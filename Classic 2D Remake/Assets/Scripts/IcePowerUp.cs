using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePowerUp : MonoBehaviour
{
    float multiplier = 1.2f;
    public Animator animator;

    public void OnTriggerEnter2D(Collider2D other)
    {
        Player player = other.GetComponent<Player>();

        if (player != null)
        {
            animator.SetBool("Ice", true);
            player.transform.localScale *= multiplier;
            Destroy(gameObject);
        } 
    }

}
