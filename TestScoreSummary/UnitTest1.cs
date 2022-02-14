using NUnit.Framework;

namespace TestScoreSummary
{
    public class ScoreSummary
    {
        private int highScore;

        public int Score { get { return 0; }  }

        public double HighScore { get { return highScore; } }

        public ScoreSummary(int h=0)
        {
            highScore = h;
        }
    }
    public class Tests
    {
        ScoreSummary scoreSummary;
        ScoreSummary withHighScore;
        [SetUp]
        public void Setup()
        {
            scoreSummary = new ScoreSummary();
            withHighScore = new ScoreSummary(150);
        }

        [Test]
        public void Test1()
        {
            Assert.IsNotNull(scoreSummary); ;
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(scoreSummary.Score,0); 
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(withHighScore.HighScore, 150);
        }
        [TearDown]
        public void TearDown()
        {

        }
    }
}