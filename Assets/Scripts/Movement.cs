using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 5;
    public float rotationSpeed = 20;
    public ParticleSystem particulas;
    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        isMoving = false;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * movementSpeed);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, Time.deltaTime * rotationSpeed * -1 , 0);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);
            isMoving = true;
        }

        if (isMoving == false)
        {
            particulas.Stop();
        }
        else if (particulas.isEmitting == false)
        {
            particulas.Play();
        }
    }
}
