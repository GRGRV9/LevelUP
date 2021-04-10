using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievmentPrefab : MonoBehaviour
{
    public Text prefabTitle;
    public int index;
    public int id;

    public void SetTitle(string newTitle) 
    {
        prefabTitle.text = newTitle;
    }
    public void SetIndex(int newIndex)
    {
        index = newIndex;
    }
    public void SetId(int newId)
    {
        id = newId;
    }
}
