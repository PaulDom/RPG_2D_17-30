using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 2;

    void Start()
    {
        Destroy(gameObject, 5);
    }

    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime * transform.up;
    }
}
