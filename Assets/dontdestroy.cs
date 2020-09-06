using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy : MonoBehaviour
{
    GameObject[] music;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

}
