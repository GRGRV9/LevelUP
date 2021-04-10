using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Databases", menuName = "New Achievment List")]
public class GoalsList : ScriptableObject
{
    public List<Achievment> customList;
}
