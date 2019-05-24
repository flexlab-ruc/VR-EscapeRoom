using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockboxUnlock : MonoBehaviour {
     Animator anim;
    bool boxOpen;
    private bool Stop;
    private bool spawn;


    // Use this for initialization
    void Start () {
        anim = gameObject.GetComponent<Animator>();
        boxOpen = false;
        Stop = false;
	}
	
	// Update is called once per frame
	void Update () {

     if (Stop == true)
        {
            GetComponent<Animator>().SetBool("open", true);

        }
        
	}


    private void OnTriggerEnter(Collider other)
    {
        if ("Key" == other.gameObject.name && Stop == false)
        {
            Stop = true;

        }
    }

   

}
