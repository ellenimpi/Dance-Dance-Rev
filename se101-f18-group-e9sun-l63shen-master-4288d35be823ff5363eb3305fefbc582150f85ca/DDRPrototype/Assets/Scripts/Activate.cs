

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Activate : MonoBehaviour
{
    SpriteRenderer sr; 
    public KeyCode key;
    bool Active = false;
    public bool Visible = false;
   // public string Score = "0000";
    GameObject note;
    Color old;
    public bool createMode;
    public GameObject n;

    private void Awake()
    {
       sr = GetComponent<SpriteRenderer>(); 
        
    }
    // Use this for initialization
    void Start()
    {
        old = sr.color;
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Combo", 0); 
    }

    // Update is called once per frame
    void Update()
    {
        if (createMode)
        {
            if (Input.GetKeyDown(key))
            {
                Instantiate(n,transform.position, Quaternion.identity);
            }
        }
        else
        {
            if (Input.GetKeyDown(key))
            {
                StartCoroutine(Pressed());
            }
            if (Active && Input.GetKeyDown(key))
            {
                Destroy(note);
                AddScore();
               // Active = false;
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Active = true;
        if (col.gameObject.tag == "Note")
        {
            note = col.gameObject;
            //Active = true;
          //  Destroy(col.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        Active = false;
    }
    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 100);
        PlayerPrefs.SetInt("Combo", PlayerPrefs.GetInt("Combo") + 1); 

        if (PlayerPrefs.GetInt("Combo") % 10 ==0)
        {
            Visible = true; 
        }
       // GetComponent<Text>().text = Score;
    }
    IEnumerator Pressed()
    {
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.05f);
        sr.color = old; 
    }

}

