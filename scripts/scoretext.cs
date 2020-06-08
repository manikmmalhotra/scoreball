using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;


public class scoretext : MonoBehaviour
{
    public float score;

    private bool touch = false;
    public Text scortext;
    [SerializeField]
    private timer tym;


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "scorezone" && touch)
        {
            score++;
            scortext.text = score.ToString();
            if (score == 6)
            {
                tym.currentime += 10;
            }
            if (score == 11)
            {
                tym.currentime += 10;
            }
            if (score == 16)
            {
                tym.currentime += 12;
            }
            if (score == 21)
            {
                tym.currentime += 12;
            }
            if (score == 31)
            {
                tym.currentime += 15;
            }
            if (score == 36)
            {
                tym.currentime += 20;
            }
            if (score == 41)
            {
                tym.currentime += 20;
            }
            if (score == 46)
            {
                tym.currentime += 30;
            }
        }
        if (other.gameObject.tag == "true")
        {
            touch = false;
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "touch")
        {
            touch = true;
        }
    }

}
