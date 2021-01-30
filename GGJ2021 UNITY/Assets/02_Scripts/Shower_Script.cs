using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower_Script : MonoBehaviour
{
    //Define Variables
    public Animation Shower_anim;
    public AudioSource Shower_sound;
    public GameObject Player;
    public GameObject Shampoo;

    //Public Function for triggering sound effects and animation.
    public void triggerShower()
    {
        if (Shampoo.GetComponent<Shampoo_Script>().shampoo == true)
        {
            //Shower_anim = GetComponent<Animation>();
            //foreach (AnimationState state in Shower_anim)
            //{
            //   state.speed = 1f;
            //}

            //Shower_sound.Play();

            //Take charm for successful action
            Player.GetComponent<StarTracker>().AddStars();

            //Destroy the script so action cant be played twice
            Destroy(this);
        }

        else
        {
            Debug.Log("No Shampoo");
            //More to do here with text on the UI
        }
    }
}
