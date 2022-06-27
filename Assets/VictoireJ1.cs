using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoireJ1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform aliment1;
    private Vector3 a1;
    public Transform aliment2;
    private Vector3 a2;
    public Transform aliment3;
    private Vector3 a3;
    public Transform aliment4;
    private Vector3 a4;
    public Transform aliment5;
    private Vector3 a5;

    public Transform aliment6;
    private Vector3 a6;
    public Transform aliment7;
    private Vector3 a7;
    public Transform aliment8;
    private Vector3 a8;

    public Transform aliment9;

    public int pointsJoueur;

    public Text text_points;

    public Text préparationPlat;
    public Text compositionPlat;

    

    




    void Start()
    {
        préparationPlat.text = "Salade";
        compositionPlat.text = "Poisson,pain,fromage, \n moutarde,eau";
        pointsJoueur = 0;

        a1 = aliment1.position;
        a2 = aliment2.position;
        a3 = aliment3.position;
        a4 = aliment4.position;
        a5 = aliment5.position;
        a6 = aliment6.position;
        a7 = aliment7.position;
        a8 = aliment8.position;
        


    }

    // Update is called once per frame
    void Update()
    {


        if (CheckBurger(aliment1) && CheckBurger(aliment2) && CheckBurger(aliment3) && CheckBurger(aliment4) && CheckBurger(aliment5) && préparationPlat.text == "Burger")
        {
            aliment1.transform.position = a1;
            aliment2.transform.position = a2;
            aliment3.transform.position = a3;
            aliment4.transform.position = a4;
            aliment5.transform.position = a5;
            pointsJoueur += 10;
            préparationPlat.text = "Burger";
            compositionPlat.text = "Salade,moutarde,eau";
            aliment9.transform.position = new Vector3(29, (float)0.1, (float)7.3);
        }

        text_points.text ="Points J1 : " + pointsJoueur;

        if (CheckSalade(aliment6) && CheckSalade(aliment7) && CheckSalade(aliment8) && préparationPlat.text == "Salade")
        {
            aliment6.transform.position = a6;
            aliment7.transform.position = a7;
            aliment8.transform.position = a8;
            pointsJoueur += 5;
            préparationPlat.text = "Burger";
            compositionPlat.text = "Poisson,pain,fromage, \n moutarde,eau";
            aliment9.transform.position = new Vector3(29, (float)0.1, (float)7.3);
        }
    }

    public bool CheckBurger(Transform a)
    {
        bool verif = false;
        float dist = Vector3.Distance(gameObject.transform.position, a.position);
        if (dist < 2f)
        {
            verif = true;
        }
        return verif;
    }

    public bool CheckSalade(Transform a)
    {
        bool verif = false;
        float dist = Vector3.Distance(gameObject.transform.position, a.position);
        if (dist < 2f)
        {
            verif = true;
        }
        return verif;
    }
}
