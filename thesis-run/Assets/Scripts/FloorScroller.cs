using UnityEngine;
using System.Collections;

public class FloorScroller : MonoBehaviour {

	float speed = 0.35f;
	public Renderer rend;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (0, Time.time * speed);

		rend.material.mainTextureOffset = offset;
	}
}
