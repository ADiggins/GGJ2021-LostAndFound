using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
	public string content;
	public float displayed;
	private ParticleSystem ps;

	private void Awake()
	{
		ps = GetComponent<ParticleSystem>();
	}

	public void Fire()
	{
		ps.Play();
	}
}
