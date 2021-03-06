#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

namespace Focus {

/// <summary>This defines the inheriting widget as Composition widget.
/// A composition widget is a widget that&apos;s the logical parent of another set of widgets which can be used for interaction.</summary>
[Efl.Ui.Focus.ICompositionConcrete.NativeMethods]
public interface IComposition : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Set the order of elements that will be used for composition
/// Elements of the list can be either an Efl.Ui.Widget, an Efl.Ui.Focus.Object or an Efl.Gfx.
/// 
/// If the element is an Efl.Gfx.Entity, then the geometry is used as focus geometry, the focus property is redirected to the evas focus property. The mixin will take care of registration.
/// 
/// If the element is an Efl.Ui.Focus.Object, then the mixin will take care of registering the element.
/// 
/// If the element is a Efl.Ui.Widget nothing is done and the widget is simply part of the order.</summary>
/// <returns>The order to use</returns>
Eina.List<Efl.Gfx.IEntity> GetCompositionElements();
    /// <summary>Set the order of elements that will be used for composition
/// Elements of the list can be either an Efl.Ui.Widget, an Efl.Ui.Focus.Object or an Efl.Gfx.
/// 
/// If the element is an Efl.Gfx.Entity, then the geometry is used as focus geometry, the focus property is redirected to the evas focus property. The mixin will take care of registration.
/// 
/// If the element is an Efl.Ui.Focus.Object, then the mixin will take care of registering the element.
/// 
/// If the element is a Efl.Ui.Widget nothing is done and the widget is simply part of the order.</summary>
/// <param name="logical_order">The order to use</param>
void SetCompositionElements(Eina.List<Efl.Gfx.IEntity> logical_order);
    /// <summary>Set to true if all children should be registered as logicals</summary>
/// <returns><c>true</c> or <c>false</c></returns>
bool GetLogicalMode();
    /// <summary>Set to true if all children should be registered as logicals</summary>
/// <param name="logical_mode"><c>true</c> or <c>false</c></param>
void SetLogicalMode(bool logical_mode);
    /// <summary>Mark this widget as dirty, the children can be considered to be changed after that call</summary>
void Dirty();
    /// <summary>A call to prepare the children of this element, called if marked as dirty
/// You can use this function to call composition_elements.</summary>
void Prepare();
                            /// <summary>Set the order of elements that will be used for composition
/// Elements of the list can be either an Efl.Ui.Widget, an Efl.Ui.Focus.Object or an Efl.Gfx.
/// 
/// If the element is an Efl.Gfx.Entity, then the geometry is used as focus geometry, the focus property is redirected to the evas focus property. The mixin will take care of registration.
/// 
/// If the element is an Efl.Ui.Focus.Object, then the mixin will take care of registering the element.
/// 
/// If the element is a Efl.Ui.Widget nothing is done and the widget is simply part of the order.</summary>
/// <value>The order to use</value>
    Eina.List<Efl.Gfx.IEntity> CompositionElements {
        get ;
        set ;
    }
    /// <summary>Set to true if all children should be registered as logicals</summary>
/// <value><c>true</c> or <c>false</c></value>
    bool LogicalMode {
        get ;
        set ;
    }
}
/// <summary>This defines the inheriting widget as Composition widget.
/// A composition widget is a widget that&apos;s the logical parent of another set of widgets which can be used for interaction.</summary>
sealed public class ICompositionConcrete : 

