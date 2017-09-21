using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public int walltype;

    void Start () {
<<<<<<< Updated upstream
=======
		//adds aabbCollider to wall object
>>>>>>> Stashed changes
        CollideManager.walls.Add(GetComponent<AABBCollider>());
	}
	
	void OnDestroy () {
<<<<<<< Updated upstream
=======
		//removes aabbCollider from wall object when it is destroyed
>>>>>>> Stashed changes
        CollideManager.walls.Remove(GetComponent<AABBCollider>());
       
    }
}
<<<<<<< Updated upstream
=======
 
>>>>>>> Stashed changes
