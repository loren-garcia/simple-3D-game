using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPC : MonoBehaviour  {

    private Rigidbody rbd;
    public float velocidade = 5;
    public float velRot = 100;
    private Quaternion rotOriginal;
    private float rotMouseX = 0;
    int rotTecladoX = 0;
    
    void Start() {

        Cursor.visible = false;
        
        rbd = GetComponent<Rigidbody>();
        rotOriginal = transform.localRotation;
    }

    void Update() {

        //MOVIMENTO
        float moveFrente = Input.GetAxis("Vertical");
        float moveLado = Input.GetAxis("Horizontal");

        Vector3 vel = transform.TransformDirection(new Vector3(moveLado * velocidade, rbd.velocity.y, moveFrente * velocidade));
        rbd.velocity = vel;

        //ROTAÇÃO MOUSE
        rotMouseX += Input.GetAxis("Mouse X");

        
        if (Input.GetKey(KeyCode.Q))
            rotTecladoX -= 1;
        else if (Input.GetKey(KeyCode.E))
            rotTecladoX += 1;

        Quaternion lado = Quaternion.AngleAxis(rotMouseX + rotTecladoX, Vector3.up);
        
        transform.localRotation = rotOriginal * lado;
    }
}
