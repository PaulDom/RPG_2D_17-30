using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Corn singleton;

    void Awake()
    {
        singleton = this;
    }

    void Update()
    {
        
    }
}
