using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsToPage : MonoBehaviour
{
    public Text Name;
    public Text Location;
    public Text LikesCount;
    public Text Level;

    public Text Exp;
    public Slider ExpSlider;
    string MaxExpValue;
    int CurrentExpValue;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //name
        Name.text = PlayerPrefs.GetString("username");

        //location
        Location.text = PlayerPrefs.GetString("location");

        //likescount
        LikesCount.text = PlayerPrefs.GetInt("likescount").ToString();

        //level
        Level.text = PlayerPrefs.GetInt("level").ToString() + " LEVEL";

        //exp
        CurrentExpValue = PlayerPrefs.GetInt("exp");
        MaxExpValue = Math.Round(ExpSlider.maxValue).ToString();        
        Exp.text = CurrentExpValue + " EXP / " + MaxExpValue + " EXP";
    }
}
