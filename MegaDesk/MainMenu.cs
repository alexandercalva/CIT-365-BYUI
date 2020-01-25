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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addNew = new AddQuote();
            addNew.Show();
            this.Hide();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            Form viewQuote = new DisplayQuote();
            viewQuote.Show();
            this.Hide();
            
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            Form searchQuote = new SearchQuotes();
            searchQuote.Show();
            
            this.Hide();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
