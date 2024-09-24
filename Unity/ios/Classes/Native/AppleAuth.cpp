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

// System.Action`1<AppleAuth.Enums.CredentialState>
struct Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178;
// System.Action`1<AppleAuth.Interfaces.IAppleError>
struct Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F;
// System.Action`1<AppleAuth.Interfaces.ICredential>
struct Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA;
// System.Action`1<System.Int32Enum>
struct Action_1_tF0FD284A49EB7135379250254D6B49FA84383C09;
// System.Action`1<System.Object>
struct Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC;
// System.Action`1<System.String>
struct Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3;
// System.Collections.Generic.Dictionary`2<System.UInt32,System.Object>
struct Dictionary_2_t32479D928C553725424938B11A68D3CD8069EA75;
// System.Collections.Generic.Dictionary`2<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>
struct Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE;
// System.Collections.Generic.IEqualityComparer`1<System.UInt32>
struct IEqualityComparer_1_t75C3361D3BE51E9742B0BBFA0F3998120E7CB6CE;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>
struct KeyCollection_t6057ED980E3422713330F5C7A92068D17C0B351C;
// System.Collections.Generic.List`1<System.Action>
struct List_1_t458734AF850139150AB40DFB2B5D1BCE23178235;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5;
// System.Collections.Generic.List`1<System.String>
struct List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>
struct ValueCollection_tBF82E9954A18793DA2F953D5EAE7368360017A8E;
// System.Collections.Generic.Dictionary`2/Entry<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>[]
struct EntryU5BU5D_tD8513BC8927800DA27D4597213473F165953D424;
// System.Action[]
struct ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2;
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
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
// System.Type[]
struct TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755;
// System.Action
struct Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6;
// AppleAuth.AppleAuthManager
struct AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48;
// AppleAuth.Native.AppleError
struct AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5;
// AppleAuth.Native.AppleIDCredential
struct AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// System.Reflection.Binder
struct Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30;
// AppleAuth.Native.CredentialStateResponse
struct CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// System.Exception
struct Exception_t;
// AppleAuth.Native.FullPersonName
struct FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F;
// AppleAuth.Interfaces.IAppleError
struct IAppleError_t67DF74DC018430779145EFC48504E9D023F98602;
// AppleAuth.Interfaces.IAppleIDCredential
struct IAppleIDCredential_tF8BE78143CEAA01854388D43EBE686724DABA567;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// AppleAuth.Interfaces.ICredential
struct ICredential_t45C23521279A83E4D31DB0FCFFCB0E8B5AF8759B;
// AppleAuth.Interfaces.ICredentialStateResponse
struct ICredentialStateResponse_t2CC47394E1D3C5FEBF97A30D2A3E289C7071FDDE;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// AppleAuth.Interfaces.ILoginWithAppleIdResponse
struct ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C;
// AppleAuth.Interfaces.IPasswordCredential
struct IPasswordCredential_tBB9B0F4215351CE7FCF21DCD47161721794E9064;
// AppleAuth.Interfaces.IPayloadDeserializer
struct IPayloadDeserializer_t9239EDD58B766683711ABF2E9862582281F71D49;
// AppleAuth.Interfaces.IPersonName
struct IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E;
// AppleAuth.Native.LoginWithAppleIdResponse
struct LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E;
// System.Reflection.MemberFilter
struct MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// AppleAuth.Native.PasswordCredential
struct PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372;
// AppleAuth.Native.PayloadDeserializer
struct PayloadDeserializer_t600547BA2304A4FA88803CCFEDE89EC5D9FBAD14;
// AppleAuth.Native.PersonName
struct PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.String
struct String_t;
// System.Text.StringBuilder
struct StringBuilder_t;
// System.Type
struct Type_t;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// AppleAuth.AppleAuthManager/<>c__DisplayClass10_0
struct U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29;
// AppleAuth.AppleAuthManager/<>c__DisplayClass7_0
struct U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB;
// AppleAuth.AppleAuthManager/<>c__DisplayClass9_0
struct U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817;
// AppleAuth.AppleAuthManager/CallbackHandler/<>c
struct U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465;
// AppleAuth.AppleAuthManager/CallbackHandler/<>c__DisplayClass14_0
struct U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C;
// AppleAuth.AppleAuthManager/CallbackHandler/Entry
struct Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417;
// AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate
struct NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA;

IL2CPP_EXTERN_C RuntimeClass* Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Console_t79987B1B5914E76054A8CBE506B9E11936A8BC07_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Enum_t23B90B40F60E677A8025267341651C94AE079CDA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IAppleError_t67DF74DC018430779145EFC48504E9D023F98602_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ICredentialStateResponse_t2CC47394E1D3C5FEBF97A30D2A3E289C7071FDDE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IPayloadDeserializer_t9239EDD58B766683711ABF2E9862582281F71D49_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t458734AF850139150AB40DFB2B5D1BCE23178235_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UInt32_tE60352A06233E4E69DD198BCC67142159F686B15_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral0C3C6829C3CCF8020C6AC45B87963ADC095CD44A;
IL2CPP_EXTERN_C String_t* _stringLiteral19ACA45079EF05169E31F35925318831A3818A1E;
IL2CPP_EXTERN_C String_t* _stringLiteral1F4A0E039A8EDC945B386FCBD017946A90DD1482;
IL2CPP_EXTERN_C String_t* _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745;
IL2CPP_EXTERN_C String_t* _stringLiteral2B40CC33334E727913DBC178F885E03EE82101DB;
IL2CPP_EXTERN_C String_t* _stringLiteral323F125E5D7C69BA15AAB717EC66868024836092;
IL2CPP_EXTERN_C String_t* _stringLiteral39E5FB85EEC80F6ADEB66C4385F2A26D2A4971F6;
IL2CPP_EXTERN_C String_t* _stringLiteral4AAD7578E022578EB4E96D24CE1D90283FF0579B;
IL2CPP_EXTERN_C String_t* _stringLiteral4B31B12774EADD6A7DE8A6382F262DAD80E785C9;
IL2CPP_EXTERN_C String_t* _stringLiteral4D6C09A5E22530642E0E4DFEE6451C33F878ECAE;
IL2CPP_EXTERN_C String_t* _stringLiteral4D8D9C94AC5DA5FCED2EC8A64E10E714A2515C30;
IL2CPP_EXTERN_C String_t* _stringLiteral66A865E28B2B5657FCF66691A6F7AC2B94FE50BA;
IL2CPP_EXTERN_C String_t* _stringLiteral6B0F8C117113DCAEA31A236AE8DD26B97E6CB442;
IL2CPP_EXTERN_C String_t* _stringLiteral83A3AA4026743A327B1E8CB980C4AF5DEFA1E953;
IL2CPP_EXTERN_C String_t* _stringLiteral93D9B00D6E9CE12A85069965CC351E5DE11CA3AD;
IL2CPP_EXTERN_C String_t* _stringLiteral9788FC9C452EE9A7B91598A36199A2CDE3698A4C;
IL2CPP_EXTERN_C String_t* _stringLiteralA0288CC1A5F3CF90F6C5630BC8E0B28DB90F2571;
IL2CPP_EXTERN_C String_t* _stringLiteralA2375F7B48A283E93E609EE95A59C68710F2EFE8;
IL2CPP_EXTERN_C String_t* _stringLiteralA95898025CC11DF26437FBBC4B43CA5F697F5DB1;
IL2CPP_EXTERN_C String_t* _stringLiteralAAFEF493C52F96B5A12AC31A8C67F85BBF99BC17;
IL2CPP_EXTERN_C String_t* _stringLiteralC4C24815B709651078475AD9B46BEF647015D240;
IL2CPP_EXTERN_C String_t* _stringLiteralCA0DA7AFA13D06380B286383F61CFD3BFBFDEB4B;
IL2CPP_EXTERN_C String_t* _stringLiteralDA3990537E355E81C23A6B8320705118BC1046ED;
IL2CPP_EXTERN_C String_t* _stringLiteralFB14AD5D529C63D6104FCC6253259F2F5B0E793D;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_m6E81F94353B45920E7018D209DCF4B63DBE8D8B6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_m962693B0F6FA0C65C36BFDC35E053E1125FA149A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* CallbackHandler_AddMessageCallback_m7B194DE6CC041640E88BDB3111D732D7BE355E92_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* CallbackHandler_RemoveMessageCallback_m21605F49CE514727FB7861F0ED428D341E2FD4D2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Add_mEF7ADA2611CF6AE754C1D3B6109D3C4A81D20A95_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_ContainsKey_m782EBE8C977F074B6717FB7C1A23B70904B6AF69_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_Remove_m31296A3D9862AFFD78839933103BFA7B99CCCBE7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_m821D7367424A9A61214C4CA1B2B608708636F93E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_m1F3234CA822823DFC744DCE9DF739A4EDD0C8882_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* JsonUtility_FromJson_TisCredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433_mF602D4AE88853D8A2A9C9D40421058B6834CFFDC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* JsonUtility_FromJson_TisLoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E_m5FE146A960E6F18BFFB51D58B287890DD5E53A21_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m7701B455B6EA0411642596847118B51F91DA8BC9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_RemoveAt_mD4CD85C9E5FDA40D3274952962B580A0BA3349FD_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_m94163AE84EBF9A1F7483014A8E9906BD93D9EBDB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m30C52A4F2828D86CA3FAB0B1B583948F4DA9F1F9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m8F3A8E6C64C39DA66FF5F99E7A6BB97B41A482BB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m62C12145DD437794F8660D2396A00A7B2BA480C5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m9F0A626A47DAE7452E139A6961335BE81507E551_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PInvoke_NativeMessageHandlerCallback_mBA8562A025E9B934C3F7F672E02E08EF2033E8B3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SerializationTools_FixSerializationForArray_TisString_t_m4508C4D7A8194BD8A3F86525D870B214646B89D8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SerializationTools_FixSerializationForObject_TisAppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5_mF02F1B47277A639EDF4EDBE0123B1FC5E289E017_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SerializationTools_FixSerializationForObject_TisAppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612_m56697900B3FA29ADB060E74DB02057455D909D96_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SerializationTools_FixSerializationForObject_TisFullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F_m2C9FB5DFB296EC5FD48BDE7B7B83550625AA55FE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SerializationTools_FixSerializationForObject_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mC91420AF1574C1B1A3945354470789F8D482CAC5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SerializationTools_FixSerializationForObject_TisPasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372_mD95DFFCC92BBB817B7B3842C2A4CFA956459D63C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* SerializationTools_FixSerializationForObject_TisPersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575_m617A30C4801302EBEA5A9372B5F749559919980B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec_U3Cadd_NativeCredentialsRevokedU3Eb__12_0_m7A6F70094F70AAC04CD30A3BC7BD49E2E3CADB78_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass10_0_U3CGetCredentialStateU3Eb__0_m86C591492D3EFBD62625107928D944A52044BA59_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass14_0_U3CScheduleCallbackU3Eb__0_m675187383F28AA97201E57D51CF47571A67846ED_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass7_0_U3CQuickLoginU3Eb__0_m0163857449472462097FE98E94EE2C764791D43B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass9_0_U3CLoginWithAppleIdU3Eb__0_mA62EB5BB7611FA73AFDB2697C47D792A7122E3EF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* AuthorizationErrorCode_t39345506E8A14B87DC20E75D12142CE1804DF557_0_0_0_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
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
struct U3CModuleU3E_t75DDC8AAD9056B9EBB1649415471CD76BA087A7E 
{
public:

public:
};


// System.Object


// System.Collections.Generic.Dictionary`2<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>
struct Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_tD8513BC8927800DA27D4597213473F165953D424* ___entries_1;
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
	KeyCollection_t6057ED980E3422713330F5C7A92068D17C0B351C * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_tBF82E9954A18793DA2F953D5EAE7368360017A8E * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___entries_1)); }
	inline EntryU5BU5D_tD8513BC8927800DA27D4597213473F165953D424* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_tD8513BC8927800DA27D4597213473F165953D424** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_tD8513BC8927800DA27D4597213473F165953D424* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___keys_7)); }
	inline KeyCollection_t6057ED980E3422713330F5C7A92068D17C0B351C * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t6057ED980E3422713330F5C7A92068D17C0B351C ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t6057ED980E3422713330F5C7A92068D17C0B351C * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ___values_8)); }
	inline ValueCollection_tBF82E9954A18793DA2F953D5EAE7368360017A8E * get_values_8() const { return ___values_8; }
	inline ValueCollection_tBF82E9954A18793DA2F953D5EAE7368360017A8E ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_tBF82E9954A18793DA2F953D5EAE7368360017A8E * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_9), (void*)value);
	}
};


// System.Collections.Generic.List`1<System.Action>
struct List_1_t458734AF850139150AB40DFB2B5D1BCE23178235  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t458734AF850139150AB40DFB2B5D1BCE23178235, ____items_1)); }
	inline ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2* get__items_1() const { return ____items_1; }
	inline ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t458734AF850139150AB40DFB2B5D1BCE23178235, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t458734AF850139150AB40DFB2B5D1BCE23178235, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t458734AF850139150AB40DFB2B5D1BCE23178235, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t458734AF850139150AB40DFB2B5D1BCE23178235_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t458734AF850139150AB40DFB2B5D1BCE23178235_StaticFields, ____emptyArray_5)); }
	inline ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ActionU5BU5D_t4184CD78B103476FA93E685EDBF3C083DBA9E2C2* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
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


// System.Collections.Generic.List`1<System.String>
struct List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3, ____items_1)); }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* get__items_1() const { return ____items_1; }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3_StaticFields, ____emptyArray_5)); }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* get__emptyArray_5() const { return ____emptyArray_5; }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// AppleAuth.AppleAuthManager
struct AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48  : public RuntimeObject
{
public:
	// AppleAuth.Interfaces.IPayloadDeserializer AppleAuth.AppleAuthManager::_payloadDeserializer
	RuntimeObject* ____payloadDeserializer_0;
	// System.Action`1<System.String> AppleAuth.AppleAuthManager::_credentialsRevokedCallback
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ____credentialsRevokedCallback_1;

public:
	inline static int32_t get_offset_of__payloadDeserializer_0() { return static_cast<int32_t>(offsetof(AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48, ____payloadDeserializer_0)); }
	inline RuntimeObject* get__payloadDeserializer_0() const { return ____payloadDeserializer_0; }
	inline RuntimeObject** get_address_of__payloadDeserializer_0() { return &____payloadDeserializer_0; }
	inline void set__payloadDeserializer_0(RuntimeObject* value)
	{
		____payloadDeserializer_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____payloadDeserializer_0), (void*)value);
	}

	inline static int32_t get_offset_of__credentialsRevokedCallback_1() { return static_cast<int32_t>(offsetof(AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48, ____credentialsRevokedCallback_1)); }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * get__credentialsRevokedCallback_1() const { return ____credentialsRevokedCallback_1; }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 ** get_address_of__credentialsRevokedCallback_1() { return &____credentialsRevokedCallback_1; }
	inline void set__credentialsRevokedCallback_1(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * value)
	{
		____credentialsRevokedCallback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____credentialsRevokedCallback_1), (void*)value);
	}
};


// AppleAuth.Native.AppleError
struct AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5  : public RuntimeObject
{
public:
	// System.Int32 AppleAuth.Native.AppleError::_code
	int32_t ____code_0;
	// System.String AppleAuth.Native.AppleError::_domain
	String_t* ____domain_1;
	// System.String AppleAuth.Native.AppleError::_localizedDescription
	String_t* ____localizedDescription_2;
	// System.String[] AppleAuth.Native.AppleError::_localizedRecoveryOptions
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ____localizedRecoveryOptions_3;
	// System.String AppleAuth.Native.AppleError::_localizedRecoverySuggestion
	String_t* ____localizedRecoverySuggestion_4;
	// System.String AppleAuth.Native.AppleError::_localizedFailureReason
	String_t* ____localizedFailureReason_5;

public:
	inline static int32_t get_offset_of__code_0() { return static_cast<int32_t>(offsetof(AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5, ____code_0)); }
	inline int32_t get__code_0() const { return ____code_0; }
	inline int32_t* get_address_of__code_0() { return &____code_0; }
	inline void set__code_0(int32_t value)
	{
		____code_0 = value;
	}

	inline static int32_t get_offset_of__domain_1() { return static_cast<int32_t>(offsetof(AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5, ____domain_1)); }
	inline String_t* get__domain_1() const { return ____domain_1; }
	inline String_t** get_address_of__domain_1() { return &____domain_1; }
	inline void set__domain_1(String_t* value)
	{
		____domain_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____domain_1), (void*)value);
	}

	inline static int32_t get_offset_of__localizedDescription_2() { return static_cast<int32_t>(offsetof(AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5, ____localizedDescription_2)); }
	inline String_t* get__localizedDescription_2() const { return ____localizedDescription_2; }
	inline String_t** get_address_of__localizedDescription_2() { return &____localizedDescription_2; }
	inline void set__localizedDescription_2(String_t* value)
	{
		____localizedDescription_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____localizedDescription_2), (void*)value);
	}

	inline static int32_t get_offset_of__localizedRecoveryOptions_3() { return static_cast<int32_t>(offsetof(AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5, ____localizedRecoveryOptions_3)); }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* get__localizedRecoveryOptions_3() const { return ____localizedRecoveryOptions_3; }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** get_address_of__localizedRecoveryOptions_3() { return &____localizedRecoveryOptions_3; }
	inline void set__localizedRecoveryOptions_3(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* value)
	{
		____localizedRecoveryOptions_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____localizedRecoveryOptions_3), (void*)value);
	}

	inline static int32_t get_offset_of__localizedRecoverySuggestion_4() { return static_cast<int32_t>(offsetof(AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5, ____localizedRecoverySuggestion_4)); }
	inline String_t* get__localizedRecoverySuggestion_4() const { return ____localizedRecoverySuggestion_4; }
	inline String_t** get_address_of__localizedRecoverySuggestion_4() { return &____localizedRecoverySuggestion_4; }
	inline void set__localizedRecoverySuggestion_4(String_t* value)
	{
		____localizedRecoverySuggestion_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____localizedRecoverySuggestion_4), (void*)value);
	}

	inline static int32_t get_offset_of__localizedFailureReason_5() { return static_cast<int32_t>(offsetof(AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5, ____localizedFailureReason_5)); }
	inline String_t* get__localizedFailureReason_5() const { return ____localizedFailureReason_5; }
	inline String_t** get_address_of__localizedFailureReason_5() { return &____localizedFailureReason_5; }
	inline void set__localizedFailureReason_5(String_t* value)
	{
		____localizedFailureReason_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____localizedFailureReason_5), (void*)value);
	}
};


// AppleAuth.Extensions.AppleErrorExtensions
struct AppleErrorExtensions_t45C5FCC2492515F8BFEF9CBB2473D87F27B3343C  : public RuntimeObject
{
public:

public:
};


// AppleAuth.Native.AppleIDCredential
struct AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612  : public RuntimeObject
{
public:
	// System.String AppleAuth.Native.AppleIDCredential::_base64IdentityToken
	String_t* ____base64IdentityToken_0;
	// System.String AppleAuth.Native.AppleIDCredential::_base64AuthorizationCode
	String_t* ____base64AuthorizationCode_1;
	// System.String AppleAuth.Native.AppleIDCredential::_state
	String_t* ____state_2;
	// System.String AppleAuth.Native.AppleIDCredential::_user
	String_t* ____user_3;
	// System.String[] AppleAuth.Native.AppleIDCredential::_authorizedScopes
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ____authorizedScopes_4;
	// System.Boolean AppleAuth.Native.AppleIDCredential::_hasFullName
	bool ____hasFullName_5;
	// AppleAuth.Native.FullPersonName AppleAuth.Native.AppleIDCredential::_fullName
	FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F * ____fullName_6;
	// System.String AppleAuth.Native.AppleIDCredential::_email
	String_t* ____email_7;
	// System.Int32 AppleAuth.Native.AppleIDCredential::_realUserStatus
	int32_t ____realUserStatus_8;
	// System.Byte[] AppleAuth.Native.AppleIDCredential::_identityToken
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____identityToken_9;
	// System.Byte[] AppleAuth.Native.AppleIDCredential::_authorizationCode
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* ____authorizationCode_10;

public:
	inline static int32_t get_offset_of__base64IdentityToken_0() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____base64IdentityToken_0)); }
	inline String_t* get__base64IdentityToken_0() const { return ____base64IdentityToken_0; }
	inline String_t** get_address_of__base64IdentityToken_0() { return &____base64IdentityToken_0; }
	inline void set__base64IdentityToken_0(String_t* value)
	{
		____base64IdentityToken_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____base64IdentityToken_0), (void*)value);
	}

	inline static int32_t get_offset_of__base64AuthorizationCode_1() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____base64AuthorizationCode_1)); }
	inline String_t* get__base64AuthorizationCode_1() const { return ____base64AuthorizationCode_1; }
	inline String_t** get_address_of__base64AuthorizationCode_1() { return &____base64AuthorizationCode_1; }
	inline void set__base64AuthorizationCode_1(String_t* value)
	{
		____base64AuthorizationCode_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____base64AuthorizationCode_1), (void*)value);
	}

	inline static int32_t get_offset_of__state_2() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____state_2)); }
	inline String_t* get__state_2() const { return ____state_2; }
	inline String_t** get_address_of__state_2() { return &____state_2; }
	inline void set__state_2(String_t* value)
	{
		____state_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____state_2), (void*)value);
	}

	inline static int32_t get_offset_of__user_3() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____user_3)); }
	inline String_t* get__user_3() const { return ____user_3; }
	inline String_t** get_address_of__user_3() { return &____user_3; }
	inline void set__user_3(String_t* value)
	{
		____user_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____user_3), (void*)value);
	}

	inline static int32_t get_offset_of__authorizedScopes_4() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____authorizedScopes_4)); }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* get__authorizedScopes_4() const { return ____authorizedScopes_4; }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** get_address_of__authorizedScopes_4() { return &____authorizedScopes_4; }
	inline void set__authorizedScopes_4(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* value)
	{
		____authorizedScopes_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____authorizedScopes_4), (void*)value);
	}

	inline static int32_t get_offset_of__hasFullName_5() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____hasFullName_5)); }
	inline bool get__hasFullName_5() const { return ____hasFullName_5; }
	inline bool* get_address_of__hasFullName_5() { return &____hasFullName_5; }
	inline void set__hasFullName_5(bool value)
	{
		____hasFullName_5 = value;
	}

	inline static int32_t get_offset_of__fullName_6() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____fullName_6)); }
	inline FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F * get__fullName_6() const { return ____fullName_6; }
	inline FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F ** get_address_of__fullName_6() { return &____fullName_6; }
	inline void set__fullName_6(FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F * value)
	{
		____fullName_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____fullName_6), (void*)value);
	}

	inline static int32_t get_offset_of__email_7() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____email_7)); }
	inline String_t* get__email_7() const { return ____email_7; }
	inline String_t** get_address_of__email_7() { return &____email_7; }
	inline void set__email_7(String_t* value)
	{
		____email_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____email_7), (void*)value);
	}

	inline static int32_t get_offset_of__realUserStatus_8() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____realUserStatus_8)); }
	inline int32_t get__realUserStatus_8() const { return ____realUserStatus_8; }
	inline int32_t* get_address_of__realUserStatus_8() { return &____realUserStatus_8; }
	inline void set__realUserStatus_8(int32_t value)
	{
		____realUserStatus_8 = value;
	}

	inline static int32_t get_offset_of__identityToken_9() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____identityToken_9)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get__identityToken_9() const { return ____identityToken_9; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of__identityToken_9() { return &____identityToken_9; }
	inline void set__identityToken_9(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		____identityToken_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____identityToken_9), (void*)value);
	}

	inline static int32_t get_offset_of__authorizationCode_10() { return static_cast<int32_t>(offsetof(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612, ____authorizationCode_10)); }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* get__authorizationCode_10() const { return ____authorizationCode_10; }
	inline ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726** get_address_of__authorizationCode_10() { return &____authorizationCode_10; }
	inline void set__authorizationCode_10(ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* value)
	{
		____authorizationCode_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____authorizationCode_10), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// AppleAuth.Native.CredentialStateResponse
struct CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433  : public RuntimeObject
{
public:
	// System.Boolean AppleAuth.Native.CredentialStateResponse::_success
	bool ____success_0;
	// System.Boolean AppleAuth.Native.CredentialStateResponse::_hasCredentialState
	bool ____hasCredentialState_1;
	// System.Boolean AppleAuth.Native.CredentialStateResponse::_hasError
	bool ____hasError_2;
	// System.Int32 AppleAuth.Native.CredentialStateResponse::_credentialState
	int32_t ____credentialState_3;
	// AppleAuth.Native.AppleError AppleAuth.Native.CredentialStateResponse::_error
	AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * ____error_4;

public:
	inline static int32_t get_offset_of__success_0() { return static_cast<int32_t>(offsetof(CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433, ____success_0)); }
	inline bool get__success_0() const { return ____success_0; }
	inline bool* get_address_of__success_0() { return &____success_0; }
	inline void set__success_0(bool value)
	{
		____success_0 = value;
	}

	inline static int32_t get_offset_of__hasCredentialState_1() { return static_cast<int32_t>(offsetof(CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433, ____hasCredentialState_1)); }
	inline bool get__hasCredentialState_1() const { return ____hasCredentialState_1; }
	inline bool* get_address_of__hasCredentialState_1() { return &____hasCredentialState_1; }
	inline void set__hasCredentialState_1(bool value)
	{
		____hasCredentialState_1 = value;
	}

	inline static int32_t get_offset_of__hasError_2() { return static_cast<int32_t>(offsetof(CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433, ____hasError_2)); }
	inline bool get__hasError_2() const { return ____hasError_2; }
	inline bool* get_address_of__hasError_2() { return &____hasError_2; }
	inline void set__hasError_2(bool value)
	{
		____hasError_2 = value;
	}

	inline static int32_t get_offset_of__credentialState_3() { return static_cast<int32_t>(offsetof(CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433, ____credentialState_3)); }
	inline int32_t get__credentialState_3() const { return ____credentialState_3; }
	inline int32_t* get_address_of__credentialState_3() { return &____credentialState_3; }
	inline void set__credentialState_3(int32_t value)
	{
		____credentialState_3 = value;
	}

