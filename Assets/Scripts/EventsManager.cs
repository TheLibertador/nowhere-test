using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public static EventsManager Instance{ get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public event Action onBallGenerated;

    public void BallGenerated()
    {
        if (onBallGenerated != null)
        {
            onBallGenerated();
        }
    }
}
