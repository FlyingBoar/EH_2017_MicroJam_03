using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour {

    public Obstacle MainObstacle;

    private int score;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            Manager.I.SetScore(score);
        }
    }


    int count;
    int Count
    {
        get { return count; }
        set {
            count = value;

            if(count == 3)
            {
                MainObstacle.ChangeRotation();
            }

            if (count == 4)
            {
                MainObstacle.IncreaseSpeed();
                count = 0;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Speedometer")
        {
            Count++;
            Score++;
        }
    }
}
