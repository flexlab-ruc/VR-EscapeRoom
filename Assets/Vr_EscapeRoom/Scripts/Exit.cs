using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class Exit : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
        if ("Player" == other.gameObject.tag)
        {
            Debug.Log("inside Player");
            SceneManager.LoadScene("Win", LoadSceneMode.Single);         

        }
    }


 

}
