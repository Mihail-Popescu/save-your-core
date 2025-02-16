using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    //
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    //
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    private float movementZ;
    //
    float TmStart;
    float TmLen = 5f;
    //
    public VariableJoystick variableJoystick;
    //
    public float jumpForce = 7;
    private bool isGround = false;
    //
    public GameObject DeathScreen;
    public GameObject Joystick;
    public GameObject scene;
    public GameObject TextObj;
    //
    public float Level2;
    //
    public Transform cam1;
    public Transform cam2;
    public Transform cam3;
    public Transform cam4;
    public Transform cam5;
    public Transform cam6;
    //
    public GameObject cam1obj;
    public GameObject cam2obj;
    public GameObject cam3obj;
    public GameObject cam4obj;
    public GameObject cam5obj;
    public GameObject cam6obj;
    //
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        winTextObject.SetActive(false);

        TmStart = Time.time;
    }

    void SetCountText()
    {
        countText.text = "Cubes: " + count.ToString();
        if (count >= 11)
        {
            winTextObject.SetActive(true);
        }
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 camF1 = cam1.forward;
        Vector3 camR1 = cam1.right;

        camF1.y = 0;
        camR1.y = 0;
        camF1 = camF1.normalized;
        camR1 = camR1.normalized;
        //
        Vector3 camF2 = cam2.forward;
        Vector3 camR2 = cam2.right;

        camF2.y = 0;
        camR2.y = 0;
        camF2 = camF2.normalized;
        camR2 = camR2.normalized;
        //
        Vector3 camF3 = cam3.forward;
        Vector3 camR3 = cam3.right;

        camF3.y = 0;
        camR3.y = 0;
        camF3 = camF3.normalized;
        camR3 = camR3.normalized;
        //
        Vector3 camF4 = cam4.forward;
        Vector3 camR4 = cam4.right;

        camF4.y = 0;
        camR4.y = 0;
        camF4 = camF4.normalized;
        camR4 = camR4.normalized;
        //
        Vector3 camF5 = cam5.forward;
        Vector3 camR5 = cam5.right;

        camF5.y = 0;
        camR5.y = 0;
        camF5 = camF5.normalized;
        camR5 = camR5.normalized;
        //
        Vector3 camF6 = cam6.forward;
        Vector3 camR6 = cam6.right;

        camF6.y = 0;
        camR6.y = 0;
        camF6 = camF6.normalized;
        camR6 = camR6.normalized;
        //

        if (cam1obj.activeSelf)
        {
            Vector3 movement = camF1 * movementY + camR1 * movementX;
            rb.AddForce(movement * speed);

            Vector3 direction = camF1 * variableJoystick.Vertical + camR1 * variableJoystick.Horizontal;
            rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        } else if (cam2obj.activeSelf)
        {
            Vector3 movement = camF2 * movementY + camR2 * movementX;
            rb.AddForce(movement * speed);

            Vector3 direction = camF2 * variableJoystick.Vertical + camR2 * variableJoystick.Horizontal;
            rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        } else if (cam3obj.activeSelf)
        {
            Vector3 movement = camF3 * movementY + camR3 * movementX;
            rb.AddForce(movement * speed);

            Vector3 direction = camF3 * variableJoystick.Vertical + camR3 * variableJoystick.Horizontal;
            rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        else if (cam4obj.activeSelf)
        {
            Vector3 movement = camF4 * movementY + camR4 * movementX;
            rb.AddForce(movement * speed);

            Vector3 direction = camF4 * variableJoystick.Vertical + camR4 * variableJoystick.Horizontal;
            rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        else if (cam5obj.activeSelf)
        {
            Vector3 movement = camF5 * movementY + camR5 * movementX;
            rb.AddForce(movement * speed);

            Vector3 direction = camF5 * variableJoystick.Vertical + camR5 * variableJoystick.Horizontal;
            rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        else if (cam6obj.activeSelf)
        {
            Vector3 movement = camF6 * movementY + camR6 * movementX;
            rb.AddForce(movement * speed);

            Vector3 direction = camF6 * variableJoystick.Vertical + camR6 * variableJoystick.Horizontal;
            rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp")) // ating pickup-urile
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }

        if (other.gameObject.CompareTag("EndIt")) // ating cubul invizibil de la sfarsit care termina nivelul
        {
            //Debug.Log("it works!");
            Level2 = 1;
            PlayerPrefs.SetFloat("level", Level2);
            Joystick.SetActive(false);
            scene.SetActive(true);
        }
        else if (other.gameObject.CompareTag("EndIt2"))
        {
            Level2 = 2;
            PlayerPrefs.SetFloat("level2", Level2);
            Joystick.SetActive(false);
            scene.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground")) // Ating pamantul
        {
            isGround = true;
        }

        if (other.gameObject.CompareTag("DeadGround")) // Ating pamantul care ma "omoara"
        {
            //Debug.Log("it works!");
            Joystick.SetActive(false);
            DeathScreen.SetActive(true);
        }

    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isGround) // Sunt pe pamant
            {
                Jump();
                isGround = false;
            }
        }

        if (Time.time > TmStart + TmLen)
        {

            TextObj.SetActive(false);
        }

    }

    public void Jump()
    {
        if (isGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGround = false;
        }
    }
}
