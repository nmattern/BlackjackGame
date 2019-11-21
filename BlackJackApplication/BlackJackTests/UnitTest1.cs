using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackApplication;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace BlackJackTests
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void validateDeckConstructorForCorrectCards()
        {
            //Arrange
            List<string> possibleSuits = new List<string>();
            List<string> possibleValues = new List<string>();
            possibleSuits.Add("diamonds");
            possibleSuits.Add("hearts");
            possibleSuits.Add("spades");
            possibleSuits.Add("clubs");
            possibleValues.Add("ace");
            possibleValues.Add("2");
            possibleValues.Add("3");
            possibleValues.Add("4");
            possibleValues.Add("5");
            possibleValues.Add("6");
            possibleValues.Add("7");
            possibleValues.Add("8");
            possibleValues.Add("9");
            possibleValues.Add("10");
            possibleValues.Add("jack");
            possibleValues.Add("queen");
            possibleValues.Add("king");

            //Act
            var deck = new Deck();

            //Assert
            foreach (string value in possibleValues)
            {
                foreach (string suit in possibleSuits)
                {
                    deck.Cards.Any(c => c.Value == value && c.Suit == suit);
                }
            }
            Assert.AreEqual(52, deck.Cards.Count);
        }

        [TestMethod]
        public void validateCardConstructorForProperValues()
        {
            //Arrange
            var expectedValue = "test";
            var expectedSuit = "unitTest";

            //Act
            Card card = new Card(expectedSuit, expectedValue, null);

            //Assert
            Assert.AreEqual(expectedSuit, card.Suit);
            Assert.AreEqual(expectedValue, card.Value);

        }
        [TestMethod]
        public void validateDealerDealsCorrectCards()
        {
            //Arrange
            var player = new Player();
            var dealer = new Dealer();
            var deck = new Deck();
            Card[] cards = new Card[52];
            deck.Cards.CopyTo(cards);
            var cardsToDeal = 6;

            //Act
            dealer.dealCard(player, deck, cardsToDeal);

            //Assert
            Assert.AreEqual(cardsToDeal, player.CurrentPlayerHand.Count);

            for (int i = 0; i < cardsToDeal; i++)
            {
                Assert.AreEqual(cards[i], player.CurrentPlayerHand[i]);
            }
        }
        [TestMethod]
        public void verifyingEmptyConstructorValuesofPlayerClass()
        {
            //Arrange
            long expectedPhone = 0000000000;
            string expectedAddress = "";
            string expectedName = "test";
            long expectedCreditC = 0000000000000000;
            string expectedRecovA = "";
            string expectedRecovQ = "";
            string expectedPassword = "";
            string expectedUsername = "";
            int expectedPlayerFBID = 0;

            //Act
            var player = new Player();

            //Assert
            Assert.AreEqual(expectedPhone, player.Phone);
            Assert.AreEqual(expectedAddress, player.Address);
            Assert.AreEqual(expectedName, player.Name);
            Assert.AreEqual(expectedCreditC, player.CreditC);
            Assert.AreEqual(expectedRecovA, player.RecovA);
            Assert.AreEqual(expectedRecovQ, player.RecovQ);
            Assert.AreEqual(expectedPassword, player.Password);
            Assert.AreEqual(expectedUsername, player.Username);
            Assert.AreEqual(expectedPlayerFBID, player.PlayerFBID);
        }

        [TestMethod]
        public void verifyingTestConstructorValuesofPlayerClass()
        {
            //Arrange
            int expectedPhone = 1234567890;
            string expectedAddress = "test";
            string expectedName = "BlackJack";
            int expectedCreditC = 1234;
            string expectedRecovA = "Dog";
            string expectedRecovQ = "What is your first pet's name?";
            string expectedPassword = "password";
            string expectedUsername = "user123";
            int expectedPlayerFBID = 88;

            //Act
            var player = new Player(expectedPhone, expectedAddress,
                                    expectedName, expectedCreditC,
                                    expectedRecovA, expectedRecovQ,
                                    expectedPassword, expectedUsername,
                                    expectedPlayerFBID);

            //Assert
            Assert.AreEqual(expectedPhone, player.Phone);
            Assert.AreEqual(expectedAddress, player.Address);
            Assert.AreEqual(expectedName, player.Name);
            Assert.AreEqual(expectedCreditC, player.CreditC);
            Assert.AreEqual(expectedRecovA, player.RecovA);
            Assert.AreEqual(expectedRecovQ, player.RecovQ);
            Assert.AreEqual(expectedPassword, player.Password);
            Assert.AreEqual(expectedUsername, player.Username);
            Assert.AreEqual(expectedPlayerFBID, player.PlayerFBID);
        }

        [TestMethod]
        public void verifyPlayerAddCardToHand()
        {
            //Arrange
            Card card = new Card("test", "11", null);
            Player player = new Player();

            //Act
            player.addCardToHand(card);

            //Assert
            Assert.IsTrue(player.CurrentPlayerHand.Any(c => c.Suit == "test" &&
                                                       c.Value == "11" &&
                                                       c.CardImage == null));
        }

        [TestMethod]
        public void testTurnClassBetButtonClick()
        {
            //Arrange
            tableForm tableForm = new tableForm();
            Deck deck = new Deck();
            Player player = new Player();
            Dealer dealer = new Dealer();
            var turn = new Turn(tableForm, deck, null, player, dealer);
            tableForm.betTextBox.Text = "test";

            //Act
            turn.betButtonClick();

            //Assert

        }
    }
}

