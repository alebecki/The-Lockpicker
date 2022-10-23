using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenScript : MonoBehaviour
{
    public GameObject NotClicked;
    public GameObject Clicked;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void changeWhenHover()
    {
        NotClicked.SetActive(false);
        Clicked.SetActive(true);
    }

    public void changeWhenLeaves()
    {
        Clicked.SetActive(false);
        NotClicked.SetActive(true);
    }
}
