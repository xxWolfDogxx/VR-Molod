using System;
using System.Linq;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    // ReSharper disable once StaticMemberInGenericType
    private static bool isAlreadyTriedToFound;
    private static T _Instance;

    public static T Instance
    {
        get
        {
            if (isAlreadyTriedToFound) return _Instance;
            var resources = Resources.FindObjectsOfTypeAll<T>().ToList();
            resources = resources.Where(a => a.hideFlags == HideFlags.None).ToList();
            if (resources.Count > 1) throw new Exception("There is more than one singleton on scene! " + typeof(T));
            if (resources.Count == 0) throw new Exception("There is no singleton on scene! " + typeof(T));
            _Instance = resources.FirstOrDefault();
            isAlreadyTriedToFound = true;
            return _Instance;
        }
    }
}
