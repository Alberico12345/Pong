using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_Movement : MonoBehaviour
{
    public float speed = 5f;
    public bool RightPaddle = false;
    public GameObject TopWall;
    public GameObject BottomWall;


    // Update is called once per frame
    void Update()
    {
// Debug.Log(!GetComponent<Collider2D>().IsTouching(TopWall.GetComponent<Collider2D>()));
        if(((RightPaddle && Input.GetKey(KeyCode.UpArrow)) || (!RightPaddle && Input.GetKey(KeyCode.W))) && !GetComponent<Collider2D>().IsTouching(TopWall.GetComponent<Collider2D>()))
        {
            transform.position += Vector3.up * speed;
        }
        if (((RightPaddle && Input.GetKey(KeyCode.DownArrow)) || (!RightPaddle && Input.GetKey(KeyCode.S))) && !GetComponent<Collider2D>().IsTouching(BottomWall.GetComponent<Collider2D>()))
        {
            transform.position += Vector3.down * speed;
        }
        
    }
}
