using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

	public GameMechanic mechanics;
	public Vector2 velocity = new Vector2(0, -4);

	float[] lanes = new float[3];
	private float lane;

	// Use this for initialization
	void Start () {
		var lanePos = Screen.width / (lanes.Length + 1);
		for (var i = 0; i < lanes.Length; i++) {
			lanes [i] = lanePos * (i + 1);
			Debug.Log (lanes [i]);
		}
		lane = lanes [getLane ()];
		transform.position = new Vector2 (lane, 10f);
		GetComponent<Rigidbody2D> ().velocity = velocity;
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
