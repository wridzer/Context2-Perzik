using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeMonster : MonoBehaviour
{
    [SerializeField] private QuestNPC npc;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(isVisible());
        }
    }

    IEnumerator isVisible()
    {
        npc.GetComponent<QuestNPC>().QuestComplete2();

        yield return new WaitForSeconds(2);

        gameObject.SetActive(false);
    }
}
