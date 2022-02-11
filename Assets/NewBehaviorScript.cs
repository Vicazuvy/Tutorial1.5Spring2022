using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip musicClipOne;

public AudioClip musicClipTwo;

public AudioSource musicSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
{
Application.Quit();
}

         if (Input.GetKeyDown(KeyCode.W))
        {
          musicSource.clip = musicClipOne;
          musicSource.Play();

         }

     if (Input.GetKeyUp(KeyCode.W))
        {
          musicSource.Stop();

         }

     if (Input.GetKeyDown(KeyCode.R))
        {
          musicSource.clip = musicClipTwo;
          musicSource.Play();
         }

     if (Input.GetKeyUp(KeyCode.R))
        {
          musicSource.Stop();

         }

     if (Input.GetKeyDown(KeyCode.L))
        {
          musicSource.loop = true;
         }

     if (Input.GetKeyUp(KeyCode.L))
        {
          musicSource.loop = false;
        }
    }
}
