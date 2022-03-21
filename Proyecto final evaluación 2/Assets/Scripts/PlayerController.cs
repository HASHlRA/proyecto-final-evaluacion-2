using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public GameObject projectilePrefab;
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;
    private AudioSource playerAudioSource;
    private AudioSource cameraAudioSource;
    public AudioClip fireClip;
    private float cooldown = 2f;
    private float lastshoot;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();

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
            shooting();
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameOver();
        }
    }



    void shooting()
    {
        if (Time.time - lastshoot < cooldown)
        {
            return;
        }

        lastshoot = Time.time;
        playerAnimator.SetTrigger("disparo");
        Instantiate(projectilePrefab, transform.position, transform.rotation);
        playerAudioSource.PlayOneShot(fireClip, 0.3f);
   
    }

    private void GameOver()
    {
        {
            // Indica que el juego ha finalizado
            gameOver = true;

            // Bajar el volumen de la música de fondo
            cameraAudioSource.volume = 0.01f;

            // Muestra en consola tu resultado
            Debug.Log($"GAME OVER.");
        }
    }

}
