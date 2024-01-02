//https://unity.com/how-to/naming-and-code-style-tips-c-scripting-unity#classes-and-interfaces
#region /// Using ///
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
#endregion

// EXAMPLE: Namespace formatting
namespace ExampleNameSpace 
{
    // EXAMPLE: Class formatting
    public class ExampleClass : MonoBehaviour
    {
        #region /// Class Fields ///
        //EXAMPLE: Field formatting
        public int PublicField;
        public static int MyStaticField;
        public const var PUBLIC_VAR;

        private int _packagePrivate;
        private int _myPrivate;
        private static int _myStaticPrivate;
        private const var PRIVATE_VAR;
        
        protected int _myProtected;
        #endregion

        #region /// Methods ///
        // EXAMPLE: Methods start with a verb.
        public void SetInitialPosition(float x, float y, float z)
        {
            transform.position = new Vector3(x, y, z);
        }

        // EXAMPLE: Methods ask a question when they return bool.
        public bool IsNewPosition(Vector3 currentPosition)
        {
            return (transform.position == currentPosition );
        }
        #endregion

    #region /// Events and Actions ///
        // EXAMPLE: Events 
        
        // using System.Action delegate
        
        public event Action OpeningDoor;    // event before
        public event Action DoorOpened;     // event after
        
        public event Action<int> PointsScored;
        public event Action<CustomEventArgs> ThingHappened;

        // raises the Event if you have subscribers
        public void OnDoorOpened()
        {
            DoorOpened?.Invoke();
        }

        public void OnPointsScored(int points)
        {
            PointsScored?.Invoke(points);
        }

        // define an EventArgs if needed
        // EXAMPLE: Read-only, custom struct used to pass an ID and Color
        public struct CustomEventArgs
        {
            public int ObjectID { get; }
            public Color Color { get; }

            public CustomEventArgs(int objectId, Color color)
            {
                this.ObjectID = objectId;
                this.Color = color;
            }
        }
    #endregion

    }
}

#region /// Interfaces ///
// EXAMPLE: Interfaces
public interface IKillable
{
    void Kill();
}

public interface IDamageable<T>
{
    void Damage(T damageTaken);
}
#endregion
