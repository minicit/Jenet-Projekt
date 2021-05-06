using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//panelMain
//panelGame
//panelMap
//panelInv
namespace Jenet_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelGame.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panelStart_MouseClick(object sender, MouseEventArgs e)
        {
            panelMain.Hide();
            panelGame.Show();
            panelMap.Refresh();
        }

        private void panelMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelMap.CreateGraphics();
            int startpunktx = 0;
            int startpunkty = 0;
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    g.DrawRectangle(Pens.Black, startpunktx, startpunkty, panelMap.ClientSize.Width / 10, panelMap.ClientSize.Height / 8);
                    startpunktx += panelMap.ClientSize.Width / 10;
                }
                startpunktx = 0;
                startpunkty += (panelMap.ClientSize.Height / 8) - 1;
            }
            //g.DrawLine(Pens.Black, 0, panel1.ClientSize.Height, panel1.ClientSize.Width, panel1.ClientSize.Height);
            //panel1.Refresh();
            g.Dispose();
        }

        private void panelInv_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelInv.CreateGraphics();
            int startpunktx = 0;
            int startpunkty = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    g.DrawRectangle(Pens.Black, startpunktx, startpunkty, panelInv.ClientSize.Width / 4, panelInv.ClientSize.Height / 8);
                    startpunktx += panelInv.ClientSize.Width / 4;
                }
                startpunktx = 0;
                startpunkty += (panelInv.ClientSize.Height / 8) - 1;
            }
            //g.DrawLine(Pens.Black, 0, panel1.ClientSize.Height, panel1.ClientSize.Width, panel1.ClientSize.Height);
            //panel1.Refresh();
            g.Dispose();
        }
    }
}
