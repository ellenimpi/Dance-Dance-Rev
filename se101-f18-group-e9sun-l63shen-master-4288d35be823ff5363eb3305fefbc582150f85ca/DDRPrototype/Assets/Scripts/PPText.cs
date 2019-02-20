using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PPText : MonoBehaviour {
    public string Name;


    void Update () {
        GetComponent<Text>().text = PlayerPrefs.GetInt(Name) + "";
        
    
    }
}
