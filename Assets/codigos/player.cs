using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject pokemongo;
    public Cura  pcura;
    public pokemon Pikachu;
    public revive  resurge;
    public megaevo grande;
    public shine brilho;
    public GameObject matar;
    private int bolsac;
    private int bolsam;
   private int bolsav;
    private int bolsas;
    public  int Getbolsac()
    {
        return bolsac;
    }
    public int Getbolsam()
    {
        return bolsam;
    }
     public int Getbolsav()
    {
        return bolsav;
    }
     public int Getbolsas()
    {
        return bolsas;
    }
    public void setbolsac(int x)
    {
        this.bolsac=x;
    }
    public void setbolsam(int x)
    {
        this.bolsam=x;
    }
 public void setbolsav(int x)
    {
        this.bolsav=x;
    }
     public void setbolsas(int x)
    {
        this.bolsas=x;
    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
           this.transform.position=this.transform.position+ new Vector3 (0.01f,0,0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
           this.transform.position=this.transform.position+ new Vector3 (-0.01f,0,0);
        }

        if (Input.GetKey(KeyCode.Keypad1))
        {
       if (bolsam>0)
       {
           grande.mega();
            setbolsam(0);
       } 
        }   

        if (Input.GetKey(KeyCode.Keypad2))
        {
            if(bolsav>0)
            {
             if(!Pikachu.getAlive())
             {
              resurge.fenix();
                setbolsav(0);
            }
            }
        }
        if (Input.GetKey(KeyCode.Keypad3))
        {
            if(bolsas>0)
            {
            brilho.brilhante();
            setbolsas(0);
            }
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            if(bolsac>0)
            {
            pcura.curinha();
            setbolsac(0);
        }
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            Instantiate(matar,Pikachu.gameObject.transform.position+Vector3.up*4,Quaternion.identity);
            Pikachu.dano();
        }

    }
}




