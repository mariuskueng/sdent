using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	const int SIZE = 3;

	public GameObject player;
	Vector2 touchOrigin = -Vector2.one;

	float[] lanes = new float[SIZE];
	int position = SIZE/2;

	// Use this for initialization
	void Start () {
		float pos = 1f / 4f;
		for (var i = 0; i < lanes.Length; i++) {
			lanes [i] = pos * (i + 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		int horizontal = 0;

		if (Input.touchCount > 0)
		{
			//Store the first touch detected.
			Touch myTouch = Input.touches[0];

			//Check if the phase of that touch equals Began
			if (myTouch.phase == TouchPhase.Began)
			{
				//If so, set touchOrigin to the position of that touch
				touchOrigin = myTouch.position;
			}

			//If the touch phase is not Began, and instead is equal to Ended and the x of touchOrigin is greater or equal to zero:
			else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
			{
				//Set touchEnd to equal the position of this touch
				Vector2 touchEnd = myTouch.position;

				//Calculate the difference between the beginning and end of the touch on the x axis.
				float x = touchEnd.x - touchOrigin.x;

				//Set touchOrigin.x to -1 so that our else if statement will evaluate false and not repeat immediately.
				touchOrigin.x = -1;
					//If x is greater than zero, set horizontal to 1, otherwise set it to -1
				horizontal = x > 0 ? 1 : -1;

			}
		}

		if ((position + horizontal) >= 0 && (position + horizontal) < lanes.Length) {
			position += horizontal;
			transform.position = Camera.main.ViewportToWorldPoint(new Vector3(lanes[position], 0f, 10f));
		}
	}
}
