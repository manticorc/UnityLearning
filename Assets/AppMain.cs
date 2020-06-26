using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OT.Foundation;

public class AppMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debuger.EnableLog = true;
        Debuger.Log("AppMain", "Hello Debug");
        this.Log("Hello DebugerExtension Function");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
