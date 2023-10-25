using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform parent;
    public GameObject ennemi;
    public int nombre_ennemi = 0;
    
    public void GenerateObject()
    {
        for (int i = 0; i < 3; i++)
            Instantiate(ennemi, parent.position + Vector3.right * Random.Range(0f, 15f), parent.rotation);

    }
}
