using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScroller : MonoBehaviour
{
    //MainMenu
    public GameObject SearchPage;
    public GameObject ProfilePage;

    //SearchMenu
    public Image WorkSlider;
    public Image LifestyleSlider;
    public Image SportSlider;
    public Image StudySlider;
    public Image FamilySlider;
   
    public GameObject SportCategory;
    public GameObject StudyCategory;

    public GameObject BottomBlock;

    //SportCategory

    public GameObject MartialArtsAchievments;
    public GameObject AthleticsAchievments;

    public GameObject MarathonAchievment;


    void Start()
    {
        ProfilePage.SetActive(true);
        SearchPage.SetActive(false);
        MarathonAchievment.SetActive(false);
    }


    //Main Menu functions
    public void ProfilePageActivate()
    {
        ProfilePage.SetActive(true);
        SearchPage.SetActive(false);
        MarathonAchievment.SetActive(false);
    }

    public void SearchPageActivate()
    {
        ProfilePage.SetActive(false);
        SearchPage.SetActive(true);
        MarathonAchievment.SetActive(false);
    }






    //Search Page functions - Category picking
    public void WorkCategoryActivasion()
    {
        SportCategory.SetActive(false);
        StudyCategory.SetActive(false);

        SportSlider.fillAmount = 0;
        WorkSlider.fillAmount = 1;
        LifestyleSlider.fillAmount = 0;
        StudySlider.fillAmount = 0;
        FamilySlider.fillAmount = 0;

        BottomBlock.SetActive(false);        
    }
    public void LifestyleCategoryActivasion()
    {
        SportCategory.SetActive(false);
        StudyCategory.SetActive(false);

        SportSlider.fillAmount = 0;
        WorkSlider.fillAmount = 0;
        LifestyleSlider.fillAmount = 1;
        StudySlider.fillAmount = 0;
        FamilySlider.fillAmount = 0;

        BottomBlock.SetActive(false);
    }
    public void SportCategoryActivasion()
    {
        SportCategory.SetActive(true);
        StudyCategory.SetActive(false);

        SportSlider.fillAmount = 1;
        WorkSlider.fillAmount = 0;
        LifestyleSlider.fillAmount = 0;
        StudySlider.fillAmount = 0;
        FamilySlider.fillAmount = 0;

        BottomBlock.SetActive(false);
    }

    public void StudyCategoryActivasion()
    {
        SportCategory.SetActive(false);
        StudyCategory.SetActive(true);

        SportSlider.fillAmount = 0;
        WorkSlider.fillAmount = 0;
        LifestyleSlider.fillAmount = 0;
        StudySlider.fillAmount = 1; 
        FamilySlider.fillAmount = 0;

        BottomBlock.SetActive(false);
    }

    public void FamilyCategoryActivasion()
    {
        SportCategory.SetActive(false);
        StudyCategory.SetActive(false);

        SportSlider.fillAmount = 0;
        WorkSlider.fillAmount = 0;
        LifestyleSlider.fillAmount = 0;
        StudySlider.fillAmount = 0;
        FamilySlider.fillAmount = 1;

        BottomBlock.SetActive(false);
    }






    //Search Page functions - subcategory picking

    //Sport subcategories
    public void MartialSubcategoryActivate()
    {
        BottomBlock.SetActive(true);

        MartialArtsAchievments.SetActive(true);
        AthleticsAchievments.SetActive(false);
    }

    public void AthleticsSubcategoryActivate()
    {
        BottomBlock.SetActive(true);

        MartialArtsAchievments.SetActive(false);
        AthleticsAchievments.SetActive(true);
    }


    //Achievment Pages

    public void ViewMarathon42km()
    {
        ProfilePage.SetActive(false);
        SearchPage.SetActive(false);
        MarathonAchievment.SetActive(true);
    }

    public void BackToProfile()
    {
        ProfilePage.SetActive(true);
        SearchPage.SetActive(false);
        MarathonAchievment.SetActive(false);
    }






    // Update is called once per frame
    void Update()
    {
        
    }
}
