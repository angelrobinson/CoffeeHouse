using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_1_ProgrammingBasedOnEvents
{
    public partial class CoffeeForm : Form
    {
        //create variables to hold what user chooses
        private string size, flavor, hotCold;
        private double price, total, subtotal, qtyPrice, taxTotal;
        private int qty;
        private static double tax = 0.06; //set tax at 6%


        private void addButton_Click(object sender, EventArgs e)
        {
            //update receipt to show new item ordered
            receiptBox.AppendText($"{qty}  {size}  {hotCold}  {flavor}  {qtyPrice:C}\n");
            //update subtotal to inclue new item ordered
            subtotal += qtyPrice;
        }

        private void finalButton_Click(object sender, EventArgs e)
        {
            addButton.Enabled = false; //disable addButton so no new items can be added after finalizing
            taxTotal = subtotal * tax; //calculate total tax
            total = subtotal + tax; //calculate total

            //format the finalization of the receipt
            receiptBox.AppendText("________________\n");
            receiptBox.AppendText($"Subtotal:       {subtotal:C}\n");
            receiptBox.AppendText($"Tax:              {taxTotal:C}\n");
            receiptBox.AppendText("________________\n");
            receiptBox.AppendText($"Total:          {total:C}\n");
        }

        private void newButton_Click(object sender, EventArgs e)
        {
           
            //refresh form and reset defaults
            SetDefaults();
            UpdateQtyPrice();
            receiptBox.Text = "";
            addButton.Enabled = true;
            Application.DoEvents();

        }

        public CoffeeForm()
        {
            InitializeComponent();
            SetDefaults();
            
            
        }

        private void SetDefaults()
        {
            //default values of input
            size = "small";
            flavor = "black";
            hotCold = "hot";
            qty = 0;
            price = 1.0;
            tax = 0.06;
            qtyTextBox.Text = "1";
            flavorsDrop.SelectedIndex = 0;
            total = subtotal = qtyPrice = taxTotal = 0.0;
            hotRadio.Checked = true;
            smallRadio.Checked = true;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit applcation when exit button clicked
            Application.Exit();
        }

        private void flavorsDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set flavor choice
            flavor = flavorsDrop.Text;
        }

        private void qtyTextBox_TextChanged(object sender, EventArgs e)
        { 
            UpdateQtyPrice();
        }

        private void UpdateQtyPrice()
        {
            //verify quantity is a valid number and update the quantity price
            CheckQuantity();
            qtyPrice = price * qty;
        }

        private void CheckQuantity()
        {
            //validate if valid number and if greater than zero
            if (int.TryParse(qtyTextBox.Text, out qty))
            {
                if (qty <= 0)
                {
                    MessageBox.Show("The quantity entered needs to be greater than zero (0). \nPlease try again");
                }
                
            }
            else
            {
                MessageBox.Show("The quantity entered is not a valid number. \nPlease put in how many cups of this coffee you would like.");
            }
        }

        private void HotCold_CheckChanged(object sender, EventArgs e)
        {
            //set hotCold variable based on which radio button the user has picked: hot or iced
            if (sender == hotRadio)
            {
                hotCold = hotRadio.Text;
            }
            else
            {
                hotCold = icedRadio.Text;
            }
        }

        private void Size_CheckChanged(object sender, EventArgs e)
        {
            //set single price of coffee based on which size radio button is selected
            if (sender == smallRadio)
            {
                size = smallRadio.Text;
                price = 1.0;
            }
            else if (sender == medRadio)
            {
                size = medRadio.Text;
                price = 1.5;
            }
            else
            {
                size = largeRadio.Text;
                price = 2.0;
            }

            UpdateQtyPrice();
            
        }

    }
}
