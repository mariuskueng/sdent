using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemGenerator : MonoBehaviour {
	
	public List<GameObject> obstacles;
	public List<GameObject> powerups;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 1f, 1.5f);
		InvokeRepeating ("CreatePowerup", 2f, 3f);
	}

	// Update is called once per frame
	void Update () {

	}

	void CreateObstacle(){
		var obstacle = obstacles [Random.Range (0, obstacles.Count)];
		Instantiate(obstacle);
	}

	void CreatePowerup(){
		var powerup = powerups [Random.Range (0, powerups.Count)];
		Instantiate(powerup);
	}
}
