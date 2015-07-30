namespace HandAnalyser
{
    public class Card
    {
        private  int _value;
        private  int _suit;

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

        public int Suit  {
            get { return _suit;}
            set { _suit = value; }
        }
    }
}