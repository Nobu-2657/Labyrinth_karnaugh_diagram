using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    [SerializeField] Item item;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ItemManager itemManager = FindObjectOfType<ItemManager>(); // シーン内からItemManagerを探す
            if (itemManager != null)
            {
                // アイテムを取得する処理
                itemManager.AddItem(item);
                Destroy(gameObject); // アイテムを持っているゲームオブジェクトを破棄する
            }
            else
            {
                Debug.LogError("ItemManager not found in the scene.");
            }
        }
    }
}