using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEvent : MonoBehaviour
{
    public NavMeshMovement targetDog;
    public bool triggered = false;
    public GameObject Marker;
    public CompletedTask task;

    public void TriggerFood()
    {
        if (triggered)
            return;
        triggered = true;
        targetDog.GoToBowl();
        Marker.GetComponent<Quest_Marker>().disappear();
        task.Completed = true;
    }
}
