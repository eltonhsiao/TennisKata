using System.Collections.Generic;
using NUnit.Framework;

namespace TennisGame
{
    [TestFixture]
    public class TennisGameTests
    {
        [TestCase(0, 0, "Love All")]
        [TestCase(1, 0, "Fifteen Love")]
        [TestCase(2, 0, "Thirty Love")]
        public void TennisResult(int first, int second, string expected)
        {
            var game = new TennisGames();
            for (int i = 0; i < first; i++)
            {
                game.FirstPlayerScore();
            }
            Assert.AreEqual(expected, game.Result());
        }
    }

    public class TennisGames
    {
        private int _firstPlayerScore = 0;
        private int _secondPlayerScore = 0;

        private Dictionary<int, string> result = new Dictionary<int, string>()
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" }
        };

        public string Result()
        {
            if (_firstPlayerScore == _secondPlayerScore)
                return $"{result[_firstPlayerScore]} All";
            return $"{result[_firstPlayerScore]} {result[_secondPlayerScore]}";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}