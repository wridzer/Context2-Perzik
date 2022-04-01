using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseToDaughter : MonoBehaviour
{
    [SerializeField] private QuestNPC npc;
    [SerializeField] private QuestNPC npc2;
    [SerializeField] private QuestNPC npc3;

    public GameObject trigger;
    public GameObject tunaText;
    public GameObject leaveCave;
    public GameObject rocksBlockade;
    public GameObject mainCave;

    public GameObject climbTriggers;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(isVisible());
        }
    }

    IEnumerator isVisible()
    {
        tunaText.SetActive(true);
        leaveCave.SetActive(true);
        rocksBlockade.SetActive(true);
        mainCave.SetActive(false);

        yield return new WaitForSeconds(6);

        tunaText.SetActive(false);
        trigger.SetActive(false);
        climbTriggers.SetActive(true);
        npc.GetComponent<QuestNPC>().QuestComplete2();
        npc2.GetComponent<QuestNPC>().QuestComplete();
        npc3.GetComponent<QuestNPC>().QuestComplete();
    }
}
