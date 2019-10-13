using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterfall : MonoBehaviour
{
    public Transform playerObject;
    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
        t.position = playerObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        t.position = playerObject.position;
    }
}
