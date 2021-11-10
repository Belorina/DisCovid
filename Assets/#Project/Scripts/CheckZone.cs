using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // if (other.gameObject.CompareTag("Not_Masked"))
        // {
        //     print("he is not masked!");
        // }

        //score
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(4f, 4f, 4f));
    }


     
}
