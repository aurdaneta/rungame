using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	public Animator sintelAnim;

	// Use this for initialization
	void Start () {
		sintelAnim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		sintelAnim.SetFloat("VSpeed", Input.GetAxis("Vertical"));

		if (Input.GetButtonDown("Jump")){
			sintelAnim.SetBool("Jumping", true);
			Invoke("StopJumping", 1.0f);
		}

		/*
		if (Input.GetKey (KeyCode.Space)) {
			sintelAnim.CrossFade("Saltar", 0.5f);
			//sintelAnim.Play("Saltar");
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			sintelAnim.CrossFade("Izquierda", 0.5f);
			posX = transform.position.x;
			posX -= 0.2f;
			transform.position = new Vector3(posX, transform.position.y, transform.position.z);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			sintelAnim.CrossFade("Derecha", 0.5f);
			posX = transform.position.x;
			posX += 0.2f;
			transform.position = new Vector3(posX, transform.position.y, transform.position.z);
		}
		*/
	}

	void StopJumping(){
		sintelAnim.SetBool("Jumping", false);
	}
}
