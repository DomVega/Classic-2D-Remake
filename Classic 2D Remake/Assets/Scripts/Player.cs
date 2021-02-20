using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
To Do
1.Make Item block script 
2.Code taking damage and make checks for damage and size 
3.Kill enemy
4.Need power up animations and empty item block sprite.
5.Might need to rework enemy movement. Might need Block breaking anim. and sprite.
6.Maybe bounce projectile 
*/
public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public float jump = 8.0f;
    float horizontal;
    private Rigidbody2D rigidbody2d;
    public bool groundCheck;
    
    public Text livesText;
    public int lives;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //playerHealth = GetComponent<PlayerHealth>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        //lives = PlayerPrefs.GetInt("Lives: ", 4);
        lives = 3;
        LivesText();
     
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();  

           /*if (lives <= 0)
        {
            lives = 3;
            LivesText();
            GameOver();
           
        }
        */
        

         if(gameObject.transform.position.y < -6)
        {
            Die();
        }
    }
    
    //Needs Rework
    void PlayerMove()
    {
        //Controls
        horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        transform.position = position;

        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if (Input.GetKeyDown(KeyCode.Space) && groundCheck == true)
        {
            rigidbody2d.velocity = Vector2.up * jump;
        }
    }
    //Displays lives and sends player to main menu when lives reach 0.
    public void LivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
    }

    /*public void Damage()
    {
        
    }
    */
    //moved Die method to player script for simplicity.
    public void Die()
    {
        lives--;
        LivesText();
        //PlayerPrefs.SetInt("Lives: ", lives);
        //PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /*void GameOver()
    {
        if(lives==0)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
    */
}

