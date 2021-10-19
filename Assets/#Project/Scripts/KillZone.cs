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
}
