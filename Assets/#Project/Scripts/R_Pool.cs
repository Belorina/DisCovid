using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Pool : MonoBehaviour
{

    public List<TikTakBehaviour> taks = new List<TikTakBehaviour>();
    public GameObject takPrefab;

    public TikTakBehaviour Create(Vector3 position, Quaternion rotation)
    {
        TikTakBehaviour tak = null;

        if (taks.Count > 0)
        {
            tak = taks[0];
            taks.RemoveAt(0);
            tak.transform.rotation = rotation;
            tak.transform.position = position;
            tak.gameObject.SetActive(true);
        }
        else
        {
            GameObject takGo = Instantiate(takPrefab, position, rotation);
            tak = takGo.GetComponent<TikTakBehaviour>();
        }

        return tak;

    }

    public void Kill(TikTakBehaviour tak)
    {
       
        tak.gameObject.SetActive(false);
        taks.Add(tak);
    }
    
    // public void Kill(TikTakBehaviour taktik)
    // {
       
    //     taktik.gameObject.SetActive(false);
    //     taktiks.Add(taktik);
    // }


}
