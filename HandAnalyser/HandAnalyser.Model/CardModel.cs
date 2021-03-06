// <copyright file="CardModel.cs">Copyright ©  2015</copyright>
using System;
using System.Diagnostics.Contracts;
using HandAnalyser;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;

namespace HandAnalyser.Model
{
    /// <summary>This class contains parameterized unit tests for Card</summary>
    [PexClass(typeof(Card))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class CardModel
    {
        /// <summary>
        /// Ensures that a created card has valid range of values and suit
        /// </summary>
        [PexMethod]
        public Card CardHasValueAndSuitInRange(int value, int suit)
        {
            Card target = new Card(value, suit);
            PexAssert.AreEqual(value, target.Value);
            PexAssert.AreEqual(suit, target.Suit);
            PexAssert.IsTrue(target.Value > 0 , "value:{0}", target.Value.ToString());
            PexAssert.IsTrue(target.Value <= 12, "value:{0}", target.Value.ToString());
            PexAssert.IsTrue(target.Suit > 0 , "suit:{0}", target.Suit.ToString());
            PexAssert.IsTrue(target.Suit <= 4, "suit:{0}", target.Suit.ToString());
            return target;
        }


        [PexMethod]
        public void TestIf2CardsEqualValue(Card lhs, Card rhs)
        {
            PexAssume.IsNotNull(lhs);

            if (rhs == null)
            {
                PexAssert.IsTrue(!lhs.EqualValue(null));
                return;
            }

            PexAssert.AreEqual(lhs.Value == rhs.Value, lhs.EqualValue(rhs));
            PexAssert.AreEqual(lhs.Value == rhs.Value, rhs.EqualValue(lhs));
            PexAssert.AreNotEqual(lhs.Value != rhs.Value, lhs.EqualValue(rhs));
        }

        [PexMethod]
        public void ComparableImplementationForSorting(Card lhs, Card rhs)
        {
            PexAssume.IsNotNull(lhs);

            if (rhs == null)
            {
                PexAssert.AreEqual(1,lhs.CompareTo((Card) null));
                return;
            }

            if (rhs.EqualValue(lhs))
            {
                PexAssert.AreEqual(0, lhs.CompareTo(rhs));
                return;
            }

            if (lhs.Value > rhs.Value)
            {
                PexAssert.AreEqual(1, lhs.CompareTo(rhs));
                return;
            }

            PexAssert.AreEqual(-1, lhs.CompareTo(rhs));
        }
    }
}
