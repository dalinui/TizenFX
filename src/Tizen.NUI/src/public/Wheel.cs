/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

namespace Tizen.NUI
{

    /// <summary>
    /// The wheel event structure is used to store a wheel rolling, it facilitates processing of the wheel rolling and passing to other libraries like Toolkit.<br>
    /// There is a key modifier which relates to keys like alt, shift and control functions are supplied to check if they have been pressed when the wheel is being rolled.<br>
    /// We support a mouse device and there may be another custom device that support the wheel event. The device type is specified as \e type.<br>
    /// The mouse wheel event can be sent to the specific actor but the custom wheel event will be sent to the window.<br>
    /// </summary>
    public class Wheel : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal Wheel(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Wheel obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        //A Flag to check who called Dispose(). (By User or DisposeQueue)
        private bool isDisposeQueued = false;
        //A Flat to check if it is already disposed.
        protected bool disposed = false;

        ~Wheel()
        {
            if(!isDisposeQueued)
            {
                isDisposeQueued = true;
                DisposeQueue.Instance.Add(this);
            }
        }

        public void Dispose()
        {
            //Throw excpetion if Dispose() is called in separate thread.
            if (!Window.IsInstalled())
            {
                throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
            }

            if (isDisposeQueued)
            {
                Dispose(DisposeTypes.Implicit);
            }
            else
            {
                Dispose(DisposeTypes.Explicit);
                System.GC.SuppressFinalize(this);
            }
        }

        protected virtual void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if(type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Wheel(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
            disposed = true;
        }


        internal static Wheel GetWheelFromPtr(global::System.IntPtr cPtr)
        {
            Wheel ret = new Wheel(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// The type of the wheel event
        /// </summary>
        public Wheel.WheelType Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// he direction of wheel rolling (0 = default vertical wheel, 1 = horizontal wheel)
        /// </summary>
        public int Direction
        {
            get
            {
                return direction;
            }
        }

        /// <summary>
        /// Modifier keys pressed during the event (such as shift, alt and control)
        /// </summary>
        public uint Modifiers
        {
            get
            {
                return modifiers;
            }
        }

        /// <summary>
        /// The co-ordinates of the cursor relative to the top-left of the screen
        /// </summary>
        public Vector2 Point
        {
            get
            {
                return point;
            }
        }

        /// <summary>
        /// The offset of rolling (positive value means roll down or clockwise, and negative value means roll up or counter-clockwise)
        /// </summary>
        public int Z
        {
            get
            {
                return z;
            }
        }

        /// <summary>
        /// The time the wheel is being rolled
        /// </summary>
        public uint TimeStamp
        {
            get
            {
                return timeStamp;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Wheel() : this(NDalicPINVOKE.new_Wheel__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="type">The type of the wheel event</param>
        /// <param name="direction">The direction of wheel rolling (0 = default vertical wheel, 1 = horizontal wheel)</param>
        /// <param name="modifiers">Modifier keys pressed during the event (such as shift, alt and control)</param>
        /// <param name="point">The co-ordinates of the cursor relative to the top-left of the screen</param>
        /// <param name="z">The offset of rolling (positive value means roll down or clockwise, and negative value means roll up or counter-clockwise)</param>
        /// <param name="timeStamp">The time the wheel is being rolled</param>
        public Wheel(Wheel.WheelType type, int direction, uint modifiers, Vector2 point, int z, uint timeStamp) : this(NDalicPINVOKE.new_Wheel__SWIG_1((int)type, direction, modifiers, Vector2.getCPtr(point), z, timeStamp), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Checks to see if Shift key modifier has been supplied.
        /// </summary>
        /// <returns>True if shift modifier</returns>
        public bool IsShiftModifier()
        {
            bool ret = NDalicPINVOKE.Wheel_IsShiftModifier(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Checks to see if Ctrl (control) key modifier has been supplied.
        /// </summary>
        /// <returns>True if ctrl modifier</returns>
        public bool IsCtrlModifier()
        {
            bool ret = NDalicPINVOKE.Wheel_IsCtrlModifier(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Checks to see if Alt key modifier has been supplied.
        /// </summary>
        /// <returns>True if alt modifier</returns>
        public bool IsAltModifier()
        {
            bool ret = NDalicPINVOKE.Wheel_IsAltModifier(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private Wheel.WheelType type
        {
            set
            {
                NDalicPINVOKE.Wheel_type_set(swigCPtr, (int)value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                Wheel.WheelType ret = (Wheel.WheelType)NDalicPINVOKE.Wheel_type_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private int direction
        {
            set
            {
                NDalicPINVOKE.Wheel_direction_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                int ret = NDalicPINVOKE.Wheel_direction_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private uint modifiers
        {
            set
            {
                NDalicPINVOKE.Wheel_modifiers_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                uint ret = NDalicPINVOKE.Wheel_modifiers_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private Vector2 point
        {
            set
            {
                NDalicPINVOKE.Wheel_point_set(swigCPtr, Vector2.getCPtr(value));
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                global::System.IntPtr cPtr = NDalicPINVOKE.Wheel_point_get(swigCPtr);
                Vector2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector2(cPtr, false);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private int z
        {
            set
            {
                NDalicPINVOKE.Wheel_z_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                int ret = NDalicPINVOKE.Wheel_z_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        private uint timeStamp
        {
            set
            {
                NDalicPINVOKE.Wheel_timeStamp_set(swigCPtr, value);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                uint ret = NDalicPINVOKE.Wheel_timeStamp_get(swigCPtr);
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        /// <summary>
        /// The type of the wheel event
        /// </summary>
        public enum WheelType
        {
            MouseWheel,
            CustomWheel
        }

    }

}