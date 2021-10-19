using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Pool : MonoBehaviour
{

    public List<TikTakBehaviour> tiks = new List<TikTakBehaviour>();

    public GameObject tikPrefab;

    public TikTakBehaviour Create(Vector3 position, Quaternion rotation)
    {
        TikTakBehaviour tik = null;
       
        if (tiks.Count > 0)
        {
            tik = tiks[0];
            tiks.RemoveAt(0);
            tik.transform.rotation = rotation;
            tik.transform.position = position;
            tik.gameObject.SetActive(true);
        }
        else
        {
            GameObject tikGo = Instantiate(tikPrefab, position, rotation);
            tik = tikGo.GetComponent<TikTakBehaviour>();
        }

        return tik;

    }

    public void Kill(TikTakBehaviour tik)
    {
       
        tik.gameObject.SetActive(false);
        tiks.Add(tik);
    }
    
    // public void Kill(TikTakBehaviour taktik)
    // {
       
    //     taktik.gameObject.SetActive(false);
    //     taktiks.Add(taktik);
    // }


}
