using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public GameObject mechanic;
	float speed = 4f;
	Vector3 target;
	private GameObject sound;

	float[] lanes = new float[3];
	private float lane;

	// Use this for initialization
	void Start () {
		float pos = 1f / 4f;
		for (var i = 0; i < lanes.Length; i++) {
			lanes [i] = pos * (i + 1);
		}
		lane = lanes [getLane ()];
		//		lane = lanes [1]; // for testing we positin the item in the center
		transform.position = Camera.main.ViewportToWorldPoint(new Vector3(lane, 1f, 10f));

		mechanic = GameObject.Find ("Mechanics");
		sound = GameObject.Find ("SoundObstacle");

		target = new Vector3 (transform.position.x, transform.position.y - 100, transform.position.z);
	}

	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target , step);
		// when item leaves screen
		if (transform.position.y < -6) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		// Obstacle collision with player!
		Destroy (gameObject);

		// update Timer here
		mechanic.GetComponent<GameMechanic>().DecreaseTime();

		// play sound
		sound.GetComponent<AudioSource>().Play ();
	}

	int getLane(){
		return Random.Range (0, lanes.Length);
	}
}
