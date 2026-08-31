using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Repeated_Number__Question_And_Answer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        // Création du Label
        static Random rnd = new Random();
        int[] Arr = new int[25];
        int RanNumber = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            GetNumberArr();
            RanNumber = RandomNumber(0, 9);
            label28.Text = RanNumber.ToString();
        }
        int RandomNumber(int From, int To)
        {
            // Generate a random number between 0 and (To - From), then add From to shift the range.
            int randNum = rnd.Next() % (To - From + 1) + From;
            return randNum;
        }
        
        int[] GetRandomNumber()
        {
          for(int i = 0; i < 25; i++)
             Arr[i] = RandomNumber(0, 9);
           return Arr; 


        }
        bool VerifiedCountNumber(int NbrCheck)
        {
            int count = 0;
            for(int i = 0;i < Arr.Length; i++)
            {
                if (Arr[i] == RanNumber)
                {
                    count++;
                }
            }
            return (count == NbrCheck) ? true : false;
        }
        void ResCheck(int NbrCheck)
        {

            bool Res = VerifiedCountNumber(NbrCheck);
            if (Res)
            {
                lbRes.Text = "Right :-)";
                lbRes.ForeColor = Color.Green;

            }
            else
            {
                lbRes.Text = "Wrong :-(";
                lbRes.ForeColor = Color.Red;
            }
       

        }
        void GetNumberArr()
        {
            Arr = GetRandomNumber();

            label3.Text = Arr[0].ToString();
            label4.Text = Arr[1].ToString();
            label5.Text = Arr[2].ToString();
            label6.Text = Arr[3].ToString();
            label7.Text = Arr[4].ToString();
            label8.Text = Arr[5].ToString();
            label9.Text = Arr[6].ToString();
            label10.Text = Arr[7].ToString();
            label11.Text = Arr[8].ToString();
            label12.Text = Arr[9].ToString();
            label13.Text = Arr[10].ToString();
            label14.Text = Arr[11].ToString();
            label15.Text = Arr[12].ToString();
            label16.Text = Arr[13].ToString();
            label17.Text = Arr[14].ToString();
            label18.Text = Arr[15].ToString();
            label19.Text = Arr[16].ToString();
            label20.Text = Arr[17].ToString();
            label21.Text = Arr[18].ToString();
            label22.Text = Arr[19].ToString();
            label23.Text = Arr[20].ToString();
            label24.Text = Arr[21].ToString();
            label25.Text = Arr[22].ToString();
            label26.Text = Arr[23].ToString();
            label27.Text = Arr[24].ToString();
        }
        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // BackColor = Color.FromArgb(51, 153, 255);
            GetNumberArr();
            RanNumber = RandomNumber(0, 9);
            label28.Text = RanNumber.ToString();
            lbRes.Text = "";
            tB1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MyName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            ResCheck(int.Parse(tB1.Text));
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
