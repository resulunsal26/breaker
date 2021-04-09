using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmanager : MonoBehaviour
{
    [SerializeField]
    private GameObject paddle;
    private Vector2 distancevector;
    private bool started;
    [SerializeField]
    private AudioClip[] ballsounds;
    [SerializeField] private float randomfactor;
    Rigidbody2D toprb;
    // Start is called before the first frame update
    void Start()
    {
         toprb = GetComponent<Rigidbody2D>();
        distancevector = transform.position - paddle.transform.position;
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!started)
        {
            lockballtopaddle();
        }
       
        launchonmouseclik();

    }
    private void launchonmouseclik()
    {
       if(Input.GetMouseButtonDown(0))
        {

            started = true;
           toprb.velocity = new Vector2(2f, 15f);
            
        }
    }
    private void lockballtopaddle()
    {
        Vector2 paddlepos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlepos + distancevector;
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Vector2 randomdirection = new Vector2(
        Random.Range(0f, randomfactor), Random.Range(0f, randomfactor)
        );
        if (started)
        {
            AudioClip clip = ballsounds[Random.Range(0, ballsounds.Length)];
            GetComponent<AudioSource>().PlayOneShot(clip);
            toprb.velocity += randomdirection;
        }
       
    }
}
