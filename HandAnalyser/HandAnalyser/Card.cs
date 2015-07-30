using System;
using System.Diagnostics.Contracts;

namespace HandAnalyser
{
    /// <summary>
    /// Represents a playing card with a value and suit
    /// </summary>
    public class Card : IComparable
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
            Value = value;
            Suit = suit;
        }

        /// <summary>
        /// Gets or sets the value of the card between 1 and 12
        /// </summary>
        public int Value
        {
            get { return _value; }
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException(nameof(value),value,"value must be > 0");
                if (value > 12) throw new ArgumentOutOfRangeException(nameof(value), value, "value must be < 13");
                _value = value;
            }
        }

        /// <summary>
        /// Gets or sets the suit of the card
        /// </summary>
        public int Suit  {
            get
            {
                return _suit;
            }
            set
            {
                if (value < 1) throw new ArgumentOutOfRangeException(nameof(value), value, "suit must be > 0");
                if (value > 4) throw new ArgumentOutOfRangeException(nameof(value), value, "suit must be < 5");
                _suit = value;
            }
        }

        public bool EqualValue(Card rhs)
        {
            return rhs != null && this.Value == rhs.Value;
        }

        public int CompareTo(object obj)
        {
            Card rhs = obj as Card;
            if (rhs == null)
            {
                return 1;
            }

            if (Value > rhs.Value)
            {
                return 1;
            }

            if (EqualValue(rhs))
            {
                return 0;
            }

            return -1;
        }
    }


}