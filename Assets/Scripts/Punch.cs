using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anima;
    public float coolDown = 5;
    public float prochainCoup = 0;
    public bool estTouche = false;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       

    }

    void OnCollisionStay(Collision col) // Si collision avec le sol 
    {
        if (col.gameObject.name == "Robot Kyle (1)" && Input.GetKey(KeyCode.V))
        {
            anima.Play("Punch"); // Lance l'annimation
            prochainCoup = Time.time + coolDown;
            estTouche = true;

        }

    }

}
