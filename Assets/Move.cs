using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {


	private Animator myAnimator;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		myAnimator.SetFloat ("VSpeed", Input.GetAxis ("Vertical"));

		if (Input.GetButtonDown("Jump")){
			myAnimator.SetBool("Jumping", true);
			Invoke("StopJumping", 1.0f);
		}
	
	}

	void StopJumping(){
		myAnimator.SetBool("Jumping", false);
	}
}
