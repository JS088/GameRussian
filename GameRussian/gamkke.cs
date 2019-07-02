using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Media;
using System.IO;

namespace GameRussian
{
    public partial class gamkke : Form
    {
        public gamkke()
        {
            InitializeComponent();
        }
        gun objectgun = new gun();
        
         
        int bullets=6;
        int chance=2;
        int k;
        Random objran = new Random();
        //
        private void btnload_Click(object sender, EventArgs e)
            //calling load function from gun class
        {
            btnspin.Enabled = true;
            btnload.Enabled = false;
            pictureBox1.Visible = true;
            objectgun.loadbullete = 1;
            //this plays the gif
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("GameRussian.Resource1.load.gif");
            SoundPlayer player = new SoundPlayer(Resource1.load1);
            player.Play();

        }

        private void btnspin_Click(object sender, EventArgs e)
        //calling btnspin function from gun class
        {
            //this plays the gif
            k = objran.Next(1, 7);
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            //Stream mystream = myAssembly.GetManifestResourceStream("GameRussian.Resource1.spin.gif");
            Bitmap bmp1 = new Bitmap(Resource1.spin); 
           // Bitmap bmp = new Bitmap(mystream);
            pictureBox1.Image = bmp1;
            SoundPlayer player = new SoundPlayer(Resource1.spin1);
            player.Play();
            btnshoot.Enabled = true;
            btnspin.Enabled = false;
        }

        private void btnshoot_Click(object sender, EventArgs e)
        //calling btnshoot function from gun class
        {
            //this plays the gif
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("GameRussian.Resource1.sh.gif");
            
            SoundPlayer player = new SoundPlayer(Resource1.shoot);
            player.Play();
            bullets = bullets - 1;
            if(bullets>0 && k==1)
            {
                MessageBox.Show("shoot you loose");
                btnshoot.Enabled = false;

            }
            if (bullets == 0)
            {
                MessageBox.Show("you are out of bullets");
                buttonsa.Enabled = false;
                btnshoot.Enabled = false;
                btnspin.Enabled = false;
                btnload.Enabled = false;

            }
            if(k!=1)
            {
                MessageBox.Show("blank fire");
               k= objectgun.bulletespin(k);
                  
            }

        }
//C:\Users\Jugraj Singh\Desktop\GameRussian\GameRussian\Program.cs
        private void btnRetry_Click(object sender, EventArgs e)
      
        {

            (new gamkke()).Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bullets = 6;
            chance = 2;
        }

        private void Buttonsa_Click(object sender, EventArgs e)
        //calling Buttonsa function from gun class

        {
            if (bullets > 0 && k == 1)
            {
                if (chance == 2)
                {
                    MessageBox.Show("win your score is 100");
                }
                if (chance == 1)
                {
                    MessageBox.Show("win your score is 50");
                }
            }
            if (chance == 0)
            {
                MessageBox.Show("you loose");
                buttonsa.Enabled = false;
            }
            else
            {
                k = objectgun.bulletespin(k);
                chance = chance - 1;
                MessageBox.Show("blank fire");
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
