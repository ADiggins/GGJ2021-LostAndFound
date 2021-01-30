using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
	public KeyCode interactKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerStay(Collider other)
	{
		//Key interactions//
		if (Input.GetKeyDown(interactKey))
		{
			if (other.transform.tag == "Shower")
			{
				//trigger shower event
			}
			if (other.transform.tag == "Shampoo")
			{
				//trigger shampoo event
			}
			if (other.transform.tag == "Training")
			{
				//trigger training minigame event
			}
			if (other.transform.tag == "Mirror")
			{
				//trigger mirror event
			}
			if (other.transform.tag == "Protection")
			{
				//trigger protection event
			}
			if (other.transform.tag == "Stink")
			{
				//trigger stink event
			}
			if (other.transform.tag == "Puddle")
			{
				//trigger puddle event
			}
			if (other.transform.tag == "Food")
			{
				other.GetComponent<FoodEvent>().TriggerFood();
			}
			if (other.transform.tag == "Door")
			{
				//trigger door event
			}
		}

		//Passive events
		if (other.transform.tag == "Performance")
		{
			other.GetComponentInParent<PerformanceZone>().triggerPerformanceZone();
		}
	}
}
