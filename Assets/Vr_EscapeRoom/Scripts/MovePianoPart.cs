using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePianoPart : MonoBehaviour
{
  
    public float speed = 1.0f;
    public Transform source;
    public Transform target;
    public Rigidbody rb;
    private AudioSource audioSource;// where to sound is to be played from
    public AudioClip movingSound;//moving sound 

    public bool start  = false ;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();// finds audio soruce in gameobeject
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            rb.isKinematic = false;
            float step = speed * Time.deltaTime; // calculate distance to move
            source.transform.position = Vector3.MoveTowards(source.transform.position, target.position, step);

            Debug.Log(Vector3.Distance(source.transform.position, target.position));

            if (Vector3.Distance(source.transform.position, target.position) < 0.301f)
            {
                start = false;
            }

            audioSource.PlayOneShot(movingSound, 0.7F);//play the sound
        }
    }

    public void makeItTrue(){
        start = true;
    }

}
