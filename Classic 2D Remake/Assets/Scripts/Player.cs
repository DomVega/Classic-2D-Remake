using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float jump = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Controls
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + 5.0f * horizontal * Time.deltaTime;
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * jump);
    }

}
