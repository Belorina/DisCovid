using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GBILZone : MonoBehaviour
{
    private Pool pool;

    private void OnTriggerEnter(Collider other)
   {
       TikTakBehaviour tiktak = other.GetComponent<TikTakBehaviour>();

       if (tiktak != null)
       {
           tiktak.pool.Kill(tiktak);

       }
   }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.position, new Vector3(4f, 4f, 4f));
    }

}
