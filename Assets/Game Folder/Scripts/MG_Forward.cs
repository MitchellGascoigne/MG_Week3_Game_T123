using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MG_Forward : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    // reference to the player movement
    public GameObject objectToSpawn;
    void Start()
    {
        Instantiate(objectToSpawn);
    }
    void Update()
    {
        gameObject.transform.position = new Vector3(player.transform.position.x + 20, gameObject.transform.position.y, gameObject.transform.position.z);
        //float xPosUpdate = gameObject.transform.position.x;
        //xPosUpdate += speed * Time.deltaTime;
        //gameObject.transform.position = new Vector3(xPosUpdate, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
