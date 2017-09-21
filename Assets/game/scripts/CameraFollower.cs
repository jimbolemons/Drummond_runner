using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {
    public Transform target;

    public Vector3 offset;

	// Update is called once per frame
	void LateUpdate () {

        transform.position = new Vector3(target.position.x, 2, 0);

        //transform.position = target.position + offset;
		
	}
}
