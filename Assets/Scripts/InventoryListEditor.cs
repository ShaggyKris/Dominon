using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class InventoryListEditor : MonoBehaviour {
	
	public Dictionary<string,bool> items = new Dictionary<string,bool>();
	

	
//	void AddNew(){
//		items.Add (new KeyItem());
//	}
	
	void Remove(string item){
		items.Remove(item);
	}
	//	// Use this for initialization
	//	void Start () {
	//
	//	}
	//	
	//	// Update is called once per frame
	//	void Update () {
	//	
	//	}
}
