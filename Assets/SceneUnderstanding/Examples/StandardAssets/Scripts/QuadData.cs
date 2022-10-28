using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadData : MonoBehaviour
{
        public string type;
        public Vector3 position;
        public Quaternion rotation;
        public Vector3 scale;
        public QuadData(string type, Vector3 position , Quaternion rotation, Vector3 scale)
        {
            this.type = type;
            this.position = position;
            this.rotation= rotation;
            this.scale = scale;
        }
    
}
