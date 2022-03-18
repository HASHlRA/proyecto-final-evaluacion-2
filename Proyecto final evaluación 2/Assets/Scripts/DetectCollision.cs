using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ParticleSystem explosionParticleSystem;
    private void OnTriggerEnter(Collider otherCollider)
    {
        // Destruyo el tanque contra el que colisiona
        Destroy(otherCollider.gameObject);

        Instantiate(explosionParticleSystem, transform.position, explosionParticleSystem.transform.rotation);
        //explosionParticleSystem.Play();

        // Destruyo el proyectil
        Destroy(gameObject);

    }
}
