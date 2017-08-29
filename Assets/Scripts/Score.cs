using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {
	public static int score;
	public Text player1score;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		player1score.text = "Score : " + score;
			

	}
	void OnCollisionEnter( Collision col ) {
		score++;


	}
}
