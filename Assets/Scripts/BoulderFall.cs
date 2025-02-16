using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderFall : MonoBehaviour
{
    public GameObject DeathScreen;
    public GameObject Joystick;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Joystick.SetActive(false);
            DeathScreen.SetActive(true);
        }
    }
}
