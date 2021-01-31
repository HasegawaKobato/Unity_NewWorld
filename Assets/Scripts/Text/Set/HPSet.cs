using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPSet : MonoBehaviour {
	
	public Player player;

	public string HPOutput;
	public float HpAdditionSet;
	public int HpAdditionCounting;

	Text hpSet;

	// Use this for initialization
	void Start () {
		hpSet = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		HpAdditionCounting = (int)((HpAdditionSet * 0.07 + 1) * (HpAdditionSet * 0.07 + 1) * player.defaultHP);

		HPOutput = HpAdditionCounting.ToString ();
		string nowHpAdditionSet = HpAdditionSet.ToString ();

		hpSet.text = nowHpAdditionSet;

	}
}
