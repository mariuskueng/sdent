using UnityEngine;
using System.Collections;

public class BackgroundGenerator : MonoBehaviour {

	public GameObject pillar;
	public GameObject table;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreatePillar", 0f, 1f);
		InvokeRepeating ("CreateTable", 0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CreatePillar(){
		Instantiate(pillar);
	}

	void CreateTable(){
		Instantiate(table);
	}
}
