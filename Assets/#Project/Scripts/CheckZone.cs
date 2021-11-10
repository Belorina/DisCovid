using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckZone : MonoBehaviour
{
    private bool nearSecu;

    void Update()
    {
        if (nearSecu && Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released - on time - .");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Not_Masked"))
        {
            nearSecu = true;
        }

        //score
    }

    private void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("Not_Masked"))
        {
            nearSecu = false;
        }
    }


    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.2f);
        Gizmos.DrawCube(transform.position, new Vector3(4f, 4f, 4f));
    }



}
