using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGen : MonoBehaviour
{
    public int rndm;
    GameObject block;
    Vector2 left;
    Vector2 front;
    Vector2 right;
    ProceduralGen script;
    void Start()
    {
        script = GetComponentInParent<ProceduralGen>();
        block = GameObject.FindGameObjectWithTag("Player");
        left = new Vector2(transform.position.x - 1, transform.position.y);
        right = new Vector2(transform.position.x + 1, transform.position.y);
        front = new Vector2(transform.position.x, transform.position.y + 1);

        this.gameObject.transform.SetParent(block.transform);

        if (script.rndm == 1)
        {
            float rndm = Random.Range(1, 3);
            if (rndm == 1)
            {
                Instantiate(block, left, transform.rotation);
            }
            else if (rndm == 2)
            {
                Instantiate(block, front, transform.rotation);
            }

        }
        else if (script.rndm == 2)
        {
            float rndm = Random.Range(1, 3);
            if (rndm == 1)
            {
                Instantiate(block, right, transform.rotation);
            }
            else if (rndm == 2)
            {
                Instantiate(block, front, transform.rotation);
            }
        }
        else
        {

            float rndm = Random.Range(1, 4);

            if (rndm == 1)
            {
                Instantiate(block, left, transform.rotation);
            }
            else if (rndm == 2)
            {
                Instantiate(block, right, transform.rotation);
            }
            else if (rndm == 3)
            {
                Instantiate(block, front, transform.rotation);
            }


        }
    }

    
    void Update()
    {
    }
}
