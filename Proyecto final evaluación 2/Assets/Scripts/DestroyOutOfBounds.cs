using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLim = 25f;
    private float lowerLim = -25f;

    void Update()
    {
        // Bala fallida

        if (transform.position.x > upperLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < lowerLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < lowerLim)
        {
            Destroy(gameObject);
        }
    }
}
