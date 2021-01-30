using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shampoo_Script : MonoBehaviour
{
    //Defince variables
    public Animation Shampoo_Anim;
    public AudioSource Shampoo_sound;

    //Function for shampoo trigger
    public void triggerShampoo()
    {
        Shampoo_Anim = GetComponent<Animation>();
        foreach (AnimationState state in Shampoo_Anim)
        {
            state.speed = 1f;
        }

        Shampoo_sound.Play();

        Destroy(this);
    }
}
