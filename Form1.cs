using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckySpinner
{
    public partial class Form1 : Form
    {
        public int num1, num2, num3;
        public int count = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            num1 = GetRandNo(0, 5);
            num2 = GetRandNo(6, 10);
            num3 = GetRandNo(11, 20);

            int[] myarr = new int[3] { num1, num2, num3 };


        }
        private int GetRandNo(int min, int max)
        {
            Random rand = new Random();
            int random = rand.Next(min, max);
            return random;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (txtNum.Text != "" && Convert.ToInt32(txtNum.Text)>50)
            {
                MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum.Clear();
            }
            else if (e.KeyCode == Keys.Enter && txtNum.Text != "")
            {
                GuessingProcess(Convert.ToInt32(txtNum.Text));
                txtNum.Clear();

            }
            else if(e.KeyCode==Keys.Enter && txtNum.Text == "")
            {
                MessageBox.Show("Invalid Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
               
            }
        
        }
        private void NewGame()
        {
            txtNum.Clear();
            txtNum.Enabled = true;
            count = 3;
            lblAttempt.Text = Convert.ToString(count);
            num1 = GetRandNo(0, 5);
            num2 = GetRandNo(6, 10);
            num3 = GetRandNo(11, 20);
            lblNum1.Text = "#";
            lblNum2.Text = "#";
            lblNum3.Text = "#";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblAttempt_Click(object sender, EventArgs e)
        {

        }
        private void GuessingProcess(int no)
        {
            string Message = "Sorry Game is over!";
            string title = "Bad-Luck";
          

            if (count == 0)
            {
                txtNum.Enabled = false;
             DialogResult result=   MessageBox.Show(Message, title, MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Retry)
                {
                    // NewGame method should be called here;
                    NewGame();
                }
            }
            else if (count >=1)
            {
                if (no == num1)
                {
                    lblNum1.Text = Convert.ToString(no);
                }
                else if (no == num2)
                {
                    lblNum2.Text = Convert.ToString(no);
                }
                else if (no == num3)
                {
                    lblNum3.Text = Convert.ToString(no);

                }
                else if (no != num1 || no != num2 || no != num3)
                {
                    count--;
                    lblAttempt.Text = Convert.ToString(count);
                }
                else if(lblNum1.Text==Convert.ToString(num1)&& lblNum2.Text==Convert.ToString(num2) && lblNum3.Text==Convert.ToString(num3))
                {
                 DialogResult result=MessageBox.Show("You Won the Game", "Great!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.Retry)
                    {
                        //newGame method should execute here,.
                        NewGame();
                    }
                
                
                }
            }
        }
    }
}