using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerTime : MonoBehaviour {
   
   public int type;

    void Start () {
        CollideManager.powerups.Add(GetComponent<AABBCollider>());
    }	
	
	void OnDestroy () {
        CollideManager.powerups.Remove(GetComponent<AABBCollider>());

    }
  

}
