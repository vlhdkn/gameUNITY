using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float speed = 7f; // скорость движения
    [SerializeField] private int lives = 5; // кол-во жизней
    [SerializeField] private float jumpforce = 15f; // сила прыжка


    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }


    private void Update()
    {
        if (Input.GetButton("Horizontal"))
        Run();
    }


    private void Run()
    {
    Vector3 dir = transform.right * Input.GetAxis("Horizontal");

    transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }

}

