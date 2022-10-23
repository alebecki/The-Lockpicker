using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    // public Button NotClicked;
    // public Button Clicked;

    //Start is called before the first frame updates
    void Start()
    {

    }
    //Update is called once per frame
    void Update()
    {

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // public void changeWhenHover()
    // {
    //     NotClicked.gameObject.SetActive(false);
    //     Clicked.gameObject.SetActive(true);
    // }

    // public void changeWhenLeaves()
    // {
    //     Clicked.gameObject.SetActive(false);
    //     NotClicked.gameObject.SetActive(true);
    // }
}
