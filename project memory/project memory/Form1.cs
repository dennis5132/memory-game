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
        string[] cardnumbers = { "cardbtn1", "cardbtn2", "cardbtn3", "cardbtn4", "cardbtn5", "cardbtn6", "cardbtn7", "cardbtn8", "cardbtn9", "cardbtn10", "cardbtn11", "cardbtn12" }; //checken welke knop bij welk plaatje in de lijst eronder ligt

        List<int> picturelist = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        List<int> cardpictures = new List<int>(); // waar verschillende plaatjes liggen

        private PictureBox firstpicture;
        List<PictureBox> correct = new List<PictureBox>();

        public int pictureOne;
        public int pictureTwo;

        Random random = new Random();
        SoundPlayer player = new SoundPlayer();

        int timerLength = 0;
        //int endTimerLength = 0;

        public int currentTurn = 1;
        public int currentPoints = 0;
        public int playTime = 0;

        int minuten;
        int seconden;




        private void resetCard(PictureBox thisB)
        {
            if (correct.Contains(thisB) == false)
            {
                thisB.Image = null;
            }
        }
        private void Cardturn(PictureBox btn) //activeert als er op een knop wordt gedrukt
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
                    resetCard(cardbtn9);
                    resetCard(cardbtn10);
                    resetCard(cardbtn11);
                    resetCard(cardbtn12);

                    currentTurn += 1;
                    currentTurnLabel.Text = "turn " + currentTurn.ToString();
                }



                for (int i = 0; i < cardnumbers.Length; i++) //voor elk lid in cardnumbers
                {
                    if (cardnumbers[i] == btn.Name.ToString()) //als het lid in cardnumbers de geselecteerde knop is...
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
                            //endTimerLength = 0;
                            //endTimer.Start();
                            timeTimer.Stop();
                            resetTimer.Stop();
                            DialogResult result = MessageBox.Show($"Do you want to play again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Application.Restart();
                                //Application.Restart();
                                //Environment.Exit(0);  
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
            for (int i = 0; i < picturelist.Count;)
            {
                int addnumber = random.Next(0, picturelist.Count);
                cardpictures.Add(picturelist[addnumber]);
                picturelist.RemoveAt(addnumber);
            }
            timeTimer.Start();
        }

       
        public Form1()
        {
            InitializeComponent();

        }

        private void cardbtn1_Click(object sender, EventArgs e)
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

        private void cardbtn9_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn9);
        }

        private void cardbtn10_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn10);
        }

        private void cardbtn11_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn11);
        }

        private void cardbtn12_Click(object sender, EventArgs e)
        {
            Cardturn(cardbtn12);
        }

        private void resetTimer_Tick(object sender, EventArgs e)
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
                resetCard(cardbtn9);
                resetCard(cardbtn10);
                resetCard(cardbtn11);
                resetCard(cardbtn12);

                resetTimer.Stop();

                currentTurn += 1;
                currentTurnLabel.Text = "turn " + currentTurn.ToString();
        }

        //private void endTimer_Tick(object sender, EventArgs e)
        //{
        //    endTimerLength += 1;
        //    if (endTimerLength >= 40)
        //    {
        //        //
                
        //    }
        //}

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            // komt 1 seconde bij
            playTime++;

            // maak minuten en seconden van
            minuten = playTime / 6;
            seconden = playTime % 6;

            // zet het op label
            timelbl.Text = $"{minuten:D2}:{seconden:D2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

        
