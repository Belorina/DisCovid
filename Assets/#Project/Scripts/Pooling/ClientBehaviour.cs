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
    private NavMeshAgent agent;

    public List<TargetPoint> targetPoints = new List<TargetPoint>();

    [SerializeField]
    private int indexNextDestination = -1;

    [SerializeField]
    private Vector3 actualDestination;

    public float clientSpeed = 2f;



    void start()
    {
        //position = gameObject.transform.position;

        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.autoBraking = false;                  // allows for continuous movement between points
        agent.speed = clientSpeed;

        NextDestination();
    }

    void Update()
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            print("I am here?");
            NextDestination();
        }
    }

    private void NextDestination()
    {
        //int oldIndex = indexNextDestination;

        print(indexNextDestination);

        indexNextDestination++;
        indexNextDestination = indexNextDestination % targetPoints.Count;

        print(indexNextDestination);

        // while (oldIndex == indexNextDestination)         //  !!!!!!!!!   foreverLOOP
        // {
        //     for (int i = 0; i < targetPoints.Count; i++)
        //     {
        //         indexNextDestination = i;
        //         print(i);
        //     }

        actualDestination = targetPoints[indexNextDestination].GivePoint();

        agent.SetDestination(actualDestination);
        // }
    }

    public void OnObjectSpawn()
    {
        //agent.Move(transform.forward * Time.deltaTime);

    }
}
