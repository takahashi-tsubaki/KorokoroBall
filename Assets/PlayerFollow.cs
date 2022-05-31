using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Vector3 offSet;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        offSet = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offSet;
    }
}
