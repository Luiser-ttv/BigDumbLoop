using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);
        rigidbody.velocity = movement * speed;

        if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
        {
            //Debug.Log("test");
            gameObject.GetComponent<SpriteRenderer>().flipX = true;

        }
        else if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
        {
            //Debug.Log("test");
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }

    }
}
