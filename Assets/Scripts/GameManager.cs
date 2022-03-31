using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using Unity.XR.CoreUtils;

public class GameManager : MonoBehaviour
{
    int npcsTalkedTo = 0;
    public List<GameObject> npcs = new List<GameObject>();


    public GameObject octoHurt, octoAttack, sword, BossBattleStart;

    public void PhaseOneComplete()
    {
        //npc dialogue 3
        foreach(GameObject npc in npcs)
        {
            npc.GetComponent<NPC>().QuestComplete2();
        }
    }

    public void TalkedWithNPC()
    {
        npcsTalkedTo++;
        if (npcsTalkedTo >= 3)
        {
            Stage3();
        }
    }

    public void Stage3()
    {
        octoHurt.SetActive(false);
        octoAttack.SetActive(true);
        sword.SetActive(true);
        BossBattleStart.SetActive(true);
    }
}
