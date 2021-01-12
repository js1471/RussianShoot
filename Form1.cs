using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace RussianShoot
{
    public partial class Russian : Form
    {
        public Russian()
        {
            InitializeComponent();
        }
        //making class 
        Classshoot myclass = new Classshoot();                                                                                                                int bullet; int point; int Life;

        //Gun loading function
        private void btnLoadGun_Click(object sender, EventArgs e)
        {//method are calling from class for load the bullet
            txtResult.Text = myclass.loadbullet(Convert.ToInt32(txtStore.Text),out int mybullet, out int life);
            {
                txtStore.Text = Convert.ToString(mybullet);
                txtChance.Text = Convert.ToString(life);
                Life = Convert.ToInt32(life);
                //button enable and disable status
                btnHeadShoot.Enabled = false;
                btnShootOut.Enabled = false;
                btnSpinShot.Enabled = true;

            }
        }
        //restart button
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
        //spinshot button for spin the bullet in the gun as random place
        private void btnSpinShot_Click(object sender, EventArgs e)
        {
            txtResult.Text = myclass.spinshot(out int myrandom);
                {
                txtStore.Text = Convert.ToString(myrandom);
                bullet = Convert.ToInt32(txtStore.Text);
            }

            //button enable and disable status
            btnHeadShoot.Enabled = true;
            btnShootOut.Enabled = true;
        }

        //quit button for quick exit the game 
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // headshoot button for fire at heatshot
        private void btnHeadShoot_Click(object sender, EventArgs e)
        {
            
            bullet--;
           
            txtStore.Text = bullet.ToString();
           
            SoundPlayer shoot = new SoundPlayer(Properties.Resources.shoot);
            shoot.Play();
            txtResult.Text = "........Bullet Fired........";
           
             if (bullet == 0)
            {
                btnHeadShoot.Enabled = false;
                btnShootOut.Enabled = false;
                btnSpinShot.Enabled = false;
                btnLoadgun.Enabled = false;
                txtResult.Text = "You losse";


            }
        }
        // shootaway button for safe life there have 2 chances for safe life 
        private void btnShootOut_Click(object sender, EventArgs e)
        {
            Life--;
            txtChance.Text = Life.ToString();
            SoundPlayer shootaway = new SoundPlayer(Properties.Resources.shootaway);
            shootaway.Play();
            if (Life== 1) { txtResult.Text = "You Have only one Chance for safe yourself"; }
            if (Life == 0)
            {
                btnHeadShoot.Enabled = false;
                btnShootOut.Enabled = false;
                btnSpinShot.Enabled = false;
                btnLoadgun.Enabled = false;
                txtResult.Text = "You losse";

            }
            else if (bullet > 2) {
                btnShootOut.Enabled = false; btnHeadShoot.Enabled = false;
                txtResult.Text = " Congratulation ! You Win";
            }
        }
        // loading form fuction
        private void Russian_Load(object sender, EventArgs e)
        {
            btnHeadShoot.Enabled = false;
            btnSpinShot.Enabled = false;
            btnShootOut.Enabled = false;

        }
    }
}
