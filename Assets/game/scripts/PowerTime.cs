using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerTime : MonoBehaviour {
<<<<<<< Updated upstream
   
   public int type;

    void Start () {
=======
   //class used for powerups
   public int type;

    void Start () {

	//adds componet aabbcollider to object 
>>>>>>> Stashed changes
        CollideManager.powerups.Add(GetComponent<AABBCollider>());
    }	
	
	void OnDestroy () {
<<<<<<< Updated upstream
=======
		//removes aabbcolider from object when it is destroied
>>>>>>> Stashed changes
        CollideManager.powerups.Remove(GetComponent<AABBCollider>());

    }
  

}
