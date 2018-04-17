using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    ObstacleMovement[] obstacles;
    ObstacleRotation rotation;

	// Use this for initialization
	void Start () {
        obstacles = GetComponentsInChildren<ObstacleMovement>();
        rotation = GetComponent<ObstacleRotation>();
	}

    public void ChangeRotation()
    {
        rotation.IsClockWise = !rotation.IsClockWise;
    }

    public void IncreaseSpeed()
    {
        foreach (ObstacleMovement obst in obstacles)
        {
            if (obstacles[1].Speed < .7f)
            {
                obst.Speed += 0.1f; 
            }
        }
    }
}
