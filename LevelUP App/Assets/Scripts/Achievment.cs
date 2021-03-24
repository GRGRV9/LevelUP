using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "Achievment", menuName = "New Achievment")]
    public class Achievment : ScriptableObject
    {
        public string title;

        public string description;

        public enum sphere {Work, Family, Sport};

        public string category;

        public int experience;

        public bool status;

    }

