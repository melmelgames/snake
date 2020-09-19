using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuWindow : MonoBehaviour
{

    public Button playBtn;
    public Button howToBtn;
    public Button quitBtn;
    public GameObject howToPlayWindow;
    public Button closeHowToPlayWindowBtn;
    public GameObject difficultyWindow;
    public Button closeDifficultyWindowBtn;
    public Button level1Btn;
    public Button level2Btn;
    public Button level3Btn;
    public Button level4Btn;
    public Button level5Btn;
    public Button level6Btn;
    public Button level7Btn;
    public Button level8Btn;
    public Button level9Btn;
    public Button level10Btn;
    

    private void Awake(){
        howToPlayWindow.SetActive(false);
        difficultyWindow.SetActive(false);
    }

    private void Start() {
        playBtn.onClick.AddListener(PlayBtnOnClick);
        howToBtn.onClick.AddListener(HowToBtnOnClick);
        quitBtn.onClick.AddListener(QuitBtnOnClick);
        closeHowToPlayWindowBtn.onClick.AddListener(CloseHowToPlayWindowBtnOnClick);
        closeDifficultyWindowBtn.onClick.AddListener(CloseDifficultyWindowBtnOnClick);
        level1Btn.onClick.AddListener(Level1BtnOnClick);
        level2Btn.onClick.AddListener(Level2BtnOnClick);
        level3Btn.onClick.AddListener(Level3BtnOnClick);
        level4Btn.onClick.AddListener(Level4BtnOnClick);
        level5Btn.onClick.AddListener(Level5BtnOnClick);
        level6Btn.onClick.AddListener(Level6BtnOnClick);
        level7Btn.onClick.AddListener(Level7BtnOnClick);
        level8Btn.onClick.AddListener(Level8BtnOnClick);
        level9Btn.onClick.AddListener(Level9BtnOnClick);
        level10Btn.onClick.AddListener(Level10BtnOnClick);
    }

    private void PlayBtnOnClick(){
        difficultyWindow.SetActive(true);
    }

    private void HowToBtnOnClick(){
       howToPlayWindow.SetActive(true);
    }

    private void QuitBtnOnClick(){
        Application.Quit();
    }
    private void CloseHowToPlayWindowBtnOnClick(){
        howToPlayWindow.SetActive(false);
    }     

    private void CloseDifficultyWindowBtnOnClick(){
        difficultyWindow.SetActive(false);
    }    

    private void Level1BtnOnClick(){
        GameHandler.SetDifficulty(1);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level2BtnOnClick(){
        GameHandler.SetDifficulty(2);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level3BtnOnClick(){
        GameHandler.SetDifficulty(3);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level4BtnOnClick(){
        GameHandler.SetDifficulty(4);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level5BtnOnClick(){
        GameHandler.SetDifficulty(5);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level6BtnOnClick(){
        GameHandler.SetDifficulty(6);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level7BtnOnClick(){
        GameHandler.SetDifficulty(7);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level8BtnOnClick(){
        GameHandler.SetDifficulty(8);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level9BtnOnClick(){
        GameHandler.SetDifficulty(9);
        Loader.Load(Loader.Scene.GameScene);
    }

    private void Level10BtnOnClick(){
        GameHandler.SetDifficulty(10);
        Loader.Load(Loader.Scene.GameScene);
    }    
}
