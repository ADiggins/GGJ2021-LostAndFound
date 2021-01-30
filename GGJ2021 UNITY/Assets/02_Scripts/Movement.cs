using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float moveSpeed, jumpForce, sensitivity;
	public float cameraClampMin, cameraClampMax;

	private Rigidbody rb;
	private GameObject cameraObj, modelObj;
	private Quaternion lookRotation;
	private float xRot, forwardSpeed, sideSpeed;
	private Vector3 forwardVector;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		cameraObj = Camera.main.gameObject;
		modelObj = transform.Find("Skunk Model").gameObject;
		Cursor.lockState = CursorLockMode.Locked;
		xRot = cameraObj.transform.eulerAngles.x;
    }

	private void FixedUpdate()
	{
		rb.velocity = forwardVector + (transform.up * rb.velocity.y);
		//rb.angularVelocity = new Vector3(0, 100, 0);
	}

	// Update is called once per frame
	void Update()
	{
		//Object Movement		
		forwardSpeed = Input.GetAxis("Vertical") * moveSpeed;
		sideSpeed = Input.GetAxis("Horizontal") * moveSpeed;
		forwardVector = (transform.forward * forwardSpeed) + (transform.right * sideSpeed);
		

		//Object turning//
		transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime, 0);

		//Camera turning//
		xRot -= Input.GetAxis("Mouse Y") * sensitivity / 2 * Time.deltaTime;
		xRot = Mathf.Clamp(xRot, cameraClampMin, cameraClampMax);
		Vector3 newRotation = new Vector3(xRot, 0, 0);
		cameraObj.transform.localEulerAngles = new Vector3(xRot, 0, 0);

		//Model turning//
		if (forwardVector != Vector3.zero)
			lookRotation = Quaternion.LookRotation(forwardVector);
		modelObj.transform.rotation = Quaternion.Slerp(modelObj.transform.rotation, lookRotation, 5 * Time.deltaTime);

		//jumping//
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (Physics.Raycast(transform.position, Vector3.down, 1.0f))
				rb.AddForce(0, jumpForce, 0);
		}
	}
}
