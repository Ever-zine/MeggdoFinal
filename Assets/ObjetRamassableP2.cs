﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetRamassableP2 : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public Transform objet;
    public float throwForce = 10;

    
    private bool distPlayer = false;
    private bool estPorté = false;
    private bool collision = false;
    private bool collisionObjet = false;


    private bool doubleObjet = false; // faire en sorte qu'on puisse prendre qu'un objet
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 1.5f)
        {
            distPlayer = true;
        }
        else
        {
            distPlayer = false;
        }
        //récupérer l'aliment

        if (distPlayer && Input.GetKey(KeyCode.Keypad1) && doubleObjet == false)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            estPorté = true;
            doubleObjet = true;
            
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
            if (Input.GetKey(KeyCode.Keypad3))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                estPorté = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                doubleObjet = false;
            }
            //poser l'aliment
            else if(Input.GetKey(KeyCode.Keypad2))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                estPorté = false;
                doubleObjet = false;
            }
            
        }


        //=====================Fonction déposer automatiquement l'aliment==========================
        if (dist > 2f)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            estPorté = false;   
            doubleObjet = false;
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