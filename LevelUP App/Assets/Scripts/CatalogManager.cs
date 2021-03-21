using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatalogManager : MonoBehaviour
{
    public Catalog catalog;
    Achievment achievment1;
    Achievment achievment2;

    public Text Goal1TextUI;
    public Text Goal2TextUI;

    private void Update()
    {
        achievment1 = catalog.GetAchievmentData(0);        
        Goal1TextUI.text = achievment1.title + " : " + achievment1.description;

        achievment2 = catalog.GetAchievmentData(1);
        Goal2TextUI.text = achievment2.title + " : " + achievment2.description;
    }

}




