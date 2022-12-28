using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comparison : MonoBehaviour
{
    [SerializeField] public Text text_1, answer;
    [SerializeField] public InputField input_Value_1, input_Value_2;

    public void Start()
    {

    }

    public void onPress()
    {
        if (input_Value_1.text == "" || input_Value_2.text == "")
        {
            text_1.text = "Заполните оба поля!";
        } 
        else if (input_Value_1.text != "" && input_Value_2.text != "")
        {
            if (Convert.ToDouble(input_Value_1.text) > Convert.ToDouble(input_Value_2.text))
            {
               answer.text = "Число " + input_Value_1.text + " больше чем " + input_Value_2.text;
            } 
            else if (Convert.ToDouble(input_Value_1.text) < Convert.ToDouble(input_Value_2.text))
            {
                answer.text = "Число " + input_Value_1.text + " меньше чем " + input_Value_2.text;
            }
            else if (Convert.ToDouble(input_Value_1.text) == Convert.ToDouble(input_Value_2.text))
            {
                answer.text = "Числа " + input_Value_1.text + " и " + input_Value_2.text + " равны!";
            }
        }
    }   
}
