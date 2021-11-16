using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSpawner : MonoBehaviour
{
    [SerializeField]
    
    ObjectPooler objectPooler;

    private float radius = 1f;   // for gizmos

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    void Update()
    {
        objectPooler.SpawnFromPool("Right", transform.position, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 1f, 1f, 0.4f);
        Gizmos.DrawSphere(transform.position, radius);
    }
}
