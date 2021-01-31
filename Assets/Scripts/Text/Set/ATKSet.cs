using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ATKSet : MonoBehaviour {
	
	public Player player;
	public MonsterAbility[] monsAbility = new MonsterAbility[7];

	public string ATKOutput;
	public float AtkAdditionSet;

	Text atkSet;

	public int AtkAdditionCounting;

	// Use this for initialization
	void Start () {
		atkSet = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		AtkAdditionCounting = (int)(AtkAdditionSet * AtkAdditionSet / 2 + player.defaultATK);
		string nowAtkAdditionSet = AtkAdditionSet.ToString ();
		ATKOutput = AtkAdditionCounting.ToString ();

		for (int i = 0; i <= 6; i++) {
			monsAbility [i].damage = AtkAdditionCounting - monsAbility [i].monsterDEF;
			if (monsAbility [i].damage <= 0) {
				monsAbility [i].damage = 1;
			}
		}

		atkSet.text = nowAtkAdditionSet;
	}
}
