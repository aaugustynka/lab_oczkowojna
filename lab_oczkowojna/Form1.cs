using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab_oczkowojna
{
    public partial class Form1 : Form
    {
        private List<Card> playerDeck;
        private List<Card> computerDeck;
        private List<Card> warCards;
        private Random random;
        private bool gameStarted;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Inicjalizacja talii kart
            playerDeck = new List<Card>();
            computerDeck = new List<Card>();
            warCards = new List<Card>();
            random = new Random();

            // Utworzenie talii kart
            var suits = Enum.GetValues(typeof(CardSuit));
            var ranks = Enum.GetValues(typeof(CardRank));
            foreach (CardSuit suit in suits)
            {
                foreach (CardRank rank in ranks)
                {
                    var card = new Card(suit, rank);
                    playerDeck.Add(card);
                }
            }

            // Tasowanie talii kart
            for (int i = 0; i < playerDeck.Count; i++)
            {
                var temp = playerDeck[i];
                int randomIndex = random.Next(playerDeck.Count);
                playerDeck[i] = playerDeck[randomIndex];
                playerDeck[randomIndex] = temp;
            }

            // Podział talii kart pomiędzy gracza a komputer
            for (int i = 0; i < playerDeck.Count; i++)
            {
                if (i % 2 == 0)
                    computerDeck.Add(playerDeck[i]);
                else
                    playerDeck[i].IsFaceUp = true;
            }

            gameStarted = false;
        }

        private void UpdateUI()
        {
            playerCardsLabel.Text = $"Karty gracza: {playerDeck.Count}";
            computerCardsLabel.Text = $"Karty komputera: {computerDeck.Count}";
        }

        private void StartGame()
        {
            if (!gameStarted)
            {
                gameStarted = true;
                warCards.Clear();
                UpdateUI();
                playButton.Enabled = false;

                if (playerDeck.Count == 0 || computerDeck.Count == 0)
                {
                    MessageBox.Show("Gra zakończona!", "Koniec gry");
                    return;
                }

                var playerCard = playerDeck[0];
                var computerCard = computerDeck[0];

                playerDeck.RemoveAt(0);
                computerDeck.RemoveAt(0);

                playerCardPictureBox.Image = playerCard.GetCardImage();
                computerCardPictureBox.Image = computerCard.GetCardImage();

                if (wojna_CheckedChanged.Checked)
                {
                    if (playerCard.Rank > computerCard.Rank)
                    {
                        playerDeck.Add(playerCard);
                        playerDeck.Add(computerCard);
                    }
                    else if (playerCard.Rank < computerCard.Rank)
                    {
                        computerDeck.Add(computerCard);
                        computerDeck.Add(playerCard);
                    }
                    else
                    {
                        warCards.Add(playerCard);
                        warCards.Add(computerCard);
                        War();
                    }
                }
                else
                {
                    if (playerCard.Rank != computerCard.Rank)
                    {
                        if (playerCard.Rank > computerCard.Rank)
                        {
                            playerDeck.Add(playerCard);
                            playerDeck.Add(computerCard);
                        }
                        else
                        {
                            computerDeck.Add(computerCard);
                            computerDeck.Add(playerCard);
                        }
                    }
                    else
                    {
                        warCards.Add(playerCard);
                        warCards.Add(computerCard);
                        War();
                    }
                }

                UpdateUI();
            }
        }

        private void War()
        {
            if (playerDeck.Count < 4 || computerDeck.Count < 4)
            {
                MessageBox.Show("Nie można kontynuować wojny, nie ma wystarczającej ilości kart!", "Koniec gry");
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                if (playerDeck.Count > 0)
                {
                    var playerWarCard = playerDeck[0];
                    playerDeck.RemoveAt(0);
                    playerWarCardPictureBox.Image = playerWarCard.GetCardImage();
                    warCards.Add(playerWarCard);
                }

                if (computerDeck.Count > 0)
                {
                    var computerWarCard = computerDeck[0];
                    computerDeck.RemoveAt(0);
                    computerWarCardPictureBox.Image = computerWarCard.GetCardImage();
                    warCards.Add(computerWarCard);
                }
            }

            StartGame();
        }

        private void wojna_CheckedChanged(object sender, EventArgs e)
        {
            if (wojna_CheckedChanged.Checked)
            {
                // Wyczyść stos wojny
                warCards.Clear();
                playerWarCardPictureBox.Image = null;
                computerWarCardPictureBox.Image = null;
            }
        }

        private void playButton_Click_1(object sender, EventArgs e)
        {
            StartGame();
        }

        private void restartButton_Click_1(object sender, EventArgs e)
        {
            InitializeGame();
            playerCardPictureBox.Image = null;
            computerCardPictureBox.Image = null;
            playerWarCardPictureBox.Image = null;
            computerWarCardPictureBox.Image = null;
            playButton.Enabled = true;
        }

        private void playerCardPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void playerWarCardPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void computerWarPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void playerCardsLabel_Click(object sender, EventArgs e)
        {

        }

        private void computerCardsLabel_Click(object sender, EventArgs e)
        {

        }
    }

    public class Card
    {
        public CardSuit Suit { get; private set; }
        public CardRank Rank { get; private set; }
        public bool IsFaceUp { get; set; }

        public Card(CardSuit suit, CardRank rank)
        {
            Suit = suit;
            Rank = rank;
            IsFaceUp = false;
        }

        public Image GetCardImage()
        {
            string imageName = IsFaceUp ? $"{Rank}_{Suit}.png" : "card_back.png";
            return Image.FromFile(imageName);
        }
    }

    public enum CardSuit
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs
    }

    public enum CardRank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
