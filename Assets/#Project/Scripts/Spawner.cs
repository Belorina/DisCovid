using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Pool pool; 
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
            TikTakBehaviour tiktak = pool.Create(transform.position, transform.rotation);
            tiktak.destination = TikTakDestination;
            yield return new WaitForSeconds(delay);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 0, 1, 0.5f);
        Gizmos.DrawSphere(transform.position, 1);
    }
}
