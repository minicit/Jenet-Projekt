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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panelGame.CreateGraphics();
            int startpunktx = 0;
            int startpunkty = 0;
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    g.DrawRectangle(Pens.Black, startpunktx, startpunkty, panelGame.ClientSize.Width / 8, panelGame.ClientSize.Height / 6);
                    startpunktx += panelGame.ClientSize.Width / 8;
                }
                startpunktx = 0;
                startpunkty += (panelGame.ClientSize.Height / 6) - 1;
            }
            //g.DrawLine(Pens.Black, 0, panel1.ClientSize.Height, panel1.ClientSize.Width, panel1.ClientSize.Height);
            //panel1.Refresh();
            g.Dispose();
        }
    }
}
