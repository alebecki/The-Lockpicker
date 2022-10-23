using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    bool canLeave = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Drone"){
            if(canLeave){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
    }

    public void setCanLeave(bool b){
        canLeave = b;
    }
}
