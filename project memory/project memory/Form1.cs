using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_memory
{
    
    public partial class Form1 : Form
    {
        private float cardCheck = 0f; // hoeveel kaarten er worden bekeken
        string[] cardnumbers = { "cardbtn1", "cardbtn2", "cardbtn3", "cardbtn4", "cardbtn5", "cardbtn6", "cardbtn7", "cardbtn8" }; //checken welke knop bij welk plaatje in de lijst eronder ligt
        
        List<int> picturelist = new List<int>{1, 1, 2, 2, 3, 3, 4, 4};
        List<int> cardpictures = new List<int>(); // waar verschillende plaatjes liggen

        private Button firstpicture;
        List<Button> correct = new List<Button>();

        public int pictureOne;
        public int pictureTwo;

        Random random = new Random();
        int timerLength = 0;
        SoundPlayer player = new SoundPlayer();

        public int currentTurn = 1;
        public int currentPoints = 0;

        private void resetCard(Button thisB)
        {
            if (correct.Contains(thisB) == false)
            {
                thisB.BackgroundImage = null;
            }
        }
        private void Cardturn(Button btn) //activeert als er op een knop wordt gedrukt
        {   
            if (resetTimer.Enabled == true)
            {
                timerLength = 0;
            }
            if (correct.Contains(btn) == false)
            {
                player.Stream = Properties.Resources.flipcard_91468;
                player.Play();

              cardCheck += 1f; //er is een kaart omgedraaid
              if (cardCheck == 1f) 
              { 
                  firstpicture = btn;
              }
              
              if (cardCheck > 2f) //als er te veel kaarten zijn omgedraaid gaan alle kaarten uit
              {
                 cardCheck = 1f; //er is hierna een kaart over
                 firstpicture = btn; // stel deze kaart in als firstpicture

                  resetCard(cardbtn1);
                  resetCard(cardbtn2);
                  resetCard(cardbtn3);
                  resetCard(cardbtn4);
                  resetCard(cardbtn5);
                  resetCard(cardbtn6);
                  resetCard(cardbtn7);
                  resetCard(cardbtn8);
                 currentTurn += 1;
                 currentTurnLabel.Text = "turn " + currentTurn.ToString();
              }



              for (int i = 0; i < cardnumbers.Length; i++) //voor elk lid in cardnumbers
              {
                  if (cardnumbers[i] == btn.Name.ToString()) //als het lid in cardnumbers de geselecteerde knop is...
                  {

                      if (cardpictures[i] == 1) //...wordt het plaatje van het bijbehorende nummer in cardpictures laten zien
                      {
                          btn.BackgroundImage = Properties.Resources.Verdwijnt_de_koe_uit_ons_landschap_;
                      }
                      if (cardpictures[i] == 2)
                      {
                          btn.BackgroundImage = Properties.Resources.Dries_en_ik___Verhalen_van_vroege_r_;
                      }
                      if (cardpictures[i] == 3)
                      {
                          btn.BackgroundImage = Properties.Resources.Goofy_Horse___Horses__Animals__Roman;
                      }
                      if (cardpictures[i] == 4)
                      {
                          btn.BackgroundImage = Properties.Resources.Wat_je_kan_leren_van_een_kip___Hilde_Schoonjans;
                      }

                      if (cardCheck == 1)
                      {
                          pictureOne = cardpictures[i];
                      }
                      else if (cardCheck == 2) 
                      {
                          pictureTwo = cardpictures[i];
                      }
                  }
              }

              if (cardCheck == 2f)
              {

                    if (pictureOne == pictureTwo)
                    {
                        correct.Add(btn);
                        correct.Add(firstpicture);
                        player.Stream = Properties.Resources.rightanswer_95219;
                        player.Play();
                        currentPoints++;
                        pointsLabel.Text = currentPoints.ToString() + " points";
                        if (correct.Count == 8)
                        {
                            timerLength = 0;
                            endTimer.Start();
                            
                        }
                    }
                    resetTimer.Start();
                }
              }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            for (int i = 0; i < picturelist.Count;)
            {
                int addnumber = random.Next(0, picturelist.Count);
                cardpictures.Add(picturelist[addnumber]);
                picturelist.RemoveAt(addnumber);
            }
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

        private void resetTimer_Tick(object sender, EventArgs e)
        {
            timerLength += 1;
            if (timerLength == 170)
            {

                cardCheck = 0f;

                resetCard(cardbtn1);
                resetCard(cardbtn2);
                resetCard(cardbtn3);
                resetCard(cardbtn4);
                resetCard(cardbtn5);
                resetCard(cardbtn6);
                resetCard(cardbtn7);
                resetCard(cardbtn8);

                timerLength = 0;
                resetTimer.Stop();

                currentTurn += 1;
                currentTurnLabel.Text = "turn " + currentTurn.ToString();
            }
        }

        private void endTimer_Tick(object sender, EventArgs e)
        {
            timerLength += 1;
            if (timerLength == 5)
            {
                Application.Exit();
            }
        }
