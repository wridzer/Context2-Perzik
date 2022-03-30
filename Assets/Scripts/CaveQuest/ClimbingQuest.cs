using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingQuest : MonoBehaviour
{
    public GameObject snapperText;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(isVisible());
        }
    }


    IEnumerator isVisible()
    {
        snapperText.SetActive(true);

        yield return new WaitForSeconds(6);

        snapperText.SetActive(false);

        gameObject.SetActive(false);
    }
}
