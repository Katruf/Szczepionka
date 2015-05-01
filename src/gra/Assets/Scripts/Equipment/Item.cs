﻿using UnityEngine;
using System.Collections;


[System.Serializable]
public class Item  {
	public string itemName;
	public int itemID;
	public string itemDescription;
	public Texture2D itemIcon;

	public ItemType itemType;

	public enum ItemType {
		Weapon,
		VaccinePart,
		Ammo
	}

	public Item(string name, int ID, string description){

	}

}
