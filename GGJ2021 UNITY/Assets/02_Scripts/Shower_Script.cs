using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower_Script : MonoBehaviour
{
    //Define Variables
    public Animation Shower_anim;
    public AudioSource Shower_sound;

    //Public Function for triggering sound effects and animation.
    public void triggerShower()
    {
        Shower_anim = GetComponent<Animation>();
        foreach (AnimationState state in Shower_anim)
        {
            state.speed = 0.5f;
        }
        Shower_sound.Play();

    }
}
