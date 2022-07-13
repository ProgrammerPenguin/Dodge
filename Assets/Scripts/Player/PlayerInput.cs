using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{



    public float X {get; private set;}
    public float Y {get; private set;}

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        X = Y = 0;

        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

        //Up = Input.GetKey(KeyCode.UpArrow);
        //Down = Input.GetKey(KeyCode.DownArrow);
        //Right = Input.GetKey(KeyCode.RightArrow);
        //Left = Input.GetKey(KeyCode.LeftArrow);
        //Jump = Input.GetKey(KeyCode.Space);


    }
}
