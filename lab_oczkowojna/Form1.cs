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

        public Form1()
        {
            InitializeComponent();
            
            playButton.Hide();
            lblPlayer1Card.Hide();
            lblPlayer2Card.Hide();
            txtPlayer1Cards.Hide();
            txtPlayer2Cards.Hide();
            lblWarInfo.Hide();
            wojna.Checked = false;
        }
        private void wojna_CheckedChanged_1(object sender, EventArgs e)
        {
        if (wojna.Checked)
        {
              playButton.Show();
              lblPlayer1Card.Show();
              lblPlayer2Card.Show();
              txtPlayer1Cards.Show();
              txtPlayer2Cards.Show();
              lblWarInfo.Show();

        }
        else
        {
                playButton.Hide();
                lblPlayer1Card.Hide();
                lblPlayer2Card.Hide();
                txtPlayer1Cards.Hide();
                txtPlayer2Cards.Hide();
                lblWarInfo.Hide();
        }
    }

    private void Form1_Load(object sender, EventArgs e)
        {

            wojna.Checked = false;
            isWarGame = false; 
            InitializeDeck();
            ShuffleDeck();

            


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

            DealCards();

           wojna.Enabled = false;

            UpdateUI();

            PlayGame();
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


        private void txtPlayer1Cards_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlayer2Cards_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayer2Card_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer1Card_Click(object sender, EventArgs e)
        {

        }

        private void lblWarInfo_Click(object sender, EventArgs e)
        {

        }
    }
}


