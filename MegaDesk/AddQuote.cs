using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        enum Material { Laminate, Oak, Rosewood, Venner, Pine }

        public AddQuote()   
        {
            InitializeComponent();
            Array ValArray = Enum.GetValues(typeof(Material));
            foreach(Material index in ValArray)
            {
                materialBox.Items.Add(index);
            }
        }

        private void backMenuAdd_Click(object sender, EventArgs e)
        {
            Form exit = new MainMenu();
            exit.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
    }

    private void widthInput(object sender, EventArgs e)
        {
            int width;

            try
            {
                width = Convert.ToInt32(widthBox.Text);
                if (width >= 24 && width <= 96)
                {

                }
                else
                {
                    MessageBox.Show("Enter a validate Width, it should be between 24 and 96", "Message");
                    widthBox.Text = "";
                    widthBox.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Width number must be an integer", "Message");
                widthBox.Text = "";
                widthBox.Focus();
            }





        }

        private void DepthInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DepthNumber(object sender, CancelEventArgs e)
        {
            int depth;

            try
            {
                depth = Convert.ToInt32(depthBox.Text);
                if (depth >= 12 && depth <= 48)
                {

                }
                else
                {
                    MessageBox.Show("Enter a validate Depth, it should be between 12 and 48", "Message");
                    depthBox.Text = "";
                    depthBox.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Depth number is not an integer", "Message");
                depthBox.Text = "";
                depthBox.Focus();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DisplayQuote views = new DisplayQuote();
            views.customerText.Text = "Customer Name: " + customerBox.Text;
            views.widthText.Text = "Width: " + widthBox.Text;
            views.depthText.Text = "Depth: " + depthBox.Text;
            views.drawersText.Text = "Drawers: " + drawersBox.Text;
            views.materialText.Text = "Material: " + materialBox.Text;
            views.orderText.Text = "Order: " + orderBox.Text;
            views.Show();
            this.Hide();
        }
    }
}

