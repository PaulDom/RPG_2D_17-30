using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 2;
    public int damage = 1;

    void Start()
    {
        Destroy(gameObject, 5);
    }

    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime * transform.up;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Enemy scriptEnemy = collision.gameObject.GetComponent<Enemy>();
            scriptEnemy.takeDamage(damage);
            Destroy(gameObject);
        }
    }
}
