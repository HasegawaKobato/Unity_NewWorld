using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevelData : MonoBehaviour {

	public Player player;
	public RestAbilityPoint restAPoint;
	public Slider hpSlider;
	public Slider mpSlider;
	public Slider expSlider;
	public AudioClip levelUp;

	public GameObject abilityWindow;

	public int level,maxHPOutput,maxMPOutput,maxEXPOutput,ATKOutput,DEFOutput;

	AudioSource audio;

	bool complement = false;
	float delayTime;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (expSlider.value >= expSlider.maxValue && complement == false) {
			if (level < 10) {
				expSlider.value -= expSlider.maxValue;
				audio.clip = levelUp;
				audio.Play();
				level++;
				restAPoint.restAbilityPoint += 3;
				player.defaultHP *= 1.25f;
				player.defaultMP *= 1.25f;
				player.defaultEXP *= 2f;
				player.defaultATK *= 1.35f;
				player.defaultDEF *= 1.3f;
				maxHPOutput = (int)player.defaultHP;
				maxMPOutput = (int)player.defaultMP;
				maxEXPOutput = (int)player.defaultEXP;
				ATKOutput = (int)player.defaultATK;
				DEFOutput = (int)player.defaultDEF;
				abilityWindow.SetActive (true);
				complement = true;
				delayTime = Time.time;
			} else if (level == 10) {
				expSlider.value = expSlider.maxValue;
			}
		}

		if (level == 10) {
			expSlider.value = expSlider.maxValue;
		}

		if (complement && Time.time - delayTime >= 0.25f) {
			abilityWindow.SetActive (false);			
			hpSlider.value = hpSlider.maxValue;
			mpSlider.value = mpSlider.maxValue;
			complement = false;
		}

	}
}
