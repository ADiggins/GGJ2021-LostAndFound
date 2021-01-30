using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shampoo_Script : MonoBehaviour
{
    //Defince variables
    public Animation Shampoo_Anim;
    public AudioSource Shampoo_sound;
    public bool shampoo;


    private void Start()
    {
        shampoo = false;
    }

    //Function for shampoo trigger
    public void triggerShampoo()
    {
        //Set shampoo as being taken
        shampoo = true;

        //Shampoo_Anim = GetComponent<Animation>();
        //foreach (AnimationState state in Shampoo_Anim)
        //{
        //    state.speed = 1f;
        //}

        //Shampoo_sound.Play();

        //Destory script so only happens once
        Destroy(this);
    }
}
