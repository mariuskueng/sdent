using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

	double countdown = 60f; // seconds
	public Text timerLabel;
	public GameMechanic mechanic;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("decreaseTime", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (countdown <= 0) {
			// end level
			mechanic.GameLost();
		}
		timerLabel.text = formatTime();
	}

	void decreaseTime() {
		if (this.countdown > 0) {
			this.countdown--;
		}
	}

	void increaseTime() {
		this.countdown++;
	}

	public void UpdateTime(double seconds) {
		this.countdown += seconds;
		if (this.countdown < 0 || mechanic.HasGameEnded()) {
			this.countdown = 0;
		}
	}

	string formatTime() {
		TimeSpan time = TimeSpan.FromSeconds (this.countdown);
		string text = string.Format ("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
		return text;
	}
}
