using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower_Script : MonoBehaviour
{
    //Define Variables
    public Animation Shower_anim;
    public AudioSource Shower_sound;
    public GameObject Charm;

    //Public Function for triggering sound effects and animation.
    public void triggerShower()
    {
        Debug.Log("Triggered");
        Shower_anim = GetComponent<Animation>();
        foreach (AnimationState state in Shower_anim)
        {
            state.speed = 1f;
        }

        Shower_sound.Play();

        //Take charm for successful action

        //Destroy the script so action cant be played twice
        Destroy(this);
    }

    public void noShampoo()
    {
        Debug.Log("No Shampoo");
        //More to do here with text on the UI
    }
}
