using System.Collections;
using UnityEngine;


public class QuestObject : MonoBehaviour
{
    public GameObject gm;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.SetActive(false);
            gm.GetComponent<GameManager>().TalkedWithNPC();
        }
    }
}