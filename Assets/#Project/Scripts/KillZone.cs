using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Pool pool;

    private void OnTriggerEnter(Collider other)
   {
       TikTakBehaviour tik = other.GetComponent<TikTakBehaviour>();
       TikTakBehaviour tak = other.GetComponent<TikTakBehaviour>();

       if (tik != null)
       {
           tik.pool.Kill(tik);
           //lpool.Kill(tik);

       }
   }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.position, new Vector3(3, 3, 3));
    }

}
