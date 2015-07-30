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
    [TestFixture]
    class CardModel
    {
        [Test]
        public void TestValidCardRanges(int value, int suit)
        {
            Contract.Requires(value >= 1 && value <= 13);
            Contract.Requires(suit >= 1 && suit <= 4);

            var card = new Card(value, suit);

            Assert.AreEqual(value, card.Value);
            Assert.AreEqual(suit, card.Suit);

        }
    }
}
