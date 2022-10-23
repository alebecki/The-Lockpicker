using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallScript : MonoBehaviour
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
            Instantiate(dronePrefab, spawner.transform.position, Quaternion.identity);//spawning at a weird place
            Destroy(other.gameObject); 
        }
    }
}
