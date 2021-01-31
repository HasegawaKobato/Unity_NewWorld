using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tool2 : MonoBehaviour {

	public MonsterAbility[] monsAbility = new MonsterAbility[7];

	Text count;

	public int restCount = 0;

	// Use this for initialization
	void Start () {
		count = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		count.text = restCount.ToString ();
	}

	public void CactusIncrease () {
		int s = Random.Range (0, 100);
		if ((int)(monsAbility [0].flowers * 100) >= s) {
			restCount++;
		}
	}
	public void BlueIncrease () {
		int s = Random.Range (0, 100);
		if ((int)(monsAbility [1].flowers * 100) >= s) {
			restCount++;
		}
	}
	public void GoldIncrease () {
		int s = Random.Range (0, 100);
		if ((int)(monsAbility [2].flowers * 100) >= s) {
			restCount++;
		}
	}
	public void GreenIncrease () {
		int s = Random.Range (0, 100);
		if ((int)(monsAbility [3].flowers * 100) >= s) {
			restCount++;
		}
	}
	public void RedIncrease () {
		int s = Random.Range (0, 100);
		if ((int)(monsAbility [4].flowers * 100) >= s) {
			restCount++;
		}
	}
	public void BOSSIncrease () {
		int s = Random.Range (0, 100);
		if ((int)(monsAbility [5].flowers * 100) >= s) {
			restCount++;
		}
	}
	public void RhinoIncrease () {
		int s = Random.Range (0, 100);
		if ((int)(monsAbility [6].flowers * 100) >= s) {
			restCount++;
		}
	}
}
