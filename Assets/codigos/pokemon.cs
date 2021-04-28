using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pokemon : MonoBehaviour
{
    private const bool V = false;
    private int vida=5;
    private bool isAlive=true;
    private bool isMega;
    private bool isShine;
    public void tiravida(int x){vida+=x; 
    }
    public  pokemon pokemongo;
      private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "matar"){tiravida(100);Destroy(other.gameObject);
        }
    }
    public void setVida (int x)
    {
        this.vida=x;
    }
    public void setAlive (bool x)
    {
        isAlive=x;
    }
    public void setMega (bool x)
    {
        isMega=x;
    }
    public void setShine (bool x)
    {
        isShine=x;
    }
   
   public int getVida ()
   {
       return vida;
   }
   
   
    public bool getAlive ()
   {
       return isAlive;
   }
   
    public bool getMega ()
   {
       return isMega;
   }
   
   
    public bool getShine ()
   {
       return isShine;
   }
   
   public void dano()
   {
       vida=vida -3; 
      
   }

   // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if (vida<=0)
       {
        isAlive=false;
       }
        if (!isAlive)
        {
        SpriteRenderer pokemonsr = pokemongo.GetComponent<SpriteRenderer>();
        pokemonsr.color = new Color(1,00,01,0f);
        }
        if (vida>5)
        {
            vida=5;
        }
    }  
}


