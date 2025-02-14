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
        List<PictureBox> cardnumbers = new List<PictureBox>();
        

        List<int> picturelist = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        List<int> cardpictures = new List<int>(); // waar verschillende plaatjes liggen

        private PictureBox firstpicture;
        List<PictureBox> correct = new List<PictureBox>();

        public int pictureOne;
        public int pictureTwo;

        Random random = new Random();
        SoundPlayer player = new SoundPlayer();

        public int currentTurn = 1;
        public int currentPoints = 0;
        public int playTime = 0;        

        int minuten;
        int seconden;

        public Form1()
        {
            InitializeComponent();

            cardnumbers.Add(cardbtn1);
            cardnumbers.Add(cardbtn2);
            cardnumbers.Add(cardbtn3);
            cardnumbers.Add(cardbtn4);
            cardnumbers.Add(cardbtn5);
            cardnumbers.Add(cardbtn6);
            cardnumbers.Add(cardbtn7);
            cardnumbers.Add(cardbtn8);
            cardnumbers.Add(cardbtn9);
            cardnumbers.Add(cardbtn10);
            cardnumbers.Add(cardbtn11);
            cardnumbers.Add(cardbtn12);
        }

        private void resetCard(PictureBox thisB)
        {
            if (correct.Contains(thisB) == false)
            {
                thisB.Image = null;
            }
        }
        private void Cardturn(PictureBox btn) //activeert als er op een knop wordt gedrukt
        {
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
                    resetTimer.Stop();
                    cardCheck = 1f; //er is hierna een kaart over
                    firstpicture = btn; // stel deze kaart in als firstpicture
                    for (int i = 0; i < cardnumbers.Count; i++) 
                    {
                        resetCard(cardnumbers[i]);
                    }
                    
                    currentTurn += 1;
                    currentTurnLabel.Text = "turn " + currentTurn.ToString();
                }



                for (int i = 0; i < cardnumbers.Count; i++) //voor elk lid in cardnumbers
                {
                    if (cardnumbers[i] == btn) //als het lid in cardnumbers de geselecteerde knop is...
                    {

                        if (cardpictures[i] == 1) //...wordt het plaatje van het bijbehorende nummer in cardpictures laten zien
                        {
                            btn.Image = Properties.Resources.Verdwijnt_de_koe_uit_ons_landschap_;
                        }
                        if (cardpictures[i] == 2)
                        {
                            btn.Image = Properties.Resources.Dries_en_ik___Verhalen_van_vroege_r_;
                        }
                        if (cardpictures[i] == 3)
                        {
                            btn.Image = Properties.Resources.Goofy_Horse___Horses__Animals__Roman;
                        }
                        if (cardpictures[i] == 4)
                        {
                            btn.Image = Properties.Resources.Wat_je_kan_leren_van_een_kip___Hilde_Schoonjans;
                        }
                        if (cardpictures[i] == 5)
                        {
                            btn.Image = Properties.Resources.screaminggoat;
                        }
                        if (cardpictures[i] == 6)
                        {
                            btn.Image = Properties.Resources.varkeninmodder;
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
                        if (correct.Count == 12)
                        {
                            timeTimer.Stop();
                            resetTimer.Stop();
                            DialogResult result = MessageBox.Show($"Do you want to play again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                resetGame();  
                                currentTurn = 0;
                            }
                            else
                            {
                                // User clicked No
                                Application.Exit();
                            }
                        }
                    }
                    resetTimer.Start();
                    
                }
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            resetGame();
        }

        public void resetGame()
        {
            cardCheck = 0f;
            picturelist = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
            cardpictures = new List<int>();
            correct = new List<PictureBox>();
            currentPoints = 0;
            playTime = 0;
            pointsLabel.Text = currentPoints.ToString() + " points";

            for (int i = 0; i < cardnumbers.Count; i++)
            {
                resetCard(cardnumbers[i]);
            }
            
            for (int i = 0; i < picturelist.Count;)
            {
                int addnumber = random.Next(0, picturelist.Count);
                cardpictures.Add(picturelist[addnumber]);
                picturelist.RemoveAt(addnumber);
            }
            timeTimer.Start();
        }

        private void cardclick(object sender, EventArgs e)
        {
            if (sender is PictureBox clicked)
            {
                Cardturn(clicked);
            }
        }

        private void resetTimer_Tick(object sender, EventArgs e)
        {
                cardCheck = 0f;

            for (int i = 0; i < cardnumbers.Count; i++)
            {
                resetCard(cardnumbers[i]);
            }

            resetTimer.Stop();

                currentTurn += 1;
                currentTurnLabel.Text = "turn " + currentTurn.ToString();
        }


        private void timeTimer_Tick(object sender, EventArgs e)
        {
            // komt 1 seconde bij
            playTime++;

            // maak minuten en seconden van
            minuten = playTime / 60;
            seconden = playTime % 60;

            // zet het op label
            timelbl.Text = $"{minuten:D2}:{seconden:D2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetGame();
            currentTurn = 0;
        }

        
    }
}

        
