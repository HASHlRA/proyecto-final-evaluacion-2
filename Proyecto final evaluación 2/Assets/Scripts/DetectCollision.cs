using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        // Destruyo el proyectil
        Destroy(gameObject);

        // Destruyo el tanque contra el que colisiona
        Destroy(otherCollider.gameObject);
    }
}
