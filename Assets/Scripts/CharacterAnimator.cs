using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 10.0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0, vertical);
        animator.SetFloat("Speed", moveDirection.magnitude * moveSpeed);

        if (moveDirection.magnitude > 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }
}