using UnityEngine;
using System.Collections;

public class BackgroundImages : MonoBehaviour {


	public Vector2 velocity = new Vector2(0, -4);
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = velocity; 
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -12) {
			Destroy (gameObject);
		}
	}
}
