using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DragonController : MonoBehaviour
{

    private Rigidbody2D myRB;
    //  private Animator myAnim;

    // random to alter speeds
    public System.Random random = new System.Random();
    // Start is called before the first frame update
    // private float rotate = 0;

    private int rotateSpeed = 20;

    bool rotateClockwise = true;

    // int searchLength = 0;

    // Awake?
    void Start()
    {

        //searchLength = random.Next(30, 100);


        // random = new System.Random();

        myRB = GetComponent<Rigidbody2D>();
        //  myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        // if (searchLength < 1)
        // {
        //     // start a new search
        //     searchLength = random.Next(30, 100);

        //     // switch direction.
        //     rotateClockwise = !rotateClockwise;
        // }
        // else
        // {
        //     searchLength--;
        // }

        // // start myRB.rotation; 0
        // // end myRB.rotation; 90

        Debug.Log(myRB.rotation);

        // rotating the wrong way
        if (myRB.rotation > 20)
        {
            rotateClockwise = true;

        }
        else if (myRB.rotation < -110)
        {
            rotateClockwise = false;
        }

        // add or subtract for clockwise?
        if (rotateClockwise)
        {
            // rotate forward
            transform.Rotate(0, 0, -(rotateSpeed * Time.deltaTime));
        }
        else
        {
            // rotate backwards
            transform.Rotate(0, 0, (rotateSpeed * Time.deltaTime));
        }


    }
}
