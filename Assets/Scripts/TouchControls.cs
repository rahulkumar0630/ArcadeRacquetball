
using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour 
{

	public int speed = 10;


	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}



	}
}