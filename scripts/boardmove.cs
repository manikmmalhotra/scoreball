using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class boardmove : MonoBehaviour
{
    public Transform pos1, pos2, pos3, pos4, pos5, pos6, pos7;
    public GameObject pipe;
    public GameObject pipe2;
    public GameObject pipe3;
    public GameObject pipe4;

    private bool visible = false;

    public float speed;
    public Transform startpos;
    public Transform startpos1;
    Vector3 nextpos;
    Vector3 nextpos1;
    [SerializeField]
    private scoretext sxt;
    [SerializeField]
    private timer tym;


    // Start is called before the first frame update
    void Start()
    {
        nextpos = startpos.position;
        nextpos1 = startpos1.position;


    }

    // Update is called once per frame
    void Update()
    {
        if (tym.currentime != 0)
        {

            if (sxt.score <= 5)
            {
                transform.position = pos1.position;
            }
            if (5 < sxt.score && sxt.score <= 10)
            {
                Invoke("tensec", 1f);
            }
            if (10 < sxt.score && sxt.score <= 15)
            {
                Invoke("vertic", 1f);
            }
            if (15 < sxt.score && sxt.score <= 20)
            {
               
                Invoke("horiz", 1f);
            }
            if (20 < sxt.score && sxt.score <= 30)
            {
                Invoke("cross", 1f);
            }
            if (30 < sxt.score && sxt.score <= 35)
            {
                Invoke("vertic", 1f);
                visible = true;
                pipe.SetActive(true);
            }

             if (!(30 < sxt.score && sxt.score <= 35))
                {
                    pipe.SetActive(false);

                }

            if (35 < sxt.score && sxt.score <= 40)
            {
                Invoke("horiz", 1f);
                visible = true;
                pipe2.SetActive(true);
            }

            if (!(35 < sxt.score && sxt.score <= 40))
            {
                pipe2.SetActive(false);

            }
            if (40 < sxt.score && sxt.score <= 45)
            {
                Invoke("cross", 1f);
                pipe3.SetActive(true);
                pipe4.SetActive(true);
            }
            if (!(40 < sxt.score && sxt.score <= 45))
            {
               
                pipe3.SetActive(false);
                pipe4.SetActive(false);
            }
            if(sxt.score == 45)
            {
                SceneManager.LoadScene(4);
            }



        }
        else
        {
            SceneManager.LoadScene(1);
            admanager.VideoAd();
        }
    }
    private void OnDrawGizmos()
    {
       Gizmos.DrawLine(pos3.position, pos4.position);
        Gizmos.DrawLine(pos5.position, pos6.position);
            // Gizmos.DrawLine(pos5.position, pos7.position, pos3.position, pos6.position);
    }

    private void tensec()
    {
        transform.position = pos2.position;
    }

    private void horiz()
    {

        if (transform.position == pos3.position)
        {
            nextpos = pos4.position;
        }
        if (transform.position == pos4.position)
        {
            nextpos = pos3.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);

    }
    private void vertic()
    {

        if (transform.position == pos5.position)
        {
            nextpos1 = pos6.position;
        }
        if (transform.position == pos6.position)
        {
            nextpos1 = pos5.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos1, speed * Time.deltaTime);

    }
    private void cross()
    {

        if (transform.position == pos5.position)
        {
            nextpos1 = pos7.position;
        }
        if (transform.position == pos7.position)
        {
            nextpos1 = pos3.position;
        }
        if (transform.position == pos3.position)
        {
            nextpos1 = pos6.position;
        }
        if (transform.position == pos6.position)
        {
            nextpos1 = pos5.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos1, speed * Time.deltaTime);

    }

}

