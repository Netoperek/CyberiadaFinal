using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            PlatformMenager.curent.InvokeOnaNextPlatform();
        }
    }
}
