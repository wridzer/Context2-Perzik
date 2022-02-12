using System.Collections;
using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GetComponentInParent<NPC>().Speak();
    }
}