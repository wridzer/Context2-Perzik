using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseToDaughter : MonoBehaviour
{
    [SerializeField] private QuestNPC npc;

    public GameObject trigger;
    public GameObject tunaText;
    public GameObject leaveCave;
    public GameObject rocksBlockade;

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

        yield return new WaitForSeconds(6);

        tunaText.SetActive(false);
        trigger.SetActive(false);
        npc.GetComponent<QuestNPC>().QuestComplete();
    }
}
