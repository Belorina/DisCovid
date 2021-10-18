using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Pool pool;

    private void OnTriggerEnter(Collider other)
   {
       TikTakBehaviour tiktak = other.GetComponent<TikTakBehaviour>();

       if (tiktak != null)
       {
           pool.Kill(tiktak);
       }
   }
}
