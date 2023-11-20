using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class Chemin_ennemies : MonoBehaviour

{

    public Transform parent;
    public GameObject ennemie;
    public SplineContainer mon_chemin;
    public SplineAnimate spa;

    // Start is called before the first frame update
    void Awake()
    {
        mon_chemin = FindAnyObjectByType<SplineContainer>();
        spa.Container = mon_chemin;
        spa.Play();
    }

}
