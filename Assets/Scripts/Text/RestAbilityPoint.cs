using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestAbilityPoint : MonoBehaviour {

	public int restAbilityPoint;

	Text abilityPoint;

	// Use this for initialization
	void Start () {
		abilityPoint = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		string nowrestAbilityPoint = restAbilityPoint.ToString ();

		abilityPoint.text = nowrestAbilityPoint;
	}
}
