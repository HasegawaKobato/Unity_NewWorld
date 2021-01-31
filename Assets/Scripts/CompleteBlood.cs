using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteBlood : MonoBehaviour {

	PlayerHealth hp;
	PlayerMPValue mp;

	float time = 0;

	// Use this for initialization
	void Start () {
		hp = GameObject.FindGameObjectWithTag("HP").GetComponent<PlayerHealth>();
		mp = GameObject.FindGameObjectWithTag("MP").GetComponent<PlayerMPValue>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerStay (Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			if (Time.time - time >= 0.2f) {
				time = Time.time;
				hp.Compelete();
				mp.Compelete();
			}
		}
	}
}
