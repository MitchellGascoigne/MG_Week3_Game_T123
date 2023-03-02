using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MG_RoadSpawner : MonoBehaviour
{
    public List<GameObject> originalRoads;
    public List<GameObject> activeRoads;
    private float offset = 27.95f;
    // Start is called before the first frame update
    void Start()
    {


        if(activeRoads != null && activeRoads.Count > 0)
        {
            activeRoads = activeRoads.OrderBy(r => r.transform.position.x).ToList();
        }
    }

    public void MoveRoad()
    {
        Debug.Log("MoveRoad() called from " + gameObject.name);
        GameObject movedRoad = activeRoads[0];
        activeRoads.Remove(movedRoad);
        float newX = activeRoads[activeRoads.Count- 1].transform.position.x + offset;
        movedRoad.transform.position = new Vector3(newX, 0, 0);
        activeRoads.Add(movedRoad);
    }
}

// when reset active road = original roads