	inline static int32_t get_offset_of__error_4() { return static_cast<int32_t>(offsetof(CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433, ____error_4)); }
	inline AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * get__error_4() const { return ____error_4; }
	inline AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 ** get_address_of__error_4() { return &____error_4; }
	inline void set__error_4(AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * value)
	{
		____error_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____error_4), (void*)value);
	}
};


// AppleAuth.Native.LoginWithAppleIdResponse
struct LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E  : public RuntimeObject
{
public:
	// System.Boolean AppleAuth.Native.LoginWithAppleIdResponse::_success
	bool ____success_0;
	// System.Boolean AppleAuth.Native.LoginWithAppleIdResponse::_hasAppleIdCredential
	bool ____hasAppleIdCredential_1;
	// System.Boolean AppleAuth.Native.LoginWithAppleIdResponse::_hasPasswordCredential
	bool ____hasPasswordCredential_2;
	// System.Boolean AppleAuth.Native.LoginWithAppleIdResponse::_hasError
	bool ____hasError_3;
	// AppleAuth.Native.AppleIDCredential AppleAuth.Native.LoginWithAppleIdResponse::_appleIdCredential
	AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * ____appleIdCredential_4;
	// AppleAuth.Native.PasswordCredential AppleAuth.Native.LoginWithAppleIdResponse::_passwordCredential
	PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * ____passwordCredential_5;
	// AppleAuth.Native.AppleError AppleAuth.Native.LoginWithAppleIdResponse::_error
	AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * ____error_6;

public:
	inline static int32_t get_offset_of__success_0() { return static_cast<int32_t>(offsetof(LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E, ____success_0)); }
	inline bool get__success_0() const { return ____success_0; }
	inline bool* get_address_of__success_0() { return &____success_0; }
	inline void set__success_0(bool value)
	{
		____success_0 = value;
	}

	inline static int32_t get_offset_of__hasAppleIdCredential_1() { return static_cast<int32_t>(offsetof(LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E, ____hasAppleIdCredential_1)); }
	inline bool get__hasAppleIdCredential_1() const { return ____hasAppleIdCredential_1; }
	inline bool* get_address_of__hasAppleIdCredential_1() { return &____hasAppleIdCredential_1; }
	inline void set__hasAppleIdCredential_1(bool value)
	{
		____hasAppleIdCredential_1 = value;
	}

	inline static int32_t get_offset_of__hasPasswordCredential_2() { return static_cast<int32_t>(offsetof(LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E, ____hasPasswordCredential_2)); }
	inline bool get__hasPasswordCredential_2() const { return ____hasPasswordCredential_2; }
	inline bool* get_address_of__hasPasswordCredential_2() { return &____hasPasswordCredential_2; }
	inline void set__hasPasswordCredential_2(bool value)
	{
		____hasPasswordCredential_2 = value;
	}

	inline static int32_t get_offset_of__hasError_3() { return static_cast<int32_t>(offsetof(LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E, ____hasError_3)); }
	inline bool get__hasError_3() const { return ____hasError_3; }
	inline bool* get_address_of__hasError_3() { return &____hasError_3; }
	inline void set__hasError_3(bool value)
	{
		____hasError_3 = value;
	}

	inline static int32_t get_offset_of__appleIdCredential_4() { return static_cast<int32_t>(offsetof(LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E, ____appleIdCredential_4)); }
	inline AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * get__appleIdCredential_4() const { return ____appleIdCredential_4; }
	inline AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 ** get_address_of__appleIdCredential_4() { return &____appleIdCredential_4; }
	inline void set__appleIdCredential_4(AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * value)
	{
		____appleIdCredential_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____appleIdCredential_4), (void*)value);
	}

	inline static int32_t get_offset_of__passwordCredential_5() { return static_cast<int32_t>(offsetof(LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E, ____passwordCredential_5)); }
	inline PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * get__passwordCredential_5() const { return ____passwordCredential_5; }
	inline PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 ** get_address_of__passwordCredential_5() { return &____passwordCredential_5; }
	inline void set__passwordCredential_5(PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * value)
	{
		____passwordCredential_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____passwordCredential_5), (void*)value);
	}

	inline static int32_t get_offset_of__error_6() { return static_cast<int32_t>(offsetof(LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E, ____error_6)); }
	inline AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * get__error_6() const { return ____error_6; }
	inline AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 ** get_address_of__error_6() { return &____error_6; }
	inline void set__error_6(AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * value)
	{
		____error_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____error_6), (void*)value);
	}
};


// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
public:

public:
};


// AppleAuth.Native.PasswordCredential
struct PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372  : public RuntimeObject
{
public:
	// System.String AppleAuth.Native.PasswordCredential::_user
	String_t* ____user_0;
	// System.String AppleAuth.Native.PasswordCredential::_password
	String_t* ____password_1;

public:
	inline static int32_t get_offset_of__user_0() { return static_cast<int32_t>(offsetof(PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372, ____user_0)); }
	inline String_t* get__user_0() const { return ____user_0; }
	inline String_t** get_address_of__user_0() { return &____user_0; }
	inline void set__user_0(String_t* value)
	{
		____user_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____user_0), (void*)value);
	}

	inline static int32_t get_offset_of__password_1() { return static_cast<int32_t>(offsetof(PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372, ____password_1)); }
	inline String_t* get__password_1() const { return ____password_1; }
	inline String_t** get_address_of__password_1() { return &____password_1; }
	inline void set__password_1(String_t* value)
	{
		____password_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____password_1), (void*)value);
	}
};


// AppleAuth.Native.PayloadDeserializer
struct PayloadDeserializer_t600547BA2304A4FA88803CCFEDE89EC5D9FBAD14  : public RuntimeObject
{
public:

public:
};


// AppleAuth.Native.PersonName
struct PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575  : public RuntimeObject
{
public:
	// System.String AppleAuth.Native.PersonName::_namePrefix
	String_t* ____namePrefix_0;
	// System.String AppleAuth.Native.PersonName::_givenName
	String_t* ____givenName_1;
	// System.String AppleAuth.Native.PersonName::_middleName
	String_t* ____middleName_2;
	// System.String AppleAuth.Native.PersonName::_familyName
	String_t* ____familyName_3;
	// System.String AppleAuth.Native.PersonName::_nameSuffix
	String_t* ____nameSuffix_4;
	// System.String AppleAuth.Native.PersonName::_nickname
	String_t* ____nickname_5;

public:
	inline static int32_t get_offset_of__namePrefix_0() { return static_cast<int32_t>(offsetof(PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575, ____namePrefix_0)); }
	inline String_t* get__namePrefix_0() const { return ____namePrefix_0; }
	inline String_t** get_address_of__namePrefix_0() { return &____namePrefix_0; }
	inline void set__namePrefix_0(String_t* value)
	{
		____namePrefix_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____namePrefix_0), (void*)value);
	}

	inline static int32_t get_offset_of__givenName_1() { return static_cast<int32_t>(offsetof(PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575, ____givenName_1)); }
	inline String_t* get__givenName_1() const { return ____givenName_1; }
	inline String_t** get_address_of__givenName_1() { return &____givenName_1; }
	inline void set__givenName_1(String_t* value)
	{
		____givenName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____givenName_1), (void*)value);
	}

	inline static int32_t get_offset_of__middleName_2() { return static_cast<int32_t>(offsetof(PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575, ____middleName_2)); }
	inline String_t* get__middleName_2() const { return ____middleName_2; }
	inline String_t** get_address_of__middleName_2() { return &____middleName_2; }
	inline void set__middleName_2(String_t* value)
	{
		____middleName_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____middleName_2), (void*)value);
	}

	inline static int32_t get_offset_of__familyName_3() { return static_cast<int32_t>(offsetof(PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575, ____familyName_3)); }
	inline String_t* get__familyName_3() const { return ____familyName_3; }
	inline String_t** get_address_of__familyName_3() { return &____familyName_3; }
	inline void set__familyName_3(String_t* value)
	{
		____familyName_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____familyName_3), (void*)value);
	}

	inline static int32_t get_offset_of__nameSuffix_4() { return static_cast<int32_t>(offsetof(PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575, ____nameSuffix_4)); }
	inline String_t* get__nameSuffix_4() const { return ____nameSuffix_4; }
	inline String_t** get_address_of__nameSuffix_4() { return &____nameSuffix_4; }
	inline void set__nameSuffix_4(String_t* value)
	{
		____nameSuffix_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____nameSuffix_4), (void*)value);
	}

	inline static int32_t get_offset_of__nickname_5() { return static_cast<int32_t>(offsetof(PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575, ____nickname_5)); }
	inline String_t* get__nickname_5() const { return ____nickname_5; }
	inline String_t** get_address_of__nickname_5() { return &____nickname_5; }
	inline void set__nickname_5(String_t* value)
	{
		____nickname_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____nickname_5), (void*)value);
	}
};


// AppleAuth.Extensions.PersonNameExtensions
struct PersonNameExtensions_tB234A08D9D6E2CCCDA431C52054E61B1A74FDF50  : public RuntimeObject
{
public:

public:
};


// AppleAuth.Native.SerializationTools
struct SerializationTools_tC546CCD340C287D0272F1654E9D7BCFC282DCA3F  : public RuntimeObject
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

// AppleAuth.AppleAuthManager/<>c__DisplayClass10_0
struct U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29  : public RuntimeObject
{
public:
	// AppleAuth.AppleAuthManager AppleAuth.AppleAuthManager/<>c__DisplayClass10_0::<>4__this
	AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * ___U3CU3E4__this_0;
	// System.Action`1<AppleAuth.Interfaces.IAppleError> AppleAuth.AppleAuthManager/<>c__DisplayClass10_0::errorCallback
	Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback_1;
	// System.Action`1<AppleAuth.Enums.CredentialState> AppleAuth.AppleAuthManager/<>c__DisplayClass10_0::successCallback
	Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 * ___successCallback_2;

public:
	inline static int32_t get_offset_of_U3CU3E4__this_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29, ___U3CU3E4__this_0)); }
	inline AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * get_U3CU3E4__this_0() const { return ___U3CU3E4__this_0; }
	inline AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 ** get_address_of_U3CU3E4__this_0() { return &___U3CU3E4__this_0; }
	inline void set_U3CU3E4__this_0(AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * value)
	{
		___U3CU3E4__this_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_0), (void*)value);
	}

	inline static int32_t get_offset_of_errorCallback_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29, ___errorCallback_1)); }
	inline Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * get_errorCallback_1() const { return ___errorCallback_1; }
	inline Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F ** get_address_of_errorCallback_1() { return &___errorCallback_1; }
	inline void set_errorCallback_1(Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * value)
	{
		___errorCallback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___errorCallback_1), (void*)value);
	}

	inline static int32_t get_offset_of_successCallback_2() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29, ___successCallback_2)); }
	inline Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 * get_successCallback_2() const { return ___successCallback_2; }
	inline Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 ** get_address_of_successCallback_2() { return &___successCallback_2; }
	inline void set_successCallback_2(Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 * value)
	{
		___successCallback_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___successCallback_2), (void*)value);
	}
};


// AppleAuth.AppleAuthManager/<>c__DisplayClass7_0
struct U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB  : public RuntimeObject
{
public:
	// AppleAuth.AppleAuthManager AppleAuth.AppleAuthManager/<>c__DisplayClass7_0::<>4__this
	AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * ___U3CU3E4__this_0;
	// System.Action`1<AppleAuth.Interfaces.IAppleError> AppleAuth.AppleAuthManager/<>c__DisplayClass7_0::errorCallback
	Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback_1;
	// System.Action`1<AppleAuth.Interfaces.ICredential> AppleAuth.AppleAuthManager/<>c__DisplayClass7_0::successCallback
	Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * ___successCallback_2;

public:
	inline static int32_t get_offset_of_U3CU3E4__this_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB, ___U3CU3E4__this_0)); }
	inline AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * get_U3CU3E4__this_0() const { return ___U3CU3E4__this_0; }
	inline AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 ** get_address_of_U3CU3E4__this_0() { return &___U3CU3E4__this_0; }
	inline void set_U3CU3E4__this_0(AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * value)
	{
		___U3CU3E4__this_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_0), (void*)value);
	}

	inline static int32_t get_offset_of_errorCallback_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB, ___errorCallback_1)); }
	inline Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * get_errorCallback_1() const { return ___errorCallback_1; }
	inline Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F ** get_address_of_errorCallback_1() { return &___errorCallback_1; }
	inline void set_errorCallback_1(Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * value)
	{
		___errorCallback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___errorCallback_1), (void*)value);
	}

	inline static int32_t get_offset_of_successCallback_2() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB, ___successCallback_2)); }
	inline Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * get_successCallback_2() const { return ___successCallback_2; }
	inline Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA ** get_address_of_successCallback_2() { return &___successCallback_2; }
	inline void set_successCallback_2(Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * value)
	{
		___successCallback_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___successCallback_2), (void*)value);
	}
};


// AppleAuth.AppleAuthManager/<>c__DisplayClass9_0
struct U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817  : public RuntimeObject
{
public:
	// AppleAuth.AppleAuthManager AppleAuth.AppleAuthManager/<>c__DisplayClass9_0::<>4__this
	AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * ___U3CU3E4__this_0;
	// System.Action`1<AppleAuth.Interfaces.IAppleError> AppleAuth.AppleAuthManager/<>c__DisplayClass9_0::errorCallback
	Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback_1;
	// System.Action`1<AppleAuth.Interfaces.ICredential> AppleAuth.AppleAuthManager/<>c__DisplayClass9_0::successCallback
	Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * ___successCallback_2;

public:
	inline static int32_t get_offset_of_U3CU3E4__this_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817, ___U3CU3E4__this_0)); }
	inline AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * get_U3CU3E4__this_0() const { return ___U3CU3E4__this_0; }
	inline AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 ** get_address_of_U3CU3E4__this_0() { return &___U3CU3E4__this_0; }
	inline void set_U3CU3E4__this_0(AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * value)
	{
		___U3CU3E4__this_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_0), (void*)value);
	}

	inline static int32_t get_offset_of_errorCallback_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817, ___errorCallback_1)); }
	inline Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * get_errorCallback_1() const { return ___errorCallback_1; }
	inline Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F ** get_address_of_errorCallback_1() { return &___errorCallback_1; }
	inline void set_errorCallback_1(Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * value)
	{
		___errorCallback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___errorCallback_1), (void*)value);
	}

	inline static int32_t get_offset_of_successCallback_2() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817, ___successCallback_2)); }
	inline Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * get_successCallback_2() const { return ___successCallback_2; }
	inline Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA ** get_address_of_successCallback_2() { return &___successCallback_2; }
	inline void set_successCallback_2(Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * value)
	{
		___successCallback_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___successCallback_2), (void*)value);
	}
};


// AppleAuth.AppleAuthManager/CallbackHandler
struct CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF  : public RuntimeObject
{
public:

public:
};

struct CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields
{
public:
	// System.Object AppleAuth.AppleAuthManager/CallbackHandler::SyncLock
	RuntimeObject * ___SyncLock_2;
	// System.Collections.Generic.Dictionary`2<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry> AppleAuth.AppleAuthManager/CallbackHandler::CallbackDictionary
	Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * ___CallbackDictionary_3;
	// System.Collections.Generic.List`1<System.Action> AppleAuth.AppleAuthManager/CallbackHandler::ScheduledActions
	List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * ___ScheduledActions_4;
	// System.UInt32 AppleAuth.AppleAuthManager/CallbackHandler::_callbackId
	uint32_t ____callbackId_5;
	// System.Boolean AppleAuth.AppleAuthManager/CallbackHandler::_initialized
	bool ____initialized_6;
	// System.UInt32 AppleAuth.AppleAuthManager/CallbackHandler::_credentialsRevokedCallbackId
	uint32_t ____credentialsRevokedCallbackId_7;
	// System.Action`1<System.String> AppleAuth.AppleAuthManager/CallbackHandler::_nativeCredentialsRevoked
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ____nativeCredentialsRevoked_8;

public:
	inline static int32_t get_offset_of_SyncLock_2() { return static_cast<int32_t>(offsetof(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields, ___SyncLock_2)); }
	inline RuntimeObject * get_SyncLock_2() const { return ___SyncLock_2; }
	inline RuntimeObject ** get_address_of_SyncLock_2() { return &___SyncLock_2; }
	inline void set_SyncLock_2(RuntimeObject * value)
	{
		___SyncLock_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___SyncLock_2), (void*)value);
	}

	inline static int32_t get_offset_of_CallbackDictionary_3() { return static_cast<int32_t>(offsetof(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields, ___CallbackDictionary_3)); }
	inline Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * get_CallbackDictionary_3() const { return ___CallbackDictionary_3; }
	inline Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE ** get_address_of_CallbackDictionary_3() { return &___CallbackDictionary_3; }
	inline void set_CallbackDictionary_3(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * value)
	{
		___CallbackDictionary_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___CallbackDictionary_3), (void*)value);
	}

	inline static int32_t get_offset_of_ScheduledActions_4() { return static_cast<int32_t>(offsetof(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields, ___ScheduledActions_4)); }
	inline List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * get_ScheduledActions_4() const { return ___ScheduledActions_4; }
	inline List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 ** get_address_of_ScheduledActions_4() { return &___ScheduledActions_4; }
	inline void set_ScheduledActions_4(List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * value)
	{
		___ScheduledActions_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ScheduledActions_4), (void*)value);
	}

	inline static int32_t get_offset_of__callbackId_5() { return static_cast<int32_t>(offsetof(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields, ____callbackId_5)); }
	inline uint32_t get__callbackId_5() const { return ____callbackId_5; }
	inline uint32_t* get_address_of__callbackId_5() { return &____callbackId_5; }
	inline void set__callbackId_5(uint32_t value)
	{
		____callbackId_5 = value;
	}

	inline static int32_t get_offset_of__initialized_6() { return static_cast<int32_t>(offsetof(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields, ____initialized_6)); }
	inline bool get__initialized_6() const { return ____initialized_6; }
	inline bool* get_address_of__initialized_6() { return &____initialized_6; }
	inline void set__initialized_6(bool value)
	{
		____initialized_6 = value;
	}

	inline static int32_t get_offset_of__credentialsRevokedCallbackId_7() { return static_cast<int32_t>(offsetof(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields, ____credentialsRevokedCallbackId_7)); }
	inline uint32_t get__credentialsRevokedCallbackId_7() const { return ____credentialsRevokedCallbackId_7; }
	inline uint32_t* get_address_of__credentialsRevokedCallbackId_7() { return &____credentialsRevokedCallbackId_7; }
	inline void set__credentialsRevokedCallbackId_7(uint32_t value)
	{
		____credentialsRevokedCallbackId_7 = value;
	}

	inline static int32_t get_offset_of__nativeCredentialsRevoked_8() { return static_cast<int32_t>(offsetof(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields, ____nativeCredentialsRevoked_8)); }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * get__nativeCredentialsRevoked_8() const { return ____nativeCredentialsRevoked_8; }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 ** get_address_of__nativeCredentialsRevoked_8() { return &____nativeCredentialsRevoked_8; }
	inline void set__nativeCredentialsRevoked_8(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * value)
	{
		____nativeCredentialsRevoked_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____nativeCredentialsRevoked_8), (void*)value);
	}
};


// AppleAuth.AppleAuthManager/PInvoke
struct PInvoke_tE2D06885D909FCDB9F6F16E0B81F0C38C44E6DF6  : public RuntimeObject
{
public:

public:
};


// AppleAuth.Extensions.PersonNameExtensions/PInvoke
struct PInvoke_tE48B3C85AD4F2B58F7F6B2446B1CBBFAD5F2BD7D  : public RuntimeObject
{
public:

public:
};


// AppleAuth.AppleAuthManager/CallbackHandler/<>c
struct U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465  : public RuntimeObject
{
public:

public:
};

struct U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_StaticFields
{
public:
	// AppleAuth.AppleAuthManager/CallbackHandler/<>c AppleAuth.AppleAuthManager/CallbackHandler/<>c::<>9
	U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 * ___U3CU3E9_0;
	// System.Action`1<System.String> AppleAuth.AppleAuthManager/CallbackHandler/<>c::<>9__12_0
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___U3CU3E9__12_0_1;

public:
	inline static int32_t get_offset_of_U3CU3E9_0() { return static_cast<int32_t>(offsetof(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_StaticFields, ___U3CU3E9_0)); }
	inline U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 * get_U3CU3E9_0() const { return ___U3CU3E9_0; }
	inline U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 ** get_address_of_U3CU3E9_0() { return &___U3CU3E9_0; }
	inline void set_U3CU3E9_0(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 * value)
	{
		___U3CU3E9_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9_0), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E9__12_0_1() { return static_cast<int32_t>(offsetof(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_StaticFields, ___U3CU3E9__12_0_1)); }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * get_U3CU3E9__12_0_1() const { return ___U3CU3E9__12_0_1; }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 ** get_address_of_U3CU3E9__12_0_1() { return &___U3CU3E9__12_0_1; }
	inline void set_U3CU3E9__12_0_1(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * value)
	{
		___U3CU3E9__12_0_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E9__12_0_1), (void*)value);
	}
};


// AppleAuth.AppleAuthManager/CallbackHandler/<>c__DisplayClass14_0
struct U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C  : public RuntimeObject
{
public:
	// System.String AppleAuth.AppleAuthManager/CallbackHandler/<>c__DisplayClass14_0::payload
	String_t* ___payload_0;
	// System.Action`1<System.String> AppleAuth.AppleAuthManager/CallbackHandler/<>c__DisplayClass14_0::callback
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___callback_1;

public:
	inline static int32_t get_offset_of_payload_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C, ___payload_0)); }
	inline String_t* get_payload_0() const { return ___payload_0; }
	inline String_t** get_address_of_payload_0() { return &___payload_0; }
	inline void set_payload_0(String_t* value)
	{
		___payload_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___payload_0), (void*)value);
	}

	inline static int32_t get_offset_of_callback_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C, ___callback_1)); }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * get_callback_1() const { return ___callback_1; }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 ** get_address_of_callback_1() { return &___callback_1; }
	inline void set_callback_1(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * value)
	{
		___callback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___callback_1), (void*)value);
	}
};


// AppleAuth.AppleAuthManager/CallbackHandler/Entry
struct Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417  : public RuntimeObject
{
public:
	// System.Boolean AppleAuth.AppleAuthManager/CallbackHandler/Entry::IsSingleUseCallback
	bool ___IsSingleUseCallback_0;
	// System.Action`1<System.String> AppleAuth.AppleAuthManager/CallbackHandler/Entry::MessageCallback
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___MessageCallback_1;

public:
	inline static int32_t get_offset_of_IsSingleUseCallback_0() { return static_cast<int32_t>(offsetof(Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417, ___IsSingleUseCallback_0)); }
	inline bool get_IsSingleUseCallback_0() const { return ___IsSingleUseCallback_0; }
	inline bool* get_address_of_IsSingleUseCallback_0() { return &___IsSingleUseCallback_0; }
	inline void set_IsSingleUseCallback_0(bool value)
	{
		___IsSingleUseCallback_0 = value;
	}

	inline static int32_t get_offset_of_MessageCallback_1() { return static_cast<int32_t>(offsetof(Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417, ___MessageCallback_1)); }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * get_MessageCallback_1() const { return ___MessageCallback_1; }
	inline Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 ** get_address_of_MessageCallback_1() { return &___MessageCallback_1; }
	inline void set_MessageCallback_1(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * value)
	{
		___MessageCallback_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___MessageCallback_1), (void*)value);
	}
};


