using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = 45f;
    public Text timerText;
    private bool timeIsRunning;
    public GameObject player;
    private Player playerScript;

    //public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<Player>();
        timeIsRunning = true;

    }

    // Update is called once per frame
    void Update()
    {
        Player playerScript = player.gameObject.GetComponent<Player>();
        if (timeIsRunning)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                timerText.text = "Time" + Mathf.Round(timer);

            }

            else 
            {
                timer = 45;
                timeIsRunning = true;
                playerScript.Die();
            }
        }
    }
}
