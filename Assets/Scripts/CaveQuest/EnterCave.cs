using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCave : MonoBehaviour
{
    public GameObject TunaText;


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            StartCoroutine(isVisible());
        }
    }


    IEnumerator isVisible()
    {
        TunaText.SetActive(true);

        yield return new WaitForSeconds(6);

        TunaText.SetActive(false);
    }
}
