using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cura : Pocao
{
    private int cura;
    public GameObject pokemongo;
    public pokemon Pikachu;
    public void setCura (int x) 
  {
        cura=x; 
  }
    public void curinha()
    {
    Pikachu.setVida(Pikachu.getVida()+3);
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
