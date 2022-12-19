using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRemover : MonoBehaviour
{
    public GameObject End;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(End, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
