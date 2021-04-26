using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject patternCanvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openCanvas();
            Debug.Log("collide with player");
        }
        
    }
    void openCanvas()
    {
        patternCanvas.SetActive(true);
    }
    void closeCanvas()
    {
        patternCanvas.SetActive(false);
    }
}
