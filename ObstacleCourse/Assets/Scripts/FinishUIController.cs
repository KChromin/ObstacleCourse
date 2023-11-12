using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class FinishUIController : MonoBehaviour
{
    [SerializeField]
    private GameObject scoreObject;

    [SerializeField]
    private TextMeshProUGUI timeText;

    [SerializeField]
    private TextMeshProUGUI objectHitText;

    public static Action<int> OnFinish;

    private void OnEnable()
    {
        OnFinish += OnFinishDrawUI;
    }

    private void OnFinishDrawUI(int objectHits)
    {
        scoreObject.SetActive(true);
        timeText.SetText("Your time in seconds: " + Time.realtimeSinceStartup.ToString("F2"));
        objectHitText.SetText("Obstacle Hits: " + objectHits);
    }
}