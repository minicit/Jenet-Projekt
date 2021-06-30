using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jenet_Projekt
{
    public partial class UseItem : Form
    {
        public int returnvalue { get; set; }
        public UseItem()
        {
            InitializeComponent();
        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            returnvalue = 1;
            this.Close();
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            returnvalue = 2;
            this.Close();
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            returnvalue = 3;
            this.Close();
        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            returnvalue = 4;
            this.Close();
        }
    }
}
