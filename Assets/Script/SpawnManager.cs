
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] stalker;

    private float spawnRangeX = 140;
    private float spawnRangeZ = 120;

    private float starDelay = 5;
    private float spawnInterval = 10.5f;

    private PlayerController playerControllerScript;
    public bool gameOver = false;



    // Start is called before the first frame update
    void Start()
    {
        //repeat spawning with interval
        InvokeRepeating("SpawnRandomStalker", starDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomStalker()
    {
        //Randomly generate animal Index and spawn position
        if (playerControllerScript.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            int stalkerIndex = Random.Range(0, stalker.Length);

            Instantiate(stalker[stalkerIndex], spawnPos, stalker[stalkerIndex].transform.rotation);
        }


    }

}