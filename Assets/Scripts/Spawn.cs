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
    public float time_bet_ennemi = 1f;
    public float ranom_factor = 0.5f;
    public SplineContainer spline_a_donner_au_nouveau_ne;

    private void Start()
    {
        timer = time_bet_ennemi;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            GenerateObject();
            timer = time_bet_ennemi + Random.Range(-ranom_factor, +ranom_factor);
        }

        
        if (nombre_ennemi >= 4)     
        {
          spline_a_donner_au_nouveau_ne = splines[Random.Range(0, splines.Length)];
          nombre_ennemi = 0;
        }
        

    }
    public void GenerateObject()
    {
        Chemin_ennemies chemin_ennemi = Instantiate(spawn_ennemies[Random.Range(0,spawn_ennemies.Length)].GetComponent<Chemin_ennemies>());
        chemin_ennemi.OnSummon(spline_a_donner_au_nouveau_ne);
        nombre_ennemi  ++;
    }
    
}
