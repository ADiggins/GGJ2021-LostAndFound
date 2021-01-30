using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
	private NavMeshAgent agent;
	public float journeyLength;
	public bool triggered = false;
	public GameObject bowl;

    // Start is called before the first frame update
    void Start()
    {
		agent = GetComponent<NavMeshAgent>();
		PickRandomDestination();
    }

    // Update is called once per frame
    void Update()
    {
		if (agent.remainingDistance < 1 && !triggered)
			PickRandomDestination();
    }

	public void PickRandomDestination()
	{
		Vector3 randomDirection = transform.position + (Random.insideUnitSphere * journeyLength);
		NavMeshHit hit;
		if (NavMesh.SamplePosition(randomDirection, out hit, journeyLength, 1))
			agent.SetDestination(hit.position);
		else
			PickRandomDestination();
	}

	public void GoToBowl()
	{
		triggered = true;
		agent.SetDestination(bowl.transform.GetChild(0).transform.position);
	}
}
