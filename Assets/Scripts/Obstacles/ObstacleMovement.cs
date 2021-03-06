﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public bool IsMovingUp;
    public float Speed;

    float startTimer = 1f;
    float timer;
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= startTimer)
        {
            IsMovingUp = !IsMovingUp;
            timer = 0;
        }

        int direction;
        if (IsMovingUp)
        {
            direction = 1;
        }
        else
            direction = -1;

        transform.localPosition += transform.up * Time.deltaTime * Speed * direction;
    }
}
