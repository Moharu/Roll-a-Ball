using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rigidbody.AddForce (movement*speed*Time.deltaTime); 
	}

	public void changeColor(Color color) {
		if (color == Color.red) {
			renderer.material.SetColor ("_Color", Color.blue);
		} else if (color == Color.blue) {
			renderer.material.SetColor ("_Color", Color.red);
		}
	}
}
