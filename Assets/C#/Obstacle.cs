using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeReference] GameObject _obstacleItam;
    private void SetObstacled()
    {
       _obstacleItam = ObstaclesManager.instance.GetRandomObstacle();
    }
    private void OnEnable()
    {
       _obstacleItam.SetActive(true);
    }
    private void OnDisable()
    {
        _obstacleItam.SetActive(false);
    }
    private void Start()
    {
        SetObstacled();
    }
}
