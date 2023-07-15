using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Spawner spawner_enemy;

    public void Update()
    {
        Check();
    }

    public void Check()
    {
        if (spawner_enemy.spawnCounter <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();
            if (enemies.Length <= 0)
            {
                Victory();
            }
        }

        if (Corn.singleton.hp <= 0)
        {
            Defeat();
        }
    }

    public void Victory()
    {
        print("Victory!");
    }

    public void Defeat()
    {
        print("Defeat!");
    }
}
