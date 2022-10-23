using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lives == 0){
            SceneManager.LoadScene("GameOverScreen");
        }
    }

    public void DecreaseLives(){
        lives--;
    }

    public int GetLives(){
        return lives;
    }
}
