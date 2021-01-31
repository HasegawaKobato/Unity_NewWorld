using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelAttribute : MonoBehaviour {

	public PlayerLevelData playerData;

	Text levelAttribute;

	// Use this for initialization
	void Start () {
		levelAttribute = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		levelAttribute.text = playerData.level.ToString();
	}
}
