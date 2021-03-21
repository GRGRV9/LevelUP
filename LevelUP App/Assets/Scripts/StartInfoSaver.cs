using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartInfoSaver : MonoBehaviour
{
    public InputField NameField;
    public InputField CityField;
    public InputField EmailField;

    public void StartInfoToPrefs()
    {
        PlayerPrefs.SetString("name", NameField.text);
        PlayerPrefs.SetString("city", CityField.text);
        PlayerPrefs.SetString("email", EmailField.text);

        Debug.Log("Name: " + PlayerPrefs.GetString("name"));
        Debug.Log("City: " + PlayerPrefs.GetString("city"));
        Debug.Log("Email: " + PlayerPrefs.GetString("email"));

        SceneManager.LoadScene(1);
    }

}
