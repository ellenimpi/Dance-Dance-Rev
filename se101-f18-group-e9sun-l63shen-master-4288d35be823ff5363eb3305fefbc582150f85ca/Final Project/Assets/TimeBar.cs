using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBar : MonoBehaviour
{
    public float maxSize;
    public float growFactor;
    public float waitTime;

    void Start()
    {
       // StartCoroutine(Scale());
    }

    void Update()
    {
        transform.localScale += new Vector3(-1F/10900F, 0, 0);//-1F/15770F (60f/s) 10620
    }

    //IEnumerator Scale()
    //{
        //float timer = 0;

        //while (true) // this could also be a condition indicating "alive or dead"
        //{
        //    // we scale all axis, so they will have the same value, 
        //    // so we can work with a float instead of comparing vectors
        //    while (maxSize > transform.localScale.x)
        //    {
        //        timer += Time.deltaTime;
        //        transform.localScale += new Vector3(1, 0, 0) * Time.deltaTime * growFactor;
        //        yield return null;
        //    }
        //    // reset the timer

        //    yield return new WaitForSeconds(waitTime);

        //    timer = 0;
        //    while (1 < transform.localScale.x)
        //    {
        //        timer += Time.deltaTime;
        //        transform.localScale -= new Vector3(1F, 0, 0) * Time.deltaTime * growFactor;
        //        yield return null;
        //    }

        //    timer = 0;
        //    yield return new WaitForSeconds(waitTime);
        //}

        ////////////////////////////

        //// Use this for initialization
        //void Start () {

        //}

        // Update is called once per frame

    //}
}