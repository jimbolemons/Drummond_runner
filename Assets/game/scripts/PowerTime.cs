using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerTime : MonoBehaviour {
   //class used for powerups
   public int type;

    void Start () {

	//adds componet aabbcollider to object 
        CollideManager.powerups.Add(GetComponent<AABBCollider>());
    }	
	
	void OnDestroy () {
		//removes aabbcolider from object when it is destroied
        CollideManager.powerups.Remove(GetComponent<AABBCollider>());

    }
  

}
