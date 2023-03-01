using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int sscore = 0;
    public static int bestScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        sscore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = sscore.ToString();
            ;
    }
}
