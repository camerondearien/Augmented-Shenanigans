using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class hyperlink : MonoBehaviour
{

    public string link;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hyperlink script loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Application.OpenURL(link);
    }
}
