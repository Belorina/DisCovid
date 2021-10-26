using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class TikTakBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;

    public TargetPoint[] targetPoints = new TargetPoint[0];
    private int indexNextDestination = -1;
    public Vector3 destination;

    //public Transform[] targets;
    //public int destTarget = 0;


    public Pool pool;


    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;                  // allows for continuous movement between points

        //agent.avoidancePriority = Random.Range(1, 100);
        agent.speed = Random.Range(1f, 10f);

        //destination = TargetPoint.
    }

    void Update()
    {
        // // Choose the next destination point when the agent gets
        // // close to the current one.
        // if (!agent.pathPending && agent.remainingDistance < 0.5f)
        //     GotoNextTarget();

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            NextDestination();
        }


    }
    private void NextDestination()
    {
        // // Returns if no targets have been set up
        // if (targets.Length == 0)
        //     return;

        // // Set the agent to go to the currently selected destination.
        // agent.destination = targets[destTarget].position;

        // // Choose the next point in the array as the destination,
        // // cycling to the start if necessary.
        // destTarget = (destTarget + 1) % targets.Length;

        indexNextDestination++;
        indexNextDestination = indexNextDestination % targetPoints.Length;
        destination = targetPoints[indexNextDestination].GivePoint();
        Debug.Log("test", gameObject);
        agent.SetDestination(destination);

    }



    // gizmos for avoidancePriority

    // private void OnDrawGizmos()
    // {
    //     if (agent != null)
    //     {
    //         Gizmos.color = Color.magenta;
    //         Gizmos.DrawSphere(transform.position + Vector3.up * 2,
    //         0.5f + (100 - agent.avoidancePriority) * 0.01f);

    //     }
    // }

}
