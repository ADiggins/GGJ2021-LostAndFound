using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror_Script : MonoBehaviour
{
    //Define Variables
    public Animation Mirror_anim;
    public AudioSource Mirror_sound;
    public GameObject Charm;

    //Public Function for triggering sound effects and animation.
    public void triggerMirror()
    {
        Mirror_anim = GetComponent<Animation>();
        foreach (AnimationState state in Mirror_anim)
        {
            state.speed = 1f;
        }

        Mirror_sound.Play();

        //Add charm for successful action
        Charm.GetComponent<Charm>().charm += 2;
        //Destroy the script so action cant be played twice
        Destroy(this);
    }
}
