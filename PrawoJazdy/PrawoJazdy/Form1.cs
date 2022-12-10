using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrawoJazdy
{
    public partial class Form1 : Form
    {
        bool moveleft, moveright, moveup, movedown;

        int speed = 5;
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void ruszanie(object sender, EventArgs e)
        {
            if(moveleft == true && Kierowca.Left > 0)
            {
                Kierowca.Left -= speed;
            }
            if (moveright == true && Kierowca.Left < 650)
            {
                Kierowca.Left += speed;
            }
            if (moveup == true && Kierowca.Top > 0)
            {
                Kierowca.Top -= speed;
            }
            if (movedown == true && Kierowca.Top < 400)
            {
                Kierowca.Top += speed;
            }
        }
        private void CzasMierz(object sender, EventArgs e)
        {  
            stopwatch.Start();
            Stoperek.Text = "Czas: " + stopwatch.ElapsedMilliseconds/1000;

            if(stopwatch.ElapsedMilliseconds / 1000>20)
            {
                Stoperek.Text = "Koniec" ;
            }
        }

        private void Kierowca_Click(object sender, EventArgs e)
        {

        }

        private void Sam1_ster(object sender, EventArgs e)
        {
            Sam1.Left -= 1;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                movedown = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                moveup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                movedown = false;
            }
        }
         
    }
}
