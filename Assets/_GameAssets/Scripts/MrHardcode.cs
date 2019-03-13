using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrHardcode : MonoBehaviour
{
    float z;
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        z = Input.GetAxis("Vertical");
        if (z > 0)
        {
            animator.SetBool("Walking", true);
        } else
        {
            animator.SetBool("Walking", false);
        }

    }
}
