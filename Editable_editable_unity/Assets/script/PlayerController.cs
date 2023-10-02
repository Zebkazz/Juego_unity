using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed =8f;
    public float jumForce =12f;
    public float doublejumForce =8f;
    public float gravityScale = 5f;
    public float rotateSpeed = 5f;
    public GameObject playerModel;
    private bool canDoubleJump;

    public Animator animator;

    private Vector3 moveDirection;
    public CharacterController charController;
    public Camera playerCamera;

    private void OnCollisionEnter(Collision collision)
   {
    if(collision.gameObject.tag=="arrow")
        {
        SceneManager.LoadScene("mains"); 
        }
   }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float yStore = moveDirection.y;
        moveDirection =( transform.forward * Input.GetAxisRaw("Vertical"))+  (transform.right * Input.GetAxisRaw("Horizontal"));
        moveDirection.Normalize();
        moveDirection = moveDirection * moveSpeed;
        moveDirection.y = yStore;

        //salto
        if(Input.GetButtonDown("Jump"))
            {
                
            if(charController.isGrounded){
                canDoubleJump = true; 
                moveDirection.y = jumForce;
                }
            else{
                if(Input.GetButtonDown("Jump"))
                {
                    if(canDoubleJump)
                    {
                       moveDirection.y = doublejumForce; 
                       canDoubleJump = false; 
                    }
                }
            }
        }
        if(Input.GetKeyDown("p")){
            SceneManager.LoadScene("mains");
            }
        if(Input.GetKeyDown("u")){
            Timer.Activar = false;
		    Timer.Enemigo = false;
            SceneManager.LoadScene("nivel");
            }
        if(Input.GetKeyDown("i")){
            Timer.Activar = false;
		    Timer.Enemigo = false;
            SceneManager.LoadScene("nivel2");
            }
        
        
        moveDirection.y += Physics.gravity.y * Time.deltaTime * gravityScale;
        charController.Move(moveDirection * Time.deltaTime);

        if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            transform.rotation = Quaternion.Euler(0f, playerCamera.transform.rotation.eulerAngles.y,0f);
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x,0f,moveDirection.z));
            playerModel.transform.rotation = Quaternion.Slerp(playerModel.transform.rotation,newRotation,rotateSpeed * Time.deltaTime);
        }

        animator.SetFloat("Speed",Mathf.Abs(moveDirection.x)+ Mathf.Abs(moveDirection.z));
        animator.SetBool("Grounded", charController.isGrounded);
    
    }
}
