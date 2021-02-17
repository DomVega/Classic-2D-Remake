using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float jump = 8.0f;
    private Rigidbody2D rigidbody2d;
    public bool groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Controls
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space) && groundCheck == true)
        {
            rigidbody2d.velocity = Vector2.up * jump;
        }
    }
}

