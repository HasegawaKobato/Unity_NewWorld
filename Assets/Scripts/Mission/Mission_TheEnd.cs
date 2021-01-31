using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mission_TheEnd : MonoBehaviour {

	public AudioClip cursor;
	public AudioClip decision;
	public AudioClip cancel;
	public AudioClip ah;
	public GameObject menu;
	public GameObject select1;
	public GameObject select2;
	public GameObject select3;

	Player player;
	Animator anim;
	MissionProgress mis;
	AudioSource audio;
	AudioSource audioSource;

	float time = 0;
	bool anime = false;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		mis = GameObject.FindGameObjectWithTag("Mission").GetComponent<MissionProgress>();
		audio = GameObject.FindGameObjectWithTag("BossSet").GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		bool selectBool1 = select1.activeSelf;
		bool selectBool2 = select2.activeSelf;
		bool selectBool3 = select3.activeSelf;
		bool menuBool = menu.activeSelf;

		if (mis.mission == 22) {
			player.stop = true;
			anim.SetTrigger("End");
			anime = true;
			time = Time.time;
			mis.mission ++;
			audioSource.clip = ah;
			audioSource.Play();
		}

		if (anime == false) {
			audio.volume = 1f;
		}

		if (Time.time - time >= 65f && anime){
			audio.volume = 0.0f;
		}else if (Time.time - time >= 64f && anime) {
			audio.volume = 0.1f;
		}else if (Time.time - time >= 63f && anime) {
			audio.volume = 0.2f;
		}else if (Time.time - time >= 62f && anime) {
			audio.volume = 0.3f;
		}else if (Time.time - time >= 61f && anime) {
			audio.volume = 0.4f;
		}else if (Time.time - time >= 60f && anime) {
			audio.volume = 0.5f;
		}else if (Time.time - time >= 59f && anime) {
			audio.volume = 0.6f;
		}else if (Time.time - time >= 58f && anime) {
			audio.volume = 0.7f;
		}else if (Time.time - time >= 57f && anime) {
			audio.volume = 0.8f;
		}else if (Time.time - time >= 56f && anime) {
			audio.volume = 0.9f;
		}else if (Time.time - time >= 0f && anime) {
			audio.volume = 1f;
		}


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
			if (selectBool1 && menuBool) {
				audioSource.clip = cancel;
				audioSource.Play();
			}else if (selectBool2 && menuBool) {
				Application.Quit();
			}else if (selectBool3 && menuBool) {
				audioSource.clip = cancel;
				audioSource.Play();
			}
		}
		if (Input.GetKeyDown(KeyCode.X)){
			audioSource.clip = cancel;
			audioSource.Play();
		}

	}
}
