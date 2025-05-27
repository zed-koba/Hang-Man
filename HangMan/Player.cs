using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace HangMan
{  
    internal class Player
    {
        List<string> monstersLevel = new List<string>();
        public List<string> playerHP = new List<string>();
        public bool hurt;
        public Image player;
        public Image monster;
        public int currentLevel;
        public int playerX;
        public int playerY;
        public int monsterX;
        public int monsterY;
        public int currentPlayerHp;
        public int monsterHp;
       
        public Player(int getLevel)
        {
            playerX = 89;
            playerY = 398;
            monsterX = 889;
            monsterY = 398;
            hurt = false;
            playerHP = Directory.GetFiles("images/healthbar", "*.png").ToList();
            currentPlayerHp = 5;
            monsterHp = 0;
            currentLevel = getLevel;
            setUpPlayer();
        }

        public void setUpPlayer()
        {
            player = Image.FromFile("images/player2.gif");
            monster = Image.FromFile("images/level" + currentLevel + "/idle.gif");
        }
        public void updateHP()
        {
            currentPlayerHp -= 1;
        }
    }


}
