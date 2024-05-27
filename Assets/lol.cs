using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lol : MonoBehaviour
{
    public InputField contraseña;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void contras()
    {
        if(contraseña.text == "borja")
        {
            Debug.Log("acces granted");

        }
        else
        {
            Debug.Log("acces denied");
        }
    }
}
