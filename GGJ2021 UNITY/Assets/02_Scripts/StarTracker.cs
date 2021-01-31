using System;
using UnityEngine;

public class StarTracker : MonoBehaviour
{
    public Action<int> OnStarValueChange;

    public float currentStars, maxStars, starWorth;
	public AudioSource ac;

    private ParticleTrigger pt;
    private TimedText tt;

    public void Awake()
    {
        if (GetComponentInChildren<ParticleTrigger>())
            pt = GetComponentInChildren<ParticleTrigger>();
        if (GetComponent<TimedText>())
            tt = GetComponent<TimedText>();
		if (GetComponent<AudioSource>() && ac==null)
			ac = GetComponent<AudioSource>();
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
		ac.Play();

        OnStarValueChange?.Invoke((int)currentStars);
        //TODO: Trigger progress UI animation
    }

    public void LoseStars()
    {
        currentStars -= starWorth;
        if (currentStars < 0)
            currentStars = 0;
		ac.Play();

		OnStarValueChange?.Invoke((int)currentStars);
        //TODO: Trigger progress UI animation
    }
}
