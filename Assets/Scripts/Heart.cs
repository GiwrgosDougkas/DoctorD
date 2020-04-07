using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Heart : MonoBehaviour
{
    public static int heartValue = 0;
    Text heart;
    // Start is called before the first frame update
    void Start()
    {
        heart= GetComponent<Text>();
        heartValue = 0;
    }

    // Update is called once per frame
    void Update()
    {

        heart.text = "x" + heartValue;
    }
}
