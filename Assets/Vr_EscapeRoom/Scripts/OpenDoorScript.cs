using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    Animator anima;  
    private AudioSource audioSource;
    public AudioClip doorOpen;
    bool opened;

    // Start is called before the first frame update
    void Start()
    {
        opened = false;
        anima = gameObject.GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
   public void openDoorMethod() 
    {
       if(opened == false) { 
           audioSource.PlayOneShot(doorOpen, 1.0F);
           GetComponent<Animator>().SetBool("OpenDoor", true);
            opened = true;
        }




    }
}
