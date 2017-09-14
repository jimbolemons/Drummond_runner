using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTimer : MonoBehaviour {
    /// <summary>
    /// how many seconds this object has existed.
    /// </summary>
    float age = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        age += Time.deltaTime;

        if(age > 3)
        {
            Destroy(gameObject); //Every component can reference the object it is attached to with gameObject.
        }
	}
}
