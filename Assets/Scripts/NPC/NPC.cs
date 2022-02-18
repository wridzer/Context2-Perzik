using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class NPC : MonoBehaviour
{
    protected NavMeshAgent navAgent;
    protected bool questComplete = false;

    //Dialogue Variables
    [SerializeField] protected string name;
    [SerializeField] private GameObject canvasInstance;
    [SerializeField] private List<string> dialogueLines;
    private int dialogueCounter = 0;

    private void Awake()
    {
        dialogueLines = JSONReader.GetDialogue(name);
    }

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
            canvasInstance.GetComponentInChildren<TMP_Text>().text = dialogueLines[dialogueCounter];
        }
    }

    public void OnButtonClick()
    {
        if (dialogueCounter < dialogueLines.Count - 1)
        {
            dialogueCounter++;
            canvasInstance.GetComponentInChildren<TMP_Text>().text = dialogueLines[dialogueCounter];
        }
        else
        {
            canvasInstance.SetActive(false);
            dialogueCounter = 0;
        }
    }

}