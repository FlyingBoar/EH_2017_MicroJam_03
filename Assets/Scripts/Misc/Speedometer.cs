using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour {

    public Obstacle MainObstacle;

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
            Manager.I.Score++;
        }
    }
}
