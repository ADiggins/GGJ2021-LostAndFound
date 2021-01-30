using System;
using UnityEngine;

public class StarTracker : MonoBehaviour
{
    public Action<int> OnStarValueChange;

    public float currentStars, maxStars, starWorth;
    private ParticleTrigger pt;
    private TimedText tt;

    public void Awake()
    {
        if (GetComponentInChildren<ParticleTrigger>())
            pt = GetComponentInChildren<ParticleTrigger>();
        if (GetComponent<TimedText>())
            tt = GetComponent<TimedText>();
    }

    public void AddStars()
    {
        currentStars += starWorth;
        if (currentStars > maxStars)
            currentStars = maxStars;
        if (pt != null)
            pt.Fire();
        if (tt != null)
            tt.ShowText("+2", 1.0f);

        OnStarValueChange?.Invoke((int)currentStars);
        //TODO: Trigger progress UI animation
    }

    public void LoseStars()
    {
        currentStars -= starWorth;
        if (currentStars < 0)
            currentStars = 0;

        OnStarValueChange?.Invoke((int)currentStars);
        //TODO: Trigger progress UI animation
    }
}
