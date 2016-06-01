using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameProgressBar : MonoBehaviour {

	public Image progressBar;
	public GameMechanic mechanic;
	float time = 0f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("increaseTime", 1.0f, 1.0f);
	}

	// Update is called once per frame
	void Update () {
		if (time == 60) {
			// win
			mechanic.GameWon();
		}
		progressBar.rectTransform.sizeDelta = new Vector2 (10 + (time * 4), 20f);
	}

	void increaseTime() {
		if (time < 60) {
			this.time++;
		}
	}
}
