using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class OnClickRun5 : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 1f;
    public UnityEngine.Vector3 targetPosition;
    private bool isWalking = false;
    public Button exitRun3;



    public void Start()
    {
        exitRun3.onClick.AddListener(GoToTarget);
    }
    // Update is called once per frame
    public void Update()
    {
        if(isWalking)
        {
            MoveCharacter();
        }
    }

    public void GoToTarget()
    {
        UnityEngine.Vector3 target = new UnityEngine.Vector3(-3f, 0f, 8f);
        targetPosition = target;
        isWalking = true;
        animator.SetBool("move", true); //set animation to walk (aka move)
    }

    public void MoveCharacter()
    {
        transform.position = UnityEngine.Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        if(transform.position == targetPosition)
        {
            isWalking = false;
            animator.SetBool("move", false);
        }
    }

    public void StopMovement()
    {
        isWalking = false;
    }
}
