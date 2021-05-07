using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    //Variable modifiable dans l'inspector (vitesse, vitesse maximale, force du saut)
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpForce;

    private float diection;

    private Rigidbody2D body2D;

    private SpriteRenderer spriterenderer;


    private Controls controls;

    private void OnEnable()
    {
        controls = new Controls();
        controls.Enable();
        controls.Main.MoveLR.performed += MoveLROnPerformed;
        controls.Main.MoveLR.canceled += MoveLROnCanceled;
        controls.Main.Jump.performed += JumpOnPerformed;
    }

    //Demande si le player se déplace
    private void MoveLROnPerformed(InputAction.CallbackContext obj)
    {

    }

    //Demande si le player arrête de se déplacer
    private void MoveLROnCanceled(InputAction.CallbackContext obj)
    {

    }

    //Demande si le player saute
    private void JumpOnPerformed(InputAction.CallbackContext obj)
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
