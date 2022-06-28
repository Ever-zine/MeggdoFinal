using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{

    public Text win;
    public Text timerText;

    private float startTime;
    public VictoireJ1 J1;
    public VictoireJ2 J2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string secondes = Math.Round((t % 60), 0).ToString();
        timerText.text = minutes + ":" + (Math.Round((t % 60), 0) < 10 ? "0" + secondes : secondes == "60" ? "59" : secondes);


        if ((int.Parse(minutes) == 3))
        {
            
            if (J1.pointsJoueur > 0)
            {
                win.text = "Le joueur 1 a gagné";
            }
            else if(J1.pointsJoueur == J2.pointsJoueur)
            {
                win.text = "Egalité";
            }
            else
            {
                win.text = "Le joueur 2 à gagné";
            }
        }
    }
}
