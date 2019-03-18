using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrHardcode : MonoBehaviour
{
    public enum State { Idle, Walking, Running, Jumping }
    public State estado = State.Idle;
    float x;
    float z;
    Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        z = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        switch (estado)
        {
            case State.Idle:
                ManageIdle();
                break;
            case State.Walking:
                ManageWalking();
                break;
            case State.Running:
                ManageRunning();
                break;
        }
        Rotate();
    }

    private void ManageRunning()
    {
        if (z <= 0)
        {
            StopMotion();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            StopRunning();
        }
    }

    private void ManageWalking()
    {
        if (z <= 0)
        {
            StopMotion();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartRunning();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartJumping();
        }
    }

    private void ManageIdle()
    {
        if (z > 0)
        {
            StartWalking();
        }
    }

    private void StopRunning()
    {
        animator.SetBool("Running", false);
        estado = State.Walking;
    }

    private void StartRunning()
    {
        animator.SetBool("Running", true);
        estado = State.Running;
    }

    private void StopMotion()
    {
        animator.SetBool("Running", false);
        animator.SetBool("Walking", false);
        estado = State.Idle;
    }

    private void StartWalking()
    {
        animator.SetBool("Walking", true);
        estado = State.Walking;
    }

    private void StartJumping()
    {
        animator.SetTrigger("Jumping");
    }

    private void Rotate()
    {
        transform.Rotate(new Vector3(0, x, 0));
    }
}
