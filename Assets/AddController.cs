using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddController : MonoBehaviour
{
    string addSceneName = "Scenes/test2Add"; 
    // Start is called before the first frame update
    void Start()
    {
        LightProbes.needsRetetrahedralization += LightProbes_needsRetetrahedralization;
        LightProbes.tetrahedralizationCompleted += LightProbes_tetrahedralizationCompleted;

        Debug.Log("Start load adding scene:"+addSceneName);
        SceneManager.LoadScene(addSceneName, LoadSceneMode.Additive);
    }

    private void LightProbes_tetrahedralizationCompleted()
    {
        Debug.Log("Event:tetrahedralizationCompleted");
    }

    private void LightProbes_needsRetetrahedralization()
    {
        Debug.Log("Event:needsRetetrahedralization");

        LightProbes.Tetrahedralize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        LightProbes.needsRetetrahedralization -= LightProbes_needsRetetrahedralization;
        LightProbes.tetrahedralizationCompleted -= LightProbes_tetrahedralizationCompleted;
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Unload"))
        {
            Debug.Log("Start unload adding scene:"+addSceneName);
            SceneManager.UnloadSceneAsync(addSceneName);
        }
    }
}
