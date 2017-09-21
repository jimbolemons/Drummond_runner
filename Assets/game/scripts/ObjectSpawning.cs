using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawning : MonoBehaviour
{

    public GameObject topSpawnPoint;    // 0
    public GameObject middleSpawnPoint; // 1
    public GameObject bottomSpawnPoint; // 2
    
    public GameObject Wall1;         // 0
    public GameObject Wall2;         // 1
    public GameObject Wall3;         // 2

    public GameObject ScorePowerUp;  // 0
    public GameObject LifePowerUp;   // 1
    public GameObject SpeedPowerUp;  // 2


    List<GameObject> Points = new List<GameObject>();
    List<GameObject> Obstacles = new List<GameObject>();
    List<GameObject> PowerUps = new List<GameObject>();


    public void spawnObjects()
    {
       
        Points.Add(topSpawnPoint);
        Points.Add(middleSpawnPoint);
        Points.Add(bottomSpawnPoint);

        Obstacles.Add(Wall1);
        Obstacles.Add(Wall2);
        Obstacles.Add(Wall3);
     
        PowerUps.Add(ScorePowerUp);
        PowerUps.Add(LifePowerUp);
        PowerUps.Add(SpeedPowerUp);
      
        int amount = Random.Range(1, Points.Count + 1);               

        while (amount > 0)
        {           
            int spawnLocation = Random.Range(0, Points.Count); 
            Vector3 position = Points[spawnLocation].transform.position;           
            if (amount <= 1)
            {
                int powerUp = Random.Range(0, PowerUps.Count);
                var newPowerUp = Instantiate(getPowerUp(powerUp), position, Quaternion.identity);
                newPowerUp.transform.parent = transform;
                newPowerUp.GetComponent<PowerTime>().type = powerUp;
            }
            else
            {
                int wall = Random.Range(0, Obstacles.Count);
                var newWall = Instantiate(getWall(wall), position, Quaternion.identity);
                newWall.transform.parent = transform;
                newWall.GetComponent<Wall>().walltype = wall;              
            }          
            Points.RemoveAt(spawnLocation);
            amount--;
        }
    }
     
    void Update()
    {

    }

    public GameObject getWall(int wallIndexNumber)
    {
        return Obstacles[wallIndexNumber]; 
    }

    public GameObject getPowerUp(int powerUpIndexNumber)
    {
        return PowerUps[powerUpIndexNumber]; 
    }
}
