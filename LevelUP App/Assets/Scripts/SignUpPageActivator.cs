using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignUpPageActivator : MonoBehaviour
{
    public GameObject SignUpPage;

    public void OpenSignUpPage()
    {
        SignUpPage.SetActive(true);
    }

    public void CloseSignUpPage()
    {
        SignUpPage.SetActive(false);
    }

}
