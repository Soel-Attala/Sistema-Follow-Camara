using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float hor;
    public float ver;
    public float speed;
    public GameObject camUno;
    public GameObject camDos;
    public float rotateSpeed;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MovimientoJugador();
        PlayerMoveMentRE();

        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleCamara();
        }
            
    }

    void MovimientoJugador()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hor, 0, ver) * speed * Time.deltaTime);
    }

    void PlayerMoveMentRE()
    {
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, ver) * speed * Time.deltaTime);

        float hor = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, hor, 0) * rotateSpeed * Time.deltaTime);
     }

    void ToggleCamara()
    {
        if (camUno.activeInHierarchy)
        {
            camUno.SetActive(false);
            camDos.SetActive(true);
        }
        else
        {
            camUno.SetActive(true);
            camDos.SetActive(false);
        }

    }
}
