using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeleft;
    public Text countdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;

        TimeSpan t = TimeSpan.FromSeconds(timeleft);  

        countdown.text = t.Minutes.ToString()+ ":"+t.Seconds.ToString();;
        
        if (timeleft <=0)
        {
            Debug.Log("time is up");
            SceneManager.LoadScene("Lose", LoadSceneMode.Single);
        }
    }
}
