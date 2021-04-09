using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    [SerializeField]private  int breakableblocks;
    SceneLoader sceneLoader;
    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    public void countbreakableblocks()
    {
        breakableblocks++;
    }
    public void blockdestroyed()
    {
        breakableblocks--;
        if(breakableblocks<=0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
