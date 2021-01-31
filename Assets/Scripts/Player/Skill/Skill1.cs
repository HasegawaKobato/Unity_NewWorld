using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill1 : MonoBehaviour {

	public PlayerLevelData level;

	Text skill;

	bool[] levelSetting = new bool[10];
	public bool skillUsing = false;
	public int costMP = 0;
	public int cd = 0;

	public float countdown;

	// Use this for initialization
	void Start () {
		skill = GetComponent<Text> ();
		for (int s = 0; s <= 9; s++) {
			levelSetting [s] = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (level.level == 1 && skillUsing == false) {
			skill.text = "2";
			cd = 2;
			costMP = 10;
			levelSetting [0] = true;
		}else if (level.level == 2 && skillUsing == false) {
			skill.text = "3";
			cd = 3;
			costMP = 15;
			levelSetting [1] = true;
		}else if (level.level == 3 && skillUsing == false) {
			skill.text = "5";
			cd = 5;
			costMP = 20;
			levelSetting [2] = true;
		}else if (level.level == 4 && skillUsing == false) {
			skill.text = "7";
			cd = 7;
			costMP = 25;
			levelSetting [3] = true;
		}else if (level.level == 5 && skillUsing == false) {
			skill.text = "10";
			cd = 10;
			costMP = 30;
			levelSetting [4] = true;
		}else if (level.level == 6 && skillUsing == false) {
			skill.text = "15";
			cd = 15;
			costMP = 40;
			levelSetting [5] = true;
		}else if (level.level == 7 && skillUsing == false) {
			skill.text = "20";
			cd = 20;
			costMP = 50;
			levelSetting [6] = true;
		}else if (level.level == 8 && skillUsing == false) {
			skill.text = "30";
			cd = 30;
			costMP = 60;
			levelSetting [7] = true;
		}else if (level.level == 9 && skillUsing == false) {
			skill.text = "45";
			cd = 45;
			costMP = 70;
			levelSetting [8] = true;
		}else if (level.level == 10 && skillUsing == false) {
			skill.text = "60";
			cd = 60;
			costMP = 80;
			levelSetting [9] = true;
		}


		/*if (level.level == 1 && levelSetting [0] && skillUsing) {
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 2 && levelSetting [1] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 3 && levelSetting [2] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 4 && levelSetting [3] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 5 && levelSetting [4] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 6 && levelSetting [5] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 7 && levelSetting [6] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 8 && levelSetting [7] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 9 && levelSetting [8] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}else if (level.level == 10 && levelSetting [9] && skillUsing){
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}*/

		if (skillUsing) {
			skill.text = (cd - (int)(Time.time - countdown)).ToString();
		}

		if ((cd - (int)(Time.time - countdown)) <= 0) {
			skillUsing = false;
		}

		
	}
}
