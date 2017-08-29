using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Livesforhardmode : MonoBehaviour {
	public int lives  = 1;
	public Text livesText;


	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		livesText.text = "Lives : " + lives;

	}
	void OnCollisionEnter( Collision col ) {
		lives--;

		if (lives == 0) {
			Application.LoadLevel ("End Scene");
		}

	}
}
