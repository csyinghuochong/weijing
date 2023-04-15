#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R>
struct VirtFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3>
struct VirtActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct VirtFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericVirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3>
struct GenericVirtActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
struct GenericVirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct GenericVirtFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct GenericVirtFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1>
struct GenericVirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct InterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3>
struct InterfaceActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct InterfaceFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct InterfaceFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericInterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3>
struct GenericInterfaceActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
struct GenericInterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct GenericInterfaceFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct GenericInterfaceFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1>
struct GenericInterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};

// System.Collections.Generic.Dictionary`2<System.Int32,System.Globalization.CultureInfo>
struct Dictionary_2_t5B8303F2C9869A39ED3E03C0FBB09F817E479402;
// System.Collections.Generic.Dictionary`2<System.String,System.Globalization.CultureInfo>
struct Dictionary_2_t0015CBF964B0687CBB5ECFDDE06671A8F3DDE4BC;
// UnityEngine.Events.UnityEvent`1<System.Int32>
struct UnityEvent_1_tB235B5DAD099AC425DC059D10DEB8B97A35E2BBF;
// UnityEngine.Events.UnityEvent`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>
struct UnityEvent_1_t5380899C55F3CD7FD1CD64F13EE5E1E4B11D602B;
// UnityEngine.Events.UnityEvent`1<System.Object>
struct UnityEvent_1_t32063FE815890FF672DF76288FAC4ABE089B899F;
// System.Collections.Generic.KeyValuePair`2<System.Byte[],System.Text.Encoding>[]
struct KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7;
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// UnityEngine.Light[]
struct LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9;
// UnityEngine.Mesh[]
struct MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
// System.ArgumentNullException
struct ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// System.Attribute
struct Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71;
// UnityEngine.Rendering.BatchRendererGroup
struct BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A;
// System.Byte
struct Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056;
// System.Globalization.Calendar
struct Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A;
// UnityEngine.Camera
struct Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C;
// System.Globalization.CodePageDataItem
struct CodePageDataItem_t09A62F57142BF0456C8F414898A37E79BCC9F09E;
// System.Globalization.CompareInfo
struct CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9;
// System.Globalization.CultureData
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529;
// System.Globalization.CultureInfo
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98;
// UnityEngine.CustomYieldInstruction
struct CustomYieldInstruction_t4ED1543FBAA3143362854EB1867B42E5D190A5C7;
// System.Globalization.DateTimeFormatInfo
struct DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90;
// System.Text.DecoderFallback
struct DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D;
// System.Text.DecoderReplacementFallback
struct DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.Text.EncoderFallback
struct EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4;
// System.Text.EncoderReplacementFallback
struct EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418;
// System.Text.Encoding
struct Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827;
// System.Threading.EventWaitHandle
struct EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C;
// System.Exception
struct Exception_t;
// System.Collections.Hashtable
struct Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.IFormatProvider
struct IFormatProvider_tF2AECC4B14F41D36718920D67F930CED940412DF;
// System.IndexOutOfRangeException
struct IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD;
// System.IntPtr
struct IntPtr_t;
// System.InvalidOperationException
struct InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB;
// UnityEngine.Events.InvokableCallList
struct InvokableCallList_tB7C66AA0C00F9C102C8BDC17A144E569AC7527A9;
// UnityEngine.Light
struct Light_tA2F349FE839781469A0344CF6039B51512394275;
// System.Threading.ManualResetEvent
struct ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA;
// UnityEngine.Mesh
struct Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6;
// UnityEngine.Networking.PlayerConnection.MessageEventArgs
struct MessageEventArgs_t6905F6AA12A37C5A38BBCB907E9215622364DCCA;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Globalization.NumberFormatInfo
struct NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D;
// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A;
// UnityEngine.Events.PersistentCallGroup
struct PersistentCallGroup_t9A1D83DA2BA3118C103FA87D93CE92557A956FDC;
// System.Security.Cryptography.RandomNumberGenerator
struct RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50;
// UnityEngine.RectTransform
struct RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072;
// UnityEngine.RenderTexture
struct RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// Microsoft.Win32.SafeHandles.SafeWaitHandle
struct SafeWaitHandle_tF37EACEDF9C6F350EB4ABC1E1F869EECB0B5ABB1;
// System.Threading.SendOrPostCallback
struct SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C;
// System.String
struct String_t;
// System.Globalization.TextInfo
struct TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C;
// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1;
// System.UInt32
struct UInt32_tE60352A06233E4E69DD198BCC67142159F686B15;
// System.UInt64
struct UInt64_tEC57511B3E3CA2DBA1BEBD434C6983E31C943281;
// System.Text.UTF32Encoding
struct UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014;
// System.Text.UTF8Encoding
struct UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282;
// System.Text.UnicodeEncoding
struct UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68;
// UnityEngine.Events.UnityAction
struct UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.WaitForEndOfFrame
struct WaitForEndOfFrame_t082FDFEAAFF92937632C357C39E55C84B8FD06D4;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013;
// UnityEngine.WaitForSecondsRealtime
struct WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40;
// Unity.Collections.LowLevel.Unsafe.WriteAccessRequiredAttribute
struct WriteAccessRequiredAttribute_t801D798894A40E3789DE39CC4BE0D3B04B852DCA;
// UnityEngine.YieldInstruction
struct YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF;
// UnityEngine.Application/AdvertisingIdentifierCallback
struct AdvertisingIdentifierCallback_t718F15DCE2CA38B886F324F079A4B41774A3042B;
// UnityEngine.Application/LogCallback
struct LogCallback_t8C3C9B1E0F185E2A25D09DE10DD8414898698BBD;
// UnityEngine.Application/LowMemoryCallback
struct LowMemoryCallback_tF94AC614EDACA9AD4CEA3DE77FF8EFF5DA1E5240;
// UnityEngine.Rendering.BatchRendererGroup/OnPerformCulling
struct OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB;
// UnityEngine.Camera/CameraCallback
struct CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D;
// UnityEngine.CullingGroup/StateChanged
struct StateChanged_tAE96F0A8860BFCD704179F6C1F376A6FAE3E25E0;
// UnityEngine.Display/DisplaysUpdatedDelegate
struct DisplaysUpdatedDelegate_tC6A6AD44FAD98C9E28479FFF4BD3D9932458A6A1;
// Unity.Jobs.LowLevel.Unsafe.JobsUtility/PanicFunction_
struct PanicFunction__tFB4D850E5B848FFEF210623F5669284D723544EB;
// UnityEngine.Experimental.GlobalIllumination.Lightmapping/<>c
struct U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826;
// UnityEngine.Experimental.GlobalIllumination.Lightmapping/RequestLightsDelegate
struct RequestLightsDelegate_t48C36AFA6015405AE4069BB1F3623AF3BC51FDA0;
// UnityEngine.Playables.PlayableBinding/CreateOutputMethod
struct CreateOutputMethod_t7A129D00E8823B50AEDD0C9B082C9CB3DF863876;
// UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass12_0
struct U3CU3Ec__DisplayClass12_0_tC029C4F11E384EFEF6FD86B7BEC83D295D098769;
// UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass13_0
struct U3CU3Ec__DisplayClass13_0_t1A8EBE4E3370D09549DE4FD59077B3A7AEAD0C54;
// UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass20_0
struct U3CU3Ec__DisplayClass20_0_tEA47E236E3FCEC75772DAF52911B35E8F14766DD;
// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass6_0
struct U3CU3Ec__DisplayClass6_0_t96633FB6A2AE351A4A3FCDF89D10891DA07AD54F;
// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass7_0
struct U3CU3Ec__DisplayClass7_0_t7C625D285CBB757F88C0232D12D88EDABF06EB60;
// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass8_0
struct U3CU3Ec__DisplayClass8_0_tE64E7CAC5415DCD425D14A6062600087CC872B93;
// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/ConnectionChangeEvent
struct ConnectionChangeEvent_tCA1C8C14171C72EC394EF45450D69C1585067BDF;
// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageEvent
struct MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B;
// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers
struct MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F;
// UnityEngine.LowLevel.PlayerLoopSystem/UpdateFunction
struct UpdateFunction_tEDC2A88F61F179480CAA9443E6ADDA3F126B8AEA;
// UnityEngine.RectTransform/ReapplyDrivenProperties
struct ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE;
// UnityEngine.Transform/Enumerator
struct Enumerator_t8A0B2200373BC9628C065322A1BA07AAA47E0259;

IL2CPP_EXTERN_C RuntimeClass* ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Guid_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Light_tA2F349FE839781469A0344CF6039B51512394275_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* LogType_tF490DBF8368BD4EBA703B2824CB76A853820F773_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* VertexAttributeFormat_tE5FC93A96237AAF63142B0E521925CAE4F283485_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* VertexAttribute_t9B763063E3B1705070D4DB8BC32F21F0FB30867C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral2956576D4D7B715600E40D140A87CD9FCBAF2307;
IL2CPP_EXTERN_C String_t* _stringLiteral2AAF6C7A90E58D7205596DC636D6A02BDB914696;
IL2CPP_EXTERN_C String_t* _stringLiteral3F9A41AFB2F37B2A341E596DC86390141A92BF03;
IL2CPP_EXTERN_C String_t* _stringLiteral40603CB9C3C2F0F007BD4C59CEB195FB17927F5C;
IL2CPP_EXTERN_C String_t* _stringLiteral4DA40F86FA6B66D1B6831F82ADF65BBE193ABB05;
IL2CPP_EXTERN_C String_t* _stringLiteralB23C3717573626FB4C3C7DF5C19EDE7689837214;
IL2CPP_EXTERN_C String_t* _stringLiteralB54D393654F24720778CBD1865ACD7D51485886C;
IL2CPP_EXTERN_C String_t* _stringLiteralB8F710F417E2D96E747683BF53A8CA9BB6B9648C;
IL2CPP_EXTERN_C String_t* _stringLiteralC613D4D2FE3F5D74727D376F793286A2BCBB1391;
IL2CPP_EXTERN_C String_t* _stringLiteralD79748BAD21E0600896A37452D2DDED1006AA1B1;
IL2CPP_EXTERN_C String_t* _stringLiteralDA7AEF839C310E50649FABCB16048EC805ED1DCF;
IL2CPP_EXTERN_C String_t* _stringLiteralE7731045AD45AF27C2F5E740C1F6CAF61BFD563E;
IL2CPP_EXTERN_C String_t* _stringLiteralEB0A157666700D8227FD4B66A26FDC02035E89BF;
IL2CPP_EXTERN_C String_t* _stringLiteralEC5621377AD9B4098EC3FB34AF35BAA9E6C07B64;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MeshDataArray_ApplyToMeshAndDispose_m387C3268D1678D98A4387A19E3309C53EAB5DB93_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MeshDataArray_ApplyToMeshesAndDispose_m8C732EB6A9EF32119A0F6AF1C2E157466669E74A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MeshDataArray__ctor_mD35379B2DF108964E9721D9062A82DE52C344D02_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MeshDataArray__ctor_mF40C97EC8A5377A058E86FE10773C7EC437D0BAB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MeshDataArray__ctor_mF8939F58B78C2693235E3FE9143637404EB1A0D0_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* UnityEvent_1__ctor_m30F443398054B5E3666B3C86E64A5C0FF97D93FF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* UnityEvent_1__ctor_mC7E63F58C7EFC8E8747E3619B7564A7325F03D3B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Vector4_get_Item_m469B9D88498D0F7CD14B71A9512915BAA0B9B3B7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Vector4_set_Item_m7552B288FF218CA023F0DFB971BBA30D0362006A_RuntimeMethod_var;
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529_marshaled_com;
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529_marshaled_pinvoke;
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_com;
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_pinvoke;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7;
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
struct LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9;
struct MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8;
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

struct Il2CppArrayBounds;

// System.Array


// System.Attribute
struct Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71  : public RuntimeObject
{
public:

public:
};


// System.Globalization.CultureInfo
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98  : public RuntimeObject
{
public:
	// System.Boolean System.Globalization.CultureInfo::m_isReadOnly
	bool ___m_isReadOnly_3;
	// System.Int32 System.Globalization.CultureInfo::cultureID
	int32_t ___cultureID_4;
	// System.Int32 System.Globalization.CultureInfo::parent_lcid
	int32_t ___parent_lcid_5;
	// System.Int32 System.Globalization.CultureInfo::datetime_index
	int32_t ___datetime_index_6;
	// System.Int32 System.Globalization.CultureInfo::number_index
	int32_t ___number_index_7;
	// System.Int32 System.Globalization.CultureInfo::default_calendar_type
	int32_t ___default_calendar_type_8;
	// System.Boolean System.Globalization.CultureInfo::m_useUserOverride
	bool ___m_useUserOverride_9;
	// System.Globalization.NumberFormatInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::numInfo
	NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * ___numInfo_10;
	// System.Globalization.DateTimeFormatInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::dateTimeInfo
	DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90 * ___dateTimeInfo_11;
	// System.Globalization.TextInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::textInfo
	TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C * ___textInfo_12;
	// System.String System.Globalization.CultureInfo::m_name
	String_t* ___m_name_13;
	// System.String System.Globalization.CultureInfo::englishname
	String_t* ___englishname_14;
	// System.String System.Globalization.CultureInfo::nativename
	String_t* ___nativename_15;
	// System.String System.Globalization.CultureInfo::iso3lang
	String_t* ___iso3lang_16;
	// System.String System.Globalization.CultureInfo::iso2lang
	String_t* ___iso2lang_17;
	// System.String System.Globalization.CultureInfo::win3lang
	String_t* ___win3lang_18;
	// System.String System.Globalization.CultureInfo::territory
	String_t* ___territory_19;
	// System.String[] System.Globalization.CultureInfo::native_calendar_names
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___native_calendar_names_20;
	// System.Globalization.CompareInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::compareInfo
	CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9 * ___compareInfo_21;
	// System.Void* System.Globalization.CultureInfo::textinfo_data
	void* ___textinfo_data_22;
	// System.Int32 System.Globalization.CultureInfo::m_dataItem
	int32_t ___m_dataItem_23;
	// System.Globalization.Calendar System.Globalization.CultureInfo::calendar
	Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A * ___calendar_24;
	// System.Globalization.CultureInfo System.Globalization.CultureInfo::parent_culture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___parent_culture_25;
	// System.Boolean System.Globalization.CultureInfo::constructed
	bool ___constructed_26;
	// System.Byte[] System.Globalization.CultureInfo::cached_serialized_form
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___cached_serialized_form_27;
	// System.Globalization.CultureData System.Globalization.CultureInfo::m_cultureData
	CultureData_t53CDF1C5F789A28897415891667799420D3C5529 * ___m_cultureData_28;
	// System.Boolean System.Globalization.CultureInfo::m_isInherited
	bool ___m_isInherited_29;

public:
	inline static int32_t get_offset_of_m_isReadOnly_3() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___m_isReadOnly_3)); }
	inline bool get_m_isReadOnly_3() const { return ___m_isReadOnly_3; }
	inline bool* get_address_of_m_isReadOnly_3() { return &___m_isReadOnly_3; }
	inline void set_m_isReadOnly_3(bool value)
	{
		___m_isReadOnly_3 = value;
	}

	inline static int32_t get_offset_of_cultureID_4() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___cultureID_4)); }
	inline int32_t get_cultureID_4() const { return ___cultureID_4; }
	inline int32_t* get_address_of_cultureID_4() { return &___cultureID_4; }
	inline void set_cultureID_4(int32_t value)
	{
		___cultureID_4 = value;
	}

	inline static int32_t get_offset_of_parent_lcid_5() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___parent_lcid_5)); }
	inline int32_t get_parent_lcid_5() const { return ___parent_lcid_5; }
	inline int32_t* get_address_of_parent_lcid_5() { return &___parent_lcid_5; }
	inline void set_parent_lcid_5(int32_t value)
	{
		___parent_lcid_5 = value;
	}

	inline static int32_t get_offset_of_datetime_index_6() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___datetime_index_6)); }
	inline int32_t get_datetime_index_6() const { return ___datetime_index_6; }
	inline int32_t* get_address_of_datetime_index_6() { return &___datetime_index_6; }
	inline void set_datetime_index_6(int32_t value)
	{
		___datetime_index_6 = value;
	}

	inline static int32_t get_offset_of_number_index_7() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___number_index_7)); }
	inline int32_t get_number_index_7() const { return ___number_index_7; }
	inline int32_t* get_address_of_number_index_7() { return &___number_index_7; }
	inline void set_number_index_7(int32_t value)
	{
		___number_index_7 = value;
	}

	inline static int32_t get_offset_of_default_calendar_type_8() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___default_calendar_type_8)); }
	inline int32_t get_default_calendar_type_8() const { return ___default_calendar_type_8; }
	inline int32_t* get_address_of_default_calendar_type_8() { return &___default_calendar_type_8; }
	inline void set_default_calendar_type_8(int32_t value)
	{
		___default_calendar_type_8 = value;
	}

	inline static int32_t get_offset_of_m_useUserOverride_9() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___m_useUserOverride_9)); }
	inline bool get_m_useUserOverride_9() const { return ___m_useUserOverride_9; }
	inline bool* get_address_of_m_useUserOverride_9() { return &___m_useUserOverride_9; }
	inline void set_m_useUserOverride_9(bool value)
	{
		___m_useUserOverride_9 = value;
	}

	inline static int32_t get_offset_of_numInfo_10() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___numInfo_10)); }
	inline NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * get_numInfo_10() const { return ___numInfo_10; }
	inline NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D ** get_address_of_numInfo_10() { return &___numInfo_10; }
	inline void set_numInfo_10(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * value)
	{
		___numInfo_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___numInfo_10), (void*)value);
	}

	inline static int32_t get_offset_of_dateTimeInfo_11() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___dateTimeInfo_11)); }
	inline DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90 * get_dateTimeInfo_11() const { return ___dateTimeInfo_11; }
	inline DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90 ** get_address_of_dateTimeInfo_11() { return &___dateTimeInfo_11; }
	inline void set_dateTimeInfo_11(DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90 * value)
	{
		___dateTimeInfo_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dateTimeInfo_11), (void*)value);
	}

	inline static int32_t get_offset_of_textInfo_12() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___textInfo_12)); }
	inline TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C * get_textInfo_12() const { return ___textInfo_12; }
	inline TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C ** get_address_of_textInfo_12() { return &___textInfo_12; }
	inline void set_textInfo_12(TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C * value)
	{
		___textInfo_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___textInfo_12), (void*)value);
	}

	inline static int32_t get_offset_of_m_name_13() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___m_name_13)); }
	inline String_t* get_m_name_13() const { return ___m_name_13; }
	inline String_t** get_address_of_m_name_13() { return &___m_name_13; }
	inline void set_m_name_13(String_t* value)
	{
		___m_name_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_name_13), (void*)value);
	}

	inline static int32_t get_offset_of_englishname_14() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___englishname_14)); }
	inline String_t* get_englishname_14() const { return ___englishname_14; }
	inline String_t** get_address_of_englishname_14() { return &___englishname_14; }
	inline void set_englishname_14(String_t* value)
	{
		___englishname_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___englishname_14), (void*)value);
	}

	inline static int32_t get_offset_of_nativename_15() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___nativename_15)); }
	inline String_t* get_nativename_15() const { return ___nativename_15; }
	inline String_t** get_address_of_nativename_15() { return &___nativename_15; }
	inline void set_nativename_15(String_t* value)
	{
		___nativename_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___nativename_15), (void*)value);
	}

	inline static int32_t get_offset_of_iso3lang_16() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___iso3lang_16)); }
	inline String_t* get_iso3lang_16() const { return ___iso3lang_16; }
	inline String_t** get_address_of_iso3lang_16() { return &___iso3lang_16; }
	inline void set_iso3lang_16(String_t* value)
	{
		___iso3lang_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___iso3lang_16), (void*)value);
	}

	inline static int32_t get_offset_of_iso2lang_17() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___iso2lang_17)); }
	inline String_t* get_iso2lang_17() const { return ___iso2lang_17; }
	inline String_t** get_address_of_iso2lang_17() { return &___iso2lang_17; }
	inline void set_iso2lang_17(String_t* value)
	{
		___iso2lang_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___iso2lang_17), (void*)value);
	}

	inline static int32_t get_offset_of_win3lang_18() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___win3lang_18)); }
	inline String_t* get_win3lang_18() const { return ___win3lang_18; }
	inline String_t** get_address_of_win3lang_18() { return &___win3lang_18; }
	inline void set_win3lang_18(String_t* value)
	{
		___win3lang_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___win3lang_18), (void*)value);
	}

	inline static int32_t get_offset_of_territory_19() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___territory_19)); }
	inline String_t* get_territory_19() const { return ___territory_19; }
	inline String_t** get_address_of_territory_19() { return &___territory_19; }
	inline void set_territory_19(String_t* value)
	{
		___territory_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___territory_19), (void*)value);
	}

	inline static int32_t get_offset_of_native_calendar_names_20() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___native_calendar_names_20)); }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* get_native_calendar_names_20() const { return ___native_calendar_names_20; }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** get_address_of_native_calendar_names_20() { return &___native_calendar_names_20; }
	inline void set_native_calendar_names_20(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* value)
	{
		___native_calendar_names_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___native_calendar_names_20), (void*)value);
	}

	inline static int32_t get_offset_of_compareInfo_21() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___compareInfo_21)); }
	inline CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9 * get_compareInfo_21() const { return ___compareInfo_21; }
	inline CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9 ** get_address_of_compareInfo_21() { return &___compareInfo_21; }
	inline void set_compareInfo_21(CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9 * value)
	{
		___compareInfo_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___compareInfo_21), (void*)value);
	}

	inline static int32_t get_offset_of_textinfo_data_22() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___textinfo_data_22)); }
	inline void* get_textinfo_data_22() const { return ___textinfo_data_22; }
	inline void** get_address_of_textinfo_data_22() { return &___textinfo_data_22; }
	inline void set_textinfo_data_22(void* value)
	{
		___textinfo_data_22 = value;
	}

	inline static int32_t get_offset_of_m_dataItem_23() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___m_dataItem_23)); }
	inline int32_t get_m_dataItem_23() const { return ___m_dataItem_23; }
	inline int32_t* get_address_of_m_dataItem_23() { return &___m_dataItem_23; }
	inline void set_m_dataItem_23(int32_t value)
	{
		___m_dataItem_23 = value;
	}

	inline static int32_t get_offset_of_calendar_24() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___calendar_24)); }
	inline Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A * get_calendar_24() const { return ___calendar_24; }
	inline Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A ** get_address_of_calendar_24() { return &___calendar_24; }
	inline void set_calendar_24(Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A * value)
	{
		___calendar_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___calendar_24), (void*)value);
	}

	inline static int32_t get_offset_of_parent_culture_25() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___parent_culture_25)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get_parent_culture_25() const { return ___parent_culture_25; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of_parent_culture_25() { return &___parent_culture_25; }
	inline void set_parent_culture_25(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		___parent_culture_25 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___parent_culture_25), (void*)value);
	}

	inline static int32_t get_offset_of_constructed_26() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___constructed_26)); }
	inline bool get_constructed_26() const { return ___constructed_26; }
	inline bool* get_address_of_constructed_26() { return &___constructed_26; }
	inline void set_constructed_26(bool value)
	{
		___constructed_26 = value;
	}

	inline static int32_t get_offset_of_cached_serialized_form_27() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___cached_serialized_form_27)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_cached_serialized_form_27() const { return ___cached_serialized_form_27; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_cached_serialized_form_27() { return &___cached_serialized_form_27; }
	inline void set_cached_serialized_form_27(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___cached_serialized_form_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___cached_serialized_form_27), (void*)value);
	}

	inline static int32_t get_offset_of_m_cultureData_28() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___m_cultureData_28)); }
	inline CultureData_t53CDF1C5F789A28897415891667799420D3C5529 * get_m_cultureData_28() const { return ___m_cultureData_28; }
	inline CultureData_t53CDF1C5F789A28897415891667799420D3C5529 ** get_address_of_m_cultureData_28() { return &___m_cultureData_28; }
	inline void set_m_cultureData_28(CultureData_t53CDF1C5F789A28897415891667799420D3C5529 * value)
	{
		___m_cultureData_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_cultureData_28), (void*)value);
	}

	inline static int32_t get_offset_of_m_isInherited_29() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98, ___m_isInherited_29)); }
	inline bool get_m_isInherited_29() const { return ___m_isInherited_29; }
	inline bool* get_address_of_m_isInherited_29() { return &___m_isInherited_29; }
	inline void set_m_isInherited_29(bool value)
	{
		___m_isInherited_29 = value;
	}
};

struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields
{
public:
	// System.Globalization.CultureInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::invariant_culture_info
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___invariant_culture_info_0;
	// System.Object System.Globalization.CultureInfo::shared_table_lock
	RuntimeObject * ___shared_table_lock_1;
	// System.Globalization.CultureInfo System.Globalization.CultureInfo::default_current_culture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___default_current_culture_2;
	// System.Globalization.CultureInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::s_DefaultThreadCurrentUICulture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___s_DefaultThreadCurrentUICulture_33;
	// System.Globalization.CultureInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::s_DefaultThreadCurrentCulture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___s_DefaultThreadCurrentCulture_34;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Globalization.CultureInfo> System.Globalization.CultureInfo::shared_by_number
	Dictionary_2_t5B8303F2C9869A39ED3E03C0FBB09F817E479402 * ___shared_by_number_35;
	// System.Collections.Generic.Dictionary`2<System.String,System.Globalization.CultureInfo> System.Globalization.CultureInfo::shared_by_name
	Dictionary_2_t0015CBF964B0687CBB5ECFDDE06671A8F3DDE4BC * ___shared_by_name_36;
	// System.Boolean System.Globalization.CultureInfo::IsTaiwanSku
	bool ___IsTaiwanSku_37;

public:
	inline static int32_t get_offset_of_invariant_culture_info_0() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields, ___invariant_culture_info_0)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get_invariant_culture_info_0() const { return ___invariant_culture_info_0; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of_invariant_culture_info_0() { return &___invariant_culture_info_0; }
	inline void set_invariant_culture_info_0(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		___invariant_culture_info_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___invariant_culture_info_0), (void*)value);
	}

	inline static int32_t get_offset_of_shared_table_lock_1() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields, ___shared_table_lock_1)); }
	inline RuntimeObject * get_shared_table_lock_1() const { return ___shared_table_lock_1; }
	inline RuntimeObject ** get_address_of_shared_table_lock_1() { return &___shared_table_lock_1; }
	inline void set_shared_table_lock_1(RuntimeObject * value)
	{
		___shared_table_lock_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___shared_table_lock_1), (void*)value);
	}

	inline static int32_t get_offset_of_default_current_culture_2() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields, ___default_current_culture_2)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get_default_current_culture_2() const { return ___default_current_culture_2; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of_default_current_culture_2() { return &___default_current_culture_2; }
	inline void set_default_current_culture_2(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		___default_current_culture_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___default_current_culture_2), (void*)value);
	}

	inline static int32_t get_offset_of_s_DefaultThreadCurrentUICulture_33() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields, ___s_DefaultThreadCurrentUICulture_33)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get_s_DefaultThreadCurrentUICulture_33() const { return ___s_DefaultThreadCurrentUICulture_33; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of_s_DefaultThreadCurrentUICulture_33() { return &___s_DefaultThreadCurrentUICulture_33; }
	inline void set_s_DefaultThreadCurrentUICulture_33(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		___s_DefaultThreadCurrentUICulture_33 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_DefaultThreadCurrentUICulture_33), (void*)value);
	}

	inline static int32_t get_offset_of_s_DefaultThreadCurrentCulture_34() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields, ___s_DefaultThreadCurrentCulture_34)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get_s_DefaultThreadCurrentCulture_34() const { return ___s_DefaultThreadCurrentCulture_34; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of_s_DefaultThreadCurrentCulture_34() { return &___s_DefaultThreadCurrentCulture_34; }
	inline void set_s_DefaultThreadCurrentCulture_34(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		___s_DefaultThreadCurrentCulture_34 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_DefaultThreadCurrentCulture_34), (void*)value);
	}

	inline static int32_t get_offset_of_shared_by_number_35() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields, ___shared_by_number_35)); }
	inline Dictionary_2_t5B8303F2C9869A39ED3E03C0FBB09F817E479402 * get_shared_by_number_35() const { return ___shared_by_number_35; }
	inline Dictionary_2_t5B8303F2C9869A39ED3E03C0FBB09F817E479402 ** get_address_of_shared_by_number_35() { return &___shared_by_number_35; }
	inline void set_shared_by_number_35(Dictionary_2_t5B8303F2C9869A39ED3E03C0FBB09F817E479402 * value)
	{
		___shared_by_number_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___shared_by_number_35), (void*)value);
	}

	inline static int32_t get_offset_of_shared_by_name_36() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields, ___shared_by_name_36)); }
	inline Dictionary_2_t0015CBF964B0687CBB5ECFDDE06671A8F3DDE4BC * get_shared_by_name_36() const { return ___shared_by_name_36; }
	inline Dictionary_2_t0015CBF964B0687CBB5ECFDDE06671A8F3DDE4BC ** get_address_of_shared_by_name_36() { return &___shared_by_name_36; }
	inline void set_shared_by_name_36(Dictionary_2_t0015CBF964B0687CBB5ECFDDE06671A8F3DDE4BC * value)
	{
		___shared_by_name_36 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___shared_by_name_36), (void*)value);
	}

	inline static int32_t get_offset_of_IsTaiwanSku_37() { return static_cast<int32_t>(offsetof(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_StaticFields, ___IsTaiwanSku_37)); }
	inline bool get_IsTaiwanSku_37() const { return ___IsTaiwanSku_37; }
	inline bool* get_address_of_IsTaiwanSku_37() { return &___IsTaiwanSku_37; }
	inline void set_IsTaiwanSku_37(bool value)
	{
		___IsTaiwanSku_37 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Globalization.CultureInfo
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_pinvoke
{
	int32_t ___m_isReadOnly_3;
	int32_t ___cultureID_4;
	int32_t ___parent_lcid_5;
	int32_t ___datetime_index_6;
	int32_t ___number_index_7;
	int32_t ___default_calendar_type_8;
	int32_t ___m_useUserOverride_9;
	NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * ___numInfo_10;
	DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90 * ___dateTimeInfo_11;
	TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C * ___textInfo_12;
	char* ___m_name_13;
	char* ___englishname_14;
	char* ___nativename_15;
	char* ___iso3lang_16;
	char* ___iso2lang_17;
	char* ___win3lang_18;
	char* ___territory_19;
	char** ___native_calendar_names_20;
	CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9 * ___compareInfo_21;
	void* ___textinfo_data_22;
	int32_t ___m_dataItem_23;
	Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A * ___calendar_24;
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_pinvoke* ___parent_culture_25;
	int32_t ___constructed_26;
	Il2CppSafeArray/*NONE*/* ___cached_serialized_form_27;
	CultureData_t53CDF1C5F789A28897415891667799420D3C5529_marshaled_pinvoke* ___m_cultureData_28;
	int32_t ___m_isInherited_29;
};
// Native definition for COM marshalling of System.Globalization.CultureInfo
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_com
{
	int32_t ___m_isReadOnly_3;
	int32_t ___cultureID_4;
	int32_t ___parent_lcid_5;
	int32_t ___datetime_index_6;
	int32_t ___number_index_7;
	int32_t ___default_calendar_type_8;
	int32_t ___m_useUserOverride_9;
	NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * ___numInfo_10;
	DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90 * ___dateTimeInfo_11;
	TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C * ___textInfo_12;
	Il2CppChar* ___m_name_13;
	Il2CppChar* ___englishname_14;
	Il2CppChar* ___nativename_15;
	Il2CppChar* ___iso3lang_16;
	Il2CppChar* ___iso2lang_17;
	Il2CppChar* ___win3lang_18;
	Il2CppChar* ___territory_19;
	Il2CppChar** ___native_calendar_names_20;
	CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9 * ___compareInfo_21;
	void* ___textinfo_data_22;
	int32_t ___m_dataItem_23;
	Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A * ___calendar_24;
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_com* ___parent_culture_25;
	int32_t ___constructed_26;
	Il2CppSafeArray/*NONE*/* ___cached_serialized_form_27;
	CultureData_t53CDF1C5F789A28897415891667799420D3C5529_marshaled_com* ___m_cultureData_28;
	int32_t ___m_isInherited_29;
};

// UnityEngine.CustomYieldInstruction
struct CustomYieldInstruction_t4ED1543FBAA3143362854EB1867B42E5D190A5C7  : public RuntimeObject
{
public:

public:
};


// System.Text.DecoderFallback
struct DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D  : public RuntimeObject
{
public:
	// System.Boolean System.Text.DecoderFallback::bIsMicrosoftBestFitFallback
	bool ___bIsMicrosoftBestFitFallback_0;

public:
	inline static int32_t get_offset_of_bIsMicrosoftBestFitFallback_0() { return static_cast<int32_t>(offsetof(DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D, ___bIsMicrosoftBestFitFallback_0)); }
	inline bool get_bIsMicrosoftBestFitFallback_0() const { return ___bIsMicrosoftBestFitFallback_0; }
	inline bool* get_address_of_bIsMicrosoftBestFitFallback_0() { return &___bIsMicrosoftBestFitFallback_0; }
	inline void set_bIsMicrosoftBestFitFallback_0(bool value)
	{
		___bIsMicrosoftBestFitFallback_0 = value;
	}
};

struct DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D_StaticFields
{
public:
	// System.Text.DecoderFallback modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.DecoderFallback::replacementFallback
	DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * ___replacementFallback_1;
	// System.Text.DecoderFallback modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.DecoderFallback::exceptionFallback
	DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * ___exceptionFallback_2;
	// System.Object System.Text.DecoderFallback::s_InternalSyncObject
	RuntimeObject * ___s_InternalSyncObject_3;

public:
	inline static int32_t get_offset_of_replacementFallback_1() { return static_cast<int32_t>(offsetof(DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D_StaticFields, ___replacementFallback_1)); }
	inline DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * get_replacementFallback_1() const { return ___replacementFallback_1; }
	inline DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D ** get_address_of_replacementFallback_1() { return &___replacementFallback_1; }
	inline void set_replacementFallback_1(DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * value)
	{
		___replacementFallback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___replacementFallback_1), (void*)value);
	}

	inline static int32_t get_offset_of_exceptionFallback_2() { return static_cast<int32_t>(offsetof(DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D_StaticFields, ___exceptionFallback_2)); }
	inline DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * get_exceptionFallback_2() const { return ___exceptionFallback_2; }
	inline DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D ** get_address_of_exceptionFallback_2() { return &___exceptionFallback_2; }
	inline void set_exceptionFallback_2(DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * value)
	{
		___exceptionFallback_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___exceptionFallback_2), (void*)value);
	}

	inline static int32_t get_offset_of_s_InternalSyncObject_3() { return static_cast<int32_t>(offsetof(DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D_StaticFields, ___s_InternalSyncObject_3)); }
	inline RuntimeObject * get_s_InternalSyncObject_3() const { return ___s_InternalSyncObject_3; }
	inline RuntimeObject ** get_address_of_s_InternalSyncObject_3() { return &___s_InternalSyncObject_3; }
	inline void set_s_InternalSyncObject_3(RuntimeObject * value)
	{
		___s_InternalSyncObject_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_InternalSyncObject_3), (void*)value);
	}
};


// System.Text.EncoderFallback
struct EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4  : public RuntimeObject
{
public:
	// System.Boolean System.Text.EncoderFallback::bIsMicrosoftBestFitFallback
	bool ___bIsMicrosoftBestFitFallback_0;

public:
	inline static int32_t get_offset_of_bIsMicrosoftBestFitFallback_0() { return static_cast<int32_t>(offsetof(EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4, ___bIsMicrosoftBestFitFallback_0)); }
	inline bool get_bIsMicrosoftBestFitFallback_0() const { return ___bIsMicrosoftBestFitFallback_0; }
	inline bool* get_address_of_bIsMicrosoftBestFitFallback_0() { return &___bIsMicrosoftBestFitFallback_0; }
	inline void set_bIsMicrosoftBestFitFallback_0(bool value)
	{
		___bIsMicrosoftBestFitFallback_0 = value;
	}
};

struct EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4_StaticFields
{
public:
	// System.Text.EncoderFallback modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.EncoderFallback::replacementFallback
	EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * ___replacementFallback_1;
	// System.Text.EncoderFallback modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.EncoderFallback::exceptionFallback
	EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * ___exceptionFallback_2;
	// System.Object System.Text.EncoderFallback::s_InternalSyncObject
	RuntimeObject * ___s_InternalSyncObject_3;

public:
	inline static int32_t get_offset_of_replacementFallback_1() { return static_cast<int32_t>(offsetof(EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4_StaticFields, ___replacementFallback_1)); }
	inline EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * get_replacementFallback_1() const { return ___replacementFallback_1; }
	inline EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 ** get_address_of_replacementFallback_1() { return &___replacementFallback_1; }
	inline void set_replacementFallback_1(EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * value)
	{
		___replacementFallback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___replacementFallback_1), (void*)value);
	}

	inline static int32_t get_offset_of_exceptionFallback_2() { return static_cast<int32_t>(offsetof(EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4_StaticFields, ___exceptionFallback_2)); }
	inline EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * get_exceptionFallback_2() const { return ___exceptionFallback_2; }
	inline EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 ** get_address_of_exceptionFallback_2() { return &___exceptionFallback_2; }
	inline void set_exceptionFallback_2(EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * value)
	{
		___exceptionFallback_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___exceptionFallback_2), (void*)value);
	}

	inline static int32_t get_offset_of_s_InternalSyncObject_3() { return static_cast<int32_t>(offsetof(EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4_StaticFields, ___s_InternalSyncObject_3)); }
	inline RuntimeObject * get_s_InternalSyncObject_3() const { return ___s_InternalSyncObject_3; }
	inline RuntimeObject ** get_address_of_s_InternalSyncObject_3() { return &___s_InternalSyncObject_3; }
	inline void set_s_InternalSyncObject_3(RuntimeObject * value)
	{
		___s_InternalSyncObject_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_InternalSyncObject_3), (void*)value);
	}
};


// System.Text.Encoding
struct Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827  : public RuntimeObject
{
public:
	// System.Int32 System.Text.Encoding::m_codePage
	int32_t ___m_codePage_55;
	// System.Globalization.CodePageDataItem System.Text.Encoding::dataItem
	CodePageDataItem_t09A62F57142BF0456C8F414898A37E79BCC9F09E * ___dataItem_56;
	// System.Boolean System.Text.Encoding::m_deserializedFromEverett
	bool ___m_deserializedFromEverett_57;
	// System.Boolean System.Text.Encoding::m_isReadOnly
	bool ___m_isReadOnly_58;
	// System.Text.EncoderFallback System.Text.Encoding::encoderFallback
	EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * ___encoderFallback_59;
	// System.Text.DecoderFallback System.Text.Encoding::decoderFallback
	DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * ___decoderFallback_60;

public:
	inline static int32_t get_offset_of_m_codePage_55() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827, ___m_codePage_55)); }
	inline int32_t get_m_codePage_55() const { return ___m_codePage_55; }
	inline int32_t* get_address_of_m_codePage_55() { return &___m_codePage_55; }
	inline void set_m_codePage_55(int32_t value)
	{
		___m_codePage_55 = value;
	}

	inline static int32_t get_offset_of_dataItem_56() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827, ___dataItem_56)); }
	inline CodePageDataItem_t09A62F57142BF0456C8F414898A37E79BCC9F09E * get_dataItem_56() const { return ___dataItem_56; }
	inline CodePageDataItem_t09A62F57142BF0456C8F414898A37E79BCC9F09E ** get_address_of_dataItem_56() { return &___dataItem_56; }
	inline void set_dataItem_56(CodePageDataItem_t09A62F57142BF0456C8F414898A37E79BCC9F09E * value)
	{
		___dataItem_56 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dataItem_56), (void*)value);
	}

	inline static int32_t get_offset_of_m_deserializedFromEverett_57() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827, ___m_deserializedFromEverett_57)); }
	inline bool get_m_deserializedFromEverett_57() const { return ___m_deserializedFromEverett_57; }
	inline bool* get_address_of_m_deserializedFromEverett_57() { return &___m_deserializedFromEverett_57; }
	inline void set_m_deserializedFromEverett_57(bool value)
	{
		___m_deserializedFromEverett_57 = value;
	}

	inline static int32_t get_offset_of_m_isReadOnly_58() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827, ___m_isReadOnly_58)); }
	inline bool get_m_isReadOnly_58() const { return ___m_isReadOnly_58; }
	inline bool* get_address_of_m_isReadOnly_58() { return &___m_isReadOnly_58; }
	inline void set_m_isReadOnly_58(bool value)
	{
		___m_isReadOnly_58 = value;
	}

	inline static int32_t get_offset_of_encoderFallback_59() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827, ___encoderFallback_59)); }
	inline EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * get_encoderFallback_59() const { return ___encoderFallback_59; }
	inline EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 ** get_address_of_encoderFallback_59() { return &___encoderFallback_59; }
	inline void set_encoderFallback_59(EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * value)
	{
		___encoderFallback_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___encoderFallback_59), (void*)value);
	}

	inline static int32_t get_offset_of_decoderFallback_60() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827, ___decoderFallback_60)); }
	inline DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * get_decoderFallback_60() const { return ___decoderFallback_60; }
	inline DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D ** get_address_of_decoderFallback_60() { return &___decoderFallback_60; }
	inline void set_decoderFallback_60(DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * value)
	{
		___decoderFallback_60 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___decoderFallback_60), (void*)value);
	}
};

struct Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields
{
public:
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::defaultEncoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___defaultEncoding_0;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::unicodeEncoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___unicodeEncoding_1;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::bigEndianUnicode
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___bigEndianUnicode_2;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf7Encoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___utf7Encoding_3;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf8Encoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___utf8Encoding_4;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf32Encoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___utf32Encoding_5;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::asciiEncoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___asciiEncoding_6;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::latin1Encoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___latin1Encoding_7;
	// System.Collections.Hashtable modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::encodings
	Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * ___encodings_8;
	// System.Object System.Text.Encoding::s_InternalSyncObject
	RuntimeObject * ___s_InternalSyncObject_61;

public:
	inline static int32_t get_offset_of_defaultEncoding_0() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___defaultEncoding_0)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_defaultEncoding_0() const { return ___defaultEncoding_0; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_defaultEncoding_0() { return &___defaultEncoding_0; }
	inline void set_defaultEncoding_0(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___defaultEncoding_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___defaultEncoding_0), (void*)value);
	}

	inline static int32_t get_offset_of_unicodeEncoding_1() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___unicodeEncoding_1)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_unicodeEncoding_1() const { return ___unicodeEncoding_1; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_unicodeEncoding_1() { return &___unicodeEncoding_1; }
	inline void set_unicodeEncoding_1(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___unicodeEncoding_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___unicodeEncoding_1), (void*)value);
	}

	inline static int32_t get_offset_of_bigEndianUnicode_2() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___bigEndianUnicode_2)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_bigEndianUnicode_2() const { return ___bigEndianUnicode_2; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_bigEndianUnicode_2() { return &___bigEndianUnicode_2; }
	inline void set_bigEndianUnicode_2(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___bigEndianUnicode_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___bigEndianUnicode_2), (void*)value);
	}

	inline static int32_t get_offset_of_utf7Encoding_3() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___utf7Encoding_3)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_utf7Encoding_3() const { return ___utf7Encoding_3; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_utf7Encoding_3() { return &___utf7Encoding_3; }
	inline void set_utf7Encoding_3(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___utf7Encoding_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___utf7Encoding_3), (void*)value);
	}

	inline static int32_t get_offset_of_utf8Encoding_4() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___utf8Encoding_4)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_utf8Encoding_4() const { return ___utf8Encoding_4; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_utf8Encoding_4() { return &___utf8Encoding_4; }
	inline void set_utf8Encoding_4(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___utf8Encoding_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___utf8Encoding_4), (void*)value);
	}

	inline static int32_t get_offset_of_utf32Encoding_5() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___utf32Encoding_5)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_utf32Encoding_5() const { return ___utf32Encoding_5; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_utf32Encoding_5() { return &___utf32Encoding_5; }
	inline void set_utf32Encoding_5(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___utf32Encoding_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___utf32Encoding_5), (void*)value);
	}

	inline static int32_t get_offset_of_asciiEncoding_6() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___asciiEncoding_6)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_asciiEncoding_6() const { return ___asciiEncoding_6; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_asciiEncoding_6() { return &___asciiEncoding_6; }
	inline void set_asciiEncoding_6(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___asciiEncoding_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___asciiEncoding_6), (void*)value);
	}

	inline static int32_t get_offset_of_latin1Encoding_7() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___latin1Encoding_7)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_latin1Encoding_7() const { return ___latin1Encoding_7; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_latin1Encoding_7() { return &___latin1Encoding_7; }
	inline void set_latin1Encoding_7(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___latin1Encoding_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___latin1Encoding_7), (void*)value);
	}

	inline static int32_t get_offset_of_encodings_8() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___encodings_8)); }
	inline Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * get_encodings_8() const { return ___encodings_8; }
	inline Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC ** get_address_of_encodings_8() { return &___encodings_8; }
	inline void set_encodings_8(Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * value)
	{
		___encodings_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___encodings_8), (void*)value);
	}

	inline static int32_t get_offset_of_s_InternalSyncObject_61() { return static_cast<int32_t>(offsetof(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827_StaticFields, ___s_InternalSyncObject_61)); }
	inline RuntimeObject * get_s_InternalSyncObject_61() const { return ___s_InternalSyncObject_61; }
	inline RuntimeObject ** get_address_of_s_InternalSyncObject_61() { return &___s_InternalSyncObject_61; }
	inline void set_s_InternalSyncObject_61(RuntimeObject * value)
	{
		___s_InternalSyncObject_61 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_InternalSyncObject_61), (void*)value);
	}
};


// System.MarshalByRefObject
struct MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8  : public RuntimeObject
{
public:
	// System.Object System.MarshalByRefObject::_identity
	RuntimeObject * ____identity_0;

public:
	inline static int32_t get_offset_of__identity_0() { return static_cast<int32_t>(offsetof(MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8, ____identity_0)); }
	inline RuntimeObject * get__identity_0() const { return ____identity_0; }
	inline RuntimeObject ** get_address_of__identity_0() { return &____identity_0; }
	inline void set__identity_0(RuntimeObject * value)
	{
		____identity_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____identity_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.MarshalByRefObject
struct MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8_marshaled_pinvoke
{
	Il2CppIUnknown* ____identity_0;
};
// Native definition for COM marshalling of System.MarshalByRefObject
struct MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8_marshaled_com
{
	Il2CppIUnknown* ____identity_0;
};

// UnityEngine.Networking.PlayerConnection.MessageEventArgs
struct MessageEventArgs_t6905F6AA12A37C5A38BBCB907E9215622364DCCA  : public RuntimeObject
{
public:
	// System.Int32 UnityEngine.Networking.PlayerConnection.MessageEventArgs::playerId
	int32_t ___playerId_0;
	// System.Byte[] UnityEngine.Networking.PlayerConnection.MessageEventArgs::data
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___data_1;

public:
	inline static int32_t get_offset_of_playerId_0() { return static_cast<int32_t>(offsetof(MessageEventArgs_t6905F6AA12A37C5A38BBCB907E9215622364DCCA, ___playerId_0)); }
	inline int32_t get_playerId_0() const { return ___playerId_0; }
	inline int32_t* get_address_of_playerId_0() { return &___playerId_0; }
	inline void set_playerId_0(int32_t value)
	{
		___playerId_0 = value;
	}

	inline static int32_t get_offset_of_data_1() { return static_cast<int32_t>(offsetof(MessageEventArgs_t6905F6AA12A37C5A38BBCB907E9215622364DCCA, ___data_1)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_data_1() const { return ___data_1; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_data_1() { return &___data_1; }
	inline void set_data_1(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___data_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_1), (void*)value);
	}
};


// System.String
struct String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// UnityEngine.Events.UnityEventBase
struct UnityEventBase_tBB43047292084BA63C5CBB1A379A8BB88611C6FB  : public RuntimeObject
{
public:
	// UnityEngine.Events.InvokableCallList UnityEngine.Events.UnityEventBase::m_Calls
	InvokableCallList_tB7C66AA0C00F9C102C8BDC17A144E569AC7527A9 * ___m_Calls_0;
	// UnityEngine.Events.PersistentCallGroup UnityEngine.Events.UnityEventBase::m_PersistentCalls
	PersistentCallGroup_t9A1D83DA2BA3118C103FA87D93CE92557A956FDC * ___m_PersistentCalls_1;
	// System.Boolean UnityEngine.Events.UnityEventBase::m_CallsDirty
	bool ___m_CallsDirty_2;

public:
	inline static int32_t get_offset_of_m_Calls_0() { return static_cast<int32_t>(offsetof(UnityEventBase_tBB43047292084BA63C5CBB1A379A8BB88611C6FB, ___m_Calls_0)); }
	inline InvokableCallList_tB7C66AA0C00F9C102C8BDC17A144E569AC7527A9 * get_m_Calls_0() const { return ___m_Calls_0; }
	inline InvokableCallList_tB7C66AA0C00F9C102C8BDC17A144E569AC7527A9 ** get_address_of_m_Calls_0() { return &___m_Calls_0; }
	inline void set_m_Calls_0(InvokableCallList_tB7C66AA0C00F9C102C8BDC17A144E569AC7527A9 * value)
	{
		___m_Calls_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Calls_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_PersistentCalls_1() { return static_cast<int32_t>(offsetof(UnityEventBase_tBB43047292084BA63C5CBB1A379A8BB88611C6FB, ___m_PersistentCalls_1)); }
	inline PersistentCallGroup_t9A1D83DA2BA3118C103FA87D93CE92557A956FDC * get_m_PersistentCalls_1() const { return ___m_PersistentCalls_1; }
	inline PersistentCallGroup_t9A1D83DA2BA3118C103FA87D93CE92557A956FDC ** get_address_of_m_PersistentCalls_1() { return &___m_PersistentCalls_1; }
	inline void set_m_PersistentCalls_1(PersistentCallGroup_t9A1D83DA2BA3118C103FA87D93CE92557A956FDC * value)
	{
		___m_PersistentCalls_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_PersistentCalls_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_CallsDirty_2() { return static_cast<int32_t>(offsetof(UnityEventBase_tBB43047292084BA63C5CBB1A379A8BB88611C6FB, ___m_CallsDirty_2)); }
	inline bool get_m_CallsDirty_2() const { return ___m_CallsDirty_2; }
	inline bool* get_address_of_m_CallsDirty_2() { return &___m_CallsDirty_2; }
	inline void set_m_CallsDirty_2(bool value)
	{
		___m_CallsDirty_2 = value;
	}
};


// System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// UnityEngine.YieldInstruction
struct YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_com
{
};

// UnityEngine.Experimental.GlobalIllumination.Lightmapping/<>c
struct U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826  : public RuntimeObject
{
public:

public:
};

struct U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826_StaticFields
{
public:
	// UnityEngine.Experimental.GlobalIllumination.Lightmapping/<>c UnityEngine.Experimental.GlobalIllumination.Lightmapping/<>c::<>9
	U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 * ___U3CU3E9_0;

public:
	inline static int32_t get_offset_of_U3CU3E9_0() { return static_cast<int32_t>(offsetof(U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826_StaticFields, ___U3CU3E9_0)); }
	inline U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 * get_U3CU3E9_0() const { return ___U3CU3E9_0; }
	inline U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 ** get_address_of_U3CU3E9_0() { return &___U3CU3E9_0; }
	inline void set_U3CU3E9_0(U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 * value)
	{
		___U3CU3E9_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9_0), (void*)value);
	}
};


// UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass20_0
struct U3CU3Ec__DisplayClass20_0_tEA47E236E3FCEC75772DAF52911B35E8F14766DD  : public RuntimeObject
{
public:
	// System.Boolean UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass20_0::msgReceived
	bool ___msgReceived_0;

public:
	inline static int32_t get_offset_of_msgReceived_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass20_0_tEA47E236E3FCEC75772DAF52911B35E8F14766DD, ___msgReceived_0)); }
	inline bool get_msgReceived_0() const { return ___msgReceived_0; }
	inline bool* get_address_of_msgReceived_0() { return &___msgReceived_0; }
	inline void set_msgReceived_0(bool value)
	{
		___msgReceived_0 = value;
	}
};


// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers
struct MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F  : public RuntimeObject
{
public:
	// System.String UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers::m_messageTypeId
	String_t* ___m_messageTypeId_0;
	// System.Int32 UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers::subscriberCount
	int32_t ___subscriberCount_1;
	// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageEvent UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers::messageCallback
	MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B * ___messageCallback_2;

public:
	inline static int32_t get_offset_of_m_messageTypeId_0() { return static_cast<int32_t>(offsetof(MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F, ___m_messageTypeId_0)); }
	inline String_t* get_m_messageTypeId_0() const { return ___m_messageTypeId_0; }
	inline String_t** get_address_of_m_messageTypeId_0() { return &___m_messageTypeId_0; }
	inline void set_m_messageTypeId_0(String_t* value)
	{
		___m_messageTypeId_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_messageTypeId_0), (void*)value);
	}

	inline static int32_t get_offset_of_subscriberCount_1() { return static_cast<int32_t>(offsetof(MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F, ___subscriberCount_1)); }
	inline int32_t get_subscriberCount_1() const { return ___subscriberCount_1; }
	inline int32_t* get_address_of_subscriberCount_1() { return &___subscriberCount_1; }
	inline void set_subscriberCount_1(int32_t value)
	{
		___subscriberCount_1 = value;
	}

	inline static int32_t get_offset_of_messageCallback_2() { return static_cast<int32_t>(offsetof(MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F, ___messageCallback_2)); }
	inline MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B * get_messageCallback_2() const { return ___messageCallback_2; }
	inline MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B ** get_address_of_messageCallback_2() { return &___messageCallback_2; }
	inline void set_messageCallback_2(MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B * value)
	{
		___messageCallback_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___messageCallback_2), (void*)value);
	}
};


// UnityEngine.TextAsset/EncodingUtility
struct EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983  : public RuntimeObject
{
public:

public:
};

struct EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_StaticFields
{
public:
	// System.Collections.Generic.KeyValuePair`2<System.Byte[],System.Text.Encoding>[] UnityEngine.TextAsset/EncodingUtility::encodingLookup
	KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* ___encodingLookup_0;
	// System.Text.Encoding UnityEngine.TextAsset/EncodingUtility::targetEncoding
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___targetEncoding_1;

public:
	inline static int32_t get_offset_of_encodingLookup_0() { return static_cast<int32_t>(offsetof(EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_StaticFields, ___encodingLookup_0)); }
	inline KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* get_encodingLookup_0() const { return ___encodingLookup_0; }
	inline KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7** get_address_of_encodingLookup_0() { return &___encodingLookup_0; }
	inline void set_encodingLookup_0(KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* value)
	{
		___encodingLookup_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___encodingLookup_0), (void*)value);
	}

	inline static int32_t get_offset_of_targetEncoding_1() { return static_cast<int32_t>(offsetof(EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_StaticFields, ___targetEncoding_1)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_targetEncoding_1() const { return ___targetEncoding_1; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_targetEncoding_1() { return &___targetEncoding_1; }
	inline void set_targetEncoding_1(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___targetEncoding_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetEncoding_1), (void*)value);
	}
};


// UnityEngine.Transform/Enumerator
struct Enumerator_t8A0B2200373BC9628C065322A1BA07AAA47E0259  : public RuntimeObject
{
public:
	// UnityEngine.Transform UnityEngine.Transform/Enumerator::outer
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___outer_0;
	// System.Int32 UnityEngine.Transform/Enumerator::currentIndex
	int32_t ___currentIndex_1;

public:
	inline static int32_t get_offset_of_outer_0() { return static_cast<int32_t>(offsetof(Enumerator_t8A0B2200373BC9628C065322A1BA07AAA47E0259, ___outer_0)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_outer_0() const { return ___outer_0; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_outer_0() { return &___outer_0; }
	inline void set_outer_0(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___outer_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___outer_0), (void*)value);
	}

	inline static int32_t get_offset_of_currentIndex_1() { return static_cast<int32_t>(offsetof(Enumerator_t8A0B2200373BC9628C065322A1BA07AAA47E0259, ___currentIndex_1)); }
	inline int32_t get_currentIndex_1() const { return ___currentIndex_1; }
	inline int32_t* get_address_of_currentIndex_1() { return &___currentIndex_1; }
	inline void set_currentIndex_1(int32_t value)
	{
		___currentIndex_1 = value;
	}
};


// System.Collections.Generic.KeyValuePair`2<System.Byte[],System.Text.Encoding>
struct KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B 
{
public:
	// TKey System.Collections.Generic.KeyValuePair`2::key
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___value_1;

public:
	inline static int32_t get_offset_of_key_0() { return static_cast<int32_t>(offsetof(KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B, ___key_0)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_key_0() const { return ___key_0; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_key_0() { return &___key_0; }
	inline void set_key_0(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___key_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___key_0), (void*)value);
	}

	inline static int32_t get_offset_of_value_1() { return static_cast<int32_t>(offsetof(KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B, ___value_1)); }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * get_value_1() const { return ___value_1; }
	inline Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 ** get_address_of_value_1() { return &___value_1; }
	inline void set_value_1(Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * value)
	{
		___value_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___value_1), (void*)value);
	}
};


// System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>
struct KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625 
{
public:
	// TKey System.Collections.Generic.KeyValuePair`2::key
	RuntimeObject * ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	RuntimeObject * ___value_1;

public:
	inline static int32_t get_offset_of_key_0() { return static_cast<int32_t>(offsetof(KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625, ___key_0)); }
	inline RuntimeObject * get_key_0() const { return ___key_0; }
	inline RuntimeObject ** get_address_of_key_0() { return &___key_0; }
	inline void set_key_0(RuntimeObject * value)
	{
		___key_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___key_0), (void*)value);
	}

	inline static int32_t get_offset_of_value_1() { return static_cast<int32_t>(offsetof(KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625, ___value_1)); }
	inline RuntimeObject * get_value_1() const { return ___value_1; }
	inline RuntimeObject ** get_address_of_value_1() { return &___value_1; }
	inline void set_value_1(RuntimeObject * value)
	{
		___value_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___value_1), (void*)value);
	}
};


// UnityEngine.Events.UnityEvent`1<System.Int32>
struct UnityEvent_1_tB235B5DAD099AC425DC059D10DEB8B97A35E2BBF  : public UnityEventBase_tBB43047292084BA63C5CBB1A379A8BB88611C6FB
{
public:
	// System.Object[] UnityEngine.Events.UnityEvent`1::m_InvokeArray
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___m_InvokeArray_3;

public:
	inline static int32_t get_offset_of_m_InvokeArray_3() { return static_cast<int32_t>(offsetof(UnityEvent_1_tB235B5DAD099AC425DC059D10DEB8B97A35E2BBF, ___m_InvokeArray_3)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get_m_InvokeArray_3() const { return ___m_InvokeArray_3; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of_m_InvokeArray_3() { return &___m_InvokeArray_3; }
	inline void set_m_InvokeArray_3(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		___m_InvokeArray_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_InvokeArray_3), (void*)value);
	}
};


// UnityEngine.Events.UnityEvent`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>
struct UnityEvent_1_t5380899C55F3CD7FD1CD64F13EE5E1E4B11D602B  : public UnityEventBase_tBB43047292084BA63C5CBB1A379A8BB88611C6FB
{
public:
	// System.Object[] UnityEngine.Events.UnityEvent`1::m_InvokeArray
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___m_InvokeArray_3;

public:
	inline static int32_t get_offset_of_m_InvokeArray_3() { return static_cast<int32_t>(offsetof(UnityEvent_1_t5380899C55F3CD7FD1CD64F13EE5E1E4B11D602B, ___m_InvokeArray_3)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get_m_InvokeArray_3() const { return ___m_InvokeArray_3; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of_m_InvokeArray_3() { return &___m_InvokeArray_3; }
	inline void set_m_InvokeArray_3(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		___m_InvokeArray_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_InvokeArray_3), (void*)value);
	}
};


// System.Boolean
struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Byte
struct Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056 
{
public:
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056, ___m_value_0)); }
	inline uint8_t get_m_value_0() const { return ___m_value_0; }
	inline uint8_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint8_t value)
	{
		___m_value_0 = value;
	}
};


// UnityEngine.Color
struct Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 
{
public:
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;

public:
	inline static int32_t get_offset_of_r_0() { return static_cast<int32_t>(offsetof(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659, ___r_0)); }
	inline float get_r_0() const { return ___r_0; }
	inline float* get_address_of_r_0() { return &___r_0; }
	inline void set_r_0(float value)
	{
		___r_0 = value;
	}

	inline static int32_t get_offset_of_g_1() { return static_cast<int32_t>(offsetof(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659, ___g_1)); }
	inline float get_g_1() const { return ___g_1; }
	inline float* get_address_of_g_1() { return &___g_1; }
	inline void set_g_1(float value)
	{
		___g_1 = value;
	}

	inline static int32_t get_offset_of_b_2() { return static_cast<int32_t>(offsetof(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659, ___b_2)); }
	inline float get_b_2() const { return ___b_2; }
	inline float* get_address_of_b_2() { return &___b_2; }
	inline void set_b_2(float value)
	{
		___b_2 = value;
	}

	inline static int32_t get_offset_of_a_3() { return static_cast<int32_t>(offsetof(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659, ___a_3)); }
	inline float get_a_3() const { return ___a_3; }
	inline float* get_address_of_a_3() { return &___a_3; }
	inline void set_a_3(float value)
	{
		___a_3 = value;
	}
};


// UnityEngine.CullingGroupEvent
struct CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C 
{
public:
	// System.Int32 UnityEngine.CullingGroupEvent::m_Index
	int32_t ___m_Index_0;
	// System.Byte UnityEngine.CullingGroupEvent::m_PrevState
	uint8_t ___m_PrevState_1;
	// System.Byte UnityEngine.CullingGroupEvent::m_ThisState
	uint8_t ___m_ThisState_2;

public:
	inline static int32_t get_offset_of_m_Index_0() { return static_cast<int32_t>(offsetof(CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C, ___m_Index_0)); }
	inline int32_t get_m_Index_0() const { return ___m_Index_0; }
	inline int32_t* get_address_of_m_Index_0() { return &___m_Index_0; }
	inline void set_m_Index_0(int32_t value)
	{
		___m_Index_0 = value;
	}

	inline static int32_t get_offset_of_m_PrevState_1() { return static_cast<int32_t>(offsetof(CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C, ___m_PrevState_1)); }
	inline uint8_t get_m_PrevState_1() const { return ___m_PrevState_1; }
	inline uint8_t* get_address_of_m_PrevState_1() { return &___m_PrevState_1; }
	inline void set_m_PrevState_1(uint8_t value)
	{
		___m_PrevState_1 = value;
	}

	inline static int32_t get_offset_of_m_ThisState_2() { return static_cast<int32_t>(offsetof(CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C, ___m_ThisState_2)); }
	inline uint8_t get_m_ThisState_2() const { return ___m_ThisState_2; }
	inline uint8_t* get_address_of_m_ThisState_2() { return &___m_ThisState_2; }
	inline void set_m_ThisState_2(uint8_t value)
	{
		___m_ThisState_2 = value;
	}
};


// System.Text.DecoderReplacementFallback
struct DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130  : public DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D
{
public:
	// System.String System.Text.DecoderReplacementFallback::strDefault
	String_t* ___strDefault_4;

public:
	inline static int32_t get_offset_of_strDefault_4() { return static_cast<int32_t>(offsetof(DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130, ___strDefault_4)); }
	inline String_t* get_strDefault_4() const { return ___strDefault_4; }
	inline String_t** get_address_of_strDefault_4() { return &___strDefault_4; }
	inline void set_strDefault_4(String_t* value)
	{
		___strDefault_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___strDefault_4), (void*)value);
	}
};


// System.Double
struct Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181 
{
public:
	// System.Double System.Double::m_value
	double ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181, ___m_value_0)); }
	inline double get_m_value_0() const { return ___m_value_0; }
	inline double* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(double value)
	{
		___m_value_0 = value;
	}
};

struct Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_StaticFields
{
public:
	// System.Double System.Double::NegativeZero
	double ___NegativeZero_7;

public:
	inline static int32_t get_offset_of_NegativeZero_7() { return static_cast<int32_t>(offsetof(Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_StaticFields, ___NegativeZero_7)); }
	inline double get_NegativeZero_7() const { return ___NegativeZero_7; }
	inline double* get_address_of_NegativeZero_7() { return &___NegativeZero_7; }
	inline void set_NegativeZero_7(double value)
	{
		___NegativeZero_7 = value;
	}
};


// System.Text.EncoderReplacementFallback
struct EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418  : public EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4
{
public:
	// System.String System.Text.EncoderReplacementFallback::strDefault
	String_t* ___strDefault_4;

public:
	inline static int32_t get_offset_of_strDefault_4() { return static_cast<int32_t>(offsetof(EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418, ___strDefault_4)); }
	inline String_t* get_strDefault_4() const { return ___strDefault_4; }
	inline String_t** get_address_of_strDefault_4() { return &___strDefault_4; }
	inline void set_strDefault_4(String_t* value)
	{
		___strDefault_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___strDefault_4), (void*)value);
	}
};


// System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.Guid
struct Guid_t 
{
public:
	// System.Int32 System.Guid::_a
	int32_t ____a_1;
	// System.Int16 System.Guid::_b
	int16_t ____b_2;
	// System.Int16 System.Guid::_c
	int16_t ____c_3;
	// System.Byte System.Guid::_d
	uint8_t ____d_4;
	// System.Byte System.Guid::_e
	uint8_t ____e_5;
	// System.Byte System.Guid::_f
	uint8_t ____f_6;
	// System.Byte System.Guid::_g
	uint8_t ____g_7;
	// System.Byte System.Guid::_h
	uint8_t ____h_8;
	// System.Byte System.Guid::_i
	uint8_t ____i_9;
	// System.Byte System.Guid::_j
	uint8_t ____j_10;
	// System.Byte System.Guid::_k
	uint8_t ____k_11;

public:
	inline static int32_t get_offset_of__a_1() { return static_cast<int32_t>(offsetof(Guid_t, ____a_1)); }
	inline int32_t get__a_1() const { return ____a_1; }
	inline int32_t* get_address_of__a_1() { return &____a_1; }
	inline void set__a_1(int32_t value)
	{
		____a_1 = value;
	}

	inline static int32_t get_offset_of__b_2() { return static_cast<int32_t>(offsetof(Guid_t, ____b_2)); }
	inline int16_t get__b_2() const { return ____b_2; }
	inline int16_t* get_address_of__b_2() { return &____b_2; }
	inline void set__b_2(int16_t value)
	{
		____b_2 = value;
	}

	inline static int32_t get_offset_of__c_3() { return static_cast<int32_t>(offsetof(Guid_t, ____c_3)); }
	inline int16_t get__c_3() const { return ____c_3; }
	inline int16_t* get_address_of__c_3() { return &____c_3; }
	inline void set__c_3(int16_t value)
	{
		____c_3 = value;
	}

	inline static int32_t get_offset_of__d_4() { return static_cast<int32_t>(offsetof(Guid_t, ____d_4)); }
	inline uint8_t get__d_4() const { return ____d_4; }
	inline uint8_t* get_address_of__d_4() { return &____d_4; }
	inline void set__d_4(uint8_t value)
	{
		____d_4 = value;
	}

	inline static int32_t get_offset_of__e_5() { return static_cast<int32_t>(offsetof(Guid_t, ____e_5)); }
	inline uint8_t get__e_5() const { return ____e_5; }
	inline uint8_t* get_address_of__e_5() { return &____e_5; }
	inline void set__e_5(uint8_t value)
	{
		____e_5 = value;
	}

	inline static int32_t get_offset_of__f_6() { return static_cast<int32_t>(offsetof(Guid_t, ____f_6)); }
	inline uint8_t get__f_6() const { return ____f_6; }
	inline uint8_t* get_address_of__f_6() { return &____f_6; }
	inline void set__f_6(uint8_t value)
	{
		____f_6 = value;
	}

	inline static int32_t get_offset_of__g_7() { return static_cast<int32_t>(offsetof(Guid_t, ____g_7)); }
	inline uint8_t get__g_7() const { return ____g_7; }
	inline uint8_t* get_address_of__g_7() { return &____g_7; }
	inline void set__g_7(uint8_t value)
	{
		____g_7 = value;
	}

	inline static int32_t get_offset_of__h_8() { return static_cast<int32_t>(offsetof(Guid_t, ____h_8)); }
	inline uint8_t get__h_8() const { return ____h_8; }
	inline uint8_t* get_address_of__h_8() { return &____h_8; }
	inline void set__h_8(uint8_t value)
	{
		____h_8 = value;
	}

	inline static int32_t get_offset_of__i_9() { return static_cast<int32_t>(offsetof(Guid_t, ____i_9)); }
	inline uint8_t get__i_9() const { return ____i_9; }
	inline uint8_t* get_address_of__i_9() { return &____i_9; }
	inline void set__i_9(uint8_t value)
	{
		____i_9 = value;
	}

	inline static int32_t get_offset_of__j_10() { return static_cast<int32_t>(offsetof(Guid_t, ____j_10)); }
	inline uint8_t get__j_10() const { return ____j_10; }
	inline uint8_t* get_address_of__j_10() { return &____j_10; }
	inline void set__j_10(uint8_t value)
	{
		____j_10 = value;
	}

	inline static int32_t get_offset_of__k_11() { return static_cast<int32_t>(offsetof(Guid_t, ____k_11)); }
	inline uint8_t get__k_11() const { return ____k_11; }
	inline uint8_t* get_address_of__k_11() { return &____k_11; }
	inline void set__k_11(uint8_t value)
	{
		____k_11 = value;
	}
};

struct Guid_t_StaticFields
{
public:
	// System.Guid System.Guid::Empty
	Guid_t  ___Empty_0;
	// System.Object System.Guid::_rngAccess
	RuntimeObject * ____rngAccess_12;
	// System.Security.Cryptography.RandomNumberGenerator System.Guid::_rng
	RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * ____rng_13;
	// System.Security.Cryptography.RandomNumberGenerator System.Guid::_fastRng
	RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * ____fastRng_14;

public:
	inline static int32_t get_offset_of_Empty_0() { return static_cast<int32_t>(offsetof(Guid_t_StaticFields, ___Empty_0)); }
	inline Guid_t  get_Empty_0() const { return ___Empty_0; }
	inline Guid_t * get_address_of_Empty_0() { return &___Empty_0; }
	inline void set_Empty_0(Guid_t  value)
	{
		___Empty_0 = value;
	}

	inline static int32_t get_offset_of__rngAccess_12() { return static_cast<int32_t>(offsetof(Guid_t_StaticFields, ____rngAccess_12)); }
	inline RuntimeObject * get__rngAccess_12() const { return ____rngAccess_12; }
	inline RuntimeObject ** get_address_of__rngAccess_12() { return &____rngAccess_12; }
	inline void set__rngAccess_12(RuntimeObject * value)
	{
		____rngAccess_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____rngAccess_12), (void*)value);
	}

	inline static int32_t get_offset_of__rng_13() { return static_cast<int32_t>(offsetof(Guid_t_StaticFields, ____rng_13)); }
	inline RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * get__rng_13() const { return ____rng_13; }
	inline RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 ** get_address_of__rng_13() { return &____rng_13; }
	inline void set__rng_13(RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * value)
	{
		____rng_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____rng_13), (void*)value);
	}

	inline static int32_t get_offset_of__fastRng_14() { return static_cast<int32_t>(offsetof(Guid_t_StaticFields, ____fastRng_14)); }
	inline RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * get__fastRng_14() const { return ____fastRng_14; }
	inline RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 ** get_address_of__fastRng_14() { return &____fastRng_14; }
	inline void set__fastRng_14(RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50 * value)
	{
		____fastRng_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____fastRng_14), (void*)value);
	}
};


// System.Int32
struct Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.Int64
struct Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3 
{
public:
	// System.Int64 System.Int64::m_value
	int64_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3, ___m_value_0)); }
	inline int64_t get_m_value_0() const { return ___m_value_0; }
	inline int64_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int64_t value)
	{
		___m_value_0 = value;
	}
};


// System.IntPtr
struct IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// UnityEngine.Experimental.GlobalIllumination.LinearColor
struct LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 
{
public:
	// System.Single UnityEngine.Experimental.GlobalIllumination.LinearColor::m_red
	float ___m_red_0;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LinearColor::m_green
	float ___m_green_1;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LinearColor::m_blue
	float ___m_blue_2;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LinearColor::m_intensity
	float ___m_intensity_3;

public:
	inline static int32_t get_offset_of_m_red_0() { return static_cast<int32_t>(offsetof(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2, ___m_red_0)); }
	inline float get_m_red_0() const { return ___m_red_0; }
	inline float* get_address_of_m_red_0() { return &___m_red_0; }
	inline void set_m_red_0(float value)
	{
		___m_red_0 = value;
	}

	inline static int32_t get_offset_of_m_green_1() { return static_cast<int32_t>(offsetof(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2, ___m_green_1)); }
	inline float get_m_green_1() const { return ___m_green_1; }
	inline float* get_address_of_m_green_1() { return &___m_green_1; }
	inline void set_m_green_1(float value)
	{
		___m_green_1 = value;
	}

	inline static int32_t get_offset_of_m_blue_2() { return static_cast<int32_t>(offsetof(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2, ___m_blue_2)); }
	inline float get_m_blue_2() const { return ___m_blue_2; }
	inline float* get_address_of_m_blue_2() { return &___m_blue_2; }
	inline void set_m_blue_2(float value)
	{
		___m_blue_2 = value;
	}

	inline static int32_t get_offset_of_m_intensity_3() { return static_cast<int32_t>(offsetof(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2, ___m_intensity_3)); }
	inline float get_m_intensity_3() const { return ___m_intensity_3; }
	inline float* get_address_of_m_intensity_3() { return &___m_intensity_3; }
	inline void set_m_intensity_3(float value)
	{
		___m_intensity_3 = value;
	}
};


// UnityEngine.Matrix4x4
struct Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 
{
public:
	// System.Single UnityEngine.Matrix4x4::m00
	float ___m00_0;
	// System.Single UnityEngine.Matrix4x4::m10
	float ___m10_1;
	// System.Single UnityEngine.Matrix4x4::m20
	float ___m20_2;
	// System.Single UnityEngine.Matrix4x4::m30
	float ___m30_3;
	// System.Single UnityEngine.Matrix4x4::m01
	float ___m01_4;
	// System.Single UnityEngine.Matrix4x4::m11
	float ___m11_5;
	// System.Single UnityEngine.Matrix4x4::m21
	float ___m21_6;
	// System.Single UnityEngine.Matrix4x4::m31
	float ___m31_7;
	// System.Single UnityEngine.Matrix4x4::m02
	float ___m02_8;
	// System.Single UnityEngine.Matrix4x4::m12
	float ___m12_9;
	// System.Single UnityEngine.Matrix4x4::m22
	float ___m22_10;
	// System.Single UnityEngine.Matrix4x4::m32
	float ___m32_11;
	// System.Single UnityEngine.Matrix4x4::m03
	float ___m03_12;
	// System.Single UnityEngine.Matrix4x4::m13
	float ___m13_13;
	// System.Single UnityEngine.Matrix4x4::m23
	float ___m23_14;
	// System.Single UnityEngine.Matrix4x4::m33
	float ___m33_15;

public:
	inline static int32_t get_offset_of_m00_0() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m00_0)); }
	inline float get_m00_0() const { return ___m00_0; }
	inline float* get_address_of_m00_0() { return &___m00_0; }
	inline void set_m00_0(float value)
	{
		___m00_0 = value;
	}

	inline static int32_t get_offset_of_m10_1() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m10_1)); }
	inline float get_m10_1() const { return ___m10_1; }
	inline float* get_address_of_m10_1() { return &___m10_1; }
	inline void set_m10_1(float value)
	{
		___m10_1 = value;
	}

	inline static int32_t get_offset_of_m20_2() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m20_2)); }
	inline float get_m20_2() const { return ___m20_2; }
	inline float* get_address_of_m20_2() { return &___m20_2; }
	inline void set_m20_2(float value)
	{
		___m20_2 = value;
	}

	inline static int32_t get_offset_of_m30_3() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m30_3)); }
	inline float get_m30_3() const { return ___m30_3; }
	inline float* get_address_of_m30_3() { return &___m30_3; }
	inline void set_m30_3(float value)
	{
		___m30_3 = value;
	}

	inline static int32_t get_offset_of_m01_4() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m01_4)); }
	inline float get_m01_4() const { return ___m01_4; }
	inline float* get_address_of_m01_4() { return &___m01_4; }
	inline void set_m01_4(float value)
	{
		___m01_4 = value;
	}

	inline static int32_t get_offset_of_m11_5() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m11_5)); }
	inline float get_m11_5() const { return ___m11_5; }
	inline float* get_address_of_m11_5() { return &___m11_5; }
	inline void set_m11_5(float value)
	{
		___m11_5 = value;
	}

	inline static int32_t get_offset_of_m21_6() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m21_6)); }
	inline float get_m21_6() const { return ___m21_6; }
	inline float* get_address_of_m21_6() { return &___m21_6; }
	inline void set_m21_6(float value)
	{
		___m21_6 = value;
	}

	inline static int32_t get_offset_of_m31_7() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m31_7)); }
	inline float get_m31_7() const { return ___m31_7; }
	inline float* get_address_of_m31_7() { return &___m31_7; }
	inline void set_m31_7(float value)
	{
		___m31_7 = value;
	}

	inline static int32_t get_offset_of_m02_8() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m02_8)); }
	inline float get_m02_8() const { return ___m02_8; }
	inline float* get_address_of_m02_8() { return &___m02_8; }
	inline void set_m02_8(float value)
	{
		___m02_8 = value;
	}

	inline static int32_t get_offset_of_m12_9() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m12_9)); }
	inline float get_m12_9() const { return ___m12_9; }
	inline float* get_address_of_m12_9() { return &___m12_9; }
	inline void set_m12_9(float value)
	{
		___m12_9 = value;
	}

	inline static int32_t get_offset_of_m22_10() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m22_10)); }
	inline float get_m22_10() const { return ___m22_10; }
	inline float* get_address_of_m22_10() { return &___m22_10; }
	inline void set_m22_10(float value)
	{
		___m22_10 = value;
	}

	inline static int32_t get_offset_of_m32_11() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m32_11)); }
	inline float get_m32_11() const { return ___m32_11; }
	inline float* get_address_of_m32_11() { return &___m32_11; }
	inline void set_m32_11(float value)
	{
		___m32_11 = value;
	}

	inline static int32_t get_offset_of_m03_12() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m03_12)); }
	inline float get_m03_12() const { return ___m03_12; }
	inline float* get_address_of_m03_12() { return &___m03_12; }
	inline void set_m03_12(float value)
	{
		___m03_12 = value;
	}

	inline static int32_t get_offset_of_m13_13() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m13_13)); }
	inline float get_m13_13() const { return ___m13_13; }
	inline float* get_address_of_m13_13() { return &___m13_13; }
	inline void set_m13_13(float value)
	{
		___m13_13 = value;
	}

	inline static int32_t get_offset_of_m23_14() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m23_14)); }
	inline float get_m23_14() const { return ___m23_14; }
	inline float* get_address_of_m23_14() { return &___m23_14; }
	inline void set_m23_14(float value)
	{
		___m23_14 = value;
	}

	inline static int32_t get_offset_of_m33_15() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461, ___m33_15)); }
	inline float get_m33_15() const { return ___m33_15; }
	inline float* get_address_of_m33_15() { return &___m33_15; }
	inline void set_m33_15(float value)
	{
		___m33_15 = value;
	}
};

struct Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461_StaticFields
{
public:
	// UnityEngine.Matrix4x4 UnityEngine.Matrix4x4::zeroMatrix
	Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  ___zeroMatrix_16;
	// UnityEngine.Matrix4x4 UnityEngine.Matrix4x4::identityMatrix
	Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  ___identityMatrix_17;

public:
	inline static int32_t get_offset_of_zeroMatrix_16() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461_StaticFields, ___zeroMatrix_16)); }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  get_zeroMatrix_16() const { return ___zeroMatrix_16; }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * get_address_of_zeroMatrix_16() { return &___zeroMatrix_16; }
	inline void set_zeroMatrix_16(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  value)
	{
		___zeroMatrix_16 = value;
	}

	inline static int32_t get_offset_of_identityMatrix_17() { return static_cast<int32_t>(offsetof(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461_StaticFields, ___identityMatrix_17)); }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  get_identityMatrix_17() const { return ___identityMatrix_17; }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * get_address_of_identityMatrix_17() { return &___identityMatrix_17; }
	inline void set_identityMatrix_17(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  value)
	{
		___identityMatrix_17 = value;
	}
};


// UnityEngine.Quaternion
struct Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 
{
public:
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}

	inline static int32_t get_offset_of_z_2() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4, ___z_2)); }
	inline float get_z_2() const { return ___z_2; }
	inline float* get_address_of_z_2() { return &___z_2; }
	inline void set_z_2(float value)
	{
		___z_2 = value;
	}

	inline static int32_t get_offset_of_w_3() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4, ___w_3)); }
	inline float get_w_3() const { return ___w_3; }
	inline float* get_address_of_w_3() { return &___w_3; }
	inline void set_w_3(float value)
	{
		___w_3 = value;
	}
};

struct Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4_StaticFields
{
public:
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___identityQuaternion_4;

public:
	inline static int32_t get_offset_of_identityQuaternion_4() { return static_cast<int32_t>(offsetof(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4_StaticFields, ___identityQuaternion_4)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_identityQuaternion_4() const { return ___identityQuaternion_4; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_identityQuaternion_4() { return &___identityQuaternion_4; }
	inline void set_identityQuaternion_4(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___identityQuaternion_4 = value;
	}
};


// UnityEngine.Rect
struct Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 
{
public:
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;

public:
	inline static int32_t get_offset_of_m_XMin_0() { return static_cast<int32_t>(offsetof(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878, ___m_XMin_0)); }
	inline float get_m_XMin_0() const { return ___m_XMin_0; }
	inline float* get_address_of_m_XMin_0() { return &___m_XMin_0; }
	inline void set_m_XMin_0(float value)
	{
		___m_XMin_0 = value;
	}

	inline static int32_t get_offset_of_m_YMin_1() { return static_cast<int32_t>(offsetof(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878, ___m_YMin_1)); }
	inline float get_m_YMin_1() const { return ___m_YMin_1; }
	inline float* get_address_of_m_YMin_1() { return &___m_YMin_1; }
	inline void set_m_YMin_1(float value)
	{
		___m_YMin_1 = value;
	}

	inline static int32_t get_offset_of_m_Width_2() { return static_cast<int32_t>(offsetof(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878, ___m_Width_2)); }
	inline float get_m_Width_2() const { return ___m_Width_2; }
	inline float* get_address_of_m_Width_2() { return &___m_Width_2; }
	inline void set_m_Width_2(float value)
	{
		___m_Width_2 = value;
	}

	inline static int32_t get_offset_of_m_Height_3() { return static_cast<int32_t>(offsetof(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878, ___m_Height_3)); }
	inline float get_m_Height_3() const { return ___m_Height_3; }
	inline float* get_address_of_m_Height_3() { return &___m_Height_3; }
	inline void set_m_Height_3(float value)
	{
		___m_Height_3 = value;
	}
};


// System.Single
struct Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};


// System.UInt16
struct UInt16_t894EA9D4FB7C799B244E7BBF2DF0EEEDBC77A8BD 
{
public:
	// System.UInt16 System.UInt16::m_value
	uint16_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(UInt16_t894EA9D4FB7C799B244E7BBF2DF0EEEDBC77A8BD, ___m_value_0)); }
	inline uint16_t get_m_value_0() const { return ___m_value_0; }
	inline uint16_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint16_t value)
	{
		___m_value_0 = value;
	}
};


// System.UInt32
struct UInt32_tE60352A06233E4E69DD198BCC67142159F686B15 
{
public:
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(UInt32_tE60352A06233E4E69DD198BCC67142159F686B15, ___m_value_0)); }
	inline uint32_t get_m_value_0() const { return ___m_value_0; }
	inline uint32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint32_t value)
	{
		___m_value_0 = value;
	}
};


// System.UInt64
struct UInt64_tEC57511B3E3CA2DBA1BEBD434C6983E31C943281 
{
public:
	// System.UInt64 System.UInt64::m_value
	uint64_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(UInt64_tEC57511B3E3CA2DBA1BEBD434C6983E31C943281, ___m_value_0)); }
	inline uint64_t get_m_value_0() const { return ___m_value_0; }
	inline uint64_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint64_t value)
	{
		___m_value_0 = value;
	}
};


// System.Text.UTF32Encoding
struct UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014  : public Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827
{
public:
	// System.Boolean System.Text.UTF32Encoding::emitUTF32ByteOrderMark
	bool ___emitUTF32ByteOrderMark_62;
	// System.Boolean System.Text.UTF32Encoding::isThrowException
	bool ___isThrowException_63;
	// System.Boolean System.Text.UTF32Encoding::bigEndian
	bool ___bigEndian_64;

public:
	inline static int32_t get_offset_of_emitUTF32ByteOrderMark_62() { return static_cast<int32_t>(offsetof(UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014, ___emitUTF32ByteOrderMark_62)); }
	inline bool get_emitUTF32ByteOrderMark_62() const { return ___emitUTF32ByteOrderMark_62; }
	inline bool* get_address_of_emitUTF32ByteOrderMark_62() { return &___emitUTF32ByteOrderMark_62; }
	inline void set_emitUTF32ByteOrderMark_62(bool value)
	{
		___emitUTF32ByteOrderMark_62 = value;
	}

	inline static int32_t get_offset_of_isThrowException_63() { return static_cast<int32_t>(offsetof(UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014, ___isThrowException_63)); }
	inline bool get_isThrowException_63() const { return ___isThrowException_63; }
	inline bool* get_address_of_isThrowException_63() { return &___isThrowException_63; }
	inline void set_isThrowException_63(bool value)
	{
		___isThrowException_63 = value;
	}

	inline static int32_t get_offset_of_bigEndian_64() { return static_cast<int32_t>(offsetof(UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014, ___bigEndian_64)); }
	inline bool get_bigEndian_64() const { return ___bigEndian_64; }
	inline bool* get_address_of_bigEndian_64() { return &___bigEndian_64; }
	inline void set_bigEndian_64(bool value)
	{
		___bigEndian_64 = value;
	}
};


// System.Text.UTF8Encoding
struct UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282  : public Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827
{
public:
	// System.Boolean System.Text.UTF8Encoding::emitUTF8Identifier
	bool ___emitUTF8Identifier_63;
	// System.Boolean System.Text.UTF8Encoding::isThrowException
	bool ___isThrowException_64;

public:
	inline static int32_t get_offset_of_emitUTF8Identifier_63() { return static_cast<int32_t>(offsetof(UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282, ___emitUTF8Identifier_63)); }
	inline bool get_emitUTF8Identifier_63() const { return ___emitUTF8Identifier_63; }
	inline bool* get_address_of_emitUTF8Identifier_63() { return &___emitUTF8Identifier_63; }
	inline void set_emitUTF8Identifier_63(bool value)
	{
		___emitUTF8Identifier_63 = value;
	}

	inline static int32_t get_offset_of_isThrowException_64() { return static_cast<int32_t>(offsetof(UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282, ___isThrowException_64)); }
	inline bool get_isThrowException_64() const { return ___isThrowException_64; }
	inline bool* get_address_of_isThrowException_64() { return &___isThrowException_64; }
	inline void set_isThrowException_64(bool value)
	{
		___isThrowException_64 = value;
	}
};


// System.Text.UnicodeEncoding
struct UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68  : public Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827
{
public:
	// System.Boolean System.Text.UnicodeEncoding::isThrowException
	bool ___isThrowException_62;
	// System.Boolean System.Text.UnicodeEncoding::bigEndian
	bool ___bigEndian_63;
	// System.Boolean System.Text.UnicodeEncoding::byteOrderMark
	bool ___byteOrderMark_64;

public:
	inline static int32_t get_offset_of_isThrowException_62() { return static_cast<int32_t>(offsetof(UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68, ___isThrowException_62)); }
	inline bool get_isThrowException_62() const { return ___isThrowException_62; }
	inline bool* get_address_of_isThrowException_62() { return &___isThrowException_62; }
	inline void set_isThrowException_62(bool value)
	{
		___isThrowException_62 = value;
	}

	inline static int32_t get_offset_of_bigEndian_63() { return static_cast<int32_t>(offsetof(UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68, ___bigEndian_63)); }
	inline bool get_bigEndian_63() const { return ___bigEndian_63; }
	inline bool* get_address_of_bigEndian_63() { return &___bigEndian_63; }
	inline void set_bigEndian_63(bool value)
	{
		___bigEndian_63 = value;
	}

	inline static int32_t get_offset_of_byteOrderMark_64() { return static_cast<int32_t>(offsetof(UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68, ___byteOrderMark_64)); }
	inline bool get_byteOrderMark_64() const { return ___byteOrderMark_64; }
	inline bool* get_address_of_byteOrderMark_64() { return &___byteOrderMark_64; }
	inline void set_byteOrderMark_64(bool value)
	{
		___byteOrderMark_64 = value;
	}
};

struct UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68_StaticFields
{
public:
	// System.UInt64 System.Text.UnicodeEncoding::highLowPatternMask
	uint64_t ___highLowPatternMask_66;

public:
	inline static int32_t get_offset_of_highLowPatternMask_66() { return static_cast<int32_t>(offsetof(UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68_StaticFields, ___highLowPatternMask_66)); }
	inline uint64_t get_highLowPatternMask_66() const { return ___highLowPatternMask_66; }
	inline uint64_t* get_address_of_highLowPatternMask_66() { return &___highLowPatternMask_66; }
	inline void set_highLowPatternMask_66(uint64_t value)
	{
		___highLowPatternMask_66 = value;
	}
};


// UnityEngine.Vector2
struct Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 
{
public:
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}
};

struct Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields
{
public:
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___negativeInfinityVector_9;

public:
	inline static int32_t get_offset_of_zeroVector_2() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___zeroVector_2)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_zeroVector_2() const { return ___zeroVector_2; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_zeroVector_2() { return &___zeroVector_2; }
	inline void set_zeroVector_2(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___zeroVector_2 = value;
	}

	inline static int32_t get_offset_of_oneVector_3() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___oneVector_3)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_oneVector_3() const { return ___oneVector_3; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_oneVector_3() { return &___oneVector_3; }
	inline void set_oneVector_3(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___oneVector_3 = value;
	}

	inline static int32_t get_offset_of_upVector_4() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___upVector_4)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_upVector_4() const { return ___upVector_4; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_upVector_4() { return &___upVector_4; }
	inline void set_upVector_4(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___upVector_4 = value;
	}

	inline static int32_t get_offset_of_downVector_5() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___downVector_5)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_downVector_5() const { return ___downVector_5; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_downVector_5() { return &___downVector_5; }
	inline void set_downVector_5(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___downVector_5 = value;
	}

	inline static int32_t get_offset_of_leftVector_6() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___leftVector_6)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_leftVector_6() const { return ___leftVector_6; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_leftVector_6() { return &___leftVector_6; }
	inline void set_leftVector_6(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___leftVector_6 = value;
	}

	inline static int32_t get_offset_of_rightVector_7() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___rightVector_7)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_rightVector_7() const { return ___rightVector_7; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_rightVector_7() { return &___rightVector_7; }
	inline void set_rightVector_7(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___rightVector_7 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___positiveInfinityVector_8)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_positiveInfinityVector_8() const { return ___positiveInfinityVector_8; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_positiveInfinityVector_8() { return &___positiveInfinityVector_8; }
	inline void set_positiveInfinityVector_8(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___positiveInfinityVector_8 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_9() { return static_cast<int32_t>(offsetof(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9_StaticFields, ___negativeInfinityVector_9)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_negativeInfinityVector_9() const { return ___negativeInfinityVector_9; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_negativeInfinityVector_9() { return &___negativeInfinityVector_9; }
	inline void set_negativeInfinityVector_9(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___negativeInfinityVector_9 = value;
	}
};


// UnityEngine.Vector3
struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;

public:
	inline static int32_t get_offset_of_x_2() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___x_2)); }
	inline float get_x_2() const { return ___x_2; }
	inline float* get_address_of_x_2() { return &___x_2; }
	inline void set_x_2(float value)
	{
		___x_2 = value;
	}

	inline static int32_t get_offset_of_y_3() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___y_3)); }
	inline float get_y_3() const { return ___y_3; }
	inline float* get_address_of_y_3() { return &___y_3; }
	inline void set_y_3(float value)
	{
		___y_3 = value;
	}

	inline static int32_t get_offset_of_z_4() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___z_4)); }
	inline float get_z_4() const { return ___z_4; }
	inline float* get_address_of_z_4() { return &___z_4; }
	inline void set_z_4(float value)
	{
		___z_4 = value;
	}
};

struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___negativeInfinityVector_14;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___zeroVector_5)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___oneVector_6)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_upVector_7() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___upVector_7)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_upVector_7() const { return ___upVector_7; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_upVector_7() { return &___upVector_7; }
	inline void set_upVector_7(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___upVector_7 = value;
	}

	inline static int32_t get_offset_of_downVector_8() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___downVector_8)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_downVector_8() const { return ___downVector_8; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_downVector_8() { return &___downVector_8; }
	inline void set_downVector_8(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___downVector_8 = value;
	}

	inline static int32_t get_offset_of_leftVector_9() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___leftVector_9)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_leftVector_9() const { return ___leftVector_9; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_leftVector_9() { return &___leftVector_9; }
	inline void set_leftVector_9(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___leftVector_9 = value;
	}

	inline static int32_t get_offset_of_rightVector_10() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___rightVector_10)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_rightVector_10() const { return ___rightVector_10; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_rightVector_10() { return &___rightVector_10; }
	inline void set_rightVector_10(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___rightVector_10 = value;
	}

	inline static int32_t get_offset_of_forwardVector_11() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___forwardVector_11)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_forwardVector_11() const { return ___forwardVector_11; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_forwardVector_11() { return &___forwardVector_11; }
	inline void set_forwardVector_11(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___forwardVector_11 = value;
	}

	inline static int32_t get_offset_of_backVector_12() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___backVector_12)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_backVector_12() const { return ___backVector_12; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_backVector_12() { return &___backVector_12; }
	inline void set_backVector_12(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___backVector_12 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___positiveInfinityVector_13)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_positiveInfinityVector_13() const { return ___positiveInfinityVector_13; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_positiveInfinityVector_13() { return &___positiveInfinityVector_13; }
	inline void set_positiveInfinityVector_13(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___positiveInfinityVector_13 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_14() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___negativeInfinityVector_14)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_negativeInfinityVector_14() const { return ___negativeInfinityVector_14; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_negativeInfinityVector_14() { return &___negativeInfinityVector_14; }
	inline void set_negativeInfinityVector_14(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___negativeInfinityVector_14 = value;
	}
};


// UnityEngine.Vector4
struct Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 
{
public:
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;

public:
	inline static int32_t get_offset_of_x_1() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___x_1)); }
	inline float get_x_1() const { return ___x_1; }
	inline float* get_address_of_x_1() { return &___x_1; }
	inline void set_x_1(float value)
	{
		___x_1 = value;
	}

	inline static int32_t get_offset_of_y_2() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___y_2)); }
	inline float get_y_2() const { return ___y_2; }
	inline float* get_address_of_y_2() { return &___y_2; }
	inline void set_y_2(float value)
	{
		___y_2 = value;
	}

	inline static int32_t get_offset_of_z_3() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___z_3)); }
	inline float get_z_3() const { return ___z_3; }
	inline float* get_address_of_z_3() { return &___z_3; }
	inline void set_z_3(float value)
	{
		___z_3 = value;
	}

	inline static int32_t get_offset_of_w_4() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___w_4)); }
	inline float get_w_4() const { return ___w_4; }
	inline float* get_address_of_w_4() { return &___w_4; }
	inline void set_w_4(float value)
	{
		___w_4 = value;
	}
};

struct Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields
{
public:
	// UnityEngine.Vector4 UnityEngine.Vector4::zeroVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___zeroVector_5;
	// UnityEngine.Vector4 UnityEngine.Vector4::oneVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___oneVector_6;
	// UnityEngine.Vector4 UnityEngine.Vector4::positiveInfinityVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___positiveInfinityVector_7;
	// UnityEngine.Vector4 UnityEngine.Vector4::negativeInfinityVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___negativeInfinityVector_8;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___zeroVector_5)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___oneVector_6)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_7() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___positiveInfinityVector_7)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_positiveInfinityVector_7() const { return ___positiveInfinityVector_7; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_positiveInfinityVector_7() { return &___positiveInfinityVector_7; }
	inline void set_positiveInfinityVector_7(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___positiveInfinityVector_7 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___negativeInfinityVector_8)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_negativeInfinityVector_8() const { return ___negativeInfinityVector_8; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_negativeInfinityVector_8() { return &___negativeInfinityVector_8; }
	inline void set_negativeInfinityVector_8(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___negativeInfinityVector_8 = value;
	}
};


// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// UnityEngine.WaitForEndOfFrame
struct WaitForEndOfFrame_t082FDFEAAFF92937632C357C39E55C84B8FD06D4  : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF
{
public:

public:
};


// UnityEngine.WaitForFixedUpdate
struct WaitForFixedUpdate_t675FCE2AEFAC5C924A4020474C997FF2CDD3F4C5  : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF
{
public:

public:
};


// UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013  : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF
{
public:
	// System.Single UnityEngine.WaitForSeconds::m_Seconds
	float ___m_Seconds_0;

public:
	inline static int32_t get_offset_of_m_Seconds_0() { return static_cast<int32_t>(offsetof(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013, ___m_Seconds_0)); }
	inline float get_m_Seconds_0() const { return ___m_Seconds_0; }
	inline float* get_address_of_m_Seconds_0() { return &___m_Seconds_0; }
	inline void set_m_Seconds_0(float value)
	{
		___m_Seconds_0 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_pinvoke : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_pinvoke
{
	float ___m_Seconds_0;
};
// Native definition for COM marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_com : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_com
{
	float ___m_Seconds_0;
};

// UnityEngine.WaitForSecondsRealtime
struct WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40  : public CustomYieldInstruction_t4ED1543FBAA3143362854EB1867B42E5D190A5C7
{
public:
	// System.Single UnityEngine.WaitForSecondsRealtime::<waitTime>k__BackingField
	float ___U3CwaitTimeU3Ek__BackingField_0;
	// System.Single UnityEngine.WaitForSecondsRealtime::m_WaitUntilTime
	float ___m_WaitUntilTime_1;

public:
	inline static int32_t get_offset_of_U3CwaitTimeU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40, ___U3CwaitTimeU3Ek__BackingField_0)); }
	inline float get_U3CwaitTimeU3Ek__BackingField_0() const { return ___U3CwaitTimeU3Ek__BackingField_0; }
	inline float* get_address_of_U3CwaitTimeU3Ek__BackingField_0() { return &___U3CwaitTimeU3Ek__BackingField_0; }
	inline void set_U3CwaitTimeU3Ek__BackingField_0(float value)
	{
		___U3CwaitTimeU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_m_WaitUntilTime_1() { return static_cast<int32_t>(offsetof(WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40, ___m_WaitUntilTime_1)); }
	inline float get_m_WaitUntilTime_1() const { return ___m_WaitUntilTime_1; }
	inline float* get_address_of_m_WaitUntilTime_1() { return &___m_WaitUntilTime_1; }
	inline void set_m_WaitUntilTime_1(float value)
	{
		___m_WaitUntilTime_1 = value;
	}
};


// Unity.Collections.LowLevel.Unsafe.WriteAccessRequiredAttribute
struct WriteAccessRequiredAttribute_t801D798894A40E3789DE39CC4BE0D3B04B852DCA  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// Unity.Collections.WriteOnlyAttribute
struct WriteOnlyAttribute_t6897770F57B21F93E440F44DF3D1A5804D6019FA  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// UnityEngine.BeforeRenderHelper/OrderBlock
struct OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2 
{
public:
	// System.Int32 UnityEngine.BeforeRenderHelper/OrderBlock::order
	int32_t ___order_0;
	// UnityEngine.Events.UnityAction UnityEngine.BeforeRenderHelper/OrderBlock::callback
	UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * ___callback_1;

public:
	inline static int32_t get_offset_of_order_0() { return static_cast<int32_t>(offsetof(OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2, ___order_0)); }
	inline int32_t get_order_0() const { return ___order_0; }
	inline int32_t* get_address_of_order_0() { return &___order_0; }
	inline void set_order_0(int32_t value)
	{
		___order_0 = value;
	}

	inline static int32_t get_offset_of_callback_1() { return static_cast<int32_t>(offsetof(OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2, ___callback_1)); }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * get_callback_1() const { return ___callback_1; }
	inline UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 ** get_address_of_callback_1() { return &___callback_1; }
	inline void set_callback_1(UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099 * value)
	{
		___callback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callback_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.BeforeRenderHelper/OrderBlock
struct OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshaled_pinvoke
{
	int32_t ___order_0;
	Il2CppMethodPointer ___callback_1;
};
// Native definition for COM marshalling of UnityEngine.BeforeRenderHelper/OrderBlock
struct OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshaled_com
{
	int32_t ___order_0;
	Il2CppMethodPointer ___callback_1;
};

// UnityEngine.Rendering.CameraProperties/<layerCullDistances>e__FixedBuffer
struct U3ClayerCullDistancesU3Ee__FixedBuffer_tE71C7AFD9D79A3B7182FA61420BBC853479CB82D 
{
public:
	union
	{
		struct
		{
			// System.Single UnityEngine.Rendering.CameraProperties/<layerCullDistances>e__FixedBuffer::FixedElementField
			float ___FixedElementField_0;
		};
		uint8_t U3ClayerCullDistancesU3Ee__FixedBuffer_tE71C7AFD9D79A3B7182FA61420BBC853479CB82D__padding[128];
	};

public:
	inline static int32_t get_offset_of_FixedElementField_0() { return static_cast<int32_t>(offsetof(U3ClayerCullDistancesU3Ee__FixedBuffer_tE71C7AFD9D79A3B7182FA61420BBC853479CB82D, ___FixedElementField_0)); }
	inline float get_FixedElementField_0() const { return ___FixedElementField_0; }
	inline float* get_address_of_FixedElementField_0() { return &___FixedElementField_0; }
	inline void set_FixedElementField_0(float value)
	{
		___FixedElementField_0 = value;
	}
};


// UnityEngine.Rendering.CameraProperties/<m_CameraCullPlanes>e__FixedBuffer
struct U3Cm_CameraCullPlanesU3Ee__FixedBuffer_t59DEB93CDAC5F35F2FBBDE7FD1ACDEA5CBAE0715 
{
public:
	union
	{
		struct
		{
			// System.Byte UnityEngine.Rendering.CameraProperties/<m_CameraCullPlanes>e__FixedBuffer::FixedElementField
			uint8_t ___FixedElementField_0;
		};
		uint8_t U3Cm_CameraCullPlanesU3Ee__FixedBuffer_t59DEB93CDAC5F35F2FBBDE7FD1ACDEA5CBAE0715__padding[96];
	};

public:
	inline static int32_t get_offset_of_FixedElementField_0() { return static_cast<int32_t>(offsetof(U3Cm_CameraCullPlanesU3Ee__FixedBuffer_t59DEB93CDAC5F35F2FBBDE7FD1ACDEA5CBAE0715, ___FixedElementField_0)); }
	inline uint8_t get_FixedElementField_0() const { return ___FixedElementField_0; }
	inline uint8_t* get_address_of_FixedElementField_0() { return &___FixedElementField_0; }
	inline void set_FixedElementField_0(uint8_t value)
	{
		___FixedElementField_0 = value;
	}
};


// UnityEngine.Rendering.CameraProperties/<m_ShadowCullPlanes>e__FixedBuffer
struct U3Cm_ShadowCullPlanesU3Ee__FixedBuffer_t27C8A3E160EA9662D45EE3054CAB0B1E6900FDE2 
{
public:
	union
	{
		struct
		{
			// System.Byte UnityEngine.Rendering.CameraProperties/<m_ShadowCullPlanes>e__FixedBuffer::FixedElementField
			uint8_t ___FixedElementField_0;
		};
		uint8_t U3Cm_ShadowCullPlanesU3Ee__FixedBuffer_t27C8A3E160EA9662D45EE3054CAB0B1E6900FDE2__padding[96];
	};

public:
	inline static int32_t get_offset_of_FixedElementField_0() { return static_cast<int32_t>(offsetof(U3Cm_ShadowCullPlanesU3Ee__FixedBuffer_t27C8A3E160EA9662D45EE3054CAB0B1E6900FDE2, ___FixedElementField_0)); }
	inline uint8_t get_FixedElementField_0() const { return ___FixedElementField_0; }
	inline uint8_t* get_address_of_FixedElementField_0() { return &___FixedElementField_0; }
	inline void set_FixedElementField_0(uint8_t value)
	{
		___FixedElementField_0 = value;
	}
};


// UnityEngine.Rendering.DrawingSettings/<shaderPassNames>e__FixedBuffer
struct U3CshaderPassNamesU3Ee__FixedBuffer_tD1B82F2532DDB17723F27AB236D1A65F0A635DAF 
{
public:
	union
	{
		struct
		{
			// System.Int32 UnityEngine.Rendering.DrawingSettings/<shaderPassNames>e__FixedBuffer::FixedElementField
			int32_t ___FixedElementField_0;
		};
		uint8_t U3CshaderPassNamesU3Ee__FixedBuffer_tD1B82F2532DDB17723F27AB236D1A65F0A635DAF__padding[64];
	};

public:
	inline static int32_t get_offset_of_FixedElementField_0() { return static_cast<int32_t>(offsetof(U3CshaderPassNamesU3Ee__FixedBuffer_tD1B82F2532DDB17723F27AB236D1A65F0A635DAF, ___FixedElementField_0)); }
	inline int32_t get_FixedElementField_0() const { return ___FixedElementField_0; }
	inline int32_t* get_address_of_FixedElementField_0() { return &___FixedElementField_0; }
	inline void set_FixedElementField_0(int32_t value)
	{
		___FixedElementField_0 = value;
	}
};


// UnityEngine.PlayerLoop.EarlyUpdate/ARCoreUpdate
struct ARCoreUpdate_t345A656C10E6E775CE53726D062F4CECDACD7D56 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ARCoreUpdate_t345A656C10E6E775CE53726D062F4CECDACD7D56__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/AnalyticsCoreStatsUpdate
struct AnalyticsCoreStatsUpdate_t4A67F117F57258A558CE7C30ECD0DC6BD844E0BC 
{
public:
	union
	{
		struct
		{
		};
		uint8_t AnalyticsCoreStatsUpdate_t4A67F117F57258A558CE7C30ECD0DC6BD844E0BC__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/ClearIntermediateRenderers
struct ClearIntermediateRenderers_tAC7049D6072F90734E528B90B95C40CF7F90A748 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ClearIntermediateRenderers_tAC7049D6072F90734E528B90B95C40CF7F90A748__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/ClearLines
struct ClearLines_t07F570AD58667935AD12B63CD120E9BCB6E95D71 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ClearLines_t07F570AD58667935AD12B63CD120E9BCB6E95D71__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/DeliverIosPlatformEvents
struct DeliverIosPlatformEvents_t3BF56C33BEF28195805C74F0ED4B3F53BEDF9049 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DeliverIosPlatformEvents_t3BF56C33BEF28195805C74F0ED4B3F53BEDF9049__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/DispatchEventQueueEvents
struct DispatchEventQueueEvents_t57DA008DF9012DB2B7B7B093F66207E11F1801C7 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DispatchEventQueueEvents_t57DA008DF9012DB2B7B7B093F66207E11F1801C7__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/ExecuteMainThreadJobs
struct ExecuteMainThreadJobs_t178184E2A46BE6E4999FB4A6909DA0981128FF19 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ExecuteMainThreadJobs_t178184E2A46BE6E4999FB4A6909DA0981128FF19__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/GpuTimestamp
struct GpuTimestamp_t2AFDA2966ED888A5AD724AAB77422828D4ADBA7F 
{
public:
	union
	{
		struct
		{
		};
		uint8_t GpuTimestamp_t2AFDA2966ED888A5AD724AAB77422828D4ADBA7F__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/PerformanceAnalyticsUpdate
struct PerformanceAnalyticsUpdate_t1AE3F68BF048267B56AC956F28F48B286F2DB5C6 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PerformanceAnalyticsUpdate_t1AE3F68BF048267B56AC956F28F48B286F2DB5C6__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/PhysicsResetInterpolatedTransformPosition
struct PhysicsResetInterpolatedTransformPosition_t63FDDA90182BA3FA40B3D74870BC99958C67E18C 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PhysicsResetInterpolatedTransformPosition_t63FDDA90182BA3FA40B3D74870BC99958C67E18C__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/PlayerCleanupCachedData
struct PlayerCleanupCachedData_t59BB27B35F4901EFD5243D3ACB724C4AB760D97E 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PlayerCleanupCachedData_t59BB27B35F4901EFD5243D3ACB724C4AB760D97E__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/PollHtcsPlayerConnection
struct PollHtcsPlayerConnection_t0701098C7389B5A4ABE7B2D875AF7797FC693C63 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PollHtcsPlayerConnection_t0701098C7389B5A4ABE7B2D875AF7797FC693C63__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/PollPlayerConnection
struct PollPlayerConnection_tC440AA2EF4FFBE9A131CD21E28FD2C999C9699C9 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PollPlayerConnection_tC440AA2EF4FFBE9A131CD21E28FD2C999C9699C9__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/PresentBeforeUpdate
struct PresentBeforeUpdate_tF1A8E51EF605A45F3AFA67A3EC4F55D48483E2D0 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PresentBeforeUpdate_tF1A8E51EF605A45F3AFA67A3EC4F55D48483E2D0__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/ProcessMouseInWindow
struct ProcessMouseInWindow_t5E3FFEFC4E6FC09E607DACE6E0CA8DF0CDADFAE6 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ProcessMouseInWindow_t5E3FFEFC4E6FC09E607DACE6E0CA8DF0CDADFAE6__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/ProcessRemoteInput
struct ProcessRemoteInput_t42D081A550685F4C78E334CA381D184F08FB62F3 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ProcessRemoteInput_t42D081A550685F4C78E334CA381D184F08FB62F3__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/ProfilerStartFrame
struct ProfilerStartFrame_tAC3E2CF0778F729F11D08358849F7CD4CD585E7C 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ProfilerStartFrame_tAC3E2CF0778F729F11D08358849F7CD4CD585E7C__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/RendererNotifyInvisible
struct RendererNotifyInvisible_t8ED1E3B4D8DE9D108C6EA967C5DB4B59A5BD48E5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t RendererNotifyInvisible_t8ED1E3B4D8DE9D108C6EA967C5DB4B59A5BD48E5__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/ResetFrameStatsAfterPresent
struct ResetFrameStatsAfterPresent_t7E3F5B7774CBAD72CB6EAF576B64A4D7AF24D1D4 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ResetFrameStatsAfterPresent_t7E3F5B7774CBAD72CB6EAF576B64A4D7AF24D1D4__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/ScriptRunDelayedStartupFrame
struct ScriptRunDelayedStartupFrame_tCD3EB2C533206E2243EDBEC265AE32D963A12298 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ScriptRunDelayedStartupFrame_tCD3EB2C533206E2243EDBEC265AE32D963A12298__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/SpriteAtlasManagerUpdate
struct SpriteAtlasManagerUpdate_t98936A7616CEE98F8447488F9CC817448529250F 
{
public:
	union
	{
		struct
		{
		};
		uint8_t SpriteAtlasManagerUpdate_t98936A7616CEE98F8447488F9CC817448529250F__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/TangoUpdate
struct TangoUpdate_tD6640C8082DC2C21F7864C6D5D5606C435455A68 
{
public:
	union
	{
		struct
		{
		};
		uint8_t TangoUpdate_tD6640C8082DC2C21F7864C6D5D5606C435455A68__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UnityWebRequestUpdate
struct UnityWebRequestUpdate_t893B39AA3BF55998BCBF9F6C33C3A24146456781 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UnityWebRequestUpdate_t893B39AA3BF55998BCBF9F6C33C3A24146456781__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdateAsyncReadbackManager
struct UpdateAsyncReadbackManager_t432611386C4251CC08B4CA68843AAE1B049D116F 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateAsyncReadbackManager_t432611386C4251CC08B4CA68843AAE1B049D116F__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdateAutoStreamer
struct UpdateAutoStreamer_t7D973CF64989CFDD36D200878B3211ECD60EE06E 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateAutoStreamer_t7D973CF64989CFDD36D200878B3211ECD60EE06E__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdateCanvasRectTransform
struct UpdateCanvasRectTransform_t6BD3BF9EC17DC88DCCACE9DA694623B8184D4C08 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateCanvasRectTransform_t6BD3BF9EC17DC88DCCACE9DA694623B8184D4C08__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdateInputManager
struct UpdateInputManager_t4624AF2E3D5322A456E241653B288D4407A070D7 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateInputManager_t4624AF2E3D5322A456E241653B288D4407A070D7__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdateKinect
struct UpdateKinect_t5BDA1D122E2563A2BD5C16B5BFC9675704984331 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateKinect_t5BDA1D122E2563A2BD5C16B5BFC9675704984331__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdateMainGameViewRect
struct UpdateMainGameViewRect_tF94FDE58A08AA15EE7B31E9090AC23CD08BF9080 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateMainGameViewRect_tF94FDE58A08AA15EE7B31E9090AC23CD08BF9080__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdatePreloading
struct UpdatePreloading_t29F051FCC78430BB557F67F99A1E24431DF85AB4 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdatePreloading_t29F051FCC78430BB557F67F99A1E24431DF85AB4__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdateStreamingManager
struct UpdateStreamingManager_tCAB478C327FDE15704577ED0A7CA8A22B2BB8554 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateStreamingManager_tCAB478C327FDE15704577ED0A7CA8A22B2BB8554__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/UpdateTextureStreamingManager
struct UpdateTextureStreamingManager_tD08A0C8DDF3E6C7970AA5A651B0163D449C21A3A 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateTextureStreamingManager_tD08A0C8DDF3E6C7970AA5A651B0163D449C21A3A__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.EarlyUpdate/XRUpdate
struct XRUpdate_t718B5C2C28DAC016453B3B52D02EEE90D546A495 
{
public:
	union
	{
		struct
		{
		};
		uint8_t XRUpdate_t718B5C2C28DAC016453B3B52D02EEE90D546A495__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/AudioFixedUpdate
struct AudioFixedUpdate_t7BB8352EC33E8541EAE347A6ECE127618C347C71 
{
public:
	union
	{
		struct
		{
		};
		uint8_t AudioFixedUpdate_t7BB8352EC33E8541EAE347A6ECE127618C347C71__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/ClearLines
struct ClearLines_t1D6D67DA1401D35D871A126DB5A5EF69CCD57721 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ClearLines_t1D6D67DA1401D35D871A126DB5A5EF69CCD57721__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/DirectorFixedSampleTime
struct DirectorFixedSampleTime_t407AD40EC7E9155C6016F3C38DA8B626FF5495D2 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorFixedSampleTime_t407AD40EC7E9155C6016F3C38DA8B626FF5495D2__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/DirectorFixedUpdate
struct DirectorFixedUpdate_tC33E95FDFBA813B63A0AD9A8446234869AE0EDDA 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorFixedUpdate_tC33E95FDFBA813B63A0AD9A8446234869AE0EDDA__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/DirectorFixedUpdatePostPhysics
struct DirectorFixedUpdatePostPhysics_t1ADEB661939FF1C092B77D6E72D0B84C2B357346 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorFixedUpdatePostPhysics_t1ADEB661939FF1C092B77D6E72D0B84C2B357346__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/LegacyFixedAnimationUpdate
struct LegacyFixedAnimationUpdate_tA84F66DFD94D3FC2604C0AD276D9D61D1039A351 
{
public:
	union
	{
		struct
		{
		};
		uint8_t LegacyFixedAnimationUpdate_tA84F66DFD94D3FC2604C0AD276D9D61D1039A351__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/NewInputFixedUpdate
struct NewInputFixedUpdate_t988F4AAC48EC31DD66EAC14BE6EC2DF37ACC10CC 
{
public:
	union
	{
		struct
		{
		};
		uint8_t NewInputFixedUpdate_t988F4AAC48EC31DD66EAC14BE6EC2DF37ACC10CC__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/Physics2DFixedUpdate
struct Physics2DFixedUpdate_t4A442ECBB32F36838F630AC8A06CDC557C8C0B68 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Physics2DFixedUpdate_t4A442ECBB32F36838F630AC8A06CDC557C8C0B68__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/PhysicsClothFixedUpdate
struct PhysicsClothFixedUpdate_t3CEB0DDEB572CBD9C45085F56EC6788F7EEEB275 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PhysicsClothFixedUpdate_t3CEB0DDEB572CBD9C45085F56EC6788F7EEEB275__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/PhysicsFixedUpdate
struct PhysicsFixedUpdate_t46121810B20B779B5BA50C78BC94DE2ABEB4D0C2 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PhysicsFixedUpdate_t46121810B20B779B5BA50C78BC94DE2ABEB4D0C2__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/ScriptRunBehaviourFixedUpdate
struct ScriptRunBehaviourFixedUpdate_t7FE48475D8C09E8A4FF93E60B9CEA5B69EC9B203 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ScriptRunBehaviourFixedUpdate_t7FE48475D8C09E8A4FF93E60B9CEA5B69EC9B203__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/ScriptRunDelayedFixedFrameRate
struct ScriptRunDelayedFixedFrameRate_t85D2FB79D04C22A2A6C8FD81A9B32D9930C23297 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ScriptRunDelayedFixedFrameRate_t85D2FB79D04C22A2A6C8FD81A9B32D9930C23297__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.FixedUpdate/XRFixedUpdate
struct XRFixedUpdate_t6A63A12A03ABAACF0B95B921C5CC15484C467132 
{
public:
	union
	{
		struct
		{
		};
		uint8_t XRFixedUpdate_t6A63A12A03ABAACF0B95B921C5CC15484C467132__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Initialization/AsyncUploadTimeSlicedUpdate
struct AsyncUploadTimeSlicedUpdate_t47FF6A1EB31C45CA8BD817C6D50FCF55CAD91610 
{
public:
	union
	{
		struct
		{
		};
		uint8_t AsyncUploadTimeSlicedUpdate_t47FF6A1EB31C45CA8BD817C6D50FCF55CAD91610__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Initialization/DirectorSampleTime
struct DirectorSampleTime_tF12AFDE1C2F301238588429E1D63F4B7D28FFA51 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorSampleTime_tF12AFDE1C2F301238588429E1D63F4B7D28FFA51__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Initialization/SynchronizeInputs
struct SynchronizeInputs_t4F1F899CB89A9DF9090DEBDF21425980C1A216C0 
{
public:
	union
	{
		struct
		{
		};
		uint8_t SynchronizeInputs_t4F1F899CB89A9DF9090DEBDF21425980C1A216C0__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Initialization/SynchronizeState
struct SynchronizeState_tC915C418D749E282696E2D2DC6080CE18C4ABDFA 
{
public:
	union
	{
		struct
		{
		};
		uint8_t SynchronizeState_tC915C418D749E282696E2D2DC6080CE18C4ABDFA__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Initialization/UpdateCameraMotionVectors
struct UpdateCameraMotionVectors_t2D7D3155FCE58E4F0AE638F4C99CAD66E23FA8E7 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateCameraMotionVectors_t2D7D3155FCE58E4F0AE638F4C99CAD66E23FA8E7__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Initialization/XREarlyUpdate
struct XREarlyUpdate_t9F969CD15ECD221891055EB60CE7A879B6A1AE86 
{
public:
	union
	{
		struct
		{
		};
		uint8_t XREarlyUpdate_t9F969CD15ECD221891055EB60CE7A879B6A1AE86__padding[1];
	};

public:
};


// UnityEngine.Mesh/MeshDataArray
struct MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 
{
public:
	// System.IntPtr* UnityEngine.Mesh/MeshDataArray::m_Ptrs
	intptr_t* ___m_Ptrs_0;
	// System.Int32 UnityEngine.Mesh/MeshDataArray::m_Length
	int32_t ___m_Length_1;

public:
	inline static int32_t get_offset_of_m_Ptrs_0() { return static_cast<int32_t>(offsetof(MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26, ___m_Ptrs_0)); }
	inline intptr_t* get_m_Ptrs_0() const { return ___m_Ptrs_0; }
	inline intptr_t** get_address_of_m_Ptrs_0() { return &___m_Ptrs_0; }
	inline void set_m_Ptrs_0(intptr_t* value)
	{
		___m_Ptrs_0 = value;
	}

	inline static int32_t get_offset_of_m_Length_1() { return static_cast<int32_t>(offsetof(MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26, ___m_Length_1)); }
	inline int32_t get_m_Length_1() const { return ___m_Length_1; }
	inline int32_t* get_address_of_m_Length_1() { return &___m_Length_1; }
	inline void set_m_Length_1(int32_t value)
	{
		___m_Length_1 = value;
	}
};


// UnityEngine.PlayerLoop.PostLateUpdate/BatchModeUpdate
struct BatchModeUpdate_t8C6F527A5CA9A7A8E9CCCA61F2E99448C18AEAD2 
{
public:
	union
	{
		struct
		{
		};
		uint8_t BatchModeUpdate_t8C6F527A5CA9A7A8E9CCCA61F2E99448C18AEAD2__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ClearImmediateRenderers
struct ClearImmediateRenderers_t37FCF798A50163FCAE31F618A88AA0928C40CAFB 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ClearImmediateRenderers_t37FCF798A50163FCAE31F618A88AA0928C40CAFB__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/DirectorLateUpdate
struct DirectorLateUpdate_t77313447CF25B5FBC7F6A738FC6B6FE4FB7D3B0E 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorLateUpdate_t77313447CF25B5FBC7F6A738FC6B6FE4FB7D3B0E__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/DirectorRenderImage
struct DirectorRenderImage_t18FF15945AD4A75A4E38086E7E50F0839A6085B9 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorRenderImage_t18FF15945AD4A75A4E38086E7E50F0839A6085B9__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/EndGraphicsJobsAfterScriptLateUpdate
struct EndGraphicsJobsAfterScriptLateUpdate_tE1D20D73472F346D7745C213712D90496E6E9350 
{
public:
	union
	{
		struct
		{
		};
		uint8_t EndGraphicsJobsAfterScriptLateUpdate_tE1D20D73472F346D7745C213712D90496E6E9350__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/EnlightenRuntimeUpdate
struct EnlightenRuntimeUpdate_t0F7246E586E8744EBF22C6E557A5CDD79D42512F 
{
public:
	union
	{
		struct
		{
		};
		uint8_t EnlightenRuntimeUpdate_t0F7246E586E8744EBF22C6E557A5CDD79D42512F__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ExecuteGameCenterCallbacks
struct ExecuteGameCenterCallbacks_t6AAA6429F53079FA5779EC93FF422C45F39B6A69 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ExecuteGameCenterCallbacks_t6AAA6429F53079FA5779EC93FF422C45F39B6A69__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/FinishFrameRendering
struct FinishFrameRendering_t6D8F987520D0CABFB634214E47EA6C98A1DE69F5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t FinishFrameRendering_t6D8F987520D0CABFB634214E47EA6C98A1DE69F5__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/GUIClearEvents
struct GUIClearEvents_t2ACF18A4B2C80DFB240DBE01D7B0B0751C3042ED 
{
public:
	union
	{
		struct
		{
		};
		uint8_t GUIClearEvents_t2ACF18A4B2C80DFB240DBE01D7B0B0751C3042ED__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/InputEndFrame
struct InputEndFrame_t4E00F58665EC8A4AC407107E6AD65F8D9BE5D496 
{
public:
	union
	{
		struct
		{
		};
		uint8_t InputEndFrame_t4E00F58665EC8A4AC407107E6AD65F8D9BE5D496__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/MemoryFrameMaintenance
struct MemoryFrameMaintenance_t8641D3964D8E591E9924C60B849CFC8E13781FCA 
{
public:
	union
	{
		struct
		{
		};
		uint8_t MemoryFrameMaintenance_t8641D3964D8E591E9924C60B849CFC8E13781FCA__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ParticleSystemEndUpdateAll
struct ParticleSystemEndUpdateAll_t0C9862FC07BF69AEC1B23295BF70D3F4862D9DE8 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ParticleSystemEndUpdateAll_t0C9862FC07BF69AEC1B23295BF70D3F4862D9DE8__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/PhysicsSkinnedClothBeginUpdate
struct PhysicsSkinnedClothBeginUpdate_t23CEEF7DB8085BB3831A7670928EDD96A0BD36C1 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PhysicsSkinnedClothBeginUpdate_t23CEEF7DB8085BB3831A7670928EDD96A0BD36C1__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/PhysicsSkinnedClothFinishUpdate
struct PhysicsSkinnedClothFinishUpdate_tA2BC6F1632D750962DBB9A5331B880A3964D17C0 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PhysicsSkinnedClothFinishUpdate_tA2BC6F1632D750962DBB9A5331B880A3964D17C0__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/PlayerEmitCanvasGeometry
struct PlayerEmitCanvasGeometry_tD6837358BC1539ED3BFDA4A14DBA2634D21C7278 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PlayerEmitCanvasGeometry_tD6837358BC1539ED3BFDA4A14DBA2634D21C7278__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/PlayerSendFrameComplete
struct PlayerSendFrameComplete_tFCB4A131339039D456553596DC33CD625CFF7AAC 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PlayerSendFrameComplete_tFCB4A131339039D456553596DC33CD625CFF7AAC__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/PlayerSendFramePostPresent
struct PlayerSendFramePostPresent_t2F6B4A129327E35A001A0C0808FEFF20D1BAFCB6 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PlayerSendFramePostPresent_t2F6B4A129327E35A001A0C0808FEFF20D1BAFCB6__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/PlayerSendFrameStarted
struct PlayerSendFrameStarted_tBE2DDEEFF66EAD5BFC54776035F83F2BBFDC866A 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PlayerSendFrameStarted_tBE2DDEEFF66EAD5BFC54776035F83F2BBFDC866A__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/PlayerUpdateCanvases
struct PlayerUpdateCanvases_tA3BDD28A248E9294BBA8E93C53AF78B902A24CD4 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PlayerUpdateCanvases_tA3BDD28A248E9294BBA8E93C53AF78B902A24CD4__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/PresentAfterDraw
struct PresentAfterDraw_t26958AF5B43FD8A6101C88833BC41A0F5CE9830A 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PresentAfterDraw_t26958AF5B43FD8A6101C88833BC41A0F5CE9830A__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ProcessWebSendMessages
struct ProcessWebSendMessages_t5AD55E51AED08DA28C11DF31783B07C7A5128124 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ProcessWebSendMessages_t5AD55E51AED08DA28C11DF31783B07C7A5128124__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ProfilerEndFrame
struct ProfilerEndFrame_t9D91D2F297E099F92D03834C9FBFF860A8EF45DD 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ProfilerEndFrame_t9D91D2F297E099F92D03834C9FBFF860A8EF45DD__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ProfilerSynchronizeStats
struct ProfilerSynchronizeStats_t8B0F4436679D8BAF7D86793D207AD90477D601BB 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ProfilerSynchronizeStats_t8B0F4436679D8BAF7D86793D207AD90477D601BB__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ResetInputAxis
struct ResetInputAxis_t585B9BDCE262954A57C75B9492FCF7146662E21C 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ResetInputAxis_t585B9BDCE262954A57C75B9492FCF7146662E21C__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ScriptRunDelayedDynamicFrameRate
struct ScriptRunDelayedDynamicFrameRate_t6D962FA77CFBF776A2D946C07C567B795CF671B4 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ScriptRunDelayedDynamicFrameRate_t6D962FA77CFBF776A2D946C07C567B795CF671B4__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ShaderHandleErrors
struct ShaderHandleErrors_t2A99C9332EC9DE30DD16AF1FD18C582E5B02AE92 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ShaderHandleErrors_t2A99C9332EC9DE30DD16AF1FD18C582E5B02AE92__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/SortingGroupsUpdate
struct SortingGroupsUpdate_tBC21E7D8B383652646C08B9AE743A7EC38733CEF 
{
public:
	union
	{
		struct
		{
		};
		uint8_t SortingGroupsUpdate_tBC21E7D8B383652646C08B9AE743A7EC38733CEF__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/ThreadedLoadingDebug
struct ThreadedLoadingDebug_t12597D128CC91C40B4C874800B0C3AEBF7DAD04B 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ThreadedLoadingDebug_t12597D128CC91C40B4C874800B0C3AEBF7DAD04B__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/TriggerEndOfFrameCallbacks
struct TriggerEndOfFrameCallbacks_tB5DD4CDE53AB8C30E72194AB21AFE73BFB4DC424 
{
public:
	union
	{
		struct
		{
		};
		uint8_t TriggerEndOfFrameCallbacks_tB5DD4CDE53AB8C30E72194AB21AFE73BFB4DC424__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UIWidgetsVSync
struct UIWidgetsVSync_tF45F16B02A0B88C293EF13A103370434DF4E8805 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UIWidgetsVSync_tF45F16B02A0B88C293EF13A103370434DF4E8805__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UIWidgetsWait
struct UIWidgetsWait_tED9A39DD45CDD7F0FB27744C8C63B0B40E817DF6 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UIWidgetsWait_tED9A39DD45CDD7F0FB27744C8C63B0B40E817DF6__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateAllRenderers
struct UpdateAllRenderers_t96FC2DF53BC1D90C7E40E2CAD10B8C674A94B86C 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateAllRenderers_t96FC2DF53BC1D90C7E40E2CAD10B8C674A94B86C__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateAllSkinnedMeshes
struct UpdateAllSkinnedMeshes_tC6792E38655DE2113814AC6A642B3D937D6640F6 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateAllSkinnedMeshes_tC6792E38655DE2113814AC6A642B3D937D6640F6__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateAudio
struct UpdateAudio_t87394777AB6FE384B45C0C013722C1F68A60CF58 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateAudio_t87394777AB6FE384B45C0C013722C1F68A60CF58__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateCanvasRectTransform
struct UpdateCanvasRectTransform_t4E5EA2B18FCFD686E1F2052517657E391709422A 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateCanvasRectTransform_t4E5EA2B18FCFD686E1F2052517657E391709422A__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateCaptureScreenshot
struct UpdateCaptureScreenshot_t4FC86A971BE4E341EE83B9BCF72D3642CB67E483 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateCaptureScreenshot_t4FC86A971BE4E341EE83B9BCF72D3642CB67E483__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateCustomRenderTextures
struct UpdateCustomRenderTextures_t52B541FA5A7354ED440E274C6E357EBAA3F4C031 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateCustomRenderTextures_t52B541FA5A7354ED440E274C6E357EBAA3F4C031__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateLightProbeProxyVolumes
struct UpdateLightProbeProxyVolumes_t42C724BC635B9701939388DCB63A3FF0E882EA3E 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateLightProbeProxyVolumes_t42C724BC635B9701939388DCB63A3FF0E882EA3E__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateRectTransform
struct UpdateRectTransform_t6290D8B6BF5E990B5F706FE60B4A5CD954D72F13 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateRectTransform_t6290D8B6BF5E990B5F706FE60B4A5CD954D72F13__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateResolution
struct UpdateResolution_t8394E04EF0F5C04C0C65B1DF23F0E3E700144B45 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateResolution_t8394E04EF0F5C04C0C65B1DF23F0E3E700144B45__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateSubstance
struct UpdateSubstance_tC6E01D9640025CD7D0B09D636C02172D22F66967 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateSubstance_tC6E01D9640025CD7D0B09D636C02172D22F66967__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateVideo
struct UpdateVideo_t1E34A645DFD2C4E5243980D958392F6969F3D064 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateVideo_t1E34A645DFD2C4E5243980D958392F6969F3D064__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/UpdateVideoTextures
struct UpdateVideoTextures_t05417287668B8B95121C4236FD3A419DAC091BB5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateVideoTextures_t05417287668B8B95121C4236FD3A419DAC091BB5__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/VFXUpdate
struct VFXUpdate_tA520740E78D381B2830822C7FE90A203478B2214 
{
public:
	union
	{
		struct
		{
		};
		uint8_t VFXUpdate_tA520740E78D381B2830822C7FE90A203478B2214__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/XRPostLateUpdate
struct XRPostLateUpdate_t2DCEBE93C7B7994BC1888C2BF003C386E131DEB5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t XRPostLateUpdate_t2DCEBE93C7B7994BC1888C2BF003C386E131DEB5__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/XRPostPresent
struct XRPostPresent_t1B355F20B2823F13F6FBC66E36526B280B7EA85C 
{
public:
	union
	{
		struct
		{
		};
		uint8_t XRPostPresent_t1B355F20B2823F13F6FBC66E36526B280B7EA85C__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PostLateUpdate/XRPreEndFrame
struct XRPreEndFrame_t35AEF9FB00F67C92D7A01AFDBB56D2FC3CC3A251 
{
public:
	union
	{
		struct
		{
		};
		uint8_t XRPreEndFrame_t35AEF9FB00F67C92D7A01AFDBB56D2FC3CC3A251__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/AIUpdatePostScript
struct AIUpdatePostScript_t8A88713869A78E54E8A68D01A2DAE28612B31BE4 
{
public:
	union
	{
		struct
		{
		};
		uint8_t AIUpdatePostScript_t8A88713869A78E54E8A68D01A2DAE28612B31BE4__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/ConstraintManagerUpdate
struct ConstraintManagerUpdate_t60B829793DBE56E48C551CA2FC80F7FE82EC0090 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ConstraintManagerUpdate_t60B829793DBE56E48C551CA2FC80F7FE82EC0090__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/DirectorDeferredEvaluate
struct DirectorDeferredEvaluate_t1ADCC8CADAB3489481182AE5AE94F2218BA8E08F 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorDeferredEvaluate_t1ADCC8CADAB3489481182AE5AE94F2218BA8E08F__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/DirectorUpdateAnimationBegin
struct DirectorUpdateAnimationBegin_t1F818F8031BEDE2CDC67F69C0CDFF860F2063A74 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorUpdateAnimationBegin_t1F818F8031BEDE2CDC67F69C0CDFF860F2063A74__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/DirectorUpdateAnimationEnd
struct DirectorUpdateAnimationEnd_tDFC00FCAC7FBFD798572D224654127451FF4CEC1 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorUpdateAnimationEnd_tDFC00FCAC7FBFD798572D224654127451FF4CEC1__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/EndGraphicsJobsAfterScriptUpdate
struct EndGraphicsJobsAfterScriptUpdate_tD208592C17EBA50EB4E2E9B4E4C64C9122AE3C96 
{
public:
	union
	{
		struct
		{
		};
		uint8_t EndGraphicsJobsAfterScriptUpdate_tD208592C17EBA50EB4E2E9B4E4C64C9122AE3C96__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/LegacyAnimationUpdate
struct LegacyAnimationUpdate_t4838E9C42DDCC98CF195A798F73DD5E57F559A37 
{
public:
	union
	{
		struct
		{
		};
		uint8_t LegacyAnimationUpdate_t4838E9C42DDCC98CF195A798F73DD5E57F559A37__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/ParticleSystemBeginUpdateAll
struct ParticleSystemBeginUpdateAll_t87DCB20B8C93E68E52B943F1E3B31BB091FCA078 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ParticleSystemBeginUpdateAll_t87DCB20B8C93E68E52B943F1E3B31BB091FCA078__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/Physics2DLateUpdate
struct Physics2DLateUpdate_t9102D905FE91BCB2893E02C6824C5AAC56B47072 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Physics2DLateUpdate_t9102D905FE91BCB2893E02C6824C5AAC56B47072__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/ScriptRunBehaviourLateUpdate
struct ScriptRunBehaviourLateUpdate_t58F4C9331E2958013C6CB7FEF18E370AD5043B9A 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ScriptRunBehaviourLateUpdate_t58F4C9331E2958013C6CB7FEF18E370AD5043B9A__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/UIElementsUpdatePanels
struct UIElementsUpdatePanels_t88C1C5E585CBE9C5230CD7862714798690BF034F 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UIElementsUpdatePanels_t88C1C5E585CBE9C5230CD7862714798690BF034F__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/UNetUpdate
struct UNetUpdate_tDD911C7D34BC0CE4B5C79DD46C45285E224E21B2 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UNetUpdate_tDD911C7D34BC0CE4B5C79DD46C45285E224E21B2__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/UpdateMasterServerInterface
struct UpdateMasterServerInterface_t1F40E6F5C301466C446578EF63381B5D1C8DA187 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateMasterServerInterface_t1F40E6F5C301466C446578EF63381B5D1C8DA187__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreLateUpdate/UpdateNetworkManager
struct UpdateNetworkManager_tBEE4C45468BA0C0DBA98B8C25FC315233267AE2C 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateNetworkManager_tBEE4C45468BA0C0DBA98B8C25FC315233267AE2C__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/AIUpdate
struct AIUpdate_tACDB7E77F804905AFC0D39674778A62488A22CE2 
{
public:
	union
	{
		struct
		{
		};
		uint8_t AIUpdate_tACDB7E77F804905AFC0D39674778A62488A22CE2__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/CheckTexFieldInput
struct CheckTexFieldInput_t1FA363405F456B111E58078F4EFAB82912734432 
{
public:
	union
	{
		struct
		{
		};
		uint8_t CheckTexFieldInput_t1FA363405F456B111E58078F4EFAB82912734432__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/IMGUISendQueuedEvents
struct IMGUISendQueuedEvents_tF513CA3C17A07868E255F8D5A34C284803A22767 
{
public:
	union
	{
		struct
		{
		};
		uint8_t IMGUISendQueuedEvents_tF513CA3C17A07868E255F8D5A34C284803A22767__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/NewInputUpdate
struct NewInputUpdate_tF98FD69B5E9EAFEA02964DFFE852FF6029676308 
{
public:
	union
	{
		struct
		{
		};
		uint8_t NewInputUpdate_tF98FD69B5E9EAFEA02964DFFE852FF6029676308__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/Physics2DUpdate
struct Physics2DUpdate_tDC29C716549E1E860FD67BF84EF243D3BA595A60 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Physics2DUpdate_tDC29C716549E1E860FD67BF84EF243D3BA595A60__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/PhysicsUpdate
struct PhysicsUpdate_tF321BF0A833E955AED90F182BBC9D6D7D40F2F25 
{
public:
	union
	{
		struct
		{
		};
		uint8_t PhysicsUpdate_tF321BF0A833E955AED90F182BBC9D6D7D40F2F25__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/SendMouseEvents
struct SendMouseEvents_t2D84BCC439FE9A04E341AD07ECEBF4E8B12D2F9D 
{
public:
	union
	{
		struct
		{
		};
		uint8_t SendMouseEvents_t2D84BCC439FE9A04E341AD07ECEBF4E8B12D2F9D__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/UpdateVideo
struct UpdateVideo_tE460041F5545E24C8A107B563F971F491286C0BD 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UpdateVideo_tE460041F5545E24C8A107B563F971F491286C0BD__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.PreUpdate/WindUpdate
struct WindUpdate_t40BB9BF39AEE43023A49F0335A9DAC9F91E43150 
{
public:
	union
	{
		struct
		{
		};
		uint8_t WindUpdate_t40BB9BF39AEE43023A49F0335A9DAC9F91E43150__padding[1];
	};

public:
};


// UnityEngine.Random/State
struct State_t8E62E640CAE29BF61164F51619D1C04936074C15 
{
public:
	// System.Int32 UnityEngine.Random/State::s0
	int32_t ___s0_0;
	// System.Int32 UnityEngine.Random/State::s1
	int32_t ___s1_1;
	// System.Int32 UnityEngine.Random/State::s2
	int32_t ___s2_2;
	// System.Int32 UnityEngine.Random/State::s3
	int32_t ___s3_3;

public:
	inline static int32_t get_offset_of_s0_0() { return static_cast<int32_t>(offsetof(State_t8E62E640CAE29BF61164F51619D1C04936074C15, ___s0_0)); }
	inline int32_t get_s0_0() const { return ___s0_0; }
	inline int32_t* get_address_of_s0_0() { return &___s0_0; }
	inline void set_s0_0(int32_t value)
	{
		___s0_0 = value;
	}

	inline static int32_t get_offset_of_s1_1() { return static_cast<int32_t>(offsetof(State_t8E62E640CAE29BF61164F51619D1C04936074C15, ___s1_1)); }
	inline int32_t get_s1_1() const { return ___s1_1; }
	inline int32_t* get_address_of_s1_1() { return &___s1_1; }
	inline void set_s1_1(int32_t value)
	{
		___s1_1 = value;
	}

	inline static int32_t get_offset_of_s2_2() { return static_cast<int32_t>(offsetof(State_t8E62E640CAE29BF61164F51619D1C04936074C15, ___s2_2)); }
	inline int32_t get_s2_2() const { return ___s2_2; }
	inline int32_t* get_address_of_s2_2() { return &___s2_2; }
	inline void set_s2_2(int32_t value)
	{
		___s2_2 = value;
	}

	inline static int32_t get_offset_of_s3_3() { return static_cast<int32_t>(offsetof(State_t8E62E640CAE29BF61164F51619D1C04936074C15, ___s3_3)); }
	inline int32_t get_s3_3() const { return ___s3_3; }
	inline int32_t* get_address_of_s3_3() { return &___s3_3; }
	inline void set_s3_3(int32_t value)
	{
		___s3_3 = value;
	}
};


// UnityEngine.Rendering.ScriptableCullingParameters/<m_CullingPlanes>e__FixedBuffer
struct U3Cm_CullingPlanesU3Ee__FixedBuffer_t68E97CADA0C5FB08E8F025822CDE2CC1B8CC1490 
{
public:
	union
	{
		struct
		{
			// System.Byte UnityEngine.Rendering.ScriptableCullingParameters/<m_CullingPlanes>e__FixedBuffer::FixedElementField
			uint8_t ___FixedElementField_0;
		};
		uint8_t U3Cm_CullingPlanesU3Ee__FixedBuffer_t68E97CADA0C5FB08E8F025822CDE2CC1B8CC1490__padding[160];
	};

public:
	inline static int32_t get_offset_of_FixedElementField_0() { return static_cast<int32_t>(offsetof(U3Cm_CullingPlanesU3Ee__FixedBuffer_t68E97CADA0C5FB08E8F025822CDE2CC1B8CC1490, ___FixedElementField_0)); }
	inline uint8_t get_FixedElementField_0() const { return ___FixedElementField_0; }
	inline uint8_t* get_address_of_FixedElementField_0() { return &___FixedElementField_0; }
	inline void set_FixedElementField_0(uint8_t value)
	{
		___FixedElementField_0 = value;
	}
};


// UnityEngine.Rendering.ScriptableCullingParameters/<m_LayerFarCullDistances>e__FixedBuffer
struct U3Cm_LayerFarCullDistancesU3Ee__FixedBuffer_t5B7FC7CD51D4855019C575D8B77A38581146E884 
{
public:
	union
	{
		struct
		{
			// System.Single UnityEngine.Rendering.ScriptableCullingParameters/<m_LayerFarCullDistances>e__FixedBuffer::FixedElementField
			float ___FixedElementField_0;
		};
		uint8_t U3Cm_LayerFarCullDistancesU3Ee__FixedBuffer_t5B7FC7CD51D4855019C575D8B77A38581146E884__padding[128];
	};

public:
	inline static int32_t get_offset_of_FixedElementField_0() { return static_cast<int32_t>(offsetof(U3Cm_LayerFarCullDistancesU3Ee__FixedBuffer_t5B7FC7CD51D4855019C575D8B77A38581146E884, ___FixedElementField_0)); }
	inline float get_FixedElementField_0() const { return ___FixedElementField_0; }
	inline float* get_address_of_FixedElementField_0() { return &___FixedElementField_0; }
	inline void set_FixedElementField_0(float value)
	{
		___FixedElementField_0 = value;
	}
};


// UnityEngine.ScriptingUtility/TestClass
struct TestClass_tE31E21A91B6A07C4CA1720FE6B57C980181F3F2C 
{
public:
	// System.Int32 UnityEngine.ScriptingUtility/TestClass::value
	int32_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(TestClass_tE31E21A91B6A07C4CA1720FE6B57C980181F3F2C, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}
};


// UnityEngine.Rendering.ShadowSplitData/<m_CullingPlanes>e__FixedBuffer
struct U3Cm_CullingPlanesU3Ee__FixedBuffer_t83A9378FE5BA54A07D7E8542C5D1FE3A666ECA4C 
{
public:
	union
	{
		struct
		{
			// System.Byte UnityEngine.Rendering.ShadowSplitData/<m_CullingPlanes>e__FixedBuffer::FixedElementField
			uint8_t ___FixedElementField_0;
		};
		uint8_t U3Cm_CullingPlanesU3Ee__FixedBuffer_t83A9378FE5BA54A07D7E8542C5D1FE3A666ECA4C__padding[160];
	};

public:
	inline static int32_t get_offset_of_FixedElementField_0() { return static_cast<int32_t>(offsetof(U3Cm_CullingPlanesU3Ee__FixedBuffer_t83A9378FE5BA54A07D7E8542C5D1FE3A666ECA4C, ___FixedElementField_0)); }
	inline uint8_t get_FixedElementField_0() const { return ___FixedElementField_0; }
	inline uint8_t* get_address_of_FixedElementField_0() { return &___FixedElementField_0; }
	inline void set_FixedElementField_0(uint8_t value)
	{
		___FixedElementField_0 = value;
	}
};


// UnityEngine.SpookyHash/U
struct U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB 
{
public:
	union
	{
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Byte* UnityEngine.SpookyHash/U::p8
			uint8_t* ___p8_0;
		};
		#pragma pack(pop, tp)
		struct
		{
			uint8_t* ___p8_0_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.UInt32* UnityEngine.SpookyHash/U::p32
			uint32_t* ___p32_1;
		};
		#pragma pack(pop, tp)
		struct
		{
			uint32_t* ___p32_1_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.UInt64* UnityEngine.SpookyHash/U::p64
			uint64_t* ___p64_2;
		};
		#pragma pack(pop, tp)
		struct
		{
			uint64_t* ___p64_2_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.UInt64 UnityEngine.SpookyHash/U::i
			uint64_t ___i_3;
		};
		#pragma pack(pop, tp)
		struct
		{
			uint64_t ___i_3_forAlignmentOnly;
		};
	};

public:
	inline static int32_t get_offset_of_p8_0() { return static_cast<int32_t>(offsetof(U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB, ___p8_0)); }
	inline uint8_t* get_p8_0() const { return ___p8_0; }
	inline uint8_t** get_address_of_p8_0() { return &___p8_0; }
	inline void set_p8_0(uint8_t* value)
	{
		___p8_0 = value;
	}

	inline static int32_t get_offset_of_p32_1() { return static_cast<int32_t>(offsetof(U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB, ___p32_1)); }
	inline uint32_t* get_p32_1() const { return ___p32_1; }
	inline uint32_t** get_address_of_p32_1() { return &___p32_1; }
	inline void set_p32_1(uint32_t* value)
	{
		___p32_1 = value;
	}

	inline static int32_t get_offset_of_p64_2() { return static_cast<int32_t>(offsetof(U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB, ___p64_2)); }
	inline uint64_t* get_p64_2() const { return ___p64_2; }
	inline uint64_t** get_address_of_p64_2() { return &___p64_2; }
	inline void set_p64_2(uint64_t* value)
	{
		___p64_2 = value;
	}

	inline static int32_t get_offset_of_i_3() { return static_cast<int32_t>(offsetof(U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB, ___i_3)); }
	inline uint64_t get_i_3() const { return ___i_3; }
	inline uint64_t* get_address_of_i_3() { return &___i_3; }
	inline void set_i_3(uint64_t value)
	{
		___i_3 = value;
	}
};


// UnityEngine.PlayerLoop.TimeUpdate/WaitForLastPresentationAndUpdateTime
struct WaitForLastPresentationAndUpdateTime_tA3D3F4FF8206E94C5B3CD7F2370CED1F2E90AF88 
{
public:
	union
	{
		struct
		{
		};
		uint8_t WaitForLastPresentationAndUpdateTime_tA3D3F4FF8206E94C5B3CD7F2370CED1F2E90AF88__padding[1];
	};

public:
};


// UnityEngine.UnitySynchronizationContext/WorkRequest
struct WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 
{
public:
	// System.Threading.SendOrPostCallback UnityEngine.UnitySynchronizationContext/WorkRequest::m_DelagateCallback
	SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * ___m_DelagateCallback_0;
	// System.Object UnityEngine.UnitySynchronizationContext/WorkRequest::m_DelagateState
	RuntimeObject * ___m_DelagateState_1;
	// System.Threading.ManualResetEvent UnityEngine.UnitySynchronizationContext/WorkRequest::m_WaitHandle
	ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * ___m_WaitHandle_2;

public:
	inline static int32_t get_offset_of_m_DelagateCallback_0() { return static_cast<int32_t>(offsetof(WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393, ___m_DelagateCallback_0)); }
	inline SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * get_m_DelagateCallback_0() const { return ___m_DelagateCallback_0; }
	inline SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C ** get_address_of_m_DelagateCallback_0() { return &___m_DelagateCallback_0; }
	inline void set_m_DelagateCallback_0(SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * value)
	{
		___m_DelagateCallback_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_DelagateCallback_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_DelagateState_1() { return static_cast<int32_t>(offsetof(WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393, ___m_DelagateState_1)); }
	inline RuntimeObject * get_m_DelagateState_1() const { return ___m_DelagateState_1; }
	inline RuntimeObject ** get_address_of_m_DelagateState_1() { return &___m_DelagateState_1; }
	inline void set_m_DelagateState_1(RuntimeObject * value)
	{
		___m_DelagateState_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_DelagateState_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_WaitHandle_2() { return static_cast<int32_t>(offsetof(WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393, ___m_WaitHandle_2)); }
	inline ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * get_m_WaitHandle_2() const { return ___m_WaitHandle_2; }
	inline ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA ** get_address_of_m_WaitHandle_2() { return &___m_WaitHandle_2; }
	inline void set_m_WaitHandle_2(ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * value)
	{
		___m_WaitHandle_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_WaitHandle_2), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.UnitySynchronizationContext/WorkRequest
struct WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshaled_pinvoke
{
	Il2CppMethodPointer ___m_DelagateCallback_0;
	Il2CppIUnknown* ___m_DelagateState_1;
	ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * ___m_WaitHandle_2;
};
// Native definition for COM marshalling of UnityEngine.UnitySynchronizationContext/WorkRequest
struct WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshaled_com
{
	Il2CppMethodPointer ___m_DelagateCallback_0;
	Il2CppIUnknown* ___m_DelagateState_1;
	ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * ___m_WaitHandle_2;
};

// UnityEngine.PlayerLoop.Update/DirectorUpdate
struct DirectorUpdate_t4A7FCDCBD027B9D28BFAFF7DEB5F33E0B5E27A85 
{
public:
	union
	{
		struct
		{
		};
		uint8_t DirectorUpdate_t4A7FCDCBD027B9D28BFAFF7DEB5F33E0B5E27A85__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Update/ScriptRunBehaviourUpdate
struct ScriptRunBehaviourUpdate_tAAEB9BAF1DB9036DFA153F433C2D719A7BC30536 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ScriptRunBehaviourUpdate_tAAEB9BAF1DB9036DFA153F433C2D719A7BC30536__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Update/ScriptRunDelayedDynamicFrameRate
struct ScriptRunDelayedDynamicFrameRate_t1A2D15EEF198E3050B653FD370CBDFE82A46F66E 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ScriptRunDelayedDynamicFrameRate_t1A2D15EEF198E3050B653FD370CBDFE82A46F66E__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Update/ScriptRunDelayedTasks
struct ScriptRunDelayedTasks_t87535B3420E907071EA14E80AD9D811F29AA978A 
{
public:
	union
	{
		struct
		{
		};
		uint8_t ScriptRunDelayedTasks_t87535B3420E907071EA14E80AD9D811F29AA978A__padding[1];
	};

public:
};


// UnityEngine.PlayerLoop.Update/UIWidgetsUpdate
struct UIWidgetsUpdate_tFFC010CB5AA31564175901ED00434740523DDACE 
{
public:
	union
	{
		struct
		{
		};
		uint8_t UIWidgetsUpdate_tFFC010CB5AA31564175901ED00434740523DDACE__padding[1];
	};

public:
};


// Unity.Collections.Allocator
struct Allocator_t9888223DEF4F46F3419ECFCCD0753599BEE52A05 
{
public:
	// System.Int32 Unity.Collections.Allocator::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Allocator_t9888223DEF4F46F3419ECFCCD0753599BEE52A05, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Experimental.GlobalIllumination.AngularFalloffType
struct AngularFalloffType_tE33F65C52CF289A72D8EA70883440F4D993621E2 
{
public:
	// System.Byte UnityEngine.Experimental.GlobalIllumination.AngularFalloffType::value__
	uint8_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AngularFalloffType_tE33F65C52CF289A72D8EA70883440F4D993621E2, ___value___2)); }
	inline uint8_t get_value___2() const { return ___value___2; }
	inline uint8_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint8_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Rendering.BatchRendererGroup
struct BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Rendering.BatchRendererGroup::m_GroupHandle
	intptr_t ___m_GroupHandle_0;
	// UnityEngine.Rendering.BatchRendererGroup/OnPerformCulling UnityEngine.Rendering.BatchRendererGroup::m_PerformCulling
	OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB * ___m_PerformCulling_1;

public:
	inline static int32_t get_offset_of_m_GroupHandle_0() { return static_cast<int32_t>(offsetof(BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A, ___m_GroupHandle_0)); }
	inline intptr_t get_m_GroupHandle_0() const { return ___m_GroupHandle_0; }
	inline intptr_t* get_address_of_m_GroupHandle_0() { return &___m_GroupHandle_0; }
	inline void set_m_GroupHandle_0(intptr_t value)
	{
		___m_GroupHandle_0 = value;
	}

	inline static int32_t get_offset_of_m_PerformCulling_1() { return static_cast<int32_t>(offsetof(BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A, ___m_PerformCulling_1)); }
	inline OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB * get_m_PerformCulling_1() const { return ___m_PerformCulling_1; }
	inline OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB ** get_address_of_m_PerformCulling_1() { return &___m_PerformCulling_1; }
	inline void set_m_PerformCulling_1(OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB * value)
	{
		___m_PerformCulling_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_PerformCulling_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Rendering.BatchRendererGroup
struct BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A_marshaled_pinvoke
{
	intptr_t ___m_GroupHandle_0;
	Il2CppMethodPointer ___m_PerformCulling_1;
};
// Native definition for COM marshalling of UnityEngine.Rendering.BatchRendererGroup
struct BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A_marshaled_com
{
	intptr_t ___m_GroupHandle_0;
	Il2CppMethodPointer ___m_PerformCulling_1;
};

// UnityEngine.Bounds
struct Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 
{
public:
	// UnityEngine.Vector3 UnityEngine.Bounds::m_Center
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___m_Center_0;
	// UnityEngine.Vector3 UnityEngine.Bounds::m_Extents
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___m_Extents_1;

public:
	inline static int32_t get_offset_of_m_Center_0() { return static_cast<int32_t>(offsetof(Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37, ___m_Center_0)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_m_Center_0() const { return ___m_Center_0; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_m_Center_0() { return &___m_Center_0; }
	inline void set_m_Center_0(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___m_Center_0 = value;
	}

	inline static int32_t get_offset_of_m_Extents_1() { return static_cast<int32_t>(offsetof(Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37, ___m_Extents_1)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_m_Extents_1() const { return ___m_Extents_1; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_m_Extents_1() { return &___m_Extents_1; }
	inline void set_m_Extents_1(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___m_Extents_1 = value;
	}
};


// UnityEngine.Experimental.GlobalIllumination.Cookie
struct Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B 
{
public:
	// System.Int32 UnityEngine.Experimental.GlobalIllumination.Cookie::instanceID
	int32_t ___instanceID_0;
	// System.Single UnityEngine.Experimental.GlobalIllumination.Cookie::scale
	float ___scale_1;
	// UnityEngine.Vector2 UnityEngine.Experimental.GlobalIllumination.Cookie::sizes
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___sizes_2;

public:
	inline static int32_t get_offset_of_instanceID_0() { return static_cast<int32_t>(offsetof(Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B, ___instanceID_0)); }
	inline int32_t get_instanceID_0() const { return ___instanceID_0; }
	inline int32_t* get_address_of_instanceID_0() { return &___instanceID_0; }
	inline void set_instanceID_0(int32_t value)
	{
		___instanceID_0 = value;
	}

	inline static int32_t get_offset_of_scale_1() { return static_cast<int32_t>(offsetof(Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B, ___scale_1)); }
	inline float get_scale_1() const { return ___scale_1; }
	inline float* get_address_of_scale_1() { return &___scale_1; }
	inline void set_scale_1(float value)
	{
		___scale_1 = value;
	}

	inline static int32_t get_offset_of_sizes_2() { return static_cast<int32_t>(offsetof(Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B, ___sizes_2)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_sizes_2() const { return ___sizes_2; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_sizes_2() { return &___sizes_2; }
	inline void set_sizes_2(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___sizes_2 = value;
	}
};


// System.Delegate
struct Delegate_t  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_7;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_8;
	// System.DelegateData System.Delegate::data
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_10;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_target_2), (void*)value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_extra_arg_5() { return static_cast<int32_t>(offsetof(Delegate_t, ___extra_arg_5)); }
	inline intptr_t get_extra_arg_5() const { return ___extra_arg_5; }
	inline intptr_t* get_address_of_extra_arg_5() { return &___extra_arg_5; }
	inline void set_extra_arg_5(intptr_t value)
	{
		___extra_arg_5 = value;
	}

	inline static int32_t get_offset_of_method_code_6() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_code_6)); }
	inline intptr_t get_method_code_6() const { return ___method_code_6; }
	inline intptr_t* get_address_of_method_code_6() { return &___method_code_6; }
	inline void set_method_code_6(intptr_t value)
	{
		___method_code_6 = value;
	}

	inline static int32_t get_offset_of_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_info_7)); }
	inline MethodInfo_t * get_method_info_7() const { return ___method_info_7; }
	inline MethodInfo_t ** get_address_of_method_info_7() { return &___method_info_7; }
	inline void set_method_info_7(MethodInfo_t * value)
	{
		___method_info_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_info_7), (void*)value);
	}

	inline static int32_t get_offset_of_original_method_info_8() { return static_cast<int32_t>(offsetof(Delegate_t, ___original_method_info_8)); }
	inline MethodInfo_t * get_original_method_info_8() const { return ___original_method_info_8; }
	inline MethodInfo_t ** get_address_of_original_method_info_8() { return &___original_method_info_8; }
	inline void set_original_method_info_8(MethodInfo_t * value)
	{
		___original_method_info_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___original_method_info_8), (void*)value);
	}

	inline static int32_t get_offset_of_data_9() { return static_cast<int32_t>(offsetof(Delegate_t, ___data_9)); }
	inline DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * get_data_9() const { return ___data_9; }
	inline DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 ** get_address_of_data_9() { return &___data_9; }
	inline void set_data_9(DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * value)
	{
		___data_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_9), (void*)value);
	}

	inline static int32_t get_offset_of_method_is_virtual_10() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_is_virtual_10)); }
	inline bool get_method_is_virtual_10() const { return ___method_is_virtual_10; }
	inline bool* get_address_of_method_is_virtual_10() { return &___method_is_virtual_10; }
	inline void set_method_is_virtual_10(bool value)
	{
		___method_is_virtual_10 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	int32_t ___method_is_virtual_10;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288 * ___data_9;
	int32_t ___method_is_virtual_10;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
public:
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t * ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject * ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject * ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* ___native_trace_ips_15;

public:
	inline static int32_t get_offset_of__className_1() { return static_cast<int32_t>(offsetof(Exception_t, ____className_1)); }
	inline String_t* get__className_1() const { return ____className_1; }
	inline String_t** get_address_of__className_1() { return &____className_1; }
	inline void set__className_1(String_t* value)
	{
		____className_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____className_1), (void*)value);
	}

	inline static int32_t get_offset_of__message_2() { return static_cast<int32_t>(offsetof(Exception_t, ____message_2)); }
	inline String_t* get__message_2() const { return ____message_2; }
	inline String_t** get_address_of__message_2() { return &____message_2; }
	inline void set__message_2(String_t* value)
	{
		____message_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____message_2), (void*)value);
	}

	inline static int32_t get_offset_of__data_3() { return static_cast<int32_t>(offsetof(Exception_t, ____data_3)); }
	inline RuntimeObject* get__data_3() const { return ____data_3; }
	inline RuntimeObject** get_address_of__data_3() { return &____data_3; }
	inline void set__data_3(RuntimeObject* value)
	{
		____data_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____data_3), (void*)value);
	}

	inline static int32_t get_offset_of__innerException_4() { return static_cast<int32_t>(offsetof(Exception_t, ____innerException_4)); }
	inline Exception_t * get__innerException_4() const { return ____innerException_4; }
	inline Exception_t ** get_address_of__innerException_4() { return &____innerException_4; }
	inline void set__innerException_4(Exception_t * value)
	{
		____innerException_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____innerException_4), (void*)value);
	}

	inline static int32_t get_offset_of__helpURL_5() { return static_cast<int32_t>(offsetof(Exception_t, ____helpURL_5)); }
	inline String_t* get__helpURL_5() const { return ____helpURL_5; }
	inline String_t** get_address_of__helpURL_5() { return &____helpURL_5; }
	inline void set__helpURL_5(String_t* value)
	{
		____helpURL_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____helpURL_5), (void*)value);
	}

	inline static int32_t get_offset_of__stackTrace_6() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTrace_6)); }
	inline RuntimeObject * get__stackTrace_6() const { return ____stackTrace_6; }
	inline RuntimeObject ** get_address_of__stackTrace_6() { return &____stackTrace_6; }
	inline void set__stackTrace_6(RuntimeObject * value)
	{
		____stackTrace_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTrace_6), (void*)value);
	}

	inline static int32_t get_offset_of__stackTraceString_7() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTraceString_7)); }
	inline String_t* get__stackTraceString_7() const { return ____stackTraceString_7; }
	inline String_t** get_address_of__stackTraceString_7() { return &____stackTraceString_7; }
	inline void set__stackTraceString_7(String_t* value)
	{
		____stackTraceString_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTraceString_7), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackTraceString_8() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackTraceString_8)); }
	inline String_t* get__remoteStackTraceString_8() const { return ____remoteStackTraceString_8; }
	inline String_t** get_address_of__remoteStackTraceString_8() { return &____remoteStackTraceString_8; }
	inline void set__remoteStackTraceString_8(String_t* value)
	{
		____remoteStackTraceString_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____remoteStackTraceString_8), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackIndex_9() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackIndex_9)); }
	inline int32_t get__remoteStackIndex_9() const { return ____remoteStackIndex_9; }
	inline int32_t* get_address_of__remoteStackIndex_9() { return &____remoteStackIndex_9; }
	inline void set__remoteStackIndex_9(int32_t value)
	{
		____remoteStackIndex_9 = value;
	}

	inline static int32_t get_offset_of__dynamicMethods_10() { return static_cast<int32_t>(offsetof(Exception_t, ____dynamicMethods_10)); }
	inline RuntimeObject * get__dynamicMethods_10() const { return ____dynamicMethods_10; }
	inline RuntimeObject ** get_address_of__dynamicMethods_10() { return &____dynamicMethods_10; }
	inline void set__dynamicMethods_10(RuntimeObject * value)
	{
		____dynamicMethods_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dynamicMethods_10), (void*)value);
	}

	inline static int32_t get_offset_of__HResult_11() { return static_cast<int32_t>(offsetof(Exception_t, ____HResult_11)); }
	inline int32_t get__HResult_11() const { return ____HResult_11; }
	inline int32_t* get_address_of__HResult_11() { return &____HResult_11; }
	inline void set__HResult_11(int32_t value)
	{
		____HResult_11 = value;
	}

	inline static int32_t get_offset_of__source_12() { return static_cast<int32_t>(offsetof(Exception_t, ____source_12)); }
	inline String_t* get__source_12() const { return ____source_12; }
	inline String_t** get_address_of__source_12() { return &____source_12; }
	inline void set__source_12(String_t* value)
	{
		____source_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____source_12), (void*)value);
	}

	inline static int32_t get_offset_of__safeSerializationManager_13() { return static_cast<int32_t>(offsetof(Exception_t, ____safeSerializationManager_13)); }
	inline SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * get__safeSerializationManager_13() const { return ____safeSerializationManager_13; }
	inline SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F ** get_address_of__safeSerializationManager_13() { return &____safeSerializationManager_13; }
	inline void set__safeSerializationManager_13(SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * value)
	{
		____safeSerializationManager_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____safeSerializationManager_13), (void*)value);
	}

	inline static int32_t get_offset_of_captured_traces_14() { return static_cast<int32_t>(offsetof(Exception_t, ___captured_traces_14)); }
	inline StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* get_captured_traces_14() const { return ___captured_traces_14; }
	inline StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971** get_address_of_captured_traces_14() { return &___captured_traces_14; }
	inline void set_captured_traces_14(StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* value)
	{
		___captured_traces_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___captured_traces_14), (void*)value);
	}

	inline static int32_t get_offset_of_native_trace_ips_15() { return static_cast<int32_t>(offsetof(Exception_t, ___native_trace_ips_15)); }
	inline IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* get_native_trace_ips_15() const { return ___native_trace_ips_15; }
	inline IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6** get_address_of_native_trace_ips_15() { return &___native_trace_ips_15; }
	inline void set_native_trace_ips_15(IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* value)
	{
		___native_trace_ips_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___native_trace_ips_15), (void*)value);
	}
};

struct Exception_t_StaticFields
{
public:
	// System.Object System.Exception::s_EDILock
	RuntimeObject * ___s_EDILock_0;

public:
	inline static int32_t get_offset_of_s_EDILock_0() { return static_cast<int32_t>(offsetof(Exception_t_StaticFields, ___s_EDILock_0)); }
	inline RuntimeObject * get_s_EDILock_0() const { return ___s_EDILock_0; }
	inline RuntimeObject ** get_address_of_s_EDILock_0() { return &___s_EDILock_0; }
	inline void set_s_EDILock_0(RuntimeObject * value)
	{
		___s_EDILock_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_EDILock_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};

// UnityEngine.Experimental.GlobalIllumination.FalloffType
struct FalloffType_t983DA2C11C909629E51BD1D4CF088C689C9863CB 
{
public:
	// System.Byte UnityEngine.Experimental.GlobalIllumination.FalloffType::value__
	uint8_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FalloffType_t983DA2C11C909629E51BD1D4CF088C689C9863CB, ___value___2)); }
	inline uint8_t get_value___2() const { return ___value___2; }
	inline uint8_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint8_t value)
	{
		___value___2 = value;
	}
};


// Unity.Jobs.JobHandle
struct JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 
{
public:
	// System.IntPtr Unity.Jobs.JobHandle::jobGroup
	intptr_t ___jobGroup_0;
	// System.Int32 Unity.Jobs.JobHandle::version
	int32_t ___version_1;

public:
	inline static int32_t get_offset_of_jobGroup_0() { return static_cast<int32_t>(offsetof(JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847, ___jobGroup_0)); }
	inline intptr_t get_jobGroup_0() const { return ___jobGroup_0; }
	inline intptr_t* get_address_of_jobGroup_0() { return &___jobGroup_0; }
	inline void set_jobGroup_0(intptr_t value)
	{
		___jobGroup_0 = value;
	}

	inline static int32_t get_offset_of_version_1() { return static_cast<int32_t>(offsetof(JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847, ___version_1)); }
	inline int32_t get_version_1() const { return ___version_1; }
	inline int32_t* get_address_of_version_1() { return &___version_1; }
	inline void set_version_1(int32_t value)
	{
		___version_1 = value;
	}
};


// UnityEngine.Rendering.LODParameters
struct LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD 
{
public:
	// System.Int32 UnityEngine.Rendering.LODParameters::m_IsOrthographic
	int32_t ___m_IsOrthographic_0;
	// UnityEngine.Vector3 UnityEngine.Rendering.LODParameters::m_CameraPosition
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___m_CameraPosition_1;
	// System.Single UnityEngine.Rendering.LODParameters::m_FieldOfView
	float ___m_FieldOfView_2;
	// System.Single UnityEngine.Rendering.LODParameters::m_OrthoSize
	float ___m_OrthoSize_3;
	// System.Int32 UnityEngine.Rendering.LODParameters::m_CameraPixelHeight
	int32_t ___m_CameraPixelHeight_4;

public:
	inline static int32_t get_offset_of_m_IsOrthographic_0() { return static_cast<int32_t>(offsetof(LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD, ___m_IsOrthographic_0)); }
	inline int32_t get_m_IsOrthographic_0() const { return ___m_IsOrthographic_0; }
	inline int32_t* get_address_of_m_IsOrthographic_0() { return &___m_IsOrthographic_0; }
	inline void set_m_IsOrthographic_0(int32_t value)
	{
		___m_IsOrthographic_0 = value;
	}

	inline static int32_t get_offset_of_m_CameraPosition_1() { return static_cast<int32_t>(offsetof(LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD, ___m_CameraPosition_1)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_m_CameraPosition_1() const { return ___m_CameraPosition_1; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_m_CameraPosition_1() { return &___m_CameraPosition_1; }
	inline void set_m_CameraPosition_1(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___m_CameraPosition_1 = value;
	}

	inline static int32_t get_offset_of_m_FieldOfView_2() { return static_cast<int32_t>(offsetof(LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD, ___m_FieldOfView_2)); }
	inline float get_m_FieldOfView_2() const { return ___m_FieldOfView_2; }
	inline float* get_address_of_m_FieldOfView_2() { return &___m_FieldOfView_2; }
	inline void set_m_FieldOfView_2(float value)
	{
		___m_FieldOfView_2 = value;
	}

	inline static int32_t get_offset_of_m_OrthoSize_3() { return static_cast<int32_t>(offsetof(LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD, ___m_OrthoSize_3)); }
	inline float get_m_OrthoSize_3() const { return ___m_OrthoSize_3; }
	inline float* get_address_of_m_OrthoSize_3() { return &___m_OrthoSize_3; }
	inline void set_m_OrthoSize_3(float value)
	{
		___m_OrthoSize_3 = value;
	}

	inline static int32_t get_offset_of_m_CameraPixelHeight_4() { return static_cast<int32_t>(offsetof(LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD, ___m_CameraPixelHeight_4)); }
	inline int32_t get_m_CameraPixelHeight_4() const { return ___m_CameraPixelHeight_4; }
	inline int32_t* get_address_of_m_CameraPixelHeight_4() { return &___m_CameraPixelHeight_4; }
	inline void set_m_CameraPixelHeight_4(int32_t value)
	{
		___m_CameraPixelHeight_4 = value;
	}
};


// UnityEngine.Experimental.GlobalIllumination.LightMode
struct LightMode_t9D89979F39C1DBB9CD1E275BDD77C7EA1B506491 
{
public:
	// System.Byte UnityEngine.Experimental.GlobalIllumination.LightMode::value__
	uint8_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LightMode_t9D89979F39C1DBB9CD1E275BDD77C7EA1B506491, ___value___2)); }
	inline uint8_t get_value___2() const { return ___value___2; }
	inline uint8_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint8_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.LightType
struct LightType_tAD5FBE55DEE7A9C38A42323701B0BDD716761B14 
{
public:
	// System.Int32 UnityEngine.LightType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LightType_tAD5FBE55DEE7A9C38A42323701B0BDD716761B14, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Experimental.GlobalIllumination.LightType
struct LightType_t4205DE4BEF130CE507C87172DAB60E5B1EB05552 
{
public:
	// System.Byte UnityEngine.Experimental.GlobalIllumination.LightType::value__
	uint8_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LightType_t4205DE4BEF130CE507C87172DAB60E5B1EB05552, ___value___2)); }
	inline uint8_t get_value___2() const { return ___value___2; }
	inline uint8_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint8_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.LogType
struct LogType_tF490DBF8368BD4EBA703B2824CB76A853820F773 
{
public:
	// System.Int32 UnityEngine.LogType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LogType_tF490DBF8368BD4EBA703B2824CB76A853820F773, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Rendering.MeshUpdateFlags
struct MeshUpdateFlags_t6CC8A3E19F8A286528978810AB6FFAEEB6A125B5 
{
public:
	// System.Int32 UnityEngine.Rendering.MeshUpdateFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MeshUpdateFlags_t6CC8A3E19F8A286528978810AB6FFAEEB6A125B5, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Globalization.NumberStyles
struct NumberStyles_t379EFBF2535E1C950DEC8042704BB663BF636594 
{
public:
	// System.Int32 System.Globalization.NumberStyles::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(NumberStyles_t379EFBF2535E1C950DEC8042704BB663BF636594, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Playables.PlayableGraph
struct PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A 
{
public:
	// System.IntPtr UnityEngine.Playables.PlayableGraph::m_Handle
	intptr_t ___m_Handle_0;
	// System.UInt32 UnityEngine.Playables.PlayableGraph::m_Version
	uint32_t ___m_Version_1;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A, ___m_Handle_0)); }
	inline intptr_t get_m_Handle_0() const { return ___m_Handle_0; }
	inline intptr_t* get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(intptr_t value)
	{
		___m_Handle_0 = value;
	}

	inline static int32_t get_offset_of_m_Version_1() { return static_cast<int32_t>(offsetof(PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A, ___m_Version_1)); }
	inline uint32_t get_m_Version_1() const { return ___m_Version_1; }
	inline uint32_t* get_address_of_m_Version_1() { return &___m_Version_1; }
	inline void set_m_Version_1(uint32_t value)
	{
		___m_Version_1 = value;
	}
};


// UnityEngine.Playables.PlayableOutputHandle
struct PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1 
{
public:
	// System.IntPtr UnityEngine.Playables.PlayableOutputHandle::m_Handle
	intptr_t ___m_Handle_0;
	// System.UInt32 UnityEngine.Playables.PlayableOutputHandle::m_Version
	uint32_t ___m_Version_1;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1, ___m_Handle_0)); }
	inline intptr_t get_m_Handle_0() const { return ___m_Handle_0; }
	inline intptr_t* get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(intptr_t value)
	{
		___m_Handle_0 = value;
	}

	inline static int32_t get_offset_of_m_Version_1() { return static_cast<int32_t>(offsetof(PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1, ___m_Version_1)); }
	inline uint32_t get_m_Version_1() const { return ___m_Version_1; }
	inline uint32_t* get_address_of_m_Version_1() { return &___m_Version_1; }
	inline void set_m_Version_1(uint32_t value)
	{
		___m_Version_1 = value;
	}
};

struct PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1_StaticFields
{
public:
	// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Playables.PlayableOutputHandle::m_Null
	PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  ___m_Null_2;

public:
	inline static int32_t get_offset_of_m_Null_2() { return static_cast<int32_t>(offsetof(PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1_StaticFields, ___m_Null_2)); }
	inline PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  get_m_Null_2() const { return ___m_Null_2; }
	inline PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1 * get_address_of_m_Null_2() { return &___m_Null_2; }
	inline void set_m_Null_2(PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  value)
	{
		___m_Null_2 = value;
	}
};


// Unity.Jobs.LowLevel.Unsafe.ScheduleMode
struct ScheduleMode_t25A6FBD7FAB995823340CBF0FDA24A3EB7D51B42 
{
public:
	// System.Int32 Unity.Jobs.LowLevel.Unsafe.ScheduleMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ScheduleMode_t25A6FBD7FAB995823340CBF0FDA24A3EB7D51B42, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Rendering.VertexAttribute
struct VertexAttribute_t9B763063E3B1705070D4DB8BC32F21F0FB30867C 
{
public:
	// System.Int32 UnityEngine.Rendering.VertexAttribute::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(VertexAttribute_t9B763063E3B1705070D4DB8BC32F21F0FB30867C, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Rendering.VertexAttributeFormat
struct VertexAttributeFormat_tE5FC93A96237AAF63142B0E521925CAE4F283485 
{
public:
	// System.Int32 UnityEngine.Rendering.VertexAttributeFormat::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(VertexAttributeFormat_tE5FC93A96237AAF63142B0E521925CAE4F283485, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Rendering.VisibleLightFlags
struct VisibleLightFlags_tDB755E7201CE7B38D58CC4524920ACDABC292EC0 
{
public:
	// System.Int32 UnityEngine.Rendering.VisibleLightFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(VisibleLightFlags_tDB755E7201CE7B38D58CC4524920ACDABC292EC0, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Threading.WaitHandle
struct WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842  : public MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8
{
public:
	// System.IntPtr System.Threading.WaitHandle::waitHandle
	intptr_t ___waitHandle_3;
	// Microsoft.Win32.SafeHandles.SafeWaitHandle modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.WaitHandle::safeWaitHandle
	SafeWaitHandle_tF37EACEDF9C6F350EB4ABC1E1F869EECB0B5ABB1 * ___safeWaitHandle_4;
	// System.Boolean System.Threading.WaitHandle::hasThreadAffinity
	bool ___hasThreadAffinity_5;

public:
	inline static int32_t get_offset_of_waitHandle_3() { return static_cast<int32_t>(offsetof(WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842, ___waitHandle_3)); }
	inline intptr_t get_waitHandle_3() const { return ___waitHandle_3; }
	inline intptr_t* get_address_of_waitHandle_3() { return &___waitHandle_3; }
	inline void set_waitHandle_3(intptr_t value)
	{
		___waitHandle_3 = value;
	}

	inline static int32_t get_offset_of_safeWaitHandle_4() { return static_cast<int32_t>(offsetof(WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842, ___safeWaitHandle_4)); }
	inline SafeWaitHandle_tF37EACEDF9C6F350EB4ABC1E1F869EECB0B5ABB1 * get_safeWaitHandle_4() const { return ___safeWaitHandle_4; }
	inline SafeWaitHandle_tF37EACEDF9C6F350EB4ABC1E1F869EECB0B5ABB1 ** get_address_of_safeWaitHandle_4() { return &___safeWaitHandle_4; }
	inline void set_safeWaitHandle_4(SafeWaitHandle_tF37EACEDF9C6F350EB4ABC1E1F869EECB0B5ABB1 * value)
	{
		___safeWaitHandle_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___safeWaitHandle_4), (void*)value);
	}

	inline static int32_t get_offset_of_hasThreadAffinity_5() { return static_cast<int32_t>(offsetof(WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842, ___hasThreadAffinity_5)); }
	inline bool get_hasThreadAffinity_5() const { return ___hasThreadAffinity_5; }
	inline bool* get_address_of_hasThreadAffinity_5() { return &___hasThreadAffinity_5; }
	inline void set_hasThreadAffinity_5(bool value)
	{
		___hasThreadAffinity_5 = value;
	}
};

struct WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842_StaticFields
{
public:
	// System.IntPtr System.Threading.WaitHandle::InvalidHandle
	intptr_t ___InvalidHandle_10;

public:
	inline static int32_t get_offset_of_InvalidHandle_10() { return static_cast<int32_t>(offsetof(WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842_StaticFields, ___InvalidHandle_10)); }
	inline intptr_t get_InvalidHandle_10() const { return ___InvalidHandle_10; }
	inline intptr_t* get_address_of_InvalidHandle_10() { return &___InvalidHandle_10; }
	inline void set_InvalidHandle_10(intptr_t value)
	{
		___InvalidHandle_10 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Threading.WaitHandle
struct WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842_marshaled_pinvoke : public MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8_marshaled_pinvoke
{
	intptr_t ___waitHandle_3;
	void* ___safeWaitHandle_4;
	int32_t ___hasThreadAffinity_5;
};
// Native definition for COM marshalling of System.Threading.WaitHandle
struct WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842_marshaled_com : public MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8_marshaled_com
{
	intptr_t ___waitHandle_3;
	void* ___safeWaitHandle_4;
	int32_t ___hasThreadAffinity_5;
};

// UnityEngine.WrapMode
struct WrapMode_t0DF566E32B136795606714DB9A11A3DC170F5468 
{
public:
	// System.Int32 UnityEngine.WrapMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(WrapMode_t0DF566E32B136795606714DB9A11A3DC170F5468, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Camera/GateFitMode
struct GateFitMode_tDBD4389C530FAD67ED78789C02808A1D2DB4A525 
{
public:
	// System.Int32 UnityEngine.Camera/GateFitMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(GateFitMode_tDBD4389C530FAD67ED78789C02808A1D2DB4A525, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Camera/MonoOrStereoscopicEye
struct MonoOrStereoscopicEye_t22538A0C5043C3A233E0332787D3E06DA966703E 
{
public:
	// System.Int32 UnityEngine.Camera/MonoOrStereoscopicEye::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MonoOrStereoscopicEye_t22538A0C5043C3A233E0332787D3E06DA966703E, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Camera/ProjectionMatrixMode
struct ProjectionMatrixMode_t4F6841DE6D2CFEB3C53276D28B69D6D18B814DBC 
{
public:
	// System.Int32 UnityEngine.Camera/ProjectionMatrixMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ProjectionMatrixMode_t4F6841DE6D2CFEB3C53276D28B69D6D18B814DBC, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Camera/RenderRequestMode
struct RenderRequestMode_tCB120B82DED523ADBA2D6093A1A8ABF17D94A313 
{
public:
	// System.Int32 UnityEngine.Camera/RenderRequestMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(RenderRequestMode_tCB120B82DED523ADBA2D6093A1A8ABF17D94A313, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Camera/RenderRequestOutputSpace
struct RenderRequestOutputSpace_t8EB93E4720B2D1BAB624A04ADB473C37C7F3D6A5 
{
public:
	// System.Int32 UnityEngine.Camera/RenderRequestOutputSpace::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(RenderRequestOutputSpace_t8EB93E4720B2D1BAB624A04ADB473C37C7F3D6A5, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Camera/StereoscopicEye
struct StereoscopicEye_t0193B972018E94F768D3B2E44CCE0E88EE2FFFD3 
{
public:
	// System.Int32 UnityEngine.Camera/StereoscopicEye::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(StereoscopicEye_t0193B972018E94F768D3B2E44CCE0E88EE2FFFD3, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Playables.FrameData/Flags
struct Flags_t64F4A80C88F9E613B720DA0195BAB2B34C5307D5 
{
public:
	// System.Int32 UnityEngine.Playables.FrameData/Flags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Flags_t64F4A80C88F9E613B720DA0195BAB2B34C5307D5, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Mesh/MeshData
struct MeshData_tBFF99C0C82DBC04BDB83209CDE690A0B4303D6D1 
{
public:
	// System.IntPtr UnityEngine.Mesh/MeshData::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(MeshData_tBFF99C0C82DBC04BDB83209CDE690A0B4303D6D1, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};


// UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass12_0
struct U3CU3Ec__DisplayClass12_0_tC029C4F11E384EFEF6FD86B7BEC83D295D098769  : public RuntimeObject
{
public:
	// System.Guid UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass12_0::messageId
	Guid_t  ___messageId_0;

public:
	inline static int32_t get_offset_of_messageId_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass12_0_tC029C4F11E384EFEF6FD86B7BEC83D295D098769, ___messageId_0)); }
	inline Guid_t  get_messageId_0() const { return ___messageId_0; }
	inline Guid_t * get_address_of_messageId_0() { return &___messageId_0; }
	inline void set_messageId_0(Guid_t  value)
	{
		___messageId_0 = value;
	}
};


// UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass13_0
struct U3CU3Ec__DisplayClass13_0_t1A8EBE4E3370D09549DE4FD59077B3A7AEAD0C54  : public RuntimeObject
{
public:
	// System.Guid UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass13_0::messageId
	Guid_t  ___messageId_0;

public:
	inline static int32_t get_offset_of_messageId_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass13_0_t1A8EBE4E3370D09549DE4FD59077B3A7AEAD0C54, ___messageId_0)); }
	inline Guid_t  get_messageId_0() const { return ___messageId_0; }
	inline Guid_t * get_address_of_messageId_0() { return &___messageId_0; }
	inline void set_messageId_0(Guid_t  value)
	{
		___messageId_0 = value;
	}
};


// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass6_0
struct U3CU3Ec__DisplayClass6_0_t96633FB6A2AE351A4A3FCDF89D10891DA07AD54F  : public RuntimeObject
{
public:
	// System.Guid UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass6_0::messageId
	Guid_t  ___messageId_0;

public:
	inline static int32_t get_offset_of_messageId_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass6_0_t96633FB6A2AE351A4A3FCDF89D10891DA07AD54F, ___messageId_0)); }
	inline Guid_t  get_messageId_0() const { return ___messageId_0; }
	inline Guid_t * get_address_of_messageId_0() { return &___messageId_0; }
	inline void set_messageId_0(Guid_t  value)
	{
		___messageId_0 = value;
	}
};


// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass7_0
struct U3CU3Ec__DisplayClass7_0_t7C625D285CBB757F88C0232D12D88EDABF06EB60  : public RuntimeObject
{
public:
	// System.Guid UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass7_0::messageId
	Guid_t  ___messageId_0;

public:
	inline static int32_t get_offset_of_messageId_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass7_0_t7C625D285CBB757F88C0232D12D88EDABF06EB60, ___messageId_0)); }
	inline Guid_t  get_messageId_0() const { return ___messageId_0; }
	inline Guid_t * get_address_of_messageId_0() { return &___messageId_0; }
	inline void set_messageId_0(Guid_t  value)
	{
		___messageId_0 = value;
	}
};


// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass8_0
struct U3CU3Ec__DisplayClass8_0_tE64E7CAC5415DCD425D14A6062600087CC872B93  : public RuntimeObject
{
public:
	// System.Guid UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass8_0::messageId
	Guid_t  ___messageId_0;

public:
	inline static int32_t get_offset_of_messageId_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass8_0_tE64E7CAC5415DCD425D14A6062600087CC872B93, ___messageId_0)); }
	inline Guid_t  get_messageId_0() const { return ___messageId_0; }
	inline Guid_t * get_address_of_messageId_0() { return &___messageId_0; }
	inline void set_messageId_0(Guid_t  value)
	{
		___messageId_0 = value;
	}
};


// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/ConnectionChangeEvent
struct ConnectionChangeEvent_tCA1C8C14171C72EC394EF45450D69C1585067BDF  : public UnityEvent_1_tB235B5DAD099AC425DC059D10DEB8B97A35E2BBF
{
public:

public:
};


// UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageEvent
struct MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B  : public UnityEvent_1_t5380899C55F3CD7FD1CD64F13EE5E1E4B11D602B
{
public:

public:
};


// UnityEngine.RectTransform/Axis
struct Axis_t8881AF0DB9EDF3F36FE049AA194D0206695EBF83 
{
public:
	// System.Int32 UnityEngine.RectTransform/Axis::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Axis_t8881AF0DB9EDF3F36FE049AA194D0206695EBF83, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.RectTransform/Edge
struct Edge_tC1CFEDE8D0D04FFA0E8F261E6DFEB1F22831F364 
{
public:
	// System.Int32 UnityEngine.RectTransform/Edge::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Edge_tC1CFEDE8D0D04FFA0E8F261E6DFEB1F22831F364, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.ReflectionProbe/ReflectionProbeEvent
struct ReflectionProbeEvent_tA90347B5A1B5256D229969ADF158978AF137003A 
{
public:
	// System.Int32 UnityEngine.ReflectionProbe/ReflectionProbeEvent::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ReflectionProbeEvent_tA90347B5A1B5256D229969ADF158978AF137003A, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Rendering.SupportedRenderingFeatures/LightmapMixedBakeModes
struct LightmapMixedBakeModes_t517152ED1576E98EFCB29D358676919D88844F75 
{
public:
	// System.Int32 UnityEngine.Rendering.SupportedRenderingFeatures/LightmapMixedBakeModes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LightmapMixedBakeModes_t517152ED1576E98EFCB29D358676919D88844F75, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Rendering.SupportedRenderingFeatures/ReflectionProbeModes
struct ReflectionProbeModes_tBE15DD8892571EBC569B7FCD5D918B0588F8EA4A 
{
public:
	// System.Int32 UnityEngine.Rendering.SupportedRenderingFeatures/ReflectionProbeModes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ReflectionProbeModes_tBE15DD8892571EBC569B7FCD5D918B0588F8EA4A, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.TextAsset/CreateOptions
struct CreateOptions_t5CEBFE620BF81FE1A8B9C950C434E5C29FDDD494 
{
public:
	// System.Int32 UnityEngine.TextAsset/CreateOptions::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(CreateOptions_t5CEBFE620BF81FE1A8B9C950C434E5C29FDDD494, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.TouchScreenKeyboard/Status
struct Status_tCF9D837EDAD10412CECD4A306BCD7CA936720FEF 
{
public:
	// System.Int32 UnityEngine.TouchScreenKeyboard/Status::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Status_tCF9D837EDAD10412CECD4A306BCD7CA936720FEF, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// Unity.Collections.NativeArray`1<UnityEngine.Rendering.BatchVisibility>
struct NativeArray_1_t18D233A2E30E28048C1252473AFD0799557294DA 
{
public:
	// System.Void* Unity.Collections.NativeArray`1::m_Buffer
	void* ___m_Buffer_0;
	// System.Int32 Unity.Collections.NativeArray`1::m_Length
	int32_t ___m_Length_1;
	// Unity.Collections.Allocator Unity.Collections.NativeArray`1::m_AllocatorLabel
	int32_t ___m_AllocatorLabel_2;

public:
	inline static int32_t get_offset_of_m_Buffer_0() { return static_cast<int32_t>(offsetof(NativeArray_1_t18D233A2E30E28048C1252473AFD0799557294DA, ___m_Buffer_0)); }
	inline void* get_m_Buffer_0() const { return ___m_Buffer_0; }
	inline void** get_address_of_m_Buffer_0() { return &___m_Buffer_0; }
	inline void set_m_Buffer_0(void* value)
	{
		___m_Buffer_0 = value;
	}

	inline static int32_t get_offset_of_m_Length_1() { return static_cast<int32_t>(offsetof(NativeArray_1_t18D233A2E30E28048C1252473AFD0799557294DA, ___m_Length_1)); }
	inline int32_t get_m_Length_1() const { return ___m_Length_1; }
	inline int32_t* get_address_of_m_Length_1() { return &___m_Length_1; }
	inline void set_m_Length_1(int32_t value)
	{
		___m_Length_1 = value;
	}

	inline static int32_t get_offset_of_m_AllocatorLabel_2() { return static_cast<int32_t>(offsetof(NativeArray_1_t18D233A2E30E28048C1252473AFD0799557294DA, ___m_AllocatorLabel_2)); }
	inline int32_t get_m_AllocatorLabel_2() const { return ___m_AllocatorLabel_2; }
	inline int32_t* get_address_of_m_AllocatorLabel_2() { return &___m_AllocatorLabel_2; }
	inline void set_m_AllocatorLabel_2(int32_t value)
	{
		___m_AllocatorLabel_2 = value;
	}
};


// Unity.Collections.NativeArray`1<System.Int32>
struct NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99 
{
public:
	// System.Void* Unity.Collections.NativeArray`1::m_Buffer
	void* ___m_Buffer_0;
	// System.Int32 Unity.Collections.NativeArray`1::m_Length
	int32_t ___m_Length_1;
	// Unity.Collections.Allocator Unity.Collections.NativeArray`1::m_AllocatorLabel
	int32_t ___m_AllocatorLabel_2;

public:
	inline static int32_t get_offset_of_m_Buffer_0() { return static_cast<int32_t>(offsetof(NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99, ___m_Buffer_0)); }
	inline void* get_m_Buffer_0() const { return ___m_Buffer_0; }
	inline void** get_address_of_m_Buffer_0() { return &___m_Buffer_0; }
	inline void set_m_Buffer_0(void* value)
	{
		___m_Buffer_0 = value;
	}

	inline static int32_t get_offset_of_m_Length_1() { return static_cast<int32_t>(offsetof(NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99, ___m_Length_1)); }
	inline int32_t get_m_Length_1() const { return ___m_Length_1; }
	inline int32_t* get_address_of_m_Length_1() { return &___m_Length_1; }
	inline void set_m_Length_1(int32_t value)
	{
		___m_Length_1 = value;
	}

	inline static int32_t get_offset_of_m_AllocatorLabel_2() { return static_cast<int32_t>(offsetof(NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99, ___m_AllocatorLabel_2)); }
	inline int32_t get_m_AllocatorLabel_2() const { return ___m_AllocatorLabel_2; }
	inline int32_t* get_address_of_m_AllocatorLabel_2() { return &___m_AllocatorLabel_2; }
	inline void set_m_AllocatorLabel_2(int32_t value)
	{
		___m_AllocatorLabel_2 = value;
	}
};


// Unity.Collections.NativeArray`1<UnityEngine.Experimental.GlobalIllumination.LightDataGI>
struct NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2 
{
public:
	// System.Void* Unity.Collections.NativeArray`1::m_Buffer
	void* ___m_Buffer_0;
	// System.Int32 Unity.Collections.NativeArray`1::m_Length
	int32_t ___m_Length_1;
	// Unity.Collections.Allocator Unity.Collections.NativeArray`1::m_AllocatorLabel
	int32_t ___m_AllocatorLabel_2;

public:
	inline static int32_t get_offset_of_m_Buffer_0() { return static_cast<int32_t>(offsetof(NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2, ___m_Buffer_0)); }
	inline void* get_m_Buffer_0() const { return ___m_Buffer_0; }
	inline void** get_address_of_m_Buffer_0() { return &___m_Buffer_0; }
	inline void set_m_Buffer_0(void* value)
	{
		___m_Buffer_0 = value;
	}

	inline static int32_t get_offset_of_m_Length_1() { return static_cast<int32_t>(offsetof(NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2, ___m_Length_1)); }
	inline int32_t get_m_Length_1() const { return ___m_Length_1; }
	inline int32_t* get_address_of_m_Length_1() { return &___m_Length_1; }
	inline void set_m_Length_1(int32_t value)
	{
		___m_Length_1 = value;
	}

	inline static int32_t get_offset_of_m_AllocatorLabel_2() { return static_cast<int32_t>(offsetof(NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2, ___m_AllocatorLabel_2)); }
	inline int32_t get_m_AllocatorLabel_2() const { return ___m_AllocatorLabel_2; }
	inline int32_t* get_address_of_m_AllocatorLabel_2() { return &___m_AllocatorLabel_2; }
	inline void set_m_AllocatorLabel_2(int32_t value)
	{
		___m_AllocatorLabel_2 = value;
	}
};


// Unity.Collections.NativeArray`1<UnityEngine.Plane>
struct NativeArray_1_t527C586787ACD1AD75E3C78BFB024FFA9925662E 
{
public:
	// System.Void* Unity.Collections.NativeArray`1::m_Buffer
	void* ___m_Buffer_0;
	// System.Int32 Unity.Collections.NativeArray`1::m_Length
	int32_t ___m_Length_1;
	// Unity.Collections.Allocator Unity.Collections.NativeArray`1::m_AllocatorLabel
	int32_t ___m_AllocatorLabel_2;

public:
	inline static int32_t get_offset_of_m_Buffer_0() { return static_cast<int32_t>(offsetof(NativeArray_1_t527C586787ACD1AD75E3C78BFB024FFA9925662E, ___m_Buffer_0)); }
	inline void* get_m_Buffer_0() const { return ___m_Buffer_0; }
	inline void** get_address_of_m_Buffer_0() { return &___m_Buffer_0; }
	inline void set_m_Buffer_0(void* value)
	{
		___m_Buffer_0 = value;
	}

	inline static int32_t get_offset_of_m_Length_1() { return static_cast<int32_t>(offsetof(NativeArray_1_t527C586787ACD1AD75E3C78BFB024FFA9925662E, ___m_Length_1)); }
	inline int32_t get_m_Length_1() const { return ___m_Length_1; }
	inline int32_t* get_address_of_m_Length_1() { return &___m_Length_1; }
	inline void set_m_Length_1(int32_t value)
	{
		___m_Length_1 = value;
	}

	inline static int32_t get_offset_of_m_AllocatorLabel_2() { return static_cast<int32_t>(offsetof(NativeArray_1_t527C586787ACD1AD75E3C78BFB024FFA9925662E, ___m_AllocatorLabel_2)); }
	inline int32_t get_m_AllocatorLabel_2() const { return ___m_AllocatorLabel_2; }
	inline int32_t* get_address_of_m_AllocatorLabel_2() { return &___m_AllocatorLabel_2; }
	inline void set_m_AllocatorLabel_2(int32_t value)
	{
		___m_AllocatorLabel_2 = value;
	}
};


// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.Experimental.GlobalIllumination.DirectionalLight
struct DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7 
{
public:
	// System.Int32 UnityEngine.Experimental.GlobalIllumination.DirectionalLight::instanceID
	int32_t ___instanceID_0;
	// System.Boolean UnityEngine.Experimental.GlobalIllumination.DirectionalLight::shadow
	bool ___shadow_1;
	// UnityEngine.Experimental.GlobalIllumination.LightMode UnityEngine.Experimental.GlobalIllumination.DirectionalLight::mode
	uint8_t ___mode_2;
	// UnityEngine.Vector3 UnityEngine.Experimental.GlobalIllumination.DirectionalLight::position
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	// UnityEngine.Quaternion UnityEngine.Experimental.GlobalIllumination.DirectionalLight::orientation
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.DirectionalLight::color
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.DirectionalLight::indirectColor
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	// System.Single UnityEngine.Experimental.GlobalIllumination.DirectionalLight::penumbraWidthRadian
	float ___penumbraWidthRadian_7;
	// UnityEngine.Vector3 UnityEngine.Experimental.GlobalIllumination.DirectionalLight::direction
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___direction_8;

public:
	inline static int32_t get_offset_of_instanceID_0() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___instanceID_0)); }
	inline int32_t get_instanceID_0() const { return ___instanceID_0; }
	inline int32_t* get_address_of_instanceID_0() { return &___instanceID_0; }
	inline void set_instanceID_0(int32_t value)
	{
		___instanceID_0 = value;
	}

	inline static int32_t get_offset_of_shadow_1() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___shadow_1)); }
	inline bool get_shadow_1() const { return ___shadow_1; }
	inline bool* get_address_of_shadow_1() { return &___shadow_1; }
	inline void set_shadow_1(bool value)
	{
		___shadow_1 = value;
	}

	inline static int32_t get_offset_of_mode_2() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___mode_2)); }
	inline uint8_t get_mode_2() const { return ___mode_2; }
	inline uint8_t* get_address_of_mode_2() { return &___mode_2; }
	inline void set_mode_2(uint8_t value)
	{
		___mode_2 = value;
	}

	inline static int32_t get_offset_of_position_3() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___position_3)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_position_3() const { return ___position_3; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_position_3() { return &___position_3; }
	inline void set_position_3(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___position_3 = value;
	}

	inline static int32_t get_offset_of_orientation_4() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___orientation_4)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_orientation_4() const { return ___orientation_4; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_orientation_4() { return &___orientation_4; }
	inline void set_orientation_4(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___orientation_4 = value;
	}

	inline static int32_t get_offset_of_color_5() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___color_5)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_color_5() const { return ___color_5; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_color_5() { return &___color_5; }
	inline void set_color_5(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___color_5 = value;
	}

	inline static int32_t get_offset_of_indirectColor_6() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___indirectColor_6)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_indirectColor_6() const { return ___indirectColor_6; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_indirectColor_6() { return &___indirectColor_6; }
	inline void set_indirectColor_6(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___indirectColor_6 = value;
	}

	inline static int32_t get_offset_of_penumbraWidthRadian_7() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___penumbraWidthRadian_7)); }
	inline float get_penumbraWidthRadian_7() const { return ___penumbraWidthRadian_7; }
	inline float* get_address_of_penumbraWidthRadian_7() { return &___penumbraWidthRadian_7; }
	inline void set_penumbraWidthRadian_7(float value)
	{
		___penumbraWidthRadian_7 = value;
	}

	inline static int32_t get_offset_of_direction_8() { return static_cast<int32_t>(offsetof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7, ___direction_8)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_direction_8() const { return ___direction_8; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_direction_8() { return &___direction_8; }
	inline void set_direction_8(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___direction_8 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Experimental.GlobalIllumination.DirectionalLight
struct DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7_marshaled_pinvoke
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___penumbraWidthRadian_7;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___direction_8;
};
// Native definition for COM marshalling of UnityEngine.Experimental.GlobalIllumination.DirectionalLight
struct DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7_marshaled_com
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___penumbraWidthRadian_7;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___direction_8;
};

// UnityEngine.Experimental.GlobalIllumination.DiscLight
struct DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D 
{
public:
	// System.Int32 UnityEngine.Experimental.GlobalIllumination.DiscLight::instanceID
	int32_t ___instanceID_0;
	// System.Boolean UnityEngine.Experimental.GlobalIllumination.DiscLight::shadow
	bool ___shadow_1;
	// UnityEngine.Experimental.GlobalIllumination.LightMode UnityEngine.Experimental.GlobalIllumination.DiscLight::mode
	uint8_t ___mode_2;
	// UnityEngine.Vector3 UnityEngine.Experimental.GlobalIllumination.DiscLight::position
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	// UnityEngine.Quaternion UnityEngine.Experimental.GlobalIllumination.DiscLight::orientation
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.DiscLight::color
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.DiscLight::indirectColor
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	// System.Single UnityEngine.Experimental.GlobalIllumination.DiscLight::range
	float ___range_7;
	// System.Single UnityEngine.Experimental.GlobalIllumination.DiscLight::radius
	float ___radius_8;
	// UnityEngine.Experimental.GlobalIllumination.FalloffType UnityEngine.Experimental.GlobalIllumination.DiscLight::falloff
	uint8_t ___falloff_9;

public:
	inline static int32_t get_offset_of_instanceID_0() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___instanceID_0)); }
	inline int32_t get_instanceID_0() const { return ___instanceID_0; }
	inline int32_t* get_address_of_instanceID_0() { return &___instanceID_0; }
	inline void set_instanceID_0(int32_t value)
	{
		___instanceID_0 = value;
	}

	inline static int32_t get_offset_of_shadow_1() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___shadow_1)); }
	inline bool get_shadow_1() const { return ___shadow_1; }
	inline bool* get_address_of_shadow_1() { return &___shadow_1; }
	inline void set_shadow_1(bool value)
	{
		___shadow_1 = value;
	}

	inline static int32_t get_offset_of_mode_2() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___mode_2)); }
	inline uint8_t get_mode_2() const { return ___mode_2; }
	inline uint8_t* get_address_of_mode_2() { return &___mode_2; }
	inline void set_mode_2(uint8_t value)
	{
		___mode_2 = value;
	}

	inline static int32_t get_offset_of_position_3() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___position_3)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_position_3() const { return ___position_3; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_position_3() { return &___position_3; }
	inline void set_position_3(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___position_3 = value;
	}

	inline static int32_t get_offset_of_orientation_4() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___orientation_4)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_orientation_4() const { return ___orientation_4; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_orientation_4() { return &___orientation_4; }
	inline void set_orientation_4(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___orientation_4 = value;
	}

	inline static int32_t get_offset_of_color_5() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___color_5)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_color_5() const { return ___color_5; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_color_5() { return &___color_5; }
	inline void set_color_5(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___color_5 = value;
	}

	inline static int32_t get_offset_of_indirectColor_6() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___indirectColor_6)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_indirectColor_6() const { return ___indirectColor_6; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_indirectColor_6() { return &___indirectColor_6; }
	inline void set_indirectColor_6(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___indirectColor_6 = value;
	}

	inline static int32_t get_offset_of_range_7() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___range_7)); }
	inline float get_range_7() const { return ___range_7; }
	inline float* get_address_of_range_7() { return &___range_7; }
	inline void set_range_7(float value)
	{
		___range_7 = value;
	}

	inline static int32_t get_offset_of_radius_8() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___radius_8)); }
	inline float get_radius_8() const { return ___radius_8; }
	inline float* get_address_of_radius_8() { return &___radius_8; }
	inline void set_radius_8(float value)
	{
		___radius_8 = value;
	}

	inline static int32_t get_offset_of_falloff_9() { return static_cast<int32_t>(offsetof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D, ___falloff_9)); }
	inline uint8_t get_falloff_9() const { return ___falloff_9; }
	inline uint8_t* get_address_of_falloff_9() { return &___falloff_9; }
	inline void set_falloff_9(uint8_t value)
	{
		___falloff_9 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Experimental.GlobalIllumination.DiscLight
struct DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D_marshaled_pinvoke
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___range_7;
	float ___radius_8;
	uint8_t ___falloff_9;
};
// Native definition for COM marshalling of UnityEngine.Experimental.GlobalIllumination.DiscLight
struct DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D_marshaled_com
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___range_7;
	float ___radius_8;
	uint8_t ___falloff_9;
};

// System.Threading.EventWaitHandle
struct EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C  : public WaitHandle_t1D7DD8480FD5DA4E3AF92F569890FB972D9B1842
{
public:

public:
};


// UnityEngine.Experimental.GlobalIllumination.LightDataGI
struct LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 
{
public:
	// System.Int32 UnityEngine.Experimental.GlobalIllumination.LightDataGI::instanceID
	int32_t ___instanceID_0;
	// System.Int32 UnityEngine.Experimental.GlobalIllumination.LightDataGI::cookieID
	int32_t ___cookieID_1;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LightDataGI::cookieScale
	float ___cookieScale_2;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.LightDataGI::color
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_3;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.LightDataGI::indirectColor
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_4;
	// UnityEngine.Quaternion UnityEngine.Experimental.GlobalIllumination.LightDataGI::orientation
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_5;
	// UnityEngine.Vector3 UnityEngine.Experimental.GlobalIllumination.LightDataGI::position
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_6;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LightDataGI::range
	float ___range_7;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LightDataGI::coneAngle
	float ___coneAngle_8;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LightDataGI::innerConeAngle
	float ___innerConeAngle_9;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LightDataGI::shape0
	float ___shape0_10;
	// System.Single UnityEngine.Experimental.GlobalIllumination.LightDataGI::shape1
	float ___shape1_11;
	// UnityEngine.Experimental.GlobalIllumination.LightType UnityEngine.Experimental.GlobalIllumination.LightDataGI::type
	uint8_t ___type_12;
	// UnityEngine.Experimental.GlobalIllumination.LightMode UnityEngine.Experimental.GlobalIllumination.LightDataGI::mode
	uint8_t ___mode_13;
	// System.Byte UnityEngine.Experimental.GlobalIllumination.LightDataGI::shadow
	uint8_t ___shadow_14;
	// UnityEngine.Experimental.GlobalIllumination.FalloffType UnityEngine.Experimental.GlobalIllumination.LightDataGI::falloff
	uint8_t ___falloff_15;

public:
	inline static int32_t get_offset_of_instanceID_0() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___instanceID_0)); }
	inline int32_t get_instanceID_0() const { return ___instanceID_0; }
	inline int32_t* get_address_of_instanceID_0() { return &___instanceID_0; }
	inline void set_instanceID_0(int32_t value)
	{
		___instanceID_0 = value;
	}

	inline static int32_t get_offset_of_cookieID_1() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___cookieID_1)); }
	inline int32_t get_cookieID_1() const { return ___cookieID_1; }
	inline int32_t* get_address_of_cookieID_1() { return &___cookieID_1; }
	inline void set_cookieID_1(int32_t value)
	{
		___cookieID_1 = value;
	}

	inline static int32_t get_offset_of_cookieScale_2() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___cookieScale_2)); }
	inline float get_cookieScale_2() const { return ___cookieScale_2; }
	inline float* get_address_of_cookieScale_2() { return &___cookieScale_2; }
	inline void set_cookieScale_2(float value)
	{
		___cookieScale_2 = value;
	}

	inline static int32_t get_offset_of_color_3() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___color_3)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_color_3() const { return ___color_3; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_color_3() { return &___color_3; }
	inline void set_color_3(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___color_3 = value;
	}

	inline static int32_t get_offset_of_indirectColor_4() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___indirectColor_4)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_indirectColor_4() const { return ___indirectColor_4; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_indirectColor_4() { return &___indirectColor_4; }
	inline void set_indirectColor_4(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___indirectColor_4 = value;
	}

	inline static int32_t get_offset_of_orientation_5() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___orientation_5)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_orientation_5() const { return ___orientation_5; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_orientation_5() { return &___orientation_5; }
	inline void set_orientation_5(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___orientation_5 = value;
	}

	inline static int32_t get_offset_of_position_6() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___position_6)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_position_6() const { return ___position_6; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_position_6() { return &___position_6; }
	inline void set_position_6(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___position_6 = value;
	}

	inline static int32_t get_offset_of_range_7() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___range_7)); }
	inline float get_range_7() const { return ___range_7; }
	inline float* get_address_of_range_7() { return &___range_7; }
	inline void set_range_7(float value)
	{
		___range_7 = value;
	}

	inline static int32_t get_offset_of_coneAngle_8() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___coneAngle_8)); }
	inline float get_coneAngle_8() const { return ___coneAngle_8; }
	inline float* get_address_of_coneAngle_8() { return &___coneAngle_8; }
	inline void set_coneAngle_8(float value)
	{
		___coneAngle_8 = value;
	}

	inline static int32_t get_offset_of_innerConeAngle_9() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___innerConeAngle_9)); }
	inline float get_innerConeAngle_9() const { return ___innerConeAngle_9; }
	inline float* get_address_of_innerConeAngle_9() { return &___innerConeAngle_9; }
	inline void set_innerConeAngle_9(float value)
	{
		___innerConeAngle_9 = value;
	}

	inline static int32_t get_offset_of_shape0_10() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___shape0_10)); }
	inline float get_shape0_10() const { return ___shape0_10; }
	inline float* get_address_of_shape0_10() { return &___shape0_10; }
	inline void set_shape0_10(float value)
	{
		___shape0_10 = value;
	}

	inline static int32_t get_offset_of_shape1_11() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___shape1_11)); }
	inline float get_shape1_11() const { return ___shape1_11; }
	inline float* get_address_of_shape1_11() { return &___shape1_11; }
	inline void set_shape1_11(float value)
	{
		___shape1_11 = value;
	}

	inline static int32_t get_offset_of_type_12() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___type_12)); }
	inline uint8_t get_type_12() const { return ___type_12; }
	inline uint8_t* get_address_of_type_12() { return &___type_12; }
	inline void set_type_12(uint8_t value)
	{
		___type_12 = value;
	}

	inline static int32_t get_offset_of_mode_13() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___mode_13)); }
	inline uint8_t get_mode_13() const { return ___mode_13; }
	inline uint8_t* get_address_of_mode_13() { return &___mode_13; }
	inline void set_mode_13(uint8_t value)
	{
		___mode_13 = value;
	}

	inline static int32_t get_offset_of_shadow_14() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___shadow_14)); }
	inline uint8_t get_shadow_14() const { return ___shadow_14; }
	inline uint8_t* get_address_of_shadow_14() { return &___shadow_14; }
	inline void set_shadow_14(uint8_t value)
	{
		___shadow_14 = value;
	}

	inline static int32_t get_offset_of_falloff_15() { return static_cast<int32_t>(offsetof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2, ___falloff_15)); }
	inline uint8_t get_falloff_15() const { return ___falloff_15; }
	inline uint8_t* get_address_of_falloff_15() { return &___falloff_15; }
	inline void set_falloff_15(uint8_t value)
	{
		___falloff_15 = value;
	}
};


// UnityEngine.Mesh
struct Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
public:
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* ___delegates_11;

public:
	inline static int32_t get_offset_of_delegates_11() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___delegates_11)); }
	inline DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* get_delegates_11() const { return ___delegates_11; }
	inline DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8** get_address_of_delegates_11() { return &___delegates_11; }
	inline void set_delegates_11(DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* value)
	{
		___delegates_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delegates_11), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_11;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_11;
};

// System.Globalization.NumberFormatInfo
struct NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D  : public RuntimeObject
{
public:
	// System.Int32[] System.Globalization.NumberFormatInfo::numberGroupSizes
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___numberGroupSizes_1;
	// System.Int32[] System.Globalization.NumberFormatInfo::currencyGroupSizes
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___currencyGroupSizes_2;
	// System.Int32[] System.Globalization.NumberFormatInfo::percentGroupSizes
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___percentGroupSizes_3;
	// System.String System.Globalization.NumberFormatInfo::positiveSign
	String_t* ___positiveSign_4;
	// System.String System.Globalization.NumberFormatInfo::negativeSign
	String_t* ___negativeSign_5;
	// System.String System.Globalization.NumberFormatInfo::numberDecimalSeparator
	String_t* ___numberDecimalSeparator_6;
	// System.String System.Globalization.NumberFormatInfo::numberGroupSeparator
	String_t* ___numberGroupSeparator_7;
	// System.String System.Globalization.NumberFormatInfo::currencyGroupSeparator
	String_t* ___currencyGroupSeparator_8;
	// System.String System.Globalization.NumberFormatInfo::currencyDecimalSeparator
	String_t* ___currencyDecimalSeparator_9;
	// System.String System.Globalization.NumberFormatInfo::currencySymbol
	String_t* ___currencySymbol_10;
	// System.String System.Globalization.NumberFormatInfo::ansiCurrencySymbol
	String_t* ___ansiCurrencySymbol_11;
	// System.String System.Globalization.NumberFormatInfo::nanSymbol
	String_t* ___nanSymbol_12;
	// System.String System.Globalization.NumberFormatInfo::positiveInfinitySymbol
	String_t* ___positiveInfinitySymbol_13;
	// System.String System.Globalization.NumberFormatInfo::negativeInfinitySymbol
	String_t* ___negativeInfinitySymbol_14;
	// System.String System.Globalization.NumberFormatInfo::percentDecimalSeparator
	String_t* ___percentDecimalSeparator_15;
	// System.String System.Globalization.NumberFormatInfo::percentGroupSeparator
	String_t* ___percentGroupSeparator_16;
	// System.String System.Globalization.NumberFormatInfo::percentSymbol
	String_t* ___percentSymbol_17;
	// System.String System.Globalization.NumberFormatInfo::perMilleSymbol
	String_t* ___perMilleSymbol_18;
	// System.String[] System.Globalization.NumberFormatInfo::nativeDigits
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___nativeDigits_19;
	// System.Int32 System.Globalization.NumberFormatInfo::m_dataItem
	int32_t ___m_dataItem_20;
	// System.Int32 System.Globalization.NumberFormatInfo::numberDecimalDigits
	int32_t ___numberDecimalDigits_21;
	// System.Int32 System.Globalization.NumberFormatInfo::currencyDecimalDigits
	int32_t ___currencyDecimalDigits_22;
	// System.Int32 System.Globalization.NumberFormatInfo::currencyPositivePattern
	int32_t ___currencyPositivePattern_23;
	// System.Int32 System.Globalization.NumberFormatInfo::currencyNegativePattern
	int32_t ___currencyNegativePattern_24;
	// System.Int32 System.Globalization.NumberFormatInfo::numberNegativePattern
	int32_t ___numberNegativePattern_25;
	// System.Int32 System.Globalization.NumberFormatInfo::percentPositivePattern
	int32_t ___percentPositivePattern_26;
	// System.Int32 System.Globalization.NumberFormatInfo::percentNegativePattern
	int32_t ___percentNegativePattern_27;
	// System.Int32 System.Globalization.NumberFormatInfo::percentDecimalDigits
	int32_t ___percentDecimalDigits_28;
	// System.Int32 System.Globalization.NumberFormatInfo::digitSubstitution
	int32_t ___digitSubstitution_29;
	// System.Boolean System.Globalization.NumberFormatInfo::isReadOnly
	bool ___isReadOnly_30;
	// System.Boolean System.Globalization.NumberFormatInfo::m_useUserOverride
	bool ___m_useUserOverride_31;
	// System.Boolean System.Globalization.NumberFormatInfo::m_isInvariant
	bool ___m_isInvariant_32;
	// System.Boolean System.Globalization.NumberFormatInfo::validForParseAsNumber
	bool ___validForParseAsNumber_33;
	// System.Boolean System.Globalization.NumberFormatInfo::validForParseAsCurrency
	bool ___validForParseAsCurrency_34;

public:
	inline static int32_t get_offset_of_numberGroupSizes_1() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___numberGroupSizes_1)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_numberGroupSizes_1() const { return ___numberGroupSizes_1; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_numberGroupSizes_1() { return &___numberGroupSizes_1; }
	inline void set_numberGroupSizes_1(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___numberGroupSizes_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___numberGroupSizes_1), (void*)value);
	}

	inline static int32_t get_offset_of_currencyGroupSizes_2() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___currencyGroupSizes_2)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_currencyGroupSizes_2() const { return ___currencyGroupSizes_2; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_currencyGroupSizes_2() { return &___currencyGroupSizes_2; }
	inline void set_currencyGroupSizes_2(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___currencyGroupSizes_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currencyGroupSizes_2), (void*)value);
	}

	inline static int32_t get_offset_of_percentGroupSizes_3() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___percentGroupSizes_3)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_percentGroupSizes_3() const { return ___percentGroupSizes_3; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_percentGroupSizes_3() { return &___percentGroupSizes_3; }
	inline void set_percentGroupSizes_3(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___percentGroupSizes_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___percentGroupSizes_3), (void*)value);
	}

	inline static int32_t get_offset_of_positiveSign_4() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___positiveSign_4)); }
	inline String_t* get_positiveSign_4() const { return ___positiveSign_4; }
	inline String_t** get_address_of_positiveSign_4() { return &___positiveSign_4; }
	inline void set_positiveSign_4(String_t* value)
	{
		___positiveSign_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___positiveSign_4), (void*)value);
	}

	inline static int32_t get_offset_of_negativeSign_5() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___negativeSign_5)); }
	inline String_t* get_negativeSign_5() const { return ___negativeSign_5; }
	inline String_t** get_address_of_negativeSign_5() { return &___negativeSign_5; }
	inline void set_negativeSign_5(String_t* value)
	{
		___negativeSign_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___negativeSign_5), (void*)value);
	}

	inline static int32_t get_offset_of_numberDecimalSeparator_6() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___numberDecimalSeparator_6)); }
	inline String_t* get_numberDecimalSeparator_6() const { return ___numberDecimalSeparator_6; }
	inline String_t** get_address_of_numberDecimalSeparator_6() { return &___numberDecimalSeparator_6; }
	inline void set_numberDecimalSeparator_6(String_t* value)
	{
		___numberDecimalSeparator_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___numberDecimalSeparator_6), (void*)value);
	}

	inline static int32_t get_offset_of_numberGroupSeparator_7() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___numberGroupSeparator_7)); }
	inline String_t* get_numberGroupSeparator_7() const { return ___numberGroupSeparator_7; }
	inline String_t** get_address_of_numberGroupSeparator_7() { return &___numberGroupSeparator_7; }
	inline void set_numberGroupSeparator_7(String_t* value)
	{
		___numberGroupSeparator_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___numberGroupSeparator_7), (void*)value);
	}

	inline static int32_t get_offset_of_currencyGroupSeparator_8() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___currencyGroupSeparator_8)); }
	inline String_t* get_currencyGroupSeparator_8() const { return ___currencyGroupSeparator_8; }
	inline String_t** get_address_of_currencyGroupSeparator_8() { return &___currencyGroupSeparator_8; }
	inline void set_currencyGroupSeparator_8(String_t* value)
	{
		___currencyGroupSeparator_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currencyGroupSeparator_8), (void*)value);
	}

	inline static int32_t get_offset_of_currencyDecimalSeparator_9() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___currencyDecimalSeparator_9)); }
	inline String_t* get_currencyDecimalSeparator_9() const { return ___currencyDecimalSeparator_9; }
	inline String_t** get_address_of_currencyDecimalSeparator_9() { return &___currencyDecimalSeparator_9; }
	inline void set_currencyDecimalSeparator_9(String_t* value)
	{
		___currencyDecimalSeparator_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currencyDecimalSeparator_9), (void*)value);
	}

	inline static int32_t get_offset_of_currencySymbol_10() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___currencySymbol_10)); }
	inline String_t* get_currencySymbol_10() const { return ___currencySymbol_10; }
	inline String_t** get_address_of_currencySymbol_10() { return &___currencySymbol_10; }
	inline void set_currencySymbol_10(String_t* value)
	{
		___currencySymbol_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___currencySymbol_10), (void*)value);
	}

	inline static int32_t get_offset_of_ansiCurrencySymbol_11() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___ansiCurrencySymbol_11)); }
	inline String_t* get_ansiCurrencySymbol_11() const { return ___ansiCurrencySymbol_11; }
	inline String_t** get_address_of_ansiCurrencySymbol_11() { return &___ansiCurrencySymbol_11; }
	inline void set_ansiCurrencySymbol_11(String_t* value)
	{
		___ansiCurrencySymbol_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ansiCurrencySymbol_11), (void*)value);
	}

	inline static int32_t get_offset_of_nanSymbol_12() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___nanSymbol_12)); }
	inline String_t* get_nanSymbol_12() const { return ___nanSymbol_12; }
	inline String_t** get_address_of_nanSymbol_12() { return &___nanSymbol_12; }
	inline void set_nanSymbol_12(String_t* value)
	{
		___nanSymbol_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___nanSymbol_12), (void*)value);
	}

	inline static int32_t get_offset_of_positiveInfinitySymbol_13() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___positiveInfinitySymbol_13)); }
	inline String_t* get_positiveInfinitySymbol_13() const { return ___positiveInfinitySymbol_13; }
	inline String_t** get_address_of_positiveInfinitySymbol_13() { return &___positiveInfinitySymbol_13; }
	inline void set_positiveInfinitySymbol_13(String_t* value)
	{
		___positiveInfinitySymbol_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___positiveInfinitySymbol_13), (void*)value);
	}

	inline static int32_t get_offset_of_negativeInfinitySymbol_14() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___negativeInfinitySymbol_14)); }
	inline String_t* get_negativeInfinitySymbol_14() const { return ___negativeInfinitySymbol_14; }
	inline String_t** get_address_of_negativeInfinitySymbol_14() { return &___negativeInfinitySymbol_14; }
	inline void set_negativeInfinitySymbol_14(String_t* value)
	{
		___negativeInfinitySymbol_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___negativeInfinitySymbol_14), (void*)value);
	}

	inline static int32_t get_offset_of_percentDecimalSeparator_15() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___percentDecimalSeparator_15)); }
	inline String_t* get_percentDecimalSeparator_15() const { return ___percentDecimalSeparator_15; }
	inline String_t** get_address_of_percentDecimalSeparator_15() { return &___percentDecimalSeparator_15; }
	inline void set_percentDecimalSeparator_15(String_t* value)
	{
		___percentDecimalSeparator_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___percentDecimalSeparator_15), (void*)value);
	}

	inline static int32_t get_offset_of_percentGroupSeparator_16() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___percentGroupSeparator_16)); }
	inline String_t* get_percentGroupSeparator_16() const { return ___percentGroupSeparator_16; }
	inline String_t** get_address_of_percentGroupSeparator_16() { return &___percentGroupSeparator_16; }
	inline void set_percentGroupSeparator_16(String_t* value)
	{
		___percentGroupSeparator_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___percentGroupSeparator_16), (void*)value);
	}

	inline static int32_t get_offset_of_percentSymbol_17() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___percentSymbol_17)); }
	inline String_t* get_percentSymbol_17() const { return ___percentSymbol_17; }
	inline String_t** get_address_of_percentSymbol_17() { return &___percentSymbol_17; }
	inline void set_percentSymbol_17(String_t* value)
	{
		___percentSymbol_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___percentSymbol_17), (void*)value);
	}

	inline static int32_t get_offset_of_perMilleSymbol_18() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___perMilleSymbol_18)); }
	inline String_t* get_perMilleSymbol_18() const { return ___perMilleSymbol_18; }
	inline String_t** get_address_of_perMilleSymbol_18() { return &___perMilleSymbol_18; }
	inline void set_perMilleSymbol_18(String_t* value)
	{
		___perMilleSymbol_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___perMilleSymbol_18), (void*)value);
	}

	inline static int32_t get_offset_of_nativeDigits_19() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___nativeDigits_19)); }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* get_nativeDigits_19() const { return ___nativeDigits_19; }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** get_address_of_nativeDigits_19() { return &___nativeDigits_19; }
	inline void set_nativeDigits_19(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* value)
	{
		___nativeDigits_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___nativeDigits_19), (void*)value);
	}

	inline static int32_t get_offset_of_m_dataItem_20() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___m_dataItem_20)); }
	inline int32_t get_m_dataItem_20() const { return ___m_dataItem_20; }
	inline int32_t* get_address_of_m_dataItem_20() { return &___m_dataItem_20; }
	inline void set_m_dataItem_20(int32_t value)
	{
		___m_dataItem_20 = value;
	}

	inline static int32_t get_offset_of_numberDecimalDigits_21() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___numberDecimalDigits_21)); }
	inline int32_t get_numberDecimalDigits_21() const { return ___numberDecimalDigits_21; }
	inline int32_t* get_address_of_numberDecimalDigits_21() { return &___numberDecimalDigits_21; }
	inline void set_numberDecimalDigits_21(int32_t value)
	{
		___numberDecimalDigits_21 = value;
	}

	inline static int32_t get_offset_of_currencyDecimalDigits_22() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___currencyDecimalDigits_22)); }
	inline int32_t get_currencyDecimalDigits_22() const { return ___currencyDecimalDigits_22; }
	inline int32_t* get_address_of_currencyDecimalDigits_22() { return &___currencyDecimalDigits_22; }
	inline void set_currencyDecimalDigits_22(int32_t value)
	{
		___currencyDecimalDigits_22 = value;
	}

	inline static int32_t get_offset_of_currencyPositivePattern_23() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___currencyPositivePattern_23)); }
	inline int32_t get_currencyPositivePattern_23() const { return ___currencyPositivePattern_23; }
	inline int32_t* get_address_of_currencyPositivePattern_23() { return &___currencyPositivePattern_23; }
	inline void set_currencyPositivePattern_23(int32_t value)
	{
		___currencyPositivePattern_23 = value;
	}

	inline static int32_t get_offset_of_currencyNegativePattern_24() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___currencyNegativePattern_24)); }
	inline int32_t get_currencyNegativePattern_24() const { return ___currencyNegativePattern_24; }
	inline int32_t* get_address_of_currencyNegativePattern_24() { return &___currencyNegativePattern_24; }
	inline void set_currencyNegativePattern_24(int32_t value)
	{
		___currencyNegativePattern_24 = value;
	}

	inline static int32_t get_offset_of_numberNegativePattern_25() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___numberNegativePattern_25)); }
	inline int32_t get_numberNegativePattern_25() const { return ___numberNegativePattern_25; }
	inline int32_t* get_address_of_numberNegativePattern_25() { return &___numberNegativePattern_25; }
	inline void set_numberNegativePattern_25(int32_t value)
	{
		___numberNegativePattern_25 = value;
	}

	inline static int32_t get_offset_of_percentPositivePattern_26() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___percentPositivePattern_26)); }
	inline int32_t get_percentPositivePattern_26() const { return ___percentPositivePattern_26; }
	inline int32_t* get_address_of_percentPositivePattern_26() { return &___percentPositivePattern_26; }
	inline void set_percentPositivePattern_26(int32_t value)
	{
		___percentPositivePattern_26 = value;
	}

	inline static int32_t get_offset_of_percentNegativePattern_27() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___percentNegativePattern_27)); }
	inline int32_t get_percentNegativePattern_27() const { return ___percentNegativePattern_27; }
	inline int32_t* get_address_of_percentNegativePattern_27() { return &___percentNegativePattern_27; }
	inline void set_percentNegativePattern_27(int32_t value)
	{
		___percentNegativePattern_27 = value;
	}

	inline static int32_t get_offset_of_percentDecimalDigits_28() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___percentDecimalDigits_28)); }
	inline int32_t get_percentDecimalDigits_28() const { return ___percentDecimalDigits_28; }
	inline int32_t* get_address_of_percentDecimalDigits_28() { return &___percentDecimalDigits_28; }
	inline void set_percentDecimalDigits_28(int32_t value)
	{
		___percentDecimalDigits_28 = value;
	}

	inline static int32_t get_offset_of_digitSubstitution_29() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___digitSubstitution_29)); }
	inline int32_t get_digitSubstitution_29() const { return ___digitSubstitution_29; }
	inline int32_t* get_address_of_digitSubstitution_29() { return &___digitSubstitution_29; }
	inline void set_digitSubstitution_29(int32_t value)
	{
		___digitSubstitution_29 = value;
	}

	inline static int32_t get_offset_of_isReadOnly_30() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___isReadOnly_30)); }
	inline bool get_isReadOnly_30() const { return ___isReadOnly_30; }
	inline bool* get_address_of_isReadOnly_30() { return &___isReadOnly_30; }
	inline void set_isReadOnly_30(bool value)
	{
		___isReadOnly_30 = value;
	}

	inline static int32_t get_offset_of_m_useUserOverride_31() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___m_useUserOverride_31)); }
	inline bool get_m_useUserOverride_31() const { return ___m_useUserOverride_31; }
	inline bool* get_address_of_m_useUserOverride_31() { return &___m_useUserOverride_31; }
	inline void set_m_useUserOverride_31(bool value)
	{
		___m_useUserOverride_31 = value;
	}

	inline static int32_t get_offset_of_m_isInvariant_32() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___m_isInvariant_32)); }
	inline bool get_m_isInvariant_32() const { return ___m_isInvariant_32; }
	inline bool* get_address_of_m_isInvariant_32() { return &___m_isInvariant_32; }
	inline void set_m_isInvariant_32(bool value)
	{
		___m_isInvariant_32 = value;
	}

	inline static int32_t get_offset_of_validForParseAsNumber_33() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___validForParseAsNumber_33)); }
	inline bool get_validForParseAsNumber_33() const { return ___validForParseAsNumber_33; }
	inline bool* get_address_of_validForParseAsNumber_33() { return &___validForParseAsNumber_33; }
	inline void set_validForParseAsNumber_33(bool value)
	{
		___validForParseAsNumber_33 = value;
	}

	inline static int32_t get_offset_of_validForParseAsCurrency_34() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D, ___validForParseAsCurrency_34)); }
	inline bool get_validForParseAsCurrency_34() const { return ___validForParseAsCurrency_34; }
	inline bool* get_address_of_validForParseAsCurrency_34() { return &___validForParseAsCurrency_34; }
	inline void set_validForParseAsCurrency_34(bool value)
	{
		___validForParseAsCurrency_34 = value;
	}
};

struct NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D_StaticFields
{
public:
	// System.Globalization.NumberFormatInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.NumberFormatInfo::invariantInfo
	NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * ___invariantInfo_0;

public:
	inline static int32_t get_offset_of_invariantInfo_0() { return static_cast<int32_t>(offsetof(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D_StaticFields, ___invariantInfo_0)); }
	inline NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * get_invariantInfo_0() const { return ___invariantInfo_0; }
	inline NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D ** get_address_of_invariantInfo_0() { return &___invariantInfo_0; }
	inline void set_invariantInfo_0(NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * value)
	{
		___invariantInfo_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___invariantInfo_0), (void*)value);
	}
};


// UnityEngine.Playables.PlayableOutput
struct PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82 
{
public:
	// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Playables.PlayableOutput::m_Handle
	PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82, ___m_Handle_0)); }
	inline PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1 * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  value)
	{
		___m_Handle_0 = value;
	}
};

struct PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82_StaticFields
{
public:
	// UnityEngine.Playables.PlayableOutput UnityEngine.Playables.PlayableOutput::m_NullPlayableOutput
	PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  ___m_NullPlayableOutput_1;

public:
	inline static int32_t get_offset_of_m_NullPlayableOutput_1() { return static_cast<int32_t>(offsetof(PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82_StaticFields, ___m_NullPlayableOutput_1)); }
	inline PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  get_m_NullPlayableOutput_1() const { return ___m_NullPlayableOutput_1; }
	inline PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82 * get_address_of_m_NullPlayableOutput_1() { return &___m_NullPlayableOutput_1; }
	inline void set_m_NullPlayableOutput_1(PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  value)
	{
		___m_NullPlayableOutput_1 = value;
	}
};


// UnityEngine.Experimental.GlobalIllumination.PointLight
struct PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E 
{
public:
	// System.Int32 UnityEngine.Experimental.GlobalIllumination.PointLight::instanceID
	int32_t ___instanceID_0;
	// System.Boolean UnityEngine.Experimental.GlobalIllumination.PointLight::shadow
	bool ___shadow_1;
	// UnityEngine.Experimental.GlobalIllumination.LightMode UnityEngine.Experimental.GlobalIllumination.PointLight::mode
	uint8_t ___mode_2;
	// UnityEngine.Vector3 UnityEngine.Experimental.GlobalIllumination.PointLight::position
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	// UnityEngine.Quaternion UnityEngine.Experimental.GlobalIllumination.PointLight::orientation
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.PointLight::color
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.PointLight::indirectColor
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	// System.Single UnityEngine.Experimental.GlobalIllumination.PointLight::range
	float ___range_7;
	// System.Single UnityEngine.Experimental.GlobalIllumination.PointLight::sphereRadius
	float ___sphereRadius_8;
	// UnityEngine.Experimental.GlobalIllumination.FalloffType UnityEngine.Experimental.GlobalIllumination.PointLight::falloff
	uint8_t ___falloff_9;

public:
	inline static int32_t get_offset_of_instanceID_0() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___instanceID_0)); }
	inline int32_t get_instanceID_0() const { return ___instanceID_0; }
	inline int32_t* get_address_of_instanceID_0() { return &___instanceID_0; }
	inline void set_instanceID_0(int32_t value)
	{
		___instanceID_0 = value;
	}

	inline static int32_t get_offset_of_shadow_1() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___shadow_1)); }
	inline bool get_shadow_1() const { return ___shadow_1; }
	inline bool* get_address_of_shadow_1() { return &___shadow_1; }
	inline void set_shadow_1(bool value)
	{
		___shadow_1 = value;
	}

	inline static int32_t get_offset_of_mode_2() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___mode_2)); }
	inline uint8_t get_mode_2() const { return ___mode_2; }
	inline uint8_t* get_address_of_mode_2() { return &___mode_2; }
	inline void set_mode_2(uint8_t value)
	{
		___mode_2 = value;
	}

	inline static int32_t get_offset_of_position_3() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___position_3)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_position_3() const { return ___position_3; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_position_3() { return &___position_3; }
	inline void set_position_3(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___position_3 = value;
	}

	inline static int32_t get_offset_of_orientation_4() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___orientation_4)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_orientation_4() const { return ___orientation_4; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_orientation_4() { return &___orientation_4; }
	inline void set_orientation_4(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___orientation_4 = value;
	}

	inline static int32_t get_offset_of_color_5() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___color_5)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_color_5() const { return ___color_5; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_color_5() { return &___color_5; }
	inline void set_color_5(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___color_5 = value;
	}

	inline static int32_t get_offset_of_indirectColor_6() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___indirectColor_6)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_indirectColor_6() const { return ___indirectColor_6; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_indirectColor_6() { return &___indirectColor_6; }
	inline void set_indirectColor_6(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___indirectColor_6 = value;
	}

	inline static int32_t get_offset_of_range_7() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___range_7)); }
	inline float get_range_7() const { return ___range_7; }
	inline float* get_address_of_range_7() { return &___range_7; }
	inline void set_range_7(float value)
	{
		___range_7 = value;
	}

	inline static int32_t get_offset_of_sphereRadius_8() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___sphereRadius_8)); }
	inline float get_sphereRadius_8() const { return ___sphereRadius_8; }
	inline float* get_address_of_sphereRadius_8() { return &___sphereRadius_8; }
	inline void set_sphereRadius_8(float value)
	{
		___sphereRadius_8 = value;
	}

	inline static int32_t get_offset_of_falloff_9() { return static_cast<int32_t>(offsetof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E, ___falloff_9)); }
	inline uint8_t get_falloff_9() const { return ___falloff_9; }
	inline uint8_t* get_address_of_falloff_9() { return &___falloff_9; }
	inline void set_falloff_9(uint8_t value)
	{
		___falloff_9 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Experimental.GlobalIllumination.PointLight
struct PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E_marshaled_pinvoke
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___range_7;
	float ___sphereRadius_8;
	uint8_t ___falloff_9;
};
// Native definition for COM marshalling of UnityEngine.Experimental.GlobalIllumination.PointLight
struct PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E_marshaled_com
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___range_7;
	float ___sphereRadius_8;
	uint8_t ___falloff_9;
};

// UnityEngine.Experimental.GlobalIllumination.RectangleLight
struct RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985 
{
public:
	// System.Int32 UnityEngine.Experimental.GlobalIllumination.RectangleLight::instanceID
	int32_t ___instanceID_0;
	// System.Boolean UnityEngine.Experimental.GlobalIllumination.RectangleLight::shadow
	bool ___shadow_1;
	// UnityEngine.Experimental.GlobalIllumination.LightMode UnityEngine.Experimental.GlobalIllumination.RectangleLight::mode
	uint8_t ___mode_2;
	// UnityEngine.Vector3 UnityEngine.Experimental.GlobalIllumination.RectangleLight::position
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	// UnityEngine.Quaternion UnityEngine.Experimental.GlobalIllumination.RectangleLight::orientation
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.RectangleLight::color
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.RectangleLight::indirectColor
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	// System.Single UnityEngine.Experimental.GlobalIllumination.RectangleLight::range
	float ___range_7;
	// System.Single UnityEngine.Experimental.GlobalIllumination.RectangleLight::width
	float ___width_8;
	// System.Single UnityEngine.Experimental.GlobalIllumination.RectangleLight::height
	float ___height_9;
	// UnityEngine.Experimental.GlobalIllumination.FalloffType UnityEngine.Experimental.GlobalIllumination.RectangleLight::falloff
	uint8_t ___falloff_10;

public:
	inline static int32_t get_offset_of_instanceID_0() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___instanceID_0)); }
	inline int32_t get_instanceID_0() const { return ___instanceID_0; }
	inline int32_t* get_address_of_instanceID_0() { return &___instanceID_0; }
	inline void set_instanceID_0(int32_t value)
	{
		___instanceID_0 = value;
	}

	inline static int32_t get_offset_of_shadow_1() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___shadow_1)); }
	inline bool get_shadow_1() const { return ___shadow_1; }
	inline bool* get_address_of_shadow_1() { return &___shadow_1; }
	inline void set_shadow_1(bool value)
	{
		___shadow_1 = value;
	}

	inline static int32_t get_offset_of_mode_2() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___mode_2)); }
	inline uint8_t get_mode_2() const { return ___mode_2; }
	inline uint8_t* get_address_of_mode_2() { return &___mode_2; }
	inline void set_mode_2(uint8_t value)
	{
		___mode_2 = value;
	}

	inline static int32_t get_offset_of_position_3() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___position_3)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_position_3() const { return ___position_3; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_position_3() { return &___position_3; }
	inline void set_position_3(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___position_3 = value;
	}

	inline static int32_t get_offset_of_orientation_4() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___orientation_4)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_orientation_4() const { return ___orientation_4; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_orientation_4() { return &___orientation_4; }
	inline void set_orientation_4(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___orientation_4 = value;
	}

	inline static int32_t get_offset_of_color_5() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___color_5)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_color_5() const { return ___color_5; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_color_5() { return &___color_5; }
	inline void set_color_5(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___color_5 = value;
	}

	inline static int32_t get_offset_of_indirectColor_6() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___indirectColor_6)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_indirectColor_6() const { return ___indirectColor_6; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_indirectColor_6() { return &___indirectColor_6; }
	inline void set_indirectColor_6(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___indirectColor_6 = value;
	}

	inline static int32_t get_offset_of_range_7() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___range_7)); }
	inline float get_range_7() const { return ___range_7; }
	inline float* get_address_of_range_7() { return &___range_7; }
	inline void set_range_7(float value)
	{
		___range_7 = value;
	}

	inline static int32_t get_offset_of_width_8() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___width_8)); }
	inline float get_width_8() const { return ___width_8; }
	inline float* get_address_of_width_8() { return &___width_8; }
	inline void set_width_8(float value)
	{
		___width_8 = value;
	}

	inline static int32_t get_offset_of_height_9() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___height_9)); }
	inline float get_height_9() const { return ___height_9; }
	inline float* get_address_of_height_9() { return &___height_9; }
	inline void set_height_9(float value)
	{
		___height_9 = value;
	}

	inline static int32_t get_offset_of_falloff_10() { return static_cast<int32_t>(offsetof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985, ___falloff_10)); }
	inline uint8_t get_falloff_10() const { return ___falloff_10; }
	inline uint8_t* get_address_of_falloff_10() { return &___falloff_10; }
	inline void set_falloff_10(uint8_t value)
	{
		___falloff_10 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Experimental.GlobalIllumination.RectangleLight
struct RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985_marshaled_pinvoke
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___range_7;
	float ___width_8;
	float ___height_9;
	uint8_t ___falloff_10;
};
// Native definition for COM marshalling of UnityEngine.Experimental.GlobalIllumination.RectangleLight
struct RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985_marshaled_com
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___range_7;
	float ___width_8;
	float ___height_9;
	uint8_t ___falloff_10;
};

// UnityEngine.Experimental.GlobalIllumination.SpotLight
struct SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D 
{
public:
	// System.Int32 UnityEngine.Experimental.GlobalIllumination.SpotLight::instanceID
	int32_t ___instanceID_0;
	// System.Boolean UnityEngine.Experimental.GlobalIllumination.SpotLight::shadow
	bool ___shadow_1;
	// UnityEngine.Experimental.GlobalIllumination.LightMode UnityEngine.Experimental.GlobalIllumination.SpotLight::mode
	uint8_t ___mode_2;
	// UnityEngine.Vector3 UnityEngine.Experimental.GlobalIllumination.SpotLight::position
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	// UnityEngine.Quaternion UnityEngine.Experimental.GlobalIllumination.SpotLight::orientation
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.SpotLight::color
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	// UnityEngine.Experimental.GlobalIllumination.LinearColor UnityEngine.Experimental.GlobalIllumination.SpotLight::indirectColor
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	// System.Single UnityEngine.Experimental.GlobalIllumination.SpotLight::range
	float ___range_7;
	// System.Single UnityEngine.Experimental.GlobalIllumination.SpotLight::sphereRadius
	float ___sphereRadius_8;
	// System.Single UnityEngine.Experimental.GlobalIllumination.SpotLight::coneAngle
	float ___coneAngle_9;
	// System.Single UnityEngine.Experimental.GlobalIllumination.SpotLight::innerConeAngle
	float ___innerConeAngle_10;
	// UnityEngine.Experimental.GlobalIllumination.FalloffType UnityEngine.Experimental.GlobalIllumination.SpotLight::falloff
	uint8_t ___falloff_11;
	// UnityEngine.Experimental.GlobalIllumination.AngularFalloffType UnityEngine.Experimental.GlobalIllumination.SpotLight::angularFalloff
	uint8_t ___angularFalloff_12;

public:
	inline static int32_t get_offset_of_instanceID_0() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___instanceID_0)); }
	inline int32_t get_instanceID_0() const { return ___instanceID_0; }
	inline int32_t* get_address_of_instanceID_0() { return &___instanceID_0; }
	inline void set_instanceID_0(int32_t value)
	{
		___instanceID_0 = value;
	}

	inline static int32_t get_offset_of_shadow_1() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___shadow_1)); }
	inline bool get_shadow_1() const { return ___shadow_1; }
	inline bool* get_address_of_shadow_1() { return &___shadow_1; }
	inline void set_shadow_1(bool value)
	{
		___shadow_1 = value;
	}

	inline static int32_t get_offset_of_mode_2() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___mode_2)); }
	inline uint8_t get_mode_2() const { return ___mode_2; }
	inline uint8_t* get_address_of_mode_2() { return &___mode_2; }
	inline void set_mode_2(uint8_t value)
	{
		___mode_2 = value;
	}

	inline static int32_t get_offset_of_position_3() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___position_3)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_position_3() const { return ___position_3; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_position_3() { return &___position_3; }
	inline void set_position_3(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___position_3 = value;
	}

	inline static int32_t get_offset_of_orientation_4() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___orientation_4)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_orientation_4() const { return ___orientation_4; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_orientation_4() { return &___orientation_4; }
	inline void set_orientation_4(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___orientation_4 = value;
	}

	inline static int32_t get_offset_of_color_5() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___color_5)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_color_5() const { return ___color_5; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_color_5() { return &___color_5; }
	inline void set_color_5(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___color_5 = value;
	}

	inline static int32_t get_offset_of_indirectColor_6() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___indirectColor_6)); }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  get_indirectColor_6() const { return ___indirectColor_6; }
	inline LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2 * get_address_of_indirectColor_6() { return &___indirectColor_6; }
	inline void set_indirectColor_6(LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  value)
	{
		___indirectColor_6 = value;
	}

	inline static int32_t get_offset_of_range_7() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___range_7)); }
	inline float get_range_7() const { return ___range_7; }
	inline float* get_address_of_range_7() { return &___range_7; }
	inline void set_range_7(float value)
	{
		___range_7 = value;
	}

	inline static int32_t get_offset_of_sphereRadius_8() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___sphereRadius_8)); }
	inline float get_sphereRadius_8() const { return ___sphereRadius_8; }
	inline float* get_address_of_sphereRadius_8() { return &___sphereRadius_8; }
	inline void set_sphereRadius_8(float value)
	{
		___sphereRadius_8 = value;
	}

	inline static int32_t get_offset_of_coneAngle_9() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___coneAngle_9)); }
	inline float get_coneAngle_9() const { return ___coneAngle_9; }
	inline float* get_address_of_coneAngle_9() { return &___coneAngle_9; }
	inline void set_coneAngle_9(float value)
	{
		___coneAngle_9 = value;
	}

	inline static int32_t get_offset_of_innerConeAngle_10() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___innerConeAngle_10)); }
	inline float get_innerConeAngle_10() const { return ___innerConeAngle_10; }
	inline float* get_address_of_innerConeAngle_10() { return &___innerConeAngle_10; }
	inline void set_innerConeAngle_10(float value)
	{
		___innerConeAngle_10 = value;
	}

	inline static int32_t get_offset_of_falloff_11() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___falloff_11)); }
	inline uint8_t get_falloff_11() const { return ___falloff_11; }
	inline uint8_t* get_address_of_falloff_11() { return &___falloff_11; }
	inline void set_falloff_11(uint8_t value)
	{
		___falloff_11 = value;
	}

	inline static int32_t get_offset_of_angularFalloff_12() { return static_cast<int32_t>(offsetof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D, ___angularFalloff_12)); }
	inline uint8_t get_angularFalloff_12() const { return ___angularFalloff_12; }
	inline uint8_t* get_address_of_angularFalloff_12() { return &___angularFalloff_12; }
	inline void set_angularFalloff_12(uint8_t value)
	{
		___angularFalloff_12 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Experimental.GlobalIllumination.SpotLight
struct SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D_marshaled_pinvoke
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___range_7;
	float ___sphereRadius_8;
	float ___coneAngle_9;
	float ___innerConeAngle_10;
	uint8_t ___falloff_11;
	uint8_t ___angularFalloff_12;
};
// Native definition for COM marshalling of UnityEngine.Experimental.GlobalIllumination.SpotLight
struct SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D_marshaled_com
{
	int32_t ___instanceID_0;
	int32_t ___shadow_1;
	uint8_t ___mode_2;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_3;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___orientation_4;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___color_5;
	LinearColor_tB134EA090C61E6624DE36F52980CA7E2C893D5F2  ___indirectColor_6;
	float ___range_7;
	float ___sphereRadius_8;
	float ___coneAngle_9;
	float ___innerConeAngle_10;
	uint8_t ___falloff_11;
	uint8_t ___angularFalloff_12;
};

// System.SystemException
struct SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62  : public Exception_t
{
public:

public:
};


// UnityEngine.Texture
struct Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};

struct Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE_StaticFields
{
public:
	// System.Int32 UnityEngine.Texture::GenerateAllMips
	int32_t ___GenerateAllMips_4;

public:
	inline static int32_t get_offset_of_GenerateAllMips_4() { return static_cast<int32_t>(offsetof(Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE_StaticFields, ___GenerateAllMips_4)); }
	inline int32_t get_GenerateAllMips_4() const { return ___GenerateAllMips_4; }
	inline int32_t* get_address_of_GenerateAllMips_4() { return &___GenerateAllMips_4; }
	inline void set_GenerateAllMips_4(int32_t value)
	{
		___GenerateAllMips_4 = value;
	}
};


// UnityEngine.Rendering.VertexAttributeDescriptor
struct VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E 
{
public:
	// UnityEngine.Rendering.VertexAttribute UnityEngine.Rendering.VertexAttributeDescriptor::<attribute>k__BackingField
	int32_t ___U3CattributeU3Ek__BackingField_0;
	// UnityEngine.Rendering.VertexAttributeFormat UnityEngine.Rendering.VertexAttributeDescriptor::<format>k__BackingField
	int32_t ___U3CformatU3Ek__BackingField_1;
	// System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::<dimension>k__BackingField
	int32_t ___U3CdimensionU3Ek__BackingField_2;
	// System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::<stream>k__BackingField
	int32_t ___U3CstreamU3Ek__BackingField_3;

public:
	inline static int32_t get_offset_of_U3CattributeU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E, ___U3CattributeU3Ek__BackingField_0)); }
	inline int32_t get_U3CattributeU3Ek__BackingField_0() const { return ___U3CattributeU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3CattributeU3Ek__BackingField_0() { return &___U3CattributeU3Ek__BackingField_0; }
	inline void set_U3CattributeU3Ek__BackingField_0(int32_t value)
	{
		___U3CattributeU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_U3CformatU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E, ___U3CformatU3Ek__BackingField_1)); }
	inline int32_t get_U3CformatU3Ek__BackingField_1() const { return ___U3CformatU3Ek__BackingField_1; }
	inline int32_t* get_address_of_U3CformatU3Ek__BackingField_1() { return &___U3CformatU3Ek__BackingField_1; }
	inline void set_U3CformatU3Ek__BackingField_1(int32_t value)
	{
		___U3CformatU3Ek__BackingField_1 = value;
	}

	inline static int32_t get_offset_of_U3CdimensionU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E, ___U3CdimensionU3Ek__BackingField_2)); }
	inline int32_t get_U3CdimensionU3Ek__BackingField_2() const { return ___U3CdimensionU3Ek__BackingField_2; }
	inline int32_t* get_address_of_U3CdimensionU3Ek__BackingField_2() { return &___U3CdimensionU3Ek__BackingField_2; }
	inline void set_U3CdimensionU3Ek__BackingField_2(int32_t value)
	{
		___U3CdimensionU3Ek__BackingField_2 = value;
	}

	inline static int32_t get_offset_of_U3CstreamU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E, ___U3CstreamU3Ek__BackingField_3)); }
	inline int32_t get_U3CstreamU3Ek__BackingField_3() const { return ___U3CstreamU3Ek__BackingField_3; }
	inline int32_t* get_address_of_U3CstreamU3Ek__BackingField_3() { return &___U3CstreamU3Ek__BackingField_3; }
	inline void set_U3CstreamU3Ek__BackingField_3(int32_t value)
	{
		___U3CstreamU3Ek__BackingField_3 = value;
	}
};


// UnityEngine.Rendering.VisibleLight
struct VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B 
{
public:
	// UnityEngine.LightType UnityEngine.Rendering.VisibleLight::m_LightType
	int32_t ___m_LightType_0;
	// UnityEngine.Color UnityEngine.Rendering.VisibleLight::m_FinalColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_FinalColor_1;
	// UnityEngine.Rect UnityEngine.Rendering.VisibleLight::m_ScreenRect
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___m_ScreenRect_2;
	// UnityEngine.Matrix4x4 UnityEngine.Rendering.VisibleLight::m_LocalToWorldMatrix
	Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  ___m_LocalToWorldMatrix_3;
	// System.Single UnityEngine.Rendering.VisibleLight::m_Range
	float ___m_Range_4;
	// System.Single UnityEngine.Rendering.VisibleLight::m_SpotAngle
	float ___m_SpotAngle_5;
	// System.Int32 UnityEngine.Rendering.VisibleLight::m_InstanceId
	int32_t ___m_InstanceId_6;
	// UnityEngine.Rendering.VisibleLightFlags UnityEngine.Rendering.VisibleLight::m_Flags
	int32_t ___m_Flags_7;

public:
	inline static int32_t get_offset_of_m_LightType_0() { return static_cast<int32_t>(offsetof(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B, ___m_LightType_0)); }
	inline int32_t get_m_LightType_0() const { return ___m_LightType_0; }
	inline int32_t* get_address_of_m_LightType_0() { return &___m_LightType_0; }
	inline void set_m_LightType_0(int32_t value)
	{
		___m_LightType_0 = value;
	}

	inline static int32_t get_offset_of_m_FinalColor_1() { return static_cast<int32_t>(offsetof(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B, ___m_FinalColor_1)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_FinalColor_1() const { return ___m_FinalColor_1; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_FinalColor_1() { return &___m_FinalColor_1; }
	inline void set_m_FinalColor_1(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_FinalColor_1 = value;
	}

	inline static int32_t get_offset_of_m_ScreenRect_2() { return static_cast<int32_t>(offsetof(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B, ___m_ScreenRect_2)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_m_ScreenRect_2() const { return ___m_ScreenRect_2; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_m_ScreenRect_2() { return &___m_ScreenRect_2; }
	inline void set_m_ScreenRect_2(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___m_ScreenRect_2 = value;
	}

	inline static int32_t get_offset_of_m_LocalToWorldMatrix_3() { return static_cast<int32_t>(offsetof(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B, ___m_LocalToWorldMatrix_3)); }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  get_m_LocalToWorldMatrix_3() const { return ___m_LocalToWorldMatrix_3; }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * get_address_of_m_LocalToWorldMatrix_3() { return &___m_LocalToWorldMatrix_3; }
	inline void set_m_LocalToWorldMatrix_3(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  value)
	{
		___m_LocalToWorldMatrix_3 = value;
	}

	inline static int32_t get_offset_of_m_Range_4() { return static_cast<int32_t>(offsetof(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B, ___m_Range_4)); }
	inline float get_m_Range_4() const { return ___m_Range_4; }
	inline float* get_address_of_m_Range_4() { return &___m_Range_4; }
	inline void set_m_Range_4(float value)
	{
		___m_Range_4 = value;
	}

	inline static int32_t get_offset_of_m_SpotAngle_5() { return static_cast<int32_t>(offsetof(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B, ___m_SpotAngle_5)); }
	inline float get_m_SpotAngle_5() const { return ___m_SpotAngle_5; }
	inline float* get_address_of_m_SpotAngle_5() { return &___m_SpotAngle_5; }
	inline void set_m_SpotAngle_5(float value)
	{
		___m_SpotAngle_5 = value;
	}

	inline static int32_t get_offset_of_m_InstanceId_6() { return static_cast<int32_t>(offsetof(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B, ___m_InstanceId_6)); }
	inline int32_t get_m_InstanceId_6() const { return ___m_InstanceId_6; }
	inline int32_t* get_address_of_m_InstanceId_6() { return &___m_InstanceId_6; }
	inline void set_m_InstanceId_6(int32_t value)
	{
		___m_InstanceId_6 = value;
	}

	inline static int32_t get_offset_of_m_Flags_7() { return static_cast<int32_t>(offsetof(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B, ___m_Flags_7)); }
	inline int32_t get_m_Flags_7() const { return ___m_Flags_7; }
	inline int32_t* get_address_of_m_Flags_7() { return &___m_Flags_7; }
	inline void set_m_Flags_7(int32_t value)
	{
		___m_Flags_7 = value;
	}
};


// UnityEngine.Rendering.VisibleReflectionProbe
struct VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 
{
public:
	// UnityEngine.Bounds UnityEngine.Rendering.VisibleReflectionProbe::m_Bounds
	Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  ___m_Bounds_0;
	// UnityEngine.Matrix4x4 UnityEngine.Rendering.VisibleReflectionProbe::m_LocalToWorldMatrix
	Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  ___m_LocalToWorldMatrix_1;
	// UnityEngine.Vector4 UnityEngine.Rendering.VisibleReflectionProbe::m_HdrData
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___m_HdrData_2;
	// UnityEngine.Vector3 UnityEngine.Rendering.VisibleReflectionProbe::m_Center
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___m_Center_3;
	// System.Single UnityEngine.Rendering.VisibleReflectionProbe::m_BlendDistance
	float ___m_BlendDistance_4;
	// System.Int32 UnityEngine.Rendering.VisibleReflectionProbe::m_Importance
	int32_t ___m_Importance_5;
	// System.Int32 UnityEngine.Rendering.VisibleReflectionProbe::m_BoxProjection
	int32_t ___m_BoxProjection_6;
	// System.Int32 UnityEngine.Rendering.VisibleReflectionProbe::m_InstanceId
	int32_t ___m_InstanceId_7;
	// System.Int32 UnityEngine.Rendering.VisibleReflectionProbe::m_TextureId
	int32_t ___m_TextureId_8;

public:
	inline static int32_t get_offset_of_m_Bounds_0() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_Bounds_0)); }
	inline Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  get_m_Bounds_0() const { return ___m_Bounds_0; }
	inline Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * get_address_of_m_Bounds_0() { return &___m_Bounds_0; }
	inline void set_m_Bounds_0(Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  value)
	{
		___m_Bounds_0 = value;
	}

	inline static int32_t get_offset_of_m_LocalToWorldMatrix_1() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_LocalToWorldMatrix_1)); }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  get_m_LocalToWorldMatrix_1() const { return ___m_LocalToWorldMatrix_1; }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * get_address_of_m_LocalToWorldMatrix_1() { return &___m_LocalToWorldMatrix_1; }
	inline void set_m_LocalToWorldMatrix_1(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  value)
	{
		___m_LocalToWorldMatrix_1 = value;
	}

	inline static int32_t get_offset_of_m_HdrData_2() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_HdrData_2)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_m_HdrData_2() const { return ___m_HdrData_2; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_m_HdrData_2() { return &___m_HdrData_2; }
	inline void set_m_HdrData_2(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___m_HdrData_2 = value;
	}

	inline static int32_t get_offset_of_m_Center_3() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_Center_3)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_m_Center_3() const { return ___m_Center_3; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_m_Center_3() { return &___m_Center_3; }
	inline void set_m_Center_3(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___m_Center_3 = value;
	}

	inline static int32_t get_offset_of_m_BlendDistance_4() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_BlendDistance_4)); }
	inline float get_m_BlendDistance_4() const { return ___m_BlendDistance_4; }
	inline float* get_address_of_m_BlendDistance_4() { return &___m_BlendDistance_4; }
	inline void set_m_BlendDistance_4(float value)
	{
		___m_BlendDistance_4 = value;
	}

	inline static int32_t get_offset_of_m_Importance_5() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_Importance_5)); }
	inline int32_t get_m_Importance_5() const { return ___m_Importance_5; }
	inline int32_t* get_address_of_m_Importance_5() { return &___m_Importance_5; }
	inline void set_m_Importance_5(int32_t value)
	{
		___m_Importance_5 = value;
	}

	inline static int32_t get_offset_of_m_BoxProjection_6() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_BoxProjection_6)); }
	inline int32_t get_m_BoxProjection_6() const { return ___m_BoxProjection_6; }
	inline int32_t* get_address_of_m_BoxProjection_6() { return &___m_BoxProjection_6; }
	inline void set_m_BoxProjection_6(int32_t value)
	{
		___m_BoxProjection_6 = value;
	}

	inline static int32_t get_offset_of_m_InstanceId_7() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_InstanceId_7)); }
	inline int32_t get_m_InstanceId_7() const { return ___m_InstanceId_7; }
	inline int32_t* get_address_of_m_InstanceId_7() { return &___m_InstanceId_7; }
	inline void set_m_InstanceId_7(int32_t value)
	{
		___m_InstanceId_7 = value;
	}

	inline static int32_t get_offset_of_m_TextureId_8() { return static_cast<int32_t>(offsetof(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51, ___m_TextureId_8)); }
	inline int32_t get_m_TextureId_8() const { return ___m_TextureId_8; }
	inline int32_t* get_address_of_m_TextureId_8() { return &___m_TextureId_8; }
	inline void set_m_TextureId_8(int32_t value)
	{
		___m_TextureId_8 = value;
	}
};


// UnityEngine.Camera/GateFitParameters
struct GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D 
{
public:
	// UnityEngine.Camera/GateFitMode UnityEngine.Camera/GateFitParameters::<mode>k__BackingField
	int32_t ___U3CmodeU3Ek__BackingField_0;
	// System.Single UnityEngine.Camera/GateFitParameters::<aspect>k__BackingField
	float ___U3CaspectU3Ek__BackingField_1;

public:
	inline static int32_t get_offset_of_U3CmodeU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D, ___U3CmodeU3Ek__BackingField_0)); }
	inline int32_t get_U3CmodeU3Ek__BackingField_0() const { return ___U3CmodeU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3CmodeU3Ek__BackingField_0() { return &___U3CmodeU3Ek__BackingField_0; }
	inline void set_U3CmodeU3Ek__BackingField_0(int32_t value)
	{
		___U3CmodeU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_U3CaspectU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D, ___U3CaspectU3Ek__BackingField_1)); }
	inline float get_U3CaspectU3Ek__BackingField_1() const { return ___U3CaspectU3Ek__BackingField_1; }
	inline float* get_address_of_U3CaspectU3Ek__BackingField_1() { return &___U3CaspectU3Ek__BackingField_1; }
	inline void set_U3CaspectU3Ek__BackingField_1(float value)
	{
		___U3CaspectU3Ek__BackingField_1 = value;
	}
};


// UnityEngine.Camera/RenderRequest
struct RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94 
{
public:
	// UnityEngine.Camera/RenderRequestMode UnityEngine.Camera/RenderRequest::m_CameraRenderMode
	int32_t ___m_CameraRenderMode_0;
	// UnityEngine.RenderTexture UnityEngine.Camera/RenderRequest::m_ResultRT
	RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * ___m_ResultRT_1;
	// UnityEngine.Camera/RenderRequestOutputSpace UnityEngine.Camera/RenderRequest::m_OutputSpace
	int32_t ___m_OutputSpace_2;

public:
	inline static int32_t get_offset_of_m_CameraRenderMode_0() { return static_cast<int32_t>(offsetof(RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94, ___m_CameraRenderMode_0)); }
	inline int32_t get_m_CameraRenderMode_0() const { return ___m_CameraRenderMode_0; }
	inline int32_t* get_address_of_m_CameraRenderMode_0() { return &___m_CameraRenderMode_0; }
	inline void set_m_CameraRenderMode_0(int32_t value)
	{
		___m_CameraRenderMode_0 = value;
	}

	inline static int32_t get_offset_of_m_ResultRT_1() { return static_cast<int32_t>(offsetof(RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94, ___m_ResultRT_1)); }
	inline RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * get_m_ResultRT_1() const { return ___m_ResultRT_1; }
	inline RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 ** get_address_of_m_ResultRT_1() { return &___m_ResultRT_1; }
	inline void set_m_ResultRT_1(RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * value)
	{
		___m_ResultRT_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ResultRT_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_OutputSpace_2() { return static_cast<int32_t>(offsetof(RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94, ___m_OutputSpace_2)); }
	inline int32_t get_m_OutputSpace_2() const { return ___m_OutputSpace_2; }
	inline int32_t* get_address_of_m_OutputSpace_2() { return &___m_OutputSpace_2; }
	inline void set_m_OutputSpace_2(int32_t value)
	{
		___m_OutputSpace_2 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Camera/RenderRequest
struct RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshaled_pinvoke
{
	int32_t ___m_CameraRenderMode_0;
	RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * ___m_ResultRT_1;
	int32_t ___m_OutputSpace_2;
};
// Native definition for COM marshalling of UnityEngine.Camera/RenderRequest
struct RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshaled_com
{
	int32_t ___m_CameraRenderMode_0;
	RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * ___m_ResultRT_1;
	int32_t ___m_OutputSpace_2;
};

// Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters
struct JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8 
{
public:
	// Unity.Jobs.JobHandle Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters::Dependency
	JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  ___Dependency_0;
	// System.Int32 Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters::ScheduleMode
	int32_t ___ScheduleMode_1;
	// System.IntPtr Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters::ReflectionData
	intptr_t ___ReflectionData_2;
	// System.IntPtr Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters::JobDataPtr
	intptr_t ___JobDataPtr_3;

public:
	inline static int32_t get_offset_of_Dependency_0() { return static_cast<int32_t>(offsetof(JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8, ___Dependency_0)); }
	inline JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  get_Dependency_0() const { return ___Dependency_0; }
	inline JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 * get_address_of_Dependency_0() { return &___Dependency_0; }
	inline void set_Dependency_0(JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  value)
	{
		___Dependency_0 = value;
	}

	inline static int32_t get_offset_of_ScheduleMode_1() { return static_cast<int32_t>(offsetof(JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8, ___ScheduleMode_1)); }
	inline int32_t get_ScheduleMode_1() const { return ___ScheduleMode_1; }
	inline int32_t* get_address_of_ScheduleMode_1() { return &___ScheduleMode_1; }
	inline void set_ScheduleMode_1(int32_t value)
	{
		___ScheduleMode_1 = value;
	}

	inline static int32_t get_offset_of_ReflectionData_2() { return static_cast<int32_t>(offsetof(JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8, ___ReflectionData_2)); }
	inline intptr_t get_ReflectionData_2() const { return ___ReflectionData_2; }
	inline intptr_t* get_address_of_ReflectionData_2() { return &___ReflectionData_2; }
	inline void set_ReflectionData_2(intptr_t value)
	{
		___ReflectionData_2 = value;
	}

	inline static int32_t get_offset_of_JobDataPtr_3() { return static_cast<int32_t>(offsetof(JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8, ___JobDataPtr_3)); }
	inline intptr_t get_JobDataPtr_3() const { return ___JobDataPtr_3; }
	inline intptr_t* get_address_of_JobDataPtr_3() { return &___JobDataPtr_3; }
	inline void set_JobDataPtr_3(intptr_t value)
	{
		___JobDataPtr_3 = value;
	}
};


// System.ArgumentException
struct ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:
	// System.String System.ArgumentException::m_paramName
	String_t* ___m_paramName_17;

public:
	inline static int32_t get_offset_of_m_paramName_17() { return static_cast<int32_t>(offsetof(ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00, ___m_paramName_17)); }
	inline String_t* get_m_paramName_17() const { return ___m_paramName_17; }
	inline String_t** get_address_of_m_paramName_17() { return &___m_paramName_17; }
	inline void set_m_paramName_17(String_t* value)
	{
		___m_paramName_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_paramName_17), (void*)value);
	}
};


// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Rendering.BatchCullingContext
struct BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66 
{
public:
	// Unity.Collections.NativeArray`1<UnityEngine.Plane> UnityEngine.Rendering.BatchCullingContext::cullingPlanes
	NativeArray_1_t527C586787ACD1AD75E3C78BFB024FFA9925662E  ___cullingPlanes_0;
	// Unity.Collections.NativeArray`1<UnityEngine.Rendering.BatchVisibility> UnityEngine.Rendering.BatchCullingContext::batchVisibility
	NativeArray_1_t18D233A2E30E28048C1252473AFD0799557294DA  ___batchVisibility_1;
	// Unity.Collections.NativeArray`1<System.Int32> UnityEngine.Rendering.BatchCullingContext::visibleIndices
	NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99  ___visibleIndices_2;
	// Unity.Collections.NativeArray`1<System.Int32> UnityEngine.Rendering.BatchCullingContext::visibleIndicesY
	NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99  ___visibleIndicesY_3;
	// UnityEngine.Rendering.LODParameters UnityEngine.Rendering.BatchCullingContext::lodParameters
	LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD  ___lodParameters_4;
	// UnityEngine.Matrix4x4 UnityEngine.Rendering.BatchCullingContext::cullingMatrix
	Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  ___cullingMatrix_5;
	// System.Single UnityEngine.Rendering.BatchCullingContext::nearPlane
	float ___nearPlane_6;

public:
	inline static int32_t get_offset_of_cullingPlanes_0() { return static_cast<int32_t>(offsetof(BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66, ___cullingPlanes_0)); }
	inline NativeArray_1_t527C586787ACD1AD75E3C78BFB024FFA9925662E  get_cullingPlanes_0() const { return ___cullingPlanes_0; }
	inline NativeArray_1_t527C586787ACD1AD75E3C78BFB024FFA9925662E * get_address_of_cullingPlanes_0() { return &___cullingPlanes_0; }
	inline void set_cullingPlanes_0(NativeArray_1_t527C586787ACD1AD75E3C78BFB024FFA9925662E  value)
	{
		___cullingPlanes_0 = value;
	}

	inline static int32_t get_offset_of_batchVisibility_1() { return static_cast<int32_t>(offsetof(BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66, ___batchVisibility_1)); }
	inline NativeArray_1_t18D233A2E30E28048C1252473AFD0799557294DA  get_batchVisibility_1() const { return ___batchVisibility_1; }
	inline NativeArray_1_t18D233A2E30E28048C1252473AFD0799557294DA * get_address_of_batchVisibility_1() { return &___batchVisibility_1; }
	inline void set_batchVisibility_1(NativeArray_1_t18D233A2E30E28048C1252473AFD0799557294DA  value)
	{
		___batchVisibility_1 = value;
	}

	inline static int32_t get_offset_of_visibleIndices_2() { return static_cast<int32_t>(offsetof(BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66, ___visibleIndices_2)); }
	inline NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99  get_visibleIndices_2() const { return ___visibleIndices_2; }
	inline NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99 * get_address_of_visibleIndices_2() { return &___visibleIndices_2; }
	inline void set_visibleIndices_2(NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99  value)
	{
		___visibleIndices_2 = value;
	}

	inline static int32_t get_offset_of_visibleIndicesY_3() { return static_cast<int32_t>(offsetof(BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66, ___visibleIndicesY_3)); }
	inline NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99  get_visibleIndicesY_3() const { return ___visibleIndicesY_3; }
	inline NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99 * get_address_of_visibleIndicesY_3() { return &___visibleIndicesY_3; }
	inline void set_visibleIndicesY_3(NativeArray_1_tD60079F06B473C85CF6C2BB4F2D203F38191AE99  value)
	{
		___visibleIndicesY_3 = value;
	}

	inline static int32_t get_offset_of_lodParameters_4() { return static_cast<int32_t>(offsetof(BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66, ___lodParameters_4)); }
	inline LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD  get_lodParameters_4() const { return ___lodParameters_4; }
	inline LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD * get_address_of_lodParameters_4() { return &___lodParameters_4; }
	inline void set_lodParameters_4(LODParameters_tA41D06C4BDB03138144BE9DCC4BC6B37963DC5CD  value)
	{
		___lodParameters_4 = value;
	}

	inline static int32_t get_offset_of_cullingMatrix_5() { return static_cast<int32_t>(offsetof(BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66, ___cullingMatrix_5)); }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  get_cullingMatrix_5() const { return ___cullingMatrix_5; }
	inline Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * get_address_of_cullingMatrix_5() { return &___cullingMatrix_5; }
	inline void set_cullingMatrix_5(Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  value)
	{
		___cullingMatrix_5 = value;
	}

	inline static int32_t get_offset_of_nearPlane_6() { return static_cast<int32_t>(offsetof(BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66, ___nearPlane_6)); }
	inline float get_nearPlane_6() const { return ___nearPlane_6; }
	inline float* get_address_of_nearPlane_6() { return &___nearPlane_6; }
	inline void set_nearPlane_6(float value)
	{
		___nearPlane_6 = value;
	}
};


// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// System.IndexOutOfRangeException
struct IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// System.InvalidOperationException
struct InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// System.Threading.ManualResetEvent
struct ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA  : public EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C
{
public:

public:
};


// UnityEngine.RenderTexture
struct RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849  : public Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE
{
public:

public:
};


// System.Threading.SendOrPostCallback
struct SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// UnityEngine.Events.UnityAction
struct UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Application/AdvertisingIdentifierCallback
struct AdvertisingIdentifierCallback_t718F15DCE2CA38B886F324F079A4B41774A3042B  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Application/LogCallback
struct LogCallback_t8C3C9B1E0F185E2A25D09DE10DD8414898698BBD  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Application/LowMemoryCallback
struct LowMemoryCallback_tF94AC614EDACA9AD4CEA3DE77FF8EFF5DA1E5240  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Camera/CameraCallback
struct CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.CullingGroup/StateChanged
struct StateChanged_tAE96F0A8860BFCD704179F6C1F376A6FAE3E25E0  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Display/DisplaysUpdatedDelegate
struct DisplaysUpdatedDelegate_tC6A6AD44FAD98C9E28479FFF4BD3D9932458A6A1  : public MulticastDelegate_t
{
public:

public:
};


// Unity.Jobs.LowLevel.Unsafe.JobsUtility/PanicFunction_
struct PanicFunction__tFB4D850E5B848FFEF210623F5669284D723544EB  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Experimental.GlobalIllumination.Lightmapping/RequestLightsDelegate
struct RequestLightsDelegate_t48C36AFA6015405AE4069BB1F3623AF3BC51FDA0  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Playables.PlayableBinding/CreateOutputMethod
struct CreateOutputMethod_t7A129D00E8823B50AEDD0C9B082C9CB3DF863876  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.LowLevel.PlayerLoopSystem/UpdateFunction
struct UpdateFunction_tEDC2A88F61F179480CAA9443E6ADDA3F126B8AEA  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.RectTransform/ReapplyDrivenProperties
struct ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE  : public MulticastDelegate_t
{
public:

public:
};


// System.ArgumentNullException
struct ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB  : public ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00
{
public:

public:
};


// UnityEngine.Camera
struct Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};

struct Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C_StaticFields
{
public:
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreCull
	CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * ___onPreCull_4;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreRender
	CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * ___onPreRender_5;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPostRender
	CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * ___onPostRender_6;

public:
	inline static int32_t get_offset_of_onPreCull_4() { return static_cast<int32_t>(offsetof(Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C_StaticFields, ___onPreCull_4)); }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * get_onPreCull_4() const { return ___onPreCull_4; }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D ** get_address_of_onPreCull_4() { return &___onPreCull_4; }
	inline void set_onPreCull_4(CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * value)
	{
		___onPreCull_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPreCull_4), (void*)value);
	}

	inline static int32_t get_offset_of_onPreRender_5() { return static_cast<int32_t>(offsetof(Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C_StaticFields, ___onPreRender_5)); }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * get_onPreRender_5() const { return ___onPreRender_5; }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D ** get_address_of_onPreRender_5() { return &___onPreRender_5; }
	inline void set_onPreRender_5(CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * value)
	{
		___onPreRender_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPreRender_5), (void*)value);
	}

	inline static int32_t get_offset_of_onPostRender_6() { return static_cast<int32_t>(offsetof(Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C_StaticFields, ___onPostRender_6)); }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * get_onPostRender_6() const { return ___onPostRender_6; }
	inline CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D ** get_address_of_onPostRender_6() { return &___onPostRender_6; }
	inline void set_onPostRender_6(CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * value)
	{
		___onPostRender_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onPostRender_6), (void*)value);
	}
};


// UnityEngine.Light
struct Light_tA2F349FE839781469A0344CF6039B51512394275  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:
	// System.Int32 UnityEngine.Light::m_BakedIndex
	int32_t ___m_BakedIndex_4;

public:
	inline static int32_t get_offset_of_m_BakedIndex_4() { return static_cast<int32_t>(offsetof(Light_tA2F349FE839781469A0344CF6039B51512394275, ___m_BakedIndex_4)); }
	inline int32_t get_m_BakedIndex_4() const { return ___m_BakedIndex_4; }
	inline int32_t* get_address_of_m_BakedIndex_4() { return &___m_BakedIndex_4; }
	inline void set_m_BakedIndex_4(int32_t value)
	{
		___m_BakedIndex_4 = value;
	}
};


// UnityEngine.RectTransform
struct RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072  : public Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1
{
public:

public:
};

struct RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072_StaticFields
{
public:
	// UnityEngine.RectTransform/ReapplyDrivenProperties UnityEngine.RectTransform::reapplyDrivenProperties
	ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE * ___reapplyDrivenProperties_4;

public:
	inline static int32_t get_offset_of_reapplyDrivenProperties_4() { return static_cast<int32_t>(offsetof(RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072_StaticFields, ___reapplyDrivenProperties_4)); }
	inline ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE * get_reapplyDrivenProperties_4() const { return ___reapplyDrivenProperties_4; }
	inline ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE ** get_address_of_reapplyDrivenProperties_4() { return &___reapplyDrivenProperties_4; }
	inline void set_reapplyDrivenProperties_4(ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE * value)
	{
		___reapplyDrivenProperties_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___reapplyDrivenProperties_4), (void*)value);
	}
};


// UnityEngine.Rendering.BatchRendererGroup/OnPerformCulling
struct OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) RuntimeObject * m_Items[1];

public:
	inline RuntimeObject * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Delegate_t * m_Items[1];

public:
	inline Delegate_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Light[]
struct LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Light_tA2F349FE839781469A0344CF6039B51512394275 * m_Items[1];

public:
	inline Light_tA2F349FE839781469A0344CF6039B51512394275 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Light_tA2F349FE839781469A0344CF6039B51512394275 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Light_tA2F349FE839781469A0344CF6039B51512394275 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Light_tA2F349FE839781469A0344CF6039B51512394275 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Light_tA2F349FE839781469A0344CF6039B51512394275 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Light_tA2F349FE839781469A0344CF6039B51512394275 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Mesh[]
struct MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * m_Items[1];

public:
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Collections.Generic.KeyValuePair`2<System.Byte[],System.Text.Encoding>[]
struct KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  m_Items[1];

public:
	inline KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B * GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___key_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___value_1), (void*)NULL);
		#endif
	}
	inline KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B * GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___key_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___value_1), (void*)NULL);
		#endif
	}
};
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) uint8_t m_Items[1];

public:
	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};


// System.Int32 Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SizeOf<System.IntPtr>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_gshared (const RuntimeMethod* method);
// System.Int32 Unity.Collections.LowLevel.Unsafe.UnsafeUtility::AlignOf<System.IntPtr>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_gshared (const RuntimeMethod* method);
// System.Void UnityEngine.Events.UnityEvent`1<System.Int32>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityEvent_1__ctor_m30F443398054B5E3666B3C86E64A5C0FF97D93FF_gshared (UnityEvent_1_tB235B5DAD099AC425DC059D10DEB8B97A35E2BBF * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Events.UnityEvent`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityEvent_1__ctor_mD87552C18A41196B69A62A366C8238FC246B151A_gshared (UnityEvent_1_t32063FE815890FF672DF76288FAC4ABE089B899F * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>::.ctor(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyValuePair_2__ctor_m74B9EB9E16A0CC0F80B0AB74B8E1E91C16E6998E_gshared (KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625 * __this, RuntimeObject * ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);

// System.Void System.IndexOutOfRangeException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IndexOutOfRangeException__ctor_mC5747EC0E0F49AAD1AD782ACC7A0CCD80D192FEF (IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Single UnityEngine.Vector4::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector4_get_Item_m469B9D88498D0F7CD14B71A9512915BAA0B9B3B7 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Void UnityEngine.Vector4::set_Item(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector4_set_Item_m7552B288FF218CA023F0DFB971BBA30D0362006A (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, float ___x0, float ___y1, float ___z2, float ___w3, const RuntimeMethod* method);
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector4__ctor_m7F4644B9C896ADDF4A3033DA36EF9D873A678E5F (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, float ___x0, float ___y1, const RuntimeMethod* method);
// System.Int32 System.Single::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Single_GetHashCode_m7662E1812DDDBC85D464398740CFFC3588DFB2C9 (float* __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Vector4::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Vector4_GetHashCode_mCA7B312F8CA141F6F25BABDDF406F3D2BDD5E895 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Vector4::Equals(UnityEngine.Vector4)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector4_Equals_m0919D35807550372D1748193EB31E4C5E406AE61_inline (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Vector4::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Vector4_Equals_m71D14F39651C3FBEDE17214455DFA727921F07AA (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, RuntimeObject * ___other0, const RuntimeMethod* method);
// System.Single UnityEngine.Vector4::Dot(UnityEngine.Vector4,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector4_Dot_m3373C73B23A0BC07DDE8B9C99AA2FC933CD1143F (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___a0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___b1, const RuntimeMethod* method);
// System.Single UnityEngine.Vector4::get_magnitude()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector4_get_magnitude_mAEC3DB52FD5DEFB39CA058BAF64A0C487B9CDD10 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Vector4::get_sqrMagnitude()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector4_get_sqrMagnitude_m1450744F6AAD57773CE0208B6F51DDEEE9A48E07 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Vector4::op_Equality(UnityEngine.Vector4,UnityEngine.Vector4)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector4_op_Equality_mAC86329F5E0AF56A4A1067AB4299C291221720AE_inline (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___lhs0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___rhs1, const RuntimeMethod* method);
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method);
// System.Globalization.CultureInfo System.Globalization.CultureInfo::get_InvariantCulture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164 (const RuntimeMethod* method);
// System.String UnityEngine.Vector4::ToString(System.String,System.IFormatProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Vector4_ToString_m0EC6AA83CD606E3EB5BE60108A1D9AC4ECB5517A (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, String_t* ___format0, RuntimeObject* ___formatProvider1, const RuntimeMethod* method);
// System.String UnityEngine.Vector4::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Vector4_ToString_mF2D17142EBD75E91BC718B3E347F614AC45E9040 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, const RuntimeMethod* method);
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C (String_t* ___value0, const RuntimeMethod* method);
// System.String System.Single::ToString(System.String,System.IFormatProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Single_ToString_m7631D332703B4197EAA7DC0BA067CE7E16334D8B (float* __this, String_t* ___format0, RuntimeObject* ___provider1, const RuntimeMethod* method);
// System.String UnityEngine.UnityString::Format(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityString_Format_m7A07C068ED408DD06F634070770FB55F13AA4EC9 (String_t* ___fmt0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method);
// UnityEngine.Rendering.VertexAttribute UnityEngine.Rendering.VertexAttributeDescriptor::get_attribute()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::set_attribute(UnityEngine.Rendering.VertexAttribute)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_attribute_mBF99A4AE23B0677C1922EA461FB8B36B021C68B6_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method);
// UnityEngine.Rendering.VertexAttributeFormat UnityEngine.Rendering.VertexAttributeDescriptor::get_format()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::set_format(UnityEngine.Rendering.VertexAttributeFormat)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_format_m530E47091524EF538721994F3A0A066285B72251_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::get_dimension()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::set_dimension(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_dimension_m8E0A210A2662617D2AB601C6DC0D996A08563787_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::get_stream()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::set_stream(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_stream_m39EC0B3F25D7CCF8F389C2CCF6390DA8E8651BEE_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::.ctor(UnityEngine.Rendering.VertexAttribute,UnityEngine.Rendering.VertexAttributeFormat,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VertexAttributeDescriptor__ctor_m98183669DC960D7BEFBEF0E216FF9A4BE1941FE9 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___attribute0, int32_t ___format1, int32_t ___dimension2, int32_t ___stream3, const RuntimeMethod* method);
// System.String System.String::Format(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B (String_t* ___format0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method);
// System.String UnityEngine.Rendering.VertexAttributeDescriptor::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* VertexAttributeDescriptor_ToString_m573FD18B681482B56A12328C9D7D2DA171391B6D (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_GetHashCode_m6928CD591C6E2506839A6B252BEF738EFF05BAB9 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rendering.VertexAttributeDescriptor::Equals(UnityEngine.Rendering.VertexAttributeDescriptor)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VertexAttributeDescriptor_Equals_mED68AA9CEBA42E83A17AAB1CB177D6A96C00EEF9 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rendering.VertexAttributeDescriptor::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VertexAttributeDescriptor_Equals_mF5DF2302FF50A66408E015DB0AA51C743D239C00 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, RuntimeObject * ___other0, const RuntimeMethod* method);
// UnityEngine.Object UnityEngine.Object::FindObjectFromInstanceID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * Object_FindObjectFromInstanceID_m0AD731D3F583CBBDC7DC0E08B38F742B447FA44A (int32_t ___instanceID0, const RuntimeMethod* method);
// UnityEngine.Light UnityEngine.Rendering.VisibleLight::get_light()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Light_tA2F349FE839781469A0344CF6039B51512394275 * VisibleLight_get_light_mB3719D47BF6F69C2DE42B532388A1614163850D7 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method);
// UnityEngine.LightType UnityEngine.Rendering.VisibleLight::get_lightType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VisibleLight_get_lightType_m7D69884E96A92F41619FCE4E419593C9FE28A6C9 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.Rendering.VisibleLight::get_finalColor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  VisibleLight_get_finalColor_m58FCC6FC876E90AF728669588D220B23F72D8F81 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method);
// UnityEngine.Matrix4x4 UnityEngine.Rendering.VisibleLight::get_localToWorldMatrix()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  VisibleLight_get_localToWorldMatrix_m8A49A19AA3E7DE6782FAEF618D4BCE5DAAE26636 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Rendering.VisibleLight::get_range()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float VisibleLight_get_range_mDEEB57B3AF09E27E2B70852C3F263BED748962F4 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Rendering.VisibleLight::get_spotAngle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float VisibleLight_get_spotAngle_m5B090DAE3C02F6CA75F5FE4B807DAD408FD652F4 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Color::Equals(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Color_Equals_mB531F532B5F7BE6168CFD4A6C89358C16F058D00 (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * __this, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rect::Equals(UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Rect_Equals_mC9EE5E0C234DB174AC16E653ED8D32BB4D356BB8 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Matrix4x4::Equals(UnityEngine.Matrix4x4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Matrix4x4_Equals_mAE7AC284A922B094E4ACCC04A1C48B247E9A7997 (Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * __this, Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  ___other0, const RuntimeMethod* method);
// System.Boolean System.Single::Equals(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Single_Equals_m298A3A849F30B9900813BE6DD98AE6810CDBE914 (float* __this, float ___obj0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rendering.VisibleLight::Equals(UnityEngine.Rendering.VisibleLight)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VisibleLight_Equals_mFA9ADFF9549B6E1582730CE2A980CDC0AB53B5CF (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rendering.VisibleLight::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VisibleLight_Equals_m31A93583009988A9E375AF5F30584EA2384A6792 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Color::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Color_GetHashCode_mAF5E7EE6AFA983D3FA5E3D316E672EE1511F97CF (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Rect::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Rect_GetHashCode_mE5841C54528B29D5E85173AF1973326793AF9311 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Matrix4x4::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Matrix4x4_GetHashCode_m102B903082CD1C786C221268A19679820E365B59 (Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Rendering.VisibleLight::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VisibleLight_GetHashCode_mB02BF000082BA2DB2E7034052814FC078ABBCA79 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Bounds::Equals(UnityEngine.Bounds)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Bounds_Equals_mC558BE6FE3614F7B42F5E22D1F155194A0E3DD0F (Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Vector3::Equals(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Vector3_Equals_mA92800CD98ED6A42DD7C55C5DB22DAB4DEAA6397 (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rendering.VisibleReflectionProbe::Equals(UnityEngine.Rendering.VisibleReflectionProbe)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VisibleReflectionProbe_Equals_m08619B5CE171C4CAB0DDC2E71D621D017675CA43 (VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * __this, VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rendering.VisibleReflectionProbe::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VisibleReflectionProbe_Equals_m41A430F408D799CCB4C2762658C36C5EBEFF6BE7 (VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * __this, RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Bounds::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Bounds_GetHashCode_m822D1DF4F57180495A4322AADD3FD173C6FC3A1B (Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Vector3::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Vector3_GetHashCode_m9F18401DA6025110A012F55BBB5ACABD36FA9A0A (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Rendering.VisibleReflectionProbe::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VisibleReflectionProbe_GetHashCode_m0C0B7C72A3CCDE769DF19DE1F4847A6B97CADF4E (VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.YieldInstruction::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void YieldInstruction__ctor_mD8203310B47F2C36BED3EEC00CA1944C9D941AEF (YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_realtimeSinceStartup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B (const RuntimeMethod* method);
// System.Single UnityEngine.WaitForSecondsRealtime::get_waitTime()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float WaitForSecondsRealtime_get_waitTime_m04ED4EACCB01E49DEC7E0E5A83789068A3525BC2_inline (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.CustomYieldInstruction::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CustomYieldInstruction__ctor_m01929E3EEB78B751510038B32D889061960DA1BE (CustomYieldInstruction_t4ED1543FBAA3143362854EB1867B42E5D190A5C7 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.WaitForSecondsRealtime::set_waitTime(System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void WaitForSecondsRealtime_set_waitTime_m241120AEE2F1BDD0DC3077D865C7C3D878448268_inline (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, float ___value0, const RuntimeMethod* method);
// System.Void System.Attribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Attribute__ctor_m5C1862A7DFC2C25A4797A8C5F681FBB5CB53ECE1 (Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71 * __this, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// UnityEngine.Camera/GateFitMode UnityEngine.Camera/GateFitParameters::get_mode()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t GateFitParameters_get_mode_m77B9128212158F79B56A96B464863CF425DAD42E_inline (GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Camera/GateFitParameters::get_aspect()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float GateFitParameters_get_aspect_m58C24572B24DA38AE4973691C26C0822A0D5C58A_inline (GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D * __this, const RuntimeMethod* method);
// System.IntPtr System.IntPtr::op_Explicit(System.Void*)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t IntPtr_op_Explicit_mBD40223EE90BDDF40A24C0F321D3398DEA300495 (void* ___value0, const RuntimeMethod* method);
// System.Void Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters::.ctor(System.Void*,System.IntPtr,Unity.Jobs.JobHandle,Unity.Jobs.LowLevel.Unsafe.ScheduleMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JobScheduleParameters__ctor_m7BAC662AF5FA4A96429644CC676D3179A5B143F8 (JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8 * __this, void* ___i_jobData0, intptr_t ___i_reflectionData1, JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  ___i_dependency2, int32_t ___i_scheduleMode3, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.Lightmapping/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m8F825BEC75A119B6CDDA0985A3F7BA3DEA8AD5B2 (U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 * __this, const RuntimeMethod* method);
// UnityEngine.LightType UnityEngine.Light::get_type()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Light_get_type_mDBBEC33D93952330EED5B02B15865C59D5C355A0 (Light_tA2F349FE839781469A0344CF6039B51512394275 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightmapperUtils::Extract(UnityEngine.Light,UnityEngine.Experimental.GlobalIllumination.DirectionalLight&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightmapperUtils_Extract_mCBEC26CC920C0D87DF6E25417533923E26CB6DFC (Light_tA2F349FE839781469A0344CF6039B51512394275 * ___l0, DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7 * ___dir1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightmapperUtils::Extract(UnityEngine.Light,UnityEngine.Experimental.GlobalIllumination.Cookie&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightmapperUtils_Extract_mACAC5E823E243A53EDD2A01CF857DD16C3FDBE2A (Light_tA2F349FE839781469A0344CF6039B51512394275 * ___l0, Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B * ___cookie1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightDataGI::Init(UnityEngine.Experimental.GlobalIllumination.DirectionalLight&,UnityEngine.Experimental.GlobalIllumination.Cookie&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightDataGI_Init_m135DF5CF6CBECA4CBA0AC71F9CDEEF8DE25606DB (LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 * __this, DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7 * ___light0, Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B * ___cookie1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightmapperUtils::Extract(UnityEngine.Light,UnityEngine.Experimental.GlobalIllumination.PointLight&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightmapperUtils_Extract_mB11D8F3B35F96E176A89517A25CD1A54DCBD7D6E (Light_tA2F349FE839781469A0344CF6039B51512394275 * ___l0, PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E * ___point1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightDataGI::Init(UnityEngine.Experimental.GlobalIllumination.PointLight&,UnityEngine.Experimental.GlobalIllumination.Cookie&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightDataGI_Init_m4E8BEBD383D5F6F1A1EDFEC763A718A7271C22A6 (LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 * __this, PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E * ___light0, Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B * ___cookie1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightmapperUtils::Extract(UnityEngine.Light,UnityEngine.Experimental.GlobalIllumination.SpotLight&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightmapperUtils_Extract_mB1572C38F682F043180745B7A231FBE07CD205E4 (Light_tA2F349FE839781469A0344CF6039B51512394275 * ___l0, SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D * ___spot1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightDataGI::Init(UnityEngine.Experimental.GlobalIllumination.SpotLight&,UnityEngine.Experimental.GlobalIllumination.Cookie&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightDataGI_Init_mC9948FAC4A191C99E3E7D94677B7CFD241857C86 (LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 * __this, SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D * ___light0, Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B * ___cookie1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightmapperUtils::Extract(UnityEngine.Light,UnityEngine.Experimental.GlobalIllumination.RectangleLight&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightmapperUtils_Extract_mEABF77895D51E1CA5FD380682539C3DD3FC8A91C (Light_tA2F349FE839781469A0344CF6039B51512394275 * ___l0, RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985 * ___rect1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightDataGI::Init(UnityEngine.Experimental.GlobalIllumination.RectangleLight&,UnityEngine.Experimental.GlobalIllumination.Cookie&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightDataGI_Init_mA0DF9747C6AD308EAAF2A9530B4225A3D65BB092 (LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 * __this, RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985 * ___light0, Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B * ___cookie1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightmapperUtils::Extract(UnityEngine.Light,UnityEngine.Experimental.GlobalIllumination.DiscLight&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightmapperUtils_Extract_m93B350DDA0CB5B624054835BAF46C177472E9212 (Light_tA2F349FE839781469A0344CF6039B51512394275 * ___l0, DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D * ___disc1, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightDataGI::Init(UnityEngine.Experimental.GlobalIllumination.DiscLight&,UnityEngine.Experimental.GlobalIllumination.Cookie&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightDataGI_Init_mB96C3F3E00F10DD0806BD3DB93B58C2299D59E94 (LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 * __this, DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D * ___light0, Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B * ___cookie1, const RuntimeMethod* method);
// System.Int32 UnityEngine.Object::GetInstanceID()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Object_GetInstanceID_m7CF962BC1DB5C03F3522F88728CB2F514582B501 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Experimental.GlobalIllumination.LightDataGI::InitNoBake(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LightDataGI_InitNoBake_mF600D612DE9A1CE4355C61317F6173E1AAEFBD57 (LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 * __this, int32_t ___lightInstanceID0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Mesh/MeshDataArray::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t MeshDataArray_get_Length_mF10B3C18CF5962BD3D2E0490C1EC4351B33F2160_inline (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::ReleaseMeshDatas(System.IntPtr*,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ReleaseMeshDatas_m4B049CAB0F9836B576B4C92A779F68FE951DE2D8 (intptr_t* ___datas0, int32_t ___count1, const RuntimeMethod* method);
// System.Void Unity.Collections.LowLevel.Unsafe.UnsafeUtility::Free(System.Void*,Unity.Collections.Allocator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnsafeUtility_Free_mA805168FF1B6728E7DF3AD1DE47400B37F3441F9 (void* ___memory0, int32_t ___allocator1, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_Dispose_m6A2B50484E35E488127841621369799266CBD4F2 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Mesh::get_canAccess()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Mesh_get_canAccess_m991B64F0FA651459A7E0DD4526D7EF0384F1792F (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Object::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// System.Void System.InvalidOperationException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::ApplyToMeshImpl(UnityEngine.Mesh,System.IntPtr,UnityEngine.Rendering.MeshUpdateFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ApplyToMeshImpl_mF3CA062385320C84B620CAB4031C70E18695E625 (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, intptr_t ___data1, int32_t ___flags2, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::ApplyToMeshAndDispose(UnityEngine.Mesh,UnityEngine.Rendering.MeshUpdateFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ApplyToMeshAndDispose_m387C3268D1678D98A4387A19E3309C53EAB5DB93 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, int32_t ___flags1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// System.String System.String::Format(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17 (String_t* ___format0, RuntimeObject * ___arg01, const RuntimeMethod* method);
// System.Void System.ArgumentNullException::.ctor(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentNullException__ctor_mAD2F05A24C92A657CBCA8C43A9A373C53739A283 (ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB * __this, String_t* ___paramName0, String_t* ___message1, const RuntimeMethod* method);
// System.String System.String::Format(System.String,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_m8D1CB0410C35E052A53AE957C914C841E54BAB66 (String_t* ___format0, RuntimeObject * ___arg01, RuntimeObject * ___arg12, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::ApplyToMeshesImpl(UnityEngine.Mesh[],System.IntPtr*,System.Int32,UnityEngine.Rendering.MeshUpdateFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ApplyToMeshesImpl_m8335D1328BAD5FDF11D6CCFB90ED1FC9E96F9500 (MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, intptr_t* ___datas1, int32_t ___count2, int32_t ___flags3, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::ApplyToMeshesAndDispose(UnityEngine.Mesh[],UnityEngine.Rendering.MeshUpdateFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ApplyToMeshesAndDispose_m8C732EB6A9EF32119A0F6AF1C2E157466669E74A (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, int32_t ___flags1, const RuntimeMethod* method);
// System.Int32 Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SizeOf<System.IntPtr>()
inline int32_t UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91 (const RuntimeMethod* method)
{
	return ((  int32_t (*) (const RuntimeMethod*))UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_gshared)(method);
}
// System.Int32 Unity.Collections.LowLevel.Unsafe.UnsafeUtility::AlignOf<System.IntPtr>()
inline int32_t UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994 (const RuntimeMethod* method)
{
	return ((  int32_t (*) (const RuntimeMethod*))UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_gshared)(method);
}
// System.Void* Unity.Collections.LowLevel.Unsafe.UnsafeUtility::Malloc(System.Int64,System.Int32,Unity.Collections.Allocator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void* UnsafeUtility_Malloc_m18FCC67A056C48A4E0F939D08C43F9E876CA1CF6 (int64_t ___size0, int32_t ___alignment1, int32_t ___allocator2, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::AcquireReadOnlyMeshData(UnityEngine.Mesh,System.IntPtr*)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_AcquireReadOnlyMeshData_mA8D0A6B091478A148E7572C4D9F6C9F93A1321BE (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, intptr_t* ___datas1, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::.ctor(UnityEngine.Mesh,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray__ctor_mF8939F58B78C2693235E3FE9143637404EB1A0D0 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, bool ___checkReadWrite1, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::AcquireReadOnlyMeshDatas(UnityEngine.Mesh[],System.IntPtr*,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_AcquireReadOnlyMeshDatas_m80768A6BCF4F95D32DA2E718E67046EA44CCCA6B (MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, intptr_t* ___datas1, int32_t ___count2, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::.ctor(UnityEngine.Mesh[],System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray__ctor_mD35379B2DF108964E9721D9062A82DE52C344D02 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, int32_t ___meshesCount1, bool ___checkReadWrite2, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::CreateNewMeshDatas(System.IntPtr*,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_CreateNewMeshDatas_m0C3B36987DB4F94DCC2129BE8E41F56C4C99ADC2 (intptr_t* ___datas0, int32_t ___count1, const RuntimeMethod* method);
// System.Void UnityEngine.Mesh/MeshDataArray::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray__ctor_mF40C97EC8A5377A058E86FE10773C7EC437D0BAB (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, int32_t ___meshesCount0, const RuntimeMethod* method);
// System.Guid UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers::get_MessageTypeId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Guid_t  MessageTypeSubscribers_get_MessageTypeId_m5A873C55E97728BD12BA52B5DB72FFA366992DD9 (MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * __this, const RuntimeMethod* method);
// System.Boolean System.Guid::op_Equality(System.Guid,System.Guid)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Guid_op_Equality_m4C2AA9C31D173525E381965A7246814B4C74D5B0 (Guid_t  ___a0, Guid_t  ___b1, const RuntimeMethod* method);
// System.Void UnityEngine.Events.UnityEvent`1<System.Int32>::.ctor()
inline void UnityEvent_1__ctor_m30F443398054B5E3666B3C86E64A5C0FF97D93FF (UnityEvent_1_tB235B5DAD099AC425DC059D10DEB8B97A35E2BBF * __this, const RuntimeMethod* method)
{
	((  void (*) (UnityEvent_1_tB235B5DAD099AC425DC059D10DEB8B97A35E2BBF *, const RuntimeMethod*))UnityEvent_1__ctor_m30F443398054B5E3666B3C86E64A5C0FF97D93FF_gshared)(__this, method);
}
// System.Void UnityEngine.Events.UnityEvent`1<UnityEngine.Networking.PlayerConnection.MessageEventArgs>::.ctor()
inline void UnityEvent_1__ctor_mC7E63F58C7EFC8E8747E3619B7564A7325F03D3B (UnityEvent_1_t5380899C55F3CD7FD1CD64F13EE5E1E4B11D602B * __this, const RuntimeMethod* method)
{
	((  void (*) (UnityEvent_1_t5380899C55F3CD7FD1CD64F13EE5E1E4B11D602B *, const RuntimeMethod*))UnityEvent_1__ctor_mD87552C18A41196B69A62A366C8238FC246B151A_gshared)(__this, method);
}
// System.Void System.Guid::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Guid__ctor_mF80313305B9CD2AD39B621E1CEC5C7DFDFFBDE66 (Guid_t * __this, String_t* ___g0, const RuntimeMethod* method);
// System.String System.Guid::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Guid_ToString_mA3AB7742FB0E04808F580868E82BDEB93187FB75 (Guid_t * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MessageEvent__ctor_mE4D70D8837C51E422C9A40C3F8F34ACB9AB572BB (MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.SpookyHash/U::.ctor(System.UInt16*)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U__ctor_m29915B03ADD0CB26085DB325B7FC87C4A5134C01 (U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB * __this, uint16_t* ___p80, const RuntimeMethod* method);
// System.Text.Encoding System.Text.Encoding::get_UTF8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E (const RuntimeMethod* method);
// System.Void System.Text.EncoderReplacementFallback::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EncoderReplacementFallback__ctor_m07299910DC3D3F6B9F8F37A4ADD40A500F97D1D4 (EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418 * __this, String_t* ___replacement0, const RuntimeMethod* method);
// System.Void System.Text.DecoderReplacementFallback::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DecoderReplacementFallback__ctor_m7E6C273B2682E373C787568EB0BB0B2E4B6C2253 (DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130 * __this, String_t* ___replacement0, const RuntimeMethod* method);
// System.Text.Encoding System.Text.Encoding::GetEncoding(System.Int32,System.Text.EncoderFallback,System.Text.DecoderFallback)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * Encoding_GetEncoding_m4DC46FF0C923994EDEE21980037198E27A75E4F2 (int32_t ___codepage0, EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4 * ___encoderFallback1, DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D * ___decoderFallback2, const RuntimeMethod* method);
// System.Void System.Text.UTF32Encoding::.ctor(System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UTF32Encoding__ctor_mCC6CB31807AE3B57FAF941B59D72D7BA10CFB1FD (UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014 * __this, bool ___bigEndian0, bool ___byteOrderMark1, bool ___throwOnInvalidCharacters2, const RuntimeMethod* method);
// System.Void System.Text.UnicodeEncoding::.ctor(System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnicodeEncoding__ctor_m8D0BFF0DBB175D7E590674E31343E8C72701FC7C (UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68 * __this, bool ___bigEndian0, bool ___byteOrderMark1, bool ___throwOnInvalidBytes2, const RuntimeMethod* method);
// System.Void System.Text.UTF8Encoding::.ctor(System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UTF8Encoding__ctor_mD752778085A353529AF03841383E5603FE556449 (UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * __this, bool ___encoderShouldEmitUTF8Identifier0, bool ___throwOnInvalidBytes1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.KeyValuePair`2<System.Byte[],System.Text.Encoding>::.ctor(!0,!1)
inline void KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E (KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___key0, Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * ___value1, const RuntimeMethod* method)
{
	((  void (*) (KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B *, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 *, const RuntimeMethod*))KeyValuePair_2__ctor_m74B9EB9E16A0CC0F80B0AB74B8E1E91C16E6998E_gshared)(__this, ___key0, ___value1, method);
}
// UnityEngine.Transform UnityEngine.Transform::GetChild(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Transform_GetChild_mA7D94BEFF0144F76561D9B8FED61C5C939EC1F1C (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Transform::get_childCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Transform_get_childCount_mCBED4F6D3F6A7386C4D97C2C3FD25C383A0BCD05 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.UnitySynchronizationContext/WorkRequest::.ctor(System.Threading.SendOrPostCallback,System.Object,System.Threading.ManualResetEvent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkRequest__ctor_m13C7B4A89E47F4B97ED9B786DB99849DBC2B5603 (WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 * __this, SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * ___callback0, RuntimeObject * ___state1, ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * ___waitHandle2, const RuntimeMethod* method);
// System.Void System.Threading.SendOrPostCallback::Invoke(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SendOrPostCallback_Invoke_m352534ED0E61440A793944CC44809F666BBC1461 (SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * __this, RuntimeObject * ___state0, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogException_m1BE957624F4DD291B1B4265D4A55A34EFAA8D7BA (Exception_t * ___exception0, const RuntimeMethod* method);
// System.Boolean System.Threading.EventWaitHandle::Set()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EventWaitHandle_Set_m81764C887F38A1153224557B26CD688B59987B38 (EventWaitHandle_t80CDEB33529EF7549E7D3E3B689D8272B9F37F3C * __this, const RuntimeMethod* method);
// System.Void UnityEngine.UnitySynchronizationContext/WorkRequest::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkRequest_Invoke_m1C292B7297918C5F2DBE70971895FE8D5C33AA20 (WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 * __this, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Single UnityEngine.Vector4::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector4_get_Item_m469B9D88498D0F7CD14B71A9512915BAA0B9B3B7 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	float V_2 = 0.0f;
	{
		int32_t L_0 = ___index0;
		V_1 = L_0;
		int32_t L_1 = V_1;
		V_0 = L_1;
		int32_t L_2 = V_0;
		switch (L_2)
		{
			case 0:
			{
				goto IL_001d;
			}
			case 1:
			{
				goto IL_0026;
			}
			case 2:
			{
				goto IL_002f;
			}
			case 3:
			{
				goto IL_0038;
			}
		}
	}
	{
		goto IL_0041;
	}

IL_001d:
	{
		float L_3 = __this->get_x_1();
		V_2 = L_3;
		goto IL_004c;
	}

IL_0026:
	{
		float L_4 = __this->get_y_2();
		V_2 = L_4;
		goto IL_004c;
	}

IL_002f:
	{
		float L_5 = __this->get_z_3();
		V_2 = L_5;
		goto IL_004c;
	}

IL_0038:
	{
		float L_6 = __this->get_w_4();
		V_2 = L_6;
		goto IL_004c;
	}

IL_0041:
	{
		IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD * L_7 = (IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD_il2cpp_TypeInfo_var)));
		IndexOutOfRangeException__ctor_mC5747EC0E0F49AAD1AD782ACC7A0CCD80D192FEF(L_7, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralB23C3717573626FB4C3C7DF5C19EDE7689837214)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Vector4_get_Item_m469B9D88498D0F7CD14B71A9512915BAA0B9B3B7_RuntimeMethod_var)));
	}

IL_004c:
	{
		float L_8 = V_2;
		return L_8;
	}
}
IL2CPP_EXTERN_C  float Vector4_get_Item_m469B9D88498D0F7CD14B71A9512915BAA0B9B3B7_AdjustorThunk (RuntimeObject * __this, int32_t ___index0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	float _returnValue;
	_returnValue = Vector4_get_Item_m469B9D88498D0F7CD14B71A9512915BAA0B9B3B7(_thisAdjusted, ___index0, method);
	return _returnValue;
}
// System.Void UnityEngine.Vector4::set_Item(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector4_set_Item_m7552B288FF218CA023F0DFB971BBA30D0362006A (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = ___index0;
		V_1 = L_0;
		int32_t L_1 = V_1;
		V_0 = L_1;
		int32_t L_2 = V_0;
		switch (L_2)
		{
			case 0:
			{
				goto IL_001d;
			}
			case 1:
			{
				goto IL_0026;
			}
			case 2:
			{
				goto IL_002f;
			}
			case 3:
			{
				goto IL_0038;
			}
		}
	}
	{
		goto IL_0041;
	}

IL_001d:
	{
		float L_3 = ___value1;
		__this->set_x_1(L_3);
		goto IL_004c;
	}

IL_0026:
	{
		float L_4 = ___value1;
		__this->set_y_2(L_4);
		goto IL_004c;
	}

IL_002f:
	{
		float L_5 = ___value1;
		__this->set_z_3(L_5);
		goto IL_004c;
	}

IL_0038:
	{
		float L_6 = ___value1;
		__this->set_w_4(L_6);
		goto IL_004c;
	}

IL_0041:
	{
		IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD * L_7 = (IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD_il2cpp_TypeInfo_var)));
		IndexOutOfRangeException__ctor_mC5747EC0E0F49AAD1AD782ACC7A0CCD80D192FEF(L_7, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralB23C3717573626FB4C3C7DF5C19EDE7689837214)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Vector4_set_Item_m7552B288FF218CA023F0DFB971BBA30D0362006A_RuntimeMethod_var)));
	}

IL_004c:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void Vector4_set_Item_m7552B288FF218CA023F0DFB971BBA30D0362006A_AdjustorThunk (RuntimeObject * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	Vector4_set_Item_m7552B288FF218CA023F0DFB971BBA30D0362006A(_thisAdjusted, ___index0, ___value1, method);
}
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, float ___x0, float ___y1, float ___z2, float ___w3, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_1(L_0);
		float L_1 = ___y1;
		__this->set_y_2(L_1);
		float L_2 = ___z2;
		__this->set_z_3(L_2);
		float L_3 = ___w3;
		__this->set_w_4(L_3);
		return;
	}
}
IL2CPP_EXTERN_C  void Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2_AdjustorThunk (RuntimeObject * __this, float ___x0, float ___y1, float ___z2, float ___w3, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2(_thisAdjusted, ___x0, ___y1, ___z2, ___w3, method);
}
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector4__ctor_m7F4644B9C896ADDF4A3033DA36EF9D873A678E5F (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, float ___x0, float ___y1, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_1(L_0);
		float L_1 = ___y1;
		__this->set_y_2(L_1);
		__this->set_z_3((0.0f));
		__this->set_w_4((0.0f));
		return;
	}
}
IL2CPP_EXTERN_C  void Vector4__ctor_m7F4644B9C896ADDF4A3033DA36EF9D873A678E5F_AdjustorThunk (RuntimeObject * __this, float ___x0, float ___y1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	Vector4__ctor_m7F4644B9C896ADDF4A3033DA36EF9D873A678E5F(_thisAdjusted, ___x0, ___y1, method);
}
// System.Int32 UnityEngine.Vector4::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Vector4_GetHashCode_mCA7B312F8CA141F6F25BABDDF406F3D2BDD5E895 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		float* L_0 = __this->get_address_of_x_1();
		int32_t L_1;
		L_1 = Single_GetHashCode_m7662E1812DDDBC85D464398740CFFC3588DFB2C9((float*)L_0, /*hidden argument*/NULL);
		float* L_2 = __this->get_address_of_y_2();
		int32_t L_3;
		L_3 = Single_GetHashCode_m7662E1812DDDBC85D464398740CFFC3588DFB2C9((float*)L_2, /*hidden argument*/NULL);
		float* L_4 = __this->get_address_of_z_3();
		int32_t L_5;
		L_5 = Single_GetHashCode_m7662E1812DDDBC85D464398740CFFC3588DFB2C9((float*)L_4, /*hidden argument*/NULL);
		float* L_6 = __this->get_address_of_w_4();
		int32_t L_7;
		L_7 = Single_GetHashCode_m7662E1812DDDBC85D464398740CFFC3588DFB2C9((float*)L_6, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)((int32_t)((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_5>>(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_7>>(int32_t)1))));
		goto IL_0039;
	}

IL_0039:
	{
		int32_t L_8 = V_0;
		return L_8;
	}
}
IL2CPP_EXTERN_C  int32_t Vector4_GetHashCode_mCA7B312F8CA141F6F25BABDDF406F3D2BDD5E895_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = Vector4_GetHashCode_mCA7B312F8CA141F6F25BABDDF406F3D2BDD5E895(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Vector4::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Vector4_Equals_m71D14F39651C3FBEDE17214455DFA727921F07AA (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		RuntimeObject * L_0 = ___other0;
		V_0 = (bool)((((int32_t)((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_0024;
	}

IL_0015:
	{
		RuntimeObject * L_2 = ___other0;
		bool L_3;
		L_3 = Vector4_Equals_m0919D35807550372D1748193EB31E4C5E406AE61_inline((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)__this, ((*(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)UnBox(L_2, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var)))), /*hidden argument*/NULL);
		V_1 = L_3;
		goto IL_0024;
	}

IL_0024:
	{
		bool L_4 = V_1;
		return L_4;
	}
}
IL2CPP_EXTERN_C  bool Vector4_Equals_m71D14F39651C3FBEDE17214455DFA727921F07AA_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	bool _returnValue;
	_returnValue = Vector4_Equals_m71D14F39651C3FBEDE17214455DFA727921F07AA(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Vector4::Equals(UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Vector4_Equals_m0919D35807550372D1748193EB31E4C5E406AE61 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___other0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t G_B5_0 = 0;
	{
		float L_0 = __this->get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_1 = ___other0;
		float L_2 = L_1.get_x_1();
		if ((!(((float)L_0) == ((float)L_2))))
		{
			goto IL_003b;
		}
	}
	{
		float L_3 = __this->get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___other0;
		float L_5 = L_4.get_y_2();
		if ((!(((float)L_3) == ((float)L_5))))
		{
			goto IL_003b;
		}
	}
	{
		float L_6 = __this->get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_7 = ___other0;
		float L_8 = L_7.get_z_3();
		if ((!(((float)L_6) == ((float)L_8))))
		{
			goto IL_003b;
		}
	}
	{
		float L_9 = __this->get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_10 = ___other0;
		float L_11 = L_10.get_w_4();
		G_B5_0 = ((((float)L_9) == ((float)L_11))? 1 : 0);
		goto IL_003c;
	}

IL_003b:
	{
		G_B5_0 = 0;
	}

IL_003c:
	{
		V_0 = (bool)G_B5_0;
		goto IL_003f;
	}

IL_003f:
	{
		bool L_12 = V_0;
		return L_12;
	}
}
IL2CPP_EXTERN_C  bool Vector4_Equals_m0919D35807550372D1748193EB31E4C5E406AE61_AdjustorThunk (RuntimeObject * __this, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	bool _returnValue;
	_returnValue = Vector4_Equals_m0919D35807550372D1748193EB31E4C5E406AE61_inline(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Single UnityEngine.Vector4::Dot(UnityEngine.Vector4,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector4_Dot_m3373C73B23A0BC07DDE8B9C99AA2FC933CD1143F (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___a0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___b1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___a0;
		float L_1 = L_0.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_2 = ___b1;
		float L_3 = L_2.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___a0;
		float L_5 = L_4.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___b1;
		float L_7 = L_6.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_8 = ___a0;
		float L_9 = L_8.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_10 = ___b1;
		float L_11 = L_10.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_12 = ___a0;
		float L_13 = L_12.get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_14 = ___b1;
		float L_15 = L_14.get_w_4();
		V_0 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_1, (float)L_3)), (float)((float)il2cpp_codegen_multiply((float)L_5, (float)L_7)))), (float)((float)il2cpp_codegen_multiply((float)L_9, (float)L_11)))), (float)((float)il2cpp_codegen_multiply((float)L_13, (float)L_15))));
		goto IL_003b;
	}

IL_003b:
	{
		float L_16 = V_0;
		return L_16;
	}
}
// System.Single UnityEngine.Vector4::get_magnitude()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector4_get_magnitude_mAEC3DB52FD5DEFB39CA058BAF64A0C487B9CDD10 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = (*(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)__this);
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_1 = (*(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)__this);
		float L_2;
		L_2 = Vector4_Dot_m3373C73B23A0BC07DDE8B9C99AA2FC933CD1143F(L_0, L_1, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var);
		double L_3;
		L_3 = sqrt(((double)((double)L_2)));
		V_0 = ((float)((float)L_3));
		goto IL_001c;
	}

IL_001c:
	{
		float L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  float Vector4_get_magnitude_mAEC3DB52FD5DEFB39CA058BAF64A0C487B9CDD10_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	float _returnValue;
	_returnValue = Vector4_get_magnitude_mAEC3DB52FD5DEFB39CA058BAF64A0C487B9CDD10(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.Vector4::get_sqrMagnitude()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector4_get_sqrMagnitude_m1450744F6AAD57773CE0208B6F51DDEEE9A48E07 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = (*(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)__this);
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_1 = (*(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)__this);
		float L_2;
		L_2 = Vector4_Dot_m3373C73B23A0BC07DDE8B9C99AA2FC933CD1143F(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0015;
	}

IL_0015:
	{
		float L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  float Vector4_get_sqrMagnitude_m1450744F6AAD57773CE0208B6F51DDEEE9A48E07_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	float _returnValue;
	_returnValue = Vector4_get_sqrMagnitude_m1450744F6AAD57773CE0208B6F51DDEEE9A48E07(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Vector4 UnityEngine.Vector4::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_get_zero_m9E807FEBC8B638914DF4A0BA87C0BD95A19F5200 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var))->get_zeroVector_5();
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::get_one()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_get_one_m59B707729B52E58A045A6DE2ACDDE1D1600F48A4 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var))->get_oneVector_6();
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Addition(UnityEngine.Vector4,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Addition_m3456C2E0202FF7A30CA7211D40FA80A6FA28B1D0 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___a0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___b1, const RuntimeMethod* method)
{
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___a0;
		float L_1 = L_0.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_2 = ___b1;
		float L_3 = L_2.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___a0;
		float L_5 = L_4.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___b1;
		float L_7 = L_6.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_8 = ___a0;
		float L_9 = L_8.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_10 = ___b1;
		float L_11 = L_10.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_12 = ___a0;
		float L_13 = L_12.get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_14 = ___b1;
		float L_15 = L_14.get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_16;
		memset((&L_16), 0, sizeof(L_16));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_16), ((float)il2cpp_codegen_add((float)L_1, (float)L_3)), ((float)il2cpp_codegen_add((float)L_5, (float)L_7)), ((float)il2cpp_codegen_add((float)L_9, (float)L_11)), ((float)il2cpp_codegen_add((float)L_13, (float)L_15)), /*hidden argument*/NULL);
		V_0 = L_16;
		goto IL_003d;
	}

IL_003d:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_17 = V_0;
		return L_17;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Subtraction(UnityEngine.Vector4,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Subtraction_mF776C80EC658784C4F821FDBD4B14A0297A591D1 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___a0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___b1, const RuntimeMethod* method)
{
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___a0;
		float L_1 = L_0.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_2 = ___b1;
		float L_3 = L_2.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___a0;
		float L_5 = L_4.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___b1;
		float L_7 = L_6.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_8 = ___a0;
		float L_9 = L_8.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_10 = ___b1;
		float L_11 = L_10.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_12 = ___a0;
		float L_13 = L_12.get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_14 = ___b1;
		float L_15 = L_14.get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_16;
		memset((&L_16), 0, sizeof(L_16));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_16), ((float)il2cpp_codegen_subtract((float)L_1, (float)L_3)), ((float)il2cpp_codegen_subtract((float)L_5, (float)L_7)), ((float)il2cpp_codegen_subtract((float)L_9, (float)L_11)), ((float)il2cpp_codegen_subtract((float)L_13, (float)L_15)), /*hidden argument*/NULL);
		V_0 = L_16;
		goto IL_003d;
	}

IL_003d:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_17 = V_0;
		return L_17;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_UnaryNegation(UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_UnaryNegation_m513EC47996956B01B9AEFE7B4352952A9E818F6E (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___a0, const RuntimeMethod* method)
{
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___a0;
		float L_1 = L_0.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_2 = ___a0;
		float L_3 = L_2.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___a0;
		float L_5 = L_4.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___a0;
		float L_7 = L_6.get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_8), ((-L_1)), ((-L_3)), ((-L_5)), ((-L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0025;
	}

IL_0025:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_9 = V_0;
		return L_9;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Multiply(UnityEngine.Vector4,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Multiply_m4B615DCAD6D77FE276AC56F17EA3ED0DCD942111 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___a0;
		float L_1 = L_0.get_x_1();
		float L_2 = ___d1;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_3 = ___a0;
		float L_4 = L_3.get_y_2();
		float L_5 = ___d1;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___a0;
		float L_7 = L_6.get_z_3();
		float L_8 = ___d1;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_9 = ___a0;
		float L_10 = L_9.get_w_4();
		float L_11 = ___d1;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_12), ((float)il2cpp_codegen_multiply((float)L_1, (float)L_2)), ((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)), ((float)il2cpp_codegen_multiply((float)L_7, (float)L_8)), ((float)il2cpp_codegen_multiply((float)L_10, (float)L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0029;
	}

IL_0029:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_13 = V_0;
		return L_13;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Multiply(System.Single,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Multiply_m5413794561683CB2AA8D68DD1B432FF853DF3BC6 (float ___d0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___a1, const RuntimeMethod* method)
{
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___a1;
		float L_1 = L_0.get_x_1();
		float L_2 = ___d0;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_3 = ___a1;
		float L_4 = L_3.get_y_2();
		float L_5 = ___d0;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___a1;
		float L_7 = L_6.get_z_3();
		float L_8 = ___d0;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_9 = ___a1;
		float L_10 = L_9.get_w_4();
		float L_11 = ___d0;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_12), ((float)il2cpp_codegen_multiply((float)L_1, (float)L_2)), ((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)), ((float)il2cpp_codegen_multiply((float)L_7, (float)L_8)), ((float)il2cpp_codegen_multiply((float)L_10, (float)L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0029;
	}

IL_0029:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_13 = V_0;
		return L_13;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Division(UnityEngine.Vector4,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Division_m8AF7C92DD640CE3275F975E9BCD62F04E29DEDB6 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___a0;
		float L_1 = L_0.get_x_1();
		float L_2 = ___d1;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_3 = ___a0;
		float L_4 = L_3.get_y_2();
		float L_5 = ___d1;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___a0;
		float L_7 = L_6.get_z_3();
		float L_8 = ___d1;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_9 = ___a0;
		float L_10 = L_9.get_w_4();
		float L_11 = ___d1;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_12), ((float)((float)L_1/(float)L_2)), ((float)((float)L_4/(float)L_5)), ((float)((float)L_7/(float)L_8)), ((float)((float)L_10/(float)L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0029;
	}

IL_0029:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_13 = V_0;
		return L_13;
	}
}
// System.Boolean UnityEngine.Vector4::op_Equality(UnityEngine.Vector4,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Vector4_op_Equality_mAC86329F5E0AF56A4A1067AB4299C291221720AE (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___lhs0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___rhs1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	float V_4 = 0.0f;
	bool V_5 = false;
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___lhs0;
		float L_1 = L_0.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_2 = ___rhs1;
		float L_3 = L_2.get_x_1();
		V_0 = ((float)il2cpp_codegen_subtract((float)L_1, (float)L_3));
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___lhs0;
		float L_5 = L_4.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___rhs1;
		float L_7 = L_6.get_y_2();
		V_1 = ((float)il2cpp_codegen_subtract((float)L_5, (float)L_7));
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_8 = ___lhs0;
		float L_9 = L_8.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_10 = ___rhs1;
		float L_11 = L_10.get_z_3();
		V_2 = ((float)il2cpp_codegen_subtract((float)L_9, (float)L_11));
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_12 = ___lhs0;
		float L_13 = L_12.get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_14 = ___rhs1;
		float L_15 = L_14.get_w_4();
		V_3 = ((float)il2cpp_codegen_subtract((float)L_13, (float)L_15));
		float L_16 = V_0;
		float L_17 = V_0;
		float L_18 = V_1;
		float L_19 = V_1;
		float L_20 = V_2;
		float L_21 = V_2;
		float L_22 = V_3;
		float L_23 = V_3;
		V_4 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_16, (float)L_17)), (float)((float)il2cpp_codegen_multiply((float)L_18, (float)L_19)))), (float)((float)il2cpp_codegen_multiply((float)L_20, (float)L_21)))), (float)((float)il2cpp_codegen_multiply((float)L_22, (float)L_23))));
		float L_24 = V_4;
		V_5 = (bool)((((float)L_24) < ((float)(9.99999944E-11f)))? 1 : 0);
		goto IL_0057;
	}

IL_0057:
	{
		bool L_25 = V_5;
		return L_25;
	}
}
// System.Boolean UnityEngine.Vector4::op_Inequality(UnityEngine.Vector4,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Vector4_op_Inequality_m2B976EE8649EE1AE9DE1771CEE183AC70E3A75B7 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___lhs0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___rhs1, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___lhs0;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_1 = ___rhs1;
		bool L_2;
		L_2 = Vector4_op_Equality_mAC86329F5E0AF56A4A1067AB4299C291221720AE_inline(L_0, L_1, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		goto IL_000e;
	}

IL_000e:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Implicit(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Implicit_mDCFA56E9D34979E1E2BFE6C2D61F1768D934A8EB (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___v0, const RuntimeMethod* method)
{
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___v0;
		float L_1 = L_0.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2 = ___v0;
		float L_3 = L_2.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4 = ___v0;
		float L_5 = L_4.get_z_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6;
		memset((&L_6), 0, sizeof(L_6));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_6), L_1, L_3, L_5, (0.0f), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_0020;
	}

IL_0020:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_7 = V_0;
		return L_7;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector4::op_Implicit(UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector4_op_Implicit_m5811604E04B684BE3F1A212A7FA46767619AB35B (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___v0, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___v0;
		float L_1 = L_0.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_2 = ___v0;
		float L_3 = L_2.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___v0;
		float L_5 = L_4.get_z_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6;
		memset((&L_6), 0, sizeof(L_6));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_6), L_1, L_3, L_5, /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_001b;
	}

IL_001b:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_7 = V_0;
		return L_7;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Implicit(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Implicit_mFFF2D39354FC98FDEDA761EDB4326E4F11B87504 (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___v0, const RuntimeMethod* method)
{
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0 = ___v0;
		float L_1 = L_0.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2 = ___v0;
		float L_3 = L_2.get_y_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4;
		memset((&L_4), 0, sizeof(L_4));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_4), L_1, L_3, (0.0f), (0.0f), /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_001f;
	}

IL_001f:
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_5 = V_0;
		return L_5;
	}
}
// System.String UnityEngine.Vector4::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Vector4_ToString_mF2D17142EBD75E91BC718B3E347F614AC45E9040 (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_0;
		L_0 = CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164(/*hidden argument*/NULL);
		NullCheck(L_0);
		NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * L_1;
		L_1 = VirtFuncInvoker0< NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D * >::Invoke(20 /* System.Globalization.NumberFormatInfo System.Globalization.CultureInfo::get_NumberFormat() */, L_0);
		String_t* L_2;
		L_2 = Vector4_ToString_m0EC6AA83CD606E3EB5BE60108A1D9AC4ECB5517A((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)__this, (String_t*)NULL, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0015;
	}

IL_0015:
	{
		String_t* L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  String_t* Vector4_ToString_mF2D17142EBD75E91BC718B3E347F614AC45E9040_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	String_t* _returnValue;
	_returnValue = Vector4_ToString_mF2D17142EBD75E91BC718B3E347F614AC45E9040(_thisAdjusted, method);
	return _returnValue;
}
// System.String UnityEngine.Vector4::ToString(System.String,System.IFormatProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Vector4_ToString_m0EC6AA83CD606E3EB5BE60108A1D9AC4ECB5517A (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, String_t* ___format0, RuntimeObject* ___formatProvider1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4DA40F86FA6B66D1B6831F82ADF65BBE193ABB05);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC613D4D2FE3F5D74727D376F793286A2BCBB1391);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	String_t* V_1 = NULL;
	{
		String_t* L_0 = ___format0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0012;
		}
	}
	{
		___format0 = _stringLiteralC613D4D2FE3F5D74727D376F793286A2BCBB1391;
	}

IL_0012:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)4);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = L_3;
		float* L_5 = __this->get_address_of_x_1();
		String_t* L_6 = ___format0;
		RuntimeObject* L_7 = ___formatProvider1;
		String_t* L_8;
		L_8 = Single_ToString_m7631D332703B4197EAA7DC0BA067CE7E16334D8B((float*)L_5, L_6, L_7, /*hidden argument*/NULL);
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, L_8);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_8);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_9 = L_4;
		float* L_10 = __this->get_address_of_y_2();
		String_t* L_11 = ___format0;
		RuntimeObject* L_12 = ___formatProvider1;
		String_t* L_13;
		L_13 = Single_ToString_m7631D332703B4197EAA7DC0BA067CE7E16334D8B((float*)L_10, L_11, L_12, /*hidden argument*/NULL);
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, L_13);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_13);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_14 = L_9;
		float* L_15 = __this->get_address_of_z_3();
		String_t* L_16 = ___format0;
		RuntimeObject* L_17 = ___formatProvider1;
		String_t* L_18;
		L_18 = Single_ToString_m7631D332703B4197EAA7DC0BA067CE7E16334D8B((float*)L_15, L_16, L_17, /*hidden argument*/NULL);
		NullCheck(L_14);
		ArrayElementTypeCheck (L_14, L_18);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_18);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_19 = L_14;
		float* L_20 = __this->get_address_of_w_4();
		String_t* L_21 = ___format0;
		RuntimeObject* L_22 = ___formatProvider1;
		String_t* L_23;
		L_23 = Single_ToString_m7631D332703B4197EAA7DC0BA067CE7E16334D8B((float*)L_20, L_21, L_22, /*hidden argument*/NULL);
		NullCheck(L_19);
		ArrayElementTypeCheck (L_19, L_23);
		(L_19)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_23);
		String_t* L_24;
		L_24 = UnityString_Format_m7A07C068ED408DD06F634070770FB55F13AA4EC9(_stringLiteral4DA40F86FA6B66D1B6831F82ADF65BBE193ABB05, L_19, /*hidden argument*/NULL);
		V_1 = L_24;
		goto IL_0065;
	}

IL_0065:
	{
		String_t* L_25 = V_1;
		return L_25;
	}
}
IL2CPP_EXTERN_C  String_t* Vector4_ToString_m0EC6AA83CD606E3EB5BE60108A1D9AC4ECB5517A_AdjustorThunk (RuntimeObject * __this, String_t* ___format0, RuntimeObject* ___formatProvider1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * _thisAdjusted = reinterpret_cast<Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *>(__this + _offset);
	String_t* _returnValue;
	_returnValue = Vector4_ToString_m0EC6AA83CD606E3EB5BE60108A1D9AC4ECB5517A(_thisAdjusted, ___format0, ___formatProvider1, method);
	return _returnValue;
}
// System.Void UnityEngine.Vector4::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector4__cctor_m35F167F24C48A767EAD837754896B5A5178C078A (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0;
		memset((&L_0), 0, sizeof(L_0));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_0), (0.0f), (0.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var))->set_zeroVector_5(L_0);
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_1;
		memset((&L_1), 0, sizeof(L_1));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_1), (1.0f), (1.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var))->set_oneVector_6(L_1);
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_2;
		memset((&L_2), 0, sizeof(L_2));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_2), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), /*hidden argument*/NULL);
		((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var))->set_positiveInfinityVector_7(L_2);
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_3;
		memset((&L_3), 0, sizeof(L_3));
		Vector4__ctor_mCAB598A37C4D5E80282277E828B8A3EAD936D3B2((&L_3), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), /*hidden argument*/NULL);
		((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_il2cpp_TypeInfo_var))->set_negativeInfinityVector_8(L_3);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Rendering.VertexAttribute UnityEngine.Rendering.VertexAttributeDescriptor::get_attribute()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CattributeU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD_inline(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::set_attribute(UnityEngine.Rendering.VertexAttribute)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_attribute_mBF99A4AE23B0677C1922EA461FB8B36B021C68B6 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CattributeU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_EXTERN_C  void VertexAttributeDescriptor_set_attribute_mBF99A4AE23B0677C1922EA461FB8B36B021C68B6_AdjustorThunk (RuntimeObject * __this, int32_t ___value0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	VertexAttributeDescriptor_set_attribute_mBF99A4AE23B0677C1922EA461FB8B36B021C68B6_inline(_thisAdjusted, ___value0, method);
}
// UnityEngine.Rendering.VertexAttributeFormat UnityEngine.Rendering.VertexAttributeDescriptor::get_format()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CformatU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186_inline(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::set_format(UnityEngine.Rendering.VertexAttributeFormat)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_format_m530E47091524EF538721994F3A0A066285B72251 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CformatU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_EXTERN_C  void VertexAttributeDescriptor_set_format_m530E47091524EF538721994F3A0A066285B72251_AdjustorThunk (RuntimeObject * __this, int32_t ___value0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	VertexAttributeDescriptor_set_format_m530E47091524EF538721994F3A0A066285B72251_inline(_thisAdjusted, ___value0, method);
}
// System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::get_dimension()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CdimensionU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C_inline(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::set_dimension(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_dimension_m8E0A210A2662617D2AB601C6DC0D996A08563787 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CdimensionU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_EXTERN_C  void VertexAttributeDescriptor_set_dimension_m8E0A210A2662617D2AB601C6DC0D996A08563787_AdjustorThunk (RuntimeObject * __this, int32_t ___value0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	VertexAttributeDescriptor_set_dimension_m8E0A210A2662617D2AB601C6DC0D996A08563787_inline(_thisAdjusted, ___value0, method);
}
// System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::get_stream()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CstreamU3Ek__BackingField_3();
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15_inline(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::set_stream(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_stream_m39EC0B3F25D7CCF8F389C2CCF6390DA8E8651BEE (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CstreamU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_EXTERN_C  void VertexAttributeDescriptor_set_stream_m39EC0B3F25D7CCF8F389C2CCF6390DA8E8651BEE_AdjustorThunk (RuntimeObject * __this, int32_t ___value0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	VertexAttributeDescriptor_set_stream_m39EC0B3F25D7CCF8F389C2CCF6390DA8E8651BEE_inline(_thisAdjusted, ___value0, method);
}
// System.Void UnityEngine.Rendering.VertexAttributeDescriptor::.ctor(UnityEngine.Rendering.VertexAttribute,UnityEngine.Rendering.VertexAttributeFormat,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VertexAttributeDescriptor__ctor_m98183669DC960D7BEFBEF0E216FF9A4BE1941FE9 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___attribute0, int32_t ___format1, int32_t ___dimension2, int32_t ___stream3, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___attribute0;
		VertexAttributeDescriptor_set_attribute_mBF99A4AE23B0677C1922EA461FB8B36B021C68B6_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, L_0, /*hidden argument*/NULL);
		int32_t L_1 = ___format1;
		VertexAttributeDescriptor_set_format_m530E47091524EF538721994F3A0A066285B72251_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, L_1, /*hidden argument*/NULL);
		int32_t L_2 = ___dimension2;
		VertexAttributeDescriptor_set_dimension_m8E0A210A2662617D2AB601C6DC0D996A08563787_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, L_2, /*hidden argument*/NULL);
		int32_t L_3 = ___stream3;
		VertexAttributeDescriptor_set_stream_m39EC0B3F25D7CCF8F389C2CCF6390DA8E8651BEE_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, L_3, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void VertexAttributeDescriptor__ctor_m98183669DC960D7BEFBEF0E216FF9A4BE1941FE9_AdjustorThunk (RuntimeObject * __this, int32_t ___attribute0, int32_t ___format1, int32_t ___dimension2, int32_t ___stream3, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	VertexAttributeDescriptor__ctor_m98183669DC960D7BEFBEF0E216FF9A4BE1941FE9(_thisAdjusted, ___attribute0, ___format1, ___dimension2, ___stream3, method);
}
// System.String UnityEngine.Rendering.VertexAttributeDescriptor::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* VertexAttributeDescriptor_ToString_m573FD18B681482B56A12328C9D7D2DA171391B6D (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&VertexAttributeFormat_tE5FC93A96237AAF63142B0E521925CAE4F283485_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&VertexAttribute_t9B763063E3B1705070D4DB8BC32F21F0FB30867C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral40603CB9C3C2F0F007BD4C59CEB195FB17927F5C);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_0 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)4);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_1 = L_0;
		int32_t L_2;
		L_2 = VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		int32_t L_3 = L_2;
		RuntimeObject * L_4 = Box(VertexAttribute_t9B763063E3B1705070D4DB8BC32F21F0FB30867C_il2cpp_TypeInfo_var, &L_3);
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, L_4);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_4);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_5 = L_1;
		int32_t L_6;
		L_6 = VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		int32_t L_7 = L_6;
		RuntimeObject * L_8 = Box(VertexAttributeFormat_tE5FC93A96237AAF63142B0E521925CAE4F283485_il2cpp_TypeInfo_var, &L_7);
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_8);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_8);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_9 = L_5;
		int32_t L_10;
		L_10 = VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		int32_t L_11 = L_10;
		RuntimeObject * L_12 = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &L_11);
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, L_12);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_12);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_13 = L_9;
		int32_t L_14;
		L_14 = VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		int32_t L_15 = L_14;
		RuntimeObject * L_16 = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &L_15);
		NullCheck(L_13);
		ArrayElementTypeCheck (L_13, L_16);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_16);
		String_t* L_17;
		L_17 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral40603CB9C3C2F0F007BD4C59CEB195FB17927F5C, L_13, /*hidden argument*/NULL);
		V_0 = L_17;
		goto IL_004c;
	}

IL_004c:
	{
		String_t* L_18 = V_0;
		return L_18;
	}
}
IL2CPP_EXTERN_C  String_t* VertexAttributeDescriptor_ToString_m573FD18B681482B56A12328C9D7D2DA171391B6D_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	String_t* _returnValue;
	_returnValue = VertexAttributeDescriptor_ToString_m573FD18B681482B56A12328C9D7D2DA171391B6D(_thisAdjusted, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Rendering.VertexAttributeDescriptor::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_GetHashCode_m6928CD591C6E2506839A6B252BEF738EFF05BAB9 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		V_0 = ((int32_t)17);
		int32_t L_0 = V_0;
		int32_t L_1;
		L_1 = VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_0, (int32_t)((int32_t)23))), (int32_t)L_1));
		int32_t L_2 = V_0;
		int32_t L_3;
		L_3 = VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_2, (int32_t)((int32_t)23))), (int32_t)L_3));
		int32_t L_4 = V_0;
		int32_t L_5;
		L_5 = VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_4, (int32_t)((int32_t)23))), (int32_t)L_5));
		int32_t L_6 = V_0;
		int32_t L_7;
		L_7 = VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_6, (int32_t)((int32_t)23))), (int32_t)L_7));
		int32_t L_8 = V_0;
		V_1 = L_8;
		goto IL_0039;
	}

IL_0039:
	{
		int32_t L_9 = V_1;
		return L_9;
	}
}
IL2CPP_EXTERN_C  int32_t VertexAttributeDescriptor_GetHashCode_m6928CD591C6E2506839A6B252BEF738EFF05BAB9_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = VertexAttributeDescriptor_GetHashCode_m6928CD591C6E2506839A6B252BEF738EFF05BAB9(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Rendering.VertexAttributeDescriptor::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VertexAttributeDescriptor_Equals_mF5DF2302FF50A66408E015DB0AA51C743D239C00 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		RuntimeObject * L_0 = ___other0;
		V_0 = (bool)((((int32_t)((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_0, VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_0024;
	}

IL_0015:
	{
		RuntimeObject * L_2 = ___other0;
		bool L_3;
		L_3 = VertexAttributeDescriptor_Equals_mED68AA9CEBA42E83A17AAB1CB177D6A96C00EEF9((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, ((*(VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)UnBox(L_2, VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E_il2cpp_TypeInfo_var)))), /*hidden argument*/NULL);
		V_1 = L_3;
		goto IL_0024;
	}

IL_0024:
	{
		bool L_4 = V_1;
		return L_4;
	}
}
IL2CPP_EXTERN_C  bool VertexAttributeDescriptor_Equals_mF5DF2302FF50A66408E015DB0AA51C743D239C00_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	bool _returnValue;
	_returnValue = VertexAttributeDescriptor_Equals_mF5DF2302FF50A66408E015DB0AA51C743D239C00(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Rendering.VertexAttributeDescriptor::Equals(UnityEngine.Rendering.VertexAttributeDescriptor)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VertexAttributeDescriptor_Equals_mED68AA9CEBA42E83A17AAB1CB177D6A96C00EEF9 (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E  ___other0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t G_B5_0 = 0;
	{
		int32_t L_0;
		L_0 = VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)(&___other0), /*hidden argument*/NULL);
		if ((!(((uint32_t)L_0) == ((uint32_t)L_1))))
		{
			goto IL_003f;
		}
	}
	{
		int32_t L_2;
		L_2 = VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		int32_t L_3;
		L_3 = VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)(&___other0), /*hidden argument*/NULL);
		if ((!(((uint32_t)L_2) == ((uint32_t)L_3))))
		{
			goto IL_003f;
		}
	}
	{
		int32_t L_4;
		L_4 = VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		int32_t L_5;
		L_5 = VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)(&___other0), /*hidden argument*/NULL);
		if ((!(((uint32_t)L_4) == ((uint32_t)L_5))))
		{
			goto IL_003f;
		}
	}
	{
		int32_t L_6;
		L_6 = VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15_inline((VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *)(&___other0), /*hidden argument*/NULL);
		G_B5_0 = ((((int32_t)L_6) == ((int32_t)L_7))? 1 : 0);
		goto IL_0040;
	}

IL_003f:
	{
		G_B5_0 = 0;
	}

IL_0040:
	{
		V_0 = (bool)G_B5_0;
		goto IL_0043;
	}

IL_0043:
	{
		bool L_8 = V_0;
		return L_8;
	}
}
IL2CPP_EXTERN_C  bool VertexAttributeDescriptor_Equals_mED68AA9CEBA42E83A17AAB1CB177D6A96C00EEF9_AdjustorThunk (RuntimeObject * __this, VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * _thisAdjusted = reinterpret_cast<VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E *>(__this + _offset);
	bool _returnValue;
	_returnValue = VertexAttributeDescriptor_Equals_mED68AA9CEBA42E83A17AAB1CB177D6A96C00EEF9(_thisAdjusted, ___other0, method);
	return _returnValue;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Light UnityEngine.Rendering.VisibleLight::get_light()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Light_tA2F349FE839781469A0344CF6039B51512394275 * VisibleLight_get_light_mB3719D47BF6F69C2DE42B532388A1614163850D7 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Light_tA2F349FE839781469A0344CF6039B51512394275_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = __this->get_m_InstanceId_6();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * L_1;
		L_1 = Object_FindObjectFromInstanceID_m0AD731D3F583CBBDC7DC0E08B38F742B447FA44A(L_0, /*hidden argument*/NULL);
		return ((Light_tA2F349FE839781469A0344CF6039B51512394275 *)CastclassSealed((RuntimeObject*)L_1, Light_tA2F349FE839781469A0344CF6039B51512394275_il2cpp_TypeInfo_var));
	}
}
IL2CPP_EXTERN_C  Light_tA2F349FE839781469A0344CF6039B51512394275 * VisibleLight_get_light_mB3719D47BF6F69C2DE42B532388A1614163850D7_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	Light_tA2F349FE839781469A0344CF6039B51512394275 * _returnValue;
	_returnValue = VisibleLight_get_light_mB3719D47BF6F69C2DE42B532388A1614163850D7(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.LightType UnityEngine.Rendering.VisibleLight::get_lightType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VisibleLight_get_lightType_m7D69884E96A92F41619FCE4E419593C9FE28A6C9 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_LightType_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  int32_t VisibleLight_get_lightType_m7D69884E96A92F41619FCE4E419593C9FE28A6C9_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = VisibleLight_get_lightType_m7D69884E96A92F41619FCE4E419593C9FE28A6C9(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Color UnityEngine.Rendering.VisibleLight::get_finalColor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  VisibleLight_get_finalColor_m58FCC6FC876E90AF728669588D220B23F72D8F81 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method)
{
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_0 = __this->get_m_FinalColor_1();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  VisibleLight_get_finalColor_m58FCC6FC876E90AF728669588D220B23F72D8F81_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  _returnValue;
	_returnValue = VisibleLight_get_finalColor_m58FCC6FC876E90AF728669588D220B23F72D8F81(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Matrix4x4 UnityEngine.Rendering.VisibleLight::get_localToWorldMatrix()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  VisibleLight_get_localToWorldMatrix_m8A49A19AA3E7DE6782FAEF618D4BCE5DAAE26636 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method)
{
	Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  L_0 = __this->get_m_LocalToWorldMatrix_3();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  VisibleLight_get_localToWorldMatrix_m8A49A19AA3E7DE6782FAEF618D4BCE5DAAE26636_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  _returnValue;
	_returnValue = VisibleLight_get_localToWorldMatrix_m8A49A19AA3E7DE6782FAEF618D4BCE5DAAE26636(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.Rendering.VisibleLight::get_range()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float VisibleLight_get_range_mDEEB57B3AF09E27E2B70852C3F263BED748962F4 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_Range_4();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float VisibleLight_get_range_mDEEB57B3AF09E27E2B70852C3F263BED748962F4_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	float _returnValue;
	_returnValue = VisibleLight_get_range_mDEEB57B3AF09E27E2B70852C3F263BED748962F4(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.Rendering.VisibleLight::get_spotAngle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float VisibleLight_get_spotAngle_m5B090DAE3C02F6CA75F5FE4B807DAD408FD652F4 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_SpotAngle_5();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float VisibleLight_get_spotAngle_m5B090DAE3C02F6CA75F5FE4B807DAD408FD652F4_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	float _returnValue;
	_returnValue = VisibleLight_get_spotAngle_m5B090DAE3C02F6CA75F5FE4B807DAD408FD652F4(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Rendering.VisibleLight::Equals(UnityEngine.Rendering.VisibleLight)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VisibleLight_Equals_mFA9ADFF9549B6E1582730CE2A980CDC0AB53B5CF (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  ___other0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t G_B9_0 = 0;
	{
		int32_t L_0 = __this->get_m_LightType_0();
		VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  L_1 = ___other0;
		int32_t L_2 = L_1.get_m_LightType_0();
		if ((!(((uint32_t)L_0) == ((uint32_t)L_2))))
		{
			goto IL_008c;
		}
	}
	{
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * L_3 = __this->get_address_of_m_FinalColor_1();
		VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  L_4 = ___other0;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_5 = L_4.get_m_FinalColor_1();
		bool L_6;
		L_6 = Color_Equals_mB531F532B5F7BE6168CFD4A6C89358C16F058D00((Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)L_3, L_5, /*hidden argument*/NULL);
		if (!L_6)
		{
			goto IL_008c;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * L_7 = __this->get_address_of_m_ScreenRect_2();
		VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  L_8 = ___other0;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_9 = L_8.get_m_ScreenRect_2();
		bool L_10;
		L_10 = Rect_Equals_mC9EE5E0C234DB174AC16E653ED8D32BB4D356BB8((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)L_7, L_9, /*hidden argument*/NULL);
		if (!L_10)
		{
			goto IL_008c;
		}
	}
	{
		Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * L_11 = __this->get_address_of_m_LocalToWorldMatrix_3();
		VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  L_12 = ___other0;
		Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  L_13 = L_12.get_m_LocalToWorldMatrix_3();
		bool L_14;
		L_14 = Matrix4x4_Equals_mAE7AC284A922B094E4ACCC04A1C48B247E9A7997((Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 *)L_11, L_13, /*hidden argument*/NULL);
		if (!L_14)
		{
			goto IL_008c;
		}
	}
	{
		float* L_15 = __this->get_address_of_m_Range_4();
		VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  L_16 = ___other0;
		float L_17 = L_16.get_m_Range_4();
		bool L_18;
		L_18 = Single_Equals_m298A3A849F30B9900813BE6DD98AE6810CDBE914((float*)L_15, L_17, /*hidden argument*/NULL);
		if (!L_18)
		{
			goto IL_008c;
		}
	}
	{
		float* L_19 = __this->get_address_of_m_SpotAngle_5();
		VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  L_20 = ___other0;
		float L_21 = L_20.get_m_SpotAngle_5();
		bool L_22;
		L_22 = Single_Equals_m298A3A849F30B9900813BE6DD98AE6810CDBE914((float*)L_19, L_21, /*hidden argument*/NULL);
		if (!L_22)
		{
			goto IL_008c;
		}
	}
	{
		int32_t L_23 = __this->get_m_InstanceId_6();
		VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  L_24 = ___other0;
		int32_t L_25 = L_24.get_m_InstanceId_6();
		if ((!(((uint32_t)L_23) == ((uint32_t)L_25))))
		{
			goto IL_008c;
		}
	}
	{
		int32_t L_26 = __this->get_m_Flags_7();
		VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  L_27 = ___other0;
		int32_t L_28 = L_27.get_m_Flags_7();
		G_B9_0 = ((((int32_t)L_26) == ((int32_t)L_28))? 1 : 0);
		goto IL_008d;
	}

IL_008c:
	{
		G_B9_0 = 0;
	}

IL_008d:
	{
		V_0 = (bool)G_B9_0;
		goto IL_0090;
	}

IL_0090:
	{
		bool L_29 = V_0;
		return L_29;
	}
}
IL2CPP_EXTERN_C  bool VisibleLight_Equals_mFA9ADFF9549B6E1582730CE2A980CDC0AB53B5CF_AdjustorThunk (RuntimeObject * __this, VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	bool _returnValue;
	_returnValue = VisibleLight_Equals_mFA9ADFF9549B6E1582730CE2A980CDC0AB53B5CF(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Rendering.VisibleLight::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VisibleLight_Equals_m31A93583009988A9E375AF5F30584EA2384A6792 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	int32_t G_B5_0 = 0;
	{
		RuntimeObject * L_0 = ___obj0;
		V_0 = (bool)((((RuntimeObject*)(RuntimeObject *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000d;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_0027;
	}

IL_000d:
	{
		RuntimeObject * L_2 = ___obj0;
		if (!((RuntimeObject *)IsInstSealed((RuntimeObject*)L_2, VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B_il2cpp_TypeInfo_var)))
		{
			goto IL_0023;
		}
	}
	{
		RuntimeObject * L_3 = ___obj0;
		bool L_4;
		L_4 = VisibleLight_Equals_mFA9ADFF9549B6E1582730CE2A980CDC0AB53B5CF((VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *)__this, ((*(VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *)((VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *)UnBox(L_3, VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B_il2cpp_TypeInfo_var)))), /*hidden argument*/NULL);
		G_B5_0 = ((int32_t)(L_4));
		goto IL_0024;
	}

IL_0023:
	{
		G_B5_0 = 0;
	}

IL_0024:
	{
		V_1 = (bool)G_B5_0;
		goto IL_0027;
	}

IL_0027:
	{
		bool L_5 = V_1;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool VisibleLight_Equals_m31A93583009988A9E375AF5F30584EA2384A6792_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	bool _returnValue;
	_returnValue = VisibleLight_Equals_m31A93583009988A9E375AF5F30584EA2384A6792(_thisAdjusted, ___obj0, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Rendering.VisibleLight::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VisibleLight_GetHashCode_mB02BF000082BA2DB2E7034052814FC078ABBCA79 (VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		int32_t L_0 = __this->get_m_LightType_0();
		V_0 = L_0;
		int32_t L_1 = V_0;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * L_2 = __this->get_address_of_m_FinalColor_1();
		int32_t L_3;
		L_3 = Color_GetHashCode_mAF5E7EE6AFA983D3FA5E3D316E672EE1511F97CF((Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)L_2, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_1, (int32_t)((int32_t)397)))^(int32_t)L_3));
		int32_t L_4 = V_0;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * L_5 = __this->get_address_of_m_ScreenRect_2();
		int32_t L_6;
		L_6 = Rect_GetHashCode_mE5841C54528B29D5E85173AF1973326793AF9311((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)L_5, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_4, (int32_t)((int32_t)397)))^(int32_t)L_6));
		int32_t L_7 = V_0;
		Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * L_8 = __this->get_address_of_m_LocalToWorldMatrix_3();
		int32_t L_9;
		L_9 = Matrix4x4_GetHashCode_m102B903082CD1C786C221268A19679820E365B59((Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 *)L_8, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_7, (int32_t)((int32_t)397)))^(int32_t)L_9));
		int32_t L_10 = V_0;
		float* L_11 = __this->get_address_of_m_Range_4();
		int32_t L_12;
		L_12 = Single_GetHashCode_m7662E1812DDDBC85D464398740CFFC3588DFB2C9((float*)L_11, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_10, (int32_t)((int32_t)397)))^(int32_t)L_12));
		int32_t L_13 = V_0;
		float* L_14 = __this->get_address_of_m_SpotAngle_5();
		int32_t L_15;
		L_15 = Single_GetHashCode_m7662E1812DDDBC85D464398740CFFC3588DFB2C9((float*)L_14, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_13, (int32_t)((int32_t)397)))^(int32_t)L_15));
		int32_t L_16 = V_0;
		int32_t L_17 = __this->get_m_InstanceId_6();
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_16, (int32_t)((int32_t)397)))^(int32_t)L_17));
		int32_t L_18 = V_0;
		int32_t L_19 = __this->get_m_Flags_7();
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_18, (int32_t)((int32_t)397)))^(int32_t)L_19));
		int32_t L_20 = V_0;
		V_1 = L_20;
		goto IL_00a1;
	}

IL_00a1:
	{
		int32_t L_21 = V_1;
		return L_21;
	}
}
IL2CPP_EXTERN_C  int32_t VisibleLight_GetHashCode_mB02BF000082BA2DB2E7034052814FC078ABBCA79_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B * _thisAdjusted = reinterpret_cast<VisibleLight_t72748A05D894B8E7CBD6F03B858BEE8E8CAF065B *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = VisibleLight_GetHashCode_mB02BF000082BA2DB2E7034052814FC078ABBCA79(_thisAdjusted, method);
	return _returnValue;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean UnityEngine.Rendering.VisibleReflectionProbe::Equals(UnityEngine.Rendering.VisibleReflectionProbe)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VisibleReflectionProbe_Equals_m08619B5CE171C4CAB0DDC2E71D621D017675CA43 (VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * __this, VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  ___other0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t G_B10_0 = 0;
	{
		Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * L_0 = __this->get_address_of_m_Bounds_0();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_1 = ___other0;
		Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  L_2 = L_1.get_m_Bounds_0();
		bool L_3;
		L_3 = Bounds_Equals_mC558BE6FE3614F7B42F5E22D1F155194A0E3DD0F((Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *)L_0, L_2, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_009d;
		}
	}
	{
		Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * L_4 = __this->get_address_of_m_LocalToWorldMatrix_1();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_5 = ___other0;
		Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461  L_6 = L_5.get_m_LocalToWorldMatrix_1();
		bool L_7;
		L_7 = Matrix4x4_Equals_mAE7AC284A922B094E4ACCC04A1C48B247E9A7997((Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 *)L_4, L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_009d;
		}
	}
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * L_8 = __this->get_address_of_m_HdrData_2();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_9 = ___other0;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_10 = L_9.get_m_HdrData_2();
		bool L_11;
		L_11 = Vector4_Equals_m0919D35807550372D1748193EB31E4C5E406AE61_inline((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)L_8, L_10, /*hidden argument*/NULL);
		if (!L_11)
		{
			goto IL_009d;
		}
	}
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_12 = __this->get_address_of_m_Center_3();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_13 = ___other0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_14 = L_13.get_m_Center_3();
		bool L_15;
		L_15 = Vector3_Equals_mA92800CD98ED6A42DD7C55C5DB22DAB4DEAA6397((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)L_12, L_14, /*hidden argument*/NULL);
		if (!L_15)
		{
			goto IL_009d;
		}
	}
	{
		float* L_16 = __this->get_address_of_m_BlendDistance_4();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_17 = ___other0;
		float L_18 = L_17.get_m_BlendDistance_4();
		bool L_19;
		L_19 = Single_Equals_m298A3A849F30B9900813BE6DD98AE6810CDBE914((float*)L_16, L_18, /*hidden argument*/NULL);
		if (!L_19)
		{
			goto IL_009d;
		}
	}
	{
		int32_t L_20 = __this->get_m_Importance_5();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_21 = ___other0;
		int32_t L_22 = L_21.get_m_Importance_5();
		if ((!(((uint32_t)L_20) == ((uint32_t)L_22))))
		{
			goto IL_009d;
		}
	}
	{
		int32_t L_23 = __this->get_m_BoxProjection_6();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_24 = ___other0;
		int32_t L_25 = L_24.get_m_BoxProjection_6();
		if ((!(((uint32_t)L_23) == ((uint32_t)L_25))))
		{
			goto IL_009d;
		}
	}
	{
		int32_t L_26 = __this->get_m_InstanceId_7();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_27 = ___other0;
		int32_t L_28 = L_27.get_m_InstanceId_7();
		if ((!(((uint32_t)L_26) == ((uint32_t)L_28))))
		{
			goto IL_009d;
		}
	}
	{
		int32_t L_29 = __this->get_m_TextureId_8();
		VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  L_30 = ___other0;
		int32_t L_31 = L_30.get_m_TextureId_8();
		G_B10_0 = ((((int32_t)L_29) == ((int32_t)L_31))? 1 : 0);
		goto IL_009e;
	}

IL_009d:
	{
		G_B10_0 = 0;
	}

IL_009e:
	{
		V_0 = (bool)G_B10_0;
		goto IL_00a1;
	}

IL_00a1:
	{
		bool L_32 = V_0;
		return L_32;
	}
}
IL2CPP_EXTERN_C  bool VisibleReflectionProbe_Equals_m08619B5CE171C4CAB0DDC2E71D621D017675CA43_AdjustorThunk (RuntimeObject * __this, VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * _thisAdjusted = reinterpret_cast<VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 *>(__this + _offset);
	bool _returnValue;
	_returnValue = VisibleReflectionProbe_Equals_m08619B5CE171C4CAB0DDC2E71D621D017675CA43(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Rendering.VisibleReflectionProbe::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool VisibleReflectionProbe_Equals_m41A430F408D799CCB4C2762658C36C5EBEFF6BE7 (VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	int32_t G_B5_0 = 0;
	{
		RuntimeObject * L_0 = ___obj0;
		V_0 = (bool)((((RuntimeObject*)(RuntimeObject *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000d;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_0027;
	}

IL_000d:
	{
		RuntimeObject * L_2 = ___obj0;
		if (!((RuntimeObject *)IsInstSealed((RuntimeObject*)L_2, VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51_il2cpp_TypeInfo_var)))
		{
			goto IL_0023;
		}
	}
	{
		RuntimeObject * L_3 = ___obj0;
		bool L_4;
		L_4 = VisibleReflectionProbe_Equals_m08619B5CE171C4CAB0DDC2E71D621D017675CA43((VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 *)__this, ((*(VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 *)((VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 *)UnBox(L_3, VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51_il2cpp_TypeInfo_var)))), /*hidden argument*/NULL);
		G_B5_0 = ((int32_t)(L_4));
		goto IL_0024;
	}

IL_0023:
	{
		G_B5_0 = 0;
	}

IL_0024:
	{
		V_1 = (bool)G_B5_0;
		goto IL_0027;
	}

IL_0027:
	{
		bool L_5 = V_1;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool VisibleReflectionProbe_Equals_m41A430F408D799CCB4C2762658C36C5EBEFF6BE7_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * _thisAdjusted = reinterpret_cast<VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 *>(__this + _offset);
	bool _returnValue;
	_returnValue = VisibleReflectionProbe_Equals_m41A430F408D799CCB4C2762658C36C5EBEFF6BE7(_thisAdjusted, ___obj0, method);
	return _returnValue;
}
// System.Int32 UnityEngine.Rendering.VisibleReflectionProbe::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t VisibleReflectionProbe_GetHashCode_m0C0B7C72A3CCDE769DF19DE1F4847A6B97CADF4E (VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * L_0 = __this->get_address_of_m_Bounds_0();
		int32_t L_1;
		L_1 = Bounds_GetHashCode_m822D1DF4F57180495A4322AADD3FD173C6FC3A1B((Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *)L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		int32_t L_2 = V_0;
		Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 * L_3 = __this->get_address_of_m_LocalToWorldMatrix_1();
		int32_t L_4;
		L_4 = Matrix4x4_GetHashCode_m102B903082CD1C786C221268A19679820E365B59((Matrix4x4_tDE7FF4F2E2EA284F6EFE00D627789D0E5B8B4461 *)L_3, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_2, (int32_t)((int32_t)397)))^(int32_t)L_4));
		int32_t L_5 = V_0;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * L_6 = __this->get_address_of_m_HdrData_2();
		int32_t L_7;
		L_7 = Vector4_GetHashCode_mCA7B312F8CA141F6F25BABDDF406F3D2BDD5E895((Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 *)L_6, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_5, (int32_t)((int32_t)397)))^(int32_t)L_7));
		int32_t L_8 = V_0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_9 = __this->get_address_of_m_Center_3();
		int32_t L_10;
		L_10 = Vector3_GetHashCode_m9F18401DA6025110A012F55BBB5ACABD36FA9A0A((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)L_9, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_8, (int32_t)((int32_t)397)))^(int32_t)L_10));
		int32_t L_11 = V_0;
		float* L_12 = __this->get_address_of_m_BlendDistance_4();
		int32_t L_13;
		L_13 = Single_GetHashCode_m7662E1812DDDBC85D464398740CFFC3588DFB2C9((float*)L_12, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_11, (int32_t)((int32_t)397)))^(int32_t)L_13));
		int32_t L_14 = V_0;
		int32_t L_15 = __this->get_m_Importance_5();
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_14, (int32_t)((int32_t)397)))^(int32_t)L_15));
		int32_t L_16 = V_0;
		int32_t L_17 = __this->get_m_BoxProjection_6();
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_16, (int32_t)((int32_t)397)))^(int32_t)L_17));
		int32_t L_18 = V_0;
		int32_t L_19 = __this->get_m_InstanceId_7();
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_18, (int32_t)((int32_t)397)))^(int32_t)L_19));
		int32_t L_20 = V_0;
		int32_t L_21 = __this->get_m_TextureId_8();
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_20, (int32_t)((int32_t)397)))^(int32_t)L_21));
		int32_t L_22 = V_0;
		V_1 = L_22;
		goto IL_00b6;
	}

IL_00b6:
	{
		int32_t L_23 = V_1;
		return L_23;
	}
}
IL2CPP_EXTERN_C  int32_t VisibleReflectionProbe_GetHashCode_m0C0B7C72A3CCDE769DF19DE1F4847A6B97CADF4E_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 * _thisAdjusted = reinterpret_cast<VisibleReflectionProbe_tE111B448A222148708F68ACE9B8DB1AC3D9E8F51 *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = VisibleReflectionProbe_GetHashCode_m0C0B7C72A3CCDE769DF19DE1F4847A6B97CADF4E(_thisAdjusted, method);
	return _returnValue;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.WaitForEndOfFrame::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForEndOfFrame__ctor_mEA41FB4A9236A64D566330BBE25F9902DEBB2EEA (WaitForEndOfFrame_t082FDFEAAFF92937632C357C39E55C84B8FD06D4 * __this, const RuntimeMethod* method)
{
	{
		YieldInstruction__ctor_mD8203310B47F2C36BED3EEC00CA1944C9D941AEF(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.WaitForSeconds
IL2CPP_EXTERN_C void WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshal_pinvoke(const WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013& unmarshaled, WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Seconds_0 = unmarshaled.get_m_Seconds_0();
}
IL2CPP_EXTERN_C void WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshal_pinvoke_back(const WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_pinvoke& marshaled, WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013& unmarshaled)
{
	float unmarshaled_m_Seconds_temp_0 = 0.0f;
	unmarshaled_m_Seconds_temp_0 = marshaled.___m_Seconds_0;
	unmarshaled.set_m_Seconds_0(unmarshaled_m_Seconds_temp_0);
}
// Conversion method for clean up from marshalling of: UnityEngine.WaitForSeconds
IL2CPP_EXTERN_C void WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshal_pinvoke_cleanup(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.WaitForSeconds
IL2CPP_EXTERN_C void WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshal_com(const WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013& unmarshaled, WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_com& marshaled)
{
	marshaled.___m_Seconds_0 = unmarshaled.get_m_Seconds_0();
}
IL2CPP_EXTERN_C void WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshal_com_back(const WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_com& marshaled, WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013& unmarshaled)
{
	float unmarshaled_m_Seconds_temp_0 = 0.0f;
	unmarshaled_m_Seconds_temp_0 = marshaled.___m_Seconds_0;
	unmarshaled.set_m_Seconds_0(unmarshaled_m_Seconds_temp_0);
}
// Conversion method for clean up from marshalling of: UnityEngine.WaitForSeconds
IL2CPP_EXTERN_C void WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshal_com_cleanup(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.WaitForSeconds::.ctor(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForSeconds__ctor_mD298C4CB9532BBBDE172FC40F3397E30504038D4 (WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * __this, float ___seconds0, const RuntimeMethod* method)
{
	{
		YieldInstruction__ctor_mD8203310B47F2C36BED3EEC00CA1944C9D941AEF(__this, /*hidden argument*/NULL);
		float L_0 = ___seconds0;
		__this->set_m_Seconds_0(L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Single UnityEngine.WaitForSecondsRealtime::get_waitTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float WaitForSecondsRealtime_get_waitTime_m04ED4EACCB01E49DEC7E0E5A83789068A3525BC2 (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, const RuntimeMethod* method)
{
	{
		float L_0 = __this->get_U3CwaitTimeU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.WaitForSecondsRealtime::set_waitTime(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForSecondsRealtime_set_waitTime_m241120AEE2F1BDD0DC3077D865C7C3D878448268 (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, float ___value0, const RuntimeMethod* method)
{
	{
		float L_0 = ___value0;
		__this->set_U3CwaitTimeU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.Boolean UnityEngine.WaitForSecondsRealtime::get_keepWaiting()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WaitForSecondsRealtime_get_keepWaiting_m96E9697A6DA22E3537EE2ED3823523C05838844D (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	{
		float L_0 = __this->get_m_WaitUntilTime_1();
		V_1 = (bool)((((float)L_0) < ((float)(0.0f)))? 1 : 0);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_0026;
		}
	}
	{
		float L_2;
		L_2 = Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B(/*hidden argument*/NULL);
		float L_3;
		L_3 = WaitForSecondsRealtime_get_waitTime_m04ED4EACCB01E49DEC7E0E5A83789068A3525BC2_inline(__this, /*hidden argument*/NULL);
		__this->set_m_WaitUntilTime_1(((float)il2cpp_codegen_add((float)L_2, (float)L_3)));
	}

IL_0026:
	{
		float L_4;
		L_4 = Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B(/*hidden argument*/NULL);
		float L_5 = __this->get_m_WaitUntilTime_1();
		V_0 = (bool)((((float)L_4) < ((float)L_5))? 1 : 0);
		bool L_6 = V_0;
		V_2 = (bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		bool L_7 = V_2;
		if (!L_7)
		{
			goto IL_0045;
		}
	}
	{
		VirtActionInvoker0::Invoke(8 /* System.Void UnityEngine.CustomYieldInstruction::Reset() */, __this);
	}

IL_0045:
	{
		bool L_8 = V_0;
		V_3 = L_8;
		goto IL_0049;
	}

IL_0049:
	{
		bool L_9 = V_3;
		return L_9;
	}
}
// System.Void UnityEngine.WaitForSecondsRealtime::.ctor(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForSecondsRealtime__ctor_m7A69DE38F96121145BE8108B5AA62C789059F225 (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, float ___time0, const RuntimeMethod* method)
{
	{
		__this->set_m_WaitUntilTime_1((-1.0f));
		CustomYieldInstruction__ctor_m01929E3EEB78B751510038B32D889061960DA1BE(__this, /*hidden argument*/NULL);
		float L_0 = ___time0;
		WaitForSecondsRealtime_set_waitTime_m241120AEE2F1BDD0DC3077D865C7C3D878448268_inline(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.WaitForSecondsRealtime::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForSecondsRealtime_Reset_m6CB6F149A3EC3BA4ADB6A78FD8A05F82246E9B01 (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, const RuntimeMethod* method)
{
	{
		__this->set_m_WaitUntilTime_1((-1.0f));
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.Collections.LowLevel.Unsafe.WriteAccessRequiredAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WriteAccessRequiredAttribute__ctor_m832267CA67398C994C2B666B00253CD9959610B9 (WriteAccessRequiredAttribute_t801D798894A40E3789DE39CC4BE0D3B04B852DCA * __this, const RuntimeMethod* method)
{
	{
		Attribute__ctor_m5C1862A7DFC2C25A4797A8C5F681FBB5CB53ECE1(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
IL2CPP_EXTERN_C void YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshal_pinvoke(const YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF& unmarshaled, YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_pinvoke& marshaled)
{
}
IL2CPP_EXTERN_C void YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshal_pinvoke_back(const YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_pinvoke& marshaled, YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
IL2CPP_EXTERN_C void YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshal_pinvoke_cleanup(YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
IL2CPP_EXTERN_C void YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshal_com(const YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF& unmarshaled, YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_com& marshaled)
{
}
IL2CPP_EXTERN_C void YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshal_com_back(const YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_com& marshaled, YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
IL2CPP_EXTERN_C void YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshal_com_cleanup(YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.YieldInstruction::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void YieldInstruction__ctor_mD8203310B47F2C36BED3EEC00CA1944C9D941AEF (YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_AdvertisingIdentifierCallback_t718F15DCE2CA38B886F324F079A4B41774A3042B (AdvertisingIdentifierCallback_t718F15DCE2CA38B886F324F079A4B41774A3042B * __this, String_t* ___advertisingId0, bool ___trackingEnabled1, String_t* ___errorMsg2, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(char*, int32_t, char*);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Marshaling of parameter '___advertisingId0' to native representation
	char* ____advertisingId0_marshaled = NULL;
	____advertisingId0_marshaled = il2cpp_codegen_marshal_string(___advertisingId0);

	// Marshaling of parameter '___errorMsg2' to native representation
	char* ____errorMsg2_marshaled = NULL;
	____errorMsg2_marshaled = il2cpp_codegen_marshal_string(___errorMsg2);

	// Native function invocation
	il2cppPInvokeFunc(____advertisingId0_marshaled, static_cast<int32_t>(___trackingEnabled1), ____errorMsg2_marshaled);

	// Marshaling cleanup of parameter '___advertisingId0' native representation
	il2cpp_codegen_marshal_free(____advertisingId0_marshaled);
	____advertisingId0_marshaled = NULL;

	// Marshaling cleanup of parameter '___errorMsg2' native representation
	il2cpp_codegen_marshal_free(____errorMsg2_marshaled);
	____errorMsg2_marshaled = NULL;

}
// System.Void UnityEngine.Application/AdvertisingIdentifierCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AdvertisingIdentifierCallback__ctor_m53451DA47B2B096A02263052686591C6EB81B42E (AdvertisingIdentifierCallback_t718F15DCE2CA38B886F324F079A4B41774A3042B * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.Application/AdvertisingIdentifierCallback::Invoke(System.String,System.Boolean,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AdvertisingIdentifierCallback_Invoke_mD1D1ADD410605FE714A7200A54F6BDFB3D62423E (AdvertisingIdentifierCallback_t718F15DCE2CA38B886F324F079A4B41774A3042B * __this, String_t* ___advertisingId0, bool ___trackingEnabled1, String_t* ___errorMsg2, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 3)
			{
				// open
				typedef void (*FunctionPointerType) (String_t*, bool, String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___advertisingId0, ___trackingEnabled1, ___errorMsg2, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, String_t*, bool, String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___advertisingId0, ___trackingEnabled1, ___errorMsg2, targetMethod);
			}
		}
		else if (___parameterCount != 3)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker2< bool, String_t* >::Invoke(targetMethod, ___advertisingId0, ___trackingEnabled1, ___errorMsg2);
					else
						GenericVirtActionInvoker2< bool, String_t* >::Invoke(targetMethod, ___advertisingId0, ___trackingEnabled1, ___errorMsg2);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker2< bool, String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___advertisingId0, ___trackingEnabled1, ___errorMsg2);
					else
						VirtActionInvoker2< bool, String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___advertisingId0, ___trackingEnabled1, ___errorMsg2);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (String_t*, bool, String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___advertisingId0, ___trackingEnabled1, ___errorMsg2, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker3< String_t*, bool, String_t* >::Invoke(targetMethod, targetThis, ___advertisingId0, ___trackingEnabled1, ___errorMsg2);
					else
						GenericVirtActionInvoker3< String_t*, bool, String_t* >::Invoke(targetMethod, targetThis, ___advertisingId0, ___trackingEnabled1, ___errorMsg2);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker3< String_t*, bool, String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___advertisingId0, ___trackingEnabled1, ___errorMsg2);
					else
						VirtActionInvoker3< String_t*, bool, String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___advertisingId0, ___trackingEnabled1, ___errorMsg2);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (String_t*, bool, String_t*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___advertisingId0, ___trackingEnabled1, ___errorMsg2, targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, String_t*, bool, String_t*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___advertisingId0, ___trackingEnabled1, ___errorMsg2, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.Application/AdvertisingIdentifierCallback::BeginInvoke(System.String,System.Boolean,System.String,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* AdvertisingIdentifierCallback_BeginInvoke_mDD08B4C34A4273AA2B779DFD8A6CBA23DB04D7BA (AdvertisingIdentifierCallback_t718F15DCE2CA38B886F324F079A4B41774A3042B * __this, String_t* ___advertisingId0, bool ___trackingEnabled1, String_t* ___errorMsg2, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback3, RuntimeObject * ___object4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[4] = {0};
	__d_args[0] = ___advertisingId0;
	__d_args[1] = Box(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var, &___trackingEnabled1);
	__d_args[2] = ___errorMsg2;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback3, (RuntimeObject*)___object4);;
}
// System.Void UnityEngine.Application/AdvertisingIdentifierCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AdvertisingIdentifierCallback_EndInvoke_m521A4146D8BAAD9494BF1AC92C6B4439FC580D1C (AdvertisingIdentifierCallback_t718F15DCE2CA38B886F324F079A4B41774A3042B * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_LogCallback_t8C3C9B1E0F185E2A25D09DE10DD8414898698BBD (LogCallback_t8C3C9B1E0F185E2A25D09DE10DD8414898698BBD * __this, String_t* ___condition0, String_t* ___stackTrace1, int32_t ___type2, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(char*, char*, int32_t);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Marshaling of parameter '___condition0' to native representation
	char* ____condition0_marshaled = NULL;
	____condition0_marshaled = il2cpp_codegen_marshal_string(___condition0);

	// Marshaling of parameter '___stackTrace1' to native representation
	char* ____stackTrace1_marshaled = NULL;
	____stackTrace1_marshaled = il2cpp_codegen_marshal_string(___stackTrace1);

	// Native function invocation
	il2cppPInvokeFunc(____condition0_marshaled, ____stackTrace1_marshaled, ___type2);

	// Marshaling cleanup of parameter '___condition0' native representation
	il2cpp_codegen_marshal_free(____condition0_marshaled);
	____condition0_marshaled = NULL;

	// Marshaling cleanup of parameter '___stackTrace1' native representation
	il2cpp_codegen_marshal_free(____stackTrace1_marshaled);
	____stackTrace1_marshaled = NULL;

}
// System.Void UnityEngine.Application/LogCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LogCallback__ctor_mB5F165ECC180A20258EF4EFF589D88FB9F9E9C57 (LogCallback_t8C3C9B1E0F185E2A25D09DE10DD8414898698BBD * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.Application/LogCallback::Invoke(System.String,System.String,UnityEngine.LogType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LogCallback_Invoke_m5503AB0FDB4D9D1A8FFE13283321AF278B7F6C4E (LogCallback_t8C3C9B1E0F185E2A25D09DE10DD8414898698BBD * __this, String_t* ___condition0, String_t* ___stackTrace1, int32_t ___type2, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 3)
			{
				// open
				typedef void (*FunctionPointerType) (String_t*, String_t*, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___condition0, ___stackTrace1, ___type2, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, String_t*, String_t*, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___condition0, ___stackTrace1, ___type2, targetMethod);
			}
		}
		else if (___parameterCount != 3)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker2< String_t*, int32_t >::Invoke(targetMethod, ___condition0, ___stackTrace1, ___type2);
					else
						GenericVirtActionInvoker2< String_t*, int32_t >::Invoke(targetMethod, ___condition0, ___stackTrace1, ___type2);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker2< String_t*, int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___condition0, ___stackTrace1, ___type2);
					else
						VirtActionInvoker2< String_t*, int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___condition0, ___stackTrace1, ___type2);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (String_t*, String_t*, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___condition0, ___stackTrace1, ___type2, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker3< String_t*, String_t*, int32_t >::Invoke(targetMethod, targetThis, ___condition0, ___stackTrace1, ___type2);
					else
						GenericVirtActionInvoker3< String_t*, String_t*, int32_t >::Invoke(targetMethod, targetThis, ___condition0, ___stackTrace1, ___type2);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker3< String_t*, String_t*, int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___condition0, ___stackTrace1, ___type2);
					else
						VirtActionInvoker3< String_t*, String_t*, int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___condition0, ___stackTrace1, ___type2);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (String_t*, String_t*, int32_t, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___condition0, ___stackTrace1, ___type2, targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, String_t*, String_t*, int32_t, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___condition0, ___stackTrace1, ___type2, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.Application/LogCallback::BeginInvoke(System.String,System.String,UnityEngine.LogType,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* LogCallback_BeginInvoke_m346CFB69BAB75EF96F9EBA2B3C312A1AD1D4147F (LogCallback_t8C3C9B1E0F185E2A25D09DE10DD8414898698BBD * __this, String_t* ___condition0, String_t* ___stackTrace1, int32_t ___type2, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback3, RuntimeObject * ___object4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&LogType_tF490DBF8368BD4EBA703B2824CB76A853820F773_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[4] = {0};
	__d_args[0] = ___condition0;
	__d_args[1] = ___stackTrace1;
	__d_args[2] = Box(LogType_tF490DBF8368BD4EBA703B2824CB76A853820F773_il2cpp_TypeInfo_var, &___type2);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback3, (RuntimeObject*)___object4);;
}
// System.Void UnityEngine.Application/LogCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LogCallback_EndInvoke_m940C8D1C936259607F04EA27DA8FBB2828FC9280 (LogCallback_t8C3C9B1E0F185E2A25D09DE10DD8414898698BBD * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_LowMemoryCallback_tF94AC614EDACA9AD4CEA3DE77FF8EFF5DA1E5240 (LowMemoryCallback_tF94AC614EDACA9AD4CEA3DE77FF8EFF5DA1E5240 * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void UnityEngine.Application/LowMemoryCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LowMemoryCallback__ctor_m91C04CE7D7A323B50CA6A73B23949639E1EA53C3 (LowMemoryCallback_tF94AC614EDACA9AD4CEA3DE77FF8EFF5DA1E5240 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.Application/LowMemoryCallback::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LowMemoryCallback_Invoke_mDF9C72A7F7CD34CC8FAED88642864AE193742437 (LowMemoryCallback_tF94AC614EDACA9AD4CEA3DE77FF8EFF5DA1E5240 * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult UnityEngine.Application/LowMemoryCallback::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* LowMemoryCallback_BeginInvoke_mF446F2B2F047BC877D3819B38D1CB0AFC4C4D953 (LowMemoryCallback_tF94AC614EDACA9AD4CEA3DE77FF8EFF5DA1E5240 * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void UnityEngine.Application/LowMemoryCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LowMemoryCallback_EndInvoke_mB653B34015F110168720FED3201FDD6D2B235212 (LowMemoryCallback_tF94AC614EDACA9AD4CEA3DE77FF8EFF5DA1E5240 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Rendering.BatchRendererGroup/OnPerformCulling::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnPerformCulling__ctor_m1862F8A67E8CA14A19B80DE61BBC1881DF945E9F (OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// Unity.Jobs.JobHandle UnityEngine.Rendering.BatchRendererGroup/OnPerformCulling::Invoke(UnityEngine.Rendering.BatchRendererGroup,UnityEngine.Rendering.BatchCullingContext)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  OnPerformCulling_Invoke_m804E8422831E63707E5582FBBBFEF08E8A100525 (OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB * __this, BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A * ___rendererGroup0, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  ___cullingContext1, const RuntimeMethod* method)
{
	JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  result;
	memset((&result), 0, sizeof(result));
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 2)
			{
				// open
				typedef JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  (*FunctionPointerType) (BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66 , const RuntimeMethod*);
				result = ((FunctionPointerType)targetMethodPointer)(___rendererGroup0, ___cullingContext1, targetMethod);
			}
			else
			{
				// closed
				typedef JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  (*FunctionPointerType) (void*, BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66 , const RuntimeMethod*);
				result = ((FunctionPointerType)targetMethodPointer)(targetThis, ___rendererGroup0, ___cullingContext1, targetMethod);
			}
		}
		else if (___parameterCount != 2)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						result = GenericInterfaceFuncInvoker1< JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 , BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  >::Invoke(targetMethod, ___rendererGroup0, ___cullingContext1);
					else
						result = GenericVirtFuncInvoker1< JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 , BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  >::Invoke(targetMethod, ___rendererGroup0, ___cullingContext1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						result = InterfaceFuncInvoker1< JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 , BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___rendererGroup0, ___cullingContext1);
					else
						result = VirtFuncInvoker1< JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 , BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___rendererGroup0, ___cullingContext1);
				}
			}
			else
			{
				typedef JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  (*FunctionPointerType) (BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66 , const RuntimeMethod*);
				result = ((FunctionPointerType)targetMethodPointer)(___rendererGroup0, ___cullingContext1, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						result = GenericInterfaceFuncInvoker2< JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 , BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  >::Invoke(targetMethod, targetThis, ___rendererGroup0, ___cullingContext1);
					else
						result = GenericVirtFuncInvoker2< JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 , BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  >::Invoke(targetMethod, targetThis, ___rendererGroup0, ___cullingContext1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						result = InterfaceFuncInvoker2< JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 , BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___rendererGroup0, ___cullingContext1);
					else
						result = VirtFuncInvoker2< JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 , BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___rendererGroup0, ___cullingContext1);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  (*FunctionPointerType) (BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66 , const RuntimeMethod*);
					result = ((FunctionPointerType)targetMethodPointer)(___rendererGroup0, ___cullingContext1, targetMethod);
				}
				else
				{
					typedef JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  (*FunctionPointerType) (void*, BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A *, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66 , const RuntimeMethod*);
					result = ((FunctionPointerType)targetMethodPointer)(targetThis, ___rendererGroup0, ___cullingContext1, targetMethod);
				}
			}
		}
	}
	return result;
}
// System.IAsyncResult UnityEngine.Rendering.BatchRendererGroup/OnPerformCulling::BeginInvoke(UnityEngine.Rendering.BatchRendererGroup,UnityEngine.Rendering.BatchCullingContext,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* OnPerformCulling_BeginInvoke_mAF6E29B6BAC52D4DCAD0C87B8C6939B94566EAA1 (OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB * __this, BatchRendererGroup_t68C1EAC6F7158DC1C02C16D4E343397D5EC4574A * ___rendererGroup0, BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66  ___cullingContext1, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback2, RuntimeObject * ___object3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[3] = {0};
	__d_args[0] = ___rendererGroup0;
	__d_args[1] = Box(BatchCullingContext_t26E634F354C4F3915108C34A32FD32118FFE1F66_il2cpp_TypeInfo_var, &___cullingContext1);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);;
}
// Unity.Jobs.JobHandle UnityEngine.Rendering.BatchRendererGroup/OnPerformCulling::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  OnPerformCulling_EndInvoke_m643216ACF662C78BD6F98E09FA5AA45F92E2F9F0 (OnPerformCulling_t44E5FE326B88CD7B1F07F3DDD2433D2D70161AEB * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
	return *(JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847 *)UnBox ((RuntimeObject*)__result);;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.BeforeRenderHelper/OrderBlock
IL2CPP_EXTERN_C void OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshal_pinvoke(const OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2& unmarshaled, OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshaled_pinvoke& marshaled)
{
	marshaled.___order_0 = unmarshaled.get_order_0();
	marshaled.___callback_1 = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(unmarshaled.get_callback_1()));
}
IL2CPP_EXTERN_C void OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshal_pinvoke_back(const OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshaled_pinvoke& marshaled, OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2& unmarshaled)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t unmarshaled_order_temp_0 = 0;
	unmarshaled_order_temp_0 = marshaled.___order_0;
	unmarshaled.set_order_0(unmarshaled_order_temp_0);
	unmarshaled.set_callback_1(il2cpp_codegen_marshal_function_ptr_to_delegate<UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099>(marshaled.___callback_1, UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099_il2cpp_TypeInfo_var));
}
// Conversion method for clean up from marshalling of: UnityEngine.BeforeRenderHelper/OrderBlock
IL2CPP_EXTERN_C void OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshal_pinvoke_cleanup(OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.BeforeRenderHelper/OrderBlock
IL2CPP_EXTERN_C void OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshal_com(const OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2& unmarshaled, OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshaled_com& marshaled)
{
	marshaled.___order_0 = unmarshaled.get_order_0();
	marshaled.___callback_1 = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(unmarshaled.get_callback_1()));
}
IL2CPP_EXTERN_C void OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshal_com_back(const OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshaled_com& marshaled, OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2& unmarshaled)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t unmarshaled_order_temp_0 = 0;
	unmarshaled_order_temp_0 = marshaled.___order_0;
	unmarshaled.set_order_0(unmarshaled_order_temp_0);
	unmarshaled.set_callback_1(il2cpp_codegen_marshal_function_ptr_to_delegate<UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099>(marshaled.___callback_1, UnityAction_t22E545F8BE0A62EE051C6A83E209587A0DB1C099_il2cpp_TypeInfo_var));
}
// Conversion method for clean up from marshalling of: UnityEngine.BeforeRenderHelper/OrderBlock
IL2CPP_EXTERN_C void OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshal_com_cleanup(OrderBlock_t0B106828F588BC2F0B9895425E6FD39EDA45C1E2_marshaled_com& marshaled)
{
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Camera/CameraCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CameraCallback__ctor_m6E26A220911F56F3E8936DDD217ED76A15B1915E (CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.Camera/CameraCallback::Invoke(UnityEngine.Camera)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CameraCallback_Invoke_m52ACC6D0C6BA5A247A24DB9C63D4340B2EF97B24 (CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * __this, Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * ___cam0, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___cam0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___cam0, targetMethod);
			}
		}
		else if (___parameterCount != 1)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, ___cam0);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, ___cam0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___cam0);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___cam0);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___cam0, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * >::Invoke(targetMethod, targetThis, ___cam0);
					else
						GenericVirtActionInvoker1< Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * >::Invoke(targetMethod, targetThis, ___cam0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___cam0);
					else
						VirtActionInvoker1< Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___cam0);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C *, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___cam0, targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C *, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___cam0, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.Camera/CameraCallback::BeginInvoke(UnityEngine.Camera,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CameraCallback_BeginInvoke_m7DD0D3DB7F6ACCBFE090C1E2EEE9BBD065A0925D (CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * __this, Camera_tC44E094BAB53AFC8A014C6F9CFCE11F4FC38006C * ___cam0, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	void *__d_args[2] = {0};
	__d_args[0] = ___cam0;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);;
}
// System.Void UnityEngine.Camera/CameraCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CameraCallback_EndInvoke_m2CF9596F172FF401AAF5A606BE966E3D08F62DB9 (CameraCallback_tD9E7B69E561CE2EFDEEDB0E7F1406AC52247160D * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Camera/GateFitMode UnityEngine.Camera/GateFitParameters::get_mode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GateFitParameters_get_mode_m77B9128212158F79B56A96B464863CF425DAD42E (GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CmodeU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t GateFitParameters_get_mode_m77B9128212158F79B56A96B464863CF425DAD42E_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D * _thisAdjusted = reinterpret_cast<GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = GateFitParameters_get_mode_m77B9128212158F79B56A96B464863CF425DAD42E_inline(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.Camera/GateFitParameters::get_aspect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GateFitParameters_get_aspect_m58C24572B24DA38AE4973691C26C0822A0D5C58A (GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D * __this, const RuntimeMethod* method)
{
	{
		float L_0 = __this->get_U3CaspectU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_EXTERN_C  float GateFitParameters_get_aspect_m58C24572B24DA38AE4973691C26C0822A0D5C58A_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D * _thisAdjusted = reinterpret_cast<GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D *>(__this + _offset);
	float _returnValue;
	_returnValue = GateFitParameters_get_aspect_m58C24572B24DA38AE4973691C26C0822A0D5C58A_inline(_thisAdjusted, method);
	return _returnValue;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.Camera/RenderRequest
IL2CPP_EXTERN_C void RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshal_pinvoke(const RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94& unmarshaled, RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshaled_pinvoke& marshaled)
{
	Exception_t* ___m_ResultRT_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_ResultRT' of type 'RenderRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_ResultRT_1Exception, NULL);
}
IL2CPP_EXTERN_C void RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshal_pinvoke_back(const RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshaled_pinvoke& marshaled, RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94& unmarshaled)
{
	Exception_t* ___m_ResultRT_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_ResultRT' of type 'RenderRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_ResultRT_1Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.Camera/RenderRequest
IL2CPP_EXTERN_C void RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshal_pinvoke_cleanup(RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.Camera/RenderRequest
IL2CPP_EXTERN_C void RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshal_com(const RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94& unmarshaled, RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshaled_com& marshaled)
{
	Exception_t* ___m_ResultRT_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_ResultRT' of type 'RenderRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_ResultRT_1Exception, NULL);
}
IL2CPP_EXTERN_C void RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshal_com_back(const RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshaled_com& marshaled, RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94& unmarshaled)
{
	Exception_t* ___m_ResultRT_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_ResultRT' of type 'RenderRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_ResultRT_1Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.Camera/RenderRequest
IL2CPP_EXTERN_C void RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshal_com_cleanup(RenderRequest_t7DEDFA6AAA1C8D381280183054C328F26BBCCE94_marshaled_com& marshaled)
{
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_StateChanged_tAE96F0A8860BFCD704179F6C1F376A6FAE3E25E0 (StateChanged_tAE96F0A8860BFCD704179F6C1F376A6FAE3E25E0 * __this, CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C  ___sphere0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C );
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc(___sphere0);

}
// System.Void UnityEngine.CullingGroup/StateChanged::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateChanged__ctor_mBBB5FB739CB1D1206034FFDE998AE8342CC5C0C2 (StateChanged_tAE96F0A8860BFCD704179F6C1F376A6FAE3E25E0 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.CullingGroup/StateChanged::Invoke(UnityEngine.CullingGroupEvent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateChanged_Invoke_m6CD13C3770E1EB709C4B125F69F7E4CE6539814D (StateChanged_tAE96F0A8860BFCD704179F6C1F376A6FAE3E25E0 * __this, CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C  ___sphere0, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___sphere0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___sphere0, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C  >::Invoke(targetMethod, targetThis, ___sphere0);
					else
						GenericVirtActionInvoker1< CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C  >::Invoke(targetMethod, targetThis, ___sphere0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___sphere0);
					else
						VirtActionInvoker1< CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___sphere0);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)((RuntimeObject*)(reinterpret_cast<RuntimeObject*>(&___sphere0) - 1), targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C , const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___sphere0, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.CullingGroup/StateChanged::BeginInvoke(UnityEngine.CullingGroupEvent,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* StateChanged_BeginInvoke_m70DAA3720650BA61CA34446A5E19736213E82D4D (StateChanged_tAE96F0A8860BFCD704179F6C1F376A6FAE3E25E0 * __this, CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C  ___sphere0, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[2] = {0};
	__d_args[0] = Box(CullingGroupEvent_t58E1718FD0A5FC5037538BD223DCF1385014185C_il2cpp_TypeInfo_var, &___sphere0);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);;
}
// System.Void UnityEngine.CullingGroup/StateChanged::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateChanged_EndInvoke_m742AAC097C6A02605BF7FB6AA283CA24C021ED65 (StateChanged_tAE96F0A8860BFCD704179F6C1F376A6FAE3E25E0 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_DisplaysUpdatedDelegate_tC6A6AD44FAD98C9E28479FFF4BD3D9932458A6A1 (DisplaysUpdatedDelegate_tC6A6AD44FAD98C9E28479FFF4BD3D9932458A6A1 * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void UnityEngine.Display/DisplaysUpdatedDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DisplaysUpdatedDelegate__ctor_mE01841FD1E938AA63EF9D1153CB40E44543A78BE (DisplaysUpdatedDelegate_tC6A6AD44FAD98C9E28479FFF4BD3D9932458A6A1 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.Display/DisplaysUpdatedDelegate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DisplaysUpdatedDelegate_Invoke_mBABCF33A27A4E0A5FBC06AECECA79FBF4293E7F9 (DisplaysUpdatedDelegate_tC6A6AD44FAD98C9E28479FFF4BD3D9932458A6A1 * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult UnityEngine.Display/DisplaysUpdatedDelegate::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* DisplaysUpdatedDelegate_BeginInvoke_m42DDA570D68BFAD055E2FEBB75FBE79EFEE2752F (DisplaysUpdatedDelegate_tC6A6AD44FAD98C9E28479FFF4BD3D9932458A6A1 * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void UnityEngine.Display/DisplaysUpdatedDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DisplaysUpdatedDelegate_EndInvoke_mBE00DC8335AF5142275DCCE3C5CEBC4ED0F60937 (DisplaysUpdatedDelegate_tC6A6AD44FAD98C9E28479FFF4BD3D9932458A6A1 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.Jobs.LowLevel.Unsafe.JobsUtility/JobScheduleParameters::.ctor(System.Void*,System.IntPtr,Unity.Jobs.JobHandle,Unity.Jobs.LowLevel.Unsafe.ScheduleMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JobScheduleParameters__ctor_m7BAC662AF5FA4A96429644CC676D3179A5B143F8 (JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8 * __this, void* ___i_jobData0, intptr_t ___i_reflectionData1, JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  ___i_dependency2, int32_t ___i_scheduleMode3, const RuntimeMethod* method)
{
	{
		JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  L_0 = ___i_dependency2;
		__this->set_Dependency_0(L_0);
		void* L_1 = ___i_jobData0;
		intptr_t L_2;
		L_2 = IntPtr_op_Explicit_mBD40223EE90BDDF40A24C0F321D3398DEA300495((void*)(void*)L_1, /*hidden argument*/NULL);
		__this->set_JobDataPtr_3((intptr_t)L_2);
		intptr_t L_3 = ___i_reflectionData1;
		__this->set_ReflectionData_2((intptr_t)L_3);
		int32_t L_4 = ___i_scheduleMode3;
		__this->set_ScheduleMode_1(L_4);
		return;
	}
}
IL2CPP_EXTERN_C  void JobScheduleParameters__ctor_m7BAC662AF5FA4A96429644CC676D3179A5B143F8_AdjustorThunk (RuntimeObject * __this, void* ___i_jobData0, intptr_t ___i_reflectionData1, JobHandle_t8AEB8D31C25D7774C71D62B0C662525E6E36D847  ___i_dependency2, int32_t ___i_scheduleMode3, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8 * _thisAdjusted = reinterpret_cast<JobScheduleParameters_tA29064729507A938ACB05D9F98B2C4A6977E3EF8 *>(__this + _offset);
	JobScheduleParameters__ctor_m7BAC662AF5FA4A96429644CC676D3179A5B143F8(_thisAdjusted, ___i_jobData0, ___i_reflectionData1, ___i_dependency2, ___i_scheduleMode3, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_PanicFunction__tFB4D850E5B848FFEF210623F5669284D723544EB (PanicFunction__tFB4D850E5B848FFEF210623F5669284D723544EB * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void Unity.Jobs.LowLevel.Unsafe.JobsUtility/PanicFunction_::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PanicFunction___ctor_mB3D415ACBD0EFCD1A8B86C3522139B925FB3692A (PanicFunction__tFB4D850E5B848FFEF210623F5669284D723544EB * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void Unity.Jobs.LowLevel.Unsafe.JobsUtility/PanicFunction_::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PanicFunction__Invoke_m1A61124D09B3DB67123E6E5FD12D5C290D425B66 (PanicFunction__tFB4D850E5B848FFEF210623F5669284D723544EB * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult Unity.Jobs.LowLevel.Unsafe.JobsUtility/PanicFunction_::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PanicFunction__BeginInvoke_m282584A1964E17E399D5E2684C080EA5E6ABB3D0 (PanicFunction__tFB4D850E5B848FFEF210623F5669284D723544EB * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void Unity.Jobs.LowLevel.Unsafe.JobsUtility/PanicFunction_::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PanicFunction__EndInvoke_m22F4B852847D10CABDCF03A8634443FB30509961 (PanicFunction__tFB4D850E5B848FFEF210623F5669284D723544EB * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Experimental.GlobalIllumination.Lightmapping/<>c::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_m2A00D547FF8F6F8A03666B4737BB9A0620719987 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 * L_0 = (U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 *)il2cpp_codegen_object_new(U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826_il2cpp_TypeInfo_var);
		U3CU3Ec__ctor_m8F825BEC75A119B6CDDA0985A3F7BA3DEA8AD5B2(L_0, /*hidden argument*/NULL);
		((U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826_il2cpp_TypeInfo_var))->set_U3CU3E9_0(L_0);
		return;
	}
}
// System.Void UnityEngine.Experimental.GlobalIllumination.Lightmapping/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m8F825BEC75A119B6CDDA0985A3F7BA3DEA8AD5B2 (U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Experimental.GlobalIllumination.Lightmapping/<>c::<.cctor>b__7_0(UnityEngine.Light[],Unity.Collections.NativeArray`1<UnityEngine.Experimental.GlobalIllumination.LightDataGI>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec_U3C_cctorU3Eb__7_0_m84A19BB5BB12263A1E3C52F1B351E3A24BE546C7 (U3CU3Ec_t0CD29EFB17F20C410B16682BBAC2B78C5BD98826 * __this, LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9* ___requests0, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  ___lightsOutput1, const RuntimeMethod* method)
{
	DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7  V_0;
	memset((&V_0), 0, sizeof(V_0));
	PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E  V_1;
	memset((&V_1), 0, sizeof(V_1));
	SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D  V_2;
	memset((&V_2), 0, sizeof(V_2));
	RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985  V_3;
	memset((&V_3), 0, sizeof(V_3));
	DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D  V_4;
	memset((&V_4), 0, sizeof(V_4));
	Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B  V_5;
	memset((&V_5), 0, sizeof(V_5));
	LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2  V_6;
	memset((&V_6), 0, sizeof(V_6));
	int32_t V_7 = 0;
	Light_tA2F349FE839781469A0344CF6039B51512394275 * V_8 = NULL;
	int32_t V_9 = 0;
	int32_t V_10 = 0;
	bool V_11 = false;
	{
		il2cpp_codegen_initobj((&V_0), sizeof(DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7 ));
		il2cpp_codegen_initobj((&V_1), sizeof(PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E ));
		il2cpp_codegen_initobj((&V_2), sizeof(SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D ));
		il2cpp_codegen_initobj((&V_3), sizeof(RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985 ));
		il2cpp_codegen_initobj((&V_4), sizeof(DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D ));
		il2cpp_codegen_initobj((&V_5), sizeof(Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B ));
		il2cpp_codegen_initobj((&V_6), sizeof(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 ));
		V_7 = 0;
		goto IL_0146;
	}

IL_0041:
	{
		LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9* L_0 = ___requests0;
		int32_t L_1 = V_7;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		V_8 = L_3;
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_4 = V_8;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = Light_get_type_mDBBEC33D93952330EED5B02B15865C59D5C355A0(L_4, /*hidden argument*/NULL);
		V_10 = L_5;
		int32_t L_6 = V_10;
		V_9 = L_6;
		int32_t L_7 = V_9;
		switch (L_7)
		{
			case 0:
			{
				goto IL_00bc;
			}
			case 1:
			{
				goto IL_0075;
			}
			case 2:
			{
				goto IL_009a;
			}
			case 3:
			{
				goto IL_00de;
			}
			case 4:
			{
				goto IL_0100;
			}
		}
	}
	{
		goto IL_0122;
	}

IL_0075:
	{
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_8 = V_8;
		LightmapperUtils_Extract_mCBEC26CC920C0D87DF6E25417533923E26CB6DFC(L_8, (DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7 *)(&V_0), /*hidden argument*/NULL);
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_9 = V_8;
		LightmapperUtils_Extract_mACAC5E823E243A53EDD2A01CF857DD16C3FDBE2A(L_9, (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		LightDataGI_Init_m135DF5CF6CBECA4CBA0AC71F9CDEEF8DE25606DB((LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 *)(&V_6), (DirectionalLight_t64077C15074628F61CE703ED3A168AA8AB7F0AB7 *)(&V_0), (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		goto IL_0133;
	}

IL_009a:
	{
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_10 = V_8;
		LightmapperUtils_Extract_mB11D8F3B35F96E176A89517A25CD1A54DCBD7D6E(L_10, (PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E *)(&V_1), /*hidden argument*/NULL);
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_11 = V_8;
		LightmapperUtils_Extract_mACAC5E823E243A53EDD2A01CF857DD16C3FDBE2A(L_11, (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		LightDataGI_Init_m4E8BEBD383D5F6F1A1EDFEC763A718A7271C22A6((LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 *)(&V_6), (PointLight_t543DD0461FFC4EA9F3B08CF9F4BF5BB2164D167E *)(&V_1), (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		goto IL_0133;
	}

IL_00bc:
	{
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_12 = V_8;
		LightmapperUtils_Extract_mB1572C38F682F043180745B7A231FBE07CD205E4(L_12, (SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D *)(&V_2), /*hidden argument*/NULL);
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_13 = V_8;
		LightmapperUtils_Extract_mACAC5E823E243A53EDD2A01CF857DD16C3FDBE2A(L_13, (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		LightDataGI_Init_mC9948FAC4A191C99E3E7D94677B7CFD241857C86((LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 *)(&V_6), (SpotLight_tAE1210A6FAE3F41CA62CB63E9012C9BED625AC9D *)(&V_2), (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		goto IL_0133;
	}

IL_00de:
	{
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_14 = V_8;
		LightmapperUtils_Extract_mEABF77895D51E1CA5FD380682539C3DD3FC8A91C(L_14, (RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985 *)(&V_3), /*hidden argument*/NULL);
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_15 = V_8;
		LightmapperUtils_Extract_mACAC5E823E243A53EDD2A01CF857DD16C3FDBE2A(L_15, (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		LightDataGI_Init_mA0DF9747C6AD308EAAF2A9530B4225A3D65BB092((LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 *)(&V_6), (RectangleLight_t9F02AC7041621773D7676A5E2707898F24892985 *)(&V_3), (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		goto IL_0133;
	}

IL_0100:
	{
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_16 = V_8;
		LightmapperUtils_Extract_m93B350DDA0CB5B624054835BAF46C177472E9212(L_16, (DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D *)(&V_4), /*hidden argument*/NULL);
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_17 = V_8;
		LightmapperUtils_Extract_mACAC5E823E243A53EDD2A01CF857DD16C3FDBE2A(L_17, (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		LightDataGI_Init_mB96C3F3E00F10DD0806BD3DB93B58C2299D59E94((LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 *)(&V_6), (DiscLight_t2F3E542C8536D7FE93D943F5336DCCE844D6CB8D *)(&V_4), (Cookie_tEC43B52DA6FD8E9BFF0B54D063671606E01E039B *)(&V_5), /*hidden argument*/NULL);
		goto IL_0133;
	}

IL_0122:
	{
		Light_tA2F349FE839781469A0344CF6039B51512394275 * L_18 = V_8;
		NullCheck(L_18);
		int32_t L_19;
		L_19 = Object_GetInstanceID_m7CF962BC1DB5C03F3522F88728CB2F514582B501(L_18, /*hidden argument*/NULL);
		LightDataGI_InitNoBake_mF600D612DE9A1CE4355C61317F6173E1AAEFBD57((LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 *)(&V_6), L_19, /*hidden argument*/NULL);
		goto IL_0133;
	}

IL_0133:
	{
		int32_t L_20 = V_7;
		LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2  L_21 = V_6;
		IL2CPP_NATIVEARRAY_SET_ITEM(LightDataGI_t0C34AB69E4E96717FD276B35116C798A641D44F2 , ((NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2 *)(&___lightsOutput1))->___m_Buffer_0, L_20, (L_21));
		int32_t L_22 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add((int32_t)L_22, (int32_t)1));
	}

IL_0146:
	{
		int32_t L_23 = V_7;
		LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9* L_24 = ___requests0;
		NullCheck(L_24);
		V_11 = (bool)((((int32_t)L_23) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_24)->max_length)))))? 1 : 0);
		bool L_25 = V_11;
		if (L_25)
		{
			goto IL_0041;
		}
	}
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Experimental.GlobalIllumination.Lightmapping/RequestLightsDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RequestLightsDelegate__ctor_m47823FBD9D2EE4ABA5EE8D889BBBC0783FB10A42 (RequestLightsDelegate_t48C36AFA6015405AE4069BB1F3623AF3BC51FDA0 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.Experimental.GlobalIllumination.Lightmapping/RequestLightsDelegate::Invoke(UnityEngine.Light[],Unity.Collections.NativeArray`1<UnityEngine.Experimental.GlobalIllumination.LightDataGI>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RequestLightsDelegate_Invoke_m8BC0D55744A3FA2E75444AC72B3D3E4FB858BECB (RequestLightsDelegate_t48C36AFA6015405AE4069BB1F3623AF3BC51FDA0 * __this, LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9* ___requests0, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  ___lightsOutput1, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 2)
			{
				// open
				typedef void (*FunctionPointerType) (LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2 , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___requests0, ___lightsOutput1, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2 , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___requests0, ___lightsOutput1, targetMethod);
			}
		}
		else if (___parameterCount != 2)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  >::Invoke(targetMethod, ___requests0, ___lightsOutput1);
					else
						GenericVirtActionInvoker1< NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  >::Invoke(targetMethod, ___requests0, ___lightsOutput1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___requests0, ___lightsOutput1);
					else
						VirtActionInvoker1< NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___requests0, ___lightsOutput1);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2 , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___requests0, ___lightsOutput1, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker2< LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  >::Invoke(targetMethod, targetThis, ___requests0, ___lightsOutput1);
					else
						GenericVirtActionInvoker2< LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  >::Invoke(targetMethod, targetThis, ___requests0, ___lightsOutput1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker2< LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___requests0, ___lightsOutput1);
					else
						VirtActionInvoker2< LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___requests0, ___lightsOutput1);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2 , const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___requests0, ___lightsOutput1, targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9*, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2 , const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___requests0, ___lightsOutput1, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.Experimental.GlobalIllumination.Lightmapping/RequestLightsDelegate::BeginInvoke(UnityEngine.Light[],Unity.Collections.NativeArray`1<UnityEngine.Experimental.GlobalIllumination.LightDataGI>,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* RequestLightsDelegate_BeginInvoke_m75482E3D4E28205DCB4A202F5C144CB7C95622A6 (RequestLightsDelegate_t48C36AFA6015405AE4069BB1F3623AF3BC51FDA0 * __this, LightU5BU5D_t1376F7CA1DDFC128499DDA9516CC40DDEE59EAC9* ___requests0, NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2  ___lightsOutput1, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback2, RuntimeObject * ___object3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[3] = {0};
	__d_args[0] = ___requests0;
	__d_args[1] = Box(NativeArray_1_tF6A10DD2511425342F2B1B19CF0EA313D4F300D2_il2cpp_TypeInfo_var, &___lightsOutput1);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);;
}
// System.Void UnityEngine.Experimental.GlobalIllumination.Lightmapping/RequestLightsDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RequestLightsDelegate_EndInvoke_mA1FF787B6F3182ACF6157D13F9A84AFCBB66EE60 (RequestLightsDelegate_t48C36AFA6015405AE4069BB1F3623AF3BC51FDA0 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Mesh/MeshDataArray::AcquireReadOnlyMeshData(UnityEngine.Mesh,System.IntPtr*)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_AcquireReadOnlyMeshData_mA8D0A6B091478A148E7572C4D9F6C9F93A1321BE (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, intptr_t* ___datas1, const RuntimeMethod* method)
{
	typedef void (*MeshDataArray_AcquireReadOnlyMeshData_mA8D0A6B091478A148E7572C4D9F6C9F93A1321BE_ftn) (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 *, intptr_t*);
	static MeshDataArray_AcquireReadOnlyMeshData_mA8D0A6B091478A148E7572C4D9F6C9F93A1321BE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (MeshDataArray_AcquireReadOnlyMeshData_mA8D0A6B091478A148E7572C4D9F6C9F93A1321BE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Mesh/MeshDataArray::AcquireReadOnlyMeshData(UnityEngine.Mesh,System.IntPtr*)");
	_il2cpp_icall_func(___mesh0, ___datas1);
}
// System.Void UnityEngine.Mesh/MeshDataArray::AcquireReadOnlyMeshDatas(UnityEngine.Mesh[],System.IntPtr*,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_AcquireReadOnlyMeshDatas_m80768A6BCF4F95D32DA2E718E67046EA44CCCA6B (MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, intptr_t* ___datas1, int32_t ___count2, const RuntimeMethod* method)
{
	typedef void (*MeshDataArray_AcquireReadOnlyMeshDatas_m80768A6BCF4F95D32DA2E718E67046EA44CCCA6B_ftn) (MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8*, intptr_t*, int32_t);
	static MeshDataArray_AcquireReadOnlyMeshDatas_m80768A6BCF4F95D32DA2E718E67046EA44CCCA6B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (MeshDataArray_AcquireReadOnlyMeshDatas_m80768A6BCF4F95D32DA2E718E67046EA44CCCA6B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Mesh/MeshDataArray::AcquireReadOnlyMeshDatas(UnityEngine.Mesh[],System.IntPtr*,System.Int32)");
	_il2cpp_icall_func(___meshes0, ___datas1, ___count2);
}
// System.Void UnityEngine.Mesh/MeshDataArray::ReleaseMeshDatas(System.IntPtr*,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ReleaseMeshDatas_m4B049CAB0F9836B576B4C92A779F68FE951DE2D8 (intptr_t* ___datas0, int32_t ___count1, const RuntimeMethod* method)
{
	typedef void (*MeshDataArray_ReleaseMeshDatas_m4B049CAB0F9836B576B4C92A779F68FE951DE2D8_ftn) (intptr_t*, int32_t);
	static MeshDataArray_ReleaseMeshDatas_m4B049CAB0F9836B576B4C92A779F68FE951DE2D8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (MeshDataArray_ReleaseMeshDatas_m4B049CAB0F9836B576B4C92A779F68FE951DE2D8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Mesh/MeshDataArray::ReleaseMeshDatas(System.IntPtr*,System.Int32)");
	_il2cpp_icall_func(___datas0, ___count1);
}
// System.Void UnityEngine.Mesh/MeshDataArray::CreateNewMeshDatas(System.IntPtr*,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_CreateNewMeshDatas_m0C3B36987DB4F94DCC2129BE8E41F56C4C99ADC2 (intptr_t* ___datas0, int32_t ___count1, const RuntimeMethod* method)
{
	typedef void (*MeshDataArray_CreateNewMeshDatas_m0C3B36987DB4F94DCC2129BE8E41F56C4C99ADC2_ftn) (intptr_t*, int32_t);
	static MeshDataArray_CreateNewMeshDatas_m0C3B36987DB4F94DCC2129BE8E41F56C4C99ADC2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (MeshDataArray_CreateNewMeshDatas_m0C3B36987DB4F94DCC2129BE8E41F56C4C99ADC2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Mesh/MeshDataArray::CreateNewMeshDatas(System.IntPtr*,System.Int32)");
	_il2cpp_icall_func(___datas0, ___count1);
}
// System.Void UnityEngine.Mesh/MeshDataArray::ApplyToMeshesImpl(UnityEngine.Mesh[],System.IntPtr*,System.Int32,UnityEngine.Rendering.MeshUpdateFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ApplyToMeshesImpl_m8335D1328BAD5FDF11D6CCFB90ED1FC9E96F9500 (MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, intptr_t* ___datas1, int32_t ___count2, int32_t ___flags3, const RuntimeMethod* method)
{
	typedef void (*MeshDataArray_ApplyToMeshesImpl_m8335D1328BAD5FDF11D6CCFB90ED1FC9E96F9500_ftn) (MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8*, intptr_t*, int32_t, int32_t);
	static MeshDataArray_ApplyToMeshesImpl_m8335D1328BAD5FDF11D6CCFB90ED1FC9E96F9500_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (MeshDataArray_ApplyToMeshesImpl_m8335D1328BAD5FDF11D6CCFB90ED1FC9E96F9500_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Mesh/MeshDataArray::ApplyToMeshesImpl(UnityEngine.Mesh[],System.IntPtr*,System.Int32,UnityEngine.Rendering.MeshUpdateFlags)");
	_il2cpp_icall_func(___meshes0, ___datas1, ___count2, ___flags3);
}
// System.Void UnityEngine.Mesh/MeshDataArray::ApplyToMeshImpl(UnityEngine.Mesh,System.IntPtr,UnityEngine.Rendering.MeshUpdateFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ApplyToMeshImpl_mF3CA062385320C84B620CAB4031C70E18695E625 (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, intptr_t ___data1, int32_t ___flags2, const RuntimeMethod* method)
{
	typedef void (*MeshDataArray_ApplyToMeshImpl_mF3CA062385320C84B620CAB4031C70E18695E625_ftn) (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 *, intptr_t, int32_t);
	static MeshDataArray_ApplyToMeshImpl_mF3CA062385320C84B620CAB4031C70E18695E625_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (MeshDataArray_ApplyToMeshImpl_mF3CA062385320C84B620CAB4031C70E18695E625_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Mesh/MeshDataArray::ApplyToMeshImpl(UnityEngine.Mesh,System.IntPtr,UnityEngine.Rendering.MeshUpdateFlags)");
	_il2cpp_icall_func(___mesh0, ___data1, ___flags2);
}
// System.Int32 UnityEngine.Mesh/MeshDataArray::get_Length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MeshDataArray_get_Length_mF10B3C18CF5962BD3D2E0490C1EC4351B33F2160 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_m_Length_1();
		return L_0;
	}
}
IL2CPP_EXTERN_C  int32_t MeshDataArray_get_Length_mF10B3C18CF5962BD3D2E0490C1EC4351B33F2160_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * _thisAdjusted = reinterpret_cast<MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = MeshDataArray_get_Length_mF10B3C18CF5962BD3D2E0490C1EC4351B33F2160_inline(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Mesh/MeshDataArray::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_Dispose_m6A2B50484E35E488127841621369799266CBD4F2 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->get_m_Length_1();
		V_0 = (bool)((!(((uint32_t)L_0) <= ((uint32_t)0)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_002f;
		}
	}
	{
		intptr_t* L_2 = __this->get_m_Ptrs_0();
		int32_t L_3 = __this->get_m_Length_1();
		MeshDataArray_ReleaseMeshDatas_m4B049CAB0F9836B576B4C92A779F68FE951DE2D8((intptr_t*)(intptr_t*)L_2, L_3, /*hidden argument*/NULL);
		intptr_t* L_4 = __this->get_m_Ptrs_0();
		UnsafeUtility_Free_mA805168FF1B6728E7DF3AD1DE47400B37F3441F9((void*)(void*)L_4, 4, /*hidden argument*/NULL);
	}

IL_002f:
	{
		__this->set_m_Ptrs_0((intptr_t*)((uintptr_t)0));
		__this->set_m_Length_1(0);
		return;
	}
}
IL2CPP_EXTERN_C  void MeshDataArray_Dispose_m6A2B50484E35E488127841621369799266CBD4F2_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * _thisAdjusted = reinterpret_cast<MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *>(__this + _offset);
	MeshDataArray_Dispose_m6A2B50484E35E488127841621369799266CBD4F2(_thisAdjusted, method);
}
// System.Void UnityEngine.Mesh/MeshDataArray::ApplyToMeshAndDispose(UnityEngine.Mesh,UnityEngine.Rendering.MeshUpdateFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ApplyToMeshAndDispose_m387C3268D1678D98A4387A19E3309C53EAB5DB93 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, int32_t ___flags1, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_0 = ___mesh0;
		NullCheck(L_0);
		bool L_1;
		L_1 = Mesh_get_canAccess_m991B64F0FA651459A7E0DD4526D7EF0384F1792F(L_0, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_1) == ((int32_t)0))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0029;
		}
	}
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_3 = ___mesh0;
		NullCheck(L_3);
		String_t* L_4;
		L_4 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_3, /*hidden argument*/NULL);
		String_t* L_5;
		L_5 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralDA7AEF839C310E50649FABCB16048EC805ED1DCF)), L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2AAF6C7A90E58D7205596DC636D6A02BDB914696)), /*hidden argument*/NULL);
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_6 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_6, L_5, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_6, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray_ApplyToMeshAndDispose_m387C3268D1678D98A4387A19E3309C53EAB5DB93_RuntimeMethod_var)));
	}

IL_0029:
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_7 = ___mesh0;
		intptr_t* L_8 = __this->get_m_Ptrs_0();
		int32_t L_9 = ___flags1;
		MeshDataArray_ApplyToMeshImpl_mF3CA062385320C84B620CAB4031C70E18695E625(L_7, (intptr_t)((*(L_8))), L_9, /*hidden argument*/NULL);
		MeshDataArray_Dispose_m6A2B50484E35E488127841621369799266CBD4F2((MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *)__this, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void MeshDataArray_ApplyToMeshAndDispose_m387C3268D1678D98A4387A19E3309C53EAB5DB93_AdjustorThunk (RuntimeObject * __this, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, int32_t ___flags1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * _thisAdjusted = reinterpret_cast<MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *>(__this + _offset);
	MeshDataArray_ApplyToMeshAndDispose_m387C3268D1678D98A4387A19E3309C53EAB5DB93(_thisAdjusted, ___mesh0, ___flags1, method);
}
// System.Void UnityEngine.Mesh/MeshDataArray::ApplyToMeshesAndDispose(UnityEngine.Mesh[],UnityEngine.Rendering.MeshUpdateFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray_ApplyToMeshesAndDispose_m8C732EB6A9EF32119A0F6AF1C2E157466669E74A (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, int32_t ___flags1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * V_1 = NULL;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	{
		V_0 = 0;
		goto IL_005e;
	}

IL_0005:
	{
		MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* L_0 = ___meshes0;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		V_1 = L_3;
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_4 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_5;
		L_5 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_4, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		V_2 = L_5;
		bool L_6 = V_2;
		if (!L_6)
		{
			goto IL_0030;
		}
	}
	{
		int32_t L_7 = V_0;
		int32_t L_8 = L_7;
		RuntimeObject * L_9 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)), &L_8);
		String_t* L_10;
		L_10 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralE7731045AD45AF27C2F5E740C1F6CAF61BFD563E)), L_9, /*hidden argument*/NULL);
		ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB * L_11 = (ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_mAD2F05A24C92A657CBCA8C43A9A373C53739A283(L_11, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralEC5621377AD9B4098EC3FB34AF35BAA9E6C07B64)), L_10, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_11, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray_ApplyToMeshesAndDispose_m8C732EB6A9EF32119A0F6AF1C2E157466669E74A_RuntimeMethod_var)));
	}

IL_0030:
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_12 = V_1;
		NullCheck(L_12);
		bool L_13;
		L_13 = Mesh_get_canAccess_m991B64F0FA651459A7E0DD4526D7EF0384F1792F(L_12, /*hidden argument*/NULL);
		V_3 = (bool)((((int32_t)L_13) == ((int32_t)0))? 1 : 0);
		bool L_14 = V_3;
		if (!L_14)
		{
			goto IL_0059;
		}
	}
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_15 = V_1;
		NullCheck(L_15);
		String_t* L_16;
		L_16 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_15, /*hidden argument*/NULL);
		int32_t L_17 = V_0;
		int32_t L_18 = L_17;
		RuntimeObject * L_19 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)), &L_18);
		String_t* L_20;
		L_20 = String_Format_m8D1CB0410C35E052A53AE957C914C841E54BAB66(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral3F9A41AFB2F37B2A341E596DC86390141A92BF03)), L_16, L_19, /*hidden argument*/NULL);
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_21 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_21, L_20, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_21, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray_ApplyToMeshesAndDispose_m8C732EB6A9EF32119A0F6AF1C2E157466669E74A_RuntimeMethod_var)));
	}

IL_0059:
	{
		int32_t L_22 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_22, (int32_t)1));
	}

IL_005e:
	{
		int32_t L_23 = V_0;
		int32_t L_24 = __this->get_m_Length_1();
		V_4 = (bool)((((int32_t)L_23) < ((int32_t)L_24))? 1 : 0);
		bool L_25 = V_4;
		if (L_25)
		{
			goto IL_0005;
		}
	}
	{
		MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* L_26 = ___meshes0;
		intptr_t* L_27 = __this->get_m_Ptrs_0();
		int32_t L_28 = __this->get_m_Length_1();
		int32_t L_29 = ___flags1;
		MeshDataArray_ApplyToMeshesImpl_m8335D1328BAD5FDF11D6CCFB90ED1FC9E96F9500(L_26, (intptr_t*)(intptr_t*)L_27, L_28, L_29, /*hidden argument*/NULL);
		MeshDataArray_Dispose_m6A2B50484E35E488127841621369799266CBD4F2((MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *)__this, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void MeshDataArray_ApplyToMeshesAndDispose_m8C732EB6A9EF32119A0F6AF1C2E157466669E74A_AdjustorThunk (RuntimeObject * __this, MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, int32_t ___flags1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * _thisAdjusted = reinterpret_cast<MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *>(__this + _offset);
	MeshDataArray_ApplyToMeshesAndDispose_m8C732EB6A9EF32119A0F6AF1C2E157466669E74A(_thisAdjusted, ___meshes0, ___flags1, method);
}
// System.Void UnityEngine.Mesh/MeshDataArray::.ctor(UnityEngine.Mesh,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray__ctor_mF8939F58B78C2693235E3FE9143637404EB1A0D0 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, bool ___checkReadWrite1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	int32_t G_B5_0 = 0;
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_0 = ___mesh0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_0, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		V_1 = L_1;
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_001c;
		}
	}
	{
		ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB * L_3 = (ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_mAD2F05A24C92A657CBCA8C43A9A373C53739A283(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralEB0A157666700D8227FD4B66A26FDC02035E89BF)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2956576D4D7B715600E40D140A87CD9FCBAF2307)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray__ctor_mF8939F58B78C2693235E3FE9143637404EB1A0D0_RuntimeMethod_var)));
	}

IL_001c:
	{
		bool L_4 = ___checkReadWrite1;
		if (!L_4)
		{
			goto IL_002a;
		}
	}
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_5 = ___mesh0;
		NullCheck(L_5);
		bool L_6;
		L_6 = Mesh_get_canAccess_m991B64F0FA651459A7E0DD4526D7EF0384F1792F(L_5, /*hidden argument*/NULL);
		G_B5_0 = ((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		goto IL_002b;
	}

IL_002a:
	{
		G_B5_0 = 0;
	}

IL_002b:
	{
		V_2 = (bool)G_B5_0;
		bool L_7 = V_2;
		if (!L_7)
		{
			goto IL_004a;
		}
	}
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_8 = ___mesh0;
		NullCheck(L_8);
		String_t* L_9;
		L_9 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_8, /*hidden argument*/NULL);
		String_t* L_10;
		L_10 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralDA7AEF839C310E50649FABCB16048EC805ED1DCF)), L_9, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral2AAF6C7A90E58D7205596DC636D6A02BDB914696)), /*hidden argument*/NULL);
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_11 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_11, L_10, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_11, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray__ctor_mF8939F58B78C2693235E3FE9143637404EB1A0D0_RuntimeMethod_var)));
	}

IL_004a:
	{
		__this->set_m_Length_1(1);
		int32_t L_12;
		L_12 = UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91(/*hidden argument*/UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_RuntimeMethod_var);
		V_0 = L_12;
		int32_t L_13 = V_0;
		int32_t L_14;
		L_14 = UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994(/*hidden argument*/UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_RuntimeMethod_var);
		void* L_15;
		L_15 = UnsafeUtility_Malloc_m18FCC67A056C48A4E0F939D08C43F9E876CA1CF6(((int64_t)((int64_t)L_13)), L_14, 4, /*hidden argument*/NULL);
		__this->set_m_Ptrs_0((intptr_t*)L_15);
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_16 = ___mesh0;
		intptr_t* L_17 = __this->get_m_Ptrs_0();
		MeshDataArray_AcquireReadOnlyMeshData_mA8D0A6B091478A148E7572C4D9F6C9F93A1321BE(L_16, (intptr_t*)(intptr_t*)L_17, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void MeshDataArray__ctor_mF8939F58B78C2693235E3FE9143637404EB1A0D0_AdjustorThunk (RuntimeObject * __this, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___mesh0, bool ___checkReadWrite1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * _thisAdjusted = reinterpret_cast<MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *>(__this + _offset);
	MeshDataArray__ctor_mF8939F58B78C2693235E3FE9143637404EB1A0D0(_thisAdjusted, ___mesh0, ___checkReadWrite1, method);
}
// System.Void UnityEngine.Mesh/MeshDataArray::.ctor(UnityEngine.Mesh[],System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray__ctor_mD35379B2DF108964E9721D9062A82DE52C344D02 (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, int32_t ___meshesCount1, bool ___checkReadWrite2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * V_3 = NULL;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	int32_t G_B8_0 = 0;
	{
		MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* L_0 = ___meshes0;
		NullCheck(L_0);
		int32_t L_1 = ___meshesCount1;
		V_1 = (bool)((((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_0)->max_length)))) < ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0029;
		}
	}
	{
		MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* L_3 = ___meshes0;
		NullCheck(L_3);
		int32_t L_4 = ((int32_t)((int32_t)(((RuntimeArray*)L_3)->max_length)));
		RuntimeObject * L_5 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)), &L_4);
		int32_t L_6 = ___meshesCount1;
		int32_t L_7 = L_6;
		RuntimeObject * L_8 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)), &L_7);
		String_t* L_9;
		L_9 = String_Format_m8D1CB0410C35E052A53AE957C914C841E54BAB66(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralD79748BAD21E0600896A37452D2DDED1006AA1B1)), L_5, L_8, /*hidden argument*/NULL);
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_10 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_10, L_9, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_10, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray__ctor_mD35379B2DF108964E9721D9062A82DE52C344D02_RuntimeMethod_var)));
	}

IL_0029:
	{
		V_2 = 0;
		goto IL_0090;
	}

IL_002d:
	{
		MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* L_11 = ___meshes0;
		int32_t L_12 = V_2;
		NullCheck(L_11);
		int32_t L_13 = L_12;
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_14 = (L_11)->GetAt(static_cast<il2cpp_array_size_t>(L_13));
		V_3 = L_14;
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_15 = V_3;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_16;
		L_16 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_15, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		V_4 = L_16;
		bool L_17 = V_4;
		if (!L_17)
		{
			goto IL_005a;
		}
	}
	{
		int32_t L_18 = V_2;
		int32_t L_19 = L_18;
		RuntimeObject * L_20 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)), &L_19);
		String_t* L_21;
		L_21 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralE7731045AD45AF27C2F5E740C1F6CAF61BFD563E)), L_20, /*hidden argument*/NULL);
		ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB * L_22 = (ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_mAD2F05A24C92A657CBCA8C43A9A373C53739A283(L_22, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralEC5621377AD9B4098EC3FB34AF35BAA9E6C07B64)), L_21, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_22, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray__ctor_mD35379B2DF108964E9721D9062A82DE52C344D02_RuntimeMethod_var)));
	}

IL_005a:
	{
		bool L_23 = ___checkReadWrite2;
		if (!L_23)
		{
			goto IL_0068;
		}
	}
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_24 = V_3;
		NullCheck(L_24);
		bool L_25;
		L_25 = Mesh_get_canAccess_m991B64F0FA651459A7E0DD4526D7EF0384F1792F(L_24, /*hidden argument*/NULL);
		G_B8_0 = ((((int32_t)L_25) == ((int32_t)0))? 1 : 0);
		goto IL_0069;
	}

IL_0068:
	{
		G_B8_0 = 0;
	}

IL_0069:
	{
		V_5 = (bool)G_B8_0;
		bool L_26 = V_5;
		if (!L_26)
		{
			goto IL_008b;
		}
	}
	{
		Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * L_27 = V_3;
		NullCheck(L_27);
		String_t* L_28;
		L_28 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_27, /*hidden argument*/NULL);
		int32_t L_29 = V_2;
		int32_t L_30 = L_29;
		RuntimeObject * L_31 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)), &L_30);
		String_t* L_32;
		L_32 = String_Format_m8D1CB0410C35E052A53AE957C914C841E54BAB66(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral3F9A41AFB2F37B2A341E596DC86390141A92BF03)), L_28, L_31, /*hidden argument*/NULL);
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_33 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_33, L_32, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_33, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray__ctor_mD35379B2DF108964E9721D9062A82DE52C344D02_RuntimeMethod_var)));
	}

IL_008b:
	{
		int32_t L_34 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_34, (int32_t)1));
	}

IL_0090:
	{
		int32_t L_35 = V_2;
		int32_t L_36 = ___meshesCount1;
		V_6 = (bool)((((int32_t)L_35) < ((int32_t)L_36))? 1 : 0);
		bool L_37 = V_6;
		if (L_37)
		{
			goto IL_002d;
		}
	}
	{
		int32_t L_38 = ___meshesCount1;
		__this->set_m_Length_1(L_38);
		int32_t L_39;
		L_39 = UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91(/*hidden argument*/UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_RuntimeMethod_var);
		int32_t L_40 = ___meshesCount1;
		V_0 = ((int32_t)il2cpp_codegen_multiply((int32_t)L_39, (int32_t)L_40));
		int32_t L_41 = V_0;
		int32_t L_42;
		L_42 = UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994(/*hidden argument*/UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_RuntimeMethod_var);
		void* L_43;
		L_43 = UnsafeUtility_Malloc_m18FCC67A056C48A4E0F939D08C43F9E876CA1CF6(((int64_t)((int64_t)L_41)), L_42, 4, /*hidden argument*/NULL);
		__this->set_m_Ptrs_0((intptr_t*)L_43);
		MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* L_44 = ___meshes0;
		intptr_t* L_45 = __this->get_m_Ptrs_0();
		int32_t L_46 = ___meshesCount1;
		MeshDataArray_AcquireReadOnlyMeshDatas_m80768A6BCF4F95D32DA2E718E67046EA44CCCA6B(L_44, (intptr_t*)(intptr_t*)L_45, L_46, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void MeshDataArray__ctor_mD35379B2DF108964E9721D9062A82DE52C344D02_AdjustorThunk (RuntimeObject * __this, MeshU5BU5D_t9083AB7B9B72E4E05B55B7CA24A5D6020DC1C6D8* ___meshes0, int32_t ___meshesCount1, bool ___checkReadWrite2, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * _thisAdjusted = reinterpret_cast<MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *>(__this + _offset);
	MeshDataArray__ctor_mD35379B2DF108964E9721D9062A82DE52C344D02(_thisAdjusted, ___meshes0, ___meshesCount1, ___checkReadWrite2, method);
}
// System.Void UnityEngine.Mesh/MeshDataArray::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MeshDataArray__ctor_mF40C97EC8A5377A058E86FE10773C7EC437D0BAB (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, int32_t ___meshesCount0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		int32_t L_0 = ___meshesCount0;
		V_1 = (bool)((((int32_t)L_0) < ((int32_t)0))? 1 : 0);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = ___meshesCount0;
		int32_t L_3 = L_2;
		RuntimeObject * L_4 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)), &L_3);
		String_t* L_5;
		L_5 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralB54D393654F24720778CBD1865ACD7D51485886C)), L_4, /*hidden argument*/NULL);
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_6 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_6, L_5, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_6, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MeshDataArray__ctor_mF40C97EC8A5377A058E86FE10773C7EC437D0BAB_RuntimeMethod_var)));
	}

IL_001f:
	{
		int32_t L_7 = ___meshesCount0;
		__this->set_m_Length_1(L_7);
		int32_t L_8;
		L_8 = UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91(/*hidden argument*/UnsafeUtility_SizeOf_TisIntPtr_t_m898A6587F20939CD34E3E72B3810C7B0280ECD91_RuntimeMethod_var);
		int32_t L_9 = ___meshesCount0;
		V_0 = ((int32_t)il2cpp_codegen_multiply((int32_t)L_8, (int32_t)L_9));
		int32_t L_10 = V_0;
		int32_t L_11;
		L_11 = UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994(/*hidden argument*/UnsafeUtility_AlignOf_TisIntPtr_t_m6AB814A0687830CB2072610922C3DC026C895994_RuntimeMethod_var);
		void* L_12;
		L_12 = UnsafeUtility_Malloc_m18FCC67A056C48A4E0F939D08C43F9E876CA1CF6(((int64_t)((int64_t)L_10)), L_11, 4, /*hidden argument*/NULL);
		__this->set_m_Ptrs_0((intptr_t*)L_12);
		intptr_t* L_13 = __this->get_m_Ptrs_0();
		int32_t L_14 = ___meshesCount0;
		MeshDataArray_CreateNewMeshDatas_m0C3B36987DB4F94DCC2129BE8E41F56C4C99ADC2((intptr_t*)(intptr_t*)L_13, L_14, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void MeshDataArray__ctor_mF40C97EC8A5377A058E86FE10773C7EC437D0BAB_AdjustorThunk (RuntimeObject * __this, int32_t ___meshesCount0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * _thisAdjusted = reinterpret_cast<MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 *>(__this + _offset);
	MeshDataArray__ctor_mF40C97EC8A5377A058E86FE10773C7EC437D0BAB(_thisAdjusted, ___meshesCount0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  DelegatePInvokeWrapper_CreateOutputMethod_t7A129D00E8823B50AEDD0C9B082C9CB3DF863876 (CreateOutputMethod_t7A129D00E8823B50AEDD0C9B082C9CB3DF863876 * __this, PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A  ___graph0, String_t* ___name1, const RuntimeMethod* method)
{
	typedef PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  (DEFAULT_CALL *PInvokeFunc)(PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A , char*);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Marshaling of parameter '___name1' to native representation
	char* ____name1_marshaled = NULL;
	____name1_marshaled = il2cpp_codegen_marshal_string(___name1);

	// Native function invocation
	PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  returnValue = il2cppPInvokeFunc(___graph0, ____name1_marshaled);

	// Marshaling cleanup of parameter '___name1' native representation
	il2cpp_codegen_marshal_free(____name1_marshaled);
	____name1_marshaled = NULL;

	return returnValue;
}
// System.Void UnityEngine.Playables.PlayableBinding/CreateOutputMethod::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CreateOutputMethod__ctor_m944A1B790F35F52E108EF2CC13BA02BD8DE62EB3 (CreateOutputMethod_t7A129D00E8823B50AEDD0C9B082C9CB3DF863876 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// UnityEngine.Playables.PlayableOutput UnityEngine.Playables.PlayableBinding/CreateOutputMethod::Invoke(UnityEngine.Playables.PlayableGraph,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  CreateOutputMethod_Invoke_mFD551E15D9A6FD8B2C70A2CC96AAD0D2D9D3D109 (CreateOutputMethod_t7A129D00E8823B50AEDD0C9B082C9CB3DF863876 * __this, PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A  ___graph0, String_t* ___name1, const RuntimeMethod* method)
{
	PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  result;
	memset((&result), 0, sizeof(result));
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 2)
			{
				// open
				typedef PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  (*FunctionPointerType) (PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A , String_t*, const RuntimeMethod*);
				result = ((FunctionPointerType)targetMethodPointer)(___graph0, ___name1, targetMethod);
			}
			else
			{
				// closed
				typedef PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  (*FunctionPointerType) (void*, PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A , String_t*, const RuntimeMethod*);
				result = ((FunctionPointerType)targetMethodPointer)(targetThis, ___graph0, ___name1, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						result = GenericInterfaceFuncInvoker2< PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82 , PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A , String_t* >::Invoke(targetMethod, targetThis, ___graph0, ___name1);
					else
						result = GenericVirtFuncInvoker2< PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82 , PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A , String_t* >::Invoke(targetMethod, targetThis, ___graph0, ___name1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						result = InterfaceFuncInvoker2< PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82 , PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A , String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___graph0, ___name1);
					else
						result = VirtFuncInvoker2< PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82 , PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A , String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___graph0, ___name1);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  (*FunctionPointerType) (RuntimeObject*, String_t*, const RuntimeMethod*);
					result = ((FunctionPointerType)targetMethodPointer)((RuntimeObject*)(reinterpret_cast<RuntimeObject*>(&___graph0) - 1), ___name1, targetMethod);
				}
				else
				{
					typedef PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  (*FunctionPointerType) (void*, PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A , String_t*, const RuntimeMethod*);
					result = ((FunctionPointerType)targetMethodPointer)(targetThis, ___graph0, ___name1, targetMethod);
				}
			}
		}
	}
	return result;
}
// System.IAsyncResult UnityEngine.Playables.PlayableBinding/CreateOutputMethod::BeginInvoke(UnityEngine.Playables.PlayableGraph,System.String,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CreateOutputMethod_BeginInvoke_m082AE47F9DFBF0C1787081D2D628E0E5CECCBFF1 (CreateOutputMethod_t7A129D00E8823B50AEDD0C9B082C9CB3DF863876 * __this, PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A  ___graph0, String_t* ___name1, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback2, RuntimeObject * ___object3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[3] = {0};
	__d_args[0] = Box(PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A_il2cpp_TypeInfo_var, &___graph0);
	__d_args[1] = ___name1;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);;
}
// UnityEngine.Playables.PlayableOutput UnityEngine.Playables.PlayableBinding/CreateOutputMethod::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82  CreateOutputMethod_EndInvoke_mAA7AE5BF9E6A38C081A972827A16497ACA9FA9CE (CreateOutputMethod_t7A129D00E8823B50AEDD0C9B082C9CB3DF863876 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	RuntimeObject *__result = il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
	return *(PlayableOutput_tE735DC774F014DB1711310988F2F914C66520F82 *)UnBox ((RuntimeObject*)__result);;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass12_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass12_0__ctor_m66E5B9C72A27F0645F9854522ACE087CE32A5EEE (U3CU3Ec__DisplayClass12_0_tC029C4F11E384EFEF6FD86B7BEC83D295D098769 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass12_0::<Register>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CU3Ec__DisplayClass12_0_U3CRegisterU3Eb__0_m27C1416BAD7AF0A1BF83339C8A03865A6487B234 (U3CU3Ec__DisplayClass12_0_tC029C4F11E384EFEF6FD86B7BEC83D295D098769 * __this, MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Guid_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * L_0 = ___x0;
		NullCheck(L_0);
		Guid_t  L_1;
		L_1 = MessageTypeSubscribers_get_MessageTypeId_m5A873C55E97728BD12BA52B5DB72FFA366992DD9(L_0, /*hidden argument*/NULL);
		Guid_t  L_2 = __this->get_messageId_0();
		IL2CPP_RUNTIME_CLASS_INIT(Guid_t_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Guid_op_Equality_m4C2AA9C31D173525E381965A7246814B4C74D5B0(L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass13_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass13_0__ctor_m75A8930EBA7C6BF81519358930656DAA2FBDDEDB (U3CU3Ec__DisplayClass13_0_t1A8EBE4E3370D09549DE4FD59077B3A7AEAD0C54 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass13_0::<Unregister>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CU3Ec__DisplayClass13_0_U3CUnregisterU3Eb__0_mBA34804D7BB1B4FFE45D077BBB07BFA81C8DCB00 (U3CU3Ec__DisplayClass13_0_t1A8EBE4E3370D09549DE4FD59077B3A7AEAD0C54 * __this, MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Guid_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * L_0 = ___x0;
		NullCheck(L_0);
		Guid_t  L_1;
		L_1 = MessageTypeSubscribers_get_MessageTypeId_m5A873C55E97728BD12BA52B5DB72FFA366992DD9(L_0, /*hidden argument*/NULL);
		Guid_t  L_2 = __this->get_messageId_0();
		IL2CPP_RUNTIME_CLASS_INIT(Guid_t_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Guid_op_Equality_m4C2AA9C31D173525E381965A7246814B4C74D5B0(L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass20_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass20_0__ctor_m2B215926A23E33037D754DFAFDF8459D82243683 (U3CU3Ec__DisplayClass20_0_tEA47E236E3FCEC75772DAF52911B35E8F14766DD * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Networking.PlayerConnection.PlayerConnection/<>c__DisplayClass20_0::<BlockUntilRecvMsg>b__0(UnityEngine.Networking.PlayerConnection.MessageEventArgs)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass20_0_U3CBlockUntilRecvMsgU3Eb__0_m1D6C3976419CFCE0B612D04C135A985707C215E2 (U3CU3Ec__DisplayClass20_0_tEA47E236E3FCEC75772DAF52911B35E8F14766DD * __this, MessageEventArgs_t6905F6AA12A37C5A38BBCB907E9215622364DCCA * ___args0, const RuntimeMethod* method)
{
	{
		__this->set_msgReceived_0((bool)1);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass6_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass6_0__ctor_mEB8DB2BFDA9F6F083E77F1EC1CE3F4861CD1815A (U3CU3Ec__DisplayClass6_0_t96633FB6A2AE351A4A3FCDF89D10891DA07AD54F * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass6_0::<InvokeMessageIdSubscribers>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CU3Ec__DisplayClass6_0_U3CInvokeMessageIdSubscribersU3Eb__0_mEF5D5DFC8F7C2CEC86378AC3BBD40E80A1D9C615 (U3CU3Ec__DisplayClass6_0_t96633FB6A2AE351A4A3FCDF89D10891DA07AD54F * __this, MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Guid_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * L_0 = ___x0;
		NullCheck(L_0);
		Guid_t  L_1;
		L_1 = MessageTypeSubscribers_get_MessageTypeId_m5A873C55E97728BD12BA52B5DB72FFA366992DD9(L_0, /*hidden argument*/NULL);
		Guid_t  L_2 = __this->get_messageId_0();
		IL2CPP_RUNTIME_CLASS_INIT(Guid_t_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Guid_op_Equality_m4C2AA9C31D173525E381965A7246814B4C74D5B0(L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass7_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0__ctor_m97B67DA8AA306A160A790CCDD869669878DDB7F3 (U3CU3Ec__DisplayClass7_0_t7C625D285CBB757F88C0232D12D88EDABF06EB60 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass7_0::<AddAndCreate>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CU3Ec__DisplayClass7_0_U3CAddAndCreateU3Eb__0_mAA3D205F35F7BE200A5DDD14099F56312FBED909 (U3CU3Ec__DisplayClass7_0_t7C625D285CBB757F88C0232D12D88EDABF06EB60 * __this, MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Guid_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * L_0 = ___x0;
		NullCheck(L_0);
		Guid_t  L_1;
		L_1 = MessageTypeSubscribers_get_MessageTypeId_m5A873C55E97728BD12BA52B5DB72FFA366992DD9(L_0, /*hidden argument*/NULL);
		Guid_t  L_2 = __this->get_messageId_0();
		IL2CPP_RUNTIME_CLASS_INIT(Guid_t_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Guid_op_Equality_m4C2AA9C31D173525E381965A7246814B4C74D5B0(L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass8_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass8_0__ctor_m18AC0B2825D7BB04F59DC800DFF74D45921A28FA (U3CU3Ec__DisplayClass8_0_tE64E7CAC5415DCD425D14A6062600087CC872B93 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/<>c__DisplayClass8_0::<UnregisterManagedCallback>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CU3Ec__DisplayClass8_0_U3CUnregisterManagedCallbackU3Eb__0_m70805C4CE0F8DD258CC3975A8C90313A0A609BE3 (U3CU3Ec__DisplayClass8_0_tE64E7CAC5415DCD425D14A6062600087CC872B93 * __this, MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Guid_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * L_0 = ___x0;
		NullCheck(L_0);
		Guid_t  L_1;
		L_1 = MessageTypeSubscribers_get_MessageTypeId_m5A873C55E97728BD12BA52B5DB72FFA366992DD9(L_0, /*hidden argument*/NULL);
		Guid_t  L_2 = __this->get_messageId_0();
		IL2CPP_RUNTIME_CLASS_INIT(Guid_t_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Guid_op_Equality_m4C2AA9C31D173525E381965A7246814B4C74D5B0(L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/ConnectionChangeEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConnectionChangeEvent__ctor_m95EBD8B5EA1C4A14A5F2B71CEE1A2C18C73DB0A1 (ConnectionChangeEvent_tCA1C8C14171C72EC394EF45450D69C1585067BDF * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityEvent_1__ctor_m30F443398054B5E3666B3C86E64A5C0FF97D93FF_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		UnityEvent_1__ctor_m30F443398054B5E3666B3C86E64A5C0FF97D93FF(__this, /*hidden argument*/UnityEvent_1__ctor_m30F443398054B5E3666B3C86E64A5C0FF97D93FF_RuntimeMethod_var);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MessageEvent__ctor_mE4D70D8837C51E422C9A40C3F8F34ACB9AB572BB (MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityEvent_1__ctor_mC7E63F58C7EFC8E8747E3619B7564A7325F03D3B_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		UnityEvent_1__ctor_mC7E63F58C7EFC8E8747E3619B7564A7325F03D3B(__this, /*hidden argument*/UnityEvent_1__ctor_mC7E63F58C7EFC8E8747E3619B7564A7325F03D3B_RuntimeMethod_var);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Guid UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers::get_MessageTypeId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Guid_t  MessageTypeSubscribers_get_MessageTypeId_m5A873C55E97728BD12BA52B5DB72FFA366992DD9 (MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * __this, const RuntimeMethod* method)
{
	Guid_t  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		String_t* L_0 = __this->get_m_messageTypeId_0();
		Guid_t  L_1;
		memset((&L_1), 0, sizeof(L_1));
		Guid__ctor_mF80313305B9CD2AD39B621E1CEC5C7DFDFFBDE66((&L_1), L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		Guid_t  L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers::set_MessageTypeId(System.Guid)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MessageTypeSubscribers_set_MessageTypeId_m7125FF3E71F4E678644F056A4DC5C29EFB749762 (MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * __this, Guid_t  ___value0, const RuntimeMethod* method)
{
	{
		String_t* L_0;
		L_0 = Guid_ToString_mA3AB7742FB0E04808F580868E82BDEB93187FB75((Guid_t *)(&___value0), /*hidden argument*/NULL);
		__this->set_m_messageTypeId_0(L_0);
		return;
	}
}
// System.Void UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents/MessageTypeSubscribers::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MessageTypeSubscribers__ctor_mA51A6D3E38DBAA5B8237BAB1688F669F24982F29 (MessageTypeSubscribers_t7A69A1D132BF9A354D94F9E490E148BBB81A508F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		__this->set_subscriberCount_1(0);
		MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B * L_0 = (MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B *)il2cpp_codegen_object_new(MessageEvent_tF0C632D7EBE9C4B2B91E20F2AA4B593D1B55469B_il2cpp_TypeInfo_var);
		MessageEvent__ctor_mE4D70D8837C51E422C9A40C3F8F34ACB9AB572BB(L_0, /*hidden argument*/NULL);
		__this->set_messageCallback_2(L_0);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_UpdateFunction_tEDC2A88F61F179480CAA9443E6ADDA3F126B8AEA (UpdateFunction_tEDC2A88F61F179480CAA9443E6ADDA3F126B8AEA * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void UnityEngine.LowLevel.PlayerLoopSystem/UpdateFunction::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpdateFunction__ctor_mB10AB83A3F547AC95FF726E8A7B5FF9C16EC1319 (UpdateFunction_tEDC2A88F61F179480CAA9443E6ADDA3F126B8AEA * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.LowLevel.PlayerLoopSystem/UpdateFunction::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpdateFunction_Invoke_mB17C55B92FAECE51078028F59A9F1EAC2016B1AD (UpdateFunction_tEDC2A88F61F179480CAA9443E6ADDA3F126B8AEA * __this, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 0)
			{
				// open
				typedef void (*FunctionPointerType) (const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, targetThis);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, targetThis);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, targetMethod);
			}
		}
	}
}
// System.IAsyncResult UnityEngine.LowLevel.PlayerLoopSystem/UpdateFunction::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* UpdateFunction_BeginInvoke_m1EB0935AB72A286D153ACEBD0E5D66BB38BD6799 (UpdateFunction_tEDC2A88F61F179480CAA9443E6ADDA3F126B8AEA * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void UnityEngine.LowLevel.PlayerLoopSystem/UpdateFunction::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpdateFunction_EndInvoke_mB4BC0AA40E9C83274116DF6467D72DD4902DA624 (UpdateFunction_tEDC2A88F61F179480CAA9443E6ADDA3F126B8AEA * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.RectTransform/ReapplyDrivenProperties::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ReapplyDrivenProperties__ctor_mD584B5E4A07E3D025352EA0BAE9B10FE5C13A583 (ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.RectTransform/ReapplyDrivenProperties::Invoke(UnityEngine.RectTransform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ReapplyDrivenProperties_Invoke_m5B39EC5205C3910AC09DCF378EAA2D8E99391636 (ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE * __this, RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___driven0, const RuntimeMethod* method)
{
	DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8* delegateArrayToInvoke = __this->get_delegates_11();
	Delegate_t** delegatesToInvoke;
	il2cpp_array_size_t length;
	if (delegateArrayToInvoke != NULL)
	{
		length = delegateArrayToInvoke->max_length;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(delegateArrayToInvoke->GetAddressAtUnchecked(0));
	}
	else
	{
		length = 1;
		delegatesToInvoke = reinterpret_cast<Delegate_t**>(&__this);
	}

	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		Delegate_t* currentDelegate = delegatesToInvoke[i];
		Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
		RuntimeObject* targetThis = currentDelegate->get_m_target_2();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___driven0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___driven0, targetMethod);
			}
		}
		else if (___parameterCount != 1)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker0::Invoke(targetMethod, ___driven0);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, ___driven0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___driven0);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___driven0);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___driven0, targetMethod);
			}
		}
		else
		{
			// closed
			if (targetThis != NULL && il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * >::Invoke(targetMethod, targetThis, ___driven0);
					else
						GenericVirtActionInvoker1< RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * >::Invoke(targetMethod, targetThis, ___driven0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___driven0);
					else
						VirtActionInvoker1< RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___driven0);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 *, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___driven0, targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 *, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___driven0, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult UnityEngine.RectTransform/ReapplyDrivenProperties::BeginInvoke(UnityEngine.RectTransform,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ReapplyDrivenProperties_BeginInvoke_mC7625A8FDFF392D73C7828526490DCB88FD87232 (ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE * __this, RectTransform_t8A6A306FB29A6C8C22010CF9040E319753571072 * ___driven0, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	void *__d_args[2] = {0};
	__d_args[0] = ___driven0;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);;
}
// System.Void UnityEngine.RectTransform/ReapplyDrivenProperties::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ReapplyDrivenProperties_EndInvoke_m89A593999C130CA23515BF8A9C02DDE5B39ECF67 (ReapplyDrivenProperties_t1441259DADA8FE33A95334AC24C017DFA3DEB4CE * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.SpookyHash/U::.ctor(System.UInt16*)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U__ctor_m29915B03ADD0CB26085DB325B7FC87C4A5134C01 (U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB * __this, uint16_t* ___p80, const RuntimeMethod* method)
{
	{
		__this->set_p32_1((uint32_t*)((intptr_t)0));
		__this->set_p64_2((uint64_t*)((intptr_t)0));
		__this->set_i_3(((int64_t)((int64_t)0)));
		uint16_t* L_0 = ___p80;
		__this->set_p8_0((uint8_t*)L_0);
		return;
	}
}
IL2CPP_EXTERN_C  void U__ctor_m29915B03ADD0CB26085DB325B7FC87C4A5134C01_AdjustorThunk (RuntimeObject * __this, uint16_t* ___p80, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB * _thisAdjusted = reinterpret_cast<U_tEA9A82EE61C5DDF7656EA5DDFCB15367A0BE3ADB *>(__this + _offset);
	U__ctor_m29915B03ADD0CB26085DB325B7FC87C4A5134C01(_thisAdjusted, ___p80, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.TextAsset/EncodingUtility::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EncodingUtility__cctor_m6BADEB7670563CC438C10AF259028A7FF06AD65F (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB8F710F417E2D96E747683BF53A8CA9BB6B9648C);
		s_Il2CppMethodInitialized = true;
	}
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * V_0 = NULL;
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * V_1 = NULL;
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * V_2 = NULL;
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * V_3 = NULL;
	Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * V_4 = NULL;
	{
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_0;
		L_0 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(39 /* System.Int32 System.Text.Encoding::get_CodePage() */, L_0);
		EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418 * L_2 = (EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418 *)il2cpp_codegen_object_new(EncoderReplacementFallback_t61E36A507D7FA8034B49F86DBE560EC77A6A8418_il2cpp_TypeInfo_var);
		EncoderReplacementFallback__ctor_m07299910DC3D3F6B9F8F37A4ADD40A500F97D1D4(L_2, _stringLiteralB8F710F417E2D96E747683BF53A8CA9BB6B9648C, /*hidden argument*/NULL);
		DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130 * L_3 = (DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130 *)il2cpp_codegen_object_new(DecoderReplacementFallback_t8DA345EC4EF3A35A2667365F691EE69408A62130_il2cpp_TypeInfo_var);
		DecoderReplacementFallback__ctor_m7E6C273B2682E373C787568EB0BB0B2E4B6C2253(L_3, _stringLiteralB8F710F417E2D96E747683BF53A8CA9BB6B9648C, /*hidden argument*/NULL);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_4;
		L_4 = Encoding_GetEncoding_m4DC46FF0C923994EDEE21980037198E27A75E4F2(L_1, L_2, L_3, /*hidden argument*/NULL);
		((EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_StaticFields*)il2cpp_codegen_static_fields_for(EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_il2cpp_TypeInfo_var))->set_targetEncoding_1(L_4);
		UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014 * L_5 = (UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014 *)il2cpp_codegen_object_new(UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014_il2cpp_TypeInfo_var);
		UTF32Encoding__ctor_mCC6CB31807AE3B57FAF941B59D72D7BA10CFB1FD(L_5, (bool)1, (bool)1, (bool)1, /*hidden argument*/NULL);
		V_0 = L_5;
		UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014 * L_6 = (UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014 *)il2cpp_codegen_object_new(UTF32Encoding_t54B51C8FAC5B2EAB4BDFACBBA06DB6117A38D014_il2cpp_TypeInfo_var);
		UTF32Encoding__ctor_mCC6CB31807AE3B57FAF941B59D72D7BA10CFB1FD(L_6, (bool)0, (bool)1, (bool)1, /*hidden argument*/NULL);
		V_1 = L_6;
		UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68 * L_7 = (UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68 *)il2cpp_codegen_object_new(UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68_il2cpp_TypeInfo_var);
		UnicodeEncoding__ctor_m8D0BFF0DBB175D7E590674E31343E8C72701FC7C(L_7, (bool)1, (bool)1, (bool)1, /*hidden argument*/NULL);
		V_2 = L_7;
		UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68 * L_8 = (UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68 *)il2cpp_codegen_object_new(UnicodeEncoding_tBB60B97AFC49D6246F28BF16D3E09822FCCACC68_il2cpp_TypeInfo_var);
		UnicodeEncoding__ctor_m8D0BFF0DBB175D7E590674E31343E8C72701FC7C(L_8, (bool)0, (bool)1, (bool)1, /*hidden argument*/NULL);
		V_3 = L_8;
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_9 = (UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 *)il2cpp_codegen_object_new(UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		UTF8Encoding__ctor_mD752778085A353529AF03841383E5603FE556449(L_9, (bool)1, (bool)1, /*hidden argument*/NULL);
		V_4 = L_9;
		KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* L_10 = (KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7*)(KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7*)SZArrayNew(KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7_il2cpp_TypeInfo_var, (uint32_t)5);
		KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* L_11 = L_10;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_12 = V_0;
		NullCheck(L_12);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_13;
		L_13 = VirtFuncInvoker0< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(6 /* System.Byte[] System.Text.Encoding::GetPreamble() */, L_12);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_14 = V_0;
		KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  L_15;
		memset((&L_15), 0, sizeof(L_15));
		KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E((&L_15), L_13, L_14, /*hidden argument*/KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E_RuntimeMethod_var);
		NullCheck(L_11);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(0), (KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B )L_15);
		KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* L_16 = L_11;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_17 = V_1;
		NullCheck(L_17);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_18;
		L_18 = VirtFuncInvoker0< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(6 /* System.Byte[] System.Text.Encoding::GetPreamble() */, L_17);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_19 = V_1;
		KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  L_20;
		memset((&L_20), 0, sizeof(L_20));
		KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E((&L_20), L_18, L_19, /*hidden argument*/KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E_RuntimeMethod_var);
		NullCheck(L_16);
		(L_16)->SetAt(static_cast<il2cpp_array_size_t>(1), (KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B )L_20);
		KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* L_21 = L_16;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_22 = V_2;
		NullCheck(L_22);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = VirtFuncInvoker0< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(6 /* System.Byte[] System.Text.Encoding::GetPreamble() */, L_22);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_24 = V_2;
		KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  L_25;
		memset((&L_25), 0, sizeof(L_25));
		KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E((&L_25), L_23, L_24, /*hidden argument*/KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E_RuntimeMethod_var);
		NullCheck(L_21);
		(L_21)->SetAt(static_cast<il2cpp_array_size_t>(2), (KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B )L_25);
		KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* L_26 = L_21;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_27 = V_3;
		NullCheck(L_27);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_28;
		L_28 = VirtFuncInvoker0< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(6 /* System.Byte[] System.Text.Encoding::GetPreamble() */, L_27);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_29 = V_3;
		KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  L_30;
		memset((&L_30), 0, sizeof(L_30));
		KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E((&L_30), L_28, L_29, /*hidden argument*/KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E_RuntimeMethod_var);
		NullCheck(L_26);
		(L_26)->SetAt(static_cast<il2cpp_array_size_t>(3), (KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B )L_30);
		KeyValuePair_2U5BU5D_t256F162571C05521448AA203E8C620697614CAE7* L_31 = L_26;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_32 = V_4;
		NullCheck(L_32);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_33;
		L_33 = VirtFuncInvoker0< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(6 /* System.Byte[] System.Text.Encoding::GetPreamble() */, L_32);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_34 = V_4;
		KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B  L_35;
		memset((&L_35), 0, sizeof(L_35));
		KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E((&L_35), L_33, L_34, /*hidden argument*/KeyValuePair_2__ctor_mDCF2A49BD99EBDA9819EAB356D5E65CA66F8754E_RuntimeMethod_var);
		NullCheck(L_31);
		(L_31)->SetAt(static_cast<il2cpp_array_size_t>(4), (KeyValuePair_2_t3A7CB634D4B37FBC5AD1F3511F36FC672A31B11B )L_35);
		((EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_StaticFields*)il2cpp_codegen_static_fields_for(EncodingUtility_tF25232B383AA56BB15E7955C1C9FC356F9770983_il2cpp_TypeInfo_var))->set_encodingLookup_0(L_31);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Transform/Enumerator::.ctor(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator__ctor_m052C22273F1D789E58A09606D5EE5E87ABC2C91B (Enumerator_t8A0B2200373BC9628C065322A1BA07AAA47E0259 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___outer0, const RuntimeMethod* method)
{
	{
		__this->set_currentIndex_1((-1));
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0 = ___outer0;
		__this->set_outer_0(L_0);
		return;
	}
}
// System.Object UnityEngine.Transform/Enumerator::get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_m1CFECBB7AC3EACD05A11CC6848AE7A94A8123E9F (Enumerator_t8A0B2200373BC9628C065322A1BA07AAA47E0259 * __this, const RuntimeMethod* method)
{
	RuntimeObject * V_0 = NULL;
	{
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0 = __this->get_outer_0();
		int32_t L_1 = __this->get_currentIndex_1();
		NullCheck(L_0);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_2;
		L_2 = Transform_GetChild_mA7D94BEFF0144F76561D9B8FED61C5C939EC1F1C(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0015;
	}

IL_0015:
	{
		RuntimeObject * L_3 = V_0;
		return L_3;
	}
}
// System.Boolean UnityEngine.Transform/Enumerator::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m346F9A121D9E89ADBA8296E6A7EF8763C5B58A14 (Enumerator_t8A0B2200373BC9628C065322A1BA07AAA47E0259 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	bool V_2 = false;
	{
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0 = __this->get_outer_0();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Transform_get_childCount_mCBED4F6D3F6A7386C4D97C2C3FD25C383A0BCD05(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		int32_t L_2 = __this->get_currentIndex_1();
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_2, (int32_t)1));
		int32_t L_3 = V_1;
		__this->set_currentIndex_1(L_3);
		int32_t L_4 = V_1;
		int32_t L_5 = V_0;
		V_2 = (bool)((((int32_t)L_4) < ((int32_t)L_5))? 1 : 0);
		goto IL_0024;
	}

IL_0024:
	{
		bool L_6 = V_2;
		return L_6;
	}
}
// System.Void UnityEngine.Transform/Enumerator::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Reset_mFA289646E280C94D82CC223C024E0B615F811C8E (Enumerator_t8A0B2200373BC9628C065322A1BA07AAA47E0259 * __this, const RuntimeMethod* method)
{
	{
		__this->set_currentIndex_1((-1));
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.UnitySynchronizationContext/WorkRequest
IL2CPP_EXTERN_C void WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshal_pinvoke(const WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393& unmarshaled, WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshaled_pinvoke& marshaled)
{
	Exception_t* ___m_WaitHandle_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_WaitHandle' of type 'WorkRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_WaitHandle_2Exception, NULL);
}
IL2CPP_EXTERN_C void WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshal_pinvoke_back(const WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshaled_pinvoke& marshaled, WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393& unmarshaled)
{
	Exception_t* ___m_WaitHandle_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_WaitHandle' of type 'WorkRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_WaitHandle_2Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.UnitySynchronizationContext/WorkRequest
IL2CPP_EXTERN_C void WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshal_pinvoke_cleanup(WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.UnitySynchronizationContext/WorkRequest
IL2CPP_EXTERN_C void WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshal_com(const WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393& unmarshaled, WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshaled_com& marshaled)
{
	Exception_t* ___m_WaitHandle_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_WaitHandle' of type 'WorkRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_WaitHandle_2Exception, NULL);
}
IL2CPP_EXTERN_C void WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshal_com_back(const WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshaled_com& marshaled, WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393& unmarshaled)
{
	Exception_t* ___m_WaitHandle_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_WaitHandle' of type 'WorkRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_WaitHandle_2Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.UnitySynchronizationContext/WorkRequest
IL2CPP_EXTERN_C void WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshal_com_cleanup(WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.UnitySynchronizationContext/WorkRequest::.ctor(System.Threading.SendOrPostCallback,System.Object,System.Threading.ManualResetEvent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkRequest__ctor_m13C7B4A89E47F4B97ED9B786DB99849DBC2B5603 (WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 * __this, SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * ___callback0, RuntimeObject * ___state1, ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * ___waitHandle2, const RuntimeMethod* method)
{
	{
		SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * L_0 = ___callback0;
		__this->set_m_DelagateCallback_0(L_0);
		RuntimeObject * L_1 = ___state1;
		__this->set_m_DelagateState_1(L_1);
		ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * L_2 = ___waitHandle2;
		__this->set_m_WaitHandle_2(L_2);
		return;
	}
}
IL2CPP_EXTERN_C  void WorkRequest__ctor_m13C7B4A89E47F4B97ED9B786DB99849DBC2B5603_AdjustorThunk (RuntimeObject * __this, SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * ___callback0, RuntimeObject * ___state1, ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * ___waitHandle2, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 * _thisAdjusted = reinterpret_cast<WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 *>(__this + _offset);
	WorkRequest__ctor_m13C7B4A89E47F4B97ED9B786DB99849DBC2B5603(_thisAdjusted, ___callback0, ___state1, ___waitHandle2, method);
}
// System.Void UnityEngine.UnitySynchronizationContext/WorkRequest::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WorkRequest_Invoke_m1C292B7297918C5F2DBE70971895FE8D5C33AA20 (WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 * __this, const RuntimeMethod* method)
{
	Exception_t * V_0 = NULL;
	bool V_1 = false;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
	}

IL_0001:
	try
	{ // begin try (depth: 1)
		SendOrPostCallback_t6B7334CE017AF595535507519400AC02D688DC3C * L_0 = __this->get_m_DelagateCallback_0();
		RuntimeObject * L_1 = __this->get_m_DelagateState_1();
		NullCheck(L_0);
		SendOrPostCallback_Invoke_m352534ED0E61440A793944CC44809F666BBC1461(L_0, L_1, /*hidden argument*/NULL);
		goto IL_0023;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0017;
		}
		throw e;
	}

CATCH_0017:
	{ // begin catch(System.Exception)
		V_0 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		Exception_t * L_2 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var)));
		Debug_LogException_m1BE957624F4DD291B1B4265D4A55A34EFAA8D7BA(L_2, /*hidden argument*/NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0023;
	} // end catch (depth: 1)

IL_0023:
	{
		ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * L_3 = __this->get_m_WaitHandle_2();
		V_1 = (bool)((!(((RuntimeObject*)(ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA *)L_3) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_003c;
		}
	}
	{
		ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * L_5 = __this->get_m_WaitHandle_2();
		NullCheck(L_5);
		bool L_6;
		L_6 = EventWaitHandle_Set_m81764C887F38A1153224557B26CD688B59987B38(L_5, /*hidden argument*/NULL);
	}

IL_003c:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void WorkRequest_Invoke_m1C292B7297918C5F2DBE70971895FE8D5C33AA20_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 * _thisAdjusted = reinterpret_cast<WorkRequest_tA19FD4D1269D8EE2EA886AAF036C4F7F09154393 *>(__this + _offset);
	WorkRequest_Invoke_m1C292B7297918C5F2DBE70971895FE8D5C33AA20(_thisAdjusted, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector4_Equals_m0919D35807550372D1748193EB31E4C5E406AE61_inline (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * __this, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___other0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t G_B5_0 = 0;
	{
		float L_0 = __this->get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_1 = ___other0;
		float L_2 = L_1.get_x_1();
		if ((!(((float)L_0) == ((float)L_2))))
		{
			goto IL_003b;
		}
	}
	{
		float L_3 = __this->get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___other0;
		float L_5 = L_4.get_y_2();
		if ((!(((float)L_3) == ((float)L_5))))
		{
			goto IL_003b;
		}
	}
	{
		float L_6 = __this->get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_7 = ___other0;
		float L_8 = L_7.get_z_3();
		if ((!(((float)L_6) == ((float)L_8))))
		{
			goto IL_003b;
		}
	}
	{
		float L_9 = __this->get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_10 = ___other0;
		float L_11 = L_10.get_w_4();
		G_B5_0 = ((((float)L_9) == ((float)L_11))? 1 : 0);
		goto IL_003c;
	}

IL_003b:
	{
		G_B5_0 = 0;
	}

IL_003c:
	{
		V_0 = (bool)G_B5_0;
		goto IL_003f;
	}

IL_003f:
	{
		bool L_12 = V_0;
		return L_12;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Vector4_op_Equality_mAC86329F5E0AF56A4A1067AB4299C291221720AE_inline (Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___lhs0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___rhs1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	float V_4 = 0.0f;
	bool V_5 = false;
	{
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_0 = ___lhs0;
		float L_1 = L_0.get_x_1();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_2 = ___rhs1;
		float L_3 = L_2.get_x_1();
		V_0 = ((float)il2cpp_codegen_subtract((float)L_1, (float)L_3));
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_4 = ___lhs0;
		float L_5 = L_4.get_y_2();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_6 = ___rhs1;
		float L_7 = L_6.get_y_2();
		V_1 = ((float)il2cpp_codegen_subtract((float)L_5, (float)L_7));
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_8 = ___lhs0;
		float L_9 = L_8.get_z_3();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_10 = ___rhs1;
		float L_11 = L_10.get_z_3();
		V_2 = ((float)il2cpp_codegen_subtract((float)L_9, (float)L_11));
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_12 = ___lhs0;
		float L_13 = L_12.get_w_4();
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_14 = ___rhs1;
		float L_15 = L_14.get_w_4();
		V_3 = ((float)il2cpp_codegen_subtract((float)L_13, (float)L_15));
		float L_16 = V_0;
		float L_17 = V_0;
		float L_18 = V_1;
		float L_19 = V_1;
		float L_20 = V_2;
		float L_21 = V_2;
		float L_22 = V_3;
		float L_23 = V_3;
		V_4 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_16, (float)L_17)), (float)((float)il2cpp_codegen_multiply((float)L_18, (float)L_19)))), (float)((float)il2cpp_codegen_multiply((float)L_20, (float)L_21)))), (float)((float)il2cpp_codegen_multiply((float)L_22, (float)L_23))));
		float L_24 = V_4;
		V_5 = (bool)((((float)L_24) < ((float)(9.99999944E-11f)))? 1 : 0);
		goto IL_0057;
	}

IL_0057:
	{
		bool L_25 = V_5;
		return L_25;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_2(L_0);
		float L_1 = ___y1;
		__this->set_y_3(L_1);
		float L_2 = ___z2;
		__this->set_z_4(L_2);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_attribute_m88486EF6174B0F27BB4DCD82E8FF1A0AEFD79ABD_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CattributeU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_attribute_mBF99A4AE23B0677C1922EA461FB8B36B021C68B6_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CattributeU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_format_mA80A6D11ABBC8B2774F50035308781AD277D8186_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CformatU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_format_m530E47091524EF538721994F3A0A066285B72251_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CformatU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_dimension_mB07B5E7D624C5EF40D994752E38D83B7A66A7E3C_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CdimensionU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_dimension_m8E0A210A2662617D2AB601C6DC0D996A08563787_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CdimensionU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t VertexAttributeDescriptor_get_stream_m4603EAF7571DB331ED3735D89DBB72B465486E15_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CstreamU3Ek__BackingField_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void VertexAttributeDescriptor_set_stream_m39EC0B3F25D7CCF8F389C2CCF6390DA8E8651BEE_inline (VertexAttributeDescriptor_t63A6AA231C2400B66A65E1B66732882B6C27E54E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CstreamU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float WaitForSecondsRealtime_get_waitTime_m04ED4EACCB01E49DEC7E0E5A83789068A3525BC2_inline (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, const RuntimeMethod* method)
{
	{
		float L_0 = __this->get_U3CwaitTimeU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void WaitForSecondsRealtime_set_waitTime_m241120AEE2F1BDD0DC3077D865C7C3D878448268_inline (WaitForSecondsRealtime_t04F2884A9814C3E4E415E788AFE56B5928577C40 * __this, float ___value0, const RuntimeMethod* method)
{
	{
		float L_0 = ___value0;
		__this->set_U3CwaitTimeU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t GateFitParameters_get_mode_m77B9128212158F79B56A96B464863CF425DAD42E_inline (GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CmodeU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR float GateFitParameters_get_aspect_m58C24572B24DA38AE4973691C26C0822A0D5C58A_inline (GateFitParameters_t7BD1C97382C48CE31E7FA3D5C183551C50FBFE5D * __this, const RuntimeMethod* method)
{
	{
		float L_0 = __this->get_U3CaspectU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t MeshDataArray_get_Length_mF10B3C18CF5962BD3D2E0490C1EC4351B33F2160_inline (MeshDataArray_t8335D979DAE839C8BBF6619FC8D8A6F0948B3D26 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_m_Length_1();
		return L_0;
	}
}
