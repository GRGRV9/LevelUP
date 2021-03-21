using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catalog : MonoBehaviour
{
    public List<Achievment> CustomCatalog;

    Achievment achievment;

    public Achievment GetAchievmentData(int id)
    {
        achievment = CustomCatalog[id];
        return achievment;
    }
}

[CreateAssetMenu(fileName = "Achievment", menuName = "New Achievment")]
public class Achievment : ScriptableObject
{
    public string title;

    public string description;

    public int experience;

    public bool status;

}




