using System;
using UnityEngine;
using UnityEngine.UI;

public class RoundSlidersController : MonoBehaviour
{
    public Text CircleFillAmount;
    public Image Slider;
    int IntPercents;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IntPercents = (int) Math.Round(Slider.fillAmount*100);
        CircleFillAmount.text = IntPercents.ToString();
        
    }
}
