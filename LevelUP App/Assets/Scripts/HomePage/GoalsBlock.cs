using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalsBlock : MonoBehaviour
{
    //Main catalog
    public Catalog catalogObject;    
    List<Achievment> mainCatalog;
    Achievment achievment;

    //Custom list of achievments
    public GoalsList goalsListObject;
    public GameObject prefab;
    List<Achievment> goalsList;

    Vector2 startPosition = new Vector2(-10, -35);
    Vector2 delta = new Vector2(0, -55);
    

    void Start()
    {
        mainCatalog = catalogObject.GetCatalog();
        goalsList = goalsListObject.customList;
        CreateGoals();
    }

    private void Update()
    {
        
    }

    public void CreateGoals()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        
        for (int i = 0; i < goalsList.Count; i++)
        {
            GameObject newPrefab = Instantiate(prefab, startPosition, transform.rotation);
            newPrefab.name = goalsList[i].title;
            AchievmentPrefab achievmentPrefab = newPrefab.GetComponent<AchievmentPrefab>();
            newPrefab.transform.SetParent(gameObject.transform, false);
            achievmentPrefab.SetTitle(goalsList[i].title);
            achievmentPrefab.SetIndex(i);
            achievmentPrefab.SetId((goalsList[i].id));
            startPosition += delta;
        }
        startPosition = new Vector2(-10, -35);
    }

    public void AddGoal(int id) 
    {        
        achievment = catalogObject.GetAchievment(id);
        goalsList.Add(achievment);
        goalsList.RemoveAt(0);
    }

    public void AddGoalButton()
    {
        int id = GetComponent<AchievmentPrefab>().id;
        AddGoal(id);
        CreateGoals();
    }

    public void TestButton2()
    {
        CreateGoals();
    }
}
