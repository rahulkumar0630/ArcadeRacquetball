using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
	 int Scorefromscorecs = Score.score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void LevelMainMenuLoad()
	{
		Application.LoadLevel("Main Menu");
		Score.score = 0;
	}
}
