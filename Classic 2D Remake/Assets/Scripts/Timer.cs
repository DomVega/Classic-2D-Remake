using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = 45f;
    Text timerText;
    private bool timeIsRunning;

    //public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        timeIsRunning = true;
        timerText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsRunning)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                timerText.text = "Time" + Mathf.Round(timer);

            }

            else 
            {
                timer = 0;
                timeIsRunning = false;
            }
        }
    }
}
