using System.Collections;
using UnityEngine;


public class BrickQuest : MonoBehaviour
{
    private int brickCount = 0;
    [SerializeField] private GameObject finalBrickHolder;
    [SerializeField] private QuestNPC npc;

    // Update is called once per frame
    void Update()
    {
        if(brickCount == 2)
        {
            finalBrickHolder.SetActive(true);
        }

        if (brickCount == 3)
        {
            npc.GetComponent<QuestNPC>().QuestComplete();
        }
    }

    public void AddedBrick(GameObject brickHolder)
    {
        brickHolder.GetComponent<MeshRenderer>().enabled = false;
        brickCount++;
    }
}