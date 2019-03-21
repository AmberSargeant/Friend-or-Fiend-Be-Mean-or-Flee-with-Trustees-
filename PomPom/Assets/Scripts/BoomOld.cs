using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomOld : MonoBehaviour
{
    private Animator anim;
    public MainScript script;
   
   
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (script.BoomOldTrigger)
        {
            anim.SetBool("BoomOld", true);
        }
        if (script.StopScreen)
        {
            if (script.boom)
            {
                anim.SetBool("BoomOld", false);
                anim.SetBool("DeathTrigger", true);      
            }
        }
    }
}
