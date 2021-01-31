using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    public CompletedTask task;

    public bool triggered, dogIn;
    public GameObject dogObj, playerObj;

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
        }
        else
        {
            yRot = Mathf.Lerp(yRot, 0, 5 * Time.deltaTime);
        }
        doorPivot.transform.localEulerAngles = new Vector3(0, yRot, 0);
    }

    public void TriggerDoorEvent()
    {
        if (dogIn)
        {
            triggered = true;
            dogObj.GetComponent<NavMeshMovement>().GoToBowl();
            dogObj.GetComponent<StarTracker>().LoseStars();
            task.Completed = true;
        }
        else
            playerObj.GetComponent<TimedText>().ShowText("Get the dog inside first!", 2.0f);

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
