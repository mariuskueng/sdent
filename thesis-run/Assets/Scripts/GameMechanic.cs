using UnityEngine;
using System.Collections;

public class GameMechanic : MonoBehaviour {

	private float[] lanes = new float[3];

	// Use this for initialization
	void Start () {
		var lanePos = Screen.width / (lanes.Length + 1);
		for (var i = 0; i < lanes.Length; i++) {
			lanes [i] = lanePos * (i + 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GameLost (){
		
	}

	void GameWon (){
		
	}

	void IncreaseTime () {
	}

	void DecreaseTime () {
	}

	float[] GetLanes() {
		return lanes;
	}
}
