using UnityEngine;

public class playerMovment : MonoBehaviour
{

    public Rigidbody rb;
    public Transform body;
    
    public Transform cam;
    public Animator playerAnimator;
    public AudioSource jumbSound;

    public float speedRotation;
    public float speedRun;
    public float jumpFoarce;
    


    float hor;
    float ver;
    float mouseX;
    float mouseY;
    float angle;

    Vector3 moveDirRun;
    Vector3 moveDirjump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        movment();
        rotation();

    }

    private void Inputs()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical"); 
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y"); 

    }

    private void movment()
    {

      moveDirRun = new Vector3(hor * speedRun, rb.linearVelocity.y, ver * speedRun);
       moveDirRun = body.TransformDirection(moveDirRun);
        //run
        bool isRunning = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        if (isRunning)
        {
           rb.linearVelocity = moveDirRun;


        }


       moveDirjump = new Vector3(rb.linearVelocity.x, jumpFoarce, rb.linearVelocity.z);
       moveDirjump = body.TransformDirection(moveDirjump);
        //jumb
        bool isJumping = Input.GetKeyDown(KeyCode.Space);
        if (isJumping && Mathf.Abs(rb.linearVelocity.y) < 0.01f)
        {
           rb.linearVelocity = moveDirjump;
            playerAnimator.SetBool("isJumping", true);
            jumbSound.Play();


        }

        else
        {
            playerAnimator.SetBool("isJumping", false);

        }




    

    }

    public void rotation()
    {
        body.Rotate(0, mouseX * speedRotation * Time.deltaTime, 0);
        angle -= mouseY * speedRotation * Time.deltaTime;
        angle = Mathf.Clamp(angle, 0, 60);
        cam.localRotation = Quaternion.Euler(angle, 0, 0);
    }



}


