using System;using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public enum ItemType
{
    None,
    Head,
    Legs,
    Shoes,
    Chest,
    Shield,
    Weapon
}

[CreateAssetMenu(menuName = "ScriptableObjects/ItemData", fileName = "NewItemData")]
public class ItemData : ScriptableObject
{
    [SerializeField] 
    private Sprite _sprite;
    
    [SerializeField] 
    private string _name;
    
    [SerializeField] 
    private ItemType _itemType;
    
    [TextArea]
    [SerializeField] 
    private string _description;
    
    [SerializeField] 
    private int _cost;

    [SerializeField] private bool _isEquipped;

    [SerializeField] private Vector2 _displayOffset;
    
    public bool IsEquipped { 
        get => _isEquipped;
        set => _isEquipped = value;
    }

    public Sprite ItemSprite => _sprite;
    public string ItemName => _name;
    public string ItemDescription => _description;
    public ItemType ItemType => _itemType;
    public int ItemCost => _cost;
    public Vector2 DisplayOffset => _displayOffset;
}
