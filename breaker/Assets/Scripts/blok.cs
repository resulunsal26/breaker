using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blok : MonoBehaviour
{
    gamestatus gamestatus;
    [SerializeField] AudioClip clip;
    level level;
    [SerializeField] private GameObject particleprefab;
    [SerializeField] private int maxhit;
    [SerializeField] private Sprite[] hitssprites;
    private int timeshit;
   
    private void Start()
    {
       
        gamestatus = FindObjectOfType<gamestatus>();
        level = Object.FindObjectOfType<level>();
        if (tag == "breakable")
        {

            level.countbreakableblocks();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        audiclipplay();
        if (tag=="breakable")
        {

            timeshit++;
            if(timeshit>=maxhit)
            {
                if(name== "breakableblok")
                {
                    score();
                    destroyedblock();
                    gamestatus.addtoscore(10);
                }
                else if(name == "ikihithitbreakableblok")
                {
                    score();
                    destroyedblock();
                    gamestatus.addtoscore(20);
                }
                else if (name == "uchitbreakableblok")
                {
                    score();
                    destroyedblock();
                    gamestatus.addtoscore(30);
                }

            }
           else
            {
              
                GetComponent<SpriteRenderer>().sprite = hitssprites[timeshit-1];
            }
        }
       

       
    }
    public void destroyedblock()
    {
     
       GameObject particle= Instantiate(particleprefab, transform.position,transform.rotation);
        Destroy(particle,1f);
        Destroy(gameObject);
    }
    private void audiclipplay()
    {
        AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
    }
    private void score()
    {

        level.blockdestroyed();
      
    }
}
