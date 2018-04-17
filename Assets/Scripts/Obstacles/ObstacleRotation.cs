using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotation : MonoBehaviour {

    public float Speed;
    public bool IsClockWise;

	// Update is called once per frame
	void Update () {
        if (IsClockWise)
            transform.Rotate(Vector3.forward * Time.deltaTime * Speed, Space.World); 
        else
            transform.Rotate(-Vector3.forward * Time.deltaTime * Speed, Space.World);
    }
}
