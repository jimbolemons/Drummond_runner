﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public int walltype;

    void Start () {
        CollidingManager.walls.Add(GetComponent<AABBCollider>());
	}
	
	void OnDestroy () {
        CollidingManager.walls.Remove(GetComponent<AABBCollider>());
       
    }
}
