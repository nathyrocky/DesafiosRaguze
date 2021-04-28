using System.Collections.Generic;
using UnityEngine;

public class shine : MonoBehaviour
{ public GameObject pokemongo;
    
     public pokemon Pikachu;
    public void brilhante()
    {
      SpriteRenderer temp=Pikachu.GetComponent<SpriteRenderer>();
        
        if(!Pikachu.getShine())
             
             {
              temp.color=new Color(0f,0f,200f,200f);
            } else{
                temp.color=new Color(200f,0f,200f,200f);
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
