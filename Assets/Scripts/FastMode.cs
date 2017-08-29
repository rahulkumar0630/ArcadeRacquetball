using UnityEngine;
using System.Collections;

public class FastMode : MonoBehaviour {
	int Scorefromscorecs = Score.score;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void LevelFASTMODELoad()
	{
		Application.LoadLevel("FASTMODE");
		Score.score = 0;
	}

}
