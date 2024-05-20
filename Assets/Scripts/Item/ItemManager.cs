using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	//　アイテムデータベース
	[SerializeField]
	private ItemDataBase itemDataBase;
    [SerializeField] GameObject images;
    [SerializeField] Transform image;

    private Item item;

	//　アイテム数管理
	private Dictionary<Item, int> numOfItems = new Dictionary<Item, int>();

	// Use this for initialization
	void Start () {
		for (int i = 0; i < itemDataBase.GetItemLists().Count; i++) {
			//　アイテム数を0に設定
			numOfItems.Add (itemDataBase.GetItemLists() [i], 0);
		}
        images = GameObject.Find("KeyImage");
    }

    //　アイテムを手に入れる
        public void AddItem(Item item)
    {
        if (numOfItems.ContainsKey(item))
        {
            numOfItems[item]++;

            image = images.transform.Find(item.GetItemName()+"_image");
            image.gameObject.SetActive(true);

            Debug.Log("Added item: " + item.GetItemName());
        }
        else
        {
            Debug.LogWarning("Item not found: " + item.GetItemName());
        }
    }

    //　アイテムを使用し削除
    public void RemoveItem(Item item)
    {
        if (numOfItems.ContainsKey(item))
        {
            if (numOfItems[item] > 0)
            {
                numOfItems[item]--;
                Debug.Log("Removed item: " + item.GetItemName());
            }
            else
            {
                Debug.LogWarning("No more " + item.GetItemName() + " to remove.");
            }
        }
        else
        {
            Debug.LogWarning("Item not found: " + item.GetItemName());
        }
        image = images.transform.Find(item.GetItemName());
        image.gameObject.SetActive(false);
    }

    //　アイテムを持っているかどうか
    public bool HasItem(Item item)
    {
        if (numOfItems.ContainsKey(item))
        {
            return true;
        } else {
            return false;
        }
    }
}