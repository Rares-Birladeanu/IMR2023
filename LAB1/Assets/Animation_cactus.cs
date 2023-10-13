using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_cactus : MonoBehaviour
{
    public Animator animator;
    public float attackDistance = 0.2f; // Adjust the distance as needed

    private bool isAttacking = false;

    void Update()
    {
        GameObject cactus1 = GameObject.Find("Caiet 1");
        GameObject cactus2 = GameObject.Find("Caiet 2");

        if (cactus1 != null && cactus2 != null)
        {
            float distance = Vector3.Distance(cactus1.transform.position, cactus2.transform.position);

            if (distance < attackDistance)
            {
                if (!isAttacking)
                {
                    // Start the attack animation loop
                    animator.Play("Attack");
                    isAttacking = true;
                }
            }
            else
            {
                if (isAttacking)
                {
                    // Stop the attack animation and return to idle
                    animator.Play("Idle");
                    isAttacking = false;
                }
            }
        }
        else
        {
            Debug.LogWarning("One or both cactus GameObjects not found.");
        }
    }
}
