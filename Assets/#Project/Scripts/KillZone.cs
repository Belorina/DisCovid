using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public R_Pool rpool;
    public L_Pool lpool;


    private void OnTriggerEnter(Collider other)
   {
       TikTakBehaviour tik = other.GetComponent<TikTakBehaviour>();
       TikTakBehaviour tak = other.GetComponent<TikTakBehaviour>();

       if (tik != null)
       {
           tik.rpool.Kill(tik);
           //lpool.Kill(tik);

       }
   }
}
