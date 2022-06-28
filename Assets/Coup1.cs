using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coup1 : MonoBehaviour
{
    public float coolDown = 5;
    public float prochainCoup = 0;
    public ObjetRamassableP2 unObjet;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);

        if (Time.time > prochainCoup) // si le cooldown son passe
        {
            if (Input.GetKeyDown(KeyCode.F) && dist < 3f) // si appuis sur la touche
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                unObjet.estPorté = false;
            }
        }
    }
}
