using UnityEngine;
using Firebase.Database;
using UnityEngine.UI;
using System;

public class GetPostManager : MonoBehaviour
{
    string id;

    string locationFromDatabase;
    string UsernameFromDatabase;
    string LikesCountFromDatabase;
    string LevelFromDatabase;
    string ExpFromDatabase;

    public Text Name;
    public Text Location;
    public Text LikesCount;
    public Text Level;

    public Text Exp;
    public Slider ExpSlider;
    string MaxExpValue;    

    //string locationPostToDatabase;


    void Awake()
    {
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        Firebase.Auth.FirebaseUser user = auth.CurrentUser;
        FirebaseDatabase database = FirebaseDatabase.DefaultInstance;

        id = user.UserId;        

        //Get name from database
        database.GetReference("users").Child(id).Child("username")
        .GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
            {
                // Handle the error...
            }
            else if (task.IsCompleted)
            {
                //Получили snapshot
                DataSnapshot snapshot = task.Result;

                //Достали value и перевели в строку
                UsernameFromDatabase = snapshot.GetValue(true).ToString();
                Debug.Log(UsernameFromDatabase);
                Name.text = UsernameFromDatabase;


            }
        });

        //Get location from database
        database.GetReference("users").Child(id).Child("location")
        .GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
            {
                // Handle the error...
            }
            else if (task.IsCompleted)
            {
                //Получили snapshot
                DataSnapshot snapshot = task.Result;

                //Достали value и перевели в строку
                locationFromDatabase = snapshot.GetValue(true).ToString();
                Debug.Log(locationFromDatabase);
                Location.text = locationFromDatabase;
            }
        });

        //Get likescount from database
        database.GetReference("users").Child(id).Child("likescount")
        .GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
            {
                // Handle the error...
            }
            else if (task.IsCompleted)
            {
                //Получили snapshot
                DataSnapshot snapshot = task.Result;

                //Достали value и перевели в строку
                LikesCountFromDatabase = snapshot.GetValue(true).ToString();
                Debug.Log(LikesCountFromDatabase);
                LikesCount.text = LikesCountFromDatabase;
            }
        });

        //Get level from database
        database.GetReference("users").Child(id).Child("level")
        .GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
            {
                // Handle the error...
            }
            else if (task.IsCompleted)
            {
                //Получили snapshot
                DataSnapshot snapshot = task.Result;

                //Достали value и перевели в строку
                LevelFromDatabase = snapshot.GetValue(true).ToString();
                Debug.Log(LevelFromDatabase);
                Level.text = LevelFromDatabase + " LEVEL";
            }
        });

        //Get exp from database
        database.GetReference("users").Child(id).Child("currentexp")
        .GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
            {
                // Handle the error...
            }
            else if (task.IsCompleted)
            {
                //Получили snapshot
                DataSnapshot snapshot = task.Result;

                //Достали value и перевели в строку
                ExpFromDatabase = snapshot.GetValue(true).ToString();
                Debug.Log(ExpFromDatabase);

                MaxExpValue = Math.Round(ExpSlider.maxValue).ToString();
                ExpSlider.value = int.Parse(ExpFromDatabase);
                Exp.text = ExpFromDatabase + " EXP / " + MaxExpValue + " EXP";
            }
        });

    }



    //LocationSetValue void

    //public void LocationSetValue()
    //{
    //    Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
    //    Firebase.Auth.FirebaseUser user = auth.CurrentUser;
    //    FirebaseDatabase database = FirebaseDatabase.DefaultInstance;

    //    id = user.UserId;

    //    //Получение значения из LocationField
    //    //location = LocationField.text;
    //    Debug.Log(locationPostToDatabase);
    //    database.RootReference.Child("users").Child(id).Child("location").SetValueAsync(locationPostToDatabase);
    //}
}
