using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class champignons : MonoBehaviour
{
    // Start is called before the first frame update
    void OnFire(InputValue.Bouton)
    {
        Debug.Log(Bouton.isPressed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
