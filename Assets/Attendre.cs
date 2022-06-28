using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attendre : MonoBehaviour
{

    public int nbSec = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("attend");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator attend()
    {
        yield return new WaitForSeconds(nbSec);
        Destroy(gameObject);
    }
}
