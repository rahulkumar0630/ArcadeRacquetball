﻿using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour
{
	public float ballVelocity = 3000;

	Rigidbody rb;
	bool isPlay;
	int randInt;

	void Awake()
	{
		rb = GetComponent<Rigidbody>();
		randInt = Random.Range(1,3);
	}

	void Update()
	{
		if (Input.touchCount == 1 && isPlay == false)
		{
			transform.parent = null;
			isPlay = true;
			rb.isKinematic = false;
			if (randInt == 1)
			{
				rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
			}
			if (randInt == 2)
			{
				rb.AddForce(new Vector3(-ballVelocity, -ballVelocity, 0));
			}
		}

	}

	void OnCollisionEnter( Collision col ) {


		AudioSource audio = GetComponent<AudioSource>();
		audio.Play ();

			

	}

}