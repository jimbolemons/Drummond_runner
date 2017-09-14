using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // when user presses down 
        //squish this object
        //else
        //unsquish this object

        //To get rid of acceleration on axis you can call get Axis raw instead of get axis

        if(Input.GetKey(KeyCode.Space))
        {
            transform.localPosition = new Vector3(1, 3, 1); //In c# floats need f's after them
            //Default vector 3's in local scale can not be individually manipulated, you must set a new vector 3
        }//End of if statement
        else
        {
            // transform.localScale = new Vector3(1, 1, 1);
            //or you can use
            transform.localPosition = new Vector3(1, 1, 1);
        }//end of if statement


        

	}
}