// AppleAuth.AppleAuthQuickLoginArgs
struct AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE 
{
public:
	// System.String AppleAuth.AppleAuthQuickLoginArgs::Nonce
	String_t* ___Nonce_0;
	// System.String AppleAuth.AppleAuthQuickLoginArgs::State
	String_t* ___State_1;

public:
	inline static int32_t get_offset_of_Nonce_0() { return static_cast<int32_t>(offsetof(AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE, ___Nonce_0)); }
	inline String_t* get_Nonce_0() const { return ___Nonce_0; }
	inline String_t** get_address_of_Nonce_0() { return &___Nonce_0; }
	inline void set_Nonce_0(String_t* value)
	{
		___Nonce_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Nonce_0), (void*)value);
	}

	inline static int32_t get_offset_of_State_1() { return static_cast<int32_t>(offsetof(AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE, ___State_1)); }
	inline String_t* get_State_1() const { return ___State_1; }
	inline String_t** get_address_of_State_1() { return &___State_1; }
	inline void set_State_1(String_t* value)
	{
		___State_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___State_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of AppleAuth.AppleAuthQuickLoginArgs
struct AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshaled_pinvoke
{
	char* ___Nonce_0;
	char* ___State_1;
};
// Native definition for COM marshalling of AppleAuth.AppleAuthQuickLoginArgs
struct AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshaled_com
{
	Il2CppChar* ___Nonce_0;
	Il2CppChar* ___State_1;
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

// AppleAuth.Native.FullPersonName
struct FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F  : public PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575
{
public:
	// System.Boolean AppleAuth.Native.FullPersonName::_hasPhoneticRepresentation
	bool ____hasPhoneticRepresentation_6;
	// AppleAuth.Native.PersonName AppleAuth.Native.FullPersonName::_phoneticRepresentation
	PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * ____phoneticRepresentation_7;

public:
	inline static int32_t get_offset_of__hasPhoneticRepresentation_6() { return static_cast<int32_t>(offsetof(FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F, ____hasPhoneticRepresentation_6)); }
	inline bool get__hasPhoneticRepresentation_6() const { return ____hasPhoneticRepresentation_6; }
	inline bool* get_address_of__hasPhoneticRepresentation_6() { return &____hasPhoneticRepresentation_6; }
	inline void set__hasPhoneticRepresentation_6(bool value)
	{
		____hasPhoneticRepresentation_6 = value;
	}

	inline static int32_t get_offset_of__phoneticRepresentation_7() { return static_cast<int32_t>(offsetof(FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F, ____phoneticRepresentation_7)); }
	inline PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * get__phoneticRepresentation_7() const { return ____phoneticRepresentation_7; }
	inline PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 ** get_address_of__phoneticRepresentation_7() { return &____phoneticRepresentation_7; }
	inline void set__phoneticRepresentation_7(PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * value)
	{
		____phoneticRepresentation_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____phoneticRepresentation_7), (void*)value);
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


// AppleAuth.Enums.AuthorizationErrorCode
struct AuthorizationErrorCode_t39345506E8A14B87DC20E75D12142CE1804DF557 
{
public:
	// System.Int32 AppleAuth.Enums.AuthorizationErrorCode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AuthorizationErrorCode_t39345506E8A14B87DC20E75D12142CE1804DF557, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
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


// AppleAuth.Enums.CredentialState
struct CredentialState_tB6FBBF4767DBDA30410372D655B7E7B53FDA1964 
{
public:
	// System.Int32 AppleAuth.Enums.CredentialState::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(CredentialState_tB6FBBF4767DBDA30410372D655B7E7B53FDA1964, ___value___2)); }
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


// AppleAuth.Enums.LoginOptions
struct LoginOptions_tA6B67F9BBFE55877449C94CF3938C3F10459BAB6 
{
public:
	// System.Int32 AppleAuth.Enums.LoginOptions::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(LoginOptions_tA6B67F9BBFE55877449C94CF3938C3F10459BAB6, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// AppleAuth.Enums.PersonNameFormatterStyle
struct PersonNameFormatterStyle_tA9AA1AE6E08F57BBCB1A73CC82E1344A10E5F4D7 
{
public:
	// System.Int32 AppleAuth.Enums.PersonNameFormatterStyle::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PersonNameFormatterStyle_tA9AA1AE6E08F57BBCB1A73CC82E1344A10E5F4D7, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// AppleAuth.Enums.RealUserStatus
struct RealUserStatus_tC6D79A69AA0DED40B231C7B6790B6E50F8BCCFDF 
{
public:
	// System.Int32 AppleAuth.Enums.RealUserStatus::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(RealUserStatus_tC6D79A69AA0DED40B231C7B6790B6E50F8BCCFDF, ___value___2)); }
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


// AppleAuth.AppleAuthLoginArgs
struct AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE 
{
public:
	// AppleAuth.Enums.LoginOptions AppleAuth.AppleAuthLoginArgs::Options
	int32_t ___Options_0;
	// System.String AppleAuth.AppleAuthLoginArgs::Nonce
	String_t* ___Nonce_1;
	// System.String AppleAuth.AppleAuthLoginArgs::State
	String_t* ___State_2;

public:
	inline static int32_t get_offset_of_Options_0() { return static_cast<int32_t>(offsetof(AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE, ___Options_0)); }
	inline int32_t get_Options_0() const { return ___Options_0; }
	inline int32_t* get_address_of_Options_0() { return &___Options_0; }
	inline void set_Options_0(int32_t value)
	{
		___Options_0 = value;
	}

	inline static int32_t get_offset_of_Nonce_1() { return static_cast<int32_t>(offsetof(AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE, ___Nonce_1)); }
	inline String_t* get_Nonce_1() const { return ___Nonce_1; }
	inline String_t** get_address_of_Nonce_1() { return &___Nonce_1; }
	inline void set_Nonce_1(String_t* value)
	{
		___Nonce_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Nonce_1), (void*)value);
	}

	inline static int32_t get_offset_of_State_2() { return static_cast<int32_t>(offsetof(AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE, ___State_2)); }
	inline String_t* get_State_2() const { return ___State_2; }
	inline String_t** get_address_of_State_2() { return &___State_2; }
	inline void set_State_2(String_t* value)
	{
		___State_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___State_2), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of AppleAuth.AppleAuthLoginArgs
struct AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshaled_pinvoke
{
	int32_t ___Options_0;
	char* ___Nonce_1;
	char* ___State_2;
};
// Native definition for COM marshalling of AppleAuth.AppleAuthLoginArgs
struct AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshaled_com
{
	int32_t ___Options_0;
	Il2CppChar* ___Nonce_1;
	Il2CppChar* ___State_2;
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


// System.Action`1<AppleAuth.Enums.CredentialState>
struct Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178  : public MulticastDelegate_t
{
public:

public:
};


// System.Action`1<AppleAuth.Interfaces.IAppleError>
struct Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F  : public MulticastDelegate_t
{
public:

public:
};


// System.Action`1<AppleAuth.Interfaces.ICredential>
struct Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA  : public MulticastDelegate_t
{
public:

public:
};


// System.Action`1<System.String>
struct Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3  : public MulticastDelegate_t
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


// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA  : public MulticastDelegate_t
{
public:

public:
};


// AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate
struct NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
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


// System.Void System.Action`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1__ctor_mA671E933C9D3DAE4E3F71D34FDDA971739618158_gshared (Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForArray<System.Object>(T[]&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SerializationTools_FixSerializationForArray_TisRuntimeObject_mCFAB8C0FE4427CA0C70BBC741DA5B5DED5575225_gshared (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** ___originalArray0, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForObject<System.Object>(T&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SerializationTools_FixSerializationForObject_TisRuntimeObject_m782800768451BBB7EF1FF2E3D32EB8F48DD9E7BE_gshared (RuntimeObject ** ___originalObject0, bool ___hasOriginalObject1, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForObject<System.Int32>(T&,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SerializationTools_FixSerializationForObject_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mC91420AF1574C1B1A3945354470789F8D482CAC5_gshared (int32_t* ___originalObject0, bool ___hasOriginalObject1, const RuntimeMethod* method);
// !!0 UnityEngine.JsonUtility::FromJson<System.Object>(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * JsonUtility_FromJson_TisRuntimeObject_m7398DCFD1F6BF2A10AB1274ABED512F322F8F4B4_gshared (String_t* ___json0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// !0[] System.Collections.Generic.List`1<System.Object>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* List_1_ToArray_mA737986DE6389E9DD8FA8E3D4E222DE4DA34958D_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Void System.Action`1<System.Object>::Invoke(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1_Invoke_m587509C88BB83721D7918D89DF07606BB752D744_gshared (Action_1_tD9663D9715FAA4E62035CFCF1AD4D094EE7872DC * __this, RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Void System.Action`1<System.Int32Enum>::Invoke(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_1_Invoke_m2652E72792A278523D6D8962CBBEA84177BB4556_gshared (Action_1_tF0FD284A49EB7135379250254D6B49FA84383C09 * __this, int32_t ___obj0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.UInt32,System.Object>::TryGetValue(!0,!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_mF5A0875939E9F81FC647F954014F68BC5678AAF8_gshared (Dictionary_2_t32479D928C553725424938B11A68D3CD8069EA75 * __this, uint32_t ___key0, RuntimeObject ** ___value1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.UInt32,System.Object>::Remove(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_Remove_m1B22227EF07C5B7D71412C84A6FC5BC6B227AA9C_gshared (Dictionary_2_t32479D928C553725424938B11A68D3CD8069EA75 * __this, uint32_t ___key0, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1<System.Object>::get_Item(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * List_1_get_Item_mF00B574E58FB078BB753B05A3B86DD0A7A266B63_gshared_inline (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::RemoveAt(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_RemoveAt_m66148860899ECCAE9B323372032BFC1C255393D2_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m5D847939ABB9A78203B062CAFFE975792174D00F_gshared_inline (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.UInt32,System.Object>::Add(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_Add_m505F2CF58731D70AAE480EFFE20B311E5BBBB761_gshared (Dictionary_2_t32479D928C553725424938B11A68D3CD8069EA75 * __this, uint32_t ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.UInt32,System.Object>::ContainsKey(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_ContainsKey_mF4CE0F5D4D835043FF57A231D7A6BF1C786FE1C9_gshared (Dictionary_2_t32479D928C553725424938B11A68D3CD8069EA75 * __this, uint32_t ___key0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.UInt32,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m5D54E695939D13E41566390833F4B0DB613D4E27_gshared (Dictionary_2_t32479D928C553725424938B11A68D3CD8069EA75 * __this, const RuntimeMethod* method);

// System.Void AppleAuth.AppleAuthLoginArgs::.ctor(AppleAuth.Enums.LoginOptions,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthLoginArgs__ctor_m39DCEE4E48A1245B936703CB9AF4B032C4D4E4C3 (AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE * __this, int32_t ___options0, String_t* ___nonce1, String_t* ___state2, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_LogMessage(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_LogMessage_mAFE1CA4F989C68BDE97E602ACE4D1A7FC70243D9 (String_t* ___messageCStr0, const RuntimeMethod* method);
// System.Boolean AppleAuth.AppleAuthManager/PInvoke::AppleAuth_IsCurrentPlatformSupported()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PInvoke_AppleAuth_IsCurrentPlatformSupported_m186998F906FC4A08604FA9D6B8B466C9AF823CC8 (const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager::QuickLogin(AppleAuth.AppleAuthQuickLoginArgs,System.Action`1<AppleAuth.Interfaces.ICredential>,System.Action`1<AppleAuth.Interfaces.IAppleError>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_QuickLogin_mA0443BF145CB62FB998A8828916F03EDE7B7BC35 (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE  ___quickLoginArgs0, Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * ___successCallback1, Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback2, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass7_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0__ctor_m81604CDFA2714F09B02C08FD6AD332AA22203154 (U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * __this, const RuntimeMethod* method);
// System.Void System.Action`1<System.String>::.ctor(System.Object,System.IntPtr)
inline void Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161 (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *, RuntimeObject *, intptr_t, const RuntimeMethod*))Action_1__ctor_mA671E933C9D3DAE4E3F71D34FDDA971739618158_gshared)(__this, ___object0, ___method1, method);
}
// System.UInt32 AppleAuth.AppleAuthManager/CallbackHandler::AddMessageCallback(System.Boolean,System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t CallbackHandler_AddMessageCallback_m7B194DE6CC041640E88BDB3111D732D7BE355E92 (bool ___isSingleUse0, Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___messageCallback1, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_QuickLogin(System.UInt32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_QuickLogin_m2E1CE51129E8B07C976CC003233013D67AA9B985 (uint32_t ___requestId0, String_t* ___nonceCStr1, String_t* ___stateCStr2, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager::LoginWithAppleId(AppleAuth.AppleAuthLoginArgs,System.Action`1<AppleAuth.Interfaces.ICredential>,System.Action`1<AppleAuth.Interfaces.IAppleError>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_LoginWithAppleId_m43E256001A4940AEECC68F522CBE417BD17103D2 (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE  ___loginArgs0, Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * ___successCallback1, Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback2, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass9_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass9_0__ctor_m04AF0C6AC86E75FB90C3AF0775EF4661DDCC8AAC (U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * __this, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_LoginWithAppleId(System.UInt32,System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_LoginWithAppleId_m9A61219460D34AE8A008FAA16C756A30029EC7B8 (uint32_t ___requestId0, int32_t ___loginOptions1, String_t* ___nonceCStr2, String_t* ___stateCStr3, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass10_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass10_0__ctor_m9AF46F3648D1F310EAA6633345AE5B109BEE9D3B (U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * __this, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_GetCredentialState(System.UInt32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_GetCredentialState_mE2F5EDC4A49B99D61296CCC4A3C284667E7EC40D (uint32_t ___requestId0, String_t* ___userId1, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::remove_NativeCredentialsRevoked(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_remove_NativeCredentialsRevoked_mAB87C721DDE673ADD5DF4F1FB03005DB78060A14 (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___value0, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::add_NativeCredentialsRevoked(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_add_NativeCredentialsRevoked_m9A6E540FAEA285B407694C30EF23F8A949837F09 (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___value0, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::ExecutePendingCallbacks()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_ExecutePendingCallbacks_m8FDE99CABAE4E3E08A7D8590D863CB550A3AC24B (const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthQuickLoginArgs::.ctor(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthQuickLoginArgs__ctor_m043BC449E06C61C6EAD18D0380BA196AB99A9F93 (AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE * __this, String_t* ___nonce0, String_t* ___state1, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForString(System.String&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2 (String_t** ___originalString0, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForArray<System.String>(T[]&)
inline void SerializationTools_FixSerializationForArray_TisString_t_m4508C4D7A8194BD8A3F86525D870B214646B89D8 (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** ___originalArray0, const RuntimeMethod* method)
{
	((  void (*) (StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A**, const RuntimeMethod*))SerializationTools_FixSerializationForArray_TisRuntimeObject_mCFAB8C0FE4427CA0C70BBC741DA5B5DED5575225_gshared)(___originalArray0, method);
}
// System.String System.String::Format(System.String,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_m039737CCD992C5BFC8D16DFD681F5E8786E87FA6 (String_t* ___format0, RuntimeObject * ___arg01, RuntimeObject * ___arg12, RuntimeObject * ___arg23, const RuntimeMethod* method);
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method);
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E (RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ___handle0, const RuntimeMethod* method);
// System.Boolean System.Enum::IsDefined(System.Type,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enum_IsDefined_m70E955627155998B426145940DE105ECEF213B96 (Type_t * ___enumType0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForObject<AppleAuth.Native.FullPersonName>(T&,System.Boolean)
inline void SerializationTools_FixSerializationForObject_TisFullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F_m2C9FB5DFB296EC5FD48BDE7B7B83550625AA55FE (FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F ** ___originalObject0, bool ___hasOriginalObject1, const RuntimeMethod* method)
{
	((  void (*) (FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F **, bool, const RuntimeMethod*))SerializationTools_FixSerializationForObject_TisRuntimeObject_m782800768451BBB7EF1FF2E3D32EB8F48DD9E7BE_gshared)(___originalObject0, ___hasOriginalObject1, method);
}
// System.Byte[] AppleAuth.Native.SerializationTools::GetBytesFromBase64String(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* SerializationTools_GetBytesFromBase64String_mC62CDA9500A1DB0D8401FB2F655D006BACE3CD2F (String_t* ___base64String0, String_t* ___fieldName1, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForObject<System.Int32>(T&,System.Boolean)
inline void SerializationTools_FixSerializationForObject_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mC91420AF1574C1B1A3945354470789F8D482CAC5 (int32_t* ___originalObject0, bool ___hasOriginalObject1, const RuntimeMethod* method)
{
	((  void (*) (int32_t*, bool, const RuntimeMethod*))SerializationTools_FixSerializationForObject_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mC91420AF1574C1B1A3945354470789F8D482CAC5_gshared)(___originalObject0, ___hasOriginalObject1, method);
}
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForObject<AppleAuth.Native.AppleError>(T&,System.Boolean)
inline void SerializationTools_FixSerializationForObject_TisAppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5_mF02F1B47277A639EDF4EDBE0123B1FC5E289E017 (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 ** ___originalObject0, bool ___hasOriginalObject1, const RuntimeMethod* method)
{
	((  void (*) (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 **, bool, const RuntimeMethod*))SerializationTools_FixSerializationForObject_TisRuntimeObject_m782800768451BBB7EF1FF2E3D32EB8F48DD9E7BE_gshared)(___originalObject0, ___hasOriginalObject1, method);
}
// System.Void AppleAuth.Native.PersonName::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PersonName_OnAfterDeserialize_mCB951E18D2ACAD268936336AD70B20C4149F00B5 (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForObject<AppleAuth.Native.PersonName>(T&,System.Boolean)
inline void SerializationTools_FixSerializationForObject_TisPersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575_m617A30C4801302EBEA5A9372B5F749559919980B (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 ** ___originalObject0, bool ___hasOriginalObject1, const RuntimeMethod* method)
{
	((  void (*) (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 **, bool, const RuntimeMethod*))SerializationTools_FixSerializationForObject_TisRuntimeObject_m782800768451BBB7EF1FF2E3D32EB8F48DD9E7BE_gshared)(___originalObject0, ___hasOriginalObject1, method);
}
// System.Void AppleAuth.Native.PersonName::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PersonName__ctor_mD480CDC2BE2345F367BE8C893C3210BEF68F9399 (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method);
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForObject<AppleAuth.Native.AppleIDCredential>(T&,System.Boolean)
inline void SerializationTools_FixSerializationForObject_TisAppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612_m56697900B3FA29ADB060E74DB02057455D909D96 (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 ** ___originalObject0, bool ___hasOriginalObject1, const RuntimeMethod* method)
{
	((  void (*) (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 **, bool, const RuntimeMethod*))SerializationTools_FixSerializationForObject_TisRuntimeObject_m782800768451BBB7EF1FF2E3D32EB8F48DD9E7BE_gshared)(___originalObject0, ___hasOriginalObject1, method);
}
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForObject<AppleAuth.Native.PasswordCredential>(T&,System.Boolean)
inline void SerializationTools_FixSerializationForObject_TisPasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372_mD95DFFCC92BBB817B7B3842C2A4CFA956459D63C (PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 ** ___originalObject0, bool ___hasOriginalObject1, const RuntimeMethod* method)
{
	((  void (*) (PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 **, bool, const RuntimeMethod*))SerializationTools_FixSerializationForObject_TisRuntimeObject_m782800768451BBB7EF1FF2E3D32EB8F48DD9E7BE_gshared)(___originalObject0, ___hasOriginalObject1, method);
}
// !!0 UnityEngine.JsonUtility::FromJson<AppleAuth.Native.CredentialStateResponse>(System.String)
inline CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * JsonUtility_FromJson_TisCredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433_mF602D4AE88853D8A2A9C9D40421058B6834CFFDC (String_t* ___json0, const RuntimeMethod* method)
{
	return ((  CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * (*) (String_t*, const RuntimeMethod*))JsonUtility_FromJson_TisRuntimeObject_m7398DCFD1F6BF2A10AB1274ABED512F322F8F4B4_gshared)(___json0, method);
}
// !!0 UnityEngine.JsonUtility::FromJson<AppleAuth.Native.LoginWithAppleIdResponse>(System.String)
inline LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * JsonUtility_FromJson_TisLoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E_m5FE146A960E6F18BFFB51D58B287890DD5E53A21 (String_t* ___json0, const RuntimeMethod* method)
{
	return ((  LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * (*) (String_t*, const RuntimeMethod*))JsonUtility_FromJson_TisRuntimeObject_m7398DCFD1F6BF2A10AB1274ABED512F322F8F4B4_gshared)(___json0, method);
}
// System.String AppleAuth.Extensions.PersonNameExtensions::JsonStringForPersonName(AppleAuth.Interfaces.IPersonName)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonNameExtensions_JsonStringForPersonName_m009CD92B73A00F4AD0CB6B74000039C2D1F49290 (RuntimeObject* ___personName0, const RuntimeMethod* method);
// System.String AppleAuth.Extensions.PersonNameExtensions/PInvoke::AppleAuth_GetPersonNameUsingFormatter(System.String,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PInvoke_AppleAuth_GetPersonNameUsingFormatter_m3EB54DC8762902550797A25C7BB4E61FD63731E0 (String_t* ___payload0, int32_t ___style1, bool ___usePhoneticRepresentation2, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.String>::.ctor()
inline void List_1__ctor_m30C52A4F2828D86CA3FAB0B1B583948F4DA9F1F9 (List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C (String_t* ___value0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.String>::Add(!0)
inline void List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE (List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * __this, String_t* ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 *, String_t*, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// !0[] System.Collections.Generic.List`1<System.String>::ToArray()
inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* List_1_ToArray_m94163AE84EBF9A1F7483014A8E9906BD93D9EBDB (List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * __this, const RuntimeMethod* method)
{
	return ((  StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* (*) (List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 *, const RuntimeMethod*))List_1_ToArray_mA737986DE6389E9DD8FA8E3D4E222DE4DA34958D_gshared)(__this, method);
}
// System.String System.String::Join(System.String,System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Join_m8846EB11F0A221BDE237DE041D17764B36065404 (String_t* ___separator0, StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___value1, const RuntimeMethod* method);
// System.Void System.Text.StringBuilder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9 (StringBuilder_t * __this, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1 (StringBuilder_t * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void AppleAuth.Extensions.PersonNameExtensions::TryAddKeyValue(System.String,System.String,System.String,System.Text.StringBuilder)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625 (String_t* ___format0, String_t* ___key1, String_t* ___value2, StringBuilder_t * ___stringBuilder3, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::AppendFormat(System.String,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_AppendFormat_m37B348187DD9186C2451ACCA3DBC4ABCD4632AD4 (StringBuilder_t * __this, String_t* ___format0, RuntimeObject * ___arg01, RuntimeObject * ___arg12, const RuntimeMethod* method);
// System.Byte[] System.Convert::FromBase64String(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* Convert_FromBase64String_mB2E4E2CD03B34DB7C2665694D5B2E967BC81E9A8 (String_t* ___s0, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// System.Void System.Console::WriteLine(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Console_WriteLine_mE9EEA95C541D41E36A0F4844153A67EAAA0D12F7 (String_t* ___value0, const RuntimeMethod* method);
// System.Void System.Action`1<AppleAuth.Interfaces.IAppleError>::Invoke(!0)
inline void Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7 (Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * __this, RuntimeObject* ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F *, RuntimeObject*, const RuntimeMethod*))Action_1_Invoke_m587509C88BB83721D7918D89DF07606BB752D744_gshared)(__this, ___obj0, method);
}
// System.Void System.Action`1<AppleAuth.Enums.CredentialState>::Invoke(!0)
inline void Action_1_Invoke_m962693B0F6FA0C65C36BFDC35E053E1125FA149A (Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 * __this, int32_t ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 *, int32_t, const RuntimeMethod*))Action_1_Invoke_m2652E72792A278523D6D8962CBBEA84177BB4556_gshared)(__this, ___obj0, method);
}
// System.Void System.Action`1<AppleAuth.Interfaces.ICredential>::Invoke(!0)
inline void Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357 (Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * __this, RuntimeObject* ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA *, RuntimeObject*, const RuntimeMethod*))Action_1_Invoke_m587509C88BB83721D7918D89DF07606BB752D744_gshared)(__this, ___obj0, method);
}
// System.Delegate System.Delegate::Combine(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t * Delegate_Combine_m631D10D6CFF81AB4F237B9D549B235A54F45FA55 (Delegate_t * ___a0, Delegate_t * ___b1, const RuntimeMethod* method);
// System.Delegate System.Delegate::Remove(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t * Delegate_Remove_m8B4AD17254118B2904720D55C9B34FB3DCCBD7D4 (Delegate_t * ___source0, Delegate_t * ___value1, const RuntimeMethod* method);
// System.Void System.Threading.Monitor::Enter(System.Object,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4 (RuntimeObject * ___obj0, bool* ___lockTaken1, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_RegisterCredentialsRevokedCallbackId(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_RegisterCredentialsRevokedCallbackId_m7832911757EA10685C78C60F28ECB9783A53D787 (uint32_t ___callbackId0, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::add__nativeCredentialsRevoked(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_add__nativeCredentialsRevoked_m5914C8893508EE656C3324572E537E962E76F91E (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___value0, const RuntimeMethod* method);
// System.Void System.Threading.Monitor::Exit(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A (RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::remove__nativeCredentialsRevoked(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_remove__nativeCredentialsRevoked_mBD5A18068932A435B639C8335FF850802373F27C (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___value0, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::RemoveMessageCallback(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_RemoveMessageCallback_m21605F49CE514727FB7861F0ED428D341E2FD4D2 (uint32_t ___requestId0, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/<>c__DisplayClass14_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass14_0__ctor_m34864F02146811916F09E681C2C43F35191EA19A (U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>::TryGetValue(!0,!1&)
inline bool Dictionary_2_TryGetValue_m821D7367424A9A61214C4CA1B2B608708636F93E (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * __this, uint32_t ___key0, Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 ** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE *, uint32_t, Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 **, const RuntimeMethod*))Dictionary_2_TryGetValue_mF5A0875939E9F81FC647F954014F68BC5678AAF8_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Action::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action__ctor_m07BE5EE8A629FBBA52AE6356D57A0D371BE2574B (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Action>::Add(!0)
inline void List_1_Add_m7701B455B6EA0411642596847118B51F91DA8BC9 (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * __this, Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 *, Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 *, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>::Remove(!0)
inline bool Dictionary_2_Remove_m31296A3D9862AFFD78839933103BFA7B99CCCBE7 (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * __this, uint32_t ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE *, uint32_t, const RuntimeMethod*))Dictionary_2_Remove_m1B22227EF07C5B7D71412C84A6FC5BC6B227AA9C_gshared)(__this, ___key0, method);
}
// !0 System.Collections.Generic.List`1<System.Action>::get_Item(System.Int32)
inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * List_1_get_Item_m9F0A626A47DAE7452E139A6961335BE81507E551_inline (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * (*) (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 *, int32_t, const RuntimeMethod*))List_1_get_Item_mF00B574E58FB078BB753B05A3B86DD0A7A266B63_gshared_inline)(__this, ___index0, method);
}
// System.Void System.Collections.Generic.List`1<System.Action>::RemoveAt(System.Int32)
inline void List_1_RemoveAt_mD4CD85C9E5FDA40D3274952962B580A0BA3349FD (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 *, int32_t, const RuntimeMethod*))List_1_RemoveAt_m66148860899ECCAE9B323372032BFC1C255393D2_gshared)(__this, ___index0, method);
}
// System.Void System.Action::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_Invoke_m3FFA5BE3D64F0FF8E1E1CB6F953913FADB5EB89E (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * __this, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<System.Action>::get_Count()
inline int32_t List_1_get_Count_m62C12145DD437794F8660D2396A00A7B2BA480C5_inline (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 *, const RuntimeMethod*))List_1_get_Count_m5D847939ABB9A78203B062CAFFE975792174D00F_gshared_inline)(__this, method);
}
// System.Void AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativeMessageHandlerCallbackDelegate__ctor_m7ECBD3BE4EF8F1109AED37D1FCB02BF6648DFC5E (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_SetupNativeMessageHandlerCallback(AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_SetupNativeMessageHandlerCallback_m159E00729893F68C30D03CD151E4737C67B0E8BA (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * ___callback0, const RuntimeMethod* method);
// System.Void System.Exception::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11 (Exception_t * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/Entry::.ctor(System.Boolean,System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entry__ctor_m10C87A89CC51BC3AAB8683768ACF168B78FBCA64 (Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * __this, bool ___isSingleUseCallback0, Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___messageCallback1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>::Add(!0,!1)
inline void Dictionary_2_Add_mEF7ADA2611CF6AE754C1D3B6109D3C4A81D20A95 (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * __this, uint32_t ___key0, Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE *, uint32_t, Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 *, const RuntimeMethod*))Dictionary_2_Add_m505F2CF58731D70AAE480EFFE20B311E5BBBB761_gshared)(__this, ___key0, ___value1, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>::ContainsKey(!0)
inline bool Dictionary_2_ContainsKey_m782EBE8C977F074B6717FB7C1A23B70904B6AF69 (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * __this, uint32_t ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE *, uint32_t, const RuntimeMethod*))Dictionary_2_ContainsKey_mF4CE0F5D4D835043FF57A231D7A6BF1C786FE1C9_gshared)(__this, ___key0, method);
}
// System.String System.UInt32::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UInt32_ToString_mEB55F257429D34ED2BF41AE9567096F1F969B9A0 (uint32_t* __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.UInt32,AppleAuth.AppleAuthManager/CallbackHandler/Entry>::.ctor()
inline void Dictionary_2__ctor_m1F3234CA822823DFC744DCE9DF739A4EDD0C8882 (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE *, const RuntimeMethod*))Dictionary_2__ctor_m5D54E695939D13E41566390833F4B0DB613D4E27_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Action>::.ctor()
inline void List_1__ctor_m8F3A8E6C64C39DA66FF5F99E7A6BB97B41A482BB (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// System.Void AppleAuth.AppleAuthManager/PInvoke::NativeMessageHandlerCallback(System.UInt32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_NativeMessageHandlerCallback_mBA8562A025E9B934C3F7F672E02E08EF2033E8B3 (uint32_t ___requestId0, String_t* ___payload1, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::ScheduleCallback(System.UInt32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_ScheduleCallback_mCE6ED1A1BCEAD5F333C202E0B91E72407654E8F6 (uint32_t ___requestId0, String_t* ___payload1, const RuntimeMethod* method);
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m06B3B2000266EAE802DFB6601F159E2071659616 (U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 * __this, const RuntimeMethod* method);
// System.Void System.Action`1<System.String>::Invoke(!0)
inline void Action_1_Invoke_m6E81F94353B45920E7018D209DCF4B63DBE8D8B6 (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * __this, String_t* ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *, String_t*, const RuntimeMethod*))Action_1_Invoke_m587509C88BB83721D7918D89DF07606BB752D744_gshared)(__this, ___obj0, method);
}
// System.Void System.ThrowHelper::ThrowArgumentOutOfRangeException()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThrowHelper_ThrowArgumentOutOfRangeException_m4841366ABC2B2AFA37C10900551D7E07522C0929 (const RuntimeMethod* method);
IL2CPP_EXTERN_C int32_t DEFAULT_CALL AppleAuth_IsCurrentPlatformSupported();
IL2CPP_EXTERN_C void DEFAULT_CALL AppleAuth_SetupNativeMessageHandlerCallback(Il2CppMethodPointer);
IL2CPP_EXTERN_C void DEFAULT_CALL AppleAuth_GetCredentialState(uint32_t, char*);
IL2CPP_EXTERN_C void DEFAULT_CALL AppleAuth_LoginWithAppleId(uint32_t, int32_t, char*, char*);
IL2CPP_EXTERN_C void DEFAULT_CALL AppleAuth_QuickLogin(uint32_t, char*, char*);
IL2CPP_EXTERN_C void DEFAULT_CALL AppleAuth_RegisterCredentialsRevokedCallbackId(uint32_t);
IL2CPP_EXTERN_C void DEFAULT_CALL AppleAuth_LogMessage(char*);
IL2CPP_EXTERN_C char* DEFAULT_CALL AppleAuth_GetPersonNameUsingFormatter(char*, int32_t, int32_t);
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
// Conversion methods for marshalling of: AppleAuth.AppleAuthLoginArgs
IL2CPP_EXTERN_C void AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshal_pinvoke(const AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE& unmarshaled, AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshaled_pinvoke& marshaled)
{
	marshaled.___Options_0 = unmarshaled.get_Options_0();
	marshaled.___Nonce_1 = il2cpp_codegen_marshal_string(unmarshaled.get_Nonce_1());
	marshaled.___State_2 = il2cpp_codegen_marshal_string(unmarshaled.get_State_2());
}
IL2CPP_EXTERN_C void AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshal_pinvoke_back(const AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshaled_pinvoke& marshaled, AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE& unmarshaled)
{
	int32_t unmarshaled_Options_temp_0 = 0;
	unmarshaled_Options_temp_0 = marshaled.___Options_0;
	unmarshaled.set_Options_0(unmarshaled_Options_temp_0);
	unmarshaled.set_Nonce_1(il2cpp_codegen_marshal_string_result(marshaled.___Nonce_1));
	unmarshaled.set_State_2(il2cpp_codegen_marshal_string_result(marshaled.___State_2));
}
// Conversion method for clean up from marshalling of: AppleAuth.AppleAuthLoginArgs
IL2CPP_EXTERN_C void AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshal_pinvoke_cleanup(AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___Nonce_1);
	marshaled.___Nonce_1 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___State_2);
	marshaled.___State_2 = NULL;
}
// Conversion methods for marshalling of: AppleAuth.AppleAuthLoginArgs
IL2CPP_EXTERN_C void AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshal_com(const AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE& unmarshaled, AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshaled_com& marshaled)
{
	marshaled.___Options_0 = unmarshaled.get_Options_0();
	marshaled.___Nonce_1 = il2cpp_codegen_marshal_bstring(unmarshaled.get_Nonce_1());
	marshaled.___State_2 = il2cpp_codegen_marshal_bstring(unmarshaled.get_State_2());
}
IL2CPP_EXTERN_C void AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshal_com_back(const AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshaled_com& marshaled, AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE& unmarshaled)
{
	int32_t unmarshaled_Options_temp_0 = 0;
	unmarshaled_Options_temp_0 = marshaled.___Options_0;
	unmarshaled.set_Options_0(unmarshaled_Options_temp_0);
	unmarshaled.set_Nonce_1(il2cpp_codegen_marshal_bstring_result(marshaled.___Nonce_1));
	unmarshaled.set_State_2(il2cpp_codegen_marshal_bstring_result(marshaled.___State_2));
}
// Conversion method for clean up from marshalling of: AppleAuth.AppleAuthLoginArgs
IL2CPP_EXTERN_C void AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshal_com_cleanup(AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___Nonce_1);
	marshaled.___Nonce_1 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___State_2);
	marshaled.___State_2 = NULL;
}
// System.Void AppleAuth.AppleAuthLoginArgs::.ctor(AppleAuth.Enums.LoginOptions,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthLoginArgs__ctor_m39DCEE4E48A1245B936703CB9AF4B032C4D4E4C3 (AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE * __this, int32_t ___options0, String_t* ___nonce1, String_t* ___state2, const RuntimeMethod* method)
{
	{
		// this.Options = options;
		int32_t L_0 = ___options0;
		__this->set_Options_0(L_0);
		// this.Nonce = nonce;
		String_t* L_1 = ___nonce1;
		__this->set_Nonce_1(L_1);
		// this.State = state;
		String_t* L_2 = ___state2;
		__this->set_State_2(L_2);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void AppleAuthLoginArgs__ctor_m39DCEE4E48A1245B936703CB9AF4B032C4D4E4C3_AdjustorThunk (RuntimeObject * __this, int32_t ___options0, String_t* ___nonce1, String_t* ___state2, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE * _thisAdjusted = reinterpret_cast<AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE *>(__this + _offset);
	AppleAuthLoginArgs__ctor_m39DCEE4E48A1245B936703CB9AF4B032C4D4E4C3(_thisAdjusted, ___options0, ___nonce1, ___state2, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AppleAuth.AppleAuthManager::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager__cctor_mC9428D6AD1B4A1C95A47940E5799D4CD98FDDFE6 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralAAFEF493C52F96B5A12AC31A8C67F85BBF99BC17);
		s_Il2CppMethodInitialized = true;
	}
	{
		// PInvoke.AppleAuth_LogMessage(versionMessage);
		PInvoke_AppleAuth_LogMessage_mAFE1CA4F989C68BDE97E602ACE4D1A7FC70243D9(_stringLiteralAAFEF493C52F96B5A12AC31A8C67F85BBF99BC17, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Boolean AppleAuth.AppleAuthManager::get_IsCurrentPlatformSupported()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AppleAuthManager_get_IsCurrentPlatformSupported_m01CEEEA3918FF1E3DFD7DC78E385BE2C8CB8807E (const RuntimeMethod* method)
{
	{
		// return PInvoke.AppleAuth_IsCurrentPlatformSupported();
		bool L_0;
		L_0 = PInvoke_AppleAuth_IsCurrentPlatformSupported_m186998F906FC4A08604FA9D6B8B466C9AF823CC8(/*hidden argument*/NULL);
		return L_0;
	}
}
// System.Void AppleAuth.AppleAuthManager::.ctor(AppleAuth.Interfaces.IPayloadDeserializer)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager__ctor_m71500AFEB804B05281F27D5A34885E55FB7ED81F (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, RuntimeObject* ___payloadDeserializer0, const RuntimeMethod* method)
{
	{
		// public AppleAuthManager(IPayloadDeserializer payloadDeserializer)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this._payloadDeserializer = payloadDeserializer;
		RuntimeObject* L_0 = ___payloadDeserializer0;
		__this->set__payloadDeserializer_0(L_0);
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager::QuickLogin(System.Action`1<AppleAuth.Interfaces.ICredential>,System.Action`1<AppleAuth.Interfaces.IAppleError>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_QuickLogin_m8FD22B7EA7E7AA93041B9ADF123C699157EC951C (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * ___successCallback0, Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback1, const RuntimeMethod* method)
{
	AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// this.QuickLogin(new AppleAuthQuickLoginArgs(), successCallback, errorCallback);
		il2cpp_codegen_initobj((&V_0), sizeof(AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE ));
		AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE  L_0 = V_0;
		Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * L_1 = ___successCallback0;
		Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * L_2 = ___errorCallback1;
		AppleAuthManager_QuickLogin_mA0443BF145CB62FB998A8828916F03EDE7B7BC35(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager::QuickLogin(AppleAuth.AppleAuthQuickLoginArgs,System.Action`1<AppleAuth.Interfaces.ICredential>,System.Action`1<AppleAuth.Interfaces.IAppleError>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_QuickLogin_mA0443BF145CB62FB998A8828916F03EDE7B7BC35 (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE  ___quickLoginArgs0, Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * ___successCallback1, Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass7_0_U3CQuickLoginU3Eb__0_m0163857449472462097FE98E94EE2C764791D43B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* V_2 = NULL;
	{
		U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * L_0 = (U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass7_0__ctor_m81604CDFA2714F09B02C08FD6AD332AA22203154(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * L_1 = V_0;
		NullCheck(L_1);
		L_1->set_U3CU3E4__this_0(__this);
		U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * L_2 = V_0;
		Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * L_3 = ___errorCallback2;
		NullCheck(L_2);
		L_2->set_errorCallback_1(L_3);
		U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * L_4 = V_0;
		Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * L_5 = ___successCallback1;
		NullCheck(L_4);
		L_4->set_successCallback_2(L_5);
		// var nonce = quickLoginArgs.Nonce;
		AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE  L_6 = ___quickLoginArgs0;
		String_t* L_7 = L_6.get_Nonce_0();
		V_1 = L_7;
		// var state = quickLoginArgs.State;
		AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE  L_8 = ___quickLoginArgs0;
		String_t* L_9 = L_8.get_State_1();
		V_2 = L_9;
		// var requestId = CallbackHandler.AddMessageCallback(
		//     true,
		//     payload =>
		//     {
		//         var response = this._payloadDeserializer.DeserializeLoginWithAppleIdResponse(payload);
		//         if (response.Error != null)
		//             errorCallback(response.Error);
		//         else if (response.PasswordCredential != null)
		//             successCallback(response.PasswordCredential);
		//         else
		//             successCallback(response.AppleIDCredential);
		//     });
		U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * L_10 = V_0;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_11 = (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)il2cpp_codegen_object_new(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161(L_11, L_10, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass7_0_U3CQuickLoginU3Eb__0_m0163857449472462097FE98E94EE2C764791D43B_RuntimeMethod_var), /*hidden argument*/Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var);
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		uint32_t L_12;
		L_12 = CallbackHandler_AddMessageCallback_m7B194DE6CC041640E88BDB3111D732D7BE355E92((bool)1, L_11, /*hidden argument*/NULL);
		// PInvoke.AppleAuth_QuickLogin(requestId, nonce, state);
		String_t* L_13 = V_1;
		String_t* L_14 = V_2;
		PInvoke_AppleAuth_QuickLogin_m2E1CE51129E8B07C976CC003233013D67AA9B985(L_12, L_13, L_14, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager::LoginWithAppleId(AppleAuth.Enums.LoginOptions,System.Action`1<AppleAuth.Interfaces.ICredential>,System.Action`1<AppleAuth.Interfaces.IAppleError>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_LoginWithAppleId_m4B51F71A4D8EEFA2A6052332E4CA76E4BD4274F1 (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, int32_t ___options0, Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * ___successCallback1, Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback2, const RuntimeMethod* method)
{
	{
		// this.LoginWithAppleId(new AppleAuthLoginArgs(options), successCallback, errorCallback);
		int32_t L_0 = ___options0;
		AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AppleAuthLoginArgs__ctor_m39DCEE4E48A1245B936703CB9AF4B032C4D4E4C3((&L_1), L_0, (String_t*)NULL, (String_t*)NULL, /*hidden argument*/NULL);
		Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * L_2 = ___successCallback1;
		Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * L_3 = ___errorCallback2;
		AppleAuthManager_LoginWithAppleId_m43E256001A4940AEECC68F522CBE417BD17103D2(__this, L_1, L_2, L_3, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager::LoginWithAppleId(AppleAuth.AppleAuthLoginArgs,System.Action`1<AppleAuth.Interfaces.ICredential>,System.Action`1<AppleAuth.Interfaces.IAppleError>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_LoginWithAppleId_m43E256001A4940AEECC68F522CBE417BD17103D2 (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE  ___loginArgs0, Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * ___successCallback1, Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass9_0_U3CLoginWithAppleIdU3Eb__0_mA62EB5BB7611FA73AFDB2697C47D792A7122E3EF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * V_0 = NULL;
	int32_t V_1 = 0;
	String_t* V_2 = NULL;
	String_t* V_3 = NULL;
	{
		U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * L_0 = (U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass9_0__ctor_m04AF0C6AC86E75FB90C3AF0775EF4661DDCC8AAC(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * L_1 = V_0;
		NullCheck(L_1);
		L_1->set_U3CU3E4__this_0(__this);
		U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * L_2 = V_0;
		Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * L_3 = ___errorCallback2;
		NullCheck(L_2);
		L_2->set_errorCallback_1(L_3);
		U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * L_4 = V_0;
		Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * L_5 = ___successCallback1;
		NullCheck(L_4);
		L_4->set_successCallback_2(L_5);
		// var loginOptions = loginArgs.Options;
		AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE  L_6 = ___loginArgs0;
		int32_t L_7 = L_6.get_Options_0();
		V_1 = L_7;
		// var nonce = loginArgs.Nonce;
		AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE  L_8 = ___loginArgs0;
		String_t* L_9 = L_8.get_Nonce_1();
		V_2 = L_9;
		// var state = loginArgs.State;
		AppleAuthLoginArgs_tFD2D54DC8A95B45AC97FC9C21BB0A0C1BB32A2DE  L_10 = ___loginArgs0;
		String_t* L_11 = L_10.get_State_2();
		V_3 = L_11;
		// var requestId = CallbackHandler.AddMessageCallback(
		//     true,
		//     payload =>
		//     {
		//         var response = this._payloadDeserializer.DeserializeLoginWithAppleIdResponse(payload);
		//         if (response.Error != null)
		//             errorCallback(response.Error);
		//         else
		//             successCallback(response.AppleIDCredential);
		//     });
		U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * L_12 = V_0;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_13 = (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)il2cpp_codegen_object_new(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161(L_13, L_12, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass9_0_U3CLoginWithAppleIdU3Eb__0_mA62EB5BB7611FA73AFDB2697C47D792A7122E3EF_RuntimeMethod_var), /*hidden argument*/Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var);
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		uint32_t L_14;
		L_14 = CallbackHandler_AddMessageCallback_m7B194DE6CC041640E88BDB3111D732D7BE355E92((bool)1, L_13, /*hidden argument*/NULL);
		// PInvoke.AppleAuth_LoginWithAppleId(requestId, (int)loginOptions, nonce, state);
		int32_t L_15 = V_1;
		String_t* L_16 = V_2;
		String_t* L_17 = V_3;
		PInvoke_AppleAuth_LoginWithAppleId_m9A61219460D34AE8A008FAA16C756A30029EC7B8(L_14, L_15, L_16, L_17, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager::GetCredentialState(System.String,System.Action`1<AppleAuth.Enums.CredentialState>,System.Action`1<AppleAuth.Interfaces.IAppleError>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_GetCredentialState_mBA1ECA7B6EE84C2675632FA01306869C53D1422F (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, String_t* ___userId0, Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 * ___successCallback1, Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * ___errorCallback2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass10_0_U3CGetCredentialStateU3Eb__0_m86C591492D3EFBD62625107928D944A52044BA59_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * V_0 = NULL;
	{
		U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * L_0 = (U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass10_0__ctor_m9AF46F3648D1F310EAA6633345AE5B109BEE9D3B(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * L_1 = V_0;
		NullCheck(L_1);
		L_1->set_U3CU3E4__this_0(__this);
		U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * L_2 = V_0;
		Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * L_3 = ___errorCallback2;
		NullCheck(L_2);
		L_2->set_errorCallback_1(L_3);
		U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * L_4 = V_0;
		Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 * L_5 = ___successCallback1;
		NullCheck(L_4);
		L_4->set_successCallback_2(L_5);
		// var requestId = CallbackHandler.AddMessageCallback(
		//     true,
		//     payload =>
		//     {
		//         var response = this._payloadDeserializer.DeserializeCredentialStateResponse(payload);
		//         if (response.Error != null)
		//             errorCallback(response.Error);
		//         else
		//             successCallback(response.CredentialState);
		//     });
		U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * L_6 = V_0;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_7 = (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)il2cpp_codegen_object_new(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161(L_7, L_6, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass10_0_U3CGetCredentialStateU3Eb__0_m86C591492D3EFBD62625107928D944A52044BA59_RuntimeMethod_var), /*hidden argument*/Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var);
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		uint32_t L_8;
		L_8 = CallbackHandler_AddMessageCallback_m7B194DE6CC041640E88BDB3111D732D7BE355E92((bool)1, L_7, /*hidden argument*/NULL);
		// PInvoke.AppleAuth_GetCredentialState(requestId, userId);
		String_t* L_9 = ___userId0;
		PInvoke_AppleAuth_GetCredentialState_mE2F5EDC4A49B99D61296CCC4A3C284667E7EC40D(L_8, L_9, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager::SetCredentialsRevokedCallback(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_SetCredentialsRevokedCallback_m91B3771189CB3EF4F263D4F4C03A1FBE17ECA9E4 (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___credentialsRevokedCallback0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (this._credentialsRevokedCallback != null)
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_0 = __this->get__credentialsRevokedCallback_1();
		if (!L_0)
		{
			goto IL_001a;
		}
	}
	{
		// CallbackHandler.NativeCredentialsRevoked -= this._credentialsRevokedCallback;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_1 = __this->get__credentialsRevokedCallback_1();
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		CallbackHandler_remove_NativeCredentialsRevoked_mAB87C721DDE673ADD5DF4F1FB03005DB78060A14(L_1, /*hidden argument*/NULL);
		// this._credentialsRevokedCallback = null;
		__this->set__credentialsRevokedCallback_1((Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)NULL);
	}

IL_001a:
	{
		// if (credentialsRevokedCallback != null)
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_2 = ___credentialsRevokedCallback0;
		if (!L_2)
		{
			goto IL_002a;
		}
	}
	{
		// CallbackHandler.NativeCredentialsRevoked += credentialsRevokedCallback;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_3 = ___credentialsRevokedCallback0;
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		CallbackHandler_add_NativeCredentialsRevoked_m9A6E540FAEA285B407694C30EF23F8A949837F09(L_3, /*hidden argument*/NULL);
		// this._credentialsRevokedCallback = credentialsRevokedCallback;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_4 = ___credentialsRevokedCallback0;
		__this->set__credentialsRevokedCallback_1(L_4);
	}

IL_002a:
	{
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthManager_Update_m1F9CC97AE702FC1FD826266963D3DD6402D627B7 (AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// CallbackHandler.ExecutePendingCallbacks();
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		CallbackHandler_ExecutePendingCallbacks_m8FDE99CABAE4E3E08A7D8590D863CB550A3AC24B(/*hidden argument*/NULL);
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
// Conversion methods for marshalling of: AppleAuth.AppleAuthQuickLoginArgs
IL2CPP_EXTERN_C void AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshal_pinvoke(const AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE& unmarshaled, AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshaled_pinvoke& marshaled)
{
	marshaled.___Nonce_0 = il2cpp_codegen_marshal_string(unmarshaled.get_Nonce_0());
	marshaled.___State_1 = il2cpp_codegen_marshal_string(unmarshaled.get_State_1());
}
IL2CPP_EXTERN_C void AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshal_pinvoke_back(const AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshaled_pinvoke& marshaled, AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE& unmarshaled)
{
	unmarshaled.set_Nonce_0(il2cpp_codegen_marshal_string_result(marshaled.___Nonce_0));
	unmarshaled.set_State_1(il2cpp_codegen_marshal_string_result(marshaled.___State_1));
}
// Conversion method for clean up from marshalling of: AppleAuth.AppleAuthQuickLoginArgs
IL2CPP_EXTERN_C void AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshal_pinvoke_cleanup(AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___Nonce_0);
	marshaled.___Nonce_0 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___State_1);
	marshaled.___State_1 = NULL;
}
// Conversion methods for marshalling of: AppleAuth.AppleAuthQuickLoginArgs
IL2CPP_EXTERN_C void AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshal_com(const AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE& unmarshaled, AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshaled_com& marshaled)
{
	marshaled.___Nonce_0 = il2cpp_codegen_marshal_bstring(unmarshaled.get_Nonce_0());
	marshaled.___State_1 = il2cpp_codegen_marshal_bstring(unmarshaled.get_State_1());
}
IL2CPP_EXTERN_C void AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshal_com_back(const AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshaled_com& marshaled, AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE& unmarshaled)
{
	unmarshaled.set_Nonce_0(il2cpp_codegen_marshal_bstring_result(marshaled.___Nonce_0));
	unmarshaled.set_State_1(il2cpp_codegen_marshal_bstring_result(marshaled.___State_1));
}
// Conversion method for clean up from marshalling of: AppleAuth.AppleAuthQuickLoginArgs
IL2CPP_EXTERN_C void AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshal_com_cleanup(AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___Nonce_0);
	marshaled.___Nonce_0 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___State_1);
	marshaled.___State_1 = NULL;
}
// System.Void AppleAuth.AppleAuthQuickLoginArgs::.ctor(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleAuthQuickLoginArgs__ctor_m043BC449E06C61C6EAD18D0380BA196AB99A9F93 (AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE * __this, String_t* ___nonce0, String_t* ___state1, const RuntimeMethod* method)
{
	{
		// this.Nonce = nonce;
		String_t* L_0 = ___nonce0;
		__this->set_Nonce_0(L_0);
		// this.State = state;
		String_t* L_1 = ___state1;
		__this->set_State_1(L_1);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void AppleAuthQuickLoginArgs__ctor_m043BC449E06C61C6EAD18D0380BA196AB99A9F93_AdjustorThunk (RuntimeObject * __this, String_t* ___nonce0, String_t* ___state1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE * _thisAdjusted = reinterpret_cast<AppleAuthQuickLoginArgs_tB4EBA8537306E44BEEDC145F62F83CA0E0864DAE *>(__this + _offset);
	AppleAuthQuickLoginArgs__ctor_m043BC449E06C61C6EAD18D0380BA196AB99A9F93(_thisAdjusted, ___nonce0, ___state1, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 AppleAuth.Native.AppleError::get_Code()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AppleError_get_Code_m998B2B7DE24904B19A1040AA9CA7B549C14454CA (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	{
		// public int Code { get { return this._code; } }
		int32_t L_0 = __this->get__code_0();
		return L_0;
	}
}
// System.String AppleAuth.Native.AppleError::get_Domain()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AppleError_get_Domain_mD5851A9969413955F24F8DE4EABE06F15526BDCD (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	{
		// public string Domain { get { return this._domain; } }
		String_t* L_0 = __this->get__domain_1();
		return L_0;
	}
}
// System.String AppleAuth.Native.AppleError::get_LocalizedDescription()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AppleError_get_LocalizedDescription_m6ED91BB91B76E83B726E3DF370F9BD39B14EDCF5 (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	{
		// public string LocalizedDescription { get { return this._localizedDescription; } }
		String_t* L_0 = __this->get__localizedDescription_2();
		return L_0;
	}
}
// System.String[] AppleAuth.Native.AppleError::get_LocalizedRecoveryOptions()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* AppleError_get_LocalizedRecoveryOptions_m73ED1A684345E9EDA0C23A0CAF7F38DA69293BC9 (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	{
		// public string[] LocalizedRecoveryOptions { get { return this._localizedRecoveryOptions; } }
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_0 = __this->get__localizedRecoveryOptions_3();
		return L_0;
	}
}
// System.String AppleAuth.Native.AppleError::get_LocalizedRecoverySuggestion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AppleError_get_LocalizedRecoverySuggestion_mD8EFE4C5025AE558730C8BE64BC11E6ECA9E5F10 (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	{
		// public string LocalizedRecoverySuggestion { get { return this._localizedRecoverySuggestion; } }
		String_t* L_0 = __this->get__localizedRecoverySuggestion_4();
		return L_0;
	}
}
// System.String AppleAuth.Native.AppleError::get_LocalizedFailureReason()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AppleError_get_LocalizedFailureReason_m17931F3110E3BF6C4D81B276268BAC80FB5ECDC9 (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	{
		// public string LocalizedFailureReason { get { return this._localizedFailureReason; } }
		String_t* L_0 = __this->get__localizedFailureReason_5();
		return L_0;
	}
}
// System.Void AppleAuth.Native.AppleError::OnBeforeSerialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleError_OnBeforeSerialize_m44069A2F5269C9DA52809D3CBBA8ADF424078E75 (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	{
		// public void OnBeforeSerialize() { }
		return;
	}
}
// System.Void AppleAuth.Native.AppleError::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleError_OnAfterDeserialize_m3E3F1EC02A24597A4A49A54CFE369E97650A963C (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForArray_TisString_t_m4508C4D7A8194BD8A3F86525D870B214646B89D8_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SerializationTools.FixSerializationForString(ref this._domain);
		String_t** L_0 = __this->get_address_of__domain_1();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_0, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._localizedDescription);
		String_t** L_1 = __this->get_address_of__localizedDescription_2();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_1, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._localizedRecoverySuggestion);
		String_t** L_2 = __this->get_address_of__localizedRecoverySuggestion_4();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_2, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._localizedFailureReason);
		String_t** L_3 = __this->get_address_of__localizedFailureReason_5();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_3, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForArray(ref this._localizedRecoveryOptions);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** L_4 = __this->get_address_of__localizedRecoveryOptions_3();
		SerializationTools_FixSerializationForArray_TisString_t_m4508C4D7A8194BD8A3F86525D870B214646B89D8((StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A**)L_4, /*hidden argument*/SerializationTools_FixSerializationForArray_TisString_t_m4508C4D7A8194BD8A3F86525D870B214646B89D8_RuntimeMethod_var);
		// }
		return;
	}
}
// System.String AppleAuth.Native.AppleError::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AppleError_ToString_m777433F7A496602A3F93F8FC8793E1FD304BDDC5 (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral93D9B00D6E9CE12A85069965CC351E5DE11CA3AD);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return $"Domain={_domain} Code={_code} Description={_localizedDescription}";
		String_t* L_0 = __this->get__domain_1();
		int32_t L_1 = __this->get__code_0();
		int32_t L_2 = L_1;
		RuntimeObject * L_3 = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &L_2);
		String_t* L_4 = __this->get__localizedDescription_2();
		String_t* L_5;
		L_5 = String_Format_m039737CCD992C5BFC8D16DFD681F5E8786E87FA6(_stringLiteral93D9B00D6E9CE12A85069965CC351E5DE11CA3AD, L_0, L_3, L_4, /*hidden argument*/NULL);
		return L_5;
	}
}
// System.Void AppleAuth.Native.AppleError::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleError__ctor_m21957A1973268E2D76E19628453FAAD8F1F209DF (AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * __this, const RuntimeMethod* method)
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
// AppleAuth.Enums.AuthorizationErrorCode AppleAuth.Extensions.AppleErrorExtensions::GetAuthorizationErrorCode(AppleAuth.Interfaces.IAppleError)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AppleErrorExtensions_GetAuthorizationErrorCode_m18C2F50BA8124CE8CD3A68D2E1868E01D63AF561 (RuntimeObject* ___error0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AuthorizationErrorCode_t39345506E8A14B87DC20E75D12142CE1804DF557_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enum_t23B90B40F60E677A8025267341651C94AE079CDA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IAppleError_t67DF74DC018430779145EFC48504E9D023F98602_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCA0DA7AFA13D06380B286383F61CFD3BFBFDEB4B);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (error.Domain == "com.apple.AuthenticationServices.AuthorizationError" &&
		//     Enum.IsDefined(typeof(AuthorizationErrorCode), error.Code))
		RuntimeObject* L_0 = ___error0;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = InterfaceFuncInvoker0< String_t* >::Invoke(1 /* System.String AppleAuth.Interfaces.IAppleError::get_Domain() */, IAppleError_t67DF74DC018430779145EFC48504E9D023F98602_il2cpp_TypeInfo_var, L_0);
		bool L_2;
		L_2 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_1, _stringLiteralCA0DA7AFA13D06380B286383F61CFD3BFBFDEB4B, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_0035;
		}
	}
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_3 = { reinterpret_cast<intptr_t> (AuthorizationErrorCode_t39345506E8A14B87DC20E75D12142CE1804DF557_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_4;
		L_4 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E(L_3, /*hidden argument*/NULL);
		RuntimeObject* L_5 = ___error0;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = InterfaceFuncInvoker0< int32_t >::Invoke(0 /* System.Int32 AppleAuth.Interfaces.IAppleError::get_Code() */, IAppleError_t67DF74DC018430779145EFC48504E9D023F98602_il2cpp_TypeInfo_var, L_5);
		int32_t L_7 = L_6;
		RuntimeObject * L_8 = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &L_7);
		IL2CPP_RUNTIME_CLASS_INIT(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_il2cpp_TypeInfo_var);
		bool L_9;
		L_9 = Enum_IsDefined_m70E955627155998B426145940DE105ECEF213B96(L_4, L_8, /*hidden argument*/NULL);
		if (!L_9)
		{
			goto IL_0035;
		}
	}
	{
		// return (AuthorizationErrorCode)error.Code;
		RuntimeObject* L_10 = ___error0;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = InterfaceFuncInvoker0< int32_t >::Invoke(0 /* System.Int32 AppleAuth.Interfaces.IAppleError::get_Code() */, IAppleError_t67DF74DC018430779145EFC48504E9D023F98602_il2cpp_TypeInfo_var, L_10);
		return (int32_t)(L_11);
	}

IL_0035:
	{
		// return AuthorizationErrorCode.Unknown;
		return (int32_t)(((int32_t)1000));
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
// System.Byte[] AppleAuth.Native.AppleIDCredential::get_IdentityToken()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* AppleIDCredential_get_IdentityToken_m88EB89F4E29C6E9C1EE228D5F14639DBC653B10B (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public byte[] IdentityToken { get { return this._identityToken; } }
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = __this->get__identityToken_9();
		return L_0;
	}
}
// System.Byte[] AppleAuth.Native.AppleIDCredential::get_AuthorizationCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* AppleIDCredential_get_AuthorizationCode_m6E8179FA8FF93AD47C73740F37945F8873B45912 (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public byte[] AuthorizationCode { get { return this._authorizationCode; } }
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_0 = __this->get__authorizationCode_10();
		return L_0;
	}
}
// System.String AppleAuth.Native.AppleIDCredential::get_State()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AppleIDCredential_get_State_mDBF6E62DAF0D1ACFAB3FD3E2736D75C0BB4D7C05 (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public string State { get { return this._state; } }
		String_t* L_0 = __this->get__state_2();
		return L_0;
	}
}
// System.String AppleAuth.Native.AppleIDCredential::get_User()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AppleIDCredential_get_User_mE05FD0711E3EDE24348B6CDC797BEA9799C2D56B (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public string User { get { return this._user; } }
		String_t* L_0 = __this->get__user_3();
		return L_0;
	}
}
// System.String[] AppleAuth.Native.AppleIDCredential::get_AuthorizedScopes()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* AppleIDCredential_get_AuthorizedScopes_mA1A05E81FE5381913B8E0451D2F9EC574933BDF4 (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public string[] AuthorizedScopes { get { return this._authorizedScopes; } }
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_0 = __this->get__authorizedScopes_4();
		return L_0;
	}
}
// AppleAuth.Interfaces.IPersonName AppleAuth.Native.AppleIDCredential::get_FullName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* AppleIDCredential_get_FullName_m20E28FEA24D60812B11979EF164F9B83FC7E950E (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public IPersonName FullName { get { return this._fullName; } }
		FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F * L_0 = __this->get__fullName_6();
		return L_0;
	}
}
// System.String AppleAuth.Native.AppleIDCredential::get_Email()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AppleIDCredential_get_Email_m1CA397D5FE51A69A79C8A100DE67A16B1D3ABA06 (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public string Email { get { return this._email; } }
		String_t* L_0 = __this->get__email_7();
		return L_0;
	}
}
// AppleAuth.Enums.RealUserStatus AppleAuth.Native.AppleIDCredential::get_RealUserStatus()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AppleIDCredential_get_RealUserStatus_mBFDD4ABE7F6B70DD63B97440301B3C18228C8355 (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public RealUserStatus RealUserStatus { get { return (RealUserStatus) this._realUserStatus; } }
		int32_t L_0 = __this->get__realUserStatus_8();
		return (int32_t)(L_0);
	}
}
// System.Void AppleAuth.Native.AppleIDCredential::OnBeforeSerialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleIDCredential_OnBeforeSerialize_m51724ECFF259753B93F19BF782638CF15457CFEB (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	{
		// public void OnBeforeSerialize() { }
		return;
	}
}
// System.Void AppleAuth.Native.AppleIDCredential::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleIDCredential_OnAfterDeserialize_m36FF10347F8071736B105CA7674926B859A1EBF8 (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForArray_TisString_t_m4508C4D7A8194BD8A3F86525D870B214646B89D8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForObject_TisFullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F_m2C9FB5DFB296EC5FD48BDE7B7B83550625AA55FE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4B31B12774EADD6A7DE8A6382F262DAD80E785C9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA3990537E355E81C23A6B8320705118BC1046ED);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SerializationTools.FixSerializationForString(ref this._base64IdentityToken);
		String_t** L_0 = __this->get_address_of__base64IdentityToken_0();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_0, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._base64AuthorizationCode);
		String_t** L_1 = __this->get_address_of__base64AuthorizationCode_1();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_1, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._state);
		String_t** L_2 = __this->get_address_of__state_2();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_2, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._user);
		String_t** L_3 = __this->get_address_of__user_3();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_3, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._email);
		String_t** L_4 = __this->get_address_of__email_7();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_4, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForArray(ref this._authorizedScopes);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** L_5 = __this->get_address_of__authorizedScopes_4();
		SerializationTools_FixSerializationForArray_TisString_t_m4508C4D7A8194BD8A3F86525D870B214646B89D8((StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A**)L_5, /*hidden argument*/SerializationTools_FixSerializationForArray_TisString_t_m4508C4D7A8194BD8A3F86525D870B214646B89D8_RuntimeMethod_var);
		// SerializationTools.FixSerializationForObject(ref this._fullName, this._hasFullName);
		FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F ** L_6 = __this->get_address_of__fullName_6();
		bool L_7 = __this->get__hasFullName_5();
		SerializationTools_FixSerializationForObject_TisFullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F_m2C9FB5DFB296EC5FD48BDE7B7B83550625AA55FE((FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F **)L_6, L_7, /*hidden argument*/SerializationTools_FixSerializationForObject_TisFullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F_m2C9FB5DFB296EC5FD48BDE7B7B83550625AA55FE_RuntimeMethod_var);
		// this._identityToken = SerializationTools.GetBytesFromBase64String(this._base64IdentityToken, "_identityToken");
		String_t* L_8 = __this->get__base64IdentityToken_0();
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_9;
		L_9 = SerializationTools_GetBytesFromBase64String_mC62CDA9500A1DB0D8401FB2F655D006BACE3CD2F(L_8, _stringLiteralDA3990537E355E81C23A6B8320705118BC1046ED, /*hidden argument*/NULL);
		__this->set__identityToken_9(L_9);
		// this._authorizationCode = SerializationTools.GetBytesFromBase64String(this._base64AuthorizationCode, "_authorizationCode");
		String_t* L_10 = __this->get__base64AuthorizationCode_1();
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_11;
		L_11 = SerializationTools_GetBytesFromBase64String_mC62CDA9500A1DB0D8401FB2F655D006BACE3CD2F(L_10, _stringLiteral4B31B12774EADD6A7DE8A6382F262DAD80E785C9, /*hidden argument*/NULL);
		__this->set__authorizationCode_10(L_11);
		// }
		return;
	}
}
// System.Void AppleAuth.Native.AppleIDCredential::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AppleIDCredential__ctor_mF74CB3E39A6C887F0E9BB88A7CFD68D8FE1CBFB9 (AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * __this, const RuntimeMethod* method)
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
// System.Boolean AppleAuth.Native.CredentialStateResponse::get_Success()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool CredentialStateResponse_get_Success_m703B60AC37F745BFDC9B85F9E903A58511C94CD0 (CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * __this, const RuntimeMethod* method)
{
	{
		// public bool Success { get { return this._success; } }
		bool L_0 = __this->get__success_0();
		return L_0;
	}
}
// AppleAuth.Enums.CredentialState AppleAuth.Native.CredentialStateResponse::get_CredentialState()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CredentialStateResponse_get_CredentialState_mFF87869CDA57093F3EECF0D6AA2AFD59467B108E (CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * __this, const RuntimeMethod* method)
{
	{
		// public CredentialState CredentialState { get { return (CredentialState) this._credentialState; } }
		int32_t L_0 = __this->get__credentialState_3();
		return (int32_t)(L_0);
	}
}
// AppleAuth.Interfaces.IAppleError AppleAuth.Native.CredentialStateResponse::get_Error()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* CredentialStateResponse_get_Error_m134C3C415C7AA942C02E88A8589CF8C5980C0C3F (CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * __this, const RuntimeMethod* method)
{
	{
		// public IAppleError Error { get { return this._error; } }
		AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * L_0 = __this->get__error_4();
		return L_0;
	}
}
// System.Void AppleAuth.Native.CredentialStateResponse::OnBeforeSerialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CredentialStateResponse_OnBeforeSerialize_mFF1E61B5782461A2126074F4D6D8265FE207808D (CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * __this, const RuntimeMethod* method)
{
	{
		// public void OnBeforeSerialize() { }
		return;
	}
}
// System.Void AppleAuth.Native.CredentialStateResponse::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CredentialStateResponse_OnAfterDeserialize_m8D26F323AC14D2E42E1DA8C3AA9386AF3F14BA61 (CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForObject_TisAppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5_mF02F1B47277A639EDF4EDBE0123B1FC5E289E017_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForObject_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mC91420AF1574C1B1A3945354470789F8D482CAC5_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SerializationTools.FixSerializationForObject(ref this._credentialState, this._hasCredentialState);
		int32_t* L_0 = __this->get_address_of__credentialState_3();
		bool L_1 = __this->get__hasCredentialState_1();
		SerializationTools_FixSerializationForObject_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mC91420AF1574C1B1A3945354470789F8D482CAC5((int32_t*)L_0, L_1, /*hidden argument*/SerializationTools_FixSerializationForObject_TisInt32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_mC91420AF1574C1B1A3945354470789F8D482CAC5_RuntimeMethod_var);
		// SerializationTools.FixSerializationForObject(ref this._error, this._hasError);
		AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 ** L_2 = __this->get_address_of__error_4();
		bool L_3 = __this->get__hasError_2();
		SerializationTools_FixSerializationForObject_TisAppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5_mF02F1B47277A639EDF4EDBE0123B1FC5E289E017((AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 **)L_2, L_3, /*hidden argument*/SerializationTools_FixSerializationForObject_TisAppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5_mF02F1B47277A639EDF4EDBE0123B1FC5E289E017_RuntimeMethod_var);
		// }
		return;
	}
}
// System.Void AppleAuth.Native.CredentialStateResponse::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CredentialStateResponse__ctor_m2E16126AE507CA4C92C8082F47AF4A628C1F2DBA (CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * __this, const RuntimeMethod* method)
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
// AppleAuth.Interfaces.IPersonName AppleAuth.Native.FullPersonName::get_PhoneticRepresentation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* FullPersonName_get_PhoneticRepresentation_m3F40A727A87891125A8F6533DCBDE5F50E4E04DC (FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F * __this, const RuntimeMethod* method)
{
	{
		// public new IPersonName PhoneticRepresentation { get { return _phoneticRepresentation; } }
		PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * L_0 = __this->get__phoneticRepresentation_7();
		return L_0;
	}
}
// System.Void AppleAuth.Native.FullPersonName::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FullPersonName_OnAfterDeserialize_m03401370A164AC6530215459BB0005313D39051A (FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForObject_TisPersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575_m617A30C4801302EBEA5A9372B5F749559919980B_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// base.OnAfterDeserialize();
		PersonName_OnAfterDeserialize_mCB951E18D2ACAD268936336AD70B20C4149F00B5(__this, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForObject(ref this._phoneticRepresentation, this._hasPhoneticRepresentation);
		PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 ** L_0 = __this->get_address_of__phoneticRepresentation_7();
		bool L_1 = __this->get__hasPhoneticRepresentation_6();
		SerializationTools_FixSerializationForObject_TisPersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575_m617A30C4801302EBEA5A9372B5F749559919980B((PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 **)L_0, L_1, /*hidden argument*/SerializationTools_FixSerializationForObject_TisPersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575_m617A30C4801302EBEA5A9372B5F749559919980B_RuntimeMethod_var);
		// }
		return;
	}
}
// System.Void AppleAuth.Native.FullPersonName::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FullPersonName__ctor_m3DC0191C0707F2100F723E888F1AA0CF2F89BBA4 (FullPersonName_t303E56178B03CE1DF4717E1F0A4EDE671DEB6A4F * __this, const RuntimeMethod* method)
{
	{
		PersonName__ctor_mD480CDC2BE2345F367BE8C893C3210BEF68F9399(__this, /*hidden argument*/NULL);
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
// System.Boolean AppleAuth.Native.LoginWithAppleIdResponse::get_Success()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool LoginWithAppleIdResponse_get_Success_mEE019B05F2383810D8A1CAFA3F869A6A181A5956 (LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * __this, const RuntimeMethod* method)
{
	{
		// public bool Success { get { return this._success; } }
		bool L_0 = __this->get__success_0();
		return L_0;
	}
}
// AppleAuth.Interfaces.IAppleError AppleAuth.Native.LoginWithAppleIdResponse::get_Error()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* LoginWithAppleIdResponse_get_Error_mF38EE7A4EA12527FB31ED35CF2D792B47B507BB4 (LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * __this, const RuntimeMethod* method)
{
	{
		// public IAppleError Error { get { return this._error; } }
		AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 * L_0 = __this->get__error_6();
		return L_0;
	}
}
// AppleAuth.Interfaces.IAppleIDCredential AppleAuth.Native.LoginWithAppleIdResponse::get_AppleIDCredential()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* LoginWithAppleIdResponse_get_AppleIDCredential_mB4CE0CE4DC23060DB3B50D1813F4D4821A3965C4 (LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * __this, const RuntimeMethod* method)
{
	{
		// public IAppleIDCredential AppleIDCredential { get { return this._appleIdCredential; } }
		AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 * L_0 = __this->get__appleIdCredential_4();
		return L_0;
	}
}
// AppleAuth.Interfaces.IPasswordCredential AppleAuth.Native.LoginWithAppleIdResponse::get_PasswordCredential()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* LoginWithAppleIdResponse_get_PasswordCredential_m2E44E0D9777E1CA1AFE3F28427B4467D391683B2 (LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * __this, const RuntimeMethod* method)
{
	{
		// public IPasswordCredential PasswordCredential { get { return this._passwordCredential; } }
		PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * L_0 = __this->get__passwordCredential_5();
		return L_0;
	}
}
// System.Void AppleAuth.Native.LoginWithAppleIdResponse::OnBeforeSerialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LoginWithAppleIdResponse_OnBeforeSerialize_m2288FB8C1635107FE3ACA4626649DFBD594CC505 (LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * __this, const RuntimeMethod* method)
{
	{
		// public void OnBeforeSerialize() { }
		return;
	}
}
// System.Void AppleAuth.Native.LoginWithAppleIdResponse::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LoginWithAppleIdResponse_OnAfterDeserialize_mDFF513395873B5E016A1C97A0B40E7885D1681ED (LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForObject_TisAppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5_mF02F1B47277A639EDF4EDBE0123B1FC5E289E017_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForObject_TisAppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612_m56697900B3FA29ADB060E74DB02057455D909D96_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SerializationTools_FixSerializationForObject_TisPasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372_mD95DFFCC92BBB817B7B3842C2A4CFA956459D63C_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// SerializationTools.FixSerializationForObject(ref this._error, this._hasError);
		AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 ** L_0 = __this->get_address_of__error_6();
		bool L_1 = __this->get__hasError_3();
		SerializationTools_FixSerializationForObject_TisAppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5_mF02F1B47277A639EDF4EDBE0123B1FC5E289E017((AppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5 **)L_0, L_1, /*hidden argument*/SerializationTools_FixSerializationForObject_TisAppleError_t178070F9FBAFA2B7555097FD1989C1FD2ABD63B5_mF02F1B47277A639EDF4EDBE0123B1FC5E289E017_RuntimeMethod_var);
		// SerializationTools.FixSerializationForObject(ref this._appleIdCredential, this._hasAppleIdCredential);
		AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 ** L_2 = __this->get_address_of__appleIdCredential_4();
		bool L_3 = __this->get__hasAppleIdCredential_1();
		SerializationTools_FixSerializationForObject_TisAppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612_m56697900B3FA29ADB060E74DB02057455D909D96((AppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612 **)L_2, L_3, /*hidden argument*/SerializationTools_FixSerializationForObject_TisAppleIDCredential_t7565E891A81AAE46CDDD98C8CD4C2B316B4C8612_m56697900B3FA29ADB060E74DB02057455D909D96_RuntimeMethod_var);
		// SerializationTools.FixSerializationForObject(ref this._passwordCredential, this._hasPasswordCredential);
		PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 ** L_4 = __this->get_address_of__passwordCredential_5();
		bool L_5 = __this->get__hasPasswordCredential_2();
		SerializationTools_FixSerializationForObject_TisPasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372_mD95DFFCC92BBB817B7B3842C2A4CFA956459D63C((PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 **)L_4, L_5, /*hidden argument*/SerializationTools_FixSerializationForObject_TisPasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372_mD95DFFCC92BBB817B7B3842C2A4CFA956459D63C_RuntimeMethod_var);
		// }
		return;
	}
}
// System.Void AppleAuth.Native.LoginWithAppleIdResponse::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LoginWithAppleIdResponse__ctor_mF02FC6B6B663C21F1B575D41F01F28A635219561 (LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * __this, const RuntimeMethod* method)
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
// System.String AppleAuth.Native.PasswordCredential::get_User()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PasswordCredential_get_User_mFC6889FBFA7B6FF9E93904ADB009F46ABA4894EB (PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * __this, const RuntimeMethod* method)
{
	{
		// public string User { get { return this._user; } }
		String_t* L_0 = __this->get__user_0();
		return L_0;
	}
}
// System.String AppleAuth.Native.PasswordCredential::get_Password()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PasswordCredential_get_Password_m1E8887A5D315DB769B5C8799813BE9868955EA34 (PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * __this, const RuntimeMethod* method)
{
	{
		// public string Password { get { return this._password; } }
		String_t* L_0 = __this->get__password_1();
		return L_0;
	}
}
// System.Void AppleAuth.Native.PasswordCredential::OnBeforeSerialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PasswordCredential_OnBeforeSerialize_m0997FDDD9FBBFF955127764296E931FF2F257484 (PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * __this, const RuntimeMethod* method)
{
	{
		// public void OnBeforeSerialize() { }
		return;
	}
}
// System.Void AppleAuth.Native.PasswordCredential::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PasswordCredential_OnAfterDeserialize_m761E1E02DFF24AF6230B213C73BDC0764084044C (PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * __this, const RuntimeMethod* method)
{
	{
		// SerializationTools.FixSerializationForString(ref this._user);
		String_t** L_0 = __this->get_address_of__user_0();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_0, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._password);
		String_t** L_1 = __this->get_address_of__password_1();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_1, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AppleAuth.Native.PasswordCredential::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PasswordCredential__ctor_mBF8A05155BB8E7E7DA22CF72FF80634EC03509B3 (PasswordCredential_tD0961201A3141B6BD9802D34AD0A0011BBDF0372 * __this, const RuntimeMethod* method)
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
// AppleAuth.Interfaces.ICredentialStateResponse AppleAuth.Native.PayloadDeserializer::DeserializeCredentialStateResponse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PayloadDeserializer_DeserializeCredentialStateResponse_m5BB3EC90BF34CC544851F3FBE71544AC18AF012C (PayloadDeserializer_t600547BA2304A4FA88803CCFEDE89EC5D9FBAD14 * __this, String_t* ___payload0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JsonUtility_FromJson_TisCredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433_mF602D4AE88853D8A2A9C9D40421058B6834CFFDC_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return JsonUtility.FromJson<CredentialStateResponse>(payload);
		String_t* L_0 = ___payload0;
		CredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433 * L_1;
		L_1 = JsonUtility_FromJson_TisCredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433_mF602D4AE88853D8A2A9C9D40421058B6834CFFDC(L_0, /*hidden argument*/JsonUtility_FromJson_TisCredentialStateResponse_t3FC94F590E55458CC23AF58A7B7A63C77880F433_mF602D4AE88853D8A2A9C9D40421058B6834CFFDC_RuntimeMethod_var);
		return L_1;
	}
}
// AppleAuth.Interfaces.ILoginWithAppleIdResponse AppleAuth.Native.PayloadDeserializer::DeserializeLoginWithAppleIdResponse(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PayloadDeserializer_DeserializeLoginWithAppleIdResponse_m5E2545C4029E73CD7B97B2097640EDD6C945A0FB (PayloadDeserializer_t600547BA2304A4FA88803CCFEDE89EC5D9FBAD14 * __this, String_t* ___payload0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&JsonUtility_FromJson_TisLoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E_m5FE146A960E6F18BFFB51D58B287890DD5E53A21_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return JsonUtility.FromJson<LoginWithAppleIdResponse>(payload);
		String_t* L_0 = ___payload0;
		LoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E * L_1;
		L_1 = JsonUtility_FromJson_TisLoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E_m5FE146A960E6F18BFFB51D58B287890DD5E53A21(L_0, /*hidden argument*/JsonUtility_FromJson_TisLoginWithAppleIdResponse_tF57BAE392E5E0FA99FB738DBA1797435B268301E_m5FE146A960E6F18BFFB51D58B287890DD5E53A21_RuntimeMethod_var);
		return L_1;
	}
}
// System.Void AppleAuth.Native.PayloadDeserializer::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PayloadDeserializer__ctor_m7CC545A1B00832CD537687155732E0832BEB35E6 (PayloadDeserializer_t600547BA2304A4FA88803CCFEDE89EC5D9FBAD14 * __this, const RuntimeMethod* method)
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
// System.String AppleAuth.Native.PersonName::get_NamePrefix()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonName_get_NamePrefix_m626CEC232B50771B7901B0D9F8FE4D76773A0EB1 (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// public string NamePrefix { get { return _namePrefix; } }
		String_t* L_0 = __this->get__namePrefix_0();
		return L_0;
	}
}
// System.String AppleAuth.Native.PersonName::get_GivenName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonName_get_GivenName_mD4FC6FCA13C64A75DF012890CD243ABADDF2C80E (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// public string GivenName { get { return _givenName; } }
		String_t* L_0 = __this->get__givenName_1();
		return L_0;
	}
}
// System.String AppleAuth.Native.PersonName::get_MiddleName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonName_get_MiddleName_m133FB0613FA37141781728C39BE5BE16A386C9E6 (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// public string MiddleName { get { return _middleName; } }
		String_t* L_0 = __this->get__middleName_2();
		return L_0;
	}
}
// System.String AppleAuth.Native.PersonName::get_FamilyName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonName_get_FamilyName_m6E47CFE0BC05CEE58F4B4A0C4CB24C6F8C09B3BA (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// public string FamilyName { get { return _familyName; } }
		String_t* L_0 = __this->get__familyName_3();
		return L_0;
	}
}
// System.String AppleAuth.Native.PersonName::get_NameSuffix()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonName_get_NameSuffix_mE4F487F1398A07A5ECDBAB6D023C1C5AA6C474AC (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// public string NameSuffix { get { return _nameSuffix; } }
		String_t* L_0 = __this->get__nameSuffix_4();
		return L_0;
	}
}
// System.String AppleAuth.Native.PersonName::get_Nickname()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonName_get_Nickname_m4B90A0EA61895A5574DC2FD6C32B0DDB572A9675 (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// public string Nickname { get { return _nickname; } }
		String_t* L_0 = __this->get__nickname_5();
		return L_0;
	}
}
// AppleAuth.Interfaces.IPersonName AppleAuth.Native.PersonName::get_PhoneticRepresentation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PersonName_get_PhoneticRepresentation_m8C6E90A3C3E6802EF90E5B8B8EBED0D21F05AC4C (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// public IPersonName PhoneticRepresentation { get { return null; } }
		return (RuntimeObject*)NULL;
	}
}
// System.Void AppleAuth.Native.PersonName::OnBeforeSerialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PersonName_OnBeforeSerialize_m0C90D229B6F57B194F9FBD635641519A65156FBD (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// public void OnBeforeSerialize() { }
		return;
	}
}
// System.Void AppleAuth.Native.PersonName::OnAfterDeserialize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PersonName_OnAfterDeserialize_mCB951E18D2ACAD268936336AD70B20C4149F00B5 (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
{
	{
		// SerializationTools.FixSerializationForString(ref this._namePrefix);
		String_t** L_0 = __this->get_address_of__namePrefix_0();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_0, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._givenName);
		String_t** L_1 = __this->get_address_of__givenName_1();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_1, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._middleName);
		String_t** L_2 = __this->get_address_of__middleName_2();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_2, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._familyName);
		String_t** L_3 = __this->get_address_of__familyName_3();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_3, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._nameSuffix);
		String_t** L_4 = __this->get_address_of__nameSuffix_4();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_4, /*hidden argument*/NULL);
		// SerializationTools.FixSerializationForString(ref this._nickname);
		String_t** L_5 = __this->get_address_of__nickname_5();
		SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2((String_t**)L_5, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void AppleAuth.Native.PersonName::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PersonName__ctor_mD480CDC2BE2345F367BE8C893C3210BEF68F9399 (PersonName_t23AEAE8EA94AF2AB78C01F9316273CBA100CD575 * __this, const RuntimeMethod* method)
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
// System.String AppleAuth.Extensions.PersonNameExtensions::ToLocalizedString(AppleAuth.Interfaces.IPersonName,AppleAuth.Enums.PersonNameFormatterStyle,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonNameExtensions_ToLocalizedString_mCAC40A3411216B317856451568211AF03CA711F6 (RuntimeObject* ___personName0, int32_t ___style1, bool ___usePhoneticRepresentation2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m94163AE84EBF9A1F7483014A8E9906BD93D9EBDB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m30C52A4F2828D86CA3FAB0B1B583948F4DA9F1F9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * V_1 = NULL;
	{
		// var jsonString = JsonStringForPersonName(personName);
		RuntimeObject* L_0 = ___personName0;
		String_t* L_1;
		L_1 = PersonNameExtensions_JsonStringForPersonName_m009CD92B73A00F4AD0CB6B74000039C2D1F49290(L_0, /*hidden argument*/NULL);
		// var localizedString = PInvoke.AppleAuth_GetPersonNameUsingFormatter(jsonString, (int) style, usePhoneticRepresentation);
		int32_t L_2 = ___style1;
		bool L_3 = ___usePhoneticRepresentation2;
		String_t* L_4;
		L_4 = PInvoke_AppleAuth_GetPersonNameUsingFormatter_m3EB54DC8762902550797A25C7BB4E61FD63731E0(L_1, L_2, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		// if (localizedString != null)
		String_t* L_5 = V_0;
		if (!L_5)
		{
			goto IL_0013;
		}
	}
	{
		// return localizedString;
		String_t* L_6 = V_0;
		return L_6;
	}

IL_0013:
	{
		// var orderedParts = new System.Collections.Generic.List<string>();
		List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * L_7 = (List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 *)il2cpp_codegen_object_new(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3_il2cpp_TypeInfo_var);
		List_1__ctor_m30C52A4F2828D86CA3FAB0B1B583948F4DA9F1F9(L_7, /*hidden argument*/List_1__ctor_m30C52A4F2828D86CA3FAB0B1B583948F4DA9F1F9_RuntimeMethod_var);
		V_1 = L_7;
		// if (string.IsNullOrEmpty(personName.NamePrefix))
		RuntimeObject* L_8 = ___personName0;
		NullCheck(L_8);
		String_t* L_9;
		L_9 = InterfaceFuncInvoker0< String_t* >::Invoke(0 /* System.String AppleAuth.Interfaces.IPersonName::get_NamePrefix() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_8);
		bool L_10;
		L_10 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_9, /*hidden argument*/NULL);
		if (!L_10)
		{
			goto IL_0032;
		}
	}
	{
		// orderedParts.Add(personName.NamePrefix);
		List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * L_11 = V_1;
		RuntimeObject* L_12 = ___personName0;
		NullCheck(L_12);
		String_t* L_13;
		L_13 = InterfaceFuncInvoker0< String_t* >::Invoke(0 /* System.String AppleAuth.Interfaces.IPersonName::get_NamePrefix() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_12);
		NullCheck(L_11);
		List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE(L_11, L_13, /*hidden argument*/List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE_RuntimeMethod_var);
	}

IL_0032:
	{
		// if (string.IsNullOrEmpty(personName.GivenName))
		RuntimeObject* L_14 = ___personName0;
		NullCheck(L_14);
		String_t* L_15;
		L_15 = InterfaceFuncInvoker0< String_t* >::Invoke(1 /* System.String AppleAuth.Interfaces.IPersonName::get_GivenName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_14);
		bool L_16;
		L_16 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_15, /*hidden argument*/NULL);
		if (!L_16)
		{
			goto IL_004b;
		}
	}
	{
		// orderedParts.Add(personName.GivenName);
		List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * L_17 = V_1;
		RuntimeObject* L_18 = ___personName0;
		NullCheck(L_18);
		String_t* L_19;
		L_19 = InterfaceFuncInvoker0< String_t* >::Invoke(1 /* System.String AppleAuth.Interfaces.IPersonName::get_GivenName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_18);
		NullCheck(L_17);
		List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE(L_17, L_19, /*hidden argument*/List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE_RuntimeMethod_var);
	}

IL_004b:
	{
		// if (string.IsNullOrEmpty(personName.MiddleName))
		RuntimeObject* L_20 = ___personName0;
		NullCheck(L_20);
		String_t* L_21;
		L_21 = InterfaceFuncInvoker0< String_t* >::Invoke(2 /* System.String AppleAuth.Interfaces.IPersonName::get_MiddleName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_20);
		bool L_22;
		L_22 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_21, /*hidden argument*/NULL);
		if (!L_22)
		{
			goto IL_0064;
		}
	}
	{
		// orderedParts.Add(personName.MiddleName);
		List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * L_23 = V_1;
		RuntimeObject* L_24 = ___personName0;
		NullCheck(L_24);
		String_t* L_25;
		L_25 = InterfaceFuncInvoker0< String_t* >::Invoke(2 /* System.String AppleAuth.Interfaces.IPersonName::get_MiddleName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_24);
		NullCheck(L_23);
		List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE(L_23, L_25, /*hidden argument*/List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE_RuntimeMethod_var);
	}

IL_0064:
	{
		// if (string.IsNullOrEmpty(personName.FamilyName))
		RuntimeObject* L_26 = ___personName0;
		NullCheck(L_26);
		String_t* L_27;
		L_27 = InterfaceFuncInvoker0< String_t* >::Invoke(3 /* System.String AppleAuth.Interfaces.IPersonName::get_FamilyName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_26);
		bool L_28;
		L_28 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_27, /*hidden argument*/NULL);
		if (!L_28)
		{
			goto IL_007d;
		}
	}
	{
		// orderedParts.Add(personName.FamilyName);
		List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * L_29 = V_1;
		RuntimeObject* L_30 = ___personName0;
		NullCheck(L_30);
		String_t* L_31;
		L_31 = InterfaceFuncInvoker0< String_t* >::Invoke(3 /* System.String AppleAuth.Interfaces.IPersonName::get_FamilyName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_30);
		NullCheck(L_29);
		List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE(L_29, L_31, /*hidden argument*/List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE_RuntimeMethod_var);
	}

IL_007d:
	{
		// if (string.IsNullOrEmpty(personName.NameSuffix))
		RuntimeObject* L_32 = ___personName0;
		NullCheck(L_32);
		String_t* L_33;
		L_33 = InterfaceFuncInvoker0< String_t* >::Invoke(4 /* System.String AppleAuth.Interfaces.IPersonName::get_NameSuffix() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_32);
		bool L_34;
		L_34 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_33, /*hidden argument*/NULL);
		if (!L_34)
		{
			goto IL_0096;
		}
	}
	{
		// orderedParts.Add(personName.NameSuffix);
		List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * L_35 = V_1;
		RuntimeObject* L_36 = ___personName0;
		NullCheck(L_36);
		String_t* L_37;
		L_37 = InterfaceFuncInvoker0< String_t* >::Invoke(4 /* System.String AppleAuth.Interfaces.IPersonName::get_NameSuffix() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_36);
		NullCheck(L_35);
		List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE(L_35, L_37, /*hidden argument*/List_1_Add_m627ED3F7C50096BB8934F778CB980E79483BD2AE_RuntimeMethod_var);
	}

IL_0096:
	{
		// return string.Join(" ", orderedParts.ToArray());
		List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * L_38 = V_1;
		NullCheck(L_38);
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_39;
		L_39 = List_1_ToArray_m94163AE84EBF9A1F7483014A8E9906BD93D9EBDB(L_38, /*hidden argument*/List_1_ToArray_m94163AE84EBF9A1F7483014A8E9906BD93D9EBDB_RuntimeMethod_var);
		String_t* L_40;
		L_40 = String_Join_m8846EB11F0A221BDE237DE041D17764B36065404(_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, L_39, /*hidden argument*/NULL);
		return L_40;
	}
}
// System.String AppleAuth.Extensions.PersonNameExtensions::JsonStringForPersonName(AppleAuth.Interfaces.IPersonName)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PersonNameExtensions_JsonStringForPersonName_m009CD92B73A00F4AD0CB6B74000039C2D1F49290 (RuntimeObject* ___personName0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringBuilder_t_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0C3C6829C3CCF8020C6AC45B87963ADC095CD44A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral19ACA45079EF05169E31F35925318831A3818A1E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1F4A0E039A8EDC945B386FCBD017946A90DD1482);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2B40CC33334E727913DBC178F885E03EE82101DB);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4AAD7578E022578EB4E96D24CE1D90283FF0579B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4D8D9C94AC5DA5FCED2EC8A64E10E714A2515C30);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6B0F8C117113DCAEA31A236AE8DD26B97E6CB442);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral83A3AA4026743A327B1E8CB980C4AF5DEFA1E953);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA0288CC1A5F3CF90F6C5630BC8E0B28DB90F2571);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA2375F7B48A283E93E609EE95A59C68710F2EFE8);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFB14AD5D529C63D6104FCC6253259F2F5B0E793D);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	String_t* V_1 = NULL;
	{
		// if (personName == null)
		RuntimeObject* L_0 = ___personName0;
		if (L_0)
		{
			goto IL_0005;
		}
	}
	{
		// return null;
		return (String_t*)NULL;
	}

IL_0005:
	{
		// var stringBuilder = new System.Text.StringBuilder();
		StringBuilder_t * L_1 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m5A81DE19E748F748E19FF13FB6FFD2547F9212D9(L_1, /*hidden argument*/NULL);
		V_0 = L_1;
		// stringBuilder.Append("{");
		StringBuilder_t * L_2 = V_0;
		NullCheck(L_2);
		StringBuilder_t * L_3;
		L_3 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_2, _stringLiteral0C3C6829C3CCF8020C6AC45B87963ADC095CD44A, /*hidden argument*/NULL);
		// TryAddKeyValue(StringDictionaryFormat, "_namePrefix", personName.NamePrefix, stringBuilder);
		RuntimeObject* L_4 = ___personName0;
		NullCheck(L_4);
		String_t* L_5;
		L_5 = InterfaceFuncInvoker0< String_t* >::Invoke(0 /* System.String AppleAuth.Interfaces.IPersonName::get_NamePrefix() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_4);
		StringBuilder_t * L_6 = V_0;
		PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625(_stringLiteral19ACA45079EF05169E31F35925318831A3818A1E, _stringLiteralFB14AD5D529C63D6104FCC6253259F2F5B0E793D, L_5, L_6, /*hidden argument*/NULL);
		// TryAddKeyValue(StringDictionaryFormat, "_givenName", personName.GivenName, stringBuilder);
		RuntimeObject* L_7 = ___personName0;
		NullCheck(L_7);
		String_t* L_8;
		L_8 = InterfaceFuncInvoker0< String_t* >::Invoke(1 /* System.String AppleAuth.Interfaces.IPersonName::get_GivenName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_7);
		StringBuilder_t * L_9 = V_0;
		PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625(_stringLiteral19ACA45079EF05169E31F35925318831A3818A1E, _stringLiteralA0288CC1A5F3CF90F6C5630BC8E0B28DB90F2571, L_8, L_9, /*hidden argument*/NULL);
		// TryAddKeyValue(StringDictionaryFormat, "_middleName", personName.MiddleName, stringBuilder);
		RuntimeObject* L_10 = ___personName0;
		NullCheck(L_10);
		String_t* L_11;
		L_11 = InterfaceFuncInvoker0< String_t* >::Invoke(2 /* System.String AppleAuth.Interfaces.IPersonName::get_MiddleName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_10);
		StringBuilder_t * L_12 = V_0;
		PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625(_stringLiteral19ACA45079EF05169E31F35925318831A3818A1E, _stringLiteralA2375F7B48A283E93E609EE95A59C68710F2EFE8, L_11, L_12, /*hidden argument*/NULL);
		// TryAddKeyValue(StringDictionaryFormat, "_familyName", personName.FamilyName, stringBuilder);
		RuntimeObject* L_13 = ___personName0;
		NullCheck(L_13);
		String_t* L_14;
		L_14 = InterfaceFuncInvoker0< String_t* >::Invoke(3 /* System.String AppleAuth.Interfaces.IPersonName::get_FamilyName() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_13);
		StringBuilder_t * L_15 = V_0;
		PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625(_stringLiteral19ACA45079EF05169E31F35925318831A3818A1E, _stringLiteral2B40CC33334E727913DBC178F885E03EE82101DB, L_14, L_15, /*hidden argument*/NULL);
		// TryAddKeyValue(StringDictionaryFormat, "_nameSuffix", personName.NameSuffix, stringBuilder);
		RuntimeObject* L_16 = ___personName0;
		NullCheck(L_16);
		String_t* L_17;
		L_17 = InterfaceFuncInvoker0< String_t* >::Invoke(4 /* System.String AppleAuth.Interfaces.IPersonName::get_NameSuffix() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_16);
		StringBuilder_t * L_18 = V_0;
		PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625(_stringLiteral19ACA45079EF05169E31F35925318831A3818A1E, _stringLiteral1F4A0E039A8EDC945B386FCBD017946A90DD1482, L_17, L_18, /*hidden argument*/NULL);
		// TryAddKeyValue(StringDictionaryFormat, "_nickname", personName.Nickname, stringBuilder);
		RuntimeObject* L_19 = ___personName0;
		NullCheck(L_19);
		String_t* L_20;
		L_20 = InterfaceFuncInvoker0< String_t* >::Invoke(5 /* System.String AppleAuth.Interfaces.IPersonName::get_Nickname() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_19);
		StringBuilder_t * L_21 = V_0;
		PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625(_stringLiteral19ACA45079EF05169E31F35925318831A3818A1E, _stringLiteral4AAD7578E022578EB4E96D24CE1D90283FF0579B, L_20, L_21, /*hidden argument*/NULL);
		// var phoneticRepresentationJson = JsonStringForPersonName(personName.PhoneticRepresentation);
		RuntimeObject* L_22 = ___personName0;
		NullCheck(L_22);
		RuntimeObject* L_23;
		L_23 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(6 /* AppleAuth.Interfaces.IPersonName AppleAuth.Interfaces.IPersonName::get_PhoneticRepresentation() */, IPersonName_t415F64E429CA6D83F00588202F125711D3C9251E_il2cpp_TypeInfo_var, L_22);
		String_t* L_24;
		L_24 = PersonNameExtensions_JsonStringForPersonName_m009CD92B73A00F4AD0CB6B74000039C2D1F49290(L_23, /*hidden argument*/NULL);
		V_1 = L_24;
		// TryAddKeyValue(StringObjectFormat, "_phoneticRepresentation", phoneticRepresentationJson, stringBuilder);
		String_t* L_25 = V_1;
		StringBuilder_t * L_26 = V_0;
		PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625(_stringLiteral83A3AA4026743A327B1E8CB980C4AF5DEFA1E953, _stringLiteral6B0F8C117113DCAEA31A236AE8DD26B97E6CB442, L_25, L_26, /*hidden argument*/NULL);
		// stringBuilder.Append("}");
		StringBuilder_t * L_27 = V_0;
		NullCheck(L_27);
		StringBuilder_t * L_28;
		L_28 = StringBuilder_Append_mD02AB0C74C6F55E3E330818C77EC147E22096FB1(L_27, _stringLiteral4D8D9C94AC5DA5FCED2EC8A64E10E714A2515C30, /*hidden argument*/NULL);
		// return stringBuilder.ToString();
		StringBuilder_t * L_29 = V_0;
		NullCheck(L_29);
		String_t* L_30;
		L_30 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_29);
		return L_30;
	}
}
// System.Void AppleAuth.Extensions.PersonNameExtensions::TryAddKeyValue(System.String,System.String,System.String,System.Text.StringBuilder)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PersonNameExtensions_TryAddKeyValue_m2B20F4F935B9150BDF3C245ACBFD528879ED9625 (String_t* ___format0, String_t* ___key1, String_t* ___value2, StringBuilder_t * ___stringBuilder3, const RuntimeMethod* method)
{
	{
		// if (string.IsNullOrEmpty(value))
		String_t* L_0 = ___value2;
		bool L_1;
		L_1 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_0, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// stringBuilder.AppendFormat(format, key, value);
		StringBuilder_t * L_2 = ___stringBuilder3;
		String_t* L_3 = ___format0;
		String_t* L_4 = ___key1;
		String_t* L_5 = ___value2;
		NullCheck(L_2);
		StringBuilder_t * L_6;
		L_6 = StringBuilder_AppendFormat_m37B348187DD9186C2451ACCA3DBC4ABCD4632AD4(L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AppleAuth.Native.SerializationTools::FixSerializationForString(System.String&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SerializationTools_FixSerializationForString_mF16C98FBC1192F5A1B011E0F326B7CC6FDE3C6A2 (String_t** ___originalString0, const RuntimeMethod* method)
{
	{
		// if (string.IsNullOrEmpty(originalString))
		String_t** L_0 = ___originalString0;
		String_t* L_1 = *((String_t**)L_0);
		bool L_2;
		L_2 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_1, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_000c;
		}
	}
	{
		// originalString = null;
		String_t** L_3 = ___originalString0;
		*((RuntimeObject **)L_3) = (RuntimeObject *)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject **)L_3, (void*)(RuntimeObject *)NULL);
	}

IL_000c:
	{
		// }
		return;
	}
}
// System.Byte[] AppleAuth.Native.SerializationTools::GetBytesFromBase64String(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* SerializationTools_GetBytesFromBase64String_mC62CDA9500A1DB0D8401FB2F655D006BACE3CD2F (String_t* ___base64String0, String_t* ___fieldName1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* V_0 = NULL;
	Exception_t * V_1 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	Exception_t * G_B6_0 = NULL;
	String_t* G_B6_1 = NULL;
	Exception_t * G_B5_0 = NULL;
	String_t* G_B5_1 = NULL;
	String_t* G_B7_0 = NULL;
	String_t* G_B7_1 = NULL;
	{
		// if (base64String == null)
		String_t* L_0 = ___base64String0;
		if (L_0)
		{
			goto IL_0005;
		}
	}
	{
		// return null;
		return (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)NULL;
	}

IL_0005:
	{
		// var returnedBytes = default(byte[]);
		V_0 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)NULL;
	}

