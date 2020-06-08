using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemove : MonoBehaviour
{
    public Transform pos1, pos2, pos3, pos4;
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
            if (30 < sxt.score && sxt.score <= 35)
            {
                Invoke("pipevertic", 1f);
            }
            if (35 < sxt.score && sxt.score <= 40)
            {
                Invoke("pipehoriz", 1f);
            }
        }
    }

    private void pipevertic()
    {

        if (transform.position == pos1.position)
        {
            nextpos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextpos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
    }
    private void pipehoriz()
    {

        if (transform.position == pos3.position)
        {
            nextpos1 = pos4.position;
        }
        if (transform.position == pos4.position)
        {
            nextpos1 = pos3.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos1, speed * Time.deltaTime);
    }

}
