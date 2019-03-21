using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class JumpScript : MonoBehaviour
{
    public MainScript script;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded = true;
    public AudioClip Sound;
    public AudioSource SoundSource;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SoundSource.clip = Sound;
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            if (script.NotDead)
            {
                rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
                isGrounded = false;
                SoundSource.Play();
            }
        }
        //Debug.Log(isGrounded);
    }
}