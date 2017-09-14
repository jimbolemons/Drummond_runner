using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //float jump = Input.GetAxis("Jump");

        //float jump = Input.GetButton("Jump");

        if (Input.GetButton("Jump"))
        {
            Rigidbody body = GetComponent<Rigidbody>();
            if (body != null) body.useGravity = true;
        }//end of statement

    }
}
