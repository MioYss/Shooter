using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour

{
    public TextMeshProUGUI texte_score;
    public int score_joueur;



    private void Update()
    {
        texte_score.text = "" + score_joueur;
    }

}
