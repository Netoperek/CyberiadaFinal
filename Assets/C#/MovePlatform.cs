using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{

    public void StartMove()
    {
        StartCoroutine(MoveAsset());
    }
    private void Move()
    {
        transform.position -= Vector3.forward * PlatformMenager.curent.speed;
    }
    public void StopMove()
    {
        StopAllCoroutines();
    }
    IEnumerator MoveAsset()
    {
        while (true)
        {

            this.Move();
            yield return new WaitForFixedUpdate();
        }
    }
    private void OnEnable()
    {
        
    }
    private void Start()
    {
        StartMove();
    }
    private void OnDisable()
    {
        StopMove();
    }

}
