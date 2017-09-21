using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideManager : MonoBehaviour {

    public AudioClip wallHit;
    public AudioClip powerUpHit;

    public AABBCollider player;

   
    static public List<AABBCollider> walls = new List<AABBCollider>();
    static public List<AABBCollider> powerups = new List<AABBCollider>();

    void Start () {		
	}	

	void LateUpdate () {
        DoCollisionDetectionWalls();
        DoCollisionDetectionPowerups();
    }

    private void DoCollisionDetectionWalls()
    {
        for (int i = walls.Count - 1; i >= 0; i--)
        {
            if(walls[i].CheckOverlap(player))
            {
                Destroy(walls[i].gameObject);
                cubemoverGen2.life--;
                cubemoverGen2.speed--;
             print(cubemoverGen2.life);
           AudioSource.PlayClipAtPoint(wallHit, transform.position);
            }

        }
       
    }

    private void DoCollisionDetectionPowerups()
    {
        for (int i = powerups.Count - 1; i >= 0; i--)
        {
            
                if (powerups[i].CheckOverlap(player))
                {
               
                 int type = powerups[i].GetComponent<PowerTime>().type ;

                if (type == 0)
                {
                   
                    cubemoverGen2.speed +=2;
                    cubemoverGen2.score++;

                }
                else if (type == 1)
                {
                    cubemoverGen2.life++;
                    cubemoverGen2.score++;          

                }
                else {

                    cubemoverGen2.score += 5;

                }
                print(cubemoverGen2.speed);



            Destroy(powerups[i].gameObject);
               

                AudioSource.PlayClipAtPoint(powerUpHit, transform.position);
                
            }
        }        

    }
}
