using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public Text win;
    public Text timerText;

    public GameObject buttonRejouer;
    public GameObject buttonRetour;
    public GameObject buttonQuitter;

    private float startTime;
    public VictoireJ1 J1;
    public VictoireJ2 J2;

    private float t;
    private string minutes;
    private string secondes;

    // Start is called before the first frame update
    void Start()
    {
        buttonRetour = GameObject.Find("btnMenuPrincipal");
        buttonRejouer = GameObject.Find("btnRejouer");
        buttonQuitter = GameObject.Find("btnQuitter");

        buttonRetour.SetActive(false);
        buttonRejouer.SetActive(false);
        buttonQuitter.SetActive(false);
    }

    public void Rejouer()
    {
        SceneManager.LoadScene(1);
    }

    public void RetourMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.timeSinceLevelLoad - startTime;
        minutes = ((int)t / 60).ToString();
        secondes = Math.Round((t % 60), 0).ToString();
        timerText.text = minutes + ":" + (Math.Round((t % 60), 0) < 10 ? "0" + secondes : secondes == "60" ? "59" : secondes);


        if ((int.Parse(minutes) == 3))
        {
            
            if (J1.pointsJoueur > 0)
            {
                win.text = "Le joueur 1 a gagné";
                buttonRetour.SetActive(true);
                buttonRejouer.SetActive(true);
                buttonQuitter.SetActive(true);
            }
            else if(J1.pointsJoueur == J2.pointsJoueur)
            {
                win.text = "Egalité";
                buttonRetour.SetActive(true);
                buttonRejouer.SetActive(true);
                buttonQuitter.SetActive(true);
            }
            else
            {
                win.text = "Le joueur 2 à gagné";
                buttonRetour.SetActive(true);
                buttonRejouer.SetActive(true);
                buttonQuitter.SetActive(true);
            }
        }
    }
}
