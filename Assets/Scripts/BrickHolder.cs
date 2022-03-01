using System.Collections;
using UnityEngine;


public class BrickHolder : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        GetComponentInParent<BrickQuest>().AddedBrick(gameObject);
    }
}