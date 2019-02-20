using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    public KeyCode key;
    public bool Visible = false;
    GameObject note;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Note")
        {
            KillCombo();
        }
    }

    void KillCombo()
    {
        PlayerPrefs.SetInt("Combo", 0);
        if (PlayerPrefs.GetInt("Combo") % 10 == 0)
        {
            Visible = true;
        }
    }
}
