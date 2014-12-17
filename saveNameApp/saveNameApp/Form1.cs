using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saveNameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] name = new string[10];
         int i=0;
        private void showAllNameButton_Click(object sender, EventArgs e)
        {
            
            nameListBox.Items.Clear();
            for (int j = 0; j < i; j++)
            {
                nameListBox.Items.Add(name[j]);

            }

        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {
            if (nameInputTextBox.Text != string.Empty)
            {
                if (i < 10)
                {
                    name[i] = nameInputTextBox.Text;
                    i++;

                    countNameTextBox.Text = Convert.ToString(i);
                    nameInputTextBox.Clear();
                    if (i == 10)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            nameListBox.Items.Add(name[j]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("maximum.");
                }
            }
            else
            {
                MessageBox.Show("Enter name");
            }

            

        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