IL_0007:
	try
	{ // begin try (depth: 1)
		// returnedBytes = Convert.FromBase64String(base64String);
		String_t* L_1 = ___base64String0;
		IL2CPP_RUNTIME_CLASS_INIT(Convert_tDA947A979C1DAB4F09C461FAFD94FE194743A671_il2cpp_TypeInfo_var);
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_2;
		L_2 = Convert_FromBase64String_mB2E4E2CD03B34DB7C2665694D5B2E967BC81E9A8(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		// }
		goto IL_0041;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0010;
		}
		throw e;
	}

CATCH_0010:
	{ // begin catch(System.Exception)
		{
			// catch (Exception exception)
			V_1 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
			// Console.WriteLine("Received exception while deserializing byte array for " + fieldName);
			String_t* L_3 = ___fieldName1;
			String_t* L_4;
			L_4 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral66A865E28B2B5657FCF66691A6F7AC2B94FE50BA)), L_3, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Console_t79987B1B5914E76054A8CBE506B9E11936A8BC07_il2cpp_TypeInfo_var)));
			Console_WriteLine_mE9EEA95C541D41E36A0F4844153A67EAAA0D12F7(L_4, /*hidden argument*/NULL);
			// Console.WriteLine("Exception: " + exception);
			Exception_t * L_5 = V_1;
			Exception_t * L_6 = L_5;
			G_B5_0 = L_6;
			G_B5_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralA95898025CC11DF26437FBBC4B43CA5F697F5DB1));
			if (L_6)
			{
				G_B6_0 = L_6;
				G_B6_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralA95898025CC11DF26437FBBC4B43CA5F697F5DB1));
				goto IL_002e;
			}
		}

