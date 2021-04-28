using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokestop : MonoBehaviour
{ public player playergo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKey(KeyCode.Keypad5))
    {
      playergo.setbolsam(1);
      playergo.setbolsas(1);
      playergo.setbolsav(1);
      playergo.setbolsac(1);
     
    }
    }
}
