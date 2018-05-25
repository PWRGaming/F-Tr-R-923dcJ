using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punching : MonoBehaviour {

	private Animator anim;
	public bool punch;

	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	void PunchOff(){
		punch = false;
	
	}


	void Update () {
		anim.SetBool ("punch", punch);
		if (Input.GetButton("PunchTest")) {
			punch = true;

			//yield return new Wait
		}

		}
	}
//}