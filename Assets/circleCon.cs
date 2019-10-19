using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleCon : MonoBehaviour
{
    GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("Square");
        this.transform.parent = p.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("pos:"+this.transform.position);
    }
}
