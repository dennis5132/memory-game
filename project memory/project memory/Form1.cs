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
        private float cardCheck = 0f;
        private void Cardturn(Button btn)
        {
            
            cardCheck += 1f;
            if (cardCheck == 3f)
            {
                cardCheck = 0f;
                cardbtn1.BackgroundImage = null;
                cardbtn2.BackgroundImage = null;
                cardbtn3.BackgroundImage = null;
            }
            btn.BackgroundImage = Properties.Resources.Verdwijnt_de_koe_uit_ons_landschap_;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void cardClick1(object sender, EventArgs e)
        {
            Cardturn(cardbtn1);
        }

        private void cardbtn2_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn2);
        }
        private void cardbtn3_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn3);
        }

        
    }
}
