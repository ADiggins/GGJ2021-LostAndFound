using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror_Script : MonoBehaviour
{
    //Define Variables
    public Animation Mirror_anim;
    public AudioSource Mirror_sound;
    public GameObject Player;
    public GameObject Marker;

    public CompletedTask task;

    //Public Function for triggering sound effects and animation.
    public void triggerMirror()
    {
        if (!task.Completed)
        {
            //Mirror_anim = GetComponent<Animation>();
            //foreach (AnimationState state in Mirror_anim)
            //{
            //    state.speed = 1f;
            //}

            //Mirror_sound.Play();

            //Add Stars for successful action
            Player.GetComponent<StarTracker>().AddStars();

            Marker.GetComponent<Quest_Marker>().disappear();
            task.Completed = true;
        }
    }
}
