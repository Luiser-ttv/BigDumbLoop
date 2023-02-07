using UnityEngine;

public class CharacterMovementV2 : MonoBehaviour
{
   

    public float moveSpeed = 2.0f;
    public float jumpForce = 5.0f;
    private Rigidbody rigidbodyPlayer;

    private Vector2 moveInput;
    public LayerMask whatIsGround;
    public Transform groundPoint;
    private bool isGrounded;

    public Animator animatorPlayer;

    public SpriteRenderer SRPlayer;

    private bool movingBackwards;

    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        moveInput.Normalize();

        rigidbodyPlayer.velocity = new Vector3(moveInput.x * moveSpeed, rigidbodyPlayer.velocity.y, moveInput.y * moveSpeed);

        RaycastHit hit;
        if (Physics.Raycast(groundPoint.position, Vector3.down, out hit, .3f, whatIsGround))
        {
            isGrounded = true;
            //Debug.Log("works");
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidbodyPlayer.velocity += new Vector3(0f, jumpForce, 0f);
        }
        animatorPlayer.SetBool("onGround", isGrounded);

        if (!SRPlayer.flipX && moveInput.x < 0)
        {
            SRPlayer.flipX = true;
        }
        else if (SRPlayer.flipX && moveInput.x > 0)
        {
            SRPlayer.flipX = false;
        }

        if (!movingBackwards && moveInput.y > 0)
        {
            movingBackwards = true;
        }
        else if (movingBackwards && moveInput.y < 0)
        {
            movingBackwards = false;
        }
        animatorPlayer.SetBool("movingBackwards", movingBackwards);
    }
}