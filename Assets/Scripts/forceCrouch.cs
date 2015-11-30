using UnityEngine;
using System.Collections;

public class forceCrouch : MonoBehaviour {

	/*
	 * This script is used by various trigger boxes where the player must move through a tight area.
	 * By forcing the player into the crouch position, and not allowing them to stand up, it
	 * ensures the player does not clip through the geometry
	 */

	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController player;

	private bool value;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
//		player.forceCrouch = value;
	}

	void OnTriggerEnter (Collider other)
	{
		player.forceCrouch = true;
	}

	void OnTriggerStay (Collider other)
	{
		player.forceCrouch = true;
	}

	void OnTriggerExit (Collider other)
	{
		player.forceCrouch = Input.GetKey(KeyCode.C);
	}
}
