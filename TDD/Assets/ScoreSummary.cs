using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreSummary : MonoBehaviour
{
    public class ScoreSummaryTested
    {
        private int highScore;
        public int Score { get { return 0; } }
        public double HighScore { get { return highScore; } }
        public ScoreSummaryTested(int h = 0)
        {
            highScore = h;
        }
    }
    TextReader tr;
    ScoreSummaryTested sstd;
    // Start is called before the first frame update
    void Start()
    {
        tr = new StreamReader("ScoreData.csv");
        string input;
        List<string> partsList = new List<string>();
        while ((input = tr.ReadLine()) != null)
        {
            //Debug.Log(input);
            string [] parts = input.Split(',');
            //Debug.Log("Read " + parts[0] + " " + parts[1]);
            partsList.Add(parts[0]);
            partsList.Add(parts[1]);
        }
        tr.Close();
        for(int i = 0; i <partsList.Count; i += 2)
        {
            Debug.Log(partsList[i] + " " + partsList[i + 1]);
        }
        int h2 = System.Int32.Parse(partsList[1]);
        ScoreSummaryTested sst1 = new ScoreSummaryTested();
        ScoreSummaryTested sst2 = new ScoreSummaryTested(h2);
        Debug.Log("sst1 high score " + sst1.HighScore);
        Debug.Log("sst2 high score " + sst2.HighScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
