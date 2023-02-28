using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loader : MonoBehaviour
{
   public void LoadLevel(string name){
    SceneManager.LoadScene(name);
   }
   public void exit(){
    Application.Quit();
   }

}