IL_002a:
		{
			G_B7_0 = ((String_t*)(NULL));
			G_B7_1 = G_B5_1;
			goto IL_0033;
		}

IL_002e:
		{
			NullCheck(G_B6_0);
			String_t* L_7;
			L_7 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B6_0);
			G_B7_0 = L_7;
			G_B7_1 = G_B6_1;
		}

IL_0033:
		{
			String_t* L_8;
			L_8 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(G_B7_1, G_B7_0, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Console_t79987B1B5914E76054A8CBE506B9E11936A8BC07_il2cpp_TypeInfo_var)));
			Console_WriteLine_mE9EEA95C541D41E36A0F4844153A67EAAA0D12F7(L_8, /*hidden argument*/NULL);
			// returnedBytes = null;
			V_0 = (ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726*)NULL;
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_0041;
		}
	} // end catch (depth: 1)

IL_0041:
	{
		// return returnedBytes;
		ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726* L_9 = V_0;
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
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass10_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass10_0__ctor_m9AF46F3648D1F310EAA6633345AE5B109BEE9D3B (U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass10_0::<GetCredentialState>b__0(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass10_0_U3CGetCredentialStateU3Eb__0_m86C591492D3EFBD62625107928D944A52044BA59 (U3CU3Ec__DisplayClass10_0_tBD710A22FF5EA9E23FEFF59B4DE9FE305F3D8F29 * __this, String_t* ___payload0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m962693B0F6FA0C65C36BFDC35E053E1125FA149A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ICredentialStateResponse_t2CC47394E1D3C5FEBF97A30D2A3E289C7071FDDE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPayloadDeserializer_t9239EDD58B766683711ABF2E9862582281F71D49_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	{
		// var response = this._payloadDeserializer.DeserializeCredentialStateResponse(payload);
		AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * L_0 = __this->get_U3CU3E4__this_0();
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->get__payloadDeserializer_0();
		String_t* L_2 = ___payload0;
		NullCheck(L_1);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker1< RuntimeObject*, String_t* >::Invoke(0 /* AppleAuth.Interfaces.ICredentialStateResponse AppleAuth.Interfaces.IPayloadDeserializer::DeserializeCredentialStateResponse(System.String) */, IPayloadDeserializer_t9239EDD58B766683711ABF2E9862582281F71D49_il2cpp_TypeInfo_var, L_1, L_2);
		V_0 = L_3;
		// if (response.Error != null)
		RuntimeObject* L_4 = V_0;
		NullCheck(L_4);
		RuntimeObject* L_5;
		L_5 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(2 /* AppleAuth.Interfaces.IAppleError AppleAuth.Interfaces.ICredentialStateResponse::get_Error() */, ICredentialStateResponse_t2CC47394E1D3C5FEBF97A30D2A3E289C7071FDDE_il2cpp_TypeInfo_var, L_4);
		if (!L_5)
		{
			goto IL_002c;
		}
	}
	{
		// errorCallback(response.Error);
		Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * L_6 = __this->get_errorCallback_1();
		RuntimeObject* L_7 = V_0;
		NullCheck(L_7);
		RuntimeObject* L_8;
		L_8 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(2 /* AppleAuth.Interfaces.IAppleError AppleAuth.Interfaces.ICredentialStateResponse::get_Error() */, ICredentialStateResponse_t2CC47394E1D3C5FEBF97A30D2A3E289C7071FDDE_il2cpp_TypeInfo_var, L_7);
		NullCheck(L_6);
		Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7(L_6, L_8, /*hidden argument*/Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7_RuntimeMethod_var);
		return;
	}

IL_002c:
	{
		// successCallback(response.CredentialState);
		Action_1_tF4E3983AC72DD1D0DAC6510689E80775A254E178 * L_9 = __this->get_successCallback_2();
		RuntimeObject* L_10 = V_0;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = InterfaceFuncInvoker0< int32_t >::Invoke(1 /* AppleAuth.Enums.CredentialState AppleAuth.Interfaces.ICredentialStateResponse::get_CredentialState() */, ICredentialStateResponse_t2CC47394E1D3C5FEBF97A30D2A3E289C7071FDDE_il2cpp_TypeInfo_var, L_10);
		NullCheck(L_9);
		Action_1_Invoke_m962693B0F6FA0C65C36BFDC35E053E1125FA149A(L_9, L_11, /*hidden argument*/Action_1_Invoke_m962693B0F6FA0C65C36BFDC35E053E1125FA149A_RuntimeMethod_var);
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
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass7_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0__ctor_m81604CDFA2714F09B02C08FD6AD332AA22203154 (U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass7_0::<QuickLogin>b__0(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass7_0_U3CQuickLoginU3Eb__0_m0163857449472462097FE98E94EE2C764791D43B (U3CU3Ec__DisplayClass7_0_t2C8F3E948619C7E256E09ECE9D367D979189DBDB * __this, String_t* ___payload0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPayloadDeserializer_t9239EDD58B766683711ABF2E9862582281F71D49_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	{
		// var response = this._payloadDeserializer.DeserializeLoginWithAppleIdResponse(payload);
		AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * L_0 = __this->get_U3CU3E4__this_0();
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->get__payloadDeserializer_0();
		String_t* L_2 = ___payload0;
		NullCheck(L_1);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker1< RuntimeObject*, String_t* >::Invoke(1 /* AppleAuth.Interfaces.ILoginWithAppleIdResponse AppleAuth.Interfaces.IPayloadDeserializer::DeserializeLoginWithAppleIdResponse(System.String) */, IPayloadDeserializer_t9239EDD58B766683711ABF2E9862582281F71D49_il2cpp_TypeInfo_var, L_1, L_2);
		V_0 = L_3;
		// if (response.Error != null)
		RuntimeObject* L_4 = V_0;
		NullCheck(L_4);
		RuntimeObject* L_5;
		L_5 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(1 /* AppleAuth.Interfaces.IAppleError AppleAuth.Interfaces.ILoginWithAppleIdResponse::get_Error() */, ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var, L_4);
		if (!L_5)
		{
			goto IL_002c;
		}
	}
	{
		// errorCallback(response.Error);
		Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * L_6 = __this->get_errorCallback_1();
		RuntimeObject* L_7 = V_0;
		NullCheck(L_7);
		RuntimeObject* L_8;
		L_8 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(1 /* AppleAuth.Interfaces.IAppleError AppleAuth.Interfaces.ILoginWithAppleIdResponse::get_Error() */, ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var, L_7);
		NullCheck(L_6);
		Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7(L_6, L_8, /*hidden argument*/Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7_RuntimeMethod_var);
		return;
	}

IL_002c:
	{
		// else if (response.PasswordCredential != null)
		RuntimeObject* L_9 = V_0;
		NullCheck(L_9);
		RuntimeObject* L_10;
		L_10 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(3 /* AppleAuth.Interfaces.IPasswordCredential AppleAuth.Interfaces.ILoginWithAppleIdResponse::get_PasswordCredential() */, ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var, L_9);
		if (!L_10)
		{
			goto IL_0046;
		}
	}
	{
		// successCallback(response.PasswordCredential);
		Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * L_11 = __this->get_successCallback_2();
		RuntimeObject* L_12 = V_0;
		NullCheck(L_12);
		RuntimeObject* L_13;
		L_13 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(3 /* AppleAuth.Interfaces.IPasswordCredential AppleAuth.Interfaces.ILoginWithAppleIdResponse::get_PasswordCredential() */, ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var, L_12);
		NullCheck(L_11);
		Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357(L_11, L_13, /*hidden argument*/Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357_RuntimeMethod_var);
		return;
	}

IL_0046:
	{
		// successCallback(response.AppleIDCredential);
		Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * L_14 = __this->get_successCallback_2();
		RuntimeObject* L_15 = V_0;
		NullCheck(L_15);
		RuntimeObject* L_16;
		L_16 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(2 /* AppleAuth.Interfaces.IAppleIDCredential AppleAuth.Interfaces.ILoginWithAppleIdResponse::get_AppleIDCredential() */, ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var, L_15);
		NullCheck(L_14);
		Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357(L_14, L_16, /*hidden argument*/Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357_RuntimeMethod_var);
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
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass9_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass9_0__ctor_m04AF0C6AC86E75FB90C3AF0775EF4661DDCC8AAC (U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/<>c__DisplayClass9_0::<LoginWithAppleId>b__0(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass9_0_U3CLoginWithAppleIdU3Eb__0_mA62EB5BB7611FA73AFDB2697C47D792A7122E3EF (U3CU3Ec__DisplayClass9_0_t42795919AE31548BF9CEE8D40D958585CDBF2817 * __this, String_t* ___payload0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IPayloadDeserializer_t9239EDD58B766683711ABF2E9862582281F71D49_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	{
		// var response = this._payloadDeserializer.DeserializeLoginWithAppleIdResponse(payload);
		AppleAuthManager_t37260D6B2591162187A8CD664740F73A58B50C48 * L_0 = __this->get_U3CU3E4__this_0();
		NullCheck(L_0);
		RuntimeObject* L_1 = L_0->get__payloadDeserializer_0();
		String_t* L_2 = ___payload0;
		NullCheck(L_1);
		RuntimeObject* L_3;
		L_3 = InterfaceFuncInvoker1< RuntimeObject*, String_t* >::Invoke(1 /* AppleAuth.Interfaces.ILoginWithAppleIdResponse AppleAuth.Interfaces.IPayloadDeserializer::DeserializeLoginWithAppleIdResponse(System.String) */, IPayloadDeserializer_t9239EDD58B766683711ABF2E9862582281F71D49_il2cpp_TypeInfo_var, L_1, L_2);
		V_0 = L_3;
		// if (response.Error != null)
		RuntimeObject* L_4 = V_0;
		NullCheck(L_4);
		RuntimeObject* L_5;
		L_5 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(1 /* AppleAuth.Interfaces.IAppleError AppleAuth.Interfaces.ILoginWithAppleIdResponse::get_Error() */, ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var, L_4);
		if (!L_5)
		{
			goto IL_002c;
		}
	}
	{
		// errorCallback(response.Error);
		Action_1_t606C72DCC04AF289F9A814871ED55B87EF37A52F * L_6 = __this->get_errorCallback_1();
		RuntimeObject* L_7 = V_0;
		NullCheck(L_7);
		RuntimeObject* L_8;
		L_8 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(1 /* AppleAuth.Interfaces.IAppleError AppleAuth.Interfaces.ILoginWithAppleIdResponse::get_Error() */, ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var, L_7);
		NullCheck(L_6);
		Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7(L_6, L_8, /*hidden argument*/Action_1_Invoke_mC751BF64FB654C19B3A3D7EA406BE6AA7F9B5DD7_RuntimeMethod_var);
		return;
	}

IL_002c:
	{
		// successCallback(response.AppleIDCredential);
		Action_1_t348A28FBF846AED62F05CF204456E80D591E54AA * L_9 = __this->get_successCallback_2();
		RuntimeObject* L_10 = V_0;
		NullCheck(L_10);
		RuntimeObject* L_11;
		L_11 = InterfaceFuncInvoker0< RuntimeObject* >::Invoke(2 /* AppleAuth.Interfaces.IAppleIDCredential AppleAuth.Interfaces.ILoginWithAppleIdResponse::get_AppleIDCredential() */, ILoginWithAppleIdResponse_t71A2923F2436856ED426DF639CFB4EB69A2BFE9C_il2cpp_TypeInfo_var, L_10);
		NullCheck(L_9);
		Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357(L_9, L_11, /*hidden argument*/Action_1_Invoke_mEC4B87DB249214A006217DD3C146A5C0464BE357_RuntimeMethod_var);
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
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::add__nativeCredentialsRevoked(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_add__nativeCredentialsRevoked_m5914C8893508EE656C3324572E537E962E76F91E (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * V_0 = NULL;
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * V_1 = NULL;
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * V_2 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_0 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__nativeCredentialsRevoked_8();
		V_0 = L_0;
	}

IL_0006:
	{
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_1 = V_0;
		V_1 = L_1;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_2 = V_1;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_3 = ___value0;
		Delegate_t * L_4;
		L_4 = Delegate_Combine_m631D10D6CFF81AB4F237B9D549B235A54F45FA55(L_2, L_3, /*hidden argument*/NULL);
		V_2 = ((Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)CastclassSealed((RuntimeObject*)L_4, Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var));
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_5 = V_2;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_6 = V_1;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_7;
		L_7 = InterlockedCompareExchangeImpl<Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *>((Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 **)(((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_address_of__nativeCredentialsRevoked_8()), L_5, L_6);
		V_0 = L_7;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_8 = V_0;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_9 = V_1;
		if ((!(((RuntimeObject*)(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)L_8) == ((RuntimeObject*)(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)L_9))))
		{
			goto IL_0006;
		}
	}
	{
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::remove__nativeCredentialsRevoked(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_remove__nativeCredentialsRevoked_mBD5A18068932A435B639C8335FF850802373F27C (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * V_0 = NULL;
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * V_1 = NULL;
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * V_2 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_0 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__nativeCredentialsRevoked_8();
		V_0 = L_0;
	}

IL_0006:
	{
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_1 = V_0;
		V_1 = L_1;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_2 = V_1;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_3 = ___value0;
		Delegate_t * L_4;
		L_4 = Delegate_Remove_m8B4AD17254118B2904720D55C9B34FB3DCCBD7D4(L_2, L_3, /*hidden argument*/NULL);
		V_2 = ((Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)CastclassSealed((RuntimeObject*)L_4, Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var));
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_5 = V_2;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_6 = V_1;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_7;
		L_7 = InterlockedCompareExchangeImpl<Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *>((Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 **)(((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_address_of__nativeCredentialsRevoked_8()), L_5, L_6);
		V_0 = L_7;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_8 = V_0;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_9 = V_1;
		if ((!(((RuntimeObject*)(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)L_8) == ((RuntimeObject*)(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)L_9))))
		{
			goto IL_0006;
		}
	}
	{
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::add_NativeCredentialsRevoked(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_add_NativeCredentialsRevoked_m9A6E540FAEA285B407694C30EF23F8A949837F09 (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_U3Cadd_NativeCredentialsRevokedU3Eb__12_0_m7A6F70094F70AAC04CD30A3BC7BD49E2E3CADB78_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	bool V_1 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * G_B4_0 = NULL;
	int32_t G_B4_1 = 0;
	Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * G_B3_0 = NULL;
	int32_t G_B3_1 = 0;
	{
		// lock (SyncLock)
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		RuntimeObject * L_0 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_SyncLock_2();
		V_0 = L_0;
		V_1 = (bool)0;
	}

IL_0008:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_1 = V_0;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4(L_1, (bool*)(&V_1), /*hidden argument*/NULL);
			// if (_nativeCredentialsRevoked == null)
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_2 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__nativeCredentialsRevoked_8();
			if (L_2)
			{
				goto IL_004b;
			}
		}

IL_0017:
		{
			// _credentialsRevokedCallbackId = AddMessageCallback(false, payload => _nativeCredentialsRevoked.Invoke(payload));
			IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var);
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_3 = ((U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var))->get_U3CU3E9__12_0_1();
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_4 = L_3;
			G_B3_0 = L_4;
			G_B3_1 = 0;
			if (L_4)
			{
				G_B4_0 = L_4;
				G_B4_1 = 0;
				goto IL_0037;
			}
		}

IL_0020:
		{
			IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var);
			U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 * L_5 = ((U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var))->get_U3CU3E9_0();
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_6 = (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)il2cpp_codegen_object_new(Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3_il2cpp_TypeInfo_var);
			Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161(L_6, L_5, (intptr_t)((intptr_t)U3CU3Ec_U3Cadd_NativeCredentialsRevokedU3Eb__12_0_m7A6F70094F70AAC04CD30A3BC7BD49E2E3CADB78_RuntimeMethod_var), /*hidden argument*/Action_1__ctor_m090CD607C7652B994D986F12CB18450A24FD8161_RuntimeMethod_var);
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_7 = L_6;
			((U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var))->set_U3CU3E9__12_0_1(L_7);
			G_B4_0 = L_7;
			G_B4_1 = G_B3_1;
		}

IL_0037:
		{
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			uint32_t L_8;
			L_8 = CallbackHandler_AddMessageCallback_m7B194DE6CC041640E88BDB3111D732D7BE355E92((bool)G_B4_1, G_B4_0, /*hidden argument*/NULL);
			((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__credentialsRevokedCallbackId_7(L_8);
			// PInvoke.AppleAuth_RegisterCredentialsRevokedCallbackId(_credentialsRevokedCallbackId);
			uint32_t L_9 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__credentialsRevokedCallbackId_7();
			PInvoke_AppleAuth_RegisterCredentialsRevokedCallbackId_m7832911757EA10685C78C60F28ECB9783A53D787(L_9, /*hidden argument*/NULL);
		}

IL_004b:
		{
			// _nativeCredentialsRevoked += value;
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_10 = ___value0;
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			CallbackHandler_add__nativeCredentialsRevoked_m5914C8893508EE656C3324572E537E962E76F91E(L_10, /*hidden argument*/NULL);
			// }
			IL2CPP_LEAVE(0x5D, FINALLY_0053);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0053;
	}

FINALLY_0053:
	{ // begin finally (depth: 1)
		{
			bool L_11 = V_1;
			if (!L_11)
			{
				goto IL_005c;
			}
		}

IL_0056:
		{
			RuntimeObject * L_12 = V_0;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A(L_12, /*hidden argument*/NULL);
		}

IL_005c:
		{
			IL2CPP_END_FINALLY(83)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(83)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x5D, IL_005d)
	}

IL_005d:
	{
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::remove_NativeCredentialsRevoked(System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_remove_NativeCredentialsRevoked_mAB87C721DDE673ADD5DF4F1FB03005DB78060A14 (Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	bool V_1 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// lock (SyncLock)
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		RuntimeObject * L_0 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_SyncLock_2();
		V_0 = L_0;
		V_1 = (bool)0;
	}

IL_0008:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_1 = V_0;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4(L_1, (bool*)(&V_1), /*hidden argument*/NULL);
			// _nativeCredentialsRevoked -= value;
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_2 = ___value0;
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			CallbackHandler_remove__nativeCredentialsRevoked_mBD5A18068932A435B639C8335FF850802373F27C(L_2, /*hidden argument*/NULL);
			// if (_nativeCredentialsRevoked == null)
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_3 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__nativeCredentialsRevoked_8();
			if (L_3)
			{
				goto IL_0033;
			}
		}

IL_001d:
		{
			// RemoveMessageCallback(_credentialsRevokedCallbackId);
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			uint32_t L_4 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__credentialsRevokedCallbackId_7();
			CallbackHandler_RemoveMessageCallback_m21605F49CE514727FB7861F0ED428D341E2FD4D2(L_4, /*hidden argument*/NULL);
			// _credentialsRevokedCallbackId = 0U;
			((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__credentialsRevokedCallbackId_7(0);
			// PInvoke.AppleAuth_RegisterCredentialsRevokedCallbackId(0U);
			PInvoke_AppleAuth_RegisterCredentialsRevokedCallbackId_m7832911757EA10685C78C60F28ECB9783A53D787(0, /*hidden argument*/NULL);
		}

IL_0033:
		{
			// }
			IL2CPP_LEAVE(0x3F, FINALLY_0035);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0035;
	}

FINALLY_0035:
	{ // begin finally (depth: 1)
		{
			bool L_5 = V_1;
			if (!L_5)
			{
				goto IL_003e;
			}
		}

IL_0038:
		{
			RuntimeObject * L_6 = V_0;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A(L_6, /*hidden argument*/NULL);
		}

IL_003e:
		{
			IL2CPP_END_FINALLY(53)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(53)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x3F, IL_003f)
	}

IL_003f:
	{
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::ScheduleCallback(System.UInt32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_ScheduleCallback_mCE6ED1A1BCEAD5F333C202E0B91E72407654E8F6 (uint32_t ___requestId0, String_t* ___payload1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Remove_m31296A3D9862AFFD78839933103BFA7B99CCCBE7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_m821D7367424A9A61214C4CA1B2B608708636F93E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m7701B455B6EA0411642596847118B51F91DA8BC9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass14_0_U3CScheduleCallbackU3Eb__0_m675187383F28AA97201E57D51CF47571A67846ED_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C * V_0 = NULL;
	RuntimeObject * V_1 = NULL;
	bool V_2 = false;
	Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * V_3 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C * L_0 = (U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass14_0__ctor_m34864F02146811916F09E681C2C43F35191EA19A(L_0, /*hidden argument*/NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C * L_1 = V_0;
		String_t* L_2 = ___payload1;
		NullCheck(L_1);
		L_1->set_payload_0(L_2);
		// lock (SyncLock)
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		RuntimeObject * L_3 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_SyncLock_2();
		V_1 = L_3;
		V_2 = (bool)0;
	}

IL_0015:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_4 = V_1;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4(L_4, (bool*)(&V_2), /*hidden argument*/NULL);
			// var callbackEntry = default(Entry);
			V_3 = (Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 *)NULL;
			// if (CallbackDictionary.TryGetValue(requestId, out callbackEntry))
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * L_5 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_CallbackDictionary_3();
			uint32_t L_6 = ___requestId0;
			NullCheck(L_5);
			bool L_7;
			L_7 = Dictionary_2_TryGetValue_m821D7367424A9A61214C4CA1B2B608708636F93E(L_5, L_6, (Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 **)(&V_3), /*hidden argument*/Dictionary_2_TryGetValue_m821D7367424A9A61214C4CA1B2B608708636F93E_RuntimeMethod_var);
			if (!L_7)
			{
				goto IL_0064;
			}
		}

IL_002e:
		{
			// var callback = callbackEntry.MessageCallback;
			U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C * L_8 = V_0;
			Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * L_9 = V_3;
			NullCheck(L_9);
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_10 = L_9->get_MessageCallback_1();
			NullCheck(L_8);
			L_8->set_callback_1(L_10);
			// ScheduledActions.Add(() => callback.Invoke(payload));
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * L_11 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_ScheduledActions_4();
			U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C * L_12 = V_0;
			Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_13 = (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 *)il2cpp_codegen_object_new(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6_il2cpp_TypeInfo_var);
			Action__ctor_m07BE5EE8A629FBBA52AE6356D57A0D371BE2574B(L_13, L_12, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass14_0_U3CScheduleCallbackU3Eb__0_m675187383F28AA97201E57D51CF47571A67846ED_RuntimeMethod_var), /*hidden argument*/NULL);
			NullCheck(L_11);
			List_1_Add_m7701B455B6EA0411642596847118B51F91DA8BC9(L_11, L_13, /*hidden argument*/List_1_Add_m7701B455B6EA0411642596847118B51F91DA8BC9_RuntimeMethod_var);
			// if (callbackEntry.IsSingleUseCallback)
			Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * L_14 = V_3;
			NullCheck(L_14);
			bool L_15 = L_14->get_IsSingleUseCallback_0();
			if (!L_15)
			{
				goto IL_0064;
			}
		}

IL_0058:
		{
			// CallbackDictionary.Remove(requestId);
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * L_16 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_CallbackDictionary_3();
			uint32_t L_17 = ___requestId0;
			NullCheck(L_16);
			bool L_18;
			L_18 = Dictionary_2_Remove_m31296A3D9862AFFD78839933103BFA7B99CCCBE7(L_16, L_17, /*hidden argument*/Dictionary_2_Remove_m31296A3D9862AFFD78839933103BFA7B99CCCBE7_RuntimeMethod_var);
		}

IL_0064:
		{
			// }
			IL2CPP_LEAVE(0x70, FINALLY_0066);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0066;
	}

FINALLY_0066:
	{ // begin finally (depth: 1)
		{
			bool L_19 = V_2;
			if (!L_19)
			{
				goto IL_006f;
			}
		}

IL_0069:
		{
			RuntimeObject * L_20 = V_1;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A(L_20, /*hidden argument*/NULL);
		}

IL_006f:
		{
			IL2CPP_END_FINALLY(102)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(102)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x70, IL_0070)
	}

IL_0070:
	{
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::ExecutePendingCallbacks()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_ExecutePendingCallbacks_m8FDE99CABAE4E3E08A7D8590D863CB550A3AC24B (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_RemoveAt_mD4CD85C9E5FDA40D3274952962B580A0BA3349FD_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m62C12145DD437794F8660D2396A00A7B2BA480C5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m9F0A626A47DAE7452E139A6961335BE81507E551_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	bool V_1 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// lock (SyncLock)
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		RuntimeObject * L_0 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_SyncLock_2();
		V_0 = L_0;
		V_1 = (bool)0;
	}

IL_0008:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_1 = V_0;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4(L_1, (bool*)(&V_1), /*hidden argument*/NULL);
			goto IL_002d;
		}

IL_0012:
		{
			// var action = ScheduledActions[0];
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * L_2 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_ScheduledActions_4();
			NullCheck(L_2);
			Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_3;
			L_3 = List_1_get_Item_m9F0A626A47DAE7452E139A6961335BE81507E551_inline(L_2, 0, /*hidden argument*/List_1_get_Item_m9F0A626A47DAE7452E139A6961335BE81507E551_RuntimeMethod_var);
			// ScheduledActions.RemoveAt(0);
			List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * L_4 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_ScheduledActions_4();
			NullCheck(L_4);
			List_1_RemoveAt_mD4CD85C9E5FDA40D3274952962B580A0BA3349FD(L_4, 0, /*hidden argument*/List_1_RemoveAt_mD4CD85C9E5FDA40D3274952962B580A0BA3349FD_RuntimeMethod_var);
			// action.Invoke();
			NullCheck(L_3);
			Action_Invoke_m3FFA5BE3D64F0FF8E1E1CB6F953913FADB5EB89E(L_3, /*hidden argument*/NULL);
		}

IL_002d:
		{
			// while (ScheduledActions.Count > 0)
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * L_5 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_ScheduledActions_4();
			NullCheck(L_5);
			int32_t L_6;
			L_6 = List_1_get_Count_m62C12145DD437794F8660D2396A00A7B2BA480C5_inline(L_5, /*hidden argument*/List_1_get_Count_m62C12145DD437794F8660D2396A00A7B2BA480C5_RuntimeMethod_var);
			if ((((int32_t)L_6) > ((int32_t)0)))
			{
				goto IL_0012;
			}
		}

IL_003a:
		{
			// }
			IL2CPP_LEAVE(0x46, FINALLY_003c);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_003c;
	}

FINALLY_003c:
	{ // begin finally (depth: 1)
		{
			bool L_7 = V_1;
			if (!L_7)
			{
				goto IL_0045;
			}
		}

IL_003f:
		{
			RuntimeObject * L_8 = V_0;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A(L_8, /*hidden argument*/NULL);
		}

IL_0045:
		{
			IL2CPP_END_FINALLY(60)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(60)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x46, IL_0046)
	}

IL_0046:
	{
		// }
		return;
	}
}
// System.UInt32 AppleAuth.AppleAuthManager/CallbackHandler::AddMessageCallback(System.Boolean,System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t CallbackHandler_AddMessageCallback_m7B194DE6CC041640E88BDB3111D732D7BE355E92 (bool ___isSingleUse0, Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___messageCallback1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Add_mEF7ADA2611CF6AE754C1D3B6109D3C4A81D20A95_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PInvoke_NativeMessageHandlerCallback_mBA8562A025E9B934C3F7F672E02E08EF2033E8B3_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	uint32_t V_0 = 0;
	RuntimeObject * V_1 = NULL;
	bool V_2 = false;
	Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * V_3 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// if (!_initialized)
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		bool L_0 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__initialized_6();
		if (L_0)
		{
			goto IL_001e;
		}
	}
	{
		// PInvoke.AppleAuth_SetupNativeMessageHandlerCallback(PInvoke.NativeMessageHandlerCallback);
		NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * L_1 = (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA *)il2cpp_codegen_object_new(NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA_il2cpp_TypeInfo_var);
		NativeMessageHandlerCallbackDelegate__ctor_m7ECBD3BE4EF8F1109AED37D1FCB02BF6648DFC5E(L_1, NULL, (intptr_t)((intptr_t)PInvoke_NativeMessageHandlerCallback_mBA8562A025E9B934C3F7F672E02E08EF2033E8B3_RuntimeMethod_var), /*hidden argument*/NULL);
		PInvoke_AppleAuth_SetupNativeMessageHandlerCallback_m159E00729893F68C30D03CD151E4737C67B0E8BA(L_1, /*hidden argument*/NULL);
		// _initialized = true;
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__initialized_6((bool)1);
	}

IL_001e:
	{
		// if (messageCallback == null)
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_2 = ___messageCallback1;
		if (L_2)
		{
			goto IL_002c;
		}
	}
	{
		// throw new Exception("Can't add a null Message Callback.");
		Exception_t * L_3 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
		Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral9788FC9C452EE9A7B91598A36199A2CDE3698A4C)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&CallbackHandler_AddMessageCallback_m7B194DE6CC041640E88BDB3111D732D7BE355E92_RuntimeMethod_var)));
	}

IL_002c:
	{
		// var usedCallbackId = default(uint);
		V_0 = 0;
		// lock (SyncLock)
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		RuntimeObject * L_4 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_SyncLock_2();
		V_1 = L_4;
		V_2 = (bool)0;
	}

IL_0036:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_5 = V_1;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4(L_5, (bool*)(&V_2), /*hidden argument*/NULL);
			// usedCallbackId = _callbackId;
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			uint32_t L_6 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__callbackId_5();
			V_0 = L_6;
			// _callbackId += 1;
			uint32_t L_7 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__callbackId_5();
			((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__callbackId_5(((int32_t)il2cpp_codegen_add((int32_t)L_7, (int32_t)1)));
			// if (_callbackId >= MaxCallbackId)
			uint32_t L_8 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__callbackId_5();
			if ((!(((uint32_t)L_8) >= ((uint32_t)(-1)))))
			{
				goto IL_005e;
			}
		}

IL_0058:
		{
			// _callbackId = InitialCallbackId;
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__callbackId_5(1);
		}

IL_005e:
		{
			// var callbackEntry = new Entry(isSingleUse, messageCallback);
			bool L_9 = ___isSingleUse0;
			Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_10 = ___messageCallback1;
			Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * L_11 = (Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 *)il2cpp_codegen_object_new(Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417_il2cpp_TypeInfo_var);
			Entry__ctor_m10C87A89CC51BC3AAB8683768ACF168B78FBCA64(L_11, L_9, L_10, /*hidden argument*/NULL);
			V_3 = L_11;
			// CallbackDictionary.Add(usedCallbackId, callbackEntry);
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * L_12 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_CallbackDictionary_3();
			uint32_t L_13 = V_0;
			Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * L_14 = V_3;
			NullCheck(L_12);
			Dictionary_2_Add_mEF7ADA2611CF6AE754C1D3B6109D3C4A81D20A95(L_12, L_13, L_14, /*hidden argument*/Dictionary_2_Add_mEF7ADA2611CF6AE754C1D3B6109D3C4A81D20A95_RuntimeMethod_var);
			// }
			IL2CPP_LEAVE(0x7E, FINALLY_0074);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0074;
	}

FINALLY_0074:
	{ // begin finally (depth: 1)
		{
			bool L_15 = V_2;
			if (!L_15)
			{
				goto IL_007d;
			}
		}

IL_0077:
		{
			RuntimeObject * L_16 = V_1;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A(L_16, /*hidden argument*/NULL);
		}

IL_007d:
		{
			IL2CPP_END_FINALLY(116)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(116)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x7E, IL_007e)
	}

IL_007e:
	{
		// return usedCallbackId;
		uint32_t L_17 = V_0;
		return L_17;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::RemoveMessageCallback(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler_RemoveMessageCallback_m21605F49CE514727FB7861F0ED428D341E2FD4D2 (uint32_t ___requestId0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_m782EBE8C977F074B6717FB7C1A23B70904B6AF69_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_Remove_m31296A3D9862AFFD78839933103BFA7B99CCCBE7_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	bool V_1 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
		// lock (SyncLock)
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		RuntimeObject * L_0 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_SyncLock_2();
		V_0 = L_0;
		V_1 = (bool)0;
	}

IL_0008:
	try
	{ // begin try (depth: 1)
		{
			RuntimeObject * L_1 = V_0;
			Monitor_Enter_mBEB6CC84184B46F26375EC3FC8921D16E48EA4C4(L_1, (bool*)(&V_1), /*hidden argument*/NULL);
			// if (!CallbackDictionary.ContainsKey(requestId))
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * L_2 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_CallbackDictionary_3();
			uint32_t L_3 = ___requestId0;
			NullCheck(L_2);
			bool L_4;
			L_4 = Dictionary_2_ContainsKey_m782EBE8C977F074B6717FB7C1A23B70904B6AF69(L_2, L_3, /*hidden argument*/Dictionary_2_ContainsKey_m782EBE8C977F074B6717FB7C1A23B70904B6AF69_RuntimeMethod_var);
			if (L_4)
			{
				goto IL_0039;
			}
		}

IL_001d:
		{
			// throw new Exception("Callback with id " + requestId + " does not exist and can't be removed");
			String_t* L_5;
			L_5 = UInt32_ToString_mEB55F257429D34ED2BF41AE9567096F1F969B9A0((uint32_t*)(&___requestId0), /*hidden argument*/NULL);
			String_t* L_6;
			L_6 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral39E5FB85EEC80F6ADEB66C4385F2A26D2A4971F6)), L_5, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralC4C24815B709651078475AD9B46BEF647015D240)), /*hidden argument*/NULL);
			Exception_t * L_7 = (Exception_t *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
			Exception__ctor_m8ECDE8ACA7F2E0EF1144BD1200FB5DB2870B5F11(L_7, L_6, /*hidden argument*/NULL);
			IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&CallbackHandler_RemoveMessageCallback_m21605F49CE514727FB7861F0ED428D341E2FD4D2_RuntimeMethod_var)));
		}

IL_0039:
		{
			// CallbackDictionary.Remove(requestId);
			IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
			Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * L_8 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get_CallbackDictionary_3();
			uint32_t L_9 = ___requestId0;
			NullCheck(L_8);
			bool L_10;
			L_10 = Dictionary_2_Remove_m31296A3D9862AFFD78839933103BFA7B99CCCBE7(L_8, L_9, /*hidden argument*/Dictionary_2_Remove_m31296A3D9862AFFD78839933103BFA7B99CCCBE7_RuntimeMethod_var);
			// }
			IL2CPP_LEAVE(0x51, FINALLY_0047);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0047;
	}

FINALLY_0047:
	{ // begin finally (depth: 1)
		{
			bool L_11 = V_1;
			if (!L_11)
			{
				goto IL_0050;
			}
		}

IL_004a:
		{
			RuntimeObject * L_12 = V_0;
			Monitor_Exit_mA776B403DA88AC77CDEEF67AB9F0D0E77ABD254A(L_12, /*hidden argument*/NULL);
		}

IL_0050:
		{
			IL2CPP_END_FINALLY(71)
		}
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(71)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x51, IL_0051)
	}

IL_0051:
	{
		// }
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CallbackHandler__cctor_m7A1EC301E2505E5AA0DA758C8B70133F56301F7C (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_m1F3234CA822823DFC744DCE9DF739A4EDD0C8882_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m8F3A8E6C64C39DA66FF5F99E7A6BB97B41A482BB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t458734AF850139150AB40DFB2B5D1BCE23178235_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RuntimeObject_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private static readonly object SyncLock = new object();
		RuntimeObject * L_0 = (RuntimeObject *)il2cpp_codegen_object_new(RuntimeObject_il2cpp_TypeInfo_var);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(L_0, /*hidden argument*/NULL);
		((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set_SyncLock_2(L_0);
		// private static readonly System.Collections.Generic.Dictionary<uint, Entry> CallbackDictionary = new System.Collections.Generic.Dictionary<uint, Entry>();
		Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE * L_1 = (Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE *)il2cpp_codegen_object_new(Dictionary_2_tFC6585D4209F6371B8ED92EDD4AB6193EFED3CAE_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m1F3234CA822823DFC744DCE9DF739A4EDD0C8882(L_1, /*hidden argument*/Dictionary_2__ctor_m1F3234CA822823DFC744DCE9DF739A4EDD0C8882_RuntimeMethod_var);
		((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set_CallbackDictionary_3(L_1);
		// private static readonly System.Collections.Generic.List<Action> ScheduledActions = new System.Collections.Generic.List<Action>();
		List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 * L_2 = (List_1_t458734AF850139150AB40DFB2B5D1BCE23178235 *)il2cpp_codegen_object_new(List_1_t458734AF850139150AB40DFB2B5D1BCE23178235_il2cpp_TypeInfo_var);
		List_1__ctor_m8F3A8E6C64C39DA66FF5F99E7A6BB97B41A482BB(L_2, /*hidden argument*/List_1__ctor_m8F3A8E6C64C39DA66FF5F99E7A6BB97B41A482BB_RuntimeMethod_var);
		((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set_ScheduledActions_4(L_2);
		// private static uint _callbackId = InitialCallbackId;
		((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__callbackId_5(1);
		// private static bool _initialized = false;
		((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__initialized_6((bool)0);
		// private static uint _credentialsRevokedCallbackId = 0U;
		((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__credentialsRevokedCallbackId_7(0);
		// private static event Action<string> _nativeCredentialsRevoked = null;
		((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->set__nativeCredentialsRevoked_8((Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 *)NULL);
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
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PInvoke_NativeMessageHandlerCallback_mBA8562A025E9B934C3F7F672E02E08EF2033E8B3(uint32_t ___requestId0, char* ___payload1)
{
	il2cpp::vm::ScopedThreadAttacher _vmThreadHelper;

	// Marshaling of parameter '___payload1' to managed representation
	String_t* ____payload1_unmarshaled = NULL;
	____payload1_unmarshaled = il2cpp_codegen_marshal_string_result(___payload1);

	// Managed method invocation
	PInvoke_NativeMessageHandlerCallback_mBA8562A025E9B934C3F7F672E02E08EF2033E8B3(___requestId0, ____payload1_unmarshaled, NULL);

}
// System.Void AppleAuth.AppleAuthManager/PInvoke::NativeMessageHandlerCallback(System.UInt32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_NativeMessageHandlerCallback_mBA8562A025E9B934C3F7F672E02E08EF2033E8B3 (uint32_t ___requestId0, String_t* ___payload1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Exception_t * V_0 = NULL;
	il2cpp::utils::ExceptionSupportStack<RuntimeObject*, 1> __active_exceptions;
	il2cpp::utils::ExceptionSupportStack<int32_t, 2> __leave_targets;
	Exception_t * G_B3_0 = NULL;
	String_t* G_B3_1 = NULL;
	Exception_t * G_B2_0 = NULL;
	String_t* G_B2_1 = NULL;
	String_t* G_B4_0 = NULL;
	String_t* G_B4_1 = NULL;

IL_0000:
	try
	{ // begin try (depth: 1)
		// CallbackHandler.ScheduleCallback(requestId, payload);
		uint32_t L_0 = ___requestId0;
		String_t* L_1 = ___payload1;
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		CallbackHandler_ScheduleCallback_mCE6ED1A1BCEAD5F333C202E0B91E72407654E8F6(L_0, L_1, /*hidden argument*/NULL);
		// }
		goto IL_004e;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		if(il2cpp_codegen_class_is_assignable_from (((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)), il2cpp_codegen_object_class(e.ex)))
		{
			IL2CPP_PUSH_ACTIVE_EXCEPTION(e.ex);
			goto CATCH_0009;
		}
		throw e;
	}

CATCH_0009:
	{ // begin catch(System.Exception)
		{
			// catch (Exception exception)
			V_0 = ((Exception_t *)IL2CPP_GET_ACTIVE_EXCEPTION(Exception_t *));
			// Console.WriteLine("Received exception while scheduling a callback for request ID " + requestId);
			String_t* L_2;
			L_2 = UInt32_ToString_mEB55F257429D34ED2BF41AE9567096F1F969B9A0((uint32_t*)(&___requestId0), /*hidden argument*/NULL);
			String_t* L_3;
			L_3 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral323F125E5D7C69BA15AAB717EC66868024836092)), L_2, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Console_t79987B1B5914E76054A8CBE506B9E11936A8BC07_il2cpp_TypeInfo_var)));
			Console_WriteLine_mE9EEA95C541D41E36A0F4844153A67EAAA0D12F7(L_3, /*hidden argument*/NULL);
			// Console.WriteLine("Detailed payload:\n" + payload);
			String_t* L_4 = ___payload1;
			String_t* L_5;
			L_5 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral4D6C09A5E22530642E0E4DFEE6451C33F878ECAE)), L_4, /*hidden argument*/NULL);
			Console_WriteLine_mE9EEA95C541D41E36A0F4844153A67EAAA0D12F7(L_5, /*hidden argument*/NULL);
			// Console.WriteLine("Exception: " + exception);
			Exception_t * L_6 = V_0;
			Exception_t * L_7 = L_6;
			G_B2_0 = L_7;
			G_B2_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralA95898025CC11DF26437FBBC4B43CA5F697F5DB1));
			if (L_7)
			{
				G_B3_0 = L_7;
				G_B3_1 = ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralA95898025CC11DF26437FBBC4B43CA5F697F5DB1));
				goto IL_003d;
			}
		}

IL_0039:
		{
			G_B4_0 = ((String_t*)(NULL));
			G_B4_1 = G_B2_1;
			goto IL_0042;
		}

IL_003d:
		{
			NullCheck(G_B3_0);
			String_t* L_8;
			L_8 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B3_0);
			G_B4_0 = L_8;
			G_B4_1 = G_B3_1;
		}

IL_0042:
		{
			String_t* L_9;
			L_9 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(G_B4_1, G_B4_0, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Console_t79987B1B5914E76054A8CBE506B9E11936A8BC07_il2cpp_TypeInfo_var)));
			Console_WriteLine_mE9EEA95C541D41E36A0F4844153A67EAAA0D12F7(L_9, /*hidden argument*/NULL);
			// }
			IL2CPP_POP_ACTIVE_EXCEPTION();
			goto IL_004e;
		}
	} // end catch (depth: 1)

IL_004e:
	{
		// }
		return;
	}
}
// System.Boolean AppleAuth.AppleAuthManager/PInvoke::AppleAuth_IsCurrentPlatformSupported()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PInvoke_AppleAuth_IsCurrentPlatformSupported_m186998F906FC4A08604FA9D6B8B466C9AF823CC8 (const RuntimeMethod* method)
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) ();

	// Native function invocation
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(AppleAuth_IsCurrentPlatformSupported)();

	return static_cast<bool>(returnValue);
}
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_SetupNativeMessageHandlerCallback(AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_SetupNativeMessageHandlerCallback_m159E00729893F68C30D03CD151E4737C67B0E8BA (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * ___callback0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (Il2CppMethodPointer);

	// Marshaling of parameter '___callback0' to native representation
	Il2CppMethodPointer ____callback0_marshaled = NULL;
	____callback0_marshaled = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(___callback0));

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(AppleAuth_SetupNativeMessageHandlerCallback)(____callback0_marshaled);

}
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_GetCredentialState(System.UInt32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_GetCredentialState_mE2F5EDC4A49B99D61296CCC4A3C284667E7EC40D (uint32_t ___requestId0, String_t* ___userId1, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (uint32_t, char*);

	// Marshaling of parameter '___userId1' to native representation
	char* ____userId1_marshaled = NULL;
	____userId1_marshaled = il2cpp_codegen_marshal_string(___userId1);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(AppleAuth_GetCredentialState)(___requestId0, ____userId1_marshaled);

	// Marshaling cleanup of parameter '___userId1' native representation
	il2cpp_codegen_marshal_free(____userId1_marshaled);
	____userId1_marshaled = NULL;

}
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_LoginWithAppleId(System.UInt32,System.Int32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_LoginWithAppleId_m9A61219460D34AE8A008FAA16C756A30029EC7B8 (uint32_t ___requestId0, int32_t ___loginOptions1, String_t* ___nonceCStr2, String_t* ___stateCStr3, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (uint32_t, int32_t, char*, char*);

	// Marshaling of parameter '___nonceCStr2' to native representation
	char* ____nonceCStr2_marshaled = NULL;
	____nonceCStr2_marshaled = il2cpp_codegen_marshal_string(___nonceCStr2);

	// Marshaling of parameter '___stateCStr3' to native representation
	char* ____stateCStr3_marshaled = NULL;
	____stateCStr3_marshaled = il2cpp_codegen_marshal_string(___stateCStr3);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(AppleAuth_LoginWithAppleId)(___requestId0, ___loginOptions1, ____nonceCStr2_marshaled, ____stateCStr3_marshaled);

	// Marshaling cleanup of parameter '___nonceCStr2' native representation
	il2cpp_codegen_marshal_free(____nonceCStr2_marshaled);
	____nonceCStr2_marshaled = NULL;

	// Marshaling cleanup of parameter '___stateCStr3' native representation
	il2cpp_codegen_marshal_free(____stateCStr3_marshaled);
	____stateCStr3_marshaled = NULL;

}
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_QuickLogin(System.UInt32,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_QuickLogin_m2E1CE51129E8B07C976CC003233013D67AA9B985 (uint32_t ___requestId0, String_t* ___nonceCStr1, String_t* ___stateCStr2, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (uint32_t, char*, char*);

	// Marshaling of parameter '___nonceCStr1' to native representation
	char* ____nonceCStr1_marshaled = NULL;
	____nonceCStr1_marshaled = il2cpp_codegen_marshal_string(___nonceCStr1);

	// Marshaling of parameter '___stateCStr2' to native representation
	char* ____stateCStr2_marshaled = NULL;
	____stateCStr2_marshaled = il2cpp_codegen_marshal_string(___stateCStr2);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(AppleAuth_QuickLogin)(___requestId0, ____nonceCStr1_marshaled, ____stateCStr2_marshaled);

	// Marshaling cleanup of parameter '___nonceCStr1' native representation
	il2cpp_codegen_marshal_free(____nonceCStr1_marshaled);
	____nonceCStr1_marshaled = NULL;

	// Marshaling cleanup of parameter '___stateCStr2' native representation
	il2cpp_codegen_marshal_free(____stateCStr2_marshaled);
	____stateCStr2_marshaled = NULL;

}
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_RegisterCredentialsRevokedCallbackId(System.UInt32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_RegisterCredentialsRevokedCallbackId_m7832911757EA10685C78C60F28ECB9783A53D787 (uint32_t ___callbackId0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (uint32_t);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(AppleAuth_RegisterCredentialsRevokedCallbackId)(___callbackId0);

}
// System.Void AppleAuth.AppleAuthManager/PInvoke::AppleAuth_LogMessage(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PInvoke_AppleAuth_LogMessage_mAFE1CA4F989C68BDE97E602ACE4D1A7FC70243D9 (String_t* ___messageCStr0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc) (char*);

	// Marshaling of parameter '___messageCStr0' to native representation
	char* ____messageCStr0_marshaled = NULL;
	____messageCStr0_marshaled = il2cpp_codegen_marshal_string(___messageCStr0);

	// Native function invocation
	reinterpret_cast<PInvokeFunc>(AppleAuth_LogMessage)(____messageCStr0_marshaled);

	// Marshaling cleanup of parameter '___messageCStr0' native representation
	il2cpp_codegen_marshal_free(____messageCStr0_marshaled);
	____messageCStr0_marshaled = NULL;

}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String AppleAuth.Extensions.PersonNameExtensions/PInvoke::AppleAuth_GetPersonNameUsingFormatter(System.String,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* PInvoke_AppleAuth_GetPersonNameUsingFormatter_m3EB54DC8762902550797A25C7BB4E61FD63731E0 (String_t* ___payload0, int32_t ___style1, bool ___usePhoneticRepresentation2, const RuntimeMethod* method)
{
	typedef char* (DEFAULT_CALL *PInvokeFunc) (char*, int32_t, int32_t);

	// Marshaling of parameter '___payload0' to native representation
	char* ____payload0_marshaled = NULL;
	____payload0_marshaled = il2cpp_codegen_marshal_string(___payload0);

	// Native function invocation
	char* returnValue = reinterpret_cast<PInvokeFunc>(AppleAuth_GetPersonNameUsingFormatter)(____payload0_marshaled, ___style1, static_cast<int32_t>(___usePhoneticRepresentation2));

	// Marshaling of return value back from native representation
	String_t* _returnValue_unmarshaled = NULL;
	_returnValue_unmarshaled = il2cpp_codegen_marshal_string_result(returnValue);

	// Marshaling cleanup of return value native representation
	il2cpp_codegen_marshal_free(returnValue);
	returnValue = NULL;

	// Marshaling cleanup of parameter '___payload0' native representation
	il2cpp_codegen_marshal_free(____payload0_marshaled);
	____payload0_marshaled = NULL;

	return _returnValue_unmarshaled;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/<>c::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_m30BB0249BB178895EBF6464569FFDBCDB82C2485 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 * L_0 = (U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 *)il2cpp_codegen_object_new(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var);
		U3CU3Ec__ctor_m06B3B2000266EAE802DFB6601F159E2071659616(L_0, /*hidden argument*/NULL);
		((U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465_il2cpp_TypeInfo_var))->set_U3CU3E9_0(L_0);
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/<>c::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m06B3B2000266EAE802DFB6601F159E2071659616 (U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/<>c::<add_NativeCredentialsRevoked>b__12_0(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec_U3Cadd_NativeCredentialsRevokedU3Eb__12_0_m7A6F70094F70AAC04CD30A3BC7BD49E2E3CADB78 (U3CU3Ec_t1A0B32B021026480AD1DA93019B950315F6C6465 * __this, String_t* ___payload0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m6E81F94353B45920E7018D209DCF4B63DBE8D8B6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// _credentialsRevokedCallbackId = AddMessageCallback(false, payload => _nativeCredentialsRevoked.Invoke(payload));
		IL2CPP_RUNTIME_CLASS_INIT(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var);
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_0 = ((CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_StaticFields*)il2cpp_codegen_static_fields_for(CallbackHandler_t95D3073FD75C3AE2265158B15D24367D88D770FF_il2cpp_TypeInfo_var))->get__nativeCredentialsRevoked_8();
		String_t* L_1 = ___payload0;
		NullCheck(L_0);
		Action_1_Invoke_m6E81F94353B45920E7018D209DCF4B63DBE8D8B6(L_0, L_1, /*hidden argument*/Action_1_Invoke_m6E81F94353B45920E7018D209DCF4B63DBE8D8B6_RuntimeMethod_var);
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
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/<>c__DisplayClass14_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass14_0__ctor_m34864F02146811916F09E681C2C43F35191EA19A (U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/<>c__DisplayClass14_0::<ScheduleCallback>b__0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass14_0_U3CScheduleCallbackU3Eb__0_m675187383F28AA97201E57D51CF47571A67846ED (U3CU3Ec__DisplayClass14_0_t76B7A760FD63024CAA5F5C422124E2C15D33392C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_Invoke_m6E81F94353B45920E7018D209DCF4B63DBE8D8B6_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// ScheduledActions.Add(() => callback.Invoke(payload));
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_0 = __this->get_callback_1();
		String_t* L_1 = __this->get_payload_0();
		NullCheck(L_0);
		Action_1_Invoke_m6E81F94353B45920E7018D209DCF4B63DBE8D8B6(L_0, L_1, /*hidden argument*/Action_1_Invoke_m6E81F94353B45920E7018D209DCF4B63DBE8D8B6_RuntimeMethod_var);
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
// System.Void AppleAuth.AppleAuthManager/CallbackHandler/Entry::.ctor(System.Boolean,System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Entry__ctor_m10C87A89CC51BC3AAB8683768ACF168B78FBCA64 (Entry_t60B227824CCC9D3EBCFE0ACB178321C3339BE417 * __this, bool ___isSingleUseCallback0, Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * ___messageCallback1, const RuntimeMethod* method)
{
	{
		// public Entry(bool isSingleUseCallback, Action<string> messageCallback)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// this.IsSingleUseCallback = isSingleUseCallback;
		bool L_0 = ___isSingleUseCallback0;
		__this->set_IsSingleUseCallback_0(L_0);
		// this.MessageCallback = messageCallback;
		Action_1_tC0D73E03177C82525D78670CDC2165F7CBF0A9C3 * L_1 = ___messageCallback1;
		__this->set_MessageCallback_1(L_1);
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
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * __this, uint32_t ___requestId0, String_t* ___payload1, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(uint32_t, char*);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Marshaling of parameter '___payload1' to native representation
	char* ____payload1_marshaled = NULL;
	____payload1_marshaled = il2cpp_codegen_marshal_string(___payload1);

	// Native function invocation
	il2cppPInvokeFunc(___requestId0, ____payload1_marshaled);

	// Marshaling cleanup of parameter '___payload1' native representation
	il2cpp_codegen_marshal_free(____payload1_marshaled);
	____payload1_marshaled = NULL;

}
// System.Void AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativeMessageHandlerCallbackDelegate__ctor_m7ECBD3BE4EF8F1109AED37D1FCB02BF6648DFC5E (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate::Invoke(System.UInt32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativeMessageHandlerCallbackDelegate_Invoke_m4589FC97715BB3B5F918272F7B32FF0D5736F4FB (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * __this, uint32_t ___requestId0, String_t* ___payload1, const RuntimeMethod* method)
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
				typedef void (*FunctionPointerType) (uint32_t, String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___requestId0, ___payload1, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, uint32_t, String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___requestId0, ___payload1, targetMethod);
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
						GenericInterfaceActionInvoker2< uint32_t, String_t* >::Invoke(targetMethod, targetThis, ___requestId0, ___payload1);
					else
						GenericVirtActionInvoker2< uint32_t, String_t* >::Invoke(targetMethod, targetThis, ___requestId0, ___payload1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker2< uint32_t, String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___requestId0, ___payload1);
					else
						VirtActionInvoker2< uint32_t, String_t* >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___requestId0, ___payload1);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, uint32_t, String_t*, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___requestId0, ___payload1, targetMethod);
			}
		}
	}
}
// System.IAsyncResult AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate::BeginInvoke(System.UInt32,System.String,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* NativeMessageHandlerCallbackDelegate_BeginInvoke_m667F61718D8BD96AEB06CBCD42F02D0866562386 (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * __this, uint32_t ___requestId0, String_t* ___payload1, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback2, RuntimeObject * ___object3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UInt32_tE60352A06233E4E69DD198BCC67142159F686B15_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[3] = {0};
	__d_args[0] = Box(UInt32_tE60352A06233E4E69DD198BCC67142159F686B15_il2cpp_TypeInfo_var, &___requestId0);
	__d_args[1] = ___payload1;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);;
}
// System.Void AppleAuth.AppleAuthManager/PInvoke/NativeMessageHandlerCallbackDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NativeMessageHandlerCallbackDelegate_EndInvoke_m15CB0EB0CCBEF2065F0B78EE601F1AF03D455A9B (NativeMessageHandlerCallbackDelegate_t701AFC8159184451D0239E9261614DE01CBBF2DA * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * List_1_get_Item_mF00B574E58FB078BB753B05A3B86DD0A7A266B63_gshared_inline (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___index0;
		int32_t L_1 = (int32_t)__this->get__size_2();
		if ((!(((uint32_t)L_0) >= ((uint32_t)L_1))))
		{
			goto IL_000e;
		}
	}
	{
		ThrowHelper_ThrowArgumentOutOfRangeException_m4841366ABC2B2AFA37C10900551D7E07522C0929(/*hidden argument*/NULL);
	}

IL_000e:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__items_1();
		int32_t L_3 = ___index0;
		RuntimeObject * L_4;
		L_4 = IL2CPP_ARRAY_UNSAFE_LOAD((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, (int32_t)L_3);
		return (RuntimeObject *)L_4;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m5D847939ABB9A78203B062CAFFE975792174D00F_gshared_inline (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = (int32_t)__this->get__size_2();
		return (int32_t)L_0;
	}
}
