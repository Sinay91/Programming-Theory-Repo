using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainScene : MonoBehaviour
{
    public GameObject ball;
    public GameObject bouncingBall;

    private float spawnRangeX = 5;
    private float spawnRangeY = 5;

    public void NewBall()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 2.5f, -3);
        Instantiate(ball, spawnPos, bouncingBall.transform.rotation);
    }

    public void NewBouncingBall()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY, -3);
        Instantiate(bouncingBall, spawnPos, bouncingBall.transform.rotation);
    }
}
