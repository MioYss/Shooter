using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus_add : MonoBehaviour
{
    public Mouvement_tir changement_tir_ref;
    // Start is called before the first frame update
    void Start()
    {
        changement_tir_ref = FindObjectOfType<Mouvement_tir>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            changement_tir_ref.changement_tir++;
            Destroy(gameObject);
        }

    }

}
