using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower_Script : MonoBehaviour
{

    public Animation Shower_anim;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void triggerShower()
    {
        Shower_anim = GetComponent<Animation>();

        foreach (AnimationState state in Shower_anim)
        {
            state.speed = 0.5f;
        }
    }
}
