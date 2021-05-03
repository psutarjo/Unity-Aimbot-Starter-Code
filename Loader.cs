using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityAimbot
{
    public class Loader
    {
        // In order for the injection to work, functions/game objects need to be declared static void
        public static GameObject load_object;
        
        // This method will be executed upon injection
        public static void Load()
        {
            // Create new game object in our scene
            load_object = new GameObject();
            // Attach our aimbot script named Main
            load_object.AddComponent<Main>();
            // Tell Unity not to destroy the object when loading a new scene
            UnityEngine.Object.DontDestroyOnLoad(load_object);

        }
        
        // This method will be executed upon ejection
        public static void Unload()
        {
            // Call destructor on game object
            GameObject.Destroy(load_object);
        }
    }
}