using UnityEngine;
using System.Collections;

public class ChangeTerrain : MonoBehaviour {

	public bool ClickFlag;
	// Update is called once per frame
	void Update () {
		if (ClickFlag == false) {
			if (Input.GetMouseButtonDown (0)) {
				if (renderer.material.GetColor ("_Color") == Color.red) {
					renderer.material.SetColor ("_Color", Color.blue);
				} else {
					renderer.material.SetColor ("_Color", Color.red);
				}
				GameObject.Find("Player").GetComponent<PlayerController>().changeColor(renderer.material.GetColor ("_Color"));
				ClickFlag = true;
			}
		} else {
			if (Input.GetMouseButtonUp (0)){
				ClickFlag = false;
			}
		}
	}
}
