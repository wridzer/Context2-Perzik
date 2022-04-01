using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBattleStart : MonoBehaviour
{
    //[SerializeField] private GameObject BossBattleInstance;

    //on trigger enter
    //place player and disable move
    //start battle

    public GameObject octoIdle, octoAttack;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = transform.position;
            other.GetComponent<Movement>().enabled = false;
            octoAttack.SetActive(true);
            octoIdle.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
