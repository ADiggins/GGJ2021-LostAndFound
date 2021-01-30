using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stink_Script : MonoBehaviour
{
    //Define Variables
    public Animation Stink_anim;
    public AudioSource Stink_sound;
    public GameObject Charm;

    //Public Function for triggering sound effects and animation.
    public void triggerStink()
    {
        Debug.Log("Triggered");
        Stink_anim = GetComponent<Animation>();
        foreach (AnimationState state in Stink_anim)
        {
            state.speed = 1f;
        }

        Stink_sound.Play();

        //Add charm for successful action
         
        //Destroy the script so action cant be played twice
        Destroy(this);
    }
}
