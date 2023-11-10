
using static System.Console;

namespace CSharpStudy
{
    public enum Suit { Spades, Diamonds, Hearts, Clubs,  }
    public enum Rank { Ace = 1, Two, Three, Four, Five, Six, Seven,
                       Eight, Nine, Ten, Jack, Queen, King }

    public class Game03Blackjack
    {
        private Deck _deck;
        private GivenCards _player;
        private GivenCards _dealer;

        public void PlayGame()
        {
            while (true)
            {
                _deck = new Deck();
                _player = new GivenCards();
                _dealer = new GivenCards();
                Card card;

                //game start
                _player.GetACard(_deck);
                _player.GetACard(_deck);
                _dealer.GetACard(_deck);

                WriteLine();
                WriteLine(" Welcome to Blackjack");
                WriteLine(" Jack, Queen, and King cards have 10 points.");
                WriteLine(" Aces have 1 or 11 points.");
                WriteLine(" All other cards have points of their face values.");
                WriteLine();

                WriteLine(" Dealer stays if score is 17 or more.");
                WriteLine(" You and dealer go bust if score exceeds 21");
                WriteLine(" If scores of player and dealer are the same, dealer wins.");
                WriteLine();

                _player.DisplayAllCards();
                WriteLine($" player's point : {_player.CalcPoint()}");
                WriteLine();

                _dealer.DisplayAllCards();
                WriteLine($" dealer's point : {_dealer.CalcPoint()}");
                WriteLine();

                // player's turn
                while (_player.CalcPoint() < 21)
                {
                    Write(" hit or stay? (h/s): ");
                    string userRetry = ReadLine();

                    if (userRetry.ToLower() == "h")
                    {
                        card = _player.GetACard(_deck);
                        WriteLine($" You drew the {card}.");
                        _player.DisplayAllCards();
                        WriteLine();
                        WriteLine($" Your current score is {_player.CalcPoint()}");
                        WriteLine();
                    }
                    else
                    {
                        WriteLine();
                        break;
                    }
                }

                // dealer's turn, when player not bust
                if (_player.CalcPoint() <= 21)
                {
                    WriteLine(" dealer's turn");

                    while (_dealer.CalcPoint() < 17)
                    {
                        card = _dealer.GetACard(_deck);
                        WriteLine($" dealer drew the {card}.");
                        _dealer.DisplayAllCards();
                        WriteLine();
                        WriteLine($" dealer's current score is {_dealer.CalcPoint()}");
                        WriteLine();
                    }
                }

                // Winner determination.
                if (_player.CalcPoint() > 21)
                {
                    WriteLine(" You went bust. dealer wins");
                }
                else if (_dealer.CalcPoint() > 21)
                {
                    WriteLine(" Dealer went bust, you win!");
                }
                else if (_player.CalcPoint() > _dealer.CalcPoint())
                {
                    WriteLine(" Your score is higher than dealer\'s, you win!");
                }
                else
                {
                    WriteLine(" Dealer\'s score is equal to or higher than the player's score.");
                }

                WriteLine();

                Write(" Play one more time? (y/n): ");
                string userInput = ReadLine();

                if (userInput.ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }

    /// <summary>
    /// A class for one card
    /// </summary>
    public class Card
    {
        public Suit Suit { get; private set; }
        public Rank Rank { get; private set; }

        public Card(Suit cardType, Rank cardNumber)
        {
            Suit = cardType;
            Rank = cardNumber;
        }

        // Compute point of a card
        public int GetPoint()
        {
            if ((int)Rank > 10)
            {
                return 10;
            }
            else if ((int)Rank > 1)
            {
                return (int)Rank;
            }
            else
            {
                return 11;
            }
        }

        // Compute string representation of a card.
        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    /// <summary>
    /// A class for deck of 52 cards.
    /// this class create, shuffle, check deck is empty
    /// and draw card from deck
    /// </summary>
    public class Deck
    {
        // Create card case for create new card deck
        private List<Card> cards;

        // Create not shuffled card deck
        public Deck()
        {
            cards = new List<Card>();

            // 모든 무늬와 숫자의 조합에 대해 카드를 생성
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(s, r));
                }
            }

            // 카드를 섞는다
            Shuffle();
        }

        // Shuffling the card deck.
        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = 0; i < cards.Count; i++)
            {
                int j = rand.Next(i, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        // Check whether this deck is empty
        public int IsEmpty()
        {
            if (cards.Count == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        // Pick up a card from this deck
        public Card DrawCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }

    /// <summary>
    /// This class displays the player's card hand,
    /// calculates scores, and draws a card from the deck
    /// to add to the player's hand.
    /// </summary>
    public class GivenCards
    {
        // cards
        private List<Card> cards;

        public GivenCards()
        {
            cards = new List<Card>();
        }

        // give a card to person (dealer, player)
        public virtual Card GetACard(Deck deck)
        {
            Card card = deck.DrawCard();
            cards.Add(card);
            return card;
        }

        // method for calcuating card points
        public int CalcPoint()
        {
            int point = 0;
            int aceCount = 0;

            // basic rules for calculating card points
            foreach (Card card in cards)
            {
                if (card.Rank == Rank.Ace)
                {
                    aceCount++;
                }
                point += card.GetPoint();
            }

            // specific rules for calculating card points
            // If the total score exceeds 21 points,
            // aces can be counted as 1 point
            while (point > 21 && aceCount > 0)
            {
                point -= 10;
                aceCount--;
            }

            return point;
        }

        // Display all the cards in hand.
        public void DisplayAllCards()
        {
            Write(" [ ");
            for (int i = 0; i < cards.Count; i++)
            {
                string oneCard = cards[i].ToString();
                if (i < (cards.Count - 1))
                {
                    Write($"{oneCard}, ");
                }
                else
                {
                    WriteLine($"{oneCard} ]");
                }
            }
        }
    }
}