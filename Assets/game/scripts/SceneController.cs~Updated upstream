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
            if (player.position.x - chunks[0].transform.position.x > 20)
            {
                Destroy(chunks[0]);
                chunks.RemoveAt(0); 
            }
        }
        while (chunks.Count < 5)
        {
            Vector3 position = Vector3.zero;
            if (chunks.Count > 0)
            {
               position = chunks[chunks.Count - 1].transform.Find("Connector").position;
            }
            GameObject obj = Instantiate(prefabTrackChunk, position, Quaternion.Euler(0,90,0));

            chunks.Add(obj);
            if (chunks.Count >= 3)
            {
                obj.GetComponent<ObjectSpawning>().spawnObjects();
            }
            


        }
    }
}
