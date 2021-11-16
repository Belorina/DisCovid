using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSpawner : MonoBehaviour
{
    [SerializeField]
    
    ObjectPooler objectPooler;

    private float radius = 1f;   // for gizmos
public float delay = 1f;    // spawning delay 


    private void Start()
    {
        objectPooler = ObjectPooler.Instance;

        StartCoroutine(delaySpawn());
    }

    private IEnumerator delaySpawn()
    {
        while (true)
        {
            objectPooler.SpawnFromPool("Right", transform.position, Quaternion.identity);


            yield return new WaitForSeconds(delay);
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 1f, 1f, 0.4f);
        Gizmos.DrawSphere(transform.position, radius);
    }
}
