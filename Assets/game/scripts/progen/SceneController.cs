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
            if (player.position.z - chunks[0].transform.position.z > 10)
            {
                Destroy(chunks[0]);
                chunks.RemoveAt(0); //removes the array
            }
        }
        while (chunks.Count < 5)
        {
            Vector3 position = Vector3.zero;
            if (chunks.Count > 0)
            {
               position = chunks[chunks.Count - 1].transform.Find("Connector").position;
            }
            GameObject obj = Instantiate(prefabTrackChunk, position, Quaternion.identity);

            chunks.Add(obj);
            //spawn new chunk...
            //spawn next 10 meters of the track


        }
    }
}
