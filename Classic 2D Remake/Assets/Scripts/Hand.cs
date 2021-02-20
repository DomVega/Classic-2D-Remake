using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Transform hand;
    public Rigidbody2D projectile;
    public float fireSpeed = 150f;
    public bool icePower = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ice Pick Up"))
        {
            icePower = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    public void Fire()
    {
        if (icePower == true && Input.GetKeyDown(KeyCode.F))
        {
            var firedProjectile = Instantiate(projectile, hand.position, Quaternion.identity);
            firedProjectile.AddForce (hand.right * fireSpeed);
        }      
    }
}
