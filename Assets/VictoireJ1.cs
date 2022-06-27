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
    private Vector3 a9;
    public Transform aliment10;
    private Vector3 a10;
    public Transform aliment11;
    private Vector3 a11;
    public Transform aliment12;
    private Vector3 a12;
    public Transform aliment13;
    private Vector3 a13;
    public Transform aliment14;
    public Transform aliment15;
    private Vector3 a14;
    private Vector3 a15;

    public Transform Burger;
    public Transform Salade;
    public int pointsJoueur;

    public Text text_points;

    public Text préparationPlat;
    public Text compositionPlat;

    

    




    void Start()
    {
        préparationPlat.text = "Salade";
        compositionPlat.text = "Salade,tomate,oeuf, \n bière";
        pointsJoueur = 0;

        a1 = aliment1.position;
        a2 = aliment2.position;
        a3 = aliment3.position;
        a4 = aliment4.position;
        a5 = aliment5.position;
        a6 = aliment6.position;
        a7 = aliment7.position;
        a8 = aliment8.position;
        a9 = aliment9.position;
        a10 = aliment10.position;
        a11 = aliment11.position;
        a12 = aliment12.position;
        a13 = aliment13.position;
        a14 = aliment14.position;
        a15 = aliment15.position;
    }

    // Update is called once per frame
    void Update()
    {


        if (CheckAliment(aliment1) && CheckAliment(aliment2) && CheckAliment(aliment3) && CheckAliment(aliment4) && CheckAliment(aliment5) && préparationPlat.text == "Burger au Poisson")
        {
            
            aliment1.transform.position = a1;
            aliment2.transform.position = a2;
            aliment3.transform.position = a3;
            aliment4.transform.position = a4;
            aliment5.transform.position = a5;
            pointsJoueur += 10;
            préparationPlat.text = "Burger";
            compositionPlat.text = "Steak,pain,fromage,\nmoutarde,toamte\nvin"; 
            Burger.transform.position = new Vector3(29, (float)0.1, (float)7.3);

        }

        if (CheckAliment(aliment6) && CheckAliment(aliment7) && CheckAliment(aliment8) && CheckAliment(aliment9) && préparationPlat.text == "Salade")
        {
            
            aliment6.transform.position = a6;
            aliment7.transform.position = a7;
            aliment8.transform.position = a8;
            aliment9.transform.position = a9;
            pointsJoueur += 6;
            préparationPlat.text = "Burger au Poisson";
            compositionPlat.text = "Poisson,pain,fromage,moutarde,\neau";
            Salade.transform.position = new Vector3((float)29.96, (float)0.636, (float)8.72);
        }

        if (CheckAliment(aliment10) && CheckAliment(aliment11) && CheckAliment(aliment12) && CheckAliment(aliment13) && CheckAliment(aliment14) && CheckAliment(aliment15) && préparationPlat.text == "Burger")
        {
            
            aliment10.transform.position = a10;
            aliment11.transform.position = a11;
            aliment12.transform.position = a12;
            aliment13.transform.position = a13;
            aliment14.transform.position = a14;
            aliment15.transform.position = a15;
            pointsJoueur += 12;
            préparationPlat.text = "Salade";
            compositionPlat.text = "Salade,tomate,oeuf,\nbière";
            Burger.transform.position = new Vector3(29, (float)0.1, (float)7.3);
        }
        text_points.text = "Points J1 : " + pointsJoueur;
    }

    public bool CheckAliment(Transform a)
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
