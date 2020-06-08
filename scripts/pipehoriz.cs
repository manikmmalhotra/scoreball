using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipehoriz : MonoBehaviour
{

    public Transform pos1, pos2;
    public float speed;
    public Transform startpos;
    Vector3 nextpos;
    [SerializeField]
    private scoretext sxt;
    [SerializeField]
    private timer tym;


    // Start is called before the first frame update
    void Start()
    {
        nextpos = startpos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (tym.currentime != 0)
        {
            if (40 < sxt.score && sxt.score <= 45)
            {
                Invoke("pipehorizz", 1f);
               
            }
        }
    }

    private void pipehorizz()
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


}
