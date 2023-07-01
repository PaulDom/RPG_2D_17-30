using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public GameObject prefabArrow;
    public float shootInterval = 0.5f;
    public float shootTimer = 0;

    void Update()
    {
        shootTimer -= Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if (shootTimer <= 0)
            {
                Instantiate(prefabArrow, transform.position, transform.rotation);
                shootTimer = shootInterval;
            }
        }

        Vector2 mouseScreenPos = Input.mousePosition;
        Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
        Vector2 bowPos = transform.position;

        Vector2 wantedDirection = mouseScenePos - bowPos;
        Vector2 defaultDirection = Vector2.up;

        float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);

        Vector3 newEuler = new Vector3(0, 0, angle);
        transform.localEulerAngles = newEuler;
    }
}
