using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawning : MonoBehaviour
{

    // Spawn Areas
    // Lane One
    public GameObject topLaneOneSpawnPoint;    // 0
    public GameObject middleLaneOneSpawnPoint; // 1
    public GameObject bottomLaneOneSpawnPoint; // 2



    // Obstacles
    public GameObject Wall1;         // 0
    public GameObject Wall2;         // 1
    public GameObject Wall3;         // 2
    public GameObject ScorePowerUp;  // 0
    public GameObject LifePowerUp;   // 1
    public GameObject SpeedPowerUp;  // 2


    List<GameObject> Points = new List<GameObject>();
    List<GameObject> Obstacles = new List<GameObject>();
    List<GameObject> PowerUps = new List<GameObject>();

   // List<GameObject> boopWalls = new List<GameObject>();

    // Use this for initialization
    public void spawnObjects()
    {

        // Adds all Spawn Areas to the Points List
        // Lane One
        Points.Add(topLaneOneSpawnPoint);
        Points.Add(middleLaneOneSpawnPoint);
        Points.Add(bottomLaneOneSpawnPoint);
        // Lane Two


        // Adds all Objects to the Obstacles List
        Obstacles.Add(Wall1);
        Obstacles.Add(Wall2);
        Obstacles.Add(Wall3);
        //adds stuff to the PowerUps list
        PowerUps.Add(ScorePowerUp);
        PowerUps.Add(LifePowerUp);
        PowerUps.Add(SpeedPowerUp);



        // gets the amount of objects it wants to spawn for that chunk
        int amount = Random.Range(1, Points.Count + 1); // max is exclusive


        //print(amount);

        while (amount > 0)
        {
            // determines the spawn location of the object
            int spawnLocation = Random.Range(0, Points.Count); // max is exclusive
            Vector3 position = Points[spawnLocation].transform.position;

            // determines if a powerup object can replace a wall object in this position
            // int isPowerUp = Random.Range(0, 101); // max is exclusive

            // if isPowerUp is less than 25 AND we havnt spawned a powerup on this trackpiece yet, then spawn a powerup in this location
            // OR if this is the last object spawning on this track piece AND we havnt spawned a powerup on this trackpiece yet, then spawn a powerup in this location
            // ELSE spawn a wall in this location
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


               // var newWall1 = Instantiate(Wall1, position, Quaternion.identity);
               // newWall1.transform.parent = transform;
               //print("spawn");
            }

            // remove this point from the List of points so that only one object can spawn in that location
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
