using Dice;
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
using System.Media;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;

namespace DiceGameForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DiceOneBtn_Click(object sender, EventArgs e)
        {

            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            
          

            Thread.Sleep(1000);
           

            DiceClassRepository diceClassRepository = new DiceClassRepository();

            var a = diceClassRepository.GetFace();

            Image img = Image.FromFile(@"C:\Users\..\source\repos\diceGame\DiceGameForm\Dices\Dice" + a + ".jpg");


            
            pictureBox7.Image = img;



        }

        private void DiceTwoBtn_Click(object sender, EventArgs e)
        {


            Thread.Sleep(1000);



            DiceClassRepository diceClassRepository = new DiceClassRepository();

            var a = diceClassRepository.GetFace();

            Image img = Image.FromFile(@"C:\Users\..\source\repos\diceGame\DiceGameForm\Dices\Dice" + a + ".jpg");


            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Image = img;





            a = diceClassRepository.GetFace();
            Image img1 = Image.FromFile(@"C:\Users\..\source\repos\diceGame\DiceGameForm\Dices\Dice" + a + ".jpg");



            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.Image = img1;








        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://twitter.com/home",
                UseShellExecute = true
            };
            Process.Start(psi);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var psi = new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=3z0IT3bXm_E",
                UseShellExecute = true
            };
            Process.Start(psi);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = " https://bobiler.org/",
                UseShellExecute = true
            };
            Process.Start(psi);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\..\source\repos\diceGame\DiceGameForm\Dices\vurgunum.wav");
            splayer.Play();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://github.com/DelifisekBetonNecmettin",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
