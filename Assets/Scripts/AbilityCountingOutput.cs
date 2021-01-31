using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityCountingOutput : MonoBehaviour {
	
	public HPSet hp;
	public ATKSet atk;
	public AGISet agi;
	public LUCSet luc;
	public KBSet kb;
	public RestAbilityPoint restAPoint;

	public AudioClip up;

	public static string HPOutput,ATKOutput,AGIOutput,LUCOutput,KBOutput;

	AudioSource audio;

	void Start () {
		audio = GetComponent<AudioSource>();
	}

	void Update () {
		
	}

	public void HPAdd() {
		if (restAPoint.restAbilityPoint > 0) {
			hp.HpAdditionSet++;
			restAPoint.restAbilityPoint--;
			audio.clip = up;
			audio.Play();
		}
	}

	public void ATKAdd() {
		if (restAPoint.restAbilityPoint > 0) {
			atk.AtkAdditionSet++;
			restAPoint.restAbilityPoint--;
			audio.clip = up;
			audio.Play();
		}
	}

	public void AGIAdd() {
		if (restAPoint.restAbilityPoint > 0) {
			agi.AgiAdditionSet++;
			restAPoint.restAbilityPoint--;
			audio.clip = up;
			audio.Play();
		}
	}

	public void LUCAdd() {
		if (restAPoint.restAbilityPoint > 0) {
			luc.LucAdditionSet++;
			restAPoint.restAbilityPoint--;
			audio.clip = up;
			audio.Play();
		}
	}

	public void KBAdd() {
		if (restAPoint.restAbilityPoint > 0) {
			kb.KbAdditionSet++;
			restAPoint.restAbilityPoint--;
			audio.clip = up;
			audio.Play();
		}
	}


}
