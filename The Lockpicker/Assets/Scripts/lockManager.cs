using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockManager : MonoBehaviour
{
    public int maxLocks;
    int completedLocks = 0;
    public GameObject door;
    public GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(completedLocks == maxLocks){
            Destroy(door);
            exit.GetComponent<Exit>().setCanLeave(true);
        }
    }

    public void increaseLock(){
        completedLocks++;
    }

}