IComposition
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(ICompositionConcrete))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    private  System.IntPtr handle;
    ///<summary>Pointer to the native instance.</summary>
    public System.IntPtr NativeHandle
    {
        get { return handle; }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
        efl_ui_focus_composition_mixin_get();
    /// <summary>Initializes a new instance of the <see cref="IComposition"/> class.
    /// Internal usage: This is used when interacting with C code and should not be used directly.</summary>
    private ICompositionConcrete(System.IntPtr raw)
    {
        handle = raw;
    }
    ///<summary>Destructor.</summary>
    ~ICompositionConcrete()
    {
        Dispose(false);
    }

    ///<summary>Releases the underlying native instance.</summary>
    private void Dispose(bool disposing)
    {
        if (handle != System.IntPtr.Zero)
        {
            IntPtr h = handle;
            handle = IntPtr.Zero;

            IntPtr gcHandlePtr = IntPtr.Zero;
            if (disposing)
            {
                Efl.Eo.Globals.efl_mono_native_dispose(h, gcHandlePtr);
            }
            else
            {
                Monitor.Enter(Efl.All.InitLock);
                if (Efl.All.MainLoopInitialized)
                {
                    Efl.Eo.Globals.efl_mono_thread_safe_native_dispose(h, gcHandlePtr);
                }

                Monitor.Exit(Efl.All.InitLock);
            }
        }

    }

    ///<summary>Releases the underlying native instance.</summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
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

    /// <summary>Set the order of elements that will be used for composition
    /// Elements of the list can be either an Efl.Ui.Widget, an Efl.Ui.Focus.Object or an Efl.Gfx.
    /// 
    /// If the element is an Efl.Gfx.Entity, then the geometry is used as focus geometry, the focus property is redirected to the evas focus property. The mixin will take care of registration.
    /// 
    /// If the element is an Efl.Ui.Focus.Object, then the mixin will take care of registering the element.
    /// 
    /// If the element is a Efl.Ui.Widget nothing is done and the widget is simply part of the order.</summary>
    /// <returns>The order to use</returns>
    public Eina.List<Efl.Gfx.IEntity> GetCompositionElements() {
         var _ret_var = Efl.Ui.Focus.ICompositionConcrete.NativeMethods.efl_ui_focus_composition_elements_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return new Eina.List<Efl.Gfx.IEntity>(_ret_var, true, false);
 }
    /// <summary>Set the order of elements that will be used for composition
    /// Elements of the list can be either an Efl.Ui.Widget, an Efl.Ui.Focus.Object or an Efl.Gfx.
    /// 
    /// If the element is an Efl.Gfx.Entity, then the geometry is used as focus geometry, the focus property is redirected to the evas focus property. The mixin will take care of registration.
    /// 
    /// If the element is an Efl.Ui.Focus.Object, then the mixin will take care of registering the element.
    /// 
    /// If the element is a Efl.Ui.Widget nothing is done and the widget is simply part of the order.</summary>
    /// <param name="logical_order">The order to use</param>
    public void SetCompositionElements(Eina.List<Efl.Gfx.IEntity> logical_order) {
         var _in_logical_order = logical_order.Handle;
logical_order.Own = false;
                        Efl.Ui.Focus.ICompositionConcrete.NativeMethods.efl_ui_focus_composition_elements_set_ptr.Value.Delegate(this.NativeHandle,_in_logical_order);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Set to true if all children should be registered as logicals</summary>
    /// <returns><c>true</c> or <c>false</c></returns>
    public bool GetLogicalMode() {
         var _ret_var = Efl.Ui.Focus.ICompositionConcrete.NativeMethods.efl_ui_focus_composition_logical_mode_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Set to true if all children should be registered as logicals</summary>
    /// <param name="logical_mode"><c>true</c> or <c>false</c></param>
    public void SetLogicalMode(bool logical_mode) {
                                 Efl.Ui.Focus.ICompositionConcrete.NativeMethods.efl_ui_focus_composition_logical_mode_set_ptr.Value.Delegate(this.NativeHandle,logical_mode);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Mark this widget as dirty, the children can be considered to be changed after that call</summary>
    public void Dirty() {
         Efl.Ui.Focus.ICompositionConcrete.NativeMethods.efl_ui_focus_composition_dirty_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
         }
    /// <summary>A call to prepare the children of this element, called if marked as dirty
    /// You can use this function to call composition_elements.</summary>
    public void Prepare() {
         Efl.Ui.Focus.ICompositionConcrete.NativeMethods.efl_ui_focus_composition_prepare_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
         }
    /// <summary>Set the order of elements that will be used for composition
/// Elements of the list can be either an Efl.Ui.Widget, an Efl.Ui.Focus.Object or an Efl.Gfx.
/// 
/// If the element is an Efl.Gfx.Entity, then the geometry is used as focus geometry, the focus property is redirected to the evas focus property. The mixin will take care of registration.
/// 
/// If the element is an Efl.Ui.Focus.Object, then the mixin will take care of registering the element.
/// 
/// If the element is a Efl.Ui.Widget nothing is done and the widget is simply part of the order.</summary>
/// <value>The order to use</value>
    public Eina.List<Efl.Gfx.IEntity> CompositionElements {
        get { return GetCompositionElements(); }
        set { SetCompositionElements(value); }
    }
    /// <summary>Set to true if all children should be registered as logicals</summary>
/// <value><c>true</c> or <c>false</c></value>
    public bool LogicalMode {
        get { return GetLogicalMode(); }
        set { SetLogicalMode(value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.Focus.ICompositionConcrete.efl_ui_focus_composition_mixin_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public class NativeMethods  : Efl.Eo.NativeClass
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Elementary);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_focus_composition_elements_get_static_delegate == null)
            {
                efl_ui_focus_composition_elements_get_static_delegate = new efl_ui_focus_composition_elements_get_delegate(composition_elements_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetCompositionElements") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_focus_composition_elements_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_composition_elements_get_static_delegate) });
            }

            if (efl_ui_focus_composition_elements_set_static_delegate == null)
            {
                efl_ui_focus_composition_elements_set_static_delegate = new efl_ui_focus_composition_elements_set_delegate(composition_elements_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetCompositionElements") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_focus_composition_elements_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_composition_elements_set_static_delegate) });
            }

            if (efl_ui_focus_composition_logical_mode_get_static_delegate == null)
            {
                efl_ui_focus_composition_logical_mode_get_static_delegate = new efl_ui_focus_composition_logical_mode_get_delegate(logical_mode_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetLogicalMode") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_focus_composition_logical_mode_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_composition_logical_mode_get_static_delegate) });
            }

            if (efl_ui_focus_composition_logical_mode_set_static_delegate == null)
            {
                efl_ui_focus_composition_logical_mode_set_static_delegate = new efl_ui_focus_composition_logical_mode_set_delegate(logical_mode_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetLogicalMode") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_focus_composition_logical_mode_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_composition_logical_mode_set_static_delegate) });
            }

            if (efl_ui_focus_composition_dirty_static_delegate == null)
            {
                efl_ui_focus_composition_dirty_static_delegate = new efl_ui_focus_composition_dirty_delegate(dirty);
            }

            if (methods.FirstOrDefault(m => m.Name == "Dirty") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_focus_composition_dirty"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_composition_dirty_static_delegate) });
            }

            if (efl_ui_focus_composition_prepare_static_delegate == null)
            {
                efl_ui_focus_composition_prepare_static_delegate = new efl_ui_focus_composition_prepare_delegate(prepare);
            }

            if (methods.FirstOrDefault(m => m.Name == "Prepare") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_focus_composition_prepare"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_composition_prepare_static_delegate) });
            }

            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.Focus.ICompositionConcrete.efl_ui_focus_composition_mixin_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        
        private delegate System.IntPtr efl_ui_focus_composition_elements_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate System.IntPtr efl_ui_focus_composition_elements_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_focus_composition_elements_get_api_delegate> efl_ui_focus_composition_elements_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_composition_elements_get_api_delegate>(Module, "efl_ui_focus_composition_elements_get");

        private static System.IntPtr composition_elements_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_focus_composition_elements_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Eina.List<Efl.Gfx.IEntity> _ret_var = default(Eina.List<Efl.Gfx.IEntity>);
                try
                {
                    _ret_var = ((ICompositionConcrete)wrapper).GetCompositionElements();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        _ret_var.Own = false; return _ret_var.Handle;

            }
            else
            {
                return efl_ui_focus_composition_elements_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_focus_composition_elements_get_delegate efl_ui_focus_composition_elements_get_static_delegate;

        
        private delegate void efl_ui_focus_composition_elements_set_delegate(System.IntPtr obj, System.IntPtr pd,  System.IntPtr logical_order);

        
        public delegate void efl_ui_focus_composition_elements_set_api_delegate(System.IntPtr obj,  System.IntPtr logical_order);

        public static Efl.Eo.FunctionWrapper<efl_ui_focus_composition_elements_set_api_delegate> efl_ui_focus_composition_elements_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_composition_elements_set_api_delegate>(Module, "efl_ui_focus_composition_elements_set");

        private static void composition_elements_set(System.IntPtr obj, System.IntPtr pd, System.IntPtr logical_order)
        {
            Eina.Log.Debug("function efl_ui_focus_composition_elements_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
        var _in_logical_order = new Eina.List<Efl.Gfx.IEntity>(logical_order, true, false);
                            
                try
                {
                    ((ICompositionConcrete)wrapper).SetCompositionElements(_in_logical_order);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_focus_composition_elements_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), logical_order);
            }
        }

        private static efl_ui_focus_composition_elements_set_delegate efl_ui_focus_composition_elements_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_focus_composition_logical_mode_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_focus_composition_logical_mode_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_focus_composition_logical_mode_get_api_delegate> efl_ui_focus_composition_logical_mode_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_composition_logical_mode_get_api_delegate>(Module, "efl_ui_focus_composition_logical_mode_get");

        private static bool logical_mode_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_focus_composition_logical_mode_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((ICompositionConcrete)wrapper).GetLogicalMode();
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
                return efl_ui_focus_composition_logical_mode_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_focus_composition_logical_mode_get_delegate efl_ui_focus_composition_logical_mode_get_static_delegate;

        
        private delegate void efl_ui_focus_composition_logical_mode_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool logical_mode);

        
        public delegate void efl_ui_focus_composition_logical_mode_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool logical_mode);

        public static Efl.Eo.FunctionWrapper<efl_ui_focus_composition_logical_mode_set_api_delegate> efl_ui_focus_composition_logical_mode_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_composition_logical_mode_set_api_delegate>(Module, "efl_ui_focus_composition_logical_mode_set");

        private static void logical_mode_set(System.IntPtr obj, System.IntPtr pd, bool logical_mode)
        {
            Eina.Log.Debug("function efl_ui_focus_composition_logical_mode_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ICompositionConcrete)wrapper).SetLogicalMode(logical_mode);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_focus_composition_logical_mode_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), logical_mode);
            }
        }

        private static efl_ui_focus_composition_logical_mode_set_delegate efl_ui_focus_composition_logical_mode_set_static_delegate;

        
        private delegate void efl_ui_focus_composition_dirty_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate void efl_ui_focus_composition_dirty_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_focus_composition_dirty_api_delegate> efl_ui_focus_composition_dirty_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_composition_dirty_api_delegate>(Module, "efl_ui_focus_composition_dirty");

        private static void dirty(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_focus_composition_dirty was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            
                try
                {
                    ((ICompositionConcrete)wrapper).Dirty();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        
            }
            else
            {
                efl_ui_focus_composition_dirty_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_focus_composition_dirty_delegate efl_ui_focus_composition_dirty_static_delegate;

        
        private delegate void efl_ui_focus_composition_prepare_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate void efl_ui_focus_composition_prepare_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_focus_composition_prepare_api_delegate> efl_ui_focus_composition_prepare_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_composition_prepare_api_delegate>(Module, "efl_ui_focus_composition_prepare");

        private static void prepare(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_focus_composition_prepare was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            
                try
                {
                    ((ICompositionConcrete)wrapper).Prepare();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        
            }
            else
            {
                efl_ui_focus_composition_prepare_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_focus_composition_prepare_delegate efl_ui_focus_composition_prepare_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

}

