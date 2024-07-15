using UnityEngine;

public class FleshOnOf : MonoBehaviour
{
    private bool Active;
    private AndroidJavaObject camera1;
    void FL_Start()
    {
        AndroidJavaClass cameraClass = new AndroidJavaClass("android.hardware.Camera");
        WebCamDevice[] devices = WebCamTexture.devices;

        int camID = 0;
        camera1 = cameraClass.CallStatic<AndroidJavaObject>("open", camID);

        if (camera1 != null)
        {
            AndroidJavaObject cameraParameters = camera1.Call<AndroidJavaObject>("getParameters");
            cameraParameters.Call("setFlashMode", "torch");
            camera1.Call("setParameters", cameraParameters);
            Active = true;
        }
        else
        {
            Debug.LogError("[CameraParametersAndroid] Camera not available");
        }

    }

    void OnDestroy()
    {
        FL_Stop();
    }

    void FL_Stop()
    {

        if (camera1 != null)
        {
            camera1.Call("stopPreview");
            camera1.Call("release");
            Active = false;
        }
        else
        {
            Debug.LogError("[CameraParametersAndroid] Camera not available");
        }

    }

    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width * 0.1f, Screen.height * 0.1f, Screen.width * 0.3f, Screen.height * 0.1f));
        if (!Active)
        {
            if (GUILayout.Button("ENABLE FLASHLIGHT"))
                FL_Start();
        }
        else
        {
            if (GUILayout.Button("DISABLE FLASHLIGHT"))
                FL_Stop();
        }
        GUILayout.EndArea();
    }

}