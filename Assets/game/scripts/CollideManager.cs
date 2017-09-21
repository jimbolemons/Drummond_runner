using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideManager : MonoBehaviour {
	//audio clips for collitions
    public AudioClip wallHit;
    public AudioClip powerUpHit;
	//
    public AABBCollider player;
   //creates two lists for the powerups and walls
    static public List<AABBCollider> walls = new List<AABBCollider>();
    static public List<AABBCollider> powerups = new List<AABBCollider>();

    void Start () {		
	}	

	void LateUpdate () {
		//calls for the colitions detection to be done
        DoCollisionDetectionWalls();
        DoCollisionDetectionPowerups();
    }
	//collition detection for the walls
    private void DoCollisionDetectionWalls(){
		//goes through all of the wall objects
        for (int i = walls.Count - 1; i >= 0; i--){
			//checks to see if the player is coliding with this wall 
            if(walls[i].CheckOverlap(player)){
                Destroy(walls[i].gameObject);
                cubemoverGen2.life--;
                cubemoverGen2.speed--;
                print(cubemoverGen2.life);
				//check to see if the players life is now too low to live if it is too low the it send the player to the game over sceen
             if (cubemoverGen2.life <= 0) {
                    SceneManager.LoadScene("Gameover");
                }
           		AudioSource.PlayClipAtPoint(wallHit, transform.position);
            }
        }       
    }
	//collition detection for the powerups
    private void DoCollisionDetectionPowerups()
    {
	//goes through all the power ups in the list	
        for (int i = powerups.Count - 1; i >= 0; i--){  
			//checks for collitions
           if (powerups[i].CheckOverlap(player)){
				//gets the type of the power up                
                int type = powerups[i].GetComponent<PowerTime>().type ;
				//uses the type of the power up to determin how it will effect the player
              if (type == 0){                   
                    cubemoverGen2.speed +=2;
                    cubemoverGen2.score++;
                }else if (type == 1){
                    cubemoverGen2.life++;
                    cubemoverGen2.score++;  
                }else{
                    cubemoverGen2.score += 5;
                }
                print(cubemoverGen2.speed);
           	    Destroy(powerups[i].gameObject);  
                AudioSource.PlayClipAtPoint(powerUpHit, transform.position);
                
            }
        }        

    }
}
