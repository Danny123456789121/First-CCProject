using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Click : MonoBehaviour
{
    public Text goldDisplay;
    public int gold = 0;
    public int goldperclick = 1;


    private void Update()
    {
        goldDisplay.text = "Gold : " + gold;

    }

    public void Clicked ()
    {
        gold += goldperclick;

    }

}
