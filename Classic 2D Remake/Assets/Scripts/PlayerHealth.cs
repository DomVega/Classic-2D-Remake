using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public bool autoDeath;
    
    // Start is called before the first frame update
    void Start()
    {
        autoDeath = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -5)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
