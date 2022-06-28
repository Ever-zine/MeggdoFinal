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
        compositionPlat.text = "Salade,tomate,oeuf,\n bière";
        pointsJoueur = 0;

        a1 = new Vector3((float)3.13, (float)0.37, (float)3.67);
        a2 = new Vector3((float)7.38, (float)0.543, (float)3.81);
        a3 = new Vector3((float)9.5, (float)0.425, (float)3.6);
        a4 = new Vector3((float)6, (float)0.78, (float)11.88);
        a5 = new Vector3((float)17.886, (float)0.54, (float)3.462);
        a6 = new Vector3((float)13.99, (float)1.032, (float)10.262);
        a7 = new Vector3((float)14.01, (float)0.84, (float)13.17);
        a8 = new Vector3((float)13.71, (float)0.86, (float)16.52);
        a9 = new Vector3((float)14.8, (float)0.78, (float)3.6);
        a10 = new Vector3((float)5.32, (float)0.27, (float)3.73);
        a11 = new Vector3((float)7.38, (float)0.543, (float)3.81);
        a12 = new Vector3((float)9.5, (float)0.425, (float)3.6);
        a13 = new Vector3((float)6, (float)0.78, (float)11.88);
        a14 = new Vector3((float)14.01, (float)0.84, (float)13.17);
        a15 = new Vector3((float)21.26, (float)1.15, (float)3.57);

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
            compositionPlat.text = "Steak,pain,fromage,\nmoutarde,tomate\nvin"; 
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
        if (dist < 2.5f)
        {
            verif = true;
        }
        return verif;
    }
}
