using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsInheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetNumCheckBoxesChecked();
        }

        /// <summary>
        /// Determine how many checkboxes on the form have been checked
        /// </summary>
        /// <returns></returns>
        private int GetNumCheckBoxesChecked()
        {
            int numChecked = 0;
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox currBox = c as CheckBox;
                    if (currBox.Checked)
                    {
                        numChecked++;
                    }
                }
            }
            MessageBox.Show($"You checked {numChecked}");
            return numChecked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // if you need it dynamic you do it through code

            Button myButton = new Button();
            myButton.Text = "Click This!!!";
            myButton.Size = new Size(100, 35);
            myButton.Location = new Point(50, 250);
            myButton.Click += new System.EventHandler(MyBtnClick);

            this.Controls.Add(myButton);
        }

        private void MyBtnClick(object s, EventArgs e)
        {
            MessageBox.Show("We completed this example...");
        }
    }
}
