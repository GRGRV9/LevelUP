using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileManager : MonoBehaviour
{
    public Text LikesCounter;
    int LikesCount;

    // Start is called before the first frame update
    void Start()
    {
        LikesCount = PlayerPrefs.GetInt("likes");
    }

    // Update is called once per frame
    void Update()
    {
        
        LikesCounter.text = LikesCount.ToString();        
    }

    public void AddLike()
    {
        LikesCount += 1;
        PlayerPrefs.SetInt("likes", LikesCount);
    }
}
