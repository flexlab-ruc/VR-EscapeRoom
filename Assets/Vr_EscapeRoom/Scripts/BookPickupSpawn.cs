using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPickupSpawn : MonoBehaviour
{
    private Double xPos;
    private Double yPos;
    private Double zPos;
    public GameObject sheet;
    private Boolean stop ;
    private AudioSource audioSource;// where to sound is to be played from
    public AudioClip movingSound;//moving sound 

    // Start is called before the first frame update
    void Start()
    {
        xPos = Math.Round(gameObject.transform.position.x, 1);
        yPos = Math.Round(gameObject.transform.position.y, 1);
        zPos = Math.Round(gameObject.transform.position.z, 1);
        stop = false;
       
    }

    // Update is called once per frame
    void Update()
    {


        if (stop == false)
        {
            if (zPos != Math.Round(gameObject.transform.position.z, 1))
            {

                Debug.Log("instatiate");
                stop = true;
                Instantiate(sheet, new Vector3((float)xPos - 0.4f, (float)yPos, (float)zPos), Quaternion.identity);

                audioSource.PlayOneShot(movingSound, 0.7F);//play the sound
            }
                
        }

    }



  
}
