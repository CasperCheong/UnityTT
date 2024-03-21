using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour {
    private InputData _inputData;
	// Use this for initialization
	void Start () {
		_inputData = GetComponent<InputData>();
        Debug.Log("Started inputData: " + _inputData);
	}
	
	// Update is called once per frame
	void Update () {
         if (_inputData._rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool Bbutton))

        // if (OVRInput.GetDown(OVRInput.RawButton.B))
        
        {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif

        }
         if (_inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool Abutton))
        // if (OVRInput.GetDown(OVRInput.RawButton.A))
        {

            SceneManager.LoadScene("game__room");

        }

    }
}
