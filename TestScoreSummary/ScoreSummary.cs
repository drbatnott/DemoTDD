using System;

public class ScoreSummary
{
    private int highScore;

    public int Score { get { return 0; } }

    public double HighScore { get { return highScore; } }

    public ScoreSummary(int h = 0)
    {
        highScore = h;
    }
}