using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    public static ObstaclesManager instance { get; private set; }
    Queue<GameObject> posObstacles;
    List<Queue<GameObject>> obstacles;
    Queue<GameObject> obstaclesType_01;
    Queue<GameObject> obstaclesType_02;
    Queue<GameObject> obstaclesType_03;


    [SerializeReference] List<GameObject> _posObstacles;
    [SerializeReference] List<Queue<GameObject>> _obstacles;
    [SerializeReference] List<GameObject> _obstaclesType_01;
    [SerializeReference] List<GameObject> _obstaclesType_02;
    [SerializeReference] List<GameObject> _obstaclesType_03;



    /// <summary>
    /// Rodzaje Przeszkód które s¹ dostêpne;
    /// </summary>
    /// <returns></returns>
    public ref List<Queue<GameObject>> GetObstacles()
    {
        return ref obstacles;
    }
    /// <summary>
    /// No te œmieszne pozycje przeszkód;
    /// </summary>
    /// <returns></returns>
    public ref List<Queue<GameObject>> GetPosObstacles()
    {
        return ref obstacles;
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
    }
}
