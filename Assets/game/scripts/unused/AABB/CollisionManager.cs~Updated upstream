using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour {
    //check collision and listen
    //array of objects that tracks AABB collision groups
    //create collision groups
    //will inform what lists we can create
    //one list of all enemies /powerups, etc

    ColliderAABB player;
    static public List<ColliderAABB> powerups = new List<ColliderAABB>();

	void Start () {
        player = GameObject.Find("Cube").GetComponent<ColliderAABB>();

	}
	
	void LateUpdate () {
        DoCollisionDetection();

		
	}

    void DoCollisionDetection()
    {
        foreach(ColliderAABB powerup in powerups)
        {
            bool result = player.CheckOverlap(powerup);

            player.SetCollisionWith(result, powerup);

            powerup.SetCollisionWith(result, player);

            /*EVENTs
            {
                //                print("collision!");
                //                 Destroy(powerup);
                //                Destroy(powerup.gameObject);
                powerup.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0, 1, 1, 1, 1, 1);

                //event listeners, 
            }*/
        }

    }
}
