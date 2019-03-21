using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    private int smiley = 0;
    private int heartCount = 0;
    private int starCount = 0;
    public bool Owner = false;
    public bool boom = false;
    private bool star = false;
    public bool BoomOldTrigger = false;
    public bool StopScreen = false;
    public bool NotDead = true;
    private Animator anim;
    private IEnumerator coroutine;
    private IEnumerator deadCoroutine;
    public GameObject MomoBaby;
    public GameObject MomoStand;
    public GameObject BoomStand;
    public GameObject BoomBoom;
    public GameObject MomoYoung;
    public GameObject MomoOld;
    public GameObject Hearts;
    public GameObject Stars;
    public GameObject deadPom;
    public GameObject BlackScreen;
    public GameObject Ending1;
    public GameObject Ending2;
    public GameObject Ending3;
    public GameObject Ending4;
    public GameObject Ending5;
    public GameObject Ending6;
    public GameObject FirstAudio;
    public GameObject SecondAudio;
    public GameObject ThirdAudio;
    public AudioClip Sound;
    public AudioSource SoundSource;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        coroutine = fadeBlack(5.0f);
        deadCoroutine = fadePom(2.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hearts "+ heartCount);
        //Debug.Log("Smiles "+ smiley);
        //Debug.Log("Owner " + Owner);
       // Debug.Log("Boom " + boom);
        //Debug.Log("Stars " + Stars);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Smiley"))
        {
            other.gameObject.SetActive(false);
            smiley++;
            SoundSource.Play();
        }
        if (other.gameObject.CompareTag("Hearts"))
        {
            other.gameObject.SetActive(false);
            heartCount++;
            SoundSource.Play();
        }
        if (other.gameObject.CompareTag("Stars"))
        {
            other.gameObject.SetActive(false);
            starCount++;
            SoundSource.Play();
        }
        if (heartCount >= 7)
        {
            boom = true;
        }
        if (smiley >= 7)
        {
            Owner = true;
        }
        if (starCount >= 7)
        {
            star = true;
        }

        if (other.gameObject.CompareTag("MomoTrigger"))
        {
            if (Owner)
            {
                MomoBaby.SetActive(true);
                MomoStand.SetActive(false);

            }
        }
        if (other.gameObject.CompareTag("CityTrigger"))
        {
            Hearts.SetActive(true);
            Stars.SetActive(true);
            FirstAudio.SetActive(false);
            SecondAudio.SetActive(true);
            if (Owner)
            {
                MomoBaby.SetActive(false);
                MomoYoung.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("BoomTrigger"))
        {
            if (boom)
            {
                BoomBoom.SetActive(true);
                BoomStand.SetActive(false);
            }

        }
        if (other.gameObject.CompareTag("SnowTrigger"))
        {
            SecondAudio.SetActive(false);
            ThirdAudio.SetActive(true);
            anim.SetBool("Old", true);
            if (Owner)
            {
                MomoYoung.SetActive(false);
                MomoOld.SetActive(true);
            }
            if (boom)
            {
                BoomOldTrigger = true;
            }
        }

        if (other.gameObject.CompareTag("DeathTrigger"))
        {
           
            StopScreen = true;
            NotDead = false;
            anim.SetBool("Dead", true);
            StartCoroutine(coroutine);
            StartCoroutine(deadCoroutine);
            if (!(boom))
            {
                Ending1.SetActive(true);
            }
            else
            {
                Ending2.SetActive(true);
            }
            if (!(star))
            {
                Ending3.SetActive(true);
            }
            else
            {
                Ending4.SetActive(true);
            }
            if ((!Owner))
            {
                Ending5.SetActive(true);
            }
            else
            {
                Ending6.SetActive(true);
            }
        }

    }
    private IEnumerator fadeBlack(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        BlackScreen.SetActive(true);


    }
    private IEnumerator fadePom(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        deadPom.SetActive(true);


    }

}
