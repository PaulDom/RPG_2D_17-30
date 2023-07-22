using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn_object;
    public Transform top_point;
    public Transform bottom_point;

    public float spawnIntervalMax = 2f;
    public float spawnIntervalMin = 0.5f;
    public float spawnTimer = 0f;

    public int spawnCounter = 3;

    void Update()
    {
        if (LevelController.finished == false)
        {
            spawnTimer = spawnTimer - Time.deltaTime;
            if (spawnTimer <= 0)
            {
                if (spawnCounter > 0)
                {
                    Spawn();
                    spawnCounter = spawnCounter - 1;
                    spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);
                }
            } 
        }    
    }

    public void Spawn()
    {
        Vector2 pos_spawn = new Vector2(transform.position.x, Random.Range(bottom_point.position.y, top_point.position.y));
        Instantiate(spawn_object, pos_spawn, Quaternion.identity);
    }
}
