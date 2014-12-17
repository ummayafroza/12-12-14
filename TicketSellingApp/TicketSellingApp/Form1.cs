using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSellingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttondetails_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextBox.Text;
            int numberOfTicket = Convert.ToInt32(numberOfTicketTextBox.Text);
            int priceOFticket = 10;
            int totalPriceOfTicket = numberOfTicket*priceOFticket;
            MessageBox.Show("Cusotmer Name " + customerName + " Total Amount " + totalPriceOfTicket);
            
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            string customerName = customerNameTextBox.Text;
            int numberOfTicket = Convert.ToInt32(numberOfTicketTextBox.Text);
            int priceOFticket = 10;
            int totalPriceOfTicket = numberOfTicket * priceOFticket;
            MessageBox.Show("Cusotmer Name " + customerName + "\n Total Amount" + totalPriceOfTicket+"\n Number Of Ticket " +numberOfTicket);
            customerNameTextBox.Text = "";
            numberOfTicketTextBox.Text = "";        
        }
    }
}
