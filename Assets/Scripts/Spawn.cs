using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class Spawn : MonoBehaviour
{
    public Transform parent;
    public GameObject ennemi;
    public int nombre_ennemi = 0;
    public GameObject[] spawn_ennemies;
    public SplineContainer[] splines;

    private float timer;
    public float timeBetEnnemi = 1f;
    public float ranomFactor = 0.5f;

    /*public void GenerateObject()
    {
        for (int i = 0; i < 3; i++)
            Instantiate(ennemi, parent.position + Vector3.right * Random.Range(0f, 15f), parent.rotation);*/

    private void Start()
    {
        timer = timeBetEnnemi;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            GenerateObject();
            timer = timeBetEnnemi + Random.Range(-ranomFactor, +ranomFactor);
        }


    }
    public void GenerateObject()
    {
        Chemin_ennemies cheminEnemi = Instantiate(spawn_ennemies[Random.Range(0,spawn_ennemies.Length)].GetComponent<Chemin_ennemies>());
        SplineContainer splineADonnerAuNouveauNe = splines[Random.Range(0, splines.Length)];
        cheminEnemi.OnSummon(splineADonnerAuNouveauNe);
    }
    
}
