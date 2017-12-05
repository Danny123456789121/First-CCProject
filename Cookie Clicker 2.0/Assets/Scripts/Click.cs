using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Click : MonoBehaviour
{
    public Text gpc;
    public Text goldDisplay;
    public float gold = 0.00f;
    public int goldperclick = 1;


    private void Update()
    {
        goldDisplay.text = "Gold : " + gold;
        gpc.text = goldperclick + " gold/click";
    }

    public void Clicked ()
    {
        gold += goldperclick;

    }

}
