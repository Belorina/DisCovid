using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSpawner : MonoBehaviour
{
    [SerializeField]
    ObjectPooler objectPooler;

    private float radius = 1f;   // for gizmos

    public float delay = 1f;    // spawning delay 

    //public TargetPoint myTarget;

    //public Vector3 clientDestination;

    //public ClientBehaviour client;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;

        StartCoroutine(delaySpawn());

        //myTarget = gameObject.GetComponent(typeof(TargetPoint)) as TargetPoint;

        //TargetPoint[] myTargets = myTarget.targetPoints;


        //client.destination = clientDestination;
    }

    private IEnumerator delaySpawn()
    {
        while (true)
        {
            objectPooler.SpawnFromPool("Left", transform.position, Quaternion.identity);


            yield return new WaitForSeconds(delay);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 1f, 0f, 0.4f);
        Gizmos.DrawSphere(transform.position, radius);
    }
}
