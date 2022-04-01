using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class NPC : MonoBehaviour
{
    public NavMeshAgent navAgent;
    protected bool questComplete = false;
    protected bool questComplete2 = false;
    protected bool questComplete3 = false;
    public Vector3 destination;
    public bool walk = false;

    //Dialogue Variables
    [SerializeField] protected string name;
    [SerializeField] private GameObject canvasInstance, textInstance, gameManager, questItem;
    [SerializeField] private List<string> dialogueLines;
    private int dialogueCounter = 0;

    private void Awake()
    {
            dialogueLines = JSONReader.GetDialogue(name);
    }

    protected virtual void Move() { }

    public void QuestComplete()
    {
        dialogueLines = JSONReader.GetDialogue(name + "1");
    }

    public void QuestComplete2()
    {
        dialogueLines = JSONReader.GetDialogue(name + "2");
    }

    public void QuestComplete3()
    {
        questComplete3 = true;
        dialogueLines = JSONReader.GetDialogue(name + "3");
    }

    public void Speak()
    {
        if(dialogueLines[dialogueCounter] != null)
        {
            //display dialogue
            canvasInstance.SetActive(true);
            textInstance.GetComponent<TMP_Text>().text = dialogueLines[dialogueCounter];
        }
    }

    public void OnButtonClick()
    {
        if (dialogueCounter < dialogueLines.Count - 1)
        {
            dialogueCounter++;
            textInstance.GetComponent<TMP_Text>().text = dialogueLines[dialogueCounter];
        }
        else
        {
            if (questComplete3)
            {
                Debug.Log("asdads");
                questItem.SetActive(true);
                gameManager.GetComponent<GameManager>().TalkedWithNPC();
            }
            canvasInstance.SetActive(false);
            dialogueCounter = 0;
        }
    }

}
