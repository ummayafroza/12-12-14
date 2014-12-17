using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavePersonNameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sr = new ArrayList();
        private void nameSavebutton_Click(object sender, EventArgs e)
        {

            if (personNameTextbox.Text != "")
            {
                if (sr.Count < 10)
                {
                    string personName = personNameTextbox.Text;
                    sr.Add(personName);
                    countLabel.Text = sr.Count.ToString();
                }
                if (sr.Count == 10)
                {
                    foreach (var personNameAdd in sr)
                    {
                        PersonNameListBox.Items.Add(personNameAdd);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please FIll properley");
            }
        }

        private void saveAllbutton_Click(object sender, EventArgs e)
        {
            foreach (var personNameAdd in sr)
            {
                PersonNameListBox.Items.Add(personNameAdd);
            }
        }
    }
}
