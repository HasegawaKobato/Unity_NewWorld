using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


	public PlayerHealth respawn;

	public AudioClip cursor;
	public AudioClip decision;
	public AudioClip cancel;
	public GameObject select1;
	public GameObject select2;
	public GameObject select3;
	public GameObject menu;
	public GameObject abilityWindow;

	Animator gameover;
	AudioSource audioSource;
	AudioSource gameoverBGM;
	AudioSource mons;
	AudioSource town;
	AudioSource begin;
	Transform player;
	Transform respawnPoint;
	PlayerMPValue mp;
	GameObject die;

	int i = 0;
	int s = 0;
	float count = 0;
	bool cc =false;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		gameover = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>();
		respawnPoint = GameObject.FindGameObjectWithTag ("Respawn").GetComponent<Transform>();
		mp = GameObject.FindGameObjectWithTag ("MP").GetComponent<PlayerMPValue>();
		mons = GameObject.FindGameObjectWithTag("BGM_MonsterArea").GetComponent<AudioSource>();
		town = GameObject.FindGameObjectWithTag("BGM_Town").GetComponent<AudioSource>();
		begin = GameObject.FindGameObjectWithTag("BGM_Begining").GetComponent<AudioSource>();
		gameoverBGM = GameObject.FindGameObjectWithTag("GameOverBGM").GetComponent<AudioSource>();
		die = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {

		if (s == 1 && cc == false) {
			count = Time.time;
			s++;
			cc = true;
		}

		if (Time.time - count >= 2f && cc) {
			Time.timeScale = 0;
		}

		bool selectBool1 = select1.activeSelf;
		bool selectBool2 = select2.activeSelf;
		bool selectBool3 = select3.activeSelf;
		bool menuBool = menu.activeSelf;


		if (selectBool1 && menuBool) {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select3.SetActive(true);

				select2.SetActive(false);
				select1.SetActive(false);
			}else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select2.SetActive(true);

				select3.SetActive(false);
				select1.SetActive(false);
			}
		}else if (selectBool2 && menuBool) {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select1.SetActive(true);

				select3.SetActive(false);
				select2.SetActive(false);
			}else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select3.SetActive(true);

				select2.SetActive(false);
				select1.SetActive(false);
			}
		}else if (selectBool3 && menuBool) {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select2.SetActive(true);

				select3.SetActive(false);
				select1.SetActive(false);
			}else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select1.SetActive(true);

				select3.SetActive(false);
				select2.SetActive(false);
			}
		}


		if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)){
			//-----------------
			//死亡重生暫時刪除（重生點問題）
			//-----------------
			/*if (selectBool1 && menuBool && i == 0) {
				i++;
				audioSource.clip = decision;
				audioSource.Play();
				gameover.SetTrigger("Respawn");
				gameover.SetBool ("GameOver", false);
				respawn.Respawn ();
				mp.Respawn();
				player.transform.position = respawnPoint.transform.position;
			}else */if (selectBool3 && menuBool && i == 0) {
				Application.Quit();
			}else if (selectBool1 && menuBool && i == 0) {
				audioSource.clip = cancel;
				audioSource.Play();
			}else if (selectBool2 && menuBool && i == 0) {
				audioSource.clip = cancel;
				audioSource.Play();
			}
		}
	}



	public void Dead () {
		i = 0;
		if (s == 0) {
			gameover.SetBool ("GameOver", true);
			mons.Stop();
			town.Stop();
			begin.Stop();
			gameoverBGM.Play();
			s++;
			if (abilityWindow.activeSelf) {
				abilityWindow.SetActive(false);
			}
		}
	}
}
