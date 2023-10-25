using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_ennemies : MonoBehaviour
{

    public GameObject spawn_bonus_joueur;
    public Transform parent_ennemies;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(spawn_bonus_joueur, parent_ennemies.position, Quaternion.identity);
    }

}
