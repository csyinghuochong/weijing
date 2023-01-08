#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


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
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Threading.AsyncLocal`1<System.Globalization.CultureInfo>
struct AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Globalization.CultureInfo>
struct Dictionary_2_t5B8303F2C9869A39ED3E03C0FBB09F817E479402;
// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D;
// System.Collections.Generic.Dictionary`2<System.String,System.Globalization.CultureInfo>
struct Dictionary_2_t0015CBF964B0687CBB5ECFDDE06671A8F3DDE4BC;
// System.Collections.Generic.Dictionary`2<System.String,System.Object>
struct Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399;
// System.Collections.Generic.IEqualityComparer`1<System.String>
struct IEqualityComparer_1_tE6A65C5E45E33FD7D9849FD0914DE3AD32B68050;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.String,System.Object>
struct KeyCollection_t0043475CBB02FD67894529F3CAA818080A2F7A17;
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt>
struct List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5;
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo>
struct List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18;
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert>
struct List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3;
// System.Threading.Tasks.Task`1<System.Int32>
struct Task_1_tEF253D967DB628A9F8A389A9F2E4516871FD3725;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.String,System.Object>
struct ValueCollection_tB942A1033B750DCF04FE948413982D120FC69A4E;
// System.Collections.Generic.Dictionary`2/Entry<System.String,System.Object>[]
struct EntryU5BU5D_tDCA1A62E50C5B5A40FD6F44107088AF42F5671D2;
// UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[]
struct AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8;
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Security.Cryptography.KeySizes[]
struct KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// UnityEngine.Purchasing.Security.SignerInfo[]
struct SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
// UnityEngine.Purchasing.Security.X509Cert[]
struct X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB;
// UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt
struct AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36;
// UnityEngine.Purchasing.Security.AppleReceipt
struct AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62;
// UnityEngine.Purchasing.Security.AppleReceiptParser
struct AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433;
// System.ArgumentException
struct ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00;
// System.Collections.ArrayList
struct ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575;
// LipingShare.LCLib.Asn1Processor.Asn1Node
struct Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3;
// LipingShare.LCLib.Asn1Processor.Asn1Parser
struct Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD;
// System.Globalization.Calendar
struct Calendar_t3D638AEAB45F029DF47138EDA4CF9A7CBBB1C32A;
// System.Globalization.CodePageDataItem
struct CodePageDataItem_t09A62F57142BF0456C8F414898A37E79BCC9F09E;
// System.Globalization.CompareInfo
struct CompareInfo_t4AB62EC32E8AF1E469E315620C7E3FB8B0CAE0C9;
// System.Globalization.CultureData
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529;
// System.Globalization.CultureInfo
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98;
// System.Globalization.DateTimeFormatInfo
struct DateTimeFormatInfo_t0B9F6CA631A51CFC98A3C6031CF8069843137C90;
// System.Text.DecoderFallback
struct DecoderFallback_tF86D337D6576E81E5DA285E5673183EBC66DEF8D;
// UnityEngine.Purchasing.Security.DistinguishedName
struct DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90;
// System.Text.EncoderFallback
struct EncoderFallback_t02AC990075E17EB09F0D7E4831C3B3F264025CC4;
// System.Text.Encoding
struct Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827;
// System.Exception
struct Exception_t;
// System.Threading.ExecutionContext
struct ExecutionContext_t16AC73BB21FEEEAD34A017877AC18DD8BB836414;
// System.Collections.Hashtable
struct Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC;
// UnityEngine.Purchasing.Security.IAPSecurityException
struct IAPSecurityException_t0688C40275CE97C34325C2D6C5884694663D5EFA;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.Security.Principal.IPrincipal
struct IPrincipal_t850ACE1F48327B64F266DD2C6FD8C5F56E4889E2;
// System.Threading.InternalThread
struct InternalThread_t12B78B27503AE19E9122E212419A66843BF746EB;
// UnityEngine.Purchasing.Security.InvalidPKCS7Data
struct InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81;
// UnityEngine.Purchasing.Security.InvalidRSAData
struct InvalidRSAData_t7936FA4BD4B05A86337546B43ED2197E49D4EFF7;
// UnityEngine.Purchasing.Security.InvalidTimeFormat
struct InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428;
// UnityEngine.Purchasing.Security.InvalidX509Data
struct InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA;
// Mono.Security.Cryptography.KeyPairPersistence
struct KeyPairPersistence_t7F7E8811D03A25C0251BF255AB94BAF57E965D9A;
// System.LocalDataStoreHolder
struct LocalDataStoreHolder_tF51C9DD735A89132114AE47E3EB51C11D0FED146;
// System.LocalDataStoreMgr
struct LocalDataStoreMgr_t6CC44D0584911B6A6C6823115F858FC34AB4A80A;
// System.IO.MemoryStream
struct MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C;
// System.MulticastDelegate
struct MulticastDelegate_t;
// System.Globalization.NumberFormatInfo
struct NumberFormatInfo_t58780B43B6A840C38FD10C50CDFE2128884CAD1D;
// LipingShare.LCLib.Asn1Processor.Oid
struct Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D;
// UnityEngine.Purchasing.Security.PKCS7
struct PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71;
// System.Security.Cryptography.RSACryptoServiceProvider
struct RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7;
// UnityEngine.Purchasing.Security.RSAKey
struct RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6;
// Mono.Security.Cryptography.RSAManaged
struct RSAManaged_t39EF82A0D6040ACF38E3C8A99982838521A33E65;
// LipingShare.LCLib.Asn1Processor.RelativeOid
struct RelativeOid_t97392E06363F6AFF26543502032B89445860F72A;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t3EF85FC980AE57957BEBB6B78E81DE2E3233D385;
// UnityEngine.Purchasing.Security.SignerInfo
struct SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB;
// System.IO.Stream
struct Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB;
// System.String
struct String_t;
// System.Collections.Specialized.StringDictionary
struct StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79;
// System.Globalization.TextInfo
struct TextInfo_tE823D0684BFE8B203501C9B2B38585E8F06E872C;
// System.Threading.Thread
struct Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414;
// System.Text.UTF8Encoding
struct UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282;
// UnityEngine.Purchasing.Security.UnsupportedSignerInfoVersion
struct UnsupportedSignerInfoVersion_t0D2E1B83A5FA8AAAF3BA828FFEEEE27A2AC57B1F;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.Purchasing.Security.X509Cert
struct X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_t32CD2C230786712954C1DB518DBE420A1F4C7974;

IL2CPP_EXTERN_C RuntimeClass* AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidRSAData_t7936FA4BD4B05A86337546B43ED2197E49D4EFF7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RelativeOid_t97392E06363F6AFF26543502032B89445860F72A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnsupportedSignerInfoVersion_t0D2E1B83A5FA8AAAF3BA828FFEEEE27A2AC57B1F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeField* U3CPrivateImplementationDetailsU3E_tD58C289ECB60EF91D67519C579A83B4F9F1364B0____2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0_FieldInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral04E4C7E6115783DAF7E8E371EDC9AE581528EA78;
IL2CPP_EXTERN_C String_t* _stringLiteral0524144B9F212F40BEC2750DD0C06E4159777384;
IL2CPP_EXTERN_C String_t* _stringLiteral08D691F3DDE80A0F3B3AFC79770EEC67F64A0234;
IL2CPP_EXTERN_C String_t* _stringLiteral0AC347CF826668C4F33A1CD7ADF5419BAAE73FE0;
IL2CPP_EXTERN_C String_t* _stringLiteral0B6E49D70DC463E44307A8A539250C8090D10786;
IL2CPP_EXTERN_C String_t* _stringLiteral14D13302CA125B23FDC663B73325C42B8DA4C1EB;
IL2CPP_EXTERN_C String_t* _stringLiteral16DEBA0A49D8FDF8FFD3E681909ACA71D8132580;
IL2CPP_EXTERN_C String_t* _stringLiteral17F69BD9415AEEFF5AF120DF2D45F20433804764;
IL2CPP_EXTERN_C String_t* _stringLiteral1A7FC08E8EB016BAD5A8A8D7B3447DAD63E867BC;
IL2CPP_EXTERN_C String_t* _stringLiteral1AC39C0EA9E4D306D424F6C66A205ABF47D53B5E;
IL2CPP_EXTERN_C String_t* _stringLiteral1FA2E7519891D1B744F973A073D6CE50874854C6;
IL2CPP_EXTERN_C String_t* _stringLiteral2A7F604AA53E605CA5A4D06ADF4F5C4B6FCBD8E8;
IL2CPP_EXTERN_C String_t* _stringLiteral31EFAEEDBC2BB686A5ABA0098A7A45FCE86FBD8A;
IL2CPP_EXTERN_C String_t* _stringLiteral3B764AA8712500B6779AEFF44B47B45F9ECF8039;
IL2CPP_EXTERN_C String_t* _stringLiteral3C71631187881B6DAB198AF4B06C779471926174;
IL2CPP_EXTERN_C String_t* _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5;
IL2CPP_EXTERN_C String_t* _stringLiteral4202CE17CF8429812DBB3C69FBD0097EC2457F9F;
IL2CPP_EXTERN_C String_t* _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D;
IL2CPP_EXTERN_C String_t* _stringLiteral44D231DAD9D02BE301A8CF4FBCABD5DE1FDCFF54;
IL2CPP_EXTERN_C String_t* _stringLiteral453A07B8CC155ECBEB68D277EC848642FFB5F3B6;
IL2CPP_EXTERN_C String_t* _stringLiteral481CFA1B155F22067D8FEA989EB269E873B62B4F;
IL2CPP_EXTERN_C String_t* _stringLiteral4BAFCB89E7C61DD51CF32D48E1F883426E74C000;
IL2CPP_EXTERN_C String_t* _stringLiteral52D13D434A39B045A12B8CCE2D63CFFAFE1972CF;
IL2CPP_EXTERN_C String_t* _stringLiteral5F3ACD009658E07BAE430ABC62FC30CE666E7249;
IL2CPP_EXTERN_C String_t* _stringLiteral61F9A6943D78A4154F6821755AA9A1C4A3E80717;
IL2CPP_EXTERN_C String_t* _stringLiteral67E6D858EA0BE7F6F1158A0A3EA4E4946B21A283;
IL2CPP_EXTERN_C String_t* _stringLiteral68E810E310A6E1368AC66300136C585E142E80BF;
IL2CPP_EXTERN_C String_t* _stringLiteral6BB0A873A6D6124ACF9D6FEAEB6204BC0FFE7381;
IL2CPP_EXTERN_C String_t* _stringLiteral79C59A0C4D87BBB64A0C537CC6FCEBF8DE14A269;
IL2CPP_EXTERN_C String_t* _stringLiteral859BD87B9776D9CE86B7C752B95409950D61EB08;
IL2CPP_EXTERN_C String_t* _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1;
IL2CPP_EXTERN_C String_t* _stringLiteral900D858FE9ABCD2ED2B25CD27110A78ADCC6EC6B;
IL2CPP_EXTERN_C String_t* _stringLiteral94227CA8EB4252C21E39FE8CCB2B65A6D01D3CF1;
IL2CPP_EXTERN_C String_t* _stringLiteral9787EA65D34ACB2E800972522D1FB9E8D86E0511;
IL2CPP_EXTERN_C String_t* _stringLiteral99C134A36D015746C32203B98CC495F87311D9DC;
IL2CPP_EXTERN_C String_t* _stringLiteral9CBE6269D7D5D08B76852D89B90B601BAD02D7DD;
IL2CPP_EXTERN_C String_t* _stringLiteralAC35AB7561A701D96BD51BC1F1EE072F2F9718C0;
IL2CPP_EXTERN_C String_t* _stringLiteralADADD3B05013D84B886E96640AA7F89AF39D5AD6;
IL2CPP_EXTERN_C String_t* _stringLiteralADF3402AEC14A5C5A7E1E8A624F7B7F4D2123EA0;
IL2CPP_EXTERN_C String_t* _stringLiteralAE82977104FE357F4C1CE6D6A3DFD58AFEBFC641;
IL2CPP_EXTERN_C String_t* _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D;
IL2CPP_EXTERN_C String_t* _stringLiteralB4A7D2EEB1F22F7D3B5BE89D41486AAF0411C31A;
IL2CPP_EXTERN_C String_t* _stringLiteralB562730CA6FCD749B7C84DE73BEBD292D954C70E;
IL2CPP_EXTERN_C String_t* _stringLiteralB89111EC34842EC45C03B81F4BDFBC7724B6905F;
IL2CPP_EXTERN_C String_t* _stringLiteralB9DA3B4CA745F231A5F6D027DDCEE9158AC52CAE;
IL2CPP_EXTERN_C String_t* _stringLiteralBCED53E33A2D1B5B5E90E0B5DE86443E44FD452A;
IL2CPP_EXTERN_C String_t* _stringLiteralBF403E6FC90C56524FFEE246E1374665DF60C2D6;
IL2CPP_EXTERN_C String_t* _stringLiteralC2DD8ADEA00866AFE6382302B25CE5A086DBCEF8;
IL2CPP_EXTERN_C String_t* _stringLiteralC3C83DB7DD412566438B355E6504DBB01A12F5E4;
IL2CPP_EXTERN_C String_t* _stringLiteralCB4985E8F90C7FA1F0E650F37DD0D921D1BF99E6;
IL2CPP_EXTERN_C String_t* _stringLiteralCBDD70ED42B3745921307A6AF5729CDF0C49B732;
IL2CPP_EXTERN_C String_t* _stringLiteralCEA206F53009B4409A8E1620933737D0F4D7E1B6;
IL2CPP_EXTERN_C String_t* _stringLiteralCF2AF9005B6B2A5DCC73C4E00CBE3F19D96687B4;
IL2CPP_EXTERN_C String_t* _stringLiteralCF61206F351943EEC77681D8FE9F32833CBE6444;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralDC3FA34132F5B79C1EC6AD3AAAC2C6A5B7F29E34;
IL2CPP_EXTERN_C String_t* _stringLiteralDCACA63FC238CCA8ED535F7BFAF590FC831D8832;
IL2CPP_EXTERN_C String_t* _stringLiteralDD381BE73F585C3796C220566E891E458F9D6290;
IL2CPP_EXTERN_C String_t* _stringLiteralE1A854E69EA27FE94B3DD30F3C8F92D6E6560149;
IL2CPP_EXTERN_C String_t* _stringLiteralE91195DA6E39E9A4D6BB7DBF2BF8A45CF0FB0A42;
IL2CPP_EXTERN_C String_t* _stringLiteralEA9886E4F2C4A6802C316A24EEE315A59DF9E0B5;
IL2CPP_EXTERN_C String_t* _stringLiteralEBF60A7C62C7CF38BEB570C5B0AF43904FFCB6B8;
IL2CPP_EXTERN_C String_t* _stringLiteralEFE5B4EE3917FFFE8F93D31E5E798F2A968F3FC6;
IL2CPP_EXTERN_C String_t* _stringLiteralF172F77C7E45F5898E6A62C11097CBEE26EBF4E1;
IL2CPP_EXTERN_C String_t* _stringLiteralF24BCEBD3BF54143DC34399B1E3AD4F93496E764;
IL2CPP_EXTERN_C String_t* _stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D;
IL2CPP_EXTERN_C String_t* _stringLiteralF69C981860A19A82ADD9552E5DDAFA32BFD3D7B7;
IL2CPP_EXTERN_C String_t* _stringLiteralF7906DC491A0486A30D111F231D1624CA5B94C94;
IL2CPP_EXTERN_C const RuntimeMethod* AppleReceiptParser_ArrayEquals_TisByte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_mF12D1427396A96BD80931D7572CBB9B2C8405230_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AppleReceiptParser_ParseReceipt_m543C1FD33C7B481B0557EB1D5FA5868E2914C91F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Asn1Node_CreateAndPrepareListDecodeMemoryStreamKnownLength_mB4D54A6EF150F7586A41C1A6988B86905F0830D6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Asn1Node_ReadMeasuredLengthDataFromStart_m89EBB7361B009BF6D5CC8B901A3FE9468AF94ACD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Asn1Parser_LoadData_mC695E2673D7B8576065B7130E6BF0B92F4908B98_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* DistinguishedName__ctor_m88B417EEFA420272B08355F1369DBDAA71532886_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m240F342C63A57F3BEA7E78AFF14DF3D96C208FE6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m80068FC05C359A987CEF7128920AA1437950D76E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m9B4412E2C7AAF1AF1107C9AD3E077358556B98C0_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_mEF201E3A675DB1879B7B5308261F352929154CD6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m5667C5FFA6B3D3FE9E406930664837BF29CB06F1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m9174FECFF4F8AF56773DA8275A1610F7D7BF0745_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mD16F670EC2FA32D7869FD8D681CC05B713B06FB8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Oid_Decode_m419D782F9974D3FB801A90E8F01B965E3786DC09_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* RSAKey_ParseNode_mC39A2AC4AC93CD5E30783858DE40667A8CE74D77_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* RelativeOid_Decode_mE4574BFE63ABA7C1657B17B37854434120457BCD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* X509Cert_ParseTime_m315E259C5A6097A60455BBBF417F8770C849DAC9_RuntimeMethod_var;
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529_marshaled_com;
struct CultureData_t53CDF1C5F789A28897415891667799420D3C5529_marshaled_pinvoke;
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_com;
struct CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8;
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
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
struct U3CModuleU3E_t39A39E16240466000E23BBDA0E7436B7C616ED35 
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


// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt>
struct List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07, ____items_1)); }
	inline AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* get__items_1() const { return ____items_1; }
	inline AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07_StaticFields, ____emptyArray_5)); }
	inline AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* get__emptyArray_5() const { return ____emptyArray_5; }
	inline AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo>
struct List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18, ____items_1)); }
	inline SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057* get__items_1() const { return ____items_1; }
	inline SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18_StaticFields, ____emptyArray_5)); }
	inline SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057* get__emptyArray_5() const { return ____emptyArray_5; }
	inline SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(SignerInfoU5BU5D_t40BE6DBEAF75F7B207CA4C7E2164025982365057* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert>
struct List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3, ____items_1)); }
	inline X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB* get__items_1() const { return ____items_1; }
	inline X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3_StaticFields, ____emptyArray_5)); }
	inline X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB* get__emptyArray_5() const { return ____emptyArray_5; }
	inline X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(X509CertU5BU5D_t864FC06318ACDB31AB05235263659CF0BB6D73AB* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// UnityEngine.Purchasing.Security.AppleReceiptParser
struct AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433  : public RuntimeObject
{
public:

public:
};

struct AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.String,System.Object> UnityEngine.Purchasing.Security.AppleReceiptParser::_mostRecentReceiptData
	Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * ____mostRecentReceiptData_0;

public:
	inline static int32_t get_offset_of__mostRecentReceiptData_0() { return static_cast<int32_t>(offsetof(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields, ____mostRecentReceiptData_0)); }
	inline Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * get__mostRecentReceiptData_0() const { return ____mostRecentReceiptData_0; }
	inline Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 ** get_address_of__mostRecentReceiptData_0() { return &____mostRecentReceiptData_0; }
	inline void set__mostRecentReceiptData_0(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * value)
	{
		____mostRecentReceiptData_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____mostRecentReceiptData_0), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// System.Collections.ArrayList
struct ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575  : public RuntimeObject
{
public:
	// System.Object[] System.Collections.ArrayList::_items
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ____items_0;
	// System.Int32 System.Collections.ArrayList::_size
	int32_t ____size_1;
	// System.Int32 System.Collections.ArrayList::_version
	int32_t ____version_2;
	// System.Object System.Collections.ArrayList::_syncRoot
	RuntimeObject * ____syncRoot_3;

public:
	inline static int32_t get_offset_of__items_0() { return static_cast<int32_t>(offsetof(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575, ____items_0)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get__items_0() const { return ____items_0; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of__items_0() { return &____items_0; }
	inline void set__items_0(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		____items_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_0), (void*)value);
	}

	inline static int32_t get_offset_of__size_1() { return static_cast<int32_t>(offsetof(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575, ____size_1)); }
	inline int32_t get__size_1() const { return ____size_1; }
	inline int32_t* get_address_of__size_1() { return &____size_1; }
	inline void set__size_1(int32_t value)
	{
		____size_1 = value;
	}

	inline static int32_t get_offset_of__version_2() { return static_cast<int32_t>(offsetof(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575, ____version_2)); }
	inline int32_t get__version_2() const { return ____version_2; }
	inline int32_t* get_address_of__version_2() { return &____version_2; }
	inline void set__version_2(int32_t value)
	{
		____version_2 = value;
	}

	inline static int32_t get_offset_of__syncRoot_3() { return static_cast<int32_t>(offsetof(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575, ____syncRoot_3)); }
	inline RuntimeObject * get__syncRoot_3() const { return ____syncRoot_3; }
	inline RuntimeObject ** get_address_of__syncRoot_3() { return &____syncRoot_3; }
	inline void set__syncRoot_3(RuntimeObject * value)
	{
		____syncRoot_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_3), (void*)value);
	}
};

struct ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575_StaticFields
{
public:
	// System.Object[] System.Collections.ArrayList::emptyArray
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___emptyArray_5;

public:
	inline static int32_t get_offset_of_emptyArray_5() { return static_cast<int32_t>(offsetof(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575_StaticFields, ___emptyArray_5)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get_emptyArray_5() const { return ___emptyArray_5; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of_emptyArray_5() { return &___emptyArray_5; }
	inline void set_emptyArray_5(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		___emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___emptyArray_5), (void*)value);
	}
};


// LipingShare.LCLib.Asn1Processor.Asn1Node
struct Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3  : public RuntimeObject
{
public:
	// System.Byte LipingShare.LCLib.Asn1Processor.Asn1Node::tag
	uint8_t ___tag_0;
	// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::dataOffset
	int64_t ___dataOffset_1;
	// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::dataLength
	int64_t ___dataLength_2;
	// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::lengthFieldBytes
	int64_t ___lengthFieldBytes_3;
	// System.Byte[] LipingShare.LCLib.Asn1Processor.Asn1Node::data
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___data_4;
	// System.Collections.ArrayList LipingShare.LCLib.Asn1Processor.Asn1Node::childNodeList
	ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * ___childNodeList_5;
	// System.Byte LipingShare.LCLib.Asn1Processor.Asn1Node::unusedBits
	uint8_t ___unusedBits_6;
	// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::deepness
	int64_t ___deepness_7;
	// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::path
	String_t* ___path_8;
	// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Node::parentNode
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___parentNode_9;
	// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::requireRecalculatePar
	bool ___requireRecalculatePar_10;
	// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::isIndefiniteLength
	bool ___isIndefiniteLength_11;
	// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::parseEncapsulatedData
	bool ___parseEncapsulatedData_12;

public:
	inline static int32_t get_offset_of_tag_0() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___tag_0)); }
	inline uint8_t get_tag_0() const { return ___tag_0; }
	inline uint8_t* get_address_of_tag_0() { return &___tag_0; }
	inline void set_tag_0(uint8_t value)
	{
		___tag_0 = value;
	}

	inline static int32_t get_offset_of_dataOffset_1() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___dataOffset_1)); }
	inline int64_t get_dataOffset_1() const { return ___dataOffset_1; }
	inline int64_t* get_address_of_dataOffset_1() { return &___dataOffset_1; }
	inline void set_dataOffset_1(int64_t value)
	{
		___dataOffset_1 = value;
	}

	inline static int32_t get_offset_of_dataLength_2() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___dataLength_2)); }
	inline int64_t get_dataLength_2() const { return ___dataLength_2; }
	inline int64_t* get_address_of_dataLength_2() { return &___dataLength_2; }
	inline void set_dataLength_2(int64_t value)
	{
		___dataLength_2 = value;
	}

	inline static int32_t get_offset_of_lengthFieldBytes_3() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___lengthFieldBytes_3)); }
	inline int64_t get_lengthFieldBytes_3() const { return ___lengthFieldBytes_3; }
	inline int64_t* get_address_of_lengthFieldBytes_3() { return &___lengthFieldBytes_3; }
	inline void set_lengthFieldBytes_3(int64_t value)
	{
		___lengthFieldBytes_3 = value;
	}

	inline static int32_t get_offset_of_data_4() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___data_4)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_data_4() const { return ___data_4; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_data_4() { return &___data_4; }
	inline void set_data_4(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___data_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___data_4), (void*)value);
	}

	inline static int32_t get_offset_of_childNodeList_5() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___childNodeList_5)); }
	inline ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * get_childNodeList_5() const { return ___childNodeList_5; }
	inline ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 ** get_address_of_childNodeList_5() { return &___childNodeList_5; }
	inline void set_childNodeList_5(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * value)
	{
		___childNodeList_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___childNodeList_5), (void*)value);
	}

	inline static int32_t get_offset_of_unusedBits_6() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___unusedBits_6)); }
	inline uint8_t get_unusedBits_6() const { return ___unusedBits_6; }
	inline uint8_t* get_address_of_unusedBits_6() { return &___unusedBits_6; }
	inline void set_unusedBits_6(uint8_t value)
	{
		___unusedBits_6 = value;
	}

	inline static int32_t get_offset_of_deepness_7() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___deepness_7)); }
	inline int64_t get_deepness_7() const { return ___deepness_7; }
	inline int64_t* get_address_of_deepness_7() { return &___deepness_7; }
	inline void set_deepness_7(int64_t value)
	{
		___deepness_7 = value;
	}

	inline static int32_t get_offset_of_path_8() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___path_8)); }
	inline String_t* get_path_8() const { return ___path_8; }
	inline String_t** get_address_of_path_8() { return &___path_8; }
	inline void set_path_8(String_t* value)
	{
		___path_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___path_8), (void*)value);
	}

	inline static int32_t get_offset_of_parentNode_9() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___parentNode_9)); }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * get_parentNode_9() const { return ___parentNode_9; }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 ** get_address_of_parentNode_9() { return &___parentNode_9; }
	inline void set_parentNode_9(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * value)
	{
		___parentNode_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___parentNode_9), (void*)value);
	}

	inline static int32_t get_offset_of_requireRecalculatePar_10() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___requireRecalculatePar_10)); }
	inline bool get_requireRecalculatePar_10() const { return ___requireRecalculatePar_10; }
	inline bool* get_address_of_requireRecalculatePar_10() { return &___requireRecalculatePar_10; }
	inline void set_requireRecalculatePar_10(bool value)
	{
		___requireRecalculatePar_10 = value;
	}

	inline static int32_t get_offset_of_isIndefiniteLength_11() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___isIndefiniteLength_11)); }
	inline bool get_isIndefiniteLength_11() const { return ___isIndefiniteLength_11; }
	inline bool* get_address_of_isIndefiniteLength_11() { return &___isIndefiniteLength_11; }
	inline void set_isIndefiniteLength_11(bool value)
	{
		___isIndefiniteLength_11 = value;
	}

	inline static int32_t get_offset_of_parseEncapsulatedData_12() { return static_cast<int32_t>(offsetof(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3, ___parseEncapsulatedData_12)); }
	inline bool get_parseEncapsulatedData_12() const { return ___parseEncapsulatedData_12; }
	inline bool* get_address_of_parseEncapsulatedData_12() { return &___parseEncapsulatedData_12; }
	inline void set_parseEncapsulatedData_12(bool value)
	{
		___parseEncapsulatedData_12 = value;
	}
};


// LipingShare.LCLib.Asn1Processor.Asn1Parser
struct Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD  : public RuntimeObject
{
public:
	// System.Byte[] LipingShare.LCLib.Asn1Processor.Asn1Parser::rawData
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___rawData_0;
	// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Parser::rootNode
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___rootNode_1;

public:
	inline static int32_t get_offset_of_rawData_0() { return static_cast<int32_t>(offsetof(Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD, ___rawData_0)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_rawData_0() const { return ___rawData_0; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_rawData_0() { return &___rawData_0; }
	inline void set_rawData_0(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___rawData_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___rawData_0), (void*)value);
	}

	inline static int32_t get_offset_of_rootNode_1() { return static_cast<int32_t>(offsetof(Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD, ___rootNode_1)); }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * get_rootNode_1() const { return ___rootNode_1; }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 ** get_address_of_rootNode_1() { return &___rootNode_1; }
	inline void set_rootNode_1(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * value)
	{
		___rootNode_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___rootNode_1), (void*)value);
	}
};


// LipingShare.LCLib.Asn1Processor.Asn1Util
struct Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E  : public RuntimeObject
{
public:

public:
};

struct Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_StaticFields
{
public:
	// System.Char[] LipingShare.LCLib.Asn1Processor.Asn1Util::hexDigits
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___hexDigits_0;

public:
	inline static int32_t get_offset_of_hexDigits_0() { return static_cast<int32_t>(offsetof(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_StaticFields, ___hexDigits_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_hexDigits_0() const { return ___hexDigits_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_hexDigits_0() { return &___hexDigits_0; }
	inline void set_hexDigits_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___hexDigits_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___hexDigits_0), (void*)value);
	}
};


// System.Security.Cryptography.AsymmetricAlgorithm
struct AsymmetricAlgorithm_t3519DD47C199C0F5A666E99931C22F84487EE51F  : public RuntimeObject
{
public:
	// System.Int32 System.Security.Cryptography.AsymmetricAlgorithm::KeySizeValue
	int32_t ___KeySizeValue_0;
	// System.Security.Cryptography.KeySizes[] System.Security.Cryptography.AsymmetricAlgorithm::LegalKeySizesValue
	KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* ___LegalKeySizesValue_1;

public:
	inline static int32_t get_offset_of_KeySizeValue_0() { return static_cast<int32_t>(offsetof(AsymmetricAlgorithm_t3519DD47C199C0F5A666E99931C22F84487EE51F, ___KeySizeValue_0)); }
	inline int32_t get_KeySizeValue_0() const { return ___KeySizeValue_0; }
	inline int32_t* get_address_of_KeySizeValue_0() { return &___KeySizeValue_0; }
	inline void set_KeySizeValue_0(int32_t value)
	{
		___KeySizeValue_0 = value;
	}

	inline static int32_t get_offset_of_LegalKeySizesValue_1() { return static_cast<int32_t>(offsetof(AsymmetricAlgorithm_t3519DD47C199C0F5A666E99931C22F84487EE51F, ___LegalKeySizesValue_1)); }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* get_LegalKeySizesValue_1() const { return ___LegalKeySizesValue_1; }
	inline KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499** get_address_of_LegalKeySizesValue_1() { return &___LegalKeySizesValue_1; }
	inline void set_LegalKeySizesValue_1(KeySizesU5BU5D_tA093382691AAF32E84D3063E83C59472F9714499* value)
	{
		___LegalKeySizesValue_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___LegalKeySizesValue_1), (void*)value);
	}
};


// System.Runtime.ConstrainedExecution.CriticalFinalizerObject
struct CriticalFinalizerObject_tA3367C832FFE7434EB3C15C7136AF25524150997  : public RuntimeObject
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

// UnityEngine.Purchasing.Security.DistinguishedName
struct DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90  : public RuntimeObject
{
public:
	// System.String UnityEngine.Purchasing.Security.DistinguishedName::<Country>k__BackingField
	String_t* ___U3CCountryU3Ek__BackingField_0;
	// System.String UnityEngine.Purchasing.Security.DistinguishedName::<Organization>k__BackingField
	String_t* ___U3COrganizationU3Ek__BackingField_1;
	// System.String UnityEngine.Purchasing.Security.DistinguishedName::<OrganizationalUnit>k__BackingField
	String_t* ___U3COrganizationalUnitU3Ek__BackingField_2;
	// System.String UnityEngine.Purchasing.Security.DistinguishedName::<Dnq>k__BackingField
	String_t* ___U3CDnqU3Ek__BackingField_3;
	// System.String UnityEngine.Purchasing.Security.DistinguishedName::<State>k__BackingField
	String_t* ___U3CStateU3Ek__BackingField_4;
	// System.String UnityEngine.Purchasing.Security.DistinguishedName::<CommonName>k__BackingField
	String_t* ___U3CCommonNameU3Ek__BackingField_5;
	// System.String UnityEngine.Purchasing.Security.DistinguishedName::<SerialNumber>k__BackingField
	String_t* ___U3CSerialNumberU3Ek__BackingField_6;

public:
	inline static int32_t get_offset_of_U3CCountryU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90, ___U3CCountryU3Ek__BackingField_0)); }
	inline String_t* get_U3CCountryU3Ek__BackingField_0() const { return ___U3CCountryU3Ek__BackingField_0; }
	inline String_t** get_address_of_U3CCountryU3Ek__BackingField_0() { return &___U3CCountryU3Ek__BackingField_0; }
	inline void set_U3CCountryU3Ek__BackingField_0(String_t* value)
	{
		___U3CCountryU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CCountryU3Ek__BackingField_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3COrganizationU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90, ___U3COrganizationU3Ek__BackingField_1)); }
	inline String_t* get_U3COrganizationU3Ek__BackingField_1() const { return ___U3COrganizationU3Ek__BackingField_1; }
	inline String_t** get_address_of_U3COrganizationU3Ek__BackingField_1() { return &___U3COrganizationU3Ek__BackingField_1; }
	inline void set_U3COrganizationU3Ek__BackingField_1(String_t* value)
	{
		___U3COrganizationU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3COrganizationU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3COrganizationalUnitU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90, ___U3COrganizationalUnitU3Ek__BackingField_2)); }
	inline String_t* get_U3COrganizationalUnitU3Ek__BackingField_2() const { return ___U3COrganizationalUnitU3Ek__BackingField_2; }
	inline String_t** get_address_of_U3COrganizationalUnitU3Ek__BackingField_2() { return &___U3COrganizationalUnitU3Ek__BackingField_2; }
	inline void set_U3COrganizationalUnitU3Ek__BackingField_2(String_t* value)
	{
		___U3COrganizationalUnitU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3COrganizationalUnitU3Ek__BackingField_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CDnqU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90, ___U3CDnqU3Ek__BackingField_3)); }
	inline String_t* get_U3CDnqU3Ek__BackingField_3() const { return ___U3CDnqU3Ek__BackingField_3; }
	inline String_t** get_address_of_U3CDnqU3Ek__BackingField_3() { return &___U3CDnqU3Ek__BackingField_3; }
	inline void set_U3CDnqU3Ek__BackingField_3(String_t* value)
	{
		___U3CDnqU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CDnqU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CStateU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90, ___U3CStateU3Ek__BackingField_4)); }
	inline String_t* get_U3CStateU3Ek__BackingField_4() const { return ___U3CStateU3Ek__BackingField_4; }
	inline String_t** get_address_of_U3CStateU3Ek__BackingField_4() { return &___U3CStateU3Ek__BackingField_4; }
	inline void set_U3CStateU3Ek__BackingField_4(String_t* value)
	{
		___U3CStateU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CStateU3Ek__BackingField_4), (void*)value);
	}

	inline static int32_t get_offset_of_U3CCommonNameU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90, ___U3CCommonNameU3Ek__BackingField_5)); }
	inline String_t* get_U3CCommonNameU3Ek__BackingField_5() const { return ___U3CCommonNameU3Ek__BackingField_5; }
	inline String_t** get_address_of_U3CCommonNameU3Ek__BackingField_5() { return &___U3CCommonNameU3Ek__BackingField_5; }
	inline void set_U3CCommonNameU3Ek__BackingField_5(String_t* value)
	{
		___U3CCommonNameU3Ek__BackingField_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CCommonNameU3Ek__BackingField_5), (void*)value);
	}

	inline static int32_t get_offset_of_U3CSerialNumberU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90, ___U3CSerialNumberU3Ek__BackingField_6)); }
	inline String_t* get_U3CSerialNumberU3Ek__BackingField_6() const { return ___U3CSerialNumberU3Ek__BackingField_6; }
	inline String_t** get_address_of_U3CSerialNumberU3Ek__BackingField_6() { return &___U3CSerialNumberU3Ek__BackingField_6; }
	inline void set_U3CSerialNumberU3Ek__BackingField_6(String_t* value)
	{
		___U3CSerialNumberU3Ek__BackingField_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CSerialNumberU3Ek__BackingField_6), (void*)value);
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

// LipingShare.LCLib.Asn1Processor.Oid
struct Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D  : public RuntimeObject
{
public:

public:
};

struct Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_StaticFields
{
public:
	// System.Collections.Specialized.StringDictionary LipingShare.LCLib.Asn1Processor.Oid::oidDictionary
	StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 * ___oidDictionary_0;

public:
	inline static int32_t get_offset_of_oidDictionary_0() { return static_cast<int32_t>(offsetof(Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_StaticFields, ___oidDictionary_0)); }
	inline StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 * get_oidDictionary_0() const { return ___oidDictionary_0; }
	inline StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 ** get_address_of_oidDictionary_0() { return &___oidDictionary_0; }
	inline void set_oidDictionary_0(StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 * value)
	{
		___oidDictionary_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___oidDictionary_0), (void*)value);
	}
};


// UnityEngine.Purchasing.Security.PKCS7
struct PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71  : public RuntimeObject
{
public:
	// LipingShare.LCLib.Asn1Processor.Asn1Node UnityEngine.Purchasing.Security.PKCS7::root
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___root_0;
	// LipingShare.LCLib.Asn1Processor.Asn1Node UnityEngine.Purchasing.Security.PKCS7::<data>k__BackingField
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___U3CdataU3Ek__BackingField_1;
	// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo> UnityEngine.Purchasing.Security.PKCS7::<sinfos>k__BackingField
	List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * ___U3CsinfosU3Ek__BackingField_2;
	// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert> UnityEngine.Purchasing.Security.PKCS7::<certChain>k__BackingField
	List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * ___U3CcertChainU3Ek__BackingField_3;
	// System.Boolean UnityEngine.Purchasing.Security.PKCS7::validStructure
	bool ___validStructure_4;

public:
	inline static int32_t get_offset_of_root_0() { return static_cast<int32_t>(offsetof(PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71, ___root_0)); }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * get_root_0() const { return ___root_0; }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 ** get_address_of_root_0() { return &___root_0; }
	inline void set_root_0(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * value)
	{
		___root_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___root_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CdataU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71, ___U3CdataU3Ek__BackingField_1)); }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * get_U3CdataU3Ek__BackingField_1() const { return ___U3CdataU3Ek__BackingField_1; }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 ** get_address_of_U3CdataU3Ek__BackingField_1() { return &___U3CdataU3Ek__BackingField_1; }
	inline void set_U3CdataU3Ek__BackingField_1(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * value)
	{
		___U3CdataU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CdataU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CsinfosU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71, ___U3CsinfosU3Ek__BackingField_2)); }
	inline List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * get_U3CsinfosU3Ek__BackingField_2() const { return ___U3CsinfosU3Ek__BackingField_2; }
	inline List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 ** get_address_of_U3CsinfosU3Ek__BackingField_2() { return &___U3CsinfosU3Ek__BackingField_2; }
	inline void set_U3CsinfosU3Ek__BackingField_2(List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * value)
	{
		___U3CsinfosU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CsinfosU3Ek__BackingField_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CcertChainU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71, ___U3CcertChainU3Ek__BackingField_3)); }
	inline List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * get_U3CcertChainU3Ek__BackingField_3() const { return ___U3CcertChainU3Ek__BackingField_3; }
	inline List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 ** get_address_of_U3CcertChainU3Ek__BackingField_3() { return &___U3CcertChainU3Ek__BackingField_3; }
	inline void set_U3CcertChainU3Ek__BackingField_3(List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * value)
	{
		___U3CcertChainU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CcertChainU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_validStructure_4() { return static_cast<int32_t>(offsetof(PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71, ___validStructure_4)); }
	inline bool get_validStructure_4() const { return ___validStructure_4; }
	inline bool* get_address_of_validStructure_4() { return &___validStructure_4; }
	inline void set_validStructure_4(bool value)
	{
		___validStructure_4 = value;
	}
};


// UnityEngine.Purchasing.Security.RSAKey
struct RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6  : public RuntimeObject
{
public:
	// System.Security.Cryptography.RSACryptoServiceProvider UnityEngine.Purchasing.Security.RSAKey::<rsa>k__BackingField
	RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * ___U3CrsaU3Ek__BackingField_0;

public:
	inline static int32_t get_offset_of_U3CrsaU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6, ___U3CrsaU3Ek__BackingField_0)); }
	inline RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * get_U3CrsaU3Ek__BackingField_0() const { return ___U3CrsaU3Ek__BackingField_0; }
	inline RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 ** get_address_of_U3CrsaU3Ek__BackingField_0() { return &___U3CrsaU3Ek__BackingField_0; }
	inline void set_U3CrsaU3Ek__BackingField_0(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * value)
	{
		___U3CrsaU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CrsaU3Ek__BackingField_0), (void*)value);
	}
};


// UnityEngine.Purchasing.Security.SignerInfo
struct SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB  : public RuntimeObject
{
public:
	// System.Int32 UnityEngine.Purchasing.Security.SignerInfo::<Version>k__BackingField
	int32_t ___U3CVersionU3Ek__BackingField_0;
	// System.String UnityEngine.Purchasing.Security.SignerInfo::<IssuerSerialNumber>k__BackingField
	String_t* ___U3CIssuerSerialNumberU3Ek__BackingField_1;
	// System.Byte[] UnityEngine.Purchasing.Security.SignerInfo::<EncryptedDigest>k__BackingField
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___U3CEncryptedDigestU3Ek__BackingField_2;

public:
	inline static int32_t get_offset_of_U3CVersionU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB, ___U3CVersionU3Ek__BackingField_0)); }
	inline int32_t get_U3CVersionU3Ek__BackingField_0() const { return ___U3CVersionU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3CVersionU3Ek__BackingField_0() { return &___U3CVersionU3Ek__BackingField_0; }
	inline void set_U3CVersionU3Ek__BackingField_0(int32_t value)
	{
		___U3CVersionU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_U3CIssuerSerialNumberU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB, ___U3CIssuerSerialNumberU3Ek__BackingField_1)); }
	inline String_t* get_U3CIssuerSerialNumberU3Ek__BackingField_1() const { return ___U3CIssuerSerialNumberU3Ek__BackingField_1; }
	inline String_t** get_address_of_U3CIssuerSerialNumberU3Ek__BackingField_1() { return &___U3CIssuerSerialNumberU3Ek__BackingField_1; }
	inline void set_U3CIssuerSerialNumberU3Ek__BackingField_1(String_t* value)
	{
		___U3CIssuerSerialNumberU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CIssuerSerialNumberU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CEncryptedDigestU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB, ___U3CEncryptedDigestU3Ek__BackingField_2)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_U3CEncryptedDigestU3Ek__BackingField_2() const { return ___U3CEncryptedDigestU3Ek__BackingField_2; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_U3CEncryptedDigestU3Ek__BackingField_2() { return &___U3CEncryptedDigestU3Ek__BackingField_2; }
	inline void set_U3CEncryptedDigestU3Ek__BackingField_2(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___U3CEncryptedDigestU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CEncryptedDigestU3Ek__BackingField_2), (void*)value);
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


// System.Collections.Specialized.StringDictionary
struct StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79  : public RuntimeObject
{
public:
	// System.Collections.Hashtable System.Collections.Specialized.StringDictionary::contents
	Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * ___contents_0;

public:
	inline static int32_t get_offset_of_contents_0() { return static_cast<int32_t>(offsetof(StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79, ___contents_0)); }
	inline Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * get_contents_0() const { return ___contents_0; }
	inline Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC ** get_address_of_contents_0() { return &___contents_0; }
	inline void set_contents_0(Hashtable_t7565AB92A12227AD5BADD6911F10D87EE52509AC * value)
	{
		___contents_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___contents_0), (void*)value);
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


// System.DateTime
struct DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 
{
public:
	// System.UInt64 System.DateTime::dateData
	uint64_t ___dateData_44;

public:
	inline static int32_t get_offset_of_dateData_44() { return static_cast<int32_t>(offsetof(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405, ___dateData_44)); }
	inline uint64_t get_dateData_44() const { return ___dateData_44; }
	inline uint64_t* get_address_of_dateData_44() { return &___dateData_44; }
	inline void set_dateData_44(uint64_t value)
	{
		___dateData_44 = value;
	}
};

struct DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_StaticFields
{
public:
	// System.Int32[] System.DateTime::DaysToMonth365
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___DaysToMonth365_29;
	// System.Int32[] System.DateTime::DaysToMonth366
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___DaysToMonth366_30;
	// System.DateTime System.DateTime::MinValue
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___MinValue_31;
	// System.DateTime System.DateTime::MaxValue
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___MaxValue_32;

public:
	inline static int32_t get_offset_of_DaysToMonth365_29() { return static_cast<int32_t>(offsetof(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_StaticFields, ___DaysToMonth365_29)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_DaysToMonth365_29() const { return ___DaysToMonth365_29; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_DaysToMonth365_29() { return &___DaysToMonth365_29; }
	inline void set_DaysToMonth365_29(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___DaysToMonth365_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___DaysToMonth365_29), (void*)value);
	}

	inline static int32_t get_offset_of_DaysToMonth366_30() { return static_cast<int32_t>(offsetof(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_StaticFields, ___DaysToMonth366_30)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_DaysToMonth366_30() const { return ___DaysToMonth366_30; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_DaysToMonth366_30() { return &___DaysToMonth366_30; }
	inline void set_DaysToMonth366_30(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___DaysToMonth366_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___DaysToMonth366_30), (void*)value);
	}

	inline static int32_t get_offset_of_MinValue_31() { return static_cast<int32_t>(offsetof(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_StaticFields, ___MinValue_31)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_MinValue_31() const { return ___MinValue_31; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_MinValue_31() { return &___MinValue_31; }
	inline void set_MinValue_31(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___MinValue_31 = value;
	}

	inline static int32_t get_offset_of_MaxValue_32() { return static_cast<int32_t>(offsetof(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_StaticFields, ___MaxValue_32)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_MaxValue_32() const { return ___MaxValue_32; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_MaxValue_32() { return &___MaxValue_32; }
	inline void set_MaxValue_32(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___MaxValue_32 = value;
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


// System.Security.Cryptography.RSA
struct RSA_t69A71E36B9C80D9580996FE05CBA0BAF3CE5560B  : public AsymmetricAlgorithm_t3519DD47C199C0F5A666E99931C22F84487EE51F
{
public:

public:
};


// LipingShare.LCLib.Asn1Processor.RelativeOid
struct RelativeOid_t97392E06363F6AFF26543502032B89445860F72A  : public Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D
{
public:

public:
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


// System.Threading.Thread
struct Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414  : public CriticalFinalizerObject_tA3367C832FFE7434EB3C15C7136AF25524150997
{
public:
	// System.Threading.InternalThread System.Threading.Thread::internal_thread
	InternalThread_t12B78B27503AE19E9122E212419A66843BF746EB * ___internal_thread_6;
	// System.Object System.Threading.Thread::m_ThreadStartArg
	RuntimeObject * ___m_ThreadStartArg_7;
	// System.Object System.Threading.Thread::pending_exception
	RuntimeObject * ___pending_exception_8;
	// System.Security.Principal.IPrincipal System.Threading.Thread::principal
	RuntimeObject* ___principal_9;
	// System.Int32 System.Threading.Thread::principal_version
	int32_t ___principal_version_10;
	// System.MulticastDelegate System.Threading.Thread::m_Delegate
	MulticastDelegate_t * ___m_Delegate_12;
	// System.Threading.ExecutionContext System.Threading.Thread::m_ExecutionContext
	ExecutionContext_t16AC73BB21FEEEAD34A017877AC18DD8BB836414 * ___m_ExecutionContext_13;
	// System.Boolean System.Threading.Thread::m_ExecutionContextBelongsToOuterScope
	bool ___m_ExecutionContextBelongsToOuterScope_14;

public:
	inline static int32_t get_offset_of_internal_thread_6() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414, ___internal_thread_6)); }
	inline InternalThread_t12B78B27503AE19E9122E212419A66843BF746EB * get_internal_thread_6() const { return ___internal_thread_6; }
	inline InternalThread_t12B78B27503AE19E9122E212419A66843BF746EB ** get_address_of_internal_thread_6() { return &___internal_thread_6; }
	inline void set_internal_thread_6(InternalThread_t12B78B27503AE19E9122E212419A66843BF746EB * value)
	{
		___internal_thread_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___internal_thread_6), (void*)value);
	}

	inline static int32_t get_offset_of_m_ThreadStartArg_7() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414, ___m_ThreadStartArg_7)); }
	inline RuntimeObject * get_m_ThreadStartArg_7() const { return ___m_ThreadStartArg_7; }
	inline RuntimeObject ** get_address_of_m_ThreadStartArg_7() { return &___m_ThreadStartArg_7; }
	inline void set_m_ThreadStartArg_7(RuntimeObject * value)
	{
		___m_ThreadStartArg_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ThreadStartArg_7), (void*)value);
	}

	inline static int32_t get_offset_of_pending_exception_8() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414, ___pending_exception_8)); }
	inline RuntimeObject * get_pending_exception_8() const { return ___pending_exception_8; }
	inline RuntimeObject ** get_address_of_pending_exception_8() { return &___pending_exception_8; }
	inline void set_pending_exception_8(RuntimeObject * value)
	{
		___pending_exception_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___pending_exception_8), (void*)value);
	}

	inline static int32_t get_offset_of_principal_9() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414, ___principal_9)); }
	inline RuntimeObject* get_principal_9() const { return ___principal_9; }
	inline RuntimeObject** get_address_of_principal_9() { return &___principal_9; }
	inline void set_principal_9(RuntimeObject* value)
	{
		___principal_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___principal_9), (void*)value);
	}

	inline static int32_t get_offset_of_principal_version_10() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414, ___principal_version_10)); }
	inline int32_t get_principal_version_10() const { return ___principal_version_10; }
	inline int32_t* get_address_of_principal_version_10() { return &___principal_version_10; }
	inline void set_principal_version_10(int32_t value)
	{
		___principal_version_10 = value;
	}

	inline static int32_t get_offset_of_m_Delegate_12() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414, ___m_Delegate_12)); }
	inline MulticastDelegate_t * get_m_Delegate_12() const { return ___m_Delegate_12; }
	inline MulticastDelegate_t ** get_address_of_m_Delegate_12() { return &___m_Delegate_12; }
	inline void set_m_Delegate_12(MulticastDelegate_t * value)
	{
		___m_Delegate_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Delegate_12), (void*)value);
	}

	inline static int32_t get_offset_of_m_ExecutionContext_13() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414, ___m_ExecutionContext_13)); }
	inline ExecutionContext_t16AC73BB21FEEEAD34A017877AC18DD8BB836414 * get_m_ExecutionContext_13() const { return ___m_ExecutionContext_13; }
	inline ExecutionContext_t16AC73BB21FEEEAD34A017877AC18DD8BB836414 ** get_address_of_m_ExecutionContext_13() { return &___m_ExecutionContext_13; }
	inline void set_m_ExecutionContext_13(ExecutionContext_t16AC73BB21FEEEAD34A017877AC18DD8BB836414 * value)
	{
		___m_ExecutionContext_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ExecutionContext_13), (void*)value);
	}

	inline static int32_t get_offset_of_m_ExecutionContextBelongsToOuterScope_14() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414, ___m_ExecutionContextBelongsToOuterScope_14)); }
	inline bool get_m_ExecutionContextBelongsToOuterScope_14() const { return ___m_ExecutionContextBelongsToOuterScope_14; }
	inline bool* get_address_of_m_ExecutionContextBelongsToOuterScope_14() { return &___m_ExecutionContextBelongsToOuterScope_14; }
	inline void set_m_ExecutionContextBelongsToOuterScope_14(bool value)
	{
		___m_ExecutionContextBelongsToOuterScope_14 = value;
	}
};

struct Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_StaticFields
{
public:
	// System.LocalDataStoreMgr System.Threading.Thread::s_LocalDataStoreMgr
	LocalDataStoreMgr_t6CC44D0584911B6A6C6823115F858FC34AB4A80A * ___s_LocalDataStoreMgr_0;
	// System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> System.Threading.Thread::s_asyncLocalCurrentCulture
	AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349 * ___s_asyncLocalCurrentCulture_4;
	// System.Threading.AsyncLocal`1<System.Globalization.CultureInfo> System.Threading.Thread::s_asyncLocalCurrentUICulture
	AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349 * ___s_asyncLocalCurrentUICulture_5;

public:
	inline static int32_t get_offset_of_s_LocalDataStoreMgr_0() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_StaticFields, ___s_LocalDataStoreMgr_0)); }
	inline LocalDataStoreMgr_t6CC44D0584911B6A6C6823115F858FC34AB4A80A * get_s_LocalDataStoreMgr_0() const { return ___s_LocalDataStoreMgr_0; }
	inline LocalDataStoreMgr_t6CC44D0584911B6A6C6823115F858FC34AB4A80A ** get_address_of_s_LocalDataStoreMgr_0() { return &___s_LocalDataStoreMgr_0; }
	inline void set_s_LocalDataStoreMgr_0(LocalDataStoreMgr_t6CC44D0584911B6A6C6823115F858FC34AB4A80A * value)
	{
		___s_LocalDataStoreMgr_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_LocalDataStoreMgr_0), (void*)value);
	}

	inline static int32_t get_offset_of_s_asyncLocalCurrentCulture_4() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_StaticFields, ___s_asyncLocalCurrentCulture_4)); }
	inline AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349 * get_s_asyncLocalCurrentCulture_4() const { return ___s_asyncLocalCurrentCulture_4; }
	inline AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349 ** get_address_of_s_asyncLocalCurrentCulture_4() { return &___s_asyncLocalCurrentCulture_4; }
	inline void set_s_asyncLocalCurrentCulture_4(AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349 * value)
	{
		___s_asyncLocalCurrentCulture_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_asyncLocalCurrentCulture_4), (void*)value);
	}

	inline static int32_t get_offset_of_s_asyncLocalCurrentUICulture_5() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_StaticFields, ___s_asyncLocalCurrentUICulture_5)); }
	inline AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349 * get_s_asyncLocalCurrentUICulture_5() const { return ___s_asyncLocalCurrentUICulture_5; }
	inline AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349 ** get_address_of_s_asyncLocalCurrentUICulture_5() { return &___s_asyncLocalCurrentUICulture_5; }
	inline void set_s_asyncLocalCurrentUICulture_5(AsyncLocal_1_t480A201BA0D1C62C2C6FA6598EEDF7BB35D85349 * value)
	{
		___s_asyncLocalCurrentUICulture_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_asyncLocalCurrentUICulture_5), (void*)value);
	}
};

struct Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_ThreadStaticFields
{
public:
	// System.LocalDataStoreHolder System.Threading.Thread::s_LocalDataStore
	LocalDataStoreHolder_tF51C9DD735A89132114AE47E3EB51C11D0FED146 * ___s_LocalDataStore_1;
	// System.Globalization.CultureInfo System.Threading.Thread::m_CurrentCulture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___m_CurrentCulture_2;
	// System.Globalization.CultureInfo System.Threading.Thread::m_CurrentUICulture
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___m_CurrentUICulture_3;
	// System.Threading.Thread System.Threading.Thread::current_thread
	Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * ___current_thread_11;

public:
	inline static int32_t get_offset_of_s_LocalDataStore_1() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_ThreadStaticFields, ___s_LocalDataStore_1)); }
	inline LocalDataStoreHolder_tF51C9DD735A89132114AE47E3EB51C11D0FED146 * get_s_LocalDataStore_1() const { return ___s_LocalDataStore_1; }
	inline LocalDataStoreHolder_tF51C9DD735A89132114AE47E3EB51C11D0FED146 ** get_address_of_s_LocalDataStore_1() { return &___s_LocalDataStore_1; }
	inline void set_s_LocalDataStore_1(LocalDataStoreHolder_tF51C9DD735A89132114AE47E3EB51C11D0FED146 * value)
	{
		___s_LocalDataStore_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_LocalDataStore_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_CurrentCulture_2() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_ThreadStaticFields, ___m_CurrentCulture_2)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get_m_CurrentCulture_2() const { return ___m_CurrentCulture_2; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of_m_CurrentCulture_2() { return &___m_CurrentCulture_2; }
	inline void set_m_CurrentCulture_2(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		___m_CurrentCulture_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CurrentCulture_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_CurrentUICulture_3() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_ThreadStaticFields, ___m_CurrentUICulture_3)); }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * get_m_CurrentUICulture_3() const { return ___m_CurrentUICulture_3; }
	inline CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 ** get_address_of_m_CurrentUICulture_3() { return &___m_CurrentUICulture_3; }
	inline void set_m_CurrentUICulture_3(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * value)
	{
		___m_CurrentUICulture_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CurrentUICulture_3), (void*)value);
	}

	inline static int32_t get_offset_of_current_thread_11() { return static_cast<int32_t>(offsetof(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414_ThreadStaticFields, ___current_thread_11)); }
	inline Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * get_current_thread_11() const { return ___current_thread_11; }
	inline Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 ** get_address_of_current_thread_11() { return &___current_thread_11; }
	inline void set_current_thread_11(Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * value)
	{
		___current_thread_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___current_thread_11), (void*)value);
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


// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32
struct __StaticArrayInitTypeSizeU3D32_t60BA3D78537C5993EE55D197EBECDE62DF05C712 
{
public:
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D32_t60BA3D78537C5993EE55D197EBECDE62DF05C712__padding[32];
	};

public:
};


// <PrivateImplementationDetails>
struct U3CPrivateImplementationDetailsU3E_tD58C289ECB60EF91D67519C579A83B4F9F1364B0  : public RuntimeObject
{
public:

public:
};

struct U3CPrivateImplementationDetailsU3E_tD58C289ECB60EF91D67519C579A83B4F9F1364B0_StaticFields
{
public:
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70
	__StaticArrayInitTypeSizeU3D32_t60BA3D78537C5993EE55D197EBECDE62DF05C712  ___2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0;

public:
	inline static int32_t get_offset_of_U32EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0() { return static_cast<int32_t>(offsetof(U3CPrivateImplementationDetailsU3E_tD58C289ECB60EF91D67519C579A83B4F9F1364B0_StaticFields, ___2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0)); }
	inline __StaticArrayInitTypeSizeU3D32_t60BA3D78537C5993EE55D197EBECDE62DF05C712  get_U32EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0() const { return ___2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0; }
	inline __StaticArrayInitTypeSizeU3D32_t60BA3D78537C5993EE55D197EBECDE62DF05C712 * get_address_of_U32EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0() { return &___2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0; }
	inline void set_U32EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0(__StaticArrayInitTypeSizeU3D32_t60BA3D78537C5993EE55D197EBECDE62DF05C712  value)
	{
		___2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0 = value;
	}
};


// UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt
struct AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36  : public RuntimeObject
{
public:
	// System.Int32 UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<quantity>k__BackingField
	int32_t ___U3CquantityU3Ek__BackingField_0;
	// System.String UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<productID>k__BackingField
	String_t* ___U3CproductIDU3Ek__BackingField_1;
	// System.String UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<transactionID>k__BackingField
	String_t* ___U3CtransactionIDU3Ek__BackingField_2;
	// System.String UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<originalTransactionIdentifier>k__BackingField
	String_t* ___U3CoriginalTransactionIdentifierU3Ek__BackingField_3;
	// System.DateTime UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<purchaseDate>k__BackingField
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___U3CpurchaseDateU3Ek__BackingField_4;
	// System.DateTime UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<originalPurchaseDate>k__BackingField
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___U3CoriginalPurchaseDateU3Ek__BackingField_5;
	// System.DateTime UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<subscriptionExpirationDate>k__BackingField
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___U3CsubscriptionExpirationDateU3Ek__BackingField_6;
	// System.DateTime UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<cancellationDate>k__BackingField
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___U3CcancellationDateU3Ek__BackingField_7;
	// System.Int32 UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<isFreeTrial>k__BackingField
	int32_t ___U3CisFreeTrialU3Ek__BackingField_8;
	// System.Int32 UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<productType>k__BackingField
	int32_t ___U3CproductTypeU3Ek__BackingField_9;
	// System.Int32 UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::<isIntroductoryPricePeriod>k__BackingField
	int32_t ___U3CisIntroductoryPricePeriodU3Ek__BackingField_10;

public:
	inline static int32_t get_offset_of_U3CquantityU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CquantityU3Ek__BackingField_0)); }
	inline int32_t get_U3CquantityU3Ek__BackingField_0() const { return ___U3CquantityU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3CquantityU3Ek__BackingField_0() { return &___U3CquantityU3Ek__BackingField_0; }
	inline void set_U3CquantityU3Ek__BackingField_0(int32_t value)
	{
		___U3CquantityU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_U3CproductIDU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CproductIDU3Ek__BackingField_1)); }
	inline String_t* get_U3CproductIDU3Ek__BackingField_1() const { return ___U3CproductIDU3Ek__BackingField_1; }
	inline String_t** get_address_of_U3CproductIDU3Ek__BackingField_1() { return &___U3CproductIDU3Ek__BackingField_1; }
	inline void set_U3CproductIDU3Ek__BackingField_1(String_t* value)
	{
		___U3CproductIDU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CproductIDU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CtransactionIDU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CtransactionIDU3Ek__BackingField_2)); }
	inline String_t* get_U3CtransactionIDU3Ek__BackingField_2() const { return ___U3CtransactionIDU3Ek__BackingField_2; }
	inline String_t** get_address_of_U3CtransactionIDU3Ek__BackingField_2() { return &___U3CtransactionIDU3Ek__BackingField_2; }
	inline void set_U3CtransactionIDU3Ek__BackingField_2(String_t* value)
	{
		___U3CtransactionIDU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CtransactionIDU3Ek__BackingField_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3CoriginalTransactionIdentifierU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CoriginalTransactionIdentifierU3Ek__BackingField_3)); }
	inline String_t* get_U3CoriginalTransactionIdentifierU3Ek__BackingField_3() const { return ___U3CoriginalTransactionIdentifierU3Ek__BackingField_3; }
	inline String_t** get_address_of_U3CoriginalTransactionIdentifierU3Ek__BackingField_3() { return &___U3CoriginalTransactionIdentifierU3Ek__BackingField_3; }
	inline void set_U3CoriginalTransactionIdentifierU3Ek__BackingField_3(String_t* value)
	{
		___U3CoriginalTransactionIdentifierU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CoriginalTransactionIdentifierU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CpurchaseDateU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CpurchaseDateU3Ek__BackingField_4)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_U3CpurchaseDateU3Ek__BackingField_4() const { return ___U3CpurchaseDateU3Ek__BackingField_4; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_U3CpurchaseDateU3Ek__BackingField_4() { return &___U3CpurchaseDateU3Ek__BackingField_4; }
	inline void set_U3CpurchaseDateU3Ek__BackingField_4(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___U3CpurchaseDateU3Ek__BackingField_4 = value;
	}

	inline static int32_t get_offset_of_U3CoriginalPurchaseDateU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CoriginalPurchaseDateU3Ek__BackingField_5)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_U3CoriginalPurchaseDateU3Ek__BackingField_5() const { return ___U3CoriginalPurchaseDateU3Ek__BackingField_5; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_U3CoriginalPurchaseDateU3Ek__BackingField_5() { return &___U3CoriginalPurchaseDateU3Ek__BackingField_5; }
	inline void set_U3CoriginalPurchaseDateU3Ek__BackingField_5(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___U3CoriginalPurchaseDateU3Ek__BackingField_5 = value;
	}

	inline static int32_t get_offset_of_U3CsubscriptionExpirationDateU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CsubscriptionExpirationDateU3Ek__BackingField_6)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_U3CsubscriptionExpirationDateU3Ek__BackingField_6() const { return ___U3CsubscriptionExpirationDateU3Ek__BackingField_6; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_U3CsubscriptionExpirationDateU3Ek__BackingField_6() { return &___U3CsubscriptionExpirationDateU3Ek__BackingField_6; }
	inline void set_U3CsubscriptionExpirationDateU3Ek__BackingField_6(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___U3CsubscriptionExpirationDateU3Ek__BackingField_6 = value;
	}

	inline static int32_t get_offset_of_U3CcancellationDateU3Ek__BackingField_7() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CcancellationDateU3Ek__BackingField_7)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_U3CcancellationDateU3Ek__BackingField_7() const { return ___U3CcancellationDateU3Ek__BackingField_7; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_U3CcancellationDateU3Ek__BackingField_7() { return &___U3CcancellationDateU3Ek__BackingField_7; }
	inline void set_U3CcancellationDateU3Ek__BackingField_7(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___U3CcancellationDateU3Ek__BackingField_7 = value;
	}

	inline static int32_t get_offset_of_U3CisFreeTrialU3Ek__BackingField_8() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CisFreeTrialU3Ek__BackingField_8)); }
	inline int32_t get_U3CisFreeTrialU3Ek__BackingField_8() const { return ___U3CisFreeTrialU3Ek__BackingField_8; }
	inline int32_t* get_address_of_U3CisFreeTrialU3Ek__BackingField_8() { return &___U3CisFreeTrialU3Ek__BackingField_8; }
	inline void set_U3CisFreeTrialU3Ek__BackingField_8(int32_t value)
	{
		___U3CisFreeTrialU3Ek__BackingField_8 = value;
	}

	inline static int32_t get_offset_of_U3CproductTypeU3Ek__BackingField_9() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CproductTypeU3Ek__BackingField_9)); }
	inline int32_t get_U3CproductTypeU3Ek__BackingField_9() const { return ___U3CproductTypeU3Ek__BackingField_9; }
	inline int32_t* get_address_of_U3CproductTypeU3Ek__BackingField_9() { return &___U3CproductTypeU3Ek__BackingField_9; }
	inline void set_U3CproductTypeU3Ek__BackingField_9(int32_t value)
	{
		___U3CproductTypeU3Ek__BackingField_9 = value;
	}

	inline static int32_t get_offset_of_U3CisIntroductoryPricePeriodU3Ek__BackingField_10() { return static_cast<int32_t>(offsetof(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36, ___U3CisIntroductoryPricePeriodU3Ek__BackingField_10)); }
	inline int32_t get_U3CisIntroductoryPricePeriodU3Ek__BackingField_10() const { return ___U3CisIntroductoryPricePeriodU3Ek__BackingField_10; }
	inline int32_t* get_address_of_U3CisIntroductoryPricePeriodU3Ek__BackingField_10() { return &___U3CisIntroductoryPricePeriodU3Ek__BackingField_10; }
	inline void set_U3CisIntroductoryPricePeriodU3Ek__BackingField_10(int32_t value)
	{
		___U3CisIntroductoryPricePeriodU3Ek__BackingField_10 = value;
	}
};


// UnityEngine.Purchasing.Security.AppleReceipt
struct AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62  : public RuntimeObject
{
public:
	// System.String UnityEngine.Purchasing.Security.AppleReceipt::<bundleID>k__BackingField
	String_t* ___U3CbundleIDU3Ek__BackingField_0;
	// System.String UnityEngine.Purchasing.Security.AppleReceipt::<appVersion>k__BackingField
	String_t* ___U3CappVersionU3Ek__BackingField_1;
	// System.Byte[] UnityEngine.Purchasing.Security.AppleReceipt::<opaque>k__BackingField
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___U3CopaqueU3Ek__BackingField_2;
	// System.Byte[] UnityEngine.Purchasing.Security.AppleReceipt::<hash>k__BackingField
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___U3ChashU3Ek__BackingField_3;
	// System.String UnityEngine.Purchasing.Security.AppleReceipt::<originalApplicationVersion>k__BackingField
	String_t* ___U3CoriginalApplicationVersionU3Ek__BackingField_4;
	// System.DateTime UnityEngine.Purchasing.Security.AppleReceipt::<receiptCreationDate>k__BackingField
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___U3CreceiptCreationDateU3Ek__BackingField_5;
	// UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[] UnityEngine.Purchasing.Security.AppleReceipt::inAppPurchaseReceipts
	AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* ___inAppPurchaseReceipts_6;

public:
	inline static int32_t get_offset_of_U3CbundleIDU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62, ___U3CbundleIDU3Ek__BackingField_0)); }
	inline String_t* get_U3CbundleIDU3Ek__BackingField_0() const { return ___U3CbundleIDU3Ek__BackingField_0; }
	inline String_t** get_address_of_U3CbundleIDU3Ek__BackingField_0() { return &___U3CbundleIDU3Ek__BackingField_0; }
	inline void set_U3CbundleIDU3Ek__BackingField_0(String_t* value)
	{
		___U3CbundleIDU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CbundleIDU3Ek__BackingField_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CappVersionU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62, ___U3CappVersionU3Ek__BackingField_1)); }
	inline String_t* get_U3CappVersionU3Ek__BackingField_1() const { return ___U3CappVersionU3Ek__BackingField_1; }
	inline String_t** get_address_of_U3CappVersionU3Ek__BackingField_1() { return &___U3CappVersionU3Ek__BackingField_1; }
	inline void set_U3CappVersionU3Ek__BackingField_1(String_t* value)
	{
		___U3CappVersionU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CappVersionU3Ek__BackingField_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CopaqueU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62, ___U3CopaqueU3Ek__BackingField_2)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_U3CopaqueU3Ek__BackingField_2() const { return ___U3CopaqueU3Ek__BackingField_2; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_U3CopaqueU3Ek__BackingField_2() { return &___U3CopaqueU3Ek__BackingField_2; }
	inline void set_U3CopaqueU3Ek__BackingField_2(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___U3CopaqueU3Ek__BackingField_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CopaqueU3Ek__BackingField_2), (void*)value);
	}

	inline static int32_t get_offset_of_U3ChashU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62, ___U3ChashU3Ek__BackingField_3)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_U3ChashU3Ek__BackingField_3() const { return ___U3ChashU3Ek__BackingField_3; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_U3ChashU3Ek__BackingField_3() { return &___U3ChashU3Ek__BackingField_3; }
	inline void set_U3ChashU3Ek__BackingField_3(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___U3ChashU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3ChashU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CoriginalApplicationVersionU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62, ___U3CoriginalApplicationVersionU3Ek__BackingField_4)); }
	inline String_t* get_U3CoriginalApplicationVersionU3Ek__BackingField_4() const { return ___U3CoriginalApplicationVersionU3Ek__BackingField_4; }
	inline String_t** get_address_of_U3CoriginalApplicationVersionU3Ek__BackingField_4() { return &___U3CoriginalApplicationVersionU3Ek__BackingField_4; }
	inline void set_U3CoriginalApplicationVersionU3Ek__BackingField_4(String_t* value)
	{
		___U3CoriginalApplicationVersionU3Ek__BackingField_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CoriginalApplicationVersionU3Ek__BackingField_4), (void*)value);
	}

	inline static int32_t get_offset_of_U3CreceiptCreationDateU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62, ___U3CreceiptCreationDateU3Ek__BackingField_5)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_U3CreceiptCreationDateU3Ek__BackingField_5() const { return ___U3CreceiptCreationDateU3Ek__BackingField_5; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_U3CreceiptCreationDateU3Ek__BackingField_5() { return &___U3CreceiptCreationDateU3Ek__BackingField_5; }
	inline void set_U3CreceiptCreationDateU3Ek__BackingField_5(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___U3CreceiptCreationDateU3Ek__BackingField_5 = value;
	}

	inline static int32_t get_offset_of_inAppPurchaseReceipts_6() { return static_cast<int32_t>(offsetof(AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62, ___inAppPurchaseReceipts_6)); }
	inline AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* get_inAppPurchaseReceipts_6() const { return ___inAppPurchaseReceipts_6; }
	inline AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8** get_address_of_inAppPurchaseReceipts_6() { return &___inAppPurchaseReceipts_6; }
	inline void set_inAppPurchaseReceipts_6(AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* value)
	{
		___inAppPurchaseReceipts_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___inAppPurchaseReceipts_6), (void*)value);
	}
};


// LipingShare.LCLib.Asn1Processor.Asn1EndOfIndefiniteLengthNodeType
struct Asn1EndOfIndefiniteLengthNodeType_t851EDF7A77BDD4CD01F6B01F7E943516A6D4C918 
{
public:
	// System.Int32 LipingShare.LCLib.Asn1Processor.Asn1EndOfIndefiniteLengthNodeType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Asn1EndOfIndefiniteLengthNodeType_t851EDF7A77BDD4CD01F6B01F7E943516A6D4C918, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Security.Cryptography.CspProviderFlags
struct CspProviderFlags_t8981EF4CA441D46FBF242ABAA443608B474586D1 
{
public:
	// System.Int32 System.Security.Cryptography.CspProviderFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(CspProviderFlags_t8981EF4CA441D46FBF242ABAA443608B474586D1, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.DateTimeKind
struct DateTimeKind_tA0B5F3F88991AC3B7F24393E15B54062722571D0 
{
public:
	// System.Int32 System.DateTimeKind::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DateTimeKind_tA0B5F3F88991AC3B7F24393E15B54062722571D0, ___value___2)); }
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


// UnityEngine.Purchasing.Security.X509Cert
struct X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C  : public RuntimeObject
{
public:
	// System.String UnityEngine.Purchasing.Security.X509Cert::<SerialNumber>k__BackingField
	String_t* ___U3CSerialNumberU3Ek__BackingField_0;
	// System.DateTime UnityEngine.Purchasing.Security.X509Cert::<ValidAfter>k__BackingField
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___U3CValidAfterU3Ek__BackingField_1;
	// System.DateTime UnityEngine.Purchasing.Security.X509Cert::<ValidBefore>k__BackingField
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___U3CValidBeforeU3Ek__BackingField_2;
	// UnityEngine.Purchasing.Security.RSAKey UnityEngine.Purchasing.Security.X509Cert::<PubKey>k__BackingField
	RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * ___U3CPubKeyU3Ek__BackingField_3;
	// System.Boolean UnityEngine.Purchasing.Security.X509Cert::<SelfSigned>k__BackingField
	bool ___U3CSelfSignedU3Ek__BackingField_4;
	// UnityEngine.Purchasing.Security.DistinguishedName UnityEngine.Purchasing.Security.X509Cert::<Subject>k__BackingField
	DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___U3CSubjectU3Ek__BackingField_5;
	// UnityEngine.Purchasing.Security.DistinguishedName UnityEngine.Purchasing.Security.X509Cert::<Issuer>k__BackingField
	DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___U3CIssuerU3Ek__BackingField_6;
	// LipingShare.LCLib.Asn1Processor.Asn1Node UnityEngine.Purchasing.Security.X509Cert::TbsCertificate
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___TbsCertificate_7;
	// LipingShare.LCLib.Asn1Processor.Asn1Node UnityEngine.Purchasing.Security.X509Cert::<Signature>k__BackingField
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___U3CSignatureU3Ek__BackingField_8;
	// System.Byte[] UnityEngine.Purchasing.Security.X509Cert::rawTBSCertificate
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___rawTBSCertificate_9;

public:
	inline static int32_t get_offset_of_U3CSerialNumberU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___U3CSerialNumberU3Ek__BackingField_0)); }
	inline String_t* get_U3CSerialNumberU3Ek__BackingField_0() const { return ___U3CSerialNumberU3Ek__BackingField_0; }
	inline String_t** get_address_of_U3CSerialNumberU3Ek__BackingField_0() { return &___U3CSerialNumberU3Ek__BackingField_0; }
	inline void set_U3CSerialNumberU3Ek__BackingField_0(String_t* value)
	{
		___U3CSerialNumberU3Ek__BackingField_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CSerialNumberU3Ek__BackingField_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CValidAfterU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___U3CValidAfterU3Ek__BackingField_1)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_U3CValidAfterU3Ek__BackingField_1() const { return ___U3CValidAfterU3Ek__BackingField_1; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_U3CValidAfterU3Ek__BackingField_1() { return &___U3CValidAfterU3Ek__BackingField_1; }
	inline void set_U3CValidAfterU3Ek__BackingField_1(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___U3CValidAfterU3Ek__BackingField_1 = value;
	}

	inline static int32_t get_offset_of_U3CValidBeforeU3Ek__BackingField_2() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___U3CValidBeforeU3Ek__BackingField_2)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_U3CValidBeforeU3Ek__BackingField_2() const { return ___U3CValidBeforeU3Ek__BackingField_2; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_U3CValidBeforeU3Ek__BackingField_2() { return &___U3CValidBeforeU3Ek__BackingField_2; }
	inline void set_U3CValidBeforeU3Ek__BackingField_2(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___U3CValidBeforeU3Ek__BackingField_2 = value;
	}

	inline static int32_t get_offset_of_U3CPubKeyU3Ek__BackingField_3() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___U3CPubKeyU3Ek__BackingField_3)); }
	inline RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * get_U3CPubKeyU3Ek__BackingField_3() const { return ___U3CPubKeyU3Ek__BackingField_3; }
	inline RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 ** get_address_of_U3CPubKeyU3Ek__BackingField_3() { return &___U3CPubKeyU3Ek__BackingField_3; }
	inline void set_U3CPubKeyU3Ek__BackingField_3(RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * value)
	{
		___U3CPubKeyU3Ek__BackingField_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CPubKeyU3Ek__BackingField_3), (void*)value);
	}

	inline static int32_t get_offset_of_U3CSelfSignedU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___U3CSelfSignedU3Ek__BackingField_4)); }
	inline bool get_U3CSelfSignedU3Ek__BackingField_4() const { return ___U3CSelfSignedU3Ek__BackingField_4; }
	inline bool* get_address_of_U3CSelfSignedU3Ek__BackingField_4() { return &___U3CSelfSignedU3Ek__BackingField_4; }
	inline void set_U3CSelfSignedU3Ek__BackingField_4(bool value)
	{
		___U3CSelfSignedU3Ek__BackingField_4 = value;
	}

	inline static int32_t get_offset_of_U3CSubjectU3Ek__BackingField_5() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___U3CSubjectU3Ek__BackingField_5)); }
	inline DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * get_U3CSubjectU3Ek__BackingField_5() const { return ___U3CSubjectU3Ek__BackingField_5; }
	inline DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 ** get_address_of_U3CSubjectU3Ek__BackingField_5() { return &___U3CSubjectU3Ek__BackingField_5; }
	inline void set_U3CSubjectU3Ek__BackingField_5(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * value)
	{
		___U3CSubjectU3Ek__BackingField_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CSubjectU3Ek__BackingField_5), (void*)value);
	}

	inline static int32_t get_offset_of_U3CIssuerU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___U3CIssuerU3Ek__BackingField_6)); }
	inline DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * get_U3CIssuerU3Ek__BackingField_6() const { return ___U3CIssuerU3Ek__BackingField_6; }
	inline DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 ** get_address_of_U3CIssuerU3Ek__BackingField_6() { return &___U3CIssuerU3Ek__BackingField_6; }
	inline void set_U3CIssuerU3Ek__BackingField_6(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * value)
	{
		___U3CIssuerU3Ek__BackingField_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CIssuerU3Ek__BackingField_6), (void*)value);
	}

	inline static int32_t get_offset_of_TbsCertificate_7() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___TbsCertificate_7)); }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * get_TbsCertificate_7() const { return ___TbsCertificate_7; }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 ** get_address_of_TbsCertificate_7() { return &___TbsCertificate_7; }
	inline void set_TbsCertificate_7(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * value)
	{
		___TbsCertificate_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TbsCertificate_7), (void*)value);
	}

	inline static int32_t get_offset_of_U3CSignatureU3Ek__BackingField_8() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___U3CSignatureU3Ek__BackingField_8)); }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * get_U3CSignatureU3Ek__BackingField_8() const { return ___U3CSignatureU3Ek__BackingField_8; }
	inline Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 ** get_address_of_U3CSignatureU3Ek__BackingField_8() { return &___U3CSignatureU3Ek__BackingField_8; }
	inline void set_U3CSignatureU3Ek__BackingField_8(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * value)
	{
		___U3CSignatureU3Ek__BackingField_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CSignatureU3Ek__BackingField_8), (void*)value);
	}

	inline static int32_t get_offset_of_rawTBSCertificate_9() { return static_cast<int32_t>(offsetof(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C, ___rawTBSCertificate_9)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get_rawTBSCertificate_9() const { return ___rawTBSCertificate_9; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of_rawTBSCertificate_9() { return &___rawTBSCertificate_9; }
	inline void set_rawTBSCertificate_9(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		___rawTBSCertificate_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___rawTBSCertificate_9), (void*)value);
	}
};


// UnityEngine.Purchasing.Security.IAPSecurityException
struct IAPSecurityException_t0688C40275CE97C34325C2D6C5884694663D5EFA  : public Exception_t
{
public:

public:
};


// System.Security.Cryptography.RSACryptoServiceProvider
struct RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7  : public RSA_t69A71E36B9C80D9580996FE05CBA0BAF3CE5560B
{
public:
	// Mono.Security.Cryptography.KeyPairPersistence System.Security.Cryptography.RSACryptoServiceProvider::store
	KeyPairPersistence_t7F7E8811D03A25C0251BF255AB94BAF57E965D9A * ___store_6;
	// System.Boolean System.Security.Cryptography.RSACryptoServiceProvider::persistKey
	bool ___persistKey_7;
	// System.Boolean System.Security.Cryptography.RSACryptoServiceProvider::persisted
	bool ___persisted_8;
	// System.Boolean System.Security.Cryptography.RSACryptoServiceProvider::privateKeyExportable
	bool ___privateKeyExportable_9;
	// System.Boolean System.Security.Cryptography.RSACryptoServiceProvider::m_disposed
	bool ___m_disposed_10;
	// Mono.Security.Cryptography.RSAManaged System.Security.Cryptography.RSACryptoServiceProvider::rsa
	RSAManaged_t39EF82A0D6040ACF38E3C8A99982838521A33E65 * ___rsa_11;

public:
	inline static int32_t get_offset_of_store_6() { return static_cast<int32_t>(offsetof(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7, ___store_6)); }
	inline KeyPairPersistence_t7F7E8811D03A25C0251BF255AB94BAF57E965D9A * get_store_6() const { return ___store_6; }
	inline KeyPairPersistence_t7F7E8811D03A25C0251BF255AB94BAF57E965D9A ** get_address_of_store_6() { return &___store_6; }
	inline void set_store_6(KeyPairPersistence_t7F7E8811D03A25C0251BF255AB94BAF57E965D9A * value)
	{
		___store_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___store_6), (void*)value);
	}

	inline static int32_t get_offset_of_persistKey_7() { return static_cast<int32_t>(offsetof(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7, ___persistKey_7)); }
	inline bool get_persistKey_7() const { return ___persistKey_7; }
	inline bool* get_address_of_persistKey_7() { return &___persistKey_7; }
	inline void set_persistKey_7(bool value)
	{
		___persistKey_7 = value;
	}

	inline static int32_t get_offset_of_persisted_8() { return static_cast<int32_t>(offsetof(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7, ___persisted_8)); }
	inline bool get_persisted_8() const { return ___persisted_8; }
	inline bool* get_address_of_persisted_8() { return &___persisted_8; }
	inline void set_persisted_8(bool value)
	{
		___persisted_8 = value;
	}

	inline static int32_t get_offset_of_privateKeyExportable_9() { return static_cast<int32_t>(offsetof(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7, ___privateKeyExportable_9)); }
	inline bool get_privateKeyExportable_9() const { return ___privateKeyExportable_9; }
	inline bool* get_address_of_privateKeyExportable_9() { return &___privateKeyExportable_9; }
	inline void set_privateKeyExportable_9(bool value)
	{
		___privateKeyExportable_9 = value;
	}

	inline static int32_t get_offset_of_m_disposed_10() { return static_cast<int32_t>(offsetof(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7, ___m_disposed_10)); }
	inline bool get_m_disposed_10() const { return ___m_disposed_10; }
	inline bool* get_address_of_m_disposed_10() { return &___m_disposed_10; }
	inline void set_m_disposed_10(bool value)
	{
		___m_disposed_10 = value;
	}

	inline static int32_t get_offset_of_rsa_11() { return static_cast<int32_t>(offsetof(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7, ___rsa_11)); }
	inline RSAManaged_t39EF82A0D6040ACF38E3C8A99982838521A33E65 * get_rsa_11() const { return ___rsa_11; }
	inline RSAManaged_t39EF82A0D6040ACF38E3C8A99982838521A33E65 ** get_address_of_rsa_11() { return &___rsa_11; }
	inline void set_rsa_11(RSAManaged_t39EF82A0D6040ACF38E3C8A99982838521A33E65 * value)
	{
		___rsa_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___rsa_11), (void*)value);
	}
};

struct RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7_StaticFields
{
public:
	// System.Security.Cryptography.CspProviderFlags modreq(System.Runtime.CompilerServices.IsVolatile) System.Security.Cryptography.RSACryptoServiceProvider::s_UseMachineKeyStore
	int32_t ___s_UseMachineKeyStore_2;

public:
	inline static int32_t get_offset_of_s_UseMachineKeyStore_2() { return static_cast<int32_t>(offsetof(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7_StaticFields, ___s_UseMachineKeyStore_2)); }
	inline int32_t get_s_UseMachineKeyStore_2() const { return ___s_UseMachineKeyStore_2; }
	inline int32_t* get_address_of_s_UseMachineKeyStore_2() { return &___s_UseMachineKeyStore_2; }
	inline void set_s_UseMachineKeyStore_2(int32_t value)
	{
		___s_UseMachineKeyStore_2 = value;
	}
};


// System.SystemException
struct SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62  : public Exception_t
{
public:

public:
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


// UnityEngine.Purchasing.Security.InvalidPKCS7Data
struct InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81  : public IAPSecurityException_t0688C40275CE97C34325C2D6C5884694663D5EFA
{
public:

public:
};


// UnityEngine.Purchasing.Security.InvalidRSAData
struct InvalidRSAData_t7936FA4BD4B05A86337546B43ED2197E49D4EFF7  : public IAPSecurityException_t0688C40275CE97C34325C2D6C5884694663D5EFA
{
public:

public:
};


// UnityEngine.Purchasing.Security.InvalidTimeFormat
struct InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428  : public IAPSecurityException_t0688C40275CE97C34325C2D6C5884694663D5EFA
{
public:

public:
};


// UnityEngine.Purchasing.Security.InvalidX509Data
struct InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA  : public IAPSecurityException_t0688C40275CE97C34325C2D6C5884694663D5EFA
{
public:

public:
};


// UnityEngine.Purchasing.Security.UnsupportedSignerInfoVersion
struct UnsupportedSignerInfoVersion_t0D2E1B83A5FA8AAAF3BA828FFEEEE27A2AC57B1F  : public IAPSecurityException_t0688C40275CE97C34325C2D6C5884694663D5EFA
{
public:

public:
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
// UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[]
struct AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * m_Items[1];

public:
	inline AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * value)
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


// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Object>::ContainsKey(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_ContainsKey_m4F01DBE7409811CAB0BBA7AEFBAB4BC028D26FA6_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// !1 System.Collections.Generic.Dictionary`2<System.Object,System.Object>::get_Item(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Dictionary_2_get_Item_mB1398A10D048A0246178C59F95003BD338CE7394_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Purchasing.Security.AppleReceiptParser::ArrayEquals<System.Byte>(T[],T[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AppleReceiptParser_ArrayEquals_TisByte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_mF12D1427396A96BD80931D7572CBB9B2C8405230_gshared (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___a0, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___b1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::set_Item(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_mE6BF870B04922441F9F2760E782DEE6EE682615A_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, RuntimeObject * ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// !0[] System.Collections.Generic.List`1<System.Object>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* List_1_ToArray_mA737986DE6389E9DD8FA8E3D4E222DE4DA34958D_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared (Dictionary_2_tBD1E3221EBD04CEBDA49B84779912E91F56B958D * __this, const RuntimeMethod* method);
// !!0[] System.Array::Empty<System.Object>()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline (const RuntimeMethod* method);

// System.Char System.String::get_Chars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70 (String_t* __this, int32_t ___index0, const RuntimeMethod* method);
// System.Int32 System.String::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline (String_t* __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.Security.AppleReceipt UnityEngine.Purchasing.Security.AppleReceiptParser::Parse(System.Byte[],UnityEngine.Purchasing.Security.PKCS7&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * AppleReceiptParser_Parse_m6EB83189E2AB556AB8A99A44AC5AB3D9CA2773A5 (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___receiptData0, PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 ** ___receipt1, const RuntimeMethod* method);
// System.Globalization.CultureInfo UnityEngine.Purchasing.Security.AppleReceiptParser::PushInvariantCultureOnThread()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * AppleReceiptParser_PushInvariantCultureOnThread_m8D752C06EB42526BA86D1B6FA1FC558F2A7D63A2 (const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.String,System.Object>::ContainsKey(!0)
inline bool Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710 (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, String_t*, const RuntimeMethod*))Dictionary_2_ContainsKey_m4F01DBE7409811CAB0BBA7AEFBAB4BC028D26FA6_gshared)(__this, ___key0, method);
}
// !1 System.Collections.Generic.Dictionary`2<System.String,System.Object>::get_Item(!0)
inline RuntimeObject * Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, String_t* ___key0, const RuntimeMethod* method)
{
	return ((  RuntimeObject * (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, String_t*, const RuntimeMethod*))Dictionary_2_get_Item_mB1398A10D048A0246178C59F95003BD338CE7394_gshared)(__this, ___key0, method);
}
// System.Boolean UnityEngine.Purchasing.Security.AppleReceiptParser::ArrayEquals<System.Byte>(T[],T[])
inline bool AppleReceiptParser_ArrayEquals_TisByte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_mF12D1427396A96BD80931D7572CBB9B2C8405230 (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___a0, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___b1, const RuntimeMethod* method)
{
	return ((  bool (*) (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, const RuntimeMethod*))AppleReceiptParser_ArrayEquals_TisByte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_mF12D1427396A96BD80931D7572CBB9B2C8405230_gshared)(___a0, ___b1, method);
}
// System.Void System.IO.MemoryStream::.ctor(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2 (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___buffer0, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Parser::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Parser__ctor_mA73693A2C1369EA2767CCD813D6A9ACCC8599088 (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * __this, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Parser::LoadData(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Parser_LoadData_mC695E2673D7B8576065B7130E6BF0B92F4908B98 (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___stream0, const RuntimeMethod* method);
// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Parser::get_RootNode()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Parser_get_RootNode_m4359D48A87548584ACCF8540BA10BD7326091DAC_inline (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.PKCS7::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PKCS7__ctor_mC23976D15A67FB5C3C7CCDC937F9F6800E0CC3E5 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, const RuntimeMethod* method);
// LipingShare.LCLib.Asn1Processor.Asn1Node UnityEngine.Purchasing.Security.PKCS7::get_data()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * PKCS7_get_data_m6D8A2F87A739A82DD799A4221D0694378AE72766_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.Security.AppleReceipt UnityEngine.Purchasing.Security.AppleReceiptParser::ParseReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * AppleReceiptParser_ParseReceipt_m543C1FD33C7B481B0557EB1D5FA5868E2914C91F (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___data0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Object>::set_Item(!0,!1)
inline void Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9 (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, String_t* ___key0, RuntimeObject * ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, String_t*, RuntimeObject *, const RuntimeMethod*))Dictionary_2_set_Item_mE6BF870B04922441F9F2760E782DEE6EE682615A_gshared)(__this, ___key0, ___value1, method);
}
// System.Void UnityEngine.Purchasing.Security.AppleReceiptParser::PopCultureOffThread(System.Globalization.CultureInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleReceiptParser_PopCultureOffThread_mF43C20B91C47DEF1FD242DCF90CE97E7109C4BF2 (CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___originalCulture0, const RuntimeMethod* method);
// System.Threading.Thread System.Threading.Thread::get_CurrentThread()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * Thread_get_CurrentThread_m80236D2457FBCC1F76A08711E059A0B738DA71EC (const RuntimeMethod* method);
// System.Globalization.CultureInfo System.Threading.Thread::get_CurrentCulture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * Thread_get_CurrentCulture_m08B216EA7CE554F98EB601108206C01A54CAAC5F (Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * __this, const RuntimeMethod* method);
// System.Globalization.CultureInfo System.Globalization.CultureInfo::get_InvariantCulture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164 (const RuntimeMethod* method);
// System.Void System.Threading.Thread::set_CurrentCulture(System.Globalization.CultureInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Thread_set_CurrentCulture_mB3E49ED9AA150FD1CB3DE40BA436819A5E181127 (Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * __this, CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___value0, const RuntimeMethod* method);
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::get_ChildNodeCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.InvalidPKCS7Data::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1 (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * __this, const RuntimeMethod* method);
// LipingShare.LCLib.Asn1Processor.Asn1Node UnityEngine.Purchasing.Security.AppleReceiptParser::GetSetNode(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * AppleReceiptParser_GetSetNode_m0E58E5F2D41F7A54260248E404E52832EB7BC140 (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___data0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleReceipt::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleReceipt__ctor_m5432AB9CB2486AD3B215B6F49346E95070E0DD93 (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt>::.ctor()
inline void List_1__ctor_mD16F670EC2FA32D7869FD8D681CC05B713B06FB8 (List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Node::GetChildNode(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Byte[] LipingShare.LCLib.Asn1Processor.Asn1Node::get_Data()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Util::BytesToLong(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7 (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___bytes0, const RuntimeMethod* method);
// System.Text.Encoding System.Text.Encoding::get_UTF8()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E (const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleReceipt::set_bundleID(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_bundleID_m25A02C4A40C8E054E863C72E2D4AD23695FE3482_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleReceipt::set_appVersion(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_appVersion_m5D30750E5D757BB076E3B17EB3C2F18A3232A0DD_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleReceipt::set_opaque(System.Byte[])
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_opaque_mA8F53007E41556E07493855602A21573751D67ED_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleReceipt::set_hash(System.Byte[])
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_hash_m98652052746864E8676E6E374A419E371E9E13DF_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___value0, const RuntimeMethod* method);
// System.DateTime System.DateTime::Parse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  DateTime_Parse_m15F41E956747FC3E7EEBB24E45AA8733C1966989 (String_t* ___s0, const RuntimeMethod* method);
// System.DateTime System.DateTime::ToUniversalTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  DateTime_ToUniversalTime_mB5FB50E0AD0D9A2A917893A1655F51B174C7A6B3 (DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleReceipt::set_receiptCreationDate(System.DateTime)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_receiptCreationDate_m00A21F12F64E78048EFF1AC76A9A3E7A3A2742EE_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method);
// UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt UnityEngine.Purchasing.Security.AppleReceiptParser::ParseInAppReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * AppleReceiptParser_ParseInAppReceipt_mEB9CAB649C870275D5E5C2DD6710AED8E254C703 (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___inApp0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt>::Add(!0)
inline void List_1_Add_m240F342C63A57F3BEA7E78AFF14DF3D96C208FE6 (List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 * __this, AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 *, AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 *, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// System.Void UnityEngine.Purchasing.Security.AppleReceipt::set_originalApplicationVersion(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_originalApplicationVersion_mDEB66DD33895134615538BC540A7A7868FAE3C83_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, String_t* ___value0, const RuntimeMethod* method);
// !0[] System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt>::ToArray()
inline AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* List_1_ToArray_mEF201E3A675DB1879B7B5308261F352929154CD6 (List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 * __this, const RuntimeMethod* method)
{
	return ((  AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* (*) (List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 *, const RuntimeMethod*))List_1_ToArray_mA737986DE6389E9DD8FA8E3D4E222DE4DA34958D_gshared)(__this, method);
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::get_IsIndefiniteLength()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Asn1Node_get_IsIndefiniteLength_mD03D4CDC16E172CB7384EF056509817408C83FBB_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt__ctor_m2577093C483999A97CEC2BFC23495E0229DE8A4D (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_quantity(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_quantity_m7838C12ED8258D3ECCDA44599A8664D99350F9BB_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_productID(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_productID_m20774404517FD2203A1B5C87D1DF035836A58C99_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_transactionID(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_transactionID_mEF8CCA16FE937E8CD2058B032515369E98146333_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_originalTransactionIdentifier(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_originalTransactionIdentifier_mCB042EF9C653D71F4875FCDEE6DF1808F8E3C070_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.DateTime UnityEngine.Purchasing.Security.AppleReceiptParser::TryParseDateTimeNode(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  AppleReceiptParser_TryParseDateTimeNode_m74F92A23F91951E1B15DD7B6542711032C6AD8AA (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_purchaseDate(System.DateTime)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_purchaseDate_m38F96B704E6F95810EA9848C5B67587C42D0DFEA_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_originalPurchaseDate(System.DateTime)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_originalPurchaseDate_mCA445C1C9420F56D6EE01331D33A688D009BCF03_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_subscriptionExpirationDate(System.DateTime)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_subscriptionExpirationDate_mDA1D62DFD0BA2599664C19A4CE0A58404E73A80C_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_cancellationDate(System.DateTime)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_cancellationDate_mD0B29F011BB2B30D117E19E1E8FC3F8E7EFEE0E5_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_productType(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_productType_m1348D5CF0996703DF6B089CA2CBD9CDAC125ED17_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_isFreeTrial(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_isFreeTrial_mA51C247092E28915A28200F715EB1BEBB1CC88C0_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt::set_isIntroductoryPricePeriod(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_isIntroductoryPricePeriod_mA41926584FDAD3A1FA54A9BC0816D9741BB1D365_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C (String_t* ___value0, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.String,System.Object>::.ctor()
inline void Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63 (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *, const RuntimeMethod*))Dictionary_2__ctor_m2C8EE5C13636D67F6C451C4935049F534AEC658F_gshared)(__this, method);
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::Init()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_Init_m14DA7F09F96054644EFFE7DF908FBFEC08DB1297 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::get_Deepness()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int64_t Asn1Node_get_Deepness_m2ED875AFAB0B74DC5A8622DB3B3D18C4B7F6E95F_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Void System.Collections.ArrayList::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArrayList__ctor_m6847CFECD6BDC2AD10A4AC9852A572B88B8D6B1B (ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * __this, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetIndentStr(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___startNode0, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::ToHexString(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___bytes0, const RuntimeMethod* method);
// System.String System.String::Concat(System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9 (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___values0, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::FormatLineHexString(System.String,System.Int32,System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_FormatLineHexString_mD779CB787AB5999E9C8C43CD848691178F639339 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, String_t* ___lStr0, int32_t ___indent1, int32_t ___lineLen2, String_t* ___msg3, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::GenStr(System.Int32,System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_GenStr_mE8F5722F4437A061860433CFB0478AFFDB15B9B1 (int32_t ___len0, Il2CppChar ___xch1, const RuntimeMethod* method);
// System.String System.String::Substring(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B (String_t* __this, int32_t ___startIndex0, int32_t ___length1, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::set_RequireRecalculatePar(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Asn1Node_set_RequireRecalculatePar_m39322AC2FD6FC053F6E61C5665C0898C7E52C21F_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, bool ___value0, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::InternalLoadData(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_InternalLoadData_mD4F124147CA5C1269F2CFA65E20AD7104477E3B9 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::RecalculateTreePar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_RecalculateTreePar_m6437576AC8919D0347737FDE2EB8AA7B4FDDAA97 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Int32 LipingShare.LCLib.Asn1Processor.Asn1Util::DERLengthEncode(System.IO.Stream,System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Asn1Util_DERLengthEncode_mAB5A1E98AC3EF600B339FE181ADF620BBB2DF2FD (Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, uint64_t ___length1, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::SaveData(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_SaveData_m5130FD25C319C413AE8F113454C33DA32072191E (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ClearAll()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ClearAll_mD39130DFBE7AD1AF33618AEF2CE0CE2757D27046 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::GetTagName(System.Byte)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_GetTagName_m02927760E26BC5A39C7DBA088AE6427B24ADA73D (uint8_t ___tag0, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::get_TagName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.String System.String::Format(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B (String_t* ___format0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Oid::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Oid__ctor_m5F73190FA2302798601F2B61863F12363DF5E843 (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Oid::GetOidName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Oid_GetOidName_mF1BA27FF9C294059635716F0A23C27D63C69698B (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, String_t* ___inOidStr0, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.RelativeOid::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RelativeOid__ctor_m1DD6406191F78BC9BAAC9FD71BAF4AFC9372A6C8 (RelativeOid_t97392E06363F6AFF26543502032B89445860F72A * __this, const RuntimeMethod* method);
// System.Void System.Text.UTF8Encoding::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UTF8Encoding__ctor_mA3F21D41B65D155202345802A05761A4BC022888 (UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * __this, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::BytesToString(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_BytesToString_mA5E3457776D5F5FAF8C7D2850268B8FA9E8CE441 (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___bytes0, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::FormatLineString(System.String,System.Int32,System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_FormatLineString_mFD55298C08C9C61F3918378C6973279839645DCA (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, String_t* ___lStr0, int32_t ___indent1, int32_t ___lineLen2, String_t* ___msg3, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78 (String_t* ___str00, String_t* ___str11, String_t* ___str22, String_t* ___str33, const RuntimeMethod* method);
// System.String System.Int64::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int64_ToString_m8AAA883F340993DCDF339C208F3416C3BA82589F (int64_t* __this, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetHexPrintingStr(LipingShare.LCLib.Asn1Processor.Asn1Node,System.String,System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetHexPrintingStr_m0BD9EACAA7BDA5502C4D11C8512E7DF2A65B6F22 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___startNode0, String_t* ___baseLine1, String_t* ___lStr2, int32_t ___lineLen3, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetListStr(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetListStr_m982D22756C098CBED892C9C34A54E56A14614DA4 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___startNode0, int32_t ___lineLen1, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::FormatString(System.String,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_FormatString_m7588BDA18A9BC660061BAC73AB79DD458DF589F9 (String_t* ___inStr0, int32_t ___lineLen1, int32_t ___groupLen2, const RuntimeMethod* method);
// System.Void System.IO.MemoryStream::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MemoryStream__ctor_mD27B3DF2400D46A4A81EE78B0BD2C29EFCFAA44F (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * __this, const RuntimeMethod* method);
// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Node::get_ParentNode()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Node_get_ParentNode_mB1CB94F695AF71514E30EFEA66AD34AF626D2E44_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::ResetBranchDataLength(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_ResetBranchDataLength_m8E5348C849E7F7595944DB99E079F2421066D9EF (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ResetChildNodePar(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ResetChildNodePar_m85706CEC5D1ABE7DC9C317B03D5E6133DD77BA60 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___xNode0, int64_t ___subOffset1, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ResetDataLengthFieldWidth(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ResetDataLengthFieldWidth_m843C075C52989FEF803C622B1EF8317DCAD4BDE0 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, const RuntimeMethod* method);
// System.String System.Int32::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411 (int32_t* __this, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetText(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetText_m08AD0406E4330E7F0B546A1C8AA67D2B88F77B72 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___startNode0, int32_t ___lineLen1, const RuntimeMethod* method);
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Util::DerLengthDecode(System.IO.Stream,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Util_DerLengthDecode_m09878729C7733370A7423F2FD7CF97ECE86F58F9 (Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___bt0, bool* ___isIndefiniteLength1, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::AreTagsOk()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_AreTagsOk_m5CFAE2F617BD9F1F3B8536A73AEC04997F239236 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::GeneralDecodeIndefiniteLength(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_GeneralDecodeIndefiniteLength_mCA0402F12B5F298CF866EAD1FDCB4975631E0A0E (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___nodeMaxLen1, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::GeneralDecodeKnownLengthWithChecks(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_GeneralDecodeKnownLengthWithChecks_mEFE1C220D68654A2977591E537E0FDE3904401E5 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, int64_t ___nodeMaxLen2, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::IsGeneralStreamLengthOk(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_IsGeneralStreamLengthOk_mD8EDC30F136815F4F649056A87C054724EE7FF50 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, int64_t ___nodeMaxLen2, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::GeneralDecodeKnownLength(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_GeneralDecodeKnownLength_m694C84876BC67B6B9262F83CD57604CDB0E4A74C (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ReadStreamDataDefiniteLength(System.IO.Stream,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ReadStreamDataDefiniteLength_m7FE22AB1DEA1AF258E8ABB3FB36DEC5963A96269 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int32_t ___length1, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ReadStreamDataIndefiniteLength(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ReadStreamDataIndefiniteLength_m33C8696271566577856A568A8A3BDC706309D8C2 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___nodeMaxLen1, const RuntimeMethod* method);
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::MeasureContentLength(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_MeasureContentLength_mC6339E6F3567891FBF8B3DAC1E890F01C7CA44FE (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ReadMeasuredLengthDataFromStart(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ReadMeasuredLengthDataFromStart_m89EBB7361B009BF6D5CC8B901A3FE9468AF94ACD (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___startPosition1, int64_t ___length2, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeIndefiniteLength(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeIndefiniteLength_m20CC97EC0CA87B9FA41B03D1D4EF7C8A540E93AD (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeKnownLengthWithChecks(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeKnownLengthWithChecks_m7F188A7F5DF1A57A156E7DF92CF652DCFC60E45D (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::IsListStreamLengthOk(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_IsListStreamLengthOk_m11C6BBF656C6802EDF87ECFEFD498D58A1F74E9B (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___childNodeMaxLen1, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeKnownLength(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeKnownLength_mD6745A67CEF1E27237E54ECFC09A597616CED6B8 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, const RuntimeMethod* method);
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::CalculateListEncodeFieldBytesAndOffset(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_CalculateListEncodeFieldBytesAndOffset_m0D964212F4ABD27C10ABC8EEA4626F7E9CEABB55 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::HandleBitStringTag(System.IO.Stream,System.Int64&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_HandleBitStringTag_m3F1E2B0518549DCB5C253486E51E0D47329EC643 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t* ___offset1, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeKnownLengthInternal(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeKnownLengthInternal_mB98462D9D93AA55555AA2EEFC320655E540EADB8 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___offset1, const RuntimeMethod* method);
// System.IO.Stream LipingShare.LCLib.Asn1Processor.Asn1Node::CreateAndPrepareListDecodeMemoryStreamKnownLength(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * Asn1Node_CreateAndPrepareListDecodeMemoryStreamKnownLength_mB4D54A6EF150F7586A41C1A6988B86905F0830D6 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeChildNodesWithKnownLength(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeChildNodesWithKnownLength_m526CD7A41A53D2A54F129008D8688DE3F4E52005 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___secData0, int64_t ___offset1, const RuntimeMethod* method);
// System.Void System.IO.MemoryStream::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MemoryStream__ctor_mCB4274FF375AD786CCED424E80B047E0DEC50938 (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * __this, int32_t ___capacity0, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::CreateAndAddChildNode(System.IO.Stream,System.Int64&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_CreateAndAddChildNode_mFDBB610D8295704D2DC2FA8EE62146C1C3FD1421 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___secData0, int64_t* ___offset1, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node__ctor_m94082F24B4B34958EAC6DC936D16B324589758BC (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___parentNode0, int64_t ___dataOffset1, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::AddChild(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_AddChild_m2A68F11D8748772F35AA72997F724034790B2605 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___xdata0, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeIndefiniteLengthInternal(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeIndefiniteLengthInternal_m8E21404468B59298C16988FC14411A5576789E01 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___offset1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(System.IO.Stream,System.Int64&,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid_m7192750440F31F6C278BC0389A0C9FE069E62148 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t* ___offset1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method);
// LipingShare.LCLib.Asn1Processor.Asn1EndOfIndefiniteLengthNodeType LipingShare.LCLib.Asn1Processor.Asn1Node::DetectEndOfIndefiniteListContents(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Asn1Node_DetectEndOfIndefiniteListContents_mCA07A1B65297E1AF71D6E84A5003B0EC16ADD676 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ReadNextChildNodeOfIndefiniteListClearIfInvalid(System.IO.Stream,System.Int64&,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ReadNextChildNodeOfIndefiniteListClearIfInvalid_m1FEF12D06C608BFAC0C093E2383679B6FB205110 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t* ___offset1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method);
// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Node::GetLastChild()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Node_GetLastChild_m0F7F8629136DB0882A19E41C4F74BBF16F36E317 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::get_DataLength()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int64_t Asn1Node_get_DataLength_mCF41384470AB94796BC81FCA252C18AB3513BBD8_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecode(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecode_mBFC1B062A5F787770D9CD86742038160283956BD (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::GeneralDecode(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_GeneralDecode_m0CF76CE74470A9631179746CBE8AEEA09C7BE56B (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node__ctor_mB242F7479DDBE60A03AF22BC268BD4DA1EA62E5B (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::LoadData(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_LoadData_m19814DE77D7FE6BD5E95380BF1AB1357F15C750F (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method);
// System.Void System.ArgumentException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentException__ctor_m2D35EAD113C2ADC99EB17B940A2097A93FD23EFC (ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00 * __this, String_t* ___message0, const RuntimeMethod* method);
// !!0[] System.Array::Empty<System.Object>()
inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_inline (const RuntimeMethod* method)
{
	return ((  ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* (*) (const RuntimeMethod*))Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline)(method);
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Parser::GetNodeText(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Parser_GetNodeText_m4E589B8AF54C8760C8CCE19F81D8778EBA02462D (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, int32_t ___lineLen1, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Parser::GetNodeTextHeader(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Parser_GetNodeTextHeader_m48CEC04B4FBF2BBE897D1FFA800A8F09F5F03071 (int32_t ___lineLen0, const RuntimeMethod* method);
// System.String System.String::CreateString(System.Char[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_CreateString_mC7F57CE6ED768CF86591160424FE55D5CBA7C344 (String_t* __this, CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___val0, const RuntimeMethod* method);
// System.String System.String::TrimEnd(System.Char[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_TrimEnd_mA98B5B9C45CCAB016F32F1C8BBE29A215B9D277E (String_t* __this, CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___trimChars0, const RuntimeMethod* method);
// System.Int32 LipingShare.LCLib.Asn1Processor.Asn1Util::BytePrecision(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Asn1Util_BytePrecision_m2FB699DF3BB16FA38562D4FC072CD769835A89EB (uint64_t ___value0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeHelpers::InitializeArray(System.Array,System.RuntimeFieldHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeHelpers_InitializeArray_mE27238308FED781F2D6A719F0903F2E1311B058F (RuntimeArray * ___array0, RuntimeFieldHandle_t7BE65FC857501059EBAC9772C93B02CD413D9C96  ___fldHandle1, const RuntimeMethod* method);
// System.Byte LipingShare.LCLib.Asn1Processor.Asn1Node::get_MaskedTag()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint8_t Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.InvalidX509Data::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * __this, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Oid::Decode(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Oid_Decode_m645A8CFA1369387AA5638099EDE5EFBD2B0A7DC1 (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___data0, const RuntimeMethod* method);
// System.UInt32 <PrivateImplementationDetails>::ComputeStringHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t U3CPrivateImplementationDetailsU3E_ComputeStringHash_mF5324EA33B0E55B4570D0EF8DA5A0FCB25E6ECA4 (String_t* ___s0, const RuntimeMethod* method);
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_Country(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_Country_m5FEE9E1CA4B8090244EFC4C035C4B602B5812FF0_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_Organization(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_Organization_mE46F109C4F90063C1424156D4A82676305D1FC68_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_OrganizationalUnit(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_OrganizationalUnit_mF45FFA1898130492704A1D74B8A2D3381553A874_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_CommonName(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_CommonName_m699DA7948C7C23CB270E88A56453A54B826A7197_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_SerialNumber(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_SerialNumber_m4BC141696476B8DCD83E21BC78F3CA5A57316B74_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_Dnq(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_Dnq_m5804E8D6845E922F9E4ABA254387CCA4BB2EF63D_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_State(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_State_mD31D1EC2DB9AF12BB9C27511CDA0E1B2381BC0E6_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_Organization()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Organization_m7099D111E9B3D9F4EBA74CFE022080B6AF2E4571_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_OrganizationalUnit()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_OrganizationalUnit_mA770C2BF2D42EFBC103C06EE7D2196C6977CA499_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_Dnq()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Dnq_mF2BDB440F23D8D256304AD7385170B20823E7E40_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_Country()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Country_m7428D857116758C8131C1A89D0ECBD9300257478_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_State()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_State_mB6E45565C187F37F8AA400B6126A3DDB7F8964F4_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_CommonName()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_CommonName_mF8E6F3B5D8AC9A1DBCBD08F7F9BF5445B61676A1_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.IAPSecurityException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IAPSecurityException__ctor_mFFF023188A2BB47A715BCEAF3B94F31370D77680 (IAPSecurityException_t0688C40275CE97C34325C2D6C5884694663D5EFA * __this, const RuntimeMethod* method);
// System.Void System.Collections.Specialized.StringDictionary::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringDictionary__ctor_mEA16941AB5C9CDBEE3B0572E3FA74DD1CC0C8637 (StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 * __this, const RuntimeMethod* method);
// System.String System.Convert::ToString(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Convert_ToString_m591519A05955A00954A48E0EA3F5CB9921C13969 (int32_t ___value0, const RuntimeMethod* method);
// System.Int32 LipingShare.LCLib.Asn1Processor.Oid::DecodeValue(System.IO.Stream,System.UInt64&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Oid_DecodeValue_m319B938E419AD61DA32F9D0E7191FF2815B55DD8 (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___bt0, uint64_t* ___v1, const RuntimeMethod* method);
// System.String System.UInt64::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UInt64_ToString_m3644686F0A0E32CB94D300CF891DBD7920396F37 (uint64_t* __this, const RuntimeMethod* method);
// System.Void System.Exception::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11 (Exception_t * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.PKCS7::CheckStructure()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method);
// System.Byte LipingShare.LCLib.Asn1Processor.Asn1Node::get_Tag()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR uint8_t Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method);
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetDataStr(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetDataStr_mF4A8F71F0C9F5ECB82E4981090F142D59965CAD1 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, bool ___pureHexMode0, const RuntimeMethod* method);
// System.Boolean System.String::op_Inequality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Inequality_mDDA2DDED3E7EF042987EB7180EE3E88105F0AAE2 (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.PKCS7::set_data(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PKCS7_set_data_m1BCC45AFBD0BC0E7F7A108C65F1FC8DC42A57489_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___value0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert>::.ctor()
inline void List_1__ctor_m9174FECFF4F8AF56773DA8275A1610F7D7BF0745 (List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// System.Void UnityEngine.Purchasing.Security.PKCS7::set_certChain(System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PKCS7_set_certChain_m3393852EBF6A9ACF57D248CD5CD96E7170DA9257_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * ___value0, const RuntimeMethod* method);
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert> UnityEngine.Purchasing.Security.PKCS7::get_certChain()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * PKCS7_get_certChain_m00B476DB0047B4C9991F5B435BFACD1124394373_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert__ctor_mA9A0A93FB464AA5AE8E65B5E6DDFCBBAD398AF9B (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert>::Add(!0)
inline void List_1_Add_m9B4412E2C7AAF1AF1107C9AD3E077358556B98C0 (List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * __this, X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 *, X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C *, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo>::.ctor()
inline void List_1__ctor_m5667C5FFA6B3D3FE9E406930664837BF29CB06F1 (List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// System.Void UnityEngine.Purchasing.Security.PKCS7::set_sinfos(System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo>)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PKCS7_set_sinfos_mE2B572994330BFEF8B073BCD8D6C1EC384DC2BC7_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * ___value0, const RuntimeMethod* method);
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo> UnityEngine.Purchasing.Security.PKCS7::get_sinfos()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * PKCS7_get_sinfos_mC974631B995F6B9AC43EFD1E5B02F8EE112F278F_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.SignerInfo::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9 (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo>::Add(!0)
inline void List_1_Add_m80068FC05C359A987CEF7128920AA1437950D76E (List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * __this, SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 *, SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB *, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// System.Security.Cryptography.RSACryptoServiceProvider UnityEngine.Purchasing.Security.RSAKey::ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * RSAKey_ParseNode_mC39A2AC4AC93CD5E30783858DE40667A8CE74D77 (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.RSAKey::set_rsa(System.Security.Cryptography.RSACryptoServiceProvider)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RSAKey_set_rsa_m5B74E411FA4685E4484F1EEF973E02F1F008A4F5_inline (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * ___value0, const RuntimeMethod* method);
// System.Void System.Array::Copy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877 (RuntimeArray * ___sourceArray0, int32_t ___sourceIndex1, RuntimeArray * ___destinationArray2, int32_t ___destinationIndex3, int32_t ___length4, const RuntimeMethod* method);
// System.String System.Convert::ToBase64String(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Convert_ToBase64String_mE6E1FE504EF1E99DB2F8B92180A82A5F1512EF6A (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___inArray0, const RuntimeMethod* method);
// System.Void System.Security.Cryptography.RSACryptoServiceProvider::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RSACryptoServiceProvider__ctor_m540359C328E1E9E9818A1192E34C74C986186B80 (RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * __this, const RuntimeMethod* method);
// System.String UnityEngine.Purchasing.Security.RSAKey::ToXML(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RSAKey_ToXML_m189C5328EE031465F2BFF117F6AE5E4BBB39C022 (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, String_t* ___modulus0, String_t* ___exponent1, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.InvalidRSAData::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidRSAData__ctor_m7FD4D1595A630A2C0D68DF36C9E9E383262C056C (InvalidRSAData_t7936FA4BD4B05A86337546B43ED2197E49D4EFF7 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.SignerInfo::set_Version(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SignerInfo_set_Version_m096A7A01379DBFE817CB261272AE462789B619CF_inline (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Purchasing.Security.SignerInfo::get_Version()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t SignerInfo_get_Version_m7967FD171D0CD045416CF0CD8EE86F880B5AFDA1_inline (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.UnsupportedSignerInfoVersion::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnsupportedSignerInfoVersion__ctor_m2A525C80CA9AB2BE9F9869A020D54A0A11AA1542 (UnsupportedSignerInfoVersion_t0D2E1B83A5FA8AAAF3BA828FFEEEE27A2AC57B1F * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.SignerInfo::set_IssuerSerialNumber(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SignerInfo_set_IssuerSerialNumber_mCF2536D75E277F4AF7311E105A586BC8087BC8E2_inline (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.SignerInfo::set_EncryptedDigest(System.Byte[])
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SignerInfo_set_EncryptedDigest_mBF05E641B22261C4D7A5DAE5F5FCD59BBDA1505B_inline (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___root0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_SerialNumber(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_SerialNumber_mFA0667C943FA625300BE9D274F35630B7C918604_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName__ctor_m88B417EEFA420272B08355F1369DBDAA71532886 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_Issuer(UnityEngine.Purchasing.Security.DistinguishedName)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_Issuer_m9FC621236D22A3F23C3F94338EF6544D34B5D94B_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_Subject(UnityEngine.Purchasing.Security.DistinguishedName)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_Subject_m5649A924BEB6DD0E9039AEB2232D4ECF0AD70FE4_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___value0, const RuntimeMethod* method);
// System.DateTime UnityEngine.Purchasing.Security.X509Cert::ParseTime(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  X509Cert_ParseTime_m315E259C5A6097A60455BBBF417F8770C849DAC9 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_ValidAfter(System.DateTime)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_ValidAfter_m206F8F9D9BE5AAF09187DD65143E73C7DA19A46F_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_ValidBefore(System.DateTime)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_ValidBefore_m9C8AE3C70CA68DCFE66E72C82AFC2861979CB6B7_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method);
// UnityEngine.Purchasing.Security.DistinguishedName UnityEngine.Purchasing.Security.X509Cert::get_Subject()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * X509Cert_get_Subject_m12D21A6B054646292F89E16073D231ADD945FF61_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, const RuntimeMethod* method);
// UnityEngine.Purchasing.Security.DistinguishedName UnityEngine.Purchasing.Security.X509Cert::get_Issuer()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * X509Cert_get_Issuer_m046958208FB8B4569B0F9A4D2B8EBC7DE6B6987B_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Purchasing.Security.DistinguishedName::Equals(UnityEngine.Purchasing.Security.DistinguishedName)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool DistinguishedName_Equals_mFFA3F3D4A6FADBEB7B9FF6BDC988D48D346A13D4 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___n20, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_SelfSigned(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_SelfSigned_m73D24826515F4DA3F86453E6E70B92C1C8500A90_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, bool ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.RSAKey::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RSAKey__ctor_m122BCC496985281C78CCD0A223792580C27D4F6F (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_PubKey(UnityEngine.Purchasing.Security.RSAKey)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_PubKey_mE5DCFEA38790817EF1860B54E27D06465C915D5F_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_Signature(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_Signature_m4E664BC494904845D1CBC1B766CA37FA0C089A2E_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Purchasing.Security.InvalidTimeFormat::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidTimeFormat__ctor_m2EA54FD5CEBC3F2494069A8E58329417DBFD4FFA (InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428 * __this, const RuntimeMethod* method);
// System.Int32 System.Int32::Parse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Int32_Parse_mE5D220FEA7F0BFB1B220B2A30797D7DD83ACF22C (String_t* ___s0, const RuntimeMethod* method);
// System.Void System.DateTime::.ctor(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.DateTimeKind)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DateTime__ctor_mE84FCDCEAD332A62B587191C5874DAD7C238CFEA (DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * __this, int32_t ___year0, int32_t ___month1, int32_t ___day2, int32_t ___hour3, int32_t ___minute4, int32_t ___second5, int32_t ___kind6, const RuntimeMethod* method);
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
// System.UInt32 <PrivateImplementationDetails>::ComputeStringHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t U3CPrivateImplementationDetailsU3E_ComputeStringHash_mF5324EA33B0E55B4570D0EF8DA5A0FCB25E6ECA4 (String_t* ___s0, const RuntimeMethod* method)
{
	uint32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		String_t* L_0 = ___s0;
		if (!L_0)
		{
			goto IL_002a;
		}
	}
	{
		V_0 = ((int32_t)-2128831035);
		V_1 = 0;
		goto IL_0021;
	}

IL_000d:
	{
		String_t* L_1 = ___s0;
		int32_t L_2 = V_1;
		NullCheck(L_1);
		Il2CppChar L_3;
		L_3 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_1, L_2, /*hidden argument*/NULL);
		uint32_t L_4 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_multiply((int32_t)((int32_t)((int32_t)L_3^(int32_t)L_4)), (int32_t)((int32_t)16777619)));
		int32_t L_5 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_5, (int32_t)1));
	}

IL_0021:
	{
		int32_t L_6 = V_1;
		String_t* L_7 = ___s0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_7, /*hidden argument*/NULL);
		if ((((int32_t)L_6) < ((int32_t)L_8)))
		{
			goto IL_000d;
		}
	}

IL_002a:
	{
		uint32_t L_9 = V_0;
		return L_9;
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
// UnityEngine.Purchasing.Security.AppleReceipt UnityEngine.Purchasing.Security.AppleReceiptParser::Parse(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * AppleReceiptParser_Parse_mC538513E3A2270F3A19D1367AEFA407D1F958BF1 (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___receiptData0, const RuntimeMethod* method)
{
	PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * V_0 = NULL;
	{
		// return Parse(receiptData, out _);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = ___receiptData0;
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_1;
		L_1 = AppleReceiptParser_Parse_m6EB83189E2AB556AB8A99A44AC5AB3D9CA2773A5(__this, L_0, (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 **)(&V_0), /*hidden argument*/NULL);
		return L_1;
	}
}
// UnityEngine.Purchasing.Security.AppleReceipt UnityEngine.Purchasing.Security.AppleReceiptParser::Parse(System.Byte[],UnityEngine.Purchasing.Security.PKCS7&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * AppleReceiptParser_Parse_m6EB83189E2AB556AB8A99A44AC5AB3D9CA2773A5 (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___receiptData0, PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 ** ___receipt1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AppleReceiptParser_ArrayEquals_TisByte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_mF12D1427396A96BD80931D7572CBB9B2C8405230_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral08D691F3DDE80A0F3B3AFC79770EEC67F64A0234);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0B6E49D70DC463E44307A8A539250C8090D10786);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6BB0A873A6D6124ACF9D6FEAEB6204BC0FFE7381);
		s_Il2CppMethodInitialized = true;
	}
	CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * V_0 = NULL;
	AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * V_1 = NULL;
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * V_2 = NULL;
	Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * V_3 = NULL;
	AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * V_4 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
		// CultureInfo originalCulture = PushInvariantCultureOnThread();
		IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_0;
		L_0 = AppleReceiptParser_PushInvariantCultureOnThread_m8D752C06EB42526BA86D1B6FA1FC558F2A7D63A2(/*hidden argument*/NULL);
		V_0 = L_0;
	}

IL_0006:
	try
	{ // begin try (depth: 1)
		{
			// if (_mostRecentReceiptData.ContainsKey(k_AppleReceiptKey) &&
			//     _mostRecentReceiptData.ContainsKey(k_PKCS7Key) &&
			//     _mostRecentReceiptData.ContainsKey(k_ReceiptBytesKey) &&
			//     ArrayEquals<byte>(receiptData, (byte[])_mostRecentReceiptData[k_ReceiptBytesKey]))
			IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_1 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			NullCheck(L_1);
			bool L_2;
			L_2 = Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710(L_1, _stringLiteral08D691F3DDE80A0F3B3AFC79770EEC67F64A0234, /*hidden argument*/Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710_RuntimeMethod_var);
			if (!L_2)
			{
				goto IL_0082;
			}
		}

IL_0017:
		{
			IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_3 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			NullCheck(L_3);
			bool L_4;
			L_4 = Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710(L_3, _stringLiteral6BB0A873A6D6124ACF9D6FEAEB6204BC0FFE7381, /*hidden argument*/Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710_RuntimeMethod_var);
			if (!L_4)
			{
				goto IL_0082;
			}
		}

IL_0028:
		{
			IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_5 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			NullCheck(L_5);
			bool L_6;
			L_6 = Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710(L_5, _stringLiteral0B6E49D70DC463E44307A8A539250C8090D10786, /*hidden argument*/Dictionary_2_ContainsKey_m660B1C18318BE8EEC0B242140281274407F20710_RuntimeMethod_var);
			if (!L_6)
			{
				goto IL_0082;
			}
		}

IL_0039:
		{
			ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_7 = ___receiptData0;
			IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_8 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			NullCheck(L_8);
			RuntimeObject * L_9;
			L_9 = Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D(L_8, _stringLiteral0B6E49D70DC463E44307A8A539250C8090D10786, /*hidden argument*/Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D_RuntimeMethod_var);
			bool L_10;
			L_10 = AppleReceiptParser_ArrayEquals_TisByte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_mF12D1427396A96BD80931D7572CBB9B2C8405230(L_7, ((ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)Castclass((RuntimeObject*)L_9, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var)), /*hidden argument*/AppleReceiptParser_ArrayEquals_TisByte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_mF12D1427396A96BD80931D7572CBB9B2C8405230_RuntimeMethod_var);
			if (!L_10)
			{
				goto IL_0082;
			}
		}

IL_0055:
		{
			// receipt = (PKCS7)_mostRecentReceiptData[k_PKCS7Key];
			PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 ** L_11 = ___receipt1;
			IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_12 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			NullCheck(L_12);
			RuntimeObject * L_13;
			L_13 = Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D(L_12, _stringLiteral6BB0A873A6D6124ACF9D6FEAEB6204BC0FFE7381, /*hidden argument*/Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D_RuntimeMethod_var);
			*((RuntimeObject **)L_11) = (RuntimeObject *)((PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 *)CastclassClass((RuntimeObject*)L_13, PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71_il2cpp_TypeInfo_var));
			Il2CppCodeGenWriteBarrier((void**)(RuntimeObject **)L_11, (void*)(RuntimeObject *)((PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 *)CastclassClass((RuntimeObject*)L_13, PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71_il2cpp_TypeInfo_var)));
			// return (AppleReceipt)_mostRecentReceiptData[k_AppleReceiptKey];
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_14 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			NullCheck(L_14);
			RuntimeObject * L_15;
			L_15 = Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D(L_14, _stringLiteral08D691F3DDE80A0F3B3AFC79770EEC67F64A0234, /*hidden argument*/Dictionary_2_get_Item_m88AA4580D695AEA212B0DF17D8B55C98CF3B624D_RuntimeMethod_var);
			V_1 = ((AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 *)CastclassClass((RuntimeObject*)L_15, AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62_il2cpp_TypeInfo_var));
			IL2CPP_LEAVE(0xFA, FINALLY_00f3);
		}

IL_0082:
		{
			// using (var stm = new System.IO.MemoryStream(receiptData))
			ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_16 = ___receiptData0;
			MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_17 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
			MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2(L_17, L_16, /*hidden argument*/NULL);
			V_2 = L_17;
		}

IL_0089:
		try
		{ // begin try (depth: 2)
			// Asn1Parser parser = new Asn1Parser();
			Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * L_18 = (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD *)il2cpp_codegen_object_new(Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD_il2cpp_TypeInfo_var);
			Asn1Parser__ctor_mA73693A2C1369EA2767CCD813D6A9ACCC8599088(L_18, /*hidden argument*/NULL);
			V_3 = L_18;
			// parser.LoadData(stm);
			Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * L_19 = V_3;
			MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_20 = V_2;
			NullCheck(L_19);
			Asn1Parser_LoadData_mC695E2673D7B8576065B7130E6BF0B92F4908B98(L_19, L_20, /*hidden argument*/NULL);
			// receipt = new PKCS7(parser.RootNode);
			PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 ** L_21 = ___receipt1;
			Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * L_22 = V_3;
			NullCheck(L_22);
			Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_23;
			L_23 = Asn1Parser_get_RootNode_m4359D48A87548584ACCF8540BA10BD7326091DAC_inline(L_22, /*hidden argument*/NULL);
			PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * L_24 = (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 *)il2cpp_codegen_object_new(PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71_il2cpp_TypeInfo_var);
			PKCS7__ctor_mC23976D15A67FB5C3C7CCDC937F9F6800E0CC3E5(L_24, L_23, /*hidden argument*/NULL);
			*((RuntimeObject **)L_21) = (RuntimeObject *)L_24;
			Il2CppCodeGenWriteBarrier((void**)(RuntimeObject **)L_21, (void*)(RuntimeObject *)L_24);
			// var result = ParseReceipt(receipt.data);
			PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 ** L_25 = ___receipt1;
			PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * L_26 = *((PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 **)L_25);
			NullCheck(L_26);
			Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_27;
			L_27 = PKCS7_get_data_m6D8A2F87A739A82DD799A4221D0694378AE72766_inline(L_26, /*hidden argument*/NULL);
			AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_28;
			L_28 = AppleReceiptParser_ParseReceipt_m543C1FD33C7B481B0557EB1D5FA5868E2914C91F(__this, L_27, /*hidden argument*/NULL);
			V_4 = L_28;
			// _mostRecentReceiptData[k_AppleReceiptKey] = result;
			IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_29 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_30 = V_4;
			NullCheck(L_29);
			Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9(L_29, _stringLiteral08D691F3DDE80A0F3B3AFC79770EEC67F64A0234, L_30, /*hidden argument*/Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9_RuntimeMethod_var);
			// _mostRecentReceiptData[k_PKCS7Key] = receipt;
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_31 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 ** L_32 = ___receipt1;
			PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * L_33 = *((PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 **)L_32);
			NullCheck(L_31);
			Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9(L_31, _stringLiteral6BB0A873A6D6124ACF9D6FEAEB6204BC0FFE7381, L_33, /*hidden argument*/Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9_RuntimeMethod_var);
			// _mostRecentReceiptData[k_ReceiptBytesKey] = receiptData;
			Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_34 = ((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->get__mostRecentReceiptData_0();
			ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_35 = ___receiptData0;
			NullCheck(L_34);
			Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9(L_34, _stringLiteral0B6E49D70DC463E44307A8A539250C8090D10786, (RuntimeObject *)(RuntimeObject *)L_35, /*hidden argument*/Dictionary_2_set_Item_mD86FD5EED3CEB42690DDFEB80B2494A5A48A3EB9_RuntimeMethod_var);
			// return result;
			AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_36 = V_4;
			V_1 = L_36;
			IL2CPP_LEAVE(0xFA, FINALLY_00e9);
		} // end try (depth: 2)
		catch(Il2CppExceptionWrapper& e)
		{
			__last_unhandled_exception = (Exception_t *)e.ex;
			goto FINALLY_00e9;
		}

FINALLY_00e9:
		{ // begin finally (depth: 2)
			{
				MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_37 = V_2;
				if (!L_37)
				{
					goto IL_00f2;
				}
			}

IL_00ec:
			{
				MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_38 = V_2;
				NullCheck(L_38);
				InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t099785737FC6A1E3699919A94109383715A8D807_il2cpp_TypeInfo_var, L_38);
			}

IL_00f2:
			{
				IL2CPP_END_FINALLY(233)
			}
		} // end finally (depth: 2)
		IL2CPP_CLEANUP(233)
		{
			IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
			IL2CPP_END_CLEANUP(0xFA, FINALLY_00f3);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_00f3;
	}

FINALLY_00f3:
	{ // begin finally (depth: 1)
		// PopCultureOffThread(originalCulture);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_39 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		AppleReceiptParser_PopCultureOffThread_mF43C20B91C47DEF1FD242DCF90CE97E7109C4BF2(L_39, /*hidden argument*/NULL);
		// }
		IL2CPP_END_FINALLY(243)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(243)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0xFA, IL_00fa)
	}

IL_00fa:
	{
		// }
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_40 = V_1;
		return L_40;
	}
}
// System.Globalization.CultureInfo UnityEngine.Purchasing.Security.AppleReceiptParser::PushInvariantCultureOnThread()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * AppleReceiptParser_PushInvariantCultureOnThread_m8D752C06EB42526BA86D1B6FA1FC558F2A7D63A2 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// var originalCulture = Thread.CurrentThread.CurrentCulture;
		Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * L_0;
		L_0 = Thread_get_CurrentThread_m80236D2457FBCC1F76A08711E059A0B738DA71EC(/*hidden argument*/NULL);
		NullCheck(L_0);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_1;
		L_1 = Thread_get_CurrentCulture_m08B216EA7CE554F98EB601108206C01A54CAAC5F(L_0, /*hidden argument*/NULL);
		// Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
		Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * L_2;
		L_2 = Thread_get_CurrentThread_m80236D2457FBCC1F76A08711E059A0B738DA71EC(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98_il2cpp_TypeInfo_var);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_3;
		L_3 = CultureInfo_get_InvariantCulture_m9FAAFAF8A00091EE1FCB7098AD3F163ECDF02164(/*hidden argument*/NULL);
		NullCheck(L_2);
		Thread_set_CurrentCulture_mB3E49ED9AA150FD1CB3DE40BA436819A5E181127(L_2, L_3, /*hidden argument*/NULL);
		// return originalCulture;
		return L_1;
	}
}
// System.Void UnityEngine.Purchasing.Security.AppleReceiptParser::PopCultureOffThread(System.Globalization.CultureInfo)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleReceiptParser_PopCultureOffThread_mF43C20B91C47DEF1FD242DCF90CE97E7109C4BF2 (CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * ___originalCulture0, const RuntimeMethod* method)
{
	{
		// Thread.CurrentThread.CurrentCulture = originalCulture;
		Thread_tB9EB71664220EE16451AF3276D78DE6614D2A414 * L_0;
		L_0 = Thread_get_CurrentThread_m80236D2457FBCC1F76A08711E059A0B738DA71EC(/*hidden argument*/NULL);
		CultureInfo_t1B787142231DB79ABDCE0659823F908A040E9A98 * L_1 = ___originalCulture0;
		NullCheck(L_0);
		Thread_set_CurrentCulture_mB3E49ED9AA150FD1CB3DE40BA436819A5E181127(L_0, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// UnityEngine.Purchasing.Security.AppleReceipt UnityEngine.Purchasing.Security.AppleReceiptParser::ParseReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * AppleReceiptParser_ParseReceipt_m543C1FD33C7B481B0557EB1D5FA5868E2914C91F (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___data0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m240F342C63A57F3BEA7E78AFF14DF3D96C208FE6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_mEF201E3A675DB1879B7B5308261F352929154CD6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mD16F670EC2FA32D7869FD8D681CC05B713B06FB8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_0 = NULL;
	AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * V_1 = NULL;
	List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 * V_2 = NULL;
	int32_t V_3 = 0;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_4 = NULL;
	int64_t V_5 = 0;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_6 = NULL;
	String_t* V_7 = NULL;
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  V_8;
	memset((&V_8), 0, sizeof(V_8));
	int64_t G_B8_0 = 0;
	int64_t G_B7_0 = 0;
	{
		// if (data == null || data.ChildNodeCount != 1)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___data0;
		if (!L_0)
		{
			goto IL_000d;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1 = ___data0;
		NullCheck(L_1);
		int64_t L_2;
		L_2 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_1, /*hidden argument*/NULL);
		if ((((int64_t)L_2) == ((int64_t)((int64_t)((int64_t)1)))))
		{
			goto IL_0013;
		}
	}

IL_000d:
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_3 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_3, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AppleReceiptParser_ParseReceipt_m543C1FD33C7B481B0557EB1D5FA5868E2914C91F_RuntimeMethod_var)));
	}

IL_0013:
	{
		// Asn1Node set = GetSetNode(data);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4 = ___data0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5;
		L_5 = AppleReceiptParser_GetSetNode_m0E58E5F2D41F7A54260248E404E52832EB7BC140(__this, L_4, /*hidden argument*/NULL);
		V_0 = L_5;
		// var result = new AppleReceipt();
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_6 = (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 *)il2cpp_codegen_object_new(AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62_il2cpp_TypeInfo_var);
		AppleReceipt__ctor_m5432AB9CB2486AD3B215B6F49346E95070E0DD93(L_6, /*hidden argument*/NULL);
		V_1 = L_6;
		// var inApps = new List<AppleInAppPurchaseReceipt>();
		List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 * L_7 = (List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 *)il2cpp_codegen_object_new(List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07_il2cpp_TypeInfo_var);
		List_1__ctor_mD16F670EC2FA32D7869FD8D681CC05B713B06FB8(L_7, /*hidden argument*/List_1__ctor_mD16F670EC2FA32D7869FD8D681CC05B713B06FB8_RuntimeMethod_var);
		V_2 = L_7;
		// for (int t = 0; t < set.ChildNodeCount; t++)
		V_3 = 0;
		goto IL_017f;
	}

IL_002e:
	{
		// var node = set.GetChildNode(t);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8 = V_0;
		int32_t L_9 = V_3;
		NullCheck(L_8);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_10;
		L_10 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_8, L_9, /*hidden argument*/NULL);
		V_4 = L_10;
		// if (node.ChildNodeCount == 3)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_11 = V_4;
		NullCheck(L_11);
		int64_t L_12;
		L_12 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_11, /*hidden argument*/NULL);
		if ((!(((uint64_t)L_12) == ((uint64_t)((int64_t)((int64_t)3))))))
		{
			goto IL_017b;
		}
	}
	{
		// var type = Asn1Util.BytesToLong(node.GetChildNode(0).Data);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_13 = V_4;
		NullCheck(L_13);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_14;
		L_14 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_13, 0, /*hidden argument*/NULL);
		NullCheck(L_14);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_15;
		L_15 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_14, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int64_t L_16;
		L_16 = Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7(L_15, /*hidden argument*/NULL);
		V_5 = L_16;
		// var value = node.GetChildNode(2);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_17 = V_4;
		NullCheck(L_17);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_18;
		L_18 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_17, 2, /*hidden argument*/NULL);
		V_6 = L_18;
		int64_t L_19 = V_5;
		if ((((int64_t)L_19) > ((int64_t)((int64_t)((int64_t)((int32_t)12))))))
		{
			goto IL_009c;
		}
	}
	{
		int64_t L_20 = V_5;
		int64_t L_21 = ((int64_t)il2cpp_codegen_subtract((int64_t)L_20, (int64_t)((int64_t)((int64_t)2))));
		G_B7_0 = L_21;
		if ((!(((uint64_t)L_21) > ((uint64_t)((int64_t)((int64_t)3))))))
		{
			G_B8_0 = L_21;
			goto IL_0077;
		}
	}
	{
		goto IL_008d;
	}

IL_0077:
	{
		switch (((int32_t)((uint32_t)G_B8_0)))
		{
			case 0:
			{
				goto IL_00b5;
			}
			case 1:
			{
				goto IL_00d7;
			}
			case 2:
			{
				goto IL_00f9;
			}
			case 3:
			{
				goto IL_0108;
			}
		}
	}

IL_008d:
	{
		int64_t L_22 = V_5;
		if ((((int64_t)L_22) == ((int64_t)((int64_t)((int64_t)((int32_t)12))))))
		{
			goto IL_0117;
		}
	}
	{
		goto IL_017b;
	}

IL_009c:
	{
		int64_t L_23 = V_5;
		if ((((int64_t)L_23) == ((int64_t)((int64_t)((int64_t)((int32_t)17))))))
		{
			goto IL_0148;
		}
	}
	{
		int64_t L_24 = V_5;
		if ((((int64_t)L_24) == ((int64_t)((int64_t)((int64_t)((int32_t)19))))))
		{
			goto IL_015e;
		}
	}
	{
		goto IL_017b;
	}

IL_00b5:
	{
		// result.bundleID = Encoding.UTF8.GetString(value.GetChildNode(0).Data);
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_25 = V_1;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_26;
		L_26 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_27 = V_6;
		NullCheck(L_27);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_28;
		L_28 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_27, 0, /*hidden argument*/NULL);
		NullCheck(L_28);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_29;
		L_29 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_28, /*hidden argument*/NULL);
		NullCheck(L_26);
		String_t* L_30;
		L_30 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_26, L_29);
		NullCheck(L_25);
		AppleReceipt_set_bundleID_m25A02C4A40C8E054E863C72E2D4AD23695FE3482_inline(L_25, L_30, /*hidden argument*/NULL);
		// break;
		goto IL_017b;
	}

IL_00d7:
	{
		// result.appVersion = Encoding.UTF8.GetString(value.GetChildNode(0).Data);
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_31 = V_1;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_32;
		L_32 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_33 = V_6;
		NullCheck(L_33);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_34;
		L_34 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_33, 0, /*hidden argument*/NULL);
		NullCheck(L_34);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_35;
		L_35 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_34, /*hidden argument*/NULL);
		NullCheck(L_32);
		String_t* L_36;
		L_36 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_32, L_35);
		NullCheck(L_31);
		AppleReceipt_set_appVersion_m5D30750E5D757BB076E3B17EB3C2F18A3232A0DD_inline(L_31, L_36, /*hidden argument*/NULL);
		// break;
		goto IL_017b;
	}

IL_00f9:
	{
		// result.opaque = value.Data;
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_37 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_38 = V_6;
		NullCheck(L_38);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_39;
		L_39 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_38, /*hidden argument*/NULL);
		NullCheck(L_37);
		AppleReceipt_set_opaque_mA8F53007E41556E07493855602A21573751D67ED_inline(L_37, L_39, /*hidden argument*/NULL);
		// break;
		goto IL_017b;
	}

IL_0108:
	{
		// result.hash = value.Data;
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_40 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_41 = V_6;
		NullCheck(L_41);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_42;
		L_42 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_41, /*hidden argument*/NULL);
		NullCheck(L_40);
		AppleReceipt_set_hash_m98652052746864E8676E6E374A419E371E9E13DF_inline(L_40, L_42, /*hidden argument*/NULL);
		// break;
		goto IL_017b;
	}

IL_0117:
	{
		// var dateString = Encoding.UTF8.GetString(value.GetChildNode(0).Data);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_43;
		L_43 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_44 = V_6;
		NullCheck(L_44);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_45;
		L_45 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_44, 0, /*hidden argument*/NULL);
		NullCheck(L_45);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_46;
		L_46 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_45, /*hidden argument*/NULL);
		NullCheck(L_43);
		String_t* L_47;
		L_47 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_43, L_46);
		V_7 = L_47;
		// result.receiptCreationDate = DateTime.Parse(dateString).ToUniversalTime();
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_48 = V_1;
		String_t* L_49 = V_7;
		IL2CPP_RUNTIME_CLASS_INIT(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_50;
		L_50 = DateTime_Parse_m15F41E956747FC3E7EEBB24E45AA8733C1966989(L_49, /*hidden argument*/NULL);
		V_8 = L_50;
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_51;
		L_51 = DateTime_ToUniversalTime_mB5FB50E0AD0D9A2A917893A1655F51B174C7A6B3((DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 *)(&V_8), /*hidden argument*/NULL);
		NullCheck(L_48);
		AppleReceipt_set_receiptCreationDate_m00A21F12F64E78048EFF1AC76A9A3E7A3A2742EE_inline(L_48, L_51, /*hidden argument*/NULL);
		// break;
		goto IL_017b;
	}

IL_0148:
	{
		// inApps.Add(ParseInAppReceipt(value.GetChildNode(0)));
		List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 * L_52 = V_2;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_53 = V_6;
		NullCheck(L_53);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_54;
		L_54 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_53, 0, /*hidden argument*/NULL);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_55;
		L_55 = AppleReceiptParser_ParseInAppReceipt_mEB9CAB649C870275D5E5C2DD6710AED8E254C703(__this, L_54, /*hidden argument*/NULL);
		NullCheck(L_52);
		List_1_Add_m240F342C63A57F3BEA7E78AFF14DF3D96C208FE6(L_52, L_55, /*hidden argument*/List_1_Add_m240F342C63A57F3BEA7E78AFF14DF3D96C208FE6_RuntimeMethod_var);
		// break;
		goto IL_017b;
	}

IL_015e:
	{
		// result.originalApplicationVersion = Encoding.UTF8.GetString(value.GetChildNode(0).Data);
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_56 = V_1;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_57;
		L_57 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_58 = V_6;
		NullCheck(L_58);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_59;
		L_59 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_58, 0, /*hidden argument*/NULL);
		NullCheck(L_59);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_60;
		L_60 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_59, /*hidden argument*/NULL);
		NullCheck(L_57);
		String_t* L_61;
		L_61 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_57, L_60);
		NullCheck(L_56);
		AppleReceipt_set_originalApplicationVersion_mDEB66DD33895134615538BC540A7A7868FAE3C83_inline(L_56, L_61, /*hidden argument*/NULL);
	}

IL_017b:
	{
		// for (int t = 0; t < set.ChildNodeCount; t++)
		int32_t L_62 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_62, (int32_t)1));
	}

IL_017f:
	{
		// for (int t = 0; t < set.ChildNodeCount; t++)
		int32_t L_63 = V_3;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_64 = V_0;
		NullCheck(L_64);
		int64_t L_65;
		L_65 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_64, /*hidden argument*/NULL);
		if ((((int64_t)((int64_t)((int64_t)L_63))) < ((int64_t)L_65)))
		{
			goto IL_002e;
		}
	}
	{
		// result.inAppPurchaseReceipts = inApps.ToArray();
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_66 = V_1;
		List_1_tCEE92C0DE44C2B8CA49FA8576243782CACC33A07 * L_67 = V_2;
		NullCheck(L_67);
		AppleInAppPurchaseReceiptU5BU5D_tE521ED29BA1528A3E90EFC6126DA7230E921B3F8* L_68;
		L_68 = List_1_ToArray_mEF201E3A675DB1879B7B5308261F352929154CD6(L_67, /*hidden argument*/List_1_ToArray_mEF201E3A675DB1879B7B5308261F352929154CD6_RuntimeMethod_var);
		NullCheck(L_66);
		L_66->set_inAppPurchaseReceipts_6(L_68);
		// return result;
		AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * L_69 = V_1;
		return L_69;
	}
}
// LipingShare.LCLib.Asn1Processor.Asn1Node UnityEngine.Purchasing.Security.AppleReceiptParser::GetSetNode(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * AppleReceiptParser_GetSetNode_m0E58E5F2D41F7A54260248E404E52832EB7BC140 (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___data0, const RuntimeMethod* method)
{
	{
		// if (data.IsIndefiniteLength && data.ChildNodeCount == 1)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___data0;
		NullCheck(L_0);
		bool L_1;
		L_1 = Asn1Node_get_IsIndefiniteLength_mD03D4CDC16E172CB7384EF056509817408C83FBB_inline(L_0, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0020;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = ___data0;
		NullCheck(L_2);
		int64_t L_3;
		L_3 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_2, /*hidden argument*/NULL);
		if ((!(((uint64_t)L_3) == ((uint64_t)((int64_t)((int64_t)1))))))
		{
			goto IL_0020;
		}
	}
	{
		// var intermediateNode = data.GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4 = ___data0;
		NullCheck(L_4);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5;
		L_5 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_4, 0, /*hidden argument*/NULL);
		// return intermediateNode.GetChildNode(0);
		NullCheck(L_5);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_6;
		L_6 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_5, 0, /*hidden argument*/NULL);
		return L_6;
	}

IL_0020:
	{
		// return data.GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_7 = ___data0;
		NullCheck(L_7);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8;
		L_8 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_7, 0, /*hidden argument*/NULL);
		return L_8;
	}
}
// UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt UnityEngine.Purchasing.Security.AppleReceiptParser::ParseInAppReceipt(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * AppleReceiptParser_ParseInAppReceipt_mEB9CAB649C870275D5E5C2DD6710AED8E254C703 (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___inApp0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * V_0 = NULL;
	int32_t V_1 = 0;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_2 = NULL;
	int64_t V_3 = 0;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_4 = NULL;
	int64_t G_B4_0 = 0;
	int64_t G_B3_0 = 0;
	{
		// var result = new AppleInAppPurchaseReceipt();
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_0 = (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 *)il2cpp_codegen_object_new(AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36_il2cpp_TypeInfo_var);
		AppleInAppPurchaseReceipt__ctor_m2577093C483999A97CEC2BFC23495E0229DE8A4D(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		// for (int t = 0; t < inApp.ChildNodeCount; t++)
		V_1 = 0;
		goto IL_01bb;
	}

IL_000d:
	{
		// var node = inApp.GetChildNode(t);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1 = ___inApp0;
		int32_t L_2 = V_1;
		NullCheck(L_1);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_3;
		L_3 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_1, L_2, /*hidden argument*/NULL);
		V_2 = L_3;
		// if (node.ChildNodeCount == 3)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4 = V_2;
		NullCheck(L_4);
		int64_t L_5;
		L_5 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_4, /*hidden argument*/NULL);
		if ((!(((uint64_t)L_5) == ((uint64_t)((int64_t)((int64_t)3))))))
		{
			goto IL_01b7;
		}
	}
	{
		// var type = Asn1Util.BytesToLong(node.GetChildNode(0).Data);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_6 = V_2;
		NullCheck(L_6);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_7;
		L_7 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_6, 0, /*hidden argument*/NULL);
		NullCheck(L_7);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_8;
		L_8 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_7, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int64_t L_9;
		L_9 = Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7(L_8, /*hidden argument*/NULL);
		V_3 = L_9;
		// var value = node.GetChildNode(2);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_10 = V_2;
		NullCheck(L_10);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_11;
		L_11 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_10, 2, /*hidden argument*/NULL);
		V_4 = L_11;
		int64_t L_12 = V_3;
		int64_t L_13 = ((int64_t)il2cpp_codegen_subtract((int64_t)L_12, (int64_t)((int64_t)((int64_t)((int32_t)1701)))));
		G_B3_0 = L_13;
		if ((!(((uint64_t)L_13) > ((uint64_t)((int64_t)((int64_t)((int32_t)18)))))))
		{
			G_B4_0 = L_13;
			goto IL_0051;
		}
	}
	{
		goto IL_01b7;
	}

IL_0051:
	{
		switch (((int32_t)((uint32_t)G_B4_0)))
		{
			case 0:
			{
				goto IL_00a8;
			}
			case 1:
			{
				goto IL_00c6;
			}
			case 2:
			{
				goto IL_00e8;
			}
			case 3:
			{
				goto IL_012c;
			}
			case 4:
			{
				goto IL_010a;
			}
			case 5:
			{
				goto IL_013b;
			}
			case 6:
			{
				goto IL_0168;
			}
			case 7:
			{
				goto IL_014a;
			}
			case 8:
			{
				goto IL_01b7;
			}
			case 9:
			{
				goto IL_01b7;
			}
			case 10:
			{
				goto IL_01b7;
			}
			case 11:
			{
				goto IL_0159;
			}
			case 12:
			{
				goto IL_0183;
			}
			case 13:
			{
				goto IL_01b7;
			}
			case 14:
			{
				goto IL_01b7;
			}
			case 15:
			{
				goto IL_01b7;
			}
			case 16:
			{
				goto IL_01b7;
			}
			case 17:
			{
				goto IL_01b7;
			}
			case 18:
			{
				goto IL_019e;
			}
		}
	}
	{
		goto IL_01b7;
	}

IL_00a8:
	{
		// result.quantity = (int)Asn1Util.BytesToLong(value.GetChildNode(0).Data);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_14 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_15 = V_4;
		NullCheck(L_15);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_16;
		L_16 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_15, 0, /*hidden argument*/NULL);
		NullCheck(L_16);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_17;
		L_17 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_16, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int64_t L_18;
		L_18 = Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7(L_17, /*hidden argument*/NULL);
		NullCheck(L_14);
		AppleInAppPurchaseReceipt_set_quantity_m7838C12ED8258D3ECCDA44599A8664D99350F9BB_inline(L_14, ((int32_t)((int32_t)L_18)), /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_00c6:
	{
		// result.productID = Encoding.UTF8.GetString(value.GetChildNode(0).Data);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_19 = V_0;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_20;
		L_20 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_21 = V_4;
		NullCheck(L_21);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_22;
		L_22 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_21, 0, /*hidden argument*/NULL);
		NullCheck(L_22);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_22, /*hidden argument*/NULL);
		NullCheck(L_20);
		String_t* L_24;
		L_24 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_20, L_23);
		NullCheck(L_19);
		AppleInAppPurchaseReceipt_set_productID_m20774404517FD2203A1B5C87D1DF035836A58C99_inline(L_19, L_24, /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_00e8:
	{
		// result.transactionID = Encoding.UTF8.GetString(value.GetChildNode(0).Data);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_25 = V_0;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_26;
		L_26 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_27 = V_4;
		NullCheck(L_27);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_28;
		L_28 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_27, 0, /*hidden argument*/NULL);
		NullCheck(L_28);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_29;
		L_29 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_28, /*hidden argument*/NULL);
		NullCheck(L_26);
		String_t* L_30;
		L_30 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_26, L_29);
		NullCheck(L_25);
		AppleInAppPurchaseReceipt_set_transactionID_mEF8CCA16FE937E8CD2058B032515369E98146333_inline(L_25, L_30, /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_010a:
	{
		// result.originalTransactionIdentifier = Encoding.UTF8.GetString(value.GetChildNode(0).Data);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_31 = V_0;
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_32;
		L_32 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_33 = V_4;
		NullCheck(L_33);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_34;
		L_34 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_33, 0, /*hidden argument*/NULL);
		NullCheck(L_34);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_35;
		L_35 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_34, /*hidden argument*/NULL);
		NullCheck(L_32);
		String_t* L_36;
		L_36 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_32, L_35);
		NullCheck(L_31);
		AppleInAppPurchaseReceipt_set_originalTransactionIdentifier_mCB042EF9C653D71F4875FCDEE6DF1808F8E3C070_inline(L_31, L_36, /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_012c:
	{
		// result.purchaseDate = TryParseDateTimeNode(value);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_37 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_38 = V_4;
		IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_39;
		L_39 = AppleReceiptParser_TryParseDateTimeNode_m74F92A23F91951E1B15DD7B6542711032C6AD8AA(L_38, /*hidden argument*/NULL);
		NullCheck(L_37);
		AppleInAppPurchaseReceipt_set_purchaseDate_m38F96B704E6F95810EA9848C5B67587C42D0DFEA_inline(L_37, L_39, /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_013b:
	{
		// result.originalPurchaseDate = TryParseDateTimeNode(value);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_40 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_41 = V_4;
		IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_42;
		L_42 = AppleReceiptParser_TryParseDateTimeNode_m74F92A23F91951E1B15DD7B6542711032C6AD8AA(L_41, /*hidden argument*/NULL);
		NullCheck(L_40);
		AppleInAppPurchaseReceipt_set_originalPurchaseDate_mCA445C1C9420F56D6EE01331D33A688D009BCF03_inline(L_40, L_42, /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_014a:
	{
		// result.subscriptionExpirationDate = TryParseDateTimeNode(value);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_43 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_44 = V_4;
		IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_45;
		L_45 = AppleReceiptParser_TryParseDateTimeNode_m74F92A23F91951E1B15DD7B6542711032C6AD8AA(L_44, /*hidden argument*/NULL);
		NullCheck(L_43);
		AppleInAppPurchaseReceipt_set_subscriptionExpirationDate_mDA1D62DFD0BA2599664C19A4CE0A58404E73A80C_inline(L_43, L_45, /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_0159:
	{
		// result.cancellationDate = TryParseDateTimeNode(value);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_46 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_47 = V_4;
		IL2CPP_RUNTIME_CLASS_INIT(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_48;
		L_48 = AppleReceiptParser_TryParseDateTimeNode_m74F92A23F91951E1B15DD7B6542711032C6AD8AA(L_47, /*hidden argument*/NULL);
		NullCheck(L_46);
		AppleInAppPurchaseReceipt_set_cancellationDate_mD0B29F011BB2B30D117E19E1E8FC3F8E7EFEE0E5_inline(L_46, L_48, /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_0168:
	{
		// result.productType = (int)Asn1Util.BytesToLong(value.GetChildNode(0).Data);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_49 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_50 = V_4;
		NullCheck(L_50);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_51;
		L_51 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_50, 0, /*hidden argument*/NULL);
		NullCheck(L_51);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_52;
		L_52 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_51, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int64_t L_53;
		L_53 = Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7(L_52, /*hidden argument*/NULL);
		NullCheck(L_49);
		AppleInAppPurchaseReceipt_set_productType_m1348D5CF0996703DF6B089CA2CBD9CDAC125ED17_inline(L_49, ((int32_t)((int32_t)L_53)), /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_0183:
	{
		// result.isFreeTrial = (int)Asn1Util.BytesToLong(value.GetChildNode(0).Data);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_54 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_55 = V_4;
		NullCheck(L_55);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_56;
		L_56 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_55, 0, /*hidden argument*/NULL);
		NullCheck(L_56);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_57;
		L_57 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_56, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int64_t L_58;
		L_58 = Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7(L_57, /*hidden argument*/NULL);
		NullCheck(L_54);
		AppleInAppPurchaseReceipt_set_isFreeTrial_mA51C247092E28915A28200F715EB1BEBB1CC88C0_inline(L_54, ((int32_t)((int32_t)L_58)), /*hidden argument*/NULL);
		// break;
		goto IL_01b7;
	}

IL_019e:
	{
		// result.isIntroductoryPricePeriod = (int)Asn1Util.BytesToLong(value.GetChildNode(0).Data);
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_59 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_60 = V_4;
		NullCheck(L_60);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_61;
		L_61 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_60, 0, /*hidden argument*/NULL);
		NullCheck(L_61);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_62;
		L_62 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_61, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int64_t L_63;
		L_63 = Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7(L_62, /*hidden argument*/NULL);
		NullCheck(L_59);
		AppleInAppPurchaseReceipt_set_isIntroductoryPricePeriod_mA41926584FDAD3A1FA54A9BC0816D9741BB1D365_inline(L_59, ((int32_t)((int32_t)L_63)), /*hidden argument*/NULL);
	}

IL_01b7:
	{
		// for (int t = 0; t < inApp.ChildNodeCount; t++)
		int32_t L_64 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_64, (int32_t)1));
	}

IL_01bb:
	{
		// for (int t = 0; t < inApp.ChildNodeCount; t++)
		int32_t L_65 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_66 = ___inApp0;
		NullCheck(L_66);
		int64_t L_67;
		L_67 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_66, /*hidden argument*/NULL);
		if ((((int64_t)((int64_t)((int64_t)L_65))) < ((int64_t)L_67)))
		{
			goto IL_000d;
		}
	}
	{
		// return result;
		AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * L_68 = V_0;
		return L_68;
	}
}
// System.DateTime UnityEngine.Purchasing.Security.AppleReceiptParser::TryParseDateTimeNode(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  AppleReceiptParser_TryParseDateTimeNode_m74F92A23F91951E1B15DD7B6542711032C6AD8AA (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var dateString = Encoding.UTF8.GetString(node.GetChildNode(0).Data);
		Encoding_tE901442411E2E70039D2A4AE77FB81C3D6064827 * L_0;
		L_0 = Encoding_get_UTF8_mC877FB3137BBD566AEE7B15F9BF61DC4EF8F5E5E(/*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1 = ___node0;
		NullCheck(L_1);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2;
		L_2 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_1, 0, /*hidden argument*/NULL);
		NullCheck(L_2);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_3;
		L_3 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_2, /*hidden argument*/NULL);
		NullCheck(L_0);
		String_t* L_4;
		L_4 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_0, L_3);
		V_0 = L_4;
		// if (!string.IsNullOrEmpty(dateString))
		String_t* L_5 = V_0;
		bool L_6;
		L_6 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_5, /*hidden argument*/NULL);
		if (L_6)
		{
			goto IL_002e;
		}
	}
	{
		// return DateTime.Parse(dateString).ToUniversalTime();
		String_t* L_7 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_8;
		L_8 = DateTime_Parse_m15F41E956747FC3E7EEBB24E45AA8733C1966989(L_7, /*hidden argument*/NULL);
		V_1 = L_8;
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_9;
		L_9 = DateTime_ToUniversalTime_mB5FB50E0AD0D9A2A917893A1655F51B174C7A6B3((DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 *)(&V_1), /*hidden argument*/NULL);
		return L_9;
	}

IL_002e:
	{
		// return DateTime.MinValue;
		IL2CPP_RUNTIME_CLASS_INIT(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_10 = ((DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_StaticFields*)il2cpp_codegen_static_fields_for(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var))->get_MinValue_31();
		return L_10;
	}
}
// System.Void UnityEngine.Purchasing.Security.AppleReceiptParser::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleReceiptParser__ctor_m92B7E449AC8995BFA18A465EC47717EF5E5DC86B (AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.AppleReceiptParser::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleReceiptParser__cctor_m7C0A872B03C5B6F9FA69F60429CAE1A273ACCFA4 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private static Dictionary<string, object> _mostRecentReceiptData = new Dictionary<string, object>();
		Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 * L_0 = (Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399 *)il2cpp_codegen_object_new(Dictionary_2_t692011309BA94F599C6042A381FC9F8B3CB08399_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63(L_0, /*hidden argument*/Dictionary_2__ctor_mCD0C2F0325B7677B9BC340A60AA3FB9C7A88FF63_RuntimeMethod_var);
		((AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_StaticFields*)il2cpp_codegen_static_fields_for(AppleReceiptParser_t1391E019ECCDD14CECD09851183129E78BA6A433_il2cpp_TypeInfo_var))->set__mostRecentReceiptData_0(L_0);
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
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node__ctor_m94082F24B4B34958EAC6DC936D16B324589758BC (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___parentNode0, int64_t ___dataOffset1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private string path = "";
		__this->set_path_8(_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		// private bool requireRecalculatePar = true;
		__this->set_requireRecalculatePar_10((bool)1);
		// private bool parseEncapsulatedData = true;
		__this->set_parseEncapsulatedData_12((bool)1);
		// private Asn1Node(Asn1Node parentNode, long dataOffset)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// Init();
		Asn1Node_Init_m14DA7F09F96054644EFFE7DF908FBFEC08DB1297(__this, /*hidden argument*/NULL);
		// deepness = parentNode.Deepness + 1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___parentNode0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = Asn1Node_get_Deepness_m2ED875AFAB0B74DC5A8622DB3B3D18C4B7F6E95F_inline(L_0, /*hidden argument*/NULL);
		__this->set_deepness_7(((int64_t)il2cpp_codegen_add((int64_t)L_1, (int64_t)((int64_t)((int64_t)1)))));
		// this.parentNode = parentNode;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = ___parentNode0;
		__this->set_parentNode_9(L_2);
		// this.dataOffset = dataOffset;
		int64_t L_3 = ___dataOffset1;
		__this->set_dataOffset_1(L_3);
		// }
		return;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::Init()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_Init_m14DA7F09F96054644EFFE7DF908FBFEC08DB1297 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// childNodeList = new ArrayList();
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_0 = (ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 *)il2cpp_codegen_object_new(ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575_il2cpp_TypeInfo_var);
		ArrayList__ctor_m6847CFECD6BDC2AD10A4AC9852A572B88B8D6B1B(L_0, /*hidden argument*/NULL);
		__this->set_childNodeList_5(L_0);
		// data = null;
		__this->set_data_4((ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)NULL);
		// dataLength = 0;
		__this->set_dataLength_2(((int64_t)((int64_t)0)));
		// lengthFieldBytes = 0;
		__this->set_lengthFieldBytes_3(((int64_t)((int64_t)0)));
		// unusedBits = 0;
		__this->set_unusedBits_6((uint8_t)0);
		// tag = Asn1Tag.SEQUENCE | Asn1TagClasses.CONSTRUCTED;
		__this->set_tag_0((uint8_t)((int32_t)48));
		// childNodeList.Clear();
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_1 = __this->get_childNodeList_5();
		NullCheck(L_1);
		VirtActionInvoker0::Invoke(35 /* System.Void System.Collections.ArrayList::Clear() */, L_1);
		// deepness = 0;
		__this->set_deepness_7(((int64_t)((int64_t)0)));
		// parentNode = null;
		__this->set_parentNode_9((Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)NULL);
		// }
		return;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetHexPrintingStr(LipingShare.LCLib.Asn1Processor.Asn1Node,System.String,System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetHexPrintingStr_m0BD9EACAA7BDA5502C4D11C8512E7DF2A65B6F22 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___startNode0, String_t* ___baseLine1, String_t* ___lStr2, int32_t ___lineLen3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* V_2 = NULL;
	{
		// string nodeStr = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// string iStr = GetIndentStr(startNode);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___startNode0;
		String_t* L_1;
		L_1 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_0, /*hidden argument*/NULL);
		V_1 = L_1;
		// string dataStr = Asn1Util.ToHexString(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_2 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_3;
		L_3 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_2, /*hidden argument*/NULL);
		V_2 = L_3;
		// if (dataStr.Length > 0)
		String_t* L_4 = V_2;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_4, /*hidden argument*/NULL);
		if ((((int32_t)L_5) <= ((int32_t)0)))
		{
			goto IL_0078;
		}
	}
	{
		// if (baseLine.Length + dataStr.Length < lineLen)
		String_t* L_6 = ___baseLine1;
		NullCheck(L_6);
		int32_t L_7;
		L_7 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_6, /*hidden argument*/NULL);
		String_t* L_8 = V_2;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_8, /*hidden argument*/NULL);
		int32_t L_10 = ___lineLen3;
		if ((((int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_7, (int32_t)L_9))) >= ((int32_t)L_10)))
		{
			goto IL_005e;
		}
	}
	{
		// nodeStr += baseLine + "'" + dataStr + "'";
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_11 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_12 = L_11;
		String_t* L_13 = V_0;
		NullCheck(L_12);
		ArrayElementTypeCheck (L_12, L_13);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_13);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_14 = L_12;
		String_t* L_15 = ___baseLine1;
		NullCheck(L_14);
		ArrayElementTypeCheck (L_14, L_15);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_15);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_16 = L_14;
		NullCheck(L_16);
		ArrayElementTypeCheck (L_16, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_16)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_17 = L_16;
		String_t* L_18 = V_2;
		NullCheck(L_17);
		ArrayElementTypeCheck (L_17, L_18);
		(L_17)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_18);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_19 = L_17;
		NullCheck(L_19);
		ArrayElementTypeCheck (L_19, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_19)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		String_t* L_20;
		L_20 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_19, /*hidden argument*/NULL);
		V_0 = L_20;
		// }
		goto IL_0080;
	}

IL_005e:
	{
		// nodeStr += baseLine + FormatLineHexString(
		//     lStr,
		//     iStr.Length,
		//     lineLen,
		//     dataStr
		//     );
		String_t* L_21 = V_0;
		String_t* L_22 = ___baseLine1;
		String_t* L_23 = ___lStr2;
		String_t* L_24 = V_1;
		NullCheck(L_24);
		int32_t L_25;
		L_25 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_24, /*hidden argument*/NULL);
		int32_t L_26 = ___lineLen3;
		String_t* L_27 = V_2;
		String_t* L_28;
		L_28 = Asn1Node_FormatLineHexString_mD779CB787AB5999E9C8C43CD848691178F639339(__this, L_23, L_25, L_26, L_27, /*hidden argument*/NULL);
		String_t* L_29;
		L_29 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_21, L_22, L_28, /*hidden argument*/NULL);
		V_0 = L_29;
		// }
		goto IL_0080;
	}

IL_0078:
	{
		// nodeStr += baseLine;
		String_t* L_30 = V_0;
		String_t* L_31 = ___baseLine1;
		String_t* L_32;
		L_32 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_30, L_31, /*hidden argument*/NULL);
		V_0 = L_32;
	}

IL_0080:
	{
		// return nodeStr + "\r\n";
		String_t* L_33 = V_0;
		String_t* L_34;
		L_34 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_33, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5, /*hidden argument*/NULL);
		return L_34;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::FormatLineString(System.String,System.Int32,System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_FormatLineString_mFD55298C08C9C61F3918378C6973279839645DCA (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, String_t* ___lStr0, int32_t ___indent1, int32_t ___lineLen2, String_t* ___msg3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		// string retval = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// indent += indentStep;
		int32_t L_0 = ___indent1;
		___indent1 = ((int32_t)il2cpp_codegen_add((int32_t)L_0, (int32_t)3));
		// int realLen = lineLen - indent;
		int32_t L_1 = ___lineLen2;
		int32_t L_2 = ___indent1;
		V_1 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_1, (int32_t)L_2));
		// int sLen = indent;
		int32_t L_3 = ___indent1;
		V_2 = L_3;
		// for (currentp = 0; currentp < msg.Length; currentp += realLen)
		V_3 = 0;
		goto IL_00b8;
	}

IL_0018:
	{
		// if (currentp + realLen > msg.Length)
		int32_t L_4 = V_3;
		int32_t L_5 = V_1;
		String_t* L_6 = ___msg3;
		NullCheck(L_6);
		int32_t L_7;
		L_7 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_6, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_4, (int32_t)L_5))) <= ((int32_t)L_7)))
		{
			goto IL_0071;
		}
	}
	{
		// retval += "\r\n" + lStr + Asn1Util.GenStr(sLen, ' ') +
		//     "'" + msg.Substring(currentp, msg.Length - currentp) + "'";
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_8 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)7);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_9 = L_8;
		String_t* L_10 = V_0;
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, L_10);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_10);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_11 = L_9;
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_12 = L_11;
		String_t* L_13 = ___lStr0;
		NullCheck(L_12);
		ArrayElementTypeCheck (L_12, L_13);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)L_13);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_14 = L_12;
		int32_t L_15 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_16;
		L_16 = Asn1Util_GenStr_mE8F5722F4437A061860433CFB0478AFFDB15B9B1(L_15, ((int32_t)32), /*hidden argument*/NULL);
		NullCheck(L_14);
		ArrayElementTypeCheck (L_14, L_16);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_16);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_17 = L_14;
		NullCheck(L_17);
		ArrayElementTypeCheck (L_17, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_17)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_18 = L_17;
		String_t* L_19 = ___msg3;
		int32_t L_20 = V_3;
		String_t* L_21 = ___msg3;
		NullCheck(L_21);
		int32_t L_22;
		L_22 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_21, /*hidden argument*/NULL);
		int32_t L_23 = V_3;
		NullCheck(L_19);
		String_t* L_24;
		L_24 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_19, L_20, ((int32_t)il2cpp_codegen_subtract((int32_t)L_22, (int32_t)L_23)), /*hidden argument*/NULL);
		NullCheck(L_18);
		ArrayElementTypeCheck (L_18, L_24);
		(L_18)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)L_24);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_25 = L_18;
		NullCheck(L_25);
		ArrayElementTypeCheck (L_25, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_25)->SetAt(static_cast<il2cpp_array_size_t>(6), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		String_t* L_26;
		L_26 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_25, /*hidden argument*/NULL);
		V_0 = L_26;
		// }
		goto IL_00b4;
	}

IL_0071:
	{
		// retval += "\r\n" + lStr + Asn1Util.GenStr(sLen, ' ') + "'" +
		//     msg.Substring(currentp, realLen) + "'";
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_27 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)7);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_28 = L_27;
		String_t* L_29 = V_0;
		NullCheck(L_28);
		ArrayElementTypeCheck (L_28, L_29);
		(L_28)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_29);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_30 = L_28;
		NullCheck(L_30);
		ArrayElementTypeCheck (L_30, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		(L_30)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_31 = L_30;
		String_t* L_32 = ___lStr0;
		NullCheck(L_31);
		ArrayElementTypeCheck (L_31, L_32);
		(L_31)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)L_32);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_33 = L_31;
		int32_t L_34 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_35;
		L_35 = Asn1Util_GenStr_mE8F5722F4437A061860433CFB0478AFFDB15B9B1(L_34, ((int32_t)32), /*hidden argument*/NULL);
		NullCheck(L_33);
		ArrayElementTypeCheck (L_33, L_35);
		(L_33)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_35);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_36 = L_33;
		NullCheck(L_36);
		ArrayElementTypeCheck (L_36, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_36)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_37 = L_36;
		String_t* L_38 = ___msg3;
		int32_t L_39 = V_3;
		int32_t L_40 = V_1;
		NullCheck(L_38);
		String_t* L_41;
		L_41 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_38, L_39, L_40, /*hidden argument*/NULL);
		NullCheck(L_37);
		ArrayElementTypeCheck (L_37, L_41);
		(L_37)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)L_41);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_42 = L_37;
		NullCheck(L_42);
		ArrayElementTypeCheck (L_42, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_42)->SetAt(static_cast<il2cpp_array_size_t>(6), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		String_t* L_43;
		L_43 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_42, /*hidden argument*/NULL);
		V_0 = L_43;
	}

IL_00b4:
	{
		// for (currentp = 0; currentp < msg.Length; currentp += realLen)
		int32_t L_44 = V_3;
		int32_t L_45 = V_1;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_44, (int32_t)L_45));
	}

IL_00b8:
	{
		// for (currentp = 0; currentp < msg.Length; currentp += realLen)
		int32_t L_46 = V_3;
		String_t* L_47 = ___msg3;
		NullCheck(L_47);
		int32_t L_48;
		L_48 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_47, /*hidden argument*/NULL);
		if ((((int32_t)L_46) < ((int32_t)L_48)))
		{
			goto IL_0018;
		}
	}
	{
		// return retval;
		String_t* L_49 = V_0;
		return L_49;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::FormatLineHexString(System.String,System.Int32,System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_FormatLineHexString_mD779CB787AB5999E9C8C43CD848691178F639339 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, String_t* ___lStr0, int32_t ___indent1, int32_t ___lineLen2, String_t* ___msg3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		// string retval = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// indent += indentStep;
		int32_t L_0 = ___indent1;
		___indent1 = ((int32_t)il2cpp_codegen_add((int32_t)L_0, (int32_t)3));
		// int realLen = lineLen - indent;
		int32_t L_1 = ___lineLen2;
		int32_t L_2 = ___indent1;
		V_1 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_1, (int32_t)L_2));
		// int sLen = indent;
		int32_t L_3 = ___indent1;
		V_2 = L_3;
		// for (currentp = 0; currentp < msg.Length; currentp += realLen)
		V_3 = 0;
		goto IL_0098;
	}

IL_0018:
	{
		// if (currentp + realLen > msg.Length)
		int32_t L_4 = V_3;
		int32_t L_5 = V_1;
		String_t* L_6 = ___msg3;
		NullCheck(L_6);
		int32_t L_7;
		L_7 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_6, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_4, (int32_t)L_5))) <= ((int32_t)L_7)))
		{
			goto IL_0061;
		}
	}
	{
		// retval += "\r\n" + lStr + Asn1Util.GenStr(sLen, ' ') +
		//     msg.Substring(currentp, msg.Length - currentp);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_8 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_9 = L_8;
		String_t* L_10 = V_0;
		NullCheck(L_9);
		ArrayElementTypeCheck (L_9, L_10);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_10);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_11 = L_9;
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_12 = L_11;
		String_t* L_13 = ___lStr0;
		NullCheck(L_12);
		ArrayElementTypeCheck (L_12, L_13);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)L_13);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_14 = L_12;
		int32_t L_15 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_16;
		L_16 = Asn1Util_GenStr_mE8F5722F4437A061860433CFB0478AFFDB15B9B1(L_15, ((int32_t)32), /*hidden argument*/NULL);
		NullCheck(L_14);
		ArrayElementTypeCheck (L_14, L_16);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_16);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_17 = L_14;
		String_t* L_18 = ___msg3;
		int32_t L_19 = V_3;
		String_t* L_20 = ___msg3;
		NullCheck(L_20);
		int32_t L_21;
		L_21 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_20, /*hidden argument*/NULL);
		int32_t L_22 = V_3;
		NullCheck(L_18);
		String_t* L_23;
		L_23 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_18, L_19, ((int32_t)il2cpp_codegen_subtract((int32_t)L_21, (int32_t)L_22)), /*hidden argument*/NULL);
		NullCheck(L_17);
		ArrayElementTypeCheck (L_17, L_23);
		(L_17)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)L_23);
		String_t* L_24;
		L_24 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_17, /*hidden argument*/NULL);
		V_0 = L_24;
		// }
		goto IL_0094;
	}

IL_0061:
	{
		// retval += "\r\n" + lStr + Asn1Util.GenStr(sLen, ' ') +
		//     msg.Substring(currentp, realLen);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_25 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_26 = L_25;
		String_t* L_27 = V_0;
		NullCheck(L_26);
		ArrayElementTypeCheck (L_26, L_27);
		(L_26)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_27);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_28 = L_26;
		NullCheck(L_28);
		ArrayElementTypeCheck (L_28, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		(L_28)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_29 = L_28;
		String_t* L_30 = ___lStr0;
		NullCheck(L_29);
		ArrayElementTypeCheck (L_29, L_30);
		(L_29)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)L_30);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_31 = L_29;
		int32_t L_32 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_33;
		L_33 = Asn1Util_GenStr_mE8F5722F4437A061860433CFB0478AFFDB15B9B1(L_32, ((int32_t)32), /*hidden argument*/NULL);
		NullCheck(L_31);
		ArrayElementTypeCheck (L_31, L_33);
		(L_31)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_33);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_34 = L_31;
		String_t* L_35 = ___msg3;
		int32_t L_36 = V_3;
		int32_t L_37 = V_1;
		NullCheck(L_35);
		String_t* L_38;
		L_38 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_35, L_36, L_37, /*hidden argument*/NULL);
		NullCheck(L_34);
		ArrayElementTypeCheck (L_34, L_38);
		(L_34)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)L_38);
		String_t* L_39;
		L_39 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_34, /*hidden argument*/NULL);
		V_0 = L_39;
	}

IL_0094:
	{
		// for (currentp = 0; currentp < msg.Length; currentp += realLen)
		int32_t L_40 = V_3;
		int32_t L_41 = V_1;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_40, (int32_t)L_41));
	}

IL_0098:
	{
		// for (currentp = 0; currentp < msg.Length; currentp += realLen)
		int32_t L_42 = V_3;
		String_t* L_43 = ___msg3;
		NullCheck(L_43);
		int32_t L_44;
		L_44 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_43, /*hidden argument*/NULL);
		if ((((int32_t)L_42) < ((int32_t)L_44)))
		{
			goto IL_0018;
		}
	}
	{
		// return retval;
		String_t* L_45 = V_0;
		return L_45;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node__ctor_mB242F7479DDBE60A03AF22BC268BD4DA1EA62E5B (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private string path = "";
		__this->set_path_8(_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		// private bool requireRecalculatePar = true;
		__this->set_requireRecalculatePar_10((bool)1);
		// private bool parseEncapsulatedData = true;
		__this->set_parseEncapsulatedData_12((bool)1);
		// public Asn1Node()
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// Init();
		Asn1Node_Init_m14DA7F09F96054644EFFE7DF908FBFEC08DB1297(__this, /*hidden argument*/NULL);
		// dataOffset = 0;
		__this->set_dataOffset_1(((int64_t)((int64_t)0)));
		// }
		return;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::get_IsIndefiniteLength()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_get_IsIndefiniteLength_mD03D4CDC16E172CB7384EF056509817408C83FBB (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return isIndefiniteLength;
		bool L_0 = __this->get_isIndefiniteLength_11();
		return L_0;
	}
}
// System.Byte LipingShare.LCLib.Asn1Processor.Asn1Node::get_Tag()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint8_t Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return tag;
		uint8_t L_0 = __this->get_tag_0();
		return L_0;
	}
}
// System.Byte LipingShare.LCLib.Asn1Processor.Asn1Node::get_MaskedTag()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint8_t Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return (byte)(tag & Asn1Tag.TAG_MASK);
		uint8_t L_0 = __this->get_tag_0();
		return (uint8_t)((int32_t)((uint8_t)((int32_t)((int32_t)L_0&(int32_t)((int32_t)31)))));
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::LoadData(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_LoadData_m19814DE77D7FE6BD5E95380BF1AB1357F15C750F (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	bool V_0 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;

IL_0000:
	try
	{ // begin try (depth: 1)
		// RequireRecalculatePar = false;
		Asn1Node_set_RequireRecalculatePar_m39322AC2FD6FC053F6E61C5665C0898C7E52C21F_inline(__this, (bool)0, /*hidden argument*/NULL);
		// retval = InternalLoadData(xdata);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		bool L_1;
		L_1 = Asn1Node_InternalLoadData_mD4F124147CA5C1269F2CFA65E20AD7104477E3B9(__this, L_0, /*hidden argument*/NULL);
		// return retval;
		V_0 = L_1;
		IL2CPP_LEAVE(0x1F, FINALLY_0011);
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0011;
	}

FINALLY_0011:
	{ // begin finally (depth: 1)
		// RequireRecalculatePar = true;
		Asn1Node_set_RequireRecalculatePar_m39322AC2FD6FC053F6E61C5665C0898C7E52C21F_inline(__this, (bool)1, /*hidden argument*/NULL);
		// RecalculateTreePar();
		Asn1Node_RecalculateTreePar_m6437576AC8919D0347737FDE2EB8AA7B4FDDAA97(__this, /*hidden argument*/NULL);
		// }
		IL2CPP_END_FINALLY(17)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(17)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x1F, IL_001f)
	}

IL_001f:
	{
		// }
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::SaveData(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_SaveData_m5130FD25C319C413AE8F113454C33DA32072191E (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int64_t V_1 = 0;
	int32_t V_2 = 0;
	{
		// bool retval = true;
		V_0 = (bool)1;
		// long nodeCount = ChildNodeCount;
		int64_t L_0;
		L_0 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(__this, /*hidden argument*/NULL);
		V_1 = L_0;
		// xdata.WriteByte(tag);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = ___xdata0;
		uint8_t L_2 = __this->get_tag_0();
		NullCheck(L_1);
		VirtActionInvoker1< uint8_t >::Invoke(37 /* System.Void System.IO.Stream::WriteByte(System.Byte) */, L_1, L_2);
		// Asn1Util.DERLengthEncode(xdata, (ulong)dataLength);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_3 = ___xdata0;
		int64_t L_4 = __this->get_dataLength_2();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int32_t L_5;
		L_5 = Asn1Util_DERLengthEncode_mAB5A1E98AC3EF600B339FE181ADF620BBB2DF2FD(L_3, L_4, /*hidden argument*/NULL);
		// if ((tag) == Asn1Tag.BIT_STRING)
		uint8_t L_6 = __this->get_tag_0();
		if ((!(((uint32_t)L_6) == ((uint32_t)3))))
		{
			goto IL_0037;
		}
	}
	{
		// xdata.WriteByte(unusedBits);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_7 = ___xdata0;
		uint8_t L_8 = __this->get_unusedBits_6();
		NullCheck(L_7);
		VirtActionInvoker1< uint8_t >::Invoke(37 /* System.Void System.IO.Stream::WriteByte(System.Byte) */, L_7, L_8);
	}

IL_0037:
	{
		// if (nodeCount == 0)
		int64_t L_9 = V_1;
		if (L_9)
		{
			goto IL_0059;
		}
	}
	{
		// if (data != null)
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_10 = __this->get_data_4();
		if (!L_10)
		{
			goto IL_0074;
		}
	}
	{
		// xdata.Write(data, 0, data.Length);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_11 = ___xdata0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_12 = __this->get_data_4();
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_13 = __this->get_data_4();
		NullCheck(L_13);
		NullCheck(L_11);
		VirtActionInvoker3< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(36 /* System.Void System.IO.Stream::Write(System.Byte[],System.Int32,System.Int32) */, L_11, L_12, 0, ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length))));
		// }
		goto IL_0074;
	}

IL_0059:
	{
		// for (i = 0; i < nodeCount; i++)
		V_2 = 0;
		goto IL_006f;
	}

IL_005d:
	{
		// tempNode = GetChildNode(i);
		int32_t L_14 = V_2;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_15;
		L_15 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(__this, L_14, /*hidden argument*/NULL);
		// retval = tempNode.SaveData(xdata);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_16 = ___xdata0;
		NullCheck(L_15);
		bool L_17;
		L_17 = Asn1Node_SaveData_m5130FD25C319C413AE8F113454C33DA32072191E(L_15, L_16, /*hidden argument*/NULL);
		V_0 = L_17;
		// for (i = 0; i < nodeCount; i++)
		int32_t L_18 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_18, (int32_t)1));
	}

IL_006f:
	{
		// for (i = 0; i < nodeCount; i++)
		int32_t L_19 = V_2;
		int64_t L_20 = V_1;
		if ((((int64_t)((int64_t)((int64_t)L_19))) < ((int64_t)L_20)))
		{
			goto IL_005d;
		}
	}

IL_0074:
	{
		// return retval;
		bool L_21 = V_0;
		return L_21;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ClearAll()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ClearAll_mD39130DFBE7AD1AF33618AEF2CE0CE2757D27046 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		// data = null;
		__this->set_data_4((ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)NULL);
		// for (int i = 0; i < childNodeList.Count; i++)
		V_0 = 0;
		goto IL_0025;
	}

IL_000b:
	{
		// tempNode = (Asn1Node)childNodeList[i];
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_0 = __this->get_childNodeList_5();
		int32_t L_1 = V_0;
		NullCheck(L_0);
		RuntimeObject * L_2;
		L_2 = VirtFuncInvoker1< RuntimeObject *, int32_t >::Invoke(28 /* System.Object System.Collections.ArrayList::get_Item(System.Int32) */, L_0, L_1);
		// tempNode.ClearAll();
		NullCheck(((Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)CastclassClass((RuntimeObject*)L_2, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var)));
		Asn1Node_ClearAll_mD39130DFBE7AD1AF33618AEF2CE0CE2757D27046(((Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)CastclassClass((RuntimeObject*)L_2, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var)), /*hidden argument*/NULL);
		// for (int i = 0; i < childNodeList.Count; i++)
		int32_t L_3 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_3, (int32_t)1));
	}

IL_0025:
	{
		// for (int i = 0; i < childNodeList.Count; i++)
		int32_t L_4 = V_0;
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_5 = __this->get_childNodeList_5();
		NullCheck(L_5);
		int32_t L_6;
		L_6 = VirtFuncInvoker0< int32_t >::Invoke(23 /* System.Int32 System.Collections.ArrayList::get_Count() */, L_5);
		if ((((int32_t)L_4) < ((int32_t)L_6)))
		{
			goto IL_000b;
		}
	}
	{
		// childNodeList.Clear();
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_7 = __this->get_childNodeList_5();
		NullCheck(L_7);
		VirtActionInvoker0::Invoke(35 /* System.Void System.Collections.ArrayList::Clear() */, L_7);
		// RecalculateTreePar();
		Asn1Node_RecalculateTreePar_m6437576AC8919D0347737FDE2EB8AA7B4FDDAA97(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::AddChild(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_AddChild_m2A68F11D8748772F35AA72997F724034790B2605 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___xdata0, const RuntimeMethod* method)
{
	{
		// childNodeList.Add(xdata);
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_0 = __this->get_childNodeList_5();
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1 = ___xdata0;
		NullCheck(L_0);
		int32_t L_2;
		L_2 = VirtFuncInvoker1< int32_t, RuntimeObject * >::Invoke(30 /* System.Int32 System.Collections.ArrayList::Add(System.Object) */, L_0, L_1);
		// RecalculateTreePar();
		Asn1Node_RecalculateTreePar_m6437576AC8919D0347737FDE2EB8AA7B4FDDAA97(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Node::GetLastChild()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Node_GetLastChild_m0F7F8629136DB0882A19E41C4F74BBF16F36E317 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return (Asn1Node)childNodeList[childNodeList.Count - 1];
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_0 = __this->get_childNodeList_5();
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_1 = __this->get_childNodeList_5();
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(23 /* System.Int32 System.Collections.ArrayList::get_Count() */, L_1);
		NullCheck(L_0);
		RuntimeObject * L_3;
		L_3 = VirtFuncInvoker1< RuntimeObject *, int32_t >::Invoke(28 /* System.Object System.Collections.ArrayList::get_Item(System.Int32) */, L_0, ((int32_t)il2cpp_codegen_subtract((int32_t)L_2, (int32_t)1)));
		return ((Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)CastclassClass((RuntimeObject*)L_3, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var));
	}
}
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::get_ChildNodeCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return childNodeList.Count;
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_0 = __this->get_childNodeList_5();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(23 /* System.Int32 System.Collections.ArrayList::get_Count() */, L_0);
		return ((int64_t)((int64_t)L_1));
	}
}
// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Node::GetChildNode(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_0 = NULL;
	{
		// Asn1Node retval = null;
		V_0 = (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)NULL;
		// if (index < ChildNodeCount)
		int32_t L_0 = ___index0;
		int64_t L_1;
		L_1 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(__this, /*hidden argument*/NULL);
		if ((((int64_t)((int64_t)((int64_t)L_0))) >= ((int64_t)L_1)))
		{
			goto IL_001e;
		}
	}
	{
		// retval = (Asn1Node)childNodeList[index];
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_2 = __this->get_childNodeList_5();
		int32_t L_3 = ___index0;
		NullCheck(L_2);
		RuntimeObject * L_4;
		L_4 = VirtFuncInvoker1< RuntimeObject *, int32_t >::Invoke(28 /* System.Object System.Collections.ArrayList::get_Item(System.Int32) */, L_2, L_3);
		V_0 = ((Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)CastclassClass((RuntimeObject*)L_4, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var));
	}

IL_001e:
	{
		// return retval;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5 = V_0;
		return L_5;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::get_TagName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return Asn1Util.GetTagName(tag);
		uint8_t L_0 = __this->get_tag_0();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_1;
		L_1 = Asn1Util_GetTagName_m02927760E26BC5A39C7DBA088AE6427B24ADA73D(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Node::get_ParentNode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Node_get_ParentNode_mB1CB94F695AF71514E30EFEA66AD34AF626D2E44 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return parentNode;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = __this->get_parentNode_9();
		return L_0;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetText(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetText_m08AD0406E4330E7F0B546A1C8AA67D2B88F77B72 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___startNode0, int32_t ___lineLen1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RelativeOid_t97392E06363F6AFF26543502032B89445860F72A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1AC39C0EA9E4D306D424F6C66A205ABF47D53B5E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4202CE17CF8429812DBB3C69FBD0097EC2457F9F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5F3ACD009658E07BAE430ABC62FC30CE666E7249);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9787EA65D34ACB2E800972522D1FB9E8D86E0511);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB4A7D2EEB1F22F7D3B5BE89D41486AAF0411C31A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC2DD8ADEA00866AFE6382302B25CE5A086DBCEF8);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* V_2 = NULL;
	String_t* V_3 = NULL;
	String_t* V_4 = NULL;
	uint8_t V_5 = 0x0;
	int64_t V_6 = 0;
	{
		// string nodeStr = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// string baseLine = "";
		V_1 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// string dataStr = "";
		V_2 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// switch (tag)
		uint8_t L_0 = __this->get_tag_0();
		V_5 = L_0;
		uint8_t L_1 = V_5;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_1, (int32_t)2)))
		{
			case 0:
			{
				goto IL_0361;
			}
			case 1:
			{
				goto IL_0092;
			}
			case 2:
			{
				goto IL_044b;
			}
			case 3:
			{
				goto IL_044b;
			}
			case 4:
			{
				goto IL_0182;
			}
		}
	}
	{
		uint8_t L_2 = V_5;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_2, (int32_t)((int32_t)12))))
		{
			case 0:
			{
				goto IL_0282;
			}
			case 1:
			{
				goto IL_0203;
			}
			case 2:
			{
				goto IL_044b;
			}
			case 3:
			{
				goto IL_044b;
			}
			case 4:
			{
				goto IL_044b;
			}
			case 5:
			{
				goto IL_044b;
			}
			case 6:
			{
				goto IL_0282;
			}
			case 7:
			{
				goto IL_0282;
			}
			case 8:
			{
				goto IL_044b;
			}
			case 9:
			{
				goto IL_044b;
			}
			case 10:
			{
				goto IL_0282;
			}
			case 11:
			{
				goto IL_0282;
			}
			case 12:
			{
				goto IL_0282;
			}
			case 13:
			{
				goto IL_044b;
			}
			case 14:
			{
				goto IL_0282;
			}
			case 15:
			{
				goto IL_0282;
			}
			case 16:
			{
				goto IL_0282;
			}
			case 17:
			{
				goto IL_044b;
			}
			case 18:
			{
				goto IL_0282;
			}
		}
	}
	{
		goto IL_044b;
	}

IL_0092:
	{
		// baseLine =
		//     String.Format("{0,6}|{1,6}|{2,7}|{3} {4} UnusedBits:{5} : ",
		//     dataOffset,
		//     dataLength,
		//     lengthFieldBytes,
		//     GetIndentStr(startNode),
		//     TagName,
		//     unusedBits
		//     );
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_3 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)6);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_4 = L_3;
		int64_t L_5 = __this->get_dataOffset_1();
		int64_t L_6 = L_5;
		RuntimeObject * L_7 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_6);
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_7);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_8 = L_4;
		int64_t L_9 = __this->get_dataLength_2();
		int64_t L_10 = L_9;
		RuntimeObject * L_11 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_10);
		NullCheck(L_8);
		ArrayElementTypeCheck (L_8, L_11);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_11);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_12 = L_8;
		int64_t L_13 = __this->get_lengthFieldBytes_3();
		int64_t L_14 = L_13;
		RuntimeObject * L_15 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_14);
		NullCheck(L_12);
		ArrayElementTypeCheck (L_12, L_15);
		(L_12)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_15);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_16 = L_12;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_17 = ___startNode0;
		String_t* L_18;
		L_18 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_17, /*hidden argument*/NULL);
		NullCheck(L_16);
		ArrayElementTypeCheck (L_16, L_18);
		(L_16)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_18);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_19 = L_16;
		String_t* L_20;
		L_20 = Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C(__this, /*hidden argument*/NULL);
		NullCheck(L_19);
		ArrayElementTypeCheck (L_19, L_20);
		(L_19)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject *)L_20);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_21 = L_19;
		uint8_t L_22 = __this->get_unusedBits_6();
		uint8_t L_23 = L_22;
		RuntimeObject * L_24 = Box(Byte_t0111FAB8B8685667EDDAF77683F0D8F86B659056_il2cpp_TypeInfo_var, &L_23);
		NullCheck(L_21);
		ArrayElementTypeCheck (L_21, L_24);
		(L_21)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject *)L_24);
		String_t* L_25;
		L_25 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteralB4A7D2EEB1F22F7D3B5BE89D41486AAF0411C31A, L_21, /*hidden argument*/NULL);
		V_1 = L_25;
		// dataStr = Asn1Util.ToHexString(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_26 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_27;
		L_27 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_26, /*hidden argument*/NULL);
		V_2 = L_27;
		// if (baseLine.Length + dataStr.Length < lineLen)
		String_t* L_28 = V_1;
		NullCheck(L_28);
		int32_t L_29;
		L_29 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_28, /*hidden argument*/NULL);
		String_t* L_30 = V_2;
		NullCheck(L_30);
		int32_t L_31;
		L_31 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_30, /*hidden argument*/NULL);
		int32_t L_32 = ___lineLen1;
		if ((((int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_29, (int32_t)L_31))) >= ((int32_t)L_32)))
		{
			goto IL_0152;
		}
	}
	{
		// if (dataStr.Length < 1)
		String_t* L_33 = V_2;
		NullCheck(L_33);
		int32_t L_34;
		L_34 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_33, /*hidden argument*/NULL);
		if ((((int32_t)L_34) >= ((int32_t)1)))
		{
			goto IL_0125;
		}
	}
	{
		// nodeStr += baseLine + "\r\n";
		String_t* L_35 = V_0;
		String_t* L_36 = V_1;
		String_t* L_37;
		L_37 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_35, L_36, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5, /*hidden argument*/NULL);
		V_0 = L_37;
		// }
		goto IL_057c;
	}

IL_0125:
	{
		// nodeStr += baseLine + "'" + dataStr + "'\r\n";
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_38 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_39 = L_38;
		String_t* L_40 = V_0;
		NullCheck(L_39);
		ArrayElementTypeCheck (L_39, L_40);
		(L_39)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_40);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_41 = L_39;
		String_t* L_42 = V_1;
		NullCheck(L_41);
		ArrayElementTypeCheck (L_41, L_42);
		(L_41)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_42);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_43 = L_41;
		NullCheck(L_43);
		ArrayElementTypeCheck (L_43, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_43)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_44 = L_43;
		String_t* L_45 = V_2;
		NullCheck(L_44);
		ArrayElementTypeCheck (L_44, L_45);
		(L_44)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_45);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_46 = L_44;
		NullCheck(L_46);
		ArrayElementTypeCheck (L_46, _stringLiteral1AC39C0EA9E4D306D424F6C66A205ABF47D53B5E);
		(L_46)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral1AC39C0EA9E4D306D424F6C66A205ABF47D53B5E);
		String_t* L_47;
		L_47 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_46, /*hidden argument*/NULL);
		V_0 = L_47;
		// }
		goto IL_057c;
	}

IL_0152:
	{
		// nodeStr += baseLine + FormatLineHexString(
		//     lStr,
		//     GetIndentStr(startNode).Length,
		//     lineLen,
		//     dataStr + "\r\n"
		//     );
		String_t* L_48 = V_0;
		String_t* L_49 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_50 = ___startNode0;
		String_t* L_51;
		L_51 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_50, /*hidden argument*/NULL);
		NullCheck(L_51);
		int32_t L_52;
		L_52 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_51, /*hidden argument*/NULL);
		int32_t L_53 = ___lineLen1;
		String_t* L_54 = V_2;
		String_t* L_55;
		L_55 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_54, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5, /*hidden argument*/NULL);
		String_t* L_56;
		L_56 = Asn1Node_FormatLineHexString_mD779CB787AB5999E9C8C43CD848691178F639339(__this, _stringLiteralC2DD8ADEA00866AFE6382302B25CE5A086DBCEF8, L_52, L_53, L_55, /*hidden argument*/NULL);
		String_t* L_57;
		L_57 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_48, L_49, L_56, /*hidden argument*/NULL);
		V_0 = L_57;
		// break;
		goto IL_057c;
	}

IL_0182:
	{
		// Oid xoid = new Oid();
		Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * L_58 = (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D *)il2cpp_codegen_object_new(Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var);
		Oid__ctor_m5F73190FA2302798601F2B61863F12363DF5E843(L_58, /*hidden argument*/NULL);
		// oid = xoid.Decode(new MemoryStream(data));
		Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * L_59 = L_58;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_60 = __this->get_data_4();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_61 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2(L_61, L_60, /*hidden argument*/NULL);
		NullCheck(L_59);
		String_t* L_62;
		L_62 = VirtFuncInvoker1< String_t*, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * >::Invoke(4 /* System.String LipingShare.LCLib.Asn1Processor.Oid::Decode(System.IO.Stream) */, L_59, L_61);
		V_3 = L_62;
		// oidName = xoid.GetOidName(oid);
		String_t* L_63 = V_3;
		NullCheck(L_59);
		String_t* L_64;
		L_64 = Oid_GetOidName_mF1BA27FF9C294059635716F0A23C27D63C69698B(L_59, L_63, /*hidden argument*/NULL);
		V_4 = L_64;
		// nodeStr += String.Format("{0,6}|{1,6}|{2,7}|{3} {4} : {5} [{6}]\r\n",
		//     dataOffset,
		//     dataLength,
		//     lengthFieldBytes,
		//     GetIndentStr(startNode),
		//     TagName,
		//     oidName,
		//     oid
		//     );
		String_t* L_65 = V_0;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_66 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)7);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_67 = L_66;
		int64_t L_68 = __this->get_dataOffset_1();
		int64_t L_69 = L_68;
		RuntimeObject * L_70 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_69);
		NullCheck(L_67);
		ArrayElementTypeCheck (L_67, L_70);
		(L_67)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_70);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_71 = L_67;
		int64_t L_72 = __this->get_dataLength_2();
		int64_t L_73 = L_72;
		RuntimeObject * L_74 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_73);
		NullCheck(L_71);
		ArrayElementTypeCheck (L_71, L_74);
		(L_71)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_74);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_75 = L_71;
		int64_t L_76 = __this->get_lengthFieldBytes_3();
		int64_t L_77 = L_76;
		RuntimeObject * L_78 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_77);
		NullCheck(L_75);
		ArrayElementTypeCheck (L_75, L_78);
		(L_75)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_78);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_79 = L_75;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_80 = ___startNode0;
		String_t* L_81;
		L_81 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_80, /*hidden argument*/NULL);
		NullCheck(L_79);
		ArrayElementTypeCheck (L_79, L_81);
		(L_79)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_81);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_82 = L_79;
		String_t* L_83;
		L_83 = Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C(__this, /*hidden argument*/NULL);
		NullCheck(L_82);
		ArrayElementTypeCheck (L_82, L_83);
		(L_82)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject *)L_83);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_84 = L_82;
		String_t* L_85 = V_4;
		NullCheck(L_84);
		ArrayElementTypeCheck (L_84, L_85);
		(L_84)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject *)L_85);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_86 = L_84;
		String_t* L_87 = V_3;
		NullCheck(L_86);
		ArrayElementTypeCheck (L_86, L_87);
		(L_86)->SetAt(static_cast<il2cpp_array_size_t>(6), (RuntimeObject *)L_87);
		String_t* L_88;
		L_88 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral5F3ACD009658E07BAE430ABC62FC30CE666E7249, L_86, /*hidden argument*/NULL);
		String_t* L_89;
		L_89 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_65, L_88, /*hidden argument*/NULL);
		V_0 = L_89;
		// break;
		goto IL_057c;
	}

IL_0203:
	{
		// RelativeOid xiod = new RelativeOid();
		RelativeOid_t97392E06363F6AFF26543502032B89445860F72A * L_90 = (RelativeOid_t97392E06363F6AFF26543502032B89445860F72A *)il2cpp_codegen_object_new(RelativeOid_t97392E06363F6AFF26543502032B89445860F72A_il2cpp_TypeInfo_var);
		RelativeOid__ctor_m1DD6406191F78BC9BAAC9FD71BAF4AFC9372A6C8(L_90, /*hidden argument*/NULL);
		// oid = xiod.Decode(new MemoryStream(data));
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_91 = __this->get_data_4();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_92 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2(L_92, L_91, /*hidden argument*/NULL);
		NullCheck(L_90);
		String_t* L_93;
		L_93 = VirtFuncInvoker1< String_t*, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * >::Invoke(4 /* System.String LipingShare.LCLib.Asn1Processor.Oid::Decode(System.IO.Stream) */, L_90, L_92);
		V_3 = L_93;
		// oidName = "";
		V_4 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// nodeStr += String.Format("{0,6}|{1,6}|{2,7}|{3} {4} : {5} [{6}]\r\n",
		//     dataOffset,
		//     dataLength,
		//     lengthFieldBytes,
		//     GetIndentStr(startNode),
		//     TagName,
		//     oidName,
		//     oid
		//     );
		String_t* L_94 = V_0;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_95 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)7);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_96 = L_95;
		int64_t L_97 = __this->get_dataOffset_1();
		int64_t L_98 = L_97;
		RuntimeObject * L_99 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_98);
		NullCheck(L_96);
		ArrayElementTypeCheck (L_96, L_99);
		(L_96)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_99);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_100 = L_96;
		int64_t L_101 = __this->get_dataLength_2();
		int64_t L_102 = L_101;
		RuntimeObject * L_103 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_102);
		NullCheck(L_100);
		ArrayElementTypeCheck (L_100, L_103);
		(L_100)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_103);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_104 = L_100;
		int64_t L_105 = __this->get_lengthFieldBytes_3();
		int64_t L_106 = L_105;
		RuntimeObject * L_107 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_106);
		NullCheck(L_104);
		ArrayElementTypeCheck (L_104, L_107);
		(L_104)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_107);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_108 = L_104;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_109 = ___startNode0;
		String_t* L_110;
		L_110 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_109, /*hidden argument*/NULL);
		NullCheck(L_108);
		ArrayElementTypeCheck (L_108, L_110);
		(L_108)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_110);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_111 = L_108;
		String_t* L_112;
		L_112 = Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C(__this, /*hidden argument*/NULL);
		NullCheck(L_111);
		ArrayElementTypeCheck (L_111, L_112);
		(L_111)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject *)L_112);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_113 = L_111;
		String_t* L_114 = V_4;
		NullCheck(L_113);
		ArrayElementTypeCheck (L_113, L_114);
		(L_113)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject *)L_114);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_115 = L_113;
		String_t* L_116 = V_3;
		NullCheck(L_115);
		ArrayElementTypeCheck (L_115, L_116);
		(L_115)->SetAt(static_cast<il2cpp_array_size_t>(6), (RuntimeObject *)L_116);
		String_t* L_117;
		L_117 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral5F3ACD009658E07BAE430ABC62FC30CE666E7249, L_115, /*hidden argument*/NULL);
		String_t* L_118;
		L_118 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_94, L_117, /*hidden argument*/NULL);
		V_0 = L_118;
		// break;
		goto IL_057c;
	}

IL_0282:
	{
		// baseLine =
		//     String.Format("{0,6}|{1,6}|{2,7}|{3} {4} : ",
		//     dataOffset,
		//     dataLength,
		//     lengthFieldBytes,
		//     GetIndentStr(startNode),
		//     TagName
		//     );
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_119 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)5);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_120 = L_119;
		int64_t L_121 = __this->get_dataOffset_1();
		int64_t L_122 = L_121;
		RuntimeObject * L_123 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_122);
		NullCheck(L_120);
		ArrayElementTypeCheck (L_120, L_123);
		(L_120)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_123);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_124 = L_120;
		int64_t L_125 = __this->get_dataLength_2();
		int64_t L_126 = L_125;
		RuntimeObject * L_127 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_126);
		NullCheck(L_124);
		ArrayElementTypeCheck (L_124, L_127);
		(L_124)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_127);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_128 = L_124;
		int64_t L_129 = __this->get_lengthFieldBytes_3();
		int64_t L_130 = L_129;
		RuntimeObject * L_131 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_130);
		NullCheck(L_128);
		ArrayElementTypeCheck (L_128, L_131);
		(L_128)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_131);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_132 = L_128;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_133 = ___startNode0;
		String_t* L_134;
		L_134 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_133, /*hidden argument*/NULL);
		NullCheck(L_132);
		ArrayElementTypeCheck (L_132, L_134);
		(L_132)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_134);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_135 = L_132;
		String_t* L_136;
		L_136 = Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C(__this, /*hidden argument*/NULL);
		NullCheck(L_135);
		ArrayElementTypeCheck (L_135, L_136);
		(L_135)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject *)L_136);
		String_t* L_137;
		L_137 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral4202CE17CF8429812DBB3C69FBD0097EC2457F9F, L_135, /*hidden argument*/NULL);
		V_1 = L_137;
		// if (tag == Asn1Tag.UTF8_STRING)
		uint8_t L_138 = __this->get_tag_0();
		if ((!(((uint32_t)L_138) == ((uint32_t)((int32_t)12)))))
		{
			goto IL_02ed;
		}
	}
	{
		// UTF8Encoding unicode = new UTF8Encoding();
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_139 = (UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 *)il2cpp_codegen_object_new(UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		UTF8Encoding__ctor_mA3F21D41B65D155202345802A05761A4BC022888(L_139, /*hidden argument*/NULL);
		// dataStr = unicode.GetString(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_140 = __this->get_data_4();
		NullCheck(L_139);
		String_t* L_141;
		L_141 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_139, L_140);
		V_2 = L_141;
		// }
		goto IL_02f9;
	}

IL_02ed:
	{
		// dataStr = Asn1Util.BytesToString(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_142 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_143;
		L_143 = Asn1Util_BytesToString_mA5E3457776D5F5FAF8C7D2850268B8FA9E8CE441(L_142, /*hidden argument*/NULL);
		V_2 = L_143;
	}

IL_02f9:
	{
		// if (baseLine.Length + dataStr.Length < lineLen)
		String_t* L_144 = V_1;
		NullCheck(L_144);
		int32_t L_145;
		L_145 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_144, /*hidden argument*/NULL);
		String_t* L_146 = V_2;
		NullCheck(L_146);
		int32_t L_147;
		L_147 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_146, /*hidden argument*/NULL);
		int32_t L_148 = ___lineLen1;
		if ((((int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_145, (int32_t)L_147))) >= ((int32_t)L_148)))
		{
			goto IL_0336;
		}
	}
	{
		// nodeStr += baseLine + "'" + dataStr + "'\r\n";
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_149 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_150 = L_149;
		String_t* L_151 = V_0;
		NullCheck(L_150);
		ArrayElementTypeCheck (L_150, L_151);
		(L_150)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_151);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_152 = L_150;
		String_t* L_153 = V_1;
		NullCheck(L_152);
		ArrayElementTypeCheck (L_152, L_153);
		(L_152)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_153);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_154 = L_152;
		NullCheck(L_154);
		ArrayElementTypeCheck (L_154, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_154)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_155 = L_154;
		String_t* L_156 = V_2;
		NullCheck(L_155);
		ArrayElementTypeCheck (L_155, L_156);
		(L_155)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_156);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_157 = L_155;
		NullCheck(L_157);
		ArrayElementTypeCheck (L_157, _stringLiteral1AC39C0EA9E4D306D424F6C66A205ABF47D53B5E);
		(L_157)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral1AC39C0EA9E4D306D424F6C66A205ABF47D53B5E);
		String_t* L_158;
		L_158 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_157, /*hidden argument*/NULL);
		V_0 = L_158;
		// }
		goto IL_057c;
	}

IL_0336:
	{
		// nodeStr += baseLine + FormatLineString(
		//     lStr,
		//     GetIndentStr(startNode).Length,
		//     lineLen,
		//     dataStr) + "\r\n";
		String_t* L_159 = V_0;
		String_t* L_160 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_161 = ___startNode0;
		String_t* L_162;
		L_162 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_161, /*hidden argument*/NULL);
		NullCheck(L_162);
		int32_t L_163;
		L_163 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_162, /*hidden argument*/NULL);
		int32_t L_164 = ___lineLen1;
		String_t* L_165 = V_2;
		String_t* L_166;
		L_166 = Asn1Node_FormatLineString_mFD55298C08C9C61F3918378C6973279839645DCA(__this, _stringLiteralC2DD8ADEA00866AFE6382302B25CE5A086DBCEF8, L_163, L_164, L_165, /*hidden argument*/NULL);
		String_t* L_167;
		L_167 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_159, L_160, L_166, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5, /*hidden argument*/NULL);
		V_0 = L_167;
		// break;
		goto IL_057c;
	}

IL_0361:
	{
		// if (data != null && dataLength < 8)
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_168 = __this->get_data_4();
		if (!L_168)
		{
			goto IL_03e3;
		}
	}
	{
		int64_t L_169 = __this->get_dataLength_2();
		if ((((int64_t)L_169) >= ((int64_t)((int64_t)((int64_t)8)))))
		{
			goto IL_03e3;
		}
	}
	{
		// nodeStr += String.Format("{0,6}|{1,6}|{2,7}|{3} {4} : {5}\r\n",
		//     dataOffset,
		//     dataLength,
		//     lengthFieldBytes,
		//     GetIndentStr(startNode),
		//     TagName,
		//     Asn1Util.BytesToLong(data).ToString()
		//     );
		String_t* L_170 = V_0;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_171 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)6);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_172 = L_171;
		int64_t L_173 = __this->get_dataOffset_1();
		int64_t L_174 = L_173;
		RuntimeObject * L_175 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_174);
		NullCheck(L_172);
		ArrayElementTypeCheck (L_172, L_175);
		(L_172)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_175);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_176 = L_172;
		int64_t L_177 = __this->get_dataLength_2();
		int64_t L_178 = L_177;
		RuntimeObject * L_179 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_178);
		NullCheck(L_176);
		ArrayElementTypeCheck (L_176, L_179);
		(L_176)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_179);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_180 = L_176;
		int64_t L_181 = __this->get_lengthFieldBytes_3();
		int64_t L_182 = L_181;
		RuntimeObject * L_183 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_182);
		NullCheck(L_180);
		ArrayElementTypeCheck (L_180, L_183);
		(L_180)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_183);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_184 = L_180;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_185 = ___startNode0;
		String_t* L_186;
		L_186 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_185, /*hidden argument*/NULL);
		NullCheck(L_184);
		ArrayElementTypeCheck (L_184, L_186);
		(L_184)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_186);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_187 = L_184;
		String_t* L_188;
		L_188 = Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C(__this, /*hidden argument*/NULL);
		NullCheck(L_187);
		ArrayElementTypeCheck (L_187, L_188);
		(L_187)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject *)L_188);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_189 = L_187;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_190 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int64_t L_191;
		L_191 = Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7(L_190, /*hidden argument*/NULL);
		V_6 = L_191;
		String_t* L_192;
		L_192 = Int64_ToString_m8AAA883F340993DCDF339C208F3416C3BA82589F((int64_t*)(&V_6), /*hidden argument*/NULL);
		NullCheck(L_189);
		ArrayElementTypeCheck (L_189, L_192);
		(L_189)->SetAt(static_cast<il2cpp_array_size_t>(5), (RuntimeObject *)L_192);
		String_t* L_193;
		L_193 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral9787EA65D34ACB2E800972522D1FB9E8D86E0511, L_189, /*hidden argument*/NULL);
		String_t* L_194;
		L_194 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_170, L_193, /*hidden argument*/NULL);
		V_0 = L_194;
		// }
		goto IL_057c;
	}

IL_03e3:
	{
		// baseLine =
		//     String.Format("{0,6}|{1,6}|{2,7}|{3} {4} : ",
		//     dataOffset,
		//     dataLength,
		//     lengthFieldBytes,
		//     GetIndentStr(startNode),
		//     TagName
		//     );
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_195 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)5);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_196 = L_195;
		int64_t L_197 = __this->get_dataOffset_1();
		int64_t L_198 = L_197;
		RuntimeObject * L_199 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_198);
		NullCheck(L_196);
		ArrayElementTypeCheck (L_196, L_199);
		(L_196)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_199);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_200 = L_196;
		int64_t L_201 = __this->get_dataLength_2();
		int64_t L_202 = L_201;
		RuntimeObject * L_203 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_202);
		NullCheck(L_200);
		ArrayElementTypeCheck (L_200, L_203);
		(L_200)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_203);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_204 = L_200;
		int64_t L_205 = __this->get_lengthFieldBytes_3();
		int64_t L_206 = L_205;
		RuntimeObject * L_207 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_206);
		NullCheck(L_204);
		ArrayElementTypeCheck (L_204, L_207);
		(L_204)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_207);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_208 = L_204;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_209 = ___startNode0;
		String_t* L_210;
		L_210 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_209, /*hidden argument*/NULL);
		NullCheck(L_208);
		ArrayElementTypeCheck (L_208, L_210);
		(L_208)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_210);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_211 = L_208;
		String_t* L_212;
		L_212 = Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C(__this, /*hidden argument*/NULL);
		NullCheck(L_211);
		ArrayElementTypeCheck (L_211, L_212);
		(L_211)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject *)L_212);
		String_t* L_213;
		L_213 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral4202CE17CF8429812DBB3C69FBD0097EC2457F9F, L_211, /*hidden argument*/NULL);
		V_1 = L_213;
		// nodeStr += GetHexPrintingStr(startNode, baseLine, lStr, lineLen);
		String_t* L_214 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_215 = ___startNode0;
		String_t* L_216 = V_1;
		int32_t L_217 = ___lineLen1;
		String_t* L_218;
		L_218 = Asn1Node_GetHexPrintingStr_m0BD9EACAA7BDA5502C4D11C8512E7DF2A65B6F22(__this, L_215, L_216, _stringLiteralC2DD8ADEA00866AFE6382302B25CE5A086DBCEF8, L_217, /*hidden argument*/NULL);
		String_t* L_219;
		L_219 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_214, L_218, /*hidden argument*/NULL);
		V_0 = L_219;
		// break;
		goto IL_057c;
	}

IL_044b:
	{
		// if ((tag & Asn1Tag.TAG_MASK) == 6) // Visible string for certificate
		uint8_t L_220 = __this->get_tag_0();
		if ((!(((uint32_t)((int32_t)((int32_t)L_220&(int32_t)((int32_t)31)))) == ((uint32_t)6))))
		{
			goto IL_0519;
		}
	}
	{
		// baseLine =
		//     String.Format("{0,6}|{1,6}|{2,7}|{3} {4} : ",
		//     dataOffset,
		//     dataLength,
		//     lengthFieldBytes,
		//     GetIndentStr(startNode),
		//     TagName
		//     );
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_221 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)5);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_222 = L_221;
		int64_t L_223 = __this->get_dataOffset_1();
		int64_t L_224 = L_223;
		RuntimeObject * L_225 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_224);
		NullCheck(L_222);
		ArrayElementTypeCheck (L_222, L_225);
		(L_222)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_225);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_226 = L_222;
		int64_t L_227 = __this->get_dataLength_2();
		int64_t L_228 = L_227;
		RuntimeObject * L_229 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_228);
		NullCheck(L_226);
		ArrayElementTypeCheck (L_226, L_229);
		(L_226)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_229);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_230 = L_226;
		int64_t L_231 = __this->get_lengthFieldBytes_3();
		int64_t L_232 = L_231;
		RuntimeObject * L_233 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_232);
		NullCheck(L_230);
		ArrayElementTypeCheck (L_230, L_233);
		(L_230)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_233);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_234 = L_230;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_235 = ___startNode0;
		String_t* L_236;
		L_236 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_235, /*hidden argument*/NULL);
		NullCheck(L_234);
		ArrayElementTypeCheck (L_234, L_236);
		(L_234)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_236);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_237 = L_234;
		String_t* L_238;
		L_238 = Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C(__this, /*hidden argument*/NULL);
		NullCheck(L_237);
		ArrayElementTypeCheck (L_237, L_238);
		(L_237)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject *)L_238);
		String_t* L_239;
		L_239 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral4202CE17CF8429812DBB3C69FBD0097EC2457F9F, L_237, /*hidden argument*/NULL);
		V_1 = L_239;
		// dataStr = Asn1Util.BytesToString(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_240 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_241;
		L_241 = Asn1Util_BytesToString_mA5E3457776D5F5FAF8C7D2850268B8FA9E8CE441(L_240, /*hidden argument*/NULL);
		V_2 = L_241;
		// if (baseLine.Length + dataStr.Length < lineLen)
		String_t* L_242 = V_1;
		NullCheck(L_242);
		int32_t L_243;
		L_243 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_242, /*hidden argument*/NULL);
		String_t* L_244 = V_2;
		NullCheck(L_244);
		int32_t L_245;
		L_245 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_244, /*hidden argument*/NULL);
		int32_t L_246 = ___lineLen1;
		if ((((int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_243, (int32_t)L_245))) >= ((int32_t)L_246)))
		{
			goto IL_04f1;
		}
	}
	{
		// nodeStr += baseLine + "'" + dataStr + "'\r\n";
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_247 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_248 = L_247;
		String_t* L_249 = V_0;
		NullCheck(L_248);
		ArrayElementTypeCheck (L_248, L_249);
		(L_248)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_249);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_250 = L_248;
		String_t* L_251 = V_1;
		NullCheck(L_250);
		ArrayElementTypeCheck (L_250, L_251);
		(L_250)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_251);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_252 = L_250;
		NullCheck(L_252);
		ArrayElementTypeCheck (L_252, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		(L_252)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_253 = L_252;
		String_t* L_254 = V_2;
		NullCheck(L_253);
		ArrayElementTypeCheck (L_253, L_254);
		(L_253)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_254);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_255 = L_253;
		NullCheck(L_255);
		ArrayElementTypeCheck (L_255, _stringLiteral1AC39C0EA9E4D306D424F6C66A205ABF47D53B5E);
		(L_255)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral1AC39C0EA9E4D306D424F6C66A205ABF47D53B5E);
		String_t* L_256;
		L_256 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_255, /*hidden argument*/NULL);
		V_0 = L_256;
		// }
		goto IL_057c;
	}

IL_04f1:
	{
		// nodeStr += baseLine + FormatLineString(
		//     lStr,
		//     GetIndentStr(startNode).Length,
		//     lineLen,
		//     dataStr) + "\r\n";
		String_t* L_257 = V_0;
		String_t* L_258 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_259 = ___startNode0;
		String_t* L_260;
		L_260 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_259, /*hidden argument*/NULL);
		NullCheck(L_260);
		int32_t L_261;
		L_261 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_260, /*hidden argument*/NULL);
		int32_t L_262 = ___lineLen1;
		String_t* L_263 = V_2;
		String_t* L_264;
		L_264 = Asn1Node_FormatLineString_mFD55298C08C9C61F3918378C6973279839645DCA(__this, _stringLiteralC2DD8ADEA00866AFE6382302B25CE5A086DBCEF8, L_261, L_262, L_263, /*hidden argument*/NULL);
		String_t* L_265;
		L_265 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_257, L_258, L_264, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5, /*hidden argument*/NULL);
		V_0 = L_265;
		// }
		goto IL_057c;
	}

IL_0519:
	{
		// baseLine =
		//     String.Format("{0,6}|{1,6}|{2,7}|{3} {4} : ",
		//     dataOffset,
		//     dataLength,
		//     lengthFieldBytes,
		//     GetIndentStr(startNode),
		//     TagName
		//     );
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_266 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)5);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_267 = L_266;
		int64_t L_268 = __this->get_dataOffset_1();
		int64_t L_269 = L_268;
		RuntimeObject * L_270 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_269);
		NullCheck(L_267);
		ArrayElementTypeCheck (L_267, L_270);
		(L_267)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_270);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_271 = L_267;
		int64_t L_272 = __this->get_dataLength_2();
		int64_t L_273 = L_272;
		RuntimeObject * L_274 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_273);
		NullCheck(L_271);
		ArrayElementTypeCheck (L_271, L_274);
		(L_271)->SetAt(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_274);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_275 = L_271;
		int64_t L_276 = __this->get_lengthFieldBytes_3();
		int64_t L_277 = L_276;
		RuntimeObject * L_278 = Box(Int64_t378EE0D608BD3107E77238E85F30D2BBD46981F3_il2cpp_TypeInfo_var, &L_277);
		NullCheck(L_275);
		ArrayElementTypeCheck (L_275, L_278);
		(L_275)->SetAt(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_278);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_279 = L_275;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_280 = ___startNode0;
		String_t* L_281;
		L_281 = Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB(__this, L_280, /*hidden argument*/NULL);
		NullCheck(L_279);
		ArrayElementTypeCheck (L_279, L_281);
		(L_279)->SetAt(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_281);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_282 = L_279;
		String_t* L_283;
		L_283 = Asn1Node_get_TagName_m239036A12640CEF89C8AE0D90E117CEBD083211C(__this, /*hidden argument*/NULL);
		NullCheck(L_282);
		ArrayElementTypeCheck (L_282, L_283);
		(L_282)->SetAt(static_cast<il2cpp_array_size_t>(4), (RuntimeObject *)L_283);
		String_t* L_284;
		L_284 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral4202CE17CF8429812DBB3C69FBD0097EC2457F9F, L_282, /*hidden argument*/NULL);
		V_1 = L_284;
		// nodeStr += GetHexPrintingStr(startNode, baseLine, lStr, lineLen);
		String_t* L_285 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_286 = ___startNode0;
		String_t* L_287 = V_1;
		int32_t L_288 = ___lineLen1;
		String_t* L_289;
		L_289 = Asn1Node_GetHexPrintingStr_m0BD9EACAA7BDA5502C4D11C8512E7DF2A65B6F22(__this, L_286, L_287, _stringLiteralC2DD8ADEA00866AFE6382302B25CE5A086DBCEF8, L_288, /*hidden argument*/NULL);
		String_t* L_290;
		L_290 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_285, L_289, /*hidden argument*/NULL);
		V_0 = L_290;
	}

IL_057c:
	{
		// if (childNodeList.Count >= 0)
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_291 = __this->get_childNodeList_5();
		NullCheck(L_291);
		int32_t L_292;
		L_292 = VirtFuncInvoker0< int32_t >::Invoke(23 /* System.Int32 System.Collections.ArrayList::get_Count() */, L_291);
		if ((((int32_t)L_292) < ((int32_t)0)))
		{
			goto IL_0599;
		}
	}
	{
		// nodeStr += GetListStr(startNode, lineLen);
		String_t* L_293 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_294 = ___startNode0;
		int32_t L_295 = ___lineLen1;
		String_t* L_296;
		L_296 = Asn1Node_GetListStr_m982D22756C098CBED892C9C34A54E56A14614DA4(__this, L_294, L_295, /*hidden argument*/NULL);
		String_t* L_297;
		L_297 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_293, L_296, /*hidden argument*/NULL);
		V_0 = L_297;
	}

IL_0599:
	{
		// return nodeStr;
		String_t* L_298 = V_0;
		return L_298;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetDataStr(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetDataStr_mF4A8F71F0C9F5ECB82E4981090F142D59965CAD1 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, bool ___pureHexMode0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RelativeOid_t97392E06363F6AFF26543502032B89445860F72A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	uint8_t V_1 = 0x0;
	{
		// string dataStr = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// if (pureHexMode)
		bool L_0 = ___pureHexMode0;
		if (!L_0)
		{
			goto IL_0022;
		}
	}
	{
		// dataStr = Asn1Util.FormatString(Asn1Util.ToHexString(data), lineLen, 2);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_1 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_2;
		L_2 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_1, /*hidden argument*/NULL);
		String_t* L_3;
		L_3 = Asn1Util_FormatString_m7588BDA18A9BC660061BAC73AB79DD458DF589F9(L_2, ((int32_t)32), 2, /*hidden argument*/NULL);
		V_0 = L_3;
		// }
		goto IL_014d;
	}

IL_0022:
	{
		// switch (tag)
		uint8_t L_4 = __this->get_tag_0();
		V_1 = L_4;
		uint8_t L_5 = V_1;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_5, (int32_t)2)))
		{
			case 0:
			{
				goto IL_0109;
			}
			case 1:
			{
				goto IL_009f;
			}
			case 2:
			{
				goto IL_011f;
			}
			case 3:
			{
				goto IL_011f;
			}
			case 4:
			{
				goto IL_00b8;
			}
		}
	}
	{
		uint8_t L_6 = V_1;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_6, (int32_t)((int32_t)12))))
		{
			case 0:
			{
				goto IL_00f6;
			}
			case 1:
			{
				goto IL_00d0;
			}
			case 2:
			{
				goto IL_011f;
			}
			case 3:
			{
				goto IL_011f;
			}
			case 4:
			{
				goto IL_011f;
			}
			case 5:
			{
				goto IL_011f;
			}
			case 6:
			{
				goto IL_00e8;
			}
			case 7:
			{
				goto IL_00e8;
			}
			case 8:
			{
				goto IL_011f;
			}
			case 9:
			{
				goto IL_011f;
			}
			case 10:
			{
				goto IL_00e8;
			}
			case 11:
			{
				goto IL_00e8;
			}
			case 12:
			{
				goto IL_00e8;
			}
			case 13:
			{
				goto IL_011f;
			}
			case 14:
			{
				goto IL_00e8;
			}
			case 15:
			{
				goto IL_00e8;
			}
			case 16:
			{
				goto IL_00e8;
			}
			case 17:
			{
				goto IL_011f;
			}
			case 18:
			{
				goto IL_00e8;
			}
		}
	}
	{
		goto IL_011f;
	}

IL_009f:
	{
		// dataStr = Asn1Util.FormatString(Asn1Util.ToHexString(data), lineLen, 2);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_7 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_8;
		L_8 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_7, /*hidden argument*/NULL);
		String_t* L_9;
		L_9 = Asn1Util_FormatString_m7588BDA18A9BC660061BAC73AB79DD458DF589F9(L_8, ((int32_t)32), 2, /*hidden argument*/NULL);
		V_0 = L_9;
		// break;
		goto IL_014d;
	}

IL_00b8:
	{
		// Oid xoid = new Oid();
		Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * L_10 = (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D *)il2cpp_codegen_object_new(Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var);
		Oid__ctor_m5F73190FA2302798601F2B61863F12363DF5E843(L_10, /*hidden argument*/NULL);
		// dataStr = xoid.Decode(new MemoryStream(data));
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_11 = __this->get_data_4();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_12 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2(L_12, L_11, /*hidden argument*/NULL);
		NullCheck(L_10);
		String_t* L_13;
		L_13 = VirtFuncInvoker1< String_t*, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * >::Invoke(4 /* System.String LipingShare.LCLib.Asn1Processor.Oid::Decode(System.IO.Stream) */, L_10, L_12);
		V_0 = L_13;
		// break;
		goto IL_014d;
	}

IL_00d0:
	{
		// RelativeOid roid = new RelativeOid();
		RelativeOid_t97392E06363F6AFF26543502032B89445860F72A * L_14 = (RelativeOid_t97392E06363F6AFF26543502032B89445860F72A *)il2cpp_codegen_object_new(RelativeOid_t97392E06363F6AFF26543502032B89445860F72A_il2cpp_TypeInfo_var);
		RelativeOid__ctor_m1DD6406191F78BC9BAAC9FD71BAF4AFC9372A6C8(L_14, /*hidden argument*/NULL);
		// dataStr = roid.Decode(new MemoryStream(data));
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_15 = __this->get_data_4();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_16 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2(L_16, L_15, /*hidden argument*/NULL);
		NullCheck(L_14);
		String_t* L_17;
		L_17 = VirtFuncInvoker1< String_t*, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * >::Invoke(4 /* System.String LipingShare.LCLib.Asn1Processor.Oid::Decode(System.IO.Stream) */, L_14, L_16);
		V_0 = L_17;
		// break;
		goto IL_014d;
	}

IL_00e8:
	{
		// dataStr = Asn1Util.BytesToString(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_18 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_19;
		L_19 = Asn1Util_BytesToString_mA5E3457776D5F5FAF8C7D2850268B8FA9E8CE441(L_18, /*hidden argument*/NULL);
		V_0 = L_19;
		// break;
		goto IL_014d;
	}

IL_00f6:
	{
		// UTF8Encoding utf8 = new UTF8Encoding();
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_20 = (UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 *)il2cpp_codegen_object_new(UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		UTF8Encoding__ctor_mA3F21D41B65D155202345802A05761A4BC022888(L_20, /*hidden argument*/NULL);
		// dataStr = utf8.GetString(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_21 = __this->get_data_4();
		NullCheck(L_20);
		String_t* L_22;
		L_22 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_20, L_21);
		V_0 = L_22;
		// break;
		goto IL_014d;
	}

IL_0109:
	{
		// dataStr = Asn1Util.FormatString(Asn1Util.ToHexString(data), lineLen, 2);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_24;
		L_24 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_23, /*hidden argument*/NULL);
		String_t* L_25;
		L_25 = Asn1Util_FormatString_m7588BDA18A9BC660061BAC73AB79DD458DF589F9(L_24, ((int32_t)32), 2, /*hidden argument*/NULL);
		V_0 = L_25;
		// break;
		goto IL_014d;
	}

IL_011f:
	{
		// if ((tag & Asn1Tag.TAG_MASK) == 6) // Visible string for certificate
		uint8_t L_26 = __this->get_tag_0();
		if ((!(((uint32_t)((int32_t)((int32_t)L_26&(int32_t)((int32_t)31)))) == ((uint32_t)6))))
		{
			goto IL_0139;
		}
	}
	{
		// dataStr = Asn1Util.BytesToString(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_27 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_28;
		L_28 = Asn1Util_BytesToString_mA5E3457776D5F5FAF8C7D2850268B8FA9E8CE441(L_27, /*hidden argument*/NULL);
		V_0 = L_28;
		// }
		goto IL_014d;
	}

IL_0139:
	{
		// dataStr = Asn1Util.FormatString(Asn1Util.ToHexString(data), lineLen, 2);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_29 = __this->get_data_4();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_30;
		L_30 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_29, /*hidden argument*/NULL);
		String_t* L_31;
		L_31 = Asn1Util_FormatString_m7588BDA18A9BC660061BAC73AB79DD458DF589F9(L_30, ((int32_t)32), 2, /*hidden argument*/NULL);
		V_0 = L_31;
	}

IL_014d:
	{
		// return dataStr;
		String_t* L_32 = V_0;
		return L_32;
	}
}
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::get_DataLength()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_get_DataLength_mCF41384470AB94796BC81FCA252C18AB3513BBD8 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return dataLength;
		int64_t L_0 = __this->get_dataLength_2();
		return L_0;
	}
}
// System.Byte[] LipingShare.LCLib.Asn1Processor.Asn1Node::get_Data()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * V_0 = NULL;
	int64_t V_1 = 0;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_2 = NULL;
	int32_t V_3 = 0;
	{
		// MemoryStream xdata = new MemoryStream();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_0 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_mD27B3DF2400D46A4A81EE78B0BD2C29EFCFAA44F(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		// long nodeCount = ChildNodeCount;
		int64_t L_1;
		L_1 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(__this, /*hidden argument*/NULL);
		V_1 = L_1;
		// if (nodeCount == 0)
		int64_t L_2 = V_1;
		if (L_2)
		{
			goto IL_002f;
		}
	}
	{
		// if (data != null)
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_3 = __this->get_data_4();
		if (!L_3)
		{
			goto IL_004a;
		}
	}
	{
		// xdata.Write(data, 0, data.Length);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_4 = V_0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_5 = __this->get_data_4();
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_6 = __this->get_data_4();
		NullCheck(L_6);
		NullCheck(L_4);
		VirtActionInvoker3< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(36 /* System.Void System.IO.Stream::Write(System.Byte[],System.Int32,System.Int32) */, L_4, L_5, 0, ((int32_t)((int32_t)(((RuntimeArray*)L_6)->max_length))));
		// }
		goto IL_004a;
	}

IL_002f:
	{
		// for (int i = 0; i < nodeCount; i++)
		V_3 = 0;
		goto IL_0045;
	}

IL_0033:
	{
		// tempNode = GetChildNode(i);
		int32_t L_7 = V_3;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8;
		L_8 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(__this, L_7, /*hidden argument*/NULL);
		// tempNode.SaveData(xdata);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_9 = V_0;
		NullCheck(L_8);
		bool L_10;
		L_10 = Asn1Node_SaveData_m5130FD25C319C413AE8F113454C33DA32072191E(L_8, L_9, /*hidden argument*/NULL);
		// for (int i = 0; i < nodeCount; i++)
		int32_t L_11 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_11, (int32_t)1));
	}

IL_0045:
	{
		// for (int i = 0; i < nodeCount; i++)
		int32_t L_12 = V_3;
		int64_t L_13 = V_1;
		if ((((int64_t)((int64_t)((int64_t)L_12))) < ((int64_t)L_13)))
		{
			goto IL_0033;
		}
	}

IL_004a:
	{
		// byte[] tmpData = new byte[xdata.Length];
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_14 = V_0;
		NullCheck(L_14);
		int64_t L_15;
		L_15 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_14);
		if ((int64_t)(L_15) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F_RuntimeMethod_var);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_16 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)L_15));
		V_2 = L_16;
		// xdata.Position = 0;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_17 = V_0;
		NullCheck(L_17);
		VirtActionInvoker1< int64_t >::Invoke(14 /* System.Void System.IO.Stream::set_Position(System.Int64) */, L_17, ((int64_t)((int64_t)0)));
		// xdata.Read(tmpData, 0, (int)xdata.Length);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_18 = V_0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_19 = V_2;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_20 = V_0;
		NullCheck(L_20);
		int64_t L_21;
		L_21 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_20);
		NullCheck(L_18);
		int32_t L_22;
		L_22 = VirtFuncInvoker3< int32_t, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(34 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_18, L_19, 0, ((int32_t)((int32_t)L_21)));
		// xdata.Close();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_23 = V_0;
		NullCheck(L_23);
		VirtActionInvoker0::Invoke(21 /* System.Void System.IO.Stream::Close() */, L_23);
		// return tmpData;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_24 = V_2;
		return L_24;
	}
}
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::get_Deepness()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_get_Deepness_m2ED875AFAB0B74DC5A8622DB3B3D18C4B7F6E95F (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return deepness;
		int64_t L_0 = __this->get_deepness_7();
		return L_0;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::set_RequireRecalculatePar(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_set_RequireRecalculatePar_m39322AC2FD6FC053F6E61C5665C0898C7E52C21F (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// requireRecalculatePar = value;
		bool L_0 = ___value0;
		__this->set_requireRecalculatePar_10(L_0);
		// }
		return;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::RecalculateTreePar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_RecalculateTreePar_m6437576AC8919D0347737FDE2EB8AA7B4FDDAA97 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_0 = NULL;
	int64_t V_1 = 0;
	{
		// if (!requireRecalculatePar) return;
		bool L_0 = __this->get_requireRecalculatePar_10();
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// if (!requireRecalculatePar) return;
		return;
	}

IL_0009:
	{
		// for (rootNode = this; rootNode.ParentNode != null;)
		V_0 = __this;
		goto IL_0014;
	}

IL_000d:
	{
		// rootNode = rootNode.ParentNode;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1 = V_0;
		NullCheck(L_1);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2;
		L_2 = Asn1Node_get_ParentNode_mB1CB94F695AF71514E30EFEA66AD34AF626D2E44_inline(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
	}

IL_0014:
	{
		// for (rootNode = this; rootNode.ParentNode != null;)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_3 = V_0;
		NullCheck(L_3);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4;
		L_4 = Asn1Node_get_ParentNode_mB1CB94F695AF71514E30EFEA66AD34AF626D2E44_inline(L_3, /*hidden argument*/NULL);
		if (L_4)
		{
			goto IL_000d;
		}
	}
	{
		// ResetBranchDataLength(rootNode);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5 = V_0;
		int64_t L_6;
		L_6 = Asn1Node_ResetBranchDataLength_m8E5348C849E7F7595944DB99E079F2421066D9EF(L_5, /*hidden argument*/NULL);
		// rootNode.dataOffset = 0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_7 = V_0;
		NullCheck(L_7);
		L_7->set_dataOffset_1(((int64_t)((int64_t)0)));
		// rootNode.deepness = 0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8 = V_0;
		NullCheck(L_8);
		L_8->set_deepness_7(((int64_t)((int64_t)0)));
		// long subOffset = rootNode.dataOffset + TagLength + rootNode.lengthFieldBytes;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_9 = V_0;
		NullCheck(L_9);
		int64_t L_10 = L_9->get_dataOffset_1();
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_11 = V_0;
		NullCheck(L_11);
		int64_t L_12 = L_11->get_lengthFieldBytes_3();
		V_1 = ((int64_t)il2cpp_codegen_add((int64_t)((int64_t)il2cpp_codegen_add((int64_t)L_10, (int64_t)((int64_t)((int64_t)1)))), (int64_t)L_12));
		// ResetChildNodePar(rootNode, subOffset);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_13 = V_0;
		int64_t L_14 = V_1;
		Asn1Node_ResetChildNodePar_m85706CEC5D1ABE7DC9C317B03D5E6133DD77BA60(__this, L_13, L_14, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::ResetBranchDataLength(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_ResetBranchDataLength_m8E5348C849E7F7595944DB99E079F2421066D9EF (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, const RuntimeMethod* method)
{
	int64_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// long childDataLength = 0;
		V_0 = ((int64_t)((int64_t)0));
		// if (node.ChildNodeCount < 1)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___node0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_0, /*hidden argument*/NULL);
		if ((((int64_t)L_1) >= ((int64_t)((int64_t)((int64_t)1)))))
		{
			goto IL_0023;
		}
	}
	{
		// if (node.data != null)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = ___node0;
		NullCheck(L_2);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_3 = L_2->get_data_4();
		if (!L_3)
		{
			goto IL_0044;
		}
	}
	{
		// childDataLength += node.data.Length;
		int64_t L_4 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5 = ___node0;
		NullCheck(L_5);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_6 = L_5->get_data_4();
		NullCheck(L_6);
		V_0 = ((int64_t)il2cpp_codegen_add((int64_t)L_4, (int64_t)((int64_t)((int64_t)((int32_t)((int32_t)(((RuntimeArray*)L_6)->max_length)))))));
		// }
		goto IL_0044;
	}

IL_0023:
	{
		// for (int i = 0; i < node.ChildNodeCount; i++)
		V_1 = 0;
		goto IL_003a;
	}

IL_0027:
	{
		// childDataLength += ResetBranchDataLength(node.GetChildNode(i));
		int64_t L_7 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8 = ___node0;
		int32_t L_9 = V_1;
		NullCheck(L_8);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_10;
		L_10 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_8, L_9, /*hidden argument*/NULL);
		int64_t L_11;
		L_11 = Asn1Node_ResetBranchDataLength_m8E5348C849E7F7595944DB99E079F2421066D9EF(L_10, /*hidden argument*/NULL);
		V_0 = ((int64_t)il2cpp_codegen_add((int64_t)L_7, (int64_t)L_11));
		// for (int i = 0; i < node.ChildNodeCount; i++)
		int32_t L_12 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_003a:
	{
		// for (int i = 0; i < node.ChildNodeCount; i++)
		int32_t L_13 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_14 = ___node0;
		NullCheck(L_14);
		int64_t L_15;
		L_15 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_14, /*hidden argument*/NULL);
		if ((((int64_t)((int64_t)((int64_t)L_13))) < ((int64_t)L_15)))
		{
			goto IL_0027;
		}
	}

IL_0044:
	{
		// node.dataLength = childDataLength;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_16 = ___node0;
		int64_t L_17 = V_0;
		NullCheck(L_16);
		L_16->set_dataLength_2(L_17);
		// if (node.tag == Asn1Tag.BIT_STRING)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_18 = ___node0;
		NullCheck(L_18);
		uint8_t L_19 = L_18->get_tag_0();
		if ((!(((uint32_t)L_19) == ((uint32_t)3))))
		{
			goto IL_0063;
		}
	}
	{
		// node.dataLength += BitStringUnusedFiledLength;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_20 = ___node0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_21 = L_20;
		NullCheck(L_21);
		int64_t L_22 = L_21->get_dataLength_2();
		NullCheck(L_21);
		L_21->set_dataLength_2(((int64_t)il2cpp_codegen_add((int64_t)L_22, (int64_t)((int64_t)((int64_t)1)))));
	}

IL_0063:
	{
		// ResetDataLengthFieldWidth(node);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_23 = ___node0;
		Asn1Node_ResetDataLengthFieldWidth_m843C075C52989FEF803C622B1EF8317DCAD4BDE0(L_23, /*hidden argument*/NULL);
		// retval = node.dataLength + TagLength + node.lengthFieldBytes;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_24 = ___node0;
		NullCheck(L_24);
		int64_t L_25 = L_24->get_dataLength_2();
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_26 = ___node0;
		NullCheck(L_26);
		int64_t L_27 = L_26->get_lengthFieldBytes_3();
		// return retval;
		return ((int64_t)il2cpp_codegen_add((int64_t)((int64_t)il2cpp_codegen_add((int64_t)L_25, (int64_t)((int64_t)((int64_t)1)))), (int64_t)L_27));
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ResetDataLengthFieldWidth(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ResetDataLengthFieldWidth_m843C075C52989FEF803C622B1EF8317DCAD4BDE0 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * V_0 = NULL;
	{
		// MemoryStream tempStream = new MemoryStream();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_0 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_mD27B3DF2400D46A4A81EE78B0BD2C29EFCFAA44F(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		// Asn1Util.DERLengthEncode(tempStream, (ulong)node.dataLength);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_1 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = ___node0;
		NullCheck(L_2);
		int64_t L_3 = L_2->get_dataLength_2();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int32_t L_4;
		L_4 = Asn1Util_DERLengthEncode_mAB5A1E98AC3EF600B339FE181ADF620BBB2DF2FD(L_1, L_3, /*hidden argument*/NULL);
		// node.lengthFieldBytes = tempStream.Length;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5 = ___node0;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_6 = V_0;
		NullCheck(L_6);
		int64_t L_7;
		L_7 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_6);
		NullCheck(L_5);
		L_5->set_lengthFieldBytes_3(L_7);
		// tempStream.Close();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_8 = V_0;
		NullCheck(L_8);
		VirtActionInvoker0::Invoke(21 /* System.Void System.IO.Stream::Close() */, L_8);
		// }
		return;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ResetChildNodePar(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ResetChildNodePar_m85706CEC5D1ABE7DC9C317B03D5E6133DD77BA60 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___xNode0, int64_t ___subOffset1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_1 = NULL;
	{
		// if (xNode.tag == Asn1Tag.BIT_STRING)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___xNode0;
		NullCheck(L_0);
		uint8_t L_1 = L_0->get_tag_0();
		if ((!(((uint32_t)L_1) == ((uint32_t)3))))
		{
			goto IL_000f;
		}
	}
	{
		// subOffset++;
		int64_t L_2 = ___subOffset1;
		___subOffset1 = ((int64_t)il2cpp_codegen_add((int64_t)L_2, (int64_t)((int64_t)((int64_t)1))));
	}

IL_000f:
	{
		// for (i = 0; i < xNode.ChildNodeCount; i++)
		V_0 = 0;
		goto IL_0078;
	}

IL_0013:
	{
		// tempNode = xNode.GetChildNode(i);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_3 = ___xNode0;
		int32_t L_4 = V_0;
		NullCheck(L_3);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5;
		L_5 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_3, L_4, /*hidden argument*/NULL);
		V_1 = L_5;
		// tempNode.parentNode = xNode;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_6 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_7 = ___xNode0;
		NullCheck(L_6);
		L_6->set_parentNode_9(L_7);
		// tempNode.dataOffset = subOffset;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8 = V_1;
		int64_t L_9 = ___subOffset1;
		NullCheck(L_8);
		L_8->set_dataOffset_1(L_9);
		// tempNode.deepness = xNode.deepness + 1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_10 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_11 = ___xNode0;
		NullCheck(L_11);
		int64_t L_12 = L_11->get_deepness_7();
		NullCheck(L_10);
		L_10->set_deepness_7(((int64_t)il2cpp_codegen_add((int64_t)L_12, (int64_t)((int64_t)((int64_t)1)))));
		// tempNode.path = xNode.path + '/' + i.ToString();
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_13 = V_1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_14 = ___xNode0;
		NullCheck(L_14);
		String_t* L_15 = L_14->get_path_8();
		String_t* L_16;
		L_16 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_0), /*hidden argument*/NULL);
		String_t* L_17;
		L_17 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_15, _stringLiteral86BBAACC00198DBB3046818AD3FC2AA10AE48DE1, L_16, /*hidden argument*/NULL);
		NullCheck(L_13);
		L_13->set_path_8(L_17);
		// subOffset += TagLength + tempNode.lengthFieldBytes;
		int64_t L_18 = ___subOffset1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_19 = V_1;
		NullCheck(L_19);
		int64_t L_20 = L_19->get_lengthFieldBytes_3();
		___subOffset1 = ((int64_t)il2cpp_codegen_add((int64_t)L_18, (int64_t)((int64_t)il2cpp_codegen_add((int64_t)((int64_t)((int64_t)1)), (int64_t)L_20))));
		// ResetChildNodePar(tempNode, subOffset);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_21 = V_1;
		int64_t L_22 = ___subOffset1;
		Asn1Node_ResetChildNodePar_m85706CEC5D1ABE7DC9C317B03D5E6133DD77BA60(__this, L_21, L_22, /*hidden argument*/NULL);
		// subOffset += tempNode.dataLength;
		int64_t L_23 = ___subOffset1;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_24 = V_1;
		NullCheck(L_24);
		int64_t L_25 = L_24->get_dataLength_2();
		___subOffset1 = ((int64_t)il2cpp_codegen_add((int64_t)L_23, (int64_t)L_25));
		// for (i = 0; i < xNode.ChildNodeCount; i++)
		int32_t L_26 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_26, (int32_t)1));
	}

IL_0078:
	{
		// for (i = 0; i < xNode.ChildNodeCount; i++)
		int32_t L_27 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_28 = ___xNode0;
		NullCheck(L_28);
		int64_t L_29;
		L_29 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_28, /*hidden argument*/NULL);
		if ((((int64_t)((int64_t)((int64_t)L_27))) < ((int64_t)L_29)))
		{
			goto IL_0013;
		}
	}
	{
		// }
		return;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetListStr(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetListStr_m982D22756C098CBED892C9C34A54E56A14614DA4 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___startNode0, int32_t ___lineLen1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	int32_t V_1 = 0;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_2 = NULL;
	{
		// string nodeStr = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// for (i = 0; i < childNodeList.Count; i++)
		V_1 = 0;
		goto IL_002f;
	}

IL_000a:
	{
		// tempNode = (Asn1Node)childNodeList[i];
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_0 = __this->get_childNodeList_5();
		int32_t L_1 = V_1;
		NullCheck(L_0);
		RuntimeObject * L_2;
		L_2 = VirtFuncInvoker1< RuntimeObject *, int32_t >::Invoke(28 /* System.Object System.Collections.ArrayList::get_Item(System.Int32) */, L_0, L_1);
		V_2 = ((Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)CastclassClass((RuntimeObject*)L_2, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var));
		// nodeStr += tempNode.GetText(startNode, lineLen);
		String_t* L_3 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4 = V_2;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5 = ___startNode0;
		int32_t L_6 = ___lineLen1;
		NullCheck(L_4);
		String_t* L_7;
		L_7 = Asn1Node_GetText_m08AD0406E4330E7F0B546A1C8AA67D2B88F77B72(L_4, L_5, L_6, /*hidden argument*/NULL);
		String_t* L_8;
		L_8 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_3, L_7, /*hidden argument*/NULL);
		V_0 = L_8;
		// for (i = 0; i < childNodeList.Count; i++)
		int32_t L_9 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_9, (int32_t)1));
	}

IL_002f:
	{
		// for (i = 0; i < childNodeList.Count; i++)
		int32_t L_10 = V_1;
		ArrayList_t6C1A49839DC1F0D568E8E11FA1626FCF0EC06575 * L_11 = __this->get_childNodeList_5();
		NullCheck(L_11);
		int32_t L_12;
		L_12 = VirtFuncInvoker0< int32_t >::Invoke(23 /* System.Int32 System.Collections.ArrayList::get_Count() */, L_11);
		if ((((int32_t)L_10) < ((int32_t)L_12)))
		{
			goto IL_000a;
		}
	}
	{
		// return nodeStr;
		String_t* L_13 = V_0;
		return L_13;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Node::GetIndentStr(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Node_GetIndentStr_m8300CAB914F766E20106AFFFB68B2680D813EBDB (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___startNode0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral17F69BD9415AEEFF5AF120DF2D45F20433804764);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	int64_t V_1 = 0;
	int64_t V_2 = 0;
	{
		// string retval = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// long startLen = 0;
		V_1 = ((int64_t)((int64_t)0));
		// if (startNode != null)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___startNode0;
		if (!L_0)
		{
			goto IL_0013;
		}
	}
	{
		// startLen = startNode.Deepness;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1 = ___startNode0;
		NullCheck(L_1);
		int64_t L_2;
		L_2 = Asn1Node_get_Deepness_m2ED875AFAB0B74DC5A8622DB3B3D18C4B7F6E95F_inline(L_1, /*hidden argument*/NULL);
		V_1 = L_2;
	}

IL_0013:
	{
		// for (long i = 0; i < deepness - startLen; i++)
		V_2 = ((int64_t)((int64_t)0));
		goto IL_0029;
	}

IL_0018:
	{
		// retval += "   ";
		String_t* L_3 = V_0;
		String_t* L_4;
		L_4 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_3, _stringLiteral17F69BD9415AEEFF5AF120DF2D45F20433804764, /*hidden argument*/NULL);
		V_0 = L_4;
		// for (long i = 0; i < deepness - startLen; i++)
		int64_t L_5 = V_2;
		V_2 = ((int64_t)il2cpp_codegen_add((int64_t)L_5, (int64_t)((int64_t)((int64_t)1))));
	}

IL_0029:
	{
		// for (long i = 0; i < deepness - startLen; i++)
		int64_t L_6 = V_2;
		int64_t L_7 = __this->get_deepness_7();
		int64_t L_8 = V_1;
		if ((((int64_t)L_6) < ((int64_t)((int64_t)il2cpp_codegen_subtract((int64_t)L_7, (int64_t)L_8)))))
		{
			goto IL_0018;
		}
	}
	{
		// return retval;
		String_t* L_9 = V_0;
		return L_9;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::GeneralDecode(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_GeneralDecode_m0CF76CE74470A9631179746CBE8AEEA09C7BE56B (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int64_t V_0 = 0;
	int64_t V_1 = 0;
	{
		// long nodeMaxLen = xdata.Length - xdata.Position;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_0);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = ___xdata0;
		NullCheck(L_2);
		int64_t L_3;
		L_3 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_2);
		V_0 = ((int64_t)il2cpp_codegen_subtract((int64_t)L_1, (int64_t)L_3));
		// tag = (byte)xdata.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___xdata0;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_4);
		__this->set_tag_0((uint8_t)((int32_t)((uint8_t)L_5)));
		// long start = xdata.Position;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_6 = ___xdata0;
		NullCheck(L_6);
		int64_t L_7;
		L_7 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_6);
		V_1 = L_7;
		// dataLength = Asn1Util.DerLengthDecode(xdata, ref isIndefiniteLength);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_8 = ___xdata0;
		bool* L_9 = __this->get_address_of_isIndefiniteLength_11();
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int64_t L_10;
		L_10 = Asn1Util_DerLengthDecode_m09878729C7733370A7423F2FD7CF97ECE86F58F9(L_8, (bool*)L_9, /*hidden argument*/NULL);
		__this->set_dataLength_2(L_10);
		// if (AreTagsOk())
		bool L_11;
		L_11 = Asn1Node_AreTagsOk_m5CFAE2F617BD9F1F3B8536A73AEC04997F239236(__this, /*hidden argument*/NULL);
		if (!L_11)
		{
			goto IL_005a;
		}
	}
	{
		// if (isIndefiniteLength)
		bool L_12 = __this->get_isIndefiniteLength_11();
		if (!L_12)
		{
			goto IL_0050;
		}
	}
	{
		// return GeneralDecodeIndefiniteLength(xdata, nodeMaxLen - k_IndefiniteLengthFooterSize);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_13 = ___xdata0;
		int64_t L_14 = V_0;
		bool L_15;
		L_15 = Asn1Node_GeneralDecodeIndefiniteLength_mCA0402F12B5F298CF866EAD1FDCB4975631E0A0E(__this, L_13, ((int64_t)il2cpp_codegen_subtract((int64_t)L_14, (int64_t)((int64_t)((int64_t)2)))), /*hidden argument*/NULL);
		return L_15;
	}

IL_0050:
	{
		// return GeneralDecodeKnownLengthWithChecks(xdata, start, nodeMaxLen);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_16 = ___xdata0;
		int64_t L_17 = V_1;
		int64_t L_18 = V_0;
		bool L_19;
		L_19 = Asn1Node_GeneralDecodeKnownLengthWithChecks_mEFE1C220D68654A2977591E537E0FDE3904401E5(__this, L_16, L_17, L_18, /*hidden argument*/NULL);
		return L_19;
	}

IL_005a:
	{
		// return false;
		return (bool)0;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::AreTagsOk()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_AreTagsOk_m5CFAE2F617BD9F1F3B8536A73AEC04997F239236 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// if (ParentNode == null || ((ParentNode.tag & Asn1TagClasses.CONSTRUCTED) == 0))
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0;
		L_0 = Asn1Node_get_ParentNode_mB1CB94F695AF71514E30EFEA66AD34AF626D2E44_inline(__this, /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_0018;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1;
		L_1 = Asn1Node_get_ParentNode_mB1CB94F695AF71514E30EFEA66AD34AF626D2E44_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_1);
		uint8_t L_2 = L_1->get_tag_0();
		if (((int32_t)((int32_t)L_2&(int32_t)((int32_t)32))))
		{
			goto IL_0033;
		}
	}

IL_0018:
	{
		// if ((tag & Asn1Tag.TAG_MASK) <= 0 || (tag & Asn1Tag.TAG_MASK) > 0x1E)
		uint8_t L_3 = __this->get_tag_0();
		if ((((int32_t)((int32_t)((int32_t)L_3&(int32_t)((int32_t)31)))) <= ((int32_t)0)))
		{
			goto IL_0031;
		}
	}
	{
		uint8_t L_4 = __this->get_tag_0();
		if ((((int32_t)((int32_t)((int32_t)L_4&(int32_t)((int32_t)31)))) <= ((int32_t)((int32_t)30))))
		{
			goto IL_0033;
		}
	}

IL_0031:
	{
		// return false;
		return (bool)0;
	}

IL_0033:
	{
		// return true;
		return (bool)1;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::GeneralDecodeKnownLengthWithChecks(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_GeneralDecodeKnownLengthWithChecks_mEFE1C220D68654A2977591E537E0FDE3904401E5 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, int64_t ___nodeMaxLen2, const RuntimeMethod* method)
{
	{
		// if (IsGeneralStreamLengthOk(xdata, start, nodeMaxLen))
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		int64_t L_1 = ___start1;
		int64_t L_2 = ___nodeMaxLen2;
		bool L_3;
		L_3 = Asn1Node_IsGeneralStreamLengthOk_mD8EDC30F136815F4F649056A87C054724EE7FF50(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0013;
		}
	}
	{
		// return GeneralDecodeKnownLength(xdata);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___xdata0;
		bool L_5;
		L_5 = Asn1Node_GeneralDecodeKnownLength_m694C84876BC67B6B9262F83CD57604CDB0E4A74C(__this, L_4, /*hidden argument*/NULL);
		return L_5;
	}

IL_0013:
	{
		// return false;
		return (bool)0;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::IsGeneralStreamLengthOk(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_IsGeneralStreamLengthOk_mD8EDC30F136815F4F649056A87C054724EE7FF50 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, int64_t ___nodeMaxLen2, const RuntimeMethod* method)
{
	{
		// if (dataLength >= 0)
		int64_t L_0 = __this->get_dataLength_2();
		if ((((int64_t)L_0) < ((int64_t)((int64_t)((int64_t)0)))))
		{
			goto IL_002d;
		}
	}
	{
		// lengthFieldBytes = xdata.Position - start;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = ___xdata0;
		NullCheck(L_1);
		int64_t L_2;
		L_2 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_1);
		int64_t L_3 = ___start1;
		__this->set_lengthFieldBytes_3(((int64_t)il2cpp_codegen_subtract((int64_t)L_2, (int64_t)L_3)));
		// if (nodeMaxLen >= (dataLength + TagLength + lengthFieldBytes))
		int64_t L_4 = ___nodeMaxLen2;
		int64_t L_5 = __this->get_dataLength_2();
		int64_t L_6 = __this->get_lengthFieldBytes_3();
		if ((((int64_t)L_4) < ((int64_t)((int64_t)il2cpp_codegen_add((int64_t)((int64_t)il2cpp_codegen_add((int64_t)L_5, (int64_t)((int64_t)((int64_t)1)))), (int64_t)L_6)))))
		{
			goto IL_002d;
		}
	}
	{
		// return true;
		return (bool)1;
	}

IL_002d:
	{
		// return false;
		return (bool)0;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::GeneralDecodeKnownLength(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_GeneralDecodeKnownLength_m694C84876BC67B6B9262F83CD57604CDB0E4A74C (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	{
		// if (tag == Asn1Tag.BIT_STRING)
		uint8_t L_0 = __this->get_tag_0();
		if ((!(((uint32_t)L_0) == ((uint32_t)3))))
		{
			goto IL_0035;
		}
	}
	{
		// if (dataLength < 1)
		int64_t L_1 = __this->get_dataLength_2();
		if ((((int64_t)L_1) >= ((int64_t)((int64_t)((int64_t)1)))))
		{
			goto IL_0015;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0015:
	{
		// unusedBits = (byte)xdata.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = ___xdata0;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_2);
		__this->set_unusedBits_6((uint8_t)((int32_t)((uint8_t)L_3)));
		// ReadStreamDataDefiniteLength(xdata, (int)(dataLength - 1));
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___xdata0;
		int64_t L_5 = __this->get_dataLength_2();
		Asn1Node_ReadStreamDataDefiniteLength_m7FE22AB1DEA1AF258E8ABB3FB36DEC5963A96269(__this, L_4, ((int32_t)((int32_t)((int64_t)il2cpp_codegen_subtract((int64_t)L_5, (int64_t)((int64_t)((int64_t)1)))))), /*hidden argument*/NULL);
		// }
		goto IL_0043;
	}

IL_0035:
	{
		// ReadStreamDataDefiniteLength(xdata, (int)(dataLength));
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_6 = ___xdata0;
		int64_t L_7 = __this->get_dataLength_2();
		Asn1Node_ReadStreamDataDefiniteLength_m7FE22AB1DEA1AF258E8ABB3FB36DEC5963A96269(__this, L_6, ((int32_t)((int32_t)L_7)), /*hidden argument*/NULL);
	}

IL_0043:
	{
		// return true;
		return (bool)1;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ReadStreamDataDefiniteLength(System.IO.Stream,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ReadStreamDataDefiniteLength_m7FE22AB1DEA1AF258E8ABB3FB36DEC5963A96269 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int32_t ___length1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// data = new byte[length];
		int32_t L_0 = ___length1;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_1 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, (uint32_t)L_0);
		__this->set_data_4(L_1);
		// xdata.Read(data, 0, (int)(length));
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = ___xdata0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_3 = __this->get_data_4();
		int32_t L_4 = ___length1;
		NullCheck(L_2);
		int32_t L_5;
		L_5 = VirtFuncInvoker3< int32_t, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(34 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_2, L_3, 0, L_4);
		// }
		return;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::GeneralDecodeIndefiniteLength(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_GeneralDecodeIndefiniteLength_mCA0402F12B5F298CF866EAD1FDCB4975631E0A0E (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___nodeMaxLen1, const RuntimeMethod* method)
{
	{
		// if (tag == Asn1Tag.BIT_STRING)
		uint8_t L_0 = __this->get_tag_0();
		if ((!(((uint32_t)L_0) == ((uint32_t)3))))
		{
			goto IL_001c;
		}
	}
	{
		// unusedBits = (byte)xdata.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = ___xdata0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_1);
		__this->set_unusedBits_6((uint8_t)((int32_t)((uint8_t)L_2)));
		// nodeMaxLen--;
		int64_t L_3 = ___nodeMaxLen1;
		___nodeMaxLen1 = ((int64_t)il2cpp_codegen_subtract((int64_t)L_3, (int64_t)((int64_t)((int64_t)1))));
	}

IL_001c:
	{
		// return ReadStreamDataIndefiniteLength(xdata, nodeMaxLen);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___xdata0;
		int64_t L_5 = ___nodeMaxLen1;
		bool L_6;
		L_6 = Asn1Node_ReadStreamDataIndefiniteLength_m33C8696271566577856A568A8A3BDC706309D8C2(__this, L_4, L_5, /*hidden argument*/NULL);
		return L_6;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ReadStreamDataIndefiniteLength(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ReadStreamDataIndefiniteLength_m33C8696271566577856A568A8A3BDC706309D8C2 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___nodeMaxLen1, const RuntimeMethod* method)
{
	int64_t V_0 = 0;
	int64_t V_1 = 0;
	{
		// var streamPosition = xdata.Position;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_0);
		V_0 = L_1;
		// long contentLength = MeasureContentLength(xdata);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = ___xdata0;
		int64_t L_3;
		L_3 = Asn1Node_MeasureContentLength_mC6339E6F3567891FBF8B3DAC1E890F01C7CA44FE(__this, L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		// if (contentLength != k_InvalidIndeterminateContentLength && contentLength <= nodeMaxLen)
		int64_t L_4 = V_1;
		if ((((int64_t)L_4) == ((int64_t)((int64_t)((int64_t)(-1))))))
		{
			goto IL_0023;
		}
	}
	{
		int64_t L_5 = V_1;
		int64_t L_6 = ___nodeMaxLen1;
		if ((((int64_t)L_5) > ((int64_t)L_6)))
		{
			goto IL_0023;
		}
	}
	{
		// ReadMeasuredLengthDataFromStart(xdata, streamPosition, contentLength);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_7 = ___xdata0;
		int64_t L_8 = V_0;
		int64_t L_9 = V_1;
		Asn1Node_ReadMeasuredLengthDataFromStart_m89EBB7361B009BF6D5CC8B901A3FE9468AF94ACD(__this, L_7, L_8, L_9, /*hidden argument*/NULL);
		// return true;
		return (bool)1;
	}

IL_0023:
	{
		// return false;
		return (bool)0;
	}
}
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::MeasureContentLength(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_MeasureContentLength_mC6339E6F3567891FBF8B3DAC1E890F01C7CA44FE (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	int64_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	{
		// long contentLength = 0;
		V_0 = ((int64_t)((int64_t)0));
		// bool firstEocByteFound = false;
		V_1 = (bool)0;
		// bool foundEoc = false;
		V_2 = (bool)0;
		goto IL_0038;
	}

IL_0009:
	{
		// var currentByte = xdata.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_0);
		V_3 = L_1;
		// if (currentByte == k_EndOfStream)
		int32_t L_2 = V_3;
		if ((!(((uint32_t)L_2) == ((uint32_t)(-1)))))
		{
			goto IL_001b;
		}
	}
	{
		// foundEoc = true;
		V_2 = (bool)1;
		// contentLength = k_InvalidIndeterminateContentLength;
		V_0 = ((int64_t)((int64_t)(-1)));
		// }
		goto IL_0038;
	}

IL_001b:
	{
		// else if (currentByte == Asn1Tag.TAG_END_OF_CONTENTS)
		int32_t L_3 = V_3;
		if (L_3)
		{
			goto IL_0029;
		}
	}
	{
		// if (firstEocByteFound)
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_0025;
		}
	}
	{
		// foundEoc = true;
		V_2 = (bool)1;
		// }
		goto IL_0038;
	}

IL_0025:
	{
		// firstEocByteFound = true;
		V_1 = (bool)1;
		// }
		goto IL_0038;
	}

IL_0029:
	{
		// if (firstEocByteFound)
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0033;
		}
	}
	{
		// firstEocByteFound = false;
		V_1 = (bool)0;
		// contentLength++;
		int64_t L_6 = V_0;
		V_0 = ((int64_t)il2cpp_codegen_add((int64_t)L_6, (int64_t)((int64_t)((int64_t)1))));
	}

IL_0033:
	{
		// contentLength++;
		int64_t L_7 = V_0;
		V_0 = ((int64_t)il2cpp_codegen_add((int64_t)L_7, (int64_t)((int64_t)((int64_t)1))));
	}

IL_0038:
	{
		// while (!foundEoc)
		bool L_8 = V_2;
		if (!L_8)
		{
			goto IL_0009;
		}
	}
	{
		// return contentLength;
		int64_t L_9 = V_0;
		return L_9;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Node::ReadMeasuredLengthDataFromStart(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Node_ReadMeasuredLengthDataFromStart_m89EBB7361B009BF6D5CC8B901A3FE9468AF94ACD (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___startPosition1, int64_t ___length2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_ReadMeasuredLengthDataFromStart_m89EBB7361B009BF6D5CC8B901A3FE9468AF94ACD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// xdata.Seek(startPosition, SeekOrigin.Begin);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		int64_t L_1 = ___startPosition1;
		NullCheck(L_0);
		int64_t L_2;
		L_2 = VirtFuncInvoker2< int64_t, int64_t, int32_t >::Invoke(32 /* System.Int64 System.IO.Stream::Seek(System.Int64,System.IO.SeekOrigin) */, L_0, L_1, 0);
		// data = new byte[length];
		int64_t L_3 = ___length2;
		if ((int64_t)(L_3) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), Asn1Node_ReadMeasuredLengthDataFromStart_m89EBB7361B009BF6D5CC8B901A3FE9468AF94ACD_RuntimeMethod_var);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_4 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)L_3));
		__this->set_data_4(L_4);
		// xdata.Read(data, 0, (int)(length));
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_5 = ___xdata0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_6 = __this->get_data_4();
		int64_t L_7 = ___length2;
		NullCheck(L_5);
		int32_t L_8;
		L_8 = VirtFuncInvoker3< int32_t, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(34 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_5, L_6, 0, ((int32_t)((int32_t)L_7)));
		// }
		return;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecode(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecode_mBFC1B062A5F787770D9CD86742038160283956BD (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int64_t V_1 = 0;
	int64_t V_2 = 0;
	int64_t V_3 = 0;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	{
		// bool retval = false;
		V_0 = (bool)0;
		// long originalPosition = xdata.Position;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_0);
		V_1 = L_1;
	}

IL_0009:
	try
	{ // begin try (depth: 1)
		{
			// tag = (byte)xdata.ReadByte();
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = ___xdata0;
			NullCheck(L_2);
			int32_t L_3;
			L_3 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_2);
			__this->set_tag_0((uint8_t)((int32_t)((uint8_t)L_3)));
			// long start = xdata.Position;
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___xdata0;
			NullCheck(L_4);
			int64_t L_5;
			L_5 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_4);
			V_2 = L_5;
			// dataLength = Asn1Util.DerLengthDecode(xdata, ref isIndefiniteLength);
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_6 = ___xdata0;
			bool* L_7 = __this->get_address_of_isIndefiniteLength_11();
			IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
			int64_t L_8;
			L_8 = Asn1Util_DerLengthDecode_m09878729C7733370A7423F2FD7CF97ECE86F58F9(L_6, (bool*)L_7, /*hidden argument*/NULL);
			__this->set_dataLength_2(L_8);
			// long childNodeMaxLen = xdata.Length - xdata.Position;
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_9 = ___xdata0;
			NullCheck(L_9);
			int64_t L_10;
			L_10 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_9);
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_11 = ___xdata0;
			NullCheck(L_11);
			int64_t L_12;
			L_12 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_11);
			V_3 = ((int64_t)il2cpp_codegen_subtract((int64_t)L_10, (int64_t)L_12));
			// if (isIndefiniteLength)
			bool L_13 = __this->get_isIndefiniteLength_11();
			if (!L_13)
			{
				goto IL_0054;
			}
		}

IL_0045:
		{
			// retval = ListDecodeIndefiniteLength(xdata, start, childNodeMaxLen - k_IndefiniteLengthFooterSize);
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_14 = ___xdata0;
			int64_t L_15 = V_2;
			int64_t L_16 = V_3;
			bool L_17;
			L_17 = Asn1Node_ListDecodeIndefiniteLength_m20CC97EC0CA87B9FA41B03D1D4EF7C8A540E93AD(__this, L_14, L_15, ((int64_t)il2cpp_codegen_subtract((int64_t)L_16, (int64_t)((int64_t)((int64_t)2)))), /*hidden argument*/NULL);
			V_0 = L_17;
			// }
			IL2CPP_LEAVE(0x71, FINALLY_0060);
		}

IL_0054:
		{
			// retval = ListDecodeKnownLengthWithChecks(xdata, start, childNodeMaxLen);
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_18 = ___xdata0;
			int64_t L_19 = V_2;
			int64_t L_20 = V_3;
			bool L_21;
			L_21 = Asn1Node_ListDecodeKnownLengthWithChecks_m7F188A7F5DF1A57A156E7DF92CF652DCFC60E45D(__this, L_18, L_19, L_20, /*hidden argument*/NULL);
			V_0 = L_21;
			// }
			IL2CPP_LEAVE(0x71, FINALLY_0060);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0060;
	}

FINALLY_0060:
	{ // begin finally (depth: 1)
		{
			// if (!retval)
			bool L_22 = V_0;
			if (L_22)
			{
				goto IL_0070;
			}
		}

IL_0063:
		{
			// xdata.Position = originalPosition;
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_23 = ___xdata0;
			int64_t L_24 = V_1;
			NullCheck(L_23);
			VirtActionInvoker1< int64_t >::Invoke(14 /* System.Void System.IO.Stream::set_Position(System.Int64) */, L_23, L_24);
			// ClearAll();
			Asn1Node_ClearAll_mD39130DFBE7AD1AF33618AEF2CE0CE2757D27046(__this, /*hidden argument*/NULL);
		}

IL_0070:
		{
			// }
			IL2CPP_END_FINALLY(96)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(96)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x71, IL_0071)
	}

IL_0071:
	{
		// return retval;
		bool L_25 = V_0;
		return L_25;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeKnownLengthWithChecks(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeKnownLengthWithChecks_m7F188A7F5DF1A57A156E7DF92CF652DCFC60E45D (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method)
{
	{
		// if (IsListStreamLengthOk(xdata, childNodeMaxLen))
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		int64_t L_1 = ___childNodeMaxLen2;
		bool L_2;
		L_2 = Asn1Node_IsListStreamLengthOk_m11C6BBF656C6802EDF87ECFEFD498D58A1F74E9B(__this, L_0, L_1, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_0013;
		}
	}
	{
		// return ListDecodeKnownLength(xdata, start);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_3 = ___xdata0;
		int64_t L_4 = ___start1;
		bool L_5;
		L_5 = Asn1Node_ListDecodeKnownLength_mD6745A67CEF1E27237E54ECFC09A597616CED6B8(__this, L_3, L_4, /*hidden argument*/NULL);
		return L_5;
	}

IL_0013:
	{
		// return false;
		return (bool)0;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::IsListStreamLengthOk(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_IsListStreamLengthOk_m11C6BBF656C6802EDF87ECFEFD498D58A1F74E9B (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___childNodeMaxLen1, const RuntimeMethod* method)
{
	{
		// return (dataLength >= 0 && childNodeMaxLen >= dataLength);
		int64_t L_0 = __this->get_dataLength_2();
		if ((((int64_t)L_0) < ((int64_t)((int64_t)((int64_t)0)))))
		{
			goto IL_0017;
		}
	}
	{
		int64_t L_1 = ___childNodeMaxLen1;
		int64_t L_2 = __this->get_dataLength_2();
		return (bool)((((int32_t)((((int64_t)L_1) < ((int64_t)L_2))? 1 : 0)) == ((int32_t)0))? 1 : 0);
	}

IL_0017:
	{
		return (bool)0;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeKnownLength(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeKnownLength_mD6745A67CEF1E27237E54ECFC09A597616CED6B8 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, const RuntimeMethod* method)
{
	int64_t V_0 = 0;
	{
		// long offset = CalculateListEncodeFieldBytesAndOffset(xdata, start);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		int64_t L_1 = ___start1;
		int64_t L_2;
		L_2 = Asn1Node_CalculateListEncodeFieldBytesAndOffset_m0D964212F4ABD27C10ABC8EEA4626F7E9CEABB55(__this, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		// HandleBitStringTag(xdata, ref offset);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_3 = ___xdata0;
		bool L_4;
		L_4 = Asn1Node_HandleBitStringTag_m3F1E2B0518549DCB5C253486E51E0D47329EC643(__this, L_3, (int64_t*)(&V_0), /*hidden argument*/NULL);
		// if (dataLength > 0)
		int64_t L_5 = __this->get_dataLength_2();
		if ((((int64_t)L_5) <= ((int64_t)((int64_t)((int64_t)0)))))
		{
			goto IL_0026;
		}
	}
	{
		// return ListDecodeKnownLengthInternal(xdata, offset);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_6 = ___xdata0;
		int64_t L_7 = V_0;
		bool L_8;
		L_8 = Asn1Node_ListDecodeKnownLengthInternal_mB98462D9D93AA55555AA2EEFC320655E540EADB8(__this, L_6, L_7, /*hidden argument*/NULL);
		return L_8;
	}

IL_0026:
	{
		// return false;
		return (bool)0;
	}
}
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Node::CalculateListEncodeFieldBytesAndOffset(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Node_CalculateListEncodeFieldBytesAndOffset_m0D964212F4ABD27C10ABC8EEA4626F7E9CEABB55 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, const RuntimeMethod* method)
{
	{
		// lengthFieldBytes = xdata.Position - start;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_0);
		int64_t L_2 = ___start1;
		__this->set_lengthFieldBytes_3(((int64_t)il2cpp_codegen_subtract((int64_t)L_1, (int64_t)L_2)));
		// return dataOffset + TagLength + lengthFieldBytes;
		int64_t L_3 = __this->get_dataOffset_1();
		int64_t L_4 = __this->get_lengthFieldBytes_3();
		return ((int64_t)il2cpp_codegen_add((int64_t)((int64_t)il2cpp_codegen_add((int64_t)L_3, (int64_t)((int64_t)((int64_t)1)))), (int64_t)L_4));
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::HandleBitStringTag(System.IO.Stream,System.Int64&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_HandleBitStringTag_m3F1E2B0518549DCB5C253486E51E0D47329EC643 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t* ___offset1, const RuntimeMethod* method)
{
	{
		// if (tag == Asn1Tag.BIT_STRING)
		uint8_t L_0 = __this->get_tag_0();
		if ((!(((uint32_t)L_0) == ((uint32_t)3))))
		{
			goto IL_002e;
		}
	}
	{
		// unusedBits = (byte)xdata.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = ___xdata0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_1);
		__this->set_unusedBits_6((uint8_t)((int32_t)((uint8_t)L_2)));
		// dataLength--;
		int64_t L_3 = __this->get_dataLength_2();
		__this->set_dataLength_2(((int64_t)il2cpp_codegen_subtract((int64_t)L_3, (int64_t)((int64_t)((int64_t)1)))));
		// offset++;
		int64_t* L_4 = ___offset1;
		int64_t* L_5 = ___offset1;
		int64_t L_6 = *((int64_t*)L_5);
		*((int64_t*)L_4) = (int64_t)((int64_t)il2cpp_codegen_add((int64_t)L_6, (int64_t)((int64_t)((int64_t)1))));
		// return true;
		return (bool)1;
	}

IL_002e:
	{
		// return false;
		return (bool)0;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeKnownLengthInternal(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeKnownLengthInternal_mB98462D9D93AA55555AA2EEFC320655E540EADB8 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___offset1, const RuntimeMethod* method)
{
	Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * V_0 = NULL;
	{
		// Stream secData = CreateAndPrepareListDecodeMemoryStreamKnownLength(xdata);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1;
		L_1 = Asn1Node_CreateAndPrepareListDecodeMemoryStreamKnownLength_mB4D54A6EF150F7586A41C1A6988B86905F0830D6(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		// return ListDecodeChildNodesWithKnownLength(secData, offset);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = V_0;
		int64_t L_3 = ___offset1;
		bool L_4;
		L_4 = Asn1Node_ListDecodeChildNodesWithKnownLength_m526CD7A41A53D2A54F129008D8688DE3F4E52005(__this, L_2, L_3, /*hidden argument*/NULL);
		return L_4;
	}
}
// System.IO.Stream LipingShare.LCLib.Asn1Processor.Asn1Node::CreateAndPrepareListDecodeMemoryStreamKnownLength(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * Asn1Node_CreateAndPrepareListDecodeMemoryStreamKnownLength_mB4D54A6EF150F7586A41C1A6988B86905F0830D6 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_CreateAndPrepareListDecodeMemoryStreamKnownLength_mB4D54A6EF150F7586A41C1A6988B86905F0830D6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_0 = NULL;
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * G_B2_0 = NULL;
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * G_B1_0 = NULL;
	{
		// Stream secData = new MemoryStream((int)dataLength);
		int64_t L_0 = __this->get_dataLength_2();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_1 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_mCB4274FF375AD786CCED424E80B047E0DEC50938(L_1, ((int32_t)((int32_t)L_0)), /*hidden argument*/NULL);
		// byte[] secByte = new byte[dataLength];
		int64_t L_2 = __this->get_dataLength_2();
		if ((int64_t)(L_2) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), Asn1Node_CreateAndPrepareListDecodeMemoryStreamKnownLength_mB4D54A6EF150F7586A41C1A6988B86905F0830D6_RuntimeMethod_var);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_3 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)L_2));
		V_0 = L_3;
		// xdata.Read(secByte, 0, (int)(dataLength));
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___xdata0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_5 = V_0;
		int64_t L_6 = __this->get_dataLength_2();
		NullCheck(L_4);
		int32_t L_7;
		L_7 = VirtFuncInvoker3< int32_t, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(34 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_4, L_5, 0, ((int32_t)((int32_t)L_6)));
		// if (tag == Asn1Tag.BIT_STRING)
		uint8_t L_8 = __this->get_tag_0();
		G_B1_0 = L_1;
		if ((!(((uint32_t)L_8) == ((uint32_t)3))))
		{
			G_B2_0 = L_1;
			goto IL_0041;
		}
	}
	{
		// dataLength++;
		int64_t L_9 = __this->get_dataLength_2();
		__this->set_dataLength_2(((int64_t)il2cpp_codegen_add((int64_t)L_9, (int64_t)((int64_t)((int64_t)1)))));
		G_B2_0 = G_B1_0;
	}

IL_0041:
	{
		// secData.Write(secByte, 0, secByte.Length);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_10 = G_B2_0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_11 = V_0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_12 = V_0;
		NullCheck(L_12);
		NullCheck(L_10);
		VirtActionInvoker3< ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(36 /* System.Void System.IO.Stream::Write(System.Byte[],System.Int32,System.Int32) */, L_10, L_11, 0, ((int32_t)((int32_t)(((RuntimeArray*)L_12)->max_length))));
		// secData.Position = 0;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_13 = L_10;
		NullCheck(L_13);
		VirtActionInvoker1< int64_t >::Invoke(14 /* System.Void System.IO.Stream::set_Position(System.Int64) */, L_13, ((int64_t)((int64_t)0)));
		// return secData;
		return L_13;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeChildNodesWithKnownLength(System.IO.Stream,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeChildNodesWithKnownLength_m526CD7A41A53D2A54F129008D8688DE3F4E52005 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___secData0, int64_t ___offset1, const RuntimeMethod* method)
{
	{
		goto IL_000f;
	}

IL_0002:
	{
		// if (!CreateAndAddChildNode(secData, ref offset))
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___secData0;
		bool L_1;
		L_1 = Asn1Node_CreateAndAddChildNode_mFDBB610D8295704D2DC2FA8EE62146C1C3FD1421(__this, L_0, (int64_t*)(&___offset1), /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_000f;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_000f:
	{
		// while (secData.Position < secData.Length)
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = ___secData0;
		NullCheck(L_2);
		int64_t L_3;
		L_3 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_2);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___secData0;
		NullCheck(L_4);
		int64_t L_5;
		L_5 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_4);
		if ((((int64_t)L_3) < ((int64_t)L_5)))
		{
			goto IL_0002;
		}
	}
	{
		// return true;
		return (bool)1;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::CreateAndAddChildNode(System.IO.Stream,System.Int64&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_CreateAndAddChildNode_mFDBB610D8295704D2DC2FA8EE62146C1C3FD1421 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___secData0, int64_t* ___offset1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_0 = NULL;
	int64_t V_1 = 0;
	{
		// var node = new Asn1Node(this, offset);
		int64_t* L_0 = ___offset1;
		int64_t L_1 = *((int64_t*)L_0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)il2cpp_codegen_object_new(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var);
		Asn1Node__ctor_m94082F24B4B34958EAC6DC936D16B324589758BC(L_2, __this, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		// node.parseEncapsulatedData = this.parseEncapsulatedData;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_3 = V_0;
		bool L_4 = __this->get_parseEncapsulatedData_12();
		NullCheck(L_3);
		L_3->set_parseEncapsulatedData_12(L_4);
		// long start = secData.Position;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_5 = ___secData0;
		NullCheck(L_5);
		int64_t L_6;
		L_6 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_5);
		V_1 = L_6;
		// if (!node.InternalLoadData(secData))
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_7 = V_0;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_8 = ___secData0;
		NullCheck(L_7);
		bool L_9;
		L_9 = Asn1Node_InternalLoadData_mD4F124147CA5C1269F2CFA65E20AD7104477E3B9(L_7, L_8, /*hidden argument*/NULL);
		if (L_9)
		{
			goto IL_0027;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_0027:
	{
		// AddChild(node);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_10 = V_0;
		Asn1Node_AddChild_m2A68F11D8748772F35AA72997F724034790B2605(__this, L_10, /*hidden argument*/NULL);
		// offset += secData.Position - start;
		int64_t* L_11 = ___offset1;
		int64_t* L_12 = ___offset1;
		int64_t L_13 = *((int64_t*)L_12);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_14 = ___secData0;
		NullCheck(L_14);
		int64_t L_15;
		L_15 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_14);
		int64_t L_16 = V_1;
		*((int64_t*)L_11) = (int64_t)((int64_t)il2cpp_codegen_add((int64_t)L_13, (int64_t)((int64_t)il2cpp_codegen_subtract((int64_t)L_15, (int64_t)L_16))));
		// return true;
		return (bool)1;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeIndefiniteLength(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeIndefiniteLength_m20CC97EC0CA87B9FA41B03D1D4EF7C8A540E93AD (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___start1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method)
{
	int64_t V_0 = 0;
	{
		// long offset = CalculateListEncodeFieldBytesAndOffset(xdata, start);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		int64_t L_1 = ___start1;
		int64_t L_2;
		L_2 = Asn1Node_CalculateListEncodeFieldBytesAndOffset_m0D964212F4ABD27C10ABC8EEA4626F7E9CEABB55(__this, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		// if (HandleBitStringTag(xdata, ref offset))
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_3 = ___xdata0;
		bool L_4;
		L_4 = Asn1Node_HandleBitStringTag_m3F1E2B0518549DCB5C253486E51E0D47329EC643(__this, L_3, (int64_t*)(&V_0), /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_001a;
		}
	}
	{
		// childNodeMaxLen--;
		int64_t L_5 = ___childNodeMaxLen2;
		___childNodeMaxLen2 = ((int64_t)il2cpp_codegen_subtract((int64_t)L_5, (int64_t)((int64_t)((int64_t)1))));
	}

IL_001a:
	{
		// return ListDecodeIndefiniteLengthInternal(xdata, offset, childNodeMaxLen);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_6 = ___xdata0;
		int64_t L_7 = V_0;
		int64_t L_8 = ___childNodeMaxLen2;
		bool L_9;
		L_9 = Asn1Node_ListDecodeIndefiniteLengthInternal_m8E21404468B59298C16988FC14411A5576789E01(__this, L_6, L_7, L_8, /*hidden argument*/NULL);
		return L_9;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ListDecodeIndefiniteLengthInternal(System.IO.Stream,System.Int64,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ListDecodeIndefiniteLengthInternal_m8E21404468B59298C16988FC14411A5576789E01 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t ___offset1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method)
{
	bool V_0 = false;
	int64_t V_1 = 0;
	{
		// bool doneReading = false;
		V_0 = (bool)0;
		goto IL_0018;
	}

IL_0004:
	{
		// var oldOffset = offset;
		int64_t L_0 = ___offset1;
		V_1 = L_0;
		// doneReading = ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(xdata, ref offset, childNodeMaxLen);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = ___xdata0;
		int64_t L_2 = ___childNodeMaxLen2;
		bool L_3;
		L_3 = Asn1Node_ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid_m7192750440F31F6C278BC0389A0C9FE069E62148(__this, L_1, (int64_t*)(&___offset1), L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		// childNodeMaxLen -= (offset - oldOffset);
		int64_t L_4 = ___childNodeMaxLen2;
		int64_t L_5 = ___offset1;
		int64_t L_6 = V_1;
		___childNodeMaxLen2 = ((int64_t)il2cpp_codegen_subtract((int64_t)L_4, (int64_t)((int64_t)il2cpp_codegen_subtract((int64_t)L_5, (int64_t)L_6))));
	}

IL_0018:
	{
		// while (!doneReading)
		bool L_7 = V_0;
		if (!L_7)
		{
			goto IL_0004;
		}
	}
	{
		// return ChildNodeCount > 0;
		int64_t L_8;
		L_8 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(__this, /*hidden argument*/NULL);
		return (bool)((((int64_t)L_8) > ((int64_t)((int64_t)((int64_t)0))))? 1 : 0);
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(System.IO.Stream,System.Int64&,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid_m7192750440F31F6C278BC0389A0C9FE069E62148 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t* ___offset1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	{
		// var byteChecks = DetectEndOfIndefiniteListContents(xdata);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		int32_t L_1;
		L_1 = Asn1Node_DetectEndOfIndefiniteListContents_mCA07A1B65297E1AF71D6E84A5003B0EC16ADD676(__this, L_0, /*hidden argument*/NULL);
		V_1 = L_1;
		// if (byteChecks == Asn1EndOfIndefiniteLengthNodeType.NotEnd)
		int32_t L_2 = V_1;
		if ((!(((uint32_t)L_2) == ((uint32_t)2))))
		{
			goto IL_001b;
		}
	}
	{
		// doneReading = !ReadNextChildNodeOfIndefiniteListClearIfInvalid(xdata, ref offset, childNodeMaxLen);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_3 = ___xdata0;
		int64_t* L_4 = ___offset1;
		int64_t L_5 = ___childNodeMaxLen2;
		bool L_6;
		L_6 = Asn1Node_ReadNextChildNodeOfIndefiniteListClearIfInvalid_m1FEF12D06C608BFAC0C093E2383679B6FB205110(__this, L_3, (int64_t*)L_4, L_5, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		// }
		goto IL_0030;
	}

IL_001b:
	{
		// if (byteChecks == Asn1EndOfIndefiniteLengthNodeType.EndOfStream && ChildNodeCount > 0)
		int32_t L_7 = V_1;
		if (L_7)
		{
			goto IL_002e;
		}
	}
	{
		int64_t L_8;
		L_8 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(__this, /*hidden argument*/NULL);
		if ((((int64_t)L_8) <= ((int64_t)((int64_t)((int64_t)0)))))
		{
			goto IL_002e;
		}
	}
	{
		// ClearAll();
		Asn1Node_ClearAll_mD39130DFBE7AD1AF33618AEF2CE0CE2757D27046(__this, /*hidden argument*/NULL);
	}

IL_002e:
	{
		// doneReading = true;
		V_0 = (bool)1;
	}

IL_0030:
	{
		// return doneReading;
		bool L_9 = V_0;
		return L_9;
	}
}
// LipingShare.LCLib.Asn1Processor.Asn1EndOfIndefiniteLengthNodeType LipingShare.LCLib.Asn1Processor.Asn1Node::DetectEndOfIndefiniteListContents(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Asn1Node_DetectEndOfIndefiniteListContents_mCA07A1B65297E1AF71D6E84A5003B0EC16ADD676 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// var tagByte = xdata.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_0);
		V_0 = L_1;
		// if (tagByte != k_EndOfStream)
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)(-1))))
		{
			goto IL_0020;
		}
	}
	{
		// var lengthByte = xdata.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_3 = ___xdata0;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_3);
		V_1 = L_4;
		// if (lengthByte != k_EndOfStream)
		int32_t L_5 = V_1;
		if ((((int32_t)L_5) == ((int32_t)(-1))))
		{
			goto IL_0020;
		}
	}
	{
		// if (tagByte == Asn1Tag.TAG_END_OF_CONTENTS && lengthByte == Asn1Tag.TAG_END_OF_CONTENTS)
		int32_t L_6 = V_0;
		if (L_6)
		{
			goto IL_001e;
		}
	}
	{
		int32_t L_7 = V_1;
		if (L_7)
		{
			goto IL_001e;
		}
	}
	{
		// return Asn1EndOfIndefiniteLengthNodeType.EndOfNodeFooter;
		return (int32_t)(1);
	}

IL_001e:
	{
		// return Asn1EndOfIndefiniteLengthNodeType.NotEnd;
		return (int32_t)(2);
	}

IL_0020:
	{
		// return Asn1EndOfIndefiniteLengthNodeType.EndOfStream;
		return (int32_t)(0);
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::ReadNextChildNodeOfIndefiniteListClearIfInvalid(System.IO.Stream,System.Int64&,System.Int64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_ReadNextChildNodeOfIndefiniteListClearIfInvalid_m1FEF12D06C608BFAC0C093E2383679B6FB205110 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, int64_t* ___offset1, int64_t ___childNodeMaxLen2, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		// xdata.Position -= k_IndefiniteLengthFooterSize;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = L_0;
		NullCheck(L_1);
		int64_t L_2;
		L_2 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_1);
		NullCheck(L_1);
		VirtActionInvoker1< int64_t >::Invoke(14 /* System.Void System.IO.Stream::set_Position(System.Int64) */, L_1, ((int64_t)il2cpp_codegen_subtract((int64_t)L_2, (int64_t)((int64_t)((int64_t)2)))));
		// bool validChildNode = false;
		V_0 = (bool)0;
		// if (CreateAndAddChildNode(xdata, ref offset))
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_3 = ___xdata0;
		int64_t* L_4 = ___offset1;
		bool L_5;
		L_5 = Asn1Node_CreateAndAddChildNode_mFDBB610D8295704D2DC2FA8EE62146C1C3FD1421(__this, L_3, (int64_t*)L_4, /*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_002a;
		}
	}
	{
		// validChildNode = GetLastChild().DataLength < childNodeMaxLen;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_6;
		L_6 = Asn1Node_GetLastChild_m0F7F8629136DB0882A19E41C4F74BBF16F36E317(__this, /*hidden argument*/NULL);
		NullCheck(L_6);
		int64_t L_7;
		L_7 = Asn1Node_get_DataLength_mCF41384470AB94796BC81FCA252C18AB3513BBD8_inline(L_6, /*hidden argument*/NULL);
		int64_t L_8 = ___childNodeMaxLen2;
		V_0 = (bool)((((int64_t)L_7) < ((int64_t)L_8))? 1 : 0);
	}

IL_002a:
	{
		// if (ChildNodeCount > 0 && !validChildNode)
		int64_t L_9;
		L_9 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(__this, /*hidden argument*/NULL);
		if ((((int64_t)L_9) <= ((int64_t)((int64_t)((int64_t)0)))))
		{
			goto IL_003d;
		}
	}
	{
		bool L_10 = V_0;
		if (L_10)
		{
			goto IL_003d;
		}
	}
	{
		// ClearAll();
		Asn1Node_ClearAll_mD39130DFBE7AD1AF33618AEF2CE0CE2757D27046(__this, /*hidden argument*/NULL);
	}

IL_003d:
	{
		// return validChildNode;
		bool L_11 = V_0;
		return L_11;
	}
}
// System.Boolean LipingShare.LCLib.Asn1Processor.Asn1Node::InternalLoadData(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Asn1Node_InternalLoadData_mD4F124147CA5C1269F2CFA65E20AD7104477E3B9 (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int64_t V_1 = 0;
	int32_t V_2 = 0;
	{
		// bool retval = true;
		V_0 = (bool)1;
		// ClearAll();
		Asn1Node_ClearAll_mD39130DFBE7AD1AF33618AEF2CE0CE2757D27046(__this, /*hidden argument*/NULL);
		// long curPosition = xdata.Position;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___xdata0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_0);
		V_1 = L_1;
		// xtag = (byte)xdata.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = ___xdata0;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_2);
		// xdata.Position = curPosition;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___xdata0;
		int64_t L_5 = V_1;
		NullCheck(L_4);
		VirtActionInvoker1< int64_t >::Invoke(14 /* System.Void System.IO.Stream::set_Position(System.Int64) */, L_4, L_5);
		// int maskedTag = xtag & Asn1Tag.TAG_MASK;
		int32_t L_6 = ((int32_t)((uint8_t)L_3));
		V_2 = ((int32_t)((int32_t)L_6&(int32_t)((int32_t)31)));
		// if (((xtag & Asn1TagClasses.CONSTRUCTED) != 0)
		//     || (parseEncapsulatedData
		//         && ((maskedTag == Asn1Tag.BIT_STRING)
		//             || (maskedTag == Asn1Tag.EXTERNAL)
		//             || (maskedTag == Asn1Tag.GENERAL_STRING)
		//             || (maskedTag == Asn1Tag.GENERALIZED_TIME)
		//             || (maskedTag == Asn1Tag.GRAPHIC_STRING)
		//             || (maskedTag == Asn1Tag.IA5_STRING)
		//             || (maskedTag == Asn1Tag.OCTET_STRING)
		//             || (maskedTag == Asn1Tag.PRINTABLE_STRING)
		//             || (maskedTag == Asn1Tag.SEQUENCE)
		//             || (maskedTag == Asn1Tag.SET)
		//             || (maskedTag == Asn1Tag.T61_STRING)
		//             || (maskedTag == Asn1Tag.UNIVERSAL_STRING)
		//             || (maskedTag == Asn1Tag.UTF8_STRING)
		//             || (maskedTag == Asn1Tag.VIDEOTEXT_STRING)
		//             || (maskedTag == Asn1Tag.VISIBLE_STRING)))
		// )
		if (((int32_t)((int32_t)L_6&(int32_t)((int32_t)32))))
		{
			goto IL_0077;
		}
	}
	{
		bool L_7 = __this->get_parseEncapsulatedData_12();
		if (!L_7)
		{
			goto IL_008d;
		}
	}
	{
		int32_t L_8 = V_2;
		if ((((int32_t)L_8) == ((int32_t)3)))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_9 = V_2;
		if ((((int32_t)L_9) == ((int32_t)8)))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_10 = V_2;
		if ((((int32_t)L_10) == ((int32_t)((int32_t)27))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_11 = V_2;
		if ((((int32_t)L_11) == ((int32_t)((int32_t)24))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_12 = V_2;
		if ((((int32_t)L_12) == ((int32_t)((int32_t)25))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_13 = V_2;
		if ((((int32_t)L_13) == ((int32_t)((int32_t)22))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_14 = V_2;
		if ((((int32_t)L_14) == ((int32_t)4)))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_15 = V_2;
		if ((((int32_t)L_15) == ((int32_t)((int32_t)19))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_16 = V_2;
		if ((((int32_t)L_16) == ((int32_t)((int32_t)16))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_17 = V_2;
		if ((((int32_t)L_17) == ((int32_t)((int32_t)17))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_18 = V_2;
		if ((((int32_t)L_18) == ((int32_t)((int32_t)20))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_19 = V_2;
		if ((((int32_t)L_19) == ((int32_t)((int32_t)28))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_20 = V_2;
		if ((((int32_t)L_20) == ((int32_t)((int32_t)12))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_21 = V_2;
		if ((((int32_t)L_21) == ((int32_t)((int32_t)21))))
		{
			goto IL_0077;
		}
	}
	{
		int32_t L_22 = V_2;
		if ((!(((uint32_t)L_22) == ((uint32_t)((int32_t)26)))))
		{
			goto IL_008d;
		}
	}

IL_0077:
	{
		// if (!ListDecode(xdata))
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_23 = ___xdata0;
		bool L_24;
		L_24 = Asn1Node_ListDecode_mBFC1B062A5F787770D9CD86742038160283956BD(__this, L_23, /*hidden argument*/NULL);
		if (L_24)
		{
			goto IL_0098;
		}
	}
	{
		// if (!GeneralDecode(xdata))
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_25 = ___xdata0;
		bool L_26;
		L_26 = Asn1Node_GeneralDecode_m0CF76CE74470A9631179746CBE8AEEA09C7BE56B(__this, L_25, /*hidden argument*/NULL);
		if (L_26)
		{
			goto IL_0098;
		}
	}
	{
		// retval = false;
		V_0 = (bool)0;
		// }
		goto IL_0098;
	}

IL_008d:
	{
		// if (!GeneralDecode(xdata)) retval = false;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_27 = ___xdata0;
		bool L_28;
		L_28 = Asn1Node_GeneralDecode_m0CF76CE74470A9631179746CBE8AEEA09C7BE56B(__this, L_27, /*hidden argument*/NULL);
		if (L_28)
		{
			goto IL_0098;
		}
	}
	{
		// if (!GeneralDecode(xdata)) retval = false;
		V_0 = (bool)0;
	}

IL_0098:
	{
		// return retval;
		bool L_29 = V_0;
		return L_29;
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
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Parser::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Parser__ctor_mA73693A2C1369EA2767CCD813D6A9ACCC8599088 (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private Asn1Node rootNode = new Asn1Node();
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 *)il2cpp_codegen_object_new(Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3_il2cpp_TypeInfo_var);
		Asn1Node__ctor_mB242F7479DDBE60A03AF22BC268BD4DA1EA62E5B(L_0, /*hidden argument*/NULL);
		__this->set_rootNode_1(L_0);
		// public Asn1Parser()
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Parser::LoadData(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Parser_LoadData_mC695E2673D7B8576065B7130E6BF0B92F4908B98 (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___stream0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Parser_LoadData_mC695E2673D7B8576065B7130E6BF0B92F4908B98_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// stream.Position = 0;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___stream0;
		NullCheck(L_0);
		VirtActionInvoker1< int64_t >::Invoke(14 /* System.Void System.IO.Stream::set_Position(System.Int64) */, L_0, ((int64_t)((int64_t)0)));
		// if (!rootNode.LoadData(stream))
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1 = __this->get_rootNode_1();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_2 = ___stream0;
		NullCheck(L_1);
		bool L_3;
		L_3 = Asn1Node_LoadData_m19814DE77D7FE6BD5E95380BF1AB1357F15C750F(L_1, L_2, /*hidden argument*/NULL);
		if (L_3)
		{
			goto IL_0021;
		}
	}
	{
		// throw new ArgumentException("Failed to load data.");
		ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00 * L_4 = (ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00_il2cpp_TypeInfo_var)));
		ArgumentException__ctor_m2D35EAD113C2ADC99EB17B940A2097A93FD23EFC(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralB89111EC34842EC45C03B81F4BDFBC7724B6905F)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Asn1Parser_LoadData_mC695E2673D7B8576065B7130E6BF0B92F4908B98_RuntimeMethod_var)));
	}

IL_0021:
	{
		// rawData = new byte[stream.Length];
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_5 = ___stream0;
		NullCheck(L_5);
		int64_t L_6;
		L_6 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_5);
		if ((int64_t)(L_6) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), Asn1Parser_LoadData_mC695E2673D7B8576065B7130E6BF0B92F4908B98_RuntimeMethod_var);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_7 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)L_6));
		__this->set_rawData_0(L_7);
		// stream.Position = 0;
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_8 = ___stream0;
		NullCheck(L_8);
		VirtActionInvoker1< int64_t >::Invoke(14 /* System.Void System.IO.Stream::set_Position(System.Int64) */, L_8, ((int64_t)((int64_t)0)));
		// stream.Read(rawData, 0, rawData.Length);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_9 = ___stream0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_10 = __this->get_rawData_0();
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_11 = __this->get_rawData_0();
		NullCheck(L_11);
		NullCheck(L_9);
		int32_t L_12;
		L_12 = VirtFuncInvoker3< int32_t, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*, int32_t, int32_t >::Invoke(34 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_9, L_10, 0, ((int32_t)((int32_t)(((RuntimeArray*)L_11)->max_length))));
		// }
		return;
	}
}
// LipingShare.LCLib.Asn1Processor.Asn1Node LipingShare.LCLib.Asn1Processor.Asn1Parser::get_RootNode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Parser_get_RootNode_m4359D48A87548584ACCF8540BA10BD7326091DAC (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * __this, const RuntimeMethod* method)
{
	{
		// return rootNode;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = __this->get_rootNode_1();
		return L_0;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Parser::GetNodeTextHeader(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Parser_GetNodeTextHeader_m48CEC04B4FBF2BBE897D1FFA800A8F09F5F03071 (int32_t ___lineLen0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4BAFCB89E7C61DD51CF32D48E1F883426E74C000);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral61F9A6943D78A4154F6821755AA9A1C4A3E80717);
		s_Il2CppMethodInitialized = true;
	}
	{
		// string header = String.Format("Offset| Len  |LenByte|\r\n");
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_0;
		L_0 = Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_inline(/*hidden argument*/Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_RuntimeMethod_var);
		String_t* L_1;
		L_1 = String_Format_mCED6767EA5FEE6F15ABCD5B4F9150D1284C2795B(_stringLiteral61F9A6943D78A4154F6821755AA9A1C4A3E80717, L_0, /*hidden argument*/NULL);
		// header += "======+======+=======+" + Asn1Util.GenStr(lineLen + 10, '=') + "\r\n";
		int32_t L_2 = ___lineLen0;
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_3;
		L_3 = Asn1Util_GenStr_mE8F5722F4437A061860433CFB0478AFFDB15B9B1(((int32_t)il2cpp_codegen_add((int32_t)L_2, (int32_t)((int32_t)10))), ((int32_t)61), /*hidden argument*/NULL);
		String_t* L_4;
		L_4 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_1, _stringLiteral4BAFCB89E7C61DD51CF32D48E1F883426E74C000, L_3, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5, /*hidden argument*/NULL);
		// return header;
		return L_4;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Parser::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Parser_ToString_mB446C934F7F87D230376957F9497D8F3D27723FC (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * __this, const RuntimeMethod* method)
{
	{
		// return GetNodeText(rootNode, 100);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = __this->get_rootNode_1();
		String_t* L_1;
		L_1 = Asn1Parser_GetNodeText_m4E589B8AF54C8760C8CCE19F81D8778EBA02462D(L_0, ((int32_t)100), /*hidden argument*/NULL);
		return L_1;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Parser::GetNodeText(LipingShare.LCLib.Asn1Processor.Asn1Node,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Parser_GetNodeText_m4E589B8AF54C8760C8CCE19F81D8778EBA02462D (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, int32_t ___lineLen1, const RuntimeMethod* method)
{
	{
		// string nodeStr = GetNodeTextHeader(lineLen);
		int32_t L_0 = ___lineLen1;
		String_t* L_1;
		L_1 = Asn1Parser_GetNodeTextHeader_m48CEC04B4FBF2BBE897D1FFA800A8F09F5F03071(L_0, /*hidden argument*/NULL);
		// nodeStr += node.GetText(node, lineLen);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = ___node0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_3 = ___node0;
		int32_t L_4 = ___lineLen1;
		NullCheck(L_2);
		String_t* L_5;
		L_5 = Asn1Node_GetText_m08AD0406E4330E7F0B546A1C8AA67D2B88F77B72(L_2, L_3, L_4, /*hidden argument*/NULL);
		String_t* L_6;
		L_6 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_1, L_5, /*hidden argument*/NULL);
		// return nodeStr;
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
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::FormatString(System.String,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_FormatString_m7588BDA18A9BC660061BAC73AB79DD458DF589F9 (String_t* ___inStr0, int32_t ___lineLen1, int32_t ___groupLen2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	{
		// char[] tmpCh = new char[inStr.Length * 2];
		String_t* L_0 = ___inStr0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_0, /*hidden argument*/NULL);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_2 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_1, (int32_t)2)));
		V_0 = L_2;
		// int i, c = 0, linec = 0;
		V_2 = 0;
		// int i, c = 0, linec = 0;
		V_3 = 0;
		// int gc = 0;
		V_4 = 0;
		// for (i = 0; i < inStr.Length; i++)
		V_1 = 0;
		goto IL_0062;
	}

IL_0019:
	{
		// tmpCh[c++] = inStr[i];
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_3 = V_0;
		int32_t L_4 = V_2;
		int32_t L_5 = L_4;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_5, (int32_t)1));
		String_t* L_6 = ___inStr0;
		int32_t L_7 = V_1;
		NullCheck(L_6);
		Il2CppChar L_8;
		L_8 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_6, L_7, /*hidden argument*/NULL);
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(L_5), (Il2CppChar)L_8);
		// gc++;
		int32_t L_9 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add((int32_t)L_9, (int32_t)1));
		// linec++;
		int32_t L_10 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_10, (int32_t)1));
		// if (gc >= groupLen && groupLen > 0)
		int32_t L_11 = V_4;
		int32_t L_12 = ___groupLen2;
		if ((((int32_t)L_11) < ((int32_t)L_12)))
		{
			goto IL_0046;
		}
	}
	{
		int32_t L_13 = ___groupLen2;
		if ((((int32_t)L_13) <= ((int32_t)0)))
		{
			goto IL_0046;
		}
	}
	{
		// tmpCh[c++] = ' ';
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_14 = V_0;
		int32_t L_15 = V_2;
		int32_t L_16 = L_15;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_16, (int32_t)1));
		NullCheck(L_14);
		(L_14)->SetAt(static_cast<il2cpp_array_size_t>(L_16), (Il2CppChar)((int32_t)32));
		// gc = 0;
		V_4 = 0;
	}

IL_0046:
	{
		// if (linec >= lineLen)
		int32_t L_17 = V_3;
		int32_t L_18 = ___lineLen1;
		if ((((int32_t)L_17) < ((int32_t)L_18)))
		{
			goto IL_005e;
		}
	}
	{
		// tmpCh[c++] = '\r';
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_19 = V_0;
		int32_t L_20 = V_2;
		int32_t L_21 = L_20;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_21, (int32_t)1));
		NullCheck(L_19);
		(L_19)->SetAt(static_cast<il2cpp_array_size_t>(L_21), (Il2CppChar)((int32_t)13));
		// tmpCh[c++] = '\n';
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_22 = V_0;
		int32_t L_23 = V_2;
		int32_t L_24 = L_23;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_24, (int32_t)1));
		NullCheck(L_22);
		(L_22)->SetAt(static_cast<il2cpp_array_size_t>(L_24), (Il2CppChar)((int32_t)10));
		// linec = 0;
		V_3 = 0;
	}

IL_005e:
	{
		// for (i = 0; i < inStr.Length; i++)
		int32_t L_25 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_25, (int32_t)1));
	}

IL_0062:
	{
		// for (i = 0; i < inStr.Length; i++)
		int32_t L_26 = V_1;
		String_t* L_27 = ___inStr0;
		NullCheck(L_27);
		int32_t L_28;
		L_28 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_27, /*hidden argument*/NULL);
		if ((((int32_t)L_26) < ((int32_t)L_28)))
		{
			goto IL_0019;
		}
	}
	{
		// string retval = new string(tmpCh);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_29 = V_0;
		String_t* L_30;
		L_30 = String_CreateString_mC7F57CE6ED768CF86591160424FE55D5CBA7C344(NULL, L_29, /*hidden argument*/NULL);
		// retval = retval.TrimEnd('\0');
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_31 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)1);
		NullCheck(L_30);
		String_t* L_32;
		L_32 = String_TrimEnd_mA98B5B9C45CCAB016F32F1C8BBE29A215B9D277E(L_30, L_31, /*hidden argument*/NULL);
		// retval = retval.TrimEnd('\n');
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_33 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)1);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_34 = L_33;
		NullCheck(L_34);
		(L_34)->SetAt(static_cast<il2cpp_array_size_t>(0), (Il2CppChar)((int32_t)10));
		NullCheck(L_32);
		String_t* L_35;
		L_35 = String_TrimEnd_mA98B5B9C45CCAB016F32F1C8BBE29A215B9D277E(L_32, L_34, /*hidden argument*/NULL);
		// retval = retval.TrimEnd('\r');
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_36 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)1);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_37 = L_36;
		NullCheck(L_37);
		(L_37)->SetAt(static_cast<il2cpp_array_size_t>(0), (Il2CppChar)((int32_t)13));
		NullCheck(L_35);
		String_t* L_38;
		L_38 = String_TrimEnd_mA98B5B9C45CCAB016F32F1C8BBE29A215B9D277E(L_35, L_37, /*hidden argument*/NULL);
		// return retval;
		return L_38;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::GenStr(System.Int32,System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_GenStr_mE8F5722F4437A061860433CFB0478AFFDB15B9B1 (int32_t ___len0, Il2CppChar ___xch1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// char[] ch = new char[len];
		int32_t L_0 = ___len0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_1 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)L_0);
		V_0 = L_1;
		// for (int i = 0; i < len; i++)
		V_1 = 0;
		goto IL_0013;
	}

IL_000b:
	{
		// ch[i] = xch;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_2 = V_0;
		int32_t L_3 = V_1;
		Il2CppChar L_4 = ___xch1;
		NullCheck(L_2);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(L_3), (Il2CppChar)L_4);
		// for (int i = 0; i < len; i++)
		int32_t L_5 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_5, (int32_t)1));
	}

IL_0013:
	{
		// for (int i = 0; i < len; i++)
		int32_t L_6 = V_1;
		int32_t L_7 = ___len0;
		if ((((int32_t)L_6) < ((int32_t)L_7)))
		{
			goto IL_000b;
		}
	}
	{
		// return new string(ch);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_8 = V_0;
		String_t* L_9;
		L_9 = String_CreateString_mC7F57CE6ED768CF86591160424FE55D5CBA7C344(NULL, L_8, /*hidden argument*/NULL);
		return L_9;
	}
}
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Util::BytesToLong(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Util_BytesToLong_m64549AEECF1BDC3B2C9A99B77043EB487E58B3D7 (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___bytes0, const RuntimeMethod* method)
{
	int64_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// long tempInt = 0;
		V_0 = ((int64_t)((int64_t)0));
		// for (int i = 0; i < bytes.Length; i++)
		V_1 = 0;
		goto IL_0014;
	}

IL_0007:
	{
		// tempInt = tempInt << 8 | bytes[i];
		int64_t L_0 = V_0;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_1 = ___bytes0;
		int32_t L_2 = V_1;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		uint8_t L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = ((int64_t)((int64_t)((int64_t)((int64_t)L_0<<(int32_t)8))|(int64_t)((int64_t)((uint64_t)L_4))));
		// for (int i = 0; i < bytes.Length; i++)
		int32_t L_5 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_5, (int32_t)1));
	}

IL_0014:
	{
		// for (int i = 0; i < bytes.Length; i++)
		int32_t L_6 = V_1;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_7 = ___bytes0;
		NullCheck(L_7);
		if ((((int32_t)L_6) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_7)->max_length))))))
		{
			goto IL_0007;
		}
	}
	{
		// return tempInt;
		int64_t L_8 = V_0;
		return L_8;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::BytesToString(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_BytesToString_mA5E3457776D5F5FAF8C7D2850268B8FA9E8CE441 (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___bytes0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		// string retval = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// if (bytes == null || bytes.Length < 1) return retval;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = ___bytes0;
		if (!L_0)
		{
			goto IL_000f;
		}
	}
	{
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_1 = ___bytes0;
		NullCheck(L_1);
		if ((((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length)))) >= ((int32_t)1)))
		{
			goto IL_0011;
		}
	}

IL_000f:
	{
		// if (bytes == null || bytes.Length < 1) return retval;
		String_t* L_2 = V_0;
		return L_2;
	}

IL_0011:
	{
		// char[] cretval = new char[bytes.Length];
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_3 = ___bytes0;
		NullCheck(L_3);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_4 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)((int32_t)((int32_t)(((RuntimeArray*)L_3)->max_length))));
		V_1 = L_4;
		// for (int i = 0, j = 0; i < bytes.Length; i++)
		V_2 = 0;
		// for (int i = 0, j = 0; i < bytes.Length; i++)
		V_3 = 0;
		goto IL_0033;
	}

IL_0020:
	{
		// if (bytes[i] != '\0')
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_5 = ___bytes0;
		int32_t L_6 = V_2;
		NullCheck(L_5);
		int32_t L_7 = L_6;
		uint8_t L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		if (!L_8)
		{
			goto IL_002f;
		}
	}
	{
		// cretval[j++] = (char)bytes[i];
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_9 = V_1;
		int32_t L_10 = V_3;
		int32_t L_11 = L_10;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_11, (int32_t)1));
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_12 = ___bytes0;
		int32_t L_13 = V_2;
		NullCheck(L_12);
		int32_t L_14 = L_13;
		uint8_t L_15 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		NullCheck(L_9);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(L_11), (Il2CppChar)L_15);
	}

IL_002f:
	{
		// for (int i = 0, j = 0; i < bytes.Length; i++)
		int32_t L_16 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_16, (int32_t)1));
	}

IL_0033:
	{
		// for (int i = 0, j = 0; i < bytes.Length; i++)
		int32_t L_17 = V_2;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_18 = ___bytes0;
		NullCheck(L_18);
		if ((((int32_t)L_17) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_18)->max_length))))))
		{
			goto IL_0020;
		}
	}
	{
		// retval = new string(cretval);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_19 = V_1;
		String_t* L_20;
		L_20 = String_CreateString_mC7F57CE6ED768CF86591160424FE55D5CBA7C344(NULL, L_19, /*hidden argument*/NULL);
		V_0 = L_20;
		// retval = retval.TrimEnd('\0');
		String_t* L_21 = V_0;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_22 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)1);
		NullCheck(L_21);
		String_t* L_23;
		L_23 = String_TrimEnd_mA98B5B9C45CCAB016F32F1C8BBE29A215B9D277E(L_21, L_22, /*hidden argument*/NULL);
		V_0 = L_23;
		// return retval;
		String_t* L_24 = V_0;
		return L_24;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::ToHexString(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___bytes0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		// if (bytes == null) return "";
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = ___bytes0;
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// if (bytes == null) return "";
		return _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
	}

IL_0009:
	{
		// char[] chars = new char[bytes.Length * 2];
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_1 = ___bytes0;
		NullCheck(L_1);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_2 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length))), (int32_t)2)));
		V_0 = L_2;
		// for (i = 0; i < bytes.Length; i++)
		V_2 = 0;
		goto IL_003f;
	}

IL_0018:
	{
		// b = bytes[i];
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_3 = ___bytes0;
		int32_t L_4 = V_2;
		NullCheck(L_3);
		int32_t L_5 = L_4;
		uint8_t L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		V_1 = L_6;
		// chars[i * 2] = hexDigits[b >> 4];
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_7 = V_0;
		int32_t L_8 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_9 = ((Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_StaticFields*)il2cpp_codegen_static_fields_for(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var))->get_hexDigits_0();
		int32_t L_10 = V_1;
		NullCheck(L_9);
		int32_t L_11 = ((int32_t)((int32_t)L_10>>(int32_t)4));
		uint16_t L_12 = (uint16_t)(L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		NullCheck(L_7);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_multiply((int32_t)L_8, (int32_t)2))), (Il2CppChar)L_12);
		// chars[i * 2 + 1] = hexDigits[b & 0xF];
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_13 = V_0;
		int32_t L_14 = V_2;
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_15 = ((Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_StaticFields*)il2cpp_codegen_static_fields_for(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var))->get_hexDigits_0();
		int32_t L_16 = V_1;
		NullCheck(L_15);
		int32_t L_17 = ((int32_t)((int32_t)L_16&(int32_t)((int32_t)15)));
		uint16_t L_18 = (uint16_t)(L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		NullCheck(L_13);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_14, (int32_t)2)), (int32_t)1))), (Il2CppChar)L_18);
		// for (i = 0; i < bytes.Length; i++)
		int32_t L_19 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_19, (int32_t)1));
	}

IL_003f:
	{
		// for (i = 0; i < bytes.Length; i++)
		int32_t L_20 = V_2;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_21 = ___bytes0;
		NullCheck(L_21);
		if ((((int32_t)L_20) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_21)->max_length))))))
		{
			goto IL_0018;
		}
	}
	{
		// return new string(chars);
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_22 = V_0;
		String_t* L_23;
		L_23 = String_CreateString_mC7F57CE6ED768CF86591160424FE55D5CBA7C344(NULL, L_22, /*hidden argument*/NULL);
		return L_23;
	}
}
// System.Int32 LipingShare.LCLib.Asn1Processor.Asn1Util::BytePrecision(System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Asn1Util_BytePrecision_m2FB699DF3BB16FA38562D4FC072CD769835A89EB (uint64_t ___value0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		// for (i = 4; i > 0; --i) // 4: sizeof(ulong)
		V_0 = 4;
		goto IL_0014;
	}

IL_0004:
	{
		// if ((value >> (i - 1) * 8) != 0)
		uint64_t L_0 = ___value0;
		int32_t L_1 = V_0;
		if (((int64_t)((uint64_t)L_0>>((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_1, (int32_t)1)), (int32_t)8))&(int32_t)((int32_t)63))))))
		{
			goto IL_0018;
		}
	}
	{
		// for (i = 4; i > 0; --i) // 4: sizeof(ulong)
		int32_t L_2 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_2, (int32_t)1));
	}

IL_0014:
	{
		// for (i = 4; i > 0; --i) // 4: sizeof(ulong)
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) > ((int32_t)0)))
		{
			goto IL_0004;
		}
	}

IL_0018:
	{
		// return i;
		int32_t L_4 = V_0;
		return L_4;
	}
}
// System.Int32 LipingShare.LCLib.Asn1Processor.Asn1Util::DERLengthEncode(System.IO.Stream,System.UInt64)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Asn1Util_DERLengthEncode_mAB5A1E98AC3EF600B339FE181ADF620BBB2DF2FD (Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___xdata0, uint64_t ___length1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		// int i = 0;
		V_0 = 0;
		// if (length <= 0x7f)
		uint64_t L_0 = ___length1;
		if ((!(((uint64_t)L_0) <= ((uint64_t)((int64_t)((int64_t)((int32_t)127)))))))
		{
			goto IL_0016;
		}
	}
	{
		// xdata.WriteByte((byte)length);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = ___xdata0;
		uint64_t L_2 = ___length1;
		NullCheck(L_1);
		VirtActionInvoker1< uint8_t >::Invoke(37 /* System.Void System.IO.Stream::WriteByte(System.Byte) */, L_1, (uint8_t)((int32_t)((uint8_t)L_2)));
		// i++;
		int32_t L_3 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_3, (int32_t)1));
		// }
		goto IL_0053;
	}

IL_0016:
	{
		// xdata.WriteByte((byte)(BytePrecision(length) | 0x80));
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_4 = ___xdata0;
		uint64_t L_5 = ___length1;
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		int32_t L_6;
		L_6 = Asn1Util_BytePrecision_m2FB699DF3BB16FA38562D4FC072CD769835A89EB(L_5, /*hidden argument*/NULL);
		NullCheck(L_4);
		VirtActionInvoker1< uint8_t >::Invoke(37 /* System.Void System.IO.Stream::WriteByte(System.Byte) */, L_4, (uint8_t)((int32_t)((uint8_t)((int32_t)((int32_t)L_6|(int32_t)((int32_t)128))))));
		// i++;
		int32_t L_7 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_7, (int32_t)1));
		// for (int j = BytePrecision((ulong)length); j > 0; --j)
		uint64_t L_8 = ___length1;
		int32_t L_9;
		L_9 = Asn1Util_BytePrecision_m2FB699DF3BB16FA38562D4FC072CD769835A89EB(L_8, /*hidden argument*/NULL);
		V_1 = L_9;
		goto IL_004f;
	}

IL_0036:
	{
		// xdata.WriteByte((byte)(length >> (j - 1) * 8));
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_10 = ___xdata0;
		uint64_t L_11 = ___length1;
		int32_t L_12 = V_1;
		NullCheck(L_10);
		VirtActionInvoker1< uint8_t >::Invoke(37 /* System.Void System.IO.Stream::WriteByte(System.Byte) */, L_10, (uint8_t)((int32_t)((uint8_t)((int64_t)((uint64_t)L_11>>((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_12, (int32_t)1)), (int32_t)8))&(int32_t)((int32_t)63))))))));
		// i++;
		int32_t L_13 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_13, (int32_t)1));
		// for (int j = BytePrecision((ulong)length); j > 0; --j)
		int32_t L_14 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_14, (int32_t)1));
	}

IL_004f:
	{
		// for (int j = BytePrecision((ulong)length); j > 0; --j)
		int32_t L_15 = V_1;
		if ((((int32_t)L_15) > ((int32_t)0)))
		{
			goto IL_0036;
		}
	}

IL_0053:
	{
		// return i;
		int32_t L_16 = V_0;
		return L_16;
	}
}
// System.Int64 LipingShare.LCLib.Asn1Processor.Asn1Util::DerLengthDecode(System.IO.Stream,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int64_t Asn1Util_DerLengthDecode_m09878729C7733370A7423F2FD7CF97ECE86F58F9 (Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___bt0, bool* ___isIndefiniteLength1, const RuntimeMethod* method)
{
	int64_t V_0 = 0;
	uint8_t V_1 = 0x0;
	int64_t V_2 = 0;
	{
		// isIndefiniteLength = false;
		bool* L_0 = ___isIndefiniteLength1;
		*((int8_t*)L_0) = (int8_t)0;
		// long length = 0;
		V_0 = ((int64_t)((int64_t)0));
		// b = (byte)bt.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = ___bt0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_1);
		V_1 = (uint8_t)((int32_t)((uint8_t)L_2));
		// if ((b & 0x80) == 0)
		uint8_t L_3 = V_1;
		if (((int32_t)((int32_t)L_3&(int32_t)((int32_t)128))))
		{
			goto IL_001c;
		}
	}
	{
		// length = b;
		uint8_t L_4 = V_1;
		V_0 = ((int64_t)((uint64_t)L_4));
		// }
		goto IL_005e;
	}

IL_001c:
	{
		// long lengthBytes = b & 0x7f;
		uint8_t L_5 = V_1;
		V_2 = ((int64_t)((int64_t)((int32_t)((int32_t)L_5&(int32_t)((int32_t)127)))));
		// if (lengthBytes == 0)
		int64_t L_6 = V_2;
		if (L_6)
		{
			goto IL_002c;
		}
	}
	{
		// isIndefiniteLength = true;
		bool* L_7 = ___isIndefiniteLength1;
		*((int8_t*)L_7) = (int8_t)1;
		// return -2; // Indefinite length.
		return ((int64_t)((int64_t)((int32_t)-2)));
	}

IL_002c:
	{
		// length = 0;
		V_0 = ((int64_t)((int64_t)0));
		goto IL_004b;
	}

IL_0031:
	{
		// if ((length >> (8 * (4 - 1))) > 0) // 4: sizeof(long)
		int64_t L_8 = V_0;
		if ((((int64_t)((int64_t)((int64_t)L_8>>(int32_t)((int32_t)24)))) <= ((int64_t)((int64_t)((int64_t)0)))))
		{
			goto IL_003c;
		}
	}
	{
		// return -1; // Length overflow.
		return ((int64_t)((int64_t)(-1)));
	}

IL_003c:
	{
		// b = (byte)bt.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_9 = ___bt0;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_9);
		V_1 = (uint8_t)((int32_t)((uint8_t)L_10));
		// length = (length << 8) | b;
		int64_t L_11 = V_0;
		uint8_t L_12 = V_1;
		V_0 = ((int64_t)((int64_t)((int64_t)((int64_t)L_11<<(int32_t)8))|(int64_t)((int64_t)((uint64_t)L_12))));
	}

IL_004b:
	{
		// while (lengthBytes-- > 0)
		int64_t L_13 = V_2;
		int64_t L_14 = L_13;
		V_2 = ((int64_t)il2cpp_codegen_subtract((int64_t)L_14, (int64_t)((int64_t)((int64_t)1))));
		if ((((int64_t)L_14) > ((int64_t)((int64_t)((int64_t)0)))))
		{
			goto IL_0031;
		}
	}
	{
		// if (length <= 0x7f)
		int64_t L_15 = V_0;
		if ((((int64_t)L_15) > ((int64_t)((int64_t)((int64_t)((int32_t)127))))))
		{
			goto IL_005e;
		}
	}
	{
		// return -1; // Indicated false node
		return ((int64_t)((int64_t)(-1)));
	}

IL_005e:
	{
		// return length;
		int64_t L_16 = V_0;
		return L_16;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Asn1Util::GetTagName(System.Byte)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Asn1Util_GetTagName_m02927760E26BC5A39C7DBA088AE6427B24ADA73D (uint8_t ___tag0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral04E4C7E6115783DAF7E8E371EDC9AE581528EA78);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0524144B9F212F40BEC2750DD0C06E4159777384);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0AC347CF826668C4F33A1CD7ADF5419BAAE73FE0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral16DEBA0A49D8FDF8FFD3E681909ACA71D8132580);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1FA2E7519891D1B744F973A073D6CE50874854C6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3C71631187881B6DAB198AF4B06C779471926174);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral44D231DAD9D02BE301A8CF4FBCABD5DE1FDCFF54);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral481CFA1B155F22067D8FEA989EB269E873B62B4F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral52D13D434A39B045A12B8CCE2D63CFFAFE1972CF);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral67E6D858EA0BE7F6F1158A0A3EA4E4946B21A283);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral68E810E310A6E1368AC66300136C585E142E80BF);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral79C59A0C4D87BBB64A0C537CC6FCEBF8DE14A269);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral859BD87B9776D9CE86B7C752B95409950D61EB08);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral900D858FE9ABCD2ED2B25CD27110A78ADCC6EC6B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9CBE6269D7D5D08B76852D89B90B601BAD02D7DD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralAC35AB7561A701D96BD51BC1F1EE072F2F9718C0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralADF3402AEC14A5C5A7E1E8A624F7B7F4D2123EA0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB562730CA6FCD749B7C84DE73BEBD292D954C70E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB9DA3B4CA745F231A5F6D027DDCEE9158AC52CAE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBF403E6FC90C56524FFEE246E1374665DF60C2D6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC3C83DB7DD412566438B355E6504DBB01A12F5E4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCB4985E8F90C7FA1F0E650F37DD0D921D1BF99E6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCBDD70ED42B3745921307A6AF5729CDF0C49B732);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCEA206F53009B4409A8E1620933737D0F4D7E1B6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCF2AF9005B6B2A5DCC73C4E00CBE3F19D96687B4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCF61206F351943EEC77681D8FE9F32833CBE6444);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDC3FA34132F5B79C1EC6AD3AAAC2C6A5B7F29E34);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE1A854E69EA27FE94B3DD30F3C8F92D6E6560149);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE91195DA6E39E9A4D6BB7DBF2BF8A45CF0FB0A42);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF172F77C7E45F5898E6A62C11097CBEE26EBF4E1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF69C981860A19A82ADD9552E5DDAFA32BFD3D7B7);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF7906DC491A0486A30D111F231D1624CA5B94C94);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		// string retval = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// if ((tag & Asn1TagClasses.CLASS_MASK) != 0)
		uint8_t L_0 = ___tag0;
		if (!((int32_t)((int32_t)L_0&(int32_t)((int32_t)192))))
		{
			goto IL_00f6;
		}
	}
	{
		// switch (tag & Asn1TagClasses.CLASS_MASK)
		uint8_t L_1 = ___tag0;
		V_1 = ((int32_t)((int32_t)L_1&(int32_t)((int32_t)192)));
		int32_t L_2 = V_1;
		if ((((int32_t)L_2) > ((int32_t)((int32_t)32))))
		{
			goto IL_0032;
		}
	}
	{
		int32_t L_3 = V_1;
		if (!L_3)
		{
			goto IL_00d4;
		}
	}
	{
		int32_t L_4 = V_1;
		if ((((int32_t)L_4) == ((int32_t)((int32_t)32))))
		{
			goto IL_00b2;
		}
	}
	{
		goto IL_032b;
	}

IL_0032:
	{
		int32_t L_5 = V_1;
		if ((((int32_t)L_5) == ((int32_t)((int32_t)64))))
		{
			goto IL_006e;
		}
	}
	{
		int32_t L_6 = V_1;
		if ((((int32_t)L_6) == ((int32_t)((int32_t)128))))
		{
			goto IL_004c;
		}
	}
	{
		int32_t L_7 = V_1;
		if ((((int32_t)L_7) == ((int32_t)((int32_t)192))))
		{
			goto IL_0090;
		}
	}
	{
		goto IL_032b;
	}

IL_004c:
	{
		// retval += "CONTEXT SPECIFIC (" + ((int)(tag & Asn1Tag.TAG_MASK)).ToString() + ")";
		String_t* L_8 = V_0;
		uint8_t L_9 = ___tag0;
		V_2 = ((int32_t)((int32_t)L_9&(int32_t)((int32_t)31)));
		String_t* L_10;
		L_10 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_2), /*hidden argument*/NULL);
		String_t* L_11;
		L_11 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_8, _stringLiteral16DEBA0A49D8FDF8FFD3E681909ACA71D8132580, L_10, _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D, /*hidden argument*/NULL);
		V_0 = L_11;
		// break;
		goto IL_032b;
	}

IL_006e:
	{
		// retval += "APPLICATION (" + ((int)(tag & Asn1Tag.TAG_MASK)).ToString() + ")";
		String_t* L_12 = V_0;
		uint8_t L_13 = ___tag0;
		V_2 = ((int32_t)((int32_t)L_13&(int32_t)((int32_t)31)));
		String_t* L_14;
		L_14 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_2), /*hidden argument*/NULL);
		String_t* L_15;
		L_15 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_12, _stringLiteralDC3FA34132F5B79C1EC6AD3AAAC2C6A5B7F29E34, L_14, _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D, /*hidden argument*/NULL);
		V_0 = L_15;
		// break;
		goto IL_032b;
	}

IL_0090:
	{
		// retval += "PRIVATE (" + ((int)(tag & Asn1Tag.TAG_MASK)).ToString() + ")";
		String_t* L_16 = V_0;
		uint8_t L_17 = ___tag0;
		V_2 = ((int32_t)((int32_t)L_17&(int32_t)((int32_t)31)));
		String_t* L_18;
		L_18 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_2), /*hidden argument*/NULL);
		String_t* L_19;
		L_19 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_16, _stringLiteralE91195DA6E39E9A4D6BB7DBF2BF8A45CF0FB0A42, L_18, _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D, /*hidden argument*/NULL);
		V_0 = L_19;
		// break;
		goto IL_032b;
	}

IL_00b2:
	{
		// retval += "CONSTRUCTED (" + ((int)(tag & Asn1Tag.TAG_MASK)).ToString() + ")";
		String_t* L_20 = V_0;
		uint8_t L_21 = ___tag0;
		V_2 = ((int32_t)((int32_t)L_21&(int32_t)((int32_t)31)));
		String_t* L_22;
		L_22 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_2), /*hidden argument*/NULL);
		String_t* L_23;
		L_23 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_20, _stringLiteralF69C981860A19A82ADD9552E5DDAFA32BFD3D7B7, L_22, _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D, /*hidden argument*/NULL);
		V_0 = L_23;
		// break;
		goto IL_032b;
	}

IL_00d4:
	{
		// retval += "UNIVERSAL (" + ((int)(tag & Asn1Tag.TAG_MASK)).ToString() + ")";
		String_t* L_24 = V_0;
		uint8_t L_25 = ___tag0;
		V_2 = ((int32_t)((int32_t)L_25&(int32_t)((int32_t)31)));
		String_t* L_26;
		L_26 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_2), /*hidden argument*/NULL);
		String_t* L_27;
		L_27 = String_Concat_m37A5BF26F8F8F1892D60D727303B23FB604FEE78(L_24, _stringLiteral859BD87B9776D9CE86B7C752B95409950D61EB08, L_26, _stringLiteralB3F14BF976EFD974E34846B742502C802FABAE9D, /*hidden argument*/NULL);
		V_0 = L_27;
		// break;
		goto IL_032b;
	}

IL_00f6:
	{
		// switch (tag & Asn1Tag.TAG_MASK)
		uint8_t L_28 = ___tag0;
		V_1 = ((int32_t)((int32_t)L_28&(int32_t)((int32_t)31)));
		int32_t L_29 = V_1;
		switch (((int32_t)il2cpp_codegen_subtract((int32_t)L_29, (int32_t)1)))
		{
			case 0:
			{
				goto IL_0180;
			}
			case 1:
			{
				goto IL_0191;
			}
			case 2:
			{
				goto IL_01a2;
			}
			case 3:
			{
				goto IL_01b3;
			}
			case 4:
			{
				goto IL_01c4;
			}
			case 5:
			{
				goto IL_01d5;
			}
			case 6:
			{
				goto IL_01e6;
			}
			case 7:
			{
				goto IL_0208;
			}
			case 8:
			{
				goto IL_0219;
			}
			case 9:
			{
				goto IL_022a;
			}
			case 10:
			{
				goto IL_031f;
			}
			case 11:
			{
				goto IL_023b;
			}
			case 12:
			{
				goto IL_01f7;
			}
			case 13:
			{
				goto IL_031f;
			}
			case 14:
			{
				goto IL_031f;
			}
			case 15:
			{
				goto IL_024c;
			}
			case 16:
			{
				goto IL_025d;
			}
			case 17:
			{
				goto IL_026e;
			}
			case 18:
			{
				goto IL_027f;
			}
			case 19:
			{
				goto IL_0290;
			}
			case 20:
			{
				goto IL_02a1;
			}
			case 21:
			{
				goto IL_02af;
			}
			case 22:
			{
				goto IL_02bd;
			}
			case 23:
			{
				goto IL_02cb;
			}
			case 24:
			{
				goto IL_02d9;
			}
			case 25:
			{
				goto IL_02e7;
			}
			case 26:
			{
				goto IL_02f5;
			}
			case 27:
			{
				goto IL_0303;
			}
			case 28:
			{
				goto IL_031f;
			}
			case 29:
			{
				goto IL_0311;
			}
		}
	}
	{
		goto IL_031f;
	}

IL_0180:
	{
		// retval += "BOOLEAN";
		String_t* L_30 = V_0;
		String_t* L_31;
		L_31 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_30, _stringLiteralCF2AF9005B6B2A5DCC73C4E00CBE3F19D96687B4, /*hidden argument*/NULL);
		V_0 = L_31;
		// break;
		goto IL_032b;
	}

IL_0191:
	{
		// retval += "INTEGER";
		String_t* L_32 = V_0;
		String_t* L_33;
		L_33 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_32, _stringLiteralCB4985E8F90C7FA1F0E650F37DD0D921D1BF99E6, /*hidden argument*/NULL);
		V_0 = L_33;
		// break;
		goto IL_032b;
	}

IL_01a2:
	{
		// retval += "BIT STRING";
		String_t* L_34 = V_0;
		String_t* L_35;
		L_35 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_34, _stringLiteralBF403E6FC90C56524FFEE246E1374665DF60C2D6, /*hidden argument*/NULL);
		V_0 = L_35;
		// break;
		goto IL_032b;
	}

IL_01b3:
	{
		// retval += "OCTET STRING";
		String_t* L_36 = V_0;
		String_t* L_37;
		L_37 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_36, _stringLiteralB9DA3B4CA745F231A5F6D027DDCEE9158AC52CAE, /*hidden argument*/NULL);
		V_0 = L_37;
		// break;
		goto IL_032b;
	}

IL_01c4:
	{
		// retval += "NULL";
		String_t* L_38 = V_0;
		String_t* L_39;
		L_39 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_38, _stringLiteral900D858FE9ABCD2ED2B25CD27110A78ADCC6EC6B, /*hidden argument*/NULL);
		V_0 = L_39;
		// break;
		goto IL_032b;
	}

IL_01d5:
	{
		// retval += "OBJECT IDENTIFIER";
		String_t* L_40 = V_0;
		String_t* L_41;
		L_41 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_40, _stringLiteralCF61206F351943EEC77681D8FE9F32833CBE6444, /*hidden argument*/NULL);
		V_0 = L_41;
		// break;
		goto IL_032b;
	}

IL_01e6:
	{
		// retval += "OBJECT DESCRIPTOR";
		String_t* L_42 = V_0;
		String_t* L_43;
		L_43 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_42, _stringLiteral9CBE6269D7D5D08B76852D89B90B601BAD02D7DD, /*hidden argument*/NULL);
		V_0 = L_43;
		// break;
		goto IL_032b;
	}

IL_01f7:
	{
		// retval += "RELATIVE-OID";
		String_t* L_44 = V_0;
		String_t* L_45;
		L_45 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_44, _stringLiteral67E6D858EA0BE7F6F1158A0A3EA4E4946B21A283, /*hidden argument*/NULL);
		V_0 = L_45;
		// break;
		goto IL_032b;
	}

IL_0208:
	{
		// retval += "EXTERNAL";
		String_t* L_46 = V_0;
		String_t* L_47;
		L_47 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_46, _stringLiteral3C71631187881B6DAB198AF4B06C779471926174, /*hidden argument*/NULL);
		V_0 = L_47;
		// break;
		goto IL_032b;
	}

IL_0219:
	{
		// retval += "REAL";
		String_t* L_48 = V_0;
		String_t* L_49;
		L_49 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_48, _stringLiteralAC35AB7561A701D96BD51BC1F1EE072F2F9718C0, /*hidden argument*/NULL);
		V_0 = L_49;
		// break;
		goto IL_032b;
	}

IL_022a:
	{
		// retval += "ENUMERATED";
		String_t* L_50 = V_0;
		String_t* L_51;
		L_51 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_50, _stringLiteral79C59A0C4D87BBB64A0C537CC6FCEBF8DE14A269, /*hidden argument*/NULL);
		V_0 = L_51;
		// break;
		goto IL_032b;
	}

IL_023b:
	{
		// retval += "UTF8 STRING";
		String_t* L_52 = V_0;
		String_t* L_53;
		L_53 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_52, _stringLiteralCBDD70ED42B3745921307A6AF5729CDF0C49B732, /*hidden argument*/NULL);
		V_0 = L_53;
		// break;
		goto IL_032b;
	}

IL_024c:
	{
		// retval += "SEQUENCE";
		String_t* L_54 = V_0;
		String_t* L_55;
		L_55 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_54, _stringLiteral0AC347CF826668C4F33A1CD7ADF5419BAAE73FE0, /*hidden argument*/NULL);
		V_0 = L_55;
		// break;
		goto IL_032b;
	}

IL_025d:
	{
		// retval += "SET";
		String_t* L_56 = V_0;
		String_t* L_57;
		L_57 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_56, _stringLiteralADF3402AEC14A5C5A7E1E8A624F7B7F4D2123EA0, /*hidden argument*/NULL);
		V_0 = L_57;
		// break;
		goto IL_032b;
	}

IL_026e:
	{
		// retval += "NUMERIC STRING";
		String_t* L_58 = V_0;
		String_t* L_59;
		L_59 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_58, _stringLiteralF172F77C7E45F5898E6A62C11097CBEE26EBF4E1, /*hidden argument*/NULL);
		V_0 = L_59;
		// break;
		goto IL_032b;
	}

IL_027f:
	{
		// retval += "PRINTABLE STRING";
		String_t* L_60 = V_0;
		String_t* L_61;
		L_61 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_60, _stringLiteral52D13D434A39B045A12B8CCE2D63CFFAFE1972CF, /*hidden argument*/NULL);
		V_0 = L_61;
		// break;
		goto IL_032b;
	}

IL_0290:
	{
		// retval += "T61 STRING";
		String_t* L_62 = V_0;
		String_t* L_63;
		L_63 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_62, _stringLiteral68E810E310A6E1368AC66300136C585E142E80BF, /*hidden argument*/NULL);
		V_0 = L_63;
		// break;
		goto IL_032b;
	}

IL_02a1:
	{
		// retval += "VIDEOTEXT STRING";
		String_t* L_64 = V_0;
		String_t* L_65;
		L_65 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_64, _stringLiteralF7906DC491A0486A30D111F231D1624CA5B94C94, /*hidden argument*/NULL);
		V_0 = L_65;
		// break;
		goto IL_032b;
	}

IL_02af:
	{
		// retval += "IA5 STRING";
		String_t* L_66 = V_0;
		String_t* L_67;
		L_67 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_66, _stringLiteralE1A854E69EA27FE94B3DD30F3C8F92D6E6560149, /*hidden argument*/NULL);
		V_0 = L_67;
		// break;
		goto IL_032b;
	}

IL_02bd:
	{
		// retval += "UTC TIME";
		String_t* L_68 = V_0;
		String_t* L_69;
		L_69 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_68, _stringLiteralCEA206F53009B4409A8E1620933737D0F4D7E1B6, /*hidden argument*/NULL);
		V_0 = L_69;
		// break;
		goto IL_032b;
	}

IL_02cb:
	{
		// retval += "GENERALIZED TIME";
		String_t* L_70 = V_0;
		String_t* L_71;
		L_71 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_70, _stringLiteralC3C83DB7DD412566438B355E6504DBB01A12F5E4, /*hidden argument*/NULL);
		V_0 = L_71;
		// break;
		goto IL_032b;
	}

IL_02d9:
	{
		// retval += "GRAPHIC STRING";
		String_t* L_72 = V_0;
		String_t* L_73;
		L_73 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_72, _stringLiteral1FA2E7519891D1B744F973A073D6CE50874854C6, /*hidden argument*/NULL);
		V_0 = L_73;
		// break;
		goto IL_032b;
	}

IL_02e7:
	{
		// retval += "VISIBLE STRING";
		String_t* L_74 = V_0;
		String_t* L_75;
		L_75 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_74, _stringLiteral0524144B9F212F40BEC2750DD0C06E4159777384, /*hidden argument*/NULL);
		V_0 = L_75;
		// break;
		goto IL_032b;
	}

IL_02f5:
	{
		// retval += "GENERAL STRING";
		String_t* L_76 = V_0;
		String_t* L_77;
		L_77 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_76, _stringLiteral481CFA1B155F22067D8FEA989EB269E873B62B4F, /*hidden argument*/NULL);
		V_0 = L_77;
		// break;
		goto IL_032b;
	}

IL_0303:
	{
		// retval += "UNIVERSAL STRING";
		String_t* L_78 = V_0;
		String_t* L_79;
		L_79 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_78, _stringLiteral04E4C7E6115783DAF7E8E371EDC9AE581528EA78, /*hidden argument*/NULL);
		V_0 = L_79;
		// break;
		goto IL_032b;
	}

IL_0311:
	{
		// retval += "BMP STRING";
		String_t* L_80 = V_0;
		String_t* L_81;
		L_81 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_80, _stringLiteral44D231DAD9D02BE301A8CF4FBCABD5DE1FDCFF54, /*hidden argument*/NULL);
		V_0 = L_81;
		// break;
		goto IL_032b;
	}

IL_031f:
	{
		// retval += "UNKNOWN TAG";
		String_t* L_82 = V_0;
		String_t* L_83;
		L_83 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_82, _stringLiteralB562730CA6FCD749B7C84DE73BEBD292D954C70E, /*hidden argument*/NULL);
		V_0 = L_83;
	}

IL_032b:
	{
		// return retval;
		String_t* L_84 = V_0;
		return L_84;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Asn1Util::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Asn1Util__cctor_mBA45AB145D42C3AC984E97EED7947121760E1785 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CPrivateImplementationDetailsU3E_tD58C289ECB60EF91D67519C579A83B4F9F1364B0____2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0_FieldInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// static char[] hexDigits = { '0', '1', '2', '3', '4', '5', '6', '7',
		//                             '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_0 = (CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34*)SZArrayNew(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34_il2cpp_TypeInfo_var, (uint32_t)((int32_t)16));
		CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* L_1 = L_0;
		RuntimeFieldHandle_t7BE65FC857501059EBAC9772C93B02CD413D9C96  L_2 = { reinterpret_cast<intptr_t> (U3CPrivateImplementationDetailsU3E_tD58C289ECB60EF91D67519C579A83B4F9F1364B0____2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70_0_FieldInfo_var) };
		RuntimeHelpers_InitializeArray_mE27238308FED781F2D6A719F0903F2E1311B058F((RuntimeArray *)(RuntimeArray *)L_1, L_2, /*hidden argument*/NULL);
		((Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_StaticFields*)il2cpp_codegen_static_fields_for(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var))->set_hexDigits_0(L_1);
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
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_Country()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Country_m7428D857116758C8131C1A89D0ECBD9300257478 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string Country { get; set; }
		String_t* L_0 = __this->get_U3CCountryU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_Country(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName_set_Country_m5FEE9E1CA4B8090244EFC4C035C4B602B5812FF0 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string Country { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CCountryU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_Organization()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Organization_m7099D111E9B3D9F4EBA74CFE022080B6AF2E4571 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string Organization { get; set; }
		String_t* L_0 = __this->get_U3COrganizationU3Ek__BackingField_1();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_Organization(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName_set_Organization_mE46F109C4F90063C1424156D4A82676305D1FC68 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string Organization { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3COrganizationU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_OrganizationalUnit()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_OrganizationalUnit_mA770C2BF2D42EFBC103C06EE7D2196C6977CA499 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string OrganizationalUnit { get; set; }
		String_t* L_0 = __this->get_U3COrganizationalUnitU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_OrganizationalUnit(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName_set_OrganizationalUnit_mF45FFA1898130492704A1D74B8A2D3381553A874 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string OrganizationalUnit { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3COrganizationalUnitU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_Dnq()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Dnq_mF2BDB440F23D8D256304AD7385170B20823E7E40 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string Dnq { get; set; }
		String_t* L_0 = __this->get_U3CDnqU3Ek__BackingField_3();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_Dnq(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName_set_Dnq_m5804E8D6845E922F9E4ABA254387CCA4BB2EF63D (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string Dnq { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CDnqU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_State()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_State_mB6E45565C187F37F8AA400B6126A3DDB7F8964F4 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string State { get; set; }
		String_t* L_0 = __this->get_U3CStateU3Ek__BackingField_4();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_State(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName_set_State_mD31D1EC2DB9AF12BB9C27511CDA0E1B2381BC0E6 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string State { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CStateU3Ek__BackingField_4(L_0);
		return;
	}
}
// System.String UnityEngine.Purchasing.Security.DistinguishedName::get_CommonName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_CommonName_mF8E6F3B5D8AC9A1DBCBD08F7F9BF5445B61676A1 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string CommonName { get; set; }
		String_t* L_0 = __this->get_U3CCommonNameU3Ek__BackingField_5();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_CommonName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName_set_CommonName_m699DA7948C7C23CB270E88A56453A54B826A7197 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string CommonName { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CCommonNameU3Ek__BackingField_5(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::set_SerialNumber(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName_set_SerialNumber_m4BC141696476B8DCD83E21BC78F3CA5A57316B74 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string SerialNumber { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CSerialNumberU3Ek__BackingField_6(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.DistinguishedName::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DistinguishedName__ctor_m88B417EEFA420272B08355F1369DBDAA71532886 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral14D13302CA125B23FDC663B73325C42B8DA4C1EB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1A7FC08E8EB016BAD5A8A8D7B3447DAD63E867BC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral453A07B8CC155ECBEB68D277EC848642FFB5F3B6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral94227CA8EB4252C21E39FE8CCB2B65A6D01D3CF1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral99C134A36D015746C32203B98CC495F87311D9DC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDD381BE73F585C3796C220566E891E458F9D6290);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF24BCEBD3BF54143DC34399B1E3AD4F93496E764);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_1 = NULL;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_2 = NULL;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_3 = NULL;
	String_t* V_4 = NULL;
	UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * V_5 = NULL;
	uint32_t V_6 = 0;
	{
		// public DistinguishedName(Asn1Node n)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// if (n.MaskedTag == Asn1Tag.SEQUENCE)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___n0;
		NullCheck(L_0);
		uint8_t L_1;
		L_1 = Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4(L_0, /*hidden argument*/NULL);
		if ((!(((uint32_t)L_1) == ((uint32_t)((int32_t)16)))))
		{
			goto IL_0267;
		}
	}
	{
		// for (int i = 0; i < n.ChildNodeCount; i++)
		V_0 = 0;
		goto IL_025a;
	}

IL_001a:
	{
		// Asn1Node tt = n.GetChildNode(i);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = ___n0;
		int32_t L_3 = V_0;
		NullCheck(L_2);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4;
		L_4 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_2, L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		// if (tt.MaskedTag != Asn1Tag.SET || tt.ChildNodeCount != 1)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5 = V_1;
		NullCheck(L_5);
		uint8_t L_6;
		L_6 = Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4(L_5, /*hidden argument*/NULL);
		if ((!(((uint32_t)L_6) == ((uint32_t)((int32_t)17)))))
		{
			goto IL_0036;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_7 = V_1;
		NullCheck(L_7);
		int64_t L_8;
		L_8 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_7, /*hidden argument*/NULL);
		if ((((int64_t)L_8) == ((int64_t)((int64_t)((int64_t)1)))))
		{
			goto IL_003c;
		}
	}

IL_0036:
	{
		// throw new InvalidX509Data();
		InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * L_9 = (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA_il2cpp_TypeInfo_var)));
		InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E(L_9, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_9, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&DistinguishedName__ctor_m88B417EEFA420272B08355F1369DBDAA71532886_RuntimeMethod_var)));
	}

IL_003c:
	{
		// tt = tt.GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_10 = V_1;
		NullCheck(L_10);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_11;
		L_11 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_10, 0, /*hidden argument*/NULL);
		V_1 = L_11;
		// if (tt.MaskedTag != Asn1Tag.SEQUENCE || tt.ChildNodeCount != 2)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_12 = V_1;
		NullCheck(L_12);
		uint8_t L_13;
		L_13 = Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4(L_12, /*hidden argument*/NULL);
		if ((!(((uint32_t)L_13) == ((uint32_t)((int32_t)16)))))
		{
			goto IL_0058;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_14 = V_1;
		NullCheck(L_14);
		int64_t L_15;
		L_15 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_14, /*hidden argument*/NULL);
		if ((((int64_t)L_15) == ((int64_t)((int64_t)((int64_t)2)))))
		{
			goto IL_005e;
		}
	}

IL_0058:
	{
		// throw new InvalidX509Data();
		InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * L_16 = (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA_il2cpp_TypeInfo_var)));
		InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E(L_16, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_16, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&DistinguishedName__ctor_m88B417EEFA420272B08355F1369DBDAA71532886_RuntimeMethod_var)));
	}

IL_005e:
	{
		// Asn1Node oi = tt.GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_17 = V_1;
		NullCheck(L_17);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_18;
		L_18 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_17, 0, /*hidden argument*/NULL);
		V_2 = L_18;
		// Asn1Node txt = tt.GetChildNode(1);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_19 = V_1;
		NullCheck(L_19);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_20;
		L_20 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_19, 1, /*hidden argument*/NULL);
		V_3 = L_20;
		// if (oi.MaskedTag != Asn1Tag.OBJECT_IDENTIFIER ||
		//     !(
		//         (txt.MaskedTag == Asn1Tag.PRINTABLE_STRING) ||
		//         (txt.MaskedTag == Asn1Tag.UTF8_STRING) ||
		//         (txt.MaskedTag == Asn1Tag.IA5_STRING)))
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_21 = V_2;
		NullCheck(L_21);
		uint8_t L_22;
		L_22 = Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4(L_21, /*hidden argument*/NULL);
		if ((!(((uint32_t)L_22) == ((uint32_t)6))))
		{
			goto IL_0095;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_23 = V_3;
		NullCheck(L_23);
		uint8_t L_24;
		L_24 = Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4(L_23, /*hidden argument*/NULL);
		if ((((int32_t)L_24) == ((int32_t)((int32_t)19))))
		{
			goto IL_009b;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_25 = V_3;
		NullCheck(L_25);
		uint8_t L_26;
		L_26 = Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4(L_25, /*hidden argument*/NULL);
		if ((((int32_t)L_26) == ((int32_t)((int32_t)12))))
		{
			goto IL_009b;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_27 = V_3;
		NullCheck(L_27);
		uint8_t L_28;
		L_28 = Asn1Node_get_MaskedTag_mCA3FB7F0BC2DD8D1E568C8BC01483950EF1631B4(L_27, /*hidden argument*/NULL);
		if ((((int32_t)L_28) == ((int32_t)((int32_t)22))))
		{
			goto IL_009b;
		}
	}

IL_0095:
	{
		// throw new InvalidX509Data();
		InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * L_29 = (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA_il2cpp_TypeInfo_var)));
		InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E(L_29, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_29, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&DistinguishedName__ctor_m88B417EEFA420272B08355F1369DBDAA71532886_RuntimeMethod_var)));
	}

IL_009b:
	{
		// var xoid = new LipingShare.LCLib.Asn1Processor.Oid();
		Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * L_30 = (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D *)il2cpp_codegen_object_new(Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var);
		Oid__ctor_m5F73190FA2302798601F2B61863F12363DF5E843(L_30, /*hidden argument*/NULL);
		// string oiName = xoid.Decode(oi.Data);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_31 = V_2;
		NullCheck(L_31);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_32;
		L_32 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_31, /*hidden argument*/NULL);
		NullCheck(L_30);
		String_t* L_33;
		L_33 = Oid_Decode_m645A8CFA1369387AA5638099EDE5EFBD2B0A7DC1(L_30, L_32, /*hidden argument*/NULL);
		V_4 = L_33;
		// var enc = new System.Text.UTF8Encoding();
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_34 = (UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 *)il2cpp_codegen_object_new(UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		UTF8Encoding__ctor_mA3F21D41B65D155202345802A05761A4BC022888(L_34, /*hidden argument*/NULL);
		V_5 = L_34;
		String_t* L_35 = V_4;
		if (!L_35)
		{
			goto IL_0256;
		}
	}
	{
		String_t* L_36 = V_4;
		uint32_t L_37;
		L_37 = U3CPrivateImplementationDetailsU3E_ComputeStringHash_mF5324EA33B0E55B4570D0EF8DA5A0FCB25E6ECA4(L_36, /*hidden argument*/NULL);
		V_6 = L_37;
		uint32_t L_38 = V_6;
		if ((!(((uint32_t)L_38) <= ((uint32_t)((int32_t)184344010)))))
		{
			goto IL_00f3;
		}
	}
	{
		uint32_t L_39 = V_6;
		if ((((int32_t)L_39) == ((int32_t)((int32_t)134011153))))
		{
			goto IL_016f;
		}
	}
	{
		uint32_t L_40 = V_6;
		if ((((int32_t)L_40) == ((int32_t)((int32_t)167566391))))
		{
			goto IL_0185;
		}
	}
	{
		uint32_t L_41 = V_6;
		if ((((int32_t)L_41) == ((int32_t)((int32_t)184344010))))
		{
			goto IL_012d;
		}
	}
	{
		goto IL_0256;
	}

IL_00f3:
	{
		uint32_t L_42 = V_6;
		if ((!(((uint32_t)L_42) <= ((uint32_t)((int32_t)1208264641)))))
		{
			goto IL_0113;
		}
	}
	{
		uint32_t L_43 = V_6;
		if ((((int32_t)L_43) == ((int32_t)((int32_t)1191487022))))
		{
			goto IL_0159;
		}
	}
	{
		uint32_t L_44 = V_6;
		if ((((int32_t)L_44) == ((int32_t)((int32_t)1208264641))))
		{
			goto IL_0143;
		}
	}
	{
		goto IL_0256;
	}

IL_0113:
	{
		uint32_t L_45 = V_6;
		if ((((int32_t)L_45) == ((int32_t)((int32_t)-1207168042))))
		{
			goto IL_019b;
		}
	}
	{
		uint32_t L_46 = V_6;
		if ((((int32_t)L_46) == ((int32_t)((int32_t)-50542656))))
		{
			goto IL_01b1;
		}
	}
	{
		goto IL_0256;
	}

IL_012d:
	{
		String_t* L_47 = V_4;
		bool L_48;
		L_48 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_47, _stringLiteral453A07B8CC155ECBEB68D277EC848642FFB5F3B6, /*hidden argument*/NULL);
		if (L_48)
		{
			goto IL_01c7;
		}
	}
	{
		goto IL_0256;
	}

IL_0143:
	{
		String_t* L_49 = V_4;
		bool L_50;
		L_50 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_49, _stringLiteralDD381BE73F585C3796C220566E891E458F9D6290, /*hidden argument*/NULL);
		if (L_50)
		{
			goto IL_01dc;
		}
	}
	{
		goto IL_0256;
	}

IL_0159:
	{
		String_t* L_51 = V_4;
		bool L_52;
		L_52 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_51, _stringLiteral99C134A36D015746C32203B98CC495F87311D9DC, /*hidden argument*/NULL);
		if (L_52)
		{
			goto IL_01f1;
		}
	}
	{
		goto IL_0256;
	}

IL_016f:
	{
		String_t* L_53 = V_4;
		bool L_54;
		L_54 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_53, _stringLiteral94227CA8EB4252C21E39FE8CCB2B65A6D01D3CF1, /*hidden argument*/NULL);
		if (L_54)
		{
			goto IL_0206;
		}
	}
	{
		goto IL_0256;
	}

IL_0185:
	{
		String_t* L_55 = V_4;
		bool L_56;
		L_56 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_55, _stringLiteralF24BCEBD3BF54143DC34399B1E3AD4F93496E764, /*hidden argument*/NULL);
		if (L_56)
		{
			goto IL_021b;
		}
	}
	{
		goto IL_0256;
	}

IL_019b:
	{
		String_t* L_57 = V_4;
		bool L_58;
		L_58 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_57, _stringLiteral14D13302CA125B23FDC663B73325C42B8DA4C1EB, /*hidden argument*/NULL);
		if (L_58)
		{
			goto IL_022e;
		}
	}
	{
		goto IL_0256;
	}

IL_01b1:
	{
		String_t* L_59 = V_4;
		bool L_60;
		L_60 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_59, _stringLiteral1A7FC08E8EB016BAD5A8A8D7B3447DAD63E867BC, /*hidden argument*/NULL);
		if (L_60)
		{
			goto IL_0243;
		}
	}
	{
		goto IL_0256;
	}

IL_01c7:
	{
		// Country = enc.GetString(txt.Data);
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_61 = V_5;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_62 = V_3;
		NullCheck(L_62);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_63;
		L_63 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_62, /*hidden argument*/NULL);
		NullCheck(L_61);
		String_t* L_64;
		L_64 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_61, L_63);
		DistinguishedName_set_Country_m5FEE9E1CA4B8090244EFC4C035C4B602B5812FF0_inline(__this, L_64, /*hidden argument*/NULL);
		// break;
		goto IL_0256;
	}

IL_01dc:
	{
		// Organization = enc.GetString(txt.Data);
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_65 = V_5;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_66 = V_3;
		NullCheck(L_66);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_67;
		L_67 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_66, /*hidden argument*/NULL);
		NullCheck(L_65);
		String_t* L_68;
		L_68 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_65, L_67);
		DistinguishedName_set_Organization_mE46F109C4F90063C1424156D4A82676305D1FC68_inline(__this, L_68, /*hidden argument*/NULL);
		// break;
		goto IL_0256;
	}

IL_01f1:
	{
		// OrganizationalUnit = enc.GetString(txt.Data);
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_69 = V_5;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_70 = V_3;
		NullCheck(L_70);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_71;
		L_71 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_70, /*hidden argument*/NULL);
		NullCheck(L_69);
		String_t* L_72;
		L_72 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_69, L_71);
		DistinguishedName_set_OrganizationalUnit_mF45FFA1898130492704A1D74B8A2D3381553A874_inline(__this, L_72, /*hidden argument*/NULL);
		// break;
		goto IL_0256;
	}

IL_0206:
	{
		// CommonName = enc.GetString(txt.Data);
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_73 = V_5;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_74 = V_3;
		NullCheck(L_74);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_75;
		L_75 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_74, /*hidden argument*/NULL);
		NullCheck(L_73);
		String_t* L_76;
		L_76 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_73, L_75);
		DistinguishedName_set_CommonName_m699DA7948C7C23CB270E88A56453A54B826A7197_inline(__this, L_76, /*hidden argument*/NULL);
		// break;
		goto IL_0256;
	}

IL_021b:
	{
		// SerialNumber = Asn1Util.ToHexString(txt.Data);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_77 = V_3;
		NullCheck(L_77);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_78;
		L_78 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_77, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_79;
		L_79 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_78, /*hidden argument*/NULL);
		DistinguishedName_set_SerialNumber_m4BC141696476B8DCD83E21BC78F3CA5A57316B74_inline(__this, L_79, /*hidden argument*/NULL);
		// break;
		goto IL_0256;
	}

IL_022e:
	{
		// Dnq = enc.GetString(txt.Data);
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_80 = V_5;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_81 = V_3;
		NullCheck(L_81);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_82;
		L_82 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_81, /*hidden argument*/NULL);
		NullCheck(L_80);
		String_t* L_83;
		L_83 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_80, L_82);
		DistinguishedName_set_Dnq_m5804E8D6845E922F9E4ABA254387CCA4BB2EF63D_inline(__this, L_83, /*hidden argument*/NULL);
		// break;
		goto IL_0256;
	}

IL_0243:
	{
		// State = enc.GetString(txt.Data);
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_84 = V_5;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_85 = V_3;
		NullCheck(L_85);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_86;
		L_86 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_85, /*hidden argument*/NULL);
		NullCheck(L_84);
		String_t* L_87;
		L_87 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_84, L_86);
		DistinguishedName_set_State_mD31D1EC2DB9AF12BB9C27511CDA0E1B2381BC0E6_inline(__this, L_87, /*hidden argument*/NULL);
	}

IL_0256:
	{
		// for (int i = 0; i < n.ChildNodeCount; i++)
		int32_t L_88 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_88, (int32_t)1));
	}

IL_025a:
	{
		// for (int i = 0; i < n.ChildNodeCount; i++)
		int32_t L_89 = V_0;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_90 = ___n0;
		NullCheck(L_90);
		int64_t L_91;
		L_91 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_90, /*hidden argument*/NULL);
		if ((((int64_t)((int64_t)((int64_t)L_89))) < ((int64_t)L_91)))
		{
			goto IL_001a;
		}
	}

IL_0267:
	{
		// }
		return;
	}
}
// System.Boolean UnityEngine.Purchasing.Security.DistinguishedName::Equals(UnityEngine.Purchasing.Security.DistinguishedName)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool DistinguishedName_Equals_mFFA3F3D4A6FADBEB7B9FF6BDC988D48D346A13D4 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___n20, const RuntimeMethod* method)
{
	{
		// return this.Organization == n2.Organization &&
		//     this.OrganizationalUnit == n2.OrganizationalUnit &&
		//     this.Dnq == n2.Dnq &&
		//     this.Country == n2.Country &&
		//     this.State == n2.State &&
		//     this.CommonName == n2.CommonName;
		String_t* L_0;
		L_0 = DistinguishedName_get_Organization_m7099D111E9B3D9F4EBA74CFE022080B6AF2E4571_inline(__this, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_1 = ___n20;
		NullCheck(L_1);
		String_t* L_2;
		L_2 = DistinguishedName_get_Organization_m7099D111E9B3D9F4EBA74CFE022080B6AF2E4571_inline(L_1, /*hidden argument*/NULL);
		bool L_3;
		L_3 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_0, L_2, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0071;
		}
	}
	{
		String_t* L_4;
		L_4 = DistinguishedName_get_OrganizationalUnit_mA770C2BF2D42EFBC103C06EE7D2196C6977CA499_inline(__this, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_5 = ___n20;
		NullCheck(L_5);
		String_t* L_6;
		L_6 = DistinguishedName_get_OrganizationalUnit_mA770C2BF2D42EFBC103C06EE7D2196C6977CA499_inline(L_5, /*hidden argument*/NULL);
		bool L_7;
		L_7 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_4, L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0071;
		}
	}
	{
		String_t* L_8;
		L_8 = DistinguishedName_get_Dnq_mF2BDB440F23D8D256304AD7385170B20823E7E40_inline(__this, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_9 = ___n20;
		NullCheck(L_9);
		String_t* L_10;
		L_10 = DistinguishedName_get_Dnq_mF2BDB440F23D8D256304AD7385170B20823E7E40_inline(L_9, /*hidden argument*/NULL);
		bool L_11;
		L_11 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_8, L_10, /*hidden argument*/NULL);
		if (!L_11)
		{
			goto IL_0071;
		}
	}
	{
		String_t* L_12;
		L_12 = DistinguishedName_get_Country_m7428D857116758C8131C1A89D0ECBD9300257478_inline(__this, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_13 = ___n20;
		NullCheck(L_13);
		String_t* L_14;
		L_14 = DistinguishedName_get_Country_m7428D857116758C8131C1A89D0ECBD9300257478_inline(L_13, /*hidden argument*/NULL);
		bool L_15;
		L_15 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_12, L_14, /*hidden argument*/NULL);
		if (!L_15)
		{
			goto IL_0071;
		}
	}
	{
		String_t* L_16;
		L_16 = DistinguishedName_get_State_mB6E45565C187F37F8AA400B6126A3DDB7F8964F4_inline(__this, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_17 = ___n20;
		NullCheck(L_17);
		String_t* L_18;
		L_18 = DistinguishedName_get_State_mB6E45565C187F37F8AA400B6126A3DDB7F8964F4_inline(L_17, /*hidden argument*/NULL);
		bool L_19;
		L_19 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_16, L_18, /*hidden argument*/NULL);
		if (!L_19)
		{
			goto IL_0071;
		}
	}
	{
		String_t* L_20;
		L_20 = DistinguishedName_get_CommonName_mF8E6F3B5D8AC9A1DBCBD08F7F9BF5445B61676A1_inline(__this, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_21 = ___n20;
		NullCheck(L_21);
		String_t* L_22;
		L_22 = DistinguishedName_get_CommonName_mF8E6F3B5D8AC9A1DBCBD08F7F9BF5445B61676A1_inline(L_21, /*hidden argument*/NULL);
		bool L_23;
		L_23 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_20, L_22, /*hidden argument*/NULL);
		return L_23;
	}

IL_0071:
	{
		return (bool)0;
	}
}
// System.String UnityEngine.Purchasing.Security.DistinguishedName::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* DistinguishedName_ToString_m1F1E20BC856E6703FEF00B57D4AE2F4785B1EFE7 (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral31EFAEEDBC2BB686A5ABA0098A7A45FCE86FBD8A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralADADD3B05013D84B886E96640AA7F89AF39D5AD6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDCACA63FC238CCA8ED535F7BFAF590FC831D8832);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEFE5B4EE3917FFFE8F93D31E5E798F2A968F3FC6);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return "CN: " + CommonName + "\n" +
		//     "ON: " + Organization + "\n" +
		//     "Unit Name: " + OrganizationalUnit + "\n" +
		//     "Country: " + Country;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_0 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)8);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_1 = L_0;
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, _stringLiteral31EFAEEDBC2BB686A5ABA0098A7A45FCE86FBD8A);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteral31EFAEEDBC2BB686A5ABA0098A7A45FCE86FBD8A);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_2 = L_1;
		String_t* L_3;
		L_3 = DistinguishedName_get_CommonName_mF8E6F3B5D8AC9A1DBCBD08F7F9BF5445B61676A1_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_2);
		ArrayElementTypeCheck (L_2, L_3);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_3);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_4 = L_2;
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, _stringLiteralDCACA63FC238CCA8ED535F7BFAF590FC831D8832);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteralDCACA63FC238CCA8ED535F7BFAF590FC831D8832);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_5 = L_4;
		String_t* L_6;
		L_6 = DistinguishedName_get_Organization_m7099D111E9B3D9F4EBA74CFE022080B6AF2E4571_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_6);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_7 = L_5;
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, _stringLiteralEFE5B4EE3917FFFE8F93D31E5E798F2A968F3FC6);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteralEFE5B4EE3917FFFE8F93D31E5E798F2A968F3FC6);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_8 = L_7;
		String_t* L_9;
		L_9 = DistinguishedName_get_OrganizationalUnit_mA770C2BF2D42EFBC103C06EE7D2196C6977CA499_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_8);
		ArrayElementTypeCheck (L_8, L_9);
		(L_8)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)L_9);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_10 = L_8;
		NullCheck(L_10);
		ArrayElementTypeCheck (L_10, _stringLiteralADADD3B05013D84B886E96640AA7F89AF39D5AD6);
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(6), (String_t*)_stringLiteralADADD3B05013D84B886E96640AA7F89AF39D5AD6);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_11 = L_10;
		String_t* L_12;
		L_12 = DistinguishedName_get_Country_m7428D857116758C8131C1A89D0ECBD9300257478_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, L_12);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(7), (String_t*)L_12);
		String_t* L_13;
		L_13 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_11, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.Security.InvalidPKCS7Data::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1 (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * __this, const RuntimeMethod* method)
{
	{
		IAPSecurityException__ctor_mFFF023188A2BB47A715BCEAF3B94F31370D77680(__this, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.Security.InvalidRSAData::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidRSAData__ctor_m7FD4D1595A630A2C0D68DF36C9E9E383262C056C (InvalidRSAData_t7936FA4BD4B05A86337546B43ED2197E49D4EFF7 * __this, const RuntimeMethod* method)
{
	{
		IAPSecurityException__ctor_mFFF023188A2BB47A715BCEAF3B94F31370D77680(__this, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.Security.InvalidTimeFormat::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidTimeFormat__ctor_m2EA54FD5CEBC3F2494069A8E58329417DBFD4FFA (InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428 * __this, const RuntimeMethod* method)
{
	{
		IAPSecurityException__ctor_mFFF023188A2BB47A715BCEAF3B94F31370D77680(__this, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.Security.InvalidX509Data::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * __this, const RuntimeMethod* method)
{
	{
		IAPSecurityException__ctor_mFFF023188A2BB47A715BCEAF3B94F31370D77680(__this, /*hidden argument*/NULL);
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
// System.String LipingShare.LCLib.Asn1Processor.Oid::GetOidName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Oid_GetOidName_mF1BA27FF9C294059635716F0A23C27D63C69698B (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, String_t* ___inOidStr0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (oidDictionary == null) //Initialize oidDictionary:
		StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 * L_0 = ((Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_StaticFields*)il2cpp_codegen_static_fields_for(Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var))->get_oidDictionary_0();
		if (L_0)
		{
			goto IL_0011;
		}
	}
	{
		// oidDictionary = new StringDictionary();
		StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 * L_1 = (StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 *)il2cpp_codegen_object_new(StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79_il2cpp_TypeInfo_var);
		StringDictionary__ctor_mEA16941AB5C9CDBEE3B0572E3FA74DD1CC0C8637(L_1, /*hidden argument*/NULL);
		((Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_StaticFields*)il2cpp_codegen_static_fields_for(Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var))->set_oidDictionary_0(L_1);
	}

IL_0011:
	{
		// return oidDictionary[inOidStr];
		StringDictionary_t0E59841BF2F9514E354A1DF32028F3EF79535E79 * L_2 = ((Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_StaticFields*)il2cpp_codegen_static_fields_for(Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D_il2cpp_TypeInfo_var))->get_oidDictionary_0();
		String_t* L_3 = ___inOidStr0;
		NullCheck(L_2);
		String_t* L_4;
		L_4 = VirtFuncInvoker1< String_t*, String_t* >::Invoke(7 /* System.String System.Collections.Specialized.StringDictionary::get_Item(System.String) */, L_2, L_3);
		return L_4;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Oid::Decode(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Oid_Decode_m645A8CFA1369387AA5638099EDE5EFBD2B0A7DC1 (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___data0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * V_0 = NULL;
	{
		// MemoryStream ms = new MemoryStream(data);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = ___data0;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_1 = (MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C *)il2cpp_codegen_object_new(MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C_il2cpp_TypeInfo_var);
		MemoryStream__ctor_m3E041ADD3DB7EA42E7DB56FE862097819C02B9C2(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		// ms.Position = 0;
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_2 = V_0;
		NullCheck(L_2);
		VirtActionInvoker1< int64_t >::Invoke(14 /* System.Void System.IO.Stream::set_Position(System.Int64) */, L_2, ((int64_t)((int64_t)0)));
		// string retval = Decode(ms);
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_3 = V_0;
		String_t* L_4;
		L_4 = VirtFuncInvoker1< String_t*, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * >::Invoke(4 /* System.String LipingShare.LCLib.Asn1Processor.Oid::Decode(System.IO.Stream) */, __this, L_3);
		// ms.Close();
		MemoryStream_t0B450399DD6D0175074FED99DD321D65771C9E1C * L_5 = V_0;
		NullCheck(L_5);
		VirtActionInvoker0::Invoke(21 /* System.Void System.IO.Stream::Close() */, L_5);
		// return retval;
		return L_4;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.Oid::Decode(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Oid_Decode_m419D782F9974D3FB801A90E8F01B965E3786DC09 (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___bt0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	uint8_t V_1 = 0x0;
	uint64_t V_2 = 0;
	Exception_t * V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// string retval = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// ulong v = 0;
		V_2 = ((int64_t)((int64_t)0));
		// b = (byte)bt.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___bt0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_0);
		V_1 = (uint8_t)((int32_t)((uint8_t)L_1));
		// retval += Convert.ToString(b / 40);
		String_t* L_2 = V_0;
		uint8_t L_3 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		String_t* L_4;
		L_4 = Convert_ToString_m591519A05955A00954A48E0EA3F5CB9921C13969(((int32_t)((int32_t)L_3/(int32_t)((int32_t)40))), /*hidden argument*/NULL);
		String_t* L_5;
		L_5 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_2, L_4, /*hidden argument*/NULL);
		V_0 = L_5;
		// retval += "." + Convert.ToString(b % 40);
		String_t* L_6 = V_0;
		uint8_t L_7 = V_1;
		String_t* L_8;
		L_8 = Convert_ToString_m591519A05955A00954A48E0EA3F5CB9921C13969(((int32_t)((int32_t)L_7%(int32_t)((int32_t)40))), /*hidden argument*/NULL);
		String_t* L_9;
		L_9 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_6, _stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D, L_8, /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_006f;
	}

IL_0038:
	{
	}

IL_0039:
	try
	{ // begin try (depth: 1)
		// DecodeValue(bt, ref v);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_10 = ___bt0;
		int32_t L_11;
		L_11 = Oid_DecodeValue_m319B938E419AD61DA32F9D0E7191FF2815B55DD8(__this, L_10, (uint64_t*)(&V_2), /*hidden argument*/NULL);
		// retval += "." + v.ToString();
		String_t* L_12 = V_0;
		String_t* L_13;
		L_13 = UInt64_ToString_m3644686F0A0E32CB94D300CF891DBD7920396F37((uint64_t*)(&V_2), /*hidden argument*/NULL);
		String_t* L_14;
		L_14 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_12, _stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D, L_13, /*hidden argument*/NULL);
		V_0 = L_14;
		// }
		goto IL_006f;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0058;
		}
		throw e;
	}

CATCH_0058:
	{ // begin catch(System.Exception)
		// catch (Exception e)
		V_3 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		// throw new Exception("Failed to decode OID value: " + e.Message);
		Exception_t * L_15 = V_3;
		NullCheck(L_15);
		String_t* L_16;
		L_16 = VirtFuncInvoker0< String_t* >::Invoke(19 /* System.String System.Exception::get_Message() */, L_15);
		String_t* L_17;
		L_17 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralAE82977104FE357F4C1CE6D6A3DFD58AFEBFC641)), L_16, /*hidden argument*/NULL);
		Exception_t * L_18 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_18, L_17, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_18, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Oid_Decode_m419D782F9974D3FB801A90E8F01B965E3786DC09_RuntimeMethod_var)));
	} // end catch (depth: 1)

IL_006f:
	{
		// while (bt.Position < bt.Length)
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_19 = ___bt0;
		NullCheck(L_19);
		int64_t L_20;
		L_20 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_19);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_21 = ___bt0;
		NullCheck(L_21);
		int64_t L_22;
		L_22 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_21);
		if ((((int64_t)L_20) < ((int64_t)L_22)))
		{
			goto IL_0038;
		}
	}
	{
		// return retval;
		String_t* L_23 = V_0;
		return L_23;
	}
}
// System.Void LipingShare.LCLib.Asn1Processor.Oid::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Oid__ctor_m5F73190FA2302798601F2B61863F12363DF5E843 (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, const RuntimeMethod* method)
{
	{
		// public Oid()
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Int32 LipingShare.LCLib.Asn1Processor.Oid::DecodeValue(System.IO.Stream,System.UInt64&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Oid_DecodeValue_m319B938E419AD61DA32F9D0E7191FF2815B55DD8 (Oid_t74E6C251FECEACAC8925DA1A6036BBE841C97E0D * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___bt0, uint64_t* ___v1, const RuntimeMethod* method)
{
	uint8_t V_0 = 0x0;
	int32_t V_1 = 0;
	{
		// int i = 0;
		V_1 = 0;
		// v = 0;
		uint64_t* L_0 = ___v1;
		*((int64_t*)L_0) = (int64_t)((int64_t)((int64_t)0));
	}

IL_0006:
	{
		// b = (byte)bt.ReadByte();
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_1 = ___bt0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(35 /* System.Int32 System.IO.Stream::ReadByte() */, L_1);
		V_0 = (uint8_t)((int32_t)((uint8_t)L_2));
		// i++;
		int32_t L_3 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_3, (int32_t)1));
		// v <<= 7;
		uint64_t* L_4 = ___v1;
		uint64_t* L_5 = ___v1;
		int64_t L_6 = *((int64_t*)L_5);
		*((int64_t*)L_4) = (int64_t)((int64_t)((int64_t)L_6<<(int32_t)7));
		// v += (ulong)(b & 0x7f);
		uint64_t* L_7 = ___v1;
		uint64_t* L_8 = ___v1;
		int64_t L_9 = *((int64_t*)L_8);
		uint8_t L_10 = V_0;
		*((int64_t*)L_7) = (int64_t)((int64_t)il2cpp_codegen_add((int64_t)L_9, (int64_t)((int64_t)((int64_t)((int32_t)((int32_t)L_10&(int32_t)((int32_t)127)))))));
		// if ((b & 0x80) == 0)
		uint8_t L_11 = V_0;
		if (((int32_t)((int32_t)L_11&(int32_t)((int32_t)128))))
		{
			goto IL_0006;
		}
	}
	{
		// return i;
		int32_t L_12 = V_1;
		return L_12;
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
// LipingShare.LCLib.Asn1Processor.Asn1Node UnityEngine.Purchasing.Security.PKCS7::get_data()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * PKCS7_get_data_m6D8A2F87A739A82DD799A4221D0694378AE72766 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method)
{
	{
		// public Asn1Node data { get; private set; }
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = __this->get_U3CdataU3Ek__BackingField_1();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.PKCS7::set_data(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PKCS7_set_data_m1BCC45AFBD0BC0E7F7A108C65F1FC8DC42A57489 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___value0, const RuntimeMethod* method)
{
	{
		// public Asn1Node data { get; private set; }
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___value0;
		__this->set_U3CdataU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo> UnityEngine.Purchasing.Security.PKCS7::get_sinfos()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * PKCS7_get_sinfos_mC974631B995F6B9AC43EFD1E5B02F8EE112F278F (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method)
{
	{
		// public List<SignerInfo> sinfos { get; private set; }
		List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * L_0 = __this->get_U3CsinfosU3Ek__BackingField_2();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.PKCS7::set_sinfos(System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.SignerInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PKCS7_set_sinfos_mE2B572994330BFEF8B073BCD8D6C1EC384DC2BC7 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * ___value0, const RuntimeMethod* method)
{
	{
		// public List<SignerInfo> sinfos { get; private set; }
		List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * L_0 = ___value0;
		__this->set_U3CsinfosU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert> UnityEngine.Purchasing.Security.PKCS7::get_certChain()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * PKCS7_get_certChain_m00B476DB0047B4C9991F5B435BFACD1124394373 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method)
{
	{
		// public List<X509Cert> certChain { get; private set; }
		List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * L_0 = __this->get_U3CcertChainU3Ek__BackingField_3();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.PKCS7::set_certChain(System.Collections.Generic.List`1<UnityEngine.Purchasing.Security.X509Cert>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PKCS7_set_certChain_m3393852EBF6A9ACF57D248CD5CD96E7170DA9257 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * ___value0, const RuntimeMethod* method)
{
	{
		// public List<X509Cert> certChain { get; private set; }
		List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * L_0 = ___value0;
		__this->set_U3CcertChainU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.PKCS7::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PKCS7__ctor_mC23976D15A67FB5C3C7CCDC937F9F6800E0CC3E5 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___node0, const RuntimeMethod* method)
{
	{
		// public PKCS7(Asn1Node node)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this.root = node;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___node0;
		__this->set_root_0(L_0);
		// CheckStructure();
		PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.PKCS7::CheckStructure()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058 (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m80068FC05C359A987CEF7128920AA1437950D76E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m9B4412E2C7AAF1AF1107C9AD3E077358556B98C0_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m5667C5FFA6B3D3FE9E406930664837BF29CB06F1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m9174FECFF4F8AF56773DA8275A1610F7D7BF0745_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEA9886E4F2C4A6802C316A24EEE315A59DF9E0B5);
		s_Il2CppMethodInitialized = true;
	}
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_0 = NULL;
	int32_t V_1 = 0;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_2 = NULL;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	{
		// validStructure = false;
		__this->set_validStructure_4((bool)0);
		// if ((root.Tag & Asn1Tag.TAG_MASK) == Asn1Tag.SEQUENCE &&
		//     root.ChildNodeCount == 2)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = __this->get_root_0();
		NullCheck(L_0);
		uint8_t L_1;
		L_1 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_0, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_1&(int32_t)((int32_t)31)))) == ((uint32_t)((int32_t)16)))))
		{
			goto IL_01dc;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = __this->get_root_0();
		NullCheck(L_2);
		int64_t L_3;
		L_3 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_2, /*hidden argument*/NULL);
		if ((!(((uint64_t)L_3) == ((uint64_t)((int64_t)((int64_t)2))))))
		{
			goto IL_01dc;
		}
	}
	{
		// Asn1Node tt = root.GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4 = __this->get_root_0();
		NullCheck(L_4);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5;
		L_5 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_4, 0, /*hidden argument*/NULL);
		V_0 = L_5;
		// if ((tt.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.OBJECT_IDENTIFIER ||
		//     tt.GetDataStr(false) != "1.2.840.113549.1.7.2")
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_6 = V_0;
		NullCheck(L_6);
		uint8_t L_7;
		L_7 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_6, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_7&(int32_t)((int32_t)31)))) == ((uint32_t)6))))
		{
			goto IL_005a;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8 = V_0;
		NullCheck(L_8);
		String_t* L_9;
		L_9 = Asn1Node_GetDataStr_mF4A8F71F0C9F5ECB82E4981090F142D59965CAD1(L_8, (bool)0, /*hidden argument*/NULL);
		bool L_10;
		L_10 = String_op_Inequality_mDDA2DDED3E7EF042987EB7180EE3E88105F0AAE2(L_9, _stringLiteralEA9886E4F2C4A6802C316A24EEE315A59DF9E0B5, /*hidden argument*/NULL);
		if (!L_10)
		{
			goto IL_0060;
		}
	}

IL_005a:
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_11 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_11, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_11, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var)));
	}

IL_0060:
	{
		// tt = root.GetChildNode(1); // [0]
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_12 = __this->get_root_0();
		NullCheck(L_12);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_13;
		L_13 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_12, 1, /*hidden argument*/NULL);
		V_0 = L_13;
		// if (tt.ChildNodeCount != 1)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_14 = V_0;
		NullCheck(L_14);
		int64_t L_15;
		L_15 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_14, /*hidden argument*/NULL);
		if ((((int64_t)L_15) == ((int64_t)((int64_t)((int64_t)1)))))
		{
			goto IL_007d;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_16 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_16, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_16, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var)));
	}

IL_007d:
	{
		// int curChild = 0;
		V_1 = 0;
		// tt = tt.GetChildNode(curChild++); // Seq
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_17 = V_0;
		int32_t L_18 = V_1;
		int32_t L_19 = L_18;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_19, (int32_t)1));
		NullCheck(L_17);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_20;
		L_20 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_17, L_19, /*hidden argument*/NULL);
		V_0 = L_20;
		// if (tt.ChildNodeCount < 4 || (tt.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.SEQUENCE)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_21 = V_0;
		NullCheck(L_21);
		int64_t L_22;
		L_22 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_21, /*hidden argument*/NULL);
		if ((((int64_t)L_22) < ((int64_t)((int64_t)((int64_t)4)))))
		{
			goto IL_00a2;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_23 = V_0;
		NullCheck(L_23);
		uint8_t L_24;
		L_24 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_23, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)((int32_t)L_24&(int32_t)((int32_t)31)))) == ((int32_t)((int32_t)16))))
		{
			goto IL_00a8;
		}
	}

IL_00a2:
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_25 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_25, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_25, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var)));
	}

IL_00a8:
	{
		// Asn1Node tt2 = tt.GetChildNode(0); // version
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_26 = V_0;
		NullCheck(L_26);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_27;
		L_27 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_26, 0, /*hidden argument*/NULL);
		V_2 = L_27;
		// if ((tt2.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.INTEGER)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_28 = V_2;
		NullCheck(L_28);
		uint8_t L_29;
		L_29 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_28, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)((int32_t)L_29&(int32_t)((int32_t)31)))) == ((int32_t)2)))
		{
			goto IL_00c2;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_30 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_30, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_30, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var)));
	}

IL_00c2:
	{
		// tt2 = tt.GetChildNode(curChild++); // digest algo
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_31 = V_0;
		int32_t L_32 = V_1;
		int32_t L_33 = L_32;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_33, (int32_t)1));
		NullCheck(L_31);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_34;
		L_34 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_31, L_33, /*hidden argument*/NULL);
		V_2 = L_34;
		// if ((tt2.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.SET)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_35 = V_2;
		NullCheck(L_35);
		uint8_t L_36;
		L_36 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_35, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)((int32_t)L_36&(int32_t)((int32_t)31)))) == ((int32_t)((int32_t)17))))
		{
			goto IL_00e1;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_37 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_37, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_37, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var)));
	}

IL_00e1:
	{
		// tt2 = tt.GetChildNode(curChild++); // pkcs7 data
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_38 = V_0;
		int32_t L_39 = V_1;
		int32_t L_40 = L_39;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_40, (int32_t)1));
		NullCheck(L_38);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_41;
		L_41 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_38, L_40, /*hidden argument*/NULL);
		V_2 = L_41;
		// if ((tt2.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.SEQUENCE && tt2.ChildNodeCount != 2)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_42 = V_2;
		NullCheck(L_42);
		uint8_t L_43;
		L_43 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_42, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)((int32_t)L_43&(int32_t)((int32_t)31)))) == ((int32_t)((int32_t)16))))
		{
			goto IL_010a;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_44 = V_2;
		NullCheck(L_44);
		int64_t L_45;
		L_45 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_44, /*hidden argument*/NULL);
		if ((((int64_t)L_45) == ((int64_t)((int64_t)((int64_t)2)))))
		{
			goto IL_010a;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_46 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_46, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_46, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var)));
	}

IL_010a:
	{
		// data = tt2.GetChildNode(1).GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_47 = V_2;
		NullCheck(L_47);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_48;
		L_48 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_47, 1, /*hidden argument*/NULL);
		NullCheck(L_48);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_49;
		L_49 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_48, 0, /*hidden argument*/NULL);
		PKCS7_set_data_m1BCC45AFBD0BC0E7F7A108C65F1FC8DC42A57489_inline(__this, L_49, /*hidden argument*/NULL);
		// if (tt.ChildNodeCount == 5)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_50 = V_0;
		NullCheck(L_50);
		int64_t L_51;
		L_51 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_50, /*hidden argument*/NULL);
		if ((!(((uint64_t)L_51) == ((uint64_t)((int64_t)((int64_t)5))))))
		{
			goto IL_0175;
		}
	}
	{
		// certChain = new List<X509Cert>();
		List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * L_52 = (List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 *)il2cpp_codegen_object_new(List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3_il2cpp_TypeInfo_var);
		List_1__ctor_m9174FECFF4F8AF56773DA8275A1610F7D7BF0745(L_52, /*hidden argument*/List_1__ctor_m9174FECFF4F8AF56773DA8275A1610F7D7BF0745_RuntimeMethod_var);
		PKCS7_set_certChain_m3393852EBF6A9ACF57D248CD5CD96E7170DA9257_inline(__this, L_52, /*hidden argument*/NULL);
		// tt2 = tt.GetChildNode(curChild++);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_53 = V_0;
		int32_t L_54 = V_1;
		int32_t L_55 = L_54;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_55, (int32_t)1));
		NullCheck(L_53);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_56;
		L_56 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_53, L_55, /*hidden argument*/NULL);
		V_2 = L_56;
		// if (tt2.ChildNodeCount == 0)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_57 = V_2;
		NullCheck(L_57);
		int64_t L_58;
		L_58 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_57, /*hidden argument*/NULL);
		if (L_58)
		{
			goto IL_014c;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_59 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_59, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_59, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var)));
	}

IL_014c:
	{
		// for (int i = 0; i < tt2.ChildNodeCount; i++)
		V_3 = 0;
		goto IL_016b;
	}

IL_0150:
	{
		// certChain.Add(new X509Cert(tt2.GetChildNode(i)));
		List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * L_60;
		L_60 = PKCS7_get_certChain_m00B476DB0047B4C9991F5B435BFACD1124394373_inline(__this, /*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_61 = V_2;
		int32_t L_62 = V_3;
		NullCheck(L_61);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_63;
		L_63 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_61, L_62, /*hidden argument*/NULL);
		X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * L_64 = (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C *)il2cpp_codegen_object_new(X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C_il2cpp_TypeInfo_var);
		X509Cert__ctor_mA9A0A93FB464AA5AE8E65B5E6DDFCBBAD398AF9B(L_64, L_63, /*hidden argument*/NULL);
		NullCheck(L_60);
		List_1_Add_m9B4412E2C7AAF1AF1107C9AD3E077358556B98C0(L_60, L_64, /*hidden argument*/List_1_Add_m9B4412E2C7AAF1AF1107C9AD3E077358556B98C0_RuntimeMethod_var);
		// for (int i = 0; i < tt2.ChildNodeCount; i++)
		int32_t L_65 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_65, (int32_t)1));
	}

IL_016b:
	{
		// for (int i = 0; i < tt2.ChildNodeCount; i++)
		int32_t L_66 = V_3;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_67 = V_2;
		NullCheck(L_67);
		int64_t L_68;
		L_68 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_67, /*hidden argument*/NULL);
		if ((((int64_t)((int64_t)((int64_t)L_66))) < ((int64_t)L_68)))
		{
			goto IL_0150;
		}
	}

IL_0175:
	{
		// tt2 = tt.GetChildNode(curChild++); // signer's info
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_69 = V_0;
		int32_t L_70 = V_1;
		int32_t L_71 = L_70;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_71, (int32_t)1));
		NullCheck(L_69);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_72;
		L_72 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_69, L_71, /*hidden argument*/NULL);
		V_2 = L_72;
		// if ((tt2.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.SET || tt2.ChildNodeCount == 0)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_73 = V_2;
		NullCheck(L_73);
		uint8_t L_74;
		L_74 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_73, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_74&(int32_t)((int32_t)31)))) == ((uint32_t)((int32_t)17)))))
		{
			goto IL_0196;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_75 = V_2;
		NullCheck(L_75);
		int64_t L_76;
		L_76 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_75, /*hidden argument*/NULL);
		if (L_76)
		{
			goto IL_019c;
		}
	}

IL_0196:
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_77 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_77, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_77, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&PKCS7_CheckStructure_m0FA3932F2DD12D410FE33EBB0CCBA3E33F6A4058_RuntimeMethod_var)));
	}

IL_019c:
	{
		// sinfos = new List<SignerInfo>();
		List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * L_78 = (List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 *)il2cpp_codegen_object_new(List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18_il2cpp_TypeInfo_var);
		List_1__ctor_m5667C5FFA6B3D3FE9E406930664837BF29CB06F1(L_78, /*hidden argument*/List_1__ctor_m5667C5FFA6B3D3FE9E406930664837BF29CB06F1_RuntimeMethod_var);
		PKCS7_set_sinfos_mE2B572994330BFEF8B073BCD8D6C1EC384DC2BC7_inline(__this, L_78, /*hidden argument*/NULL);
		// for (int i = 0; i < tt2.ChildNodeCount; i++)
		V_4 = 0;
		goto IL_01ca;
	}

IL_01ac:
	{
		// sinfos.Add(new SignerInfo(tt2.GetChildNode(i)));
		List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * L_79;
		L_79 = PKCS7_get_sinfos_mC974631B995F6B9AC43EFD1E5B02F8EE112F278F_inline(__this, /*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_80 = V_2;
		int32_t L_81 = V_4;
		NullCheck(L_80);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_82;
		L_82 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_80, L_81, /*hidden argument*/NULL);
		SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * L_83 = (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB *)il2cpp_codegen_object_new(SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB_il2cpp_TypeInfo_var);
		SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9(L_83, L_82, /*hidden argument*/NULL);
		NullCheck(L_79);
		List_1_Add_m80068FC05C359A987CEF7128920AA1437950D76E(L_79, L_83, /*hidden argument*/List_1_Add_m80068FC05C359A987CEF7128920AA1437950D76E_RuntimeMethod_var);
		// for (int i = 0; i < tt2.ChildNodeCount; i++)
		int32_t L_84 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add((int32_t)L_84, (int32_t)1));
	}

IL_01ca:
	{
		// for (int i = 0; i < tt2.ChildNodeCount; i++)
		int32_t L_85 = V_4;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_86 = V_2;
		NullCheck(L_86);
		int64_t L_87;
		L_87 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_86, /*hidden argument*/NULL);
		if ((((int64_t)((int64_t)((int64_t)L_85))) < ((int64_t)L_87)))
		{
			goto IL_01ac;
		}
	}
	{
		// validStructure = true;
		__this->set_validStructure_4((bool)1);
	}

IL_01dc:
	{
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
// System.Void UnityEngine.Purchasing.Security.RSAKey::set_rsa(System.Security.Cryptography.RSACryptoServiceProvider)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RSAKey_set_rsa_m5B74E411FA4685E4484F1EEF973E02F1F008A4F5 (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * ___value0, const RuntimeMethod* method)
{
	{
		// public RSACryptoServiceProvider rsa { get; private set; }
		RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * L_0 = ___value0;
		__this->set_U3CrsaU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.RSAKey::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RSAKey__ctor_m122BCC496985281C78CCD0A223792580C27D4F6F (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method)
{
	{
		// public RSAKey(Asn1Node n)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// rsa = ParseNode(n);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___n0;
		RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * L_1;
		L_1 = RSAKey_ParseNode_mC39A2AC4AC93CD5E30783858DE40667A8CE74D77(__this, L_0, /*hidden argument*/NULL);
		RSAKey_set_rsa_m5B74E411FA4685E4484F1EEF973E02F1F008A4F5_inline(__this, L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Security.Cryptography.RSACryptoServiceProvider UnityEngine.Purchasing.Security.RSAKey::ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * RSAKey_ParseNode_mC39A2AC4AC93CD5E30783858DE40667A8CE74D77 (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2A7F604AA53E605CA5A4D06ADF4F5C4B6FCBD8E8);
		s_Il2CppMethodInitialized = true;
	}
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_0 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_1 = NULL;
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_2 = NULL;
	String_t* V_3 = NULL;
	String_t* V_4 = NULL;
	{
		// if ((n.Tag & Asn1Tag.TAG_MASK) == Asn1Tag.SEQUENCE &&
		//     n.ChildNodeCount == 2 &&
		//     (n.GetChildNode(0).Tag & Asn1Tag.TAG_MASK) == Asn1Tag.SEQUENCE &&
		//     (n.GetChildNode(0).GetChildNode(0).Tag & Asn1Tag.TAG_MASK) == Asn1Tag.OBJECT_IDENTIFIER &&
		//     n.GetChildNode(0).GetChildNode(0).GetDataStr(false) == "1.2.840.113549.1.1.1" &&
		//     (n.GetChildNode(1).Tag & Asn1Tag.TAG_MASK) == Asn1Tag.BIT_STRING)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___n0;
		NullCheck(L_0);
		uint8_t L_1;
		L_1 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_0, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_1&(int32_t)((int32_t)31)))) == ((uint32_t)((int32_t)16)))))
		{
			goto IL_00ec;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = ___n0;
		NullCheck(L_2);
		int64_t L_3;
		L_3 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_2, /*hidden argument*/NULL);
		if ((!(((uint64_t)L_3) == ((uint64_t)((int64_t)((int64_t)2))))))
		{
			goto IL_00ec;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4 = ___n0;
		NullCheck(L_4);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5;
		L_5 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_4, 0, /*hidden argument*/NULL);
		NullCheck(L_5);
		uint8_t L_6;
		L_6 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_5, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_6&(int32_t)((int32_t)31)))) == ((uint32_t)((int32_t)16)))))
		{
			goto IL_00ec;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_7 = ___n0;
		NullCheck(L_7);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8;
		L_8 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_7, 0, /*hidden argument*/NULL);
		NullCheck(L_8);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_9;
		L_9 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_8, 0, /*hidden argument*/NULL);
		NullCheck(L_9);
		uint8_t L_10;
		L_10 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_9, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_10&(int32_t)((int32_t)31)))) == ((uint32_t)6))))
		{
			goto IL_00ec;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_11 = ___n0;
		NullCheck(L_11);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_12;
		L_12 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_11, 0, /*hidden argument*/NULL);
		NullCheck(L_12);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_13;
		L_13 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_12, 0, /*hidden argument*/NULL);
		NullCheck(L_13);
		String_t* L_14;
		L_14 = Asn1Node_GetDataStr_mF4A8F71F0C9F5ECB82E4981090F142D59965CAD1(L_13, (bool)0, /*hidden argument*/NULL);
		bool L_15;
		L_15 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_14, _stringLiteral2A7F604AA53E605CA5A4D06ADF4F5C4B6FCBD8E8, /*hidden argument*/NULL);
		if (!L_15)
		{
			goto IL_00ec;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_16 = ___n0;
		NullCheck(L_16);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_17;
		L_17 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_16, 1, /*hidden argument*/NULL);
		NullCheck(L_17);
		uint8_t L_18;
		L_18 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_17, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_18&(int32_t)((int32_t)31)))) == ((uint32_t)3))))
		{
			goto IL_00ec;
		}
	}
	{
		// var seq = n.GetChildNode(1).GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_19 = ___n0;
		NullCheck(L_19);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_20;
		L_20 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_19, 1, /*hidden argument*/NULL);
		NullCheck(L_20);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_21;
		L_21 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_20, 0, /*hidden argument*/NULL);
		V_0 = L_21;
		// if (seq.ChildNodeCount == 2)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_22 = V_0;
		NullCheck(L_22);
		int64_t L_23;
		L_23 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_22, /*hidden argument*/NULL);
		if ((!(((uint64_t)L_23) == ((uint64_t)((int64_t)((int64_t)2))))))
		{
			goto IL_00ec;
		}
	}
	{
		// byte[] data = seq.GetChildNode(0).Data;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_24 = V_0;
		NullCheck(L_24);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_25;
		L_25 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_24, 0, /*hidden argument*/NULL);
		NullCheck(L_25);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_26;
		L_26 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_25, /*hidden argument*/NULL);
		V_1 = L_26;
		// byte[] rawMod = new byte[data.Length - 1];
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_27 = V_1;
		NullCheck(L_27);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_28 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_subtract((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_27)->max_length))), (int32_t)1)));
		V_2 = L_28;
		// System.Array.Copy(data, 1, rawMod, 0, data.Length - 1);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_29 = V_1;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_30 = V_2;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_31 = V_1;
		NullCheck(L_31);
		Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877((RuntimeArray *)(RuntimeArray *)L_29, 1, (RuntimeArray *)(RuntimeArray *)L_30, 0, ((int32_t)il2cpp_codegen_subtract((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_31)->max_length))), (int32_t)1)), /*hidden argument*/NULL);
		// var modulus = System.Convert.ToBase64String(rawMod);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_32 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		String_t* L_33;
		L_33 = Convert_ToBase64String_mE6E1FE504EF1E99DB2F8B92180A82A5F1512EF6A(L_32, /*hidden argument*/NULL);
		V_3 = L_33;
		// var exponent = System.Convert.ToBase64String(seq.GetChildNode(1).Data);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_34 = V_0;
		NullCheck(L_34);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_35;
		L_35 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_34, 1, /*hidden argument*/NULL);
		NullCheck(L_35);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_36;
		L_36 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_35, /*hidden argument*/NULL);
		String_t* L_37;
		L_37 = Convert_ToBase64String_mE6E1FE504EF1E99DB2F8B92180A82A5F1512EF6A(L_36, /*hidden argument*/NULL);
		V_4 = L_37;
		// var result = new RSACryptoServiceProvider();
		RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * L_38 = (RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 *)il2cpp_codegen_object_new(RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7_il2cpp_TypeInfo_var);
		RSACryptoServiceProvider__ctor_m540359C328E1E9E9818A1192E34C74C986186B80(L_38, /*hidden argument*/NULL);
		// result.FromXmlString(ToXML(modulus, exponent));
		RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * L_39 = L_38;
		String_t* L_40 = V_3;
		String_t* L_41 = V_4;
		String_t* L_42;
		L_42 = RSAKey_ToXML_m189C5328EE031465F2BFF117F6AE5E4BBB39C022(__this, L_40, L_41, /*hidden argument*/NULL);
		NullCheck(L_39);
		VirtActionInvoker1< String_t* >::Invoke(11 /* System.Void System.Security.Cryptography.AsymmetricAlgorithm::FromXmlString(System.String) */, L_39, L_42);
		// return result;
		return L_39;
	}

IL_00ec:
	{
		// throw new InvalidRSAData();
		InvalidRSAData_t7936FA4BD4B05A86337546B43ED2197E49D4EFF7 * L_43 = (InvalidRSAData_t7936FA4BD4B05A86337546B43ED2197E49D4EFF7 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidRSAData_t7936FA4BD4B05A86337546B43ED2197E49D4EFF7_il2cpp_TypeInfo_var)));
		InvalidRSAData__ctor_m7FD4D1595A630A2C0D68DF36C9E9E383262C056C(L_43, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_43, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RSAKey_ParseNode_mC39A2AC4AC93CD5E30783858DE40667A8CE74D77_RuntimeMethod_var)));
	}
}
// System.String UnityEngine.Purchasing.Security.RSAKey::ToXML(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RSAKey_ToXML_m189C5328EE031465F2BFF117F6AE5E4BBB39C022 (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, String_t* ___modulus0, String_t* ___exponent1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3B764AA8712500B6779AEFF44B47B45F9ECF8039);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBCED53E33A2D1B5B5E90E0B5DE86443E44FD452A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEBF60A7C62C7CF38BEB570C5B0AF43904FFCB6B8);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return "<RSAKeyValue><Modulus>" + modulus + "</Modulus>" +
		//     "<Exponent>" + exponent + "</Exponent></RSAKeyValue>";
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_0 = (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A*)SZArrayNew(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A_il2cpp_TypeInfo_var, (uint32_t)5);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_1 = L_0;
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, _stringLiteral3B764AA8712500B6779AEFF44B47B45F9ECF8039);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteral3B764AA8712500B6779AEFF44B47B45F9ECF8039);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_2 = L_1;
		String_t* L_3 = ___modulus0;
		NullCheck(L_2);
		ArrayElementTypeCheck (L_2, L_3);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_3);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_4 = L_2;
		NullCheck(L_4);
		ArrayElementTypeCheck (L_4, _stringLiteralEBF60A7C62C7CF38BEB570C5B0AF43904FFCB6B8);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteralEBF60A7C62C7CF38BEB570C5B0AF43904FFCB6B8);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_5 = L_4;
		String_t* L_6 = ___exponent1;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_6);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_7 = L_5;
		NullCheck(L_7);
		ArrayElementTypeCheck (L_7, _stringLiteralBCED53E33A2D1B5B5E90E0B5DE86443E44FD452A);
		(L_7)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteralBCED53E33A2D1B5B5E90E0B5DE86443E44FD452A);
		String_t* L_8;
		L_8 = String_Concat_mFEA7EFA1A6E75B96B1B7BC4526AAC864BFF83CC9(L_7, /*hidden argument*/NULL);
		return L_8;
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
// System.Void LipingShare.LCLib.Asn1Processor.RelativeOid::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RelativeOid__ctor_m1DD6406191F78BC9BAAC9FD71BAF4AFC9372A6C8 (RelativeOid_t97392E06363F6AFF26543502032B89445860F72A * __this, const RuntimeMethod* method)
{
	{
		// public RelativeOid()
		Oid__ctor_m5F73190FA2302798601F2B61863F12363DF5E843(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.String LipingShare.LCLib.Asn1Processor.RelativeOid::Decode(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* RelativeOid_Decode_mE4574BFE63ABA7C1657B17B37854434120457BCD (RelativeOid_t97392E06363F6AFF26543502032B89445860F72A * __this, Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * ___bt0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	uint64_t V_1 = 0;
	bool V_2 = false;
	Exception_t * V_3 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// string retval = "";
		V_0 = _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
		// ulong v = 0;
		V_1 = ((int64_t)((int64_t)0));
		// bool isFirst = true;
		V_2 = (bool)1;
		goto IL_0053;
	}

IL_000d:
	{
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			// DecodeValue(bt, ref v);
			Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_0 = ___bt0;
			int32_t L_1;
			L_1 = Oid_DecodeValue_m319B938E419AD61DA32F9D0E7191FF2815B55DD8(__this, L_0, (uint64_t*)(&V_1), /*hidden argument*/NULL);
			// if (isFirst)
			bool L_2 = V_2;
			if (!L_2)
			{
				goto IL_0027;
			}
		}

IL_001b:
		{
			// retval = v.ToString();
			String_t* L_3;
			L_3 = UInt64_ToString_m3644686F0A0E32CB94D300CF891DBD7920396F37((uint64_t*)(&V_1), /*hidden argument*/NULL);
			V_0 = L_3;
			// isFirst = false;
			V_2 = (bool)0;
			// }
			goto IL_003a;
		}

IL_0027:
		{
			// retval += "." + v.ToString();
			String_t* L_4 = V_0;
			String_t* L_5;
			L_5 = UInt64_ToString_m3644686F0A0E32CB94D300CF891DBD7920396F37((uint64_t*)(&V_1), /*hidden argument*/NULL);
			String_t* L_6;
			L_6 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_4, _stringLiteralF3E84B722399601AD7E281754E917478AA9AD48D, L_5, /*hidden argument*/NULL);
			V_0 = L_6;
		}

IL_003a:
		{
			// }
			goto IL_0053;
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_003c;
		}
		throw e;
	}

CATCH_003c:
	{ // begin catch(System.Exception)
		// catch (Exception e)
		V_3 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
		// throw new Exception("Failed to decode OID value: " + e.Message);
		Exception_t * L_7 = V_3;
		NullCheck(L_7);
		String_t* L_8;
		L_8 = VirtFuncInvoker0< String_t* >::Invoke(19 /* System.String System.Exception::get_Message() */, L_7);
		String_t* L_9;
		L_9 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralAE82977104FE357F4C1CE6D6A3DFD58AFEBFC641)), L_8, /*hidden argument*/NULL);
		Exception_t * L_10 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_10, L_9, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_10, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&RelativeOid_Decode_mE4574BFE63ABA7C1657B17B37854434120457BCD_RuntimeMethod_var)));
	} // end catch (depth: 1)

IL_0053:
	{
		// while (bt.Position < bt.Length)
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_11 = ___bt0;
		NullCheck(L_11);
		int64_t L_12;
		L_12 = VirtFuncInvoker0< int64_t >::Invoke(13 /* System.Int64 System.IO.Stream::get_Position() */, L_11);
		Stream_t5DC87DD578C2C5298D98E7802E92DEABB66E2ECB * L_13 = ___bt0;
		NullCheck(L_13);
		int64_t L_14;
		L_14 = VirtFuncInvoker0< int64_t >::Invoke(12 /* System.Int64 System.IO.Stream::get_Length() */, L_13);
		if ((((int64_t)L_12) < ((int64_t)L_14)))
		{
			goto IL_000d;
		}
	}
	{
		// return retval;
		String_t* L_15 = V_0;
		return L_15;
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
// System.Int32 UnityEngine.Purchasing.Security.SignerInfo::get_Version()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SignerInfo_get_Version_m7967FD171D0CD045416CF0CD8EE86F880B5AFDA1 (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, const RuntimeMethod* method)
{
	{
		// public int Version { get; private set; }
		int32_t L_0 = __this->get_U3CVersionU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.SignerInfo::set_Version(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SignerInfo_set_Version_m096A7A01379DBFE817CB261272AE462789B619CF (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public int Version { get; private set; }
		int32_t L_0 = ___value0;
		__this->set_U3CVersionU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.SignerInfo::set_IssuerSerialNumber(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SignerInfo_set_IssuerSerialNumber_mCF2536D75E277F4AF7311E105A586BC8087BC8E2 (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string IssuerSerialNumber { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CIssuerSerialNumberU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.SignerInfo::set_EncryptedDigest(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SignerInfo_set_EncryptedDigest_mBF05E641B22261C4D7A5DAE5F5FCD59BBDA1505B (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___value0, const RuntimeMethod* method)
{
	{
		// public byte[] EncryptedDigest { get; private set; }
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = ___value0;
		__this->set_U3CEncryptedDigestU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.SignerInfo::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9 (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_0 = NULL;
	{
		// public SignerInfo(Asn1Node n)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// if (n.ChildNodeCount != 5)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___n0;
		NullCheck(L_0);
		int64_t L_1;
		L_1 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_0, /*hidden argument*/NULL);
		if ((((int64_t)L_1) == ((int64_t)((int64_t)((int64_t)5)))))
		{
			goto IL_0016;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_2 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_2, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9_RuntimeMethod_var)));
	}

IL_0016:
	{
		// tt = n.GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_3 = ___n0;
		NullCheck(L_3);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_4;
		L_4 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_3, 0, /*hidden argument*/NULL);
		V_0 = L_4;
		// if ((tt.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.INTEGER)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5 = V_0;
		NullCheck(L_5);
		uint8_t L_6;
		L_6 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_5, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)((int32_t)L_6&(int32_t)((int32_t)31)))) == ((int32_t)2)))
		{
			goto IL_0030;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_7 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_7, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9_RuntimeMethod_var)));
	}

IL_0030:
	{
		// Version = tt.Data[0];
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_8 = V_0;
		NullCheck(L_8);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_9;
		L_9 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_8, /*hidden argument*/NULL);
		NullCheck(L_9);
		int32_t L_10 = 0;
		uint8_t L_11 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		SignerInfo_set_Version_m096A7A01379DBFE817CB261272AE462789B619CF_inline(__this, L_11, /*hidden argument*/NULL);
		// if (Version != 1 || tt.Data.Length != 1)
		int32_t L_12;
		L_12 = SignerInfo_get_Version_m7967FD171D0CD045416CF0CD8EE86F880B5AFDA1_inline(__this, /*hidden argument*/NULL);
		if ((!(((uint32_t)L_12) == ((uint32_t)1))))
		{
			goto IL_0052;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_13 = V_0;
		NullCheck(L_13);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_14;
		L_14 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_13, /*hidden argument*/NULL);
		NullCheck(L_14);
		if ((((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_14)->max_length)))) == ((int32_t)1)))
		{
			goto IL_0058;
		}
	}

IL_0052:
	{
		// throw new UnsupportedSignerInfoVersion();
		UnsupportedSignerInfoVersion_t0D2E1B83A5FA8AAAF3BA828FFEEEE27A2AC57B1F * L_15 = (UnsupportedSignerInfoVersion_t0D2E1B83A5FA8AAAF3BA828FFEEEE27A2AC57B1F *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&UnsupportedSignerInfoVersion_t0D2E1B83A5FA8AAAF3BA828FFEEEE27A2AC57B1F_il2cpp_TypeInfo_var)));
		UnsupportedSignerInfoVersion__ctor_m2A525C80CA9AB2BE9F9869A020D54A0A11AA1542(L_15, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_15, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9_RuntimeMethod_var)));
	}

IL_0058:
	{
		// tt = n.GetChildNode(1);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_16 = ___n0;
		NullCheck(L_16);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_17;
		L_17 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_16, 1, /*hidden argument*/NULL);
		V_0 = L_17;
		// if ((tt.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.SEQUENCE || tt.ChildNodeCount != 2)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_18 = V_0;
		NullCheck(L_18);
		uint8_t L_19;
		L_19 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_18, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_19&(int32_t)((int32_t)31)))) == ((uint32_t)((int32_t)16)))))
		{
			goto IL_0077;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_20 = V_0;
		NullCheck(L_20);
		int64_t L_21;
		L_21 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_20, /*hidden argument*/NULL);
		if ((((int64_t)L_21) == ((int64_t)((int64_t)((int64_t)2)))))
		{
			goto IL_007d;
		}
	}

IL_0077:
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_22 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_22, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_22, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9_RuntimeMethod_var)));
	}

IL_007d:
	{
		// tt = tt.GetChildNode(1);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_23 = V_0;
		NullCheck(L_23);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_24;
		L_24 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_23, 1, /*hidden argument*/NULL);
		V_0 = L_24;
		// if ((tt.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.INTEGER)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_25 = V_0;
		NullCheck(L_25);
		uint8_t L_26;
		L_26 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_25, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)((int32_t)L_26&(int32_t)((int32_t)31)))) == ((int32_t)2)))
		{
			goto IL_0097;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_27 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_27, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_27, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9_RuntimeMethod_var)));
	}

IL_0097:
	{
		// IssuerSerialNumber = Asn1Util.ToHexString(tt.Data);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_28 = V_0;
		NullCheck(L_28);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_29;
		L_29 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_28, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_30;
		L_30 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_29, /*hidden argument*/NULL);
		SignerInfo_set_IssuerSerialNumber_mCF2536D75E277F4AF7311E105A586BC8087BC8E2_inline(__this, L_30, /*hidden argument*/NULL);
		// tt = n.GetChildNode(4);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_31 = ___n0;
		NullCheck(L_31);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_32;
		L_32 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_31, 4, /*hidden argument*/NULL);
		V_0 = L_32;
		// if ((tt.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.OCTET_STRING)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_33 = V_0;
		NullCheck(L_33);
		uint8_t L_34;
		L_34 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_33, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)((int32_t)L_34&(int32_t)((int32_t)31)))) == ((int32_t)4)))
		{
			goto IL_00c2;
		}
	}
	{
		// throw new InvalidPKCS7Data();
		InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 * L_35 = (InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidPKCS7Data_t3E7CFE6B3A72102FC1C68B873594EFEB4DB1DA81_il2cpp_TypeInfo_var)));
		InvalidPKCS7Data__ctor_m66ACFC92796EBF6BFAE5915CD3F70F1BB9D27FC1(L_35, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_35, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&SignerInfo__ctor_m72709002226CFABC20C966E638B68760B7E668A9_RuntimeMethod_var)));
	}

IL_00c2:
	{
		// EncryptedDigest = tt.Data;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_36 = V_0;
		NullCheck(L_36);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_37;
		L_37 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_36, /*hidden argument*/NULL);
		SignerInfo_set_EncryptedDigest_mBF05E641B22261C4D7A5DAE5F5FCD59BBDA1505B_inline(__this, L_37, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.Security.UnsupportedSignerInfoVersion::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnsupportedSignerInfoVersion__ctor_m2A525C80CA9AB2BE9F9869A020D54A0A11AA1542 (UnsupportedSignerInfoVersion_t0D2E1B83A5FA8AAAF3BA828FFEEEE27A2AC57B1F * __this, const RuntimeMethod* method)
{
	{
		IAPSecurityException__ctor_mFFF023188A2BB47A715BCEAF3B94F31370D77680(__this, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_SerialNumber(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_set_SerialNumber_mFA0667C943FA625300BE9D274F35630B7C918604 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string SerialNumber { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CSerialNumberU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_ValidAfter(System.DateTime)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_set_ValidAfter_m206F8F9D9BE5AAF09187DD65143E73C7DA19A46F (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime ValidAfter { get; private set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CValidAfterU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_ValidBefore(System.DateTime)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_set_ValidBefore_m9C8AE3C70CA68DCFE66E72C82AFC2861979CB6B7 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime ValidBefore { get; private set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CValidBeforeU3Ek__BackingField_2(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_PubKey(UnityEngine.Purchasing.Security.RSAKey)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_set_PubKey_mE5DCFEA38790817EF1860B54E27D06465C915D5F (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * ___value0, const RuntimeMethod* method)
{
	{
		// public RSAKey PubKey { get; private set; }
		RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * L_0 = ___value0;
		__this->set_U3CPubKeyU3Ek__BackingField_3(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_SelfSigned(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_set_SelfSigned_m73D24826515F4DA3F86453E6E70B92C1C8500A90 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// public bool SelfSigned { get; private set; }
		bool L_0 = ___value0;
		__this->set_U3CSelfSignedU3Ek__BackingField_4(L_0);
		return;
	}
}
// UnityEngine.Purchasing.Security.DistinguishedName UnityEngine.Purchasing.Security.X509Cert::get_Subject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * X509Cert_get_Subject_m12D21A6B054646292F89E16073D231ADD945FF61 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, const RuntimeMethod* method)
{
	{
		// public DistinguishedName Subject { get; private set; }
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_0 = __this->get_U3CSubjectU3Ek__BackingField_5();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_Subject(UnityEngine.Purchasing.Security.DistinguishedName)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_set_Subject_m5649A924BEB6DD0E9039AEB2232D4ECF0AD70FE4 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___value0, const RuntimeMethod* method)
{
	{
		// public DistinguishedName Subject { get; private set; }
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_0 = ___value0;
		__this->set_U3CSubjectU3Ek__BackingField_5(L_0);
		return;
	}
}
// UnityEngine.Purchasing.Security.DistinguishedName UnityEngine.Purchasing.Security.X509Cert::get_Issuer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * X509Cert_get_Issuer_m046958208FB8B4569B0F9A4D2B8EBC7DE6B6987B (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, const RuntimeMethod* method)
{
	{
		// public DistinguishedName Issuer { get; private set; }
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_0 = __this->get_U3CIssuerU3Ek__BackingField_6();
		return L_0;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_Issuer(UnityEngine.Purchasing.Security.DistinguishedName)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_set_Issuer_m9FC621236D22A3F23C3F94338EF6544D34B5D94B (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___value0, const RuntimeMethod* method)
{
	{
		// public DistinguishedName Issuer { get; private set; }
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_0 = ___value0;
		__this->set_U3CIssuerU3Ek__BackingField_6(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::set_Signature(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_set_Signature_m4E664BC494904845D1CBC1B766CA37FA0C089A2E (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___value0, const RuntimeMethod* method)
{
	{
		// public Asn1Node Signature { get; private set; }
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___value0;
		__this->set_U3CSignatureU3Ek__BackingField_8(L_0);
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::.ctor(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert__ctor_mA9A0A93FB464AA5AE8E65B5E6DDFCBBAD398AF9B (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method)
{
	{
		// public X509Cert(Asn1Node n)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// ParseNode(n);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___n0;
		X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3(__this, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.Purchasing.Security.X509Cert::ParseNode(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___root0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_0 = NULL;
	Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * V_1 = NULL;
	{
		// if ((root.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.SEQUENCE || root.ChildNodeCount != 3)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___root0;
		NullCheck(L_0);
		uint8_t L_1;
		L_1 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_0, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_1&(int32_t)((int32_t)31)))) == ((uint32_t)((int32_t)16)))))
		{
			goto IL_0017;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_2 = ___root0;
		NullCheck(L_2);
		int64_t L_3;
		L_3 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_2, /*hidden argument*/NULL);
		if ((((int64_t)L_3) == ((int64_t)((int64_t)((int64_t)3)))))
		{
			goto IL_001d;
		}
	}

IL_0017:
	{
		// throw new InvalidX509Data();
		InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * L_4 = (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA_il2cpp_TypeInfo_var)));
		InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E(L_4, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3_RuntimeMethod_var)));
	}

IL_001d:
	{
		// TbsCertificate = root.GetChildNode(0);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_5 = ___root0;
		NullCheck(L_5);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_6;
		L_6 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_5, 0, /*hidden argument*/NULL);
		__this->set_TbsCertificate_7(L_6);
		// if (TbsCertificate.ChildNodeCount < 7)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_7 = __this->get_TbsCertificate_7();
		NullCheck(L_7);
		int64_t L_8;
		L_8 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_7, /*hidden argument*/NULL);
		if ((((int64_t)L_8) >= ((int64_t)((int64_t)((int64_t)7)))))
		{
			goto IL_003f;
		}
	}
	{
		// throw new InvalidX509Data();
		InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * L_9 = (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA_il2cpp_TypeInfo_var)));
		InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E(L_9, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_9, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3_RuntimeMethod_var)));
	}

IL_003f:
	{
		// rawTBSCertificate = new byte[TbsCertificate.DataLength + 4];
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_10 = __this->get_TbsCertificate_7();
		NullCheck(L_10);
		int64_t L_11;
		L_11 = Asn1Node_get_DataLength_mCF41384470AB94796BC81FCA252C18AB3513BBD8_inline(L_10, /*hidden argument*/NULL);
		if ((int64_t)(((int64_t)il2cpp_codegen_add((int64_t)L_11, (int64_t)((int64_t)((int64_t)4))))) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3_RuntimeMethod_var);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_12 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)SZArrayNew(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)((int64_t)il2cpp_codegen_add((int64_t)L_11, (int64_t)((int64_t)((int64_t)4))))));
		__this->set_rawTBSCertificate_9(L_12);
		// Array.Copy(root.Data, 0, rawTBSCertificate, 0, rawTBSCertificate.Length);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_13 = ___root0;
		NullCheck(L_13);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_14;
		L_14 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_13, /*hidden argument*/NULL);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_15 = __this->get_rawTBSCertificate_9();
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_16 = __this->get_rawTBSCertificate_9();
		NullCheck(L_16);
		Array_Copy_m3F127FFB5149532135043FFE285F9177C80CB877((RuntimeArray *)(RuntimeArray *)L_14, 0, (RuntimeArray *)(RuntimeArray *)L_15, 0, ((int32_t)((int32_t)(((RuntimeArray*)L_16)->max_length))), /*hidden argument*/NULL);
		// Asn1Node sn = TbsCertificate.GetChildNode(1);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_17 = __this->get_TbsCertificate_7();
		NullCheck(L_17);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_18;
		L_18 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_17, 1, /*hidden argument*/NULL);
		V_0 = L_18;
		// if ((sn.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.INTEGER)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_19 = V_0;
		NullCheck(L_19);
		uint8_t L_20;
		L_20 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_19, /*hidden argument*/NULL);
		if ((((int32_t)((int32_t)((int32_t)L_20&(int32_t)((int32_t)31)))) == ((int32_t)2)))
		{
			goto IL_0093;
		}
	}
	{
		// throw new InvalidX509Data();
		InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * L_21 = (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA_il2cpp_TypeInfo_var)));
		InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E(L_21, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_21, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3_RuntimeMethod_var)));
	}

IL_0093:
	{
		// SerialNumber = Asn1Util.ToHexString(sn.Data);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_22 = V_0;
		NullCheck(L_22);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_23;
		L_23 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_22, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Asn1Util_tEB5BCCFFD196155A0AF1BA3431E22228B3ED0A2E_il2cpp_TypeInfo_var);
		String_t* L_24;
		L_24 = Asn1Util_ToHexString_m41AFD7A7290DAA00A36AFD6F505F7DED062734FA(L_23, /*hidden argument*/NULL);
		X509Cert_set_SerialNumber_mFA0667C943FA625300BE9D274F35630B7C918604_inline(__this, L_24, /*hidden argument*/NULL);
		// Issuer = new DistinguishedName(TbsCertificate.GetChildNode(3));
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_25 = __this->get_TbsCertificate_7();
		NullCheck(L_25);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_26;
		L_26 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_25, 3, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_27 = (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 *)il2cpp_codegen_object_new(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90_il2cpp_TypeInfo_var);
		DistinguishedName__ctor_m88B417EEFA420272B08355F1369DBDAA71532886(L_27, L_26, /*hidden argument*/NULL);
		X509Cert_set_Issuer_m9FC621236D22A3F23C3F94338EF6544D34B5D94B_inline(__this, L_27, /*hidden argument*/NULL);
		// Subject = new DistinguishedName(TbsCertificate.GetChildNode(5));
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_28 = __this->get_TbsCertificate_7();
		NullCheck(L_28);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_29;
		L_29 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_28, 5, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_30 = (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 *)il2cpp_codegen_object_new(DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90_il2cpp_TypeInfo_var);
		DistinguishedName__ctor_m88B417EEFA420272B08355F1369DBDAA71532886(L_30, L_29, /*hidden argument*/NULL);
		X509Cert_set_Subject_m5649A924BEB6DD0E9039AEB2232D4ECF0AD70FE4_inline(__this, L_30, /*hidden argument*/NULL);
		// Asn1Node validTimes = TbsCertificate.GetChildNode(4);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_31 = __this->get_TbsCertificate_7();
		NullCheck(L_31);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_32;
		L_32 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_31, 4, /*hidden argument*/NULL);
		V_1 = L_32;
		// if ((validTimes.Tag & Asn1Tag.TAG_MASK) != Asn1Tag.SEQUENCE || validTimes.ChildNodeCount != 2)
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_33 = V_1;
		NullCheck(L_33);
		uint8_t L_34;
		L_34 = Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline(L_33, /*hidden argument*/NULL);
		if ((!(((uint32_t)((int32_t)((int32_t)L_34&(int32_t)((int32_t)31)))) == ((uint32_t)((int32_t)16)))))
		{
			goto IL_00f6;
		}
	}
	{
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_35 = V_1;
		NullCheck(L_35);
		int64_t L_36;
		L_36 = Asn1Node_get_ChildNodeCount_mC3B93605BD0ACDF41BBB67DC3069B163E53908DB(L_35, /*hidden argument*/NULL);
		if ((((int64_t)L_36) == ((int64_t)((int64_t)((int64_t)2)))))
		{
			goto IL_00fc;
		}
	}

IL_00f6:
	{
		// throw new InvalidX509Data();
		InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA * L_37 = (InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidX509Data_t153DFD0B9D6E4BE793F83432A443D26D72E998CA_il2cpp_TypeInfo_var)));
		InvalidX509Data__ctor_m2839F4E60EEE2D3FD7F475847016E3D565817E6E(L_37, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_37, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&X509Cert_ParseNode_m88AEAEC6D6B1D1E5FC7575C532865B9730E49BD3_RuntimeMethod_var)));
	}

IL_00fc:
	{
		// ValidAfter = ParseTime(validTimes.GetChildNode(0));
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_38 = V_1;
		NullCheck(L_38);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_39;
		L_39 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_38, 0, /*hidden argument*/NULL);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_40;
		L_40 = X509Cert_ParseTime_m315E259C5A6097A60455BBBF417F8770C849DAC9(__this, L_39, /*hidden argument*/NULL);
		X509Cert_set_ValidAfter_m206F8F9D9BE5AAF09187DD65143E73C7DA19A46F_inline(__this, L_40, /*hidden argument*/NULL);
		// ValidBefore = ParseTime(validTimes.GetChildNode(1));
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_41 = V_1;
		NullCheck(L_41);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_42;
		L_42 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_41, 1, /*hidden argument*/NULL);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_43;
		L_43 = X509Cert_ParseTime_m315E259C5A6097A60455BBBF417F8770C849DAC9(__this, L_42, /*hidden argument*/NULL);
		X509Cert_set_ValidBefore_m9C8AE3C70CA68DCFE66E72C82AFC2861979CB6B7_inline(__this, L_43, /*hidden argument*/NULL);
		// SelfSigned = Subject.Equals(Issuer);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_44;
		L_44 = X509Cert_get_Subject_m12D21A6B054646292F89E16073D231ADD945FF61_inline(__this, /*hidden argument*/NULL);
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_45;
		L_45 = X509Cert_get_Issuer_m046958208FB8B4569B0F9A4D2B8EBC7DE6B6987B_inline(__this, /*hidden argument*/NULL);
		NullCheck(L_44);
		bool L_46;
		L_46 = DistinguishedName_Equals_mFFA3F3D4A6FADBEB7B9FF6BDC988D48D346A13D4(L_44, L_45, /*hidden argument*/NULL);
		X509Cert_set_SelfSigned_m73D24826515F4DA3F86453E6E70B92C1C8500A90_inline(__this, L_46, /*hidden argument*/NULL);
		// PubKey = new RSAKey(TbsCertificate.GetChildNode(6));
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_47 = __this->get_TbsCertificate_7();
		NullCheck(L_47);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_48;
		L_48 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_47, 6, /*hidden argument*/NULL);
		RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * L_49 = (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 *)il2cpp_codegen_object_new(RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6_il2cpp_TypeInfo_var);
		RSAKey__ctor_m122BCC496985281C78CCD0A223792580C27D4F6F(L_49, L_48, /*hidden argument*/NULL);
		X509Cert_set_PubKey_mE5DCFEA38790817EF1860B54E27D06465C915D5F_inline(__this, L_49, /*hidden argument*/NULL);
		// Signature = root.GetChildNode(2);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_50 = ___root0;
		NullCheck(L_50);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_51;
		L_51 = Asn1Node_GetChildNode_m492B64546769CA3C4C40FD290433822594EB8034(L_50, 2, /*hidden argument*/NULL);
		X509Cert_set_Signature_m4E664BC494904845D1CBC1B766CA37FA0C089A2E_inline(__this, L_51, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.DateTime UnityEngine.Purchasing.Security.X509Cert::ParseTime(LipingShare.LCLib.Asn1Processor.Asn1Node)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  X509Cert_ParseTime_m315E259C5A6097A60455BBBF417F8770C849DAC9 (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___n0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	{
		// string time = (new System.Text.UTF8Encoding()).GetString(n.Data);
		UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 * L_0 = (UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282 *)il2cpp_codegen_object_new(UTF8Encoding_t6EE88BC62116B5328F6CF4E39C9CC49EED2ED282_il2cpp_TypeInfo_var);
		UTF8Encoding__ctor_mA3F21D41B65D155202345802A05761A4BC022888(L_0, /*hidden argument*/NULL);
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_1 = ___n0;
		NullCheck(L_1);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_2;
		L_2 = Asn1Node_get_Data_m2D71EC76D285ACB0CD7CB44D3E7F7663B4F9DA7F(L_1, /*hidden argument*/NULL);
		NullCheck(L_0);
		String_t* L_3;
		L_3 = VirtFuncInvoker1< String_t*, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* >::Invoke(45 /* System.String System.Text.Encoding::GetString(System.Byte[]) */, L_0, L_2);
		V_0 = L_3;
		// if (!(time.Length == 13 || time.Length == 15))
		String_t* L_4 = V_0;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_4, /*hidden argument*/NULL);
		if ((((int32_t)L_5) == ((int32_t)((int32_t)13))))
		{
			goto IL_002b;
		}
	}
	{
		String_t* L_6 = V_0;
		NullCheck(L_6);
		int32_t L_7;
		L_7 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_6, /*hidden argument*/NULL);
		if ((((int32_t)L_7) == ((int32_t)((int32_t)15))))
		{
			goto IL_002b;
		}
	}
	{
		// throw new InvalidTimeFormat();
		InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428 * L_8 = (InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428_il2cpp_TypeInfo_var)));
		InvalidTimeFormat__ctor_m2EA54FD5CEBC3F2494069A8E58329417DBFD4FFA(L_8, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_8, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&X509Cert_ParseTime_m315E259C5A6097A60455BBBF417F8770C849DAC9_RuntimeMethod_var)));
	}

IL_002b:
	{
		// if (time[time.Length - 1] != 'Z')
		String_t* L_9 = V_0;
		String_t* L_10 = V_0;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_10, /*hidden argument*/NULL);
		NullCheck(L_9);
		Il2CppChar L_12;
		L_12 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_9, ((int32_t)il2cpp_codegen_subtract((int32_t)L_11, (int32_t)1)), /*hidden argument*/NULL);
		if ((((int32_t)L_12) == ((int32_t)((int32_t)90))))
		{
			goto IL_0043;
		}
	}
	{
		// throw new InvalidTimeFormat();
		InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428 * L_13 = (InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidTimeFormat_t0087C363466A0176222D5D8E13F6617131FCF428_il2cpp_TypeInfo_var)));
		InvalidTimeFormat__ctor_m2EA54FD5CEBC3F2494069A8E58329417DBFD4FFA(L_13, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_13, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&X509Cert_ParseTime_m315E259C5A6097A60455BBBF417F8770C849DAC9_RuntimeMethod_var)));
	}

IL_0043:
	{
		// int curIdx = 0;
		V_1 = 0;
		// int year = 0;
		V_2 = 0;
		// if (time.Length == 13)
		String_t* L_14 = V_0;
		NullCheck(L_14);
		int32_t L_15;
		L_15 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_14, /*hidden argument*/NULL);
		if ((!(((uint32_t)L_15) == ((uint32_t)((int32_t)13)))))
		{
			goto IL_0081;
		}
	}
	{
		// year = Int32.Parse(time.Substring(0, 2));
		String_t* L_16 = V_0;
		NullCheck(L_16);
		String_t* L_17;
		L_17 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_16, 0, 2, /*hidden argument*/NULL);
		int32_t L_18;
		L_18 = Int32_Parse_mE5D220FEA7F0BFB1B220B2A30797D7DD83ACF22C(L_17, /*hidden argument*/NULL);
		V_2 = L_18;
		// if (year >= 50)
		int32_t L_19 = V_2;
		if ((((int32_t)L_19) < ((int32_t)((int32_t)50))))
		{
			goto IL_006e;
		}
	}
	{
		// year += 1900;
		int32_t L_20 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_20, (int32_t)((int32_t)1900)));
		goto IL_007b;
	}

IL_006e:
	{
		// else if (year < 50)
		int32_t L_21 = V_2;
		if ((((int32_t)L_21) >= ((int32_t)((int32_t)50))))
		{
			goto IL_007b;
		}
	}
	{
		// year += 2000;
		int32_t L_22 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_22, (int32_t)((int32_t)2000)));
	}

IL_007b:
	{
		// curIdx += 2;
		int32_t L_23 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_23, (int32_t)2));
		// }
		goto IL_0093;
	}

IL_0081:
	{
		// year = Int32.Parse(time.Substring(0, 4));
		String_t* L_24 = V_0;
		NullCheck(L_24);
		String_t* L_25;
		L_25 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_24, 0, 4, /*hidden argument*/NULL);
		int32_t L_26;
		L_26 = Int32_Parse_mE5D220FEA7F0BFB1B220B2A30797D7DD83ACF22C(L_25, /*hidden argument*/NULL);
		V_2 = L_26;
		// curIdx += 4;
		int32_t L_27 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_27, (int32_t)4));
	}

IL_0093:
	{
		// int month = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		String_t* L_28 = V_0;
		int32_t L_29 = V_1;
		NullCheck(L_28);
		String_t* L_30;
		L_30 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_28, L_29, 2, /*hidden argument*/NULL);
		int32_t L_31;
		L_31 = Int32_Parse_mE5D220FEA7F0BFB1B220B2A30797D7DD83ACF22C(L_30, /*hidden argument*/NULL);
		V_3 = L_31;
		// int month = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		int32_t L_32 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_32, (int32_t)2));
		// int dom = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		String_t* L_33 = V_0;
		int32_t L_34 = V_1;
		NullCheck(L_33);
		String_t* L_35;
		L_35 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_33, L_34, 2, /*hidden argument*/NULL);
		int32_t L_36;
		L_36 = Int32_Parse_mE5D220FEA7F0BFB1B220B2A30797D7DD83ACF22C(L_35, /*hidden argument*/NULL);
		V_4 = L_36;
		// int dom = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		int32_t L_37 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_37, (int32_t)2));
		// int hour = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		String_t* L_38 = V_0;
		int32_t L_39 = V_1;
		NullCheck(L_38);
		String_t* L_40;
		L_40 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_38, L_39, 2, /*hidden argument*/NULL);
		int32_t L_41;
		L_41 = Int32_Parse_mE5D220FEA7F0BFB1B220B2A30797D7DD83ACF22C(L_40, /*hidden argument*/NULL);
		V_5 = L_41;
		// int hour = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		int32_t L_42 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_42, (int32_t)2));
		// int min = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		String_t* L_43 = V_0;
		int32_t L_44 = V_1;
		NullCheck(L_43);
		String_t* L_45;
		L_45 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_43, L_44, 2, /*hidden argument*/NULL);
		int32_t L_46;
		L_46 = Int32_Parse_mE5D220FEA7F0BFB1B220B2A30797D7DD83ACF22C(L_45, /*hidden argument*/NULL);
		V_6 = L_46;
		// int min = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		int32_t L_47 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_47, (int32_t)2));
		// int secs = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		String_t* L_48 = V_0;
		int32_t L_49 = V_1;
		NullCheck(L_48);
		String_t* L_50;
		L_50 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_48, L_49, 2, /*hidden argument*/NULL);
		int32_t L_51;
		L_51 = Int32_Parse_mE5D220FEA7F0BFB1B220B2A30797D7DD83ACF22C(L_50, /*hidden argument*/NULL);
		V_7 = L_51;
		// int secs = Int32.Parse(time.Substring(curIdx, 2)); curIdx += 2;
		int32_t L_52 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_52, (int32_t)2));
		// return new DateTime(year, month, dom, hour, min, secs, DateTimeKind.Utc);
		int32_t L_53 = V_2;
		int32_t L_54 = V_3;
		int32_t L_55 = V_4;
		int32_t L_56 = V_5;
		int32_t L_57 = V_6;
		int32_t L_58 = V_7;
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_59;
		memset((&L_59), 0, sizeof(L_59));
		DateTime__ctor_mE84FCDCEAD332A62B587191C5874DAD7C238CFEA((&L_59), L_53, L_54, L_55, L_56, L_57, L_58, 1, /*hidden argument*/NULL);
		return L_59;
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline (String_t* __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_m_stringLength_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Parser_get_RootNode_m4359D48A87548584ACCF8540BA10BD7326091DAC_inline (Asn1Parser_t78462A8E22C56731876E81C066EAF35F109FFEBD * __this, const RuntimeMethod* method)
{
	{
		// return rootNode;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = __this->get_rootNode_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * PKCS7_get_data_m6D8A2F87A739A82DD799A4221D0694378AE72766_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method)
{
	{
		// public Asn1Node data { get; private set; }
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = __this->get_U3CdataU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_bundleID_m25A02C4A40C8E054E863C72E2D4AD23695FE3482_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string bundleID { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CbundleIDU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_appVersion_m5D30750E5D757BB076E3B17EB3C2F18A3232A0DD_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string appVersion { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CappVersionU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_opaque_mA8F53007E41556E07493855602A21573751D67ED_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___value0, const RuntimeMethod* method)
{
	{
		// public byte[] opaque { get; internal set; }
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = ___value0;
		__this->set_U3CopaqueU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_hash_m98652052746864E8676E6E374A419E371E9E13DF_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___value0, const RuntimeMethod* method)
{
	{
		// public byte[] hash { get; internal set; }
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = ___value0;
		__this->set_U3ChashU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_receiptCreationDate_m00A21F12F64E78048EFF1AC76A9A3E7A3A2742EE_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime receiptCreationDate { get; internal set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CreceiptCreationDateU3Ek__BackingField_5(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleReceipt_set_originalApplicationVersion_mDEB66DD33895134615538BC540A7A7868FAE3C83_inline (AppleReceipt_t22259E08F1B556242C6E6EE1A41F25B4F8860D62 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string originalApplicationVersion { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CoriginalApplicationVersionU3Ek__BackingField_4(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Asn1Node_get_IsIndefiniteLength_mD03D4CDC16E172CB7384EF056509817408C83FBB_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return isIndefiniteLength;
		bool L_0 = __this->get_isIndefiniteLength_11();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_quantity_m7838C12ED8258D3ECCDA44599A8664D99350F9BB_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public int quantity { get; internal set; }
		int32_t L_0 = ___value0;
		__this->set_U3CquantityU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_productID_m20774404517FD2203A1B5C87D1DF035836A58C99_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string productID { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CproductIDU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_transactionID_mEF8CCA16FE937E8CD2058B032515369E98146333_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string transactionID { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CtransactionIDU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_originalTransactionIdentifier_mCB042EF9C653D71F4875FCDEE6DF1808F8E3C070_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string originalTransactionIdentifier { get; internal set; }
		String_t* L_0 = ___value0;
		__this->set_U3CoriginalTransactionIdentifierU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_purchaseDate_m38F96B704E6F95810EA9848C5B67587C42D0DFEA_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime purchaseDate { get; internal set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CpurchaseDateU3Ek__BackingField_4(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_originalPurchaseDate_mCA445C1C9420F56D6EE01331D33A688D009BCF03_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime originalPurchaseDate { get; internal set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CoriginalPurchaseDateU3Ek__BackingField_5(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_subscriptionExpirationDate_mDA1D62DFD0BA2599664C19A4CE0A58404E73A80C_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime subscriptionExpirationDate { get; internal set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CsubscriptionExpirationDateU3Ek__BackingField_6(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_cancellationDate_mD0B29F011BB2B30D117E19E1E8FC3F8E7EFEE0E5_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime cancellationDate { get; internal set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CcancellationDateU3Ek__BackingField_7(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_productType_m1348D5CF0996703DF6B089CA2CBD9CDAC125ED17_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public int productType { get; internal set; }
		int32_t L_0 = ___value0;
		__this->set_U3CproductTypeU3Ek__BackingField_9(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_isFreeTrial_mA51C247092E28915A28200F715EB1BEBB1CC88C0_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public int isFreeTrial { get; internal set; }
		int32_t L_0 = ___value0;
		__this->set_U3CisFreeTrialU3Ek__BackingField_8(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void AppleInAppPurchaseReceipt_set_isIntroductoryPricePeriod_mA41926584FDAD3A1FA54A9BC0816D9741BB1D365_inline (AppleInAppPurchaseReceipt_t64E09258E0CC803DC0A93786AD32A737588BEA36 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public int isIntroductoryPricePeriod { get; internal set; }
		int32_t L_0 = ___value0;
		__this->set_U3CisIntroductoryPricePeriodU3Ek__BackingField_10(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int64_t Asn1Node_get_Deepness_m2ED875AFAB0B74DC5A8622DB3B3D18C4B7F6E95F_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return deepness;
		int64_t L_0 = __this->get_deepness_7();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Asn1Node_set_RequireRecalculatePar_m39322AC2FD6FC053F6E61C5665C0898C7E52C21F_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// requireRecalculatePar = value;
		bool L_0 = ___value0;
		__this->set_requireRecalculatePar_10(L_0);
		// }
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * Asn1Node_get_ParentNode_mB1CB94F695AF71514E30EFEA66AD34AF626D2E44_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return parentNode;
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = __this->get_parentNode_9();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int64_t Asn1Node_get_DataLength_mCF41384470AB94796BC81FCA252C18AB3513BBD8_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return dataLength;
		int64_t L_0 = __this->get_dataLength_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_Country_m5FEE9E1CA4B8090244EFC4C035C4B602B5812FF0_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string Country { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CCountryU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_Organization_mE46F109C4F90063C1424156D4A82676305D1FC68_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string Organization { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3COrganizationU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_OrganizationalUnit_mF45FFA1898130492704A1D74B8A2D3381553A874_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string OrganizationalUnit { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3COrganizationalUnitU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_CommonName_m699DA7948C7C23CB270E88A56453A54B826A7197_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string CommonName { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CCommonNameU3Ek__BackingField_5(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_SerialNumber_m4BC141696476B8DCD83E21BC78F3CA5A57316B74_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string SerialNumber { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CSerialNumberU3Ek__BackingField_6(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_Dnq_m5804E8D6845E922F9E4ABA254387CCA4BB2EF63D_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string Dnq { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CDnqU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void DistinguishedName_set_State_mD31D1EC2DB9AF12BB9C27511CDA0E1B2381BC0E6_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string State { get; set; }
		String_t* L_0 = ___value0;
		__this->set_U3CStateU3Ek__BackingField_4(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Organization_m7099D111E9B3D9F4EBA74CFE022080B6AF2E4571_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string Organization { get; set; }
		String_t* L_0 = __this->get_U3COrganizationU3Ek__BackingField_1();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_OrganizationalUnit_mA770C2BF2D42EFBC103C06EE7D2196C6977CA499_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string OrganizationalUnit { get; set; }
		String_t* L_0 = __this->get_U3COrganizationalUnitU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Dnq_mF2BDB440F23D8D256304AD7385170B20823E7E40_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string Dnq { get; set; }
		String_t* L_0 = __this->get_U3CDnqU3Ek__BackingField_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_Country_m7428D857116758C8131C1A89D0ECBD9300257478_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string Country { get; set; }
		String_t* L_0 = __this->get_U3CCountryU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_State_mB6E45565C187F37F8AA400B6126A3DDB7F8964F4_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string State { get; set; }
		String_t* L_0 = __this->get_U3CStateU3Ek__BackingField_4();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* DistinguishedName_get_CommonName_mF8E6F3B5D8AC9A1DBCBD08F7F9BF5445B61676A1_inline (DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * __this, const RuntimeMethod* method)
{
	{
		// public string CommonName { get; set; }
		String_t* L_0 = __this->get_U3CCommonNameU3Ek__BackingField_5();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR uint8_t Asn1Node_get_Tag_m2BA001DB85E537BE1C1D3C77D6C8D5B9F38D6315_inline (Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * __this, const RuntimeMethod* method)
{
	{
		// return tag;
		uint8_t L_0 = __this->get_tag_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PKCS7_set_data_m1BCC45AFBD0BC0E7F7A108C65F1FC8DC42A57489_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___value0, const RuntimeMethod* method)
{
	{
		// public Asn1Node data { get; private set; }
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___value0;
		__this->set_U3CdataU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PKCS7_set_certChain_m3393852EBF6A9ACF57D248CD5CD96E7170DA9257_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * ___value0, const RuntimeMethod* method)
{
	{
		// public List<X509Cert> certChain { get; private set; }
		List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * L_0 = ___value0;
		__this->set_U3CcertChainU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * PKCS7_get_certChain_m00B476DB0047B4C9991F5B435BFACD1124394373_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method)
{
	{
		// public List<X509Cert> certChain { get; private set; }
		List_1_t8B69BF48F0DFFB3347B4D34F83561F5D17D81AD3 * L_0 = __this->get_U3CcertChainU3Ek__BackingField_3();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void PKCS7_set_sinfos_mE2B572994330BFEF8B073BCD8D6C1EC384DC2BC7_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * ___value0, const RuntimeMethod* method)
{
	{
		// public List<SignerInfo> sinfos { get; private set; }
		List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * L_0 = ___value0;
		__this->set_U3CsinfosU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * PKCS7_get_sinfos_mC974631B995F6B9AC43EFD1E5B02F8EE112F278F_inline (PKCS7_tF0F3D93619D36162DE24C0690C7C12FABDF00A71 * __this, const RuntimeMethod* method)
{
	{
		// public List<SignerInfo> sinfos { get; private set; }
		List_1_tB3F7A52E12405C408573F2FD97A2AA1F57CF3E18 * L_0 = __this->get_U3CsinfosU3Ek__BackingField_2();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RSAKey_set_rsa_m5B74E411FA4685E4484F1EEF973E02F1F008A4F5_inline (RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * __this, RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * ___value0, const RuntimeMethod* method)
{
	{
		// public RSACryptoServiceProvider rsa { get; private set; }
		RSACryptoServiceProvider_tBE6479FC7CD7D294BC6D67E41F90B9D3BBF592B7 * L_0 = ___value0;
		__this->set_U3CrsaU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SignerInfo_set_Version_m096A7A01379DBFE817CB261272AE462789B619CF_inline (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		// public int Version { get; private set; }
		int32_t L_0 = ___value0;
		__this->set_U3CVersionU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t SignerInfo_get_Version_m7967FD171D0CD045416CF0CD8EE86F880B5AFDA1_inline (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, const RuntimeMethod* method)
{
	{
		// public int Version { get; private set; }
		int32_t L_0 = __this->get_U3CVersionU3Ek__BackingField_0();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SignerInfo_set_IssuerSerialNumber_mCF2536D75E277F4AF7311E105A586BC8087BC8E2_inline (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string IssuerSerialNumber { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CIssuerSerialNumberU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SignerInfo_set_EncryptedDigest_mBF05E641B22261C4D7A5DAE5F5FCD59BBDA1505B_inline (SignerInfo_tC9E860AB5B51AF1E058021C55B4CA1D3B1D1C5AB * __this, ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ___value0, const RuntimeMethod* method)
{
	{
		// public byte[] EncryptedDigest { get; private set; }
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = ___value0;
		__this->set_U3CEncryptedDigestU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_SerialNumber_mFA0667C943FA625300BE9D274F35630B7C918604_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		// public string SerialNumber { get; private set; }
		String_t* L_0 = ___value0;
		__this->set_U3CSerialNumberU3Ek__BackingField_0(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_Issuer_m9FC621236D22A3F23C3F94338EF6544D34B5D94B_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___value0, const RuntimeMethod* method)
{
	{
		// public DistinguishedName Issuer { get; private set; }
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_0 = ___value0;
		__this->set_U3CIssuerU3Ek__BackingField_6(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_Subject_m5649A924BEB6DD0E9039AEB2232D4ECF0AD70FE4_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * ___value0, const RuntimeMethod* method)
{
	{
		// public DistinguishedName Subject { get; private set; }
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_0 = ___value0;
		__this->set_U3CSubjectU3Ek__BackingField_5(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_ValidAfter_m206F8F9D9BE5AAF09187DD65143E73C7DA19A46F_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime ValidAfter { get; private set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CValidAfterU3Ek__BackingField_1(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_ValidBefore_m9C8AE3C70CA68DCFE66E72C82AFC2861979CB6B7_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	{
		// public DateTime ValidBefore { get; private set; }
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		__this->set_U3CValidBeforeU3Ek__BackingField_2(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * X509Cert_get_Subject_m12D21A6B054646292F89E16073D231ADD945FF61_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, const RuntimeMethod* method)
{
	{
		// public DistinguishedName Subject { get; private set; }
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_0 = __this->get_U3CSubjectU3Ek__BackingField_5();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * X509Cert_get_Issuer_m046958208FB8B4569B0F9A4D2B8EBC7DE6B6987B_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, const RuntimeMethod* method)
{
	{
		// public DistinguishedName Issuer { get; private set; }
		DistinguishedName_t1437C4FE7FAAC6905557200AF34854DCC80E1E90 * L_0 = __this->get_U3CIssuerU3Ek__BackingField_6();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_SelfSigned_m73D24826515F4DA3F86453E6E70B92C1C8500A90_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// public bool SelfSigned { get; private set; }
		bool L_0 = ___value0;
		__this->set_U3CSelfSignedU3Ek__BackingField_4(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_PubKey_mE5DCFEA38790817EF1860B54E27D06465C915D5F_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * ___value0, const RuntimeMethod* method)
{
	{
		// public RSAKey PubKey { get; private set; }
		RSAKey_t44D946D5B3A7E95C97A3F26C1C7EECF930E8FCE6 * L_0 = ___value0;
		__this->set_U3CPubKeyU3Ek__BackingField_3(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void X509Cert_set_Signature_m4E664BC494904845D1CBC1B766CA37FA0C089A2E_inline (X509Cert_tF31A0BE593C3D809F37846F4C4B031AD25A5B77C * __this, Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * ___value0, const RuntimeMethod* method)
{
	{
		// public Asn1Node Signature { get; private set; }
		Asn1Node_t50DC04D8CC8E178178EE4CDD84AFD2BCD38493F3 * L_0 = ___value0;
		__this->set_U3CSignatureU3Ek__BackingField_8(L_0);
		return;
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
