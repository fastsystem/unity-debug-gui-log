using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugGuiTest : MonoBehaviour
{
    DebugGui debugGui;

    void Start()
    {
        debugGui = FindObjectOfType<DebugGui>();
    }

    void Update()
    {
        debugGui.Log("Info");
        debugGui.LogWarning("Warning");
        debugGui.LogError("Error");
    }
}
