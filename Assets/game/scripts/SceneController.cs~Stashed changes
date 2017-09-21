using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    public GameObject prefabTrackChunk;
    public Transform player;

    List<GameObject> chunks = new List<GameObject>();



    void Update()
    {
        if (chunks.Count > 0)
        { 
			//checks to see if the track chunk is off the screen and if so destroys it
            if (player.position.x - chunks[0].transform.position.x > 20)
            {
                Destroy(chunks[0]);
                chunks.RemoveAt(0); 
            }
        }
		//makes sure that there are always only 5 chnks of track
        while (chunks.Count < 5)
        {
            Vector3 position = Vector3.zero;
			// looks if a chuck is destroyed it spawns a new one at the last ones connector point
            if (chunks.Count > 0)
            {
               position = chunks[chunks.Count - 1].transform.Find("Connector").position;
            }
			//instatiates new track
            GameObject obj = Instantiate(prefabTrackChunk, position, Quaternion.Euler(0,90,0));


            chunks.Add(obj);
            if (chunks.Count >= 3)
            {
                obj.GetComponent<ObjectSpawning>().spawnObjects();
            }
            


        }
    }
}
