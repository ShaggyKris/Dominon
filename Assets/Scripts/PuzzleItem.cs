using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PuzzleItem : MonoBehaviour {
	public GameObject key;

	public string solvedMessage;
	public string unsolvedMessage;
	public UnityStandardAssets.Characters.FirstPerson.FirstPersonController player;

	private InventoryManager items;

	void Start(){
		items = player.GetComponent<InventoryManager>();
	}

	public bool Solved()
	{
		return key.Equals (this.key.transform.name);
	}

	public bool hasItem(){
		return items.contains(this.key);
	}

	public string sendMessage(bool solved){
		if(solved)
			return solvedMessage;
		return unsolvedMessage;
	}

	public GameObject keyItem{
		get{return key;}
	}

	public string keyName{
		get{return key.transform.name;}
	}
}
