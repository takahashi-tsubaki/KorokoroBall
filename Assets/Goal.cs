using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject ClearText;
    public GameObject NextBotton;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("GOAL!!");
        ClearText.SetActive(true);
        NextBotton.SetActive(true);
        audioSource.Play();
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
