using UnityEditor.VisionOS;
using UnityEngine;
public static class DataBase
{
    public static Vector3 SpownPosition;
    

    public static void SaveData()
    {
        PlayerPrefs.SetFloat("SpownPositionX", SpownPosition.x);
        PlayerPrefs.SetFloat("SpownPositionY", SpownPosition.y);
        PlayerPrefs.SetFloat("SpownPositionZ", SpownPosition.z);
    }
    public static void LoadData()
    {
        SpownPosition.x = PlayerPrefs.GetFloat("SpownPositionX");
        SpownPosition.y = PlayerPrefs.GetFloat("SpownPositionY");
        SpownPosition.z = PlayerPrefs.GetFloat("SpownPositionZ");
    }
}
