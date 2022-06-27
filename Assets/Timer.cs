using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        string secondes = (t % 60).ToString();
        timerText.text = minutes + ":" + secondes;


        if ((int.Parse(minutes) == 1))
        {
            
            if (J1.pointsJoueur > J2.pointsJoueur)
            {
                win.text = "Le joueur 1 a gagné";
            }
            else
            {
                win.text = "Le joueur 2 a gagné";
            }
        }
    }
}
