using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tutucu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI skortext;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("skora"))
        {
            skortext.text ="Son oyunun Skoru : "+ PlayerPrefs.GetInt("skora").ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
