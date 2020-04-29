using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager_Dome2 : MonoBehaviour
{
    void Start()
    {
        //set entrance level spawnpoint
        SpawnpointManager.s_spawn[(int)SpawnpointManager.scenes.ENTRANCE] = 2;
    }
}
