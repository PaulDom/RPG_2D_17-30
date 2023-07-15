using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn_object;
    public Transform top_point;
    public Transform bottom_point;

    public float spawnInterval = 1f;
    public float spawnTimer = 0f;

    void Update()
    {
        spawnTimer = spawnTimer - Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Vector2 pos_spawn = new Vector2(transform.position.x, Random.Range(bottom_point.position.y, top_point.position.y));
            Instantiate(spawn_object, pos_spawn, Quaternion.identity);
            spawnTimer = spawnInterval;
        } 
    }
}
