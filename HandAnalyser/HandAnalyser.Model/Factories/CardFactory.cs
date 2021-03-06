using HandAnalyser;
using System;
using Microsoft.Pex.Framework;

namespace HandAnalyser
{
    /// <summary>A factory for HandAnalyser.Card instances</summary>
    public static partial class CardFactory
    {
        /// <summary>A factory for HandAnalyser.Card instances</summary>
        [PexFactoryMethod(typeof(Card))]
        public static Card Create(int value_i, int suit_i1)
        {
            Card card = new Card(value_i, suit_i1);
            return card;
        }
    }
}
