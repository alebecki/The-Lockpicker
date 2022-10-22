using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = mousePos;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
