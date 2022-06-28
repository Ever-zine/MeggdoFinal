using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBottle : MonoBehaviour
{


    public GameObject flaque;

  
    private float startTime;
    public float secondes;

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public float timeRemaining = 10; // Temps restant avant le despawn de la flaque
    void Update()
    {
    
    }




        void OnCollisionStay(Collision col) // Si collision avec le sol 
    { 
        if (col.gameObject.name == "Sol cuisine")
        {
       
            Destroy(gameObject); // detruit la bouteille 
            Instantiate(flaque, transform.position , transform.rotation); // cree la flaque
        }

    }

    


}





