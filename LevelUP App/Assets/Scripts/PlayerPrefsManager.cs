using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsManager : MonoBehaviour
{
    string PlayerName;
    string PlayerCity;
    string PlayerEmail;
    int PlayerExp;

    public Text NameTextUI;
    public Text LocationTextUI;
    public Slider ExpSliderUI;
    public Text ExpTextUI;
    public Text LevelTextUI;
    public Text LikesTextUI;


    // Start is called before the first frame update
    void Start()
    {
        PlayerName = PlayerPrefs.GetString("name");
        Debug.Log(PlayerName); 
        PlayerCity = PlayerPrefs.GetString("city");
        Debug.Log(PlayerCity);
        PlayerEmail = PlayerPrefs.GetString("email");
        Debug.Log(PlayerEmail);
        PlayerExp = PlayerPrefs.GetInt("exp");
        Debug.Log(PlayerExp);



        NameTextUI.text = PlayerName;
        LocationTextUI.text = PlayerCity;
    }

    // Update is called once per frame
    void Update()
    {
        ExpSliderUI.value = PlayerPrefs.GetInt("exp");
        ExpTextUI.text = PlayerPrefs.GetInt("exp").ToString() + " EXP/" + ExpSliderUI.maxValue + " EXP";
        LevelTextUI.text = (PlayerPrefs.GetInt("level") + 1).ToString() + " LEVEL";
        LikesTextUI.text = PlayerPrefs.GetInt("likes").ToString();


    }
}
