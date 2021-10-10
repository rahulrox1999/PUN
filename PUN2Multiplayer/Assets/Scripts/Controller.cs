using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Controller : MonoBehaviour
{
    public Animator Anim;

    PhotonView View;


    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float jumpHeight = 1.0f;
    public float gravityValue = -9.81f;

    private void Start()
    {
        //controller = gameObject.AddComponent<CharacterController>();

        View = GetComponent<PhotonView>();
    }

    void Update()
    {


        if (View.IsMine)
        {
            groundedPlayer = controller.isGrounded;
            if (groundedPlayer && playerVelocity.y < 0)
            {
                playerVelocity.y = 0f;
                Anim.SetInteger("State", 0);
            }

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            controller.Move(move * Time.deltaTime * playerSpeed);

            if (move != Vector3.zero)
            {
                gameObject.transform.forward = move;
                Anim.SetInteger("State", 1);
            }

            // Changes the height position of the player..
            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                Anim.SetInteger("State", 2);
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }

            else
            {
                // 
            }
            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);

        }
          
    }
}
