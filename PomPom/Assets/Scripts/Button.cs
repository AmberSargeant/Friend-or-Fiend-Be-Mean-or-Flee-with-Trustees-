using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public JumpScript script;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.isGrounded)
        {

            anim.SetBool("Pressed", true);
        }
        else
        {
            anim.SetBool("Pressed", false);


        }
    }
}
