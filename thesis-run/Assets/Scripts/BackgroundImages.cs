using UnityEngine;
using System.Collections;

public class BackgroundImages : MonoBehaviour {


	public Vector2 velocity = new Vector2(0, -4);
	public Vector3 target;
	public float speed = 4f;
	// Use this for initialization
	void Start () {
		//GetComponent<Rigidbody2D> ().velocity = velocity;
		target = new Vector3 (transform.position.x, transform.position.y - 100, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target , step);
		if (transform.position.y < -12) {
			Destroy (gameObject);
		}
	}
}
