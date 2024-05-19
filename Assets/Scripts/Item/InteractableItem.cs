using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
private ItemManager itemManager;

    private void Start()
    {
        itemManager = GetComponent<ItemManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Item detected");
            Item item = other.GetComponent<Item>();
            if (item != null)
            {
                // アイテムを取得する処理
                itemManager.AddItem(item);
                Destroy(other.gameObject);
            }
        }
    }
}
