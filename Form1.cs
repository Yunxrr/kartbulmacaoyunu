using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartbulmacaoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //fil
            fil.BackgroundImage = Properties.Resources.filyavrusu;
            await Task.Delay(2000);
            if (fil.BackgroundImage == Properties.Resources.filyavrusu && fill.BackgroundImage == Properties.Resources.filyavrusu)
            {
                MessageBox.Show("Tebrikler! Eşleşme bulundu.");
                fil.BackgroundImage = Properties.Resources.filyavrusu;
                fill.BackgroundImage = Properties.Resources.filyavrusu;
            }
            fil.BackgroundImage = null;


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //zurafa
            zurafa.BackgroundImage = Properties.Resources.zürafa;
            await Task.Delay(2000);
            zurafa.BackgroundImage = null;
            if (zurafa.BackgroundImage == Properties.Resources.zürafa && zurafaa.BackgroundImage == Properties.Resources.zürafa)
            {
                MessageBox.Show("Tebrikler! Eşleşme bulundu.");
                zurafa.BackgroundImage = Properties.Resources.zürafa;
                zurafaa.BackgroundImage = Properties.Resources.zürafa;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            //aslan
            aslan.BackgroundImage = Properties.Resources.aslan;
            await Task.Delay(2000);
            aslan.BackgroundImage = null;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            //tilki
            tilkii.BackgroundImage = Properties.Resources.tilki;
            await Task.Delay(2000);
            tilkii.BackgroundImage = null;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            //kopek
            kopek.BackgroundImage = Properties.Resources.ekmekreiskopek;
            await Task.Delay(2000);
            kopek.BackgroundImage = null;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            //kedi
            kedi.BackgroundImage = Properties.Resources.kedi;
            await Task.Delay(2000);
            kedi.BackgroundImage = null;        
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            //fil
            fill.BackgroundImage = Properties.Resources.filyavrusu;
            await Task.Delay(2000);
            if (fil.BackgroundImage == Properties.Resources.filyavrusu && fill.BackgroundImage == Properties.Resources.filyavrusu)
            {
                MessageBox.Show("Tebrikler! Eşleşme bulundu.");
                fil.BackgroundImage = Properties.Resources.filyavrusu;
                fill.BackgroundImage = Properties.Resources.filyavrusu;
            }
            fill.BackgroundImage = null;
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            //kopek
            kopekk.BackgroundImage = Properties.Resources.ekmekreiskopek;
            await Task.Delay(2000);
            kopekk.BackgroundImage = null;
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            //yunus
            yunus.BackgroundImage = Properties.Resources.yunus;
            await Task.Delay(2000);
            yunus.BackgroundImage = null;
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            //zurafa
            zurafaa.BackgroundImage = Properties.Resources.zürafa;
            await Task.Delay(2000);
            zurafaa.BackgroundImage = null;
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            //panda
            panda.BackgroundImage = Properties.Resources.istockphoto_1195743934_612x612;
            await Task.Delay(2000);
            panda.BackgroundImage = null;
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            //kedi
            kedii.BackgroundImage = Properties.Resources.kedi;
            await Task.Delay(2000);
            kedii.BackgroundImage = null;
        }

        private async void button13_Click(object sender, EventArgs e)
        {
            //yunus
            yunuss.BackgroundImage = Properties.Resources.yunus;
            await Task.Delay(2000);
            yunuss.BackgroundImage = null;
        }

        private async void button14_Click(object sender, EventArgs e)
        {
            //tilki
            tilki.BackgroundImage = Properties.Resources.tilki;
            await Task.Delay(2000);
            tilki.BackgroundImage = null;
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            //aslan
            aslannn.BackgroundImage = Properties.Resources.aslan;
            await Task.Delay(2000);
            aslannn.BackgroundImage = null;
        }

        private async void button16_Click(object sender, EventArgs e)
        {
            //panda
            pandaa.BackgroundImage = Properties.Resources.istockphoto_1195743934_612x612;
            await Task.Delay(2000);
            pandaa.BackgroundImage = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
