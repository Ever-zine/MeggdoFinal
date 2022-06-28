using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashBleu : MonoBehaviour
{
    // Start is called before the first frame update

    ThirdPersonMovement moveScript;
    public float dashspeed;
    public float dastime;
    public Animator anim;
    public float coolDown = 5;
    public float prochainCoup = 0;


    void Start()
    {
        moveScript = GetComponent<ThirdPersonMovement>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > prochainCoup) // si le cooldown son passe
        {
            //Faire un dash
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                StartCoroutine(Dashh());
               
                prochainCoup = Time.time + coolDown;
            }
        }





    }

    IEnumerator Dashh()
    {
        float startime = Time.time;
        while (Time.time < startime + dastime)
        {
            transform.Translate(Vector3.forward * dashspeed);

            yield return null;
        }
    }
}


