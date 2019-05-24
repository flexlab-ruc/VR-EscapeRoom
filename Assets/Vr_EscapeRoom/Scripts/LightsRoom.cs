using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsRoom : MonoBehaviour
{

    public Light[] lights;
    public bool lightstate;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= lights.Length; i++)
        {
            lights[i].enabled = lightstate;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }



    public void Switvhlights()
    {
        lightstate = !lightstate;

        for ( int i= 0; i <= lights.Length; i++ )
        {
            lights[i].enabled = lightstate;
        }

     
    }
}
