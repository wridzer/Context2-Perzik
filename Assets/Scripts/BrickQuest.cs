using System.Collections;
using UnityEngine;


public class BrickQuest : MonoBehaviour
{
    private int brickCount = 0;
    [SerializeField] private GameObject finalBrickHolder;
    [SerializeField] private QuestNPC npc;
    [SerializeField] private GameObject oldHouse, newHouse;

    public void AddedBrick(GameObject brickHolder)
    {
        brickHolder.GetComponent<MeshRenderer>().enabled = false;
        brickCount++;
        if (brickCount == 12)
        {
            npc.GetComponent<QuestNPC>().QuestComplete();
            oldHouse.SetActive(false);
            newHouse.SetActive(true);
        }
    }
    public void RemovedBrick(GameObject brickHolder)
    {
        brickHolder.GetComponent<MeshRenderer>().enabled = true;
        brickCount--;
    }
}