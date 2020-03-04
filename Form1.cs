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
    public partial class Part_5 : Form
    {
        int age;
        int minimum;
        int maximum;
        int answer;
        int divider;
        public Part_5()
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


            //Random rand1 = new Random();
            //if (Int32.TryParse(TxtMinimum.Text, out minimum))
            //{
            //    if (Int32.TryParse(TxtMaximum.Text, out maximum))
            //    {
            //        answer = rand1.Next(minimum, maximum);
            //        LblAnswerRandom.Text = ($"Random Integer: {answer}");
            //    }
            //    else
            //        LblAnswerRandom.Text = "Error: Enter Correct Data Type";
            //}
            //else
            //    LblAnswerRandom.Text = "Error: Enter Correct Data Type";



            //if (Int32.TryParse(TxtDivider.Text ,out divider))
            //{
            //    if (answer % divider == 0)
            //        LblAnswerDivider.Text = "Your random number is divisble by your divisor";
            //    else
            //        LblAnswerDivider.Text = "Your random number is Not divisble by your divisor";
            //}
            //else
            //    LblAnswer.Text = "Error: Enter Correct Data Type";



        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random();
            if (Int32.TryParse(TxtMinimum.Text, out minimum))
            {
                if (Int32.TryParse(TxtMaximum.Text, out maximum))
                {
                    if (maximum > minimum)
                    {
                        answer = rand1.Next(minimum, maximum);
                        LblAnswerRandom.Text = ($"Random Integer: {answer}");
                    }
                    else
                        LblAnswerRandom.Text = "Error: Minimum cannot be greater than Maximum";
                }
                else
                    LblAnswerRandom.Text = "Error: Enter Correct Data Type";
            }
            else
                LblAnswerRandom.Text = "Error: Enter Correct Data Type";

        }

        private void BtnDivisble_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(TxtDivider.Text, out divider))
            {
                if (divider != 0 && answer % divider == 0)
                    LblAnswerDivider.Text = "Your random number is divisble by your divisor";
                else
                    LblAnswerDivider.Text = "Your random number is Not divisble by your divisor";
            }
            else
                LblAnswerDivider.Text = "Error: Enter Correct Data Type";

        }
    }
}
