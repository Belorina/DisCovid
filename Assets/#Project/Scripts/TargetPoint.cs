using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoint : MonoBehaviour
{

    //[Range(0.1f, 10f)]
    private float radius = 1f;

    public Vector3 position;

    public TargetPoint[] targetPoints;


    public Vector3 GivePoint()
    {
        print("giving point");
        //Vector3 point = Random.insideUnitSphere * radius;
        Vector3 point = Vector3.zero;

        point.z = point.y;
        point.y = 0;

        point += transform.position;
        return point;
    }

    // void start()
    // {
    //     position = gameObject.transform.position;

    // }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0f, 0.5f, 0.9f, 0.4f);
        Gizmos.DrawSphere(transform.position, radius);
    }

}
