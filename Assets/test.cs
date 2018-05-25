using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HutongGames.PlayMaker;

public class test : MonoBehaviour {
	
	public GameObject player;
	public PlayMakerFSM CombatNinja;
	public bool enable;

	//public static PlayMakerFSM FindFsmOnGameObject (GameObject go, string fsmName);


	void Start () {
		enable = true;
		//PlayMakerFSM.FindFsmOnGameObject
		//public static PlayMakerFSM FindFsmOnGameObject (GameObject go, string fsmName);
		//player.GetComponent<PlayMakerFSM>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Q) && enable) {
			TestDisable ();
			enable = false;
		} else if(Input.GetKeyDown(KeyCode.Q) && !enable ) {
			TestEnable ();
			enable = true;
		}
	}

	void TestDisable (){
		CombatNinja.GetComponent<PlayMakerFSM>().enabled = false;
		//player.GetComponent<CombatNinja>().enabled = false;
	}
	void TestEnable (){
		CombatNinja.GetComponent<PlayMakerFSM>().enabled = true;
		//player.GetComponent<CombatNinja>().enabled = false;
	}
}
