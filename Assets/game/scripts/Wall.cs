using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public int walltype;

    void Start () {
		//adds aabbCollider to wall object
        CollideManager.walls.Add(GetComponent<AABBCollider>());
	}
	
	void OnDestroy () {
		//removes aabbCollider from wall object when it is destroyed
        CollideManager.walls.Remove(GetComponent<AABBCollider>());
       
    }
}
 