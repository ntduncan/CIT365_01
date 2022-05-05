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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)this.Tag).Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDownDepth_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
