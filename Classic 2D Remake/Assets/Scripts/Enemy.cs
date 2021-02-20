using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float changeTime = 2.0f;

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }
    //Frequency the enemy moves back and forth
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
    }
    //Enemy moves back and forth
    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        position.x = position.x + Time.deltaTime * speed * direction;;
        rigidbody2D.MovePosition(position);
    }
    //Player Death on contact with enemy
    void OnCollisionEnter2D(Collision2D other)
    {
        Player player = other.gameObject.GetComponent<Player>();
    
        if(player != null)
        {
            player.Die();
        }
    }
}
