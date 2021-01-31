using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AGISet : MonoBehaviour {

	public Player player;

	public string AVOOutput;
	public string DEFOutput;
	public string SpeedOutput;
	public float AgiAdditionSet;
	public double SpeedAdditionCounting;

	Text agiSet;

	public double AvoAdditionCounting;
	public int DefAdditionCounting;

	// Use this for initialization
	void Start () {
		agiSet = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		AvoAdditionCounting = (double)((int)(((AgiAdditionSet * 0.01 + 1) * (AgiAdditionSet * 0.1 + 1) + player.defaultAVO)*100))/100;
		DefAdditionCounting = (int)(AgiAdditionSet * AgiAdditionSet / 3 + player.defaultDEF);
		SpeedAdditionCounting = (((double)(int)(AgiAdditionSet/2 * 5) / 1000) + player.defaultSpeed);

		AVOOutput = AvoAdditionCounting.ToString ();
		DEFOutput = DefAdditionCounting.ToString ();
		SpeedOutput = SpeedAdditionCounting.ToString ();
		string nowAgiAdditionSet = AgiAdditionSet.ToString ();

		agiSet.text = nowAgiAdditionSet;
	}
}
