#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

/// <summary>This is the base class for all &quot;Part&quot; handles in Efl.Ui widgets.
/// Since objects of this type are returned by <see cref="Efl.IPart.GetPart"/>, their lifetime is limited to exactly one function call only. Each widget class should expose more specific types for their API-defined parts.</summary>
[Efl.Ui.WidgetPart.NativeMethods]
public class WidgetPart : Efl.Object, Efl.Eo.IWrapper
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(WidgetPart))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
        efl_ui_widget_part_class_get();
    /// <summary>Initializes a new instance of the <see cref="WidgetPart"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public WidgetPart(Efl.Object parent= null
            ) : base(efl_ui_widget_part_class_get(), typeof(WidgetPart), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="WidgetPart"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected WidgetPart(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="WidgetPart"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected WidgetPart(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
    }

    /// <summary>Verifies if the given object is equal to this one.</summary>
    /// <param name="instance">The object to compare to.</param>
    /// <returns>True if both objects point to the same native object.</returns>
    public override bool Equals(object instance)
    {
        var other = instance as Efl.Object;
        if (other == null)
        {
            return false;
        }
        return this.NativeHandle == other.NativeHandle;
    }

    /// <summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    /// <returns>The value of the pointer, to be used as the hash code of this object.</returns>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }

    /// <summary>Turns the native pointer into a string representation.</summary>
    /// <returns>A string with the type and the native pointer for this object.</returns>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }

    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.WidgetPart.efl_ui_widget_part_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Object.NativeMethods
    {
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.WidgetPart.efl_ui_widget_part_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

