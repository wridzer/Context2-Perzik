using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class GameManager : MonoBehaviour
{
    [SerializeField] private QuestNPC npc;
    [SerializeField] private QuestNPC npc2;
    [SerializeField] private QuestNPC npc3;
    [SerializeField] private QuestNPC npc4;


    int npcsTalkedTo = 0;

    public GameObject tunaOutside, marlinOutside;

    public GameObject octoHurt, octoIdle, sword, BossBattleStart, rocksOpen;

    public void PhaseOneComplete()
    {
        npc.GetComponent<QuestNPC>().QuestComplete3();
        npc2.GetComponent<QuestNPC>().QuestComplete3();
        npc3.GetComponent<QuestNPC>().QuestComplete3();
        npc4.GetComponent<QuestNPC>().QuestComplete3();

        tunaOutside.SetActive(true);
        marlinOutside.SetActive(true);
    }

    public void TalkedWithNPC()
    {
        npcsTalkedTo++;
        if (npcsTalkedTo >= 4)
        {
            Stage3();
        }
    }

    public void Stage3()
    {
        octoHurt.SetActive(false);
        octoIdle.SetActive(true);
        sword.SetActive(true);
        BossBattleStart.SetActive(true);
        rocksOpen.SetActive(false);
    }
}
