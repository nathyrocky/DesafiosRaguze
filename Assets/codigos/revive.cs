using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revive : MonoBehaviour
{ public GameObject pokemongo;
    
     public pokemon Pikachu;
     public void fenix ()
     {
           SpriteRenderer pokemonsr = pokemongo.GetComponent<SpriteRenderer>();
        pokemonsr.color = new Color(255f,0f,0f,255f);
        Pikachu.setAlive(true);
        Pikachu.setVida(2);
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
