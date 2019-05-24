using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedboxContentSpawn : StateMachineBehaviour
{

    public GameObject scissors1;
    public GameObject map;
    private GameObject spawnPoint;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        spawnPoint = GameObject.Find("LockedBox");


        float X = this.spawnPoint.transform.position.x;
        float Y = this.spawnPoint.transform.position.y;
        float Z = this.spawnPoint.transform.position.z;

        Instantiate(scissors1, new Vector3(X, Y + 0.05f, Z), Quaternion.identity);
        Instantiate(map, new Vector3(X, Y + 0.05f, Z), Quaternion.identity);
        
    }
 
}
