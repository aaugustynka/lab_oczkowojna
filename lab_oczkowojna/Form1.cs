using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
                        var card = new Card(rank, suit);
                        playerDeck.Add(card);
                    }
                }

                // Tasowanie talii kart
                Shuffle(playerDeck);

                // Podział talii kart pomiędzy gracza a komputer
                int deckSize = playerDeck.Count;
                int halfSize = deckSize / 2;
                for (int i = 0; i < halfSize; i++)
                {
                    computerDeck.Add(playerDeck[i]);
                }
                for (int i = halfSize; i < deckSize; i++)
                {
                    playerDeck[i].IsFaceUp = true;
                }

                gameStarted = false;
            
        }

        private void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
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

                if (wojna.Checked)
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
                    warCards.Add(playerWarCard);
                }

                if (computerDeck.Count > 0)
                {
                    var computerWarCard = computerDeck[0];
                    computerDeck.RemoveAt(0);
                    warCards.Add(computerWarCard);
                }
            }

            StartGame();
        }

        private void wojna_CheckedChanged(object sender, EventArgs e)
        {
            if (wojna.Checked)
            {
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

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }

    public class Card
    {
        public CardRank Rank { get; set; }
        public CardSuit Suit { get; set; }
        public bool IsFaceUp { get; set; }

        public Card(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
            IsFaceUp = false;
        }

        public Image GetCardImage()
        {
            string rankString = ((int)Rank).ToString();
            switch (Rank)
            {
                case CardRank.Jack:
                    rankString = "jack";
                    break;
                case CardRank.Queen:
                    rankString = "queen";
                    break;
                case CardRank.King:
                    rankString = "king";
                    break;
                case CardRank.Ace:
                    rankString = "ace";
                    break;
            }

            string imagePath = Path.Combine("images", $"{rankString}_of_{Suit.ToString().ToLower()}.png");

            byte[] imageBytes = File.ReadAllBytes(imagePath);

            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            {
                return Image.FromStream(memoryStream);
            }
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