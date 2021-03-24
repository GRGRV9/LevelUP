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






