// <copyright file="CardModel.cs">Copyright ©  2015</copyright>
using System;
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
            PexAssert.AreEqual(value,target.Value);
            PexAssert.AreEqual(suit,target.Suit);
            PexAssert.IsTrue(target.Value > 0 && target.Value <= 12);
            PexAssert.IsTrue(target.Suit>0 && target.Suit <= 4);
            return target;
        }
    }
}
