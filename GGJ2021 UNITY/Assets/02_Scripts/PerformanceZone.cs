using UnityEngine;

public class PerformanceZone : MonoBehaviour
{
    public CompletedTask task;
    public bool triggered = false;
    public GameObject playerObj;
    public GameObject Marker;

    public void triggerPerformanceZone()
    {
        if (triggered || task.Completed)
            return;
        triggered = true;
        playerObj.GetComponent<StarTracker>().AddStars();
        task.Completed = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
            triggerPerformanceZone();
        Marker.GetComponent<Quest_Marker>().disappear();
    }
}
