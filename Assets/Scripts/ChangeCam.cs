using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject Cam5;
    public GameObject Cam6;

    public GameObject SetBoulder;
    public GameObject SetBoulder2;
    public GameObject SetBoulder3;
    public GameObject SetBoulder4;
    public GameObject SetBoulder5;
    public GameObject SetBoulder6;
    public GameObject SetBoulder7;
    public GameObject SetBoulder8;
    public GameObject SetBoulder9;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ChangeCam")) // ating zidul invizibil pt a schimba camera
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            SetBoulder.SetActive(true);
        }
        else if (other.gameObject.CompareTag("ChangeCam2"))
            {
                Cam2.SetActive(false);
                Cam3.SetActive(true);
                SetBoulder2.SetActive(true);
                SetBoulder3.SetActive(true);
            }
        else if (other.gameObject.CompareTag("ChangeCam3"))
        {
            Cam3.SetActive(false);
            Cam4.SetActive(true);
        }
        else if (other.gameObject.CompareTag("ChangeCam4"))
        {
            Cam4.SetActive(false);
            Cam5.SetActive(true);
        }
        else if (other.gameObject.CompareTag("ChangeCam5"))
        {
            Cam5.SetActive(false);
            Cam6.SetActive(true);
            SetBoulder4.SetActive(true);
            SetBoulder5.SetActive(true);
            SetBoulder6.SetActive(true);
            SetBoulder7.SetActive(true);
            SetBoulder8.SetActive(true);
            SetBoulder9.SetActive(true);
        }
    }
}
