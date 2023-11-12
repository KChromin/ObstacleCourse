using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHit : MonoBehaviour
{
    private Material currentMaterial;
    private bool beenHit = false;

    private void Awake()
    {
        currentMaterial = GetComponent<Renderer>().material;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (beenHit) return;

        if (other.transform.CompareTag("Player"))
        {
            currentMaterial.color = new Color(0.9f, 0, 0.1f);
            Scorer.ObstacleHit.Invoke();
            beenHit = true;
        }
    }
}