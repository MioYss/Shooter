using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement_tir : MonoBehaviour
{
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;

    public float speed = 0.4f;
    public int changement_tir = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left*speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right*speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(changement_tir == 0) 
            { 
                Instantiate(bullet, parent.position, parent.rotation);
            }

            if (changement_tir >= 1)
            {
                Instantiate(bullet, parent.position + Vector3.right*0.5f, parent.rotation);
                Instantiate(bullet, parent.position + Vector3.left*0.5f, parent.rotation);
            }
        }

        if(transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }
}
