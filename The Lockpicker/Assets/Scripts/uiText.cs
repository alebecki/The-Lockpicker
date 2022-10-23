using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiText : MonoBehaviour
{
    public GameObject timer;
    public GameObject spawner;
    public GameObject timerText;
    public GameObject lifeText;
    int lifeNum;
    int timerNum;
    // Start is called before the first frame update
    void Start()
    {
        lifeNum = spawner.GetComponent<GameOver>().GetLives();
        timerNum = timer.GetComponent<TimerScript>().GetTime();
    }

    // Update is called once per frame
    void Update()
    {
        lifeNum = spawner.GetComponent<GameOver>().GetLives();
        timerNum = timer.GetComponent<TimerScript>().GetTime();
        timerText.GetComponent<Text>().text = timerNum.ToString() + " Seconds Remain";
        lifeText.GetComponent<Text>().text = lifeNum.ToString() + " Lives";
    }
}
