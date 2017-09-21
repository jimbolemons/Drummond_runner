using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour {


    /// <summary>
    /// Velocity is measured in meters per second.
    /// </summary>
  //  Vector3 velocity = new Vector3();
    public int speed = 10;
    public float MoveDistance = 1;
    private int playerPosition = 1;
    public int Jump = 3;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


            // if D key is pressed down
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (playerPosition < 2)
                {
                    // move the player along the positive Z axis
                    transform.Translate(0, 0, MoveDistance);
                    // increment the player position
                    playerPosition++;
                }
            }
            // if A key is pressed down
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (playerPosition > 0)
                {
                    // move the player along the negative Z axis
                    transform.Translate(0, 0, -MoveDistance);
                    // decrement the player position
                    playerPosition--;
                }
            }

        if (Input.GetKey(KeyCode.Space))
        {

            if (playerPosition < 2)
            {
                // move the player along the positive Z axis
                transform.Translate(0, Jump, -MoveDistance);
                // increment the player position
                playerPosition++;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                if (playerPosition > 0)
                {
                    // move the player along the negative Z axis
                    transform.Translate(0, Jump, MoveDistance);
                    // decrement the player position
                    playerPosition--;
                }
            }





        }
        







        /*float axisH = Input.GetAxis("Vertical");
        velocity += speed *  new Vector3(0,0, axisH) * Time.deltaTime;//Acceleration which by definition is the changing of velocity //We put the ten to increase acceleration
        transform.position += velocity * Time.deltaTime; //Velocity is velocity in meters per second, Velocity by definition is the changing of position
       if(axisH == 0)velocity *= .9f;//This is frame based not time based, used to slow down
        */

        
    }
}


//
