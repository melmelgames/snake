using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseWindow : MonoBehaviour
{
    
    private static PauseWindow instance;
    
    public Button resumeBtn;
    public Button mainMenuBtn;
  
    private void Awake(){
        instance = this;
        HidePauseWindow();
    }

    private void Start() {
        resumeBtn.onClick.AddListener(ResumeBtnOnClick);
        mainMenuBtn.onClick.AddListener(MainMenuBtnOnClick);
    }

    private void MainMenuBtnOnClick(){
        GameHandler.ResumeGame();
        Loader.Load(Loader.Scene.MainMenu);
    }

    private void ResumeBtnOnClick(){
        HidePauseWindow();
        GameHandler.ResumeGame();
    }

    private void ShowPauseWindow(){
        gameObject.SetActive(true);
    }

    private void HidePauseWindow(){
        gameObject.SetActive(false);
    }

    public static void ShowPauseWindowStatic(){
        instance.ShowPauseWindow();
    }  

    public static void HidePauseWindowStatic(){
        instance.HidePauseWindow();
    }       

}
