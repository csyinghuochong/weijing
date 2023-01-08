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
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
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

// System.Action`1<UnityEngine.Font>
struct Action_1_tC07E78969BFFC97261F80F4C08915A046DFDD9C7;
// System.Collections.Generic.Dictionary`2<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>
struct Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Object>
struct Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F;
// System.Collections.Generic.Dictionary`2<System.Object,System.Int32Enum>
struct Dictionary_2_t5B35D5550B4D9CDDB7D248BEEE75285BC3023229;
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.GUIStyle>
struct Dictionary_2_t2CD153A36C5BD27CDDC85F23918ECEF77E892E80;
// System.Func`1<System.Boolean>
struct Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F;
// System.Func`2<System.Exception,System.Boolean>
struct Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F;
// System.Func`2<System.Object,System.Boolean>
struct Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8;
// System.Func`3<System.Int32,System.IntPtr,System.Boolean>
struct Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0;
// System.Collections.Generic.IEqualityComparer`1<UnityEngine.Event>
struct IEqualityComparer_1_t46A328CABC9CE489C6B244F85FFC8D5AA0CDDF5D;
// System.Collections.Generic.IEqualityComparer`1<System.Int32>
struct IEqualityComparer_1_t62010156673DE1460AB1D1CEBE5DCD48665E1A38;
// System.Collections.Generic.Dictionary`2/KeyCollection<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>
struct KeyCollection_t0B43DD6FA8A518E7BFEE3AA145DA9035733C1862;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Int32,System.Object>
struct KeyCollection_tBAE0EBE1B8D4A3690FCB3ADC3EF79DF8654B6A36;
// System.Collections.Generic.List`1<UnityEngine.GUILayoutEntry>
struct List_1_t07045BD0BCA84DF3EE9885C9BE0D1F6C57D208AA;
// System.Collections.Generic.Dictionary`2/ValueCollection<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>
struct ValueCollection_t4B4EA3861649863FBECADA2F20EFF81E8164EAED;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Int32,System.Object>
struct ValueCollection_tBBFF5FCCEA64DACDC4DFAB67787E57F5B92377EF;
// System.Collections.Generic.Dictionary`2/Entry<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>[]
struct EntryU5BU5D_t1B313EFD3570E30ADA79C6D1DEC34BBD05AB8724;
// System.Collections.Generic.Dictionary`2/Entry<System.Int32,System.Object>[]
struct EntryU5BU5D_t5373F057B0634C286A365E78C66FE57DBBDAB86E;
// System.Byte[]
struct ByteU5BU5D_tDBBEB0E8362242FA7223000D978B0DD19D4B0726;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// UnityEngine.GUILayoutOption[]
struct GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B;
// UnityEngine.GUIStyle[]
struct GUIStyleU5BU5D_t99FB75A2EC4777ADECDE02F71A619CFBFC0F4F70;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.Type[]
struct TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755;
// System.Action
struct Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6;
// System.ArgumentException
struct ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// System.Reflection.Binder
struct Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// UnityEngine.Event
struct Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E;
// System.Exception
struct Exception_t;
// UnityEngine.Font
struct Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9;
// UnityEngine.GUIContent
struct GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E;
// UnityEngine.GUILayoutEntry
struct GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE;
// UnityEngine.GUILayoutGroup
struct GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9;
// UnityEngine.GUILayoutOption
struct GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB;
// UnityEngine.GUISettings
struct GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0;
// UnityEngine.GUISkin
struct GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6;
// UnityEngine.GUIStyle
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726;
// UnityEngine.GUIStyleState
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9;
// UnityEngine.GUIWordWrapSizer
struct GUIWordWrapSizer_t2DC4A7EB6C47F17F06154C2605F4E522D1334D5D;
// UnityEngineInternal.GenericStack
struct GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.Reflection.MemberFilter
struct MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.RectOffset
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// UnityEngine.ScrollViewState
struct ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0;
// UnityEngine.SliderState
struct SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A;
// System.String
struct String_t;
// UnityEngine.TextEditor
struct TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B;
// UnityEngine.Texture
struct Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE;
// UnityEngine.TouchScreenKeyboard
struct TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E;
// System.Type
struct Type_t;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.Font/FontTextureRebuildCallback
struct FontTextureRebuildCallback_tBF11A511EBD8D237A1C5885D460B42A45DDBB2DB;
// UnityEngine.GUI/WindowFunction
struct WindowFunction_tFA5DBAB811627D7B0946C4AAD398D4CC154C174D;
// UnityEngine.GUILayoutUtility/LayoutCache
struct LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8;
// UnityEngine.GUISkin/SkinChangedDelegate
struct SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E;

IL2CPP_EXTERN_C RuntimeClass* ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ExitGUIException_tA832626B99B4D827C8064643824847BCAA7877F4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUILayoutUtility_tC8DDF719E399EA119E2889EFB47816B34CA58F5A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IntPtr_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SystemClock_tB9EEE70072B2822A428E3478AEBDCB6FCDFDEEB9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TargetInvocationException_t30F4C50D323F448CD2E08BDB8F47694B08EB354C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TextEditOp_t6C6705A198EA7EFB55340BED1D58F28A1129A4DE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral01FE2A7BAF056155917298D04AE54B7D6AF27894;
IL2CPP_EXTERN_C String_t* _stringLiteral028D7034AFF25D3F9A597A5740013E38DA19D317;
IL2CPP_EXTERN_C String_t* _stringLiteral0C9DC099BD4ECD04B696BF38FC02346103F2BC97;
IL2CPP_EXTERN_C String_t* _stringLiteral0EF758EF1A06CA13329086B705ED12F47B9F606F;
IL2CPP_EXTERN_C String_t* _stringLiteral13490EE15BBBA5055FAF4DFF43BAF8642B91BD99;
IL2CPP_EXTERN_C String_t* _stringLiteral1388D2C9310312FF15F8415A0A8F63A7EA461B41;
IL2CPP_EXTERN_C String_t* _stringLiteral13CDCE216B91792515C4C64C7FCF5B265C404257;
IL2CPP_EXTERN_C String_t* _stringLiteral16D9C3063FF5F852963147CC12C5C552A5635796;
IL2CPP_EXTERN_C String_t* _stringLiteral1B22F82E513C1BB368DFDBFDFB5FB8C1178CA305;
IL2CPP_EXTERN_C String_t* _stringLiteral1CD31FFC09BB731749BFAAC984D2EED8E22C771A;
IL2CPP_EXTERN_C String_t* _stringLiteral1DF9EACB3FD057DF42A2784124CCE504D5860AEE;
IL2CPP_EXTERN_C String_t* _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745;
IL2CPP_EXTERN_C String_t* _stringLiteral28C03674125DA29250BA73594E6061FD480A3CB7;
IL2CPP_EXTERN_C String_t* _stringLiteral34D4B5F20FD7AA47487EDE07001792463720D1CE;
IL2CPP_EXTERN_C String_t* _stringLiteral34F817DA4635C4C22DF5692FF51A196067483534;
IL2CPP_EXTERN_C String_t* _stringLiteral350D3BF828268FA677A331CBD1D40C9DB88673B3;
IL2CPP_EXTERN_C String_t* _stringLiteral3C3D97D6F00F5718D7008966DC8F93F9BB87FA51;
IL2CPP_EXTERN_C String_t* _stringLiteral3D3A00B527F2755AFFF36C8F4AC13A53B5DC81D3;
IL2CPP_EXTERN_C String_t* _stringLiteral3D5EAEDD29399C149223964BD7513C036E82B631;
IL2CPP_EXTERN_C String_t* _stringLiteral3D5EBA7CCD58DABCEC7A4FD33516FBE9E3482887;
IL2CPP_EXTERN_C String_t* _stringLiteral3E5BBD622A1890626F72D09F11351B02F04CD245;
IL2CPP_EXTERN_C String_t* _stringLiteral3E5BD769C75B1966931F7A0F059B152FE79C2619;
IL2CPP_EXTERN_C String_t* _stringLiteral4112C4C0070D77562F4AE5B1077F66F430FF4706;
IL2CPP_EXTERN_C String_t* _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5;
IL2CPP_EXTERN_C String_t* _stringLiteral46AC1D8C432B177A3C113AD943EB74504A0EB337;
IL2CPP_EXTERN_C String_t* _stringLiteral4718C7000562AF450B2C8B2BD4445A87205F7666;
IL2CPP_EXTERN_C String_t* _stringLiteral5031FEC61137D005DAA2BFB10E1404651A112B0B;
IL2CPP_EXTERN_C String_t* _stringLiteral5379C25D8F9979AD371949D2F3201B2D326743A4;
IL2CPP_EXTERN_C String_t* _stringLiteral62F0048B45A8ADBC774F1B00911C9AA337E1F633;
IL2CPP_EXTERN_C String_t* _stringLiteral6458183EA8D5BC1AAE58A98C841058647CCC35DE;
IL2CPP_EXTERN_C String_t* _stringLiteral70E962167414B98D1C47009CF2298022592E68D4;
IL2CPP_EXTERN_C String_t* _stringLiteral710CEFF5A6D94EED332EF2BD41342B8B16B45293;
IL2CPP_EXTERN_C String_t* _stringLiteral7174BAC93C4533B5ACC05736AE4D0C900491A008;
IL2CPP_EXTERN_C String_t* _stringLiteral7AADBCDB9D121BC9D88064E31E08A3186262CAE6;
IL2CPP_EXTERN_C String_t* _stringLiteral7BBDDC94A571A1FD7D1FE9C4E3062CB11564D926;
IL2CPP_EXTERN_C String_t* _stringLiteral7EF39B884F9764078345103493B55121123B1B46;
IL2CPP_EXTERN_C String_t* _stringLiteral81AB3FCA888E7214C2733551168655ABA4D3C65A;
IL2CPP_EXTERN_C String_t* _stringLiteral837B17505EC06BAC0E4AA984798E9DB32B9C3CA0;
IL2CPP_EXTERN_C String_t* _stringLiteral8739227E8E687EF781DA0D923452C2686CFF10A2;
IL2CPP_EXTERN_C String_t* _stringLiteral877F6F7B61373508B1123D79708B393A9438C37E;
IL2CPP_EXTERN_C String_t* _stringLiteral9C1E874DA059D22C91283C44117D602D9080875A;
IL2CPP_EXTERN_C String_t* _stringLiteral9FA1FF57F726441CA277BF9734892B299CA3297B;
IL2CPP_EXTERN_C String_t* _stringLiteral9FF3949A2EE199375C9E51BB6ACCD0AE243AF691;
IL2CPP_EXTERN_C String_t* _stringLiteralA2F4AC9DD8E1FAC5257E5F7BA5EE1C7C7E5F7AB1;
IL2CPP_EXTERN_C String_t* _stringLiteralA314507B0573B983FD845620D28E0B2F951D0E10;
IL2CPP_EXTERN_C String_t* _stringLiteralA3955ADB3BC69ECFE423744D4F4F597294A20827;
IL2CPP_EXTERN_C String_t* _stringLiteralA8D3437438DB8A85C804DDB64E69721F1D275030;
IL2CPP_EXTERN_C String_t* _stringLiteralAA7EB40717F1BA8A905AA5B827AAE03AF1D0F2D0;
IL2CPP_EXTERN_C String_t* _stringLiteralB1E5119D36EC43B340C0A0DDC99F1156546EA9DF;
IL2CPP_EXTERN_C String_t* _stringLiteralB468B2E60F7F60260C2916459A799050DD6D3E85;
IL2CPP_EXTERN_C String_t* _stringLiteralB8AA8F2673947FA36BB764D4DD75961AB3AF723E;
IL2CPP_EXTERN_C String_t* _stringLiteralB8E1418EB9CE2E5CF97CF8246D2776B9F1F33D67;
IL2CPP_EXTERN_C String_t* _stringLiteralBA6BD45D12B4E9306BD7E0CC99FEC1DEEBFBBC58;
IL2CPP_EXTERN_C String_t* _stringLiteralBD26781B489D74246E46948A3CF454478F1000C5;
IL2CPP_EXTERN_C String_t* _stringLiteralC581158E993200B82B36A56301468170ADB021DA;
IL2CPP_EXTERN_C String_t* _stringLiteralD91C866DD696C68303515E6926044A10A2ADAB3C;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralDBA1945CFAADC613DE5170FD5C21296CCFF83615;
IL2CPP_EXTERN_C String_t* _stringLiteralE18A20FF89E2801DE5C0C60E05D569C3513C48C7;
IL2CPP_EXTERN_C String_t* _stringLiteralE3EADA58476D85227490ACED9D3239769769DFDC;
IL2CPP_EXTERN_C String_t* _stringLiteralE7B9F94C0B0B71996D09AA98D20E270C100EAB93;
IL2CPP_EXTERN_C String_t* _stringLiteralEA74ED324D4EC0A66FF57C32244629F3B15A2CCF;
IL2CPP_EXTERN_C String_t* _stringLiteralF1129AA23E2182336739DE1026CACAE451BACE5D;
IL2CPP_EXTERN_C String_t* _stringLiteralF222CF93E01C3342431C7952E8BD62DEFC619783;
IL2CPP_EXTERN_C String_t* _stringLiteralF25B95468DAA02EC9AF41A21C2F589D8847BC27F;
IL2CPP_EXTERN_C String_t* _stringLiteralFA1435556F32329DD212289449459CCFA67730F8;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_ContainsKey_mDD8A87D2680C370A2DBC4AFECE658B948EEA1202_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_TryGetValue_m0A88BBB063127AFAD853506A433ACB07D7AAD67E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_m5F2CE464F67F4BDC4EB96CB769755BC675F66B18_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2__ctor_mE7F9D51201F5A72BF4995CA0F3F0E866DB21E638_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_get_Item_m5423F5CE10F5EA6145EECF26BE0F452A301D2B39_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_m60C46D4985DD498C33D75B842121DD35929CF75E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Dictionary_2_set_Item_m71867F9FFBB49DE962FD0036368A0F6E87F30C90_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Func_1_Invoke_mD0192F3F912E371387CD7B196DF85569553486B4_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Func_2_Invoke_m6E33E881BFD75761C0F91C7EEB1AF452BFD18445_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Func_3_Invoke_m41D8569C1E1FFC40BAB05286F15A74835341C627_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GUIUtility_CheckOnGUI_mA591FC883697B53B61EC6B5B4469262BA6936FA7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C_0_0_0_var;
IL2CPP_EXTERN_C const RuntimeType* SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A_0_0_0_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9;;
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com;
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com;;
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke;
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke;;
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726;;
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com;
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com;;
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke;
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke;;
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70;;
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com;
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com;;
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke;
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke;;

struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
struct GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B;
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.Collections.Generic.Dictionary`2<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>
struct Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t1B313EFD3570E30ADA79C6D1DEC34BBD05AB8724* ___entries_1;
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
	KeyCollection_t0B43DD6FA8A518E7BFEE3AA145DA9035733C1862 * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t4B4EA3861649863FBECADA2F20EFF81E8164EAED * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___entries_1)); }
	inline EntryU5BU5D_t1B313EFD3570E30ADA79C6D1DEC34BBD05AB8724* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t1B313EFD3570E30ADA79C6D1DEC34BBD05AB8724** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t1B313EFD3570E30ADA79C6D1DEC34BBD05AB8724* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___keys_7)); }
	inline KeyCollection_t0B43DD6FA8A518E7BFEE3AA145DA9035733C1862 * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t0B43DD6FA8A518E7BFEE3AA145DA9035733C1862 ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t0B43DD6FA8A518E7BFEE3AA145DA9035733C1862 * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ___values_8)); }
	inline ValueCollection_t4B4EA3861649863FBECADA2F20EFF81E8164EAED * get_values_8() const { return ___values_8; }
	inline ValueCollection_t4B4EA3861649863FBECADA2F20EFF81E8164EAED ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t4B4EA3861649863FBECADA2F20EFF81E8164EAED * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_9), (void*)value);
	}
};


// System.Collections.Generic.Dictionary`2<System.Int32,System.Object>
struct Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___buckets_0;
	// System.Collections.Generic.Dictionary`2/Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t5373F057B0634C286A365E78C66FE57DBBDAB86E* ___entries_1;
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
	KeyCollection_tBAE0EBE1B8D4A3690FCB3ADC3EF79DF8654B6A36 * ___keys_7;
	// System.Collections.Generic.Dictionary`2/ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_tBBFF5FCCEA64DACDC4DFAB67787E57F5B92377EF * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___buckets_0)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___buckets_0), (void*)value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___entries_1)); }
	inline EntryU5BU5D_t5373F057B0634C286A365E78C66FE57DBBDAB86E* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t5373F057B0634C286A365E78C66FE57DBBDAB86E** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t5373F057B0634C286A365E78C66FE57DBBDAB86E* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_1), (void*)value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___comparer_6), (void*)value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___keys_7)); }
	inline KeyCollection_tBAE0EBE1B8D4A3690FCB3ADC3EF79DF8654B6A36 * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_tBAE0EBE1B8D4A3690FCB3ADC3EF79DF8654B6A36 ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_tBAE0EBE1B8D4A3690FCB3ADC3EF79DF8654B6A36 * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keys_7), (void*)value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ___values_8)); }
	inline ValueCollection_tBBFF5FCCEA64DACDC4DFAB67787E57F5B92377EF * get_values_8() const { return ___values_8; }
	inline ValueCollection_tBBFF5FCCEA64DACDC4DFAB67787E57F5B92377EF ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_tBBFF5FCCEA64DACDC4DFAB67787E57F5B92377EF * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___values_8), (void*)value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_9), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// System.Attribute
struct Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71  : public RuntimeObject
{
public:

public:
};


// UnityEngine.GUIContent
struct GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E  : public RuntimeObject
{
public:
	// System.String UnityEngine.GUIContent::m_Text
	String_t* ___m_Text_0;
	// UnityEngine.Texture UnityEngine.GUIContent::m_Image
	Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE * ___m_Image_1;
	// System.String UnityEngine.GUIContent::m_Tooltip
	String_t* ___m_Tooltip_2;

public:
	inline static int32_t get_offset_of_m_Text_0() { return static_cast<int32_t>(offsetof(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E, ___m_Text_0)); }
	inline String_t* get_m_Text_0() const { return ___m_Text_0; }
	inline String_t** get_address_of_m_Text_0() { return &___m_Text_0; }
	inline void set_m_Text_0(String_t* value)
	{
		___m_Text_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Text_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_Image_1() { return static_cast<int32_t>(offsetof(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E, ___m_Image_1)); }
	inline Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE * get_m_Image_1() const { return ___m_Image_1; }
	inline Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE ** get_address_of_m_Image_1() { return &___m_Image_1; }
	inline void set_m_Image_1(Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE * value)
	{
		___m_Image_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Image_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_Tooltip_2() { return static_cast<int32_t>(offsetof(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E, ___m_Tooltip_2)); }
	inline String_t* get_m_Tooltip_2() const { return ___m_Tooltip_2; }
	inline String_t** get_address_of_m_Tooltip_2() { return &___m_Tooltip_2; }
	inline void set_m_Tooltip_2(String_t* value)
	{
		___m_Tooltip_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Tooltip_2), (void*)value);
	}
};

struct GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields
{
public:
	// UnityEngine.GUIContent UnityEngine.GUIContent::s_Text
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___s_Text_3;
	// UnityEngine.GUIContent UnityEngine.GUIContent::s_Image
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___s_Image_4;
	// UnityEngine.GUIContent UnityEngine.GUIContent::s_TextImage
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___s_TextImage_5;
	// UnityEngine.GUIContent UnityEngine.GUIContent::none
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___none_6;

public:
	inline static int32_t get_offset_of_s_Text_3() { return static_cast<int32_t>(offsetof(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields, ___s_Text_3)); }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * get_s_Text_3() const { return ___s_Text_3; }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E ** get_address_of_s_Text_3() { return &___s_Text_3; }
	inline void set_s_Text_3(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * value)
	{
		___s_Text_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Text_3), (void*)value);
	}

	inline static int32_t get_offset_of_s_Image_4() { return static_cast<int32_t>(offsetof(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields, ___s_Image_4)); }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * get_s_Image_4() const { return ___s_Image_4; }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E ** get_address_of_s_Image_4() { return &___s_Image_4; }
	inline void set_s_Image_4(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * value)
	{
		___s_Image_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Image_4), (void*)value);
	}

	inline static int32_t get_offset_of_s_TextImage_5() { return static_cast<int32_t>(offsetof(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields, ___s_TextImage_5)); }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * get_s_TextImage_5() const { return ___s_TextImage_5; }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E ** get_address_of_s_TextImage_5() { return &___s_TextImage_5; }
	inline void set_s_TextImage_5(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * value)
	{
		___s_TextImage_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_TextImage_5), (void*)value);
	}

	inline static int32_t get_offset_of_none_6() { return static_cast<int32_t>(offsetof(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields, ___none_6)); }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * get_none_6() const { return ___none_6; }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E ** get_address_of_none_6() { return &___none_6; }
	inline void set_none_6(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * value)
	{
		___none_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___none_6), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.GUIContent
struct GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_marshaled_pinvoke
{
	char* ___m_Text_0;
	Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE * ___m_Image_1;
	char* ___m_Tooltip_2;
};
// Native definition for COM marshalling of UnityEngine.GUIContent
struct GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_marshaled_com
{
	Il2CppChar* ___m_Text_0;
	Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE * ___m_Image_1;
	Il2CppChar* ___m_Tooltip_2;
};

// UnityEngine.GUIStateObjects
struct GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4  : public RuntimeObject
{
public:

public:
};

struct GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Object> UnityEngine.GUIStateObjects::s_StateCache
	Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * ___s_StateCache_0;

public:
	inline static int32_t get_offset_of_s_StateCache_0() { return static_cast<int32_t>(offsetof(GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_StaticFields, ___s_StateCache_0)); }
	inline Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * get_s_StateCache_0() const { return ___s_StateCache_0; }
	inline Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F ** get_address_of_s_StateCache_0() { return &___s_StateCache_0; }
	inline void set_s_StateCache_0(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * value)
	{
		___s_StateCache_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_StateCache_0), (void*)value);
	}
};


// UnityEngine.GUIUtility
struct GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5  : public RuntimeObject
{
public:

public:
};

struct GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields
{
public:
	// System.Int32 UnityEngine.GUIUtility::s_ControlCount
	int32_t ___s_ControlCount_0;
	// System.Int32 UnityEngine.GUIUtility::s_SkinMode
	int32_t ___s_SkinMode_1;
	// System.Int32 UnityEngine.GUIUtility::s_OriginalID
	int32_t ___s_OriginalID_2;
	// System.Action UnityEngine.GUIUtility::takeCapture
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___takeCapture_3;
	// System.Action UnityEngine.GUIUtility::releaseCapture
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___releaseCapture_4;
	// System.Func`3<System.Int32,System.IntPtr,System.Boolean> UnityEngine.GUIUtility::processEvent
	Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 * ___processEvent_5;
	// System.Func`2<System.Exception,System.Boolean> UnityEngine.GUIUtility::endContainerGUIFromException
	Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F * ___endContainerGUIFromException_6;
	// System.Action UnityEngine.GUIUtility::guiChanged
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * ___guiChanged_7;
	// System.Boolean UnityEngine.GUIUtility::<guiIsExiting>k__BackingField
	bool ___U3CguiIsExitingU3Ek__BackingField_8;
	// System.Func`1<System.Boolean> UnityEngine.GUIUtility::s_HasCurrentWindowKeyFocusFunc
	Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F * ___s_HasCurrentWindowKeyFocusFunc_9;

public:
	inline static int32_t get_offset_of_s_ControlCount_0() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___s_ControlCount_0)); }
	inline int32_t get_s_ControlCount_0() const { return ___s_ControlCount_0; }
	inline int32_t* get_address_of_s_ControlCount_0() { return &___s_ControlCount_0; }
	inline void set_s_ControlCount_0(int32_t value)
	{
		___s_ControlCount_0 = value;
	}

	inline static int32_t get_offset_of_s_SkinMode_1() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___s_SkinMode_1)); }
	inline int32_t get_s_SkinMode_1() const { return ___s_SkinMode_1; }
	inline int32_t* get_address_of_s_SkinMode_1() { return &___s_SkinMode_1; }
	inline void set_s_SkinMode_1(int32_t value)
	{
		___s_SkinMode_1 = value;
	}

	inline static int32_t get_offset_of_s_OriginalID_2() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___s_OriginalID_2)); }
	inline int32_t get_s_OriginalID_2() const { return ___s_OriginalID_2; }
	inline int32_t* get_address_of_s_OriginalID_2() { return &___s_OriginalID_2; }
	inline void set_s_OriginalID_2(int32_t value)
	{
		___s_OriginalID_2 = value;
	}

	inline static int32_t get_offset_of_takeCapture_3() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___takeCapture_3)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_takeCapture_3() const { return ___takeCapture_3; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_takeCapture_3() { return &___takeCapture_3; }
	inline void set_takeCapture_3(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___takeCapture_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___takeCapture_3), (void*)value);
	}

	inline static int32_t get_offset_of_releaseCapture_4() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___releaseCapture_4)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_releaseCapture_4() const { return ___releaseCapture_4; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_releaseCapture_4() { return &___releaseCapture_4; }
	inline void set_releaseCapture_4(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___releaseCapture_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___releaseCapture_4), (void*)value);
	}

	inline static int32_t get_offset_of_processEvent_5() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___processEvent_5)); }
	inline Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 * get_processEvent_5() const { return ___processEvent_5; }
	inline Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 ** get_address_of_processEvent_5() { return &___processEvent_5; }
	inline void set_processEvent_5(Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 * value)
	{
		___processEvent_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___processEvent_5), (void*)value);
	}

	inline static int32_t get_offset_of_endContainerGUIFromException_6() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___endContainerGUIFromException_6)); }
	inline Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F * get_endContainerGUIFromException_6() const { return ___endContainerGUIFromException_6; }
	inline Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F ** get_address_of_endContainerGUIFromException_6() { return &___endContainerGUIFromException_6; }
	inline void set_endContainerGUIFromException_6(Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F * value)
	{
		___endContainerGUIFromException_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___endContainerGUIFromException_6), (void*)value);
	}

	inline static int32_t get_offset_of_guiChanged_7() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___guiChanged_7)); }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * get_guiChanged_7() const { return ___guiChanged_7; }
	inline Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 ** get_address_of_guiChanged_7() { return &___guiChanged_7; }
	inline void set_guiChanged_7(Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * value)
	{
		___guiChanged_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___guiChanged_7), (void*)value);
	}

	inline static int32_t get_offset_of_U3CguiIsExitingU3Ek__BackingField_8() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___U3CguiIsExitingU3Ek__BackingField_8)); }
	inline bool get_U3CguiIsExitingU3Ek__BackingField_8() const { return ___U3CguiIsExitingU3Ek__BackingField_8; }
	inline bool* get_address_of_U3CguiIsExitingU3Ek__BackingField_8() { return &___U3CguiIsExitingU3Ek__BackingField_8; }
	inline void set_U3CguiIsExitingU3Ek__BackingField_8(bool value)
	{
		___U3CguiIsExitingU3Ek__BackingField_8 = value;
	}

	inline static int32_t get_offset_of_s_HasCurrentWindowKeyFocusFunc_9() { return static_cast<int32_t>(offsetof(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields, ___s_HasCurrentWindowKeyFocusFunc_9)); }
	inline Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F * get_s_HasCurrentWindowKeyFocusFunc_9() const { return ___s_HasCurrentWindowKeyFocusFunc_9; }
	inline Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F ** get_address_of_s_HasCurrentWindowKeyFocusFunc_9() { return &___s_HasCurrentWindowKeyFocusFunc_9; }
	inline void set_s_HasCurrentWindowKeyFocusFunc_9(Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F * value)
	{
		___s_HasCurrentWindowKeyFocusFunc_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_HasCurrentWindowKeyFocusFunc_9), (void*)value);
	}
};


// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
{
public:

public:
};


// UnityEngine.SliderState
struct SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A  : public RuntimeObject
{
public:
	// System.Single UnityEngine.SliderState::dragStartPos
	float ___dragStartPos_0;
	// System.Single UnityEngine.SliderState::dragStartValue
	float ___dragStartValue_1;
	// System.Boolean UnityEngine.SliderState::isDragging
	bool ___isDragging_2;

public:
	inline static int32_t get_offset_of_dragStartPos_0() { return static_cast<int32_t>(offsetof(SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A, ___dragStartPos_0)); }
	inline float get_dragStartPos_0() const { return ___dragStartPos_0; }
	inline float* get_address_of_dragStartPos_0() { return &___dragStartPos_0; }
	inline void set_dragStartPos_0(float value)
	{
		___dragStartPos_0 = value;
	}

	inline static int32_t get_offset_of_dragStartValue_1() { return static_cast<int32_t>(offsetof(SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A, ___dragStartValue_1)); }
	inline float get_dragStartValue_1() const { return ___dragStartValue_1; }
	inline float* get_address_of_dragStartValue_1() { return &___dragStartValue_1; }
	inline void set_dragStartValue_1(float value)
	{
		___dragStartValue_1 = value;
	}

	inline static int32_t get_offset_of_isDragging_2() { return static_cast<int32_t>(offsetof(SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A, ___isDragging_2)); }
	inline bool get_isDragging_2() const { return ___isDragging_2; }
	inline bool* get_address_of_isDragging_2() { return &___isDragging_2; }
	inline void set_isDragging_2(bool value)
	{
		___isDragging_2 = value;
	}
};


// System.Collections.Stack
struct Stack_tF6DD42A42C129B014D4223010F1E0FFBECBDC3B8  : public RuntimeObject
{
public:
	// System.Object[] System.Collections.Stack::_array
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ____array_0;
	// System.Int32 System.Collections.Stack::_size
	int32_t ____size_1;
	// System.Int32 System.Collections.Stack::_version
	int32_t ____version_2;
	// System.Object System.Collections.Stack::_syncRoot
	RuntimeObject * ____syncRoot_3;

public:
	inline static int32_t get_offset_of__array_0() { return static_cast<int32_t>(offsetof(Stack_tF6DD42A42C129B014D4223010F1E0FFBECBDC3B8, ____array_0)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get__array_0() const { return ____array_0; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of__array_0() { return &____array_0; }
	inline void set__array_0(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		____array_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____array_0), (void*)value);
	}

	inline static int32_t get_offset_of__size_1() { return static_cast<int32_t>(offsetof(Stack_tF6DD42A42C129B014D4223010F1E0FFBECBDC3B8, ____size_1)); }
	inline int32_t get__size_1() const { return ____size_1; }
	inline int32_t* get_address_of__size_1() { return &____size_1; }
	inline void set__size_1(int32_t value)
	{
		____size_1 = value;
	}

	inline static int32_t get_offset_of__version_2() { return static_cast<int32_t>(offsetof(Stack_tF6DD42A42C129B014D4223010F1E0FFBECBDC3B8, ____version_2)); }
	inline int32_t get__version_2() const { return ____version_2; }
	inline int32_t* get_address_of__version_2() { return &____version_2; }
	inline void set__version_2(int32_t value)
	{
		____version_2 = value;
	}

	inline static int32_t get_offset_of__syncRoot_3() { return static_cast<int32_t>(offsetof(Stack_tF6DD42A42C129B014D4223010F1E0FFBECBDC3B8, ____syncRoot_3)); }
	inline RuntimeObject * get__syncRoot_3() const { return ____syncRoot_3; }
	inline RuntimeObject ** get_address_of__syncRoot_3() { return &____syncRoot_3; }
	inline void set__syncRoot_3(RuntimeObject * value)
	{
		____syncRoot_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_3), (void*)value);
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

// UnityEngine.GUILayoutUtility/LayoutCache
struct LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8  : public RuntimeObject
{
public:
	// System.Int32 UnityEngine.GUILayoutUtility/LayoutCache::<id>k__BackingField
	int32_t ___U3CidU3Ek__BackingField_0;
	// UnityEngine.GUILayoutGroup UnityEngine.GUILayoutUtility/LayoutCache::topLevel
	GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * ___topLevel_1;
	// UnityEngineInternal.GenericStack UnityEngine.GUILayoutUtility/LayoutCache::layoutGroups
	GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * ___layoutGroups_2;
	// UnityEngine.GUILayoutGroup UnityEngine.GUILayoutUtility/LayoutCache::windows
	GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * ___windows_3;

public:
	inline static int32_t get_offset_of_U3CidU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8, ___U3CidU3Ek__BackingField_0)); }
	inline int32_t get_U3CidU3Ek__BackingField_0() const { return ___U3CidU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3CidU3Ek__BackingField_0() { return &___U3CidU3Ek__BackingField_0; }
	inline void set_U3CidU3Ek__BackingField_0(int32_t value)
	{
		___U3CidU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_topLevel_1() { return static_cast<int32_t>(offsetof(LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8, ___topLevel_1)); }
	inline GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * get_topLevel_1() const { return ___topLevel_1; }
	inline GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 ** get_address_of_topLevel_1() { return &___topLevel_1; }
	inline void set_topLevel_1(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * value)
	{
		___topLevel_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___topLevel_1), (void*)value);
	}

	inline static int32_t get_offset_of_layoutGroups_2() { return static_cast<int32_t>(offsetof(LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8, ___layoutGroups_2)); }
	inline GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * get_layoutGroups_2() const { return ___layoutGroups_2; }
	inline GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C ** get_address_of_layoutGroups_2() { return &___layoutGroups_2; }
	inline void set_layoutGroups_2(GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * value)
	{
		___layoutGroups_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___layoutGroups_2), (void*)value);
	}

	inline static int32_t get_offset_of_windows_3() { return static_cast<int32_t>(offsetof(LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8, ___windows_3)); }
	inline GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * get_windows_3() const { return ___windows_3; }
	inline GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 ** get_address_of_windows_3() { return &___windows_3; }
	inline void set_windows_3(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * value)
	{
		___windows_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___windows_3), (void*)value);
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

// UnityEngine.GUITargetAttribute
struct GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Int32 UnityEngine.GUITargetAttribute::displayMask
	int32_t ___displayMask_0;

public:
	inline static int32_t get_offset_of_displayMask_0() { return static_cast<int32_t>(offsetof(GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C, ___displayMask_0)); }
	inline int32_t get_displayMask_0() const { return ___displayMask_0; }
	inline int32_t* get_address_of_displayMask_0() { return &___displayMask_0; }
	inline void set_displayMask_0(int32_t value)
	{
		___displayMask_0 = value;
	}
};


// UnityEngineInternal.GenericStack
struct GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C  : public Stack_tF6DD42A42C129B014D4223010F1E0FFBECBDC3B8
{
public:

public:
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


// System.Reflection.MethodBase
struct MethodBase_t  : public MemberInfo_t
{
public:

public:
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

// UnityEngine.Event
struct Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Event::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};

struct Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E_StaticFields
{
public:
	// UnityEngine.Event UnityEngine.Event::s_Current
	Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___s_Current_1;
	// UnityEngine.Event UnityEngine.Event::s_MasterEvent
	Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___s_MasterEvent_2;

public:
	inline static int32_t get_offset_of_s_Current_1() { return static_cast<int32_t>(offsetof(Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E_StaticFields, ___s_Current_1)); }
	inline Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * get_s_Current_1() const { return ___s_Current_1; }
	inline Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E ** get_address_of_s_Current_1() { return &___s_Current_1; }
	inline void set_s_Current_1(Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * value)
	{
		___s_Current_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Current_1), (void*)value);
	}

	inline static int32_t get_offset_of_s_MasterEvent_2() { return static_cast<int32_t>(offsetof(Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E_StaticFields, ___s_MasterEvent_2)); }
	inline Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * get_s_MasterEvent_2() const { return ___s_MasterEvent_2; }
	inline Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E ** get_address_of_s_MasterEvent_2() { return &___s_MasterEvent_2; }
	inline void set_s_MasterEvent_2(Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * value)
	{
		___s_MasterEvent_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_MasterEvent_2), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Event
struct Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.Event
struct Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// UnityEngine.EventModifiers
struct EventModifiers_t74E579DA08774C9BED20643F03DA610285143BFA 
{
public:
	// System.Int32 UnityEngine.EventModifiers::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(EventModifiers_t74E579DA08774C9BED20643F03DA610285143BFA, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.EventType
struct EventType_t7441C817FAEEF7090BC0D9084E6DB3E7F635815F 
{
public:
	// System.Int32 UnityEngine.EventType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(EventType_t7441C817FAEEF7090BC0D9084E6DB3E7F635815F, ___value___2)); }
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

// UnityEngine.FocusType
struct FocusType_t80502A0145268E14DFC06CEB47FCFF5291947504 
{
public:
	// System.Int32 UnityEngine.FocusType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FocusType_t80502A0145268E14DFC06CEB47FCFF5291947504, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.GUI
struct GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1  : public RuntimeObject
{
public:

public:
};

struct GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields
{
public:
	// System.Int32 UnityEngine.GUI::s_ScrollControlId
	int32_t ___s_ScrollControlId_0;
	// System.Int32 UnityEngine.GUI::s_HotTextField
	int32_t ___s_HotTextField_1;
	// System.Int32 UnityEngine.GUI::s_BoxHash
	int32_t ___s_BoxHash_2;
	// System.Int32 UnityEngine.GUI::s_ButonHash
	int32_t ___s_ButonHash_3;
	// System.Int32 UnityEngine.GUI::s_RepeatButtonHash
	int32_t ___s_RepeatButtonHash_4;
	// System.Int32 UnityEngine.GUI::s_ToggleHash
	int32_t ___s_ToggleHash_5;
	// System.Int32 UnityEngine.GUI::s_ButtonGridHash
	int32_t ___s_ButtonGridHash_6;
	// System.Int32 UnityEngine.GUI::s_SliderHash
	int32_t ___s_SliderHash_7;
	// System.Int32 UnityEngine.GUI::s_BeginGroupHash
	int32_t ___s_BeginGroupHash_8;
	// System.Int32 UnityEngine.GUI::s_ScrollviewHash
	int32_t ___s_ScrollviewHash_9;
	// System.Int32 UnityEngine.GUI::<scrollTroughSide>k__BackingField
	int32_t ___U3CscrollTroughSideU3Ek__BackingField_10;
	// System.DateTime UnityEngine.GUI::<nextScrollStepTime>k__BackingField
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___U3CnextScrollStepTimeU3Ek__BackingField_11;
	// UnityEngine.GUISkin UnityEngine.GUI::s_Skin
	GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * ___s_Skin_12;
	// UnityEngine.Rect UnityEngine.GUI::s_ToolTipRect
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___s_ToolTipRect_13;
	// UnityEngineInternal.GenericStack UnityEngine.GUI::<scrollViewStates>k__BackingField
	GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * ___U3CscrollViewStatesU3Ek__BackingField_14;

public:
	inline static int32_t get_offset_of_s_ScrollControlId_0() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_ScrollControlId_0)); }
	inline int32_t get_s_ScrollControlId_0() const { return ___s_ScrollControlId_0; }
	inline int32_t* get_address_of_s_ScrollControlId_0() { return &___s_ScrollControlId_0; }
	inline void set_s_ScrollControlId_0(int32_t value)
	{
		___s_ScrollControlId_0 = value;
	}

	inline static int32_t get_offset_of_s_HotTextField_1() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_HotTextField_1)); }
	inline int32_t get_s_HotTextField_1() const { return ___s_HotTextField_1; }
	inline int32_t* get_address_of_s_HotTextField_1() { return &___s_HotTextField_1; }
	inline void set_s_HotTextField_1(int32_t value)
	{
		___s_HotTextField_1 = value;
	}

	inline static int32_t get_offset_of_s_BoxHash_2() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_BoxHash_2)); }
	inline int32_t get_s_BoxHash_2() const { return ___s_BoxHash_2; }
	inline int32_t* get_address_of_s_BoxHash_2() { return &___s_BoxHash_2; }
	inline void set_s_BoxHash_2(int32_t value)
	{
		___s_BoxHash_2 = value;
	}

	inline static int32_t get_offset_of_s_ButonHash_3() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_ButonHash_3)); }
	inline int32_t get_s_ButonHash_3() const { return ___s_ButonHash_3; }
	inline int32_t* get_address_of_s_ButonHash_3() { return &___s_ButonHash_3; }
	inline void set_s_ButonHash_3(int32_t value)
	{
		___s_ButonHash_3 = value;
	}

	inline static int32_t get_offset_of_s_RepeatButtonHash_4() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_RepeatButtonHash_4)); }
	inline int32_t get_s_RepeatButtonHash_4() const { return ___s_RepeatButtonHash_4; }
	inline int32_t* get_address_of_s_RepeatButtonHash_4() { return &___s_RepeatButtonHash_4; }
	inline void set_s_RepeatButtonHash_4(int32_t value)
	{
		___s_RepeatButtonHash_4 = value;
	}

	inline static int32_t get_offset_of_s_ToggleHash_5() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_ToggleHash_5)); }
	inline int32_t get_s_ToggleHash_5() const { return ___s_ToggleHash_5; }
	inline int32_t* get_address_of_s_ToggleHash_5() { return &___s_ToggleHash_5; }
	inline void set_s_ToggleHash_5(int32_t value)
	{
		___s_ToggleHash_5 = value;
	}

	inline static int32_t get_offset_of_s_ButtonGridHash_6() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_ButtonGridHash_6)); }
	inline int32_t get_s_ButtonGridHash_6() const { return ___s_ButtonGridHash_6; }
	inline int32_t* get_address_of_s_ButtonGridHash_6() { return &___s_ButtonGridHash_6; }
	inline void set_s_ButtonGridHash_6(int32_t value)
	{
		___s_ButtonGridHash_6 = value;
	}

	inline static int32_t get_offset_of_s_SliderHash_7() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_SliderHash_7)); }
	inline int32_t get_s_SliderHash_7() const { return ___s_SliderHash_7; }
	inline int32_t* get_address_of_s_SliderHash_7() { return &___s_SliderHash_7; }
	inline void set_s_SliderHash_7(int32_t value)
	{
		___s_SliderHash_7 = value;
	}

	inline static int32_t get_offset_of_s_BeginGroupHash_8() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_BeginGroupHash_8)); }
	inline int32_t get_s_BeginGroupHash_8() const { return ___s_BeginGroupHash_8; }
	inline int32_t* get_address_of_s_BeginGroupHash_8() { return &___s_BeginGroupHash_8; }
	inline void set_s_BeginGroupHash_8(int32_t value)
	{
		___s_BeginGroupHash_8 = value;
	}

	inline static int32_t get_offset_of_s_ScrollviewHash_9() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_ScrollviewHash_9)); }
	inline int32_t get_s_ScrollviewHash_9() const { return ___s_ScrollviewHash_9; }
	inline int32_t* get_address_of_s_ScrollviewHash_9() { return &___s_ScrollviewHash_9; }
	inline void set_s_ScrollviewHash_9(int32_t value)
	{
		___s_ScrollviewHash_9 = value;
	}

	inline static int32_t get_offset_of_U3CscrollTroughSideU3Ek__BackingField_10() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___U3CscrollTroughSideU3Ek__BackingField_10)); }
	inline int32_t get_U3CscrollTroughSideU3Ek__BackingField_10() const { return ___U3CscrollTroughSideU3Ek__BackingField_10; }
	inline int32_t* get_address_of_U3CscrollTroughSideU3Ek__BackingField_10() { return &___U3CscrollTroughSideU3Ek__BackingField_10; }
	inline void set_U3CscrollTroughSideU3Ek__BackingField_10(int32_t value)
	{
		___U3CscrollTroughSideU3Ek__BackingField_10 = value;
	}

	inline static int32_t get_offset_of_U3CnextScrollStepTimeU3Ek__BackingField_11() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___U3CnextScrollStepTimeU3Ek__BackingField_11)); }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  get_U3CnextScrollStepTimeU3Ek__BackingField_11() const { return ___U3CnextScrollStepTimeU3Ek__BackingField_11; }
	inline DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * get_address_of_U3CnextScrollStepTimeU3Ek__BackingField_11() { return &___U3CnextScrollStepTimeU3Ek__BackingField_11; }
	inline void set_U3CnextScrollStepTimeU3Ek__BackingField_11(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  value)
	{
		___U3CnextScrollStepTimeU3Ek__BackingField_11 = value;
	}

	inline static int32_t get_offset_of_s_Skin_12() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_Skin_12)); }
	inline GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * get_s_Skin_12() const { return ___s_Skin_12; }
	inline GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 ** get_address_of_s_Skin_12() { return &___s_Skin_12; }
	inline void set_s_Skin_12(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * value)
	{
		___s_Skin_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Skin_12), (void*)value);
	}

	inline static int32_t get_offset_of_s_ToolTipRect_13() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___s_ToolTipRect_13)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_s_ToolTipRect_13() const { return ___s_ToolTipRect_13; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_s_ToolTipRect_13() { return &___s_ToolTipRect_13; }
	inline void set_s_ToolTipRect_13(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___s_ToolTipRect_13 = value;
	}

	inline static int32_t get_offset_of_U3CscrollViewStatesU3Ek__BackingField_14() { return static_cast<int32_t>(offsetof(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields, ___U3CscrollViewStatesU3Ek__BackingField_14)); }
	inline GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * get_U3CscrollViewStatesU3Ek__BackingField_14() const { return ___U3CscrollViewStatesU3Ek__BackingField_14; }
	inline GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C ** get_address_of_U3CscrollViewStatesU3Ek__BackingField_14() { return &___U3CscrollViewStatesU3Ek__BackingField_14; }
	inline void set_U3CscrollViewStatesU3Ek__BackingField_14(GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * value)
	{
		___U3CscrollViewStatesU3Ek__BackingField_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CscrollViewStatesU3Ek__BackingField_14), (void*)value);
	}
};


// UnityEngine.GUILayoutEntry
struct GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE  : public RuntimeObject
{
public:
	// System.Single UnityEngine.GUILayoutEntry::minWidth
	float ___minWidth_0;
	// System.Single UnityEngine.GUILayoutEntry::maxWidth
	float ___maxWidth_1;
	// System.Single UnityEngine.GUILayoutEntry::minHeight
	float ___minHeight_2;
	// System.Single UnityEngine.GUILayoutEntry::maxHeight
	float ___maxHeight_3;
	// UnityEngine.Rect UnityEngine.GUILayoutEntry::rect
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect_4;
	// System.Int32 UnityEngine.GUILayoutEntry::stretchWidth
	int32_t ___stretchWidth_5;
	// System.Int32 UnityEngine.GUILayoutEntry::stretchHeight
	int32_t ___stretchHeight_6;
	// System.Boolean UnityEngine.GUILayoutEntry::consideredForMargin
	bool ___consideredForMargin_7;
	// UnityEngine.GUIStyle UnityEngine.GUILayoutEntry::m_Style
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_Style_8;

public:
	inline static int32_t get_offset_of_minWidth_0() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___minWidth_0)); }
	inline float get_minWidth_0() const { return ___minWidth_0; }
	inline float* get_address_of_minWidth_0() { return &___minWidth_0; }
	inline void set_minWidth_0(float value)
	{
		___minWidth_0 = value;
	}

	inline static int32_t get_offset_of_maxWidth_1() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___maxWidth_1)); }
	inline float get_maxWidth_1() const { return ___maxWidth_1; }
	inline float* get_address_of_maxWidth_1() { return &___maxWidth_1; }
	inline void set_maxWidth_1(float value)
	{
		___maxWidth_1 = value;
	}

	inline static int32_t get_offset_of_minHeight_2() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___minHeight_2)); }
	inline float get_minHeight_2() const { return ___minHeight_2; }
	inline float* get_address_of_minHeight_2() { return &___minHeight_2; }
	inline void set_minHeight_2(float value)
	{
		___minHeight_2 = value;
	}

	inline static int32_t get_offset_of_maxHeight_3() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___maxHeight_3)); }
	inline float get_maxHeight_3() const { return ___maxHeight_3; }
	inline float* get_address_of_maxHeight_3() { return &___maxHeight_3; }
	inline void set_maxHeight_3(float value)
	{
		___maxHeight_3 = value;
	}

	inline static int32_t get_offset_of_rect_4() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___rect_4)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_rect_4() const { return ___rect_4; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_rect_4() { return &___rect_4; }
	inline void set_rect_4(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___rect_4 = value;
	}

	inline static int32_t get_offset_of_stretchWidth_5() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___stretchWidth_5)); }
	inline int32_t get_stretchWidth_5() const { return ___stretchWidth_5; }
	inline int32_t* get_address_of_stretchWidth_5() { return &___stretchWidth_5; }
	inline void set_stretchWidth_5(int32_t value)
	{
		___stretchWidth_5 = value;
	}

	inline static int32_t get_offset_of_stretchHeight_6() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___stretchHeight_6)); }
	inline int32_t get_stretchHeight_6() const { return ___stretchHeight_6; }
	inline int32_t* get_address_of_stretchHeight_6() { return &___stretchHeight_6; }
	inline void set_stretchHeight_6(int32_t value)
	{
		___stretchHeight_6 = value;
	}

	inline static int32_t get_offset_of_consideredForMargin_7() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___consideredForMargin_7)); }
	inline bool get_consideredForMargin_7() const { return ___consideredForMargin_7; }
	inline bool* get_address_of_consideredForMargin_7() { return &___consideredForMargin_7; }
	inline void set_consideredForMargin_7(bool value)
	{
		___consideredForMargin_7 = value;
	}

	inline static int32_t get_offset_of_m_Style_8() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE, ___m_Style_8)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_Style_8() const { return ___m_Style_8; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_Style_8() { return &___m_Style_8; }
	inline void set_m_Style_8(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_Style_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Style_8), (void*)value);
	}
};

struct GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE_StaticFields
{
public:
	// UnityEngine.Rect UnityEngine.GUILayoutEntry::kDummyRect
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___kDummyRect_9;
	// System.Int32 UnityEngine.GUILayoutEntry::indent
	int32_t ___indent_10;

public:
	inline static int32_t get_offset_of_kDummyRect_9() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE_StaticFields, ___kDummyRect_9)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_kDummyRect_9() const { return ___kDummyRect_9; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_kDummyRect_9() { return &___kDummyRect_9; }
	inline void set_kDummyRect_9(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___kDummyRect_9 = value;
	}

	inline static int32_t get_offset_of_indent_10() { return static_cast<int32_t>(offsetof(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE_StaticFields, ___indent_10)); }
	inline int32_t get_indent_10() const { return ___indent_10; }
	inline int32_t* get_address_of_indent_10() { return &___indent_10; }
	inline void set_indent_10(int32_t value)
	{
		___indent_10 = value;
	}
};


// UnityEngine.GUISettings
struct GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0  : public RuntimeObject
{
public:
	// System.Boolean UnityEngine.GUISettings::m_DoubleClickSelectsWord
	bool ___m_DoubleClickSelectsWord_0;
	// System.Boolean UnityEngine.GUISettings::m_TripleClickSelectsLine
	bool ___m_TripleClickSelectsLine_1;
	// UnityEngine.Color UnityEngine.GUISettings::m_CursorColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_CursorColor_2;
	// System.Single UnityEngine.GUISettings::m_CursorFlashSpeed
	float ___m_CursorFlashSpeed_3;
	// UnityEngine.Color UnityEngine.GUISettings::m_SelectionColor
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___m_SelectionColor_4;

public:
	inline static int32_t get_offset_of_m_DoubleClickSelectsWord_0() { return static_cast<int32_t>(offsetof(GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0, ___m_DoubleClickSelectsWord_0)); }
	inline bool get_m_DoubleClickSelectsWord_0() const { return ___m_DoubleClickSelectsWord_0; }
	inline bool* get_address_of_m_DoubleClickSelectsWord_0() { return &___m_DoubleClickSelectsWord_0; }
	inline void set_m_DoubleClickSelectsWord_0(bool value)
	{
		___m_DoubleClickSelectsWord_0 = value;
	}

	inline static int32_t get_offset_of_m_TripleClickSelectsLine_1() { return static_cast<int32_t>(offsetof(GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0, ___m_TripleClickSelectsLine_1)); }
	inline bool get_m_TripleClickSelectsLine_1() const { return ___m_TripleClickSelectsLine_1; }
	inline bool* get_address_of_m_TripleClickSelectsLine_1() { return &___m_TripleClickSelectsLine_1; }
	inline void set_m_TripleClickSelectsLine_1(bool value)
	{
		___m_TripleClickSelectsLine_1 = value;
	}

	inline static int32_t get_offset_of_m_CursorColor_2() { return static_cast<int32_t>(offsetof(GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0, ___m_CursorColor_2)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_CursorColor_2() const { return ___m_CursorColor_2; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_CursorColor_2() { return &___m_CursorColor_2; }
	inline void set_m_CursorColor_2(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_CursorColor_2 = value;
	}

	inline static int32_t get_offset_of_m_CursorFlashSpeed_3() { return static_cast<int32_t>(offsetof(GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0, ___m_CursorFlashSpeed_3)); }
	inline float get_m_CursorFlashSpeed_3() const { return ___m_CursorFlashSpeed_3; }
	inline float* get_address_of_m_CursorFlashSpeed_3() { return &___m_CursorFlashSpeed_3; }
	inline void set_m_CursorFlashSpeed_3(float value)
	{
		___m_CursorFlashSpeed_3 = value;
	}

	inline static int32_t get_offset_of_m_SelectionColor_4() { return static_cast<int32_t>(offsetof(GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0, ___m_SelectionColor_4)); }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  get_m_SelectionColor_4() const { return ___m_SelectionColor_4; }
	inline Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * get_address_of_m_SelectionColor_4() { return &___m_SelectionColor_4; }
	inline void set_m_SelectionColor_4(Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  value)
	{
		___m_SelectionColor_4 = value;
	}
};


// UnityEngine.GUIStyleState
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.GUIStyleState::m_Ptr
	intptr_t ___m_Ptr_0;
	// UnityEngine.GUIStyle UnityEngine.GUIStyleState::m_SourceStyle
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_SourceStyle_1;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}

	inline static int32_t get_offset_of_m_SourceStyle_1() { return static_cast<int32_t>(offsetof(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9, ___m_SourceStyle_1)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_SourceStyle_1() const { return ___m_SourceStyle_1; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_SourceStyle_1() { return &___m_SourceStyle_1; }
	inline void set_m_SourceStyle_1(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_SourceStyle_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SourceStyle_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.GUIStyleState
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke* ___m_SourceStyle_1;
};
// Native definition for COM marshalling of UnityEngine.GUIStyleState
struct GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com
{
	intptr_t ___m_Ptr_0;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com* ___m_SourceStyle_1;
};

// UnityEngine.ImagePosition
struct ImagePosition_t3DBA97C0793136D349135BC5E6814CFB2BE5A43A 
{
public:
	// System.Int32 UnityEngine.ImagePosition::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ImagePosition_t3DBA97C0793136D349135BC5E6814CFB2BE5A43A, ___value___2)); }
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


// System.Reflection.MethodInfo
struct MethodInfo_t  : public MethodBase_t
{
public:

public:
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

// UnityEngine.OperatingSystemFamily
struct OperatingSystemFamily_tA0F8964A9E51797792B4FCD070B5501858BEFC33 
{
public:
	// System.Int32 UnityEngine.OperatingSystemFamily::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(OperatingSystemFamily_tA0F8964A9E51797792B4FCD070B5501858BEFC33, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.PointerType
struct PointerType_tF1BDA571526A97FE995D6F8CE02E60B6D5245560 
{
public:
	// System.Int32 UnityEngine.PointerType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PointerType_tF1BDA571526A97FE995D6F8CE02E60B6D5245560, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.RectOffset
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.RectOffset::m_Ptr
	intptr_t ___m_Ptr_0;
	// System.Object UnityEngine.RectOffset::m_SourceStyle
	RuntimeObject * ___m_SourceStyle_1;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}

	inline static int32_t get_offset_of_m_SourceStyle_1() { return static_cast<int32_t>(offsetof(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70, ___m_SourceStyle_1)); }
	inline RuntimeObject * get_m_SourceStyle_1() const { return ___m_SourceStyle_1; }
	inline RuntimeObject ** get_address_of_m_SourceStyle_1() { return &___m_SourceStyle_1; }
	inline void set_m_SourceStyle_1(RuntimeObject * value)
	{
		___m_SourceStyle_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SourceStyle_1), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.RectOffset
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
	Il2CppIUnknown* ___m_SourceStyle_1;
};
// Native definition for COM marshalling of UnityEngine.RectOffset
struct RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com
{
	intptr_t ___m_Ptr_0;
	Il2CppIUnknown* ___m_SourceStyle_1;
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


// UnityEngine.ScaleMode
struct ScaleMode_t2D41D186D047D8156791981072D8E7F8759ABB49 
{
public:
	// System.Int32 UnityEngine.ScaleMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ScaleMode_t2D41D186D047D8156791981072D8E7F8759ABB49, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.ScrollViewState
struct ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0  : public RuntimeObject
{
public:
	// UnityEngine.Rect UnityEngine.ScrollViewState::position
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position_0;
	// UnityEngine.Rect UnityEngine.ScrollViewState::visibleRect
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___visibleRect_1;
	// UnityEngine.Rect UnityEngine.ScrollViewState::viewRect
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___viewRect_2;
	// UnityEngine.Vector2 UnityEngine.ScrollViewState::scrollPosition
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___scrollPosition_3;
	// System.Boolean UnityEngine.ScrollViewState::apply
	bool ___apply_4;
	// System.Boolean UnityEngine.ScrollViewState::isDuringTouchScroll
	bool ___isDuringTouchScroll_5;
	// UnityEngine.Vector2 UnityEngine.ScrollViewState::touchScrollStartMousePosition
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___touchScrollStartMousePosition_6;
	// UnityEngine.Vector2 UnityEngine.ScrollViewState::touchScrollStartPosition
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___touchScrollStartPosition_7;
	// UnityEngine.Vector2 UnityEngine.ScrollViewState::velocity
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___velocity_8;
	// System.Single UnityEngine.ScrollViewState::previousTimeSinceStartup
	float ___previousTimeSinceStartup_9;

public:
	inline static int32_t get_offset_of_position_0() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___position_0)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_position_0() const { return ___position_0; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_position_0() { return &___position_0; }
	inline void set_position_0(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___position_0 = value;
	}

	inline static int32_t get_offset_of_visibleRect_1() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___visibleRect_1)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_visibleRect_1() const { return ___visibleRect_1; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_visibleRect_1() { return &___visibleRect_1; }
	inline void set_visibleRect_1(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___visibleRect_1 = value;
	}

	inline static int32_t get_offset_of_viewRect_2() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___viewRect_2)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_viewRect_2() const { return ___viewRect_2; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_viewRect_2() { return &___viewRect_2; }
	inline void set_viewRect_2(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___viewRect_2 = value;
	}

	inline static int32_t get_offset_of_scrollPosition_3() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___scrollPosition_3)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_scrollPosition_3() const { return ___scrollPosition_3; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_scrollPosition_3() { return &___scrollPosition_3; }
	inline void set_scrollPosition_3(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___scrollPosition_3 = value;
	}

	inline static int32_t get_offset_of_apply_4() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___apply_4)); }
	inline bool get_apply_4() const { return ___apply_4; }
	inline bool* get_address_of_apply_4() { return &___apply_4; }
	inline void set_apply_4(bool value)
	{
		___apply_4 = value;
	}

	inline static int32_t get_offset_of_isDuringTouchScroll_5() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___isDuringTouchScroll_5)); }
	inline bool get_isDuringTouchScroll_5() const { return ___isDuringTouchScroll_5; }
	inline bool* get_address_of_isDuringTouchScroll_5() { return &___isDuringTouchScroll_5; }
	inline void set_isDuringTouchScroll_5(bool value)
	{
		___isDuringTouchScroll_5 = value;
	}

	inline static int32_t get_offset_of_touchScrollStartMousePosition_6() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___touchScrollStartMousePosition_6)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_touchScrollStartMousePosition_6() const { return ___touchScrollStartMousePosition_6; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_touchScrollStartMousePosition_6() { return &___touchScrollStartMousePosition_6; }
	inline void set_touchScrollStartMousePosition_6(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___touchScrollStartMousePosition_6 = value;
	}

	inline static int32_t get_offset_of_touchScrollStartPosition_7() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___touchScrollStartPosition_7)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_touchScrollStartPosition_7() const { return ___touchScrollStartPosition_7; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_touchScrollStartPosition_7() { return &___touchScrollStartPosition_7; }
	inline void set_touchScrollStartPosition_7(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___touchScrollStartPosition_7 = value;
	}

	inline static int32_t get_offset_of_velocity_8() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___velocity_8)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_velocity_8() const { return ___velocity_8; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_velocity_8() { return &___velocity_8; }
	inline void set_velocity_8(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___velocity_8 = value;
	}

	inline static int32_t get_offset_of_previousTimeSinceStartup_9() { return static_cast<int32_t>(offsetof(ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0, ___previousTimeSinceStartup_9)); }
	inline float get_previousTimeSinceStartup_9() const { return ___previousTimeSinceStartup_9; }
	inline float* get_address_of_previousTimeSinceStartup_9() { return &___previousTimeSinceStartup_9; }
	inline void set_previousTimeSinceStartup_9(float value)
	{
		___previousTimeSinceStartup_9 = value;
	}
};


// UnityEngine.SliderHandler
struct SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 
{
public:
	// UnityEngine.Rect UnityEngine.SliderHandler::position
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position_0;
	// System.Single UnityEngine.SliderHandler::currentValue
	float ___currentValue_1;
	// System.Single UnityEngine.SliderHandler::size
	float ___size_2;
	// System.Single UnityEngine.SliderHandler::start
	float ___start_3;
	// System.Single UnityEngine.SliderHandler::end
	float ___end_4;
	// UnityEngine.GUIStyle UnityEngine.SliderHandler::slider
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___slider_5;
	// UnityEngine.GUIStyle UnityEngine.SliderHandler::thumb
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___thumb_6;
	// UnityEngine.GUIStyle UnityEngine.SliderHandler::thumbExtent
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___thumbExtent_7;
	// System.Boolean UnityEngine.SliderHandler::horiz
	bool ___horiz_8;
	// System.Int32 UnityEngine.SliderHandler::id
	int32_t ___id_9;

public:
	inline static int32_t get_offset_of_position_0() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___position_0)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_position_0() const { return ___position_0; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_position_0() { return &___position_0; }
	inline void set_position_0(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___position_0 = value;
	}

	inline static int32_t get_offset_of_currentValue_1() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___currentValue_1)); }
	inline float get_currentValue_1() const { return ___currentValue_1; }
	inline float* get_address_of_currentValue_1() { return &___currentValue_1; }
	inline void set_currentValue_1(float value)
	{
		___currentValue_1 = value;
	}

	inline static int32_t get_offset_of_size_2() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___size_2)); }
	inline float get_size_2() const { return ___size_2; }
	inline float* get_address_of_size_2() { return &___size_2; }
	inline void set_size_2(float value)
	{
		___size_2 = value;
	}

	inline static int32_t get_offset_of_start_3() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___start_3)); }
	inline float get_start_3() const { return ___start_3; }
	inline float* get_address_of_start_3() { return &___start_3; }
	inline void set_start_3(float value)
	{
		___start_3 = value;
	}

	inline static int32_t get_offset_of_end_4() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___end_4)); }
	inline float get_end_4() const { return ___end_4; }
	inline float* get_address_of_end_4() { return &___end_4; }
	inline void set_end_4(float value)
	{
		___end_4 = value;
	}

	inline static int32_t get_offset_of_slider_5() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___slider_5)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_slider_5() const { return ___slider_5; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_slider_5() { return &___slider_5; }
	inline void set_slider_5(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___slider_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___slider_5), (void*)value);
	}

	inline static int32_t get_offset_of_thumb_6() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___thumb_6)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_thumb_6() const { return ___thumb_6; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_thumb_6() { return &___thumb_6; }
	inline void set_thumb_6(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___thumb_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___thumb_6), (void*)value);
	}

	inline static int32_t get_offset_of_thumbExtent_7() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___thumbExtent_7)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_thumbExtent_7() const { return ___thumbExtent_7; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_thumbExtent_7() { return &___thumbExtent_7; }
	inline void set_thumbExtent_7(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___thumbExtent_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___thumbExtent_7), (void*)value);
	}

	inline static int32_t get_offset_of_horiz_8() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___horiz_8)); }
	inline bool get_horiz_8() const { return ___horiz_8; }
	inline bool* get_address_of_horiz_8() { return &___horiz_8; }
	inline void set_horiz_8(bool value)
	{
		___horiz_8 = value;
	}

	inline static int32_t get_offset_of_id_9() { return static_cast<int32_t>(offsetof(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4, ___id_9)); }
	inline int32_t get_id_9() const { return ___id_9; }
	inline int32_t* get_address_of_id_9() { return &___id_9; }
	inline void set_id_9(int32_t value)
	{
		___id_9 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.SliderHandler
struct SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshaled_pinvoke
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position_0;
	float ___currentValue_1;
	float ___size_2;
	float ___start_3;
	float ___end_4;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke* ___slider_5;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke* ___thumb_6;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke* ___thumbExtent_7;
	int32_t ___horiz_8;
	int32_t ___id_9;
};
// Native definition for COM marshalling of UnityEngine.SliderHandler
struct SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshaled_com
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position_0;
	float ___currentValue_1;
	float ___size_2;
	float ___start_3;
	float ___end_4;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com* ___slider_5;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com* ___thumb_6;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com* ___thumbExtent_7;
	int32_t ___horiz_8;
	int32_t ___id_9;
};

// UnityEngine.TextAnchor
struct TextAnchor_tA4C88E77C2D7312F43412275B01E1341A7CB2232 
{
public:
	// System.Int32 UnityEngine.TextAnchor::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TextAnchor_tA4C88E77C2D7312F43412275B01E1341A7CB2232, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.TouchScreenKeyboard
struct TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.TouchScreenKeyboard::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};

struct TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E_StaticFields
{
public:
	// System.Boolean UnityEngine.TouchScreenKeyboard::<disableInPlaceEditing>k__BackingField
	bool ___U3CdisableInPlaceEditingU3Ek__BackingField_1;

public:
	inline static int32_t get_offset_of_U3CdisableInPlaceEditingU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E_StaticFields, ___U3CdisableInPlaceEditingU3Ek__BackingField_1)); }
	inline bool get_U3CdisableInPlaceEditingU3Ek__BackingField_1() const { return ___U3CdisableInPlaceEditingU3Ek__BackingField_1; }
	inline bool* get_address_of_U3CdisableInPlaceEditingU3Ek__BackingField_1() { return &___U3CdisableInPlaceEditingU3Ek__BackingField_1; }
	inline void set_U3CdisableInPlaceEditingU3Ek__BackingField_1(bool value)
	{
		___U3CdisableInPlaceEditingU3Ek__BackingField_1 = value;
	}
};


// UnityEngine.GUILayoutOption/Type
struct Type_t79FB5C82B695061CED8D628CBB6A1E8709705288 
{
public:
	// System.Int32 UnityEngine.GUILayoutOption/Type::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Type_t79FB5C82B695061CED8D628CBB6A1E8709705288, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.TextEditor/CharacterType
struct CharacterType_tF584197EB8E510A866DD31B2E88080F1FF8ED5F0 
{
public:
	// System.Int32 UnityEngine.TextEditor/CharacterType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(CharacterType_tF584197EB8E510A866DD31B2E88080F1FF8ED5F0, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.TextEditor/DblClickSnapping
struct DblClickSnapping_t831A23F3ECEF6C68B62B6C3AEAF870F70596FABD 
{
public:
	// System.Byte UnityEngine.TextEditor/DblClickSnapping::value__
	uint8_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DblClickSnapping_t831A23F3ECEF6C68B62B6C3AEAF870F70596FABD, ___value___2)); }
	inline uint8_t get_value___2() const { return ___value___2; }
	inline uint8_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint8_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.TextEditor/Direction
struct Direction_t8DFA98D0B9A87CC4CF5554D7550BB125CC5A6918 
{
public:
	// System.Int32 UnityEngine.TextEditor/Direction::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Direction_t8DFA98D0B9A87CC4CF5554D7550BB125CC5A6918, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.TextEditor/TextEditOp
struct TextEditOp_t6C6705A198EA7EFB55340BED1D58F28A1129A4DE 
{
public:
	// System.Int32 UnityEngine.TextEditor/TextEditOp::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(TextEditOp_t6C6705A198EA7EFB55340BED1D58F28A1129A4DE, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.ApplicationException
struct ApplicationException_t8D709C0445A040467C6A632AD7F742B25AB2A407  : public Exception_t
{
public:

public:
};


// UnityEngine.ExitGUIException
struct ExitGUIException_tA832626B99B4D827C8064643824847BCAA7877F4  : public Exception_t
{
public:

public:
};


// UnityEngine.Font
struct Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:
	// UnityEngine.Font/FontTextureRebuildCallback UnityEngine.Font::m_FontTextureRebuildCallback
	FontTextureRebuildCallback_tBF11A511EBD8D237A1C5885D460B42A45DDBB2DB * ___m_FontTextureRebuildCallback_5;

public:
	inline static int32_t get_offset_of_m_FontTextureRebuildCallback_5() { return static_cast<int32_t>(offsetof(Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9, ___m_FontTextureRebuildCallback_5)); }
	inline FontTextureRebuildCallback_tBF11A511EBD8D237A1C5885D460B42A45DDBB2DB * get_m_FontTextureRebuildCallback_5() const { return ___m_FontTextureRebuildCallback_5; }
	inline FontTextureRebuildCallback_tBF11A511EBD8D237A1C5885D460B42A45DDBB2DB ** get_address_of_m_FontTextureRebuildCallback_5() { return &___m_FontTextureRebuildCallback_5; }
	inline void set_m_FontTextureRebuildCallback_5(FontTextureRebuildCallback_tBF11A511EBD8D237A1C5885D460B42A45DDBB2DB * value)
	{
		___m_FontTextureRebuildCallback_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_FontTextureRebuildCallback_5), (void*)value);
	}
};

struct Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9_StaticFields
{
public:
	// System.Action`1<UnityEngine.Font> UnityEngine.Font::textureRebuilt
	Action_1_tC07E78969BFFC97261F80F4C08915A046DFDD9C7 * ___textureRebuilt_4;

public:
	inline static int32_t get_offset_of_textureRebuilt_4() { return static_cast<int32_t>(offsetof(Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9_StaticFields, ___textureRebuilt_4)); }
	inline Action_1_tC07E78969BFFC97261F80F4C08915A046DFDD9C7 * get_textureRebuilt_4() const { return ___textureRebuilt_4; }
	inline Action_1_tC07E78969BFFC97261F80F4C08915A046DFDD9C7 ** get_address_of_textureRebuilt_4() { return &___textureRebuilt_4; }
	inline void set_textureRebuilt_4(Action_1_tC07E78969BFFC97261F80F4C08915A046DFDD9C7 * value)
	{
		___textureRebuilt_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___textureRebuilt_4), (void*)value);
	}
};


// UnityEngine.GUILayoutGroup
struct GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9  : public GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE
{
public:
	// System.Collections.Generic.List`1<UnityEngine.GUILayoutEntry> UnityEngine.GUILayoutGroup::entries
	List_1_t07045BD0BCA84DF3EE9885C9BE0D1F6C57D208AA * ___entries_11;
	// System.Boolean UnityEngine.GUILayoutGroup::isVertical
	bool ___isVertical_12;
	// System.Boolean UnityEngine.GUILayoutGroup::resetCoords
	bool ___resetCoords_13;
	// System.Single UnityEngine.GUILayoutGroup::spacing
	float ___spacing_14;
	// System.Boolean UnityEngine.GUILayoutGroup::sameSize
	bool ___sameSize_15;
	// System.Boolean UnityEngine.GUILayoutGroup::isWindow
	bool ___isWindow_16;
	// System.Int32 UnityEngine.GUILayoutGroup::windowID
	int32_t ___windowID_17;
	// System.Int32 UnityEngine.GUILayoutGroup::m_Cursor
	int32_t ___m_Cursor_18;
	// System.Int32 UnityEngine.GUILayoutGroup::m_StretchableCountX
	int32_t ___m_StretchableCountX_19;
	// System.Int32 UnityEngine.GUILayoutGroup::m_StretchableCountY
	int32_t ___m_StretchableCountY_20;
	// System.Boolean UnityEngine.GUILayoutGroup::m_UserSpecifiedWidth
	bool ___m_UserSpecifiedWidth_21;
	// System.Boolean UnityEngine.GUILayoutGroup::m_UserSpecifiedHeight
	bool ___m_UserSpecifiedHeight_22;
	// System.Single UnityEngine.GUILayoutGroup::m_ChildMinWidth
	float ___m_ChildMinWidth_23;
	// System.Single UnityEngine.GUILayoutGroup::m_ChildMaxWidth
	float ___m_ChildMaxWidth_24;
	// System.Single UnityEngine.GUILayoutGroup::m_ChildMinHeight
	float ___m_ChildMinHeight_25;
	// System.Single UnityEngine.GUILayoutGroup::m_ChildMaxHeight
	float ___m_ChildMaxHeight_26;
	// System.Int32 UnityEngine.GUILayoutGroup::m_MarginLeft
	int32_t ___m_MarginLeft_27;
	// System.Int32 UnityEngine.GUILayoutGroup::m_MarginRight
	int32_t ___m_MarginRight_28;
	// System.Int32 UnityEngine.GUILayoutGroup::m_MarginTop
	int32_t ___m_MarginTop_29;
	// System.Int32 UnityEngine.GUILayoutGroup::m_MarginBottom
	int32_t ___m_MarginBottom_30;

public:
	inline static int32_t get_offset_of_entries_11() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___entries_11)); }
	inline List_1_t07045BD0BCA84DF3EE9885C9BE0D1F6C57D208AA * get_entries_11() const { return ___entries_11; }
	inline List_1_t07045BD0BCA84DF3EE9885C9BE0D1F6C57D208AA ** get_address_of_entries_11() { return &___entries_11; }
	inline void set_entries_11(List_1_t07045BD0BCA84DF3EE9885C9BE0D1F6C57D208AA * value)
	{
		___entries_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___entries_11), (void*)value);
	}

	inline static int32_t get_offset_of_isVertical_12() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___isVertical_12)); }
	inline bool get_isVertical_12() const { return ___isVertical_12; }
	inline bool* get_address_of_isVertical_12() { return &___isVertical_12; }
	inline void set_isVertical_12(bool value)
	{
		___isVertical_12 = value;
	}

	inline static int32_t get_offset_of_resetCoords_13() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___resetCoords_13)); }
	inline bool get_resetCoords_13() const { return ___resetCoords_13; }
	inline bool* get_address_of_resetCoords_13() { return &___resetCoords_13; }
	inline void set_resetCoords_13(bool value)
	{
		___resetCoords_13 = value;
	}

	inline static int32_t get_offset_of_spacing_14() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___spacing_14)); }
	inline float get_spacing_14() const { return ___spacing_14; }
	inline float* get_address_of_spacing_14() { return &___spacing_14; }
	inline void set_spacing_14(float value)
	{
		___spacing_14 = value;
	}

	inline static int32_t get_offset_of_sameSize_15() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___sameSize_15)); }
	inline bool get_sameSize_15() const { return ___sameSize_15; }
	inline bool* get_address_of_sameSize_15() { return &___sameSize_15; }
	inline void set_sameSize_15(bool value)
	{
		___sameSize_15 = value;
	}

	inline static int32_t get_offset_of_isWindow_16() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___isWindow_16)); }
	inline bool get_isWindow_16() const { return ___isWindow_16; }
	inline bool* get_address_of_isWindow_16() { return &___isWindow_16; }
	inline void set_isWindow_16(bool value)
	{
		___isWindow_16 = value;
	}

	inline static int32_t get_offset_of_windowID_17() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___windowID_17)); }
	inline int32_t get_windowID_17() const { return ___windowID_17; }
	inline int32_t* get_address_of_windowID_17() { return &___windowID_17; }
	inline void set_windowID_17(int32_t value)
	{
		___windowID_17 = value;
	}

	inline static int32_t get_offset_of_m_Cursor_18() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_Cursor_18)); }
	inline int32_t get_m_Cursor_18() const { return ___m_Cursor_18; }
	inline int32_t* get_address_of_m_Cursor_18() { return &___m_Cursor_18; }
	inline void set_m_Cursor_18(int32_t value)
	{
		___m_Cursor_18 = value;
	}

	inline static int32_t get_offset_of_m_StretchableCountX_19() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_StretchableCountX_19)); }
	inline int32_t get_m_StretchableCountX_19() const { return ___m_StretchableCountX_19; }
	inline int32_t* get_address_of_m_StretchableCountX_19() { return &___m_StretchableCountX_19; }
	inline void set_m_StretchableCountX_19(int32_t value)
	{
		___m_StretchableCountX_19 = value;
	}

	inline static int32_t get_offset_of_m_StretchableCountY_20() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_StretchableCountY_20)); }
	inline int32_t get_m_StretchableCountY_20() const { return ___m_StretchableCountY_20; }
	inline int32_t* get_address_of_m_StretchableCountY_20() { return &___m_StretchableCountY_20; }
	inline void set_m_StretchableCountY_20(int32_t value)
	{
		___m_StretchableCountY_20 = value;
	}

	inline static int32_t get_offset_of_m_UserSpecifiedWidth_21() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_UserSpecifiedWidth_21)); }
	inline bool get_m_UserSpecifiedWidth_21() const { return ___m_UserSpecifiedWidth_21; }
	inline bool* get_address_of_m_UserSpecifiedWidth_21() { return &___m_UserSpecifiedWidth_21; }
	inline void set_m_UserSpecifiedWidth_21(bool value)
	{
		___m_UserSpecifiedWidth_21 = value;
	}

	inline static int32_t get_offset_of_m_UserSpecifiedHeight_22() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_UserSpecifiedHeight_22)); }
	inline bool get_m_UserSpecifiedHeight_22() const { return ___m_UserSpecifiedHeight_22; }
	inline bool* get_address_of_m_UserSpecifiedHeight_22() { return &___m_UserSpecifiedHeight_22; }
	inline void set_m_UserSpecifiedHeight_22(bool value)
	{
		___m_UserSpecifiedHeight_22 = value;
	}

	inline static int32_t get_offset_of_m_ChildMinWidth_23() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_ChildMinWidth_23)); }
	inline float get_m_ChildMinWidth_23() const { return ___m_ChildMinWidth_23; }
	inline float* get_address_of_m_ChildMinWidth_23() { return &___m_ChildMinWidth_23; }
	inline void set_m_ChildMinWidth_23(float value)
	{
		___m_ChildMinWidth_23 = value;
	}

	inline static int32_t get_offset_of_m_ChildMaxWidth_24() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_ChildMaxWidth_24)); }
	inline float get_m_ChildMaxWidth_24() const { return ___m_ChildMaxWidth_24; }
	inline float* get_address_of_m_ChildMaxWidth_24() { return &___m_ChildMaxWidth_24; }
	inline void set_m_ChildMaxWidth_24(float value)
	{
		___m_ChildMaxWidth_24 = value;
	}

	inline static int32_t get_offset_of_m_ChildMinHeight_25() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_ChildMinHeight_25)); }
	inline float get_m_ChildMinHeight_25() const { return ___m_ChildMinHeight_25; }
	inline float* get_address_of_m_ChildMinHeight_25() { return &___m_ChildMinHeight_25; }
	inline void set_m_ChildMinHeight_25(float value)
	{
		___m_ChildMinHeight_25 = value;
	}

	inline static int32_t get_offset_of_m_ChildMaxHeight_26() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_ChildMaxHeight_26)); }
	inline float get_m_ChildMaxHeight_26() const { return ___m_ChildMaxHeight_26; }
	inline float* get_address_of_m_ChildMaxHeight_26() { return &___m_ChildMaxHeight_26; }
	inline void set_m_ChildMaxHeight_26(float value)
	{
		___m_ChildMaxHeight_26 = value;
	}

	inline static int32_t get_offset_of_m_MarginLeft_27() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_MarginLeft_27)); }
	inline int32_t get_m_MarginLeft_27() const { return ___m_MarginLeft_27; }
	inline int32_t* get_address_of_m_MarginLeft_27() { return &___m_MarginLeft_27; }
	inline void set_m_MarginLeft_27(int32_t value)
	{
		___m_MarginLeft_27 = value;
	}

	inline static int32_t get_offset_of_m_MarginRight_28() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_MarginRight_28)); }
	inline int32_t get_m_MarginRight_28() const { return ___m_MarginRight_28; }
	inline int32_t* get_address_of_m_MarginRight_28() { return &___m_MarginRight_28; }
	inline void set_m_MarginRight_28(int32_t value)
	{
		___m_MarginRight_28 = value;
	}

	inline static int32_t get_offset_of_m_MarginTop_29() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_MarginTop_29)); }
	inline int32_t get_m_MarginTop_29() const { return ___m_MarginTop_29; }
	inline int32_t* get_address_of_m_MarginTop_29() { return &___m_MarginTop_29; }
	inline void set_m_MarginTop_29(int32_t value)
	{
		___m_MarginTop_29 = value;
	}

	inline static int32_t get_offset_of_m_MarginBottom_30() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9, ___m_MarginBottom_30)); }
	inline int32_t get_m_MarginBottom_30() const { return ___m_MarginBottom_30; }
	inline int32_t* get_address_of_m_MarginBottom_30() { return &___m_MarginBottom_30; }
	inline void set_m_MarginBottom_30(int32_t value)
	{
		___m_MarginBottom_30 = value;
	}
};

struct GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9_StaticFields
{
public:
	// UnityEngine.GUILayoutEntry UnityEngine.GUILayoutGroup::none
	GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE * ___none_31;

public:
	inline static int32_t get_offset_of_none_31() { return static_cast<int32_t>(offsetof(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9_StaticFields, ___none_31)); }
	inline GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE * get_none_31() const { return ___none_31; }
	inline GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE ** get_address_of_none_31() { return &___none_31; }
	inline void set_none_31(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE * value)
	{
		___none_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___none_31), (void*)value);
	}
};


// UnityEngine.GUILayoutOption
struct GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB  : public RuntimeObject
{
public:
	// UnityEngine.GUILayoutOption/Type UnityEngine.GUILayoutOption::type
	int32_t ___type_0;
	// System.Object UnityEngine.GUILayoutOption::value
	RuntimeObject * ___value_1;

public:
	inline static int32_t get_offset_of_type_0() { return static_cast<int32_t>(offsetof(GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB, ___type_0)); }
	inline int32_t get_type_0() const { return ___type_0; }
	inline int32_t* get_address_of_type_0() { return &___type_0; }
	inline void set_type_0(int32_t value)
	{
		___type_0 = value;
	}

	inline static int32_t get_offset_of_value_1() { return static_cast<int32_t>(offsetof(GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB, ___value_1)); }
	inline RuntimeObject * get_value_1() const { return ___value_1; }
	inline RuntimeObject ** get_address_of_value_1() { return &___value_1; }
	inline void set_value_1(RuntimeObject * value)
	{
		___value_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___value_1), (void*)value);
	}
};


// UnityEngine.GUIStyle
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.GUIStyle::m_Ptr
	intptr_t ___m_Ptr_0;
	// UnityEngine.GUIStyleState UnityEngine.GUIStyle::m_Normal
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * ___m_Normal_1;
	// UnityEngine.GUIStyleState UnityEngine.GUIStyle::m_Hover
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * ___m_Hover_2;
	// UnityEngine.GUIStyleState UnityEngine.GUIStyle::m_Active
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * ___m_Active_3;
	// UnityEngine.GUIStyleState UnityEngine.GUIStyle::m_Focused
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * ___m_Focused_4;
	// UnityEngine.GUIStyleState UnityEngine.GUIStyle::m_OnNormal
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * ___m_OnNormal_5;
	// UnityEngine.GUIStyleState UnityEngine.GUIStyle::m_OnHover
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * ___m_OnHover_6;
	// UnityEngine.GUIStyleState UnityEngine.GUIStyle::m_OnActive
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * ___m_OnActive_7;
	// UnityEngine.GUIStyleState UnityEngine.GUIStyle::m_OnFocused
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * ___m_OnFocused_8;
	// UnityEngine.RectOffset UnityEngine.GUIStyle::m_Border
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * ___m_Border_9;
	// UnityEngine.RectOffset UnityEngine.GUIStyle::m_Padding
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * ___m_Padding_10;
	// UnityEngine.RectOffset UnityEngine.GUIStyle::m_Margin
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * ___m_Margin_11;
	// UnityEngine.RectOffset UnityEngine.GUIStyle::m_Overflow
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * ___m_Overflow_12;
	// System.String UnityEngine.GUIStyle::m_Name
	String_t* ___m_Name_13;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}

	inline static int32_t get_offset_of_m_Normal_1() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Normal_1)); }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * get_m_Normal_1() const { return ___m_Normal_1; }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 ** get_address_of_m_Normal_1() { return &___m_Normal_1; }
	inline void set_m_Normal_1(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * value)
	{
		___m_Normal_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Normal_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_Hover_2() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Hover_2)); }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * get_m_Hover_2() const { return ___m_Hover_2; }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 ** get_address_of_m_Hover_2() { return &___m_Hover_2; }
	inline void set_m_Hover_2(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * value)
	{
		___m_Hover_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Hover_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_Active_3() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Active_3)); }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * get_m_Active_3() const { return ___m_Active_3; }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 ** get_address_of_m_Active_3() { return &___m_Active_3; }
	inline void set_m_Active_3(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * value)
	{
		___m_Active_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Active_3), (void*)value);
	}

	inline static int32_t get_offset_of_m_Focused_4() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Focused_4)); }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * get_m_Focused_4() const { return ___m_Focused_4; }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 ** get_address_of_m_Focused_4() { return &___m_Focused_4; }
	inline void set_m_Focused_4(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * value)
	{
		___m_Focused_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Focused_4), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnNormal_5() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_OnNormal_5)); }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * get_m_OnNormal_5() const { return ___m_OnNormal_5; }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 ** get_address_of_m_OnNormal_5() { return &___m_OnNormal_5; }
	inline void set_m_OnNormal_5(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * value)
	{
		___m_OnNormal_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnNormal_5), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnHover_6() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_OnHover_6)); }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * get_m_OnHover_6() const { return ___m_OnHover_6; }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 ** get_address_of_m_OnHover_6() { return &___m_OnHover_6; }
	inline void set_m_OnHover_6(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * value)
	{
		___m_OnHover_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnHover_6), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnActive_7() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_OnActive_7)); }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * get_m_OnActive_7() const { return ___m_OnActive_7; }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 ** get_address_of_m_OnActive_7() { return &___m_OnActive_7; }
	inline void set_m_OnActive_7(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * value)
	{
		___m_OnActive_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnActive_7), (void*)value);
	}

	inline static int32_t get_offset_of_m_OnFocused_8() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_OnFocused_8)); }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * get_m_OnFocused_8() const { return ___m_OnFocused_8; }
	inline GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 ** get_address_of_m_OnFocused_8() { return &___m_OnFocused_8; }
	inline void set_m_OnFocused_8(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * value)
	{
		___m_OnFocused_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_OnFocused_8), (void*)value);
	}

	inline static int32_t get_offset_of_m_Border_9() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Border_9)); }
	inline RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * get_m_Border_9() const { return ___m_Border_9; }
	inline RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 ** get_address_of_m_Border_9() { return &___m_Border_9; }
	inline void set_m_Border_9(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * value)
	{
		___m_Border_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Border_9), (void*)value);
	}

	inline static int32_t get_offset_of_m_Padding_10() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Padding_10)); }
	inline RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * get_m_Padding_10() const { return ___m_Padding_10; }
	inline RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 ** get_address_of_m_Padding_10() { return &___m_Padding_10; }
	inline void set_m_Padding_10(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * value)
	{
		___m_Padding_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Padding_10), (void*)value);
	}

	inline static int32_t get_offset_of_m_Margin_11() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Margin_11)); }
	inline RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * get_m_Margin_11() const { return ___m_Margin_11; }
	inline RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 ** get_address_of_m_Margin_11() { return &___m_Margin_11; }
	inline void set_m_Margin_11(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * value)
	{
		___m_Margin_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Margin_11), (void*)value);
	}

	inline static int32_t get_offset_of_m_Overflow_12() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Overflow_12)); }
	inline RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * get_m_Overflow_12() const { return ___m_Overflow_12; }
	inline RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 ** get_address_of_m_Overflow_12() { return &___m_Overflow_12; }
	inline void set_m_Overflow_12(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * value)
	{
		___m_Overflow_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Overflow_12), (void*)value);
	}

	inline static int32_t get_offset_of_m_Name_13() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726, ___m_Name_13)); }
	inline String_t* get_m_Name_13() const { return ___m_Name_13; }
	inline String_t** get_address_of_m_Name_13() { return &___m_Name_13; }
	inline void set_m_Name_13(String_t* value)
	{
		___m_Name_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Name_13), (void*)value);
	}
};

struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_StaticFields
{
public:
	// System.Boolean UnityEngine.GUIStyle::showKeyboardFocus
	bool ___showKeyboardFocus_14;
	// UnityEngine.GUIStyle UnityEngine.GUIStyle::s_None
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___s_None_15;

public:
	inline static int32_t get_offset_of_showKeyboardFocus_14() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_StaticFields, ___showKeyboardFocus_14)); }
	inline bool get_showKeyboardFocus_14() const { return ___showKeyboardFocus_14; }
	inline bool* get_address_of_showKeyboardFocus_14() { return &___showKeyboardFocus_14; }
	inline void set_showKeyboardFocus_14(bool value)
	{
		___showKeyboardFocus_14 = value;
	}

	inline static int32_t get_offset_of_s_None_15() { return static_cast<int32_t>(offsetof(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_StaticFields, ___s_None_15)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_s_None_15() const { return ___s_None_15; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_s_None_15() { return &___s_None_15; }
	inline void set_s_None_15(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___s_None_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_None_15), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.GUIStyle
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke* ___m_Normal_1;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke* ___m_Hover_2;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke* ___m_Active_3;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke* ___m_Focused_4;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke* ___m_OnNormal_5;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke* ___m_OnHover_6;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke* ___m_OnActive_7;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke* ___m_OnFocused_8;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke ___m_Border_9;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke ___m_Padding_10;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke ___m_Margin_11;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke ___m_Overflow_12;
	char* ___m_Name_13;
};
// Native definition for COM marshalling of UnityEngine.GUIStyle
struct GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com
{
	intptr_t ___m_Ptr_0;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com* ___m_Normal_1;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com* ___m_Hover_2;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com* ___m_Active_3;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com* ___m_Focused_4;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com* ___m_OnNormal_5;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com* ___m_OnHover_6;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com* ___m_OnActive_7;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com* ___m_OnFocused_8;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com* ___m_Border_9;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com* ___m_Padding_10;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com* ___m_Margin_11;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com* ___m_Overflow_12;
	Il2CppChar* ___m_Name_13;
};

// UnityEngine.GUIWordWrapSizer
struct GUIWordWrapSizer_t2DC4A7EB6C47F17F06154C2605F4E522D1334D5D  : public GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE
{
public:
	// UnityEngine.GUIContent UnityEngine.GUIWordWrapSizer::m_Content
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___m_Content_11;
	// System.Single UnityEngine.GUIWordWrapSizer::m_ForcedMinHeight
	float ___m_ForcedMinHeight_12;
	// System.Single UnityEngine.GUIWordWrapSizer::m_ForcedMaxHeight
	float ___m_ForcedMaxHeight_13;

public:
	inline static int32_t get_offset_of_m_Content_11() { return static_cast<int32_t>(offsetof(GUIWordWrapSizer_t2DC4A7EB6C47F17F06154C2605F4E522D1334D5D, ___m_Content_11)); }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * get_m_Content_11() const { return ___m_Content_11; }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E ** get_address_of_m_Content_11() { return &___m_Content_11; }
	inline void set_m_Content_11(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * value)
	{
		___m_Content_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Content_11), (void*)value);
	}

	inline static int32_t get_offset_of_m_ForcedMinHeight_12() { return static_cast<int32_t>(offsetof(GUIWordWrapSizer_t2DC4A7EB6C47F17F06154C2605F4E522D1334D5D, ___m_ForcedMinHeight_12)); }
	inline float get_m_ForcedMinHeight_12() const { return ___m_ForcedMinHeight_12; }
	inline float* get_address_of_m_ForcedMinHeight_12() { return &___m_ForcedMinHeight_12; }
	inline void set_m_ForcedMinHeight_12(float value)
	{
		___m_ForcedMinHeight_12 = value;
	}

	inline static int32_t get_offset_of_m_ForcedMaxHeight_13() { return static_cast<int32_t>(offsetof(GUIWordWrapSizer_t2DC4A7EB6C47F17F06154C2605F4E522D1334D5D, ___m_ForcedMaxHeight_13)); }
	inline float get_m_ForcedMaxHeight_13() const { return ___m_ForcedMaxHeight_13; }
	inline float* get_address_of_m_ForcedMaxHeight_13() { return &___m_ForcedMaxHeight_13; }
	inline void set_m_ForcedMaxHeight_13(float value)
	{
		___m_ForcedMaxHeight_13 = value;
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

// UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};

// Native definition for P/Invoke marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A_marshaled_pinvoke : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A_marshaled_com : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com
{
};

// System.SystemException
struct SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62  : public Exception_t
{
public:

public:
};


// UnityEngine.TextEditor
struct TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B  : public RuntimeObject
{
public:
	// UnityEngine.TouchScreenKeyboard UnityEngine.TextEditor::keyboardOnScreen
	TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E * ___keyboardOnScreen_0;
	// System.Int32 UnityEngine.TextEditor::controlID
	int32_t ___controlID_1;
	// UnityEngine.GUIStyle UnityEngine.TextEditor::style
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___style_2;
	// System.Boolean UnityEngine.TextEditor::multiline
	bool ___multiline_3;
	// System.Boolean UnityEngine.TextEditor::hasHorizontalCursorPos
	bool ___hasHorizontalCursorPos_4;
	// System.Boolean UnityEngine.TextEditor::isPasswordField
	bool ___isPasswordField_5;
	// System.Boolean UnityEngine.TextEditor::m_HasFocus
	bool ___m_HasFocus_6;
	// UnityEngine.Vector2 UnityEngine.TextEditor::scrollOffset
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___scrollOffset_7;
	// UnityEngine.GUIContent UnityEngine.TextEditor::m_Content
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___m_Content_8;
	// UnityEngine.Rect UnityEngine.TextEditor::m_Position
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___m_Position_9;
	// System.Int32 UnityEngine.TextEditor::m_CursorIndex
	int32_t ___m_CursorIndex_10;
	// System.Int32 UnityEngine.TextEditor::m_SelectIndex
	int32_t ___m_SelectIndex_11;
	// System.Boolean UnityEngine.TextEditor::m_RevealCursor
	bool ___m_RevealCursor_12;
	// UnityEngine.Vector2 UnityEngine.TextEditor::graphicalCursorPos
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___graphicalCursorPos_13;
	// UnityEngine.Vector2 UnityEngine.TextEditor::graphicalSelectCursorPos
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___graphicalSelectCursorPos_14;
	// System.Boolean UnityEngine.TextEditor::m_MouseDragSelectsWholeWords
	bool ___m_MouseDragSelectsWholeWords_15;
	// System.Int32 UnityEngine.TextEditor::m_DblClickInitPos
	int32_t ___m_DblClickInitPos_16;
	// UnityEngine.TextEditor/DblClickSnapping UnityEngine.TextEditor::m_DblClickSnap
	uint8_t ___m_DblClickSnap_17;
	// System.Boolean UnityEngine.TextEditor::m_bJustSelected
	bool ___m_bJustSelected_18;
	// System.Int32 UnityEngine.TextEditor::m_iAltCursorPos
	int32_t ___m_iAltCursorPos_19;
	// System.String UnityEngine.TextEditor::oldText
	String_t* ___oldText_20;
	// System.Int32 UnityEngine.TextEditor::oldPos
	int32_t ___oldPos_21;
	// System.Int32 UnityEngine.TextEditor::oldSelectPos
	int32_t ___oldSelectPos_22;

public:
	inline static int32_t get_offset_of_keyboardOnScreen_0() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___keyboardOnScreen_0)); }
	inline TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E * get_keyboardOnScreen_0() const { return ___keyboardOnScreen_0; }
	inline TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E ** get_address_of_keyboardOnScreen_0() { return &___keyboardOnScreen_0; }
	inline void set_keyboardOnScreen_0(TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E * value)
	{
		___keyboardOnScreen_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___keyboardOnScreen_0), (void*)value);
	}

	inline static int32_t get_offset_of_controlID_1() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___controlID_1)); }
	inline int32_t get_controlID_1() const { return ___controlID_1; }
	inline int32_t* get_address_of_controlID_1() { return &___controlID_1; }
	inline void set_controlID_1(int32_t value)
	{
		___controlID_1 = value;
	}

	inline static int32_t get_offset_of_style_2() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___style_2)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_style_2() const { return ___style_2; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_style_2() { return &___style_2; }
	inline void set_style_2(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___style_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___style_2), (void*)value);
	}

	inline static int32_t get_offset_of_multiline_3() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___multiline_3)); }
	inline bool get_multiline_3() const { return ___multiline_3; }
	inline bool* get_address_of_multiline_3() { return &___multiline_3; }
	inline void set_multiline_3(bool value)
	{
		___multiline_3 = value;
	}

	inline static int32_t get_offset_of_hasHorizontalCursorPos_4() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___hasHorizontalCursorPos_4)); }
	inline bool get_hasHorizontalCursorPos_4() const { return ___hasHorizontalCursorPos_4; }
	inline bool* get_address_of_hasHorizontalCursorPos_4() { return &___hasHorizontalCursorPos_4; }
	inline void set_hasHorizontalCursorPos_4(bool value)
	{
		___hasHorizontalCursorPos_4 = value;
	}

	inline static int32_t get_offset_of_isPasswordField_5() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___isPasswordField_5)); }
	inline bool get_isPasswordField_5() const { return ___isPasswordField_5; }
	inline bool* get_address_of_isPasswordField_5() { return &___isPasswordField_5; }
	inline void set_isPasswordField_5(bool value)
	{
		___isPasswordField_5 = value;
	}

	inline static int32_t get_offset_of_m_HasFocus_6() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_HasFocus_6)); }
	inline bool get_m_HasFocus_6() const { return ___m_HasFocus_6; }
	inline bool* get_address_of_m_HasFocus_6() { return &___m_HasFocus_6; }
	inline void set_m_HasFocus_6(bool value)
	{
		___m_HasFocus_6 = value;
	}

	inline static int32_t get_offset_of_scrollOffset_7() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___scrollOffset_7)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_scrollOffset_7() const { return ___scrollOffset_7; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_scrollOffset_7() { return &___scrollOffset_7; }
	inline void set_scrollOffset_7(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___scrollOffset_7 = value;
	}

	inline static int32_t get_offset_of_m_Content_8() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_Content_8)); }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * get_m_Content_8() const { return ___m_Content_8; }
	inline GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E ** get_address_of_m_Content_8() { return &___m_Content_8; }
	inline void set_m_Content_8(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * value)
	{
		___m_Content_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Content_8), (void*)value);
	}

	inline static int32_t get_offset_of_m_Position_9() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_Position_9)); }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  get_m_Position_9() const { return ___m_Position_9; }
	inline Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * get_address_of_m_Position_9() { return &___m_Position_9; }
	inline void set_m_Position_9(Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  value)
	{
		___m_Position_9 = value;
	}

	inline static int32_t get_offset_of_m_CursorIndex_10() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_CursorIndex_10)); }
	inline int32_t get_m_CursorIndex_10() const { return ___m_CursorIndex_10; }
	inline int32_t* get_address_of_m_CursorIndex_10() { return &___m_CursorIndex_10; }
	inline void set_m_CursorIndex_10(int32_t value)
	{
		___m_CursorIndex_10 = value;
	}

	inline static int32_t get_offset_of_m_SelectIndex_11() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_SelectIndex_11)); }
	inline int32_t get_m_SelectIndex_11() const { return ___m_SelectIndex_11; }
	inline int32_t* get_address_of_m_SelectIndex_11() { return &___m_SelectIndex_11; }
	inline void set_m_SelectIndex_11(int32_t value)
	{
		___m_SelectIndex_11 = value;
	}

	inline static int32_t get_offset_of_m_RevealCursor_12() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_RevealCursor_12)); }
	inline bool get_m_RevealCursor_12() const { return ___m_RevealCursor_12; }
	inline bool* get_address_of_m_RevealCursor_12() { return &___m_RevealCursor_12; }
	inline void set_m_RevealCursor_12(bool value)
	{
		___m_RevealCursor_12 = value;
	}

	inline static int32_t get_offset_of_graphicalCursorPos_13() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___graphicalCursorPos_13)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_graphicalCursorPos_13() const { return ___graphicalCursorPos_13; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_graphicalCursorPos_13() { return &___graphicalCursorPos_13; }
	inline void set_graphicalCursorPos_13(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___graphicalCursorPos_13 = value;
	}

	inline static int32_t get_offset_of_graphicalSelectCursorPos_14() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___graphicalSelectCursorPos_14)); }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  get_graphicalSelectCursorPos_14() const { return ___graphicalSelectCursorPos_14; }
	inline Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * get_address_of_graphicalSelectCursorPos_14() { return &___graphicalSelectCursorPos_14; }
	inline void set_graphicalSelectCursorPos_14(Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  value)
	{
		___graphicalSelectCursorPos_14 = value;
	}

	inline static int32_t get_offset_of_m_MouseDragSelectsWholeWords_15() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_MouseDragSelectsWholeWords_15)); }
	inline bool get_m_MouseDragSelectsWholeWords_15() const { return ___m_MouseDragSelectsWholeWords_15; }
	inline bool* get_address_of_m_MouseDragSelectsWholeWords_15() { return &___m_MouseDragSelectsWholeWords_15; }
	inline void set_m_MouseDragSelectsWholeWords_15(bool value)
	{
		___m_MouseDragSelectsWholeWords_15 = value;
	}

	inline static int32_t get_offset_of_m_DblClickInitPos_16() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_DblClickInitPos_16)); }
	inline int32_t get_m_DblClickInitPos_16() const { return ___m_DblClickInitPos_16; }
	inline int32_t* get_address_of_m_DblClickInitPos_16() { return &___m_DblClickInitPos_16; }
	inline void set_m_DblClickInitPos_16(int32_t value)
	{
		___m_DblClickInitPos_16 = value;
	}

	inline static int32_t get_offset_of_m_DblClickSnap_17() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_DblClickSnap_17)); }
	inline uint8_t get_m_DblClickSnap_17() const { return ___m_DblClickSnap_17; }
	inline uint8_t* get_address_of_m_DblClickSnap_17() { return &___m_DblClickSnap_17; }
	inline void set_m_DblClickSnap_17(uint8_t value)
	{
		___m_DblClickSnap_17 = value;
	}

	inline static int32_t get_offset_of_m_bJustSelected_18() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_bJustSelected_18)); }
	inline bool get_m_bJustSelected_18() const { return ___m_bJustSelected_18; }
	inline bool* get_address_of_m_bJustSelected_18() { return &___m_bJustSelected_18; }
	inline void set_m_bJustSelected_18(bool value)
	{
		___m_bJustSelected_18 = value;
	}

	inline static int32_t get_offset_of_m_iAltCursorPos_19() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___m_iAltCursorPos_19)); }
	inline int32_t get_m_iAltCursorPos_19() const { return ___m_iAltCursorPos_19; }
	inline int32_t* get_address_of_m_iAltCursorPos_19() { return &___m_iAltCursorPos_19; }
	inline void set_m_iAltCursorPos_19(int32_t value)
	{
		___m_iAltCursorPos_19 = value;
	}

	inline static int32_t get_offset_of_oldText_20() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___oldText_20)); }
	inline String_t* get_oldText_20() const { return ___oldText_20; }
	inline String_t** get_address_of_oldText_20() { return &___oldText_20; }
	inline void set_oldText_20(String_t* value)
	{
		___oldText_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___oldText_20), (void*)value);
	}

	inline static int32_t get_offset_of_oldPos_21() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___oldPos_21)); }
	inline int32_t get_oldPos_21() const { return ___oldPos_21; }
	inline int32_t* get_address_of_oldPos_21() { return &___oldPos_21; }
	inline void set_oldPos_21(int32_t value)
	{
		___oldPos_21 = value;
	}

	inline static int32_t get_offset_of_oldSelectPos_22() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B, ___oldSelectPos_22)); }
	inline int32_t get_oldSelectPos_22() const { return ___oldSelectPos_22; }
	inline int32_t* get_address_of_oldSelectPos_22() { return &___oldSelectPos_22; }
	inline void set_oldSelectPos_22(int32_t value)
	{
		___oldSelectPos_22 = value;
	}
};

struct TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp> UnityEngine.TextEditor::s_Keyactions
	Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * ___s_Keyactions_23;

public:
	inline static int32_t get_offset_of_s_Keyactions_23() { return static_cast<int32_t>(offsetof(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_StaticFields, ___s_Keyactions_23)); }
	inline Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * get_s_Keyactions_23() const { return ___s_Keyactions_23; }
	inline Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 ** get_address_of_s_Keyactions_23() { return &___s_Keyactions_23; }
	inline void set_s_Keyactions_23(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * value)
	{
		___s_Keyactions_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_Keyactions_23), (void*)value);
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


// System.Func`1<System.Boolean>
struct Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`2<System.Exception,System.Boolean>
struct Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F  : public MulticastDelegate_t
{
public:

public:
};


// System.Func`3<System.Int32,System.IntPtr,System.Boolean>
struct Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0  : public MulticastDelegate_t
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


// UnityEngine.GUISkin
struct GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6  : public ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A
{
public:
	// UnityEngine.Font UnityEngine.GUISkin::m_Font
	Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * ___m_Font_4;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_box
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_box_5;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_button
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_button_6;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_toggle
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_toggle_7;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_label
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_label_8;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_textField
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_textField_9;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_textArea
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_textArea_10;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_window
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_window_11;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_horizontalSlider
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_horizontalSlider_12;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_horizontalSliderThumb
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_horizontalSliderThumb_13;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_horizontalSliderThumbExtent
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_horizontalSliderThumbExtent_14;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_verticalSlider
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_verticalSlider_15;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_verticalSliderThumb
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_verticalSliderThumb_16;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_verticalSliderThumbExtent
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_verticalSliderThumbExtent_17;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_SliderMixed
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_SliderMixed_18;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_horizontalScrollbar
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_horizontalScrollbar_19;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_horizontalScrollbarThumb
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_horizontalScrollbarThumb_20;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_horizontalScrollbarLeftButton
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_horizontalScrollbarLeftButton_21;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_horizontalScrollbarRightButton
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_horizontalScrollbarRightButton_22;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_verticalScrollbar
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_verticalScrollbar_23;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_verticalScrollbarThumb
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_verticalScrollbarThumb_24;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_verticalScrollbarUpButton
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_verticalScrollbarUpButton_25;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_verticalScrollbarDownButton
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_verticalScrollbarDownButton_26;
	// UnityEngine.GUIStyle UnityEngine.GUISkin::m_ScrollView
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___m_ScrollView_27;
	// UnityEngine.GUIStyle[] UnityEngine.GUISkin::m_CustomStyles
	GUIStyleU5BU5D_t99FB75A2EC4777ADECDE02F71A619CFBFC0F4F70* ___m_CustomStyles_28;
	// UnityEngine.GUISettings UnityEngine.GUISkin::m_Settings
	GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * ___m_Settings_29;
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.GUIStyle> UnityEngine.GUISkin::m_Styles
	Dictionary_2_t2CD153A36C5BD27CDDC85F23918ECEF77E892E80 * ___m_Styles_31;

public:
	inline static int32_t get_offset_of_m_Font_4() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_Font_4)); }
	inline Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * get_m_Font_4() const { return ___m_Font_4; }
	inline Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 ** get_address_of_m_Font_4() { return &___m_Font_4; }
	inline void set_m_Font_4(Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * value)
	{
		___m_Font_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Font_4), (void*)value);
	}

	inline static int32_t get_offset_of_m_box_5() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_box_5)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_box_5() const { return ___m_box_5; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_box_5() { return &___m_box_5; }
	inline void set_m_box_5(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_box_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_box_5), (void*)value);
	}

	inline static int32_t get_offset_of_m_button_6() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_button_6)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_button_6() const { return ___m_button_6; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_button_6() { return &___m_button_6; }
	inline void set_m_button_6(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_button_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_button_6), (void*)value);
	}

	inline static int32_t get_offset_of_m_toggle_7() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_toggle_7)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_toggle_7() const { return ___m_toggle_7; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_toggle_7() { return &___m_toggle_7; }
	inline void set_m_toggle_7(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_toggle_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_toggle_7), (void*)value);
	}

	inline static int32_t get_offset_of_m_label_8() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_label_8)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_label_8() const { return ___m_label_8; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_label_8() { return &___m_label_8; }
	inline void set_m_label_8(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_label_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_label_8), (void*)value);
	}

	inline static int32_t get_offset_of_m_textField_9() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_textField_9)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_textField_9() const { return ___m_textField_9; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_textField_9() { return &___m_textField_9; }
	inline void set_m_textField_9(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_textField_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_textField_9), (void*)value);
	}

	inline static int32_t get_offset_of_m_textArea_10() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_textArea_10)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_textArea_10() const { return ___m_textArea_10; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_textArea_10() { return &___m_textArea_10; }
	inline void set_m_textArea_10(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_textArea_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_textArea_10), (void*)value);
	}

	inline static int32_t get_offset_of_m_window_11() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_window_11)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_window_11() const { return ___m_window_11; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_window_11() { return &___m_window_11; }
	inline void set_m_window_11(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_window_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_window_11), (void*)value);
	}

	inline static int32_t get_offset_of_m_horizontalSlider_12() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_horizontalSlider_12)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_horizontalSlider_12() const { return ___m_horizontalSlider_12; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_horizontalSlider_12() { return &___m_horizontalSlider_12; }
	inline void set_m_horizontalSlider_12(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_horizontalSlider_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_horizontalSlider_12), (void*)value);
	}

	inline static int32_t get_offset_of_m_horizontalSliderThumb_13() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_horizontalSliderThumb_13)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_horizontalSliderThumb_13() const { return ___m_horizontalSliderThumb_13; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_horizontalSliderThumb_13() { return &___m_horizontalSliderThumb_13; }
	inline void set_m_horizontalSliderThumb_13(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_horizontalSliderThumb_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_horizontalSliderThumb_13), (void*)value);
	}

	inline static int32_t get_offset_of_m_horizontalSliderThumbExtent_14() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_horizontalSliderThumbExtent_14)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_horizontalSliderThumbExtent_14() const { return ___m_horizontalSliderThumbExtent_14; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_horizontalSliderThumbExtent_14() { return &___m_horizontalSliderThumbExtent_14; }
	inline void set_m_horizontalSliderThumbExtent_14(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_horizontalSliderThumbExtent_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_horizontalSliderThumbExtent_14), (void*)value);
	}

	inline static int32_t get_offset_of_m_verticalSlider_15() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_verticalSlider_15)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_verticalSlider_15() const { return ___m_verticalSlider_15; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_verticalSlider_15() { return &___m_verticalSlider_15; }
	inline void set_m_verticalSlider_15(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_verticalSlider_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_verticalSlider_15), (void*)value);
	}

	inline static int32_t get_offset_of_m_verticalSliderThumb_16() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_verticalSliderThumb_16)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_verticalSliderThumb_16() const { return ___m_verticalSliderThumb_16; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_verticalSliderThumb_16() { return &___m_verticalSliderThumb_16; }
	inline void set_m_verticalSliderThumb_16(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_verticalSliderThumb_16 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_verticalSliderThumb_16), (void*)value);
	}

	inline static int32_t get_offset_of_m_verticalSliderThumbExtent_17() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_verticalSliderThumbExtent_17)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_verticalSliderThumbExtent_17() const { return ___m_verticalSliderThumbExtent_17; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_verticalSliderThumbExtent_17() { return &___m_verticalSliderThumbExtent_17; }
	inline void set_m_verticalSliderThumbExtent_17(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_verticalSliderThumbExtent_17 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_verticalSliderThumbExtent_17), (void*)value);
	}

	inline static int32_t get_offset_of_m_SliderMixed_18() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_SliderMixed_18)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_SliderMixed_18() const { return ___m_SliderMixed_18; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_SliderMixed_18() { return &___m_SliderMixed_18; }
	inline void set_m_SliderMixed_18(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_SliderMixed_18 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SliderMixed_18), (void*)value);
	}

	inline static int32_t get_offset_of_m_horizontalScrollbar_19() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_horizontalScrollbar_19)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_horizontalScrollbar_19() const { return ___m_horizontalScrollbar_19; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_horizontalScrollbar_19() { return &___m_horizontalScrollbar_19; }
	inline void set_m_horizontalScrollbar_19(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_horizontalScrollbar_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_horizontalScrollbar_19), (void*)value);
	}

	inline static int32_t get_offset_of_m_horizontalScrollbarThumb_20() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_horizontalScrollbarThumb_20)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_horizontalScrollbarThumb_20() const { return ___m_horizontalScrollbarThumb_20; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_horizontalScrollbarThumb_20() { return &___m_horizontalScrollbarThumb_20; }
	inline void set_m_horizontalScrollbarThumb_20(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_horizontalScrollbarThumb_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_horizontalScrollbarThumb_20), (void*)value);
	}

	inline static int32_t get_offset_of_m_horizontalScrollbarLeftButton_21() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_horizontalScrollbarLeftButton_21)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_horizontalScrollbarLeftButton_21() const { return ___m_horizontalScrollbarLeftButton_21; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_horizontalScrollbarLeftButton_21() { return &___m_horizontalScrollbarLeftButton_21; }
	inline void set_m_horizontalScrollbarLeftButton_21(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_horizontalScrollbarLeftButton_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_horizontalScrollbarLeftButton_21), (void*)value);
	}

	inline static int32_t get_offset_of_m_horizontalScrollbarRightButton_22() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_horizontalScrollbarRightButton_22)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_horizontalScrollbarRightButton_22() const { return ___m_horizontalScrollbarRightButton_22; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_horizontalScrollbarRightButton_22() { return &___m_horizontalScrollbarRightButton_22; }
	inline void set_m_horizontalScrollbarRightButton_22(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_horizontalScrollbarRightButton_22 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_horizontalScrollbarRightButton_22), (void*)value);
	}

	inline static int32_t get_offset_of_m_verticalScrollbar_23() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_verticalScrollbar_23)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_verticalScrollbar_23() const { return ___m_verticalScrollbar_23; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_verticalScrollbar_23() { return &___m_verticalScrollbar_23; }
	inline void set_m_verticalScrollbar_23(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_verticalScrollbar_23 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_verticalScrollbar_23), (void*)value);
	}

	inline static int32_t get_offset_of_m_verticalScrollbarThumb_24() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_verticalScrollbarThumb_24)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_verticalScrollbarThumb_24() const { return ___m_verticalScrollbarThumb_24; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_verticalScrollbarThumb_24() { return &___m_verticalScrollbarThumb_24; }
	inline void set_m_verticalScrollbarThumb_24(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_verticalScrollbarThumb_24 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_verticalScrollbarThumb_24), (void*)value);
	}

	inline static int32_t get_offset_of_m_verticalScrollbarUpButton_25() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_verticalScrollbarUpButton_25)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_verticalScrollbarUpButton_25() const { return ___m_verticalScrollbarUpButton_25; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_verticalScrollbarUpButton_25() { return &___m_verticalScrollbarUpButton_25; }
	inline void set_m_verticalScrollbarUpButton_25(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_verticalScrollbarUpButton_25 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_verticalScrollbarUpButton_25), (void*)value);
	}

	inline static int32_t get_offset_of_m_verticalScrollbarDownButton_26() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_verticalScrollbarDownButton_26)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_verticalScrollbarDownButton_26() const { return ___m_verticalScrollbarDownButton_26; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_verticalScrollbarDownButton_26() { return &___m_verticalScrollbarDownButton_26; }
	inline void set_m_verticalScrollbarDownButton_26(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_verticalScrollbarDownButton_26 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_verticalScrollbarDownButton_26), (void*)value);
	}

	inline static int32_t get_offset_of_m_ScrollView_27() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_ScrollView_27)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_m_ScrollView_27() const { return ___m_ScrollView_27; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_m_ScrollView_27() { return &___m_ScrollView_27; }
	inline void set_m_ScrollView_27(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___m_ScrollView_27 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ScrollView_27), (void*)value);
	}

	inline static int32_t get_offset_of_m_CustomStyles_28() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_CustomStyles_28)); }
	inline GUIStyleU5BU5D_t99FB75A2EC4777ADECDE02F71A619CFBFC0F4F70* get_m_CustomStyles_28() const { return ___m_CustomStyles_28; }
	inline GUIStyleU5BU5D_t99FB75A2EC4777ADECDE02F71A619CFBFC0F4F70** get_address_of_m_CustomStyles_28() { return &___m_CustomStyles_28; }
	inline void set_m_CustomStyles_28(GUIStyleU5BU5D_t99FB75A2EC4777ADECDE02F71A619CFBFC0F4F70* value)
	{
		___m_CustomStyles_28 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_CustomStyles_28), (void*)value);
	}

	inline static int32_t get_offset_of_m_Settings_29() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_Settings_29)); }
	inline GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * get_m_Settings_29() const { return ___m_Settings_29; }
	inline GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 ** get_address_of_m_Settings_29() { return &___m_Settings_29; }
	inline void set_m_Settings_29(GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * value)
	{
		___m_Settings_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Settings_29), (void*)value);
	}

	inline static int32_t get_offset_of_m_Styles_31() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6, ___m_Styles_31)); }
	inline Dictionary_2_t2CD153A36C5BD27CDDC85F23918ECEF77E892E80 * get_m_Styles_31() const { return ___m_Styles_31; }
	inline Dictionary_2_t2CD153A36C5BD27CDDC85F23918ECEF77E892E80 ** get_address_of_m_Styles_31() { return &___m_Styles_31; }
	inline void set_m_Styles_31(Dictionary_2_t2CD153A36C5BD27CDDC85F23918ECEF77E892E80 * value)
	{
		___m_Styles_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Styles_31), (void*)value);
	}
};

struct GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6_StaticFields
{
public:
	// UnityEngine.GUIStyle UnityEngine.GUISkin::ms_Error
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___ms_Error_30;
	// UnityEngine.GUISkin/SkinChangedDelegate UnityEngine.GUISkin::m_SkinChanged
	SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E * ___m_SkinChanged_32;
	// UnityEngine.GUISkin UnityEngine.GUISkin::current
	GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * ___current_33;

public:
	inline static int32_t get_offset_of_ms_Error_30() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6_StaticFields, ___ms_Error_30)); }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * get_ms_Error_30() const { return ___ms_Error_30; }
	inline GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 ** get_address_of_ms_Error_30() { return &___ms_Error_30; }
	inline void set_ms_Error_30(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * value)
	{
		___ms_Error_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___ms_Error_30), (void*)value);
	}

	inline static int32_t get_offset_of_m_SkinChanged_32() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6_StaticFields, ___m_SkinChanged_32)); }
	inline SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E * get_m_SkinChanged_32() const { return ___m_SkinChanged_32; }
	inline SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E ** get_address_of_m_SkinChanged_32() { return &___m_SkinChanged_32; }
	inline void set_m_SkinChanged_32(SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E * value)
	{
		___m_SkinChanged_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_SkinChanged_32), (void*)value);
	}

	inline static int32_t get_offset_of_current_33() { return static_cast<int32_t>(offsetof(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6_StaticFields, ___current_33)); }
	inline GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * get_current_33() const { return ___current_33; }
	inline GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 ** get_address_of_current_33() { return &___current_33; }
	inline void set_current_33(GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * value)
	{
		___current_33 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___current_33), (void*)value);
	}
};


// System.Reflection.TargetInvocationException
struct TargetInvocationException_t30F4C50D323F448CD2E08BDB8F47694B08EB354C  : public ApplicationException_t8D709C0445A040467C6A632AD7F742B25AB2A407
{
public:

public:
};


// UnityEngine.GUI/WindowFunction
struct WindowFunction_tFA5DBAB811627D7B0946C4AAD398D4CC154C174D  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.GUISkin/SkinChangedDelegate
struct SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E  : public MulticastDelegate_t
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
// UnityEngine.GUILayoutOption[]
struct GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB * m_Items[1];

public:
	inline GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB * value)
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

IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_pinvoke(const GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9& unmarshaled, GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_pinvoke_back(const GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke& marshaled, GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9& unmarshaled);
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_pinvoke_cleanup(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshal_pinvoke(const RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70& unmarshaled, RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshal_pinvoke_back(const RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke& marshaled, RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70& unmarshaled);
IL2CPP_EXTERN_C void RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshal_pinvoke_cleanup(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_com(const GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9& unmarshaled, GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com& marshaled);
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_com_back(const GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com& marshaled, GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9& unmarshaled);
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_com_cleanup(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com& marshaled);
IL2CPP_EXTERN_C void RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshal_com(const RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70& unmarshaled, RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com& marshaled);
IL2CPP_EXTERN_C void RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshal_com_back(const RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com& marshaled, RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70& unmarshaled);
IL2CPP_EXTERN_C void RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshal_com_cleanup(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_marshaled_com& marshaled);
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_pinvoke(const GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726& unmarshaled, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_pinvoke_back(const GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke& marshaled, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726& unmarshaled);
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_pinvoke_cleanup(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_com(const GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726& unmarshaled, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com& marshaled);
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_com_back(const GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com& marshaled, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726& unmarshaled);
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_com_cleanup(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com& marshaled);

// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::TryGetValue(!0,!1&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_m0A88BBB063127AFAD853506A433ACB07D7AAD67E_gshared (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * __this, int32_t ___key0, RuntimeObject ** ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::set_Item(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_m71867F9FFBB49DE962FD0036368A0F6E87F30C90_gshared (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * __this, int32_t ___key0, RuntimeObject * ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_mE7F9D51201F5A72BF4995CA0F3F0E866DB21E638_gshared (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * __this, const RuntimeMethod* method);
// !0 System.Func`1<System.Boolean>::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Func_1_Invoke_mD0192F3F912E371387CD7B196DF85569553486B4_gshared (Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F * __this, const RuntimeMethod* method);
// !2 System.Func`3<System.Int32,System.IntPtr,System.Boolean>::Invoke(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Func_3_Invoke_m41D8569C1E1FFC40BAB05286F15A74835341C627_gshared (Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 * __this, int32_t ___arg10, intptr_t ___arg21, const RuntimeMethod* method);
// !1 System.Func`2<System.Object,System.Boolean>::Invoke(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Func_2_Invoke_mC9A30EEF00507C36CC34A71B88397287E6906197_gshared (Func_2_t99409DECFF50F0FA9B427C863AC6C99C66E6F9F8 * __this, RuntimeObject * ___arg0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Object,System.Int32Enum>::ContainsKey(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Dictionary_2_ContainsKey_m3D67FD7426AFEB88575E5BFD61BE5EB21665CD69_gshared (Dictionary_2_t5B35D5550B4D9CDDB7D248BEEE75285BC3023229 * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// !1 System.Collections.Generic.Dictionary`2<System.Object,System.Int32Enum>::get_Item(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Dictionary_2_get_Item_mC3E2914537EF15406FA2F725DB20CA60F190F4F6_gshared (Dictionary_2_t5B35D5550B4D9CDDB7D248BEEE75285BC3023229 * __this, RuntimeObject * ___key0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Int32Enum>::set_Item(!0,!1)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_m372B8E717F9F74C215C8DD80965211B7F7AF2856_gshared (Dictionary_2_t5B35D5550B4D9CDDB7D248BEEE75285BC3023229 * __this, RuntimeObject * ___key0, int32_t ___value1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Int32Enum>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Dictionary_2__ctor_mDD94B092289B595591F7BFA6575667F3FCD66B00_gshared (Dictionary_2_t5B35D5550B4D9CDDB7D248BEEE75285BC3023229 * __this, const RuntimeMethod* method);

// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::TryGetValue(!0,!1&)
inline bool Dictionary_2_TryGetValue_m0A88BBB063127AFAD853506A433ACB07D7AAD67E (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * __this, int32_t ___key0, RuntimeObject ** ___value1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F *, int32_t, RuntimeObject **, const RuntimeMethod*))Dictionary_2_TryGetValue_m0A88BBB063127AFAD853506A433ACB07D7AAD67E_gshared)(__this, ___key0, ___value1, method);
}
// System.Type System.Object::GetType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Object_GetType_m571FE8360C10B98C23AAF1F066D92C08CC94F45B (RuntimeObject * __this, const RuntimeMethod* method);
// System.Object System.Activator::CreateInstance(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Activator_CreateInstance_m1BACAB5F4FBF138CCCB537DDCB0683A2AC064295 (Type_t * ___type0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::set_Item(!0,!1)
inline void Dictionary_2_set_Item_m71867F9FFBB49DE962FD0036368A0F6E87F30C90 (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * __this, int32_t ___key0, RuntimeObject * ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F *, int32_t, RuntimeObject *, const RuntimeMethod*))Dictionary_2_set_Item_m71867F9FFBB49DE962FD0036368A0F6E87F30C90_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::.ctor()
inline void Dictionary_2__ctor_mE7F9D51201F5A72BF4995CA0F3F0E866DB21E638 (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F *, const RuntimeMethod*))Dictionary_2__ctor_mE7F9D51201F5A72BF4995CA0F3F0E866DB21E638_gshared)(__this, method);
}
// System.Void UnityEngine.GUIStyle::get_contentOffset_Injected(UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_get_contentOffset_Injected_m01479BB9A70925A53DBDF36B72D5FE82C9202256 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::set_contentOffset_Injected(UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_contentOffset_Injected_mDBEAF5EF679081562A6CEFD6E208781AB0AE3245 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::set_Internal_clipOffset_Injected(UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_Internal_clipOffset_Injected_m7BEA5BAB90B2593261777E75DBF28EA8201C5F93 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_Draw_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Draw_Injected_mB08817EF206F76A1E2CF33199889F2BBC331F27A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___screenRect0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_Draw2_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Draw2_Injected_m2B6E7ADBB95678E90549769F40BAEA96334954A2 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, bool ___on3, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_DrawCursor_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,UnityEngine.Color&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_DrawCursor_Injected_m455B380779298710943DF4DBD8E9C7361D4AB245 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___pos2, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * ___cursorColor3, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_DrawWithTextSelection_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Int32,UnityEngine.Color&,UnityEngine.Color&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_DrawWithTextSelection_Injected_m5C13B16DC9C2C5CE5B1B517F5AB5980C812F11FA (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___screenRect0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, bool ___drawSelectionAsComposition6, int32_t ___cursorFirst7, int32_t ___cursorLast8, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * ___cursorColor9, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * ___selectionColor10, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_GetCursorPixelPosition_Injected_mF7899C9932D49D0AD222E71299429CB95AA2F76B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___cursorStringIndex2, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret3, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIStyle::Internal_GetCursorStringIndex_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIStyle_Internal_GetCursorStringIndex_Injected_m8949C266ABD988A56BB60CEDF47B85E65BF7B51A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___cursorPixelPosition2, const RuntimeMethod* method);
// System.String UnityEngine.GUIStyle::Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_Internal_GetSelectedRenderedText_Injected_mFBB4298AD4A38058CC247D7DDE6C7413989D1036 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___localPosition0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___mContent1, int32_t ___selectIndex2, int32_t ___cursorIndex3, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_CalcSize_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_CalcSize_Injected_m9C64AC5BB7801E30225703FB042E42061B89E636 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret1, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_CalcSizeWithConstraints_Injected_mB165D16DAE4455C9901D0A6C1B8751F2E8F8E858 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___maxSize1, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret2, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_CalcMinMaxWidth_Injected_m4E48F9D7027E8D75326DF02B0D01C6AEFB533BD8 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret1, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::SetMouseTooltip_Injected(System.String,UnityEngine.Rect&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_SetMouseTooltip_Injected_m165B8143962BC2EF7F0FE454BBAB1E358A84ED76 (String_t* ___tooltip0, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___screenRect1, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.IntPtr UnityEngine.GUIStyle::Internal_Create(UnityEngine.GUIStyle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t GUIStyle_Internal_Create_m1A826DEC0513F9B9C7E5C67D02D24BEA33783686 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___self0, const RuntimeMethod* method);
// System.Boolean System.IntPtr::op_Inequality(System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool IntPtr_op_Inequality_m212AF0E66AA81FEDC982B1C8A44ADDA24B995EB8 (intptr_t ___value10, intptr_t ___value21, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_Destroy(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Destroy_m51A33779ABE8BAF80E5F975F9F5AE8D960CB4EE8 (intptr_t ___self0, const RuntimeMethod* method);
// System.Void System.Object::Finalize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Finalize_mC59C83CF4F7707E425FFA6362931C25D4C36676A (RuntimeObject * __this, const RuntimeMethod* method);
// System.String UnityEngine.GUIStyle::get_rawName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_get_rawName_m1295BFC75B2924BEB81140B9476E5B97340A1713 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::set_rawName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_rawName_mFE7CE77C7654A7B1D68DDB557801C9D33896BDF1 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, String_t* ___value0, const RuntimeMethod* method);
// System.IntPtr UnityEngine.GUIStyle::GetStyleStatePtr(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t GUIStyle_GetStyleStatePtr_mB1EEFB0E08D242D2B10272B5F2A78B23551E012E (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, int32_t ___idx0, const RuntimeMethod* method);
// UnityEngine.GUIStyleState UnityEngine.GUIStyleState::GetGUIStyleState(UnityEngine.GUIStyle,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * GUIStyleState_GetGUIStyleState_mE8758CDE0E9E627ECDE92F60509A19B91922964C (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___sourceStyle0, intptr_t ___source1, const RuntimeMethod* method);
// System.IntPtr UnityEngine.GUIStyle::GetRectOffsetPtr(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t GUIStyle_GetRectOffsetPtr_mD3E24C1578BB69007E729CC624D264E1CD21D06A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, int32_t ___idx0, const RuntimeMethod* method);
// System.Void UnityEngine.RectOffset::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RectOffset__ctor_mA519A9F678D6B88731C3F6A67E0DA9092A4596D4 (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * __this, RuntimeObject * ___sourceStyle0, intptr_t ___source1, const RuntimeMethod* method);
// System.Single UnityEngine.GUIStyle::Internal_GetLineHeight(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_Internal_GetLineHeight_m64DD33A98E03CB492F5320C4DE3C352D1DED0DBA (intptr_t ___target0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Draw(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Draw_mA26521B967422FB04437D5AE0D0BE3EAF0FFF5EE (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlId2, bool ___isHover3, bool ___isActive4, bool ___on5, bool ___hasKeyboardFocus6, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIUtility::get_hotControl()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_get_hotControl_m70A913241C32305A380F4DB4A3F1B37BB3401E5A (const RuntimeMethod* method);
// System.Boolean UnityEngine.GUIUtility::HasKeyFocus(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_HasKeyFocus_m1CF44E6F83A22DB0B5F2148C68AA7DEC0BB94E4F (int32_t ___controlID0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_Draw(UnityEngine.Rect,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Draw_mA0406F2B22C574C77BF1F3CE5125221BAE3EAF7F (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___screenRect0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_Draw2(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Draw2_m0819148173653ADC27A83BC886C4B0A1DF840BB4 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, bool ___on3, const RuntimeMethod* method);
// UnityEngine.Event UnityEngine.Event::get_current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * Event_get_current_m069E3E742E6CBC32C3BC958B85153E75B0192443 (const RuntimeMethod* method);
// UnityEngine.EventType UnityEngine.Event::get_type()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Event_get_type_mA5010AB8C34B098E0783949046C708B9E1BA811D (Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5 (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * __this, float ___r0, float ___g1, float ___b2, float ___a3, const RuntimeMethod* method);
// UnityEngine.GUISkin UnityEngine.GUI::get_skin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * GUI_get_skin_mCD2A03F408ABBA7816C52148D92A8DC836FBDE2F (const RuntimeMethod* method);
// UnityEngine.GUISettings UnityEngine.GUISkin::get_settings()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * GUISkin_get_settings_m10680CA935A2122970FF245119CB9D428B4920E8 (GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.GUISettings::get_cursorFlashSpeed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUISettings_get_cursorFlashSpeed_mA8D2966F6AB12D282ECA5C56558FE74B71C125FC (GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_realtimeSinceStartup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B (const RuntimeMethod* method);
// System.Single UnityEngine.GUIStyle::Internal_GetCursorFlashOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_Internal_GetCursorFlashOffset_mBD1D699C55B4C0503F60D37A335D2C71B42B8344 (const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.GUISettings::get_cursorColor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  GUISettings_get_cursorColor_m353344B00E67F3084AE61F9E4FFEDD17874578F0 (GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_DrawCursor(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_DrawCursor_m51748354AC84266F3148DF7CEEF01D022CE2B770 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___pos2, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___cursorColor3, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Event::get_mousePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Event_get_mousePosition_m4D2A80BE0CF9A6D2CE8289C4815807493B3449A9 (Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rect::Contains(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Rect_Contains_m8438BA185AD95D6C50E7A2CF9DD30FBA044CE0B2 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___point0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Internal_DrawWithTextSelection(UnityEngine.Rect,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Int32,UnityEngine.Color,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_DrawWithTextSelection_mBC957F07D4BDEDB10DE76C449830D230E41EB70C (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___screenRect0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, bool ___drawSelectionAsComposition6, int32_t ___cursorFirst7, int32_t ___cursorLast8, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___cursorColor9, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___selectionColor10, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIUtility::get_keyboardControl()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_get_keyboardControl_mC111A10FE792FA94E3859C5BC704D611F8768BE1 (const RuntimeMethod* method);
// UnityEngine.Color UnityEngine.GUISettings::get_selectionColor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  GUISettings_get_selectionColor_m2CA908F3709FAD0C62822F00D3CC79B861B04933 (GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::DrawWithTextSelection(UnityEngine.Rect,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Int32,System.Int32,System.Boolean,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_DrawWithTextSelection_mD4E916B0D43FCA792CB25F4604E0A897E8186E13 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isActive2, bool ___hasKeyboardFocus3, int32_t ___firstSelectedCharacter4, int32_t ___lastSelectedCharacter5, bool ___drawSelectionAsComposition6, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___selectionColor7, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::DrawWithTextSelection(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_DrawWithTextSelection_m6A144949389804F371C359F159C9E7DAA1BEDA9A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, int32_t ___firstSelectedCharacter3, int32_t ___lastSelectedCharacter4, bool ___drawSelectionAsComposition5, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle__ctor_mDA0E00D0017FC0B2FC333C5DD6E1EDBAE3BCB8E3 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.GUIStyle::Internal_GetCursorPixelPosition(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_Internal_GetCursorPixelPosition_m69C855DB552A07BFE4F3FB5660540AE132F6F2B5 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___cursorStringIndex2, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIStyle::Internal_GetCursorStringIndex(UnityEngine.Rect,UnityEngine.GUIContent,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIStyle_Internal_GetCursorStringIndex_mCA5786C67C884DF622657D8C256994BFB6EADE77 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___cursorPixelPosition2, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.GUIStyle::Internal_CalcSize(UnityEngine.GUIContent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_Internal_CalcSize_m0D940B98466D557B889D8BD0F93F3D9D4B6F16D6 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.GUIStyle::Internal_CalcSizeWithConstraints(UnityEngine.GUIContent,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_Internal_CalcSizeWithConstraints_m992088CCE4FE1592F0BFEDA168AD79EE9D3FF646 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___maxSize1, const RuntimeMethod* method);
// System.Single UnityEngine.GUIStyle::Internal_CalcHeight(UnityEngine.GUIContent,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_Internal_CalcHeight_mE777C84ABE0D0473DD2DA866B4F3F2783EE03721 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, float ___width1, const RuntimeMethod* method);
// System.Single UnityEngine.GUIStyle::get_fixedHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.GUIStyle::get_wordWrap()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIStyle_get_wordWrap_m3852F7A584014D25A5CED400CBC1B9661ED5E01B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// UnityEngine.ImagePosition UnityEngine.GUIStyle::get_imagePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIStyle_get_imagePosition_m384E6DA06D9EE64871C2439EE5325C245FFEB4C8 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.GUIStyle::Internal_CalcMinMaxWidth(UnityEngine.GUIContent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_Internal_CalcMinMaxWidth_m1607C544FC2FB31E8340A354D978C5A49A23D86B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, const RuntimeMethod* method);
// System.String UnityEngine.GUIStyle::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_get_name_mDC1371698EB6B92D459AA165EFFE5983711C4BB6 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// System.String UnityEngine.UnityString::Format(System.String,System.Object[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UnityString_Format_m7A07C068ED408DD06F634070770FB55F13AA4EC9 (String_t* ___fmt0, ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ___args1, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyleState::set_textColor_Injected(UnityEngine.Color&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState_set_textColor_Injected_mA4161E4AAAE12F40C7F1B937F2DDCAB1D81E221F (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * ___value0, const RuntimeMethod* method);
// System.IntPtr UnityEngine.GUIStyleState::Init()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t GUIStyleState_Init_mDC103756AA527283D4D171277702A78211BE6392 (const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyleState::.ctor(UnityEngine.GUIStyle,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState__ctor_mF5B23C65DA81DA85EAE2F148C549ECE0007F1652 (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___sourceStyle0, intptr_t ___source1, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyleState::Cleanup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState_Cleanup_m811DBCF744DEC31303381BA28AD292209260C446 (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, const RuntimeMethod* method);
// System.Reflection.MethodInfo System.Type::GetMethod(System.String,System.Reflection.BindingFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MethodInfo_t * Type_GetMethod_m2DDEF37DF33D28F579BA8E03F4376B67D91F0DEB (Type_t * __this, String_t* ___name0, int32_t ___bindingAttr1, const RuntimeMethod* method);
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E (RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ___handle0, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIUtility::Internal_GetControlID_Injected(System.Int32,UnityEngine.FocusType,UnityEngine.Rect&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_Internal_GetControlID_Injected_mB712E290E5EDE635C4F06E06F697D3D82AC8C901 (int32_t ___hint0, int32_t ___focusType1, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___rect2, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIUtility::Internal_GetControlID(System.Int32,UnityEngine.FocusType,UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_Internal_GetControlID_mE6F28AD317BB04BFEB2C9E85E4E644F8B07E4AEE (int32_t ___hint0, int32_t ___focusType1, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect2, const RuntimeMethod* method);
// System.Void UnityEngine.GUIUtility::set_compositionCursorPos_Injected(UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_compositionCursorPos_Injected_mA4689621797402B18EF4F9F5627A1990A86C8D4E (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___value0, const RuntimeMethod* method);
// System.Void System.Action::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Action_Invoke_m3FFA5BE3D64F0FF8E1E1CB6F953913FADB5EB89E (Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIUtility::GetControlID(System.Int32,UnityEngine.FocusType,UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_GetControlID_mCF29C85EFCB6D5859CB1F464601ACF474754F4A3 (int32_t ___hint0, int32_t ___focusType1, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect2, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.Rect::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  Rect_get_zero_m4F738804E40698120CC691AB45A6416C4FF52589 (const RuntimeMethod* method);
// System.Object UnityEngine.GUIStateObjects::GetStateObject(System.Type,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GUIStateObjects_GetStateObject_mF668F2C3D2335FA4DE006C16C9C7C57ABB57CFD0 (Type_t * ___t0, int32_t ___controlID1, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIUtility::Internal_GetHotControl()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_Internal_GetHotControl_m34FDB5E7413F6EE520D6B4932C60A5BACBEF922F (const RuntimeMethod* method);
// System.Void UnityEngine.GUIUtility::Internal_SetHotControl(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_Internal_SetHotControl_m8DC5C397B09559EC71B12ED955A25F779569FCFD (int32_t ___value0, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIUtility::Internal_GetKeyboardControl()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_Internal_GetKeyboardControl_mBB68966687B84C74BEAAD8A117DD14D8E7B9F382 (const RuntimeMethod* method);
// System.Void UnityEngine.GUIUtility::Internal_SetKeyboardControl(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_Internal_SetKeyboardControl_mFAC14D6638CE2826ADC2CCA8205E3544A94E6671 (int32_t ___value0, const RuntimeMethod* method);
// !0 System.Func`1<System.Boolean>::Invoke()
inline bool Func_1_Invoke_mD0192F3F912E371387CD7B196DF85569553486B4 (Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F *, const RuntimeMethod*))Func_1_Invoke_mD0192F3F912E371387CD7B196DF85569553486B4_gshared)(__this, method);
}
// System.Object UnityEngine.GUIUtility::Internal_GetDefaultSkin(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GUIUtility_Internal_GetDefaultSkin_mA64DFF25827FEF564C93F240B7C6614EEABC92E5 (int32_t ___skinMode0, const RuntimeMethod* method);
// !2 System.Func`3<System.Int32,System.IntPtr,System.Boolean>::Invoke(!0,!1)
inline bool Func_3_Invoke_m41D8569C1E1FFC40BAB05286F15A74835341C627 (Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 * __this, int32_t ___arg10, intptr_t ___arg21, const RuntimeMethod* method)
{
	return ((  bool (*) (Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 *, int32_t, intptr_t, const RuntimeMethod*))Func_3_Invoke_m41D8569C1E1FFC40BAB05286F15A74835341C627_gshared)(__this, ___arg10, ___arg21, method);
}
// System.Void UnityEngine.GUIUtility::ResetGlobalState()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_ResetGlobalState_m5D608E689B0B1AA994702358158C7BB65373D3F7 (const RuntimeMethod* method);
// System.Void UnityEngine.GUILayoutUtility::Begin(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUILayoutUtility_Begin_m1A42FB0448413B7ED711887827CD6E8F9276C47D (int32_t ___instanceID0, const RuntimeMethod* method);
// System.Void UnityEngine.GUILayoutUtility::Layout()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUILayoutUtility_Layout_mE876F10FD153DE2038066B29DBC444E4B5A3F88B (const RuntimeMethod* method);
// System.Void UnityEngine.GUILayoutUtility::LayoutFromEditorWindow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUILayoutUtility_LayoutFromEditorWindow_m47384B8E70622B43668E03DA67E8B455694A7005 (const RuntimeMethod* method);
// UnityEngine.GUILayoutUtility/LayoutCache UnityEngine.GUILayoutUtility::SelectIDList(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8 * GUILayoutUtility_SelectIDList_mBB4E4C5EE476C431E3105D76F13CEA683E7021CB (int32_t ___instanceID0, bool ___isWindow1, const RuntimeMethod* method);
// System.Void UnityEngine.GUIContent::ClearStaticCache()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIContent_ClearStaticCache_mD4647E7AF90A71B211AF157C9DDF12D25A0059A2 (const RuntimeMethod* method);
// System.Void UnityEngine.GUIUtility::Internal_ExitGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_Internal_ExitGUI_m0B9B3280EB0CA732C5CFA32DA0384EA2D0A41090 (const RuntimeMethod* method);
// System.Boolean UnityEngine.GUIUtility::ShouldRethrowException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_ShouldRethrowException_m4D31C054C92D4A3D13D7F64C23634376F1F44DCB (Exception_t * ___exception0, const RuntimeMethod* method);
// !1 System.Func`2<System.Exception,System.Boolean>::Invoke(!0)
inline bool Func_2_Invoke_m6E33E881BFD75761C0F91C7EEB1AF452BFD18445 (Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F * __this, Exception_t * ___arg0, const RuntimeMethod* method)
{
	return ((  bool (*) (Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F *, Exception_t *, const RuntimeMethod*))Func_2_Invoke_mC9A30EEF00507C36CC34A71B88397287E6906197_gshared)(__this, ___arg0, method);
}
// System.Void UnityEngine.GUI::set_skin(UnityEngine.GUISkin)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUI_set_skin_mFCD039C47B3C327D9E0D867092DB353F2CEA796E (GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIUtility::set_guiIsExiting(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GUIUtility_set_guiIsExiting_m13C69BE54D215B22CA7D1FE5192DD5ED744E0FCF_inline (bool ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.GUI::set_changed(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUI_set_changed_m7DBA5D0D2493D33D86E59D55942CE4FA56451DAC (bool ___value0, const RuntimeMethod* method);
// UnityEngineInternal.GenericStack UnityEngine.GUI::get_scrollViewStates()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * GUI_get_scrollViewStates_mC0FF9F20045EB96D22254543B8C9A0643D54C4D4_inline (const RuntimeMethod* method);
// System.Exception System.Exception::get_InnerException()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Exception_t * Exception_get_InnerException_m10D85773B6B191C7D4E7D3C2954B84F9BB195218_inline (Exception_t * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.GUIUtility::IsExitGUIException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_IsExitGUIException_mF80F38388A47904E471BC7CE0E1239845A9356C2 (Exception_t * ___exception0, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIUtility::get_guiDepth()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_get_guiDepth_mCEE2CF2630726CA657D48F0375866E2B8C314F2E (const RuntimeMethod* method);
// System.Void System.ArgumentException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentException__ctor_m2D35EAD113C2ADC99EB17B940A2097A93FD23EFC (ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00 * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Single UnityEngine.Rect::get_xMin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Rect_get_xMin_m02EA330BE4C4A07A3F18F50F257832E9E3C2B873 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Rect::get_xMax()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Rect_get_xMax_m174FFAACE6F19A59AA793B3D507BE70116E27DE5 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Rect::get_yMin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Rect_get_yMin_m2C91041817D410B32B80E338764109D75ACB01E4 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Rect::get_yMax()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Rect_get_yMax_m9685BF55B44C51FF9BA080F9995073E458E1CDC3 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.GUIUtility::HitTest(UnityEngine.Rect,UnityEngine.Vector2,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_HitTest_mC4DE9B897D0988485EB1F36DF19111A20BB421D5 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___point1, int32_t ___offset2, const RuntimeMethod* method);
// System.Boolean UnityEngine.Event::get_isDirectManipulationDevice()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Event_get_isDirectManipulationDevice_mA61C39E8961354E6CC14256B8BCB000822B5755A (Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.GUIUtility::HitTest(UnityEngine.Rect,UnityEngine.Vector2,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_HitTest_mDDEDB8F53EACE5BE782B70008DD61334BA8607FC (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___point1, bool ___isDirectManipulationDevice2, const RuntimeMethod* method);
// System.Void UnityEngine.GUILayoutEntry::.ctor(System.Single,System.Single,System.Single,System.Single,UnityEngine.GUIStyle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUILayoutEntry__ctor_m29C33DB9A9A93ECD86533A72B2822E34E8415640 (GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE * __this, float ____minWidth0, float ____maxWidth1, float ____minHeight2, float ____maxHeight3, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ____style4, const RuntimeMethod* method);
// System.Void UnityEngine.GUIContent::.ctor(UnityEngine.GUIContent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIContent__ctor_m87E695240720FBABF3321CAA0F960FC02DF18647 (GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___src0, const RuntimeMethod* method);
// UnityEngine.GUIStyle UnityEngine.GUILayoutEntry::get_style()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * GUILayoutEntry_get_style_mCBE0882318C702289CFD524CF4246D1201BDCB7F (GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::CalcMinMaxWidth(UnityEngine.GUIContent,System.Single&,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_CalcMinMaxWidth_m1D29C63D2C8A757F503FE3C0904E3276CC48BB94 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, float* ___minWidth1, float* ___maxWidth2, const RuntimeMethod* method);
// System.Single UnityEngine.Rect::get_width()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.GUIStyle::CalcHeight(UnityEngine.GUIContent,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_CalcHeight_m120220D334AEC6B33F4767EA54FE78CEC09FBCC9 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, float ___width1, const RuntimeMethod* method);
// System.Void UnityEngine.SliderHandler::.ctor(UnityEngine.Rect,System.Single,System.Single,System.Single,System.Single,UnityEngine.GUIStyle,UnityEngine.GUIStyle,System.Boolean,System.Int32,UnityEngine.GUIStyle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SliderHandler__ctor_mEDBEB4F32DE823ED83C1604F2439F480156A8A56 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, float ___currentValue1, float ___size2, float ___start3, float ___end4, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___slider5, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___thumb6, bool ___horiz7, int32_t ___id8, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___thumbExtent9, const RuntimeMethod* method);
// UnityEngine.EventType UnityEngine.SliderHandler::CurrentEventType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SliderHandler_CurrentEventType_m9A5F50AD2DCDA644F0BDFD39A7D78A91E8A0CE03 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::OnMouseDown()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_OnMouseDown_m23E8544B289BA7AEA59F407A60531803DA529C33 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::OnMouseDrag()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_OnMouseDrag_mF20837A5155A974918A2F9074E3A2BE29A29AE43 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::OnMouseUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_OnMouseUp_mD8C283E0262ADE1D5931E94AB58C783D9997498B (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::OnRepaint()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_OnRepaint_m4EA34AB4CD8C441436A59DE1F389E9E2BB7863E8 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::Handle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_Handle_mF86CB8812570095EA2D216E7AA0FFBBB623DE7F1 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.SliderHandler::ThumbSelectionRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbSelectionRect_m31CADCE31EAC5F467A42EA1356B939AF32E3FB09 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// UnityEngine.Event UnityEngine.SliderHandler::CurrentEvent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.GUIUtility::HitTest(UnityEngine.Rect,UnityEngine.Event)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_HitTest_m6643D81E497211BA393BAE3C4807144E1BC4E074 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect0, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___evt1, const RuntimeMethod* method);
// System.Single System.Math::Min(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Math_Min_mED21323DC72FBF9A825FD4210D4B9D693CE87FCF (float ___val10, float ___val21, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_xMin(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_xMin_mC91AC74347F8E3D537E8C5D70015E9B8EA872A3F (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___value0, const RuntimeMethod* method);
// System.Single System.Math::Max(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Math_Max_mEB87839DA28310AE4CB81A94D551874CFC2B1247 (float ___val10, float ___val21, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_xMax(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_xMax_m4E466ED07B11CC5457BD62517418C493C0DDF2E3 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_yMin(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_yMin_mA2FDFF7C8C2361A4CF3F446BAB9A861F923F763A (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_yMax(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_yMax_m4E7A7C5E88FA369D6ED022C939427F4895F6635D (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___value0, const RuntimeMethod* method);
// System.Boolean UnityEngine.SliderHandler::IsEmptySlider()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SliderHandler_IsEmptySlider_m8BBB2FFB1700D02971BCC9D82F1C380F18F400FF (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GUI::set_scrollTroughSide(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GUI_set_scrollTroughSide_m0EAD9BD016B2E738A20356B3188A04A742AF60F2_inline (int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIUtility::set_hotControl(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_hotControl_m865CC0FAB4B33056CEC7047E38111D98097C52C8 (int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Event::Use()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Event_Use_m360896D3936BCA2FF8B3147C52952E9A4BE12519 (Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::ClampedCurrentValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.SliderHandler::StartDraggingWithValue(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SliderHandler_StartDraggingWithValue_m50B0784BA048DCAFF90809644E38B3DBCCFF890A (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, float ___dragStartValue0, const RuntimeMethod* method);
// System.Boolean UnityEngine.SliderHandler::SupportsPageMovements()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SliderHandler_SupportsPageMovements_mD2A4C576F119F358E894AC6192BDA729DC6EE3B6 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// UnityEngine.SliderState UnityEngine.SliderHandler::SliderState()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * SliderHandler_SliderState_m939A3BAD07388F8CA65E195655A3CA8967B5D127 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.DateTime UnityEngine.SystemClock::get_now()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  SystemClock_get_now_m67D7074CE3121B0702CF7CE0436F3C5496262391 (const RuntimeMethod* method);
// System.DateTime System.DateTime::AddMilliseconds(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  DateTime_AddMilliseconds_m74B689CDAFB7ABEEF56827D8777B7C95C89C3154 (DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 * __this, double ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.GUI::set_nextScrollStepTime(System.DateTime)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GUI_set_nextScrollStepTime_m3CF6DBBA4BE79B582AE4245AC02DED002C31E1DD_inline (DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method);
// System.Int32 UnityEngine.SliderHandler::CurrentScrollTroughSide()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SliderHandler_CurrentScrollTroughSide_m32D95131BA42F38C393B3948229E1B9443F4A6EC (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::PageMovementValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_PageMovementValue_m50ADD2517DE35E7E2AA9A82B499CD6208AAA96A7 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::ValueForCurrentMousePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_ValueForCurrentMousePosition_m02359E724DC0AE243B1B34F29AC762F531F0D2B8 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::Clamp(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_Clamp_mD8AB2275AB386BA1F9751B313CA05FA413619DF6 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, float ___value0, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::MousePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::ValuesPerPixel()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::Draw(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Draw_mE548BD5036F0311925375E002619553086E0A61A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, bool ___on3, bool ___hover4, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::Min(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Min_mD28BD5C9012619B74E475F204F96603193E99B14 (float ___a0, float ___b1, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::Max(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775 (float ___a0, float ___b1, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.SliderHandler::ThumbExtRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbExtRect_m4B760F15BC1C70617D6A012CE2B1FEF179B7A9CC (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.SliderHandler::ThumbRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUI::get_scrollTroughSide()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t GUI_get_scrollTroughSide_m7746453E541149AB66B07FCCE8209BE42F37684C_inline (const RuntimeMethod* method);
// System.Void UnityEngine.GUI::InternalRepaintEditorWindow()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUI_InternalRepaintEditorWindow_mB24AB5B2A1B62C2F7572ADC8F28711569434835C (const RuntimeMethod* method);
// System.DateTime UnityEngine.GUI::get_nextScrollStepTime()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  GUI_get_nextScrollStepTime_mD6A92E2DB68073C2B57EEFBDCB72D518B70E9065_inline (const RuntimeMethod* method);
// System.Boolean System.DateTime::op_LessThan(System.DateTime,System.DateTime)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool DateTime_op_LessThan_m9822D8ADDCCACAA534FE3F98C44C352778B0C3DE (DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___t10, DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___t21, const RuntimeMethod* method);
// UnityEngine.EventType UnityEngine.Event::GetTypeForControl(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Event_GetTypeForControl_mDCE0BCF26BE2422E17902BCE31693CBA83EB4052 (Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * __this, int32_t ___controlID0, const RuntimeMethod* method);
// System.Single UnityEngine.Rect::get_y()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Rect::get_x()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.GUI::get_usePageScrollbars()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUI_get_usePageScrollbars_m3704DFEA154B1C6CAD3558E8EAA5CCA1F976C233 (const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::PageUpMovementBound()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_PageUpMovementBound_m6DA2C83E39C8F8510FBFAF1397E110444005D658 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Rect::get_height()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::MinValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_MinValue_m073EA73B5C7E24798E10AF850E5FB8E7B59A579A (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::MaxValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_MaxValue_mC8B1C5738087924C1522142553435D4BB2588756 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::Clamp(System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Clamp_m2416F3B785C8F135863E3D17E5B0CB4174797B87 (float ___value0, float ___min1, float ___max2, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_x(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_x_m1147A05B5046E1D4427E8EC99B9DFA4A32EEDEE6 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_width(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_width_m07D84AD7C7093EDCCD94A7B93A9447CA9917DD9D (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_y(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_y_m015507262F8AC5AFF1B4E986B66307F31FB3A10E (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_height(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_height_m4A00B16C122F44FEF4BA074386F3DC11FF4B4D23 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___value0, const RuntimeMethod* method);
// System.Object UnityEngine.GUIUtility::GetStateObject(System.Type,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GUIUtility_GetStateObject_mCB51130ADCCE1FC49DCF65A1BC5545A07E012E6A (Type_t * ___t0, int32_t ___controlID1, const RuntimeMethod* method);
// System.Single UnityEngine.GUIStyle::get_fixedWidth()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect__ctor_m12075526A02B55B680716A34AD5287B223122B70 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, float ___x0, float ___y1, float ___width2, float ___height3, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Rect::get_center()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Rect_get_center_mDFC7A4AE153DCDC1D6248803381C6F36C7883707 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Rect::set_center(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect_set_center_mEEB5135E547FB6E296BF27F57BC857313A9A48DD (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value0, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.SliderHandler::VerticalThumbRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_VerticalThumbRect_m82DF3DABA3132CBD308A79ED264CDC0567D4BF6B (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.SliderHandler::HorizontalThumbRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_HorizontalThumbRect_m4732996A81968BEFC836C08AABDDCB5A5D243A6F (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// UnityEngine.RectOffset UnityEngine.GUIStyle::get_margin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * GUIStyle_get_margin_m1AF5B34B3BE9B514A8B189EAE16F976245C4A363 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// UnityEngine.RectOffset UnityEngine.GUIStyle::get_padding()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.RectOffset::Remove(UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  RectOffset_Remove_m49C8247D2CBB0080F7A09A37D3F1288403AE1BFB (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect0, const RuntimeMethod* method);
// System.Single UnityEngine.SliderHandler::ThumbSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_ThumbSize_m585B339F13F16DEA83D5CC6F4DA0A181822D2947 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.RectOffset::get_horizontal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RectOffset_get_horizontal_m7B1D97260EF95BCEDB9A7AF7AC9FAF99D56E9177 (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.RectOffset::get_vertical()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RectOffset_get_vertical_m589292AEF7A556D4FD0CED648DEED422C1CA36A4 (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * __this, const RuntimeMethod* method);
// System.String UnityEngine.GUIContent::get_text()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIContent_get_text_mA6BE9C17B069417994ED27EE812A39BB960D921A (GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GUIContent::set_text(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB (GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * __this, String_t* ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::EnsureValidCodePointIndex(System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_EnsureValidCodePointIndex_mB443C43308B056AE4E13DA6108E1DC1549CF7662 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t* ___index0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Rect::op_Equality(UnityEngine.Rect,UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Rect_op_Equality_m17C955A4F85F01A7CF0B43EDE41463301E93F6C1 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___lhs0, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rhs1, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Vector2::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828 (const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::UpdateScrollOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_UpdateScrollOffset_mF6F74A14D6F9824B19A0D01BC9D0A7583CD2A5F4 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// UnityEngine.Rect UnityEngine.TextEditor::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// UnityEngine.GUIStyle UnityEngine.GUIStyle::get_none()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * GUIStyle_get_none_mE13C9D26505C972F8697EE0E0E66D169D6D731A1 (const RuntimeMethod* method);
// System.Void UnityEngine.GUIContent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIContent__ctor_mC57EB7929C7079750DF0FBFE6001732F74926A42 (GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::set_selectIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::set_cursorIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectAll()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectAll_m5EDB0E8D503B602A6A1AFF213E45766B57702598 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::get_cursorIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.GUIStyle::GetCursorPixelPosition(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_GetCursorPixelPosition_m8D4E34D8BFB582440B88F54643D095DF13DEA4F3 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___cursorStringIndex2, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::get_selectIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::HandleKeyEvent(UnityEngine.Event,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_HandleKeyEvent_mA953F9277140AD596AEB563FCC189E9974B1B14A (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___e0, bool ___textIsReadOnly1, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::InitKeyActions()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_InitKeyActions_m1073E6D1966025612EFAD14D6C17E590EA95359A (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// UnityEngine.EventModifiers UnityEngine.Event::get_modifiers()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Event_get_modifiers_m01356D3F1DDF6746122F129713EBE87BFA65D886 (Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Event::set_modifiers(UnityEngine.EventModifiers)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Event_set_modifiers_m375A78874878A2BA7822E93CA62579B0E4CA7AA2 (Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>::ContainsKey(!0)
inline bool Dictionary_2_ContainsKey_mDD8A87D2680C370A2DBC4AFECE658B948EEA1202 (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * __this, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___key0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 *, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E *, const RuntimeMethod*))Dictionary_2_ContainsKey_m3D67FD7426AFEB88575E5BFD61BE5EB21665CD69_gshared)(__this, ___key0, method);
}
// !1 System.Collections.Generic.Dictionary`2<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>::get_Item(!0)
inline int32_t Dictionary_2_get_Item_m5423F5CE10F5EA6145EECF26BE0F452A301D2B39 (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * __this, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___key0, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 *, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E *, const RuntimeMethod*))Dictionary_2_get_Item_mC3E2914537EF15406FA2F725DB20CA60F190F4F6_gshared)(__this, ___key0, method);
}
// System.Boolean UnityEngine.TextEditor::PerformOperation(UnityEngine.TextEditor/TextEditOp,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_PerformOperation_mC8D7C480A86101BE510AB2ED83107110259C7821 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___operation0, bool ___textIsReadOnly1, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::get_hasSelection()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_get_hasSelection_mB5CEC2D56136DDE95D62226438FA4620E027D41B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::DeleteSelection()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.String UnityEngine.TextEditor::get_text()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Char System.String::get_Chars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70 (String_t* __this, int32_t ___index0, const RuntimeMethod* method);
// System.String System.String::Remove(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Remove_mA7DE3D6FE3344FD65108B33BD1DE8020D22ADAC0 (String_t* __this, int32_t ___startIndex0, int32_t ___count1, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::FindEndOfPreviousWord(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindEndOfPreviousWord_mDFB854C75C7B3BDB5920E004C1F106500966A8BF (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::FindStartOfNextWord(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindStartOfNextWord_m59724B3A53A023031EDC1E852721F58B980ED36C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, const RuntimeMethod* method);
// System.Int32 System.String::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline (String_t* __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::NextCodePointIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::PreviousCodePointIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::ClearCursorPos()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.String System.String::Substring(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B (String_t* __this, int32_t ___startIndex0, int32_t ___length1, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// System.String System.String::Insert(System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Insert_m6F5335C84ACB178D4141772E1D7F2EB7811990EB (String_t* __this, int32_t ___startIndex0, String_t* ___value1, const RuntimeMethod* method);
// System.String System.Char::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Char_ToString_mE0DE433463C56FD30A4F0A50539553B17147C2F8 (Il2CppChar* __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::ReplaceSelection(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ReplaceSelection_m13BC53A0C2F3B95346CAA422AB3FAD8E1BA0A44C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, String_t* ___replace0, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::DetectFocusChange()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_DetectFocusChange_mCD7E1E7B23D372E27A21C7A5012786C96EA962A0 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::GrabGraphicalCursorPos()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_GrabGraphicalCursorPos_m8B726D6524D664B81CC8D4EC0D11FFB51BDD236E (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.GUIStyle::GetCursorStringIndex(UnityEngine.Rect,UnityEngine.GUIContent,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___cursorPixelPosition2, const RuntimeMethod* method);
// System.Single UnityEngine.GUIStyle::get_lineHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_get_lineHeight_m2A3FC65C1395A047D28E3CC20015D4871729CC71 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::GetGraphicalLineStart(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_GetGraphicalLineStart_mEB3ECC40041B7A3A914DAD4F760C22E58ABAFDA9 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::GetGraphicalLineEnd(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_GetGraphicalLineEnd_mD8BFB1EA8BA9BE75DA35E35706955BFF96FFE7F6 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, const RuntimeMethod* method);
// System.Int32 System.String::IndexOf(System.Char,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t String_IndexOf_mAD7052CB25BA1D60A8F055AA89D09809F61233DB (String_t* __this, Il2CppChar ___value0, int32_t ___startIndex1, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::IndexOfEndOfLine(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_IndexOfEndOfLine_m4A524577C1989B9404AA7301741AB7F6286CF0A9 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___startIndex0, const RuntimeMethod* method);
// System.Int32 System.String::LastIndexOf(System.Char,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t String_LastIndexOf_m8DB57B87F39952A78925B5BF9BBB49B3EFA28155 (String_t* __this, Il2CppChar ___value0, int32_t ___startIndex1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Event::get_shift()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Event_get_shift_m7B2926A0EEEBF7D6FEB12B14FCC130A37F5E4697 (Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveCursorToPosition_Internal(UnityEngine.Vector2,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveCursorToPosition_Internal_m78070B113CA2AF5F9283EA1200BE889336AAB442 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___cursorPosition0, bool ___shift1, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Vector2::op_Addition(UnityEngine.Vector2,UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___a0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___b1, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::FindEndOfClassification(System.Int32,UnityEngine.TextEditor/Direction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, int32_t ___dir1, const RuntimeMethod* method);
// System.Int32 UnityEngine.Mathf::Max(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Mathf_Max_mAB2544BF70651EC36982F5F4EBD250AEE283335A (int32_t ___a0, int32_t ___b1, const RuntimeMethod* method);
// System.Int32 UnityEngine.Mathf::Min(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Mathf_Min_m8038BC2CE141C9AF3ECA2E31B88A9768423B1519 (int32_t ___a0, int32_t ___b1, const RuntimeMethod* method);
// System.Single UnityEngine.GUIUtility::get_pixelsPerPoint()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIUtility_get_pixelsPerPoint_mB5D6900CC67E192C0189890FBB163E5ECD662579 (const RuntimeMethod* method);
// UnityEngine.TextEditor/CharacterType UnityEngine.TextEditor::ClassifyChar(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::FindNextSeperator(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindNextSeperator_mBAD0845CFF4A4B87121612F879E6C83B4E7D4CE2 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___startPos0, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveRight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveRight_m634E85509D846218EAD1894FF67F7D9B8A61F9CA (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveLeft()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveLeft_m5EF461B1A8E54955FA49CFE44A30B5D56D58D59B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean System.Char::IsWhiteSpace(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Char_IsWhiteSpace_m23E361BAE86A2B42BEEA0F8362E033BACFEDB3FC (String_t* ___s0, int32_t ___index1, const RuntimeMethod* method);
// System.Boolean System.Char::IsLetterOrDigit(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Char_IsLetterOrDigit_mD4066056FDE44A25DBC022E73FED10C34CF642D8 (String_t* ___s0, int32_t ___index1, const RuntimeMethod* method);
// System.Int32 UnityEngine.TextEditor::FindPrevSeperator(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindPrevSeperator_m559E369D55926E701F6A79644019A2500378754C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___startPos0, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveWordRight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveWordRight_mFBBEA31EB6CD67F063ED3A6F2A343FBDAF08793C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveWordLeft()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveWordLeft_m76BE93FFEBB5E8A51EBD5BBCD4313681A2EC5638 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.RectOffset::get_left()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RectOffset_get_left_m3B3066D09D8C9C94826258386B609CDBFFF11910 (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.RectOffset::get_top()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RectOffset_get_top_m42000C7682185F03F23E7E0C3E8EC026FDBAB9D1 (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * __this, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.GUIStyle::CalcSize(UnityEngine.GUIContent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_CalcSize_m3B4ADD2AF66EFF1A273C10C0F77741EAD96F3F2D (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, const RuntimeMethod* method);
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * __this, float ___x0, float ___y1, const RuntimeMethod* method);
// System.Int32 UnityEngine.RectOffset::get_right()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RectOffset_get_right_m889468939F3F926FE21F8E81E23C0342D45615C6 (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.RectOffset::get_bottom()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t RectOffset_get_bottom_mDDEBF1389FC1B8DCD9FC15DF91E51D264925C00D (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * __this, const RuntimeMethod* method);
// System.String UnityEngine.GUIUtility::get_compositionString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37 (const RuntimeMethod* method);
// System.String System.String::Substring(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Substring_mB6B87FD76552BBF6D4E2B9F07F857FE051DCE190 (String_t* __this, int32_t ___startIndex0, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44 (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.GUIStyle::get_contentOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_get_contentOffset_mEDC41FC0FA4CBBF8E271A2F620305D16E7E36A1B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.Vector2::op_Subtraction(UnityEngine.Vector2,UnityEngine.Vector2)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_op_Subtraction_m6E536A8C72FEAA37FF8D5E26E11D6E71EB59599A_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___a0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___b1, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::set_contentOffset(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_contentOffset_m2EAB45D5CFBA13DFE580BD6805353BDE59D5A56D (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::set_Internal_clipOffset(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_Internal_clipOffset_mB7E8F11C269ECEE9F8277150C261E0C0534DEFBF (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value0, const RuntimeMethod* method);
// UnityEngine.Vector2 UnityEngine.GUIClip::UnclipToWindow(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIClip_UnclipToWindow_m32CAC364845EF5893B53AA6C36E4FB1EF1405E21 (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___pos0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIUtility::set_compositionCursorPos(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_compositionCursorPos_m895C29DAB9335BC53602E6D05D4FD622C37BFB8D (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::DrawWithTextSelection(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_DrawWithTextSelection_m0366243DD71AB06567B2E2AD777FC6E4585DA95F (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, int32_t ___firstSelectedCharacter3, int32_t ___lastSelectedCharacter4, const RuntimeMethod* method);
// System.Void UnityEngine.GUIStyle::DrawCursor(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_DrawCursor_m9E4A7C0BCD7E651B87B809B010DA75D2EE464676 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, int32_t ___character3, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveUp_m8FDBC52051A639319A86502D6056BC06BB78E66C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveDown()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveDown_m240765198B8A686EA80D018E8B71D435E2AFF89B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveLineStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveLineStart_mF1B12EFAFA0CAC5F8A2B9F282E20CA3D36850E2E (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveLineEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveLineEnd_m2DC31831A0D37F75BFA6CBB51FAFAD50CC966AF5 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveToStartOfNextWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveToStartOfNextWord_mA96D839CF3EB07F5CDF19762D5D2E6B9C4BAD36D (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveToEndOfPreviousWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveToEndOfPreviousWord_m51C33936E027A823E0F7500F4F1D2F8645823E40 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveTextStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveTextStart_mE75FFE843DA63613826F3A90D74FDBA8BB0DAEFC (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveTextEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveTextEnd_m25A227643D792D7D14149DBE67161C6A7843B739 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveParagraphForward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveParagraphForward_mD4466D00FDBEF6A3E9171F824531C65B495F3F55 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveParagraphBackward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveParagraphBackward_m47BF508866B9B3506FC829E9BCB6461C282AE56F (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveGraphicalLineStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveGraphicalLineStart_m74DA4B4DF3B68653DB4EC655D3092688F4B13506 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::MoveGraphicalLineEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveGraphicalLineEnd_m577F85B3D593F7A004DE79B595E3357484F04655 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectLeft()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectLeft_m518E7C7EBC18D6219ECC2454C043187986B973B1 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectRight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectRight_mC546506FCEC238ACA078ABFF78AF7D2194E42E48 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectUp_m8295F3E145EA8791A259AD4655E2FE8199E53D2E (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectDown()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectDown_mB098A57D287374CA1A522982D54BCAAA2F38C6B7 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectWordRight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectWordRight_mB94EF5DBF2D792E2FD9871312E23B737705E9A16 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectWordLeft()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectWordLeft_m9ED17611443EF88F11E5BF1E304ED3E30A5402DB (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectToEndOfPreviousWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectToEndOfPreviousWord_mCDC12CEF4FF8461F10C680730E7B98C3DD45CAD2 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectToStartOfNextWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectToStartOfNextWord_mE7ADBC51D9E0A68D3375612C4193787B661F42A7 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectTextStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectTextStart_m25834E49ED3D557CEC0ECAA129B0916309C16CB7 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectTextEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectTextEnd_m32FD60930FB84CD3C013FC067CC3FCB55973DA08 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::ExpandSelectGraphicalLineStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ExpandSelectGraphicalLineStart_m2968C0AE82AAF86E5D19F1B55C830237A171329B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::ExpandSelectGraphicalLineEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ExpandSelectGraphicalLineEnd_m92D7398F2E2B71A363F987FD9977B718B1CFBCDF (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectParagraphForward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectParagraphForward_m1B0F5BFA5639B8E863BE18672FECA9471420FC00 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectParagraphBackward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectParagraphBackward_m2C719D95116BCFEACD7ED4D9443B8B067969AE6F (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectGraphicalLineStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectGraphicalLineStart_mB5F111592C097455D485724EA0EA691AF70D5393 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectGraphicalLineEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectGraphicalLineEnd_mC6B13F73FDBEB9C38B137D894FFEB8DE3438536C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::Delete()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_Delete_mA8F15F6B7EE373DBC15A399F9C33A0B078FED6C5 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::Backspace()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_Backspace_m28CC7790088027A79B2F06F4FB3BEB65F40352CC (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::Cut()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_Cut_m8C5226EB2736F62C4D1AA2E513878462AF69E233 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::Copy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_Copy_mA09CAF84F8FFBAB60E0E5FE7EC68AAF1C814D11B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::Paste()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_Paste_m734B97FD4F98ADE4815DDE92A530EBB01F0D4781 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::SelectNone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectNone_m204A64B599049EAF1EA39EA72560DD017E02B5CD (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::DeleteWordBack()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_DeleteWordBack_mD5B1AA3E2F877EB51D2472C1308B217CA2F54A06 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::DeleteLineBack()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_DeleteLineBack_mD4520B7DDC6E616C2AF04DDFE23A4AC234437DE1 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::DeleteWordForward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_DeleteWordForward_m7BB52B567A1BBECD4663DF683FD2B996E58CF040 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.String UnityEngine.GUIStyle::Internal_GetSelectedRenderedText(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_Internal_GetSelectedRenderedText_mBB9578BE373E64754DAC9496DC4E2422B9CF438B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___localPosition0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___mContent1, int32_t ___selectIndex2, int32_t ___cursorIndex3, const RuntimeMethod* method);
// System.Void UnityEngine.GUIUtility::set_systemCopyBuffer(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_systemCopyBuffer_m1C5EAC38441C94C430AA13DF9942E1786CFCAC95 (String_t* ___value0, const RuntimeMethod* method);
// System.String System.String::Replace(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_m98184150DC4E2FBDF13E723BF5B7353D9602AC4D (String_t* __this, String_t* ___oldValue0, String_t* ___newValue1, const RuntimeMethod* method);
// System.String System.String::Replace(System.Char,System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_mD912844A1141FE8771F55255C4A8D29C80C47618 (String_t* __this, Il2CppChar ___oldChar0, Il2CppChar ___newChar1, const RuntimeMethod* method);
// System.String UnityEngine.GUIUtility::get_systemCopyBuffer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIUtility_get_systemCopyBuffer_m64CEF1CB0627F80D3CEEB458BA60DC9C1FA6141E (const RuntimeMethod* method);
// System.Boolean System.String::op_Inequality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Inequality_mDDA2DDED3E7EF042987EB7180EE3E88105F0AAE2 (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method);
// System.String UnityEngine.TextEditor::ReplaceNewlinesWithSpaces(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TextEditor_ReplaceNewlinesWithSpaces_mBFCCCAF5052A1435C1BCD13D7297D8E39BBE748E (String_t* ___value0, const RuntimeMethod* method);
// UnityEngine.Event UnityEngine.Event::KeyboardEvent(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * Event_KeyboardEvent_mEDF3A001AE1C3D3AC324784C48A835738CF050B2 (String_t* ___key0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>::set_Item(!0,!1)
inline void Dictionary_2_set_Item_m60C46D4985DD498C33D75B842121DD35929CF75E (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * __this, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___key0, int32_t ___value1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 *, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E *, int32_t, const RuntimeMethod*))Dictionary_2_set_Item_m372B8E717F9F74C215C8DD80965211B7F7AF2856_gshared)(__this, ___key0, ___value1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<UnityEngine.Event,UnityEngine.TextEditor/TextEditOp>::.ctor()
inline void Dictionary_2__ctor_m5F2CE464F67F4BDC4EB96CB769755BC675F66B18 (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 *, const RuntimeMethod*))Dictionary_2__ctor_mDD94B092289B595591F7BFA6575667F3FCD66B00_gshared)(__this, method);
}
// System.Void UnityEngine.TextEditor::MapKey(System.String,UnityEngine.TextEditor/TextEditOp)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC (String_t* ___key0, int32_t ___action1, const RuntimeMethod* method);
// UnityEngine.OperatingSystemFamily UnityEngine.SystemInfo::get_operatingSystemFamily()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SystemInfo_get_operatingSystemFamily_m797937E766B7FF87A5F1630263C49B814131DD95 (const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::OnLostFocus()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_OnLostFocus_m2E8FBC8864AA1B1EE5A56C13458618BE0EFFB783 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::OnFocus()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_OnFocus_mA391FDD8A6F669C33F4F47AA6190DFA7E6C1DDE8 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.Mathf::Clamp(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Mathf_Clamp_mAD0781EB7470594CD4482DD64A0D739E4E539C3C (int32_t ___value0, int32_t ___min1, int32_t ___max2, const RuntimeMethod* method);
// System.Void UnityEngine.TextEditor::ClampTextIndex(System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ClampTextIndex_m7848BDECC588F52DE17768F3CE2DF23E7A728DC5 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t* ___index0, const RuntimeMethod* method);
// System.Boolean UnityEngine.TextEditor::IsValidCodePointIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_IsValidCodePointIndex_mB0A21AB9662958E103DF439F8433D27796B46AF8 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Boolean System.Char::IsLowSurrogate(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Char_IsLowSurrogate_m44FA7AA923FDA925E1D536F3DA0A7E1E049E936E (Il2CppChar ___c0, const RuntimeMethod* method);
// System.Void UnityEngine.GUILayoutGroup::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUILayoutGroup__ctor_m633A8B9407554646DFD0BCAD5F9B39F34E7FCADA (GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * __this, const RuntimeMethod* method);
// System.Void UnityEngineInternal.GenericStack::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GenericStack__ctor_m42B668E8F293EE21F529A2679AA110C0877605DD (GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * __this, const RuntimeMethod* method);
// System.Void UnityEngine.GUILayoutUtility/LayoutCache::set_id(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LayoutCache_set_id_mDA2ECE692716F3D21BCA5B5B5D718A779BC6D545_inline (LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8 * __this, int32_t ___value0, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Object UnityEngine.GUIStateObjects::GetStateObject(System.Type,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GUIStateObjects_GetStateObject_mF668F2C3D2335FA4DE006C16C9C7C57ABB57CFD0 (Type_t * ___t0, int32_t ___controlID1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_TryGetValue_m0A88BBB063127AFAD853506A433ACB07D7AAD67E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_m71867F9FFBB49DE962FD0036368A0F6E87F30C90_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	bool V_1 = false;
	RuntimeObject * V_2 = NULL;
	int32_t G_B3_0 = 0;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var);
		Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * L_0 = ((GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_StaticFields*)il2cpp_codegen_static_fields_for(GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var))->get_s_StateCache_0();
		int32_t L_1 = ___controlID1;
		NullCheck(L_0);
		bool L_2;
		L_2 = Dictionary_2_TryGetValue_m0A88BBB063127AFAD853506A433ACB07D7AAD67E(L_0, L_1, (RuntimeObject **)(&V_0), /*hidden argument*/Dictionary_2_TryGetValue_m0A88BBB063127AFAD853506A433ACB07D7AAD67E_RuntimeMethod_var);
		if (!L_2)
		{
			goto IL_001e;
		}
	}
	{
		RuntimeObject * L_3 = V_0;
		NullCheck(L_3);
		Type_t * L_4;
		L_4 = Object_GetType_m571FE8360C10B98C23AAF1F066D92C08CC94F45B(L_3, /*hidden argument*/NULL);
		Type_t * L_5 = ___t0;
		G_B3_0 = ((((int32_t)((((RuntimeObject*)(Type_t *)L_4) == ((RuntimeObject*)(Type_t *)L_5))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_001f;
	}

IL_001e:
	{
		G_B3_0 = 1;
	}

IL_001f:
	{
		V_1 = (bool)G_B3_0;
		bool L_6 = V_1;
		if (!L_6)
		{
			goto IL_0039;
		}
	}
	{
		Type_t * L_7 = ___t0;
		RuntimeObject * L_8;
		L_8 = Activator_CreateInstance_m1BACAB5F4FBF138CCCB537DDCB0683A2AC064295(L_7, /*hidden argument*/NULL);
		V_0 = L_8;
		IL2CPP_RUNTIME_CLASS_INIT(GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var);
		Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * L_9 = ((GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_StaticFields*)il2cpp_codegen_static_fields_for(GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var))->get_s_StateCache_0();
		int32_t L_10 = ___controlID1;
		RuntimeObject * L_11 = V_0;
		NullCheck(L_9);
		Dictionary_2_set_Item_m71867F9FFBB49DE962FD0036368A0F6E87F30C90(L_9, L_10, L_11, /*hidden argument*/Dictionary_2_set_Item_m71867F9FFBB49DE962FD0036368A0F6E87F30C90_RuntimeMethod_var);
	}

IL_0039:
	{
		RuntimeObject * L_12 = V_0;
		V_2 = L_12;
		goto IL_003d;
	}

IL_003d:
	{
		RuntimeObject * L_13 = V_2;
		return L_13;
	}
}
// System.Void UnityEngine.GUIStateObjects::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStateObjects__cctor_m318F71B0633399F7D1206637D8C00D92CEC2FA11 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_mE7F9D51201F5A72BF4995CA0F3F0E866DB21E638_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F * L_0 = (Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F *)il2cpp_codegen_object_new(Dictionary_2_tE1E5B6327FFA2C7AE34A69E0011815C914771C2F_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mE7F9D51201F5A72BF4995CA0F3F0E866DB21E638(L_0, /*hidden argument*/Dictionary_2__ctor_mE7F9D51201F5A72BF4995CA0F3F0E866DB21E638_RuntimeMethod_var);
		((GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_StaticFields*)il2cpp_codegen_static_fields_for(GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var))->set_s_StateCache_0(L_0);
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
























// Conversion methods for marshalling of: UnityEngine.GUIStyle
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_pinvoke(const GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726& unmarshaled, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke& marshaled)
{
	Exception_t* ___m_Normal_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_Normal' of type 'GUIStyle': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_Normal_1Exception, NULL);
}
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_pinvoke_back(const GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke& marshaled, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726& unmarshaled)
{
	Exception_t* ___m_Normal_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_Normal' of type 'GUIStyle': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_Normal_1Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.GUIStyle
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_pinvoke_cleanup(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_pinvoke& marshaled)
{
}
























// Conversion methods for marshalling of: UnityEngine.GUIStyle
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_com(const GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726& unmarshaled, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com& marshaled)
{
	Exception_t* ___m_Normal_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_Normal' of type 'GUIStyle': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_Normal_1Exception, NULL);
}
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_com_back(const GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com& marshaled, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726& unmarshaled)
{
	Exception_t* ___m_Normal_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_Normal' of type 'GUIStyle': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_Normal_1Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.GUIStyle
IL2CPP_EXTERN_C void GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshal_com_cleanup(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_marshaled_com& marshaled)
{
}
// System.String UnityEngine.GUIStyle::get_rawName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_get_rawName_m1295BFC75B2924BEB81140B9476E5B97340A1713 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	typedef String_t* (*GUIStyle_get_rawName_m1295BFC75B2924BEB81140B9476E5B97340A1713_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_get_rawName_m1295BFC75B2924BEB81140B9476E5B97340A1713_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_rawName_m1295BFC75B2924BEB81140B9476E5B97340A1713_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_rawName()");
	String_t* icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.GUIStyle::set_rawName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_rawName_mFE7CE77C7654A7B1D68DDB557801C9D33896BDF1 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_set_rawName_mFE7CE77C7654A7B1D68DDB557801C9D33896BDF1_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, String_t*);
	static GUIStyle_set_rawName_mFE7CE77C7654A7B1D68DDB557801C9D33896BDF1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_set_rawName_mFE7CE77C7654A7B1D68DDB557801C9D33896BDF1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::set_rawName(System.String)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Font UnityEngine.GUIStyle::get_font()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * GUIStyle_get_font_mBDF4EDA551849623A213B09A30437C5AFDAF6BE4 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	typedef Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * (*GUIStyle_get_font_mBDF4EDA551849623A213B09A30437C5AFDAF6BE4_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_get_font_mBDF4EDA551849623A213B09A30437C5AFDAF6BE4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_font_mBDF4EDA551849623A213B09A30437C5AFDAF6BE4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_font()");
	Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.ImagePosition UnityEngine.GUIStyle::get_imagePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIStyle_get_imagePosition_m384E6DA06D9EE64871C2439EE5325C245FFEB4C8 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*GUIStyle_get_imagePosition_m384E6DA06D9EE64871C2439EE5325C245FFEB4C8_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_get_imagePosition_m384E6DA06D9EE64871C2439EE5325C245FFEB4C8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_imagePosition_m384E6DA06D9EE64871C2439EE5325C245FFEB4C8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_imagePosition()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.GUIStyle::set_alignment(UnityEngine.TextAnchor)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_alignment_mCF8FDA9DA149F528DCDC19680AEED46F25161D89 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_set_alignment_mCF8FDA9DA149F528DCDC19680AEED46F25161D89_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, int32_t);
	static GUIStyle_set_alignment_mCF8FDA9DA149F528DCDC19680AEED46F25161D89_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_set_alignment_mCF8FDA9DA149F528DCDC19680AEED46F25161D89_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::set_alignment(UnityEngine.TextAnchor)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.GUIStyle::get_wordWrap()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIStyle_get_wordWrap_m3852F7A584014D25A5CED400CBC1B9661ED5E01B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	typedef bool (*GUIStyle_get_wordWrap_m3852F7A584014D25A5CED400CBC1B9661ED5E01B_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_get_wordWrap_m3852F7A584014D25A5CED400CBC1B9661ED5E01B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_wordWrap_m3852F7A584014D25A5CED400CBC1B9661ED5E01B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_wordWrap()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.Vector2 UnityEngine.GUIStyle::get_contentOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_get_contentOffset_mEDC41FC0FA4CBBF8E271A2F620305D16E7E36A1B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		GUIStyle_get_contentOffset_Injected_m01479BB9A70925A53DBDF36B72D5FE82C9202256(__this, (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&V_0), /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.GUIStyle::set_contentOffset(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_contentOffset_m2EAB45D5CFBA13DFE580BD6805353BDE59D5A56D (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value0, const RuntimeMethod* method)
{
	{
		GUIStyle_set_contentOffset_Injected_mDBEAF5EF679081562A6CEFD6E208781AB0AE3245(__this, (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Single UnityEngine.GUIStyle::get_fixedWidth()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	typedef float (*GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_fixedWidth()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.GUIStyle::get_fixedHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	typedef float (*GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_fixedHeight()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.GUIStyle::get_stretchWidth()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIStyle_get_stretchWidth_m171F3A526E7FD0EB2FEF742F2BE125A72808A837 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	typedef bool (*GUIStyle_get_stretchWidth_m171F3A526E7FD0EB2FEF742F2BE125A72808A837_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_get_stretchWidth_m171F3A526E7FD0EB2FEF742F2BE125A72808A837_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_stretchWidth_m171F3A526E7FD0EB2FEF742F2BE125A72808A837_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_stretchWidth()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.GUIStyle::get_stretchHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIStyle_get_stretchHeight_mB249B43773569736BF1D1014F890484B17A96BE4 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	typedef bool (*GUIStyle_get_stretchHeight_mB249B43773569736BF1D1014F890484B17A96BE4_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_get_stretchHeight_mB249B43773569736BF1D1014F890484B17A96BE4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_stretchHeight_mB249B43773569736BF1D1014F890484B17A96BE4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_stretchHeight()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.GUIStyle::set_stretchHeight(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_stretchHeight_m36BB4A41AB08DF3286CB928688C6C4907134DEA9 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_set_stretchHeight_m36BB4A41AB08DF3286CB928688C6C4907134DEA9_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, bool);
	static GUIStyle_set_stretchHeight_m36BB4A41AB08DF3286CB928688C6C4907134DEA9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_set_stretchHeight_m36BB4A41AB08DF3286CB928688C6C4907134DEA9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::set_stretchHeight(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.GUIStyle::set_fontSize(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_fontSize_mFA02B9950E09F880976FD2FF646FB8AAEED1C5C6 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_set_fontSize_mFA02B9950E09F880976FD2FF646FB8AAEED1C5C6_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, int32_t);
	static GUIStyle_set_fontSize_mFA02B9950E09F880976FD2FF646FB8AAEED1C5C6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_set_fontSize_mFA02B9950E09F880976FD2FF646FB8AAEED1C5C6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::set_fontSize(System.Int32)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.GUIStyle::set_Internal_clipOffset(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_Internal_clipOffset_mB7E8F11C269ECEE9F8277150C261E0C0534DEFBF (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value0, const RuntimeMethod* method)
{
	{
		GUIStyle_set_Internal_clipOffset_Injected_m7BEA5BAB90B2593261777E75DBF28EA8201C5F93(__this, (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.IntPtr UnityEngine.GUIStyle::Internal_Create(UnityEngine.GUIStyle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t GUIStyle_Internal_Create_m1A826DEC0513F9B9C7E5C67D02D24BEA33783686 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___self0, const RuntimeMethod* method)
{
	typedef intptr_t (*GUIStyle_Internal_Create_m1A826DEC0513F9B9C7E5C67D02D24BEA33783686_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *);
	static GUIStyle_Internal_Create_m1A826DEC0513F9B9C7E5C67D02D24BEA33783686_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_Create_m1A826DEC0513F9B9C7E5C67D02D24BEA33783686_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_Create(UnityEngine.GUIStyle)");
	intptr_t icallRetVal = _il2cpp_icall_func(___self0);
	return icallRetVal;
}
// System.Void UnityEngine.GUIStyle::Internal_Destroy(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Destroy_m51A33779ABE8BAF80E5F975F9F5AE8D960CB4EE8 (intptr_t ___self0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_Destroy_m51A33779ABE8BAF80E5F975F9F5AE8D960CB4EE8_ftn) (intptr_t);
	static GUIStyle_Internal_Destroy_m51A33779ABE8BAF80E5F975F9F5AE8D960CB4EE8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_Destroy_m51A33779ABE8BAF80E5F975F9F5AE8D960CB4EE8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_Destroy(System.IntPtr)");
	_il2cpp_icall_func(___self0);
}
// System.IntPtr UnityEngine.GUIStyle::GetStyleStatePtr(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t GUIStyle_GetStyleStatePtr_mB1EEFB0E08D242D2B10272B5F2A78B23551E012E (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, int32_t ___idx0, const RuntimeMethod* method)
{
	typedef intptr_t (*GUIStyle_GetStyleStatePtr_mB1EEFB0E08D242D2B10272B5F2A78B23551E012E_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, int32_t);
	static GUIStyle_GetStyleStatePtr_mB1EEFB0E08D242D2B10272B5F2A78B23551E012E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_GetStyleStatePtr_mB1EEFB0E08D242D2B10272B5F2A78B23551E012E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::GetStyleStatePtr(System.Int32)");
	intptr_t icallRetVal = _il2cpp_icall_func(__this, ___idx0);
	return icallRetVal;
}
// System.IntPtr UnityEngine.GUIStyle::GetRectOffsetPtr(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t GUIStyle_GetRectOffsetPtr_mD3E24C1578BB69007E729CC624D264E1CD21D06A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, int32_t ___idx0, const RuntimeMethod* method)
{
	typedef intptr_t (*GUIStyle_GetRectOffsetPtr_mD3E24C1578BB69007E729CC624D264E1CD21D06A_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, int32_t);
	static GUIStyle_GetRectOffsetPtr_mD3E24C1578BB69007E729CC624D264E1CD21D06A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_GetRectOffsetPtr_mD3E24C1578BB69007E729CC624D264E1CD21D06A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::GetRectOffsetPtr(System.Int32)");
	intptr_t icallRetVal = _il2cpp_icall_func(__this, ___idx0);
	return icallRetVal;
}
// System.Single UnityEngine.GUIStyle::Internal_GetLineHeight(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_Internal_GetLineHeight_m64DD33A98E03CB492F5320C4DE3C352D1DED0DBA (intptr_t ___target0, const RuntimeMethod* method)
{
	typedef float (*GUIStyle_Internal_GetLineHeight_m64DD33A98E03CB492F5320C4DE3C352D1DED0DBA_ftn) (intptr_t);
	static GUIStyle_Internal_GetLineHeight_m64DD33A98E03CB492F5320C4DE3C352D1DED0DBA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_GetLineHeight_m64DD33A98E03CB492F5320C4DE3C352D1DED0DBA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_GetLineHeight(System.IntPtr)");
	float icallRetVal = _il2cpp_icall_func(___target0);
	return icallRetVal;
}
// System.Void UnityEngine.GUIStyle::Internal_Draw(UnityEngine.Rect,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Draw_mA0406F2B22C574C77BF1F3CE5125221BAE3EAF7F (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___screenRect0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, const RuntimeMethod* method)
{
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content1;
		bool L_1 = ___isHover2;
		bool L_2 = ___isActive3;
		bool L_3 = ___on4;
		bool L_4 = ___hasKeyboardFocus5;
		GUIStyle_Internal_Draw_Injected_mB08817EF206F76A1E2CF33199889F2BBC331F27A(__this, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___screenRect0), L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::Internal_Draw2(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Draw2_m0819148173653ADC27A83BC886C4B0A1DF840BB4 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, bool ___on3, const RuntimeMethod* method)
{
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content1;
		int32_t L_1 = ___controlID2;
		bool L_2 = ___on3;
		GUIStyle_Internal_Draw2_Injected_m2B6E7ADBB95678E90549769F40BAEA96334954A2(__this, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___position0), L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::Internal_DrawCursor(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_DrawCursor_m51748354AC84266F3148DF7CEEF01D022CE2B770 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___pos2, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___cursorColor3, const RuntimeMethod* method)
{
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content1;
		int32_t L_1 = ___pos2;
		GUIStyle_Internal_DrawCursor_Injected_m455B380779298710943DF4DBD8E9C7361D4AB245(__this, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___position0), L_0, L_1, (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)(&___cursorColor3), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::Internal_DrawWithTextSelection(UnityEngine.Rect,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Int32,UnityEngine.Color,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_DrawWithTextSelection_mBC957F07D4BDEDB10DE76C449830D230E41EB70C (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___screenRect0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, bool ___drawSelectionAsComposition6, int32_t ___cursorFirst7, int32_t ___cursorLast8, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___cursorColor9, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___selectionColor10, const RuntimeMethod* method)
{
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content1;
		bool L_1 = ___isHover2;
		bool L_2 = ___isActive3;
		bool L_3 = ___on4;
		bool L_4 = ___hasKeyboardFocus5;
		bool L_5 = ___drawSelectionAsComposition6;
		int32_t L_6 = ___cursorFirst7;
		int32_t L_7 = ___cursorLast8;
		GUIStyle_Internal_DrawWithTextSelection_Injected_m5C13B16DC9C2C5CE5B1B517F5AB5980C812F11FA(__this, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___screenRect0), L_0, L_1, L_2, L_3, L_4, L_5, L_6, L_7, (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)(&___cursorColor9), (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)(&___selectionColor10), /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector2 UnityEngine.GUIStyle::Internal_GetCursorPixelPosition(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_Internal_GetCursorPixelPosition_m69C855DB552A07BFE4F3FB5660540AE132F6F2B5 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___cursorStringIndex2, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content1;
		int32_t L_1 = ___cursorStringIndex2;
		GUIStyle_Internal_GetCursorPixelPosition_Injected_mF7899C9932D49D0AD222E71299429CB95AA2F76B(__this, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___position0), L_0, L_1, (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&V_0), /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2 = V_0;
		return L_2;
	}
}
// System.Int32 UnityEngine.GUIStyle::Internal_GetCursorStringIndex(UnityEngine.Rect,UnityEngine.GUIContent,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIStyle_Internal_GetCursorStringIndex_mCA5786C67C884DF622657D8C256994BFB6EADE77 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___cursorPixelPosition2, const RuntimeMethod* method)
{
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content1;
		int32_t L_1;
		L_1 = GUIStyle_Internal_GetCursorStringIndex_Injected_m8949C266ABD988A56BB60CEDF47B85E65BF7B51A(__this, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___position0), L_0, (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&___cursorPixelPosition2), /*hidden argument*/NULL);
		return L_1;
	}
}
// System.String UnityEngine.GUIStyle::Internal_GetSelectedRenderedText(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_Internal_GetSelectedRenderedText_mBB9578BE373E64754DAC9496DC4E2422B9CF438B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___localPosition0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___mContent1, int32_t ___selectIndex2, int32_t ___cursorIndex3, const RuntimeMethod* method)
{
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___mContent1;
		int32_t L_1 = ___selectIndex2;
		int32_t L_2 = ___cursorIndex3;
		String_t* L_3;
		L_3 = GUIStyle_Internal_GetSelectedRenderedText_Injected_mFBB4298AD4A38058CC247D7DDE6C7413989D1036(__this, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___localPosition0), L_0, L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// UnityEngine.Vector2 UnityEngine.GUIStyle::Internal_CalcSize(UnityEngine.GUIContent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_Internal_CalcSize_m0D940B98466D557B889D8BD0F93F3D9D4B6F16D6 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content0;
		GUIStyle_Internal_CalcSize_Injected_m9C64AC5BB7801E30225703FB042E42061B89E636(__this, L_0, (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&V_0), /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector2 UnityEngine.GUIStyle::Internal_CalcSizeWithConstraints(UnityEngine.GUIContent,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_Internal_CalcSizeWithConstraints_m992088CCE4FE1592F0BFEDA168AD79EE9D3FF646 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___maxSize1, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content0;
		GUIStyle_Internal_CalcSizeWithConstraints_Injected_mB165D16DAE4455C9901D0A6C1B8751F2E8F8E858(__this, L_0, (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&___maxSize1), (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&V_0), /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1 = V_0;
		return L_1;
	}
}
// System.Single UnityEngine.GUIStyle::Internal_CalcHeight(UnityEngine.GUIContent,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_Internal_CalcHeight_mE777C84ABE0D0473DD2DA866B4F3F2783EE03721 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, float ___width1, const RuntimeMethod* method)
{
	typedef float (*GUIStyle_Internal_CalcHeight_mE777C84ABE0D0473DD2DA866B4F3F2783EE03721_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, float);
	static GUIStyle_Internal_CalcHeight_mE777C84ABE0D0473DD2DA866B4F3F2783EE03721_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_CalcHeight_mE777C84ABE0D0473DD2DA866B4F3F2783EE03721_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_CalcHeight(UnityEngine.GUIContent,System.Single)");
	float icallRetVal = _il2cpp_icall_func(__this, ___content0, ___width1);
	return icallRetVal;
}
// UnityEngine.Vector2 UnityEngine.GUIStyle::Internal_CalcMinMaxWidth(UnityEngine.GUIContent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_Internal_CalcMinMaxWidth_m1607C544FC2FB31E8340A354D978C5A49A23D86B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content0;
		GUIStyle_Internal_CalcMinMaxWidth_Injected_m4E48F9D7027E8D75326DF02B0D01C6AEFB533BD8(__this, L_0, (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&V_0), /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.GUIStyle::SetMouseTooltip(System.String,UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_SetMouseTooltip_m8D24990EC470DACD68AF2A0BFABC7414DD183656 (String_t* ___tooltip0, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___screenRect1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___tooltip0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		GUIStyle_SetMouseTooltip_Injected_m165B8143962BC2EF7F0FE454BBAB1E358A84ED76(L_0, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___screenRect1), /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.GUIStyle::IsTooltipActive(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIStyle_IsTooltipActive_mBA66A54E1D3D4CE0C815D8FE9D3205947279EE87 (String_t* ___tooltip0, const RuntimeMethod* method)
{
	typedef bool (*GUIStyle_IsTooltipActive_mBA66A54E1D3D4CE0C815D8FE9D3205947279EE87_ftn) (String_t*);
	static GUIStyle_IsTooltipActive_mBA66A54E1D3D4CE0C815D8FE9D3205947279EE87_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_IsTooltipActive_mBA66A54E1D3D4CE0C815D8FE9D3205947279EE87_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::IsTooltipActive(System.String)");
	bool icallRetVal = _il2cpp_icall_func(___tooltip0);
	return icallRetVal;
}
// System.Single UnityEngine.GUIStyle::Internal_GetCursorFlashOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_Internal_GetCursorFlashOffset_mBD1D699C55B4C0503F60D37A335D2C71B42B8344 (const RuntimeMethod* method)
{
	typedef float (*GUIStyle_Internal_GetCursorFlashOffset_mBD1D699C55B4C0503F60D37A335D2C71B42B8344_ftn) ();
	static GUIStyle_Internal_GetCursorFlashOffset_mBD1D699C55B4C0503F60D37A335D2C71B42B8344_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_GetCursorFlashOffset_mBD1D699C55B4C0503F60D37A335D2C71B42B8344_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_GetCursorFlashOffset()");
	float icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Void UnityEngine.GUIStyle::SetDefaultFont(UnityEngine.Font)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_SetDefaultFont_m4C316C5C11BE5C09B36934F23D3694C13022D6C1 (Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 * ___font0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_SetDefaultFont_m4C316C5C11BE5C09B36934F23D3694C13022D6C1_ftn) (Font_tB53D3F362CB1A0B92307B362826F212AE2D2A6A9 *);
	static GUIStyle_SetDefaultFont_m4C316C5C11BE5C09B36934F23D3694C13022D6C1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_SetDefaultFont_m4C316C5C11BE5C09B36934F23D3694C13022D6C1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::SetDefaultFont(UnityEngine.Font)");
	_il2cpp_icall_func(___font0);
}
// System.Void UnityEngine.GUIStyle::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle__ctor_mDA0E00D0017FC0B2FC333C5DD6E1EDBAE3BCB8E3 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		intptr_t L_0;
		L_0 = GUIStyle_Internal_Create_m1A826DEC0513F9B9C7E5C67D02D24BEA33783686(__this, /*hidden argument*/NULL);
		__this->set_m_Ptr_0((intptr_t)L_0);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::Finalize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Finalize_m8FE33DAF2928CEDFE7DA82B5D95251C3FCB30ACC (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
	}

IL_0001:
	try
	{ // begin try (depth: 1)
		{
			intptr_t L_0 = __this->get_m_Ptr_0();
			bool L_1;
			L_1 = IntPtr_op_Inequality_m212AF0E66AA81FEDC982B1C8A44ADDA24B995EB8((intptr_t)L_0, (intptr_t)(0), /*hidden argument*/NULL);
			V_0 = L_1;
			bool L_2 = V_0;
			if (!L_2)
			{
				goto IL_002f;
			}
		}

IL_0016:
		{
			intptr_t L_3 = __this->get_m_Ptr_0();
			IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
			GUIStyle_Internal_Destroy_m51A33779ABE8BAF80E5F975F9F5AE8D960CB4EE8((intptr_t)L_3, /*hidden argument*/NULL);
			__this->set_m_Ptr_0((intptr_t)(0));
		}

IL_002f:
		{
			IL2CPP_LEAVE(0x39, FINALLY_0031);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0031;
	}

FINALLY_0031:
	{ // begin finally (depth: 1)
		Object_Finalize_mC59C83CF4F7707E425FFA6362931C25D4C36676A(__this, /*hidden argument*/NULL);
		IL2CPP_END_FINALLY(49)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(49)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x39, IL_0039)
	}

IL_0039:
	{
		return;
	}
}
// System.String UnityEngine.GUIStyle::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_get_name_mDC1371698EB6B92D459AA165EFFE5983711C4BB6 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* G_B2_0 = NULL;
	String_t* G_B1_0 = NULL;
	{
		String_t* L_0 = __this->get_m_Name_13();
		String_t* L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_001a;
		}
	}
	{
		String_t* L_2;
		L_2 = GUIStyle_get_rawName_m1295BFC75B2924BEB81140B9476E5B97340A1713(__this, /*hidden argument*/NULL);
		String_t* L_3 = L_2;
		V_0 = L_3;
		__this->set_m_Name_13(L_3);
		String_t* L_4 = V_0;
		G_B2_0 = L_4;
	}

IL_001a:
	{
		V_1 = G_B2_0;
		goto IL_001d;
	}

IL_001d:
	{
		String_t* L_5 = V_1;
		return L_5;
	}
}
// System.Void UnityEngine.GUIStyle::set_name(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_name_m8CC2C59EC03B61F7BC8E4276B509ACCE772C7AA5 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___value0;
		__this->set_m_Name_13(L_0);
		String_t* L_1 = ___value0;
		GUIStyle_set_rawName_mFE7CE77C7654A7B1D68DDB557801C9D33896BDF1(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.GUIStyleState UnityEngine.GUIStyle::get_normal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * GUIStyle_get_normal_mAD82F2E3C188C5B112B82807398D61B9998E9CDE (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * V_0 = NULL;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * V_1 = NULL;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * G_B2_0 = NULL;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * G_B1_0 = NULL;
	{
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_0 = __this->get_m_Normal_1();
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_0021;
		}
	}
	{
		intptr_t L_2;
		L_2 = GUIStyle_GetStyleStatePtr_mB1EEFB0E08D242D2B10272B5F2A78B23551E012E(__this, 0, /*hidden argument*/NULL);
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_3;
		L_3 = GUIStyleState_GetGUIStyleState_mE8758CDE0E9E627ECDE92F60509A19B91922964C(__this, (intptr_t)L_2, /*hidden argument*/NULL);
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_4 = L_3;
		V_0 = L_4;
		__this->set_m_Normal_1(L_4);
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_5 = V_0;
		G_B2_0 = L_5;
	}

IL_0021:
	{
		V_1 = G_B2_0;
		goto IL_0024;
	}

IL_0024:
	{
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_6 = V_1;
		return L_6;
	}
}
// UnityEngine.RectOffset UnityEngine.GUIStyle::get_margin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * GUIStyle_get_margin_m1AF5B34B3BE9B514A8B189EAE16F976245C4A363 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * V_0 = NULL;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * V_1 = NULL;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * G_B2_0 = NULL;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * G_B1_0 = NULL;
	{
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_0 = __this->get_m_Margin_11();
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_0021;
		}
	}
	{
		intptr_t L_2;
		L_2 = GUIStyle_GetRectOffsetPtr_mD3E24C1578BB69007E729CC624D264E1CD21D06A(__this, 1, /*hidden argument*/NULL);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_3 = (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 *)il2cpp_codegen_object_new(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_il2cpp_TypeInfo_var);
		RectOffset__ctor_mA519A9F678D6B88731C3F6A67E0DA9092A4596D4(L_3, __this, (intptr_t)L_2, /*hidden argument*/NULL);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_4 = L_3;
		V_0 = L_4;
		__this->set_m_Margin_11(L_4);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_5 = V_0;
		G_B2_0 = L_5;
	}

IL_0021:
	{
		V_1 = G_B2_0;
		goto IL_0024;
	}

IL_0024:
	{
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_6 = V_1;
		return L_6;
	}
}
// UnityEngine.RectOffset UnityEngine.GUIStyle::get_padding()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * V_0 = NULL;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * V_1 = NULL;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * G_B2_0 = NULL;
	RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * G_B1_0 = NULL;
	{
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_0 = __this->get_m_Padding_10();
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_0021;
		}
	}
	{
		intptr_t L_2;
		L_2 = GUIStyle_GetRectOffsetPtr_mD3E24C1578BB69007E729CC624D264E1CD21D06A(__this, 2, /*hidden argument*/NULL);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_3 = (RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 *)il2cpp_codegen_object_new(RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70_il2cpp_TypeInfo_var);
		RectOffset__ctor_mA519A9F678D6B88731C3F6A67E0DA9092A4596D4(L_3, __this, (intptr_t)L_2, /*hidden argument*/NULL);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_4 = L_3;
		V_0 = L_4;
		__this->set_m_Padding_10(L_4);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_5 = V_0;
		G_B2_0 = L_5;
	}

IL_0021:
	{
		V_1 = G_B2_0;
		goto IL_0024;
	}

IL_0024:
	{
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_6 = V_1;
		return L_6;
	}
}
// System.Single UnityEngine.GUIStyle::get_lineHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_get_lineHeight_m2A3FC65C1395A047D28E3CC20015D4871729CC71 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		intptr_t L_0 = __this->get_m_Ptr_0();
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		float L_1;
		L_1 = GUIStyle_Internal_GetLineHeight_m64DD33A98E03CB492F5320C4DE3C352D1DED0DBA((intptr_t)L_0, /*hidden argument*/NULL);
		float L_2;
		L_2 = bankers_roundf(L_1);
		return L_2;
	}
}
// System.Void UnityEngine.GUIStyle::Draw(UnityEngine.Rect,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Draw_m8A753264FF640DBAA021B2D7E9BD4E6F471A348B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, bool ___isHover1, bool ___isActive2, bool ___on3, bool ___hasKeyboardFocus4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ((GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields*)il2cpp_codegen_static_fields_for(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var))->get_none_6();
		bool L_2 = ___isHover1;
		bool L_3 = ___isActive2;
		bool L_4 = ___on3;
		bool L_5 = ___hasKeyboardFocus4;
		GUIStyle_Draw_mA26521B967422FB04437D5AE0D0BE3EAF0FFF5EE(__this, L_0, L_1, (-1), L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::Draw(UnityEngine.Rect,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Draw_mF228532CAE3828C7F67CF10CAD21F784FA45DBDD (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, const RuntimeMethod* method)
{
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ___content1;
		bool L_2 = ___isHover2;
		bool L_3 = ___isActive3;
		bool L_4 = ___on4;
		bool L_5 = ___hasKeyboardFocus5;
		GUIStyle_Draw_mA26521B967422FB04437D5AE0D0BE3EAF0FFF5EE(__this, L_0, L_1, (-1), L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::Draw(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Draw_mBD1F338B563A6237E3617222C91015B9468BFDC5 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, bool ___on3, const RuntimeMethod* method)
{
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ___content1;
		int32_t L_2 = ___controlID2;
		bool L_3 = ___on3;
		GUIStyle_Draw_mA26521B967422FB04437D5AE0D0BE3EAF0FFF5EE(__this, L_0, L_1, L_2, (bool)0, (bool)0, L_3, (bool)0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::Draw(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Draw_mE548BD5036F0311925375E002619553086E0A61A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, bool ___on3, bool ___hover4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ___content1;
		int32_t L_2 = ___controlID2;
		bool L_3 = ___hover4;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_4;
		L_4 = GUIUtility_get_hotControl_m70A913241C32305A380F4DB4A3F1B37BB3401E5A(/*hidden argument*/NULL);
		int32_t L_5 = ___controlID2;
		bool L_6 = ___on3;
		int32_t L_7 = ___controlID2;
		bool L_8;
		L_8 = GUIUtility_HasKeyFocus_m1CF44E6F83A22DB0B5F2148C68AA7DEC0BB94E4F(L_7, /*hidden argument*/NULL);
		GUIStyle_Draw_mA26521B967422FB04437D5AE0D0BE3EAF0FFF5EE(__this, L_0, L_1, L_2, L_3, (bool)((((int32_t)L_4) == ((int32_t)L_5))? 1 : 0), L_6, L_8, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::Draw(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Draw_mA26521B967422FB04437D5AE0D0BE3EAF0FFF5EE (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlId2, bool ___isHover3, bool ___isActive4, bool ___on5, bool ___hasKeyboardFocus6, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0 = ___controlId2;
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)(-1)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001d;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_2 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_3 = ___content1;
		bool L_4 = ___isHover3;
		bool L_5 = ___isActive4;
		bool L_6 = ___on5;
		bool L_7 = ___hasKeyboardFocus6;
		GUIStyle_Internal_Draw_mA0406F2B22C574C77BF1F3CE5125221BAE3EAF7F(__this, L_2, L_3, L_4, L_5, L_6, L_7, /*hidden argument*/NULL);
		goto IL_0029;
	}

IL_001d:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_8 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_9 = ___content1;
		int32_t L_10 = ___controlId2;
		bool L_11 = ___on5;
		GUIStyle_Internal_Draw2_m0819148173653ADC27A83BC886C4B0A1DF840BB4(__this, L_8, L_9, L_10, L_11, /*hidden argument*/NULL);
	}

IL_0029:
	{
		return;
	}
}
// System.Void UnityEngine.GUIStyle::DrawCursor(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_DrawCursor_m9E4A7C0BCD7E651B87B809B010DA75D2EE464676 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, int32_t ___character3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * V_0 = NULL;
	bool V_1 = false;
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  V_2;
	memset((&V_2), 0, sizeof(V_2));
	float V_3 = 0.0f;
	float V_4 = 0.0f;
	bool V_5 = false;
	int32_t G_B4_0 = 0;
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_0;
		L_0 = Event_get_current_m069E3E742E6CBC32C3BC958B85153E75B0192443(/*hidden argument*/NULL);
		V_0 = L_0;
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_1 = V_0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = Event_get_type_mA5010AB8C34B098E0783949046C708B9E1BA811D(L_1, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)7))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0088;
		}
	}
	{
		Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5((Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)(&V_2), (0.0f), (0.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * L_4;
		L_4 = GUI_get_skin_mCD2A03F408ABBA7816C52148D92A8DC836FBDE2F(/*hidden argument*/NULL);
		NullCheck(L_4);
		GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * L_5;
		L_5 = GUISkin_get_settings_m10680CA935A2122970FF245119CB9D428B4920E8(L_4, /*hidden argument*/NULL);
		NullCheck(L_5);
		float L_6;
		L_6 = GUISettings_get_cursorFlashSpeed_mA8D2966F6AB12D282ECA5C56558FE74B71C125FC(L_5, /*hidden argument*/NULL);
		V_3 = L_6;
		float L_7;
		L_7 = Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		float L_8;
		L_8 = GUIStyle_Internal_GetCursorFlashOffset_mBD1D699C55B4C0503F60D37A335D2C71B42B8344(/*hidden argument*/NULL);
		float L_9 = V_3;
		float L_10 = V_3;
		V_4 = ((float)((float)(fmodf(((float)il2cpp_codegen_subtract((float)L_7, (float)L_8)), L_9))/(float)L_10));
		float L_11 = V_3;
		if ((((float)L_11) == ((float)(0.0f))))
		{
			goto IL_0064;
		}
	}
	{
		float L_12 = V_4;
		G_B4_0 = ((((float)L_12) < ((float)(0.5f)))? 1 : 0);
		goto IL_0065;
	}

IL_0064:
	{
		G_B4_0 = 1;
	}

IL_0065:
	{
		V_5 = (bool)G_B4_0;
		bool L_13 = V_5;
		if (!L_13)
		{
			goto IL_007b;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * L_14;
		L_14 = GUI_get_skin_mCD2A03F408ABBA7816C52148D92A8DC836FBDE2F(/*hidden argument*/NULL);
		NullCheck(L_14);
		GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * L_15;
		L_15 = GUISkin_get_settings_m10680CA935A2122970FF245119CB9D428B4920E8(L_14, /*hidden argument*/NULL);
		NullCheck(L_15);
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_16;
		L_16 = GUISettings_get_cursorColor_m353344B00E67F3084AE61F9E4FFEDD17874578F0(L_15, /*hidden argument*/NULL);
		V_2 = L_16;
	}

IL_007b:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_17 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_18 = ___content1;
		int32_t L_19 = ___character3;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_20 = V_2;
		GUIStyle_Internal_DrawCursor_m51748354AC84266F3148DF7CEEF01D022CE2B770(__this, L_17, L_18, L_19, L_20, /*hidden argument*/NULL);
	}

IL_0088:
	{
		return;
	}
}
// System.Void UnityEngine.GUIStyle::DrawWithTextSelection(UnityEngine.Rect,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Int32,System.Int32,System.Boolean,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_DrawWithTextSelection_mD4E916B0D43FCA792CB25F4604E0A897E8186E13 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isActive2, bool ___hasKeyboardFocus3, int32_t ___firstSelectedCharacter4, int32_t ___lastSelectedCharacter5, bool ___drawSelectionAsComposition6, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___selectionColor7, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  V_0;
	memset((&V_0), 0, sizeof(V_0));
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	bool V_3 = false;
	bool V_4 = false;
	int32_t G_B3_0 = 0;
	{
		Color__ctor_m679019E6084BF7A6F82590F66F5F695F6A50ECC5((Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)(&V_0), (0.0f), (0.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * L_0;
		L_0 = GUI_get_skin_mCD2A03F408ABBA7816C52148D92A8DC836FBDE2F(/*hidden argument*/NULL);
		NullCheck(L_0);
		GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * L_1;
		L_1 = GUISkin_get_settings_m10680CA935A2122970FF245119CB9D428B4920E8(L_0, /*hidden argument*/NULL);
		NullCheck(L_1);
		float L_2;
		L_2 = GUISettings_get_cursorFlashSpeed_mA8D2966F6AB12D282ECA5C56558FE74B71C125FC(L_1, /*hidden argument*/NULL);
		V_1 = L_2;
		float L_3;
		L_3 = Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		float L_4;
		L_4 = GUIStyle_Internal_GetCursorFlashOffset_mBD1D699C55B4C0503F60D37A335D2C71B42B8344(/*hidden argument*/NULL);
		float L_5 = V_1;
		float L_6 = V_1;
		V_2 = ((float)((float)(fmodf(((float)il2cpp_codegen_subtract((float)L_3, (float)L_4)), L_5))/(float)L_6));
		float L_7 = V_1;
		if ((((float)L_7) == ((float)(0.0f))))
		{
			goto IL_004e;
		}
	}
	{
		float L_8 = V_2;
		G_B3_0 = ((((float)L_8) < ((float)(0.5f)))? 1 : 0);
		goto IL_004f;
	}

IL_004e:
	{
		G_B3_0 = 1;
	}

IL_004f:
	{
		V_4 = (bool)G_B3_0;
		bool L_9 = V_4;
		if (!L_9)
		{
			goto IL_0065;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * L_10;
		L_10 = GUI_get_skin_mCD2A03F408ABBA7816C52148D92A8DC836FBDE2F(/*hidden argument*/NULL);
		NullCheck(L_10);
		GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * L_11;
		L_11 = GUISkin_get_settings_m10680CA935A2122970FF245119CB9D428B4920E8(L_10, /*hidden argument*/NULL);
		NullCheck(L_11);
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_12;
		L_12 = GUISettings_get_cursorColor_m353344B00E67F3084AE61F9E4FFEDD17874578F0(L_11, /*hidden argument*/NULL);
		V_0 = L_12;
	}

IL_0065:
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_13;
		L_13 = Event_get_current_m069E3E742E6CBC32C3BC958B85153E75B0192443(/*hidden argument*/NULL);
		NullCheck(L_13);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_14;
		L_14 = Event_get_mousePosition_m4D2A80BE0CF9A6D2CE8289C4815807493B3449A9(L_13, /*hidden argument*/NULL);
		bool L_15;
		L_15 = Rect_Contains_m8438BA185AD95D6C50E7A2CF9DD30FBA044CE0B2((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___position0), L_14, /*hidden argument*/NULL);
		V_3 = L_15;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_16 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_17 = ___content1;
		bool L_18 = V_3;
		bool L_19 = ___isActive2;
		bool L_20 = ___hasKeyboardFocus3;
		bool L_21 = ___drawSelectionAsComposition6;
		int32_t L_22 = ___firstSelectedCharacter4;
		int32_t L_23 = ___lastSelectedCharacter5;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_24 = V_0;
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_25 = ___selectionColor7;
		GUIStyle_Internal_DrawWithTextSelection_mBC957F07D4BDEDB10DE76C449830D230E41EB70C(__this, L_16, L_17, L_18, L_19, (bool)0, L_20, L_21, L_22, L_23, L_24, L_25, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::DrawWithTextSelection(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_DrawWithTextSelection_m6A144949389804F371C359F159C9E7DAA1BEDA9A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, int32_t ___firstSelectedCharacter3, int32_t ___lastSelectedCharacter4, bool ___drawSelectionAsComposition5, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t G_B2_0 = 0;
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * G_B2_1 = NULL;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  G_B2_2;
	memset((&G_B2_2), 0, sizeof(G_B2_2));
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * G_B2_3 = NULL;
	int32_t G_B1_0 = 0;
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * G_B1_1 = NULL;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  G_B1_2;
	memset((&G_B1_2), 0, sizeof(G_B1_2));
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * G_B1_3 = NULL;
	int32_t G_B3_0 = 0;
	int32_t G_B3_1 = 0;
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * G_B3_2 = NULL;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  G_B3_3;
	memset((&G_B3_3), 0, sizeof(G_B3_3));
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * G_B3_4 = NULL;
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ___content1;
		int32_t L_2 = ___controlID2;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_3;
		L_3 = GUIUtility_get_hotControl_m70A913241C32305A380F4DB4A3F1B37BB3401E5A(/*hidden argument*/NULL);
		int32_t L_4 = ___controlID2;
		int32_t L_5;
		L_5 = GUIUtility_get_keyboardControl_mC111A10FE792FA94E3859C5BC704D611F8768BE1(/*hidden argument*/NULL);
		G_B1_0 = ((((int32_t)L_2) == ((int32_t)L_3))? 1 : 0);
		G_B1_1 = L_1;
		G_B1_2 = L_0;
		G_B1_3 = __this;
		if ((!(((uint32_t)L_4) == ((uint32_t)L_5))))
		{
			G_B2_0 = ((((int32_t)L_2) == ((int32_t)L_3))? 1 : 0);
			G_B2_1 = L_1;
			G_B2_2 = L_0;
			G_B2_3 = __this;
			goto IL_001b;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		bool L_6 = ((GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_StaticFields*)il2cpp_codegen_static_fields_for(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var))->get_showKeyboardFocus_14();
		G_B3_0 = ((int32_t)(L_6));
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		G_B3_3 = G_B1_2;
		G_B3_4 = G_B1_3;
		goto IL_001c;
	}

IL_001b:
	{
		G_B3_0 = 0;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
		G_B3_3 = G_B2_2;
		G_B3_4 = G_B2_3;
	}

IL_001c:
	{
		int32_t L_7 = ___firstSelectedCharacter3;
		int32_t L_8 = ___lastSelectedCharacter4;
		bool L_9 = ___drawSelectionAsComposition5;
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * L_10;
		L_10 = GUI_get_skin_mCD2A03F408ABBA7816C52148D92A8DC836FBDE2F(/*hidden argument*/NULL);
		NullCheck(L_10);
		GUISettings_tB85473DFD6EF025A06EAD867197A4478A41008D0 * L_11;
		L_11 = GUISkin_get_settings_m10680CA935A2122970FF245119CB9D428B4920E8(L_10, /*hidden argument*/NULL);
		NullCheck(L_11);
		Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  L_12;
		L_12 = GUISettings_get_selectionColor_m2CA908F3709FAD0C62822F00D3CC79B861B04933(L_11, /*hidden argument*/NULL);
		NullCheck(G_B3_4);
		GUIStyle_DrawWithTextSelection_mD4E916B0D43FCA792CB25F4604E0A897E8186E13(G_B3_4, G_B3_3, G_B3_2, (bool)G_B3_1, (bool)G_B3_0, L_7, L_8, L_9, L_12, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::DrawWithTextSelection(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_DrawWithTextSelection_m0366243DD71AB06567B2E2AD777FC6E4585DA95F (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, int32_t ___firstSelectedCharacter3, int32_t ___lastSelectedCharacter4, const RuntimeMethod* method)
{
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ___content1;
		int32_t L_2 = ___controlID2;
		int32_t L_3 = ___firstSelectedCharacter3;
		int32_t L_4 = ___lastSelectedCharacter4;
		GUIStyle_DrawWithTextSelection_m6A144949389804F371C359F159C9E7DAA1BEDA9A(__this, L_0, L_1, L_2, L_3, L_4, (bool)0, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.GUIStyle UnityEngine.GUIStyle::get_none()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * GUIStyle_get_none_mE13C9D26505C972F8697EE0E0E66D169D6D731A1 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * G_B2_0 = NULL;
	GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * G_B1_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = ((GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_StaticFields*)il2cpp_codegen_static_fields_for(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var))->get_s_None_15();
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_0014;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_2 = (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *)il2cpp_codegen_object_new(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		GUIStyle__ctor_mDA0E00D0017FC0B2FC333C5DD6E1EDBAE3BCB8E3(L_2, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_3 = L_2;
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		((GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_StaticFields*)il2cpp_codegen_static_fields_for(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var))->set_s_None_15(L_3);
		G_B2_0 = L_3;
	}

IL_0014:
	{
		return G_B2_0;
	}
}
// UnityEngine.Vector2 UnityEngine.GUIStyle::GetCursorPixelPosition(UnityEngine.Rect,UnityEngine.GUIContent,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_GetCursorPixelPosition_m8D4E34D8BFB582440B88F54643D095DF13DEA4F3 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___cursorStringIndex2, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ___content1;
		int32_t L_2 = ___cursorStringIndex2;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_3;
		L_3 = GUIStyle_Internal_GetCursorPixelPosition_m69C855DB552A07BFE4F3FB5660540AE132F6F2B5(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_000d;
	}

IL_000d:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4 = V_0;
		return L_4;
	}
}
// System.Int32 UnityEngine.GUIStyle::GetCursorStringIndex(UnityEngine.Rect,UnityEngine.GUIContent,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___cursorPixelPosition2, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ___content1;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2 = ___cursorPixelPosition2;
		int32_t L_3;
		L_3 = GUIStyle_Internal_GetCursorStringIndex_mCA5786C67C884DF622657D8C256994BFB6EADE77(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_4 = V_0;
		return L_4;
	}
}
// UnityEngine.Vector2 UnityEngine.GUIStyle::CalcSize(UnityEngine.GUIContent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_CalcSize_m3B4ADD2AF66EFF1A273C10C0F77741EAD96F3F2D (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content0;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1;
		L_1 = GUIStyle_Internal_CalcSize_m0D940B98466D557B889D8BD0F93F3D9D4B6F16D6(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Vector2 UnityEngine.GUIStyle::CalcSizeWithConstraints(UnityEngine.GUIContent,UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  GUIStyle_CalcSizeWithConstraints_m1D8877ED4962531437EDA31D97DC01728150D5B5 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___constraints1, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content0;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1 = ___constraints1;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2;
		L_2 = GUIStyle_Internal_CalcSizeWithConstraints_m992088CCE4FE1592F0BFEDA168AD79EE9D3FF646(__this, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000c;
	}

IL_000c:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_3 = V_0;
		return L_3;
	}
}
// System.Single UnityEngine.GUIStyle::CalcHeight(UnityEngine.GUIContent,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIStyle_CalcHeight_m120220D334AEC6B33F4767EA54FE78CEC09FBCC9 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, float ___width1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content0;
		float L_1 = ___width1;
		float L_2;
		L_2 = GUIStyle_Internal_CalcHeight_mE777C84ABE0D0473DD2DA866B4F3F2783EE03721(__this, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000c;
	}

IL_000c:
	{
		float L_3 = V_0;
		return L_3;
	}
}
// System.Boolean UnityEngine.GUIStyle::get_isHeightDependantOnWidth()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIStyle_get_isHeightDependantOnWidth_m559444B8145A3EF17F36F3376CF60208048C3013 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	int32_t G_B4_0 = 0;
	int32_t G_B6_0 = 0;
	{
		float L_0;
		L_0 = GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865(__this, /*hidden argument*/NULL);
		if ((!(((float)L_0) == ((float)(0.0f)))))
		{
			goto IL_0026;
		}
	}
	{
		bool L_1;
		L_1 = GUIStyle_get_wordWrap_m3852F7A584014D25A5CED400CBC1B9661ED5E01B(__this, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0023;
		}
	}
	{
		int32_t L_2;
		L_2 = GUIStyle_get_imagePosition_m384E6DA06D9EE64871C2439EE5325C245FFEB4C8(__this, /*hidden argument*/NULL);
		G_B4_0 = ((((int32_t)((((int32_t)L_2) == ((int32_t)2))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0024;
	}

IL_0023:
	{
		G_B4_0 = 0;
	}

IL_0024:
	{
		G_B6_0 = G_B4_0;
		goto IL_0027;
	}

IL_0026:
	{
		G_B6_0 = 0;
	}

IL_0027:
	{
		return (bool)G_B6_0;
	}
}
// System.Void UnityEngine.GUIStyle::CalcMinMaxWidth(UnityEngine.GUIContent,System.Single&,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_CalcMinMaxWidth_m1D29C63D2C8A757F503FE3C0904E3276CC48BB94 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, float* ___minWidth1, float* ___maxWidth2, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = ___content0;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1;
		L_1 = GUIStyle_Internal_CalcMinMaxWidth_m1607C544FC2FB31E8340A354D978C5A49A23D86B(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		float* L_2 = ___minWidth1;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_3 = V_0;
		float L_4 = L_3.get_x_0();
		*((float*)L_2) = (float)L_4;
		float* L_5 = ___maxWidth2;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_6 = V_0;
		float L_7 = L_6.get_y_1();
		*((float*)L_5) = (float)L_7;
		return;
	}
}
// System.String UnityEngine.GUIStyle::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_ToString_mD76BC8FD1791793D427C90D190301A1A3FD5A288 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3D5EBA7CCD58DABCEC7A4FD33516FBE9E3482887);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_0 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)SZArrayNew(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE_il2cpp_TypeInfo_var, (uint32_t)1);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_1 = L_0;
		String_t* L_2;
		L_2 = GUIStyle_get_name_mDC1371698EB6B92D459AA165EFFE5983711C4BB6(__this, /*hidden argument*/NULL);
		NullCheck(L_1);
		ArrayElementTypeCheck (L_1, L_2);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_2);
		String_t* L_3;
		L_3 = UnityString_Format_m7A07C068ED408DD06F634070770FB55F13AA4EC9(_stringLiteral3D5EBA7CCD58DABCEC7A4FD33516FBE9E3482887, L_1, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_001d;
	}

IL_001d:
	{
		String_t* L_4 = V_0;
		return L_4;
	}
}
// System.Void UnityEngine.GUIStyle::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle__cctor_mB6ECD2FB21FFBFBB0E7AC9A49A03560E20007B80 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		((GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_StaticFields*)il2cpp_codegen_static_fields_for(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var))->set_showKeyboardFocus_14((bool)1);
		return;
	}
}
// System.Void UnityEngine.GUIStyle::get_contentOffset_Injected(UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_get_contentOffset_Injected_m01479BB9A70925A53DBDF36B72D5FE82C9202256 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_get_contentOffset_Injected_m01479BB9A70925A53DBDF36B72D5FE82C9202256_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIStyle_get_contentOffset_Injected_m01479BB9A70925A53DBDF36B72D5FE82C9202256_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_get_contentOffset_Injected_m01479BB9A70925A53DBDF36B72D5FE82C9202256_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::get_contentOffset_Injected(UnityEngine.Vector2&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.GUIStyle::set_contentOffset_Injected(UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_contentOffset_Injected_mDBEAF5EF679081562A6CEFD6E208781AB0AE3245 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_set_contentOffset_Injected_mDBEAF5EF679081562A6CEFD6E208781AB0AE3245_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIStyle_set_contentOffset_Injected_mDBEAF5EF679081562A6CEFD6E208781AB0AE3245_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_set_contentOffset_Injected_mDBEAF5EF679081562A6CEFD6E208781AB0AE3245_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::set_contentOffset_Injected(UnityEngine.Vector2&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.GUIStyle::set_Internal_clipOffset_Injected(UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_set_Internal_clipOffset_Injected_m7BEA5BAB90B2593261777E75DBF28EA8201C5F93 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_set_Internal_clipOffset_Injected_m7BEA5BAB90B2593261777E75DBF28EA8201C5F93_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIStyle_set_Internal_clipOffset_Injected_m7BEA5BAB90B2593261777E75DBF28EA8201C5F93_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_set_Internal_clipOffset_Injected_m7BEA5BAB90B2593261777E75DBF28EA8201C5F93_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::set_Internal_clipOffset_Injected(UnityEngine.Vector2&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.GUIStyle::Internal_Draw_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Draw_Injected_mB08817EF206F76A1E2CF33199889F2BBC331F27A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___screenRect0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_Draw_Injected_mB08817EF206F76A1E2CF33199889F2BBC331F27A_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, bool, bool, bool, bool);
	static GUIStyle_Internal_Draw_Injected_mB08817EF206F76A1E2CF33199889F2BBC331F27A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_Draw_Injected_mB08817EF206F76A1E2CF33199889F2BBC331F27A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_Draw_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean)");
	_il2cpp_icall_func(__this, ___screenRect0, ___content1, ___isHover2, ___isActive3, ___on4, ___hasKeyboardFocus5);
}
// System.Void UnityEngine.GUIStyle::Internal_Draw2_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_Draw2_Injected_m2B6E7ADBB95678E90549769F40BAEA96334954A2 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___controlID2, bool ___on3, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_Draw2_Injected_m2B6E7ADBB95678E90549769F40BAEA96334954A2_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, int32_t, bool);
	static GUIStyle_Internal_Draw2_Injected_m2B6E7ADBB95678E90549769F40BAEA96334954A2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_Draw2_Injected_m2B6E7ADBB95678E90549769F40BAEA96334954A2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_Draw2_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,System.Boolean)");
	_il2cpp_icall_func(__this, ___position0, ___content1, ___controlID2, ___on3);
}
// System.Void UnityEngine.GUIStyle::Internal_DrawCursor_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,UnityEngine.Color&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_DrawCursor_Injected_m455B380779298710943DF4DBD8E9C7361D4AB245 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___pos2, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * ___cursorColor3, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_DrawCursor_Injected_m455B380779298710943DF4DBD8E9C7361D4AB245_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, int32_t, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *);
	static GUIStyle_Internal_DrawCursor_Injected_m455B380779298710943DF4DBD8E9C7361D4AB245_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_DrawCursor_Injected_m455B380779298710943DF4DBD8E9C7361D4AB245_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_DrawCursor_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,UnityEngine.Color&)");
	_il2cpp_icall_func(__this, ___position0, ___content1, ___pos2, ___cursorColor3);
}
// System.Void UnityEngine.GUIStyle::Internal_DrawWithTextSelection_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Int32,UnityEngine.Color&,UnityEngine.Color&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_DrawWithTextSelection_Injected_m5C13B16DC9C2C5CE5B1B517F5AB5980C812F11FA (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___screenRect0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, bool ___isHover2, bool ___isActive3, bool ___on4, bool ___hasKeyboardFocus5, bool ___drawSelectionAsComposition6, int32_t ___cursorFirst7, int32_t ___cursorLast8, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * ___cursorColor9, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * ___selectionColor10, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_DrawWithTextSelection_Injected_m5C13B16DC9C2C5CE5B1B517F5AB5980C812F11FA_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, bool, bool, bool, bool, bool, int32_t, int32_t, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *);
	static GUIStyle_Internal_DrawWithTextSelection_Injected_m5C13B16DC9C2C5CE5B1B517F5AB5980C812F11FA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_DrawWithTextSelection_Injected_m5C13B16DC9C2C5CE5B1B517F5AB5980C812F11FA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_DrawWithTextSelection_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Int32,System.Int32,UnityEngine.Color&,UnityEngine.Color&)");
	_il2cpp_icall_func(__this, ___screenRect0, ___content1, ___isHover2, ___isActive3, ___on4, ___hasKeyboardFocus5, ___drawSelectionAsComposition6, ___cursorFirst7, ___cursorLast8, ___cursorColor9, ___selectionColor10);
}
// System.Void UnityEngine.GUIStyle::Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_GetCursorPixelPosition_Injected_mF7899C9932D49D0AD222E71299429CB95AA2F76B (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, int32_t ___cursorStringIndex2, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret3, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_GetCursorPixelPosition_Injected_mF7899C9932D49D0AD222E71299429CB95AA2F76B_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, int32_t, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIStyle_Internal_GetCursorPixelPosition_Injected_mF7899C9932D49D0AD222E71299429CB95AA2F76B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_GetCursorPixelPosition_Injected_mF7899C9932D49D0AD222E71299429CB95AA2F76B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_GetCursorPixelPosition_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,UnityEngine.Vector2&)");
	_il2cpp_icall_func(__this, ___position0, ___content1, ___cursorStringIndex2, ___ret3);
}
// System.Int32 UnityEngine.GUIStyle::Internal_GetCursorStringIndex_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIStyle_Internal_GetCursorStringIndex_Injected_m8949C266ABD988A56BB60CEDF47B85E65BF7B51A (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___position0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___cursorPixelPosition2, const RuntimeMethod* method)
{
	typedef int32_t (*GUIStyle_Internal_GetCursorStringIndex_Injected_m8949C266ABD988A56BB60CEDF47B85E65BF7B51A_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIStyle_Internal_GetCursorStringIndex_Injected_m8949C266ABD988A56BB60CEDF47B85E65BF7B51A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_GetCursorStringIndex_Injected_m8949C266ABD988A56BB60CEDF47B85E65BF7B51A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_GetCursorStringIndex_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,UnityEngine.Vector2&)");
	int32_t icallRetVal = _il2cpp_icall_func(__this, ___position0, ___content1, ___cursorPixelPosition2);
	return icallRetVal;
}
// System.String UnityEngine.GUIStyle::Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIStyle_Internal_GetSelectedRenderedText_Injected_mFBB4298AD4A38058CC247D7DDE6C7413989D1036 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___localPosition0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___mContent1, int32_t ___selectIndex2, int32_t ___cursorIndex3, const RuntimeMethod* method)
{
	typedef String_t* (*GUIStyle_Internal_GetSelectedRenderedText_Injected_mFBB4298AD4A38058CC247D7DDE6C7413989D1036_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, int32_t, int32_t);
	static GUIStyle_Internal_GetSelectedRenderedText_Injected_mFBB4298AD4A38058CC247D7DDE6C7413989D1036_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_GetSelectedRenderedText_Injected_mFBB4298AD4A38058CC247D7DDE6C7413989D1036_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_GetSelectedRenderedText_Injected(UnityEngine.Rect&,UnityEngine.GUIContent,System.Int32,System.Int32)");
	String_t* icallRetVal = _il2cpp_icall_func(__this, ___localPosition0, ___mContent1, ___selectIndex2, ___cursorIndex3);
	return icallRetVal;
}
// System.Void UnityEngine.GUIStyle::Internal_CalcSize_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_CalcSize_Injected_m9C64AC5BB7801E30225703FB042E42061B89E636 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret1, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_CalcSize_Injected_m9C64AC5BB7801E30225703FB042E42061B89E636_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIStyle_Internal_CalcSize_Injected_m9C64AC5BB7801E30225703FB042E42061B89E636_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_CalcSize_Injected_m9C64AC5BB7801E30225703FB042E42061B89E636_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_CalcSize_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&)");
	_il2cpp_icall_func(__this, ___content0, ___ret1);
}
// System.Void UnityEngine.GUIStyle::Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_CalcSizeWithConstraints_Injected_mB165D16DAE4455C9901D0A6C1B8751F2E8F8E858 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___maxSize1, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret2, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_CalcSizeWithConstraints_Injected_mB165D16DAE4455C9901D0A6C1B8751F2E8F8E858_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIStyle_Internal_CalcSizeWithConstraints_Injected_mB165D16DAE4455C9901D0A6C1B8751F2E8F8E858_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_CalcSizeWithConstraints_Injected_mB165D16DAE4455C9901D0A6C1B8751F2E8F8E858_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&,UnityEngine.Vector2&)");
	_il2cpp_icall_func(__this, ___content0, ___maxSize1, ___ret2);
}
// System.Void UnityEngine.GUIStyle::Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_Internal_CalcMinMaxWidth_Injected_m4E48F9D7027E8D75326DF02B0D01C6AEFB533BD8 (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * __this, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___ret1, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_Internal_CalcMinMaxWidth_Injected_m4E48F9D7027E8D75326DF02B0D01C6AEFB533BD8_ftn) (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIStyle_Internal_CalcMinMaxWidth_Injected_m4E48F9D7027E8D75326DF02B0D01C6AEFB533BD8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_Internal_CalcMinMaxWidth_Injected_m4E48F9D7027E8D75326DF02B0D01C6AEFB533BD8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent,UnityEngine.Vector2&)");
	_il2cpp_icall_func(__this, ___content0, ___ret1);
}
// System.Void UnityEngine.GUIStyle::SetMouseTooltip_Injected(System.String,UnityEngine.Rect&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyle_SetMouseTooltip_Injected_m165B8143962BC2EF7F0FE454BBAB1E358A84ED76 (String_t* ___tooltip0, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___screenRect1, const RuntimeMethod* method)
{
	typedef void (*GUIStyle_SetMouseTooltip_Injected_m165B8143962BC2EF7F0FE454BBAB1E358A84ED76_ftn) (String_t*, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *);
	static GUIStyle_SetMouseTooltip_Injected_m165B8143962BC2EF7F0FE454BBAB1E358A84ED76_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyle_SetMouseTooltip_Injected_m165B8143962BC2EF7F0FE454BBAB1E358A84ED76_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyle::SetMouseTooltip_Injected(System.String,UnityEngine.Rect&)");
	_il2cpp_icall_func(___tooltip0, ___screenRect1);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif


// Conversion methods for marshalling of: UnityEngine.GUIStyleState
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_pinvoke(const GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9& unmarshaled, GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke& marshaled)
{
	Exception_t* ___m_SourceStyle_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_SourceStyle' of type 'GUIStyleState': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_SourceStyle_1Exception, NULL);
}
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_pinvoke_back(const GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke& marshaled, GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9& unmarshaled)
{
	Exception_t* ___m_SourceStyle_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_SourceStyle' of type 'GUIStyleState': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_SourceStyle_1Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.GUIStyleState
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_pinvoke_cleanup(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_pinvoke& marshaled)
{
}


// Conversion methods for marshalling of: UnityEngine.GUIStyleState
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_com(const GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9& unmarshaled, GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com& marshaled)
{
	Exception_t* ___m_SourceStyle_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_SourceStyle' of type 'GUIStyleState': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_SourceStyle_1Exception, NULL);
}
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_com_back(const GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com& marshaled, GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9& unmarshaled)
{
	Exception_t* ___m_SourceStyle_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_SourceStyle' of type 'GUIStyleState': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_SourceStyle_1Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.GUIStyleState
IL2CPP_EXTERN_C void GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshal_com_cleanup(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.GUIStyleState::set_textColor(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState_set_textColor_mB4B61B9CAC1D6B4694471A2BB1191B5F0D5D764A (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659  ___value0, const RuntimeMethod* method)
{
	{
		GUIStyleState_set_textColor_Injected_mA4161E4AAAE12F40C7F1B937F2DDCAB1D81E221F(__this, (Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.IntPtr UnityEngine.GUIStyleState::Init()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t GUIStyleState_Init_mDC103756AA527283D4D171277702A78211BE6392 (const RuntimeMethod* method)
{
	typedef intptr_t (*GUIStyleState_Init_mDC103756AA527283D4D171277702A78211BE6392_ftn) ();
	static GUIStyleState_Init_mDC103756AA527283D4D171277702A78211BE6392_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyleState_Init_mDC103756AA527283D4D171277702A78211BE6392_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyleState::Init()");
	intptr_t icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Void UnityEngine.GUIStyleState::Cleanup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState_Cleanup_m811DBCF744DEC31303381BA28AD292209260C446 (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, const RuntimeMethod* method)
{
	typedef void (*GUIStyleState_Cleanup_m811DBCF744DEC31303381BA28AD292209260C446_ftn) (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 *);
	static GUIStyleState_Cleanup_m811DBCF744DEC31303381BA28AD292209260C446_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyleState_Cleanup_m811DBCF744DEC31303381BA28AD292209260C446_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyleState::Cleanup()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.GUIStyleState::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState__ctor_mA3A7EEABCD874B29FE0014784D81D77D74262E56 (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		intptr_t L_0;
		L_0 = GUIStyleState_Init_mDC103756AA527283D4D171277702A78211BE6392(/*hidden argument*/NULL);
		__this->set_m_Ptr_0((intptr_t)L_0);
		return;
	}
}
// System.Void UnityEngine.GUIStyleState::.ctor(UnityEngine.GUIStyle,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState__ctor_mF5B23C65DA81DA85EAE2F148C549ECE0007F1652 (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___sourceStyle0, intptr_t ___source1, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = ___sourceStyle0;
		__this->set_m_SourceStyle_1(L_0);
		intptr_t L_1 = ___source1;
		__this->set_m_Ptr_0((intptr_t)L_1);
		return;
	}
}
// UnityEngine.GUIStyleState UnityEngine.GUIStyleState::GetGUIStyleState(UnityEngine.GUIStyle,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * GUIStyleState_GetGUIStyleState_mE8758CDE0E9E627ECDE92F60509A19B91922964C (GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___sourceStyle0, intptr_t ___source1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * V_0 = NULL;
	GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * V_1 = NULL;
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = ___sourceStyle0;
		intptr_t L_1 = ___source1;
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_2 = (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 *)il2cpp_codegen_object_new(GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9_il2cpp_TypeInfo_var);
		GUIStyleState__ctor_mF5B23C65DA81DA85EAE2F148C549ECE0007F1652(L_2, L_0, (intptr_t)L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_3 = V_0;
		V_1 = L_3;
		goto IL_000d;
	}

IL_000d:
	{
		GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * L_4 = V_1;
		return L_4;
	}
}
// System.Void UnityEngine.GUIStyleState::Finalize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState_Finalize_m2C59477659BC41A85FC7AE4DBB124294C94BE9B1 (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
	}

IL_0001:
	try
	{ // begin try (depth: 1)
		{
			GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = __this->get_m_SourceStyle_1();
			V_0 = (bool)((((RuntimeObject*)(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
			bool L_1 = V_0;
			if (!L_1)
			{
				goto IL_0023;
			}
		}

IL_000f:
		{
			GUIStyleState_Cleanup_m811DBCF744DEC31303381BA28AD292209260C446(__this, /*hidden argument*/NULL);
			__this->set_m_Ptr_0((intptr_t)(0));
		}

IL_0023:
		{
			IL2CPP_LEAVE(0x2D, FINALLY_0025);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0025;
	}

FINALLY_0025:
	{ // begin finally (depth: 1)
		Object_Finalize_mC59C83CF4F7707E425FFA6362931C25D4C36676A(__this, /*hidden argument*/NULL);
		IL2CPP_END_FINALLY(37)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(37)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x2D, IL_002d)
	}

IL_002d:
	{
		return;
	}
}
// System.Void UnityEngine.GUIStyleState::set_textColor_Injected(UnityEngine.Color&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIStyleState_set_textColor_Injected_mA4161E4AAAE12F40C7F1B937F2DDCAB1D81E221F (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 * __this, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 * ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIStyleState_set_textColor_Injected_mA4161E4AAAE12F40C7F1B937F2DDCAB1D81E221F_ftn) (GUIStyleState_tC89202668617B1D7884980314F293AD382B9AAD9 *, Color_tF40DAF76C04FFECF3FE6024F85A294741C9CC659 *);
	static GUIStyleState_set_textColor_Injected_mA4161E4AAAE12F40C7F1B937F2DDCAB1D81E221F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIStyleState_set_textColor_Injected_mA4161E4AAAE12F40C7F1B937F2DDCAB1D81E221F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIStyleState::set_textColor_Injected(UnityEngine.Color&)");
	_il2cpp_icall_func(__this, ___value0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 UnityEngine.GUITargetAttribute::GetGUITargetAttrValue(System.Type,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUITargetAttribute_GetGUITargetAttrValue_mCC2254E894729E2DDFAB25D9FC26CD4913E8ADC2 (Type_t * ___klass0, String_t* ___methodName1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	MethodInfo_t * V_0 = NULL;
	bool V_1 = false;
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* V_2 = NULL;
	bool V_3 = false;
	int32_t V_4 = 0;
	GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C * V_5 = NULL;
	bool V_6 = false;
	int32_t V_7 = 0;
	bool V_8 = false;
	{
		Type_t * L_0 = ___klass0;
		String_t* L_1 = ___methodName1;
		NullCheck(L_0);
		MethodInfo_t * L_2;
		L_2 = Type_GetMethod_m2DDEF37DF33D28F579BA8E03F4376B67D91F0DEB(L_0, L_1, ((int32_t)52), /*hidden argument*/NULL);
		V_0 = L_2;
		MethodInfo_t * L_3 = V_0;
		V_1 = (bool)((!(((RuntimeObject*)(MethodInfo_t *)L_3) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_0076;
		}
	}
	{
		MethodInfo_t * L_5 = V_0;
		NullCheck(L_5);
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_6;
		L_6 = VirtFuncInvoker1< ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*, bool >::Invoke(28 /* System.Object[] System.Reflection.MemberInfo::GetCustomAttributes(System.Boolean) */, L_5, (bool)1);
		V_2 = L_6;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_7 = V_2;
		V_3 = (bool)((!(((RuntimeObject*)(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_7) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_8 = V_3;
		if (!L_8)
		{
			goto IL_0075;
		}
	}
	{
		V_4 = 0;
		goto IL_0067;
	}

IL_002a:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_9 = V_2;
		int32_t L_10 = V_4;
		NullCheck(L_9);
		int32_t L_11 = L_10;
		RuntimeObject * L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		NullCheck(L_12);
		Type_t * L_13;
		L_13 = Object_GetType_m571FE8360C10B98C23AAF1F066D92C08CC94F45B(L_12, /*hidden argument*/NULL);
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_14 = { reinterpret_cast<intptr_t> (GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_15;
		L_15 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E(L_14, /*hidden argument*/NULL);
		V_6 = (bool)((((int32_t)((((RuntimeObject*)(Type_t *)L_13) == ((RuntimeObject*)(Type_t *)L_15))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_16 = V_6;
		if (!L_16)
		{
			goto IL_004b;
		}
	}
	{
		goto IL_0061;
	}

IL_004b:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_17 = V_2;
		int32_t L_18 = V_4;
		NullCheck(L_17);
		int32_t L_19 = L_18;
		RuntimeObject * L_20 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_19));
		V_5 = ((GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C *)IsInstClass((RuntimeObject*)L_20, GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C_il2cpp_TypeInfo_var));
		GUITargetAttribute_tFC89E3290401D51DDE92D1FA3F39134D87B9E73C * L_21 = V_5;
		NullCheck(L_21);
		int32_t L_22 = L_21->get_displayMask_0();
		V_7 = L_22;
		goto IL_007b;
	}

IL_0061:
	{
		int32_t L_23 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add((int32_t)L_23, (int32_t)1));
	}

IL_0067:
	{
		int32_t L_24 = V_4;
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_25 = V_2;
		NullCheck(L_25);
		V_8 = (bool)((((int32_t)L_24) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_25)->max_length)))))? 1 : 0);
		bool L_26 = V_8;
		if (L_26)
		{
			goto IL_002a;
		}
	}
	{
	}

IL_0075:
	{
	}

IL_0076:
	{
		V_7 = (-1);
		goto IL_007b;
	}

IL_007b:
	{
		int32_t L_27 = V_7;
		return L_27;
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
// System.Single UnityEngine.GUIUtility::get_pixelsPerPoint()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float GUIUtility_get_pixelsPerPoint_mB5D6900CC67E192C0189890FBB163E5ECD662579 (const RuntimeMethod* method)
{
	typedef float (*GUIUtility_get_pixelsPerPoint_mB5D6900CC67E192C0189890FBB163E5ECD662579_ftn) ();
	static GUIUtility_get_pixelsPerPoint_mB5D6900CC67E192C0189890FBB163E5ECD662579_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_get_pixelsPerPoint_mB5D6900CC67E192C0189890FBB163E5ECD662579_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::get_pixelsPerPoint()");
	float icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Int32 UnityEngine.GUIUtility::get_guiDepth()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_get_guiDepth_mCEE2CF2630726CA657D48F0375866E2B8C314F2E (const RuntimeMethod* method)
{
	typedef int32_t (*GUIUtility_get_guiDepth_mCEE2CF2630726CA657D48F0375866E2B8C314F2E_ftn) ();
	static GUIUtility_get_guiDepth_mCEE2CF2630726CA657D48F0375866E2B8C314F2E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_get_guiDepth_mCEE2CF2630726CA657D48F0375866E2B8C314F2E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::get_guiDepth()");
	int32_t icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Void UnityEngine.GUIUtility::set_textFieldInput(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_textFieldInput_m5C9C22189C9E2D00ACE922F7491B4EF5FCBA1396 (bool ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIUtility_set_textFieldInput_m5C9C22189C9E2D00ACE922F7491B4EF5FCBA1396_ftn) (bool);
	static GUIUtility_set_textFieldInput_m5C9C22189C9E2D00ACE922F7491B4EF5FCBA1396_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_set_textFieldInput_m5C9C22189C9E2D00ACE922F7491B4EF5FCBA1396_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::set_textFieldInput(System.Boolean)");
	_il2cpp_icall_func(___value0);
}
// System.String UnityEngine.GUIUtility::get_systemCopyBuffer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIUtility_get_systemCopyBuffer_m64CEF1CB0627F80D3CEEB458BA60DC9C1FA6141E (const RuntimeMethod* method)
{
	typedef String_t* (*GUIUtility_get_systemCopyBuffer_m64CEF1CB0627F80D3CEEB458BA60DC9C1FA6141E_ftn) ();
	static GUIUtility_get_systemCopyBuffer_m64CEF1CB0627F80D3CEEB458BA60DC9C1FA6141E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_get_systemCopyBuffer_m64CEF1CB0627F80D3CEEB458BA60DC9C1FA6141E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::get_systemCopyBuffer()");
	String_t* icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Void UnityEngine.GUIUtility::set_systemCopyBuffer(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_systemCopyBuffer_m1C5EAC38441C94C430AA13DF9942E1786CFCAC95 (String_t* ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIUtility_set_systemCopyBuffer_m1C5EAC38441C94C430AA13DF9942E1786CFCAC95_ftn) (String_t*);
	static GUIUtility_set_systemCopyBuffer_m1C5EAC38441C94C430AA13DF9942E1786CFCAC95_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_set_systemCopyBuffer_m1C5EAC38441C94C430AA13DF9942E1786CFCAC95_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::set_systemCopyBuffer(System.String)");
	_il2cpp_icall_func(___value0);
}
// System.Int32 UnityEngine.GUIUtility::Internal_GetControlID(System.Int32,UnityEngine.FocusType,UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_Internal_GetControlID_mE6F28AD317BB04BFEB2C9E85E4E644F8B07E4AEE (int32_t ___hint0, int32_t ___focusType1, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___hint0;
		int32_t L_1 = ___focusType1;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = GUIUtility_Internal_GetControlID_Injected_mB712E290E5EDE635C4F06E06F697D3D82AC8C901(L_0, L_1, (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___rect2), /*hidden argument*/NULL);
		return L_2;
	}
}
// System.Int32 UnityEngine.GUIUtility::GetControlID(System.Int32,UnityEngine.FocusType,UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_GetControlID_mCF29C85EFCB6D5859CB1F464601ACF474754F4A3 (int32_t ___hint0, int32_t ___focusType1, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_0 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_s_ControlCount_0();
		((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->set_s_ControlCount_0(((int32_t)il2cpp_codegen_add((int32_t)L_0, (int32_t)1)));
		int32_t L_1 = ___hint0;
		int32_t L_2 = ___focusType1;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_3 = ___rect2;
		int32_t L_4;
		L_4 = GUIUtility_Internal_GetControlID_mE6F28AD317BB04BFEB2C9E85E4E644F8B07E4AEE(L_1, L_2, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_0018;
	}

IL_0018:
	{
		int32_t L_5 = V_0;
		return L_5;
	}
}
// System.String UnityEngine.GUIUtility::get_compositionString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37 (const RuntimeMethod* method)
{
	typedef String_t* (*GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37_ftn) ();
	static GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::get_compositionString()");
	String_t* icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Void UnityEngine.GUIUtility::set_compositionCursorPos(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_compositionCursorPos_m895C29DAB9335BC53602E6D05D4FD622C37BFB8D (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_set_compositionCursorPos_Injected_mA4689621797402B18EF4F9F5627A1990A86C8D4E((Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Int32 UnityEngine.GUIUtility::Internal_GetHotControl()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_Internal_GetHotControl_m34FDB5E7413F6EE520D6B4932C60A5BACBEF922F (const RuntimeMethod* method)
{
	typedef int32_t (*GUIUtility_Internal_GetHotControl_m34FDB5E7413F6EE520D6B4932C60A5BACBEF922F_ftn) ();
	static GUIUtility_Internal_GetHotControl_m34FDB5E7413F6EE520D6B4932C60A5BACBEF922F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_Internal_GetHotControl_m34FDB5E7413F6EE520D6B4932C60A5BACBEF922F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::Internal_GetHotControl()");
	int32_t icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Int32 UnityEngine.GUIUtility::Internal_GetKeyboardControl()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_Internal_GetKeyboardControl_mBB68966687B84C74BEAAD8A117DD14D8E7B9F382 (const RuntimeMethod* method)
{
	typedef int32_t (*GUIUtility_Internal_GetKeyboardControl_mBB68966687B84C74BEAAD8A117DD14D8E7B9F382_ftn) ();
	static GUIUtility_Internal_GetKeyboardControl_mBB68966687B84C74BEAAD8A117DD14D8E7B9F382_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_Internal_GetKeyboardControl_mBB68966687B84C74BEAAD8A117DD14D8E7B9F382_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::Internal_GetKeyboardControl()");
	int32_t icallRetVal = _il2cpp_icall_func();
	return icallRetVal;
}
// System.Void UnityEngine.GUIUtility::Internal_SetHotControl(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_Internal_SetHotControl_m8DC5C397B09559EC71B12ED955A25F779569FCFD (int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIUtility_Internal_SetHotControl_m8DC5C397B09559EC71B12ED955A25F779569FCFD_ftn) (int32_t);
	static GUIUtility_Internal_SetHotControl_m8DC5C397B09559EC71B12ED955A25F779569FCFD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_Internal_SetHotControl_m8DC5C397B09559EC71B12ED955A25F779569FCFD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::Internal_SetHotControl(System.Int32)");
	_il2cpp_icall_func(___value0);
}
// System.Void UnityEngine.GUIUtility::Internal_SetKeyboardControl(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_Internal_SetKeyboardControl_mFAC14D6638CE2826ADC2CCA8205E3544A94E6671 (int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIUtility_Internal_SetKeyboardControl_mFAC14D6638CE2826ADC2CCA8205E3544A94E6671_ftn) (int32_t);
	static GUIUtility_Internal_SetKeyboardControl_mFAC14D6638CE2826ADC2CCA8205E3544A94E6671_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_Internal_SetKeyboardControl_mFAC14D6638CE2826ADC2CCA8205E3544A94E6671_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::Internal_SetKeyboardControl(System.Int32)");
	_il2cpp_icall_func(___value0);
}
// System.Object UnityEngine.GUIUtility::Internal_GetDefaultSkin(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GUIUtility_Internal_GetDefaultSkin_mA64DFF25827FEF564C93F240B7C6614EEABC92E5 (int32_t ___skinMode0, const RuntimeMethod* method)
{
	typedef RuntimeObject * (*GUIUtility_Internal_GetDefaultSkin_mA64DFF25827FEF564C93F240B7C6614EEABC92E5_ftn) (int32_t);
	static GUIUtility_Internal_GetDefaultSkin_mA64DFF25827FEF564C93F240B7C6614EEABC92E5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_Internal_GetDefaultSkin_mA64DFF25827FEF564C93F240B7C6614EEABC92E5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::Internal_GetDefaultSkin(System.Int32)");
	RuntimeObject * icallRetVal = _il2cpp_icall_func(___skinMode0);
	return icallRetVal;
}
// System.Void UnityEngine.GUIUtility::Internal_ExitGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_Internal_ExitGUI_m0B9B3280EB0CA732C5CFA32DA0384EA2D0A41090 (const RuntimeMethod* method)
{
	typedef void (*GUIUtility_Internal_ExitGUI_m0B9B3280EB0CA732C5CFA32DA0384EA2D0A41090_ftn) ();
	static GUIUtility_Internal_ExitGUI_m0B9B3280EB0CA732C5CFA32DA0384EA2D0A41090_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_Internal_ExitGUI_m0B9B3280EB0CA732C5CFA32DA0384EA2D0A41090_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::Internal_ExitGUI()");
	_il2cpp_icall_func();
}
// System.Void UnityEngine.GUIUtility::MarkGUIChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_MarkGUIChanged_m81ADFC648B63CFD4C6524BEA5268C4F0CAE07A61 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * G_B2_0 = NULL;
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * G_B1_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_0 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_guiChanged_7();
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000c;
		}
	}
	{
		goto IL_0012;
	}

IL_000c:
	{
		NullCheck(G_B2_0);
		Action_Invoke_m3FFA5BE3D64F0FF8E1E1CB6F953913FADB5EB89E(G_B2_0, /*hidden argument*/NULL);
	}

IL_0012:
	{
		return;
	}
}
// System.Int32 UnityEngine.GUIUtility::GetControlID(UnityEngine.FocusType,UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_GetControlID_m18D2D4AA7A56A5F75F30B2F7B225D21E10B463A2 (int32_t ___focus0, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___focus0;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1 = ___position1;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = GUIUtility_GetControlID_mCF29C85EFCB6D5859CB1F464601ACF474754F4A3(0, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_3 = V_0;
		return L_3;
	}
}
// System.Int32 UnityEngine.GUIUtility::GetControlID(System.Int32,UnityEngine.FocusType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_GetControlID_m2E9DDA37904870EC15D1CCB6A34A3EF0DB8F7280 (int32_t ___hint0, int32_t ___focus1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___hint0;
		int32_t L_1 = ___focus1;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_2;
		L_2 = Rect_get_zero_m4F738804E40698120CC691AB45A6416C4FF52589(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_3;
		L_3 = GUIUtility_GetControlID_mCF29C85EFCB6D5859CB1F464601ACF474754F4A3(L_0, L_1, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_0010;
	}

IL_0010:
	{
		int32_t L_4 = V_0;
		return L_4;
	}
}
// System.Object UnityEngine.GUIUtility::GetStateObject(System.Type,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GUIUtility_GetStateObject_mCB51130ADCCE1FC49DCF65A1BC5545A07E012E6A (Type_t * ___t0, int32_t ___controlID1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	{
		Type_t * L_0 = ___t0;
		int32_t L_1 = ___controlID1;
		IL2CPP_RUNTIME_CLASS_INIT(GUIStateObjects_t2439D5008B2E8F730065511CCCB05FA993346EE4_il2cpp_TypeInfo_var);
		RuntimeObject * L_2;
		L_2 = GUIStateObjects_GetStateObject_mF668F2C3D2335FA4DE006C16C9C7C57ABB57CFD0(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000b;
	}

IL_000b:
	{
		RuntimeObject * L_3 = V_0;
		return L_3;
	}
}
// System.Void UnityEngine.GUIUtility::set_guiIsExiting(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_guiIsExiting_m13C69BE54D215B22CA7D1FE5192DD5ED744E0FCF (bool ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->set_U3CguiIsExitingU3Ek__BackingField_8(L_0);
		return;
	}
}
// System.Int32 UnityEngine.GUIUtility::get_hotControl()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_get_hotControl_m70A913241C32305A380F4DB4A3F1B37BB3401E5A (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_0;
		L_0 = GUIUtility_Internal_GetHotControl_m34FDB5E7413F6EE520D6B4932C60A5BACBEF922F(/*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.GUIUtility::set_hotControl(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_hotControl_m865CC0FAB4B33056CEC7047E38111D98097C52C8 (int32_t ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_Internal_SetHotControl_m8DC5C397B09559EC71B12ED955A25F779569FCFD(L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.GUIUtility::TakeCapture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_TakeCapture_mB10E9D004B3C8B072634BB16C8D99DA9F6A4A006 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * G_B2_0 = NULL;
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * G_B1_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_0 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_takeCapture_3();
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000c;
		}
	}
	{
		goto IL_0012;
	}

IL_000c:
	{
		NullCheck(G_B2_0);
		Action_Invoke_m3FFA5BE3D64F0FF8E1E1CB6F953913FADB5EB89E(G_B2_0, /*hidden argument*/NULL);
	}

IL_0012:
	{
		return;
	}
}
// System.Void UnityEngine.GUIUtility::RemoveCapture()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_RemoveCapture_m6FA86E68E9C40AB3153203644AB6020E5D85167C (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * G_B2_0 = NULL;
	Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * G_B1_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_0 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_releaseCapture_4();
		Action_tAF41423D285AE0862865348CF6CE51CD085ABBA6 * L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000c;
		}
	}
	{
		goto IL_0012;
	}

IL_000c:
	{
		NullCheck(G_B2_0);
		Action_Invoke_m3FFA5BE3D64F0FF8E1E1CB6F953913FADB5EB89E(G_B2_0, /*hidden argument*/NULL);
	}

IL_0012:
	{
		return;
	}
}
// System.Int32 UnityEngine.GUIUtility::get_keyboardControl()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_get_keyboardControl_mC111A10FE792FA94E3859C5BC704D611F8768BE1 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_0;
		L_0 = GUIUtility_Internal_GetKeyboardControl_mBB68966687B84C74BEAAD8A117DD14D8E7B9F382(/*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.GUIUtility::set_keyboardControl(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_keyboardControl_m1D6F14E73A7AF683699DA6CFD41ECF7486144AD2 (int32_t ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_Internal_SetKeyboardControl_mFAC14D6638CE2826ADC2CCA8205E3544A94E6671(L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.GUIUtility::HasKeyFocus(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_HasKeyFocus_m1CF44E6F83A22DB0B5F2148C68AA7DEC0BB94E4F (int32_t ___controlID0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_1_Invoke_mD0192F3F912E371387CD7B196DF85569553486B4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t G_B4_0 = 0;
	int32_t G_B6_0 = 0;
	{
		int32_t L_0 = ___controlID0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_1;
		L_1 = GUIUtility_get_keyboardControl_mC111A10FE792FA94E3859C5BC704D611F8768BE1(/*hidden argument*/NULL);
		if ((!(((uint32_t)L_0) == ((uint32_t)L_1))))
		{
			goto IL_001f;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F * L_2 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_s_HasCurrentWindowKeyFocusFunc_9();
		if (L_2)
		{
			goto IL_0013;
		}
	}
	{
		G_B4_0 = 1;
		goto IL_001d;
	}

IL_0013:
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Func_1_t76FCDA5C58178ED310C472967481FDE5F47DCF0F * L_3 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_s_HasCurrentWindowKeyFocusFunc_9();
		NullCheck(L_3);
		bool L_4;
		L_4 = Func_1_Invoke_mD0192F3F912E371387CD7B196DF85569553486B4(L_3, /*hidden argument*/Func_1_Invoke_mD0192F3F912E371387CD7B196DF85569553486B4_RuntimeMethod_var);
		G_B4_0 = ((int32_t)(L_4));
	}

IL_001d:
	{
		G_B6_0 = G_B4_0;
		goto IL_0020;
	}

IL_001f:
	{
		G_B6_0 = 0;
	}

IL_0020:
	{
		V_0 = (bool)G_B6_0;
		goto IL_0023;
	}

IL_0023:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
// UnityEngine.GUISkin UnityEngine.GUIUtility::GetDefaultSkin()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * GUIUtility_GetDefaultSkin_m4CF951846AD574F548739127FB7569BB7E3593A4 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * V_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_0 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_s_SkinMode_1();
		RuntimeObject * L_1;
		L_1 = GUIUtility_Internal_GetDefaultSkin_mA64DFF25827FEF564C93F240B7C6614EEABC92E5(L_0, /*hidden argument*/NULL);
		V_0 = ((GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 *)IsInstSealed((RuntimeObject*)L_1, GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6_il2cpp_TypeInfo_var));
		goto IL_0013;
	}

IL_0013:
	{
		GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 * L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.GUIUtility::ProcessEvent(System.Int32,System.IntPtr,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_ProcessEvent_m96FCE6AD81E6EEE66422C72FC61C633BDFB84B8F (int32_t ___instanceID0, intptr_t ___nativeEventPtr1, bool* ___result2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_3_Invoke_m41D8569C1E1FFC40BAB05286F15A74835341C627_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		bool* L_0 = ___result2;
		*((int8_t*)L_0) = (int8_t)0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 * L_1 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_processEvent_5();
		V_0 = (bool)((!(((RuntimeObject*)(Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 *)L_1) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001e;
		}
	}
	{
		bool* L_3 = ___result2;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Func_3_tC53D1EA39D16EE63C9C8B6C2EC9769A630644CE0 * L_4 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_processEvent_5();
		int32_t L_5 = ___instanceID0;
		intptr_t L_6 = ___nativeEventPtr1;
		NullCheck(L_4);
		bool L_7;
		L_7 = Func_3_Invoke_m41D8569C1E1FFC40BAB05286F15A74835341C627(L_4, L_5, (intptr_t)L_6, /*hidden argument*/Func_3_Invoke_m41D8569C1E1FFC40BAB05286F15A74835341C627_RuntimeMethod_var);
		*((int8_t*)L_3) = (int8_t)L_7;
	}

IL_001e:
	{
		return;
	}
}
// System.Void UnityEngine.GUIUtility::BeginGUI(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_BeginGUI_mC845F40D18A61ABC56B8428DD231030CDD312C05 (int32_t ___skinMode0, int32_t ___instanceID1, int32_t ___useGUILayout2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUILayoutUtility_tC8DDF719E399EA119E2889EFB47816B34CA58F5A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		int32_t L_0 = ___skinMode0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->set_s_SkinMode_1(L_0);
		int32_t L_1 = ___instanceID1;
		((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->set_s_OriginalID_2(L_1);
		GUIUtility_ResetGlobalState_m5D608E689B0B1AA994702358158C7BB65373D3F7(/*hidden argument*/NULL);
		int32_t L_2 = ___useGUILayout2;
		V_0 = (bool)((!(((uint32_t)L_2) <= ((uint32_t)0)))? 1 : 0);
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0024;
		}
	}
	{
		int32_t L_4 = ___instanceID1;
		IL2CPP_RUNTIME_CLASS_INIT(GUILayoutUtility_tC8DDF719E399EA119E2889EFB47816B34CA58F5A_il2cpp_TypeInfo_var);
		GUILayoutUtility_Begin_m1A42FB0448413B7ED711887827CD6E8F9276C47D(L_4, /*hidden argument*/NULL);
	}

IL_0024:
	{
		return;
	}
}
// System.Void UnityEngine.GUIUtility::EndGUI(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_EndGUI_mFB2C261AB2BA4AD1D79FE74258363B4B20D631C3 (int32_t ___layoutType0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUILayoutUtility_tC8DDF719E399EA119E2889EFB47816B34CA58F5A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	{
	}

IL_0001:
	try
	{ // begin try (depth: 1)
		{
			Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_0;
			L_0 = Event_get_current_m069E3E742E6CBC32C3BC958B85153E75B0192443(/*hidden argument*/NULL);
			NullCheck(L_0);
			int32_t L_1;
			L_1 = Event_get_type_mA5010AB8C34B098E0783949046C708B9E1BA811D(L_0, /*hidden argument*/NULL);
			V_0 = (bool)((((int32_t)L_1) == ((int32_t)8))? 1 : 0);
			bool L_2 = V_0;
			if (!L_2)
			{
				goto IL_003f;
			}
		}

IL_0013:
		{
			int32_t L_3 = ___layoutType0;
			V_2 = L_3;
			int32_t L_4 = V_2;
			V_1 = L_4;
			int32_t L_5 = V_1;
			switch (L_5)
			{
				case 0:
				{
					goto IL_002c;
				}
				case 1:
				{
					goto IL_002e;
				}
				case 2:
				{
					goto IL_0036;
				}
			}
		}

IL_002a:
		{
			goto IL_003e;
		}

IL_002c:
		{
			goto IL_003e;
		}

IL_002e:
		{
			IL2CPP_RUNTIME_CLASS_INIT(GUILayoutUtility_tC8DDF719E399EA119E2889EFB47816B34CA58F5A_il2cpp_TypeInfo_var);
			GUILayoutUtility_Layout_mE876F10FD153DE2038066B29DBC444E4B5A3F88B(/*hidden argument*/NULL);
			goto IL_003e;
		}

IL_0036:
		{
			IL2CPP_RUNTIME_CLASS_INIT(GUILayoutUtility_tC8DDF719E399EA119E2889EFB47816B34CA58F5A_il2cpp_TypeInfo_var);
			GUILayoutUtility_LayoutFromEditorWindow_m47384B8E70622B43668E03DA67E8B455694A7005(/*hidden argument*/NULL);
			goto IL_003e;
		}

IL_003e:
		{
		}

IL_003f:
		{
			IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
			int32_t L_6 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_s_OriginalID_2();
			IL2CPP_RUNTIME_CLASS_INIT(GUILayoutUtility_tC8DDF719E399EA119E2889EFB47816B34CA58F5A_il2cpp_TypeInfo_var);
			LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8 * L_7;
			L_7 = GUILayoutUtility_SelectIDList_mBB4E4C5EE476C431E3105D76F13CEA683E7021CB(L_6, (bool)0, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
			GUIContent_ClearStaticCache_mD4647E7AF90A71B211AF157C9DDF12D25A0059A2(/*hidden argument*/NULL);
			IL2CPP_LEAVE(0x5D, FINALLY_0054);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0054;
	}

FINALLY_0054:
	{ // begin finally (depth: 1)
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_Internal_ExitGUI_m0B9B3280EB0CA732C5CFA32DA0384EA2D0A41090(/*hidden argument*/NULL);
		IL2CPP_END_FINALLY(84)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(84)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x5D, IL_005d)
	}

IL_005d:
	{
		return;
	}
}
// System.Boolean UnityEngine.GUIUtility::EndGUIFromException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_EndGUIFromException_mA815072F2FCEAAEA06BF7B23624251F58747E2AF (Exception_t * ___exception0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_Internal_ExitGUI_m0B9B3280EB0CA732C5CFA32DA0384EA2D0A41090(/*hidden argument*/NULL);
		Exception_t * L_0 = ___exception0;
		bool L_1;
		L_1 = GUIUtility_ShouldRethrowException_m4D31C054C92D4A3D13D7F64C23634376F1F44DCB(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.GUIUtility::EndContainerGUIFromException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_EndContainerGUIFromException_mA368DE91CD76071668ADB7DB87E579CF0D552E1A (Exception_t * ___exception0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_Invoke_m6E33E881BFD75761C0F91C7EEB1AF452BFD18445_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F * L_0 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_endContainerGUIFromException_6();
		V_0 = (bool)((!(((RuntimeObject*)(Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F *)L_0) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001b;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		Func_2_t6283F9D1F2A6C8BB45F72CDAD5856BC3FDF29C3F * L_2 = ((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->get_endContainerGUIFromException_6();
		Exception_t * L_3 = ___exception0;
		NullCheck(L_2);
		bool L_4;
		L_4 = Func_2_Invoke_m6E33E881BFD75761C0F91C7EEB1AF452BFD18445(L_2, L_3, /*hidden argument*/Func_2_Invoke_m6E33E881BFD75761C0F91C7EEB1AF452BFD18445_RuntimeMethod_var);
		V_1 = L_4;
		goto IL_001f;
	}

IL_001b:
	{
		V_1 = (bool)0;
		goto IL_001f;
	}

IL_001f:
	{
		bool L_5 = V_1;
		return L_5;
	}
}
// System.Void UnityEngine.GUIUtility::ResetGlobalState()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_ResetGlobalState_m5D608E689B0B1AA994702358158C7BB65373D3F7 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUI_set_skin_mFCD039C47B3C327D9E0D867092DB353F2CEA796E((GUISkin_tE353D65D4618423B574BAD31F5C5AC1B967E32C6 *)NULL, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_set_guiIsExiting_m13C69BE54D215B22CA7D1FE5192DD5ED744E0FCF_inline((bool)0, /*hidden argument*/NULL);
		GUI_set_changed_m7DBA5D0D2493D33D86E59D55942CE4FA56451DAC((bool)0, /*hidden argument*/NULL);
		GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * L_0;
		L_0 = GUI_get_scrollViewStates_mC0FF9F20045EB96D22254543B8C9A0643D54C4D4_inline(/*hidden argument*/NULL);
		NullCheck(L_0);
		VirtActionInvoker0::Invoke(13 /* System.Void System.Collections.Stack::Clear() */, L_0);
		return;
	}
}
// System.Boolean UnityEngine.GUIUtility::IsExitGUIException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_IsExitGUIException_mF80F38388A47904E471BC7CE0E1239845A9356C2 (Exception_t * ___exception0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExitGUIException_tA832626B99B4D827C8064643824847BCAA7877F4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TargetInvocationException_t30F4C50D323F448CD2E08BDB8F47694B08EB354C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	int32_t G_B5_0 = 0;
	{
		goto IL_000b;
	}

IL_0003:
	{
		Exception_t * L_0 = ___exception0;
		NullCheck(L_0);
		Exception_t * L_1;
		L_1 = Exception_get_InnerException_m10D85773B6B191C7D4E7D3C2954B84F9BB195218_inline(L_0, /*hidden argument*/NULL);
		___exception0 = L_1;
	}

IL_000b:
	{
		Exception_t * L_2 = ___exception0;
		if (!((TargetInvocationException_t30F4C50D323F448CD2E08BDB8F47694B08EB354C *)IsInstSealed((RuntimeObject*)L_2, TargetInvocationException_t30F4C50D323F448CD2E08BDB8F47694B08EB354C_il2cpp_TypeInfo_var)))
		{
			goto IL_001e;
		}
	}
	{
		Exception_t * L_3 = ___exception0;
		NullCheck(L_3);
		Exception_t * L_4;
		L_4 = Exception_get_InnerException_m10D85773B6B191C7D4E7D3C2954B84F9BB195218_inline(L_3, /*hidden argument*/NULL);
		G_B5_0 = ((!(((RuntimeObject*)(Exception_t *)L_4) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		goto IL_001f;
	}

IL_001e:
	{
		G_B5_0 = 0;
	}

IL_001f:
	{
		V_0 = (bool)G_B5_0;
		bool L_5 = V_0;
		if (L_5)
		{
			goto IL_0003;
		}
	}
	{
		Exception_t * L_6 = ___exception0;
		V_1 = (bool)((!(((RuntimeObject*)(ExitGUIException_tA832626B99B4D827C8064643824847BCAA7877F4 *)((ExitGUIException_tA832626B99B4D827C8064643824847BCAA7877F4 *)IsInstSealed((RuntimeObject*)L_6, ExitGUIException_tA832626B99B4D827C8064643824847BCAA7877F4_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		goto IL_002f;
	}

IL_002f:
	{
		bool L_7 = V_1;
		return L_7;
	}
}
// System.Boolean UnityEngine.GUIUtility::ShouldRethrowException(System.Exception)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_ShouldRethrowException_m4D31C054C92D4A3D13D7F64C23634376F1F44DCB (Exception_t * ___exception0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		Exception_t * L_0 = ___exception0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = GUIUtility_IsExitGUIException_mF80F38388A47904E471BC7CE0E1239845A9356C2(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000a;
	}

IL_000a:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.GUIUtility::CheckOnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_CheckOnGUI_mA591FC883697B53B61EC6B5B4469262BA6936FA7 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_0;
		L_0 = GUIUtility_get_guiDepth_mCEE2CF2630726CA657D48F0375866E2B8C314F2E(/*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)((((int32_t)L_0) > ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001b;
		}
	}
	{
		ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00 * L_2 = (ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_t505FA8C11E883F2D96C797AD9D396490794DEE00_il2cpp_TypeInfo_var)));
		ArgumentException__ctor_m2D35EAD113C2ADC99EB17B940A2097A93FD23EFC(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral3E5BD769C75B1966931F7A0F059B152FE79C2619)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&GUIUtility_CheckOnGUI_mA591FC883697B53B61EC6B5B4469262BA6936FA7_RuntimeMethod_var)));
	}

IL_001b:
	{
		return;
	}
}
// System.Boolean UnityEngine.GUIUtility::HitTest(UnityEngine.Rect,UnityEngine.Vector2,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_HitTest_mC4DE9B897D0988485EB1F36DF19111A20BB421D5 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___point1, int32_t ___offset2, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t G_B5_0 = 0;
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0 = ___point1;
		float L_1 = L_0.get_x_0();
		float L_2;
		L_2 = Rect_get_xMin_m02EA330BE4C4A07A3F18F50F257832E9E3C2B873((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___rect0), /*hidden argument*/NULL);
		int32_t L_3 = ___offset2;
		if ((!(((float)L_1) >= ((float)((float)il2cpp_codegen_subtract((float)L_2, (float)((float)((float)L_3))))))))
		{
			goto IL_004b;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4 = ___point1;
		float L_5 = L_4.get_x_0();
		float L_6;
		L_6 = Rect_get_xMax_m174FFAACE6F19A59AA793B3D507BE70116E27DE5((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___rect0), /*hidden argument*/NULL);
		int32_t L_7 = ___offset2;
		if ((!(((float)L_5) < ((float)((float)il2cpp_codegen_add((float)L_6, (float)((float)((float)L_7))))))))
		{
			goto IL_004b;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_8 = ___point1;
		float L_9 = L_8.get_y_1();
		float L_10;
		L_10 = Rect_get_yMin_m2C91041817D410B32B80E338764109D75ACB01E4((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___rect0), /*hidden argument*/NULL);
		int32_t L_11 = ___offset2;
		if ((!(((float)L_9) >= ((float)((float)il2cpp_codegen_subtract((float)L_10, (float)((float)((float)L_11))))))))
		{
			goto IL_004b;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_12 = ___point1;
		float L_13 = L_12.get_y_1();
		float L_14;
		L_14 = Rect_get_yMax_m9685BF55B44C51FF9BA080F9995073E458E1CDC3((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&___rect0), /*hidden argument*/NULL);
		int32_t L_15 = ___offset2;
		G_B5_0 = ((((float)L_13) < ((float)((float)il2cpp_codegen_add((float)L_14, (float)((float)((float)L_15))))))? 1 : 0);
		goto IL_004c;
	}

IL_004b:
	{
		G_B5_0 = 0;
	}

IL_004c:
	{
		V_0 = (bool)G_B5_0;
		goto IL_004f;
	}

IL_004f:
	{
		bool L_16 = V_0;
		return L_16;
	}
}
// System.Boolean UnityEngine.GUIUtility::HitTest(UnityEngine.Rect,UnityEngine.Vector2,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_HitTest_mDDEDB8F53EACE5BE782B70008DD61334BA8607FC (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___point1, bool ___isDirectManipulationDevice2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		V_0 = 0;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___rect0;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1 = ___point1;
		int32_t L_2 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = GUIUtility_HitTest_mC4DE9B897D0988485EB1F36DF19111A20BB421D5(L_0, L_1, L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		goto IL_000e;
	}

IL_000e:
	{
		bool L_4 = V_1;
		return L_4;
	}
}
// System.Boolean UnityEngine.GUIUtility::HitTest(UnityEngine.Rect,UnityEngine.Event)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUIUtility_HitTest_m6643D81E497211BA393BAE3C4807144E1BC4E074 (Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___rect0, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___evt1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___rect0;
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_1 = ___evt1;
		NullCheck(L_1);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2;
		L_2 = Event_get_mousePosition_m4D2A80BE0CF9A6D2CE8289C4815807493B3449A9(L_1, /*hidden argument*/NULL);
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_3 = ___evt1;
		NullCheck(L_3);
		bool L_4;
		L_4 = Event_get_isDirectManipulationDevice_mA61C39E8961354E6CC14256B8BCB000822B5755A(L_3, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		bool L_5;
		L_5 = GUIUtility_HitTest_mDDEDB8F53EACE5BE782B70008DD61334BA8607FC(L_0, L_2, L_4, /*hidden argument*/NULL);
		V_0 = L_5;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_6 = V_0;
		return L_6;
	}
}
// System.Void UnityEngine.GUIUtility::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility__cctor_mE77547426819C582016BDF9D04492102153E4E7F (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->set_s_ControlCount_0(0);
		return;
	}
}
// System.Int32 UnityEngine.GUIUtility::Internal_GetControlID_Injected(System.Int32,UnityEngine.FocusType,UnityEngine.Rect&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t GUIUtility_Internal_GetControlID_Injected_mB712E290E5EDE635C4F06E06F697D3D82AC8C901 (int32_t ___hint0, int32_t ___focusType1, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * ___rect2, const RuntimeMethod* method)
{
	typedef int32_t (*GUIUtility_Internal_GetControlID_Injected_mB712E290E5EDE635C4F06E06F697D3D82AC8C901_ftn) (int32_t, int32_t, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *);
	static GUIUtility_Internal_GetControlID_Injected_mB712E290E5EDE635C4F06E06F697D3D82AC8C901_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_Internal_GetControlID_Injected_mB712E290E5EDE635C4F06E06F697D3D82AC8C901_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::Internal_GetControlID_Injected(System.Int32,UnityEngine.FocusType,UnityEngine.Rect&)");
	int32_t icallRetVal = _il2cpp_icall_func(___hint0, ___focusType1, ___rect2);
	return icallRetVal;
}
// System.Void UnityEngine.GUIUtility::set_compositionCursorPos_Injected(UnityEngine.Vector2&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIUtility_set_compositionCursorPos_Injected_mA4689621797402B18EF4F9F5627A1990A86C8D4E (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * ___value0, const RuntimeMethod* method)
{
	typedef void (*GUIUtility_set_compositionCursorPos_Injected_mA4689621797402B18EF4F9F5627A1990A86C8D4E_ftn) (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *);
	static GUIUtility_set_compositionCursorPos_Injected_mA4689621797402B18EF4F9F5627A1990A86C8D4E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (GUIUtility_set_compositionCursorPos_Injected_mA4689621797402B18EF4F9F5627A1990A86C8D4E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.GUIUtility::set_compositionCursorPos_Injected(UnityEngine.Vector2&)");
	_il2cpp_icall_func(___value0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.GUIWordWrapSizer::.ctor(UnityEngine.GUIStyle,UnityEngine.GUIContent,UnityEngine.GUILayoutOption[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIWordWrapSizer__ctor_mB4991D92B5B194E9D760B7671C874D4382A434B1 (GUIWordWrapSizer_t2DC4A7EB6C47F17F06154C2605F4E522D1334D5D * __this, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___style0, GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * ___content1, GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* ___options2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = ___style0;
		IL2CPP_RUNTIME_CLASS_INIT(GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE_il2cpp_TypeInfo_var);
		GUILayoutEntry__ctor_m29C33DB9A9A93ECD86533A72B2822E34E8415640(__this, (0.0f), (0.0f), (0.0f), (0.0f), L_0, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = ___content1;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_2 = (GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *)il2cpp_codegen_object_new(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		GUIContent__ctor_m87E695240720FBABF3321CAA0F960FC02DF18647(L_2, L_1, /*hidden argument*/NULL);
		__this->set_m_Content_11(L_2);
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_3 = ___options2;
		VirtActionInvoker1< GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* >::Invoke(13 /* System.Void UnityEngine.GUILayoutEntry::ApplyOptions(UnityEngine.GUILayoutOption[]) */, __this, L_3);
		float L_4 = ((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->get_minHeight_2();
		__this->set_m_ForcedMinHeight_12(L_4);
		float L_5 = ((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->get_maxHeight_3();
		__this->set_m_ForcedMaxHeight_13(L_5);
		return;
	}
}
// System.Void UnityEngine.GUIWordWrapSizer::CalcWidth()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIWordWrapSizer_CalcWidth_m1FA5CF9113513880E3033544ADB8F0CFE4E96EA6 (GUIWordWrapSizer_t2DC4A7EB6C47F17F06154C2605F4E522D1334D5D * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	bool V_3 = false;
	bool V_4 = false;
	int32_t G_B3_0 = 0;
	{
		float L_0 = ((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->get_minWidth_0();
		if ((((float)L_0) == ((float)(0.0f))))
		{
			goto IL_001d;
		}
	}
	{
		float L_1 = ((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->get_maxWidth_1();
		G_B3_0 = ((((float)L_1) == ((float)(0.0f)))? 1 : 0);
		goto IL_001e;
	}

IL_001d:
	{
		G_B3_0 = 1;
	}

IL_001e:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_007a;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_3;
		L_3 = GUILayoutEntry_get_style_mCBE0882318C702289CFD524CF4246D1201BDCB7F(__this, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_4 = __this->get_m_Content_11();
		NullCheck(L_3);
		GUIStyle_CalcMinMaxWidth_m1D29C63D2C8A757F503FE3C0904E3276CC48BB94(L_3, L_4, (float*)(&V_1), (float*)(&V_2), /*hidden argument*/NULL);
		float L_5 = V_1;
		float L_6;
		L_6 = ceilf(L_5);
		V_1 = L_6;
		float L_7 = V_2;
		float L_8;
		L_8 = ceilf(L_7);
		V_2 = L_8;
		float L_9 = ((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->get_minWidth_0();
		V_3 = (bool)((((float)L_9) == ((float)(0.0f)))? 1 : 0);
		bool L_10 = V_3;
		if (!L_10)
		{
			goto IL_005f;
		}
	}
	{
		float L_11 = V_1;
		((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->set_minWidth_0(L_11);
	}

IL_005f:
	{
		float L_12 = ((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->get_maxWidth_1();
		V_4 = (bool)((((float)L_12) == ((float)(0.0f)))? 1 : 0);
		bool L_13 = V_4;
		if (!L_13)
		{
			goto IL_0079;
		}
	}
	{
		float L_14 = V_2;
		((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->set_maxWidth_1(L_14);
	}

IL_0079:
	{
	}

IL_007a:
	{
		return;
	}
}
// System.Void UnityEngine.GUIWordWrapSizer::CalcHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUIWordWrapSizer_CalcHeight_m5F5EA4595030AAB04A00135396E9E5566FDC2D31 (GUIWordWrapSizer_t2DC4A7EB6C47F17F06154C2605F4E522D1334D5D * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	float V_1 = 0.0f;
	bool V_2 = false;
	bool V_3 = false;
	int32_t G_B3_0 = 0;
	{
		float L_0 = __this->get_m_ForcedMinHeight_12();
		if ((((float)L_0) == ((float)(0.0f))))
		{
			goto IL_001d;
		}
	}
	{
		float L_1 = __this->get_m_ForcedMaxHeight_13();
		G_B3_0 = ((((float)L_1) == ((float)(0.0f)))? 1 : 0);
		goto IL_001e;
	}

IL_001d:
	{
		G_B3_0 = 1;
	}

IL_001e:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_008d;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_3;
		L_3 = GUILayoutEntry_get_style_mCBE0882318C702289CFD524CF4246D1201BDCB7F(__this, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_4 = __this->get_m_Content_11();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * L_5 = ((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->get_address_of_rect_4();
		float L_6;
		L_6 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)L_5, /*hidden argument*/NULL);
		NullCheck(L_3);
		float L_7;
		L_7 = GUIStyle_CalcHeight_m120220D334AEC6B33F4767EA54FE78CEC09FBCC9(L_3, L_4, L_6, /*hidden argument*/NULL);
		V_1 = L_7;
		float L_8 = __this->get_m_ForcedMinHeight_12();
		V_2 = (bool)((((float)L_8) == ((float)(0.0f)))? 1 : 0);
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_005a;
		}
	}
	{
		float L_10 = V_1;
		((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->set_minHeight_2(L_10);
		goto IL_0066;
	}

IL_005a:
	{
		float L_11 = __this->get_m_ForcedMinHeight_12();
		((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->set_minHeight_2(L_11);
	}

IL_0066:
	{
		float L_12 = __this->get_m_ForcedMaxHeight_13();
		V_3 = (bool)((((float)L_12) == ((float)(0.0f)))? 1 : 0);
		bool L_13 = V_3;
		if (!L_13)
		{
			goto IL_0080;
		}
	}
	{
		float L_14 = V_1;
		((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->set_maxHeight_3(L_14);
		goto IL_008c;
	}

IL_0080:
	{
		float L_15 = __this->get_m_ForcedMaxHeight_13();
		((GUILayoutEntry_t2999ED021CB0F188187989AC009621F0AE73A5DE *)__this)->set_maxHeight_3(L_15);
	}

IL_008c:
	{
	}

IL_008d:
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
// System.Void UnityEngine.ScrollViewState::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScrollViewState__ctor_m0D7C09E917B98DAE6CA669F180201B52F74A2C0E (ScrollViewState_t6ACB5023B94B7CD6372697F35F84E8A798C31AF0 * __this, const RuntimeMethod* method)
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






// Conversion methods for marshalling of: UnityEngine.SliderHandler
IL2CPP_EXTERN_C void SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshal_pinvoke(const SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4& unmarshaled, SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshaled_pinvoke& marshaled)
{
	Exception_t* ___slider_5Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'slider' of type 'SliderHandler': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___slider_5Exception, NULL);
}
IL2CPP_EXTERN_C void SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshal_pinvoke_back(const SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshaled_pinvoke& marshaled, SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4& unmarshaled)
{
	Exception_t* ___slider_5Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'slider' of type 'SliderHandler': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___slider_5Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.SliderHandler
IL2CPP_EXTERN_C void SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshal_pinvoke_cleanup(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshaled_pinvoke& marshaled)
{
}






// Conversion methods for marshalling of: UnityEngine.SliderHandler
IL2CPP_EXTERN_C void SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshal_com(const SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4& unmarshaled, SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshaled_com& marshaled)
{
	Exception_t* ___slider_5Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'slider' of type 'SliderHandler': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___slider_5Exception, NULL);
}
IL2CPP_EXTERN_C void SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshal_com_back(const SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshaled_com& marshaled, SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4& unmarshaled)
{
	Exception_t* ___slider_5Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'slider' of type 'SliderHandler': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___slider_5Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.SliderHandler
IL2CPP_EXTERN_C void SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshal_com_cleanup(SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.SliderHandler::.ctor(UnityEngine.Rect,System.Single,System.Single,System.Single,System.Single,UnityEngine.GUIStyle,UnityEngine.GUIStyle,System.Boolean,System.Int32,UnityEngine.GUIStyle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SliderHandler__ctor_mEDBEB4F32DE823ED83C1604F2439F480156A8A56 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, float ___currentValue1, float ___size2, float ___start3, float ___end4, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___slider5, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___thumb6, bool ___horiz7, int32_t ___id8, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___thumbExtent9, const RuntimeMethod* method)
{
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = ___position0;
		__this->set_position_0(L_0);
		float L_1 = ___currentValue1;
		__this->set_currentValue_1(L_1);
		float L_2 = ___size2;
		__this->set_size_2(L_2);
		float L_3 = ___start3;
		__this->set_start_3(L_3);
		float L_4 = ___end4;
		__this->set_end_4(L_4);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_5 = ___slider5;
		__this->set_slider_5(L_5);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_6 = ___thumb6;
		__this->set_thumb_6(L_6);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_7 = ___thumbExtent9;
		__this->set_thumbExtent_7(L_7);
		bool L_8 = ___horiz7;
		__this->set_horiz_8(L_8);
		int32_t L_9 = ___id8;
		__this->set_id_9(L_9);
		return;
	}
}
IL2CPP_EXTERN_C  void SliderHandler__ctor_mEDBEB4F32DE823ED83C1604F2439F480156A8A56_AdjustorThunk (RuntimeObject * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___position0, float ___currentValue1, float ___size2, float ___start3, float ___end4, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___slider5, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___thumb6, bool ___horiz7, int32_t ___id8, GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * ___thumbExtent9, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	SliderHandler__ctor_mEDBEB4F32DE823ED83C1604F2439F480156A8A56(_thisAdjusted, ___position0, ___currentValue1, ___size2, ___start3, ___end4, ___slider5, ___thumb6, ___horiz7, ___id8, ___thumbExtent9, method);
}
// System.Single UnityEngine.SliderHandler::Handle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_Handle_mF86CB8812570095EA2D216E7AA0FFBBB623DE7F1 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	float V_1 = 0.0f;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t G_B3_0 = 0;
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = __this->get_slider_5();
		if (!L_0)
		{
			goto IL_0014;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_1 = __this->get_thumb_6();
		G_B3_0 = ((((RuntimeObject*)(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *)L_1) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		goto IL_0015;
	}

IL_0014:
	{
		G_B3_0 = 1;
	}

IL_0015:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0022;
		}
	}
	{
		float L_3 = __this->get_currentValue_1();
		V_1 = L_3;
		goto IL_0076;
	}

IL_0022:
	{
		int32_t L_4;
		L_4 = SliderHandler_CurrentEventType_m9A5F50AD2DCDA644F0BDFD39A7D78A91E8A0CE03((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_3 = L_4;
		int32_t L_5 = V_3;
		V_2 = L_5;
		int32_t L_6 = V_2;
		switch (L_6)
		{
			case 0:
			{
				goto IL_0049;
			}
			case 1:
			{
				goto IL_005b;
			}
			case 2:
			{
				goto IL_006d;
			}
			case 3:
			{
				goto IL_0052;
			}
		}
	}
	{
		goto IL_0043;
	}

IL_0043:
	{
		int32_t L_7 = V_2;
		if ((((int32_t)L_7) == ((int32_t)7)))
		{
			goto IL_0064;
		}
	}
	{
		goto IL_006d;
	}

IL_0049:
	{
		float L_8;
		L_8 = SliderHandler_OnMouseDown_m23E8544B289BA7AEA59F407A60531803DA529C33((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_1 = L_8;
		goto IL_0076;
	}

IL_0052:
	{
		float L_9;
		L_9 = SliderHandler_OnMouseDrag_mF20837A5155A974918A2F9074E3A2BE29A29AE43((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_1 = L_9;
		goto IL_0076;
	}

IL_005b:
	{
		float L_10;
		L_10 = SliderHandler_OnMouseUp_mD8C283E0262ADE1D5931E94AB58C783D9997498B((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_1 = L_10;
		goto IL_0076;
	}

IL_0064:
	{
		float L_11;
		L_11 = SliderHandler_OnRepaint_m4EA34AB4CD8C441436A59DE1F389E9E2BB7863E8((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_1 = L_11;
		goto IL_0076;
	}

IL_006d:
	{
		float L_12 = __this->get_currentValue_1();
		V_1 = L_12;
		goto IL_0076;
	}

IL_0076:
	{
		float L_13 = V_1;
		return L_13;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_Handle_mF86CB8812570095EA2D216E7AA0FFBBB623DE7F1_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_Handle_mF86CB8812570095EA2D216E7AA0FFBBB623DE7F1(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::OnMouseDown()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_OnMouseDown_m23E8544B289BA7AEA59F407A60531803DA529C33 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemClock_tB9EEE70072B2822A428E3478AEBDCB6FCDFDEEB9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_0;
	memset((&V_0), 0, sizeof(V_0));
	bool V_1 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_2;
	memset((&V_2), 0, sizeof(V_2));
	float V_3 = 0.0f;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_4;
	memset((&V_4), 0, sizeof(V_4));
	bool V_5 = false;
	float V_6 = 0.0f;
	bool V_7 = false;
	bool V_8 = false;
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  V_9;
	memset((&V_9), 0, sizeof(V_9));
	int32_t G_B4_0 = 0;
	int32_t G_B6_0 = 0;
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0;
		L_0 = SliderHandler_ThumbSelectionRect_m31CADCE31EAC5F467A42EA1356B939AF32E3FB09((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_0 = L_0;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1 = V_0;
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_2;
		L_2 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = GUIUtility_HitTest_m6643D81E497211BA393BAE3C4807144E1BC4E074(L_1, L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_4;
		L_4 = Rect_get_zero_m4F738804E40698120CC691AB45A6416C4FF52589(/*hidden argument*/NULL);
		V_2 = L_4;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_5 = __this->get_position_0();
		V_4 = L_5;
		float L_6;
		L_6 = Rect_get_xMin_m02EA330BE4C4A07A3F18F50F257832E9E3C2B873((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		float L_7;
		L_7 = Rect_get_xMin_m02EA330BE4C4A07A3F18F50F257832E9E3C2B873((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Math_tA269614262430118C9FC5C4D9EF4F61C812568F0_il2cpp_TypeInfo_var);
		float L_8;
		L_8 = Math_Min_mED21323DC72FBF9A825FD4210D4B9D693CE87FCF(L_6, L_7, /*hidden argument*/NULL);
		Rect_set_xMin_mC91AC74347F8E3D537E8C5D70015E9B8EA872A3F((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_2), L_8, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_9 = __this->get_position_0();
		V_4 = L_9;
		float L_10;
		L_10 = Rect_get_xMax_m174FFAACE6F19A59AA793B3D507BE70116E27DE5((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		float L_11;
		L_11 = Rect_get_xMax_m174FFAACE6F19A59AA793B3D507BE70116E27DE5((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_12;
		L_12 = Math_Max_mEB87839DA28310AE4CB81A94D551874CFC2B1247(L_10, L_11, /*hidden argument*/NULL);
		Rect_set_xMax_m4E466ED07B11CC5457BD62517418C493C0DDF2E3((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_2), L_12, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_13 = __this->get_position_0();
		V_4 = L_13;
		float L_14;
		L_14 = Rect_get_yMin_m2C91041817D410B32B80E338764109D75ACB01E4((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		float L_15;
		L_15 = Rect_get_yMin_m2C91041817D410B32B80E338764109D75ACB01E4((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_16;
		L_16 = Math_Min_mED21323DC72FBF9A825FD4210D4B9D693CE87FCF(L_14, L_15, /*hidden argument*/NULL);
		Rect_set_yMin_mA2FDFF7C8C2361A4CF3F446BAB9A861F923F763A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_2), L_16, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_17 = __this->get_position_0();
		V_4 = L_17;
		float L_18;
		L_18 = Rect_get_yMax_m9685BF55B44C51FF9BA080F9995073E458E1CDC3((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		float L_19;
		L_19 = Rect_get_yMax_m9685BF55B44C51FF9BA080F9995073E458E1CDC3((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_20;
		L_20 = Math_Max_mEB87839DA28310AE4CB81A94D551874CFC2B1247(L_18, L_19, /*hidden argument*/NULL);
		Rect_set_yMax_m4E7A7C5E88FA369D6ED022C939427F4895F6635D((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_2), L_20, /*hidden argument*/NULL);
		bool L_21;
		L_21 = SliderHandler_IsEmptySlider_m8BBB2FFB1700D02971BCC9D82F1C380F18F400FF((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		if (L_21)
		{
			goto IL_00c6;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_22 = V_2;
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_23;
		L_23 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		bool L_24;
		L_24 = GUIUtility_HitTest_m6643D81E497211BA393BAE3C4807144E1BC4E074(L_22, L_23, /*hidden argument*/NULL);
		if (L_24)
		{
			goto IL_00c3;
		}
	}
	{
		bool L_25 = V_1;
		G_B4_0 = ((((int32_t)L_25) == ((int32_t)0))? 1 : 0);
		goto IL_00c4;
	}

IL_00c3:
	{
		G_B4_0 = 0;
	}

IL_00c4:
	{
		G_B6_0 = G_B4_0;
		goto IL_00c7;
	}

IL_00c6:
	{
		G_B6_0 = 1;
	}

IL_00c7:
	{
		V_5 = (bool)G_B6_0;
		bool L_26 = V_5;
		if (!L_26)
		{
			goto IL_00da;
		}
	}
	{
		float L_27 = __this->get_currentValue_1();
		V_6 = L_27;
		goto IL_0185;
	}

IL_00da:
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUI_set_scrollTroughSide_m0EAD9BD016B2E738A20356B3188A04A742AF60F2_inline(0, /*hidden argument*/NULL);
		int32_t L_28 = __this->get_id_9();
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_set_hotControl_m865CC0FAB4B33056CEC7047E38111D98097C52C8(L_28, /*hidden argument*/NULL);
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_29;
		L_29 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_29);
		Event_Use_m360896D3936BCA2FF8B3147C52952E9A4BE12519(L_29, /*hidden argument*/NULL);
		bool L_30 = V_1;
		V_7 = L_30;
		bool L_31 = V_7;
		if (!L_31)
		{
			goto IL_0118;
		}
	}
	{
		float L_32;
		L_32 = SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		SliderHandler_StartDraggingWithValue_m50B0784BA048DCAFF90809644E38B3DBCCFF890A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, L_32, /*hidden argument*/NULL);
		float L_33 = __this->get_currentValue_1();
		V_6 = L_33;
		goto IL_0185;
	}

IL_0118:
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUI_set_changed_m7DBA5D0D2493D33D86E59D55942CE4FA56451DAC((bool)1, /*hidden argument*/NULL);
		bool L_34;
		L_34 = SliderHandler_SupportsPageMovements_mD2A4C576F119F358E894AC6192BDA729DC6EE3B6((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_8 = L_34;
		bool L_35 = V_8;
		if (!L_35)
		{
			goto IL_016b;
		}
	}
	{
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_36;
		L_36 = SliderHandler_SliderState_m939A3BAD07388F8CA65E195655A3CA8967B5D127((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_36);
		L_36->set_isDragging_2((bool)0);
		IL2CPP_RUNTIME_CLASS_INIT(SystemClock_tB9EEE70072B2822A428E3478AEBDCB6FCDFDEEB9_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_37;
		L_37 = SystemClock_get_now_m67D7074CE3121B0702CF7CE0436F3C5496262391(/*hidden argument*/NULL);
		V_9 = L_37;
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_38;
		L_38 = DateTime_AddMilliseconds_m74B689CDAFB7ABEEF56827D8777B7C95C89C3154((DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 *)(&V_9), (250.0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUI_set_nextScrollStepTime_m3CF6DBBA4BE79B582AE4245AC02DED002C31E1DD_inline(L_38, /*hidden argument*/NULL);
		int32_t L_39;
		L_39 = SliderHandler_CurrentScrollTroughSide_m32D95131BA42F38C393B3948229E1B9443F4A6EC((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		GUI_set_scrollTroughSide_m0EAD9BD016B2E738A20356B3188A04A742AF60F2_inline(L_39, /*hidden argument*/NULL);
		float L_40;
		L_40 = SliderHandler_PageMovementValue_m50ADD2517DE35E7E2AA9A82B499CD6208AAA96A7((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_6 = L_40;
		goto IL_0185;
	}

IL_016b:
	{
		float L_41;
		L_41 = SliderHandler_ValueForCurrentMousePosition_m02359E724DC0AE243B1B34F29AC762F531F0D2B8((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_3 = L_41;
		float L_42 = V_3;
		SliderHandler_StartDraggingWithValue_m50B0784BA048DCAFF90809644E38B3DBCCFF890A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, L_42, /*hidden argument*/NULL);
		float L_43 = V_3;
		float L_44;
		L_44 = SliderHandler_Clamp_mD8AB2275AB386BA1F9751B313CA05FA413619DF6((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, L_43, /*hidden argument*/NULL);
		V_6 = L_44;
		goto IL_0185;
	}

IL_0185:
	{
		float L_45 = V_6;
		return L_45;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_OnMouseDown_m23E8544B289BA7AEA59F407A60531803DA529C33_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_OnMouseDown_m23E8544B289BA7AEA59F407A60531803DA529C33(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::OnMouseDrag()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_OnMouseDrag_mF20837A5155A974918A2F9074E3A2BE29A29AE43 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * V_0 = NULL;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	bool V_3 = false;
	float V_4 = 0.0f;
	bool V_5 = false;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_0;
		L_0 = GUIUtility_get_hotControl_m70A913241C32305A380F4DB4A3F1B37BB3401E5A(/*hidden argument*/NULL);
		int32_t L_1 = __this->get_id_9();
		V_3 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_2 = V_3;
		if (!L_2)
		{
			goto IL_001f;
		}
	}
	{
		float L_3 = __this->get_currentValue_1();
		V_4 = L_3;
		goto IL_007b;
	}

IL_001f:
	{
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_4;
		L_4 = SliderHandler_SliderState_m939A3BAD07388F8CA65E195655A3CA8967B5D127((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_0 = L_4;
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_5 = V_0;
		NullCheck(L_5);
		bool L_6 = L_5->get_isDragging_2();
		V_5 = (bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		bool L_7 = V_5;
		if (!L_7)
		{
			goto IL_003f;
		}
	}
	{
		float L_8 = __this->get_currentValue_1();
		V_4 = L_8;
		goto IL_007b;
	}

IL_003f:
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUI_set_changed_m7DBA5D0D2493D33D86E59D55942CE4FA56451DAC((bool)1, /*hidden argument*/NULL);
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_9;
		L_9 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_9);
		Event_Use_m360896D3936BCA2FF8B3147C52952E9A4BE12519(L_9, /*hidden argument*/NULL);
		float L_10;
		L_10 = SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_11 = V_0;
		NullCheck(L_11);
		float L_12 = L_11->get_dragStartPos_0();
		V_1 = ((float)il2cpp_codegen_subtract((float)L_10, (float)L_12));
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_13 = V_0;
		NullCheck(L_13);
		float L_14 = L_13->get_dragStartValue_1();
		float L_15 = V_1;
		float L_16;
		L_16 = SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_2 = ((float)il2cpp_codegen_add((float)L_14, (float)((float)((float)L_15/(float)L_16))));
		float L_17 = V_2;
		float L_18;
		L_18 = SliderHandler_Clamp_mD8AB2275AB386BA1F9751B313CA05FA413619DF6((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, L_17, /*hidden argument*/NULL);
		V_4 = L_18;
		goto IL_007b;
	}

IL_007b:
	{
		float L_19 = V_4;
		return L_19;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_OnMouseDrag_mF20837A5155A974918A2F9074E3A2BE29A29AE43_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_OnMouseDrag_mF20837A5155A974918A2F9074E3A2BE29A29AE43(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::OnMouseUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_OnMouseUp_mD8C283E0262ADE1D5931E94AB58C783D9997498B (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	float V_1 = 0.0f;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_0;
		L_0 = GUIUtility_get_hotControl_m70A913241C32305A380F4DB4A3F1B37BB3401E5A(/*hidden argument*/NULL);
		int32_t L_1 = __this->get_id_9();
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0027;
		}
	}
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_3;
		L_3 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		Event_Use_m360896D3936BCA2FF8B3147C52952E9A4BE12519(L_3, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_set_hotControl_m865CC0FAB4B33056CEC7047E38111D98097C52C8(0, /*hidden argument*/NULL);
	}

IL_0027:
	{
		float L_4 = __this->get_currentValue_1();
		V_1 = L_4;
		goto IL_0030;
	}

IL_0030:
	{
		float L_5 = V_1;
		return L_5;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_OnMouseUp_mD8C283E0262ADE1D5931E94AB58C783D9997498B_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_OnMouseUp_mD8C283E0262ADE1D5931E94AB58C783D9997498B(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::OnRepaint()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_OnRepaint_m4EA34AB4CD8C441436A59DE1F389E9E2BB7863E8 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemClock_tB9EEE70072B2822A428E3478AEBDCB6FCDFDEEB9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	float V_4 = 0.0f;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  V_9;
	memset((&V_9), 0, sizeof(V_9));
	bool V_10 = false;
	int32_t G_B4_0 = 0;
	int32_t G_B12_0 = 0;
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = __this->get_position_0();
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_1;
		L_1 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = GUIUtility_HitTest_m6643D81E497211BA393BAE3C4807144E1BC4E074(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_3 = __this->get_slider_5();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_4 = __this->get_position_0();
		IL2CPP_RUNTIME_CLASS_INIT(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_5 = ((GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields*)il2cpp_codegen_static_fields_for(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var))->get_none_6();
		int32_t L_6 = __this->get_id_9();
		bool L_7 = V_0;
		NullCheck(L_3);
		GUIStyle_Draw_mE548BD5036F0311925375E002619553086E0A61A(L_3, L_4, L_5, L_6, (bool)0, L_7, /*hidden argument*/NULL);
		bool L_8;
		L_8 = SliderHandler_IsEmptySlider_m8BBB2FFB1700D02971BCC9D82F1C380F18F400FF((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		if (L_8)
		{
			goto IL_0071;
		}
	}
	{
		float L_9 = __this->get_currentValue_1();
		float L_10 = __this->get_start_3();
		float L_11 = __this->get_end_4();
		float L_12;
		L_12 = Mathf_Min_mD28BD5C9012619B74E475F204F96603193E99B14(L_10, L_11, /*hidden argument*/NULL);
		if ((!(((float)L_9) >= ((float)L_12))))
		{
			goto IL_0071;
		}
	}
	{
		float L_13 = __this->get_currentValue_1();
		float L_14 = __this->get_start_3();
		float L_15 = __this->get_end_4();
		float L_16;
		L_16 = Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775(L_14, L_15, /*hidden argument*/NULL);
		G_B4_0 = ((((int32_t)((!(((float)L_13) <= ((float)L_16)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0072;
	}

IL_0071:
	{
		G_B4_0 = 0;
	}

IL_0072:
	{
		V_1 = (bool)G_B4_0;
		bool L_17 = V_1;
		if (!L_17)
		{
			goto IL_00c3;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_18 = __this->get_thumbExtent_7();
		V_2 = (bool)((!(((RuntimeObject*)(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 *)L_18) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_19 = V_2;
		if (!L_19)
		{
			goto IL_00a3;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_20 = __this->get_thumbExtent_7();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_21;
		L_21 = SliderHandler_ThumbExtRect_m4B760F15BC1C70617D6A012CE2B1FEF179B7A9CC((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_22 = ((GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields*)il2cpp_codegen_static_fields_for(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var))->get_none_6();
		int32_t L_23 = __this->get_id_9();
		bool L_24 = V_0;
		NullCheck(L_20);
		GUIStyle_Draw_mE548BD5036F0311925375E002619553086E0A61A(L_20, L_21, L_22, L_23, (bool)0, L_24, /*hidden argument*/NULL);
	}

IL_00a3:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_25 = __this->get_thumb_6();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_26;
		L_26 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_27 = ((GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_StaticFields*)il2cpp_codegen_static_fields_for(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var))->get_none_6();
		int32_t L_28 = __this->get_id_9();
		bool L_29 = V_0;
		NullCheck(L_25);
		GUIStyle_Draw_mE548BD5036F0311925375E002619553086E0A61A(L_25, L_26, L_27, L_28, (bool)0, L_29, /*hidden argument*/NULL);
	}

IL_00c3:
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_30;
		L_30 = GUIUtility_get_hotControl_m70A913241C32305A380F4DB4A3F1B37BB3401E5A(/*hidden argument*/NULL);
		int32_t L_31 = __this->get_id_9();
		if ((!(((uint32_t)L_30) == ((uint32_t)L_31))))
		{
			goto IL_00db;
		}
	}
	{
		bool L_32 = V_0;
		if (!L_32)
		{
			goto IL_00db;
		}
	}
	{
		bool L_33;
		L_33 = SliderHandler_IsEmptySlider_m8BBB2FFB1700D02971BCC9D82F1C380F18F400FF((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		G_B12_0 = ((int32_t)(L_33));
		goto IL_00dc;
	}

IL_00db:
	{
		G_B12_0 = 1;
	}

IL_00dc:
	{
		V_3 = (bool)G_B12_0;
		bool L_34 = V_3;
		if (!L_34)
		{
			goto IL_00ed;
		}
	}
	{
		float L_35 = __this->get_currentValue_1();
		V_4 = L_35;
		goto IL_01bf;
	}

IL_00ed:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_36;
		L_36 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_37;
		L_37 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		bool L_38;
		L_38 = GUIUtility_HitTest_m6643D81E497211BA393BAE3C4807144E1BC4E074(L_36, L_37, /*hidden argument*/NULL);
		V_5 = L_38;
		bool L_39 = V_5;
		if (!L_39)
		{
			goto IL_0129;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		int32_t L_40;
		L_40 = GUI_get_scrollTroughSide_m7746453E541149AB66B07FCCE8209BE42F37684C_inline(/*hidden argument*/NULL);
		V_6 = (bool)((!(((uint32_t)L_40) <= ((uint32_t)0)))? 1 : 0);
		bool L_41 = V_6;
		if (!L_41)
		{
			goto IL_011c;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_set_hotControl_m865CC0FAB4B33056CEC7047E38111D98097C52C8(0, /*hidden argument*/NULL);
	}

IL_011c:
	{
		float L_42 = __this->get_currentValue_1();
		V_4 = L_42;
		goto IL_01bf;
	}

IL_0129:
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUI_InternalRepaintEditorWindow_mB24AB5B2A1B62C2F7572ADC8F28711569434835C(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(SystemClock_tB9EEE70072B2822A428E3478AEBDCB6FCDFDEEB9_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_43;
		L_43 = SystemClock_get_now_m67D7074CE3121B0702CF7CE0436F3C5496262391(/*hidden argument*/NULL);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_44;
		L_44 = GUI_get_nextScrollStepTime_mD6A92E2DB68073C2B57EEFBDCB72D518B70E9065_inline(/*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405_il2cpp_TypeInfo_var);
		bool L_45;
		L_45 = DateTime_op_LessThan_m9822D8ADDCCACAA534FE3F98C44C352778B0C3DE(L_43, L_44, /*hidden argument*/NULL);
		V_7 = L_45;
		bool L_46 = V_7;
		if (!L_46)
		{
			goto IL_014e;
		}
	}
	{
		float L_47 = __this->get_currentValue_1();
		V_4 = L_47;
		goto IL_01bf;
	}

IL_014e:
	{
		int32_t L_48;
		L_48 = SliderHandler_CurrentScrollTroughSide_m32D95131BA42F38C393B3948229E1B9443F4A6EC((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		int32_t L_49;
		L_49 = GUI_get_scrollTroughSide_m7746453E541149AB66B07FCCE8209BE42F37684C_inline(/*hidden argument*/NULL);
		V_8 = (bool)((((int32_t)((((int32_t)L_48) == ((int32_t)L_49))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_50 = V_8;
		if (!L_50)
		{
			goto IL_016e;
		}
	}
	{
		float L_51 = __this->get_currentValue_1();
		V_4 = L_51;
		goto IL_01bf;
	}

IL_016e:
	{
		IL2CPP_RUNTIME_CLASS_INIT(SystemClock_tB9EEE70072B2822A428E3478AEBDCB6FCDFDEEB9_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_52;
		L_52 = SystemClock_get_now_m67D7074CE3121B0702CF7CE0436F3C5496262391(/*hidden argument*/NULL);
		V_9 = L_52;
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_53;
		L_53 = DateTime_AddMilliseconds_m74B689CDAFB7ABEEF56827D8777B7C95C89C3154((DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405 *)(&V_9), (30.0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUI_set_nextScrollStepTime_m3CF6DBBA4BE79B582AE4245AC02DED002C31E1DD_inline(L_53, /*hidden argument*/NULL);
		bool L_54;
		L_54 = SliderHandler_SupportsPageMovements_mD2A4C576F119F358E894AC6192BDA729DC6EE3B6((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_10 = L_54;
		bool L_55 = V_10;
		if (!L_55)
		{
			goto IL_01b5;
		}
	}
	{
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_56;
		L_56 = SliderHandler_SliderState_m939A3BAD07388F8CA65E195655A3CA8967B5D127((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_56);
		L_56->set_isDragging_2((bool)0);
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GUI_set_changed_m7DBA5D0D2493D33D86E59D55942CE4FA56451DAC((bool)1, /*hidden argument*/NULL);
		float L_57;
		L_57 = SliderHandler_PageMovementValue_m50ADD2517DE35E7E2AA9A82B499CD6208AAA96A7((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_4 = L_57;
		goto IL_01bf;
	}

IL_01b5:
	{
		float L_58;
		L_58 = SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_4 = L_58;
		goto IL_01bf;
	}

IL_01bf:
	{
		float L_59 = V_4;
		return L_59;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_OnRepaint_m4EA34AB4CD8C441436A59DE1F389E9E2BB7863E8_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_OnRepaint_m4EA34AB4CD8C441436A59DE1F389E9E2BB7863E8(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.EventType UnityEngine.SliderHandler::CurrentEventType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SliderHandler_CurrentEventType_m9A5F50AD2DCDA644F0BDFD39A7D78A91E8A0CE03 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_0;
		L_0 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		int32_t L_1 = __this->get_id_9();
		NullCheck(L_0);
		int32_t L_2;
		L_2 = Event_GetTypeForControl_mDCE0BCF26BE2422E17902BCE31693CBA83EB4052(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0015;
	}

IL_0015:
	{
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t SliderHandler_CurrentEventType_m9A5F50AD2DCDA644F0BDFD39A7D78A91E8A0CE03_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = SliderHandler_CurrentEventType_m9A5F50AD2DCDA644F0BDFD39A7D78A91E8A0CE03(_thisAdjusted, method);
	return _returnValue;
}
// System.Int32 UnityEngine.SliderHandler::CurrentScrollTroughSide()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t SliderHandler_CurrentScrollTroughSide_m32D95131BA42F38C393B3948229E1B9443F4A6EC (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_2;
	memset((&V_2), 0, sizeof(V_2));
	int32_t V_3 = 0;
	float G_B3_0 = 0.0f;
	float G_B6_0 = 0.0f;
	int32_t G_B9_0 = 0;
	{
		bool L_0 = __this->get_horiz_8();
		if (L_0)
		{
			goto IL_001b;
		}
	}
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_1;
		L_1 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_1);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2;
		L_2 = Event_get_mousePosition_m4D2A80BE0CF9A6D2CE8289C4815807493B3449A9(L_1, /*hidden argument*/NULL);
		float L_3 = L_2.get_y_1();
		G_B3_0 = L_3;
		goto IL_002b;
	}

IL_001b:
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_4;
		L_4 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_4);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_5;
		L_5 = Event_get_mousePosition_m4D2A80BE0CF9A6D2CE8289C4815807493B3449A9(L_4, /*hidden argument*/NULL);
		float L_6 = L_5.get_x_0();
		G_B3_0 = L_6;
	}

IL_002b:
	{
		V_0 = G_B3_0;
		bool L_7 = __this->get_horiz_8();
		if (L_7)
		{
			goto IL_0044;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_8;
		L_8 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_2 = L_8;
		float L_9;
		L_9 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_2), /*hidden argument*/NULL);
		G_B6_0 = L_9;
		goto IL_0052;
	}

IL_0044:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_10;
		L_10 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_2 = L_10;
		float L_11;
		L_11 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_2), /*hidden argument*/NULL);
		G_B6_0 = L_11;
	}

IL_0052:
	{
		V_1 = G_B6_0;
		float L_12 = V_0;
		float L_13 = V_1;
		if ((((float)L_12) > ((float)L_13)))
		{
			goto IL_005a;
		}
	}
	{
		G_B9_0 = (-1);
		goto IL_005b;
	}

IL_005a:
	{
		G_B9_0 = 1;
	}

IL_005b:
	{
		V_3 = G_B9_0;
		goto IL_005e;
	}

IL_005e:
	{
		int32_t L_14 = V_3;
		return L_14;
	}
}
IL2CPP_EXTERN_C  int32_t SliderHandler_CurrentScrollTroughSide_m32D95131BA42F38C393B3948229E1B9443F4A6EC_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = SliderHandler_CurrentScrollTroughSide_m32D95131BA42F38C393B3948229E1B9443F4A6EC(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.SliderHandler::IsEmptySlider()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SliderHandler_IsEmptySlider_m8BBB2FFB1700D02971BCC9D82F1C380F18F400FF (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		float L_0 = __this->get_start_3();
		float L_1 = __this->get_end_4();
		V_0 = (bool)((((float)L_0) == ((float)L_1))? 1 : 0);
		goto IL_0012;
	}

IL_0012:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  bool SliderHandler_IsEmptySlider_m8BBB2FFB1700D02971BCC9D82F1C380F18F400FF_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	bool _returnValue;
	_returnValue = SliderHandler_IsEmptySlider_m8BBB2FFB1700D02971BCC9D82F1C380F18F400FF(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.SliderHandler::SupportsPageMovements()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SliderHandler_SupportsPageMovements_mD2A4C576F119F358E894AC6192BDA729DC6EE3B6 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t G_B3_0 = 0;
	{
		float L_0 = __this->get_size_2();
		if ((((float)L_0) == ((float)(0.0f))))
		{
			goto IL_0015;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = GUI_get_usePageScrollbars_m3704DFEA154B1C6CAD3558E8EAA5CCA1F976C233(/*hidden argument*/NULL);
		G_B3_0 = ((int32_t)(L_1));
		goto IL_0016;
	}

IL_0015:
	{
		G_B3_0 = 0;
	}

IL_0016:
	{
		V_0 = (bool)G_B3_0;
		goto IL_0019;
	}

IL_0019:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  bool SliderHandler_SupportsPageMovements_mD2A4C576F119F358E894AC6192BDA729DC6EE3B6_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	bool _returnValue;
	_returnValue = SliderHandler_SupportsPageMovements_mD2A4C576F119F358E894AC6192BDA729DC6EE3B6(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::PageMovementValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_PageMovementValue_m50ADD2517DE35E7E2AA9A82B499CD6208AAA96A7 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	int32_t V_1 = 0;
	bool V_2 = false;
	float V_3 = 0.0f;
	int32_t G_B3_0 = 0;
	{
		float L_0 = __this->get_currentValue_1();
		V_0 = L_0;
		float L_1 = __this->get_start_3();
		float L_2 = __this->get_end_4();
		if ((((float)L_1) > ((float)L_2)))
		{
			goto IL_0019;
		}
	}
	{
		G_B3_0 = 1;
		goto IL_001a;
	}

IL_0019:
	{
		G_B3_0 = (-1);
	}

IL_001a:
	{
		V_1 = G_B3_0;
		float L_3;
		L_3 = SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_4;
		L_4 = SliderHandler_PageUpMovementBound_m6DA2C83E39C8F8510FBFAF1397E110444005D658((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_2 = (bool)((((float)L_3) > ((float)L_4))? 1 : 0);
		bool L_5 = V_2;
		if (!L_5)
		{
			goto IL_0041;
		}
	}
	{
		float L_6 = V_0;
		float L_7 = __this->get_size_2();
		int32_t L_8 = V_1;
		V_0 = ((float)il2cpp_codegen_add((float)L_6, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_multiply((float)L_7, (float)((float)((float)L_8)))), (float)(0.899999976f)))));
		goto IL_0053;
	}

IL_0041:
	{
		float L_9 = V_0;
		float L_10 = __this->get_size_2();
		int32_t L_11 = V_1;
		V_0 = ((float)il2cpp_codegen_subtract((float)L_9, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_multiply((float)L_10, (float)((float)((float)L_11)))), (float)(0.899999976f)))));
	}

IL_0053:
	{
		float L_12 = V_0;
		float L_13;
		L_13 = SliderHandler_Clamp_mD8AB2275AB386BA1F9751B313CA05FA413619DF6((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, L_12, /*hidden argument*/NULL);
		V_3 = L_13;
		goto IL_005d;
	}

IL_005d:
	{
		float L_14 = V_3;
		return L_14;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_PageMovementValue_m50ADD2517DE35E7E2AA9A82B499CD6208AAA96A7_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_PageMovementValue_m50ADD2517DE35E7E2AA9A82B499CD6208AAA96A7(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::PageUpMovementBound()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_PageUpMovementBound_m6DA2C83E39C8F8510FBFAF1397E110444005D658 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_1;
	memset((&V_1), 0, sizeof(V_1));
	float V_2 = 0.0f;
	{
		bool L_0 = __this->get_horiz_8();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_002b;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_2;
		L_2 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_1 = L_2;
		float L_3;
		L_3 = Rect_get_xMax_m174FFAACE6F19A59AA793B3D507BE70116E27DE5((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_4 = __this->get_position_0();
		V_1 = L_4;
		float L_5;
		L_5 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		V_2 = ((float)il2cpp_codegen_subtract((float)L_3, (float)L_5));
		goto IL_004b;
	}

IL_002b:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_6;
		L_6 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_1 = L_6;
		float L_7;
		L_7 = Rect_get_yMax_m9685BF55B44C51FF9BA080F9995073E458E1CDC3((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_8 = __this->get_position_0();
		V_1 = L_8;
		float L_9;
		L_9 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		V_2 = ((float)il2cpp_codegen_subtract((float)L_7, (float)L_9));
		goto IL_004b;
	}

IL_004b:
	{
		float L_10 = V_2;
		return L_10;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_PageUpMovementBound_m6DA2C83E39C8F8510FBFAF1397E110444005D658_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_PageUpMovementBound_m6DA2C83E39C8F8510FBFAF1397E110444005D658(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Event UnityEngine.SliderHandler::CurrentEvent()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * V_0 = NULL;
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_0;
		L_0 = Event_get_current_m069E3E742E6CBC32C3BC958B85153E75B0192443(/*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * _returnValue;
	_returnValue = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::ValueForCurrentMousePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_ValueForCurrentMousePosition_m02359E724DC0AE243B1B34F29AC762F531F0D2B8 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_1;
	memset((&V_1), 0, sizeof(V_1));
	float V_2 = 0.0f;
	{
		bool L_0 = __this->get_horiz_8();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0044;
		}
	}
	{
		float L_2;
		L_2 = SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_3;
		L_3 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_1 = L_3;
		float L_4;
		L_4 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		float L_5;
		L_5 = SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_6 = __this->get_start_3();
		float L_7 = __this->get_size_2();
		V_2 = ((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_add((float)((float)((float)((float)il2cpp_codegen_subtract((float)L_2, (float)((float)il2cpp_codegen_multiply((float)L_4, (float)(0.5f)))))/(float)L_5)), (float)L_6)), (float)((float)il2cpp_codegen_multiply((float)L_7, (float)(0.5f)))));
		goto IL_007d;
	}

IL_0044:
	{
		float L_8;
		L_8 = SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_9;
		L_9 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_1 = L_9;
		float L_10;
		L_10 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		float L_11;
		L_11 = SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_12 = __this->get_start_3();
		float L_13 = __this->get_size_2();
		V_2 = ((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_add((float)((float)((float)((float)il2cpp_codegen_subtract((float)L_8, (float)((float)il2cpp_codegen_multiply((float)L_10, (float)(0.5f)))))/(float)L_11)), (float)L_12)), (float)((float)il2cpp_codegen_multiply((float)L_13, (float)(0.5f)))));
		goto IL_007d;
	}

IL_007d:
	{
		float L_14 = V_2;
		return L_14;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_ValueForCurrentMousePosition_m02359E724DC0AE243B1B34F29AC762F531F0D2B8_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_ValueForCurrentMousePosition_m02359E724DC0AE243B1B34F29AC762F531F0D2B8(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::Clamp(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_Clamp_mD8AB2275AB386BA1F9751B313CA05FA413619DF6 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, float ___value0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = ___value0;
		float L_1;
		L_1 = SliderHandler_MinValue_m073EA73B5C7E24798E10AF850E5FB8E7B59A579A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_2;
		L_2 = SliderHandler_MaxValue_mC8B1C5738087924C1522142553435D4BB2588756((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_3;
		L_3 = Mathf_Clamp_m2416F3B785C8F135863E3D17E5B0CB4174797B87(L_0, L_1, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_0016;
	}

IL_0016:
	{
		float L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_Clamp_mD8AB2275AB386BA1F9751B313CA05FA413619DF6_AdjustorThunk (RuntimeObject * __this, float ___value0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_Clamp_mD8AB2275AB386BA1F9751B313CA05FA413619DF6(_thisAdjusted, ___value0, method);
	return _returnValue;
}
// UnityEngine.Rect UnityEngine.SliderHandler::ThumbSelectionRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbSelectionRect_m31CADCE31EAC5F467A42EA1356B939AF32E3FB09 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_4;
	memset((&V_4), 0, sizeof(V_4));
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0;
		L_0 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_0 = L_0;
		V_1 = ((int32_t)12);
		float L_1;
		L_1 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		int32_t L_2 = V_1;
		V_2 = (bool)((((float)L_1) < ((float)((float)((float)L_2))))? 1 : 0);
		bool L_3 = V_2;
		if (!L_3)
		{
			goto IL_0045;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * L_4 = (&V_0);
		float L_5;
		L_5 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)L_4, /*hidden argument*/NULL);
		int32_t L_6 = V_1;
		float L_7;
		L_7 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		Rect_set_x_m1147A05B5046E1D4427E8EC99B9DFA4A32EEDEE6((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)L_4, ((float)il2cpp_codegen_subtract((float)L_5, (float)((float)((float)((float)il2cpp_codegen_subtract((float)((float)((float)L_6)), (float)L_7))/(float)(2.0f))))), /*hidden argument*/NULL);
		int32_t L_8 = V_1;
		Rect_set_width_m07D84AD7C7093EDCCD94A7B93A9447CA9917DD9D((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), ((float)((float)L_8)), /*hidden argument*/NULL);
	}

IL_0045:
	{
		float L_9;
		L_9 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		int32_t L_10 = V_1;
		V_3 = (bool)((((float)L_9) < ((float)((float)((float)L_10))))? 1 : 0);
		bool L_11 = V_3;
		if (!L_11)
		{
			goto IL_007f;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 * L_12 = (&V_0);
		float L_13;
		L_13 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)L_12, /*hidden argument*/NULL);
		int32_t L_14 = V_1;
		float L_15;
		L_15 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		Rect_set_y_m015507262F8AC5AFF1B4E986B66307F31FB3A10E((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)L_12, ((float)il2cpp_codegen_subtract((float)L_13, (float)((float)((float)((float)il2cpp_codegen_subtract((float)((float)((float)L_14)), (float)L_15))/(float)(2.0f))))), /*hidden argument*/NULL);
		int32_t L_16 = V_1;
		Rect_set_height_m4A00B16C122F44FEF4BA074386F3DC11FF4B4D23((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), ((float)((float)L_16)), /*hidden argument*/NULL);
	}

IL_007f:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_17 = V_0;
		V_4 = L_17;
		goto IL_0084;
	}

IL_0084:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_18 = V_4;
		return L_18;
	}
}
IL2CPP_EXTERN_C  Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbSelectionRect_m31CADCE31EAC5F467A42EA1356B939AF32E3FB09_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  _returnValue;
	_returnValue = SliderHandler_ThumbSelectionRect_m31CADCE31EAC5F467A42EA1356B939AF32E3FB09(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.SliderHandler::StartDraggingWithValue(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SliderHandler_StartDraggingWithValue_m50B0784BA048DCAFF90809644E38B3DBCCFF890A (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, float ___dragStartValue0, const RuntimeMethod* method)
{
	SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * V_0 = NULL;
	{
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_0;
		L_0 = SliderHandler_SliderState_m939A3BAD07388F8CA65E195655A3CA8967B5D127((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_0 = L_0;
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_1 = V_0;
		float L_2;
		L_2 = SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_1);
		L_1->set_dragStartPos_0(L_2);
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_3 = V_0;
		float L_4 = ___dragStartValue0;
		NullCheck(L_3);
		L_3->set_dragStartValue_1(L_4);
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_5 = V_0;
		NullCheck(L_5);
		L_5->set_isDragging_2((bool)1);
		return;
	}
}
IL2CPP_EXTERN_C  void SliderHandler_StartDraggingWithValue_m50B0784BA048DCAFF90809644E38B3DBCCFF890A_AdjustorThunk (RuntimeObject * __this, float ___dragStartValue0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	SliderHandler_StartDraggingWithValue_m50B0784BA048DCAFF90809644E38B3DBCCFF890A(_thisAdjusted, ___dragStartValue0, method);
}
// UnityEngine.SliderState UnityEngine.SliderHandler::SliderState()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * SliderHandler_SliderState_m939A3BAD07388F8CA65E195655A3CA8967B5D127 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * V_0 = NULL;
	{
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_0 = { reinterpret_cast<intptr_t> (SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1;
		L_1 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E(L_0, /*hidden argument*/NULL);
		int32_t L_2 = __this->get_id_9();
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		RuntimeObject * L_3;
		L_3 = GUIUtility_GetStateObject_mCB51130ADCCE1FC49DCF65A1BC5545A07E012E6A(L_1, L_2, /*hidden argument*/NULL);
		V_0 = ((SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A *)CastclassClass((RuntimeObject*)L_3, SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A_il2cpp_TypeInfo_var));
		goto IL_001e;
	}

IL_001e:
	{
		SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * SliderHandler_SliderState_m939A3BAD07388F8CA65E195655A3CA8967B5D127_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * _returnValue;
	_returnValue = SliderHandler_SliderState_m939A3BAD07388F8CA65E195655A3CA8967B5D127(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Rect UnityEngine.SliderHandler::ThumbExtRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbExtRect_m4B760F15BC1C70617D6A012CE2B1FEF179B7A9CC (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_0;
	memset((&V_0), 0, sizeof(V_0));
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_1;
	memset((&V_1), 0, sizeof(V_1));
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_2;
	memset((&V_2), 0, sizeof(V_2));
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_3;
	memset((&V_3), 0, sizeof(V_3));
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = __this->get_thumbExtent_7();
		NullCheck(L_0);
		float L_1;
		L_1 = GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C(L_0, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_2 = __this->get_thumbExtent_7();
		NullCheck(L_2);
		float L_3;
		L_3 = GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865(L_2, /*hidden argument*/NULL);
		Rect__ctor_m12075526A02B55B680716A34AD5287B223122B70((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), (0.0f), (0.0f), L_1, L_3, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_4;
		L_4 = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_2 = L_4;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_5;
		L_5 = Rect_get_center_mDFC7A4AE153DCDC1D6248803381C6F36C7883707((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_2), /*hidden argument*/NULL);
		Rect_set_center_mEEB5135E547FB6E296BF27F57BC857313A9A48DD((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), L_5, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_6 = V_1;
		V_0 = L_6;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_7 = V_0;
		V_3 = L_7;
		goto IL_0044;
	}

IL_0044:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_8 = V_3;
		return L_8;
	}
}
IL2CPP_EXTERN_C  Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbExtRect_m4B760F15BC1C70617D6A012CE2B1FEF179B7A9CC_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  _returnValue;
	_returnValue = SliderHandler_ThumbExtRect_m4B760F15BC1C70617D6A012CE2B1FEF179B7A9CC(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Rect UnityEngine.SliderHandler::ThumbRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_0;
	memset((&V_0), 0, sizeof(V_0));
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  G_B3_0;
	memset((&G_B3_0), 0, sizeof(G_B3_0));
	{
		bool L_0 = __this->get_horiz_8();
		if (L_0)
		{
			goto IL_0011;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1;
		L_1 = SliderHandler_VerticalThumbRect_m82DF3DABA3132CBD308A79ED264CDC0567D4BF6B((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		G_B3_0 = L_1;
		goto IL_0017;
	}

IL_0011:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_2;
		L_2 = SliderHandler_HorizontalThumbRect_m4732996A81968BEFC836C08AABDDCB5A5D243A6F((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
	}

IL_0017:
	{
		V_0 = G_B3_0;
		goto IL_001a;
	}

IL_001a:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  _returnValue;
	_returnValue = SliderHandler_ThumbRect_m0E1CAE72256D7407B30389BF1493A7E7000D95A5(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Rect UnityEngine.SliderHandler::VerticalThumbRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_VerticalThumbRect_m82DF3DABA3132CBD308A79ED264CDC0567D4BF6B (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_0;
	memset((&V_0), 0, sizeof(V_0));
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	bool V_4 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_5;
	memset((&V_5), 0, sizeof(V_5));
	float G_B3_0 = 0.0f;
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = __this->get_thumb_6();
		NullCheck(L_0);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_1;
		L_1 = GUIStyle_get_margin_m1AF5B34B3BE9B514A8B189EAE16F976245C4A363(L_0, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_2 = __this->get_slider_5();
		NullCheck(L_2);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_3;
		L_3 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_2, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_4 = __this->get_position_0();
		NullCheck(L_3);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_5;
		L_5 = RectOffset_Remove_m49C8247D2CBB0080F7A09A37D3F1288403AE1BFB(L_3, L_4, /*hidden argument*/NULL);
		NullCheck(L_1);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_6;
		L_6 = RectOffset_Remove_m49C8247D2CBB0080F7A09A37D3F1288403AE1BFB(L_1, L_5, /*hidden argument*/NULL);
		V_0 = L_6;
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_7 = __this->get_thumb_6();
		NullCheck(L_7);
		float L_8;
		L_8 = GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C(L_7, /*hidden argument*/NULL);
		if ((!(((float)L_8) == ((float)(0.0f)))))
		{
			goto IL_0043;
		}
	}
	{
		float L_9;
		L_9 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		G_B3_0 = L_9;
		goto IL_004e;
	}

IL_0043:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_10 = __this->get_thumb_6();
		NullCheck(L_10);
		float L_11;
		L_11 = GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C(L_10, /*hidden argument*/NULL);
		G_B3_0 = L_11;
	}

IL_004e:
	{
		V_1 = G_B3_0;
		float L_12;
		L_12 = SliderHandler_ThumbSize_m585B339F13F16DEA83D5CC6F4DA0A181822D2947((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_2 = L_12;
		float L_13;
		L_13 = SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_3 = L_13;
		float L_14 = __this->get_start_3();
		float L_15 = __this->get_end_4();
		V_4 = (bool)((((float)L_14) < ((float)L_15))? 1 : 0);
		bool L_16 = V_4;
		if (!L_16)
		{
			goto IL_00a4;
		}
	}
	{
		float L_17;
		L_17 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_18;
		L_18 = SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_19 = __this->get_start_3();
		float L_20 = V_3;
		float L_21;
		L_21 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_22 = V_1;
		float L_23 = __this->get_size_2();
		float L_24 = V_3;
		float L_25 = V_2;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_26;
		memset((&L_26), 0, sizeof(L_26));
		Rect__ctor_m12075526A02B55B680716A34AD5287B223122B70((&L_26), L_17, ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_18, (float)L_19)), (float)L_20)), (float)L_21)), L_22, ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_23, (float)L_24)), (float)L_25)), /*hidden argument*/NULL);
		V_5 = L_26;
		goto IL_00df;
	}

IL_00a4:
	{
		float L_27;
		L_27 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_28;
		L_28 = SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_29 = __this->get_size_2();
		float L_30 = __this->get_start_3();
		float L_31 = V_3;
		float L_32;
		L_32 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_33 = V_1;
		float L_34 = __this->get_size_2();
		float L_35 = V_3;
		float L_36 = V_2;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_37;
		memset((&L_37), 0, sizeof(L_37));
		Rect__ctor_m12075526A02B55B680716A34AD5287B223122B70((&L_37), L_27, ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_add((float)L_28, (float)L_29)), (float)L_30)), (float)L_31)), (float)L_32)), L_33, ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_34, (float)((-L_35)))), (float)L_36)), /*hidden argument*/NULL);
		V_5 = L_37;
		goto IL_00df;
	}

IL_00df:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_38 = V_5;
		return L_38;
	}
}
IL2CPP_EXTERN_C  Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_VerticalThumbRect_m82DF3DABA3132CBD308A79ED264CDC0567D4BF6B_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  _returnValue;
	_returnValue = SliderHandler_VerticalThumbRect_m82DF3DABA3132CBD308A79ED264CDC0567D4BF6B(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.Rect UnityEngine.SliderHandler::HorizontalThumbRect()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_HorizontalThumbRect_m4732996A81968BEFC836C08AABDDCB5A5D243A6F (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_0;
	memset((&V_0), 0, sizeof(V_0));
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	float V_3 = 0.0f;
	bool V_4 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_5;
	memset((&V_5), 0, sizeof(V_5));
	float G_B3_0 = 0.0f;
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = __this->get_thumb_6();
		NullCheck(L_0);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_1;
		L_1 = GUIStyle_get_margin_m1AF5B34B3BE9B514A8B189EAE16F976245C4A363(L_0, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_2 = __this->get_slider_5();
		NullCheck(L_2);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_3;
		L_3 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_2, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_4 = __this->get_position_0();
		NullCheck(L_3);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_5;
		L_5 = RectOffset_Remove_m49C8247D2CBB0080F7A09A37D3F1288403AE1BFB(L_3, L_4, /*hidden argument*/NULL);
		NullCheck(L_1);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_6;
		L_6 = RectOffset_Remove_m49C8247D2CBB0080F7A09A37D3F1288403AE1BFB(L_1, L_5, /*hidden argument*/NULL);
		V_0 = L_6;
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_7 = __this->get_thumb_6();
		NullCheck(L_7);
		float L_8;
		L_8 = GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865(L_7, /*hidden argument*/NULL);
		if ((!(((float)L_8) == ((float)(0.0f)))))
		{
			goto IL_0043;
		}
	}
	{
		float L_9;
		L_9 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		G_B3_0 = L_9;
		goto IL_004e;
	}

IL_0043:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_10 = __this->get_thumb_6();
		NullCheck(L_10);
		float L_11;
		L_11 = GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865(L_10, /*hidden argument*/NULL);
		G_B3_0 = L_11;
	}

IL_004e:
	{
		V_1 = G_B3_0;
		float L_12;
		L_12 = SliderHandler_ThumbSize_m585B339F13F16DEA83D5CC6F4DA0A181822D2947((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_2 = L_12;
		float L_13;
		L_13 = SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		V_3 = L_13;
		float L_14 = __this->get_start_3();
		float L_15 = __this->get_end_4();
		V_4 = (bool)((((float)L_14) < ((float)L_15))? 1 : 0);
		bool L_16 = V_4;
		if (!L_16)
		{
			goto IL_00a3;
		}
	}
	{
		float L_17;
		L_17 = SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_18 = __this->get_start_3();
		float L_19 = V_3;
		float L_20;
		L_20 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_21;
		L_21 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_22 = __this->get_size_2();
		float L_23 = V_3;
		float L_24 = V_2;
		float L_25 = V_1;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_26;
		memset((&L_26), 0, sizeof(L_26));
		Rect__ctor_m12075526A02B55B680716A34AD5287B223122B70((&L_26), ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_17, (float)L_18)), (float)L_19)), (float)L_20)), L_21, ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_22, (float)L_23)), (float)L_24)), L_25, /*hidden argument*/NULL);
		V_5 = L_26;
		goto IL_00dd;
	}

IL_00a3:
	{
		float L_27;
		L_27 = SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_28 = __this->get_size_2();
		float L_29 = __this->get_start_3();
		float L_30 = V_3;
		float L_31;
		L_31 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_32;
		L_32 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_0), /*hidden argument*/NULL);
		float L_33 = __this->get_size_2();
		float L_34 = V_3;
		float L_35 = V_2;
		float L_36 = V_1;
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_37;
		memset((&L_37), 0, sizeof(L_37));
		Rect__ctor_m12075526A02B55B680716A34AD5287B223122B70((&L_37), ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_add((float)L_27, (float)L_28)), (float)L_29)), (float)L_30)), (float)L_31)), L_32, ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_33, (float)((-L_34)))), (float)L_35)), L_36, /*hidden argument*/NULL);
		V_5 = L_37;
		goto IL_00dd;
	}

IL_00dd:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_38 = V_5;
		return L_38;
	}
}
IL2CPP_EXTERN_C  Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  SliderHandler_HorizontalThumbRect_m4732996A81968BEFC836C08AABDDCB5A5D243A6F_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  _returnValue;
	_returnValue = SliderHandler_HorizontalThumbRect_m4732996A81968BEFC836C08AABDDCB5A5D243A6F(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::ClampedCurrentValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_currentValue_1();
		float L_1;
		L_1 = SliderHandler_Clamp_mD8AB2275AB386BA1F9751B313CA05FA413619DF6((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		float L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_ClampedCurrentValue_m2F440E6A40A04E7F55A51254599F9E90FEAD1B80(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::MousePosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_1;
	memset((&V_1), 0, sizeof(V_1));
	float V_2 = 0.0f;
	{
		bool L_0 = __this->get_horiz_8();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_002d;
		}
	}
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_2;
		L_2 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_2);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_3;
		L_3 = Event_get_mousePosition_m4D2A80BE0CF9A6D2CE8289C4815807493B3449A9(L_2, /*hidden argument*/NULL);
		float L_4 = L_3.get_x_0();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_5 = __this->get_position_0();
		V_1 = L_5;
		float L_6;
		L_6 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		V_2 = ((float)il2cpp_codegen_subtract((float)L_4, (float)L_6));
		goto IL_004f;
	}

IL_002d:
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_7;
		L_7 = SliderHandler_CurrentEvent_mE45046335770DC72DB92E192CF48224B20B3027A((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		NullCheck(L_7);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_8;
		L_8 = Event_get_mousePosition_m4D2A80BE0CF9A6D2CE8289C4815807493B3449A9(L_7, /*hidden argument*/NULL);
		float L_9 = L_8.get_y_1();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_10 = __this->get_position_0();
		V_1 = L_10;
		float L_11;
		L_11 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		V_2 = ((float)il2cpp_codegen_subtract((float)L_9, (float)L_11));
		goto IL_004f;
	}

IL_004f:
	{
		float L_12 = V_2;
		return L_12;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_MousePosition_mEF3CA5152014850CEFC0781C2AFC840A11A9F8AE(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::ValuesPerPixel()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_1;
	memset((&V_1), 0, sizeof(V_1));
	float V_2 = 0.0f;
	{
		bool L_0 = __this->get_horiz_8();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0043;
		}
	}
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_2 = __this->get_position_0();
		V_1 = L_2;
		float L_3;
		L_3 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_4 = __this->get_slider_5();
		NullCheck(L_4);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_5;
		L_5 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_4, /*hidden argument*/NULL);
		NullCheck(L_5);
		int32_t L_6;
		L_6 = RectOffset_get_horizontal_m7B1D97260EF95BCEDB9A7AF7AC9FAF99D56E9177(L_5, /*hidden argument*/NULL);
		float L_7;
		L_7 = SliderHandler_ThumbSize_m585B339F13F16DEA83D5CC6F4DA0A181822D2947((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_8 = __this->get_end_4();
		float L_9 = __this->get_start_3();
		V_2 = ((float)((float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_subtract((float)L_3, (float)((float)((float)L_6)))), (float)L_7))/(float)((float)il2cpp_codegen_subtract((float)L_8, (float)L_9))));
		goto IL_007b;
	}

IL_0043:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_10 = __this->get_position_0();
		V_1 = L_10;
		float L_11;
		L_11 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_12 = __this->get_slider_5();
		NullCheck(L_12);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_13;
		L_13 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_12, /*hidden argument*/NULL);
		NullCheck(L_13);
		int32_t L_14;
		L_14 = RectOffset_get_vertical_m589292AEF7A556D4FD0CED648DEED422C1CA36A4(L_13, /*hidden argument*/NULL);
		float L_15;
		L_15 = SliderHandler_ThumbSize_m585B339F13F16DEA83D5CC6F4DA0A181822D2947((SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *)__this, /*hidden argument*/NULL);
		float L_16 = __this->get_end_4();
		float L_17 = __this->get_start_3();
		V_2 = ((float)((float)((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_subtract((float)L_11, (float)((float)((float)L_14)))), (float)L_15))/(float)((float)il2cpp_codegen_subtract((float)L_16, (float)L_17))));
		goto IL_007b;
	}

IL_007b:
	{
		float L_18 = V_2;
		return L_18;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_ValuesPerPixel_mC4D99A25825054733F415BE747A92B81F2D59F77(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::ThumbSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_ThumbSize_m585B339F13F16DEA83D5CC6F4DA0A181822D2947 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	float V_1 = 0.0f;
	float G_B4_0 = 0.0f;
	float G_B8_0 = 0.0f;
	{
		bool L_0 = __this->get_horiz_8();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_003e;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_2 = __this->get_thumb_6();
		NullCheck(L_2);
		float L_3;
		L_3 = GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C(L_2, /*hidden argument*/NULL);
		if ((!(((float)L_3) == ((float)(0.0f)))))
		{
			goto IL_0030;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_4 = __this->get_thumb_6();
		NullCheck(L_4);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_5;
		L_5 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_4, /*hidden argument*/NULL);
		NullCheck(L_5);
		int32_t L_6;
		L_6 = RectOffset_get_horizontal_m7B1D97260EF95BCEDB9A7AF7AC9FAF99D56E9177(L_5, /*hidden argument*/NULL);
		G_B4_0 = ((float)((float)L_6));
		goto IL_003b;
	}

IL_0030:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_7 = __this->get_thumb_6();
		NullCheck(L_7);
		float L_8;
		L_8 = GUIStyle_get_fixedWidth_m3FE6013CACA3459C7E572E4B2CAF8CD7B54C6F1C(L_7, /*hidden argument*/NULL);
		G_B4_0 = L_8;
	}

IL_003b:
	{
		V_1 = G_B4_0;
		goto IL_0071;
	}

IL_003e:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_9 = __this->get_thumb_6();
		NullCheck(L_9);
		float L_10;
		L_10 = GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865(L_9, /*hidden argument*/NULL);
		if ((!(((float)L_10) == ((float)(0.0f)))))
		{
			goto IL_0063;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_11 = __this->get_thumb_6();
		NullCheck(L_11);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_12;
		L_12 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_11, /*hidden argument*/NULL);
		NullCheck(L_12);
		int32_t L_13;
		L_13 = RectOffset_get_vertical_m589292AEF7A556D4FD0CED648DEED422C1CA36A4(L_12, /*hidden argument*/NULL);
		G_B8_0 = ((float)((float)L_13));
		goto IL_006e;
	}

IL_0063:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_14 = __this->get_thumb_6();
		NullCheck(L_14);
		float L_15;
		L_15 = GUIStyle_get_fixedHeight_mE1D2038EB276EEC0FC42A0F08C782569EE2DE865(L_14, /*hidden argument*/NULL);
		G_B8_0 = L_15;
	}

IL_006e:
	{
		V_1 = G_B8_0;
		goto IL_0071;
	}

IL_0071:
	{
		float L_16 = V_1;
		return L_16;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_ThumbSize_m585B339F13F16DEA83D5CC6F4DA0A181822D2947_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_ThumbSize_m585B339F13F16DEA83D5CC6F4DA0A181822D2947(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::MaxValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_MaxValue_mC8B1C5738087924C1522142553435D4BB2588756 (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_start_3();
		float L_1 = __this->get_end_4();
		float L_2;
		L_2 = Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775(L_0, L_1, /*hidden argument*/NULL);
		float L_3 = __this->get_size_2();
		V_0 = ((float)il2cpp_codegen_subtract((float)L_2, (float)L_3));
		goto IL_001c;
	}

IL_001c:
	{
		float L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_MaxValue_mC8B1C5738087924C1522142553435D4BB2588756_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_MaxValue_mC8B1C5738087924C1522142553435D4BB2588756(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.SliderHandler::MinValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float SliderHandler_MinValue_m073EA73B5C7E24798E10AF850E5FB8E7B59A579A (SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_start_3();
		float L_1 = __this->get_end_4();
		float L_2;
		L_2 = Mathf_Min_mD28BD5C9012619B74E475F204F96603193E99B14(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0015;
	}

IL_0015:
	{
		float L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  float SliderHandler_MinValue_m073EA73B5C7E24798E10AF850E5FB8E7B59A579A_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 * _thisAdjusted = reinterpret_cast<SliderHandler_tA2B178A38D229E413A6FABEDCF424A63B160C4D4 *>(__this + _offset);
	float _returnValue;
	_returnValue = SliderHandler_MinValue_m073EA73B5C7E24798E10AF850E5FB8E7B59A579A(_thisAdjusted, method);
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
// System.Void UnityEngine.SliderState::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SliderState__ctor_m52C1830A6B916BE4BD18799B3934E79665EE3EDE (SliderState_t2A7A763A3DACB04584347A9FEEEB1B905A60880A * __this, const RuntimeMethod* method)
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
// System.String UnityEngine.TextEditor::get_text()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = __this->get_m_Content_8();
		NullCheck(L_0);
		String_t* L_1;
		L_1 = GUIContent_get_text_mA6BE9C17B069417994ED27EE812A39BB960D921A(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		String_t* L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.TextEditor::set_text(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_set_text_mD9129625FFD2F23A4A1F40C2D8BB09F516C9356F (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, String_t* ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* G_B2_0 = NULL;
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * G_B2_1 = NULL;
	String_t* G_B1_0 = NULL;
	GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * G_B1_1 = NULL;
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_0 = __this->get_m_Content_8();
		String_t* L_1 = ___value0;
		String_t* L_2 = L_1;
		G_B1_0 = L_2;
		G_B1_1 = L_0;
		if (L_2)
		{
			G_B2_0 = L_2;
			G_B2_1 = L_0;
			goto IL_0011;
		}
	}
	{
		String_t* L_3 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		G_B2_0 = L_3;
		G_B2_1 = G_B1_1;
	}

IL_0011:
	{
		NullCheck(G_B2_1);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(G_B2_1, G_B2_0, /*hidden argument*/NULL);
		int32_t* L_4 = __this->get_address_of_m_CursorIndex_10();
		TextEditor_EnsureValidCodePointIndex_mB443C43308B056AE4E13DA6108E1DC1549CF7662(__this, (int32_t*)L_4, /*hidden argument*/NULL);
		int32_t* L_5 = __this->get_address_of_m_SelectIndex_11();
		TextEditor_EnsureValidCodePointIndex_mB443C43308B056AE4E13DA6108E1DC1549CF7662(__this, (int32_t*)L_5, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Rect UnityEngine.TextEditor::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = __this->get_m_Position_9();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.TextEditor::set_position(UnityEngine.Rect)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_set_position_m021494940550A18AF6D726639F58E60528813EE8 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  ___value0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0 = __this->get_m_Position_9();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1 = ___value0;
		bool L_2;
		L_2 = Rect_op_Equality_m17C955A4F85F01A7CF0B43EDE41463301E93F6C1(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0013;
		}
	}
	{
		goto IL_002c;
	}

IL_0013:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4;
		L_4 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		__this->set_scrollOffset_7(L_4);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_5 = ___value0;
		__this->set_m_Position_9(L_5);
		TextEditor_UpdateScrollOffset_mF6F74A14D6F9824B19A0D01BC9D0A7583CD2A5F4(__this, /*hidden argument*/NULL);
	}

IL_002c:
	{
		return;
	}
}
// UnityEngine.Rect UnityEngine.TextEditor::get_localPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  TextEditor_get_localPosition_m0227C5065DAC9B874867C2C7862F747BABA56659 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_0;
		L_0 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1 = V_0;
		return L_1;
	}
}
// System.Int32 UnityEngine.TextEditor::get_cursorIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_CursorIndex_10();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.TextEditor::set_cursorIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___value0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		int32_t L_0 = __this->get_m_CursorIndex_10();
		V_0 = L_0;
		int32_t L_1 = ___value0;
		__this->set_m_CursorIndex_10(L_1);
		int32_t* L_2 = __this->get_address_of_m_CursorIndex_10();
		TextEditor_EnsureValidCodePointIndex_mB443C43308B056AE4E13DA6108E1DC1549CF7662(__this, (int32_t*)L_2, /*hidden argument*/NULL);
		int32_t L_3 = __this->get_m_CursorIndex_10();
		int32_t L_4 = V_0;
		V_1 = (bool)((((int32_t)((((int32_t)L_3) == ((int32_t)L_4))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_003c;
		}
	}
	{
		__this->set_m_RevealCursor_12((bool)1);
		VirtActionInvoker0::Invoke(6 /* System.Void UnityEngine.TextEditor::OnCursorIndexChange() */, __this);
	}

IL_003c:
	{
		return;
	}
}
// System.Int32 UnityEngine.TextEditor::get_selectIndex()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_SelectIndex_11();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.TextEditor::set_selectIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___value0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		int32_t L_0 = __this->get_m_SelectIndex_11();
		V_0 = L_0;
		int32_t L_1 = ___value0;
		__this->set_m_SelectIndex_11(L_1);
		int32_t* L_2 = __this->get_address_of_m_SelectIndex_11();
		TextEditor_EnsureValidCodePointIndex_mB443C43308B056AE4E13DA6108E1DC1549CF7662(__this, (int32_t*)L_2, /*hidden argument*/NULL);
		int32_t L_3 = __this->get_m_SelectIndex_11();
		int32_t L_4 = V_0;
		V_1 = (bool)((((int32_t)((((int32_t)L_3) == ((int32_t)L_4))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0033;
		}
	}
	{
		VirtActionInvoker0::Invoke(7 /* System.Void UnityEngine.TextEditor::OnSelectIndexChange() */, __this);
	}

IL_0033:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::ClearCursorPos()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		__this->set_hasHorizontalCursorPos_4((bool)0);
		__this->set_m_iAltCursorPos_19((-1));
		return;
	}
}
// System.Void UnityEngine.TextEditor::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor__ctor_m638747CE4AED20B2F497618337649E32D2ADA099 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		__this->set_keyboardOnScreen_0((TouchScreenKeyboard_t7964B2E9E52C4E095B14F01C32774B98CA11711E *)NULL);
		__this->set_controlID_1(0);
		IL2CPP_RUNTIME_CLASS_INIT(GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726_il2cpp_TypeInfo_var);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0;
		L_0 = GUIStyle_get_none_mE13C9D26505C972F8697EE0E0E66D169D6D731A1(/*hidden argument*/NULL);
		__this->set_style_2(L_0);
		__this->set_multiline_3((bool)0);
		__this->set_hasHorizontalCursorPos_4((bool)0);
		__this->set_isPasswordField_5((bool)0);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_1;
		L_1 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		__this->set_scrollOffset_7(L_1);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_2 = (GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E *)il2cpp_codegen_object_new(GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E_il2cpp_TypeInfo_var);
		GUIContent__ctor_mC57EB7929C7079750DF0FBFE6001732F74926A42(L_2, /*hidden argument*/NULL);
		__this->set_m_Content_8(L_2);
		__this->set_m_CursorIndex_10(0);
		__this->set_m_SelectIndex_11(0);
		__this->set_m_RevealCursor_12((bool)0);
		__this->set_m_MouseDragSelectsWholeWords_15((bool)0);
		__this->set_m_DblClickInitPos_16(0);
		__this->set_m_DblClickSnap_17(0);
		__this->set_m_bJustSelected_18((bool)0);
		__this->set_m_iAltCursorPos_19((-1));
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::OnFocus()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_OnFocus_mA391FDD8A6F669C33F4F47AA6190DFA7E6C1DDE8 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	{
		bool L_0 = __this->get_multiline_3();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_2 = 0;
		V_1 = L_2;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_2, /*hidden argument*/NULL);
		int32_t L_3 = V_1;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_3, /*hidden argument*/NULL);
		goto IL_0026;
	}

IL_001f:
	{
		TextEditor_SelectAll_m5EDB0E8D503B602A6A1AFF213E45766B57702598(__this, /*hidden argument*/NULL);
	}

IL_0026:
	{
		__this->set_m_HasFocus_6((bool)1);
		return;
	}
}
// System.Void UnityEngine.TextEditor::OnLostFocus()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_OnLostFocus_m2E8FBC8864AA1B1EE5A56C13458618BE0EFFB783 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		__this->set_m_HasFocus_6((bool)0);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0;
		L_0 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		__this->set_scrollOffset_7(L_0);
		return;
	}
}
// System.Void UnityEngine.TextEditor::GrabGraphicalCursorPos()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_GrabGraphicalCursorPos_m8B726D6524D664B81CC8D4EC0D11FFB51BDD236E (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		bool L_0 = __this->get_hasHorizontalCursorPos_4();
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_005d;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_2 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_3;
		L_3 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_4 = __this->get_m_Content_8();
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_2);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_6;
		L_6 = GUIStyle_GetCursorPixelPosition_m8D4E34D8BFB582440B88F54643D095DF13DEA4F3(L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
		__this->set_graphicalCursorPos_13(L_6);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_7 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_8;
		L_8 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_9 = __this->get_m_Content_8();
		int32_t L_10;
		L_10 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		NullCheck(L_7);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_11;
		L_11 = GUIStyle_GetCursorPixelPosition_m8D4E34D8BFB582440B88F54643D095DF13DEA4F3(L_7, L_8, L_9, L_10, /*hidden argument*/NULL);
		__this->set_graphicalSelectCursorPos_14(L_11);
		__this->set_hasHorizontalCursorPos_4((bool)0);
	}

IL_005d:
	{
		return;
	}
}
// System.Boolean UnityEngine.TextEditor::HandleKeyEvent(UnityEngine.Event)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_HandleKeyEvent_mECE746CCA51866A165A911C6566FEAC06AA9189C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___e0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_0 = ___e0;
		bool L_1;
		L_1 = TextEditor_HandleKeyEvent_mA953F9277140AD596AEB563FCC189E9974B1B14A(__this, L_0, (bool)0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.TextEditor::HandleKeyEvent(UnityEngine.Event,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_HandleKeyEvent_mA953F9277140AD596AEB563FCC189E9974B1B14A (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___e0, bool ___textIsReadOnly1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_ContainsKey_mDD8A87D2680C370A2DBC4AFECE658B948EEA1202_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_get_Item_m5423F5CE10F5EA6145EECF26BE0F452A301D2B39_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	bool V_3 = false;
	{
		TextEditor_InitKeyActions_m1073E6D1966025612EFAD14D6C17E590EA95359A(__this, /*hidden argument*/NULL);
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_0 = ___e0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Event_get_modifiers_m01356D3F1DDF6746122F129713EBE87BFA65D886(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_2 = ___e0;
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_3 = L_2;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = Event_get_modifiers_m01356D3F1DDF6746122F129713EBE87BFA65D886(L_3, /*hidden argument*/NULL);
		NullCheck(L_3);
		Event_set_modifiers_m375A78874878A2BA7822E93CA62579B0E4CA7AA2(L_3, ((int32_t)((int32_t)L_4&(int32_t)((int32_t)-33))), /*hidden argument*/NULL);
		Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * L_5 = ((TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_StaticFields*)il2cpp_codegen_static_fields_for(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var))->get_s_Keyactions_23();
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_6 = ___e0;
		NullCheck(L_5);
		bool L_7;
		L_7 = Dictionary_2_ContainsKey_mDD8A87D2680C370A2DBC4AFECE658B948EEA1202(L_5, L_6, /*hidden argument*/Dictionary_2_ContainsKey_mDD8A87D2680C370A2DBC4AFECE658B948EEA1202_RuntimeMethod_var);
		V_1 = L_7;
		bool L_8 = V_1;
		if (!L_8)
		{
			goto IL_0050;
		}
	}
	{
		Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * L_9 = ((TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_StaticFields*)il2cpp_codegen_static_fields_for(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var))->get_s_Keyactions_23();
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_10 = ___e0;
		NullCheck(L_9);
		int32_t L_11;
		L_11 = Dictionary_2_get_Item_m5423F5CE10F5EA6145EECF26BE0F452A301D2B39(L_9, L_10, /*hidden argument*/Dictionary_2_get_Item_m5423F5CE10F5EA6145EECF26BE0F452A301D2B39_RuntimeMethod_var);
		V_2 = L_11;
		int32_t L_12 = V_2;
		bool L_13 = ___textIsReadOnly1;
		bool L_14;
		L_14 = TextEditor_PerformOperation_mC8D7C480A86101BE510AB2ED83107110259C7821(__this, L_12, L_13, /*hidden argument*/NULL);
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_15 = ___e0;
		int32_t L_16 = V_0;
		NullCheck(L_15);
		Event_set_modifiers_m375A78874878A2BA7822E93CA62579B0E4CA7AA2(L_15, L_16, /*hidden argument*/NULL);
		V_3 = (bool)1;
		goto IL_005c;
	}

IL_0050:
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_17 = ___e0;
		int32_t L_18 = V_0;
		NullCheck(L_17);
		Event_set_modifiers_m375A78874878A2BA7822E93CA62579B0E4CA7AA2(L_17, L_18, /*hidden argument*/NULL);
		V_3 = (bool)0;
		goto IL_005c;
	}

IL_005c:
	{
		bool L_19 = V_3;
		return L_19;
	}
}
// System.Boolean UnityEngine.TextEditor::DeleteLineBack()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_DeleteLineBack_mD4520B7DDC6E616C2AF04DDFE23A4AC234437DE1 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	int32_t V_8 = 0;
	{
		bool L_0;
		L_0 = TextEditor_get_hasSelection_mB5CEC2D56136DDE95D62226438FA4620E027D41B(__this, /*hidden argument*/NULL);
		V_2 = L_0;
		bool L_1 = V_2;
		if (!L_1)
		{
			goto IL_001a;
		}
	}
	{
		bool L_2;
		L_2 = TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D(__this, /*hidden argument*/NULL);
		V_3 = (bool)1;
		goto IL_00ab;
	}

IL_001a:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_0 = L_3;
		int32_t L_4 = V_0;
		V_1 = L_4;
		goto IL_0042;
	}

IL_0025:
	{
		String_t* L_5;
		L_5 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_6 = V_1;
		NullCheck(L_5);
		Il2CppChar L_7;
		L_7 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_5, L_6, /*hidden argument*/NULL);
		V_4 = (bool)((((int32_t)L_7) == ((int32_t)((int32_t)10)))? 1 : 0);
		bool L_8 = V_4;
		if (!L_8)
		{
			goto IL_0042;
		}
	}
	{
		int32_t L_9 = V_1;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_9, (int32_t)1));
		goto IL_0050;
	}

IL_0042:
	{
		int32_t L_10 = V_1;
		int32_t L_11 = L_10;
		V_1 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_11, (int32_t)1));
		V_5 = (bool)((!(((uint32_t)L_11) <= ((uint32_t)0)))? 1 : 0);
		bool L_12 = V_5;
		if (L_12)
		{
			goto IL_0025;
		}
	}

IL_0050:
	{
		int32_t L_13 = V_1;
		V_6 = (bool)((((int32_t)L_13) == ((int32_t)(-1)))? 1 : 0);
		bool L_14 = V_6;
		if (!L_14)
		{
			goto IL_005c;
		}
	}
	{
		V_0 = 0;
	}

IL_005c:
	{
		int32_t L_15;
		L_15 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_16 = V_0;
		V_7 = (bool)((((int32_t)((((int32_t)L_15) == ((int32_t)L_16))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_17 = V_7;
		if (!L_17)
		{
			goto IL_00a7;
		}
	}
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_18 = __this->get_m_Content_8();
		String_t* L_19;
		L_19 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_20 = V_0;
		int32_t L_21;
		L_21 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_22 = V_0;
		NullCheck(L_19);
		String_t* L_23;
		L_23 = String_Remove_mA7DE3D6FE3344FD65108B33BD1DE8020D22ADAC0(L_19, L_20, ((int32_t)il2cpp_codegen_subtract((int32_t)L_21, (int32_t)L_22)), /*hidden argument*/NULL);
		NullCheck(L_18);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_18, L_23, /*hidden argument*/NULL);
		int32_t L_24 = V_0;
		int32_t L_25 = L_24;
		V_8 = L_25;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_25, /*hidden argument*/NULL);
		int32_t L_26 = V_8;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_26, /*hidden argument*/NULL);
		V_3 = (bool)1;
		goto IL_00ab;
	}

IL_00a7:
	{
		V_3 = (bool)0;
		goto IL_00ab;
	}

IL_00ab:
	{
		bool L_27 = V_3;
		return L_27;
	}
}
// System.Boolean UnityEngine.TextEditor::DeleteWordBack()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_DeleteWordBack_mD5B1AA3E2F877EB51D2472C1308B217CA2F54A06 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	int32_t V_4 = 0;
	{
		bool L_0;
		L_0 = TextEditor_get_hasSelection_mB5CEC2D56136DDE95D62226438FA4620E027D41B(__this, /*hidden argument*/NULL);
		V_1 = L_0;
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		bool L_2;
		L_2 = TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D(__this, /*hidden argument*/NULL);
		V_2 = (bool)1;
		goto IL_0071;
	}

IL_0017:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_FindEndOfPreviousWord_mDFB854C75C7B3BDB5920E004C1F106500966A8BF(__this, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_6 = V_0;
		V_3 = (bool)((((int32_t)((((int32_t)L_5) == ((int32_t)L_6))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_7 = V_3;
		if (!L_7)
		{
			goto IL_006d;
		}
	}
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_8 = __this->get_m_Content_8();
		String_t* L_9;
		L_9 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_10 = V_0;
		int32_t L_11;
		L_11 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_12 = V_0;
		NullCheck(L_9);
		String_t* L_13;
		L_13 = String_Remove_mA7DE3D6FE3344FD65108B33BD1DE8020D22ADAC0(L_9, L_10, ((int32_t)il2cpp_codegen_subtract((int32_t)L_11, (int32_t)L_12)), /*hidden argument*/NULL);
		NullCheck(L_8);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_8, L_13, /*hidden argument*/NULL);
		int32_t L_14 = V_0;
		int32_t L_15 = L_14;
		V_4 = L_15;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_15, /*hidden argument*/NULL);
		int32_t L_16 = V_4;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_16, /*hidden argument*/NULL);
		V_2 = (bool)1;
		goto IL_0071;
	}

IL_006d:
	{
		V_2 = (bool)0;
		goto IL_0071;
	}

IL_0071:
	{
		bool L_17 = V_2;
		return L_17;
	}
}
// System.Boolean UnityEngine.TextEditor::DeleteWordForward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_DeleteWordForward_m7BB52B567A1BBECD4663DF683FD2B996E58CF040 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	{
		bool L_0;
		L_0 = TextEditor_get_hasSelection_mB5CEC2D56136DDE95D62226438FA4620E027D41B(__this, /*hidden argument*/NULL);
		V_1 = L_0;
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		bool L_2;
		L_2 = TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D(__this, /*hidden argument*/NULL);
		V_2 = (bool)1;
		goto IL_0069;
	}

IL_0017:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_FindStartOfNextWord_m59724B3A53A023031EDC1E852721F58B980ED36C(__this, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		String_t* L_6;
		L_6 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_6);
		int32_t L_7;
		L_7 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_6, /*hidden argument*/NULL);
		V_3 = (bool)((((int32_t)L_5) < ((int32_t)L_7))? 1 : 0);
		bool L_8 = V_3;
		if (!L_8)
		{
			goto IL_0065;
		}
	}
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_9 = __this->get_m_Content_8();
		String_t* L_10;
		L_10 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_11;
		L_11 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_12 = V_0;
		int32_t L_13;
		L_13 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_10);
		String_t* L_14;
		L_14 = String_Remove_mA7DE3D6FE3344FD65108B33BD1DE8020D22ADAC0(L_10, L_11, ((int32_t)il2cpp_codegen_subtract((int32_t)L_12, (int32_t)L_13)), /*hidden argument*/NULL);
		NullCheck(L_9);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_9, L_14, /*hidden argument*/NULL);
		V_2 = (bool)1;
		goto IL_0069;
	}

IL_0065:
	{
		V_2 = (bool)0;
		goto IL_0069;
	}

IL_0069:
	{
		bool L_15 = V_2;
		return L_15;
	}
}
// System.Boolean UnityEngine.TextEditor::Delete()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_Delete_mA8F15F6B7EE373DBC15A399F9C33A0B078FED6C5 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	{
		bool L_0;
		L_0 = TextEditor_get_hasSelection_mB5CEC2D56136DDE95D62226438FA4620E027D41B(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		bool L_2;
		L_2 = TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D(__this, /*hidden argument*/NULL);
		V_1 = (bool)1;
		goto IL_0067;
	}

IL_0017:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		String_t* L_4;
		L_4 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_4);
		int32_t L_5;
		L_5 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_4, /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)L_3) < ((int32_t)L_5))? 1 : 0);
		bool L_6 = V_2;
		if (!L_6)
		{
			goto IL_0063;
		}
	}
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_7 = __this->get_m_Content_8();
		String_t* L_8;
		L_8 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_9;
		L_9 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_10;
		L_10 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_11;
		L_11 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_10, /*hidden argument*/NULL);
		int32_t L_12;
		L_12 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_8);
		String_t* L_13;
		L_13 = String_Remove_mA7DE3D6FE3344FD65108B33BD1DE8020D22ADAC0(L_8, L_9, ((int32_t)il2cpp_codegen_subtract((int32_t)L_11, (int32_t)L_12)), /*hidden argument*/NULL);
		NullCheck(L_7);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_7, L_13, /*hidden argument*/NULL);
		V_1 = (bool)1;
		goto IL_0067;
	}

IL_0063:
	{
		V_1 = (bool)0;
		goto IL_0067;
	}

IL_0067:
	{
		bool L_14 = V_1;
		return L_14;
	}
}
// System.Boolean UnityEngine.TextEditor::Backspace()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_Backspace_m28CC7790088027A79B2F06F4FB3BEB65F40352CC (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	{
		bool L_0;
		L_0 = TextEditor_get_hasSelection_mB5CEC2D56136DDE95D62226438FA4620E027D41B(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		bool L_2;
		L_2 = TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D(__this, /*hidden argument*/NULL);
		V_1 = (bool)1;
		goto IL_0075;
	}

IL_0017:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)L_3) > ((int32_t)0))? 1 : 0);
		bool L_4 = V_2;
		if (!L_4)
		{
			goto IL_0071;
		}
	}
	{
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_6;
		L_6 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_5, /*hidden argument*/NULL);
		V_3 = L_6;
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_7 = __this->get_m_Content_8();
		String_t* L_8;
		L_8 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_9 = V_3;
		int32_t L_10;
		L_10 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_11 = V_3;
		NullCheck(L_8);
		String_t* L_12;
		L_12 = String_Remove_mA7DE3D6FE3344FD65108B33BD1DE8020D22ADAC0(L_8, L_9, ((int32_t)il2cpp_codegen_subtract((int32_t)L_10, (int32_t)L_11)), /*hidden argument*/NULL);
		NullCheck(L_7);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_7, L_12, /*hidden argument*/NULL);
		int32_t L_13 = V_3;
		int32_t L_14 = L_13;
		V_4 = L_14;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_14, /*hidden argument*/NULL);
		int32_t L_15 = V_4;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_15, /*hidden argument*/NULL);
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		V_1 = (bool)1;
		goto IL_0075;
	}

IL_0071:
	{
		V_1 = (bool)0;
		goto IL_0075;
	}

IL_0075:
	{
		bool L_16 = V_1;
		return L_16;
	}
}
// System.Void UnityEngine.TextEditor::SelectAll()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectAll_m5EDB0E8D503B602A6A1AFF213E45766B57702598 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, 0, /*hidden argument*/NULL);
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_0, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_1, /*hidden argument*/NULL);
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectNone()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectNone_m204A64B599049EAF1EA39EA72560DD017E02B5CD (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_0, /*hidden argument*/NULL);
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.TextEditor::get_hasSelection()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_get_hasSelection_mB5CEC2D56136DDE95D62226438FA4620E027D41B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0015;
	}

IL_0015:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.TextEditor::DeleteSelection()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_00e3;
	}

IL_001a:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)L_3) < ((int32_t)L_4))? 1 : 0);
		bool L_5 = V_2;
		if (!L_5)
		{
			goto IL_0083;
		}
	}
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_6 = __this->get_m_Content_8();
		String_t* L_7;
		L_7 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_8;
		L_8 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_7);
		String_t* L_9;
		L_9 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_7, 0, L_8, /*hidden argument*/NULL);
		String_t* L_10;
		L_10 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_11;
		L_11 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		String_t* L_12;
		L_12 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_12);
		int32_t L_13;
		L_13 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_12, /*hidden argument*/NULL);
		int32_t L_14;
		L_14 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		NullCheck(L_10);
		String_t* L_15;
		L_15 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_10, L_11, ((int32_t)il2cpp_codegen_subtract((int32_t)L_13, (int32_t)L_14)), /*hidden argument*/NULL);
		String_t* L_16;
		L_16 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_9, L_15, /*hidden argument*/NULL);
		NullCheck(L_6);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_6, L_16, /*hidden argument*/NULL);
		int32_t L_17;
		L_17 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_17, /*hidden argument*/NULL);
		goto IL_00d8;
	}

IL_0083:
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_18 = __this->get_m_Content_8();
		String_t* L_19;
		L_19 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_20;
		L_20 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		NullCheck(L_19);
		String_t* L_21;
		L_21 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_19, 0, L_20, /*hidden argument*/NULL);
		String_t* L_22;
		L_22 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_23;
		L_23 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		String_t* L_24;
		L_24 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_24);
		int32_t L_25;
		L_25 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_24, /*hidden argument*/NULL);
		int32_t L_26;
		L_26 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_22);
		String_t* L_27;
		L_27 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_22, L_23, ((int32_t)il2cpp_codegen_subtract((int32_t)L_25, (int32_t)L_26)), /*hidden argument*/NULL);
		String_t* L_28;
		L_28 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_21, L_27, /*hidden argument*/NULL);
		NullCheck(L_18);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_18, L_28, /*hidden argument*/NULL);
		int32_t L_29;
		L_29 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_29, /*hidden argument*/NULL);
	}

IL_00d8:
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		V_1 = (bool)1;
		goto IL_00e3;
	}

IL_00e3:
	{
		bool L_30 = V_1;
		return L_30;
	}
}
// System.Void UnityEngine.TextEditor::ReplaceSelection(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ReplaceSelection_m13BC53A0C2F3B95346CAA422AB3FAD8E1BA0A44C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, String_t* ___replace0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		bool L_0;
		L_0 = TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D(__this, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_1 = __this->get_m_Content_8();
		String_t* L_2;
		L_2 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		String_t* L_4 = ___replace0;
		NullCheck(L_2);
		String_t* L_5;
		L_5 = String_Insert_m6F5335C84ACB178D4141772E1D7F2EB7811990EB(L_2, L_3, L_4, /*hidden argument*/NULL);
		NullCheck(L_1);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_1, L_5, /*hidden argument*/NULL);
		int32_t L_6;
		L_6 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		String_t* L_7 = ___replace0;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_7, /*hidden argument*/NULL);
		int32_t L_9 = ((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)L_8));
		V_0 = L_9;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_9, /*hidden argument*/NULL);
		int32_t L_10 = V_0;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_10, /*hidden argument*/NULL);
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::Insert(System.Char)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_Insert_m1C51BAF11E97287F7C78F8A9072A320AD0FD2ECE (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Il2CppChar ___c0, const RuntimeMethod* method)
{
	{
		String_t* L_0;
		L_0 = Char_ToString_mE0DE433463C56FD30A4F0A50539553B17147C2F8((Il2CppChar*)(&___c0), /*hidden argument*/NULL);
		TextEditor_ReplaceSelection_m13BC53A0C2F3B95346CAA422AB3FAD8E1BA0A44C(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveRight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveRight_m634E85509D846218EAD1894FF67F7D9B8A61F9CA (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0045;
		}
	}
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_3, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_4, /*hidden argument*/NULL);
		TextEditor_DetectFocusChange_mCD7E1E7B23D372E27A21C7A5012786C96EA962A0(__this, /*hidden argument*/NULL);
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_5, /*hidden argument*/NULL);
		goto IL_0075;
	}

IL_0045:
	{
		int32_t L_6;
		L_6 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_6) > ((int32_t)L_7))? 1 : 0);
		bool L_8 = V_1;
		if (!L_8)
		{
			goto IL_0067;
		}
	}
	{
		int32_t L_9;
		L_9 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_9, /*hidden argument*/NULL);
		goto IL_0074;
	}

IL_0067:
	{
		int32_t L_10;
		L_10 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_10, /*hidden argument*/NULL);
	}

IL_0074:
	{
	}

IL_0075:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveLeft()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveLeft_m5EF461B1A8E54955FA49CFE44A30B5D56D58D59B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	{
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0037;
		}
	}
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_3, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_4, /*hidden argument*/NULL);
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_5, /*hidden argument*/NULL);
		goto IL_0067;
	}

IL_0037:
	{
		int32_t L_6;
		L_6 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_6) > ((int32_t)L_7))? 1 : 0);
		bool L_8 = V_1;
		if (!L_8)
		{
			goto IL_0059;
		}
	}
	{
		int32_t L_9;
		L_9 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_9, /*hidden argument*/NULL);
		goto IL_0066;
	}

IL_0059:
	{
		int32_t L_10;
		L_10 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_10, /*hidden argument*/NULL);
	}

IL_0066:
	{
	}

IL_0067:
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveUp_m8FDBC52051A639319A86502D6056BC06BB78E66C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	bool V_2 = false;
	{
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) < ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0022;
		}
	}
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_3, /*hidden argument*/NULL);
		goto IL_002f;
	}

IL_0022:
	{
		int32_t L_4;
		L_4 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_4, /*hidden argument*/NULL);
	}

IL_002f:
	{
		TextEditor_GrabGraphicalCursorPos_m8B726D6524D664B81CC8D4EC0D11FFB51BDD236E(__this, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_5 = __this->get_address_of_graphicalCursorPos_13();
		float* L_6 = L_5->get_address_of_y_1();
		float* L_7 = L_6;
		float L_8 = *((float*)L_7);
		*((float*)L_7) = (float)((float)il2cpp_codegen_subtract((float)L_8, (float)(1.0f)));
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_9 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_10;
		L_10 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_11 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_12 = __this->get_graphicalCursorPos_13();
		NullCheck(L_9);
		int32_t L_13;
		L_13 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_9, L_10, L_11, L_12, /*hidden argument*/NULL);
		int32_t L_14 = L_13;
		V_1 = L_14;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_14, /*hidden argument*/NULL);
		int32_t L_15 = V_1;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_15, /*hidden argument*/NULL);
		int32_t L_16;
		L_16 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)((((int32_t)L_16) > ((int32_t)0))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_17 = V_2;
		if (!L_17)
		{
			goto IL_008f;
		}
	}
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
	}

IL_008f:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveDown()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveDown_m240765198B8A686EA80D018E8B71D435E2AFF89B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	bool V_2 = false;
	{
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) > ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0022;
		}
	}
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_3, /*hidden argument*/NULL);
		goto IL_002f;
	}

IL_0022:
	{
		int32_t L_4;
		L_4 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_4, /*hidden argument*/NULL);
	}

IL_002f:
	{
		TextEditor_GrabGraphicalCursorPos_m8B726D6524D664B81CC8D4EC0D11FFB51BDD236E(__this, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_5 = __this->get_address_of_graphicalCursorPos_13();
		float* L_6 = L_5->get_address_of_y_1();
		float* L_7 = L_6;
		float L_8 = *((float*)L_7);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_9 = __this->get_style_2();
		NullCheck(L_9);
		float L_10;
		L_10 = GUIStyle_get_lineHeight_m2A3FC65C1395A047D28E3CC20015D4871729CC71(L_9, /*hidden argument*/NULL);
		*((float*)L_7) = (float)((float)il2cpp_codegen_add((float)L_8, (float)((float)il2cpp_codegen_add((float)L_10, (float)(5.0f)))));
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_11 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_12;
		L_12 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_13 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_14 = __this->get_graphicalCursorPos_13();
		NullCheck(L_11);
		int32_t L_15;
		L_15 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_11, L_12, L_13, L_14, /*hidden argument*/NULL);
		int32_t L_16 = L_15;
		V_1 = L_16;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_16, /*hidden argument*/NULL);
		int32_t L_17 = V_1;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_17, /*hidden argument*/NULL);
		int32_t L_18;
		L_18 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		String_t* L_19;
		L_19 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_19);
		int32_t L_20;
		L_20 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_19, /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)L_18) == ((int32_t)L_20))? 1 : 0);
		bool L_21 = V_2;
		if (!L_21)
		{
			goto IL_00a2;
		}
	}
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
	}

IL_00a2:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveLineStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveLineStart_mF1B12EFAFA0CAC5F8A2B9F282E20CA3D36850E2E (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	bool V_2 = false;
	int32_t V_3 = 0;
	bool V_4 = false;
	int32_t G_B3_0 = 0;
	{
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		if ((((int32_t)L_0) < ((int32_t)L_1)))
		{
			goto IL_0017;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		goto IL_001d;
	}

IL_0017:
	{
		int32_t L_3;
		L_3 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_3;
	}

IL_001d:
	{
		V_0 = G_B3_0;
		int32_t L_4 = V_0;
		V_1 = L_4;
		goto IL_004d;
	}

IL_0022:
	{
		String_t* L_5;
		L_5 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_6 = V_1;
		NullCheck(L_5);
		Il2CppChar L_7;
		L_7 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_5, L_6, /*hidden argument*/NULL);
		V_2 = (bool)((((int32_t)L_7) == ((int32_t)((int32_t)10)))? 1 : 0);
		bool L_8 = V_2;
		if (!L_8)
		{
			goto IL_004d;
		}
	}
	{
		int32_t L_9 = V_1;
		int32_t L_10 = ((int32_t)il2cpp_codegen_add((int32_t)L_9, (int32_t)1));
		V_3 = L_10;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_10, /*hidden argument*/NULL);
		int32_t L_11 = V_3;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_11, /*hidden argument*/NULL);
		goto IL_006d;
	}

IL_004d:
	{
		int32_t L_12 = V_1;
		int32_t L_13 = L_12;
		V_1 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_13, (int32_t)1));
		V_4 = (bool)((!(((uint32_t)L_13) <= ((uint32_t)0)))? 1 : 0);
		bool L_14 = V_4;
		if (L_14)
		{
			goto IL_0022;
		}
	}
	{
		int32_t L_15 = 0;
		V_3 = L_15;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_15, /*hidden argument*/NULL);
		int32_t L_16 = V_3;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_16, /*hidden argument*/NULL);
	}

IL_006d:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveLineEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveLineEnd_m2DC31831A0D37F75BFA6CBB51FAFAD50CC966AF5 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	bool V_3 = false;
	int32_t V_4 = 0;
	bool V_5 = false;
	int32_t G_B3_0 = 0;
	{
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		if ((((int32_t)L_0) > ((int32_t)L_1)))
		{
			goto IL_0017;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		goto IL_001d;
	}

IL_0017:
	{
		int32_t L_3;
		L_3 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_3;
	}

IL_001d:
	{
		V_0 = G_B3_0;
		int32_t L_4 = V_0;
		V_1 = L_4;
		String_t* L_5;
		L_5 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_5);
		int32_t L_6;
		L_6 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_5, /*hidden argument*/NULL);
		V_2 = L_6;
		goto IL_005f;
	}

IL_002e:
	{
		String_t* L_7;
		L_7 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_8 = V_1;
		NullCheck(L_7);
		Il2CppChar L_9;
		L_9 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_7, L_8, /*hidden argument*/NULL);
		V_3 = (bool)((((int32_t)L_9) == ((int32_t)((int32_t)10)))? 1 : 0);
		bool L_10 = V_3;
		if (!L_10)
		{
			goto IL_005a;
		}
	}
	{
		int32_t L_11 = V_1;
		int32_t L_12 = L_11;
		V_4 = L_12;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_12, /*hidden argument*/NULL);
		int32_t L_13 = V_4;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_13, /*hidden argument*/NULL);
		goto IL_007d;
	}

IL_005a:
	{
		int32_t L_14 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_14, (int32_t)1));
	}

IL_005f:
	{
		int32_t L_15 = V_1;
		int32_t L_16 = V_2;
		V_5 = (bool)((((int32_t)L_15) < ((int32_t)L_16))? 1 : 0);
		bool L_17 = V_5;
		if (L_17)
		{
			goto IL_002e;
		}
	}
	{
		int32_t L_18 = V_2;
		int32_t L_19 = L_18;
		V_4 = L_19;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_19, /*hidden argument*/NULL);
		int32_t L_20 = V_4;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_20, /*hidden argument*/NULL);
	}

IL_007d:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveGraphicalLineStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveGraphicalLineStart_m74DA4B4DF3B68653DB4EC655D3092688F4B13506 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_1 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_2 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_1 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_2 = NULL;
	int32_t G_B3_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_1 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_2 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_3 = NULL;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B1_0 = __this;
		G_B1_1 = __this;
		G_B1_2 = __this;
		if ((((int32_t)L_0) < ((int32_t)L_1)))
		{
			G_B2_0 = __this;
			G_B2_1 = __this;
			G_B2_2 = __this;
			goto IL_001a;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		G_B3_3 = G_B1_2;
		goto IL_0020;
	}

IL_001a:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_3;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
		G_B3_3 = G_B2_2;
	}

IL_0020:
	{
		NullCheck(G_B3_1);
		int32_t L_4;
		L_4 = TextEditor_GetGraphicalLineStart_mEB3ECC40041B7A3A914DAD4F760C22E58ABAFDA9(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		int32_t L_5 = L_4;
		V_0 = L_5;
		NullCheck(G_B3_2);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(G_B3_2, L_5, /*hidden argument*/NULL);
		int32_t L_6 = V_0;
		NullCheck(G_B3_3);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(G_B3_3, L_6, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveGraphicalLineEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveGraphicalLineEnd_m577F85B3D593F7A004DE79B595E3357484F04655 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_1 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_2 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_1 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_2 = NULL;
	int32_t G_B3_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_1 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_2 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_3 = NULL;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B1_0 = __this;
		G_B1_1 = __this;
		G_B1_2 = __this;
		if ((((int32_t)L_0) > ((int32_t)L_1)))
		{
			G_B2_0 = __this;
			G_B2_1 = __this;
			G_B2_2 = __this;
			goto IL_001a;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		G_B3_1 = G_B1_0;
		G_B3_2 = G_B1_1;
		G_B3_3 = G_B1_2;
		goto IL_0020;
	}

IL_001a:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_3;
		G_B3_1 = G_B2_0;
		G_B3_2 = G_B2_1;
		G_B3_3 = G_B2_2;
	}

IL_0020:
	{
		NullCheck(G_B3_1);
		int32_t L_4;
		L_4 = TextEditor_GetGraphicalLineEnd_mD8BFB1EA8BA9BE75DA35E35706955BFF96FFE7F6(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		int32_t L_5 = L_4;
		V_0 = L_5;
		NullCheck(G_B3_2);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(G_B3_2, L_5, /*hidden argument*/NULL);
		int32_t L_6 = V_0;
		NullCheck(G_B3_3);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(G_B3_3, L_6, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveTextStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveTextStart_mE75FFE843DA63613826F3A90D74FDBA8BB0DAEFC (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = 0;
		V_0 = L_0;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_0, /*hidden argument*/NULL);
		int32_t L_1 = V_0;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveTextEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveTextEnd_m25A227643D792D7D14149DBE67161C6A7843B739 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_0, /*hidden argument*/NULL);
		int32_t L_2 = L_1;
		V_0 = L_2;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_2, /*hidden argument*/NULL);
		int32_t L_3 = V_0;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Int32 UnityEngine.TextEditor::IndexOfEndOfLine(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_IndexOfEndOfLine_m4A524577C1989B9404AA7301741AB7F6286CF0A9 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___startIndex0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t G_B3_0 = 0;
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_1 = ___startIndex0;
		NullCheck(L_0);
		int32_t L_2;
		L_2 = String_IndexOf_mAD7052CB25BA1D60A8F055AA89D09809F61233DB(L_0, ((int32_t)10), L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		int32_t L_3 = V_0;
		if ((!(((uint32_t)L_3) == ((uint32_t)(-1)))))
		{
			goto IL_0021;
		}
	}
	{
		String_t* L_4;
		L_4 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_4);
		int32_t L_5;
		L_5 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_4, /*hidden argument*/NULL);
		G_B3_0 = L_5;
		goto IL_0022;
	}

IL_0021:
	{
		int32_t L_6 = V_0;
		G_B3_0 = L_6;
	}

IL_0022:
	{
		V_1 = G_B3_0;
		goto IL_0025;
	}

IL_0025:
	{
		int32_t L_7 = V_1;
		return L_7;
	}
}
// System.Void UnityEngine.TextEditor::MoveParagraphForward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveParagraphForward_mD4466D00FDBEF6A3E9171F824531C65B495F3F55 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_1 = NULL;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B1_0 = __this;
		if ((((int32_t)L_0) > ((int32_t)L_1)))
		{
			G_B2_0 = __this;
			goto IL_0018;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		G_B3_1 = G_B1_0;
		goto IL_001e;
	}

IL_0018:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_3;
		G_B3_1 = G_B2_0;
	}

IL_001e:
	{
		NullCheck(G_B3_1);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		String_t* L_5;
		L_5 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_5);
		int32_t L_6;
		L_6 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_5, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_4) < ((int32_t)L_6))? 1 : 0);
		bool L_7 = V_0;
		if (!L_7)
		{
			goto IL_005c;
		}
	}
	{
		int32_t L_8;
		L_8 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_9;
		L_9 = TextEditor_IndexOfEndOfLine_m4A524577C1989B9404AA7301741AB7F6286CF0A9(__this, ((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1)), /*hidden argument*/NULL);
		int32_t L_10 = L_9;
		V_1 = L_10;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_10, /*hidden argument*/NULL);
		int32_t L_11 = V_1;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_11, /*hidden argument*/NULL);
	}

IL_005c:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveParagraphBackward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveParagraphBackward_m47BF508866B9B3506FC829E9BCB6461C282AE56F (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_1 = NULL;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B1_0 = __this;
		if ((((int32_t)L_0) < ((int32_t)L_1)))
		{
			G_B2_0 = __this;
			goto IL_0018;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		G_B3_1 = G_B1_0;
		goto IL_001e;
	}

IL_0018:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_3;
		G_B3_1 = G_B2_0;
	}

IL_001e:
	{
		NullCheck(G_B3_1);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_4) > ((int32_t)1))? 1 : 0);
		bool L_5 = V_0;
		if (!L_5)
		{
			goto IL_005d;
		}
	}
	{
		String_t* L_6;
		L_6 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_6);
		int32_t L_8;
		L_8 = String_LastIndexOf_m8DB57B87F39952A78925B5BF9BBB49B3EFA28155(L_6, ((int32_t)10), ((int32_t)il2cpp_codegen_subtract((int32_t)L_7, (int32_t)2)), /*hidden argument*/NULL);
		int32_t L_9 = ((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1));
		V_1 = L_9;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_9, /*hidden argument*/NULL);
		int32_t L_10 = V_1;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_10, /*hidden argument*/NULL);
		goto IL_006f;
	}

IL_005d:
	{
		int32_t L_11 = 0;
		V_1 = L_11;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_11, /*hidden argument*/NULL);
		int32_t L_12 = V_1;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_12, /*hidden argument*/NULL);
	}

IL_006f:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveCursorToPosition(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveCursorToPosition_m2AD0E35FE4C8882F0B704DFF22AB3474340CAD1F (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___cursorPosition0, const RuntimeMethod* method)
{
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0 = ___cursorPosition0;
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_1;
		L_1 = Event_get_current_m069E3E742E6CBC32C3BC958B85153E75B0192443(/*hidden argument*/NULL);
		NullCheck(L_1);
		bool L_2;
		L_2 = Event_get_shift_m7B2926A0EEEBF7D6FEB12B14FCC130A37F5E4697(L_1, /*hidden argument*/NULL);
		TextEditor_MoveCursorToPosition_Internal_m78070B113CA2AF5F9283EA1200BE889336AAB442(__this, L_0, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveCursorToPosition_Internal(UnityEngine.Vector2,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveCursorToPosition_Internal_m78070B113CA2AF5F9283EA1200BE889336AAB442 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___cursorPosition0, bool ___shift1, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1;
		L_1 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_2 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_3 = ___cursorPosition0;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4 = __this->get_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_5;
		L_5 = Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline(L_3, L_4, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_6;
		L_6 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_0, L_1, L_2, L_5, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_6, /*hidden argument*/NULL);
		bool L_7 = ___shift1;
		V_0 = (bool)((((int32_t)L_7) == ((int32_t)0))? 1 : 0);
		bool L_8 = V_0;
		if (!L_8)
		{
			goto IL_0042;
		}
	}
	{
		int32_t L_9;
		L_9 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_9, /*hidden argument*/NULL);
	}

IL_0042:
	{
		TextEditor_DetectFocusChange_mCD7E1E7B23D372E27A21C7A5012786C96EA962A0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectToPosition(UnityEngine.Vector2)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectToPosition_m41B423EAFC6268CC1C3A32489B71A41F953C10C0 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___cursorPosition0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	{
		bool L_0 = __this->get_m_MouseDragSelectsWholeWords_15();
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_003d;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_2 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_3;
		L_3 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_4 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_5 = ___cursorPosition0;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_6 = __this->get_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_7;
		L_7 = Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline(L_5, L_6, /*hidden argument*/NULL);
		NullCheck(L_2);
		int32_t L_8;
		L_8 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_2, L_3, L_4, L_7, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_8, /*hidden argument*/NULL);
		goto IL_01b8;
	}

IL_003d:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_9 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_10;
		L_10 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_11 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_12 = ___cursorPosition0;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_13 = __this->get_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_14;
		L_14 = Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline(L_12, L_13, /*hidden argument*/NULL);
		NullCheck(L_9);
		int32_t L_15;
		L_15 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_9, L_10, L_11, L_14, /*hidden argument*/NULL);
		V_1 = L_15;
		TextEditor_EnsureValidCodePointIndex_mB443C43308B056AE4E13DA6108E1DC1549CF7662(__this, (int32_t*)(&V_1), /*hidden argument*/NULL);
		int32_t* L_16 = __this->get_address_of_m_DblClickInitPos_16();
		TextEditor_EnsureValidCodePointIndex_mB443C43308B056AE4E13DA6108E1DC1549CF7662(__this, (int32_t*)L_16, /*hidden argument*/NULL);
		uint8_t L_17 = __this->get_m_DblClickSnap_17();
		V_2 = (bool)((((int32_t)L_17) == ((int32_t)0))? 1 : 0);
		bool L_18 = V_2;
		if (!L_18)
		{
			goto IL_00e5;
		}
	}
	{
		int32_t L_19 = V_1;
		int32_t L_20 = __this->get_m_DblClickInitPos_16();
		V_3 = (bool)((((int32_t)L_19) < ((int32_t)L_20))? 1 : 0);
		bool L_21 = V_3;
		if (!L_21)
		{
			goto IL_00ba;
		}
	}
	{
		int32_t L_22 = V_1;
		int32_t L_23;
		L_23 = TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89(__this, L_22, 1, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_23, /*hidden argument*/NULL);
		int32_t L_24 = __this->get_m_DblClickInitPos_16();
		int32_t L_25;
		L_25 = TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89(__this, L_24, 0, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_25, /*hidden argument*/NULL);
		goto IL_00df;
	}

IL_00ba:
	{
		int32_t L_26 = V_1;
		int32_t L_27;
		L_27 = TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89(__this, L_26, 0, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_27, /*hidden argument*/NULL);
		int32_t L_28 = __this->get_m_DblClickInitPos_16();
		int32_t L_29;
		L_29 = TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89(__this, L_28, 1, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_29, /*hidden argument*/NULL);
	}

IL_00df:
	{
		goto IL_01b7;
	}

IL_00e5:
	{
		int32_t L_30 = V_1;
		int32_t L_31 = __this->get_m_DblClickInitPos_16();
		V_4 = (bool)((((int32_t)L_30) < ((int32_t)L_31))? 1 : 0);
		bool L_32 = V_4;
		if (!L_32)
		{
			goto IL_0158;
		}
	}
	{
		int32_t L_33 = V_1;
		V_5 = (bool)((((int32_t)L_33) > ((int32_t)0))? 1 : 0);
		bool L_34 = V_5;
		if (!L_34)
		{
			goto IL_0121;
		}
	}
	{
		String_t* L_35;
		L_35 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_36 = V_1;
		int32_t L_37;
		L_37 = Mathf_Max_mAB2544BF70651EC36982F5F4EBD250AEE283335A(0, ((int32_t)il2cpp_codegen_subtract((int32_t)L_36, (int32_t)2)), /*hidden argument*/NULL);
		NullCheck(L_35);
		int32_t L_38;
		L_38 = String_LastIndexOf_m8DB57B87F39952A78925B5BF9BBB49B3EFA28155(L_35, ((int32_t)10), L_37, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, ((int32_t)il2cpp_codegen_add((int32_t)L_38, (int32_t)1)), /*hidden argument*/NULL);
		goto IL_0129;
	}

IL_0121:
	{
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, 0, /*hidden argument*/NULL);
	}

IL_0129:
	{
		String_t* L_39;
		L_39 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		String_t* L_40;
		L_40 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_40);
		int32_t L_41;
		L_41 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_40, /*hidden argument*/NULL);
		int32_t L_42 = __this->get_m_DblClickInitPos_16();
		int32_t L_43;
		L_43 = Mathf_Min_m8038BC2CE141C9AF3ECA2E31B88A9768423B1519(((int32_t)il2cpp_codegen_subtract((int32_t)L_41, (int32_t)1)), L_42, /*hidden argument*/NULL);
		NullCheck(L_39);
		int32_t L_44;
		L_44 = String_LastIndexOf_m8DB57B87F39952A78925B5BF9BBB49B3EFA28155(L_39, ((int32_t)10), L_43, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_44, /*hidden argument*/NULL);
		goto IL_01b6;
	}

IL_0158:
	{
		int32_t L_45 = V_1;
		String_t* L_46;
		L_46 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_46);
		int32_t L_47;
		L_47 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_46, /*hidden argument*/NULL);
		V_6 = (bool)((((int32_t)L_45) < ((int32_t)L_47))? 1 : 0);
		bool L_48 = V_6;
		if (!L_48)
		{
			goto IL_017f;
		}
	}
	{
		int32_t L_49 = V_1;
		int32_t L_50;
		L_50 = TextEditor_IndexOfEndOfLine_m4A524577C1989B9404AA7301741AB7F6286CF0A9(__this, L_49, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_50, /*hidden argument*/NULL);
		goto IL_0191;
	}

IL_017f:
	{
		String_t* L_51;
		L_51 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_51);
		int32_t L_52;
		L_52 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_51, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_52, /*hidden argument*/NULL);
	}

IL_0191:
	{
		String_t* L_53;
		L_53 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_54 = __this->get_m_DblClickInitPos_16();
		int32_t L_55;
		L_55 = Mathf_Max_mAB2544BF70651EC36982F5F4EBD250AEE283335A(0, ((int32_t)il2cpp_codegen_subtract((int32_t)L_54, (int32_t)2)), /*hidden argument*/NULL);
		NullCheck(L_53);
		int32_t L_56;
		L_56 = String_LastIndexOf_m8DB57B87F39952A78925B5BF9BBB49B3EFA28155(L_53, ((int32_t)10), L_55, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, ((int32_t)il2cpp_codegen_add((int32_t)L_56, (int32_t)1)), /*hidden argument*/NULL);
	}

IL_01b6:
	{
	}

IL_01b7:
	{
	}

IL_01b8:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectLeft()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectLeft_m518E7C7EBC18D6219ECC2454C043187986B973B1 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	{
		bool L_0 = __this->get_m_bJustSelected_18();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_003b;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_3;
		L_3 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_2) > ((int32_t)L_3))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_003b;
		}
	}
	{
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_2 = L_5;
		int32_t L_6;
		L_6 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_6, /*hidden argument*/NULL);
		int32_t L_7 = V_2;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_7, /*hidden argument*/NULL);
	}

IL_003b:
	{
		__this->set_m_bJustSelected_18((bool)0);
		int32_t L_8;
		L_8 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_9;
		L_9 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_8, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_9, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectRight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectRight_mC546506FCEC238ACA078ABFF78AF7D2194E42E48 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	{
		bool L_0 = __this->get_m_bJustSelected_18();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_003b;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_3;
		L_3 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_2) < ((int32_t)L_3))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_003b;
		}
	}
	{
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_2 = L_5;
		int32_t L_6;
		L_6 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_6, /*hidden argument*/NULL);
		int32_t L_7 = V_2;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_7, /*hidden argument*/NULL);
	}

IL_003b:
	{
		__this->set_m_bJustSelected_18((bool)0);
		int32_t L_8;
		L_8 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_9;
		L_9 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_8, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_9, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectUp()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectUp_m8295F3E145EA8791A259AD4655E2FE8199E53D2E (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		TextEditor_GrabGraphicalCursorPos_m8B726D6524D664B81CC8D4EC0D11FFB51BDD236E(__this, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_0 = __this->get_address_of_graphicalCursorPos_13();
		float* L_1 = L_0->get_address_of_y_1();
		float* L_2 = L_1;
		float L_3 = *((float*)L_2);
		*((float*)L_2) = (float)((float)il2cpp_codegen_subtract((float)L_3, (float)(1.0f)));
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_4 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_5;
		L_5 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_6 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_7 = __this->get_graphicalCursorPos_13();
		NullCheck(L_4);
		int32_t L_8;
		L_8 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_4, L_5, L_6, L_7, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_8, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectDown()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectDown_mB098A57D287374CA1A522982D54BCAAA2F38C6B7 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		TextEditor_GrabGraphicalCursorPos_m8B726D6524D664B81CC8D4EC0D11FFB51BDD236E(__this, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_0 = __this->get_address_of_graphicalCursorPos_13();
		float* L_1 = L_0->get_address_of_y_1();
		float* L_2 = L_1;
		float L_3 = *((float*)L_2);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_4 = __this->get_style_2();
		NullCheck(L_4);
		float L_5;
		L_5 = GUIStyle_get_lineHeight_m2A3FC65C1395A047D28E3CC20015D4871729CC71(L_4, /*hidden argument*/NULL);
		*((float*)L_2) = (float)((float)il2cpp_codegen_add((float)L_3, (float)((float)il2cpp_codegen_add((float)L_5, (float)(5.0f)))));
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_6 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_7;
		L_7 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_8 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_9 = __this->get_graphicalCursorPos_13();
		NullCheck(L_6);
		int32_t L_10;
		L_10 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_6, L_7, L_8, L_9, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_10, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectTextEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectTextEnd_m32FD60930FB84CD3C013FC067CC3FCB55973DA08 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_0, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectTextStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectTextStart_m25834E49ED3D557CEC0ECAA129B0916309C16CB7 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, 0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::MouseDragSelectsWholeWords(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MouseDragSelectsWholeWords_mE41D476CBDC08386C8ED86C7AC842926A49B467C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, bool ___on0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___on0;
		__this->set_m_MouseDragSelectsWholeWords_15(L_0);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		__this->set_m_DblClickInitPos_16(L_1);
		return;
	}
}
// System.Void UnityEngine.TextEditor::DblClickSnap(UnityEngine.TextEditor/DblClickSnapping)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_DblClickSnap_m5F79C658807D2E9C906FF0B5D3BD6907D381CAA1 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, uint8_t ___snapping0, const RuntimeMethod* method)
{
	{
		uint8_t L_0 = ___snapping0;
		__this->set_m_DblClickSnap_17(L_0);
		return;
	}
}
// System.Int32 UnityEngine.TextEditor::GetGraphicalLineStart(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_GetGraphicalLineStart_mEB3ECC40041B7A3A914DAD4F760C22E58ABAFDA9 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1;
		L_1 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_2 = __this->get_m_Content_8();
		int32_t L_3 = ___p0;
		NullCheck(L_0);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4;
		L_4 = GUIStyle_GetCursorPixelPosition_m8D4E34D8BFB582440B88F54643D095DF13DEA4F3(L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		float* L_5 = (&V_0)->get_address_of_y_1();
		float* L_6 = L_5;
		float L_7 = *((float*)L_6);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		float L_8;
		L_8 = GUIUtility_get_pixelsPerPoint_mB5D6900CC67E192C0189890FBB163E5ECD662579(/*hidden argument*/NULL);
		*((float*)L_6) = (float)((float)il2cpp_codegen_add((float)L_7, (float)((float)((float)(1.0f)/(float)L_8))));
		(&V_0)->set_x_0((0.0f));
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_9 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_10;
		L_10 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_11 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_12 = V_0;
		NullCheck(L_9);
		int32_t L_13;
		L_13 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_9, L_10, L_11, L_12, /*hidden argument*/NULL);
		V_1 = L_13;
		goto IL_0057;
	}

IL_0057:
	{
		int32_t L_14 = V_1;
		return L_14;
	}
}
// System.Int32 UnityEngine.TextEditor::GetGraphicalLineEnd(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_GetGraphicalLineEnd_mD8BFB1EA8BA9BE75DA35E35706955BFF96FFE7F6 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_0 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_1;
		L_1 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_2 = __this->get_m_Content_8();
		int32_t L_3 = ___p0;
		NullCheck(L_0);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4;
		L_4 = GUIStyle_GetCursorPixelPosition_m8D4E34D8BFB582440B88F54643D095DF13DEA4F3(L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		V_0 = L_4;
		float* L_5 = (&V_0)->get_address_of_y_1();
		float* L_6 = L_5;
		float L_7 = *((float*)L_6);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		float L_8;
		L_8 = GUIUtility_get_pixelsPerPoint_mB5D6900CC67E192C0189890FBB163E5ECD662579(/*hidden argument*/NULL);
		*((float*)L_6) = (float)((float)il2cpp_codegen_add((float)L_7, (float)((float)((float)(1.0f)/(float)L_8))));
		float* L_9 = (&V_0)->get_address_of_x_0();
		float* L_10 = L_9;
		float L_11 = *((float*)L_10);
		*((float*)L_10) = (float)((float)il2cpp_codegen_add((float)L_11, (float)(5000.0f)));
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_12 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_13;
		L_13 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_14 = __this->get_m_Content_8();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_15 = V_0;
		NullCheck(L_12);
		int32_t L_16;
		L_16 = GUIStyle_GetCursorStringIndex_mE2F7B7942106C1BE3CC846F13ECA7C1BFEE6FDAF(L_12, L_13, L_14, L_15, /*hidden argument*/NULL);
		V_1 = L_16;
		goto IL_005b;
	}

IL_005b:
	{
		int32_t L_17 = V_1;
		return L_17;
	}
}
// System.Int32 UnityEngine.TextEditor::FindNextSeperator(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindNextSeperator_mBAD0845CFF4A4B87121612F879E6C83B4E7D4CE2 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___startPos0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	int32_t G_B5_0 = 0;
	int32_t G_B11_0 = 0;
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0018;
	}

IL_000f:
	{
		int32_t L_2 = ___startPos0;
		int32_t L_3;
		L_3 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_2, /*hidden argument*/NULL);
		___startPos0 = L_3;
	}

IL_0018:
	{
		int32_t L_4 = ___startPos0;
		int32_t L_5 = V_0;
		if ((((int32_t)L_4) >= ((int32_t)L_5)))
		{
			goto IL_0028;
		}
	}
	{
		int32_t L_6 = ___startPos0;
		int32_t L_7;
		L_7 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_6, /*hidden argument*/NULL);
		G_B5_0 = ((!(((uint32_t)L_7) <= ((uint32_t)0)))? 1 : 0);
		goto IL_0029;
	}

IL_0028:
	{
		G_B5_0 = 0;
	}

IL_0029:
	{
		V_1 = (bool)G_B5_0;
		bool L_8 = V_1;
		if (L_8)
		{
			goto IL_000f;
		}
	}
	{
		goto IL_0038;
	}

IL_002f:
	{
		int32_t L_9 = ___startPos0;
		int32_t L_10;
		L_10 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_9, /*hidden argument*/NULL);
		___startPos0 = L_10;
	}

IL_0038:
	{
		int32_t L_11 = ___startPos0;
		int32_t L_12 = V_0;
		if ((((int32_t)L_11) >= ((int32_t)L_12)))
		{
			goto IL_0048;
		}
	}
	{
		int32_t L_13 = ___startPos0;
		int32_t L_14;
		L_14 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_13, /*hidden argument*/NULL);
		G_B11_0 = ((((int32_t)L_14) == ((int32_t)0))? 1 : 0);
		goto IL_0049;
	}

IL_0048:
	{
		G_B11_0 = 0;
	}

IL_0049:
	{
		V_2 = (bool)G_B11_0;
		bool L_15 = V_2;
		if (L_15)
		{
			goto IL_002f;
		}
	}
	{
		int32_t L_16 = ___startPos0;
		V_3 = L_16;
		goto IL_0051;
	}

IL_0051:
	{
		int32_t L_17 = V_3;
		return L_17;
	}
}
// System.Int32 UnityEngine.TextEditor::FindPrevSeperator(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindPrevSeperator_m559E369D55926E701F6A79644019A2500378754C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___startPos0, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	bool V_3 = false;
	bool V_4 = false;
	int32_t G_B5_0 = 0;
	int32_t G_B13_0 = 0;
	{
		int32_t L_0 = ___startPos0;
		int32_t L_1;
		L_1 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_0, /*hidden argument*/NULL);
		___startPos0 = L_1;
		goto IL_0015;
	}

IL_000c:
	{
		int32_t L_2 = ___startPos0;
		int32_t L_3;
		L_3 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_2, /*hidden argument*/NULL);
		___startPos0 = L_3;
	}

IL_0015:
	{
		int32_t L_4 = ___startPos0;
		if ((((int32_t)L_4) <= ((int32_t)0)))
		{
			goto IL_0025;
		}
	}
	{
		int32_t L_5 = ___startPos0;
		int32_t L_6;
		L_6 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_5, /*hidden argument*/NULL);
		G_B5_0 = ((!(((uint32_t)L_6) <= ((uint32_t)0)))? 1 : 0);
		goto IL_0026;
	}

IL_0025:
	{
		G_B5_0 = 0;
	}

IL_0026:
	{
		V_0 = (bool)G_B5_0;
		bool L_7 = V_0;
		if (L_7)
		{
			goto IL_000c;
		}
	}
	{
		int32_t L_8 = ___startPos0;
		V_1 = (bool)((((int32_t)L_8) == ((int32_t)0))? 1 : 0);
		bool L_9 = V_1;
		if (!L_9)
		{
			goto IL_0036;
		}
	}
	{
		V_2 = 0;
		goto IL_0074;
	}

IL_0036:
	{
		goto IL_0041;
	}

IL_0038:
	{
		int32_t L_10 = ___startPos0;
		int32_t L_11;
		L_11 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_10, /*hidden argument*/NULL);
		___startPos0 = L_11;
	}

IL_0041:
	{
		int32_t L_12 = ___startPos0;
		if ((((int32_t)L_12) <= ((int32_t)0)))
		{
			goto IL_0051;
		}
	}
	{
		int32_t L_13 = ___startPos0;
		int32_t L_14;
		L_14 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_13, /*hidden argument*/NULL);
		G_B13_0 = ((((int32_t)L_14) == ((int32_t)0))? 1 : 0);
		goto IL_0052;
	}

IL_0051:
	{
		G_B13_0 = 0;
	}

IL_0052:
	{
		V_3 = (bool)G_B13_0;
		bool L_15 = V_3;
		if (L_15)
		{
			goto IL_0038;
		}
	}
	{
		int32_t L_16 = ___startPos0;
		int32_t L_17;
		L_17 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_16, /*hidden argument*/NULL);
		V_4 = (bool)((((int32_t)L_17) == ((int32_t)0))? 1 : 0);
		bool L_18 = V_4;
		if (!L_18)
		{
			goto IL_006a;
		}
	}
	{
		int32_t L_19 = ___startPos0;
		V_2 = L_19;
		goto IL_0074;
	}

IL_006a:
	{
		int32_t L_20 = ___startPos0;
		int32_t L_21;
		L_21 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_20, /*hidden argument*/NULL);
		V_2 = L_21;
		goto IL_0074;
	}

IL_0074:
	{
		int32_t L_22 = V_2;
		return L_22;
	}
}
// System.Void UnityEngine.TextEditor::MoveWordRight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveWordRight_mFBBEA31EB6CD67F063ED3A6F2A343FBDAF08793C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_1 = NULL;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B1_0 = __this;
		if ((((int32_t)L_0) > ((int32_t)L_1)))
		{
			G_B2_0 = __this;
			goto IL_0018;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		G_B3_1 = G_B1_0;
		goto IL_001e;
	}

IL_0018:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_3;
		G_B3_1 = G_B2_0;
	}

IL_001e:
	{
		NullCheck(G_B3_1);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_5;
		L_5 = TextEditor_FindNextSeperator_mBAD0845CFF4A4B87121612F879E6C83B4E7D4CE2(__this, L_4, /*hidden argument*/NULL);
		int32_t L_6 = L_5;
		V_0 = L_6;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_6, /*hidden argument*/NULL);
		int32_t L_7 = V_0;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_7, /*hidden argument*/NULL);
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveToStartOfNextWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveToStartOfNextWord_mA96D839CF3EB07F5CDF19762D5D2E6B9C4BAD36D (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0027;
		}
	}
	{
		TextEditor_MoveRight_m634E85509D846218EAD1894FF67F7D9B8A61F9CA(__this, /*hidden argument*/NULL);
		goto IL_0044;
	}

IL_0027:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_FindStartOfNextWord_m59724B3A53A023031EDC1E852721F58B980ED36C(__this, L_3, /*hidden argument*/NULL);
		int32_t L_5 = L_4;
		V_1 = L_5;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_5, /*hidden argument*/NULL);
		int32_t L_6 = V_1;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_6, /*hidden argument*/NULL);
	}

IL_0044:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::MoveToEndOfPreviousWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveToEndOfPreviousWord_m51C33936E027A823E0F7500F4F1D2F8645823E40 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0027;
		}
	}
	{
		TextEditor_MoveLeft_m5EF461B1A8E54955FA49CFE44A30B5D56D58D59B(__this, /*hidden argument*/NULL);
		goto IL_0044;
	}

IL_0027:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_FindEndOfPreviousWord_mDFB854C75C7B3BDB5920E004C1F106500966A8BF(__this, L_3, /*hidden argument*/NULL);
		int32_t L_5 = L_4;
		V_1 = L_5;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_5, /*hidden argument*/NULL);
		int32_t L_6 = V_1;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_6, /*hidden argument*/NULL);
	}

IL_0044:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectToStartOfNextWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectToStartOfNextWord_mE7ADBC51D9E0A68D3375612C4193787B661F42A7 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_FindStartOfNextWord_m59724B3A53A023031EDC1E852721F58B980ED36C(__this, L_0, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectToEndOfPreviousWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectToEndOfPreviousWord_mCDC12CEF4FF8461F10C680730E7B98C3DD45CAD2 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_FindEndOfPreviousWord_mDFB854C75C7B3BDB5920E004C1F106500966A8BF(__this, L_0, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.TextEditor/CharacterType UnityEngine.TextEditor::ClassifyChar(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___index0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t V_1 = 0;
	bool V_2 = false;
	int32_t G_B5_0 = 0;
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_1 = ___index0;
		IL2CPP_RUNTIME_CLASS_INIT(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = Char_IsWhiteSpace_m23E361BAE86A2B42BEEA0F8362E033BACFEDB3FC(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0015;
		}
	}
	{
		V_1 = 3;
		goto IL_0042;
	}

IL_0015:
	{
		String_t* L_4;
		L_4 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_5 = ___index0;
		IL2CPP_RUNTIME_CLASS_INIT(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		bool L_6;
		L_6 = Char_IsLetterOrDigit_mD4066056FDE44A25DBC022E73FED10C34CF642D8(L_4, L_5, /*hidden argument*/NULL);
		if (L_6)
		{
			goto IL_0035;
		}
	}
	{
		String_t* L_7;
		L_7 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_8 = ___index0;
		NullCheck(L_7);
		Il2CppChar L_9;
		L_9 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_7, L_8, /*hidden argument*/NULL);
		G_B5_0 = ((((int32_t)L_9) == ((int32_t)((int32_t)39)))? 1 : 0);
		goto IL_0036;
	}

IL_0035:
	{
		G_B5_0 = 1;
	}

IL_0036:
	{
		V_2 = (bool)G_B5_0;
		bool L_10 = V_2;
		if (!L_10)
		{
			goto IL_003e;
		}
	}
	{
		V_1 = 0;
		goto IL_0042;
	}

IL_003e:
	{
		V_1 = 1;
		goto IL_0042;
	}

IL_0042:
	{
		int32_t L_11 = V_1;
		return L_11;
	}
}
// System.Int32 UnityEngine.TextEditor::FindStartOfNextWord(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindStartOfNextWord_m59724B3A53A023031EDC1E852721F58B980ED36C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	bool V_2 = false;
	int32_t V_3 = 0;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	int32_t G_B8_0 = 0;
	int32_t G_B13_0 = 0;
	int32_t G_B24_0 = 0;
	int32_t G_B29_0 = 0;
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		int32_t L_2 = ___p0;
		int32_t L_3 = V_0;
		V_2 = (bool)((((int32_t)L_2) == ((int32_t)L_3))? 1 : 0);
		bool L_4 = V_2;
		if (!L_4)
		{
			goto IL_001c;
		}
	}
	{
		int32_t L_5 = ___p0;
		V_3 = L_5;
		goto IL_0111;
	}

IL_001c:
	{
		int32_t L_6 = ___p0;
		int32_t L_7;
		L_7 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_6, /*hidden argument*/NULL);
		V_1 = L_7;
		int32_t L_8 = V_1;
		V_4 = (bool)((((int32_t)((((int32_t)L_8) == ((int32_t)3))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_9 = V_4;
		if (!L_9)
		{
			goto IL_0060;
		}
	}
	{
		int32_t L_10 = ___p0;
		int32_t L_11;
		L_11 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_10, /*hidden argument*/NULL);
		___p0 = L_11;
		goto IL_0046;
	}

IL_003d:
	{
		int32_t L_12 = ___p0;
		int32_t L_13;
		L_13 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_12, /*hidden argument*/NULL);
		___p0 = L_13;
	}

IL_0046:
	{
		int32_t L_14 = ___p0;
		int32_t L_15 = V_0;
		if ((((int32_t)L_14) >= ((int32_t)L_15)))
		{
			goto IL_0056;
		}
	}
	{
		int32_t L_16 = ___p0;
		int32_t L_17;
		L_17 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_16, /*hidden argument*/NULL);
		int32_t L_18 = V_1;
		G_B8_0 = ((((int32_t)L_17) == ((int32_t)L_18))? 1 : 0);
		goto IL_0057;
	}

IL_0056:
	{
		G_B8_0 = 0;
	}

IL_0057:
	{
		V_5 = (bool)G_B8_0;
		bool L_19 = V_5;
		if (L_19)
		{
			goto IL_003d;
		}
	}
	{
		goto IL_0095;
	}

IL_0060:
	{
		String_t* L_20;
		L_20 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_21 = ___p0;
		NullCheck(L_20);
		Il2CppChar L_22;
		L_22 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_20, L_21, /*hidden argument*/NULL);
		if ((((int32_t)L_22) == ((int32_t)((int32_t)9))))
		{
			goto IL_0083;
		}
	}
	{
		String_t* L_23;
		L_23 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_24 = ___p0;
		NullCheck(L_23);
		Il2CppChar L_25;
		L_25 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_23, L_24, /*hidden argument*/NULL);
		G_B13_0 = ((((int32_t)L_25) == ((int32_t)((int32_t)10)))? 1 : 0);
		goto IL_0084;
	}

IL_0083:
	{
		G_B13_0 = 1;
	}

IL_0084:
	{
		V_6 = (bool)G_B13_0;
		bool L_26 = V_6;
		if (!L_26)
		{
			goto IL_0094;
		}
	}
	{
		int32_t L_27 = ___p0;
		int32_t L_28;
		L_28 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_27, /*hidden argument*/NULL);
		V_3 = L_28;
		goto IL_0111;
	}

IL_0094:
	{
	}

IL_0095:
	{
		int32_t L_29 = ___p0;
		int32_t L_30 = V_0;
		V_7 = (bool)((((int32_t)L_29) == ((int32_t)L_30))? 1 : 0);
		bool L_31 = V_7;
		if (!L_31)
		{
			goto IL_00a3;
		}
	}
	{
		int32_t L_32 = ___p0;
		V_3 = L_32;
		goto IL_0111;
	}

IL_00a3:
	{
		String_t* L_33;
		L_33 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_34 = ___p0;
		NullCheck(L_33);
		Il2CppChar L_35;
		L_35 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_33, L_34, /*hidden argument*/NULL);
		V_8 = (bool)((((int32_t)L_35) == ((int32_t)((int32_t)32)))? 1 : 0);
		bool L_36 = V_8;
		if (!L_36)
		{
			goto IL_00df;
		}
	}
	{
		goto IL_00c5;
	}

IL_00bc:
	{
		int32_t L_37 = ___p0;
		int32_t L_38;
		L_38 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_37, /*hidden argument*/NULL);
		___p0 = L_38;
	}

IL_00c5:
	{
		int32_t L_39 = ___p0;
		int32_t L_40 = V_0;
		if ((((int32_t)L_39) >= ((int32_t)L_40)))
		{
			goto IL_00d5;
		}
	}
	{
		int32_t L_41 = ___p0;
		int32_t L_42;
		L_42 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_41, /*hidden argument*/NULL);
		G_B24_0 = ((((int32_t)L_42) == ((int32_t)3))? 1 : 0);
		goto IL_00d6;
	}

IL_00d5:
	{
		G_B24_0 = 0;
	}

IL_00d6:
	{
		V_9 = (bool)G_B24_0;
		bool L_43 = V_9;
		if (L_43)
		{
			goto IL_00bc;
		}
	}
	{
		goto IL_010d;
	}

IL_00df:
	{
		String_t* L_44;
		L_44 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_45 = ___p0;
		NullCheck(L_44);
		Il2CppChar L_46;
		L_46 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_44, L_45, /*hidden argument*/NULL);
		if ((((int32_t)L_46) == ((int32_t)((int32_t)9))))
		{
			goto IL_0101;
		}
	}
	{
		String_t* L_47;
		L_47 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_48 = ___p0;
		NullCheck(L_47);
		Il2CppChar L_49;
		L_49 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_47, L_48, /*hidden argument*/NULL);
		G_B29_0 = ((((int32_t)L_49) == ((int32_t)((int32_t)10)))? 1 : 0);
		goto IL_0102;
	}

IL_0101:
	{
		G_B29_0 = 1;
	}

IL_0102:
	{
		V_10 = (bool)G_B29_0;
		bool L_50 = V_10;
		if (!L_50)
		{
			goto IL_010d;
		}
	}
	{
		int32_t L_51 = ___p0;
		V_3 = L_51;
		goto IL_0111;
	}

IL_010d:
	{
		int32_t L_52 = ___p0;
		V_3 = L_52;
		goto IL_0111;
	}

IL_0111:
	{
		int32_t L_53 = V_3;
		return L_53;
	}
}
// System.Int32 UnityEngine.TextEditor::FindEndOfPreviousWord(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindEndOfPreviousWord_mDFB854C75C7B3BDB5920E004C1F106500966A8BF (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	int32_t G_B7_0 = 0;
	int32_t G_B14_0 = 0;
	{
		int32_t L_0 = ___p0;
		V_1 = (bool)((((int32_t)L_0) == ((int32_t)0))? 1 : 0);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_000d;
		}
	}
	{
		int32_t L_2 = ___p0;
		V_2 = L_2;
		goto IL_007f;
	}

IL_000d:
	{
		int32_t L_3 = ___p0;
		int32_t L_4;
		L_4 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_3, /*hidden argument*/NULL);
		___p0 = L_4;
		goto IL_0021;
	}

IL_0018:
	{
		int32_t L_5 = ___p0;
		int32_t L_6;
		L_6 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_5, /*hidden argument*/NULL);
		___p0 = L_6;
	}

IL_0021:
	{
		int32_t L_7 = ___p0;
		if ((((int32_t)L_7) <= ((int32_t)0)))
		{
			goto IL_0037;
		}
	}
	{
		String_t* L_8;
		L_8 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_9 = ___p0;
		NullCheck(L_8);
		Il2CppChar L_10;
		L_10 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_8, L_9, /*hidden argument*/NULL);
		G_B7_0 = ((((int32_t)L_10) == ((int32_t)((int32_t)32)))? 1 : 0);
		goto IL_0038;
	}

IL_0037:
	{
		G_B7_0 = 0;
	}

IL_0038:
	{
		V_3 = (bool)G_B7_0;
		bool L_11 = V_3;
		if (L_11)
		{
			goto IL_0018;
		}
	}
	{
		int32_t L_12 = ___p0;
		int32_t L_13;
		L_13 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_12, /*hidden argument*/NULL);
		V_0 = L_13;
		int32_t L_14 = V_0;
		V_4 = (bool)((((int32_t)((((int32_t)L_14) == ((int32_t)3))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_15 = V_4;
		if (!L_15)
		{
			goto IL_007b;
		}
	}
	{
		goto IL_005d;
	}

IL_0054:
	{
		int32_t L_16 = ___p0;
		int32_t L_17;
		L_17 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_16, /*hidden argument*/NULL);
		___p0 = L_17;
	}

IL_005d:
	{
		int32_t L_18 = ___p0;
		if ((((int32_t)L_18) <= ((int32_t)0)))
		{
			goto IL_0073;
		}
	}
	{
		int32_t L_19 = ___p0;
		int32_t L_20;
		L_20 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_19, /*hidden argument*/NULL);
		int32_t L_21;
		L_21 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_20, /*hidden argument*/NULL);
		int32_t L_22 = V_0;
		G_B14_0 = ((((int32_t)L_21) == ((int32_t)L_22))? 1 : 0);
		goto IL_0074;
	}

IL_0073:
	{
		G_B14_0 = 0;
	}

IL_0074:
	{
		V_5 = (bool)G_B14_0;
		bool L_23 = V_5;
		if (L_23)
		{
			goto IL_0054;
		}
	}
	{
	}

IL_007b:
	{
		int32_t L_24 = ___p0;
		V_2 = L_24;
		goto IL_007f;
	}

IL_007f:
	{
		int32_t L_25 = V_2;
		return L_25;
	}
}
// System.Void UnityEngine.TextEditor::MoveWordLeft()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MoveWordLeft_m76BE93FFEBB5E8A51EBD5BBCD4313681A2EC5638 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_1 = NULL;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B1_0 = __this;
		if ((((int32_t)L_0) < ((int32_t)L_1)))
		{
			G_B2_0 = __this;
			goto IL_0018;
		}
	}
	{
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		G_B3_1 = G_B1_0;
		goto IL_001e;
	}

IL_0018:
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B3_0 = L_3;
		G_B3_1 = G_B2_0;
	}

IL_001e:
	{
		NullCheck(G_B3_1);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_5;
		L_5 = TextEditor_FindPrevSeperator_m559E369D55926E701F6A79644019A2500378754C(__this, L_4, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_5, /*hidden argument*/NULL);
		int32_t L_6;
		L_6 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_6, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectWordRight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectWordRight_mB94EF5DBF2D792E2FD9871312E23B737705E9A16 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_0 = NULL;
	int32_t G_B4_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B4_1 = NULL;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_1) < ((int32_t)L_2))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0063;
		}
	}
	{
		int32_t L_4;
		L_4 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_4, /*hidden argument*/NULL);
		TextEditor_MoveWordRight_mFBBEA31EB6CD67F063ED3A6F2A343FBDAF08793C(__this, /*hidden argument*/NULL);
		int32_t L_5 = V_0;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_5, /*hidden argument*/NULL);
		int32_t L_6;
		L_6 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B2_0 = __this;
		if ((((int32_t)L_6) < ((int32_t)L_7)))
		{
			G_B3_0 = __this;
			goto IL_0055;
		}
	}
	{
		int32_t L_8;
		L_8 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B4_0 = L_8;
		G_B4_1 = G_B2_0;
		goto IL_005b;
	}

IL_0055:
	{
		int32_t L_9;
		L_9 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B4_0 = L_9;
		G_B4_1 = G_B3_0;
	}

IL_005b:
	{
		NullCheck(G_B4_1);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(G_B4_1, G_B4_0, /*hidden argument*/NULL);
		goto IL_007f;
	}

IL_0063:
	{
		int32_t L_10;
		L_10 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_10, /*hidden argument*/NULL);
		TextEditor_MoveWordRight_mFBBEA31EB6CD67F063ED3A6F2A343FBDAF08793C(__this, /*hidden argument*/NULL);
		int32_t L_11 = V_0;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_11, /*hidden argument*/NULL);
	}

IL_007f:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectWordLeft()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectWordLeft_m9ED17611443EF88F11E5BF1E304ED3E30A5402DB (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B3_0 = NULL;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B2_0 = NULL;
	int32_t G_B4_0 = 0;
	TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * G_B4_1 = NULL;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_1) > ((int32_t)L_2))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0063;
		}
	}
	{
		int32_t L_4;
		L_4 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_4, /*hidden argument*/NULL);
		TextEditor_MoveWordLeft_m76BE93FFEBB5E8A51EBD5BBCD4313681A2EC5638(__this, /*hidden argument*/NULL);
		int32_t L_5 = V_0;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_5, /*hidden argument*/NULL);
		int32_t L_6;
		L_6 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B2_0 = __this;
		if ((((int32_t)L_6) > ((int32_t)L_7)))
		{
			G_B3_0 = __this;
			goto IL_0055;
		}
	}
	{
		int32_t L_8;
		L_8 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B4_0 = L_8;
		G_B4_1 = G_B2_0;
		goto IL_005b;
	}

IL_0055:
	{
		int32_t L_9;
		L_9 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		G_B4_0 = L_9;
		G_B4_1 = G_B3_0;
	}

IL_005b:
	{
		NullCheck(G_B4_1);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(G_B4_1, G_B4_0, /*hidden argument*/NULL);
		goto IL_007f;
	}

IL_0063:
	{
		int32_t L_10;
		L_10 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_10, /*hidden argument*/NULL);
		TextEditor_MoveWordLeft_m76BE93FFEBB5E8A51EBD5BBCD4313681A2EC5638(__this, /*hidden argument*/NULL);
		int32_t L_11 = V_0;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_11, /*hidden argument*/NULL);
	}

IL_007f:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::ExpandSelectGraphicalLineStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ExpandSelectGraphicalLineStart_m2968C0AE82AAF86E5D19F1B55C830237A171329B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) < ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_002f;
		}
	}
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_GetGraphicalLineStart_mEB3ECC40041B7A3A914DAD4F760C22E58ABAFDA9(__this, L_3, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_4, /*hidden argument*/NULL);
		goto IL_0053;
	}

IL_002f:
	{
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_1 = L_5;
		int32_t L_6;
		L_6 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = TextEditor_GetGraphicalLineStart_mEB3ECC40041B7A3A914DAD4F760C22E58ABAFDA9(__this, L_6, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_7, /*hidden argument*/NULL);
		int32_t L_8 = V_1;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_8, /*hidden argument*/NULL);
	}

IL_0053:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::ExpandSelectGraphicalLineEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ExpandSelectGraphicalLineEnd_m92D7398F2E2B71A363F987FD9977B718B1CFBCDF (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) > ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_002f;
		}
	}
	{
		int32_t L_3;
		L_3 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_4;
		L_4 = TextEditor_GetGraphicalLineEnd_mD8BFB1EA8BA9BE75DA35E35706955BFF96FFE7F6(__this, L_3, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_4, /*hidden argument*/NULL);
		goto IL_0053;
	}

IL_002f:
	{
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_1 = L_5;
		int32_t L_6;
		L_6 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = TextEditor_GetGraphicalLineEnd_mD8BFB1EA8BA9BE75DA35E35706955BFF96FFE7F6(__this, L_6, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_7, /*hidden argument*/NULL);
		int32_t L_8 = V_1;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_8, /*hidden argument*/NULL);
	}

IL_0053:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectGraphicalLineStart()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectGraphicalLineStart_mB5F111592C097455D485724EA0EA691AF70D5393 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_GetGraphicalLineStart_mEB3ECC40041B7A3A914DAD4F760C22E58ABAFDA9(__this, L_0, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectGraphicalLineEnd()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectGraphicalLineEnd_mC6B13F73FDBEB9C38B137D894FFEB8DE3438536C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_GetGraphicalLineEnd_mD8BFB1EA8BA9BE75DA35E35706955BFF96FFE7F6(__this, L_0, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectParagraphForward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectParagraphForward_m1B0F5BFA5639B8E863BE18672FECA9471420FC00 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	int32_t G_B4_0 = 0;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) < ((int32_t)L_1))? 1 : 0);
		int32_t L_2;
		L_2 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		String_t* L_3;
		L_3 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		int32_t L_4;
		L_4 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_3, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_2) < ((int32_t)L_4))? 1 : 0);
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_006a;
		}
	}
	{
		int32_t L_6;
		L_6 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_7;
		L_7 = TextEditor_IndexOfEndOfLine_m4A524577C1989B9404AA7301741AB7F6286CF0A9(__this, ((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)1)), /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_7, /*hidden argument*/NULL);
		bool L_8 = V_0;
		if (!L_8)
		{
			goto IL_0057;
		}
	}
	{
		int32_t L_9;
		L_9 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_10;
		L_10 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B4_0 = ((((int32_t)L_9) > ((int32_t)L_10))? 1 : 0);
		goto IL_0058;
	}

IL_0057:
	{
		G_B4_0 = 0;
	}

IL_0058:
	{
		V_2 = (bool)G_B4_0;
		bool L_11 = V_2;
		if (!L_11)
		{
			goto IL_0069;
		}
	}
	{
		int32_t L_12;
		L_12 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_12, /*hidden argument*/NULL);
	}

IL_0069:
	{
	}

IL_006a:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectParagraphBackward()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectParagraphBackward_m2C719D95116BCFEACD7ED4D9443B8B067969AE6F (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	int32_t G_B4_0 = 0;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) > ((int32_t)L_1))? 1 : 0);
		int32_t L_2;
		L_2 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_2) > ((int32_t)1))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_006b;
		}
	}
	{
		String_t* L_4;
		L_4 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_4);
		int32_t L_6;
		L_6 = String_LastIndexOf_m8DB57B87F39952A78925B5BF9BBB49B3EFA28155(L_4, ((int32_t)10), ((int32_t)il2cpp_codegen_subtract((int32_t)L_5, (int32_t)2)), /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, ((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)1)), /*hidden argument*/NULL);
		bool L_7 = V_0;
		if (!L_7)
		{
			goto IL_0056;
		}
	}
	{
		int32_t L_8;
		L_8 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_9;
		L_9 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		G_B4_0 = ((((int32_t)L_8) < ((int32_t)L_9))? 1 : 0);
		goto IL_0057;
	}

IL_0056:
	{
		G_B4_0 = 0;
	}

IL_0057:
	{
		V_2 = (bool)G_B4_0;
		bool L_10 = V_2;
		if (!L_10)
		{
			goto IL_0068;
		}
	}
	{
		int32_t L_11;
		L_11 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_11, /*hidden argument*/NULL);
	}

IL_0068:
	{
		goto IL_007d;
	}

IL_006b:
	{
		int32_t L_12 = 0;
		V_3 = L_12;
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_12, /*hidden argument*/NULL);
		int32_t L_13 = V_3;
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_13, /*hidden argument*/NULL);
	}

IL_007d:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::SelectCurrentWord()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectCurrentWord_m40BF5B28CF563523AAD378239C21B0E08BC582BE (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_1) < ((int32_t)L_2))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_003c;
		}
	}
	{
		int32_t L_4 = V_0;
		int32_t L_5;
		L_5 = TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89(__this, L_4, 1, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_5, /*hidden argument*/NULL);
		int32_t L_6 = V_0;
		int32_t L_7;
		L_7 = TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89(__this, L_6, 0, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_7, /*hidden argument*/NULL);
		goto IL_005c;
	}

IL_003c:
	{
		int32_t L_8 = V_0;
		int32_t L_9;
		L_9 = TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89(__this, L_8, 0, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, L_9, /*hidden argument*/NULL);
		int32_t L_10 = V_0;
		int32_t L_11;
		L_11 = TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89(__this, L_10, 1, /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, L_11, /*hidden argument*/NULL);
	}

IL_005c:
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		__this->set_m_bJustSelected_18((bool)1);
		return;
	}
}
// System.Int32 UnityEngine.TextEditor::FindEndOfClassification(System.Int32,UnityEngine.TextEditor/Direction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_FindEndOfClassification_m2AA481A32EF0E114DE95EEF846E73FD99964CA89 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___p0, int32_t ___dir1, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	bool V_3 = false;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	int32_t G_B13_0 = 0;
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_0, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_1) == ((int32_t)0))? 1 : 0);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		V_2 = 0;
		goto IL_00d4;
	}

IL_001a:
	{
		int32_t L_3 = ___p0;
		String_t* L_4;
		L_4 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_4);
		int32_t L_5;
		L_5 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_4, /*hidden argument*/NULL);
		V_3 = (bool)((((int32_t)L_3) == ((int32_t)L_5))? 1 : 0);
		bool L_6 = V_3;
		if (!L_6)
		{
			goto IL_0035;
		}
	}
	{
		int32_t L_7 = ___p0;
		int32_t L_8;
		L_8 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_7, /*hidden argument*/NULL);
		___p0 = L_8;
	}

IL_0035:
	{
		int32_t L_9 = ___p0;
		int32_t L_10;
		L_10 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_9, /*hidden argument*/NULL);
		V_0 = L_10;
	}

IL_003d:
	{
		int32_t L_11 = ___dir1;
		V_5 = L_11;
		int32_t L_12 = V_5;
		V_4 = L_12;
		int32_t L_13 = V_4;
		if (!L_13)
		{
			goto IL_007e;
		}
	}
	{
		goto IL_004b;
	}

IL_004b:
	{
		int32_t L_14 = V_4;
		if ((((int32_t)L_14) == ((int32_t)1)))
		{
			goto IL_0052;
		}
	}
	{
		goto IL_00ab;
	}

IL_0052:
	{
		int32_t L_15 = ___p0;
		int32_t L_16;
		L_16 = TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C(__this, L_15, /*hidden argument*/NULL);
		___p0 = L_16;
		int32_t L_17 = ___p0;
		V_6 = (bool)((((int32_t)L_17) == ((int32_t)0))? 1 : 0);
		bool L_18 = V_6;
		if (!L_18)
		{
			goto IL_007c;
		}
	}
	{
		int32_t L_19;
		L_19 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, 0, /*hidden argument*/NULL);
		int32_t L_20 = V_0;
		if ((((int32_t)L_19) == ((int32_t)L_20)))
		{
			goto IL_0078;
		}
	}
	{
		int32_t L_21;
		L_21 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, 0, /*hidden argument*/NULL);
		G_B13_0 = L_21;
		goto IL_0079;
	}

IL_0078:
	{
		G_B13_0 = 0;
	}

IL_0079:
	{
		V_2 = G_B13_0;
		goto IL_00d4;
	}

IL_007c:
	{
		goto IL_00ab;
	}

IL_007e:
	{
		int32_t L_22 = ___p0;
		int32_t L_23;
		L_23 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_22, /*hidden argument*/NULL);
		___p0 = L_23;
		int32_t L_24 = ___p0;
		String_t* L_25;
		L_25 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_25);
		int32_t L_26;
		L_26 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_25, /*hidden argument*/NULL);
		V_7 = (bool)((((int32_t)L_24) == ((int32_t)L_26))? 1 : 0);
		bool L_27 = V_7;
		if (!L_27)
		{
			goto IL_00a9;
		}
	}
	{
		String_t* L_28;
		L_28 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_28);
		int32_t L_29;
		L_29 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_28, /*hidden argument*/NULL);
		V_2 = L_29;
		goto IL_00d4;
	}

IL_00a9:
	{
		goto IL_00ab;
	}

IL_00ab:
	{
		int32_t L_30 = ___p0;
		int32_t L_31;
		L_31 = TextEditor_ClassifyChar_m5F5AFD2489E3219B3005CB047A60F66C733023E3(__this, L_30, /*hidden argument*/NULL);
		int32_t L_32 = V_0;
		V_8 = (bool)((((int32_t)L_31) == ((int32_t)L_32))? 1 : 0);
		bool L_33 = V_8;
		if (L_33)
		{
			goto IL_003d;
		}
	}
	{
		int32_t L_34 = ___dir1;
		V_9 = (bool)((((int32_t)L_34) == ((int32_t)0))? 1 : 0);
		bool L_35 = V_9;
		if (!L_35)
		{
			goto IL_00ca;
		}
	}
	{
		int32_t L_36 = ___p0;
		V_2 = L_36;
		goto IL_00d4;
	}

IL_00ca:
	{
		int32_t L_37 = ___p0;
		int32_t L_38;
		L_38 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_37, /*hidden argument*/NULL);
		V_2 = L_38;
		goto IL_00d4;
	}

IL_00d4:
	{
		int32_t L_39 = V_2;
		return L_39;
	}
}
// System.Void UnityEngine.TextEditor::SelectCurrentParagraph()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SelectCurrentParagraph_m0B1D0D6F86FF6929131027BE649B5060656073F9 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	{
		TextEditor_ClearCursorPos_m76EBF2A64D2E24499FAFA0788CD221C0B24FA0CD(__this, /*hidden argument*/NULL);
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		int32_t L_2;
		L_2 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_3 = V_0;
		V_1 = (bool)((((int32_t)L_2) < ((int32_t)L_3))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_0038;
		}
	}
	{
		int32_t L_5;
		L_5 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_6;
		L_6 = TextEditor_IndexOfEndOfLine_m4A524577C1989B9404AA7301741AB7F6286CF0A9(__this, L_5, /*hidden argument*/NULL);
		TextEditor_set_cursorIndex_mE268E3EB5E125257ACADE44F75DEAE7FAE2CF481(__this, ((int32_t)il2cpp_codegen_add((int32_t)L_6, (int32_t)1)), /*hidden argument*/NULL);
	}

IL_0038:
	{
		int32_t L_7;
		L_7 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		V_2 = (bool)((!(((uint32_t)L_7) <= ((uint32_t)0)))? 1 : 0);
		bool L_8 = V_2;
		if (!L_8)
		{
			goto IL_0063;
		}
	}
	{
		String_t* L_9;
		L_9 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_10;
		L_10 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		NullCheck(L_9);
		int32_t L_11;
		L_11 = String_LastIndexOf_m8DB57B87F39952A78925B5BF9BBB49B3EFA28155(L_9, ((int32_t)10), ((int32_t)il2cpp_codegen_subtract((int32_t)L_10, (int32_t)1)), /*hidden argument*/NULL);
		TextEditor_set_selectIndex_mEF82F02E958CE673FBC882C6DC1F2C94A1DACC4F(__this, ((int32_t)il2cpp_codegen_add((int32_t)L_11, (int32_t)1)), /*hidden argument*/NULL);
	}

IL_0063:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::UpdateScrollOffsetIfNeeded(UnityEngine.Event)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_UpdateScrollOffsetIfNeeded_mDF549A082D63B9326C05FDB6FF5CF198C25AFAE8 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * ___evt0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t G_B3_0 = 0;
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_0 = ___evt0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Event_get_type_mA5010AB8C34B098E0783949046C708B9E1BA811D(L_0, /*hidden argument*/NULL);
		if ((((int32_t)L_1) == ((int32_t)7)))
		{
			goto IL_0018;
		}
	}
	{
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_2 = ___evt0;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = Event_get_type_mA5010AB8C34B098E0783949046C708B9E1BA811D(L_2, /*hidden argument*/NULL);
		G_B3_0 = ((((int32_t)((((int32_t)L_3) == ((int32_t)8))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_0019;
	}

IL_0018:
	{
		G_B3_0 = 0;
	}

IL_0019:
	{
		V_0 = (bool)G_B3_0;
		bool L_4 = V_0;
		if (!L_4)
		{
			goto IL_0026;
		}
	}
	{
		TextEditor_UpdateScrollOffset_mF6F74A14D6F9824B19A0D01BC9D0A7583CD2A5F4(__this, /*hidden argument*/NULL);
	}

IL_0026:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::UpdateScrollOffset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_UpdateScrollOffset_mF6F74A14D6F9824B19A0D01BC9D0A7583CD2A5F4 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_1;
	memset((&V_1), 0, sizeof(V_1));
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_2;
	memset((&V_2), 0, sizeof(V_2));
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_3;
	memset((&V_3), 0, sizeof(V_3));
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_4;
	memset((&V_4), 0, sizeof(V_4));
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	bool V_10 = false;
	bool V_11 = false;
	bool V_12 = false;
	bool V_13 = false;
	int32_t G_B19_0 = 0;
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * G_B23_0 = NULL;
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * G_B22_0 = NULL;
	float G_B24_0 = 0.0f;
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * G_B24_1 = NULL;
	{
		int32_t L_0;
		L_0 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_1 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_2;
		L_2 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		V_4 = L_2;
		float L_3;
		L_3 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_4;
		L_4 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		V_4 = L_4;
		float L_5;
		L_5 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_6;
		memset((&L_6), 0, sizeof(L_6));
		Rect__ctor_m12075526A02B55B680716A34AD5287B223122B70((&L_6), (0.0f), (0.0f), L_3, L_5, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_7 = __this->get_m_Content_8();
		int32_t L_8 = V_0;
		NullCheck(L_1);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_9;
		L_9 = GUIStyle_GetCursorPixelPosition_m8D4E34D8BFB582440B88F54643D095DF13DEA4F3(L_1, L_6, L_7, L_8, /*hidden argument*/NULL);
		__this->set_graphicalCursorPos_13(L_9);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_10 = __this->get_style_2();
		NullCheck(L_10);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_11;
		L_11 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_10, /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_12;
		L_12 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		NullCheck(L_11);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_13;
		L_13 = RectOffset_Remove_m49C8247D2CBB0080F7A09A37D3F1288403AE1BFB(L_11, L_12, /*hidden argument*/NULL);
		V_1 = L_13;
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_14 = __this->get_graphicalCursorPos_13();
		V_2 = L_14;
		float* L_15 = (&V_2)->get_address_of_x_0();
		float* L_16 = L_15;
		float L_17 = *((float*)L_16);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_18 = __this->get_style_2();
		NullCheck(L_18);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_19;
		L_19 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_18, /*hidden argument*/NULL);
		NullCheck(L_19);
		int32_t L_20;
		L_20 = RectOffset_get_left_m3B3066D09D8C9C94826258386B609CDBFFF11910(L_19, /*hidden argument*/NULL);
		*((float*)L_16) = (float)((float)il2cpp_codegen_subtract((float)L_17, (float)((float)((float)L_20))));
		float* L_21 = (&V_2)->get_address_of_y_1();
		float* L_22 = L_21;
		float L_23 = *((float*)L_22);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_24 = __this->get_style_2();
		NullCheck(L_24);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_25;
		L_25 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_24, /*hidden argument*/NULL);
		NullCheck(L_25);
		int32_t L_26;
		L_26 = RectOffset_get_top_m42000C7682185F03F23E7E0C3E8EC026FDBAB9D1(L_25, /*hidden argument*/NULL);
		*((float*)L_22) = (float)((float)il2cpp_codegen_subtract((float)L_23, (float)((float)((float)L_26))));
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_27 = __this->get_style_2();
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_28 = __this->get_m_Content_8();
		NullCheck(L_27);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_29;
		L_29 = GUIStyle_CalcSize_m3B4ADD2AF66EFF1A273C10C0F77741EAD96F3F2D(L_27, L_28, /*hidden argument*/NULL);
		float L_30 = L_29.get_x_0();
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_31 = __this->get_style_2();
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_32 = __this->get_m_Content_8();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_33;
		L_33 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		V_4 = L_33;
		float L_34;
		L_34 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		NullCheck(L_31);
		float L_35;
		L_35 = GUIStyle_CalcHeight_m120220D334AEC6B33F4767EA54FE78CEC09FBCC9(L_31, L_32, L_34, /*hidden argument*/NULL);
		Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline((Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 *)(&V_3), L_30, L_35, /*hidden argument*/NULL);
		float* L_36 = (&V_3)->get_address_of_x_0();
		float* L_37 = L_36;
		float L_38 = *((float*)L_37);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_39 = __this->get_style_2();
		NullCheck(L_39);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_40;
		L_40 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_39, /*hidden argument*/NULL);
		NullCheck(L_40);
		int32_t L_41;
		L_41 = RectOffset_get_left_m3B3066D09D8C9C94826258386B609CDBFFF11910(L_40, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_42 = __this->get_style_2();
		NullCheck(L_42);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_43;
		L_43 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_42, /*hidden argument*/NULL);
		NullCheck(L_43);
		int32_t L_44;
		L_44 = RectOffset_get_right_m889468939F3F926FE21F8E81E23C0342D45615C6(L_43, /*hidden argument*/NULL);
		*((float*)L_37) = (float)((float)il2cpp_codegen_subtract((float)L_38, (float)((float)((float)((int32_t)il2cpp_codegen_add((int32_t)L_41, (int32_t)L_44))))));
		float* L_45 = (&V_3)->get_address_of_y_1();
		float* L_46 = L_45;
		float L_47 = *((float*)L_46);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_48 = __this->get_style_2();
		NullCheck(L_48);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_49;
		L_49 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_48, /*hidden argument*/NULL);
		NullCheck(L_49);
		int32_t L_50;
		L_50 = RectOffset_get_top_m42000C7682185F03F23E7E0C3E8EC026FDBAB9D1(L_49, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_51 = __this->get_style_2();
		NullCheck(L_51);
		RectOffset_tE3A58467CD0749AD9D3E1271F9E315B38F39AE70 * L_52;
		L_52 = GUIStyle_get_padding_mB4566CD9B3C7911E6BF22AE1957F20ACC6E6CF17(L_51, /*hidden argument*/NULL);
		NullCheck(L_52);
		int32_t L_53;
		L_53 = RectOffset_get_bottom_mDDEBF1389FC1B8DCD9FC15DF91E51D264925C00D(L_52, /*hidden argument*/NULL);
		*((float*)L_46) = (float)((float)il2cpp_codegen_subtract((float)L_47, (float)((float)((float)((int32_t)il2cpp_codegen_add((int32_t)L_50, (int32_t)L_53))))));
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_54 = V_3;
		float L_55 = L_54.get_x_0();
		float L_56;
		L_56 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		V_5 = (bool)((((float)L_55) < ((float)L_56))? 1 : 0);
		bool L_57 = V_5;
		if (!L_57)
		{
			goto IL_0163;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_58 = __this->get_address_of_scrollOffset_7();
		L_58->set_x_0((0.0f));
		goto IL_01e1;
	}

IL_0163:
	{
		bool L_59 = __this->get_m_RevealCursor_12();
		V_6 = L_59;
		bool L_60 = V_6;
		if (!L_60)
		{
			goto IL_01e1;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_61 = V_2;
		float L_62 = L_61.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_63 = __this->get_address_of_scrollOffset_7();
		float L_64 = L_63->get_x_0();
		float L_65;
		L_65 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		V_7 = (bool)((((float)((float)il2cpp_codegen_add((float)L_62, (float)(1.0f)))) > ((float)((float)il2cpp_codegen_add((float)L_64, (float)L_65))))? 1 : 0);
		bool L_66 = V_7;
		if (!L_66)
		{
			goto IL_01b6;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_67 = __this->get_address_of_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_68 = V_2;
		float L_69 = L_68.get_x_0();
		float L_70;
		L_70 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		L_67->set_x_0(((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_subtract((float)L_69, (float)L_70)), (float)(1.0f))));
	}

IL_01b6:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_71 = V_2;
		float L_72 = L_71.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_73 = __this->get_address_of_scrollOffset_7();
		float L_74 = L_73->get_x_0();
		V_8 = (bool)((((float)L_72) < ((float)L_74))? 1 : 0);
		bool L_75 = V_8;
		if (!L_75)
		{
			goto IL_01e0;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_76 = __this->get_address_of_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_77 = V_2;
		float L_78 = L_77.get_x_0();
		L_76->set_x_0(L_78);
	}

IL_01e0:
	{
	}

IL_01e1:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_79 = V_3;
		float L_80 = L_79.get_y_1();
		float L_81;
		L_81 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		V_9 = (bool)((((float)L_80) < ((float)L_81))? 1 : 0);
		bool L_82 = V_9;
		if (!L_82)
		{
			goto IL_020d;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_83 = __this->get_address_of_scrollOffset_7();
		L_83->set_y_1((0.0f));
		goto IL_0297;
	}

IL_020d:
	{
		bool L_84 = __this->get_m_RevealCursor_12();
		V_10 = L_84;
		bool L_85 = V_10;
		if (!L_85)
		{
			goto IL_0297;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_86 = V_2;
		float L_87 = L_86.get_y_1();
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_88 = __this->get_style_2();
		NullCheck(L_88);
		float L_89;
		L_89 = GUIStyle_get_lineHeight_m2A3FC65C1395A047D28E3CC20015D4871729CC71(L_88, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_90 = __this->get_address_of_scrollOffset_7();
		float L_91 = L_90->get_y_1();
		float L_92;
		L_92 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		V_11 = (bool)((((float)((float)il2cpp_codegen_add((float)L_87, (float)L_89))) > ((float)((float)il2cpp_codegen_add((float)L_91, (float)L_92))))? 1 : 0);
		bool L_93 = V_11;
		if (!L_93)
		{
			goto IL_026c;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_94 = __this->get_address_of_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_95 = V_2;
		float L_96 = L_95.get_y_1();
		float L_97;
		L_97 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_98 = __this->get_style_2();
		NullCheck(L_98);
		float L_99;
		L_99 = GUIStyle_get_lineHeight_m2A3FC65C1395A047D28E3CC20015D4871729CC71(L_98, /*hidden argument*/NULL);
		L_94->set_y_1(((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_subtract((float)L_96, (float)L_97)), (float)L_99)));
	}

IL_026c:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_100 = V_2;
		float L_101 = L_100.get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_102 = __this->get_address_of_scrollOffset_7();
		float L_103 = L_102->get_y_1();
		V_12 = (bool)((((float)L_101) < ((float)L_103))? 1 : 0);
		bool L_104 = V_12;
		if (!L_104)
		{
			goto IL_0296;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_105 = __this->get_address_of_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_106 = V_2;
		float L_107 = L_106.get_y_1();
		L_105->set_y_1(L_107);
	}

IL_0296:
	{
	}

IL_0297:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_108 = __this->get_address_of_scrollOffset_7();
		float L_109 = L_108->get_y_1();
		if ((!(((float)L_109) > ((float)(0.0f)))))
		{
			goto IL_02c6;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_110 = V_3;
		float L_111 = L_110.get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_112 = __this->get_address_of_scrollOffset_7();
		float L_113 = L_112->get_y_1();
		float L_114;
		L_114 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		G_B19_0 = ((((float)((float)il2cpp_codegen_subtract((float)L_111, (float)L_113))) < ((float)L_114))? 1 : 0);
		goto IL_02c7;
	}

IL_02c6:
	{
		G_B19_0 = 0;
	}

IL_02c7:
	{
		V_13 = (bool)G_B19_0;
		bool L_115 = V_13;
		if (!L_115)
		{
			goto IL_02e6;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_116 = __this->get_address_of_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_117 = V_3;
		float L_118 = L_117.get_y_1();
		float L_119;
		L_119 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_1), /*hidden argument*/NULL);
		L_116->set_y_1(((float)il2cpp_codegen_subtract((float)L_118, (float)L_119)));
	}

IL_02e6:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_120 = __this->get_address_of_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_121 = __this->get_address_of_scrollOffset_7();
		float L_122 = L_121->get_y_1();
		G_B22_0 = L_120;
		if ((((float)L_122) < ((float)(0.0f))))
		{
			G_B23_0 = L_120;
			goto IL_030b;
		}
	}
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * L_123 = __this->get_address_of_scrollOffset_7();
		float L_124 = L_123->get_y_1();
		G_B24_0 = L_124;
		G_B24_1 = G_B22_0;
		goto IL_0310;
	}

IL_030b:
	{
		G_B24_0 = (0.0f);
		G_B24_1 = G_B23_0;
	}

IL_0310:
	{
		G_B24_1->set_y_1(G_B24_0);
		__this->set_m_RevealCursor_12((bool)0);
		return;
	}
}
// System.Void UnityEngine.TextEditor::DrawCursor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_DrawCursor_mD628D96A54F61FF7F96EDD357C8D669FDD26F5AA (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, String_t* ___newText0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	int32_t V_1 = 0;
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_2;
	memset((&V_2), 0, sizeof(V_2));
	bool V_3 = false;
	Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  V_4;
	memset((&V_4), 0, sizeof(V_4));
	bool V_5 = false;
	bool V_6 = false;
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_1 = L_1;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		String_t* L_2;
		L_2 = GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37(/*hidden argument*/NULL);
		NullCheck(L_2);
		int32_t L_3;
		L_3 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_2, /*hidden argument*/NULL);
		V_3 = (bool)((((int32_t)L_3) > ((int32_t)0))? 1 : 0);
		bool L_4 = V_3;
		if (!L_4)
		{
			goto IL_0060;
		}
	}
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_5 = __this->get_m_Content_8();
		String_t* L_6 = ___newText0;
		int32_t L_7;
		L_7 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_6);
		String_t* L_8;
		L_8 = String_Substring_m7A39A2AC0893AE940CF4CEC841326D56FFB9D86B(L_6, 0, L_7, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		String_t* L_9;
		L_9 = GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37(/*hidden argument*/NULL);
		String_t* L_10 = ___newText0;
		int32_t L_11;
		L_11 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		NullCheck(L_10);
		String_t* L_12;
		L_12 = String_Substring_mB6B87FD76552BBF6D4E2B9F07F857FE051DCE190(L_10, L_11, /*hidden argument*/NULL);
		String_t* L_13;
		L_13 = String_Concat_m89EAB4C6A96B0E5C3F87300D6BE78D386B9EFC44(L_8, L_9, L_12, /*hidden argument*/NULL);
		NullCheck(L_5);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_5, L_13, /*hidden argument*/NULL);
		int32_t L_14 = V_1;
		String_t* L_15;
		L_15 = GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37(/*hidden argument*/NULL);
		NullCheck(L_15);
		int32_t L_16;
		L_16 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_15, /*hidden argument*/NULL);
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_14, (int32_t)L_16));
		goto IL_006d;
	}

IL_0060:
	{
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_17 = __this->get_m_Content_8();
		String_t* L_18 = ___newText0;
		NullCheck(L_17);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_17, L_18, /*hidden argument*/NULL);
	}

IL_006d:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_19 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_20;
		L_20 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		V_4 = L_20;
		float L_21;
		L_21 = Rect_get_width_m4A0500D95CA84917787A8E90D26E66D49DFA90EF((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_22;
		L_22 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		V_4 = L_22;
		float L_23;
		L_23 = Rect_get_height_m42FEF31015A269E6E2B7E6F62E72E5BF6602302A((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_24;
		memset((&L_24), 0, sizeof(L_24));
		Rect__ctor_m12075526A02B55B680716A34AD5287B223122B70((&L_24), (0.0f), (0.0f), L_21, L_23, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_25 = __this->get_m_Content_8();
		int32_t L_26 = V_1;
		NullCheck(L_19);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_27;
		L_27 = GUIStyle_GetCursorPixelPosition_m8D4E34D8BFB582440B88F54643D095DF13DEA4F3(L_19, L_24, L_25, L_26, /*hidden argument*/NULL);
		__this->set_graphicalCursorPos_13(L_27);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_28 = __this->get_style_2();
		NullCheck(L_28);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_29;
		L_29 = GUIStyle_get_contentOffset_mEDC41FC0FA4CBBF8E271A2F620305D16E7E36A1B(L_28, /*hidden argument*/NULL);
		V_2 = L_29;
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_30 = __this->get_style_2();
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_31 = L_30;
		NullCheck(L_31);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_32;
		L_32 = GUIStyle_get_contentOffset_mEDC41FC0FA4CBBF8E271A2F620305D16E7E36A1B(L_31, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_33 = __this->get_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_34;
		L_34 = Vector2_op_Subtraction_m6E536A8C72FEAA37FF8D5E26E11D6E71EB59599A_inline(L_32, L_33, /*hidden argument*/NULL);
		NullCheck(L_31);
		GUIStyle_set_contentOffset_m2EAB45D5CFBA13DFE580BD6805353BDE59D5A56D(L_31, L_34, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_35 = __this->get_style_2();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_36 = __this->get_scrollOffset_7();
		NullCheck(L_35);
		GUIStyle_set_Internal_clipOffset_mB7E8F11C269ECEE9F8277150C261E0C0534DEFBF(L_35, L_36, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_37 = __this->get_graphicalCursorPos_13();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_38;
		L_38 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		V_4 = L_38;
		float L_39;
		L_39 = Rect_get_x_mA61220F6F26ECD6951B779FFA7CAD7ECE11D6987((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_40;
		L_40 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		V_4 = L_40;
		float L_41;
		L_41 = Rect_get_y_m4E1AAD20D167085FF4F9E9C86EF34689F5770A74((Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878 *)(&V_4), /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_42 = __this->get_style_2();
		NullCheck(L_42);
		float L_43;
		L_43 = GUIStyle_get_lineHeight_m2A3FC65C1395A047D28E3CC20015D4871729CC71(L_42, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_44;
		memset((&L_44), 0, sizeof(L_44));
		Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline((&L_44), L_39, ((float)il2cpp_codegen_add((float)L_41, (float)L_43)), /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_45;
		L_45 = Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline(L_37, L_44, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_46 = __this->get_scrollOffset_7();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_47;
		L_47 = Vector2_op_Subtraction_m6E536A8C72FEAA37FF8D5E26E11D6E71EB59599A_inline(L_45, L_46, /*hidden argument*/NULL);
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_48;
		L_48 = GUIClip_UnclipToWindow_m32CAC364845EF5893B53AA6C36E4FB1EF1405E21(L_47, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_set_compositionCursorPos_m895C29DAB9335BC53602E6D05D4FD622C37BFB8D(L_48, /*hidden argument*/NULL);
		String_t* L_49;
		L_49 = GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37(/*hidden argument*/NULL);
		NullCheck(L_49);
		int32_t L_50;
		L_50 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_49, /*hidden argument*/NULL);
		V_5 = (bool)((((int32_t)L_50) > ((int32_t)0))? 1 : 0);
		bool L_51 = V_5;
		if (!L_51)
		{
			goto IL_0188;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_52 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_53;
		L_53 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_54 = __this->get_m_Content_8();
		int32_t L_55 = __this->get_controlID_1();
		int32_t L_56;
		L_56 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_57;
		L_57 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		String_t* L_58;
		L_58 = GUIUtility_get_compositionString_m49A5608DCFEC04B7BEF7278392A0DBCBDBC2EA37(/*hidden argument*/NULL);
		NullCheck(L_58);
		int32_t L_59;
		L_59 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_58, /*hidden argument*/NULL);
		NullCheck(L_52);
		GUIStyle_DrawWithTextSelection_m6A144949389804F371C359F159C9E7DAA1BEDA9A(L_52, L_53, L_54, L_55, L_56, ((int32_t)il2cpp_codegen_add((int32_t)L_57, (int32_t)L_59)), (bool)1, /*hidden argument*/NULL);
		goto IL_01b2;
	}

IL_0188:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_60 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_61;
		L_61 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_62 = __this->get_m_Content_8();
		int32_t L_63 = __this->get_controlID_1();
		int32_t L_64;
		L_64 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		int32_t L_65;
		L_65 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		NullCheck(L_60);
		GUIStyle_DrawWithTextSelection_m0366243DD71AB06567B2E2AD777FC6E4585DA95F(L_60, L_61, L_62, L_63, L_64, L_65, /*hidden argument*/NULL);
	}

IL_01b2:
	{
		int32_t L_66 = __this->get_m_iAltCursorPos_19();
		V_6 = (bool)((((int32_t)((((int32_t)L_66) == ((int32_t)(-1)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		bool L_67 = V_6;
		if (!L_67)
		{
			goto IL_01e8;
		}
	}
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_68 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_69;
		L_69 = TextEditor_get_position_m4B5263E81A4B8D76672C5A262126AABED1A2957A(__this, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_70 = __this->get_m_Content_8();
		int32_t L_71 = __this->get_controlID_1();
		int32_t L_72 = __this->get_m_iAltCursorPos_19();
		NullCheck(L_68);
		GUIStyle_DrawCursor_m9E4A7C0BCD7E651B87B809B010DA75D2EE464676(L_68, L_69, L_70, L_71, L_72, /*hidden argument*/NULL);
	}

IL_01e8:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_73 = __this->get_style_2();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_74 = V_2;
		NullCheck(L_73);
		GUIStyle_set_contentOffset_m2EAB45D5CFBA13DFE580BD6805353BDE59D5A56D(L_73, L_74, /*hidden argument*/NULL);
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_75 = __this->get_style_2();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_76;
		L_76 = Vector2_get_zero_m621041B9DF5FAE86C1EF4CB28C224FEA089CB828(/*hidden argument*/NULL);
		NullCheck(L_75);
		GUIStyle_set_Internal_clipOffset_mB7E8F11C269ECEE9F8277150C261E0C0534DEFBF(L_75, L_76, /*hidden argument*/NULL);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_77 = __this->get_m_Content_8();
		String_t* L_78 = V_0;
		NullCheck(L_77);
		GUIContent_set_text_m1F36FE3E6B6C7058D94808769DE7C104FC85FAFB(L_77, L_78, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.TextEditor::PerformOperation(UnityEngine.TextEditor/TextEditOp,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_PerformOperation_mC8D7C480A86101BE510AB2ED83107110259C7821 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___operation0, bool ___textIsReadOnly1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TextEditOp_t6C6705A198EA7EFB55340BED1D58F28A1129A4DE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBD26781B489D74246E46948A3CF454478F1000C5);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	bool V_9 = false;
	{
		__this->set_m_RevealCursor_12((bool)1);
		int32_t L_0 = ___operation0;
		V_1 = L_0;
		int32_t L_1 = V_1;
		V_0 = L_1;
		int32_t L_2 = V_0;
		switch (L_2)
		{
			case 0:
			{
				goto IL_00cf;
			}
			case 1:
			{
				goto IL_00db;
			}
			case 2:
			{
				goto IL_00e7;
			}
			case 3:
			{
				goto IL_00f3;
			}
			case 4:
			{
				goto IL_00ff;
			}
			case 5:
			{
				goto IL_010b;
			}
			case 6:
			{
				goto IL_0147;
			}
			case 7:
			{
				goto IL_0153;
			}
			case 8:
			{
				goto IL_0309;
			}
			case 9:
			{
				goto IL_0309;
			}
			case 10:
			{
				goto IL_0177;
			}
			case 11:
			{
				goto IL_0183;
			}
			case 12:
			{
				goto IL_013b;
			}
			case 13:
			{
				goto IL_0117;
			}
			case 14:
			{
				goto IL_015f;
			}
			case 15:
			{
				goto IL_016b;
			}
			case 16:
			{
				goto IL_0123;
			}
			case 17:
			{
				goto IL_012f;
			}
			case 18:
			{
				goto IL_018f;
			}
			case 19:
			{
				goto IL_019b;
			}
			case 20:
			{
				goto IL_01a7;
			}
			case 21:
			{
				goto IL_01b3;
			}
			case 22:
			{
				goto IL_01ef;
			}
			case 23:
			{
				goto IL_01fb;
			}
			case 24:
			{
				goto IL_0309;
			}
			case 25:
			{
				goto IL_0309;
			}
			case 26:
			{
				goto IL_0207;
			}
			case 27:
			{
				goto IL_0213;
			}
			case 28:
			{
				goto IL_0237;
			}
			case 29:
			{
				goto IL_0243;
			}
			case 30:
			{
				goto IL_01cb;
			}
			case 31:
			{
				goto IL_01bf;
			}
			case 32:
			{
				goto IL_01d7;
			}
			case 33:
			{
				goto IL_01e3;
			}
			case 34:
			{
				goto IL_022b;
			}
			case 35:
			{
				goto IL_021f;
			}
			case 36:
			{
				goto IL_024f;
			}
			case 37:
			{
				goto IL_0267;
			}
			case 38:
			{
				goto IL_02cd;
			}
			case 39:
			{
				goto IL_02f5;
			}
			case 40:
			{
				goto IL_02e1;
			}
			case 41:
			{
				goto IL_0281;
			}
			case 42:
			{
				goto IL_029b;
			}
			case 43:
			{
				goto IL_02a7;
			}
			case 44:
			{
				goto IL_02bb;
			}
			case 45:
			{
				goto IL_02c4;
			}
		}
	}
	{
		goto IL_0309;
	}

IL_00cf:
	{
		TextEditor_MoveLeft_m5EF461B1A8E54955FA49CFE44A30B5D56D58D59B(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_00db:
	{
		TextEditor_MoveRight_m634E85509D846218EAD1894FF67F7D9B8A61F9CA(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_00e7:
	{
		TextEditor_MoveUp_m8FDBC52051A639319A86502D6056BC06BB78E66C(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_00f3:
	{
		TextEditor_MoveDown_m240765198B8A686EA80D018E8B71D435E2AFF89B(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_00ff:
	{
		TextEditor_MoveLineStart_mF1B12EFAFA0CAC5F8A2B9F282E20CA3D36850E2E(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_010b:
	{
		TextEditor_MoveLineEnd_m2DC31831A0D37F75BFA6CBB51FAFAD50CC966AF5(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0117:
	{
		TextEditor_MoveWordRight_mFBBEA31EB6CD67F063ED3A6F2A343FBDAF08793C(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0123:
	{
		TextEditor_MoveToStartOfNextWord_mA96D839CF3EB07F5CDF19762D5D2E6B9C4BAD36D(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_012f:
	{
		TextEditor_MoveToEndOfPreviousWord_m51C33936E027A823E0F7500F4F1D2F8645823E40(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_013b:
	{
		TextEditor_MoveWordLeft_m76BE93FFEBB5E8A51EBD5BBCD4313681A2EC5638(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0147:
	{
		TextEditor_MoveTextStart_mE75FFE843DA63613826F3A90D74FDBA8BB0DAEFC(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0153:
	{
		TextEditor_MoveTextEnd_m25A227643D792D7D14149DBE67161C6A7843B739(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_015f:
	{
		TextEditor_MoveParagraphForward_mD4466D00FDBEF6A3E9171F824531C65B495F3F55(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_016b:
	{
		TextEditor_MoveParagraphBackward_m47BF508866B9B3506FC829E9BCB6461C282AE56F(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0177:
	{
		TextEditor_MoveGraphicalLineStart_m74DA4B4DF3B68653DB4EC655D3092688F4B13506(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0183:
	{
		TextEditor_MoveGraphicalLineEnd_m577F85B3D593F7A004DE79B595E3357484F04655(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_018f:
	{
		TextEditor_SelectLeft_m518E7C7EBC18D6219ECC2454C043187986B973B1(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_019b:
	{
		TextEditor_SelectRight_mC546506FCEC238ACA078ABFF78AF7D2194E42E48(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_01a7:
	{
		TextEditor_SelectUp_m8295F3E145EA8791A259AD4655E2FE8199E53D2E(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_01b3:
	{
		TextEditor_SelectDown_mB098A57D287374CA1A522982D54BCAAA2F38C6B7(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_01bf:
	{
		TextEditor_SelectWordRight_mB94EF5DBF2D792E2FD9871312E23B737705E9A16(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_01cb:
	{
		TextEditor_SelectWordLeft_m9ED17611443EF88F11E5BF1E304ED3E30A5402DB(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_01d7:
	{
		TextEditor_SelectToEndOfPreviousWord_mCDC12CEF4FF8461F10C680730E7B98C3DD45CAD2(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_01e3:
	{
		TextEditor_SelectToStartOfNextWord_mE7ADBC51D9E0A68D3375612C4193787B661F42A7(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_01ef:
	{
		TextEditor_SelectTextStart_m25834E49ED3D557CEC0ECAA129B0916309C16CB7(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_01fb:
	{
		TextEditor_SelectTextEnd_m32FD60930FB84CD3C013FC067CC3FCB55973DA08(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0207:
	{
		TextEditor_ExpandSelectGraphicalLineStart_m2968C0AE82AAF86E5D19F1B55C830237A171329B(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0213:
	{
		TextEditor_ExpandSelectGraphicalLineEnd_m92D7398F2E2B71A363F987FD9977B718B1CFBCDF(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_021f:
	{
		TextEditor_SelectParagraphForward_m1B0F5BFA5639B8E863BE18672FECA9471420FC00(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_022b:
	{
		TextEditor_SelectParagraphBackward_m2C719D95116BCFEACD7ED4D9443B8B067969AE6F(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0237:
	{
		TextEditor_SelectGraphicalLineStart_mB5F111592C097455D485724EA0EA691AF70D5393(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0243:
	{
		TextEditor_SelectGraphicalLineEnd_mC6B13F73FDBEB9C38B137D894FFEB8DE3438536C(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_024f:
	{
		bool L_3 = ___textIsReadOnly1;
		V_2 = L_3;
		bool L_4 = V_2;
		if (!L_4)
		{
			goto IL_025b;
		}
	}
	{
		V_3 = (bool)0;
		goto IL_032c;
	}

IL_025b:
	{
		bool L_5;
		L_5 = TextEditor_Delete_mA8F15F6B7EE373DBC15A399F9C33A0B078FED6C5(__this, /*hidden argument*/NULL);
		V_3 = L_5;
		goto IL_032c;
	}

IL_0267:
	{
		bool L_6 = ___textIsReadOnly1;
		V_4 = L_6;
		bool L_7 = V_4;
		if (!L_7)
		{
			goto IL_0275;
		}
	}
	{
		V_3 = (bool)0;
		goto IL_032c;
	}

IL_0275:
	{
		bool L_8;
		L_8 = TextEditor_Backspace_m28CC7790088027A79B2F06F4FB3BEB65F40352CC(__this, /*hidden argument*/NULL);
		V_3 = L_8;
		goto IL_032c;
	}

IL_0281:
	{
		bool L_9 = ___textIsReadOnly1;
		V_5 = L_9;
		bool L_10 = V_5;
		if (!L_10)
		{
			goto IL_028f;
		}
	}
	{
		V_3 = (bool)0;
		goto IL_032c;
	}

IL_028f:
	{
		bool L_11;
		L_11 = TextEditor_Cut_m8C5226EB2736F62C4D1AA2E513878462AF69E233(__this, /*hidden argument*/NULL);
		V_3 = L_11;
		goto IL_032c;
	}

IL_029b:
	{
		TextEditor_Copy_mA09CAF84F8FFBAB60E0E5FE7EC68AAF1C814D11B(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_02a7:
	{
		bool L_12 = ___textIsReadOnly1;
		V_6 = L_12;
		bool L_13 = V_6;
		if (!L_13)
		{
			goto IL_02b2;
		}
	}
	{
		V_3 = (bool)0;
		goto IL_032c;
	}

IL_02b2:
	{
		bool L_14;
		L_14 = TextEditor_Paste_m734B97FD4F98ADE4815DDE92A530EBB01F0D4781(__this, /*hidden argument*/NULL);
		V_3 = L_14;
		goto IL_032c;
	}

IL_02bb:
	{
		TextEditor_SelectAll_m5EDB0E8D503B602A6A1AFF213E45766B57702598(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_02c4:
	{
		TextEditor_SelectNone_m204A64B599049EAF1EA39EA72560DD017E02B5CD(__this, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_02cd:
	{
		bool L_15 = ___textIsReadOnly1;
		V_7 = L_15;
		bool L_16 = V_7;
		if (!L_16)
		{
			goto IL_02d8;
		}
	}
	{
		V_3 = (bool)0;
		goto IL_032c;
	}

IL_02d8:
	{
		bool L_17;
		L_17 = TextEditor_DeleteWordBack_mD5B1AA3E2F877EB51D2472C1308B217CA2F54A06(__this, /*hidden argument*/NULL);
		V_3 = L_17;
		goto IL_032c;
	}

IL_02e1:
	{
		bool L_18 = ___textIsReadOnly1;
		V_8 = L_18;
		bool L_19 = V_8;
		if (!L_19)
		{
			goto IL_02ec;
		}
	}
	{
		V_3 = (bool)0;
		goto IL_032c;
	}

IL_02ec:
	{
		bool L_20;
		L_20 = TextEditor_DeleteLineBack_mD4520B7DDC6E616C2AF04DDFE23A4AC234437DE1(__this, /*hidden argument*/NULL);
		V_3 = L_20;
		goto IL_032c;
	}

IL_02f5:
	{
		bool L_21 = ___textIsReadOnly1;
		V_9 = L_21;
		bool L_22 = V_9;
		if (!L_22)
		{
			goto IL_0300;
		}
	}
	{
		V_3 = (bool)0;
		goto IL_032c;
	}

IL_0300:
	{
		bool L_23;
		L_23 = TextEditor_DeleteWordForward_m7BB52B567A1BBECD4663DF683FD2B996E58CF040(__this, /*hidden argument*/NULL);
		V_3 = L_23;
		goto IL_032c;
	}

IL_0309:
	{
		RuntimeObject * L_24 = Box(TextEditOp_t6C6705A198EA7EFB55340BED1D58F28A1129A4DE_il2cpp_TypeInfo_var, (&___operation0));
		NullCheck(L_24);
		String_t* L_25;
		L_25 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_24);
		___operation0 = *(int32_t*)UnBox(L_24);
		String_t* L_26;
		L_26 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(_stringLiteralBD26781B489D74246E46948A3CF454478F1000C5, L_25, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_26, /*hidden argument*/NULL);
		goto IL_0328;
	}

IL_0328:
	{
		V_3 = (bool)0;
		goto IL_032c;
	}

IL_032c:
	{
		bool L_27 = V_3;
		return L_27;
	}
}
// System.Void UnityEngine.TextEditor::SaveBackup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_SaveBackup_m94397DB7F5E9297C24AF2792CAA7574C26627722 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		String_t* L_0;
		L_0 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		__this->set_oldText_20(L_0);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		__this->set_oldPos_21(L_1);
		int32_t L_2;
		L_2 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		__this->set_oldSelectPos_22(L_2);
		return;
	}
}
// System.Boolean UnityEngine.TextEditor::Cut()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_Cut_m8C5226EB2736F62C4D1AA2E513878462AF69E233 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0 = __this->get_isPasswordField_5();
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000f;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_001f;
	}

IL_000f:
	{
		TextEditor_Copy_mA09CAF84F8FFBAB60E0E5FE7EC68AAF1C814D11B(__this, /*hidden argument*/NULL);
		bool L_2;
		L_2 = TextEditor_DeleteSelection_mE4E2C5419910E31D262D55F1FEA168E9072D9E6D(__this, /*hidden argument*/NULL);
		V_1 = L_2;
		goto IL_001f;
	}

IL_001f:
	{
		bool L_3 = V_1;
		return L_3;
	}
}
// System.Void UnityEngine.TextEditor::Copy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_Copy_mA09CAF84F8FFBAB60E0E5FE7EC68AAF1C814D11B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	{
		int32_t L_0;
		L_0 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_1;
		L_1 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0015;
		}
	}
	{
		goto IL_004c;
	}

IL_0015:
	{
		bool L_3 = __this->get_isPasswordField_5();
		V_2 = L_3;
		bool L_4 = V_2;
		if (!L_4)
		{
			goto IL_0021;
		}
	}
	{
		goto IL_004c;
	}

IL_0021:
	{
		GUIStyle_t29C59470ACD0A35C81EB0615653FD38C455A4726 * L_5 = __this->get_style_2();
		Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  L_6;
		L_6 = VirtFuncInvoker0< Rect_t7D9187DB6339DBA5741C09B6CCEF2F54F1966878  >::Invoke(4 /* UnityEngine.Rect UnityEngine.TextEditor::get_localPosition() */, __this);
		GUIContent_t39256993BF4A33F76E073488D6A2F13D678DF60E * L_7 = __this->get_m_Content_8();
		int32_t L_8;
		L_8 = TextEditor_get_selectIndex_mD6C80FE40149B0F0990868B3AC218479EEF3378C(__this, /*hidden argument*/NULL);
		int32_t L_9;
		L_9 = TextEditor_get_cursorIndex_m7D846379E1E16C578FF7206280FF522622A8061C(__this, /*hidden argument*/NULL);
		NullCheck(L_5);
		String_t* L_10;
		L_10 = GUIStyle_Internal_GetSelectedRenderedText_mBB9578BE373E64754DAC9496DC4E2422B9CF438B(L_5, L_6, L_7, L_8, L_9, /*hidden argument*/NULL);
		V_0 = L_10;
		String_t* L_11 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		GUIUtility_set_systemCopyBuffer_m1C5EAC38441C94C430AA13DF9942E1786CFCAC95(L_11, /*hidden argument*/NULL);
	}

IL_004c:
	{
		return;
	}
}
// System.String UnityEngine.TextEditor::ReplaceNewlinesWithSpaces(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* TextEditor_ReplaceNewlinesWithSpaces_mBFCCCAF5052A1435C1BCD13D7297D8E39BBE748E (String_t* ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		String_t* L_0 = ___value0;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = String_Replace_m98184150DC4E2FBDF13E723BF5B7353D9602AC4D(L_0, _stringLiteral4133EC0E83E4C69B6C0094B47BFD1408F0C8D4C5, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, /*hidden argument*/NULL);
		___value0 = L_1;
		String_t* L_2 = ___value0;
		NullCheck(L_2);
		String_t* L_3;
		L_3 = String_Replace_mD912844A1141FE8771F55255C4A8D29C80C47618(L_2, ((int32_t)10), ((int32_t)32), /*hidden argument*/NULL);
		___value0 = L_3;
		String_t* L_4 = ___value0;
		NullCheck(L_4);
		String_t* L_5;
		L_5 = String_Replace_mD912844A1141FE8771F55255C4A8D29C80C47618(L_4, ((int32_t)13), ((int32_t)32), /*hidden argument*/NULL);
		___value0 = L_5;
		String_t* L_6 = ___value0;
		V_0 = L_6;
		goto IL_002f;
	}

IL_002f:
	{
		String_t* L_7 = V_0;
		return L_7;
	}
}
// System.Boolean UnityEngine.TextEditor::Paste()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_Paste_m734B97FD4F98ADE4815DDE92A530EBB01F0D4781 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		String_t* L_0;
		L_0 = GUIUtility_get_systemCopyBuffer_m64CEF1CB0627F80D3CEEB458BA60DC9C1FA6141E(/*hidden argument*/NULL);
		V_0 = L_0;
		String_t* L_1 = V_0;
		bool L_2;
		L_2 = String_op_Inequality_mDDA2DDED3E7EF042987EB7180EE3E88105F0AAE2(L_1, _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, /*hidden argument*/NULL);
		V_1 = L_2;
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0037;
		}
	}
	{
		bool L_4 = __this->get_multiline_3();
		V_2 = (bool)((((int32_t)L_4) == ((int32_t)0))? 1 : 0);
		bool L_5 = V_2;
		if (!L_5)
		{
			goto IL_002b;
		}
	}
	{
		String_t* L_6 = V_0;
		String_t* L_7;
		L_7 = TextEditor_ReplaceNewlinesWithSpaces_mBFCCCAF5052A1435C1BCD13D7297D8E39BBE748E(L_6, /*hidden argument*/NULL);
		V_0 = L_7;
	}

IL_002b:
	{
		String_t* L_8 = V_0;
		TextEditor_ReplaceSelection_m13BC53A0C2F3B95346CAA422AB3FAD8E1BA0A44C(__this, L_8, /*hidden argument*/NULL);
		V_3 = (bool)1;
		goto IL_003b;
	}

IL_0037:
	{
		V_3 = (bool)0;
		goto IL_003b;
	}

IL_003b:
	{
		bool L_9 = V_3;
		return L_9;
	}
}
// System.Void UnityEngine.TextEditor::MapKey(System.String,UnityEngine.TextEditor/TextEditOp)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC (String_t* ___key0, int32_t ___action1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_set_Item_m60C46D4985DD498C33D75B842121DD35929CF75E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * L_0 = ((TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_StaticFields*)il2cpp_codegen_static_fields_for(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var))->get_s_Keyactions_23();
		String_t* L_1 = ___key0;
		Event_tED49F8EC5A2514F6E877E301B1AB7ABE4647253E * L_2;
		L_2 = Event_KeyboardEvent_mEDF3A001AE1C3D3AC324784C48A835738CF050B2(L_1, /*hidden argument*/NULL);
		int32_t L_3 = ___action1;
		NullCheck(L_0);
		Dictionary_2_set_Item_m60C46D4985DD498C33D75B842121DD35929CF75E(L_0, L_2, L_3, /*hidden argument*/Dictionary_2_set_Item_m60C46D4985DD498C33D75B842121DD35929CF75E_RuntimeMethod_var);
		return;
	}
}
// System.Void UnityEngine.TextEditor::InitKeyActions()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_InitKeyActions_m1073E6D1966025612EFAD14D6C17E590EA95359A (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2__ctor_m5F2CE464F67F4BDC4EB96CB769755BC675F66B18_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral01FE2A7BAF056155917298D04AE54B7D6AF27894);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral028D7034AFF25D3F9A597A5740013E38DA19D317);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0C9DC099BD4ECD04B696BF38FC02346103F2BC97);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0EF758EF1A06CA13329086B705ED12F47B9F606F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral13490EE15BBBA5055FAF4DFF43BAF8642B91BD99);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1388D2C9310312FF15F8415A0A8F63A7EA461B41);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral13CDCE216B91792515C4C64C7FCF5B265C404257);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral16D9C3063FF5F852963147CC12C5C552A5635796);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1B22F82E513C1BB368DFDBFDFB5FB8C1178CA305);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1CD31FFC09BB731749BFAAC984D2EED8E22C771A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1DF9EACB3FD057DF42A2784124CCE504D5860AEE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral28C03674125DA29250BA73594E6061FD480A3CB7);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral34D4B5F20FD7AA47487EDE07001792463720D1CE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral34F817DA4635C4C22DF5692FF51A196067483534);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral350D3BF828268FA677A331CBD1D40C9DB88673B3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3C3D97D6F00F5718D7008966DC8F93F9BB87FA51);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3D3A00B527F2755AFFF36C8F4AC13A53B5DC81D3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3D5EAEDD29399C149223964BD7513C036E82B631);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3E5BBD622A1890626F72D09F11351B02F04CD245);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4112C4C0070D77562F4AE5B1077F66F430FF4706);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral46AC1D8C432B177A3C113AD943EB74504A0EB337);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4718C7000562AF450B2C8B2BD4445A87205F7666);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5031FEC61137D005DAA2BFB10E1404651A112B0B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral5379C25D8F9979AD371949D2F3201B2D326743A4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral62F0048B45A8ADBC774F1B00911C9AA337E1F633);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6458183EA8D5BC1AAE58A98C841058647CCC35DE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral70E962167414B98D1C47009CF2298022592E68D4);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral710CEFF5A6D94EED332EF2BD41342B8B16B45293);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7174BAC93C4533B5ACC05736AE4D0C900491A008);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7AADBCDB9D121BC9D88064E31E08A3186262CAE6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7BBDDC94A571A1FD7D1FE9C4E3062CB11564D926);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7EF39B884F9764078345103493B55121123B1B46);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral81AB3FCA888E7214C2733551168655ABA4D3C65A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral837B17505EC06BAC0E4AA984798E9DB32B9C3CA0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8739227E8E687EF781DA0D923452C2686CFF10A2);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral877F6F7B61373508B1123D79708B393A9438C37E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9C1E874DA059D22C91283C44117D602D9080875A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9FA1FF57F726441CA277BF9734892B299CA3297B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9FF3949A2EE199375C9E51BB6ACCD0AE243AF691);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA2F4AC9DD8E1FAC5257E5F7BA5EE1C7C7E5F7AB1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA314507B0573B983FD845620D28E0B2F951D0E10);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA3955ADB3BC69ECFE423744D4F4F597294A20827);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA8D3437438DB8A85C804DDB64E69721F1D275030);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralAA7EB40717F1BA8A905AA5B827AAE03AF1D0F2D0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB1E5119D36EC43B340C0A0DDC99F1156546EA9DF);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB468B2E60F7F60260C2916459A799050DD6D3E85);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB8AA8F2673947FA36BB764D4DD75961AB3AF723E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB8E1418EB9CE2E5CF97CF8246D2776B9F1F33D67);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBA6BD45D12B4E9306BD7E0CC99FEC1DEEBFBBC58);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC581158E993200B82B36A56301468170ADB021DA);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD91C866DD696C68303515E6926044A10A2ADAB3C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDBA1945CFAADC613DE5170FD5C21296CCFF83615);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE18A20FF89E2801DE5C0C60E05D569C3513C48C7);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE3EADA58476D85227490ACED9D3239769769DFDC);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE7B9F94C0B0B71996D09AA98D20E270C100EAB93);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralEA74ED324D4EC0A66FF57C32244629F3B15A2CCF);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF1129AA23E2182336739DE1026CACAE451BACE5D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF222CF93E01C3342431C7952E8BD62DEFC619783);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF25B95468DAA02EC9AF41A21C2F589D8847BC27F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralFA1435556F32329DD212289449459CCFA67730F8);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * L_0 = ((TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_StaticFields*)il2cpp_codegen_static_fields_for(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var))->get_s_Keyactions_23();
		V_0 = (bool)((!(((RuntimeObject*)(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 *)L_0) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0012;
		}
	}
	{
		goto IL_03ec;
	}

IL_0012:
	{
		Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 * L_2 = (Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4 *)il2cpp_codegen_object_new(Dictionary_2_t56E51EEE113986EC168CDC77EA280DAB24101BF4_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m5F2CE464F67F4BDC4EB96CB769755BC675F66B18(L_2, /*hidden argument*/Dictionary_2__ctor_m5F2CE464F67F4BDC4EB96CB769755BC675F66B18_RuntimeMethod_var);
		((TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_StaticFields*)il2cpp_codegen_static_fields_for(TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B_il2cpp_TypeInfo_var))->set_s_Keyactions_23(L_2);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral8739227E8E687EF781DA0D923452C2686CFF10A2, 0, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralB1E5119D36EC43B340C0A0DDC99F1156546EA9DF, 1, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral1B22F82E513C1BB368DFDBFDFB5FB8C1178CA305, 2, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral5379C25D8F9979AD371949D2F3201B2D326743A4, 3, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral4718C7000562AF450B2C8B2BD4445A87205F7666, ((int32_t)18), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralB468B2E60F7F60260C2916459A799050DD6D3E85, ((int32_t)19), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralC581158E993200B82B36A56301468170ADB021DA, ((int32_t)20), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral46AC1D8C432B177A3C113AD943EB74504A0EB337, ((int32_t)21), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral028D7034AFF25D3F9A597A5740013E38DA19D317, ((int32_t)36), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral710CEFF5A6D94EED332EF2BD41342B8B16B45293, ((int32_t)37), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral350D3BF828268FA677A331CBD1D40C9DB88673B3, ((int32_t)37), /*hidden argument*/NULL);
		int32_t L_3;
		L_3 = SystemInfo_get_operatingSystemFamily_m797937E766B7FF87A5F1630263C49B814131DD95(/*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_3) == ((int32_t)1))? 1 : 0);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_0298;
		}
	}
	{
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral01FE2A7BAF056155917298D04AE54B7D6AF27894, ((int32_t)10), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral1DF9EACB3FD057DF42A2784124CCE504D5860AEE, ((int32_t)11), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral1CD31FFC09BB731749BFAAC984D2EED8E22C771A, ((int32_t)12), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral7AADBCDB9D121BC9D88064E31E08A3186262CAE6, ((int32_t)13), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralE18A20FF89E2801DE5C0C60E05D569C3513C48C7, ((int32_t)15), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral9FA1FF57F726441CA277BF9734892B299CA3297B, ((int32_t)14), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral9FF3949A2EE199375C9E51BB6ACCD0AE243AF691, ((int32_t)10), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral70E962167414B98D1C47009CF2298022592E68D4, ((int32_t)11), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral7174BAC93C4533B5ACC05736AE4D0C900491A008, 6, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralEA74ED324D4EC0A66FF57C32244629F3B15A2CCF, 7, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralF1129AA23E2182336739DE1026CACAE451BACE5D, ((int32_t)22), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral4112C4C0070D77562F4AE5B1077F66F430FF4706, ((int32_t)23), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralF222CF93E01C3342431C7952E8BD62DEFC619783, ((int32_t)26), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral7BBDDC94A571A1FD7D1FE9C4E3062CB11564D926, ((int32_t)27), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral7EF39B884F9764078345103493B55121123B1B46, ((int32_t)34), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralAA7EB40717F1BA8A905AA5B827AAE03AF1D0F2D0, ((int32_t)35), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralD91C866DD696C68303515E6926044A10A2ADAB3C, ((int32_t)30), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral6458183EA8D5BC1AAE58A98C841058647CCC35DE, ((int32_t)31), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral3D3A00B527F2755AFFF36C8F4AC13A53B5DC81D3, ((int32_t)34), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralE3EADA58476D85227490ACED9D3239769769DFDC, ((int32_t)35), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralA8D3437438DB8A85C804DDB64E69721F1D275030, ((int32_t)26), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralA3955ADB3BC69ECFE423744D4F4F597294A20827, ((int32_t)27), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral28C03674125DA29250BA73594E6061FD480A3CB7, ((int32_t)22), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral34D4B5F20FD7AA47487EDE07001792463720D1CE, ((int32_t)23), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralFA1435556F32329DD212289449459CCFA67730F8, ((int32_t)44), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral13CDCE216B91792515C4C64C7FCF5B265C404257, ((int32_t)41), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralB8AA8F2673947FA36BB764D4DD75961AB3AF723E, ((int32_t)42), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral62F0048B45A8ADBC774F1B00911C9AA337E1F633, ((int32_t)43), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral13490EE15BBBA5055FAF4DFF43BAF8642B91BD99, ((int32_t)36), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral34F817DA4635C4C22DF5692FF51A196067483534, ((int32_t)37), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral3C3D97D6F00F5718D7008966DC8F93F9BB87FA51, 0, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralB8E1418EB9CE2E5CF97CF8246D2776B9F1F33D67, 1, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral5031FEC61137D005DAA2BFB10E1404651A112B0B, 4, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral837B17505EC06BAC0E4AA984798E9DB32B9C3CA0, 5, /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral9C1E874DA059D22C91283C44117D602D9080875A, ((int32_t)39), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral877F6F7B61373508B1123D79708B393A9438C37E, ((int32_t)38), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral81AB3FCA888E7214C2733551168655ABA4D3C65A, ((int32_t)40), /*hidden argument*/NULL);
		goto IL_03ec;
	}

IL_0298:
	{
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral0C9DC099BD4ECD04B696BF38FC02346103F2BC97, ((int32_t)10), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralA2F4AC9DD8E1FAC5257E5F7BA5EE1C7C7E5F7AB1, ((int32_t)11), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral9FF3949A2EE199375C9E51BB6ACCD0AE243AF691, ((int32_t)12), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral70E962167414B98D1C47009CF2298022592E68D4, ((int32_t)13), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral7174BAC93C4533B5ACC05736AE4D0C900491A008, ((int32_t)15), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralEA74ED324D4EC0A66FF57C32244629F3B15A2CCF, ((int32_t)14), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral01FE2A7BAF056155917298D04AE54B7D6AF27894, ((int32_t)17), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral1DF9EACB3FD057DF42A2784124CCE504D5860AEE, ((int32_t)16), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralDBA1945CFAADC613DE5170FD5C21296CCFF83615, ((int32_t)15), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral3E5BBD622A1890626F72D09F11351B02F04CD245, ((int32_t)14), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralF222CF93E01C3342431C7952E8BD62DEFC619783, ((int32_t)32), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral7BBDDC94A571A1FD7D1FE9C4E3062CB11564D926, ((int32_t)33), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral7EF39B884F9764078345103493B55121123B1B46, ((int32_t)34), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralAA7EB40717F1BA8A905AA5B827AAE03AF1D0F2D0, ((int32_t)35), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralF1129AA23E2182336739DE1026CACAE451BACE5D, ((int32_t)28), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral4112C4C0070D77562F4AE5B1077F66F430FF4706, ((int32_t)29), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral3D5EAEDD29399C149223964BD7513C036E82B631, ((int32_t)39), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral1388D2C9310312FF15F8415A0A8F63A7EA461B41, ((int32_t)38), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral81AB3FCA888E7214C2733551168655ABA4D3C65A, ((int32_t)40), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral5031FEC61137D005DAA2BFB10E1404651A112B0B, ((int32_t)44), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralF25B95468DAA02EC9AF41A21C2F589D8847BC27F, ((int32_t)41), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralA314507B0573B983FD845620D28E0B2F951D0E10, ((int32_t)42), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralBA6BD45D12B4E9306BD7E0CC99FEC1DEEBFBBC58, ((int32_t)43), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral16D9C3063FF5F852963147CC12C5C552A5635796, ((int32_t)41), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteral0EF758EF1A06CA13329086B705ED12F47B9F606F, ((int32_t)42), /*hidden argument*/NULL);
		TextEditor_MapKey_m8EF99F16B324ABE126BB8450D963E6CCE2F14ACC(_stringLiteralE7B9F94C0B0B71996D09AA98D20E270C100EAB93, ((int32_t)43), /*hidden argument*/NULL);
	}

IL_03ec:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::DetectFocusChange()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_DetectFocusChange_mCD7E1E7B23D372E27A21C7A5012786C96EA962A0 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		VirtActionInvoker0::Invoke(5 /* System.Void UnityEngine.TextEditor::OnDetectFocusChange() */, __this);
		return;
	}
}
// System.Void UnityEngine.TextEditor::OnDetectFocusChange()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_OnDetectFocusChange_m838BA6AFE6EA2819C353205C69B0D9884E56C9E5 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	int32_t G_B3_0 = 0;
	int32_t G_B8_0 = 0;
	{
		bool L_0 = __this->get_m_HasFocus_6();
		if (!L_0)
		{
			goto IL_001b;
		}
	}
	{
		int32_t L_1 = __this->get_controlID_1();
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_2;
		L_2 = GUIUtility_get_keyboardControl_mC111A10FE792FA94E3859C5BC704D611F8768BE1(/*hidden argument*/NULL);
		G_B3_0 = ((((int32_t)((((int32_t)L_1) == ((int32_t)L_2))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_001c;
	}

IL_001b:
	{
		G_B3_0 = 0;
	}

IL_001c:
	{
		V_0 = (bool)G_B3_0;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0027;
		}
	}
	{
		TextEditor_OnLostFocus_m2E8FBC8864AA1B1EE5A56C13458618BE0EFFB783(__this, /*hidden argument*/NULL);
	}

IL_0027:
	{
		bool L_4 = __this->get_m_HasFocus_6();
		if (L_4)
		{
			goto IL_003e;
		}
	}
	{
		int32_t L_5 = __this->get_controlID_1();
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		int32_t L_6;
		L_6 = GUIUtility_get_keyboardControl_mC111A10FE792FA94E3859C5BC704D611F8768BE1(/*hidden argument*/NULL);
		G_B8_0 = ((((int32_t)L_5) == ((int32_t)L_6))? 1 : 0);
		goto IL_003f;
	}

IL_003e:
	{
		G_B8_0 = 0;
	}

IL_003f:
	{
		V_1 = (bool)G_B8_0;
		bool L_7 = V_1;
		if (!L_7)
		{
			goto IL_004a;
		}
	}
	{
		TextEditor_OnFocus_mA391FDD8A6F669C33F4F47AA6190DFA7E6C1DDE8(__this, /*hidden argument*/NULL);
	}

IL_004a:
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::OnCursorIndexChange()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_OnCursorIndexChange_mBCB374107D1C8683F3F5AA4E4CC9760898D9902B (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::OnSelectIndexChange()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_OnSelectIndexChange_m011581CACCDA51F92D064AA938B5FD23660585D4 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.TextEditor::ClampTextIndex(System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_ClampTextIndex_m7848BDECC588F52DE17768F3CE2DF23E7A728DC5 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t* ___index0, const RuntimeMethod* method)
{
	{
		int32_t* L_0 = ___index0;
		int32_t* L_1 = ___index0;
		int32_t L_2 = *((int32_t*)L_1);
		String_t* L_3;
		L_3 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		int32_t L_4;
		L_4 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_3, /*hidden argument*/NULL);
		int32_t L_5;
		L_5 = Mathf_Clamp_mAD0781EB7470594CD4482DD64A0D739E4E539C3C(L_2, 0, L_4, /*hidden argument*/NULL);
		*((int32_t*)L_0) = (int32_t)L_5;
		return;
	}
}
// System.Void UnityEngine.TextEditor::EnsureValidCodePointIndex(System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TextEditor_EnsureValidCodePointIndex_mB443C43308B056AE4E13DA6108E1DC1549CF7662 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t* ___index0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t* L_0 = ___index0;
		TextEditor_ClampTextIndex_m7848BDECC588F52DE17768F3CE2DF23E7A728DC5(__this, (int32_t*)L_0, /*hidden argument*/NULL);
		int32_t* L_1 = ___index0;
		int32_t L_2 = *((int32_t*)L_1);
		bool L_3;
		L_3 = TextEditor_IsValidCodePointIndex_mB0A21AB9662958E103DF439F8433D27796B46AF8(__this, L_2, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_3) == ((int32_t)0))? 1 : 0);
		bool L_4 = V_0;
		if (!L_4)
		{
			goto IL_0022;
		}
	}
	{
		int32_t* L_5 = ___index0;
		int32_t* L_6 = ___index0;
		int32_t L_7 = *((int32_t*)L_6);
		int32_t L_8;
		L_8 = TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951(__this, L_7, /*hidden argument*/NULL);
		*((int32_t*)L_5) = (int32_t)L_8;
	}

IL_0022:
	{
		return;
	}
}
// System.Boolean UnityEngine.TextEditor::IsValidCodePointIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TextEditor_IsValidCodePointIndex_mB0A21AB9662958E103DF439F8433D27796B46AF8 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___index0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	int32_t G_B3_0 = 0;
	int32_t G_B8_0 = 0;
	{
		int32_t L_0 = ___index0;
		if ((((int32_t)L_0) < ((int32_t)0)))
		{
			goto IL_0015;
		}
	}
	{
		int32_t L_1 = ___index0;
		String_t* L_2;
		L_2 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_2);
		int32_t L_3;
		L_3 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_2, /*hidden argument*/NULL);
		G_B3_0 = ((((int32_t)L_1) > ((int32_t)L_3))? 1 : 0);
		goto IL_0016;
	}

IL_0015:
	{
		G_B3_0 = 1;
	}

IL_0016:
	{
		V_0 = (bool)G_B3_0;
		bool L_4 = V_0;
		if (!L_4)
		{
			goto IL_001e;
		}
	}
	{
		V_1 = (bool)0;
		goto IL_0051;
	}

IL_001e:
	{
		int32_t L_5 = ___index0;
		if (!L_5)
		{
			goto IL_0031;
		}
	}
	{
		int32_t L_6 = ___index0;
		String_t* L_7;
		L_7 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_7, /*hidden argument*/NULL);
		G_B8_0 = ((((int32_t)L_6) == ((int32_t)L_8))? 1 : 0);
		goto IL_0032;
	}

IL_0031:
	{
		G_B8_0 = 1;
	}

IL_0032:
	{
		V_2 = (bool)G_B8_0;
		bool L_9 = V_2;
		if (!L_9)
		{
			goto IL_003a;
		}
	}
	{
		V_1 = (bool)1;
		goto IL_0051;
	}

IL_003a:
	{
		String_t* L_10;
		L_10 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_11 = ___index0;
		NullCheck(L_10);
		Il2CppChar L_12;
		L_12 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_10, L_11, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		bool L_13;
		L_13 = Char_IsLowSurrogate_m44FA7AA923FDA925E1D536F3DA0A7E1E049E936E(L_12, /*hidden argument*/NULL);
		V_1 = (bool)((((int32_t)L_13) == ((int32_t)0))? 1 : 0);
		goto IL_0051;
	}

IL_0051:
	{
		bool L_14 = V_1;
		return L_14;
	}
}
// System.Int32 UnityEngine.TextEditor::PreviousCodePointIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_PreviousCodePointIndex_m5F3FB1486A2221A2F7B70459094BC79E3A5B926C (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___index0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	int32_t G_B7_0 = 0;
	{
		int32_t L_0 = ___index0;
		V_0 = (bool)((((int32_t)L_0) > ((int32_t)0))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000e;
		}
	}
	{
		int32_t L_2 = ___index0;
		___index0 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_2, (int32_t)1));
	}

IL_000e:
	{
		goto IL_0015;
	}

IL_0010:
	{
		int32_t L_3 = ___index0;
		___index0 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_3, (int32_t)1));
	}

IL_0015:
	{
		int32_t L_4 = ___index0;
		if ((((int32_t)L_4) <= ((int32_t)0)))
		{
			goto IL_002c;
		}
	}
	{
		String_t* L_5;
		L_5 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_6 = ___index0;
		NullCheck(L_5);
		Il2CppChar L_7;
		L_7 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_5, L_6, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		bool L_8;
		L_8 = Char_IsLowSurrogate_m44FA7AA923FDA925E1D536F3DA0A7E1E049E936E(L_7, /*hidden argument*/NULL);
		G_B7_0 = ((int32_t)(L_8));
		goto IL_002d;
	}

IL_002c:
	{
		G_B7_0 = 0;
	}

IL_002d:
	{
		V_1 = (bool)G_B7_0;
		bool L_9 = V_1;
		if (L_9)
		{
			goto IL_0010;
		}
	}
	{
		int32_t L_10 = ___index0;
		V_2 = L_10;
		goto IL_0035;
	}

IL_0035:
	{
		int32_t L_11 = V_2;
		return L_11;
	}
}
// System.Int32 UnityEngine.TextEditor::NextCodePointIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TextEditor_NextCodePointIndex_m8D148585BD59DADBE637B142A7854145FA018951 (TextEditor_t0CE9EE816C020A910BA5D6DE544EF7F4FC3DBF4B * __this, int32_t ___index0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	int32_t G_B7_0 = 0;
	{
		int32_t L_0 = ___index0;
		String_t* L_1;
		L_1 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_1);
		int32_t L_2;
		L_2 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_1, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) < ((int32_t)L_2))? 1 : 0);
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0018;
		}
	}
	{
		int32_t L_4 = ___index0;
		___index0 = ((int32_t)il2cpp_codegen_add((int32_t)L_4, (int32_t)1));
	}

IL_0018:
	{
		goto IL_001f;
	}

IL_001a:
	{
		int32_t L_5 = ___index0;
		___index0 = ((int32_t)il2cpp_codegen_add((int32_t)L_5, (int32_t)1));
	}

IL_001f:
	{
		int32_t L_6 = ___index0;
		String_t* L_7;
		L_7 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m129FC0ADA02FECBED3C0B1A809AE84A5AEE1CF09_inline(L_7, /*hidden argument*/NULL);
		if ((((int32_t)L_6) >= ((int32_t)L_8)))
		{
			goto IL_0040;
		}
	}
	{
		String_t* L_9;
		L_9 = TextEditor_get_text_mE15B60D55F2AAF0D8635591E0DA94C9120911EA3(__this, /*hidden argument*/NULL);
		int32_t L_10 = ___index0;
		NullCheck(L_9);
		Il2CppChar L_11;
		L_11 = String_get_Chars_m9B1A5E4C8D70AA33A60F03735AF7B77AB9DBBA70(L_9, L_10, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Char_tFF60D8E7E89A20BE2294A003734341BD1DF43E14_il2cpp_TypeInfo_var);
		bool L_12;
		L_12 = Char_IsLowSurrogate_m44FA7AA923FDA925E1D536F3DA0A7E1E049E936E(L_11, /*hidden argument*/NULL);
		G_B7_0 = ((int32_t)(L_12));
		goto IL_0041;
	}

IL_0040:
	{
		G_B7_0 = 0;
	}

IL_0041:
	{
		V_1 = (bool)G_B7_0;
		bool L_13 = V_1;
		if (L_13)
		{
			goto IL_001a;
		}
	}
	{
		int32_t L_14 = ___index0;
		V_2 = L_14;
		goto IL_0049;
	}

IL_0049:
	{
		int32_t L_15 = V_2;
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
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_WindowFunction_tFA5DBAB811627D7B0946C4AAD398D4CC154C174D (WindowFunction_tFA5DBAB811627D7B0946C4AAD398D4CC154C174D * __this, int32_t ___id0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(int32_t);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc(___id0);

}
// System.Void UnityEngine.GUI/WindowFunction::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WindowFunction__ctor_mCC6005520B912B8BFFAECE3612EB3334FF681238 (WindowFunction_tFA5DBAB811627D7B0946C4AAD398D4CC154C174D * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.GUI/WindowFunction::Invoke(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WindowFunction_Invoke_mF7D36482F583383AF583ED812A4E2487C06C3748 (WindowFunction_tFA5DBAB811627D7B0946C4AAD398D4CC154C174D * __this, int32_t ___id0, const RuntimeMethod* method)
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
				typedef void (*FunctionPointerType) (int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___id0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___id0, targetMethod);
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
						GenericInterfaceActionInvoker1< int32_t >::Invoke(targetMethod, targetThis, ___id0);
					else
						GenericVirtActionInvoker1< int32_t >::Invoke(targetMethod, targetThis, ___id0);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___id0);
					else
						VirtActionInvoker1< int32_t >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___id0);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, int32_t, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___id0, targetMethod);
			}
		}
	}
}
// System.IAsyncResult UnityEngine.GUI/WindowFunction::BeginInvoke(System.Int32,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* WindowFunction_BeginInvoke_m9F57C6EAE29A60C2D896F2FC784280ECE8AAFBCA (WindowFunction_tFA5DBAB811627D7B0946C4AAD398D4CC154C174D * __this, int32_t ___id0, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[2] = {0};
	__d_args[0] = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &___id0);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);;
}
// System.Void UnityEngine.GUI/WindowFunction::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WindowFunction_EndInvoke_mD9651FD07B46D56BB2BC6B061FB90D3423A0B761 (WindowFunction_tFA5DBAB811627D7B0946C4AAD398D4CC154C174D * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
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
// System.Void UnityEngine.GUILayoutUtility/LayoutCache::set_id(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LayoutCache_set_id_mDA2ECE692716F3D21BCA5B5B5D718A779BC6D545 (LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CidU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.Void UnityEngine.GUILayoutUtility/LayoutCache::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LayoutCache__ctor_m31B20021AD6C02155826BB808C8E243B340022C4 (LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8 * __this, int32_t ___instanceID0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * L_0 = (GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 *)il2cpp_codegen_object_new(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9_il2cpp_TypeInfo_var);
		GUILayoutGroup__ctor_m633A8B9407554646DFD0BCAD5F9B39F34E7FCADA(L_0, /*hidden argument*/NULL);
		__this->set_topLevel_1(L_0);
		GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * L_1 = (GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C *)il2cpp_codegen_object_new(GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C_il2cpp_TypeInfo_var);
		GenericStack__ctor_m42B668E8F293EE21F529A2679AA110C0877605DD(L_1, /*hidden argument*/NULL);
		__this->set_layoutGroups_2(L_1);
		GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * L_2 = (GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 *)il2cpp_codegen_object_new(GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9_il2cpp_TypeInfo_var);
		GUILayoutGroup__ctor_m633A8B9407554646DFD0BCAD5F9B39F34E7FCADA(L_2, /*hidden argument*/NULL);
		__this->set_windows_3(L_2);
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_3 = ___instanceID0;
		LayoutCache_set_id_mDA2ECE692716F3D21BCA5B5B5D718A779BC6D545_inline(__this, L_3, /*hidden argument*/NULL);
		GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * L_4 = __this->get_layoutGroups_2();
		GUILayoutGroup_tEA8ADE069ADCDFAAE55323834EDC04B0888F10B9 * L_5 = __this->get_topLevel_1();
		NullCheck(L_4);
		VirtActionInvoker1< RuntimeObject * >::Invoke(20 /* System.Void System.Collections.Stack::Push(System.Object) */, L_4, L_5);
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
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E (SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void UnityEngine.GUISkin/SkinChangedDelegate::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SkinChangedDelegate__ctor_m89C35E9FE770168E1BEE3990E7E399891788B6DB (SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.GUISkin/SkinChangedDelegate::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SkinChangedDelegate_Invoke_m5FEBFA0F8E80B0745121ECB1C59C9E0EF595CC3C (SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E * __this, const RuntimeMethod* method)
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
// System.IAsyncResult UnityEngine.GUISkin/SkinChangedDelegate::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* SkinChangedDelegate_BeginInvoke_m7FA7715C6C7E8D8B0C95159E565520492D01F5CE (SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void UnityEngine.GUISkin/SkinChangedDelegate::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SkinChangedDelegate_EndInvoke_m6F5C8C0C660819B74CB8541173EA917C1A6A8D87 (SkinChangedDelegate_t8BECC691E2A259B07F4A51D8F1A639B83F055E1E * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GUIUtility_set_guiIsExiting_m13C69BE54D215B22CA7D1FE5192DD5ED744E0FCF_inline (bool ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		bool L_0 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var);
		((GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_StaticFields*)il2cpp_codegen_static_fields_for(GUIUtility_t0730B6D76CF479611ACF80504321B06286D12DE5_il2cpp_TypeInfo_var))->set_U3CguiIsExitingU3Ek__BackingField_8(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * GUI_get_scrollViewStates_mC0FF9F20045EB96D22254543B8C9A0643D54C4D4_inline (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		GenericStack_tFE88EF4FAC2E3519951AC2A4D721C3BD1A02E24C * L_0 = ((GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields*)il2cpp_codegen_static_fields_for(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var))->get_U3CscrollViewStatesU3Ek__BackingField_14();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Exception_t * Exception_get_InnerException_m10D85773B6B191C7D4E7D3C2954B84F9BB195218_inline (Exception_t * __this, const RuntimeMethod* method)
{
	{
		Exception_t * L_0 = __this->get__innerException_4();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GUI_set_scrollTroughSide_m0EAD9BD016B2E738A20356B3188A04A742AF60F2_inline (int32_t ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		((GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields*)il2cpp_codegen_static_fields_for(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var))->set_U3CscrollTroughSideU3Ek__BackingField_10(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void GUI_set_nextScrollStepTime_m3CF6DBBA4BE79B582AE4245AC02DED002C31E1DD_inline (DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		((GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields*)il2cpp_codegen_static_fields_for(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var))->set_U3CnextScrollStepTimeU3Ek__BackingField_11(L_0);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t GUI_get_scrollTroughSide_m7746453E541149AB66B07FCCE8209BE42F37684C_inline (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		int32_t L_0 = ((GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields*)il2cpp_codegen_static_fields_for(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var))->get_U3CscrollTroughSideU3Ek__BackingField_10();
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  GUI_get_nextScrollStepTime_mD6A92E2DB68073C2B57EEFBDCB72D518B70E9065_inline (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var);
		DateTime_tEAF2CD16E071DF5441F40822E4CFE880E5245405  L_0 = ((GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_StaticFields*)il2cpp_codegen_static_fields_for(GUI_tBCBBE29117D8093644C6E72B1CE3FB65C2CDCCC1_il2cpp_TypeInfo_var))->get_U3CnextScrollStepTimeU3Ek__BackingField_11();
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_op_Addition_m5EACC2AEA80FEE29F380397CF1F4B11D04BE71CC_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___a0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___b1, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0 = ___a0;
		float L_1 = L_0.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2 = ___b1;
		float L_3 = L_2.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4 = ___a0;
		float L_5 = L_4.get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_6 = ___b1;
		float L_7 = L_6.get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline((&L_8), ((float)il2cpp_codegen_add((float)L_1, (float)L_3)), ((float)il2cpp_codegen_add((float)L_5, (float)L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0023;
	}

IL_0023:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_9 = V_0;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9 * __this, float ___x0, float ___y1, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_0(L_0);
		float L_1 = ___y1;
		__this->set_y_1(L_1);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  Vector2_op_Subtraction_m6E536A8C72FEAA37FF8D5E26E11D6E71EB59599A_inline (Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___a0, Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  ___b1, const RuntimeMethod* method)
{
	Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_0 = ___a0;
		float L_1 = L_0.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_2 = ___b1;
		float L_3 = L_2.get_x_0();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_4 = ___a0;
		float L_5 = L_4.get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_6 = ___b1;
		float L_7 = L_6.get_y_1();
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_8;
		memset((&L_8), 0, sizeof(L_8));
		Vector2__ctor_m9F1F2D5EB5D1FF7091BB527AC8A72CBB309D115E_inline((&L_8), ((float)il2cpp_codegen_subtract((float)L_1, (float)L_3)), ((float)il2cpp_codegen_subtract((float)L_5, (float)L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0023;
	}

IL_0023:
	{
		Vector2_tBB32F2736AEC229A7BFBCE18197EC0F6AC7EC2D9  L_9 = V_0;
		return L_9;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void LayoutCache_set_id_mDA2ECE692716F3D21BCA5B5B5D718A779BC6D545_inline (LayoutCache_t4C0528EE626F95B53EFE2AB59B8D56CB70BBDFE8 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_U3CidU3Ek__BackingField_0(L_0);
		return;
	}
}
