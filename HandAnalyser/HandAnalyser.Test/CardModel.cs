using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HandAnalyser.Test
{
    /// <summary>
    /// This models the values of a card
    /// </summary>
    class CardModel
    {
       
        public void TestValidCardRanges(int value, int suit)
        {
            var card = new Card(value, suit);

            Assert.AreEqual(value, card.Value);
            Assert.AreEqual(suit, card.Suit);
        }
    }

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
