using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEvent : MonoBehaviour
{
	public NavMeshMovement targetDog;
	public bool triggered = false;

	public void TriggerFood()
	{
		if (triggered)
			return;
		triggered = true;
		targetDog.GoToBowl();
	}
}
