using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_BearContoller : MonoBehaviour
{
    public float movementSpeed = 10f;
    public MG_SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        transform.Translate(new Vector3(hMovement, vMovement) * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
