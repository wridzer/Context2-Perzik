using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingQuest : MonoBehaviour
{
    public GameObject snapperText;
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
        yield return new WaitForSeconds(4);

        snapperText.SetActive(true);
        npc.GetComponent<QuestNPC>().QuestComplete2();

        yield return new WaitForSeconds(6);

        snapperText.SetActive(false);

        gameObject.SetActive(false);
    }
}
