using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievmentPrefab : MonoBehaviour
{
    public Text prefabTitle;
    public Text prefabExp;

    public void SetTitle(string title) 
    {
        prefabTitle.text = title;
    }

    public void SetExp(string exp)
    {
        prefabExp.text = exp + " EXP";
    }
}
