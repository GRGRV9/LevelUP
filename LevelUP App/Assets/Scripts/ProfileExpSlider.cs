using System;
using UnityEngine;
using UnityEngine.UI;

public class ProfileExpSlider : MonoBehaviour
{
    public Slider ExpSlider;
    public Text ExpText;
    string MaxValue;
    string CurrentValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MaxValue = Math.Round(ExpSlider.maxValue).ToString();
        CurrentValue = Math.Round(ExpSlider.value).ToString();
        ExpText.text = CurrentValue + " EXP / " + MaxValue + " EXP";
    }
}
