using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneload : MonoBehaviour
{
    // Start is called before the first frame update

    private float delay = 3f;
    void Start()
    {
        StartCoroutine(LoadSceneAfterDelay());
    }
    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
