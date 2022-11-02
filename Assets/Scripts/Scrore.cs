using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrore : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("you have bumped on to this many times: " + hits);
        }
    }

}
