using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// near secu && not masked  - if space then plus punt (score) / if no space minus point (score)
// near secu && masked - if space then then minus point (score) / if no space plus punt (score)

public class CheckZone : MonoBehaviour
{
    private bool nearSecu;

    private bool check;

    public int score;

    void Update()
    {
        if (nearSecu && Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released - on time - .");
        }

        if (nearSecu && check && Input.GetKeyUp(KeyCode.Space))
        {
            //score +

            print("Space key detected ! Ha not masked! ");

            // change targetpoint to TZ3
        }
    }

    private void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.CompareTag("TikTak"))
        {
            nearSecu = true;
            check = false;
        }
        else
        {
            nearSecu = true;
            check = true;
        }

        //score
    }

    private void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("TikTak"))
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
