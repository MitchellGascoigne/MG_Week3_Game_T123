using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrometheusSpawnManager : MonoBehaviour
{

    //SpawnManager
    [SerializeField]
    public MG_SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
