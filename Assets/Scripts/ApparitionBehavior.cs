using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;


public class ApparitionBehavior : MonoBehaviour
{
	[SerializeField] private float speed;
	public Animator animator;
	public FirstPersonController player;
	// Use this for initialization
	void Start ()
	{
		animator.enabled = false;
	}
	
	public bool startWalk = false;
	// Update is called once per frame
	void Update ()
	{
		if (startWalk) {
			player.IsWalking(true);
			animator.enabled = true;
			//Increases object's x position to travel down hallway
			Vector3 pos = transform.position;
			pos.x = pos.x + speed;
			transform.position = pos;
       
			if (transform.position.x > -35) { //test to see if you can destory game object at certain position
				player.IsWalking(false);
				gameObject.SetActive(false);
			}
		}
	}
}
