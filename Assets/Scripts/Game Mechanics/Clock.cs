using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Text[] gameTime;

    float  year, month, day;

    public static bool startTime = true;

    public void Update()
    {   
        if(startTime == true)
        {
            day += Time.deltaTime;
            gameTime[0].text = day.ToString("F0");
        }
    
        if(day >= 21 && startTime == true)
        {
            month ++;
            month += Time.deltaTime;
            gameTime[1].text = month.ToString("F0");
            day = 1;
        }
        if(month >= 12 && startTime == true)
        {
            year ++;
            year += Time.deltaTime;
            gameTime[2].text = year.ToString("F0");
            month = 1;
        }
    }

}
