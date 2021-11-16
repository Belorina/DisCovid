using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// try re using nextdestination variable  to be easier later on condisions 
// 


[RequireComponent(typeof(NavMeshAgent))]
public class ClientBehaviour : MonoBehaviour, IPooledObject
{
    [SerializeField]
    private Vector3 destination;
    private NavMeshAgent agent;

    public float clientSpeed = 2f;

    [SerializeField]
    private int indexNextDestination = -1;

    //public TargetPoint[] targetPoints = new TargetPoint[0];

    public TargetPoint[] targetPoints;

    public Transform target;




    void start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;                  // allows for continuous movement between points

        clientSpeed = agent.speed;
        destination = agent.destination;

        target = TargetPoint.position;
    }

    void update()
    {
        //agent.Move(transform.forward * Time.deltaTime);

        // if (agent.remainingDistance <= agent.stoppingDistance)       // where definitions variables? 

        // {
        //     NextDestination();
        // }


        if (Vector3.Distance(destination, target.position) > 1.0f)
        {
            targetPoints = 

            targetPoints = TargetPoint.GivePoint();
            destination = target.position;
            agent.SetDestination(destination);
        }

        // //Update unit if the target moves one unit
        // if (Vector3.Distance(destination, target.position) > 1.0f)
        // {
        //     destination = target.position;
        //     agent.destination = destination;
        // }

    }

    public void NextDestination()
    {



        // indexNextDestination++;
        // indexNextDestination = indexNextDestination % targetPoints.Length;
        // destination = targetPoints[indexNextDestination].GivePoint();


        // //Debug.Log("test", gameObject);
        // agent.SetDestination(destination);

    }

    public void OnObjectSpawn()
    {
        //agent.Move(transform.forward * Time.deltaTime);

    }
}
