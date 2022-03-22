using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebrisFalls : MonoBehaviour
{
    public GameObject TunaText;
    public GameObject rocks;
    public GameObject trigger;
    public GameObject trigger2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(isVisible());
        }
    }


    IEnumerator isVisible()
    {
        TunaText.SetActive(true);
        rocks.SetActive(true);

        yield return new WaitForSeconds(6);

        TunaText.SetActive(false);
        trigger.SetActive(false);
        trigger2.SetActive(false);
    }
}
