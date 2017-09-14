using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAABB : MonoBehaviour {
    List<ColliderAABB> currentOverlaps = new List<ColliderAABB>();

        
        //1 positions is stored, minimum x and minmum stored as a single vector3 max of the x,y,z
    //two additional points
    Vector3 min = Vector3.zero;
    Vector3 max = Vector3.zero;
    //variable tracks size of objects AABB
    public Vector3 halfSize;

    public delegate void CollisionEvent();
    public event CollisionEvent OnCollisionStart;
    public event CollisionEvent OnCollisionEnd;

	void Update () {
        CalcEdges();
	}

    void CalcEdges()
    {
        min = transform.position - halfSize;
        max = transform.position + halfSize;
    }
    public bool CheckOverlap(ColliderAABB other)
    {
        //X 
        if (min.x > other.max.x) return false;
        if (max.x < other.min.x) return false;
        //Y
        if (min.y > other.max.y) return false;
        if (max.y < other.min.y) return false;
        //Z
        if (min.z > other.max.z) return false;
        if (max.z < other.min.z) return false;

        return true;
    }

    public void SetCollisionWith(bool isColliding, ColliderAABB other)
    {
        if (isColliding)
        {
            if (!currentOverlaps.Contains(other))
            {
                currentOverlaps.Add(other);
                OnCollisionStart();// dispatch event (collision start event)
                print("collision begin");


            }
        } else
        {
            if (currentOverlaps.Contains(other))
            {
                currentOverlaps.Remove(other);
                //TODO : 
                OnCollisionEnd();// dispatch event (collision end)
                print("collision end");
            }
        }


    }
}
///game loop will check enemies AABB and player AABB