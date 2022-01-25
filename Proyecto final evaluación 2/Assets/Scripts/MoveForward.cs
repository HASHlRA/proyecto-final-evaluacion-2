using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Movmimiento hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
