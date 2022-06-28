using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionSol : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 positionDébut;
    
    void Start()
    {
        positionDébut = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision col) // Si collision avec le sol 
    {
        if (col.gameObject.name == "Sol cuisine")
        {
            gameObject.transform.position = positionDébut;
        }
    }
}
