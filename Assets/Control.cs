using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	public Animator sintelAnim;
	private float posX;

	// Use this for initialization
	void Start () {
		sintelAnim = transform.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

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
	}
}
