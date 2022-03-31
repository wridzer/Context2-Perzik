using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCaveQuest : MonoBehaviour
{
    [SerializeField] private QuestNPC npc;

    public GameObject shell1;
    public GameObject shell2;
    public GameObject shell3;


    public GameObject caveQuest;
    public GameObject TunaOutside;
    public GameObject tunaInside;

    public void Starting()
    {
        shell1.SetActive(false);
        shell2.SetActive(false);
        shell3.SetActive(false);
        caveQuest.SetActive(true);
        TunaOutside.SetActive(false);
        tunaInside.SetActive(true);
        npc.GetComponent<QuestNPC>().QuestComplete();
    }
}
