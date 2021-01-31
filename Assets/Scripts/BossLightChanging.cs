using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLightChanging : MonoBehaviour {

	public int changeSpeed;

	Light color;
	// Use this for initialization

	float r = 0f;
	float g = 0f;
	float b = 0f;

	bool[] back = new bool[3];

	void Start () {
		color = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 changeLx = new Vector3 (- changeSpeed, 0, 0);
		Vector3 changeHz = new Vector3 (0, 0, changeSpeed);
		Vector3 changeHx = new Vector3 (changeSpeed, 0, 0);
		Vector3 changeLz = new Vector3 (0, 0, -changeSpeed);

		if (back [0]) {
			r -= 0.001f;
		} else {
			r += 0.01f;
		}

		if (back [1]) {
			g -= 0.01f;
		} else {
			g += 0.005f;
		}

		if (back [2]) {
			b -= 0.005f;
		} else {
			b += 0.001f;
		}

		if (r >= 1f) {
			back [0] = true;
		} else if (r <= 0f) {
			back [0] = false;
		}

		if (g >= 1f) {
			back [1] = true;
		} else if (g <= 0f) {
			back [1] = false;
		}

		if (b >= 1f) {
			back [2] = true;
		} else if (b <= 0f) {
			back [2] = false;
		}

		color.color = new Color (r, g, b);


		if (transform.position.z >= 10f) {
			transform.localPosition = transform.position + changeHx * Time.deltaTime;
		}

		if (transform.position.x <= -10f) {
			transform.localPosition = transform.position + changeHz * Time.deltaTime;
		}

		if (transform.position.z <= -10f) {
			transform.localPosition = transform.position + changeLx * Time.deltaTime;
		}

		if (transform.position.x >= 10f) {
			transform.localPosition = transform.position + changeLz * Time.deltaTime;
		}

	}
}
