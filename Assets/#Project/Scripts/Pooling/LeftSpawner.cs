using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSpawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    public float radius = 1f;   // for gizmos

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }

    void Update()
    {
        objectPooler.SpawnFromPool("Left", transform.position, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 1f, 0f, 0.4f);
        Gizmos.DrawSphere(transform.position, radius);
    }
}
