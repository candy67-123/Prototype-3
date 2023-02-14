using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePerafb;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController PlayControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(PlayControllerScript.gameOver == false)
        Instantiate(obstaclePerafb, spawnPos, obstaclePerafb.transform.rotation);
    }
}
