using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1;
    public int hp = 4;
    public float posX;
    public Animator animator;

    void Start()
    {
        posX = Corn.singleton.transform.position.x;
    }

    void Update()
    {
        if (transform.position.x > posX)
        {
            animator.SetBool("isMoving", true);
            transform.position = transform.position + speed * Time.deltaTime * -transform.right; 
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
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
