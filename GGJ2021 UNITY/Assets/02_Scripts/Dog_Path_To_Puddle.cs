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

            if (agent.destination == Puddle.transform.position)
            {
                GetComponent<StarTracker>().LoseStars();
            }
        }
    }
}
