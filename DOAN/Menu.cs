using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
            } else
            {
                menuVertical.Width = 250;
            }
        }
    }
}
