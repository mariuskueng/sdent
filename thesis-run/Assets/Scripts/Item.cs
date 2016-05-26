using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public GameMechanic mechanics;
	public Vector2 velocity = new Vector2(0, -4);

	float[] lanes = new float[3];
	private float lane;

	// Use this for initialization
	void Start () {
		float pos = 1f / 4f;
		for (var i = 0; i < lanes.Length; i++) {
			lanes [i] = pos * (i + 1);
		}
//		lane = lanes [getLane ()];
		lane = lanes [1]; // for testing we positin the item in the center
		transform.position = Camera.main.ViewportToWorldPoint(new Vector3(lane, 1f, 10f));
		GetComponent<Rigidbody2D> ().velocity = velocity;
	}

	void OnCollisionEnter2D(Collision2D other) {
		Destroy (gameObject);

		// update progressBar here
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -12) {
			Destroy (gameObject);
		}
	}

	int getLane(){
		return Random.Range (0, lanes.Length);
	}
}
