using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_oczkowojna
{
    public partial class Form1 : Form
    {
        private List<string> deck;
        private List<string> player1Cards;
        private List<string> player2Cards;
        private bool isWarGame;

        private List<string> playero1Cards;
        private List<string> playero2Cards;

        public Form1()
        {
            InitializeComponent();

            playButton.Hide();
            addCardButton.Hide();
            stopButton.Hide();
            lblPlayer1Card.Hide();
            lblPlayer2Card.Hide();
            txtPlayer1Cards.Hide();
            txtPlayer2Cards.Hide();
            lblWarInfo.Hide();
            lblPlayer2Cards.Hide();
            lblPlayer1Cards.Hide();
            wojna.Checked = false;
        }
        private void wojna_CheckedChanged(object sender, EventArgs e)
        {
            if (wojna.Checked)
            {
                playButton.Show();
                lblPlayer1Card.Show();
                lblPlayer2Card.Show();
                txtPlayer1Cards.Show();
                txtPlayer2Cards.Show();
                lblWarInfo.Show();
                lblPlayer2Cards.Show();
                lblPlayer1Cards.Show();

            }
            else
            {
                playButton.Hide();
                lblPlayer1Card.Hide();
                lblPlayer2Card.Hide();
                txtPlayer1Cards.Hide();
                txtPlayer2Cards.Hide();
                lblWarInfo.Hide();
                lblPlayer2Cards.Hide();
                lblPlayer1Cards.Hide();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

            wojna.Checked = false;
            isWarGame = false;
            InitializeDeck();
            ShuffleDeck();


            this.FormClosing += Form1_FormClosing;


        }
        private void InitializeDeck()
        {
            deck = new List<string>();

            string[] shapes = { "spades", "hearts", "diamonds", "clubs" };
            string[] figures = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };

            foreach (string shape in shapes)
            {
                foreach (string figure in figures)
                {
                    string card = $"{figure}_of_{shape}";
                    deck.Add(card);
                }
            }
        }

        private void ShuffleDeck()
        {
            Random random = new Random();

            for (int i = 0; i < deck.Count; i++)
            {
                int randomIndex = random.Next(i, deck.Count);
                string temp = deck[i];
                deck[i] = deck[randomIndex];
                deck[randomIndex] = temp;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            InitializeDeck();
            ShuffleDeck();
            if (wojna.Checked)
            {
                isWarGame = true;
            }
            else if (oczko.Checked)
            {
                isWarGame = false;
            }
            else
            {
                MessageBox.Show("Wybierz rodzaj gry (wojna lub oczko).");
                return;
            }

            player1Cards = new List<string>();
            player2Cards = new List<string>();
            playero1Cards = new List<string>();
            playero2Cards = new List<string>();

            DealCards();

            //wojna.Enabled = false;

            UpdateUI();

            if (isWarGame)
            {
            PlayGame();

            }
            else
            {
                PlayOczkoGame();
            }
        }
        private void PlayOczkoGame()
        {
            // Implementuj logikę gry w Oczko
            while (true)
            {
                int player1Score = CalculateOczkoScore(playero1Cards);
                int player2Score = CalculateOczkoScore(playero2Cards);

                if (player1Score >= 21 || player2Score >= 21)
                {
                    EndGame(player1Score, player2Score);
                    break;
                }

               // stopButton.Visible = true;
              //  addCardButton.Visible = true;

                stopButton.Enabled = true;
                addCardButton.Enabled = true;

               // stopButton.Click += stopButton_Click;
              //  addCardButton.Click += addCardButton_Click;

                // Oczekuj na akcję użytkownika (kliknięcie przycisku "Stop" lub "Dodaj kartę")
                Application.DoEvents();
            }
        }


        private int CalculateOczkoScore(List<string> cards)
        {
            int score = 0;

            foreach (string card in cards)
            {
                string rank = card.Substring(0, card.IndexOf("_of"));

                if (rank == "ace")
                {
                    score += 11;
                }
                else if (rank == "king" || rank == "queen" || rank == "jack")
                {
                    score += 10;
                }
                else
                {
                    score += int.Parse(rank);
                }
            }

            return score;
        }

        private void DealCards()
        {
            int numCardsPerPlayer = deck.Count / 2;

            for (int i = 0; i < numCardsPerPlayer; i++)
            {
                string card1 = deck[i];
                string card2 = deck[i + numCardsPerPlayer];

                player1Cards.Add(card1);
                player2Cards.Add(card2);
            }
        }

        private void PlayGame()
        {
            while (player1Cards.Count > 0 && player2Cards.Count > 0)
            {
                string card1 = player1Cards[0];
                string card2 = player2Cards[0];

                player1Cards.RemoveAt(0);
                player2Cards.RemoveAt(0);

                int result = CompareCards(card1, card2);

                if (result > 0)
                {
                    player1Cards.Add(card1);
                    player1Cards.Add(card2);
                }
                else if (result < 0)
                {
                    player2Cards.Add(card1);
                    player2Cards.Add(card2);
                    lblWarInfo.Text = "";
                }
                else if (isWarGame)
                {
                    War(card1, card2);
                }

                UpdateUI();
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);
            }

            // Koniec gry
            string winner = (player1Cards.Count > player2Cards.Count) ? "Gracz 1" : "Gracz 2";
            MessageBox.Show($"Koniec gry! {winner} wygrał!");
            
        }


        private void War(string card1, string card2)
        {
            lblWarInfo.Text = "WOJNA!";
            List<string> pot = new List<string>();
            pot.Add(card1);
            pot.Add(card2);

            // Zagraj kolejne rundy wojny, aż jeden z graczy zdobędzie wygraną
            while (true)
            {
                // Sprawdź, czy gracze mają wystarczającą ilość kart na wojnę
                if (player1Cards.Count < 4 || player2Cards.Count < 4)
                {
                    // Jeśli któremuś z graczy zabrakło kart, gra kończy się remisem
                    // Można dodać obsługę takiego przypadku lub zastosować inną logikę
                    break;
                }

                // Dodaj karty na wojnę do puli (stosu)
                for (int i = 0; i < 3; i++)
                {
                    pot.Add(player1Cards[i]);
                    pot.Add(player2Cards[i]);
                }

                player1Cards.RemoveRange(0, 3);
                player2Cards.RemoveRange(0, 3);

                string warCard1 = player1Cards[0];
                string warCard2 = player2Cards[0];

                int result = CompareCards(warCard1, warCard2);

                if (result > 0)
                {
                    player1Cards.AddRange(pot);
                    break;
                }
                else if (result < 0)
                {
                    player2Cards.AddRange(pot);
                    break;
                }
            }
        }



        private int CompareCards(string card1, string card2)
        {
            string rank1 = card1.Substring(0, card1.IndexOf("_of"));
            string rank2 = card2.Substring(0, card2.IndexOf("_of"));

            Dictionary<string, int> rankValues = new Dictionary<string, int>()
            {
                {"ace", 14},
                {"king", 13},
                {"queen", 12},
                {"jack", 11},
                {"10", 10},
                {"9", 9},
                {"8", 8},
                {"7", 7},
                {"6", 6},
                {"5", 5},
                {"4", 4},
                {"3", 3},
                {"2", 2}
            };

            int value1 = rankValues[rank1];
            int value2 = rankValues[rank2];

            return value1 - value2;
        }

        private void UpdateUI()
        {
            txtPlayer1Cards.Text = player1Cards.Count.ToString();
            txtPlayer2Cards.Text = player2Cards.Count.ToString();

            lblPlayer1Card.Text = (player1Cards.Count > 0) ? player1Cards[0] : "Brak";
            lblPlayer2Card.Text = (player2Cards.Count > 0) ? player2Cards[0] : "Brak";
        }
        private void UpdateUIo()
        {
            txtPlayer1Cards.Text =CalculateOczkoScore(playero1Cards).ToString();
            txtPlayer2Cards.Text = CalculateOczkoScore(playero2Cards).ToString();

            lblPlayer1Card.Text = (playero1Cards.Count > 0) ? playero1Cards[0] : "Brak";
            lblPlayer2Card.Text = (playero2Cards.Count > 0) ? playero2Cards[0] : "Brak";
        }


        private void txtPlayer1Cards_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlayer2Cards_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWarInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer1Cards_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer2Cards_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer1Card_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer2Card_Click(object sender, EventArgs e)
        {

        }

        private void oczko_CheckedChanged(object sender, EventArgs e)
        {
            if (oczko.Checked)
            {
                playButton.Show();
                lblPlayer1Card.Show();
                lblPlayer2Card.Show();
                txtPlayer1Cards.Show();
                txtPlayer2Cards.Show();
                lblWarInfo.Show();
                lblPlayer2Cards.Show();
                lblPlayer1Cards.Show();
                addCardButton.Show();
                stopButton.Show();
            }
            else
            {
                playButton.Hide();
                lblPlayer1Card.Hide();
                lblPlayer2Card.Hide();
                txtPlayer1Cards.Hide();
                txtPlayer2Cards.Hide();
                lblWarInfo.Hide();
                lblPlayer2Cards.Hide();
                lblPlayer1Cards.Hide();
                addCardButton.Hide();
                stopButton.Hide();
            }

        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            addCardButton.Enabled = false;

            int player1Score = CalculateOczkoScore(playero1Cards);
            int player2Score = CalculateOczkoScore(playero2Cards);

            UpdateUIo();

            EndGame(player1Score, player2Score);
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            if (playero1Cards.Count < 3 && playero2Cards.Count < 3)
            {
                string newCard = deck[0];
                playero1Cards.Insert(0,newCard);
                deck.RemoveAt(0);

                newCard = deck[0];
                playero2Cards.Insert(0,newCard);
                deck.RemoveAt(0);

                int player1Score = CalculateOczkoScore(playero1Cards);
                int player2Score = CalculateOczkoScore(playero2Cards);

                if (player1Score >= 21 || player2Score >= 21)
                {
                    EndGame(player1Score, player2Score);
                }

                UpdateUIo();
            }
        }

        private void EndGame(int player1Score, int player2Score)
        {
            stopButton.Enabled = false;
            addCardButton.Enabled = false;
            UpdateUIo();

            string winner;
            if (player1Score == player2Score)
            {
                winner = "Remis";
            }
            else if (player1Score > 21 && player2Score > 21)
            {
                winner = "Brak - obaj gracze przekroczyli 21";
            }
            else if (player1Score > 21)
            {
                winner = "Gracz 2";
            }
            else if (player2Score > 21)
            {
                winner = "Gracz 1";
            }
            else if (player1Score > player2Score)
            {
                winner = "Gracz 1";
            }
            else
            {
                winner = "Gracz 2";
            }

            if (winner=="Remis")
            {
             
            }
            else
            {
                MessageBox.Show($"Koniec gry! Zwycięzca: {winner}\n\nGracz 1: {player1Score}, Gracz 2: {player2Score}");
            }

            // Wyzeruj stan gry
            deck.Clear();
            playero1Cards.Clear();
            playero2Cards.Clear();

            InitializeDeck();
            ShuffleDeck();
            UpdateUIo();

            wojna.Checked = false;
            oczko.Checked = false;

            //stopButton.Visible = false;
            //addCardButton.Visible = false;

        }

    }
}