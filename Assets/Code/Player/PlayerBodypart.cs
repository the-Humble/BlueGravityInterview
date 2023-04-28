using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerBodypart : MonoBehaviour
{
    [SerializeField] private ItemData _equippedItemData;
    public ItemData EquippedItemData => _equippedItemData;

    [SerializeField] private ItemType _itemType;
    private SpriteRenderer _itemDisplaySprite;
    
    public bool HasEquipped
    {
        get => _equippedItemData != null;
    }

    public void SetEquippedItemData(ItemData itemData)
    {
        if (itemData == null)
        {
            _equippedItemData.IsEquipped = false;
        }
        _equippedItemData = itemData;
        EnsureEquippedItem();
    }
    
    private void Awake()
    {
        EnsureEquippedItem();
    }

    private void OnValidate()
    {
        EnsureEquippedItem();
    }

    private void EnsureEquippedItem()
    {
        _itemDisplaySprite = GetComponent<SpriteRenderer>();

        if (_equippedItemData == null || _equippedItemData.ItemType != _itemType)
        {
            _itemDisplaySprite.sprite = null;
            return;
        }

        _itemDisplaySprite.sprite = _equippedItemData.ItemSprite;
    }
}
