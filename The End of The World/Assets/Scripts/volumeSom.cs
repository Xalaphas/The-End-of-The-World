using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeSom : MonoBehaviour
{
    [SerializeField]private AudioSource fundoMusical;
   public void volumeMusical(float value)
    {
        fundoMusical.volume = value;
    }
}
