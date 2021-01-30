using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTracker : MonoBehaviour
{
	public float currentStars, maxStars, starWorth;
    
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
