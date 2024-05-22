using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName="CreateItem")]
public class Item : ScriptableObject {

	public enum KindOfItem {
		KeyItem,
		UseItem
	}

	//　アイテムの種類
	[SerializeField]
	private KindOfItem kindOfItem;
	//　アイテムのアイコン
	[SerializeField]
	private Sprite icon;
	//　アイテムの名前
	[SerializeField]
	private string itemName;
	//鍵がもつ値
	[SerializeField]
	private int keyValue;

	public KindOfItem GetKindOfItem() {
		return kindOfItem;
	}

	public Sprite GetIcon() {
		return icon;
	}

	public string GetItemName() {
		return itemName;
	}

	public int GetKeyValue() {
		return keyValue;
	}
}