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
        string[] cardnumbers = { "cardbtn1", "cardbtn2", "cardbtn3", "cardbtn4", "cardbtn5", "cardbtn6", "cardbtn7", "cardbtn8" };
        int[] cardpictures = {1, 3, 2, 1, 3, 4, 2, 4 };

        //public string cardpic1 = "Verdwijnt_de_koe_uit_ons_landschap_";
        //public string cardpic2 = "Wat_je_kan_leren_van_een_kip___Hilde_Schoonjans";
        //public string cardpic3 = "Dries_en_ik___Verhalen_van_vroege_r_";
        //public string cardpic4 = "Goofy_Horse___Horses__Animals__Roman";
      
        private void Cardturn(Button btn)
        {
            
            cardCheck += 1f;
            if (cardCheck >= 2f)
            {
                cardCheck = 0f;
                cardbtn1.BackgroundImage = null;
                cardbtn2.BackgroundImage = null;
                cardbtn3.BackgroundImage = null;
                cardbtn4.BackgroundImage = null;
                cardbtn5.BackgroundImage = null;
                cardbtn6.BackgroundImage = null;
                cardbtn7.BackgroundImage = null;
                cardbtn8.BackgroundImage = null;
            }

            for (int i = 0; i < cardnumbers.Length; i++) 
            {
                if (cardnumbers[i] == btn.ToString())
                {

                    if (cardpictures[i] == 1)
                    {
                        btn.BackgroundImage = Properties.Resources.Verdwijnt_de_koe_uit_ons_landschap_;
                    }


                }
            }
            //btn.BackgroundImage = Properties.Resources.Verdwijnt_de_koe_uit_ons_landschap_;
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
        private void cardbtn4_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn4);
        }

        private void cardbtn5_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn5);
        }

        private void cardbtn6_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn6);
        }

        private void cardbtn7_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn7);
        }

        private void cardbtn8_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn8);
        }
    }
}
