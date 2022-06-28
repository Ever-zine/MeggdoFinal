using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
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
            if (Input.GetKeyDown(KeyCode.A))
            {
                StartCoroutine(Dashh());
                prochainCoup = Time.time + coolDown;
            }
        }


        

     
    }

    IEnumerator Dashh()
    {
        float startime = Time.time;
        while(Time.time < startime + dastime)
        {
            transform.Translate(Vector3.forward * dashspeed);

            yield return null;
        }
    }
}

public class ThirdPersonMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 6;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Transform cam;

    //Jump Stuff
    Vector3 velocity;
    public float gravity = -9.8f;
    public Transform groundCheck;
    public float groundDist;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight = 3;

    //Dash & Movement
    public Vector3 moveDir;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v).normalized;

        if (dir.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            moveDir = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        //Jump
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && dir.magnitude <= 0.05f)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
