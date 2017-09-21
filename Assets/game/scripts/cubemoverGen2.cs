﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemoverGen2 : MonoBehaviour {

   
    private int lane = 2;
	private float positionX = 0;
	private float positionY = .5f;    

    private float positionZ = 0;
    private float rotationY = 0;
    static public int score = 0;
    static public int life = 10;

    private float Yacc = -.025f;
	private float Yvel = 0;
  
    public float jumpPower = 2f;
    public int movement = 0;
	static public float speed = 15;


    const int IDLE = 0;
    const int MOVE_LEFT = 1;
    const int MOVE_RIGHT = 2;
    

   
    const float GRAVITY = .05f;
    private int state = 0;

    void Start()
    {

    }

    void Update()
    {          
        switch (state)
        {
            case IDLE:          
			positionX += speed * Time.deltaTime;
                if (Input.GetKeyDown(KeyCode.W))
                {
                    if (lane == 3)
                       {
                        lane--;
                        state = MOVE_LEFT;
                       }
                    else if (lane == 2)
                       {
                        lane--;
                        state = MOVE_LEFT;
                       }
                    else if (lane == 1)
                       {

                        state = IDLE;
                       }
                }
                  if (Input.GetKeyDown(KeyCode.S))
                    {
                        if (lane == 1)
                            {
                             lane++;
                             state = MOVE_RIGHT;
                            }
                        else if (lane == 2)
                            {
                             lane++;
                             state = MOVE_RIGHT;
                            }
                       else if (lane == 3)
                            {
                             state = IDLE;
                            }
                }

                if (Input.GetKeyDown(KeyCode.Space))
                    {
                    if (positionY == .5f)
                    {
                        Yvel = jumpPower;

                    }

                }                

                break;
            case MOVE_LEFT:
                positionZ += movement;
                state = IDLE;
                break;

            case MOVE_RIGHT:
                positionZ -= movement;
                state = IDLE;
                break;       

           
        }
        Yvel += Yacc;
        positionY += Yvel;

        if (positionY <= .5f)
        {
            Yvel = 0;
            positionY = .5f;

           }
       

        transform.position = new Vector3(positionX, positionY, positionZ);       
        transform.Rotate(0, rotationY, 0);
          
    }


}
