using UnityEngine;

using System.Collections;



public class RayCasting : MonoBehaviour {
	
	public float distanceToSee;
	
	RaycastHit whatIHit;
	
	
	private bool guiShow = false;
	
	
	void Start () {
		
	}
	
	
	// Update is called once per frame
	
	
	void Update () {
		Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.black);
		if (Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee))
		{
			Debug.Log("I touched " + whatIHit.collider.gameObject.name);
			guiShow = true;
		}
		else
		{
			guiShow = false;
		}
	}
	
	void OnGUI() {
		
		if(guiShow == true)
		{
			GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 100, 25), whatIHit.collider.gameObject.name);
		}
		
		
	}
	
}