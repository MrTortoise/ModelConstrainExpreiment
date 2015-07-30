namespace HandAnalyser
{
    /// <summary>
    /// Represents a playing card with a value and suit
    /// </summary>
    public class Card
    {
        private  int _value;
        private  int _suit;

        /// <summary>
        /// Cosntructs a playing card with value and suit
        /// </summary>
        /// <param name="value"></param>
        /// <param name="suit"></param>
        public Card(int value, int suit)
        {
            _value = value;
            _suit = suit;
        }

        /// <summary>
        /// Gets or sets the value of the card between 1 and 12
        /// </summary>
        public int Value { get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// Gets or sets the suit of the card
        /// </summary>
        public int Suit  {
            get { return _suit;}
            set { _suit = value; }
        }
    }
}