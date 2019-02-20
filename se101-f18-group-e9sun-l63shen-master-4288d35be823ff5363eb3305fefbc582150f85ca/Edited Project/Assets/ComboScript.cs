using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboScript : MonoBehaviour
{
    public string Combo;


    void Update()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(Combo)/10*10 + "";


    }
}
