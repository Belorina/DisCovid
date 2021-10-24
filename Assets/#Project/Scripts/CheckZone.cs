using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckZone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Not_Masked"))
        {
            print("he is not masked!");
        }

        //score

        

    }

    // void OnDrawGizmos()
    // {
    //     Gizmos.color = new Color(1, 0, 0, 0.5f);
    //     Gizmos.DrawCube(transform.position, new Vector3(1f, 1f, 1f));
    // }

}
