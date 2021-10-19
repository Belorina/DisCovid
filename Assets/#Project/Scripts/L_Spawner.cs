using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Spawner : MonoBehaviour
{

    //public R_Pool rpool;
    public L_Pool lpool;
    public float delay = 1f;
    public Vector3 TikTakDestination;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true)
        {
            TikTakBehaviour tik = lpool.Create(transform.position, transform. rotation);
            tik.destination = TikTakDestination;

            // TikTakBehaviour tak = rpool.Create(transform.position, transform. rotation);
            // tak.destination = TikTakDestination;

            yield return new WaitForSeconds(delay); 
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
