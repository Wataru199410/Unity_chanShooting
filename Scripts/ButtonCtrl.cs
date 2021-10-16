using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonCtrl : MonoBehaviour
{
        public void continueCtrl(){
            SceneManager.LoadScene("Main");
        }

        public void EndCtrl(){
            SceneManager.LoadScene("Title");
        }
}



