using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack()
    {
        ani.SetInteger("animation", 21);
    }

    public void Move()
    {
        ani.SetInteger("animation", 6);
    }

    public void Idle()
    {
        ani.SetInteger("animation", 1);
    }
}
