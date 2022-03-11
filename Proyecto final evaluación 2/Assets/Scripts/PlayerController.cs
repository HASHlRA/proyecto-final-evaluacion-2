using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public GameObject projectilePrefab;
    public ParticleSystem explosionParticleSystem;
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;
    private AudioSource playerAudioSource;
    private AudioSource cameraAudioSource;
    public AudioClip fireClip;

    void Start()
    {
        // Inicializamos las variables
        gameOver = false;

        // Accedemos a las componentes que necesitamos
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();
        cameraAudioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    void Update()
    {
        // Movimiento del tanque
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        // Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
