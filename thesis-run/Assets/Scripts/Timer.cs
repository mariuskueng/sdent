﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour {

	double countdown = 60f; // seconds
	public Text timerLabel;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("decreaseTime", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (countdown == 0) {
			// end level
		}
		timerLabel.text = formatTime();
	}

	void decreaseTime() {
		this.countdown--;
	}

	void increaseTime() {
		this.countdown++;
	}

	string formatTime() {
		TimeSpan time = TimeSpan.FromSeconds (this.countdown);
		string text = string.Format ("{0:D2}:{1:D2}", time.Minutes, time.Seconds);
		return text;
	}
}
