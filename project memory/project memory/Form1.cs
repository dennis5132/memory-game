using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_memory
{
    
    public partial class Form1 : Form
    {
        float cardcheck = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void cardClick1(object sender, EventArgs e)
        {
            cardbtn1.BackgroundImage = Properties.Resources.Verdwijnt_de_koe_uit_ons_landschap_;

          
        }

        private void cardbtn2_Click(object sender, EventArgs e)
        {
            cardbtn2.BackgroundImage = Properties.Resources.Verdwijnt_de_koe_uit_ons_landschap_;
        }
        
    }
}
