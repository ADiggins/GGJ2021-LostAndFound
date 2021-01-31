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

    public CompletedTask task;

    //Public Function for triggering sound effects and animation.
    public void triggerShower()
    {
        if (task.Completed)
        {
            return;
        }

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
            task.Completed = true;
        }

        else
        {
            Player.GetComponent<TimedText>().ShowText("You can't shower without shampoo!", 2.0f);
        }
    }
}
