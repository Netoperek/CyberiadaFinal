using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    public static ObstaclesManager instance { get; private set; }

    [SerializeReference] List<GameObject> _posObstacles;
    List<List<GameObject>> _obstacles;
    [SerializeReference] List<GameObject> _obstaclesType_01;
    [SerializeReference] List<GameObject> _obstaclesType_02;
    [SerializeReference] List<GameObject> _obstaclesType_03;

    public GameObject GetRandomObstacle()
    {

        int index = UnityEngine.Random.Range(0, _obstacles.Count);

        for (int i = 0; i < _obstacles[index].Count; i++)
        {
            if (_obstacles[index][i].activeSelf == false)
            {
                return _obstacles[index][i];
            }
        }

        for (int i = 0; i < _obstacles.Count; i++)
        {
            for (int ii = 0; ii < _obstacles[i].Count; ii++)
            {
                if (_obstacles[i][ii].activeSelf == false)
                {
                    return _obstacles[i][ii];
                }
            }

        }
        return null;
    }

    public GameObject GetRandomPosObstacle()
    {

        int index = UnityEngine.Random.Range(0, _posObstacles.Count);
        if (!_posObstacles[index].activeSelf)
        {
            return _posObstacles[index];
        }
        else
        {
            for (int i = 0; i < _posObstacles.Count; i++)
            {
                if (!_posObstacles[i].activeSelf)
                {
                    return _posObstacles[i];
                }
            }
        }
        
        return null;
    }

    /// <summary>
    /// Rodzaje Przeszkód które s¹ dostêpne;
    /// </summary>
    /// <returns></returns>
    public List<List<GameObject>> GetObstacles()
    {
        return _obstacles;
    }
    /// <summary>
    /// No te œmieszne pozycje przeszkód;
    /// </summary>
    /// <returns></returns>
    public List<GameObject> GetPosObstacles()
    {
        return _posObstacles;
    }
    private void OnEnable()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
        _obstacles = new List<List<GameObject>>();
        _obstacles.Add(_obstaclesType_01);
        _obstacles.Add(_obstaclesType_02);
        _obstacles.Add(_obstaclesType_03);
    }
}
