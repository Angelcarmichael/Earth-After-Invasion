using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrEnableCharater : MonoBehaviour
{
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (character.activeInHierarchy == false)
        {
            character.SetActive(true);
        }else
        {
            character.SetActive(false);
        }

    }
}
