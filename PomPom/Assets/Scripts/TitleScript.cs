using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    private float speed = 0.1f;
    public Transform target1;
    public Transform target2;
    private SpriteRenderer spriteR;


    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(target1.position, target2.position, time);
       if(transform.localPosition.x >= 550)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }else if(transform.localPosition.x <= -550 )
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        
        
      
    }
}