using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] TankPrefabs;
    private Vector3 spawnPosition;
    private float xRange;
    private float zRange;
    private float startTime = 2f;
    private float repeatRate = 5f;
    private int randomIndex;
    private float signo;
    private float r = 22;

    void Start()
    {
        InvokeRepeating("SpawnTank", startTime, repeatRate);
    }

    public Vector3 RandomSpawnPosition()
    {
        xRange = Random.Range(-r, r);
        signo = Random.Range(0, 2);
        zRange = (-1 * signo + (1 - signo)) * Mathf.Sqrt(Mathf.Pow(r, 2) - Mathf.Pow(xRange, 2));
        return new Vector3(xRange, 0, zRange);
    }

    public void SpawnTank()
    {
        randomIndex = Random.Range(0, TankPrefabs.Length);
        spawnPosition = RandomSpawnPosition();
        Instantiate(TankPrefabs[randomIndex], spawnPosition, TankPrefabs[randomIndex].transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
