using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class NPC : MonoBehaviour
{
    protected NavMeshAgent navAgent;
    protected bool questComplete = false;

    //Dialogue Variables
    [SerializeField] private GameObject canvasInstance;
    [SerializeField] private Dialogue[] dialogueLines;
    private int dialogueCounter = 0;

    protected virtual void Move() { }

    public void QuestComplete()
    {
        questComplete = true;
    }

    public void Speak()
    {
        if(dialogueLines[dialogueCounter] != null)
        {
            //display dialogue
            canvasInstance.SetActive(true);
            canvasInstance.GetComponentInChildren<TMP_Text>().text = dialogueLines[dialogueCounter].dialogueText;
        }
    }

    public void OnButtonClick()
    {
        if (dialogueLines[dialogueCounter].HasFollowup)
        {
            dialogueCounter++;
            canvasInstance.GetComponentInChildren<TMP_Text>().text = dialogueLines[dialogueCounter].dialogueText;
        }
        else
        {
            canvasInstance.SetActive(false);
            dialogueCounter = 0;
        }
    }

}