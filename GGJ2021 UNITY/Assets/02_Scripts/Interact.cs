using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
	public KeyCode interactKey;
	public GameObject Shampoo;
    // Start is called before the first frame update
    void Start()
    {
		Shampoo = GameObject.Find("Shampoo");
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
				if (Shampoo.GetComponent<Shampoo_Script>().shampoo == true)
                {
					other.GetComponent<Shower_Script>().triggerShower();
				}

                else
                {
                }

			}
			if (other.transform.tag == "Shampoo")
			{
				other.GetComponent<Shampoo_Script>().triggerShampoo();
			}
			if (other.transform.tag == "Training")
			{
				//trigger training minigame event
			}
			if (other.transform.tag == "Mirror")
			{
				other.GetComponent<Mirror_Script>().triggerMirror();
			}
			if (other.transform.tag == "Protection")
			{
				other.GetComponent<Protection_Script>().triggerProtection();
			}
			if (other.transform.tag == "Stink")
			{
				other.GetComponent<Stink_Script>().triggerStink();
			}
			if (other.transform.tag == "Puddle")
			{
				other.GetComponent<Puddle_Script>().triggerPuddle();
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
