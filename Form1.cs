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
            //age = Convert.ToInt32(TxtAge.Text);
            if (Int32.TryParse(TxtAge.Text, out age) && age > 18)
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
    }
}
