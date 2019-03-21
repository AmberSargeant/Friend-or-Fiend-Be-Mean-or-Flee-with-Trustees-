using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomoOld : MonoBehaviour
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

        if (script.StopScreen)
        {
            if (script.Owner)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                anim.SetBool("DeathTrigger", true);
            }
        }
    }
}