using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class TikTakBehaviour : MonoBehaviour
{
    public Vector3 destination;

    public Pool pool;


    
    // Start is called before the first frame update
    void Start()
    {
        pool = FindObjectOfType<Pool>();
    }
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
}
