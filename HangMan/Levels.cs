using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Levels : Form
    {
        Form1 mainMenu;
        Form2 newGame;
        public Levels(Form1 getMainMenu)
        {
            InitializeComponent();
            mainMenu = getMainMenu;
            pbLevel1.Parent = pbBackground;
            pbLevel1.BackColor = Color.Transparent;
            pbLevel2.Parent = pbBackground;
            pbLevel2.BackColor = Color.Transparent;
            pbLevel3.Parent = pbBackground;
            pbLevel3.BackColor = Color.Transparent;
            pbLevel4.Parent = pbBackground;
            pbLevel4.BackColor = Color.Transparent;
            pbLevel5.Parent = pbBackground;
            pbLevel5.BackColor = Color.Transparent;
            pbMonster.Parent = pbBackground;
            pbMonster.BackColor = Color.Transparent;
            pbMonster2.Parent = pbBackground;
            pbMonster2.BackColor = Color.Transparent;
            pbMonster2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            pbMonster3.Parent = pbBackground;
            pbMonster3.BackColor = Color.Transparent;
            pbMonster4.Parent = pbBackground;
            pbMonster4.BackColor = Color.Transparent;
            pbMonster5.Parent = pbBackground;
            pbMonster5.BackColor = Color.Transparent;
            pbMonster5.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbLevel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newGame = new Form2(mainMenu, this, 1);
          
            newGame.ShowDialog();
        }

        private void pbLevel2_Click(object sender, EventArgs e)
        {

            this.Hide();
            newGame = new Form2(mainMenu, this, 2);
          
            newGame.ShowDialog();
        }

        private void pbLevel5_Click(object sender, EventArgs e)
        {
            this.Hide();
            newGame = new Form2(mainMenu, this, 5);
           
            newGame.ShowDialog();
        }

        private void pbLevel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            newGame = new Form2(mainMenu, this, 4);
           
            newGame.ShowDialog();
        }

        private void pbLevel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            newGame = new Form2(mainMenu, this, 3);
      
            newGame.ShowDialog();
        }
    }
}
