using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //float variable moveSpeed determines speed of movement
    public float moveSpeed = 3f;
    //Rigidbody2D component allows player to move
    public Rigidbody2D rb;
    //Stores X and Y user input
    Vector2 movementDirection;

    // Start is called before the first frame update
    void Start()
    {
        //Gets component of type Rigidbody2D on player gameobject
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //assigning horizontal (x) and vertical (y) user input to movementDirection
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    //Use FixedUpdate in case of physics (for rigidbody)
    void FixedUpdate()
    {
        rb.velocity = movementDirection * moveSpeed;
    }
}
