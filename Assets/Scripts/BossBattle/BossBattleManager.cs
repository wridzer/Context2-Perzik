using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossBattleManager : MonoBehaviour
{
    [SerializeField] private int stekelAmount;
    private int amountHit;

    public void StekelHit()
    {
        amountHit++;
        if (amountHit >= stekelAmount)
        {
            //bossbattle ended
            Debug.Log("You Won");
        }
    }
}