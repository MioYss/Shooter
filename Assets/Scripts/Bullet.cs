using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed;
    public Score score_ref;
    public Spawn nombre_ennemi_ref;

    public GameObject explosion;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;

        score_ref = FindObjectOfType<Score>();
        nombre_ennemi_ref = FindObjectOfType<Spawn>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        nombre_ennemi_ref.nombre_ennemi--;
        score_ref.score_joueur++;
        */

        if (collision.gameObject.tag == "ennemi")
        {            
            Spawn spawn= FindObjectOfType<Spawn>();
            spawn.nombre_ennemi--;

            Instantiate(explosion, parent.position +Vector3.right * 0.5f, parent.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }


    }

}
