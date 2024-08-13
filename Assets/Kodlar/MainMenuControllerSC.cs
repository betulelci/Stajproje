using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControllerSC : MonoBehaviour
{
    [SerializeField] GameObject MainmenuMenuObj;
    [SerializeField] GameObject SettingMenuObj;
    [SerializeField] Slider SliderMenuObj;
    
    void Start()
    {
        DisableMenus();
        MainmenuMenuObj.SetActive(true);
    }
    public void DisableMenus()
    {
        MainmenuMenuObj.SetActive(false);
        SettingMenuObj.SetActive(false);
    }
    public void OpenSettingMenu()
    {
        DisableMenus();
        SettingMenuObj.SetActive(true);
    }
    public void OpenMainMenuMenu()
    {
        DisableMenus();
        MainmenuMenuObj.SetActive(true);
    }
    public void OpenGameLevel()
    {
        SceneManager.LoadScene("Level");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
