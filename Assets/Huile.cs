using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huile : MonoBehaviour
{
   

    public GameObject bottle;
    public float coolDown = 5;
    public float prochainCoup = 0;





    public void Update()

    {


        if (Time.time > prochainCoup) // si le cooldown son passe
        {
            if (Input.GetKeyDown(KeyCode.J)) // si appuis sur la touche
            {

                Instantiate(bottle, transform.position + new Vector3(0, 1, 0), transform.rotation); //cree la bouteille
                prochainCoup = Time.time + coolDown;
            }
        }










    }
}
