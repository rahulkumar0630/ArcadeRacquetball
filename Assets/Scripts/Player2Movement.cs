﻿
using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour 
{

	public int speed = 10;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		}
	}
}