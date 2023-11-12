using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private bool finished;

    private void OnTriggerEnter(Collider other)
    {
        if (finished) return;
        
        if (other.transform.CompareTag("Player"))
        {
            FinishUIController.OnFinish.Invoke(GameObject.FindWithTag("GameController").GetComponent<Scorer>().GetObstacleHits());
            finished = true;
        }
    }
}