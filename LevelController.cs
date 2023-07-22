using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Spawner spawner_enemy;
    public static bool finished = false;

    public void Update()
    {
        if (finished == false)
        {
            Check();
        }     
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
        finished = true;
    }

    public void Defeat()
    {
        finished = true;
    }
}
