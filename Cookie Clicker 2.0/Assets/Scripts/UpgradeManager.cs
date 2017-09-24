using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;

    private float _newCost;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: +" + clickPower;
	}

    public void PurchasedUpgrade ()
    {
        if(click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            click.goldperclick += clickPower;
            cost = Mathf.Round (cost * 1.15f);
            _newCost = Mathf.Pow(cost, _newCost = cost);
        }
    }
}
