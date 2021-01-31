using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public AudioClip cursor;
	public AudioClip decision;
	public AudioClip cancel;
	public GameObject menu;
	public GameObject plot;
	public GameObject select1;
	public GameObject select2;
	public GameObject select3;
	public GameObject select4;
	public GameObject select5;

	Animator startMenuTransitions;
	AudioSource audioSource;

	int i = 0;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
		startMenuTransitions = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		bool selectBool1 = select1.activeSelf;
		bool selectBool2 = select2.activeSelf;
		bool selectBool3 = select3.activeSelf;
		bool selectBool4 = select4.activeSelf;
		bool selectBool5 = select5.activeSelf;
		bool menuBool = menu.activeSelf;
		bool plotBool = plot.activeSelf;

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
		}else if (selectBool4 && plotBool) {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select5.SetActive(true);

				select4.SetActive(false);
			}else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select5.SetActive(true);

				select4.SetActive(false);
			}
		}else if (selectBool5 && plotBool) {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select4.SetActive(true);

				select5.SetActive(false);
			}else if (Input.GetKeyDown(KeyCode.DownArrow)) {
				audioSource.clip = cursor;
				audioSource.Play();
				select4.SetActive(true);

				select5.SetActive(false);
			}
		}

		if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)){
			if (selectBool1 && menuBool && i == 0) {
				i++;
				audioSource.clip = decision;
				audioSource.Play();
				startMenuTransitions.SetTrigger("StartMenu");
			}else if (selectBool2 && menuBool && i == 0) {
				audioSource.clip = cancel;
				audioSource.Play();
			}else if (selectBool3 && menuBool && i == 0) {
				Application.Quit();
			}else if (selectBool4 && plotBool && i == 1){
				i++;
				audioSource.clip = decision;
				audioSource.Play();
				startMenuTransitions.SetTrigger("IsPlot");
				SceneManager.LoadScene("Plot", LoadSceneMode.Single);
			}else if (selectBool5 && plotBool && i == 1) {
				i++;
				audioSource.clip = decision;
				audioSource.Play();
				startMenuTransitions.SetTrigger("IsPlot");
				SceneManager.LoadScene("NewWorld", LoadSceneMode.Single);
			}
		}
		if (Input.GetKeyDown(KeyCode.X)){
			audioSource.clip = cancel;
			audioSource.Play();
		}


	}
}
