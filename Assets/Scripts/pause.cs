using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{

   public void pauseGame()
    {
        Time.timeScale = 0; 
    }
   public void nopause()
    {
        Time.timeScale = 1;
    }
}
