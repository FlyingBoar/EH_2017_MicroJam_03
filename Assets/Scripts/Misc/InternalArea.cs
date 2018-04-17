using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InternalArea : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>() != null)
            Manager.I.GameOver();
    }
}
