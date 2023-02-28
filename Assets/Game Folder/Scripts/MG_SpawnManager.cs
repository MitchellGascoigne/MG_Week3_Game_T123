using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_SpawnManager : MonoBehaviour
{
    MG_RoadSpawner roadSpawner;
    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<MG_RoadSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
    }
}
