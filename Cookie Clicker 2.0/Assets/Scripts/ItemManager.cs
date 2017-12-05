using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Text iteminfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;

    private float _baseCost;

    
    void Start()
    {
        _baseCost = cost;
    }

    void Update()
    {
        iteminfo.text = itemName + "\nCost: " + cost + "\nGold: " + tickValue + "/s";
    }

    public void PurchasedItem()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            cost = Mathf.Round(_baseCost * Mathf.Pow(1.15f, count));
        }       
    }












}
