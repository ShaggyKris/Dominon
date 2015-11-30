using UnityEngine;
using System.Collections;

public class EnableWalk : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}

	void OnTriggerEnter (Collider other)
	{
		FindObjectOfType<ApparitionBehavior> ().startWalk = true;

		GetComponent<BoxCollider>().enabled = false;
	}

	// Update is called once per frame
	void Update ()
	{
	
	}
}
