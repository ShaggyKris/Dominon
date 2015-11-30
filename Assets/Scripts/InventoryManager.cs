using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[System.Serializable]
public class InventoryManager : MonoBehaviour{
	
//	public Dictionary<string,bool> items = new Dictionary<string,bool>();
	public List<string> items;

	public void AddItem(GameObject key){
		items.Add(key.transform.name);
//		Destroy (key); //more than likely needs to be called within the RayCast script
	}

	public void RemoveItem(string key){
		items.Remove (key);
	}

	public bool contains(GameObject key){
		return items.Contains (key.transform.name);
	}

	public int index(GameObject key){
		return items.IndexOf (key.transform.name);
	}
}
