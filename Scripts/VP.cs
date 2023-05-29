using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VP : MonoBehaviour
{ public GameObject VideoScreen;
    public VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            VideoScreen.SetActive(true);
            video.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            VideoScreen.SetActive(false);
            video.Stop();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
