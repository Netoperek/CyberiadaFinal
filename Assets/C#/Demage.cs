using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Jeb jeb ale urwa³ XD");
        }
    }
}
