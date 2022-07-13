using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool UseSpeed = false;
    public GameObject player;
    private PlayerInput _input;
    // private Transform TP;
    private Rigidbody playerRigidbody;
    public float speed = 3f;
    // public float jumpspeed = 3f;
    //public float y = 7f;

    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        playerRigidbody = GetComponent<Rigidbody>();
        //TP = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float xSpeed = _input.X * speed;
        float zSpeed = _input.Y * speed;
        if (UseSpeed)
        {
            playerRigidbody.velocity = new Vector3(xSpeed, 0f, zSpeed);
        }
        else
        {
            playerRigidbody.AddForce(xSpeed, 0f, zSpeed);
        }
        //    if (_input.Up == true)
        //    {
        //        Debug.Log("UP");
        //        playerRigidbody.AddForce(0f, 0f, speed);
        //    }

        //    if (_input.Down == true)
        //    {
        //        Debug.Log("Down");
        //        playerRigidbody.AddForce(0f, 0f, -speed);
        //    }

        //    if (_input.Right == true)
        //    {
        //        Debug.Log("Right");
        //        playerRigidbody.AddForce(speed, 0f, 0f);
        //    }

        //    if (_input.Left == true)
        //    {
        //        Debug.Log("Left");
        //        playerRigidbody.AddForce(-speed, 0f, 0f);
        //    }

        //    if (_input.Jump == true && TP.position.y < y)
        //    {
        //        Debug.Log("Jump");
        //        playerRigidbody.AddForce(0f, jumpspeed, 0f);
        //    }
        //}
    }
}
