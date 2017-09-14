using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSpin : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

        // transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 1, transform.eulerAngles.z);
        // Vector3 rot = transform.eulerAngles;
        // rot.y += 1;
        // transform.eulerAngles = rot;//These do the same thing but there are rounding errors.

        transform.Rotate(0, 60* Time.deltaTime, 0);//This gets rid of any annoying bugs  //We use Time.deltaTime to keep your game running at a constant speed
	}
}
