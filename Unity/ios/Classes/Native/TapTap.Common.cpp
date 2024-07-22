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
struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
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

// System.Action`1<System.Object>
struct Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC;
// System.Action`1<TapTap.Common.Result>
struct Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843;
// System.Action`2<System.Int32Enum,System.Object>
struct Action_2_tAEEAE0CA76819C6105A7D08A17A11166D3071492;
// System.Action`2<TapTap.Common.TapLogLevel,System.String>
struct Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38;
// System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>
struct ConcurrentDictionary_2_t089158EC5B60BA9524898F4AC52FEBB3F3F48198;
// System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>>
struct ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Globalization.CultureInfo>
struct Dictionary_2_t5B8303F2C9869A39ED3E03C0FBB09F817E479402;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task>
struct Dictionary_2_tB758E2A2593CD827EFC041BE1F1BB4B68DE1C3E8;
// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D;
// System.Collections.Generic.Dictionary`2<System.String,System.Globalization.CultureInfo>
struct Dictionary_2_t0015CBF964B0687CBB5ECFDDE06671A8F3DDE4BC;
// System.Collections.Generic.Dictionary`2<System.String,System.Net.Http.Headers.HeaderInfo>
struct Dictionary_2_t8757406F1F2B87E86FFC8EDBDB9ACA8BF119549B;
// System.Collections.Generic.Dictionary`2<System.String,System.Object>
struct Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399;
// System.Collections.Generic.Dictionary`2<System.String,System.String>
struct Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5;
// System.Collections.Generic.Dictionary`2<System.String,System.Net.Http.Headers.HttpHeaders/HeaderBucket>
struct Dictionary_2_t96671B7CC8F3C2EEB688C956C4404C1B39FFEADA;
// System.EventHandler`1<LC.Newtonsoft.Json.Serialization.ErrorEventArgs>
struct EventHandler_1_tB446608E53297A82207BBE7269240E039AD6257B;
// System.Func`1<System.Threading.Tasks.Task/ContingentProperties>
struct Func_1_tBCF42601FA307876E83080BE4204110820F8BF3B;
// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<System.Object>>
struct Func_2_t44F36790F9746FCE5ABFDE6205B6020B2578F6DD;
// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<TapTap.Common.Result>>
struct Func_2_tDF7F105B70C3514ED1736D5838BDF9616BF53530;
// System.Func`2<System.Object,System.Int32>
struct Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C;
// System.Func`2<System.Object,System.String>
struct Func_2_t060A650AB95DEF14D4F579FA5999ACEFEEE0FD82;
// System.Collections.Generic.IEnumerable`1<System.Object>
struct IEnumerable_1_t52B1AC8D9E5E1ED28DF6C46A37C9A1B00B394F9D;
// System.Collections.Generic.IEnumerable`1<System.String>
struct IEnumerable_1_tBD60400523D840591A17E4CBBACC79397F68FAA2;
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.IEnumerable`1<System.String>>>
struct IEnumerator_1_tF46D06728D01AF99F3A346A6E78952EEA27851EB;
// System.Collections.Generic.IEqualityComparer`1<System.String>
struct IEqualityComparer_1_tE6A65C5E45E33FD7D9849FD0914DE3AD32B68050;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,System.Object>
struct KeyCollection_t0043475CBB02FD67894529F3CAA818080A2F7A17;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,System.String>
struct KeyCollection_t52C81163A051BCD87A36FEF95F736DD600E2305D;
// System.Collections.Generic.List`1<LC.Newtonsoft.Json.JsonPosition>
struct List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5;
// System.Predicate`1<System.Object>
struct Predicate_1_t5C96B81B31A697B11C4C3767E3298773AF25DFEB;
// System.Predicate`1<System.Threading.Tasks.Task>
struct Predicate_1_tC0DBBC8498BD1EE6ABFFAA5628024105FA7D11BD;
// System.Collections.Concurrent.ConcurrentDictionary`2/Tables<System.String,System.Action`1<TapTap.Common.Result>>
struct Tables_t25B90FF52E13C9D053E80653FA071E514027839C;
// System.Threading.Tasks.TaskCompletionSource`1<System.Object>
struct TaskCompletionSource_1_t5B48A13B0469AA5A5797B645926E284436099903;
// System.Threading.Tasks.TaskCompletionSource`1<TapTap.Common.Result>
struct TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD;
// System.Threading.Tasks.TaskFactory`1<System.Object>
struct TaskFactory_1_t16A95DD17BBA3D00F0A85C5077BB248421EF3A55;
// System.Threading.Tasks.TaskFactory`1<TapTap.Common.Result>
struct TaskFactory_1_t4EE5CA7CD1BE735B38CC1FC0E5782C398145358D;
// System.Threading.Tasks.Task`1<System.Int32>
struct Task_1_tEF253D967DB628A9F8A389A9F2E4516871FD3725;
// System.Threading.Tasks.Task`1<System.Object>
struct Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17;
// System.Threading.Tasks.Task`1<TapTap.Common.Result>
struct Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,System.Object>
struct ValueCollection_tB942A1033B750DCF04FE948413982D120FC69A4E;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,System.String>
struct ValueCollection_t9161A5C97376D261665798FA27DAFD5177305C81;
// System.Collections.Generic.Dictionary`2/Entry<System.String,System.Object>[]
struct EntryU5BU5D_tDCA1A62E50C5B5A40FD6F44107088AF42F5671D2;
// System.Collections.Generic.Dictionary`2/Entry<System.String,System.String>[]
struct EntryU5BU5D_t52A654EA9927D1B5F56CA05CF209F2E4393C4510;
// LC.Newtonsoft.Json.JsonWriter/State[][]
struct StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978;
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
// System.Security.Cryptography.KeySizes[]
struct KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499;
// System.Net.NetworkInformation.NetworkInterface[]
struct NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
// System.Type[]
struct TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755;
// System.UInt32[]
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF;
// UnityEngine.AndroidJavaClass
struct AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4;
// UnityEngine.AndroidJavaObject
struct AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E;
// UnityEngine.AndroidJavaProxy
struct AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// System.Reflection.Binder
struct Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30;
// TapTap.Common.BridgeAndroid
struct BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A;
// TapTap.Common.BridgeCallback
struct BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707;
// TapTap.Common.BridgeIOS
struct BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212;
// System.Globalization.Calendar
struct Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A;
// System.Threading.CancellationTokenSource
struct CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3;
// System.Globalization.CodePageDataItem
struct CodePageDataItem_t09A62F57142BF0456C8F414898A37E79BCC9F09E;
// TapTap.Common.Command
struct Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD;
// System.Globalization.CompareInfo
struct CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9;
// System.Threading.ContextCallback
struct ContextCallback_t93707E0430F4FF3E15E1FB5A4844BE89C657AE8B;
// System.Security.Cryptography.CryptoStream
struct CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66;
// System.Globalization.CultureData
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529;
// System.Globalization.CultureInfo
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98;
// System.Security.Cryptography.DESCryptoServiceProvider
struct DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40;
// System.Globalization.DateTimeFormatInfo
struct DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90;
// System.Text.DecoderFallback
struct DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.Text.EncoderFallback
struct EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4;
// System.Text.Encoding
struct Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827;
// TapTap.Common.EngineBridge
struct EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F;
// System.Exception
struct Exception_t;
// UnityEngine.GlobalJavaObjectRef
struct GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289;
// System.Collections.Hashtable
struct Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC;
// System.Net.Http.HttpClient
struct HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20;
// System.Net.Http.HttpContent
struct HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6;
// System.Net.Http.Headers.HttpContentHeaders
struct HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573;
// System.Net.Http.Headers.HttpHeaders
struct HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2;
// System.Net.Http.HttpMessageHandler
struct HttpMessageHandler_t11B1039BDB93BDFB1C03AC8C2EE195E0ADD06B69;
// System.Net.Http.HttpMethod
struct HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90;
// System.Net.Http.Headers.HttpRequestHeaders
struct HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877;
// System.Net.Http.HttpRequestMessage
struct HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F;
// System.Net.Http.Headers.HttpResponseHeaders
struct HttpResponseHeaders_t15DADCD69839D24E4336D8D0D62BEED17A6DC8B6;
// System.Net.Http.HttpResponseMessage
struct HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// TapTap.Common.IBridge
struct IBridge_t0EB65E5461387E161F5AA0E871BC9C604206B7B8;
// LC.Newtonsoft.Json.Serialization.IContractResolver
struct IContractResolver_tE9C58A48046156F7BD5AEFA3FA7E040FD32AB514;
// System.Security.Cryptography.ICryptoTransform
struct ICryptoTransform_t001D97000AA0178942D19FC52942472140472E5E;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.Collections.IEqualityComparer
struct IEqualityComparer_t6C4C1F04B21BDE1E4B84BD6EC7DE494C186D6C68;
// System.IFormatProvider
struct IFormatProvider_tF2AECC4B14F41D36718920D67F930CED940412DF;
// System.Collections.IList
struct IList_tB15A9D6625D09661D6E47976BB626C703EC81910;
// LC.Newtonsoft.Json.Serialization.IReferenceResolver
struct IReferenceResolver_tD91DD96EA2A50EB48DE659E5B0EFA2568DA02FF2;
// LC.Newtonsoft.Json.Serialization.ISerializationBinder
struct ISerializationBinder_t84094CDAFE2926222713FD6DCA21152F75319930;
// LC.Newtonsoft.Json.Serialization.ITraceWriter
struct ITraceWriter_t996C87099E3775D352FBE347E5C8A3F3276E0D1C;
// LC.Newtonsoft.Json.JsonConverter
struct JsonConverter_tB733E18F5460B16D7D15AEC1D601BFBDA786CF5F;
// LC.Newtonsoft.Json.JsonConverterCollection
struct JsonConverterCollection_tBF00847A818DC8D654E2AB29814CC38956418C86;
// LC.Newtonsoft.Json.JsonReader
struct JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B;
// LC.Newtonsoft.Json.JsonSerializer
struct JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B;
// LC.Newtonsoft.Json.JsonWriter
struct JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008;
// System.Reflection.MemberFilter
struct MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81;
// System.IO.MemoryStream
struct MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Net.NetworkInformation.NetworkInterface
struct NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB;
// System.Globalization.NumberFormatInfo
struct NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D;
// System.Security.Cryptography.RandomNumberGenerator
struct RandomNumberGenerator_t2CB5440F189986116A2FA9F907AE52644047AC50;
// TapTap.Common.Result
struct Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t3EF85FC980AE57957BEBB6B78E81DE2E3233D385;
// System.Threading.Tasks.StackGuard
struct StackGuard_t88E1EE4741AD02CA5FEA04A4EB2CC70F230E0E6D;
// System.IO.Stream
struct Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// System.IO.StringReader
struct StringReader_t74E352C280EAC22C878867444978741F19E1F895;
// TapTap.Common.TapError
struct TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4;
// TapTap.Common.TapException
struct TapException_tD607DF79F8107AB2AF0C8047B0EC40C8056FFAEB;
// TapTap.Common.Internal.Json.TapJsonConverter
struct TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE;
// TapTap.Common.TapLocalizeManager
struct TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB;
// System.Threading.Tasks.TaskFactory
struct TaskFactory_t22D999A05A967C31A4B5FFBD08864809BF35EA3B;
// System.Threading.Tasks.TaskScheduler
struct TaskScheduler_t74FBEEEDBDD5E0088FF0EEC18F45CD866B098D5D;
// System.Globalization.TextInfo
struct TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C;
// System.IO.TextReader
struct TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F;
// System.Type
struct Type_t;
// System.Uri
struct Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612;
// System.UriParser
struct UriParser_t6DEBE5C6CDC3C29C9019CD951C7ECEBD6A5D3E3A;
// System.Version
struct Version_tBDAEDED25425A1D09910468B8BD1759115646E3C;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// TapTap.Common.BridgeIOS/EngineBridgeDelegate
struct EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A;
// TapTap.Common.Command/Builder
struct Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2;
// TapTap.Common.EngineBridge/<>c__DisplayClass8_0
struct U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474;
// System.Net.Http.HttpContent/FixedMemoryStream
struct FixedMemoryStream_t5C7647C6F3503F1EADC966C8D2F50E6BF1A69E3A;
// TapTap.Common.Json/Parser
struct Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9;
// TapTap.Common.Json/Serializer
struct Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_t32CD2C230786712954C1DB518DBE420A1F4C7974;
// System.Threading.Tasks.Task/ContingentProperties
struct ContingentProperties_t1E249C737B8B8644ED1D60EEFA101D326B199EA0;
// System.Uri/UriInfo
struct UriInfo_tCB2302A896132D1F70E47C3895FAB9A0F2A6EE45;

IL2CPP_EXTERN_C RuntimeClass* Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Guid_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HttpStatusCode_tFCB1BA96A101857DA7C390345DE43B77F9567D98_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IBridge_t0EB65E5461387E161F5AA0E871BC9C604206B7B8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_1_tF46D06728D01AF99F3A346A6E78952EEA27851EB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int16_tD0F031114106263BB459DA1F099FF9F42691295A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringReader_t74E352C280EAC22C878867444978741F19E1F895_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UInt16_t894EA9D4FB7C799B244E7BBF2DF0EEEDBC77A8BD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UInt32_tE60352A06233E4E69DD198BCC67142159F686B15_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UInt64_tEC57511B3E3CA2DBA1BEBD434C6983E31C943281_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeField* U3CPrivateImplementationDetailsU3E_tA85448D1D10374C2576475EF46D71197F7E8D49F____B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0_FieldInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD;
IL2CPP_EXTERN_C String_t* _stringLiteral01D43D70585035CC3857149B066E3D05D655DB8B;
IL2CPP_EXTERN_C String_t* _stringLiteral07910731D7533EC65B7E53F11C34777CE40AA3C0;
IL2CPP_EXTERN_C String_t* _stringLiteral1168E92C164109D6220480DEDA987085B2A21155;
IL2CPP_EXTERN_C String_t* _stringLiteral13AE6958E793A1F95208712D9C75F93E88433FFD;
IL2CPP_EXTERN_C String_t* _stringLiteral1693E3C303F951873B4D96A82A6325E92278F3AB;
IL2CPP_EXTERN_C String_t* _stringLiteral1C7A9E8795DAC93A625C23D6E9F2BC7332ABF459;
IL2CPP_EXTERN_C String_t* _stringLiteral2063737B07B6658BC2E1EC3128D4E09E57CA123E;
IL2CPP_EXTERN_C String_t* _stringLiteral24313380B89749FA23D81C8CFE7ECADF5F282DF3;
IL2CPP_EXTERN_C String_t* _stringLiteral2C3D4826D5236B3C9A914C5CE2E3D8CEA48AC7CE;
IL2CPP_EXTERN_C String_t* _stringLiteral355F7D71617B9D10C0A4030AF4419CFDB06BF0D7;
IL2CPP_EXTERN_C String_t* _stringLiteral35FE427116F84AC6F7F40A6E9940DCDF2CF6CC7B;
IL2CPP_EXTERN_C String_t* _stringLiteral4D613657609485AE586A3379BA0E3FC13C1E1078;
IL2CPP_EXTERN_C String_t* _stringLiteral5962E944D7340CE47999BF097B4AFD70C1501FB9;
IL2CPP_EXTERN_C String_t* _stringLiteral5BEFD8CC60A79699B5BB00E37BAC5B62D371E174;
IL2CPP_EXTERN_C String_t* _stringLiteral5F161BA1450058E111D0B820CF591B319CD3B136;
IL2CPP_EXTERN_C String_t* _stringLiteral6041A91147E542D6A2F83C8B08CE89CC68742E51;
IL2CPP_EXTERN_C String_t* _stringLiteral60A2E461CC4A1D49199A67B5216F128319CE63CC;
IL2CPP_EXTERN_C String_t* _stringLiteral694377C0677C61D486C4B5E6D1EC89FC94F03DA2;
IL2CPP_EXTERN_C String_t* _stringLiteral74995F8A2CBEF688BCD95DF9DB36E3FFCDE14774;
IL2CPP_EXTERN_C String_t* _stringLiteral77D38C0623F92B292B925F6E72CF5CF99A20D4EB;
IL2CPP_EXTERN_C String_t* _stringLiteral785F17F45C331C415D0A7458E6AAC36966399C51;
IL2CPP_EXTERN_C String_t* _stringLiteral7F3238CD8C342B06FB9AB185C610175C84625462;
IL2CPP_EXTERN_C String_t* _stringLiteral83A882DFBD86B63D426331B0F49139080947E516;
IL2CPP_EXTERN_C String_t* _stringLiteral843A881AA95F05B68BA338CAF346BBAD3DB68882;
IL2CPP_EXTERN_C String_t* _stringLiteral848E5ED630B3142F565DD995C6E8D30187ED33CD;
IL2CPP_EXTERN_C String_t* _stringLiteral84C1E07F84B6E7BDCC02A904AFEC3BBD2CAE6EAA;
IL2CPP_EXTERN_C String_t* _stringLiteral98483F133AA49AA48A0F52F0C8C09C6CAA5A5718;
IL2CPP_EXTERN_C String_t* _stringLiteral9BC242DF4AEE0561D7635DB8227112DC96E863C3;
IL2CPP_EXTERN_C String_t* _stringLiteralA7C3FCA8C63E127B542B38A5CA5E3FEEDDD1B122;
IL2CPP_EXTERN_C String_t* _stringLiteralB78F235D4291950A7D101307609C259F3E1F033F;
IL2CPP_EXTERN_C String_t* _stringLiteralB7C45DD316C68ABF3429C20058C2981C652192F2;
IL2CPP_EXTERN_C String_t* _stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB;
IL2CPP_EXTERN_C String_t* _stringLiteralCDB1A0A3D8C53C2F9DEC231A147964E483B79A09;
IL2CPP_EXTERN_C String_t* _stringLiteralD2671306B605AA32D582F0C7A19AAE677E5437A5;
IL2CPP_EXTERN_C String_t* _stringLiteralD6CFAA9A8F507F384B1008F247D2327A3D2F1426;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralDA666908BB15F4E1D2649752EC5DCBD0D5C64699;
IL2CPP_EXTERN_C String_t* _stringLiteralDE78B901DD2022341C7FB711583371AC6F2A0D4C;
IL2CPP_EXTERN_C String_t* _stringLiteralE727BF366E3CC855B808D806440542BF7152AF19;
IL2CPP_EXTERN_C String_t* _stringLiteralE7CE87F5CD06F2CEADE5857C0C5F2EF8A58F5656;
IL2CPP_EXTERN_C String_t* _stringLiteralEAC023C83F279F84D4D498C417617E63443A176E;
IL2CPP_EXTERN_C String_t* _stringLiteralF18840F490E42D3CE48CDCBF47229C1C240F8ABE;
IL2CPP_EXTERN_C String_t* _stringLiteralFB4AE4F77150C3A8E8E4F8B23E734E0C7277B7D9;
IL2CPP_EXTERN_C String_t* _stringLiteralFDAF0D0039EA977A99E4D2F12EEED51267FAD6E4;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_m30BB8E391F85895D3CDED6D834FF6F350978FABD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1__ctor_m8A52A1E69EBA2DC131EC8543DE12B9F4E512B4BE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_2_Invoke_mAD6B0F23BFA144D866A6A4196D5E1A19CA8A8E4F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AndroidJavaObject_CallStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mAD48C38D66AB67D0F0274D195F4A99CB7AB589F2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AndroidJavaObject_GetStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mC84C97A7EC20ED712D21107C9FA32E0785021153_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* BridgeIOS_engineBridgeDelegate_m8912905FBDD43922D6F2D45405C1CF03F884F8F6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConcurrentDictionary_2_ContainsKey_m3977DBC42CD0D3E6EF36F9249D00F1940D22C3E3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConcurrentDictionary_2_GetOrAdd_m6D452307EA9EB2FFC8D778A35E994D27BB6E22F3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConcurrentDictionary_2_TryRemove_m9AF2612953577A6707762B06C82DE81718183E5D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConcurrentDictionary_2__ctor_m61593A6F8DCC9B835A9162D9A41E933C6AC0C511_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConcurrentDictionary_2_get_Count_m909ED40578105FB6817240D4E5B7DE0594CF47FF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ConcurrentDictionary_2_get_Item_mA417BF88EF46098F3A761B0C74BF477F35BA8086_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Add_mE0EF428186E444BFEAD18AC6810D423EEABB3F92_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mA6747E78BD4DF1D09D9091C1B3EBAE0FDB200666_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_m31C41E4FE938066440DAFD1E667C2F3986549668_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SafeDictionary_GetValue_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mFA70C2F966B05DCEEE7BDCAF44C103BBFC73ED8B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SafeDictionary_GetValue_TisString_t_m97A16243B1B7E0B8CFD8D82AADFFE856B1EFC47C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskCompletionSource_1_TrySetResult_m1264FCCE9A651BCB44E85D04CDA6A0AA97213617_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskCompletionSource_1__ctor_m41DCCC9230519818D858BF703C08AB243D898FF1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TaskCompletionSource_1_get_Task_mC18B68B47AD86B33CD5C42F8D2FE3EAA338B825E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass8_0_U3CEmitU3Eb__0_m69B5BE966C6BBD99E6E26D47482C034AB3F28ED4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* RuntimeObject_0_0_0_var;
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529_marshaled_com;
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529_marshaled_pinvoke;
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_com;
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_pinvoke;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
struct NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC;
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tE2D5B64252B6F4C9D36F1669931C7FC83839FABF 
{
public:

public:
};


// System.Object


// System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>>
struct ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9  : public RuntimeObject
{
public:
	// System.Collections.Concurrent.ConcurrentDictionary`2/Tables<TKey,TValue> modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Concurrent.ConcurrentDictionary`2::_tables
	Tables_t25B90FF52E13C9D053E80653FA071E514027839C * ____tables_0;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Concurrent.ConcurrentDictionary`2::_comparer
	RuntimeObject* ____comparer_1;
	// System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2::_growLockArray
	bool ____growLockArray_2;
	// System.Int32 System.Collections.Concurrent.ConcurrentDictionary`2::_budget
	int32_t ____budget_3;

public:
	inline static int32_t get_offset_of__tables_0() { return static_cast<int32_t>(offsetof(ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9, ____tables_0)); }
	inline Tables_t25B90FF52E13C9D053E80653FA071E514027839C * get__tables_0() const { return ____tables_0; }
	inline Tables_t25B90FF52E13C9D053E80653FA071E514027839C ** get_address_of__tables_0() { return &____tables_0; }
	inline void set__tables_0(Tables_t25B90FF52E13C9D053E80653FA071E514027839C * value)
	{
		____tables_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____tables_0), (void*)value);
	}

	inline static int32_t get_offset_of__comparer_1() { return static_cast<int32_t>(offsetof(ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9, ____comparer_1)); }
	inline RuntimeObject* get__comparer_1() const { return ____comparer_1; }
	inline RuntimeObject** get_address_of__comparer_1() { return &____comparer_1; }
	inline void set__comparer_1(RuntimeObject* value)
	{
		____comparer_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____comparer_1), (void*)value);
	}

	inline static int32_t get_offset_of__growLockArray_2() { return static_cast<int32_t>(offsetof(ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9, ____growLockArray_2)); }
	inline bool get__growLockArray_2() const { return ____growLockArray_2; }
	inline bool* get_address_of__growLockArray_2() { return &____growLockArray_2; }
	inline void set__growLockArray_2(bool value)
	{
		____growLockArray_2 = value;
	}

	inline static int32_t get_offset_of__budget_3() { return static_cast<int32_t>(offsetof(ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9, ____budget_3)); }
	inline int32_t get__budget_3() const { return ____budget_3; }
	inline int32_t* get_address_of__budget_3() { return &____budget_3; }
	inline void set__budget_3(int32_t value)
	{
		____budget_3 = value;
	}
};

struct ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9_StaticFields
{
public:
	// System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2::s_isValueWriteAtomic
	bool ___s_isValueWriteAtomic_6;

public:
	inline static int32_t get_offset_of_s_isValueWriteAtomic_6() { return static_cast<int32_t>(offsetof(ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9_StaticFields, ___s_isValueWriteAtomic_6)); }
	inline bool get_s_isValueWriteAtomic_6() const { return ___s_isValueWriteAtomic_6; }
	inline bool* get_address_of_s_isValueWriteAtomic_6() { return &___s_isValueWriteAtomic_6; }
	inline void set_s_isValueWriteAtomic_6(bool value)
	{
		___s_isValueWriteAtomic_6 = value;
	}
};


// System.Collections.Generic.Dictionary`2<System.String,System.Object>
struct Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_tDCA1A62E50C5B5A40FD6F44107088AF42F5671D2* ___entries_1;
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
	KeyCollection_t0043475CBB02FD67894529F3CAA818080A2F7A17 * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_tB942A1033B750DCF04FE948413982D120FC69A4E * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___entries_1)); }
	inline EntryU5BU5D_tDCA1A62E50C5B5A40FD6F44107088AF42F5671D2* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_tDCA1A62E50C5B5A40FD6F44107088AF42F5671D2** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_tDCA1A62E50C5B5A40FD6F44107088AF42F5671D2* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___keys_7)); }
	inline KeyCollection_t0043475CBB02FD67894529F3CAA818080A2F7A17 * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t0043475CBB02FD67894529F3CAA818080A2F7A17 ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t0043475CBB02FD67894529F3CAA818080A2F7A17 * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ___values_8)); }
	inline ValueCollection_tB942A1033B750DCF04FE948413982D120FC69A4E * get_values_8() const { return ___values_8; }
	inline ValueCollection_tB942A1033B750DCF04FE948413982D120FC69A4E ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_tB942A1033B750DCF04FE948413982D120FC69A4E * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_9), (void*)value);
	}
};


// System.Collections.Generic.Dictionary`2<System.String,System.String>
struct Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t52A654EA9927D1B5F56CA05CF209F2E4393C4510* ___entries_1;
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
	KeyCollection_t52C81163A051BCD87A36FEF95F736DD600E2305D * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t9161A5C97376D261665798FA27DAFD5177305C81 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___entries_1)); }
	inline EntryU5BU5D_t52A654EA9927D1B5F56CA05CF209F2E4393C4510* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t52A654EA9927D1B5F56CA05CF209F2E4393C4510** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t52A654EA9927D1B5F56CA05CF209F2E4393C4510* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___keys_7)); }
	inline KeyCollection_t52C81163A051BCD87A36FEF95F736DD600E2305D * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t52C81163A051BCD87A36FEF95F736DD600E2305D ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t52C81163A051BCD87A36FEF95F736DD600E2305D * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ___values_8)); }
	inline ValueCollection_t9161A5C97376D261665798FA27DAFD5177305C81 * get_values_8() const { return ___values_8; }
	inline ValueCollection_t9161A5C97376D261665798FA27DAFD5177305C81 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t9161A5C97376D261665798FA27DAFD5177305C81 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_9), (void*)value);
	}
};


// System.EmptyArray`1<System.Object>
struct EmptyArray_1_tBF73225DFA890366D579424FE8F40073BF9FBAD4  : public RuntimeObject
{
public:

public:
};

struct EmptyArray_1_tBF73225DFA890366D579424FE8F40073BF9FBAD4_StaticFields
{
public:
	// T[] System.EmptyArray`1::Value
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___Value_0;

public:
	inline static int32_t get_offset_of_Value_0() { return static_cast<int32_t>(offsetof(EmptyArray_1_tBF73225DFA890366D579424FE8F40073BF9FBAD4_StaticFields, ___Value_0)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get_Value_0() const { return ___Value_0; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of_Value_0() { return &___Value_0; }
	inline void set_Value_0(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		___Value_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Value_0), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5, ____items_1)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get__items_1() const { return ____items_1; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_StaticFields, ____emptyArray_5)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Threading.Tasks.TaskCompletionSource`1<System.Object>
struct TaskCompletionSource_1_t5B48A13B0469AA5A5797B645926E284436099903  : public RuntimeObject
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskCompletionSource`1::m_task
	Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * ___m_task_0;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(TaskCompletionSource_1_t5B48A13B0469AA5A5797B645926E284436099903, ___m_task_0)); }
	inline Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * get_m_task_0() const { return ___m_task_0; }
	inline Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_task_0), (void*)value);
	}
};


// System.Threading.Tasks.TaskCompletionSource`1<TapTap.Common.Result>
struct TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD  : public RuntimeObject
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Threading.Tasks.TaskCompletionSource`1::m_task
	Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * ___m_task_0;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD, ___m_task_0)); }
	inline Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * get_m_task_0() const { return ___m_task_0; }
	inline Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_task_0), (void*)value);
	}
};


// <PrivateImplementationDetails>
struct U3CPrivateImplementationDetailsU3E_tA85448D1D10374C2576475EF46D71197F7E8D49F  : public RuntimeObject
{
public:

public:
};

struct U3CPrivateImplementationDetailsU3E_tA85448D1D10374C2576475EF46D71197F7E8D49F_StaticFields
{
public:
	// System.Int64 <PrivateImplementationDetails>::B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12
	int64_t ___B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0;

public:
	inline static int32_t get_offset_of_B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0() { return static_cast<int32_t>(offsetof(U3CPrivateImplementationDetailsU3E_tA85448D1D10374C2576475EF46D71197F7E8D49F_StaticFields, ___B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0)); }
	inline int64_t get_B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0() const { return ___B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0; }
	inline int64_t* get_address_of_B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0() { return &___B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0; }
	inline void set_B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0(int64_t value)
	{
		___B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0 = value;
	}
};


// UnityEngine.AndroidJavaObject
struct AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E  : public RuntimeObject
{
public:
	// UnityEngine.GlobalJavaObjectRef UnityEngine.AndroidJavaObject::m_jobject
	GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * ___m_jobject_1;
	// UnityEngine.GlobalJavaObjectRef UnityEngine.AndroidJavaObject::m_jclass
	GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * ___m_jclass_2;

public:
	inline static int32_t get_offset_of_m_jobject_1() { return static_cast<int32_t>(offsetof(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E, ___m_jobject_1)); }
	inline GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * get_m_jobject_1() const { return ___m_jobject_1; }
	inline GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 ** get_address_of_m_jobject_1() { return &___m_jobject_1; }
	inline void set_m_jobject_1(GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * value)
	{
		___m_jobject_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_jobject_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_jclass_2() { return static_cast<int32_t>(offsetof(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E, ___m_jclass_2)); }
	inline GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * get_m_jclass_2() const { return ___m_jclass_2; }
	inline GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 ** get_address_of_m_jclass_2() { return &___m_jclass_2; }
	inline void set_m_jclass_2(GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * value)
	{
		___m_jclass_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_jclass_2), (void*)value);
	}
};

struct AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_StaticFields
{
public:
	// System.Boolean UnityEngine.AndroidJavaObject::enableDebugPrints
	bool ___enableDebugPrints_0;

public:
	inline static int32_t get_offset_of_enableDebugPrints_0() { return static_cast<int32_t>(offsetof(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_StaticFields, ___enableDebugPrints_0)); }
	inline bool get_enableDebugPrints_0() const { return ___enableDebugPrints_0; }
	inline bool* get_address_of_enableDebugPrints_0() { return &___enableDebugPrints_0; }
	inline void set_enableDebugPrints_0(bool value)
	{
		___enableDebugPrints_0 = value;
	}
};

struct Il2CppArrayBounds;

// System.Array


// TapTap.Common.BridgeAndroid
struct BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A  : public RuntimeObject
{
public:
	// System.String TapTap.Common.BridgeAndroid::bridgeJavaClz
	String_t* ___bridgeJavaClz_0;
	// System.String TapTap.Common.BridgeAndroid::instanceMethod
	String_t* ___instanceMethod_1;
	// System.String TapTap.Common.BridgeAndroid::registerHandlerMethod
	String_t* ___registerHandlerMethod_2;
	// System.String TapTap.Common.BridgeAndroid::callHandlerMethod
	String_t* ___callHandlerMethod_3;
	// System.String TapTap.Common.BridgeAndroid::initMethod
	String_t* ___initMethod_4;
	// System.String TapTap.Common.BridgeAndroid::registerMethod
	String_t* ___registerMethod_5;
	// UnityEngine.AndroidJavaObject TapTap.Common.BridgeAndroid::_mAndroidBridge
	AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * ____mAndroidBridge_6;

public:
	inline static int32_t get_offset_of_bridgeJavaClz_0() { return static_cast<int32_t>(offsetof(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A, ___bridgeJavaClz_0)); }
	inline String_t* get_bridgeJavaClz_0() const { return ___bridgeJavaClz_0; }
	inline String_t** get_address_of_bridgeJavaClz_0() { return &___bridgeJavaClz_0; }
	inline void set_bridgeJavaClz_0(String_t* value)
	{
		___bridgeJavaClz_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___bridgeJavaClz_0), (void*)value);
	}

	inline static int32_t get_offset_of_instanceMethod_1() { return static_cast<int32_t>(offsetof(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A, ___instanceMethod_1)); }
	inline String_t* get_instanceMethod_1() const { return ___instanceMethod_1; }
	inline String_t** get_address_of_instanceMethod_1() { return &___instanceMethod_1; }
	inline void set_instanceMethod_1(String_t* value)
	{
		___instanceMethod_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___instanceMethod_1), (void*)value);
	}

	inline static int32_t get_offset_of_registerHandlerMethod_2() { return static_cast<int32_t>(offsetof(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A, ___registerHandlerMethod_2)); }
	inline String_t* get_registerHandlerMethod_2() const { return ___registerHandlerMethod_2; }
	inline String_t** get_address_of_registerHandlerMethod_2() { return &___registerHandlerMethod_2; }
	inline void set_registerHandlerMethod_2(String_t* value)
	{
		___registerHandlerMethod_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___registerHandlerMethod_2), (void*)value);
	}

	inline static int32_t get_offset_of_callHandlerMethod_3() { return static_cast<int32_t>(offsetof(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A, ___callHandlerMethod_3)); }
	inline String_t* get_callHandlerMethod_3() const { return ___callHandlerMethod_3; }
	inline String_t** get_address_of_callHandlerMethod_3() { return &___callHandlerMethod_3; }
	inline void set_callHandlerMethod_3(String_t* value)
	{
		___callHandlerMethod_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callHandlerMethod_3), (void*)value);
	}

	inline static int32_t get_offset_of_initMethod_4() { return static_cast<int32_t>(offsetof(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A, ___initMethod_4)); }
	inline String_t* get_initMethod_4() const { return ___initMethod_4; }
	inline String_t** get_address_of_initMethod_4() { return &___initMethod_4; }
	inline void set_initMethod_4(String_t* value)
	{
		___initMethod_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___initMethod_4), (void*)value);
	}

	inline static int32_t get_offset_of_registerMethod_5() { return static_cast<int32_t>(offsetof(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A, ___registerMethod_5)); }
	inline String_t* get_registerMethod_5() const { return ___registerMethod_5; }
	inline String_t** get_address_of_registerMethod_5() { return &___registerMethod_5; }
	inline void set_registerMethod_5(String_t* value)
	{
		___registerMethod_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___registerMethod_5), (void*)value);
	}

	inline static int32_t get_offset_of__mAndroidBridge_6() { return static_cast<int32_t>(offsetof(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A, ____mAndroidBridge_6)); }
	inline AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * get__mAndroidBridge_6() const { return ____mAndroidBridge_6; }
	inline AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E ** get_address_of__mAndroidBridge_6() { return &____mAndroidBridge_6; }
	inline void set__mAndroidBridge_6(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * value)
	{
		____mAndroidBridge_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____mAndroidBridge_6), (void*)value);
	}
};

struct BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_StaticFields
{
public:
	// TapTap.Common.BridgeAndroid TapTap.Common.BridgeAndroid::SInstance
	BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * ___SInstance_7;

public:
	inline static int32_t get_offset_of_SInstance_7() { return static_cast<int32_t>(offsetof(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_StaticFields, ___SInstance_7)); }
	inline BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * get_SInstance_7() const { return ___SInstance_7; }
	inline BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A ** get_address_of_SInstance_7() { return &___SInstance_7; }
	inline void set_SInstance_7(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * value)
	{
		___SInstance_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___SInstance_7), (void*)value);
	}
};


// TapTap.Common.BridgeIOS
struct BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212  : public RuntimeObject
{
public:
	// System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>> TapTap.Common.BridgeIOS::dic
	ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * ___dic_1;

public:
	inline static int32_t get_offset_of_dic_1() { return static_cast<int32_t>(offsetof(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212, ___dic_1)); }
	inline ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * get_dic_1() const { return ___dic_1; }
	inline ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 ** get_address_of_dic_1() { return &___dic_1; }
	inline void set_dic_1(ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * value)
	{
		___dic_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dic_1), (void*)value);
	}
};

struct BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_StaticFields
{
public:
	// TapTap.Common.BridgeIOS TapTap.Common.BridgeIOS::SInstance
	BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * ___SInstance_0;

public:
	inline static int32_t get_offset_of_SInstance_0() { return static_cast<int32_t>(offsetof(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_StaticFields, ___SInstance_0)); }
	inline BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * get_SInstance_0() const { return ___SInstance_0; }
	inline BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 ** get_address_of_SInstance_0() { return &___SInstance_0; }
	inline void set_SInstance_0(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * value)
	{
		___SInstance_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___SInstance_0), (void*)value);
	}
};


// TapTap.Common.Command
struct Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD  : public RuntimeObject
{
public:
	// System.String TapTap.Common.Command::service
	String_t* ___service_0;
	// System.String TapTap.Common.Command::method
	String_t* ___method_1;
	// System.String TapTap.Common.Command::args
	String_t* ___args_2;
	// System.Boolean TapTap.Common.Command::callback
	bool ___callback_3;
	// System.String TapTap.Common.Command::callbackId
	String_t* ___callbackId_4;
	// System.Boolean TapTap.Common.Command::onceTime
	bool ___onceTime_5;

public:
	inline static int32_t get_offset_of_service_0() { return static_cast<int32_t>(offsetof(Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD, ___service_0)); }
	inline String_t* get_service_0() const { return ___service_0; }
	inline String_t** get_address_of_service_0() { return &___service_0; }
	inline void set_service_0(String_t* value)
	{
		___service_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___service_0), (void*)value);
	}

	inline static int32_t get_offset_of_method_1() { return static_cast<int32_t>(offsetof(Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD, ___method_1)); }
	inline String_t* get_method_1() const { return ___method_1; }
	inline String_t** get_address_of_method_1() { return &___method_1; }
	inline void set_method_1(String_t* value)
	{
		___method_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_1), (void*)value);
	}

	inline static int32_t get_offset_of_args_2() { return static_cast<int32_t>(offsetof(Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD, ___args_2)); }
	inline String_t* get_args_2() const { return ___args_2; }
	inline String_t** get_address_of_args_2() { return &___args_2; }
	inline void set_args_2(String_t* value)
	{
		___args_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___args_2), (void*)value);
	}

	inline static int32_t get_offset_of_callback_3() { return static_cast<int32_t>(offsetof(Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD, ___callback_3)); }
	inline bool get_callback_3() const { return ___callback_3; }
	inline bool* get_address_of_callback_3() { return &___callback_3; }
	inline void set_callback_3(bool value)
	{
		___callback_3 = value;
	}

	inline static int32_t get_offset_of_callbackId_4() { return static_cast<int32_t>(offsetof(Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD, ___callbackId_4)); }
	inline String_t* get_callbackId_4() const { return ___callbackId_4; }
	inline String_t** get_address_of_callbackId_4() { return &___callbackId_4; }
	inline void set_callbackId_4(String_t* value)
	{
		___callbackId_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callbackId_4), (void*)value);
	}

	inline static int32_t get_offset_of_onceTime_5() { return static_cast<int32_t>(offsetof(Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD, ___onceTime_5)); }
	inline bool get_onceTime_5() const { return ___onceTime_5; }
	inline bool* get_address_of_onceTime_5() { return &___onceTime_5; }
	inline void set_onceTime_5(bool value)
	{
		___onceTime_5 = value;
	}
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

// TapTap.Common.DataStorage
struct DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64  : public RuntimeObject
{
public:

public:
};

struct DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.String> TapTap.Common.DataStorage::dataCache
	Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * ___dataCache_0;
	// System.Byte[] TapTap.Common.DataStorage::Keys
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___Keys_1;

public:
	inline static int32_t get_offset_of_dataCache_0() { return static_cast<int32_t>(offsetof(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields, ___dataCache_0)); }
	inline Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * get_dataCache_0() const { return ___dataCache_0; }
	inline Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 ** get_address_of_dataCache_0() { return &___dataCache_0; }
	inline void set_dataCache_0(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * value)
	{
		___dataCache_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dataCache_0), (void*)value);
	}

	inline static int32_t get_offset_of_Keys_1() { return static_cast<int32_t>(offsetof(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields, ___Keys_1)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_Keys_1() const { return ___Keys_1; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_Keys_1() { return &___Keys_1; }
	inline void set_Keys_1(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___Keys_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Keys_1), (void*)value);
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


// TapTap.Common.EngineBridge
struct EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F  : public RuntimeObject
{
public:
	// TapTap.Common.IBridge TapTap.Common.EngineBridge::_bridge
	RuntimeObject* ____bridge_1;

public:
	inline static int32_t get_offset_of__bridge_1() { return static_cast<int32_t>(offsetof(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F, ____bridge_1)); }
	inline RuntimeObject* get__bridge_1() const { return ____bridge_1; }
	inline RuntimeObject** get_address_of__bridge_1() { return &____bridge_1; }
	inline void set__bridge_1(RuntimeObject* value)
	{
		____bridge_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____bridge_1), (void*)value);
	}
};

struct EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_StaticFields
{
public:
	// TapTap.Common.EngineBridge modreq(System.Runtime.CompilerServices.IsVolatile) TapTap.Common.EngineBridge::_sInstance
	EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * ____sInstance_0;
	// System.Object TapTap.Common.EngineBridge::Locker
	RuntimeObject * ___Locker_2;

public:
	inline static int32_t get_offset_of__sInstance_0() { return static_cast<int32_t>(offsetof(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_StaticFields, ____sInstance_0)); }
	inline EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * get__sInstance_0() const { return ____sInstance_0; }
	inline EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F ** get_address_of__sInstance_0() { return &____sInstance_0; }
	inline void set__sInstance_0(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * value)
	{
		____sInstance_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____sInstance_0), (void*)value);
	}

	inline static int32_t get_offset_of_Locker_2() { return static_cast<int32_t>(offsetof(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_StaticFields, ___Locker_2)); }
	inline RuntimeObject * get_Locker_2() const { return ___Locker_2; }
	inline RuntimeObject ** get_address_of_Locker_2() { return &___Locker_2; }
	inline void set_Locker_2(RuntimeObject * value)
	{
		___Locker_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Locker_2), (void*)value);
	}
};


// System.Net.Http.HttpContent
struct HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6  : public RuntimeObject
{
public:
	// System.Net.Http.HttpContent/FixedMemoryStream System.Net.Http.HttpContent::buffer
	FixedMemoryStream_t5C7647C6F3503F1EADC966C8D2F50E6BF1A69E3A * ___buffer_0;
	// System.IO.Stream System.Net.Http.HttpContent::stream
	Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___stream_1;
	// System.Boolean System.Net.Http.HttpContent::disposed
	bool ___disposed_2;
	// System.Net.Http.Headers.HttpContentHeaders System.Net.Http.HttpContent::headers
	HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573 * ___headers_3;

public:
	inline static int32_t get_offset_of_buffer_0() { return static_cast<int32_t>(offsetof(HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6, ___buffer_0)); }
	inline FixedMemoryStream_t5C7647C6F3503F1EADC966C8D2F50E6BF1A69E3A * get_buffer_0() const { return ___buffer_0; }
	inline FixedMemoryStream_t5C7647C6F3503F1EADC966C8D2F50E6BF1A69E3A ** get_address_of_buffer_0() { return &___buffer_0; }
	inline void set_buffer_0(FixedMemoryStream_t5C7647C6F3503F1EADC966C8D2F50E6BF1A69E3A * value)
	{
		___buffer_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buffer_0), (void*)value);
	}

	inline static int32_t get_offset_of_stream_1() { return static_cast<int32_t>(offsetof(HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6, ___stream_1)); }
	inline Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * get_stream_1() const { return ___stream_1; }
	inline Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB ** get_address_of_stream_1() { return &___stream_1; }
	inline void set_stream_1(Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * value)
	{
		___stream_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___stream_1), (void*)value);
	}

	inline static int32_t get_offset_of_disposed_2() { return static_cast<int32_t>(offsetof(HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6, ___disposed_2)); }
	inline bool get_disposed_2() const { return ___disposed_2; }
	inline bool* get_address_of_disposed_2() { return &___disposed_2; }
	inline void set_disposed_2(bool value)
	{
		___disposed_2 = value;
	}

	inline static int32_t get_offset_of_headers_3() { return static_cast<int32_t>(offsetof(HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6, ___headers_3)); }
	inline HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573 * get_headers_3() const { return ___headers_3; }
	inline HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573 ** get_address_of_headers_3() { return &___headers_3; }
	inline void set_headers_3(HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573 * value)
	{
		___headers_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___headers_3), (void*)value);
	}
};


// System.Net.Http.HttpMessageInvoker
struct HttpMessageInvoker_tB200A37492A5CB8B8FB6E89580AA47481225D02F  : public RuntimeObject
{
public:
	// System.Net.Http.HttpMessageHandler System.Net.Http.HttpMessageInvoker::handler
	HttpMessageHandler_t11B1039BDB93BDFB1C03AC8C2EE195E0ADD06B69 * ___handler_0;
	// System.Boolean System.Net.Http.HttpMessageInvoker::disposeHandler
	bool ___disposeHandler_1;

public:
	inline static int32_t get_offset_of_handler_0() { return static_cast<int32_t>(offsetof(HttpMessageInvoker_tB200A37492A5CB8B8FB6E89580AA47481225D02F, ___handler_0)); }
	inline HttpMessageHandler_t11B1039BDB93BDFB1C03AC8C2EE195E0ADD06B69 * get_handler_0() const { return ___handler_0; }
	inline HttpMessageHandler_t11B1039BDB93BDFB1C03AC8C2EE195E0ADD06B69 ** get_address_of_handler_0() { return &___handler_0; }
	inline void set_handler_0(HttpMessageHandler_t11B1039BDB93BDFB1C03AC8C2EE195E0ADD06B69 * value)
	{
		___handler_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___handler_0), (void*)value);
	}

	inline static int32_t get_offset_of_disposeHandler_1() { return static_cast<int32_t>(offsetof(HttpMessageInvoker_tB200A37492A5CB8B8FB6E89580AA47481225D02F, ___disposeHandler_1)); }
	inline bool get_disposeHandler_1() const { return ___disposeHandler_1; }
	inline bool* get_address_of_disposeHandler_1() { return &___disposeHandler_1; }
	inline void set_disposeHandler_1(bool value)
	{
		___disposeHandler_1 = value;
	}
};


// System.Net.Http.HttpMethod
struct HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90  : public RuntimeObject
{
public:
	// System.String System.Net.Http.HttpMethod::method
	String_t* ___method_7;

public:
	inline static int32_t get_offset_of_method_7() { return static_cast<int32_t>(offsetof(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90, ___method_7)); }
	inline String_t* get_method_7() const { return ___method_7; }
	inline String_t** get_address_of_method_7() { return &___method_7; }
	inline void set_method_7(String_t* value)
	{
		___method_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_7), (void*)value);
	}
};

struct HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90_StaticFields
{
public:
	// System.Net.Http.HttpMethod System.Net.Http.HttpMethod::delete_method
	HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * ___delete_method_0;
	// System.Net.Http.HttpMethod System.Net.Http.HttpMethod::get_method
	HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * ___get_method_1;
	// System.Net.Http.HttpMethod System.Net.Http.HttpMethod::head_method
	HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * ___head_method_2;
	// System.Net.Http.HttpMethod System.Net.Http.HttpMethod::options_method
	HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * ___options_method_3;
	// System.Net.Http.HttpMethod System.Net.Http.HttpMethod::post_method
	HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * ___post_method_4;
	// System.Net.Http.HttpMethod System.Net.Http.HttpMethod::put_method
	HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * ___put_method_5;
	// System.Net.Http.HttpMethod System.Net.Http.HttpMethod::trace_method
	HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * ___trace_method_6;

public:
	inline static int32_t get_offset_of_delete_method_0() { return static_cast<int32_t>(offsetof(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90_StaticFields, ___delete_method_0)); }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * get_delete_method_0() const { return ___delete_method_0; }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 ** get_address_of_delete_method_0() { return &___delete_method_0; }
	inline void set_delete_method_0(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * value)
	{
		___delete_method_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___delete_method_0), (void*)value);
	}

	inline static int32_t get_offset_of_get_method_1() { return static_cast<int32_t>(offsetof(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90_StaticFields, ___get_method_1)); }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * get_get_method_1() const { return ___get_method_1; }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 ** get_address_of_get_method_1() { return &___get_method_1; }
	inline void set_get_method_1(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * value)
	{
		___get_method_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___get_method_1), (void*)value);
	}

	inline static int32_t get_offset_of_head_method_2() { return static_cast<int32_t>(offsetof(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90_StaticFields, ___head_method_2)); }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * get_head_method_2() const { return ___head_method_2; }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 ** get_address_of_head_method_2() { return &___head_method_2; }
	inline void set_head_method_2(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * value)
	{
		___head_method_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___head_method_2), (void*)value);
	}

	inline static int32_t get_offset_of_options_method_3() { return static_cast<int32_t>(offsetof(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90_StaticFields, ___options_method_3)); }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * get_options_method_3() const { return ___options_method_3; }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 ** get_address_of_options_method_3() { return &___options_method_3; }
	inline void set_options_method_3(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * value)
	{
		___options_method_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___options_method_3), (void*)value);
	}

	inline static int32_t get_offset_of_post_method_4() { return static_cast<int32_t>(offsetof(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90_StaticFields, ___post_method_4)); }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * get_post_method_4() const { return ___post_method_4; }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 ** get_address_of_post_method_4() { return &___post_method_4; }
	inline void set_post_method_4(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * value)
	{
		___post_method_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___post_method_4), (void*)value);
	}

	inline static int32_t get_offset_of_put_method_5() { return static_cast<int32_t>(offsetof(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90_StaticFields, ___put_method_5)); }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * get_put_method_5() const { return ___put_method_5; }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 ** get_address_of_put_method_5() { return &___put_method_5; }
	inline void set_put_method_5(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * value)
	{
		___put_method_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___put_method_5), (void*)value);
	}

	inline static int32_t get_offset_of_trace_method_6() { return static_cast<int32_t>(offsetof(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90_StaticFields, ___trace_method_6)); }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * get_trace_method_6() const { return ___trace_method_6; }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 ** get_address_of_trace_method_6() { return &___trace_method_6; }
	inline void set_trace_method_6(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * value)
	{
		___trace_method_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___trace_method_6), (void*)value);
	}
};


// System.Net.Http.HttpRequestMessage
struct HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F  : public RuntimeObject
{
public:
	// System.Net.Http.Headers.HttpRequestHeaders System.Net.Http.HttpRequestMessage::headers
	HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * ___headers_0;
	// System.Net.Http.HttpMethod System.Net.Http.HttpRequestMessage::method
	HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * ___method_1;
	// System.Version System.Net.Http.HttpRequestMessage::version
	Version_tBDAEDED25425A1D09910468B8BD1759115646E3C * ___version_2;
	// System.Collections.Generic.Dictionary`2<System.String,System.Object> System.Net.Http.HttpRequestMessage::properties
	Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___properties_3;
	// System.Uri System.Net.Http.HttpRequestMessage::uri
	Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * ___uri_4;
	// System.Boolean System.Net.Http.HttpRequestMessage::is_used
	bool ___is_used_5;
	// System.Boolean System.Net.Http.HttpRequestMessage::disposed
	bool ___disposed_6;
	// System.Net.Http.HttpContent System.Net.Http.HttpRequestMessage::<Content>k__BackingField
	HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * ___U3CContentU3Ek__BackingField_7;

public:
	inline static int32_t get_offset_of_headers_0() { return static_cast<int32_t>(offsetof(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F, ___headers_0)); }
	inline HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * get_headers_0() const { return ___headers_0; }
	inline HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 ** get_address_of_headers_0() { return &___headers_0; }
	inline void set_headers_0(HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * value)
	{
		___headers_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___headers_0), (void*)value);
	}

	inline static int32_t get_offset_of_method_1() { return static_cast<int32_t>(offsetof(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F, ___method_1)); }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * get_method_1() const { return ___method_1; }
	inline HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 ** get_address_of_method_1() { return &___method_1; }
	inline void set_method_1(HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * value)
	{
		___method_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_1), (void*)value);
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F, ___version_2)); }
	inline Version_tBDAEDED25425A1D09910468B8BD1759115646E3C * get_version_2() const { return ___version_2; }
	inline Version_tBDAEDED25425A1D09910468B8BD1759115646E3C ** get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(Version_tBDAEDED25425A1D09910468B8BD1759115646E3C * value)
	{
		___version_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___version_2), (void*)value);
	}

	inline static int32_t get_offset_of_properties_3() { return static_cast<int32_t>(offsetof(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F, ___properties_3)); }
	inline Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * get_properties_3() const { return ___properties_3; }
	inline Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 ** get_address_of_properties_3() { return &___properties_3; }
	inline void set_properties_3(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * value)
	{
		___properties_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___properties_3), (void*)value);
	}

	inline static int32_t get_offset_of_uri_4() { return static_cast<int32_t>(offsetof(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F, ___uri_4)); }
	inline Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * get_uri_4() const { return ___uri_4; }
	inline Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 ** get_address_of_uri_4() { return &___uri_4; }
	inline void set_uri_4(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * value)
	{
		___uri_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uri_4), (void*)value);
	}

	inline static int32_t get_offset_of_is_used_5() { return static_cast<int32_t>(offsetof(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F, ___is_used_5)); }
	inline bool get_is_used_5() const { return ___is_used_5; }
	inline bool* get_address_of_is_used_5() { return &___is_used_5; }
	inline void set_is_used_5(bool value)
	{
		___is_used_5 = value;
	}

	inline static int32_t get_offset_of_disposed_6() { return static_cast<int32_t>(offsetof(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F, ___disposed_6)); }
	inline bool get_disposed_6() const { return ___disposed_6; }
	inline bool* get_address_of_disposed_6() { return &___disposed_6; }
	inline void set_disposed_6(bool value)
	{
		___disposed_6 = value;
	}

	inline static int32_t get_offset_of_U3CContentU3Ek__BackingField_7() { return static_cast<int32_t>(offsetof(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F, ___U3CContentU3Ek__BackingField_7)); }
	inline HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * get_U3CContentU3Ek__BackingField_7() const { return ___U3CContentU3Ek__BackingField_7; }
	inline HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 ** get_address_of_U3CContentU3Ek__BackingField_7() { return &___U3CContentU3Ek__BackingField_7; }
	inline void set_U3CContentU3Ek__BackingField_7(HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * value)
	{
		___U3CContentU3Ek__BackingField_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CContentU3Ek__BackingField_7), (void*)value);
	}
};


// TapTap.Common.Json
struct Json_tEFD643722607C44D1E8077774469FD18E4A1ABEE  : public RuntimeObject
{
public:

public:
};


// LC.Newtonsoft.Json.JsonConverter
struct JsonConverter_tB733E18F5460B16D7D15AEC1D601BFBDA786CF5F  : public RuntimeObject
{
public:

public:
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

// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
public:

public:
};


// System.Net.NetworkInformation.NetworkInterface
struct NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB  : public RuntimeObject
{
public:

public:
};


// System.Net.NetworkInformation.PhysicalAddress
struct PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957  : public RuntimeObject
{
public:
	// System.Byte[] System.Net.NetworkInformation.PhysicalAddress::address
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___address_0;
	// System.Boolean System.Net.NetworkInformation.PhysicalAddress::changed
	bool ___changed_1;
	// System.Int32 System.Net.NetworkInformation.PhysicalAddress::hash
	int32_t ___hash_2;

public:
	inline static int32_t get_offset_of_address_0() { return static_cast<int32_t>(offsetof(PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957, ___address_0)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_address_0() const { return ___address_0; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_address_0() { return &___address_0; }
	inline void set_address_0(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___address_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___address_0), (void*)value);
	}

	inline static int32_t get_offset_of_changed_1() { return static_cast<int32_t>(offsetof(PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957, ___changed_1)); }
	inline bool get_changed_1() const { return ___changed_1; }
	inline bool* get_address_of_changed_1() { return &___changed_1; }
	inline void set_changed_1(bool value)
	{
		___changed_1 = value;
	}

	inline static int32_t get_offset_of_hash_2() { return static_cast<int32_t>(offsetof(PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957, ___hash_2)); }
	inline int32_t get_hash_2() const { return ___hash_2; }
	inline int32_t* get_address_of_hash_2() { return &___hash_2; }
	inline void set_hash_2(int32_t value)
	{
		___hash_2 = value;
	}
};

struct PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957_StaticFields
{
public:
	// System.Net.NetworkInformation.PhysicalAddress System.Net.NetworkInformation.PhysicalAddress::None
	PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957 * ___None_3;

public:
	inline static int32_t get_offset_of_None_3() { return static_cast<int32_t>(offsetof(PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957_StaticFields, ___None_3)); }
	inline PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957 * get_None_3() const { return ___None_3; }
	inline PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957 ** get_address_of_None_3() { return &___None_3; }
	inline void set_None_3(PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957 * value)
	{
		___None_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___None_3), (void*)value);
	}
};


// TapTap.Common.Platform
struct Platform_t403CA7508AFEC1DAE3551DEE6F6FAD08E7529AA1  : public RuntimeObject
{
public:

public:
};


// TapTap.Common.Result
struct Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2  : public RuntimeObject
{
public:
	// System.Int32 TapTap.Common.Result::code
	int32_t ___code_2;
	// System.String TapTap.Common.Result::content
	String_t* ___content_3;
	// System.String TapTap.Common.Result::callbackId
	String_t* ___callbackId_4;
	// System.Boolean TapTap.Common.Result::onceTime
	bool ___onceTime_5;

public:
	inline static int32_t get_offset_of_code_2() { return static_cast<int32_t>(offsetof(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2, ___code_2)); }
	inline int32_t get_code_2() const { return ___code_2; }
	inline int32_t* get_address_of_code_2() { return &___code_2; }
	inline void set_code_2(int32_t value)
	{
		___code_2 = value;
	}

	inline static int32_t get_offset_of_content_3() { return static_cast<int32_t>(offsetof(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2, ___content_3)); }
	inline String_t* get_content_3() const { return ___content_3; }
	inline String_t** get_address_of_content_3() { return &___content_3; }
	inline void set_content_3(String_t* value)
	{
		___content_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___content_3), (void*)value);
	}

	inline static int32_t get_offset_of_callbackId_4() { return static_cast<int32_t>(offsetof(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2, ___callbackId_4)); }
	inline String_t* get_callbackId_4() const { return ___callbackId_4; }
	inline String_t** get_address_of_callbackId_4() { return &___callbackId_4; }
	inline void set_callbackId_4(String_t* value)
	{
		___callbackId_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callbackId_4), (void*)value);
	}

	inline static int32_t get_offset_of_onceTime_5() { return static_cast<int32_t>(offsetof(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2, ___onceTime_5)); }
	inline bool get_onceTime_5() const { return ___onceTime_5; }
	inline bool* get_address_of_onceTime_5() { return &___onceTime_5; }
	inline void set_onceTime_5(bool value)
	{
		___onceTime_5 = value;
	}
};

struct Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_StaticFields
{
public:
	// System.Int32 TapTap.Common.Result::RESULT_SUCCESS
	int32_t ___RESULT_SUCCESS_0;
	// System.Int32 TapTap.Common.Result::RESULT_ERROR
	int32_t ___RESULT_ERROR_1;

public:
	inline static int32_t get_offset_of_RESULT_SUCCESS_0() { return static_cast<int32_t>(offsetof(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_StaticFields, ___RESULT_SUCCESS_0)); }
	inline int32_t get_RESULT_SUCCESS_0() const { return ___RESULT_SUCCESS_0; }
	inline int32_t* get_address_of_RESULT_SUCCESS_0() { return &___RESULT_SUCCESS_0; }
	inline void set_RESULT_SUCCESS_0(int32_t value)
	{
		___RESULT_SUCCESS_0 = value;
	}

	inline static int32_t get_offset_of_RESULT_ERROR_1() { return static_cast<int32_t>(offsetof(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_StaticFields, ___RESULT_ERROR_1)); }
	inline int32_t get_RESULT_ERROR_1() const { return ___RESULT_ERROR_1; }
	inline int32_t* get_address_of_RESULT_ERROR_1() { return &___RESULT_ERROR_1; }
	inline void set_RESULT_ERROR_1(int32_t value)
	{
		___RESULT_ERROR_1 = value;
	}
};


// TapTap.Common.SafeDictionary
struct SafeDictionary_t8961EC5C9E1830D3EA7AEB6329352A4CF6404952  : public RuntimeObject
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


// System.Text.StringBuilder
struct StringBuilder_t  : public RuntimeObject
{
public:
	// System.Char[] System.Text.StringBuilder::m_ChunkChars
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___m_ChunkChars_0;
	// System.Text.StringBuilder System.Text.StringBuilder::m_ChunkPrevious
	StringBuilder_t * ___m_ChunkPrevious_1;
	// System.Int32 System.Text.StringBuilder::m_ChunkLength
	int32_t ___m_ChunkLength_2;
	// System.Int32 System.Text.StringBuilder::m_ChunkOffset
	int32_t ___m_ChunkOffset_3;
	// System.Int32 System.Text.StringBuilder::m_MaxCapacity
	int32_t ___m_MaxCapacity_4;

public:
	inline static int32_t get_offset_of_m_ChunkChars_0() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkChars_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_m_ChunkChars_0() const { return ___m_ChunkChars_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_m_ChunkChars_0() { return &___m_ChunkChars_0; }
	inline void set_m_ChunkChars_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___m_ChunkChars_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ChunkChars_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_ChunkPrevious_1() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkPrevious_1)); }
	inline StringBuilder_t * get_m_ChunkPrevious_1() const { return ___m_ChunkPrevious_1; }
	inline StringBuilder_t ** get_address_of_m_ChunkPrevious_1() { return &___m_ChunkPrevious_1; }
	inline void set_m_ChunkPrevious_1(StringBuilder_t * value)
	{
		___m_ChunkPrevious_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ChunkPrevious_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_ChunkLength_2() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkLength_2)); }
	inline int32_t get_m_ChunkLength_2() const { return ___m_ChunkLength_2; }
	inline int32_t* get_address_of_m_ChunkLength_2() { return &___m_ChunkLength_2; }
	inline void set_m_ChunkLength_2(int32_t value)
	{
		___m_ChunkLength_2 = value;
	}

	inline static int32_t get_offset_of_m_ChunkOffset_3() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkOffset_3)); }
	inline int32_t get_m_ChunkOffset_3() const { return ___m_ChunkOffset_3; }
	inline int32_t* get_address_of_m_ChunkOffset_3() { return &___m_ChunkOffset_3; }
	inline void set_m_ChunkOffset_3(int32_t value)
	{
		___m_ChunkOffset_3 = value;
	}

	inline static int32_t get_offset_of_m_MaxCapacity_4() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_MaxCapacity_4)); }
	inline int32_t get_m_MaxCapacity_4() const { return ___m_MaxCapacity_4; }
	inline int32_t* get_address_of_m_MaxCapacity_4() { return &___m_MaxCapacity_4; }
	inline void set_m_MaxCapacity_4(int32_t value)
	{
		___m_MaxCapacity_4 = value;
	}
};


// TapTap.Common.TapError
struct TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4  : public RuntimeObject
{
public:
	// System.Int32 TapTap.Common.TapError::code
	int32_t ___code_0;
	// System.String TapTap.Common.TapError::errorDescription
	String_t* ___errorDescription_1;

public:
	inline static int32_t get_offset_of_code_0() { return static_cast<int32_t>(offsetof(TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4, ___code_0)); }
	inline int32_t get_code_0() const { return ___code_0; }
	inline int32_t* get_address_of_code_0() { return &___code_0; }
	inline void set_code_0(int32_t value)
	{
		___code_0 = value;
	}

	inline static int32_t get_offset_of_errorDescription_1() { return static_cast<int32_t>(offsetof(TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4, ___errorDescription_1)); }
	inline String_t* get_errorDescription_1() const { return ___errorDescription_1; }
	inline String_t** get_address_of_errorDescription_1() { return &___errorDescription_1; }
	inline void set_errorDescription_1(String_t* value)
	{
		___errorDescription_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___errorDescription_1), (void*)value);
	}
};


// TapTap.Common.Internal.Http.TapHttpUtils
struct TapHttpUtils_t81191C334B108DB459F5FF15C8B2CAFCFDED3659  : public RuntimeObject
{
public:

public:
};


// TapTap.Common.TapLogger
struct TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A  : public RuntimeObject
{
public:

public:
};

struct TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_StaticFields
{
public:
	// System.Action`2<TapTap.Common.TapLogLevel,System.String> TapTap.Common.TapLogger::<LogDelegate>k__BackingField
	Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * ___U3CLogDelegateU3Ek__BackingField_0;

public:
	inline static int32_t get_offset_of_U3CLogDelegateU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_StaticFields, ___U3CLogDelegateU3Ek__BackingField_0)); }
	inline Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * get_U3CLogDelegateU3Ek__BackingField_0() const { return ___U3CLogDelegateU3Ek__BackingField_0; }
	inline Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 ** get_address_of_U3CLogDelegateU3Ek__BackingField_0() { return &___U3CLogDelegateU3Ek__BackingField_0; }
	inline void set_U3CLogDelegateU3Ek__BackingField_0(Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * value)
	{
		___U3CLogDelegateU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CLogDelegateU3Ek__BackingField_0), (void*)value);
	}
};


// TapTap.Common.TapUUID
struct TapUUID_t892B00C41E58C2A1C36D3668A167DDDC9978BAE7  : public RuntimeObject
{
public:

public:
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

// TapTap.Common.Command/Builder
struct Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2  : public RuntimeObject
{
public:
	// System.String TapTap.Common.Command/Builder::service
	String_t* ___service_0;
	// System.String TapTap.Common.Command/Builder::method
	String_t* ___method_1;
	// System.Boolean TapTap.Common.Command/Builder::callback
	bool ___callback_2;
	// System.String TapTap.Common.Command/Builder::callbackId
	String_t* ___callbackId_3;
	// System.Boolean TapTap.Common.Command/Builder::onceTime
	bool ___onceTime_4;
	// System.Collections.Generic.Dictionary`2<System.String,System.Object> TapTap.Common.Command/Builder::args
	Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___args_5;

public:
	inline static int32_t get_offset_of_service_0() { return static_cast<int32_t>(offsetof(Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2, ___service_0)); }
	inline String_t* get_service_0() const { return ___service_0; }
	inline String_t** get_address_of_service_0() { return &___service_0; }
	inline void set_service_0(String_t* value)
	{
		___service_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___service_0), (void*)value);
	}

	inline static int32_t get_offset_of_method_1() { return static_cast<int32_t>(offsetof(Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2, ___method_1)); }
	inline String_t* get_method_1() const { return ___method_1; }
	inline String_t** get_address_of_method_1() { return &___method_1; }
	inline void set_method_1(String_t* value)
	{
		___method_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___method_1), (void*)value);
	}

	inline static int32_t get_offset_of_callback_2() { return static_cast<int32_t>(offsetof(Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2, ___callback_2)); }
	inline bool get_callback_2() const { return ___callback_2; }
	inline bool* get_address_of_callback_2() { return &___callback_2; }
	inline void set_callback_2(bool value)
	{
		___callback_2 = value;
	}

	inline static int32_t get_offset_of_callbackId_3() { return static_cast<int32_t>(offsetof(Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2, ___callbackId_3)); }
	inline String_t* get_callbackId_3() const { return ___callbackId_3; }
	inline String_t** get_address_of_callbackId_3() { return &___callbackId_3; }
	inline void set_callbackId_3(String_t* value)
	{
		___callbackId_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callbackId_3), (void*)value);
	}

	inline static int32_t get_offset_of_onceTime_4() { return static_cast<int32_t>(offsetof(Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2, ___onceTime_4)); }
	inline bool get_onceTime_4() const { return ___onceTime_4; }
	inline bool* get_address_of_onceTime_4() { return &___onceTime_4; }
	inline void set_onceTime_4(bool value)
	{
		___onceTime_4 = value;
	}

	inline static int32_t get_offset_of_args_5() { return static_cast<int32_t>(offsetof(Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2, ___args_5)); }
	inline Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * get_args_5() const { return ___args_5; }
	inline Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 ** get_address_of_args_5() { return &___args_5; }
	inline void set_args_5(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * value)
	{
		___args_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___args_5), (void*)value);
	}
};


// TapTap.Common.EngineBridge/<>c__DisplayClass8_0
struct U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474  : public RuntimeObject
{
public:
	// System.Threading.Tasks.TaskCompletionSource`1<TapTap.Common.Result> TapTap.Common.EngineBridge/<>c__DisplayClass8_0::tcs
	TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * ___tcs_0;

public:
	inline static int32_t get_offset_of_tcs_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474, ___tcs_0)); }
	inline TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * get_tcs_0() const { return ___tcs_0; }
	inline TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD ** get_address_of_tcs_0() { return &___tcs_0; }
	inline void set_tcs_0(TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * value)
	{
		___tcs_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tcs_0), (void*)value);
	}
};


// TapTap.Common.Json/Parser
struct Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9  : public RuntimeObject
{
public:
	// System.IO.StringReader TapTap.Common.Json/Parser::json
	StringReader_t74E352C280EAC22C878867444978741F19E1F895 * ___json_0;

public:
	inline static int32_t get_offset_of_json_0() { return static_cast<int32_t>(offsetof(Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9, ___json_0)); }
	inline StringReader_t74E352C280EAC22C878867444978741F19E1F895 * get_json_0() const { return ___json_0; }
	inline StringReader_t74E352C280EAC22C878867444978741F19E1F895 ** get_address_of_json_0() { return &___json_0; }
	inline void set_json_0(StringReader_t74E352C280EAC22C878867444978741F19E1F895 * value)
	{
		___json_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___json_0), (void*)value);
	}
};


// TapTap.Common.Json/Serializer
struct Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE  : public RuntimeObject
{
public:
	// System.Text.StringBuilder TapTap.Common.Json/Serializer::builder
	StringBuilder_t * ___builder_0;

public:
	inline static int32_t get_offset_of_builder_0() { return static_cast<int32_t>(offsetof(Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE, ___builder_0)); }
	inline StringBuilder_t * get_builder_0() const { return ___builder_0; }
	inline StringBuilder_t ** get_address_of_builder_0() { return &___builder_0; }
	inline void set_builder_0(StringBuilder_t * value)
	{
		___builder_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___builder_0), (void*)value);
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


// System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.IEnumerable`1<System.String>>
struct KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 
{
public:
	// TKey System.Collections.Generic.KeyValuePair`2::key
	String_t* ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	RuntimeObject* ___value_1;

public:
	inline static int32_t get_offset_of_key_0() { return static_cast<int32_t>(offsetof(KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38, ___key_0)); }
	inline String_t* get_key_0() const { return ___key_0; }
	inline String_t** get_address_of_key_0() { return &___key_0; }
	inline void set_key_0(String_t* value)
	{
		___key_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___key_0), (void*)value);
	}

	inline static int32_t get_offset_of_value_1() { return static_cast<int32_t>(offsetof(KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38, ___value_1)); }
	inline RuntimeObject* get_value_1() const { return ___value_1; }
	inline RuntimeObject** get_address_of_value_1() { return &___value_1; }
	inline void set_value_1(RuntimeObject* value)
	{
		___value_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___value_1), (void*)value);
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


// System.Nullable`1<System.Int32>
struct Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// UnityEngine.AndroidJavaClass
struct AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4  : public AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E
{
public:

public:
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


// System.Char
struct Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14 
{
public:
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14, ___m_value_0)); }
	inline Il2CppChar get_m_value_0() const { return ___m_value_0; }
	inline Il2CppChar* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(Il2CppChar value)
	{
		___m_value_0 = value;
	}
};

struct Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_StaticFields
{
public:
	// System.Byte[] System.Char::categoryForLatin1
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___categoryForLatin1_3;

public:
	inline static int32_t get_offset_of_categoryForLatin1_3() { return static_cast<int32_t>(offsetof(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_StaticFields, ___categoryForLatin1_3)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_categoryForLatin1_3() const { return ___categoryForLatin1_3; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_categoryForLatin1_3() { return &___categoryForLatin1_3; }
	inline void set_categoryForLatin1_3(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___categoryForLatin1_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___categoryForLatin1_3), (void*)value);
	}
};


// System.Decimal
struct Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 
{
public:
	// System.Int32 System.Decimal::flags
	int32_t ___flags_14;
	// System.Int32 System.Decimal::hi
	int32_t ___hi_15;
	// System.Int32 System.Decimal::lo
	int32_t ___lo_16;
	// System.Int32 System.Decimal::mid
	int32_t ___mid_17;

public:
	inline static int32_t get_offset_of_flags_14() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7, ___flags_14)); }
	inline int32_t get_flags_14() const { return ___flags_14; }
	inline int32_t* get_address_of_flags_14() { return &___flags_14; }
	inline void set_flags_14(int32_t value)
	{
		___flags_14 = value;
	}

	inline static int32_t get_offset_of_hi_15() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7, ___hi_15)); }
	inline int32_t get_hi_15() const { return ___hi_15; }
	inline int32_t* get_address_of_hi_15() { return &___hi_15; }
	inline void set_hi_15(int32_t value)
	{
		___hi_15 = value;
	}

	inline static int32_t get_offset_of_lo_16() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7, ___lo_16)); }
	inline int32_t get_lo_16() const { return ___lo_16; }
	inline int32_t* get_address_of_lo_16() { return &___lo_16; }
	inline void set_lo_16(int32_t value)
	{
		___lo_16 = value;
	}

	inline static int32_t get_offset_of_mid_17() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7, ___mid_17)); }
	inline int32_t get_mid_17() const { return ___mid_17; }
	inline int32_t* get_address_of_mid_17() { return &___mid_17; }
	inline void set_mid_17(int32_t value)
	{
		___mid_17 = value;
	}
};

struct Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields
{
public:
	// System.UInt32[] System.Decimal::Powers10
	UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* ___Powers10_6;
	// System.Decimal System.Decimal::Zero
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___Zero_7;
	// System.Decimal System.Decimal::One
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___One_8;
	// System.Decimal System.Decimal::MinusOne
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___MinusOne_9;
	// System.Decimal System.Decimal::MaxValue
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___MaxValue_10;
	// System.Decimal System.Decimal::MinValue
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___MinValue_11;
	// System.Decimal System.Decimal::NearNegativeZero
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___NearNegativeZero_12;
	// System.Decimal System.Decimal::NearPositiveZero
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___NearPositiveZero_13;

public:
	inline static int32_t get_offset_of_Powers10_6() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields, ___Powers10_6)); }
	inline UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* get_Powers10_6() const { return ___Powers10_6; }
	inline UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF** get_address_of_Powers10_6() { return &___Powers10_6; }
	inline void set_Powers10_6(UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF* value)
	{
		___Powers10_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Powers10_6), (void*)value);
	}

	inline static int32_t get_offset_of_Zero_7() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields, ___Zero_7)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_Zero_7() const { return ___Zero_7; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_Zero_7() { return &___Zero_7; }
	inline void set_Zero_7(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___Zero_7 = value;
	}

	inline static int32_t get_offset_of_One_8() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields, ___One_8)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_One_8() const { return ___One_8; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_One_8() { return &___One_8; }
	inline void set_One_8(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___One_8 = value;
	}

	inline static int32_t get_offset_of_MinusOne_9() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields, ___MinusOne_9)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_MinusOne_9() const { return ___MinusOne_9; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_MinusOne_9() { return &___MinusOne_9; }
	inline void set_MinusOne_9(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___MinusOne_9 = value;
	}

	inline static int32_t get_offset_of_MaxValue_10() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields, ___MaxValue_10)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_MaxValue_10() const { return ___MaxValue_10; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_MaxValue_10() { return &___MaxValue_10; }
	inline void set_MaxValue_10(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___MaxValue_10 = value;
	}

	inline static int32_t get_offset_of_MinValue_11() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields, ___MinValue_11)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_MinValue_11() const { return ___MinValue_11; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_MinValue_11() { return &___MinValue_11; }
	inline void set_MinValue_11(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___MinValue_11 = value;
	}

	inline static int32_t get_offset_of_NearNegativeZero_12() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields, ___NearNegativeZero_12)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_NearNegativeZero_12() const { return ___NearNegativeZero_12; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_NearNegativeZero_12() { return &___NearNegativeZero_12; }
	inline void set_NearNegativeZero_12(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___NearNegativeZero_12 = value;
	}

	inline static int32_t get_offset_of_NearPositiveZero_13() { return static_cast<int32_t>(offsetof(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_StaticFields, ___NearPositiveZero_13)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_NearPositiveZero_13() const { return ___NearPositiveZero_13; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_NearPositiveZero_13() { return &___NearPositiveZero_13; }
	inline void set_NearPositiveZero_13(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___NearPositiveZero_13 = value;
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


// System.Int16
struct Int16_tD0F031114106263BB459DA1F099FF9F42691295A 
{
public:
	// System.Int16 System.Int16::m_value
	int16_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int16_tD0F031114106263BB459DA1F099FF9F42691295A, ___m_value_0)); }
	inline int16_t get_m_value_0() const { return ___m_value_0; }
	inline int16_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int16_t value)
	{
		___m_value_0 = value;
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


// System.SByte
struct SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B 
{
public:
	// System.SByte System.SByte::m_value
	int8_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B, ___m_value_0)); }
	inline int8_t get_m_value_0() const { return ___m_value_0; }
	inline int8_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int8_t value)
	{
		___m_value_0 = value;
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


// TapTap.Common.Internal.Json.TapJsonConverter
struct TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE  : public JsonConverter_tB733E18F5460B16D7D15AEC1D601BFBDA786CF5F
{
public:

public:
};

struct TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE_StaticFields
{
public:
	// TapTap.Common.Internal.Json.TapJsonConverter TapTap.Common.Internal.Json.TapJsonConverter::Default
	TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * ___Default_0;

public:
	inline static int32_t get_offset_of_Default_0() { return static_cast<int32_t>(offsetof(TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE_StaticFields, ___Default_0)); }
	inline TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * get_Default_0() const { return ___Default_0; }
	inline TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE ** get_address_of_Default_0() { return &___Default_0; }
	inline void set_Default_0(TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * value)
	{
		___Default_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Default_0), (void*)value);
	}
};


// System.IO.TextReader
struct TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F  : public MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8
{
public:

public:
};

struct TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F_StaticFields
{
public:
	// System.Func`2<System.Object,System.String> System.IO.TextReader::_ReadLineDelegate
	Func_2_t060A650AB95DEF14D4F579FA5999ACEFEEE0FD82 * ____ReadLineDelegate_1;
	// System.Func`2<System.Object,System.Int32> System.IO.TextReader::_ReadDelegate
	Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * ____ReadDelegate_2;
	// System.IO.TextReader System.IO.TextReader::Null
	TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F * ___Null_3;

public:
	inline static int32_t get_offset_of__ReadLineDelegate_1() { return static_cast<int32_t>(offsetof(TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F_StaticFields, ____ReadLineDelegate_1)); }
	inline Func_2_t060A650AB95DEF14D4F579FA5999ACEFEEE0FD82 * get__ReadLineDelegate_1() const { return ____ReadLineDelegate_1; }
	inline Func_2_t060A650AB95DEF14D4F579FA5999ACEFEEE0FD82 ** get_address_of__ReadLineDelegate_1() { return &____ReadLineDelegate_1; }
	inline void set__ReadLineDelegate_1(Func_2_t060A650AB95DEF14D4F579FA5999ACEFEEE0FD82 * value)
	{
		____ReadLineDelegate_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____ReadLineDelegate_1), (void*)value);
	}

	inline static int32_t get_offset_of__ReadDelegate_2() { return static_cast<int32_t>(offsetof(TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F_StaticFields, ____ReadDelegate_2)); }
	inline Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * get__ReadDelegate_2() const { return ____ReadDelegate_2; }
	inline Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C ** get_address_of__ReadDelegate_2() { return &____ReadDelegate_2; }
	inline void set__ReadDelegate_2(Func_2_t0CEE9D1C856153BA9C23BB9D7E929D577AF37A2C * value)
	{
		____ReadDelegate_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____ReadDelegate_2), (void*)value);
	}

	inline static int32_t get_offset_of_Null_3() { return static_cast<int32_t>(offsetof(TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F_StaticFields, ___Null_3)); }
	inline TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F * get_Null_3() const { return ___Null_3; }
	inline TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F ** get_address_of_Null_3() { return &___Null_3; }
	inline void set_Null_3(TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F * value)
	{
		___Null_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Null_3), (void*)value);
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


// UnityEngine.AndroidJavaProxy
struct AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF  : public RuntimeObject
{
public:
	// UnityEngine.AndroidJavaClass UnityEngine.AndroidJavaProxy::javaInterface
	AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * ___javaInterface_0;
	// System.IntPtr UnityEngine.AndroidJavaProxy::proxyObject
	intptr_t ___proxyObject_1;

public:
	inline static int32_t get_offset_of_javaInterface_0() { return static_cast<int32_t>(offsetof(AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF, ___javaInterface_0)); }
	inline AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * get_javaInterface_0() const { return ___javaInterface_0; }
	inline AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 ** get_address_of_javaInterface_0() { return &___javaInterface_0; }
	inline void set_javaInterface_0(AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * value)
	{
		___javaInterface_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___javaInterface_0), (void*)value);
	}

	inline static int32_t get_offset_of_proxyObject_1() { return static_cast<int32_t>(offsetof(AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF, ___proxyObject_1)); }
	inline intptr_t get_proxyObject_1() const { return ___proxyObject_1; }
	inline intptr_t* get_address_of_proxyObject_1() { return &___proxyObject_1; }
	inline void set_proxyObject_1(intptr_t value)
	{
		___proxyObject_1 = value;
	}
};

struct AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF_StaticFields
{
public:
	// UnityEngine.GlobalJavaObjectRef UnityEngine.AndroidJavaProxy::s_JavaLangSystemClass
	GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * ___s_JavaLangSystemClass_2;
	// System.IntPtr UnityEngine.AndroidJavaProxy::s_HashCodeMethodID
	intptr_t ___s_HashCodeMethodID_3;

public:
	inline static int32_t get_offset_of_s_JavaLangSystemClass_2() { return static_cast<int32_t>(offsetof(AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF_StaticFields, ___s_JavaLangSystemClass_2)); }
	inline GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * get_s_JavaLangSystemClass_2() const { return ___s_JavaLangSystemClass_2; }
	inline GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 ** get_address_of_s_JavaLangSystemClass_2() { return &___s_JavaLangSystemClass_2; }
	inline void set_s_JavaLangSystemClass_2(GlobalJavaObjectRef_t04A7D04EB0317C286F089E4DB4444EC4F2D78289 * value)
	{
		___s_JavaLangSystemClass_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_JavaLangSystemClass_2), (void*)value);
	}

	inline static int32_t get_offset_of_s_HashCodeMethodID_3() { return static_cast<int32_t>(offsetof(AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF_StaticFields, ___s_HashCodeMethodID_3)); }
	inline intptr_t get_s_HashCodeMethodID_3() const { return ___s_HashCodeMethodID_3; }
	inline intptr_t* get_address_of_s_HashCodeMethodID_3() { return &___s_HashCodeMethodID_3; }
	inline void set_s_HashCodeMethodID_3(intptr_t value)
	{
		___s_HashCodeMethodID_3 = value;
	}
};


// System.Reflection.BindingFlags
struct BindingFlags_tAAAB07D9AC588F0D55D844E51D7035E96DF94733 
{
public:
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(BindingFlags_tAAAB07D9AC588F0D55D844E51D7035E96DF94733, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Security.Cryptography.CipherMode
struct CipherMode_t4B09770C743AD8BCCA4B44539D0F4725DFCBCE50 
{
public:
	// System.Int32 System.Security.Cryptography.CipherMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(CipherMode_t4B09770C743AD8BCCA4B44539D0F4725DFCBCE50, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.ConstructorHandling
struct ConstructorHandling_t32825F21B812C15DE77E477575E45F3940093F61 
{
public:
	// System.Int32 LC.Newtonsoft.Json.ConstructorHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ConstructorHandling_t32825F21B812C15DE77E477575E45F3940093F61, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Security.Cryptography.CryptoStreamMode
struct CryptoStreamMode_t07EDEDDA82CABCD8B72DA0ABB2A8E384CBCF68D5 
{
public:
	// System.Int32 System.Security.Cryptography.CryptoStreamMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(CryptoStreamMode_t07EDEDDA82CABCD8B72DA0ABB2A8E384CBCF68D5, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.DateFormatHandling
struct DateFormatHandling_tFE5AB930E7222600717EB4810FAB487AD48CE944 
{
public:
	// System.Int32 LC.Newtonsoft.Json.DateFormatHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DateFormatHandling_tFE5AB930E7222600717EB4810FAB487AD48CE944, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.DateParseHandling
struct DateParseHandling_t6DC22D5557322BAD7F3A48ED7C210FD3DABF52B2 
{
public:
	// System.Int32 LC.Newtonsoft.Json.DateParseHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DateParseHandling_t6DC22D5557322BAD7F3A48ED7C210FD3DABF52B2, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.DateTimeZoneHandling
struct DateTimeZoneHandling_t442C57EFBB790633BF03411E393808E08434EBF1 
{
public:
	// System.Int32 LC.Newtonsoft.Json.DateTimeZoneHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DateTimeZoneHandling_t442C57EFBB790633BF03411E393808E08434EBF1, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.DefaultValueHandling
struct DefaultValueHandling_tAA4587F35E9EAF272E5D81064173A5327074203E 
{
public:
	// System.Int32 LC.Newtonsoft.Json.DefaultValueHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DefaultValueHandling_tAA4587F35E9EAF272E5D81064173A5327074203E, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
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

// LC.Newtonsoft.Json.FloatFormatHandling
struct FloatFormatHandling_t71D221DE6740F42DCD0034024DCC810AF78022B3 
{
public:
	// System.Int32 LC.Newtonsoft.Json.FloatFormatHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FloatFormatHandling_t71D221DE6740F42DCD0034024DCC810AF78022B3, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.FloatParseHandling
struct FloatParseHandling_t4EAA4D1805EF4C15891702DA498C641EEAC2D37E 
{
public:
	// System.Int32 LC.Newtonsoft.Json.FloatParseHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FloatParseHandling_t4EAA4D1805EF4C15891702DA498C641EEAC2D37E, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.Formatting
struct Formatting_t033EEE0BFAFD9A3216B56C02EE9B682274322B32 
{
public:
	// System.Int32 LC.Newtonsoft.Json.Formatting::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Formatting_t033EEE0BFAFD9A3216B56C02EE9B682274322B32, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Net.Http.Headers.HttpHeaderKind
struct HttpHeaderKind_t787798AEC9ED07F499DF8361CF23993D8D1EE0D3 
{
public:
	// System.Int32 System.Net.Http.Headers.HttpHeaderKind::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(HttpHeaderKind_t787798AEC9ED07F499DF8361CF23993D8D1EE0D3, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Net.HttpStatusCode
struct HttpStatusCode_tFCB1BA96A101857DA7C390345DE43B77F9567D98 
{
public:
	// System.Int32 System.Net.HttpStatusCode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(HttpStatusCode_tFCB1BA96A101857DA7C390345DE43B77F9567D98, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Int32Enum
struct Int32Enum_t9B63F771913F2B6D586F1173B44A41FBE26F6B5C 
{
public:
	// System.Int32 System.Int32Enum::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Int32Enum_t9B63F771913F2B6D586F1173B44A41FBE26F6B5C, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.JsonContainerType
struct JsonContainerType_tE87D546C3126B90C71C925A0E01D51AD78AF91F6 
{
public:
	// System.Int32 LC.Newtonsoft.Json.JsonContainerType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(JsonContainerType_tE87D546C3126B90C71C925A0E01D51AD78AF91F6, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.JsonToken
struct JsonToken_tE3431070FF92CB2CCCCD79E3A014785E2B32FBE4 
{
public:
	// System.Int32 LC.Newtonsoft.Json.JsonToken::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(JsonToken_tE3431070FF92CB2CCCCD79E3A014785E2B32FBE4, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
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


// LC.Newtonsoft.Json.MetadataPropertyHandling
struct MetadataPropertyHandling_tA5A2DA3733F67D8859FE12A6570C98507B5098F1 
{
public:
	// System.Int32 LC.Newtonsoft.Json.MetadataPropertyHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MetadataPropertyHandling_tA5A2DA3733F67D8859FE12A6570C98507B5098F1, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.MissingMemberHandling
struct MissingMemberHandling_tEC652E8E848B2C3D2A16B4C4EC996040B5E86952 
{
public:
	// System.Int32 LC.Newtonsoft.Json.MissingMemberHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MissingMemberHandling_tEC652E8E848B2C3D2A16B4C4EC996040B5E86952, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.NullValueHandling
struct NullValueHandling_t9FE751CBC72A37091C5835B9DFC6AC51F032CF51 
{
public:
	// System.Int32 LC.Newtonsoft.Json.NullValueHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(NullValueHandling_t9FE751CBC72A37091C5835B9DFC6AC51F032CF51, ___value___2)); }
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


// LC.Newtonsoft.Json.ObjectCreationHandling
struct ObjectCreationHandling_t1C45AF9899B4C602A53B72E1BB5A12E78E647880 
{
public:
	// System.Int32 LC.Newtonsoft.Json.ObjectCreationHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ObjectCreationHandling_t1C45AF9899B4C602A53B72E1BB5A12E78E647880, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Security.Cryptography.PaddingMode
struct PaddingMode_t290E663334E2B7C9D97E4E1985CB3CAAB7B432D3 
{
public:
	// System.Int32 System.Security.Cryptography.PaddingMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PaddingMode_t290E663334E2B7C9D97E4E1985CB3CAAB7B432D3, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.PreserveReferencesHandling
struct PreserveReferencesHandling_t6675B3D247936265B325C5A90D4503151225B10C 
{
public:
	// System.Int32 LC.Newtonsoft.Json.PreserveReferencesHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PreserveReferencesHandling_t6675B3D247936265B325C5A90D4503151225B10C, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.ReferenceLoopHandling
struct ReferenceLoopHandling_t12C931EA32352FD008CFF0EB0FE86148570ED79D 
{
public:
	// System.Int32 LC.Newtonsoft.Json.ReferenceLoopHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ReferenceLoopHandling_t12C931EA32352FD008CFF0EB0FE86148570ED79D, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.RuntimeFieldHandle
struct RuntimeFieldHandle_t7BE65FC857501059EBAC9772C93B02CD413D9C96 
{
public:
	// System.IntPtr System.RuntimeFieldHandle::value
	intptr_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(RuntimeFieldHandle_t7BE65FC857501059EBAC9772C93B02CD413D9C96, ___value_0)); }
	inline intptr_t get_value_0() const { return ___value_0; }
	inline intptr_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(intptr_t value)
	{
		___value_0 = value;
	}
};


// UnityEngine.RuntimePlatform
struct RuntimePlatform_tB8798C800FD9810C0FE2B7D2F2A0A3979D239065 
{
public:
	// System.Int32 UnityEngine.RuntimePlatform::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(RuntimePlatform_tB8798C800FD9810C0FE2B7D2F2A0A3979D239065, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.RuntimeTypeHandle
struct RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 
{
public:
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9, ___value_0)); }
	inline intptr_t get_value_0() const { return ___value_0; }
	inline intptr_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(intptr_t value)
	{
		___value_0 = value;
	}
};


// System.Runtime.Serialization.StreamingContextStates
struct StreamingContextStates_tF4C7FE6D6121BD4C67699869C8269A60B36B42C3 
{
public:
	// System.Int32 System.Runtime.Serialization.StreamingContextStates::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(StreamingContextStates_tF4C7FE6D6121BD4C67699869C8269A60B36B42C3, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.StringEscapeHandling
struct StringEscapeHandling_tC82C37A061858B87F0207881248EE559112CCD39 
{
public:
	// System.Int32 LC.Newtonsoft.Json.StringEscapeHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(StringEscapeHandling_tC82C37A061858B87F0207881248EE559112CCD39, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.IO.StringReader
struct StringReader_t74E352C280EAC22C878867444978741F19E1F895  : public TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F
{
public:
	// System.String System.IO.StringReader::_s
	String_t* ____s_4;
	// System.Int32 System.IO.StringReader::_pos
	int32_t ____pos_5;
	// System.Int32 System.IO.StringReader::_length
	int32_t ____length_6;

public:
	inline static int32_t get_offset_of__s_4() { return static_cast<int32_t>(offsetof(StringReader_t74E352C280EAC22C878867444978741F19E1F895, ____s_4)); }
	inline String_t* get__s_4() const { return ____s_4; }
	inline String_t** get_address_of__s_4() { return &____s_4; }
	inline void set__s_4(String_t* value)
	{
		____s_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____s_4), (void*)value);
	}

	inline static int32_t get_offset_of__pos_5() { return static_cast<int32_t>(offsetof(StringReader_t74E352C280EAC22C878867444978741F19E1F895, ____pos_5)); }
	inline int32_t get__pos_5() const { return ____pos_5; }
	inline int32_t* get_address_of__pos_5() { return &____pos_5; }
	inline void set__pos_5(int32_t value)
	{
		____pos_5 = value;
	}

	inline static int32_t get_offset_of__length_6() { return static_cast<int32_t>(offsetof(StringReader_t74E352C280EAC22C878867444978741F19E1F895, ____length_6)); }
	inline int32_t get__length_6() const { return ____length_6; }
	inline int32_t* get_address_of__length_6() { return &____length_6; }
	inline void set__length_6(int32_t value)
	{
		____length_6 = value;
	}
};


// UnityEngine.SystemLanguage
struct SystemLanguage_tF8A9C86102588DE9A5041719609C2693D283B3A6 
{
public:
	// System.Int32 UnityEngine.SystemLanguage::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(SystemLanguage_tF8A9C86102588DE9A5041719609C2693D283B3A6, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// TapTap.Common.TapLanguage
struct TapLanguage_tA55EE013DD29D62B9C75DBF4697FD74F4CBEF9C5 
{
public:
	// System.Int32 TapTap.Common.TapLanguage::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TapLanguage_tA55EE013DD29D62B9C75DBF4697FD74F4CBEF9C5, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// TapTap.Common.TapLogLevel
struct TapLogLevel_tB8607E8A83F8CA4EEBF0172AA968696C0424E8D5 
{
public:
	// System.Int32 TapTap.Common.TapLogLevel::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TapLogLevel_tB8607E8A83F8CA4EEBF0172AA968696C0424E8D5, ___value___2)); }
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


// System.TimeSpan
struct TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 
{
public:
	// System.Int64 System.TimeSpan::_ticks
	int64_t ____ticks_22;

public:
	inline static int32_t get_offset_of__ticks_22() { return static_cast<int32_t>(offsetof(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203, ____ticks_22)); }
	inline int64_t get__ticks_22() const { return ____ticks_22; }
	inline int64_t* get_address_of__ticks_22() { return &____ticks_22; }
	inline void set__ticks_22(int64_t value)
	{
		____ticks_22 = value;
	}
};

struct TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203_StaticFields
{
public:
	// System.TimeSpan System.TimeSpan::Zero
	TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  ___Zero_19;
	// System.TimeSpan System.TimeSpan::MaxValue
	TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  ___MaxValue_20;
	// System.TimeSpan System.TimeSpan::MinValue
	TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  ___MinValue_21;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.TimeSpan::_legacyConfigChecked
	bool ____legacyConfigChecked_23;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.TimeSpan::_legacyMode
	bool ____legacyMode_24;

public:
	inline static int32_t get_offset_of_Zero_19() { return static_cast<int32_t>(offsetof(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203_StaticFields, ___Zero_19)); }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  get_Zero_19() const { return ___Zero_19; }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 * get_address_of_Zero_19() { return &___Zero_19; }
	inline void set_Zero_19(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  value)
	{
		___Zero_19 = value;
	}

	inline static int32_t get_offset_of_MaxValue_20() { return static_cast<int32_t>(offsetof(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203_StaticFields, ___MaxValue_20)); }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  get_MaxValue_20() const { return ___MaxValue_20; }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 * get_address_of_MaxValue_20() { return &___MaxValue_20; }
	inline void set_MaxValue_20(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  value)
	{
		___MaxValue_20 = value;
	}

	inline static int32_t get_offset_of_MinValue_21() { return static_cast<int32_t>(offsetof(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203_StaticFields, ___MinValue_21)); }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  get_MinValue_21() const { return ___MinValue_21; }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 * get_address_of_MinValue_21() { return &___MinValue_21; }
	inline void set_MinValue_21(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  value)
	{
		___MinValue_21 = value;
	}

	inline static int32_t get_offset_of__legacyConfigChecked_23() { return static_cast<int32_t>(offsetof(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203_StaticFields, ____legacyConfigChecked_23)); }
	inline bool get__legacyConfigChecked_23() const { return ____legacyConfigChecked_23; }
	inline bool* get_address_of__legacyConfigChecked_23() { return &____legacyConfigChecked_23; }
	inline void set__legacyConfigChecked_23(bool value)
	{
		____legacyConfigChecked_23 = value;
	}

	inline static int32_t get_offset_of__legacyMode_24() { return static_cast<int32_t>(offsetof(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203_StaticFields, ____legacyMode_24)); }
	inline bool get__legacyMode_24() const { return ____legacyMode_24; }
	inline bool* get_address_of__legacyMode_24() { return &____legacyMode_24; }
	inline void set__legacyMode_24(bool value)
	{
		____legacyMode_24 = value;
	}
};


// LC.Newtonsoft.Json.TypeNameAssemblyFormatHandling
struct TypeNameAssemblyFormatHandling_tB8311F1981EE094B6FDE199590047C60A7239345 
{
public:
	// System.Int32 LC.Newtonsoft.Json.TypeNameAssemblyFormatHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TypeNameAssemblyFormatHandling_tB8311F1981EE094B6FDE199590047C60A7239345, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.TypeNameHandling
struct TypeNameHandling_t14BE34A9DBD00D0318CF27BADB9847E0261E4025 
{
public:
	// System.Int32 LC.Newtonsoft.Json.TypeNameHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TypeNameHandling_t14BE34A9DBD00D0318CF27BADB9847E0261E4025, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
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


// LC.Newtonsoft.Json.JsonReader/State
struct State_tF126B2A98A095D52E62F689AB3B50FFCE11C94C8 
{
public:
	// System.Int32 LC.Newtonsoft.Json.JsonReader/State::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(State_tF126B2A98A095D52E62F689AB3B50FFCE11C94C8, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// LC.Newtonsoft.Json.JsonWriter/State
struct State_t6560F97F34519E9A4127C40EBB408EA79AA64C92 
{
public:
	// System.Int32 LC.Newtonsoft.Json.JsonWriter/State::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(State_t6560F97F34519E9A4127C40EBB408EA79AA64C92, ___value___2)); }
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


// TapTap.Common.Json/Parser/TOKEN
struct TOKEN_t28D8114D537BA8FCFD36457CF0BF8C37B86B20F2 
{
public:
	// System.Int32 TapTap.Common.Json/Parser/TOKEN::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TOKEN_t28D8114D537BA8FCFD36457CF0BF8C37B86B20F2, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Nullable`1<LC.Newtonsoft.Json.DateFormatHandling>
struct Nullable_1_t54B973074A189235F033D5B0500365C31CE1F337 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t54B973074A189235F033D5B0500365C31CE1F337, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t54B973074A189235F033D5B0500365C31CE1F337, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Nullable`1<LC.Newtonsoft.Json.DateParseHandling>
struct Nullable_1_t08E7A00A29C14FCBC977519574552DB2C05BB587 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t08E7A00A29C14FCBC977519574552DB2C05BB587, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t08E7A00A29C14FCBC977519574552DB2C05BB587, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Nullable`1<LC.Newtonsoft.Json.DateTimeZoneHandling>
struct Nullable_1_t767D1EC598BAC10A0E90659F99060E74FA1BD5B8 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t767D1EC598BAC10A0E90659F99060E74FA1BD5B8, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t767D1EC598BAC10A0E90659F99060E74FA1BD5B8, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Nullable`1<LC.Newtonsoft.Json.FloatFormatHandling>
struct Nullable_1_t18508742AB2FF7AEFACF67FAC35F061CBD270E8E 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t18508742AB2FF7AEFACF67FAC35F061CBD270E8E, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t18508742AB2FF7AEFACF67FAC35F061CBD270E8E, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Nullable`1<LC.Newtonsoft.Json.FloatParseHandling>
struct Nullable_1_t77478D7686D2FE4521B588E8C7B86E307DC2AF5C 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t77478D7686D2FE4521B588E8C7B86E307DC2AF5C, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t77478D7686D2FE4521B588E8C7B86E307DC2AF5C, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Nullable`1<LC.Newtonsoft.Json.Formatting>
struct Nullable_1_t2F476D5976937795CC50A8B19FE43301C48709A4 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t2F476D5976937795CC50A8B19FE43301C48709A4, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t2F476D5976937795CC50A8B19FE43301C48709A4, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Nullable`1<LC.Newtonsoft.Json.StringEscapeHandling>
struct Nullable_1_t467884074E3014FCC85712886F7DC7C52D07F2CD 
{
public:
	// T System.Nullable`1::value
	int32_t ___value_0;
	// System.Boolean System.Nullable`1::has_value
	bool ___has_value_1;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(Nullable_1_t467884074E3014FCC85712886F7DC7C52D07F2CD, ___value_0)); }
	inline int32_t get_value_0() const { return ___value_0; }
	inline int32_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(int32_t value)
	{
		___value_0 = value;
	}

	inline static int32_t get_offset_of_has_value_1() { return static_cast<int32_t>(offsetof(Nullable_1_t467884074E3014FCC85712886F7DC7C52D07F2CD, ___has_value_1)); }
	inline bool get_has_value_1() const { return ___has_value_1; }
	inline bool* get_address_of_has_value_1() { return &___has_value_1; }
	inline void set_has_value_1(bool value)
	{
		___has_value_1 = value;
	}
};


// System.Threading.Tasks.Task`1<System.Object>
struct Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17  : public Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60
{
public:
	// TResult System.Threading.Tasks.Task`1::m_result
	RuntimeObject * ___m_result_40;

public:
	inline static int32_t get_offset_of_m_result_40() { return static_cast<int32_t>(offsetof(Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17, ___m_result_40)); }
	inline RuntimeObject * get_m_result_40() const { return ___m_result_40; }
	inline RuntimeObject ** get_address_of_m_result_40() { return &___m_result_40; }
	inline void set_m_result_40(RuntimeObject * value)
	{
		___m_result_40 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_result_40), (void*)value);
	}
};

struct Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17_StaticFields
{
public:
	// System.Threading.Tasks.TaskFactory`1<TResult> System.Threading.Tasks.Task`1::s_Factory
	TaskFactory_1_t16A95DD17BBA3D00F0A85C5077BB248421EF3A55 * ___s_Factory_41;
	// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<TResult>> System.Threading.Tasks.Task`1::TaskWhenAnyCast
	Func_2_t44F36790F9746FCE5ABFDE6205B6020B2578F6DD * ___TaskWhenAnyCast_42;

public:
	inline static int32_t get_offset_of_s_Factory_41() { return static_cast<int32_t>(offsetof(Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17_StaticFields, ___s_Factory_41)); }
	inline TaskFactory_1_t16A95DD17BBA3D00F0A85C5077BB248421EF3A55 * get_s_Factory_41() const { return ___s_Factory_41; }
	inline TaskFactory_1_t16A95DD17BBA3D00F0A85C5077BB248421EF3A55 ** get_address_of_s_Factory_41() { return &___s_Factory_41; }
	inline void set_s_Factory_41(TaskFactory_1_t16A95DD17BBA3D00F0A85C5077BB248421EF3A55 * value)
	{
		___s_Factory_41 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Factory_41), (void*)value);
	}

	inline static int32_t get_offset_of_TaskWhenAnyCast_42() { return static_cast<int32_t>(offsetof(Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17_StaticFields, ___TaskWhenAnyCast_42)); }
	inline Func_2_t44F36790F9746FCE5ABFDE6205B6020B2578F6DD * get_TaskWhenAnyCast_42() const { return ___TaskWhenAnyCast_42; }
	inline Func_2_t44F36790F9746FCE5ABFDE6205B6020B2578F6DD ** get_address_of_TaskWhenAnyCast_42() { return &___TaskWhenAnyCast_42; }
	inline void set_TaskWhenAnyCast_42(Func_2_t44F36790F9746FCE5ABFDE6205B6020B2578F6DD * value)
	{
		___TaskWhenAnyCast_42 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TaskWhenAnyCast_42), (void*)value);
	}
};


// System.Threading.Tasks.Task`1<TapTap.Common.Result>
struct Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30  : public Task_t804B25CFE3FC13AAEE16C8FA3BF52513F2A8DB60
{
public:
	// TResult System.Threading.Tasks.Task`1::m_result
	Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * ___m_result_40;

public:
	inline static int32_t get_offset_of_m_result_40() { return static_cast<int32_t>(offsetof(Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30, ___m_result_40)); }
	inline Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * get_m_result_40() const { return ___m_result_40; }
	inline Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 ** get_address_of_m_result_40() { return &___m_result_40; }
	inline void set_m_result_40(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * value)
	{
		___m_result_40 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_result_40), (void*)value);
	}
};

struct Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30_StaticFields
{
public:
	// System.Threading.Tasks.TaskFactory`1<TResult> System.Threading.Tasks.Task`1::s_Factory
	TaskFactory_1_t4EE5CA7CD1BE735B38CC1FC0E5782C398145358D * ___s_Factory_41;
	// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<TResult>> System.Threading.Tasks.Task`1::TaskWhenAnyCast
	Func_2_tDF7F105B70C3514ED1736D5838BDF9616BF53530 * ___TaskWhenAnyCast_42;

public:
	inline static int32_t get_offset_of_s_Factory_41() { return static_cast<int32_t>(offsetof(Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30_StaticFields, ___s_Factory_41)); }
	inline TaskFactory_1_t4EE5CA7CD1BE735B38CC1FC0E5782C398145358D * get_s_Factory_41() const { return ___s_Factory_41; }
	inline TaskFactory_1_t4EE5CA7CD1BE735B38CC1FC0E5782C398145358D ** get_address_of_s_Factory_41() { return &___s_Factory_41; }
	inline void set_s_Factory_41(TaskFactory_1_t4EE5CA7CD1BE735B38CC1FC0E5782C398145358D * value)
	{
		___s_Factory_41 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Factory_41), (void*)value);
	}

	inline static int32_t get_offset_of_TaskWhenAnyCast_42() { return static_cast<int32_t>(offsetof(Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30_StaticFields, ___TaskWhenAnyCast_42)); }
	inline Func_2_tDF7F105B70C3514ED1736D5838BDF9616BF53530 * get_TaskWhenAnyCast_42() const { return ___TaskWhenAnyCast_42; }
	inline Func_2_tDF7F105B70C3514ED1736D5838BDF9616BF53530 ** get_address_of_TaskWhenAnyCast_42() { return &___TaskWhenAnyCast_42; }
	inline void set_TaskWhenAnyCast_42(Func_2_tDF7F105B70C3514ED1736D5838BDF9616BF53530 * value)
	{
		___TaskWhenAnyCast_42 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TaskWhenAnyCast_42), (void*)value);
	}
};


// TapTap.Common.BridgeCallback
struct BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707  : public AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF
{
public:
	// System.Action`1<TapTap.Common.Result> TapTap.Common.BridgeCallback::callback
	Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ___callback_4;

public:
	inline static int32_t get_offset_of_callback_4() { return static_cast<int32_t>(offsetof(BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707, ___callback_4)); }
	inline Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * get_callback_4() const { return ___callback_4; }
	inline Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 ** get_address_of_callback_4() { return &___callback_4; }
	inline void set_callback_4(Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * value)
	{
		___callback_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callback_4), (void*)value);
	}
};


// System.Security.Cryptography.CryptoStream
struct CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66  : public Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB
{
public:
	// System.IO.Stream System.Security.Cryptography.CryptoStream::_stream
	Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ____stream_5;
	// System.Security.Cryptography.ICryptoTransform System.Security.Cryptography.CryptoStream::_Transform
	RuntimeObject* ____Transform_6;
	// System.Byte[] System.Security.Cryptography.CryptoStream::_InputBuffer
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____InputBuffer_7;
	// System.Int32 System.Security.Cryptography.CryptoStream::_InputBufferIndex
	int32_t ____InputBufferIndex_8;
	// System.Int32 System.Security.Cryptography.CryptoStream::_InputBlockSize
	int32_t ____InputBlockSize_9;
	// System.Byte[] System.Security.Cryptography.CryptoStream::_OutputBuffer
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____OutputBuffer_10;
	// System.Int32 System.Security.Cryptography.CryptoStream::_OutputBufferIndex
	int32_t ____OutputBufferIndex_11;
	// System.Int32 System.Security.Cryptography.CryptoStream::_OutputBlockSize
	int32_t ____OutputBlockSize_12;
	// System.Security.Cryptography.CryptoStreamMode System.Security.Cryptography.CryptoStream::_transformMode
	int32_t ____transformMode_13;
	// System.Boolean System.Security.Cryptography.CryptoStream::_canRead
	bool ____canRead_14;
	// System.Boolean System.Security.Cryptography.CryptoStream::_canWrite
	bool ____canWrite_15;
	// System.Boolean System.Security.Cryptography.CryptoStream::_finalBlockTransformed
	bool ____finalBlockTransformed_16;

public:
	inline static int32_t get_offset_of__stream_5() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____stream_5)); }
	inline Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * get__stream_5() const { return ____stream_5; }
	inline Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB ** get_address_of__stream_5() { return &____stream_5; }
	inline void set__stream_5(Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * value)
	{
		____stream_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stream_5), (void*)value);
	}

	inline static int32_t get_offset_of__Transform_6() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____Transform_6)); }
	inline RuntimeObject* get__Transform_6() const { return ____Transform_6; }
	inline RuntimeObject** get_address_of__Transform_6() { return &____Transform_6; }
	inline void set__Transform_6(RuntimeObject* value)
	{
		____Transform_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____Transform_6), (void*)value);
	}

	inline static int32_t get_offset_of__InputBuffer_7() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____InputBuffer_7)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get__InputBuffer_7() const { return ____InputBuffer_7; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of__InputBuffer_7() { return &____InputBuffer_7; }
	inline void set__InputBuffer_7(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		____InputBuffer_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____InputBuffer_7), (void*)value);
	}

	inline static int32_t get_offset_of__InputBufferIndex_8() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____InputBufferIndex_8)); }
	inline int32_t get__InputBufferIndex_8() const { return ____InputBufferIndex_8; }
	inline int32_t* get_address_of__InputBufferIndex_8() { return &____InputBufferIndex_8; }
	inline void set__InputBufferIndex_8(int32_t value)
	{
		____InputBufferIndex_8 = value;
	}

	inline static int32_t get_offset_of__InputBlockSize_9() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____InputBlockSize_9)); }
	inline int32_t get__InputBlockSize_9() const { return ____InputBlockSize_9; }
	inline int32_t* get_address_of__InputBlockSize_9() { return &____InputBlockSize_9; }
	inline void set__InputBlockSize_9(int32_t value)
	{
		____InputBlockSize_9 = value;
	}

	inline static int32_t get_offset_of__OutputBuffer_10() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____OutputBuffer_10)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get__OutputBuffer_10() const { return ____OutputBuffer_10; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of__OutputBuffer_10() { return &____OutputBuffer_10; }
	inline void set__OutputBuffer_10(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		____OutputBuffer_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____OutputBuffer_10), (void*)value);
	}

	inline static int32_t get_offset_of__OutputBufferIndex_11() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____OutputBufferIndex_11)); }
	inline int32_t get__OutputBufferIndex_11() const { return ____OutputBufferIndex_11; }
	inline int32_t* get_address_of__OutputBufferIndex_11() { return &____OutputBufferIndex_11; }
	inline void set__OutputBufferIndex_11(int32_t value)
	{
		____OutputBufferIndex_11 = value;
	}

	inline static int32_t get_offset_of__OutputBlockSize_12() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____OutputBlockSize_12)); }
	inline int32_t get__OutputBlockSize_12() const { return ____OutputBlockSize_12; }
	inline int32_t* get_address_of__OutputBlockSize_12() { return &____OutputBlockSize_12; }
	inline void set__OutputBlockSize_12(int32_t value)
	{
		____OutputBlockSize_12 = value;
	}

	inline static int32_t get_offset_of__transformMode_13() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____transformMode_13)); }
	inline int32_t get__transformMode_13() const { return ____transformMode_13; }
	inline int32_t* get_address_of__transformMode_13() { return &____transformMode_13; }
	inline void set__transformMode_13(int32_t value)
	{
		____transformMode_13 = value;
	}

	inline static int32_t get_offset_of__canRead_14() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____canRead_14)); }
	inline bool get__canRead_14() const { return ____canRead_14; }
	inline bool* get_address_of__canRead_14() { return &____canRead_14; }
	inline void set__canRead_14(bool value)
	{
		____canRead_14 = value;
	}

	inline static int32_t get_offset_of__canWrite_15() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____canWrite_15)); }
	inline bool get__canWrite_15() const { return ____canWrite_15; }
	inline bool* get_address_of__canWrite_15() { return &____canWrite_15; }
	inline void set__canWrite_15(bool value)
	{
		____canWrite_15 = value;
	}

	inline static int32_t get_offset_of__finalBlockTransformed_16() { return static_cast<int32_t>(offsetof(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66, ____finalBlockTransformed_16)); }
	inline bool get__finalBlockTransformed_16() const { return ____finalBlockTransformed_16; }
	inline bool* get_address_of__finalBlockTransformed_16() { return &____finalBlockTransformed_16; }
	inline void set__finalBlockTransformed_16(bool value)
	{
		____finalBlockTransformed_16 = value;
	}
};


// System.Net.Http.HttpClient
struct HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20  : public HttpMessageInvoker_tB200A37492A5CB8B8FB6E89580AA47481225D02F
{
public:
	// System.Uri System.Net.Http.HttpClient::base_address
	Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * ___base_address_3;
	// System.Threading.CancellationTokenSource System.Net.Http.HttpClient::cts
	CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * ___cts_4;
	// System.Boolean System.Net.Http.HttpClient::disposed
	bool ___disposed_5;
	// System.Net.Http.Headers.HttpRequestHeaders System.Net.Http.HttpClient::headers
	HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * ___headers_6;
	// System.Int64 System.Net.Http.HttpClient::buffer_size
	int64_t ___buffer_size_7;
	// System.TimeSpan System.Net.Http.HttpClient::timeout
	TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  ___timeout_8;

public:
	inline static int32_t get_offset_of_base_address_3() { return static_cast<int32_t>(offsetof(HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20, ___base_address_3)); }
	inline Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * get_base_address_3() const { return ___base_address_3; }
	inline Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 ** get_address_of_base_address_3() { return &___base_address_3; }
	inline void set_base_address_3(Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * value)
	{
		___base_address_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___base_address_3), (void*)value);
	}

	inline static int32_t get_offset_of_cts_4() { return static_cast<int32_t>(offsetof(HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20, ___cts_4)); }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * get_cts_4() const { return ___cts_4; }
	inline CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 ** get_address_of_cts_4() { return &___cts_4; }
	inline void set_cts_4(CancellationTokenSource_t78B989179DE23EDD36F870FFEE20A15D6D3C65B3 * value)
	{
		___cts_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___cts_4), (void*)value);
	}

	inline static int32_t get_offset_of_disposed_5() { return static_cast<int32_t>(offsetof(HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20, ___disposed_5)); }
	inline bool get_disposed_5() const { return ___disposed_5; }
	inline bool* get_address_of_disposed_5() { return &___disposed_5; }
	inline void set_disposed_5(bool value)
	{
		___disposed_5 = value;
	}

	inline static int32_t get_offset_of_headers_6() { return static_cast<int32_t>(offsetof(HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20, ___headers_6)); }
	inline HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * get_headers_6() const { return ___headers_6; }
	inline HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 ** get_address_of_headers_6() { return &___headers_6; }
	inline void set_headers_6(HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * value)
	{
		___headers_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___headers_6), (void*)value);
	}

	inline static int32_t get_offset_of_buffer_size_7() { return static_cast<int32_t>(offsetof(HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20, ___buffer_size_7)); }
	inline int64_t get_buffer_size_7() const { return ___buffer_size_7; }
	inline int64_t* get_address_of_buffer_size_7() { return &___buffer_size_7; }
	inline void set_buffer_size_7(int64_t value)
	{
		___buffer_size_7 = value;
	}

	inline static int32_t get_offset_of_timeout_8() { return static_cast<int32_t>(offsetof(HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20, ___timeout_8)); }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  get_timeout_8() const { return ___timeout_8; }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 * get_address_of_timeout_8() { return &___timeout_8; }
	inline void set_timeout_8(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  value)
	{
		___timeout_8 = value;
	}
};

struct HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20_StaticFields
{
public:
	// System.TimeSpan System.Net.Http.HttpClient::TimeoutDefault
	TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  ___TimeoutDefault_2;

public:
	inline static int32_t get_offset_of_TimeoutDefault_2() { return static_cast<int32_t>(offsetof(HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20_StaticFields, ___TimeoutDefault_2)); }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  get_TimeoutDefault_2() const { return ___TimeoutDefault_2; }
	inline TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203 * get_address_of_TimeoutDefault_2() { return &___TimeoutDefault_2; }
	inline void set_TimeoutDefault_2(TimeSpan_t4F6A0E13E703B65365CFCAB58E05EE0AF3EE6203  value)
	{
		___TimeoutDefault_2 = value;
	}
};


// System.Net.Http.Headers.HttpHeaders
struct HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2  : public RuntimeObject
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.Net.Http.Headers.HttpHeaders/HeaderBucket> System.Net.Http.Headers.HttpHeaders::headers
	Dictionary_2_t96671B7CC8F3C2EEB688C956C4404C1B39FFEADA * ___headers_1;
	// System.Net.Http.Headers.HttpHeaderKind System.Net.Http.Headers.HttpHeaders::HeaderKind
	int32_t ___HeaderKind_2;
	// System.Nullable`1<System.Boolean> System.Net.Http.Headers.HttpHeaders::connectionclose
	Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  ___connectionclose_3;
	// System.Nullable`1<System.Boolean> System.Net.Http.Headers.HttpHeaders::transferEncodingChunked
	Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  ___transferEncodingChunked_4;

public:
	inline static int32_t get_offset_of_headers_1() { return static_cast<int32_t>(offsetof(HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2, ___headers_1)); }
	inline Dictionary_2_t96671B7CC8F3C2EEB688C956C4404C1B39FFEADA * get_headers_1() const { return ___headers_1; }
	inline Dictionary_2_t96671B7CC8F3C2EEB688C956C4404C1B39FFEADA ** get_address_of_headers_1() { return &___headers_1; }
	inline void set_headers_1(Dictionary_2_t96671B7CC8F3C2EEB688C956C4404C1B39FFEADA * value)
	{
		___headers_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___headers_1), (void*)value);
	}

	inline static int32_t get_offset_of_HeaderKind_2() { return static_cast<int32_t>(offsetof(HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2, ___HeaderKind_2)); }
	inline int32_t get_HeaderKind_2() const { return ___HeaderKind_2; }
	inline int32_t* get_address_of_HeaderKind_2() { return &___HeaderKind_2; }
	inline void set_HeaderKind_2(int32_t value)
	{
		___HeaderKind_2 = value;
	}

	inline static int32_t get_offset_of_connectionclose_3() { return static_cast<int32_t>(offsetof(HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2, ___connectionclose_3)); }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  get_connectionclose_3() const { return ___connectionclose_3; }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3 * get_address_of_connectionclose_3() { return &___connectionclose_3; }
	inline void set_connectionclose_3(Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  value)
	{
		___connectionclose_3 = value;
	}

	inline static int32_t get_offset_of_transferEncodingChunked_4() { return static_cast<int32_t>(offsetof(HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2, ___transferEncodingChunked_4)); }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  get_transferEncodingChunked_4() const { return ___transferEncodingChunked_4; }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3 * get_address_of_transferEncodingChunked_4() { return &___transferEncodingChunked_4; }
	inline void set_transferEncodingChunked_4(Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  value)
	{
		___transferEncodingChunked_4 = value;
	}
};

struct HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.Net.Http.Headers.HeaderInfo> System.Net.Http.Headers.HttpHeaders::known_headers
	Dictionary_2_t8757406F1F2B87E86FFC8EDBDB9ACA8BF119549B * ___known_headers_0;

public:
	inline static int32_t get_offset_of_known_headers_0() { return static_cast<int32_t>(offsetof(HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2_StaticFields, ___known_headers_0)); }
	inline Dictionary_2_t8757406F1F2B87E86FFC8EDBDB9ACA8BF119549B * get_known_headers_0() const { return ___known_headers_0; }
	inline Dictionary_2_t8757406F1F2B87E86FFC8EDBDB9ACA8BF119549B ** get_address_of_known_headers_0() { return &___known_headers_0; }
	inline void set_known_headers_0(Dictionary_2_t8757406F1F2B87E86FFC8EDBDB9ACA8BF119549B * value)
	{
		___known_headers_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___known_headers_0), (void*)value);
	}
};


// System.Net.Http.HttpResponseMessage
struct HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752  : public RuntimeObject
{
public:
	// System.Net.Http.Headers.HttpResponseHeaders System.Net.Http.HttpResponseMessage::headers
	HttpResponseHeaders_t15DADCD69839D24E4336D8D0D62BEED17A6DC8B6 * ___headers_0;
	// System.String System.Net.Http.HttpResponseMessage::reasonPhrase
	String_t* ___reasonPhrase_1;
	// System.Net.HttpStatusCode System.Net.Http.HttpResponseMessage::statusCode
	int32_t ___statusCode_2;
	// System.Version System.Net.Http.HttpResponseMessage::version
	Version_tBDAEDED25425A1D09910468B8BD1759115646E3C * ___version_3;
	// System.Boolean System.Net.Http.HttpResponseMessage::disposed
	bool ___disposed_4;
	// System.Net.Http.HttpContent System.Net.Http.HttpResponseMessage::<Content>k__BackingField
	HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * ___U3CContentU3Ek__BackingField_5;
	// System.Net.Http.HttpRequestMessage System.Net.Http.HttpResponseMessage::<RequestMessage>k__BackingField
	HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * ___U3CRequestMessageU3Ek__BackingField_6;

public:
	inline static int32_t get_offset_of_headers_0() { return static_cast<int32_t>(offsetof(HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752, ___headers_0)); }
	inline HttpResponseHeaders_t15DADCD69839D24E4336D8D0D62BEED17A6DC8B6 * get_headers_0() const { return ___headers_0; }
	inline HttpResponseHeaders_t15DADCD69839D24E4336D8D0D62BEED17A6DC8B6 ** get_address_of_headers_0() { return &___headers_0; }
	inline void set_headers_0(HttpResponseHeaders_t15DADCD69839D24E4336D8D0D62BEED17A6DC8B6 * value)
	{
		___headers_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___headers_0), (void*)value);
	}

	inline static int32_t get_offset_of_reasonPhrase_1() { return static_cast<int32_t>(offsetof(HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752, ___reasonPhrase_1)); }
	inline String_t* get_reasonPhrase_1() const { return ___reasonPhrase_1; }
	inline String_t** get_address_of_reasonPhrase_1() { return &___reasonPhrase_1; }
	inline void set_reasonPhrase_1(String_t* value)
	{
		___reasonPhrase_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___reasonPhrase_1), (void*)value);
	}

	inline static int32_t get_offset_of_statusCode_2() { return static_cast<int32_t>(offsetof(HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752, ___statusCode_2)); }
	inline int32_t get_statusCode_2() const { return ___statusCode_2; }
	inline int32_t* get_address_of_statusCode_2() { return &___statusCode_2; }
	inline void set_statusCode_2(int32_t value)
	{
		___statusCode_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752, ___version_3)); }
	inline Version_tBDAEDED25425A1D09910468B8BD1759115646E3C * get_version_3() const { return ___version_3; }
	inline Version_tBDAEDED25425A1D09910468B8BD1759115646E3C ** get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(Version_tBDAEDED25425A1D09910468B8BD1759115646E3C * value)
	{
		___version_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___version_3), (void*)value);
	}

	inline static int32_t get_offset_of_disposed_4() { return static_cast<int32_t>(offsetof(HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752, ___disposed_4)); }
	inline bool get_disposed_4() const { return ___disposed_4; }
	inline bool* get_address_of_disposed_4() { return &___disposed_4; }
	inline void set_disposed_4(bool value)
	{
		___disposed_4 = value;
	}

	inline static int32_t get_offset_of_U3CContentU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752, ___U3CContentU3Ek__BackingField_5)); }
	inline HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * get_U3CContentU3Ek__BackingField_5() const { return ___U3CContentU3Ek__BackingField_5; }
	inline HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 ** get_address_of_U3CContentU3Ek__BackingField_5() { return &___U3CContentU3Ek__BackingField_5; }
	inline void set_U3CContentU3Ek__BackingField_5(HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * value)
	{
		___U3CContentU3Ek__BackingField_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CContentU3Ek__BackingField_5), (void*)value);
	}

	inline static int32_t get_offset_of_U3CRequestMessageU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752, ___U3CRequestMessageU3Ek__BackingField_6)); }
	inline HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * get_U3CRequestMessageU3Ek__BackingField_6() const { return ___U3CRequestMessageU3Ek__BackingField_6; }
	inline HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F ** get_address_of_U3CRequestMessageU3Ek__BackingField_6() { return &___U3CRequestMessageU3Ek__BackingField_6; }
	inline void set_U3CRequestMessageU3Ek__BackingField_6(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * value)
	{
		___U3CRequestMessageU3Ek__BackingField_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CRequestMessageU3Ek__BackingField_6), (void*)value);
	}
};


// LC.Newtonsoft.Json.JsonPosition
struct JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2 
{
public:
	// LC.Newtonsoft.Json.JsonContainerType LC.Newtonsoft.Json.JsonPosition::Type
	int32_t ___Type_1;
	// System.Int32 LC.Newtonsoft.Json.JsonPosition::Position
	int32_t ___Position_2;
	// System.String LC.Newtonsoft.Json.JsonPosition::PropertyName
	String_t* ___PropertyName_3;
	// System.Boolean LC.Newtonsoft.Json.JsonPosition::HasIndex
	bool ___HasIndex_4;

public:
	inline static int32_t get_offset_of_Type_1() { return static_cast<int32_t>(offsetof(JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2, ___Type_1)); }
	inline int32_t get_Type_1() const { return ___Type_1; }
	inline int32_t* get_address_of_Type_1() { return &___Type_1; }
	inline void set_Type_1(int32_t value)
	{
		___Type_1 = value;
	}

	inline static int32_t get_offset_of_Position_2() { return static_cast<int32_t>(offsetof(JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2, ___Position_2)); }
	inline int32_t get_Position_2() const { return ___Position_2; }
	inline int32_t* get_address_of_Position_2() { return &___Position_2; }
	inline void set_Position_2(int32_t value)
	{
		___Position_2 = value;
	}

	inline static int32_t get_offset_of_PropertyName_3() { return static_cast<int32_t>(offsetof(JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2, ___PropertyName_3)); }
	inline String_t* get_PropertyName_3() const { return ___PropertyName_3; }
	inline String_t** get_address_of_PropertyName_3() { return &___PropertyName_3; }
	inline void set_PropertyName_3(String_t* value)
	{
		___PropertyName_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___PropertyName_3), (void*)value);
	}

	inline static int32_t get_offset_of_HasIndex_4() { return static_cast<int32_t>(offsetof(JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2, ___HasIndex_4)); }
	inline bool get_HasIndex_4() const { return ___HasIndex_4; }
	inline bool* get_address_of_HasIndex_4() { return &___HasIndex_4; }
	inline void set_HasIndex_4(bool value)
	{
		___HasIndex_4 = value;
	}
};

struct JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2_StaticFields
{
public:
	// System.Char[] LC.Newtonsoft.Json.JsonPosition::SpecialCharacters
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___SpecialCharacters_0;

public:
	inline static int32_t get_offset_of_SpecialCharacters_0() { return static_cast<int32_t>(offsetof(JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2_StaticFields, ___SpecialCharacters_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_SpecialCharacters_0() const { return ___SpecialCharacters_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_SpecialCharacters_0() { return &___SpecialCharacters_0; }
	inline void set_SpecialCharacters_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___SpecialCharacters_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___SpecialCharacters_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of LC.Newtonsoft.Json.JsonPosition
struct JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2_marshaled_pinvoke
{
	int32_t ___Type_1;
	int32_t ___Position_2;
	char* ___PropertyName_3;
	int32_t ___HasIndex_4;
};
// Native definition for COM marshalling of LC.Newtonsoft.Json.JsonPosition
struct JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2_marshaled_com
{
	int32_t ___Type_1;
	int32_t ___Position_2;
	Il2CppChar* ___PropertyName_3;
	int32_t ___HasIndex_4;
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

// System.Runtime.Serialization.StreamingContext
struct StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505 
{
public:
	// System.Object System.Runtime.Serialization.StreamingContext::m_additionalContext
	RuntimeObject * ___m_additionalContext_0;
	// System.Runtime.Serialization.StreamingContextStates System.Runtime.Serialization.StreamingContext::m_state
	int32_t ___m_state_1;

public:
	inline static int32_t get_offset_of_m_additionalContext_0() { return static_cast<int32_t>(offsetof(StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505, ___m_additionalContext_0)); }
	inline RuntimeObject * get_m_additionalContext_0() const { return ___m_additionalContext_0; }
	inline RuntimeObject ** get_address_of_m_additionalContext_0() { return &___m_additionalContext_0; }
	inline void set_m_additionalContext_0(RuntimeObject * value)
	{
		___m_additionalContext_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_additionalContext_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_state_1() { return static_cast<int32_t>(offsetof(StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505, ___m_state_1)); }
	inline int32_t get_m_state_1() const { return ___m_state_1; }
	inline int32_t* get_address_of_m_state_1() { return &___m_state_1; }
	inline void set_m_state_1(int32_t value)
	{
		___m_state_1 = value;
	}
};

// Native definition for P/Invoke marshalling of System.Runtime.Serialization.StreamingContext
struct StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505_marshaled_pinvoke
{
	Il2CppIUnknown* ___m_additionalContext_0;
	int32_t ___m_state_1;
};
// Native definition for COM marshalling of System.Runtime.Serialization.StreamingContext
struct StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505_marshaled_com
{
	Il2CppIUnknown* ___m_additionalContext_0;
	int32_t ___m_state_1;
};

// System.Security.Cryptography.SymmetricAlgorithm
struct SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754  : public RuntimeObject
{
public:
	// System.Int32 System.Security.Cryptography.SymmetricAlgorithm::BlockSizeValue
	int32_t ___BlockSizeValue_0;
	// System.Int32 System.Security.Cryptography.SymmetricAlgorithm::FeedbackSizeValue
	int32_t ___FeedbackSizeValue_1;
	// System.Byte[] System.Security.Cryptography.SymmetricAlgorithm::IVValue
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___IVValue_2;
	// System.Byte[] System.Security.Cryptography.SymmetricAlgorithm::KeyValue
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___KeyValue_3;
	// System.Security.Cryptography.KeySizes[] System.Security.Cryptography.SymmetricAlgorithm::LegalBlockSizesValue
	KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* ___LegalBlockSizesValue_4;
	// System.Security.Cryptography.KeySizes[] System.Security.Cryptography.SymmetricAlgorithm::LegalKeySizesValue
	KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* ___LegalKeySizesValue_5;
	// System.Int32 System.Security.Cryptography.SymmetricAlgorithm::KeySizeValue
	int32_t ___KeySizeValue_6;
	// System.Security.Cryptography.CipherMode System.Security.Cryptography.SymmetricAlgorithm::ModeValue
	int32_t ___ModeValue_7;
	// System.Security.Cryptography.PaddingMode System.Security.Cryptography.SymmetricAlgorithm::PaddingValue
	int32_t ___PaddingValue_8;

public:
	inline static int32_t get_offset_of_BlockSizeValue_0() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___BlockSizeValue_0)); }
	inline int32_t get_BlockSizeValue_0() const { return ___BlockSizeValue_0; }
	inline int32_t* get_address_of_BlockSizeValue_0() { return &___BlockSizeValue_0; }
	inline void set_BlockSizeValue_0(int32_t value)
	{
		___BlockSizeValue_0 = value;
	}

	inline static int32_t get_offset_of_FeedbackSizeValue_1() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___FeedbackSizeValue_1)); }
	inline int32_t get_FeedbackSizeValue_1() const { return ___FeedbackSizeValue_1; }
	inline int32_t* get_address_of_FeedbackSizeValue_1() { return &___FeedbackSizeValue_1; }
	inline void set_FeedbackSizeValue_1(int32_t value)
	{
		___FeedbackSizeValue_1 = value;
	}

	inline static int32_t get_offset_of_IVValue_2() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___IVValue_2)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_IVValue_2() const { return ___IVValue_2; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_IVValue_2() { return &___IVValue_2; }
	inline void set_IVValue_2(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___IVValue_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___IVValue_2), (void*)value);
	}

	inline static int32_t get_offset_of_KeyValue_3() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___KeyValue_3)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_KeyValue_3() const { return ___KeyValue_3; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_KeyValue_3() { return &___KeyValue_3; }
	inline void set_KeyValue_3(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___KeyValue_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___KeyValue_3), (void*)value);
	}

	inline static int32_t get_offset_of_LegalBlockSizesValue_4() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___LegalBlockSizesValue_4)); }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* get_LegalBlockSizesValue_4() const { return ___LegalBlockSizesValue_4; }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499** get_address_of_LegalBlockSizesValue_4() { return &___LegalBlockSizesValue_4; }
	inline void set_LegalBlockSizesValue_4(KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* value)
	{
		___LegalBlockSizesValue_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___LegalBlockSizesValue_4), (void*)value);
	}

	inline static int32_t get_offset_of_LegalKeySizesValue_5() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___LegalKeySizesValue_5)); }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* get_LegalKeySizesValue_5() const { return ___LegalKeySizesValue_5; }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499** get_address_of_LegalKeySizesValue_5() { return &___LegalKeySizesValue_5; }
	inline void set_LegalKeySizesValue_5(KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* value)
	{
		___LegalKeySizesValue_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___LegalKeySizesValue_5), (void*)value);
	}

	inline static int32_t get_offset_of_KeySizeValue_6() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___KeySizeValue_6)); }
	inline int32_t get_KeySizeValue_6() const { return ___KeySizeValue_6; }
	inline int32_t* get_address_of_KeySizeValue_6() { return &___KeySizeValue_6; }
	inline void set_KeySizeValue_6(int32_t value)
	{
		___KeySizeValue_6 = value;
	}

	inline static int32_t get_offset_of_ModeValue_7() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___ModeValue_7)); }
	inline int32_t get_ModeValue_7() const { return ___ModeValue_7; }
	inline int32_t* get_address_of_ModeValue_7() { return &___ModeValue_7; }
	inline void set_ModeValue_7(int32_t value)
	{
		___ModeValue_7 = value;
	}

	inline static int32_t get_offset_of_PaddingValue_8() { return static_cast<int32_t>(offsetof(SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754, ___PaddingValue_8)); }
	inline int32_t get_PaddingValue_8() const { return ___PaddingValue_8; }
	inline int32_t* get_address_of_PaddingValue_8() { return &___PaddingValue_8; }
	inline void set_PaddingValue_8(int32_t value)
	{
		___PaddingValue_8 = value;
	}
};


// TapTap.Common.TapException
struct TapException_tD607DF79F8107AB2AF0C8047B0EC40C8056FFAEB  : public Exception_t
{
public:
	// System.Int32 TapTap.Common.TapException::code
	int32_t ___code_17;
	// System.String TapTap.Common.TapException::message
	String_t* ___message_18;

public:
	inline static int32_t get_offset_of_code_17() { return static_cast<int32_t>(offsetof(TapException_tD607DF79F8107AB2AF0C8047B0EC40C8056FFAEB, ___code_17)); }
	inline int32_t get_code_17() const { return ___code_17; }
	inline int32_t* get_address_of_code_17() { return &___code_17; }
	inline void set_code_17(int32_t value)
	{
		___code_17 = value;
	}

	inline static int32_t get_offset_of_message_18() { return static_cast<int32_t>(offsetof(TapException_tD607DF79F8107AB2AF0C8047B0EC40C8056FFAEB, ___message_18)); }
	inline String_t* get_message_18() const { return ___message_18; }
	inline String_t** get_address_of_message_18() { return &___message_18; }
	inline void set_message_18(String_t* value)
	{
		___message_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___message_18), (void*)value);
	}
};


// TapTap.Common.TapLocalizeManager
struct TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB  : public RuntimeObject
{
public:
	// TapTap.Common.TapLanguage TapTap.Common.TapLocalizeManager::_language
	int32_t ____language_2;
	// System.Boolean TapTap.Common.TapLocalizeManager::_regionIsCn
	bool ____regionIsCn_3;

public:
	inline static int32_t get_offset_of__language_2() { return static_cast<int32_t>(offsetof(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB, ____language_2)); }
	inline int32_t get__language_2() const { return ____language_2; }
	inline int32_t* get_address_of__language_2() { return &____language_2; }
	inline void set__language_2(int32_t value)
	{
		____language_2 = value;
	}

	inline static int32_t get_offset_of__regionIsCn_3() { return static_cast<int32_t>(offsetof(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB, ____regionIsCn_3)); }
	inline bool get__regionIsCn_3() const { return ____regionIsCn_3; }
	inline bool* get_address_of__regionIsCn_3() { return &____regionIsCn_3; }
	inline void set__regionIsCn_3(bool value)
	{
		____regionIsCn_3 = value;
	}
};

struct TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields
{
public:
	// TapTap.Common.TapLocalizeManager modreq(System.Runtime.CompilerServices.IsVolatile) TapTap.Common.TapLocalizeManager::_instance
	TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * ____instance_0;
	// System.Object TapTap.Common.TapLocalizeManager::ObjLock
	RuntimeObject * ___ObjLock_1;

public:
	inline static int32_t get_offset_of__instance_0() { return static_cast<int32_t>(offsetof(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields, ____instance_0)); }
	inline TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * get__instance_0() const { return ____instance_0; }
	inline TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB ** get_address_of__instance_0() { return &____instance_0; }
	inline void set__instance_0(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * value)
	{
		____instance_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____instance_0), (void*)value);
	}

	inline static int32_t get_offset_of_ObjLock_1() { return static_cast<int32_t>(offsetof(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields, ___ObjLock_1)); }
	inline RuntimeObject * get_ObjLock_1() const { return ___ObjLock_1; }
	inline RuntimeObject ** get_address_of_ObjLock_1() { return &___ObjLock_1; }
	inline void set_ObjLock_1(RuntimeObject * value)
	{
		___ObjLock_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ObjLock_1), (void*)value);
	}
};


// System.Type
struct Type_t  : public MemberInfo_t
{
public:
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ____impl_9;

public:
	inline static int32_t get_offset_of__impl_9() { return static_cast<int32_t>(offsetof(Type_t, ____impl_9)); }
	inline RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  get__impl_9() const { return ____impl_9; }
	inline RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 * get_address_of__impl_9() { return &____impl_9; }
	inline void set__impl_9(RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  value)
	{
		____impl_9 = value;
	}
};

struct Type_t_StaticFields
{
public:
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterAttribute_0;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterName_1;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterNameIgnoreCase_2;
	// System.Object System.Type::Missing
	RuntimeObject * ___Missing_3;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_4;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* ___EmptyTypes_5;
	// System.Reflection.Binder System.Type::defaultBinder
	Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * ___defaultBinder_6;

public:
	inline static int32_t get_offset_of_FilterAttribute_0() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterAttribute_0)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterAttribute_0() const { return ___FilterAttribute_0; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterAttribute_0() { return &___FilterAttribute_0; }
	inline void set_FilterAttribute_0(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterAttribute_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterAttribute_0), (void*)value);
	}

	inline static int32_t get_offset_of_FilterName_1() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterName_1)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterName_1() const { return ___FilterName_1; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterName_1() { return &___FilterName_1; }
	inline void set_FilterName_1(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterName_1), (void*)value);
	}

	inline static int32_t get_offset_of_FilterNameIgnoreCase_2() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterNameIgnoreCase_2)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterNameIgnoreCase_2() const { return ___FilterNameIgnoreCase_2; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterNameIgnoreCase_2() { return &___FilterNameIgnoreCase_2; }
	inline void set_FilterNameIgnoreCase_2(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterNameIgnoreCase_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterNameIgnoreCase_2), (void*)value);
	}

	inline static int32_t get_offset_of_Missing_3() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Missing_3)); }
	inline RuntimeObject * get_Missing_3() const { return ___Missing_3; }
	inline RuntimeObject ** get_address_of_Missing_3() { return &___Missing_3; }
	inline void set_Missing_3(RuntimeObject * value)
	{
		___Missing_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Missing_3), (void*)value);
	}

	inline static int32_t get_offset_of_Delimiter_4() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Delimiter_4)); }
	inline Il2CppChar get_Delimiter_4() const { return ___Delimiter_4; }
	inline Il2CppChar* get_address_of_Delimiter_4() { return &___Delimiter_4; }
	inline void set_Delimiter_4(Il2CppChar value)
	{
		___Delimiter_4 = value;
	}

	inline static int32_t get_offset_of_EmptyTypes_5() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___EmptyTypes_5)); }
	inline TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* get_EmptyTypes_5() const { return ___EmptyTypes_5; }
	inline TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755** get_address_of_EmptyTypes_5() { return &___EmptyTypes_5; }
	inline void set_EmptyTypes_5(TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* value)
	{
		___EmptyTypes_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___EmptyTypes_5), (void*)value);
	}

	inline static int32_t get_offset_of_defaultBinder_6() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___defaultBinder_6)); }
	inline Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * get_defaultBinder_6() const { return ___defaultBinder_6; }
	inline Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 ** get_address_of_defaultBinder_6() { return &___defaultBinder_6; }
	inline void set_defaultBinder_6(Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * value)
	{
		___defaultBinder_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___defaultBinder_6), (void*)value);
	}
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


// System.Action`1<TapTap.Common.Result>
struct Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843  : public MulticastDelegate_t
{
public:

public:
};


// System.Action`2<TapTap.Common.TapLogLevel,System.String>
struct Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38  : public MulticastDelegate_t
{
public:

public:
};


// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA  : public MulticastDelegate_t
{
public:

public:
};


// System.Security.Cryptography.DES
struct DES_t4ACC4972FAAE56B5E5EE9C258CC1432F2D041BF4  : public SymmetricAlgorithm_tD007D9D59B6B96F42548FFE58E5F65CA5F9B7754
{
public:

public:
};

struct DES_t4ACC4972FAAE56B5E5EE9C258CC1432F2D041BF4_StaticFields
{
public:
	// System.Security.Cryptography.KeySizes[] System.Security.Cryptography.DES::s_legalBlockSizes
	KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* ___s_legalBlockSizes_9;
	// System.Security.Cryptography.KeySizes[] System.Security.Cryptography.DES::s_legalKeySizes
	KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* ___s_legalKeySizes_10;

public:
	inline static int32_t get_offset_of_s_legalBlockSizes_9() { return static_cast<int32_t>(offsetof(DES_t4ACC4972FAAE56B5E5EE9C258CC1432F2D041BF4_StaticFields, ___s_legalBlockSizes_9)); }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* get_s_legalBlockSizes_9() const { return ___s_legalBlockSizes_9; }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499** get_address_of_s_legalBlockSizes_9() { return &___s_legalBlockSizes_9; }
	inline void set_s_legalBlockSizes_9(KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* value)
	{
		___s_legalBlockSizes_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_legalBlockSizes_9), (void*)value);
	}

	inline static int32_t get_offset_of_s_legalKeySizes_10() { return static_cast<int32_t>(offsetof(DES_t4ACC4972FAAE56B5E5EE9C258CC1432F2D041BF4_StaticFields, ___s_legalKeySizes_10)); }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* get_s_legalKeySizes_10() const { return ___s_legalKeySizes_10; }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499** get_address_of_s_legalKeySizes_10() { return &___s_legalKeySizes_10; }
	inline void set_s_legalKeySizes_10(KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* value)
	{
		___s_legalKeySizes_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_legalKeySizes_10), (void*)value);
	}
};


// System.Net.Http.Headers.HttpContentHeaders
struct HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573  : public HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2
{
public:
	// System.Net.Http.HttpContent System.Net.Http.Headers.HttpContentHeaders::content
	HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * ___content_5;

public:
	inline static int32_t get_offset_of_content_5() { return static_cast<int32_t>(offsetof(HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573, ___content_5)); }
	inline HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * get_content_5() const { return ___content_5; }
	inline HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 ** get_address_of_content_5() { return &___content_5; }
	inline void set_content_5(HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * value)
	{
		___content_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___content_5), (void*)value);
	}
};


// System.Net.Http.Headers.HttpRequestHeaders
struct HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877  : public HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2
{
public:
	// System.Nullable`1<System.Boolean> System.Net.Http.Headers.HttpRequestHeaders::expectContinue
	Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  ___expectContinue_5;

public:
	inline static int32_t get_offset_of_expectContinue_5() { return static_cast<int32_t>(offsetof(HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877, ___expectContinue_5)); }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  get_expectContinue_5() const { return ___expectContinue_5; }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3 * get_address_of_expectContinue_5() { return &___expectContinue_5; }
	inline void set_expectContinue_5(Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  value)
	{
		___expectContinue_5 = value;
	}
};


// LC.Newtonsoft.Json.JsonReader
struct JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B  : public RuntimeObject
{
public:
	// LC.Newtonsoft.Json.JsonToken LC.Newtonsoft.Json.JsonReader::_tokenType
	int32_t ____tokenType_0;
	// System.Object LC.Newtonsoft.Json.JsonReader::_value
	RuntimeObject * ____value_1;
	// System.Char LC.Newtonsoft.Json.JsonReader::_quoteChar
	Il2CppChar ____quoteChar_2;
	// LC.Newtonsoft.Json.JsonReader/State LC.Newtonsoft.Json.JsonReader::_currentState
	int32_t ____currentState_3;
	// LC.Newtonsoft.Json.JsonPosition LC.Newtonsoft.Json.JsonReader::_currentPosition
	JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2  ____currentPosition_4;
	// System.Globalization.CultureInfo LC.Newtonsoft.Json.JsonReader::_culture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ____culture_5;
	// LC.Newtonsoft.Json.DateTimeZoneHandling LC.Newtonsoft.Json.JsonReader::_dateTimeZoneHandling
	int32_t ____dateTimeZoneHandling_6;
	// System.Nullable`1<System.Int32> LC.Newtonsoft.Json.JsonReader::_maxDepth
	Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  ____maxDepth_7;
	// System.Boolean LC.Newtonsoft.Json.JsonReader::_hasExceededMaxDepth
	bool ____hasExceededMaxDepth_8;
	// LC.Newtonsoft.Json.DateParseHandling LC.Newtonsoft.Json.JsonReader::_dateParseHandling
	int32_t ____dateParseHandling_9;
	// LC.Newtonsoft.Json.FloatParseHandling LC.Newtonsoft.Json.JsonReader::_floatParseHandling
	int32_t ____floatParseHandling_10;
	// System.String LC.Newtonsoft.Json.JsonReader::_dateFormatString
	String_t* ____dateFormatString_11;
	// System.Collections.Generic.List`1<LC.Newtonsoft.Json.JsonPosition> LC.Newtonsoft.Json.JsonReader::_stack
	List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8 * ____stack_12;
	// System.Boolean LC.Newtonsoft.Json.JsonReader::<CloseInput>k__BackingField
	bool ___U3CCloseInputU3Ek__BackingField_13;
	// System.Boolean LC.Newtonsoft.Json.JsonReader::<SupportMultipleContent>k__BackingField
	bool ___U3CSupportMultipleContentU3Ek__BackingField_14;

public:
	inline static int32_t get_offset_of__tokenType_0() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____tokenType_0)); }
	inline int32_t get__tokenType_0() const { return ____tokenType_0; }
	inline int32_t* get_address_of__tokenType_0() { return &____tokenType_0; }
	inline void set__tokenType_0(int32_t value)
	{
		____tokenType_0 = value;
	}

	inline static int32_t get_offset_of__value_1() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____value_1)); }
	inline RuntimeObject * get__value_1() const { return ____value_1; }
	inline RuntimeObject ** get_address_of__value_1() { return &____value_1; }
	inline void set__value_1(RuntimeObject * value)
	{
		____value_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____value_1), (void*)value);
	}

	inline static int32_t get_offset_of__quoteChar_2() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____quoteChar_2)); }
	inline Il2CppChar get__quoteChar_2() const { return ____quoteChar_2; }
	inline Il2CppChar* get_address_of__quoteChar_2() { return &____quoteChar_2; }
	inline void set__quoteChar_2(Il2CppChar value)
	{
		____quoteChar_2 = value;
	}

	inline static int32_t get_offset_of__currentState_3() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____currentState_3)); }
	inline int32_t get__currentState_3() const { return ____currentState_3; }
	inline int32_t* get_address_of__currentState_3() { return &____currentState_3; }
	inline void set__currentState_3(int32_t value)
	{
		____currentState_3 = value;
	}

	inline static int32_t get_offset_of__currentPosition_4() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____currentPosition_4)); }
	inline JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2  get__currentPosition_4() const { return ____currentPosition_4; }
	inline JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2 * get_address_of__currentPosition_4() { return &____currentPosition_4; }
	inline void set__currentPosition_4(JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2  value)
	{
		____currentPosition_4 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&____currentPosition_4))->___PropertyName_3), (void*)NULL);
	}

	inline static int32_t get_offset_of__culture_5() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____culture_5)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get__culture_5() const { return ____culture_5; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of__culture_5() { return &____culture_5; }
	inline void set__culture_5(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		____culture_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____culture_5), (void*)value);
	}

	inline static int32_t get_offset_of__dateTimeZoneHandling_6() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____dateTimeZoneHandling_6)); }
	inline int32_t get__dateTimeZoneHandling_6() const { return ____dateTimeZoneHandling_6; }
	inline int32_t* get_address_of__dateTimeZoneHandling_6() { return &____dateTimeZoneHandling_6; }
	inline void set__dateTimeZoneHandling_6(int32_t value)
	{
		____dateTimeZoneHandling_6 = value;
	}

	inline static int32_t get_offset_of__maxDepth_7() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____maxDepth_7)); }
	inline Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  get__maxDepth_7() const { return ____maxDepth_7; }
	inline Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 * get_address_of__maxDepth_7() { return &____maxDepth_7; }
	inline void set__maxDepth_7(Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  value)
	{
		____maxDepth_7 = value;
	}

	inline static int32_t get_offset_of__hasExceededMaxDepth_8() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____hasExceededMaxDepth_8)); }
	inline bool get__hasExceededMaxDepth_8() const { return ____hasExceededMaxDepth_8; }
	inline bool* get_address_of__hasExceededMaxDepth_8() { return &____hasExceededMaxDepth_8; }
	inline void set__hasExceededMaxDepth_8(bool value)
	{
		____hasExceededMaxDepth_8 = value;
	}

	inline static int32_t get_offset_of__dateParseHandling_9() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____dateParseHandling_9)); }
	inline int32_t get__dateParseHandling_9() const { return ____dateParseHandling_9; }
	inline int32_t* get_address_of__dateParseHandling_9() { return &____dateParseHandling_9; }
	inline void set__dateParseHandling_9(int32_t value)
	{
		____dateParseHandling_9 = value;
	}

	inline static int32_t get_offset_of__floatParseHandling_10() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____floatParseHandling_10)); }
	inline int32_t get__floatParseHandling_10() const { return ____floatParseHandling_10; }
	inline int32_t* get_address_of__floatParseHandling_10() { return &____floatParseHandling_10; }
	inline void set__floatParseHandling_10(int32_t value)
	{
		____floatParseHandling_10 = value;
	}

	inline static int32_t get_offset_of__dateFormatString_11() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____dateFormatString_11)); }
	inline String_t* get__dateFormatString_11() const { return ____dateFormatString_11; }
	inline String_t** get_address_of__dateFormatString_11() { return &____dateFormatString_11; }
	inline void set__dateFormatString_11(String_t* value)
	{
		____dateFormatString_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dateFormatString_11), (void*)value);
	}

	inline static int32_t get_offset_of__stack_12() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ____stack_12)); }
	inline List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8 * get__stack_12() const { return ____stack_12; }
	inline List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8 ** get_address_of__stack_12() { return &____stack_12; }
	inline void set__stack_12(List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8 * value)
	{
		____stack_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stack_12), (void*)value);
	}

	inline static int32_t get_offset_of_U3CCloseInputU3Ek__BackingField_13() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ___U3CCloseInputU3Ek__BackingField_13)); }
	inline bool get_U3CCloseInputU3Ek__BackingField_13() const { return ___U3CCloseInputU3Ek__BackingField_13; }
	inline bool* get_address_of_U3CCloseInputU3Ek__BackingField_13() { return &___U3CCloseInputU3Ek__BackingField_13; }
	inline void set_U3CCloseInputU3Ek__BackingField_13(bool value)
	{
		___U3CCloseInputU3Ek__BackingField_13 = value;
	}

	inline static int32_t get_offset_of_U3CSupportMultipleContentU3Ek__BackingField_14() { return static_cast<int32_t>(offsetof(JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B, ___U3CSupportMultipleContentU3Ek__BackingField_14)); }
	inline bool get_U3CSupportMultipleContentU3Ek__BackingField_14() const { return ___U3CSupportMultipleContentU3Ek__BackingField_14; }
	inline bool* get_address_of_U3CSupportMultipleContentU3Ek__BackingField_14() { return &___U3CSupportMultipleContentU3Ek__BackingField_14; }
	inline void set_U3CSupportMultipleContentU3Ek__BackingField_14(bool value)
	{
		___U3CSupportMultipleContentU3Ek__BackingField_14 = value;
	}
};


// LC.Newtonsoft.Json.JsonSerializer
struct JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B  : public RuntimeObject
{
public:
	// LC.Newtonsoft.Json.TypeNameHandling LC.Newtonsoft.Json.JsonSerializer::_typeNameHandling
	int32_t ____typeNameHandling_0;
	// LC.Newtonsoft.Json.TypeNameAssemblyFormatHandling LC.Newtonsoft.Json.JsonSerializer::_typeNameAssemblyFormatHandling
	int32_t ____typeNameAssemblyFormatHandling_1;
	// LC.Newtonsoft.Json.PreserveReferencesHandling LC.Newtonsoft.Json.JsonSerializer::_preserveReferencesHandling
	int32_t ____preserveReferencesHandling_2;
	// LC.Newtonsoft.Json.ReferenceLoopHandling LC.Newtonsoft.Json.JsonSerializer::_referenceLoopHandling
	int32_t ____referenceLoopHandling_3;
	// LC.Newtonsoft.Json.MissingMemberHandling LC.Newtonsoft.Json.JsonSerializer::_missingMemberHandling
	int32_t ____missingMemberHandling_4;
	// LC.Newtonsoft.Json.ObjectCreationHandling LC.Newtonsoft.Json.JsonSerializer::_objectCreationHandling
	int32_t ____objectCreationHandling_5;
	// LC.Newtonsoft.Json.NullValueHandling LC.Newtonsoft.Json.JsonSerializer::_nullValueHandling
	int32_t ____nullValueHandling_6;
	// LC.Newtonsoft.Json.DefaultValueHandling LC.Newtonsoft.Json.JsonSerializer::_defaultValueHandling
	int32_t ____defaultValueHandling_7;
	// LC.Newtonsoft.Json.ConstructorHandling LC.Newtonsoft.Json.JsonSerializer::_constructorHandling
	int32_t ____constructorHandling_8;
	// LC.Newtonsoft.Json.MetadataPropertyHandling LC.Newtonsoft.Json.JsonSerializer::_metadataPropertyHandling
	int32_t ____metadataPropertyHandling_9;
	// LC.Newtonsoft.Json.JsonConverterCollection LC.Newtonsoft.Json.JsonSerializer::_converters
	JsonConverterCollection_tBF00847A818DC8D654E2AB29814CC38956418C86 * ____converters_10;
	// LC.Newtonsoft.Json.Serialization.IContractResolver LC.Newtonsoft.Json.JsonSerializer::_contractResolver
	RuntimeObject* ____contractResolver_11;
	// LC.Newtonsoft.Json.Serialization.ITraceWriter LC.Newtonsoft.Json.JsonSerializer::_traceWriter
	RuntimeObject* ____traceWriter_12;
	// System.Collections.IEqualityComparer LC.Newtonsoft.Json.JsonSerializer::_equalityComparer
	RuntimeObject* ____equalityComparer_13;
	// LC.Newtonsoft.Json.Serialization.ISerializationBinder LC.Newtonsoft.Json.JsonSerializer::_serializationBinder
	RuntimeObject* ____serializationBinder_14;
	// System.Runtime.Serialization.StreamingContext LC.Newtonsoft.Json.JsonSerializer::_context
	StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505  ____context_15;
	// LC.Newtonsoft.Json.Serialization.IReferenceResolver LC.Newtonsoft.Json.JsonSerializer::_referenceResolver
	RuntimeObject* ____referenceResolver_16;
	// System.Nullable`1<LC.Newtonsoft.Json.Formatting> LC.Newtonsoft.Json.JsonSerializer::_formatting
	Nullable_1_t2F476D5976937795CC50A8B19FE43301C48709A4  ____formatting_17;
	// System.Nullable`1<LC.Newtonsoft.Json.DateFormatHandling> LC.Newtonsoft.Json.JsonSerializer::_dateFormatHandling
	Nullable_1_t54B973074A189235F033D5B0500365C31CE1F337  ____dateFormatHandling_18;
	// System.Nullable`1<LC.Newtonsoft.Json.DateTimeZoneHandling> LC.Newtonsoft.Json.JsonSerializer::_dateTimeZoneHandling
	Nullable_1_t767D1EC598BAC10A0E90659F99060E74FA1BD5B8  ____dateTimeZoneHandling_19;
	// System.Nullable`1<LC.Newtonsoft.Json.DateParseHandling> LC.Newtonsoft.Json.JsonSerializer::_dateParseHandling
	Nullable_1_t08E7A00A29C14FCBC977519574552DB2C05BB587  ____dateParseHandling_20;
	// System.Nullable`1<LC.Newtonsoft.Json.FloatFormatHandling> LC.Newtonsoft.Json.JsonSerializer::_floatFormatHandling
	Nullable_1_t18508742AB2FF7AEFACF67FAC35F061CBD270E8E  ____floatFormatHandling_21;
	// System.Nullable`1<LC.Newtonsoft.Json.FloatParseHandling> LC.Newtonsoft.Json.JsonSerializer::_floatParseHandling
	Nullable_1_t77478D7686D2FE4521B588E8C7B86E307DC2AF5C  ____floatParseHandling_22;
	// System.Nullable`1<LC.Newtonsoft.Json.StringEscapeHandling> LC.Newtonsoft.Json.JsonSerializer::_stringEscapeHandling
	Nullable_1_t467884074E3014FCC85712886F7DC7C52D07F2CD  ____stringEscapeHandling_23;
	// System.Globalization.CultureInfo LC.Newtonsoft.Json.JsonSerializer::_culture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ____culture_24;
	// System.Nullable`1<System.Int32> LC.Newtonsoft.Json.JsonSerializer::_maxDepth
	Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  ____maxDepth_25;
	// System.Boolean LC.Newtonsoft.Json.JsonSerializer::_maxDepthSet
	bool ____maxDepthSet_26;
	// System.Nullable`1<System.Boolean> LC.Newtonsoft.Json.JsonSerializer::_checkAdditionalContent
	Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  ____checkAdditionalContent_27;
	// System.String LC.Newtonsoft.Json.JsonSerializer::_dateFormatString
	String_t* ____dateFormatString_28;
	// System.Boolean LC.Newtonsoft.Json.JsonSerializer::_dateFormatStringSet
	bool ____dateFormatStringSet_29;
	// System.EventHandler`1<LC.Newtonsoft.Json.Serialization.ErrorEventArgs> LC.Newtonsoft.Json.JsonSerializer::Error
	EventHandler_1_tB446608E53297A82207BBE7269240E039AD6257B * ___Error_30;

public:
	inline static int32_t get_offset_of__typeNameHandling_0() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____typeNameHandling_0)); }
	inline int32_t get__typeNameHandling_0() const { return ____typeNameHandling_0; }
	inline int32_t* get_address_of__typeNameHandling_0() { return &____typeNameHandling_0; }
	inline void set__typeNameHandling_0(int32_t value)
	{
		____typeNameHandling_0 = value;
	}

	inline static int32_t get_offset_of__typeNameAssemblyFormatHandling_1() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____typeNameAssemblyFormatHandling_1)); }
	inline int32_t get__typeNameAssemblyFormatHandling_1() const { return ____typeNameAssemblyFormatHandling_1; }
	inline int32_t* get_address_of__typeNameAssemblyFormatHandling_1() { return &____typeNameAssemblyFormatHandling_1; }
	inline void set__typeNameAssemblyFormatHandling_1(int32_t value)
	{
		____typeNameAssemblyFormatHandling_1 = value;
	}

	inline static int32_t get_offset_of__preserveReferencesHandling_2() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____preserveReferencesHandling_2)); }
	inline int32_t get__preserveReferencesHandling_2() const { return ____preserveReferencesHandling_2; }
	inline int32_t* get_address_of__preserveReferencesHandling_2() { return &____preserveReferencesHandling_2; }
	inline void set__preserveReferencesHandling_2(int32_t value)
	{
		____preserveReferencesHandling_2 = value;
	}

	inline static int32_t get_offset_of__referenceLoopHandling_3() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____referenceLoopHandling_3)); }
	inline int32_t get__referenceLoopHandling_3() const { return ____referenceLoopHandling_3; }
	inline int32_t* get_address_of__referenceLoopHandling_3() { return &____referenceLoopHandling_3; }
	inline void set__referenceLoopHandling_3(int32_t value)
	{
		____referenceLoopHandling_3 = value;
	}

	inline static int32_t get_offset_of__missingMemberHandling_4() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____missingMemberHandling_4)); }
	inline int32_t get__missingMemberHandling_4() const { return ____missingMemberHandling_4; }
	inline int32_t* get_address_of__missingMemberHandling_4() { return &____missingMemberHandling_4; }
	inline void set__missingMemberHandling_4(int32_t value)
	{
		____missingMemberHandling_4 = value;
	}

	inline static int32_t get_offset_of__objectCreationHandling_5() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____objectCreationHandling_5)); }
	inline int32_t get__objectCreationHandling_5() const { return ____objectCreationHandling_5; }
	inline int32_t* get_address_of__objectCreationHandling_5() { return &____objectCreationHandling_5; }
	inline void set__objectCreationHandling_5(int32_t value)
	{
		____objectCreationHandling_5 = value;
	}

	inline static int32_t get_offset_of__nullValueHandling_6() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____nullValueHandling_6)); }
	inline int32_t get__nullValueHandling_6() const { return ____nullValueHandling_6; }
	inline int32_t* get_address_of__nullValueHandling_6() { return &____nullValueHandling_6; }
	inline void set__nullValueHandling_6(int32_t value)
	{
		____nullValueHandling_6 = value;
	}

	inline static int32_t get_offset_of__defaultValueHandling_7() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____defaultValueHandling_7)); }
	inline int32_t get__defaultValueHandling_7() const { return ____defaultValueHandling_7; }
	inline int32_t* get_address_of__defaultValueHandling_7() { return &____defaultValueHandling_7; }
	inline void set__defaultValueHandling_7(int32_t value)
	{
		____defaultValueHandling_7 = value;
	}

	inline static int32_t get_offset_of__constructorHandling_8() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____constructorHandling_8)); }
	inline int32_t get__constructorHandling_8() const { return ____constructorHandling_8; }
	inline int32_t* get_address_of__constructorHandling_8() { return &____constructorHandling_8; }
	inline void set__constructorHandling_8(int32_t value)
	{
		____constructorHandling_8 = value;
	}

	inline static int32_t get_offset_of__metadataPropertyHandling_9() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____metadataPropertyHandling_9)); }
	inline int32_t get__metadataPropertyHandling_9() const { return ____metadataPropertyHandling_9; }
	inline int32_t* get_address_of__metadataPropertyHandling_9() { return &____metadataPropertyHandling_9; }
	inline void set__metadataPropertyHandling_9(int32_t value)
	{
		____metadataPropertyHandling_9 = value;
	}

	inline static int32_t get_offset_of__converters_10() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____converters_10)); }
	inline JsonConverterCollection_tBF00847A818DC8D654E2AB29814CC38956418C86 * get__converters_10() const { return ____converters_10; }
	inline JsonConverterCollection_tBF00847A818DC8D654E2AB29814CC38956418C86 ** get_address_of__converters_10() { return &____converters_10; }
	inline void set__converters_10(JsonConverterCollection_tBF00847A818DC8D654E2AB29814CC38956418C86 * value)
	{
		____converters_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____converters_10), (void*)value);
	}

	inline static int32_t get_offset_of__contractResolver_11() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____contractResolver_11)); }
	inline RuntimeObject* get__contractResolver_11() const { return ____contractResolver_11; }
	inline RuntimeObject** get_address_of__contractResolver_11() { return &____contractResolver_11; }
	inline void set__contractResolver_11(RuntimeObject* value)
	{
		____contractResolver_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____contractResolver_11), (void*)value);
	}

	inline static int32_t get_offset_of__traceWriter_12() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____traceWriter_12)); }
	inline RuntimeObject* get__traceWriter_12() const { return ____traceWriter_12; }
	inline RuntimeObject** get_address_of__traceWriter_12() { return &____traceWriter_12; }
	inline void set__traceWriter_12(RuntimeObject* value)
	{
		____traceWriter_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____traceWriter_12), (void*)value);
	}

	inline static int32_t get_offset_of__equalityComparer_13() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____equalityComparer_13)); }
	inline RuntimeObject* get__equalityComparer_13() const { return ____equalityComparer_13; }
	inline RuntimeObject** get_address_of__equalityComparer_13() { return &____equalityComparer_13; }
	inline void set__equalityComparer_13(RuntimeObject* value)
	{
		____equalityComparer_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____equalityComparer_13), (void*)value);
	}

	inline static int32_t get_offset_of__serializationBinder_14() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____serializationBinder_14)); }
	inline RuntimeObject* get__serializationBinder_14() const { return ____serializationBinder_14; }
	inline RuntimeObject** get_address_of__serializationBinder_14() { return &____serializationBinder_14; }
	inline void set__serializationBinder_14(RuntimeObject* value)
	{
		____serializationBinder_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____serializationBinder_14), (void*)value);
	}

	inline static int32_t get_offset_of__context_15() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____context_15)); }
	inline StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505  get__context_15() const { return ____context_15; }
	inline StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505 * get_address_of__context_15() { return &____context_15; }
	inline void set__context_15(StreamingContext_t5888E7E8C81AB6EF3B14FDDA6674F458076A8505  value)
	{
		____context_15 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&____context_15))->___m_additionalContext_0), (void*)NULL);
	}

	inline static int32_t get_offset_of__referenceResolver_16() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____referenceResolver_16)); }
	inline RuntimeObject* get__referenceResolver_16() const { return ____referenceResolver_16; }
	inline RuntimeObject** get_address_of__referenceResolver_16() { return &____referenceResolver_16; }
	inline void set__referenceResolver_16(RuntimeObject* value)
	{
		____referenceResolver_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____referenceResolver_16), (void*)value);
	}

	inline static int32_t get_offset_of__formatting_17() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____formatting_17)); }
	inline Nullable_1_t2F476D5976937795CC50A8B19FE43301C48709A4  get__formatting_17() const { return ____formatting_17; }
	inline Nullable_1_t2F476D5976937795CC50A8B19FE43301C48709A4 * get_address_of__formatting_17() { return &____formatting_17; }
	inline void set__formatting_17(Nullable_1_t2F476D5976937795CC50A8B19FE43301C48709A4  value)
	{
		____formatting_17 = value;
	}

	inline static int32_t get_offset_of__dateFormatHandling_18() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____dateFormatHandling_18)); }
	inline Nullable_1_t54B973074A189235F033D5B0500365C31CE1F337  get__dateFormatHandling_18() const { return ____dateFormatHandling_18; }
	inline Nullable_1_t54B973074A189235F033D5B0500365C31CE1F337 * get_address_of__dateFormatHandling_18() { return &____dateFormatHandling_18; }
	inline void set__dateFormatHandling_18(Nullable_1_t54B973074A189235F033D5B0500365C31CE1F337  value)
	{
		____dateFormatHandling_18 = value;
	}

	inline static int32_t get_offset_of__dateTimeZoneHandling_19() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____dateTimeZoneHandling_19)); }
	inline Nullable_1_t767D1EC598BAC10A0E90659F99060E74FA1BD5B8  get__dateTimeZoneHandling_19() const { return ____dateTimeZoneHandling_19; }
	inline Nullable_1_t767D1EC598BAC10A0E90659F99060E74FA1BD5B8 * get_address_of__dateTimeZoneHandling_19() { return &____dateTimeZoneHandling_19; }
	inline void set__dateTimeZoneHandling_19(Nullable_1_t767D1EC598BAC10A0E90659F99060E74FA1BD5B8  value)
	{
		____dateTimeZoneHandling_19 = value;
	}

	inline static int32_t get_offset_of__dateParseHandling_20() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____dateParseHandling_20)); }
	inline Nullable_1_t08E7A00A29C14FCBC977519574552DB2C05BB587  get__dateParseHandling_20() const { return ____dateParseHandling_20; }
	inline Nullable_1_t08E7A00A29C14FCBC977519574552DB2C05BB587 * get_address_of__dateParseHandling_20() { return &____dateParseHandling_20; }
	inline void set__dateParseHandling_20(Nullable_1_t08E7A00A29C14FCBC977519574552DB2C05BB587  value)
	{
		____dateParseHandling_20 = value;
	}

	inline static int32_t get_offset_of__floatFormatHandling_21() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____floatFormatHandling_21)); }
	inline Nullable_1_t18508742AB2FF7AEFACF67FAC35F061CBD270E8E  get__floatFormatHandling_21() const { return ____floatFormatHandling_21; }
	inline Nullable_1_t18508742AB2FF7AEFACF67FAC35F061CBD270E8E * get_address_of__floatFormatHandling_21() { return &____floatFormatHandling_21; }
	inline void set__floatFormatHandling_21(Nullable_1_t18508742AB2FF7AEFACF67FAC35F061CBD270E8E  value)
	{
		____floatFormatHandling_21 = value;
	}

	inline static int32_t get_offset_of__floatParseHandling_22() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____floatParseHandling_22)); }
	inline Nullable_1_t77478D7686D2FE4521B588E8C7B86E307DC2AF5C  get__floatParseHandling_22() const { return ____floatParseHandling_22; }
	inline Nullable_1_t77478D7686D2FE4521B588E8C7B86E307DC2AF5C * get_address_of__floatParseHandling_22() { return &____floatParseHandling_22; }
	inline void set__floatParseHandling_22(Nullable_1_t77478D7686D2FE4521B588E8C7B86E307DC2AF5C  value)
	{
		____floatParseHandling_22 = value;
	}

	inline static int32_t get_offset_of__stringEscapeHandling_23() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____stringEscapeHandling_23)); }
	inline Nullable_1_t467884074E3014FCC85712886F7DC7C52D07F2CD  get__stringEscapeHandling_23() const { return ____stringEscapeHandling_23; }
	inline Nullable_1_t467884074E3014FCC85712886F7DC7C52D07F2CD * get_address_of__stringEscapeHandling_23() { return &____stringEscapeHandling_23; }
	inline void set__stringEscapeHandling_23(Nullable_1_t467884074E3014FCC85712886F7DC7C52D07F2CD  value)
	{
		____stringEscapeHandling_23 = value;
	}

	inline static int32_t get_offset_of__culture_24() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____culture_24)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get__culture_24() const { return ____culture_24; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of__culture_24() { return &____culture_24; }
	inline void set__culture_24(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		____culture_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____culture_24), (void*)value);
	}

	inline static int32_t get_offset_of__maxDepth_25() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____maxDepth_25)); }
	inline Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  get__maxDepth_25() const { return ____maxDepth_25; }
	inline Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103 * get_address_of__maxDepth_25() { return &____maxDepth_25; }
	inline void set__maxDepth_25(Nullable_1_t864FD0051A05D37F91C857AB496BFCB3FE756103  value)
	{
		____maxDepth_25 = value;
	}

	inline static int32_t get_offset_of__maxDepthSet_26() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____maxDepthSet_26)); }
	inline bool get__maxDepthSet_26() const { return ____maxDepthSet_26; }
	inline bool* get_address_of__maxDepthSet_26() { return &____maxDepthSet_26; }
	inline void set__maxDepthSet_26(bool value)
	{
		____maxDepthSet_26 = value;
	}

	inline static int32_t get_offset_of__checkAdditionalContent_27() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____checkAdditionalContent_27)); }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  get__checkAdditionalContent_27() const { return ____checkAdditionalContent_27; }
	inline Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3 * get_address_of__checkAdditionalContent_27() { return &____checkAdditionalContent_27; }
	inline void set__checkAdditionalContent_27(Nullable_1_t1D1CD146BFCBDC2E53E1F700889F8C5C21063EF3  value)
	{
		____checkAdditionalContent_27 = value;
	}

	inline static int32_t get_offset_of__dateFormatString_28() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____dateFormatString_28)); }
	inline String_t* get__dateFormatString_28() const { return ____dateFormatString_28; }
	inline String_t** get_address_of__dateFormatString_28() { return &____dateFormatString_28; }
	inline void set__dateFormatString_28(String_t* value)
	{
		____dateFormatString_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dateFormatString_28), (void*)value);
	}

	inline static int32_t get_offset_of__dateFormatStringSet_29() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ____dateFormatStringSet_29)); }
	inline bool get__dateFormatStringSet_29() const { return ____dateFormatStringSet_29; }
	inline bool* get_address_of__dateFormatStringSet_29() { return &____dateFormatStringSet_29; }
	inline void set__dateFormatStringSet_29(bool value)
	{
		____dateFormatStringSet_29 = value;
	}

	inline static int32_t get_offset_of_Error_30() { return static_cast<int32_t>(offsetof(JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B, ___Error_30)); }
	inline EventHandler_1_tB446608E53297A82207BBE7269240E039AD6257B * get_Error_30() const { return ___Error_30; }
	inline EventHandler_1_tB446608E53297A82207BBE7269240E039AD6257B ** get_address_of_Error_30() { return &___Error_30; }
	inline void set_Error_30(EventHandler_1_tB446608E53297A82207BBE7269240E039AD6257B * value)
	{
		___Error_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Error_30), (void*)value);
	}
};


// LC.Newtonsoft.Json.JsonWriter
struct JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008  : public RuntimeObject
{
public:
	// System.Collections.Generic.List`1<LC.Newtonsoft.Json.JsonPosition> LC.Newtonsoft.Json.JsonWriter::_stack
	List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8 * ____stack_2;
	// LC.Newtonsoft.Json.JsonPosition LC.Newtonsoft.Json.JsonWriter::_currentPosition
	JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2  ____currentPosition_3;
	// LC.Newtonsoft.Json.JsonWriter/State LC.Newtonsoft.Json.JsonWriter::_currentState
	int32_t ____currentState_4;
	// LC.Newtonsoft.Json.Formatting LC.Newtonsoft.Json.JsonWriter::_formatting
	int32_t ____formatting_5;
	// System.Boolean LC.Newtonsoft.Json.JsonWriter::<CloseOutput>k__BackingField
	bool ___U3CCloseOutputU3Ek__BackingField_6;
	// System.Boolean LC.Newtonsoft.Json.JsonWriter::<AutoCompleteOnClose>k__BackingField
	bool ___U3CAutoCompleteOnCloseU3Ek__BackingField_7;
	// LC.Newtonsoft.Json.DateFormatHandling LC.Newtonsoft.Json.JsonWriter::_dateFormatHandling
	int32_t ____dateFormatHandling_8;
	// LC.Newtonsoft.Json.DateTimeZoneHandling LC.Newtonsoft.Json.JsonWriter::_dateTimeZoneHandling
	int32_t ____dateTimeZoneHandling_9;
	// LC.Newtonsoft.Json.StringEscapeHandling LC.Newtonsoft.Json.JsonWriter::_stringEscapeHandling
	int32_t ____stringEscapeHandling_10;
	// LC.Newtonsoft.Json.FloatFormatHandling LC.Newtonsoft.Json.JsonWriter::_floatFormatHandling
	int32_t ____floatFormatHandling_11;
	// System.String LC.Newtonsoft.Json.JsonWriter::_dateFormatString
	String_t* ____dateFormatString_12;
	// System.Globalization.CultureInfo LC.Newtonsoft.Json.JsonWriter::_culture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ____culture_13;

public:
	inline static int32_t get_offset_of__stack_2() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____stack_2)); }
	inline List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8 * get__stack_2() const { return ____stack_2; }
	inline List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8 ** get_address_of__stack_2() { return &____stack_2; }
	inline void set__stack_2(List_1_t92F303B10A0BEAA7B0DAD2E12A6515E216AD8FE8 * value)
	{
		____stack_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stack_2), (void*)value);
	}

	inline static int32_t get_offset_of__currentPosition_3() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____currentPosition_3)); }
	inline JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2  get__currentPosition_3() const { return ____currentPosition_3; }
	inline JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2 * get_address_of__currentPosition_3() { return &____currentPosition_3; }
	inline void set__currentPosition_3(JsonPosition_tEF83211F8F50D8F5765A8298F31F3E8D2A7C49A2  value)
	{
		____currentPosition_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&____currentPosition_3))->___PropertyName_3), (void*)NULL);
	}

	inline static int32_t get_offset_of__currentState_4() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____currentState_4)); }
	inline int32_t get__currentState_4() const { return ____currentState_4; }
	inline int32_t* get_address_of__currentState_4() { return &____currentState_4; }
	inline void set__currentState_4(int32_t value)
	{
		____currentState_4 = value;
	}

	inline static int32_t get_offset_of__formatting_5() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____formatting_5)); }
	inline int32_t get__formatting_5() const { return ____formatting_5; }
	inline int32_t* get_address_of__formatting_5() { return &____formatting_5; }
	inline void set__formatting_5(int32_t value)
	{
		____formatting_5 = value;
	}

	inline static int32_t get_offset_of_U3CCloseOutputU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ___U3CCloseOutputU3Ek__BackingField_6)); }
	inline bool get_U3CCloseOutputU3Ek__BackingField_6() const { return ___U3CCloseOutputU3Ek__BackingField_6; }
	inline bool* get_address_of_U3CCloseOutputU3Ek__BackingField_6() { return &___U3CCloseOutputU3Ek__BackingField_6; }
	inline void set_U3CCloseOutputU3Ek__BackingField_6(bool value)
	{
		___U3CCloseOutputU3Ek__BackingField_6 = value;
	}

	inline static int32_t get_offset_of_U3CAutoCompleteOnCloseU3Ek__BackingField_7() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ___U3CAutoCompleteOnCloseU3Ek__BackingField_7)); }
	inline bool get_U3CAutoCompleteOnCloseU3Ek__BackingField_7() const { return ___U3CAutoCompleteOnCloseU3Ek__BackingField_7; }
	inline bool* get_address_of_U3CAutoCompleteOnCloseU3Ek__BackingField_7() { return &___U3CAutoCompleteOnCloseU3Ek__BackingField_7; }
	inline void set_U3CAutoCompleteOnCloseU3Ek__BackingField_7(bool value)
	{
		___U3CAutoCompleteOnCloseU3Ek__BackingField_7 = value;
	}

	inline static int32_t get_offset_of__dateFormatHandling_8() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____dateFormatHandling_8)); }
	inline int32_t get__dateFormatHandling_8() const { return ____dateFormatHandling_8; }
	inline int32_t* get_address_of__dateFormatHandling_8() { return &____dateFormatHandling_8; }
	inline void set__dateFormatHandling_8(int32_t value)
	{
		____dateFormatHandling_8 = value;
	}

	inline static int32_t get_offset_of__dateTimeZoneHandling_9() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____dateTimeZoneHandling_9)); }
	inline int32_t get__dateTimeZoneHandling_9() const { return ____dateTimeZoneHandling_9; }
	inline int32_t* get_address_of__dateTimeZoneHandling_9() { return &____dateTimeZoneHandling_9; }
	inline void set__dateTimeZoneHandling_9(int32_t value)
	{
		____dateTimeZoneHandling_9 = value;
	}

	inline static int32_t get_offset_of__stringEscapeHandling_10() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____stringEscapeHandling_10)); }
	inline int32_t get__stringEscapeHandling_10() const { return ____stringEscapeHandling_10; }
	inline int32_t* get_address_of__stringEscapeHandling_10() { return &____stringEscapeHandling_10; }
	inline void set__stringEscapeHandling_10(int32_t value)
	{
		____stringEscapeHandling_10 = value;
	}

	inline static int32_t get_offset_of__floatFormatHandling_11() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____floatFormatHandling_11)); }
	inline int32_t get__floatFormatHandling_11() const { return ____floatFormatHandling_11; }
	inline int32_t* get_address_of__floatFormatHandling_11() { return &____floatFormatHandling_11; }
	inline void set__floatFormatHandling_11(int32_t value)
	{
		____floatFormatHandling_11 = value;
	}

	inline static int32_t get_offset_of__dateFormatString_12() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____dateFormatString_12)); }
	inline String_t* get__dateFormatString_12() const { return ____dateFormatString_12; }
	inline String_t** get_address_of__dateFormatString_12() { return &____dateFormatString_12; }
	inline void set__dateFormatString_12(String_t* value)
	{
		____dateFormatString_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dateFormatString_12), (void*)value);
	}

	inline static int32_t get_offset_of__culture_13() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008, ____culture_13)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get__culture_13() const { return ____culture_13; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of__culture_13() { return &____culture_13; }
	inline void set__culture_13(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		____culture_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____culture_13), (void*)value);
	}
};

struct JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008_StaticFields
{
public:
	// LC.Newtonsoft.Json.JsonWriter/State[][] LC.Newtonsoft.Json.JsonWriter::StateArray
	StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978* ___StateArray_0;
	// LC.Newtonsoft.Json.JsonWriter/State[][] LC.Newtonsoft.Json.JsonWriter::StateArrayTempate
	StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978* ___StateArrayTempate_1;

public:
	inline static int32_t get_offset_of_StateArray_0() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008_StaticFields, ___StateArray_0)); }
	inline StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978* get_StateArray_0() const { return ___StateArray_0; }
	inline StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978** get_address_of_StateArray_0() { return &___StateArray_0; }
	inline void set_StateArray_0(StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978* value)
	{
		___StateArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___StateArray_0), (void*)value);
	}

	inline static int32_t get_offset_of_StateArrayTempate_1() { return static_cast<int32_t>(offsetof(JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008_StaticFields, ___StateArrayTempate_1)); }
	inline StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978* get_StateArrayTempate_1() const { return ___StateArrayTempate_1; }
	inline StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978** get_address_of_StateArrayTempate_1() { return &___StateArrayTempate_1; }
	inline void set_StateArrayTempate_1(StateU5BU5DU5BU5D_t8B262E1F5F7CCC002F988ACF35AE1ED2C01B1978* value)
	{
		___StateArrayTempate_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___StateArrayTempate_1), (void*)value);
	}
};


// TapTap.Common.BridgeIOS/EngineBridgeDelegate
struct EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A  : public MulticastDelegate_t
{
public:

public:
};


// System.Security.Cryptography.DESCryptoServiceProvider
struct DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40  : public DES_t4ACC4972FAAE56B5E5EE9C258CC1432F2D041BF4
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
// System.Net.NetworkInformation.NetworkInterface[]
struct NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * m_Items[1];

public:
	inline NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) String_t* m_Items[1];

public:
	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
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
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Il2CppChar m_Items[1];

public:
	inline Il2CppChar GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Il2CppChar value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Il2CppChar GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Il2CppChar value)
	{
		m_Items[index] = value;
	}
};


// !!0 UnityEngine.AndroidJavaObject::GetStatic<System.Object>(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * AndroidJavaObject_GetStatic_TisRuntimeObject_mEC743ECF275CB896DE039A9FC1E5672B30C8B3D0_gshared (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * __this, String_t* ___fieldName0, const RuntimeMethod* method);
// !!0[] System.Array::Empty<System.Object>()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline (const RuntimeMethod* method);
// !!0 UnityEngine.AndroidJavaObject::CallStatic<System.Object>(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * AndroidJavaObject_CallStatic_TisRuntimeObject_m29BD05B7A29F937D71B746DFFE889B90E1142509_gshared (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * __this, String_t* ___methodName0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method);
// System.Void System.Action`1<System.Object>::Invoke(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1_Invoke_m587509C88BB83721D7918D89DF07606BB752D744_gshared (Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * __this, RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Void System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConcurrentDictionary_2__ctor_m0A46F1D3CDFD063E9561E0B23D2BA32B895CD1AD_gshared (ConcurrentDictionary_2_t089158EC5B60BA9524898F4AC52FEBB3F3F48198 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>::ContainsKey(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ConcurrentDictionary_2_ContainsKey_m1BACEC1E10E3A457AC9CCB90D6BA07BF197B447A_gshared (ConcurrentDictionary_2_t089158EC5B60BA9524898F4AC52FEBB3F3F48198 * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// !1 System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>::get_Item(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * ConcurrentDictionary_2_get_Item_m59F8F360E1831F72953AFFFA11CB69909D846D00_gshared (ConcurrentDictionary_2_t089158EC5B60BA9524898F4AC52FEBB3F3F48198 * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>::TryRemove(!0,!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ConcurrentDictionary_2_TryRemove_mE9378B3DDFBD3CCE02CB8862DD35BEB41A5819F6_gshared (ConcurrentDictionary_2_t089158EC5B60BA9524898F4AC52FEBB3F3F48198 * __this, RuntimeObject * ___key0, RuntimeObject ** ___value1, const RuntimeMethod* method);
// System.Int32 System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>::get_Count()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ConcurrentDictionary_2_get_Count_mDF3291BC1AE43A7122384C4795ACA565A35A3A16_gshared (ConcurrentDictionary_2_t089158EC5B60BA9524898F4AC52FEBB3F3F48198 * __this, const RuntimeMethod* method);
// !1 System.Collections.Concurrent.ConcurrentDictionary`2<System.Object,System.Object>::GetOrAdd(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * ConcurrentDictionary_2_GetOrAdd_m9BDA73F932E961A14BAE7B71565B3722590D171C_gshared (ConcurrentDictionary_2_t089158EC5B60BA9524898F4AC52FEBB3F3F48198 * __this, RuntimeObject * ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Object>::ContainsKey(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_ContainsKey_m4F01DBE7409811CAB0BBA7AEFBAB4BC028D26FA6_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::set_Item(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_mE6BF870B04922441F9F2760E782DEE6EE682615A_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::Add(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_Add_m830DC29CD6F7128D4990D460CCCDE032E3B693D9_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// !1 System.Collections.Generic.Dictionary`2<System.Object,System.Object>::get_Item(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Dictionary_2_get_Item_mB1398A10D048A0246178C59F95003BD338CE7394_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// System.Void System.Threading.Tasks.TaskCompletionSource`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TaskCompletionSource_1__ctor_m93D38CA57B11BA7F5B3E7ED1E573E2F0249E44BB_gshared (TaskCompletionSource_1_t5B48A13B0469AA5A5797B645926E284436099903 * __this, const RuntimeMethod* method);
// System.Void System.Action`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1__ctor_mA671E933C9D3DAE4E3F71D34FDDA971739618158_gshared (Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Threading.Tasks.Task`1<!0> System.Threading.Tasks.TaskCompletionSource`1<System.Object>::get_Task()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * TaskCompletionSource_1_get_Task_m7F788C2231343328FBBCFE9EDA916E748F699618_gshared_inline (TaskCompletionSource_1_t5B48A13B0469AA5A5797B645926E284436099903 * __this, const RuntimeMethod* method);
// T TapTap.Common.SafeDictionary::GetValue<System.Int32>(System.Collections.Generic.Dictionary`2<System.String,System.Object>,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SafeDictionary_GetValue_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mFA70C2F966B05DCEEE7BDCAF44C103BBFC73ED8B_gshared (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___dic0, String_t* ___key1, const RuntimeMethod* method);
// T TapTap.Common.SafeDictionary::GetValue<System.Object>(System.Collections.Generic.Dictionary`2<System.String,System.Object>,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * SafeDictionary_GetValue_TisRuntimeObject_mC1792116A1E5A9C7020C59B9FC0845A46A53E29D_gshared (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___dic0, String_t* ___key1, const RuntimeMethod* method);
// !0 System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>::get_Key()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * KeyValuePair_2_get_Key_mCAD7B121DB998D7C56EB0281215A860EFE9DCD95_gshared_inline (KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625 * __this, const RuntimeMethod* method);
// !1 System.Collections.Generic.KeyValuePair`2<System.Object,System.Object>::get_Value()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * KeyValuePair_2_get_Value_m622223593F7461E7812C581DDB145270016ED303_gshared_inline (KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625 * __this, const RuntimeMethod* method);
// !!0[] System.Linq.Enumerable::ToArray<System.Object>(System.Collections.Generic.IEnumerable`1<!!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Enumerable_ToArray_TisRuntimeObject_m21E15191FE8BDBAE753CC592A1DB55EA3BCE7B5B_gshared (RuntimeObject* ___source0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Void System.Action`2<System.Int32Enum,System.Object>::Invoke(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_2_Invoke_m152C98E120D38857ED1464915833AAE22C0812B5_gshared (Action_2_tAEEAE0CA76819C6105A7D08A17A11166D3071492 * __this, int32_t ___arg10, RuntimeObject * ___arg21, const RuntimeMethod* method);
// System.Boolean System.Threading.Tasks.TaskCompletionSource`1<System.Object>::TrySetResult(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TaskCompletionSource_1_TrySetResult_m3EE8E1110E0E022021CDBF4CA6C7485EAFD17E71_gshared (TaskCompletionSource_1_t5B48A13B0469AA5A5797B645926E284436099903 * __this, RuntimeObject * ___result0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);

// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void UnityEngine.AndroidJavaClass::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJavaClass__ctor_mEFF9F51871F231955D97DABDE9AB4A6B4EDA5541 (AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * __this, String_t* ___className0, const RuntimeMethod* method);
// !!0 UnityEngine.AndroidJavaObject::GetStatic<UnityEngine.AndroidJavaObject>(System.String)
inline AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * AndroidJavaObject_GetStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mC84C97A7EC20ED712D21107C9FA32E0785021153 (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * __this, String_t* ___fieldName0, const RuntimeMethod* method)
{
	return ((  AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * (*) (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *, String_t*, const RuntimeMethod*))AndroidJavaObject_GetStatic_TisRuntimeObject_mEC743ECF275CB896DE039A9FC1E5672B30C8B3D0_gshared)(__this, ___fieldName0, method);
}
// !!0[] System.Array::Empty<System.Object>()
inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_inline (const RuntimeMethod* method)
{
	return ((  ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* (*) (const RuntimeMethod*))Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline)(method);
}
// !!0 UnityEngine.AndroidJavaObject::CallStatic<UnityEngine.AndroidJavaObject>(System.String,System.Object[])
inline AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * AndroidJavaObject_CallStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mAD48C38D66AB67D0F0274D195F4A99CB7AB589F2 (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * __this, String_t* ___methodName0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method)
{
	return ((  AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * (*) (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *, String_t*, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, const RuntimeMethod*))AndroidJavaObject_CallStatic_TisRuntimeObject_m29BD05B7A29F937D71B746DFFE889B90E1142509_gshared)(__this, ___methodName0, ___args1, method);
}
// System.Void UnityEngine.AndroidJavaObject::Call(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJavaObject_Call_mBB226DA52CE5A2FCD9A2D42BC7FB4272E094B76D (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * __this, String_t* ___methodName0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method);
// System.Void UnityEngine.AndroidJavaObject::.ctor(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJavaObject__ctor_m6146DBD19BCFFDB3D4F42C8D38491F354B58B001 (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * __this, String_t* ___className0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.String TapTap.Common.Command::ToJSON()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Command_ToJSON_m72C0199077CB83B769023C33665380DBF6F8890C (Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * __this, const RuntimeMethod* method);
// System.Void TapTap.Common.BridgeCallback::.ctor(System.Action`1<TapTap.Common.Result>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeCallback__ctor_mD5E82AAF1D3FDBC8120AD9C1CC7CA5DEEDB0438A (BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707 * __this, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ___action0, const RuntimeMethod* method);
// System.Void TapTap.Common.BridgeAndroid::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeAndroid__ctor_mC095A76530DC28ED03819CA8C5CB6E107CBF6277 (BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * __this, const RuntimeMethod* method);
// System.Void UnityEngine.AndroidJavaProxy::.ctor(UnityEngine.AndroidJavaClass)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AndroidJavaProxy__ctor_m17BDD42A24CEBD07722B68A25CAD6DEAF64241E1 (AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF * __this, AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * ___javaInterface0, const RuntimeMethod* method);
// System.Boolean System.String::Equals(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_Equals_m8A062B96B61A7D652E7D73C9B3E904F6B0E5F41D (String_t* __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void TapTap.Common.Result::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Result__ctor_m681484DE5A13EFE6F4E971E9F22FAC7941100226 (Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * __this, String_t* ___json0, const RuntimeMethod* method);
// System.Void System.Action`1<TapTap.Common.Result>::Invoke(!0)
inline void Action_1_Invoke_m30BB8E391F85895D3CDED6D834FF6F350978FABD (Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * __this, Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 *, Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 *, const RuntimeMethod*))Action_1_Invoke_m587509C88BB83721D7918D89DF07606BB752D744_gshared)(__this, ___obj0, method);
}
// System.Void TapTap.Common.BridgeIOS::engineBridgeDelegate(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_engineBridgeDelegate_m8912905FBDD43922D6F2D45405C1CF03F884F8F6 (String_t* ___resultJson0, const RuntimeMethod* method);
// System.Void System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>>::.ctor()
inline void ConcurrentDictionary_2__ctor_m61593A6F8DCC9B835A9162D9A41E933C6AC0C511 (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * __this, const RuntimeMethod* method)
{
	((  void (*) (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 *, const RuntimeMethod*))ConcurrentDictionary_2__ctor_m0A46F1D3CDFD063E9561E0B23D2BA32B895CD1AD_gshared)(__this, method);
}
// TapTap.Common.BridgeIOS TapTap.Common.BridgeIOS::GetInstance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * BridgeIOS_GetInstance_m49697C9E7289F0A8CC539CA19A5F2A1C272B7C8C (const RuntimeMethod* method);
// System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>> TapTap.Common.BridgeIOS::GetConcurrentDictionary()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * BridgeIOS_GetConcurrentDictionary_m6CB5A2530F785096F3D03A935C215BB7A1023957 (BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>>::ContainsKey(!0)
inline bool ConcurrentDictionary_2_ContainsKey_m3977DBC42CD0D3E6EF36F9249D00F1940D22C3E3 (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 *, String_t*, const RuntimeMethod*))ConcurrentDictionary_2_ContainsKey_m1BACEC1E10E3A457AC9CCB90D6BA07BF197B447A_gshared)(__this, ___key0, method);
}
// !1 System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>>::get_Item(!0)
inline Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ConcurrentDictionary_2_get_Item_mA417BF88EF46098F3A761B0C74BF477F35BA8086 (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * (*) (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 *, String_t*, const RuntimeMethod*))ConcurrentDictionary_2_get_Item_m59F8F360E1831F72953AFFFA11CB69909D846D00_gshared)(__this, ___key0, method);
}
// System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>>::TryRemove(!0,!1&)
inline bool ConcurrentDictionary_2_TryRemove_m9AF2612953577A6707762B06C82DE81718183E5D (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * __this, String_t* ___key0, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 ** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 *, String_t*, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 **, const RuntimeMethod*))ConcurrentDictionary_2_TryRemove_mE9378B3DDFBD3CCE02CB8862DD35BEB41A5819F6_gshared)(__this, ___key0, ___value1, method);
}
// System.Int32 System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>>::get_Count()
inline int32_t ConcurrentDictionary_2_get_Count_m909ED40578105FB6817240D4E5B7DE0594CF47FF (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 *, const RuntimeMethod*))ConcurrentDictionary_2_get_Count_mDF3291BC1AE43A7122384C4795ACA565A35A3A16_gshared)(__this, method);
}
// System.String System.String::Format(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17 (String_t* ___format0, RuntimeObject * ___arg01, const RuntimeMethod* method);
// System.Void TapTap.Common.BridgeIOS::callHandler(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_callHandler_mC75DE5396D98B4D419EC8C8AF6FD43AF6C06E7DB (String_t* ___command0, const RuntimeMethod* method);
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C (String_t* ___value0, const RuntimeMethod* method);
// !1 System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>>::GetOrAdd(!0,!1)
inline Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ConcurrentDictionary_2_GetOrAdd_m6D452307EA9EB2FFC8D778A35E994D27BB6E22F3 (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * __this, String_t* ___key0, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ___value1, const RuntimeMethod* method)
{
	return ((  Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * (*) (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 *, String_t*, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 *, const RuntimeMethod*))ConcurrentDictionary_2_GetOrAdd_m9BDA73F932E961A14BAE7B71565B3722590D171C_gshared)(__this, ___key0, ___value1, method);
}
// System.Void TapTap.Common.BridgeIOS/EngineBridgeDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridgeDelegate__ctor_m0EBCEB007E06DD216B729E56DD960FACFCC9D76C (EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Void TapTap.Common.BridgeIOS::registerHandler(System.String,TapTap.Common.BridgeIOS/EngineBridgeDelegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_registerHandler_m8B0FF715CD8E84FF1C4A0F331F087EE369686C86 (String_t* ___command0, EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * ___engineBridgeDelegate1, const RuntimeMethod* method);
// System.Void TapTap.Common.BridgeIOS::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS__ctor_m3F6A9664C063DFD3E9D5C5DBBF44CC16BA96F4A7 (BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * __this, const RuntimeMethod* method);
// System.String UnityEngine.JsonUtility::ToJson(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* JsonUtility_ToJson_mF4F097C9AEC7699970E3E7E99EF8FF2F44DA1B5C (RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.String TapTap.Common.Json::Serialize(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Json_Serialize_m03AB6071E9A0A5D7197D2BA15B8E265D0876BC52 (RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.String TapTap.Common.TapUUID::UUID()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TapUUID_UUID_m34CD600BDA5D524CD97F2C290CF4FFBCBF7C950D (const RuntimeMethod* method);
// System.Void TapTap.Common.DataStorage::SaveStringToCache(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DataStorage_SaveStringToCache_m40F7AB84CB9C9F01A90435C8ABB1B3A9630CD512 (String_t* ___key0, String_t* ___value1, const RuntimeMethod* method);
// System.String TapTap.Common.DataStorage::EncodeString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_EncodeString_m48C0DF4E507E1EAA45A1D2A824AB10AAF6C9EA47 (String_t* ___encryptString0, const RuntimeMethod* method);
// System.Void UnityEngine.PlayerPrefs::SetString(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlayerPrefs_SetString_m94CD8FF45692553A5726DFADF74935F7E1D1C633 (String_t* ___key0, String_t* ___value1, const RuntimeMethod* method);
// System.String TapTap.Common.DataStorage::LoadStringFromCache(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_LoadStringFromCache_mAA04953F7EBDEC52C0329FAB2E06FE3C13D11DE4 (String_t* ___key0, const RuntimeMethod* method);
// System.Boolean UnityEngine.PlayerPrefs::HasKey(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayerPrefs_HasKey_m48BE5886380B51AB495B91C9A26115B7CB958A92 (String_t* ___key0, const RuntimeMethod* method);
// System.String UnityEngine.PlayerPrefs::GetString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PlayerPrefs_GetString_mE7654C1031622A56CD8F248F53714B105A35A159 (String_t* ___key0, const RuntimeMethod* method);
// System.String TapTap.Common.DataStorage::DecodeString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_DecodeString_m1C0A2E06114479AD5674E97026863F3AFF032C64 (String_t* ___decryptString0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.String>::.ctor()
inline void Dictionary_2__ctor_mA6747E78BD4DF1D09D9091C1B3EBAE0FDB200666 (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *, const RuntimeMethod*))Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared)(__this, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,System.String>::ContainsKey(!0)
inline bool Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027 (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *, String_t*, const RuntimeMethod*))Dictionary_2_ContainsKey_m4F01DBE7409811CAB0BBA7AEFBAB4BC028D26FA6_gshared)(__this, ___key0, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.String>::set_Item(!0,!1)
inline void Dictionary_2_set_Item_m31C41E4FE938066440DAFD1E667C2F3986549668 (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * __this, String_t* ___key0, String_t* ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *, String_t*, String_t*, const RuntimeMethod*))Dictionary_2_set_Item_mE6BF870B04922441F9F2760E782DEE6EE682615A_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.String>::Add(!0,!1)
inline void Dictionary_2_Add_mE0EF428186E444BFEAD18AC6810D423EEABB3F92 (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * __this, String_t* ___key0, String_t* ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *, String_t*, String_t*, const RuntimeMethod*))Dictionary_2_Add_m830DC29CD6F7128D4990D460CCCDE032E3B693D9_gshared)(__this, ___key0, ___value1, method);
}
// !1 System.Collections.Generic.Dictionary`2<System.String,System.String>::get_Item(!0)
inline String_t* Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141 (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  String_t* (*) (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *, String_t*, const RuntimeMethod*))Dictionary_2_get_Item_mB1398A10D048A0246178C59F95003BD338CE7394_gshared)(__this, ___key0, method);
}
// System.Boolean TapTap.Common.Platform::IsAndroid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Platform_IsAndroid_m3A9B875D7C3220A474C32E883D3FEF629E1105C0 (const RuntimeMethod* method);
// System.Boolean TapTap.Common.Platform::IsIOS()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Platform_IsIOS_m86A73A9650A84E8AAC86F9EE18B6954A75A6D6C4 (const RuntimeMethod* method);
// System.Text.Encoding System.Text.Encoding::get_UTF8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E (const RuntimeMethod* method);
// System.String TapTap.Common.DataStorage::GetMacAddress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_GetMacAddress_m48AD5D8EAA598DD27855E4858E78265E1151C11D (const RuntimeMethod* method);
// System.String System.String::Substring(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B (String_t* __this, int32_t ___startIndex0, int32_t ___length1, const RuntimeMethod* method);
// System.Void System.Security.Cryptography.DESCryptoServiceProvider::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DESCryptoServiceProvider__ctor_m7AD8E1619BAA1EBC6FA81C815FA6D2786AA232F9 (DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 * __this, const RuntimeMethod* method);
// System.Void System.IO.MemoryStream::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MemoryStream__ctor_mD27B3DF2400D46A4A81EE78B0BD2C29EFCFAA44F (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * __this, const RuntimeMethod* method);
// System.Void System.Security.Cryptography.CryptoStream::.ctor(System.IO.Stream,System.Security.Cryptography.ICryptoTransform,System.Security.Cryptography.CryptoStreamMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CryptoStream__ctor_m690A130C7B6793E8D752DD3017419FFB12A0DBAE (CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___stream0, RuntimeObject* ___transform1, int32_t ___mode2, const RuntimeMethod* method);
// System.Void System.Security.Cryptography.CryptoStream::FlushFinalBlock()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CryptoStream_FlushFinalBlock_m7649E736DC0B525D9812EC018E2D74244DDF5891 (CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * __this, const RuntimeMethod* method);
// System.String System.Convert::ToBase64String(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Convert_ToBase64String_mE6E1FE504EF1E99DB2F8B92180A82A5F1512EF6A (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___inArray0, const RuntimeMethod* method);
// System.Byte[] System.Convert::FromBase64String(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* Convert_FromBase64String_mB2E4E2CD03B34DB7C2665694D5B2E967BC81E9A8 (String_t* ___s0, const RuntimeMethod* method);
// System.Net.NetworkInformation.NetworkInterface[] System.Net.NetworkInformation.NetworkInterface::GetAllNetworkInterfaces()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC* NetworkInterface_GetAllNetworkInterfaces_mC0EF91AC837841CDC0ED9E040745F215079235B1 (const RuntimeMethod* method);
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method);
// System.Boolean System.String::op_Inequality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Inequality_mDDA2DDED3E7EF042987EB7180EE3E88105F0AAE2 (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeHelpers::InitializeArray(System.Array,System.RuntimeFieldHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeHelpers_InitializeArray_mE27238308FED781F2D6A719F0903F2E1311B058F (RuntimeArray * ___array0, RuntimeFieldHandle_t7BE65FC857501059EBAC9772C93B02CD413D9C96  ___fldHandle1, const RuntimeMethod* method);
// System.Void System.Threading.Monitor::Enter(System.Object,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4 (RuntimeObject * ___obj0, bool* ___lockTaken1, const RuntimeMethod* method);
// System.Void TapTap.Common.EngineBridge::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridge__ctor_mE1570C0E6D3CC96E5F18CF4809B014CC6F49082F (EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * __this, const RuntimeMethod* method);
// System.Void System.Threading.Monitor::Exit(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A (RuntimeObject * ___obj0, const RuntimeMethod* method);
// TapTap.Common.BridgeAndroid TapTap.Common.BridgeAndroid::GetInstance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * BridgeAndroid_GetInstance_mBAC5D6916DDC204635DFE9828F23866E00D40514 (const RuntimeMethod* method);
// System.Void TapTap.Common.EngineBridge/<>c__DisplayClass8_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass8_0__ctor_m3789C85E5AEDAEDA6059CEC611EA642F9C643B0E (U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 * __this, const RuntimeMethod* method);
// System.Void System.Threading.Tasks.TaskCompletionSource`1<TapTap.Common.Result>::.ctor()
inline void TaskCompletionSource_1__ctor_m41DCCC9230519818D858BF703C08AB243D898FF1 (TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * __this, const RuntimeMethod* method)
{
	((  void (*) (TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD *, const RuntimeMethod*))TaskCompletionSource_1__ctor_m93D38CA57B11BA7F5B3E7ED1E573E2F0249E44BB_gshared)(__this, method);
}
// System.Void System.Action`1<TapTap.Common.Result>::.ctor(System.Object,System.IntPtr)
inline void Action_1__ctor_m8A52A1E69EBA2DC131EC8543DE12B9F4E512B4BE (Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 *, RuntimeObject *, intptr_t, const RuntimeMethod*))Action_1__ctor_mA671E933C9D3DAE4E3F71D34FDDA971739618158_gshared)(__this, ___object0, ___method1, method);
}
// System.Void TapTap.Common.EngineBridge::CallHandler(TapTap.Common.Command,System.Action`1<TapTap.Common.Result>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridge_CallHandler_mECD83678524CBC1B7B4397C5833F0F7C6AD07603 (EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * __this, Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * ___command0, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ___action1, const RuntimeMethod* method);
// System.Threading.Tasks.Task`1<!0> System.Threading.Tasks.TaskCompletionSource`1<TapTap.Common.Result>::get_Task()
inline Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * TaskCompletionSource_1_get_Task_mC18B68B47AD86B33CD5C42F8D2FE3EAA338B825E_inline (TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * __this, const RuntimeMethod* method)
{
	return ((  Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * (*) (TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD *, const RuntimeMethod*))TaskCompletionSource_1_get_Task_m7F788C2231343328FBBCFE9EDA916E748F699618_gshared_inline)(__this, method);
}
// System.Object TapTap.Common.Json/Parser::Parse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Parser_Parse_m46AC1CDBD66E06E4D59D3960B11D2FEC4C49CE48 (String_t* ___jsonString0, const RuntimeMethod* method);
// System.String TapTap.Common.Json/Serializer::Serialize(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Serializer_Serialize_mB98039BD7C2A49AAAB1C2EC7829E8453F751EB9D (RuntimeObject * ___obj0, const RuntimeMethod* method);
// UnityEngine.RuntimePlatform UnityEngine.Application::get_platform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Application_get_platform_mB22F7F39CDD46667C3EF64507E55BB7DA18F66C4 (const RuntimeMethod* method);
// System.Void UnityEngine.JsonUtility::FromJsonOverwrite(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JsonUtility_FromJsonOverwrite_mC97C7C909591A29E72361FB5DBC1A58EEE6DBAEB (String_t* ___json0, RuntimeObject * ___objectToOverwrite1, const RuntimeMethod* method);
// System.Object TapTap.Common.Json::Deserialize(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Json_Deserialize_m2CF4D537FF2ABA72BB3186ED220ED27EB064BCA7 (String_t* ___json0, const RuntimeMethod* method);
// T TapTap.Common.SafeDictionary::GetValue<System.Int32>(System.Collections.Generic.Dictionary`2<System.String,System.Object>,System.String)
inline int32_t SafeDictionary_GetValue_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mFA70C2F966B05DCEEE7BDCAF44C103BBFC73ED8B (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___dic0, String_t* ___key1, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, String_t*, const RuntimeMethod*))SafeDictionary_GetValue_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mFA70C2F966B05DCEEE7BDCAF44C103BBFC73ED8B_gshared)(___dic0, ___key1, method);
}
// T TapTap.Common.SafeDictionary::GetValue<System.String>(System.Collections.Generic.Dictionary`2<System.String,System.Object>,System.String)
inline String_t* SafeDictionary_GetValue_TisString_t_m97A16243B1B7E0B8CFD8D82AADFFE856B1EFC47C (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___dic0, String_t* ___key1, const RuntimeMethod* method)
{
	return ((  String_t* (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, String_t*, const RuntimeMethod*))SafeDictionary_GetValue_TisRuntimeObject_mC1792116A1E5A9C7020C59B9FC0845A46A53E29D_gshared)(___dic0, ___key1, method);
}
// System.Void TapTap.Common.TapError::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapError__ctor_mC8CCC8EB504990561D0DCACA4E864A26DDBF8CBA (TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 * __this, String_t* ___json0, const RuntimeMethod* method);
// System.Void System.Exception::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11 (Exception_t * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Action`2<TapTap.Common.TapLogLevel,System.String> TapTap.Common.TapLogger::get_LogDelegate()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * TapLogger_get_LogDelegate_m6B310D3CB95664848307AD22C45493437991A979_inline (const RuntimeMethod* method);
// System.Void System.Text.StringBuilder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9 (StringBuilder_t * __this, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::AppendLine(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8 (StringBuilder_t * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Uri System.Net.Http.HttpRequestMessage::get_RequestUri()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * HttpRequestMessage_get_RequestUri_mB0637CC446DFCB403DC4C36781474AC9C3556DDB_inline (HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * __this, const RuntimeMethod* method);
// System.Net.Http.HttpMethod System.Net.Http.HttpRequestMessage::get_Method()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * HttpRequestMessage_get_Method_m827225A7FD4B30107C4191325DA6762D6C3469BD_inline (HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * __this, const RuntimeMethod* method);
// System.Net.Http.Headers.HttpRequestHeaders System.Net.Http.HttpClient::get_DefaultRequestHeaders()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * HttpClient_get_DefaultRequestHeaders_mD6D9E9E7568F26ED379CD2F7437FC7FACB73C18B (HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20 * __this, const RuntimeMethod* method);
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.IEnumerable`1<System.String>>> System.Net.Http.Headers.HttpHeaders::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* HttpHeaders_GetEnumerator_mFD5B6A73715C23D6998176EB6BCBDB5B6AD40CB3 (HttpHeaders_t975DBB16F39167BE91FF1BEC325EB4F4471996D2 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.IEnumerable`1<System.String>>::get_Key()
inline String_t* KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_inline (KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 * __this, const RuntimeMethod* method)
{
	return ((  String_t* (*) (KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 *, const RuntimeMethod*))KeyValuePair_2_get_Key_mCAD7B121DB998D7C56EB0281215A860EFE9DCD95_gshared_inline)(__this, method);
}
// !1 System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.IEnumerable`1<System.String>>::get_Value()
inline RuntimeObject* KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_inline (KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 * __this, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 *, const RuntimeMethod*))KeyValuePair_2_get_Value_m622223593F7461E7812C581DDB145270016ED303_gshared_inline)(__this, method);
}
// !!0[] System.Linq.Enumerable::ToArray<System.String>(System.Collections.Generic.IEnumerable`1<!!0>)
inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582 (RuntimeObject* ___source0, const RuntimeMethod* method)
{
	return ((  StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* (*) (RuntimeObject*, const RuntimeMethod*))Enumerable_ToArray_TisRuntimeObject_m21E15191FE8BDBAE753CC592A1DB55EA3BCE7B5B_gshared)(___source0, method);
}
// System.String System.String::Join(System.String,System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Join_m8846EB11F0A221BDE237DE041D17764B36065404 (String_t* ___separator0, StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___value1, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78 (String_t* ___str00, String_t* ___str11, String_t* ___str22, String_t* ___str33, const RuntimeMethod* method);
// System.Net.Http.Headers.HttpRequestHeaders System.Net.Http.HttpRequestMessage::get_Headers()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * HttpRequestMessage_get_Headers_m177A5885B3271A1B8F03DB145DBE32CC5E837063 (HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * __this, const RuntimeMethod* method);
// System.Net.Http.HttpContent System.Net.Http.HttpRequestMessage::get_Content()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * HttpRequestMessage_get_Content_mCD96F88223EA230AC47CC295A00574F52582D0D4_inline (HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * __this, const RuntimeMethod* method);
// System.Net.Http.Headers.HttpContentHeaders System.Net.Http.HttpContent::get_Headers()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573 * HttpContent_get_Headers_m8EA225DA03A60734A63156D7EA6AC36228F953E9 (HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * __this, const RuntimeMethod* method);
// System.Void TapTap.Common.TapLogger::Debug(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLogger_Debug_m92BE9D78969DA2AD33F1C88683F5BE1327285C54 (String_t* ___log0, const RuntimeMethod* method);
// System.Net.Http.HttpRequestMessage System.Net.Http.HttpResponseMessage::get_RequestMessage()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * HttpResponseMessage_get_RequestMessage_m1AADFCBFE233491EC18E65D6342833A1CEB52486_inline (HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752 * __this, const RuntimeMethod* method);
// System.Net.HttpStatusCode System.Net.Http.HttpResponseMessage::get_StatusCode()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t HttpResponseMessage_get_StatusCode_m566EA4F3B9AF052B4A59C34F51191B926BFED7CB_inline (HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752 * __this, const RuntimeMethod* method);
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E (RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ___handle0, const RuntimeMethod* method);
// System.Boolean System.Type::op_Equality(System.Type,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Type_op_Equality_mA438719A1FDF103C7BBBB08AEF564E7FAEEA0046 (Type_t * ___left0, Type_t * ___right1, const RuntimeMethod* method);
// System.Void LC.Newtonsoft.Json.JsonSerializer::Serialize(LC.Newtonsoft.Json.JsonWriter,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JsonSerializer_Serialize_mE7CF8F2F57FFCE3531DE957D8DF5F4BE3BD09052 (JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * __this, JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008 * ___jsonWriter0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Object>::.ctor()
inline void Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63 (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, const RuntimeMethod*))Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared)(__this, method);
}
// System.Void LC.Newtonsoft.Json.JsonSerializer::Populate(LC.Newtonsoft.Json.JsonReader,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JsonSerializer_Populate_m017C22B05AB4B0C5F938F2DA1ED01690491D6E5B (JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * __this, JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * ___reader0, RuntimeObject * ___target1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
inline void List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// System.Int32 System.Convert::ToInt32(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Convert_ToInt32_mFFEDED67681E3EC8705BCA890BBC206514431B4A (RuntimeObject * ___value0, const RuntimeMethod* method);
// System.Single System.Convert::ToSingle(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Convert_ToSingle_m40AEA5CD6F34773800A3A7CD0A132170315E75CC (RuntimeObject * ___value0, const RuntimeMethod* method);
// System.Object LC.Newtonsoft.Json.JsonSerializer::Deserialize(LC.Newtonsoft.Json.JsonReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * JsonSerializer_Deserialize_m34720808B03856029E60204E77B838C0EF5FF595 (JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * __this, JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * ___reader0, const RuntimeMethod* method);
// System.Void LC.Newtonsoft.Json.JsonConverter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void JsonConverter__ctor_m865BB71241002EC00FFF45238EAFD5302166B392 (JsonConverter_tB733E18F5460B16D7D15AEC1D601BFBDA786CF5F * __this, const RuntimeMethod* method);
// System.Void TapTap.Common.Internal.Json.TapJsonConverter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapJsonConverter__ctor_m1CA0A7FCF378BD5B9EA4C933698D3DCC122E44B4 (TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * __this, const RuntimeMethod* method);
// System.Void TapTap.Common.TapLocalizeManager::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLocalizeManager__ctor_mF53DFDD8735EE593E256BDECE3A8540BB8D2453C (TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * __this, const RuntimeMethod* method);
// TapTap.Common.TapLocalizeManager TapTap.Common.TapLocalizeManager::get_Instance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA (const RuntimeMethod* method);
// TapTap.Common.TapLanguage TapTap.Common.TapLocalizeManager::GetSystemLanguage()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TapLocalizeManager_GetSystemLanguage_mFD1419920E599645E6B260B696F779A1394CABBE (const RuntimeMethod* method);
// UnityEngine.SystemLanguage UnityEngine.Application::get_systemLanguage()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Application_get_systemLanguage_m97271242ECD614FD02DC6BEB912CDDB6DD2BD045 (const RuntimeMethod* method);
// System.Void System.Action`2<TapTap.Common.TapLogLevel,System.String>::Invoke(!0,!1)
inline void Action_2_Invoke_mAD6B0F23BFA144D866A6A4196D5E1A19CA8A8E4F (Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * __this, int32_t ___arg10, String_t* ___arg21, const RuntimeMethod* method)
{
	((  void (*) (Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 *, int32_t, String_t*, const RuntimeMethod*))Action_2_Invoke_m152C98E120D38857ED1464915833AAE22C0812B5_gshared)(__this, ___arg10, ___arg21, method);
}
// System.Type System.Exception::GetType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Exception_GetType_mC5B8B5C944B326B751282AB0E8C25A7F85457D9F (Exception_t * __this, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_m545FFB72A578320B1D6EA3772160353FD62C344F (StringBuilder_t * __this, RuntimeObject * ___value0, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1 (StringBuilder_t * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void TapTap.Common.TapLogger::Error(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLogger_Error_mCBD3898C4A66F803A9565DAF768275BD41E67F2D (String_t* ___log0, const RuntimeMethod* method);
// System.Guid System.Guid::NewGuid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Guid_t  Guid_NewGuid_m5BD19325820690ED6ECA31D67BC2CD474DC4FDB0 (const RuntimeMethod* method);
// System.String System.Guid::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Guid_ToString_mA3AB7742FB0E04808F580868E82BDEB93187FB75 (Guid_t * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Object>::Add(!0,!1)
inline void Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, String_t* ___key0, RuntimeObject * ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, String_t*, RuntimeObject *, const RuntimeMethod*))Dictionary_2_Add_m830DC29CD6F7128D4990D460CCCDE032E3B693D9_gshared)(__this, ___key0, ___value1, method);
}
// System.Void TapTap.Common.Command::.ctor(System.String,System.String,System.Boolean,System.Boolean,System.Collections.Generic.Dictionary`2<System.String,System.Object>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Command__ctor_m1DAC8B23A51DDB3A89F453F7C5C31128092F77C6 (Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * __this, String_t* ___service0, String_t* ___method1, bool ___callback2, bool ___onceTime3, Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___dic4, const RuntimeMethod* method);
// System.Boolean System.Threading.Tasks.TaskCompletionSource`1<TapTap.Common.Result>::TrySetResult(!0)
inline bool TaskCompletionSource_1_TrySetResult_m1264FCCE9A651BCB44E85D04CDA6A0AA97213617 (TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * __this, Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * ___result0, const RuntimeMethod* method)
{
	return ((  bool (*) (TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD *, Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 *, const RuntimeMethod*))TaskCompletionSource_1_TrySetResult_m3EE8E1110E0E022021CDBF4CA6C7485EAFD17E71_gshared)(__this, ___result0, method);
}
// System.Boolean System.Char::IsWhiteSpace(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Char_IsWhiteSpace_m99A5E1BE1EB9F17EA530A67A607DA8C260BCBF99 (Il2CppChar ___c0, const RuntimeMethod* method);
// System.Int32 System.String::IndexOf(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t String_IndexOf_mEE2D2F738175E3FF05580366D6226DBD673CA2BE (String_t* __this, Il2CppChar ___value0, const RuntimeMethod* method);
// System.Void System.IO.StringReader::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringReader__ctor_m7CC29D8E83F4813395ACA9CF4F756B1BCE09A7EE (StringReader_t74E352C280EAC22C878867444978741F19E1F895 * __this, String_t* ___s0, const RuntimeMethod* method);
// System.Void TapTap.Common.Json/Parser::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Parser__ctor_m052C8B1064670BDC8E0BB727AD912A3B8C3C1471 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, String_t* ___jsonString0, const RuntimeMethod* method);
// System.Object TapTap.Common.Json/Parser::ParseValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Parser_ParseValue_m35E0DDD3CA3D27BC78C0CDFB54E9872785DD397E (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Void System.IO.TextReader::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextReader_Dispose_mDF1DCFD8FBE94A453EB2350DB7173027420BA5F8 (TextReader_t25B06DCA1906FEAD02150DB14313EBEA4CD78D2F * __this, const RuntimeMethod* method);
// TapTap.Common.Json/Parser/TOKEN TapTap.Common.Json/Parser::get_NextToken()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Parser_get_NextToken_mCBD3F9B6662AB0DC77185218951C8623FF282405 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.String TapTap.Common.Json/Parser::ParseString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Parser_ParseString_mEFF1C4BBBB803714FFCB44377136BE72B3E0355C (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Object>::set_Item(!0,!1)
inline void Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9 (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, String_t* ___key0, RuntimeObject * ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, String_t*, RuntimeObject *, const RuntimeMethod*))Dictionary_2_set_Item_mE6BF870B04922441F9F2760E782DEE6EE682615A_gshared)(__this, ___key0, ___value1, method);
}
// System.Object TapTap.Common.Json/Parser::ParseByToken(TapTap.Common.Json/Parser/TOKEN)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Parser_ParseByToken_m2AFE2F814ACDE57A13629A5C093B246930FAEFA5 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, int32_t ___token0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
inline void List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *, RuntimeObject *, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// System.Object TapTap.Common.Json/Parser::ParseNumber()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Parser_ParseNumber_m074FC2EAA5E2210753B0316E717DD3A233AD8F84 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Collections.Generic.Dictionary`2<System.String,System.Object> TapTap.Common.Json/Parser::ParseObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * Parser_ParseObject_m5147F50A110505C2CD5AD854675696D8A6D0B001 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Collections.Generic.List`1<System.Object> TapTap.Common.Json/Parser::ParseArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * Parser_ParseArray_mF250A9E2EF06B5AE4D36BA5113D656A8BAD9F93B (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Char TapTap.Common.Json/Parser::get_NextChar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar Parser_get_NextChar_m5A3A3E1D76F4325B5ED87B1B94C23AB9AE7EF504 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E (StringBuilder_t * __this, Il2CppChar ___value0, const RuntimeMethod* method);
// System.String System.String::CreateString(System.Char[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_CreateString_mC7F57CE6ED768CF86591160424FE55D5CBA7C344 (String_t* __this, CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___val0, const RuntimeMethod* method);
// System.Int32 System.Convert::ToInt32(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Convert_ToInt32_m21526761291049AC762DEAEA073870C8A8583643 (String_t* ___value0, int32_t ___fromBase1, const RuntimeMethod* method);
// System.String TapTap.Common.Json/Parser::get_NextWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Parser_get_NextWord_m1D1FF72DD230327577C630E35432A7D37C595D75 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Globalization.CultureInfo System.Globalization.CultureInfo::get_InvariantCulture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164 (const RuntimeMethod* method);
// System.Boolean System.Int64::TryParse(System.String,System.Globalization.NumberStyles,System.IFormatProvider,System.Int64&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Int64_TryParse_m4A94015941D9BD9F9304D1FE14F17E84BFD3B69A (String_t* ___s0, int32_t ___style1, RuntimeObject* ___provider2, int64_t* ___result3, const RuntimeMethod* method);
// System.Boolean System.Double::TryParse(System.String,System.Globalization.NumberStyles,System.IFormatProvider,System.Double&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Double_TryParse_mE740D7083AC52793A9634067C4F032570FFBF61E (String_t* ___s0, int32_t ___style1, RuntimeObject* ___provider2, double* ___result3, const RuntimeMethod* method);
// System.Char TapTap.Common.Json/Parser::get_PeekChar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar Parser_get_PeekChar_m2D89A315D53EFDB8138DCD5289F9F02A2DE8B7B0 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Char System.Convert::ToChar(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar Convert_ToChar_m84E3CF47987D8B6F2D889D957CBFB5FD55F3DAEC (int32_t ___value0, const RuntimeMethod* method);
// System.Boolean TapTap.Common.Json/Parser::IsWordBreak(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Parser_IsWordBreak_mFC882BE0A768B902C6EEEC33AFE5646268F85095 (Il2CppChar ___c0, const RuntimeMethod* method);
// System.Void TapTap.Common.Json/Parser::EatWhitespace()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Parser_EatWhitespace_m9F8B40C77F3736E1558D508C7FB4AF838AFCDEF9 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method);
// System.Void TapTap.Common.Json/Serializer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer__ctor_mB70FBB4EEF8CFEF8D45D208791081F15F29A7320 (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, const RuntimeMethod* method);
// System.Void TapTap.Common.Json/Serializer::SerializeValue(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeValue_m39E6FC75FE6CC56DD6656AF3CFE953B4A2847FDC (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, RuntimeObject * ___value0, const RuntimeMethod* method);
// System.Void TapTap.Common.Json/Serializer::SerializeString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeString_m0FA59B83F91D62AADBA4FACF5095F1E80DB6E82F (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, String_t* ___str0, const RuntimeMethod* method);
// System.Void TapTap.Common.Json/Serializer::SerializeArray(System.Collections.IList)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeArray_m10B586A1ECBBA3EC6FD38A94FA57688309BFB341 (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, RuntimeObject* ___anArray0, const RuntimeMethod* method);
// System.Void TapTap.Common.Json/Serializer::SerializeObject(System.Collections.IDictionary)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeObject_m903C16422CCDF3805263D033975263ED3EAC6724 (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, RuntimeObject* ___obj0, const RuntimeMethod* method);
// System.String System.String::CreateString(System.Char,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_CreateString_m4CBF2A74FB65655B0BB1452CA748E9CF78D974ED (String_t* __this, Il2CppChar ___c0, int32_t ___count1, const RuntimeMethod* method);
// System.Void TapTap.Common.Json/Serializer::SerializeOther(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeOther_m0E79C4CBBFC917C5EA585DF184BBF6FB54C856A1 (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, RuntimeObject * ___value0, const RuntimeMethod* method);
// System.Char[] System.String::ToCharArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* String_ToCharArray_m33E93AEB7086CBEBDFA5730EAAC49686F144089C (String_t* __this, const RuntimeMethod* method);
// System.Int32 System.Convert::ToInt32(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Convert_ToInt32_m0B80BF2883121B16934DF6F71590CAE15442A5BC (Il2CppChar ___value0, const RuntimeMethod* method);
// System.String System.Int32::ToString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int32_ToString_m5398ED0B6625B75CAF70C63B3CF2CE47D3C1B184 (int32_t* __this, String_t* ___format0, const RuntimeMethod* method);
// System.String System.Single::ToString(System.String,System.IFormatProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Single_ToString_m7631D332703B4197EAA7DC0BA067CE7E16334D8B (float* __this, String_t* ___format0, RuntimeObject* ___provider1, const RuntimeMethod* method);
// System.Double System.Convert::ToDouble(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Convert_ToDouble_mF6F0642EA16CAB414EEA621DEAA519527DA64284 (RuntimeObject * ___value0, const RuntimeMethod* method);
// System.String System.Double::ToString(System.String,System.IFormatProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Double_ToString_mFF1DAF2003FC7096C54C5A2685F85082220E330B (double* __this, String_t* ___format0, RuntimeObject* ___provider1, const RuntimeMethod* method);
IL2CPP_EXTERN_C void DEFAULT_CALL callHandler(char*);
IL2CPP_EXTERN_C void DEFAULT_CALL registerHandler(char*, Il2CppMethodPointer);
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
// TapTap.Common.BridgeAndroid TapTap.Common.BridgeAndroid::GetInstance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * BridgeAndroid_GetInstance_mBAC5D6916DDC204635DFE9828F23866E00D40514 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * V_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var);
		BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * L_0 = ((BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_StaticFields*)il2cpp_codegen_static_fields_for(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var))->get_SInstance_7();
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * L_1 = V_0;
		return L_1;
	}
}
// System.Void TapTap.Common.BridgeAndroid::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeAndroid__ctor_mC095A76530DC28ED03819CA8C5CB6E107CBF6277 (BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_CallStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mAD48C38D66AB67D0F0274D195F4A99CB7AB589F2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_GetStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mC84C97A7EC20ED712D21107C9FA32E0785021153_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1C7A9E8795DAC93A625C23D6E9F2BC7332ABF459);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2063737B07B6658BC2E1EC3128D4E09E57CA123E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4D613657609485AE586A3379BA0E3FC13C1E1078);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral74995F8A2CBEF688BCD95DF9DB36E3FFCDE14774);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD2671306B605AA32D582F0C7A19AAE677E5437A5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD6CFAA9A8F507F384B1008F247D2327A3D2F1426);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE7CE87F5CD06F2CEADE5857C0C5F2EF8A58F5656);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFB4AE4F77150C3A8E8E4F8B23E734E0C7277B7D9);
		s_Il2CppMethodInitialized = true;
	}
	AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * V_0 = NULL;
	{
		__this->set_bridgeJavaClz_0(_stringLiteralD2671306B605AA32D582F0C7A19AAE677E5437A5);
		__this->set_instanceMethod_1(_stringLiteral2063737B07B6658BC2E1EC3128D4E09E57CA123E);
		__this->set_registerHandlerMethod_2(_stringLiteral74995F8A2CBEF688BCD95DF9DB36E3FFCDE14774);
		__this->set_callHandlerMethod_3(_stringLiteralE7CE87F5CD06F2CEADE5857C0C5F2EF8A58F5656);
		__this->set_initMethod_4(_stringLiteral1C7A9E8795DAC93A625C23D6E9F2BC7332ABF459);
		__this->set_registerMethod_5(_stringLiteralD6CFAA9A8F507F384B1008F247D2327A3D2F1426);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * L_0 = (AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 *)il2cpp_codegen_object_new(AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4_il2cpp_TypeInfo_var);
		AndroidJavaClass__ctor_mEFF9F51871F231955D97DABDE9AB4A6B4EDA5541(L_0, _stringLiteral4D613657609485AE586A3379BA0E3FC13C1E1078, /*hidden argument*/NULL);
		NullCheck(L_0);
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_1;
		L_1 = AndroidJavaObject_GetStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mC84C97A7EC20ED712D21107C9FA32E0785021153(L_0, _stringLiteralFB4AE4F77150C3A8E8E4F8B23E734E0C7277B7D9, /*hidden argument*/AndroidJavaObject_GetStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mC84C97A7EC20ED712D21107C9FA32E0785021153_RuntimeMethod_var);
		V_0 = L_1;
		String_t* L_2 = __this->get_bridgeJavaClz_0();
		AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * L_3 = (AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 *)il2cpp_codegen_object_new(AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4_il2cpp_TypeInfo_var);
		AndroidJavaClass__ctor_mEFF9F51871F231955D97DABDE9AB4A6B4EDA5541(L_3, L_2, /*hidden argument*/NULL);
		String_t* L_4 = __this->get_instanceMethod_1();
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_5;
		L_5 = Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_inline(/*hidden argument*/Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_RuntimeMethod_var);
		NullCheck(L_3);
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_6;
		L_6 = AndroidJavaObject_CallStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mAD48C38D66AB67D0F0274D195F4A99CB7AB589F2(L_3, L_4, L_5, /*hidden argument*/AndroidJavaObject_CallStatic_TisAndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_mAD48C38D66AB67D0F0274D195F4A99CB7AB589F2_RuntimeMethod_var);
		__this->set__mAndroidBridge_6(L_6);
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_7 = __this->get__mAndroidBridge_6();
		String_t* L_8 = __this->get_initMethod_4();
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_9 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)1);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_10 = L_9;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_11 = V_0;
		NullCheck(L_10);
		ArrayElementTypeCheck (L_10, L_11);
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_11);
		NullCheck(L_7);
		AndroidJavaObject_Call_mBB226DA52CE5A2FCD9A2D42BC7FB4272E094B76D(L_7, L_8, L_10, /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.BridgeAndroid::Register(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeAndroid_Register_m3F97FD8D1B0DEC4EEA469AA2CD038D1C2FCC87CA (BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * __this, String_t* ___serviceClzName0, String_t* ___serviceImplName1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * V_1 = NULL;
	AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * V_2 = NULL;
	Exception_t * V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	Exception_t * G_B6_0 = NULL;
	String_t* G_B6_1 = NULL;
	Exception_t * G_B5_0 = NULL;
	String_t* G_B5_1 = NULL;
	String_t* G_B7_0 = NULL;
	String_t* G_B7_1 = NULL;
	{
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_0 = __this->get__mAndroidBridge_6();
		V_0 = (bool)((((RuntimeObject*)(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0011;
		}
	}
	{
		goto IL_006b;
	}

IL_0011:
	{
	}

IL_0012:
	try
	{ // begin try (depth: 1)
		String_t* L_2 = ___serviceClzName0;
		AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * L_3 = (AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 *)il2cpp_codegen_object_new(AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4_il2cpp_TypeInfo_var);
		AndroidJavaClass__ctor_mEFF9F51871F231955D97DABDE9AB4A6B4EDA5541(L_3, L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		String_t* L_4 = ___serviceImplName1;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_5;
		L_5 = Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_inline(/*hidden argument*/Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_RuntimeMethod_var);
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_6 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)il2cpp_codegen_object_new(AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E_il2cpp_TypeInfo_var);
		AndroidJavaObject__ctor_m6146DBD19BCFFDB3D4F42C8D38491F354B58B001(L_6, L_4, L_5, /*hidden argument*/NULL);
		V_2 = L_6;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_7 = __this->get__mAndroidBridge_6();
		String_t* L_8 = __this->get_registerMethod_5();
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_9 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)2);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_10 = L_9;
		AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * L_11 = V_1;
		NullCheck(L_10);
		ArrayElementTypeCheck (L_10, L_11);
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_11);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_12 = L_10;
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_13 = V_2;
		NullCheck(L_12);
		ArrayElementTypeCheck (L_12, L_13);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_13);
		NullCheck(L_7);
		AndroidJavaObject_Call_mBB226DA52CE5A2FCD9A2D42BC7FB4272E094B76D(L_7, L_8, L_12, /*hidden argument*/NULL);
		goto IL_006b;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0049;
		}
		throw e;
	}

CATCH_0049:
	{ // begin catch(System.Exception)
		{
			V_3 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
			Exception_t * L_14 = V_3;
			Exception_t * L_15 = L_14;
			G_B5_0 = L_15;
			G_B5_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral07910731D7533EC65B7E53F11C34777CE40AA3C0));
			if (L_15)
			{
				G_B6_0 = L_15;
				G_B6_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral07910731D7533EC65B7E53F11C34777CE40AA3C0));
				goto IL_0058;
			}
		}

IL_0054:
		{
			G_B7_0 = ((String_t*)(NULL));
			G_B7_1 = G_B5_1;
			goto IL_005d;
		}

IL_0058:
		{
			NullCheck(G_B6_0);
			String_t* L_16;
			L_16 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B6_0);
			G_B7_0 = L_16;
			G_B7_1 = G_B6_1;
		}

IL_005d:
		{
			String_t* L_17;
			L_17 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(G_B7_1, G_B7_0, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var)));
			Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_17, /*hidden argument*/NULL);
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_006b;
		}
	} // end catch (depth: 1)

IL_006b:
	{
		return;
	}
}
// System.Void TapTap.Common.BridgeAndroid::Call(TapTap.Common.Command,System.Action`1<TapTap.Common.Result>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeAndroid_Call_m3199A8A51AA0E144674C38C919668D567E208A07 (BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * __this, Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * ___command0, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ___action1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * G_B2_0 = NULL;
	AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * G_B1_0 = NULL;
	{
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_0 = __this->get__mAndroidBridge_6();
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000d;
		}
	}
	{
		goto IL_0031;
	}

IL_000d:
	{
		String_t* L_2 = __this->get_registerHandlerMethod_2();
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)2);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = L_3;
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_5 = ___command0;
		NullCheck(L_5);
		String_t* L_6;
		L_6 = Command_ToJSON_m72C0199077CB83B769023C33665380DBF6F8890C(L_5, /*hidden argument*/NULL);
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, L_6);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_6);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_7 = L_4;
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_8 = ___action1;
		BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707 * L_9 = (BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707 *)il2cpp_codegen_object_new(BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707_il2cpp_TypeInfo_var);
		BridgeCallback__ctor_mD5E82AAF1D3FDBC8120AD9C1CC7CA5DEEDB0438A(L_9, L_8, /*hidden argument*/NULL);
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, L_9);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_9);
		NullCheck(G_B2_0);
		AndroidJavaObject_Call_mBB226DA52CE5A2FCD9A2D42BC7FB4272E094B76D(G_B2_0, L_2, L_7, /*hidden argument*/NULL);
	}

IL_0031:
	{
		return;
	}
}
// System.Void TapTap.Common.BridgeAndroid::Call(TapTap.Common.Command)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeAndroid_Call_mDC6842D1DA2145DD8F8D4542D186D76C5EA763F5 (BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * __this, Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * ___command0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * G_B2_0 = NULL;
	AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * G_B1_0 = NULL;
	{
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_0 = __this->get__mAndroidBridge_6();
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000d;
		}
	}
	{
		goto IL_0028;
	}

IL_000d:
	{
		String_t* L_2 = __this->get_callHandlerMethod_3();
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)1);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = L_3;
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_5 = ___command0;
		NullCheck(L_5);
		String_t* L_6;
		L_6 = Command_ToJSON_m72C0199077CB83B769023C33665380DBF6F8890C(L_5, /*hidden argument*/NULL);
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, L_6);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_6);
		NullCheck(G_B2_0);
		AndroidJavaObject_Call_mBB226DA52CE5A2FCD9A2D42BC7FB4272E094B76D(G_B2_0, L_2, L_4, /*hidden argument*/NULL);
	}

IL_0028:
	{
		return;
	}
}
// System.Void TapTap.Common.BridgeAndroid::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeAndroid__cctor_m63532A973F02D793F51ADFC222D7F106F6B1BD78 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * L_0 = (BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A *)il2cpp_codegen_object_new(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var);
		BridgeAndroid__ctor_mC095A76530DC28ED03819CA8C5CB6E107CBF6277(L_0, /*hidden argument*/NULL);
		((BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_StaticFields*)il2cpp_codegen_static_fields_for(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var))->set_SInstance_7(L_0);
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
// System.Void TapTap.Common.BridgeCallback::.ctor(System.Action`1<TapTap.Common.Result>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeCallback__ctor_mD5E82AAF1D3FDBC8120AD9C1CC7CA5DEEDB0438A (BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707 * __this, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ___action0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCDB1A0A3D8C53C2F9DEC231A147964E483B79A09);
		s_Il2CppMethodInitialized = true;
	}
	{
		AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 * L_0 = (AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4 *)il2cpp_codegen_object_new(AndroidJavaClass_t52E934B16476D72AA6E4B248F989F2F825EB62D4_il2cpp_TypeInfo_var);
		AndroidJavaClass__ctor_mEFF9F51871F231955D97DABDE9AB4A6B4EDA5541(L_0, _stringLiteralCDB1A0A3D8C53C2F9DEC231A147964E483B79A09, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(AndroidJavaProxy_tA8C86826A74CB7CC5511CB353DBA595C9270D9AF_il2cpp_TypeInfo_var);
		AndroidJavaProxy__ctor_m17BDD42A24CEBD07722B68A25CAD6DEAF64241E1(__this, L_0, /*hidden argument*/NULL);
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_1 = ___action0;
		__this->set_callback_4(L_1);
		return;
	}
}
// UnityEngine.AndroidJavaObject TapTap.Common.BridgeCallback::Invoke(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * BridgeCallback_Invoke_m383B8F6CF2D0B42C0C13E9201CB58329A88C9B05 (BridgeCallback_t93BE58AE79FC2F360AEF91FF162A339DF97E4707 * __this, String_t* ___method0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m30BB8E391F85895D3CDED6D834FF6F350978FABD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9BC242DF4AEE0561D7635DB8227112DC96E863C3);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	String_t* V_2 = NULL;
	AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * V_3 = NULL;
	{
		String_t* L_0 = ___method0;
		NullCheck(L_0);
		bool L_1;
		L_1 = String_Equals_m8A062B96B61A7D652E7D73C9B3E904F6B0E5F41D(L_0, _stringLiteral9BC242DF4AEE0561D7635DB8227112DC96E863C3, /*hidden argument*/NULL);
		V_0 = L_1;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_003e;
		}
	}
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = ___args1;
		NullCheck(L_3);
		int32_t L_4 = 0;
		RuntimeObject * L_5 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		V_1 = (bool)((!(((RuntimeObject*)(String_t*)((String_t*)IsInstSealed((RuntimeObject*)L_5, String_t_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_6 = V_1;
		if (!L_6)
		{
			goto IL_003d;
		}
	}
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_7 = ___args1;
		NullCheck(L_7);
		int32_t L_8 = 0;
		RuntimeObject * L_9 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		V_2 = ((String_t*)CastclassSealed((RuntimeObject*)L_9, String_t_il2cpp_TypeInfo_var));
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_10 = __this->get_callback_4();
		String_t* L_11 = V_2;
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_12 = (Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 *)il2cpp_codegen_object_new(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var);
		Result__ctor_m681484DE5A13EFE6F4E971E9F22FAC7941100226(L_12, L_11, /*hidden argument*/NULL);
		NullCheck(L_10);
		Action_1_Invoke_m30BB8E391F85895D3CDED6D834FF6F350978FABD(L_10, L_12, /*hidden argument*/Action_1_Invoke_m30BB8E391F85895D3CDED6D834FF6F350978FABD_RuntimeMethod_var);
	}

IL_003d:
	{
	}

IL_003e:
	{
		V_3 = (AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E *)NULL;
		goto IL_0042;
	}

IL_0042:
	{
		AndroidJavaObject_t10188D5695DCD09C9F621B44B0A8C93A2281236E * L_13 = V_3;
		return L_13;
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
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_BridgeIOS_engineBridgeDelegate_m8912905FBDD43922D6F2D45405C1CF03F884F8F6(char* ___resultJson0)
{
	il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

	// Marshaling of parameter '___resultJson0' to managed representation
	String_t* ____resultJson0_unmarshaled = NULL;
	____resultJson0_unmarshaled = il2cpp_codegen_marshal_string_result(___resultJson0);

	// Managed method invocation
	BridgeIOS_engineBridgeDelegate_m8912905FBDD43922D6F2D45405C1CF03F884F8F6(____resultJson0_unmarshaled, NULL);

}
// TapTap.Common.BridgeIOS TapTap.Common.BridgeIOS::GetInstance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * BridgeIOS_GetInstance_m49697C9E7289F0A8CC539CA19A5F2A1C272B7C8C (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * V_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * L_0 = ((BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_StaticFields*)il2cpp_codegen_static_fields_for(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var))->get_SInstance_0();
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * L_1 = V_0;
		return L_1;
	}
}
// System.Void TapTap.Common.BridgeIOS::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS__ctor_m3F6A9664C063DFD3E9D5C5DBBF44CC16BA96F4A7 (BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2__ctor_m61593A6F8DCC9B835A9162D9A41E933C6AC0C511_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_0 = (ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 *)il2cpp_codegen_object_new(ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9_il2cpp_TypeInfo_var);
		ConcurrentDictionary_2__ctor_m61593A6F8DCC9B835A9162D9A41E933C6AC0C511(L_0, /*hidden argument*/ConcurrentDictionary_2__ctor_m61593A6F8DCC9B835A9162D9A41E933C6AC0C511_RuntimeMethod_var);
		__this->set_dic_1(L_0);
		return;
	}
}
// System.Collections.Concurrent.ConcurrentDictionary`2<System.String,System.Action`1<TapTap.Common.Result>> TapTap.Common.BridgeIOS::GetConcurrentDictionary()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * BridgeIOS_GetConcurrentDictionary_m6CB5A2530F785096F3D03A935C215BB7A1023957 (BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * __this, const RuntimeMethod* method)
{
	ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * V_0 = NULL;
	{
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_0 = __this->get_dic_1();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_1 = V_0;
		return L_1;
	}
}
// System.Void TapTap.Common.BridgeIOS::engineBridgeDelegate(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_engineBridgeDelegate_m8912905FBDD43922D6F2D45405C1CF03F884F8F6 (String_t* ___resultJson0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m30BB8E391F85895D3CDED6D834FF6F350978FABD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2_ContainsKey_m3977DBC42CD0D3E6EF36F9249D00F1940D22C3E3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2_TryRemove_m9AF2612953577A6707762B06C82DE81718183E5D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2_get_Count_m909ED40578105FB6817240D4E5B7DE0594CF47FF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2_get_Item_mA417BF88EF46098F3A761B0C74BF477F35BA8086_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral843A881AA95F05B68BA338CAF346BBAD3DB68882);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEAC023C83F279F84D4D498C417617E63443A176E);
		s_Il2CppMethodInitialized = true;
	}
	Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * V_0 = NULL;
	ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * V_1 = NULL;
	Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * V_2 = NULL;
	bool V_3 = false;
	bool V_4 = false;
	Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * V_5 = NULL;
	bool V_6 = false;
	int32_t G_B3_0 = 0;
	int32_t G_B9_0 = 0;
	{
		String_t* L_0 = ___resultJson0;
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_1 = (Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 *)il2cpp_codegen_object_new(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var);
		Result__ctor_m681484DE5A13EFE6F4E971E9F22FAC7941100226(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		IL2CPP_RUNTIME_CLASS_INIT(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * L_2;
		L_2 = BridgeIOS_GetInstance_m49697C9E7289F0A8CC539CA19A5F2A1C272B7C8C(/*hidden argument*/NULL);
		NullCheck(L_2);
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_3;
		L_3 = BridgeIOS_GetConcurrentDictionary_m6CB5A2530F785096F3D03A935C215BB7A1023957(L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		V_2 = (Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 *)NULL;
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_4 = V_1;
		if (!L_4)
		{
			goto IL_0026;
		}
	}
	{
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_5 = V_1;
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_6 = V_0;
		NullCheck(L_6);
		String_t* L_7 = L_6->get_callbackId_4();
		NullCheck(L_5);
		bool L_8;
		L_8 = ConcurrentDictionary_2_ContainsKey_m3977DBC42CD0D3E6EF36F9249D00F1940D22C3E3(L_5, L_7, /*hidden argument*/ConcurrentDictionary_2_ContainsKey_m3977DBC42CD0D3E6EF36F9249D00F1940D22C3E3_RuntimeMethod_var);
		G_B3_0 = ((int32_t)(L_8));
		goto IL_0027;
	}

IL_0026:
	{
		G_B3_0 = 0;
	}

IL_0027:
	{
		V_3 = (bool)G_B3_0;
		bool L_9 = V_3;
		if (!L_9)
		{
			goto IL_003a;
		}
	}
	{
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_10 = V_1;
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_11 = V_0;
		NullCheck(L_11);
		String_t* L_12 = L_11->get_callbackId_4();
		NullCheck(L_10);
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_13;
		L_13 = ConcurrentDictionary_2_get_Item_mA417BF88EF46098F3A761B0C74BF477F35BA8086(L_10, L_12, /*hidden argument*/ConcurrentDictionary_2_get_Item_mA417BF88EF46098F3A761B0C74BF477F35BA8086_RuntimeMethod_var);
		V_2 = L_13;
	}

IL_003a:
	{
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_14 = V_2;
		V_4 = (bool)((!(((RuntimeObject*)(Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 *)L_14) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_008e;
		}
	}
	{
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_16 = V_2;
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_17 = V_0;
		NullCheck(L_16);
		Action_1_Invoke_m30BB8E391F85895D3CDED6D834FF6F350978FABD(L_16, L_17, /*hidden argument*/Action_1_Invoke_m30BB8E391F85895D3CDED6D834FF6F350978FABD_RuntimeMethod_var);
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_18 = V_0;
		NullCheck(L_18);
		bool L_19 = L_18->get_onceTime_5();
		if (!L_19)
		{
			goto IL_006e;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * L_20;
		L_20 = BridgeIOS_GetInstance_m49697C9E7289F0A8CC539CA19A5F2A1C272B7C8C(/*hidden argument*/NULL);
		NullCheck(L_20);
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_21;
		L_21 = BridgeIOS_GetConcurrentDictionary_m6CB5A2530F785096F3D03A935C215BB7A1023957(L_20, /*hidden argument*/NULL);
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_22 = V_0;
		NullCheck(L_22);
		String_t* L_23 = L_22->get_callbackId_4();
		NullCheck(L_21);
		bool L_24;
		L_24 = ConcurrentDictionary_2_TryRemove_m9AF2612953577A6707762B06C82DE81718183E5D(L_21, L_23, (Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 **)(&V_5), /*hidden argument*/ConcurrentDictionary_2_TryRemove_m9AF2612953577A6707762B06C82DE81718183E5D_RuntimeMethod_var);
		G_B9_0 = ((int32_t)(L_24));
		goto IL_006f;
	}

IL_006e:
	{
		G_B9_0 = 0;
	}

IL_006f:
	{
		V_6 = (bool)G_B9_0;
		bool L_25 = V_6;
		if (!L_25)
		{
			goto IL_008d;
		}
	}
	{
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_26 = V_0;
		NullCheck(L_26);
		String_t* L_27 = L_26->get_callbackId_4();
		String_t* L_28;
		L_28 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(_stringLiteralEAC023C83F279F84D4D498C417617E63443A176E, L_27, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_28, /*hidden argument*/NULL);
	}

IL_008d:
	{
	}

IL_008e:
	{
		IL2CPP_RUNTIME_CLASS_INIT(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * L_29;
		L_29 = BridgeIOS_GetInstance_m49697C9E7289F0A8CC539CA19A5F2A1C272B7C8C(/*hidden argument*/NULL);
		NullCheck(L_29);
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_30;
		L_30 = BridgeIOS_GetConcurrentDictionary_m6CB5A2530F785096F3D03A935C215BB7A1023957(L_29, /*hidden argument*/NULL);
		NullCheck(L_30);
		int32_t L_31;
		L_31 = ConcurrentDictionary_2_get_Count_m909ED40578105FB6817240D4E5B7DE0594CF47FF(L_30, /*hidden argument*/ConcurrentDictionary_2_get_Count_m909ED40578105FB6817240D4E5B7DE0594CF47FF_RuntimeMethod_var);
		int32_t L_32 = L_31;
		RuntimeObject * L_33 = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &L_32);
		String_t* L_34;
		L_34 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(_stringLiteral843A881AA95F05B68BA338CAF346BBAD3DB68882, L_33, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_34, /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.BridgeIOS::Register(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_Register_m23E321BE5AB425CCF289A3230C61F1B96E9978B3 (BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * __this, String_t* ___serviceClz0, String_t* ___serviceImp1, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void TapTap.Common.BridgeIOS::Call(TapTap.Common.Command)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_Call_mB3118CDA425D237428D801F0F46110803BD07C41 (BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * __this, Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * ___command0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_0 = ___command0;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = Command_ToJSON_m72C0199077CB83B769023C33665380DBF6F8890C(L_0, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		BridgeIOS_callHandler_mC75DE5396D98B4D419EC8C8AF6FD43AF6C06E7DB(L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.BridgeIOS::Call(TapTap.Common.Command,System.Action`1<TapTap.Common.Result>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_Call_m0D1A49AC76BA4C6EBB1BD8296742FE3572CC9D0C (BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * __this, Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * ___command0, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ___action1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeIOS_engineBridgeDelegate_m8912905FBDD43922D6F2D45405C1CF03F884F8F6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2_ContainsKey_m3977DBC42CD0D3E6EF36F9249D00F1940D22C3E3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConcurrentDictionary_2_GetOrAdd_m6D452307EA9EB2FFC8D778A35E994D27BB6E22F3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	int32_t G_B3_0 = 0;
	{
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_0 = ___command0;
		NullCheck(L_0);
		bool L_1 = L_0->get_callback_3();
		if (!L_1)
		{
			goto IL_0016;
		}
	}
	{
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_2 = ___command0;
		NullCheck(L_2);
		String_t* L_3 = L_2->get_callbackId_4();
		bool L_4;
		L_4 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_3, /*hidden argument*/NULL);
		G_B3_0 = ((int32_t)(L_4));
		goto IL_0017;
	}

IL_0016:
	{
		G_B3_0 = 1;
	}

IL_0017:
	{
		V_0 = (bool)G_B3_0;
		bool L_5 = V_0;
		if (!L_5)
		{
			goto IL_001d;
		}
	}
	{
		goto IL_0062;
	}

IL_001d:
	{
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_6 = __this->get_dic_1();
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_7 = ___command0;
		NullCheck(L_7);
		String_t* L_8 = L_7->get_callbackId_4();
		NullCheck(L_6);
		bool L_9;
		L_9 = ConcurrentDictionary_2_ContainsKey_m3977DBC42CD0D3E6EF36F9249D00F1940D22C3E3(L_6, L_8, /*hidden argument*/ConcurrentDictionary_2_ContainsKey_m3977DBC42CD0D3E6EF36F9249D00F1940D22C3E3_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_9) == ((int32_t)0))? 1 : 0);
		bool L_10 = V_1;
		if (!L_10)
		{
			goto IL_004a;
		}
	}
	{
		ConcurrentDictionary_2_t92CF3C12BCC374E4AEF0B827E785856DA4DB07A9 * L_11 = __this->get_dic_1();
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_12 = ___command0;
		NullCheck(L_12);
		String_t* L_13 = L_12->get_callbackId_4();
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_14 = ___action1;
		NullCheck(L_11);
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_15;
		L_15 = ConcurrentDictionary_2_GetOrAdd_m6D452307EA9EB2FFC8D778A35E994D27BB6E22F3(L_11, L_13, L_14, /*hidden argument*/ConcurrentDictionary_2_GetOrAdd_m6D452307EA9EB2FFC8D778A35E994D27BB6E22F3_RuntimeMethod_var);
	}

IL_004a:
	{
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_16 = ___command0;
		NullCheck(L_16);
		String_t* L_17;
		L_17 = Command_ToJSON_m72C0199077CB83B769023C33665380DBF6F8890C(L_16, /*hidden argument*/NULL);
		EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * L_18 = (EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A *)il2cpp_codegen_object_new(EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A_il2cpp_TypeInfo_var);
		EngineBridgeDelegate__ctor_m0EBCEB007E06DD216B729E56DD960FACFCC9D76C(L_18, NULL, (intptr_t)((intptr_t)BridgeIOS_engineBridgeDelegate_m8912905FBDD43922D6F2D45405C1CF03F884F8F6_RuntimeMethod_var), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		BridgeIOS_registerHandler_m8B0FF715CD8E84FF1C4A0F331F087EE369686C86(L_17, L_18, /*hidden argument*/NULL);
	}

IL_0062:
	{
		return;
	}
}
// System.Void TapTap.Common.BridgeIOS::callHandler(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_callHandler_mC75DE5396D98B4D419EC8C8AF6FD43AF6C06E7DB (String_t* ___command0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (char*);

	// Marshaling of parameter '___command0' to native representation
	char* ____command0_marshaled = NULL;
	____command0_marshaled = il2cpp_codegen_marshal_string(___command0);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(callHandler)(____command0_marshaled);

	// Marshaling cleanup of parameter '___command0' native representation
	il2cpp_codegen_marshal_free(____command0_marshaled);
	____command0_marshaled = NULL;

}
// System.Void TapTap.Common.BridgeIOS::registerHandler(System.String,TapTap.Common.BridgeIOS/EngineBridgeDelegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS_registerHandler_m8B0FF715CD8E84FF1C4A0F331F087EE369686C86 (String_t* ___command0, EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * ___engineBridgeDelegate1, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (char*, Il2CppMethodPointer);

	// Marshaling of parameter '___command0' to native representation
	char* ____command0_marshaled = NULL;
	____command0_marshaled = il2cpp_codegen_marshal_string(___command0);

	// Marshaling of parameter '___engineBridgeDelegate1' to native representation
	Il2CppMethodPointer ____engineBridgeDelegate1_marshaled = NULL;
	____engineBridgeDelegate1_marshaled = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(___engineBridgeDelegate1));

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(registerHandler)(____command0_marshaled, ____engineBridgeDelegate1_marshaled);

	// Marshaling cleanup of parameter '___command0' native representation
	il2cpp_codegen_marshal_free(____command0_marshaled);
	____command0_marshaled = NULL;

}
// System.Void TapTap.Common.BridgeIOS::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BridgeIOS__cctor_m4DDB0A53A13631D19544041DF2112CDD961F8349 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * L_0 = (BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 *)il2cpp_codegen_object_new(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		BridgeIOS__ctor_m3F6A9664C063DFD3E9D5C5DBBF44CC16BA96F4A7(L_0, /*hidden argument*/NULL);
		((BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_StaticFields*)il2cpp_codegen_static_fields_for(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var))->set_SInstance_0(L_0);
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
// System.String TapTap.Common.Command::ToJSON()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Command_ToJSON_m72C0199077CB83B769023C33665380DBF6F8890C (Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * __this, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		String_t* L_0;
		L_0 = JsonUtility_ToJson_mF4F097C9AEC7699970E3E7E99EF8FF2F44DA1B5C(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		String_t* L_1 = V_0;
		return L_1;
	}
}
// System.Void TapTap.Common.Command::.ctor(System.String,System.String,System.Boolean,System.Boolean,System.Collections.Generic.Dictionary`2<System.String,System.Object>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Command__ctor_m1DAC8B23A51DDB3A89F453F7C5C31128092F77C6 (Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * __this, String_t* ___service0, String_t* ___method1, bool ___callback2, bool ___onceTime3, Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___dic4, const RuntimeMethod* method)
{
	Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * G_B2_0 = NULL;
	Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * G_B1_0 = NULL;
	String_t* G_B3_0 = NULL;
	Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * G_B3_1 = NULL;
	Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * G_B5_0 = NULL;
	Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * G_B4_0 = NULL;
	String_t* G_B6_0 = NULL;
	Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * G_B6_1 = NULL;
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_0 = ___dic4;
		G_B1_0 = __this;
		if (!L_0)
		{
			G_B2_0 = __this;
			goto IL_0016;
		}
	}
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_1 = ___dic4;
		String_t* L_2;
		L_2 = Json_Serialize_m03AB6071E9A0A5D7197D2BA15B8E265D0876BC52(L_1, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		G_B3_1 = G_B1_0;
		goto IL_0017;
	}

IL_0016:
	{
		G_B3_0 = ((String_t*)(NULL));
		G_B3_1 = G_B2_0;
	}

IL_0017:
	{
		NullCheck(G_B3_1);
		G_B3_1->set_args_2(G_B3_0);
		String_t* L_3 = ___service0;
		__this->set_service_0(L_3);
		String_t* L_4 = ___method1;
		__this->set_method_1(L_4);
		bool L_5 = ___callback2;
		__this->set_callback_3(L_5);
		bool L_6 = __this->get_callback_3();
		G_B4_0 = __this;
		if (L_6)
		{
			G_B5_0 = __this;
			goto IL_003d;
		}
	}
	{
		G_B6_0 = ((String_t*)(NULL));
		G_B6_1 = G_B4_0;
		goto IL_0042;
	}

IL_003d:
	{
		String_t* L_7;
		L_7 = TapUUID_UUID_m34CD600BDA5D524CD97F2C290CF4FFBCBF7C950D(/*hidden argument*/NULL);
		G_B6_0 = L_7;
		G_B6_1 = G_B5_0;
	}

IL_0042:
	{
		NullCheck(G_B6_1);
		G_B6_1->set_callbackId_4(G_B6_0);
		bool L_8 = ___onceTime3;
		__this->set_onceTime_5(L_8);
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
// System.Void TapTap.Common.DataStorage::SaveString(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DataStorage_SaveString_m1E04DA08CA9952EEE53D1F5AE9CBF7CDAAA91B98 (String_t* ___key0, String_t* ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___key0;
		String_t* L_1 = ___value1;
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		DataStorage_SaveStringToCache_m40F7AB84CB9C9F01A90435C8ABB1B3A9630CD512(L_0, L_1, /*hidden argument*/NULL);
		String_t* L_2 = ___key0;
		String_t* L_3 = ___value1;
		String_t* L_4;
		L_4 = DataStorage_EncodeString_m48C0DF4E507E1EAA45A1D2A824AB10AAF6C9EA47(L_3, /*hidden argument*/NULL);
		PlayerPrefs_SetString_m94CD8FF45692553A5726DFADF74935F7E1D1C633(L_2, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.String TapTap.Common.DataStorage::LoadString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_LoadString_mBF4A6638C861B6B20DDC6E36E8E706CFE7AF84B1 (String_t* ___key0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	bool V_1 = false;
	String_t* V_2 = NULL;
	bool V_3 = false;
	String_t* G_B5_0 = NULL;
	{
		String_t* L_0 = ___key0;
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = DataStorage_LoadStringFromCache_mAA04953F7EBDEC52C0329FAB2E06FE3C13D11DE4(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		String_t* L_2 = V_0;
		bool L_3;
		L_3 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_2, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_3) == ((int32_t)0))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_001a;
		}
	}
	{
		String_t* L_5 = V_0;
		V_2 = L_5;
		goto IL_0047;
	}

IL_001a:
	{
		String_t* L_6 = ___key0;
		bool L_7;
		L_7 = PlayerPrefs_HasKey_m48BE5886380B51AB495B91C9A26115B7CB958A92(L_6, /*hidden argument*/NULL);
		if (L_7)
		{
			goto IL_0025;
		}
	}
	{
		G_B5_0 = ((String_t*)(NULL));
		goto IL_0030;
	}

IL_0025:
	{
		String_t* L_8 = ___key0;
		String_t* L_9;
		L_9 = PlayerPrefs_GetString_mE7654C1031622A56CD8F248F53714B105A35A159(L_8, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		String_t* L_10;
		L_10 = DataStorage_DecodeString_m1C0A2E06114479AD5674E97026863F3AFF032C64(L_9, /*hidden argument*/NULL);
		G_B5_0 = L_10;
	}

IL_0030:
	{
		V_0 = G_B5_0;
		String_t* L_11 = V_0;
		V_3 = (bool)((!(((RuntimeObject*)(String_t*)L_11) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_12 = V_3;
		if (!L_12)
		{
			goto IL_0043;
		}
	}
	{
		String_t* L_13 = ___key0;
		String_t* L_14 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		DataStorage_SaveStringToCache_m40F7AB84CB9C9F01A90435C8ABB1B3A9630CD512(L_13, L_14, /*hidden argument*/NULL);
	}

IL_0043:
	{
		String_t* L_15 = V_0;
		V_2 = L_15;
		goto IL_0047;
	}

IL_0047:
	{
		String_t* L_16 = V_2;
		return L_16;
	}
}
// System.Void TapTap.Common.DataStorage::SaveStringToCache(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DataStorage_SaveStringToCache_m40F7AB84CB9C9F01A90435C8ABB1B3A9630CD512 (String_t* ___key0, String_t* ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_mE0EF428186E444BFEAD18AC6810D423EEABB3F92_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mA6747E78BD4DF1D09D9091C1B3EBAE0FDB200666_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_m31C41E4FE938066440DAFD1E667C2F3986549668_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_0 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_dataCache_0();
		V_0 = (bool)((((RuntimeObject*)(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_2 = (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *)il2cpp_codegen_object_new(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mA6747E78BD4DF1D09D9091C1B3EBAE0FDB200666(L_2, /*hidden argument*/Dictionary_2__ctor_mA6747E78BD4DF1D09D9091C1B3EBAE0FDB200666_RuntimeMethod_var);
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->set_dataCache_0(L_2);
	}

IL_0019:
	{
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_3 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_dataCache_0();
		String_t* L_4 = ___key0;
		NullCheck(L_3);
		bool L_5;
		L_5 = Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027(L_3, L_4, /*hidden argument*/Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027_RuntimeMethod_var);
		V_1 = L_5;
		bool L_6 = V_1;
		if (!L_6)
		{
			goto IL_0039;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_7 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_dataCache_0();
		String_t* L_8 = ___key0;
		String_t* L_9 = ___value1;
		NullCheck(L_7);
		Dictionary_2_set_Item_m31C41E4FE938066440DAFD1E667C2F3986549668(L_7, L_8, L_9, /*hidden argument*/Dictionary_2_set_Item_m31C41E4FE938066440DAFD1E667C2F3986549668_RuntimeMethod_var);
		goto IL_0048;
	}

IL_0039:
	{
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_10 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_dataCache_0();
		String_t* L_11 = ___key0;
		String_t* L_12 = ___value1;
		NullCheck(L_10);
		Dictionary_2_Add_mE0EF428186E444BFEAD18AC6810D423EEABB3F92(L_10, L_11, L_12, /*hidden argument*/Dictionary_2_Add_mE0EF428186E444BFEAD18AC6810D423EEABB3F92_RuntimeMethod_var);
	}

IL_0048:
	{
		return;
	}
}
// System.String TapTap.Common.DataStorage::LoadStringFromCache(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_LoadStringFromCache_mAA04953F7EBDEC52C0329FAB2E06FE3C13D11DE4 (String_t* ___key0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mA6747E78BD4DF1D09D9091C1B3EBAE0FDB200666_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	String_t* V_1 = NULL;
	String_t* G_B5_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_0 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_dataCache_0();
		V_0 = (bool)((((RuntimeObject*)(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_2 = (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *)il2cpp_codegen_object_new(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mA6747E78BD4DF1D09D9091C1B3EBAE0FDB200666(L_2, /*hidden argument*/Dictionary_2__ctor_mA6747E78BD4DF1D09D9091C1B3EBAE0FDB200666_RuntimeMethod_var);
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->set_dataCache_0(L_2);
	}

IL_0019:
	{
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_3 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_dataCache_0();
		String_t* L_4 = ___key0;
		NullCheck(L_3);
		bool L_5;
		L_5 = Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027(L_3, L_4, /*hidden argument*/Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027_RuntimeMethod_var);
		if (L_5)
		{
			goto IL_0029;
		}
	}
	{
		G_B5_0 = ((String_t*)(NULL));
		goto IL_0034;
	}

IL_0029:
	{
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_6 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_dataCache_0();
		String_t* L_7 = ___key0;
		NullCheck(L_6);
		String_t* L_8;
		L_8 = Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141(L_6, L_7, /*hidden argument*/Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141_RuntimeMethod_var);
		G_B5_0 = L_8;
	}

IL_0034:
	{
		V_1 = G_B5_0;
		goto IL_0037;
	}

IL_0037:
	{
		String_t* L_9 = V_1;
		return L_9;
	}
}
// System.String TapTap.Common.DataStorage::EncodeString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_EncodeString_m48C0DF4E507E1EAA45A1D2A824AB10AAF6C9EA47 (String_t* ___encryptString0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	String_t* V_1 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_2 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_3 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_4 = NULL;
	DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 * V_5 = NULL;
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * V_6 = NULL;
	CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * V_7 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	int32_t G_B3_0 = 0;
	{
		bool L_0;
		L_0 = Platform_IsAndroid_m3A9B875D7C3220A474C32E883D3FEF629E1105C0(/*hidden argument*/NULL);
		if (L_0)
		{
			goto IL_000f;
		}
	}
	{
		bool L_1;
		L_1 = Platform_IsIOS_m86A73A9650A84E8AAC86F9EE18B6954A75A6D6C4(/*hidden argument*/NULL);
		G_B3_0 = ((int32_t)(L_1));
		goto IL_0010;
	}

IL_000f:
	{
		G_B3_0 = 1;
	}

IL_0010:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001c;
		}
	}
	{
		String_t* L_3 = ___encryptString0;
		V_1 = L_3;
		goto IL_009d;
	}

IL_001c:
	{
	}

IL_001d:
	try
	{ // begin try (depth: 1)
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_4;
		L_4 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		String_t* L_5;
		L_5 = DataStorage_GetMacAddress_m48AD5D8EAA598DD27855E4858E78265E1151C11D(/*hidden argument*/NULL);
		NullCheck(L_5);
		String_t* L_6;
		L_6 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_5, 0, 8, /*hidden argument*/NULL);
		NullCheck(L_4);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_7;
		L_7 = VirtFuncInvoker1< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, String_t* >::Invoke(26 /* System.Byte[] System.Text.Encoding::GetBytes(System.String) */, L_4, L_6);
		V_2 = L_7;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_8 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_Keys_1();
		V_3 = L_8;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_9;
		L_9 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		String_t* L_10 = ___encryptString0;
		NullCheck(L_9);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_11;
		L_11 = VirtFuncInvoker1< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, String_t* >::Invoke(26 /* System.Byte[] System.Text.Encoding::GetBytes(System.String) */, L_9, L_10);
		V_4 = L_11;
		DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 * L_12 = (DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 *)il2cpp_codegen_object_new(DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40_il2cpp_TypeInfo_var);
		DESCryptoServiceProvider__ctor_m7AD8E1619BAA1EBC6FA81C815FA6D2786AA232F9(L_12, /*hidden argument*/NULL);
		V_5 = L_12;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_13 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_mD27B3DF2400D46A4A81EE78B0BD2C29EFCFAA44F(L_13, /*hidden argument*/NULL);
		V_6 = L_13;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_14 = V_6;
		DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 * L_15 = V_5;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_16 = V_2;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_17 = V_3;
		NullCheck(L_15);
		RuntimeObject* L_18;
		L_18 = VirtFuncInvoker2< RuntimeObject*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(23 /* System.Security.Cryptography.ICryptoTransform System.Security.Cryptography.SymmetricAlgorithm::CreateEncryptor(System.Byte[],System.Byte[]) */, L_15, L_16, L_17);
		CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * L_19 = (CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 *)il2cpp_codegen_object_new(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66_il2cpp_TypeInfo_var);
		CryptoStream__ctor_m690A130C7B6793E8D752DD3017419FFB12A0DBAE(L_19, L_14, L_18, 1, /*hidden argument*/NULL);
		V_7 = L_19;
		CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * L_20 = V_7;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_21 = V_4;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_22 = V_4;
		NullCheck(L_22);
		NullCheck(L_20);
		VirtActionInvoker3< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(36 /* System.Void System.IO.Stream::Write(System.Byte[],System.Int32,System.Int32) */, L_20, L_21, 0, ((int32_t)((int32_t)(((RuntimeArray*)L_22)->max_length))));
		CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * L_23 = V_7;
		NullCheck(L_23);
		CryptoStream_FlushFinalBlock_m7649E736DC0B525D9812EC018E2D74244DDF5891(L_23, /*hidden argument*/NULL);
		CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * L_24 = V_7;
		NullCheck(L_24);
		VirtActionInvoker0::Invoke(21 /* System.Void System.IO.Stream::Close() */, L_24);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_25 = V_6;
		NullCheck(L_25);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_26;
		L_26 = VirtFuncInvoker0< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(47 /* System.Byte[] System.IO.MemoryStream::ToArray() */, L_25);
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		String_t* L_27;
		L_27 = Convert_ToBase64String_mE6E1FE504EF1E99DB2F8B92180A82A5F1512EF6A(L_26, /*hidden argument*/NULL);
		V_1 = L_27;
		goto IL_009d;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0097;
		}
		throw e;
	}

CATCH_0097:
	{ // begin catch(System.Object)
		String_t* L_28 = ___encryptString0;
		V_1 = L_28;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_009d;
	} // end catch (depth: 1)

IL_009d:
	{
		String_t* L_29 = V_1;
		return L_29;
	}
}
// System.String TapTap.Common.DataStorage::DecodeString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_DecodeString_m1C0A2E06114479AD5674E97026863F3AFF032C64 (String_t* ___decryptString0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	String_t* V_1 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_2 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_3 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_4 = NULL;
	DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 * V_5 = NULL;
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * V_6 = NULL;
	CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * V_7 = NULL;
	Exception_t * V_8 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	int32_t G_B3_0 = 0;
	{
		bool L_0;
		L_0 = Platform_IsAndroid_m3A9B875D7C3220A474C32E883D3FEF629E1105C0(/*hidden argument*/NULL);
		if (L_0)
		{
			goto IL_000f;
		}
	}
	{
		bool L_1;
		L_1 = Platform_IsIOS_m86A73A9650A84E8AAC86F9EE18B6954A75A6D6C4(/*hidden argument*/NULL);
		G_B3_0 = ((int32_t)(L_1));
		goto IL_0010;
	}

IL_000f:
	{
		G_B3_0 = 1;
	}

IL_0010:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001c;
		}
	}
	{
		String_t* L_3 = ___decryptString0;
		V_1 = L_3;
		goto IL_00ab;
	}

IL_001c:
	{
	}

IL_001d:
	try
	{ // begin try (depth: 1)
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_4;
		L_4 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		String_t* L_5;
		L_5 = DataStorage_GetMacAddress_m48AD5D8EAA598DD27855E4858E78265E1151C11D(/*hidden argument*/NULL);
		NullCheck(L_5);
		String_t* L_6;
		L_6 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_5, 0, 8, /*hidden argument*/NULL);
		NullCheck(L_4);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_7;
		L_7 = VirtFuncInvoker1< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, String_t* >::Invoke(26 /* System.Byte[] System.Text.Encoding::GetBytes(System.String) */, L_4, L_6);
		V_2 = L_7;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_8 = ((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->get_Keys_1();
		V_3 = L_8;
		String_t* L_9 = ___decryptString0;
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_10;
		L_10 = Convert_FromBase64String_mB2E4E2CD03B34DB7C2665694D5B2E967BC81E9A8(L_9, /*hidden argument*/NULL);
		V_4 = L_10;
		DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 * L_11 = (DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 *)il2cpp_codegen_object_new(DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40_il2cpp_TypeInfo_var);
		DESCryptoServiceProvider__ctor_m7AD8E1619BAA1EBC6FA81C815FA6D2786AA232F9(L_11, /*hidden argument*/NULL);
		V_5 = L_11;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_12 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_mD27B3DF2400D46A4A81EE78B0BD2C29EFCFAA44F(L_12, /*hidden argument*/NULL);
		V_6 = L_12;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_13 = V_6;
		DESCryptoServiceProvider_t388757BDCC2CA0DF7C68BD637624ABF602228A40 * L_14 = V_5;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_15 = V_2;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_16 = V_3;
		NullCheck(L_14);
		RuntimeObject* L_17;
		L_17 = VirtFuncInvoker2< RuntimeObject*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(25 /* System.Security.Cryptography.ICryptoTransform System.Security.Cryptography.SymmetricAlgorithm::CreateDecryptor(System.Byte[],System.Byte[]) */, L_14, L_15, L_16);
		CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * L_18 = (CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 *)il2cpp_codegen_object_new(CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66_il2cpp_TypeInfo_var);
		CryptoStream__ctor_m690A130C7B6793E8D752DD3017419FFB12A0DBAE(L_18, L_13, L_17, 1, /*hidden argument*/NULL);
		V_7 = L_18;
		CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * L_19 = V_7;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_20 = V_4;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_21 = V_4;
		NullCheck(L_21);
		NullCheck(L_19);
		VirtActionInvoker3< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(36 /* System.Void System.IO.Stream::Write(System.Byte[],System.Int32,System.Int32) */, L_19, L_20, 0, ((int32_t)((int32_t)(((RuntimeArray*)L_21)->max_length))));
		CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * L_22 = V_7;
		NullCheck(L_22);
		CryptoStream_FlushFinalBlock_m7649E736DC0B525D9812EC018E2D74244DDF5891(L_22, /*hidden argument*/NULL);
		CryptoStream_tF66A4175F53BDFFC4936AF7FD02BD54C5B024B66 * L_23 = V_7;
		NullCheck(L_23);
		VirtActionInvoker0::Invoke(21 /* System.Void System.IO.Stream::Close() */, L_23);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_24;
		L_24 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_25 = V_6;
		NullCheck(L_25);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_26;
		L_26 = VirtFuncInvoker0< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(47 /* System.Byte[] System.IO.MemoryStream::ToArray() */, L_25);
		NullCheck(L_24);
		String_t* L_27;
		L_27 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_24, L_26);
		V_1 = L_27;
		goto IL_00ab;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0097;
		}
		throw e;
	}

CATCH_0097:
	{ // begin catch(System.Exception)
		V_8 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		Exception_t * L_28 = V_8;
		NullCheck(L_28);
		String_t* L_29;
		L_29 = VirtFuncInvoker0< String_t* >::Invoke(19 /* System.String System.Exception::get_Message() */, L_28);
		IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var)));
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_29, /*hidden argument*/NULL);
		String_t* L_30 = ___decryptString0;
		V_1 = L_30;
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_00ab;
	} // end catch (depth: 1)

IL_00ab:
	{
		String_t* L_31 = V_1;
		return L_31;
	}
}
// System.String TapTap.Common.DataStorage::GetMacAddress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DataStorage_GetMacAddress_m48AD5D8EAA598DD27855E4858E78265E1151C11D (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDE78B901DD2022341C7FB711583371AC6F2A0D4C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFDAF0D0039EA977A99E4D2F12EEED51267FAD6E4);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC* V_1 = NULL;
	bool V_2 = false;
	String_t* V_3 = NULL;
	NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC* V_4 = NULL;
	int32_t V_5 = 0;
	NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * V_6 = NULL;
	bool V_7 = false;
	bool V_8 = false;
	int32_t G_B3_0 = 0;
	{
		V_0 = _stringLiteralFDAF0D0039EA977A99E4D2F12EEED51267FAD6E4;
		bool L_0;
		L_0 = Platform_IsAndroid_m3A9B875D7C3220A474C32E883D3FEF629E1105C0(/*hidden argument*/NULL);
		if (L_0)
		{
			goto IL_0015;
		}
	}
	{
		bool L_1;
		L_1 = Platform_IsIOS_m86A73A9650A84E8AAC86F9EE18B6954A75A6D6C4(/*hidden argument*/NULL);
		G_B3_0 = ((int32_t)(L_1));
		goto IL_0016;
	}

IL_0015:
	{
		G_B3_0 = 1;
	}

IL_0016:
	{
		V_2 = (bool)G_B3_0;
		bool L_2 = V_2;
		if (!L_2)
		{
			goto IL_001f;
		}
	}
	{
		String_t* L_3 = V_0;
		V_3 = L_3;
		goto IL_0094;
	}

IL_001f:
	{
		NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC* L_4;
		L_4 = NetworkInterface_GetAllNetworkInterfaces_mC0EF91AC837841CDC0ED9E040745F215079235B1(/*hidden argument*/NULL);
		V_1 = L_4;
		NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC* L_5 = V_1;
		V_4 = L_5;
		V_5 = 0;
		goto IL_0088;
	}

IL_002e:
	{
		NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC* L_6 = V_4;
		int32_t L_7 = V_5;
		NullCheck(L_6);
		int32_t L_8 = L_7;
		NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		V_6 = L_9;
		NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * L_10 = V_6;
		NullCheck(L_10);
		String_t* L_11;
		L_11 = VirtFuncInvoker0< String_t* >::Invoke(6 /* System.String System.Net.NetworkInformation.NetworkInterface::get_Description() */, L_10);
		bool L_12;
		L_12 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_11, _stringLiteralDE78B901DD2022341C7FB711583371AC6F2A0D4C, /*hidden argument*/NULL);
		V_7 = L_12;
		bool L_13 = V_7;
		if (!L_13)
		{
			goto IL_005d;
		}
	}
	{
		NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * L_14 = V_6;
		NullCheck(L_14);
		PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957 * L_15;
		L_15 = VirtFuncInvoker0< PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957 * >::Invoke(14 /* System.Net.NetworkInformation.PhysicalAddress System.Net.NetworkInformation.NetworkInterface::GetPhysicalAddress() */, L_14);
		NullCheck(L_15);
		String_t* L_16;
		L_16 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_15);
		V_0 = L_16;
		goto IL_0090;
	}

IL_005d:
	{
		NetworkInterface_tBCC292E547DEA78090B94E5A0B350C23BB9BC6CB * L_17 = V_6;
		NullCheck(L_17);
		PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957 * L_18;
		L_18 = VirtFuncInvoker0< PhysicalAddress_t59F8ACCD8811837F664FF4932EB40D4F12A33957 * >::Invoke(14 /* System.Net.NetworkInformation.PhysicalAddress System.Net.NetworkInformation.NetworkInterface::GetPhysicalAddress() */, L_17);
		NullCheck(L_18);
		String_t* L_19;
		L_19 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_18);
		V_0 = L_19;
		String_t* L_20 = V_0;
		bool L_21;
		L_21 = String_op_Inequality_mDDA2DDED3E7EF042987EB7180EE3E88105F0AAE2(L_20, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, /*hidden argument*/NULL);
		V_8 = L_21;
		bool L_22 = V_8;
		if (!L_22)
		{
			goto IL_007f;
		}
	}
	{
		goto IL_0090;
	}

IL_007f:
	{
		int32_t L_23 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add((int32_t)L_23, (int32_t)1));
	}

IL_0088:
	{
		int32_t L_24 = V_5;
		NetworkInterfaceU5BU5D_t3FBA31630FA64990195C96E0ED0D8B2395D750CC* L_25 = V_4;
		NullCheck(L_25);
		if ((((int32_t)L_24) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_25)->max_length))))))
		{
			goto IL_002e;
		}
	}

IL_0090:
	{
		String_t* L_26 = V_0;
		V_3 = L_26;
		goto IL_0094;
	}

IL_0094:
	{
		String_t* L_27 = V_3;
		return L_27;
	}
}
// System.Void TapTap.Common.DataStorage::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DataStorage__cctor_m12B7CD98F3C11D59C4A113C12A512D82A9069B88 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CPrivateImplementationDetailsU3E_tA85448D1D10374C2576475EF46D71197F7E8D49F____B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0_FieldInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, (uint32_t)8);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_1 = L_0;
		RuntimeFieldHandle_t7BE65FC857501059EBAC9772C93B02CD413D9C96  L_2 = { reinterpret_cast<intptr_t> (U3CPrivateImplementationDetailsU3E_tA85448D1D10374C2576475EF46D71197F7E8D49F____B09DC9A32DE2D32BC21052A2F185044607D11CC58966BA7D7B299FABB7DCBD12_0_FieldInfo_var) };
		RuntimeHelpers_InitializeArray_mE27238308FED781F2D6A719F0903F2E1311B058F((RuntimeArray *)(RuntimeArray *)L_1, L_2, /*hidden argument*/NULL);
		((DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_StaticFields*)il2cpp_codegen_static_fields_for(DataStorage_t663C140FA11A45E8A17C681B3E010DF7F52ABA64_il2cpp_TypeInfo_var))->set_Keys_1(L_1);
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
// TapTap.Common.EngineBridge TapTap.Common.EngineBridge::GetInstance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * EngineBridge_GetInstance_mACAEDDB6409886F592BEAB50DEB1AB1431ACB36B (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * V_3 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		IL2CPP_RUNTIME_CLASS_INIT(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var);
		RuntimeObject * L_0 = ((EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_StaticFields*)il2cpp_codegen_static_fields_for(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var))->get_Locker_2();
		V_0 = L_0;
		V_1 = (bool)0;
	}

IL_0009:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_1 = V_0;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4(L_1, (bool*)(&V_1), /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var);
			EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * L_2 = ((EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_StaticFields*)il2cpp_codegen_static_fields_for(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var))->get__sInstance_0();
			il2cpp_codegen_memory_barrier();
			V_2 = (bool)((((RuntimeObject*)(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F *)L_2) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
			bool L_3 = V_2;
			if (!L_3)
			{
				goto IL_002f;
			}
		}

IL_0021:
		{
			EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * L_4 = (EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F *)il2cpp_codegen_object_new(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var);
			EngineBridge__ctor_mE1570C0E6D3CC96E5F18CF4809B014CC6F49082F(L_4, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var);
			il2cpp_codegen_memory_barrier();
			((EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_StaticFields*)il2cpp_codegen_static_fields_for(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var))->set__sInstance_0(L_4);
		}

IL_002f:
		{
			IL2CPP_LEAVE(0x3D, FINALLY_0032);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0032;
	}

FINALLY_0032:
	{ // begin finally (depth: 1)
		{
			bool L_5 = V_1;
			if (!L_5)
			{
				goto IL_003c;
			}
		}

IL_0035:
		{
			RuntimeObject * L_6 = V_0;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A(L_6, /*hidden argument*/NULL);
		}

IL_003c:
		{
			IL2CPP_END_FINALLY(50)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(50)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x3D, IL_003d)
	}

IL_003d:
	{
		IL2CPP_RUNTIME_CLASS_INIT(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var);
		EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * L_7 = ((EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_StaticFields*)il2cpp_codegen_static_fields_for(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var))->get__sInstance_0();
		il2cpp_codegen_memory_barrier();
		V_3 = L_7;
		goto IL_0047;
	}

IL_0047:
	{
		EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * L_8 = V_3;
		return L_8;
	}
}
// System.Void TapTap.Common.EngineBridge::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridge__ctor_mE1570C0E6D3CC96E5F18CF4809B014CC6F49082F (EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		bool L_0;
		L_0 = Platform_IsAndroid_m3A9B875D7C3220A474C32E883D3FEF629E1105C0(/*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0020;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A_il2cpp_TypeInfo_var);
		BridgeAndroid_t0A9C79470201308209388F3C7D09D320F164758A * L_2;
		L_2 = BridgeAndroid_GetInstance_mBAC5D6916DDC204635DFE9828F23866E00D40514(/*hidden argument*/NULL);
		__this->set__bridge_1(L_2);
		goto IL_0036;
	}

IL_0020:
	{
		bool L_3;
		L_3 = Platform_IsIOS_m86A73A9650A84E8AAC86F9EE18B6954A75A6D6C4(/*hidden argument*/NULL);
		V_1 = L_3;
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_0036;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212_il2cpp_TypeInfo_var);
		BridgeIOS_t091301F6A07360B6B36662434E05AE3955CC8212 * L_5;
		L_5 = BridgeIOS_GetInstance_m49697C9E7289F0A8CC539CA19A5F2A1C272B7C8C(/*hidden argument*/NULL);
		__this->set__bridge_1(L_5);
	}

IL_0036:
	{
		return;
	}
}
// System.Void TapTap.Common.EngineBridge::Register(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridge_Register_mD70714D543199BA27A3DA30F83B8619A068A05F9 (EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * __this, String_t* ___serviceClzName0, String_t* ___serviceImplName1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IBridge_t0EB65E5461387E161F5AA0E871BC9C604206B7B8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* G_B2_0 = NULL;
	RuntimeObject* G_B1_0 = NULL;
	{
		RuntimeObject* L_0 = __this->get__bridge_1();
		RuntimeObject* L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000d;
		}
	}
	{
		goto IL_0015;
	}

IL_000d:
	{
		String_t* L_2 = ___serviceClzName0;
		String_t* L_3 = ___serviceImplName1;
		NullCheck(G_B2_0);
		InterfaceActionInvoker2< String_t*, String_t* >::Invoke(0 /* System.Void TapTap.Common.IBridge::Register(System.String,System.String) */, IBridge_t0EB65E5461387E161F5AA0E871BC9C604206B7B8_il2cpp_TypeInfo_var, G_B2_0, L_2, L_3);
	}

IL_0015:
	{
		return;
	}
}
// System.Void TapTap.Common.EngineBridge::CallHandler(TapTap.Common.Command)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridge_CallHandler_m6EF9012A52172B3B582D268BC64BB0A94C01969F (EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * __this, Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * ___command0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IBridge_t0EB65E5461387E161F5AA0E871BC9C604206B7B8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* G_B2_0 = NULL;
	RuntimeObject* G_B1_0 = NULL;
	{
		RuntimeObject* L_0 = __this->get__bridge_1();
		RuntimeObject* L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000d;
		}
	}
	{
		goto IL_0014;
	}

IL_000d:
	{
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_2 = ___command0;
		NullCheck(G_B2_0);
		InterfaceActionInvoker1< Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * >::Invoke(1 /* System.Void TapTap.Common.IBridge::Call(TapTap.Common.Command) */, IBridge_t0EB65E5461387E161F5AA0E871BC9C604206B7B8_il2cpp_TypeInfo_var, G_B2_0, L_2);
	}

IL_0014:
	{
		return;
	}
}
// System.Void TapTap.Common.EngineBridge::CallHandler(TapTap.Common.Command,System.Action`1<TapTap.Common.Result>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridge_CallHandler_mECD83678524CBC1B7B4397C5833F0F7C6AD07603 (EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * __this, Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * ___command0, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * ___action1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IBridge_t0EB65E5461387E161F5AA0E871BC9C604206B7B8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* G_B2_0 = NULL;
	RuntimeObject* G_B1_0 = NULL;
	{
		RuntimeObject* L_0 = __this->get__bridge_1();
		RuntimeObject* L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000d;
		}
	}
	{
		goto IL_0015;
	}

IL_000d:
	{
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_2 = ___command0;
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_3 = ___action1;
		NullCheck(G_B2_0);
		InterfaceActionInvoker2< Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD *, Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * >::Invoke(2 /* System.Void TapTap.Common.IBridge::Call(TapTap.Common.Command,System.Action`1<TapTap.Common.Result>) */, IBridge_t0EB65E5461387E161F5AA0E871BC9C604206B7B8_il2cpp_TypeInfo_var, G_B2_0, L_2, L_3);
	}

IL_0015:
	{
		return;
	}
}
// System.Threading.Tasks.Task`1<TapTap.Common.Result> TapTap.Common.EngineBridge::Emit(TapTap.Common.Command)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * EngineBridge_Emit_m68302E91805B95A23DECE89CA71C87BF586407C5 (EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F * __this, Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * ___command0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1__ctor_m8A52A1E69EBA2DC131EC8543DE12B9F4E512B4BE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1__ctor_m41DCCC9230519818D858BF703C08AB243D898FF1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1_get_Task_mC18B68B47AD86B33CD5C42F8D2FE3EAA338B825E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass8_0_U3CEmitU3Eb__0_m69B5BE966C6BBD99E6E26D47482C034AB3F28ED4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 * V_0 = NULL;
	Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * V_1 = NULL;
	{
		U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 * L_0 = (U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass8_0__ctor_m3789C85E5AEDAEDA6059CEC611EA642F9C643B0E(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 * L_1 = V_0;
		TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * L_2 = (TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD *)il2cpp_codegen_object_new(TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD_il2cpp_TypeInfo_var);
		TaskCompletionSource_1__ctor_m41DCCC9230519818D858BF703C08AB243D898FF1(L_2, /*hidden argument*/TaskCompletionSource_1__ctor_m41DCCC9230519818D858BF703C08AB243D898FF1_RuntimeMethod_var);
		NullCheck(L_1);
		L_1->set_tcs_0(L_2);
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_3 = ___command0;
		U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 * L_4 = V_0;
		Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 * L_5 = (Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843 *)il2cpp_codegen_object_new(Action_1_t25D670C7B899DA7EB63CE83AA9C0036F59F0C843_il2cpp_TypeInfo_var);
		Action_1__ctor_m8A52A1E69EBA2DC131EC8543DE12B9F4E512B4BE(L_5, L_4, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass8_0_U3CEmitU3Eb__0_m69B5BE966C6BBD99E6E26D47482C034AB3F28ED4_RuntimeMethod_var), /*hidden argument*/Action_1__ctor_m8A52A1E69EBA2DC131EC8543DE12B9F4E512B4BE_RuntimeMethod_var);
		EngineBridge_CallHandler_mECD83678524CBC1B7B4397C5833F0F7C6AD07603(__this, L_3, L_5, /*hidden argument*/NULL);
		U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 * L_6 = V_0;
		NullCheck(L_6);
		TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * L_7 = L_6->get_tcs_0();
		NullCheck(L_7);
		Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * L_8;
		L_8 = TaskCompletionSource_1_get_Task_mC18B68B47AD86B33CD5C42F8D2FE3EAA338B825E_inline(L_7, /*hidden argument*/TaskCompletionSource_1_get_Task_mC18B68B47AD86B33CD5C42F8D2FE3EAA338B825E_RuntimeMethod_var);
		V_1 = L_8;
		goto IL_0034;
	}

IL_0034:
	{
		Task_1_tE64F067EAC172A1763459197DB11B13AD153CA30 * L_9 = V_1;
		return L_9;
	}
}
// System.Boolean TapTap.Common.EngineBridge::CheckResult(TapTap.Common.Result)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool EngineBridge_CheckResult_mBA6639F3A97243C556565544C6E4333E4D770571 (Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * ___result0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	{
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_0 = ___result0;
		V_0 = (bool)((((RuntimeObject*)(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000e;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_0038;
	}

IL_000e:
	{
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_2 = ___result0;
		NullCheck(L_2);
		int32_t L_3 = L_2->get_code_2();
		IL2CPP_RUNTIME_CLASS_INIT(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var);
		int32_t L_4 = ((Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_StaticFields*)il2cpp_codegen_static_fields_for(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var))->get_RESULT_SUCCESS_0();
		V_2 = (bool)((((int32_t)((((int32_t)L_3) == ((int32_t)L_4))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_5 = V_2;
		if (!L_5)
		{
			goto IL_0027;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_0038;
	}

IL_0027:
	{
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_6 = ___result0;
		NullCheck(L_6);
		String_t* L_7 = L_6->get_content_3();
		bool L_8;
		L_8 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_7, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_8) == ((int32_t)0))? 1 : 0);
		goto IL_0038;
	}

IL_0038:
	{
		bool L_9 = V_1;
		return L_9;
	}
}
// System.Void TapTap.Common.EngineBridge::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridge__cctor_m0211B7C61445F6B7D67955D0D79E9EA5A55E31CB (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject * L_0 = (RuntimeObject *)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(L_0, /*hidden argument*/NULL);
		((EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_StaticFields*)il2cpp_codegen_static_fields_for(EngineBridge_tA18F5077267C9EFC3D33C7C7FCFD07472E87226F_il2cpp_TypeInfo_var))->set_Locker_2(L_0);
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
// System.Object TapTap.Common.Json::Deserialize(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Json_Deserialize_m2CF4D537FF2ABA72BB3186ED220ED27EB064BCA7 (String_t* ___json0, const RuntimeMethod* method)
{
	bool V_0 = false;
	RuntimeObject * V_1 = NULL;
	{
		String_t* L_0 = ___json0;
		V_0 = (bool)((((RuntimeObject*)(String_t*)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000e;
		}
	}
	{
		V_1 = NULL;
		goto IL_0017;
	}

IL_000e:
	{
		String_t* L_2 = ___json0;
		RuntimeObject * L_3;
		L_3 = Parser_Parse_m46AC1CDBD66E06E4D59D3960B11D2FEC4C49CE48(L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		goto IL_0017;
	}

IL_0017:
	{
		RuntimeObject * L_4 = V_1;
		return L_4;
	}
}
// System.String TapTap.Common.Json::Serialize(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Json_Serialize_m03AB6071E9A0A5D7197D2BA15B8E265D0876BC52 (RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		RuntimeObject * L_0 = ___obj0;
		String_t* L_1;
		L_1 = Serializer_Serialize_mB98039BD7C2A49AAAB1C2EC7829E8453F751EB9D(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000a;
	}

IL_000a:
	{
		String_t* L_2 = V_0;
		return L_2;
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
// System.Boolean TapTap.Common.Platform::IsAndroid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Platform_IsAndroid_m3A9B875D7C3220A474C32E883D3FEF629E1105C0 (const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0;
		L_0 = Application_get_platform_mB22F7F39CDD46667C3EF64507E55BB7DA18F66C4(/*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)((int32_t)11)))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
// System.Boolean TapTap.Common.Platform::IsIOS()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Platform_IsIOS_m86A73A9650A84E8AAC86F9EE18B6954A75A6D6C4 (const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0;
		L_0 = Application_get_platform_mB22F7F39CDD46667C3EF64507E55BB7DA18F66C4(/*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)8))? 1 : 0);
		goto IL_000c;
	}

IL_000c:
	{
		bool L_1 = V_0;
		return L_1;
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
// System.Void TapTap.Common.Result::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Result__ctor_m3F256B7BE1BF88C8F8F399FA6EEEEDC882D6A8A3 (Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.Result::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Result__ctor_m681484DE5A13EFE6F4E971E9F22FAC7941100226 (Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * __this, String_t* ___json0, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___json0;
		JsonUtility_FromJsonOverwrite_mC97C7C909591A29E72361FB5DBC1A58EEE6DBAEB(L_0, __this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.Result::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Result__cctor_mE030A258EE28DD9E7CF33816E2A920FAC4648188 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		((Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_StaticFields*)il2cpp_codegen_static_fields_for(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var))->set_RESULT_SUCCESS_0(0);
		((Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_StaticFields*)il2cpp_codegen_static_fields_for(Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2_il2cpp_TypeInfo_var))->set_RESULT_ERROR_1((-1));
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
// System.Void TapTap.Common.TapError::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapError__ctor_mC8CCC8EB504990561D0DCACA4E864A26DDBF8CBA (TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 * __this, String_t* ___json0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SafeDictionary_GetValue_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mFA70C2F966B05DCEEE7BDCAF44C103BBFC73ED8B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SafeDictionary_GetValue_TisString_t_m97A16243B1B7E0B8CFD8D82AADFFE856B1EFC47C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral01D43D70585035CC3857149B066E3D05D655DB8B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral60A2E461CC4A1D49199A67B5216F128319CE63CC);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * V_0 = NULL;
	bool V_1 = false;
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___json0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_0, /*hidden argument*/NULL);
		V_1 = L_1;
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0015;
		}
	}
	{
		goto IL_0043;
	}

IL_0015:
	{
		String_t* L_3 = ___json0;
		RuntimeObject * L_4;
		L_4 = Json_Deserialize_m2CF4D537FF2ABA72BB3186ED220ED27EB064BCA7(L_3, /*hidden argument*/NULL);
		V_0 = ((Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)IsInstClass((RuntimeObject*)L_4, Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var));
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_5 = V_0;
		int32_t L_6;
		L_6 = SafeDictionary_GetValue_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mFA70C2F966B05DCEEE7BDCAF44C103BBFC73ED8B(L_5, _stringLiteral60A2E461CC4A1D49199A67B5216F128319CE63CC, /*hidden argument*/SafeDictionary_GetValue_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mFA70C2F966B05DCEEE7BDCAF44C103BBFC73ED8B_RuntimeMethod_var);
		__this->set_code_0(L_6);
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_7 = V_0;
		String_t* L_8;
		L_8 = SafeDictionary_GetValue_TisString_t_m97A16243B1B7E0B8CFD8D82AADFFE856B1EFC47C(L_7, _stringLiteral01D43D70585035CC3857149B066E3D05D655DB8B, /*hidden argument*/SafeDictionary_GetValue_TisString_t_m97A16243B1B7E0B8CFD8D82AADFFE856B1EFC47C_RuntimeMethod_var);
		__this->set_errorDescription_1(L_8);
	}

IL_0043:
	{
		return;
	}
}
// TapTap.Common.TapError TapTap.Common.TapError::SafeConstructorTapError(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 * TapError_SafeConstructorTapError_m1BAE32A4E9DE6742DA083A8F2432C348C54953E4 (String_t* ___json0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 * V_0 = NULL;
	TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 * G_B3_0 = NULL;
	{
		String_t* L_0 = ___json0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_0011;
		}
	}
	{
		String_t* L_2 = ___json0;
		TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 * L_3 = (TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 *)il2cpp_codegen_object_new(TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4_il2cpp_TypeInfo_var);
		TapError__ctor_mC8CCC8EB504990561D0DCACA4E864A26DDBF8CBA(L_3, L_2, /*hidden argument*/NULL);
		G_B3_0 = L_3;
		goto IL_0012;
	}

IL_0011:
	{
		G_B3_0 = ((TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 *)(NULL));
	}

IL_0012:
	{
		V_0 = G_B3_0;
		goto IL_0015;
	}

IL_0015:
	{
		TapError_t95659C0BB32C1D735DB85EF2A1492F9B7B7661E4 * L_4 = V_0;
		return L_4;
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
// System.Int32 TapTap.Common.TapException::get_Code()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TapException_get_Code_m0A29E48236AD32F075570A894390486CFD1777E6 (TapException_tD607DF79F8107AB2AF0C8047B0EC40C8056FFAEB * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_code_17();
		return L_0;
	}
}
// System.Void TapTap.Common.TapException::.ctor(System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapException__ctor_m71BF5EE4B1D76F2E48212DD92AD83A8C7DD8B265 (TapException_tD607DF79F8107AB2AF0C8047B0EC40C8056FFAEB * __this, int32_t ___code0, String_t* ___message1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___message1;
		IL2CPP_RUNTIME_CLASS_INIT(Exception_t_il2cpp_TypeInfo_var);
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(__this, L_0, /*hidden argument*/NULL);
		int32_t L_1 = ___code0;
		__this->set_code_17(L_1);
		String_t* L_2 = ___message1;
		__this->set_message_18(L_2);
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
// System.Void TapTap.Common.Internal.Http.TapHttpUtils::PrintRequest(System.Net.Http.HttpClient,System.Net.Http.HttpRequestMessage,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapHttpUtils_PrintRequest_m969852EC4125DF9D3BC075B701A9C9B57F144A2B (HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20 * ___client0, HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * ___request1, String_t* ___content2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_1_tF46D06728D01AF99F3A346A6E78952EEA27851EB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1168E92C164109D6220480DEDA987085B2A21155);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1693E3C303F951873B4D96A82A6325E92278F3AB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral24313380B89749FA23D81C8CFE7ECADF5F282DF3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral355F7D71617B9D10C0A4030AF4419CFDB06BF0D7);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral35FE427116F84AC6F7F40A6E9940DCDF2CF6CC7B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral694377C0677C61D486C4B5E6D1EC89FC94F03DA2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral83A882DFBD86B63D426331B0F49139080947E516);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral98483F133AA49AA48A0F52F0C8C09C6CAA5A5718);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	RuntimeObject* V_4 = NULL;
	KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  V_5;
	memset((&V_5), 0, sizeof(V_5));
	RuntimeObject* V_6 = NULL;
	KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  V_7;
	memset((&V_7), 0, sizeof(V_7));
	bool V_8 = false;
	RuntimeObject* V_9 = NULL;
	KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  V_10;
	memset((&V_10), 0, sizeof(V_10));
	bool V_11 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 3> __leave_targets;
	{
		Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * L_0;
		L_0 = TapLogger_get_LogDelegate_m6B310D3CB95664848307AD22C45493437991A979_inline(/*hidden argument*/NULL);
		V_1 = (bool)((((RuntimeObject*)(Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_0013;
		}
	}
	{
		goto IL_01fe;
	}

IL_0013:
	{
		HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20 * L_2 = ___client0;
		V_2 = (bool)((((RuntimeObject*)(HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20 *)L_2) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_3 = V_2;
		if (!L_3)
		{
			goto IL_0021;
		}
	}
	{
		goto IL_01fe;
	}

IL_0021:
	{
		HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * L_4 = ___request1;
		V_3 = (bool)((((RuntimeObject*)(HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F *)L_4) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_5 = V_3;
		if (!L_5)
		{
			goto IL_002f;
		}
	}
	{
		goto IL_01fe;
	}

IL_002f:
	{
		StringBuilder_t * L_6 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_6, /*hidden argument*/NULL);
		V_0 = L_6;
		StringBuilder_t * L_7 = V_0;
		NullCheck(L_7);
		StringBuilder_t * L_8;
		L_8 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_7, _stringLiteral83A882DFBD86B63D426331B0F49139080947E516, /*hidden argument*/NULL);
		StringBuilder_t * L_9 = V_0;
		HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * L_10 = ___request1;
		NullCheck(L_10);
		Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * L_11;
		L_11 = HttpRequestMessage_get_RequestUri_mB0637CC446DFCB403DC4C36781474AC9C3556DDB_inline(L_10, /*hidden argument*/NULL);
		String_t* L_12;
		L_12 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(_stringLiteral355F7D71617B9D10C0A4030AF4419CFDB06BF0D7, L_11, /*hidden argument*/NULL);
		NullCheck(L_9);
		StringBuilder_t * L_13;
		L_13 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_9, L_12, /*hidden argument*/NULL);
		StringBuilder_t * L_14 = V_0;
		HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * L_15 = ___request1;
		NullCheck(L_15);
		HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * L_16;
		L_16 = HttpRequestMessage_get_Method_m827225A7FD4B30107C4191325DA6762D6C3469BD_inline(L_15, /*hidden argument*/NULL);
		String_t* L_17;
		L_17 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(_stringLiteral694377C0677C61D486C4B5E6D1EC89FC94F03DA2, L_16, /*hidden argument*/NULL);
		NullCheck(L_14);
		StringBuilder_t * L_18;
		L_18 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_14, L_17, /*hidden argument*/NULL);
		StringBuilder_t * L_19 = V_0;
		NullCheck(L_19);
		StringBuilder_t * L_20;
		L_20 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_19, _stringLiteral35FE427116F84AC6F7F40A6E9940DCDF2CF6CC7B, /*hidden argument*/NULL);
		HttpClient_t6C591CE801CCF126E2F8770F513BFA7DB2800A20 * L_21 = ___client0;
		NullCheck(L_21);
		HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * L_22;
		L_22 = HttpClient_get_DefaultRequestHeaders_mD6D9E9E7568F26ED379CD2F7437FC7FACB73C18B(L_21, /*hidden argument*/NULL);
		NullCheck(L_22);
		RuntimeObject* L_23;
		L_23 = HttpHeaders_GetEnumerator_mFD5B6A73715C23D6998176EB6BCBDB5B6AD40CB3(L_22, /*hidden argument*/NULL);
		V_4 = L_23;
	}

IL_0089:
	try
	{ // begin try (depth: 1)
		{
			goto IL_00c9;
		}

IL_008b:
		{
			RuntimeObject* L_24 = V_4;
			NullCheck(L_24);
			KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  L_25;
			L_25 = InterfaceFuncInvoker0< KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  >::Invoke(0 /* !0 System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.IEnumerable`1<System.String>>>::get_Current() */, IEnumerator_1_tF46D06728D01AF99F3A346A6E78952EEA27851EB_il2cpp_TypeInfo_var, L_24);
			V_5 = L_25;
			StringBuilder_t * L_26 = V_0;
			String_t* L_27;
			L_27 = KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_inline((KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 *)(&V_5), /*hidden argument*/KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_RuntimeMethod_var);
			RuntimeObject* L_28;
			L_28 = KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_inline((KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 *)(&V_5), /*hidden argument*/KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_RuntimeMethod_var);
			StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_29;
			L_29 = Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582(L_28, /*hidden argument*/Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582_RuntimeMethod_var);
			String_t* L_30;
			L_30 = String_Join_m8846EB11F0A221BDE237DE041D17764B36065404(_stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB, L_29, /*hidden argument*/NULL);
			String_t* L_31;
			L_31 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(_stringLiteral24313380B89749FA23D81C8CFE7ECADF5F282DF3, L_27, _stringLiteral1168E92C164109D6220480DEDA987085B2A21155, L_30, /*hidden argument*/NULL);
			NullCheck(L_26);
			StringBuilder_t * L_32;
			L_32 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_26, L_31, /*hidden argument*/NULL);
		}

IL_00c9:
		{
			RuntimeObject* L_33 = V_4;
			NullCheck(L_33);
			bool L_34;
			L_34 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_33);
			if (L_34)
			{
				goto IL_008b;
			}
		}

IL_00d2:
		{
			IL2CPP_LEAVE(0xE1, FINALLY_00d4);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_00d4;
	}

FINALLY_00d4:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_35 = V_4;
			if (!L_35)
			{
				goto IL_00e0;
			}
		}

IL_00d8:
		{
			RuntimeObject* L_36 = V_4;
			NullCheck(L_36);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_36);
		}

IL_00e0:
		{
			IL2CPP_END_FINALLY(212)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(212)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xE1, IL_00e1)
	}

IL_00e1:
	{
		HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * L_37 = ___request1;
		NullCheck(L_37);
		HttpRequestHeaders_t5EC6B1863CE407A0A61AC3637299CB253F26B877 * L_38;
		L_38 = HttpRequestMessage_get_Headers_m177A5885B3271A1B8F03DB145DBE32CC5E837063(L_37, /*hidden argument*/NULL);
		NullCheck(L_38);
		RuntimeObject* L_39;
		L_39 = HttpHeaders_GetEnumerator_mFD5B6A73715C23D6998176EB6BCBDB5B6AD40CB3(L_38, /*hidden argument*/NULL);
		V_6 = L_39;
	}

IL_00ef:
	try
	{ // begin try (depth: 1)
		{
			goto IL_012f;
		}

IL_00f1:
		{
			RuntimeObject* L_40 = V_6;
			NullCheck(L_40);
			KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  L_41;
			L_41 = InterfaceFuncInvoker0< KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  >::Invoke(0 /* !0 System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.IEnumerable`1<System.String>>>::get_Current() */, IEnumerator_1_tF46D06728D01AF99F3A346A6E78952EEA27851EB_il2cpp_TypeInfo_var, L_40);
			V_7 = L_41;
			StringBuilder_t * L_42 = V_0;
			String_t* L_43;
			L_43 = KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_inline((KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 *)(&V_7), /*hidden argument*/KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_RuntimeMethod_var);
			RuntimeObject* L_44;
			L_44 = KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_inline((KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 *)(&V_7), /*hidden argument*/KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_RuntimeMethod_var);
			StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_45;
			L_45 = Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582(L_44, /*hidden argument*/Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582_RuntimeMethod_var);
			String_t* L_46;
			L_46 = String_Join_m8846EB11F0A221BDE237DE041D17764B36065404(_stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB, L_45, /*hidden argument*/NULL);
			String_t* L_47;
			L_47 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(_stringLiteral24313380B89749FA23D81C8CFE7ECADF5F282DF3, L_43, _stringLiteral1168E92C164109D6220480DEDA987085B2A21155, L_46, /*hidden argument*/NULL);
			NullCheck(L_42);
			StringBuilder_t * L_48;
			L_48 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_42, L_47, /*hidden argument*/NULL);
		}

IL_012f:
		{
			RuntimeObject* L_49 = V_6;
			NullCheck(L_49);
			bool L_50;
			L_50 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_49);
			if (L_50)
			{
				goto IL_00f1;
			}
		}

IL_0138:
		{
			IL2CPP_LEAVE(0x147, FINALLY_013a);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_013a;
	}

FINALLY_013a:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_51 = V_6;
			if (!L_51)
			{
				goto IL_0146;
			}
		}

IL_013e:
		{
			RuntimeObject* L_52 = V_6;
			NullCheck(L_52);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_52);
		}

IL_0146:
		{
			IL2CPP_END_FINALLY(314)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(314)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x147, IL_0147)
	}

IL_0147:
	{
		HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * L_53 = ___request1;
		NullCheck(L_53);
		HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * L_54;
		L_54 = HttpRequestMessage_get_Content_mCD96F88223EA230AC47CC295A00574F52582D0D4_inline(L_53, /*hidden argument*/NULL);
		V_8 = (bool)((!(((RuntimeObject*)(HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 *)L_54) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_55 = V_8;
		if (!L_55)
		{
			goto IL_01c3;
		}
	}
	{
		HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * L_56 = ___request1;
		NullCheck(L_56);
		HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * L_57;
		L_57 = HttpRequestMessage_get_Content_mCD96F88223EA230AC47CC295A00574F52582D0D4_inline(L_56, /*hidden argument*/NULL);
		NullCheck(L_57);
		HttpContentHeaders_tE70F873314496D11A4823BE35556E4F03FD47573 * L_58;
		L_58 = HttpContent_get_Headers_m8EA225DA03A60734A63156D7EA6AC36228F953E9(L_57, /*hidden argument*/NULL);
		NullCheck(L_58);
		RuntimeObject* L_59;
		L_59 = HttpHeaders_GetEnumerator_mFD5B6A73715C23D6998176EB6BCBDB5B6AD40CB3(L_58, /*hidden argument*/NULL);
		V_9 = L_59;
	}

IL_016a:
	try
	{ // begin try (depth: 1)
		{
			goto IL_01aa;
		}

IL_016c:
		{
			RuntimeObject* L_60 = V_9;
			NullCheck(L_60);
			KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  L_61;
			L_61 = InterfaceFuncInvoker0< KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38  >::Invoke(0 /* !0 System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,System.Collections.Generic.IEnumerable`1<System.String>>>::get_Current() */, IEnumerator_1_tF46D06728D01AF99F3A346A6E78952EEA27851EB_il2cpp_TypeInfo_var, L_60);
			V_10 = L_61;
			StringBuilder_t * L_62 = V_0;
			String_t* L_63;
			L_63 = KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_inline((KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 *)(&V_10), /*hidden argument*/KeyValuePair_2_get_Key_m268B2B1AA17E496E22BD3135D387D2D03A88ECEC_RuntimeMethod_var);
			RuntimeObject* L_64;
			L_64 = KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_inline((KeyValuePair_2_tFBE4785A593E0906126E2B15AA7A9D45E41F9A38 *)(&V_10), /*hidden argument*/KeyValuePair_2_get_Value_m5E8B6617E1737DED71D148793111DFDAD9481119_RuntimeMethod_var);
			StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_65;
			L_65 = Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582(L_64, /*hidden argument*/Enumerable_ToArray_TisString_t_mE824E1F8EB2A50DC8E24291957CBEED8C356E582_RuntimeMethod_var);
			String_t* L_66;
			L_66 = String_Join_m8846EB11F0A221BDE237DE041D17764B36065404(_stringLiteralC18C9BB6DF0D5C60CE5A5D2D3D6111BEB6F8CCEB, L_65, /*hidden argument*/NULL);
			String_t* L_67;
			L_67 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(_stringLiteral24313380B89749FA23D81C8CFE7ECADF5F282DF3, L_63, _stringLiteral1168E92C164109D6220480DEDA987085B2A21155, L_66, /*hidden argument*/NULL);
			NullCheck(L_62);
			StringBuilder_t * L_68;
			L_68 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_62, L_67, /*hidden argument*/NULL);
		}

IL_01aa:
		{
			RuntimeObject* L_69 = V_9;
			NullCheck(L_69);
			bool L_70;
			L_70 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_69);
			if (L_70)
			{
				goto IL_016c;
			}
		}

IL_01b3:
		{
			IL2CPP_LEAVE(0x1C2, FINALLY_01b5);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_01b5;
	}

FINALLY_01b5:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_71 = V_9;
			if (!L_71)
			{
				goto IL_01c1;
			}
		}

IL_01b9:
		{
			RuntimeObject* L_72 = V_9;
			NullCheck(L_72);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_72);
		}

IL_01c1:
		{
			IL2CPP_END_FINALLY(437)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(437)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x1C2, IL_01c2)
	}

IL_01c2:
	{
	}

IL_01c3:
	{
		String_t* L_73 = ___content2;
		bool L_74;
		L_74 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_73, /*hidden argument*/NULL);
		V_11 = (bool)((((int32_t)L_74) == ((int32_t)0))? 1 : 0);
		bool L_75 = V_11;
		if (!L_75)
		{
			goto IL_01e6;
		}
	}
	{
		StringBuilder_t * L_76 = V_0;
		String_t* L_77 = ___content2;
		String_t* L_78;
		L_78 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(_stringLiteral1693E3C303F951873B4D96A82A6325E92278F3AB, L_77, /*hidden argument*/NULL);
		NullCheck(L_76);
		StringBuilder_t * L_79;
		L_79 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_76, L_78, /*hidden argument*/NULL);
	}

IL_01e6:
	{
		StringBuilder_t * L_80 = V_0;
		NullCheck(L_80);
		StringBuilder_t * L_81;
		L_81 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_80, _stringLiteral98483F133AA49AA48A0F52F0C8C09C6CAA5A5718, /*hidden argument*/NULL);
		StringBuilder_t * L_82 = V_0;
		NullCheck(L_82);
		String_t* L_83;
		L_83 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_82);
		TapLogger_Debug_m92BE9D78969DA2AD33F1C88683F5BE1327285C54(L_83, /*hidden argument*/NULL);
	}

IL_01fe:
	{
		return;
	}
}
// System.Void TapTap.Common.Internal.Http.TapHttpUtils::PrintResponse(System.Net.Http.HttpResponseMessage,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapHttpUtils_PrintResponse_mCB4BD5418F456E477F14531BD54298EA3659ECD8 (HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752 * ___response0, String_t* ___content1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HttpStatusCode_tFCB1BA96A101857DA7C390345DE43B77F9567D98_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral13AE6958E793A1F95208712D9C75F93E88433FFD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1693E3C303F951873B4D96A82A6325E92278F3AB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral355F7D71617B9D10C0A4030AF4419CFDB06BF0D7);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5F161BA1450058E111D0B820CF591B319CD3B136);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6041A91147E542D6A2F83C8B08CE89CC68742E51);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	{
		Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * L_0;
		L_0 = TapLogger_get_LogDelegate_m6B310D3CB95664848307AD22C45493437991A979_inline(/*hidden argument*/NULL);
		V_1 = (bool)((((RuntimeObject*)(Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_0013;
		}
	}
	{
		goto IL_0096;
	}

IL_0013:
	{
		StringBuilder_t * L_2 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_2, /*hidden argument*/NULL);
		V_0 = L_2;
		StringBuilder_t * L_3 = V_0;
		NullCheck(L_3);
		StringBuilder_t * L_4;
		L_4 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_3, _stringLiteral5F161BA1450058E111D0B820CF591B319CD3B136, /*hidden argument*/NULL);
		StringBuilder_t * L_5 = V_0;
		HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752 * L_6 = ___response0;
		NullCheck(L_6);
		HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * L_7;
		L_7 = HttpResponseMessage_get_RequestMessage_m1AADFCBFE233491EC18E65D6342833A1CEB52486_inline(L_6, /*hidden argument*/NULL);
		NullCheck(L_7);
		Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * L_8;
		L_8 = HttpRequestMessage_get_RequestUri_mB0637CC446DFCB403DC4C36781474AC9C3556DDB_inline(L_7, /*hidden argument*/NULL);
		String_t* L_9;
		L_9 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(_stringLiteral355F7D71617B9D10C0A4030AF4419CFDB06BF0D7, L_8, /*hidden argument*/NULL);
		NullCheck(L_5);
		StringBuilder_t * L_10;
		L_10 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_5, L_9, /*hidden argument*/NULL);
		StringBuilder_t * L_11 = V_0;
		HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752 * L_12 = ___response0;
		NullCheck(L_12);
		int32_t L_13;
		L_13 = HttpResponseMessage_get_StatusCode_m566EA4F3B9AF052B4A59C34F51191B926BFED7CB_inline(L_12, /*hidden argument*/NULL);
		int32_t L_14 = L_13;
		RuntimeObject * L_15 = Box(HttpStatusCode_tFCB1BA96A101857DA7C390345DE43B77F9567D98_il2cpp_TypeInfo_var, &L_14);
		String_t* L_16;
		L_16 = String_Format_mB3D38E5238C3164DB4D7D29339D9E225A4496D17(_stringLiteral13AE6958E793A1F95208712D9C75F93E88433FFD, L_15, /*hidden argument*/NULL);
		NullCheck(L_11);
		StringBuilder_t * L_17;
		L_17 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_11, L_16, /*hidden argument*/NULL);
		String_t* L_18 = ___content1;
		bool L_19;
		L_19 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_18, /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)L_19) == ((int32_t)0))? 1 : 0);
		bool L_20 = V_2;
		if (!L_20)
		{
			goto IL_007e;
		}
	}
	{
		StringBuilder_t * L_21 = V_0;
		String_t* L_22 = ___content1;
		String_t* L_23;
		L_23 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(_stringLiteral1693E3C303F951873B4D96A82A6325E92278F3AB, L_22, /*hidden argument*/NULL);
		NullCheck(L_21);
		StringBuilder_t * L_24;
		L_24 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_21, L_23, /*hidden argument*/NULL);
	}

IL_007e:
	{
		StringBuilder_t * L_25 = V_0;
		NullCheck(L_25);
		StringBuilder_t * L_26;
		L_26 = StringBuilder_AppendLine_m4FBF9761747825683B04B18842DF906473EEF7C8(L_25, _stringLiteral6041A91147E542D6A2F83C8B08CE89CC68742E51, /*hidden argument*/NULL);
		StringBuilder_t * L_27 = V_0;
		NullCheck(L_27);
		String_t* L_28;
		L_28 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_27);
		TapLogger_Debug_m92BE9D78969DA2AD33F1C88683F5BE1327285C54(L_28, /*hidden argument*/NULL);
	}

IL_0096:
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
// System.Boolean TapTap.Common.Internal.Json.TapJsonConverter::CanConvert(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TapJsonConverter_CanConvert_mF9F8EF5775DCF373B636EC30E55D77E5EA7A3724 (TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * __this, Type_t * ___objectType0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		Type_t * L_0 = ___objectType0;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_1 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_2;
		L_2 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E(L_1, /*hidden argument*/NULL);
		bool L_3;
		L_3 = Type_op_Equality_mA438719A1FDF103C7BBBB08AEF564E7FAEEA0046(L_0, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_0014;
	}

IL_0014:
	{
		bool L_4 = V_0;
		return L_4;
	}
}
// System.Void TapTap.Common.Internal.Json.TapJsonConverter::WriteJson(LC.Newtonsoft.Json.JsonWriter,System.Object,LC.Newtonsoft.Json.JsonSerializer)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapJsonConverter_WriteJson_m0B620346B2CB74679C146A800BAC1A011F942851 (TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * __this, JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008 * ___writer0, RuntimeObject * ___value1, JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * ___serializer2, const RuntimeMethod* method)
{
	{
		JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * L_0 = ___serializer2;
		JsonWriter_t88BD5D515C6194C6858E3D1981EE6940B20A0008 * L_1 = ___writer0;
		RuntimeObject * L_2 = ___value1;
		NullCheck(L_0);
		JsonSerializer_Serialize_mE7CF8F2F57FFCE3531DE957D8DF5F4BE3BD09052(L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Object TapTap.Common.Internal.Json.TapJsonConverter::ReadJson(LC.Newtonsoft.Json.JsonReader,System.Type,System.Object,LC.Newtonsoft.Json.JsonSerializer)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * TapJsonConverter_ReadJson_mFA6ED7B3B24CEC012E463947287EBB5E0673CCD1 (TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * __this, JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * ___reader0, Type_t * ___objectType1, RuntimeObject * ___existingValue2, JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * ___serializer3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * V_1 = NULL;
	RuntimeObject * V_2 = NULL;
	bool V_3 = false;
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * V_4 = NULL;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	{
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_0 = ___reader0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(5 /* LC.Newtonsoft.Json.JsonToken LC.Newtonsoft.Json.JsonReader::get_TokenType() */, L_0);
		V_0 = (bool)((((int32_t)L_1) == ((int32_t)1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0026;
		}
	}
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_3 = (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)il2cpp_codegen_object_new(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63(L_3, /*hidden argument*/Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		V_1 = L_3;
		JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * L_4 = ___serializer3;
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_5 = ___reader0;
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_6 = V_1;
		NullCheck(L_4);
		JsonSerializer_Populate_m017C22B05AB4B0C5F938F2DA1ED01690491D6E5B(L_4, L_5, L_6, /*hidden argument*/NULL);
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_7 = V_1;
		V_2 = L_7;
		goto IL_00b7;
	}

IL_0026:
	{
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_8 = ___reader0;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = VirtFuncInvoker0< int32_t >::Invoke(5 /* LC.Newtonsoft.Json.JsonToken LC.Newtonsoft.Json.JsonReader::get_TokenType() */, L_8);
		V_3 = (bool)((((int32_t)L_9) == ((int32_t)2))? 1 : 0);
		bool L_10 = V_3;
		if (!L_10)
		{
			goto IL_004b;
		}
	}
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_11 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)il2cpp_codegen_object_new(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_il2cpp_TypeInfo_var);
		List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B(L_11, /*hidden argument*/List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_RuntimeMethod_var);
		V_4 = L_11;
		JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * L_12 = ___serializer3;
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_13 = ___reader0;
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_14 = V_4;
		NullCheck(L_12);
		JsonSerializer_Populate_m017C22B05AB4B0C5F938F2DA1ED01690491D6E5B(L_12, L_13, L_14, /*hidden argument*/NULL);
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_15 = V_4;
		V_2 = L_15;
		goto IL_00b7;
	}

IL_004b:
	{
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_16 = ___reader0;
		NullCheck(L_16);
		int32_t L_17;
		L_17 = VirtFuncInvoker0< int32_t >::Invoke(5 /* LC.Newtonsoft.Json.JsonToken LC.Newtonsoft.Json.JsonReader::get_TokenType() */, L_16);
		V_5 = (bool)((((int32_t)L_17) == ((int32_t)7))? 1 : 0);
		bool L_18 = V_5;
		if (!L_18)
		{
			goto IL_0089;
		}
	}
	{
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_19 = ___reader0;
		NullCheck(L_19);
		RuntimeObject * L_20;
		L_20 = VirtFuncInvoker0< RuntimeObject * >::Invoke(6 /* System.Object LC.Newtonsoft.Json.JsonReader::get_Value() */, L_19);
		V_6 = (bool)((((int64_t)((*(int64_t*)((int64_t*)UnBox(L_20, Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var))))) < ((int64_t)((int64_t)((int64_t)((int32_t)2147483647LL)))))? 1 : 0);
		bool L_21 = V_6;
		if (!L_21)
		{
			goto IL_0088;
		}
	}
	{
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_22 = ___reader0;
		NullCheck(L_22);
		RuntimeObject * L_23;
		L_23 = VirtFuncInvoker0< RuntimeObject * >::Invoke(6 /* System.Object LC.Newtonsoft.Json.JsonReader::get_Value() */, L_22);
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		int32_t L_24;
		L_24 = Convert_ToInt32_mFFEDED67681E3EC8705BCA890BBC206514431B4A(L_23, /*hidden argument*/NULL);
		int32_t L_25 = L_24;
		RuntimeObject * L_26 = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &L_25);
		V_2 = L_26;
		goto IL_00b7;
	}

IL_0088:
	{
	}

IL_0089:
	{
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_27 = ___reader0;
		NullCheck(L_27);
		int32_t L_28;
		L_28 = VirtFuncInvoker0< int32_t >::Invoke(5 /* LC.Newtonsoft.Json.JsonToken LC.Newtonsoft.Json.JsonReader::get_TokenType() */, L_27);
		V_7 = (bool)((((int32_t)L_28) == ((int32_t)8))? 1 : 0);
		bool L_29 = V_7;
		if (!L_29)
		{
			goto IL_00ac;
		}
	}
	{
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_30 = ___reader0;
		NullCheck(L_30);
		RuntimeObject * L_31;
		L_31 = VirtFuncInvoker0< RuntimeObject * >::Invoke(6 /* System.Object LC.Newtonsoft.Json.JsonReader::get_Value() */, L_30);
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		float L_32;
		L_32 = Convert_ToSingle_m40AEA5CD6F34773800A3A7CD0A132170315E75CC(L_31, /*hidden argument*/NULL);
		float L_33 = L_32;
		RuntimeObject * L_34 = Box(Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_il2cpp_TypeInfo_var, &L_33);
		V_2 = L_34;
		goto IL_00b7;
	}

IL_00ac:
	{
		JsonSerializer_tA6BE70B7EB60B86B8DC764A0F5DB886D2071056B * L_35 = ___serializer3;
		JsonReader_t2FCBED9C431B2645B34B9E1B35988452DF01045B * L_36 = ___reader0;
		NullCheck(L_35);
		RuntimeObject * L_37;
		L_37 = JsonSerializer_Deserialize_m34720808B03856029E60204E77B838C0EF5FF595(L_35, L_36, /*hidden argument*/NULL);
		V_2 = L_37;
		goto IL_00b7;
	}

IL_00b7:
	{
		RuntimeObject * L_38 = V_2;
		return L_38;
	}
}
// System.Void TapTap.Common.Internal.Json.TapJsonConverter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapJsonConverter__ctor_m1CA0A7FCF378BD5B9EA4C933698D3DCC122E44B4 (TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * __this, const RuntimeMethod* method)
{
	{
		JsonConverter__ctor_m865BB71241002EC00FFF45238EAFD5302166B392(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.Internal.Json.TapJsonConverter::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapJsonConverter__cctor_m4FAB5A16A728DAA342E728469A245A4E5FB3AF80 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE * L_0 = (TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE *)il2cpp_codegen_object_new(TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE_il2cpp_TypeInfo_var);
		TapJsonConverter__ctor_m1CA0A7FCF378BD5B9EA4C933698D3DCC122E44B4(L_0, /*hidden argument*/NULL);
		((TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE_StaticFields*)il2cpp_codegen_static_fields_for(TapJsonConverter_tE7F297A71E3579781D285B2E98E6F747C9D0F7FE_il2cpp_TypeInfo_var))->set_Default_0(L_0);
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
// TapTap.Common.TapLocalizeManager TapTap.Common.TapLocalizeManager::get_Instance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * V_1 = NULL;
	RuntimeObject * V_2 = NULL;
	bool V_3 = false;
	bool V_4 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_0 = ((TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields*)il2cpp_codegen_static_fields_for(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var))->get__instance_0();
		il2cpp_codegen_memory_barrier();
		V_0 = (bool)((!(((RuntimeObject*)(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB *)L_0) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_2 = ((TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields*)il2cpp_codegen_static_fields_for(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var))->get__instance_0();
		il2cpp_codegen_memory_barrier();
		V_1 = L_2;
		goto IL_0061;
	}

IL_0019:
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		RuntimeObject * L_3 = ((TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields*)il2cpp_codegen_static_fields_for(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var))->get_ObjLock_1();
		V_2 = L_3;
		V_3 = (bool)0;
	}

IL_0021:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_4 = V_2;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4(L_4, (bool*)(&V_3), /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
			TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_5 = ((TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields*)il2cpp_codegen_static_fields_for(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var))->get__instance_0();
			il2cpp_codegen_memory_barrier();
			V_4 = (bool)((((RuntimeObject*)(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB *)L_5) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
			bool L_6 = V_4;
			if (!L_6)
			{
				goto IL_0049;
			}
		}

IL_003b:
		{
			TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_7 = (TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB *)il2cpp_codegen_object_new(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
			TapLocalizeManager__ctor_mF53DFDD8735EE593E256BDECE3A8540BB8D2453C(L_7, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
			il2cpp_codegen_memory_barrier();
			((TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields*)il2cpp_codegen_static_fields_for(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var))->set__instance_0(L_7);
		}

IL_0049:
		{
			IL2CPP_LEAVE(0x57, FINALLY_004c);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_004c;
	}

FINALLY_004c:
	{ // begin finally (depth: 1)
		{
			bool L_8 = V_3;
			if (!L_8)
			{
				goto IL_0056;
			}
		}

IL_004f:
		{
			RuntimeObject * L_9 = V_2;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A(L_9, /*hidden argument*/NULL);
		}

IL_0056:
		{
			IL2CPP_END_FINALLY(76)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(76)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x57, IL_0057)
	}

IL_0057:
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_10 = ((TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields*)il2cpp_codegen_static_fields_for(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var))->get__instance_0();
		il2cpp_codegen_memory_barrier();
		V_1 = L_10;
		goto IL_0061;
	}

IL_0061:
	{
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_11 = V_1;
		return L_11;
	}
}
// System.Void TapTap.Common.TapLocalizeManager::SetCurrentRegion(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLocalizeManager_SetCurrentRegion_mCE4E27C776AE2048AFA02DE05E618D2E78FFEB8A (bool ___isCn0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_0;
		L_0 = TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA(/*hidden argument*/NULL);
		bool L_1 = ___isCn0;
		NullCheck(L_0);
		L_0->set__regionIsCn_3(L_1);
		return;
	}
}
// TapTap.Common.TapLanguage TapTap.Common.TapLocalizeManager::GetCurrentLanguage()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TapLocalizeManager_GetCurrentLanguage_mB854A9A8971D3FCCC6FF73E12D3430D488868887 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t V_1 = 0;
	bool V_2 = false;
	TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * G_B5_0 = NULL;
	TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * G_B4_0 = NULL;
	int32_t G_B6_0 = 0;
	TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * G_B6_1 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_0;
		L_0 = TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA(/*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1 = L_0->get__language_2();
		V_0 = (bool)((!(((uint32_t)L_1) <= ((uint32_t)0)))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001f;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_3;
		L_3 = TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA(/*hidden argument*/NULL);
		NullCheck(L_3);
		int32_t L_4 = L_3->get__language_2();
		V_1 = L_4;
		goto IL_0068;
	}

IL_001f:
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_5;
		L_5 = TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA(/*hidden argument*/NULL);
		int32_t L_6;
		L_6 = TapLocalizeManager_GetSystemLanguage_mFD1419920E599645E6B260B696F779A1394CABBE(/*hidden argument*/NULL);
		NullCheck(L_5);
		L_5->set__language_2(L_6);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_7;
		L_7 = TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA(/*hidden argument*/NULL);
		NullCheck(L_7);
		int32_t L_8 = L_7->get__language_2();
		V_2 = (bool)((((int32_t)L_8) == ((int32_t)0))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_005b;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_10;
		L_10 = TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA(/*hidden argument*/NULL);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_11;
		L_11 = TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA(/*hidden argument*/NULL);
		NullCheck(L_11);
		bool L_12 = L_11->get__regionIsCn_3();
		G_B4_0 = L_10;
		if (L_12)
		{
			G_B5_0 = L_10;
			goto IL_0054;
		}
	}
	{
		G_B6_0 = 2;
		G_B6_1 = G_B4_0;
		goto IL_0055;
	}

IL_0054:
	{
		G_B6_0 = 1;
		G_B6_1 = G_B5_0;
	}

IL_0055:
	{
		NullCheck(G_B6_1);
		G_B6_1->set__language_2(G_B6_0);
	}

IL_005b:
	{
		IL2CPP_RUNTIME_CLASS_INIT(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * L_13;
		L_13 = TapLocalizeManager_get_Instance_mAA401631964A8C84040F4F245977D36BA03F6DBA(/*hidden argument*/NULL);
		NullCheck(L_13);
		int32_t L_14 = L_13->get__language_2();
		V_1 = L_14;
		goto IL_0068;
	}

IL_0068:
	{
		int32_t L_15 = V_1;
		return L_15;
	}
}
// TapTap.Common.TapLanguage TapTap.Common.TapLocalizeManager::GetSystemLanguage()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TapLocalizeManager_GetSystemLanguage_mFD1419920E599645E6B260B696F779A1394CABBE (const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	{
		V_0 = 0;
		int32_t L_0;
		L_0 = Application_get_systemLanguage_m97271242ECD614FD02DC6BEB912CDDB6DD2BD045(/*hidden argument*/NULL);
		V_1 = L_0;
		int32_t L_1 = V_1;
		V_3 = L_1;
		int32_t L_2 = V_3;
		V_2 = L_2;
		int32_t L_3 = V_2;
		if ((((int32_t)L_3) > ((int32_t)((int32_t)23))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_4 = V_2;
		if ((((int32_t)L_4) == ((int32_t)((int32_t)10))))
		{
			goto IL_004d;
		}
	}
	{
		goto IL_0019;
	}

IL_0019:
	{
		int32_t L_5 = V_2;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_5, (int32_t)((int32_t)20))))
		{
			case 0:
			{
				goto IL_0061;
			}
			case 1:
			{
				goto IL_0065;
			}
			case 2:
			{
				goto IL_0055;
			}
			case 3:
			{
				goto IL_0059;
			}
		}
	}
	{
		goto IL_0065;
	}

IL_0034:
	{
		int32_t L_6 = V_2;
		if ((((int32_t)L_6) == ((int32_t)((int32_t)36))))
		{
			goto IL_005d;
		}
	}
	{
		goto IL_003b;
	}

IL_003b:
	{
		int32_t L_7 = V_2;
		if ((((int32_t)L_7) == ((int32_t)((int32_t)40))))
		{
			goto IL_0049;
		}
	}
	{
		goto IL_0042;
	}

IL_0042:
	{
		int32_t L_8 = V_2;
		if ((((int32_t)L_8) == ((int32_t)((int32_t)41))))
		{
			goto IL_0051;
		}
	}
	{
		goto IL_0065;
	}

IL_0049:
	{
		V_0 = 1;
		goto IL_0065;
	}

IL_004d:
	{
		V_0 = 2;
		goto IL_0065;
	}

IL_0051:
	{
		V_0 = 3;
		goto IL_0065;
	}

IL_0055:
	{
		V_0 = 4;
		goto IL_0065;
	}

IL_0059:
	{
		V_0 = 5;
		goto IL_0065;
	}

IL_005d:
	{
		V_0 = 6;
		goto IL_0065;
	}

IL_0061:
	{
		V_0 = 7;
		goto IL_0065;
	}

IL_0065:
	{
		int32_t L_9 = V_0;
		V_4 = L_9;
		goto IL_006a;
	}

IL_006a:
	{
		int32_t L_10 = V_4;
		return L_10;
	}
}
// System.Void TapTap.Common.TapLocalizeManager::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLocalizeManager__ctor_mF53DFDD8735EE593E256BDECE3A8540BB8D2453C (TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB * __this, const RuntimeMethod* method)
{
	{
		__this->set__language_2(0);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.TapLocalizeManager::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLocalizeManager__cctor_m57E4E6984D01078E7462EA886480E40143406888 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject * L_0 = (RuntimeObject *)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(L_0, /*hidden argument*/NULL);
		((TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_StaticFields*)il2cpp_codegen_static_fields_for(TapLocalizeManager_t2E5FF4ECDCBB9A5FAEDCF24C48181A1DD9D1DAEB_il2cpp_TypeInfo_var))->set_ObjLock_1(L_0);
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
// System.Action`2<TapTap.Common.TapLogLevel,System.String> TapTap.Common.TapLogger::get_LogDelegate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * TapLogger_get_LogDelegate_m6B310D3CB95664848307AD22C45493437991A979 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * L_0 = ((TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_StaticFields*)il2cpp_codegen_static_fields_for(TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_il2cpp_TypeInfo_var))->get_U3CLogDelegateU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void TapTap.Common.TapLogger::Debug(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLogger_Debug_m92BE9D78969DA2AD33F1C88683F5BE1327285C54 (String_t* ___log0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_2_Invoke_mAD6B0F23BFA144D866A6A4196D5E1A19CA8A8E4F_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * G_B2_0 = NULL;
	Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * G_B1_0 = NULL;
	{
		Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * L_0;
		L_0 = TapLogger_get_LogDelegate_m6B310D3CB95664848307AD22C45493437991A979_inline(/*hidden argument*/NULL);
		Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000c;
		}
	}
	{
		goto IL_0014;
	}

IL_000c:
	{
		String_t* L_2 = ___log0;
		NullCheck(G_B2_0);
		Action_2_Invoke_mAD6B0F23BFA144D866A6A4196D5E1A19CA8A8E4F(G_B2_0, 0, L_2, /*hidden argument*/Action_2_Invoke_mAD6B0F23BFA144D866A6A4196D5E1A19CA8A8E4F_RuntimeMethod_var);
	}

IL_0014:
	{
		return;
	}
}
// System.Void TapTap.Common.TapLogger::Error(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLogger_Error_mCBD3898C4A66F803A9565DAF768275BD41E67F2D (String_t* ___log0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_2_Invoke_mAD6B0F23BFA144D866A6A4196D5E1A19CA8A8E4F_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * G_B2_0 = NULL;
	Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * G_B1_0 = NULL;
	{
		Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * L_0;
		L_0 = TapLogger_get_LogDelegate_m6B310D3CB95664848307AD22C45493437991A979_inline(/*hidden argument*/NULL);
		Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000c;
		}
	}
	{
		goto IL_0014;
	}

IL_000c:
	{
		String_t* L_2 = ___log0;
		NullCheck(G_B2_0);
		Action_2_Invoke_mAD6B0F23BFA144D866A6A4196D5E1A19CA8A8E4F(G_B2_0, 2, L_2, /*hidden argument*/Action_2_Invoke_mAD6B0F23BFA144D866A6A4196D5E1A19CA8A8E4F_RuntimeMethod_var);
	}

IL_0014:
	{
		return;
	}
}
// System.Void TapTap.Common.TapLogger::Error(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TapLogger_Error_m0FC69A48DF4527C41B393558C898D6A29CA101A8 (Exception_t * ___e0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringBuilder_t * L_1 = V_0;
		Exception_t * L_2 = ___e0;
		NullCheck(L_2);
		Type_t * L_3;
		L_3 = Exception_GetType_mC5B8B5C944B326B751282AB0E8C25A7F85457D9F(L_2, /*hidden argument*/NULL);
		NullCheck(L_1);
		StringBuilder_t * L_4;
		L_4 = StringBuilder_Append_m545FFB72A578320B1D6EA3772160353FD62C344F(L_1, L_3, /*hidden argument*/NULL);
		StringBuilder_t * L_5 = V_0;
		NullCheck(L_5);
		StringBuilder_t * L_6;
		L_6 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_5, _stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD, /*hidden argument*/NULL);
		StringBuilder_t * L_7 = V_0;
		Exception_t * L_8 = ___e0;
		NullCheck(L_8);
		String_t* L_9;
		L_9 = VirtFuncInvoker0< String_t* >::Invoke(19 /* System.String System.Exception::get_Message() */, L_8);
		NullCheck(L_7);
		StringBuilder_t * L_10;
		L_10 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_7, L_9, /*hidden argument*/NULL);
		StringBuilder_t * L_11 = V_0;
		NullCheck(L_11);
		StringBuilder_t * L_12;
		L_12 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_11, _stringLiteral00B28FF06B788B9B67C6B259800F404F9F3761FD, /*hidden argument*/NULL);
		StringBuilder_t * L_13 = V_0;
		Exception_t * L_14 = ___e0;
		NullCheck(L_14);
		String_t* L_15;
		L_15 = VirtFuncInvoker0< String_t* >::Invoke(22 /* System.String System.Exception::get_StackTrace() */, L_14);
		NullCheck(L_13);
		StringBuilder_t * L_16;
		L_16 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_13, L_15, /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		NullCheck(L_17);
		String_t* L_18;
		L_18 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_17);
		TapLogger_Error_mCBD3898C4A66F803A9565DAF768275BD41E67F2D(L_18, /*hidden argument*/NULL);
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
// System.String TapTap.Common.TapUUID::UUID()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TapUUID_UUID_m34CD600BDA5D524CD97F2C290CF4FFBCBF7C950D (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Guid_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Guid_t  V_0;
	memset((&V_0), 0, sizeof(V_0));
	String_t* V_1 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Guid_t_il2cpp_TypeInfo_var);
		Guid_t  L_0;
		L_0 = Guid_NewGuid_m5BD19325820690ED6ECA31D67BC2CD474DC4FDB0(/*hidden argument*/NULL);
		V_0 = L_0;
		String_t* L_1;
		L_1 = Guid_ToString_mA3AB7742FB0E04808F580868E82BDEB93187FB75((Guid_t *)(&V_0), /*hidden argument*/NULL);
		V_1 = L_1;
		goto IL_0017;
	}

IL_0017:
	{
		String_t* L_2 = V_1;
		return L_2;
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
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A (EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * __this, String_t* ___result0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(char*);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Marshaling of parameter '___result0' to native representation
	char* ____result0_marshaled = NULL;
	____result0_marshaled = il2cpp_codegen_marshal_string(___result0);

	// Native function invocation
	il2cppPInvokeFunc(____result0_marshaled);

	// Marshaling cleanup of parameter '___result0' native representation
	il2cpp_codegen_marshal_free(____result0_marshaled);
	____result0_marshaled = NULL;

}
// System.Void TapTap.Common.BridgeIOS/EngineBridgeDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridgeDelegate__ctor_m0EBCEB007E06DD216B729E56DD960FACFCC9D76C (EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void TapTap.Common.BridgeIOS/EngineBridgeDelegate::Invoke(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridgeDelegate_Invoke_m1E3E15D7871E28E00BC407CF5D999922E5320F0A (EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * __this, String_t* ___result0, const RuntimeMethod* method)
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
				typedef void (*FunctionPointerType) (String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___result0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___result0, targetMethod);
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
						GenericInterfaceActionInvoker0::Invoke(targetMethod, ___result0);
					else
						GenericVirtActionInvoker0::Invoke(targetMethod, ___result0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___result0);
					else
						VirtActionInvoker0::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___result0);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___result0, targetMethod);
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
						GenericInterfaceActionInvoker1< String_t* >::Invoke(targetMethod, targetThis, ___result0);
					else
						GenericVirtActionInvoker1< String_t* >::Invoke(targetMethod, targetThis, ___result0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___result0);
					else
						VirtActionInvoker1< String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___result0);
				}
			}
			else
			{
				if (targetThis == NULL)
				{
					typedef void (*FunctionPointerType) (String_t*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___result0, targetMethod);
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, String_t*, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___result0, targetMethod);
				}
			}
		}
	}
}
// System.IAsyncResult TapTap.Common.BridgeIOS/EngineBridgeDelegate::BeginInvoke(System.String,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* EngineBridgeDelegate_BeginInvoke_mC66E22FF7EFD224E2CFEDD292B6C2E97F7E0AEB9 (EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * __this, String_t* ___result0, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	void *__d_args[2] = {0};
	__d_args[0] = ___result0;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);;
}
// System.Void TapTap.Common.BridgeIOS/EngineBridgeDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void EngineBridgeDelegate_EndInvoke_m06754BE9D0C7604D7AFF179FD868C6CAF48685C0 (EngineBridgeDelegate_tD2B56FF270F3F1A9F5C79E7A7AFDA2387F5E9F7A * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
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
// System.Void TapTap.Common.Command/Builder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Builder__ctor_mCEE493D6911F2D1BD39B2626D98890322B400585 (Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// TapTap.Common.Command/Builder TapTap.Common.Command/Builder::Service(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * Builder_Service_mED33EDF1A695577444A3CBEA7F95A4BDD41CEBA9 (Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * __this, String_t* ___service0, const RuntimeMethod* method)
{
	Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * V_0 = NULL;
	{
		String_t* L_0 = ___service0;
		__this->set_service_0(L_0);
		V_0 = __this;
		goto IL_000c;
	}

IL_000c:
	{
		Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * L_1 = V_0;
		return L_1;
	}
}
// TapTap.Common.Command/Builder TapTap.Common.Command/Builder::Method(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * Builder_Method_mBD41DC24677E38D3B91DEA99AFFFEA69C13BF17A (Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * __this, String_t* ___method0, const RuntimeMethod* method)
{
	Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * V_0 = NULL;
	{
		String_t* L_0 = ___method0;
		__this->set_method_1(L_0);
		V_0 = __this;
		goto IL_000c;
	}

IL_000c:
	{
		Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * L_1 = V_0;
		return L_1;
	}
}
// TapTap.Common.Command/Builder TapTap.Common.Command/Builder::OnceTime(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * Builder_OnceTime_mDB8550344C9DA4B25E74AC5183D3382B639EA5F7 (Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * __this, bool ___onceTime0, const RuntimeMethod* method)
{
	Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * V_0 = NULL;
	{
		bool L_0 = ___onceTime0;
		__this->set_onceTime_4(L_0);
		V_0 = __this;
		goto IL_000c;
	}

IL_000c:
	{
		Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * L_1 = V_0;
		return L_1;
	}
}
// TapTap.Common.Command/Builder TapTap.Common.Command/Builder::Args(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * Builder_Args_mE6D5019F74172456032E72E06A186D5755DFDEBD (Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * __this, String_t* ___key0, RuntimeObject * ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * V_2 = NULL;
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_0 = __this->get_args_5();
		V_0 = (bool)((((RuntimeObject*)(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001b;
		}
	}
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_2 = (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)il2cpp_codegen_object_new(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63(L_2, /*hidden argument*/Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		__this->set_args_5(L_2);
	}

IL_001b:
	{
		RuntimeObject * L_3 = ___value1;
		V_1 = (bool)((!(((RuntimeObject*)(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)((Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)IsInstClass((RuntimeObject*)L_3, Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_0032;
		}
	}
	{
		RuntimeObject * L_5 = ___value1;
		String_t* L_6;
		L_6 = Json_Serialize_m03AB6071E9A0A5D7197D2BA15B8E265D0876BC52(L_5, /*hidden argument*/NULL);
		___value1 = L_6;
	}

IL_0032:
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_7 = __this->get_args_5();
		String_t* L_8 = ___key0;
		RuntimeObject * L_9 = ___value1;
		NullCheck(L_7);
		Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F(L_7, L_8, L_9, /*hidden argument*/Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var);
		V_2 = __this;
		goto IL_0044;
	}

IL_0044:
	{
		Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * L_10 = V_2;
		return L_10;
	}
}
// TapTap.Common.Command/Builder TapTap.Common.Command/Builder::Callback(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * Builder_Callback_m9E6A766555180AC1A055A66A10452E56B798B3AA (Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * __this, bool ___callback0, const RuntimeMethod* method)
{
	Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * V_0 = NULL;
	Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * G_B2_0 = NULL;
	Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * G_B1_0 = NULL;
	String_t* G_B3_0 = NULL;
	Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * G_B3_1 = NULL;
	{
		bool L_0 = ___callback0;
		__this->set_callback_2(L_0);
		bool L_1 = __this->get_callback_2();
		G_B1_0 = __this;
		if (L_1)
		{
			G_B2_0 = __this;
			goto IL_0014;
		}
	}
	{
		G_B3_0 = ((String_t*)(NULL));
		G_B3_1 = G_B1_0;
		goto IL_0019;
	}

IL_0014:
	{
		String_t* L_2;
		L_2 = TapUUID_UUID_m34CD600BDA5D524CD97F2C290CF4FFBCBF7C950D(/*hidden argument*/NULL);
		G_B3_0 = L_2;
		G_B3_1 = G_B2_0;
	}

IL_0019:
	{
		NullCheck(G_B3_1);
		G_B3_1->set_callbackId_3(G_B3_0);
		V_0 = __this;
		goto IL_0022;
	}

IL_0022:
	{
		Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * L_3 = V_0;
		return L_3;
	}
}
// TapTap.Common.Command TapTap.Common.Command/Builder::CommandBuilder()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * Builder_CommandBuilder_mE59B447902208288C195134A981544F4C30EF461 (Builder_tAFB80ED37988E21F712B4AA8DF3754AF1D8AD7A2 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * V_0 = NULL;
	{
		String_t* L_0 = __this->get_service_0();
		String_t* L_1 = __this->get_method_1();
		bool L_2 = __this->get_callback_2();
		bool L_3 = __this->get_onceTime_4();
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_4 = __this->get_args_5();
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_5 = (Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD *)il2cpp_codegen_object_new(Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD_il2cpp_TypeInfo_var);
		Command__ctor_m1DAC8B23A51DDB3A89F453F7C5C31128092F77C6(L_5, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		V_0 = L_5;
		goto IL_0027;
	}

IL_0027:
	{
		Command_t6E93C14CEC188BA8B8BCB3C9854E67B6EBCD34AD * L_6 = V_0;
		return L_6;
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
// System.Void TapTap.Common.EngineBridge/<>c__DisplayClass8_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass8_0__ctor_m3789C85E5AEDAEDA6059CEC611EA642F9C643B0E (U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.EngineBridge/<>c__DisplayClass8_0::<Emit>b__0(TapTap.Common.Result)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass8_0_U3CEmitU3Eb__0_m69B5BE966C6BBD99E6E26D47482C034AB3F28ED4 (U3CU3Ec__DisplayClass8_0_tFA66CD353837B53F99B3C793CD8F6C670EDE1474 * __this, Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * ___result0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TaskCompletionSource_1_TrySetResult_m1264FCCE9A651BCB44E85D04CDA6A0AA97213617_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		TaskCompletionSource_1_t4710E9B8A54F3B2E1947DB6FAE8A9D4F4EAE45FD * L_0 = __this->get_tcs_0();
		Result_t71F81665FB3BADF7858E5A65D5050AEA3C980FC2 * L_1 = ___result0;
		NullCheck(L_0);
		bool L_2;
		L_2 = TaskCompletionSource_1_TrySetResult_m1264FCCE9A651BCB44E85D04CDA6A0AA97213617(L_0, L_1, /*hidden argument*/TaskCompletionSource_1_TrySetResult_m1264FCCE9A651BCB44E85D04CDA6A0AA97213617_RuntimeMethod_var);
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
// System.Boolean TapTap.Common.Json/Parser::IsWordBreak(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Parser_IsWordBreak_mFC882BE0A768B902C6EEEC33AFE5646268F85095 (Il2CppChar ___c0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral84C1E07F84B6E7BDCC02A904AFEC3BBD2CAE6EAA);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t G_B3_0 = 0;
	{
		Il2CppChar L_0 = ___c0;
		IL2CPP_RUNTIME_CLASS_INIT(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Char_IsWhiteSpace_m99A5E1BE1EB9F17EA530A67A607DA8C260BCBF99(L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_001c;
		}
	}
	{
		Il2CppChar L_2 = ___c0;
		NullCheck(_stringLiteral84C1E07F84B6E7BDCC02A904AFEC3BBD2CAE6EAA);
		int32_t L_3;
		L_3 = String_IndexOf_mEE2D2F738175E3FF05580366D6226DBD673CA2BE(_stringLiteral84C1E07F84B6E7BDCC02A904AFEC3BBD2CAE6EAA, L_2, /*hidden argument*/NULL);
		G_B3_0 = ((((int32_t)((((int32_t)L_3) == ((int32_t)(-1)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_001d;
	}

IL_001c:
	{
		G_B3_0 = 1;
	}

IL_001d:
	{
		V_0 = (bool)G_B3_0;
		goto IL_0020;
	}

IL_0020:
	{
		bool L_4 = V_0;
		return L_4;
	}
}
// System.Void TapTap.Common.Json/Parser::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Parser__ctor_m052C8B1064670BDC8E0BB727AD912A3B8C3C1471 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, String_t* ___jsonString0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringReader_t74E352C280EAC22C878867444978741F19E1F895_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___jsonString0;
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_1 = (StringReader_t74E352C280EAC22C878867444978741F19E1F895 *)il2cpp_codegen_object_new(StringReader_t74E352C280EAC22C878867444978741F19E1F895_il2cpp_TypeInfo_var);
		StringReader__ctor_m7CC29D8E83F4813395ACA9CF4F756B1BCE09A7EE(L_1, L_0, /*hidden argument*/NULL);
		__this->set_json_0(L_1);
		return;
	}
}
// System.Object TapTap.Common.Json/Parser::Parse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Parser_Parse_m46AC1CDBD66E06E4D59D3960B11D2FEC4C49CE48 (String_t* ___jsonString0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * V_0 = NULL;
	RuntimeObject * V_1 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		String_t* L_0 = ___jsonString0;
		Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * L_1 = (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 *)il2cpp_codegen_object_new(Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9_il2cpp_TypeInfo_var);
		Parser__ctor_m052C8B1064670BDC8E0BB727AD912A3B8C3C1471(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
	}

IL_0008:
	try
	{ // begin try (depth: 1)
		Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * L_2 = V_0;
		NullCheck(L_2);
		RuntimeObject * L_3;
		L_3 = Parser_ParseValue_m35E0DDD3CA3D27BC78C0CDFB54E9872785DD397E(L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		IL2CPP_LEAVE(0x1D, FINALLY_0012);
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0012;
	}

FINALLY_0012:
	{ // begin finally (depth: 1)
		{
			Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * L_4 = V_0;
			if (!L_4)
			{
				goto IL_001c;
			}
		}

IL_0015:
		{
			Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * L_5 = V_0;
			NullCheck(L_5);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_5);
		}

IL_001c:
		{
			IL2CPP_END_FINALLY(18)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(18)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x1D, IL_001d)
	}

IL_001d:
	{
		RuntimeObject * L_6 = V_1;
		return L_6;
	}
}
// System.Void TapTap.Common.Json/Parser::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Parser_Dispose_m3E31298146C2715AF565BC72827D82AD4595E9DC (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_0 = __this->get_json_0();
		NullCheck(L_0);
		TextReader_Dispose_mDF1DCFD8FBE94A453EB2350DB7173027420BA5F8(L_0, /*hidden argument*/NULL);
		__this->set_json_0((StringReader_t74E352C280EAC22C878867444978741F19E1F895 *)NULL);
		return;
	}
}
// System.Collections.Generic.Dictionary`2<System.String,System.Object> TapTap.Common.Json/Parser::ParseObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * Parser_ParseObject_m5147F50A110505C2CD5AD854675696D8A6D0B001 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * V_0 = NULL;
	String_t* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * V_4 = NULL;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_0 = (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)il2cpp_codegen_object_new(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63(L_0, /*hidden argument*/Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		V_0 = L_0;
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_1 = __this->get_json_0();
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_1);
		goto IL_0088;
	}

IL_0015:
	{
		int32_t L_3;
		L_3 = Parser_get_NextToken_mCBD3F9B6662AB0DC77185218951C8623FF282405(__this, /*hidden argument*/NULL);
		V_3 = L_3;
		int32_t L_4 = V_3;
		V_2 = L_4;
		int32_t L_5 = V_2;
		if (!L_5)
		{
			goto IL_0030;
		}
	}
	{
		goto IL_0024;
	}

IL_0024:
	{
		int32_t L_6 = V_2;
		if ((((int32_t)L_6) == ((int32_t)2)))
		{
			goto IL_0037;
		}
	}
	{
		goto IL_002a;
	}

IL_002a:
	{
		int32_t L_7 = V_2;
		if ((((int32_t)L_7) == ((int32_t)6)))
		{
			goto IL_0035;
		}
	}
	{
		goto IL_003c;
	}

IL_0030:
	{
		V_4 = (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)NULL;
		goto IL_008d;
	}

IL_0035:
	{
		goto IL_0088;
	}

IL_0037:
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_8 = V_0;
		V_4 = L_8;
		goto IL_008d;
	}

IL_003c:
	{
		String_t* L_9;
		L_9 = Parser_ParseString_mEFF1C4BBBB803714FFCB44377136BE72B3E0355C(__this, /*hidden argument*/NULL);
		V_1 = L_9;
		String_t* L_10 = V_1;
		V_5 = (bool)((((RuntimeObject*)(String_t*)L_10) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_11 = V_5;
		if (!L_11)
		{
			goto IL_0053;
		}
	}
	{
		V_4 = (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)NULL;
		goto IL_008d;
	}

IL_0053:
	{
		int32_t L_12;
		L_12 = Parser_get_NextToken_mCBD3F9B6662AB0DC77185218951C8623FF282405(__this, /*hidden argument*/NULL);
		V_6 = (bool)((((int32_t)((((int32_t)L_12) == ((int32_t)5))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_13 = V_6;
		if (!L_13)
		{
			goto IL_006b;
		}
	}
	{
		V_4 = (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)NULL;
		goto IL_008d;
	}

IL_006b:
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_14 = __this->get_json_0();
		NullCheck(L_14);
		int32_t L_15;
		L_15 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_14);
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_16 = V_0;
		String_t* L_17 = V_1;
		RuntimeObject * L_18;
		L_18 = Parser_ParseValue_m35E0DDD3CA3D27BC78C0CDFB54E9872785DD397E(__this, /*hidden argument*/NULL);
		NullCheck(L_16);
		Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9(L_16, L_17, L_18, /*hidden argument*/Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9_RuntimeMethod_var);
		goto IL_0087;
	}

IL_0087:
	{
	}

IL_0088:
	{
		V_7 = (bool)1;
		goto IL_0015;
	}

IL_008d:
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_19 = V_4;
		return L_19;
	}
}
// System.Collections.Generic.List`1<System.Object> TapTap.Common.Json/Parser::ParseArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * Parser_ParseArray_mF250A9E2EF06B5AE4D36BA5113D656A8BAD9F93B (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * V_0 = NULL;
	bool V_1 = false;
	int32_t V_2 = 0;
	RuntimeObject * V_3 = NULL;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * V_6 = NULL;
	bool V_7 = false;
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_0 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)il2cpp_codegen_object_new(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_il2cpp_TypeInfo_var);
		List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B(L_0, /*hidden argument*/List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_RuntimeMethod_var);
		V_0 = L_0;
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_1 = __this->get_json_0();
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_1);
		V_1 = (bool)1;
		goto IL_0058;
	}

IL_0017:
	{
		int32_t L_3;
		L_3 = Parser_get_NextToken_mCBD3F9B6662AB0DC77185218951C8623FF282405(__this, /*hidden argument*/NULL);
		V_2 = L_3;
		int32_t L_4 = V_2;
		V_5 = L_4;
		int32_t L_5 = V_5;
		V_4 = L_5;
		int32_t L_6 = V_4;
		if (!L_6)
		{
			goto IL_003a;
		}
	}
	{
		goto IL_002c;
	}

IL_002c:
	{
		int32_t L_7 = V_4;
		if ((((int32_t)L_7) == ((int32_t)4)))
		{
			goto IL_0041;
		}
	}
	{
		goto IL_0033;
	}

IL_0033:
	{
		int32_t L_8 = V_4;
		if ((((int32_t)L_8) == ((int32_t)6)))
		{
			goto IL_003f;
		}
	}
	{
		goto IL_0045;
	}

IL_003a:
	{
		V_6 = (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 *)NULL;
		goto IL_0064;
	}

IL_003f:
	{
		goto IL_0058;
	}

IL_0041:
	{
		V_1 = (bool)0;
		goto IL_0057;
	}

IL_0045:
	{
		int32_t L_9 = V_2;
		RuntimeObject * L_10;
		L_10 = Parser_ParseByToken_m2AFE2F814ACDE57A13629A5C093B246930FAEFA5(__this, L_9, /*hidden argument*/NULL);
		V_3 = L_10;
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_11 = V_0;
		RuntimeObject * L_12 = V_3;
		NullCheck(L_11);
		List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E(L_11, L_12, /*hidden argument*/List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_RuntimeMethod_var);
		goto IL_0057;
	}

IL_0057:
	{
	}

IL_0058:
	{
		bool L_13 = V_1;
		V_7 = L_13;
		bool L_14 = V_7;
		if (L_14)
		{
			goto IL_0017;
		}
	}
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_15 = V_0;
		V_6 = L_15;
		goto IL_0064;
	}

IL_0064:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_16 = V_6;
		return L_16;
	}
}
// System.Object TapTap.Common.Json/Parser::ParseValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Parser_ParseValue_m35E0DDD3CA3D27BC78C0CDFB54E9872785DD397E (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	{
		int32_t L_0;
		L_0 = Parser_get_NextToken_mCBD3F9B6662AB0DC77185218951C8623FF282405(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		int32_t L_1 = V_0;
		RuntimeObject * L_2;
		L_2 = Parser_ParseByToken_m2AFE2F814ACDE57A13629A5C093B246930FAEFA5(__this, L_1, /*hidden argument*/NULL);
		V_1 = L_2;
		goto IL_0012;
	}

IL_0012:
	{
		RuntimeObject * L_3 = V_1;
		return L_3;
	}
}
// System.Object TapTap.Common.Json/Parser::ParseByToken(TapTap.Common.Json/Parser/TOKEN)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Parser_ParseByToken_m2AFE2F814ACDE57A13629A5C093B246930FAEFA5 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, int32_t ___token0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	RuntimeObject * V_2 = NULL;
	{
		int32_t L_0 = ___token0;
		V_1 = L_0;
		int32_t L_1 = V_1;
		V_0 = L_1;
		int32_t L_2 = V_0;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_2, (int32_t)1)))
		{
			case 0:
			{
				goto IL_004d;
			}
			case 1:
			{
				goto IL_0075;
			}
			case 2:
			{
				goto IL_0056;
			}
			case 3:
			{
				goto IL_0075;
			}
			case 4:
			{
				goto IL_0075;
			}
			case 5:
			{
				goto IL_0075;
			}
			case 6:
			{
				goto IL_003b;
			}
			case 7:
			{
				goto IL_0044;
			}
			case 8:
			{
				goto IL_005f;
			}
			case 9:
			{
				goto IL_0068;
			}
			case 10:
			{
				goto IL_0071;
			}
		}
	}
	{
		goto IL_0075;
	}

IL_003b:
	{
		String_t* L_3;
		L_3 = Parser_ParseString_mEFF1C4BBBB803714FFCB44377136BE72B3E0355C(__this, /*hidden argument*/NULL);
		V_2 = L_3;
		goto IL_0079;
	}

IL_0044:
	{
		RuntimeObject * L_4;
		L_4 = Parser_ParseNumber_m074FC2EAA5E2210753B0316E717DD3A233AD8F84(__this, /*hidden argument*/NULL);
		V_2 = L_4;
		goto IL_0079;
	}

IL_004d:
	{
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_5;
		L_5 = Parser_ParseObject_m5147F50A110505C2CD5AD854675696D8A6D0B001(__this, /*hidden argument*/NULL);
		V_2 = L_5;
		goto IL_0079;
	}

IL_0056:
	{
		List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * L_6;
		L_6 = Parser_ParseArray_mF250A9E2EF06B5AE4D36BA5113D656A8BAD9F93B(__this, /*hidden argument*/NULL);
		V_2 = L_6;
		goto IL_0079;
	}

IL_005f:
	{
		bool L_7 = ((bool)1);
		RuntimeObject * L_8 = Box(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var, &L_7);
		V_2 = L_8;
		goto IL_0079;
	}

IL_0068:
	{
		bool L_9 = ((bool)0);
		RuntimeObject * L_10 = Box(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var, &L_9);
		V_2 = L_10;
		goto IL_0079;
	}

IL_0071:
	{
		V_2 = NULL;
		goto IL_0079;
	}

IL_0075:
	{
		V_2 = NULL;
		goto IL_0079;
	}

IL_0079:
	{
		RuntimeObject * L_11 = V_2;
		return L_11;
	}
}
// System.String TapTap.Common.Json/Parser::ParseString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Parser_ParseString_mEFF1C4BBBB803714FFCB44377136BE72B3E0355C (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	Il2CppChar V_1 = 0x0;
	bool V_2 = false;
	bool V_3 = false;
	Il2CppChar V_4 = 0x0;
	Il2CppChar V_5 = 0x0;
	bool V_6 = false;
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* V_7 = NULL;
	Il2CppChar V_8 = 0x0;
	Il2CppChar V_9 = 0x0;
	int32_t V_10 = 0;
	bool V_11 = false;
	bool V_12 = false;
	String_t* V_13 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_1 = __this->get_json_0();
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_1);
		V_2 = (bool)1;
		goto IL_0178;
	}

IL_001a:
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_3 = __this->get_json_0();
		NullCheck(L_3);
		int32_t L_4;
		L_4 = VirtFuncInvoker0< int32_t >::Invoke(10 /* System.Int32 System.IO.TextReader::Peek() */, L_3);
		V_3 = (bool)((((int32_t)L_4) == ((int32_t)(-1)))? 1 : 0);
		bool L_5 = V_3;
		if (!L_5)
		{
			goto IL_0035;
		}
	}
	{
		V_2 = (bool)0;
		goto IL_0182;
	}

IL_0035:
	{
		Il2CppChar L_6;
		L_6 = Parser_get_NextChar_m5A3A3E1D76F4325B5ED87B1B94C23AB9AE7EF504(__this, /*hidden argument*/NULL);
		V_1 = L_6;
		Il2CppChar L_7 = V_1;
		V_5 = L_7;
		Il2CppChar L_8 = V_5;
		V_4 = L_8;
		Il2CppChar L_9 = V_4;
		if ((((int32_t)L_9) == ((int32_t)((int32_t)34))))
		{
			goto IL_0056;
		}
	}
	{
		goto IL_004b;
	}

IL_004b:
	{
		Il2CppChar L_10 = V_4;
		if ((((int32_t)L_10) == ((int32_t)((int32_t)92))))
		{
			goto IL_005d;
		}
	}
	{
		goto IL_016d;
	}

IL_0056:
	{
		V_2 = (bool)0;
		goto IL_0177;
	}

IL_005d:
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_11 = __this->get_json_0();
		NullCheck(L_11);
		int32_t L_12;
		L_12 = VirtFuncInvoker0< int32_t >::Invoke(10 /* System.Int32 System.IO.TextReader::Peek() */, L_11);
		V_6 = (bool)((((int32_t)L_12) == ((int32_t)(-1)))? 1 : 0);
		bool L_13 = V_6;
		if (!L_13)
		{
			goto IL_0079;
		}
	}
	{
		V_2 = (bool)0;
		goto IL_0177;
	}

IL_0079:
	{
		Il2CppChar L_14;
		L_14 = Parser_get_NextChar_m5A3A3E1D76F4325B5ED87B1B94C23AB9AE7EF504(__this, /*hidden argument*/NULL);
		V_1 = L_14;
		Il2CppChar L_15 = V_1;
		V_9 = L_15;
		Il2CppChar L_16 = V_9;
		V_8 = L_16;
		Il2CppChar L_17 = V_8;
		if ((!(((uint32_t)L_17) <= ((uint32_t)((int32_t)92)))))
		{
			goto IL_00a8;
		}
	}
	{
		Il2CppChar L_18 = V_8;
		if ((((int32_t)L_18) == ((int32_t)((int32_t)34))))
		{
			goto IL_00e8;
		}
	}
	{
		goto IL_0095;
	}

IL_0095:
	{
		Il2CppChar L_19 = V_8;
		if ((((int32_t)L_19) == ((int32_t)((int32_t)47))))
		{
			goto IL_00e8;
		}
	}
	{
		goto IL_009d;
	}

IL_009d:
	{
		Il2CppChar L_20 = V_8;
		if ((((int32_t)L_20) == ((int32_t)((int32_t)92))))
		{
			goto IL_00e8;
		}
	}
	{
		goto IL_016b;
	}

IL_00a8:
	{
		Il2CppChar L_21 = V_8;
		if ((!(((uint32_t)L_21) <= ((uint32_t)((int32_t)102)))))
		{
			goto IL_00c1;
		}
	}
	{
		Il2CppChar L_22 = V_8;
		if ((((int32_t)L_22) == ((int32_t)((int32_t)98))))
		{
			goto IL_00f2;
		}
	}
	{
		goto IL_00b6;
	}

IL_00b6:
	{
		Il2CppChar L_23 = V_8;
		if ((((int32_t)L_23) == ((int32_t)((int32_t)102))))
		{
			goto IL_00fc;
		}
	}
	{
		goto IL_016b;
	}

IL_00c1:
	{
		Il2CppChar L_24 = V_8;
		if ((((int32_t)L_24) == ((int32_t)((int32_t)110))))
		{
			goto IL_0107;
		}
	}
	{
		goto IL_00c9;
	}

IL_00c9:
	{
		Il2CppChar L_25 = V_8;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_25, (int32_t)((int32_t)114))))
		{
			case 0:
			{
				goto IL_0112;
			}
			case 1:
			{
				goto IL_016b;
			}
			case 2:
			{
				goto IL_011d;
			}
			case 3:
			{
				goto IL_0128;
			}
		}
	}
	{
		goto IL_016b;
	}

IL_00e8:
	{
		StringBuilder_t * L_26 = V_0;
		Il2CppChar L_27 = V_1;
		NullCheck(L_26);
		StringBuilder_t * L_28;
		L_28 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_26, L_27, /*hidden argument*/NULL);
		goto IL_016b;
	}

IL_00f2:
	{
		StringBuilder_t * L_29 = V_0;
		NullCheck(L_29);
		StringBuilder_t * L_30;
		L_30 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_29, 8, /*hidden argument*/NULL);
		goto IL_016b;
	}

IL_00fc:
	{
		StringBuilder_t * L_31 = V_0;
		NullCheck(L_31);
		StringBuilder_t * L_32;
		L_32 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_31, ((int32_t)12), /*hidden argument*/NULL);
		goto IL_016b;
	}

IL_0107:
	{
		StringBuilder_t * L_33 = V_0;
		NullCheck(L_33);
		StringBuilder_t * L_34;
		L_34 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_33, ((int32_t)10), /*hidden argument*/NULL);
		goto IL_016b;
	}

IL_0112:
	{
		StringBuilder_t * L_35 = V_0;
		NullCheck(L_35);
		StringBuilder_t * L_36;
		L_36 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_35, ((int32_t)13), /*hidden argument*/NULL);
		goto IL_016b;
	}

IL_011d:
	{
		StringBuilder_t * L_37 = V_0;
		NullCheck(L_37);
		StringBuilder_t * L_38;
		L_38 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_37, ((int32_t)9), /*hidden argument*/NULL);
		goto IL_016b;
	}

IL_0128:
	{
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_39 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)4);
		V_7 = L_39;
		V_10 = 0;
		goto IL_0148;
	}

IL_0135:
	{
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_40 = V_7;
		int32_t L_41 = V_10;
		Il2CppChar L_42;
		L_42 = Parser_get_NextChar_m5A3A3E1D76F4325B5ED87B1B94C23AB9AE7EF504(__this, /*hidden argument*/NULL);
		NullCheck(L_40);
		(L_40)->SetAt(static_cast<il2cpp_array_size_t>(L_41), (Il2CppChar)L_42);
		int32_t L_43 = V_10;
		V_10 = ((int32_t)il2cpp_codegen_add((int32_t)L_43, (int32_t)1));
	}

IL_0148:
	{
		int32_t L_44 = V_10;
		V_11 = (bool)((((int32_t)L_44) < ((int32_t)4))? 1 : 0);
		bool L_45 = V_11;
		if (L_45)
		{
			goto IL_0135;
		}
	}
	{
		StringBuilder_t * L_46 = V_0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_47 = V_7;
		String_t* L_48;
		L_48 = String_CreateString_mC7F57CE6ED768CF86591160424FE55D5CBA7C344(NULL, L_47, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		int32_t L_49;
		L_49 = Convert_ToInt32_m21526761291049AC762DEAEA073870C8A8583643(L_48, ((int32_t)16), /*hidden argument*/NULL);
		NullCheck(L_46);
		StringBuilder_t * L_50;
		L_50 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_46, ((int32_t)((uint16_t)L_49)), /*hidden argument*/NULL);
		goto IL_016b;
	}

IL_016b:
	{
		goto IL_0177;
	}

IL_016d:
	{
		StringBuilder_t * L_51 = V_0;
		Il2CppChar L_52 = V_1;
		NullCheck(L_51);
		StringBuilder_t * L_53;
		L_53 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_51, L_52, /*hidden argument*/NULL);
		goto IL_0177;
	}

IL_0177:
	{
	}

IL_0178:
	{
		bool L_54 = V_2;
		V_12 = L_54;
		bool L_55 = V_12;
		if (L_55)
		{
			goto IL_001a;
		}
	}

IL_0182:
	{
		StringBuilder_t * L_56 = V_0;
		NullCheck(L_56);
		String_t* L_57;
		L_57 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_56);
		V_13 = L_57;
		goto IL_018c;
	}

IL_018c:
	{
		String_t* L_58 = V_13;
		return L_58;
	}
}
// System.Object TapTap.Common.Json/Parser::ParseNumber()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Parser_ParseNumber_m074FC2EAA5E2210753B0316E717DD3A233AD8F84 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	double V_1 = 0.0;
	bool V_2 = false;
	int64_t V_3 = 0;
	RuntimeObject * V_4 = NULL;
	{
		String_t* L_0;
		L_0 = Parser_get_NextWord_m1D1FF72DD230327577C630E35432A7D37C595D75(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		String_t* L_1 = V_0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = String_IndexOf_mEE2D2F738175E3FF05580366D6226DBD673CA2BE(L_1, ((int32_t)46), /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)L_2) == ((int32_t)(-1)))? 1 : 0);
		bool L_3 = V_2;
		if (!L_3)
		{
			goto IL_0032;
		}
	}
	{
		String_t* L_4 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_5;
		L_5 = CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164(/*hidden argument*/NULL);
		bool L_6;
		L_6 = Int64_TryParse_m4A94015941D9BD9F9304D1FE14F17E84BFD3B69A(L_4, ((int32_t)111), L_5, (int64_t*)(&V_3), /*hidden argument*/NULL);
		int64_t L_7 = V_3;
		int64_t L_8 = L_7;
		RuntimeObject * L_9 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_8);
		V_4 = L_9;
		goto IL_004c;
	}

IL_0032:
	{
		String_t* L_10 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_11;
		L_11 = CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_il2cpp_TypeInfo_var);
		bool L_12;
		L_12 = Double_TryParse_mE740D7083AC52793A9634067C4F032570FFBF61E(L_10, ((int32_t)111), L_11, (double*)(&V_1), /*hidden argument*/NULL);
		double L_13 = V_1;
		double L_14 = L_13;
		RuntimeObject * L_15 = Box(Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_il2cpp_TypeInfo_var, &L_14);
		V_4 = L_15;
		goto IL_004c;
	}

IL_004c:
	{
		RuntimeObject * L_16 = V_4;
		return L_16;
	}
}
// System.Void TapTap.Common.Json/Parser::EatWhitespace()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Parser_EatWhitespace_m9F8B40C77F3736E1558D508C7FB4AF838AFCDEF9 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		goto IL_0026;
	}

IL_0003:
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_0 = __this->get_json_0();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_0);
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_2 = __this->get_json_0();
		NullCheck(L_2);
		int32_t L_3;
		L_3 = VirtFuncInvoker0< int32_t >::Invoke(10 /* System.Int32 System.IO.TextReader::Peek() */, L_2);
		V_0 = (bool)((((int32_t)L_3) == ((int32_t)(-1)))? 1 : 0);
		bool L_4 = V_0;
		if (!L_4)
		{
			goto IL_0025;
		}
	}
	{
		goto IL_0035;
	}

IL_0025:
	{
	}

IL_0026:
	{
		Il2CppChar L_5;
		L_5 = Parser_get_PeekChar_m2D89A315D53EFDB8138DCD5289F9F02A2DE8B7B0(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		bool L_6;
		L_6 = Char_IsWhiteSpace_m99A5E1BE1EB9F17EA530A67A607DA8C260BCBF99(L_5, /*hidden argument*/NULL);
		V_1 = L_6;
		bool L_7 = V_1;
		if (L_7)
		{
			goto IL_0003;
		}
	}

IL_0035:
	{
		return;
	}
}
// System.Char TapTap.Common.Json/Parser::get_PeekChar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar Parser_get_PeekChar_m2D89A315D53EFDB8138DCD5289F9F02A2DE8B7B0 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Il2CppChar V_0 = 0x0;
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_0 = __this->get_json_0();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(10 /* System.Int32 System.IO.TextReader::Peek() */, L_0);
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		Il2CppChar L_2;
		L_2 = Convert_ToChar_m84E3CF47987D8B6F2D889D957CBFB5FD55F3DAEC(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0014;
	}

IL_0014:
	{
		Il2CppChar L_3 = V_0;
		return L_3;
	}
}
// System.Char TapTap.Common.Json/Parser::get_NextChar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar Parser_get_NextChar_m5A3A3E1D76F4325B5ED87B1B94C23AB9AE7EF504 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Il2CppChar V_0 = 0x0;
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_0 = __this->get_json_0();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_0);
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		Il2CppChar L_2;
		L_2 = Convert_ToChar_m84E3CF47987D8B6F2D889D957CBFB5FD55F3DAEC(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0014;
	}

IL_0014:
	{
		Il2CppChar L_3 = V_0;
		return L_3;
	}
}
// System.String TapTap.Common.Json/Parser::get_NextWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Parser_get_NextWord_m1D1FF72DD230327577C630E35432A7D37C595D75 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	String_t* V_3 = NULL;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_002d;
	}

IL_0009:
	{
		StringBuilder_t * L_1 = V_0;
		Il2CppChar L_2;
		L_2 = Parser_get_NextChar_m5A3A3E1D76F4325B5ED87B1B94C23AB9AE7EF504(__this, /*hidden argument*/NULL);
		NullCheck(L_1);
		StringBuilder_t * L_3;
		L_3 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_1, L_2, /*hidden argument*/NULL);
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_4 = __this->get_json_0();
		NullCheck(L_4);
		int32_t L_5;
		L_5 = VirtFuncInvoker0< int32_t >::Invoke(10 /* System.Int32 System.IO.TextReader::Peek() */, L_4);
		V_1 = (bool)((((int32_t)L_5) == ((int32_t)(-1)))? 1 : 0);
		bool L_6 = V_1;
		if (!L_6)
		{
			goto IL_002c;
		}
	}
	{
		goto IL_003f;
	}

IL_002c:
	{
	}

IL_002d:
	{
		Il2CppChar L_7;
		L_7 = Parser_get_PeekChar_m2D89A315D53EFDB8138DCD5289F9F02A2DE8B7B0(__this, /*hidden argument*/NULL);
		bool L_8;
		L_8 = Parser_IsWordBreak_mFC882BE0A768B902C6EEEC33AFE5646268F85095(L_7, /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)L_8) == ((int32_t)0))? 1 : 0);
		bool L_9 = V_2;
		if (L_9)
		{
			goto IL_0009;
		}
	}

IL_003f:
	{
		StringBuilder_t * L_10 = V_0;
		NullCheck(L_10);
		String_t* L_11;
		L_11 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_10);
		V_3 = L_11;
		goto IL_0048;
	}

IL_0048:
	{
		String_t* L_12 = V_3;
		return L_12;
	}
}
// TapTap.Common.Json/Parser/TOKEN TapTap.Common.Json/Parser::get_NextToken()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Parser_get_NextToken_mCBD3F9B6662AB0DC77185218951C8623FF282405 (Parser_t10CBE3484A5E1DED02FC943F9675FDEC2A2031F9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5BEFD8CC60A79699B5BB00E37BAC5B62D371E174);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral77D38C0623F92B292B925F6E72CF5CF99A20D4EB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB7C45DD316C68ABF3429C20058C2981C652192F2);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t V_1 = 0;
	Il2CppChar V_2 = 0x0;
	Il2CppChar V_3 = 0x0;
	String_t* V_4 = NULL;
	String_t* V_5 = NULL;
	{
		Parser_EatWhitespace_m9F8B40C77F3736E1558D508C7FB4AF838AFCDEF9(__this, /*hidden argument*/NULL);
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_0 = __this->get_json_0();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(10 /* System.Int32 System.IO.TextReader::Peek() */, L_0);
		V_0 = (bool)((((int32_t)L_1) == ((int32_t)(-1)))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0022;
		}
	}
	{
		V_1 = 0;
		goto IL_014d;
	}

IL_0022:
	{
		Il2CppChar L_3;
		L_3 = Parser_get_PeekChar_m2D89A315D53EFDB8138DCD5289F9F02A2DE8B7B0(__this, /*hidden argument*/NULL);
		V_3 = L_3;
		Il2CppChar L_4 = V_3;
		V_2 = L_4;
		Il2CppChar L_5 = V_2;
		if ((!(((uint32_t)L_5) <= ((uint32_t)((int32_t)91)))))
		{
			goto IL_00a6;
		}
	}
	{
		Il2CppChar L_6 = V_2;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_6, (int32_t)((int32_t)34))))
		{
			case 0:
			{
				goto IL_00f6;
			}
			case 1:
			{
				goto IL_0102;
			}
			case 2:
			{
				goto IL_0102;
			}
			case 3:
			{
				goto IL_0102;
			}
			case 4:
			{
				goto IL_0102;
			}
			case 5:
			{
				goto IL_0102;
			}
			case 6:
			{
				goto IL_0102;
			}
			case 7:
			{
				goto IL_0102;
			}
			case 8:
			{
				goto IL_0102;
			}
			case 9:
			{
				goto IL_0102;
			}
			case 10:
			{
				goto IL_00e6;
			}
			case 11:
			{
				goto IL_00fe;
			}
			case 12:
			{
				goto IL_0102;
			}
			case 13:
			{
				goto IL_0102;
			}
			case 14:
			{
				goto IL_00fe;
			}
			case 15:
			{
				goto IL_00fe;
			}
			case 16:
			{
				goto IL_00fe;
			}
			case 17:
			{
				goto IL_00fe;
			}
			case 18:
			{
				goto IL_00fe;
			}
			case 19:
			{
				goto IL_00fe;
			}
			case 20:
			{
				goto IL_00fe;
			}
			case 21:
			{
				goto IL_00fe;
			}
			case 22:
			{
				goto IL_00fe;
			}
			case 23:
			{
				goto IL_00fe;
			}
			case 24:
			{
				goto IL_00fa;
			}
		}
	}
	{
		goto IL_009f;
	}

IL_009f:
	{
		Il2CppChar L_7 = V_2;
		if ((((int32_t)L_7) == ((int32_t)((int32_t)91))))
		{
			goto IL_00d2;
		}
	}
	{
		goto IL_0102;
	}

IL_00a6:
	{
		Il2CppChar L_8 = V_2;
		if ((((int32_t)L_8) == ((int32_t)((int32_t)93))))
		{
			goto IL_00d6;
		}
	}
	{
		goto IL_00ad;
	}

IL_00ad:
	{
		Il2CppChar L_9 = V_2;
		if ((((int32_t)L_9) == ((int32_t)((int32_t)123))))
		{
			goto IL_00bb;
		}
	}
	{
		goto IL_00b4;
	}

IL_00b4:
	{
		Il2CppChar L_10 = V_2;
		if ((((int32_t)L_10) == ((int32_t)((int32_t)125))))
		{
			goto IL_00c2;
		}
	}
	{
		goto IL_0102;
	}

IL_00bb:
	{
		V_1 = 1;
		goto IL_014d;
	}

IL_00c2:
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_11 = __this->get_json_0();
		NullCheck(L_11);
		int32_t L_12;
		L_12 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_11);
		V_1 = 2;
		goto IL_014d;
	}

IL_00d2:
	{
		V_1 = 3;
		goto IL_014d;
	}

IL_00d6:
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_13 = __this->get_json_0();
		NullCheck(L_13);
		int32_t L_14;
		L_14 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_13);
		V_1 = 4;
		goto IL_014d;
	}

IL_00e6:
	{
		StringReader_t74E352C280EAC22C878867444978741F19E1F895 * L_15 = __this->get_json_0();
		NullCheck(L_15);
		int32_t L_16;
		L_16 = VirtFuncInvoker0< int32_t >::Invoke(11 /* System.Int32 System.IO.TextReader::Read() */, L_15);
		V_1 = 6;
		goto IL_014d;
	}

IL_00f6:
	{
		V_1 = 7;
		goto IL_014d;
	}

IL_00fa:
	{
		V_1 = 5;
		goto IL_014d;
	}

IL_00fe:
	{
		V_1 = 8;
		goto IL_014d;
	}

IL_0102:
	{
		String_t* L_17;
		L_17 = Parser_get_NextWord_m1D1FF72DD230327577C630E35432A7D37C595D75(__this, /*hidden argument*/NULL);
		V_5 = L_17;
		String_t* L_18 = V_5;
		V_4 = L_18;
		String_t* L_19 = V_4;
		bool L_20;
		L_20 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_19, _stringLiteral77D38C0623F92B292B925F6E72CF5CF99A20D4EB, /*hidden argument*/NULL);
		if (L_20)
		{
			goto IL_013a;
		}
	}
	{
		String_t* L_21 = V_4;
		bool L_22;
		L_22 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_21, _stringLiteralB7C45DD316C68ABF3429C20058C2981C652192F2, /*hidden argument*/NULL);
		if (L_22)
		{
			goto IL_013f;
		}
	}
	{
		String_t* L_23 = V_4;
		bool L_24;
		L_24 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_23, _stringLiteral5BEFD8CC60A79699B5BB00E37BAC5B62D371E174, /*hidden argument*/NULL);
		if (L_24)
		{
			goto IL_0144;
		}
	}
	{
		goto IL_0149;
	}

IL_013a:
	{
		V_1 = ((int32_t)10);
		goto IL_014d;
	}

IL_013f:
	{
		V_1 = ((int32_t)9);
		goto IL_014d;
	}

IL_0144:
	{
		V_1 = ((int32_t)11);
		goto IL_014d;
	}

IL_0149:
	{
		V_1 = 0;
		goto IL_014d;
	}

IL_014d:
	{
		int32_t L_25 = V_1;
		return L_25;
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
// System.Void TapTap.Common.Json/Serializer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer__ctor_mB70FBB4EEF8CFEF8D45D208791081F15F29A7320 (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_0, /*hidden argument*/NULL);
		__this->set_builder_0(L_0);
		return;
	}
}
// System.String TapTap.Common.Json/Serializer::Serialize(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Serializer_Serialize_mB98039BD7C2A49AAAB1C2EC7829E8453F751EB9D (RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * V_0 = NULL;
	String_t* V_1 = NULL;
	{
		Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * L_0 = (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE *)il2cpp_codegen_object_new(Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE_il2cpp_TypeInfo_var);
		Serializer__ctor_mB70FBB4EEF8CFEF8D45D208791081F15F29A7320(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * L_1 = V_0;
		RuntimeObject * L_2 = ___obj0;
		NullCheck(L_1);
		Serializer_SerializeValue_m39E6FC75FE6CC56DD6656AF3CFE953B4A2847FDC(L_1, L_2, /*hidden argument*/NULL);
		Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * L_3 = V_0;
		NullCheck(L_3);
		StringBuilder_t * L_4 = L_3->get_builder_0();
		NullCheck(L_4);
		String_t* L_5;
		L_5 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_4);
		V_1 = L_5;
		goto IL_001d;
	}

IL_001d:
	{
		String_t* L_6 = V_1;
		return L_6;
	}
}
// System.Void TapTap.Common.Json/Serializer::SerializeValue(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeValue_m39E6FC75FE6CC56DD6656AF3CFE953B4A2847FDC (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5BEFD8CC60A79699B5BB00E37BAC5B62D371E174);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral77D38C0623F92B292B925F6E72CF5CF99A20D4EB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB7C45DD316C68ABF3429C20058C2981C652192F2);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	RuntimeObject* V_1 = NULL;
	String_t* V_2 = NULL;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	StringBuilder_t * G_B7_0 = NULL;
	StringBuilder_t * G_B6_0 = NULL;
	String_t* G_B8_0 = NULL;
	StringBuilder_t * G_B8_1 = NULL;
	{
		RuntimeObject * L_0 = ___value0;
		V_3 = (bool)((((RuntimeObject*)(RuntimeObject *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_3;
		if (!L_1)
		{
			goto IL_0021;
		}
	}
	{
		StringBuilder_t * L_2 = __this->get_builder_0();
		NullCheck(L_2);
		StringBuilder_t * L_3;
		L_3 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_2, _stringLiteral5BEFD8CC60A79699B5BB00E37BAC5B62D371E174, /*hidden argument*/NULL);
		goto IL_00de;
	}

IL_0021:
	{
		RuntimeObject * L_4 = ___value0;
		String_t* L_5 = ((String_t*)IsInstSealed((RuntimeObject*)L_4, String_t_il2cpp_TypeInfo_var));
		V_2 = L_5;
		V_4 = (bool)((!(((RuntimeObject*)(String_t*)L_5) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_6 = V_4;
		if (!L_6)
		{
			goto IL_0041;
		}
	}
	{
		String_t* L_7 = V_2;
		Serializer_SerializeString_m0FA59B83F91D62AADBA4FACF5095F1E80DB6E82F(__this, L_7, /*hidden argument*/NULL);
		goto IL_00de;
	}

IL_0041:
	{
		RuntimeObject * L_8 = ___value0;
		V_5 = (bool)((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_8, Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_9 = V_5;
		if (!L_9)
		{
			goto IL_0074;
		}
	}
	{
		StringBuilder_t * L_10 = __this->get_builder_0();
		RuntimeObject * L_11 = ___value0;
		G_B6_0 = L_10;
		if (((*(bool*)((bool*)UnBox(L_11, Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_il2cpp_TypeInfo_var)))))
		{
			G_B7_0 = L_10;
			goto IL_0066;
		}
	}
	{
		G_B8_0 = _stringLiteral77D38C0623F92B292B925F6E72CF5CF99A20D4EB;
		G_B8_1 = G_B6_0;
		goto IL_006b;
	}

IL_0066:
	{
		G_B8_0 = _stringLiteralB7C45DD316C68ABF3429C20058C2981C652192F2;
		G_B8_1 = G_B7_0;
	}

IL_006b:
	{
		NullCheck(G_B8_1);
		StringBuilder_t * L_12;
		L_12 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(G_B8_1, G_B8_0, /*hidden argument*/NULL);
		goto IL_00de;
	}

IL_0074:
	{
		RuntimeObject * L_13 = ___value0;
		RuntimeObject* L_14 = ((RuntimeObject*)IsInst((RuntimeObject*)L_13, IList_tB15A9D6625D09661D6E47976BB626C703EC81910_il2cpp_TypeInfo_var));
		V_0 = L_14;
		V_6 = (bool)((!(((RuntimeObject*)(RuntimeObject*)L_14) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_15 = V_6;
		if (!L_15)
		{
			goto IL_0091;
		}
	}
	{
		RuntimeObject* L_16 = V_0;
		Serializer_SerializeArray_m10B586A1ECBBA3EC6FD38A94FA57688309BFB341(__this, L_16, /*hidden argument*/NULL);
		goto IL_00de;
	}

IL_0091:
	{
		RuntimeObject * L_17 = ___value0;
		RuntimeObject* L_18 = ((RuntimeObject*)IsInst((RuntimeObject*)L_17, IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A_il2cpp_TypeInfo_var));
		V_1 = L_18;
		V_7 = (bool)((!(((RuntimeObject*)(RuntimeObject*)L_18) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_19 = V_7;
		if (!L_19)
		{
			goto IL_00ae;
		}
	}
	{
		RuntimeObject* L_20 = V_1;
		Serializer_SerializeObject_m903C16422CCDF3805263D033975263ED3EAC6724(__this, L_20, /*hidden argument*/NULL);
		goto IL_00de;
	}

IL_00ae:
	{
		RuntimeObject * L_21 = ___value0;
		V_8 = (bool)((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_21, Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_22 = V_8;
		if (!L_22)
		{
			goto IL_00d4;
		}
	}
	{
		RuntimeObject * L_23 = ___value0;
		String_t* L_24;
		L_24 = String_CreateString_m4CBF2A74FB65655B0BB1452CA748E9CF78D974ED(NULL, ((*(Il2CppChar*)((Il2CppChar*)UnBox(L_23, Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var)))), 1, /*hidden argument*/NULL);
		Serializer_SerializeString_m0FA59B83F91D62AADBA4FACF5095F1E80DB6E82F(__this, L_24, /*hidden argument*/NULL);
		goto IL_00de;
	}

IL_00d4:
	{
		RuntimeObject * L_25 = ___value0;
		Serializer_SerializeOther_m0E79C4CBBFC917C5EA585DF184BBF6FB54C856A1(__this, L_25, /*hidden argument*/NULL);
	}

IL_00de:
	{
		return;
	}
}
// System.Void TapTap.Common.Json/Serializer::SerializeObject(System.Collections.IDictionary)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeObject_m903C16422CCDF3805263D033975263ED3EAC6724 (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, RuntimeObject* ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	RuntimeObject* V_1 = NULL;
	RuntimeObject * V_2 = NULL;
	bool V_3 = false;
	RuntimeObject* V_4 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		V_0 = (bool)1;
		StringBuilder_t * L_0 = __this->get_builder_0();
		NullCheck(L_0);
		StringBuilder_t * L_1;
		L_1 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_0, ((int32_t)123), /*hidden argument*/NULL);
		RuntimeObject* L_2 = ___obj0;
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(2 /* System.Collections.ICollection System.Collections.IDictionary::get_Keys() */, IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A_il2cpp_TypeInfo_var, L_2);
		NullCheck(L_3);
		RuntimeObject* L_4;
		L_4 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.IEnumerator System.Collections.IEnumerable::GetEnumerator() */, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var, L_3);
		V_1 = L_4;
	}

IL_001e:
	try
	{ // begin try (depth: 1)
		{
			goto IL_006c;
		}

IL_0020:
		{
			RuntimeObject* L_5 = V_1;
			NullCheck(L_5);
			RuntimeObject * L_6;
			L_6 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_5);
			V_2 = L_6;
			bool L_7 = V_0;
			V_3 = (bool)((((int32_t)L_7) == ((int32_t)0))? 1 : 0);
			bool L_8 = V_3;
			if (!L_8)
			{
				goto IL_0040;
			}
		}

IL_0030:
		{
			StringBuilder_t * L_9 = __this->get_builder_0();
			NullCheck(L_9);
			StringBuilder_t * L_10;
			L_10 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_9, ((int32_t)44), /*hidden argument*/NULL);
		}

IL_0040:
		{
			RuntimeObject * L_11 = V_2;
			NullCheck(L_11);
			String_t* L_12;
			L_12 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_11);
			Serializer_SerializeString_m0FA59B83F91D62AADBA4FACF5095F1E80DB6E82F(__this, L_12, /*hidden argument*/NULL);
			StringBuilder_t * L_13 = __this->get_builder_0();
			NullCheck(L_13);
			StringBuilder_t * L_14;
			L_14 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_13, ((int32_t)58), /*hidden argument*/NULL);
			RuntimeObject* L_15 = ___obj0;
			RuntimeObject * L_16 = V_2;
			NullCheck(L_15);
			RuntimeObject * L_17;
			L_17 = InterfaceFuncInvoker1< RuntimeObject *, RuntimeObject * >::Invoke(0 /* System.Object System.Collections.IDictionary::get_Item(System.Object) */, IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A_il2cpp_TypeInfo_var, L_15, L_16);
			Serializer_SerializeValue_m39E6FC75FE6CC56DD6656AF3CFE953B4A2847FDC(__this, L_17, /*hidden argument*/NULL);
			V_0 = (bool)0;
		}

IL_006c:
		{
			RuntimeObject* L_18 = V_1;
			NullCheck(L_18);
			bool L_19;
			L_19 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_18);
			if (L_19)
			{
				goto IL_0020;
			}
		}

IL_0074:
		{
			IL2CPP_LEAVE(0x8B, FINALLY_0076);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0076;
	}

FINALLY_0076:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_20 = V_1;
			V_4 = ((RuntimeObject*)IsInst((RuntimeObject*)L_20, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_21 = V_4;
			if (!L_21)
			{
				goto IL_008a;
			}
		}

IL_0082:
		{
			RuntimeObject* L_22 = V_4;
			NullCheck(L_22);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_22);
		}

IL_008a:
		{
			IL2CPP_END_FINALLY(118)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(118)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x8B, IL_008b)
	}

IL_008b:
	{
		StringBuilder_t * L_23 = __this->get_builder_0();
		NullCheck(L_23);
		StringBuilder_t * L_24;
		L_24 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_23, ((int32_t)125), /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.Json/Serializer::SerializeArray(System.Collections.IList)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeArray_m10B586A1ECBBA3EC6FD38A94FA57688309BFB341 (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, RuntimeObject* ___anArray0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	RuntimeObject* V_1 = NULL;
	RuntimeObject * V_2 = NULL;
	bool V_3 = false;
	RuntimeObject* V_4 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		StringBuilder_t * L_0 = __this->get_builder_0();
		NullCheck(L_0);
		StringBuilder_t * L_1;
		L_1 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_0, ((int32_t)91), /*hidden argument*/NULL);
		V_0 = (bool)1;
		RuntimeObject* L_2 = ___anArray0;
		NullCheck(L_2);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(0 /* System.Collections.IEnumerator System.Collections.IEnumerable::GetEnumerator() */, IEnumerable_t47A618747A1BB2A868710316F7372094849163A2_il2cpp_TypeInfo_var, L_2);
		V_1 = L_3;
	}

IL_0019:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0046;
		}

IL_001b:
		{
			RuntimeObject* L_4 = V_1;
			NullCheck(L_4);
			RuntimeObject * L_5;
			L_5 = InterfaceFuncInvoker0< RuntimeObject * >::Invoke(1 /* System.Object System.Collections.IEnumerator::get_Current() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_4);
			V_2 = L_5;
			bool L_6 = V_0;
			V_3 = (bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
			bool L_7 = V_3;
			if (!L_7)
			{
				goto IL_003b;
			}
		}

IL_002b:
		{
			StringBuilder_t * L_8 = __this->get_builder_0();
			NullCheck(L_8);
			StringBuilder_t * L_9;
			L_9 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_8, ((int32_t)44), /*hidden argument*/NULL);
		}

IL_003b:
		{
			RuntimeObject * L_10 = V_2;
			Serializer_SerializeValue_m39E6FC75FE6CC56DD6656AF3CFE953B4A2847FDC(__this, L_10, /*hidden argument*/NULL);
			V_0 = (bool)0;
		}

IL_0046:
		{
			RuntimeObject* L_11 = V_1;
			NullCheck(L_11);
			bool L_12;
			L_12 = InterfaceFuncInvoker0< bool >::Invoke(0 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105_il2cpp_TypeInfo_var, L_11);
			if (L_12)
			{
				goto IL_001b;
			}
		}

IL_004e:
		{
			IL2CPP_LEAVE(0x65, FINALLY_0050);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0050;
	}

FINALLY_0050:
	{ // begin finally (depth: 1)
		{
			RuntimeObject* L_13 = V_1;
			V_4 = ((RuntimeObject*)IsInst((RuntimeObject*)L_13, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var));
			RuntimeObject* L_14 = V_4;
			if (!L_14)
			{
				goto IL_0064;
			}
		}

IL_005c:
		{
			RuntimeObject* L_15 = V_4;
			NullCheck(L_15);
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_15);
		}

IL_0064:
		{
			IL2CPP_END_FINALLY(80)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(80)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x65, IL_0065)
	}

IL_0065:
	{
		StringBuilder_t * L_16 = __this->get_builder_0();
		NullCheck(L_16);
		StringBuilder_t * L_17;
		L_17 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_16, ((int32_t)93), /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.Json/Serializer::SerializeString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeString_m0FA59B83F91D62AADBA4FACF5095F1E80DB6E82F (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, String_t* ___str0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5962E944D7340CE47999BF097B4AFD70C1501FB9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral785F17F45C331C415D0A7458E6AAC36966399C51);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7F3238CD8C342B06FB9AB185C610175C84625462);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral848E5ED630B3142F565DD995C6E8D30187ED33CD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA7C3FCA8C63E127B542B38A5CA5E3FEEDDD1B122);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB78F235D4291950A7D101307609C259F3E1F033F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA666908BB15F4E1D2649752EC5DCBD0D5C64699);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE727BF366E3CC855B808D806440542BF7152AF19);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF18840F490E42D3CE48CDCBF47229C1C240F8ABE);
		s_Il2CppMethodInitialized = true;
	}
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* V_0 = NULL;
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* V_1 = NULL;
	int32_t V_2 = 0;
	Il2CppChar V_3 = 0x0;
	int32_t V_4 = 0;
	Il2CppChar V_5 = 0x0;
	Il2CppChar V_6 = 0x0;
	bool V_7 = false;
	int32_t G_B17_0 = 0;
	{
		StringBuilder_t * L_0 = __this->get_builder_0();
		NullCheck(L_0);
		StringBuilder_t * L_1;
		L_1 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_0, ((int32_t)34), /*hidden argument*/NULL);
		String_t* L_2 = ___str0;
		NullCheck(L_2);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_3;
		L_3 = String_ToCharArray_m33E93AEB7086CBEBDFA5730EAAC49686F144089C(L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_4 = V_0;
		V_1 = L_4;
		V_2 = 0;
		goto IL_0159;
	}

IL_0020:
	{
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_5 = V_1;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		uint16_t L_8 = (uint16_t)(L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		V_3 = L_8;
		Il2CppChar L_9 = V_3;
		V_6 = L_9;
		Il2CppChar L_10 = V_6;
		V_5 = L_10;
		Il2CppChar L_11 = V_5;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_11, (int32_t)8)))
		{
			case 0:
			{
				goto IL_008e;
			}
			case 1:
			{
				goto IL_00e3;
			}
			case 2:
			{
				goto IL_00ba;
			}
			case 3:
			{
				goto IL_00f6;
			}
			case 4:
			{
				goto IL_00a4;
			}
			case 5:
			{
				goto IL_00d0;
			}
		}
	}
	{
		goto IL_004f;
	}

IL_004f:
	{
		Il2CppChar L_12 = V_5;
		if ((((int32_t)L_12) == ((int32_t)((int32_t)34))))
		{
			goto IL_0062;
		}
	}
	{
		goto IL_0057;
	}

IL_0057:
	{
		Il2CppChar L_13 = V_5;
		if ((((int32_t)L_13) == ((int32_t)((int32_t)92))))
		{
			goto IL_0078;
		}
	}
	{
		goto IL_00f6;
	}

IL_0062:
	{
		StringBuilder_t * L_14 = __this->get_builder_0();
		NullCheck(L_14);
		StringBuilder_t * L_15;
		L_15 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_14, _stringLiteral848E5ED630B3142F565DD995C6E8D30187ED33CD, /*hidden argument*/NULL);
		goto IL_0154;
	}

IL_0078:
	{
		StringBuilder_t * L_16 = __this->get_builder_0();
		NullCheck(L_16);
		StringBuilder_t * L_17;
		L_17 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_16, _stringLiteralF18840F490E42D3CE48CDCBF47229C1C240F8ABE, /*hidden argument*/NULL);
		goto IL_0154;
	}

IL_008e:
	{
		StringBuilder_t * L_18 = __this->get_builder_0();
		NullCheck(L_18);
		StringBuilder_t * L_19;
		L_19 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_18, _stringLiteral5962E944D7340CE47999BF097B4AFD70C1501FB9, /*hidden argument*/NULL);
		goto IL_0154;
	}

IL_00a4:
	{
		StringBuilder_t * L_20 = __this->get_builder_0();
		NullCheck(L_20);
		StringBuilder_t * L_21;
		L_21 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_20, _stringLiteralA7C3FCA8C63E127B542B38A5CA5E3FEEDDD1B122, /*hidden argument*/NULL);
		goto IL_0154;
	}

IL_00ba:
	{
		StringBuilder_t * L_22 = __this->get_builder_0();
		NullCheck(L_22);
		StringBuilder_t * L_23;
		L_23 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_22, _stringLiteral785F17F45C331C415D0A7458E6AAC36966399C51, /*hidden argument*/NULL);
		goto IL_0154;
	}

IL_00d0:
	{
		StringBuilder_t * L_24 = __this->get_builder_0();
		NullCheck(L_24);
		StringBuilder_t * L_25;
		L_25 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_24, _stringLiteralB78F235D4291950A7D101307609C259F3E1F033F, /*hidden argument*/NULL);
		goto IL_0154;
	}

IL_00e3:
	{
		StringBuilder_t * L_26 = __this->get_builder_0();
		NullCheck(L_26);
		StringBuilder_t * L_27;
		L_27 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_26, _stringLiteral7F3238CD8C342B06FB9AB185C610175C84625462, /*hidden argument*/NULL);
		goto IL_0154;
	}

IL_00f6:
	{
		Il2CppChar L_28 = V_3;
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		int32_t L_29;
		L_29 = Convert_ToInt32_m0B80BF2883121B16934DF6F71590CAE15442A5BC(L_28, /*hidden argument*/NULL);
		V_4 = L_29;
		int32_t L_30 = V_4;
		if ((((int32_t)L_30) < ((int32_t)((int32_t)32))))
		{
			goto IL_010f;
		}
	}
	{
		int32_t L_31 = V_4;
		G_B17_0 = ((((int32_t)((((int32_t)L_31) > ((int32_t)((int32_t)126)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0110;
	}

IL_010f:
	{
		G_B17_0 = 0;
	}

IL_0110:
	{
		V_7 = (bool)G_B17_0;
		bool L_32 = V_7;
		if (!L_32)
		{
			goto IL_0127;
		}
	}
	{
		StringBuilder_t * L_33 = __this->get_builder_0();
		Il2CppChar L_34 = V_3;
		NullCheck(L_33);
		StringBuilder_t * L_35;
		L_35 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_33, L_34, /*hidden argument*/NULL);
		goto IL_0152;
	}

IL_0127:
	{
		StringBuilder_t * L_36 = __this->get_builder_0();
		NullCheck(L_36);
		StringBuilder_t * L_37;
		L_37 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_36, _stringLiteralDA666908BB15F4E1D2649752EC5DCBD0D5C64699, /*hidden argument*/NULL);
		StringBuilder_t * L_38 = __this->get_builder_0();
		String_t* L_39;
		L_39 = Int32_ToString_m5398ED0B6625B75CAF70C63B3CF2CE47D3C1B184((int32_t*)(&V_4), _stringLiteralE727BF366E3CC855B808D806440542BF7152AF19, /*hidden argument*/NULL);
		NullCheck(L_38);
		StringBuilder_t * L_40;
		L_40 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_38, L_39, /*hidden argument*/NULL);
	}

IL_0152:
	{
		goto IL_0154;
	}

IL_0154:
	{
		int32_t L_41 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_41, (int32_t)1));
	}

IL_0159:
	{
		int32_t L_42 = V_2;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_43 = V_1;
		NullCheck(L_43);
		if ((((int32_t)L_42) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_43)->max_length))))))
		{
			goto IL_0020;
		}
	}
	{
		StringBuilder_t * L_44 = __this->get_builder_0();
		NullCheck(L_44);
		StringBuilder_t * L_45;
		L_45 = StringBuilder_Append_m1ADA3C16E40BF253BCDB5F9579B4DBA9C3E5B22E(L_44, ((int32_t)34), /*hidden argument*/NULL);
		return;
	}
}
// System.Void TapTap.Common.Json/Serializer::SerializeOther(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Serializer_SerializeOther_m0E79C4CBBFC917C5EA585DF184BBF6FB54C856A1 (Serializer_t456525DDBB7F911FD8033C6D03A8378E8F8FDDDE * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int16_tD0F031114106263BB459DA1F099FF9F42691295A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt16_t894EA9D4FB7C799B244E7BBF2DF0EEEDBC77A8BD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32_tE60352A06233E4E69DD198BCC67142159F686B15_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt64_tEC57511B3E3CA2DBA1BEBD434C6983E31C943281_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2C3D4826D5236B3C9A914C5CE2E3D8CEA48AC7CE);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	float V_1 = 0.0f;
	bool V_2 = false;
	bool V_3 = false;
	double V_4 = 0.0;
	int32_t G_B11_0 = 0;
	int32_t G_B16_0 = 0;
	{
		RuntimeObject * L_0 = ___value0;
		V_0 = (bool)((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_0, Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0039;
		}
	}
	{
		StringBuilder_t * L_2 = __this->get_builder_0();
		RuntimeObject * L_3 = ___value0;
		V_1 = ((*(float*)((float*)UnBox(L_3, Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E_il2cpp_TypeInfo_var))));
		IL2CPP_RUNTIME_CLASS_INIT(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_4;
		L_4 = CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164(/*hidden argument*/NULL);
		String_t* L_5;
		L_5 = Single_ToString_m7631D332703B4197EAA7DC0BA067CE7E16334D8B((float*)(&V_1), _stringLiteral2C3D4826D5236B3C9A914C5CE2E3D8CEA48AC7CE, L_4, /*hidden argument*/NULL);
		NullCheck(L_2);
		StringBuilder_t * L_6;
		L_6 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_2, L_5, /*hidden argument*/NULL);
		goto IL_00e2;
	}

IL_0039:
	{
		RuntimeObject * L_7 = ___value0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_7, Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var)))
		{
			goto IL_007c;
		}
	}
	{
		RuntimeObject * L_8 = ___value0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_8, UInt32_tE60352A06233E4E69DD198BCC67142159F686B15_il2cpp_TypeInfo_var)))
		{
			goto IL_007c;
		}
	}
	{
		RuntimeObject * L_9 = ___value0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_9, Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var)))
		{
			goto IL_007c;
		}
	}
	{
		RuntimeObject * L_10 = ___value0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_10, SByte_t928712DD662DC29BA4FAAE8CE2230AFB23447F0B_il2cpp_TypeInfo_var)))
		{
			goto IL_007c;
		}
	}
	{
		RuntimeObject * L_11 = ___value0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_11, Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var)))
		{
			goto IL_007c;
		}
	}
	{
		RuntimeObject * L_12 = ___value0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_12, Int16_tD0F031114106263BB459DA1F099FF9F42691295A_il2cpp_TypeInfo_var)))
		{
			goto IL_007c;
		}
	}
	{
		RuntimeObject * L_13 = ___value0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_13, UInt16_t894EA9D4FB7C799B244E7BBF2DF0EEEDBC77A8BD_il2cpp_TypeInfo_var)))
		{
			goto IL_007c;
		}
	}
	{
		RuntimeObject * L_14 = ___value0;
		G_B11_0 = ((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_14, UInt64_tEC57511B3E3CA2DBA1BEBD434C6983E31C943281_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		goto IL_007d;
	}

IL_007c:
	{
		G_B11_0 = 1;
	}

IL_007d:
	{
		V_2 = (bool)G_B11_0;
		bool L_15 = V_2;
		if (!L_15)
		{
			goto IL_0092;
		}
	}
	{
		StringBuilder_t * L_16 = __this->get_builder_0();
		RuntimeObject * L_17 = ___value0;
		NullCheck(L_16);
		StringBuilder_t * L_18;
		L_18 = StringBuilder_Append_m545FFB72A578320B1D6EA3772160353FD62C344F(L_16, L_17, /*hidden argument*/NULL);
		goto IL_00e2;
	}

IL_0092:
	{
		RuntimeObject * L_19 = ___value0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_19, Double_t42821932CB52DE2057E685D0E1AF3DE5033D2181_il2cpp_TypeInfo_var)))
		{
			goto IL_00a5;
		}
	}
	{
		RuntimeObject * L_20 = ___value0;
		G_B16_0 = ((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_20, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		goto IL_00a6;
	}

IL_00a5:
	{
		G_B16_0 = 1;
	}

IL_00a6:
	{
		V_3 = (bool)G_B16_0;
		bool L_21 = V_3;
		if (!L_21)
		{
			goto IL_00d3;
		}
	}
	{
		StringBuilder_t * L_22 = __this->get_builder_0();
		RuntimeObject * L_23 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		double L_24;
		L_24 = Convert_ToDouble_mF6F0642EA16CAB414EEA621DEAA519527DA64284(L_23, /*hidden argument*/NULL);
		V_4 = L_24;
		IL2CPP_RUNTIME_CLASS_INIT(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_25;
		L_25 = CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164(/*hidden argument*/NULL);
		String_t* L_26;
		L_26 = Double_ToString_mFF1DAF2003FC7096C54C5A2685F85082220E330B((double*)(&V_4), _stringLiteral2C3D4826D5236B3C9A914C5CE2E3D8CEA48AC7CE, L_25, /*hidden argument*/NULL);
		NullCheck(L_22);
		StringBuilder_t * L_27;
		L_27 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_22, L_26, /*hidden argument*/NULL);
		goto IL_00e2;
	}

IL_00d3:
	{
		RuntimeObject * L_28 = ___value0;
		NullCheck(L_28);
		String_t* L_29;
		L_29 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_28);
		Serializer_SerializeString_m0FA59B83F91D62AADBA4FACF5095F1E80DB6E82F(__this, L_29, /*hidden argument*/NULL);
	}

IL_00e2:
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * TapLogger_get_LogDelegate_m6B310D3CB95664848307AD22C45493437991A979_inline (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Action_2_tDB4321E2CDFF48141C73A9DA7135750B81BAED38 * L_0 = ((TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_StaticFields*)il2cpp_codegen_static_fields_for(TapLogger_t04353A017DDE69E1C2B1EC632DAE7FC005B6A89A_il2cpp_TypeInfo_var))->get_U3CLogDelegateU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * HttpRequestMessage_get_RequestUri_mB0637CC446DFCB403DC4C36781474AC9C3556DDB_inline (HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * __this, const RuntimeMethod* method)
{
	{
		Uri_t4A915E1CC15B2C650F478099AD448E9466CBF612 * L_0 = __this->get_uri_4();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * HttpRequestMessage_get_Method_m827225A7FD4B30107C4191325DA6762D6C3469BD_inline (HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * __this, const RuntimeMethod* method)
{
	{
		HttpMethod_t659776B0F106E0079190B76DAF45CF3B58E44C90 * L_0 = __this->get_method_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * HttpRequestMessage_get_Content_mCD96F88223EA230AC47CC295A00574F52582D0D4_inline (HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * __this, const RuntimeMethod* method)
{
	{
		HttpContent_tD8845E4F14BA310E60D340FB2673D36103A802C6 * L_0 = __this->get_U3CContentU3Ek__BackingField_7();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * HttpResponseMessage_get_RequestMessage_m1AADFCBFE233491EC18E65D6342833A1CEB52486_inline (HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752 * __this, const RuntimeMethod* method)
{
	{
		HttpRequestMessage_t2363952C1280568FCCFC6514257FA681811F942F * L_0 = __this->get_U3CRequestMessageU3Ek__BackingField_6();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t HttpResponseMessage_get_StatusCode_m566EA4F3B9AF052B4A59C34F51191B926BFED7CB_inline (HttpResponseMessage_t63F09CB81BACD128DB43F511182D683D13445752 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_statusCode_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline (const RuntimeMethod* method)
{
	{
		IL2CPP_RUNTIME_CLASS_INIT(IL2CPP_RGCTX_DATA(method->rgctx_data, 0));
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_0 = ((EmptyArray_1_tBF73225DFA890366D579424FE8F40073BF9FBAD4_StaticFields*)il2cpp_codegen_static_fields_for(IL2CPP_RGCTX_DATA(method->rgctx_data, 0)))->get_Value_0();
		return (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * TaskCompletionSource_1_get_Task_m7F788C2231343328FBBCFE9EDA916E748F699618_gshared_inline (TaskCompletionSource_1_t5B48A13B0469AA5A5797B645926E284436099903 * __this, const RuntimeMethod* method)
{
	{
		Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 * L_0 = (Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 *)__this->get_m_task_0();
		return (Task_1_tC1805497876E88B78A2B0CB81C6409E0B381AC17 *)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * KeyValuePair_2_get_Key_mCAD7B121DB998D7C56EB0281215A860EFE9DCD95_gshared_inline (KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = (RuntimeObject *)__this->get_key_0();
		return (RuntimeObject *)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * KeyValuePair_2_get_Value_m622223593F7461E7812C581DDB145270016ED303_gshared_inline (KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = (RuntimeObject *)__this->get_value_1();
		return (RuntimeObject *)L_0;
	}
}
