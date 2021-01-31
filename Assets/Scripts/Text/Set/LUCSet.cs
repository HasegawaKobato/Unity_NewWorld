using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LUCSet : MonoBehaviour {

	public Player player;

	public string LUCOutput;
	public float LucAdditionSet;
	public int LucAdditionCounting;

	PlayerExperience exp;
	Text lucSet;



	// Use this for initialization
	void Start () {
		lucSet = GetComponent<Text> ();
		exp = GameObject.FindGameObjectWithTag ("EXP").GetComponent<PlayerExperience> ();
	}
	
	// Update is called once per frame
	void Update () {
		LucAdditionCounting = (int)(exp.currentEXP * (exp.maxEXP / ((LucAdditionSet * 0.05 +1) * 100)));
		string nowLucAdditionSet = LucAdditionSet.ToString ();

		lucSet.text = nowLucAdditionSet;
	}
}
