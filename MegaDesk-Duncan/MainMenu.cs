using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Duncan
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show();

            this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuote = new SearchQuote();
            searchQuote.Tag = this;
            searchQuote.Show();

            this.Hide();
        }

        private void btnViewAllQuotes_Click(object sender, EventArgs e)
        {
            var viewAllQuotes = new ViewAllQuotes(this);
            viewAllQuotes.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
