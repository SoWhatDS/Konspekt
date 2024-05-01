using System;
using UnityEngine;

internal sealed class DataStructures 
{
    [Serializable]
    internal struct SVect3
    {
        public float X;
        public float Y;
        public float Z;

        internal SVect3(float x,float y,float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static implicit operator SVect3(Vector3 value)
        {
            return new SVect3(value.x, value.y, value.z);
        }

        public static implicit operator Vector3(SVect3 value)
        {
            return new Vector3(value.X, value.Y, value.Z);
        }
    }

    [Serializable]
    internal struct SQuater
    {
        public float X;
        public float Y;
        public float Z;
        public float W;

        internal SQuater(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public static implicit operator SQuater(Quaternion value)
        {
            return new SQuater(value.x, value.y, value.z,value.w);
        }

        public static implicit operator Quaternion(SQuater value)
        {
            return new Quaternion(value.X, value.Y, value.Z,value.W);
        }
    }

    [Serializable]
    internal struct SObject
    {
        public string Name;
        public SVect3 Position;
        public SVect3 Scale;
        public SQuater Rotation;
    }
}
