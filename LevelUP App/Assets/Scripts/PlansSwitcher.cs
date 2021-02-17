using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlansSwitcher : MonoBehaviour
{
    public GameObject PlansWindow;
    public GameObject CompletedPlansWindow;
    public Animator SwitcherAnimator;

    void Start()
    {
        SwitcherAnimator = GetComponent<Animator>();
    }

    public void OpenPlans()
    {
        PlansWindow.SetActive(true);
        CompletedPlansWindow.SetActive(false);
        SwitcherAnimator.SetBool("CompletedPlansPicked", false);

    }
    public void OpenCompleted()
    {
        PlansWindow.SetActive(false);
        CompletedPlansWindow.SetActive(true);
        SwitcherAnimator.SetBool("CompletedPlansPicked", true);
    }
}
