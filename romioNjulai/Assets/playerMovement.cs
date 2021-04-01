using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;

public class playerMovement : MonoBehaviour
{
    public string playerName = "Romeo";

    //Reference to our diagUI script for quick access
    public VIDEUIManager1 diagUI;

    //Stored current VA when inside a trigger
    public VIDE_Assign inTrigger;

    public CapsuleCollider coll;
    public CharacterController controller;

    private Vector3 dir;
    public float speed = 8f;
    public float gravity = 28f;
    private KeyCode lastKeyPressed;

    public float zBack = 1.25f;
    public float zFront = -1.25f;

    public float lerpSpeed;
    float lerpValue = 0f;

    public Sprite standardSprite;
    private Animator walkAnim;
    private SpriteRenderer spriteR;

    private bool moving;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        coll = GetComponent<CapsuleCollider>();
        walkAnim = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();

        lastKeyPressed = KeyCode.S;
    }

    void Update()
    {
        if (!VD.isActive)
        {
            float hInput = Input.GetAxis("Horizontal");
            dir.x = hInput * speed;

            if (hInput != 0f || moving)
            {
                walkAnim.enabled = true;
            } else
            {
                walkAnim.enabled = false;
                spriteR.sprite = standardSprite;
            }

            if (hInput < 0)
            {
                spriteR.flipX = true;
            }
            else if (hInput > 0)
            {
                spriteR.flipX = false;
            }

            if (Grounded())
            {
                dir.y = 0f;
            }
            else if (!Grounded())
            {
                dir.y -= gravity * Time.deltaTime;
            }

            controller.Move(dir * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.W) && lastKeyPressed != KeyCode.W && !moving)
            {
                lastKeyPressed = KeyCode.W;
                moving = true;

                //MoveLayer(Vector3.forward, KeyCode.W);
            }

            if (Input.GetKeyDown(KeyCode.S) && lastKeyPressed != KeyCode.S && !moving)
            {
                lastKeyPressed = KeyCode.S;
                moving = true;

                //MoveLayer(Vector3.back, KeyCode.S);
            }

            if (moving && lastKeyPressed == KeyCode.W)
            {
                Vector3 p1 = transform.position + controller.center + Vector3.up * -controller.height * 0.5F;
                Vector3 p2 = p1 + Vector3.up * controller.height;

                if (!Physics.CapsuleCast(p1, p2, controller.radius, Vector3.forward, 2f))
                {
                    Vector3 newPos = new Vector3(transform.position.x, transform.position.y, zBack);

                    if (lerpValue < 1)
                    {
                        lerpValue += lerpSpeed * Time.deltaTime;
                        transform.position = Vector3.MoveTowards(transform.position, newPos, lerpValue);
                    }
                    if (lerpValue >= 1)
                    {
                        moving = false;
                        lerpValue = 0f;
                    }
                }
            }

            if (moving && lastKeyPressed == KeyCode.S)
            {
                Vector3 p1 = transform.position + controller.center + Vector3.up * -controller.height * 0.5F;
                Vector3 p2 = p1 + Vector3.up * controller.height;

                if (!Physics.CapsuleCast(p1, p2, controller.radius, Vector3.back, 2f))
                {
                    Vector3 newPos = new Vector3(transform.position.x, transform.position.y, zFront);

                    if (lerpValue < 1)
                    {
                        lerpValue += lerpSpeed * Time.deltaTime;
                        transform.position = Vector3.MoveTowards(transform.position, newPos, lerpValue);
                    }
                    if (lerpValue >= 1)
                    {
                        moving = false;
                        lerpValue = 0f;
                    }
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<VIDE_Assign>() != null)
            inTrigger = other.GetComponent<VIDE_Assign>();
    }

    void OnTriggerExit()
    {
        inTrigger = null;
    }

    void TryInteract()
    {
        /* Prioritize triggers */

        if (inTrigger)
        {
            diagUI.Interact(inTrigger);
            return;
        }
    }

        bool Grounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, coll.bounds.extents.y + 0.1f);
    }

    //void MoveLayer(Vector3 direction, KeyCode pressedKey)
    //{
    //    Vector3 p1 = transform.position + controller.center + Vector3.up * -controller.height * 0.5F;
    //    Vector3 p2 = p1 + Vector3.up * controller.height;

    //    if (!Physics.CapsuleCast(p1, p2, controller.radius, direction, 3f))
    //    {
    //        controller.Move(direction * 2f);
    //        lastKeyPressed = pressedKey;
    //    }
    //}
}
