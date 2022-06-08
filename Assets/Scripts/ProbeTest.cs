using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class ProbeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    private void OnGUI()
    {
        var lightProbes = LightmapSettings.lightProbes; 
        if (lightProbes != null)
        {
            int lineHight = 30;
            GUI.Label(new Rect(25, 25, 200, lineHight), "Total probe count:" + lightProbes.count);
            GUI.Label(new Rect(25, 25 + lineHight * 1, 200, lineHight), "Total tetra count:" + lightProbes.cellCount);
            GUI.Label(new Rect(25, 25 + lineHight * 2, 200, lineHight), "Total GroupSet count:" + lightProbes.GetGroupSetIndexes().Length);

        }
        
    }
}
