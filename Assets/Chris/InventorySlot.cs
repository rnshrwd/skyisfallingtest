﻿/*using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
	public Image icon;
	public Button removeButton;

	item item;

	public void AddItem (Item newItem)
	{
		item = newItem;

		icon.sprit = item.icon;
		icon.enabled = true;
		removeButton.interactable = true;
	}

	public void ClearSlot ()
	{
		item = null;

		icon.sprite = null;
		icon.enabled = false;
		removeButton.interactable = false;
	}

	public void OnRemoveButton ()
	{
		Inventory.instance.Remove(item);
	}

	public void UseItem ()
	{
		if (item != null)
		{
			item.Use();
		}
	}
}
*/