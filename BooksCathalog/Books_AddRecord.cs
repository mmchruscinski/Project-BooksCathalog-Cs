using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksCathalog
{
    public partial class Books_AddRecord : Form
    {
        public Books_AddRecord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBook(object sender, EventArgs e)
        {
            MessageBox.Show("The record has been added!", "Message", MessageBoxButtons.OK);
        }
    }
}
