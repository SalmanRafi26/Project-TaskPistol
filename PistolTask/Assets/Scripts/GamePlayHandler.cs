using System;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayHandler : MonoBehaviour
{
    public static GamePlayHandler instance;

    [Header("Player")]
    public float PlayerRadius;
    [SerializeField] private Transform ThePlayer;
    public List<ObstacleStat> ObstacleList = new List<ObstacleStat>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddObstacle(Transform transform)
    {
        ObstacleStat OS = new ObstacleStat();
        OS.TheObstacle = transform;
        OS.DistanceFromPlayer = 0;
        ObstacleList.Add(OS);
    }
    private void Update()
    {
        for (int i = 0; i < ObstacleList.Count; i++)
        {
            ObstacleList[i].DistanceFromPlayer = Vector3.Distance(ThePlayer.transform.position, ObstacleList[i].TheObstacle.position);
        }
        ObstacleList.Sort((a, b) => a.DistanceFromPlayer.CompareTo(b.DistanceFromPlayer));
    }
    public Transform GetNearestObstacle()
    {
        if (ObstacleList[0].DistanceFromPlayer <= PlayerRadius)
        {
            return ObstacleList[0].TheObstacle;   
        }
        else
        {
            return null;
        }
    }
}

[Serializable]
public class ObstacleStat
{
    public Transform TheObstacle;
    public float DistanceFromPlayer;
}
