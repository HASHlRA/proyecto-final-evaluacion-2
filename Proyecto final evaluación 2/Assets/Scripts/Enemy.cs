using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRigidbody;
    private GameObject player;
    [SerializeField] private float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(direction * speed);

    }
}
