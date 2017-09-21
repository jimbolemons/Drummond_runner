using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemoverGen2 : MonoBehaviour {

   
    private int lane = 2;
	//stores the position of the player
	private float positionX = 0;
	private float positionY = .5f;  
    private float positionZ = 0;
    private float rotationY = 0;
<<<<<<< Updated upstream
    static public int score = 0;
    static public int life = 10;

=======
	//the players score
    static public int score = 0;
	//the players life
    static public int life = 10;
	//gravity
>>>>>>> Stashed changes
    private float Yacc = -.025f;
	private float Yvel = 0;
  //jump impulse
    public float jumpPower = 2f;
    public int movement = 0;
<<<<<<< Updated upstream
=======
	//players speed
>>>>>>> Stashed changes
	static public float speed = 15;


    const int IDLE = 0;
    const int MOVE_LEFT = 1;
    const int MOVE_RIGHT = 2;
    

   
    const float GRAVITY = .05f;
    private int state = 0;

    void Start(){

    }

<<<<<<< Updated upstream
    void Update()
    {          
        switch (state)
        {
=======
    void Update(){          
        switch (state){
		//uses state mechine to detetmin what the player will do during this update
>>>>>>> Stashed changes
            case IDLE:          
			positionX += speed * Time.deltaTime;
			//checks to see if the player is pressing W
                if (Input.GetKeyDown(KeyCode.W)){
                    if (lane == 3){
                        lane--;
                        state = MOVE_LEFT;
                       }
                    else if (lane == 2){
                        lane--;
                        state = MOVE_LEFT;
                       }
                    else if (lane == 1){
                        state = IDLE;
                       }
                }
			//checks to see if the player is pressing S
                  if (Input.GetKeyDown(KeyCode.S)){
                        if (lane == 1){
                             lane++;
                             state = MOVE_RIGHT;
                            }
                        else if (lane == 2){
                             lane++;
                             state = MOVE_RIGHT;
                            }
                       else if (lane == 3){
                             state = IDLE;
                            }
                }
			//checks to see if the player is pressing space
                if (Input.GetKeyDown(KeyCode.Space)){
                    if (positionY == .5f){
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
		//applys gavity
        	Yvel += Yacc;
       	    positionY += Yvel;
		//stops the player from going too low
        if (positionY <= .5f){
            Yvel = 0;
            positionY = .5f;
           }   
           transform.position = new Vector3(positionX, positionY, positionZ);       
       	   transform.Rotate(0, rotationY, 0);
          
    }


}
