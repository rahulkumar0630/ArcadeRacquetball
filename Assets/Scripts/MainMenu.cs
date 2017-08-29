using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public static int ScorefromScorecs = Score.score;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void LevelGameSceneLoad()
	{
		Application.LoadLevel("Game Scence");
		Score.score = 0;
	}

}
