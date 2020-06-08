using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [HideInInspector]
    public float currentime=0f;
    float startime=200f;
    public Text countdowntext;

    // Start is called before the first frame update
    void Start()
    {
        currentime = startime;
    }

    // Update is called once per frame
    void Update()
    {
        currentime -= 1 * Time.deltaTime;
        countdowntext.text =currentime.ToString("0");

        if (currentime <= 0)
        {
            currentime = 0;
        }
    }

}
