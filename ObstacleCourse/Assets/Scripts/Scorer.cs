using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField]
    private int numberOfObstacleHits;

    public static Action ObstacleHit;

    private void Start()
    {
        ObstacleHit += ObstacleHitCount;
    }

    private void ObstacleHitCount()
    {
        numberOfObstacleHits++;
    }

    public int GetObstacleHits()
    {
        return numberOfObstacleHits;
    }
    
}