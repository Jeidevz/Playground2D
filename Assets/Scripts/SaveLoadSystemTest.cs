using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JDevs.Playground2D;

public class SaveLoadSystemTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SaveLoadSystem.Save();
        SaveLoadSystem.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
