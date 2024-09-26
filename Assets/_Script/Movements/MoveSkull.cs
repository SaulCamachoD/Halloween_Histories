using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MoveSkull : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private String horizontal;
    [SerializeField] private String vertical;
    private float speed = 10f;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        float x = Input.GetAxisRaw(horizontal);
        float y = Input.GetAxisRaw(vertical);
        
        transform.Translate(0, 0,- y * Time.deltaTime * speed);
        
        anim.SetFloat("Velx",x);
        anim.SetFloat("Vely",y);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            anim.SetTrigger("Attack");
        }
       if (Input.GetKeyDown(KeyCode.Space))
       {
                    anim.SetTrigger("Attack_T");
       }
    }
}
