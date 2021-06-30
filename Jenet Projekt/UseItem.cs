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
        public UseItem(int[] itemArray)
        {
            InitializeComponent();
            this.CenterToParent();
            if (itemArray[0] == 0)
                this.btnItem1.Enabled = false; 
            if (itemArray[1] == 0)
                this.btnItem2.Enabled = false; 
            if (itemArray[2] == 0)
                this.btnItem3.Enabled = false; 
            if (itemArray[3] == 0)
                this.btnItem4.Enabled = false;
        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            returnvalue = 0;
            this.Close();
        }

        private void btnItem2_Click(object sender, EventArgs e)
        {
            returnvalue = 1;
            this.Close();
        }

        private void btnItem3_Click(object sender, EventArgs e)
        {
            returnvalue = 2;
            this.Close();
        }

        private void btnItem4_Click(object sender, EventArgs e)
        {
            returnvalue = 3;
            this.Close();
        }
    }
}
