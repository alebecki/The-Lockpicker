using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockTrigger : MonoBehaviour
{
    public GameObject dronePrefab;
    public GameObject spawner;
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
            GetComponent<SpriteRenderer>().color = Color.green;

        }
    }

}
