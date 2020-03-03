using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5_Decisions_Forum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            int age;

            if (Int32.TryParse(TxtAge.Text, out age))
            {
                if (age > 18)
                    LblAnswer.Text = "Adult";
                else if (age <= 18)
                {
                    if (age <= 12)
                    {
                        if (age <= 10)
                        {
                            if (age <= 5)
                            {
                                if (age <= 0)
                                {
                                    LblAnswer.Text = "Error: You arent born yet";
                                }

                                else
                                    LblAnswer.Text = "Toddler";
                            }
                            else
                                LblAnswer.Text = "Child";
                        }
                        else
                            LblAnswer.Text = "Preteen";
                    }
                    else
                        LblAnswer.Text = "Teen";
                }
            }
            else
                LblAnswer.Text = "Error: Enter an integer";



            //Color c = (Color)(new Random()).Next(0, 3);
            //switch (c)
            //{
            //    case Color.Red:
            //        Console.WriteLine("The color is red");
            //        break;
            //    case Color.Green:
            //        Console.WriteLine("The color is green");
            //        break;
            //    case Color.Blue:
            //        Console.WriteLine("The color is blue");
            //        break;
            //    default:
            //        Console.WriteLine("The color is unknown.");
            //        break;
            }

        private void BtnHurricane_Click(object sender, EventArgs e)
        {
            int windspeed;
            if (Int32.TryParse(TxtHurricane.Text, out windspeed))
            {
                switch (windspeed)
                {
                    case 1:
                        LblHurricaneAnswer.Text = ($"Hello");
                        break;
                    case 
                }

            }
            else
                LblHurricaneAnswer.Text = "Error: Enter Integer";
                
        }
    }
}
