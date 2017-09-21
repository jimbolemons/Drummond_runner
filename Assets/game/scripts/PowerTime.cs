using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerTime : MonoBehaviour {
   
   public int type;

    void Start () {
        CollidingManager.powerups.Add(GetComponent<AABBCollider>());
    }	
	
	void OnDestroy () {
        CollidingManager.powerups.Remove(GetComponent<AABBCollider>());

    }
  

}
