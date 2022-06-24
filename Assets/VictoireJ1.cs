using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoireJ1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform aliment1;
    public Transform aliment2;
    public Transform aliment3;
    public Transform aliment4;
    public Transform aliment5;

    public Transform aliment6;
    public Transform aliment7;
    public Transform aliment8;

    public int pointsJoueur;

    public Text text_points;

    public Text préparationPlat;





    void Start()
    {
        préparationPlat.text = "Salade";
        pointsJoueur = 0;

    }

    // Update is called once per frame
    void Update()
    {


        if (CheckBurger(aliment1) && CheckBurger(aliment2) && CheckBurger(aliment3) && CheckBurger(aliment4) && CheckBurger(aliment5) && préparationPlat.text == "Burger")
        {
            aliment1.transform.position = new Vector3((float)-4.112, (float)0.091, (float)-1.976908);
            aliment2.transform.position = new Vector3(1, 0, 0);
            aliment3.transform.position = new Vector3(2, 0, 0);
            aliment4.transform.position = new Vector3(3, 0, 0);
            aliment5.transform.position = new Vector3(4, 0, 0);
            pointsJoueur += 10;
            préparationPlat.text = "Salade";
        }

        text_points.text ="Points : " + pointsJoueur;

        if (CheckSalade(aliment6) && CheckSalade(aliment7) && CheckSalade(aliment8) && préparationPlat.text == "Salade")
        {
            aliment6.transform.position = new Vector3((float)-4.112, (float)0.091, (float)-1.976908);
            aliment7.transform.position = new Vector3(1, 0, 0);
            aliment8.transform.position = new Vector3(1, 0, 0);
            pointsJoueur += 5;
            préparationPlat.text = "Burger";
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
