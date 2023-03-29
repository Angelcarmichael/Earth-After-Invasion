using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrEnableCharater : MonoBehaviour
{
    //public GameObject character;
    public GameObject male;
    public GameObject female;

    public void MaleWhenClicked()
    {
        male.SetActive(true);
        female.SetActive(false);
    }

    public void FemaleWhenClicked()
    {
        female.SetActive(true);
        male.SetActive(false);
    }
}
