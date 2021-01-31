using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KBSet : MonoBehaviour {

	public Player player;

	public string KBOutput;
	public float KbAdditionSet;

	Text kbSet;

	public int KbAdditionCounting;

	// Use this for initialization
	void Start () {
		kbSet = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		KbAdditionCounting = (int)(KbAdditionSet * KbAdditionSet / 3 + player.defaultKB);

		string nowKbAdditionSet = KbAdditionSet.ToString ();
		KBOutput = KbAdditionCounting.ToString ();

		kbSet.text = nowKbAdditionSet;
	}
}
