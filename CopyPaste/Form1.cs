using System;
using System.Windows.Forms;

namespace CopyPaste
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

         private string message1 = "", message2 = "", message3 = "", message4 = "", message5 = "", message6 = "";

        public void setMessage1(string message) 
         {
            message1 = message;
         }

        public void setMessage2(string message)
        {
            message2 = message;
        }

        public void setMessage3(string message)
        {
            message3 = message;
        }

        public void setMessage4(string message)
        {
            message4 = message;
        }

        public void setMessage5(string message)
        {
            message5 = message;
        }

        public void setMessage6(string message)
        {
            message6 = message;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
                {

                    if (radioButton1.Checked)
                    {
                        button1.Text = nameBox.Text;
                        setMessage1(MainTextArea.Text);
                    }

                    else if (radioButton2.Checked)
                    {
                        button2.Text = nameBox.Text;
                        setMessage2(MainTextArea.Text);
                    }

                    else if (radioButton3.Checked)
                    {
                        button3.Text = nameBox.Text;
                        setMessage3(MainTextArea.Text);
                    }

                    else if (radioButton4.Checked)
                    {
                        button4.Text = nameBox.Text;
                        setMessage4(MainTextArea.Text);
                    }

                    else if (radioButton5.Checked)
                    {
                        button5.Text = nameBox.Text;
                        setMessage5(MainTextArea.Text);
                    }

                    else if (radioButton6.Checked)
                    {
                        button6.Text = nameBox.Text;
                        setMessage6(MainTextArea.Text);
                    }
            
        }

                private void button1_Click(object sender, EventArgs e)
                {
                      Clipboard.SetText(message1);
                }

                private void button2_Click(object sender, EventArgs e)
                {
                    Clipboard.SetText(message2);
                }

                 private void button3_Click(object sender, EventArgs e)
                {
                     Clipboard.SetText(message3);
                }

                private void button4_Click(object sender, EventArgs e)
                {
                      Clipboard.SetText(message4);
                }

                private void button5_Click(object sender, EventArgs e)
                {
                     Clipboard.SetText(message5);
                }

                private void button6_Click(object sender, EventArgs e)
                {
                     Clipboard.SetText(message6);
                }

    }
}
