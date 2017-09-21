using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public int walltype;

    void Start () {
        CollideManager.walls.Add(GetComponent<AABBCollider>());
	}
	
	void OnDestroy () {
        CollideManager.walls.Remove(GetComponent<AABBCollider>());
       
    }
}
