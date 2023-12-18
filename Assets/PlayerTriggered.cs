using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerTriggered : MonoBehaviour
{
    public UnityEvent PlayerEnteredEvent;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
            return;

        PlayerEnteredEvent?.Invoke();

    }
}
