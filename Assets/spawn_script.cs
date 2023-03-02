using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour
{
    public GameObject our_prefab;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(our_prefab, transform.position, transform. rotation);
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
