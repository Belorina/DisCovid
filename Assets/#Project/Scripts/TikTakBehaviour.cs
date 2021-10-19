using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class TikTakBehaviour : MonoBehaviour
{
    public Vector3 destination;

    public R_Pool rpool;


    
    // Start is called before the first frame update
    void Start()
    {
        rpool = FindObjectOfType<R_Pool>();
    }
    void Update()
    {
        GetComponent<NavMeshAgent>().SetDestination(destination);
    }
}
