using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTracker : MonoBehaviour
{
    public float currentStars, maxStars, starWorth;
    private ParticleTrigger pt;

    public void Awake()
    {
        if (GetComponentInChildren<ParticleTrigger>())
            pt = GetComponentInChildren<ParticleTrigger>();
    }

    public void AddStars()
    {
        currentStars += starWorth;
        if (currentStars > maxStars)
            currentStars = maxStars;
        if (pt != null)
            pt.Fire();
        //TODO: Trigger progress UI animation
    }

    public void AddStars()
    {
        currentStars += starWorth;
        if (currentStars > maxStars)
            currentStars = maxStars;
        //TODO: Trigger progress UI animation
    }

    public void LoseStars()
    {
        currentStars -= starWorth;
        if (currentStars < 0)
            currentStars = 0;
        //TODO: Trigger progress UI animation
    }
}
