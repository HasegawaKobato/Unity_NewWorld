using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlotProgress : MonoBehaviour {

	Animator plotProgress;

	// Use this for initialization
	void Start () {
		plotProgress = GetComponent<Animator>();
		plotProgress.SetTrigger("PlotProgress");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.Escape)) {
			SceneManager.LoadScene("NewWorld", LoadSceneMode.Single);
		}

		if (Time.time >= 107f) {
			SceneManager.LoadScene("NewWorld", LoadSceneMode.Single);
		}
	}
}
