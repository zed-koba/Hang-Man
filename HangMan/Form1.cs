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
    public partial class Form1 : Form
    {
        public bool levelFormShowed;
        Levels openLevels;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Parent = pbBackground;
            pictureBox2.BackColor = Color.Transparent;
            pbAdventure.Parent = pbBackground;
            pbAdventure.BackColor = Color.Transparent;
            pbSettings.Parent = pbBackground;
            pbSettings.BackColor = Color.Transparent;
            pbExit.Parent = pbBackground;
            pbExit.BackColor = Color.Transparent;
            pbCharacter.Parent = pbBackground;
            pbCharacter.BackColor = Color.Transparent;
            pbMonster.Parent = pbBackground;
            pbMonster.BackColor = Color.Transparent;
            levelFormShowed = false;
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

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void pbAdventure_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!levelFormShowed)
            {
                openLevels = new Levels(this);
                openLevels.Closed += (s, args) => this.Close();
                openLevels.Show();
            }
            else
            {
                openLevels.Show();
            }
        }
    }
}
