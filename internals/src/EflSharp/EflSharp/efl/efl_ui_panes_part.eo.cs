#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

/// <summary>Elementary Panes internal part class</summary>
[Efl.Ui.PanesPart.NativeMethods]
public class PanesPart : Efl.Ui.LayoutPartContent, Efl.Eo.IWrapper
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(PanesPart))
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
        efl_ui_panes_part_class_get();
    /// <summary>Initializes a new instance of the <see cref="PanesPart"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public PanesPart(Efl.Object parent= null
            ) : base(efl_ui_panes_part_class_get(), typeof(PanesPart), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="PanesPart"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected PanesPart(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="PanesPart"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected PanesPart(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
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

    /// <summary>Allows the user to set size hints to be respected and ignored combined with a minimum size. If this flag is set, the minimum size set by <see cref="Efl.Gfx.IHint.SetHintSizeMin"/> is respected forcefully.</summary>
    /// <returns>If <c>true</c> minimum size is forced</returns>
    virtual public bool GetHintMinAllow() {
         var _ret_var = Efl.Ui.PanesPart.NativeMethods.efl_ui_panes_part_hint_min_allow_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Allows the user to set size hints to be respected and ignored combined with a minimum size. If this flag is set, the minimum size set by <see cref="Efl.Gfx.IHint.SetHintSizeMin"/> is respected forcefully.</summary>
    /// <param name="allow">If <c>true</c> minimum size is forced</param>
    virtual public void SetHintMinAllow(bool allow) {
                                 Efl.Ui.PanesPart.NativeMethods.efl_ui_panes_part_hint_min_allow_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),allow);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Controls the relative minimum size of panes widget&apos;s part.
    /// If <see cref="Efl.Gfx.IHint.SetHintSizeMin"/> is also used along with <see cref="Efl.Ui.PanesPart.SetSplitRatioMin"/>, maximum value is set as minimum size to part.</summary>
    /// <returns>Value between 0.0 and 1.0 representing size proportion of first part&apos;s minimum size.</returns>
    virtual public double GetSplitRatioMin() {
         var _ret_var = Efl.Ui.PanesPart.NativeMethods.efl_ui_panes_part_split_ratio_min_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Controls the relative minimum size of panes widget&apos;s part.
    /// If <see cref="Efl.Gfx.IHint.SetHintSizeMin"/> is also used along with <see cref="Efl.Ui.PanesPart.SetSplitRatioMin"/>, maximum value is set as minimum size to part.</summary>
    /// <param name="size">Value between 0.0 and 1.0 representing size proportion of first part&apos;s minimum size.</param>
    virtual public void SetSplitRatioMin(double size) {
                                 Efl.Ui.PanesPart.NativeMethods.efl_ui_panes_part_split_ratio_min_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),size);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Allows the user to set size hints to be respected and ignored combined with a minimum size. If this flag is set, the minimum size set by <see cref="Efl.Gfx.IHint.SetHintSizeMin"/> is respected forcefully.</summary>
/// <value>If <c>true</c> minimum size is forced</value>
    public bool HintMinAllow {
        get { return GetHintMinAllow(); }
        set { SetHintMinAllow(value); }
    }
    /// <summary>Controls the relative minimum size of panes widget&apos;s part.
/// If <see cref="Efl.Gfx.IHint.SetHintSizeMin"/> is also used along with <see cref="Efl.Ui.PanesPart.SetSplitRatioMin"/>, maximum value is set as minimum size to part.</summary>
/// <value>Value between 0.0 and 1.0 representing size proportion of first part&apos;s minimum size.</value>
    public double SplitRatioMin {
        get { return GetSplitRatioMin(); }
        set { SetSplitRatioMin(value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.PanesPart.efl_ui_panes_part_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Ui.LayoutPartContent.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Elementary);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_panes_part_hint_min_allow_get_static_delegate == null)
            {
                efl_ui_panes_part_hint_min_allow_get_static_delegate = new efl_ui_panes_part_hint_min_allow_get_delegate(hint_min_allow_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHintMinAllow") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_panes_part_hint_min_allow_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_panes_part_hint_min_allow_get_static_delegate) });
            }

            if (efl_ui_panes_part_hint_min_allow_set_static_delegate == null)
            {
                efl_ui_panes_part_hint_min_allow_set_static_delegate = new efl_ui_panes_part_hint_min_allow_set_delegate(hint_min_allow_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHintMinAllow") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_panes_part_hint_min_allow_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_panes_part_hint_min_allow_set_static_delegate) });
            }

            if (efl_ui_panes_part_split_ratio_min_get_static_delegate == null)
            {
                efl_ui_panes_part_split_ratio_min_get_static_delegate = new efl_ui_panes_part_split_ratio_min_get_delegate(split_ratio_min_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetSplitRatioMin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_panes_part_split_ratio_min_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_panes_part_split_ratio_min_get_static_delegate) });
            }

            if (efl_ui_panes_part_split_ratio_min_set_static_delegate == null)
            {
                efl_ui_panes_part_split_ratio_min_set_static_delegate = new efl_ui_panes_part_split_ratio_min_set_delegate(split_ratio_min_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetSplitRatioMin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_panes_part_split_ratio_min_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_panes_part_split_ratio_min_set_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.PanesPart.efl_ui_panes_part_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_panes_part_hint_min_allow_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_panes_part_hint_min_allow_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_panes_part_hint_min_allow_get_api_delegate> efl_ui_panes_part_hint_min_allow_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_panes_part_hint_min_allow_get_api_delegate>(Module, "efl_ui_panes_part_hint_min_allow_get");

        private static bool hint_min_allow_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_panes_part_hint_min_allow_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((PanesPart)wrapper).GetHintMinAllow();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_ui_panes_part_hint_min_allow_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_panes_part_hint_min_allow_get_delegate efl_ui_panes_part_hint_min_allow_get_static_delegate;

        
        private delegate void efl_ui_panes_part_hint_min_allow_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool allow);

        
        public delegate void efl_ui_panes_part_hint_min_allow_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool allow);

        public static Efl.Eo.FunctionWrapper<efl_ui_panes_part_hint_min_allow_set_api_delegate> efl_ui_panes_part_hint_min_allow_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_panes_part_hint_min_allow_set_api_delegate>(Module, "efl_ui_panes_part_hint_min_allow_set");

        private static void hint_min_allow_set(System.IntPtr obj, System.IntPtr pd, bool allow)
        {
            Eina.Log.Debug("function efl_ui_panes_part_hint_min_allow_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((PanesPart)wrapper).SetHintMinAllow(allow);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_panes_part_hint_min_allow_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), allow);
            }
        }

        private static efl_ui_panes_part_hint_min_allow_set_delegate efl_ui_panes_part_hint_min_allow_set_static_delegate;

        
        private delegate double efl_ui_panes_part_split_ratio_min_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_ui_panes_part_split_ratio_min_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_panes_part_split_ratio_min_get_api_delegate> efl_ui_panes_part_split_ratio_min_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_panes_part_split_ratio_min_get_api_delegate>(Module, "efl_ui_panes_part_split_ratio_min_get");

        private static double split_ratio_min_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_panes_part_split_ratio_min_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((PanesPart)wrapper).GetSplitRatioMin();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_ui_panes_part_split_ratio_min_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_panes_part_split_ratio_min_get_delegate efl_ui_panes_part_split_ratio_min_get_static_delegate;

        
        private delegate void efl_ui_panes_part_split_ratio_min_set_delegate(System.IntPtr obj, System.IntPtr pd,  double size);

        
        public delegate void efl_ui_panes_part_split_ratio_min_set_api_delegate(System.IntPtr obj,  double size);

        public static Efl.Eo.FunctionWrapper<efl_ui_panes_part_split_ratio_min_set_api_delegate> efl_ui_panes_part_split_ratio_min_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_panes_part_split_ratio_min_set_api_delegate>(Module, "efl_ui_panes_part_split_ratio_min_set");

        private static void split_ratio_min_set(System.IntPtr obj, System.IntPtr pd, double size)
        {
            Eina.Log.Debug("function efl_ui_panes_part_split_ratio_min_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((PanesPart)wrapper).SetSplitRatioMin(size);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_panes_part_split_ratio_min_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), size);
            }
        }

        private static efl_ui_panes_part_split_ratio_min_set_delegate efl_ui_panes_part_split_ratio_min_set_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

