using HangMan.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HangMan
{
   
    public partial class Form2 : Form
    {
        Player player;
        Image backgroundImage;
        List<string> backgroundUrls = new List<string>();
        int levels;
        int playerTotalFrame, monsterTotalFrame;
        double num, numDying;
        int score = 0;
        Levels levelForm;
        Form1 mainMenu;

        string[] levelsWord = new string[] {"event", "lambdas", "windows form", "control  properties", "language  integrated-query" };
        string[] levelsClue = new string[] { "occurrence of interest", "handle events", "graphical user interface (GUI)",
        "refer to the attributes", "allows developers to query data"};
        List<char> guessedLetter = new List<char>();
        int numOfLetters, numOfHits;
        bool attackRight, attackLeft;
        bool playerAttackOngoing, monsterAttackOngoing;
        bool retreating;
        bool hurt;
        bool proceedNextLevel;
        bool monsterDying, monsterDead, playerDead;
        public Form2(Form1 getMainMenu, Levels getLevelForm, int getLevel)
        {
            InitializeComponent();
            player = new Player(getLevel);
            numOfHits = 0;         
            proceedNextLevel = false;
            monsterDying = false;
            playerDead = false;
            levelForm = getLevelForm;
            mainMenu = getMainMenu;
            levels = getLevel;
            lblLevel.Text = levels.ToString();
            setUpForm();
            createWord();
            calcNumOfLetters();
            lblClue.Text = levelsClue[levels - 1];
           
            
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
            this.Update();
            Refresh();
            ImageAnimator.UpdateFrames();
            playerAtMonster();
            monsterAtplayer();
            if (playerAttackOngoing)
            {
                if (num < playerTotalFrame)
                {
                    num += 1.6f;
                }
                if (num >= playerTotalFrame)
                {
                    if (retreating)
                    {
                        player.player = Image.FromFile("images/player2retreating.gif");
                        player.monster = Image.FromFile("images/level" + levels + "/hurt.gif");
                        setUpAnimation();
                        num = playerTotalFrame;
                        numOfHits++;
                    }
                    playerResetPosition();
                    retreating = false;
                }
            }
            if (monsterAttackOngoing)
            {
                if (num < monsterTotalFrame)
                {
                    num +=1.6f;
                }
                if (num >= monsterTotalFrame)
                {
                    if (retreating)
                    {
                        player.monster = Image.FromFile("images/level" + levels + "/retreating.gif");
                        player.player = Image.FromFile("images/player2hurt.gif");
                        setUpAnimation();
                        num = monsterTotalFrame;
                        player.updateHP();
                        hurt = true;
                    }
                    monsterResetPosition();
                    retreating = false;

                }
            }
            if (hurt && player.currentPlayerHp != 0)
            {
                pbHealth.Image = Image.FromFile(player.playerHP[player.currentPlayerHp - 1]);
                hurt = false;
            }
            else if (player.currentPlayerHp == 0 && playerDead == false)
            {
                player.player = Image.FromFile("images/dying.gif");
                setUpAnimation();
                playerDead = true;
                btnNextLevel.Visible = true;
                btnNextLevel.Text = "Restart";
                btnNextLevel.Left = 465;
                pbLevelClearFail.Visible = true;
                pbLevelClearFail.Image = Resources.Level_Failed;
                lblOpacity.Visible = true;
                lblOpacity.Text = "Boooo! You lose.";
            }

            if (numOfHits == numOfLetters)
            {
                player.monster = Image.FromFile("images/level" + levels + "/dying.gif");
                setUpAnimation();
                monsterDying = true;
                monsterDead = true;
                numOfHits = 0;
                player.monsterY = 370;
            }
            if (monsterDying)
            {
                if (numDying < monsterTotalFrame)
                {
                    numDying += 1.6f;
                }
                if (numDying >= monsterTotalFrame)
                {
                    player.monster = Image.FromFile("images/level" + levels + "/dead.gif");
                    monsterDying = false;
                    proceedNextLevel = true;
                    numDying = 0;                 
                    btnNextLevel.Visible = true;
                    btnNextLevel.Text = "Next Level >>";
                    btnNextLevel.Left = 455;
                    pbLevelClearFail.Visible = true;
                    pbLevelClearFail.Image = Resources.Clear_reward_;
                    btnNextLevel.BringToFront();
                    lblOpacity.Visible = true;
                    lblOpacity.Text = "Congratulations! You won.";
                    pbPause.Enabled = false;
                }
            }

        }

        private void FormGamePaint_Event(object sender, PaintEventArgs e)
        {


            e.Graphics.DrawImage(backgroundImage, new Point(0, 25));
            e.Graphics.DrawImage(player.player, new Point(player.playerX, player.playerY));
            e.Graphics.DrawImage(player.monster, new Point(player.monsterX, player.monsterY));

        }
        private void setUpForm()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            backgroundUrls = Directory.GetFiles("images/background", "*.png").ToList();
            backgroundImage = Image.FromFile(backgroundUrls[levels-1]);
            setUpAnimation();
        }
        private void setUpAnimation()
        {
            ImageAnimator.Animate(player.player, this.OnFrameChangedHandler);
            ImageAnimator.Animate(player.monster, this.OnFrameChangedHandler);
            FrameDimension dimensions = new FrameDimension(player.player.FrameDimensionsList[0]);
            playerTotalFrame = player.player.GetFrameCount(dimensions);
            monsterTotalFrame = player.monster.GetFrameCount(dimensions);
        }

        private void OnFrameChangedHandler(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void btnClick(Control ctrl)
        {
            if (levelsWord[levels-1].Contains(ctrl.Text.ToLower()))
            {
                lblGuessTheWord.ResetText();
                guessedLetter.Add(Convert.ToChar(ctrl.Text.ToLower()));
                foreach(char letters in levelsWord[levels-1])
                {
                    if (guessedLetter.Contains(letters))
                    {
                        lblGuessTheWord.Text += Convert.ToString(letters).ToUpper() + " ";
                        score++;
                        lblScore.Text = score.ToString();
                    }
                    else if(letters == '-')
                    {
                        lblGuessTheWord.Text += Environment.NewLine;
                    }
                    else if (!char.IsLetter(letters))
                    {
                        lblGuessTheWord.Text += "  ";
                    }
                    else
                    {
                        lblGuessTheWord.Text += "_ ";
                    }
                    
                }
                ctrl.BackColor = Color.FromArgb(239, 104, 36);
                ctrl.Enabled = false;
                playerAttack();
                lblOpacity.Visible = true;
                lblOpacity.Text = "Splendid!, Charge!.";
                lblOpacity.ForeColor = Color.FromArgb(239, 104, 36);

            }
            else
            {
                ctrl.BackColor = Color.FromArgb(239, 104, 36);
                ctrl.Enabled = false;
                monsterAttack();
                lblOpacity.Visible = true;
                lblOpacity.Text = "Bzzz!, Die you human!.";
                lblOpacity.ForeColor = Color.IndianRed;
            }
            GameTimer.Start();
        }
        private void playerAttack()
        {
            attackRight = true;
            player.player = Image.FromFile("images/player2running.gif");
            setUpAnimation();
        }
        private void playerResetPosition()
        {
            int playerX = 89;
            if(playerX <= player.playerX)
            {
                player.playerX -= 30;
                if(player.playerX <= 300 && monsterDead == false)
                {
                    player.monster = Image.FromFile("images/level" + levels + "/idle.gif");
                    setUpAnimation();
                }
            }
            if(playerX == player.playerX)
            {
                playerAttackOngoing = false;
                player.player = Image.FromFile("images/player2.gif");
                setUpAnimation();
                num = 0;
                if (monsterDead == false)
                {
                    lblOpacity.Visible = false;
                }
                GameTimer.Stop();
            }
            

        }
        private void monsterAttack()
        {
            attackLeft = true;
            player.monster = Image.FromFile("images/level" + levels + "/running.gif");
            setUpAnimation();
        }
        private void monsterResetPosition()
        {
            int monsterX = 889;
            if(monsterX >= player.monsterX)
            {
                player.monsterX += 50;
                if(player.monsterX >= 600 && playerDead == false)
                {
                    player.player = Image.FromFile("images/player2.gif");
                    setUpAnimation();  
                }
            }
            if (monsterX == player.monsterX || monsterDying == true)
            {
                monsterAttackOngoing = false;
                player.monster = Image.FromFile("images/level" + levels + "/idle.gif");
                setUpAnimation();
                num = 0;
                if (playerDead == false)
                {
                    lblOpacity.Visible = false;
                }
                
                
            }
        }
        private void playerAtMonster()
        {
            if (attackRight)
            {
                if (player.playerX < player.monsterX - player.monster.Width - 30)
                {
                    player.playerX += 30;
                   
                }
                else
                {
                    player.player = Image.FromFile("images/playeratk2.gif");
                    setUpAnimation();
                    playerAttackOngoing = true;
                    attackRight = false;
                    retreating = true;
                }

            }
        }
        private void monsterAtplayer()
        {
            if(attackLeft)
            {
                if(player.monsterX > player.playerX + player.player.Width-30)
                {
                    player.monsterX -= 50;        
                }else
                {
                    player.monster = Image.FromFile("images/level" + levels + "/attack.gif");
                    setUpAnimation();
                    monsterAttackOngoing = true;
                    attackLeft = false;
                    retreating = true;

                }
            }
        }
        private void createWord()
        {
            foreach (char letter in levelsWord[levels-1])
            {
                if (char.IsLetter(letter))
                {
                    lblGuessTheWord.Text += "_ ";
                }else if(letter == '-')
                {
                    lblGuessTheWord.Text += Environment.NewLine;
                }
                else
                {
                    lblGuessTheWord.Text += "  ";
                }
            }
        }
        private void btnNextLevel_Click(object sender, EventArgs e)
        {
            if (btnNextLevel.Text == "Next Level >>")
            {
                switch (levels)
                {
                    case 1:
                        levelForm.pbLevel1.Image = Resources.level1complete;
                        levelForm.pbLevel1.Size = new Size(83, 76);
                        levelForm.pbLevel1.Location = new Point(458, 680);
                        break;
                    case 2:
                        levelForm.pbLevel2.Image = Resources.level2complete;
                        levelForm.pbLevel2.Size = new Size(83, 76);
                        break;
                    case 3:
                        levelForm.pbLevel3.Image = Resources.level3complete;
                        levelForm.pbLevel3.Size = new Size(83, 76);
                        break;
                    case 4:
                        levelForm.pbLevel4.Image = Resources.level4complete;
                        levelForm.pbLevel4.Size = new Size(83, 76);
                        break;
                    case 5:
                        levelForm.pbLevel5.Image = Resources.level5complete;
                        levelForm.pbLevel5.Size = new Size(83, 76);
                        break;       
                }         
                this.Dispose();
                this.Close();
                levelForm.Show();
                pbPause.Enabled = true;
            }
            else if (btnNextLevel.Text == "Restart")
            {
                this.Close();
                levelForm.Show();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
            
        }
        private void btnV_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }   
        private void btnN_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pDragForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbPause_Click(object sender, EventArgs e)
        {
            btnMainMenu.Visible = true;
            btnLevels.Visible = true;
            btnCloseSetting.Visible = true;
            pbLevelClearFail.Image = Resources.pausesetting;
            pbLevelClearFail.Visible = true;
            lblOpacity.Visible = true;
            lblOpacity.Text = "Game Paused";
        }

        private void btnCloseSetting_Click(object sender, EventArgs e)
        {
            pbLevelClearFail.Visible = false;
            btnMainMenu.Visible = false;
            btnLevels.Visible = false;
            btnCloseSetting.Visible = false;
            lblOpacity.Visible = false;
        }

      

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu.levelFormShowed = true;
            mainMenu.Show();
            
        }

        private void btnLevels_Click(object sender, EventArgs e)
        {
            this.Close();
            levelForm.Show();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Control sendBtn = (Control)sender;
            btnClick(sendBtn);
        }
       private void calcNumOfLetters()
        {
            HashSet<char> uniqueLetter = new HashSet<char>();
            foreach(char letter in levelsWord[levels-1])
            {
                if (char.IsLetter(letter))
                {
                    uniqueLetter.Add(letter);
                }
            }
            numOfLetters = uniqueLetter.Count;
            lblLevel.Text = "Level " + levels;

        }

    }
}
