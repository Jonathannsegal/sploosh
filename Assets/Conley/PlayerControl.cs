 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool isGrounded;
    //public bool isIdel;

    public float speed;
    public float wSpeed = 0.05f;
    private float rSpeed = 0.1f;
    private float wSpeedmax = 0.05f;

    public float rotSpeed = 3.0f;
    public float jumpHeight = 3.0f;

    Rigidbody rd;
    CapsuleCollider colSize;


    // Start is called before the first frame update
    void Start()
    {
        rd =      GetComponent<Rigidbody>();
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
            isGrounded = false;
        }



        if ( Input.GetKey(KeyCode.LeftShift) )
        {
            speed = rSpeed;
            //Running Controlls
        } else
        {
            speed = wSpeed;
            //Running Controlls

        }


    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
