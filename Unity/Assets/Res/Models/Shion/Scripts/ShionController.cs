using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShionController : MonoBehaviour
{
    CharacterController controller;
    Vector3 movedir = Vector3.zero;

    private bool allowOperation;    
    private bool getHorizontal;

    private Animator animator;

    private bool isHop;
    private bool isInput;

    private float idleTime = 0.0f;

    private bool jumpUp;
    private bool isGrab;
    private Transform jumpTarget;
    private bool isMatchTarget;

    public AttackEffect attackEffect;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        attackEffect = GameObject.Find("Trail").GetComponent<AttackEffect>();

        reset();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            reset();
        }

        if(Input.anyKey && !Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
        {
            isInput = true;
        } else
        {
            isInput = false;
        }

        if(!isInput)
        {
            idleTime += Time.deltaTime;
            if(idleTime >= 5.5f)
            {
                changeAnimation("idleB");
                idleTime = 0;
            }
        }

        if (isGrab)
        {
            changeAnimation("grab");

            if (animator.GetCurrentAnimatorStateInfo(0).IsName("GrabCliff") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 0.9f && !animator.IsInTransition (0))
            {
                animator.applyRootMotion = true;
                controller.enabled = false;
                animator.MatchTarget (jumpTarget.position, Quaternion.identity, AvatarTarget.RightHand, new MatchTargetWeightMask (new Vector3 (1f, 1f, 1f), 0), 0, 0.08f);
                isMatchTarget = true;
            }
         
            if (isMatchTarget)
            {
                if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
                {
                    isMatchTarget = false;
                    isGrab = false;
                    animator.SetBool("idle", false);
                    controller.enabled = true;
                    jumpUp = false;
                    isHop = false;
                    animator.applyRootMotion = false;
                    isInput = false;
                }
            }
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.9f)
        {
            attackEffect.AttackEffectOff();
            animator.SetBool("attackFlag", false);
            allowOperation = true;
        }

        if (allowOperation)
        {
            if (jumpUp)
            {
                if (Input.GetKey("space"))
                {
                    if (Input.GetKey("left") || Input.GetKey("a") || Input.GetKey("right") || Input.GetKey("d"))
                    {
                        isGrab = true;
                        jumpUp = false;
                        isInput = true;
                    }
                }
            }

            if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);
            }

            if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
            }

            if (controller.isGrounded)
            {
                if (Input.GetKeyDown("z"))
                {
                    changeAnimation("attack");
                    attackEffect.AttackEffectOn();
                    allowOperation = false;
                }
                
                if (Input.GetKeyDown("space"))
                {
                    movedir.y = 7.0f;
                    changeAnimation("hopStart");
                    isHop = true;
                } else
                {
                    movedir.y -= 10f;
                }

                if (Input.GetKey("left") || Input.GetKey("a") || Input.GetKey("right") || Input.GetKey("d"))
                {
                    changeAnimation("run");
                } else
                {
                    if(!isHop)
                    {
                        changeAnimation("idle");
                    }
                }                

            } else
            {
                changeAnimation("hopAir");

                if (controller.velocity.y < 0)
                {
                    hopLand();
                }
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            controller.Move(move * Time.deltaTime * 5.0f);
        }

        movedir.y -= 20f * Time.deltaTime;

        Vector3 globaldir = transform.TransformDirection(movedir);
        controller.Move(globaldir * Time.deltaTime);

        if (controller.isGrounded)
        {
            movedir.y = 0;
        }    
    }

    /*public void JumpArea(Transform jumpTarget)
    {
        this.jumpTarget = jumpTarget;
    }*/

    public void NotJumpArea()
    {

    }

    void hopLand()
    {
        var ray = new Ray(this.transform.position, Vector3.down);
        var tolerance = 0.1f;
        
        if (Physics.Raycast(ray, tolerance))
        {
            changeAnimation("hopLand");
            isHop = false;

        }

        Debug.DrawRay(ray.origin, Vector3.down, Color.red, 2.0f);
    }

    void changeAnimation(string currentAnimation)
    {
        if (currentAnimation == "idle")
        {
            animator.SetBool("runFlag", false);
            animator.SetBool("idleFlag", true);
            animator.SetBool("hopStartFlag", false);
            animator.SetBool("hopAirFlag", false);
            animator.SetBool("hopLandFlag", false);
            animator.SetBool("grabFlag", false);
        }

        if (currentAnimation == "idleB")
        {
            animator.SetBool("idleBFlag", true);
            animator.SetBool("idleFlag", false);
        }       

        if (currentAnimation == "run")
        {
            animator.SetBool("runFlag", true);
            animator.SetBool("idleFlag", false);
            animator.SetBool("hopLandFlag", false);
            animator.SetBool("hopAirFlag", false);
            animator.SetBool("attackFlag", false);
            animator.SetBool("idleBFlag", false);
            animator.SetBool("grabFlag", false);
        }

        if (currentAnimation == "hopStart")
        {
            animator.SetBool("hopStartFlag", true);
            animator.SetBool("idleFlag", false);
            animator.SetBool("runFlag", false);
            animator.SetBool("attackFlag", false);
            animator.SetBool("idleBFlag", false);
        }

        if (currentAnimation == "hopAir")
        {
            animator.SetBool("hopAirFlag", true);
        }

        if (currentAnimation == "hopLand")
        {
            animator.SetBool("hopAirFlag", false);
            animator.SetBool("hopStartFlag", false);
            animator.SetBool("hopLandFlag", true);
        }

        if (currentAnimation == "attack")
        {
            animator.SetBool("attackFlag", true);
            animator.SetBool("idleFlag", false);
            animator.SetBool("idleBFlag", false);
        }

        if (currentAnimation == "grab")
        {
            animator.SetBool("grabFlag", true);
            animator.SetBool("idleFlag", false);
            animator.SetBool("runFlag", false);
            animator.SetBool("hopAirFlag", false);
            animator.SetBool("hopStartFlag", false);
            animator.SetBool("hopLandFlag", false);
        }

        if (currentAnimation == "blink")
        {
            animator.SetTrigger("blinkFlag");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("JumpUpObj"))
        {
            jumpUp = true;
            jumpTarget = other.transform.Find("UpPos");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("JumpUpObj"))
        {
            jumpUp = false;
        }
    }

    void reset()
    {
        allowOperation = true;
        isHop = false;
        isInput = false;
        changeAnimation("idle");

        GetComponent<CharacterController>().enabled = false;
        this.transform.position = new Vector3(0, 0, 0);
        GetComponent<CharacterController>().enabled = true;

    }
}
