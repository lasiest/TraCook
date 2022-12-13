using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy_Sate : MonoBehaviour
{

    Scene scene;
    private void Awake() {
        scene = SceneManager.GetActiveScene();
        if(scene.name == "2.Sate_Bakar_Scene"){
            DontDestroyOnLoad(this.gameObject);
        }else if(scene.name == "3.Sate_Plating_Scene"){
            DontDestroyOnLoad(this.gameObject);
        }else{
            Destroy(this.gameObject);
        }
    }
}
