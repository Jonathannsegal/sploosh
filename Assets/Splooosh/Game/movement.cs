using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector3 mMinScale;
    public float lifeTime = 10f;

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;


    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        BuildingDie(collision.gameObject);
    }

    void BuildingDie(GameObject obj)
    {
        obj.gameObject.transform.Translate(Vector3.down);
        Destroy(obj.gameObject, lifeTime);
        BuildingDie(obj.gameObject);
    }
}
