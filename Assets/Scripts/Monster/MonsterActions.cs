using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterActions : MonoBehaviour {
	
	public MonsterAbility monster;
	public EnemyBirth birth;
	PlayerHealth getHit;
	PlayerExperience playerEXP;

	public float followDistance = 8f;
	public float attackDistance = 1f;
	public float fightingTime = 1f;
	GameObject player;
	public bool attack;

	Animator anim;
	Animator playerAnim;
	NavMeshAgent nav;
	AudioSource audioPlay;
	Tool1 tool1;
	Tool2 tool2;
	Tool3 tool3;


	Vector3 playerPosition,selfPosition,backPosition;
	Quaternion selfRotation,backRotation;
	float time;
	float damageTime;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag("Player");
		getHit = GameObject.FindGameObjectWithTag ("HP").GetComponent<PlayerHealth> ();
		playerAnim = player.GetComponent<Animator> ();
		nav = GetComponent<NavMeshAgent> ();
		audioPlay = GetComponent<AudioSource>();
		playerEXP = GameObject.FindGameObjectWithTag("EXP").GetComponent<PlayerExperience>();
		tool1 = GameObject.FindGameObjectWithTag("Tools1").GetComponent<Tool1>();
		tool2 = GameObject.FindGameObjectWithTag("Tools2").GetComponent<Tool2>();
		tool3 = GameObject.FindGameObjectWithTag("Tools3").GetComponent<Tool3>();
	}
	
	// Update is called once per frame
	void Update () {

		playerPosition = player.transform.position;
		//------------------------
		//設定擊退後的位置
		//------------------------
		selfPosition = transform.position;
		backPosition = selfPosition + (backRotation * Vector3.forward) * 1f;
		selfRotation = transform.rotation;
		backRotation = selfRotation * Quaternion.AngleAxis (180f, Vector3.up);

		//------------------------
		//怪物永遠面向角色
		//------------------------

		transform.LookAt (playerPosition);

		//------------------------
		//怪物與角色距離上的動作判斷
		//------------------------

		if (Vector3.Distance (playerPosition, selfPosition) <= followDistance && Vector3.Distance (playerPosition, selfPosition) > attackDistance) {
			nav.SetDestination (playerPosition);
			anim.SetBool ("Walk", true);
		} else {
			nav.SetDestination (selfPosition);
			anim.SetBool ("Walk", false);
		}
		if (Vector3.Distance (playerPosition, selfPosition) <= attackDistance && gameObject.activeInHierarchy) {
			anim.SetBool ("Atk", true);
			attack = true;

			if (Time.time - time >= fightingTime && attack && gameObject.activeInHierarchy) {
				time = Time.time;
				if (gameObject.CompareTag("Cactus")) {
					getHit.CactusGetHit ();
				} else if (gameObject.CompareTag("Blue")) {
					getHit.BlueGetHit ();
				} else if (gameObject.CompareTag("Gold")) {
					getHit.GoldGetHit ();
				} else if (gameObject.CompareTag("Green")) {
					getHit.GreenGetHit ();
				} else if (gameObject.CompareTag("Red")) {
					getHit.RedGetHit ();
				} else if (gameObject.CompareTag("BOSS")) {
					getHit.BOSSGetHit ();
				} else if (gameObject.CompareTag("Rhino")) {
					getHit.RhinoGetHit ();
				}
			}
		} else {
			anim.SetBool ("Atk", false);
			attack = false;
		}

		//------------------------
		//怪物血量歸零時死亡
		//------------------------
		if (gameObject.CompareTag("Cactus")) {
			if (monster.monsterHP <= 0 && attack) {
				Destroy(gameObject,0.01f);
				attack = false;
				playerEXP.CactusDead ();
				tool1.CactusIncrease ();
				tool2.CactusIncrease ();
				tool3.CactusIncrease ();
				monster.monsterHP = 125;
				return;
			}
		} else if (gameObject.CompareTag("Blue")) {
			if (monster.monsterHP <= 0 && attack) {
				Destroy(gameObject,0.01f);
				attack = false;
				playerEXP.BlueDead ();
				tool1.BlueIncrease ();
				tool2.BlueIncrease ();
				tool3.BlueIncrease ();
				monster.monsterHP = 870;
				return;
			}
		} else if (gameObject.CompareTag("Gold")) {
			if (monster.monsterHP <= 0 && attack) {
				Destroy(gameObject,0.01f);
				attack = false;
				playerEXP.GoldDead ();
				tool1.GoldIncrease ();
				tool2.GoldIncrease ();
				tool3.GoldIncrease ();
				monster.monsterHP = 1860;
				return;
			}
		} else if (gameObject.CompareTag("Green")) {
			if (monster.monsterHP <= 0 && attack) {
				Destroy(gameObject,0.01f);
				attack = false;
				playerEXP.GreenDead ();
				tool1.GreenIncrease ();
				tool2.GreenIncrease ();
				tool3.GreenIncrease ();
				monster.monsterHP = 3445;
				return;
			}
		} else if (gameObject.CompareTag("Red")) {
			if (monster.monsterHP <= 0 && attack) {
				Destroy(gameObject,0.01f);
				attack = false;
				playerEXP.RedDead ();
				tool1.RedIncrease ();
				tool2.RedIncrease ();
				tool3.RedIncrease ();
				monster.monsterHP = 5775;
				return;
			}
		} else if (gameObject.CompareTag("BOSS")) {
			if (monster.monsterHP <= 0 && attack) {
				Destroy(gameObject,0.01f);
				attack = false;
				playerEXP.BOSSDead ();
				tool1.BOSSIncrease ();
				tool2.BOSSIncrease ();
				tool3.BOSSIncrease ();
				monster.monsterHP = 1;
				return;
			}
		} else if (gameObject.CompareTag("Rhino")) {
			if (monster.monsterHP <= 0 && attack) {
				Destroy(gameObject,0.01f);
				attack = false;
				playerEXP.RhinoDead ();
				tool1.RhinoIncrease ();
				tool2.RhinoIncrease ();
				tool3.RhinoIncrease ();
				monster.monsterHP = 12350;
				return;
			}
		}
		//------------------------


	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject == player) {
			nav.SetDestination (selfPosition);
			anim.SetTrigger ("Atk");
		}

		if (playerAnim.GetCurrentAnimatorStateInfo (0).IsName ("Hikick")) {
			if (Time.time - damageTime >= 0.4f) {
				damageTime = Time.time;
				if (monster.kb) {
					transform.localPosition = backPosition;
				}
				audioPlay.Play ();
				monster.GetHit ();
			}
		}

		if (playerAnim.GetCurrentAnimatorStateInfo (0).IsName ("Spinkick")) {
			if (Time.time - damageTime >= 0.5f) {
				damageTime = Time.time;
				if (monster.kb) {
					transform.localPosition = backPosition;
				}
				audioPlay.Play ();
				monster.GetHit ();
			}
		}
	}
}
