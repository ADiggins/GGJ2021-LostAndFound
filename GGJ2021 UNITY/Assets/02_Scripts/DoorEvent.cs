using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEvent : MonoBehaviour
{
	public bool triggered, dogIn;
	public GameObject dogObj;

	private float yRot;
	private GameObject doorPivot;

    // Start is called before the first frame update
    void Start()
    {
		doorPivot = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
		if (triggered)
		{
			yRot = Mathf.Lerp(yRot, 90, 5 * Time.deltaTime);
		} else
		{
			yRot = Mathf.Lerp(yRot, 0, 5 * Time.deltaTime);
		}
		doorPivot.transform.localEulerAngles = new Vector3(0, yRot, 0);
	}

	public void TriggerDoorEvent()
	{
		if (dogIn) 
			triggered = true;
		//TODO: Else don't close the door and report to the player.
		//Correct Dog stars
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Dog")
			dogIn = true;
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.transform.tag == "Dog")
			dogIn = false;
	}
}
