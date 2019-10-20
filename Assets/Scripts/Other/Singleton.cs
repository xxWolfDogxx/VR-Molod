using System;
using System.Linq;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _Instance;

    public static T Instance
    {
        get
        {
            if (_Instance) return _Instance;
            var resources = Resources.FindObjectsOfTypeAll<T>().ToList();
            resources = resources.Where(a => a.hideFlags == HideFlags.None).ToList();
            if (resources.Count > 1) throw new Exception("There is more than one singleton on scene! " + typeof(T));
            if (resources.Count == 0) throw new Exception("There is no singleton on scene! " + typeof(T));
            _Instance = resources.FirstOrDefault();
            return _Instance;
        }
    }

    private void OnDestroy()
    {
        _Instance = null;
    }
}
