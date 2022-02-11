using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Dialogue")]
public class Dialogue : ScriptableObject
{
    public string dialogueText;
    public bool HasFollowup;
}