using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesPos : MonoBehaviour
{
    [SerializeReference] GameObject _obstaclePosItam;
    private void SetPosObstacled()
    {
        _obstaclePosItam = ObstaclesManager.instance.GetRandomPosObstacle();
    }
    private void OnEnable()
    {
        _obstaclePosItam.SetActive(true);
    }
    private void OnDisable()
    {
        _obstaclePosItam.SetActive(false);
    }
   
}
