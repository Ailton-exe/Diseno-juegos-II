using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    Animator bubble_Animator;
    GameObject bubble;
    GameObject[] bubbles;

    void Awake()
    {
        bubbles = GameObject.FindGameObjectsWithTag("Bubbles");
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        foreach (GameObject bubble in bubbles)
        {
            bubble_Animator = bubble.GetComponent<Animator>();
            bubble_Animator.SetBool("isBubbling", true);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        foreach (GameObject bubble in bubbles)
        {
            bubble_Animator = bubble.GetComponent<Animator>();
            bubble_Animator.SetBool("isBubbling", false);
        }
    }
}