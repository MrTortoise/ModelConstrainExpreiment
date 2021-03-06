using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;
using NUnit.Framework;
using HandAnalyser;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace HandAnalyser.Model
{
    public partial class CardModel
    {

[Test]
[PexGeneratedBy(typeof(CardModel))]
public void ComparableImplementationForSorting37601()
{
    Card card;
    card = CardFactory.Create(1, 1);
    this.ComparableImplementationForSorting(card, (Card)null);
}

[Test]
[PexGeneratedBy(typeof(CardModel))]
public void ComparableImplementationForSorting54901()
{
    Card card;
    card = CardFactory.Create(4, 4);
    this.ComparableImplementationForSorting(card, card);
}

[Test]
[PexGeneratedBy(typeof(CardModel))]
public void ComparableImplementationForSorting316()
{
    Card card;
    Card card1;
    card = CardFactory.Create(9, 1);
    card1 = CardFactory.Create(4, 1);
    this.ComparableImplementationForSorting(card, card1);
}

[Test]
[PexGeneratedBy(typeof(CardModel))]
public void ComparableImplementationForSorting755()
{
    Card card;
    Card card1;
    card = CardFactory.Create(1, 1);
    card1 = CardFactory.Create(4, 4);
    this.ComparableImplementationForSorting(card, card1);
}
    }
}
