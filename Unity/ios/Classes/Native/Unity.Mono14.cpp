#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


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
template <typename R, typename T1, typename T2, typename T3>
struct VirtFuncInvoker3
{
	typedef R (*Func)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
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
template <typename R, typename T1, typename T2, typename T3, typename T4>
struct VirtFuncInvoker4
{
	typedef R (*Func)(void*, T1, T2, T3, T4, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, p4, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
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

// System.Action`1<System.Exception>
struct Action_1_t34F00247DCE829C59C4C5AAECAE03F05F060DD90;
// System.Action`1<System.Object>
struct Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC;
// System.Action`2<System.Int64,System.Net.IPEndPoint>
struct Action_2_t9750FBDA93C54A068C92A369CAC15F24DE158260;
// System.Action`2<System.Int64,System.Int32>
struct Action_2_t2ADD49D0CF846FB88D1900B8895B44BFB673FF0F;
// System.Action`2<System.Int64,System.IO.MemoryStream>
struct Action_2_tC2DAC15FF34E77EADA91D6F573A5B82C8767C79A;
// System.Collections.Generic.Dictionary`2<System.Reflection.FieldInfo,System.Collections.Generic.KeyValuePair`2<ILRuntime.Runtime.Enviorment.CLRFieldBindingDelegate,ILRuntime.Runtime.Enviorment.CLRFieldBindingDelegate>>
struct Dictionary_2_tDAC370053A1E5D6045467E2B48C4266C64ED4025;
// System.Collections.Generic.Dictionary`2<System.Reflection.FieldInfo,ILRuntime.Runtime.Enviorment.CLRFieldGetterDelegate>
struct Dictionary_2_t22C480C209A674253ACD2CFCB944227F9742EA45;
// System.Collections.Generic.Dictionary`2<System.Reflection.FieldInfo,ILRuntime.Runtime.Enviorment.CLRFieldSetterDelegate>
struct Dictionary_2_tD0995A54F52C664DA4414EEA7D5455E3392135DD;
// System.Collections.Generic.Dictionary`2<ILRuntime.CLR.Method.ILMethod,ILRuntime.Runtime.Intepreter.IDelegateAdapter>
struct Dictionary_2_tE1A83080A9D570401050D852D45604823051496B;
// System.Collections.Generic.Dictionary`2<System.Int32,ILRuntime.Runtime.Intepreter.ILIntepreter>
struct Dictionary_2_t0498150D64162A220E50F416A2B03CBC3208917A;
// System.Collections.Generic.Dictionary`2<System.Int32,ILRuntime.CLR.TypeSystem.IType>
struct Dictionary_2_t061ADB0E2EC4ED1C323DC00B84F25404EED49736;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>
struct Dictionary_2_t49CB072CAA9184D326107FA696BB354C43EB5E08;
// System.Collections.Generic.Dictionary`2<System.Int32,System.String>
struct Dictionary_2_t0ACB62D0885C7AB376463C70665400A39808C5FB;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task>
struct Dictionary_2_tB758E2A2593CD827EFC041BE1F1BB4B68DE1C3E8;
// System.Collections.Generic.Dictionary`2<System.Int64,System.Object>
struct Dictionary_2_t240BB5F785CC3B2A17B14447F3C0E0BB6AAB8E26;
// System.Collections.Generic.Dictionary`2<System.Int64,ET.WChannel>
struct Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE;
// System.Collections.Generic.Dictionary`2<System.Reflection.MethodBase,ILRuntime.Runtime.Enviorment.CLRRedirectionDelegate>
struct Dictionary_2_tECEB4010F857D3A74927A65E4E1FD022D1DE9446;
// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<ILRuntime.CLR.Method.ILMethod>>
struct Dictionary_2_t0CA2C2C7261253E1492136E657CF00E1677F4BA0;
// System.Collections.Generic.Dictionary`2<System.String,System.Byte[]>
struct Dictionary_2_tEB463D000DF6B3D1706F993599896D44D951DDD5;
// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162;
// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.CLRCreateArrayInstanceDelegate>
struct Dictionary_2_tDBB96F3778A1819B94D6661F5BBC0289A0061AA6;
// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.CLRCreateDefaultInstanceDelegate>
struct Dictionary_2_t334DF8318ABD34FE4D86B27506FB4188CCA51679;
// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.CLRMemberwiseCloneDelegate>
struct Dictionary_2_tFE7AF4DDB7938F8E050A59DB8772E6F2FAC3F3C9;
// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.CrossBindingAdaptor>
struct Dictionary_2_t3B6E7F8E03E7F33A003842F91DE56BC9FF84FC04;
// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.CLR.TypeSystem.IType>
struct Dictionary_2_t19C57C1FBC50115D03F52B2AADFC57ED62F6374F;
// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.ValueTypeBinder>
struct Dictionary_2_tE83DE222A73949FDCD78F1120B67AFC69707746D;
// System.Func`1<System.Threading.Tasks.Task/ContingentProperties>
struct Func_1_tBCF42601FA307876E83080BE4204110820F8BF3B;
// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<System.Net.HttpListenerContext>>
struct Func_2_tD7772F8C5D4C5928DD22254477694C7ED8B2A10A;
// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<System.Net.WebSockets.HttpListenerWebSocketContext>>
struct Func_2_t8936B820B2FAA2912BC66CEF081462D70A778FA7;
// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<System.Net.WebSockets.WebSocketReceiveResult>>
struct Func_2_t3E70501828E336A95A943FA3F6EC4B1DB7736B3E;
// System.Collections.Generic.IEnumerable`1<System.String>
struct IEnumerable_1_tBD60400523D840591A17E4CBBACC79397F68FAA2;
// System.Collections.Generic.IEqualityComparer`1<System.Int64>
struct IEqualityComparer_1_tBD7EB381E8B25356EF3AED6C41B65AECA6B91A19;
// System.Collections.Generic.IList`1<System.Object>
struct IList_1_t707982BD768B18C51D263C759F33BCDBDFA44901;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Int64,ET.WChannel>
struct KeyCollection_tF9F6C15485F9E60A0BBE89C462BB0229B7198E81;
// System.Collections.Generic.List`1<ILRuntime.CLR.Method.ILMethod>
struct List_1_t24A8BC5C4F5BF0821221F08827FEDE6E9B894320;
// System.Collections.Generic.List`1<ILRuntime.CLR.TypeSystem.ILType>
struct List_1_t90485522A4E2346576EFE8A1A39658A219F00796;
// System.Collections.Generic.List`1<ILRuntime.CLR.TypeSystem.IType>
struct List_1_t87CDBC8651F8EEFB19B40ED5D2C9B2C35CED9BC8;
// System.Collections.Generic.List`1<System.String>
struct List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3;
// System.Predicate`1<System.Object>
struct Predicate_1_t5C96B81B31A697B11C4C3767E3298773AF25DFEB;
// System.Predicate`1<System.Threading.Tasks.Task>
struct Predicate_1_tC0DBBC8498BD1EE6ABFFAA5628024105FA7D11BD;
// System.Collections.Generic.Queue`1<System.Byte[]>
struct Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4;
// System.Collections.Generic.Queue`1<ET.ETTask>
struct Queue_1_tB507071133411FA55FF2315F30B7DE52E9042A80;
// System.Collections.Generic.Queue`1<ILRuntime.Runtime.Intepreter.ILIntepreter>
struct Queue_1_t9AF11493932D68D1ED7D097E9F520EB41308612F;
// System.Collections.Generic.Queue`1<System.Object>
struct Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64;
// System.Threading.Tasks.TaskFactory`1<System.Net.HttpListenerContext>
struct TaskFactory_1_t5E5A6EA81864D954CD634E63E7679B54C114A514;
// System.Threading.Tasks.TaskFactory`1<System.Net.WebSockets.HttpListenerWebSocketContext>
struct TaskFactory_1_tC295FDAAC14E306B1EF6D6D848D146F29521D4F5;
// System.Threading.Tasks.TaskFactory`1<System.Net.WebSockets.WebSocketReceiveResult>
struct TaskFactory_1_tC063EA52EE4C2F5600912DE4F3612E7BCD1A2095;
// System.Threading.Tasks.Task`1<System.Net.HttpListenerContext>
struct Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33;
// System.Threading.Tasks.Task`1<System.Net.WebSockets.HttpListenerWebSocketContext>
struct Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC;
// System.Threading.Tasks.Task`1<System.Int32>
struct Task_1_tEF253D967DB628A9F8A389A9F2E4516871FD3725;
// System.Threading.Tasks.Task`1<System.Object>
struct Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17;
// System.Threading.Tasks.Task`1<System.Net.WebSockets.WebSocketReceiveResult>
struct Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E;
// ILRuntime.Other.ThreadSafeDictionary`2<System.Int32,ILRuntime.CLR.Method.IMethod>
struct ThreadSafeDictionary_2_tA2E86FABA4D232D732E0A14EA8C5248591B338B2;
// ILRuntime.Other.ThreadSafeDictionary`2<System.Int32,ILRuntime.CLR.TypeSystem.IType>
struct ThreadSafeDictionary_2_t19585080272B2201A8232E71A9942469F3AD34C8;
// ILRuntime.Other.ThreadSafeDictionary`2<System.Int64,System.String>
struct ThreadSafeDictionary_2_tCF79B0B6F2A588A98A6FE793ADCCEE3FE975434B;
// ILRuntime.Other.ThreadSafeDictionary`2<System.String,ILRuntime.CLR.TypeSystem.IType>
struct ThreadSafeDictionary_2_tA87BD25CEAE3FA571238F58A44EA82D417F99F01;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Int64,ET.WChannel>
struct ValueCollection_tBD9F1B24DDF167BD643135CD60C898042AD8E637;
// System.Collections.Generic.Dictionary`2/Entry<System.Int64,ET.WChannel>[]
struct EntryU5BU5D_tAABE5B350D6633F77FB521249CD73E89ADFEFA90;
// System.Collections.Generic.KeyValuePair`2<System.String,ILRuntime.CLR.TypeSystem.IType>[]
struct KeyValuePair_2U5BU5D_tCB908F739CE11EA7E094EB7CB1172BF9F4E43B85;
// System.Threading.SparselyPopulatedArray`1<System.Threading.CancellationCallbackInfo>[]
struct SparselyPopulatedArray_1U5BU5D_t4D2064CEC206620DC5001D7C857A845833DCB52A;
// System.Byte[][]
struct ByteU5BU5DU5BU5D_t95107DE217CCFA8CD77945AC2CB9492D4D01FE8D;
// System.Reflection.Assembly[]
struct AssemblyU5BU5D_t42061B4CA43487DD8ECD8C3AACCEF783FA081FF0;
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
// System.Threading.CancellationTokenRegistration[]
struct CancellationTokenRegistrationU5BU5D_t864BA2E1E6485FDC593F17F7C01525F33CCE7910;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// ILRuntime.Mono.Cecil.FieldDefinition[]
struct FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0;
// ILRuntime.CLR.TypeSystem.IType[]
struct ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// UnityEngine.ParticleSystem[]
struct ParticleSystemU5BU5D_t9786AE8909F75284FDCB6BAD155E24AAFDB88CC7;
// ILRuntime.Runtime.Stack.StackObject[]
struct StackObjectU5BU5D_t22EFA8CE63EDF2E1959505B7D91FCB790A838CF9;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// ET.AChannel
struct AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432;
// ET.AService
struct AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B;
// System.Action
struct Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6;
// ILRuntime.Runtime.Enviorment.AppDomain
struct AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371;
// System.Collections.ArrayList
struct ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575;
// ILRuntime.Runtime.Intepreter.RegisterVM.AsyncJITCompileWorker
struct AsyncJITCompileWorker_tF9A53213C842B49DA4941078092524971B0AA02F;
// System.Net.AuthenticationSchemeSelector
struct AuthenticationSchemeSelector_t9FDFDC832A54C0A0DFBCCFF3A6F9F5FFCABCB6D7;
// System.Threading.CancellationCallbackInfo
struct CancellationCallbackInfo_t7FC8CF6DB4845FCB0138771E86AE058710B1117B;
// System.Threading.CancellationTokenSource
struct CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3;
// System.Net.WebSockets.ClientWebSocket
struct ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09;
// System.Net.WebSockets.ClientWebSocketOptions
struct ClientWebSocketOptions_t542669394208DA09FBC06141585E0CA380ACEC85;
// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684;
// System.Threading.ContextCallback
struct ContextCallback_t93707E0430F4FF3E15E1FB5A4844BE89C657AE8B;
// System.Net.CookieCollection
struct CookieCollection_t2D2FA42D43C1A8053D95FD2205360B2E0B94AF06;
// ILRuntime.Runtime.Debugger.DebugService
struct DebugService_tC7C54FE8596DE1526A35F74FBA8D94A3B18CAF31;
// ILRuntime.Runtime.Enviorment.DelegateManager
struct DelegateManager_t27AAC9E0AC29D01AB6056BEF61D340C3344C4E6B;
// ET.ETTask
struct ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF;
// System.Exception
struct Exception_t;
// System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy
struct ExtendedProtectionPolicy_tF4E31F8B39C403E6FFF6ADA49B5BE0042121CDCE;
// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319;
// UnityEngine.Gradient
struct Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2;
// System.Collections.Hashtable
struct Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC;
// System.Net.HttpConnection
struct HttpConnection_t43F1696021071DFD5908CB5F1290EC15CE6AA1A0;
// System.Net.HttpListener
struct HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1;
// System.Net.HttpListenerContext
struct HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117;
// System.Net.HttpListenerPrefixCollection
struct HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283;
// System.Net.HttpListenerRequest
struct HttpListenerRequest_tA211D6E12A7C62C874A8B2A794066534B80BF18F;
// System.Net.HttpListenerResponse
struct HttpListenerResponse_t562C5F626301C5F39A8550549590D5B7D5061E6E;
// System.Net.WebSockets.HttpListenerWebSocketContext
struct HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33;
// System.Runtime.CompilerServices.IAsyncStateMachine
struct IAsyncStateMachine_tAE063F84A60E1058FCA4E3EA9F555D3462641F7D;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// ILRuntime.CLR.Method.ILMethod
struct ILMethod_t2BB68162E74186F7B88F8DD1CEF140B9842C8D8B;
// ILRuntime.Reflection.ILRuntimeType
struct ILRuntimeType_tE8E25D5C24E1D9239C605CA77B86273B6A3DCDF2;
// ILRuntime.CLR.TypeSystem.ILType
struct ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7;
// ILRuntime.Runtime.Intepreter.ILTypeInstance
struct ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610;
// ILRuntime.Runtime.Intepreter.ILTypeStaticInstance
struct ILTypeStaticInstance_tA790A39AC732C21DBF9006F6A8772C1C3AB013B5;
// ILRuntime.CLR.Method.IMethod
struct IMethod_tE9516A5A4DD5724DD6F75FD3FC1F3C6B8155E83C;
// System.Net.IPAddress
struct IPAddress_t2B5F1762B4B9935BA6CA8FB12C87282C72E035AE;
// System.Net.IPEndPoint
struct IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E;
// System.Security.Principal.IPrincipal
struct IPrincipal_t850ACE1F48327B64F266DD2C6FD8C5F56E4889E2;
// ILRuntime.Mono.Cecil.Cil.ISymbolReaderProvider
struct ISymbolReaderProvider_t834FA8A231A90748774E8AA7885761794C23B81A;
// ILRuntime.CLR.TypeSystem.IType
struct IType_t11C23CC6CFBAA0E44F7A6550A308171172FF4A53;
// System.Threading.ManualResetEvent
struct ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA;
// System.IO.MemoryStream
struct MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C;
// Mono.Security.Interface.MonoTlsProvider
struct MonoTlsProvider_tBE72637BEDBD1516A1BC30D94F7159B7289CF0D7;
// Mono.Security.Interface.MonoTlsSettings
struct MonoTlsSettings_tBDF72C906FE6477EFBA9493F7F5CB5ADE2C80E21;
// System.Collections.Specialized.NameValueCollection
struct NameValueCollection_tE3BED11C58844E8A4D9A74F359692B9A51781B4D;
// System.NotSupportedException
struct NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339;
// ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider
struct PdbReaderProvider_tD6CADF6205DDD9BB74AE340FE5FF73794FD2361C;
// UnityEngine.Rigidbody
struct Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t3EF85FC980AE57957BEBB6B78E81DE2E3233D385;
// System.Net.ServiceNameStore
struct ServiceNameStore_t760B40F6038C931BFDD075828BD6F9181EDB0A17;
// System.Threading.Tasks.StackGuard
struct StackGuard_t88E1EE4741AD02CA5FEA04A4EB2CC70F230E0E6D;
// System.IO.Stream
struct Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB;
// System.String
struct String_t;
// System.Threading.SynchronizationContext
struct SynchronizationContext_t17D9365B5E0D30A0910A16FA4351C525232EF069;
// System.Threading.Tasks.Task
struct Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60;
// System.Threading.Tasks.TaskFactory
struct TaskFactory_t22D999A05A967C31A4B5FFBD08864809BF35EA3B;
// System.Threading.Tasks.TaskScheduler
struct TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D;
// ET.ThreadSynchronizationContext
struct ThreadSynchronizationContext_tF420C4E811585DBD12B49A48FCD46C8F6EBE208C;
// System.Threading.Timer
struct Timer_t31BE4EDDA5C1CB5CFDF698231850B47B7F9DE9CB;
// System.Threading.TimerCallback
struct TimerCallback_tD193CC50BF27E129E6857E1E8A7EAC24BD131814;
// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1;
// System.Type
struct Type_t;
// ILRuntime.Mono.Cecil.TypeDefinition
struct TypeDefinition_tDB5BC46957B9F256FE082FE78EC8121F8F72CF0F;
// ILRuntime.Mono.Cecil.TypeReference
struct TypeReference_t72C4131E60A79E1B419C38BF5DD0C213033BB425;
// UnityEngine.Networking.UnityWebRequest
struct UnityWebRequest_tB75B39F6951CA0DBA2D5BEDF85FDCAAC6026A37E;
// System.Uri
struct Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612;
// System.UriParser
struct UriParser_t6DEBE5C6CDC3C29C9019CD951C7ECEBD6A5D3E3A;
// ValueTypeBindingDemo
struct ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// ET.WChannel
struct WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93;
// ET.WService
struct WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1;
// UnityEngine.WWW
struct WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013;
// System.Net.WebSockets.WebSocket
struct WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D;
// System.Net.WebSockets.WebSocketHandle
struct WebSocketHandle_t39F2F748886F0AEA42BB56CB4836BA17834AD3A4;
// System.Net.WebSockets.WebSocketReceiveResult
struct WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122;
// System.Security.Cryptography.X509Certificates.X509Certificate
struct X509Certificate_t6F3E94ED7C8FB33253E4705C76A40144E59F0553;
// System.Net.HttpListener/ExtendedProtectionSelector
struct ExtendedProtectionSelector_tD26A07B8EFF1BE64214537F2B6242618D134BAAE;
// ET.MonoBehaviourAdapter/Adaptor
struct Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_t32CD2C230786712954C1DB518DBE420A1F4C7974;
// System.Threading.Tasks.Task/ContingentProperties
struct ContingentProperties_t1E249C737B8B8644ED1D60EEFA101D326B199EA0;
// System.Uri/UriInfo
struct UriInfo_tCB2302A896132D1F70E47C3895FAB9A0F2A6EE45;
// ValueTypeBindingDemo/<LoadHotFixAssembly>d__4
struct U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785;
// ET.WChannel/<>c__DisplayClass11_0
struct U3CU3Ec__DisplayClass11_0_tBF6C144A4B80DF4937B39E39D7900DE33A416F40;
// instantiateEffectCaller/chainEffect
struct chainEffect_t86AB203988F70EBB301E81E78456C8BC8D99F8EE;
// particleColorChanger/colorChange
struct colorChange_t90D67E9441CA1F572801FE59E3CBDA1416AFF4B5;
// projectileActor/projectile
struct projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9;

IL2CPP_EXTERN_C RuntimeClass* AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerable_1_tBD60400523D840591A17E4CBBACC79397F68FAA2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_1_t0DE5AA701B682A891412350E63D3E441F98F205C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MissingReferenceException_t0957F7F403A0B9249CE6AB66FAD46E626F787EE8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NullReferenceException_t44B4F3CDE3111E74591952B8BE8707B28866D724_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PdbReaderProvider_tD6CADF6205DDD9BB74AE340FE5FF73794FD2361C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral2D3C540F0573F47B63A168DBF2502AFB95812B8A;
IL2CPP_EXTERN_C String_t* _stringLiteral6F94F2594F44480FF62C6897BADE0E43E8B80580;
IL2CPP_EXTERN_C String_t* _stringLiteral7DE18B9B94414FE9BDBA0668D8B260329D4DF2AA;
IL2CPP_EXTERN_C String_t* _stringLiteral8243A16D425F93AF62CAAB2BFAE01A2D6246A5FE;
IL2CPP_EXTERN_C String_t* _stringLiteral876BA9D37F5B3B86B1953A81D0C931AE6AFB2BED;
IL2CPP_EXTERN_C String_t* _stringLiteralCCDFA92C7C90AFE4EE7318DA274C1053FF9D7695;
IL2CPP_EXTERN_C String_t* _stringLiteralCD3284491A66FAA2DF335D327F62D690553DD236;
IL2CPP_EXTERN_C String_t* _stringLiteralCF489FF8F40BBA37AA37DDF596A798640FCFD888;
IL2CPP_EXTERN_C const RuntimeMethod* ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D_mADD06B426C3D8B131B2D9AF08601BAB40AE72515_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F_mC22F9B7E118032FDAE087379683D6E4516C0BFC3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_mEA97895401C9E128BC88F3D235F7BC79D107D052_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_m70C423FEFD680FB2A62EB0131C67A46D80F73C1F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_mACF8F057852CBC55283D1FB99088AFA3DB047A2C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_mFD39C7F5DE149D2283C6E3634B13E448F6EDD262_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA_m73E39109983EA3E233B4541A6358DD15797D8F31_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m6FB0816A8B00FD9C3EDC5827C4A2E97FF700B397_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162_mF0CD29EE2B7DAEB89BF469B893F9CD822C6DD7C1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Queue_1_Dequeue_m2EA4ED50C9D3AFC5608B9ACDF7C611D244872F0D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Queue_1_get_Count_m1D55723B47270D04849E24BC09480DCD17C0CEBA_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskAwaiter_1_GetResult_m9F9A1E7D4504D843ACF08CB847674ACB717B07B7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskAwaiter_1_GetResult_mCDCAAF89F5D74175A37B6E9F507C970EDAF07B97_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskAwaiter_1_GetResult_mCE6EEB08A3F3CD7DA4D0B764AC8A22E5AE8242A8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskAwaiter_1_get_IsCompleted_m0450A198520AE843F0245B5CF36EEC50B4718E0B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskAwaiter_1_get_IsCompleted_m2D13C0370C28B8EA4406A35F0A8BC012DF3C8537_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskAwaiter_1_get_IsCompleted_m5407555CDC2063AC7E69154390A144F53D7B370F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Task_1_GetAwaiter_m03F3C2C642FE0130BAE3F8BBFAB13E7BB19707B3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Task_1_GetAwaiter_m4323D9958B429E8928A9758244674DB503E63EF4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Task_1_GetAwaiter_m46A488400364A14C5B4A6B616BD7A1BB08927520_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CLoadHotFixAssemblyU3Ed__4_System_Collections_IEnumerator_Reset_mB67512B97B229931E43B55700F18385A3E1429AD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CStartAcceptU3Ed__12_MoveNext_mBF535DCEC52A35459F64CF39C14B0B8685F2110D_RuntimeMethod_var;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.Collections.Generic.Dictionary`2<System.Int64,ET.WChannel>
struct Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_tAABE5B350D6633F77FB521249CD73E89ADFEFA90* ___entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::count
	int32_t ___count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::version
	int32_t ___version_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeList
	int32_t ___freeList_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeCount
	int32_t ___freeCount_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::comparer
	RuntimeObject* ___comparer_6;
	// System.Collections.Generic.Dictionary`2/KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::keys
	KeyCollection_tF9F6C15485F9E60A0BBE89C462BB0229B7198E81 * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_tBD9F1B24DDF167BD643135CD60C898042AD8E637 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___entries_1)); }
	inline EntryU5BU5D_tAABE5B350D6633F77FB521249CD73E89ADFEFA90* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_tAABE5B350D6633F77FB521249CD73E89ADFEFA90** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_tAABE5B350D6633F77FB521249CD73E89ADFEFA90* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___keys_7)); }
	inline KeyCollection_tF9F6C15485F9E60A0BBE89C462BB0229B7198E81 * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_tF9F6C15485F9E60A0BBE89C462BB0229B7198E81 ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_tF9F6C15485F9E60A0BBE89C462BB0229B7198E81 * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ___values_8)); }
	inline ValueCollection_tBD9F1B24DDF167BD643135CD60C898042AD8E637 * get_values_8() const { return ___values_8; }
	inline ValueCollection_tBD9F1B24DDF167BD643135CD60C898042AD8E637 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_tBD9F1B24DDF167BD643135CD60C898042AD8E637 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_9), (void*)value);
	}
};


// System.Collections.Generic.Queue`1<System.Byte[]>
struct Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.Queue`1::_array
	ByteU5BU5DU5BU5D_t95107DE217CCFA8CD77945AC2CB9492D4D01FE8D* ____array_0;
	// System.Int32 System.Collections.Generic.Queue`1::_head
	int32_t ____head_1;
	// System.Int32 System.Collections.Generic.Queue`1::_tail
	int32_t ____tail_2;
	// System.Int32 System.Collections.Generic.Queue`1::_size
	int32_t ____size_3;
	// System.Int32 System.Collections.Generic.Queue`1::_version
	int32_t ____version_4;
	// System.Object System.Collections.Generic.Queue`1::_syncRoot
	RuntimeObject * ____syncRoot_5;

public:
	inline static int32_t get_offset_of__array_0() { return static_cast<int32_t>(offsetof(Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4, ____array_0)); }
	inline ByteU5BU5DU5BU5D_t95107DE217CCFA8CD77945AC2CB9492D4D01FE8D* get__array_0() const { return ____array_0; }
	inline ByteU5BU5DU5BU5D_t95107DE217CCFA8CD77945AC2CB9492D4D01FE8D** get_address_of__array_0() { return &____array_0; }
	inline void set__array_0(ByteU5BU5DU5BU5D_t95107DE217CCFA8CD77945AC2CB9492D4D01FE8D* value)
	{
		____array_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____array_0), (void*)value);
	}

	inline static int32_t get_offset_of__head_1() { return static_cast<int32_t>(offsetof(Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4, ____head_1)); }
	inline int32_t get__head_1() const { return ____head_1; }
	inline int32_t* get_address_of__head_1() { return &____head_1; }
	inline void set__head_1(int32_t value)
	{
		____head_1 = value;
	}

	inline static int32_t get_offset_of__tail_2() { return static_cast<int32_t>(offsetof(Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4, ____tail_2)); }
	inline int32_t get__tail_2() const { return ____tail_2; }
	inline int32_t* get_address_of__tail_2() { return &____tail_2; }
	inline void set__tail_2(int32_t value)
	{
		____tail_2 = value;
	}

	inline static int32_t get_offset_of__size_3() { return static_cast<int32_t>(offsetof(Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4, ____size_3)); }
	inline int32_t get__size_3() const { return ____size_3; }
	inline int32_t* get_address_of__size_3() { return &____size_3; }
	inline void set__size_3(int32_t value)
	{
		____size_3 = value;
	}

	inline static int32_t get_offset_of__version_4() { return static_cast<int32_t>(offsetof(Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4, ____version_4)); }
	inline int32_t get__version_4() const { return ____version_4; }
	inline int32_t* get_address_of__version_4() { return &____version_4; }
	inline void set__version_4(int32_t value)
	{
		____version_4 = value;
	}

	inline static int32_t get_offset_of__syncRoot_5() { return static_cast<int32_t>(offsetof(Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4, ____syncRoot_5)); }
	inline RuntimeObject * get__syncRoot_5() const { return ____syncRoot_5; }
	inline RuntimeObject ** get_address_of__syncRoot_5() { return &____syncRoot_5; }
	inline void set__syncRoot_5(RuntimeObject * value)
	{
		____syncRoot_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_5), (void*)value);
	}
};


// System.Collections.Generic.Queue`1<System.Object>
struct Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.Queue`1::_array
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ____array_0;
	// System.Int32 System.Collections.Generic.Queue`1::_head
	int32_t ____head_1;
	// System.Int32 System.Collections.Generic.Queue`1::_tail
	int32_t ____tail_2;
	// System.Int32 System.Collections.Generic.Queue`1::_size
	int32_t ____size_3;
	// System.Int32 System.Collections.Generic.Queue`1::_version
	int32_t ____version_4;
	// System.Object System.Collections.Generic.Queue`1::_syncRoot
	RuntimeObject * ____syncRoot_5;

public:
	inline static int32_t get_offset_of__array_0() { return static_cast<int32_t>(offsetof(Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64, ____array_0)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get__array_0() const { return ____array_0; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of__array_0() { return &____array_0; }
	inline void set__array_0(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		____array_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____array_0), (void*)value);
	}

	inline static int32_t get_offset_of__head_1() { return static_cast<int32_t>(offsetof(Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64, ____head_1)); }
	inline int32_t get__head_1() const { return ____head_1; }
	inline int32_t* get_address_of__head_1() { return &____head_1; }
	inline void set__head_1(int32_t value)
	{
		____head_1 = value;
	}

	inline static int32_t get_offset_of__tail_2() { return static_cast<int32_t>(offsetof(Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64, ____tail_2)); }
	inline int32_t get__tail_2() const { return ____tail_2; }
	inline int32_t* get_address_of__tail_2() { return &____tail_2; }
	inline void set__tail_2(int32_t value)
	{
		____tail_2 = value;
	}

	inline static int32_t get_offset_of__size_3() { return static_cast<int32_t>(offsetof(Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64, ____size_3)); }
	inline int32_t get__size_3() const { return ____size_3; }
	inline int32_t* get_address_of__size_3() { return &____size_3; }
	inline void set__size_3(int32_t value)
	{
		____size_3 = value;
	}

	inline static int32_t get_offset_of__version_4() { return static_cast<int32_t>(offsetof(Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64, ____version_4)); }
	inline int32_t get__version_4() const { return ____version_4; }
	inline int32_t* get_address_of__version_4() { return &____version_4; }
	inline void set__version_4(int32_t value)
	{
		____version_4 = value;
	}

	inline static int32_t get_offset_of__syncRoot_5() { return static_cast<int32_t>(offsetof(Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64, ____syncRoot_5)); }
	inline RuntimeObject * get__syncRoot_5() const { return ____syncRoot_5; }
	inline RuntimeObject ** get_address_of__syncRoot_5() { return &____syncRoot_5; }
	inline void set__syncRoot_5(RuntimeObject * value)
	{
		____syncRoot_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_5), (void*)value);
	}
};


// ILRuntime.Runtime.Enviorment.AppDomain
struct AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371  : public RuntimeObject
{
public:
	// System.Collections.Generic.Queue`1<ILRuntime.Runtime.Intepreter.ILIntepreter> ILRuntime.Runtime.Enviorment.AppDomain::freeIntepreters
	Queue_1_t9AF11493932D68D1ED7D097E9F520EB41308612F * ___freeIntepreters_0;
	// System.Collections.Generic.Dictionary`2<System.Int32,ILRuntime.Runtime.Intepreter.ILIntepreter> ILRuntime.Runtime.Enviorment.AppDomain::intepreters
	Dictionary_2_t0498150D64162A220E50F416A2B03CBC3208917A * ___intepreters_1;
	// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.CrossBindingAdaptor> ILRuntime.Runtime.Enviorment.AppDomain::crossAdaptors
	Dictionary_2_t3B6E7F8E03E7F33A003842F91DE56BC9FF84FC04 * ___crossAdaptors_2;
	// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.ValueTypeBinder> ILRuntime.Runtime.Enviorment.AppDomain::valueTypeBinders
	Dictionary_2_tE83DE222A73949FDCD78F1120B67AFC69707746D * ___valueTypeBinders_3;
	// ILRuntime.Other.ThreadSafeDictionary`2<System.String,ILRuntime.CLR.TypeSystem.IType> ILRuntime.Runtime.Enviorment.AppDomain::mapType
	ThreadSafeDictionary_2_tA87BD25CEAE3FA571238F58A44EA82D417F99F01 * ___mapType_4;
	// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.CLR.TypeSystem.IType> ILRuntime.Runtime.Enviorment.AppDomain::clrTypeMapping
	Dictionary_2_t19C57C1FBC50115D03F52B2AADFC57ED62F6374F * ___clrTypeMapping_5;
	// System.Collections.Generic.List`1<ILRuntime.CLR.TypeSystem.IType> ILRuntime.Runtime.Enviorment.AppDomain::typesByIndex
	List_1_t87CDBC8651F8EEFB19B40ED5D2C9B2C35CED9BC8 * ___typesByIndex_6;
	// ILRuntime.Other.ThreadSafeDictionary`2<System.Int32,ILRuntime.CLR.TypeSystem.IType> ILRuntime.Runtime.Enviorment.AppDomain::mapTypeToken
	ThreadSafeDictionary_2_t19585080272B2201A8232E71A9942469F3AD34C8 * ___mapTypeToken_7;
	// ILRuntime.Other.ThreadSafeDictionary`2<System.Int32,ILRuntime.CLR.Method.IMethod> ILRuntime.Runtime.Enviorment.AppDomain::mapMethod
	ThreadSafeDictionary_2_tA2E86FABA4D232D732E0A14EA8C5248591B338B2 * ___mapMethod_8;
	// ILRuntime.Other.ThreadSafeDictionary`2<System.Int64,System.String> ILRuntime.Runtime.Enviorment.AppDomain::mapString
	ThreadSafeDictionary_2_tCF79B0B6F2A588A98A6FE793ADCCEE3FE975434B * ___mapString_9;
	// System.Collections.Generic.Dictionary`2<System.Reflection.MethodBase,ILRuntime.Runtime.Enviorment.CLRRedirectionDelegate> ILRuntime.Runtime.Enviorment.AppDomain::redirectMap
	Dictionary_2_tECEB4010F857D3A74927A65E4E1FD022D1DE9446 * ___redirectMap_10;
	// System.Collections.Generic.Dictionary`2<System.Reflection.FieldInfo,ILRuntime.Runtime.Enviorment.CLRFieldGetterDelegate> ILRuntime.Runtime.Enviorment.AppDomain::fieldGetterMap
	Dictionary_2_t22C480C209A674253ACD2CFCB944227F9742EA45 * ___fieldGetterMap_11;
	// System.Collections.Generic.Dictionary`2<System.Reflection.FieldInfo,ILRuntime.Runtime.Enviorment.CLRFieldSetterDelegate> ILRuntime.Runtime.Enviorment.AppDomain::fieldSetterMap
	Dictionary_2_tD0995A54F52C664DA4414EEA7D5455E3392135DD * ___fieldSetterMap_12;
	// System.Collections.Generic.Dictionary`2<System.Reflection.FieldInfo,System.Collections.Generic.KeyValuePair`2<ILRuntime.Runtime.Enviorment.CLRFieldBindingDelegate,ILRuntime.Runtime.Enviorment.CLRFieldBindingDelegate>> ILRuntime.Runtime.Enviorment.AppDomain::fieldBindingMap
	Dictionary_2_tDAC370053A1E5D6045467E2B48C4266C64ED4025 * ___fieldBindingMap_13;
	// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.CLRMemberwiseCloneDelegate> ILRuntime.Runtime.Enviorment.AppDomain::memberwiseCloneMap
	Dictionary_2_tFE7AF4DDB7938F8E050A59DB8772E6F2FAC3F3C9 * ___memberwiseCloneMap_14;
	// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.CLRCreateDefaultInstanceDelegate> ILRuntime.Runtime.Enviorment.AppDomain::createDefaultInstanceMap
	Dictionary_2_t334DF8318ABD34FE4D86B27506FB4188CCA51679 * ___createDefaultInstanceMap_15;
	// System.Collections.Generic.Dictionary`2<System.Type,ILRuntime.Runtime.Enviorment.CLRCreateArrayInstanceDelegate> ILRuntime.Runtime.Enviorment.AppDomain::createArrayInstanceMap
	Dictionary_2_tDBB96F3778A1819B94D6661F5BBC0289A0061AA6 * ___createArrayInstanceMap_16;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.Runtime.Enviorment.AppDomain::voidType
	RuntimeObject* ___voidType_17;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.Runtime.Enviorment.AppDomain::intType
	RuntimeObject* ___intType_18;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.Runtime.Enviorment.AppDomain::longType
	RuntimeObject* ___longType_19;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.Runtime.Enviorment.AppDomain::boolType
	RuntimeObject* ___boolType_20;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.Runtime.Enviorment.AppDomain::floatType
	RuntimeObject* ___floatType_21;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.Runtime.Enviorment.AppDomain::doubleType
	RuntimeObject* ___doubleType_22;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.Runtime.Enviorment.AppDomain::objectType
	RuntimeObject* ___objectType_23;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.Runtime.Enviorment.AppDomain::jitAttributeType
	RuntimeObject* ___jitAttributeType_24;
	// ILRuntime.Runtime.Enviorment.DelegateManager ILRuntime.Runtime.Enviorment.AppDomain::dMgr
	DelegateManager_t27AAC9E0AC29D01AB6056BEF61D340C3344C4E6B * ___dMgr_25;
	// System.Reflection.Assembly[] ILRuntime.Runtime.Enviorment.AppDomain::loadedAssemblies
	AssemblyU5BU5D_t42061B4CA43487DD8ECD8C3AACCEF783FA081FF0* ___loadedAssemblies_26;
	// System.Collections.Generic.Dictionary`2<System.String,System.Byte[]> ILRuntime.Runtime.Enviorment.AppDomain::references
	Dictionary_2_tEB463D000DF6B3D1706F993599896D44D951DDD5 * ___references_27;
	// ILRuntime.Runtime.Debugger.DebugService ILRuntime.Runtime.Enviorment.AppDomain::debugService
	DebugService_tC7C54FE8596DE1526A35F74FBA8D94A3B18CAF31 * ___debugService_28;
	// ILRuntime.Runtime.Intepreter.RegisterVM.AsyncJITCompileWorker ILRuntime.Runtime.Enviorment.AppDomain::jitWorker
	AsyncJITCompileWorker_tF9A53213C842B49DA4941078092524971B0AA02F * ___jitWorker_29;
	// System.Int32 ILRuntime.Runtime.Enviorment.AppDomain::defaultJITFlags
	int32_t ___defaultJITFlags_30;
	// System.Boolean ILRuntime.Runtime.Enviorment.AppDomain::<AllowUnboundCLRMethod>k__BackingField
	bool ___U3CAllowUnboundCLRMethodU3Ek__BackingField_31;
	// System.Boolean ILRuntime.Runtime.Enviorment.AppDomain::<SuppressStaticConstructor>k__BackingField
	bool ___U3CSuppressStaticConstructorU3Ek__BackingField_32;
	// System.Boolean ILRuntime.Runtime.Enviorment.AppDomain::IsThreadBinding
	bool ___IsThreadBinding_33;
	// System.Boolean ILRuntime.Runtime.Enviorment.AppDomain::IsBindingDone
	bool ___IsBindingDone_34;

public:
	inline static int32_t get_offset_of_freeIntepreters_0() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___freeIntepreters_0)); }
	inline Queue_1_t9AF11493932D68D1ED7D097E9F520EB41308612F * get_freeIntepreters_0() const { return ___freeIntepreters_0; }
	inline Queue_1_t9AF11493932D68D1ED7D097E9F520EB41308612F ** get_address_of_freeIntepreters_0() { return &___freeIntepreters_0; }
	inline void set_freeIntepreters_0(Queue_1_t9AF11493932D68D1ED7D097E9F520EB41308612F * value)
	{
		___freeIntepreters_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___freeIntepreters_0), (void*)value);
	}

	inline static int32_t get_offset_of_intepreters_1() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___intepreters_1)); }
	inline Dictionary_2_t0498150D64162A220E50F416A2B03CBC3208917A * get_intepreters_1() const { return ___intepreters_1; }
	inline Dictionary_2_t0498150D64162A220E50F416A2B03CBC3208917A ** get_address_of_intepreters_1() { return &___intepreters_1; }
	inline void set_intepreters_1(Dictionary_2_t0498150D64162A220E50F416A2B03CBC3208917A * value)
	{
		___intepreters_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___intepreters_1), (void*)value);
	}

	inline static int32_t get_offset_of_crossAdaptors_2() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___crossAdaptors_2)); }
	inline Dictionary_2_t3B6E7F8E03E7F33A003842F91DE56BC9FF84FC04 * get_crossAdaptors_2() const { return ___crossAdaptors_2; }
	inline Dictionary_2_t3B6E7F8E03E7F33A003842F91DE56BC9FF84FC04 ** get_address_of_crossAdaptors_2() { return &___crossAdaptors_2; }
	inline void set_crossAdaptors_2(Dictionary_2_t3B6E7F8E03E7F33A003842F91DE56BC9FF84FC04 * value)
	{
		___crossAdaptors_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___crossAdaptors_2), (void*)value);
	}

	inline static int32_t get_offset_of_valueTypeBinders_3() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___valueTypeBinders_3)); }
	inline Dictionary_2_tE83DE222A73949FDCD78F1120B67AFC69707746D * get_valueTypeBinders_3() const { return ___valueTypeBinders_3; }
	inline Dictionary_2_tE83DE222A73949FDCD78F1120B67AFC69707746D ** get_address_of_valueTypeBinders_3() { return &___valueTypeBinders_3; }
	inline void set_valueTypeBinders_3(Dictionary_2_tE83DE222A73949FDCD78F1120B67AFC69707746D * value)
	{
		___valueTypeBinders_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___valueTypeBinders_3), (void*)value);
	}

	inline static int32_t get_offset_of_mapType_4() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___mapType_4)); }
	inline ThreadSafeDictionary_2_tA87BD25CEAE3FA571238F58A44EA82D417F99F01 * get_mapType_4() const { return ___mapType_4; }
	inline ThreadSafeDictionary_2_tA87BD25CEAE3FA571238F58A44EA82D417F99F01 ** get_address_of_mapType_4() { return &___mapType_4; }
	inline void set_mapType_4(ThreadSafeDictionary_2_tA87BD25CEAE3FA571238F58A44EA82D417F99F01 * value)
	{
		___mapType_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mapType_4), (void*)value);
	}

	inline static int32_t get_offset_of_clrTypeMapping_5() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___clrTypeMapping_5)); }
	inline Dictionary_2_t19C57C1FBC50115D03F52B2AADFC57ED62F6374F * get_clrTypeMapping_5() const { return ___clrTypeMapping_5; }
	inline Dictionary_2_t19C57C1FBC50115D03F52B2AADFC57ED62F6374F ** get_address_of_clrTypeMapping_5() { return &___clrTypeMapping_5; }
	inline void set_clrTypeMapping_5(Dictionary_2_t19C57C1FBC50115D03F52B2AADFC57ED62F6374F * value)
	{
		___clrTypeMapping_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___clrTypeMapping_5), (void*)value);
	}

	inline static int32_t get_offset_of_typesByIndex_6() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___typesByIndex_6)); }
	inline List_1_t87CDBC8651F8EEFB19B40ED5D2C9B2C35CED9BC8 * get_typesByIndex_6() const { return ___typesByIndex_6; }
	inline List_1_t87CDBC8651F8EEFB19B40ED5D2C9B2C35CED9BC8 ** get_address_of_typesByIndex_6() { return &___typesByIndex_6; }
	inline void set_typesByIndex_6(List_1_t87CDBC8651F8EEFB19B40ED5D2C9B2C35CED9BC8 * value)
	{
		___typesByIndex_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___typesByIndex_6), (void*)value);
	}

	inline static int32_t get_offset_of_mapTypeToken_7() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___mapTypeToken_7)); }
	inline ThreadSafeDictionary_2_t19585080272B2201A8232E71A9942469F3AD34C8 * get_mapTypeToken_7() const { return ___mapTypeToken_7; }
	inline ThreadSafeDictionary_2_t19585080272B2201A8232E71A9942469F3AD34C8 ** get_address_of_mapTypeToken_7() { return &___mapTypeToken_7; }
	inline void set_mapTypeToken_7(ThreadSafeDictionary_2_t19585080272B2201A8232E71A9942469F3AD34C8 * value)
	{
		___mapTypeToken_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mapTypeToken_7), (void*)value);
	}

	inline static int32_t get_offset_of_mapMethod_8() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___mapMethod_8)); }
	inline ThreadSafeDictionary_2_tA2E86FABA4D232D732E0A14EA8C5248591B338B2 * get_mapMethod_8() const { return ___mapMethod_8; }
	inline ThreadSafeDictionary_2_tA2E86FABA4D232D732E0A14EA8C5248591B338B2 ** get_address_of_mapMethod_8() { return &___mapMethod_8; }
	inline void set_mapMethod_8(ThreadSafeDictionary_2_tA2E86FABA4D232D732E0A14EA8C5248591B338B2 * value)
	{
		___mapMethod_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mapMethod_8), (void*)value);
	}

	inline static int32_t get_offset_of_mapString_9() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___mapString_9)); }
	inline ThreadSafeDictionary_2_tCF79B0B6F2A588A98A6FE793ADCCEE3FE975434B * get_mapString_9() const { return ___mapString_9; }
	inline ThreadSafeDictionary_2_tCF79B0B6F2A588A98A6FE793ADCCEE3FE975434B ** get_address_of_mapString_9() { return &___mapString_9; }
	inline void set_mapString_9(ThreadSafeDictionary_2_tCF79B0B6F2A588A98A6FE793ADCCEE3FE975434B * value)
	{
		___mapString_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mapString_9), (void*)value);
	}

	inline static int32_t get_offset_of_redirectMap_10() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___redirectMap_10)); }
	inline Dictionary_2_tECEB4010F857D3A74927A65E4E1FD022D1DE9446 * get_redirectMap_10() const { return ___redirectMap_10; }
	inline Dictionary_2_tECEB4010F857D3A74927A65E4E1FD022D1DE9446 ** get_address_of_redirectMap_10() { return &___redirectMap_10; }
	inline void set_redirectMap_10(Dictionary_2_tECEB4010F857D3A74927A65E4E1FD022D1DE9446 * value)
	{
		___redirectMap_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___redirectMap_10), (void*)value);
	}

	inline static int32_t get_offset_of_fieldGetterMap_11() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___fieldGetterMap_11)); }
	inline Dictionary_2_t22C480C209A674253ACD2CFCB944227F9742EA45 * get_fieldGetterMap_11() const { return ___fieldGetterMap_11; }
	inline Dictionary_2_t22C480C209A674253ACD2CFCB944227F9742EA45 ** get_address_of_fieldGetterMap_11() { return &___fieldGetterMap_11; }
	inline void set_fieldGetterMap_11(Dictionary_2_t22C480C209A674253ACD2CFCB944227F9742EA45 * value)
	{
		___fieldGetterMap_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fieldGetterMap_11), (void*)value);
	}

	inline static int32_t get_offset_of_fieldSetterMap_12() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___fieldSetterMap_12)); }
	inline Dictionary_2_tD0995A54F52C664DA4414EEA7D5455E3392135DD * get_fieldSetterMap_12() const { return ___fieldSetterMap_12; }
	inline Dictionary_2_tD0995A54F52C664DA4414EEA7D5455E3392135DD ** get_address_of_fieldSetterMap_12() { return &___fieldSetterMap_12; }
	inline void set_fieldSetterMap_12(Dictionary_2_tD0995A54F52C664DA4414EEA7D5455E3392135DD * value)
	{
		___fieldSetterMap_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fieldSetterMap_12), (void*)value);
	}

	inline static int32_t get_offset_of_fieldBindingMap_13() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___fieldBindingMap_13)); }
	inline Dictionary_2_tDAC370053A1E5D6045467E2B48C4266C64ED4025 * get_fieldBindingMap_13() const { return ___fieldBindingMap_13; }
	inline Dictionary_2_tDAC370053A1E5D6045467E2B48C4266C64ED4025 ** get_address_of_fieldBindingMap_13() { return &___fieldBindingMap_13; }
	inline void set_fieldBindingMap_13(Dictionary_2_tDAC370053A1E5D6045467E2B48C4266C64ED4025 * value)
	{
		___fieldBindingMap_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fieldBindingMap_13), (void*)value);
	}

	inline static int32_t get_offset_of_memberwiseCloneMap_14() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___memberwiseCloneMap_14)); }
	inline Dictionary_2_tFE7AF4DDB7938F8E050A59DB8772E6F2FAC3F3C9 * get_memberwiseCloneMap_14() const { return ___memberwiseCloneMap_14; }
	inline Dictionary_2_tFE7AF4DDB7938F8E050A59DB8772E6F2FAC3F3C9 ** get_address_of_memberwiseCloneMap_14() { return &___memberwiseCloneMap_14; }
	inline void set_memberwiseCloneMap_14(Dictionary_2_tFE7AF4DDB7938F8E050A59DB8772E6F2FAC3F3C9 * value)
	{
		___memberwiseCloneMap_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___memberwiseCloneMap_14), (void*)value);
	}

	inline static int32_t get_offset_of_createDefaultInstanceMap_15() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___createDefaultInstanceMap_15)); }
	inline Dictionary_2_t334DF8318ABD34FE4D86B27506FB4188CCA51679 * get_createDefaultInstanceMap_15() const { return ___createDefaultInstanceMap_15; }
	inline Dictionary_2_t334DF8318ABD34FE4D86B27506FB4188CCA51679 ** get_address_of_createDefaultInstanceMap_15() { return &___createDefaultInstanceMap_15; }
	inline void set_createDefaultInstanceMap_15(Dictionary_2_t334DF8318ABD34FE4D86B27506FB4188CCA51679 * value)
	{
		___createDefaultInstanceMap_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___createDefaultInstanceMap_15), (void*)value);
	}

	inline static int32_t get_offset_of_createArrayInstanceMap_16() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___createArrayInstanceMap_16)); }
	inline Dictionary_2_tDBB96F3778A1819B94D6661F5BBC0289A0061AA6 * get_createArrayInstanceMap_16() const { return ___createArrayInstanceMap_16; }
	inline Dictionary_2_tDBB96F3778A1819B94D6661F5BBC0289A0061AA6 ** get_address_of_createArrayInstanceMap_16() { return &___createArrayInstanceMap_16; }
	inline void set_createArrayInstanceMap_16(Dictionary_2_tDBB96F3778A1819B94D6661F5BBC0289A0061AA6 * value)
	{
		___createArrayInstanceMap_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___createArrayInstanceMap_16), (void*)value);
	}

	inline static int32_t get_offset_of_voidType_17() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___voidType_17)); }
	inline RuntimeObject* get_voidType_17() const { return ___voidType_17; }
	inline RuntimeObject** get_address_of_voidType_17() { return &___voidType_17; }
	inline void set_voidType_17(RuntimeObject* value)
	{
		___voidType_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___voidType_17), (void*)value);
	}

	inline static int32_t get_offset_of_intType_18() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___intType_18)); }
	inline RuntimeObject* get_intType_18() const { return ___intType_18; }
	inline RuntimeObject** get_address_of_intType_18() { return &___intType_18; }
	inline void set_intType_18(RuntimeObject* value)
	{
		___intType_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___intType_18), (void*)value);
	}

	inline static int32_t get_offset_of_longType_19() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___longType_19)); }
	inline RuntimeObject* get_longType_19() const { return ___longType_19; }
	inline RuntimeObject** get_address_of_longType_19() { return &___longType_19; }
	inline void set_longType_19(RuntimeObject* value)
	{
		___longType_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___longType_19), (void*)value);
	}

	inline static int32_t get_offset_of_boolType_20() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___boolType_20)); }
	inline RuntimeObject* get_boolType_20() const { return ___boolType_20; }
	inline RuntimeObject** get_address_of_boolType_20() { return &___boolType_20; }
	inline void set_boolType_20(RuntimeObject* value)
	{
		___boolType_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___boolType_20), (void*)value);
	}

	inline static int32_t get_offset_of_floatType_21() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___floatType_21)); }
	inline RuntimeObject* get_floatType_21() const { return ___floatType_21; }
	inline RuntimeObject** get_address_of_floatType_21() { return &___floatType_21; }
	inline void set_floatType_21(RuntimeObject* value)
	{
		___floatType_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___floatType_21), (void*)value);
	}

	inline static int32_t get_offset_of_doubleType_22() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___doubleType_22)); }
	inline RuntimeObject* get_doubleType_22() const { return ___doubleType_22; }
	inline RuntimeObject** get_address_of_doubleType_22() { return &___doubleType_22; }
	inline void set_doubleType_22(RuntimeObject* value)
	{
		___doubleType_22 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___doubleType_22), (void*)value);
	}

	inline static int32_t get_offset_of_objectType_23() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___objectType_23)); }
	inline RuntimeObject* get_objectType_23() const { return ___objectType_23; }
	inline RuntimeObject** get_address_of_objectType_23() { return &___objectType_23; }
	inline void set_objectType_23(RuntimeObject* value)
	{
		___objectType_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objectType_23), (void*)value);
	}

	inline static int32_t get_offset_of_jitAttributeType_24() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___jitAttributeType_24)); }
	inline RuntimeObject* get_jitAttributeType_24() const { return ___jitAttributeType_24; }
	inline RuntimeObject** get_address_of_jitAttributeType_24() { return &___jitAttributeType_24; }
	inline void set_jitAttributeType_24(RuntimeObject* value)
	{
		___jitAttributeType_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___jitAttributeType_24), (void*)value);
	}

	inline static int32_t get_offset_of_dMgr_25() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___dMgr_25)); }
	inline DelegateManager_t27AAC9E0AC29D01AB6056BEF61D340C3344C4E6B * get_dMgr_25() const { return ___dMgr_25; }
	inline DelegateManager_t27AAC9E0AC29D01AB6056BEF61D340C3344C4E6B ** get_address_of_dMgr_25() { return &___dMgr_25; }
	inline void set_dMgr_25(DelegateManager_t27AAC9E0AC29D01AB6056BEF61D340C3344C4E6B * value)
	{
		___dMgr_25 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dMgr_25), (void*)value);
	}

	inline static int32_t get_offset_of_loadedAssemblies_26() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___loadedAssemblies_26)); }
	inline AssemblyU5BU5D_t42061B4CA43487DD8ECD8C3AACCEF783FA081FF0* get_loadedAssemblies_26() const { return ___loadedAssemblies_26; }
	inline AssemblyU5BU5D_t42061B4CA43487DD8ECD8C3AACCEF783FA081FF0** get_address_of_loadedAssemblies_26() { return &___loadedAssemblies_26; }
	inline void set_loadedAssemblies_26(AssemblyU5BU5D_t42061B4CA43487DD8ECD8C3AACCEF783FA081FF0* value)
	{
		___loadedAssemblies_26 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___loadedAssemblies_26), (void*)value);
	}

	inline static int32_t get_offset_of_references_27() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___references_27)); }
	inline Dictionary_2_tEB463D000DF6B3D1706F993599896D44D951DDD5 * get_references_27() const { return ___references_27; }
	inline Dictionary_2_tEB463D000DF6B3D1706F993599896D44D951DDD5 ** get_address_of_references_27() { return &___references_27; }
	inline void set_references_27(Dictionary_2_tEB463D000DF6B3D1706F993599896D44D951DDD5 * value)
	{
		___references_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___references_27), (void*)value);
	}

	inline static int32_t get_offset_of_debugService_28() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___debugService_28)); }
	inline DebugService_tC7C54FE8596DE1526A35F74FBA8D94A3B18CAF31 * get_debugService_28() const { return ___debugService_28; }
	inline DebugService_tC7C54FE8596DE1526A35F74FBA8D94A3B18CAF31 ** get_address_of_debugService_28() { return &___debugService_28; }
	inline void set_debugService_28(DebugService_tC7C54FE8596DE1526A35F74FBA8D94A3B18CAF31 * value)
	{
		___debugService_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___debugService_28), (void*)value);
	}

	inline static int32_t get_offset_of_jitWorker_29() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___jitWorker_29)); }
	inline AsyncJITCompileWorker_tF9A53213C842B49DA4941078092524971B0AA02F * get_jitWorker_29() const { return ___jitWorker_29; }
	inline AsyncJITCompileWorker_tF9A53213C842B49DA4941078092524971B0AA02F ** get_address_of_jitWorker_29() { return &___jitWorker_29; }
	inline void set_jitWorker_29(AsyncJITCompileWorker_tF9A53213C842B49DA4941078092524971B0AA02F * value)
	{
		___jitWorker_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___jitWorker_29), (void*)value);
	}

	inline static int32_t get_offset_of_defaultJITFlags_30() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___defaultJITFlags_30)); }
	inline int32_t get_defaultJITFlags_30() const { return ___defaultJITFlags_30; }
	inline int32_t* get_address_of_defaultJITFlags_30() { return &___defaultJITFlags_30; }
	inline void set_defaultJITFlags_30(int32_t value)
	{
		___defaultJITFlags_30 = value;
	}

	inline static int32_t get_offset_of_U3CAllowUnboundCLRMethodU3Ek__BackingField_31() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___U3CAllowUnboundCLRMethodU3Ek__BackingField_31)); }
	inline bool get_U3CAllowUnboundCLRMethodU3Ek__BackingField_31() const { return ___U3CAllowUnboundCLRMethodU3Ek__BackingField_31; }
	inline bool* get_address_of_U3CAllowUnboundCLRMethodU3Ek__BackingField_31() { return &___U3CAllowUnboundCLRMethodU3Ek__BackingField_31; }
	inline void set_U3CAllowUnboundCLRMethodU3Ek__BackingField_31(bool value)
	{
		___U3CAllowUnboundCLRMethodU3Ek__BackingField_31 = value;
	}

	inline static int32_t get_offset_of_U3CSuppressStaticConstructorU3Ek__BackingField_32() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___U3CSuppressStaticConstructorU3Ek__BackingField_32)); }
	inline bool get_U3CSuppressStaticConstructorU3Ek__BackingField_32() const { return ___U3CSuppressStaticConstructorU3Ek__BackingField_32; }
	inline bool* get_address_of_U3CSuppressStaticConstructorU3Ek__BackingField_32() { return &___U3CSuppressStaticConstructorU3Ek__BackingField_32; }
	inline void set_U3CSuppressStaticConstructorU3Ek__BackingField_32(bool value)
	{
		___U3CSuppressStaticConstructorU3Ek__BackingField_32 = value;
	}

	inline static int32_t get_offset_of_IsThreadBinding_33() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___IsThreadBinding_33)); }
	inline bool get_IsThreadBinding_33() const { return ___IsThreadBinding_33; }
	inline bool* get_address_of_IsThreadBinding_33() { return &___IsThreadBinding_33; }
	inline void set_IsThreadBinding_33(bool value)
	{
		___IsThreadBinding_33 = value;
	}

	inline static int32_t get_offset_of_IsBindingDone_34() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371, ___IsBindingDone_34)); }
	inline bool get_IsBindingDone_34() const { return ___IsBindingDone_34; }
	inline bool* get_address_of_IsBindingDone_34() { return &___IsBindingDone_34; }
	inline void set_IsBindingDone_34(bool value)
	{
		___IsBindingDone_34 = value;
	}
};

struct AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371_StaticFields
{
public:
	// System.Object ILRuntime.Runtime.Enviorment.AppDomain::bindingLockObject
	RuntimeObject * ___bindingLockObject_35;

public:
	inline static int32_t get_offset_of_bindingLockObject_35() { return static_cast<int32_t>(offsetof(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371_StaticFields, ___bindingLockObject_35)); }
	inline RuntimeObject * get_bindingLockObject_35() const { return ___bindingLockObject_35; }
	inline RuntimeObject ** get_address_of_bindingLockObject_35() { return &___bindingLockObject_35; }
	inline void set_bindingLockObject_35(RuntimeObject * value)
	{
		___bindingLockObject_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___bindingLockObject_35), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// UnityEngine.CustomYieldInstruction
struct CustomYieldInstruction_t4ED1543FBAA3143362854EB1867B42E5D190A5C7  : public RuntimeObject
{
public:

public:
};


// System.Net.EndPoint
struct EndPoint_t18D4AE8D03090A2B262136E59F95CE61418C34DA  : public RuntimeObject
{
public:

public:
};


// System.Net.HttpListenerContext
struct HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117  : public RuntimeObject
{
public:
	// System.Net.HttpListenerRequest System.Net.HttpListenerContext::request
	HttpListenerRequest_tA211D6E12A7C62C874A8B2A794066534B80BF18F * ___request_0;
	// System.Net.HttpListenerResponse System.Net.HttpListenerContext::response
	HttpListenerResponse_t562C5F626301C5F39A8550549590D5B7D5061E6E * ___response_1;
	// System.Security.Principal.IPrincipal System.Net.HttpListenerContext::user
	RuntimeObject* ___user_2;
	// System.Net.HttpConnection System.Net.HttpListenerContext::cnc
	HttpConnection_t43F1696021071DFD5908CB5F1290EC15CE6AA1A0 * ___cnc_3;
	// System.String System.Net.HttpListenerContext::error
	String_t* ___error_4;
	// System.Int32 System.Net.HttpListenerContext::err_status
	int32_t ___err_status_5;
	// System.Net.HttpListener System.Net.HttpListenerContext::Listener
	HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * ___Listener_6;

public:
	inline static int32_t get_offset_of_request_0() { return static_cast<int32_t>(offsetof(HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117, ___request_0)); }
	inline HttpListenerRequest_tA211D6E12A7C62C874A8B2A794066534B80BF18F * get_request_0() const { return ___request_0; }
	inline HttpListenerRequest_tA211D6E12A7C62C874A8B2A794066534B80BF18F ** get_address_of_request_0() { return &___request_0; }
	inline void set_request_0(HttpListenerRequest_tA211D6E12A7C62C874A8B2A794066534B80BF18F * value)
	{
		___request_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___request_0), (void*)value);
	}

	inline static int32_t get_offset_of_response_1() { return static_cast<int32_t>(offsetof(HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117, ___response_1)); }
	inline HttpListenerResponse_t562C5F626301C5F39A8550549590D5B7D5061E6E * get_response_1() const { return ___response_1; }
	inline HttpListenerResponse_t562C5F626301C5F39A8550549590D5B7D5061E6E ** get_address_of_response_1() { return &___response_1; }
	inline void set_response_1(HttpListenerResponse_t562C5F626301C5F39A8550549590D5B7D5061E6E * value)
	{
		___response_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___response_1), (void*)value);
	}

	inline static int32_t get_offset_of_user_2() { return static_cast<int32_t>(offsetof(HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117, ___user_2)); }
	inline RuntimeObject* get_user_2() const { return ___user_2; }
	inline RuntimeObject** get_address_of_user_2() { return &___user_2; }
	inline void set_user_2(RuntimeObject* value)
	{
		___user_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___user_2), (void*)value);
	}

	inline static int32_t get_offset_of_cnc_3() { return static_cast<int32_t>(offsetof(HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117, ___cnc_3)); }
	inline HttpConnection_t43F1696021071DFD5908CB5F1290EC15CE6AA1A0 * get_cnc_3() const { return ___cnc_3; }
	inline HttpConnection_t43F1696021071DFD5908CB5F1290EC15CE6AA1A0 ** get_address_of_cnc_3() { return &___cnc_3; }
	inline void set_cnc_3(HttpConnection_t43F1696021071DFD5908CB5F1290EC15CE6AA1A0 * value)
	{
		___cnc_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___cnc_3), (void*)value);
	}

	inline static int32_t get_offset_of_error_4() { return static_cast<int32_t>(offsetof(HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117, ___error_4)); }
	inline String_t* get_error_4() const { return ___error_4; }
	inline String_t** get_address_of_error_4() { return &___error_4; }
	inline void set_error_4(String_t* value)
	{
		___error_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___error_4), (void*)value);
	}

	inline static int32_t get_offset_of_err_status_5() { return static_cast<int32_t>(offsetof(HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117, ___err_status_5)); }
	inline int32_t get_err_status_5() const { return ___err_status_5; }
	inline int32_t* get_address_of_err_status_5() { return &___err_status_5; }
	inline void set_err_status_5(int32_t value)
	{
		___err_status_5 = value;
	}

	inline static int32_t get_offset_of_Listener_6() { return static_cast<int32_t>(offsetof(HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117, ___Listener_6)); }
	inline HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * get_Listener_6() const { return ___Listener_6; }
	inline HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 ** get_address_of_Listener_6() { return &___Listener_6; }
	inline void set_Listener_6(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * value)
	{
		___Listener_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Listener_6), (void*)value);
	}
};


// System.Net.HttpListenerPrefixCollection
struct HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283  : public RuntimeObject
{
public:
	// System.Collections.Generic.List`1<System.String> System.Net.HttpListenerPrefixCollection::prefixes
	List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * ___prefixes_0;
	// System.Net.HttpListener System.Net.HttpListenerPrefixCollection::listener
	HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * ___listener_1;

public:
	inline static int32_t get_offset_of_prefixes_0() { return static_cast<int32_t>(offsetof(HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283, ___prefixes_0)); }
	inline List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * get_prefixes_0() const { return ___prefixes_0; }
	inline List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 ** get_address_of_prefixes_0() { return &___prefixes_0; }
	inline void set_prefixes_0(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * value)
	{
		___prefixes_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___prefixes_0), (void*)value);
	}

	inline static int32_t get_offset_of_listener_1() { return static_cast<int32_t>(offsetof(HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283, ___listener_1)); }
	inline HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * get_listener_1() const { return ___listener_1; }
	inline HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 ** get_address_of_listener_1() { return &___listener_1; }
	inline void set_listener_1(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * value)
	{
		___listener_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___listener_1), (void*)value);
	}
};


// ILRuntime.Runtime.Intepreter.ILTypeInstance
struct ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610  : public RuntimeObject
{
public:
	// ILRuntime.CLR.TypeSystem.ILType ILRuntime.Runtime.Intepreter.ILTypeInstance::type
	ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * ___type_0;
	// ILRuntime.Runtime.Stack.StackObject[] ILRuntime.Runtime.Intepreter.ILTypeInstance::fields
	StackObjectU5BU5D_t22EFA8CE63EDF2E1959505B7D91FCB790A838CF9* ___fields_1;
	// System.Collections.Generic.IList`1<System.Object> ILRuntime.Runtime.Intepreter.ILTypeInstance::managedObjs
	RuntimeObject* ___managedObjs_2;
	// System.Object ILRuntime.Runtime.Intepreter.ILTypeInstance::clrInstance
	RuntimeObject * ___clrInstance_3;
	// System.UInt64 ILRuntime.Runtime.Intepreter.ILTypeInstance::valueTypeMask
	uint64_t ___valueTypeMask_4;
	// System.Collections.Generic.Dictionary`2<ILRuntime.CLR.Method.ILMethod,ILRuntime.Runtime.Intepreter.IDelegateAdapter> ILRuntime.Runtime.Intepreter.ILTypeInstance::delegates
	Dictionary_2_tE1A83080A9D570401050D852D45604823051496B * ___delegates_5;
	// System.Boolean ILRuntime.Runtime.Intepreter.ILTypeInstance::<Boxed>k__BackingField
	bool ___U3CBoxedU3Ek__BackingField_6;

public:
	inline static int32_t get_offset_of_type_0() { return static_cast<int32_t>(offsetof(ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610, ___type_0)); }
	inline ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * get_type_0() const { return ___type_0; }
	inline ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 ** get_address_of_type_0() { return &___type_0; }
	inline void set_type_0(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * value)
	{
		___type_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___type_0), (void*)value);
	}

	inline static int32_t get_offset_of_fields_1() { return static_cast<int32_t>(offsetof(ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610, ___fields_1)); }
	inline StackObjectU5BU5D_t22EFA8CE63EDF2E1959505B7D91FCB790A838CF9* get_fields_1() const { return ___fields_1; }
	inline StackObjectU5BU5D_t22EFA8CE63EDF2E1959505B7D91FCB790A838CF9** get_address_of_fields_1() { return &___fields_1; }
	inline void set_fields_1(StackObjectU5BU5D_t22EFA8CE63EDF2E1959505B7D91FCB790A838CF9* value)
	{
		___fields_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fields_1), (void*)value);
	}

	inline static int32_t get_offset_of_managedObjs_2() { return static_cast<int32_t>(offsetof(ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610, ___managedObjs_2)); }
	inline RuntimeObject* get_managedObjs_2() const { return ___managedObjs_2; }
	inline RuntimeObject** get_address_of_managedObjs_2() { return &___managedObjs_2; }
	inline void set_managedObjs_2(RuntimeObject* value)
	{
		___managedObjs_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___managedObjs_2), (void*)value);
	}

	inline static int32_t get_offset_of_clrInstance_3() { return static_cast<int32_t>(offsetof(ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610, ___clrInstance_3)); }
	inline RuntimeObject * get_clrInstance_3() const { return ___clrInstance_3; }
	inline RuntimeObject ** get_address_of_clrInstance_3() { return &___clrInstance_3; }
	inline void set_clrInstance_3(RuntimeObject * value)
	{
		___clrInstance_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___clrInstance_3), (void*)value);
	}

	inline static int32_t get_offset_of_valueTypeMask_4() { return static_cast<int32_t>(offsetof(ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610, ___valueTypeMask_4)); }
	inline uint64_t get_valueTypeMask_4() const { return ___valueTypeMask_4; }
	inline uint64_t* get_address_of_valueTypeMask_4() { return &___valueTypeMask_4; }
	inline void set_valueTypeMask_4(uint64_t value)
	{
		___valueTypeMask_4 = value;
	}

	inline static int32_t get_offset_of_delegates_5() { return static_cast<int32_t>(offsetof(ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610, ___delegates_5)); }
	inline Dictionary_2_tE1A83080A9D570401050D852D45604823051496B * get_delegates_5() const { return ___delegates_5; }
	inline Dictionary_2_tE1A83080A9D570401050D852D45604823051496B ** get_address_of_delegates_5() { return &___delegates_5; }
	inline void set_delegates_5(Dictionary_2_tE1A83080A9D570401050D852D45604823051496B * value)
	{
		___delegates_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delegates_5), (void*)value);
	}

	inline static int32_t get_offset_of_U3CBoxedU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610, ___U3CBoxedU3Ek__BackingField_6)); }
	inline bool get_U3CBoxedU3Ek__BackingField_6() const { return ___U3CBoxedU3Ek__BackingField_6; }
	inline bool* get_address_of_U3CBoxedU3Ek__BackingField_6() { return &___U3CBoxedU3Ek__BackingField_6; }
	inline void set_U3CBoxedU3Ek__BackingField_6(bool value)
	{
		___U3CBoxedU3Ek__BackingField_6 = value;
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

// ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider
struct PdbReaderProvider_tD6CADF6205DDD9BB74AE340FE5FF73794FD2361C  : public RuntimeObject
{
public:

public:
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

// System.Net.WebSockets.WebSocket
struct WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D  : public RuntimeObject
{
public:

public:
};


// System.Net.WebSockets.WebSocketContext
struct WebSocketContext_t680B9E369D33F9814583D3750D8401C575A15D46  : public RuntimeObject
{
public:

public:
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

// ValueTypeBindingDemo/<LoadHotFixAssembly>d__4
struct U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785  : public RuntimeObject
{
public:
	// System.Int32 ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::<>2__current
	RuntimeObject * ___U3CU3E2__current_1;
	// ValueTypeBindingDemo ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::<>4__this
	ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * ___U3CU3E4__this_2;
	// UnityEngine.WWW ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::<www>5__2
	WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * ___U3CwwwU3E5__2_3;
	// System.Byte[] ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::<dll>5__3
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___U3CdllU3E5__3_4;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3E2__current_1() { return static_cast<int32_t>(offsetof(U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785, ___U3CU3E2__current_1)); }
	inline RuntimeObject * get_U3CU3E2__current_1() const { return ___U3CU3E2__current_1; }
	inline RuntimeObject ** get_address_of_U3CU3E2__current_1() { return &___U3CU3E2__current_1; }
	inline void set_U3CU3E2__current_1(RuntimeObject * value)
	{
		___U3CU3E2__current_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E2__current_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_2() { return static_cast<int32_t>(offsetof(U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785, ___U3CU3E4__this_2)); }
	inline ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * get_U3CU3E4__this_2() const { return ___U3CU3E4__this_2; }
	inline ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA ** get_address_of_U3CU3E4__this_2() { return &___U3CU3E4__this_2; }
	inline void set_U3CU3E4__this_2(ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * value)
	{
		___U3CU3E4__this_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CwwwU3E5__2_3() { return static_cast<int32_t>(offsetof(U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785, ___U3CwwwU3E5__2_3)); }
	inline WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * get_U3CwwwU3E5__2_3() const { return ___U3CwwwU3E5__2_3; }
	inline WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 ** get_address_of_U3CwwwU3E5__2_3() { return &___U3CwwwU3E5__2_3; }
	inline void set_U3CwwwU3E5__2_3(WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * value)
	{
		___U3CwwwU3E5__2_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CwwwU3E5__2_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CdllU3E5__3_4() { return static_cast<int32_t>(offsetof(U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785, ___U3CdllU3E5__3_4)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_U3CdllU3E5__3_4() const { return ___U3CdllU3E5__3_4; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_U3CdllU3E5__3_4() { return &___U3CdllU3E5__3_4; }
	inline void set_U3CdllU3E5__3_4(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___U3CdllU3E5__3_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CdllU3E5__3_4), (void*)value);
	}
};


// ET.WChannel/<>c__DisplayClass11_0
struct U3CU3Ec__DisplayClass11_0_tBF6C144A4B80DF4937B39E39D7900DE33A416F40  : public RuntimeObject
{
public:
	// ET.WChannel ET.WChannel/<>c__DisplayClass11_0::<>4__this
	WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * ___U3CU3E4__this_0;
	// System.String ET.WChannel/<>c__DisplayClass11_0::connectUrl
	String_t* ___connectUrl_1;

public:
	inline static int32_t get_offset_of_U3CU3E4__this_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass11_0_tBF6C144A4B80DF4937B39E39D7900DE33A416F40, ___U3CU3E4__this_0)); }
	inline WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * get_U3CU3E4__this_0() const { return ___U3CU3E4__this_0; }
	inline WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 ** get_address_of_U3CU3E4__this_0() { return &___U3CU3E4__this_0; }
	inline void set_U3CU3E4__this_0(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * value)
	{
		___U3CU3E4__this_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_0), (void*)value);
	}

	inline static int32_t get_offset_of_connectUrl_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass11_0_tBF6C144A4B80DF4937B39E39D7900DE33A416F40, ___connectUrl_1)); }
	inline String_t* get_connectUrl_1() const { return ___connectUrl_1; }
	inline String_t** get_address_of_connectUrl_1() { return &___connectUrl_1; }
	inline void set_connectUrl_1(String_t* value)
	{
		___connectUrl_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___connectUrl_1), (void*)value);
	}
};


// instantiateEffectCaller/chainEffect
struct chainEffect_t86AB203988F70EBB301E81E78456C8BC8D99F8EE  : public RuntimeObject
{
public:
	// System.Boolean instantiateEffectCaller/chainEffect::isPlayed
	bool ___isPlayed_0;
	// System.Single instantiateEffectCaller/chainEffect::activateTimer
	float ___activateTimer_1;
	// UnityEngine.GameObject instantiateEffectCaller/chainEffect::Effect
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___Effect_2;
	// UnityEngine.Transform instantiateEffectCaller/chainEffect::effectLocator
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___effectLocator_3;

public:
	inline static int32_t get_offset_of_isPlayed_0() { return static_cast<int32_t>(offsetof(chainEffect_t86AB203988F70EBB301E81E78456C8BC8D99F8EE, ___isPlayed_0)); }
	inline bool get_isPlayed_0() const { return ___isPlayed_0; }
	inline bool* get_address_of_isPlayed_0() { return &___isPlayed_0; }
	inline void set_isPlayed_0(bool value)
	{
		___isPlayed_0 = value;
	}

	inline static int32_t get_offset_of_activateTimer_1() { return static_cast<int32_t>(offsetof(chainEffect_t86AB203988F70EBB301E81E78456C8BC8D99F8EE, ___activateTimer_1)); }
	inline float get_activateTimer_1() const { return ___activateTimer_1; }
	inline float* get_address_of_activateTimer_1() { return &___activateTimer_1; }
	inline void set_activateTimer_1(float value)
	{
		___activateTimer_1 = value;
	}

	inline static int32_t get_offset_of_Effect_2() { return static_cast<int32_t>(offsetof(chainEffect_t86AB203988F70EBB301E81E78456C8BC8D99F8EE, ___Effect_2)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_Effect_2() const { return ___Effect_2; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_Effect_2() { return &___Effect_2; }
	inline void set_Effect_2(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___Effect_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Effect_2), (void*)value);
	}

	inline static int32_t get_offset_of_effectLocator_3() { return static_cast<int32_t>(offsetof(chainEffect_t86AB203988F70EBB301E81E78456C8BC8D99F8EE, ___effectLocator_3)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_effectLocator_3() const { return ___effectLocator_3; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_effectLocator_3() { return &___effectLocator_3; }
	inline void set_effectLocator_3(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___effectLocator_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___effectLocator_3), (void*)value);
	}
};


// particleColorChanger/colorChange
struct colorChange_t90D67E9441CA1F572801FE59E3CBDA1416AFF4B5  : public RuntimeObject
{
public:
	// System.String particleColorChanger/colorChange::Name
	String_t* ___Name_0;
	// UnityEngine.ParticleSystem[] particleColorChanger/colorChange::colored_ParticleSystem
	ParticleSystemU5BU5D_t9786AE8909F75284FDCB6BAD155E24AAFDB88CC7* ___colored_ParticleSystem_1;
	// UnityEngine.Gradient particleColorChanger/colorChange::Gradient_custom
	Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * ___Gradient_custom_2;

public:
	inline static int32_t get_offset_of_Name_0() { return static_cast<int32_t>(offsetof(colorChange_t90D67E9441CA1F572801FE59E3CBDA1416AFF4B5, ___Name_0)); }
	inline String_t* get_Name_0() const { return ___Name_0; }
	inline String_t** get_address_of_Name_0() { return &___Name_0; }
	inline void set_Name_0(String_t* value)
	{
		___Name_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Name_0), (void*)value);
	}

	inline static int32_t get_offset_of_colored_ParticleSystem_1() { return static_cast<int32_t>(offsetof(colorChange_t90D67E9441CA1F572801FE59E3CBDA1416AFF4B5, ___colored_ParticleSystem_1)); }
	inline ParticleSystemU5BU5D_t9786AE8909F75284FDCB6BAD155E24AAFDB88CC7* get_colored_ParticleSystem_1() const { return ___colored_ParticleSystem_1; }
	inline ParticleSystemU5BU5D_t9786AE8909F75284FDCB6BAD155E24AAFDB88CC7** get_address_of_colored_ParticleSystem_1() { return &___colored_ParticleSystem_1; }
	inline void set_colored_ParticleSystem_1(ParticleSystemU5BU5D_t9786AE8909F75284FDCB6BAD155E24AAFDB88CC7* value)
	{
		___colored_ParticleSystem_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___colored_ParticleSystem_1), (void*)value);
	}

	inline static int32_t get_offset_of_Gradient_custom_2() { return static_cast<int32_t>(offsetof(colorChange_t90D67E9441CA1F572801FE59E3CBDA1416AFF4B5, ___Gradient_custom_2)); }
	inline Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * get_Gradient_custom_2() const { return ___Gradient_custom_2; }
	inline Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 ** get_address_of_Gradient_custom_2() { return &___Gradient_custom_2; }
	inline void set_Gradient_custom_2(Gradient_t297BAC6722F67728862AE2FBE760A400DA8902F2 * value)
	{
		___Gradient_custom_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Gradient_custom_2), (void*)value);
	}
};


// projectileActor/projectile
struct projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9  : public RuntimeObject
{
public:
	// System.String projectileActor/projectile::name
	String_t* ___name_0;
	// UnityEngine.Rigidbody projectileActor/projectile::bombPrefab
	Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A * ___bombPrefab_1;
	// UnityEngine.GameObject projectileActor/projectile::muzzleflare
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___muzzleflare_2;
	// System.Single projectileActor/projectile::min
	float ___min_3;
	// System.Single projectileActor/projectile::max
	float ___max_4;
	// System.Boolean projectileActor/projectile::rapidFire
	bool ___rapidFire_5;
	// System.Single projectileActor/projectile::rapidFireCooldown
	float ___rapidFireCooldown_6;
	// System.Boolean projectileActor/projectile::shotgunBehavior
	bool ___shotgunBehavior_7;
	// System.Int32 projectileActor/projectile::shotgunPellets
	int32_t ___shotgunPellets_8;
	// UnityEngine.GameObject projectileActor/projectile::shellPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___shellPrefab_9;
	// System.Boolean projectileActor/projectile::hasShells
	bool ___hasShells_10;

public:
	inline static int32_t get_offset_of_name_0() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___name_0)); }
	inline String_t* get_name_0() const { return ___name_0; }
	inline String_t** get_address_of_name_0() { return &___name_0; }
	inline void set_name_0(String_t* value)
	{
		___name_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___name_0), (void*)value);
	}

	inline static int32_t get_offset_of_bombPrefab_1() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___bombPrefab_1)); }
	inline Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A * get_bombPrefab_1() const { return ___bombPrefab_1; }
	inline Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A ** get_address_of_bombPrefab_1() { return &___bombPrefab_1; }
	inline void set_bombPrefab_1(Rigidbody_t101F2E2F9F16E765A77429B2DE4527D2047A887A * value)
	{
		___bombPrefab_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___bombPrefab_1), (void*)value);
	}

	inline static int32_t get_offset_of_muzzleflare_2() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___muzzleflare_2)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_muzzleflare_2() const { return ___muzzleflare_2; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_muzzleflare_2() { return &___muzzleflare_2; }
	inline void set_muzzleflare_2(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___muzzleflare_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___muzzleflare_2), (void*)value);
	}

	inline static int32_t get_offset_of_min_3() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___min_3)); }
	inline float get_min_3() const { return ___min_3; }
	inline float* get_address_of_min_3() { return &___min_3; }
	inline void set_min_3(float value)
	{
		___min_3 = value;
	}

	inline static int32_t get_offset_of_max_4() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___max_4)); }
	inline float get_max_4() const { return ___max_4; }
	inline float* get_address_of_max_4() { return &___max_4; }
	inline void set_max_4(float value)
	{
		___max_4 = value;
	}

	inline static int32_t get_offset_of_rapidFire_5() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___rapidFire_5)); }
	inline bool get_rapidFire_5() const { return ___rapidFire_5; }
	inline bool* get_address_of_rapidFire_5() { return &___rapidFire_5; }
	inline void set_rapidFire_5(bool value)
	{
		___rapidFire_5 = value;
	}

	inline static int32_t get_offset_of_rapidFireCooldown_6() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___rapidFireCooldown_6)); }
	inline float get_rapidFireCooldown_6() const { return ___rapidFireCooldown_6; }
	inline float* get_address_of_rapidFireCooldown_6() { return &___rapidFireCooldown_6; }
	inline void set_rapidFireCooldown_6(float value)
	{
		___rapidFireCooldown_6 = value;
	}

	inline static int32_t get_offset_of_shotgunBehavior_7() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___shotgunBehavior_7)); }
	inline bool get_shotgunBehavior_7() const { return ___shotgunBehavior_7; }
	inline bool* get_address_of_shotgunBehavior_7() { return &___shotgunBehavior_7; }
	inline void set_shotgunBehavior_7(bool value)
	{
		___shotgunBehavior_7 = value;
	}

	inline static int32_t get_offset_of_shotgunPellets_8() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___shotgunPellets_8)); }
	inline int32_t get_shotgunPellets_8() const { return ___shotgunPellets_8; }
	inline int32_t* get_address_of_shotgunPellets_8() { return &___shotgunPellets_8; }
	inline void set_shotgunPellets_8(int32_t value)
	{
		___shotgunPellets_8 = value;
	}

	inline static int32_t get_offset_of_shellPrefab_9() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___shellPrefab_9)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_shellPrefab_9() const { return ___shellPrefab_9; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_shellPrefab_9() { return &___shellPrefab_9; }
	inline void set_shellPrefab_9(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___shellPrefab_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___shellPrefab_9), (void*)value);
	}

	inline static int32_t get_offset_of_hasShells_10() { return static_cast<int32_t>(offsetof(projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9, ___hasShells_10)); }
	inline bool get_hasShells_10() const { return ___hasShells_10; }
	inline bool* get_address_of_hasShells_10() { return &___hasShells_10; }
	inline void set_hasShells_10(bool value)
	{
		___hasShells_10 = value;
	}
};


// System.ArraySegment`1<System.Byte>
struct ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE 
{
public:
	// T[] System.ArraySegment`1::_array
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____array_0;
	// System.Int32 System.ArraySegment`1::_offset
	int32_t ____offset_1;
	// System.Int32 System.ArraySegment`1::_count
	int32_t ____count_2;

public:
	inline static int32_t get_offset_of__array_0() { return static_cast<int32_t>(offsetof(ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE, ____array_0)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get__array_0() const { return ____array_0; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of__array_0() { return &____array_0; }
	inline void set__array_0(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		____array_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____array_0), (void*)value);
	}

	inline static int32_t get_offset_of__offset_1() { return static_cast<int32_t>(offsetof(ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE, ____offset_1)); }
	inline int32_t get__offset_1() const { return ____offset_1; }
	inline int32_t* get_address_of__offset_1() { return &____offset_1; }
	inline void set__offset_1(int32_t value)
	{
		____offset_1 = value;
	}

	inline static int32_t get_offset_of__count_2() { return static_cast<int32_t>(offsetof(ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE, ____count_2)); }
	inline int32_t get__count_2() const { return ____count_2; }
	inline int32_t* get_address_of__count_2() { return &____count_2; }
	inline void set__count_2(int32_t value)
	{
		____count_2 = value;
	}
};


// System.Nullable`1<System.Boolean>
struct Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3 
{
public:
	// T System.Nullable`1::value
	bool ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3, ___value_0)); }
	inline bool get_value_0() const { return ___value_0; }
	inline bool* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(bool value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.HttpListenerContext>
struct TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.TaskAwaiter`1::m_task
	Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33 * ___m_task_0;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381, ___m_task_0)); }
	inline Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33 * get_m_task_0() const { return ___m_task_0; }
	inline Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33 ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33 * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_task_0), (void*)value);
	}
};


// System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.HttpListenerWebSocketContext>
struct TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD 
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.TaskAwaiter`1::m_task
	Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC * ___m_task_0;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD, ___m_task_0)); }
	inline Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC * get_m_task_0() const { return ___m_task_0; }
	inline Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_task_0), (void*)value);
	}
};


// System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>
struct TaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE 
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.TaskAwaiter`1::m_task
	Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * ___m_task_0;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(TaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE, ___m_task_0)); }
	inline Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * get_m_task_0() const { return ___m_task_0; }
	inline Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_task_0), (void*)value);
	}
};


// System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.WebSocketReceiveResult>
struct TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.TaskAwaiter`1::m_task
	Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E * ___m_task_0;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6, ___m_task_0)); }
	inline Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E * get_m_task_0() const { return ___m_task_0; }
	inline Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_task_0), (void*)value);
	}
};


// System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34 
{
public:
	// System.Runtime.CompilerServices.IAsyncStateMachine System.Runtime.CompilerServices.AsyncMethodBuilderCore::m_stateMachine
	RuntimeObject* ___m_stateMachine_0;
	// System.Action System.Runtime.CompilerServices.AsyncMethodBuilderCore::m_defaultContextAction
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___m_defaultContextAction_1;

public:
	inline static int32_t get_offset_of_m_stateMachine_0() { return static_cast<int32_t>(offsetof(AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34, ___m_stateMachine_0)); }
	inline RuntimeObject* get_m_stateMachine_0() const { return ___m_stateMachine_0; }
	inline RuntimeObject** get_address_of_m_stateMachine_0() { return &___m_stateMachine_0; }
	inline void set_m_stateMachine_0(RuntimeObject* value)
	{
		___m_stateMachine_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_stateMachine_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_defaultContextAction_1() { return static_cast<int32_t>(offsetof(AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34, ___m_defaultContextAction_1)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_m_defaultContextAction_1() const { return ___m_defaultContextAction_1; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_m_defaultContextAction_1() { return &___m_defaultContextAction_1; }
	inline void set_m_defaultContextAction_1(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___m_defaultContextAction_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_defaultContextAction_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34_marshaled_pinvoke
{
	RuntimeObject* ___m_stateMachine_0;
	Il2CppMethodPointer ___m_defaultContextAction_1;
};
// Native definition for COM marshalling of System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34_marshaled_com
{
	RuntimeObject* ___m_stateMachine_0;
	Il2CppMethodPointer ___m_defaultContextAction_1;
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


// System.Threading.CancellationToken
struct CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD 
{
public:
	// System.Threading.CancellationTokenSource System.Threading.CancellationToken::m_source
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ___m_source_0;

public:
	inline static int32_t get_offset_of_m_source_0() { return static_cast<int32_t>(offsetof(CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD, ___m_source_0)); }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * get_m_source_0() const { return ___m_source_0; }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 ** get_address_of_m_source_0() { return &___m_source_0; }
	inline void set_m_source_0(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * value)
	{
		___m_source_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_source_0), (void*)value);
	}
};

struct CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD_StaticFields
{
public:
	// System.Action`1<System.Object> System.Threading.CancellationToken::s_ActionToActionObjShunt
	Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * ___s_ActionToActionObjShunt_1;

public:
	inline static int32_t get_offset_of_s_ActionToActionObjShunt_1() { return static_cast<int32_t>(offsetof(CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD_StaticFields, ___s_ActionToActionObjShunt_1)); }
	inline Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * get_s_ActionToActionObjShunt_1() const { return ___s_ActionToActionObjShunt_1; }
	inline Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC ** get_address_of_s_ActionToActionObjShunt_1() { return &___s_ActionToActionObjShunt_1; }
	inline void set_s_ActionToActionObjShunt_1(Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * value)
	{
		___s_ActionToActionObjShunt_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_ActionToActionObjShunt_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Threading.CancellationToken
struct CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD_marshaled_pinvoke
{
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ___m_source_0;
};
// Native definition for COM marshalling of System.Threading.CancellationToken
struct CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD_marshaled_com
{
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ___m_source_0;
};

// System.Net.WebSockets.ClientWebSocket
struct ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09  : public WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D
{
public:
	// System.Net.WebSockets.ClientWebSocketOptions System.Net.WebSockets.ClientWebSocket::_options
	ClientWebSocketOptions_t542669394208DA09FBC06141585E0CA380ACEC85 * ____options_0;
	// System.Net.WebSockets.WebSocketHandle System.Net.WebSockets.ClientWebSocket::_innerWebSocket
	WebSocketHandle_t39F2F748886F0AEA42BB56CB4836BA17834AD3A4 * ____innerWebSocket_1;
	// System.Int32 System.Net.WebSockets.ClientWebSocket::_state
	int32_t ____state_2;

public:
	inline static int32_t get_offset_of__options_0() { return static_cast<int32_t>(offsetof(ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09, ____options_0)); }
	inline ClientWebSocketOptions_t542669394208DA09FBC06141585E0CA380ACEC85 * get__options_0() const { return ____options_0; }
	inline ClientWebSocketOptions_t542669394208DA09FBC06141585E0CA380ACEC85 ** get_address_of__options_0() { return &____options_0; }
	inline void set__options_0(ClientWebSocketOptions_t542669394208DA09FBC06141585E0CA380ACEC85 * value)
	{
		____options_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____options_0), (void*)value);
	}

	inline static int32_t get_offset_of__innerWebSocket_1() { return static_cast<int32_t>(offsetof(ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09, ____innerWebSocket_1)); }
	inline WebSocketHandle_t39F2F748886F0AEA42BB56CB4836BA17834AD3A4 * get__innerWebSocket_1() const { return ____innerWebSocket_1; }
	inline WebSocketHandle_t39F2F748886F0AEA42BB56CB4836BA17834AD3A4 ** get_address_of__innerWebSocket_1() { return &____innerWebSocket_1; }
	inline void set__innerWebSocket_1(WebSocketHandle_t39F2F748886F0AEA42BB56CB4836BA17834AD3A4 * value)
	{
		____innerWebSocket_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____innerWebSocket_1), (void*)value);
	}

	inline static int32_t get_offset_of__state_2() { return static_cast<int32_t>(offsetof(ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09, ____state_2)); }
	inline int32_t get__state_2() const { return ____state_2; }
	inline int32_t* get_address_of__state_2() { return &____state_2; }
	inline void set__state_2(int32_t value)
	{
		____state_2 = value;
	}
};


// ET.ETAsyncTaskMethodBuilder
struct ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F 
{
public:
	// ET.ETTask ET.ETAsyncTaskMethodBuilder::tcs
	ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * ___tcs_0;

public:
	inline static int32_t get_offset_of_tcs_0() { return static_cast<int32_t>(offsetof(ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F, ___tcs_0)); }
	inline ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * get_tcs_0() const { return ___tcs_0; }
	inline ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF ** get_address_of_tcs_0() { return &___tcs_0; }
	inline void set_tcs_0(ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * value)
	{
		___tcs_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tcs_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of ET.ETAsyncTaskMethodBuilder
struct ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F_marshaled_pinvoke
{
	ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * ___tcs_0;
};
// Native definition for COM marshalling of ET.ETAsyncTaskMethodBuilder
struct ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F_marshaled_com
{
	ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * ___tcs_0;
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

// System.Net.WebSockets.HttpListenerWebSocketContext
struct HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33  : public WebSocketContext_t680B9E369D33F9814583D3750D8401C575A15D46
{
public:
	// System.Uri System.Net.WebSockets.HttpListenerWebSocketContext::_requestUri
	Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * ____requestUri_0;
	// System.Collections.Specialized.NameValueCollection System.Net.WebSockets.HttpListenerWebSocketContext::_headers
	NameValueCollection_tE3BED11C58844E8A4D9A74F359692B9A51781B4D * ____headers_1;
	// System.Net.CookieCollection System.Net.WebSockets.HttpListenerWebSocketContext::_cookieCollection
	CookieCollection_t2D2FA42D43C1A8053D95FD2205360B2E0B94AF06 * ____cookieCollection_2;
	// System.Security.Principal.IPrincipal System.Net.WebSockets.HttpListenerWebSocketContext::_user
	RuntimeObject* ____user_3;
	// System.Boolean System.Net.WebSockets.HttpListenerWebSocketContext::_isAuthenticated
	bool ____isAuthenticated_4;
	// System.Boolean System.Net.WebSockets.HttpListenerWebSocketContext::_isLocal
	bool ____isLocal_5;
	// System.Boolean System.Net.WebSockets.HttpListenerWebSocketContext::_isSecureConnection
	bool ____isSecureConnection_6;
	// System.String System.Net.WebSockets.HttpListenerWebSocketContext::_origin
	String_t* ____origin_7;
	// System.Collections.Generic.IEnumerable`1<System.String> System.Net.WebSockets.HttpListenerWebSocketContext::_secWebSocketProtocols
	RuntimeObject* ____secWebSocketProtocols_8;
	// System.String System.Net.WebSockets.HttpListenerWebSocketContext::_secWebSocketVersion
	String_t* ____secWebSocketVersion_9;
	// System.String System.Net.WebSockets.HttpListenerWebSocketContext::_secWebSocketKey
	String_t* ____secWebSocketKey_10;
	// System.Net.WebSockets.WebSocket System.Net.WebSockets.HttpListenerWebSocketContext::_webSocket
	WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * ____webSocket_11;

public:
	inline static int32_t get_offset_of__requestUri_0() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____requestUri_0)); }
	inline Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * get__requestUri_0() const { return ____requestUri_0; }
	inline Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 ** get_address_of__requestUri_0() { return &____requestUri_0; }
	inline void set__requestUri_0(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * value)
	{
		____requestUri_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____requestUri_0), (void*)value);
	}

	inline static int32_t get_offset_of__headers_1() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____headers_1)); }
	inline NameValueCollection_tE3BED11C58844E8A4D9A74F359692B9A51781B4D * get__headers_1() const { return ____headers_1; }
	inline NameValueCollection_tE3BED11C58844E8A4D9A74F359692B9A51781B4D ** get_address_of__headers_1() { return &____headers_1; }
	inline void set__headers_1(NameValueCollection_tE3BED11C58844E8A4D9A74F359692B9A51781B4D * value)
	{
		____headers_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____headers_1), (void*)value);
	}

	inline static int32_t get_offset_of__cookieCollection_2() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____cookieCollection_2)); }
	inline CookieCollection_t2D2FA42D43C1A8053D95FD2205360B2E0B94AF06 * get__cookieCollection_2() const { return ____cookieCollection_2; }
	inline CookieCollection_t2D2FA42D43C1A8053D95FD2205360B2E0B94AF06 ** get_address_of__cookieCollection_2() { return &____cookieCollection_2; }
	inline void set__cookieCollection_2(CookieCollection_t2D2FA42D43C1A8053D95FD2205360B2E0B94AF06 * value)
	{
		____cookieCollection_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____cookieCollection_2), (void*)value);
	}

	inline static int32_t get_offset_of__user_3() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____user_3)); }
	inline RuntimeObject* get__user_3() const { return ____user_3; }
	inline RuntimeObject** get_address_of__user_3() { return &____user_3; }
	inline void set__user_3(RuntimeObject* value)
	{
		____user_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____user_3), (void*)value);
	}

	inline static int32_t get_offset_of__isAuthenticated_4() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____isAuthenticated_4)); }
	inline bool get__isAuthenticated_4() const { return ____isAuthenticated_4; }
	inline bool* get_address_of__isAuthenticated_4() { return &____isAuthenticated_4; }
	inline void set__isAuthenticated_4(bool value)
	{
		____isAuthenticated_4 = value;
	}

	inline static int32_t get_offset_of__isLocal_5() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____isLocal_5)); }
	inline bool get__isLocal_5() const { return ____isLocal_5; }
	inline bool* get_address_of__isLocal_5() { return &____isLocal_5; }
	inline void set__isLocal_5(bool value)
	{
		____isLocal_5 = value;
	}

	inline static int32_t get_offset_of__isSecureConnection_6() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____isSecureConnection_6)); }
	inline bool get__isSecureConnection_6() const { return ____isSecureConnection_6; }
	inline bool* get_address_of__isSecureConnection_6() { return &____isSecureConnection_6; }
	inline void set__isSecureConnection_6(bool value)
	{
		____isSecureConnection_6 = value;
	}

	inline static int32_t get_offset_of__origin_7() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____origin_7)); }
	inline String_t* get__origin_7() const { return ____origin_7; }
	inline String_t** get_address_of__origin_7() { return &____origin_7; }
	inline void set__origin_7(String_t* value)
	{
		____origin_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____origin_7), (void*)value);
	}

	inline static int32_t get_offset_of__secWebSocketProtocols_8() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____secWebSocketProtocols_8)); }
	inline RuntimeObject* get__secWebSocketProtocols_8() const { return ____secWebSocketProtocols_8; }
	inline RuntimeObject** get_address_of__secWebSocketProtocols_8() { return &____secWebSocketProtocols_8; }
	inline void set__secWebSocketProtocols_8(RuntimeObject* value)
	{
		____secWebSocketProtocols_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____secWebSocketProtocols_8), (void*)value);
	}

	inline static int32_t get_offset_of__secWebSocketVersion_9() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____secWebSocketVersion_9)); }
	inline String_t* get__secWebSocketVersion_9() const { return ____secWebSocketVersion_9; }
	inline String_t** get_address_of__secWebSocketVersion_9() { return &____secWebSocketVersion_9; }
	inline void set__secWebSocketVersion_9(String_t* value)
	{
		____secWebSocketVersion_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____secWebSocketVersion_9), (void*)value);
	}

	inline static int32_t get_offset_of__secWebSocketKey_10() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____secWebSocketKey_10)); }
	inline String_t* get__secWebSocketKey_10() const { return ____secWebSocketKey_10; }
	inline String_t** get_address_of__secWebSocketKey_10() { return &____secWebSocketKey_10; }
	inline void set__secWebSocketKey_10(String_t* value)
	{
		____secWebSocketKey_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____secWebSocketKey_10), (void*)value);
	}

	inline static int32_t get_offset_of__webSocket_11() { return static_cast<int32_t>(offsetof(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33, ____webSocket_11)); }
	inline WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * get__webSocket_11() const { return ____webSocket_11; }
	inline WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D ** get_address_of__webSocket_11() { return &____webSocket_11; }
	inline void set__webSocket_11(WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * value)
	{
		____webSocket_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____webSocket_11), (void*)value);
	}
};


// System.Net.IPEndPoint
struct IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E  : public EndPoint_t18D4AE8D03090A2B262136E59F95CE61418C34DA
{
public:
	// System.Net.IPAddress System.Net.IPEndPoint::m_Address
	IPAddress_t2B5F1762B4B9935BA6CA8FB12C87282C72E035AE * ___m_Address_2;
	// System.Int32 System.Net.IPEndPoint::m_Port
	int32_t ___m_Port_3;

public:
	inline static int32_t get_offset_of_m_Address_2() { return static_cast<int32_t>(offsetof(IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E, ___m_Address_2)); }
	inline IPAddress_t2B5F1762B4B9935BA6CA8FB12C87282C72E035AE * get_m_Address_2() const { return ___m_Address_2; }
	inline IPAddress_t2B5F1762B4B9935BA6CA8FB12C87282C72E035AE ** get_address_of_m_Address_2() { return &___m_Address_2; }
	inline void set_m_Address_2(IPAddress_t2B5F1762B4B9935BA6CA8FB12C87282C72E035AE * value)
	{
		___m_Address_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Address_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_Port_3() { return static_cast<int32_t>(offsetof(IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E, ___m_Port_3)); }
	inline int32_t get_m_Port_3() const { return ___m_Port_3; }
	inline int32_t* get_address_of_m_Port_3() { return &___m_Port_3; }
	inline void set_m_Port_3(int32_t value)
	{
		___m_Port_3 = value;
	}
};

struct IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E_StaticFields
{
public:
	// System.Net.IPEndPoint System.Net.IPEndPoint::Any
	IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * ___Any_5;
	// System.Net.IPEndPoint System.Net.IPEndPoint::IPv6Any
	IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * ___IPv6Any_6;

public:
	inline static int32_t get_offset_of_Any_5() { return static_cast<int32_t>(offsetof(IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E_StaticFields, ___Any_5)); }
	inline IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * get_Any_5() const { return ___Any_5; }
	inline IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E ** get_address_of_Any_5() { return &___Any_5; }
	inline void set_Any_5(IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * value)
	{
		___Any_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Any_5), (void*)value);
	}

	inline static int32_t get_offset_of_IPv6Any_6() { return static_cast<int32_t>(offsetof(IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E_StaticFields, ___IPv6Any_6)); }
	inline IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * get_IPv6Any_6() const { return ___IPv6Any_6; }
	inline IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E ** get_address_of_IPv6Any_6() { return &___IPv6Any_6; }
	inline void set_IPv6Any_6(IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * value)
	{
		___IPv6Any_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___IPv6Any_6), (void*)value);
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


// System.IO.Stream
struct Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB  : public MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8
{
public:
	// System.IO.Stream/ReadWriteTask System.IO.Stream::_activeReadWriteTask
	ReadWriteTask_t32CD2C230786712954C1DB518DBE420A1F4C7974 * ____activeReadWriteTask_3;
	// System.Threading.SemaphoreSlim System.IO.Stream::_asyncActiveSemaphore
	SemaphoreSlim_t3EF85FC980AE57957BEBB6B78E81DE2E3233D385 * ____asyncActiveSemaphore_4;

public:
	inline static int32_t get_offset_of__activeReadWriteTask_3() { return static_cast<int32_t>(offsetof(Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB, ____activeReadWriteTask_3)); }
	inline ReadWriteTask_t32CD2C230786712954C1DB518DBE420A1F4C7974 * get__activeReadWriteTask_3() const { return ____activeReadWriteTask_3; }
	inline ReadWriteTask_t32CD2C230786712954C1DB518DBE420A1F4C7974 ** get_address_of__activeReadWriteTask_3() { return &____activeReadWriteTask_3; }
	inline void set__activeReadWriteTask_3(ReadWriteTask_t32CD2C230786712954C1DB518DBE420A1F4C7974 * value)
	{
		____activeReadWriteTask_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____activeReadWriteTask_3), (void*)value);
	}

	inline static int32_t get_offset_of__asyncActiveSemaphore_4() { return static_cast<int32_t>(offsetof(Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB, ____asyncActiveSemaphore_4)); }
	inline SemaphoreSlim_t3EF85FC980AE57957BEBB6B78E81DE2E3233D385 * get__asyncActiveSemaphore_4() const { return ____asyncActiveSemaphore_4; }
	inline SemaphoreSlim_t3EF85FC980AE57957BEBB6B78E81DE2E3233D385 ** get_address_of__asyncActiveSemaphore_4() { return &____asyncActiveSemaphore_4; }
	inline void set__asyncActiveSemaphore_4(SemaphoreSlim_t3EF85FC980AE57957BEBB6B78E81DE2E3233D385 * value)
	{
		____asyncActiveSemaphore_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____asyncActiveSemaphore_4), (void*)value);
	}
};

struct Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB_StaticFields
{
public:
	// System.IO.Stream System.IO.Stream::Null
	Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___Null_1;

public:
	inline static int32_t get_offset_of_Null_1() { return static_cast<int32_t>(offsetof(Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB_StaticFields, ___Null_1)); }
	inline Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * get_Null_1() const { return ___Null_1; }
	inline Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB ** get_address_of_Null_1() { return &___Null_1; }
	inline void set_Null_1(Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * value)
	{
		___Null_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Null_1), (void*)value);
	}
};


// System.Runtime.CompilerServices.TaskAwaiter
struct TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C 
{
public:
	// System.Threading.Tasks.Task System.Runtime.CompilerServices.TaskAwaiter::m_task
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___m_task_0;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C, ___m_task_0)); }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * get_m_task_0() const { return ___m_task_0; }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_task_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Runtime.CompilerServices.TaskAwaiter
struct TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_marshaled_pinvoke
{
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___m_task_0;
};
// Native definition for COM marshalling of System.Runtime.CompilerServices.TaskAwaiter
struct TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_marshaled_com
{
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___m_task_0;
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


// UnityEngine.WWW
struct WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2  : public CustomYieldInstruction_t4ED1543FBAA3143362854EB1867B42E5D190A5C7
{
public:
	// UnityEngine.Networking.UnityWebRequest UnityEngine.WWW::_uwr
	UnityWebRequest_tB75B39F6951CA0DBA2D5BEDF85FDCAAC6026A37E * ____uwr_0;

public:
	inline static int32_t get_offset_of__uwr_0() { return static_cast<int32_t>(offsetof(WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2, ____uwr_0)); }
	inline UnityWebRequest_tB75B39F6951CA0DBA2D5BEDF85FDCAAC6026A37E * get__uwr_0() const { return ____uwr_0; }
	inline UnityWebRequest_tB75B39F6951CA0DBA2D5BEDF85FDCAAC6026A37E ** get_address_of__uwr_0() { return &____uwr_0; }
	inline void set__uwr_0(UnityWebRequest_tB75B39F6951CA0DBA2D5BEDF85FDCAAC6026A37E * value)
	{
		____uwr_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____uwr_0), (void*)value);
	}
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

// System.Runtime.CompilerServices.AsyncVoidMethodBuilder
struct AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 
{
public:
	// System.Threading.SynchronizationContext System.Runtime.CompilerServices.AsyncVoidMethodBuilder::m_synchronizationContext
	SynchronizationContext_t17D9365B5E0D30A0910A16FA4351C525232EF069 * ___m_synchronizationContext_0;
	// System.Runtime.CompilerServices.AsyncMethodBuilderCore System.Runtime.CompilerServices.AsyncVoidMethodBuilder::m_coreState
	AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34  ___m_coreState_1;
	// System.Threading.Tasks.Task System.Runtime.CompilerServices.AsyncVoidMethodBuilder::m_task
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___m_task_2;

public:
	inline static int32_t get_offset_of_m_synchronizationContext_0() { return static_cast<int32_t>(offsetof(AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6, ___m_synchronizationContext_0)); }
	inline SynchronizationContext_t17D9365B5E0D30A0910A16FA4351C525232EF069 * get_m_synchronizationContext_0() const { return ___m_synchronizationContext_0; }
	inline SynchronizationContext_t17D9365B5E0D30A0910A16FA4351C525232EF069 ** get_address_of_m_synchronizationContext_0() { return &___m_synchronizationContext_0; }
	inline void set_m_synchronizationContext_0(SynchronizationContext_t17D9365B5E0D30A0910A16FA4351C525232EF069 * value)
	{
		___m_synchronizationContext_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_synchronizationContext_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_coreState_1() { return static_cast<int32_t>(offsetof(AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6, ___m_coreState_1)); }
	inline AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34  get_m_coreState_1() const { return ___m_coreState_1; }
	inline AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34 * get_address_of_m_coreState_1() { return &___m_coreState_1; }
	inline void set_m_coreState_1(AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34  value)
	{
		___m_coreState_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_coreState_1))->___m_stateMachine_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___m_coreState_1))->___m_defaultContextAction_1), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_m_task_2() { return static_cast<int32_t>(offsetof(AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6, ___m_task_2)); }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * get_m_task_2() const { return ___m_task_2; }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 ** get_address_of_m_task_2() { return &___m_task_2; }
	inline void set_m_task_2(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * value)
	{
		___m_task_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_task_2), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Runtime.CompilerServices.AsyncVoidMethodBuilder
struct AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6_marshaled_pinvoke
{
	SynchronizationContext_t17D9365B5E0D30A0910A16FA4351C525232EF069 * ___m_synchronizationContext_0;
	AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34_marshaled_pinvoke ___m_coreState_1;
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___m_task_2;
};
// Native definition for COM marshalling of System.Runtime.CompilerServices.AsyncVoidMethodBuilder
struct AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6_marshaled_com
{
	SynchronizationContext_t17D9365B5E0D30A0910A16FA4351C525232EF069 * ___m_synchronizationContext_0;
	AsyncMethodBuilderCore_t2C85055E04767C52B9F66144476FCBF500DBFA34_marshaled_com ___m_coreState_1;
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___m_task_2;
};

// System.Net.AuthenticationSchemes
struct AuthenticationSchemes_tF8F52F1898BAB6939F252F4AF6B4F123FBC4EF47 
{
public:
	// System.Int32 System.Net.AuthenticationSchemes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AuthenticationSchemes_tF8F52F1898BAB6939F252F4AF6B4F123FBC4EF47, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// ET.AwaiterStatus
struct AwaiterStatus_t7D3338F8A73065C16378C11C75AD725451810A2C 
{
public:
	// System.Byte ET.AwaiterStatus::value__
	uint8_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AwaiterStatus_t7D3338F8A73065C16378C11C75AD725451810A2C, ___value___2)); }
	inline uint8_t get_value___2() const { return ___value___2; }
	inline uint8_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint8_t value)
	{
		___value___2 = value;
	}
};


// System.Threading.CancellationTokenSource
struct CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3  : public RuntimeObject
{
public:
	// System.Threading.ManualResetEvent modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.CancellationTokenSource::m_kernelEvent
	ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * ___m_kernelEvent_3;
	// System.Threading.SparselyPopulatedArray`1<System.Threading.CancellationCallbackInfo>[] modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.CancellationTokenSource::m_registeredCallbacksLists
	SparselyPopulatedArray_1U5BU5D_t4D2064CEC206620DC5001D7C857A845833DCB52A* ___m_registeredCallbacksLists_4;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.CancellationTokenSource::m_state
	int32_t ___m_state_9;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.CancellationTokenSource::m_threadIDExecutingCallbacks
	int32_t ___m_threadIDExecutingCallbacks_10;
	// System.Boolean System.Threading.CancellationTokenSource::m_disposed
	bool ___m_disposed_11;
	// System.Threading.CancellationTokenRegistration[] System.Threading.CancellationTokenSource::m_linkingRegistrations
	CancellationTokenRegistrationU5BU5D_t864BA2E1E6485FDC593F17F7C01525F33CCE7910* ___m_linkingRegistrations_12;
	// System.Threading.CancellationCallbackInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.CancellationTokenSource::m_executingCallback
	CancellationCallbackInfo_t7FC8CF6DB4845FCB0138771E86AE058710B1117B * ___m_executingCallback_14;
	// System.Threading.Timer modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.CancellationTokenSource::m_timer
	Timer_t31BE4EDDA5C1CB5CFDF698231850B47B7F9DE9CB * ___m_timer_15;

public:
	inline static int32_t get_offset_of_m_kernelEvent_3() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3, ___m_kernelEvent_3)); }
	inline ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * get_m_kernelEvent_3() const { return ___m_kernelEvent_3; }
	inline ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA ** get_address_of_m_kernelEvent_3() { return &___m_kernelEvent_3; }
	inline void set_m_kernelEvent_3(ManualResetEvent_t9E2ED486907E3A16122ED4E946534E4DD6B5A7BA * value)
	{
		___m_kernelEvent_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_kernelEvent_3), (void*)value);
	}

	inline static int32_t get_offset_of_m_registeredCallbacksLists_4() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3, ___m_registeredCallbacksLists_4)); }
	inline SparselyPopulatedArray_1U5BU5D_t4D2064CEC206620DC5001D7C857A845833DCB52A* get_m_registeredCallbacksLists_4() const { return ___m_registeredCallbacksLists_4; }
	inline SparselyPopulatedArray_1U5BU5D_t4D2064CEC206620DC5001D7C857A845833DCB52A** get_address_of_m_registeredCallbacksLists_4() { return &___m_registeredCallbacksLists_4; }
	inline void set_m_registeredCallbacksLists_4(SparselyPopulatedArray_1U5BU5D_t4D2064CEC206620DC5001D7C857A845833DCB52A* value)
	{
		___m_registeredCallbacksLists_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_registeredCallbacksLists_4), (void*)value);
	}

	inline static int32_t get_offset_of_m_state_9() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3, ___m_state_9)); }
	inline int32_t get_m_state_9() const { return ___m_state_9; }
	inline int32_t* get_address_of_m_state_9() { return &___m_state_9; }
	inline void set_m_state_9(int32_t value)
	{
		___m_state_9 = value;
	}

	inline static int32_t get_offset_of_m_threadIDExecutingCallbacks_10() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3, ___m_threadIDExecutingCallbacks_10)); }
	inline int32_t get_m_threadIDExecutingCallbacks_10() const { return ___m_threadIDExecutingCallbacks_10; }
	inline int32_t* get_address_of_m_threadIDExecutingCallbacks_10() { return &___m_threadIDExecutingCallbacks_10; }
	inline void set_m_threadIDExecutingCallbacks_10(int32_t value)
	{
		___m_threadIDExecutingCallbacks_10 = value;
	}

	inline static int32_t get_offset_of_m_disposed_11() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3, ___m_disposed_11)); }
	inline bool get_m_disposed_11() const { return ___m_disposed_11; }
	inline bool* get_address_of_m_disposed_11() { return &___m_disposed_11; }
	inline void set_m_disposed_11(bool value)
	{
		___m_disposed_11 = value;
	}

	inline static int32_t get_offset_of_m_linkingRegistrations_12() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3, ___m_linkingRegistrations_12)); }
	inline CancellationTokenRegistrationU5BU5D_t864BA2E1E6485FDC593F17F7C01525F33CCE7910* get_m_linkingRegistrations_12() const { return ___m_linkingRegistrations_12; }
	inline CancellationTokenRegistrationU5BU5D_t864BA2E1E6485FDC593F17F7C01525F33CCE7910** get_address_of_m_linkingRegistrations_12() { return &___m_linkingRegistrations_12; }
	inline void set_m_linkingRegistrations_12(CancellationTokenRegistrationU5BU5D_t864BA2E1E6485FDC593F17F7C01525F33CCE7910* value)
	{
		___m_linkingRegistrations_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_linkingRegistrations_12), (void*)value);
	}

	inline static int32_t get_offset_of_m_executingCallback_14() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3, ___m_executingCallback_14)); }
	inline CancellationCallbackInfo_t7FC8CF6DB4845FCB0138771E86AE058710B1117B * get_m_executingCallback_14() const { return ___m_executingCallback_14; }
	inline CancellationCallbackInfo_t7FC8CF6DB4845FCB0138771E86AE058710B1117B ** get_address_of_m_executingCallback_14() { return &___m_executingCallback_14; }
	inline void set_m_executingCallback_14(CancellationCallbackInfo_t7FC8CF6DB4845FCB0138771E86AE058710B1117B * value)
	{
		___m_executingCallback_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_executingCallback_14), (void*)value);
	}

	inline static int32_t get_offset_of_m_timer_15() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3, ___m_timer_15)); }
	inline Timer_t31BE4EDDA5C1CB5CFDF698231850B47B7F9DE9CB * get_m_timer_15() const { return ___m_timer_15; }
	inline Timer_t31BE4EDDA5C1CB5CFDF698231850B47B7F9DE9CB ** get_address_of_m_timer_15() { return &___m_timer_15; }
	inline void set_m_timer_15(Timer_t31BE4EDDA5C1CB5CFDF698231850B47B7F9DE9CB * value)
	{
		___m_timer_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_timer_15), (void*)value);
	}
};

struct CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3_StaticFields
{
public:
	// System.Threading.CancellationTokenSource System.Threading.CancellationTokenSource::_staticSource_Set
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ____staticSource_Set_0;
	// System.Threading.CancellationTokenSource System.Threading.CancellationTokenSource::_staticSource_NotCancelable
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ____staticSource_NotCancelable_1;
	// System.Int32 System.Threading.CancellationTokenSource::s_nLists
	int32_t ___s_nLists_2;
	// System.Action`1<System.Object> System.Threading.CancellationTokenSource::s_LinkedTokenCancelDelegate
	Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * ___s_LinkedTokenCancelDelegate_13;
	// System.Threading.TimerCallback System.Threading.CancellationTokenSource::s_timerCallback
	TimerCallback_tD193CC50BF27E129E6857E1E8A7EAC24BD131814 * ___s_timerCallback_16;

public:
	inline static int32_t get_offset_of__staticSource_Set_0() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3_StaticFields, ____staticSource_Set_0)); }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * get__staticSource_Set_0() const { return ____staticSource_Set_0; }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 ** get_address_of__staticSource_Set_0() { return &____staticSource_Set_0; }
	inline void set__staticSource_Set_0(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * value)
	{
		____staticSource_Set_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____staticSource_Set_0), (void*)value);
	}

	inline static int32_t get_offset_of__staticSource_NotCancelable_1() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3_StaticFields, ____staticSource_NotCancelable_1)); }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * get__staticSource_NotCancelable_1() const { return ____staticSource_NotCancelable_1; }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 ** get_address_of__staticSource_NotCancelable_1() { return &____staticSource_NotCancelable_1; }
	inline void set__staticSource_NotCancelable_1(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * value)
	{
		____staticSource_NotCancelable_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____staticSource_NotCancelable_1), (void*)value);
	}

	inline static int32_t get_offset_of_s_nLists_2() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3_StaticFields, ___s_nLists_2)); }
	inline int32_t get_s_nLists_2() const { return ___s_nLists_2; }
	inline int32_t* get_address_of_s_nLists_2() { return &___s_nLists_2; }
	inline void set_s_nLists_2(int32_t value)
	{
		___s_nLists_2 = value;
	}

	inline static int32_t get_offset_of_s_LinkedTokenCancelDelegate_13() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3_StaticFields, ___s_LinkedTokenCancelDelegate_13)); }
	inline Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * get_s_LinkedTokenCancelDelegate_13() const { return ___s_LinkedTokenCancelDelegate_13; }
	inline Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC ** get_address_of_s_LinkedTokenCancelDelegate_13() { return &___s_LinkedTokenCancelDelegate_13; }
	inline void set_s_LinkedTokenCancelDelegate_13(Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * value)
	{
		___s_LinkedTokenCancelDelegate_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_LinkedTokenCancelDelegate_13), (void*)value);
	}

	inline static int32_t get_offset_of_s_timerCallback_16() { return static_cast<int32_t>(offsetof(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3_StaticFields, ___s_timerCallback_16)); }
	inline TimerCallback_tD193CC50BF27E129E6857E1E8A7EAC24BD131814 * get_s_timerCallback_16() const { return ___s_timerCallback_16; }
	inline TimerCallback_tD193CC50BF27E129E6857E1E8A7EAC24BD131814 ** get_address_of_s_timerCallback_16() { return &___s_timerCallback_16; }
	inline void set_s_timerCallback_16(TimerCallback_tD193CC50BF27E129E6857E1E8A7EAC24BD131814 * value)
	{
		___s_timerCallback_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_timerCallback_16), (void*)value);
	}
};


// ET.ChannelType
struct ChannelType_tAC40E4F8EB4B3F7C66682B2FF35F399D2D396797 
{
public:
	// System.Int32 ET.ChannelType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ChannelType_tAC40E4F8EB4B3F7C66682B2FF35F399D2D396797, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
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

// ILRuntime.CLR.TypeSystem.ILType
struct ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7  : public RuntimeObject
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<ILRuntime.CLR.Method.ILMethod>> ILRuntime.CLR.TypeSystem.ILType::methods
	Dictionary_2_t0CA2C2C7261253E1492136E657CF00E1677F4BA0 * ___methods_0;
	// ILRuntime.Mono.Cecil.TypeReference ILRuntime.CLR.TypeSystem.ILType::typeRef
	TypeReference_t72C4131E60A79E1B419C38BF5DD0C213033BB425 * ___typeRef_1;
	// ILRuntime.Mono.Cecil.TypeDefinition ILRuntime.CLR.TypeSystem.ILType::definition
	TypeDefinition_tDB5BC46957B9F256FE082FE78EC8121F8F72CF0F * ___definition_2;
	// ILRuntime.Runtime.Enviorment.AppDomain ILRuntime.CLR.TypeSystem.ILType::appdomain
	AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * ___appdomain_3;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::staticConstructorCalled
	bool ___staticConstructorCalled_4;
	// ILRuntime.CLR.Method.ILMethod ILRuntime.CLR.TypeSystem.ILType::staticConstructor
	ILMethod_t2BB68162E74186F7B88F8DD1CEF140B9842C8D8B * ___staticConstructor_5;
	// System.Collections.Generic.List`1<ILRuntime.CLR.Method.ILMethod> ILRuntime.CLR.TypeSystem.ILType::constructors
	List_1_t24A8BC5C4F5BF0821221F08827FEDE6E9B894320 * ___constructors_6;
	// ILRuntime.CLR.TypeSystem.IType[] ILRuntime.CLR.TypeSystem.ILType::fieldTypes
	ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* ___fieldTypes_7;
	// ILRuntime.Mono.Cecil.FieldDefinition[] ILRuntime.CLR.TypeSystem.ILType::fieldDefinitions
	FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0* ___fieldDefinitions_8;
	// ILRuntime.CLR.TypeSystem.IType[] ILRuntime.CLR.TypeSystem.ILType::staticFieldTypes
	ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* ___staticFieldTypes_9;
	// ILRuntime.Mono.Cecil.FieldDefinition[] ILRuntime.CLR.TypeSystem.ILType::staticFieldDefinitions
	FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0* ___staticFieldDefinitions_10;
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> ILRuntime.CLR.TypeSystem.ILType::fieldMapping
	Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162 * ___fieldMapping_11;
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> ILRuntime.CLR.TypeSystem.ILType::staticFieldMapping
	Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162 * ___staticFieldMapping_12;
	// ILRuntime.Runtime.Intepreter.ILTypeStaticInstance ILRuntime.CLR.TypeSystem.ILType::staticInstance
	ILTypeStaticInstance_tA790A39AC732C21DBF9006F6A8772C1C3AB013B5 * ___staticInstance_13;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32> ILRuntime.CLR.TypeSystem.ILType::fieldTokenMapping
	Dictionary_2_t49CB072CAA9184D326107FA696BB354C43EB5E08 * ___fieldTokenMapping_14;
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::fieldStartIdx
	int32_t ___fieldStartIdx_15;
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::totalFieldCnt
	int32_t ___totalFieldCnt_16;
	// System.Collections.Generic.KeyValuePair`2<System.String,ILRuntime.CLR.TypeSystem.IType>[] ILRuntime.CLR.TypeSystem.ILType::genericArguments
	KeyValuePair_2U5BU5D_tCB908F739CE11EA7E094EB7CB1172BF9F4E43B85* ___genericArguments_17;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.CLR.TypeSystem.ILType::baseType
	RuntimeObject* ___baseType_18;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.CLR.TypeSystem.ILType::byRefType
	RuntimeObject* ___byRefType_19;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.CLR.TypeSystem.ILType::enumType
	RuntimeObject* ___enumType_20;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.CLR.TypeSystem.ILType::elementType
	RuntimeObject* ___elementType_21;
	// System.Collections.Generic.Dictionary`2<System.Int32,ILRuntime.CLR.TypeSystem.IType> ILRuntime.CLR.TypeSystem.ILType::arrayTypes
	Dictionary_2_t061ADB0E2EC4ED1C323DC00B84F25404EED49736 * ___arrayTypes_22;
	// System.Type ILRuntime.CLR.TypeSystem.ILType::arrayCLRType
	Type_t * ___arrayCLRType_23;
	// System.Type ILRuntime.CLR.TypeSystem.ILType::byRefCLRType
	Type_t * ___byRefCLRType_24;
	// ILRuntime.CLR.TypeSystem.IType[] ILRuntime.CLR.TypeSystem.ILType::interfaces
	ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* ___interfaces_25;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::baseTypeInitialized
	bool ___baseTypeInitialized_26;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::interfaceInitialized
	bool ___interfaceInitialized_27;
	// System.Collections.Generic.List`1<ILRuntime.CLR.TypeSystem.ILType> ILRuntime.CLR.TypeSystem.ILType::genericInstances
	List_1_t90485522A4E2346576EFE8A1A39658A219F00796 * ___genericInstances_28;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::isDelegate
	bool ___isDelegate_29;
	// ILRuntime.Reflection.ILRuntimeType ILRuntime.CLR.TypeSystem.ILType::reflectionType
	ILRuntimeType_tE8E25D5C24E1D9239C605CA77B86273B6A3DCDF2 * ___reflectionType_30;
	// ILRuntime.CLR.TypeSystem.ILType ILRuntime.CLR.TypeSystem.ILType::genericDefinition
	ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * ___genericDefinition_31;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.CLR.TypeSystem.ILType::firstCLRBaseType
	RuntimeObject* ___firstCLRBaseType_32;
	// ILRuntime.CLR.TypeSystem.IType ILRuntime.CLR.TypeSystem.ILType::firstCLRInterface
	RuntimeObject* ___firstCLRInterface_33;
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::hashCode
	int32_t ___hashCode_34;
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::tIdx
	int32_t ___tIdx_35;
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::jitFlags
	int32_t ___jitFlags_37;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::mToStringGot
	bool ___mToStringGot_38;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::mEqualsGot
	bool ___mEqualsGot_39;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::mGetHashCodeGot
	bool ___mGetHashCodeGot_40;
	// ILRuntime.CLR.Method.IMethod ILRuntime.CLR.TypeSystem.ILType::mToString
	RuntimeObject* ___mToString_41;
	// ILRuntime.CLR.Method.IMethod ILRuntime.CLR.TypeSystem.ILType::mEquals
	RuntimeObject* ___mEquals_42;
	// ILRuntime.CLR.Method.IMethod ILRuntime.CLR.TypeSystem.ILType::mGetHashCode
	RuntimeObject* ___mGetHashCode_43;
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::valuetypeFieldCount
	int32_t ___valuetypeFieldCount_44;
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::valuetypeManagedCount
	int32_t ___valuetypeManagedCount_45;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::valuetypeSizeCalculated
	bool ___valuetypeSizeCalculated_46;
	// System.Boolean ILRuntime.CLR.TypeSystem.ILType::<IsArray>k__BackingField
	bool ___U3CIsArrayU3Ek__BackingField_47;
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::<ArrayRank>k__BackingField
	int32_t ___U3CArrayRankU3Ek__BackingField_48;
	// System.Nullable`1<System.Boolean> ILRuntime.CLR.TypeSystem.ILType::isValueType
	Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  ___isValueType_49;
	// System.String ILRuntime.CLR.TypeSystem.ILType::fullName
	String_t* ___fullName_50;
	// System.String ILRuntime.CLR.TypeSystem.ILType::fullNameForNested
	String_t* ___fullNameForNested_51;

public:
	inline static int32_t get_offset_of_methods_0() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___methods_0)); }
	inline Dictionary_2_t0CA2C2C7261253E1492136E657CF00E1677F4BA0 * get_methods_0() const { return ___methods_0; }
	inline Dictionary_2_t0CA2C2C7261253E1492136E657CF00E1677F4BA0 ** get_address_of_methods_0() { return &___methods_0; }
	inline void set_methods_0(Dictionary_2_t0CA2C2C7261253E1492136E657CF00E1677F4BA0 * value)
	{
		___methods_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___methods_0), (void*)value);
	}

	inline static int32_t get_offset_of_typeRef_1() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___typeRef_1)); }
	inline TypeReference_t72C4131E60A79E1B419C38BF5DD0C213033BB425 * get_typeRef_1() const { return ___typeRef_1; }
	inline TypeReference_t72C4131E60A79E1B419C38BF5DD0C213033BB425 ** get_address_of_typeRef_1() { return &___typeRef_1; }
	inline void set_typeRef_1(TypeReference_t72C4131E60A79E1B419C38BF5DD0C213033BB425 * value)
	{
		___typeRef_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___typeRef_1), (void*)value);
	}

	inline static int32_t get_offset_of_definition_2() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___definition_2)); }
	inline TypeDefinition_tDB5BC46957B9F256FE082FE78EC8121F8F72CF0F * get_definition_2() const { return ___definition_2; }
	inline TypeDefinition_tDB5BC46957B9F256FE082FE78EC8121F8F72CF0F ** get_address_of_definition_2() { return &___definition_2; }
	inline void set_definition_2(TypeDefinition_tDB5BC46957B9F256FE082FE78EC8121F8F72CF0F * value)
	{
		___definition_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___definition_2), (void*)value);
	}

	inline static int32_t get_offset_of_appdomain_3() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___appdomain_3)); }
	inline AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * get_appdomain_3() const { return ___appdomain_3; }
	inline AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 ** get_address_of_appdomain_3() { return &___appdomain_3; }
	inline void set_appdomain_3(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * value)
	{
		___appdomain_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___appdomain_3), (void*)value);
	}

	inline static int32_t get_offset_of_staticConstructorCalled_4() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___staticConstructorCalled_4)); }
	inline bool get_staticConstructorCalled_4() const { return ___staticConstructorCalled_4; }
	inline bool* get_address_of_staticConstructorCalled_4() { return &___staticConstructorCalled_4; }
	inline void set_staticConstructorCalled_4(bool value)
	{
		___staticConstructorCalled_4 = value;
	}

	inline static int32_t get_offset_of_staticConstructor_5() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___staticConstructor_5)); }
	inline ILMethod_t2BB68162E74186F7B88F8DD1CEF140B9842C8D8B * get_staticConstructor_5() const { return ___staticConstructor_5; }
	inline ILMethod_t2BB68162E74186F7B88F8DD1CEF140B9842C8D8B ** get_address_of_staticConstructor_5() { return &___staticConstructor_5; }
	inline void set_staticConstructor_5(ILMethod_t2BB68162E74186F7B88F8DD1CEF140B9842C8D8B * value)
	{
		___staticConstructor_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___staticConstructor_5), (void*)value);
	}

	inline static int32_t get_offset_of_constructors_6() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___constructors_6)); }
	inline List_1_t24A8BC5C4F5BF0821221F08827FEDE6E9B894320 * get_constructors_6() const { return ___constructors_6; }
	inline List_1_t24A8BC5C4F5BF0821221F08827FEDE6E9B894320 ** get_address_of_constructors_6() { return &___constructors_6; }
	inline void set_constructors_6(List_1_t24A8BC5C4F5BF0821221F08827FEDE6E9B894320 * value)
	{
		___constructors_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___constructors_6), (void*)value);
	}

	inline static int32_t get_offset_of_fieldTypes_7() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___fieldTypes_7)); }
	inline ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* get_fieldTypes_7() const { return ___fieldTypes_7; }
	inline ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54** get_address_of_fieldTypes_7() { return &___fieldTypes_7; }
	inline void set_fieldTypes_7(ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* value)
	{
		___fieldTypes_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fieldTypes_7), (void*)value);
	}

	inline static int32_t get_offset_of_fieldDefinitions_8() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___fieldDefinitions_8)); }
	inline FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0* get_fieldDefinitions_8() const { return ___fieldDefinitions_8; }
	inline FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0** get_address_of_fieldDefinitions_8() { return &___fieldDefinitions_8; }
	inline void set_fieldDefinitions_8(FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0* value)
	{
		___fieldDefinitions_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fieldDefinitions_8), (void*)value);
	}

	inline static int32_t get_offset_of_staticFieldTypes_9() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___staticFieldTypes_9)); }
	inline ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* get_staticFieldTypes_9() const { return ___staticFieldTypes_9; }
	inline ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54** get_address_of_staticFieldTypes_9() { return &___staticFieldTypes_9; }
	inline void set_staticFieldTypes_9(ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* value)
	{
		___staticFieldTypes_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___staticFieldTypes_9), (void*)value);
	}

	inline static int32_t get_offset_of_staticFieldDefinitions_10() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___staticFieldDefinitions_10)); }
	inline FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0* get_staticFieldDefinitions_10() const { return ___staticFieldDefinitions_10; }
	inline FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0** get_address_of_staticFieldDefinitions_10() { return &___staticFieldDefinitions_10; }
	inline void set_staticFieldDefinitions_10(FieldDefinitionU5BU5D_t23D2044A48BBDD1560A506AC6B71CB51C8237EF0* value)
	{
		___staticFieldDefinitions_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___staticFieldDefinitions_10), (void*)value);
	}

	inline static int32_t get_offset_of_fieldMapping_11() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___fieldMapping_11)); }
	inline Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162 * get_fieldMapping_11() const { return ___fieldMapping_11; }
	inline Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162 ** get_address_of_fieldMapping_11() { return &___fieldMapping_11; }
	inline void set_fieldMapping_11(Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162 * value)
	{
		___fieldMapping_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fieldMapping_11), (void*)value);
	}

	inline static int32_t get_offset_of_staticFieldMapping_12() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___staticFieldMapping_12)); }
	inline Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162 * get_staticFieldMapping_12() const { return ___staticFieldMapping_12; }
	inline Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162 ** get_address_of_staticFieldMapping_12() { return &___staticFieldMapping_12; }
	inline void set_staticFieldMapping_12(Dictionary_2_tC94E9875910491F8130C2DC8B11E4D1548A55162 * value)
	{
		___staticFieldMapping_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___staticFieldMapping_12), (void*)value);
	}

	inline static int32_t get_offset_of_staticInstance_13() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___staticInstance_13)); }
	inline ILTypeStaticInstance_tA790A39AC732C21DBF9006F6A8772C1C3AB013B5 * get_staticInstance_13() const { return ___staticInstance_13; }
	inline ILTypeStaticInstance_tA790A39AC732C21DBF9006F6A8772C1C3AB013B5 ** get_address_of_staticInstance_13() { return &___staticInstance_13; }
	inline void set_staticInstance_13(ILTypeStaticInstance_tA790A39AC732C21DBF9006F6A8772C1C3AB013B5 * value)
	{
		___staticInstance_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___staticInstance_13), (void*)value);
	}

	inline static int32_t get_offset_of_fieldTokenMapping_14() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___fieldTokenMapping_14)); }
	inline Dictionary_2_t49CB072CAA9184D326107FA696BB354C43EB5E08 * get_fieldTokenMapping_14() const { return ___fieldTokenMapping_14; }
	inline Dictionary_2_t49CB072CAA9184D326107FA696BB354C43EB5E08 ** get_address_of_fieldTokenMapping_14() { return &___fieldTokenMapping_14; }
	inline void set_fieldTokenMapping_14(Dictionary_2_t49CB072CAA9184D326107FA696BB354C43EB5E08 * value)
	{
		___fieldTokenMapping_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fieldTokenMapping_14), (void*)value);
	}

	inline static int32_t get_offset_of_fieldStartIdx_15() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___fieldStartIdx_15)); }
	inline int32_t get_fieldStartIdx_15() const { return ___fieldStartIdx_15; }
	inline int32_t* get_address_of_fieldStartIdx_15() { return &___fieldStartIdx_15; }
	inline void set_fieldStartIdx_15(int32_t value)
	{
		___fieldStartIdx_15 = value;
	}

	inline static int32_t get_offset_of_totalFieldCnt_16() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___totalFieldCnt_16)); }
	inline int32_t get_totalFieldCnt_16() const { return ___totalFieldCnt_16; }
	inline int32_t* get_address_of_totalFieldCnt_16() { return &___totalFieldCnt_16; }
	inline void set_totalFieldCnt_16(int32_t value)
	{
		___totalFieldCnt_16 = value;
	}

	inline static int32_t get_offset_of_genericArguments_17() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___genericArguments_17)); }
	inline KeyValuePair_2U5BU5D_tCB908F739CE11EA7E094EB7CB1172BF9F4E43B85* get_genericArguments_17() const { return ___genericArguments_17; }
	inline KeyValuePair_2U5BU5D_tCB908F739CE11EA7E094EB7CB1172BF9F4E43B85** get_address_of_genericArguments_17() { return &___genericArguments_17; }
	inline void set_genericArguments_17(KeyValuePair_2U5BU5D_tCB908F739CE11EA7E094EB7CB1172BF9F4E43B85* value)
	{
		___genericArguments_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___genericArguments_17), (void*)value);
	}

	inline static int32_t get_offset_of_baseType_18() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___baseType_18)); }
	inline RuntimeObject* get_baseType_18() const { return ___baseType_18; }
	inline RuntimeObject** get_address_of_baseType_18() { return &___baseType_18; }
	inline void set_baseType_18(RuntimeObject* value)
	{
		___baseType_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___baseType_18), (void*)value);
	}

	inline static int32_t get_offset_of_byRefType_19() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___byRefType_19)); }
	inline RuntimeObject* get_byRefType_19() const { return ___byRefType_19; }
	inline RuntimeObject** get_address_of_byRefType_19() { return &___byRefType_19; }
	inline void set_byRefType_19(RuntimeObject* value)
	{
		___byRefType_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___byRefType_19), (void*)value);
	}

	inline static int32_t get_offset_of_enumType_20() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___enumType_20)); }
	inline RuntimeObject* get_enumType_20() const { return ___enumType_20; }
	inline RuntimeObject** get_address_of_enumType_20() { return &___enumType_20; }
	inline void set_enumType_20(RuntimeObject* value)
	{
		___enumType_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumType_20), (void*)value);
	}

	inline static int32_t get_offset_of_elementType_21() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___elementType_21)); }
	inline RuntimeObject* get_elementType_21() const { return ___elementType_21; }
	inline RuntimeObject** get_address_of_elementType_21() { return &___elementType_21; }
	inline void set_elementType_21(RuntimeObject* value)
	{
		___elementType_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___elementType_21), (void*)value);
	}

	inline static int32_t get_offset_of_arrayTypes_22() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___arrayTypes_22)); }
	inline Dictionary_2_t061ADB0E2EC4ED1C323DC00B84F25404EED49736 * get_arrayTypes_22() const { return ___arrayTypes_22; }
	inline Dictionary_2_t061ADB0E2EC4ED1C323DC00B84F25404EED49736 ** get_address_of_arrayTypes_22() { return &___arrayTypes_22; }
	inline void set_arrayTypes_22(Dictionary_2_t061ADB0E2EC4ED1C323DC00B84F25404EED49736 * value)
	{
		___arrayTypes_22 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___arrayTypes_22), (void*)value);
	}

	inline static int32_t get_offset_of_arrayCLRType_23() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___arrayCLRType_23)); }
	inline Type_t * get_arrayCLRType_23() const { return ___arrayCLRType_23; }
	inline Type_t ** get_address_of_arrayCLRType_23() { return &___arrayCLRType_23; }
	inline void set_arrayCLRType_23(Type_t * value)
	{
		___arrayCLRType_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___arrayCLRType_23), (void*)value);
	}

	inline static int32_t get_offset_of_byRefCLRType_24() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___byRefCLRType_24)); }
	inline Type_t * get_byRefCLRType_24() const { return ___byRefCLRType_24; }
	inline Type_t ** get_address_of_byRefCLRType_24() { return &___byRefCLRType_24; }
	inline void set_byRefCLRType_24(Type_t * value)
	{
		___byRefCLRType_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___byRefCLRType_24), (void*)value);
	}

	inline static int32_t get_offset_of_interfaces_25() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___interfaces_25)); }
	inline ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* get_interfaces_25() const { return ___interfaces_25; }
	inline ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54** get_address_of_interfaces_25() { return &___interfaces_25; }
	inline void set_interfaces_25(ITypeU5BU5D_tCFC66A2C802B39EECD0A83C1DDC83870EDB90F54* value)
	{
		___interfaces_25 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___interfaces_25), (void*)value);
	}

	inline static int32_t get_offset_of_baseTypeInitialized_26() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___baseTypeInitialized_26)); }
	inline bool get_baseTypeInitialized_26() const { return ___baseTypeInitialized_26; }
	inline bool* get_address_of_baseTypeInitialized_26() { return &___baseTypeInitialized_26; }
	inline void set_baseTypeInitialized_26(bool value)
	{
		___baseTypeInitialized_26 = value;
	}

	inline static int32_t get_offset_of_interfaceInitialized_27() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___interfaceInitialized_27)); }
	inline bool get_interfaceInitialized_27() const { return ___interfaceInitialized_27; }
	inline bool* get_address_of_interfaceInitialized_27() { return &___interfaceInitialized_27; }
	inline void set_interfaceInitialized_27(bool value)
	{
		___interfaceInitialized_27 = value;
	}

	inline static int32_t get_offset_of_genericInstances_28() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___genericInstances_28)); }
	inline List_1_t90485522A4E2346576EFE8A1A39658A219F00796 * get_genericInstances_28() const { return ___genericInstances_28; }
	inline List_1_t90485522A4E2346576EFE8A1A39658A219F00796 ** get_address_of_genericInstances_28() { return &___genericInstances_28; }
	inline void set_genericInstances_28(List_1_t90485522A4E2346576EFE8A1A39658A219F00796 * value)
	{
		___genericInstances_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___genericInstances_28), (void*)value);
	}

	inline static int32_t get_offset_of_isDelegate_29() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___isDelegate_29)); }
	inline bool get_isDelegate_29() const { return ___isDelegate_29; }
	inline bool* get_address_of_isDelegate_29() { return &___isDelegate_29; }
	inline void set_isDelegate_29(bool value)
	{
		___isDelegate_29 = value;
	}

	inline static int32_t get_offset_of_reflectionType_30() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___reflectionType_30)); }
	inline ILRuntimeType_tE8E25D5C24E1D9239C605CA77B86273B6A3DCDF2 * get_reflectionType_30() const { return ___reflectionType_30; }
	inline ILRuntimeType_tE8E25D5C24E1D9239C605CA77B86273B6A3DCDF2 ** get_address_of_reflectionType_30() { return &___reflectionType_30; }
	inline void set_reflectionType_30(ILRuntimeType_tE8E25D5C24E1D9239C605CA77B86273B6A3DCDF2 * value)
	{
		___reflectionType_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___reflectionType_30), (void*)value);
	}

	inline static int32_t get_offset_of_genericDefinition_31() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___genericDefinition_31)); }
	inline ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * get_genericDefinition_31() const { return ___genericDefinition_31; }
	inline ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 ** get_address_of_genericDefinition_31() { return &___genericDefinition_31; }
	inline void set_genericDefinition_31(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * value)
	{
		___genericDefinition_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___genericDefinition_31), (void*)value);
	}

	inline static int32_t get_offset_of_firstCLRBaseType_32() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___firstCLRBaseType_32)); }
	inline RuntimeObject* get_firstCLRBaseType_32() const { return ___firstCLRBaseType_32; }
	inline RuntimeObject** get_address_of_firstCLRBaseType_32() { return &___firstCLRBaseType_32; }
	inline void set_firstCLRBaseType_32(RuntimeObject* value)
	{
		___firstCLRBaseType_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___firstCLRBaseType_32), (void*)value);
	}

	inline static int32_t get_offset_of_firstCLRInterface_33() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___firstCLRInterface_33)); }
	inline RuntimeObject* get_firstCLRInterface_33() const { return ___firstCLRInterface_33; }
	inline RuntimeObject** get_address_of_firstCLRInterface_33() { return &___firstCLRInterface_33; }
	inline void set_firstCLRInterface_33(RuntimeObject* value)
	{
		___firstCLRInterface_33 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___firstCLRInterface_33), (void*)value);
	}

	inline static int32_t get_offset_of_hashCode_34() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___hashCode_34)); }
	inline int32_t get_hashCode_34() const { return ___hashCode_34; }
	inline int32_t* get_address_of_hashCode_34() { return &___hashCode_34; }
	inline void set_hashCode_34(int32_t value)
	{
		___hashCode_34 = value;
	}

	inline static int32_t get_offset_of_tIdx_35() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___tIdx_35)); }
	inline int32_t get_tIdx_35() const { return ___tIdx_35; }
	inline int32_t* get_address_of_tIdx_35() { return &___tIdx_35; }
	inline void set_tIdx_35(int32_t value)
	{
		___tIdx_35 = value;
	}

	inline static int32_t get_offset_of_jitFlags_37() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___jitFlags_37)); }
	inline int32_t get_jitFlags_37() const { return ___jitFlags_37; }
	inline int32_t* get_address_of_jitFlags_37() { return &___jitFlags_37; }
	inline void set_jitFlags_37(int32_t value)
	{
		___jitFlags_37 = value;
	}

	inline static int32_t get_offset_of_mToStringGot_38() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___mToStringGot_38)); }
	inline bool get_mToStringGot_38() const { return ___mToStringGot_38; }
	inline bool* get_address_of_mToStringGot_38() { return &___mToStringGot_38; }
	inline void set_mToStringGot_38(bool value)
	{
		___mToStringGot_38 = value;
	}

	inline static int32_t get_offset_of_mEqualsGot_39() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___mEqualsGot_39)); }
	inline bool get_mEqualsGot_39() const { return ___mEqualsGot_39; }
	inline bool* get_address_of_mEqualsGot_39() { return &___mEqualsGot_39; }
	inline void set_mEqualsGot_39(bool value)
	{
		___mEqualsGot_39 = value;
	}

	inline static int32_t get_offset_of_mGetHashCodeGot_40() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___mGetHashCodeGot_40)); }
	inline bool get_mGetHashCodeGot_40() const { return ___mGetHashCodeGot_40; }
	inline bool* get_address_of_mGetHashCodeGot_40() { return &___mGetHashCodeGot_40; }
	inline void set_mGetHashCodeGot_40(bool value)
	{
		___mGetHashCodeGot_40 = value;
	}

	inline static int32_t get_offset_of_mToString_41() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___mToString_41)); }
	inline RuntimeObject* get_mToString_41() const { return ___mToString_41; }
	inline RuntimeObject** get_address_of_mToString_41() { return &___mToString_41; }
	inline void set_mToString_41(RuntimeObject* value)
	{
		___mToString_41 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mToString_41), (void*)value);
	}

	inline static int32_t get_offset_of_mEquals_42() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___mEquals_42)); }
	inline RuntimeObject* get_mEquals_42() const { return ___mEquals_42; }
	inline RuntimeObject** get_address_of_mEquals_42() { return &___mEquals_42; }
	inline void set_mEquals_42(RuntimeObject* value)
	{
		___mEquals_42 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mEquals_42), (void*)value);
	}

	inline static int32_t get_offset_of_mGetHashCode_43() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___mGetHashCode_43)); }
	inline RuntimeObject* get_mGetHashCode_43() const { return ___mGetHashCode_43; }
	inline RuntimeObject** get_address_of_mGetHashCode_43() { return &___mGetHashCode_43; }
	inline void set_mGetHashCode_43(RuntimeObject* value)
	{
		___mGetHashCode_43 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mGetHashCode_43), (void*)value);
	}

	inline static int32_t get_offset_of_valuetypeFieldCount_44() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___valuetypeFieldCount_44)); }
	inline int32_t get_valuetypeFieldCount_44() const { return ___valuetypeFieldCount_44; }
	inline int32_t* get_address_of_valuetypeFieldCount_44() { return &___valuetypeFieldCount_44; }
	inline void set_valuetypeFieldCount_44(int32_t value)
	{
		___valuetypeFieldCount_44 = value;
	}

	inline static int32_t get_offset_of_valuetypeManagedCount_45() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___valuetypeManagedCount_45)); }
	inline int32_t get_valuetypeManagedCount_45() const { return ___valuetypeManagedCount_45; }
	inline int32_t* get_address_of_valuetypeManagedCount_45() { return &___valuetypeManagedCount_45; }
	inline void set_valuetypeManagedCount_45(int32_t value)
	{
		___valuetypeManagedCount_45 = value;
	}

	inline static int32_t get_offset_of_valuetypeSizeCalculated_46() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___valuetypeSizeCalculated_46)); }
	inline bool get_valuetypeSizeCalculated_46() const { return ___valuetypeSizeCalculated_46; }
	inline bool* get_address_of_valuetypeSizeCalculated_46() { return &___valuetypeSizeCalculated_46; }
	inline void set_valuetypeSizeCalculated_46(bool value)
	{
		___valuetypeSizeCalculated_46 = value;
	}

	inline static int32_t get_offset_of_U3CIsArrayU3Ek__BackingField_47() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___U3CIsArrayU3Ek__BackingField_47)); }
	inline bool get_U3CIsArrayU3Ek__BackingField_47() const { return ___U3CIsArrayU3Ek__BackingField_47; }
	inline bool* get_address_of_U3CIsArrayU3Ek__BackingField_47() { return &___U3CIsArrayU3Ek__BackingField_47; }
	inline void set_U3CIsArrayU3Ek__BackingField_47(bool value)
	{
		___U3CIsArrayU3Ek__BackingField_47 = value;
	}

	inline static int32_t get_offset_of_U3CArrayRankU3Ek__BackingField_48() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___U3CArrayRankU3Ek__BackingField_48)); }
	inline int32_t get_U3CArrayRankU3Ek__BackingField_48() const { return ___U3CArrayRankU3Ek__BackingField_48; }
	inline int32_t* get_address_of_U3CArrayRankU3Ek__BackingField_48() { return &___U3CArrayRankU3Ek__BackingField_48; }
	inline void set_U3CArrayRankU3Ek__BackingField_48(int32_t value)
	{
		___U3CArrayRankU3Ek__BackingField_48 = value;
	}

	inline static int32_t get_offset_of_isValueType_49() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___isValueType_49)); }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  get_isValueType_49() const { return ___isValueType_49; }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3 * get_address_of_isValueType_49() { return &___isValueType_49; }
	inline void set_isValueType_49(Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  value)
	{
		___isValueType_49 = value;
	}

	inline static int32_t get_offset_of_fullName_50() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___fullName_50)); }
	inline String_t* get_fullName_50() const { return ___fullName_50; }
	inline String_t** get_address_of_fullName_50() { return &___fullName_50; }
	inline void set_fullName_50(String_t* value)
	{
		___fullName_50 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fullName_50), (void*)value);
	}

	inline static int32_t get_offset_of_fullNameForNested_51() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7, ___fullNameForNested_51)); }
	inline String_t* get_fullNameForNested_51() const { return ___fullNameForNested_51; }
	inline String_t** get_address_of_fullNameForNested_51() { return &___fullNameForNested_51; }
	inline void set_fullNameForNested_51(String_t* value)
	{
		___fullNameForNested_51 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fullNameForNested_51), (void*)value);
	}
};

struct ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7_StaticFields
{
public:
	// System.Int32 ILRuntime.CLR.TypeSystem.ILType::instance_id
	int32_t ___instance_id_36;

public:
	inline static int32_t get_offset_of_instance_id_36() { return static_cast<int32_t>(offsetof(ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7_StaticFields, ___instance_id_36)); }
	inline int32_t get_instance_id_36() const { return ___instance_id_36; }
	inline int32_t* get_address_of_instance_id_36() { return &___instance_id_36; }
	inline void set_instance_id_36(int32_t value)
	{
		___instance_id_36 = value;
	}
};


// System.IO.MemoryStream
struct MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C  : public Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB
{
public:
	// System.Byte[] System.IO.MemoryStream::_buffer
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____buffer_5;
	// System.Int32 System.IO.MemoryStream::_origin
	int32_t ____origin_6;
	// System.Int32 System.IO.MemoryStream::_position
	int32_t ____position_7;
	// System.Int32 System.IO.MemoryStream::_length
	int32_t ____length_8;
	// System.Int32 System.IO.MemoryStream::_capacity
	int32_t ____capacity_9;
	// System.Boolean System.IO.MemoryStream::_expandable
	bool ____expandable_10;
	// System.Boolean System.IO.MemoryStream::_writable
	bool ____writable_11;
	// System.Boolean System.IO.MemoryStream::_exposable
	bool ____exposable_12;
	// System.Boolean System.IO.MemoryStream::_isOpen
	bool ____isOpen_13;
	// System.Threading.Tasks.Task`1<System.Int32> System.IO.MemoryStream::_lastReadTask
	Task_1_tEF253D967DB628A9F8A389A9F2E4516871FD3725 * ____lastReadTask_14;

public:
	inline static int32_t get_offset_of__buffer_5() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____buffer_5)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get__buffer_5() const { return ____buffer_5; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of__buffer_5() { return &____buffer_5; }
	inline void set__buffer_5(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		____buffer_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____buffer_5), (void*)value);
	}

	inline static int32_t get_offset_of__origin_6() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____origin_6)); }
	inline int32_t get__origin_6() const { return ____origin_6; }
	inline int32_t* get_address_of__origin_6() { return &____origin_6; }
	inline void set__origin_6(int32_t value)
	{
		____origin_6 = value;
	}

	inline static int32_t get_offset_of__position_7() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____position_7)); }
	inline int32_t get__position_7() const { return ____position_7; }
	inline int32_t* get_address_of__position_7() { return &____position_7; }
	inline void set__position_7(int32_t value)
	{
		____position_7 = value;
	}

	inline static int32_t get_offset_of__length_8() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____length_8)); }
	inline int32_t get__length_8() const { return ____length_8; }
	inline int32_t* get_address_of__length_8() { return &____length_8; }
	inline void set__length_8(int32_t value)
	{
		____length_8 = value;
	}

	inline static int32_t get_offset_of__capacity_9() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____capacity_9)); }
	inline int32_t get__capacity_9() const { return ____capacity_9; }
	inline int32_t* get_address_of__capacity_9() { return &____capacity_9; }
	inline void set__capacity_9(int32_t value)
	{
		____capacity_9 = value;
	}

	inline static int32_t get_offset_of__expandable_10() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____expandable_10)); }
	inline bool get__expandable_10() const { return ____expandable_10; }
	inline bool* get_address_of__expandable_10() { return &____expandable_10; }
	inline void set__expandable_10(bool value)
	{
		____expandable_10 = value;
	}

	inline static int32_t get_offset_of__writable_11() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____writable_11)); }
	inline bool get__writable_11() const { return ____writable_11; }
	inline bool* get_address_of__writable_11() { return &____writable_11; }
	inline void set__writable_11(bool value)
	{
		____writable_11 = value;
	}

	inline static int32_t get_offset_of__exposable_12() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____exposable_12)); }
	inline bool get__exposable_12() const { return ____exposable_12; }
	inline bool* get_address_of__exposable_12() { return &____exposable_12; }
	inline void set__exposable_12(bool value)
	{
		____exposable_12 = value;
	}

	inline static int32_t get_offset_of__isOpen_13() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____isOpen_13)); }
	inline bool get__isOpen_13() const { return ____isOpen_13; }
	inline bool* get_address_of__isOpen_13() { return &____isOpen_13; }
	inline void set__isOpen_13(bool value)
	{
		____isOpen_13 = value;
	}

	inline static int32_t get_offset_of__lastReadTask_14() { return static_cast<int32_t>(offsetof(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C, ____lastReadTask_14)); }
	inline Task_1_tEF253D967DB628A9F8A389A9F2E4516871FD3725 * get__lastReadTask_14() const { return ____lastReadTask_14; }
	inline Task_1_tEF253D967DB628A9F8A389A9F2E4516871FD3725 ** get_address_of__lastReadTask_14() { return &____lastReadTask_14; }
	inline void set__lastReadTask_14(Task_1_tEF253D967DB628A9F8A389A9F2E4516871FD3725 * value)
	{
		____lastReadTask_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____lastReadTask_14), (void*)value);
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

// System.IO.SeekOrigin
struct SeekOrigin_t4A91B37D046CD7A6578066059AE9F6269A888D4F 
{
public:
	// System.Int32 System.IO.SeekOrigin::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(SeekOrigin_t4A91B37D046CD7A6578066059AE9F6269A888D4F, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// ET.ServiceType
struct ServiceType_tE511803D87C98F11A005D9F0365B5469E843A6C7 
{
public:
	// System.Int32 ET.ServiceType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ServiceType_tE511803D87C98F11A005D9F0365B5469E843A6C7, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Threading.Tasks.Task
struct Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60  : public RuntimeObject
{
public:
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_taskId
	int32_t ___m_taskId_4;
	// System.Object System.Threading.Tasks.Task::m_action
	RuntimeObject * ___m_action_5;
	// System.Object System.Threading.Tasks.Task::m_stateObject
	RuntimeObject * ___m_stateObject_6;
	// System.Threading.Tasks.TaskScheduler System.Threading.Tasks.Task::m_taskScheduler
	TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * ___m_taskScheduler_7;
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::m_parent
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___m_parent_8;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_stateFlags
	int32_t ___m_stateFlags_9;
	// System.Object modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_continuationObject
	RuntimeObject * ___m_continuationObject_28;
	// System.Threading.Tasks.Task/ContingentProperties modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_contingentProperties
	ContingentProperties_t1E249C737B8B8644ED1D60EEFA101D326B199EA0 * ___m_contingentProperties_33;

public:
	inline static int32_t get_offset_of_m_taskId_4() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60, ___m_taskId_4)); }
	inline int32_t get_m_taskId_4() const { return ___m_taskId_4; }
	inline int32_t* get_address_of_m_taskId_4() { return &___m_taskId_4; }
	inline void set_m_taskId_4(int32_t value)
	{
		___m_taskId_4 = value;
	}

	inline static int32_t get_offset_of_m_action_5() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60, ___m_action_5)); }
	inline RuntimeObject * get_m_action_5() const { return ___m_action_5; }
	inline RuntimeObject ** get_address_of_m_action_5() { return &___m_action_5; }
	inline void set_m_action_5(RuntimeObject * value)
	{
		___m_action_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_action_5), (void*)value);
	}

	inline static int32_t get_offset_of_m_stateObject_6() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60, ___m_stateObject_6)); }
	inline RuntimeObject * get_m_stateObject_6() const { return ___m_stateObject_6; }
	inline RuntimeObject ** get_address_of_m_stateObject_6() { return &___m_stateObject_6; }
	inline void set_m_stateObject_6(RuntimeObject * value)
	{
		___m_stateObject_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_stateObject_6), (void*)value);
	}

	inline static int32_t get_offset_of_m_taskScheduler_7() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60, ___m_taskScheduler_7)); }
	inline TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * get_m_taskScheduler_7() const { return ___m_taskScheduler_7; }
	inline TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D ** get_address_of_m_taskScheduler_7() { return &___m_taskScheduler_7; }
	inline void set_m_taskScheduler_7(TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D * value)
	{
		___m_taskScheduler_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_taskScheduler_7), (void*)value);
	}

	inline static int32_t get_offset_of_m_parent_8() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60, ___m_parent_8)); }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * get_m_parent_8() const { return ___m_parent_8; }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 ** get_address_of_m_parent_8() { return &___m_parent_8; }
	inline void set_m_parent_8(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * value)
	{
		___m_parent_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_parent_8), (void*)value);
	}

	inline static int32_t get_offset_of_m_stateFlags_9() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60, ___m_stateFlags_9)); }
	inline int32_t get_m_stateFlags_9() const { return ___m_stateFlags_9; }
	inline int32_t* get_address_of_m_stateFlags_9() { return &___m_stateFlags_9; }
	inline void set_m_stateFlags_9(int32_t value)
	{
		___m_stateFlags_9 = value;
	}

	inline static int32_t get_offset_of_m_continuationObject_28() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60, ___m_continuationObject_28)); }
	inline RuntimeObject * get_m_continuationObject_28() const { return ___m_continuationObject_28; }
	inline RuntimeObject ** get_address_of_m_continuationObject_28() { return &___m_continuationObject_28; }
	inline void set_m_continuationObject_28(RuntimeObject * value)
	{
		___m_continuationObject_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_continuationObject_28), (void*)value);
	}

	inline static int32_t get_offset_of_m_contingentProperties_33() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60, ___m_contingentProperties_33)); }
	inline ContingentProperties_t1E249C737B8B8644ED1D60EEFA101D326B199EA0 * get_m_contingentProperties_33() const { return ___m_contingentProperties_33; }
	inline ContingentProperties_t1E249C737B8B8644ED1D60EEFA101D326B199EA0 ** get_address_of_m_contingentProperties_33() { return &___m_contingentProperties_33; }
	inline void set_m_contingentProperties_33(ContingentProperties_t1E249C737B8B8644ED1D60EEFA101D326B199EA0 * value)
	{
		___m_contingentProperties_33 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_contingentProperties_33), (void*)value);
	}
};

struct Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields
{
public:
	// System.Int32 System.Threading.Tasks.Task::s_taskIdCounter
	int32_t ___s_taskIdCounter_2;
	// System.Threading.Tasks.TaskFactory System.Threading.Tasks.Task::s_factory
	TaskFactory_t22D999A05A967C31A4B5FFBD08864809BF35EA3B * ___s_factory_3;
	// System.Object System.Threading.Tasks.Task::s_taskCompletionSentinel
	RuntimeObject * ___s_taskCompletionSentinel_29;
	// System.Boolean System.Threading.Tasks.Task::s_asyncDebuggingEnabled
	bool ___s_asyncDebuggingEnabled_30;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task> System.Threading.Tasks.Task::s_currentActiveTasks
	Dictionary_2_tB758E2A2593CD827EFC041BE1F1BB4B68DE1C3E8 * ___s_currentActiveTasks_31;
	// System.Object System.Threading.Tasks.Task::s_activeTasksLock
	RuntimeObject * ___s_activeTasksLock_32;
	// System.Action`1<System.Object> System.Threading.Tasks.Task::s_taskCancelCallback
	Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * ___s_taskCancelCallback_34;
	// System.Func`1<System.Threading.Tasks.Task/ContingentProperties> System.Threading.Tasks.Task::s_createContingentProperties
	Func_1_tBCF42601FA307876E83080BE4204110820F8BF3B * ___s_createContingentProperties_35;
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::s_completedTask
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___s_completedTask_36;
	// System.Predicate`1<System.Threading.Tasks.Task> System.Threading.Tasks.Task::s_IsExceptionObservedByParentPredicate
	Predicate_1_tC0DBBC8498BD1EE6ABFFAA5628024105FA7D11BD * ___s_IsExceptionObservedByParentPredicate_37;
	// System.Threading.ContextCallback System.Threading.Tasks.Task::s_ecCallback
	ContextCallback_t93707E0430F4FF3E15E1FB5A4844BE89C657AE8B * ___s_ecCallback_38;
	// System.Predicate`1<System.Object> System.Threading.Tasks.Task::s_IsTaskContinuationNullPredicate
	Predicate_1_t5C96B81B31A697B11C4C3767E3298773AF25DFEB * ___s_IsTaskContinuationNullPredicate_39;

public:
	inline static int32_t get_offset_of_s_taskIdCounter_2() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_taskIdCounter_2)); }
	inline int32_t get_s_taskIdCounter_2() const { return ___s_taskIdCounter_2; }
	inline int32_t* get_address_of_s_taskIdCounter_2() { return &___s_taskIdCounter_2; }
	inline void set_s_taskIdCounter_2(int32_t value)
	{
		___s_taskIdCounter_2 = value;
	}

	inline static int32_t get_offset_of_s_factory_3() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_factory_3)); }
	inline TaskFactory_t22D999A05A967C31A4B5FFBD08864809BF35EA3B * get_s_factory_3() const { return ___s_factory_3; }
	inline TaskFactory_t22D999A05A967C31A4B5FFBD08864809BF35EA3B ** get_address_of_s_factory_3() { return &___s_factory_3; }
	inline void set_s_factory_3(TaskFactory_t22D999A05A967C31A4B5FFBD08864809BF35EA3B * value)
	{
		___s_factory_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_factory_3), (void*)value);
	}

	inline static int32_t get_offset_of_s_taskCompletionSentinel_29() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_taskCompletionSentinel_29)); }
	inline RuntimeObject * get_s_taskCompletionSentinel_29() const { return ___s_taskCompletionSentinel_29; }
	inline RuntimeObject ** get_address_of_s_taskCompletionSentinel_29() { return &___s_taskCompletionSentinel_29; }
	inline void set_s_taskCompletionSentinel_29(RuntimeObject * value)
	{
		___s_taskCompletionSentinel_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_taskCompletionSentinel_29), (void*)value);
	}

	inline static int32_t get_offset_of_s_asyncDebuggingEnabled_30() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_asyncDebuggingEnabled_30)); }
	inline bool get_s_asyncDebuggingEnabled_30() const { return ___s_asyncDebuggingEnabled_30; }
	inline bool* get_address_of_s_asyncDebuggingEnabled_30() { return &___s_asyncDebuggingEnabled_30; }
	inline void set_s_asyncDebuggingEnabled_30(bool value)
	{
		___s_asyncDebuggingEnabled_30 = value;
	}

	inline static int32_t get_offset_of_s_currentActiveTasks_31() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_currentActiveTasks_31)); }
	inline Dictionary_2_tB758E2A2593CD827EFC041BE1F1BB4B68DE1C3E8 * get_s_currentActiveTasks_31() const { return ___s_currentActiveTasks_31; }
	inline Dictionary_2_tB758E2A2593CD827EFC041BE1F1BB4B68DE1C3E8 ** get_address_of_s_currentActiveTasks_31() { return &___s_currentActiveTasks_31; }
	inline void set_s_currentActiveTasks_31(Dictionary_2_tB758E2A2593CD827EFC041BE1F1BB4B68DE1C3E8 * value)
	{
		___s_currentActiveTasks_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_currentActiveTasks_31), (void*)value);
	}

	inline static int32_t get_offset_of_s_activeTasksLock_32() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_activeTasksLock_32)); }
	inline RuntimeObject * get_s_activeTasksLock_32() const { return ___s_activeTasksLock_32; }
	inline RuntimeObject ** get_address_of_s_activeTasksLock_32() { return &___s_activeTasksLock_32; }
	inline void set_s_activeTasksLock_32(RuntimeObject * value)
	{
		___s_activeTasksLock_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_activeTasksLock_32), (void*)value);
	}

	inline static int32_t get_offset_of_s_taskCancelCallback_34() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_taskCancelCallback_34)); }
	inline Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * get_s_taskCancelCallback_34() const { return ___s_taskCancelCallback_34; }
	inline Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC ** get_address_of_s_taskCancelCallback_34() { return &___s_taskCancelCallback_34; }
	inline void set_s_taskCancelCallback_34(Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * value)
	{
		___s_taskCancelCallback_34 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_taskCancelCallback_34), (void*)value);
	}

	inline static int32_t get_offset_of_s_createContingentProperties_35() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_createContingentProperties_35)); }
	inline Func_1_tBCF42601FA307876E83080BE4204110820F8BF3B * get_s_createContingentProperties_35() const { return ___s_createContingentProperties_35; }
	inline Func_1_tBCF42601FA307876E83080BE4204110820F8BF3B ** get_address_of_s_createContingentProperties_35() { return &___s_createContingentProperties_35; }
	inline void set_s_createContingentProperties_35(Func_1_tBCF42601FA307876E83080BE4204110820F8BF3B * value)
	{
		___s_createContingentProperties_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_createContingentProperties_35), (void*)value);
	}

	inline static int32_t get_offset_of_s_completedTask_36() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_completedTask_36)); }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * get_s_completedTask_36() const { return ___s_completedTask_36; }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 ** get_address_of_s_completedTask_36() { return &___s_completedTask_36; }
	inline void set_s_completedTask_36(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * value)
	{
		___s_completedTask_36 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_completedTask_36), (void*)value);
	}

	inline static int32_t get_offset_of_s_IsExceptionObservedByParentPredicate_37() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_IsExceptionObservedByParentPredicate_37)); }
	inline Predicate_1_tC0DBBC8498BD1EE6ABFFAA5628024105FA7D11BD * get_s_IsExceptionObservedByParentPredicate_37() const { return ___s_IsExceptionObservedByParentPredicate_37; }
	inline Predicate_1_tC0DBBC8498BD1EE6ABFFAA5628024105FA7D11BD ** get_address_of_s_IsExceptionObservedByParentPredicate_37() { return &___s_IsExceptionObservedByParentPredicate_37; }
	inline void set_s_IsExceptionObservedByParentPredicate_37(Predicate_1_tC0DBBC8498BD1EE6ABFFAA5628024105FA7D11BD * value)
	{
		___s_IsExceptionObservedByParentPredicate_37 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_IsExceptionObservedByParentPredicate_37), (void*)value);
	}

	inline static int32_t get_offset_of_s_ecCallback_38() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_ecCallback_38)); }
	inline ContextCallback_t93707E0430F4FF3E15E1FB5A4844BE89C657AE8B * get_s_ecCallback_38() const { return ___s_ecCallback_38; }
	inline ContextCallback_t93707E0430F4FF3E15E1FB5A4844BE89C657AE8B ** get_address_of_s_ecCallback_38() { return &___s_ecCallback_38; }
	inline void set_s_ecCallback_38(ContextCallback_t93707E0430F4FF3E15E1FB5A4844BE89C657AE8B * value)
	{
		___s_ecCallback_38 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_ecCallback_38), (void*)value);
	}

	inline static int32_t get_offset_of_s_IsTaskContinuationNullPredicate_39() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_StaticFields, ___s_IsTaskContinuationNullPredicate_39)); }
	inline Predicate_1_t5C96B81B31A697B11C4C3767E3298773AF25DFEB * get_s_IsTaskContinuationNullPredicate_39() const { return ___s_IsTaskContinuationNullPredicate_39; }
	inline Predicate_1_t5C96B81B31A697B11C4C3767E3298773AF25DFEB ** get_address_of_s_IsTaskContinuationNullPredicate_39() { return &___s_IsTaskContinuationNullPredicate_39; }
	inline void set_s_IsTaskContinuationNullPredicate_39(Predicate_1_t5C96B81B31A697B11C4C3767E3298773AF25DFEB * value)
	{
		___s_IsTaskContinuationNullPredicate_39 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_IsTaskContinuationNullPredicate_39), (void*)value);
	}
};

struct Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_ThreadStaticFields
{
public:
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::t_currentTask
	Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ___t_currentTask_0;
	// System.Threading.Tasks.StackGuard System.Threading.Tasks.Task::t_stackGuard
	StackGuard_t88E1EE4741AD02CA5FEA04A4EB2CC70F230E0E6D * ___t_stackGuard_1;

public:
	inline static int32_t get_offset_of_t_currentTask_0() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_ThreadStaticFields, ___t_currentTask_0)); }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * get_t_currentTask_0() const { return ___t_currentTask_0; }
	inline Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 ** get_address_of_t_currentTask_0() { return &___t_currentTask_0; }
	inline void set_t_currentTask_0(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * value)
	{
		___t_currentTask_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___t_currentTask_0), (void*)value);
	}

	inline static int32_t get_offset_of_t_stackGuard_1() { return static_cast<int32_t>(offsetof(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_ThreadStaticFields, ___t_stackGuard_1)); }
	inline StackGuard_t88E1EE4741AD02CA5FEA04A4EB2CC70F230E0E6D * get_t_stackGuard_1() const { return ___t_stackGuard_1; }
	inline StackGuard_t88E1EE4741AD02CA5FEA04A4EB2CC70F230E0E6D ** get_address_of_t_stackGuard_1() { return &___t_stackGuard_1; }
	inline void set_t_stackGuard_1(StackGuard_t88E1EE4741AD02CA5FEA04A4EB2CC70F230E0E6D * value)
	{
		___t_stackGuard_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___t_stackGuard_1), (void*)value);
	}
};


// System.UriFormat
struct UriFormat_t25C936463BDE737B16A8EC3DA05091FC31F1A71F 
{
public:
	// System.Int32 System.UriFormat::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(UriFormat_t25C936463BDE737B16A8EC3DA05091FC31F1A71F, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.UriIdnScope
struct UriIdnScope_tBA22B992BA582F68F2B98CDEBCB24299F249DE4D 
{
public:
	// System.Int32 System.UriIdnScope::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(UriIdnScope_tBA22B992BA582F68F2B98CDEBCB24299F249DE4D, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.UriKind
struct UriKind_tFC16ACC1842283AAE2C7F50C9C70EFBF6550B3FC 
{
public:
	// System.Int32 System.UriKind::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(UriKind_tFC16ACC1842283AAE2C7F50C9C70EFBF6550B3FC, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Net.WebSockets.WebSocketCloseStatus
struct WebSocketCloseStatus_t3F80BE84F62E6E4BF4A1BE486A6123B4C216EE71 
{
public:
	// System.Int32 System.Net.WebSockets.WebSocketCloseStatus::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(WebSocketCloseStatus_t3F80BE84F62E6E4BF4A1BE486A6123B4C216EE71, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Net.WebSockets.WebSocketMessageType
struct WebSocketMessageType_tF7042A3143AD0252FC984BD22ADA17B64B727D7D 
{
public:
	// System.Int32 System.Net.WebSockets.WebSocketMessageType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(WebSocketMessageType_tF7042A3143AD0252FC984BD22ADA17B64B727D7D, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// libx.Updater/Step
struct Step_t808014FA0DA52771CBF5A03788C882B439A53A93 
{
public:
	// System.Int32 libx.Updater/Step::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Step_t808014FA0DA52771CBF5A03788C882B439A53A93, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Uri/Flags
struct Flags_t72C622DF5C3ED762F55AB36EC2CCDDF3AF56B8D4 
{
public:
	// System.UInt64 System.Uri/Flags::value__
	uint64_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Flags_t72C622DF5C3ED762F55AB36EC2CCDDF3AF56B8D4, ___value___2)); }
	inline uint64_t get_value___2() const { return ___value___2; }
	inline uint64_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint64_t value)
	{
		___value___2 = value;
	}
};


// ET.WChannel/<ConnectAsync>d__13
struct U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA 
{
public:
	// System.Int32 ET.WChannel/<ConnectAsync>d__13::<>1__state
	int32_t ___U3CU3E1__state_0;
	// ET.ETAsyncTaskMethodBuilder ET.WChannel/<ConnectAsync>d__13::<>t__builder
	ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  ___U3CU3Et__builder_1;
	// ET.WChannel ET.WChannel/<ConnectAsync>d__13::<>4__this
	WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * ___U3CU3E4__this_2;
	// System.String ET.WChannel/<ConnectAsync>d__13::url
	String_t* ___url_3;
	// System.Runtime.CompilerServices.TaskAwaiter ET.WChannel/<ConnectAsync>d__13::<>u__1
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  ___U3CU3Eu__1_4;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3Et__builder_1() { return static_cast<int32_t>(offsetof(U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA, ___U3CU3Et__builder_1)); }
	inline ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  get_U3CU3Et__builder_1() const { return ___U3CU3Et__builder_1; }
	inline ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * get_address_of_U3CU3Et__builder_1() { return &___U3CU3Et__builder_1; }
	inline void set_U3CU3Et__builder_1(ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  value)
	{
		___U3CU3Et__builder_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Et__builder_1))->___tcs_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_2() { return static_cast<int32_t>(offsetof(U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA, ___U3CU3E4__this_2)); }
	inline WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * get_U3CU3E4__this_2() const { return ___U3CU3E4__this_2; }
	inline WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 ** get_address_of_U3CU3E4__this_2() { return &___U3CU3E4__this_2; }
	inline void set_U3CU3E4__this_2(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * value)
	{
		___U3CU3E4__this_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_2), (void*)value);
	}

	inline static int32_t get_offset_of_url_3() { return static_cast<int32_t>(offsetof(U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA, ___url_3)); }
	inline String_t* get_url_3() const { return ___url_3; }
	inline String_t** get_address_of_url_3() { return &___url_3; }
	inline void set_url_3(String_t* value)
	{
		___url_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___url_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3Eu__1_4() { return static_cast<int32_t>(offsetof(U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA, ___U3CU3Eu__1_4)); }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  get_U3CU3Eu__1_4() const { return ___U3CU3Eu__1_4; }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * get_address_of_U3CU3Eu__1_4() { return &___U3CU3Eu__1_4; }
	inline void set_U3CU3Eu__1_4(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  value)
	{
		___U3CU3Eu__1_4 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Eu__1_4))->___m_task_0), (void*)NULL);
	}
};


// ET.WChannel/<StartRecv>d__17
struct U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B 
{
public:
	// System.Int32 ET.WChannel/<StartRecv>d__17::<>1__state
	int32_t ___U3CU3E1__state_0;
	// ET.ETAsyncTaskMethodBuilder ET.WChannel/<StartRecv>d__17::<>t__builder
	ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  ___U3CU3Et__builder_1;
	// ET.WChannel ET.WChannel/<StartRecv>d__17::<>4__this
	WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * ___U3CU3E4__this_2;
	// System.Int32 ET.WChannel/<StartRecv>d__17::<receiveCount>5__2
	int32_t ___U3CreceiveCountU3E5__2_3;
	// System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.WebSocketReceiveResult> ET.WChannel/<StartRecv>d__17::<>u__1
	TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  ___U3CU3Eu__1_4;
	// System.Runtime.CompilerServices.TaskAwaiter ET.WChannel/<StartRecv>d__17::<>u__2
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  ___U3CU3Eu__2_5;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3Et__builder_1() { return static_cast<int32_t>(offsetof(U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B, ___U3CU3Et__builder_1)); }
	inline ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  get_U3CU3Et__builder_1() const { return ___U3CU3Et__builder_1; }
	inline ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * get_address_of_U3CU3Et__builder_1() { return &___U3CU3Et__builder_1; }
	inline void set_U3CU3Et__builder_1(ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  value)
	{
		___U3CU3Et__builder_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Et__builder_1))->___tcs_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_2() { return static_cast<int32_t>(offsetof(U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B, ___U3CU3E4__this_2)); }
	inline WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * get_U3CU3E4__this_2() const { return ___U3CU3E4__this_2; }
	inline WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 ** get_address_of_U3CU3E4__this_2() { return &___U3CU3E4__this_2; }
	inline void set_U3CU3E4__this_2(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * value)
	{
		___U3CU3E4__this_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CreceiveCountU3E5__2_3() { return static_cast<int32_t>(offsetof(U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B, ___U3CreceiveCountU3E5__2_3)); }
	inline int32_t get_U3CreceiveCountU3E5__2_3() const { return ___U3CreceiveCountU3E5__2_3; }
	inline int32_t* get_address_of_U3CreceiveCountU3E5__2_3() { return &___U3CreceiveCountU3E5__2_3; }
	inline void set_U3CreceiveCountU3E5__2_3(int32_t value)
	{
		___U3CreceiveCountU3E5__2_3 = value;
	}

	inline static int32_t get_offset_of_U3CU3Eu__1_4() { return static_cast<int32_t>(offsetof(U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B, ___U3CU3Eu__1_4)); }
	inline TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  get_U3CU3Eu__1_4() const { return ___U3CU3Eu__1_4; }
	inline TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 * get_address_of_U3CU3Eu__1_4() { return &___U3CU3Eu__1_4; }
	inline void set_U3CU3Eu__1_4(TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  value)
	{
		___U3CU3Eu__1_4 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Eu__1_4))->___m_task_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_U3CU3Eu__2_5() { return static_cast<int32_t>(offsetof(U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B, ___U3CU3Eu__2_5)); }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  get_U3CU3Eu__2_5() const { return ___U3CU3Eu__2_5; }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * get_address_of_U3CU3Eu__2_5() { return &___U3CU3Eu__2_5; }
	inline void set_U3CU3Eu__2_5(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  value)
	{
		___U3CU3Eu__2_5 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Eu__2_5))->___m_task_0), (void*)NULL);
	}
};


// ET.WChannel/<StartSend>d__15
struct U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 
{
public:
	// System.Int32 ET.WChannel/<StartSend>d__15::<>1__state
	int32_t ___U3CU3E1__state_0;
	// ET.ETAsyncTaskMethodBuilder ET.WChannel/<StartSend>d__15::<>t__builder
	ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  ___U3CU3Et__builder_1;
	// ET.WChannel ET.WChannel/<StartSend>d__15::<>4__this
	WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * ___U3CU3E4__this_2;
	// System.Runtime.CompilerServices.TaskAwaiter ET.WChannel/<StartSend>d__15::<>u__1
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  ___U3CU3Eu__1_3;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3Et__builder_1() { return static_cast<int32_t>(offsetof(U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162, ___U3CU3Et__builder_1)); }
	inline ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  get_U3CU3Et__builder_1() const { return ___U3CU3Et__builder_1; }
	inline ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * get_address_of_U3CU3Et__builder_1() { return &___U3CU3Et__builder_1; }
	inline void set_U3CU3Et__builder_1(ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  value)
	{
		___U3CU3Et__builder_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Et__builder_1))->___tcs_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_2() { return static_cast<int32_t>(offsetof(U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162, ___U3CU3E4__this_2)); }
	inline WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * get_U3CU3E4__this_2() const { return ___U3CU3E4__this_2; }
	inline WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 ** get_address_of_U3CU3E4__this_2() { return &___U3CU3E4__this_2; }
	inline void set_U3CU3E4__this_2(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * value)
	{
		___U3CU3E4__this_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3Eu__1_3() { return static_cast<int32_t>(offsetof(U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162, ___U3CU3Eu__1_3)); }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  get_U3CU3Eu__1_3() const { return ___U3CU3Eu__1_3; }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * get_address_of_U3CU3Eu__1_3() { return &___U3CU3Eu__1_3; }
	inline void set_U3CU3Eu__1_3(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  value)
	{
		___U3CU3Eu__1_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Eu__1_3))->___m_task_0), (void*)NULL);
	}
};


// ET.WService/<StartAccept>d__12
struct U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE 
{
public:
	// System.Int32 ET.WService/<StartAccept>d__12::<>1__state
	int32_t ___U3CU3E1__state_0;
	// ET.ETAsyncTaskMethodBuilder ET.WService/<StartAccept>d__12::<>t__builder
	ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  ___U3CU3Et__builder_1;
	// System.Collections.Generic.IEnumerable`1<System.String> ET.WService/<StartAccept>d__12::prefixs
	RuntimeObject* ___prefixs_2;
	// ET.WService ET.WService/<StartAccept>d__12::<>4__this
	WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * ___U3CU3E4__this_3;
	// System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.HttpListenerContext> ET.WService/<StartAccept>d__12::<>u__1
	TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  ___U3CU3Eu__1_4;
	// System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.HttpListenerWebSocketContext> ET.WService/<StartAccept>d__12::<>u__2
	TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  ___U3CU3Eu__2_5;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3Et__builder_1() { return static_cast<int32_t>(offsetof(U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE, ___U3CU3Et__builder_1)); }
	inline ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  get_U3CU3Et__builder_1() const { return ___U3CU3Et__builder_1; }
	inline ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * get_address_of_U3CU3Et__builder_1() { return &___U3CU3Et__builder_1; }
	inline void set_U3CU3Et__builder_1(ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F  value)
	{
		___U3CU3Et__builder_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Et__builder_1))->___tcs_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_prefixs_2() { return static_cast<int32_t>(offsetof(U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE, ___prefixs_2)); }
	inline RuntimeObject* get_prefixs_2() const { return ___prefixs_2; }
	inline RuntimeObject** get_address_of_prefixs_2() { return &___prefixs_2; }
	inline void set_prefixs_2(RuntimeObject* value)
	{
		___prefixs_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___prefixs_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_3() { return static_cast<int32_t>(offsetof(U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE, ___U3CU3E4__this_3)); }
	inline WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * get_U3CU3E4__this_3() const { return ___U3CU3E4__this_3; }
	inline WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 ** get_address_of_U3CU3E4__this_3() { return &___U3CU3E4__this_3; }
	inline void set_U3CU3E4__this_3(WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * value)
	{
		___U3CU3E4__this_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3Eu__1_4() { return static_cast<int32_t>(offsetof(U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE, ___U3CU3Eu__1_4)); }
	inline TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  get_U3CU3Eu__1_4() const { return ___U3CU3Eu__1_4; }
	inline TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 * get_address_of_U3CU3Eu__1_4() { return &___U3CU3Eu__1_4; }
	inline void set_U3CU3Eu__1_4(TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  value)
	{
		___U3CU3Eu__1_4 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Eu__1_4))->___m_task_0), (void*)NULL);
	}

	inline static int32_t get_offset_of_U3CU3Eu__2_5() { return static_cast<int32_t>(offsetof(U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE, ___U3CU3Eu__2_5)); }
	inline TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  get_U3CU3Eu__2_5() const { return ___U3CU3Eu__2_5; }
	inline TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD * get_address_of_U3CU3Eu__2_5() { return &___U3CU3Eu__2_5; }
	inline void set_U3CU3Eu__2_5(TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  value)
	{
		___U3CU3Eu__2_5 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Eu__2_5))->___m_task_0), (void*)NULL);
	}
};


// System.Nullable`1<System.Net.WebSockets.WebSocketCloseStatus>
struct Nullable_1_tEEF07CE805E86A33961C7C0AE095FA4A628605C6 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_tEEF07CE805E86A33961C7C0AE095FA4A628605C6, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_tEEF07CE805E86A33961C7C0AE095FA4A628605C6, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Threading.Tasks.Task`1<System.Net.HttpListenerContext>
struct Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33  : public Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60
{
public:
	// TResult System.Threading.Tasks.Task`1::m_result
	HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117 * ___m_result_40;

public:
	inline static int32_t get_offset_of_m_result_40() { return static_cast<int32_t>(offsetof(Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33, ___m_result_40)); }
	inline HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117 * get_m_result_40() const { return ___m_result_40; }
	inline HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117 ** get_address_of_m_result_40() { return &___m_result_40; }
	inline void set_m_result_40(HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117 * value)
	{
		___m_result_40 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_result_40), (void*)value);
	}
};

struct Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33_StaticFields
{
public:
	// System.Threading.Tasks.TaskFactory`1<TResult> System.Threading.Tasks.Task`1::s_Factory
	TaskFactory_1_t5E5A6EA81864D954CD634E63E7679B54C114A514 * ___s_Factory_41;
	// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<TResult>> System.Threading.Tasks.Task`1::TaskWhenAnyCast
	Func_2_tD7772F8C5D4C5928DD22254477694C7ED8B2A10A * ___TaskWhenAnyCast_42;

public:
	inline static int32_t get_offset_of_s_Factory_41() { return static_cast<int32_t>(offsetof(Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33_StaticFields, ___s_Factory_41)); }
	inline TaskFactory_1_t5E5A6EA81864D954CD634E63E7679B54C114A514 * get_s_Factory_41() const { return ___s_Factory_41; }
	inline TaskFactory_1_t5E5A6EA81864D954CD634E63E7679B54C114A514 ** get_address_of_s_Factory_41() { return &___s_Factory_41; }
	inline void set_s_Factory_41(TaskFactory_1_t5E5A6EA81864D954CD634E63E7679B54C114A514 * value)
	{
		___s_Factory_41 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Factory_41), (void*)value);
	}

	inline static int32_t get_offset_of_TaskWhenAnyCast_42() { return static_cast<int32_t>(offsetof(Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33_StaticFields, ___TaskWhenAnyCast_42)); }
	inline Func_2_tD7772F8C5D4C5928DD22254477694C7ED8B2A10A * get_TaskWhenAnyCast_42() const { return ___TaskWhenAnyCast_42; }
	inline Func_2_tD7772F8C5D4C5928DD22254477694C7ED8B2A10A ** get_address_of_TaskWhenAnyCast_42() { return &___TaskWhenAnyCast_42; }
	inline void set_TaskWhenAnyCast_42(Func_2_tD7772F8C5D4C5928DD22254477694C7ED8B2A10A * value)
	{
		___TaskWhenAnyCast_42 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TaskWhenAnyCast_42), (void*)value);
	}
};


// System.Threading.Tasks.Task`1<System.Net.WebSockets.HttpListenerWebSocketContext>
struct Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC  : public Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60
{
public:
	// TResult System.Threading.Tasks.Task`1::m_result
	HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * ___m_result_40;

public:
	inline static int32_t get_offset_of_m_result_40() { return static_cast<int32_t>(offsetof(Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC, ___m_result_40)); }
	inline HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * get_m_result_40() const { return ___m_result_40; }
	inline HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 ** get_address_of_m_result_40() { return &___m_result_40; }
	inline void set_m_result_40(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * value)
	{
		___m_result_40 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_result_40), (void*)value);
	}
};

struct Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC_StaticFields
{
public:
	// System.Threading.Tasks.TaskFactory`1<TResult> System.Threading.Tasks.Task`1::s_Factory
	TaskFactory_1_tC295FDAAC14E306B1EF6D6D848D146F29521D4F5 * ___s_Factory_41;
	// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<TResult>> System.Threading.Tasks.Task`1::TaskWhenAnyCast
	Func_2_t8936B820B2FAA2912BC66CEF081462D70A778FA7 * ___TaskWhenAnyCast_42;

public:
	inline static int32_t get_offset_of_s_Factory_41() { return static_cast<int32_t>(offsetof(Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC_StaticFields, ___s_Factory_41)); }
	inline TaskFactory_1_tC295FDAAC14E306B1EF6D6D848D146F29521D4F5 * get_s_Factory_41() const { return ___s_Factory_41; }
	inline TaskFactory_1_tC295FDAAC14E306B1EF6D6D848D146F29521D4F5 ** get_address_of_s_Factory_41() { return &___s_Factory_41; }
	inline void set_s_Factory_41(TaskFactory_1_tC295FDAAC14E306B1EF6D6D848D146F29521D4F5 * value)
	{
		___s_Factory_41 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Factory_41), (void*)value);
	}

	inline static int32_t get_offset_of_TaskWhenAnyCast_42() { return static_cast<int32_t>(offsetof(Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC_StaticFields, ___TaskWhenAnyCast_42)); }
	inline Func_2_t8936B820B2FAA2912BC66CEF081462D70A778FA7 * get_TaskWhenAnyCast_42() const { return ___TaskWhenAnyCast_42; }
	inline Func_2_t8936B820B2FAA2912BC66CEF081462D70A778FA7 ** get_address_of_TaskWhenAnyCast_42() { return &___TaskWhenAnyCast_42; }
	inline void set_TaskWhenAnyCast_42(Func_2_t8936B820B2FAA2912BC66CEF081462D70A778FA7 * value)
	{
		___TaskWhenAnyCast_42 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TaskWhenAnyCast_42), (void*)value);
	}
};


// System.Threading.Tasks.Task`1<System.Net.WebSockets.WebSocketReceiveResult>
struct Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E  : public Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60
{
public:
	// TResult System.Threading.Tasks.Task`1::m_result
	WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * ___m_result_40;

public:
	inline static int32_t get_offset_of_m_result_40() { return static_cast<int32_t>(offsetof(Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E, ___m_result_40)); }
	inline WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * get_m_result_40() const { return ___m_result_40; }
	inline WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 ** get_address_of_m_result_40() { return &___m_result_40; }
	inline void set_m_result_40(WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * value)
	{
		___m_result_40 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_result_40), (void*)value);
	}
};

struct Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E_StaticFields
{
public:
	// System.Threading.Tasks.TaskFactory`1<TResult> System.Threading.Tasks.Task`1::s_Factory
	TaskFactory_1_tC063EA52EE4C2F5600912DE4F3612E7BCD1A2095 * ___s_Factory_41;
	// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<TResult>> System.Threading.Tasks.Task`1::TaskWhenAnyCast
	Func_2_t3E70501828E336A95A943FA3F6EC4B1DB7736B3E * ___TaskWhenAnyCast_42;

public:
	inline static int32_t get_offset_of_s_Factory_41() { return static_cast<int32_t>(offsetof(Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E_StaticFields, ___s_Factory_41)); }
	inline TaskFactory_1_tC063EA52EE4C2F5600912DE4F3612E7BCD1A2095 * get_s_Factory_41() const { return ___s_Factory_41; }
	inline TaskFactory_1_tC063EA52EE4C2F5600912DE4F3612E7BCD1A2095 ** get_address_of_s_Factory_41() { return &___s_Factory_41; }
	inline void set_s_Factory_41(TaskFactory_1_tC063EA52EE4C2F5600912DE4F3612E7BCD1A2095 * value)
	{
		___s_Factory_41 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Factory_41), (void*)value);
	}

	inline static int32_t get_offset_of_TaskWhenAnyCast_42() { return static_cast<int32_t>(offsetof(Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E_StaticFields, ___TaskWhenAnyCast_42)); }
	inline Func_2_t3E70501828E336A95A943FA3F6EC4B1DB7736B3E * get_TaskWhenAnyCast_42() const { return ___TaskWhenAnyCast_42; }
	inline Func_2_t3E70501828E336A95A943FA3F6EC4B1DB7736B3E ** get_address_of_TaskWhenAnyCast_42() { return &___TaskWhenAnyCast_42; }
	inline void set_TaskWhenAnyCast_42(Func_2_t3E70501828E336A95A943FA3F6EC4B1DB7736B3E * value)
	{
		___TaskWhenAnyCast_42 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TaskWhenAnyCast_42), (void*)value);
	}
};


// ET.AChannel
struct AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432  : public RuntimeObject
{
public:
	// System.Int64 ET.AChannel::Id
	int64_t ___Id_0;
	// ET.ChannelType ET.AChannel::<ChannelType>k__BackingField
	int32_t ___U3CChannelTypeU3Ek__BackingField_1;
	// System.Int32 ET.AChannel::<Error>k__BackingField
	int32_t ___U3CErrorU3Ek__BackingField_2;
	// System.Net.IPEndPoint ET.AChannel::<RemoteAddress>k__BackingField
	IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * ___U3CRemoteAddressU3Ek__BackingField_3;

public:
	inline static int32_t get_offset_of_Id_0() { return static_cast<int32_t>(offsetof(AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432, ___Id_0)); }
	inline int64_t get_Id_0() const { return ___Id_0; }
	inline int64_t* get_address_of_Id_0() { return &___Id_0; }
	inline void set_Id_0(int64_t value)
	{
		___Id_0 = value;
	}

	inline static int32_t get_offset_of_U3CChannelTypeU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432, ___U3CChannelTypeU3Ek__BackingField_1)); }
	inline int32_t get_U3CChannelTypeU3Ek__BackingField_1() const { return ___U3CChannelTypeU3Ek__BackingField_1; }
	inline int32_t* get_address_of_U3CChannelTypeU3Ek__BackingField_1() { return &___U3CChannelTypeU3Ek__BackingField_1; }
	inline void set_U3CChannelTypeU3Ek__BackingField_1(int32_t value)
	{
		___U3CChannelTypeU3Ek__BackingField_1 = value;
	}

	inline static int32_t get_offset_of_U3CErrorU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432, ___U3CErrorU3Ek__BackingField_2)); }
	inline int32_t get_U3CErrorU3Ek__BackingField_2() const { return ___U3CErrorU3Ek__BackingField_2; }
	inline int32_t* get_address_of_U3CErrorU3Ek__BackingField_2() { return &___U3CErrorU3Ek__BackingField_2; }
	inline void set_U3CErrorU3Ek__BackingField_2(int32_t value)
	{
		___U3CErrorU3Ek__BackingField_2 = value;
	}

	inline static int32_t get_offset_of_U3CRemoteAddressU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432, ___U3CRemoteAddressU3Ek__BackingField_3)); }
	inline IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * get_U3CRemoteAddressU3Ek__BackingField_3() const { return ___U3CRemoteAddressU3Ek__BackingField_3; }
	inline IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E ** get_address_of_U3CRemoteAddressU3Ek__BackingField_3() { return &___U3CRemoteAddressU3Ek__BackingField_3; }
	inline void set_U3CRemoteAddressU3Ek__BackingField_3(IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * value)
	{
		___U3CRemoteAddressU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CRemoteAddressU3Ek__BackingField_3), (void*)value);
	}
};


// ET.AService
struct AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B  : public RuntimeObject
{
public:
	// ET.ServiceType ET.AService::<ServiceType>k__BackingField
	int32_t ___U3CServiceTypeU3Ek__BackingField_0;
	// ET.ThreadSynchronizationContext ET.AService::ThreadSynchronizationContext
	ThreadSynchronizationContext_tF420C4E811585DBD12B49A48FCD46C8F6EBE208C * ___ThreadSynchronizationContext_1;
	// System.Int64 ET.AService::connectIdGenerater
	int64_t ___connectIdGenerater_2;
	// System.Int64 ET.AService::acceptIdGenerater
	int64_t ___acceptIdGenerater_3;
	// System.Action`2<System.Int64,System.Net.IPEndPoint> ET.AService::AcceptCallback
	Action_2_t9750FBDA93C54A068C92A369CAC15F24DE158260 * ___AcceptCallback_4;
	// System.Action`2<System.Int64,System.Int32> ET.AService::ErrorCallback
	Action_2_t2ADD49D0CF846FB88D1900B8895B44BFB673FF0F * ___ErrorCallback_5;
	// System.Action`2<System.Int64,System.IO.MemoryStream> ET.AService::ReadCallback
	Action_2_tC2DAC15FF34E77EADA91D6F573A5B82C8767C79A * ___ReadCallback_6;

public:
	inline static int32_t get_offset_of_U3CServiceTypeU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B, ___U3CServiceTypeU3Ek__BackingField_0)); }
	inline int32_t get_U3CServiceTypeU3Ek__BackingField_0() const { return ___U3CServiceTypeU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3CServiceTypeU3Ek__BackingField_0() { return &___U3CServiceTypeU3Ek__BackingField_0; }
	inline void set_U3CServiceTypeU3Ek__BackingField_0(int32_t value)
	{
		___U3CServiceTypeU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_ThreadSynchronizationContext_1() { return static_cast<int32_t>(offsetof(AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B, ___ThreadSynchronizationContext_1)); }
	inline ThreadSynchronizationContext_tF420C4E811585DBD12B49A48FCD46C8F6EBE208C * get_ThreadSynchronizationContext_1() const { return ___ThreadSynchronizationContext_1; }
	inline ThreadSynchronizationContext_tF420C4E811585DBD12B49A48FCD46C8F6EBE208C ** get_address_of_ThreadSynchronizationContext_1() { return &___ThreadSynchronizationContext_1; }
	inline void set_ThreadSynchronizationContext_1(ThreadSynchronizationContext_tF420C4E811585DBD12B49A48FCD46C8F6EBE208C * value)
	{
		___ThreadSynchronizationContext_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ThreadSynchronizationContext_1), (void*)value);
	}

	inline static int32_t get_offset_of_connectIdGenerater_2() { return static_cast<int32_t>(offsetof(AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B, ___connectIdGenerater_2)); }
	inline int64_t get_connectIdGenerater_2() const { return ___connectIdGenerater_2; }
	inline int64_t* get_address_of_connectIdGenerater_2() { return &___connectIdGenerater_2; }
	inline void set_connectIdGenerater_2(int64_t value)
	{
		___connectIdGenerater_2 = value;
	}

	inline static int32_t get_offset_of_acceptIdGenerater_3() { return static_cast<int32_t>(offsetof(AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B, ___acceptIdGenerater_3)); }
	inline int64_t get_acceptIdGenerater_3() const { return ___acceptIdGenerater_3; }
	inline int64_t* get_address_of_acceptIdGenerater_3() { return &___acceptIdGenerater_3; }
	inline void set_acceptIdGenerater_3(int64_t value)
	{
		___acceptIdGenerater_3 = value;
	}

	inline static int32_t get_offset_of_AcceptCallback_4() { return static_cast<int32_t>(offsetof(AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B, ___AcceptCallback_4)); }
	inline Action_2_t9750FBDA93C54A068C92A369CAC15F24DE158260 * get_AcceptCallback_4() const { return ___AcceptCallback_4; }
	inline Action_2_t9750FBDA93C54A068C92A369CAC15F24DE158260 ** get_address_of_AcceptCallback_4() { return &___AcceptCallback_4; }
	inline void set_AcceptCallback_4(Action_2_t9750FBDA93C54A068C92A369CAC15F24DE158260 * value)
	{
		___AcceptCallback_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___AcceptCallback_4), (void*)value);
	}

	inline static int32_t get_offset_of_ErrorCallback_5() { return static_cast<int32_t>(offsetof(AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B, ___ErrorCallback_5)); }
	inline Action_2_t2ADD49D0CF846FB88D1900B8895B44BFB673FF0F * get_ErrorCallback_5() const { return ___ErrorCallback_5; }
	inline Action_2_t2ADD49D0CF846FB88D1900B8895B44BFB673FF0F ** get_address_of_ErrorCallback_5() { return &___ErrorCallback_5; }
	inline void set_ErrorCallback_5(Action_2_t2ADD49D0CF846FB88D1900B8895B44BFB673FF0F * value)
	{
		___ErrorCallback_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ErrorCallback_5), (void*)value);
	}

	inline static int32_t get_offset_of_ReadCallback_6() { return static_cast<int32_t>(offsetof(AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B, ___ReadCallback_6)); }
	inline Action_2_tC2DAC15FF34E77EADA91D6F573A5B82C8767C79A * get_ReadCallback_6() const { return ___ReadCallback_6; }
	inline Action_2_tC2DAC15FF34E77EADA91D6F573A5B82C8767C79A ** get_address_of_ReadCallback_6() { return &___ReadCallback_6; }
	inline void set_ReadCallback_6(Action_2_tC2DAC15FF34E77EADA91D6F573A5B82C8767C79A * value)
	{
		___ReadCallback_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ReadCallback_6), (void*)value);
	}
};


// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// ET.ETTask
struct ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF  : public RuntimeObject
{
public:
	// System.Boolean ET.ETTask::fromPool
	bool ___fromPool_2;
	// ET.AwaiterStatus ET.ETTask::state
	uint8_t ___state_3;
	// System.Object ET.ETTask::callback
	RuntimeObject * ___callback_4;

public:
	inline static int32_t get_offset_of_fromPool_2() { return static_cast<int32_t>(offsetof(ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF, ___fromPool_2)); }
	inline bool get_fromPool_2() const { return ___fromPool_2; }
	inline bool* get_address_of_fromPool_2() { return &___fromPool_2; }
	inline void set_fromPool_2(bool value)
	{
		___fromPool_2 = value;
	}

	inline static int32_t get_offset_of_state_3() { return static_cast<int32_t>(offsetof(ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF, ___state_3)); }
	inline uint8_t get_state_3() const { return ___state_3; }
	inline uint8_t* get_address_of_state_3() { return &___state_3; }
	inline void set_state_3(uint8_t value)
	{
		___state_3 = value;
	}

	inline static int32_t get_offset_of_callback_4() { return static_cast<int32_t>(offsetof(ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF, ___callback_4)); }
	inline RuntimeObject * get_callback_4() const { return ___callback_4; }
	inline RuntimeObject ** get_address_of_callback_4() { return &___callback_4; }
	inline void set_callback_4(RuntimeObject * value)
	{
		___callback_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callback_4), (void*)value);
	}
};

struct ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF_StaticFields
{
public:
	// System.Action`1<System.Exception> ET.ETTask::ExceptionHandler
	Action_1_t34F00247DCE829C59C4C5AAECAE03F05F060DD90 * ___ExceptionHandler_0;
	// System.Collections.Generic.Queue`1<ET.ETTask> ET.ETTask::queue
	Queue_1_tB507071133411FA55FF2315F30B7DE52E9042A80 * ___queue_1;

public:
	inline static int32_t get_offset_of_ExceptionHandler_0() { return static_cast<int32_t>(offsetof(ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF_StaticFields, ___ExceptionHandler_0)); }
	inline Action_1_t34F00247DCE829C59C4C5AAECAE03F05F060DD90 * get_ExceptionHandler_0() const { return ___ExceptionHandler_0; }
	inline Action_1_t34F00247DCE829C59C4C5AAECAE03F05F060DD90 ** get_address_of_ExceptionHandler_0() { return &___ExceptionHandler_0; }
	inline void set_ExceptionHandler_0(Action_1_t34F00247DCE829C59C4C5AAECAE03F05F060DD90 * value)
	{
		___ExceptionHandler_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ExceptionHandler_0), (void*)value);
	}

	inline static int32_t get_offset_of_queue_1() { return static_cast<int32_t>(offsetof(ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF_StaticFields, ___queue_1)); }
	inline Queue_1_tB507071133411FA55FF2315F30B7DE52E9042A80 * get_queue_1() const { return ___queue_1; }
	inline Queue_1_tB507071133411FA55FF2315F30B7DE52E9042A80 ** get_address_of_queue_1() { return &___queue_1; }
	inline void set_queue_1(Queue_1_tB507071133411FA55FF2315F30B7DE52E9042A80 * value)
	{
		___queue_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___queue_1), (void*)value);
	}
};


// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// System.Net.HttpListener
struct HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1  : public RuntimeObject
{
public:
	// Mono.Security.Interface.MonoTlsProvider System.Net.HttpListener::tlsProvider
	MonoTlsProvider_tBE72637BEDBD1516A1BC30D94F7159B7289CF0D7 * ___tlsProvider_0;
	// Mono.Security.Interface.MonoTlsSettings System.Net.HttpListener::tlsSettings
	MonoTlsSettings_tBDF72C906FE6477EFBA9493F7F5CB5ADE2C80E21 * ___tlsSettings_1;
	// System.Security.Cryptography.X509Certificates.X509Certificate System.Net.HttpListener::certificate
	X509Certificate_t6F3E94ED7C8FB33253E4705C76A40144E59F0553 * ___certificate_2;
	// System.Net.AuthenticationSchemes System.Net.HttpListener::auth_schemes
	int32_t ___auth_schemes_3;
	// System.Net.HttpListenerPrefixCollection System.Net.HttpListener::prefixes
	HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283 * ___prefixes_4;
	// System.Net.AuthenticationSchemeSelector System.Net.HttpListener::auth_selector
	AuthenticationSchemeSelector_t9FDFDC832A54C0A0DFBCCFF3A6F9F5FFCABCB6D7 * ___auth_selector_5;
	// System.String System.Net.HttpListener::realm
	String_t* ___realm_6;
	// System.Boolean System.Net.HttpListener::ignore_write_exceptions
	bool ___ignore_write_exceptions_7;
	// System.Boolean System.Net.HttpListener::unsafe_ntlm_auth
	bool ___unsafe_ntlm_auth_8;
	// System.Boolean System.Net.HttpListener::listening
	bool ___listening_9;
	// System.Boolean System.Net.HttpListener::disposed
	bool ___disposed_10;
	// System.Object System.Net.HttpListener::_internalLock
	RuntimeObject * ____internalLock_11;
	// System.Collections.Hashtable System.Net.HttpListener::registry
	Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * ___registry_12;
	// System.Collections.ArrayList System.Net.HttpListener::ctx_queue
	ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * ___ctx_queue_13;
	// System.Collections.ArrayList System.Net.HttpListener::wait_queue
	ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * ___wait_queue_14;
	// System.Collections.Hashtable System.Net.HttpListener::connections
	Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * ___connections_15;
	// System.Net.ServiceNameStore System.Net.HttpListener::defaultServiceNames
	ServiceNameStore_t760B40F6038C931BFDD075828BD6F9181EDB0A17 * ___defaultServiceNames_16;
	// System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy System.Net.HttpListener::extendedProtectionPolicy
	ExtendedProtectionPolicy_tF4E31F8B39C403E6FFF6ADA49B5BE0042121CDCE * ___extendedProtectionPolicy_17;
	// System.Net.HttpListener/ExtendedProtectionSelector System.Net.HttpListener::extendedProtectionSelectorDelegate
	ExtendedProtectionSelector_tD26A07B8EFF1BE64214537F2B6242618D134BAAE * ___extendedProtectionSelectorDelegate_18;

public:
	inline static int32_t get_offset_of_tlsProvider_0() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___tlsProvider_0)); }
	inline MonoTlsProvider_tBE72637BEDBD1516A1BC30D94F7159B7289CF0D7 * get_tlsProvider_0() const { return ___tlsProvider_0; }
	inline MonoTlsProvider_tBE72637BEDBD1516A1BC30D94F7159B7289CF0D7 ** get_address_of_tlsProvider_0() { return &___tlsProvider_0; }
	inline void set_tlsProvider_0(MonoTlsProvider_tBE72637BEDBD1516A1BC30D94F7159B7289CF0D7 * value)
	{
		___tlsProvider_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tlsProvider_0), (void*)value);
	}

	inline static int32_t get_offset_of_tlsSettings_1() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___tlsSettings_1)); }
	inline MonoTlsSettings_tBDF72C906FE6477EFBA9493F7F5CB5ADE2C80E21 * get_tlsSettings_1() const { return ___tlsSettings_1; }
	inline MonoTlsSettings_tBDF72C906FE6477EFBA9493F7F5CB5ADE2C80E21 ** get_address_of_tlsSettings_1() { return &___tlsSettings_1; }
	inline void set_tlsSettings_1(MonoTlsSettings_tBDF72C906FE6477EFBA9493F7F5CB5ADE2C80E21 * value)
	{
		___tlsSettings_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tlsSettings_1), (void*)value);
	}

	inline static int32_t get_offset_of_certificate_2() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___certificate_2)); }
	inline X509Certificate_t6F3E94ED7C8FB33253E4705C76A40144E59F0553 * get_certificate_2() const { return ___certificate_2; }
	inline X509Certificate_t6F3E94ED7C8FB33253E4705C76A40144E59F0553 ** get_address_of_certificate_2() { return &___certificate_2; }
	inline void set_certificate_2(X509Certificate_t6F3E94ED7C8FB33253E4705C76A40144E59F0553 * value)
	{
		___certificate_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___certificate_2), (void*)value);
	}

	inline static int32_t get_offset_of_auth_schemes_3() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___auth_schemes_3)); }
	inline int32_t get_auth_schemes_3() const { return ___auth_schemes_3; }
	inline int32_t* get_address_of_auth_schemes_3() { return &___auth_schemes_3; }
	inline void set_auth_schemes_3(int32_t value)
	{
		___auth_schemes_3 = value;
	}

	inline static int32_t get_offset_of_prefixes_4() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___prefixes_4)); }
	inline HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283 * get_prefixes_4() const { return ___prefixes_4; }
	inline HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283 ** get_address_of_prefixes_4() { return &___prefixes_4; }
	inline void set_prefixes_4(HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283 * value)
	{
		___prefixes_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___prefixes_4), (void*)value);
	}

	inline static int32_t get_offset_of_auth_selector_5() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___auth_selector_5)); }
	inline AuthenticationSchemeSelector_t9FDFDC832A54C0A0DFBCCFF3A6F9F5FFCABCB6D7 * get_auth_selector_5() const { return ___auth_selector_5; }
	inline AuthenticationSchemeSelector_t9FDFDC832A54C0A0DFBCCFF3A6F9F5FFCABCB6D7 ** get_address_of_auth_selector_5() { return &___auth_selector_5; }
	inline void set_auth_selector_5(AuthenticationSchemeSelector_t9FDFDC832A54C0A0DFBCCFF3A6F9F5FFCABCB6D7 * value)
	{
		___auth_selector_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___auth_selector_5), (void*)value);
	}

	inline static int32_t get_offset_of_realm_6() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___realm_6)); }
	inline String_t* get_realm_6() const { return ___realm_6; }
	inline String_t** get_address_of_realm_6() { return &___realm_6; }
	inline void set_realm_6(String_t* value)
	{
		___realm_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___realm_6), (void*)value);
	}

	inline static int32_t get_offset_of_ignore_write_exceptions_7() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___ignore_write_exceptions_7)); }
	inline bool get_ignore_write_exceptions_7() const { return ___ignore_write_exceptions_7; }
	inline bool* get_address_of_ignore_write_exceptions_7() { return &___ignore_write_exceptions_7; }
	inline void set_ignore_write_exceptions_7(bool value)
	{
		___ignore_write_exceptions_7 = value;
	}

	inline static int32_t get_offset_of_unsafe_ntlm_auth_8() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___unsafe_ntlm_auth_8)); }
	inline bool get_unsafe_ntlm_auth_8() const { return ___unsafe_ntlm_auth_8; }
	inline bool* get_address_of_unsafe_ntlm_auth_8() { return &___unsafe_ntlm_auth_8; }
	inline void set_unsafe_ntlm_auth_8(bool value)
	{
		___unsafe_ntlm_auth_8 = value;
	}

	inline static int32_t get_offset_of_listening_9() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___listening_9)); }
	inline bool get_listening_9() const { return ___listening_9; }
	inline bool* get_address_of_listening_9() { return &___listening_9; }
	inline void set_listening_9(bool value)
	{
		___listening_9 = value;
	}

	inline static int32_t get_offset_of_disposed_10() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___disposed_10)); }
	inline bool get_disposed_10() const { return ___disposed_10; }
	inline bool* get_address_of_disposed_10() { return &___disposed_10; }
	inline void set_disposed_10(bool value)
	{
		___disposed_10 = value;
	}

	inline static int32_t get_offset_of__internalLock_11() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ____internalLock_11)); }
	inline RuntimeObject * get__internalLock_11() const { return ____internalLock_11; }
	inline RuntimeObject ** get_address_of__internalLock_11() { return &____internalLock_11; }
	inline void set__internalLock_11(RuntimeObject * value)
	{
		____internalLock_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____internalLock_11), (void*)value);
	}

	inline static int32_t get_offset_of_registry_12() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___registry_12)); }
	inline Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * get_registry_12() const { return ___registry_12; }
	inline Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC ** get_address_of_registry_12() { return &___registry_12; }
	inline void set_registry_12(Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * value)
	{
		___registry_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___registry_12), (void*)value);
	}

	inline static int32_t get_offset_of_ctx_queue_13() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___ctx_queue_13)); }
	inline ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * get_ctx_queue_13() const { return ___ctx_queue_13; }
	inline ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 ** get_address_of_ctx_queue_13() { return &___ctx_queue_13; }
	inline void set_ctx_queue_13(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * value)
	{
		___ctx_queue_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ctx_queue_13), (void*)value);
	}

	inline static int32_t get_offset_of_wait_queue_14() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___wait_queue_14)); }
	inline ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * get_wait_queue_14() const { return ___wait_queue_14; }
	inline ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 ** get_address_of_wait_queue_14() { return &___wait_queue_14; }
	inline void set_wait_queue_14(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * value)
	{
		___wait_queue_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___wait_queue_14), (void*)value);
	}

	inline static int32_t get_offset_of_connections_15() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___connections_15)); }
	inline Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * get_connections_15() const { return ___connections_15; }
	inline Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC ** get_address_of_connections_15() { return &___connections_15; }
	inline void set_connections_15(Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * value)
	{
		___connections_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___connections_15), (void*)value);
	}

	inline static int32_t get_offset_of_defaultServiceNames_16() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___defaultServiceNames_16)); }
	inline ServiceNameStore_t760B40F6038C931BFDD075828BD6F9181EDB0A17 * get_defaultServiceNames_16() const { return ___defaultServiceNames_16; }
	inline ServiceNameStore_t760B40F6038C931BFDD075828BD6F9181EDB0A17 ** get_address_of_defaultServiceNames_16() { return &___defaultServiceNames_16; }
	inline void set_defaultServiceNames_16(ServiceNameStore_t760B40F6038C931BFDD075828BD6F9181EDB0A17 * value)
	{
		___defaultServiceNames_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___defaultServiceNames_16), (void*)value);
	}

	inline static int32_t get_offset_of_extendedProtectionPolicy_17() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___extendedProtectionPolicy_17)); }
	inline ExtendedProtectionPolicy_tF4E31F8B39C403E6FFF6ADA49B5BE0042121CDCE * get_extendedProtectionPolicy_17() const { return ___extendedProtectionPolicy_17; }
	inline ExtendedProtectionPolicy_tF4E31F8B39C403E6FFF6ADA49B5BE0042121CDCE ** get_address_of_extendedProtectionPolicy_17() { return &___extendedProtectionPolicy_17; }
	inline void set_extendedProtectionPolicy_17(ExtendedProtectionPolicy_tF4E31F8B39C403E6FFF6ADA49B5BE0042121CDCE * value)
	{
		___extendedProtectionPolicy_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___extendedProtectionPolicy_17), (void*)value);
	}

	inline static int32_t get_offset_of_extendedProtectionSelectorDelegate_18() { return static_cast<int32_t>(offsetof(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1, ___extendedProtectionSelectorDelegate_18)); }
	inline ExtendedProtectionSelector_tD26A07B8EFF1BE64214537F2B6242618D134BAAE * get_extendedProtectionSelectorDelegate_18() const { return ___extendedProtectionSelectorDelegate_18; }
	inline ExtendedProtectionSelector_tD26A07B8EFF1BE64214537F2B6242618D134BAAE ** get_address_of_extendedProtectionSelectorDelegate_18() { return &___extendedProtectionSelectorDelegate_18; }
	inline void set_extendedProtectionSelectorDelegate_18(ExtendedProtectionSelector_tD26A07B8EFF1BE64214537F2B6242618D134BAAE * value)
	{
		___extendedProtectionSelectorDelegate_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___extendedProtectionSelectorDelegate_18), (void*)value);
	}
};


// UnityEngine.MissingReferenceException
struct MissingReferenceException_t0957F7F403A0B9249CE6AB66FAD46E626F787EE8  : public Exception_t
{
public:

public:
};


// System.SystemException
struct SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62  : public Exception_t
{
public:

public:
};


// System.Uri
struct Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612  : public RuntimeObject
{
public:
	// System.String System.Uri::m_String
	String_t* ___m_String_16;
	// System.String System.Uri::m_originalUnicodeString
	String_t* ___m_originalUnicodeString_17;
	// System.UriParser System.Uri::m_Syntax
	UriParser_t6DEBE5C6CDC3C29C9019CD951C7ECEBD6A5D3E3A * ___m_Syntax_18;
	// System.String System.Uri::m_DnsSafeHost
	String_t* ___m_DnsSafeHost_19;
	// System.Uri/Flags System.Uri::m_Flags
	uint64_t ___m_Flags_20;
	// System.Uri/UriInfo System.Uri::m_Info
	UriInfo_tCB2302A896132D1F70E47C3895FAB9A0F2A6EE45 * ___m_Info_21;
	// System.Boolean System.Uri::m_iriParsing
	bool ___m_iriParsing_22;

public:
	inline static int32_t get_offset_of_m_String_16() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612, ___m_String_16)); }
	inline String_t* get_m_String_16() const { return ___m_String_16; }
	inline String_t** get_address_of_m_String_16() { return &___m_String_16; }
	inline void set_m_String_16(String_t* value)
	{
		___m_String_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_String_16), (void*)value);
	}

	inline static int32_t get_offset_of_m_originalUnicodeString_17() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612, ___m_originalUnicodeString_17)); }
	inline String_t* get_m_originalUnicodeString_17() const { return ___m_originalUnicodeString_17; }
	inline String_t** get_address_of_m_originalUnicodeString_17() { return &___m_originalUnicodeString_17; }
	inline void set_m_originalUnicodeString_17(String_t* value)
	{
		___m_originalUnicodeString_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_originalUnicodeString_17), (void*)value);
	}

	inline static int32_t get_offset_of_m_Syntax_18() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612, ___m_Syntax_18)); }
	inline UriParser_t6DEBE5C6CDC3C29C9019CD951C7ECEBD6A5D3E3A * get_m_Syntax_18() const { return ___m_Syntax_18; }
	inline UriParser_t6DEBE5C6CDC3C29C9019CD951C7ECEBD6A5D3E3A ** get_address_of_m_Syntax_18() { return &___m_Syntax_18; }
	inline void set_m_Syntax_18(UriParser_t6DEBE5C6CDC3C29C9019CD951C7ECEBD6A5D3E3A * value)
	{
		___m_Syntax_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Syntax_18), (void*)value);
	}

	inline static int32_t get_offset_of_m_DnsSafeHost_19() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612, ___m_DnsSafeHost_19)); }
	inline String_t* get_m_DnsSafeHost_19() const { return ___m_DnsSafeHost_19; }
	inline String_t** get_address_of_m_DnsSafeHost_19() { return &___m_DnsSafeHost_19; }
	inline void set_m_DnsSafeHost_19(String_t* value)
	{
		___m_DnsSafeHost_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_DnsSafeHost_19), (void*)value);
	}

	inline static int32_t get_offset_of_m_Flags_20() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612, ___m_Flags_20)); }
	inline uint64_t get_m_Flags_20() const { return ___m_Flags_20; }
	inline uint64_t* get_address_of_m_Flags_20() { return &___m_Flags_20; }
	inline void set_m_Flags_20(uint64_t value)
	{
		___m_Flags_20 = value;
	}

	inline static int32_t get_offset_of_m_Info_21() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612, ___m_Info_21)); }
	inline UriInfo_tCB2302A896132D1F70E47C3895FAB9A0F2A6EE45 * get_m_Info_21() const { return ___m_Info_21; }
	inline UriInfo_tCB2302A896132D1F70E47C3895FAB9A0F2A6EE45 ** get_address_of_m_Info_21() { return &___m_Info_21; }
	inline void set_m_Info_21(UriInfo_tCB2302A896132D1F70E47C3895FAB9A0F2A6EE45 * value)
	{
		___m_Info_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Info_21), (void*)value);
	}

	inline static int32_t get_offset_of_m_iriParsing_22() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612, ___m_iriParsing_22)); }
	inline bool get_m_iriParsing_22() const { return ___m_iriParsing_22; }
	inline bool* get_address_of_m_iriParsing_22() { return &___m_iriParsing_22; }
	inline void set_m_iriParsing_22(bool value)
	{
		___m_iriParsing_22 = value;
	}
};

struct Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields
{
public:
	// System.String System.Uri::UriSchemeFile
	String_t* ___UriSchemeFile_0;
	// System.String System.Uri::UriSchemeFtp
	String_t* ___UriSchemeFtp_1;
	// System.String System.Uri::UriSchemeGopher
	String_t* ___UriSchemeGopher_2;
	// System.String System.Uri::UriSchemeHttp
	String_t* ___UriSchemeHttp_3;
	// System.String System.Uri::UriSchemeHttps
	String_t* ___UriSchemeHttps_4;
	// System.String System.Uri::UriSchemeWs
	String_t* ___UriSchemeWs_5;
	// System.String System.Uri::UriSchemeWss
	String_t* ___UriSchemeWss_6;
	// System.String System.Uri::UriSchemeMailto
	String_t* ___UriSchemeMailto_7;
	// System.String System.Uri::UriSchemeNews
	String_t* ___UriSchemeNews_8;
	// System.String System.Uri::UriSchemeNntp
	String_t* ___UriSchemeNntp_9;
	// System.String System.Uri::UriSchemeNetTcp
	String_t* ___UriSchemeNetTcp_10;
	// System.String System.Uri::UriSchemeNetPipe
	String_t* ___UriSchemeNetPipe_11;
	// System.String System.Uri::SchemeDelimiter
	String_t* ___SchemeDelimiter_12;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_ConfigInitialized
	bool ___s_ConfigInitialized_23;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_ConfigInitializing
	bool ___s_ConfigInitializing_24;
	// System.UriIdnScope modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_IdnScope
	int32_t ___s_IdnScope_25;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_IriParsing
	bool ___s_IriParsing_26;
	// System.Boolean System.Uri::useDotNetRelativeOrAbsolute
	bool ___useDotNetRelativeOrAbsolute_27;
	// System.Boolean System.Uri::IsWindowsFileSystem
	bool ___IsWindowsFileSystem_29;
	// System.Object System.Uri::s_initLock
	RuntimeObject * ___s_initLock_30;
	// System.Char[] System.Uri::HexLowerChars
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___HexLowerChars_34;
	// System.Char[] System.Uri::_WSchars
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ____WSchars_35;

public:
	inline static int32_t get_offset_of_UriSchemeFile_0() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeFile_0)); }
	inline String_t* get_UriSchemeFile_0() const { return ___UriSchemeFile_0; }
	inline String_t** get_address_of_UriSchemeFile_0() { return &___UriSchemeFile_0; }
	inline void set_UriSchemeFile_0(String_t* value)
	{
		___UriSchemeFile_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeFile_0), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeFtp_1() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeFtp_1)); }
	inline String_t* get_UriSchemeFtp_1() const { return ___UriSchemeFtp_1; }
	inline String_t** get_address_of_UriSchemeFtp_1() { return &___UriSchemeFtp_1; }
	inline void set_UriSchemeFtp_1(String_t* value)
	{
		___UriSchemeFtp_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeFtp_1), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeGopher_2() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeGopher_2)); }
	inline String_t* get_UriSchemeGopher_2() const { return ___UriSchemeGopher_2; }
	inline String_t** get_address_of_UriSchemeGopher_2() { return &___UriSchemeGopher_2; }
	inline void set_UriSchemeGopher_2(String_t* value)
	{
		___UriSchemeGopher_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeGopher_2), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeHttp_3() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeHttp_3)); }
	inline String_t* get_UriSchemeHttp_3() const { return ___UriSchemeHttp_3; }
	inline String_t** get_address_of_UriSchemeHttp_3() { return &___UriSchemeHttp_3; }
	inline void set_UriSchemeHttp_3(String_t* value)
	{
		___UriSchemeHttp_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeHttp_3), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeHttps_4() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeHttps_4)); }
	inline String_t* get_UriSchemeHttps_4() const { return ___UriSchemeHttps_4; }
	inline String_t** get_address_of_UriSchemeHttps_4() { return &___UriSchemeHttps_4; }
	inline void set_UriSchemeHttps_4(String_t* value)
	{
		___UriSchemeHttps_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeHttps_4), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeWs_5() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeWs_5)); }
	inline String_t* get_UriSchemeWs_5() const { return ___UriSchemeWs_5; }
	inline String_t** get_address_of_UriSchemeWs_5() { return &___UriSchemeWs_5; }
	inline void set_UriSchemeWs_5(String_t* value)
	{
		___UriSchemeWs_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeWs_5), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeWss_6() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeWss_6)); }
	inline String_t* get_UriSchemeWss_6() const { return ___UriSchemeWss_6; }
	inline String_t** get_address_of_UriSchemeWss_6() { return &___UriSchemeWss_6; }
	inline void set_UriSchemeWss_6(String_t* value)
	{
		___UriSchemeWss_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeWss_6), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeMailto_7() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeMailto_7)); }
	inline String_t* get_UriSchemeMailto_7() const { return ___UriSchemeMailto_7; }
	inline String_t** get_address_of_UriSchemeMailto_7() { return &___UriSchemeMailto_7; }
	inline void set_UriSchemeMailto_7(String_t* value)
	{
		___UriSchemeMailto_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeMailto_7), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeNews_8() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeNews_8)); }
	inline String_t* get_UriSchemeNews_8() const { return ___UriSchemeNews_8; }
	inline String_t** get_address_of_UriSchemeNews_8() { return &___UriSchemeNews_8; }
	inline void set_UriSchemeNews_8(String_t* value)
	{
		___UriSchemeNews_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeNews_8), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeNntp_9() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeNntp_9)); }
	inline String_t* get_UriSchemeNntp_9() const { return ___UriSchemeNntp_9; }
	inline String_t** get_address_of_UriSchemeNntp_9() { return &___UriSchemeNntp_9; }
	inline void set_UriSchemeNntp_9(String_t* value)
	{
		___UriSchemeNntp_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeNntp_9), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeNetTcp_10() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeNetTcp_10)); }
	inline String_t* get_UriSchemeNetTcp_10() const { return ___UriSchemeNetTcp_10; }
	inline String_t** get_address_of_UriSchemeNetTcp_10() { return &___UriSchemeNetTcp_10; }
	inline void set_UriSchemeNetTcp_10(String_t* value)
	{
		___UriSchemeNetTcp_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeNetTcp_10), (void*)value);
	}

	inline static int32_t get_offset_of_UriSchemeNetPipe_11() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___UriSchemeNetPipe_11)); }
	inline String_t* get_UriSchemeNetPipe_11() const { return ___UriSchemeNetPipe_11; }
	inline String_t** get_address_of_UriSchemeNetPipe_11() { return &___UriSchemeNetPipe_11; }
	inline void set_UriSchemeNetPipe_11(String_t* value)
	{
		___UriSchemeNetPipe_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___UriSchemeNetPipe_11), (void*)value);
	}

	inline static int32_t get_offset_of_SchemeDelimiter_12() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___SchemeDelimiter_12)); }
	inline String_t* get_SchemeDelimiter_12() const { return ___SchemeDelimiter_12; }
	inline String_t** get_address_of_SchemeDelimiter_12() { return &___SchemeDelimiter_12; }
	inline void set_SchemeDelimiter_12(String_t* value)
	{
		___SchemeDelimiter_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___SchemeDelimiter_12), (void*)value);
	}

	inline static int32_t get_offset_of_s_ConfigInitialized_23() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___s_ConfigInitialized_23)); }
	inline bool get_s_ConfigInitialized_23() const { return ___s_ConfigInitialized_23; }
	inline bool* get_address_of_s_ConfigInitialized_23() { return &___s_ConfigInitialized_23; }
	inline void set_s_ConfigInitialized_23(bool value)
	{
		___s_ConfigInitialized_23 = value;
	}

	inline static int32_t get_offset_of_s_ConfigInitializing_24() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___s_ConfigInitializing_24)); }
	inline bool get_s_ConfigInitializing_24() const { return ___s_ConfigInitializing_24; }
	inline bool* get_address_of_s_ConfigInitializing_24() { return &___s_ConfigInitializing_24; }
	inline void set_s_ConfigInitializing_24(bool value)
	{
		___s_ConfigInitializing_24 = value;
	}

	inline static int32_t get_offset_of_s_IdnScope_25() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___s_IdnScope_25)); }
	inline int32_t get_s_IdnScope_25() const { return ___s_IdnScope_25; }
	inline int32_t* get_address_of_s_IdnScope_25() { return &___s_IdnScope_25; }
	inline void set_s_IdnScope_25(int32_t value)
	{
		___s_IdnScope_25 = value;
	}

	inline static int32_t get_offset_of_s_IriParsing_26() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___s_IriParsing_26)); }
	inline bool get_s_IriParsing_26() const { return ___s_IriParsing_26; }
	inline bool* get_address_of_s_IriParsing_26() { return &___s_IriParsing_26; }
	inline void set_s_IriParsing_26(bool value)
	{
		___s_IriParsing_26 = value;
	}

	inline static int32_t get_offset_of_useDotNetRelativeOrAbsolute_27() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___useDotNetRelativeOrAbsolute_27)); }
	inline bool get_useDotNetRelativeOrAbsolute_27() const { return ___useDotNetRelativeOrAbsolute_27; }
	inline bool* get_address_of_useDotNetRelativeOrAbsolute_27() { return &___useDotNetRelativeOrAbsolute_27; }
	inline void set_useDotNetRelativeOrAbsolute_27(bool value)
	{
		___useDotNetRelativeOrAbsolute_27 = value;
	}

	inline static int32_t get_offset_of_IsWindowsFileSystem_29() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___IsWindowsFileSystem_29)); }
	inline bool get_IsWindowsFileSystem_29() const { return ___IsWindowsFileSystem_29; }
	inline bool* get_address_of_IsWindowsFileSystem_29() { return &___IsWindowsFileSystem_29; }
	inline void set_IsWindowsFileSystem_29(bool value)
	{
		___IsWindowsFileSystem_29 = value;
	}

	inline static int32_t get_offset_of_s_initLock_30() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___s_initLock_30)); }
	inline RuntimeObject * get_s_initLock_30() const { return ___s_initLock_30; }
	inline RuntimeObject ** get_address_of_s_initLock_30() { return &___s_initLock_30; }
	inline void set_s_initLock_30(RuntimeObject * value)
	{
		___s_initLock_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_initLock_30), (void*)value);
	}

	inline static int32_t get_offset_of_HexLowerChars_34() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ___HexLowerChars_34)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_HexLowerChars_34() const { return ___HexLowerChars_34; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_HexLowerChars_34() { return &___HexLowerChars_34; }
	inline void set_HexLowerChars_34(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___HexLowerChars_34 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___HexLowerChars_34), (void*)value);
	}

	inline static int32_t get_offset_of__WSchars_35() { return static_cast<int32_t>(offsetof(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_StaticFields, ____WSchars_35)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get__WSchars_35() const { return ____WSchars_35; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of__WSchars_35() { return &____WSchars_35; }
	inline void set__WSchars_35(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		____WSchars_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____WSchars_35), (void*)value);
	}
};


// ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18
struct U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D 
{
public:
	// System.Int32 ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Runtime.CompilerServices.AsyncVoidMethodBuilder ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18::<>t__builder
	AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6  ___U3CU3Et__builder_1;
	// ET.MonoBehaviourAdapter/Adaptor ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18::<>4__this
	Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * ___U3CU3E4__this_2;
	// System.Runtime.CompilerServices.TaskAwaiter ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18::<>u__1
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  ___U3CU3Eu__1_3;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3Et__builder_1() { return static_cast<int32_t>(offsetof(U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D, ___U3CU3Et__builder_1)); }
	inline AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6  get_U3CU3Et__builder_1() const { return ___U3CU3Et__builder_1; }
	inline AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * get_address_of_U3CU3Et__builder_1() { return &___U3CU3Et__builder_1; }
	inline void set_U3CU3Et__builder_1(AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6  value)
	{
		___U3CU3Et__builder_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Et__builder_1))->___m_synchronizationContext_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___U3CU3Et__builder_1))->___m_coreState_1))->___m_stateMachine_0), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___U3CU3Et__builder_1))->___m_coreState_1))->___m_defaultContextAction_1), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Et__builder_1))->___m_task_2), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_U3CU3E4__this_2() { return static_cast<int32_t>(offsetof(U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D, ___U3CU3E4__this_2)); }
	inline Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * get_U3CU3E4__this_2() const { return ___U3CU3E4__this_2; }
	inline Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 ** get_address_of_U3CU3E4__this_2() { return &___U3CU3E4__this_2; }
	inline void set_U3CU3E4__this_2(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * value)
	{
		___U3CU3E4__this_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3Eu__1_3() { return static_cast<int32_t>(offsetof(U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D, ___U3CU3Eu__1_3)); }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  get_U3CU3Eu__1_3() const { return ___U3CU3Eu__1_3; }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * get_address_of_U3CU3Eu__1_3() { return &___U3CU3Eu__1_3; }
	inline void set_U3CU3Eu__1_3(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  value)
	{
		___U3CU3Eu__1_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Eu__1_3))->___m_task_0), (void*)NULL);
	}
};


// ET.MonoBehaviourAdapter/Adaptor/<Start>d__21
struct U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F 
{
public:
	// System.Int32 ET.MonoBehaviourAdapter/Adaptor/<Start>d__21::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Runtime.CompilerServices.AsyncVoidMethodBuilder ET.MonoBehaviourAdapter/Adaptor/<Start>d__21::<>t__builder
	AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6  ___U3CU3Et__builder_1;
	// ET.MonoBehaviourAdapter/Adaptor ET.MonoBehaviourAdapter/Adaptor/<Start>d__21::<>4__this
	Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * ___U3CU3E4__this_2;
	// System.Runtime.CompilerServices.TaskAwaiter ET.MonoBehaviourAdapter/Adaptor/<Start>d__21::<>u__1
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  ___U3CU3Eu__1_3;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3Et__builder_1() { return static_cast<int32_t>(offsetof(U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F, ___U3CU3Et__builder_1)); }
	inline AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6  get_U3CU3Et__builder_1() const { return ___U3CU3Et__builder_1; }
	inline AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * get_address_of_U3CU3Et__builder_1() { return &___U3CU3Et__builder_1; }
	inline void set_U3CU3Et__builder_1(AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6  value)
	{
		___U3CU3Et__builder_1 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Et__builder_1))->___m_synchronizationContext_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___U3CU3Et__builder_1))->___m_coreState_1))->___m_stateMachine_0), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((&(((&___U3CU3Et__builder_1))->___m_coreState_1))->___m_defaultContextAction_1), (void*)NULL);
		#endif
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Et__builder_1))->___m_task_2), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_U3CU3E4__this_2() { return static_cast<int32_t>(offsetof(U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F, ___U3CU3E4__this_2)); }
	inline Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * get_U3CU3E4__this_2() const { return ___U3CU3E4__this_2; }
	inline Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 ** get_address_of_U3CU3E4__this_2() { return &___U3CU3E4__this_2; }
	inline void set_U3CU3E4__this_2(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * value)
	{
		___U3CU3E4__this_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3Eu__1_3() { return static_cast<int32_t>(offsetof(U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F, ___U3CU3Eu__1_3)); }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  get_U3CU3Eu__1_3() const { return ___U3CU3Eu__1_3; }
	inline TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * get_address_of_U3CU3Eu__1_3() { return &___U3CU3Eu__1_3; }
	inline void set_U3CU3Eu__1_3(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  value)
	{
		___U3CU3Eu__1_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___U3CU3Eu__1_3))->___m_task_0), (void*)NULL);
	}
};


// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// System.Runtime.InteropServices.ExternalException
struct ExternalException_tC18275DD0AEB2CDF9F85D94670C5A49A4DC3B783  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// System.NotSupportedException
struct NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// System.NullReferenceException
struct NullReferenceException_t44B4F3CDE3111E74591952B8BE8707B28866D724  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// ET.WChannel
struct WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93  : public AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432
{
public:
	// System.Net.WebSockets.HttpListenerWebSocketContext ET.WChannel::<WebSocketContext>k__BackingField
	HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * ___U3CWebSocketContextU3Ek__BackingField_4;
	// ET.WService ET.WChannel::Service
	WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * ___Service_5;
	// System.Net.WebSockets.WebSocket ET.WChannel::webSocket
	WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * ___webSocket_6;
	// System.Collections.Generic.Queue`1<System.Byte[]> ET.WChannel::queue
	Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 * ___queue_7;
	// System.Boolean ET.WChannel::isSending
	bool ___isSending_8;
	// System.Boolean ET.WChannel::isConnected
	bool ___isConnected_9;
	// System.IO.MemoryStream ET.WChannel::recvStream
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * ___recvStream_10;
	// System.Threading.CancellationTokenSource ET.WChannel::cancellationTokenSource
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ___cancellationTokenSource_11;
	// System.Byte[] ET.WChannel::cache
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___cache_12;

public:
	inline static int32_t get_offset_of_U3CWebSocketContextU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___U3CWebSocketContextU3Ek__BackingField_4)); }
	inline HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * get_U3CWebSocketContextU3Ek__BackingField_4() const { return ___U3CWebSocketContextU3Ek__BackingField_4; }
	inline HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 ** get_address_of_U3CWebSocketContextU3Ek__BackingField_4() { return &___U3CWebSocketContextU3Ek__BackingField_4; }
	inline void set_U3CWebSocketContextU3Ek__BackingField_4(HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * value)
	{
		___U3CWebSocketContextU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CWebSocketContextU3Ek__BackingField_4), (void*)value);
	}

	inline static int32_t get_offset_of_Service_5() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___Service_5)); }
	inline WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * get_Service_5() const { return ___Service_5; }
	inline WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 ** get_address_of_Service_5() { return &___Service_5; }
	inline void set_Service_5(WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * value)
	{
		___Service_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Service_5), (void*)value);
	}

	inline static int32_t get_offset_of_webSocket_6() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___webSocket_6)); }
	inline WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * get_webSocket_6() const { return ___webSocket_6; }
	inline WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D ** get_address_of_webSocket_6() { return &___webSocket_6; }
	inline void set_webSocket_6(WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * value)
	{
		___webSocket_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___webSocket_6), (void*)value);
	}

	inline static int32_t get_offset_of_queue_7() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___queue_7)); }
	inline Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 * get_queue_7() const { return ___queue_7; }
	inline Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 ** get_address_of_queue_7() { return &___queue_7; }
	inline void set_queue_7(Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 * value)
	{
		___queue_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___queue_7), (void*)value);
	}

	inline static int32_t get_offset_of_isSending_8() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___isSending_8)); }
	inline bool get_isSending_8() const { return ___isSending_8; }
	inline bool* get_address_of_isSending_8() { return &___isSending_8; }
	inline void set_isSending_8(bool value)
	{
		___isSending_8 = value;
	}

	inline static int32_t get_offset_of_isConnected_9() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___isConnected_9)); }
	inline bool get_isConnected_9() const { return ___isConnected_9; }
	inline bool* get_address_of_isConnected_9() { return &___isConnected_9; }
	inline void set_isConnected_9(bool value)
	{
		___isConnected_9 = value;
	}

	inline static int32_t get_offset_of_recvStream_10() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___recvStream_10)); }
	inline MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * get_recvStream_10() const { return ___recvStream_10; }
	inline MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C ** get_address_of_recvStream_10() { return &___recvStream_10; }
	inline void set_recvStream_10(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * value)
	{
		___recvStream_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___recvStream_10), (void*)value);
	}

	inline static int32_t get_offset_of_cancellationTokenSource_11() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___cancellationTokenSource_11)); }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * get_cancellationTokenSource_11() const { return ___cancellationTokenSource_11; }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 ** get_address_of_cancellationTokenSource_11() { return &___cancellationTokenSource_11; }
	inline void set_cancellationTokenSource_11(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * value)
	{
		___cancellationTokenSource_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___cancellationTokenSource_11), (void*)value);
	}

	inline static int32_t get_offset_of_cache_12() { return static_cast<int32_t>(offsetof(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93, ___cache_12)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_cache_12() const { return ___cache_12; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_cache_12() { return &___cache_12; }
	inline void set_cache_12(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___cache_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___cache_12), (void*)value);
	}
};


// ET.WService
struct WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1  : public AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B
{
public:
	// System.Int64 ET.WService::idGenerater
	int64_t ___idGenerater_7;
	// System.Net.HttpListener ET.WService::httpListener
	HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * ___httpListener_8;
	// System.Collections.Generic.Dictionary`2<System.Int64,ET.WChannel> ET.WService::channels
	Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE * ___channels_9;

public:
	inline static int32_t get_offset_of_idGenerater_7() { return static_cast<int32_t>(offsetof(WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1, ___idGenerater_7)); }
	inline int64_t get_idGenerater_7() const { return ___idGenerater_7; }
	inline int64_t* get_address_of_idGenerater_7() { return &___idGenerater_7; }
	inline void set_idGenerater_7(int64_t value)
	{
		___idGenerater_7 = value;
	}

	inline static int32_t get_offset_of_httpListener_8() { return static_cast<int32_t>(offsetof(WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1, ___httpListener_8)); }
	inline HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * get_httpListener_8() const { return ___httpListener_8; }
	inline HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 ** get_address_of_httpListener_8() { return &___httpListener_8; }
	inline void set_httpListener_8(HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * value)
	{
		___httpListener_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___httpListener_8), (void*)value);
	}

	inline static int32_t get_offset_of_channels_9() { return static_cast<int32_t>(offsetof(WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1, ___channels_9)); }
	inline Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE * get_channels_9() const { return ___channels_9; }
	inline Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE ** get_address_of_channels_9() { return &___channels_9; }
	inline void set_channels_9(Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE * value)
	{
		___channels_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___channels_9), (void*)value);
	}
};


// System.Net.WebSockets.WebSocketReceiveResult
struct WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122  : public RuntimeObject
{
public:
	// System.Int32 System.Net.WebSockets.WebSocketReceiveResult::<Count>k__BackingField
	int32_t ___U3CCountU3Ek__BackingField_0;
	// System.Boolean System.Net.WebSockets.WebSocketReceiveResult::<EndOfMessage>k__BackingField
	bool ___U3CEndOfMessageU3Ek__BackingField_1;
	// System.Net.WebSockets.WebSocketMessageType System.Net.WebSockets.WebSocketReceiveResult::<MessageType>k__BackingField
	int32_t ___U3CMessageTypeU3Ek__BackingField_2;
	// System.Nullable`1<System.Net.WebSockets.WebSocketCloseStatus> System.Net.WebSockets.WebSocketReceiveResult::<CloseStatus>k__BackingField
	Nullable_1_tEEF07CE805E86A33961C7C0AE095FA4A628605C6  ___U3CCloseStatusU3Ek__BackingField_3;
	// System.String System.Net.WebSockets.WebSocketReceiveResult::<CloseStatusDescription>k__BackingField
	String_t* ___U3CCloseStatusDescriptionU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CCountU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122, ___U3CCountU3Ek__BackingField_0)); }
	inline int32_t get_U3CCountU3Ek__BackingField_0() const { return ___U3CCountU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3CCountU3Ek__BackingField_0() { return &___U3CCountU3Ek__BackingField_0; }
	inline void set_U3CCountU3Ek__BackingField_0(int32_t value)
	{
		___U3CCountU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_U3CEndOfMessageU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122, ___U3CEndOfMessageU3Ek__BackingField_1)); }
	inline bool get_U3CEndOfMessageU3Ek__BackingField_1() const { return ___U3CEndOfMessageU3Ek__BackingField_1; }
	inline bool* get_address_of_U3CEndOfMessageU3Ek__BackingField_1() { return &___U3CEndOfMessageU3Ek__BackingField_1; }
	inline void set_U3CEndOfMessageU3Ek__BackingField_1(bool value)
	{
		___U3CEndOfMessageU3Ek__BackingField_1 = value;
	}

	inline static int32_t get_offset_of_U3CMessageTypeU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122, ___U3CMessageTypeU3Ek__BackingField_2)); }
	inline int32_t get_U3CMessageTypeU3Ek__BackingField_2() const { return ___U3CMessageTypeU3Ek__BackingField_2; }
	inline int32_t* get_address_of_U3CMessageTypeU3Ek__BackingField_2() { return &___U3CMessageTypeU3Ek__BackingField_2; }
	inline void set_U3CMessageTypeU3Ek__BackingField_2(int32_t value)
	{
		___U3CMessageTypeU3Ek__BackingField_2 = value;
	}

	inline static int32_t get_offset_of_U3CCloseStatusU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122, ___U3CCloseStatusU3Ek__BackingField_3)); }
	inline Nullable_1_tEEF07CE805E86A33961C7C0AE095FA4A628605C6  get_U3CCloseStatusU3Ek__BackingField_3() const { return ___U3CCloseStatusU3Ek__BackingField_3; }
	inline Nullable_1_tEEF07CE805E86A33961C7C0AE095FA4A628605C6 * get_address_of_U3CCloseStatusU3Ek__BackingField_3() { return &___U3CCloseStatusU3Ek__BackingField_3; }
	inline void set_U3CCloseStatusU3Ek__BackingField_3(Nullable_1_tEEF07CE805E86A33961C7C0AE095FA4A628605C6  value)
	{
		___U3CCloseStatusU3Ek__BackingField_3 = value;
	}

	inline static int32_t get_offset_of_U3CCloseStatusDescriptionU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122, ___U3CCloseStatusDescriptionU3Ek__BackingField_4)); }
	inline String_t* get_U3CCloseStatusDescriptionU3Ek__BackingField_4() const { return ___U3CCloseStatusDescriptionU3Ek__BackingField_4; }
	inline String_t** get_address_of_U3CCloseStatusDescriptionU3Ek__BackingField_4() { return &___U3CCloseStatusDescriptionU3Ek__BackingField_4; }
	inline void set_U3CCloseStatusDescriptionU3Ek__BackingField_4(String_t* value)
	{
		___U3CCloseStatusDescriptionU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CCloseStatusDescriptionU3Ek__BackingField_4), (void*)value);
	}
};


// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};


// System.ComponentModel.Win32Exception
struct Win32Exception_t4B7A329153AA0E88CA08533EFB6DB2F2A8E90950  : public ExternalException_tC18275DD0AEB2CDF9F85D94670C5A49A4DC3B783
{
public:
	// System.Int32 System.ComponentModel.Win32Exception::nativeErrorCode
	int32_t ___nativeErrorCode_17;

public:
	inline static int32_t get_offset_of_nativeErrorCode_17() { return static_cast<int32_t>(offsetof(Win32Exception_t4B7A329153AA0E88CA08533EFB6DB2F2A8E90950, ___nativeErrorCode_17)); }
	inline int32_t get_nativeErrorCode_17() const { return ___nativeErrorCode_17; }
	inline int32_t* get_address_of_nativeErrorCode_17() { return &___nativeErrorCode_17; }
	inline void set_nativeErrorCode_17(int32_t value)
	{
		___nativeErrorCode_17 = value;
	}
};

struct Win32Exception_t4B7A329153AA0E88CA08533EFB6DB2F2A8E90950_StaticFields
{
public:
	// System.Boolean System.ComponentModel.Win32Exception::s_ErrorMessagesInitialized
	bool ___s_ErrorMessagesInitialized_18;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.String> System.ComponentModel.Win32Exception::s_ErrorMessage
	Dictionary_2_t0ACB62D0885C7AB376463C70665400A39808C5FB * ___s_ErrorMessage_19;

public:
	inline static int32_t get_offset_of_s_ErrorMessagesInitialized_18() { return static_cast<int32_t>(offsetof(Win32Exception_t4B7A329153AA0E88CA08533EFB6DB2F2A8E90950_StaticFields, ___s_ErrorMessagesInitialized_18)); }
	inline bool get_s_ErrorMessagesInitialized_18() const { return ___s_ErrorMessagesInitialized_18; }
	inline bool* get_address_of_s_ErrorMessagesInitialized_18() { return &___s_ErrorMessagesInitialized_18; }
	inline void set_s_ErrorMessagesInitialized_18(bool value)
	{
		___s_ErrorMessagesInitialized_18 = value;
	}

	inline static int32_t get_offset_of_s_ErrorMessage_19() { return static_cast<int32_t>(offsetof(Win32Exception_t4B7A329153AA0E88CA08533EFB6DB2F2A8E90950_StaticFields, ___s_ErrorMessage_19)); }
	inline Dictionary_2_t0ACB62D0885C7AB376463C70665400A39808C5FB * get_s_ErrorMessage_19() const { return ___s_ErrorMessage_19; }
	inline Dictionary_2_t0ACB62D0885C7AB376463C70665400A39808C5FB ** get_address_of_s_ErrorMessage_19() { return &___s_ErrorMessage_19; }
	inline void set_s_ErrorMessage_19(Dictionary_2_t0ACB62D0885C7AB376463C70665400A39808C5FB * value)
	{
		___s_ErrorMessage_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_ErrorMessage_19), (void*)value);
	}
};


// System.Net.HttpListenerException
struct HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF  : public Win32Exception_t4B7A329153AA0E88CA08533EFB6DB2F2A8E90950
{
public:

public:
};


// ValueTypeBindingDemo
struct ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// ILRuntime.Runtime.Enviorment.AppDomain ValueTypeBindingDemo::appdomain
	AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * ___appdomain_4;
	// System.IO.MemoryStream ValueTypeBindingDemo::fs
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * ___fs_5;
	// System.IO.MemoryStream ValueTypeBindingDemo::p
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * ___p_6;

public:
	inline static int32_t get_offset_of_appdomain_4() { return static_cast<int32_t>(offsetof(ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA, ___appdomain_4)); }
	inline AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * get_appdomain_4() const { return ___appdomain_4; }
	inline AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 ** get_address_of_appdomain_4() { return &___appdomain_4; }
	inline void set_appdomain_4(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * value)
	{
		___appdomain_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___appdomain_4), (void*)value);
	}

	inline static int32_t get_offset_of_fs_5() { return static_cast<int32_t>(offsetof(ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA, ___fs_5)); }
	inline MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * get_fs_5() const { return ___fs_5; }
	inline MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C ** get_address_of_fs_5() { return &___fs_5; }
	inline void set_fs_5(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * value)
	{
		___fs_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___fs_5), (void*)value);
	}

	inline static int32_t get_offset_of_p_6() { return static_cast<int32_t>(offsetof(ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA, ___p_6)); }
	inline MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * get_p_6() const { return ___p_6; }
	inline MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C ** get_address_of_p_6() { return &___p_6; }
	inline void set_p_6(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * value)
	{
		___p_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___p_6), (void*)value);
	}
};


// ET.MonoBehaviourAdapter/Adaptor
struct Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// ILRuntime.Runtime.Intepreter.ILTypeInstance ET.MonoBehaviourAdapter/Adaptor::instance
	ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * ___instance_4;
	// ILRuntime.Runtime.Enviorment.AppDomain ET.MonoBehaviourAdapter/Adaptor::appdomain
	AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * ___appdomain_5;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::isMonoBehaviour
	bool ___isMonoBehaviour_6;
	// System.Object[] ET.MonoBehaviourAdapter/Adaptor::param0
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___param0_7;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::destoryed
	bool ___destoryed_8;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mAwakeMethod
	RuntimeObject* ___mAwakeMethod_9;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mAwakeMethodGot
	bool ___mAwakeMethodGot_10;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::awaked
	bool ___awaked_11;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::isAwaking
	bool ___isAwaking_12;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mStartMethod
	RuntimeObject* ___mStartMethod_13;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mStartMethodGot
	bool ___mStartMethodGot_14;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mUpdateMethod
	RuntimeObject* ___mUpdateMethod_15;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mUpdateMethodGot
	bool ___mUpdateMethodGot_16;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mFixedUpdateMethod
	RuntimeObject* ___mFixedUpdateMethod_17;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mFixedUpdateMethodGot
	bool ___mFixedUpdateMethodGot_18;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mLateUpdateMethod
	RuntimeObject* ___mLateUpdateMethod_19;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mLateUpdateMethodGot
	bool ___mLateUpdateMethodGot_20;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnEnableMethod
	RuntimeObject* ___mOnEnableMethod_21;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnEnableMethodGot
	bool ___mOnEnableMethodGot_22;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnDisableMethod
	RuntimeObject* ___mOnDisableMethod_23;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnDisableMethodGot
	bool ___mOnDisableMethodGot_24;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mDestroyMethod
	RuntimeObject* ___mDestroyMethod_25;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mDestroyMethodGot
	bool ___mDestroyMethodGot_26;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnTriggerEnterMethod
	RuntimeObject* ___mOnTriggerEnterMethod_27;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnTriggerEnterMethodGot
	bool ___mOnTriggerEnterMethodGot_28;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnTriggerStayMethod
	RuntimeObject* ___mOnTriggerStayMethod_29;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnTriggerStayMethodGot
	bool ___mOnTriggerStayMethodGot_30;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnTriggerExitMethod
	RuntimeObject* ___mOnTriggerExitMethod_31;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnTriggerExitMethodGot
	bool ___mOnTriggerExitMethodGot_32;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnCollisionEnterMethod
	RuntimeObject* ___mOnCollisionEnterMethod_33;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnCollisionEnterMethodGot
	bool ___mOnCollisionEnterMethodGot_34;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnCollisionStayMethod
	RuntimeObject* ___mOnCollisionStayMethod_35;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnCollisionStayMethodGot
	bool ___mOnCollisionStayMethodGot_36;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnCollisionExitMethod
	RuntimeObject* ___mOnCollisionExitMethod_37;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnCollisionExitMethodGot
	bool ___mOnCollisionExitMethodGot_38;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnValidateMethod
	RuntimeObject* ___mOnValidateMethod_39;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnValidateMethodGot
	bool ___mOnValidateMethodGot_40;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnAnimatorMoveMethod
	RuntimeObject* ___mOnAnimatorMoveMethod_41;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnAnimatorMoveMethodGot
	bool ___mOnAnimatorMoveMethodGot_42;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnApplicationFocusMethod
	RuntimeObject* ___mOnApplicationFocusMethod_43;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnApplicationFocusMethodGot
	bool ___mOnApplicationFocusMethodGot_44;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnApplicationPauseMethod
	RuntimeObject* ___mOnApplicationPauseMethod_45;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnApplicationPauseMethodGot
	bool ___mOnApplicationPauseMethodGot_46;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnApplicationQuitMethod
	RuntimeObject* ___mOnApplicationQuitMethod_47;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnApplicationQuitMethodGot
	bool ___mOnApplicationQuitMethodGot_48;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnBecameInvisibleMethod
	RuntimeObject* ___mOnBecameInvisibleMethod_49;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnBecameInvisibleMethodGot
	bool ___mOnBecameInvisibleMethodGot_50;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnBecameVisibleMethod
	RuntimeObject* ___mOnBecameVisibleMethod_51;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnBecameVisibleMethodGot
	bool ___mOnBecameVisibleMethodGot_52;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnDrawGizmosMethod
	RuntimeObject* ___mOnDrawGizmosMethod_53;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnDrawGizmosMethodGot
	bool ___mOnDrawGizmosMethodGot_54;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnJointBreakMethod
	RuntimeObject* ___mOnJointBreakMethod_55;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnJointBreakMethodGot
	bool ___mOnJointBreakMethodGot_56;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnMouseDownMethod
	RuntimeObject* ___mOnMouseDownMethod_57;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnMouseDownMethodGot
	bool ___mOnMouseDownMethodGot_58;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnMouseDragMethod
	RuntimeObject* ___mOnMouseDragMethod_59;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnMouseDragMethodGot
	bool ___mOnMouseDragMethodGot_60;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnMouseEnterMethod
	RuntimeObject* ___mOnMouseEnterMethod_61;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnMouseEnterMethodGot
	bool ___mOnMouseEnterMethodGot_62;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnMouseExitMethod
	RuntimeObject* ___mOnMouseExitMethod_63;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnMouseExitMethodGot
	bool ___mOnMouseExitMethodGot_64;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnMouseOverMethod
	RuntimeObject* ___mOnMouseOverMethod_65;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnMouseOverMethodGot
	bool ___mOnMouseOverMethodGot_66;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnMouseUpMethod
	RuntimeObject* ___mOnMouseUpMethod_67;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnMouseUpMethodGot
	bool ___mOnMouseUpMethodGot_68;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnParticleCollisionMethod
	RuntimeObject* ___mOnParticleCollisionMethod_69;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnParticleCollisionMethodGot
	bool ___mOnParticleCollisionMethodGot_70;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnParticleTriggerMethod
	RuntimeObject* ___mOnParticleTriggerMethod_71;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnParticleTriggerMethodGot
	bool ___mOnParticleTriggerMethodGot_72;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnPostRenderMethod
	RuntimeObject* ___mOnPostRenderMethod_73;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnPostRenderMethodGot
	bool ___mOnPostRenderMethodGot_74;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnPreCullMethod
	RuntimeObject* ___mOnPreCullMethod_75;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnPreCullMethodGot
	bool ___mOnPreCullMethodGot_76;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnPreRenderMethod
	RuntimeObject* ___mOnPreRenderMethod_77;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnPreRenderMethodGot
	bool ___mOnPreRenderMethodGot_78;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnRenderImageMethod
	RuntimeObject* ___mOnRenderImageMethod_79;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnRenderImageMethodGot
	bool ___mOnRenderImageMethodGot_80;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnRenderObjectMethod
	RuntimeObject* ___mOnRenderObjectMethod_81;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnRenderObjectMethodGot
	bool ___mOnRenderObjectMethodGot_82;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnServerInitializedMethod
	RuntimeObject* ___mOnServerInitializedMethod_83;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnServerInitializedMethodGot
	bool ___mOnServerInitializedMethodGot_84;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnAnimatorIKMethod
	RuntimeObject* ___mOnAnimatorIKMethod_85;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnAnimatorIKMethodGot
	bool ___mOnAnimatorIKMethodGot_86;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnAudioFilterReadMethod
	RuntimeObject* ___mOnAudioFilterReadMethod_87;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnAudioFilterReadMethodGot
	bool ___mOnAudioFilterReadMethodGot_88;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnCanvasGroupChangedMethod
	RuntimeObject* ___mOnCanvasGroupChangedMethod_89;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnCanvasGroupChangedMethodGot
	bool ___mOnCanvasGroupChangedMethodGot_90;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnCanvasHierarchyChangedMethod
	RuntimeObject* ___mOnCanvasHierarchyChangedMethod_91;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnCanvasHierarchyChangedMethodGot
	bool ___mOnCanvasHierarchyChangedMethodGot_92;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnCollisionEnter2DMethod
	RuntimeObject* ___mOnCollisionEnter2DMethod_93;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnCollisionEnter2DMethodGot
	bool ___mOnCollisionEnter2DMethodGot_94;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnCollisionExit2DMethod
	RuntimeObject* ___mOnCollisionExit2DMethod_95;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnCollisionExit2DMethodGot
	bool ___mOnCollisionExit2DMethodGot_96;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnCollisionStay2DMethod
	RuntimeObject* ___mOnCollisionStay2DMethod_97;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnCollisionStay2DMethodGot
	bool ___mOnCollisionStay2DMethodGot_98;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnConnectedToServerMethod
	RuntimeObject* ___mOnConnectedToServerMethod_99;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnConnectedToServerMethodGot
	bool ___mOnConnectedToServerMethodGot_100;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnControllerColliderHitMethod
	RuntimeObject* ___mOnControllerColliderHitMethod_101;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnControllerColliderHitMethodGot
	bool ___mOnControllerColliderHitMethodGot_102;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnDrawGizmosSelectedMethod
	RuntimeObject* ___mOnDrawGizmosSelectedMethod_103;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnDrawGizmosSelectedMethodGot
	bool ___mOnDrawGizmosSelectedMethodGot_104;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnGUIMethod
	RuntimeObject* ___mOnGUIMethod_105;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnGUIMethodGot
	bool ___mOnGUIMethodGot_106;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnJointBreak2DMethod
	RuntimeObject* ___mOnJointBreak2DMethod_107;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnJointBreak2DMethodGot
	bool ___mOnJointBreak2DMethodGot_108;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnParticleSystemStoppedMethod
	RuntimeObject* ___mOnParticleSystemStoppedMethod_109;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnParticleSystemStoppedMethodGot
	bool ___mOnParticleSystemStoppedMethodGot_110;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnTransformChildrenChangedMethod
	RuntimeObject* ___mOnTransformChildrenChangedMethod_111;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnTransformChildrenChangedMethodGot
	bool ___mOnTransformChildrenChangedMethodGot_112;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnTransformParentChangedMethod
	RuntimeObject* ___mOnTransformParentChangedMethod_113;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnTransformParentChangedMethodGot
	bool ___mOnTransformParentChangedMethodGot_114;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnTriggerEnter2DMethod
	RuntimeObject* ___mOnTriggerEnter2DMethod_115;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnTriggerEnter2DMethodGot
	bool ___mOnTriggerEnter2DMethodGot_116;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnTriggerExit2DMethod
	RuntimeObject* ___mOnTriggerExit2DMethod_117;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnTriggerExit2DMethodGot
	bool ___mOnTriggerExit2DMethodGot_118;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnTriggerStay2DMethod
	RuntimeObject* ___mOnTriggerStay2DMethod_119;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnTriggerStay2DMethodGot
	bool ___mOnTriggerStay2DMethodGot_120;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnWillRenderObjectMethod
	RuntimeObject* ___mOnWillRenderObjectMethod_121;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnWillRenderObjectMethodGot
	bool ___mOnWillRenderObjectMethodGot_122;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnBeforeTransformParentChangedMethod
	RuntimeObject* ___mOnBeforeTransformParentChangedMethod_123;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnBeforeTransformParentChangedMethodGot
	bool ___mOnBeforeTransformParentChangedMethodGot_124;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnDidApplyAnimationPropertiesMethod
	RuntimeObject* ___mOnDidApplyAnimationPropertiesMethod_125;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnDidApplyAnimationPropertiesMethodGot
	bool ___mOnDidApplyAnimationPropertiesMethodGot_126;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnMouseUpAsButtonMethod
	RuntimeObject* ___mOnMouseUpAsButtonMethod_127;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnMouseUpAsButtonMethodGot
	bool ___mOnMouseUpAsButtonMethodGot_128;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnParticleUpdateJobScheduledMethod
	RuntimeObject* ___mOnParticleUpdateJobScheduledMethod_129;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnParticleUpdateJobScheduledMethodGot
	bool ___mOnParticleUpdateJobScheduledMethodGot_130;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mOnRectTransformDimensionsChangeMethod
	RuntimeObject* ___mOnRectTransformDimensionsChangeMethod_131;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mOnRectTransformDimensionsChangeMethodGot
	bool ___mOnRectTransformDimensionsChangeMethodGot_132;
	// ILRuntime.CLR.Method.IMethod ET.MonoBehaviourAdapter/Adaptor::mToStringMethod
	RuntimeObject* ___mToStringMethod_133;
	// System.Boolean ET.MonoBehaviourAdapter/Adaptor::mToStringMethodGot
	bool ___mToStringMethodGot_134;

public:
	inline static int32_t get_offset_of_instance_4() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___instance_4)); }
	inline ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * get_instance_4() const { return ___instance_4; }
	inline ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 ** get_address_of_instance_4() { return &___instance_4; }
	inline void set_instance_4(ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * value)
	{
		___instance_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___instance_4), (void*)value);
	}

	inline static int32_t get_offset_of_appdomain_5() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___appdomain_5)); }
	inline AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * get_appdomain_5() const { return ___appdomain_5; }
	inline AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 ** get_address_of_appdomain_5() { return &___appdomain_5; }
	inline void set_appdomain_5(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * value)
	{
		___appdomain_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___appdomain_5), (void*)value);
	}

	inline static int32_t get_offset_of_isMonoBehaviour_6() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___isMonoBehaviour_6)); }
	inline bool get_isMonoBehaviour_6() const { return ___isMonoBehaviour_6; }
	inline bool* get_address_of_isMonoBehaviour_6() { return &___isMonoBehaviour_6; }
	inline void set_isMonoBehaviour_6(bool value)
	{
		___isMonoBehaviour_6 = value;
	}

	inline static int32_t get_offset_of_param0_7() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___param0_7)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get_param0_7() const { return ___param0_7; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of_param0_7() { return &___param0_7; }
	inline void set_param0_7(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		___param0_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___param0_7), (void*)value);
	}

	inline static int32_t get_offset_of_destoryed_8() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___destoryed_8)); }
	inline bool get_destoryed_8() const { return ___destoryed_8; }
	inline bool* get_address_of_destoryed_8() { return &___destoryed_8; }
	inline void set_destoryed_8(bool value)
	{
		___destoryed_8 = value;
	}

	inline static int32_t get_offset_of_mAwakeMethod_9() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mAwakeMethod_9)); }
	inline RuntimeObject* get_mAwakeMethod_9() const { return ___mAwakeMethod_9; }
	inline RuntimeObject** get_address_of_mAwakeMethod_9() { return &___mAwakeMethod_9; }
	inline void set_mAwakeMethod_9(RuntimeObject* value)
	{
		___mAwakeMethod_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mAwakeMethod_9), (void*)value);
	}

	inline static int32_t get_offset_of_mAwakeMethodGot_10() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mAwakeMethodGot_10)); }
	inline bool get_mAwakeMethodGot_10() const { return ___mAwakeMethodGot_10; }
	inline bool* get_address_of_mAwakeMethodGot_10() { return &___mAwakeMethodGot_10; }
	inline void set_mAwakeMethodGot_10(bool value)
	{
		___mAwakeMethodGot_10 = value;
	}

	inline static int32_t get_offset_of_awaked_11() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___awaked_11)); }
	inline bool get_awaked_11() const { return ___awaked_11; }
	inline bool* get_address_of_awaked_11() { return &___awaked_11; }
	inline void set_awaked_11(bool value)
	{
		___awaked_11 = value;
	}

	inline static int32_t get_offset_of_isAwaking_12() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___isAwaking_12)); }
	inline bool get_isAwaking_12() const { return ___isAwaking_12; }
	inline bool* get_address_of_isAwaking_12() { return &___isAwaking_12; }
	inline void set_isAwaking_12(bool value)
	{
		___isAwaking_12 = value;
	}

	inline static int32_t get_offset_of_mStartMethod_13() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mStartMethod_13)); }
	inline RuntimeObject* get_mStartMethod_13() const { return ___mStartMethod_13; }
	inline RuntimeObject** get_address_of_mStartMethod_13() { return &___mStartMethod_13; }
	inline void set_mStartMethod_13(RuntimeObject* value)
	{
		___mStartMethod_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mStartMethod_13), (void*)value);
	}

	inline static int32_t get_offset_of_mStartMethodGot_14() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mStartMethodGot_14)); }
	inline bool get_mStartMethodGot_14() const { return ___mStartMethodGot_14; }
	inline bool* get_address_of_mStartMethodGot_14() { return &___mStartMethodGot_14; }
	inline void set_mStartMethodGot_14(bool value)
	{
		___mStartMethodGot_14 = value;
	}

	inline static int32_t get_offset_of_mUpdateMethod_15() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mUpdateMethod_15)); }
	inline RuntimeObject* get_mUpdateMethod_15() const { return ___mUpdateMethod_15; }
	inline RuntimeObject** get_address_of_mUpdateMethod_15() { return &___mUpdateMethod_15; }
	inline void set_mUpdateMethod_15(RuntimeObject* value)
	{
		___mUpdateMethod_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mUpdateMethod_15), (void*)value);
	}

	inline static int32_t get_offset_of_mUpdateMethodGot_16() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mUpdateMethodGot_16)); }
	inline bool get_mUpdateMethodGot_16() const { return ___mUpdateMethodGot_16; }
	inline bool* get_address_of_mUpdateMethodGot_16() { return &___mUpdateMethodGot_16; }
	inline void set_mUpdateMethodGot_16(bool value)
	{
		___mUpdateMethodGot_16 = value;
	}

	inline static int32_t get_offset_of_mFixedUpdateMethod_17() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mFixedUpdateMethod_17)); }
	inline RuntimeObject* get_mFixedUpdateMethod_17() const { return ___mFixedUpdateMethod_17; }
	inline RuntimeObject** get_address_of_mFixedUpdateMethod_17() { return &___mFixedUpdateMethod_17; }
	inline void set_mFixedUpdateMethod_17(RuntimeObject* value)
	{
		___mFixedUpdateMethod_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mFixedUpdateMethod_17), (void*)value);
	}

	inline static int32_t get_offset_of_mFixedUpdateMethodGot_18() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mFixedUpdateMethodGot_18)); }
	inline bool get_mFixedUpdateMethodGot_18() const { return ___mFixedUpdateMethodGot_18; }
	inline bool* get_address_of_mFixedUpdateMethodGot_18() { return &___mFixedUpdateMethodGot_18; }
	inline void set_mFixedUpdateMethodGot_18(bool value)
	{
		___mFixedUpdateMethodGot_18 = value;
	}

	inline static int32_t get_offset_of_mLateUpdateMethod_19() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mLateUpdateMethod_19)); }
	inline RuntimeObject* get_mLateUpdateMethod_19() const { return ___mLateUpdateMethod_19; }
	inline RuntimeObject** get_address_of_mLateUpdateMethod_19() { return &___mLateUpdateMethod_19; }
	inline void set_mLateUpdateMethod_19(RuntimeObject* value)
	{
		___mLateUpdateMethod_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mLateUpdateMethod_19), (void*)value);
	}

	inline static int32_t get_offset_of_mLateUpdateMethodGot_20() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mLateUpdateMethodGot_20)); }
	inline bool get_mLateUpdateMethodGot_20() const { return ___mLateUpdateMethodGot_20; }
	inline bool* get_address_of_mLateUpdateMethodGot_20() { return &___mLateUpdateMethodGot_20; }
	inline void set_mLateUpdateMethodGot_20(bool value)
	{
		___mLateUpdateMethodGot_20 = value;
	}

	inline static int32_t get_offset_of_mOnEnableMethod_21() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnEnableMethod_21)); }
	inline RuntimeObject* get_mOnEnableMethod_21() const { return ___mOnEnableMethod_21; }
	inline RuntimeObject** get_address_of_mOnEnableMethod_21() { return &___mOnEnableMethod_21; }
	inline void set_mOnEnableMethod_21(RuntimeObject* value)
	{
		___mOnEnableMethod_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnEnableMethod_21), (void*)value);
	}

	inline static int32_t get_offset_of_mOnEnableMethodGot_22() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnEnableMethodGot_22)); }
	inline bool get_mOnEnableMethodGot_22() const { return ___mOnEnableMethodGot_22; }
	inline bool* get_address_of_mOnEnableMethodGot_22() { return &___mOnEnableMethodGot_22; }
	inline void set_mOnEnableMethodGot_22(bool value)
	{
		___mOnEnableMethodGot_22 = value;
	}

	inline static int32_t get_offset_of_mOnDisableMethod_23() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnDisableMethod_23)); }
	inline RuntimeObject* get_mOnDisableMethod_23() const { return ___mOnDisableMethod_23; }
	inline RuntimeObject** get_address_of_mOnDisableMethod_23() { return &___mOnDisableMethod_23; }
	inline void set_mOnDisableMethod_23(RuntimeObject* value)
	{
		___mOnDisableMethod_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnDisableMethod_23), (void*)value);
	}

	inline static int32_t get_offset_of_mOnDisableMethodGot_24() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnDisableMethodGot_24)); }
	inline bool get_mOnDisableMethodGot_24() const { return ___mOnDisableMethodGot_24; }
	inline bool* get_address_of_mOnDisableMethodGot_24() { return &___mOnDisableMethodGot_24; }
	inline void set_mOnDisableMethodGot_24(bool value)
	{
		___mOnDisableMethodGot_24 = value;
	}

	inline static int32_t get_offset_of_mDestroyMethod_25() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mDestroyMethod_25)); }
	inline RuntimeObject* get_mDestroyMethod_25() const { return ___mDestroyMethod_25; }
	inline RuntimeObject** get_address_of_mDestroyMethod_25() { return &___mDestroyMethod_25; }
	inline void set_mDestroyMethod_25(RuntimeObject* value)
	{
		___mDestroyMethod_25 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mDestroyMethod_25), (void*)value);
	}

	inline static int32_t get_offset_of_mDestroyMethodGot_26() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mDestroyMethodGot_26)); }
	inline bool get_mDestroyMethodGot_26() const { return ___mDestroyMethodGot_26; }
	inline bool* get_address_of_mDestroyMethodGot_26() { return &___mDestroyMethodGot_26; }
	inline void set_mDestroyMethodGot_26(bool value)
	{
		___mDestroyMethodGot_26 = value;
	}

	inline static int32_t get_offset_of_mOnTriggerEnterMethod_27() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerEnterMethod_27)); }
	inline RuntimeObject* get_mOnTriggerEnterMethod_27() const { return ___mOnTriggerEnterMethod_27; }
	inline RuntimeObject** get_address_of_mOnTriggerEnterMethod_27() { return &___mOnTriggerEnterMethod_27; }
	inline void set_mOnTriggerEnterMethod_27(RuntimeObject* value)
	{
		___mOnTriggerEnterMethod_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnTriggerEnterMethod_27), (void*)value);
	}

	inline static int32_t get_offset_of_mOnTriggerEnterMethodGot_28() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerEnterMethodGot_28)); }
	inline bool get_mOnTriggerEnterMethodGot_28() const { return ___mOnTriggerEnterMethodGot_28; }
	inline bool* get_address_of_mOnTriggerEnterMethodGot_28() { return &___mOnTriggerEnterMethodGot_28; }
	inline void set_mOnTriggerEnterMethodGot_28(bool value)
	{
		___mOnTriggerEnterMethodGot_28 = value;
	}

	inline static int32_t get_offset_of_mOnTriggerStayMethod_29() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerStayMethod_29)); }
	inline RuntimeObject* get_mOnTriggerStayMethod_29() const { return ___mOnTriggerStayMethod_29; }
	inline RuntimeObject** get_address_of_mOnTriggerStayMethod_29() { return &___mOnTriggerStayMethod_29; }
	inline void set_mOnTriggerStayMethod_29(RuntimeObject* value)
	{
		___mOnTriggerStayMethod_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnTriggerStayMethod_29), (void*)value);
	}

	inline static int32_t get_offset_of_mOnTriggerStayMethodGot_30() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerStayMethodGot_30)); }
	inline bool get_mOnTriggerStayMethodGot_30() const { return ___mOnTriggerStayMethodGot_30; }
	inline bool* get_address_of_mOnTriggerStayMethodGot_30() { return &___mOnTriggerStayMethodGot_30; }
	inline void set_mOnTriggerStayMethodGot_30(bool value)
	{
		___mOnTriggerStayMethodGot_30 = value;
	}

	inline static int32_t get_offset_of_mOnTriggerExitMethod_31() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerExitMethod_31)); }
	inline RuntimeObject* get_mOnTriggerExitMethod_31() const { return ___mOnTriggerExitMethod_31; }
	inline RuntimeObject** get_address_of_mOnTriggerExitMethod_31() { return &___mOnTriggerExitMethod_31; }
	inline void set_mOnTriggerExitMethod_31(RuntimeObject* value)
	{
		___mOnTriggerExitMethod_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnTriggerExitMethod_31), (void*)value);
	}

	inline static int32_t get_offset_of_mOnTriggerExitMethodGot_32() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerExitMethodGot_32)); }
	inline bool get_mOnTriggerExitMethodGot_32() const { return ___mOnTriggerExitMethodGot_32; }
	inline bool* get_address_of_mOnTriggerExitMethodGot_32() { return &___mOnTriggerExitMethodGot_32; }
	inline void set_mOnTriggerExitMethodGot_32(bool value)
	{
		___mOnTriggerExitMethodGot_32 = value;
	}

	inline static int32_t get_offset_of_mOnCollisionEnterMethod_33() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionEnterMethod_33)); }
	inline RuntimeObject* get_mOnCollisionEnterMethod_33() const { return ___mOnCollisionEnterMethod_33; }
	inline RuntimeObject** get_address_of_mOnCollisionEnterMethod_33() { return &___mOnCollisionEnterMethod_33; }
	inline void set_mOnCollisionEnterMethod_33(RuntimeObject* value)
	{
		___mOnCollisionEnterMethod_33 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnCollisionEnterMethod_33), (void*)value);
	}

	inline static int32_t get_offset_of_mOnCollisionEnterMethodGot_34() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionEnterMethodGot_34)); }
	inline bool get_mOnCollisionEnterMethodGot_34() const { return ___mOnCollisionEnterMethodGot_34; }
	inline bool* get_address_of_mOnCollisionEnterMethodGot_34() { return &___mOnCollisionEnterMethodGot_34; }
	inline void set_mOnCollisionEnterMethodGot_34(bool value)
	{
		___mOnCollisionEnterMethodGot_34 = value;
	}

	inline static int32_t get_offset_of_mOnCollisionStayMethod_35() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionStayMethod_35)); }
	inline RuntimeObject* get_mOnCollisionStayMethod_35() const { return ___mOnCollisionStayMethod_35; }
	inline RuntimeObject** get_address_of_mOnCollisionStayMethod_35() { return &___mOnCollisionStayMethod_35; }
	inline void set_mOnCollisionStayMethod_35(RuntimeObject* value)
	{
		___mOnCollisionStayMethod_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnCollisionStayMethod_35), (void*)value);
	}

	inline static int32_t get_offset_of_mOnCollisionStayMethodGot_36() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionStayMethodGot_36)); }
	inline bool get_mOnCollisionStayMethodGot_36() const { return ___mOnCollisionStayMethodGot_36; }
	inline bool* get_address_of_mOnCollisionStayMethodGot_36() { return &___mOnCollisionStayMethodGot_36; }
	inline void set_mOnCollisionStayMethodGot_36(bool value)
	{
		___mOnCollisionStayMethodGot_36 = value;
	}

	inline static int32_t get_offset_of_mOnCollisionExitMethod_37() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionExitMethod_37)); }
	inline RuntimeObject* get_mOnCollisionExitMethod_37() const { return ___mOnCollisionExitMethod_37; }
	inline RuntimeObject** get_address_of_mOnCollisionExitMethod_37() { return &___mOnCollisionExitMethod_37; }
	inline void set_mOnCollisionExitMethod_37(RuntimeObject* value)
	{
		___mOnCollisionExitMethod_37 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnCollisionExitMethod_37), (void*)value);
	}

	inline static int32_t get_offset_of_mOnCollisionExitMethodGot_38() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionExitMethodGot_38)); }
	inline bool get_mOnCollisionExitMethodGot_38() const { return ___mOnCollisionExitMethodGot_38; }
	inline bool* get_address_of_mOnCollisionExitMethodGot_38() { return &___mOnCollisionExitMethodGot_38; }
	inline void set_mOnCollisionExitMethodGot_38(bool value)
	{
		___mOnCollisionExitMethodGot_38 = value;
	}

	inline static int32_t get_offset_of_mOnValidateMethod_39() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnValidateMethod_39)); }
	inline RuntimeObject* get_mOnValidateMethod_39() const { return ___mOnValidateMethod_39; }
	inline RuntimeObject** get_address_of_mOnValidateMethod_39() { return &___mOnValidateMethod_39; }
	inline void set_mOnValidateMethod_39(RuntimeObject* value)
	{
		___mOnValidateMethod_39 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnValidateMethod_39), (void*)value);
	}

	inline static int32_t get_offset_of_mOnValidateMethodGot_40() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnValidateMethodGot_40)); }
	inline bool get_mOnValidateMethodGot_40() const { return ___mOnValidateMethodGot_40; }
	inline bool* get_address_of_mOnValidateMethodGot_40() { return &___mOnValidateMethodGot_40; }
	inline void set_mOnValidateMethodGot_40(bool value)
	{
		___mOnValidateMethodGot_40 = value;
	}

	inline static int32_t get_offset_of_mOnAnimatorMoveMethod_41() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnAnimatorMoveMethod_41)); }
	inline RuntimeObject* get_mOnAnimatorMoveMethod_41() const { return ___mOnAnimatorMoveMethod_41; }
	inline RuntimeObject** get_address_of_mOnAnimatorMoveMethod_41() { return &___mOnAnimatorMoveMethod_41; }
	inline void set_mOnAnimatorMoveMethod_41(RuntimeObject* value)
	{
		___mOnAnimatorMoveMethod_41 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnAnimatorMoveMethod_41), (void*)value);
	}

	inline static int32_t get_offset_of_mOnAnimatorMoveMethodGot_42() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnAnimatorMoveMethodGot_42)); }
	inline bool get_mOnAnimatorMoveMethodGot_42() const { return ___mOnAnimatorMoveMethodGot_42; }
	inline bool* get_address_of_mOnAnimatorMoveMethodGot_42() { return &___mOnAnimatorMoveMethodGot_42; }
	inline void set_mOnAnimatorMoveMethodGot_42(bool value)
	{
		___mOnAnimatorMoveMethodGot_42 = value;
	}

	inline static int32_t get_offset_of_mOnApplicationFocusMethod_43() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnApplicationFocusMethod_43)); }
	inline RuntimeObject* get_mOnApplicationFocusMethod_43() const { return ___mOnApplicationFocusMethod_43; }
	inline RuntimeObject** get_address_of_mOnApplicationFocusMethod_43() { return &___mOnApplicationFocusMethod_43; }
	inline void set_mOnApplicationFocusMethod_43(RuntimeObject* value)
	{
		___mOnApplicationFocusMethod_43 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnApplicationFocusMethod_43), (void*)value);
	}

	inline static int32_t get_offset_of_mOnApplicationFocusMethodGot_44() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnApplicationFocusMethodGot_44)); }
	inline bool get_mOnApplicationFocusMethodGot_44() const { return ___mOnApplicationFocusMethodGot_44; }
	inline bool* get_address_of_mOnApplicationFocusMethodGot_44() { return &___mOnApplicationFocusMethodGot_44; }
	inline void set_mOnApplicationFocusMethodGot_44(bool value)
	{
		___mOnApplicationFocusMethodGot_44 = value;
	}

	inline static int32_t get_offset_of_mOnApplicationPauseMethod_45() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnApplicationPauseMethod_45)); }
	inline RuntimeObject* get_mOnApplicationPauseMethod_45() const { return ___mOnApplicationPauseMethod_45; }
	inline RuntimeObject** get_address_of_mOnApplicationPauseMethod_45() { return &___mOnApplicationPauseMethod_45; }
	inline void set_mOnApplicationPauseMethod_45(RuntimeObject* value)
	{
		___mOnApplicationPauseMethod_45 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnApplicationPauseMethod_45), (void*)value);
	}

	inline static int32_t get_offset_of_mOnApplicationPauseMethodGot_46() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnApplicationPauseMethodGot_46)); }
	inline bool get_mOnApplicationPauseMethodGot_46() const { return ___mOnApplicationPauseMethodGot_46; }
	inline bool* get_address_of_mOnApplicationPauseMethodGot_46() { return &___mOnApplicationPauseMethodGot_46; }
	inline void set_mOnApplicationPauseMethodGot_46(bool value)
	{
		___mOnApplicationPauseMethodGot_46 = value;
	}

	inline static int32_t get_offset_of_mOnApplicationQuitMethod_47() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnApplicationQuitMethod_47)); }
	inline RuntimeObject* get_mOnApplicationQuitMethod_47() const { return ___mOnApplicationQuitMethod_47; }
	inline RuntimeObject** get_address_of_mOnApplicationQuitMethod_47() { return &___mOnApplicationQuitMethod_47; }
	inline void set_mOnApplicationQuitMethod_47(RuntimeObject* value)
	{
		___mOnApplicationQuitMethod_47 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnApplicationQuitMethod_47), (void*)value);
	}

	inline static int32_t get_offset_of_mOnApplicationQuitMethodGot_48() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnApplicationQuitMethodGot_48)); }
	inline bool get_mOnApplicationQuitMethodGot_48() const { return ___mOnApplicationQuitMethodGot_48; }
	inline bool* get_address_of_mOnApplicationQuitMethodGot_48() { return &___mOnApplicationQuitMethodGot_48; }
	inline void set_mOnApplicationQuitMethodGot_48(bool value)
	{
		___mOnApplicationQuitMethodGot_48 = value;
	}

	inline static int32_t get_offset_of_mOnBecameInvisibleMethod_49() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnBecameInvisibleMethod_49)); }
	inline RuntimeObject* get_mOnBecameInvisibleMethod_49() const { return ___mOnBecameInvisibleMethod_49; }
	inline RuntimeObject** get_address_of_mOnBecameInvisibleMethod_49() { return &___mOnBecameInvisibleMethod_49; }
	inline void set_mOnBecameInvisibleMethod_49(RuntimeObject* value)
	{
		___mOnBecameInvisibleMethod_49 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnBecameInvisibleMethod_49), (void*)value);
	}

	inline static int32_t get_offset_of_mOnBecameInvisibleMethodGot_50() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnBecameInvisibleMethodGot_50)); }
	inline bool get_mOnBecameInvisibleMethodGot_50() const { return ___mOnBecameInvisibleMethodGot_50; }
	inline bool* get_address_of_mOnBecameInvisibleMethodGot_50() { return &___mOnBecameInvisibleMethodGot_50; }
	inline void set_mOnBecameInvisibleMethodGot_50(bool value)
	{
		___mOnBecameInvisibleMethodGot_50 = value;
	}

	inline static int32_t get_offset_of_mOnBecameVisibleMethod_51() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnBecameVisibleMethod_51)); }
	inline RuntimeObject* get_mOnBecameVisibleMethod_51() const { return ___mOnBecameVisibleMethod_51; }
	inline RuntimeObject** get_address_of_mOnBecameVisibleMethod_51() { return &___mOnBecameVisibleMethod_51; }
	inline void set_mOnBecameVisibleMethod_51(RuntimeObject* value)
	{
		___mOnBecameVisibleMethod_51 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnBecameVisibleMethod_51), (void*)value);
	}

	inline static int32_t get_offset_of_mOnBecameVisibleMethodGot_52() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnBecameVisibleMethodGot_52)); }
	inline bool get_mOnBecameVisibleMethodGot_52() const { return ___mOnBecameVisibleMethodGot_52; }
	inline bool* get_address_of_mOnBecameVisibleMethodGot_52() { return &___mOnBecameVisibleMethodGot_52; }
	inline void set_mOnBecameVisibleMethodGot_52(bool value)
	{
		___mOnBecameVisibleMethodGot_52 = value;
	}

	inline static int32_t get_offset_of_mOnDrawGizmosMethod_53() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnDrawGizmosMethod_53)); }
	inline RuntimeObject* get_mOnDrawGizmosMethod_53() const { return ___mOnDrawGizmosMethod_53; }
	inline RuntimeObject** get_address_of_mOnDrawGizmosMethod_53() { return &___mOnDrawGizmosMethod_53; }
	inline void set_mOnDrawGizmosMethod_53(RuntimeObject* value)
	{
		___mOnDrawGizmosMethod_53 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnDrawGizmosMethod_53), (void*)value);
	}

	inline static int32_t get_offset_of_mOnDrawGizmosMethodGot_54() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnDrawGizmosMethodGot_54)); }
	inline bool get_mOnDrawGizmosMethodGot_54() const { return ___mOnDrawGizmosMethodGot_54; }
	inline bool* get_address_of_mOnDrawGizmosMethodGot_54() { return &___mOnDrawGizmosMethodGot_54; }
	inline void set_mOnDrawGizmosMethodGot_54(bool value)
	{
		___mOnDrawGizmosMethodGot_54 = value;
	}

	inline static int32_t get_offset_of_mOnJointBreakMethod_55() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnJointBreakMethod_55)); }
	inline RuntimeObject* get_mOnJointBreakMethod_55() const { return ___mOnJointBreakMethod_55; }
	inline RuntimeObject** get_address_of_mOnJointBreakMethod_55() { return &___mOnJointBreakMethod_55; }
	inline void set_mOnJointBreakMethod_55(RuntimeObject* value)
	{
		___mOnJointBreakMethod_55 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnJointBreakMethod_55), (void*)value);
	}

	inline static int32_t get_offset_of_mOnJointBreakMethodGot_56() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnJointBreakMethodGot_56)); }
	inline bool get_mOnJointBreakMethodGot_56() const { return ___mOnJointBreakMethodGot_56; }
	inline bool* get_address_of_mOnJointBreakMethodGot_56() { return &___mOnJointBreakMethodGot_56; }
	inline void set_mOnJointBreakMethodGot_56(bool value)
	{
		___mOnJointBreakMethodGot_56 = value;
	}

	inline static int32_t get_offset_of_mOnMouseDownMethod_57() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseDownMethod_57)); }
	inline RuntimeObject* get_mOnMouseDownMethod_57() const { return ___mOnMouseDownMethod_57; }
	inline RuntimeObject** get_address_of_mOnMouseDownMethod_57() { return &___mOnMouseDownMethod_57; }
	inline void set_mOnMouseDownMethod_57(RuntimeObject* value)
	{
		___mOnMouseDownMethod_57 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnMouseDownMethod_57), (void*)value);
	}

	inline static int32_t get_offset_of_mOnMouseDownMethodGot_58() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseDownMethodGot_58)); }
	inline bool get_mOnMouseDownMethodGot_58() const { return ___mOnMouseDownMethodGot_58; }
	inline bool* get_address_of_mOnMouseDownMethodGot_58() { return &___mOnMouseDownMethodGot_58; }
	inline void set_mOnMouseDownMethodGot_58(bool value)
	{
		___mOnMouseDownMethodGot_58 = value;
	}

	inline static int32_t get_offset_of_mOnMouseDragMethod_59() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseDragMethod_59)); }
	inline RuntimeObject* get_mOnMouseDragMethod_59() const { return ___mOnMouseDragMethod_59; }
	inline RuntimeObject** get_address_of_mOnMouseDragMethod_59() { return &___mOnMouseDragMethod_59; }
	inline void set_mOnMouseDragMethod_59(RuntimeObject* value)
	{
		___mOnMouseDragMethod_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnMouseDragMethod_59), (void*)value);
	}

	inline static int32_t get_offset_of_mOnMouseDragMethodGot_60() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseDragMethodGot_60)); }
	inline bool get_mOnMouseDragMethodGot_60() const { return ___mOnMouseDragMethodGot_60; }
	inline bool* get_address_of_mOnMouseDragMethodGot_60() { return &___mOnMouseDragMethodGot_60; }
	inline void set_mOnMouseDragMethodGot_60(bool value)
	{
		___mOnMouseDragMethodGot_60 = value;
	}

	inline static int32_t get_offset_of_mOnMouseEnterMethod_61() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseEnterMethod_61)); }
	inline RuntimeObject* get_mOnMouseEnterMethod_61() const { return ___mOnMouseEnterMethod_61; }
	inline RuntimeObject** get_address_of_mOnMouseEnterMethod_61() { return &___mOnMouseEnterMethod_61; }
	inline void set_mOnMouseEnterMethod_61(RuntimeObject* value)
	{
		___mOnMouseEnterMethod_61 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnMouseEnterMethod_61), (void*)value);
	}

	inline static int32_t get_offset_of_mOnMouseEnterMethodGot_62() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseEnterMethodGot_62)); }
	inline bool get_mOnMouseEnterMethodGot_62() const { return ___mOnMouseEnterMethodGot_62; }
	inline bool* get_address_of_mOnMouseEnterMethodGot_62() { return &___mOnMouseEnterMethodGot_62; }
	inline void set_mOnMouseEnterMethodGot_62(bool value)
	{
		___mOnMouseEnterMethodGot_62 = value;
	}

	inline static int32_t get_offset_of_mOnMouseExitMethod_63() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseExitMethod_63)); }
	inline RuntimeObject* get_mOnMouseExitMethod_63() const { return ___mOnMouseExitMethod_63; }
	inline RuntimeObject** get_address_of_mOnMouseExitMethod_63() { return &___mOnMouseExitMethod_63; }
	inline void set_mOnMouseExitMethod_63(RuntimeObject* value)
	{
		___mOnMouseExitMethod_63 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnMouseExitMethod_63), (void*)value);
	}

	inline static int32_t get_offset_of_mOnMouseExitMethodGot_64() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseExitMethodGot_64)); }
	inline bool get_mOnMouseExitMethodGot_64() const { return ___mOnMouseExitMethodGot_64; }
	inline bool* get_address_of_mOnMouseExitMethodGot_64() { return &___mOnMouseExitMethodGot_64; }
	inline void set_mOnMouseExitMethodGot_64(bool value)
	{
		___mOnMouseExitMethodGot_64 = value;
	}

	inline static int32_t get_offset_of_mOnMouseOverMethod_65() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseOverMethod_65)); }
	inline RuntimeObject* get_mOnMouseOverMethod_65() const { return ___mOnMouseOverMethod_65; }
	inline RuntimeObject** get_address_of_mOnMouseOverMethod_65() { return &___mOnMouseOverMethod_65; }
	inline void set_mOnMouseOverMethod_65(RuntimeObject* value)
	{
		___mOnMouseOverMethod_65 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnMouseOverMethod_65), (void*)value);
	}

	inline static int32_t get_offset_of_mOnMouseOverMethodGot_66() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseOverMethodGot_66)); }
	inline bool get_mOnMouseOverMethodGot_66() const { return ___mOnMouseOverMethodGot_66; }
	inline bool* get_address_of_mOnMouseOverMethodGot_66() { return &___mOnMouseOverMethodGot_66; }
	inline void set_mOnMouseOverMethodGot_66(bool value)
	{
		___mOnMouseOverMethodGot_66 = value;
	}

	inline static int32_t get_offset_of_mOnMouseUpMethod_67() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseUpMethod_67)); }
	inline RuntimeObject* get_mOnMouseUpMethod_67() const { return ___mOnMouseUpMethod_67; }
	inline RuntimeObject** get_address_of_mOnMouseUpMethod_67() { return &___mOnMouseUpMethod_67; }
	inline void set_mOnMouseUpMethod_67(RuntimeObject* value)
	{
		___mOnMouseUpMethod_67 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnMouseUpMethod_67), (void*)value);
	}

	inline static int32_t get_offset_of_mOnMouseUpMethodGot_68() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseUpMethodGot_68)); }
	inline bool get_mOnMouseUpMethodGot_68() const { return ___mOnMouseUpMethodGot_68; }
	inline bool* get_address_of_mOnMouseUpMethodGot_68() { return &___mOnMouseUpMethodGot_68; }
	inline void set_mOnMouseUpMethodGot_68(bool value)
	{
		___mOnMouseUpMethodGot_68 = value;
	}

	inline static int32_t get_offset_of_mOnParticleCollisionMethod_69() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnParticleCollisionMethod_69)); }
	inline RuntimeObject* get_mOnParticleCollisionMethod_69() const { return ___mOnParticleCollisionMethod_69; }
	inline RuntimeObject** get_address_of_mOnParticleCollisionMethod_69() { return &___mOnParticleCollisionMethod_69; }
	inline void set_mOnParticleCollisionMethod_69(RuntimeObject* value)
	{
		___mOnParticleCollisionMethod_69 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnParticleCollisionMethod_69), (void*)value);
	}

	inline static int32_t get_offset_of_mOnParticleCollisionMethodGot_70() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnParticleCollisionMethodGot_70)); }
	inline bool get_mOnParticleCollisionMethodGot_70() const { return ___mOnParticleCollisionMethodGot_70; }
	inline bool* get_address_of_mOnParticleCollisionMethodGot_70() { return &___mOnParticleCollisionMethodGot_70; }
	inline void set_mOnParticleCollisionMethodGot_70(bool value)
	{
		___mOnParticleCollisionMethodGot_70 = value;
	}

	inline static int32_t get_offset_of_mOnParticleTriggerMethod_71() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnParticleTriggerMethod_71)); }
	inline RuntimeObject* get_mOnParticleTriggerMethod_71() const { return ___mOnParticleTriggerMethod_71; }
	inline RuntimeObject** get_address_of_mOnParticleTriggerMethod_71() { return &___mOnParticleTriggerMethod_71; }
	inline void set_mOnParticleTriggerMethod_71(RuntimeObject* value)
	{
		___mOnParticleTriggerMethod_71 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnParticleTriggerMethod_71), (void*)value);
	}

	inline static int32_t get_offset_of_mOnParticleTriggerMethodGot_72() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnParticleTriggerMethodGot_72)); }
	inline bool get_mOnParticleTriggerMethodGot_72() const { return ___mOnParticleTriggerMethodGot_72; }
	inline bool* get_address_of_mOnParticleTriggerMethodGot_72() { return &___mOnParticleTriggerMethodGot_72; }
	inline void set_mOnParticleTriggerMethodGot_72(bool value)
	{
		___mOnParticleTriggerMethodGot_72 = value;
	}

	inline static int32_t get_offset_of_mOnPostRenderMethod_73() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnPostRenderMethod_73)); }
	inline RuntimeObject* get_mOnPostRenderMethod_73() const { return ___mOnPostRenderMethod_73; }
	inline RuntimeObject** get_address_of_mOnPostRenderMethod_73() { return &___mOnPostRenderMethod_73; }
	inline void set_mOnPostRenderMethod_73(RuntimeObject* value)
	{
		___mOnPostRenderMethod_73 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnPostRenderMethod_73), (void*)value);
	}

	inline static int32_t get_offset_of_mOnPostRenderMethodGot_74() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnPostRenderMethodGot_74)); }
	inline bool get_mOnPostRenderMethodGot_74() const { return ___mOnPostRenderMethodGot_74; }
	inline bool* get_address_of_mOnPostRenderMethodGot_74() { return &___mOnPostRenderMethodGot_74; }
	inline void set_mOnPostRenderMethodGot_74(bool value)
	{
		___mOnPostRenderMethodGot_74 = value;
	}

	inline static int32_t get_offset_of_mOnPreCullMethod_75() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnPreCullMethod_75)); }
	inline RuntimeObject* get_mOnPreCullMethod_75() const { return ___mOnPreCullMethod_75; }
	inline RuntimeObject** get_address_of_mOnPreCullMethod_75() { return &___mOnPreCullMethod_75; }
	inline void set_mOnPreCullMethod_75(RuntimeObject* value)
	{
		___mOnPreCullMethod_75 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnPreCullMethod_75), (void*)value);
	}

	inline static int32_t get_offset_of_mOnPreCullMethodGot_76() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnPreCullMethodGot_76)); }
	inline bool get_mOnPreCullMethodGot_76() const { return ___mOnPreCullMethodGot_76; }
	inline bool* get_address_of_mOnPreCullMethodGot_76() { return &___mOnPreCullMethodGot_76; }
	inline void set_mOnPreCullMethodGot_76(bool value)
	{
		___mOnPreCullMethodGot_76 = value;
	}

	inline static int32_t get_offset_of_mOnPreRenderMethod_77() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnPreRenderMethod_77)); }
	inline RuntimeObject* get_mOnPreRenderMethod_77() const { return ___mOnPreRenderMethod_77; }
	inline RuntimeObject** get_address_of_mOnPreRenderMethod_77() { return &___mOnPreRenderMethod_77; }
	inline void set_mOnPreRenderMethod_77(RuntimeObject* value)
	{
		___mOnPreRenderMethod_77 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnPreRenderMethod_77), (void*)value);
	}

	inline static int32_t get_offset_of_mOnPreRenderMethodGot_78() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnPreRenderMethodGot_78)); }
	inline bool get_mOnPreRenderMethodGot_78() const { return ___mOnPreRenderMethodGot_78; }
	inline bool* get_address_of_mOnPreRenderMethodGot_78() { return &___mOnPreRenderMethodGot_78; }
	inline void set_mOnPreRenderMethodGot_78(bool value)
	{
		___mOnPreRenderMethodGot_78 = value;
	}

	inline static int32_t get_offset_of_mOnRenderImageMethod_79() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnRenderImageMethod_79)); }
	inline RuntimeObject* get_mOnRenderImageMethod_79() const { return ___mOnRenderImageMethod_79; }
	inline RuntimeObject** get_address_of_mOnRenderImageMethod_79() { return &___mOnRenderImageMethod_79; }
	inline void set_mOnRenderImageMethod_79(RuntimeObject* value)
	{
		___mOnRenderImageMethod_79 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnRenderImageMethod_79), (void*)value);
	}

	inline static int32_t get_offset_of_mOnRenderImageMethodGot_80() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnRenderImageMethodGot_80)); }
	inline bool get_mOnRenderImageMethodGot_80() const { return ___mOnRenderImageMethodGot_80; }
	inline bool* get_address_of_mOnRenderImageMethodGot_80() { return &___mOnRenderImageMethodGot_80; }
	inline void set_mOnRenderImageMethodGot_80(bool value)
	{
		___mOnRenderImageMethodGot_80 = value;
	}

	inline static int32_t get_offset_of_mOnRenderObjectMethod_81() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnRenderObjectMethod_81)); }
	inline RuntimeObject* get_mOnRenderObjectMethod_81() const { return ___mOnRenderObjectMethod_81; }
	inline RuntimeObject** get_address_of_mOnRenderObjectMethod_81() { return &___mOnRenderObjectMethod_81; }
	inline void set_mOnRenderObjectMethod_81(RuntimeObject* value)
	{
		___mOnRenderObjectMethod_81 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnRenderObjectMethod_81), (void*)value);
	}

	inline static int32_t get_offset_of_mOnRenderObjectMethodGot_82() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnRenderObjectMethodGot_82)); }
	inline bool get_mOnRenderObjectMethodGot_82() const { return ___mOnRenderObjectMethodGot_82; }
	inline bool* get_address_of_mOnRenderObjectMethodGot_82() { return &___mOnRenderObjectMethodGot_82; }
	inline void set_mOnRenderObjectMethodGot_82(bool value)
	{
		___mOnRenderObjectMethodGot_82 = value;
	}

	inline static int32_t get_offset_of_mOnServerInitializedMethod_83() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnServerInitializedMethod_83)); }
	inline RuntimeObject* get_mOnServerInitializedMethod_83() const { return ___mOnServerInitializedMethod_83; }
	inline RuntimeObject** get_address_of_mOnServerInitializedMethod_83() { return &___mOnServerInitializedMethod_83; }
	inline void set_mOnServerInitializedMethod_83(RuntimeObject* value)
	{
		___mOnServerInitializedMethod_83 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnServerInitializedMethod_83), (void*)value);
	}

	inline static int32_t get_offset_of_mOnServerInitializedMethodGot_84() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnServerInitializedMethodGot_84)); }
	inline bool get_mOnServerInitializedMethodGot_84() const { return ___mOnServerInitializedMethodGot_84; }
	inline bool* get_address_of_mOnServerInitializedMethodGot_84() { return &___mOnServerInitializedMethodGot_84; }
	inline void set_mOnServerInitializedMethodGot_84(bool value)
	{
		___mOnServerInitializedMethodGot_84 = value;
	}

	inline static int32_t get_offset_of_mOnAnimatorIKMethod_85() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnAnimatorIKMethod_85)); }
	inline RuntimeObject* get_mOnAnimatorIKMethod_85() const { return ___mOnAnimatorIKMethod_85; }
	inline RuntimeObject** get_address_of_mOnAnimatorIKMethod_85() { return &___mOnAnimatorIKMethod_85; }
	inline void set_mOnAnimatorIKMethod_85(RuntimeObject* value)
	{
		___mOnAnimatorIKMethod_85 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnAnimatorIKMethod_85), (void*)value);
	}

	inline static int32_t get_offset_of_mOnAnimatorIKMethodGot_86() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnAnimatorIKMethodGot_86)); }
	inline bool get_mOnAnimatorIKMethodGot_86() const { return ___mOnAnimatorIKMethodGot_86; }
	inline bool* get_address_of_mOnAnimatorIKMethodGot_86() { return &___mOnAnimatorIKMethodGot_86; }
	inline void set_mOnAnimatorIKMethodGot_86(bool value)
	{
		___mOnAnimatorIKMethodGot_86 = value;
	}

	inline static int32_t get_offset_of_mOnAudioFilterReadMethod_87() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnAudioFilterReadMethod_87)); }
	inline RuntimeObject* get_mOnAudioFilterReadMethod_87() const { return ___mOnAudioFilterReadMethod_87; }
	inline RuntimeObject** get_address_of_mOnAudioFilterReadMethod_87() { return &___mOnAudioFilterReadMethod_87; }
	inline void set_mOnAudioFilterReadMethod_87(RuntimeObject* value)
	{
		___mOnAudioFilterReadMethod_87 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnAudioFilterReadMethod_87), (void*)value);
	}

	inline static int32_t get_offset_of_mOnAudioFilterReadMethodGot_88() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnAudioFilterReadMethodGot_88)); }
	inline bool get_mOnAudioFilterReadMethodGot_88() const { return ___mOnAudioFilterReadMethodGot_88; }
	inline bool* get_address_of_mOnAudioFilterReadMethodGot_88() { return &___mOnAudioFilterReadMethodGot_88; }
	inline void set_mOnAudioFilterReadMethodGot_88(bool value)
	{
		___mOnAudioFilterReadMethodGot_88 = value;
	}

	inline static int32_t get_offset_of_mOnCanvasGroupChangedMethod_89() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCanvasGroupChangedMethod_89)); }
	inline RuntimeObject* get_mOnCanvasGroupChangedMethod_89() const { return ___mOnCanvasGroupChangedMethod_89; }
	inline RuntimeObject** get_address_of_mOnCanvasGroupChangedMethod_89() { return &___mOnCanvasGroupChangedMethod_89; }
	inline void set_mOnCanvasGroupChangedMethod_89(RuntimeObject* value)
	{
		___mOnCanvasGroupChangedMethod_89 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnCanvasGroupChangedMethod_89), (void*)value);
	}

	inline static int32_t get_offset_of_mOnCanvasGroupChangedMethodGot_90() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCanvasGroupChangedMethodGot_90)); }
	inline bool get_mOnCanvasGroupChangedMethodGot_90() const { return ___mOnCanvasGroupChangedMethodGot_90; }
	inline bool* get_address_of_mOnCanvasGroupChangedMethodGot_90() { return &___mOnCanvasGroupChangedMethodGot_90; }
	inline void set_mOnCanvasGroupChangedMethodGot_90(bool value)
	{
		___mOnCanvasGroupChangedMethodGot_90 = value;
	}

	inline static int32_t get_offset_of_mOnCanvasHierarchyChangedMethod_91() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCanvasHierarchyChangedMethod_91)); }
	inline RuntimeObject* get_mOnCanvasHierarchyChangedMethod_91() const { return ___mOnCanvasHierarchyChangedMethod_91; }
	inline RuntimeObject** get_address_of_mOnCanvasHierarchyChangedMethod_91() { return &___mOnCanvasHierarchyChangedMethod_91; }
	inline void set_mOnCanvasHierarchyChangedMethod_91(RuntimeObject* value)
	{
		___mOnCanvasHierarchyChangedMethod_91 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnCanvasHierarchyChangedMethod_91), (void*)value);
	}

	inline static int32_t get_offset_of_mOnCanvasHierarchyChangedMethodGot_92() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCanvasHierarchyChangedMethodGot_92)); }
	inline bool get_mOnCanvasHierarchyChangedMethodGot_92() const { return ___mOnCanvasHierarchyChangedMethodGot_92; }
	inline bool* get_address_of_mOnCanvasHierarchyChangedMethodGot_92() { return &___mOnCanvasHierarchyChangedMethodGot_92; }
	inline void set_mOnCanvasHierarchyChangedMethodGot_92(bool value)
	{
		___mOnCanvasHierarchyChangedMethodGot_92 = value;
	}

	inline static int32_t get_offset_of_mOnCollisionEnter2DMethod_93() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionEnter2DMethod_93)); }
	inline RuntimeObject* get_mOnCollisionEnter2DMethod_93() const { return ___mOnCollisionEnter2DMethod_93; }
	inline RuntimeObject** get_address_of_mOnCollisionEnter2DMethod_93() { return &___mOnCollisionEnter2DMethod_93; }
	inline void set_mOnCollisionEnter2DMethod_93(RuntimeObject* value)
	{
		___mOnCollisionEnter2DMethod_93 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnCollisionEnter2DMethod_93), (void*)value);
	}

	inline static int32_t get_offset_of_mOnCollisionEnter2DMethodGot_94() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionEnter2DMethodGot_94)); }
	inline bool get_mOnCollisionEnter2DMethodGot_94() const { return ___mOnCollisionEnter2DMethodGot_94; }
	inline bool* get_address_of_mOnCollisionEnter2DMethodGot_94() { return &___mOnCollisionEnter2DMethodGot_94; }
	inline void set_mOnCollisionEnter2DMethodGot_94(bool value)
	{
		___mOnCollisionEnter2DMethodGot_94 = value;
	}

	inline static int32_t get_offset_of_mOnCollisionExit2DMethod_95() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionExit2DMethod_95)); }
	inline RuntimeObject* get_mOnCollisionExit2DMethod_95() const { return ___mOnCollisionExit2DMethod_95; }
	inline RuntimeObject** get_address_of_mOnCollisionExit2DMethod_95() { return &___mOnCollisionExit2DMethod_95; }
	inline void set_mOnCollisionExit2DMethod_95(RuntimeObject* value)
	{
		___mOnCollisionExit2DMethod_95 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnCollisionExit2DMethod_95), (void*)value);
	}

	inline static int32_t get_offset_of_mOnCollisionExit2DMethodGot_96() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionExit2DMethodGot_96)); }
	inline bool get_mOnCollisionExit2DMethodGot_96() const { return ___mOnCollisionExit2DMethodGot_96; }
	inline bool* get_address_of_mOnCollisionExit2DMethodGot_96() { return &___mOnCollisionExit2DMethodGot_96; }
	inline void set_mOnCollisionExit2DMethodGot_96(bool value)
	{
		___mOnCollisionExit2DMethodGot_96 = value;
	}

	inline static int32_t get_offset_of_mOnCollisionStay2DMethod_97() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionStay2DMethod_97)); }
	inline RuntimeObject* get_mOnCollisionStay2DMethod_97() const { return ___mOnCollisionStay2DMethod_97; }
	inline RuntimeObject** get_address_of_mOnCollisionStay2DMethod_97() { return &___mOnCollisionStay2DMethod_97; }
	inline void set_mOnCollisionStay2DMethod_97(RuntimeObject* value)
	{
		___mOnCollisionStay2DMethod_97 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnCollisionStay2DMethod_97), (void*)value);
	}

	inline static int32_t get_offset_of_mOnCollisionStay2DMethodGot_98() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnCollisionStay2DMethodGot_98)); }
	inline bool get_mOnCollisionStay2DMethodGot_98() const { return ___mOnCollisionStay2DMethodGot_98; }
	inline bool* get_address_of_mOnCollisionStay2DMethodGot_98() { return &___mOnCollisionStay2DMethodGot_98; }
	inline void set_mOnCollisionStay2DMethodGot_98(bool value)
	{
		___mOnCollisionStay2DMethodGot_98 = value;
	}

	inline static int32_t get_offset_of_mOnConnectedToServerMethod_99() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnConnectedToServerMethod_99)); }
	inline RuntimeObject* get_mOnConnectedToServerMethod_99() const { return ___mOnConnectedToServerMethod_99; }
	inline RuntimeObject** get_address_of_mOnConnectedToServerMethod_99() { return &___mOnConnectedToServerMethod_99; }
	inline void set_mOnConnectedToServerMethod_99(RuntimeObject* value)
	{
		___mOnConnectedToServerMethod_99 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnConnectedToServerMethod_99), (void*)value);
	}

	inline static int32_t get_offset_of_mOnConnectedToServerMethodGot_100() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnConnectedToServerMethodGot_100)); }
	inline bool get_mOnConnectedToServerMethodGot_100() const { return ___mOnConnectedToServerMethodGot_100; }
	inline bool* get_address_of_mOnConnectedToServerMethodGot_100() { return &___mOnConnectedToServerMethodGot_100; }
	inline void set_mOnConnectedToServerMethodGot_100(bool value)
	{
		___mOnConnectedToServerMethodGot_100 = value;
	}

	inline static int32_t get_offset_of_mOnControllerColliderHitMethod_101() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnControllerColliderHitMethod_101)); }
	inline RuntimeObject* get_mOnControllerColliderHitMethod_101() const { return ___mOnControllerColliderHitMethod_101; }
	inline RuntimeObject** get_address_of_mOnControllerColliderHitMethod_101() { return &___mOnControllerColliderHitMethod_101; }
	inline void set_mOnControllerColliderHitMethod_101(RuntimeObject* value)
	{
		___mOnControllerColliderHitMethod_101 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnControllerColliderHitMethod_101), (void*)value);
	}

	inline static int32_t get_offset_of_mOnControllerColliderHitMethodGot_102() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnControllerColliderHitMethodGot_102)); }
	inline bool get_mOnControllerColliderHitMethodGot_102() const { return ___mOnControllerColliderHitMethodGot_102; }
	inline bool* get_address_of_mOnControllerColliderHitMethodGot_102() { return &___mOnControllerColliderHitMethodGot_102; }
	inline void set_mOnControllerColliderHitMethodGot_102(bool value)
	{
		___mOnControllerColliderHitMethodGot_102 = value;
	}

	inline static int32_t get_offset_of_mOnDrawGizmosSelectedMethod_103() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnDrawGizmosSelectedMethod_103)); }
	inline RuntimeObject* get_mOnDrawGizmosSelectedMethod_103() const { return ___mOnDrawGizmosSelectedMethod_103; }
	inline RuntimeObject** get_address_of_mOnDrawGizmosSelectedMethod_103() { return &___mOnDrawGizmosSelectedMethod_103; }
	inline void set_mOnDrawGizmosSelectedMethod_103(RuntimeObject* value)
	{
		___mOnDrawGizmosSelectedMethod_103 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnDrawGizmosSelectedMethod_103), (void*)value);
	}

	inline static int32_t get_offset_of_mOnDrawGizmosSelectedMethodGot_104() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnDrawGizmosSelectedMethodGot_104)); }
	inline bool get_mOnDrawGizmosSelectedMethodGot_104() const { return ___mOnDrawGizmosSelectedMethodGot_104; }
	inline bool* get_address_of_mOnDrawGizmosSelectedMethodGot_104() { return &___mOnDrawGizmosSelectedMethodGot_104; }
	inline void set_mOnDrawGizmosSelectedMethodGot_104(bool value)
	{
		___mOnDrawGizmosSelectedMethodGot_104 = value;
	}

	inline static int32_t get_offset_of_mOnGUIMethod_105() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnGUIMethod_105)); }
	inline RuntimeObject* get_mOnGUIMethod_105() const { return ___mOnGUIMethod_105; }
	inline RuntimeObject** get_address_of_mOnGUIMethod_105() { return &___mOnGUIMethod_105; }
	inline void set_mOnGUIMethod_105(RuntimeObject* value)
	{
		___mOnGUIMethod_105 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnGUIMethod_105), (void*)value);
	}

	inline static int32_t get_offset_of_mOnGUIMethodGot_106() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnGUIMethodGot_106)); }
	inline bool get_mOnGUIMethodGot_106() const { return ___mOnGUIMethodGot_106; }
	inline bool* get_address_of_mOnGUIMethodGot_106() { return &___mOnGUIMethodGot_106; }
	inline void set_mOnGUIMethodGot_106(bool value)
	{
		___mOnGUIMethodGot_106 = value;
	}

	inline static int32_t get_offset_of_mOnJointBreak2DMethod_107() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnJointBreak2DMethod_107)); }
	inline RuntimeObject* get_mOnJointBreak2DMethod_107() const { return ___mOnJointBreak2DMethod_107; }
	inline RuntimeObject** get_address_of_mOnJointBreak2DMethod_107() { return &___mOnJointBreak2DMethod_107; }
	inline void set_mOnJointBreak2DMethod_107(RuntimeObject* value)
	{
		___mOnJointBreak2DMethod_107 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnJointBreak2DMethod_107), (void*)value);
	}

	inline static int32_t get_offset_of_mOnJointBreak2DMethodGot_108() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnJointBreak2DMethodGot_108)); }
	inline bool get_mOnJointBreak2DMethodGot_108() const { return ___mOnJointBreak2DMethodGot_108; }
	inline bool* get_address_of_mOnJointBreak2DMethodGot_108() { return &___mOnJointBreak2DMethodGot_108; }
	inline void set_mOnJointBreak2DMethodGot_108(bool value)
	{
		___mOnJointBreak2DMethodGot_108 = value;
	}

	inline static int32_t get_offset_of_mOnParticleSystemStoppedMethod_109() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnParticleSystemStoppedMethod_109)); }
	inline RuntimeObject* get_mOnParticleSystemStoppedMethod_109() const { return ___mOnParticleSystemStoppedMethod_109; }
	inline RuntimeObject** get_address_of_mOnParticleSystemStoppedMethod_109() { return &___mOnParticleSystemStoppedMethod_109; }
	inline void set_mOnParticleSystemStoppedMethod_109(RuntimeObject* value)
	{
		___mOnParticleSystemStoppedMethod_109 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnParticleSystemStoppedMethod_109), (void*)value);
	}

	inline static int32_t get_offset_of_mOnParticleSystemStoppedMethodGot_110() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnParticleSystemStoppedMethodGot_110)); }
	inline bool get_mOnParticleSystemStoppedMethodGot_110() const { return ___mOnParticleSystemStoppedMethodGot_110; }
	inline bool* get_address_of_mOnParticleSystemStoppedMethodGot_110() { return &___mOnParticleSystemStoppedMethodGot_110; }
	inline void set_mOnParticleSystemStoppedMethodGot_110(bool value)
	{
		___mOnParticleSystemStoppedMethodGot_110 = value;
	}

	inline static int32_t get_offset_of_mOnTransformChildrenChangedMethod_111() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTransformChildrenChangedMethod_111)); }
	inline RuntimeObject* get_mOnTransformChildrenChangedMethod_111() const { return ___mOnTransformChildrenChangedMethod_111; }
	inline RuntimeObject** get_address_of_mOnTransformChildrenChangedMethod_111() { return &___mOnTransformChildrenChangedMethod_111; }
	inline void set_mOnTransformChildrenChangedMethod_111(RuntimeObject* value)
	{
		___mOnTransformChildrenChangedMethod_111 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnTransformChildrenChangedMethod_111), (void*)value);
	}

	inline static int32_t get_offset_of_mOnTransformChildrenChangedMethodGot_112() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTransformChildrenChangedMethodGot_112)); }
	inline bool get_mOnTransformChildrenChangedMethodGot_112() const { return ___mOnTransformChildrenChangedMethodGot_112; }
	inline bool* get_address_of_mOnTransformChildrenChangedMethodGot_112() { return &___mOnTransformChildrenChangedMethodGot_112; }
	inline void set_mOnTransformChildrenChangedMethodGot_112(bool value)
	{
		___mOnTransformChildrenChangedMethodGot_112 = value;
	}

	inline static int32_t get_offset_of_mOnTransformParentChangedMethod_113() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTransformParentChangedMethod_113)); }
	inline RuntimeObject* get_mOnTransformParentChangedMethod_113() const { return ___mOnTransformParentChangedMethod_113; }
	inline RuntimeObject** get_address_of_mOnTransformParentChangedMethod_113() { return &___mOnTransformParentChangedMethod_113; }
	inline void set_mOnTransformParentChangedMethod_113(RuntimeObject* value)
	{
		___mOnTransformParentChangedMethod_113 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnTransformParentChangedMethod_113), (void*)value);
	}

	inline static int32_t get_offset_of_mOnTransformParentChangedMethodGot_114() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTransformParentChangedMethodGot_114)); }
	inline bool get_mOnTransformParentChangedMethodGot_114() const { return ___mOnTransformParentChangedMethodGot_114; }
	inline bool* get_address_of_mOnTransformParentChangedMethodGot_114() { return &___mOnTransformParentChangedMethodGot_114; }
	inline void set_mOnTransformParentChangedMethodGot_114(bool value)
	{
		___mOnTransformParentChangedMethodGot_114 = value;
	}

	inline static int32_t get_offset_of_mOnTriggerEnter2DMethod_115() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerEnter2DMethod_115)); }
	inline RuntimeObject* get_mOnTriggerEnter2DMethod_115() const { return ___mOnTriggerEnter2DMethod_115; }
	inline RuntimeObject** get_address_of_mOnTriggerEnter2DMethod_115() { return &___mOnTriggerEnter2DMethod_115; }
	inline void set_mOnTriggerEnter2DMethod_115(RuntimeObject* value)
	{
		___mOnTriggerEnter2DMethod_115 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnTriggerEnter2DMethod_115), (void*)value);
	}

	inline static int32_t get_offset_of_mOnTriggerEnter2DMethodGot_116() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerEnter2DMethodGot_116)); }
	inline bool get_mOnTriggerEnter2DMethodGot_116() const { return ___mOnTriggerEnter2DMethodGot_116; }
	inline bool* get_address_of_mOnTriggerEnter2DMethodGot_116() { return &___mOnTriggerEnter2DMethodGot_116; }
	inline void set_mOnTriggerEnter2DMethodGot_116(bool value)
	{
		___mOnTriggerEnter2DMethodGot_116 = value;
	}

	inline static int32_t get_offset_of_mOnTriggerExit2DMethod_117() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerExit2DMethod_117)); }
	inline RuntimeObject* get_mOnTriggerExit2DMethod_117() const { return ___mOnTriggerExit2DMethod_117; }
	inline RuntimeObject** get_address_of_mOnTriggerExit2DMethod_117() { return &___mOnTriggerExit2DMethod_117; }
	inline void set_mOnTriggerExit2DMethod_117(RuntimeObject* value)
	{
		___mOnTriggerExit2DMethod_117 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnTriggerExit2DMethod_117), (void*)value);
	}

	inline static int32_t get_offset_of_mOnTriggerExit2DMethodGot_118() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerExit2DMethodGot_118)); }
	inline bool get_mOnTriggerExit2DMethodGot_118() const { return ___mOnTriggerExit2DMethodGot_118; }
	inline bool* get_address_of_mOnTriggerExit2DMethodGot_118() { return &___mOnTriggerExit2DMethodGot_118; }
	inline void set_mOnTriggerExit2DMethodGot_118(bool value)
	{
		___mOnTriggerExit2DMethodGot_118 = value;
	}

	inline static int32_t get_offset_of_mOnTriggerStay2DMethod_119() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerStay2DMethod_119)); }
	inline RuntimeObject* get_mOnTriggerStay2DMethod_119() const { return ___mOnTriggerStay2DMethod_119; }
	inline RuntimeObject** get_address_of_mOnTriggerStay2DMethod_119() { return &___mOnTriggerStay2DMethod_119; }
	inline void set_mOnTriggerStay2DMethod_119(RuntimeObject* value)
	{
		___mOnTriggerStay2DMethod_119 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnTriggerStay2DMethod_119), (void*)value);
	}

	inline static int32_t get_offset_of_mOnTriggerStay2DMethodGot_120() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnTriggerStay2DMethodGot_120)); }
	inline bool get_mOnTriggerStay2DMethodGot_120() const { return ___mOnTriggerStay2DMethodGot_120; }
	inline bool* get_address_of_mOnTriggerStay2DMethodGot_120() { return &___mOnTriggerStay2DMethodGot_120; }
	inline void set_mOnTriggerStay2DMethodGot_120(bool value)
	{
		___mOnTriggerStay2DMethodGot_120 = value;
	}

	inline static int32_t get_offset_of_mOnWillRenderObjectMethod_121() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnWillRenderObjectMethod_121)); }
	inline RuntimeObject* get_mOnWillRenderObjectMethod_121() const { return ___mOnWillRenderObjectMethod_121; }
	inline RuntimeObject** get_address_of_mOnWillRenderObjectMethod_121() { return &___mOnWillRenderObjectMethod_121; }
	inline void set_mOnWillRenderObjectMethod_121(RuntimeObject* value)
	{
		___mOnWillRenderObjectMethod_121 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnWillRenderObjectMethod_121), (void*)value);
	}

	inline static int32_t get_offset_of_mOnWillRenderObjectMethodGot_122() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnWillRenderObjectMethodGot_122)); }
	inline bool get_mOnWillRenderObjectMethodGot_122() const { return ___mOnWillRenderObjectMethodGot_122; }
	inline bool* get_address_of_mOnWillRenderObjectMethodGot_122() { return &___mOnWillRenderObjectMethodGot_122; }
	inline void set_mOnWillRenderObjectMethodGot_122(bool value)
	{
		___mOnWillRenderObjectMethodGot_122 = value;
	}

	inline static int32_t get_offset_of_mOnBeforeTransformParentChangedMethod_123() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnBeforeTransformParentChangedMethod_123)); }
	inline RuntimeObject* get_mOnBeforeTransformParentChangedMethod_123() const { return ___mOnBeforeTransformParentChangedMethod_123; }
	inline RuntimeObject** get_address_of_mOnBeforeTransformParentChangedMethod_123() { return &___mOnBeforeTransformParentChangedMethod_123; }
	inline void set_mOnBeforeTransformParentChangedMethod_123(RuntimeObject* value)
	{
		___mOnBeforeTransformParentChangedMethod_123 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnBeforeTransformParentChangedMethod_123), (void*)value);
	}

	inline static int32_t get_offset_of_mOnBeforeTransformParentChangedMethodGot_124() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnBeforeTransformParentChangedMethodGot_124)); }
	inline bool get_mOnBeforeTransformParentChangedMethodGot_124() const { return ___mOnBeforeTransformParentChangedMethodGot_124; }
	inline bool* get_address_of_mOnBeforeTransformParentChangedMethodGot_124() { return &___mOnBeforeTransformParentChangedMethodGot_124; }
	inline void set_mOnBeforeTransformParentChangedMethodGot_124(bool value)
	{
		___mOnBeforeTransformParentChangedMethodGot_124 = value;
	}

	inline static int32_t get_offset_of_mOnDidApplyAnimationPropertiesMethod_125() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnDidApplyAnimationPropertiesMethod_125)); }
	inline RuntimeObject* get_mOnDidApplyAnimationPropertiesMethod_125() const { return ___mOnDidApplyAnimationPropertiesMethod_125; }
	inline RuntimeObject** get_address_of_mOnDidApplyAnimationPropertiesMethod_125() { return &___mOnDidApplyAnimationPropertiesMethod_125; }
	inline void set_mOnDidApplyAnimationPropertiesMethod_125(RuntimeObject* value)
	{
		___mOnDidApplyAnimationPropertiesMethod_125 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnDidApplyAnimationPropertiesMethod_125), (void*)value);
	}

	inline static int32_t get_offset_of_mOnDidApplyAnimationPropertiesMethodGot_126() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnDidApplyAnimationPropertiesMethodGot_126)); }
	inline bool get_mOnDidApplyAnimationPropertiesMethodGot_126() const { return ___mOnDidApplyAnimationPropertiesMethodGot_126; }
	inline bool* get_address_of_mOnDidApplyAnimationPropertiesMethodGot_126() { return &___mOnDidApplyAnimationPropertiesMethodGot_126; }
	inline void set_mOnDidApplyAnimationPropertiesMethodGot_126(bool value)
	{
		___mOnDidApplyAnimationPropertiesMethodGot_126 = value;
	}

	inline static int32_t get_offset_of_mOnMouseUpAsButtonMethod_127() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseUpAsButtonMethod_127)); }
	inline RuntimeObject* get_mOnMouseUpAsButtonMethod_127() const { return ___mOnMouseUpAsButtonMethod_127; }
	inline RuntimeObject** get_address_of_mOnMouseUpAsButtonMethod_127() { return &___mOnMouseUpAsButtonMethod_127; }
	inline void set_mOnMouseUpAsButtonMethod_127(RuntimeObject* value)
	{
		___mOnMouseUpAsButtonMethod_127 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnMouseUpAsButtonMethod_127), (void*)value);
	}

	inline static int32_t get_offset_of_mOnMouseUpAsButtonMethodGot_128() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnMouseUpAsButtonMethodGot_128)); }
	inline bool get_mOnMouseUpAsButtonMethodGot_128() const { return ___mOnMouseUpAsButtonMethodGot_128; }
	inline bool* get_address_of_mOnMouseUpAsButtonMethodGot_128() { return &___mOnMouseUpAsButtonMethodGot_128; }
	inline void set_mOnMouseUpAsButtonMethodGot_128(bool value)
	{
		___mOnMouseUpAsButtonMethodGot_128 = value;
	}

	inline static int32_t get_offset_of_mOnParticleUpdateJobScheduledMethod_129() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnParticleUpdateJobScheduledMethod_129)); }
	inline RuntimeObject* get_mOnParticleUpdateJobScheduledMethod_129() const { return ___mOnParticleUpdateJobScheduledMethod_129; }
	inline RuntimeObject** get_address_of_mOnParticleUpdateJobScheduledMethod_129() { return &___mOnParticleUpdateJobScheduledMethod_129; }
	inline void set_mOnParticleUpdateJobScheduledMethod_129(RuntimeObject* value)
	{
		___mOnParticleUpdateJobScheduledMethod_129 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnParticleUpdateJobScheduledMethod_129), (void*)value);
	}

	inline static int32_t get_offset_of_mOnParticleUpdateJobScheduledMethodGot_130() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnParticleUpdateJobScheduledMethodGot_130)); }
	inline bool get_mOnParticleUpdateJobScheduledMethodGot_130() const { return ___mOnParticleUpdateJobScheduledMethodGot_130; }
	inline bool* get_address_of_mOnParticleUpdateJobScheduledMethodGot_130() { return &___mOnParticleUpdateJobScheduledMethodGot_130; }
	inline void set_mOnParticleUpdateJobScheduledMethodGot_130(bool value)
	{
		___mOnParticleUpdateJobScheduledMethodGot_130 = value;
	}

	inline static int32_t get_offset_of_mOnRectTransformDimensionsChangeMethod_131() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnRectTransformDimensionsChangeMethod_131)); }
	inline RuntimeObject* get_mOnRectTransformDimensionsChangeMethod_131() const { return ___mOnRectTransformDimensionsChangeMethod_131; }
	inline RuntimeObject** get_address_of_mOnRectTransformDimensionsChangeMethod_131() { return &___mOnRectTransformDimensionsChangeMethod_131; }
	inline void set_mOnRectTransformDimensionsChangeMethod_131(RuntimeObject* value)
	{
		___mOnRectTransformDimensionsChangeMethod_131 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mOnRectTransformDimensionsChangeMethod_131), (void*)value);
	}

	inline static int32_t get_offset_of_mOnRectTransformDimensionsChangeMethodGot_132() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mOnRectTransformDimensionsChangeMethodGot_132)); }
	inline bool get_mOnRectTransformDimensionsChangeMethodGot_132() const { return ___mOnRectTransformDimensionsChangeMethodGot_132; }
	inline bool* get_address_of_mOnRectTransformDimensionsChangeMethodGot_132() { return &___mOnRectTransformDimensionsChangeMethodGot_132; }
	inline void set_mOnRectTransformDimensionsChangeMethodGot_132(bool value)
	{
		___mOnRectTransformDimensionsChangeMethodGot_132 = value;
	}

	inline static int32_t get_offset_of_mToStringMethod_133() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mToStringMethod_133)); }
	inline RuntimeObject* get_mToStringMethod_133() const { return ___mToStringMethod_133; }
	inline RuntimeObject** get_address_of_mToStringMethod_133() { return &___mToStringMethod_133; }
	inline void set_mToStringMethod_133(RuntimeObject* value)
	{
		___mToStringMethod_133 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mToStringMethod_133), (void*)value);
	}

	inline static int32_t get_offset_of_mToStringMethodGot_134() { return static_cast<int32_t>(offsetof(Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11, ___mToStringMethodGot_134)); }
	inline bool get_mToStringMethodGot_134() const { return ___mToStringMethodGot_134; }
	inline bool* get_address_of_mToStringMethodGot_134() { return &___mToStringMethodGot_134; }
	inline void set_mToStringMethodGot_134(bool value)
	{
		___mToStringMethodGot_134 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
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


// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.WChannel/<ConnectAsync>d__13>(!!0&,!!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA_m73E39109983EA3E233B4541A6358DD15797D8F31_gshared (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA * ___stateMachine1, const RuntimeMethod* method);
// System.Void System.ArraySegment`1<System.Byte>::.ctor(!0[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D_gshared (ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___array0, int32_t ___offset1, int32_t ___count2, const RuntimeMethod* method);
// System.Runtime.CompilerServices.TaskAwaiter`1<!0> System.Threading.Tasks.Task`1<System.Object>::GetAwaiter()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE  Task_1_GetAwaiter_m4F5B9EF55874E9959CE12E71ADEAC798960F0FE3_gshared (Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * __this, const RuntimeMethod* method);
// System.Boolean System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>::get_IsCompleted()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TaskAwaiter_1_get_IsCompleted_mEC81351691C5A577A64F3B728036AD979AB3AF94_gshared (TaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE * __this, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>,ET.WChannel/<StartRecv>d__17>(!!0&,!!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m773A01822B0151CB655A97275ECEB2A7E64B09B3_gshared (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE * ___awaiter0, U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * ___stateMachine1, const RuntimeMethod* method);
// !0 System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>::GetResult()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * TaskAwaiter_1_GetResult_m7703A30E4F4EA17FBA4243DE1BF9412521B2AFDA_gshared (TaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE * __this, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.WChannel/<StartRecv>d__17>(!!0&,!!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m6FB0816A8B00FD9C3EDC5827C4A2E97FF700B397_gshared (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * ___stateMachine1, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.Queue`1<System.Object>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Queue_1_get_Count_mD618588C9785F06D043BE6AAD0A0B8116B2A77A3_gshared_inline (Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.Queue`1<System.Object>::Dequeue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Queue_1_Dequeue_mE9A2A69E86A7EDA9FBCEA675542F01A6D8677A14_gshared (Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64 * __this, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.WChannel/<StartSend>d__15>(!!0&,!!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162_mF0CD29EE2B7DAEB89BF469B893F9CD822C6DD7C1_gshared (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 * ___stateMachine1, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter`1<System.Object>,ET.WService/<StartAccept>d__12>(!!0&,!!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_m20852DC509D70264075AE5026F1032036856A457_gshared (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE * ___awaiter0, U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * ___stateMachine1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int64,System.Object>::set_Item(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_m18814ACD68689D7E74739B3C97A18BD6DC76E855_gshared (Dictionary_2_t240BB5F785CC3B2A17B14447F3C0E0BB6AAB8E26 * __this, int64_t ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18>(!!0&,!!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D_mADD06B426C3D8B131B2D9AF08601BAB40AE72515_gshared (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D * ___stateMachine1, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.MonoBehaviourAdapter/Adaptor/<Start>d__21>(!!0&,!!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F_mC22F9B7E118032FDAE087379683D6E4516C0BFC3_gshared (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F * ___stateMachine1, const RuntimeMethod* method);

// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void ILRuntime.Runtime.Enviorment.AppDomain::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppDomain__ctor_m408804551D2A00426FCA0228FB862BF0D5033E0A (AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * __this, int32_t ___defaultJITFlags0, const RuntimeMethod* method);
// System.String UnityEngine.Application::get_streamingAssetsPath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Application_get_streamingAssetsPath_mA1FBABB08D7A4590A468C7CD940CD442B58C91E1 (const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// System.Void UnityEngine.WWW::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WWW__ctor_mE77AD6C372CC76F48A893C5E2F91A81193A9F8C5 (WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * __this, String_t* ___url0, const RuntimeMethod* method);
// System.Boolean UnityEngine.WWW::get_isDone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool WWW_get_isDone_m916B54D53395990DB59C64413798FBCAFB08E0E3 (WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * __this, const RuntimeMethod* method);
// System.String UnityEngine.WWW::get_error()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* WWW_get_error_mB278F5EC90EF99FEF70D80112940CFB49E79C9BC (WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * __this, const RuntimeMethod* method);
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C (String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Byte[] UnityEngine.WWW::get_bytes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* WWW_get_bytes_m378FCCD8E91FB7FE7FA22E05BA3FE528CD7EAF1A (WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.WWW::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WWW_Dispose_mF5A8B944281564903043545BC1E7F1CAD941519F (WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * __this, const RuntimeMethod* method);
// System.Void System.IO.MemoryStream::.ctor(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2 (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___buffer0, const RuntimeMethod* method);
// System.Void ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PdbReaderProvider__ctor_m50C615CF0E70F9D7F4866EDA1DDA1D35E9F4927E (PdbReaderProvider_tD6CADF6205DDD9BB74AE340FE5FF73794FD2361C * __this, const RuntimeMethod* method);
// System.Void ILRuntime.Runtime.Enviorment.AppDomain::LoadAssembly(System.IO.Stream,System.IO.Stream,ILRuntime.Mono.Cecil.Cil.ISymbolReaderProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppDomain_LoadAssembly_mB90CAC0CE799D4DFED276766E453CFA72F154D4C (AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___stream0, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___symbol1, RuntimeObject* ___symbolReader2, const RuntimeMethod* method);
// System.Void ValueTypeBindingDemo::InitializeILRuntime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ValueTypeBindingDemo_InitializeILRuntime_m57550517344A6088870F628CF80EDB15F629F896 (ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * __this, const RuntimeMethod* method);
// System.Void UnityEngine.WaitForSeconds::.ctor(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForSeconds__ctor_mD298C4CB9532BBBDE172FC40F3397E30504038D4 (WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * __this, float ___seconds0, const RuntimeMethod* method);
// System.Void ValueTypeBindingDemo::RunTest()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ValueTypeBindingDemo_RunTest_m6ECAEFA1DD1163DFD1720100A9076AA4F8469E30 (ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * __this, const RuntimeMethod* method);
// System.Void ValueTypeBindingDemo::RunTest2()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ValueTypeBindingDemo_RunTest2_m52AE4B7379D659AAFB4D53C2891FDD2A78ED1988 (ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * __this, const RuntimeMethod* method);
// System.Void ValueTypeBindingDemo::RunTest3()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ValueTypeBindingDemo_RunTest3_m666AAE2FCD937E808E5F5B1BBAAA5F3AD3C9D25D (ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * __this, const RuntimeMethod* method);
// System.Void System.NotSupportedException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * __this, const RuntimeMethod* method);
// ET.ETTask ET.WChannel::ConnectAsync(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * WChannel_ConnectAsync_m3BED888E920BDB2B452EFC4FE3FCE47FA3758363 (WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * __this, String_t* ___url0, const RuntimeMethod* method);
// System.Void ET.ETTask::Coroutine()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETTask_Coroutine_m6A9CDCF58772F984C229E45D91CE5D84598738A2 (ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * __this, const RuntimeMethod* method);
// System.Void System.Uri::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Uri__ctor_m7724F43B1525624FFF97A774B6B909B075714D5C (Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * __this, String_t* ___uriString0, const RuntimeMethod* method);
// System.Threading.CancellationToken System.Threading.CancellationTokenSource::get_Token()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  CancellationTokenSource_get_Token_m2A9A82BA3532B89870363E8C1DEAE2F1EFD3962C (CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * __this, const RuntimeMethod* method);
// System.Threading.Tasks.Task System.Net.WebSockets.ClientWebSocket::ConnectAsync(System.Uri,System.Threading.CancellationToken)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * ClientWebSocket_ConnectAsync_m2FF7047AC718D6181EF7E3840543DB645089D72D (ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09 * __this, Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * ___uri0, CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  ___cancellationToken1, const RuntimeMethod* method);
// System.Runtime.CompilerServices.TaskAwaiter System.Threading.Tasks.Task::GetAwaiter()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  Task_GetAwaiter_m1FF7528A8FE13F79207DFE970F642078EF6B1260 (Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * __this, const RuntimeMethod* method);
// System.Boolean System.Runtime.CompilerServices.TaskAwaiter::get_IsCompleted()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TaskAwaiter_get_IsCompleted_m6F97613C55E505B5664C3C0CFC4677D296EAA8BC (TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * __this, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.WChannel/<ConnectAsync>d__13>(!!0&,!!1&)
inline void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA_m73E39109983EA3E233B4541A6358DD15797D8F31 (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA * ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *, U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA *, const RuntimeMethod*))ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA_m73E39109983EA3E233B4541A6358DD15797D8F31_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// System.Void System.Runtime.CompilerServices.TaskAwaiter::GetResult()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TaskAwaiter_GetResult_m578EEFEC4DD1AE5E77C899B8BAA3825EB79D1330 (TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * __this, const RuntimeMethod* method);
// ET.ETTask ET.WChannel::StartRecv()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * WChannel_StartRecv_mBC78B621E242A880F57025CC8B6AFFF174C273BD (WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * __this, const RuntimeMethod* method);
// ET.ETTask ET.WChannel::StartSend()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * WChannel_StartSend_m04D765F133E266B934CF960E838DDCDD979F96B3 (WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * __this, const RuntimeMethod* method);
// System.Void ET.Log::Error(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Log_Error_mC1EB3767E2A28400D0ED5C10C1B0FB83FDF39365 (Exception_t * ___e0, const RuntimeMethod* method);
// System.Void ET.WChannel::OnError(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WChannel_OnError_m268622C0130BB47AD32D04876CFF669E5466CD6E (WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * __this, int32_t ___error0, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::SetException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETAsyncTaskMethodBuilder_SetException_m94B10E7E2F8D77DDE977C587A7444B7EC17DCC71 (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, Exception_t * ___exception0, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::SetResult()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETAsyncTaskMethodBuilder_SetResult_m985BE32D35AB03DC4CE000D8D9A2BFACB8B7A88B (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, const RuntimeMethod* method);
// System.Void ET.WChannel/<ConnectAsync>d__13::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CConnectAsyncU3Ed__13_MoveNext_m6C9E2C896B64BCF28C7011E150404527D621F163 (U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA * __this, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ETAsyncTaskMethodBuilder_SetStateMachine_mFECCC5F702F4D3B9598975007D961FE4D0BFAAC3 (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
// System.Void ET.WChannel/<ConnectAsync>d__13::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CConnectAsyncU3Ed__13_SetStateMachine_m8BE2AB2C8AC652075E318FFEE4DBB3606D3AD9D1 (U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
// System.Boolean ET.AChannel::get_IsDisposed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AChannel_get_IsDisposed_m80F93CAF0E5479EFDB294FB9174D9DBD51C4FAFA (AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432 * __this, const RuntimeMethod* method);
// System.Void System.ArraySegment`1<System.Byte>::.ctor(!0[],System.Int32,System.Int32)
inline void ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D (ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___array0, int32_t ___offset1, int32_t ___count2, const RuntimeMethod* method)
{
	((  void (*) (ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE *, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t, const RuntimeMethod*))ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D_gshared)(__this, ___array0, ___offset1, ___count2, method);
}
// System.Runtime.CompilerServices.TaskAwaiter`1<!0> System.Threading.Tasks.Task`1<System.Net.WebSockets.WebSocketReceiveResult>::GetAwaiter()
inline TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  Task_1_GetAwaiter_m46A488400364A14C5B4A6B616BD7A1BB08927520 (Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E * __this, const RuntimeMethod* method)
{
	return ((  TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  (*) (Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E *, const RuntimeMethod*))Task_1_GetAwaiter_m4F5B9EF55874E9959CE12E71ADEAC798960F0FE3_gshared)(__this, method);
}
// System.Boolean System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.WebSocketReceiveResult>::get_IsCompleted()
inline bool TaskAwaiter_1_get_IsCompleted_m2D13C0370C28B8EA4406A35F0A8BC012DF3C8537 (TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 *, const RuntimeMethod*))TaskAwaiter_1_get_IsCompleted_mEC81351691C5A577A64F3B728036AD979AB3AF94_gshared)(__this, method);
}
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.WebSocketReceiveResult>,ET.WChannel/<StartRecv>d__17>(!!0&,!!1&)
inline void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_mFD39C7F5DE149D2283C6E3634B13E448F6EDD262 (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 * ___awaiter0, U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *, TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 *, U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B *, const RuntimeMethod*))ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m773A01822B0151CB655A97275ECEB2A7E64B09B3_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// !0 System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.WebSocketReceiveResult>::GetResult()
inline WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * TaskAwaiter_1_GetResult_mCDCAAF89F5D74175A37B6E9F507C970EDAF07B97 (TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 * __this, const RuntimeMethod* method)
{
	return ((  WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * (*) (TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 *, const RuntimeMethod*))TaskAwaiter_1_GetResult_m7703A30E4F4EA17FBA4243DE1BF9412521B2AFDA_gshared)(__this, method);
}
// System.Int32 System.Net.WebSockets.WebSocketReceiveResult::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WebSocketReceiveResult_get_Count_m9A22CB095E69E1DE69FDA79295ECC5BE8A147CB9_inline (WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * __this, const RuntimeMethod* method);
// System.Boolean System.Net.WebSockets.WebSocketReceiveResult::get_EndOfMessage()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool WebSocketReceiveResult_get_EndOfMessage_m233182D8ABF49FEE3C82D6C217CAAC5922104F57_inline (WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * __this, const RuntimeMethod* method);
// System.Net.WebSockets.WebSocketMessageType System.Net.WebSockets.WebSocketReceiveResult::get_MessageType()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WebSocketReceiveResult_get_MessageType_mBE189CACCE7DCDC1C5C0CF9873DD3290BC686478_inline (WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * __this, const RuntimeMethod* method);
// System.String System.String::Format(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17 (String_t* ___format0, RuntimeObject * ___arg01, const RuntimeMethod* method);
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.WChannel/<StartRecv>d__17>(!!0&,!!1&)
inline void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m6FB0816A8B00FD9C3EDC5827C4A2E97FF700B397 (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *, U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B *, const RuntimeMethod*))ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m6FB0816A8B00FD9C3EDC5827C4A2E97FF700B397_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// System.Void System.Array::Copy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877 (RuntimeArray * ___sourceArray0, int32_t ___sourceIndex1, RuntimeArray * ___destinationArray2, int32_t ___destinationIndex3, int32_t ___length4, const RuntimeMethod* method);
// System.Void ET.WChannel::OnRead(System.IO.MemoryStream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WChannel_OnRead_m381A0C3EAD0C66840129B57E13B269320DFD0A36 (WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * __this, MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * ___memoryStream0, const RuntimeMethod* method);
// System.Void ET.WChannel/<StartRecv>d__17::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartRecvU3Ed__17_MoveNext_m99A96D91E71703A4B7769BEF21B9501C6701FA2C (U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * __this, const RuntimeMethod* method);
// System.Void ET.WChannel/<StartRecv>d__17::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartRecvU3Ed__17_SetStateMachine_mDFAFE34FF168AE8E3424749DAE476EF91B653303 (U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.Queue`1<System.Byte[]>::get_Count()
inline int32_t Queue_1_get_Count_m1D55723B47270D04849E24BC09480DCD17C0CEBA_inline (Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 *, const RuntimeMethod*))Queue_1_get_Count_mD618588C9785F06D043BE6AAD0A0B8116B2A77A3_gshared_inline)(__this, method);
}
// !0 System.Collections.Generic.Queue`1<System.Byte[]>::Dequeue()
inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* Queue_1_Dequeue_m2EA4ED50C9D3AFC5608B9ACDF7C611D244872F0D (Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 * __this, const RuntimeMethod* method)
{
	return ((  ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* (*) (Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 *, const RuntimeMethod*))Queue_1_Dequeue_mE9A2A69E86A7EDA9FBCEA675542F01A6D8677A14_gshared)(__this, method);
}
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.WChannel/<StartSend>d__15>(!!0&,!!1&)
inline void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162_mF0CD29EE2B7DAEB89BF469B893F9CD822C6DD7C1 (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 * ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *, U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 *, const RuntimeMethod*))ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162_mF0CD29EE2B7DAEB89BF469B893F9CD822C6DD7C1_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// System.Void ET.WChannel/<StartSend>d__15::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartSendU3Ed__15_MoveNext_m5A2FAB35FEF8A1D2638A92B2AF086F6B17ABE055 (U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 * __this, const RuntimeMethod* method);
// System.Void ET.WChannel/<StartSend>d__15::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartSendU3Ed__15_SetStateMachine_m6F79A85253722DF738F762E00AED8BE912EAF268 (U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
// System.Net.HttpListenerPrefixCollection System.Net.HttpListener::get_Prefixes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283 * HttpListener_get_Prefixes_m9632A8FF20E68DC9770668813E57345354144298 (HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * __this, const RuntimeMethod* method);
// System.Void System.Net.HttpListenerPrefixCollection::Add(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HttpListenerPrefixCollection_Add_mC81B7F10D756C258BA242226C9ADF5EFD1A28250 (HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283 * __this, String_t* ___uriPrefix0, const RuntimeMethod* method);
// System.Void System.Net.HttpListener::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HttpListener_Start_m0A043055653F94400CC94661D972C84C30E86043 (HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * __this, const RuntimeMethod* method);
// System.Threading.Tasks.Task`1<System.Net.HttpListenerContext> System.Net.HttpListener::GetContextAsync()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33 * HttpListener_GetContextAsync_m7662749B26AA3702E4B6D4B0A5360EE7A4B95509 (HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * __this, const RuntimeMethod* method);
// System.Runtime.CompilerServices.TaskAwaiter`1<!0> System.Threading.Tasks.Task`1<System.Net.HttpListenerContext>::GetAwaiter()
inline TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  Task_1_GetAwaiter_m03F3C2C642FE0130BAE3F8BBFAB13E7BB19707B3 (Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33 * __this, const RuntimeMethod* method)
{
	return ((  TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  (*) (Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33 *, const RuntimeMethod*))Task_1_GetAwaiter_m4F5B9EF55874E9959CE12E71ADEAC798960F0FE3_gshared)(__this, method);
}
// System.Boolean System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.HttpListenerContext>::get_IsCompleted()
inline bool TaskAwaiter_1_get_IsCompleted_m5407555CDC2063AC7E69154390A144F53D7B370F (TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 *, const RuntimeMethod*))TaskAwaiter_1_get_IsCompleted_mEC81351691C5A577A64F3B728036AD979AB3AF94_gshared)(__this, method);
}
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.HttpListenerContext>,ET.WService/<StartAccept>d__12>(!!0&,!!1&)
inline void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_m70C423FEFD680FB2A62EB0131C67A46D80F73C1F (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 * ___awaiter0, U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *, TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 *, U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE *, const RuntimeMethod*))ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_m20852DC509D70264075AE5026F1032036856A457_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// !0 System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.HttpListenerContext>::GetResult()
inline HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117 * TaskAwaiter_1_GetResult_mCE6EEB08A3F3CD7DA4D0B764AC8A22E5AE8242A8 (TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 * __this, const RuntimeMethod* method)
{
	return ((  HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117 * (*) (TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 *, const RuntimeMethod*))TaskAwaiter_1_GetResult_m7703A30E4F4EA17FBA4243DE1BF9412521B2AFDA_gshared)(__this, method);
}
// System.Threading.Tasks.Task`1<System.Net.WebSockets.HttpListenerWebSocketContext> System.Net.HttpListenerContext::AcceptWebSocketAsync(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC * HttpListenerContext_AcceptWebSocketAsync_m8EA6D4ADE8019B6FF83A9C6332491BDAC762B8EF (HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117 * __this, String_t* ___subProtocol0, const RuntimeMethod* method);
// System.Runtime.CompilerServices.TaskAwaiter`1<!0> System.Threading.Tasks.Task`1<System.Net.WebSockets.HttpListenerWebSocketContext>::GetAwaiter()
inline TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  Task_1_GetAwaiter_m4323D9958B429E8928A9758244674DB503E63EF4 (Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC * __this, const RuntimeMethod* method)
{
	return ((  TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  (*) (Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC *, const RuntimeMethod*))Task_1_GetAwaiter_m4F5B9EF55874E9959CE12E71ADEAC798960F0FE3_gshared)(__this, method);
}
// System.Boolean System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.HttpListenerWebSocketContext>::get_IsCompleted()
inline bool TaskAwaiter_1_get_IsCompleted_m0450A198520AE843F0245B5CF36EEC50B4718E0B (TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD *, const RuntimeMethod*))TaskAwaiter_1_get_IsCompleted_mEC81351691C5A577A64F3B728036AD979AB3AF94_gshared)(__this, method);
}
// System.Void ET.ETAsyncTaskMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.HttpListenerWebSocketContext>,ET.WService/<StartAccept>d__12>(!!0&,!!1&)
inline void ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_mACF8F057852CBC55283D1FB99088AFA3DB047A2C (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * __this, TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD * ___awaiter0, U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *, TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD *, U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE *, const RuntimeMethod*))ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t2631C6B4AF6F87F9DA4817BE4B0962E01B4F47FE_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_m20852DC509D70264075AE5026F1032036856A457_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// !0 System.Runtime.CompilerServices.TaskAwaiter`1<System.Net.WebSockets.HttpListenerWebSocketContext>::GetResult()
inline HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * TaskAwaiter_1_GetResult_m9F9A1E7D4504D843ACF08CB847674ACB717B07B7 (TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD * __this, const RuntimeMethod* method)
{
	return ((  HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * (*) (TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD *, const RuntimeMethod*))TaskAwaiter_1_GetResult_m7703A30E4F4EA17FBA4243DE1BF9412521B2AFDA_gshared)(__this, method);
}
// System.Int64 ET.WService::get_GetId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t WService_get_GetId_m74A4D3DE92F81CD576DD4645472FE83F512952B2 (WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * __this, const RuntimeMethod* method);
// System.Void ET.WChannel::.ctor(System.Int64,System.Net.WebSockets.HttpListenerWebSocketContext,ET.WService)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WChannel__ctor_mF8C76CEE10FC5F7770EE013DE372E64D82A79DBF (WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * __this, int64_t ___id0, HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * ___webSocketContext1, WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * ___service2, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int64,ET.WChannel>::set_Item(!0,!1)
inline void Dictionary_2_set_Item_mEA97895401C9E128BC88F3D235F7BC79D107D052 (Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE * __this, int64_t ___key0, WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE *, int64_t, WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 *, const RuntimeMethod*))Dictionary_2_set_Item_m18814ACD68689D7E74739B3C97A18BD6DC76E855_gshared)(__this, ___key0, ___value1, method);
}
// System.Net.IPEndPoint ET.AChannel::get_RemoteAddress()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * AChannel_get_RemoteAddress_m44608A1AAAD2C9B33577B94FBD3D04469973585E_inline (AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432 * __this, const RuntimeMethod* method);
// System.Void ET.AService::OnAccept(System.Int64,System.Net.IPEndPoint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AService_OnAccept_m6DAACBA870A623CD54A535546E363AB29665A8CC (AService_tAE41D3D6649EBE2154A9E16FFE74D1535EF78A5B * __this, int64_t ___channelId0, IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * ___ipEndPoint1, const RuntimeMethod* method);
// System.Void System.Exception::.ctor(System.String,System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_mB842BA6E644CDB9DB058F5628BB90DF5EF22C080 (Exception_t * __this, String_t* ___message0, Exception_t * ___innerException1, const RuntimeMethod* method);
// System.Void ET.WService/<StartAccept>d__12::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartAcceptU3Ed__12_MoveNext_mBF535DCEC52A35459F64CF39C14B0B8685F2110D (U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * __this, const RuntimeMethod* method);
// System.Void ET.WService/<StartAccept>d__12::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartAcceptU3Ed__12_SetStateMachine_m2F77662D5C4721760033BC3F3516F52987470B67 (U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
// ILRuntime.CLR.TypeSystem.ILType ILRuntime.Runtime.Intepreter.ILTypeInstance::get_Type()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * ILTypeInstance_get_Type_mC878DA7939714DD13AE31EE38E3F5DE9199B4937_inline (ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * __this, const RuntimeMethod* method);
// ILRuntime.CLR.Method.IMethod ILRuntime.CLR.TypeSystem.ILType::GetMethod(System.String,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ILType_GetMethod_m0893FB8B1DFF4B883238D84CD116018ED057E20A (ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * __this, String_t* ___name0, int32_t ___paramCount1, bool ___declaredOnly2, const RuntimeMethod* method);
// System.Threading.Tasks.Task System.Threading.Tasks.Task::Delay(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * Task_Delay_mD54722DBAF22507493263E9B1167A7F77EDDF80E (int32_t ___millisecondsDelay0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18>(!!0&,!!1&)
inline void AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D_mADD06B426C3D8B131B2D9AF08601BAB40AE72515 (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D * ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *, U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D *, const RuntimeMethod*))AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D_mADD06B426C3D8B131B2D9AF08601BAB40AE72515_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// System.Boolean UnityEngine.Application::get_isPlaying()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Application_get_isPlaying_m7BB718D8E58B807184491F64AFF0649517E56567 (const RuntimeMethod* method);
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.GameObject::get_activeInHierarchy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GameObject_get_activeInHierarchy_mA3990AC5F61BB35283188E925C2BE7F7BF67734B (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method);
// System.Object ILRuntime.Runtime.Enviorment.AppDomain::Invoke(ILRuntime.CLR.Method.IMethod,System.Object,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * AppDomain_Invoke_m01501668384C8C306EA59E43689038EF3D7DD355 (AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * __this, RuntimeObject* ___m0, RuntimeObject * ___instance1, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___p2, const RuntimeMethod* method);
// System.Void ET.MonoBehaviourAdapter/Adaptor::OnEnable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Adaptor_OnEnable_m148F0BD477129D4E91C21EF601E63C6EE4A3E0DE (Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * __this, const RuntimeMethod* method);
// System.Void ET.MonoBehaviourAdapter/Adaptor::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Adaptor_Awake_mADB9789D0CC503886A47E8CB40E11F36E2A455A8 (Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::SetException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_SetException_m16372173CEA3031B4CB9B8D15DA97C457F835155 (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * __this, Exception_t * ___exception0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::SetResult()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_SetResult_m901385B56EBE93E472A77EA48F61E4F498F3E00E (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * __this, const RuntimeMethod* method);
// System.Void ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CAwakeU3Ed__18_MoveNext_mDCE82912BC8FC5F255C49854F30D25838E63CB6A (U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AsyncVoidMethodBuilder_SetStateMachine_m1ED99BE03B146D8A7117E299EBA5D74999EB52D7 (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
// System.Void ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CAwakeU3Ed__18_SetStateMachine_m7E4DB6EC7CF1932501BBE25C7DD83706822D93B2 (U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,ET.MonoBehaviourAdapter/Adaptor/<Start>d__21>(!!0&,!!1&)
inline void AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F_mC22F9B7E118032FDAE087379683D6E4516C0BFC3 (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * __this, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * ___awaiter0, U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F * ___stateMachine1, const RuntimeMethod* method)
{
	((  void (*) (AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *, TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *, U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F *, const RuntimeMethod*))AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F_mC22F9B7E118032FDAE087379683D6E4516C0BFC3_gshared)(__this, ___awaiter0, ___stateMachine1, method);
}
// System.Void ET.MonoBehaviourAdapter/Adaptor/<Start>d__21::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartU3Ed__21_MoveNext_mF6E2ED62890FEE5CF2A654E4F9358581A1A2D1E7 (U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F * __this, const RuntimeMethod* method);
// System.Void ET.MonoBehaviourAdapter/Adaptor/<Start>d__21::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartU3Ed__21_SetStateMachine_m18818E7BF447ED99FDA6431D59BA2C7E6C72FCE0 (U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
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
// System.Void ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CLoadHotFixAssemblyU3Ed__4__ctor_m0A42D0C025022AAD7500416B3852EC30D607424C (U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785 * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->set_U3CU3E1__state_0(L_0);
		return;
	}
}
// System.Void ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CLoadHotFixAssemblyU3Ed__4_System_IDisposable_Dispose_mE5B88F06C5AD3D1A4DFDC4EAC1EA61FEA3C67AC3 (U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785 * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CLoadHotFixAssemblyU3Ed__4_MoveNext_m4773DED823FFD6DF69B3807324F88CAD997B7775 (U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PdbReaderProvider_tD6CADF6205DDD9BB74AE340FE5FF73794FD2361C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6F94F2594F44480FF62C6897BADE0E43E8B80580);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral876BA9D37F5B3B86B1953A81D0C931AE6AFB2BED);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCF489FF8F40BBA37AA37DDF596A798640FCFD888);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * V_1 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_2 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_1 = __this->get_U3CU3E4__this_2();
		V_1 = L_1;
		int32_t L_2 = V_0;
		switch (L_2)
		{
			case 0:
			{
				goto IL_002e;
			}
			case 1:
			{
				goto IL_0072;
			}
			case 2:
			{
				goto IL_00f5;
			}
			case 3:
			{
				goto IL_019e;
			}
			case 4:
			{
				goto IL_01c4;
			}
			case 5:
			{
				goto IL_01ea;
			}
		}
	}
	{
		return (bool)0;
	}

IL_002e:
	{
		__this->set_U3CU3E1__state_0((-1));
		// appdomain = new ILRuntime.Runtime.Enviorment.AppDomain();
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_3 = V_1;
		AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * L_4 = (AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 *)il2cpp_codegen_object_new(AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371_il2cpp_TypeInfo_var);
		AppDomain__ctor_m408804551D2A00426FCA0228FB862BF0D5033E0A(L_4, 0, /*hidden argument*/NULL);
		NullCheck(L_3);
		L_3->set_appdomain_4(L_4);
		// WWW www = new WWW("file:///" + Application.streamingAssetsPath + "/HotFix_Project.dll");
		String_t* L_5;
		L_5 = Application_get_streamingAssetsPath_mA1FBABB08D7A4590A468C7CD940CD442B58C91E1(/*hidden argument*/NULL);
		String_t* L_6;
		L_6 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(_stringLiteral876BA9D37F5B3B86B1953A81D0C931AE6AFB2BED, L_5, _stringLiteralCF489FF8F40BBA37AA37DDF596A798640FCFD888, /*hidden argument*/NULL);
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_7 = (WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 *)il2cpp_codegen_object_new(WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2_il2cpp_TypeInfo_var);
		WWW__ctor_mE77AD6C372CC76F48A893C5E2F91A81193A9F8C5(L_7, L_6, /*hidden argument*/NULL);
		__this->set_U3CwwwU3E5__2_3(L_7);
		goto IL_0079;
	}

IL_0062:
	{
		// yield return null;
		__this->set_U3CU3E2__current_1(NULL);
		__this->set_U3CU3E1__state_0(1);
		return (bool)1;
	}

IL_0072:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_0079:
	{
		// while (!www.isDone)
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_8 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_8);
		bool L_9;
		L_9 = WWW_get_isDone_m916B54D53395990DB59C64413798FBCAFB08E0E3(L_8, /*hidden argument*/NULL);
		if (!L_9)
		{
			goto IL_0062;
		}
	}
	{
		// if (!string.IsNullOrEmpty(www.error))
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_10 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_10);
		String_t* L_11;
		L_11 = WWW_get_error_mB278F5EC90EF99FEF70D80112940CFB49E79C9BC(L_10, /*hidden argument*/NULL);
		bool L_12;
		L_12 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_11, /*hidden argument*/NULL);
		if (L_12)
		{
			goto IL_00a8;
		}
	}
	{
		// UnityEngine.Debug.LogError(www.error);
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_13 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_13);
		String_t* L_14;
		L_14 = WWW_get_error_mB278F5EC90EF99FEF70D80112940CFB49E79C9BC(L_13, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_14, /*hidden argument*/NULL);
	}

IL_00a8:
	{
		// byte[] dll = www.bytes;
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_15 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_15);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_16;
		L_16 = WWW_get_bytes_m378FCCD8E91FB7FE7FA22E05BA3FE528CD7EAF1A(L_15, /*hidden argument*/NULL);
		__this->set_U3CdllU3E5__3_4(L_16);
		// www.Dispose();
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_17 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_17);
		WWW_Dispose_mF5A8B944281564903043545BC1E7F1CAD941519F(L_17, /*hidden argument*/NULL);
		// www = new WWW("file:///" + Application.streamingAssetsPath + "/HotFix_Project.pdb");
		String_t* L_18;
		L_18 = Application_get_streamingAssetsPath_mA1FBABB08D7A4590A468C7CD940CD442B58C91E1(/*hidden argument*/NULL);
		String_t* L_19;
		L_19 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(_stringLiteral876BA9D37F5B3B86B1953A81D0C931AE6AFB2BED, L_18, _stringLiteral6F94F2594F44480FF62C6897BADE0E43E8B80580, /*hidden argument*/NULL);
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_20 = (WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 *)il2cpp_codegen_object_new(WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2_il2cpp_TypeInfo_var);
		WWW__ctor_mE77AD6C372CC76F48A893C5E2F91A81193A9F8C5(L_20, L_19, /*hidden argument*/NULL);
		__this->set_U3CwwwU3E5__2_3(L_20);
		goto IL_00fc;
	}

IL_00e5:
	{
		// yield return null;
		__this->set_U3CU3E2__current_1(NULL);
		__this->set_U3CU3E1__state_0(2);
		return (bool)1;
	}

IL_00f5:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_00fc:
	{
		// while (!www.isDone)
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_21 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_21);
		bool L_22;
		L_22 = WWW_get_isDone_m916B54D53395990DB59C64413798FBCAFB08E0E3(L_21, /*hidden argument*/NULL);
		if (!L_22)
		{
			goto IL_00e5;
		}
	}
	{
		// if (!string.IsNullOrEmpty(www.error))
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_23 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_23);
		String_t* L_24;
		L_24 = WWW_get_error_mB278F5EC90EF99FEF70D80112940CFB49E79C9BC(L_23, /*hidden argument*/NULL);
		bool L_25;
		L_25 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_24, /*hidden argument*/NULL);
		if (L_25)
		{
			goto IL_012b;
		}
	}
	{
		// UnityEngine.Debug.LogError(www.error);
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_26 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_26);
		String_t* L_27;
		L_27 = WWW_get_error_mB278F5EC90EF99FEF70D80112940CFB49E79C9BC(L_26, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(L_27, /*hidden argument*/NULL);
	}

IL_012b:
	{
		// byte[] pdb = www.bytes;
		WWW_tCC46D6E5A368D4A83A3D6FAFF00B19700C5373E2 * L_28 = __this->get_U3CwwwU3E5__2_3();
		NullCheck(L_28);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_29;
		L_29 = WWW_get_bytes_m378FCCD8E91FB7FE7FA22E05BA3FE528CD7EAF1A(L_28, /*hidden argument*/NULL);
		V_2 = L_29;
		// fs = new MemoryStream(dll);
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_30 = V_1;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_31 = __this->get_U3CdllU3E5__3_4();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_32 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2(L_32, L_31, /*hidden argument*/NULL);
		NullCheck(L_30);
		L_30->set_fs_5(L_32);
		// p = new MemoryStream(pdb);
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_33 = V_1;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_34 = V_2;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_35 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2(L_35, L_34, /*hidden argument*/NULL);
		NullCheck(L_33);
		L_33->set_p_6(L_35);
	}

IL_0154:
	try
	{ // begin try (depth: 1)
		// appdomain.LoadAssembly(fs, p, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_36 = V_1;
		NullCheck(L_36);
		AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * L_37 = L_36->get_appdomain_4();
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_38 = V_1;
		NullCheck(L_38);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_39 = L_38->get_fs_5();
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_40 = V_1;
		NullCheck(L_40);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_41 = L_40->get_p_6();
		PdbReaderProvider_tD6CADF6205DDD9BB74AE340FE5FF73794FD2361C * L_42 = (PdbReaderProvider_tD6CADF6205DDD9BB74AE340FE5FF73794FD2361C *)il2cpp_codegen_object_new(PdbReaderProvider_tD6CADF6205DDD9BB74AE340FE5FF73794FD2361C_il2cpp_TypeInfo_var);
		PdbReaderProvider__ctor_m50C615CF0E70F9D7F4866EDA1DDA1D35E9F4927E(L_42, /*hidden argument*/NULL);
		NullCheck(L_37);
		AppDomain_LoadAssembly_mB90CAC0CE799D4DFED276766E453CFA72F154D4C(L_37, L_39, L_41, L_42, /*hidden argument*/NULL);
		// }
		goto IL_017f;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0172;
		}
		throw e;
	}

CATCH_0172:
	{ // begin catch(System.Object)
		// catch
		// Debug.LogError("加载热更DLL失败，请确保已经通过VS打开Assets/Samples/ILRuntime/1.6/Demo/HotFix_Project/HotFix_Project.sln编译过热更DLL");
		IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var)));
		Debug_LogError_m8850D65592770A364D494025FF3A73E8D4D70485(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralCD3284491A66FAA2DF335D327F62D690553DD236)), /*hidden argument*/NULL);
		// }
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_017f;
	} // end catch (depth: 1)

IL_017f:
	{
		// InitializeILRuntime();
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_43 = V_1;
		NullCheck(L_43);
		ValueTypeBindingDemo_InitializeILRuntime_m57550517344A6088870F628CF80EDB15F629F896(L_43, /*hidden argument*/NULL);
		// yield return new WaitForSeconds(0.5f);
		WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * L_44 = (WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 *)il2cpp_codegen_object_new(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var);
		WaitForSeconds__ctor_mD298C4CB9532BBBDE172FC40F3397E30504038D4(L_44, (0.5f), /*hidden argument*/NULL);
		__this->set_U3CU3E2__current_1(L_44);
		__this->set_U3CU3E1__state_0(3);
		return (bool)1;
	}

IL_019e:
	{
		__this->set_U3CU3E1__state_0((-1));
		// RunTest();
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_45 = V_1;
		NullCheck(L_45);
		ValueTypeBindingDemo_RunTest_m6ECAEFA1DD1163DFD1720100A9076AA4F8469E30(L_45, /*hidden argument*/NULL);
		// yield return new WaitForSeconds(0.5f);
		WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * L_46 = (WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 *)il2cpp_codegen_object_new(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var);
		WaitForSeconds__ctor_mD298C4CB9532BBBDE172FC40F3397E30504038D4(L_46, (0.5f), /*hidden argument*/NULL);
		__this->set_U3CU3E2__current_1(L_46);
		__this->set_U3CU3E1__state_0(4);
		return (bool)1;
	}

IL_01c4:
	{
		__this->set_U3CU3E1__state_0((-1));
		// RunTest2();
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_47 = V_1;
		NullCheck(L_47);
		ValueTypeBindingDemo_RunTest2_m52AE4B7379D659AAFB4D53C2891FDD2A78ED1988(L_47, /*hidden argument*/NULL);
		// yield return new WaitForSeconds(0.5f);
		WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * L_48 = (WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 *)il2cpp_codegen_object_new(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var);
		WaitForSeconds__ctor_mD298C4CB9532BBBDE172FC40F3397E30504038D4(L_48, (0.5f), /*hidden argument*/NULL);
		__this->set_U3CU3E2__current_1(L_48);
		__this->set_U3CU3E1__state_0(5);
		return (bool)1;
	}

IL_01ea:
	{
		__this->set_U3CU3E1__state_0((-1));
		// RunTest3();
		ValueTypeBindingDemo_t340FE41FC753F9325123D34BF8557B8D06AF4AFA * L_49 = V_1;
		NullCheck(L_49);
		ValueTypeBindingDemo_RunTest3_m666AAE2FCD937E808E5F5B1BBAAA5F3AD3C9D25D(L_49, /*hidden argument*/NULL);
		// }
		return (bool)0;
	}
}
// System.Object ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CLoadHotFixAssemblyU3Ed__4_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mBD8C7F11CEFBA9B6BBB9067188FC84361984D8B1 (U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
// System.Void ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CLoadHotFixAssemblyU3Ed__4_System_Collections_IEnumerator_Reset_mB67512B97B229931E43B55700F18385A3E1429AD (U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785 * __this, const RuntimeMethod* method)
{
	{
		NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * L_0 = (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var)));
		NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CLoadHotFixAssemblyU3Ed__4_System_Collections_IEnumerator_Reset_mB67512B97B229931E43B55700F18385A3E1429AD_RuntimeMethod_var)));
	}
}
// System.Object ValueTypeBindingDemo/<LoadHotFixAssembly>d__4::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3CLoadHotFixAssemblyU3Ed__4_System_Collections_IEnumerator_get_Current_m4A51F0CE82DA3516A5BC4C4935722F9AF05E500B (U3CLoadHotFixAssemblyU3Ed__4_tAA2AA910A10C7C02E916722CAAD3C33C4A7C0785 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
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
// System.Void ET.WChannel/<>c__DisplayClass11_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass11_0__ctor_mCAFC511BBE0C3AA39BA20DBF13191E051E451FF1 (U3CU3Ec__DisplayClass11_0_tBF6C144A4B80DF4937B39E39D7900DE33A416F40 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void ET.WChannel/<>c__DisplayClass11_0::<.ctor>b__0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass11_0_U3C_ctorU3Eb__0_mFF44968EEA5A3375FFB109E0E39E4A6A8DCBA19D (U3CU3Ec__DisplayClass11_0_tBF6C144A4B80DF4937B39E39D7900DE33A416F40 * __this, const RuntimeMethod* method)
{
	{
		// this.Service.ThreadSynchronizationContext.PostNext(()=>this.ConnectAsync(connectUrl).Coroutine());
		WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_0 = __this->get_U3CU3E4__this_0();
		String_t* L_1 = __this->get_connectUrl_1();
		NullCheck(L_0);
		ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * L_2;
		L_2 = WChannel_ConnectAsync_m3BED888E920BDB2B452EFC4FE3FCE47FA3758363(L_0, L_1, /*hidden argument*/NULL);
		NullCheck(L_2);
		ETTask_Coroutine_m6A9CDCF58772F984C229E45D91CE5D84598738A2(L_2, /*hidden argument*/NULL);
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
// System.Void ET.WChannel/<ConnectAsync>d__13::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CConnectAsyncU3Ed__13_MoveNext_m6C9E2C896B64BCF28C7011E150404527D621F163 (U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA_m73E39109983EA3E233B4541A6358DD15797D8F31_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * V_1 = NULL;
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  V_2;
	memset((&V_2), 0, sizeof(V_2));
	Exception_t * V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 2> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 5> __leave_targets;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_1 = __this->get_U3CU3E4__this_2();
		V_1 = L_1;
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			int32_t L_2 = V_0;
		}

IL_0011:
		try
		{ // begin try (depth: 2)
			{
				int32_t L_3 = V_0;
				if (!L_3)
				{
					goto IL_006c;
				}
			}

IL_0014:
			{
				// await ((ClientWebSocket) this.webSocket).ConnectAsync(new Uri(url), cancellationTokenSource.Token);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_4 = V_1;
				NullCheck(L_4);
				WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * L_5 = L_4->get_webSocket_6();
				String_t* L_6 = __this->get_url_3();
				Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * L_7 = (Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 *)il2cpp_codegen_object_new(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612_il2cpp_TypeInfo_var);
				Uri__ctor_m7724F43B1525624FFF97A774B6B909B075714D5C(L_7, L_6, /*hidden argument*/NULL);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_8 = V_1;
				NullCheck(L_8);
				CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * L_9 = L_8->get_cancellationTokenSource_11();
				NullCheck(L_9);
				CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  L_10;
				L_10 = CancellationTokenSource_get_Token_m2A9A82BA3532B89870363E8C1DEAE2F1EFD3962C(L_9, /*hidden argument*/NULL);
				NullCheck(((ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09 *)CastclassSealed((RuntimeObject*)L_5, ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09_il2cpp_TypeInfo_var)));
				Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * L_11;
				L_11 = ClientWebSocket_ConnectAsync_m2FF7047AC718D6181EF7E3840543DB645089D72D(((ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09 *)CastclassSealed((RuntimeObject*)L_5, ClientWebSocket_tA2D70722EB2DD788E27D46C7E262C85C984EEE09_il2cpp_TypeInfo_var)), L_7, L_10, /*hidden argument*/NULL);
				NullCheck(L_11);
				TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_12;
				L_12 = Task_GetAwaiter_m1FF7528A8FE13F79207DFE970F642078EF6B1260(L_11, /*hidden argument*/NULL);
				V_2 = L_12;
				bool L_13;
				L_13 = TaskAwaiter_get_IsCompleted_m6F97613C55E505B5664C3C0CFC4677D296EAA8BC((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), /*hidden argument*/NULL);
				if (L_13)
				{
					goto IL_0088;
				}
			}

IL_0049:
			{
				int32_t L_14 = 0;
				V_0 = L_14;
				__this->set_U3CU3E1__state_0(L_14);
				TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_15 = V_2;
				__this->set_U3CU3Eu__1_4(L_15);
				ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_16 = __this->get_address_of_U3CU3Et__builder_1();
				ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA_m73E39109983EA3E233B4541A6358DD15797D8F31((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_16, (TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), (U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA *)__this, /*hidden argument*/ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA_m73E39109983EA3E233B4541A6358DD15797D8F31_RuntimeMethod_var);
				goto IL_00ec;
			}

IL_006c:
			{
				TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_17 = __this->get_U3CU3Eu__1_4();
				V_2 = L_17;
				TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * L_18 = __this->get_address_of_U3CU3Eu__1_4();
				il2cpp_codegen_initobj(L_18, sizeof(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C ));
				int32_t L_19 = (-1);
				V_0 = L_19;
				__this->set_U3CU3E1__state_0(L_19);
			}

IL_0088:
			{
				TaskAwaiter_GetResult_m578EEFEC4DD1AE5E77C899B8BAA3825EB79D1330((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), /*hidden argument*/NULL);
				// isConnected = true;
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_20 = V_1;
				NullCheck(L_20);
				L_20->set_isConnected_9((bool)1);
				// this.StartRecv().Coroutine();
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_21 = V_1;
				NullCheck(L_21);
				ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * L_22;
				L_22 = WChannel_StartRecv_mBC78B621E242A880F57025CC8B6AFFF174C273BD(L_21, /*hidden argument*/NULL);
				NullCheck(L_22);
				ETTask_Coroutine_m6A9CDCF58772F984C229E45D91CE5D84598738A2(L_22, /*hidden argument*/NULL);
				// this.StartSend().Coroutine();
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_23 = V_1;
				NullCheck(L_23);
				ETTask_t7CE21662325DB4B000542DA47BE4D092D95C48EF * L_24;
				L_24 = WChannel_StartSend_m04D765F133E266B934CF960E838DDCDD979F96B3(L_23, /*hidden argument*/NULL);
				NullCheck(L_24);
				ETTask_Coroutine_m6A9CDCF58772F984C229E45D91CE5D84598738A2(L_24, /*hidden argument*/NULL);
				// }
				goto IL_00c0;
			}
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_00ae;
			}
			throw e;
		}

CATCH_00ae:
		{ // begin catch(System.Exception)
			// Log.Error(e);
			Log_Error_mC1EB3767E2A28400D0ED5C10C1B0FB83FDF39365(((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *)), /*hidden argument*/NULL);
			// this.OnError(ErrorCore.ERR_WebsocketConnectError);
			WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_25 = V_1;
			NullCheck(L_25);
			WChannel_OnError_m268622C0130BB47AD32D04876CFF669E5466CD6E(L_25, ((int32_t)110304), /*hidden argument*/NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_00c0;
		} // end catch (depth: 2)

IL_00c0:
		{
			goto IL_00d9;
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00c2;
		}
		throw e;
	}

CATCH_00c2:
	{ // begin catch(System.Exception)
		V_3 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_26 = __this->get_address_of_U3CU3Et__builder_1();
		Exception_t * L_27 = V_3;
		ETAsyncTaskMethodBuilder_SetException_m94B10E7E2F8D77DDE977C587A7444B7EC17DCC71((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_26, L_27, /*hidden argument*/NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00ec;
	} // end catch (depth: 1)

IL_00d9:
	{
		// }
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_28 = __this->get_address_of_U3CU3Et__builder_1();
		ETAsyncTaskMethodBuilder_SetResult_m985BE32D35AB03DC4CE000D8D9A2BFACB8B7A88B((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_28, /*hidden argument*/NULL);
	}

IL_00ec:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CConnectAsyncU3Ed__13_MoveNext_m6C9E2C896B64BCF28C7011E150404527D621F163_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA * _thisAdjusted = reinterpret_cast<U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA *>(__this + _offset);
	U3CConnectAsyncU3Ed__13_MoveNext_m6C9E2C896B64BCF28C7011E150404527D621F163(_thisAdjusted, method);
}
// System.Void ET.WChannel/<ConnectAsync>d__13::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CConnectAsyncU3Ed__13_SetStateMachine_m8BE2AB2C8AC652075E318FFEE4DBB3606D3AD9D1 (U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	{
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_0 = __this->get_address_of_U3CU3Et__builder_1();
		RuntimeObject* L_1 = ___stateMachine0;
		ETAsyncTaskMethodBuilder_SetStateMachine_mFECCC5F702F4D3B9598975007D961FE4D0BFAAC3((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CConnectAsyncU3Ed__13_SetStateMachine_m8BE2AB2C8AC652075E318FFEE4DBB3606D3AD9D1_AdjustorThunk (RuntimeObject * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA * _thisAdjusted = reinterpret_cast<U3CConnectAsyncU3Ed__13_t7B06F75B9F3802F66691127AD2766D807A3568BA *>(__this + _offset);
	U3CConnectAsyncU3Ed__13_SetStateMachine_m8BE2AB2C8AC652075E318FFEE4DBB3606D3AD9D1(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void ET.WChannel/<StartRecv>d__17::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartRecvU3Ed__17_MoveNext_m99A96D91E71703A4B7769BEF21B9501C6701FA2C (U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_mFD39C7F5DE149D2283C6E3634B13E448F6EDD262_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m6FB0816A8B00FD9C3EDC5827C4A2E97FF700B397_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskAwaiter_1_GetResult_mCDCAAF89F5D74175A37B6E9F507C970EDAF07B97_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskAwaiter_1_get_IsCompleted_m2D13C0370C28B8EA4406A35F0A8BC012DF3C8537_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Task_1_GetAwaiter_m46A488400364A14C5B4A6B616BD7A1BB08927520_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2D3C540F0573F47B63A168DBF2502AFB95812B8A);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * V_1 = NULL;
	WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * V_2 = NULL;
	TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  V_3;
	memset((&V_3), 0, sizeof(V_3));
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  V_4;
	memset((&V_4), 0, sizeof(V_4));
	Exception_t * V_5 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 2> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 9> __leave_targets;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_1 = __this->get_U3CU3E4__this_2();
		V_1 = L_1;
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			int32_t L_2 = V_0;
			if ((!(((uint32_t)L_2) > ((uint32_t)1))))
			{
				goto IL_001f;
			}
		}

IL_0012:
		{
			// if (this.IsDisposed)
			WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_3 = V_1;
			NullCheck(L_3);
			bool L_4;
			L_4 = AChannel_get_IsDisposed_m80F93CAF0E5479EFDB294FB9174D9DBD51C4FAFA(L_3, /*hidden argument*/NULL);
			if (!L_4)
			{
				goto IL_001f;
			}
		}

IL_001a:
		{
			// return;
			goto IL_0223;
		}

IL_001f:
		{
		}

IL_0020:
		try
		{ // begin try (depth: 2)
			{
				int32_t L_5 = V_0;
				if (!L_5)
				{
					goto IL_0099;
				}
			}

IL_0023:
			{
				int32_t L_6 = V_0;
				if ((((int32_t)L_6) == ((int32_t)1)))
				{
					goto IL_0175;
				}
			}

IL_002a:
			{
				// int receiveCount = 0;
				__this->set_U3CreceiveCountU3E5__2_3(0);
			}

IL_0031:
			{
				// receiveResult = await this.webSocket.ReceiveAsync(
				//     new ArraySegment<byte>(this.cache, receiveCount, this.cache.Length - receiveCount),
				//     cancellationTokenSource.Token);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_7 = V_1;
				NullCheck(L_7);
				WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * L_8 = L_7->get_webSocket_6();
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_9 = V_1;
				NullCheck(L_9);
				ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_10 = L_9->get_cache_12();
				int32_t L_11 = __this->get_U3CreceiveCountU3E5__2_3();
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_12 = V_1;
				NullCheck(L_12);
				ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_13 = L_12->get_cache_12();
				NullCheck(L_13);
				int32_t L_14 = __this->get_U3CreceiveCountU3E5__2_3();
				ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE  L_15;
				memset((&L_15), 0, sizeof(L_15));
				ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D((&L_15), L_10, L_11, ((int32_t)il2cpp_codegen_subtract((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length))), (int32_t)L_14)), /*hidden argument*/ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D_RuntimeMethod_var);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_16 = V_1;
				NullCheck(L_16);
				CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * L_17 = L_16->get_cancellationTokenSource_11();
				NullCheck(L_17);
				CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  L_18;
				L_18 = CancellationTokenSource_get_Token_m2A9A82BA3532B89870363E8C1DEAE2F1EFD3962C(L_17, /*hidden argument*/NULL);
				NullCheck(L_8);
				Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E * L_19;
				L_19 = VirtFuncInvoker2< Task_1_t79E764D87096B674F330B1306805A0FF72B2E83E *, ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE , CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  >::Invoke(13 /* System.Threading.Tasks.Task`1<System.Net.WebSockets.WebSocketReceiveResult> System.Net.WebSockets.WebSocket::ReceiveAsync(System.ArraySegment`1<System.Byte>,System.Threading.CancellationToken) */, L_8, L_15, L_18);
				NullCheck(L_19);
				TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  L_20;
				L_20 = Task_1_GetAwaiter_m46A488400364A14C5B4A6B616BD7A1BB08927520(L_19, /*hidden argument*/Task_1_GetAwaiter_m46A488400364A14C5B4A6B616BD7A1BB08927520_RuntimeMethod_var);
				V_3 = L_20;
				bool L_21;
				L_21 = TaskAwaiter_1_get_IsCompleted_m2D13C0370C28B8EA4406A35F0A8BC012DF3C8537((TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 *)(&V_3), /*hidden argument*/TaskAwaiter_1_get_IsCompleted_m2D13C0370C28B8EA4406A35F0A8BC012DF3C8537_RuntimeMethod_var);
				if (L_21)
				{
					goto IL_00b5;
				}
			}

IL_0076:
			{
				int32_t L_22 = 0;
				V_0 = L_22;
				__this->set_U3CU3E1__state_0(L_22);
				TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  L_23 = V_3;
				__this->set_U3CU3Eu__1_4(L_23);
				ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_24 = __this->get_address_of_U3CU3Et__builder_1();
				ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_mFD39C7F5DE149D2283C6E3634B13E448F6EDD262((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_24, (TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 *)(&V_3), (U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B *)__this, /*hidden argument*/ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_mFD39C7F5DE149D2283C6E3634B13E448F6EDD262_RuntimeMethod_var);
				goto IL_0236;
			}

IL_0099:
			{
				TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6  L_25 = __this->get_U3CU3Eu__1_4();
				V_3 = L_25;
				TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 * L_26 = __this->get_address_of_U3CU3Eu__1_4();
				il2cpp_codegen_initobj(L_26, sizeof(TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 ));
				int32_t L_27 = (-1);
				V_0 = L_27;
				__this->set_U3CU3E1__state_0(L_27);
			}

IL_00b5:
			{
				WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * L_28;
				L_28 = TaskAwaiter_1_GetResult_mCDCAAF89F5D74175A37B6E9F507C970EDAF07B97((TaskAwaiter_1_tE7CEF18367E979C3A40489CF01B7F0C9D2DC7FD6 *)(&V_3), /*hidden argument*/TaskAwaiter_1_GetResult_mCDCAAF89F5D74175A37B6E9F507C970EDAF07B97_RuntimeMethod_var);
				V_2 = L_28;
				// if (this.IsDisposed)
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_29 = V_1;
				NullCheck(L_29);
				bool L_30;
				L_30 = AChannel_get_IsDisposed_m80F93CAF0E5479EFDB294FB9174D9DBD51C4FAFA(L_29, /*hidden argument*/NULL);
				if (!L_30)
				{
					goto IL_00ca;
				}
			}

IL_00c5:
			{
				// return;
				goto IL_0223;
			}

IL_00ca:
			{
				// receiveCount += receiveResult.Count;
				int32_t L_31 = __this->get_U3CreceiveCountU3E5__2_3();
				WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * L_32 = V_2;
				NullCheck(L_32);
				int32_t L_33;
				L_33 = WebSocketReceiveResult_get_Count_m9A22CB095E69E1DE69FDA79295ECC5BE8A147CB9_inline(L_32, /*hidden argument*/NULL);
				__this->set_U3CreceiveCountU3E5__2_3(((int32_t)il2cpp_codegen_add((int32_t)L_31, (int32_t)L_33)));
				// while (!receiveResult.EndOfMessage);
				WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * L_34 = V_2;
				NullCheck(L_34);
				bool L_35;
				L_35 = WebSocketReceiveResult_get_EndOfMessage_m233182D8ABF49FEE3C82D6C217CAAC5922104F57_inline(L_34, /*hidden argument*/NULL);
				if (!L_35)
				{
					goto IL_0031;
				}
			}

IL_00e8:
			{
				// if (receiveResult.MessageType == WebSocketMessageType.Close)
				WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * L_36 = V_2;
				NullCheck(L_36);
				int32_t L_37;
				L_37 = WebSocketReceiveResult_get_MessageType_mBE189CACCE7DCDC1C5C0CF9873DD3290BC686478_inline(L_36, /*hidden argument*/NULL);
				if ((!(((uint32_t)L_37) == ((uint32_t)2))))
				{
					goto IL_0101;
				}
			}

IL_00f1:
			{
				// this.OnError(ErrorCore.ERR_WebsocketPeerReset);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_38 = V_1;
				NullCheck(L_38);
				WChannel_OnError_m268622C0130BB47AD32D04876CFF669E5466CD6E(L_38, ((int32_t)100218), /*hidden argument*/NULL);
				// return;
				goto IL_0223;
			}

IL_0101:
			{
				// if (receiveResult.Count > ushort.MaxValue)
				WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * L_39 = V_2;
				NullCheck(L_39);
				int32_t L_40;
				L_40 = WebSocketReceiveResult_get_Count_m9A22CB095E69E1DE69FDA79295ECC5BE8A147CB9_inline(L_39, /*hidden argument*/NULL);
				if ((((int32_t)L_40) <= ((int32_t)((int32_t)65535))))
				{
					goto IL_01a6;
				}
			}

IL_0111:
			{
				// await this.webSocket.CloseAsync(WebSocketCloseStatus.MessageTooBig, $"message too big: {receiveCount}",
				//     cancellationTokenSource.Token);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_41 = V_1;
				NullCheck(L_41);
				WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * L_42 = L_41->get_webSocket_6();
				int32_t L_43 = __this->get_U3CreceiveCountU3E5__2_3();
				int32_t L_44 = L_43;
				RuntimeObject * L_45 = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &L_44);
				String_t* L_46;
				L_46 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(_stringLiteral2D3C540F0573F47B63A168DBF2502AFB95812B8A, L_45, /*hidden argument*/NULL);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_47 = V_1;
				NullCheck(L_47);
				CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * L_48 = L_47->get_cancellationTokenSource_11();
				NullCheck(L_48);
				CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  L_49;
				L_49 = CancellationTokenSource_get_Token_m2A9A82BA3532B89870363E8C1DEAE2F1EFD3962C(L_48, /*hidden argument*/NULL);
				NullCheck(L_42);
				Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * L_50;
				L_50 = VirtFuncInvoker3< Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 *, int32_t, String_t*, CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  >::Invoke(10 /* System.Threading.Tasks.Task System.Net.WebSockets.WebSocket::CloseAsync(System.Net.WebSockets.WebSocketCloseStatus,System.String,System.Threading.CancellationToken) */, L_42, ((int32_t)1009), L_46, L_49);
				NullCheck(L_50);
				TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_51;
				L_51 = Task_GetAwaiter_m1FF7528A8FE13F79207DFE970F642078EF6B1260(L_50, /*hidden argument*/NULL);
				V_4 = L_51;
				bool L_52;
				L_52 = TaskAwaiter_get_IsCompleted_m6F97613C55E505B5664C3C0CFC4677D296EAA8BC((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_4), /*hidden argument*/NULL);
				if (L_52)
				{
					goto IL_0192;
				}
			}

IL_0151:
			{
				int32_t L_53 = 1;
				V_0 = L_53;
				__this->set_U3CU3E1__state_0(L_53);
				TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_54 = V_4;
				__this->set_U3CU3Eu__2_5(L_54);
				ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_55 = __this->get_address_of_U3CU3Et__builder_1();
				ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m6FB0816A8B00FD9C3EDC5827C4A2E97FF700B397((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_55, (TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_4), (U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B *)__this, /*hidden argument*/ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B_m6FB0816A8B00FD9C3EDC5827C4A2E97FF700B397_RuntimeMethod_var);
				goto IL_0236;
			}

IL_0175:
			{
				TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_56 = __this->get_U3CU3Eu__2_5();
				V_4 = L_56;
				TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * L_57 = __this->get_address_of_U3CU3Eu__2_5();
				il2cpp_codegen_initobj(L_57, sizeof(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C ));
				int32_t L_58 = (-1);
				V_0 = L_58;
				__this->set_U3CU3E1__state_0(L_58);
			}

IL_0192:
			{
				TaskAwaiter_GetResult_m578EEFEC4DD1AE5E77C899B8BAA3825EB79D1330((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_4), /*hidden argument*/NULL);
				// this.OnError(ErrorCore.ERR_WebsocketMessageTooBig);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_59 = V_1;
				NullCheck(L_59);
				WChannel_OnError_m268622C0130BB47AD32D04876CFF669E5466CD6E(L_59, ((int32_t)100219), /*hidden argument*/NULL);
				// return;
				goto IL_0223;
			}

IL_01a6:
			{
				// this.recvStream.SetLength(receiveCount);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_60 = V_1;
				NullCheck(L_60);
				MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_61 = L_60->get_recvStream_10();
				int32_t L_62 = __this->get_U3CreceiveCountU3E5__2_3();
				NullCheck(L_61);
				VirtActionInvoker1< int64_t >::Invoke(33 /* System.Void System.IO.Stream::SetLength(System.Int64) */, L_61, ((int64_t)((int64_t)L_62)));
				// this.recvStream.Seek(2, SeekOrigin.Begin);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_63 = V_1;
				NullCheck(L_63);
				MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_64 = L_63->get_recvStream_10();
				NullCheck(L_64);
				int64_t L_65;
				L_65 = VirtFuncInvoker2< int64_t, int64_t, int32_t >::Invoke(32 /* System.Int64 System.IO.Stream::Seek(System.Int64,System.IO.SeekOrigin) */, L_64, ((int64_t)((int64_t)2)), 0);
				// Array.Copy(this.cache, 0, this.recvStream.GetBuffer(), 0, receiveCount);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_66 = V_1;
				NullCheck(L_66);
				ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_67 = L_66->get_cache_12();
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_68 = V_1;
				NullCheck(L_68);
				MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_69 = L_68->get_recvStream_10();
				NullCheck(L_69);
				ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_70;
				L_70 = VirtFuncInvoker0< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(43 /* System.Byte[] System.IO.MemoryStream::GetBuffer() */, L_69);
				int32_t L_71 = __this->get_U3CreceiveCountU3E5__2_3();
				Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877((RuntimeArray *)(RuntimeArray *)L_67, 0, (RuntimeArray *)(RuntimeArray *)L_70, 0, L_71, /*hidden argument*/NULL);
				// this.OnRead(this.recvStream);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_72 = V_1;
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_73 = V_1;
				NullCheck(L_73);
				MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_74 = L_73->get_recvStream_10();
				NullCheck(L_72);
				WChannel_OnRead_m381A0C3EAD0C66840129B57E13B269320DFD0A36(L_72, L_74, /*hidden argument*/NULL);
				// while (true)
				goto IL_002a;
			}
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_01f6;
			}
			throw e;
		}

CATCH_01f6:
		{ // begin catch(System.Exception)
			// Log.Error(e);
			Log_Error_mC1EB3767E2A28400D0ED5C10C1B0FB83FDF39365(((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *)), /*hidden argument*/NULL);
			// this.OnError(ErrorCore.ERR_WebsocketRecvError);
			WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_75 = V_1;
			NullCheck(L_75);
			WChannel_OnError_m268622C0130BB47AD32D04876CFF669E5466CD6E(L_75, ((int32_t)100220), /*hidden argument*/NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_0208;
		} // end catch (depth: 2)

IL_0208:
		{
			goto IL_0223;
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_020a;
		}
		throw e;
	}

CATCH_020a:
	{ // begin catch(System.Exception)
		V_5 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_76 = __this->get_address_of_U3CU3Et__builder_1();
		Exception_t * L_77 = V_5;
		ETAsyncTaskMethodBuilder_SetException_m94B10E7E2F8D77DDE977C587A7444B7EC17DCC71((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_76, L_77, /*hidden argument*/NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0236;
	} // end catch (depth: 1)

IL_0223:
	{
		// }
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_78 = __this->get_address_of_U3CU3Et__builder_1();
		ETAsyncTaskMethodBuilder_SetResult_m985BE32D35AB03DC4CE000D8D9A2BFACB8B7A88B((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_78, /*hidden argument*/NULL);
	}

IL_0236:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CStartRecvU3Ed__17_MoveNext_m99A96D91E71703A4B7769BEF21B9501C6701FA2C_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * _thisAdjusted = reinterpret_cast<U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B *>(__this + _offset);
	U3CStartRecvU3Ed__17_MoveNext_m99A96D91E71703A4B7769BEF21B9501C6701FA2C(_thisAdjusted, method);
}
// System.Void ET.WChannel/<StartRecv>d__17::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartRecvU3Ed__17_SetStateMachine_mDFAFE34FF168AE8E3424749DAE476EF91B653303 (U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	{
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_0 = __this->get_address_of_U3CU3Et__builder_1();
		RuntimeObject* L_1 = ___stateMachine0;
		ETAsyncTaskMethodBuilder_SetStateMachine_mFECCC5F702F4D3B9598975007D961FE4D0BFAAC3((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CStartRecvU3Ed__17_SetStateMachine_mDFAFE34FF168AE8E3424749DAE476EF91B653303_AdjustorThunk (RuntimeObject * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B * _thisAdjusted = reinterpret_cast<U3CStartRecvU3Ed__17_t22078C09D141C8A4C904CC2832AFB2EF51675E1B *>(__this + _offset);
	U3CStartRecvU3Ed__17_SetStateMachine_mDFAFE34FF168AE8E3424749DAE476EF91B653303(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void ET.WChannel/<StartSend>d__15::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartSendU3Ed__15_MoveNext_m5A2FAB35FEF8A1D2638A92B2AF086F6B17ABE055 (U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162_mF0CD29EE2B7DAEB89BF469B893F9CD822C6DD7C1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Queue_1_Dequeue_m2EA4ED50C9D3AFC5608B9ACDF7C611D244872F0D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Queue_1_get_Count_m1D55723B47270D04849E24BC09480DCD17C0CEBA_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * V_1 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_2 = NULL;
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  V_3;
	memset((&V_3), 0, sizeof(V_3));
	Exception_t * V_4 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 3> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 10> __leave_targets;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_1 = __this->get_U3CU3E4__this_2();
		V_1 = L_1;
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			int32_t L_2 = V_0;
			if (!L_2)
			{
				goto IL_001e;
			}
		}

IL_0011:
		{
			// if (this.IsDisposed)
			WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_3 = V_1;
			NullCheck(L_3);
			bool L_4;
			L_4 = AChannel_get_IsDisposed_m80F93CAF0E5479EFDB294FB9174D9DBD51C4FAFA(L_3, /*hidden argument*/NULL);
			if (!L_4)
			{
				goto IL_001e;
			}
		}

IL_0019:
		{
			// return;
			goto IL_0116;
		}

IL_001e:
		{
		}

IL_001f:
		try
		{ // begin try (depth: 2)
			{
				int32_t L_5 = V_0;
				if (!L_5)
				{
					goto IL_005b;
				}
			}

IL_0022:
			{
				// if (this.isSending)
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_6 = V_1;
				NullCheck(L_6);
				bool L_7 = L_6->get_isSending_8();
				if (!L_7)
				{
					goto IL_002f;
				}
			}

IL_002a:
			{
				// return;
				goto IL_0116;
			}

IL_002f:
			{
				// this.isSending = true;
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_8 = V_1;
				NullCheck(L_8);
				L_8->set_isSending_8((bool)1);
			}

IL_0036:
			{
				// if (this.queue.Count == 0)
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_9 = V_1;
				NullCheck(L_9);
				Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 * L_10 = L_9->get_queue_7();
				NullCheck(L_10);
				int32_t L_11;
				L_11 = Queue_1_get_Count_m1D55723B47270D04849E24BC09480DCD17C0CEBA_inline(L_10, /*hidden argument*/Queue_1_get_Count_m1D55723B47270D04849E24BC09480DCD17C0CEBA_RuntimeMethod_var);
				if (L_11)
				{
					goto IL_004f;
				}
			}

IL_0043:
			{
				// this.isSending = false;
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_12 = V_1;
				NullCheck(L_12);
				L_12->set_isSending_8((bool)0);
				// return;
				goto IL_0116;
			}

IL_004f:
			{
				// byte[] bytes = this.queue.Dequeue();
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_13 = V_1;
				NullCheck(L_13);
				Queue_1_tAF2A710AEBB98604F7E35A3CD161FA0838FD96D4 * L_14 = L_13->get_queue_7();
				NullCheck(L_14);
				ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_15;
				L_15 = Queue_1_Dequeue_m2EA4ED50C9D3AFC5608B9ACDF7C611D244872F0D(L_14, /*hidden argument*/Queue_1_Dequeue_m2EA4ED50C9D3AFC5608B9ACDF7C611D244872F0D_RuntimeMethod_var);
				V_2 = L_15;
			}

IL_005b:
			{
			}

IL_005c:
			try
			{ // begin try (depth: 3)
				{
					int32_t L_16 = V_0;
					if (!L_16)
					{
						goto IL_00b0;
					}
				}

IL_005f:
				{
					// await this.webSocket.SendAsync(new ArraySegment<byte>(bytes, 0, bytes.Length), WebSocketMessageType.Binary, true, cancellationTokenSource.Token);
					WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_17 = V_1;
					NullCheck(L_17);
					WebSocket_t163494E6D52FFC7BACDCD1488EB1B61B392C298D * L_18 = L_17->get_webSocket_6();
					ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_19 = V_2;
					ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_20 = V_2;
					NullCheck(L_20);
					ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE  L_21;
					memset((&L_21), 0, sizeof(L_21));
					ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D((&L_21), L_19, 0, ((int32_t)((int32_t)(((RuntimeArray*)L_20)->max_length))), /*hidden argument*/ArraySegment_1__ctor_mAA780E22BB5AE07078510EDCE524DD1EA1E98E0D_RuntimeMethod_var);
					WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_22 = V_1;
					NullCheck(L_22);
					CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * L_23 = L_22->get_cancellationTokenSource_11();
					NullCheck(L_23);
					CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  L_24;
					L_24 = CancellationTokenSource_get_Token_m2A9A82BA3532B89870363E8C1DEAE2F1EFD3962C(L_23, /*hidden argument*/NULL);
					NullCheck(L_18);
					Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * L_25;
					L_25 = VirtFuncInvoker4< Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 *, ArraySegment_1_t89782CFC3178DB9FD8FFCCC398B4575AE8D740AE , int32_t, bool, CancellationToken_tC9D68381C9164A4BA10397257E87ADC832AF5FFD  >::Invoke(14 /* System.Threading.Tasks.Task System.Net.WebSockets.WebSocket::SendAsync(System.ArraySegment`1<System.Byte>,System.Net.WebSockets.WebSocketMessageType,System.Boolean,System.Threading.CancellationToken) */, L_18, L_21, 1, (bool)1, L_24);
					NullCheck(L_25);
					TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_26;
					L_26 = Task_GetAwaiter_m1FF7528A8FE13F79207DFE970F642078EF6B1260(L_25, /*hidden argument*/NULL);
					V_3 = L_26;
					bool L_27;
					L_27 = TaskAwaiter_get_IsCompleted_m6F97613C55E505B5664C3C0CFC4677D296EAA8BC((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_3), /*hidden argument*/NULL);
					if (L_27)
					{
						goto IL_00cc;
					}
				}

IL_0090:
				{
					int32_t L_28 = 0;
					V_0 = L_28;
					__this->set_U3CU3E1__state_0(L_28);
					TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_29 = V_3;
					__this->set_U3CU3Eu__1_3(L_29);
					ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_30 = __this->get_address_of_U3CU3Et__builder_1();
					ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162_mF0CD29EE2B7DAEB89BF469B893F9CD822C6DD7C1((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_30, (TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_3), (U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 *)__this, /*hidden argument*/ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162_mF0CD29EE2B7DAEB89BF469B893F9CD822C6DD7C1_RuntimeMethod_var);
					goto IL_0129;
				}

IL_00b0:
				{
					TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_31 = __this->get_U3CU3Eu__1_3();
					V_3 = L_31;
					TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * L_32 = __this->get_address_of_U3CU3Eu__1_3();
					il2cpp_codegen_initobj(L_32, sizeof(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C ));
					int32_t L_33 = (-1);
					V_0 = L_33;
					__this->set_U3CU3E1__state_0(L_33);
				}

IL_00cc:
				{
					TaskAwaiter_GetResult_m578EEFEC4DD1AE5E77C899B8BAA3825EB79D1330((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_3), /*hidden argument*/NULL);
					// if (this.IsDisposed)
					WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_34 = V_1;
					NullCheck(L_34);
					bool L_35;
					L_35 = AChannel_get_IsDisposed_m80F93CAF0E5479EFDB294FB9174D9DBD51C4FAFA(L_34, /*hidden argument*/NULL);
					if (!L_35)
					{
						goto IL_00dd;
					}
				}

IL_00db:
				{
					// return;
					goto IL_0116;
				}

IL_00dd:
				{
					// }
					goto IL_0036;
				}
			} // end try (depth: 3)
			catch(Il2CppExceptionWrapper& e)
			{
				if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
				{
					IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
					goto CATCH_00e2;
				}
				throw e;
			}

CATCH_00e2:
			{ // begin catch(System.Exception)
				// Log.Error(e);
				Log_Error_mC1EB3767E2A28400D0ED5C10C1B0FB83FDF39365(((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *)), /*hidden argument*/NULL);
				// this.OnError(ErrorCore.ERR_WebsocketSendError);
				WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_36 = V_1;
				NullCheck(L_36);
				WChannel_OnError_m268622C0130BB47AD32D04876CFF669E5466CD6E(L_36, ((int32_t)100217), /*hidden argument*/NULL);
				// return;
				IL2CPP_POP_ACTIVE_EXCEPTION();
				goto IL_0116;
			} // end catch (depth: 3)
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_00f4;
			}
			throw e;
		}

CATCH_00f4:
		{ // begin catch(System.Exception)
			// Log.Error(e);
			Log_Error_mC1EB3767E2A28400D0ED5C10C1B0FB83FDF39365(((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *)), /*hidden argument*/NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_00fb;
		} // end catch (depth: 2)

IL_00fb:
		{
			goto IL_0116;
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00fd;
		}
		throw e;
	}

CATCH_00fd:
	{ // begin catch(System.Exception)
		V_4 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_37 = __this->get_address_of_U3CU3Et__builder_1();
		Exception_t * L_38 = V_4;
		ETAsyncTaskMethodBuilder_SetException_m94B10E7E2F8D77DDE977C587A7444B7EC17DCC71((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_37, L_38, /*hidden argument*/NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0129;
	} // end catch (depth: 1)

IL_0116:
	{
		// }
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_39 = __this->get_address_of_U3CU3Et__builder_1();
		ETAsyncTaskMethodBuilder_SetResult_m985BE32D35AB03DC4CE000D8D9A2BFACB8B7A88B((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_39, /*hidden argument*/NULL);
	}

IL_0129:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CStartSendU3Ed__15_MoveNext_m5A2FAB35FEF8A1D2638A92B2AF086F6B17ABE055_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 * _thisAdjusted = reinterpret_cast<U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 *>(__this + _offset);
	U3CStartSendU3Ed__15_MoveNext_m5A2FAB35FEF8A1D2638A92B2AF086F6B17ABE055(_thisAdjusted, method);
}
// System.Void ET.WChannel/<StartSend>d__15::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartSendU3Ed__15_SetStateMachine_m6F79A85253722DF738F762E00AED8BE912EAF268 (U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	{
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_0 = __this->get_address_of_U3CU3Et__builder_1();
		RuntimeObject* L_1 = ___stateMachine0;
		ETAsyncTaskMethodBuilder_SetStateMachine_mFECCC5F702F4D3B9598975007D961FE4D0BFAAC3((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CStartSendU3Ed__15_SetStateMachine_m6F79A85253722DF738F762E00AED8BE912EAF268_AdjustorThunk (RuntimeObject * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 * _thisAdjusted = reinterpret_cast<U3CStartSendU3Ed__15_tBFDCAE9568C48766A45936029585E5E2DE00F162 *>(__this + _offset);
	U3CStartSendU3Ed__15_SetStateMachine_m6F79A85253722DF738F762E00AED8BE912EAF268(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void ET.WService/<StartAccept>d__12::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartAcceptU3Ed__12_MoveNext_mBF535DCEC52A35459F64CF39C14B0B8685F2110D (U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mEA97895401C9E128BC88F3D235F7BC79D107D052_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_m70C423FEFD680FB2A62EB0131C67A46D80F73C1F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_mACF8F057852CBC55283D1FB99088AFA3DB047A2C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_1_tBD60400523D840591A17E4CBBACC79397F68FAA2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_1_t0DE5AA701B682A891412350E63D3E441F98F205C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskAwaiter_1_GetResult_m9F9A1E7D4504D843ACF08CB847674ACB717B07B7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskAwaiter_1_GetResult_mCE6EEB08A3F3CD7DA4D0B764AC8A22E5AE8242A8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskAwaiter_1_get_IsCompleted_m0450A198520AE843F0245B5CF36EEC50B4718E0B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskAwaiter_1_get_IsCompleted_m5407555CDC2063AC7E69154390A144F53D7B370F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Task_1_GetAwaiter_m03F3C2C642FE0130BAE3F8BBFAB13E7BB19707B3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Task_1_GetAwaiter_m4323D9958B429E8928A9758244674DB503E63EF4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * V_1 = NULL;
	RuntimeObject* V_2 = NULL;
	String_t* V_3 = NULL;
	HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * V_4 = NULL;
	WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * V_5 = NULL;
	TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  V_6;
	memset((&V_6), 0, sizeof(V_6));
	TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  V_7;
	memset((&V_7), 0, sizeof(V_7));
	HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF * V_8 = NULL;
	Exception_t * V_9 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 3> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 9> __leave_targets;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * L_1 = __this->get_U3CU3E4__this_3();
		V_1 = L_1;
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			int32_t L_2 = V_0;
		}

IL_0013:
		try
		{ // begin try (depth: 2)
			{
				int32_t L_3 = V_0;
				if ((!(((uint32_t)L_3) > ((uint32_t)1))))
				{
					goto IL_0060;
				}
			}

IL_0017:
			{
				// foreach (string prefix in prefixs)
				RuntimeObject* L_4 = __this->get_prefixs_2();
				NullCheck(L_4);
				RuntimeObject* L_5;
				L_5 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.Generic.IEnumerator`1<!0> System.Collections.Generic.IEnumerable`1<System.String>::GetEnumerator() */, IEnumerable_1_tBD60400523D840591A17E4CBBACC79397F68FAA2_il2cpp_TypeInfo_var, L_4);
				V_2 = L_5;
			}

IL_0023:
			try
			{ // begin try (depth: 3)
				{
					goto IL_003d;
				}

IL_0025:
				{
					// foreach (string prefix in prefixs)
					RuntimeObject* L_6 = V_2;
					NullCheck(L_6);
					String_t* L_7;
					L_7 = InterfaceFuncInvoker0< String_t* >::Invoke(0 /* !0 System.Collections.Generic.IEnumerator`1<System.String>::get_Current() */, IEnumerator_1_t0DE5AA701B682A891412350E63D3E441F98F205C_il2cpp_TypeInfo_var, L_6);
					V_3 = L_7;
					// this.httpListener.Prefixes.Add(prefix);
					WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * L_8 = V_1;
					NullCheck(L_8);
					HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * L_9 = L_8->get_httpListener_8();
					NullCheck(L_9);
					HttpListenerPrefixCollection_tEE2B7EC42FFA3565285AC8455E9F095ABD4FD283 * L_10;
					L_10 = HttpListener_get_Prefixes_m9632A8FF20E68DC9770668813E57345354144298(L_9, /*hidden argument*/NULL);
					String_t* L_11 = V_3;
					NullCheck(L_10);
					HttpListenerPrefixCollection_Add_mC81B7F10D756C258BA242226C9ADF5EFD1A28250(L_10, L_11, /*hidden argument*/NULL);
				}

IL_003d:
				{
					// foreach (string prefix in prefixs)
					RuntimeObject* L_12 = V_2;
					NullCheck(L_12);
					bool L_13;
					L_13 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_12);
					if (L_13)
					{
						goto IL_0025;
					}
				}

IL_0045:
				{
					IL2CPP_LEAVE(0x55, FINALLY_0047);
				}
			} // end try (depth: 3)
			catch(Il2CppExceptionWrapper& e)
			{
				__last_unhandled_exception = (Exception_t *)e.ex;
				goto FINALLY_0047;
			}

FINALLY_0047:
			{ // begin finally (depth: 3)
				{
					int32_t L_14 = V_0;
					if ((((int32_t)L_14) >= ((int32_t)0)))
					{
						goto IL_0054;
					}
				}

IL_004b:
				{
					RuntimeObject* L_15 = V_2;
					if (!L_15)
					{
						goto IL_0054;
					}
				}

IL_004e:
				{
					RuntimeObject* L_16 = V_2;
					NullCheck(L_16);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_16);
				}

IL_0054:
				{
					IL2CPP_END_FINALLY(71)
				}
			} // end finally (depth: 3)
			IL2CPP_CLEANUP(71)
			{
				IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
				IL2CPP_JUMP_TBL(0x55, IL_0055)
			}

IL_0055:
			{
				// httpListener.Start();
				WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * L_17 = V_1;
				NullCheck(L_17);
				HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * L_18 = L_17->get_httpListener_8();
				NullCheck(L_18);
				HttpListener_Start_m0A043055653F94400CC94661D972C84C30E86043(L_18, /*hidden argument*/NULL);
			}

IL_0060:
			{
			}

IL_0061:
			try
			{ // begin try (depth: 3)
				{
					int32_t L_19 = V_0;
					if (!L_19)
					{
						goto IL_00aa;
					}
				}

IL_0064:
				{
					int32_t L_20 = V_0;
					if ((((int32_t)L_20) == ((int32_t)1)))
					{
						goto IL_0108;
					}
				}

IL_006b:
				{
					// HttpListenerContext httpListenerContext = await this.httpListener.GetContextAsync();
					WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * L_21 = V_1;
					NullCheck(L_21);
					HttpListener_tD4F9D686C3CBAEA5C24A554A088DDD34D056E4F1 * L_22 = L_21->get_httpListener_8();
					NullCheck(L_22);
					Task_1_tF80EAF91EE0A0400B5ADA1846DFAD4491E8A8D33 * L_23;
					L_23 = HttpListener_GetContextAsync_m7662749B26AA3702E4B6D4B0A5360EE7A4B95509(L_22, /*hidden argument*/NULL);
					NullCheck(L_23);
					TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  L_24;
					L_24 = Task_1_GetAwaiter_m03F3C2C642FE0130BAE3F8BBFAB13E7BB19707B3(L_23, /*hidden argument*/Task_1_GetAwaiter_m03F3C2C642FE0130BAE3F8BBFAB13E7BB19707B3_RuntimeMethod_var);
					V_6 = L_24;
					bool L_25;
					L_25 = TaskAwaiter_1_get_IsCompleted_m5407555CDC2063AC7E69154390A144F53D7B370F((TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 *)(&V_6), /*hidden argument*/TaskAwaiter_1_get_IsCompleted_m5407555CDC2063AC7E69154390A144F53D7B370F_RuntimeMethod_var);
					if (L_25)
					{
						goto IL_00c7;
					}
				}

IL_0086:
				{
					int32_t L_26 = 0;
					V_0 = L_26;
					__this->set_U3CU3E1__state_0(L_26);
					TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  L_27 = V_6;
					__this->set_U3CU3Eu__1_4(L_27);
					ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_28 = __this->get_address_of_U3CU3Et__builder_1();
					ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_m70C423FEFD680FB2A62EB0131C67A46D80F73C1F((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_28, (TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 *)(&V_6), (U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE *)__this, /*hidden argument*/ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_m70C423FEFD680FB2A62EB0131C67A46D80F73C1F_RuntimeMethod_var);
					goto IL_01cc;
				}

IL_00aa:
				{
					TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381  L_29 = __this->get_U3CU3Eu__1_4();
					V_6 = L_29;
					TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 * L_30 = __this->get_address_of_U3CU3Eu__1_4();
					il2cpp_codegen_initobj(L_30, sizeof(TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 ));
					int32_t L_31 = (-1);
					V_0 = L_31;
					__this->set_U3CU3E1__state_0(L_31);
				}

IL_00c7:
				{
					HttpListenerContext_t54B97C4A4AFCA81BBB6C289899C01F444BBA0117 * L_32;
					L_32 = TaskAwaiter_1_GetResult_mCE6EEB08A3F3CD7DA4D0B764AC8A22E5AE8242A8((TaskAwaiter_1_t7DA6F587FA9888597196C1622759E869F1C98381 *)(&V_6), /*hidden argument*/TaskAwaiter_1_GetResult_mCE6EEB08A3F3CD7DA4D0B764AC8A22E5AE8242A8_RuntimeMethod_var);
					// HttpListenerWebSocketContext webSocketContext = await httpListenerContext.AcceptWebSocketAsync(null);
					NullCheck(L_32);
					Task_1_t7156770CBC4F1495A3BE667C19D0D453FDCE36BC * L_33;
					L_33 = HttpListenerContext_AcceptWebSocketAsync_m8EA6D4ADE8019B6FF83A9C6332491BDAC762B8EF(L_32, (String_t*)NULL, /*hidden argument*/NULL);
					NullCheck(L_33);
					TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  L_34;
					L_34 = Task_1_GetAwaiter_m4323D9958B429E8928A9758244674DB503E63EF4(L_33, /*hidden argument*/Task_1_GetAwaiter_m4323D9958B429E8928A9758244674DB503E63EF4_RuntimeMethod_var);
					V_7 = L_34;
					bool L_35;
					L_35 = TaskAwaiter_1_get_IsCompleted_m0450A198520AE843F0245B5CF36EEC50B4718E0B((TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD *)(&V_7), /*hidden argument*/TaskAwaiter_1_get_IsCompleted_m0450A198520AE843F0245B5CF36EEC50B4718E0B_RuntimeMethod_var);
					if (L_35)
					{
						goto IL_0125;
					}
				}

IL_00e4:
				{
					int32_t L_36 = 1;
					V_0 = L_36;
					__this->set_U3CU3E1__state_0(L_36);
					TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  L_37 = V_7;
					__this->set_U3CU3Eu__2_5(L_37);
					ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_38 = __this->get_address_of_U3CU3Et__builder_1();
					ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_mACF8F057852CBC55283D1FB99088AFA3DB047A2C((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_38, (TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD *)(&V_7), (U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE *)__this, /*hidden argument*/ETAsyncTaskMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD_TisU3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE_mACF8F057852CBC55283D1FB99088AFA3DB047A2C_RuntimeMethod_var);
					goto IL_01cc;
				}

IL_0108:
				{
					TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD  L_39 = __this->get_U3CU3Eu__2_5();
					V_7 = L_39;
					TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD * L_40 = __this->get_address_of_U3CU3Eu__2_5();
					il2cpp_codegen_initobj(L_40, sizeof(TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD ));
					int32_t L_41 = (-1);
					V_0 = L_41;
					__this->set_U3CU3E1__state_0(L_41);
				}

IL_0125:
				{
					HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * L_42;
					L_42 = TaskAwaiter_1_GetResult_m9F9A1E7D4504D843ACF08CB847674ACB717B07B7((TaskAwaiter_1_tB5475C135FDDC2907EDDF653D868A2D14A5B1ABD *)(&V_7), /*hidden argument*/TaskAwaiter_1_GetResult_m9F9A1E7D4504D843ACF08CB847674ACB717B07B7_RuntimeMethod_var);
					V_4 = L_42;
					// WChannel channel = new WChannel(this.GetId, webSocketContext, this);
					WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * L_43 = V_1;
					NullCheck(L_43);
					int64_t L_44;
					L_44 = WService_get_GetId_m74A4D3DE92F81CD576DD4645472FE83F512952B2(L_43, /*hidden argument*/NULL);
					HttpListenerWebSocketContext_t13E1BD038762B7877488A1E2B5F8C0960FC87E33 * L_45 = V_4;
					WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * L_46 = V_1;
					WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_47 = (WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 *)il2cpp_codegen_object_new(WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93_il2cpp_TypeInfo_var);
					WChannel__ctor_mF8C76CEE10FC5F7770EE013DE372E64D82A79DBF(L_47, L_44, L_45, L_46, /*hidden argument*/NULL);
					V_5 = L_47;
					// this.channels[channel.Id] = channel;
					WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * L_48 = V_1;
					NullCheck(L_48);
					Dictionary_2_tC7F0B914F33D5C048A0538A868AB5C0AAE406EDE * L_49 = L_48->get_channels_9();
					WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_50 = V_5;
					NullCheck(L_50);
					int64_t L_51 = ((AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432 *)L_50)->get_Id_0();
					WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_52 = V_5;
					NullCheck(L_49);
					Dictionary_2_set_Item_mEA97895401C9E128BC88F3D235F7BC79D107D052(L_49, L_51, L_52, /*hidden argument*/Dictionary_2_set_Item_mEA97895401C9E128BC88F3D235F7BC79D107D052_RuntimeMethod_var);
					// this.OnAccept(channel.Id, channel.RemoteAddress);
					WService_tE3AB2FC44BEAF596C1382ABF40B6FC04A63B56B1 * L_53 = V_1;
					WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_54 = V_5;
					NullCheck(L_54);
					int64_t L_55 = ((AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432 *)L_54)->get_Id_0();
					WChannel_t6CECB286964D3BB9BD483BDAF6C7C8BF366E6F93 * L_56 = V_5;
					NullCheck(L_56);
					IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * L_57;
					L_57 = AChannel_get_RemoteAddress_m44608A1AAAD2C9B33577B94FBD3D04469973585E_inline(L_56, /*hidden argument*/NULL);
					NullCheck(L_53);
					AService_OnAccept_m6DAACBA870A623CD54A535546E363AB29665A8CC(L_53, L_55, L_57, /*hidden argument*/NULL);
					// }
					goto IL_0060;
				}
			} // end try (depth: 3)
			catch(Il2CppExceptionWrapper& e)
			{
				if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
				{
					IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
					goto CATCH_016b;
				}
				throw e;
			}

CATCH_016b:
			{ // begin catch(System.Exception)
				// Log.Error(e);
				Log_Error_mC1EB3767E2A28400D0ED5C10C1B0FB83FDF39365(((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *)), /*hidden argument*/NULL);
				// }
				IL2CPP_POP_ACTIVE_EXCEPTION();
				goto IL_0060;
			} // end catch (depth: 3)
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_0175;
			}
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_0197;
			}
			throw e;
		}

CATCH_0175:
		{ // begin catch(System.Net.HttpListenerException)
			{
				// catch (HttpListenerException e)
				V_8 = ((HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF *)IL2CPP_GET_ACTIVE_EXCEPTION(HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF *));
				// if (e.ErrorCode == 5)
				HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF * L_58 = V_8;
				NullCheck(L_58);
				int32_t L_59;
				L_59 = VirtFuncInvoker0< int32_t >::Invoke(29 /* System.Int32 System.Runtime.InteropServices.ExternalException::get_ErrorCode() */, L_58);
				if ((!(((uint32_t)L_59) == ((uint32_t)5))))
				{
					goto IL_018e;
				}
			}

IL_0181:
			{
				// throw new Exception($"CMD管理员中输入: netsh http add urlacl url=http://*:8080/ user=Everyone", e);
				HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF * L_60 = V_8;
				Exception_t * L_61 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
				Exception__ctor_mB842BA6E644CDB9DB058F5628BB90DF5EF22C080(L_61, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralCCDFA92C7C90AFE4EE7318DA274C1053FF9D7695)), L_60, /*hidden argument*/NULL);
				IL2CPP_RAISE_MANAGED_EXCEPTION(L_61, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CStartAcceptU3Ed__12_MoveNext_mBF535DCEC52A35459F64CF39C14B0B8685F2110D_RuntimeMethod_var)));
			}

IL_018e:
			{
				// Log.Error(e);
				HttpListenerException_t8CFAD40EE4A4CE183B360C8CD1C94B71484526AF * L_62 = V_8;
				Log_Error_mC1EB3767E2A28400D0ED5C10C1B0FB83FDF39365(L_62, /*hidden argument*/NULL);
				// }
				IL2CPP_POP_ACTIVE_EXCEPTION();
				goto IL_019e;
			}
		} // end catch (depth: 2)

CATCH_0197:
		{ // begin catch(System.Exception)
			// Log.Error(e);
			Log_Error_mC1EB3767E2A28400D0ED5C10C1B0FB83FDF39365(((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *)), /*hidden argument*/NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_019e;
		} // end catch (depth: 2)

IL_019e:
		{
			goto IL_01b9;
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_01a0;
		}
		throw e;
	}

CATCH_01a0:
	{ // begin catch(System.Exception)
		V_9 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_63 = __this->get_address_of_U3CU3Et__builder_1();
		Exception_t * L_64 = V_9;
		ETAsyncTaskMethodBuilder_SetException_m94B10E7E2F8D77DDE977C587A7444B7EC17DCC71((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_63, L_64, /*hidden argument*/NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_01cc;
	} // end catch (depth: 1)

IL_01b9:
	{
		// }
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_65 = __this->get_address_of_U3CU3Et__builder_1();
		ETAsyncTaskMethodBuilder_SetResult_m985BE32D35AB03DC4CE000D8D9A2BFACB8B7A88B((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_65, /*hidden argument*/NULL);
	}

IL_01cc:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CStartAcceptU3Ed__12_MoveNext_mBF535DCEC52A35459F64CF39C14B0B8685F2110D_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * _thisAdjusted = reinterpret_cast<U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE *>(__this + _offset);
	U3CStartAcceptU3Ed__12_MoveNext_mBF535DCEC52A35459F64CF39C14B0B8685F2110D(_thisAdjusted, method);
}
// System.Void ET.WService/<StartAccept>d__12::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartAcceptU3Ed__12_SetStateMachine_m2F77662D5C4721760033BC3F3516F52987470B67 (U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	{
		ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F * L_0 = __this->get_address_of_U3CU3Et__builder_1();
		RuntimeObject* L_1 = ___stateMachine0;
		ETAsyncTaskMethodBuilder_SetStateMachine_mFECCC5F702F4D3B9598975007D961FE4D0BFAAC3((ETAsyncTaskMethodBuilder_tFC2F55F328E847ABB765AE06AEA87D67286DBD4F *)L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CStartAcceptU3Ed__12_SetStateMachine_m2F77662D5C4721760033BC3F3516F52987470B67_AdjustorThunk (RuntimeObject * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE * _thisAdjusted = reinterpret_cast<U3CStartAcceptU3Ed__12_tEF2B5CDB56B68875AF98D1420C5826DBDFD465FE *>(__this + _offset);
	U3CStartAcceptU3Ed__12_SetStateMachine_m2F77662D5C4721760033BC3F3516F52987470B67(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void instantiateEffectCaller/chainEffect::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void chainEffect__ctor_m569B56E38A93D7D813B9B61C9EE5242A1BFA3C3A (chainEffect_t86AB203988F70EBB301E81E78456C8BC8D99F8EE * __this, const RuntimeMethod* method)
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
// System.Void particleColorChanger/colorChange::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void colorChange__ctor_m1844449AC2D246C943DC830A386943AAF6DED6AD (colorChange_t90D67E9441CA1F572801FE59E3CBDA1416AFF4B5 * __this, const RuntimeMethod* method)
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
// System.Void projectileActor/projectile::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void projectile__ctor_m2AFFF20E864DFB8D620590D930FE6313E59F62F6 (projectile_t92718EFF331FD6AC7D20F826D53866FF092D8ED9 * __this, const RuntimeMethod* method)
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
// System.Void ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CAwakeU3Ed__18_MoveNext_mDCE82912BC8FC5F255C49854F30D25838E63CB6A (U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D_mADD06B426C3D8B131B2D9AF08601BAB40AE72515_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7DE18B9B94414FE9BDBA0668D8B260329D4DF2AA);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * V_1 = NULL;
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  V_2;
	memset((&V_2), 0, sizeof(V_2));
	Exception_t * V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 3> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 8> __leave_targets;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_1 = __this->get_U3CU3E4__this_2();
		V_1 = L_1;
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			int32_t L_2 = V_0;
		}

IL_0011:
		try
		{ // begin try (depth: 2)
			{
				int32_t L_3 = V_0;
				if (!L_3)
				{
					goto IL_005d;
				}
			}

IL_0014:
			{
				// if (instance != null)
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_4 = V_1;
				NullCheck(L_4);
				ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * L_5 = L_4->get_instance_4();
				if (!L_5)
				{
					goto IL_012b;
				}
			}

IL_001f:
			{
				// if (!mAwakeMethodGot)
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_6 = V_1;
				NullCheck(L_6);
				bool L_7 = L_6->get_mAwakeMethodGot_10();
				if (L_7)
				{
					goto IL_004b;
				}
			}

IL_0027:
			{
				// mAwakeMethod = instance.Type.GetMethod("Awake", 0);
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_8 = V_1;
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_9 = V_1;
				NullCheck(L_9);
				ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * L_10 = L_9->get_instance_4();
				NullCheck(L_10);
				ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * L_11;
				L_11 = ILTypeInstance_get_Type_mC878DA7939714DD13AE31EE38E3F5DE9199B4937_inline(L_10, /*hidden argument*/NULL);
				NullCheck(L_11);
				RuntimeObject* L_12;
				L_12 = ILType_GetMethod_m0893FB8B1DFF4B883238D84CD116018ED057E20A(L_11, _stringLiteral7DE18B9B94414FE9BDBA0668D8B260329D4DF2AA, 0, (bool)0, /*hidden argument*/NULL);
				NullCheck(L_8);
				L_8->set_mAwakeMethod_9(L_12);
				// mAwakeMethodGot = true;
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_13 = V_1;
				NullCheck(L_13);
				L_13->set_mAwakeMethodGot_10((bool)1);
			}

IL_004b:
			{
				// if (!isAwaking)
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_14 = V_1;
				NullCheck(L_14);
				bool L_15 = L_14->get_isAwaking_12();
				if (L_15)
				{
					goto IL_012b;
				}
			}

IL_0056:
			{
				// isAwaking = true;
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_16 = V_1;
				NullCheck(L_16);
				L_16->set_isAwaking_12((bool)1);
			}

IL_005d:
			{
			}

IL_005e:
			try
			{ // begin try (depth: 3)
				{
					int32_t L_17 = V_0;
					if (!L_17)
					{
						goto IL_009c;
					}
				}

IL_0061:
				{
					goto IL_00bf;
				}

IL_0063:
				{
					// await Task.Delay(20);
					IL2CPP_RUNTIME_CLASS_INIT(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_il2cpp_TypeInfo_var);
					Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * L_18;
					L_18 = Task_Delay_mD54722DBAF22507493263E9B1167A7F77EDDF80E(((int32_t)20), /*hidden argument*/NULL);
					NullCheck(L_18);
					TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_19;
					L_19 = Task_GetAwaiter_m1FF7528A8FE13F79207DFE970F642078EF6B1260(L_18, /*hidden argument*/NULL);
					V_2 = L_19;
					bool L_20;
					L_20 = TaskAwaiter_get_IsCompleted_m6F97613C55E505B5664C3C0CFC4677D296EAA8BC((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), /*hidden argument*/NULL);
					if (L_20)
					{
						goto IL_00b8;
					}
				}

IL_0079:
				{
					int32_t L_21 = 0;
					V_0 = L_21;
					__this->set_U3CU3E1__state_0(L_21);
					TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_22 = V_2;
					__this->set_U3CU3Eu__1_3(L_22);
					AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * L_23 = __this->get_address_of_U3CU3Et__builder_1();
					AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D_mADD06B426C3D8B131B2D9AF08601BAB40AE72515((AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *)L_23, (TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), (U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D *)__this, /*hidden argument*/AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D_mADD06B426C3D8B131B2D9AF08601BAB40AE72515_RuntimeMethod_var);
					goto IL_0162;
				}

IL_009c:
				{
					TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_24 = __this->get_U3CU3Eu__1_3();
					V_2 = L_24;
					TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * L_25 = __this->get_address_of_U3CU3Eu__1_3();
					il2cpp_codegen_initobj(L_25, sizeof(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C ));
					int32_t L_26 = (-1);
					V_0 = L_26;
					__this->set_U3CU3E1__state_0(L_26);
				}

IL_00b8:
				{
					TaskAwaiter_GetResult_m578EEFEC4DD1AE5E77C899B8BAA3825EB79D1330((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), /*hidden argument*/NULL);
				}

IL_00bf:
				{
					// while (Application.isPlaying && !destoryed && !gameObject.activeInHierarchy)
					bool L_27;
					L_27 = Application_get_isPlaying_m7BB718D8E58B807184491F64AFF0649517E56567(/*hidden argument*/NULL);
					if (!L_27)
					{
						goto IL_00db;
					}
				}

IL_00c6:
				{
					Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_28 = V_1;
					NullCheck(L_28);
					bool L_29 = L_28->get_destoryed_8();
					if (L_29)
					{
						goto IL_00db;
					}
				}

IL_00ce:
				{
					Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_30 = V_1;
					NullCheck(L_30);
					GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_31;
					L_31 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_30, /*hidden argument*/NULL);
					NullCheck(L_31);
					bool L_32;
					L_32 = GameObject_get_activeInHierarchy_mA3990AC5F61BB35283188E925C2BE7F7BF67734B(L_31, /*hidden argument*/NULL);
					if (!L_32)
					{
						goto IL_0063;
					}
				}

IL_00db:
				{
					// }
					goto IL_00e0;
				}
			} // end try (depth: 3)
			catch(Il2CppExceptionWrapper& e)
			{
				if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&MissingReferenceException_t0957F7F403A0B9249CE6AB66FAD46E626F787EE8_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
				{
					IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
					goto CATCH_00dd;
				}
				throw e;
			}

CATCH_00dd:
			{ // begin catch(UnityEngine.MissingReferenceException)
				// catch (MissingReferenceException) //如果gameObject被删了，就会触发这个，这个时候就直接return了
				// return;
				IL2CPP_POP_ACTIVE_EXCEPTION();
				goto IL_014f;
			} // end catch (depth: 3)

IL_00e0:
			{
				// if (destoryed || !Application.isPlaying)
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_33 = V_1;
				NullCheck(L_33);
				bool L_34 = L_33->get_destoryed_8();
				if (L_34)
				{
					goto IL_00ef;
				}
			}

IL_00e8:
			{
				bool L_35;
				L_35 = Application_get_isPlaying_m7BB718D8E58B807184491F64AFF0649517E56567(/*hidden argument*/NULL);
				if (L_35)
				{
					goto IL_00f1;
				}
			}

IL_00ef:
			{
				// return;
				goto IL_014f;
			}

IL_00f1:
			{
				// if (mAwakeMethod != null)
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_36 = V_1;
				NullCheck(L_36);
				RuntimeObject* L_37 = L_36->get_mAwakeMethod_9();
				if (!L_37)
				{
					goto IL_0117;
				}
			}

IL_00f9:
			{
				// appdomain.Invoke(mAwakeMethod, instance, param0);
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_38 = V_1;
				NullCheck(L_38);
				AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * L_39 = L_38->get_appdomain_5();
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_40 = V_1;
				NullCheck(L_40);
				RuntimeObject* L_41 = L_40->get_mAwakeMethod_9();
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_42 = V_1;
				NullCheck(L_42);
				ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * L_43 = L_42->get_instance_4();
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_44 = V_1;
				NullCheck(L_44);
				ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_45 = L_44->get_param0_7();
				NullCheck(L_39);
				RuntimeObject * L_46;
				L_46 = AppDomain_Invoke_m01501668384C8C306EA59E43689038EF3D7DD355(L_39, L_41, L_43, L_45, /*hidden argument*/NULL);
			}

IL_0117:
			{
				// isAwaking = false;
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_47 = V_1;
				NullCheck(L_47);
				L_47->set_isAwaking_12((bool)0);
				// awaked = true;
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_48 = V_1;
				NullCheck(L_48);
				L_48->set_awaked_11((bool)1);
				// OnEnable();
				Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_49 = V_1;
				NullCheck(L_49);
				Adaptor_OnEnable_m148F0BD477129D4E91C21EF601E63C6EE4A3E0DE(L_49, /*hidden argument*/NULL);
			}

IL_012b:
			{
				// }
				goto IL_0136;
			}
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NullReferenceException_t44B4F3CDE3111E74591952B8BE8707B28866D724_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
			{
				IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
				goto CATCH_012d;
			}
			throw e;
		}

CATCH_012d:
		{ // begin catch(System.NullReferenceException)
			// catch (NullReferenceException)
			// Awake();
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_50 = V_1;
			NullCheck(L_50);
			Adaptor_Awake_mADB9789D0CC503886A47E8CB40E11F36E2A455A8(L_50, /*hidden argument*/NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_0136;
		} // end catch (depth: 2)

IL_0136:
		{
			goto IL_014f;
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0138;
		}
		throw e;
	}

CATCH_0138:
	{ // begin catch(System.Exception)
		V_3 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * L_51 = __this->get_address_of_U3CU3Et__builder_1();
		Exception_t * L_52 = V_3;
		AsyncVoidMethodBuilder_SetException_m16372173CEA3031B4CB9B8D15DA97C457F835155((AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *)L_51, L_52, /*hidden argument*/NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0162;
	} // end catch (depth: 1)

IL_014f:
	{
		// }
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * L_53 = __this->get_address_of_U3CU3Et__builder_1();
		AsyncVoidMethodBuilder_SetResult_m901385B56EBE93E472A77EA48F61E4F498F3E00E((AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *)L_53, /*hidden argument*/NULL);
	}

IL_0162:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CAwakeU3Ed__18_MoveNext_mDCE82912BC8FC5F255C49854F30D25838E63CB6A_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D * _thisAdjusted = reinterpret_cast<U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D *>(__this + _offset);
	U3CAwakeU3Ed__18_MoveNext_mDCE82912BC8FC5F255C49854F30D25838E63CB6A(_thisAdjusted, method);
}
// System.Void ET.MonoBehaviourAdapter/Adaptor/<Awake>d__18::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CAwakeU3Ed__18_SetStateMachine_m7E4DB6EC7CF1932501BBE25C7DD83706822D93B2 (U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	{
		AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * L_0 = __this->get_address_of_U3CU3Et__builder_1();
		RuntimeObject* L_1 = ___stateMachine0;
		AsyncVoidMethodBuilder_SetStateMachine_m1ED99BE03B146D8A7117E299EBA5D74999EB52D7((AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *)L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CAwakeU3Ed__18_SetStateMachine_m7E4DB6EC7CF1932501BBE25C7DD83706822D93B2_AdjustorThunk (RuntimeObject * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D * _thisAdjusted = reinterpret_cast<U3CAwakeU3Ed__18_tD959B5BC8BB4EFFAE85322718C2FB26AB929596D *>(__this + _offset);
	U3CAwakeU3Ed__18_SetStateMachine_m7E4DB6EC7CF1932501BBE25C7DD83706822D93B2(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void ET.MonoBehaviourAdapter/Adaptor/<Start>d__21::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartU3Ed__21_MoveNext_mF6E2ED62890FEE5CF2A654E4F9358581A1A2D1E7 (U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F_mC22F9B7E118032FDAE087379683D6E4516C0BFC3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8243A16D425F93AF62CAAB2BFAE01A2D6246A5FE);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * V_1 = NULL;
	TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  V_2;
	memset((&V_2), 0, sizeof(V_2));
	Exception_t * V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 4> __leave_targets;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_1 = __this->get_U3CU3E4__this_2();
		V_1 = L_1;
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			int32_t L_2 = V_0;
			if (!L_2)
			{
				goto IL_005e;
			}
		}

IL_0011:
		{
			// if (!isMonoBehaviour) return;
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_3 = V_1;
			NullCheck(L_3);
			bool L_4 = L_3->get_isMonoBehaviour_6();
			if (L_4)
			{
				goto IL_001e;
			}
		}

IL_0019:
		{
			// if (!isMonoBehaviour) return;
			goto IL_00ec;
		}

IL_001e:
		{
			// if (instance == null)
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_5 = V_1;
			NullCheck(L_5);
			ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * L_6 = L_5->get_instance_4();
			if (L_6)
			{
				goto IL_0081;
			}
		}

IL_0026:
		{
			// await Task.Delay(1);
			IL2CPP_RUNTIME_CLASS_INIT(Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60_il2cpp_TypeInfo_var);
			Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60 * L_7;
			L_7 = Task_Delay_mD54722DBAF22507493263E9B1167A7F77EDDF80E(1, /*hidden argument*/NULL);
			NullCheck(L_7);
			TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_8;
			L_8 = Task_GetAwaiter_m1FF7528A8FE13F79207DFE970F642078EF6B1260(L_7, /*hidden argument*/NULL);
			V_2 = L_8;
			bool L_9;
			L_9 = TaskAwaiter_get_IsCompleted_m6F97613C55E505B5664C3C0CFC4677D296EAA8BC((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), /*hidden argument*/NULL);
			if (L_9)
			{
				goto IL_007a;
			}
		}

IL_003b:
		{
			int32_t L_10 = 0;
			V_0 = L_10;
			__this->set_U3CU3E1__state_0(L_10);
			TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_11 = V_2;
			__this->set_U3CU3Eu__1_3(L_11);
			AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * L_12 = __this->get_address_of_U3CU3Et__builder_1();
			AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F_mC22F9B7E118032FDAE087379683D6E4516C0BFC3((AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *)L_12, (TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), (U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F *)__this, /*hidden argument*/AsyncVoidMethodBuilder_AwaitUnsafeOnCompleted_TisTaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C_TisU3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F_mC22F9B7E118032FDAE087379683D6E4516C0BFC3_RuntimeMethod_var);
			goto IL_00ff;
		}

IL_005e:
		{
			TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C  L_13 = __this->get_U3CU3Eu__1_3();
			V_2 = L_13;
			TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C * L_14 = __this->get_address_of_U3CU3Eu__1_3();
			il2cpp_codegen_initobj(L_14, sizeof(TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C ));
			int32_t L_15 = (-1);
			V_0 = L_15;
			__this->set_U3CU3E1__state_0(L_15);
		}

IL_007a:
		{
			TaskAwaiter_GetResult_m578EEFEC4DD1AE5E77C899B8BAA3825EB79D1330((TaskAwaiter_t3780D365E9D10C2D6C4E76C78AA0CDF92B8F181C *)(&V_2), /*hidden argument*/NULL);
		}

IL_0081:
		{
			// if (!mStartMethodGot)
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_16 = V_1;
			NullCheck(L_16);
			bool L_17 = L_16->get_mStartMethodGot_14();
			if (L_17)
			{
				goto IL_00ad;
			}
		}

IL_0089:
		{
			// mStartMethod = instance.Type.GetMethod("Start", 0);
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_18 = V_1;
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_19 = V_1;
			NullCheck(L_19);
			ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * L_20 = L_19->get_instance_4();
			NullCheck(L_20);
			ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * L_21;
			L_21 = ILTypeInstance_get_Type_mC878DA7939714DD13AE31EE38E3F5DE9199B4937_inline(L_20, /*hidden argument*/NULL);
			NullCheck(L_21);
			RuntimeObject* L_22;
			L_22 = ILType_GetMethod_m0893FB8B1DFF4B883238D84CD116018ED057E20A(L_21, _stringLiteral8243A16D425F93AF62CAAB2BFAE01A2D6246A5FE, 0, (bool)0, /*hidden argument*/NULL);
			NullCheck(L_18);
			L_18->set_mStartMethod_13(L_22);
			// mStartMethodGot = true;
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_23 = V_1;
			NullCheck(L_23);
			L_23->set_mStartMethodGot_14((bool)1);
		}

IL_00ad:
		{
			// if (mStartMethod != null)
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_24 = V_1;
			NullCheck(L_24);
			RuntimeObject* L_25 = L_24->get_mStartMethod_13();
			if (!L_25)
			{
				goto IL_00d3;
			}
		}

IL_00b5:
		{
			// appdomain.Invoke(mStartMethod, instance, param0);
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_26 = V_1;
			NullCheck(L_26);
			AppDomain_t19E43EFE7921E7FD0AF4E214BF04EDEADBE8D371 * L_27 = L_26->get_appdomain_5();
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_28 = V_1;
			NullCheck(L_28);
			RuntimeObject* L_29 = L_28->get_mStartMethod_13();
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_30 = V_1;
			NullCheck(L_30);
			ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * L_31 = L_30->get_instance_4();
			Adaptor_tE31C04E7A4C0E7AC371CB16B68BDDF9508421A11 * L_32 = V_1;
			NullCheck(L_32);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_33 = L_32->get_param0_7();
			NullCheck(L_27);
			RuntimeObject * L_34;
			L_34 = AppDomain_Invoke_m01501668384C8C306EA59E43689038EF3D7DD355(L_27, L_29, L_31, L_33, /*hidden argument*/NULL);
		}

IL_00d3:
		{
			goto IL_00ec;
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_00d5;
		}
		throw e;
	}

CATCH_00d5:
	{ // begin catch(System.Exception)
		V_3 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * L_35 = __this->get_address_of_U3CU3Et__builder_1();
		Exception_t * L_36 = V_3;
		AsyncVoidMethodBuilder_SetException_m16372173CEA3031B4CB9B8D15DA97C457F835155((AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *)L_35, L_36, /*hidden argument*/NULL);
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00ff;
	} // end catch (depth: 1)

IL_00ec:
	{
		// }
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * L_37 = __this->get_address_of_U3CU3Et__builder_1();
		AsyncVoidMethodBuilder_SetResult_m901385B56EBE93E472A77EA48F61E4F498F3E00E((AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *)L_37, /*hidden argument*/NULL);
	}

IL_00ff:
	{
		return;
	}
}
IL2CPP_EXTERN_C  void U3CStartU3Ed__21_MoveNext_mF6E2ED62890FEE5CF2A654E4F9358581A1A2D1E7_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F * _thisAdjusted = reinterpret_cast<U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F *>(__this + _offset);
	U3CStartU3Ed__21_MoveNext_mF6E2ED62890FEE5CF2A654E4F9358581A1A2D1E7(_thisAdjusted, method);
}
// System.Void ET.MonoBehaviourAdapter/Adaptor/<Start>d__21::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CStartU3Ed__21_SetStateMachine_m18818E7BF447ED99FDA6431D59BA2C7E6C72FCE0 (U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	{
		AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 * L_0 = __this->get_address_of_U3CU3Et__builder_1();
		RuntimeObject* L_1 = ___stateMachine0;
		AsyncVoidMethodBuilder_SetStateMachine_m1ED99BE03B146D8A7117E299EBA5D74999EB52D7((AsyncVoidMethodBuilder_tA31C888168B27AABF7B0D9E7DF720547D4892DE6 *)L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void U3CStartU3Ed__21_SetStateMachine_m18818E7BF447ED99FDA6431D59BA2C7E6C72FCE0_AdjustorThunk (RuntimeObject * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F * _thisAdjusted = reinterpret_cast<U3CStartU3Ed__21_tE567B25817A6FAD47B6ADA47EDECC0ABE9D6E67F *>(__this + _offset);
	U3CStartU3Ed__21_SetStateMachine_m18818E7BF447ED99FDA6431D59BA2C7E6C72FCE0(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WebSocketReceiveResult_get_Count_m9A22CB095E69E1DE69FDA79295ECC5BE8A147CB9_inline (WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CCountU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool WebSocketReceiveResult_get_EndOfMessage_m233182D8ABF49FEE3C82D6C217CAAC5922104F57_inline (WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * __this, const RuntimeMethod* method)
{
	{
		bool L_0 = __this->get_U3CEndOfMessageU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t WebSocketReceiveResult_get_MessageType_mBE189CACCE7DCDC1C5C0CF9873DD3290BC686478_inline (WebSocketReceiveResult_tEB9BD882DB3C2B94DFDA4655DAD6DFD2DDF85122 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_U3CMessageTypeU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * AChannel_get_RemoteAddress_m44608A1AAAD2C9B33577B94FBD3D04469973585E_inline (AChannel_t96AFF580B6453BD6073337914DEDEC7F158D2432 * __this, const RuntimeMethod* method)
{
	{
		// public IPEndPoint RemoteAddress { get; set; }
		IPEndPoint_t41C675C79A8B4EA6D5211D9B907137A2C015EA3E * L_0 = __this->get_U3CRemoteAddressU3Ek__BackingField_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * ILTypeInstance_get_Type_mC878DA7939714DD13AE31EE38E3F5DE9199B4937_inline (ILTypeInstance_t14C24B55EDC90505DE4BDDA3DC4CAD39BE94A610 * __this, const RuntimeMethod* method)
{
	{
		// return type;
		ILType_tBE79A6900F4C54C1A5EBB72491BC112A1DC539C7 * L_0 = __this->get_type_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Queue_1_get_Count_mD618588C9785F06D043BE6AAD0A0B8116B2A77A3_gshared_inline (Queue_1_t65333FCCA10D8CE1B441D400B6B94140BCB8BF64 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = (int32_t)__this->get__size_3();
		return (int32_t)L_0;
	}
}
