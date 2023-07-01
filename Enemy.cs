using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1;
    public int hp = 4;

    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime * -transform.right;
    }

    public void takeDamage(int damage)
    {
        hp = hp - damage;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
