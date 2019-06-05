using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public float startTimer = 2;
    private float timer;

    private void Start()
    {
        timer = startTimer;
    }
    void Update()
    {
        if (timer < 1)
        {
            timer = startTimer;
        }
        else
        {
            timer -= Time.deltaTime;
            transform.localScale = Vector3.one * timer;
        }        
    }
}
