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
    public GameObject Marker;

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

            Shower_sound.Play();

            //Take charm for successful action
            Player.GetComponent<StarTracker>().AddStars();

            Marker.GetComponent<Quest_Marker>().disappear();
            //Destroy the script so action cant be played twice
            Destroy(this);
        }

        else
        {
			Player.GetComponent<TimedText>().ShowText("No Shampoo", 2.0f);
        }
    }
}
