using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restrictionInst : MonoBehaviour
{
    public GameObject rest;
    Vector3 left;
    Vector3 right;
    Vector3 up;
    Vector3 down;
    // Start is called before the first frame update
    void Start()
    {
        left = new Vector3(transform.position.x -1, transform.position.y + 1, transform.position.z );
        right = new Vector3(transform.position.x +1, transform.position.y + 1, transform.position.z);
        up = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z -1);
        down = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z + 1);
        Instantiate(rest, left, transform.rotation);
        Instantiate(rest, right, transform.rotation);
        Instantiate(rest, up, transform.rotation);
        Instantiate(rest, down, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
