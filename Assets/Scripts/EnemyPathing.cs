using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] GameObject path;
    List<Transform> waypoints = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        int waypointIndex = 0;
        foreach(Transform t in path.GetComponentInChildren<Transform>())
        {
            waypoints.Add(t);
        }
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
