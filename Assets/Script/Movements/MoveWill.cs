using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWill : MonoBehaviour
{
    Rigidbody Rb;
    public Animator animator;
    private float _movex, _movez;
    [SerializeField] private float _speed = 10f;
    [SerializeField] private float _rotationSpeed = 720f;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _movex = Input.GetAxis("Horizontal");
        _movez = Input.GetAxis("Vertical");
        animator.SetFloat("Movz", _movez);
        animator.SetFloat("Movx", _movex);
    }

    private void FixedUpdate()
    {
        Movement();
    }

    public void Movement()
    {
        // Crear el vector de movimiento en espacio local
        Vector3 localMovement = new Vector3(_movex, 0.0f, _movez) * _speed * Time.deltaTime;

        // Convertir el vector de movimiento a espacio mundial
        Vector3 worldMovement = transform.TransformDirection(localMovement);

        // Aplicar el movimiento
        Rb.MovePosition(Rb.position + worldMovement);

        // Rotación
        if (_movex != 0 || _movez != 0)
        {
            // Calcular el ángulo objetivo basándose en el vector de entrada
            float targetAngle = Mathf.Atan2(_movex, _movez) * Mathf.Rad2Deg;

            // Crear la rotación objetivo
            Quaternion targetRotation = Quaternion.Euler(0, targetAngle + transform.eulerAngles.y, 0);

            // Rotar el personaje hacia la rotación objetivo
            Rb.rotation = Quaternion.RotateTowards(Rb.rotation, targetRotation, _rotationSpeed * Time.deltaTime);
        }
    }
}