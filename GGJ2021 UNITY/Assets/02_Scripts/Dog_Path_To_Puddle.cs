using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dog_Path_To_Puddle : MonoBehaviour
{
    public GameObject Puddle;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Track();
    }

    private void Track()
    {
        if (Puddle.GetComponent<Puddle_Script>().isStuck == true)
        {
            agent.destination = Puddle.transform.position;
            // When dog reaches destination it is ~2.4 units from puddle
            if (Vector3.Distance(transform.position, Puddle.transform.position) < 2.5f)
            {
                GetComponent<StarTracker>().LoseStars();
                this.enabled = false;
            }
        }
    }
}
