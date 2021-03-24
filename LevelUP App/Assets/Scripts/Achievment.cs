using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SphereType
{
    work,
    lifestyle,
    sport,
    education,
    family
}


[CreateAssetMenu(fileName = "Achievment", menuName = "New Achievment")]
    public class Achievment : ScriptableObject
    {
        public string title;

        public string description;

        public SphereType sphere;

        public string category;

        public int experience;

        public bool status;

    }

