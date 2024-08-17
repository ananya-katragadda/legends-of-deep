using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscode : MonoBehaviour
{
    public float movementSpeed;
    public Animator animator;//   18/03/2024
    // Start is called before the first frame update
    void Start()
    {
        //MyFunction();

    }

    // Update is called once per frame
    void Update()
    {
        // MyFunction();
        MyFunction();
        Jump();
        CameraControls();
    }
    public void MyFunction()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log("horizontal input" + horizontalInput);
        Debug.Log("vertical input" + verticalInput);
        Vector2 movementDir = new Vector2(horizontalInput, verticalInput);
        if (movementDir.magnitude <= 0)
        {
            //whenever there is no input given by the user
            animator.SetBool("isMoving", false);//   18/03/2024
            return;
        }
        //Ehenever there is an input move the player
        animator.SetBool("isMoving", true);//   18/03/2024
        transform.Translate(movementDir * movementSpeed * Time.deltaTime);
    }
    public Rigidbody2D playerRigidBody;
    public float jumpHeight;
    public float jumpSpeed;
    public bool isGrounded;
    public void Jump()
    {
        if (!isGrounded)
            return;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump Performed");
            playerRigidBody.AddForce(Vector2.up * jumpHeight * jumpSpeed);
        }
    }
    public Transform cameraT;// IDENTIFYING THE OBJECT
    public float followSpeed;
    public float distFromPlayer;
    public void CameraControls()
    {
        ///GET THE POSTION
        Vector3 playerPos = transform.position;//GEtting the POSITION
        //Vector3 targetLoc = playerPos;
        Vector3 targetLoc = Vector3.Lerp(cameraT.position, playerPos, followSpeed * Time.deltaTime);
        targetLoc.z = distFromPlayer;

        //SET THE POSITION
        cameraT.position = targetLoc;
    }
    public SpriteRenderer sprite;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            sprite.color = Color.red;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        sprite.color = Color.white;
    }
}