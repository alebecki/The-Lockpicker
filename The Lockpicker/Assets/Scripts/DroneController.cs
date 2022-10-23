using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    Vector3 mousePos;
    float speed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);
    public bool pickedUp = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(pickedUp){
            position = Vector2.Lerp(transform.position, mousePos, speed);
        }
    }

    void FixedUpdate()
    {
        if(pickedUp){
            rb.MovePosition(position);
        }
    }

    void OnMouseOver(){
        pickedUp = true;
    }

}
