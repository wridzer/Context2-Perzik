using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phase2trigger : MonoBehaviour
{
    public GameObject squid, gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            squid.GetComponent<Animation>().enabled = true;
            gameManager.GetComponent<GameManager>().PhaseOneComplete();
        }
    }
}
