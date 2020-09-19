﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader {

    public enum Scene{
        GameScene,
        Loading,
        MainMenu
    }

    private static Action loaderCallbackAction;

    public static void Load(Scene scene){
        // Set up the callback action that will trigger after the loading scene is loaded
        loaderCallbackAction = () => {
            // Load target scene when loading scene is loaded
            SceneManager.LoadScene(scene.ToString());
        };
        //Load loading scene
        SceneManager.LoadScene(Scene.Loading.ToString());
    }

    public static void LoaderCallback(){
        if(loaderCallbackAction != null){
            loaderCallbackAction();
            loaderCallbackAction = null;
        }

    }

    public static bool IsGameSceneLoaded(){
        return SceneManager.GetActiveScene().ToString() == Scene.GameScene.ToString();
    }

}
