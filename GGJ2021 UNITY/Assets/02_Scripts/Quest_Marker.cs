using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Quest_Marker : MonoBehaviour
{
    //Assign Variables
    public float amplitude = 0.5f;
    public float frequency = 1f;
    public Transform leader;
    public float followSharpness = 0.1f;
    Vector3 _followOffset;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    void Start()
    {
        // Store the starting position of the object
        posOffset = transform.position;
        _followOffset = transform.position - leader.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }

    void LateUpdate()
    {
        // Apply that offset to get a target position.
        Vector3 targetPosition = leader.position + _followOffset;

        // Keep our y position unchanged.
        targetPosition.y = transform.position.y;

        // Smooth follow.    
        transform.position += (targetPosition - transform.position) * followSharpness;
    }
}
