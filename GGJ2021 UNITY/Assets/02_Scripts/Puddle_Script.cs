using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle_Script : MonoBehaviour
{
    //Define Variables
    public Animation Puddle_anim;
    public AudioSource Puddle_sound;
    public bool isStuck = false;
    public GameObject Marker;

    public CompletedTask task;

    //Public Function for triggering sound effects and animation.
    public void triggerPuddle()
    {
        if (!task.Completed)
        {
            //Puddle_anim = GetComponent<Animation>();
            //foreach (AnimationState state in Puddle_anim)
            //{
            //    state.speed = 1f;
            //}

            //Puddle_sound.Play();
            task.Completed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            isStuck = true;
            Marker.GetComponent<Quest_Marker>().disappear();
        }
    }
}
