using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]

public class TikTakBehaviour : MonoBehaviour
{
    public Vector3 destination;

    private Pool pool;

    
    // Start is called before the first frame update
    void Start()
    {
        pool = FindObjectOfType<Pool>();
    }

    void Update()
    {
        GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(destination);
    }
}
