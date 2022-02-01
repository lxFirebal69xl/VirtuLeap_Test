using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomAreaSpawner : MonoBehaviour
{

    public GameObject itemToSpread;
    public int numItemsToSpawn = 10;

    public float itemXSpread = 10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;
    

    void SpreadItem()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(0, 0), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        GameObject clone = Instantiate(itemToSpread, randPosition, Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numItemsToSpawn; i++)
        {
            Debug.Log("Items spawned: " + i);
            SpreadItem();
        }

        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
