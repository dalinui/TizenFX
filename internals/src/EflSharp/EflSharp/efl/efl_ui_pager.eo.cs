#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

/// <summary>Pager widget
/// A pager contains many pages in a linear fashion and allows users to scroll through pages. Each page is numbered according to linear order and one of the pages is marked as &apos;current page&apos; and displayed in the middle. The way each page is displayed is defined by <see cref="Efl.Page.Transition"/> object, allowing users to adopt different types of transition. The most common use case of this widget is the home screen of mobile devices.</summary>
[Efl.Ui.Pager.NativeMethods]
public class Pager : Efl.Ui.LayoutBase, Efl.Eo.IWrapper,Efl.IPack,Efl.IPackLinear
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(Pager))
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
        efl_ui_pager_class_get();
    /// <summary>Initializes a new instance of the <see cref="Pager"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    /// <param name="style">The widget style to use. See <see cref="Efl.Ui.Widget.SetStyle"/></param>
    public Pager(Efl.Object parent
            , System.String style = null) : base(efl_ui_pager_class_get(), typeof(Pager), parent)
    {
        if (Efl.Eo.Globals.ParamHelperCheck(style))
        {
            SetStyle(Efl.Eo.Globals.GetParamHelper(style));
        }

        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="Pager"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected Pager(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="Pager"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected Pager(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
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

    /// <summary>Set a page transition effect</summary>
    /// <param name="transition">transition effect</param>
    virtual public void SetTransition(Efl.Page.Transition transition) {
                                 Efl.Ui.Pager.NativeMethods.efl_ui_pager_transition_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),transition);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Set a page indicator</summary>
    /// <param name="indicator">indicator class</param>
    virtual public void SetIndicator(Efl.Page.Indicator indicator) {
                                 Efl.Ui.Pager.NativeMethods.efl_ui_pager_indicator_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),indicator);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Get the current page</summary>
    virtual public int GetCurrentPage() {
         var _ret_var = Efl.Ui.Pager.NativeMethods.efl_ui_pager_current_page_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Set one page as current page</summary>
    virtual public void SetCurrentPage(int index) {
                                 Efl.Ui.Pager.NativeMethods.efl_ui_pager_current_page_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),index);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Pages can be scrolled back and forth by default. This property allows limiting the direction of scrolling, or blocking scroll gesture at all.</summary>
    virtual public void GetScrollBlock(out bool prev, out bool next) {
                                                         Efl.Ui.Pager.NativeMethods.efl_ui_pager_scroll_block_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),out prev, out next);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Pages can be scrolled back and forth by default. This property allows limiting the direction of scrolling, or blocking scroll gesture at all.</summary>
    virtual public void SetScrollBlock(bool prev, bool next) {
                                                         Efl.Ui.Pager.NativeMethods.efl_ui_pager_scroll_block_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),prev, next);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Pager is not scrolled after it&apos;s scrolled to the end by default. This property gives the option to make a loop through pages.</summary>
    virtual public Efl.Ui.PagerLoop GetLoopMode() {
         var _ret_var = Efl.Ui.Pager.NativeMethods.efl_ui_pager_loop_mode_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Pager is not scrolled after it&apos;s scrolled to the end by default. This property gives the option to make a loop through pages.</summary>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    virtual public bool SetLoopMode(Efl.Ui.PagerLoop loop) {
                                 var _ret_var = Efl.Ui.Pager.NativeMethods.efl_ui_pager_loop_mode_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),loop);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    virtual public Eina.Size2D GetPageSize() {
         var _ret_var = Efl.Ui.Pager.NativeMethods.efl_ui_pager_page_size_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    virtual public void SetPageSize(Eina.Size2D size) {
         Eina.Size2D.NativeStruct _in_size = size;
                        Efl.Ui.Pager.NativeMethods.efl_ui_pager_page_size_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),_in_size);
        Eina.Error.RaiseIfUnhandledException();
                         }
    virtual public int GetPadding() {
         var _ret_var = Efl.Ui.Pager.NativeMethods.efl_ui_pager_padding_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    virtual public void SetPadding(int padding) {
                                 Efl.Ui.Pager.NativeMethods.efl_ui_pager_padding_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),padding);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Alignment of the container within its bounds</summary>
    /// <param name="align_horiz">Horizontal alignment</param>
    /// <param name="align_vert">Vertical alignment</param>
    virtual public void GetPackAlign(out double align_horiz, out double align_vert) {
                                                         Efl.IPackConcrete.NativeMethods.efl_pack_align_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),out align_horiz, out align_vert);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Alignment of the container within its bounds</summary>
    /// <param name="align_horiz">Horizontal alignment</param>
    /// <param name="align_vert">Vertical alignment</param>
    virtual public void SetPackAlign(double align_horiz, double align_vert) {
                                                         Efl.IPackConcrete.NativeMethods.efl_pack_align_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),align_horiz, align_vert);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Padding between items contained in this object.</summary>
    /// <param name="pad_horiz">Horizontal padding</param>
    /// <param name="pad_vert">Vertical padding</param>
    /// <param name="scalable"><c>true</c> if scalable, <c>false</c> otherwise</param>
    virtual public void GetPackPadding(out double pad_horiz, out double pad_vert, out bool scalable) {
                                                                                 Efl.IPackConcrete.NativeMethods.efl_pack_padding_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),out pad_horiz, out pad_vert, out scalable);
        Eina.Error.RaiseIfUnhandledException();
                                                         }
    /// <summary>Padding between items contained in this object.</summary>
    /// <param name="pad_horiz">Horizontal padding</param>
    /// <param name="pad_vert">Vertical padding</param>
    /// <param name="scalable"><c>true</c> if scalable, <c>false</c> otherwise</param>
    virtual public void SetPackPadding(double pad_horiz, double pad_vert, bool scalable) {
                                                                                 Efl.IPackConcrete.NativeMethods.efl_pack_padding_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),pad_horiz, pad_vert, scalable);
        Eina.Error.RaiseIfUnhandledException();
                                                         }
    /// <summary>Removes all packed contents, and unreferences them.</summary>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    virtual public bool ClearPack() {
         var _ret_var = Efl.IPackConcrete.NativeMethods.efl_pack_clear_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Removes all packed contents, without unreferencing them.
    /// Use with caution.</summary>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    virtual public bool UnpackAll() {
         var _ret_var = Efl.IPackConcrete.NativeMethods.efl_pack_unpack_all_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Removes an existing item from the container, without deleting it.</summary>
    /// <param name="subobj">The unpacked object.</param>
    /// <returns><c>false</c> if <c>subobj</c> wasn&apos;t a child or can&apos;t be removed</returns>
    virtual public bool Unpack(Efl.Gfx.IEntity subobj) {
                                 var _ret_var = Efl.IPackConcrete.NativeMethods.efl_pack_unpack_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Adds an item to this container.
    /// Depending on the container this will either fill in the default spot, replacing any already existing element or append to the end of the container if there is no default part.
    /// 
    /// When this container is deleted, it will request deletion of the given <c>subobj</c>. Use <see cref="Efl.IPack.Unpack"/> to remove <c>subobj</c> from this container without deleting it.</summary>
    /// <param name="subobj">An object to pack.</param>
    /// <returns><c>false</c> if <c>subobj</c> could not be packed.</returns>
    virtual public bool Pack(Efl.Gfx.IEntity subobj) {
                                 var _ret_var = Efl.IPackConcrete.NativeMethods.efl_pack_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Prepend an object at the beginning of this container.
    /// This is the same as <see cref="Efl.IPackLinear.PackAt"/>(<c>subobj</c>, 0).
    /// 
    /// When this container is deleted, it will request deletion of the given <c>subobj</c>. Use <see cref="Efl.IPack.Unpack"/> to remove <c>subobj</c> from this container without deleting it.</summary>
    /// <param name="subobj">Item to pack at the beginning.</param>
    /// <returns><c>false</c> if <c>subobj</c> could not be packed.</returns>
    virtual public bool PackBegin(Efl.Gfx.IEntity subobj) {
                                 var _ret_var = Efl.IPackLinearConcrete.NativeMethods.efl_pack_begin_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Append item at the end of this container.
    /// This is the same as <see cref="Efl.IPackLinear.PackAt"/>(<c>subobj</c>, -1).
    /// 
    /// When this container is deleted, it will request deletion of the given <c>subobj</c>. Use <see cref="Efl.IPack.Unpack"/> to remove <c>subobj</c> from this container without deleting it.</summary>
    /// <param name="subobj">Item to pack at the end.</param>
    /// <returns><c>false</c> if <c>subobj</c> could not be packed.</returns>
    virtual public bool PackEnd(Efl.Gfx.IEntity subobj) {
                                 var _ret_var = Efl.IPackLinearConcrete.NativeMethods.efl_pack_end_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Prepend item before other sub object.
    /// When this container is deleted, it will request deletion of the given <c>subobj</c>. Use <see cref="Efl.IPack.Unpack"/> to remove <c>subobj</c> from this container without deleting it.</summary>
    /// <param name="subobj">Item to pack before <c>existing</c>.</param>
    /// <param name="existing">Item to refer to.</param>
    /// <returns><c>false</c> if <c>existing</c> could not be found or <c>subobj</c> could not be packed.</returns>
    virtual public bool PackBefore(Efl.Gfx.IEntity subobj, Efl.Gfx.IEntity existing) {
                                                         var _ret_var = Efl.IPackLinearConcrete.NativeMethods.efl_pack_before_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj, existing);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Append item after other sub object.
    /// When this container is deleted, it will request deletion of the given <c>subobj</c>. Use <see cref="Efl.IPack.Unpack"/> to remove <c>subobj</c> from this container without deleting it.</summary>
    /// <param name="subobj">Item to pack after <c>existing</c>.</param>
    /// <param name="existing">Item to refer to.</param>
    /// <returns><c>false</c> if <c>existing</c> could not be found or <c>subobj</c> could not be packed.</returns>
    virtual public bool PackAfter(Efl.Gfx.IEntity subobj, Efl.Gfx.IEntity existing) {
                                                         var _ret_var = Efl.IPackLinearConcrete.NativeMethods.efl_pack_after_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj, existing);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Inserts <c>subobj</c> BEFORE the item at position <c>index</c>.
    /// <c>index</c> ranges from -<c>count</c> to <c>count</c>-1, where positive numbers go from first item (0) to last item (<c>count</c>-1), and negative numbers go from last item (-1) to first item (-<c>count</c>). Where <c>count</c> is the number of items currently in the container.
    /// 
    /// If <c>index</c> is less than -<c>count</c>, it will trigger <see cref="Efl.IPackLinear.PackBegin"/>(<c>subobj</c>) whereas <c>index</c> greater than <c>count</c>-1 will trigger <see cref="Efl.IPackLinear.PackEnd"/>(<c>subobj</c>).
    /// 
    /// When this container is deleted, it will request deletion of the given <c>subobj</c>. Use <see cref="Efl.IPack.Unpack"/> to remove <c>subobj</c> from this container without deleting it.</summary>
    /// <param name="subobj">Item to pack.</param>
    /// <param name="index">Index of item to insert BEFORE. Valid range is -<c>count</c> to (<c>count</c>-1).</param>
    /// <returns><c>false</c> if <c>subobj</c> could not be packed.</returns>
    virtual public bool PackAt(Efl.Gfx.IEntity subobj, int index) {
                                                         var _ret_var = Efl.IPackLinearConcrete.NativeMethods.efl_pack_at_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj, index);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Content at a given <c>index</c> in this container.
    /// <c>index</c> ranges from -<c>count</c> to <c>count</c>-1, where positive numbers go from first item (0) to last item (<c>count</c>-1), and negative numbers go from last item (-1) to first item (-<c>count</c>). Where <c>count</c> is the number of items currently in the container.
    /// 
    /// If <c>index</c> is less than -<c>count</c>, it will return the first item whereas <c>index</c> greater than <c>count</c>-1 will return the last item.</summary>
    /// <param name="index">Index of the item to retrieve. Valid range is -<c>count</c> to (<c>count</c>-1).</param>
    /// <returns>The object contained at the given <c>index</c>.</returns>
    virtual public Efl.Gfx.IEntity GetPackContent(int index) {
                                 var _ret_var = Efl.IPackLinearConcrete.NativeMethods.efl_pack_content_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),index);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Get the index of a child in this container.</summary>
    /// <param name="subobj">An object contained in this pack.</param>
    /// <returns>-1 in case <c>subobj</c> is not a child of this object, or the index of this item in the range 0 to (<c>count</c>-1).</returns>
    virtual public int GetPackIndex(Efl.Gfx.IEntity subobj) {
                                 var _ret_var = Efl.IPackLinearConcrete.NativeMethods.efl_pack_index_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Pop out (remove) the item at the specified <c>index</c>.
    /// <c>index</c> ranges from -<c>count</c> to <c>count</c>-1, where positive numbers go from first item (0) to last item (<c>count</c>-1), and negative numbers go from last item (-1) to first item (-<c>count</c>). Where <c>count</c> is the number of items currently in the container.
    /// 
    /// If <c>index</c> is less than -<c>count</c>, it will remove the first item whereas <c>index</c> greater than <c>count</c>-1 will remove the last item.
    /// 
    /// Equivalent to <see cref="Efl.IPack.Unpack"/>(<see cref="Efl.IPackLinear.GetPackContent"/>(<c>index</c>)).</summary>
    /// <param name="index">Index of item to remove. Valid range is -<c>count</c> to (<c>count</c>-1).</param>
    /// <returns>The child item if it could be removed.</returns>
    virtual public Efl.Gfx.IEntity PackUnpackAt(int index) {
                                 var _ret_var = Efl.IPackLinearConcrete.NativeMethods.efl_pack_unpack_at_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),index);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Page transition effect
/// Page transition is in charge of displaying pages in a specific way and invoked every time page layout needs to be updated.</summary>
/// <value>transition effect</value>
    public Efl.Page.Transition Transition {
        set { SetTransition(value); }
    }
    /// <summary>Page indicator
/// Page indicator, located on the top layer of pager widget, helps users to know the number of pages and the current page&apos;s index without scrolling.</summary>
/// <value>indicator class</value>
    public Efl.Page.Indicator Indicator {
        set { SetIndicator(value); }
    }
    /// <summary>One page is selected as the current page and mainly displayed.</summary>
    public int CurrentPage {
        get { return GetCurrentPage(); }
        set { SetCurrentPage(value); }
    }
    /// <summary>Pager is not scrolled after it&apos;s scrolled to the end by default. This property gives the option to make a loop through pages.</summary>
    public Efl.Ui.PagerLoop LoopMode {
        get { return GetLoopMode(); }
        set { SetLoopMode(value); }
    }
        public Eina.Size2D PageSize {
        get { return GetPageSize(); }
        set { SetPageSize(value); }
    }
        public int Padding {
        get { return GetPadding(); }
        set { SetPadding(value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.Pager.efl_ui_pager_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Ui.LayoutBase.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Elementary);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_pager_transition_set_static_delegate == null)
            {
                efl_ui_pager_transition_set_static_delegate = new efl_ui_pager_transition_set_delegate(transition_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetTransition") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_transition_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_transition_set_static_delegate) });
            }

            if (efl_ui_pager_indicator_set_static_delegate == null)
            {
                efl_ui_pager_indicator_set_static_delegate = new efl_ui_pager_indicator_set_delegate(indicator_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetIndicator") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_indicator_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_indicator_set_static_delegate) });
            }

            if (efl_ui_pager_current_page_get_static_delegate == null)
            {
                efl_ui_pager_current_page_get_static_delegate = new efl_ui_pager_current_page_get_delegate(current_page_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetCurrentPage") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_current_page_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_current_page_get_static_delegate) });
            }

            if (efl_ui_pager_current_page_set_static_delegate == null)
            {
                efl_ui_pager_current_page_set_static_delegate = new efl_ui_pager_current_page_set_delegate(current_page_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetCurrentPage") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_current_page_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_current_page_set_static_delegate) });
            }

            if (efl_ui_pager_scroll_block_get_static_delegate == null)
            {
                efl_ui_pager_scroll_block_get_static_delegate = new efl_ui_pager_scroll_block_get_delegate(scroll_block_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetScrollBlock") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_scroll_block_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_scroll_block_get_static_delegate) });
            }

            if (efl_ui_pager_scroll_block_set_static_delegate == null)
            {
                efl_ui_pager_scroll_block_set_static_delegate = new efl_ui_pager_scroll_block_set_delegate(scroll_block_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetScrollBlock") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_scroll_block_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_scroll_block_set_static_delegate) });
            }

            if (efl_ui_pager_loop_mode_get_static_delegate == null)
            {
                efl_ui_pager_loop_mode_get_static_delegate = new efl_ui_pager_loop_mode_get_delegate(loop_mode_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetLoopMode") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_loop_mode_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_loop_mode_get_static_delegate) });
            }

            if (efl_ui_pager_loop_mode_set_static_delegate == null)
            {
                efl_ui_pager_loop_mode_set_static_delegate = new efl_ui_pager_loop_mode_set_delegate(loop_mode_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetLoopMode") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_loop_mode_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_loop_mode_set_static_delegate) });
            }

            if (efl_ui_pager_page_size_get_static_delegate == null)
            {
                efl_ui_pager_page_size_get_static_delegate = new efl_ui_pager_page_size_get_delegate(page_size_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetPageSize") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_page_size_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_page_size_get_static_delegate) });
            }

            if (efl_ui_pager_page_size_set_static_delegate == null)
            {
                efl_ui_pager_page_size_set_static_delegate = new efl_ui_pager_page_size_set_delegate(page_size_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetPageSize") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_page_size_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_page_size_set_static_delegate) });
            }

            if (efl_ui_pager_padding_get_static_delegate == null)
            {
                efl_ui_pager_padding_get_static_delegate = new efl_ui_pager_padding_get_delegate(padding_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetPadding") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_padding_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_padding_get_static_delegate) });
            }

            if (efl_ui_pager_padding_set_static_delegate == null)
            {
                efl_ui_pager_padding_set_static_delegate = new efl_ui_pager_padding_set_delegate(padding_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetPadding") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_pager_padding_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_pager_padding_set_static_delegate) });
            }

            if (efl_pack_align_get_static_delegate == null)
            {
                efl_pack_align_get_static_delegate = new efl_pack_align_get_delegate(pack_align_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetPackAlign") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_align_get"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_align_get_static_delegate) });
            }

            if (efl_pack_align_set_static_delegate == null)
            {
                efl_pack_align_set_static_delegate = new efl_pack_align_set_delegate(pack_align_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetPackAlign") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_align_set"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_align_set_static_delegate) });
            }

            if (efl_pack_padding_get_static_delegate == null)
            {
                efl_pack_padding_get_static_delegate = new efl_pack_padding_get_delegate(pack_padding_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetPackPadding") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_padding_get"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_padding_get_static_delegate) });
            }

            if (efl_pack_padding_set_static_delegate == null)
            {
                efl_pack_padding_set_static_delegate = new efl_pack_padding_set_delegate(pack_padding_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetPackPadding") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_padding_set"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_padding_set_static_delegate) });
            }

            if (efl_pack_clear_static_delegate == null)
            {
                efl_pack_clear_static_delegate = new efl_pack_clear_delegate(pack_clear);
            }

            if (methods.FirstOrDefault(m => m.Name == "ClearPack") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_clear"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_clear_static_delegate) });
            }

            if (efl_pack_unpack_all_static_delegate == null)
            {
                efl_pack_unpack_all_static_delegate = new efl_pack_unpack_all_delegate(unpack_all);
            }

            if (methods.FirstOrDefault(m => m.Name == "UnpackAll") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_unpack_all"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_unpack_all_static_delegate) });
            }

            if (efl_pack_unpack_static_delegate == null)
            {
                efl_pack_unpack_static_delegate = new efl_pack_unpack_delegate(unpack);
            }

            if (methods.FirstOrDefault(m => m.Name == "Unpack") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_unpack"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_unpack_static_delegate) });
            }

            if (efl_pack_static_delegate == null)
            {
                efl_pack_static_delegate = new efl_pack_delegate(pack);
            }

            if (methods.FirstOrDefault(m => m.Name == "Pack") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_static_delegate) });
            }

            if (efl_pack_begin_static_delegate == null)
            {
                efl_pack_begin_static_delegate = new efl_pack_begin_delegate(pack_begin);
            }

            if (methods.FirstOrDefault(m => m.Name == "PackBegin") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_begin"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_begin_static_delegate) });
            }

            if (efl_pack_end_static_delegate == null)
            {
                efl_pack_end_static_delegate = new efl_pack_end_delegate(pack_end);
            }

            if (methods.FirstOrDefault(m => m.Name == "PackEnd") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_end"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_end_static_delegate) });
            }

            if (efl_pack_before_static_delegate == null)
            {
                efl_pack_before_static_delegate = new efl_pack_before_delegate(pack_before);
            }

            if (methods.FirstOrDefault(m => m.Name == "PackBefore") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_before"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_before_static_delegate) });
            }

            if (efl_pack_after_static_delegate == null)
            {
                efl_pack_after_static_delegate = new efl_pack_after_delegate(pack_after);
            }

            if (methods.FirstOrDefault(m => m.Name == "PackAfter") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_after"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_after_static_delegate) });
            }

            if (efl_pack_at_static_delegate == null)
            {
                efl_pack_at_static_delegate = new efl_pack_at_delegate(pack_at);
            }

            if (methods.FirstOrDefault(m => m.Name == "PackAt") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_at"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_at_static_delegate) });
            }

            if (efl_pack_content_get_static_delegate == null)
            {
                efl_pack_content_get_static_delegate = new efl_pack_content_get_delegate(pack_content_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetPackContent") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_content_get"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_content_get_static_delegate) });
            }

            if (efl_pack_index_get_static_delegate == null)
            {
                efl_pack_index_get_static_delegate = new efl_pack_index_get_delegate(pack_index_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetPackIndex") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_index_get"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_index_get_static_delegate) });
            }

            if (efl_pack_unpack_at_static_delegate == null)
            {
                efl_pack_unpack_at_static_delegate = new efl_pack_unpack_at_delegate(pack_unpack_at);
            }

            if (methods.FirstOrDefault(m => m.Name == "PackUnpackAt") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_pack_unpack_at"), func = Marshal.GetFunctionPointerForDelegate(efl_pack_unpack_at_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.Pager.efl_ui_pager_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        
        private delegate void efl_ui_pager_transition_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Page.Transition transition);

        
        public delegate void efl_ui_pager_transition_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Page.Transition transition);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_transition_set_api_delegate> efl_ui_pager_transition_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_transition_set_api_delegate>(Module, "efl_ui_pager_transition_set");

        private static void transition_set(System.IntPtr obj, System.IntPtr pd, Efl.Page.Transition transition)
        {
            Eina.Log.Debug("function efl_ui_pager_transition_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Pager)wrapper).SetTransition(transition);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_pager_transition_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), transition);
            }
        }

        private static efl_ui_pager_transition_set_delegate efl_ui_pager_transition_set_static_delegate;

        
        private delegate void efl_ui_pager_indicator_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Page.Indicator indicator);

        
        public delegate void efl_ui_pager_indicator_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Page.Indicator indicator);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_indicator_set_api_delegate> efl_ui_pager_indicator_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_indicator_set_api_delegate>(Module, "efl_ui_pager_indicator_set");

        private static void indicator_set(System.IntPtr obj, System.IntPtr pd, Efl.Page.Indicator indicator)
        {
            Eina.Log.Debug("function efl_ui_pager_indicator_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Pager)wrapper).SetIndicator(indicator);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_pager_indicator_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), indicator);
            }
        }

        private static efl_ui_pager_indicator_set_delegate efl_ui_pager_indicator_set_static_delegate;

        
        private delegate int efl_ui_pager_current_page_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate int efl_ui_pager_current_page_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_current_page_get_api_delegate> efl_ui_pager_current_page_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_current_page_get_api_delegate>(Module, "efl_ui_pager_current_page_get");

        private static int current_page_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_pager_current_page_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            int _ret_var = default(int);
                try
                {
                    _ret_var = ((Pager)wrapper).GetCurrentPage();
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
                return efl_ui_pager_current_page_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_pager_current_page_get_delegate efl_ui_pager_current_page_get_static_delegate;

        
        private delegate void efl_ui_pager_current_page_set_delegate(System.IntPtr obj, System.IntPtr pd,  int index);

        
        public delegate void efl_ui_pager_current_page_set_api_delegate(System.IntPtr obj,  int index);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_current_page_set_api_delegate> efl_ui_pager_current_page_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_current_page_set_api_delegate>(Module, "efl_ui_pager_current_page_set");

        private static void current_page_set(System.IntPtr obj, System.IntPtr pd, int index)
        {
            Eina.Log.Debug("function efl_ui_pager_current_page_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Pager)wrapper).SetCurrentPage(index);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_pager_current_page_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), index);
            }
        }

        private static efl_ui_pager_current_page_set_delegate efl_ui_pager_current_page_set_static_delegate;

        
        private delegate void efl_ui_pager_scroll_block_get_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] out bool prev, [MarshalAs(UnmanagedType.U1)] out bool next);

        
        public delegate void efl_ui_pager_scroll_block_get_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] out bool prev, [MarshalAs(UnmanagedType.U1)] out bool next);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_scroll_block_get_api_delegate> efl_ui_pager_scroll_block_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_scroll_block_get_api_delegate>(Module, "efl_ui_pager_scroll_block_get");

        private static void scroll_block_get(System.IntPtr obj, System.IntPtr pd, out bool prev, out bool next)
        {
            Eina.Log.Debug("function efl_ui_pager_scroll_block_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        prev = default(bool);        next = default(bool);                            
                try
                {
                    ((Pager)wrapper).GetScrollBlock(out prev, out next);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_pager_scroll_block_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out prev, out next);
            }
        }

        private static efl_ui_pager_scroll_block_get_delegate efl_ui_pager_scroll_block_get_static_delegate;

        
        private delegate void efl_ui_pager_scroll_block_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool prev, [MarshalAs(UnmanagedType.U1)] bool next);

        
        public delegate void efl_ui_pager_scroll_block_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool prev, [MarshalAs(UnmanagedType.U1)] bool next);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_scroll_block_set_api_delegate> efl_ui_pager_scroll_block_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_scroll_block_set_api_delegate>(Module, "efl_ui_pager_scroll_block_set");

        private static void scroll_block_set(System.IntPtr obj, System.IntPtr pd, bool prev, bool next)
        {
            Eina.Log.Debug("function efl_ui_pager_scroll_block_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            
                try
                {
                    ((Pager)wrapper).SetScrollBlock(prev, next);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_pager_scroll_block_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), prev, next);
            }
        }

        private static efl_ui_pager_scroll_block_set_delegate efl_ui_pager_scroll_block_set_static_delegate;

        
        private delegate Efl.Ui.PagerLoop efl_ui_pager_loop_mode_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Efl.Ui.PagerLoop efl_ui_pager_loop_mode_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_loop_mode_get_api_delegate> efl_ui_pager_loop_mode_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_loop_mode_get_api_delegate>(Module, "efl_ui_pager_loop_mode_get");

        private static Efl.Ui.PagerLoop loop_mode_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_pager_loop_mode_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.Ui.PagerLoop _ret_var = default(Efl.Ui.PagerLoop);
                try
                {
                    _ret_var = ((Pager)wrapper).GetLoopMode();
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
                return efl_ui_pager_loop_mode_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_pager_loop_mode_get_delegate efl_ui_pager_loop_mode_get_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_pager_loop_mode_set_delegate(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.PagerLoop loop);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_pager_loop_mode_set_api_delegate(System.IntPtr obj,  Efl.Ui.PagerLoop loop);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_loop_mode_set_api_delegate> efl_ui_pager_loop_mode_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_loop_mode_set_api_delegate>(Module, "efl_ui_pager_loop_mode_set");

        private static bool loop_mode_set(System.IntPtr obj, System.IntPtr pd, Efl.Ui.PagerLoop loop)
        {
            Eina.Log.Debug("function efl_ui_pager_loop_mode_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).SetLoopMode(loop);
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
                return efl_ui_pager_loop_mode_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), loop);
            }
        }

        private static efl_ui_pager_loop_mode_set_delegate efl_ui_pager_loop_mode_set_static_delegate;

        
        private delegate Eina.Size2D.NativeStruct efl_ui_pager_page_size_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Eina.Size2D.NativeStruct efl_ui_pager_page_size_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_page_size_get_api_delegate> efl_ui_pager_page_size_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_page_size_get_api_delegate>(Module, "efl_ui_pager_page_size_get");

        private static Eina.Size2D.NativeStruct page_size_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_pager_page_size_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Eina.Size2D _ret_var = default(Eina.Size2D);
                try
                {
                    _ret_var = ((Pager)wrapper).GetPageSize();
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
                return efl_ui_pager_page_size_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_pager_page_size_get_delegate efl_ui_pager_page_size_get_static_delegate;

        
        private delegate void efl_ui_pager_page_size_set_delegate(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D.NativeStruct size);

        
        public delegate void efl_ui_pager_page_size_set_api_delegate(System.IntPtr obj,  Eina.Size2D.NativeStruct size);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_page_size_set_api_delegate> efl_ui_pager_page_size_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_page_size_set_api_delegate>(Module, "efl_ui_pager_page_size_set");

        private static void page_size_set(System.IntPtr obj, System.IntPtr pd, Eina.Size2D.NativeStruct size)
        {
            Eina.Log.Debug("function efl_ui_pager_page_size_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
        Eina.Size2D _in_size = size;
                            
                try
                {
                    ((Pager)wrapper).SetPageSize(_in_size);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_pager_page_size_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), size);
            }
        }

        private static efl_ui_pager_page_size_set_delegate efl_ui_pager_page_size_set_static_delegate;

        
        private delegate int efl_ui_pager_padding_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate int efl_ui_pager_padding_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_padding_get_api_delegate> efl_ui_pager_padding_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_padding_get_api_delegate>(Module, "efl_ui_pager_padding_get");

        private static int padding_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_pager_padding_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            int _ret_var = default(int);
                try
                {
                    _ret_var = ((Pager)wrapper).GetPadding();
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
                return efl_ui_pager_padding_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_pager_padding_get_delegate efl_ui_pager_padding_get_static_delegate;

        
        private delegate void efl_ui_pager_padding_set_delegate(System.IntPtr obj, System.IntPtr pd,  int padding);

        
        public delegate void efl_ui_pager_padding_set_api_delegate(System.IntPtr obj,  int padding);

        public static Efl.Eo.FunctionWrapper<efl_ui_pager_padding_set_api_delegate> efl_ui_pager_padding_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_pager_padding_set_api_delegate>(Module, "efl_ui_pager_padding_set");

        private static void padding_set(System.IntPtr obj, System.IntPtr pd, int padding)
        {
            Eina.Log.Debug("function efl_ui_pager_padding_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((Pager)wrapper).SetPadding(padding);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_pager_padding_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), padding);
            }
        }

        private static efl_ui_pager_padding_set_delegate efl_ui_pager_padding_set_static_delegate;

        
        private delegate void efl_pack_align_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double align_horiz,  out double align_vert);

        
        public delegate void efl_pack_align_get_api_delegate(System.IntPtr obj,  out double align_horiz,  out double align_vert);

        public static Efl.Eo.FunctionWrapper<efl_pack_align_get_api_delegate> efl_pack_align_get_ptr = new Efl.Eo.FunctionWrapper<efl_pack_align_get_api_delegate>(Module, "efl_pack_align_get");

        private static void pack_align_get(System.IntPtr obj, System.IntPtr pd, out double align_horiz, out double align_vert)
        {
            Eina.Log.Debug("function efl_pack_align_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                        align_horiz = default(double);        align_vert = default(double);                            
                try
                {
                    ((Pager)wrapper).GetPackAlign(out align_horiz, out align_vert);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_pack_align_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out align_horiz, out align_vert);
            }
        }

        private static efl_pack_align_get_delegate efl_pack_align_get_static_delegate;

        
        private delegate void efl_pack_align_set_delegate(System.IntPtr obj, System.IntPtr pd,  double align_horiz,  double align_vert);

        
        public delegate void efl_pack_align_set_api_delegate(System.IntPtr obj,  double align_horiz,  double align_vert);

        public static Efl.Eo.FunctionWrapper<efl_pack_align_set_api_delegate> efl_pack_align_set_ptr = new Efl.Eo.FunctionWrapper<efl_pack_align_set_api_delegate>(Module, "efl_pack_align_set");

        private static void pack_align_set(System.IntPtr obj, System.IntPtr pd, double align_horiz, double align_vert)
        {
            Eina.Log.Debug("function efl_pack_align_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            
                try
                {
                    ((Pager)wrapper).SetPackAlign(align_horiz, align_vert);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_pack_align_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), align_horiz, align_vert);
            }
        }

        private static efl_pack_align_set_delegate efl_pack_align_set_static_delegate;

        
        private delegate void efl_pack_padding_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double pad_horiz,  out double pad_vert, [MarshalAs(UnmanagedType.U1)] out bool scalable);

        
        public delegate void efl_pack_padding_get_api_delegate(System.IntPtr obj,  out double pad_horiz,  out double pad_vert, [MarshalAs(UnmanagedType.U1)] out bool scalable);

        public static Efl.Eo.FunctionWrapper<efl_pack_padding_get_api_delegate> efl_pack_padding_get_ptr = new Efl.Eo.FunctionWrapper<efl_pack_padding_get_api_delegate>(Module, "efl_pack_padding_get");

        private static void pack_padding_get(System.IntPtr obj, System.IntPtr pd, out double pad_horiz, out double pad_vert, out bool scalable)
        {
            Eina.Log.Debug("function efl_pack_padding_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                pad_horiz = default(double);        pad_vert = default(double);        scalable = default(bool);                                    
                try
                {
                    ((Pager)wrapper).GetPackPadding(out pad_horiz, out pad_vert, out scalable);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                                        
            }
            else
            {
                efl_pack_padding_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out pad_horiz, out pad_vert, out scalable);
            }
        }

        private static efl_pack_padding_get_delegate efl_pack_padding_get_static_delegate;

        
        private delegate void efl_pack_padding_set_delegate(System.IntPtr obj, System.IntPtr pd,  double pad_horiz,  double pad_vert, [MarshalAs(UnmanagedType.U1)] bool scalable);

        
        public delegate void efl_pack_padding_set_api_delegate(System.IntPtr obj,  double pad_horiz,  double pad_vert, [MarshalAs(UnmanagedType.U1)] bool scalable);

        public static Efl.Eo.FunctionWrapper<efl_pack_padding_set_api_delegate> efl_pack_padding_set_ptr = new Efl.Eo.FunctionWrapper<efl_pack_padding_set_api_delegate>(Module, "efl_pack_padding_set");

        private static void pack_padding_set(System.IntPtr obj, System.IntPtr pd, double pad_horiz, double pad_vert, bool scalable)
        {
            Eina.Log.Debug("function efl_pack_padding_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                                                    
                try
                {
                    ((Pager)wrapper).SetPackPadding(pad_horiz, pad_vert, scalable);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                                        
            }
            else
            {
                efl_pack_padding_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), pad_horiz, pad_vert, scalable);
            }
        }

        private static efl_pack_padding_set_delegate efl_pack_padding_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_clear_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_clear_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_pack_clear_api_delegate> efl_pack_clear_ptr = new Efl.Eo.FunctionWrapper<efl_pack_clear_api_delegate>(Module, "efl_pack_clear");

        private static bool pack_clear(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_pack_clear was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).ClearPack();
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
                return efl_pack_clear_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_pack_clear_delegate efl_pack_clear_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_unpack_all_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_unpack_all_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_pack_unpack_all_api_delegate> efl_pack_unpack_all_ptr = new Efl.Eo.FunctionWrapper<efl_pack_unpack_all_api_delegate>(Module, "efl_pack_unpack_all");

        private static bool unpack_all(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_pack_unpack_all was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).UnpackAll();
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
                return efl_pack_unpack_all_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_pack_unpack_all_delegate efl_pack_unpack_all_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_unpack_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_unpack_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        public static Efl.Eo.FunctionWrapper<efl_pack_unpack_api_delegate> efl_pack_unpack_ptr = new Efl.Eo.FunctionWrapper<efl_pack_unpack_api_delegate>(Module, "efl_pack_unpack");

        private static bool unpack(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj)
        {
            Eina.Log.Debug("function efl_pack_unpack was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).Unpack(subobj);
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
                return efl_pack_unpack_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj);
            }
        }

        private static efl_pack_unpack_delegate efl_pack_unpack_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        public static Efl.Eo.FunctionWrapper<efl_pack_api_delegate> efl_pack_ptr = new Efl.Eo.FunctionWrapper<efl_pack_api_delegate>(Module, "efl_pack");

        private static bool pack(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj)
        {
            Eina.Log.Debug("function efl_pack was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).Pack(subobj);
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
                return efl_pack_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj);
            }
        }

        private static efl_pack_delegate efl_pack_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_begin_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_begin_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        public static Efl.Eo.FunctionWrapper<efl_pack_begin_api_delegate> efl_pack_begin_ptr = new Efl.Eo.FunctionWrapper<efl_pack_begin_api_delegate>(Module, "efl_pack_begin");

        private static bool pack_begin(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj)
        {
            Eina.Log.Debug("function efl_pack_begin was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).PackBegin(subobj);
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
                return efl_pack_begin_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj);
            }
        }

        private static efl_pack_begin_delegate efl_pack_begin_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_end_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_end_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        public static Efl.Eo.FunctionWrapper<efl_pack_end_api_delegate> efl_pack_end_ptr = new Efl.Eo.FunctionWrapper<efl_pack_end_api_delegate>(Module, "efl_pack_end");

        private static bool pack_end(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj)
        {
            Eina.Log.Debug("function efl_pack_end was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).PackEnd(subobj);
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
                return efl_pack_end_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj);
            }
        }

        private static efl_pack_end_delegate efl_pack_end_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_before_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity existing);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_before_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity existing);

        public static Efl.Eo.FunctionWrapper<efl_pack_before_api_delegate> efl_pack_before_ptr = new Efl.Eo.FunctionWrapper<efl_pack_before_api_delegate>(Module, "efl_pack_before");

        private static bool pack_before(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj, Efl.Gfx.IEntity existing)
        {
            Eina.Log.Debug("function efl_pack_before was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).PackBefore(subobj, existing);
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
                return efl_pack_before_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj, existing);
            }
        }

        private static efl_pack_before_delegate efl_pack_before_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_after_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity existing);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_after_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity existing);

        public static Efl.Eo.FunctionWrapper<efl_pack_after_api_delegate> efl_pack_after_ptr = new Efl.Eo.FunctionWrapper<efl_pack_after_api_delegate>(Module, "efl_pack_after");

        private static bool pack_after(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj, Efl.Gfx.IEntity existing)
        {
            Eina.Log.Debug("function efl_pack_after was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).PackAfter(subobj, existing);
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
                return efl_pack_after_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj, existing);
            }
        }

        private static efl_pack_after_delegate efl_pack_after_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_pack_at_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj,  int index);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_pack_at_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj,  int index);

        public static Efl.Eo.FunctionWrapper<efl_pack_at_api_delegate> efl_pack_at_ptr = new Efl.Eo.FunctionWrapper<efl_pack_at_api_delegate>(Module, "efl_pack_at");

        private static bool pack_at(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj, int index)
        {
            Eina.Log.Debug("function efl_pack_at was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((Pager)wrapper).PackAt(subobj, index);
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
                return efl_pack_at_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj, index);
            }
        }

        private static efl_pack_at_delegate efl_pack_at_static_delegate;

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Gfx.IEntity efl_pack_content_get_delegate(System.IntPtr obj, System.IntPtr pd,  int index);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Gfx.IEntity efl_pack_content_get_api_delegate(System.IntPtr obj,  int index);

        public static Efl.Eo.FunctionWrapper<efl_pack_content_get_api_delegate> efl_pack_content_get_ptr = new Efl.Eo.FunctionWrapper<efl_pack_content_get_api_delegate>(Module, "efl_pack_content_get");

        private static Efl.Gfx.IEntity pack_content_get(System.IntPtr obj, System.IntPtr pd, int index)
        {
            Eina.Log.Debug("function efl_pack_content_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    Efl.Gfx.IEntity _ret_var = default(Efl.Gfx.IEntity);
                try
                {
                    _ret_var = ((Pager)wrapper).GetPackContent(index);
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
                return efl_pack_content_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), index);
            }
        }

        private static efl_pack_content_get_delegate efl_pack_content_get_static_delegate;

        
        private delegate int efl_pack_index_get_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        
        public delegate int efl_pack_index_get_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj);

        public static Efl.Eo.FunctionWrapper<efl_pack_index_get_api_delegate> efl_pack_index_get_ptr = new Efl.Eo.FunctionWrapper<efl_pack_index_get_api_delegate>(Module, "efl_pack_index_get");

        private static int pack_index_get(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj)
        {
            Eina.Log.Debug("function efl_pack_index_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    int _ret_var = default(int);
                try
                {
                    _ret_var = ((Pager)wrapper).GetPackIndex(subobj);
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
                return efl_pack_index_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj);
            }
        }

        private static efl_pack_index_get_delegate efl_pack_index_get_static_delegate;

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Gfx.IEntity efl_pack_unpack_at_delegate(System.IntPtr obj, System.IntPtr pd,  int index);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Gfx.IEntity efl_pack_unpack_at_api_delegate(System.IntPtr obj,  int index);

        public static Efl.Eo.FunctionWrapper<efl_pack_unpack_at_api_delegate> efl_pack_unpack_at_ptr = new Efl.Eo.FunctionWrapper<efl_pack_unpack_at_api_delegate>(Module, "efl_pack_unpack_at");

        private static Efl.Gfx.IEntity pack_unpack_at(System.IntPtr obj, System.IntPtr pd, int index)
        {
            Eina.Log.Debug("function efl_pack_unpack_at was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    Efl.Gfx.IEntity _ret_var = default(Efl.Gfx.IEntity);
                try
                {
                    _ret_var = ((Pager)wrapper).PackUnpackAt(index);
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
                return efl_pack_unpack_at_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), index);
            }
        }

        private static efl_pack_unpack_at_delegate efl_pack_unpack_at_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

namespace Efl {

namespace Ui {

/// <summary>Efl ui pager loop mode</summary>
public enum PagerLoop
{
Disabled = 0,
Enabled = 1,
}

}

}

