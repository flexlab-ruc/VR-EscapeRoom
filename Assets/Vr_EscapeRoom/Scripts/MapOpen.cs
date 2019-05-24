using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapOpen : MonoBehaviour
{
  
    private Boolean stop;

    //public Transform other;
   private GameObject spawnPoint;

    Animator anima;

    // Start is called before the first frame update
    void Start()
    {
       
        stop = false;
        anima = gameObject.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {

        

        spawnPoint = GameObject.Find("LockedBox");

        

        float dist = Vector3.Distance(spawnPoint.transform.position, transform.position);


        if (dist >= 0.25 && stop == false)
        {
           
            Debug.Log("animate map" + dist);
            GetComponent<Animator>().SetTrigger("MapTrigger");
            stop = true;
        }

     
    }
}
