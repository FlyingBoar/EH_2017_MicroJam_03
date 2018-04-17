using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody rigid;
    public float Speed;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (rigid != null)
            {
                rigid.AddForce(Vector3.up * Speed, ForceMode.Impulse); 
            }
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            Manager.I.GameOver();
        }
    }
}
