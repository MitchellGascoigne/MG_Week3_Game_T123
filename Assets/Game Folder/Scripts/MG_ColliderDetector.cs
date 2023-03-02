using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_ColliderDetector : MonoBehaviour
{
    //SpawnManager
    [SerializeField]
    public MG_SpawnManager spawnManager;

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
