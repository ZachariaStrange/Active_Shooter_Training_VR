using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class OnClickHide5 : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 1f;
    public UnityEngine.Vector3 targetPosition;
    private bool isWalking = false;
    public Button exitHide2;



    public void Start()
    {
        exitHide2.onClick.AddListener(GoToTarget);
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
        UnityEngine.Vector3 target = new UnityEngine.Vector3(9f, 0f, 5.5f);
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
}
