using UnityEngine;
using System.Collections;

public class Hardmode : MonoBehaviour {
	int Scorefromscorecs = Score.score;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void LevelHARDMODELoad()
	{
		Application.LoadLevel("HARDMODE");
		Score.score = 0;

	}

}
