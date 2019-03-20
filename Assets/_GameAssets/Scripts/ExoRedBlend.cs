using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExoRedBlend : MonoBehaviour
{
    float speed = 0;
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            speed += 0.05f;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            speed -= 0.05f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Shooting");
        }
        speed = Mathf.Min(1, speed);
        speed = Mathf.Max(0, speed);
        animator.SetFloat("Speed", speed);
    }
}
