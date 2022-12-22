using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switcher : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
     
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
           (image1.sprite, image2.sprite, image3.sprite, image4.sprite) = (image4.sprite, image1.sprite, image2.sprite, image3.sprite);
        }
    }
}
