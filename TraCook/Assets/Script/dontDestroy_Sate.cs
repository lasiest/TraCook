using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy_Sate : MonoBehaviour
{
    Scene scene;
    private void Update() {
        scene = SceneManager.GetActiveScene();
        if(scene.name == "3.Sate_Bakar_Scene"){
            DontDestroyOnLoad(gameObject);
        }
        else if(scene.name == "4.Sate_Plating_Scene"){
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
}
