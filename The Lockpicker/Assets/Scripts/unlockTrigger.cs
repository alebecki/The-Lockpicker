using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockTrigger : MonoBehaviour
{
    //public GameObject dronePrefab;
    //public GameObject spawner;
    public GameObject lockManager;
    bool onlyOnce = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Drone" && onlyOnce){
            onlyOnce = false;
            GetComponent<SpriteRenderer>().color = Color.green;
            lockManager.GetComponent<lockManager>().increaseLock();
        }
    }

}
