 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool isGrounded;
    //public bool isIdel;

    private float speed;
    private float wSpeed = 0.05f;
    private float rSpeed = 0.1f;
    private float wSpeedmax = 0.05f;

    public float rotSpeed = 3.0f;
    public float jumpHeight = 3.0f;

    Rigidbody rd;
    Animator anim;
    CapsuleCollider colSize;


    // Start is called before the first frame update
    void Start()
    {
        rd =      GetComponent<Rigidbody>();
        anim =    GetComponent<Animator>();
        colSize = GetComponent<CapsuleCollider>();
        isGrounded = true;

    }

    // Update is called once per frame
    void Update()
    {
        var z = Input.GetAxis("Vertical") * speed;
        var y = Input.GetAxis("Horizontal") * rotSpeed;

        transform.Translate(0, 0, z);
        transform.Rotate(0, y, 0);

        if ( Input.GetKey(KeyCode.Space) && isGrounded == true )
        {
            rd.AddForce(0, jumpHeight, 0);
            anim.SetTrigger("isJumping");
            isGrounded = false;
        }



        if ( Input.GetKey(KeyCode.LeftShift) )
        {
            speed = rSpeed;
            //Running Controlls

            if ( Input.GetKey(KeyCode.W) )
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isIdel", false);
                anim.SetBool("isRunning", true);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isIdel", false);
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isIdel", true);
                anim.SetBool("isRunning", false);

            }
        } else
        {
            speed = wSpeed;
            //Running Controlls

            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isIdel", false);
                anim.SetBool("isRunning", true);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isIdel", false);
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isIdel", true);
                anim.SetBool("isRunning", false);

            }

        }


    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
