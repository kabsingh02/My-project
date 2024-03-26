using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private ScreenFader screenFader;

    public void StartGame() {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        screenFader.FadeToColor("GameScene");
    }

    public void EndGame() {
        Debug.Log("QUIT!");
        Application.Quit();


    }

}
