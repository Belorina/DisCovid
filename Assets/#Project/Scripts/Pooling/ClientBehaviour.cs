using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClientBehaviour : MonoBehaviour, IPooledObject

{
    [SerializeField]
    private NavMeshAgent agent;

    public float clientSpeed = 2f;

    [SerializeField]
    private int indexNextDestination = -1;

    public TargetPoint[] targetPoints = new TargetPoint[0];

    private Vector3 destination;



    void start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;                  // allows for continuous movement between points

        clientSpeed = agent.speed;
    }

    void update()
    {
        //agent.Move(transform.forward * Time.deltaTime);

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            NextDestination();
        }
    }

    public void NextDestination()
    {

        indexNextDestination++;
        indexNextDestination = indexNextDestination % targetPoints.Length;
        destination = targetPoints[indexNextDestination].GivePoint();
        //Debug.Log("test", gameObject);
        agent.SetDestination(destination);

    }

    public void OnObjectSpawn()
    {
        //agent.Move(transform.forward * Time.deltaTime);

    }
}
