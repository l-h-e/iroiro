using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{

    bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag==true)
        { // Editor/マウス操作の場合は Input.GetMouseButton(0) にする  Input.touchCount > 0 &&
           // Debug.Log("aaaa");
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            var poss = new Vector3(pos.x, this.transform.position.y, pos.z);
            this.transform.position = poss;
        }
    }

    public void OnUp()
    {
        flag = false;
    }

    public void OnDown()
    {
       // Debug.Log("teusi");
        flag = true;
    }
}
