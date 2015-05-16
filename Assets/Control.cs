using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	private Animator sintelAnim;

	// Use this for initialization
	void Start () {
		sintelAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		sintelAnim.SetFloat("VSpeed", Input.GetAxis("Vertical"));
		sintelAnim.SetFloat("HSpeed", Input.GetAxis("Horizontal"));
		if (Input.GetButtonDown("Jump")){
			sintelAnim.SetBool("Jumping", true);
			Invoke("StopJumping", 1.0f);
		}
	}

	void StopJumping(){
		sintelAnim.SetBool("Jumping", false);
	}
}
