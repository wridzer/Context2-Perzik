using System.Collections;
using UnityEngine;


public class BrickHolder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetComponentInParent<BrickQuest>().AddedBrick(gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        GetComponentInParent<BrickQuest>().RemovedBrick(gameObject);
    }
}