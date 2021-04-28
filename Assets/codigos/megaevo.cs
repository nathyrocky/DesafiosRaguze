using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megaevo : MonoBehaviour
{
     public GameObject pokemongo;
    
     public pokemon Pikachu;

    public void mega()
    {

      if(!Pikachu.getMega())

         {
              pokemongo.transform.localScale=pokemongo.transform.localScale + new Vector3 (1,1,0);
            Pikachu.setMega(true);
          }
        

    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
