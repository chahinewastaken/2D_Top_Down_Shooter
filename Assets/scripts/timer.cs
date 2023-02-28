using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
  float timer1;
  public Text timerText;

    // Update is called once per frame
    void Update()
    {
        timer1 += Time.deltaTime;
        timerText.text=Mathf.Floor(timer1).ToString();
    }
}
