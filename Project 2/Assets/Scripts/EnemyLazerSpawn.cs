using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLazerSpawn : MonoBehaviour
{
    public GameObject enemyLazer;
    public float spawnTimer;
    public float maxSpawnTime = 5;
    public float minSpawnTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            Instantiate(enemyLazer, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
        }

    }

}
