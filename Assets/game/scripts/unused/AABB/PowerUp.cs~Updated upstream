using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {
	void Start () {
        ColliderAABB collider = GetComponent<ColliderAABB>();

        collider.OnCollisionStart += StartCollide;
        collider.OnCollisionEnd += EndCollide;

        CollisionManager.powerups.Add(collider);

        //decoupled very clean
    }
    void OnDestroy()
    {
        ColliderAABB collider = GetComponent<ColliderAABB>();
        CollisionManager.powerups.Remove(collider);

    }
    void StartCollide()
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;

    }
    void EndCollide()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
