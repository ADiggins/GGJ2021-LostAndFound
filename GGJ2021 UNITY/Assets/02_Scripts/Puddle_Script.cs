using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle_Script : MonoBehaviour
{
    //Define Variables
    public Animation Puddle_anim;
    public AudioSource Puddle_sound;
    public GameObject Dog;

    //Public Function for triggering sound effects and animation.
    public void triggerPuddle()
    {
        Puddle_anim = GetComponent<Animation>();
        foreach (AnimationState state in Puddle_anim)
        {
            state.speed = 1f;
        }

        Puddle_sound.Play();

        //Take charm for successful action
        Dog.GetComponent<StarTracker>().LoseStars();

        //Destroy the script so action cant be played twice
        Destroy(this);
    }
}
