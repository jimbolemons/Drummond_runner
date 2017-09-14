using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemoverGen2 : MonoBehaviour {

   
    private int lane = 2;
    private int positionX = 0;
    private int positionY = 0;

    private float positionZ = 0;
    private float rotationY = 0;
  
    public int jumpPower = 1;
    public int movement = 1;
    //private int speed;

    const int IDLE = 0;
    const int MOVE_LEFT = 1;
    const int MOVE_RIGHT = 2;
    const int JUMP = 3;
   
    const int GRAVITY = 1;
    private int state = 0;

    void Start()
    {

    }

    void Update()
    {
        
        //bool leftClick = Input.GetMouseButton(0);
       // bool rightClick = Input.GetMouseButton(1);    
           
        switch (state)
        {
            case IDLE:                
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
                     state = JUMP;
                     positionY = jumpPower;
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

            case JUMP:
                positionY -= GRAVITY;
                if (positionY <= 0)
                    {
                     positionY = 0;
                     state = IDLE;
                    }
                break;         

           
        }

        transform.position = new Vector3(positionX, positionY, positionZ);       
        transform.Rotate(0, rotationY, 0);
          
    }


}
