using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flaspStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flaspStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
