using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SequenceChecker : MonoBehaviour
{
    public int[] sequence;// set length and input in unity inspector
    private bool locked;
    public int config; // To know if we need to open the piano or the drawer
                            // 0 is for the drawer 
                            // 1 is for the piano

    private List<int> inputSequence = new List<int>();// list for containing input form buttons
    public LinearDrive_Project linearDrive_Project;//the steamvr script to be affected by this script
    public MovePianoPart movePianoPart;//
    public AudioClip wrongSeq;// audio wrong
    public AudioClip correctSeq;//audio correct
    private AudioSource audioSource;// where to sound is to be played from

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();// finds audio soruce in gameobeject
        locked = false; // set inital state to false AKA locked
    }


    // method to be executted when button is pressed in VR
    public void AddToInputSequence(int pressedInput)
    {
        //This is to check the 
        //With this script everytime we get an input which maches the first one our Array gets reseted, so we could not make a sequence (in the piano) with the first tale twice
        //We wanted out game puzzle to mach our pianoo score but we could not make it
        
        if (inputSequence.Count==sequence.Length || sequence[0] == pressedInput)
            inputSequence.Clear();
        
        inputSequence.Add(pressedInput); // ad button value to list
        CompareSequences();
        switch (config) { 
            case 0:
                UnlockDrawer();
                break;
            case 1:    
                openPiano();
                break;
        }
    }



    //goes trough length of inputSequence and compares with  sequence if all id correct, locked bool ends up false(note that lenght of both array i comapred in  Unlock() method);
    private void CompareSequences()
    {
        locked = false ;
        int i = 0;
        while ( i < inputSequence.Count && locked == false)
        {
            Debug.Log("inputSequence" + inputSequence[i]);
           // Debug.Log("sequence" + sequence[i]);

            if (inputSequence[i] != sequence[i])
            {
                locked = true;
                //Debug.Log("locked == false" );

            }
          
            i++;
        }

    }




    private void openPiano()
    {
        if (locked == false && inputSequence.Count == sequence.Length)// checks if false and list and array is same length
        {
            Debug.Log("Correct sequence");
            this.movePianoPart.makeItTrue();
            audioSource.PlayOneShot(correctSeq, 0.7F);//play correct sound
        }
        else if (locked == true && inputSequence.Count == sequence.Length - 1)
        {
            Debug.Log("Wrong sequence");
            audioSource.PlayOneShot(wrongSeq, 0.7F);//play wrong sound
        }
    }


    private void UnlockDrawer()
    {
        if (locked == false && inputSequence.Count == sequence.Length)// checks if false and list and array is same length
        {
            linearDrive_Project.SetArrayPos(1);//sets linear drive pos to index1
            audioSource.PlayOneShot(correctSeq, 0.7F);//play correct sound
        }
        else if (locked == true && inputSequence.Count == sequence.Length-1) {
            audioSource.PlayOneShot(wrongSeq, 0.7F);//play wrong sound
        }

    }

}
