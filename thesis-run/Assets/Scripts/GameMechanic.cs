using UnityEngine;
using System.Collections;

public class GameMechanic : MonoBehaviour {

	public GameObject winPanel;
	private bool winCheck = false;

	public GameObject losePanel;
	private bool loseCheck = false;

	public GameObject gameMusic;

	// Use this for initialization
	void Start () {
		gameMusic.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GameLost (){
		if (!winCheck) {
			loseCheck = true;
			losePanel.SetActive (true);
		}
		gameMusic.SetActive (false);
	}

	public void GameWon (){
		if (!loseCheck) {
			winCheck = true;
			winPanel.SetActive (true);
		}
		gameMusic.SetActive (false);
	}

	public void IncreaseTime () {
		
	}

	public void DecreaseTime () {
		
	}
}
