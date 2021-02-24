using Firebase.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Extensions;
using System;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Database;

public class Registration : MonoBehaviour
{
    protected Firebase.Auth.FirebaseAuth otherAuth;
    protected Firebase.Auth.FirebaseUser user;
    
    public InputField EmailField;
    public InputField PasswordField;
    public Button LoginButton;
    public Button SignUpButton;
    public string email;
    public string password;
    public string id;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //CreateUser void
    public void CreateUser() {
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        email = EmailField.text;
        password = PasswordField.text;

        //Create user
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled) {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted) {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            // Firebase user has been created.
            Firebase.Auth.FirebaseUser newUser = task.Result;
                Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);

            //Send email verification
            Firebase.Auth.FirebaseUser user = auth.CurrentUser;
            user.SendEmailVerificationAsync().ContinueWith(goal => {
                if (goal.IsCanceled) {
                Debug.LogError("SendEmailVerificationAsync was canceled.");
                return;
                }
                if (goal.IsFaulted) {
                Debug.LogError("SendEmailVerificationAsync encountered an error: " + goal.Exception);
                return;
                }

                Debug.Log("Email sent successfully.");
                //Здесь можно показать диалоговое окно с информацией о том, что ссылка для подтверждения отправлена на почту
            });
        });            
    }

    //Login
    public void Login() {
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        Firebase.Auth.FirebaseUser user = auth.CurrentUser;
        email = EmailField.text;
        password = PasswordField.text;

        //Sign in
        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            
            //Check Email Verification
            if (user.IsEmailVerified) {
                if (task.IsCanceled) {
                    Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                    return;
                }
                if (task.IsFaulted) {
                    Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                    return;
                }
                    Firebase.Auth.FirebaseUser newUser = task.Result;
                    Debug.LogFormat("User signed in successfully: {0} ({1})",
                        newUser.DisplayName, newUser.UserId);
                    id = newUser.UserId;
                    Debug.Log(id);
                    Debug.Log("All right");

                    //Create data for user
                    FirebaseDatabase database = FirebaseDatabase.DefaultInstance;
                    database.RootReference.Child("users").Child(id).Child("completedachievment1").SetValueAsync(" ");
                    database.RootReference.Child("users").Child(id).Child("completedachievment1").SetValueAsync(" ");
                    database.RootReference.Child("users").Child(id).Child("currentexp").SetValueAsync(0);
                    database.RootReference.Child("users").Child(id).Child("level").SetValueAsync(0);
                    database.RootReference.Child("users").Child(id).Child("location").SetValueAsync(" ");
                    database.RootReference.Child("users").Child(id).Child("mainachievement1").SetValueAsync(" ");
                    database.RootReference.Child("users").Child(id).Child("mainachievement2").SetValueAsync(" ");
                    database.RootReference.Child("users").Child(id).Child("name").SetValueAsync(" ");
                    database.RootReference.Child("users").Child(id).Child("plan1").SetValueAsync(" ");

                    //Переход на сцену SampleScene
                    SceneManager.LoadScene("SampleScene");
            } else {
                //Диалоговое окно с инфрмацией, что нужно подтвердить аккаунт. Или что-то вроде того
                Debug.Log("Nope");
            }
        });
    }          

    // Update is called once per frame
    void Update()
    {

    }
}