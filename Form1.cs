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
                                    LblAnswer.Text = "You are a Toddler";
                            }
                            else
                                LblAnswer.Text = "You are a Child";
                        }
                        else
                            LblAnswer.Text = "You are a Preteen";
                    }
                    else
                        LblAnswer.Text = "You are a Teen";
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
            int Catagory;
            if (Int32.TryParse(TxtHurricane.Text, out Catagory))
            {
                if (1 <= Catagory && Catagory <= 5)
                {
                    switch (Catagory)
                    {
                        case 1:
                            LblHurricaneAnswer.Text = "74-95 mph or 64-82 kt or 119-153 kph";
                            break;
                        case 2:
                            LblHurricaneAnswer.Text = "96-110 mph or 83-95 kt or 154-177 kph";
                            break;
                        case 3:
                            LblHurricaneAnswer.Text = "111-130 mph or 96-113 kt or 178-209 kph";
                            break;
                        case 4:
                            LblHurricaneAnswer.Text = "131-155 mph or 114-135 kt or 210-249 kph";
                            break;
                        case 5:
                            LblHurricaneAnswer.Text = "Greater than 155 mph or 135 kt or 249 kph";
                            break;
                    }

                }
                else
                    LblHurricaneAnswer.Text = "Enter an Integer between 1 and 5";
            }
            else
                LblHurricaneAnswer.Text = "Error: Enter Integer";
                
        }
    }
}
