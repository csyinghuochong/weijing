#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
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
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct InterfaceActionInvoker5
{
	typedef void (*Action)(void*, T1, T2, T3, T4, T5, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, p4, p5, invokeData.method);
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

// System.Action`1<System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>>
struct Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999;
// System.Action`1<UnityEngine.Purchasing.InitializationFailureReason>
struct Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983;
// System.Action`1<System.Int32Enum>
struct Action_1_tF0FD284A49EB7135379250254D6B49FA84383C09;
// System.Action`1<System.Object>
struct Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC;
// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D;
// System.Collections.Generic.Dictionary`2<System.String,System.Object>
struct Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399;
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Purchasing.Product>
struct Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3;
// System.Collections.Generic.Dictionary`2<System.String,System.String>
struct Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5;
// System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration>
struct Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51;
// System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.IStoreExtension>
struct Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004;
// System.Func`2<System.Object,System.Boolean>
struct Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8;
// System.Func`2<System.Object,System.Object>
struct Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436;
// System.Func`2<UnityEngine.Purchasing.Product,System.Boolean>
struct Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06;
// System.Func`2<UnityEngine.Purchasing.Product,System.String>
struct Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0;
// System.Func`2<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product>
struct Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2;
// System.Collections.Generic.HashSet`1<System.Object>
struct HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B;
// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product>
struct HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA;
// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>
struct HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1;
// System.Collections.Generic.IDictionary`2<System.String,System.Object>
struct IDictionary_2_tED3FAE588A6FD3ED0A4589C52122AB8F53D8A3B8;
// System.Collections.Generic.IEnumerable`1<System.Object>
struct IEnumerable_1_t52B1AC8D9E5E1ED28DF6C46A37C9A1B00B394F9D;
// System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.PayoutDefinition>
struct IEnumerable_1_tD514615CC1047D4721507B4869A16AF9C4EFE949;
// System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.Product>
struct IEnumerable_1_tDC86E8238143E448DB6E49715B87B774AB98A3F7;
// System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.ProductDefinition>
struct IEnumerable_1_t525A9FD9C59E65C6778A42487409EC6AA6F489E4;
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>
struct IEnumerator_1_t692ABF80A29FB82368A57AE22841134E3626E47A;
// System.Collections.Generic.IEqualityComparer`1<System.Object>
struct IEqualityComparer_1_t1A386BEF1855064FD5CC71F340A68881A52B4932;
// System.Collections.Generic.IEqualityComparer`1<UnityEngine.Purchasing.Product>
struct IEqualityComparer_1_t8A36BA16E72C459ACF0E5359818E49D82B7A2526;
// System.Collections.Generic.IEqualityComparer`1<UnityEngine.Purchasing.ProductDefinition>
struct IEqualityComparer_1_tEC1CF82C4A359B52B4A2DAEC1258EFB33652D833;
// System.Collections.Generic.IEqualityComparer`1<System.String>
struct IEqualityComparer_1_tE6A65C5E45E33FD7D9849FD0914DE3AD32B68050;
// System.Collections.Generic.IEqualityComparer`1<System.Type>
struct IEqualityComparer_1_t7EEC9B4006D6D425748908D52AA799197F29A165;
// System.Collections.Generic.IList`1<System.Object>
struct IList_1_t707982BD768B18C51D263C759F33BCDBDFA44901;
// System.Collections.Generic.IList`1<UnityEngine.Purchasing.ProductDefinition>
struct IList_1_tDC1792FC74233BD232D090860F9B0FBC88301C34;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,System.Object>
struct KeyCollection_t0043475CBB02FD67894529F3CAA818080A2F7A17;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,UnityEngine.Purchasing.Product>
struct KeyCollection_t133EE6D6B1C80589D64ABA76A33EA515000CDADE;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,System.String>
struct KeyCollection_t52C81163A051BCD87A36FEF95F736DD600E2305D;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration>
struct KeyCollection_tE61AF7C29BF456560A002AEF9BD4BBCC34A9B34D;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Type,UnityEngine.Purchasing.IStoreExtension>
struct KeyCollection_t564C9A5CE4AE188E03B2B854A18A0F4168FB2706;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5;
// System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition>
struct List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5;
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Product>
struct List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA;
// System.Collections.Generic.List`1<UnityEngine.Purchasing.ProductDefinition>
struct List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5;
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Extension.ProductDescription>
struct List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF;
// System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>
struct ReadOnlyCollection_1_t921D1901AD35062BE31FAEB0798A4B814F33A3C3;
// System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Purchasing.ProductDefinition>
struct ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,System.Object>
struct ValueCollection_tB942A1033B750DCF04FE948413982D120FC69A4E;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,UnityEngine.Purchasing.Product>
struct ValueCollection_t982F1D7BF16A528D8E04D84E200C5DAEE8195A42;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,System.String>
struct ValueCollection_t9161A5C97376D261665798FA27DAFD5177305C81;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration>
struct ValueCollection_t479B3EDE1159C78EAA3D3073031B4F330FE6C116;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Type,UnityEngine.Purchasing.IStoreExtension>
struct ValueCollection_tEDB8A43687BC6DEF1ACB265DB2F35011A3D156F9;
// System.Collections.Generic.Dictionary`2/Entry<System.String,System.Object>[]
struct EntryU5BU5D_tDCA1A62E50C5B5A40FD6F44107088AF42F5671D2;
// System.Collections.Generic.Dictionary`2/Entry<System.String,UnityEngine.Purchasing.Product>[]
struct EntryU5BU5D_tDB6EAE21D4E690C1506082FC4F68EB7688FCF9EA;
// System.Collections.Generic.Dictionary`2/Entry<System.String,System.String>[]
struct EntryU5BU5D_t52A654EA9927D1B5F56CA05CF209F2E4393C4510;
// System.Collections.Generic.Dictionary`2/Entry<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration>[]
struct EntryU5BU5D_t655E045236501C5C4F50808D4C165B6D5B8F2755;
// System.Collections.Generic.Dictionary`2/Entry<System.Type,UnityEngine.Purchasing.IStoreExtension>[]
struct EntryU5BU5D_tFEAAAEB113A8290D2088661F702968CA3E97F98B;
// System.Collections.Generic.HashSet`1/Slot<System.Object>[]
struct SlotU5BU5D_tA2C59549601B8D4FF421D3FE4AE207703AADA494;
// System.Collections.Generic.HashSet`1/Slot<UnityEngine.Purchasing.Product>[]
struct SlotU5BU5D_tBB35DF137B8BE0A14EEBEB5FD6F8FB39C60272EE;
// System.Collections.Generic.HashSet`1/Slot<UnityEngine.Purchasing.ProductDefinition>[]
struct SlotU5BU5D_tDB8A48C4E210B3D540FE4F6DC3D0B18D36E9A46E;
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// UnityEngine.Purchasing.Extension.IPurchasingModule[]
struct IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// UnityEngine.Purchasing.PayoutDefinition[]
struct PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786;
// UnityEngine.Purchasing.Product[]
struct ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062;
// UnityEngine.Purchasing.ProductDefinition[]
struct ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738;
// UnityEngine.Purchasing.Extension.ProductDescription[]
struct ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
// System.UInt32[]
struct UInt32U5BU5D_tCF06F1E9E72E0302C762578FF5358CC523F2A2CF;
// UnityEngine.Purchasing.Extension.AbstractPurchasingModule
struct AbstractPurchasingModule_tE97233CECF61E1D47FE937203B395835774FBB04;
// UnityEngine.Purchasing.Extension.AbstractStore
struct AbstractStore_tB0FD374A2E9858EB3A2DC721CBA280409F9485C0;
// System.Action
struct Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6;
// UnityEngine.Purchasing.AnalyticsReporter
struct AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// UnityEngine.Purchasing.ConfigurationBuilder
struct ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.IO.DirectoryInfo
struct DirectoryInfo_t4EF3610F45F0D234800D01ADA8F3F476AE0CF5CD;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// UnityEngine.Purchasing.Extension.ICatalogProvider
struct ICatalogProvider_t0370C13FC059CB78485B74EA854C0FE4FD6CAAB2;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// UnityEngine.Purchasing.IDs
struct IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F;
// System.Collections.IEnumerator
struct IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105;
// UnityEngine.Purchasing.IExtensionProvider
struct IExtensionProvider_tFD47F15B6FCCD46BE6E88D2112B30EC88061B8DC;
// UnityEngine.Purchasing.IInternalStoreListener
struct IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417;
// UnityEngine.ILogger
struct ILogger_t25627AC5B51863702868D31972297B7D633B4583;
// UnityEngine.Purchasing.Extension.IPurchasingBinder
struct IPurchasingBinder_t55347A5ACE1DB3892EEB13D922FD591E238B75E1;
// UnityEngine.Purchasing.Extension.IPurchasingModule
struct IPurchasingModule_t1F474F8488BDF1F1D3B8C907E7648E4829B2A597;
// UnityEngine.Purchasing.Extension.IStore
struct IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E;
// UnityEngine.Purchasing.IStoreController
struct IStoreController_t7F8439B516FC2268F81CE246954C55F8DC6E40F8;
// UnityEngine.Purchasing.IStoreListener
struct IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506;
// UnityEngine.Purchasing.IUnityAnalytics
struct IUnityAnalytics_t011CB850F707109CA3DBD46809D38E6A41EB5765;
// System.InvalidOperationException
struct InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.Purchasing.PayoutDefinition
struct PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D;
// UnityEngine.Purchasing.Product
struct Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E;
// UnityEngine.Purchasing.ProductCollection
struct ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C;
// UnityEngine.Purchasing.ProductDefinition
struct ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572;
// UnityEngine.Purchasing.Extension.ProductDescription
struct ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75;
// UnityEngine.Purchasing.ProductMetadata
struct ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02;
// UnityEngine.Purchasing.PurchaseEventArgs
struct PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114;
// UnityEngine.Purchasing.Extension.PurchaseFailureDescription
struct PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8;
// UnityEngine.Purchasing.PurchasingFactory
struct PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2;
// UnityEngine.Purchasing.PurchasingManager
struct PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1;
// UnityEngine.Purchasing.StoreListenerProxy
struct StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// UnityEngine.Purchasing.TransactionLog
struct TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1;
// UnityEngine.Purchasing.UnifiedReceipt
struct UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C;
// UnityEngine.Purchasing.UnityAnalytics
struct UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.Purchasing.ProductCollection/<>c
struct U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9;
// UnityEngine.Purchasing.PurchasingManager/<>c
struct U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396;
// UnityEngine.Purchasing.PurchasingManager/<>c__DisplayClass23_0
struct U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038;
// UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass2_0
struct U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089;
// UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass3_0
struct U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF;

IL2CPP_EXTERN_C RuntimeClass* Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BitConverter_t8DCBA24B909F1B221372AF2B37C76DCF614BA654_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ICatalogProvider_t0370C13FC059CB78485B74EA854C0FE4FD6CAAB2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IPurchasingBinder_t55347A5ACE1DB3892EEB13D922FD591E238B75E1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IPurchasingModule_t1F474F8488BDF1F1D3B8C907E7648E4829B2A597_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IUnityAnalytics_t011CB850F707109CA3DBD46809D38E6A41EB5765_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Path_tF1D95B78D57C1C1211BA6633FF2AC22FD6C48921_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PurchaseFailureReason_t92D34AB6DC07828C5204898759640EDFB9336BA5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral01178BFE3AE4B5082489FFCE9A716AC6B6F5F635;
IL2CPP_EXTERN_C String_t* _stringLiteral012A18907B249DF0954BFA806717C2FD7DDB76F9;
IL2CPP_EXTERN_C String_t* _stringLiteral0D0B37FF71B4D60D0DEBB7B5FC4A114D5D152406;
IL2CPP_EXTERN_C String_t* _stringLiteral0E768DF5448A939C90FD26493F20E5402437A92E;
IL2CPP_EXTERN_C String_t* _stringLiteral2CC71DBDCE6B0FAE2580070B39FD7E51B3684ECD;
IL2CPP_EXTERN_C String_t* _stringLiteral364F4173856E05DF96506EB76D1DECAD55D36048;
IL2CPP_EXTERN_C String_t* _stringLiteral36E11B7148F1843CD0462BD31F425C12CE582990;
IL2CPP_EXTERN_C String_t* _stringLiteral474DAFF928C5AC11FD7C81344E18501ED567C068;
IL2CPP_EXTERN_C String_t* _stringLiteral523FBF11CD01FCA136C78DEF46B68DDA517990DB;
IL2CPP_EXTERN_C String_t* _stringLiteral57D091E724A1E1A78CFF70893BF15B1612349B44;
IL2CPP_EXTERN_C String_t* _stringLiteral89C49DC40879EC998EC0B3FD9E005123B80E7297;
IL2CPP_EXTERN_C String_t* _stringLiteral9AC36C3A3EC82C292FD998FA2F3C73EFBC571F3A;
IL2CPP_EXTERN_C String_t* _stringLiteral9C03B7A4604CD518F2462F5F825D6BC63324F275;
IL2CPP_EXTERN_C String_t* _stringLiteralAB3E708924BFB9D6B641A4B9F82FE5FE57F307B6;
IL2CPP_EXTERN_C String_t* _stringLiteralC12B0525FE4A7F52BA51C6514949B9777123CD42;
IL2CPP_EXTERN_C String_t* _stringLiteralC18E9CCAC1016A10BA9513A2E6CF1F1FB023D755;
IL2CPP_EXTERN_C String_t* _stringLiteralDD638980A42773DBA4D111CE8D3979093BAC27E5;
IL2CPP_EXTERN_C String_t* _stringLiteralE838692FA53EEF960E9D0CB6D54405E9A12BF310;
IL2CPP_EXTERN_C String_t* _stringLiteralF70186B9E93B040BE74228E43B2D0DFEECC9C509;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_m819A05351F202EF5B8F9AB2F363759B0B09D1319_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_mD253810DCE8FE22D2D7CA13562023DD0CFA960AC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1__ctor_mEC4C58AA11C194EB281B783201E44BEBAA1E18AC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_GetEnumerator_m8C0A038B5FA7E62DEF4DB9EF1F5FCC4348D785C5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_m818108628C884130D20F1CE7A3DD2D0BEDA54240_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_m17F438F4F280FA74C072C108A91953A0D3D08927_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_m44704C7AAA86E3266061F028FC3FC6F45F36D029_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_FirstOrDefault_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_m3C9959CA12D5CE0709E77E76A00693D62C76735F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_Select_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mC47E532FD81FF155A9AD9CE8E139BFA2992B7CFF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_ToArray_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mEE2FE11BDD311009011FF50D0BACC5AA3C07BE1C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_ToDictionary_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_TisString_t_mCE58036003050068B397D143069CEB9FFDDDC0BC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_ToList_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_m01AA1776DEE25E5683AAC0EFB71501BA03745774_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m69B413E241BCF6115FB0F8CFEEB1855788A349F1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_mECB624E9227DAD90587C5FB7547E0ABAC77E23A4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_mF00BC099D6D9E176778EC76B9CBF3F521AE31E9B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_m34DE56BFFB93F822D883D63793D4F6EAF4746808_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_m60D31817DCDACB537CAD2D01045C2CDD5CECD4F2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_mEE376D71AB426CB6748F702E512B357FB483F455_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m0E0A041FD0428646F68B50259291381BEF627BFB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m600D6E603AF57068B4587387CEAAB4EB740A60B4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_m89F845C0B1EA66200DEA88D2FC1CEDB159B0489B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Func_2__ctor_m509007DD57F653BAA3882037AB268CA3D7C5E053_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Func_2__ctor_m5BA6ACDCD9B26E626B98532D5D60DB79C93CCF44_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Func_2__ctor_mC0A642D3F07FB566E56D3E4395C6E7A53093DE9C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_Add_m7D4C2485E000A367089991F01E0724430347AF82_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_Add_mE4FBC8CF189E84F0C496E46A3AB981EEBDE8BF4D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_GetEnumerator_m0556A05132CD535D94ECC794908D21198CC99520_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_GetEnumerator_mEA35B35D1D04D4D0640DEC29AFA49D6AA004E2F7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_Remove_m07D62659DE67245D3DE64BF57E99C7AF25DBC6CF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_UnionWith_mA88C2E1D44F2F4FCC1E7C24880A99405A87B2E09_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1__ctor_m49FF96A56D01B47661A3DA57E99CABB3777841A1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1__ctor_mDB79646D0C35A9CDC3F655F883F35AD083912302_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1__ctor_mF1247FA13C1F59B28E7048BFABB8E206D160FD64_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* HashSet_1_get_Count_m6E973EE5C7480789B23EA6F34AEDE890E1AD0245_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_AddRange_m5C4A175E221847296EA6BA421CB11FC15629780E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Clear_m16E9797AAF502957D595712D9415EE8EC92BC001_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_GetEnumerator_m9C1505A33FD0156C5CDED2CA7BAEB3BF1DE4E1FB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m0066DC5C7B9DADA1721568BFC63754E8159B10AC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PurchasingFactory_get_service_mE5E7B0A844A43B08F2813E258ECD873B0689B39A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ReadOnlyCollection_1__ctor_m0B811F745C2789AF0A5DE025161C795ADCA5A960_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec_U3CAddProductsU3Eb__5_0_m815B1655D68CD538FD0A3C4DA1A6592505B189F8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec_U3CAddProductsU3Eb__5_1_m1F74C97E90D2636BC4DCB850358F89D9A5F84F95_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec_U3CInitializeU3Eb__36_0_m2FBA72637489C224FF4714F2F72AEBE55BE31C86_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass23_0_U3COnAllPurchasesRetrievedU3Eb__0_m1ED6B42682A464C7B9336B43821D16738BC5A3B1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass2_0_U3CInitializeU3Eb__0_mF37EF332DF02DAB08B58D417E5B22A7253B5B790_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass3_0_U3CFetchAndMergeProductsU3Eb__0_m51D9C35CC76C013F9D19AEA16DE34A8B957D122E_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
struct IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2;
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
struct ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062;
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t0530D6C44C4F14D8843541FD8842FECF7B041D2A 
{
public:

public:
};


// System.Object


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


// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Purchasing.Product>
struct Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_tDB6EAE21D4E690C1506082FC4F68EB7688FCF9EA* ___entries_1;
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
	KeyCollection_t133EE6D6B1C80589D64ABA76A33EA515000CDADE * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t982F1D7BF16A528D8E04D84E200C5DAEE8195A42 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___entries_1)); }
	inline EntryU5BU5D_tDB6EAE21D4E690C1506082FC4F68EB7688FCF9EA* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_tDB6EAE21D4E690C1506082FC4F68EB7688FCF9EA** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_tDB6EAE21D4E690C1506082FC4F68EB7688FCF9EA* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___keys_7)); }
	inline KeyCollection_t133EE6D6B1C80589D64ABA76A33EA515000CDADE * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t133EE6D6B1C80589D64ABA76A33EA515000CDADE ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t133EE6D6B1C80589D64ABA76A33EA515000CDADE * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ___values_8)); }
	inline ValueCollection_t982F1D7BF16A528D8E04D84E200C5DAEE8195A42 * get_values_8() const { return ___values_8; }
	inline ValueCollection_t982F1D7BF16A528D8E04D84E200C5DAEE8195A42 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t982F1D7BF16A528D8E04D84E200C5DAEE8195A42 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3, ____syncRoot_9)); }
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


// System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration>
struct Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t655E045236501C5C4F50808D4C165B6D5B8F2755* ___entries_1;
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
	KeyCollection_tE61AF7C29BF456560A002AEF9BD4BBCC34A9B34D * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t479B3EDE1159C78EAA3D3073031B4F330FE6C116 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___entries_1)); }
	inline EntryU5BU5D_t655E045236501C5C4F50808D4C165B6D5B8F2755* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t655E045236501C5C4F50808D4C165B6D5B8F2755** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t655E045236501C5C4F50808D4C165B6D5B8F2755* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___keys_7)); }
	inline KeyCollection_tE61AF7C29BF456560A002AEF9BD4BBCC34A9B34D * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_tE61AF7C29BF456560A002AEF9BD4BBCC34A9B34D ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_tE61AF7C29BF456560A002AEF9BD4BBCC34A9B34D * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ___values_8)); }
	inline ValueCollection_t479B3EDE1159C78EAA3D3073031B4F330FE6C116 * get_values_8() const { return ___values_8; }
	inline ValueCollection_t479B3EDE1159C78EAA3D3073031B4F330FE6C116 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t479B3EDE1159C78EAA3D3073031B4F330FE6C116 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_9), (void*)value);
	}
};


// System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.IStoreExtension>
struct Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_tFEAAAEB113A8290D2088661F702968CA3E97F98B* ___entries_1;
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
	KeyCollection_t564C9A5CE4AE188E03B2B854A18A0F4168FB2706 * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_tEDB8A43687BC6DEF1ACB265DB2F35011A3D156F9 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___entries_1)); }
	inline EntryU5BU5D_tFEAAAEB113A8290D2088661F702968CA3E97F98B* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_tFEAAAEB113A8290D2088661F702968CA3E97F98B** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_tFEAAAEB113A8290D2088661F702968CA3E97F98B* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___keys_7)); }
	inline KeyCollection_t564C9A5CE4AE188E03B2B854A18A0F4168FB2706 * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t564C9A5CE4AE188E03B2B854A18A0F4168FB2706 ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t564C9A5CE4AE188E03B2B854A18A0F4168FB2706 * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ___values_8)); }
	inline ValueCollection_tEDB8A43687BC6DEF1ACB265DB2F35011A3D156F9 * get_values_8() const { return ___values_8; }
	inline ValueCollection_tEDB8A43687BC6DEF1ACB265DB2F35011A3D156F9 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_tEDB8A43687BC6DEF1ACB265DB2F35011A3D156F9 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_9), (void*)value);
	}
};


// System.Collections.Generic.HashSet`1<System.Object>
struct HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.HashSet`1::_buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ____buckets_7;
	// System.Collections.Generic.HashSet`1/Slot<T>[] System.Collections.Generic.HashSet`1::_slots
	SlotU5BU5D_tA2C59549601B8D4FF421D3FE4AE207703AADA494* ____slots_8;
	// System.Int32 System.Collections.Generic.HashSet`1::_count
	int32_t ____count_9;
	// System.Int32 System.Collections.Generic.HashSet`1::_lastIndex
	int32_t ____lastIndex_10;
	// System.Int32 System.Collections.Generic.HashSet`1::_freeList
	int32_t ____freeList_11;
	// System.Collections.Generic.IEqualityComparer`1<T> System.Collections.Generic.HashSet`1::_comparer
	RuntimeObject* ____comparer_12;
	// System.Int32 System.Collections.Generic.HashSet`1::_version
	int32_t ____version_13;
	// System.Runtime.Serialization.SerializationInfo System.Collections.Generic.HashSet`1::_siInfo
	SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * ____siInfo_14;

public:
	inline static int32_t get_offset_of__buckets_7() { return static_cast<int32_t>(offsetof(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B, ____buckets_7)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get__buckets_7() const { return ____buckets_7; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of__buckets_7() { return &____buckets_7; }
	inline void set__buckets_7(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		____buckets_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____buckets_7), (void*)value);
	}

	inline static int32_t get_offset_of__slots_8() { return static_cast<int32_t>(offsetof(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B, ____slots_8)); }
	inline SlotU5BU5D_tA2C59549601B8D4FF421D3FE4AE207703AADA494* get__slots_8() const { return ____slots_8; }
	inline SlotU5BU5D_tA2C59549601B8D4FF421D3FE4AE207703AADA494** get_address_of__slots_8() { return &____slots_8; }
	inline void set__slots_8(SlotU5BU5D_tA2C59549601B8D4FF421D3FE4AE207703AADA494* value)
	{
		____slots_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____slots_8), (void*)value);
	}

	inline static int32_t get_offset_of__count_9() { return static_cast<int32_t>(offsetof(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B, ____count_9)); }
	inline int32_t get__count_9() const { return ____count_9; }
	inline int32_t* get_address_of__count_9() { return &____count_9; }
	inline void set__count_9(int32_t value)
	{
		____count_9 = value;
	}

	inline static int32_t get_offset_of__lastIndex_10() { return static_cast<int32_t>(offsetof(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B, ____lastIndex_10)); }
	inline int32_t get__lastIndex_10() const { return ____lastIndex_10; }
	inline int32_t* get_address_of__lastIndex_10() { return &____lastIndex_10; }
	inline void set__lastIndex_10(int32_t value)
	{
		____lastIndex_10 = value;
	}

	inline static int32_t get_offset_of__freeList_11() { return static_cast<int32_t>(offsetof(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B, ____freeList_11)); }
	inline int32_t get__freeList_11() const { return ____freeList_11; }
	inline int32_t* get_address_of__freeList_11() { return &____freeList_11; }
	inline void set__freeList_11(int32_t value)
	{
		____freeList_11 = value;
	}

	inline static int32_t get_offset_of__comparer_12() { return static_cast<int32_t>(offsetof(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B, ____comparer_12)); }
	inline RuntimeObject* get__comparer_12() const { return ____comparer_12; }
	inline RuntimeObject** get_address_of__comparer_12() { return &____comparer_12; }
	inline void set__comparer_12(RuntimeObject* value)
	{
		____comparer_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____comparer_12), (void*)value);
	}

	inline static int32_t get_offset_of__version_13() { return static_cast<int32_t>(offsetof(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B, ____version_13)); }
	inline int32_t get__version_13() const { return ____version_13; }
	inline int32_t* get_address_of__version_13() { return &____version_13; }
	inline void set__version_13(int32_t value)
	{
		____version_13 = value;
	}

	inline static int32_t get_offset_of__siInfo_14() { return static_cast<int32_t>(offsetof(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B, ____siInfo_14)); }
	inline SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * get__siInfo_14() const { return ____siInfo_14; }
	inline SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 ** get_address_of__siInfo_14() { return &____siInfo_14; }
	inline void set__siInfo_14(SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * value)
	{
		____siInfo_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____siInfo_14), (void*)value);
	}
};


// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product>
struct HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.HashSet`1::_buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ____buckets_7;
	// System.Collections.Generic.HashSet`1/Slot<T>[] System.Collections.Generic.HashSet`1::_slots
	SlotU5BU5D_tBB35DF137B8BE0A14EEBEB5FD6F8FB39C60272EE* ____slots_8;
	// System.Int32 System.Collections.Generic.HashSet`1::_count
	int32_t ____count_9;
	// System.Int32 System.Collections.Generic.HashSet`1::_lastIndex
	int32_t ____lastIndex_10;
	// System.Int32 System.Collections.Generic.HashSet`1::_freeList
	int32_t ____freeList_11;
	// System.Collections.Generic.IEqualityComparer`1<T> System.Collections.Generic.HashSet`1::_comparer
	RuntimeObject* ____comparer_12;
	// System.Int32 System.Collections.Generic.HashSet`1::_version
	int32_t ____version_13;
	// System.Runtime.Serialization.SerializationInfo System.Collections.Generic.HashSet`1::_siInfo
	SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * ____siInfo_14;

public:
	inline static int32_t get_offset_of__buckets_7() { return static_cast<int32_t>(offsetof(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA, ____buckets_7)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get__buckets_7() const { return ____buckets_7; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of__buckets_7() { return &____buckets_7; }
	inline void set__buckets_7(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		____buckets_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____buckets_7), (void*)value);
	}

	inline static int32_t get_offset_of__slots_8() { return static_cast<int32_t>(offsetof(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA, ____slots_8)); }
	inline SlotU5BU5D_tBB35DF137B8BE0A14EEBEB5FD6F8FB39C60272EE* get__slots_8() const { return ____slots_8; }
	inline SlotU5BU5D_tBB35DF137B8BE0A14EEBEB5FD6F8FB39C60272EE** get_address_of__slots_8() { return &____slots_8; }
	inline void set__slots_8(SlotU5BU5D_tBB35DF137B8BE0A14EEBEB5FD6F8FB39C60272EE* value)
	{
		____slots_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____slots_8), (void*)value);
	}

	inline static int32_t get_offset_of__count_9() { return static_cast<int32_t>(offsetof(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA, ____count_9)); }
	inline int32_t get__count_9() const { return ____count_9; }
	inline int32_t* get_address_of__count_9() { return &____count_9; }
	inline void set__count_9(int32_t value)
	{
		____count_9 = value;
	}

	inline static int32_t get_offset_of__lastIndex_10() { return static_cast<int32_t>(offsetof(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA, ____lastIndex_10)); }
	inline int32_t get__lastIndex_10() const { return ____lastIndex_10; }
	inline int32_t* get_address_of__lastIndex_10() { return &____lastIndex_10; }
	inline void set__lastIndex_10(int32_t value)
	{
		____lastIndex_10 = value;
	}

	inline static int32_t get_offset_of__freeList_11() { return static_cast<int32_t>(offsetof(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA, ____freeList_11)); }
	inline int32_t get__freeList_11() const { return ____freeList_11; }
	inline int32_t* get_address_of__freeList_11() { return &____freeList_11; }
	inline void set__freeList_11(int32_t value)
	{
		____freeList_11 = value;
	}

	inline static int32_t get_offset_of__comparer_12() { return static_cast<int32_t>(offsetof(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA, ____comparer_12)); }
	inline RuntimeObject* get__comparer_12() const { return ____comparer_12; }
	inline RuntimeObject** get_address_of__comparer_12() { return &____comparer_12; }
	inline void set__comparer_12(RuntimeObject* value)
	{
		____comparer_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____comparer_12), (void*)value);
	}

	inline static int32_t get_offset_of__version_13() { return static_cast<int32_t>(offsetof(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA, ____version_13)); }
	inline int32_t get__version_13() const { return ____version_13; }
	inline int32_t* get_address_of__version_13() { return &____version_13; }
	inline void set__version_13(int32_t value)
	{
		____version_13 = value;
	}

	inline static int32_t get_offset_of__siInfo_14() { return static_cast<int32_t>(offsetof(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA, ____siInfo_14)); }
	inline SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * get__siInfo_14() const { return ____siInfo_14; }
	inline SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 ** get_address_of__siInfo_14() { return &____siInfo_14; }
	inline void set__siInfo_14(SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * value)
	{
		____siInfo_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____siInfo_14), (void*)value);
	}
};


// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>
struct HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.HashSet`1::_buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ____buckets_7;
	// System.Collections.Generic.HashSet`1/Slot<T>[] System.Collections.Generic.HashSet`1::_slots
	SlotU5BU5D_tDB8A48C4E210B3D540FE4F6DC3D0B18D36E9A46E* ____slots_8;
	// System.Int32 System.Collections.Generic.HashSet`1::_count
	int32_t ____count_9;
	// System.Int32 System.Collections.Generic.HashSet`1::_lastIndex
	int32_t ____lastIndex_10;
	// System.Int32 System.Collections.Generic.HashSet`1::_freeList
	int32_t ____freeList_11;
	// System.Collections.Generic.IEqualityComparer`1<T> System.Collections.Generic.HashSet`1::_comparer
	RuntimeObject* ____comparer_12;
	// System.Int32 System.Collections.Generic.HashSet`1::_version
	int32_t ____version_13;
	// System.Runtime.Serialization.SerializationInfo System.Collections.Generic.HashSet`1::_siInfo
	SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * ____siInfo_14;

public:
	inline static int32_t get_offset_of__buckets_7() { return static_cast<int32_t>(offsetof(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1, ____buckets_7)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get__buckets_7() const { return ____buckets_7; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of__buckets_7() { return &____buckets_7; }
	inline void set__buckets_7(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		____buckets_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____buckets_7), (void*)value);
	}

	inline static int32_t get_offset_of__slots_8() { return static_cast<int32_t>(offsetof(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1, ____slots_8)); }
	inline SlotU5BU5D_tDB8A48C4E210B3D540FE4F6DC3D0B18D36E9A46E* get__slots_8() const { return ____slots_8; }
	inline SlotU5BU5D_tDB8A48C4E210B3D540FE4F6DC3D0B18D36E9A46E** get_address_of__slots_8() { return &____slots_8; }
	inline void set__slots_8(SlotU5BU5D_tDB8A48C4E210B3D540FE4F6DC3D0B18D36E9A46E* value)
	{
		____slots_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____slots_8), (void*)value);
	}

	inline static int32_t get_offset_of__count_9() { return static_cast<int32_t>(offsetof(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1, ____count_9)); }
	inline int32_t get__count_9() const { return ____count_9; }
	inline int32_t* get_address_of__count_9() { return &____count_9; }
	inline void set__count_9(int32_t value)
	{
		____count_9 = value;
	}

	inline static int32_t get_offset_of__lastIndex_10() { return static_cast<int32_t>(offsetof(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1, ____lastIndex_10)); }
	inline int32_t get__lastIndex_10() const { return ____lastIndex_10; }
	inline int32_t* get_address_of__lastIndex_10() { return &____lastIndex_10; }
	inline void set__lastIndex_10(int32_t value)
	{
		____lastIndex_10 = value;
	}

	inline static int32_t get_offset_of__freeList_11() { return static_cast<int32_t>(offsetof(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1, ____freeList_11)); }
	inline int32_t get__freeList_11() const { return ____freeList_11; }
	inline int32_t* get_address_of__freeList_11() { return &____freeList_11; }
	inline void set__freeList_11(int32_t value)
	{
		____freeList_11 = value;
	}

	inline static int32_t get_offset_of__comparer_12() { return static_cast<int32_t>(offsetof(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1, ____comparer_12)); }
	inline RuntimeObject* get__comparer_12() const { return ____comparer_12; }
	inline RuntimeObject** get_address_of__comparer_12() { return &____comparer_12; }
	inline void set__comparer_12(RuntimeObject* value)
	{
		____comparer_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____comparer_12), (void*)value);
	}

	inline static int32_t get_offset_of__version_13() { return static_cast<int32_t>(offsetof(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1, ____version_13)); }
	inline int32_t get__version_13() const { return ____version_13; }
	inline int32_t* get_address_of__version_13() { return &____version_13; }
	inline void set__version_13(int32_t value)
	{
		____version_13 = value;
	}

	inline static int32_t get_offset_of__siInfo_14() { return static_cast<int32_t>(offsetof(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1, ____siInfo_14)); }
	inline SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * get__siInfo_14() const { return ____siInfo_14; }
	inline SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 ** get_address_of__siInfo_14() { return &____siInfo_14; }
	inline void set__siInfo_14(SerializationInfo_t097DA64D9DB49ED7F2458E964BE8CCCF63FC67C1 * value)
	{
		____siInfo_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____siInfo_14), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition>
struct List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5, ____items_1)); }
	inline PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786* get__items_1() const { return ____items_1; }
	inline PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5_StaticFields, ____emptyArray_5)); }
	inline PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786* get__emptyArray_5() const { return ____emptyArray_5; }
	inline PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(PayoutDefinitionU5BU5D_t62683F41522EDD4C5F68F9DC67A06B4C87DAF786* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.Purchasing.Product>
struct List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA, ____items_1)); }
	inline ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* get__items_1() const { return ____items_1; }
	inline ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA_StaticFields, ____emptyArray_5)); }
	inline ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.Purchasing.ProductDefinition>
struct List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5, ____items_1)); }
	inline ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738* get__items_1() const { return ____items_1; }
	inline ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5_StaticFields, ____emptyArray_5)); }
	inline ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ProductDefinitionU5BU5D_tB67240A61C620B2DD2F71ED68D36C378EA560738* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.Purchasing.Extension.ProductDescription>
struct List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF, ____items_1)); }
	inline ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79* get__items_1() const { return ____items_1; }
	inline ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF_StaticFields, ____emptyArray_5)); }
	inline ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ProductDescriptionU5BU5D_t2A77BC327A51622FB3EB0927656D980A1A10EB79* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Purchasing.ProductDefinition>
struct ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3  : public RuntimeObject
{
public:
	// System.Collections.Generic.IList`1<T> System.Collections.ObjectModel.ReadOnlyCollection`1::list
	RuntimeObject* ___list_0;
	// System.Object System.Collections.ObjectModel.ReadOnlyCollection`1::_syncRoot
	RuntimeObject * ____syncRoot_1;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3, ___list_0)); }
	inline RuntimeObject* get_list_0() const { return ___list_0; }
	inline RuntimeObject** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(RuntimeObject* value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_1() { return static_cast<int32_t>(offsetof(ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3, ____syncRoot_1)); }
	inline RuntimeObject * get__syncRoot_1() const { return ____syncRoot_1; }
	inline RuntimeObject ** get_address_of__syncRoot_1() { return &____syncRoot_1; }
	inline void set__syncRoot_1(RuntimeObject * value)
	{
		____syncRoot_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_1), (void*)value);
	}
};


// UnityEngine.Purchasing.Extension.AbstractPurchasingModule
struct AbstractPurchasingModule_tE97233CECF61E1D47FE937203B395835774FBB04  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.Extension.IPurchasingBinder UnityEngine.Purchasing.Extension.AbstractPurchasingModule::m_Binder
	RuntimeObject* ___m_Binder_0;

public:
	inline static int32_t get_offset_of_m_Binder_0() { return static_cast<int32_t>(offsetof(AbstractPurchasingModule_tE97233CECF61E1D47FE937203B395835774FBB04, ___m_Binder_0)); }
	inline RuntimeObject* get_m_Binder_0() const { return ___m_Binder_0; }
	inline RuntimeObject** get_address_of_m_Binder_0() { return &___m_Binder_0; }
	inline void set_m_Binder_0(RuntimeObject* value)
	{
		___m_Binder_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Binder_0), (void*)value);
	}
};


// UnityEngine.Purchasing.Extension.AbstractStore
struct AbstractStore_tB0FD374A2E9858EB3A2DC721CBA280409F9485C0  : public RuntimeObject
{
public:

public:
};


// UnityEngine.Purchasing.AnalyticsReporter
struct AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.IUnityAnalytics UnityEngine.Purchasing.AnalyticsReporter::m_Analytics
	RuntimeObject* ___m_Analytics_0;

public:
	inline static int32_t get_offset_of_m_Analytics_0() { return static_cast<int32_t>(offsetof(AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB, ___m_Analytics_0)); }
	inline RuntimeObject* get_m_Analytics_0() const { return ___m_Analytics_0; }
	inline RuntimeObject** get_address_of_m_Analytics_0() { return &___m_Analytics_0; }
	inline void set_m_Analytics_0(RuntimeObject* value)
	{
		___m_Analytics_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Analytics_0), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// UnityEngine.Purchasing.ConfigurationBuilder
struct ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.PurchasingFactory UnityEngine.Purchasing.ConfigurationBuilder::m_Factory
	PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * ___m_Factory_0;
	// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition> UnityEngine.Purchasing.ConfigurationBuilder::m_Products
	HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___m_Products_1;
	// System.Boolean UnityEngine.Purchasing.ConfigurationBuilder::<useCatalogProvider>k__BackingField
	bool ___U3CuseCatalogProviderU3Ek__BackingField_2;

public:
	inline static int32_t get_offset_of_m_Factory_0() { return static_cast<int32_t>(offsetof(ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A, ___m_Factory_0)); }
	inline PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * get_m_Factory_0() const { return ___m_Factory_0; }
	inline PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 ** get_address_of_m_Factory_0() { return &___m_Factory_0; }
	inline void set_m_Factory_0(PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * value)
	{
		___m_Factory_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Factory_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_Products_1() { return static_cast<int32_t>(offsetof(ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A, ___m_Products_1)); }
	inline HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * get_m_Products_1() const { return ___m_Products_1; }
	inline HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 ** get_address_of_m_Products_1() { return &___m_Products_1; }
	inline void set_m_Products_1(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * value)
	{
		___m_Products_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Products_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CuseCatalogProviderU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A, ___U3CuseCatalogProviderU3Ek__BackingField_2)); }
	inline bool get_U3CuseCatalogProviderU3Ek__BackingField_2() const { return ___U3CuseCatalogProviderU3Ek__BackingField_2; }
	inline bool* get_address_of_U3CuseCatalogProviderU3Ek__BackingField_2() { return &___U3CuseCatalogProviderU3Ek__BackingField_2; }
	inline void set_U3CuseCatalogProviderU3Ek__BackingField_2(bool value)
	{
		___U3CuseCatalogProviderU3Ek__BackingField_2 = value;
	}
};


// UnityEngine.Debug
struct Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B  : public RuntimeObject
{
public:

public:
};

struct Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_StaticFields
{
public:
	// UnityEngine.ILogger UnityEngine.Debug::s_DefaultLogger
	RuntimeObject* ___s_DefaultLogger_0;
	// UnityEngine.ILogger UnityEngine.Debug::s_Logger
	RuntimeObject* ___s_Logger_1;

public:
	inline static int32_t get_offset_of_s_DefaultLogger_0() { return static_cast<int32_t>(offsetof(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_StaticFields, ___s_DefaultLogger_0)); }
	inline RuntimeObject* get_s_DefaultLogger_0() const { return ___s_DefaultLogger_0; }
	inline RuntimeObject** get_address_of_s_DefaultLogger_0() { return &___s_DefaultLogger_0; }
	inline void set_s_DefaultLogger_0(RuntimeObject* value)
	{
		___s_DefaultLogger_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_DefaultLogger_0), (void*)value);
	}

	inline static int32_t get_offset_of_s_Logger_1() { return static_cast<int32_t>(offsetof(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_StaticFields, ___s_Logger_1)); }
	inline RuntimeObject* get_s_Logger_1() const { return ___s_Logger_1; }
	inline RuntimeObject** get_address_of_s_Logger_1() { return &___s_Logger_1; }
	inline void set_s_Logger_1(RuntimeObject* value)
	{
		___s_Logger_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Logger_1), (void*)value);
	}
};


// UnityEngine.Purchasing.IDs
struct IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F  : public RuntimeObject
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.String> UnityEngine.Purchasing.IDs::m_Dic
	Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * ___m_Dic_0;

public:
	inline static int32_t get_offset_of_m_Dic_0() { return static_cast<int32_t>(offsetof(IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F, ___m_Dic_0)); }
	inline Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * get_m_Dic_0() const { return ___m_Dic_0; }
	inline Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 ** get_address_of_m_Dic_0() { return &___m_Dic_0; }
	inline void set_m_Dic_0(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * value)
	{
		___m_Dic_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Dic_0), (void*)value);
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

// UnityEngine.Purchasing.Product
struct Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.ProductDefinition UnityEngine.Purchasing.Product::<definition>k__BackingField
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___U3CdefinitionU3Ek__BackingField_0;
	// UnityEngine.Purchasing.ProductMetadata UnityEngine.Purchasing.Product::<metadata>k__BackingField
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___U3CmetadataU3Ek__BackingField_1;
	// System.Boolean UnityEngine.Purchasing.Product::<availableToPurchase>k__BackingField
	bool ___U3CavailableToPurchaseU3Ek__BackingField_2;
	// System.String UnityEngine.Purchasing.Product::<transactionID>k__BackingField
	String_t* ___U3CtransactionIDU3Ek__BackingField_3;
	// System.String UnityEngine.Purchasing.Product::<receipt>k__BackingField
	String_t* ___U3CreceiptU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CdefinitionU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E, ___U3CdefinitionU3Ek__BackingField_0)); }
	inline ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * get_U3CdefinitionU3Ek__BackingField_0() const { return ___U3CdefinitionU3Ek__BackingField_0; }
	inline ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 ** get_address_of_U3CdefinitionU3Ek__BackingField_0() { return &___U3CdefinitionU3Ek__BackingField_0; }
	inline void set_U3CdefinitionU3Ek__BackingField_0(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * value)
	{
		___U3CdefinitionU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CdefinitionU3Ek__BackingField_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CmetadataU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E, ___U3CmetadataU3Ek__BackingField_1)); }
	inline ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * get_U3CmetadataU3Ek__BackingField_1() const { return ___U3CmetadataU3Ek__BackingField_1; }
	inline ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 ** get_address_of_U3CmetadataU3Ek__BackingField_1() { return &___U3CmetadataU3Ek__BackingField_1; }
	inline void set_U3CmetadataU3Ek__BackingField_1(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * value)
	{
		___U3CmetadataU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CmetadataU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CavailableToPurchaseU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E, ___U3CavailableToPurchaseU3Ek__BackingField_2)); }
	inline bool get_U3CavailableToPurchaseU3Ek__BackingField_2() const { return ___U3CavailableToPurchaseU3Ek__BackingField_2; }
	inline bool* get_address_of_U3CavailableToPurchaseU3Ek__BackingField_2() { return &___U3CavailableToPurchaseU3Ek__BackingField_2; }
	inline void set_U3CavailableToPurchaseU3Ek__BackingField_2(bool value)
	{
		___U3CavailableToPurchaseU3Ek__BackingField_2 = value;
	}

	inline static int32_t get_offset_of_U3CtransactionIDU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E, ___U3CtransactionIDU3Ek__BackingField_3)); }
	inline String_t* get_U3CtransactionIDU3Ek__BackingField_3() const { return ___U3CtransactionIDU3Ek__BackingField_3; }
	inline String_t** get_address_of_U3CtransactionIDU3Ek__BackingField_3() { return &___U3CtransactionIDU3Ek__BackingField_3; }
	inline void set_U3CtransactionIDU3Ek__BackingField_3(String_t* value)
	{
		___U3CtransactionIDU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CtransactionIDU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CreceiptU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E, ___U3CreceiptU3Ek__BackingField_4)); }
	inline String_t* get_U3CreceiptU3Ek__BackingField_4() const { return ___U3CreceiptU3Ek__BackingField_4; }
	inline String_t** get_address_of_U3CreceiptU3Ek__BackingField_4() { return &___U3CreceiptU3Ek__BackingField_4; }
	inline void set_U3CreceiptU3Ek__BackingField_4(String_t* value)
	{
		___U3CreceiptU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CreceiptU3Ek__BackingField_4), (void*)value);
	}
};


// UnityEngine.Purchasing.ProductCollection
struct ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C  : public RuntimeObject
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Purchasing.Product> UnityEngine.Purchasing.ProductCollection::m_IdToProduct
	Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * ___m_IdToProduct_0;
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Purchasing.Product> UnityEngine.Purchasing.ProductCollection::m_StoreSpecificIdToProduct
	Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * ___m_StoreSpecificIdToProduct_1;
	// UnityEngine.Purchasing.Product[] UnityEngine.Purchasing.ProductCollection::m_Products
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* ___m_Products_2;
	// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product> UnityEngine.Purchasing.ProductCollection::m_ProductSet
	HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * ___m_ProductSet_3;

public:
	inline static int32_t get_offset_of_m_IdToProduct_0() { return static_cast<int32_t>(offsetof(ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C, ___m_IdToProduct_0)); }
	inline Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * get_m_IdToProduct_0() const { return ___m_IdToProduct_0; }
	inline Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 ** get_address_of_m_IdToProduct_0() { return &___m_IdToProduct_0; }
	inline void set_m_IdToProduct_0(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * value)
	{
		___m_IdToProduct_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_IdToProduct_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_StoreSpecificIdToProduct_1() { return static_cast<int32_t>(offsetof(ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C, ___m_StoreSpecificIdToProduct_1)); }
	inline Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * get_m_StoreSpecificIdToProduct_1() const { return ___m_StoreSpecificIdToProduct_1; }
	inline Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 ** get_address_of_m_StoreSpecificIdToProduct_1() { return &___m_StoreSpecificIdToProduct_1; }
	inline void set_m_StoreSpecificIdToProduct_1(Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * value)
	{
		___m_StoreSpecificIdToProduct_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_StoreSpecificIdToProduct_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_Products_2() { return static_cast<int32_t>(offsetof(ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C, ___m_Products_2)); }
	inline ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* get_m_Products_2() const { return ___m_Products_2; }
	inline ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062** get_address_of_m_Products_2() { return &___m_Products_2; }
	inline void set_m_Products_2(ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* value)
	{
		___m_Products_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Products_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_ProductSet_3() { return static_cast<int32_t>(offsetof(ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C, ___m_ProductSet_3)); }
	inline HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * get_m_ProductSet_3() const { return ___m_ProductSet_3; }
	inline HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA ** get_address_of_m_ProductSet_3() { return &___m_ProductSet_3; }
	inline void set_m_ProductSet_3(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * value)
	{
		___m_ProductSet_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ProductSet_3), (void*)value);
	}
};


// UnityEngine.Purchasing.ProductPurchaseUpdater
struct ProductPurchaseUpdater_t3C687B4F5C16313A0616F2D2D4CD625745AE0717  : public RuntimeObject
{
public:

public:
};


// UnityEngine.Purchasing.PurchaseEventArgs
struct PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.Product UnityEngine.Purchasing.PurchaseEventArgs::<purchasedProduct>k__BackingField
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___U3CpurchasedProductU3Ek__BackingField_0;

public:
	inline static int32_t get_offset_of_U3CpurchasedProductU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114, ___U3CpurchasedProductU3Ek__BackingField_0)); }
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * get_U3CpurchasedProductU3Ek__BackingField_0() const { return ___U3CpurchasedProductU3Ek__BackingField_0; }
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E ** get_address_of_U3CpurchasedProductU3Ek__BackingField_0() { return &___U3CpurchasedProductU3Ek__BackingField_0; }
	inline void set_U3CpurchasedProductU3Ek__BackingField_0(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * value)
	{
		___U3CpurchasedProductU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CpurchasedProductU3Ek__BackingField_0), (void*)value);
	}
};


// UnityEngine.Purchasing.PurchasingFactory
struct PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2  : public RuntimeObject
{
public:
	// System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration> UnityEngine.Purchasing.PurchasingFactory::m_ConfigMap
	Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51 * ___m_ConfigMap_0;
	// System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.IStoreExtension> UnityEngine.Purchasing.PurchasingFactory::m_ExtensionMap
	Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004 * ___m_ExtensionMap_1;
	// UnityEngine.Purchasing.Extension.IStore UnityEngine.Purchasing.PurchasingFactory::m_Store
	RuntimeObject* ___m_Store_2;
	// UnityEngine.Purchasing.Extension.ICatalogProvider UnityEngine.Purchasing.PurchasingFactory::m_CatalogProvider
	RuntimeObject* ___m_CatalogProvider_3;
	// System.String UnityEngine.Purchasing.PurchasingFactory::<storeName>k__BackingField
	String_t* ___U3CstoreNameU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_m_ConfigMap_0() { return static_cast<int32_t>(offsetof(PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2, ___m_ConfigMap_0)); }
	inline Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51 * get_m_ConfigMap_0() const { return ___m_ConfigMap_0; }
	inline Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51 ** get_address_of_m_ConfigMap_0() { return &___m_ConfigMap_0; }
	inline void set_m_ConfigMap_0(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51 * value)
	{
		___m_ConfigMap_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ConfigMap_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_ExtensionMap_1() { return static_cast<int32_t>(offsetof(PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2, ___m_ExtensionMap_1)); }
	inline Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004 * get_m_ExtensionMap_1() const { return ___m_ExtensionMap_1; }
	inline Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004 ** get_address_of_m_ExtensionMap_1() { return &___m_ExtensionMap_1; }
	inline void set_m_ExtensionMap_1(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004 * value)
	{
		___m_ExtensionMap_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ExtensionMap_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_Store_2() { return static_cast<int32_t>(offsetof(PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2, ___m_Store_2)); }
	inline RuntimeObject* get_m_Store_2() const { return ___m_Store_2; }
	inline RuntimeObject** get_address_of_m_Store_2() { return &___m_Store_2; }
	inline void set_m_Store_2(RuntimeObject* value)
	{
		___m_Store_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Store_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_CatalogProvider_3() { return static_cast<int32_t>(offsetof(PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2, ___m_CatalogProvider_3)); }
	inline RuntimeObject* get_m_CatalogProvider_3() const { return ___m_CatalogProvider_3; }
	inline RuntimeObject** get_address_of_m_CatalogProvider_3() { return &___m_CatalogProvider_3; }
	inline void set_m_CatalogProvider_3(RuntimeObject* value)
	{
		___m_CatalogProvider_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CatalogProvider_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CstoreNameU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2, ___U3CstoreNameU3Ek__BackingField_4)); }
	inline String_t* get_U3CstoreNameU3Ek__BackingField_4() const { return ___U3CstoreNameU3Ek__BackingField_4; }
	inline String_t** get_address_of_U3CstoreNameU3Ek__BackingField_4() { return &___U3CstoreNameU3Ek__BackingField_4; }
	inline void set_U3CstoreNameU3Ek__BackingField_4(String_t* value)
	{
		___U3CstoreNameU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CstoreNameU3Ek__BackingField_4), (void*)value);
	}
};


// UnityEngine.Purchasing.PurchasingManager
struct PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.Extension.IStore UnityEngine.Purchasing.PurchasingManager::m_Store
	RuntimeObject* ___m_Store_0;
	// UnityEngine.Purchasing.IInternalStoreListener UnityEngine.Purchasing.PurchasingManager::m_Listener
	RuntimeObject* ___m_Listener_1;
	// UnityEngine.ILogger UnityEngine.Purchasing.PurchasingManager::m_Logger
	RuntimeObject* ___m_Logger_2;
	// UnityEngine.Purchasing.TransactionLog UnityEngine.Purchasing.PurchasingManager::m_TransactionLog
	TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * ___m_TransactionLog_3;
	// System.String UnityEngine.Purchasing.PurchasingManager::m_StoreName
	String_t* ___m_StoreName_4;
	// System.Action UnityEngine.Purchasing.PurchasingManager::m_AdditionalProductsCallback
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___m_AdditionalProductsCallback_5;
	// System.Action`1<UnityEngine.Purchasing.InitializationFailureReason> UnityEngine.Purchasing.PurchasingManager::m_AdditionalProductsFailCallback
	Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983 * ___m_AdditionalProductsFailCallback_6;
	// System.Boolean UnityEngine.Purchasing.PurchasingManager::<useTransactionLog>k__BackingField
	bool ___U3CuseTransactionLogU3Ek__BackingField_7;
	// UnityEngine.Purchasing.ProductCollection UnityEngine.Purchasing.PurchasingManager::<products>k__BackingField
	ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * ___U3CproductsU3Ek__BackingField_8;
	// System.Boolean UnityEngine.Purchasing.PurchasingManager::initialized
	bool ___initialized_9;

public:
	inline static int32_t get_offset_of_m_Store_0() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___m_Store_0)); }
	inline RuntimeObject* get_m_Store_0() const { return ___m_Store_0; }
	inline RuntimeObject** get_address_of_m_Store_0() { return &___m_Store_0; }
	inline void set_m_Store_0(RuntimeObject* value)
	{
		___m_Store_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Store_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_Listener_1() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___m_Listener_1)); }
	inline RuntimeObject* get_m_Listener_1() const { return ___m_Listener_1; }
	inline RuntimeObject** get_address_of_m_Listener_1() { return &___m_Listener_1; }
	inline void set_m_Listener_1(RuntimeObject* value)
	{
		___m_Listener_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Listener_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_Logger_2() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___m_Logger_2)); }
	inline RuntimeObject* get_m_Logger_2() const { return ___m_Logger_2; }
	inline RuntimeObject** get_address_of_m_Logger_2() { return &___m_Logger_2; }
	inline void set_m_Logger_2(RuntimeObject* value)
	{
		___m_Logger_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Logger_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_TransactionLog_3() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___m_TransactionLog_3)); }
	inline TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * get_m_TransactionLog_3() const { return ___m_TransactionLog_3; }
	inline TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 ** get_address_of_m_TransactionLog_3() { return &___m_TransactionLog_3; }
	inline void set_m_TransactionLog_3(TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * value)
	{
		___m_TransactionLog_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_TransactionLog_3), (void*)value);
	}

	inline static int32_t get_offset_of_m_StoreName_4() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___m_StoreName_4)); }
	inline String_t* get_m_StoreName_4() const { return ___m_StoreName_4; }
	inline String_t** get_address_of_m_StoreName_4() { return &___m_StoreName_4; }
	inline void set_m_StoreName_4(String_t* value)
	{
		___m_StoreName_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_StoreName_4), (void*)value);
	}

	inline static int32_t get_offset_of_m_AdditionalProductsCallback_5() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___m_AdditionalProductsCallback_5)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_m_AdditionalProductsCallback_5() const { return ___m_AdditionalProductsCallback_5; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_m_AdditionalProductsCallback_5() { return &___m_AdditionalProductsCallback_5; }
	inline void set_m_AdditionalProductsCallback_5(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___m_AdditionalProductsCallback_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_AdditionalProductsCallback_5), (void*)value);
	}

	inline static int32_t get_offset_of_m_AdditionalProductsFailCallback_6() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___m_AdditionalProductsFailCallback_6)); }
	inline Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983 * get_m_AdditionalProductsFailCallback_6() const { return ___m_AdditionalProductsFailCallback_6; }
	inline Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983 ** get_address_of_m_AdditionalProductsFailCallback_6() { return &___m_AdditionalProductsFailCallback_6; }
	inline void set_m_AdditionalProductsFailCallback_6(Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983 * value)
	{
		___m_AdditionalProductsFailCallback_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_AdditionalProductsFailCallback_6), (void*)value);
	}

	inline static int32_t get_offset_of_U3CuseTransactionLogU3Ek__BackingField_7() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___U3CuseTransactionLogU3Ek__BackingField_7)); }
	inline bool get_U3CuseTransactionLogU3Ek__BackingField_7() const { return ___U3CuseTransactionLogU3Ek__BackingField_7; }
	inline bool* get_address_of_U3CuseTransactionLogU3Ek__BackingField_7() { return &___U3CuseTransactionLogU3Ek__BackingField_7; }
	inline void set_U3CuseTransactionLogU3Ek__BackingField_7(bool value)
	{
		___U3CuseTransactionLogU3Ek__BackingField_7 = value;
	}

	inline static int32_t get_offset_of_U3CproductsU3Ek__BackingField_8() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___U3CproductsU3Ek__BackingField_8)); }
	inline ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * get_U3CproductsU3Ek__BackingField_8() const { return ___U3CproductsU3Ek__BackingField_8; }
	inline ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C ** get_address_of_U3CproductsU3Ek__BackingField_8() { return &___U3CproductsU3Ek__BackingField_8; }
	inline void set_U3CproductsU3Ek__BackingField_8(ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * value)
	{
		___U3CproductsU3Ek__BackingField_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CproductsU3Ek__BackingField_8), (void*)value);
	}

	inline static int32_t get_offset_of_initialized_9() { return static_cast<int32_t>(offsetof(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B, ___initialized_9)); }
	inline bool get_initialized_9() const { return ___initialized_9; }
	inline bool* get_address_of_initialized_9() { return &___initialized_9; }
	inline void set_initialized_9(bool value)
	{
		___initialized_9 = value;
	}
};


// UnityEngine.Purchasing.StoreListenerProxy
struct StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.AnalyticsReporter UnityEngine.Purchasing.StoreListenerProxy::m_Analytics
	AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * ___m_Analytics_0;
	// UnityEngine.Purchasing.IStoreListener UnityEngine.Purchasing.StoreListenerProxy::m_ForwardTo
	RuntimeObject* ___m_ForwardTo_1;
	// UnityEngine.Purchasing.IExtensionProvider UnityEngine.Purchasing.StoreListenerProxy::m_Extensions
	RuntimeObject* ___m_Extensions_2;

public:
	inline static int32_t get_offset_of_m_Analytics_0() { return static_cast<int32_t>(offsetof(StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA, ___m_Analytics_0)); }
	inline AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * get_m_Analytics_0() const { return ___m_Analytics_0; }
	inline AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB ** get_address_of_m_Analytics_0() { return &___m_Analytics_0; }
	inline void set_m_Analytics_0(AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * value)
	{
		___m_Analytics_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Analytics_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_ForwardTo_1() { return static_cast<int32_t>(offsetof(StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA, ___m_ForwardTo_1)); }
	inline RuntimeObject* get_m_ForwardTo_1() const { return ___m_ForwardTo_1; }
	inline RuntimeObject** get_address_of_m_ForwardTo_1() { return &___m_ForwardTo_1; }
	inline void set_m_ForwardTo_1(RuntimeObject* value)
	{
		___m_ForwardTo_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ForwardTo_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_Extensions_2() { return static_cast<int32_t>(offsetof(StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA, ___m_Extensions_2)); }
	inline RuntimeObject* get_m_Extensions_2() const { return ___m_Extensions_2; }
	inline RuntimeObject** get_address_of_m_Extensions_2() { return &___m_Extensions_2; }
	inline void set_m_Extensions_2(RuntimeObject* value)
	{
		___m_Extensions_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Extensions_2), (void*)value);
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


// UnityEngine.Purchasing.TransactionLog
struct TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1  : public RuntimeObject
{
public:
	// UnityEngine.ILogger UnityEngine.Purchasing.TransactionLog::logger
	RuntimeObject* ___logger_0;
	// System.String UnityEngine.Purchasing.TransactionLog::persistentDataPath
	String_t* ___persistentDataPath_1;

public:
	inline static int32_t get_offset_of_logger_0() { return static_cast<int32_t>(offsetof(TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1, ___logger_0)); }
	inline RuntimeObject* get_logger_0() const { return ___logger_0; }
	inline RuntimeObject** get_address_of_logger_0() { return &___logger_0; }
	inline void set_logger_0(RuntimeObject* value)
	{
		___logger_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___logger_0), (void*)value);
	}

	inline static int32_t get_offset_of_persistentDataPath_1() { return static_cast<int32_t>(offsetof(TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1, ___persistentDataPath_1)); }
	inline String_t* get_persistentDataPath_1() const { return ___persistentDataPath_1; }
	inline String_t** get_address_of_persistentDataPath_1() { return &___persistentDataPath_1; }
	inline void set_persistentDataPath_1(String_t* value)
	{
		___persistentDataPath_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___persistentDataPath_1), (void*)value);
	}
};


// UnityEngine.Purchasing.UnifiedReceipt
struct UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C  : public RuntimeObject
{
public:
	// System.String UnityEngine.Purchasing.UnifiedReceipt::Payload
	String_t* ___Payload_0;
	// System.String UnityEngine.Purchasing.UnifiedReceipt::Store
	String_t* ___Store_1;
	// System.String UnityEngine.Purchasing.UnifiedReceipt::TransactionID
	String_t* ___TransactionID_2;

public:
	inline static int32_t get_offset_of_Payload_0() { return static_cast<int32_t>(offsetof(UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C, ___Payload_0)); }
	inline String_t* get_Payload_0() const { return ___Payload_0; }
	inline String_t** get_address_of_Payload_0() { return &___Payload_0; }
	inline void set_Payload_0(String_t* value)
	{
		___Payload_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Payload_0), (void*)value);
	}

	inline static int32_t get_offset_of_Store_1() { return static_cast<int32_t>(offsetof(UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C, ___Store_1)); }
	inline String_t* get_Store_1() const { return ___Store_1; }
	inline String_t** get_address_of_Store_1() { return &___Store_1; }
	inline void set_Store_1(String_t* value)
	{
		___Store_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Store_1), (void*)value);
	}

	inline static int32_t get_offset_of_TransactionID_2() { return static_cast<int32_t>(offsetof(UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C, ___TransactionID_2)); }
	inline String_t* get_TransactionID_2() const { return ___TransactionID_2; }
	inline String_t** get_address_of_TransactionID_2() { return &___TransactionID_2; }
	inline void set_TransactionID_2(String_t* value)
	{
		___TransactionID_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TransactionID_2), (void*)value);
	}
};


// UnityEngine.Purchasing.UnifiedReceiptFormatter
struct UnifiedReceiptFormatter_tF17B9AB60209A3B70E46DFAAC8E597E7108B1E81  : public RuntimeObject
{
public:

public:
};


// UnityEngine.Purchasing.UnityAnalytics
struct UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62  : public RuntimeObject
{
public:

public:
};


// UnityEngine.Purchasing.UnityPurchasing
struct UnityPurchasing_tE6C5F8D267566C120DCAE72D4A5B2024CF0DBE96  : public RuntimeObject
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

// UnityEngine.Purchasing.ProductCollection/<>c
struct U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9  : public RuntimeObject
{
public:

public:
};

struct U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields
{
public:
	// UnityEngine.Purchasing.ProductCollection/<>c UnityEngine.Purchasing.ProductCollection/<>c::<>9
	U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * ___U3CU3E9_0;
	// System.Func`2<UnityEngine.Purchasing.Product,System.String> UnityEngine.Purchasing.ProductCollection/<>c::<>9__5_0
	Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * ___U3CU3E9__5_0_1;
	// System.Func`2<UnityEngine.Purchasing.Product,System.String> UnityEngine.Purchasing.ProductCollection/<>c::<>9__5_1
	Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * ___U3CU3E9__5_1_2;

public:
	inline static int32_t get_offset_of_U3CU3E9_0() { return static_cast<int32_t>(offsetof(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields, ___U3CU3E9_0)); }
	inline U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * get_U3CU3E9_0() const { return ___U3CU3E9_0; }
	inline U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 ** get_address_of_U3CU3E9_0() { return &___U3CU3E9_0; }
	inline void set_U3CU3E9_0(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * value)
	{
		___U3CU3E9_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E9__5_0_1() { return static_cast<int32_t>(offsetof(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields, ___U3CU3E9__5_0_1)); }
	inline Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * get_U3CU3E9__5_0_1() const { return ___U3CU3E9__5_0_1; }
	inline Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 ** get_address_of_U3CU3E9__5_0_1() { return &___U3CU3E9__5_0_1; }
	inline void set_U3CU3E9__5_0_1(Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * value)
	{
		___U3CU3E9__5_0_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9__5_0_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E9__5_1_2() { return static_cast<int32_t>(offsetof(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields, ___U3CU3E9__5_1_2)); }
	inline Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * get_U3CU3E9__5_1_2() const { return ___U3CU3E9__5_1_2; }
	inline Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 ** get_address_of_U3CU3E9__5_1_2() { return &___U3CU3E9__5_1_2; }
	inline void set_U3CU3E9__5_1_2(Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * value)
	{
		___U3CU3E9__5_1_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9__5_1_2), (void*)value);
	}
};


// UnityEngine.Purchasing.PurchasingManager/<>c
struct U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396  : public RuntimeObject
{
public:

public:
};

struct U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_StaticFields
{
public:
	// UnityEngine.Purchasing.PurchasingManager/<>c UnityEngine.Purchasing.PurchasingManager/<>c::<>9
	U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 * ___U3CU3E9_0;
	// System.Func`2<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product> UnityEngine.Purchasing.PurchasingManager/<>c::<>9__36_0
	Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * ___U3CU3E9__36_0_1;

public:
	inline static int32_t get_offset_of_U3CU3E9_0() { return static_cast<int32_t>(offsetof(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_StaticFields, ___U3CU3E9_0)); }
	inline U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 * get_U3CU3E9_0() const { return ___U3CU3E9_0; }
	inline U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 ** get_address_of_U3CU3E9_0() { return &___U3CU3E9_0; }
	inline void set_U3CU3E9_0(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 * value)
	{
		___U3CU3E9_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E9__36_0_1() { return static_cast<int32_t>(offsetof(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_StaticFields, ___U3CU3E9__36_0_1)); }
	inline Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * get_U3CU3E9__36_0_1() const { return ___U3CU3E9__36_0_1; }
	inline Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 ** get_address_of_U3CU3E9__36_0_1() { return &___U3CU3E9__36_0_1; }
	inline void set_U3CU3E9__36_0_1(Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * value)
	{
		___U3CU3E9__36_0_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9__36_0_1), (void*)value);
	}
};


// UnityEngine.Purchasing.PurchasingManager/<>c__DisplayClass23_0
struct U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.Product UnityEngine.Purchasing.PurchasingManager/<>c__DisplayClass23_0::product
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product_0;

public:
	inline static int32_t get_offset_of_product_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038, ___product_0)); }
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * get_product_0() const { return ___product_0; }
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E ** get_address_of_product_0() { return &___product_0; }
	inline void set_product_0(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * value)
	{
		___product_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___product_0), (void*)value);
	}
};


// UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass2_0
struct U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.PurchasingManager UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass2_0::manager
	PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * ___manager_0;
	// UnityEngine.Purchasing.StoreListenerProxy UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass2_0::proxy
	StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * ___proxy_1;

public:
	inline static int32_t get_offset_of_manager_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089, ___manager_0)); }
	inline PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * get_manager_0() const { return ___manager_0; }
	inline PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B ** get_address_of_manager_0() { return &___manager_0; }
	inline void set_manager_0(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * value)
	{
		___manager_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___manager_0), (void*)value);
	}

	inline static int32_t get_offset_of_proxy_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089, ___proxy_1)); }
	inline StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * get_proxy_1() const { return ___proxy_1; }
	inline StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA ** get_address_of_proxy_1() { return &___proxy_1; }
	inline void set_proxy_1(StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * value)
	{
		___proxy_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___proxy_1), (void*)value);
	}
};


// UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass3_0
struct U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF  : public RuntimeObject
{
public:
	// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition> UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass3_0::localProductSet
	HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___localProductSet_0;
	// System.Action`1<System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>> UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass3_0::callback
	Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * ___callback_1;

public:
	inline static int32_t get_offset_of_localProductSet_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF, ___localProductSet_0)); }
	inline HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * get_localProductSet_0() const { return ___localProductSet_0; }
	inline HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 ** get_address_of_localProductSet_0() { return &___localProductSet_0; }
	inline void set_localProductSet_0(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * value)
	{
		___localProductSet_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___localProductSet_0), (void*)value);
	}

	inline static int32_t get_offset_of_callback_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF, ___callback_1)); }
	inline Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * get_callback_1() const { return ___callback_1; }
	inline Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 ** get_address_of_callback_1() { return &___callback_1; }
	inline void set_callback_1(Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * value)
	{
		___callback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callback_1), (void*)value);
	}
};


// System.Collections.Generic.HashSet`1/Enumerator<System.Object>
struct Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A 
{
public:
	// System.Collections.Generic.HashSet`1<T> System.Collections.Generic.HashSet`1/Enumerator::_set
	HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * ____set_0;
	// System.Int32 System.Collections.Generic.HashSet`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.HashSet`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.HashSet`1/Enumerator::_current
	RuntimeObject * ____current_3;

public:
	inline static int32_t get_offset_of__set_0() { return static_cast<int32_t>(offsetof(Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A, ____set_0)); }
	inline HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * get__set_0() const { return ____set_0; }
	inline HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B ** get_address_of__set_0() { return &____set_0; }
	inline void set__set_0(HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * value)
	{
		____set_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____set_0), (void*)value);
	}

	inline static int32_t get_offset_of__index_1() { return static_cast<int32_t>(offsetof(Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A, ____index_1)); }
	inline int32_t get__index_1() const { return ____index_1; }
	inline int32_t* get_address_of__index_1() { return &____index_1; }
	inline void set__index_1(int32_t value)
	{
		____index_1 = value;
	}

	inline static int32_t get_offset_of__version_2() { return static_cast<int32_t>(offsetof(Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A, ____version_2)); }
	inline int32_t get__version_2() const { return ____version_2; }
	inline int32_t* get_address_of__version_2() { return &____version_2; }
	inline void set__version_2(int32_t value)
	{
		____version_2 = value;
	}

	inline static int32_t get_offset_of__current_3() { return static_cast<int32_t>(offsetof(Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A, ____current_3)); }
	inline RuntimeObject * get__current_3() const { return ____current_3; }
	inline RuntimeObject ** get_address_of__current_3() { return &____current_3; }
	inline void set__current_3(RuntimeObject * value)
	{
		____current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____current_3), (void*)value);
	}
};


// System.Collections.Generic.List`1/Enumerator<System.Object>
struct Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	RuntimeObject * ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6, ___list_0)); }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * get_list_0() const { return ___list_0; }
	inline List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6, ___current_3)); }
	inline RuntimeObject * get_current_3() const { return ___current_3; }
	inline RuntimeObject ** get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(RuntimeObject * value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___current_3), (void*)value);
	}
};


// System.Collections.Generic.HashSet`1/Enumerator<UnityEngine.Purchasing.Product>
struct Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 
{
public:
	// System.Collections.Generic.HashSet`1<T> System.Collections.Generic.HashSet`1/Enumerator::_set
	HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * ____set_0;
	// System.Int32 System.Collections.Generic.HashSet`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.HashSet`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.HashSet`1/Enumerator::_current
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ____current_3;

public:
	inline static int32_t get_offset_of__set_0() { return static_cast<int32_t>(offsetof(Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809, ____set_0)); }
	inline HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * get__set_0() const { return ____set_0; }
	inline HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA ** get_address_of__set_0() { return &____set_0; }
	inline void set__set_0(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * value)
	{
		____set_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____set_0), (void*)value);
	}

	inline static int32_t get_offset_of__index_1() { return static_cast<int32_t>(offsetof(Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809, ____index_1)); }
	inline int32_t get__index_1() const { return ____index_1; }
	inline int32_t* get_address_of__index_1() { return &____index_1; }
	inline void set__index_1(int32_t value)
	{
		____index_1 = value;
	}

	inline static int32_t get_offset_of__version_2() { return static_cast<int32_t>(offsetof(Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809, ____version_2)); }
	inline int32_t get__version_2() const { return ____version_2; }
	inline int32_t* get_address_of__version_2() { return &____version_2; }
	inline void set__version_2(int32_t value)
	{
		____version_2 = value;
	}

	inline static int32_t get_offset_of__current_3() { return static_cast<int32_t>(offsetof(Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809, ____current_3)); }
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * get__current_3() const { return ____current_3; }
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E ** get_address_of__current_3() { return &____current_3; }
	inline void set__current_3(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * value)
	{
		____current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____current_3), (void*)value);
	}
};


// System.Collections.Generic.HashSet`1/Enumerator<UnityEngine.Purchasing.ProductDefinition>
struct Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C 
{
public:
	// System.Collections.Generic.HashSet`1<T> System.Collections.Generic.HashSet`1/Enumerator::_set
	HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ____set_0;
	// System.Int32 System.Collections.Generic.HashSet`1/Enumerator::_index
	int32_t ____index_1;
	// System.Int32 System.Collections.Generic.HashSet`1/Enumerator::_version
	int32_t ____version_2;
	// T System.Collections.Generic.HashSet`1/Enumerator::_current
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ____current_3;

public:
	inline static int32_t get_offset_of__set_0() { return static_cast<int32_t>(offsetof(Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C, ____set_0)); }
	inline HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * get__set_0() const { return ____set_0; }
	inline HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 ** get_address_of__set_0() { return &____set_0; }
	inline void set__set_0(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * value)
	{
		____set_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____set_0), (void*)value);
	}

	inline static int32_t get_offset_of__index_1() { return static_cast<int32_t>(offsetof(Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C, ____index_1)); }
	inline int32_t get__index_1() const { return ____index_1; }
	inline int32_t* get_address_of__index_1() { return &____index_1; }
	inline void set__index_1(int32_t value)
	{
		____index_1 = value;
	}

	inline static int32_t get_offset_of__version_2() { return static_cast<int32_t>(offsetof(Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C, ____version_2)); }
	inline int32_t get__version_2() const { return ____version_2; }
	inline int32_t* get_address_of__version_2() { return &____version_2; }
	inline void set__version_2(int32_t value)
	{
		____version_2 = value;
	}

	inline static int32_t get_offset_of__current_3() { return static_cast<int32_t>(offsetof(Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C, ____current_3)); }
	inline ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * get__current_3() const { return ____current_3; }
	inline ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 ** get_address_of__current_3() { return &____current_3; }
	inline void set__current_3(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * value)
	{
		____current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____current_3), (void*)value);
	}
};


// System.Collections.Generic.List`1/Enumerator<UnityEngine.Purchasing.Extension.ProductDescription>
struct Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84, ___list_0)); }
	inline List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF * get_list_0() const { return ___list_0; }
	inline List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84, ___current_3)); }
	inline ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * get_current_3() const { return ___current_3; }
	inline ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 ** get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___current_3), (void*)value);
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


// System.Collections.Generic.KeyValuePair`2<System.String,System.String>
struct KeyValuePair_2_tE863694F1DB1F441CAE5A282829BDB941B2DEEBC 
{
public:
	// TKey System.Collections.Generic.KeyValuePair`2::key
	String_t* ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	String_t* ___value_1;

public:
	inline static int32_t get_offset_of_key_0() { return static_cast<int32_t>(offsetof(KeyValuePair_2_tE863694F1DB1F441CAE5A282829BDB941B2DEEBC, ___key_0)); }
	inline String_t* get_key_0() const { return ___key_0; }
	inline String_t** get_address_of_key_0() { return &___key_0; }
	inline void set_key_0(String_t* value)
	{
		___key_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___key_0), (void*)value);
	}

	inline static int32_t get_offset_of_value_1() { return static_cast<int32_t>(offsetof(KeyValuePair_2_tE863694F1DB1F441CAE5A282829BDB941B2DEEBC, ___value_1)); }
	inline String_t* get_value_1() const { return ___value_1; }
	inline String_t** get_address_of_value_1() { return &___value_1; }
	inline void set_value_1(String_t* value)
	{
		___value_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___value_1), (void*)value);
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


// System.Collections.Generic.Dictionary`2/Enumerator<System.Object,System.Object>
struct Enumerator_tE4E91EE5578038530CF0C46227953BA787E7A0A0 
{
public:
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::dictionary
	Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * ___dictionary_0;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::version
	int32_t ___version_1;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::index
	int32_t ___index_2;
	// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::current
	KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625  ___current_3;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::getEnumeratorRetType
	int32_t ___getEnumeratorRetType_4;

public:
	inline static int32_t get_offset_of_dictionary_0() { return static_cast<int32_t>(offsetof(Enumerator_tE4E91EE5578038530CF0C46227953BA787E7A0A0, ___dictionary_0)); }
	inline Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * get_dictionary_0() const { return ___dictionary_0; }
	inline Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D ** get_address_of_dictionary_0() { return &___dictionary_0; }
	inline void set_dictionary_0(Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * value)
	{
		___dictionary_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dictionary_0), (void*)value);
	}

	inline static int32_t get_offset_of_version_1() { return static_cast<int32_t>(offsetof(Enumerator_tE4E91EE5578038530CF0C46227953BA787E7A0A0, ___version_1)); }
	inline int32_t get_version_1() const { return ___version_1; }
	inline int32_t* get_address_of_version_1() { return &___version_1; }
	inline void set_version_1(int32_t value)
	{
		___version_1 = value;
	}

	inline static int32_t get_offset_of_index_2() { return static_cast<int32_t>(offsetof(Enumerator_tE4E91EE5578038530CF0C46227953BA787E7A0A0, ___index_2)); }
	inline int32_t get_index_2() const { return ___index_2; }
	inline int32_t* get_address_of_index_2() { return &___index_2; }
	inline void set_index_2(int32_t value)
	{
		___index_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tE4E91EE5578038530CF0C46227953BA787E7A0A0, ___current_3)); }
	inline KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625  get_current_3() const { return ___current_3; }
	inline KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625 * get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(KeyValuePair_2_tFB6A066C69E28C6ACA5FC5E24D969BFADC5FA625  value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___key_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___value_1), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_getEnumeratorRetType_4() { return static_cast<int32_t>(offsetof(Enumerator_tE4E91EE5578038530CF0C46227953BA787E7A0A0, ___getEnumeratorRetType_4)); }
	inline int32_t get_getEnumeratorRetType_4() const { return ___getEnumeratorRetType_4; }
	inline int32_t* get_address_of_getEnumeratorRetType_4() { return &___getEnumeratorRetType_4; }
	inline void set_getEnumeratorRetType_4(int32_t value)
	{
		___getEnumeratorRetType_4 = value;
	}
};


// System.Collections.Generic.Dictionary`2/Enumerator<System.String,System.String>
struct Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB 
{
public:
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::dictionary
	Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * ___dictionary_0;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::version
	int32_t ___version_1;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::index
	int32_t ___index_2;
	// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2/Enumerator::current
	KeyValuePair_2_tE863694F1DB1F441CAE5A282829BDB941B2DEEBC  ___current_3;
	// System.Int32 System.Collections.Generic.Dictionary`2/Enumerator::getEnumeratorRetType
	int32_t ___getEnumeratorRetType_4;

public:
	inline static int32_t get_offset_of_dictionary_0() { return static_cast<int32_t>(offsetof(Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB, ___dictionary_0)); }
	inline Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * get_dictionary_0() const { return ___dictionary_0; }
	inline Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 ** get_address_of_dictionary_0() { return &___dictionary_0; }
	inline void set_dictionary_0(Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * value)
	{
		___dictionary_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___dictionary_0), (void*)value);
	}

	inline static int32_t get_offset_of_version_1() { return static_cast<int32_t>(offsetof(Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB, ___version_1)); }
	inline int32_t get_version_1() const { return ___version_1; }
	inline int32_t* get_address_of_version_1() { return &___version_1; }
	inline void set_version_1(int32_t value)
	{
		___version_1 = value;
	}

	inline static int32_t get_offset_of_index_2() { return static_cast<int32_t>(offsetof(Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB, ___index_2)); }
	inline int32_t get_index_2() const { return ___index_2; }
	inline int32_t* get_address_of_index_2() { return &___index_2; }
	inline void set_index_2(int32_t value)
	{
		___index_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB, ___current_3)); }
	inline KeyValuePair_2_tE863694F1DB1F441CAE5A282829BDB941B2DEEBC  get_current_3() const { return ___current_3; }
	inline KeyValuePair_2_tE863694F1DB1F441CAE5A282829BDB941B2DEEBC * get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(KeyValuePair_2_tE863694F1DB1F441CAE5A282829BDB941B2DEEBC  value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___key_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&(((&___current_3))->___value_1), (void*)NULL);
		#endif
	}

	inline static int32_t get_offset_of_getEnumeratorRetType_4() { return static_cast<int32_t>(offsetof(Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB, ___getEnumeratorRetType_4)); }
	inline int32_t get_getEnumeratorRetType_4() const { return ___getEnumeratorRetType_4; }
	inline int32_t* get_address_of_getEnumeratorRetType_4() { return &___getEnumeratorRetType_4; }
	inline void set_getEnumeratorRetType_4(int32_t value)
	{
		___getEnumeratorRetType_4 = value;
	}
};


// UnityEngine.Analytics.AnalyticsResult
struct AnalyticsResult_t354FBE9E2776B790EBAF24EBA60EE7AA64F1E1E0 
{
public:
	// System.Int32 UnityEngine.Analytics.AnalyticsResult::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AnalyticsResult_t354FBE9E2776B790EBAF24EBA60EE7AA64F1E1E0, ___value___2)); }
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

// System.IO.FileAttributes
struct FileAttributes_t47DBB9A73CF80C7CA21C9AAB8D5336C92D32C1AE 
{
public:
	// System.Int32 System.IO.FileAttributes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FileAttributes_t47DBB9A73CF80C7CA21C9AAB8D5336C92D32C1AE, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Purchasing.InitializationFailureReason
struct InitializationFailureReason_t63D9BE9105494C8AB7836A61F07115B84654837B 
{
public:
	// System.Int32 UnityEngine.Purchasing.InitializationFailureReason::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(InitializationFailureReason_t63D9BE9105494C8AB7836A61F07115B84654837B, ___value___2)); }
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


// UnityEngine.Purchasing.PayoutType
struct PayoutType_t3BDB7DF467106E1DB002687204312C9CEC25EAF0 
{
public:
	// System.Int32 UnityEngine.Purchasing.PayoutType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PayoutType_t3BDB7DF467106E1DB002687204312C9CEC25EAF0, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Purchasing.ProductMetadata
struct ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02  : public RuntimeObject
{
public:
	// System.String UnityEngine.Purchasing.ProductMetadata::<localizedPriceString>k__BackingField
	String_t* ___U3ClocalizedPriceStringU3Ek__BackingField_0;
	// System.String UnityEngine.Purchasing.ProductMetadata::<localizedTitle>k__BackingField
	String_t* ___U3ClocalizedTitleU3Ek__BackingField_1;
	// System.String UnityEngine.Purchasing.ProductMetadata::<localizedDescription>k__BackingField
	String_t* ___U3ClocalizedDescriptionU3Ek__BackingField_2;
	// System.String UnityEngine.Purchasing.ProductMetadata::<isoCurrencyCode>k__BackingField
	String_t* ___U3CisoCurrencyCodeU3Ek__BackingField_3;
	// System.Decimal UnityEngine.Purchasing.ProductMetadata::<localizedPrice>k__BackingField
	Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___U3ClocalizedPriceU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3ClocalizedPriceStringU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02, ___U3ClocalizedPriceStringU3Ek__BackingField_0)); }
	inline String_t* get_U3ClocalizedPriceStringU3Ek__BackingField_0() const { return ___U3ClocalizedPriceStringU3Ek__BackingField_0; }
	inline String_t** get_address_of_U3ClocalizedPriceStringU3Ek__BackingField_0() { return &___U3ClocalizedPriceStringU3Ek__BackingField_0; }
	inline void set_U3ClocalizedPriceStringU3Ek__BackingField_0(String_t* value)
	{
		___U3ClocalizedPriceStringU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3ClocalizedPriceStringU3Ek__BackingField_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3ClocalizedTitleU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02, ___U3ClocalizedTitleU3Ek__BackingField_1)); }
	inline String_t* get_U3ClocalizedTitleU3Ek__BackingField_1() const { return ___U3ClocalizedTitleU3Ek__BackingField_1; }
	inline String_t** get_address_of_U3ClocalizedTitleU3Ek__BackingField_1() { return &___U3ClocalizedTitleU3Ek__BackingField_1; }
	inline void set_U3ClocalizedTitleU3Ek__BackingField_1(String_t* value)
	{
		___U3ClocalizedTitleU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3ClocalizedTitleU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3ClocalizedDescriptionU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02, ___U3ClocalizedDescriptionU3Ek__BackingField_2)); }
	inline String_t* get_U3ClocalizedDescriptionU3Ek__BackingField_2() const { return ___U3ClocalizedDescriptionU3Ek__BackingField_2; }
	inline String_t** get_address_of_U3ClocalizedDescriptionU3Ek__BackingField_2() { return &___U3ClocalizedDescriptionU3Ek__BackingField_2; }
	inline void set_U3ClocalizedDescriptionU3Ek__BackingField_2(String_t* value)
	{
		___U3ClocalizedDescriptionU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3ClocalizedDescriptionU3Ek__BackingField_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CisoCurrencyCodeU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02, ___U3CisoCurrencyCodeU3Ek__BackingField_3)); }
	inline String_t* get_U3CisoCurrencyCodeU3Ek__BackingField_3() const { return ___U3CisoCurrencyCodeU3Ek__BackingField_3; }
	inline String_t** get_address_of_U3CisoCurrencyCodeU3Ek__BackingField_3() { return &___U3CisoCurrencyCodeU3Ek__BackingField_3; }
	inline void set_U3CisoCurrencyCodeU3Ek__BackingField_3(String_t* value)
	{
		___U3CisoCurrencyCodeU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CisoCurrencyCodeU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3ClocalizedPriceU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02, ___U3ClocalizedPriceU3Ek__BackingField_4)); }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  get_U3ClocalizedPriceU3Ek__BackingField_4() const { return ___U3ClocalizedPriceU3Ek__BackingField_4; }
	inline Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 * get_address_of_U3ClocalizedPriceU3Ek__BackingField_4() { return &___U3ClocalizedPriceU3Ek__BackingField_4; }
	inline void set_U3ClocalizedPriceU3Ek__BackingField_4(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  value)
	{
		___U3ClocalizedPriceU3Ek__BackingField_4 = value;
	}
};


// UnityEngine.Purchasing.ProductType
struct ProductType_tBF332314E0B8C2094184DDA4751FDB3518A79D5A 
{
public:
	// System.Int32 UnityEngine.Purchasing.ProductType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ProductType_tBF332314E0B8C2094184DDA4751FDB3518A79D5A, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Purchasing.PurchaseFailureReason
struct PurchaseFailureReason_t92D34AB6DC07828C5204898759640EDFB9336BA5 
{
public:
	// System.Int32 UnityEngine.Purchasing.PurchaseFailureReason::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PurchaseFailureReason_t92D34AB6DC07828C5204898759640EDFB9336BA5, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Purchasing.PurchaseProcessingResult
struct PurchaseProcessingResult_t7359C9B8C72BD6C2B38698E38AABD666E2DAE4CC 
{
public:
	// System.Int32 UnityEngine.Purchasing.PurchaseProcessingResult::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PurchaseProcessingResult_t7359C9B8C72BD6C2B38698E38AABD666E2DAE4CC, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.IO.MonoIOStat
struct MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71 
{
public:
	// System.IO.FileAttributes System.IO.MonoIOStat::fileAttributes
	int32_t ___fileAttributes_0;
	// System.Int64 System.IO.MonoIOStat::Length
	int64_t ___Length_1;
	// System.Int64 System.IO.MonoIOStat::CreationTime
	int64_t ___CreationTime_2;
	// System.Int64 System.IO.MonoIOStat::LastAccessTime
	int64_t ___LastAccessTime_3;
	// System.Int64 System.IO.MonoIOStat::LastWriteTime
	int64_t ___LastWriteTime_4;

public:
	inline static int32_t get_offset_of_fileAttributes_0() { return static_cast<int32_t>(offsetof(MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71, ___fileAttributes_0)); }
	inline int32_t get_fileAttributes_0() const { return ___fileAttributes_0; }
	inline int32_t* get_address_of_fileAttributes_0() { return &___fileAttributes_0; }
	inline void set_fileAttributes_0(int32_t value)
	{
		___fileAttributes_0 = value;
	}

	inline static int32_t get_offset_of_Length_1() { return static_cast<int32_t>(offsetof(MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71, ___Length_1)); }
	inline int64_t get_Length_1() const { return ___Length_1; }
	inline int64_t* get_address_of_Length_1() { return &___Length_1; }
	inline void set_Length_1(int64_t value)
	{
		___Length_1 = value;
	}

	inline static int32_t get_offset_of_CreationTime_2() { return static_cast<int32_t>(offsetof(MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71, ___CreationTime_2)); }
	inline int64_t get_CreationTime_2() const { return ___CreationTime_2; }
	inline int64_t* get_address_of_CreationTime_2() { return &___CreationTime_2; }
	inline void set_CreationTime_2(int64_t value)
	{
		___CreationTime_2 = value;
	}

	inline static int32_t get_offset_of_LastAccessTime_3() { return static_cast<int32_t>(offsetof(MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71, ___LastAccessTime_3)); }
	inline int64_t get_LastAccessTime_3() const { return ___LastAccessTime_3; }
	inline int64_t* get_address_of_LastAccessTime_3() { return &___LastAccessTime_3; }
	inline void set_LastAccessTime_3(int64_t value)
	{
		___LastAccessTime_3 = value;
	}

	inline static int32_t get_offset_of_LastWriteTime_4() { return static_cast<int32_t>(offsetof(MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71, ___LastWriteTime_4)); }
	inline int64_t get_LastWriteTime_4() const { return ___LastWriteTime_4; }
	inline int64_t* get_address_of_LastWriteTime_4() { return &___LastWriteTime_4; }
	inline void set_LastWriteTime_4(int64_t value)
	{
		___LastWriteTime_4 = value;
	}
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

// UnityEngine.Purchasing.PayoutDefinition
struct PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D  : public RuntimeObject
{
public:
	// UnityEngine.Purchasing.PayoutType UnityEngine.Purchasing.PayoutDefinition::m_Type
	int32_t ___m_Type_0;
	// System.String UnityEngine.Purchasing.PayoutDefinition::m_Subtype
	String_t* ___m_Subtype_1;
	// System.Double UnityEngine.Purchasing.PayoutDefinition::m_Quantity
	double ___m_Quantity_2;
	// System.String UnityEngine.Purchasing.PayoutDefinition::m_Data
	String_t* ___m_Data_3;

public:
	inline static int32_t get_offset_of_m_Type_0() { return static_cast<int32_t>(offsetof(PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D, ___m_Type_0)); }
	inline int32_t get_m_Type_0() const { return ___m_Type_0; }
	inline int32_t* get_address_of_m_Type_0() { return &___m_Type_0; }
	inline void set_m_Type_0(int32_t value)
	{
		___m_Type_0 = value;
	}

	inline static int32_t get_offset_of_m_Subtype_1() { return static_cast<int32_t>(offsetof(PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D, ___m_Subtype_1)); }
	inline String_t* get_m_Subtype_1() const { return ___m_Subtype_1; }
	inline String_t** get_address_of_m_Subtype_1() { return &___m_Subtype_1; }
	inline void set_m_Subtype_1(String_t* value)
	{
		___m_Subtype_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Subtype_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_Quantity_2() { return static_cast<int32_t>(offsetof(PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D, ___m_Quantity_2)); }
	inline double get_m_Quantity_2() const { return ___m_Quantity_2; }
	inline double* get_address_of_m_Quantity_2() { return &___m_Quantity_2; }
	inline void set_m_Quantity_2(double value)
	{
		___m_Quantity_2 = value;
	}

	inline static int32_t get_offset_of_m_Data_3() { return static_cast<int32_t>(offsetof(PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D, ___m_Data_3)); }
	inline String_t* get_m_Data_3() const { return ___m_Data_3; }
	inline String_t** get_address_of_m_Data_3() { return &___m_Data_3; }
	inline void set_m_Data_3(String_t* value)
	{
		___m_Data_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Data_3), (void*)value);
	}
};


// UnityEngine.Purchasing.ProductDefinition
struct ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572  : public RuntimeObject
{
public:
	// System.String UnityEngine.Purchasing.ProductDefinition::<id>k__BackingField
	String_t* ___U3CidU3Ek__BackingField_0;
	// System.String UnityEngine.Purchasing.ProductDefinition::<storeSpecificId>k__BackingField
	String_t* ___U3CstoreSpecificIdU3Ek__BackingField_1;
	// UnityEngine.Purchasing.ProductType UnityEngine.Purchasing.ProductDefinition::<type>k__BackingField
	int32_t ___U3CtypeU3Ek__BackingField_2;
	// System.Boolean UnityEngine.Purchasing.ProductDefinition::<enabled>k__BackingField
	bool ___U3CenabledU3Ek__BackingField_3;
	// System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition> UnityEngine.Purchasing.ProductDefinition::m_Payouts
	List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * ___m_Payouts_4;

public:
	inline static int32_t get_offset_of_U3CidU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572, ___U3CidU3Ek__BackingField_0)); }
	inline String_t* get_U3CidU3Ek__BackingField_0() const { return ___U3CidU3Ek__BackingField_0; }
	inline String_t** get_address_of_U3CidU3Ek__BackingField_0() { return &___U3CidU3Ek__BackingField_0; }
	inline void set_U3CidU3Ek__BackingField_0(String_t* value)
	{
		___U3CidU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CidU3Ek__BackingField_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CstoreSpecificIdU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572, ___U3CstoreSpecificIdU3Ek__BackingField_1)); }
	inline String_t* get_U3CstoreSpecificIdU3Ek__BackingField_1() const { return ___U3CstoreSpecificIdU3Ek__BackingField_1; }
	inline String_t** get_address_of_U3CstoreSpecificIdU3Ek__BackingField_1() { return &___U3CstoreSpecificIdU3Ek__BackingField_1; }
	inline void set_U3CstoreSpecificIdU3Ek__BackingField_1(String_t* value)
	{
		___U3CstoreSpecificIdU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CstoreSpecificIdU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CtypeU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572, ___U3CtypeU3Ek__BackingField_2)); }
	inline int32_t get_U3CtypeU3Ek__BackingField_2() const { return ___U3CtypeU3Ek__BackingField_2; }
	inline int32_t* get_address_of_U3CtypeU3Ek__BackingField_2() { return &___U3CtypeU3Ek__BackingField_2; }
	inline void set_U3CtypeU3Ek__BackingField_2(int32_t value)
	{
		___U3CtypeU3Ek__BackingField_2 = value;
	}

	inline static int32_t get_offset_of_U3CenabledU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572, ___U3CenabledU3Ek__BackingField_3)); }
	inline bool get_U3CenabledU3Ek__BackingField_3() const { return ___U3CenabledU3Ek__BackingField_3; }
	inline bool* get_address_of_U3CenabledU3Ek__BackingField_3() { return &___U3CenabledU3Ek__BackingField_3; }
	inline void set_U3CenabledU3Ek__BackingField_3(bool value)
	{
		___U3CenabledU3Ek__BackingField_3 = value;
	}

	inline static int32_t get_offset_of_m_Payouts_4() { return static_cast<int32_t>(offsetof(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572, ___m_Payouts_4)); }
	inline List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * get_m_Payouts_4() const { return ___m_Payouts_4; }
	inline List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 ** get_address_of_m_Payouts_4() { return &___m_Payouts_4; }
	inline void set_m_Payouts_4(List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * value)
	{
		___m_Payouts_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Payouts_4), (void*)value);
	}
};


// UnityEngine.Purchasing.Extension.ProductDescription
struct ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75  : public RuntimeObject
{
public:
	// System.String UnityEngine.Purchasing.Extension.ProductDescription::<storeSpecificId>k__BackingField
	String_t* ___U3CstoreSpecificIdU3Ek__BackingField_0;
	// UnityEngine.Purchasing.ProductType UnityEngine.Purchasing.Extension.ProductDescription::type
	int32_t ___type_1;
	// UnityEngine.Purchasing.ProductMetadata UnityEngine.Purchasing.Extension.ProductDescription::<metadata>k__BackingField
	ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___U3CmetadataU3Ek__BackingField_2;
	// System.String UnityEngine.Purchasing.Extension.ProductDescription::<receipt>k__BackingField
	String_t* ___U3CreceiptU3Ek__BackingField_3;
	// System.String UnityEngine.Purchasing.Extension.ProductDescription::<transactionId>k__BackingField
	String_t* ___U3CtransactionIdU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CstoreSpecificIdU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75, ___U3CstoreSpecificIdU3Ek__BackingField_0)); }
	inline String_t* get_U3CstoreSpecificIdU3Ek__BackingField_0() const { return ___U3CstoreSpecificIdU3Ek__BackingField_0; }
	inline String_t** get_address_of_U3CstoreSpecificIdU3Ek__BackingField_0() { return &___U3CstoreSpecificIdU3Ek__BackingField_0; }
	inline void set_U3CstoreSpecificIdU3Ek__BackingField_0(String_t* value)
	{
		___U3CstoreSpecificIdU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CstoreSpecificIdU3Ek__BackingField_0), (void*)value);
	}

	inline static int32_t get_offset_of_type_1() { return static_cast<int32_t>(offsetof(ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75, ___type_1)); }
	inline int32_t get_type_1() const { return ___type_1; }
	inline int32_t* get_address_of_type_1() { return &___type_1; }
	inline void set_type_1(int32_t value)
	{
		___type_1 = value;
	}

	inline static int32_t get_offset_of_U3CmetadataU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75, ___U3CmetadataU3Ek__BackingField_2)); }
	inline ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * get_U3CmetadataU3Ek__BackingField_2() const { return ___U3CmetadataU3Ek__BackingField_2; }
	inline ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 ** get_address_of_U3CmetadataU3Ek__BackingField_2() { return &___U3CmetadataU3Ek__BackingField_2; }
	inline void set_U3CmetadataU3Ek__BackingField_2(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * value)
	{
		___U3CmetadataU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CmetadataU3Ek__BackingField_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CreceiptU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75, ___U3CreceiptU3Ek__BackingField_3)); }
	inline String_t* get_U3CreceiptU3Ek__BackingField_3() const { return ___U3CreceiptU3Ek__BackingField_3; }
	inline String_t** get_address_of_U3CreceiptU3Ek__BackingField_3() { return &___U3CreceiptU3Ek__BackingField_3; }
	inline void set_U3CreceiptU3Ek__BackingField_3(String_t* value)
	{
		___U3CreceiptU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CreceiptU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CtransactionIdU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75, ___U3CtransactionIdU3Ek__BackingField_4)); }
	inline String_t* get_U3CtransactionIdU3Ek__BackingField_4() const { return ___U3CtransactionIdU3Ek__BackingField_4; }
	inline String_t** get_address_of_U3CtransactionIdU3Ek__BackingField_4() { return &___U3CtransactionIdU3Ek__BackingField_4; }
	inline void set_U3CtransactionIdU3Ek__BackingField_4(String_t* value)
	{
		___U3CtransactionIdU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CtransactionIdU3Ek__BackingField_4), (void*)value);
	}
};


// UnityEngine.Purchasing.Extension.PurchaseFailureDescription
struct PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8  : public RuntimeObject
{
public:
	// System.String UnityEngine.Purchasing.Extension.PurchaseFailureDescription::<productId>k__BackingField
	String_t* ___U3CproductIdU3Ek__BackingField_0;
	// UnityEngine.Purchasing.PurchaseFailureReason UnityEngine.Purchasing.Extension.PurchaseFailureDescription::<reason>k__BackingField
	int32_t ___U3CreasonU3Ek__BackingField_1;
	// System.String UnityEngine.Purchasing.Extension.PurchaseFailureDescription::<message>k__BackingField
	String_t* ___U3CmessageU3Ek__BackingField_2;

public:
	inline static int32_t get_offset_of_U3CproductIdU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8, ___U3CproductIdU3Ek__BackingField_0)); }
	inline String_t* get_U3CproductIdU3Ek__BackingField_0() const { return ___U3CproductIdU3Ek__BackingField_0; }
	inline String_t** get_address_of_U3CproductIdU3Ek__BackingField_0() { return &___U3CproductIdU3Ek__BackingField_0; }
	inline void set_U3CproductIdU3Ek__BackingField_0(String_t* value)
	{
		___U3CproductIdU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CproductIdU3Ek__BackingField_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CreasonU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8, ___U3CreasonU3Ek__BackingField_1)); }
	inline int32_t get_U3CreasonU3Ek__BackingField_1() const { return ___U3CreasonU3Ek__BackingField_1; }
	inline int32_t* get_address_of_U3CreasonU3Ek__BackingField_1() { return &___U3CreasonU3Ek__BackingField_1; }
	inline void set_U3CreasonU3Ek__BackingField_1(int32_t value)
	{
		___U3CreasonU3Ek__BackingField_1 = value;
	}

	inline static int32_t get_offset_of_U3CmessageU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8, ___U3CmessageU3Ek__BackingField_2)); }
	inline String_t* get_U3CmessageU3Ek__BackingField_2() const { return ___U3CmessageU3Ek__BackingField_2; }
	inline String_t** get_address_of_U3CmessageU3Ek__BackingField_2() { return &___U3CmessageU3Ek__BackingField_2; }
	inline void set_U3CmessageU3Ek__BackingField_2(String_t* value)
	{
		___U3CmessageU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CmessageU3Ek__BackingField_2), (void*)value);
	}
};


// System.SystemException
struct SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62  : public Exception_t
{
public:

public:
};


// System.Action`1<System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>>
struct Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999  : public MulticastDelegate_t
{
public:

public:
};


// System.Action`1<UnityEngine.Purchasing.InitializationFailureReason>
struct Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Purchasing.Product,System.Boolean>
struct Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Purchasing.Product,System.String>
struct Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product>
struct Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2  : public MulticastDelegate_t
{
public:

public:
};


// System.Action
struct Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6  : public MulticastDelegate_t
{
public:

public:
};


// System.IO.FileSystemInfo
struct FileSystemInfo_t4479D65BB34DEAFCDA2A98F8B797D7C19EFDA246  : public MarshalByRefObject_tD4DF91B488B284F899417EC468D8E50E933306A8
{
public:
	// System.IO.MonoIOStat System.IO.FileSystemInfo::_data
	MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71  ____data_1;
	// System.Int32 System.IO.FileSystemInfo::_dataInitialised
	int32_t ____dataInitialised_2;
	// System.String System.IO.FileSystemInfo::FullPath
	String_t* ___FullPath_5;
	// System.String System.IO.FileSystemInfo::OriginalPath
	String_t* ___OriginalPath_6;
	// System.String System.IO.FileSystemInfo::_displayPath
	String_t* ____displayPath_7;

public:
	inline static int32_t get_offset_of__data_1() { return static_cast<int32_t>(offsetof(FileSystemInfo_t4479D65BB34DEAFCDA2A98F8B797D7C19EFDA246, ____data_1)); }
	inline MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71  get__data_1() const { return ____data_1; }
	inline MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71 * get_address_of__data_1() { return &____data_1; }
	inline void set__data_1(MonoIOStat_t24C11A45B0B5F84242B31BA1EF48458595FF5F71  value)
	{
		____data_1 = value;
	}

	inline static int32_t get_offset_of__dataInitialised_2() { return static_cast<int32_t>(offsetof(FileSystemInfo_t4479D65BB34DEAFCDA2A98F8B797D7C19EFDA246, ____dataInitialised_2)); }
	inline int32_t get__dataInitialised_2() const { return ____dataInitialised_2; }
	inline int32_t* get_address_of__dataInitialised_2() { return &____dataInitialised_2; }
	inline void set__dataInitialised_2(int32_t value)
	{
		____dataInitialised_2 = value;
	}

	inline static int32_t get_offset_of_FullPath_5() { return static_cast<int32_t>(offsetof(FileSystemInfo_t4479D65BB34DEAFCDA2A98F8B797D7C19EFDA246, ___FullPath_5)); }
	inline String_t* get_FullPath_5() const { return ___FullPath_5; }
	inline String_t** get_address_of_FullPath_5() { return &___FullPath_5; }
	inline void set_FullPath_5(String_t* value)
	{
		___FullPath_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FullPath_5), (void*)value);
	}

	inline static int32_t get_offset_of_OriginalPath_6() { return static_cast<int32_t>(offsetof(FileSystemInfo_t4479D65BB34DEAFCDA2A98F8B797D7C19EFDA246, ___OriginalPath_6)); }
	inline String_t* get_OriginalPath_6() const { return ___OriginalPath_6; }
	inline String_t** get_address_of_OriginalPath_6() { return &___OriginalPath_6; }
	inline void set_OriginalPath_6(String_t* value)
	{
		___OriginalPath_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OriginalPath_6), (void*)value);
	}

	inline static int32_t get_offset_of__displayPath_7() { return static_cast<int32_t>(offsetof(FileSystemInfo_t4479D65BB34DEAFCDA2A98F8B797D7C19EFDA246, ____displayPath_7)); }
	inline String_t* get__displayPath_7() const { return ____displayPath_7; }
	inline String_t** get_address_of__displayPath_7() { return &____displayPath_7; }
	inline void set__displayPath_7(String_t* value)
	{
		____displayPath_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____displayPath_7), (void*)value);
	}
};


// System.InvalidOperationException
struct InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// System.IO.DirectoryInfo
struct DirectoryInfo_t4EF3610F45F0D234800D01ADA8F3F476AE0CF5CD  : public FileSystemInfo_t4479D65BB34DEAFCDA2A98F8B797D7C19EFDA246
{
public:
	// System.String System.IO.DirectoryInfo::current
	String_t* ___current_8;
	// System.String System.IO.DirectoryInfo::parent
	String_t* ___parent_9;

public:
	inline static int32_t get_offset_of_current_8() { return static_cast<int32_t>(offsetof(DirectoryInfo_t4EF3610F45F0D234800D01ADA8F3F476AE0CF5CD, ___current_8)); }
	inline String_t* get_current_8() const { return ___current_8; }
	inline String_t** get_address_of_current_8() { return &___current_8; }
	inline void set_current_8(String_t* value)
	{
		___current_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___current_8), (void*)value);
	}

	inline static int32_t get_offset_of_parent_9() { return static_cast<int32_t>(offsetof(DirectoryInfo_t4EF3610F45F0D234800D01ADA8F3F476AE0CF5CD, ___parent_9)); }
	inline String_t* get_parent_9() const { return ___parent_9; }
	inline String_t** get_address_of_parent_9() { return &___parent_9; }
	inline void set_parent_9(String_t* value)
	{
		___parent_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___parent_9), (void*)value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// UnityEngine.Purchasing.Extension.IPurchasingModule[]
struct IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

public:
	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Purchasing.Product[]
struct ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * m_Items[1];

public:
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
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


// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::Add(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_Add_m830DC29CD6F7128D4990D460CCCDE032E3B693D9_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HashSet_1__ctor_m2CDA40DEC2900A9CB00F8348FF386DF44ABD0EC7_gshared (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.HashSet`1<System.Object>::Add(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool HashSet_1_Add_mF670AD4C3F2685F0797E05C5491BC1841CEA9DBA_gshared (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// System.Collections.Generic.Dictionary`2/Enumerator<!0,!1> System.Collections.Generic.Dictionary`2<System.Object,System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_tE4E91EE5578038530CF0C46227953BA787E7A0A0  Dictionary_2_GetEnumerator_mA44BBB15DFBD8E08B5E60E23AA5044D45C3F889F_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Object>::ContainsKey(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_ContainsKey_m4F01DBE7409811CAB0BBA7AEFBAB4BC028D26FA6_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// !1 System.Collections.Generic.Dictionary`2<System.Object,System.Object>::get_Item(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Dictionary_2_get_Item_mB1398A10D048A0246178C59F95003BD338CE7394_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1<System.Object>::UnionWith(System.Collections.Generic.IEnumerable`1<!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HashSet_1_UnionWith_m5A9E0842B99BC83EC166ECCD45BD961D31480E53_gshared (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, RuntimeObject* ___other0, const RuntimeMethod* method);
// !!0[] System.Linq.Enumerable::ToArray<System.Object>(System.Collections.Generic.IEnumerable`1<!!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Enumerable_ToArray_TisRuntimeObject_m21E15191FE8BDBAE753CC592A1DB55EA3BCE7B5B_gshared (RuntimeObject* ___source0, const RuntimeMethod* method);
// System.Void System.Func`2<System.Object,System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_2__ctor_mA7F3C5A0612B84E910DE92E77BA95101FD68EEDB_gshared (Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Collections.Generic.Dictionary`2<!!1,!!0> System.Linq.Enumerable::ToDictionary<System.Object,System.Object>(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * Enumerable_ToDictionary_TisRuntimeObject_TisRuntimeObject_mA8D9C8974F5EBC5DA90B704687515C4ECBBD49F9_gshared (RuntimeObject* ___source0, Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * ___keySelector1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Object>::TryGetValue(!0,!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_m048C13E0F44BDC16F7CF01D14E918A84EE72C62C_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, RuntimeObject ** ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Clear()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_Clear_m5FB5A9C59D8625FDFB06876C4D8848F0F07ABFD0_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::AddRange(System.Collections.Generic.IEnumerable`1<!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_AddRange_m6465DEF706EB529B4227F2AF79338419D517EDF9_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject* ___collection0, const RuntimeMethod* method);
// System.Void System.Func`2<System.Object,System.Boolean>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_2__ctor_mCA84157864A199574AD0B7F3083F99B54DC1F98C_gshared (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// !!0 System.Linq.Enumerable::FirstOrDefault<System.Object>(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,System.Boolean>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Enumerable_FirstOrDefault_TisRuntimeObject_mEA8E5753D70A4AA5ABF983D5FE3BACC1537B3ECE_gshared (RuntimeObject* ___source0, Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * ___predicate1, const RuntimeMethod* method);
// System.Void System.Action`1<System.Int32Enum>::Invoke(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1_Invoke_m2652E72792A278523D6D8962CBBEA84177BB4556_gshared (Action_1_tF0FD284A49EB7135379250254D6B49FA84383C09 * __this, int32_t ___obj0, const RuntimeMethod* method);
// System.Collections.Generic.List`1/Enumerator<!0> System.Collections.Generic.List`1<System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  List_1_GetEnumerator_m1739A5E25DF502A6984F9B98CFCAC2D3FABCF233_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0_gshared (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1/Enumerator<System.Object>::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mCFB225D9E5E597A1CC8F958E53BEA1367D8AC7B8_gshared (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.HashSet`1<System.Object>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t HashSet_1_get_Count_m41C20B7D2DB4661F5C68E9BA25E4B83FC6914CD8_gshared_inline (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, const RuntimeMethod* method);
// System.Collections.Generic.HashSet`1/Enumerator<!0> System.Collections.Generic.HashSet`1<System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A  HashSet_1_GetEnumerator_m7B591DC586DE6ACF8918E1BC71FA731FB919603E_gshared (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.HashSet`1/Enumerator<System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_mC55AF9E2F45639649E40AF5919D6169FD9543E01_gshared_inline (Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.HashSet`1/Enumerator<System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_mD87CDEF3F60C047F21B9E6A48590E59D9D6621C9_gshared (Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1/Enumerator<System.Object>::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_m8A225BA705CC2D5BA0A22FF58381EA1FDB37ED20_gshared (Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A * __this, const RuntimeMethod* method);
// System.Collections.Generic.IEnumerable`1<!!1> System.Linq.Enumerable::Select<System.Object,System.Object>(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Enumerable_Select_TisRuntimeObject_TisRuntimeObject_mC0F1DA980E0433D70A6CF9DD7CD1942BB7FE87C0_gshared (RuntimeObject* ___source0, Func_2_tFF5BB8F40A35B1BEA00D4EBBC6CBE7184A584436 * ___selector1, const RuntimeMethod* method);
// System.Collections.Generic.List`1<!!0> System.Linq.Enumerable::ToList<System.Object>(System.Collections.Generic.IEnumerable`1<!!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * Enumerable_ToList_TisRuntimeObject_mA4E485F973C6DF746B8DB54CA6F54192D4231CA2_gshared (RuntimeObject* ___source0, const RuntimeMethod* method);
// System.Void System.Collections.ObjectModel.ReadOnlyCollection`1<System.Object>::.ctor(System.Collections.Generic.IList`1<!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ReadOnlyCollection_1__ctor_mED7425C8A39DDAE57BB831E4903F987E9D033BF2_gshared (ReadOnlyCollection_1_t921D1901AD35062BE31FAEB0798A4B814F33A3C3 * __this, RuntimeObject* ___list0, const RuntimeMethod* method);
// System.Void System.Action`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1__ctor_mA671E933C9D3DAE4E3F71D34FDDA971739618158_gshared (Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Void System.Action`1<System.Object>::Invoke(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1_Invoke_m587509C88BB83721D7918D89DF07606BB752D744_gshared (Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * __this, RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1<System.Object>::.ctor(System.Collections.Generic.IEnumerable`1<!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HashSet_1__ctor_m9D936778F28043838186FC2037F47460DA7925B9_gshared (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, RuntimeObject* ___collection0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.HashSet`1<System.Object>::Remove(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool HashSet_1_Remove_m05A1DBBB51DD02B44F81FDB9ECDDED8304381F1D_gshared (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, RuntimeObject * ___item0, const RuntimeMethod* method);

// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.ProductMetadata UnityEngine.Purchasing.Product::get_metadata()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.ProductMetadata::get_isoCurrencyCode()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductMetadata_get_isoCurrencyCode_mF120AB3BE16D7412714ADCB4A3A309994AD14448_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.ProductDefinition UnityEngine.Purchasing.Product::get_definition()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.ProductDefinition::get_storeSpecificId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method);
// System.Decimal UnityEngine.Purchasing.ProductMetadata::get_localizedPrice()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ProductMetadata_get_localizedPrice_mCD6B8DDFB4A322CD82A44ECFB0D098F195493F9D_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Product::get_receipt()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* Product_get_receipt_mEB9707DA0BF7F2D19DF9A0B2512B416FF89CB8C7_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Object>::.ctor()
inline void Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63 (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, const RuntimeMethod*))Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Object>::Add(!0,!1)
inline void Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, String_t* ___key0, RuntimeObject * ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, String_t*, RuntimeObject *, const RuntimeMethod*))Dictionary_2_Add_m830DC29CD6F7128D4990D460CCCDE032E3B693D9_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>::.ctor()
inline void HashSet_1__ctor_mDB79646D0C35A9CDC3F655F883F35AD083912302 (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * __this, const RuntimeMethod* method)
{
	((  void (*) (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 *, const RuntimeMethod*))HashSet_1__ctor_m2CDA40DEC2900A9CB00F8348FF386DF44ABD0EC7_gshared)(__this, method);
}
// System.Void UnityEngine.Purchasing.PurchasingFactory::.ctor(UnityEngine.Purchasing.Extension.IPurchasingModule,UnityEngine.Purchasing.Extension.IPurchasingModule[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingFactory__ctor_mE6065911A080C31F248EA2A3871EC24EF7BB71E5 (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, RuntimeObject* ___first0, IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2* ___remainingModules1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ConfigurationBuilder::.ctor(UnityEngine.Purchasing.PurchasingFactory)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigurationBuilder__ctor_m6D44A4228C6D3B5F37B78623D5768584FC3C5F58 (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * ___factory0, const RuntimeMethod* method);
// UnityEngine.Purchasing.ConfigurationBuilder UnityEngine.Purchasing.ConfigurationBuilder::AddProduct(System.String,UnityEngine.Purchasing.ProductType,UnityEngine.Purchasing.IDs)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ConfigurationBuilder_AddProduct_m6F291A7C3BB7C97C87DDCD4DF9B44C42C0FD13EA (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, String_t* ___id0, int32_t ___type1, IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * ___storeIDs2, const RuntimeMethod* method);
// UnityEngine.Purchasing.ConfigurationBuilder UnityEngine.Purchasing.ConfigurationBuilder::AddProduct(System.String,UnityEngine.Purchasing.ProductType,UnityEngine.Purchasing.IDs,System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.PayoutDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ConfigurationBuilder_AddProduct_mE4D41230A1FBEC3B58B9E44EAE220DDE6A4665F8 (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, String_t* ___id0, int32_t ___type1, IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * ___storeIDs2, RuntimeObject* ___payouts3, const RuntimeMethod* method);
// UnityEngine.Purchasing.PurchasingFactory UnityEngine.Purchasing.ConfigurationBuilder::get_factory()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * ConfigurationBuilder_get_factory_mC832B7559209EE727A013F929285DFF1E0D0CCA0_inline (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.PurchasingFactory::get_storeName()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* PurchasingFactory_get_storeName_mFFC419BA561609F0C7FFA02C3C7FC5DCD0E51453_inline (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.IDs::SpecificIDForStore(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* IDs_SpecificIDForStore_m4F11D33B86D4AFD9E041BB232A9ECDBD544587DE (IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * __this, String_t* ___store0, String_t* ___defaultValue1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductDefinition::.ctor(System.String,System.String,UnityEngine.Purchasing.ProductType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition__ctor_mE256AE9F056EA9E401D0CB8DD80C3C2071827FA1 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___id0, String_t* ___storeSpecificId1, int32_t ___type2, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductDefinition::SetPayouts(System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.PayoutDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition_SetPayouts_mA6122814E042438C08B1B90A57DE9D77865E617C (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, RuntimeObject* ___newPayouts0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>::Add(!0)
inline bool HashSet_1_Add_mE4FBC8CF189E84F0C496E46A3AB981EEBDE8BF4D (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 *, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *, const RuntimeMethod*))HashSet_1_Add_mF670AD4C3F2685F0797E05C5491BC1841CEA9DBA_gshared)(__this, ___item0, method);
}
// System.Collections.Generic.Dictionary`2/Enumerator<!0,!1> System.Collections.Generic.Dictionary`2<System.String,System.String>::GetEnumerator()
inline Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB  Dictionary_2_GetEnumerator_m8C0A038B5FA7E62DEF4DB9EF1F5FCC4348D785C5 (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * __this, const RuntimeMethod* method)
{
	return ((  Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB  (*) (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *, const RuntimeMethod*))Dictionary_2_GetEnumerator_mA44BBB15DFBD8E08B5E60E23AA5044D45C3F889F_gshared)(__this, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,System.String>::ContainsKey(!0)
inline bool Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027 (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *, String_t*, const RuntimeMethod*))Dictionary_2_ContainsKey_m4F01DBE7409811CAB0BBA7AEFBAB4BC028D26FA6_gshared)(__this, ___key0, method);
}
// !1 System.Collections.Generic.Dictionary`2<System.String,System.String>::get_Item(!0)
inline String_t* Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141 (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  String_t* (*) (Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 *, String_t*, const RuntimeMethod*))Dictionary_2_get_Item_mB1398A10D048A0246178C59F95003BD338CE7394_gshared)(__this, ___key0, method);
}
// System.Void UnityEngine.Purchasing.Product::set_definition(UnityEngine.Purchasing.ProductDefinition)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_definition_m17632BA5F56BA30A07498B0EB5C0D1D7142D521F_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Product::set_metadata(UnityEngine.Purchasing.ProductMetadata)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_metadata_m47CFE30071CD7DFC334749332B8C7869D08C18A4_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Product::set_receipt(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Product::.ctor(UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.ProductMetadata,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product__ctor_m943599E6C855DEA54B258C54DC8A29A3667814EE (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___definition0, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___metadata1, String_t* ___receipt2, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product>::.ctor()
inline void HashSet_1__ctor_mF1247FA13C1F59B28E7048BFABB8E206D160FD64 (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * __this, const RuntimeMethod* method)
{
	((  void (*) (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA *, const RuntimeMethod*))HashSet_1__ctor_m2CDA40DEC2900A9CB00F8348FF386DF44ABD0EC7_gshared)(__this, method);
}
// System.Void UnityEngine.Purchasing.ProductCollection::AddProducts(System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.Product>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductCollection_AddProducts_m0BB3F5D30E6255BF2CC046EDE294CC19C7ADD1D0 (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, RuntimeObject* ___products0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product>::UnionWith(System.Collections.Generic.IEnumerable`1<!0>)
inline void HashSet_1_UnionWith_mA88C2E1D44F2F4FCC1E7C24880A99405A87B2E09 (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * __this, RuntimeObject* ___other0, const RuntimeMethod* method)
{
	((  void (*) (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA *, RuntimeObject*, const RuntimeMethod*))HashSet_1_UnionWith_m5A9E0842B99BC83EC166ECCD45BD961D31480E53_gshared)(__this, ___other0, method);
}
// !!0[] System.Linq.Enumerable::ToArray<UnityEngine.Purchasing.Product>(System.Collections.Generic.IEnumerable`1<!!0>)
inline ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* Enumerable_ToArray_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mEE2FE11BDD311009011FF50D0BACC5AA3C07BE1C (RuntimeObject* ___source0, const RuntimeMethod* method)
{
	return ((  ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* (*) (RuntimeObject*, const RuntimeMethod*))Enumerable_ToArray_TisRuntimeObject_m21E15191FE8BDBAE753CC592A1DB55EA3BCE7B5B_gshared)(___source0, method);
}
// System.Void System.Func`2<UnityEngine.Purchasing.Product,System.String>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_m5BA6ACDCD9B26E626B98532D5D60DB79C93CCF44 (Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 *, RuntimeObject *, intptr_t, const RuntimeMethod*))Func_2__ctor_mA7F3C5A0612B84E910DE92E77BA95101FD68EEDB_gshared)(__this, ___object0, ___method1, method);
}
// System.Collections.Generic.Dictionary`2<!!1,!!0> System.Linq.Enumerable::ToDictionary<UnityEngine.Purchasing.Product,System.String>(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>)
inline Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * Enumerable_ToDictionary_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_TisString_t_mCE58036003050068B397D143069CEB9FFDDDC0BC (RuntimeObject* ___source0, Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * ___keySelector1, const RuntimeMethod* method)
{
	return ((  Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * (*) (RuntimeObject*, Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 *, const RuntimeMethod*))Enumerable_ToDictionary_TisRuntimeObject_TisRuntimeObject_mA8D9C8974F5EBC5DA90B704687515C4ECBBD49F9_gshared)(___source0, ___keySelector1, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Purchasing.Product>::TryGetValue(!0,!1&)
inline bool Dictionary_2_TryGetValue_m818108628C884130D20F1CE7A3DD2D0BEDA54240 (Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * __this, String_t* ___key0, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E ** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 *, String_t*, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E **, const RuntimeMethod*))Dictionary_2_TryGetValue_m048C13E0F44BDC16F7CF01D14E918A84EE72C62C_gshared)(__this, ___key0, ___value1, method);
}
// System.Void UnityEngine.Purchasing.ProductDefinition::.ctor(System.String,System.String,UnityEngine.Purchasing.ProductType,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition__ctor_mECD431B115EECDAC521F7ACA816EF778C17BC270 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___id0, String_t* ___storeSpecificId1, int32_t ___type2, bool ___enabled3, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductDefinition::.ctor(System.String,System.String,UnityEngine.Purchasing.ProductType,System.Boolean,System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.PayoutDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition__ctor_mD15BEC65454666E9349D84A1E3D59F4EFBD82713 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___id0, String_t* ___storeSpecificId1, int32_t ___type2, bool ___enabled3, RuntimeObject* ___payouts4, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition>::.ctor()
inline void List_1__ctor_m0066DC5C7B9DADA1721568BFC63754E8159B10AC (List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// System.Void UnityEngine.Purchasing.ProductDefinition::set_id(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDefinition_set_id_m51E9751372680165426BF38F704AF156EDC8F409_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductDefinition::set_storeSpecificId(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDefinition_set_storeSpecificId_m8B517A5FFCCDE7F6D966D01755E6ED85D7E08383_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductDefinition::set_type(UnityEngine.Purchasing.ProductType)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDefinition_set_type_mD99FAB9E2A75B43223D3FC6CD94D2227F08685B7_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductDefinition::set_enabled(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDefinition_set_enabled_m9D94A78B81CE41EAAC26428D76679DC52BC8D638_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, bool ___value0, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.ProductDefinition::get_id()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method);
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition>::Clear()
inline void List_1_Clear_m16E9797AAF502957D595712D9415EE8EC92BC001 (List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 *, const RuntimeMethod*))List_1_Clear_m5FB5A9C59D8625FDFB06876C4D8848F0F07ABFD0_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition>::AddRange(System.Collections.Generic.IEnumerable`1<!0>)
inline void List_1_AddRange_m5C4A175E221847296EA6BA421CB11FC15629780E (List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * __this, RuntimeObject* ___collection0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 *, RuntimeObject*, const RuntimeMethod*))List_1_AddRange_m6465DEF706EB529B4227F2AF79338419D517EDF9_gshared)(__this, ___collection0, method);
}
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::set_storeSpecificId(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDescription_set_storeSpecificId_mA913B1D4F5C2DB7009A530F0B3550EF57F20FD44_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::set_metadata(UnityEngine.Purchasing.ProductMetadata)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDescription_set_metadata_mDD9C2B807FD047A7C91EDA3996931E5D9E886703_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::set_receipt(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDescription_set_receipt_m68F0A2BE12715CD2FFD606E6455796D4EA254101_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::set_transactionId(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDescription_set_transactionId_m5C0C2615AAB10FD93A69683CDEDC072F44CCA752_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::.ctor(System.String,UnityEngine.Purchasing.ProductMetadata,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDescription__ctor_m5A36ABE65E02274EC3E63E2252FB7B43852A4D8D (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___id0, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___metadata1, String_t* ___receipt2, String_t* ___transactionId3, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductMetadata::set_localizedPriceString(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedPriceString_m3114E4D67F5A17BC187DBB9D3A067C0569A69702_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductMetadata::set_localizedTitle(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedTitle_mA0D1F59CA6B369ED045226948723B583CD49E78A_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductMetadata::set_localizedDescription(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedDescription_m1B74BFD9B930EF7A3174C3C8738EE404D1399152_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductMetadata::set_isoCurrencyCode(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_isoCurrencyCode_m4E5A20FB8601E9A651FBA18BBB5F5ACD426DA768_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductMetadata::set_localizedPrice(System.Decimal)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedPrice_mF41BFD302AE1C9F21AEBD893D4337C362C50DB88_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___value0, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.UnifiedReceiptFormatter::FormatUnifiedReceipt(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnifiedReceiptFormatter_FormatUnifiedReceipt_mD91359B583BEB06ACD63EE20F0B1F6495B266AE9 (String_t* ___platformReceipt0, String_t* ___transactionId1, String_t* ___storeName2, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Product::set_transactionID(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchaseEventArgs::set_purchasedProduct(UnityEngine.Purchasing.Product)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchaseEventArgs_set_purchasedProduct_mDBEFD23C5488F6EC6F2EE719925D31A090AC35CC_inline (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Extension.PurchaseFailureDescription::set_productId(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_productId_mE295E5962FBA98CCB477B4B0572CC6FC3A766B6D_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Extension.PurchaseFailureDescription::set_reason(UnityEngine.Purchasing.PurchaseFailureReason)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_reason_mDEA2EF43F275FBDED54C8727D03F749E898E22FE_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Extension.PurchaseFailureDescription::set_message(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_message_mD2A75514074F67A7CEC79A18D061F444F5BCCAC1_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration>::.ctor()
inline void Dictionary_2__ctor_m44704C7AAA86E3266061F028FC3FC6F45F36D029 (Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51 *, const RuntimeMethod*))Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.IStoreExtension>::.ctor()
inline void Dictionary_2__ctor_m17F438F4F280FA74C072C108A91953A0D3D08927 (Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004 *, const RuntimeMethod*))Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared)(__this, method);
}
// System.Void System.InvalidOperationException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingFactory::set_storeName(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchasingFactory_set_storeName_mF4007CD7F5CD1373507429D6E6BA9D5A4800AC7D_inline (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingFactory::set_service(UnityEngine.Purchasing.Extension.IStore)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchasingFactory_set_service_mD6B699C7477F20875DE50767AB1CE363CB17DA44_inline (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, RuntimeObject* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::set_useTransactionLog(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchasingManager_set_useTransactionLog_mB13861C43C5625F0F4EA38327A6056EE9EF273DA_inline (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, bool ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::InitiatePurchase(UnityEngine.Purchasing.Product,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_InitiatePurchase_m312855678BFC254CA30B5E9530207B896923F85C (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, String_t* ___developerPayload1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Purchasing.Product::get_availableToPurchase()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Product_get_availableToPurchase_mBAB83F4E1E276628EA5948A67C2F79F31A003CBF_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Product::get_transactionID()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method);
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C (String_t* ___value0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Purchasing.PurchasingManager::get_useTransactionLog()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool PurchasingManager_get_useTransactionLog_mB8E7472617FCBD4BA5C910F4D5D5FFB6A0A6BADF_inline (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.TransactionLog::Record(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransactionLog_Record_m7CDAC959A14AD174B4C33255F2BA013349883895 (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * __this, String_t* ___transactionID0, const RuntimeMethod* method);
// UnityEngine.Purchasing.ProductCollection UnityEngine.Purchasing.PurchasingManager::get_products()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.Product UnityEngine.Purchasing.ProductCollection::WithStoreSpecificID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ProductCollection_WithStoreSpecificID_m6F49CE43D79C4DD72570EFFF2603BA6AFA97A0D4 (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, String_t* ___id0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductDefinition::.ctor(System.String,UnityEngine.Purchasing.ProductType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition__ctor_mE91946E2215B8A4D2045682518527F9C4721BFDD (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___id0, int32_t ___type1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.ProductMetadata::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductMetadata__ctor_m7561EFECB866511CAE76597E34C9DFD34E0D3171 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Product::.ctor(UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.ProductMetadata)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product__ctor_m6417672E9F6ED21F6A9D5DA018EEA866AF8CFC9C (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___definition0, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___metadata1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::UpdateProductReceiptAndTrandsactionID(UnityEngine.Purchasing.Product,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_UpdateProductReceiptAndTrandsactionID_m9D5BA8C8A65FD50C69D523733B98008C94579146 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, String_t* ___receipt1, String_t* ___transactionId2, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::ProcessPurchaseIfNew(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_ProcessPurchaseIfNew_mCDE6D69367D34F7E7E20A1B4A5E5301DEB309B81 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.PurchasingManager::CreateUnifiedReceipt(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PurchasingManager_CreateUnifiedReceipt_mA5F66EA027EE9D8E96A13F096CEA3D4958FC8EC3 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, String_t* ___rawReceipt0, String_t* ___transactionId1, const RuntimeMethod* method);
// UnityEngine.Purchasing.Product[] UnityEngine.Purchasing.ProductCollection::get_all()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* ProductCollection_get_all_m8F08A78D6AF774BE9A1A0C14E69747293EDC6E11_inline (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager/<>c__DisplayClass23_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass23_0__ctor_mACE5AC91204E137680F657F55F9278C899497A74 (U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * __this, const RuntimeMethod* method);
// System.Void System.Func`2<UnityEngine.Purchasing.Product,System.Boolean>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_m509007DD57F653BAA3882037AB268CA3D7C5E053 (Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06 *, RuntimeObject *, intptr_t, const RuntimeMethod*))Func_2__ctor_mCA84157864A199574AD0B7F3083F99B54DC1F98C_gshared)(__this, ___object0, ___method1, method);
}
// !!0 System.Linq.Enumerable::FirstOrDefault<UnityEngine.Purchasing.Product>(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,System.Boolean>)
inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * Enumerable_FirstOrDefault_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_m3C9959CA12D5CE0709E77E76A00693D62C76735F (RuntimeObject* ___source0, Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06 * ___predicate1, const RuntimeMethod* method)
{
	return ((  Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * (*) (RuntimeObject*, Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06 *, const RuntimeMethod*))Enumerable_FirstOrDefault_TisRuntimeObject_mEA8E5753D70A4AA5ABF983D5FE3BACC1537B3ECE_gshared)(___source0, ___predicate1, method);
}
// System.Void UnityEngine.Purchasing.PurchasingManager::HandlePurchaseRetrieved(UnityEngine.Purchasing.Product,UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_HandlePurchaseRetrieved_mD9555DFEE135F475A3377676A934484121FA7E88 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___purchasedProduct1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::ClearProductReceipt(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_ClearProductReceipt_m447D36D66C149C4A1944981005F1344E7D6AEFA9 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method);
// System.Void System.Action`1<UnityEngine.Purchasing.InitializationFailureReason>::Invoke(!0)
inline void Action_1_Invoke_mD253810DCE8FE22D2D7CA13562023DD0CFA960AC (Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983 * __this, int32_t ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983 *, int32_t, const RuntimeMethod*))Action_1_Invoke_m2652E72792A278523D6D8962CBBEA84177BB4556_gshared)(__this, ___obj0, method);
}
// System.String UnityEngine.Purchasing.Extension.PurchaseFailureDescription::get_productId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* PurchaseFailureDescription_get_productId_mDAE0C9E1F3A0144CF7A6728EDAC287009F483057_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.PurchaseFailureReason UnityEngine.Purchasing.Extension.PurchaseFailureDescription::get_reason()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t PurchaseFailureDescription_get_reason_m0EF61510E8851D12EA86FF0376DC4B99A7415E0F_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Extension.PurchaseFailureDescription::get_message()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* PurchaseFailureDescription_get_message_mF5E354CE7F8BAEF0BE525EC30608A54F4607E504_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9 (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___values0, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78 (String_t* ___str00, String_t* ___str11, String_t* ___str22, String_t* ___str33, const RuntimeMethod* method);
// System.Collections.Generic.List`1/Enumerator<!0> System.Collections.Generic.List`1<UnityEngine.Purchasing.Extension.ProductDescription>::GetEnumerator()
inline Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84  List_1_GetEnumerator_m9C1505A33FD0156C5CDED2CA7BAEB3BF1DE4E1FB (List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF * __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84  (*) (List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF *, const RuntimeMethod*))List_1_GetEnumerator_m1739A5E25DF502A6984F9B98CFCAC2D3FABCF233_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<UnityEngine.Purchasing.Extension.ProductDescription>::get_Current()
inline ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * Enumerator_get_Current_m0E0A041FD0428646F68B50259291381BEF627BFB_inline (Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 * __this, const RuntimeMethod* method)
{
	return ((  ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * (*) (Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 *, const RuntimeMethod*))Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline)(__this, method);
}
// System.String UnityEngine.Purchasing.Extension.ProductDescription::get_storeSpecificId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDescription_get_storeSpecificId_m805EE28C57C25664093C7F5C2FB24EAADFEAFB09_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.ProductMetadata UnityEngine.Purchasing.Extension.ProductDescription::get_metadata()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ProductDescription_get_metadata_m3638B035BE86738C71F776D7313827080557986B_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product>::Add(!0)
inline bool HashSet_1_Add_m7D4C2485E000A367089991F01E0724430347AF82 (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA *, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *, const RuntimeMethod*))HashSet_1_Add_mF670AD4C3F2685F0797E05C5491BC1841CEA9DBA_gshared)(__this, ___item0, method);
}
// System.Void UnityEngine.Purchasing.Product::set_availableToPurchase(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_availableToPurchase_m7C4954A4C675BE7DBC041D8928D4E66AEBBBE28C_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, bool ___value0, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Extension.ProductDescription::get_transactionId()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDescription_get_transactionId_m88319BAE8BD3CC3E1D65E19370EE3EB9379BE93F_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Extension.ProductDescription::get_receipt()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDescription_get_receipt_m0D6C6B53F56F62B89399A156E392AF9AE1D53CC7_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<UnityEngine.Purchasing.Extension.ProductDescription>::MoveNext()
inline bool Enumerator_MoveNext_mEE376D71AB426CB6748F702E512B357FB483F455 (Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 *, const RuntimeMethod*))Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1/Enumerator<UnityEngine.Purchasing.Extension.ProductDescription>::Dispose()
inline void Enumerator_Dispose_mF00BC099D6D9E176778EC76B9CBF3F521AE31E9B (Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 * __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 *, const RuntimeMethod*))Enumerator_Dispose_mCFB225D9E5E597A1CC8F958E53BEA1367D8AC7B8_gshared)(__this, method);
}
// System.Int32 System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product>::get_Count()
inline int32_t HashSet_1_get_Count_m6E973EE5C7480789B23EA6F34AEDE890E1AD0245_inline (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA *, const RuntimeMethod*))HashSet_1_get_Count_m41C20B7D2DB4661F5C68E9BA25E4B83FC6914CD8_gshared_inline)(__this, method);
}
// System.Void UnityEngine.Purchasing.PurchasingManager::CheckForInitialization()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_CheckForInitialization_m831821ACF5867F2979E82A51CD61BD08008E54BB (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::ProcessPurchaseOnStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_ProcessPurchaseOnStart_mEB48CC9B7C636C6B3AE2CD75ED72247861863AF8 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method);
// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product> UnityEngine.Purchasing.ProductCollection::get_set()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * ProductCollection_get_set_m59FB3EC03DCFA60FD4F6685381F2E1CF47358725_inline (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, const RuntimeMethod* method);
// System.Collections.Generic.HashSet`1/Enumerator<!0> System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product>::GetEnumerator()
inline Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809  HashSet_1_GetEnumerator_mEA35B35D1D04D4D0640DEC29AFA49D6AA004E2F7 (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * __this, const RuntimeMethod* method)
{
	return ((  Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809  (*) (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA *, const RuntimeMethod*))HashSet_1_GetEnumerator_m7B591DC586DE6ACF8918E1BC71FA731FB919603E_gshared)(__this, method);
}
// !0 System.Collections.Generic.HashSet`1/Enumerator<UnityEngine.Purchasing.Product>::get_Current()
inline Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * Enumerator_get_Current_m89F845C0B1EA66200DEA88D2FC1CEDB159B0489B_inline (Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 * __this, const RuntimeMethod* method)
{
	return ((  Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * (*) (Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *, const RuntimeMethod*))Enumerator_get_Current_mC55AF9E2F45639649E40AF5919D6169FD9543E01_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.HashSet`1/Enumerator<UnityEngine.Purchasing.Product>::MoveNext()
inline bool Enumerator_MoveNext_m34DE56BFFB93F822D883D63793D4F6EAF4746808 (Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *, const RuntimeMethod*))Enumerator_MoveNext_mD87CDEF3F60C047F21B9E6A48590E59D9D6621C9_gshared)(__this, method);
}
// System.Void System.Collections.Generic.HashSet`1/Enumerator<UnityEngine.Purchasing.Product>::Dispose()
inline void Enumerator_Dispose_mECB624E9227DAD90587C5FB7547E0ABAC77E23A4 (Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 * __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *, const RuntimeMethod*))Enumerator_Dispose_m8A225BA705CC2D5BA0A22FF58381EA1FDB37ED20_gshared)(__this, method);
}
// System.Boolean UnityEngine.Purchasing.TransactionLog::HasRecordOf(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransactionLog_HasRecordOf_m7086CC4A600D584BE9954FB9684A1E80FDD5F02B (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * __this, String_t* ___transactionID0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchaseEventArgs::.ctor(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchaseEventArgs__ctor_m8B7ED6ABBC91A602EBD4B4442173C29D372AF4D1 (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___purchasedProduct0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::ConfirmPendingPurchase(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_ConfirmPendingPurchase_m891FE9D820139B48C2C469CB12D103664E45ED43 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Purchasing.PurchasingManager::HasAvailableProductsToPurchase(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PurchasingManager_HasAvailableProductsToPurchase_mA23998827E0C5EBF5987F05AF9A800CEA3A0B12A (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, bool ___shouldLogUnavailableProducts0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_OnSetupFailed_m3C47D121D10B99663FFD6BE099FBC07092183D99 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, int32_t ___reason0, const RuntimeMethod* method);
// System.Void System.Action::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_Invoke_m3FFA5BE3D64F0FF8E1E1CB6F953913FADB5EB89E (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * __this, const RuntimeMethod* method);
// System.Void System.Func`2<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_mC0A642D3F07FB566E56D3E4395C6E7A53093DE9C (Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 *, RuntimeObject *, intptr_t, const RuntimeMethod*))Func_2__ctor_mA7F3C5A0612B84E910DE92E77BA95101FD68EEDB_gshared)(__this, ___object0, ___method1, method);
}
// System.Collections.Generic.IEnumerable`1<!!1> System.Linq.Enumerable::Select<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product>(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>)
inline RuntimeObject* Enumerable_Select_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mC47E532FD81FF155A9AD9CE8E139BFA2992B7CFF (RuntimeObject* ___source0, Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * ___selector1, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (RuntimeObject*, Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 *, const RuntimeMethod*))Enumerable_Select_TisRuntimeObject_TisRuntimeObject_mC0F1DA980E0433D70A6CF9DD7CD1942BB7FE87C0_gshared)(___source0, ___selector1, method);
}
// System.Void UnityEngine.Purchasing.ProductCollection::.ctor(UnityEngine.Purchasing.Product[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductCollection__ctor_mA5BA7263EBF8B3614EA01852105640CE9D1D2D1E (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* ___products0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::set_products(UnityEngine.Purchasing.ProductCollection)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchasingManager_set_products_m302D5E4CFC91CE9E1162063F0F260DC63EB026AD_inline (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * ___value0, const RuntimeMethod* method);
// System.Collections.Generic.List`1<!!0> System.Linq.Enumerable::ToList<UnityEngine.Purchasing.ProductDefinition>(System.Collections.Generic.IEnumerable`1<!!0>)
inline List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5 * Enumerable_ToList_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_m01AA1776DEE25E5683AAC0EFB71501BA03745774 (RuntimeObject* ___source0, const RuntimeMethod* method)
{
	return ((  List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5 * (*) (RuntimeObject*, const RuntimeMethod*))Enumerable_ToList_TisRuntimeObject_mA4E485F973C6DF746B8DB54CA6F54192D4231CA2_gshared)(___source0, method);
}
// System.Void System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Purchasing.ProductDefinition>::.ctor(System.Collections.Generic.IList`1<!0>)
inline void ReadOnlyCollection_1__ctor_m0B811F745C2789AF0A5DE025161C795ADCA5A960 (ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3 * __this, RuntimeObject* ___list0, const RuntimeMethod* method)
{
	((  void (*) (ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3 *, RuntimeObject*, const RuntimeMethod*))ReadOnlyCollection_1__ctor_mED7425C8A39DDAE57BB831E4903F987E9D033BF2_gshared)(__this, ___list0, method);
}
// UnityEngine.Purchasing.Product UnityEngine.Purchasing.PurchaseEventArgs::get_purchasedProduct()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * PurchaseEventArgs_get_purchasedProduct_m82395AF6B8EB5A4747C638287821893F2D31D355_inline (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.AnalyticsReporter::OnPurchaseSucceeded(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnalyticsReporter_OnPurchaseSucceeded_mBF9872A9CB357375E14A0948C07079F927901130 (AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.AnalyticsReporter::OnPurchaseFailed(UnityEngine.Purchasing.Product,UnityEngine.Purchasing.PurchaseFailureReason)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnalyticsReporter_OnPurchaseFailed_mDBC18A9A51370DFA084D7AF1D85AB0086665AB97 (AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, int32_t ___reason1, const RuntimeMethod* method);
// System.String System.IO.Path::Combine(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_Combine_mC22E47A9BB232F02ED3B6B5F6DD53338D37782EF (String_t* ___path10, String_t* ___path21, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.TransactionLog::GetRecordPath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TransactionLog_GetRecordPath_m942A71AC05728018B92D3F9130F681CC63EF2F45 (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * __this, String_t* ___transactionID0, const RuntimeMethod* method);
// System.Boolean System.IO.Directory::Exists(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Directory_Exists_m17E38B91F6D9A0064D614FF2237BBFC0127468FE (String_t* ___path0, const RuntimeMethod* method);
// System.IO.DirectoryInfo System.IO.Directory::CreateDirectory(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DirectoryInfo_t4EF3610F45F0D234800D01ADA8F3F476AE0CF5CD * Directory_CreateDirectory_m38040338519C48CE52137CC146372A153D5C6A7A (String_t* ___path0, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.TransactionLog::ComputeHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TransactionLog_ComputeHash_m26E7E1369870C738E5158FA9B8B522CDD39993E8 (String_t* ___transactionID0, const RuntimeMethod* method);
// System.Char System.String::get_Chars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70 (String_t* __this, int32_t ___index0, const RuntimeMethod* method);
// System.Int32 System.String::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline (String_t* __this, const RuntimeMethod* method);
// System.Void System.Text.StringBuilder::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_mEDFFE2D378A15F6DAB54D52661C84C1B52E7BA2E (StringBuilder_t * __this, int32_t ___capacity0, const RuntimeMethod* method);
// System.Byte[] System.BitConverter::GetBytes(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* BitConverter_GetBytes_mFAF80F30CFF838A062D9740EB200372693481E1F (uint64_t ___value0, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::AppendFormat(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_AppendFormat_mA3A12EF6C7AC4C5EBC41FCA633F4FC036205669E (StringBuilder_t * __this, String_t* ___format0, RuntimeObject * ___arg01, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.UnifiedReceipt::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnifiedReceipt__ctor_m95303143DCAA8B2CACB4EA6A080F50AB8F5A3450 (UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C * __this, const RuntimeMethod* method);
// System.String UnityEngine.JsonUtility::ToJson(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* JsonUtility_ToJson_mF4F097C9AEC7699970E3E7E99EF8FF2F44DA1B5C (RuntimeObject * ___obj0, const RuntimeMethod* method);
// UnityEngine.Analytics.AnalyticsResult UnityEngine.Analytics.Analytics::Transaction(System.String,System.Decimal,System.String,System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Analytics_Transaction_m6B28F1858A26BFF3D6CD98704C73320D27BFDC0F (String_t* ___productId0, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___amount1, String_t* ___currency2, String_t* ___receiptPurchaseData3, String_t* ___signature4, bool ___usingIAPService5, const RuntimeMethod* method);
// UnityEngine.Analytics.AnalyticsResult UnityEngine.Analytics.Analytics::CustomEvent(System.String,System.Collections.Generic.IDictionary`2<System.String,System.Object>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Analytics_CustomEvent_m1E9B8BA28D46AD42DA9D447644BB69B3B4D93C1A (String_t* ___customEventName0, RuntimeObject* ___eventData1, const RuntimeMethod* method);
// UnityEngine.ILogger UnityEngine.Debug::get_unityLogger()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Debug_get_unityLogger_m70D38067C3055104F6C8D050AB7CE0FDFD05EE22_inline (const RuntimeMethod* method);
// System.String UnityEngine.Application::get_persistentDataPath()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Application_get_persistentDataPath_mBD9C84D06693A9DEF2D9D2206B59D4BCF8A03463 (const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.UnityAnalytics::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAnalytics__ctor_m06F33FBA14352393AEBFD232B8F449015EFD7115 (UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62 * __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.Extension.ICatalogProvider UnityEngine.Purchasing.PurchasingFactory::GetCatalogProvider()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* PurchasingFactory_GetCatalogProvider_m5A9250177EBC80F6D0A390D5DCCBA46425AF193F_inline (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.UnityPurchasing::Initialize(UnityEngine.Purchasing.IStoreListener,UnityEngine.Purchasing.ConfigurationBuilder,UnityEngine.ILogger,System.String,UnityEngine.Purchasing.IUnityAnalytics,UnityEngine.Purchasing.Extension.ICatalogProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityPurchasing_Initialize_m79D9E40F5D4BDB2A05DFECA2A6D4DA12D80F0282 (RuntimeObject* ___listener0, ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ___builder1, RuntimeObject* ___logger2, String_t* ___persistentDatapath3, RuntimeObject* ___analytics4, RuntimeObject* ___catalog5, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass2_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass2_0__ctor_mCA71656BBA4CD214ACBAD8952AD947F05CEB8302 (U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.TransactionLog::.ctor(UnityEngine.ILogger,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransactionLog__ctor_m69D721C1EDECA02889EF962DC5077FE3CD176863 (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * __this, RuntimeObject* ___logger0, String_t* ___persistentDataPath1, const RuntimeMethod* method);
// UnityEngine.Purchasing.Extension.IStore UnityEngine.Purchasing.PurchasingFactory::get_service()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PurchasingFactory_get_service_mE5E7B0A844A43B08F2813E258ECD873B0689B39A (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::.ctor(UnityEngine.Purchasing.TransactionLog,UnityEngine.ILogger,UnityEngine.Purchasing.Extension.IStore,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager__ctor_m251E9682588599B21B7D33DDA7A44926A9D30E29 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * ___tDb0, RuntimeObject* ___logger1, RuntimeObject* ___store2, String_t* ___storeName3, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.AnalyticsReporter::.ctor(UnityEngine.Purchasing.IUnityAnalytics)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnalyticsReporter__ctor_m5AA7698A343EE3F3A76D286856FF1CC4C66FCC82 (AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * __this, RuntimeObject* ___analytics0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.StoreListenerProxy::.ctor(UnityEngine.Purchasing.IStoreListener,UnityEngine.Purchasing.AnalyticsReporter,UnityEngine.Purchasing.IExtensionProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StoreListenerProxy__ctor_mBCC694AD6F19AF0B686F84F9F35A489B7745B7C5 (StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * __this, RuntimeObject* ___forwardTo0, AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * ___analytics1, RuntimeObject* ___extensions2, const RuntimeMethod* method);
// System.Boolean UnityEngine.Purchasing.ConfigurationBuilder::get_useCatalogProvider()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool ConfigurationBuilder_get_useCatalogProvider_mD19652692295CEAC3B86595FA8C3C4A4BBABF664_inline (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method);
// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition> UnityEngine.Purchasing.ConfigurationBuilder::get_products()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ConfigurationBuilder_get_products_m8143583E6C254670908552934A7B2A2B26A9E2AE_inline (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method);
// System.Void System.Action`1<System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>>::.ctor(System.Object,System.IntPtr)
inline void Action_1__ctor_mEC4C58AA11C194EB281B783201E44BEBAA1E18AC (Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 *, RuntimeObject *, intptr_t, const RuntimeMethod*))Action_1__ctor_mA671E933C9D3DAE4E3F71D34FDDA971739618158_gshared)(__this, ___object0, ___method1, method);
}
// System.Void UnityEngine.Purchasing.UnityPurchasing::FetchAndMergeProducts(System.Boolean,System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>,UnityEngine.Purchasing.Extension.ICatalogProvider,System.Action`1<System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityPurchasing_FetchAndMergeProducts_mD67B366475ACD28CCE4D0B5FB93CAFE1333847C0 (bool ___useCatalog0, HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___localProductSet1, RuntimeObject* ___catalog2, Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * ___callback3, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass3_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0__ctor_mCE46D1ADC61B87945F8D7F201F26DCEC5322049B (U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * __this, const RuntimeMethod* method);
// System.Void System.Action`1<System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>>::Invoke(!0)
inline void Action_1_Invoke_m819A05351F202EF5B8F9AB2F363759B0B09D1319 (Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * __this, HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 *, HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 *, const RuntimeMethod*))Action_1_Invoke_m587509C88BB83721D7918D89DF07606BB752D744_gshared)(__this, ___obj0, method);
}
// System.Void UnityEngine.Purchasing.ProductCollection/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_mE557B132E7E4710FFD7F7F4BE5089A8EE063C2F4 (U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_mE70C90F486FEEBDC825A2B27A814F48CF9EBD833 (U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.PurchasingManager::Initialize(UnityEngine.Purchasing.IInternalStoreListener,System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_Initialize_m9E1231D1B39759CD83D74A42F7F87DB2AB8A2840 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, RuntimeObject* ___listener0, HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___products1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>::.ctor(System.Collections.Generic.IEnumerable`1<!0>)
inline void HashSet_1__ctor_m49FF96A56D01B47661A3DA57E99CABB3777841A1 (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * __this, RuntimeObject* ___collection0, const RuntimeMethod* method)
{
	((  void (*) (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 *, RuntimeObject*, const RuntimeMethod*))HashSet_1__ctor_m9D936778F28043838186FC2037F47460DA7925B9_gshared)(__this, ___collection0, method);
}
// System.Collections.Generic.HashSet`1/Enumerator<!0> System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>::GetEnumerator()
inline Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C  HashSet_1_GetEnumerator_m0556A05132CD535D94ECC794908D21198CC99520 (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C  (*) (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 *, const RuntimeMethod*))HashSet_1_GetEnumerator_m7B591DC586DE6ACF8918E1BC71FA731FB919603E_gshared)(__this, method);
}
// !0 System.Collections.Generic.HashSet`1/Enumerator<UnityEngine.Purchasing.ProductDefinition>::get_Current()
inline ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * Enumerator_get_Current_m600D6E603AF57068B4587387CEAAB4EB740A60B4_inline (Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C * __this, const RuntimeMethod* method)
{
	return ((  ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * (*) (Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C *, const RuntimeMethod*))Enumerator_get_Current_mC55AF9E2F45639649E40AF5919D6169FD9543E01_gshared_inline)(__this, method);
}
// System.Boolean System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>::Remove(!0)
inline bool HashSet_1_Remove_m07D62659DE67245D3DE64BF57E99C7AF25DBC6CF (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 *, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *, const RuntimeMethod*))HashSet_1_Remove_m05A1DBBB51DD02B44F81FDB9ECDDED8304381F1D_gshared)(__this, ___item0, method);
}
// System.Boolean System.Collections.Generic.HashSet`1/Enumerator<UnityEngine.Purchasing.ProductDefinition>::MoveNext()
inline bool Enumerator_MoveNext_m60D31817DCDACB537CAD2D01045C2CDD5CECD4F2 (Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C *, const RuntimeMethod*))Enumerator_MoveNext_mD87CDEF3F60C047F21B9E6A48590E59D9D6621C9_gshared)(__this, method);
}
// System.Void System.Collections.Generic.HashSet`1/Enumerator<UnityEngine.Purchasing.ProductDefinition>::Dispose()
inline void Enumerator_Dispose_m69B413E241BCF6115FB0F8CFEEB1855788A349F1 (Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C * __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C *, const RuntimeMethod*))Enumerator_Dispose_m8A225BA705CC2D5BA0A22FF58381EA1FDB37ED20_gshared)(__this, method);
}
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
// System.Void UnityEngine.Purchasing.Extension.AbstractPurchasingModule::Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AbstractPurchasingModule_Configure_mDD1990D2084DEA1815D6AC2B920603117F8E6C92 (AbstractPurchasingModule_tE97233CECF61E1D47FE937203B395835774FBB04 * __this, RuntimeObject* ___binder0, const RuntimeMethod* method)
{
	{
		// this.m_Binder = binder;
		RuntimeObject* L_0 = ___binder0;
		__this->set_m_Binder_0(L_0);
		// Configure();
		VirtActionInvoker0::Invoke(5 /* System.Void UnityEngine.Purchasing.Extension.AbstractPurchasingModule::Configure() */, __this);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.Extension.AbstractPurchasingModule::RegisterStore(System.String,UnityEngine.Purchasing.Extension.IStore)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AbstractPurchasingModule_RegisterStore_mED344AC0AF2514BCE3710A2937C4E5CF15FDC592 (AbstractPurchasingModule_tE97233CECF61E1D47FE937203B395835774FBB04 * __this, String_t* ___name0, RuntimeObject* ___store1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPurchasingBinder_t55347A5ACE1DB3892EEB13D922FD591E238B75E1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_Binder.RegisterStore(name, store);
		RuntimeObject* L_0 = __this->get_m_Binder_0();
		String_t* L_1 = ___name0;
		RuntimeObject* L_2 = ___store1;
		NullCheck(L_0);
		InterfaceActionInvoker2< String_t*, RuntimeObject* >::Invoke(0 /* System.Void UnityEngine.Purchasing.Extension.IPurchasingBinder::RegisterStore(System.String,UnityEngine.Purchasing.Extension.IStore) */, IPurchasingBinder_t55347A5ACE1DB3892EEB13D922FD591E238B75E1_il2cpp_TypeInfo_var, L_0, L_1, L_2);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.Extension.AbstractPurchasingModule::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AbstractPurchasingModule__ctor_mF6444F2524D281396A8ED7A306DABD7655D1728D (AbstractPurchasingModule_tE97233CECF61E1D47FE937203B395835774FBB04 * __this, const RuntimeMethod* method)
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
// System.Void UnityEngine.Purchasing.Extension.AbstractStore::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AbstractStore__ctor_mC8C41E364D4E2A414AC8E3439755882A337CCE97 (AbstractStore_tB0FD374A2E9858EB3A2DC721CBA280409F9485C0 * __this, const RuntimeMethod* method)
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
// System.Void UnityEngine.Purchasing.AnalyticsReporter::.ctor(UnityEngine.Purchasing.IUnityAnalytics)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnalyticsReporter__ctor_m5AA7698A343EE3F3A76D286856FF1CC4C66FCC82 (AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * __this, RuntimeObject* ___analytics0, const RuntimeMethod* method)
{
	{
		// public AnalyticsReporter(IUnityAnalytics analytics)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// m_Analytics = analytics;
		RuntimeObject* L_0 = ___analytics0;
		__this->set_m_Analytics_0(L_0);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.AnalyticsReporter::OnPurchaseSucceeded(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnalyticsReporter_OnPurchaseSucceeded_mBF9872A9CB357375E14A0948C07079F927901130 (AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IUnityAnalytics_t011CB850F707109CA3DBD46809D38E6A41EB5765_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (null == product.metadata.isoCurrencyCode)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___product0;
		NullCheck(L_0);
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_1;
		L_1 = Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE_inline(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		String_t* L_2;
		L_2 = ProductMetadata_get_isoCurrencyCode_mF120AB3BE16D7412714ADCB4A3A309994AD14448_inline(L_1, /*hidden argument*/NULL);
		if (L_2)
		{
			goto IL_000e;
		}
	}
	{
		// return;
		return;
	}

IL_000e:
	{
		// m_Analytics.Transaction(product.definition.storeSpecificId,
		//     product.metadata.localizedPrice,
		//     product.metadata.isoCurrencyCode,
		//     product.receipt,
		//     null);
		RuntimeObject* L_3 = __this->get_m_Analytics_0();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_4 = ___product0;
		NullCheck(L_4);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_5;
		L_5 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_4, /*hidden argument*/NULL);
		NullCheck(L_5);
		String_t* L_6;
		L_6 = ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6_inline(L_5, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_7 = ___product0;
		NullCheck(L_7);
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_8;
		L_8 = Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE_inline(L_7, /*hidden argument*/NULL);
		NullCheck(L_8);
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_9;
		L_9 = ProductMetadata_get_localizedPrice_mCD6B8DDFB4A322CD82A44ECFB0D098F195493F9D_inline(L_8, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_10 = ___product0;
		NullCheck(L_10);
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_11;
		L_11 = Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE_inline(L_10, /*hidden argument*/NULL);
		NullCheck(L_11);
		String_t* L_12;
		L_12 = ProductMetadata_get_isoCurrencyCode_mF120AB3BE16D7412714ADCB4A3A309994AD14448_inline(L_11, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_13 = ___product0;
		NullCheck(L_13);
		String_t* L_14;
		L_14 = Product_get_receipt_mEB9707DA0BF7F2D19DF9A0B2512B416FF89CB8C7_inline(L_13, /*hidden argument*/NULL);
		NullCheck(L_3);
		InterfaceActionInvoker5< String_t*, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7 , String_t*, String_t*, String_t* >::Invoke(0 /* System.Void UnityEngine.Purchasing.IUnityAnalytics::Transaction(System.String,System.Decimal,System.String,System.String,System.String) */, IUnityAnalytics_t011CB850F707109CA3DBD46809D38E6A41EB5765_il2cpp_TypeInfo_var, L_3, L_6, L_9, L_12, L_14, (String_t*)NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.AnalyticsReporter::OnPurchaseFailed(UnityEngine.Purchasing.Product,UnityEngine.Purchasing.PurchaseFailureReason)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnalyticsReporter_OnPurchaseFailed_mDBC18A9A51370DFA084D7AF1D85AB0086665AB97 (AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, int32_t ___reason1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IUnityAnalytics_t011CB850F707109CA3DBD46809D38E6A41EB5765_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PurchaseFailureReason_t92D34AB6DC07828C5204898759640EDFB9336BA5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral012A18907B249DF0954BFA806717C2FD7DDB76F9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2CC71DBDCE6B0FAE2580070B39FD7E51B3684ECD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral364F4173856E05DF96506EB76D1DECAD55D36048);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral474DAFF928C5AC11FD7C81344E18501ED567C068);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralAB3E708924BFB9D6B641A4B9F82FE5FE57F307B6);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * V_0 = NULL;
	{
		// var data = new Dictionary<string, object>() {
		//     { "productID", product.definition.storeSpecificId },
		//     { "reason", reason },
		//     { "price", product.metadata.localizedPrice },
		//     { "currency", product.metadata.isoCurrencyCode }
		// };
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_0 = (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)il2cpp_codegen_object_new(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63(L_0, /*hidden argument*/Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_1 = L_0;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_2 = ___product0;
		NullCheck(L_2);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_3;
		L_3 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_2, /*hidden argument*/NULL);
		NullCheck(L_3);
		String_t* L_4;
		L_4 = ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6_inline(L_3, /*hidden argument*/NULL);
		NullCheck(L_1);
		Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F(L_1, _stringLiteral364F4173856E05DF96506EB76D1DECAD55D36048, L_4, /*hidden argument*/Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var);
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_5 = L_1;
		int32_t L_6 = ___reason1;
		int32_t L_7 = L_6;
		RuntimeObject * L_8 = Box(PurchaseFailureReason_t92D34AB6DC07828C5204898759640EDFB9336BA5_il2cpp_TypeInfo_var, &L_7);
		NullCheck(L_5);
		Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F(L_5, _stringLiteral012A18907B249DF0954BFA806717C2FD7DDB76F9, L_8, /*hidden argument*/Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var);
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_9 = L_5;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_10 = ___product0;
		NullCheck(L_10);
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_11;
		L_11 = Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE_inline(L_10, /*hidden argument*/NULL);
		NullCheck(L_11);
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_12;
		L_12 = ProductMetadata_get_localizedPrice_mCD6B8DDFB4A322CD82A44ECFB0D098F195493F9D_inline(L_11, /*hidden argument*/NULL);
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_13 = L_12;
		RuntimeObject * L_14 = Box(Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7_il2cpp_TypeInfo_var, &L_13);
		NullCheck(L_9);
		Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F(L_9, _stringLiteral2CC71DBDCE6B0FAE2580070B39FD7E51B3684ECD, L_14, /*hidden argument*/Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var);
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_15 = L_9;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_16 = ___product0;
		NullCheck(L_16);
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_17;
		L_17 = Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE_inline(L_16, /*hidden argument*/NULL);
		NullCheck(L_17);
		String_t* L_18;
		L_18 = ProductMetadata_get_isoCurrencyCode_mF120AB3BE16D7412714ADCB4A3A309994AD14448_inline(L_17, /*hidden argument*/NULL);
		NullCheck(L_15);
		Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F(L_15, _stringLiteralAB3E708924BFB9D6B641A4B9F82FE5FE57F307B6, L_18, /*hidden argument*/Dictionary_2_Add_m005F33425CDAEC23027518EC759F8F439AF34F3F_RuntimeMethod_var);
		V_0 = L_15;
		// m_Analytics.CustomEvent("unity.PurchaseFailed", data);
		RuntimeObject* L_19 = __this->get_m_Analytics_0();
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_20 = V_0;
		NullCheck(L_19);
		InterfaceActionInvoker2< String_t*, Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * >::Invoke(1 /* System.Void UnityEngine.Purchasing.IUnityAnalytics::CustomEvent(System.String,System.Collections.Generic.Dictionary`2<System.String,System.Object>) */, IUnityAnalytics_t011CB850F707109CA3DBD46809D38E6A41EB5765_il2cpp_TypeInfo_var, L_19, _stringLiteral474DAFF928C5AC11FD7C81344E18501ED567C068, L_20);
		// }
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
// System.Void UnityEngine.Purchasing.ConfigurationBuilder::.ctor(UnityEngine.Purchasing.PurchasingFactory)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConfigurationBuilder__ctor_m6D44A4228C6D3B5F37B78623D5768584FC3C5F58 (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * ___factory0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1__ctor_mDB79646D0C35A9CDC3F655F883F35AD083912302_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private HashSet<ProductDefinition> m_Products = new HashSet<ProductDefinition>();
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_0 = (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 *)il2cpp_codegen_object_new(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1_il2cpp_TypeInfo_var);
		HashSet_1__ctor_mDB79646D0C35A9CDC3F655F883F35AD083912302(L_0, /*hidden argument*/HashSet_1__ctor_mDB79646D0C35A9CDC3F655F883F35AD083912302_RuntimeMethod_var);
		__this->set_m_Products_1(L_0);
		// internal ConfigurationBuilder(PurchasingFactory factory)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// m_Factory = factory;
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_1 = ___factory0;
		__this->set_m_Factory_0(L_1);
		// }
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.ConfigurationBuilder::get_useCatalogProvider()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ConfigurationBuilder_get_useCatalogProvider_mD19652692295CEAC3B86595FA8C3C4A4BBABF664 (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method)
{
	{
		// get;
		bool L_0 = __this->get_U3CuseCatalogProviderU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition> UnityEngine.Purchasing.ConfigurationBuilder::get_products()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ConfigurationBuilder_get_products_m8143583E6C254670908552934A7B2A2B26A9E2AE (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method)
{
	{
		// get { return m_Products; }
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_0 = __this->get_m_Products_1();
		return L_0;
	}
}
// UnityEngine.Purchasing.PurchasingFactory UnityEngine.Purchasing.ConfigurationBuilder::get_factory()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * ConfigurationBuilder_get_factory_mC832B7559209EE727A013F929285DFF1E0D0CCA0 (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method)
{
	{
		// get { return m_Factory; }
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_0 = __this->get_m_Factory_0();
		return L_0;
	}
}
// UnityEngine.Purchasing.ConfigurationBuilder UnityEngine.Purchasing.ConfigurationBuilder::Instance(UnityEngine.Purchasing.Extension.IPurchasingModule,UnityEngine.Purchasing.Extension.IPurchasingModule[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ConfigurationBuilder_Instance_m8A8AC35B507C6934A818FCDB5DF6BE15952FEEB1 (RuntimeObject* ___first0, IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2* ___rest1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// PurchasingFactory factory = new PurchasingFactory(first, rest);
		RuntimeObject* L_0 = ___first0;
		IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2* L_1 = ___rest1;
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_2 = (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 *)il2cpp_codegen_object_new(PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2_il2cpp_TypeInfo_var);
		PurchasingFactory__ctor_mE6065911A080C31F248EA2A3871EC24EF7BB71E5(L_2, L_0, L_1, /*hidden argument*/NULL);
		// return new ConfigurationBuilder(factory);
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_3 = (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A *)il2cpp_codegen_object_new(ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A_il2cpp_TypeInfo_var);
		ConfigurationBuilder__ctor_m6D44A4228C6D3B5F37B78623D5768584FC3C5F58(L_3, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// UnityEngine.Purchasing.ConfigurationBuilder UnityEngine.Purchasing.ConfigurationBuilder::AddProduct(System.String,UnityEngine.Purchasing.ProductType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ConfigurationBuilder_AddProduct_m5066777AB6A76BB44B01E644B5631B76ADA1663B (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, String_t* ___id0, int32_t ___type1, const RuntimeMethod* method)
{
	{
		// return AddProduct(id, type, null);
		String_t* L_0 = ___id0;
		int32_t L_1 = ___type1;
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_2;
		L_2 = ConfigurationBuilder_AddProduct_m6F291A7C3BB7C97C87DDCD4DF9B44C42C0FD13EA(__this, L_0, L_1, (IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F *)NULL, /*hidden argument*/NULL);
		return L_2;
	}
}
// UnityEngine.Purchasing.ConfigurationBuilder UnityEngine.Purchasing.ConfigurationBuilder::AddProduct(System.String,UnityEngine.Purchasing.ProductType,UnityEngine.Purchasing.IDs)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ConfigurationBuilder_AddProduct_m6F291A7C3BB7C97C87DDCD4DF9B44C42C0FD13EA (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, String_t* ___id0, int32_t ___type1, IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * ___storeIDs2, const RuntimeMethod* method)
{
	{
		// return AddProduct(id, type, storeIDs, (IEnumerable<PayoutDefinition>)null);
		String_t* L_0 = ___id0;
		int32_t L_1 = ___type1;
		IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * L_2 = ___storeIDs2;
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_3;
		L_3 = ConfigurationBuilder_AddProduct_mE4D41230A1FBEC3B58B9E44EAE220DDE6A4665F8(__this, L_0, L_1, L_2, (RuntimeObject*)NULL, /*hidden argument*/NULL);
		return L_3;
	}
}
// UnityEngine.Purchasing.ConfigurationBuilder UnityEngine.Purchasing.ConfigurationBuilder::AddProduct(System.String,UnityEngine.Purchasing.ProductType,UnityEngine.Purchasing.IDs,System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.PayoutDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ConfigurationBuilder_AddProduct_mE4D41230A1FBEC3B58B9E44EAE220DDE6A4665F8 (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, String_t* ___id0, int32_t ___type1, IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * ___storeIDs2, RuntimeObject* ___payouts3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Add_mE4FBC8CF189E84F0C496E46A3AB981EEBDE8BF4D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * V_1 = NULL;
	{
		// var specificId = id;
		String_t* L_0 = ___id0;
		V_0 = L_0;
		// if (storeIDs != null)
		IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * L_1 = ___storeIDs2;
		if (!L_1)
		{
			goto IL_0018;
		}
	}
	{
		// specificId = storeIDs.SpecificIDForStore(factory.storeName, id);
		IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * L_2 = ___storeIDs2;
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_3;
		L_3 = ConfigurationBuilder_get_factory_mC832B7559209EE727A013F929285DFF1E0D0CCA0_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		String_t* L_4;
		L_4 = PurchasingFactory_get_storeName_mFFC419BA561609F0C7FFA02C3C7FC5DCD0E51453_inline(L_3, /*hidden argument*/NULL);
		String_t* L_5 = ___id0;
		NullCheck(L_2);
		String_t* L_6;
		L_6 = IDs_SpecificIDForStore_m4F11D33B86D4AFD9E041BB232A9ECDBD544587DE(L_2, L_4, L_5, /*hidden argument*/NULL);
		V_0 = L_6;
	}

IL_0018:
	{
		// var product = new ProductDefinition(id, specificId, type);
		String_t* L_7 = ___id0;
		String_t* L_8 = V_0;
		int32_t L_9 = ___type1;
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_10 = (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *)il2cpp_codegen_object_new(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var);
		ProductDefinition__ctor_mE256AE9F056EA9E401D0CB8DD80C3C2071827FA1(L_10, L_7, L_8, L_9, /*hidden argument*/NULL);
		V_1 = L_10;
		// product.SetPayouts(payouts);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_11 = V_1;
		RuntimeObject* L_12 = ___payouts3;
		NullCheck(L_11);
		ProductDefinition_SetPayouts_mA6122814E042438C08B1B90A57DE9D77865E617C(L_11, L_12, /*hidden argument*/NULL);
		// m_Products.Add(product);
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_13 = __this->get_m_Products_1();
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_14 = V_1;
		NullCheck(L_13);
		bool L_15;
		L_15 = HashSet_1_Add_mE4FBC8CF189E84F0C496E46A3AB981EEBDE8BF4D(L_13, L_14, /*hidden argument*/HashSet_1_Add_mE4FBC8CF189E84F0C496E46A3AB981EEBDE8BF4D_RuntimeMethod_var);
		// return this;
		return __this;
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
// System.Collections.IEnumerator UnityEngine.Purchasing.IDs::System.Collections.IEnumerable.GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* IDs_System_Collections_IEnumerable_GetEnumerator_mF461E5D41CFACBD1F93001A8563AAEB640A2934C (IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_GetEnumerator_m8C0A038B5FA7E62DEF4DB9EF1F5FCC4348D785C5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return m_Dic.GetEnumerator();
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_0 = __this->get_m_Dic_0();
		NullCheck(L_0);
		Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB  L_1;
		L_1 = Dictionary_2_GetEnumerator_m8C0A038B5FA7E62DEF4DB9EF1F5FCC4348D785C5(L_0, /*hidden argument*/Dictionary_2_GetEnumerator_m8C0A038B5FA7E62DEF4DB9EF1F5FCC4348D785C5_RuntimeMethod_var);
		Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB  L_2 = L_1;
		RuntimeObject * L_3 = Box(Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB_il2cpp_TypeInfo_var, &L_2);
		return (RuntimeObject*)L_3;
	}
}
// System.String UnityEngine.Purchasing.IDs::SpecificIDForStore(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* IDs_SpecificIDForStore_m4F11D33B86D4AFD9E041BB232A9ECDBD544587DE (IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * __this, String_t* ___store0, String_t* ___defaultValue1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (m_Dic.ContainsKey(store))
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_0 = __this->get_m_Dic_0();
		String_t* L_1 = ___store0;
		NullCheck(L_0);
		bool L_2;
		L_2 = Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027(L_0, L_1, /*hidden argument*/Dictionary_2_ContainsKey_m5BB06692D9A48A3FEEB102881A86417DE6DA5027_RuntimeMethod_var);
		if (!L_2)
		{
			goto IL_001b;
		}
	}
	{
		// return m_Dic[store];
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_3 = __this->get_m_Dic_0();
		String_t* L_4 = ___store0;
		NullCheck(L_3);
		String_t* L_5;
		L_5 = Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141(L_3, L_4, /*hidden argument*/Dictionary_2_get_Item_mFCD5E71429358EE225039B602674518740D30141_RuntimeMethod_var);
		return L_5;
	}

IL_001b:
	{
		// return defaultValue;
		String_t* L_6 = ___defaultValue1;
		return L_6;
	}
}
// System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>> UnityEngine.Purchasing.IDs::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* IDs_GetEnumerator_m53FDA58B9BE4B1EF9E42F1E2FA16CE6BF8A93D09 (IDs_t2A680151D8C1DD3B5E75B6C4DD012B9BC3293F8F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_GetEnumerator_m8C0A038B5FA7E62DEF4DB9EF1F5FCC4348D785C5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return m_Dic.GetEnumerator();
		Dictionary_2_tDE3227CA5E7A32F5070BD24C69F42204A3ADE9D5 * L_0 = __this->get_m_Dic_0();
		NullCheck(L_0);
		Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB  L_1;
		L_1 = Dictionary_2_GetEnumerator_m8C0A038B5FA7E62DEF4DB9EF1F5FCC4348D785C5(L_0, /*hidden argument*/Dictionary_2_GetEnumerator_m8C0A038B5FA7E62DEF4DB9EF1F5FCC4348D785C5_RuntimeMethod_var);
		Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB  L_2 = L_1;
		RuntimeObject * L_3 = Box(Enumerator_tEDF5E503528903FB9B9A1D645C82789D7B8006CB_il2cpp_TypeInfo_var, &L_2);
		return (RuntimeObject*)L_3;
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
// System.Void UnityEngine.Purchasing.PayoutDefinition::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PayoutDefinition__ctor_mFE6C10EC7907C33083F3E81C24185F20DA8334EE (PayoutDefinition_t1278207A8201D457938CB37160A4417CABD9694D * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// string m_Subtype = string.Empty;
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_m_Subtype_1(L_0);
		// string m_Data = string.Empty;
		String_t* L_1 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_m_Data_3(L_1);
		// public PayoutDefinition()
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// }
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
// System.Void UnityEngine.Purchasing.Product::.ctor(UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.ProductMetadata,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product__ctor_m943599E6C855DEA54B258C54DC8A29A3667814EE (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___definition0, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___metadata1, String_t* ___receipt2, const RuntimeMethod* method)
{
	{
		// internal Product(ProductDefinition definition, ProductMetadata metadata, string receipt)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this.definition = definition;
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_0 = ___definition0;
		Product_set_definition_m17632BA5F56BA30A07498B0EB5C0D1D7142D521F_inline(__this, L_0, /*hidden argument*/NULL);
		// this.metadata = metadata;
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_1 = ___metadata1;
		Product_set_metadata_m47CFE30071CD7DFC334749332B8C7869D08C18A4_inline(__this, L_1, /*hidden argument*/NULL);
		// this.receipt = receipt;
		String_t* L_2 = ___receipt2;
		Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939_inline(__this, L_2, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.Product::.ctor(UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.ProductMetadata)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product__ctor_m6417672E9F6ED21F6A9D5DA018EEA866AF8CFC9C (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___definition0, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___metadata1, const RuntimeMethod* method)
{
	{
		// internal Product(ProductDefinition definition, ProductMetadata metadata) : this(definition, metadata, null)
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_0 = ___definition0;
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_1 = ___metadata1;
		Product__ctor_m943599E6C855DEA54B258C54DC8A29A3667814EE(__this, L_0, L_1, (String_t*)NULL, /*hidden argument*/NULL);
		// }
		return;
	}
}
// UnityEngine.Purchasing.ProductDefinition UnityEngine.Purchasing.Product::get_definition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public ProductDefinition definition { get; private set; }
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_0 = __this->get_U3CdefinitionU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Product::set_definition(UnityEngine.Purchasing.ProductDefinition)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product_set_definition_m17632BA5F56BA30A07498B0EB5C0D1D7142D521F (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___value0, const RuntimeMethod* method)
{
	{
		// public ProductDefinition definition { get; private set; }
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_0 = ___value0;
		__this->set_U3CdefinitionU3Ek__BackingField_0(L_0);
		return;
	}
}
// UnityEngine.Purchasing.ProductMetadata UnityEngine.Purchasing.Product::get_metadata()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public ProductMetadata metadata { get; internal set; }
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_0 = __this->get_U3CmetadataU3Ek__BackingField_1();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Product::set_metadata(UnityEngine.Purchasing.ProductMetadata)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product_set_metadata_m47CFE30071CD7DFC334749332B8C7869D08C18A4 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___value0, const RuntimeMethod* method)
{
	{
		// public ProductMetadata metadata { get; internal set; }
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_0 = ___value0;
		__this->set_U3CmetadataU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.Product::get_availableToPurchase()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Product_get_availableToPurchase_mBAB83F4E1E276628EA5948A67C2F79F31A003CBF (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public bool availableToPurchase { get; internal set; }
		bool L_0 = __this->get_U3CavailableToPurchaseU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Product::set_availableToPurchase(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product_set_availableToPurchase_m7C4954A4C675BE7DBC041D8928D4E66AEBBBE28C (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// public bool availableToPurchase { get; internal set; }
		bool L_0 = ___value0;
		__this->set_U3CavailableToPurchaseU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Product::get_transactionID()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public string transactionID { get; internal set; }
		String_t* L_0 = __this->get_U3CtransactionIDU3Ek__BackingField_3();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Product::set_transactionID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string transactionID { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CtransactionIDU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Product::get_receipt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Product_get_receipt_mEB9707DA0BF7F2D19DF9A0B2512B416FF89CB8C7 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public string receipt { get; internal set; }
		String_t* L_0 = __this->get_U3CreceiptU3Ek__BackingField_4();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Product::set_receipt(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string receipt { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CreceiptU3Ek__BackingField_4(L_0);
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.Product::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Product_Equals_mC325EDF6C7849CF15E736436882EB610BCA0DD61 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_0 = NULL;
	{
		// if (obj == null)
		RuntimeObject * L_0 = ___obj0;
		if (L_0)
		{
			goto IL_0005;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0005:
	{
		// Product p = obj as Product;
		RuntimeObject * L_1 = ___obj0;
		V_0 = ((Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *)IsInstClass((RuntimeObject*)L_1, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var));
		// if (p == null)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_2 = V_0;
		if (L_2)
		{
			goto IL_0011;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0011:
	{
		// return (definition.Equals(p.definition));
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_3;
		L_3 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(__this, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_4 = V_0;
		NullCheck(L_4);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_5;
		L_5 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_4, /*hidden argument*/NULL);
		NullCheck(L_3);
		bool L_6;
		L_6 = VirtFuncInvoker1< bool, RuntimeObject * >::Invoke(0 /* System.Boolean System.Object::Equals(System.Object) */, L_3, L_5);
		return L_6;
	}
}
// System.Int32 UnityEngine.Purchasing.Product::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Product_GetHashCode_mEC48EE804ED34441A3C3C3D845E0F78DD7D5E2F5 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// return definition.GetHashCode();
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_0;
		L_0 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_0);
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
// System.Void UnityEngine.Purchasing.ProductCollection::.ctor(UnityEngine.Purchasing.Product[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductCollection__ctor_mA5BA7263EBF8B3614EA01852105640CE9D1D2D1E (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* ___products0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1__ctor_mF1247FA13C1F59B28E7048BFABB8E206D160FD64_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private HashSet<Product> m_ProductSet = new HashSet<Product>();
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_0 = (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA *)il2cpp_codegen_object_new(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA_il2cpp_TypeInfo_var);
		HashSet_1__ctor_mF1247FA13C1F59B28E7048BFABB8E206D160FD64(L_0, /*hidden argument*/HashSet_1__ctor_mF1247FA13C1F59B28E7048BFABB8E206D160FD64_RuntimeMethod_var);
		__this->set_m_ProductSet_3(L_0);
		// internal ProductCollection(Product[] products)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// AddProducts(products);
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_1 = ___products0;
		ProductCollection_AddProducts_m0BB3F5D30E6255BF2CC046EDE294CC19C7ADD1D0(__this, (RuntimeObject*)(RuntimeObject*)L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.ProductCollection::AddProducts(System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.Product>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductCollection_AddProducts_m0BB3F5D30E6255BF2CC046EDE294CC19C7ADD1D0 (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, RuntimeObject* ___products0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_ToArray_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mEE2FE11BDD311009011FF50D0BACC5AA3C07BE1C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_ToDictionary_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_TisString_t_mCE58036003050068B397D143069CEB9FFDDDC0BC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2__ctor_m5BA6ACDCD9B26E626B98532D5D60DB79C93CCF44_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_UnionWith_mA88C2E1D44F2F4FCC1E7C24880A99405A87B2E09_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_U3CAddProductsU3Eb__5_0_m815B1655D68CD538FD0A3C4DA1A6592505B189F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_U3CAddProductsU3Eb__5_1_m1F74C97E90D2636BC4DCB850358F89D9A5F84F95_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * G_B2_0 = NULL;
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* G_B2_1 = NULL;
	ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * G_B2_2 = NULL;
	Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * G_B1_0 = NULL;
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* G_B1_1 = NULL;
	ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * G_B1_2 = NULL;
	Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * G_B4_0 = NULL;
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* G_B4_1 = NULL;
	ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * G_B4_2 = NULL;
	Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * G_B3_0 = NULL;
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* G_B3_1 = NULL;
	ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * G_B3_2 = NULL;
	{
		// m_ProductSet.UnionWith(products);
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_0 = __this->get_m_ProductSet_3();
		RuntimeObject* L_1 = ___products0;
		NullCheck(L_0);
		HashSet_1_UnionWith_mA88C2E1D44F2F4FCC1E7C24880A99405A87B2E09(L_0, L_1, /*hidden argument*/HashSet_1_UnionWith_mA88C2E1D44F2F4FCC1E7C24880A99405A87B2E09_RuntimeMethod_var);
		// m_Products = m_ProductSet.ToArray();
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_2 = __this->get_m_ProductSet_3();
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_3;
		L_3 = Enumerable_ToArray_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mEE2FE11BDD311009011FF50D0BACC5AA3C07BE1C(L_2, /*hidden argument*/Enumerable_ToArray_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mEE2FE11BDD311009011FF50D0BACC5AA3C07BE1C_RuntimeMethod_var);
		__this->set_m_Products_2(L_3);
		// m_IdToProduct = m_Products.ToDictionary(x => x.definition.id);
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_4 = __this->get_m_Products_2();
		IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var);
		Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * L_5 = ((U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var))->get_U3CU3E9__5_0_1();
		Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * L_6 = L_5;
		G_B1_0 = L_6;
		G_B1_1 = L_4;
		G_B1_2 = __this;
		if (L_6)
		{
			G_B2_0 = L_6;
			G_B2_1 = L_4;
			G_B2_2 = __this;
			goto IL_0043;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var);
		U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * L_7 = ((U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var))->get_U3CU3E9_0();
		Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * L_8 = (Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 *)il2cpp_codegen_object_new(Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0_il2cpp_TypeInfo_var);
		Func_2__ctor_m5BA6ACDCD9B26E626B98532D5D60DB79C93CCF44(L_8, L_7, (intptr_t)((intptr_t)U3CU3Ec_U3CAddProductsU3Eb__5_0_m815B1655D68CD538FD0A3C4DA1A6592505B189F8_RuntimeMethod_var), /*hidden argument*/Func_2__ctor_m5BA6ACDCD9B26E626B98532D5D60DB79C93CCF44_RuntimeMethod_var);
		Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * L_9 = L_8;
		((U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var))->set_U3CU3E9__5_0_1(L_9);
		G_B2_0 = L_9;
		G_B2_1 = G_B1_1;
		G_B2_2 = G_B1_2;
	}

IL_0043:
	{
		Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * L_10;
		L_10 = Enumerable_ToDictionary_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_TisString_t_mCE58036003050068B397D143069CEB9FFDDDC0BC((RuntimeObject*)(RuntimeObject*)G_B2_1, G_B2_0, /*hidden argument*/Enumerable_ToDictionary_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_TisString_t_mCE58036003050068B397D143069CEB9FFDDDC0BC_RuntimeMethod_var);
		NullCheck(G_B2_2);
		G_B2_2->set_m_IdToProduct_0(L_10);
		// m_StoreSpecificIdToProduct = m_Products.ToDictionary(x => x.definition.storeSpecificId);
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_11 = __this->get_m_Products_2();
		IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var);
		Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * L_12 = ((U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var))->get_U3CU3E9__5_1_2();
		Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * L_13 = L_12;
		G_B3_0 = L_13;
		G_B3_1 = L_11;
		G_B3_2 = __this;
		if (L_13)
		{
			G_B4_0 = L_13;
			G_B4_1 = L_11;
			G_B4_2 = __this;
			goto IL_0073;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var);
		U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * L_14 = ((U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var))->get_U3CU3E9_0();
		Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * L_15 = (Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 *)il2cpp_codegen_object_new(Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0_il2cpp_TypeInfo_var);
		Func_2__ctor_m5BA6ACDCD9B26E626B98532D5D60DB79C93CCF44(L_15, L_14, (intptr_t)((intptr_t)U3CU3Ec_U3CAddProductsU3Eb__5_1_m1F74C97E90D2636BC4DCB850358F89D9A5F84F95_RuntimeMethod_var), /*hidden argument*/Func_2__ctor_m5BA6ACDCD9B26E626B98532D5D60DB79C93CCF44_RuntimeMethod_var);
		Func_2_t13F1C5B3233E4FC9EF09FD6624DC4F83F19BD0F0 * L_16 = L_15;
		((U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var))->set_U3CU3E9__5_1_2(L_16);
		G_B4_0 = L_16;
		G_B4_1 = G_B3_1;
		G_B4_2 = G_B3_2;
	}

IL_0073:
	{
		Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * L_17;
		L_17 = Enumerable_ToDictionary_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_TisString_t_mCE58036003050068B397D143069CEB9FFDDDC0BC((RuntimeObject*)(RuntimeObject*)G_B4_1, G_B4_0, /*hidden argument*/Enumerable_ToDictionary_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_TisString_t_mCE58036003050068B397D143069CEB9FFDDDC0BC_RuntimeMethod_var);
		NullCheck(G_B4_2);
		G_B4_2->set_m_StoreSpecificIdToProduct_1(L_17);
		// }
		return;
	}
}
// System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product> UnityEngine.Purchasing.ProductCollection::get_set()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * ProductCollection_get_set_m59FB3EC03DCFA60FD4F6685381F2E1CF47358725 (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, const RuntimeMethod* method)
{
	{
		// get { return m_ProductSet; }
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_0 = __this->get_m_ProductSet_3();
		return L_0;
	}
}
// UnityEngine.Purchasing.Product[] UnityEngine.Purchasing.ProductCollection::get_all()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* ProductCollection_get_all_m8F08A78D6AF774BE9A1A0C14E69747293EDC6E11 (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, const RuntimeMethod* method)
{
	{
		// get { return m_Products; }
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_0 = __this->get_m_Products_2();
		return L_0;
	}
}
// UnityEngine.Purchasing.Product UnityEngine.Purchasing.ProductCollection::WithID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ProductCollection_WithID_m9289AB6693C11C0D15F0222506D1A2BC6F49F940 (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, String_t* ___id0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_m818108628C884130D20F1CE7A3DD2D0BEDA54240_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_0 = NULL;
	{
		// Product result = null;
		V_0 = (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *)NULL;
		// m_IdToProduct.TryGetValue(id, out result);
		Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * L_0 = __this->get_m_IdToProduct_0();
		String_t* L_1 = ___id0;
		NullCheck(L_0);
		bool L_2;
		L_2 = Dictionary_2_TryGetValue_m818108628C884130D20F1CE7A3DD2D0BEDA54240(L_0, L_1, (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E **)(&V_0), /*hidden argument*/Dictionary_2_TryGetValue_m818108628C884130D20F1CE7A3DD2D0BEDA54240_RuntimeMethod_var);
		// return result;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Purchasing.Product UnityEngine.Purchasing.ProductCollection::WithStoreSpecificID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ProductCollection_WithStoreSpecificID_m6F49CE43D79C4DD72570EFFF2603BA6AFA97A0D4 (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, String_t* ___id0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_m818108628C884130D20F1CE7A3DD2D0BEDA54240_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_0 = NULL;
	{
		// Product result = null;
		V_0 = (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *)NULL;
		// if (id != null)
		String_t* L_0 = ___id0;
		if (!L_0)
		{
			goto IL_0014;
		}
	}
	{
		// m_StoreSpecificIdToProduct.TryGetValue(id, out result);
		Dictionary_2_tE1D69E9CA40947B3D70DD9DD5D07C3B20FA874E3 * L_1 = __this->get_m_StoreSpecificIdToProduct_1();
		String_t* L_2 = ___id0;
		NullCheck(L_1);
		bool L_3;
		L_3 = Dictionary_2_TryGetValue_m818108628C884130D20F1CE7A3DD2D0BEDA54240(L_1, L_2, (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E **)(&V_0), /*hidden argument*/Dictionary_2_TryGetValue_m818108628C884130D20F1CE7A3DD2D0BEDA54240_RuntimeMethod_var);
	}

IL_0014:
	{
		// return result;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_4 = V_0;
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
// System.Void UnityEngine.Purchasing.ProductDefinition::.ctor(System.String,System.String,UnityEngine.Purchasing.ProductType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition__ctor_mE256AE9F056EA9E401D0CB8DD80C3C2071827FA1 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___id0, String_t* ___storeSpecificId1, int32_t ___type2, const RuntimeMethod* method)
{
	{
		// public ProductDefinition(string id, string storeSpecificId, ProductType type) : this(id, storeSpecificId, type, true)
		String_t* L_0 = ___id0;
		String_t* L_1 = ___storeSpecificId1;
		int32_t L_2 = ___type2;
		ProductDefinition__ctor_mECD431B115EECDAC521F7ACA816EF778C17BC270(__this, L_0, L_1, L_2, (bool)1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.ProductDefinition::.ctor(System.String,System.String,UnityEngine.Purchasing.ProductType,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition__ctor_mECD431B115EECDAC521F7ACA816EF778C17BC270 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___id0, String_t* ___storeSpecificId1, int32_t ___type2, bool ___enabled3, const RuntimeMethod* method)
{
	{
		// public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled) : this(id, storeSpecificId, type, enabled, (IEnumerable<PayoutDefinition>)null)
		String_t* L_0 = ___id0;
		String_t* L_1 = ___storeSpecificId1;
		int32_t L_2 = ___type2;
		bool L_3 = ___enabled3;
		ProductDefinition__ctor_mD15BEC65454666E9349D84A1E3D59F4EFBD82713(__this, L_0, L_1, L_2, L_3, (RuntimeObject*)NULL, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.ProductDefinition::.ctor(System.String,System.String,UnityEngine.Purchasing.ProductType,System.Boolean,System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.PayoutDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition__ctor_mD15BEC65454666E9349D84A1E3D59F4EFBD82713 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___id0, String_t* ___storeSpecificId1, int32_t ___type2, bool ___enabled3, RuntimeObject* ___payouts4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m0066DC5C7B9DADA1721568BFC63754E8159B10AC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private List<PayoutDefinition> m_Payouts = new List<PayoutDefinition>();
		List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * L_0 = (List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 *)il2cpp_codegen_object_new(List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5_il2cpp_TypeInfo_var);
		List_1__ctor_m0066DC5C7B9DADA1721568BFC63754E8159B10AC(L_0, /*hidden argument*/List_1__ctor_m0066DC5C7B9DADA1721568BFC63754E8159B10AC_RuntimeMethod_var);
		__this->set_m_Payouts_4(L_0);
		// public ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this.id = id;
		String_t* L_1 = ___id0;
		ProductDefinition_set_id_m51E9751372680165426BF38F704AF156EDC8F409_inline(__this, L_1, /*hidden argument*/NULL);
		// this.storeSpecificId = storeSpecificId;
		String_t* L_2 = ___storeSpecificId1;
		ProductDefinition_set_storeSpecificId_m8B517A5FFCCDE7F6D966D01755E6ED85D7E08383_inline(__this, L_2, /*hidden argument*/NULL);
		// this.type = type;
		int32_t L_3 = ___type2;
		ProductDefinition_set_type_mD99FAB9E2A75B43223D3FC6CD94D2227F08685B7_inline(__this, L_3, /*hidden argument*/NULL);
		// this.enabled = enabled;
		bool L_4 = ___enabled3;
		ProductDefinition_set_enabled_m9D94A78B81CE41EAAC26428D76679DC52BC8D638_inline(__this, L_4, /*hidden argument*/NULL);
		// SetPayouts(payouts);
		RuntimeObject* L_5 = ___payouts4;
		ProductDefinition_SetPayouts_mA6122814E042438C08B1B90A57DE9D77865E617C(__this, L_5, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.ProductDefinition::.ctor(System.String,UnityEngine.Purchasing.ProductType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition__ctor_mE91946E2215B8A4D2045682518527F9C4721BFDD (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___id0, int32_t ___type1, const RuntimeMethod* method)
{
	{
		// public ProductDefinition(string id, ProductType type) : this(id, id, type)
		String_t* L_0 = ___id0;
		String_t* L_1 = ___id0;
		int32_t L_2 = ___type1;
		ProductDefinition__ctor_mE256AE9F056EA9E401D0CB8DD80C3C2071827FA1(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.String UnityEngine.Purchasing.ProductDefinition::get_id()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method)
{
	{
		// public string id { get; private set; }
		String_t* L_0 = __this->get_U3CidU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductDefinition::set_id(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition_set_id_m51E9751372680165426BF38F704AF156EDC8F409 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string id { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CidU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.ProductDefinition::get_storeSpecificId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method)
{
	{
		// public string storeSpecificId { get; private set; }
		String_t* L_0 = __this->get_U3CstoreSpecificIdU3Ek__BackingField_1();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductDefinition::set_storeSpecificId(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition_set_storeSpecificId_m8B517A5FFCCDE7F6D966D01755E6ED85D7E08383 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string storeSpecificId { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CstoreSpecificIdU3Ek__BackingField_1(L_0);
		return;
	}
}
// UnityEngine.Purchasing.ProductType UnityEngine.Purchasing.ProductDefinition::get_type()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ProductDefinition_get_type_m54E16B91196F7553460DEFE3701E9867F126AB42 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method)
{
	{
		// public ProductType type { get; private set; }
		int32_t L_0 = __this->get_U3CtypeU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductDefinition::set_type(UnityEngine.Purchasing.ProductType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition_set_type_mD99FAB9E2A75B43223D3FC6CD94D2227F08685B7 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public ProductType type { get; private set; }
		int32_t L_0 = ___value0;
		__this->set_U3CtypeU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.ProductDefinition::get_enabled()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ProductDefinition_get_enabled_mB14409410443F6717CAE07758FD27EDC5BE88A19 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method)
{
	{
		// public bool enabled { get; private set; }
		bool L_0 = __this->get_U3CenabledU3Ek__BackingField_3();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductDefinition::set_enabled(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition_set_enabled_m9D94A78B81CE41EAAC26428D76679DC52BC8D638 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// public bool enabled { get; private set; }
		bool L_0 = ___value0;
		__this->set_U3CenabledU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.ProductDefinition::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ProductDefinition_Equals_mBB63D4D4C1F6B804E32AB0A6FC95F0A6CD92B768 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * V_0 = NULL;
	{
		// if (obj == null)
		RuntimeObject * L_0 = ___obj0;
		if (L_0)
		{
			goto IL_0005;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0005:
	{
		// ProductDefinition p = obj as ProductDefinition;
		RuntimeObject * L_1 = ___obj0;
		V_0 = ((ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *)IsInstClass((RuntimeObject*)L_1, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var));
		// if (p == null)
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_2 = V_0;
		if (L_2)
		{
			goto IL_0011;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0011:
	{
		// return (id == p.id);
		String_t* L_3;
		L_3 = ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline(__this, /*hidden argument*/NULL);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_4 = V_0;
		NullCheck(L_4);
		String_t* L_5;
		L_5 = ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline(L_4, /*hidden argument*/NULL);
		bool L_6;
		L_6 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_3, L_5, /*hidden argument*/NULL);
		return L_6;
	}
}
// System.Int32 UnityEngine.Purchasing.ProductDefinition::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ProductDefinition_GetHashCode_mEA82BEDE293346BEC31B84EC32C421806A66D99A (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method)
{
	{
		// return id.GetHashCode();
		String_t* L_0;
		L_0 = ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_0);
		return L_1;
	}
}
// System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.PayoutDefinition> UnityEngine.Purchasing.ProductDefinition::get_payouts()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* ProductDefinition_get_payouts_m98FC895648FD1A5501879A76E1CF997B824E3EC3 (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method)
{
	{
		// return m_Payouts;
		List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * L_0 = __this->get_m_Payouts_4();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductDefinition::SetPayouts(System.Collections.Generic.IEnumerable`1<UnityEngine.Purchasing.PayoutDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDefinition_SetPayouts_mA6122814E042438C08B1B90A57DE9D77865E617C (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, RuntimeObject* ___newPayouts0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_AddRange_m5C4A175E221847296EA6BA421CB11FC15629780E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Clear_m16E9797AAF502957D595712D9415EE8EC92BC001_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (newPayouts == null)
		RuntimeObject* L_0 = ___newPayouts0;
		if (L_0)
		{
			goto IL_0004;
		}
	}
	{
		// return;
		return;
	}

IL_0004:
	{
		// m_Payouts.Clear();
		List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * L_1 = __this->get_m_Payouts_4();
		NullCheck(L_1);
		List_1_Clear_m16E9797AAF502957D595712D9415EE8EC92BC001(L_1, /*hidden argument*/List_1_Clear_m16E9797AAF502957D595712D9415EE8EC92BC001_RuntimeMethod_var);
		// m_Payouts.AddRange(newPayouts);
		List_1_tA412B3BCF33761A8E1663DFE231E9FB84169A4B5 * L_2 = __this->get_m_Payouts_4();
		RuntimeObject* L_3 = ___newPayouts0;
		NullCheck(L_2);
		List_1_AddRange_m5C4A175E221847296EA6BA421CB11FC15629780E(L_2, L_3, /*hidden argument*/List_1_AddRange_m5C4A175E221847296EA6BA421CB11FC15629780E_RuntimeMethod_var);
		// }
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
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::.ctor(System.String,UnityEngine.Purchasing.ProductMetadata,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDescription__ctor_m5A36ABE65E02274EC3E63E2252FB7B43852A4D8D (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___id0, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___metadata1, String_t* ___receipt2, String_t* ___transactionId3, const RuntimeMethod* method)
{
	{
		// public ProductDescription(string id, ProductMetadata metadata,
		//                           string receipt, string transactionId)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// storeSpecificId = id;
		String_t* L_0 = ___id0;
		ProductDescription_set_storeSpecificId_mA913B1D4F5C2DB7009A530F0B3550EF57F20FD44_inline(__this, L_0, /*hidden argument*/NULL);
		// this.metadata = metadata;
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_1 = ___metadata1;
		ProductDescription_set_metadata_mDD9C2B807FD047A7C91EDA3996931E5D9E886703_inline(__this, L_1, /*hidden argument*/NULL);
		// this.receipt = receipt;
		String_t* L_2 = ___receipt2;
		ProductDescription_set_receipt_m68F0A2BE12715CD2FFD606E6455796D4EA254101_inline(__this, L_2, /*hidden argument*/NULL);
		// this.transactionId = transactionId;
		String_t* L_3 = ___transactionId3;
		ProductDescription_set_transactionId_m5C0C2615AAB10FD93A69683CDEDC072F44CCA752_inline(__this, L_3, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::.ctor(System.String,UnityEngine.Purchasing.ProductMetadata,System.String,System.String,UnityEngine.Purchasing.ProductType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDescription__ctor_mECF8458853D84D8CEC8AEA0956F088DC7BDC7ED2 (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___id0, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___metadata1, String_t* ___receipt2, String_t* ___transactionId3, int32_t ___type4, const RuntimeMethod* method)
{
	{
		// : this(id, metadata, receipt, transactionId)
		String_t* L_0 = ___id0;
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_1 = ___metadata1;
		String_t* L_2 = ___receipt2;
		String_t* L_3 = ___transactionId3;
		ProductDescription__ctor_m5A36ABE65E02274EC3E63E2252FB7B43852A4D8D(__this, L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		// this.type = type;
		int32_t L_4 = ___type4;
		__this->set_type_1(L_4);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::.ctor(System.String,UnityEngine.Purchasing.ProductMetadata)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDescription__ctor_m3338B95919E9021FA186F9A1F7AA972C6E1CC8E1 (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___id0, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___metadata1, const RuntimeMethod* method)
{
	{
		// public ProductDescription(string id, ProductMetadata metadata) : this(id, metadata, null, null)
		String_t* L_0 = ___id0;
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_1 = ___metadata1;
		ProductDescription__ctor_m5A36ABE65E02274EC3E63E2252FB7B43852A4D8D(__this, L_0, L_1, (String_t*)NULL, (String_t*)NULL, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.String UnityEngine.Purchasing.Extension.ProductDescription::get_storeSpecificId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductDescription_get_storeSpecificId_m805EE28C57C25664093C7F5C2FB24EAADFEAFB09 (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method)
{
	{
		// public string storeSpecificId { get; private set; }
		String_t* L_0 = __this->get_U3CstoreSpecificIdU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::set_storeSpecificId(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDescription_set_storeSpecificId_mA913B1D4F5C2DB7009A530F0B3550EF57F20FD44 (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string storeSpecificId { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CstoreSpecificIdU3Ek__BackingField_0(L_0);
		return;
	}
}
// UnityEngine.Purchasing.ProductMetadata UnityEngine.Purchasing.Extension.ProductDescription::get_metadata()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ProductDescription_get_metadata_m3638B035BE86738C71F776D7313827080557986B (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method)
{
	{
		// public ProductMetadata metadata { get; private set; }
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_0 = __this->get_U3CmetadataU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::set_metadata(UnityEngine.Purchasing.ProductMetadata)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDescription_set_metadata_mDD9C2B807FD047A7C91EDA3996931E5D9E886703 (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___value0, const RuntimeMethod* method)
{
	{
		// public ProductMetadata metadata { get; private set; }
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_0 = ___value0;
		__this->set_U3CmetadataU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Extension.ProductDescription::get_receipt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductDescription_get_receipt_m0D6C6B53F56F62B89399A156E392AF9AE1D53CC7 (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method)
{
	{
		// public string receipt { get; private set; }
		String_t* L_0 = __this->get_U3CreceiptU3Ek__BackingField_3();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::set_receipt(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDescription_set_receipt_m68F0A2BE12715CD2FFD606E6455796D4EA254101 (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string receipt { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CreceiptU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Extension.ProductDescription::get_transactionId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductDescription_get_transactionId_m88319BAE8BD3CC3E1D65E19370EE3EB9379BE93F (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method)
{
	{
		// public string transactionId { get; set; }
		String_t* L_0 = __this->get_U3CtransactionIdU3Ek__BackingField_4();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Extension.ProductDescription::set_transactionId(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductDescription_set_transactionId_m5C0C2615AAB10FD93A69683CDEDC072F44CCA752 (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string transactionId { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CtransactionIdU3Ek__BackingField_4(L_0);
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
// System.Void UnityEngine.Purchasing.ProductMetadata::.ctor(System.String,System.String,System.String,System.String,System.Decimal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductMetadata__ctor_m70B4DE85AEB735ECFEBB4051860A27A08487A4C4 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___priceString0, String_t* ___title1, String_t* ___description2, String_t* ___currencyCode3, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___localizedPrice4, const RuntimeMethod* method)
{
	{
		// public ProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// localizedPriceString = priceString;
		String_t* L_0 = ___priceString0;
		ProductMetadata_set_localizedPriceString_m3114E4D67F5A17BC187DBB9D3A067C0569A69702_inline(__this, L_0, /*hidden argument*/NULL);
		// localizedTitle = title;
		String_t* L_1 = ___title1;
		ProductMetadata_set_localizedTitle_mA0D1F59CA6B369ED045226948723B583CD49E78A_inline(__this, L_1, /*hidden argument*/NULL);
		// localizedDescription = description;
		String_t* L_2 = ___description2;
		ProductMetadata_set_localizedDescription_m1B74BFD9B930EF7A3174C3C8738EE404D1399152_inline(__this, L_2, /*hidden argument*/NULL);
		// isoCurrencyCode = currencyCode;
		String_t* L_3 = ___currencyCode3;
		ProductMetadata_set_isoCurrencyCode_m4E5A20FB8601E9A651FBA18BBB5F5ACD426DA768_inline(__this, L_3, /*hidden argument*/NULL);
		// this.localizedPrice = localizedPrice;
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_4 = ___localizedPrice4;
		ProductMetadata_set_localizedPrice_mF41BFD302AE1C9F21AEBD893D4337C362C50DB88_inline(__this, L_4, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.ProductMetadata::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductMetadata__ctor_m7561EFECB866511CAE76597E34C9DFD34E0D3171 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method)
{
	{
		// public ProductMetadata()
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.String UnityEngine.Purchasing.ProductMetadata::get_localizedPriceString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductMetadata_get_localizedPriceString_mA5D6DDFDCF8F4B157E3AC23559650C89ED863914 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method)
{
	{
		// public string localizedPriceString { get; internal set; }
		String_t* L_0 = __this->get_U3ClocalizedPriceStringU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductMetadata::set_localizedPriceString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedPriceString_m3114E4D67F5A17BC187DBB9D3A067C0569A69702 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string localizedPriceString { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3ClocalizedPriceStringU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.ProductMetadata::get_localizedTitle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductMetadata_get_localizedTitle_m2DCBF60B7674A4E25E4D14D00EC66F40C0157D31 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method)
{
	{
		// public string localizedTitle { get; internal set; }
		String_t* L_0 = __this->get_U3ClocalizedTitleU3Ek__BackingField_1();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductMetadata::set_localizedTitle(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedTitle_mA0D1F59CA6B369ED045226948723B583CD49E78A (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string localizedTitle { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3ClocalizedTitleU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.ProductMetadata::get_localizedDescription()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductMetadata_get_localizedDescription_mB3B820DBB41F1EEC2B9E2C9B588CDC7050818FDF (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method)
{
	{
		// public string localizedDescription { get; internal set; }
		String_t* L_0 = __this->get_U3ClocalizedDescriptionU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductMetadata::set_localizedDescription(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedDescription_m1B74BFD9B930EF7A3174C3C8738EE404D1399152 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string localizedDescription { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3ClocalizedDescriptionU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.ProductMetadata::get_isoCurrencyCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ProductMetadata_get_isoCurrencyCode_mF120AB3BE16D7412714ADCB4A3A309994AD14448 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method)
{
	{
		// public string isoCurrencyCode { get; internal set; }
		String_t* L_0 = __this->get_U3CisoCurrencyCodeU3Ek__BackingField_3();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductMetadata::set_isoCurrencyCode(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductMetadata_set_isoCurrencyCode_m4E5A20FB8601E9A651FBA18BBB5F5ACD426DA768 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string isoCurrencyCode { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CisoCurrencyCodeU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.Decimal UnityEngine.Purchasing.ProductMetadata::get_localizedPrice()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ProductMetadata_get_localizedPrice_mCD6B8DDFB4A322CD82A44ECFB0D098F195493F9D (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method)
{
	{
		// public decimal localizedPrice { get; internal set; }
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_0 = __this->get_U3ClocalizedPriceU3Ek__BackingField_4();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.ProductMetadata::set_localizedPrice(System.Decimal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedPrice_mF41BFD302AE1C9F21AEBD893D4337C362C50DB88 (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___value0, const RuntimeMethod* method)
{
	{
		// public decimal localizedPrice { get; internal set; }
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_0 = ___value0;
		__this->set_U3ClocalizedPriceU3Ek__BackingField_4(L_0);
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
// System.Void UnityEngine.Purchasing.ProductPurchaseUpdater::UpdateProductReceiptAndTransactionID(UnityEngine.Purchasing.Product,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ProductPurchaseUpdater_UpdateProductReceiptAndTransactionID_mF5D682B563D1A815D8574CDF04363F9820A5F2F2 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, String_t* ___receipt1, String_t* ___transactionId2, String_t* ___storeName3, const RuntimeMethod* method)
{
	{
		// product.receipt = UnifiedReceiptFormatter.FormatUnifiedReceipt(receipt, transactionId, storeName);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___product0;
		String_t* L_1 = ___receipt1;
		String_t* L_2 = ___transactionId2;
		String_t* L_3 = ___storeName3;
		String_t* L_4;
		L_4 = UnifiedReceiptFormatter_FormatUnifiedReceipt_mD91359B583BEB06ACD63EE20F0B1F6495B266AE9(L_1, L_2, L_3, /*hidden argument*/NULL);
		NullCheck(L_0);
		Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939_inline(L_0, L_4, /*hidden argument*/NULL);
		// product.transactionID = transactionId;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_5 = ___product0;
		String_t* L_6 = ___transactionId2;
		NullCheck(L_5);
		Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF_inline(L_5, L_6, /*hidden argument*/NULL);
		// }
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
// System.Void UnityEngine.Purchasing.PurchaseEventArgs::.ctor(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchaseEventArgs__ctor_m8B7ED6ABBC91A602EBD4B4442173C29D372AF4D1 (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___purchasedProduct0, const RuntimeMethod* method)
{
	{
		// internal PurchaseEventArgs(Product purchasedProduct)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this.purchasedProduct = purchasedProduct;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___purchasedProduct0;
		PurchaseEventArgs_set_purchasedProduct_mDBEFD23C5488F6EC6F2EE719925D31A090AC35CC_inline(__this, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// UnityEngine.Purchasing.Product UnityEngine.Purchasing.PurchaseEventArgs::get_purchasedProduct()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * PurchaseEventArgs_get_purchasedProduct_m82395AF6B8EB5A4747C638287821893F2D31D355 (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * __this, const RuntimeMethod* method)
{
	{
		// public Product purchasedProduct { get; private set; }
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = __this->get_U3CpurchasedProductU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.PurchaseEventArgs::set_purchasedProduct(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchaseEventArgs_set_purchasedProduct_mDBEFD23C5488F6EC6F2EE719925D31A090AC35CC (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___value0, const RuntimeMethod* method)
{
	{
		// public Product purchasedProduct { get; private set; }
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___value0;
		__this->set_U3CpurchasedProductU3Ek__BackingField_0(L_0);
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
// System.Void UnityEngine.Purchasing.Extension.PurchaseFailureDescription::.ctor(System.String,UnityEngine.Purchasing.PurchaseFailureReason,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchaseFailureDescription__ctor_m82E2FF9C0415A1D1001A8C0F80016441A08140D5 (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, String_t* ___productId0, int32_t ___reason1, String_t* ___message2, const RuntimeMethod* method)
{
	{
		// public PurchaseFailureDescription(string productId, PurchaseFailureReason reason, string message)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this.productId = productId;
		String_t* L_0 = ___productId0;
		PurchaseFailureDescription_set_productId_mE295E5962FBA98CCB477B4B0572CC6FC3A766B6D_inline(__this, L_0, /*hidden argument*/NULL);
		// this.reason = reason;
		int32_t L_1 = ___reason1;
		PurchaseFailureDescription_set_reason_mDEA2EF43F275FBDED54C8727D03F749E898E22FE_inline(__this, L_1, /*hidden argument*/NULL);
		// this.message = message;
		String_t* L_2 = ___message2;
		PurchaseFailureDescription_set_message_mD2A75514074F67A7CEC79A18D061F444F5BCCAC1_inline(__this, L_2, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.String UnityEngine.Purchasing.Extension.PurchaseFailureDescription::get_productId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PurchaseFailureDescription_get_productId_mDAE0C9E1F3A0144CF7A6728EDAC287009F483057 (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method)
{
	{
		// public string productId { get; private set; }
		String_t* L_0 = __this->get_U3CproductIdU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Extension.PurchaseFailureDescription::set_productId(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_productId_mE295E5962FBA98CCB477B4B0572CC6FC3A766B6D (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string productId { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CproductIdU3Ek__BackingField_0(L_0);
		return;
	}
}
// UnityEngine.Purchasing.PurchaseFailureReason UnityEngine.Purchasing.Extension.PurchaseFailureDescription::get_reason()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t PurchaseFailureDescription_get_reason_m0EF61510E8851D12EA86FF0376DC4B99A7415E0F (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method)
{
	{
		// public PurchaseFailureReason reason { get; private set; }
		int32_t L_0 = __this->get_U3CreasonU3Ek__BackingField_1();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Extension.PurchaseFailureDescription::set_reason(UnityEngine.Purchasing.PurchaseFailureReason)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_reason_mDEA2EF43F275FBDED54C8727D03F749E898E22FE (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public PurchaseFailureReason reason { get; private set; }
		int32_t L_0 = ___value0;
		__this->set_U3CreasonU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Extension.PurchaseFailureDescription::get_message()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PurchaseFailureDescription_get_message_mF5E354CE7F8BAEF0BE525EC30608A54F4607E504 (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method)
{
	{
		// public String message { get; private set; }
		String_t* L_0 = __this->get_U3CmessageU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Extension.PurchaseFailureDescription::set_message(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_message_mD2A75514074F67A7CEC79A18D061F444F5BCCAC1 (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public String message { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CmessageU3Ek__BackingField_2(L_0);
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
// System.Void UnityEngine.Purchasing.PurchasingFactory::.ctor(UnityEngine.Purchasing.Extension.IPurchasingModule,UnityEngine.Purchasing.Extension.IPurchasingModule[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingFactory__ctor_mE6065911A080C31F248EA2A3871EC24EF7BB71E5 (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, RuntimeObject* ___first0, IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2* ___remainingModules1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_m17F438F4F280FA74C072C108A91953A0D3D08927_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_m44704C7AAA86E3266061F028FC3FC6F45F36D029_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPurchasingModule_t1F474F8488BDF1F1D3B8C907E7648E4829B2A597_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// private Dictionary<Type, IStoreConfiguration> m_ConfigMap = new Dictionary<Type, IStoreConfiguration>();
		Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51 * L_0 = (Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51 *)il2cpp_codegen_object_new(Dictionary_2_t64F28B8D958378EB9AB1546B27F670B1B5F3ED51_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m44704C7AAA86E3266061F028FC3FC6F45F36D029(L_0, /*hidden argument*/Dictionary_2__ctor_m44704C7AAA86E3266061F028FC3FC6F45F36D029_RuntimeMethod_var);
		__this->set_m_ConfigMap_0(L_0);
		// private Dictionary<Type, IStoreExtension> m_ExtensionMap = new Dictionary<Type, IStoreExtension>();
		Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004 * L_1 = (Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004 *)il2cpp_codegen_object_new(Dictionary_2_t4061741366DFB8F135696C736B5D70F4E4E72004_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m17F438F4F280FA74C072C108A91953A0D3D08927(L_1, /*hidden argument*/Dictionary_2__ctor_m17F438F4F280FA74C072C108A91953A0D3D08927_RuntimeMethod_var);
		__this->set_m_ExtensionMap_1(L_1);
		// public PurchasingFactory(IPurchasingModule first, params IPurchasingModule[] remainingModules)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// first.Configure(this);
		RuntimeObject* L_2 = ___first0;
		NullCheck(L_2);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(0 /* System.Void UnityEngine.Purchasing.Extension.IPurchasingModule::Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder) */, IPurchasingModule_t1F474F8488BDF1F1D3B8C907E7648E4829B2A597_il2cpp_TypeInfo_var, L_2, __this);
		// foreach (var module in remainingModules)
		IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2* L_3 = ___remainingModules1;
		V_0 = L_3;
		V_1 = 0;
		goto IL_0036;
	}

IL_0029:
	{
		// foreach (var module in remainingModules)
		IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2* L_4 = V_0;
		int32_t L_5 = V_1;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		RuntimeObject* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		// module.Configure(this);
		NullCheck(L_7);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(0 /* System.Void UnityEngine.Purchasing.Extension.IPurchasingModule::Configure(UnityEngine.Purchasing.Extension.IPurchasingBinder) */, IPurchasingModule_t1F474F8488BDF1F1D3B8C907E7648E4829B2A597_il2cpp_TypeInfo_var, L_7, __this);
		int32_t L_8 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1));
	}

IL_0036:
	{
		// foreach (var module in remainingModules)
		int32_t L_9 = V_1;
		IPurchasingModuleU5BU5D_t1B7B3D30C9A9AC4EEB093DD12C9D93E5DCB5F4B2* L_10 = V_0;
		NullCheck(L_10);
		if ((((int32_t)L_9) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_10)->max_length))))))
		{
			goto IL_0029;
		}
	}
	{
		// }
		return;
	}
}
// System.String UnityEngine.Purchasing.PurchasingFactory::get_storeName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PurchasingFactory_get_storeName_mFFC419BA561609F0C7FFA02C3C7FC5DCD0E51453 (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, const RuntimeMethod* method)
{
	{
		// public string storeName { get; private set; }
		String_t* L_0 = __this->get_U3CstoreNameU3Ek__BackingField_4();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingFactory::set_storeName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingFactory_set_storeName_mF4007CD7F5CD1373507429D6E6BA9D5A4800AC7D (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string storeName { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CstoreNameU3Ek__BackingField_4(L_0);
		return;
	}
}
// UnityEngine.Purchasing.Extension.IStore UnityEngine.Purchasing.PurchasingFactory::get_service()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PurchasingFactory_get_service_mE5E7B0A844A43B08F2813E258ECD873B0689B39A (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, const RuntimeMethod* method)
{
	{
		// if (m_Store != null)
		RuntimeObject* L_0 = __this->get_m_Store_2();
		if (!L_0)
		{
			goto IL_000f;
		}
	}
	{
		// return m_Store;
		RuntimeObject* L_1 = __this->get_m_Store_2();
		return L_1;
	}

IL_000f:
	{
		// throw new InvalidOperationException("No impl available!");
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_2 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralE838692FA53EEF960E9D0CB6D54405E9A12BF310)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PurchasingFactory_get_service_mE5E7B0A844A43B08F2813E258ECD873B0689B39A_RuntimeMethod_var)));
	}
}
// System.Void UnityEngine.Purchasing.PurchasingFactory::set_service(UnityEngine.Purchasing.Extension.IStore)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingFactory_set_service_mD6B699C7477F20875DE50767AB1CE363CB17DA44 (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, RuntimeObject* ___value0, const RuntimeMethod* method)
{
	{
		// set { m_Store = value; }
		RuntimeObject* L_0 = ___value0;
		__this->set_m_Store_2(L_0);
		// set { m_Store = value; }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingFactory::RegisterStore(System.String,UnityEngine.Purchasing.Extension.IStore)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingFactory_RegisterStore_mEBA9FE992648231E02B4844154676190E914D853 (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, String_t* ___name0, RuntimeObject* ___s1, const RuntimeMethod* method)
{
	{
		// if (m_Store == null && s != null)
		RuntimeObject* L_0 = __this->get_m_Store_2();
		if (L_0)
		{
			goto IL_0019;
		}
	}
	{
		RuntimeObject* L_1 = ___s1;
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		// storeName = name;
		String_t* L_2 = ___name0;
		PurchasingFactory_set_storeName_mF4007CD7F5CD1373507429D6E6BA9D5A4800AC7D_inline(__this, L_2, /*hidden argument*/NULL);
		// service = s;
		RuntimeObject* L_3 = ___s1;
		PurchasingFactory_set_service_mD6B699C7477F20875DE50767AB1CE363CB17DA44_inline(__this, L_3, /*hidden argument*/NULL);
	}

IL_0019:
	{
		// }
		return;
	}
}
// UnityEngine.Purchasing.Extension.ICatalogProvider UnityEngine.Purchasing.PurchasingFactory::GetCatalogProvider()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PurchasingFactory_GetCatalogProvider_m5A9250177EBC80F6D0A390D5DCCBA46425AF193F (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, const RuntimeMethod* method)
{
	{
		// return m_CatalogProvider;
		RuntimeObject* L_0 = __this->get_m_CatalogProvider_3();
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
// System.Boolean UnityEngine.Purchasing.PurchasingManager::get_useTransactionLog()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PurchasingManager_get_useTransactionLog_mB8E7472617FCBD4BA5C910F4D5D5FFB6A0A6BADF (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method)
{
	{
		// public bool useTransactionLog { get; set; }
		bool L_0 = __this->get_U3CuseTransactionLogU3Ek__BackingField_7();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::set_useTransactionLog(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_set_useTransactionLog_mB13861C43C5625F0F4EA38327A6056EE9EF273DA (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// public bool useTransactionLog { get; set; }
		bool L_0 = ___value0;
		__this->set_U3CuseTransactionLogU3Ek__BackingField_7(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::.ctor(UnityEngine.Purchasing.TransactionLog,UnityEngine.ILogger,UnityEngine.Purchasing.Extension.IStore,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager__ctor_m251E9682588599B21B7D33DDA7A44926A9D30E29 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * ___tDb0, RuntimeObject* ___logger1, RuntimeObject* ___store2, String_t* ___storeName3, const RuntimeMethod* method)
{
	{
		// internal PurchasingManager(TransactionLog tDb, ILogger logger, IStore store, string storeName)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// m_TransactionLog = tDb;
		TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * L_0 = ___tDb0;
		__this->set_m_TransactionLog_3(L_0);
		// m_Store = store;
		RuntimeObject* L_1 = ___store2;
		__this->set_m_Store_0(L_1);
		// m_Logger = logger;
		RuntimeObject* L_2 = ___logger1;
		__this->set_m_Logger_2(L_2);
		// m_StoreName = storeName;
		String_t* L_3 = ___storeName3;
		__this->set_m_StoreName_4(L_3);
		// useTransactionLog = true;
		PurchasingManager_set_useTransactionLog_mB13861C43C5625F0F4EA38327A6056EE9EF273DA_inline(__this, (bool)1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::InitiatePurchase(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_InitiatePurchase_mAB3C5B26ADC0E157D629DF43A063C7AF2B0D8CA5 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// InitiatePurchase(product, string.Empty);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___product0;
		String_t* L_1 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		PurchasingManager_InitiatePurchase_m312855678BFC254CA30B5E9530207B896923F85C(__this, L_0, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::InitiatePurchase(UnityEngine.Purchasing.Product,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_InitiatePurchase_m312855678BFC254CA30B5E9530207B896923F85C (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, String_t* ___developerPayload1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC18E9CCAC1016A10BA9513A2E6CF1F1FB023D755);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF70186B9E93B040BE74228E43B2D0DFEECC9C509);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (null == product)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___product0;
		if (L_0)
		{
			goto IL_0019;
		}
	}
	{
		// m_Logger.LogWarning("Unity IAP", "Trying to purchase null Product");
		RuntimeObject* L_1 = __this->get_m_Logger_2();
		NullCheck(L_1);
		InterfaceActionInvoker2< String_t*, RuntimeObject * >::Invoke(6 /* System.Void UnityEngine.ILogger::LogWarning(System.String,System.Object) */, ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var, L_1, _stringLiteralF70186B9E93B040BE74228E43B2D0DFEECC9C509, _stringLiteralC18E9CCAC1016A10BA9513A2E6CF1F1FB023D755);
		// return;
		return;
	}

IL_0019:
	{
		// if (!product.availableToPurchase)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_2 = ___product0;
		NullCheck(L_2);
		bool L_3;
		L_3 = Product_get_availableToPurchase_mBAB83F4E1E276628EA5948A67C2F79F31A003CBF_inline(L_2, /*hidden argument*/NULL);
		if (L_3)
		{
			goto IL_002f;
		}
	}
	{
		// m_Listener.OnPurchaseFailed(product, PurchaseFailureReason.ProductUnavailable);
		RuntimeObject* L_4 = __this->get_m_Listener_1();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_5 = ___product0;
		NullCheck(L_4);
		InterfaceActionInvoker2< Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *, int32_t >::Invoke(2 /* System.Void UnityEngine.Purchasing.IInternalStoreListener::OnPurchaseFailed(UnityEngine.Purchasing.Product,UnityEngine.Purchasing.PurchaseFailureReason) */, IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var, L_4, L_5, 2);
		// return;
		return;
	}

IL_002f:
	{
		// m_Store.Purchase(product.definition, developerPayload);
		RuntimeObject* L_6 = __this->get_m_Store_0();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_7 = ___product0;
		NullCheck(L_7);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_8;
		L_8 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_7, /*hidden argument*/NULL);
		String_t* L_9 = ___developerPayload1;
		NullCheck(L_6);
		InterfaceActionInvoker2< ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *, String_t* >::Invoke(2 /* System.Void UnityEngine.Purchasing.Extension.IStore::Purchase(UnityEngine.Purchasing.ProductDefinition,System.String) */, IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var, L_6, L_8, L_9);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::ConfirmPendingPurchase(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_ConfirmPendingPurchase_m891FE9D820139B48C2C469CB12D103664E45ED43 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral523FBF11CD01FCA136C78DEF46B68DDA517990DB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral57D091E724A1E1A78CFF70893BF15B1612349B44);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF70186B9E93B040BE74228E43B2D0DFEECC9C509);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (null == product)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___product0;
		if (L_0)
		{
			goto IL_0019;
		}
	}
	{
		// m_Logger.LogError("Unity IAP", "Unable to confirm purchase with null Product");
		RuntimeObject* L_1 = __this->get_m_Logger_2();
		NullCheck(L_1);
		InterfaceActionInvoker2< String_t*, RuntimeObject * >::Invoke(7 /* System.Void UnityEngine.ILogger::LogError(System.String,System.Object) */, ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var, L_1, _stringLiteralF70186B9E93B040BE74228E43B2D0DFEECC9C509, _stringLiteral57D091E724A1E1A78CFF70893BF15B1612349B44);
		// return;
		return;
	}

IL_0019:
	{
		// if (string.IsNullOrEmpty(product.transactionID))
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_2 = ___product0;
		NullCheck(L_2);
		String_t* L_3;
		L_3 = Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline(L_2, /*hidden argument*/NULL);
		bool L_4;
		L_4 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_3, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_003c;
		}
	}
	{
		// m_Logger.LogError("Unity IAP", "Unable to confirm purchase; Product has missing or empty transactionID");
		RuntimeObject* L_5 = __this->get_m_Logger_2();
		NullCheck(L_5);
		InterfaceActionInvoker2< String_t*, RuntimeObject * >::Invoke(7 /* System.Void UnityEngine.ILogger::LogError(System.String,System.Object) */, ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var, L_5, _stringLiteralF70186B9E93B040BE74228E43B2D0DFEECC9C509, _stringLiteral523FBF11CD01FCA136C78DEF46B68DDA517990DB);
		// return;
		return;
	}

IL_003c:
	{
		// if (useTransactionLog)
		bool L_6;
		L_6 = PurchasingManager_get_useTransactionLog_mB8E7472617FCBD4BA5C910F4D5D5FFB6A0A6BADF_inline(__this, /*hidden argument*/NULL);
		if (!L_6)
		{
			goto IL_0055;
		}
	}
	{
		// m_TransactionLog.Record(product.transactionID);
		TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * L_7 = __this->get_m_TransactionLog_3();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_8 = ___product0;
		NullCheck(L_8);
		String_t* L_9;
		L_9 = Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline(L_8, /*hidden argument*/NULL);
		NullCheck(L_7);
		TransactionLog_Record_m7CDAC959A14AD174B4C33255F2BA013349883895(L_7, L_9, /*hidden argument*/NULL);
	}

IL_0055:
	{
		// m_Store.FinishTransaction(product.definition, product.transactionID);
		RuntimeObject* L_10 = __this->get_m_Store_0();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_11 = ___product0;
		NullCheck(L_11);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_12;
		L_12 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_11, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_13 = ___product0;
		NullCheck(L_13);
		String_t* L_14;
		L_14 = Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline(L_13, /*hidden argument*/NULL);
		NullCheck(L_10);
		InterfaceActionInvoker2< ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *, String_t* >::Invoke(3 /* System.Void UnityEngine.Purchasing.Extension.IStore::FinishTransaction(UnityEngine.Purchasing.ProductDefinition,System.String) */, IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var, L_10, L_12, L_14);
		// }
		return;
	}
}
// UnityEngine.Purchasing.ProductCollection UnityEngine.Purchasing.PurchasingManager::get_products()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method)
{
	{
		// public ProductCollection products { get; private set; }
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_0 = __this->get_U3CproductsU3Ek__BackingField_8();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::set_products(UnityEngine.Purchasing.ProductCollection)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_set_products_m302D5E4CFC91CE9E1162063F0F260DC63EB026AD (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * ___value0, const RuntimeMethod* method)
{
	{
		// public ProductCollection products { get; private set; }
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_0 = ___value0;
		__this->set_U3CproductsU3Ek__BackingField_8(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::OnPurchaseSucceeded(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_OnPurchaseSucceeded_m93B8955249B645AA237ABAC9E09C632E48FCEFB8 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, String_t* ___id0, String_t* ___receipt1, String_t* ___transactionId2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_0 = NULL;
	{
		// var product = products.WithStoreSpecificID(id);
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_0;
		L_0 = PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline(__this, /*hidden argument*/NULL);
		String_t* L_1 = ___id0;
		NullCheck(L_0);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_2;
		L_2 = ProductCollection_WithStoreSpecificID_m6F49CE43D79C4DD72570EFFF2603BA6AFA97A0D4(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		// if (null == product)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_3 = V_0;
		if (L_3)
		{
			goto IL_0022;
		}
	}
	{
		// var definition = new ProductDefinition(id, ProductType.NonConsumable);
		String_t* L_4 = ___id0;
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_5 = (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *)il2cpp_codegen_object_new(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var);
		ProductDefinition__ctor_mE91946E2215B8A4D2045682518527F9C4721BFDD(L_5, L_4, 1, /*hidden argument*/NULL);
		// product = new Product(definition, new ProductMetadata());
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_6 = (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 *)il2cpp_codegen_object_new(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_il2cpp_TypeInfo_var);
		ProductMetadata__ctor_m7561EFECB866511CAE76597E34C9DFD34E0D3171(L_6, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_7 = (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *)il2cpp_codegen_object_new(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var);
		Product__ctor_m6417672E9F6ED21F6A9D5DA018EEA866AF8CFC9C(L_7, L_5, L_6, /*hidden argument*/NULL);
		V_0 = L_7;
	}

IL_0022:
	{
		// UpdateProductReceiptAndTrandsactionID(product, receipt, transactionId);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_8 = V_0;
		String_t* L_9 = ___receipt1;
		String_t* L_10 = ___transactionId2;
		PurchasingManager_UpdateProductReceiptAndTrandsactionID_m9D5BA8C8A65FD50C69D523733B98008C94579146(__this, L_8, L_9, L_10, /*hidden argument*/NULL);
		// ProcessPurchaseIfNew(product);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_11 = V_0;
		PurchasingManager_ProcessPurchaseIfNew_mCDE6D69367D34F7E7E20A1B4A5E5301DEB309B81(__this, L_11, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::UpdateProductReceiptAndTrandsactionID(UnityEngine.Purchasing.Product,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_UpdateProductReceiptAndTrandsactionID_m9D5BA8C8A65FD50C69D523733B98008C94579146 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, String_t* ___receipt1, String_t* ___transactionId2, const RuntimeMethod* method)
{
	{
		// if (product != null)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___product0;
		if (!L_0)
		{
			goto IL_0018;
		}
	}
	{
		// product.receipt = CreateUnifiedReceipt(receipt, transactionId);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_1 = ___product0;
		String_t* L_2 = ___receipt1;
		String_t* L_3 = ___transactionId2;
		String_t* L_4;
		L_4 = PurchasingManager_CreateUnifiedReceipt_mA5F66EA027EE9D8E96A13F096CEA3D4958FC8EC3(__this, L_2, L_3, /*hidden argument*/NULL);
		NullCheck(L_1);
		Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939_inline(L_1, L_4, /*hidden argument*/NULL);
		// product.transactionID = transactionId;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_5 = ___product0;
		String_t* L_6 = ___transactionId2;
		NullCheck(L_5);
		Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF_inline(L_5, L_6, /*hidden argument*/NULL);
	}

IL_0018:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::OnAllPurchasesRetrieved(System.Collections.Generic.List`1<UnityEngine.Purchasing.Product>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_OnAllPurchasesRetrieved_mBF1A0682F308EF8A325F886B9AE6E3CEF524B0AD (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA * ___purchasedProducts0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_FirstOrDefault_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_m3C9959CA12D5CE0709E77E76A00693D62C76735F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2__ctor_m509007DD57F653BAA3882037AB268CA3D7C5E053_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass23_0_U3COnAllPurchasesRetrievedU3Eb__0_m1ED6B42682A464C7B9336B43821D16738BC5A3B1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* V_0 = NULL;
	int32_t V_1 = 0;
	U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * V_2 = NULL;
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_3 = NULL;
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * G_B5_0 = NULL;
	{
		// if (products != null)
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_0;
		L_0 = PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline(__this, /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_0067;
		}
	}
	{
		// foreach (var product in products.all)
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_1;
		L_1 = PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_1);
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_2;
		L_2 = ProductCollection_get_all_m8F08A78D6AF774BE9A1A0C14E69747293EDC6E11_inline(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		V_1 = 0;
		goto IL_0061;
	}

IL_0018:
	{
		U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * L_3 = (U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass23_0__ctor_mACE5AC91204E137680F657F55F9278C899497A74(L_3, /*hidden argument*/NULL);
		V_2 = L_3;
		// foreach (var product in products.all)
		U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * L_4 = V_2;
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_5 = V_0;
		int32_t L_6 = V_1;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		NullCheck(L_4);
		L_4->set_product_0(L_8);
		// var purchasedProduct = purchasedProducts?.FirstOrDefault(firstPurchasedProduct => firstPurchasedProduct.definition.id == product.definition.id);
		List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA * L_9 = ___purchasedProducts0;
		if (L_9)
		{
			goto IL_002d;
		}
	}
	{
		G_B5_0 = ((Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *)(NULL));
		goto IL_003f;
	}

IL_002d:
	{
		List_1_tD6CD4E5E39E75EE330B0C6DB8A7A0AEE4966D8AA * L_10 = ___purchasedProducts0;
		U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * L_11 = V_2;
		Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06 * L_12 = (Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06 *)il2cpp_codegen_object_new(Func_2_t069D52252DAB356BD2BF76995697BEAF19B55D06_il2cpp_TypeInfo_var);
		Func_2__ctor_m509007DD57F653BAA3882037AB268CA3D7C5E053(L_12, L_11, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass23_0_U3COnAllPurchasesRetrievedU3Eb__0_m1ED6B42682A464C7B9336B43821D16738BC5A3B1_RuntimeMethod_var), /*hidden argument*/Func_2__ctor_m509007DD57F653BAA3882037AB268CA3D7C5E053_RuntimeMethod_var);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_13;
		L_13 = Enumerable_FirstOrDefault_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_m3C9959CA12D5CE0709E77E76A00693D62C76735F(L_10, L_12, /*hidden argument*/Enumerable_FirstOrDefault_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_m3C9959CA12D5CE0709E77E76A00693D62C76735F_RuntimeMethod_var);
		G_B5_0 = L_13;
	}

IL_003f:
	{
		V_3 = G_B5_0;
		// if (purchasedProduct != null)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_14 = V_3;
		if (!L_14)
		{
			goto IL_0052;
		}
	}
	{
		// HandlePurchaseRetrieved(product, purchasedProduct);
		U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * L_15 = V_2;
		NullCheck(L_15);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_16 = L_15->get_product_0();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_17 = V_3;
		PurchasingManager_HandlePurchaseRetrieved_mD9555DFEE135F475A3377676A934484121FA7E88(__this, L_16, L_17, /*hidden argument*/NULL);
		// }
		goto IL_005d;
	}

IL_0052:
	{
		// ClearProductReceipt(product);
		U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * L_18 = V_2;
		NullCheck(L_18);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_19 = L_18->get_product_0();
		PurchasingManager_ClearProductReceipt_m447D36D66C149C4A1944981005F1344E7D6AEFA9(L_19, /*hidden argument*/NULL);
	}

IL_005d:
	{
		int32_t L_20 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_20, (int32_t)1));
	}

IL_0061:
	{
		// foreach (var product in products.all)
		int32_t L_21 = V_1;
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_22 = V_0;
		NullCheck(L_22);
		if ((((int32_t)L_21) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_22)->max_length))))))
		{
			goto IL_0018;
		}
	}

IL_0067:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::HandlePurchaseRetrieved(UnityEngine.Purchasing.Product,UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_HandlePurchaseRetrieved_mD9555DFEE135F475A3377676A934484121FA7E88 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___purchasedProduct1, const RuntimeMethod* method)
{
	{
		// UpdateProductReceiptAndTrandsactionID(product, purchasedProduct.receipt, purchasedProduct.transactionID);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___product0;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_1 = ___purchasedProduct1;
		NullCheck(L_1);
		String_t* L_2;
		L_2 = Product_get_receipt_mEB9707DA0BF7F2D19DF9A0B2512B416FF89CB8C7_inline(L_1, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_3 = ___purchasedProduct1;
		NullCheck(L_3);
		String_t* L_4;
		L_4 = Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline(L_3, /*hidden argument*/NULL);
		PurchasingManager_UpdateProductReceiptAndTrandsactionID_m9D5BA8C8A65FD50C69D523733B98008C94579146(__this, L_0, L_2, L_4, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::ClearProductReceipt(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_ClearProductReceipt_m447D36D66C149C4A1944981005F1344E7D6AEFA9 (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method)
{
	{
		// product.receipt = null;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___product0;
		NullCheck(L_0);
		Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939_inline(L_0, (String_t*)NULL, /*hidden argument*/NULL);
		// product.transactionID = null;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_1 = ___product0;
		NullCheck(L_1);
		Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF_inline(L_1, (String_t*)NULL, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::OnSetupFailed(UnityEngine.Purchasing.InitializationFailureReason)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_OnSetupFailed_m3C47D121D10B99663FFD6BE099FBC07092183D99 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, int32_t ___reason0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_mD253810DCE8FE22D2D7CA13562023DD0CFA960AC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (initialized)
		bool L_0 = __this->get_initialized_9();
		if (!L_0)
		{
			goto IL_001d;
		}
	}
	{
		// if (null != m_AdditionalProductsFailCallback)
		Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983 * L_1 = __this->get_m_AdditionalProductsFailCallback_6();
		if (!L_1)
		{
			goto IL_0029;
		}
	}
	{
		// m_AdditionalProductsFailCallback(reason);
		Action_1_t20A1F01581736CB9E0AE5A814CCE17B106457983 * L_2 = __this->get_m_AdditionalProductsFailCallback_6();
		int32_t L_3 = ___reason0;
		NullCheck(L_2);
		Action_1_Invoke_mD253810DCE8FE22D2D7CA13562023DD0CFA960AC(L_2, L_3, /*hidden argument*/Action_1_Invoke_mD253810DCE8FE22D2D7CA13562023DD0CFA960AC_RuntimeMethod_var);
		// }
		return;
	}

IL_001d:
	{
		// m_Listener.OnInitializeFailed(reason);
		RuntimeObject* L_4 = __this->get_m_Listener_1();
		int32_t L_5 = ___reason0;
		NullCheck(L_4);
		InterfaceActionInvoker1< int32_t >::Invoke(0 /* System.Void UnityEngine.Purchasing.IInternalStoreListener::OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason) */, IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var, L_4, L_5);
	}

IL_0029:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::OnPurchaseFailed(UnityEngine.Purchasing.Extension.PurchaseFailureDescription)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_OnPurchaseFailed_m86F44450D38A242A89FC7F27FC7CBD7671E5E6D6 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * ___description0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PurchaseFailureReason_t92D34AB6DC07828C5204898759640EDFB9336BA5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral01178BFE3AE4B5082489FFCE9A716AC6B6F5F635);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0D0B37FF71B4D60D0DEBB7B5FC4A114D5D152406);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral36E11B7148F1843CD0462BD31F425C12CE582990);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9C03B7A4604CD518F2462F5F825D6BC63324F275);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC12B0525FE4A7F52BA51C6514949B9777123CD42);
		s_Il2CppMethodInitialized = true;
	}
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_0 = NULL;
	int32_t V_1 = 0;
	{
		// if (description != null)
		PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * L_0 = ___description0;
		if (!L_0)
		{
			goto IL_00ce;
		}
	}
	{
		// var product = products.WithStoreSpecificID(description.productId);
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_1;
		L_1 = PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline(__this, /*hidden argument*/NULL);
		PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * L_2 = ___description0;
		NullCheck(L_2);
		String_t* L_3;
		L_3 = PurchaseFailureDescription_get_productId_mDAE0C9E1F3A0144CF7A6728EDAC287009F483057_inline(L_2, /*hidden argument*/NULL);
		NullCheck(L_1);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_4;
		L_4 = ProductCollection_WithStoreSpecificID_m6F49CE43D79C4DD72570EFFF2603BA6AFA97A0D4(L_1, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		// if (null == product)
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_5 = V_0;
		if (L_5)
		{
			goto IL_0082;
		}
	}
	{
		// m_Logger.LogFormat(LogType.Error, "Failed to purchase unknown product {0}", "productId:" + description.productId + " reason:" + description.reason + " message:" + description.message);
		RuntimeObject* L_6 = __this->get_m_Logger_2();
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_7 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)1);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_8 = L_7;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_9 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)6);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_10 = L_9;
		NullCheck(L_10);
		ArrayElementTypeCheck (L_10, _stringLiteral01178BFE3AE4B5082489FFCE9A716AC6B6F5F635);
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteral01178BFE3AE4B5082489FFCE9A716AC6B6F5F635);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_11 = L_10;
		PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * L_12 = ___description0;
		NullCheck(L_12);
		String_t* L_13;
		L_13 = PurchaseFailureDescription_get_productId_mDAE0C9E1F3A0144CF7A6728EDAC287009F483057_inline(L_12, /*hidden argument*/NULL);
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, L_13);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_13);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_14 = L_11;
		NullCheck(L_14);
		ArrayElementTypeCheck (L_14, _stringLiteral9C03B7A4604CD518F2462F5F825D6BC63324F275);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral9C03B7A4604CD518F2462F5F825D6BC63324F275);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_15 = L_14;
		PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * L_16 = ___description0;
		NullCheck(L_16);
		int32_t L_17;
		L_17 = PurchaseFailureDescription_get_reason_m0EF61510E8851D12EA86FF0376DC4B99A7415E0F_inline(L_16, /*hidden argument*/NULL);
		V_1 = L_17;
		RuntimeObject * L_18 = Box(PurchaseFailureReason_t92D34AB6DC07828C5204898759640EDFB9336BA5_il2cpp_TypeInfo_var, (&V_1));
		NullCheck(L_18);
		String_t* L_19;
		L_19 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_18);
		V_1 = *(int32_t*)UnBox(L_18);
		NullCheck(L_15);
		ArrayElementTypeCheck (L_15, L_19);
		(L_15)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_19);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_20 = L_15;
		NullCheck(L_20);
		ArrayElementTypeCheck (L_20, _stringLiteral36E11B7148F1843CD0462BD31F425C12CE582990);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral36E11B7148F1843CD0462BD31F425C12CE582990);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_21 = L_20;
		PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * L_22 = ___description0;
		NullCheck(L_22);
		String_t* L_23;
		L_23 = PurchaseFailureDescription_get_message_mF5E354CE7F8BAEF0BE525EC30608A54F4607E504_inline(L_22, /*hidden argument*/NULL);
		NullCheck(L_21);
		ArrayElementTypeCheck (L_21, L_23);
		(L_21)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)L_23);
		String_t* L_24;
		L_24 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_21, /*hidden argument*/NULL);
		NullCheck(L_8);
		ArrayElementTypeCheck (L_8, L_24);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_24);
		NullCheck(L_6);
		InterfaceActionInvoker3< int32_t, String_t*, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* >::Invoke(8 /* System.Void UnityEngine.ILogger::LogFormat(UnityEngine.LogType,System.String,System.Object[]) */, ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var, L_6, 0, _stringLiteral0D0B37FF71B4D60D0DEBB7B5FC4A114D5D152406, L_8);
		// return;
		return;
	}

IL_0082:
	{
		// m_Logger.LogFormat(LogType.Warning, "onPurchaseFailedEvent({0})", "productId:" + product.definition.id + " message:" + description.message);
		RuntimeObject* L_25 = __this->get_m_Logger_2();
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_26 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)1);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_27 = L_26;
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_28 = V_0;
		NullCheck(L_28);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_29;
		L_29 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_28, /*hidden argument*/NULL);
		NullCheck(L_29);
		String_t* L_30;
		L_30 = ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline(L_29, /*hidden argument*/NULL);
		PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * L_31 = ___description0;
		NullCheck(L_31);
		String_t* L_32;
		L_32 = PurchaseFailureDescription_get_message_mF5E354CE7F8BAEF0BE525EC30608A54F4607E504_inline(L_31, /*hidden argument*/NULL);
		String_t* L_33;
		L_33 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(_stringLiteral01178BFE3AE4B5082489FFCE9A716AC6B6F5F635, L_30, _stringLiteral36E11B7148F1843CD0462BD31F425C12CE582990, L_32, /*hidden argument*/NULL);
		NullCheck(L_27);
		ArrayElementTypeCheck (L_27, L_33);
		(L_27)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_33);
		NullCheck(L_25);
		InterfaceActionInvoker3< int32_t, String_t*, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* >::Invoke(8 /* System.Void UnityEngine.ILogger::LogFormat(UnityEngine.LogType,System.String,System.Object[]) */, ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var, L_25, 2, _stringLiteralC12B0525FE4A7F52BA51C6514949B9777123CD42, L_27);
		// m_Listener.OnPurchaseFailed(product, description.reason);
		RuntimeObject* L_34 = __this->get_m_Listener_1();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_35 = V_0;
		PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * L_36 = ___description0;
		NullCheck(L_36);
		int32_t L_37;
		L_37 = PurchaseFailureDescription_get_reason_m0EF61510E8851D12EA86FF0376DC4B99A7415E0F_inline(L_36, /*hidden argument*/NULL);
		NullCheck(L_34);
		InterfaceActionInvoker2< Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *, int32_t >::Invoke(2 /* System.Void UnityEngine.Purchasing.IInternalStoreListener::OnPurchaseFailed(UnityEngine.Purchasing.Product,UnityEngine.Purchasing.PurchaseFailureReason) */, IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var, L_34, L_35, L_37);
	}

IL_00ce:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::OnProductsRetrieved(System.Collections.Generic.List`1<UnityEngine.Purchasing.Extension.ProductDescription>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_OnProductsRetrieved_m9945C663D5B445836DC4234D521290335BD272F7 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF * ___products0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_mF00BC099D6D9E176778EC76B9CBF3F521AE31E9B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_mEE376D71AB426CB6748F702E512B357FB483F455_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m0E0A041FD0428646F68B50259291381BEF627BFB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Add_m7D4C2485E000A367089991F01E0724430347AF82_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1__ctor_mF1247FA13C1F59B28E7048BFABB8E206D160FD64_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_get_Count_m6E973EE5C7480789B23EA6F34AEDE890E1AD0245_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_GetEnumerator_m9C1505A33FD0156C5CDED2CA7BAEB3BF1DE4E1FB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * V_0 = NULL;
	Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84  V_1;
	memset((&V_1), 0, sizeof(V_1));
	ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * V_2 = NULL;
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_3 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// var unknownProducts = new HashSet<Product>();
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_0 = (HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA *)il2cpp_codegen_object_new(HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA_il2cpp_TypeInfo_var);
		HashSet_1__ctor_mF1247FA13C1F59B28E7048BFABB8E206D160FD64(L_0, /*hidden argument*/HashSet_1__ctor_mF1247FA13C1F59B28E7048BFABB8E206D160FD64_RuntimeMethod_var);
		V_0 = L_0;
		// foreach (var product in products)
		List_1_t293A9B62DF9E931D44BF8E69475D79D308B627FF * L_1 = ___products0;
		NullCheck(L_1);
		Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84  L_2;
		L_2 = List_1_GetEnumerator_m9C1505A33FD0156C5CDED2CA7BAEB3BF1DE4E1FB(L_1, /*hidden argument*/List_1_GetEnumerator_m9C1505A33FD0156C5CDED2CA7BAEB3BF1DE4E1FB_RuntimeMethod_var);
		V_1 = L_2;
	}

IL_000d:
	try
	{ // begin try (depth: 1)
		{
			goto IL_009e;
		}

IL_0012:
		{
			// foreach (var product in products)
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_3;
			L_3 = Enumerator_get_Current_m0E0A041FD0428646F68B50259291381BEF627BFB_inline((Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 *)(&V_1), /*hidden argument*/Enumerator_get_Current_m0E0A041FD0428646F68B50259291381BEF627BFB_RuntimeMethod_var);
			V_2 = L_3;
			// var matchedProduct = this.products.WithStoreSpecificID(product.storeSpecificId);
			ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_4;
			L_4 = PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline(__this, /*hidden argument*/NULL);
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_5 = V_2;
			NullCheck(L_5);
			String_t* L_6;
			L_6 = ProductDescription_get_storeSpecificId_m805EE28C57C25664093C7F5C2FB24EAADFEAFB09_inline(L_5, /*hidden argument*/NULL);
			NullCheck(L_4);
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_7;
			L_7 = ProductCollection_WithStoreSpecificID_m6F49CE43D79C4DD72570EFFF2603BA6AFA97A0D4(L_4, L_6, /*hidden argument*/NULL);
			V_3 = L_7;
			// if (null == matchedProduct)
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_8 = V_3;
			if (L_8)
			{
				goto IL_005a;
			}
		}

IL_002f:
		{
			// var definition = new ProductDefinition(product.storeSpecificId,
			//         product.storeSpecificId, product.type);
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_9 = V_2;
			NullCheck(L_9);
			String_t* L_10;
			L_10 = ProductDescription_get_storeSpecificId_m805EE28C57C25664093C7F5C2FB24EAADFEAFB09_inline(L_9, /*hidden argument*/NULL);
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_11 = V_2;
			NullCheck(L_11);
			String_t* L_12;
			L_12 = ProductDescription_get_storeSpecificId_m805EE28C57C25664093C7F5C2FB24EAADFEAFB09_inline(L_11, /*hidden argument*/NULL);
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_13 = V_2;
			NullCheck(L_13);
			int32_t L_14 = L_13->get_type_1();
			ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_15 = (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *)il2cpp_codegen_object_new(ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_il2cpp_TypeInfo_var);
			ProductDefinition__ctor_mE256AE9F056EA9E401D0CB8DD80C3C2071827FA1(L_15, L_10, L_12, L_14, /*hidden argument*/NULL);
			// matchedProduct = new Product(definition, product.metadata);
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_16 = V_2;
			NullCheck(L_16);
			ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_17;
			L_17 = ProductDescription_get_metadata_m3638B035BE86738C71F776D7313827080557986B_inline(L_16, /*hidden argument*/NULL);
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_18 = (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *)il2cpp_codegen_object_new(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var);
			Product__ctor_m6417672E9F6ED21F6A9D5DA018EEA866AF8CFC9C(L_18, L_15, L_17, /*hidden argument*/NULL);
			V_3 = L_18;
			// unknownProducts.Add(matchedProduct);
			HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_19 = V_0;
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_20 = V_3;
			NullCheck(L_19);
			bool L_21;
			L_21 = HashSet_1_Add_m7D4C2485E000A367089991F01E0724430347AF82(L_19, L_20, /*hidden argument*/HashSet_1_Add_m7D4C2485E000A367089991F01E0724430347AF82_RuntimeMethod_var);
		}

IL_005a:
		{
			// matchedProduct.availableToPurchase = true;
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_22 = V_3;
			NullCheck(L_22);
			Product_set_availableToPurchase_m7C4954A4C675BE7DBC041D8928D4E66AEBBBE28C_inline(L_22, (bool)1, /*hidden argument*/NULL);
			// matchedProduct.metadata = product.metadata;
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_23 = V_3;
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_24 = V_2;
			NullCheck(L_24);
			ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_25;
			L_25 = ProductDescription_get_metadata_m3638B035BE86738C71F776D7313827080557986B_inline(L_24, /*hidden argument*/NULL);
			NullCheck(L_23);
			Product_set_metadata_m47CFE30071CD7DFC334749332B8C7869D08C18A4_inline(L_23, L_25, /*hidden argument*/NULL);
			// matchedProduct.transactionID = product.transactionId;
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_26 = V_3;
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_27 = V_2;
			NullCheck(L_27);
			String_t* L_28;
			L_28 = ProductDescription_get_transactionId_m88319BAE8BD3CC3E1D65E19370EE3EB9379BE93F_inline(L_27, /*hidden argument*/NULL);
			NullCheck(L_26);
			Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF_inline(L_26, L_28, /*hidden argument*/NULL);
			// if (!string.IsNullOrEmpty(product.receipt))
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_29 = V_2;
			NullCheck(L_29);
			String_t* L_30;
			L_30 = ProductDescription_get_receipt_m0D6C6B53F56F62B89399A156E392AF9AE1D53CC7_inline(L_29, /*hidden argument*/NULL);
			bool L_31;
			L_31 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_30, /*hidden argument*/NULL);
			if (L_31)
			{
				goto IL_009e;
			}
		}

IL_0086:
		{
			// matchedProduct.receipt = CreateUnifiedReceipt(product.receipt, product.transactionId);
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_32 = V_3;
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_33 = V_2;
			NullCheck(L_33);
			String_t* L_34;
			L_34 = ProductDescription_get_receipt_m0D6C6B53F56F62B89399A156E392AF9AE1D53CC7_inline(L_33, /*hidden argument*/NULL);
			ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * L_35 = V_2;
			NullCheck(L_35);
			String_t* L_36;
			L_36 = ProductDescription_get_transactionId_m88319BAE8BD3CC3E1D65E19370EE3EB9379BE93F_inline(L_35, /*hidden argument*/NULL);
			String_t* L_37;
			L_37 = PurchasingManager_CreateUnifiedReceipt_mA5F66EA027EE9D8E96A13F096CEA3D4958FC8EC3(__this, L_34, L_36, /*hidden argument*/NULL);
			NullCheck(L_32);
			Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939_inline(L_32, L_37, /*hidden argument*/NULL);
		}

IL_009e:
		{
			// foreach (var product in products)
			bool L_38;
			L_38 = Enumerator_MoveNext_mEE376D71AB426CB6748F702E512B357FB483F455((Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 *)(&V_1), /*hidden argument*/Enumerator_MoveNext_mEE376D71AB426CB6748F702E512B357FB483F455_RuntimeMethod_var);
			if (L_38)
			{
				goto IL_0012;
			}
		}

IL_00aa:
		{
			IL2CPP_LEAVE(0xBA, FINALLY_00ac);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_00ac;
	}

FINALLY_00ac:
	{ // begin finally (depth: 1)
		Enumerator_Dispose_mF00BC099D6D9E176778EC76B9CBF3F521AE31E9B((Enumerator_t3CA0E0FE0DB562F08785EE83A682E02E9B95EE84 *)(&V_1), /*hidden argument*/Enumerator_Dispose_mF00BC099D6D9E176778EC76B9CBF3F521AE31E9B_RuntimeMethod_var);
		IL2CPP_END_FINALLY(172)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(172)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xBA, IL_00ba)
	}

IL_00ba:
	{
		// if (unknownProducts.Count > 0)
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_39 = V_0;
		NullCheck(L_39);
		int32_t L_40;
		L_40 = HashSet_1_get_Count_m6E973EE5C7480789B23EA6F34AEDE890E1AD0245_inline(L_39, /*hidden argument*/HashSet_1_get_Count_m6E973EE5C7480789B23EA6F34AEDE890E1AD0245_RuntimeMethod_var);
		if ((((int32_t)L_40) <= ((int32_t)0)))
		{
			goto IL_00cf;
		}
	}
	{
		// this.products.AddProducts(unknownProducts);
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_41;
		L_41 = PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline(__this, /*hidden argument*/NULL);
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_42 = V_0;
		NullCheck(L_41);
		ProductCollection_AddProducts_m0BB3F5D30E6255BF2CC046EDE294CC19C7ADD1D0(L_41, L_42, /*hidden argument*/NULL);
	}

IL_00cf:
	{
		// CheckForInitialization();
		PurchasingManager_CheckForInitialization_m831821ACF5867F2979E82A51CD61BD08008E54BB(__this, /*hidden argument*/NULL);
		// ProcessPurchaseOnStart();
		PurchasingManager_ProcessPurchaseOnStart_mEB48CC9B7C636C6B3AE2CD75ED72247861863AF8(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.String UnityEngine.Purchasing.PurchasingManager::CreateUnifiedReceipt(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PurchasingManager_CreateUnifiedReceipt_mA5F66EA027EE9D8E96A13F096CEA3D4958FC8EC3 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, String_t* ___rawReceipt0, String_t* ___transactionId1, const RuntimeMethod* method)
{
	{
		// return UnifiedReceiptFormatter.FormatUnifiedReceipt(rawReceipt, transactionId, m_StoreName);
		String_t* L_0 = ___rawReceipt0;
		String_t* L_1 = ___transactionId1;
		String_t* L_2 = __this->get_m_StoreName_4();
		String_t* L_3;
		L_3 = UnifiedReceiptFormatter_FormatUnifiedReceipt_mD91359B583BEB06ACD63EE20F0B1F6495B266AE9(L_0, L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::ProcessPurchaseOnStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_ProcessPurchaseOnStart_mEB48CC9B7C636C6B3AE2CD75ED72247861863AF8 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_mECB624E9227DAD90587C5FB7547E0ABAC77E23A4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m34DE56BFFB93F822D883D63793D4F6EAF4746808_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m89F845C0B1EA66200DEA88D2FC1CEDB159B0489B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_GetEnumerator_mEA35B35D1D04D4D0640DEC29AFA49D6AA004E2F7_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809  V_0;
	memset((&V_0), 0, sizeof(V_0));
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_1 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// foreach (var product in products.set)
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_0;
		L_0 = PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_1;
		L_1 = ProductCollection_get_set_m59FB3EC03DCFA60FD4F6685381F2E1CF47358725_inline(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809  L_2;
		L_2 = HashSet_1_GetEnumerator_mEA35B35D1D04D4D0640DEC29AFA49D6AA004E2F7(L_1, /*hidden argument*/HashSet_1_GetEnumerator_mEA35B35D1D04D4D0640DEC29AFA49D6AA004E2F7_RuntimeMethod_var);
		V_0 = L_2;
	}

IL_0011:
	try
	{ // begin try (depth: 1)
		{
			goto IL_003c;
		}

IL_0013:
		{
			// foreach (var product in products.set)
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_3;
			L_3 = Enumerator_get_Current_m89F845C0B1EA66200DEA88D2FC1CEDB159B0489B_inline((Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *)(&V_0), /*hidden argument*/Enumerator_get_Current_m89F845C0B1EA66200DEA88D2FC1CEDB159B0489B_RuntimeMethod_var);
			V_1 = L_3;
			// if (!string.IsNullOrEmpty(product.receipt) && !string.IsNullOrEmpty(product.transactionID))
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_4 = V_1;
			NullCheck(L_4);
			String_t* L_5;
			L_5 = Product_get_receipt_mEB9707DA0BF7F2D19DF9A0B2512B416FF89CB8C7_inline(L_4, /*hidden argument*/NULL);
			bool L_6;
			L_6 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_5, /*hidden argument*/NULL);
			if (L_6)
			{
				goto IL_003c;
			}
		}

IL_0028:
		{
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_7 = V_1;
			NullCheck(L_7);
			String_t* L_8;
			L_8 = Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline(L_7, /*hidden argument*/NULL);
			bool L_9;
			L_9 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_8, /*hidden argument*/NULL);
			if (L_9)
			{
				goto IL_003c;
			}
		}

IL_0035:
		{
			// ProcessPurchaseIfNew(product);
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_10 = V_1;
			PurchasingManager_ProcessPurchaseIfNew_mCDE6D69367D34F7E7E20A1B4A5E5301DEB309B81(__this, L_10, /*hidden argument*/NULL);
		}

IL_003c:
		{
			// foreach (var product in products.set)
			bool L_11;
			L_11 = Enumerator_MoveNext_m34DE56BFFB93F822D883D63793D4F6EAF4746808((Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *)(&V_0), /*hidden argument*/Enumerator_MoveNext_m34DE56BFFB93F822D883D63793D4F6EAF4746808_RuntimeMethod_var);
			if (L_11)
			{
				goto IL_0013;
			}
		}

IL_0045:
		{
			IL2CPP_LEAVE(0x55, FINALLY_0047);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0047;
	}

FINALLY_0047:
	{ // begin finally (depth: 1)
		Enumerator_Dispose_mECB624E9227DAD90587C5FB7547E0ABAC77E23A4((Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *)(&V_0), /*hidden argument*/Enumerator_Dispose_mECB624E9227DAD90587C5FB7547E0ABAC77E23A4_RuntimeMethod_var);
		IL2CPP_END_FINALLY(71)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(71)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x55, IL_0055)
	}

IL_0055:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::ProcessPurchaseIfNew(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_ProcessPurchaseIfNew_mCDE6D69367D34F7E7E20A1B4A5E5301DEB309B81 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___product0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * V_0 = NULL;
	{
		// if (useTransactionLog && m_TransactionLog.HasRecordOf(product.transactionID))
		bool L_0;
		L_0 = PurchasingManager_get_useTransactionLog_mB8E7472617FCBD4BA5C910F4D5D5FFB6A0A6BADF_inline(__this, /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_0033;
		}
	}
	{
		TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * L_1 = __this->get_m_TransactionLog_3();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_2 = ___product0;
		NullCheck(L_2);
		String_t* L_3;
		L_3 = Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline(L_2, /*hidden argument*/NULL);
		NullCheck(L_1);
		bool L_4;
		L_4 = TransactionLog_HasRecordOf_m7086CC4A600D584BE9954FB9684A1E80FDD5F02B(L_1, L_3, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_0033;
		}
	}
	{
		// m_Store.FinishTransaction(product.definition, product.transactionID);
		RuntimeObject* L_5 = __this->get_m_Store_0();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_6 = ___product0;
		NullCheck(L_6);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_7;
		L_7 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_6, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_8 = ___product0;
		NullCheck(L_8);
		String_t* L_9;
		L_9 = Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline(L_8, /*hidden argument*/NULL);
		NullCheck(L_5);
		InterfaceActionInvoker2< ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 *, String_t* >::Invoke(3 /* System.Void UnityEngine.Purchasing.Extension.IStore::FinishTransaction(UnityEngine.Purchasing.ProductDefinition,System.String) */, IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var, L_5, L_7, L_9);
		// return;
		return;
	}

IL_0033:
	{
		// var p = new PurchaseEventArgs(product);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_10 = ___product0;
		PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * L_11 = (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 *)il2cpp_codegen_object_new(PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114_il2cpp_TypeInfo_var);
		PurchaseEventArgs__ctor_m8B7ED6ABBC91A602EBD4B4442173C29D372AF4D1(L_11, L_10, /*hidden argument*/NULL);
		V_0 = L_11;
		// if (PurchaseProcessingResult.Complete == m_Listener.ProcessPurchase(p))
		RuntimeObject* L_12 = __this->get_m_Listener_1();
		PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * L_13 = V_0;
		NullCheck(L_12);
		int32_t L_14;
		L_14 = InterfaceFuncInvoker1< int32_t, PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * >::Invoke(1 /* UnityEngine.Purchasing.PurchaseProcessingResult UnityEngine.Purchasing.IInternalStoreListener::ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs) */, IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var, L_12, L_13);
		if (L_14)
		{
			goto IL_004f;
		}
	}
	{
		// ConfirmPendingPurchase(product);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_15 = ___product0;
		PurchasingManager_ConfirmPendingPurchase_m891FE9D820139B48C2C469CB12D103664E45ED43(__this, L_15, /*hidden argument*/NULL);
	}

IL_004f:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::CheckForInitialization()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_CheckForInitialization_m831821ACF5867F2979E82A51CD61BD08008E54BB (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (!initialized)
		bool L_0 = __this->get_initialized_9();
		if (L_0)
		{
			goto IL_002e;
		}
	}
	{
		// var hasAvailableProductsToPurchase = HasAvailableProductsToPurchase();
		bool L_1;
		L_1 = PurchasingManager_HasAvailableProductsToPurchase_mA23998827E0C5EBF5987F05AF9A800CEA3A0B12A(__this, (bool)1, /*hidden argument*/NULL);
		// if (hasAvailableProductsToPurchase)
		if (!L_1)
		{
			goto IL_001f;
		}
	}
	{
		// m_Listener.OnInitialized(this);
		RuntimeObject* L_2 = __this->get_m_Listener_1();
		NullCheck(L_2);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(3 /* System.Void UnityEngine.Purchasing.IInternalStoreListener::OnInitialized(UnityEngine.Purchasing.IStoreController) */, IInternalStoreListener_tABF6BC66B60AB7BADE4B9BE2326D1E6439642417_il2cpp_TypeInfo_var, L_2, __this);
		// }
		goto IL_0026;
	}

IL_001f:
	{
		// OnSetupFailed(InitializationFailureReason.NoProductsAvailable);
		PurchasingManager_OnSetupFailed_m3C47D121D10B99663FFD6BE099FBC07092183D99(__this, 1, /*hidden argument*/NULL);
	}

IL_0026:
	{
		// initialized = true;
		__this->set_initialized_9((bool)1);
		// }
		return;
	}

IL_002e:
	{
		// if (null != m_AdditionalProductsCallback)
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_3 = __this->get_m_AdditionalProductsCallback_5();
		if (!L_3)
		{
			goto IL_0041;
		}
	}
	{
		// m_AdditionalProductsCallback();
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_4 = __this->get_m_AdditionalProductsCallback_5();
		NullCheck(L_4);
		Action_Invoke_m3FFA5BE3D64F0FF8E1E1CB6F953913FADB5EB89E(L_4, /*hidden argument*/NULL);
	}

IL_0041:
	{
		// }
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.PurchasingManager::HasAvailableProductsToPurchase(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PurchasingManager_HasAvailableProductsToPurchase_mA23998827E0C5EBF5987F05AF9A800CEA3A0B12A (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, bool ___shouldLogUnavailableProducts0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_mECB624E9227DAD90587C5FB7547E0ABAC77E23A4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m34DE56BFFB93F822D883D63793D4F6EAF4746808_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m89F845C0B1EA66200DEA88D2FC1CEDB159B0489B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_GetEnumerator_mEA35B35D1D04D4D0640DEC29AFA49D6AA004E2F7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral89C49DC40879EC998EC0B3FD9E005123B80E7297);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809  V_1;
	memset((&V_1), 0, sizeof(V_1));
	Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * V_2 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// var available = false;
		V_0 = (bool)0;
		// foreach (var product in products.set)
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_0;
		L_0 = PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_1;
		L_1 = ProductCollection_get_set_m59FB3EC03DCFA60FD4F6685381F2E1CF47358725_inline(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809  L_2;
		L_2 = HashSet_1_GetEnumerator_mEA35B35D1D04D4D0640DEC29AFA49D6AA004E2F7(L_1, /*hidden argument*/HashSet_1_GetEnumerator_mEA35B35D1D04D4D0640DEC29AFA49D6AA004E2F7_RuntimeMethod_var);
		V_1 = L_2;
	}

IL_0013:
	try
	{ // begin try (depth: 1)
		{
			goto IL_005f;
		}

IL_0015:
		{
			// foreach (var product in products.set)
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_3;
			L_3 = Enumerator_get_Current_m89F845C0B1EA66200DEA88D2FC1CEDB159B0489B_inline((Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *)(&V_1), /*hidden argument*/Enumerator_get_Current_m89F845C0B1EA66200DEA88D2FC1CEDB159B0489B_RuntimeMethod_var);
			V_2 = L_3;
			// if (product.availableToPurchase)
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_4 = V_2;
			NullCheck(L_4);
			bool L_5;
			L_5 = Product_get_availableToPurchase_mBAB83F4E1E276628EA5948A67C2F79F31A003CBF_inline(L_4, /*hidden argument*/NULL);
			if (!L_5)
			{
				goto IL_0029;
			}
		}

IL_0025:
		{
			// available = true;
			V_0 = (bool)1;
			// }
			goto IL_005f;
		}

IL_0029:
		{
			// else if (shouldLogUnavailableProducts)
			bool L_6 = ___shouldLogUnavailableProducts0;
			if (!L_6)
			{
				goto IL_005f;
			}
		}

IL_002c:
		{
			// m_Logger.LogFormat(LogType.Warning, "Unavailable product {0}-{1}", product.definition.id, product.definition.storeSpecificId);
			RuntimeObject* L_7 = __this->get_m_Logger_2();
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_8 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)2);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_9 = L_8;
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_10 = V_2;
			NullCheck(L_10);
			ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_11;
			L_11 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_10, /*hidden argument*/NULL);
			NullCheck(L_11);
			String_t* L_12;
			L_12 = ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline(L_11, /*hidden argument*/NULL);
			NullCheck(L_9);
			ArrayElementTypeCheck (L_9, L_12);
			(L_9)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_12);
			ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_13 = L_9;
			Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_14 = V_2;
			NullCheck(L_14);
			ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_15;
			L_15 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_14, /*hidden argument*/NULL);
			NullCheck(L_15);
			String_t* L_16;
			L_16 = ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6_inline(L_15, /*hidden argument*/NULL);
			NullCheck(L_13);
			ArrayElementTypeCheck (L_13, L_16);
			(L_13)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_16);
			NullCheck(L_7);
			InterfaceActionInvoker3< int32_t, String_t*, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* >::Invoke(8 /* System.Void UnityEngine.ILogger::LogFormat(UnityEngine.LogType,System.String,System.Object[]) */, ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var, L_7, 2, _stringLiteral89C49DC40879EC998EC0B3FD9E005123B80E7297, L_13);
		}

IL_005f:
		{
			// foreach (var product in products.set)
			bool L_17;
			L_17 = Enumerator_MoveNext_m34DE56BFFB93F822D883D63793D4F6EAF4746808((Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *)(&V_1), /*hidden argument*/Enumerator_MoveNext_m34DE56BFFB93F822D883D63793D4F6EAF4746808_RuntimeMethod_var);
			if (L_17)
			{
				goto IL_0015;
			}
		}

IL_0068:
		{
			IL2CPP_LEAVE(0x78, FINALLY_006a);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_006a;
	}

FINALLY_006a:
	{ // begin finally (depth: 1)
		Enumerator_Dispose_mECB624E9227DAD90587C5FB7547E0ABAC77E23A4((Enumerator_tA3BA417B427D6BC82D93E1D0B1CB6005F7761809 *)(&V_1), /*hidden argument*/Enumerator_Dispose_mECB624E9227DAD90587C5FB7547E0ABAC77E23A4_RuntimeMethod_var);
		IL2CPP_END_FINALLY(106)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(106)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x78, IL_0078)
	}

IL_0078:
	{
		// return available;
		bool L_18 = V_0;
		return L_18;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager::Initialize(UnityEngine.Purchasing.IInternalStoreListener,System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PurchasingManager_Initialize_m9E1231D1B39759CD83D74A42F7F87DB2AB8A2840 (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, RuntimeObject* ___listener0, HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___products1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_Select_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mC47E532FD81FF155A9AD9CE8E139BFA2992B7CFF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_ToArray_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mEE2FE11BDD311009011FF50D0BACC5AA3C07BE1C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_ToList_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_m01AA1776DEE25E5683AAC0EFB71501BA03745774_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2__ctor_mC0A642D3F07FB566E56D3E4395C6E7A53093DE9C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReadOnlyCollection_1__ctor_m0B811F745C2789AF0A5DE025161C795ADCA5A960_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_U3CInitializeU3Eb__36_0_m2FBA72637489C224FF4714F2F72AEBE55BE31C86_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* V_0 = NULL;
	ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3 * V_1 = NULL;
	Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * G_B2_0 = NULL;
	HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * G_B2_1 = NULL;
	Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * G_B1_0 = NULL;
	HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * G_B1_1 = NULL;
	{
		// m_Listener = listener;
		RuntimeObject* L_0 = ___listener0;
		__this->set_m_Listener_1(L_0);
		// m_Store.Initialize(this);
		RuntimeObject* L_1 = __this->get_m_Store_0();
		NullCheck(L_1);
		InterfaceActionInvoker1< RuntimeObject* >::Invoke(0 /* System.Void UnityEngine.Purchasing.Extension.IStore::Initialize(UnityEngine.Purchasing.Extension.IStoreCallback) */, IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var, L_1, __this);
		// var prods = products.Select(x => new Product(x, new ProductMetadata())).ToArray();
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_2 = ___products1;
		IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var);
		Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * L_3 = ((U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var))->get_U3CU3E9__36_0_1();
		Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * L_4 = L_3;
		G_B1_0 = L_4;
		G_B1_1 = L_2;
		if (L_4)
		{
			G_B2_0 = L_4;
			G_B2_1 = L_2;
			goto IL_0033;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var);
		U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 * L_5 = ((U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var))->get_U3CU3E9_0();
		Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * L_6 = (Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 *)il2cpp_codegen_object_new(Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2_il2cpp_TypeInfo_var);
		Func_2__ctor_mC0A642D3F07FB566E56D3E4395C6E7A53093DE9C(L_6, L_5, (intptr_t)((intptr_t)U3CU3Ec_U3CInitializeU3Eb__36_0_m2FBA72637489C224FF4714F2F72AEBE55BE31C86_RuntimeMethod_var), /*hidden argument*/Func_2__ctor_mC0A642D3F07FB566E56D3E4395C6E7A53093DE9C_RuntimeMethod_var);
		Func_2_t5298DCB4B742C2E951D64232284082578A81A0F2 * L_7 = L_6;
		((U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var))->set_U3CU3E9__36_0_1(L_7);
		G_B2_0 = L_7;
		G_B2_1 = G_B1_1;
	}

IL_0033:
	{
		RuntimeObject* L_8;
		L_8 = Enumerable_Select_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mC47E532FD81FF155A9AD9CE8E139BFA2992B7CFF(G_B2_1, G_B2_0, /*hidden argument*/Enumerable_Select_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mC47E532FD81FF155A9AD9CE8E139BFA2992B7CFF_RuntimeMethod_var);
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_9;
		L_9 = Enumerable_ToArray_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mEE2FE11BDD311009011FF50D0BACC5AA3C07BE1C(L_8, /*hidden argument*/Enumerable_ToArray_TisProduct_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_mEE2FE11BDD311009011FF50D0BACC5AA3C07BE1C_RuntimeMethod_var);
		V_0 = L_9;
		// this.products = new ProductCollection(prods);
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_10 = V_0;
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_11 = (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C *)il2cpp_codegen_object_new(ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C_il2cpp_TypeInfo_var);
		ProductCollection__ctor_mA5BA7263EBF8B3614EA01852105640CE9D1D2D1E(L_11, L_10, /*hidden argument*/NULL);
		PurchasingManager_set_products_m302D5E4CFC91CE9E1162063F0F260DC63EB026AD_inline(__this, L_11, /*hidden argument*/NULL);
		// var productCollection = new ReadOnlyCollection<ProductDefinition>(products.ToList());
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_12 = ___products1;
		List_1_tDD11FDCDDCA59BDB033D0E2B42EB7E6EF661C0F5 * L_13;
		L_13 = Enumerable_ToList_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_m01AA1776DEE25E5683AAC0EFB71501BA03745774(L_12, /*hidden argument*/Enumerable_ToList_TisProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572_m01AA1776DEE25E5683AAC0EFB71501BA03745774_RuntimeMethod_var);
		ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3 * L_14 = (ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3 *)il2cpp_codegen_object_new(ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3_il2cpp_TypeInfo_var);
		ReadOnlyCollection_1__ctor_m0B811F745C2789AF0A5DE025161C795ADCA5A960(L_14, L_13, /*hidden argument*/ReadOnlyCollection_1__ctor_m0B811F745C2789AF0A5DE025161C795ADCA5A960_RuntimeMethod_var);
		V_1 = L_14;
		// m_Store.RetrieveProducts(productCollection);
		RuntimeObject* L_15 = __this->get_m_Store_0();
		ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3 * L_16 = V_1;
		NullCheck(L_15);
		InterfaceActionInvoker1< ReadOnlyCollection_1_tA17CC77D8AB24DD29DF396C7B3CC305302C189C3 * >::Invoke(1 /* System.Void UnityEngine.Purchasing.Extension.IStore::RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Purchasing.ProductDefinition>) */, IStore_tCEF0F12ABAEB669C05EFD4FA40A31BAAC6F4B51E_il2cpp_TypeInfo_var, L_15, L_16);
		// }
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
// System.Void UnityEngine.Purchasing.StoreListenerProxy::.ctor(UnityEngine.Purchasing.IStoreListener,UnityEngine.Purchasing.AnalyticsReporter,UnityEngine.Purchasing.IExtensionProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StoreListenerProxy__ctor_mBCC694AD6F19AF0B686F84F9F35A489B7745B7C5 (StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * __this, RuntimeObject* ___forwardTo0, AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * ___analytics1, RuntimeObject* ___extensions2, const RuntimeMethod* method)
{
	{
		// public StoreListenerProxy(IStoreListener forwardTo, AnalyticsReporter analytics, IExtensionProvider extensions)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// m_ForwardTo = forwardTo;
		RuntimeObject* L_0 = ___forwardTo0;
		__this->set_m_ForwardTo_1(L_0);
		// m_Analytics = analytics;
		AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * L_1 = ___analytics1;
		__this->set_m_Analytics_0(L_1);
		// m_Extensions = extensions;
		RuntimeObject* L_2 = ___extensions2;
		__this->set_m_Extensions_2(L_2);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.StoreListenerProxy::OnInitialized(UnityEngine.Purchasing.IStoreController)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StoreListenerProxy_OnInitialized_m895D4536EE045C7C9DEC0A1F691969BEEBB56234 (StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * __this, RuntimeObject* ___controller0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_ForwardTo.OnInitialized(controller, m_Extensions);
		RuntimeObject* L_0 = __this->get_m_ForwardTo_1();
		RuntimeObject* L_1 = ___controller0;
		RuntimeObject* L_2 = __this->get_m_Extensions_2();
		NullCheck(L_0);
		InterfaceActionInvoker2< RuntimeObject*, RuntimeObject* >::Invoke(3 /* System.Void UnityEngine.Purchasing.IStoreListener::OnInitialized(UnityEngine.Purchasing.IStoreController,UnityEngine.Purchasing.IExtensionProvider) */, IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var, L_0, L_1, L_2);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.StoreListenerProxy::OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StoreListenerProxy_OnInitializeFailed_mD884A06D78F27080B1C4B7230F5D922927022452 (StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * __this, int32_t ___error0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_ForwardTo.OnInitializeFailed(error);
		RuntimeObject* L_0 = __this->get_m_ForwardTo_1();
		int32_t L_1 = ___error0;
		NullCheck(L_0);
		InterfaceActionInvoker1< int32_t >::Invoke(0 /* System.Void UnityEngine.Purchasing.IStoreListener::OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason) */, IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var, L_0, L_1);
		// }
		return;
	}
}
// UnityEngine.Purchasing.PurchaseProcessingResult UnityEngine.Purchasing.StoreListenerProxy::ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t StoreListenerProxy_ProcessPurchase_m97AEB27C4793C16DE0C90C3931FA653C22988335 (StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * __this, PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * ___e0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_Analytics.OnPurchaseSucceeded(e.purchasedProduct);
		AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * L_0 = __this->get_m_Analytics_0();
		PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * L_1 = ___e0;
		NullCheck(L_1);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_2;
		L_2 = PurchaseEventArgs_get_purchasedProduct_m82395AF6B8EB5A4747C638287821893F2D31D355_inline(L_1, /*hidden argument*/NULL);
		NullCheck(L_0);
		AnalyticsReporter_OnPurchaseSucceeded_mBF9872A9CB357375E14A0948C07079F927901130(L_0, L_2, /*hidden argument*/NULL);
		// return m_ForwardTo.ProcessPurchase(e);
		RuntimeObject* L_3 = __this->get_m_ForwardTo_1();
		PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * L_4 = ___e0;
		NullCheck(L_3);
		int32_t L_5;
		L_5 = InterfaceFuncInvoker1< int32_t, PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * >::Invoke(1 /* UnityEngine.Purchasing.PurchaseProcessingResult UnityEngine.Purchasing.IStoreListener::ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs) */, IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var, L_3, L_4);
		return L_5;
	}
}
// System.Void UnityEngine.Purchasing.StoreListenerProxy::OnPurchaseFailed(UnityEngine.Purchasing.Product,UnityEngine.Purchasing.PurchaseFailureReason)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StoreListenerProxy_OnPurchaseFailed_m5B4547EB124BC10D2034DC60BD379B83CBC5EB95 (StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___i0, int32_t ___p1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_Analytics.OnPurchaseFailed(i, p);
		AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * L_0 = __this->get_m_Analytics_0();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_1 = ___i0;
		int32_t L_2 = ___p1;
		NullCheck(L_0);
		AnalyticsReporter_OnPurchaseFailed_mDBC18A9A51370DFA084D7AF1D85AB0086665AB97(L_0, L_1, L_2, /*hidden argument*/NULL);
		// m_ForwardTo.OnPurchaseFailed(i, p);
		RuntimeObject* L_3 = __this->get_m_ForwardTo_1();
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_4 = ___i0;
		int32_t L_5 = ___p1;
		NullCheck(L_3);
		InterfaceActionInvoker2< Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *, int32_t >::Invoke(2 /* System.Void UnityEngine.Purchasing.IStoreListener::OnPurchaseFailed(UnityEngine.Purchasing.Product,UnityEngine.Purchasing.PurchaseFailureReason) */, IStoreListener_t13D28A8F0959FCB6067361D7DA536E6CC8E3B506_il2cpp_TypeInfo_var, L_3, L_4, L_5);
		// }
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
// System.Void UnityEngine.Purchasing.TransactionLog::.ctor(UnityEngine.ILogger,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransactionLog__ctor_m69D721C1EDECA02889EF962DC5077FE3CD176863 (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * __this, RuntimeObject* ___logger0, String_t* ___persistentDataPath1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_tF1D95B78D57C1C1211BA6633FF2AC22FD6C48921_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0E768DF5448A939C90FD26493F20E5402437A92E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9AC36C3A3EC82C292FD998FA2F3C73EFBC571F3A);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public TransactionLog(ILogger logger, string persistentDataPath)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this.logger = logger;
		RuntimeObject* L_0 = ___logger0;
		__this->set_logger_0(L_0);
		// if (!string.IsNullOrEmpty(persistentDataPath))
		String_t* L_1 = ___persistentDataPath1;
		bool L_2;
		L_2 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_1, /*hidden argument*/NULL);
		if (L_2)
		{
			goto IL_0030;
		}
	}
	{
		// this.persistentDataPath = Path.Combine(Path.Combine(persistentDataPath, "Unity"), "UnityPurchasing");
		String_t* L_3 = ___persistentDataPath1;
		IL2CPP_RUNTIME_CLASS_INIT(Path_tF1D95B78D57C1C1211BA6633FF2AC22FD6C48921_il2cpp_TypeInfo_var);
		String_t* L_4;
		L_4 = Path_Combine_mC22E47A9BB232F02ED3B6B5F6DD53338D37782EF(L_3, _stringLiteral9AC36C3A3EC82C292FD998FA2F3C73EFBC571F3A, /*hidden argument*/NULL);
		String_t* L_5;
		L_5 = Path_Combine_mC22E47A9BB232F02ED3B6B5F6DD53338D37782EF(L_4, _stringLiteral0E768DF5448A939C90FD26493F20E5402437A92E, /*hidden argument*/NULL);
		__this->set_persistentDataPath_1(L_5);
	}

IL_0030:
	{
		// }
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.TransactionLog::HasRecordOf(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TransactionLog_HasRecordOf_m7086CC4A600D584BE9954FB9684A1E80FDD5F02B (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * __this, String_t* ___transactionID0, const RuntimeMethod* method)
{
	{
		// if (string.IsNullOrEmpty(transactionID) || string.IsNullOrEmpty(persistentDataPath))
		String_t* L_0 = ___transactionID0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_0015;
		}
	}
	{
		String_t* L_2 = __this->get_persistentDataPath_1();
		bool L_3;
		L_3 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_2, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0017;
		}
	}

IL_0015:
	{
		// return false;
		return (bool)0;
	}

IL_0017:
	{
		// return Directory.Exists(GetRecordPath(transactionID));
		String_t* L_4 = ___transactionID0;
		String_t* L_5;
		L_5 = TransactionLog_GetRecordPath_m942A71AC05728018B92D3F9130F681CC63EF2F45(__this, L_4, /*hidden argument*/NULL);
		bool L_6;
		L_6 = Directory_Exists_m17E38B91F6D9A0064D614FF2237BBFC0127468FE(L_5, /*hidden argument*/NULL);
		return L_6;
	}
}
// System.Void UnityEngine.Purchasing.TransactionLog::Record(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TransactionLog_Record_m7CDAC959A14AD174B4C33255F2BA013349883895 (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * __this, String_t* ___transactionID0, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	Exception_t * V_1 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
		// if (!(string.IsNullOrEmpty(transactionID) || string.IsNullOrEmpty(persistentDataPath)))
		String_t* L_0 = ___transactionID0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_0035;
		}
	}
	{
		String_t* L_2 = __this->get_persistentDataPath_1();
		bool L_3;
		L_3 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_2, /*hidden argument*/NULL);
		if (L_3)
		{
			goto IL_0035;
		}
	}
	{
		// var path = GetRecordPath(transactionID);
		String_t* L_4 = ___transactionID0;
		String_t* L_5;
		L_5 = TransactionLog_GetRecordPath_m942A71AC05728018B92D3F9130F681CC63EF2F45(__this, L_4, /*hidden argument*/NULL);
		V_0 = L_5;
	}

IL_001d:
	try
	{ // begin try (depth: 1)
		// Directory.CreateDirectory(path);
		String_t* L_6 = V_0;
		DirectoryInfo_t4EF3610F45F0D234800D01ADA8F3F476AE0CF5CD * L_7;
		L_7 = Directory_CreateDirectory_m38040338519C48CE52137CC146372A153D5C6A7A(L_6, /*hidden argument*/NULL);
		// }
		goto IL_0035;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0026;
		}
		throw e;
	}

CATCH_0026:
	{ // begin catch(System.Exception)
		// catch (Exception recordPathException)
		V_1 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		// logger.LogException(recordPathException);
		RuntimeObject* L_8 = __this->get_logger_0();
		Exception_t * L_9 = V_1;
		NullCheck(L_8);
		InterfaceActionInvoker1< Exception_t * >::Invoke(9 /* System.Void UnityEngine.ILogger::LogException(System.Exception) */, ((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ILogger_t25627AC5B51863702868D31972297B7D633B4583_il2cpp_TypeInfo_var)), L_8, L_9);
		// }
		IL2CPP_POP_ACTIVE_EXCEPTION();
		goto IL_0035;
	} // end catch (depth: 1)

IL_0035:
	{
		// }
		return;
	}
}
// System.String UnityEngine.Purchasing.TransactionLog::GetRecordPath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TransactionLog_GetRecordPath_m942A71AC05728018B92D3F9130F681CC63EF2F45 (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * __this, String_t* ___transactionID0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_tF1D95B78D57C1C1211BA6633FF2AC22FD6C48921_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return Path.Combine(persistentDataPath, ComputeHash(transactionID));
		String_t* L_0 = __this->get_persistentDataPath_1();
		String_t* L_1 = ___transactionID0;
		String_t* L_2;
		L_2 = TransactionLog_ComputeHash_m26E7E1369870C738E5158FA9B8B522CDD39993E8(L_1, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Path_tF1D95B78D57C1C1211BA6633FF2AC22FD6C48921_il2cpp_TypeInfo_var);
		String_t* L_3;
		L_3 = Path_Combine_mC22E47A9BB232F02ED3B6B5F6DD53338D37782EF(L_0, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// System.String UnityEngine.Purchasing.TransactionLog::ComputeHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TransactionLog_ComputeHash_m26E7E1369870C738E5158FA9B8B522CDD39993E8 (String_t* ___transactionID0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BitConverter_t8DCBA24B909F1B221372AF2B37C76DCF614BA654_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDD638980A42773DBA4D111CE8D3979093BAC27E5);
		s_Il2CppMethodInitialized = true;
	}
	uint64_t V_0 = 0;
	StringBuilder_t * V_1 = NULL;
	int32_t V_2 = 0;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_3 = NULL;
	int32_t V_4 = 0;
	uint8_t V_5 = 0x0;
	{
		// UInt64 hash = 3074457345618258791ul;
		V_0 = ((int64_t)3074457345618258791LL);
		// for (int i = 0; i < transactionID.Length; i++)
		V_2 = 0;
		goto IL_0029;
	}

IL_000e:
	{
		// hash += transactionID[i];
		uint64_t L_0 = V_0;
		String_t* L_1 = ___transactionID0;
		int32_t L_2 = V_2;
		NullCheck(L_1);
		Il2CppChar L_3;
		L_3 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_1, L_2, /*hidden argument*/NULL);
		V_0 = ((int64_t)il2cpp_codegen_add((int64_t)L_0, (int64_t)((int64_t)((uint64_t)L_3))));
		// hash *= 3074457345618258799ul;
		uint64_t L_4 = V_0;
		V_0 = ((int64_t)il2cpp_codegen_multiply((int64_t)L_4, (int64_t)((int64_t)3074457345618258799LL)));
		// for (int i = 0; i < transactionID.Length; i++)
		int32_t L_5 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_5, (int32_t)1));
	}

IL_0029:
	{
		// for (int i = 0; i < transactionID.Length; i++)
		int32_t L_6 = V_2;
		String_t* L_7 = ___transactionID0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_7, /*hidden argument*/NULL);
		if ((((int32_t)L_6) < ((int32_t)L_8)))
		{
			goto IL_000e;
		}
	}
	{
		// StringBuilder builder = new StringBuilder(16);
		StringBuilder_t * L_9 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_mEDFFE2D378A15F6DAB54D52661C84C1B52E7BA2E(L_9, ((int32_t)16), /*hidden argument*/NULL);
		V_1 = L_9;
		// foreach (byte b in BitConverter.GetBytes(hash))
		uint64_t L_10 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(BitConverter_t8DCBA24B909F1B221372AF2B37C76DCF614BA654_il2cpp_TypeInfo_var);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_11;
		L_11 = BitConverter_GetBytes_mFAF80F30CFF838A062D9740EB200372693481E1F(L_10, /*hidden argument*/NULL);
		V_3 = L_11;
		V_4 = 0;
		goto IL_0065;
	}

IL_0046:
	{
		// foreach (byte b in BitConverter.GetBytes(hash))
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_12 = V_3;
		int32_t L_13 = V_4;
		NullCheck(L_12);
		int32_t L_14 = L_13;
		uint8_t L_15 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		V_5 = L_15;
		// builder.AppendFormat("{0:X2}", b);
		StringBuilder_t * L_16 = V_1;
		uint8_t L_17 = V_5;
		uint8_t L_18 = L_17;
		RuntimeObject * L_19 = Box(Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var, &L_18);
		NullCheck(L_16);
		StringBuilder_t * L_20;
		L_20 = StringBuilder_AppendFormat_mA3A12EF6C7AC4C5EBC41FCA633F4FC036205669E(L_16, _stringLiteralDD638980A42773DBA4D111CE8D3979093BAC27E5, L_19, /*hidden argument*/NULL);
		int32_t L_21 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add((int32_t)L_21, (int32_t)1));
	}

IL_0065:
	{
		// foreach (byte b in BitConverter.GetBytes(hash))
		int32_t L_22 = V_4;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23 = V_3;
		NullCheck(L_23);
		if ((((int32_t)L_22) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length))))))
		{
			goto IL_0046;
		}
	}
	{
		// return builder.ToString();
		StringBuilder_t * L_24 = V_1;
		NullCheck(L_24);
		String_t* L_25;
		L_25 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_24);
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
// System.Void UnityEngine.Purchasing.UnifiedReceipt::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnifiedReceipt__ctor_m95303143DCAA8B2CACB4EA6A080F50AB8F5A3450 (UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C * __this, const RuntimeMethod* method)
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
// System.String UnityEngine.Purchasing.UnifiedReceiptFormatter::FormatUnifiedReceipt(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnifiedReceiptFormatter_FormatUnifiedReceipt_mD91359B583BEB06ACD63EE20F0B1F6495B266AE9 (String_t* ___platformReceipt0, String_t* ___transactionId1, String_t* ___storeName2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// UnifiedReceipt unifiedReceipt = new UnifiedReceipt()
		// {
		//     Store = storeName,
		//     TransactionID = transactionId,
		//     Payload = platformReceipt
		// };
		UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C * L_0 = (UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C *)il2cpp_codegen_object_new(UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C_il2cpp_TypeInfo_var);
		UnifiedReceipt__ctor_m95303143DCAA8B2CACB4EA6A080F50AB8F5A3450(L_0, /*hidden argument*/NULL);
		UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C * L_1 = L_0;
		String_t* L_2 = ___storeName2;
		NullCheck(L_1);
		L_1->set_Store_1(L_2);
		UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C * L_3 = L_1;
		String_t* L_4 = ___transactionId1;
		NullCheck(L_3);
		L_3->set_TransactionID_2(L_4);
		UnifiedReceipt_tA6F15C09016E268972C54E17E9113C4C4B42480C * L_5 = L_3;
		String_t* L_6 = ___platformReceipt0;
		NullCheck(L_5);
		L_5->set_Payload_0(L_6);
		// return JsonUtility.ToJson(unifiedReceipt);
		String_t* L_7;
		L_7 = JsonUtility_ToJson_mF4F097C9AEC7699970E3E7E99EF8FF2F44DA1B5C(L_5, /*hidden argument*/NULL);
		return L_7;
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
// System.Void UnityEngine.Purchasing.UnityAnalytics::Transaction(System.String,System.Decimal,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAnalytics_Transaction_mAD109DF02074F03522F8B5BF8C45A09D3AD56D2D (UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62 * __this, String_t* ___productId0, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___price1, String_t* ___currency2, String_t* ___receipt3, String_t* ___signature4, const RuntimeMethod* method)
{
	{
		// Analytics.Analytics.Transaction(productId, price, currency, receipt, signature, true);
		String_t* L_0 = ___productId0;
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_1 = ___price1;
		String_t* L_2 = ___currency2;
		String_t* L_3 = ___receipt3;
		String_t* L_4 = ___signature4;
		int32_t L_5;
		L_5 = Analytics_Transaction_m6B28F1858A26BFF3D6CD98704C73320D27BFDC0F(L_0, L_1, L_2, L_3, L_4, (bool)1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.UnityAnalytics::CustomEvent(System.String,System.Collections.Generic.Dictionary`2<System.String,System.Object>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAnalytics_CustomEvent_m2453A646D234BF4379E846B847C2E99B225D4678 (UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62 * __this, String_t* ___name0, Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ___data1, const RuntimeMethod* method)
{
	{
		// Analytics.Analytics.CustomEvent(name, data);
		String_t* L_0 = ___name0;
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_1 = ___data1;
		int32_t L_2;
		L_2 = Analytics_CustomEvent_m1E9B8BA28D46AD42DA9D447644BB69B3B4D93C1A(L_0, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.UnityAnalytics::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAnalytics__ctor_m06F33FBA14352393AEBFD232B8F449015EFD7115 (UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62 * __this, const RuntimeMethod* method)
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
// System.Void UnityEngine.Purchasing.UnityPurchasing::Initialize(UnityEngine.Purchasing.IStoreListener,UnityEngine.Purchasing.ConfigurationBuilder)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityPurchasing_Initialize_m8C668B4F6A75B63D6E149178AC6862826BEAB013 (RuntimeObject* ___listener0, ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ___builder1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Initialize(listener, builder, UnityEngine.Debug.unityLogger, Application.persistentDataPath, new UnityAnalytics(), builder.factory.GetCatalogProvider());
		RuntimeObject* L_0 = ___listener0;
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_1 = ___builder1;
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		RuntimeObject* L_2;
		L_2 = Debug_get_unityLogger_m70D38067C3055104F6C8D050AB7CE0FDFD05EE22_inline(/*hidden argument*/NULL);
		String_t* L_3;
		L_3 = Application_get_persistentDataPath_mBD9C84D06693A9DEF2D9D2206B59D4BCF8A03463(/*hidden argument*/NULL);
		UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62 * L_4 = (UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62 *)il2cpp_codegen_object_new(UnityAnalytics_t9FEC38A6052562113F121301B9876FB3154E4A62_il2cpp_TypeInfo_var);
		UnityAnalytics__ctor_m06F33FBA14352393AEBFD232B8F449015EFD7115(L_4, /*hidden argument*/NULL);
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_5 = ___builder1;
		NullCheck(L_5);
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_6;
		L_6 = ConfigurationBuilder_get_factory_mC832B7559209EE727A013F929285DFF1E0D0CCA0_inline(L_5, /*hidden argument*/NULL);
		NullCheck(L_6);
		RuntimeObject* L_7;
		L_7 = PurchasingFactory_GetCatalogProvider_m5A9250177EBC80F6D0A390D5DCCBA46425AF193F_inline(L_6, /*hidden argument*/NULL);
		UnityPurchasing_Initialize_m79D9E40F5D4BDB2A05DFECA2A6D4DA12D80F0282(L_0, L_1, L_2, L_3, L_4, L_7, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.UnityPurchasing::Initialize(UnityEngine.Purchasing.IStoreListener,UnityEngine.Purchasing.ConfigurationBuilder,UnityEngine.ILogger,System.String,UnityEngine.Purchasing.IUnityAnalytics,UnityEngine.Purchasing.Extension.ICatalogProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityPurchasing_Initialize_m79D9E40F5D4BDB2A05DFECA2A6D4DA12D80F0282 (RuntimeObject* ___listener0, ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * ___builder1, RuntimeObject* ___logger2, String_t* ___persistentDatapath3, RuntimeObject* ___analytics4, RuntimeObject* ___catalog5, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1__ctor_mEC4C58AA11C194EB281B783201E44BEBAA1E18AC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass2_0_U3CInitializeU3Eb__0_mF37EF332DF02DAB08B58D417E5B22A7253B5B790_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 * V_0 = NULL;
	TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * V_1 = NULL;
	AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * V_2 = NULL;
	{
		U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 * L_0 = (U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass2_0__ctor_mCA71656BBA4CD214ACBAD8952AD947F05CEB8302(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		// var transactionLog = new TransactionLog(logger, persistentDatapath);
		RuntimeObject* L_1 = ___logger2;
		String_t* L_2 = ___persistentDatapath3;
		TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * L_3 = (TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 *)il2cpp_codegen_object_new(TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1_il2cpp_TypeInfo_var);
		TransactionLog__ctor_m69D721C1EDECA02889EF962DC5077FE3CD176863(L_3, L_1, L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		// var manager = new PurchasingManager(transactionLog, logger, builder.factory.service, builder.factory.storeName);
		U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 * L_4 = V_0;
		TransactionLog_t96726116160A27989A375B17CC8AC333B6A011C1 * L_5 = V_1;
		RuntimeObject* L_6 = ___logger2;
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_7 = ___builder1;
		NullCheck(L_7);
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_8;
		L_8 = ConfigurationBuilder_get_factory_mC832B7559209EE727A013F929285DFF1E0D0CCA0_inline(L_7, /*hidden argument*/NULL);
		NullCheck(L_8);
		RuntimeObject* L_9;
		L_9 = PurchasingFactory_get_service_mE5E7B0A844A43B08F2813E258ECD873B0689B39A(L_8, /*hidden argument*/NULL);
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_10 = ___builder1;
		NullCheck(L_10);
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_11;
		L_11 = ConfigurationBuilder_get_factory_mC832B7559209EE727A013F929285DFF1E0D0CCA0_inline(L_10, /*hidden argument*/NULL);
		NullCheck(L_11);
		String_t* L_12;
		L_12 = PurchasingFactory_get_storeName_mFFC419BA561609F0C7FFA02C3C7FC5DCD0E51453_inline(L_11, /*hidden argument*/NULL);
		PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * L_13 = (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B *)il2cpp_codegen_object_new(PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B_il2cpp_TypeInfo_var);
		PurchasingManager__ctor_m251E9682588599B21B7D33DDA7A44926A9D30E29(L_13, L_5, L_6, L_9, L_12, /*hidden argument*/NULL);
		NullCheck(L_4);
		L_4->set_manager_0(L_13);
		// var analyticsReporter = new AnalyticsReporter(analytics);
		RuntimeObject* L_14 = ___analytics4;
		AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * L_15 = (AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB *)il2cpp_codegen_object_new(AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB_il2cpp_TypeInfo_var);
		AnalyticsReporter__ctor_m5AA7698A343EE3F3A76D286856FF1CC4C66FCC82(L_15, L_14, /*hidden argument*/NULL);
		V_2 = L_15;
		// var proxy = new StoreListenerProxy(listener, analyticsReporter, builder.factory);
		U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 * L_16 = V_0;
		RuntimeObject* L_17 = ___listener0;
		AnalyticsReporter_t4C77E71C8AD47EF8D10F7C7100B17E3DD229F6BB * L_18 = V_2;
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_19 = ___builder1;
		NullCheck(L_19);
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_20;
		L_20 = ConfigurationBuilder_get_factory_mC832B7559209EE727A013F929285DFF1E0D0CCA0_inline(L_19, /*hidden argument*/NULL);
		StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * L_21 = (StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA *)il2cpp_codegen_object_new(StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA_il2cpp_TypeInfo_var);
		StoreListenerProxy__ctor_mBCC694AD6F19AF0B686F84F9F35A489B7745B7C5(L_21, L_17, L_18, L_20, /*hidden argument*/NULL);
		NullCheck(L_16);
		L_16->set_proxy_1(L_21);
		// FetchAndMergeProducts(builder.useCatalogProvider, builder.products, catalog, response =>
		//     {
		//         manager.Initialize(proxy, response);
		//     });
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_22 = ___builder1;
		NullCheck(L_22);
		bool L_23;
		L_23 = ConfigurationBuilder_get_useCatalogProvider_mD19652692295CEAC3B86595FA8C3C4A4BBABF664_inline(L_22, /*hidden argument*/NULL);
		ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * L_24 = ___builder1;
		NullCheck(L_24);
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_25;
		L_25 = ConfigurationBuilder_get_products_m8143583E6C254670908552934A7B2A2B26A9E2AE_inline(L_24, /*hidden argument*/NULL);
		RuntimeObject* L_26 = ___catalog5;
		U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 * L_27 = V_0;
		Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * L_28 = (Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 *)il2cpp_codegen_object_new(Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999_il2cpp_TypeInfo_var);
		Action_1__ctor_mEC4C58AA11C194EB281B783201E44BEBAA1E18AC(L_28, L_27, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass2_0_U3CInitializeU3Eb__0_mF37EF332DF02DAB08B58D417E5B22A7253B5B790_RuntimeMethod_var), /*hidden argument*/Action_1__ctor_mEC4C58AA11C194EB281B783201E44BEBAA1E18AC_RuntimeMethod_var);
		UnityPurchasing_FetchAndMergeProducts_mD67B366475ACD28CCE4D0B5FB93CAFE1333847C0(L_23, L_25, L_26, L_28, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.UnityPurchasing::FetchAndMergeProducts(System.Boolean,System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>,UnityEngine.Purchasing.Extension.ICatalogProvider,System.Action`1<System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityPurchasing_FetchAndMergeProducts_mD67B366475ACD28CCE4D0B5FB93CAFE1333847C0 (bool ___useCatalog0, HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___localProductSet1, RuntimeObject* ___catalog2, Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * ___callback3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m819A05351F202EF5B8F9AB2F363759B0B09D1319_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1__ctor_mEC4C58AA11C194EB281B783201E44BEBAA1E18AC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICatalogProvider_t0370C13FC059CB78485B74EA854C0FE4FD6CAAB2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass3_0_U3CFetchAndMergeProductsU3Eb__0_m51D9C35CC76C013F9D19AEA16DE34A8B957D122E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * V_0 = NULL;
	{
		U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * L_0 = (U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass3_0__ctor_mCE46D1ADC61B87945F8D7F201F26DCEC5322049B(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * L_1 = V_0;
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_2 = ___localProductSet1;
		NullCheck(L_1);
		L_1->set_localProductSet_0(L_2);
		U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * L_3 = V_0;
		Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * L_4 = ___callback3;
		NullCheck(L_3);
		L_3->set_callback_1(L_4);
		// if (useCatalog && catalog != null)
		bool L_5 = ___useCatalog0;
		if (!L_5)
		{
			goto IL_002d;
		}
	}
	{
		RuntimeObject* L_6 = ___catalog2;
		if (!L_6)
		{
			goto IL_002d;
		}
	}
	{
		// catalog.FetchProducts(cloudProducts =>
		// {
		//     var updatedProductSet = new HashSet<ProductDefinition>(localProductSet);
		// 
		//     foreach (var product in cloudProducts)
		//     {
		//         // Products are hashed by id, so this should remove the local product with the same id before adding the cloud product
		//         updatedProductSet.Remove(product);
		//         updatedProductSet.Add(product);
		//     }
		// 
		//     callback(updatedProductSet);
		// });
		RuntimeObject* L_7 = ___catalog2;
		U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * L_8 = V_0;
		Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * L_9 = (Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 *)il2cpp_codegen_object_new(Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999_il2cpp_TypeInfo_var);
		Action_1__ctor_mEC4C58AA11C194EB281B783201E44BEBAA1E18AC(L_9, L_8, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass3_0_U3CFetchAndMergeProductsU3Eb__0_m51D9C35CC76C013F9D19AEA16DE34A8B957D122E_RuntimeMethod_var), /*hidden argument*/Action_1__ctor_mEC4C58AA11C194EB281B783201E44BEBAA1E18AC_RuntimeMethod_var);
		NullCheck(L_7);
		InterfaceActionInvoker1< Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * >::Invoke(0 /* System.Void UnityEngine.Purchasing.Extension.ICatalogProvider::FetchProducts(System.Action`1<System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>>) */, ICatalogProvider_t0370C13FC059CB78485B74EA854C0FE4FD6CAAB2_il2cpp_TypeInfo_var, L_7, L_9);
		// }
		return;
	}

IL_002d:
	{
		// callback(localProductSet);
		U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * L_10 = V_0;
		NullCheck(L_10);
		Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * L_11 = L_10->get_callback_1();
		U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * L_12 = V_0;
		NullCheck(L_12);
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_13 = L_12->get_localProductSet_0();
		NullCheck(L_11);
		Action_1_Invoke_m819A05351F202EF5B8F9AB2F363759B0B09D1319(L_11, L_13, /*hidden argument*/Action_1_Invoke_m819A05351F202EF5B8F9AB2F363759B0B09D1319_RuntimeMethod_var);
		// }
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
// System.Void UnityEngine.Purchasing.ProductCollection/<>c::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_mA757A3F274F98E6404548637B4056C699633385D (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * L_0 = (U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 *)il2cpp_codegen_object_new(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var);
		U3CU3Ec__ctor_mE557B132E7E4710FFD7F7F4BE5089A8EE063C2F4(L_0, /*hidden argument*/NULL);
		((U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9_il2cpp_TypeInfo_var))->set_U3CU3E9_0(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.ProductCollection/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_mE557B132E7E4710FFD7F7F4BE5089A8EE063C2F4 (U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.String UnityEngine.Purchasing.ProductCollection/<>c::<AddProducts>b__5_0(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* U3CU3Ec_U3CAddProductsU3Eb__5_0_m815B1655D68CD538FD0A3C4DA1A6592505B189F8 (U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___x0, const RuntimeMethod* method)
{
	{
		// m_IdToProduct = m_Products.ToDictionary(x => x.definition.id);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___x0;
		NullCheck(L_0);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_1;
		L_1 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		String_t* L_2;
		L_2 = ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline(L_1, /*hidden argument*/NULL);
		return L_2;
	}
}
// System.String UnityEngine.Purchasing.ProductCollection/<>c::<AddProducts>b__5_1(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* U3CU3Ec_U3CAddProductsU3Eb__5_1_m1F74C97E90D2636BC4DCB850358F89D9A5F84F95 (U3CU3Ec_t6F6C504F3EB8439EDC7766B0D8C4F2AEBD1717F9 * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___x0, const RuntimeMethod* method)
{
	{
		// m_StoreSpecificIdToProduct = m_Products.ToDictionary(x => x.definition.storeSpecificId);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___x0;
		NullCheck(L_0);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_1;
		L_1 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		String_t* L_2;
		L_2 = ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6_inline(L_1, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.PurchasingManager/<>c::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_mD46F83D4E0C9CFA8C64EC4582AF4CE7F98D50F1A (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 * L_0 = (U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 *)il2cpp_codegen_object_new(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var);
		U3CU3Ec__ctor_mE70C90F486FEEBDC825A2B27A814F48CF9EBD833(L_0, /*hidden argument*/NULL);
		((U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396_il2cpp_TypeInfo_var))->set_U3CU3E9_0(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.PurchasingManager/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_mE70C90F486FEEBDC825A2B27A814F48CF9EBD833 (U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Purchasing.Product UnityEngine.Purchasing.PurchasingManager/<>c::<Initialize>b__36_0(UnityEngine.Purchasing.ProductDefinition)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * U3CU3Ec_U3CInitializeU3Eb__36_0_m2FBA72637489C224FF4714F2F72AEBE55BE31C86 (U3CU3Ec_t4E2E1F21F7CBE95399C269B6E4474EEB756D5396 * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___x0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// var prods = products.Select(x => new Product(x, new ProductMetadata())).ToArray();
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_0 = ___x0;
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_1 = (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 *)il2cpp_codegen_object_new(ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02_il2cpp_TypeInfo_var);
		ProductMetadata__ctor_m7561EFECB866511CAE76597E34C9DFD34E0D3171(L_1, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_2 = (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E *)il2cpp_codegen_object_new(Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E_il2cpp_TypeInfo_var);
		Product__ctor_m6417672E9F6ED21F6A9D5DA018EEA866AF8CFC9C(L_2, L_0, L_1, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.PurchasingManager/<>c__DisplayClass23_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass23_0__ctor_mACE5AC91204E137680F657F55F9278C899497A74 (U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.PurchasingManager/<>c__DisplayClass23_0::<OnAllPurchasesRetrieved>b__0(UnityEngine.Purchasing.Product)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CU3Ec__DisplayClass23_0_U3COnAllPurchasesRetrievedU3Eb__0_m1ED6B42682A464C7B9336B43821D16738BC5A3B1 (U3CU3Ec__DisplayClass23_0_tB1BCA31B9BB72E859F6045426E5D454AD4E78038 * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___firstPurchasedProduct0, const RuntimeMethod* method)
{
	{
		// var purchasedProduct = purchasedProducts?.FirstOrDefault(firstPurchasedProduct => firstPurchasedProduct.definition.id == product.definition.id);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___firstPurchasedProduct0;
		NullCheck(L_0);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_1;
		L_1 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		String_t* L_2;
		L_2 = ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline(L_1, /*hidden argument*/NULL);
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_3 = __this->get_product_0();
		NullCheck(L_3);
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_4;
		L_4 = Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline(L_3, /*hidden argument*/NULL);
		NullCheck(L_4);
		String_t* L_5;
		L_5 = ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline(L_4, /*hidden argument*/NULL);
		bool L_6;
		L_6 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_2, L_5, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass2_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass2_0__ctor_mCA71656BBA4CD214ACBAD8952AD947F05CEB8302 (U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass2_0::<Initialize>b__0(System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass2_0_U3CInitializeU3Eb__0_mF37EF332DF02DAB08B58D417E5B22A7253B5B790 (U3CU3Ec__DisplayClass2_0_t6411F0D32B5FE96D705441DC7EAB1DD607642089 * __this, HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___response0, const RuntimeMethod* method)
{
	{
		// manager.Initialize(proxy, response);
		PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * L_0 = __this->get_manager_0();
		StoreListenerProxy_t73229B778BCA758426B0B520E52B890575C49FDA * L_1 = __this->get_proxy_1();
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_2 = ___response0;
		NullCheck(L_0);
		PurchasingManager_Initialize_m9E1231D1B39759CD83D74A42F7F87DB2AB8A2840(L_0, L_1, L_2, /*hidden argument*/NULL);
		// });
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
// System.Void UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass3_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0__ctor_mCE46D1ADC61B87945F8D7F201F26DCEC5322049B (U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Purchasing.UnityPurchasing/<>c__DisplayClass3_0::<FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0_U3CFetchAndMergeProductsU3Eb__0_m51D9C35CC76C013F9D19AEA16DE34A8B957D122E (U3CU3Ec__DisplayClass3_0_t8F694455F2692CE22C749D0F70E6480D1C2307AF * __this, HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ___cloudProducts0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m819A05351F202EF5B8F9AB2F363759B0B09D1319_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m69B413E241BCF6115FB0F8CFEEB1855788A349F1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_m60D31817DCDACB537CAD2D01045C2CDD5CECD4F2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_m600D6E603AF57068B4587387CEAAB4EB740A60B4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Add_mE4FBC8CF189E84F0C496E46A3AB981EEBDE8BF4D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_GetEnumerator_m0556A05132CD535D94ECC794908D21198CC99520_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_Remove_m07D62659DE67245D3DE64BF57E99C7AF25DBC6CF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1__ctor_m49FF96A56D01B47661A3DA57E99CABB3777841A1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * V_0 = NULL;
	Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C  V_1;
	memset((&V_1), 0, sizeof(V_1));
	ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * V_2 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// var updatedProductSet = new HashSet<ProductDefinition>(localProductSet);
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_0 = __this->get_localProductSet_0();
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_1 = (HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 *)il2cpp_codegen_object_new(HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1_il2cpp_TypeInfo_var);
		HashSet_1__ctor_m49FF96A56D01B47661A3DA57E99CABB3777841A1(L_1, L_0, /*hidden argument*/HashSet_1__ctor_m49FF96A56D01B47661A3DA57E99CABB3777841A1_RuntimeMethod_var);
		V_0 = L_1;
		// foreach (var product in cloudProducts)
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_2 = ___cloudProducts0;
		NullCheck(L_2);
		Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C  L_3;
		L_3 = HashSet_1_GetEnumerator_m0556A05132CD535D94ECC794908D21198CC99520(L_2, /*hidden argument*/HashSet_1_GetEnumerator_m0556A05132CD535D94ECC794908D21198CC99520_RuntimeMethod_var);
		V_1 = L_3;
	}

IL_0013:
	try
	{ // begin try (depth: 1)
		{
			goto IL_002d;
		}

IL_0015:
		{
			// foreach (var product in cloudProducts)
			ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_4;
			L_4 = Enumerator_get_Current_m600D6E603AF57068B4587387CEAAB4EB740A60B4_inline((Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C *)(&V_1), /*hidden argument*/Enumerator_get_Current_m600D6E603AF57068B4587387CEAAB4EB740A60B4_RuntimeMethod_var);
			V_2 = L_4;
			// updatedProductSet.Remove(product);
			HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_5 = V_0;
			ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_6 = V_2;
			NullCheck(L_5);
			bool L_7;
			L_7 = HashSet_1_Remove_m07D62659DE67245D3DE64BF57E99C7AF25DBC6CF(L_5, L_6, /*hidden argument*/HashSet_1_Remove_m07D62659DE67245D3DE64BF57E99C7AF25DBC6CF_RuntimeMethod_var);
			// updatedProductSet.Add(product);
			HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_8 = V_0;
			ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_9 = V_2;
			NullCheck(L_8);
			bool L_10;
			L_10 = HashSet_1_Add_mE4FBC8CF189E84F0C496E46A3AB981EEBDE8BF4D(L_8, L_9, /*hidden argument*/HashSet_1_Add_mE4FBC8CF189E84F0C496E46A3AB981EEBDE8BF4D_RuntimeMethod_var);
		}

IL_002d:
		{
			// foreach (var product in cloudProducts)
			bool L_11;
			L_11 = Enumerator_MoveNext_m60D31817DCDACB537CAD2D01045C2CDD5CECD4F2((Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C *)(&V_1), /*hidden argument*/Enumerator_MoveNext_m60D31817DCDACB537CAD2D01045C2CDD5CECD4F2_RuntimeMethod_var);
			if (L_11)
			{
				goto IL_0015;
			}
		}

IL_0036:
		{
			IL2CPP_LEAVE(0x46, FINALLY_0038);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0038;
	}

FINALLY_0038:
	{ // begin finally (depth: 1)
		Enumerator_Dispose_m69B413E241BCF6115FB0F8CFEEB1855788A349F1((Enumerator_t745259B2A655949ED9A93FE4C9E1EF9038D2FF3C *)(&V_1), /*hidden argument*/Enumerator_Dispose_m69B413E241BCF6115FB0F8CFEEB1855788A349F1_RuntimeMethod_var);
		IL2CPP_END_FINALLY(56)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(56)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x46, IL_0046)
	}

IL_0046:
	{
		// callback(updatedProductSet);
		Action_1_tB603F9E9D8984BC150C1410A9EC36FB9EF27C999 * L_12 = __this->get_callback_1();
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_13 = V_0;
		NullCheck(L_12);
		Action_1_Invoke_m819A05351F202EF5B8F9AB2F363759B0B09D1319(L_12, L_13, /*hidden argument*/Action_1_Invoke_m819A05351F202EF5B8F9AB2F363759B0B09D1319_RuntimeMethod_var);
		// });
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * Product_get_metadata_m36970AF9A9B1A716E3E1FDDF3B7A3A4C2287F8AE_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public ProductMetadata metadata { get; internal set; }
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_0 = __this->get_U3CmetadataU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductMetadata_get_isoCurrencyCode_mF120AB3BE16D7412714ADCB4A3A309994AD14448_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method)
{
	{
		// public string isoCurrencyCode { get; internal set; }
		String_t* L_0 = __this->get_U3CisoCurrencyCodeU3Ek__BackingField_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * Product_get_definition_m0311B165A3BC6AF59A28AE4D75A220DDFDAA7182_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public ProductDefinition definition { get; private set; }
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_0 = __this->get_U3CdefinitionU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDefinition_get_storeSpecificId_m32204A00FC4A55334ABC8336509E4B57A6CD50B6_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method)
{
	{
		// public string storeSpecificId { get; private set; }
		String_t* L_0 = __this->get_U3CstoreSpecificIdU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ProductMetadata_get_localizedPrice_mCD6B8DDFB4A322CD82A44ECFB0D098F195493F9D_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, const RuntimeMethod* method)
{
	{
		// public decimal localizedPrice { get; internal set; }
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_0 = __this->get_U3ClocalizedPriceU3Ek__BackingField_4();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* Product_get_receipt_mEB9707DA0BF7F2D19DF9A0B2512B416FF89CB8C7_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public string receipt { get; internal set; }
		String_t* L_0 = __this->get_U3CreceiptU3Ek__BackingField_4();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * ConfigurationBuilder_get_factory_mC832B7559209EE727A013F929285DFF1E0D0CCA0_inline (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method)
{
	{
		// get { return m_Factory; }
		PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * L_0 = __this->get_m_Factory_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* PurchasingFactory_get_storeName_mFFC419BA561609F0C7FFA02C3C7FC5DCD0E51453_inline (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, const RuntimeMethod* method)
{
	{
		// public string storeName { get; private set; }
		String_t* L_0 = __this->get_U3CstoreNameU3Ek__BackingField_4();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_definition_m17632BA5F56BA30A07498B0EB5C0D1D7142D521F_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * ___value0, const RuntimeMethod* method)
{
	{
		// public ProductDefinition definition { get; private set; }
		ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * L_0 = ___value0;
		__this->set_U3CdefinitionU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_metadata_m47CFE30071CD7DFC334749332B8C7869D08C18A4_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___value0, const RuntimeMethod* method)
{
	{
		// public ProductMetadata metadata { get; internal set; }
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_0 = ___value0;
		__this->set_U3CmetadataU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_receipt_m840DB38E1DF977D46501E9775822998504321939_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string receipt { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CreceiptU3Ek__BackingField_4(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDefinition_set_id_m51E9751372680165426BF38F704AF156EDC8F409_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string id { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CidU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDefinition_set_storeSpecificId_m8B517A5FFCCDE7F6D966D01755E6ED85D7E08383_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string storeSpecificId { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CstoreSpecificIdU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDefinition_set_type_mD99FAB9E2A75B43223D3FC6CD94D2227F08685B7_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public ProductType type { get; private set; }
		int32_t L_0 = ___value0;
		__this->set_U3CtypeU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDefinition_set_enabled_m9D94A78B81CE41EAAC26428D76679DC52BC8D638_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// public bool enabled { get; private set; }
		bool L_0 = ___value0;
		__this->set_U3CenabledU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDefinition_get_id_m36316F5B3DCDF8110AF71C3F6E3F0E28AFC831E8_inline (ProductDefinition_tD15185D43FAFB5711540CA3DEB1E600F7FE08572 * __this, const RuntimeMethod* method)
{
	{
		// public string id { get; private set; }
		String_t* L_0 = __this->get_U3CidU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDescription_set_storeSpecificId_mA913B1D4F5C2DB7009A530F0B3550EF57F20FD44_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string storeSpecificId { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CstoreSpecificIdU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDescription_set_metadata_mDD9C2B807FD047A7C91EDA3996931E5D9E886703_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ___value0, const RuntimeMethod* method)
{
	{
		// public ProductMetadata metadata { get; private set; }
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_0 = ___value0;
		__this->set_U3CmetadataU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDescription_set_receipt_m68F0A2BE12715CD2FFD606E6455796D4EA254101_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string receipt { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CreceiptU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductDescription_set_transactionId_m5C0C2615AAB10FD93A69683CDEDC072F44CCA752_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string transactionId { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CtransactionIdU3Ek__BackingField_4(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedPriceString_m3114E4D67F5A17BC187DBB9D3A067C0569A69702_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string localizedPriceString { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3ClocalizedPriceStringU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedTitle_mA0D1F59CA6B369ED045226948723B583CD49E78A_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string localizedTitle { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3ClocalizedTitleU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedDescription_m1B74BFD9B930EF7A3174C3C8738EE404D1399152_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string localizedDescription { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3ClocalizedDescriptionU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_isoCurrencyCode_m4E5A20FB8601E9A651FBA18BBB5F5ACD426DA768_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string isoCurrencyCode { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CisoCurrencyCodeU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ProductMetadata_set_localizedPrice_mF41BFD302AE1C9F21AEBD893D4337C362C50DB88_inline (ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * __this, Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  ___value0, const RuntimeMethod* method)
{
	{
		// public decimal localizedPrice { get; internal set; }
		Decimal_t2978B229CA86D3B7BA66A0AEEE014E0DE4F940D7  L_0 = ___value0;
		__this->set_U3ClocalizedPriceU3Ek__BackingField_4(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_transactionID_mDA6FB2B1B4E82594D80FE295F4333936FD162FBF_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string transactionID { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CtransactionIDU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchaseEventArgs_set_purchasedProduct_mDBEFD23C5488F6EC6F2EE719925D31A090AC35CC_inline (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * __this, Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * ___value0, const RuntimeMethod* method)
{
	{
		// public Product purchasedProduct { get; private set; }
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = ___value0;
		__this->set_U3CpurchasedProductU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_productId_mE295E5962FBA98CCB477B4B0572CC6FC3A766B6D_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string productId { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CproductIdU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_reason_mDEA2EF43F275FBDED54C8727D03F749E898E22FE_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public PurchaseFailureReason reason { get; private set; }
		int32_t L_0 = ___value0;
		__this->set_U3CreasonU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchaseFailureDescription_set_message_mD2A75514074F67A7CEC79A18D061F444F5BCCAC1_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public String message { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CmessageU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchasingFactory_set_storeName_mF4007CD7F5CD1373507429D6E6BA9D5A4800AC7D_inline (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string storeName { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CstoreNameU3Ek__BackingField_4(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchasingFactory_set_service_mD6B699C7477F20875DE50767AB1CE363CB17DA44_inline (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, RuntimeObject* ___value0, const RuntimeMethod* method)
{
	{
		// set { m_Store = value; }
		RuntimeObject* L_0 = ___value0;
		__this->set_m_Store_2(L_0);
		// set { m_Store = value; }
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchasingManager_set_useTransactionLog_mB13861C43C5625F0F4EA38327A6056EE9EF273DA_inline (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// public bool useTransactionLog { get; set; }
		bool L_0 = ___value0;
		__this->set_U3CuseTransactionLogU3Ek__BackingField_7(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Product_get_availableToPurchase_mBAB83F4E1E276628EA5948A67C2F79F31A003CBF_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public bool availableToPurchase { get; internal set; }
		bool L_0 = __this->get_U3CavailableToPurchaseU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* Product_get_transactionID_m4648435E58ABED9B0C3771DCE566C3646FBE554F_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, const RuntimeMethod* method)
{
	{
		// public string transactionID { get; internal set; }
		String_t* L_0 = __this->get_U3CtransactionIDU3Ek__BackingField_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool PurchasingManager_get_useTransactionLog_mB8E7472617FCBD4BA5C910F4D5D5FFB6A0A6BADF_inline (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method)
{
	{
		// public bool useTransactionLog { get; set; }
		bool L_0 = __this->get_U3CuseTransactionLogU3Ek__BackingField_7();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * PurchasingManager_get_products_mFDE03D74A8B2E640AA9FDF130EA61B166DC64203_inline (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, const RuntimeMethod* method)
{
	{
		// public ProductCollection products { get; private set; }
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_0 = __this->get_U3CproductsU3Ek__BackingField_8();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* ProductCollection_get_all_m8F08A78D6AF774BE9A1A0C14E69747293EDC6E11_inline (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, const RuntimeMethod* method)
{
	{
		// get { return m_Products; }
		ProductU5BU5D_t1202CB7487EB88A76294BF6E7F42E297D74B8062* L_0 = __this->get_m_Products_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* PurchaseFailureDescription_get_productId_mDAE0C9E1F3A0144CF7A6728EDAC287009F483057_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method)
{
	{
		// public string productId { get; private set; }
		String_t* L_0 = __this->get_U3CproductIdU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t PurchaseFailureDescription_get_reason_m0EF61510E8851D12EA86FF0376DC4B99A7415E0F_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method)
{
	{
		// public PurchaseFailureReason reason { get; private set; }
		int32_t L_0 = __this->get_U3CreasonU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* PurchaseFailureDescription_get_message_mF5E354CE7F8BAEF0BE525EC30608A54F4607E504_inline (PurchaseFailureDescription_tF5204FF61912DF603166BB79C4A10BA5727FBFD8 * __this, const RuntimeMethod* method)
{
	{
		// public String message { get; private set; }
		String_t* L_0 = __this->get_U3CmessageU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDescription_get_storeSpecificId_m805EE28C57C25664093C7F5C2FB24EAADFEAFB09_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method)
{
	{
		// public string storeSpecificId { get; private set; }
		String_t* L_0 = __this->get_U3CstoreSpecificIdU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * ProductDescription_get_metadata_m3638B035BE86738C71F776D7313827080557986B_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method)
{
	{
		// public ProductMetadata metadata { get; private set; }
		ProductMetadata_tAA2AADD58CE3B832532B471EA80FEE323EB9BF02 * L_0 = __this->get_U3CmetadataU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Product_set_availableToPurchase_m7C4954A4C675BE7DBC041D8928D4E66AEBBBE28C_inline (Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// public bool availableToPurchase { get; internal set; }
		bool L_0 = ___value0;
		__this->set_U3CavailableToPurchaseU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDescription_get_transactionId_m88319BAE8BD3CC3E1D65E19370EE3EB9379BE93F_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method)
{
	{
		// public string transactionId { get; set; }
		String_t* L_0 = __this->get_U3CtransactionIdU3Ek__BackingField_4();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* ProductDescription_get_receipt_m0D6C6B53F56F62B89399A156E392AF9AE1D53CC7_inline (ProductDescription_t9F14611B4DB2B1E0DAE69236C5C50FE41DDE6C75 * __this, const RuntimeMethod* method)
{
	{
		// public string receipt { get; private set; }
		String_t* L_0 = __this->get_U3CreceiptU3Ek__BackingField_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * ProductCollection_get_set_m59FB3EC03DCFA60FD4F6685381F2E1CF47358725_inline (ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * __this, const RuntimeMethod* method)
{
	{
		// get { return m_ProductSet; }
		HashSet_1_tDFDEC884936A4BFB3ED41935F9313D9685C1FECA * L_0 = __this->get_m_ProductSet_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PurchasingManager_set_products_m302D5E4CFC91CE9E1162063F0F260DC63EB026AD_inline (PurchasingManager_tC707886FC4440A66F3BF2B3DD870CC96CDB9B83B * __this, ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * ___value0, const RuntimeMethod* method)
{
	{
		// public ProductCollection products { get; private set; }
		ProductCollection_t5877A1A47DA0DA2C32488E6D2DD23B77E6B6065C * L_0 = ___value0;
		__this->set_U3CproductsU3Ek__BackingField_8(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * PurchaseEventArgs_get_purchasedProduct_m82395AF6B8EB5A4747C638287821893F2D31D355_inline (PurchaseEventArgs_tDBAC51992A265A32E79B590688327200A2545114 * __this, const RuntimeMethod* method)
{
	{
		// public Product purchasedProduct { get; private set; }
		Product_t8D04681E6E43F5FBB6065B70408B9B0F13B5797E * L_0 = __this->get_U3CpurchasedProductU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline (String_t* __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_m_stringLength_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* Debug_get_unityLogger_m70D38067C3055104F6C8D050AB7CE0FDFD05EE22_inline (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_StaticFields*)il2cpp_codegen_static_fields_for(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var))->get_s_Logger_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject* PurchasingFactory_GetCatalogProvider_m5A9250177EBC80F6D0A390D5DCCBA46425AF193F_inline (PurchasingFactory_t9319A1D18BC6A8E7E35A33E66CDF88575CCB95D2 * __this, const RuntimeMethod* method)
{
	{
		// return m_CatalogProvider;
		RuntimeObject* L_0 = __this->get_m_CatalogProvider_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool ConfigurationBuilder_get_useCatalogProvider_mD19652692295CEAC3B86595FA8C3C4A4BBABF664_inline (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method)
{
	{
		// get;
		bool L_0 = __this->get_U3CuseCatalogProviderU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * ConfigurationBuilder_get_products_m8143583E6C254670908552934A7B2A2B26A9E2AE_inline (ConfigurationBuilder_t8C2A33B91D14FD46DA1EF4EF45CA14143260969A * __this, const RuntimeMethod* method)
{
	{
		// get { return m_Products; }
		HashSet_1_t00A61FC12AB18B4C1D249E381790DAEE518920B1 * L_0 = __this->get_m_Products_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = (RuntimeObject *)__this->get_current_3();
		return (RuntimeObject *)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t HashSet_1_get_Count_m41C20B7D2DB4661F5C68E9BA25E4B83FC6914CD8_gshared_inline (HashSet_1_t680119C7ED8D82AED56CDB83DF6F0E9149852A9B * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = (int32_t)__this->get__count_9();
		return (int32_t)L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_mC55AF9E2F45639649E40AF5919D6169FD9543E01_gshared_inline (Enumerator_t2430E2854B4328060EB6096AD1E4851E8DC45C3A * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = (RuntimeObject *)__this->get__current_3();
		return (RuntimeObject *)L_0;
	}
}
