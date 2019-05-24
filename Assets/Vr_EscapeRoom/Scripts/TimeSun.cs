using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSun : MonoBehaviour
{
    public float xAngle = -0.01f, yAngle, zAngle;
  
    Color color0 = Color.white;
    Color color1 = Color.red;
    Light lt;
    private float intensityValue;
    

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        intensityValue = lt.intensity;       
    }

    // Update is called once per frame
    void Update()
    {
       

        
   


        if (lt.transform.rotation.x >= -0.001f)
        {
            lt.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
         
        }
        else
        {

            lt.intensity -= intensityValue / 10;
          
        }
    }
}
