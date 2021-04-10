using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInstansiate : MonoBehaviour
{
    public Catalog catalog;
    public GameObject prefab;    
    List<Achievment> CustomCatalog;
    Vector2 startPosition = new Vector2(-35,100);
    Vector2 delta = new Vector2(0, -55);
   

    void Start()
    {
        CustomCatalog = catalog.GetCatalog();
        string objectName = gameObject.name;        

        foreach (var item in CustomCatalog)
        {            
            if (item.category == objectName)
            {                
                GameObject newPrefab = Instantiate(prefab, startPosition, transform.rotation) as GameObject;
                newPrefab.name = item.title;
                AchievmentPrefab achievmentPrefab = newPrefab.GetComponent<AchievmentPrefab>();
                newPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("martial").transform, false);
                //achievmentPrefab.SetExp(item.experience.ToString());
                achievmentPrefab.SetTitle(item.title);
                startPosition += delta;
            }
        }
    }
    
}
