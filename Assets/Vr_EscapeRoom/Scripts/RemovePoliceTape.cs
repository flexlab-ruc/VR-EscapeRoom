using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;


public class RemovePoliceTape : MonoBehaviour
     
{

    public TeleportArea teleportArea;

    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("somehing hit me" + collision.gameObject.name);

        if ("scissors1" == collision.collider.gameObject.name)
        {
          
            this.gameObject.SetActive(false);
            teleportArea.locked = false;

        }
    }
}
