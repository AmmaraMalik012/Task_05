using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Obstacles : MonoBehaviour
{
    public int spawnPosX = 13;
    // public int spawnLocZ = 20;
    public GameObject obstacle;
    private float spawnInterval = 3f;
    private float startDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // spawning obstacles randomly
    void SpawnObstacles()
    {
        // Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, 0);
        Instantiate(obstacle, transform.position, obstacle.transform.rotation);
    }
}
