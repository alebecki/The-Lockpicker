using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public Text gameOvertext = "Game over! Better brush up on your lockpicking skills by breaking out of prison. If you can, after the criminals you’ve been robbing don’t come after you first. Better luck next time.";
    
    yield return new reading_time(10f);

    SceneManager.LoadScene("MainMenu");

}
