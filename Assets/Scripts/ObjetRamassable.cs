using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetRamassable : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public Transform objet;
    public float throwForce = 10;

    public ObjetRécupéré p1;
    private bool distPlayer = false;
    public bool estPorté = false;
    private bool collision = false;
    private bool collisionObjet = false;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2f)
        {
            distPlayer = true;
        }
        else
        {
            distPlayer = false;
        }
        //récupérer l'aliment

        if (distPlayer && Input.GetKey(KeyCode.Keypad1) )
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            estPorté = true;
            
            
        }

        if (estPorté)
        {
            if (collision)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                estPorté = false;
                collision = false;
                
            }
            // Jetter l'aliment
           
            //poser l'aliment
            else if (Input.GetKey(KeyCode.Keypad2))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                estPorté = false;
            }
        }


        //=====================Fonction déposer automatiquement l'aliment==========================
        
        if (dist > 2f)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            estPorté = false;
        }
       
    }

    
    public void OnTriggerEnter()
    {
        if (estPorté)
        {
            collision = true;
        }
    }
}
