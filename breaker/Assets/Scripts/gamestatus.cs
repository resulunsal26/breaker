using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamestatus : MonoBehaviour
{
    [Range(0f, 4f)][SerializeField]
    private float gamespeed = 1f;
   
    [SerializeField] private int currentscore=0;
    [SerializeField] private TextMeshProUGUI skortxt;
    // Update is called once per frame
    private void Awake()
    {
        int countofgamestatus = FindObjectsOfType<gamestatus>().Length;
        if(countofgamestatus>1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
      
    }
    private void Start()
    {
        skortxt.text = "Skor : " + currentscore.ToString();
    }
    
      
    
    void Update()
    {
        Time.timeScale = gamespeed;
        PlayerPrefs.SetInt("skora", currentscore);
    }
    public void addtoscore(int puan)
    {
        currentscore  += puan;
        skortxt.text ="Skor : "+ currentscore.ToString();
    }
    public void resetgames()
    {
        Destroy(gameObject);
    }
}
