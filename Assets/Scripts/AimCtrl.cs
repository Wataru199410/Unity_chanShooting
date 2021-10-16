using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(delete),2.0f);
    }

    private void delete(){
        Destroy(gameObject);
    } 
}
