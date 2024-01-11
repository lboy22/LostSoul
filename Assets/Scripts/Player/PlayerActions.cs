using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    //Use this to check whether the player can do any actions (moving, jumping or creating bridges).
    // This is so the player doesn't do any of these while the game is in pause state.
    // [SerializeField] static bool isPause = false;
    [SerializeField] int moveSpeed = 5;
    [SerializeField] Rigidbody2D playerBody;
    [SerializeField] PlayerControls playerControls;
    public GameObject playerObject;
    int yValue;

    private InputAction move;
    Vector2 moveDirection = Vector2.zero;
    [SerializeField] int jumpForce = 3;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
        if(Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.UpArrow)) {
            yValue = 1;
        }
        else if(Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.DownArrow)) {
            yValue = -1;
        }
        if(Input.GetKeyUp("w") || Input.GetKeyUp(KeyCode.UpArrow)) {
            yValue = 0;
        }
        if(Input.GetKeyUp("s") || Input.GetKeyUp(KeyCode.DownArrow)) {
            yValue = 0;
        }
        
        //if (playerControls.Player.Jump.triggered) 
        //{
        //    OnJump();
       // }
        
    }

    //private void OnJump()
    //{
     //   Vector2 currentVelocity = playerBody.velocity;
       // currentVelocity.y = jumpForce;
    //    playerBody.velocity = currentVelocity;

      //  Debug.Log("Jumping: " + jumpForce + " Velocity: " + playerBody.velocity);
   // }


    private void FixedUpdate()
    {
        if(playerObject.transform.position.x > PlayerPrefs.GetInt("bridgeLeft") && playerObject.transform.position.x < PlayerPrefs.GetInt("bridgeRight") && playerObject.transform.position.y >= PlayerPrefs.GetInt("bridgeBottom") && playerObject.transform.position.y <= PlayerPrefs.GetInt("bridgeTop")) {
            playerBody.velocity = new Vector2(moveDirection.x * moveSpeed, yValue * moveSpeed);
        }
        else {
            playerBody.velocity = new Vector2(moveDirection.x * moveSpeed, 0);
        }
    }

    
}
