using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerformanceZone : MonoBehaviour
{
	public bool triggered = false;
	public GameObject playerObj;
	public GameObject Marker;

	public void triggerPerformanceZone()
	{
		if (triggered)
			return;
		triggered = true;
		playerObj.GetComponent<StarTracker>().AddStars();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Player")
			triggerPerformanceZone();
		Marker.GetComponent<Quest_Marker>().disappear();
	}
}
