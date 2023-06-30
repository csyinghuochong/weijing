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
struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
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
template <typename R, typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7, typename T8, typename T9, typename T10, typename T11, typename T12>
struct VirtFuncInvoker12
{
	typedef R (*Func)(void*, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10, T11 p11, T12 p12)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, invokeData.method);
	}
};
template <typename R, typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7, typename T8, typename T9, typename T10>
struct VirtFuncInvoker10
{
	typedef R (*Func)(void*, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8, T9 p9, T10 p10)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, invokeData.method);
	}
};

// System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MB_DynamicGameObject>
struct Dictionary_2_tEBA7C09A32644A3FA6E8B48325BC38F770D7E9B7;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5;
// System.Collections.Generic.List`1<MB_MaterialAndUVRect>
struct List_1_t6425EAFD4675F92D315F6E731F6A39897EEE0C9C;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5;
// System.Collections.Generic.List`1<DigitalOpus.MB.Core.ShaderTextureProperty>
struct List_1_t875987ABEC7A87063EA5CF3947DAE9FA48A0284D;
// System.Collections.Generic.List`1<System.String>
struct List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3;
// System.Collections.Generic.List`1<DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MB_DynamicGameObject>
struct List_1_t6253F0F417D70B05EF0E231E5CE290DB280006BF;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// UnityEngine.Color[]
struct ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// UnityEngine.GUILayoutOption[]
struct GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B;
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642;
// System.Int32[]
struct Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// MB_AtlasesAndRects[]
struct MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7;
// MB_MaterialAndUVRect[]
struct MB_MaterialAndUVRectU5BU5D_t8E28990AFF4F39DED1CECC95CBE573BBE835A4ED;
// MB_MultiMaterial[]
struct MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C;
// MB_MultiMaterialTexArray[]
struct MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E;
// MB_TextureArrayFormatSet[]
struct MB_TextureArrayFormatSetU5BU5D_tACA344ABBD1E4E010BCAD10396752EF4473007E4;
// UnityEngine.Material[]
struct MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492;
// UnityEngine.Matrix4x4[]
struct Matrix4x4U5BU5D_tE53F71E9C9110DD439281A6AB8B699F9F85D8F82;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// UnityEngine.Renderer[]
struct RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7;
// System.Single[]
struct SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
// UnityEngine.Texture2D[]
struct Texture2DU5BU5D_t0CBDCEA1648F6CBEA47C64E1E48F22B9692B3316;
// UnityEngine.Transform[]
struct TransformU5BU5D_t7821C0520CC567C0A069329C01AE9C058C7E3F1D;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4;
// UnityEngine.Vector4[]
struct Vector4U5BU5D_tCE72D928AA6FF1852BAC5E4396F6F0131ED11871;
// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MBBlendShape[]
struct MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB;
// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/SerializableIntArray[]
struct SerializableIntArrayU5BU5D_t37CB8F11D83C4AF885127641F3BAD20857D43DA2;
// UnityEngine.Animation
struct Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// BakeTexturesAtRuntime
struct BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0;
// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684;
// UnityEngine.Coroutine
struct Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// UnityEngine.GUILayoutOption
struct GUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB;
// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.Collections.IEnumerator
struct IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105;
// DigitalOpus.MB.Core.MB2_EditorMethodsInterface
struct MB2_EditorMethodsInterface_tDE7551065B75C48C11D6388743912ADFF51D1753;
// MB2_TextureBakeResults
struct MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC;
// MB3_MeshBaker
struct MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D;
// DigitalOpus.MB.Core.MB3_MeshCombinerSingle
struct MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A;
// MB3_MultiMeshBaker
struct MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D;
// DigitalOpus.MB.Core.MB3_MultiMeshCombiner
struct MB3_MultiMeshCombiner_t7CB3D4CCC9CFF1D0DA1C602351C8A2974AC39498;
// MB3_TextureBaker
struct MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E;
// MB_AtlasesAndRects
struct MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0;
// MB_BatchPrepareObjectsForDynamicBatchingDescription
struct MB_BatchPrepareObjectsForDynamicBatchingDescription_t9D997A1F37CDAE2A718380F1F0CC0A49E976F6CF;
// MB_DynamicAddDeleteExample
struct MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352;
// MB_Example
struct MB_Example_t2482A220673A29321053B9C6DED04A8B5F5F01DE;
// MB_ExampleMover
struct MB_ExampleMover_tE2268282AE7C1F2ABF91583A07AEB890359FE29D;
// MB_ExampleSkinnedMeshDescription
struct MB_ExampleSkinnedMeshDescription_tFB02696EFBA31EAD5321A0212F961B2698FC0CF4;
// DigitalOpus.MB.Core.MB_IMeshCombinerSimpleBones
struct MB_IMeshCombinerSimpleBones_t5277B3785F1B5A9275DB66B6D4AE3225A8A1AD48;
// MB_MigrateMaterialsToDifferentPipeline
struct MB_MigrateMaterialsToDifferentPipeline_t595685F82E94A09D39B4A9215AB3D547905D242B;
// MB_PrepareObjectsForDynamicBatchingDescription
struct MB_PrepareObjectsForDynamicBatchingDescription_t7E6322CFBF49D134B355E9347B8B4FB734E487DF;
// MB_SkinnedMeshSceneController
struct MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711;
// MB_SwapShirts
struct MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A;
// MB_SwitchBakedObjectsTexture
struct MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2;
// UnityEngine.Material
struct Material_t8927C00353A72755313F046D0CE85178AE8218EE;
// UnityEngine.Mesh
struct Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6;
// UnityEngine.MeshRenderer
struct MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A;
// System.NotSupportedException
struct NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339;
// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A;
// DigitalOpus.MB.Core.ProgressUpdateDelegate
struct ProgressUpdateDelegate_t2D164ADF2149F0581DEC2C7F4FA179F9566DBAAE;
// UnityEngine.Renderer
struct Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// UnityEngine.Shader
struct Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39;
// UnityEngine.SkinnedMeshRenderer
struct SkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496;
// System.String
struct String_t;
// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013;
// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshChannelsCache
struct MeshChannelsCache_t06EBFC463E3A29CBB756BB69A89D91DCCF74F633;
// MB3_TextureBaker/OnCombinedTexturesCoroutineFail
struct OnCombinedTexturesCoroutineFail_tC2BCA7F277426A929A0DE369D1A40285A18AB7A5;
// MB3_TextureBaker/OnCombinedTexturesCoroutineSuccess
struct OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA;
// DigitalOpus.MB.Core.MB3_TextureCombiner/CreateAtlasesCoroutineResult
struct CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB;
// MB_DynamicAddDeleteExample/<largeNumber>d__6
struct U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3;

IL2CPP_EXTERN_C RuntimeClass* CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral1691262A69613799986FFA89B484056508CBB3BD;
IL2CPP_EXTERN_C String_t* _stringLiteral1D2BA32BAB27E860E6B12CC64F30005C594802DA;
IL2CPP_EXTERN_C String_t* _stringLiteral1F7C34975DFE706DD833966CB44E790BC5F368E9;
IL2CPP_EXTERN_C String_t* _stringLiteral36AF179E09591E2BB7D1E7F5CC5B53634BC4026C;
IL2CPP_EXTERN_C String_t* _stringLiteral3EC3372E82B3B91672EF4EC7D6C8F3FB8E934642;
IL2CPP_EXTERN_C String_t* _stringLiteral3EE88DEAAD87FBF3623D53B0DE9986802A46D44D;
IL2CPP_EXTERN_C String_t* _stringLiteral402FF1C40586BBD50501FAA0F8F03404A4726BCD;
IL2CPP_EXTERN_C String_t* _stringLiteral6A858309322EB401D88265AE411835295660D2D6;
IL2CPP_EXTERN_C String_t* _stringLiteral7A3EC5F790A16AC6FC972A197F8CEC8FBE6B0942;
IL2CPP_EXTERN_C String_t* _stringLiteral8486A1F3A607D4973F36A2FB09B9E8A935DD95F2;
IL2CPP_EXTERN_C String_t* _stringLiteral84BE4104B995B0C9A1BE75ACFE52A28EAEBEC7BE;
IL2CPP_EXTERN_C String_t* _stringLiteral89BC85578B58BB199C2ACE44FCEB4FBC379C8D78;
IL2CPP_EXTERN_C String_t* _stringLiteral967C0E8FBF2CA8DCA87FC5F95006322F543FD279;
IL2CPP_EXTERN_C String_t* _stringLiteral96DB94E82B2C0B32BDD0F4D65857163BAC78861E;
IL2CPP_EXTERN_C String_t* _stringLiteral9B4FEEFA76B93D58B6E47CD9FF76F6E287D0D321;
IL2CPP_EXTERN_C String_t* _stringLiteral9B5270D77D3E3831C975E95DE1EB9D935744D556;
IL2CPP_EXTERN_C String_t* _stringLiteral9C15DB2067A4346D49A29ABFAD47FCD9AFA8384E;
IL2CPP_EXTERN_C String_t* _stringLiteral9F24FB9F6B79BD601755A6710686857F7B86347B;
IL2CPP_EXTERN_C String_t* _stringLiteralB02464A50A3B10AAA41DF03F87603D4EFABCFAF1;
IL2CPP_EXTERN_C String_t* _stringLiteralB13DE94066F2B882DE8E239513931BE1DFE46A03;
IL2CPP_EXTERN_C String_t* _stringLiteralB94ABD5415DFD72925D621D57063D571A5D90722;
IL2CPP_EXTERN_C String_t* _stringLiteralBAA0EAB272BE3FEF05FED2A6DDFCB50F93272B51;
IL2CPP_EXTERN_C String_t* _stringLiteralC84A871C8490BEB7482BEFA51B4C6EABB2E98A56;
IL2CPP_EXTERN_C String_t* _stringLiteralD0CB1AEF1E14A3CCF80E864762420E6CE16F1986;
IL2CPP_EXTERN_C String_t* _stringLiteralE040F9AA7BB3C6984613571A2CE6BA4705EBE9BB;
IL2CPP_EXTERN_C String_t* _stringLiteralF3DC1C70BEC11B40775CE32E6B71F1D8639EB5E4;
IL2CPP_EXTERN_C String_t* _stringLiteralF3F758FD35A5DD16AA5EF6E3B5380F1BD4ADDA59;
IL2CPP_EXTERN_C String_t* _stringLiteralF864450B05AACC1DF7E89709AF0716CAD8A14213;
IL2CPP_EXTERN_C const RuntimeMethod* Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* BakeTexturesAtRuntime_OnBuiltAtlasesSuccess_mE0B5F2680AE0ECC5E84126EEBEAE1B60B74CBC17_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponentInChildren_TisMB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D_m7BE87A164A3CB00D0F9A0CC0ECE26C96E46250ED_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_Dispose_m4B68F0A4E0441A036D7E39BC7E639536164196D9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_MoveNext_mF39107B3A55F66C83EBCA798CBC93AC4C990DBD7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerator_get_Current_mB38DBEFCD264B4682A190F8592464C0658F702B7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponentInChildren_TisSkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496_mBCB18247386FE1CD6449BA6EAAE856412A692586_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisAnimation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8_m92B9ADEC5AE6A5FB55D702AD0410469739EF307C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_mD787758BED3337F182C18CC67C516C2A11B55466_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Contains_mE508A129A7CB4DC89530674E7854B7F699BB486F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_GetEnumerator_m3616D04A85546C8251A6C376656CDB5358D893F6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ScriptableObject_CreateInstance_TisMB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC_mAB16670B2FAE73EF1E708558E4110CE0D941C508_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3ClargeNumberU3Ed__6_System_Collections_IEnumerator_Reset_m5890C15C5B5E0FAA08F7DA06DE339AC363A617B4_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B;
struct GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642;
struct MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7;
struct MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492;
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
struct RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t86A8971294189B0EE2A3081FDC9DDF750B54C42B 
{
public:

public:
};


// System.Object


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


// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5, ____items_1)); }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* get__items_1() const { return ____items_1; }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5_StaticFields, ____emptyArray_5)); }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* get__emptyArray_5() const { return ____emptyArray_5; }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// MB_AtlasesAndRects
struct MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0  : public RuntimeObject
{
public:
	// UnityEngine.Texture2D[] MB_AtlasesAndRects::atlases
	Texture2DU5BU5D_t0CBDCEA1648F6CBEA47C64E1E48F22B9692B3316* ___atlases_0;
	// System.Collections.Generic.List`1<MB_MaterialAndUVRect> MB_AtlasesAndRects::mat2rect_map
	List_1_t6425EAFD4675F92D315F6E731F6A39897EEE0C9C * ___mat2rect_map_1;
	// System.String[] MB_AtlasesAndRects::texPropertyNames
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___texPropertyNames_2;

public:
	inline static int32_t get_offset_of_atlases_0() { return static_cast<int32_t>(offsetof(MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0, ___atlases_0)); }
	inline Texture2DU5BU5D_t0CBDCEA1648F6CBEA47C64E1E48F22B9692B3316* get_atlases_0() const { return ___atlases_0; }
	inline Texture2DU5BU5D_t0CBDCEA1648F6CBEA47C64E1E48F22B9692B3316** get_address_of_atlases_0() { return &___atlases_0; }
	inline void set_atlases_0(Texture2DU5BU5D_t0CBDCEA1648F6CBEA47C64E1E48F22B9692B3316* value)
	{
		___atlases_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___atlases_0), (void*)value);
	}

	inline static int32_t get_offset_of_mat2rect_map_1() { return static_cast<int32_t>(offsetof(MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0, ___mat2rect_map_1)); }
	inline List_1_t6425EAFD4675F92D315F6E731F6A39897EEE0C9C * get_mat2rect_map_1() const { return ___mat2rect_map_1; }
	inline List_1_t6425EAFD4675F92D315F6E731F6A39897EEE0C9C ** get_address_of_mat2rect_map_1() { return &___mat2rect_map_1; }
	inline void set_mat2rect_map_1(List_1_t6425EAFD4675F92D315F6E731F6A39897EEE0C9C * value)
	{
		___mat2rect_map_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mat2rect_map_1), (void*)value);
	}

	inline static int32_t get_offset_of_texPropertyNames_2() { return static_cast<int32_t>(offsetof(MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0, ___texPropertyNames_2)); }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* get_texPropertyNames_2() const { return ___texPropertyNames_2; }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** get_address_of_texPropertyNames_2() { return &___texPropertyNames_2; }
	inline void set_texPropertyNames_2(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* value)
	{
		___texPropertyNames_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___texPropertyNames_2), (void*)value);
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

// DigitalOpus.MB.Core.MB3_TextureCombiner/CreateAtlasesCoroutineResult
struct CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB  : public RuntimeObject
{
public:
	// System.Boolean DigitalOpus.MB.Core.MB3_TextureCombiner/CreateAtlasesCoroutineResult::success
	bool ___success_0;
	// System.Boolean DigitalOpus.MB.Core.MB3_TextureCombiner/CreateAtlasesCoroutineResult::isFinished
	bool ___isFinished_1;

public:
	inline static int32_t get_offset_of_success_0() { return static_cast<int32_t>(offsetof(CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB, ___success_0)); }
	inline bool get_success_0() const { return ___success_0; }
	inline bool* get_address_of_success_0() { return &___success_0; }
	inline void set_success_0(bool value)
	{
		___success_0 = value;
	}

	inline static int32_t get_offset_of_isFinished_1() { return static_cast<int32_t>(offsetof(CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB, ___isFinished_1)); }
	inline bool get_isFinished_1() const { return ___isFinished_1; }
	inline bool* get_address_of_isFinished_1() { return &___isFinished_1; }
	inline void set_isFinished_1(bool value)
	{
		___isFinished_1 = value;
	}
};


// MB_DynamicAddDeleteExample/<largeNumber>d__6
struct U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3  : public RuntimeObject
{
public:
	// System.Int32 MB_DynamicAddDeleteExample/<largeNumber>d__6::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object MB_DynamicAddDeleteExample/<largeNumber>d__6::<>2__current
	RuntimeObject * ___U3CU3E2__current_1;
	// MB_DynamicAddDeleteExample MB_DynamicAddDeleteExample/<largeNumber>d__6::<>4__this
	MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * ___U3CU3E4__this_2;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3E2__current_1() { return static_cast<int32_t>(offsetof(U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3, ___U3CU3E2__current_1)); }
	inline RuntimeObject * get_U3CU3E2__current_1() const { return ___U3CU3E2__current_1; }
	inline RuntimeObject ** get_address_of_U3CU3E2__current_1() { return &___U3CU3E2__current_1; }
	inline void set_U3CU3E2__current_1(RuntimeObject * value)
	{
		___U3CU3E2__current_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E2__current_1), (void*)value);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_2() { return static_cast<int32_t>(offsetof(U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3, ___U3CU3E4__this_2)); }
	inline MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * get_U3CU3E4__this_2() const { return ___U3CU3E4__this_2; }
	inline MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 ** get_address_of_U3CU3E4__this_2() { return &___U3CU3E4__this_2; }
	inline void set_U3CU3E4__this_2(MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * value)
	{
		___U3CU3E4__this_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___U3CU3E4__this_2), (void*)value);
	}
};


// System.Collections.Generic.List`1/Enumerator<UnityEngine.GameObject>
struct Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1/Enumerator::list
	List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * ___list_0;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1/Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1/Enumerator::current
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14, ___list_0)); }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * get_list_0() const { return ___list_0; }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___list_0), (void*)value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14, ___current_3)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_current_3() const { return ___current_3; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___current_3), (void*)value);
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

// UnityEngine.AnimationCullingType
struct AnimationCullingType_t89A20BAE9022D15D84E3CB022425A7D8F86DF170 
{
public:
	// System.Int32 UnityEngine.AnimationCullingType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AnimationCullingType_t89A20BAE9022D15D84E3CB022425A7D8F86DF170, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Coroutine
struct Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7  : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF
{
public:
	// System.IntPtr UnityEngine.Coroutine::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Coroutine
struct Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7_marshaled_pinvoke : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.Coroutine
struct Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7_marshaled_com : public YieldInstruction_tB0B4E05316710E51ECCC1E57174C27FE6DEBBEAF_marshaled_com
{
	intptr_t ___m_Ptr_0;
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

// UnityEngine.KeyCode
struct KeyCode_t1D303F7D061BF4429872E9F109ADDBCB431671F4 
{
public:
	// System.Int32 UnityEngine.KeyCode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(KeyCode_t1D303F7D061BF4429872E9F109ADDBCB431671F4, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB2_LightmapOptions
struct MB2_LightmapOptions_tE301AEB5E1F65C952F3230526F7B1242709A0CF2 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB2_LightmapOptions::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MB2_LightmapOptions_tE301AEB5E1F65C952F3230526F7B1242709A0CF2, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB2_LogLevel
struct MB2_LogLevel_t99E2FB65EC1965EA372CD10C7C3F67FB8FD55BA2 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB2_LogLevel::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MB2_LogLevel_t99E2FB65EC1965EA372CD10C7C3F67FB8FD55BA2, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB2_OutputOptions
struct MB2_OutputOptions_t0DC372071645DCD0DAFD2A9672F4FEB6385B77BB 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB2_OutputOptions::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MB2_OutputOptions_t0DC372071645DCD0DAFD2A9672F4FEB6385B77BB, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB2_PackingAlgorithmEnum
struct MB2_PackingAlgorithmEnum_tA9E4A54C8A6AF91B448D3C70427B009420A455C8 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB2_PackingAlgorithmEnum::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MB2_PackingAlgorithmEnum_tA9E4A54C8A6AF91B448D3C70427B009420A455C8, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB2_ValidationLevel
struct MB2_ValidationLevel_t02A0F145AA83EE1F57D7161DA6651116A47B6FC7 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB2_ValidationLevel::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MB2_ValidationLevel_t02A0F145AA83EE1F57D7161DA6651116A47B6FC7, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB_MeshPivotLocation
struct MB_MeshPivotLocation_tF130F088E5C04BB7CB3F73656F828919A766280F 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB_MeshPivotLocation::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MB_MeshPivotLocation_tF130F088E5C04BB7CB3F73656F828919A766280F, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB_RenderType
struct MB_RenderType_t36A50A738C37B078ED098F5BBAA2A385A7D762DB 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB_RenderType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MB_RenderType_t36A50A738C37B078ED098F5BBAA2A385A7D762DB, ___value___2)); }
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


// MB2_TextureBakeResults/ResultType
struct ResultType_t9861477BBE46D37FB8C72CC0D5D7BCEEC54D6070 
{
public:
	// System.Int32 MB2_TextureBakeResults/ResultType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ResultType_t9861477BBE46D37FB8C72CC0D5D7BCEEC54D6070, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshCombiningStatus
struct MeshCombiningStatus_t7FCA4080AE172083F990E46A6C9BED1E32BC37FB 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshCombiningStatus::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MeshCombiningStatus_t7FCA4080AE172083F990E46A6C9BED1E32BC37FB, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshCreationConditions
struct MeshCreationConditions_t3FB313F7794758C38368BA5486A55255C3AB0007 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshCreationConditions::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MeshCreationConditions_t3FB313F7794758C38368BA5486A55255C3AB0007, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// DigitalOpus.MB.Core.MBVersion/PipelineType
struct PipelineType_t598D4A56D159619553B3BC8D6AB44E41DB302F65 
{
public:
	// System.Int32 DigitalOpus.MB.Core.MBVersion/PipelineType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PipelineType_t598D4A56D159619553B3BC8D6AB44E41DB302F65, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
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


// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// DigitalOpus.MB.Core.MB3_MeshCombiner
struct MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51  : public RuntimeObject
{
public:
	// DigitalOpus.MB.Core.MB2_ValidationLevel DigitalOpus.MB.Core.MB3_MeshCombiner::_validationLevel
	int32_t ____validationLevel_0;
	// System.String DigitalOpus.MB.Core.MB3_MeshCombiner::_name
	String_t* ____name_1;
	// MB2_TextureBakeResults DigitalOpus.MB.Core.MB3_MeshCombiner::_textureBakeResults
	MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * ____textureBakeResults_2;
	// UnityEngine.GameObject DigitalOpus.MB.Core.MB3_MeshCombiner::_resultSceneObject
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ____resultSceneObject_3;
	// UnityEngine.Renderer DigitalOpus.MB.Core.MB3_MeshCombiner::_targetRenderer
	Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * ____targetRenderer_4;
	// DigitalOpus.MB.Core.MB2_LogLevel DigitalOpus.MB.Core.MB3_MeshCombiner::_LOG_LEVEL
	int32_t ____LOG_LEVEL_5;
	// UnityEngine.Object DigitalOpus.MB.Core.MB3_MeshCombiner::_settingsHolder
	Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ____settingsHolder_6;
	// DigitalOpus.MB.Core.MB2_OutputOptions DigitalOpus.MB.Core.MB3_MeshCombiner::_outputOption
	int32_t ____outputOption_7;
	// DigitalOpus.MB.Core.MB_RenderType DigitalOpus.MB.Core.MB3_MeshCombiner::_renderType
	int32_t ____renderType_8;
	// DigitalOpus.MB.Core.MB2_LightmapOptions DigitalOpus.MB.Core.MB3_MeshCombiner::_lightmapOption
	int32_t ____lightmapOption_9;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doNorm
	bool ____doNorm_10;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doTan
	bool ____doTan_11;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doCol
	bool ____doCol_12;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doUV
	bool ____doUV_13;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doUV3
	bool ____doUV3_14;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doUV4
	bool ____doUV4_15;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doUV5
	bool ____doUV5_16;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doUV6
	bool ____doUV6_17;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doUV7
	bool ____doUV7_18;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doUV8
	bool ____doUV8_19;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_doBlendShapes
	bool ____doBlendShapes_20;
	// DigitalOpus.MB.Core.MB_MeshPivotLocation DigitalOpus.MB.Core.MB3_MeshCombiner::_pivotLocationType
	int32_t ____pivotLocationType_21;
	// UnityEngine.Vector3 DigitalOpus.MB.Core.MB3_MeshCombiner::_pivotLocation
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ____pivotLocation_22;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_clearBuffersAfterBake
	bool ____clearBuffersAfterBake_23;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_optimizeAfterBake
	bool ____optimizeAfterBake_24;
	// System.Single DigitalOpus.MB.Core.MB3_MeshCombiner::_uv2UnwrappingParamsHardAngle
	float ____uv2UnwrappingParamsHardAngle_25;
	// System.Single DigitalOpus.MB.Core.MB3_MeshCombiner::_uv2UnwrappingParamsPackMargin
	float ____uv2UnwrappingParamsPackMargin_26;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_smrNoExtraBonesWhenCombiningMeshRenderers
	bool ____smrNoExtraBonesWhenCombiningMeshRenderers_27;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_smrMergeBlendShapesWithSameNames
	bool ____smrMergeBlendShapesWithSameNames_28;
	// UnityEngine.Object DigitalOpus.MB.Core.MB3_MeshCombiner::_assignToMeshCustomizer
	Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ____assignToMeshCustomizer_29;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_usingTemporaryTextureBakeResult
	bool ____usingTemporaryTextureBakeResult_30;
	// System.Boolean DigitalOpus.MB.Core.MB3_MeshCombiner::_disposed
	bool ____disposed_31;

public:
	inline static int32_t get_offset_of__validationLevel_0() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____validationLevel_0)); }
	inline int32_t get__validationLevel_0() const { return ____validationLevel_0; }
	inline int32_t* get_address_of__validationLevel_0() { return &____validationLevel_0; }
	inline void set__validationLevel_0(int32_t value)
	{
		____validationLevel_0 = value;
	}

	inline static int32_t get_offset_of__name_1() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____name_1)); }
	inline String_t* get__name_1() const { return ____name_1; }
	inline String_t** get_address_of__name_1() { return &____name_1; }
	inline void set__name_1(String_t* value)
	{
		____name_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____name_1), (void*)value);
	}

	inline static int32_t get_offset_of__textureBakeResults_2() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____textureBakeResults_2)); }
	inline MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * get__textureBakeResults_2() const { return ____textureBakeResults_2; }
	inline MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC ** get_address_of__textureBakeResults_2() { return &____textureBakeResults_2; }
	inline void set__textureBakeResults_2(MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * value)
	{
		____textureBakeResults_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____textureBakeResults_2), (void*)value);
	}

	inline static int32_t get_offset_of__resultSceneObject_3() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____resultSceneObject_3)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get__resultSceneObject_3() const { return ____resultSceneObject_3; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of__resultSceneObject_3() { return &____resultSceneObject_3; }
	inline void set__resultSceneObject_3(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		____resultSceneObject_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____resultSceneObject_3), (void*)value);
	}

	inline static int32_t get_offset_of__targetRenderer_4() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____targetRenderer_4)); }
	inline Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * get__targetRenderer_4() const { return ____targetRenderer_4; }
	inline Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C ** get_address_of__targetRenderer_4() { return &____targetRenderer_4; }
	inline void set__targetRenderer_4(Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * value)
	{
		____targetRenderer_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____targetRenderer_4), (void*)value);
	}

	inline static int32_t get_offset_of__LOG_LEVEL_5() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____LOG_LEVEL_5)); }
	inline int32_t get__LOG_LEVEL_5() const { return ____LOG_LEVEL_5; }
	inline int32_t* get_address_of__LOG_LEVEL_5() { return &____LOG_LEVEL_5; }
	inline void set__LOG_LEVEL_5(int32_t value)
	{
		____LOG_LEVEL_5 = value;
	}

	inline static int32_t get_offset_of__settingsHolder_6() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____settingsHolder_6)); }
	inline Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * get__settingsHolder_6() const { return ____settingsHolder_6; }
	inline Object_tF2F3778131EFF286AF62B7B013A170F95A91571A ** get_address_of__settingsHolder_6() { return &____settingsHolder_6; }
	inline void set__settingsHolder_6(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * value)
	{
		____settingsHolder_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____settingsHolder_6), (void*)value);
	}

	inline static int32_t get_offset_of__outputOption_7() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____outputOption_7)); }
	inline int32_t get__outputOption_7() const { return ____outputOption_7; }
	inline int32_t* get_address_of__outputOption_7() { return &____outputOption_7; }
	inline void set__outputOption_7(int32_t value)
	{
		____outputOption_7 = value;
	}

	inline static int32_t get_offset_of__renderType_8() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____renderType_8)); }
	inline int32_t get__renderType_8() const { return ____renderType_8; }
	inline int32_t* get_address_of__renderType_8() { return &____renderType_8; }
	inline void set__renderType_8(int32_t value)
	{
		____renderType_8 = value;
	}

	inline static int32_t get_offset_of__lightmapOption_9() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____lightmapOption_9)); }
	inline int32_t get__lightmapOption_9() const { return ____lightmapOption_9; }
	inline int32_t* get_address_of__lightmapOption_9() { return &____lightmapOption_9; }
	inline void set__lightmapOption_9(int32_t value)
	{
		____lightmapOption_9 = value;
	}

	inline static int32_t get_offset_of__doNorm_10() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doNorm_10)); }
	inline bool get__doNorm_10() const { return ____doNorm_10; }
	inline bool* get_address_of__doNorm_10() { return &____doNorm_10; }
	inline void set__doNorm_10(bool value)
	{
		____doNorm_10 = value;
	}

	inline static int32_t get_offset_of__doTan_11() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doTan_11)); }
	inline bool get__doTan_11() const { return ____doTan_11; }
	inline bool* get_address_of__doTan_11() { return &____doTan_11; }
	inline void set__doTan_11(bool value)
	{
		____doTan_11 = value;
	}

	inline static int32_t get_offset_of__doCol_12() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doCol_12)); }
	inline bool get__doCol_12() const { return ____doCol_12; }
	inline bool* get_address_of__doCol_12() { return &____doCol_12; }
	inline void set__doCol_12(bool value)
	{
		____doCol_12 = value;
	}

	inline static int32_t get_offset_of__doUV_13() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doUV_13)); }
	inline bool get__doUV_13() const { return ____doUV_13; }
	inline bool* get_address_of__doUV_13() { return &____doUV_13; }
	inline void set__doUV_13(bool value)
	{
		____doUV_13 = value;
	}

	inline static int32_t get_offset_of__doUV3_14() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doUV3_14)); }
	inline bool get__doUV3_14() const { return ____doUV3_14; }
	inline bool* get_address_of__doUV3_14() { return &____doUV3_14; }
	inline void set__doUV3_14(bool value)
	{
		____doUV3_14 = value;
	}

	inline static int32_t get_offset_of__doUV4_15() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doUV4_15)); }
	inline bool get__doUV4_15() const { return ____doUV4_15; }
	inline bool* get_address_of__doUV4_15() { return &____doUV4_15; }
	inline void set__doUV4_15(bool value)
	{
		____doUV4_15 = value;
	}

	inline static int32_t get_offset_of__doUV5_16() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doUV5_16)); }
	inline bool get__doUV5_16() const { return ____doUV5_16; }
	inline bool* get_address_of__doUV5_16() { return &____doUV5_16; }
	inline void set__doUV5_16(bool value)
	{
		____doUV5_16 = value;
	}

	inline static int32_t get_offset_of__doUV6_17() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doUV6_17)); }
	inline bool get__doUV6_17() const { return ____doUV6_17; }
	inline bool* get_address_of__doUV6_17() { return &____doUV6_17; }
	inline void set__doUV6_17(bool value)
	{
		____doUV6_17 = value;
	}

	inline static int32_t get_offset_of__doUV7_18() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doUV7_18)); }
	inline bool get__doUV7_18() const { return ____doUV7_18; }
	inline bool* get_address_of__doUV7_18() { return &____doUV7_18; }
	inline void set__doUV7_18(bool value)
	{
		____doUV7_18 = value;
	}

	inline static int32_t get_offset_of__doUV8_19() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doUV8_19)); }
	inline bool get__doUV8_19() const { return ____doUV8_19; }
	inline bool* get_address_of__doUV8_19() { return &____doUV8_19; }
	inline void set__doUV8_19(bool value)
	{
		____doUV8_19 = value;
	}

	inline static int32_t get_offset_of__doBlendShapes_20() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____doBlendShapes_20)); }
	inline bool get__doBlendShapes_20() const { return ____doBlendShapes_20; }
	inline bool* get_address_of__doBlendShapes_20() { return &____doBlendShapes_20; }
	inline void set__doBlendShapes_20(bool value)
	{
		____doBlendShapes_20 = value;
	}

	inline static int32_t get_offset_of__pivotLocationType_21() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____pivotLocationType_21)); }
	inline int32_t get__pivotLocationType_21() const { return ____pivotLocationType_21; }
	inline int32_t* get_address_of__pivotLocationType_21() { return &____pivotLocationType_21; }
	inline void set__pivotLocationType_21(int32_t value)
	{
		____pivotLocationType_21 = value;
	}

	inline static int32_t get_offset_of__pivotLocation_22() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____pivotLocation_22)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get__pivotLocation_22() const { return ____pivotLocation_22; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of__pivotLocation_22() { return &____pivotLocation_22; }
	inline void set__pivotLocation_22(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		____pivotLocation_22 = value;
	}

	inline static int32_t get_offset_of__clearBuffersAfterBake_23() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____clearBuffersAfterBake_23)); }
	inline bool get__clearBuffersAfterBake_23() const { return ____clearBuffersAfterBake_23; }
	inline bool* get_address_of__clearBuffersAfterBake_23() { return &____clearBuffersAfterBake_23; }
	inline void set__clearBuffersAfterBake_23(bool value)
	{
		____clearBuffersAfterBake_23 = value;
	}

	inline static int32_t get_offset_of__optimizeAfterBake_24() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____optimizeAfterBake_24)); }
	inline bool get__optimizeAfterBake_24() const { return ____optimizeAfterBake_24; }
	inline bool* get_address_of__optimizeAfterBake_24() { return &____optimizeAfterBake_24; }
	inline void set__optimizeAfterBake_24(bool value)
	{
		____optimizeAfterBake_24 = value;
	}

	inline static int32_t get_offset_of__uv2UnwrappingParamsHardAngle_25() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____uv2UnwrappingParamsHardAngle_25)); }
	inline float get__uv2UnwrappingParamsHardAngle_25() const { return ____uv2UnwrappingParamsHardAngle_25; }
	inline float* get_address_of__uv2UnwrappingParamsHardAngle_25() { return &____uv2UnwrappingParamsHardAngle_25; }
	inline void set__uv2UnwrappingParamsHardAngle_25(float value)
	{
		____uv2UnwrappingParamsHardAngle_25 = value;
	}

	inline static int32_t get_offset_of__uv2UnwrappingParamsPackMargin_26() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____uv2UnwrappingParamsPackMargin_26)); }
	inline float get__uv2UnwrappingParamsPackMargin_26() const { return ____uv2UnwrappingParamsPackMargin_26; }
	inline float* get_address_of__uv2UnwrappingParamsPackMargin_26() { return &____uv2UnwrappingParamsPackMargin_26; }
	inline void set__uv2UnwrappingParamsPackMargin_26(float value)
	{
		____uv2UnwrappingParamsPackMargin_26 = value;
	}

	inline static int32_t get_offset_of__smrNoExtraBonesWhenCombiningMeshRenderers_27() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____smrNoExtraBonesWhenCombiningMeshRenderers_27)); }
	inline bool get__smrNoExtraBonesWhenCombiningMeshRenderers_27() const { return ____smrNoExtraBonesWhenCombiningMeshRenderers_27; }
	inline bool* get_address_of__smrNoExtraBonesWhenCombiningMeshRenderers_27() { return &____smrNoExtraBonesWhenCombiningMeshRenderers_27; }
	inline void set__smrNoExtraBonesWhenCombiningMeshRenderers_27(bool value)
	{
		____smrNoExtraBonesWhenCombiningMeshRenderers_27 = value;
	}

	inline static int32_t get_offset_of__smrMergeBlendShapesWithSameNames_28() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____smrMergeBlendShapesWithSameNames_28)); }
	inline bool get__smrMergeBlendShapesWithSameNames_28() const { return ____smrMergeBlendShapesWithSameNames_28; }
	inline bool* get_address_of__smrMergeBlendShapesWithSameNames_28() { return &____smrMergeBlendShapesWithSameNames_28; }
	inline void set__smrMergeBlendShapesWithSameNames_28(bool value)
	{
		____smrMergeBlendShapesWithSameNames_28 = value;
	}

	inline static int32_t get_offset_of__assignToMeshCustomizer_29() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____assignToMeshCustomizer_29)); }
	inline Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * get__assignToMeshCustomizer_29() const { return ____assignToMeshCustomizer_29; }
	inline Object_tF2F3778131EFF286AF62B7B013A170F95A91571A ** get_address_of__assignToMeshCustomizer_29() { return &____assignToMeshCustomizer_29; }
	inline void set__assignToMeshCustomizer_29(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * value)
	{
		____assignToMeshCustomizer_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____assignToMeshCustomizer_29), (void*)value);
	}

	inline static int32_t get_offset_of__usingTemporaryTextureBakeResult_30() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____usingTemporaryTextureBakeResult_30)); }
	inline bool get__usingTemporaryTextureBakeResult_30() const { return ____usingTemporaryTextureBakeResult_30; }
	inline bool* get_address_of__usingTemporaryTextureBakeResult_30() { return &____usingTemporaryTextureBakeResult_30; }
	inline void set__usingTemporaryTextureBakeResult_30(bool value)
	{
		____usingTemporaryTextureBakeResult_30 = value;
	}

	inline static int32_t get_offset_of__disposed_31() { return static_cast<int32_t>(offsetof(MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51, ____disposed_31)); }
	inline bool get__disposed_31() const { return ____disposed_31; }
	inline bool* get_address_of__disposed_31() { return &____disposed_31; }
	inline void set__disposed_31(bool value)
	{
		____disposed_31 = value;
	}
};


// UnityEngine.Material
struct Material_t8927C00353A72755313F046D0CE85178AE8218EE  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
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

// UnityEngine.Shader
struct Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
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


// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// MB2_TextureBakeResults
struct MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC  : public ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A
{
public:
	// System.Int32 MB2_TextureBakeResults::version
	int32_t ___version_4;
	// MB2_TextureBakeResults/ResultType MB2_TextureBakeResults::resultType
	int32_t ___resultType_5;
	// MB_MaterialAndUVRect[] MB2_TextureBakeResults::materialsAndUVRects
	MB_MaterialAndUVRectU5BU5D_t8E28990AFF4F39DED1CECC95CBE573BBE835A4ED* ___materialsAndUVRects_6;
	// MB_MultiMaterial[] MB2_TextureBakeResults::resultMaterials
	MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C* ___resultMaterials_7;
	// MB_MultiMaterialTexArray[] MB2_TextureBakeResults::resultMaterialsTexArray
	MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E* ___resultMaterialsTexArray_8;
	// System.Boolean MB2_TextureBakeResults::doMultiMaterial
	bool ___doMultiMaterial_9;

public:
	inline static int32_t get_offset_of_version_4() { return static_cast<int32_t>(offsetof(MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC, ___version_4)); }
	inline int32_t get_version_4() const { return ___version_4; }
	inline int32_t* get_address_of_version_4() { return &___version_4; }
	inline void set_version_4(int32_t value)
	{
		___version_4 = value;
	}

	inline static int32_t get_offset_of_resultType_5() { return static_cast<int32_t>(offsetof(MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC, ___resultType_5)); }
	inline int32_t get_resultType_5() const { return ___resultType_5; }
	inline int32_t* get_address_of_resultType_5() { return &___resultType_5; }
	inline void set_resultType_5(int32_t value)
	{
		___resultType_5 = value;
	}

	inline static int32_t get_offset_of_materialsAndUVRects_6() { return static_cast<int32_t>(offsetof(MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC, ___materialsAndUVRects_6)); }
	inline MB_MaterialAndUVRectU5BU5D_t8E28990AFF4F39DED1CECC95CBE573BBE835A4ED* get_materialsAndUVRects_6() const { return ___materialsAndUVRects_6; }
	inline MB_MaterialAndUVRectU5BU5D_t8E28990AFF4F39DED1CECC95CBE573BBE835A4ED** get_address_of_materialsAndUVRects_6() { return &___materialsAndUVRects_6; }
	inline void set_materialsAndUVRects_6(MB_MaterialAndUVRectU5BU5D_t8E28990AFF4F39DED1CECC95CBE573BBE835A4ED* value)
	{
		___materialsAndUVRects_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___materialsAndUVRects_6), (void*)value);
	}

	inline static int32_t get_offset_of_resultMaterials_7() { return static_cast<int32_t>(offsetof(MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC, ___resultMaterials_7)); }
	inline MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C* get_resultMaterials_7() const { return ___resultMaterials_7; }
	inline MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C** get_address_of_resultMaterials_7() { return &___resultMaterials_7; }
	inline void set_resultMaterials_7(MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C* value)
	{
		___resultMaterials_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___resultMaterials_7), (void*)value);
	}

	inline static int32_t get_offset_of_resultMaterialsTexArray_8() { return static_cast<int32_t>(offsetof(MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC, ___resultMaterialsTexArray_8)); }
	inline MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E* get_resultMaterialsTexArray_8() const { return ___resultMaterialsTexArray_8; }
	inline MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E** get_address_of_resultMaterialsTexArray_8() { return &___resultMaterialsTexArray_8; }
	inline void set_resultMaterialsTexArray_8(MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E* value)
	{
		___resultMaterialsTexArray_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___resultMaterialsTexArray_8), (void*)value);
	}

	inline static int32_t get_offset_of_doMultiMaterial_9() { return static_cast<int32_t>(offsetof(MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC, ___doMultiMaterial_9)); }
	inline bool get_doMultiMaterial_9() const { return ___doMultiMaterial_9; }
	inline bool* get_address_of_doMultiMaterial_9() { return &___doMultiMaterial_9; }
	inline void set_doMultiMaterial_9(bool value)
	{
		___doMultiMaterial_9 = value;
	}
};


// DigitalOpus.MB.Core.MB3_MeshCombinerSingle
struct MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A  : public MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51
{
public:
	// System.Collections.Generic.List`1<UnityEngine.GameObject> DigitalOpus.MB.Core.MB3_MeshCombinerSingle::objectsInCombinedMesh
	List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * ___objectsInCombinedMesh_32;
	// System.Int32 DigitalOpus.MB.Core.MB3_MeshCombinerSingle::lightmapIndex
	int32_t ___lightmapIndex_33;
	// System.Collections.Generic.List`1<DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MB_DynamicGameObject> DigitalOpus.MB.Core.MB3_MeshCombinerSingle::mbDynamicObjectsInCombinedMesh
	List_1_t6253F0F417D70B05EF0E231E5CE290DB280006BF * ___mbDynamicObjectsInCombinedMesh_34;
	// System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MB_DynamicGameObject> DigitalOpus.MB.Core.MB3_MeshCombinerSingle::_instance2combined_map
	Dictionary_2_tEBA7C09A32644A3FA6E8B48325BC38F770D7E9B7 * ____instance2combined_map_35;
	// UnityEngine.Vector3[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::verts
	Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* ___verts_36;
	// UnityEngine.Vector3[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::normals
	Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* ___normals_37;
	// UnityEngine.Vector4[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::tangents
	Vector4U5BU5D_tCE72D928AA6FF1852BAC5E4396F6F0131ED11871* ___tangents_38;
	// UnityEngine.Vector2[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uvs
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___uvs_39;
	// System.Single[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uvsSliceIdx
	SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* ___uvsSliceIdx_40;
	// UnityEngine.Vector2[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uv2s
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___uv2s_41;
	// UnityEngine.Vector2[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uv3s
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___uv3s_42;
	// UnityEngine.Vector2[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uv4s
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___uv4s_43;
	// UnityEngine.Vector2[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uv5s
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___uv5s_44;
	// UnityEngine.Vector2[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uv6s
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___uv6s_45;
	// UnityEngine.Vector2[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uv7s
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___uv7s_46;
	// UnityEngine.Vector2[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::uv8s
	Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* ___uv8s_47;
	// UnityEngine.Color[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::colors
	ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* ___colors_48;
	// UnityEngine.Matrix4x4[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::bindPoses
	Matrix4x4U5BU5D_tE53F71E9C9110DD439281A6AB8B699F9F85D8F82* ___bindPoses_49;
	// UnityEngine.Transform[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::bones
	TransformU5BU5D_t7821C0520CC567C0A069329C01AE9C058C7E3F1D* ___bones_50;
	// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MBBlendShape[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::blendShapes
	MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB* ___blendShapes_51;
	// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MBBlendShape[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::blendShapesInCombined
	MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB* ___blendShapesInCombined_52;
	// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/SerializableIntArray[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::submeshTris
	SerializableIntArrayU5BU5D_t37CB8F11D83C4AF885127641F3BAD20857D43DA2* ___submeshTris_53;
	// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshCreationConditions DigitalOpus.MB.Core.MB3_MeshCombinerSingle::_meshBirth
	int32_t ____meshBirth_54;
	// UnityEngine.Mesh DigitalOpus.MB.Core.MB3_MeshCombinerSingle::_mesh
	Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ____mesh_55;
	// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshCombiningStatus DigitalOpus.MB.Core.MB3_MeshCombinerSingle::bakeStatus
	int32_t ___bakeStatus_56;
	// DigitalOpus.MB.Core.MB_IMeshCombinerSimpleBones DigitalOpus.MB.Core.MB3_MeshCombinerSingle::_boneProcessor
	RuntimeObject* ____boneProcessor_57;
	// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshChannelsCache DigitalOpus.MB.Core.MB3_MeshCombinerSingle::_meshChannelsCache
	MeshChannelsCache_t06EBFC463E3A29CBB756BB69A89D91DCCF74F633 * ____meshChannelsCache_58;
	// UnityEngine.GameObject[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::empty
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* ___empty_59;
	// System.Int32[] DigitalOpus.MB.Core.MB3_MeshCombinerSingle::emptyIDs
	Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* ___emptyIDs_60;

public:
	inline static int32_t get_offset_of_objectsInCombinedMesh_32() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___objectsInCombinedMesh_32)); }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * get_objectsInCombinedMesh_32() const { return ___objectsInCombinedMesh_32; }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 ** get_address_of_objectsInCombinedMesh_32() { return &___objectsInCombinedMesh_32; }
	inline void set_objectsInCombinedMesh_32(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * value)
	{
		___objectsInCombinedMesh_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objectsInCombinedMesh_32), (void*)value);
	}

	inline static int32_t get_offset_of_lightmapIndex_33() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___lightmapIndex_33)); }
	inline int32_t get_lightmapIndex_33() const { return ___lightmapIndex_33; }
	inline int32_t* get_address_of_lightmapIndex_33() { return &___lightmapIndex_33; }
	inline void set_lightmapIndex_33(int32_t value)
	{
		___lightmapIndex_33 = value;
	}

	inline static int32_t get_offset_of_mbDynamicObjectsInCombinedMesh_34() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___mbDynamicObjectsInCombinedMesh_34)); }
	inline List_1_t6253F0F417D70B05EF0E231E5CE290DB280006BF * get_mbDynamicObjectsInCombinedMesh_34() const { return ___mbDynamicObjectsInCombinedMesh_34; }
	inline List_1_t6253F0F417D70B05EF0E231E5CE290DB280006BF ** get_address_of_mbDynamicObjectsInCombinedMesh_34() { return &___mbDynamicObjectsInCombinedMesh_34; }
	inline void set_mbDynamicObjectsInCombinedMesh_34(List_1_t6253F0F417D70B05EF0E231E5CE290DB280006BF * value)
	{
		___mbDynamicObjectsInCombinedMesh_34 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mbDynamicObjectsInCombinedMesh_34), (void*)value);
	}

	inline static int32_t get_offset_of__instance2combined_map_35() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ____instance2combined_map_35)); }
	inline Dictionary_2_tEBA7C09A32644A3FA6E8B48325BC38F770D7E9B7 * get__instance2combined_map_35() const { return ____instance2combined_map_35; }
	inline Dictionary_2_tEBA7C09A32644A3FA6E8B48325BC38F770D7E9B7 ** get_address_of__instance2combined_map_35() { return &____instance2combined_map_35; }
	inline void set__instance2combined_map_35(Dictionary_2_tEBA7C09A32644A3FA6E8B48325BC38F770D7E9B7 * value)
	{
		____instance2combined_map_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____instance2combined_map_35), (void*)value);
	}

	inline static int32_t get_offset_of_verts_36() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___verts_36)); }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* get_verts_36() const { return ___verts_36; }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4** get_address_of_verts_36() { return &___verts_36; }
	inline void set_verts_36(Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* value)
	{
		___verts_36 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___verts_36), (void*)value);
	}

	inline static int32_t get_offset_of_normals_37() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___normals_37)); }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* get_normals_37() const { return ___normals_37; }
	inline Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4** get_address_of_normals_37() { return &___normals_37; }
	inline void set_normals_37(Vector3U5BU5D_t5FB88EAA33E46838BDC2ABDAEA3E8727491CB9E4* value)
	{
		___normals_37 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___normals_37), (void*)value);
	}

	inline static int32_t get_offset_of_tangents_38() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___tangents_38)); }
	inline Vector4U5BU5D_tCE72D928AA6FF1852BAC5E4396F6F0131ED11871* get_tangents_38() const { return ___tangents_38; }
	inline Vector4U5BU5D_tCE72D928AA6FF1852BAC5E4396F6F0131ED11871** get_address_of_tangents_38() { return &___tangents_38; }
	inline void set_tangents_38(Vector4U5BU5D_tCE72D928AA6FF1852BAC5E4396F6F0131ED11871* value)
	{
		___tangents_38 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___tangents_38), (void*)value);
	}

	inline static int32_t get_offset_of_uvs_39() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uvs_39)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_uvs_39() const { return ___uvs_39; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_uvs_39() { return &___uvs_39; }
	inline void set_uvs_39(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___uvs_39 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uvs_39), (void*)value);
	}

	inline static int32_t get_offset_of_uvsSliceIdx_40() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uvsSliceIdx_40)); }
	inline SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* get_uvsSliceIdx_40() const { return ___uvsSliceIdx_40; }
	inline SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA** get_address_of_uvsSliceIdx_40() { return &___uvsSliceIdx_40; }
	inline void set_uvsSliceIdx_40(SingleU5BU5D_t47E8DBF5B597C122478D1FFBD9DD57399A0650FA* value)
	{
		___uvsSliceIdx_40 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uvsSliceIdx_40), (void*)value);
	}

	inline static int32_t get_offset_of_uv2s_41() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uv2s_41)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_uv2s_41() const { return ___uv2s_41; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_uv2s_41() { return &___uv2s_41; }
	inline void set_uv2s_41(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___uv2s_41 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uv2s_41), (void*)value);
	}

	inline static int32_t get_offset_of_uv3s_42() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uv3s_42)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_uv3s_42() const { return ___uv3s_42; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_uv3s_42() { return &___uv3s_42; }
	inline void set_uv3s_42(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___uv3s_42 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uv3s_42), (void*)value);
	}

	inline static int32_t get_offset_of_uv4s_43() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uv4s_43)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_uv4s_43() const { return ___uv4s_43; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_uv4s_43() { return &___uv4s_43; }
	inline void set_uv4s_43(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___uv4s_43 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uv4s_43), (void*)value);
	}

	inline static int32_t get_offset_of_uv5s_44() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uv5s_44)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_uv5s_44() const { return ___uv5s_44; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_uv5s_44() { return &___uv5s_44; }
	inline void set_uv5s_44(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___uv5s_44 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uv5s_44), (void*)value);
	}

	inline static int32_t get_offset_of_uv6s_45() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uv6s_45)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_uv6s_45() const { return ___uv6s_45; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_uv6s_45() { return &___uv6s_45; }
	inline void set_uv6s_45(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___uv6s_45 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uv6s_45), (void*)value);
	}

	inline static int32_t get_offset_of_uv7s_46() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uv7s_46)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_uv7s_46() const { return ___uv7s_46; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_uv7s_46() { return &___uv7s_46; }
	inline void set_uv7s_46(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___uv7s_46 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uv7s_46), (void*)value);
	}

	inline static int32_t get_offset_of_uv8s_47() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___uv8s_47)); }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* get_uv8s_47() const { return ___uv8s_47; }
	inline Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA** get_address_of_uv8s_47() { return &___uv8s_47; }
	inline void set_uv8s_47(Vector2U5BU5D_tE0F58A2D6D8592B5EC37D9CDEF09103A02E5D7FA* value)
	{
		___uv8s_47 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___uv8s_47), (void*)value);
	}

	inline static int32_t get_offset_of_colors_48() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___colors_48)); }
	inline ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* get_colors_48() const { return ___colors_48; }
	inline ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834** get_address_of_colors_48() { return &___colors_48; }
	inline void set_colors_48(ColorU5BU5D_t358DD89F511301E663AD9157305B94A2DEFF8834* value)
	{
		___colors_48 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___colors_48), (void*)value);
	}

	inline static int32_t get_offset_of_bindPoses_49() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___bindPoses_49)); }
	inline Matrix4x4U5BU5D_tE53F71E9C9110DD439281A6AB8B699F9F85D8F82* get_bindPoses_49() const { return ___bindPoses_49; }
	inline Matrix4x4U5BU5D_tE53F71E9C9110DD439281A6AB8B699F9F85D8F82** get_address_of_bindPoses_49() { return &___bindPoses_49; }
	inline void set_bindPoses_49(Matrix4x4U5BU5D_tE53F71E9C9110DD439281A6AB8B699F9F85D8F82* value)
	{
		___bindPoses_49 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___bindPoses_49), (void*)value);
	}

	inline static int32_t get_offset_of_bones_50() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___bones_50)); }
	inline TransformU5BU5D_t7821C0520CC567C0A069329C01AE9C058C7E3F1D* get_bones_50() const { return ___bones_50; }
	inline TransformU5BU5D_t7821C0520CC567C0A069329C01AE9C058C7E3F1D** get_address_of_bones_50() { return &___bones_50; }
	inline void set_bones_50(TransformU5BU5D_t7821C0520CC567C0A069329C01AE9C058C7E3F1D* value)
	{
		___bones_50 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___bones_50), (void*)value);
	}

	inline static int32_t get_offset_of_blendShapes_51() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___blendShapes_51)); }
	inline MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB* get_blendShapes_51() const { return ___blendShapes_51; }
	inline MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB** get_address_of_blendShapes_51() { return &___blendShapes_51; }
	inline void set_blendShapes_51(MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB* value)
	{
		___blendShapes_51 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___blendShapes_51), (void*)value);
	}

	inline static int32_t get_offset_of_blendShapesInCombined_52() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___blendShapesInCombined_52)); }
	inline MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB* get_blendShapesInCombined_52() const { return ___blendShapesInCombined_52; }
	inline MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB** get_address_of_blendShapesInCombined_52() { return &___blendShapesInCombined_52; }
	inline void set_blendShapesInCombined_52(MBBlendShapeU5BU5D_t1A7C9D39C9A6FA2A72A609365FAD471C735F1BEB* value)
	{
		___blendShapesInCombined_52 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___blendShapesInCombined_52), (void*)value);
	}

	inline static int32_t get_offset_of_submeshTris_53() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___submeshTris_53)); }
	inline SerializableIntArrayU5BU5D_t37CB8F11D83C4AF885127641F3BAD20857D43DA2* get_submeshTris_53() const { return ___submeshTris_53; }
	inline SerializableIntArrayU5BU5D_t37CB8F11D83C4AF885127641F3BAD20857D43DA2** get_address_of_submeshTris_53() { return &___submeshTris_53; }
	inline void set_submeshTris_53(SerializableIntArrayU5BU5D_t37CB8F11D83C4AF885127641F3BAD20857D43DA2* value)
	{
		___submeshTris_53 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___submeshTris_53), (void*)value);
	}

	inline static int32_t get_offset_of__meshBirth_54() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ____meshBirth_54)); }
	inline int32_t get__meshBirth_54() const { return ____meshBirth_54; }
	inline int32_t* get_address_of__meshBirth_54() { return &____meshBirth_54; }
	inline void set__meshBirth_54(int32_t value)
	{
		____meshBirth_54 = value;
	}

	inline static int32_t get_offset_of__mesh_55() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ____mesh_55)); }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * get__mesh_55() const { return ____mesh_55; }
	inline Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 ** get_address_of__mesh_55() { return &____mesh_55; }
	inline void set__mesh_55(Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * value)
	{
		____mesh_55 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____mesh_55), (void*)value);
	}

	inline static int32_t get_offset_of_bakeStatus_56() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___bakeStatus_56)); }
	inline int32_t get_bakeStatus_56() const { return ___bakeStatus_56; }
	inline int32_t* get_address_of_bakeStatus_56() { return &___bakeStatus_56; }
	inline void set_bakeStatus_56(int32_t value)
	{
		___bakeStatus_56 = value;
	}

	inline static int32_t get_offset_of__boneProcessor_57() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ____boneProcessor_57)); }
	inline RuntimeObject* get__boneProcessor_57() const { return ____boneProcessor_57; }
	inline RuntimeObject** get_address_of__boneProcessor_57() { return &____boneProcessor_57; }
	inline void set__boneProcessor_57(RuntimeObject* value)
	{
		____boneProcessor_57 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____boneProcessor_57), (void*)value);
	}

	inline static int32_t get_offset_of__meshChannelsCache_58() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ____meshChannelsCache_58)); }
	inline MeshChannelsCache_t06EBFC463E3A29CBB756BB69A89D91DCCF74F633 * get__meshChannelsCache_58() const { return ____meshChannelsCache_58; }
	inline MeshChannelsCache_t06EBFC463E3A29CBB756BB69A89D91DCCF74F633 ** get_address_of__meshChannelsCache_58() { return &____meshChannelsCache_58; }
	inline void set__meshChannelsCache_58(MeshChannelsCache_t06EBFC463E3A29CBB756BB69A89D91DCCF74F633 * value)
	{
		____meshChannelsCache_58 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____meshChannelsCache_58), (void*)value);
	}

	inline static int32_t get_offset_of_empty_59() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___empty_59)); }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* get_empty_59() const { return ___empty_59; }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642** get_address_of_empty_59() { return &___empty_59; }
	inline void set_empty_59(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* value)
	{
		___empty_59 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___empty_59), (void*)value);
	}

	inline static int32_t get_offset_of_emptyIDs_60() { return static_cast<int32_t>(offsetof(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A, ___emptyIDs_60)); }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* get_emptyIDs_60() const { return ___emptyIDs_60; }
	inline Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32** get_address_of_emptyIDs_60() { return &___emptyIDs_60; }
	inline void set_emptyIDs_60(Int32U5BU5D_t70F1BDC14B1786481B176D6139A5E3B87DC54C32* value)
	{
		___emptyIDs_60 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___emptyIDs_60), (void*)value);
	}
};


// System.NotSupportedException
struct NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// DigitalOpus.MB.Core.ProgressUpdateDelegate
struct ProgressUpdateDelegate_t2D164ADF2149F0581DEC2C7F4FA179F9566DBAAE  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Renderer
struct Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
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


// DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate
struct GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9  : public MulticastDelegate_t
{
public:

public:
};


// MB3_TextureBaker/OnCombinedTexturesCoroutineSuccess
struct OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA  : public MulticastDelegate_t
{
public:

public:
};


// UnityEngine.Animation
struct Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};


// UnityEngine.MeshRenderer
struct MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B  : public Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C
{
public:

public:
};


// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};


// UnityEngine.SkinnedMeshRenderer
struct SkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496  : public Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C
{
public:

public:
};


// BakeTexturesAtRuntime
struct BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.GameObject BakeTexturesAtRuntime::target
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___target_4;
	// System.Single BakeTexturesAtRuntime::elapsedTime
	float ___elapsedTime_5;
	// DigitalOpus.MB.Core.MB3_TextureCombiner/CreateAtlasesCoroutineResult BakeTexturesAtRuntime::result
	CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * ___result_6;

public:
	inline static int32_t get_offset_of_target_4() { return static_cast<int32_t>(offsetof(BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0, ___target_4)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_target_4() const { return ___target_4; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_target_4() { return &___target_4; }
	inline void set_target_4(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___target_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___target_4), (void*)value);
	}

	inline static int32_t get_offset_of_elapsedTime_5() { return static_cast<int32_t>(offsetof(BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0, ___elapsedTime_5)); }
	inline float get_elapsedTime_5() const { return ___elapsedTime_5; }
	inline float* get_address_of_elapsedTime_5() { return &___elapsedTime_5; }
	inline void set_elapsedTime_5(float value)
	{
		___elapsedTime_5 = value;
	}

	inline static int32_t get_offset_of_result_6() { return static_cast<int32_t>(offsetof(BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0, ___result_6)); }
	inline CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * get_result_6() const { return ___result_6; }
	inline CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB ** get_address_of_result_6() { return &___result_6; }
	inline void set_result_6(CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * value)
	{
		___result_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___result_6), (void*)value);
	}
};


// MB3_MeshBakerRoot
struct MB3_MeshBakerRoot_tC0344086A800527ABB3081F4C2B5744AD1EF8384  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.Vector3 MB3_MeshBakerRoot::sortAxis
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___sortAxis_4;

public:
	inline static int32_t get_offset_of_sortAxis_4() { return static_cast<int32_t>(offsetof(MB3_MeshBakerRoot_tC0344086A800527ABB3081F4C2B5744AD1EF8384, ___sortAxis_4)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_sortAxis_4() const { return ___sortAxis_4; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_sortAxis_4() { return &___sortAxis_4; }
	inline void set_sortAxis_4(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___sortAxis_4 = value;
	}
};


// MB_BatchPrepareObjectsForDynamicBatchingDescription
struct MB_BatchPrepareObjectsForDynamicBatchingDescription_t9D997A1F37CDAE2A718380F1F0CC0A49E976F6CF  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:

public:
};


// MB_DynamicAddDeleteExample
struct MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.GameObject MB_DynamicAddDeleteExample::prefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___prefab_4;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> MB_DynamicAddDeleteExample::objsInCombined
	List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * ___objsInCombined_5;
	// MB3_MultiMeshBaker MB_DynamicAddDeleteExample::mbd
	MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * ___mbd_6;
	// UnityEngine.GameObject[] MB_DynamicAddDeleteExample::objs
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* ___objs_7;

public:
	inline static int32_t get_offset_of_prefab_4() { return static_cast<int32_t>(offsetof(MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352, ___prefab_4)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_prefab_4() const { return ___prefab_4; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_prefab_4() { return &___prefab_4; }
	inline void set_prefab_4(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___prefab_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___prefab_4), (void*)value);
	}

	inline static int32_t get_offset_of_objsInCombined_5() { return static_cast<int32_t>(offsetof(MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352, ___objsInCombined_5)); }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * get_objsInCombined_5() const { return ___objsInCombined_5; }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 ** get_address_of_objsInCombined_5() { return &___objsInCombined_5; }
	inline void set_objsInCombined_5(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * value)
	{
		___objsInCombined_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objsInCombined_5), (void*)value);
	}

	inline static int32_t get_offset_of_mbd_6() { return static_cast<int32_t>(offsetof(MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352, ___mbd_6)); }
	inline MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * get_mbd_6() const { return ___mbd_6; }
	inline MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D ** get_address_of_mbd_6() { return &___mbd_6; }
	inline void set_mbd_6(MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * value)
	{
		___mbd_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___mbd_6), (void*)value);
	}

	inline static int32_t get_offset_of_objs_7() { return static_cast<int32_t>(offsetof(MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352, ___objs_7)); }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* get_objs_7() const { return ___objs_7; }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642** get_address_of_objs_7() { return &___objs_7; }
	inline void set_objs_7(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* value)
	{
		___objs_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objs_7), (void*)value);
	}
};


// MB_Example
struct MB_Example_t2482A220673A29321053B9C6DED04A8B5F5F01DE  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// MB3_MeshBaker MB_Example::meshbaker
	MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * ___meshbaker_4;
	// UnityEngine.GameObject[] MB_Example::objsToCombine
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* ___objsToCombine_5;

public:
	inline static int32_t get_offset_of_meshbaker_4() { return static_cast<int32_t>(offsetof(MB_Example_t2482A220673A29321053B9C6DED04A8B5F5F01DE, ___meshbaker_4)); }
	inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * get_meshbaker_4() const { return ___meshbaker_4; }
	inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D ** get_address_of_meshbaker_4() { return &___meshbaker_4; }
	inline void set_meshbaker_4(MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * value)
	{
		___meshbaker_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___meshbaker_4), (void*)value);
	}

	inline static int32_t get_offset_of_objsToCombine_5() { return static_cast<int32_t>(offsetof(MB_Example_t2482A220673A29321053B9C6DED04A8B5F5F01DE, ___objsToCombine_5)); }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* get_objsToCombine_5() const { return ___objsToCombine_5; }
	inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642** get_address_of_objsToCombine_5() { return &___objsToCombine_5; }
	inline void set_objsToCombine_5(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* value)
	{
		___objsToCombine_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objsToCombine_5), (void*)value);
	}
};


// MB_ExampleMover
struct MB_ExampleMover_tE2268282AE7C1F2ABF91583A07AEB890359FE29D  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Int32 MB_ExampleMover::axis
	int32_t ___axis_4;

public:
	inline static int32_t get_offset_of_axis_4() { return static_cast<int32_t>(offsetof(MB_ExampleMover_tE2268282AE7C1F2ABF91583A07AEB890359FE29D, ___axis_4)); }
	inline int32_t get_axis_4() const { return ___axis_4; }
	inline int32_t* get_address_of_axis_4() { return &___axis_4; }
	inline void set_axis_4(int32_t value)
	{
		___axis_4 = value;
	}
};


// MB_ExampleSkinnedMeshDescription
struct MB_ExampleSkinnedMeshDescription_tFB02696EFBA31EAD5321A0212F961B2698FC0CF4  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:

public:
};


// MB_MigrateMaterialsToDifferentPipeline
struct MB_MigrateMaterialsToDifferentPipeline_t595685F82E94A09D39B4A9215AB3D547905D242B  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:

public:
};


// MB_PrepareObjectsForDynamicBatchingDescription
struct MB_PrepareObjectsForDynamicBatchingDescription_t7E6322CFBF49D134B355E9347B8B4FB734E487DF  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:

public:
};


// MB_SkinnedMeshSceneController
struct MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.GameObject MB_SkinnedMeshSceneController::swordPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___swordPrefab_4;
	// UnityEngine.GameObject MB_SkinnedMeshSceneController::hatPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___hatPrefab_5;
	// UnityEngine.GameObject MB_SkinnedMeshSceneController::glassesPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___glassesPrefab_6;
	// UnityEngine.GameObject MB_SkinnedMeshSceneController::workerPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___workerPrefab_7;
	// UnityEngine.GameObject MB_SkinnedMeshSceneController::targetCharacter
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___targetCharacter_8;
	// MB3_MeshBaker MB_SkinnedMeshSceneController::skinnedMeshBaker
	MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * ___skinnedMeshBaker_9;
	// UnityEngine.GameObject MB_SkinnedMeshSceneController::swordInstance
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___swordInstance_10;
	// UnityEngine.GameObject MB_SkinnedMeshSceneController::glassesInstance
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___glassesInstance_11;
	// UnityEngine.GameObject MB_SkinnedMeshSceneController::hatInstance
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___hatInstance_12;

public:
	inline static int32_t get_offset_of_swordPrefab_4() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___swordPrefab_4)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_swordPrefab_4() const { return ___swordPrefab_4; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_swordPrefab_4() { return &___swordPrefab_4; }
	inline void set_swordPrefab_4(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___swordPrefab_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___swordPrefab_4), (void*)value);
	}

	inline static int32_t get_offset_of_hatPrefab_5() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___hatPrefab_5)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_hatPrefab_5() const { return ___hatPrefab_5; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_hatPrefab_5() { return &___hatPrefab_5; }
	inline void set_hatPrefab_5(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___hatPrefab_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___hatPrefab_5), (void*)value);
	}

	inline static int32_t get_offset_of_glassesPrefab_6() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___glassesPrefab_6)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_glassesPrefab_6() const { return ___glassesPrefab_6; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_glassesPrefab_6() { return &___glassesPrefab_6; }
	inline void set_glassesPrefab_6(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___glassesPrefab_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___glassesPrefab_6), (void*)value);
	}

	inline static int32_t get_offset_of_workerPrefab_7() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___workerPrefab_7)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_workerPrefab_7() const { return ___workerPrefab_7; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_workerPrefab_7() { return &___workerPrefab_7; }
	inline void set_workerPrefab_7(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___workerPrefab_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___workerPrefab_7), (void*)value);
	}

	inline static int32_t get_offset_of_targetCharacter_8() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___targetCharacter_8)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_targetCharacter_8() const { return ___targetCharacter_8; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_targetCharacter_8() { return &___targetCharacter_8; }
	inline void set_targetCharacter_8(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___targetCharacter_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetCharacter_8), (void*)value);
	}

	inline static int32_t get_offset_of_skinnedMeshBaker_9() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___skinnedMeshBaker_9)); }
	inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * get_skinnedMeshBaker_9() const { return ___skinnedMeshBaker_9; }
	inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D ** get_address_of_skinnedMeshBaker_9() { return &___skinnedMeshBaker_9; }
	inline void set_skinnedMeshBaker_9(MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * value)
	{
		___skinnedMeshBaker_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___skinnedMeshBaker_9), (void*)value);
	}

	inline static int32_t get_offset_of_swordInstance_10() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___swordInstance_10)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_swordInstance_10() const { return ___swordInstance_10; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_swordInstance_10() { return &___swordInstance_10; }
	inline void set_swordInstance_10(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___swordInstance_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___swordInstance_10), (void*)value);
	}

	inline static int32_t get_offset_of_glassesInstance_11() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___glassesInstance_11)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_glassesInstance_11() const { return ___glassesInstance_11; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_glassesInstance_11() { return &___glassesInstance_11; }
	inline void set_glassesInstance_11(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___glassesInstance_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___glassesInstance_11), (void*)value);
	}

	inline static int32_t get_offset_of_hatInstance_12() { return static_cast<int32_t>(offsetof(MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711, ___hatInstance_12)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_hatInstance_12() const { return ___hatInstance_12; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_hatInstance_12() { return &___hatInstance_12; }
	inline void set_hatInstance_12(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___hatInstance_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___hatInstance_12), (void*)value);
	}
};


// MB_SwapShirts
struct MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// MB3_MeshBaker MB_SwapShirts::meshBaker
	MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * ___meshBaker_4;
	// UnityEngine.Renderer[] MB_SwapShirts::clothingAndBodyPartsBareTorso
	RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* ___clothingAndBodyPartsBareTorso_5;
	// UnityEngine.Renderer[] MB_SwapShirts::clothingAndBodyPartsBareTorsoDamagedArm
	RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* ___clothingAndBodyPartsBareTorsoDamagedArm_6;
	// UnityEngine.Renderer[] MB_SwapShirts::clothingAndBodyPartsHoodie
	RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* ___clothingAndBodyPartsHoodie_7;

public:
	inline static int32_t get_offset_of_meshBaker_4() { return static_cast<int32_t>(offsetof(MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A, ___meshBaker_4)); }
	inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * get_meshBaker_4() const { return ___meshBaker_4; }
	inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D ** get_address_of_meshBaker_4() { return &___meshBaker_4; }
	inline void set_meshBaker_4(MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * value)
	{
		___meshBaker_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___meshBaker_4), (void*)value);
	}

	inline static int32_t get_offset_of_clothingAndBodyPartsBareTorso_5() { return static_cast<int32_t>(offsetof(MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A, ___clothingAndBodyPartsBareTorso_5)); }
	inline RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* get_clothingAndBodyPartsBareTorso_5() const { return ___clothingAndBodyPartsBareTorso_5; }
	inline RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7** get_address_of_clothingAndBodyPartsBareTorso_5() { return &___clothingAndBodyPartsBareTorso_5; }
	inline void set_clothingAndBodyPartsBareTorso_5(RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* value)
	{
		___clothingAndBodyPartsBareTorso_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___clothingAndBodyPartsBareTorso_5), (void*)value);
	}

	inline static int32_t get_offset_of_clothingAndBodyPartsBareTorsoDamagedArm_6() { return static_cast<int32_t>(offsetof(MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A, ___clothingAndBodyPartsBareTorsoDamagedArm_6)); }
	inline RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* get_clothingAndBodyPartsBareTorsoDamagedArm_6() const { return ___clothingAndBodyPartsBareTorsoDamagedArm_6; }
	inline RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7** get_address_of_clothingAndBodyPartsBareTorsoDamagedArm_6() { return &___clothingAndBodyPartsBareTorsoDamagedArm_6; }
	inline void set_clothingAndBodyPartsBareTorsoDamagedArm_6(RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* value)
	{
		___clothingAndBodyPartsBareTorsoDamagedArm_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___clothingAndBodyPartsBareTorsoDamagedArm_6), (void*)value);
	}

	inline static int32_t get_offset_of_clothingAndBodyPartsHoodie_7() { return static_cast<int32_t>(offsetof(MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A, ___clothingAndBodyPartsHoodie_7)); }
	inline RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* get_clothingAndBodyPartsHoodie_7() const { return ___clothingAndBodyPartsHoodie_7; }
	inline RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7** get_address_of_clothingAndBodyPartsHoodie_7() { return &___clothingAndBodyPartsHoodie_7; }
	inline void set_clothingAndBodyPartsHoodie_7(RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* value)
	{
		___clothingAndBodyPartsHoodie_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___clothingAndBodyPartsHoodie_7), (void*)value);
	}
};


// MB_SwitchBakedObjectsTexture
struct MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.MeshRenderer MB_SwitchBakedObjectsTexture::targetRenderer
	MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * ___targetRenderer_4;
	// UnityEngine.Material[] MB_SwitchBakedObjectsTexture::materials
	MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492* ___materials_5;
	// MB3_MeshBaker MB_SwitchBakedObjectsTexture::meshBaker
	MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * ___meshBaker_6;

public:
	inline static int32_t get_offset_of_targetRenderer_4() { return static_cast<int32_t>(offsetof(MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2, ___targetRenderer_4)); }
	inline MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * get_targetRenderer_4() const { return ___targetRenderer_4; }
	inline MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B ** get_address_of_targetRenderer_4() { return &___targetRenderer_4; }
	inline void set_targetRenderer_4(MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * value)
	{
		___targetRenderer_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___targetRenderer_4), (void*)value);
	}

	inline static int32_t get_offset_of_materials_5() { return static_cast<int32_t>(offsetof(MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2, ___materials_5)); }
	inline MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492* get_materials_5() const { return ___materials_5; }
	inline MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492** get_address_of_materials_5() { return &___materials_5; }
	inline void set_materials_5(MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492* value)
	{
		___materials_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___materials_5), (void*)value);
	}

	inline static int32_t get_offset_of_meshBaker_6() { return static_cast<int32_t>(offsetof(MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2, ___meshBaker_6)); }
	inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * get_meshBaker_6() const { return ___meshBaker_6; }
	inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D ** get_address_of_meshBaker_6() { return &___meshBaker_6; }
	inline void set_meshBaker_6(MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * value)
	{
		___meshBaker_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___meshBaker_6), (void*)value);
	}
};


// MB3_MeshBakerCommon
struct MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19  : public MB3_MeshBakerRoot_tC0344086A800527ABB3081F4C2B5744AD1EF8384
{
public:
	// System.Int32 MB3_MeshBakerCommon::version
	int32_t ___version_5;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> MB3_MeshBakerCommon::objsToMesh
	List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * ___objsToMesh_6;
	// System.Boolean MB3_MeshBakerCommon::useObjsToMeshFromTexBaker
	bool ___useObjsToMeshFromTexBaker_7;
	// System.Boolean MB3_MeshBakerCommon::_clearBuffersAfterBake
	bool ____clearBuffersAfterBake_8;
	// System.String MB3_MeshBakerCommon::bakeAssetsInPlaceFolderPath
	String_t* ___bakeAssetsInPlaceFolderPath_9;
	// UnityEngine.GameObject MB3_MeshBakerCommon::resultPrefab
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___resultPrefab_10;
	// System.Boolean MB3_MeshBakerCommon::resultPrefabLeaveInstanceInSceneAfterBake
	bool ___resultPrefabLeaveInstanceInSceneAfterBake_11;
	// UnityEngine.Transform MB3_MeshBakerCommon::parentSceneObject
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___parentSceneObject_12;

public:
	inline static int32_t get_offset_of_version_5() { return static_cast<int32_t>(offsetof(MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19, ___version_5)); }
	inline int32_t get_version_5() const { return ___version_5; }
	inline int32_t* get_address_of_version_5() { return &___version_5; }
	inline void set_version_5(int32_t value)
	{
		___version_5 = value;
	}

	inline static int32_t get_offset_of_objsToMesh_6() { return static_cast<int32_t>(offsetof(MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19, ___objsToMesh_6)); }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * get_objsToMesh_6() const { return ___objsToMesh_6; }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 ** get_address_of_objsToMesh_6() { return &___objsToMesh_6; }
	inline void set_objsToMesh_6(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * value)
	{
		___objsToMesh_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objsToMesh_6), (void*)value);
	}

	inline static int32_t get_offset_of_useObjsToMeshFromTexBaker_7() { return static_cast<int32_t>(offsetof(MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19, ___useObjsToMeshFromTexBaker_7)); }
	inline bool get_useObjsToMeshFromTexBaker_7() const { return ___useObjsToMeshFromTexBaker_7; }
	inline bool* get_address_of_useObjsToMeshFromTexBaker_7() { return &___useObjsToMeshFromTexBaker_7; }
	inline void set_useObjsToMeshFromTexBaker_7(bool value)
	{
		___useObjsToMeshFromTexBaker_7 = value;
	}

	inline static int32_t get_offset_of__clearBuffersAfterBake_8() { return static_cast<int32_t>(offsetof(MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19, ____clearBuffersAfterBake_8)); }
	inline bool get__clearBuffersAfterBake_8() const { return ____clearBuffersAfterBake_8; }
	inline bool* get_address_of__clearBuffersAfterBake_8() { return &____clearBuffersAfterBake_8; }
	inline void set__clearBuffersAfterBake_8(bool value)
	{
		____clearBuffersAfterBake_8 = value;
	}

	inline static int32_t get_offset_of_bakeAssetsInPlaceFolderPath_9() { return static_cast<int32_t>(offsetof(MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19, ___bakeAssetsInPlaceFolderPath_9)); }
	inline String_t* get_bakeAssetsInPlaceFolderPath_9() const { return ___bakeAssetsInPlaceFolderPath_9; }
	inline String_t** get_address_of_bakeAssetsInPlaceFolderPath_9() { return &___bakeAssetsInPlaceFolderPath_9; }
	inline void set_bakeAssetsInPlaceFolderPath_9(String_t* value)
	{
		___bakeAssetsInPlaceFolderPath_9 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___bakeAssetsInPlaceFolderPath_9), (void*)value);
	}

	inline static int32_t get_offset_of_resultPrefab_10() { return static_cast<int32_t>(offsetof(MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19, ___resultPrefab_10)); }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * get_resultPrefab_10() const { return ___resultPrefab_10; }
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** get_address_of_resultPrefab_10() { return &___resultPrefab_10; }
	inline void set_resultPrefab_10(GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		___resultPrefab_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___resultPrefab_10), (void*)value);
	}

	inline static int32_t get_offset_of_resultPrefabLeaveInstanceInSceneAfterBake_11() { return static_cast<int32_t>(offsetof(MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19, ___resultPrefabLeaveInstanceInSceneAfterBake_11)); }
	inline bool get_resultPrefabLeaveInstanceInSceneAfterBake_11() const { return ___resultPrefabLeaveInstanceInSceneAfterBake_11; }
	inline bool* get_address_of_resultPrefabLeaveInstanceInSceneAfterBake_11() { return &___resultPrefabLeaveInstanceInSceneAfterBake_11; }
	inline void set_resultPrefabLeaveInstanceInSceneAfterBake_11(bool value)
	{
		___resultPrefabLeaveInstanceInSceneAfterBake_11 = value;
	}

	inline static int32_t get_offset_of_parentSceneObject_12() { return static_cast<int32_t>(offsetof(MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19, ___parentSceneObject_12)); }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * get_parentSceneObject_12() const { return ___parentSceneObject_12; }
	inline Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 ** get_address_of_parentSceneObject_12() { return &___parentSceneObject_12; }
	inline void set_parentSceneObject_12(Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * value)
	{
		___parentSceneObject_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___parentSceneObject_12), (void*)value);
	}
};


// MB3_TextureBaker
struct MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E  : public MB3_MeshBakerRoot_tC0344086A800527ABB3081F4C2B5744AD1EF8384
{
public:
	// DigitalOpus.MB.Core.MB2_LogLevel MB3_TextureBaker::LOG_LEVEL
	int32_t ___LOG_LEVEL_5;
	// MB2_TextureBakeResults MB3_TextureBaker::_textureBakeResults
	MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * ____textureBakeResults_6;
	// System.Int32 MB3_TextureBaker::_atlasPadding
	int32_t ____atlasPadding_7;
	// System.Int32 MB3_TextureBaker::_maxAtlasSize
	int32_t ____maxAtlasSize_8;
	// System.Boolean MB3_TextureBaker::_useMaxAtlasWidthOverride
	bool ____useMaxAtlasWidthOverride_9;
	// System.Int32 MB3_TextureBaker::_maxAtlasWidthOverride
	int32_t ____maxAtlasWidthOverride_10;
	// System.Boolean MB3_TextureBaker::_useMaxAtlasHeightOverride
	bool ____useMaxAtlasHeightOverride_11;
	// System.Int32 MB3_TextureBaker::_maxAtlasHeightOverride
	int32_t ____maxAtlasHeightOverride_12;
	// System.Boolean MB3_TextureBaker::_resizePowerOfTwoTextures
	bool ____resizePowerOfTwoTextures_13;
	// System.Boolean MB3_TextureBaker::_fixOutOfBoundsUVs
	bool ____fixOutOfBoundsUVs_14;
	// System.Int32 MB3_TextureBaker::_maxTilingBakeSize
	int32_t ____maxTilingBakeSize_15;
	// DigitalOpus.MB.Core.MB2_PackingAlgorithmEnum MB3_TextureBaker::_packingAlgorithm
	int32_t ____packingAlgorithm_16;
	// System.Int32 MB3_TextureBaker::_layerTexturePackerFastMesh
	int32_t ____layerTexturePackerFastMesh_17;
	// System.Boolean MB3_TextureBaker::_meshBakerTexturePackerForcePowerOfTwo
	bool ____meshBakerTexturePackerForcePowerOfTwo_18;
	// System.Collections.Generic.List`1<DigitalOpus.MB.Core.ShaderTextureProperty> MB3_TextureBaker::_customShaderProperties
	List_1_t875987ABEC7A87063EA5CF3947DAE9FA48A0284D * ____customShaderProperties_19;
	// System.Collections.Generic.List`1<System.String> MB3_TextureBaker::_texturePropNamesToIgnore
	List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * ____texturePropNamesToIgnore_20;
	// System.Collections.Generic.List`1<System.String> MB3_TextureBaker::_customShaderPropNames_Depricated
	List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * ____customShaderPropNames_Depricated_21;
	// MB2_TextureBakeResults/ResultType MB3_TextureBaker::_resultType
	int32_t ____resultType_22;
	// System.Boolean MB3_TextureBaker::_doMultiMaterial
	bool ____doMultiMaterial_23;
	// System.Boolean MB3_TextureBaker::_doMultiMaterialSplitAtlasesIfTooBig
	bool ____doMultiMaterialSplitAtlasesIfTooBig_24;
	// System.Boolean MB3_TextureBaker::_doMultiMaterialSplitAtlasesIfOBUVs
	bool ____doMultiMaterialSplitAtlasesIfOBUVs_25;
	// UnityEngine.Material MB3_TextureBaker::_resultMaterial
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ____resultMaterial_26;
	// System.Boolean MB3_TextureBaker::_considerNonTextureProperties
	bool ____considerNonTextureProperties_27;
	// System.Boolean MB3_TextureBaker::_doSuggestTreatment
	bool ____doSuggestTreatment_28;
	// DigitalOpus.MB.Core.MB3_TextureCombiner/CreateAtlasesCoroutineResult MB3_TextureBaker::_coroutineResult
	CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * ____coroutineResult_29;
	// MB_MultiMaterial[] MB3_TextureBaker::resultMaterials
	MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C* ___resultMaterials_30;
	// MB_MultiMaterialTexArray[] MB3_TextureBaker::resultMaterialsTexArray
	MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E* ___resultMaterialsTexArray_31;
	// MB_TextureArrayFormatSet[] MB3_TextureBaker::textureArrayOutputFormats
	MB_TextureArrayFormatSetU5BU5D_tACA344ABBD1E4E010BCAD10396752EF4473007E4* ___textureArrayOutputFormats_32;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> MB3_TextureBaker::objsToMesh
	List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * ___objsToMesh_33;
	// MB3_TextureBaker/OnCombinedTexturesCoroutineSuccess MB3_TextureBaker::onBuiltAtlasesSuccess
	OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA * ___onBuiltAtlasesSuccess_34;
	// MB3_TextureBaker/OnCombinedTexturesCoroutineFail MB3_TextureBaker::onBuiltAtlasesFail
	OnCombinedTexturesCoroutineFail_tC2BCA7F277426A929A0DE369D1A40285A18AB7A5 * ___onBuiltAtlasesFail_35;
	// MB_AtlasesAndRects[] MB3_TextureBaker::OnCombinedTexturesCoroutineAtlasesAndRects
	MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7* ___OnCombinedTexturesCoroutineAtlasesAndRects_36;

public:
	inline static int32_t get_offset_of_LOG_LEVEL_5() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ___LOG_LEVEL_5)); }
	inline int32_t get_LOG_LEVEL_5() const { return ___LOG_LEVEL_5; }
	inline int32_t* get_address_of_LOG_LEVEL_5() { return &___LOG_LEVEL_5; }
	inline void set_LOG_LEVEL_5(int32_t value)
	{
		___LOG_LEVEL_5 = value;
	}

	inline static int32_t get_offset_of__textureBakeResults_6() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____textureBakeResults_6)); }
	inline MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * get__textureBakeResults_6() const { return ____textureBakeResults_6; }
	inline MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC ** get_address_of__textureBakeResults_6() { return &____textureBakeResults_6; }
	inline void set__textureBakeResults_6(MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * value)
	{
		____textureBakeResults_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____textureBakeResults_6), (void*)value);
	}

	inline static int32_t get_offset_of__atlasPadding_7() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____atlasPadding_7)); }
	inline int32_t get__atlasPadding_7() const { return ____atlasPadding_7; }
	inline int32_t* get_address_of__atlasPadding_7() { return &____atlasPadding_7; }
	inline void set__atlasPadding_7(int32_t value)
	{
		____atlasPadding_7 = value;
	}

	inline static int32_t get_offset_of__maxAtlasSize_8() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____maxAtlasSize_8)); }
	inline int32_t get__maxAtlasSize_8() const { return ____maxAtlasSize_8; }
	inline int32_t* get_address_of__maxAtlasSize_8() { return &____maxAtlasSize_8; }
	inline void set__maxAtlasSize_8(int32_t value)
	{
		____maxAtlasSize_8 = value;
	}

	inline static int32_t get_offset_of__useMaxAtlasWidthOverride_9() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____useMaxAtlasWidthOverride_9)); }
	inline bool get__useMaxAtlasWidthOverride_9() const { return ____useMaxAtlasWidthOverride_9; }
	inline bool* get_address_of__useMaxAtlasWidthOverride_9() { return &____useMaxAtlasWidthOverride_9; }
	inline void set__useMaxAtlasWidthOverride_9(bool value)
	{
		____useMaxAtlasWidthOverride_9 = value;
	}

	inline static int32_t get_offset_of__maxAtlasWidthOverride_10() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____maxAtlasWidthOverride_10)); }
	inline int32_t get__maxAtlasWidthOverride_10() const { return ____maxAtlasWidthOverride_10; }
	inline int32_t* get_address_of__maxAtlasWidthOverride_10() { return &____maxAtlasWidthOverride_10; }
	inline void set__maxAtlasWidthOverride_10(int32_t value)
	{
		____maxAtlasWidthOverride_10 = value;
	}

	inline static int32_t get_offset_of__useMaxAtlasHeightOverride_11() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____useMaxAtlasHeightOverride_11)); }
	inline bool get__useMaxAtlasHeightOverride_11() const { return ____useMaxAtlasHeightOverride_11; }
	inline bool* get_address_of__useMaxAtlasHeightOverride_11() { return &____useMaxAtlasHeightOverride_11; }
	inline void set__useMaxAtlasHeightOverride_11(bool value)
	{
		____useMaxAtlasHeightOverride_11 = value;
	}

	inline static int32_t get_offset_of__maxAtlasHeightOverride_12() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____maxAtlasHeightOverride_12)); }
	inline int32_t get__maxAtlasHeightOverride_12() const { return ____maxAtlasHeightOverride_12; }
	inline int32_t* get_address_of__maxAtlasHeightOverride_12() { return &____maxAtlasHeightOverride_12; }
	inline void set__maxAtlasHeightOverride_12(int32_t value)
	{
		____maxAtlasHeightOverride_12 = value;
	}

	inline static int32_t get_offset_of__resizePowerOfTwoTextures_13() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____resizePowerOfTwoTextures_13)); }
	inline bool get__resizePowerOfTwoTextures_13() const { return ____resizePowerOfTwoTextures_13; }
	inline bool* get_address_of__resizePowerOfTwoTextures_13() { return &____resizePowerOfTwoTextures_13; }
	inline void set__resizePowerOfTwoTextures_13(bool value)
	{
		____resizePowerOfTwoTextures_13 = value;
	}

	inline static int32_t get_offset_of__fixOutOfBoundsUVs_14() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____fixOutOfBoundsUVs_14)); }
	inline bool get__fixOutOfBoundsUVs_14() const { return ____fixOutOfBoundsUVs_14; }
	inline bool* get_address_of__fixOutOfBoundsUVs_14() { return &____fixOutOfBoundsUVs_14; }
	inline void set__fixOutOfBoundsUVs_14(bool value)
	{
		____fixOutOfBoundsUVs_14 = value;
	}

	inline static int32_t get_offset_of__maxTilingBakeSize_15() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____maxTilingBakeSize_15)); }
	inline int32_t get__maxTilingBakeSize_15() const { return ____maxTilingBakeSize_15; }
	inline int32_t* get_address_of__maxTilingBakeSize_15() { return &____maxTilingBakeSize_15; }
	inline void set__maxTilingBakeSize_15(int32_t value)
	{
		____maxTilingBakeSize_15 = value;
	}

	inline static int32_t get_offset_of__packingAlgorithm_16() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____packingAlgorithm_16)); }
	inline int32_t get__packingAlgorithm_16() const { return ____packingAlgorithm_16; }
	inline int32_t* get_address_of__packingAlgorithm_16() { return &____packingAlgorithm_16; }
	inline void set__packingAlgorithm_16(int32_t value)
	{
		____packingAlgorithm_16 = value;
	}

	inline static int32_t get_offset_of__layerTexturePackerFastMesh_17() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____layerTexturePackerFastMesh_17)); }
	inline int32_t get__layerTexturePackerFastMesh_17() const { return ____layerTexturePackerFastMesh_17; }
	inline int32_t* get_address_of__layerTexturePackerFastMesh_17() { return &____layerTexturePackerFastMesh_17; }
	inline void set__layerTexturePackerFastMesh_17(int32_t value)
	{
		____layerTexturePackerFastMesh_17 = value;
	}

	inline static int32_t get_offset_of__meshBakerTexturePackerForcePowerOfTwo_18() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____meshBakerTexturePackerForcePowerOfTwo_18)); }
	inline bool get__meshBakerTexturePackerForcePowerOfTwo_18() const { return ____meshBakerTexturePackerForcePowerOfTwo_18; }
	inline bool* get_address_of__meshBakerTexturePackerForcePowerOfTwo_18() { return &____meshBakerTexturePackerForcePowerOfTwo_18; }
	inline void set__meshBakerTexturePackerForcePowerOfTwo_18(bool value)
	{
		____meshBakerTexturePackerForcePowerOfTwo_18 = value;
	}

	inline static int32_t get_offset_of__customShaderProperties_19() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____customShaderProperties_19)); }
	inline List_1_t875987ABEC7A87063EA5CF3947DAE9FA48A0284D * get__customShaderProperties_19() const { return ____customShaderProperties_19; }
	inline List_1_t875987ABEC7A87063EA5CF3947DAE9FA48A0284D ** get_address_of__customShaderProperties_19() { return &____customShaderProperties_19; }
	inline void set__customShaderProperties_19(List_1_t875987ABEC7A87063EA5CF3947DAE9FA48A0284D * value)
	{
		____customShaderProperties_19 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____customShaderProperties_19), (void*)value);
	}

	inline static int32_t get_offset_of__texturePropNamesToIgnore_20() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____texturePropNamesToIgnore_20)); }
	inline List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * get__texturePropNamesToIgnore_20() const { return ____texturePropNamesToIgnore_20; }
	inline List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 ** get_address_of__texturePropNamesToIgnore_20() { return &____texturePropNamesToIgnore_20; }
	inline void set__texturePropNamesToIgnore_20(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * value)
	{
		____texturePropNamesToIgnore_20 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____texturePropNamesToIgnore_20), (void*)value);
	}

	inline static int32_t get_offset_of__customShaderPropNames_Depricated_21() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____customShaderPropNames_Depricated_21)); }
	inline List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * get__customShaderPropNames_Depricated_21() const { return ____customShaderPropNames_Depricated_21; }
	inline List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 ** get_address_of__customShaderPropNames_Depricated_21() { return &____customShaderPropNames_Depricated_21; }
	inline void set__customShaderPropNames_Depricated_21(List_1_t6C9F81EDBF0F4A31A9B0DA372D2EF34BDA3A1AF3 * value)
	{
		____customShaderPropNames_Depricated_21 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____customShaderPropNames_Depricated_21), (void*)value);
	}

	inline static int32_t get_offset_of__resultType_22() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____resultType_22)); }
	inline int32_t get__resultType_22() const { return ____resultType_22; }
	inline int32_t* get_address_of__resultType_22() { return &____resultType_22; }
	inline void set__resultType_22(int32_t value)
	{
		____resultType_22 = value;
	}

	inline static int32_t get_offset_of__doMultiMaterial_23() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____doMultiMaterial_23)); }
	inline bool get__doMultiMaterial_23() const { return ____doMultiMaterial_23; }
	inline bool* get_address_of__doMultiMaterial_23() { return &____doMultiMaterial_23; }
	inline void set__doMultiMaterial_23(bool value)
	{
		____doMultiMaterial_23 = value;
	}

	inline static int32_t get_offset_of__doMultiMaterialSplitAtlasesIfTooBig_24() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____doMultiMaterialSplitAtlasesIfTooBig_24)); }
	inline bool get__doMultiMaterialSplitAtlasesIfTooBig_24() const { return ____doMultiMaterialSplitAtlasesIfTooBig_24; }
	inline bool* get_address_of__doMultiMaterialSplitAtlasesIfTooBig_24() { return &____doMultiMaterialSplitAtlasesIfTooBig_24; }
	inline void set__doMultiMaterialSplitAtlasesIfTooBig_24(bool value)
	{
		____doMultiMaterialSplitAtlasesIfTooBig_24 = value;
	}

	inline static int32_t get_offset_of__doMultiMaterialSplitAtlasesIfOBUVs_25() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____doMultiMaterialSplitAtlasesIfOBUVs_25)); }
	inline bool get__doMultiMaterialSplitAtlasesIfOBUVs_25() const { return ____doMultiMaterialSplitAtlasesIfOBUVs_25; }
	inline bool* get_address_of__doMultiMaterialSplitAtlasesIfOBUVs_25() { return &____doMultiMaterialSplitAtlasesIfOBUVs_25; }
	inline void set__doMultiMaterialSplitAtlasesIfOBUVs_25(bool value)
	{
		____doMultiMaterialSplitAtlasesIfOBUVs_25 = value;
	}

	inline static int32_t get_offset_of__resultMaterial_26() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____resultMaterial_26)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get__resultMaterial_26() const { return ____resultMaterial_26; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of__resultMaterial_26() { return &____resultMaterial_26; }
	inline void set__resultMaterial_26(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		____resultMaterial_26 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____resultMaterial_26), (void*)value);
	}

	inline static int32_t get_offset_of__considerNonTextureProperties_27() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____considerNonTextureProperties_27)); }
	inline bool get__considerNonTextureProperties_27() const { return ____considerNonTextureProperties_27; }
	inline bool* get_address_of__considerNonTextureProperties_27() { return &____considerNonTextureProperties_27; }
	inline void set__considerNonTextureProperties_27(bool value)
	{
		____considerNonTextureProperties_27 = value;
	}

	inline static int32_t get_offset_of__doSuggestTreatment_28() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____doSuggestTreatment_28)); }
	inline bool get__doSuggestTreatment_28() const { return ____doSuggestTreatment_28; }
	inline bool* get_address_of__doSuggestTreatment_28() { return &____doSuggestTreatment_28; }
	inline void set__doSuggestTreatment_28(bool value)
	{
		____doSuggestTreatment_28 = value;
	}

	inline static int32_t get_offset_of__coroutineResult_29() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ____coroutineResult_29)); }
	inline CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * get__coroutineResult_29() const { return ____coroutineResult_29; }
	inline CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB ** get_address_of__coroutineResult_29() { return &____coroutineResult_29; }
	inline void set__coroutineResult_29(CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * value)
	{
		____coroutineResult_29 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____coroutineResult_29), (void*)value);
	}

	inline static int32_t get_offset_of_resultMaterials_30() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ___resultMaterials_30)); }
	inline MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C* get_resultMaterials_30() const { return ___resultMaterials_30; }
	inline MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C** get_address_of_resultMaterials_30() { return &___resultMaterials_30; }
	inline void set_resultMaterials_30(MB_MultiMaterialU5BU5D_tD0D35FA30A1016BB30C44338E9D9F3B12B0E520C* value)
	{
		___resultMaterials_30 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___resultMaterials_30), (void*)value);
	}

	inline static int32_t get_offset_of_resultMaterialsTexArray_31() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ___resultMaterialsTexArray_31)); }
	inline MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E* get_resultMaterialsTexArray_31() const { return ___resultMaterialsTexArray_31; }
	inline MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E** get_address_of_resultMaterialsTexArray_31() { return &___resultMaterialsTexArray_31; }
	inline void set_resultMaterialsTexArray_31(MB_MultiMaterialTexArrayU5BU5D_t5E6F96D72C71BB789EFF767E2AD0972AB834DF1E* value)
	{
		___resultMaterialsTexArray_31 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___resultMaterialsTexArray_31), (void*)value);
	}

	inline static int32_t get_offset_of_textureArrayOutputFormats_32() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ___textureArrayOutputFormats_32)); }
	inline MB_TextureArrayFormatSetU5BU5D_tACA344ABBD1E4E010BCAD10396752EF4473007E4* get_textureArrayOutputFormats_32() const { return ___textureArrayOutputFormats_32; }
	inline MB_TextureArrayFormatSetU5BU5D_tACA344ABBD1E4E010BCAD10396752EF4473007E4** get_address_of_textureArrayOutputFormats_32() { return &___textureArrayOutputFormats_32; }
	inline void set_textureArrayOutputFormats_32(MB_TextureArrayFormatSetU5BU5D_tACA344ABBD1E4E010BCAD10396752EF4473007E4* value)
	{
		___textureArrayOutputFormats_32 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___textureArrayOutputFormats_32), (void*)value);
	}

	inline static int32_t get_offset_of_objsToMesh_33() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ___objsToMesh_33)); }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * get_objsToMesh_33() const { return ___objsToMesh_33; }
	inline List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 ** get_address_of_objsToMesh_33() { return &___objsToMesh_33; }
	inline void set_objsToMesh_33(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * value)
	{
		___objsToMesh_33 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___objsToMesh_33), (void*)value);
	}

	inline static int32_t get_offset_of_onBuiltAtlasesSuccess_34() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ___onBuiltAtlasesSuccess_34)); }
	inline OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA * get_onBuiltAtlasesSuccess_34() const { return ___onBuiltAtlasesSuccess_34; }
	inline OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA ** get_address_of_onBuiltAtlasesSuccess_34() { return &___onBuiltAtlasesSuccess_34; }
	inline void set_onBuiltAtlasesSuccess_34(OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA * value)
	{
		___onBuiltAtlasesSuccess_34 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onBuiltAtlasesSuccess_34), (void*)value);
	}

	inline static int32_t get_offset_of_onBuiltAtlasesFail_35() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ___onBuiltAtlasesFail_35)); }
	inline OnCombinedTexturesCoroutineFail_tC2BCA7F277426A929A0DE369D1A40285A18AB7A5 * get_onBuiltAtlasesFail_35() const { return ___onBuiltAtlasesFail_35; }
	inline OnCombinedTexturesCoroutineFail_tC2BCA7F277426A929A0DE369D1A40285A18AB7A5 ** get_address_of_onBuiltAtlasesFail_35() { return &___onBuiltAtlasesFail_35; }
	inline void set_onBuiltAtlasesFail_35(OnCombinedTexturesCoroutineFail_tC2BCA7F277426A929A0DE369D1A40285A18AB7A5 * value)
	{
		___onBuiltAtlasesFail_35 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___onBuiltAtlasesFail_35), (void*)value);
	}

	inline static int32_t get_offset_of_OnCombinedTexturesCoroutineAtlasesAndRects_36() { return static_cast<int32_t>(offsetof(MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E, ___OnCombinedTexturesCoroutineAtlasesAndRects_36)); }
	inline MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7* get_OnCombinedTexturesCoroutineAtlasesAndRects_36() const { return ___OnCombinedTexturesCoroutineAtlasesAndRects_36; }
	inline MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7** get_address_of_OnCombinedTexturesCoroutineAtlasesAndRects_36() { return &___OnCombinedTexturesCoroutineAtlasesAndRects_36; }
	inline void set_OnCombinedTexturesCoroutineAtlasesAndRects_36(MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7* value)
	{
		___OnCombinedTexturesCoroutineAtlasesAndRects_36 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnCombinedTexturesCoroutineAtlasesAndRects_36), (void*)value);
	}
};


// MB3_MeshBaker
struct MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D  : public MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19
{
public:
	// DigitalOpus.MB.Core.MB3_MeshCombinerSingle MB3_MeshBaker::_meshCombiner
	MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A * ____meshCombiner_13;

public:
	inline static int32_t get_offset_of__meshCombiner_13() { return static_cast<int32_t>(offsetof(MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D, ____meshCombiner_13)); }
	inline MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A * get__meshCombiner_13() const { return ____meshCombiner_13; }
	inline MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A ** get_address_of__meshCombiner_13() { return &____meshCombiner_13; }
	inline void set__meshCombiner_13(MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A * value)
	{
		____meshCombiner_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____meshCombiner_13), (void*)value);
	}
};


// MB3_MultiMeshBaker
struct MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D  : public MB3_MeshBakerCommon_t12DD9D611518227894CA194E9FABD606E3820D19
{
public:
	// DigitalOpus.MB.Core.MB3_MultiMeshCombiner MB3_MultiMeshBaker::_meshCombiner
	MB3_MultiMeshCombiner_t7CB3D4CCC9CFF1D0DA1C602351C8A2974AC39498 * ____meshCombiner_13;

public:
	inline static int32_t get_offset_of__meshCombiner_13() { return static_cast<int32_t>(offsetof(MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D, ____meshCombiner_13)); }
	inline MB3_MultiMeshCombiner_t7CB3D4CCC9CFF1D0DA1C602351C8A2974AC39498 * get__meshCombiner_13() const { return ____meshCombiner_13; }
	inline MB3_MultiMeshCombiner_t7CB3D4CCC9CFF1D0DA1C602351C8A2974AC39498 ** get_address_of__meshCombiner_13() { return &____meshCombiner_13; }
	inline void set__meshCombiner_13(MB3_MultiMeshCombiner_t7CB3D4CCC9CFF1D0DA1C602351C8A2974AC39498 * value)
	{
		____meshCombiner_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____meshCombiner_13), (void*)value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
// MB_AtlasesAndRects[]
struct MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0 * m_Items[1];

public:
	inline MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, MB_AtlasesAndRects_t230DBEBE30CC29F4685F7FB51D170E9FF7665DF0 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.GameObject[]
struct GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * m_Items[1];

public:
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Renderer[]
struct RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * m_Items[1];

public:
	inline Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Material[]
struct MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Material_t8927C00353A72755313F046D0CE85178AE8218EE * m_Items[1];

public:
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
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


// !!0[] System.Array::Empty<System.Object>()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline (const RuntimeMethod* method);
// !!0 UnityEngine.GameObject::GetComponentInChildren<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GameObject_GetComponentInChildren_TisRuntimeObject_mC8FC6687C66150FA89090C2A7733B2EE2E1315FD_gshared (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.GameObject::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * GameObject_GetComponent_TisRuntimeObject_mCE43118393A796C759AC5D43257AB2330881767D_gshared (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.ScriptableObject::CreateInstance<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * ScriptableObject_CreateInstance_TisRuntimeObject_mACD826EE1088E1006234E254924A7067CD467A5F_gshared (const RuntimeMethod* method);
// !0[] System.Collections.Generic.List`1<System.Object>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* List_1_ToArray_mA737986DE6389E9DD8FA8E3D4E222DE4DA34958D_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponentInChildren<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Component_GetComponentInChildren_TisRuntimeObject_mB377B32275A969E0D1A738DBC693DE8EB3593642_gshared (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Object::Instantiate<System.Object>(!!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Object_Instantiate_TisRuntimeObject_m4039C8E65629D33E1EC84D2505BF1D5DDC936622_gshared (RuntimeObject * ___original0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// System.Collections.Generic.List`1/Enumerator<!0> System.Collections.Generic.List`1<System.Object>::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6  List_1_GetEnumerator_m1739A5E25DF502A6984F9B98CFCAC2D3FABCF233_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Object>::get_Current()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Object>::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0_gshared (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1/Enumerator<System.Object>::Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Dispose_mCFB225D9E5E597A1CC8F958E53BEA1367D8AC7B8_gshared (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1<System.Object>::Contains(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool List_1_Contains_m99C700668AC6D272188471D2D6B784A2B5636C8E_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);

// DigitalOpus.MB.Core.MBVersion/PipelineType DigitalOpus.MB.Core.MBVersion::DetectPipeline()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MBVersion_DetectPipeline_mA626D6B7F925CE0BE0D080491A617DFE5B8E7E67 (const RuntimeMethod* method);
// System.String System.Single::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Single_ToString_m80E7ABED4F4D73F2BE19DDB80D3D92FCD8DFA010 (float* __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// !!0[] System.Array::Empty<UnityEngine.GUILayoutOption>()
inline GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline (const RuntimeMethod* method)
{
	return ((  GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* (*) (const RuntimeMethod*))Array_Empty_TisRuntimeObject_m1FBC21243DF3542384C523801E8CA8A97606C747_gshared_inline)(method);
}
// System.Void UnityEngine.GUILayout::Label(System.String,UnityEngine.GUILayoutOption[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUILayout_Label_m0DD89429577B101820231347FB04CFC489245502 (String_t* ___text0, GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* ___options1, const RuntimeMethod* method);
// System.Boolean UnityEngine.GUILayout::Button(System.String,UnityEngine.GUILayoutOption[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162 (String_t* ___text0, GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* ___options1, const RuntimeMethod* method);
// !!0 UnityEngine.GameObject::GetComponentInChildren<MB3_MeshBaker>()
inline MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method)
{
	return ((  MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))GameObject_GetComponentInChildren_TisRuntimeObject_mC8FC6687C66150FA89090C2A7733B2EE2E1315FD_gshared)(__this, method);
}
// !!0 UnityEngine.GameObject::GetComponent<MB3_TextureBaker>()
inline MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method)
{
	return ((  MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_mCE43118393A796C759AC5D43257AB2330881767D_gshared)(__this, method);
}
// DigitalOpus.MB.Core.MB3_MeshCombinerSingle/MeshCreationConditions DigitalOpus.MB.Core.MB3_MeshCombinerSingle::SetMesh(UnityEngine.Mesh)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t MB3_MeshCombinerSingle_SetMesh_m913208EB96CADA749F2A4693C2458FAEDD77ADF5 (MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A * __this, Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 * ___m0, const RuntimeMethod* method);
// !!0 UnityEngine.ScriptableObject::CreateInstance<MB2_TextureBakeResults>()
inline MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * ScriptableObject_CreateInstance_TisMB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC_mAB16670B2FAE73EF1E708558E4110CE0D941C508 (const RuntimeMethod* method)
{
	return ((  MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * (*) (const RuntimeMethod*))ScriptableObject_CreateInstance_TisRuntimeObject_mACD826EE1088E1006234E254924A7067CD467A5F_gshared)(method);
}
// System.String BakeTexturesAtRuntime::GetShaderNameForPipeline()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BakeTexturesAtRuntime_GetShaderNameForPipeline_m7B464858C7585EB4ADB376DADCAB3197D4E91251 (BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0 * __this, const RuntimeMethod* method);
// UnityEngine.Shader UnityEngine.Shader::Find(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * Shader_Find_m596EC6EBDCA8C9D5D86E2410A319928C1E8E6B5A (String_t* ___name0, const RuntimeMethod* method);
// System.Void UnityEngine.Material::.ctor(UnityEngine.Shader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * ___shader0, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_realtimeSinceStartup()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B (const RuntimeMethod* method);
// MB_AtlasesAndRects[] MB3_TextureBaker::CreateAtlases()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7* MB3_TextureBaker_CreateAtlases_mAA875D7978C4D621DE7B82FE04F8378F81A65788 (MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * __this, const RuntimeMethod* method);
// !0[] System.Collections.Generic.List`1<UnityEngine.GameObject>::ToArray()
inline GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * __this, const RuntimeMethod* method)
{
	return ((  GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* (*) (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 *, const RuntimeMethod*))List_1_ToArray_mA737986DE6389E9DD8FA8E3D4E222DE4DA34958D_gshared)(__this, method);
}
// System.Int32 UnityEngine.Time::get_frameCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Time_get_frameCount_m8601F5FB5B701680076B40D2F31405F304D963F0 (const RuntimeMethod* method);
// System.String System.Int32::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411 (int32_t* __this, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Void MB3_TextureBaker/OnCombinedTexturesCoroutineSuccess::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnCombinedTexturesCoroutineSuccess__ctor_m1AD2CEEA7A026F333C8F791C360458DC4EFA609E (OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method);
// System.Collections.IEnumerator MB3_TextureBaker::CreateAtlasesCoroutine(DigitalOpus.MB.Core.ProgressUpdateDelegate,DigitalOpus.MB.Core.MB3_TextureCombiner/CreateAtlasesCoroutineResult,System.Boolean,DigitalOpus.MB.Core.MB2_EditorMethodsInterface,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MB3_TextureBaker_CreateAtlasesCoroutine_mD8813862C75BAF7117A56458057541A4DAE6B63A (MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * __this, ProgressUpdateDelegate_t2D164ADF2149F0581DEC2C7F4FA179F9566DBAAE * ___progressInfo0, CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * ___coroutineResult1, bool ___saveAtlasesAsAssets2, RuntimeObject* ___editorMethods3, float ___maxTimePerFrame4, const RuntimeMethod* method);
// UnityEngine.Coroutine UnityEngine.MonoBehaviour::StartCoroutine(System.Collections.IEnumerator)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7 * MonoBehaviour_StartCoroutine_m3E33706D38B23CDD179E99BAD61E32303E9CC719 (MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A * __this, RuntimeObject* ___routine0, const RuntimeMethod* method);
// System.Void DigitalOpus.MB.Core.MB3_TextureCombiner/CreateAtlasesCoroutineResult::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CreateAtlasesCoroutineResult__ctor_mF36A464EA23E259B9C06CADDDA9C12700954323D (CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * __this, const RuntimeMethod* method);
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED (MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Random::Range(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2 (float ___minInclusive0, float ___maxInclusive1, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponentInChildren<MB3_MultiMeshBaker>()
inline MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * Component_GetComponentInChildren_TisMB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D_m7BE87A164A3CB00D0F9A0CC0ECE26C96E46250ED (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponentInChildren_TisRuntimeObject_mB377B32275A969E0D1A738DBC693DE8EB3593642_gshared)(__this, method);
}
// !!0 UnityEngine.Object::Instantiate<UnityEngine.GameObject>(!!0)
inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___original0, const RuntimeMethod* method)
{
	return ((  GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))Object_Instantiate_TisRuntimeObject_m4039C8E65629D33E1EC84D2505BF1D5DDC936622_gshared)(___original0, method);
}
// !!0 UnityEngine.GameObject::GetComponentInChildren<UnityEngine.MeshRenderer>()
inline MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method)
{
	return ((  MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))GameObject_GetComponentInChildren_TisRuntimeObject_mC8FC6687C66150FA89090C2A7733B2EE2E1315FD_gshared)(__this, method);
}
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.GameObject::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Random::Range(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Random_Range_m4B3A0037ACA057F33C94508F908546B9317D996A (int32_t ___minInclusive0, int32_t ___maxExclusive1, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::Euler(System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Quaternion_Euler_m37BF99FFFA09F4B3F83DC066641B82C59B19A9C3 (float ___x0, float ___y1, float ___z2, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_rotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_rotation_m1B5F3D4CE984AB31254615C9C71B0E54978583B4 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_one()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB (const RuntimeMethod* method);
// System.Single MB_DynamicAddDeleteExample::GaussianValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float MB_DynamicAddDeleteExample_GaussianValue_mB34D1F0AD2CBD262E4279B2D468C15B693E5D0E9 (MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, float ___d1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localScale(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.GameObject>::Add(!0)
inline void List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3 (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * __this, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 *, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// System.Collections.IEnumerator MB_DynamicAddDeleteExample::largeNumber()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MB_DynamicAddDeleteExample_largeNumber_m943BF6BA1335CFAB6F135D0DDE197C421B649D0F (MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * __this, const RuntimeMethod* method);
// System.Void MB_DynamicAddDeleteExample/<largeNumber>d__6::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3ClargeNumberU3Ed__6__ctor_m8AC2966092B5D4BF3EFF5FA4ED9AB676FC2ED063 (U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.GameObject>::.ctor()
inline void List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8 (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// System.Single UnityEngine.Vector3::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Vector3_get_Item_m7E5B57E02F6873804F40DD48F8BEA00247AFF5AC (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_time()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844 (const RuntimeMethod* method);
// System.Void UnityEngine.Vector3::set_Item(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Vector3_set_Item_mF3E5D7FFAD5F81973283AE6C1D15C9B238AEE346 (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.Component::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.GameObject::GetComponent<UnityEngine.Animation>()
inline Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * GameObject_GetComponent_TisAnimation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8_m92B9ADEC5AE6A5FB55D702AD0410469739EF307C (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method)
{
	return ((  Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_mCE43118393A796C759AC5D43257AB2330881767D_gshared)(__this, method);
}
// System.Void UnityEngine.Animation::set_wrapMode(UnityEngine.WrapMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_wrapMode_m27F6F0A482EF9EB1CFB350E294D1404C8ADE8A94 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::set_cullingType(UnityEngine.AnimationCullingType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_cullingType_m65032F770648FA34658DAE194947173110CBAD08 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animation::Play(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_m8EDFE80589A27DF1C34CCC0CF81DB5313CE35607 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, const RuntimeMethod* method);
// !!0 UnityEngine.GameObject::GetComponentInChildren<UnityEngine.SkinnedMeshRenderer>()
inline SkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496 * GameObject_GetComponentInChildren_TisSkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496_mBCB18247386FE1CD6449BA6EAAE856412A692586 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method)
{
	return ((  SkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496 * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))GameObject_GetComponentInChildren_TisRuntimeObject_mC8FC6687C66150FA89090C2A7733B2EE2E1315FD_gshared)(__this, method);
}
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// UnityEngine.Transform MB_SkinnedMeshSceneController::SearchHierarchyForBone(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * MB_SkinnedMeshSceneController_SearchHierarchyForBone_m06E65B46043DC5D5B28FB93129261C78C704C52C (MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___current0, String_t* ___name1, const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_parent(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6 (const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localPosition_m2A2B0033EF079077FAE7C65196078EAF5D041AFC (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::get_identity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702 (const RuntimeMethod* method);
// System.Void UnityEngine.Transform::set_localRotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___obj0, const RuntimeMethod* method);
// System.String UnityEngine.Object::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, const RuntimeMethod* method);
// System.Boolean System.String::Equals(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_Equals_m8A062B96B61A7D652E7D73C9B3E904F6B0E5F41D (String_t* __this, String_t* ___value0, const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.Transform::GetChild(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Transform_GetChild_mA7D94BEFF0144F76561D9B8FED61C5C939EC1F1C (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// System.Int32 UnityEngine.Transform::get_childCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Transform_get_childCount_mCBED4F6D3F6A7386C4D97C2C3FD25C383A0BCD05 (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * __this, const RuntimeMethod* method);
// System.Void MB_SwapShirts::ChangeOutfit(UnityEngine.Renderer[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwapShirts_ChangeOutfit_m826844529AAC21F9F16961B872D9DBC20291F746 (MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A * __this, RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* ___outfit0, const RuntimeMethod* method);
// System.Collections.Generic.List`1/Enumerator<!0> System.Collections.Generic.List`1<UnityEngine.GameObject>::GetEnumerator()
inline Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14  List_1_GetEnumerator_m3616D04A85546C8251A6C376656CDB5358D893F6 (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * __this, const RuntimeMethod* method)
{
	return ((  Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14  (*) (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 *, const RuntimeMethod*))List_1_GetEnumerator_m1739A5E25DF502A6984F9B98CFCAC2D3FABCF233_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<UnityEngine.GameObject>::get_Current()
inline GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Enumerator_get_Current_mB38DBEFCD264B4682A190F8592464C0658F702B7_inline (Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 * __this, const RuntimeMethod* method)
{
	return ((  GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * (*) (Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 *, const RuntimeMethod*))Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline)(__this, method);
}
// !!0 UnityEngine.GameObject::GetComponent<UnityEngine.Renderer>()
inline Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * GameObject_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_mD787758BED3337F182C18CC67C516C2A11B55466 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method)
{
	return ((  Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_mCE43118393A796C759AC5D43257AB2330881767D_gshared)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1/Enumerator<UnityEngine.GameObject>::MoveNext()
inline bool Enumerator_MoveNext_mF39107B3A55F66C83EBCA798CBC93AC4C990DBD7 (Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 *, const RuntimeMethod*))Enumerator_MoveNext_m2E56233762839CE55C67E00AC8DD3D4D3F6C0DF0_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1/Enumerator<UnityEngine.GameObject>::Dispose()
inline void Enumerator_Dispose_m4B68F0A4E0441A036D7E39BC7E639536164196D9 (Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 * __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 *, const RuntimeMethod*))Enumerator_Dispose_mCFB225D9E5E597A1CC8F958E53BEA1367D8AC7B8_gshared)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1<UnityEngine.GameObject>::Contains(!0)
inline bool List_1_Contains_mE508A129A7CB4DC89530674E7854B7F699BB486F (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * __this, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 *, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))List_1_Contains_m99C700668AC6D272188471D2D6B784A2B5636C8E_gshared)(__this, ___item0, method);
}
// System.Boolean UnityEngine.Input::GetKeyDown(UnityEngine.KeyCode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220 (int32_t ___key0, const RuntimeMethod* method);
// UnityEngine.Material UnityEngine.Renderer::get_sharedMaterial()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Material_t8927C00353A72755313F046D0CE85178AE8218EE * Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC (Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Renderer::set_sharedMaterial(UnityEngine.Material)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Renderer_set_sharedMaterial_m1E66766F93E95F692C3C9C2C09AFD795B156678B (Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * __this, Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___value0, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void UnityEngine.WaitForSeconds::.ctor(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void WaitForSeconds__ctor_mD298C4CB9532BBBDE172FC40F3397E30504038D4 (WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * __this, float ___seconds0, const RuntimeMethod* method);
// System.Void System.NotSupportedException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * __this, const RuntimeMethod* method);
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
// System.String BakeTexturesAtRuntime::GetShaderNameForPipeline()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* BakeTexturesAtRuntime_GetShaderNameForPipeline_m7B464858C7585EB4ADB376DADCAB3197D4E91251 (BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3EC3372E82B3B91672EF4EC7D6C8F3FB8E934642);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9B4FEEFA76B93D58B6E47CD9FF76F6E287D0D321);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD0CB1AEF1E14A3CCF80E864762420E6CE16F1986);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (MBVersion.DetectPipeline() == MBVersion.PipelineType.URP)
		int32_t L_0;
		L_0 = MBVersion_DetectPipeline_mA626D6B7F925CE0BE0D080491A617DFE5B8E7E67(/*hidden argument*/NULL);
		if ((!(((uint32_t)L_0) == ((uint32_t)2))))
		{
			goto IL_000e;
		}
	}
	{
		// return "Universal Render Pipeline/Lit";
		return _stringLiteral9B4FEEFA76B93D58B6E47CD9FF76F6E287D0D321;
	}

IL_000e:
	{
		// else if (MBVersion.DetectPipeline() == MBVersion.PipelineType.HDRP)
		int32_t L_1;
		L_1 = MBVersion_DetectPipeline_mA626D6B7F925CE0BE0D080491A617DFE5B8E7E67(/*hidden argument*/NULL);
		if ((!(((uint32_t)L_1) == ((uint32_t)3))))
		{
			goto IL_001c;
		}
	}
	{
		// return "HDRP/Lit";
		return _stringLiteralD0CB1AEF1E14A3CCF80E864762420E6CE16F1986;
	}

IL_001c:
	{
		// return "Diffuse";
		return _stringLiteral3EC3372E82B3B91672EF4EC7D6C8F3FB8E934642;
	}
}
// System.Void BakeTexturesAtRuntime::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BakeTexturesAtRuntime_OnGUI_mAACE86F537C6DD17102A43372E1B42D9192B7579 (BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BakeTexturesAtRuntime_OnBuiltAtlasesSuccess_mE0B5F2680AE0ECC5E84126EEBEAE1B60B74CBC17_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ScriptableObject_CreateInstance_TisMB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC_mAB16670B2FAE73EF1E708558E4110CE0D941C508_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral36AF179E09591E2BB7D1E7F5CC5B53634BC4026C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3EE88DEAAD87FBF3623D53B0DE9986802A46D44D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7A3EC5F790A16AC6FC972A197F8CEC8FBE6B0942);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral89BC85578B58BB199C2ACE44FCEB4FBC379C8D78);
		s_Il2CppMethodInitialized = true;
	}
	MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * V_0 = NULL;
	MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * V_1 = NULL;
	float V_2 = 0.0f;
	MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * V_3 = NULL;
	int32_t V_4 = 0;
	{
		// GUILayout.Label("Time to bake textures: " + elapsedTime);
		float* L_0 = __this->get_address_of_elapsedTime_5();
		String_t* L_1;
		L_1 = Single_ToString_m80E7ABED4F4D73F2BE19DDB80D3D92FCD8DFA010((float*)L_0, /*hidden argument*/NULL);
		String_t* L_2;
		L_2 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(_stringLiteral3EE88DEAAD87FBF3623D53B0DE9986802A46D44D, L_1, /*hidden argument*/NULL);
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_3;
		L_3 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		GUILayout_Label_m0DD89429577B101820231347FB04CFC489245502(L_2, L_3, /*hidden argument*/NULL);
		// if (GUILayout.Button("Combine textures & build combined mesh all at once"))
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_4;
		L_4 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		bool L_5;
		L_5 = GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162(_stringLiteral7A3EC5F790A16AC6FC972A197F8CEC8FBE6B0942, L_4, /*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_00c7;
		}
	}
	{
		// MB3_MeshBaker meshbaker = target.GetComponentInChildren<MB3_MeshBaker>();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_6 = __this->get_target_4();
		NullCheck(L_6);
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_7;
		L_7 = GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF(L_6, /*hidden argument*/GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF_RuntimeMethod_var);
		V_0 = L_7;
		// MB3_TextureBaker textureBaker = target.GetComponent<MB3_TextureBaker>();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_8 = __this->get_target_4();
		NullCheck(L_8);
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_9;
		L_9 = GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127(L_8, /*hidden argument*/GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127_RuntimeMethod_var);
		V_1 = L_9;
		// ((MB3_MeshCombinerSingle)meshbaker.meshCombiner).SetMesh(null);
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_10 = V_0;
		NullCheck(L_10);
		MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51 * L_11;
		L_11 = VirtFuncInvoker0< MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51 * >::Invoke(8 /* DigitalOpus.MB.Core.MB3_MeshCombiner MB3_MeshBakerCommon::get_meshCombiner() */, L_10);
		NullCheck(((MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A *)CastclassClass((RuntimeObject*)L_11, MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A_il2cpp_TypeInfo_var)));
		int32_t L_12;
		L_12 = MB3_MeshCombinerSingle_SetMesh_m913208EB96CADA749F2A4693C2458FAEDD77ADF5(((MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A *)CastclassClass((RuntimeObject*)L_11, MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A_il2cpp_TypeInfo_var)), (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 *)NULL, /*hidden argument*/NULL);
		// textureBaker.textureBakeResults = ScriptableObject.CreateInstance<MB2_TextureBakeResults>();
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_13 = V_1;
		MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * L_14;
		L_14 = ScriptableObject_CreateInstance_TisMB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC_mAB16670B2FAE73EF1E708558E4110CE0D941C508(/*hidden argument*/ScriptableObject_CreateInstance_TisMB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC_mAB16670B2FAE73EF1E708558E4110CE0D941C508_RuntimeMethod_var);
		NullCheck(L_13);
		VirtActionInvoker1< MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * >::Invoke(5 /* System.Void MB3_MeshBakerRoot::set_textureBakeResults(MB2_TextureBakeResults) */, L_13, L_14);
		// textureBaker.resultMaterial = new Material(Shader.Find(GetShaderNameForPipeline()));
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_15 = V_1;
		String_t* L_16;
		L_16 = BakeTexturesAtRuntime_GetShaderNameForPipeline_m7B464858C7585EB4ADB376DADCAB3197D4E91251(__this, /*hidden argument*/NULL);
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_17;
		L_17 = Shader_Find_m596EC6EBDCA8C9D5D86E2410A319928C1E8E6B5A(L_16, /*hidden argument*/NULL);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_18 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E(L_18, L_17, /*hidden argument*/NULL);
		NullCheck(L_15);
		VirtActionInvoker1< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(45 /* System.Void MB3_TextureBaker::set_resultMaterial(UnityEngine.Material) */, L_15, L_18);
		// float t1 = Time.realtimeSinceStartup;
		float L_19;
		L_19 = Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B(/*hidden argument*/NULL);
		V_2 = L_19;
		// textureBaker.CreateAtlases();
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_20 = V_1;
		NullCheck(L_20);
		MB_AtlasesAndRectsU5BU5D_t5CCFE0B695665D1767A47570C601199AF60B2CC7* L_21;
		L_21 = MB3_TextureBaker_CreateAtlases_mAA875D7978C4D621DE7B82FE04F8378F81A65788(L_20, /*hidden argument*/NULL);
		// elapsedTime = Time.realtimeSinceStartup - t1;
		float L_22;
		L_22 = Time_get_realtimeSinceStartup_m5228CC1C1E57213D4148E965499072EA70D8C02B(/*hidden argument*/NULL);
		float L_23 = V_2;
		__this->set_elapsedTime_5(((float)il2cpp_codegen_subtract((float)L_22, (float)L_23)));
		// meshbaker.ClearMesh(); //only necessary if your not sure whats in the combined mesh
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_24 = V_0;
		NullCheck(L_24);
		VirtActionInvoker0::Invoke(9 /* System.Void MB3_MeshBakerCommon::ClearMesh() */, L_24);
		// meshbaker.textureBakeResults = textureBaker.textureBakeResults;
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_25 = V_0;
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_26 = V_1;
		NullCheck(L_26);
		MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * L_27;
		L_27 = VirtFuncInvoker0< MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * >::Invoke(4 /* MB2_TextureBakeResults MB3_MeshBakerRoot::get_textureBakeResults() */, L_26);
		NullCheck(L_25);
		VirtActionInvoker1< MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * >::Invoke(5 /* System.Void MB3_MeshBakerRoot::set_textureBakeResults(MB2_TextureBakeResults) */, L_25, L_27);
		// if (meshbaker.AddDeleteGameObjects(textureBaker.GetObjectsToCombine().ToArray(), null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_28 = V_0;
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_29 = V_1;
		NullCheck(L_29);
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_30;
		L_30 = VirtFuncInvoker0< List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * >::Invoke(6 /* System.Collections.Generic.List`1<UnityEngine.GameObject> MB3_MeshBakerRoot::GetObjectsToCombine() */, L_29);
		NullCheck(L_30);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_31;
		L_31 = List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F(L_30, /*hidden argument*/List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		NullCheck(L_28);
		bool L_32;
		L_32 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_28, L_31, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_32)
		{
			goto IL_00c7;
		}
	}
	{
		// meshbaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_33 = V_0;
		NullCheck(L_33);
		bool L_34;
		L_34 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_33, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_00c7:
	{
		// if (GUILayout.Button("Combine textures & build combined mesh using coroutine"))
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_35;
		L_35 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		bool L_36;
		L_36 = GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162(_stringLiteral36AF179E09591E2BB7D1E7F5CC5B53634BC4026C, L_35, /*hidden argument*/NULL);
		if (!L_36)
		{
			goto IL_016e;
		}
	}
	{
		// Debug.Log("Starting to bake textures on frame " + Time.frameCount);
		int32_t L_37;
		L_37 = Time_get_frameCount_m8601F5FB5B701680076B40D2F31405F304D963F0(/*hidden argument*/NULL);
		V_4 = L_37;
		String_t* L_38;
		L_38 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_4), /*hidden argument*/NULL);
		String_t* L_39;
		L_39 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(_stringLiteral89BC85578B58BB199C2ACE44FCEB4FBC379C8D78, L_38, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_39, /*hidden argument*/NULL);
		// MB3_MeshBaker meshbaker = target.GetComponentInChildren<MB3_MeshBaker>();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_40 = __this->get_target_4();
		NullCheck(L_40);
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_41;
		L_41 = GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF(L_40, /*hidden argument*/GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF_RuntimeMethod_var);
		// MB3_TextureBaker textureBaker = target.GetComponent<MB3_TextureBaker>();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_42 = __this->get_target_4();
		NullCheck(L_42);
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_43;
		L_43 = GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127(L_42, /*hidden argument*/GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127_RuntimeMethod_var);
		V_3 = L_43;
		// ((MB3_MeshCombinerSingle)meshbaker.meshCombiner).SetMesh(null);
		NullCheck(L_41);
		MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51 * L_44;
		L_44 = VirtFuncInvoker0< MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51 * >::Invoke(8 /* DigitalOpus.MB.Core.MB3_MeshCombiner MB3_MeshBakerCommon::get_meshCombiner() */, L_41);
		NullCheck(((MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A *)CastclassClass((RuntimeObject*)L_44, MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A_il2cpp_TypeInfo_var)));
		int32_t L_45;
		L_45 = MB3_MeshCombinerSingle_SetMesh_m913208EB96CADA749F2A4693C2458FAEDD77ADF5(((MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A *)CastclassClass((RuntimeObject*)L_44, MB3_MeshCombinerSingle_tBCCD22E7273CB29AA045363DBE8B40ECF746656A_il2cpp_TypeInfo_var)), (Mesh_t2F5992DBA650D5862B43D3823ACD997132A57DA6 *)NULL, /*hidden argument*/NULL);
		// textureBaker.textureBakeResults = ScriptableObject.CreateInstance<MB2_TextureBakeResults>();
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_46 = V_3;
		MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * L_47;
		L_47 = ScriptableObject_CreateInstance_TisMB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC_mAB16670B2FAE73EF1E708558E4110CE0D941C508(/*hidden argument*/ScriptableObject_CreateInstance_TisMB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC_mAB16670B2FAE73EF1E708558E4110CE0D941C508_RuntimeMethod_var);
		NullCheck(L_46);
		VirtActionInvoker1< MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * >::Invoke(5 /* System.Void MB3_MeshBakerRoot::set_textureBakeResults(MB2_TextureBakeResults) */, L_46, L_47);
		// textureBaker.resultMaterial = new Material(Shader.Find(GetShaderNameForPipeline()));
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_48 = V_3;
		String_t* L_49;
		L_49 = BakeTexturesAtRuntime_GetShaderNameForPipeline_m7B464858C7585EB4ADB376DADCAB3197D4E91251(__this, /*hidden argument*/NULL);
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_50;
		L_50 = Shader_Find_m596EC6EBDCA8C9D5D86E2410A319928C1E8E6B5A(L_49, /*hidden argument*/NULL);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_51 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E(L_51, L_50, /*hidden argument*/NULL);
		NullCheck(L_48);
		VirtActionInvoker1< Material_t8927C00353A72755313F046D0CE85178AE8218EE * >::Invoke(45 /* System.Void MB3_TextureBaker::set_resultMaterial(UnityEngine.Material) */, L_48, L_51);
		// textureBaker.onBuiltAtlasesSuccess = new MB3_TextureBaker.OnCombinedTexturesCoroutineSuccess(OnBuiltAtlasesSuccess);
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_52 = V_3;
		OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA * L_53 = (OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA *)il2cpp_codegen_object_new(OnCombinedTexturesCoroutineSuccess_tCE097AA3519CB09349950699FAC2E9DA64529FFA_il2cpp_TypeInfo_var);
		OnCombinedTexturesCoroutineSuccess__ctor_m1AD2CEEA7A026F333C8F791C360458DC4EFA609E(L_53, __this, (intptr_t)((intptr_t)BakeTexturesAtRuntime_OnBuiltAtlasesSuccess_mE0B5F2680AE0ECC5E84126EEBEAE1B60B74CBC17_RuntimeMethod_var), /*hidden argument*/NULL);
		NullCheck(L_52);
		L_52->set_onBuiltAtlasesSuccess_34(L_53);
		// StartCoroutine(textureBaker.CreateAtlasesCoroutine(null, result, false, null, .01f));
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_54 = V_3;
		CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * L_55 = __this->get_result_6();
		NullCheck(L_54);
		RuntimeObject* L_56;
		L_56 = MB3_TextureBaker_CreateAtlasesCoroutine_mD8813862C75BAF7117A56458057541A4DAE6B63A(L_54, (ProgressUpdateDelegate_t2D164ADF2149F0581DEC2C7F4FA179F9566DBAAE *)NULL, L_55, (bool)0, (RuntimeObject*)NULL, (0.00999999978f), /*hidden argument*/NULL);
		Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7 * L_57;
		L_57 = MonoBehaviour_StartCoroutine_m3E33706D38B23CDD179E99BAD61E32303E9CC719(__this, L_56, /*hidden argument*/NULL);
	}

IL_016e:
	{
		// }
		return;
	}
}
// System.Void BakeTexturesAtRuntime::OnBuiltAtlasesSuccess()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BakeTexturesAtRuntime_OnBuiltAtlasesSuccess_mE0B5F2680AE0ECC5E84126EEBEAE1B60B74CBC17 (BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9C15DB2067A4346D49A29ABFAD47FCD9AFA8384E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE040F9AA7BB3C6984613571A2CE6BA4705EBE9BB);
		s_Il2CppMethodInitialized = true;
	}
	MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * V_0 = NULL;
	MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * V_1 = NULL;
	int32_t V_2 = 0;
	{
		// Debug.Log("Calling success callback. baking meshes");
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(_stringLiteral9C15DB2067A4346D49A29ABFAD47FCD9AFA8384E, /*hidden argument*/NULL);
		// MB3_MeshBaker meshbaker = target.GetComponentInChildren<MB3_MeshBaker>();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_0 = __this->get_target_4();
		NullCheck(L_0);
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_1;
		L_1 = GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF(L_0, /*hidden argument*/GameObject_GetComponentInChildren_TisMB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D_mAFAD67FC5CFCDD82972F6FA63D386F25237798EF_RuntimeMethod_var);
		V_0 = L_1;
		// MB3_TextureBaker textureBaker = target.GetComponent<MB3_TextureBaker>();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_2 = __this->get_target_4();
		NullCheck(L_2);
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_3;
		L_3 = GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127(L_2, /*hidden argument*/GameObject_GetComponent_TisMB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E_m6808BF272148CE1B87DF8BCDAD488E9121492127_RuntimeMethod_var);
		V_1 = L_3;
		// if (result.isFinished &&
		//     result.success)
		CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * L_4 = __this->get_result_6();
		NullCheck(L_4);
		bool L_5 = L_4->get_isFinished_1();
		if (!L_5)
		{
			goto IL_006b;
		}
	}
	{
		CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * L_6 = __this->get_result_6();
		NullCheck(L_6);
		bool L_7 = L_6->get_success_0();
		if (!L_7)
		{
			goto IL_006b;
		}
	}
	{
		// meshbaker.ClearMesh(); //only necessary if your not sure whats in the combined mesh
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_8 = V_0;
		NullCheck(L_8);
		VirtActionInvoker0::Invoke(9 /* System.Void MB3_MeshBakerCommon::ClearMesh() */, L_8);
		// meshbaker.textureBakeResults = textureBaker.textureBakeResults;
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_9 = V_0;
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_10 = V_1;
		NullCheck(L_10);
		MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * L_11;
		L_11 = VirtFuncInvoker0< MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * >::Invoke(4 /* MB2_TextureBakeResults MB3_MeshBakerRoot::get_textureBakeResults() */, L_10);
		NullCheck(L_9);
		VirtActionInvoker1< MB2_TextureBakeResults_tE15E182B2F930944AF42892E526B84F097D922BC * >::Invoke(5 /* System.Void MB3_MeshBakerRoot::set_textureBakeResults(MB2_TextureBakeResults) */, L_9, L_11);
		// if (meshbaker.AddDeleteGameObjects(textureBaker.GetObjectsToCombine().ToArray(), null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_12 = V_0;
		MB3_TextureBaker_tD4C04032C0D2100BB67F9FC3E81FFB2CD59F709E * L_13 = V_1;
		NullCheck(L_13);
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_14;
		L_14 = VirtFuncInvoker0< List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * >::Invoke(6 /* System.Collections.Generic.List`1<UnityEngine.GameObject> MB3_MeshBakerRoot::GetObjectsToCombine() */, L_13);
		NullCheck(L_14);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_15;
		L_15 = List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F(L_14, /*hidden argument*/List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		NullCheck(L_12);
		bool L_16;
		L_16 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_12, L_15, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_16)
		{
			goto IL_006b;
		}
	}
	{
		// meshbaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_17 = V_0;
		NullCheck(L_17);
		bool L_18;
		L_18 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_17, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_006b:
	{
		// Debug.Log("Completed baking textures on frame " + Time.frameCount);
		int32_t L_19;
		L_19 = Time_get_frameCount_m8601F5FB5B701680076B40D2F31405F304D963F0(/*hidden argument*/NULL);
		V_2 = L_19;
		String_t* L_20;
		L_20 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_2), /*hidden argument*/NULL);
		String_t* L_21;
		L_21 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(_stringLiteralE040F9AA7BB3C6984613571A2CE6BA4705EBE9BB, L_20, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_21, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void BakeTexturesAtRuntime::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BakeTexturesAtRuntime__ctor_mB6448F7604E69B37BB2B0161A4C761B17B85D00C (BakeTexturesAtRuntime_t97034D1A87947A583CD390091E016A39076CB4B0 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// MB3_TextureCombiner.CreateAtlasesCoroutineResult result = new MB3_TextureCombiner.CreateAtlasesCoroutineResult();
		CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB * L_0 = (CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB *)il2cpp_codegen_object_new(CreateAtlasesCoroutineResult_tE458925108AC59BB91F951377D690B90BE9128EB_il2cpp_TypeInfo_var);
		CreateAtlasesCoroutineResult__ctor_mF36A464EA23E259B9C06CADDDA9C12700954323D(L_0, /*hidden argument*/NULL);
		__this->set_result_6(L_0);
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_BatchPrepareObjectsForDynamicBatchingDescription::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_BatchPrepareObjectsForDynamicBatchingDescription_OnGUI_mBC039323D6791AE853A0CD3DC27BABCCE68E214E (MB_BatchPrepareObjectsForDynamicBatchingDescription_t9D997A1F37CDAE2A718380F1F0CC0A49E976F6CF * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1D2BA32BAB27E860E6B12CC64F30005C594802DA);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUILayout.Label ("This scene is set up to create a combined material and meshes with adjusted UVs so \n" +
		//                  " objects can share a material and be batched by Unity's static/dynamic batching.\n" +
		//                  " This scene has added a BatchPrefabBaker component to a Mesh and Material Baker which \n" +
		//                  "  can bake many prefabs (each of which can have several renderers) in one click.\n" +
		//                  " The batching tool accepts prefab assets instead of scene objects. \n");
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_0;
		L_0 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		GUILayout_Label_m0DD89429577B101820231347FB04CFC489245502(_stringLiteral1D2BA32BAB27E860E6B12CC64F30005C594802DA, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void MB_BatchPrepareObjectsForDynamicBatchingDescription::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_BatchPrepareObjectsForDynamicBatchingDescription__ctor_m08D5CC451356E63D6478ECBEAB2940CCCC3993DF (MB_BatchPrepareObjectsForDynamicBatchingDescription_t9D997A1F37CDAE2A718380F1F0CC0A49E976F6CF * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Single MB_DynamicAddDeleteExample::GaussianValue()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float MB_DynamicAddDeleteExample_GaussianValue_mB34D1F0AD2CBD262E4279B2D468C15B693E5D0E9 (MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;

IL_0000:
	{
		// x1 = 2.0f * Random.Range(0f, 1f) - 1.0f;
		float L_0;
		L_0 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2((0.0f), (1.0f), /*hidden argument*/NULL);
		V_0 = ((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_multiply((float)(2.0f), (float)L_0)), (float)(1.0f)));
		// x2 = 2.0f * Random.Range(0f, 1f) - 1.0f;
		float L_1;
		L_1 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2((0.0f), (1.0f), /*hidden argument*/NULL);
		V_1 = ((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_multiply((float)(2.0f), (float)L_1)), (float)(1.0f)));
		// w = x1 * x1 + x2 * x2;
		float L_2 = V_0;
		float L_3 = V_0;
		float L_4 = V_1;
		float L_5 = V_1;
		V_2 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)), (float)((float)il2cpp_codegen_multiply((float)L_4, (float)L_5))));
		// } while (w >= 1.0f);
		float L_6 = V_2;
		if ((((float)L_6) >= ((float)(1.0f))))
		{
			goto IL_0000;
		}
	}
	{
		// w = Mathf.Sqrt((-2.0f * Mathf.Log(w)) / w);
		float L_7 = V_2;
		float L_8;
		L_8 = logf(L_7);
		float L_9 = V_2;
		float L_10;
		L_10 = sqrtf(((float)((float)((float)il2cpp_codegen_multiply((float)(-2.0f), (float)L_8))/(float)L_9)));
		V_2 = L_10;
		// y1 = x1 * w;
		float L_11 = V_0;
		float L_12 = V_2;
		// return y1;
		return ((float)il2cpp_codegen_multiply((float)L_11, (float)L_12));
	}
}
// System.Void MB_DynamicAddDeleteExample::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_DynamicAddDeleteExample_Start_m2AEA9659E48E967376AE8DB78FA269F42E09856C (MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentInChildren_TisMB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D_m7BE87A164A3CB00D0F9A0CC0ECE26C96E46250ED_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * V_4 = NULL;
	float V_5 = 0.0f;
	float V_6 = 0.0f;
	float V_7 = 0.0f;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_8;
	memset((&V_8), 0, sizeof(V_8));
	{
		// mbd = GetComponentInChildren<MB3_MultiMeshBaker>();
		MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * L_0;
		L_0 = Component_GetComponentInChildren_TisMB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D_m7BE87A164A3CB00D0F9A0CC0ECE26C96E46250ED(__this, /*hidden argument*/Component_GetComponentInChildren_TisMB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D_m7BE87A164A3CB00D0F9A0CC0ECE26C96E46250ED_RuntimeMethod_var);
		__this->set_mbd_6(L_0);
		// int dim = 10;
		V_0 = ((int32_t)10);
		// GameObject[] gos = new GameObject[dim * dim];
		int32_t L_1 = V_0;
		int32_t L_2 = V_0;
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_3 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_1, (int32_t)L_2)));
		V_1 = L_3;
		// for (int i = 0; i < dim; i++)
		V_2 = 0;
		goto IL_011d;
	}

IL_001f:
	{
		// for (int j = 0; j < dim; j++)
		V_3 = 0;
		goto IL_0112;
	}

IL_0026:
	{
		// GameObject go = (GameObject)Instantiate(prefab);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_4 = __this->get_prefab_4();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_5;
		L_5 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33(L_4, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var);
		V_4 = L_5;
		// gos[i * dim + j] = go.GetComponentInChildren<MeshRenderer>().gameObject;
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_6 = V_1;
		int32_t L_7 = V_2;
		int32_t L_8 = V_0;
		int32_t L_9 = V_3;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_10 = V_4;
		NullCheck(L_10);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_11;
		L_11 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_10, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_11);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_12;
		L_12 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_11, /*hidden argument*/NULL);
		NullCheck(L_6);
		ArrayElementTypeCheck (L_6, L_12);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_7, (int32_t)L_8)), (int32_t)L_9))), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_12);
		// float randx = Random.Range(-4f, 4f);
		float L_13;
		L_13 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2((-4.0f), (4.0f), /*hidden argument*/NULL);
		V_5 = L_13;
		// float randz = Random.Range(-4f, 4f);
		float L_14;
		L_14 = Random_Range_mC15372D42A9ABDCAC3DE82E114D60A40C9C311D2((-4.0f), (4.0f), /*hidden argument*/NULL);
		V_6 = L_14;
		// go.transform.position = (new Vector3(3f * i + randx, 0, 3f * j + randz));
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_15 = V_4;
		NullCheck(L_15);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_16;
		L_16 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_15, /*hidden argument*/NULL);
		int32_t L_17 = V_2;
		float L_18 = V_5;
		int32_t L_19 = V_3;
		float L_20 = V_6;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_21;
		memset((&L_21), 0, sizeof(L_21));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_21), ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)(3.0f), (float)((float)((float)L_17)))), (float)L_18)), (0.0f), ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)(3.0f), (float)((float)((float)L_19)))), (float)L_20)), /*hidden argument*/NULL);
		NullCheck(L_16);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_16, L_21, /*hidden argument*/NULL);
		// float randrot = Random.Range(0, 360);
		int32_t L_22;
		L_22 = Random_Range_m4B3A0037ACA057F33C94508F908546B9317D996A(0, ((int32_t)360), /*hidden argument*/NULL);
		V_7 = ((float)((float)L_22));
		// go.transform.rotation = Quaternion.Euler(0, randrot, 0);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_23 = V_4;
		NullCheck(L_23);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_24;
		L_24 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_23, /*hidden argument*/NULL);
		float L_25 = V_7;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_26;
		L_26 = Quaternion_Euler_m37BF99FFFA09F4B3F83DC066641B82C59B19A9C3((0.0f), L_25, (0.0f), /*hidden argument*/NULL);
		NullCheck(L_24);
		Transform_set_rotation_m1B5F3D4CE984AB31254615C9C71B0E54978583B4(L_24, L_26, /*hidden argument*/NULL);
		// Vector3 randscale = Vector3.one + Vector3.one * GaussianValue() * .15f;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_27;
		L_27 = Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB(/*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_28;
		L_28 = Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB(/*hidden argument*/NULL);
		float L_29;
		L_29 = MB_DynamicAddDeleteExample_GaussianValue_mB34D1F0AD2CBD262E4279B2D468C15B693E5D0E9(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_30;
		L_30 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_28, L_29, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_31;
		L_31 = Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline(L_30, (0.150000006f), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_32;
		L_32 = Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline(L_27, L_31, /*hidden argument*/NULL);
		V_8 = L_32;
		// go.transform.localScale = randscale;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_33 = V_4;
		NullCheck(L_33);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_34;
		L_34 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_33, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_35 = V_8;
		NullCheck(L_34);
		Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A(L_34, L_35, /*hidden argument*/NULL);
		// if ((i * dim + j) % 3 == 0)
		int32_t L_36 = V_2;
		int32_t L_37 = V_0;
		int32_t L_38 = V_3;
		if (((int32_t)((int32_t)((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_36, (int32_t)L_37)), (int32_t)L_38))%(int32_t)3)))
		{
			goto IL_010e;
		}
	}
	{
		// objsInCombined.Add(gos[i * dim + j]);
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_39 = __this->get_objsInCombined_5();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_40 = V_1;
		int32_t L_41 = V_2;
		int32_t L_42 = V_0;
		int32_t L_43 = V_3;
		NullCheck(L_40);
		int32_t L_44 = ((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_41, (int32_t)L_42)), (int32_t)L_43));
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_45 = (L_40)->GetAt(static_cast<il2cpp_array_size_t>(L_44));
		NullCheck(L_39);
		List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3(L_39, L_45, /*hidden argument*/List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3_RuntimeMethod_var);
	}

IL_010e:
	{
		// for (int j = 0; j < dim; j++)
		int32_t L_46 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_46, (int32_t)1));
	}

IL_0112:
	{
		// for (int j = 0; j < dim; j++)
		int32_t L_47 = V_3;
		int32_t L_48 = V_0;
		if ((((int32_t)L_47) < ((int32_t)L_48)))
		{
			goto IL_0026;
		}
	}
	{
		// for (int i = 0; i < dim; i++)
		int32_t L_49 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_49, (int32_t)1));
	}

IL_011d:
	{
		// for (int i = 0; i < dim; i++)
		int32_t L_50 = V_2;
		int32_t L_51 = V_0;
		if ((((int32_t)L_50) < ((int32_t)L_51)))
		{
			goto IL_001f;
		}
	}
	{
		// mbd.ClearMesh();
		MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * L_52 = __this->get_mbd_6();
		NullCheck(L_52);
		VirtActionInvoker0::Invoke(9 /* System.Void MB3_MeshBakerCommon::ClearMesh() */, L_52);
		// if (mbd.AddDeleteGameObjects(gos, null, true))
		MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * L_53 = __this->get_mbd_6();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_54 = V_1;
		NullCheck(L_53);
		bool L_55;
		L_55 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_53, L_54, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_55)
		{
			goto IL_014c;
		}
	}
	{
		// mbd.Apply();
		MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * L_56 = __this->get_mbd_6();
		NullCheck(L_56);
		bool L_57;
		L_57 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_56, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_014c:
	{
		// objs = objsInCombined.ToArray();
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_58 = __this->get_objsInCombined_5();
		NullCheck(L_58);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_59;
		L_59 = List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F(L_58, /*hidden argument*/List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		__this->set_objs_7(L_59);
		// StartCoroutine(largeNumber());
		RuntimeObject* L_60;
		L_60 = MB_DynamicAddDeleteExample_largeNumber_m943BF6BA1335CFAB6F135D0DDE197C421B649D0F(__this, /*hidden argument*/NULL);
		Coroutine_t899D5232EF542CB8BA70AF9ECEECA494FAA9CCB7 * L_61;
		L_61 = MonoBehaviour_StartCoroutine_m3E33706D38B23CDD179E99BAD61E32303E9CC719(__this, L_60, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Collections.IEnumerator MB_DynamicAddDeleteExample::largeNumber()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MB_DynamicAddDeleteExample_largeNumber_m943BF6BA1335CFAB6F135D0DDE197C421B649D0F (MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * L_0 = (U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 *)il2cpp_codegen_object_new(U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3_il2cpp_TypeInfo_var);
		U3ClargeNumberU3Ed__6__ctor_m8AC2966092B5D4BF3EFF5FA4ED9AB676FC2ED063(L_0, 0, /*hidden argument*/NULL);
		U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * L_1 = L_0;
		NullCheck(L_1);
		L_1->set_U3CU3E4__this_2(__this);
		return L_1;
	}
}
// System.Void MB_DynamicAddDeleteExample::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_DynamicAddDeleteExample_OnGUI_m44BD4EE6AF0C301AC582241F4BA33180C1B0BCD3 (MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1691262A69613799986FFA89B484056508CBB3BD);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUILayout.Label("Dynamically instantiates game objects. \nRepeatedly adds and removes some of them\n from the combined mesh.");
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_0;
		L_0 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		GUILayout_Label_m0DD89429577B101820231347FB04CFC489245502(_stringLiteral1691262A69613799986FFA89B484056508CBB3BD, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void MB_DynamicAddDeleteExample::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_DynamicAddDeleteExample__ctor_m2CC11F6A9CE1F2B2A87892AA5D1E57755C5685C2 (MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// List<GameObject> objsInCombined = new List<GameObject>();
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_0 = (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 *)il2cpp_codegen_object_new(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5_il2cpp_TypeInfo_var);
		List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8(L_0, /*hidden argument*/List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8_RuntimeMethod_var);
		__this->set_objsInCombined_5(L_0);
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_Example::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_Example_Start_m854DA1537F759A27ED3DAD5317D996733CFDB60A (MB_Example_t2482A220673A29321053B9C6DED04A8B5F5F01DE * __this, const RuntimeMethod* method)
{
	{
		// if (meshbaker.AddDeleteGameObjects(objsToCombine, null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_0 = __this->get_meshbaker_4();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_1 = __this->get_objsToCombine_5();
		NullCheck(L_0);
		bool L_2;
		L_2 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_0, L_1, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_2)
		{
			goto IL_0022;
		}
	}
	{
		// meshbaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_3 = __this->get_meshbaker_4();
		NullCheck(L_3);
		bool L_4;
		L_4 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_3, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_0022:
	{
		// }
		return;
	}
}
// System.Void MB_Example::LateUpdate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_Example_LateUpdate_mE1BEAF256171302BB0B8B9F0546BFF33996C78CB (MB_Example_t2482A220673A29321053B9C6DED04A8B5F5F01DE * __this, const RuntimeMethod* method)
{
	{
		// if (meshbaker.UpdateGameObjects(objsToCombine))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_0 = __this->get_meshbaker_4();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_1 = __this->get_objsToCombine_5();
		NullCheck(L_0);
		bool L_2;
		L_2 = VirtFuncInvoker1< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* >::Invoke(20 /* System.Boolean MB3_MeshBakerCommon::UpdateGameObjects(UnityEngine.GameObject[]) */, L_0, L_1);
		if (!L_2)
		{
			goto IL_002b;
		}
	}
	{
		// meshbaker.Apply(false, true, true, true, false, false, false, false, false);
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_3 = __this->get_meshbaker_4();
		NullCheck(L_3);
		bool L_4;
		L_4 = VirtFuncInvoker12< bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(18 /* System.Boolean MB3_MeshBakerCommon::Apply(System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_3, (bool)0, (bool)1, (bool)1, (bool)1, (bool)0, (bool)0, (bool)0, (bool)0, (bool)0, (bool)0, (bool)0, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_002b:
	{
		// }
		return;
	}
}
// System.Void MB_Example::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_Example_OnGUI_mAA6984FCDE4696C4F9D2480DC78A82AE7268004C (MB_Example_t2482A220673A29321053B9C6DED04A8B5F5F01DE * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral967C0E8FBF2CA8DCA87FC5F95006322F543FD279);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUILayout.Label("Dynamically updates the vertices, normals and tangents in combined mesh every frame.\n" +
		//                  "This is similar to dynamic batching. It is not recommended to do this every frame.\n" +
		//                  "Also consider baking the mesh renderer objects into a skinned mesh renderer\n" +
		//                  "The skinned mesh approach is faster for objects that need to move independently of each other every frame.");
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_0;
		L_0 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		GUILayout_Label_m0DD89429577B101820231347FB04CFC489245502(_stringLiteral967C0E8FBF2CA8DCA87FC5F95006322F543FD279, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void MB_Example::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_Example__ctor_m9193830737FD79B02B061530571D850097B3DC10 (MB_Example_t2482A220673A29321053B9C6DED04A8B5F5F01DE * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_ExampleMover::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_ExampleMover_Update_m029F30564F6DC1C86D0E8471C81405E38CC21A17 (MB_ExampleMover_tE2268282AE7C1F2ABF91583A07AEB890359FE29D * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * V_1 = NULL;
	int32_t V_2 = 0;
	{
		// Vector3 v1 = new Vector3(5f,5f,5f);
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), (5.0f), (5.0f), (5.0f), /*hidden argument*/NULL);
		// v1[axis] *= Mathf.Sin(Time.time);
		V_1 = (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0);
		int32_t L_0 = __this->get_axis_4();
		V_2 = L_0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_1 = V_1;
		int32_t L_2 = V_2;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * L_3 = V_1;
		int32_t L_4 = V_2;
		float L_5;
		L_5 = Vector3_get_Item_m7E5B57E02F6873804F40DD48F8BEA00247AFF5AC((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)L_3, L_4, /*hidden argument*/NULL);
		float L_6;
		L_6 = Time_get_time_m1A186074B1FCD448AB13A4B9D715AB9ED0B40844(/*hidden argument*/NULL);
		float L_7;
		L_7 = sinf(L_6);
		Vector3_set_Item_mF3E5D7FFAD5F81973283AE6C1D15C9B238AEE346((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)L_1, L_2, ((float)il2cpp_codegen_multiply((float)L_5, (float)L_7)), /*hidden argument*/NULL);
		// transform.position = v1;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_8;
		L_8 = Component_get_transform_mE8496EBC45BEB1BADB5F314960F1DF1C952FA11F(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_9 = V_0;
		NullCheck(L_8);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_8, L_9, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void MB_ExampleMover::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_ExampleMover__ctor_mADBED902B78440031656FBDBE93DD632B198311B (MB_ExampleMover_tE2268282AE7C1F2ABF91583A07AEB890359FE29D * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_ExampleSkinnedMeshDescription::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_ExampleSkinnedMeshDescription_OnGUI_mEDCD2AF9244C464AFDBF5C3F01342D913B4DB859 (MB_ExampleSkinnedMeshDescription_tFB02696EFBA31EAD5321A0212F961B2698FC0CF4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF3DC1C70BEC11B40775CE32E6B71F1D8639EB5E4);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUILayout.Label ("Mesh Renderer objects have been baked into a skinned mesh. Each source object\n" +
		//                  " is still in the scene (with renderer disabled) and becomes a bone. Any scripts, animations,\n" +
		//                  " or physics that affect the invisible source objects will be visible in the\n" +
		//                  "Skinned Mesh." +
		//                  " This approach is more efficient than either dynamic batching or updating every frame \n" +
		//                  " for many small objects that constantly and independently move. \n" +
		//                  " With this approach pay attention to the SkinnedMeshRenderer Bounds and Animation Culling\n" +
		//                  "settings. You may need to write your own script to manage/update these or your object may vanish or stop animating.\n" +
		//                  " You can update the combined mesh at runtime as objects are added and deleted from the scene.");
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_0;
		L_0 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		GUILayout_Label_m0DD89429577B101820231347FB04CFC489245502(_stringLiteralF3DC1C70BEC11B40775CE32E6B71F1D8639EB5E4, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void MB_ExampleSkinnedMeshDescription::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_ExampleSkinnedMeshDescription__ctor_m460AB1520081DDD6065486F8C5D65A2D34867E28 (MB_ExampleSkinnedMeshDescription_tFB02696EFBA31EAD5321A0212F961B2698FC0CF4 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_MigrateMaterialsToDifferentPipeline::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_MigrateMaterialsToDifferentPipeline__ctor_m7E75C57765A20CCD68FCCDEAD4E2E9FC671D1128 (MB_MigrateMaterialsToDifferentPipeline_t595685F82E94A09D39B4A9215AB3D547905D242B * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_PrepareObjectsForDynamicBatchingDescription::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_PrepareObjectsForDynamicBatchingDescription_OnGUI_mFAB946B1CD9180941CB6BD5AFC3E031E3D0B16D0 (MB_PrepareObjectsForDynamicBatchingDescription_t7E6322CFBF49D134B355E9347B8B4FB734E487DF * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBAA0EAB272BE3FEF05FED2A6DDFCB50F93272B51);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUILayout.Label ("This scene creates a combined material and meshes with adjusted UVs so objects \n" +
		//                  " can share a material and be batched by Unity's static/dynamic batching.\n" +
		//                  " Output has been set to 'bakeMeshAssetsInPlace' on the Mesh Baker\n" +
		//                  " Position, Scale and Rotation will be baked into meshes so place them appropriately.\n" +
		//                  " Dynamic batching requires objects with uniform scale. You can fix non-uniform scale here\n" +
		//                  " After baking you need to duplicate your source prefab assets and replace the  \n" +
		//                  " meshes and materials with the generated ones.\n");
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_0;
		L_0 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		GUILayout_Label_m0DD89429577B101820231347FB04CFC489245502(_stringLiteralBAA0EAB272BE3FEF05FED2A6DDFCB50F93272B51, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void MB_PrepareObjectsForDynamicBatchingDescription::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_PrepareObjectsForDynamicBatchingDescription__ctor_mBD6923DD5071463BE639F9A86647D5182D19FBEA (MB_PrepareObjectsForDynamicBatchingDescription_t7E6322CFBF49D134B355E9347B8B4FB734E487DF * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_SkinnedMeshSceneController::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SkinnedMeshSceneController_Start_m84A18E9DA1372D4D0C8B18710F37E80B536B625F (MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentInChildren_TisSkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496_mBCB18247386FE1CD6449BA6EAAE856412A692586_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisAnimation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8_m92B9ADEC5AE6A5FB55D702AD0410469739EF307C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9F24FB9F6B79BD601755A6710686857F7B86347B);
		s_Il2CppMethodInitialized = true;
	}
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * V_0 = NULL;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_1 = NULL;
	{
		// GameObject worker1 = (GameObject)Instantiate(workerPrefab);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_0 = __this->get_workerPrefab_7();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_1;
		L_1 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33(L_0, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var);
		V_0 = L_1;
		// worker1.transform.position = new Vector3(1.31f, 0.985f, -0.25f);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_2 = V_0;
		NullCheck(L_2);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_3;
		L_3 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_2, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4;
		memset((&L_4), 0, sizeof(L_4));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_4), (1.30999994f), (0.985000014f), (-0.25f), /*hidden argument*/NULL);
		NullCheck(L_3);
		Transform_set_position_mB169E52D57EEAC1E3F22C5395968714E4F00AC91(L_3, L_4, /*hidden argument*/NULL);
		// Animation anim = worker1.GetComponent<Animation>();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_5 = V_0;
		NullCheck(L_5);
		Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * L_6;
		L_6 = GameObject_GetComponent_TisAnimation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8_m92B9ADEC5AE6A5FB55D702AD0410469739EF307C(L_5, /*hidden argument*/GameObject_GetComponent_TisAnimation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8_m92B9ADEC5AE6A5FB55D702AD0410469739EF307C_RuntimeMethod_var);
		// anim.wrapMode = WrapMode.Loop;
		Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * L_7 = L_6;
		NullCheck(L_7);
		Animation_set_wrapMode_m27F6F0A482EF9EB1CFB350E294D1404C8ADE8A94(L_7, 2, /*hidden argument*/NULL);
		// anim.cullingType = AnimationCullingType.AlwaysAnimate; //IMPORTANT
		Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * L_8 = L_7;
		NullCheck(L_8);
		Animation_set_cullingType_m65032F770648FA34658DAE194947173110CBAD08(L_8, 0, /*hidden argument*/NULL);
		// anim.Play("run");
		NullCheck(L_8);
		bool L_9;
		L_9 = Animation_Play_m8EDFE80589A27DF1C34CCC0CF81DB5313CE35607(L_8, _stringLiteral9F24FB9F6B79BD601755A6710686857F7B86347B, /*hidden argument*/NULL);
		// GameObject[] objsToAdd = new GameObject[1] { worker1.GetComponentInChildren<SkinnedMeshRenderer>().gameObject };
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_10 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)1);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_11 = L_10;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_12 = V_0;
		NullCheck(L_12);
		SkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496 * L_13;
		L_13 = GameObject_GetComponentInChildren_TisSkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496_mBCB18247386FE1CD6449BA6EAAE856412A692586(L_12, /*hidden argument*/GameObject_GetComponentInChildren_TisSkinnedMeshRenderer_t126F4D6010E0F4B2685A7817B0A9171805D8F496_mBCB18247386FE1CD6449BA6EAAE856412A692586_RuntimeMethod_var);
		NullCheck(L_13);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_14;
		L_14 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_13, /*hidden argument*/NULL);
		NullCheck(L_11);
		ArrayElementTypeCheck (L_11, L_14);
		(L_11)->SetAt(static_cast<il2cpp_array_size_t>(0), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_14);
		V_1 = L_11;
		// if (skinnedMeshBaker.AddDeleteGameObjects(objsToAdd, null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_15 = __this->get_skinnedMeshBaker_9();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_16 = V_1;
		NullCheck(L_15);
		bool L_17;
		L_17 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_15, L_16, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_17)
		{
			goto IL_007c;
		}
	}
	{
		// skinnedMeshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_18 = __this->get_skinnedMeshBaker_9();
		NullCheck(L_18);
		bool L_19;
		L_19 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_18, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_007c:
	{
		// }
		return;
	}
}
// System.Void MB_SkinnedMeshSceneController::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SkinnedMeshSceneController_OnGUI_m7AE87011F69EE0FC72AA32B2133D3933AEB5249E (MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral402FF1C40586BBD50501FAA0F8F03404A4726BCD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9B5270D77D3E3831C975E95DE1EB9D935744D556);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB02464A50A3B10AAA41DF03F87603D4EFABCFAF1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB13DE94066F2B882DE8E239513931BE1DFE46A03);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF3F758FD35A5DD16AA5EF6E3B5380F1BD4ADDA59);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralF864450B05AACC1DF7E89709AF0716CAD8A14213);
		s_Il2CppMethodInitialized = true;
	}
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * V_0 = NULL;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_1 = NULL;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_2 = NULL;
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * V_3 = NULL;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_4 = NULL;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_5 = NULL;
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * V_6 = NULL;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_7 = NULL;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_8 = NULL;
	{
		// if (GUILayout.Button("Add/Remove Sword"))
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_0;
		L_0 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		bool L_1;
		L_1 = GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162(_stringLiteral402FF1C40586BBD50501FAA0F8F03404A4726BCD, L_0, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_013c;
		}
	}
	{
		// if (swordInstance == null)
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_2 = __this->get_swordInstance_10();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_2, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_00d6;
		}
	}
	{
		// Transform hand = SearchHierarchyForBone(targetCharacter.transform, "RightHandAttachPoint");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_4 = __this->get_targetCharacter_8();
		NullCheck(L_4);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_5;
		L_5 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_4, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_6;
		L_6 = MB_SkinnedMeshSceneController_SearchHierarchyForBone_m06E65B46043DC5D5B28FB93129261C78C704C52C(__this, L_5, _stringLiteralB13DE94066F2B882DE8E239513931BE1DFE46A03, /*hidden argument*/NULL);
		V_0 = L_6;
		// swordInstance = (GameObject)Instantiate(swordPrefab);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_7 = __this->get_swordPrefab_4();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_8;
		L_8 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33(L_7, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var);
		__this->set_swordInstance_10(L_8);
		// swordInstance.transform.parent = hand;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_9 = __this->get_swordInstance_10();
		NullCheck(L_9);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_10;
		L_10 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_9, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_11 = V_0;
		NullCheck(L_10);
		Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13(L_10, L_11, /*hidden argument*/NULL);
		// swordInstance.transform.localPosition = Vector3.zero;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_12 = __this->get_swordInstance_10();
		NullCheck(L_12);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_13;
		L_13 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_12, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_14;
		L_14 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		NullCheck(L_13);
		Transform_set_localPosition_m2A2B0033EF079077FAE7C65196078EAF5D041AFC(L_13, L_14, /*hidden argument*/NULL);
		// swordInstance.transform.localRotation = Quaternion.identity;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_15 = __this->get_swordInstance_10();
		NullCheck(L_15);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_16;
		L_16 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_15, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_17;
		L_17 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		NullCheck(L_16);
		Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C(L_16, L_17, /*hidden argument*/NULL);
		// swordInstance.transform.localScale = Vector3.one;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_18 = __this->get_swordInstance_10();
		NullCheck(L_18);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_19;
		L_19 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_18, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_20;
		L_20 = Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB(/*hidden argument*/NULL);
		NullCheck(L_19);
		Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A(L_19, L_20, /*hidden argument*/NULL);
		// GameObject[] objsToAdd = new GameObject[1] { swordInstance.GetComponentInChildren<MeshRenderer>().gameObject };
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_21 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)1);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_22 = L_21;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_23 = __this->get_swordInstance_10();
		NullCheck(L_23);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_24;
		L_24 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_23, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_24);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_25;
		L_25 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_24, /*hidden argument*/NULL);
		NullCheck(L_22);
		ArrayElementTypeCheck (L_22, L_25);
		(L_22)->SetAt(static_cast<il2cpp_array_size_t>(0), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_25);
		V_1 = L_22;
		// if (skinnedMeshBaker.AddDeleteGameObjects(objsToAdd, null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_26 = __this->get_skinnedMeshBaker_9();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_27 = V_1;
		NullCheck(L_26);
		bool L_28;
		L_28 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_26, L_27, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_28)
		{
			goto IL_013c;
		}
	}
	{
		// skinnedMeshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_29 = __this->get_skinnedMeshBaker_9();
		NullCheck(L_29);
		bool L_30;
		L_30 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_29, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
		// }
		goto IL_013c;
	}

IL_00d6:
	{
		// else if (skinnedMeshBaker.CombinedMeshContains(swordInstance.GetComponentInChildren<MeshRenderer>().gameObject))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_31 = __this->get_skinnedMeshBaker_9();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_32 = __this->get_swordInstance_10();
		NullCheck(L_32);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_33;
		L_33 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_32, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_33);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_34;
		L_34 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_33, /*hidden argument*/NULL);
		NullCheck(L_31);
		bool L_35;
		L_35 = VirtFuncInvoker1< bool, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * >::Invoke(19 /* System.Boolean MB3_MeshBakerCommon::CombinedMeshContains(UnityEngine.GameObject) */, L_31, L_34);
		if (!L_35)
		{
			goto IL_013c;
		}
	}
	{
		// GameObject[] objsToDelete = new GameObject[1] { swordInstance.GetComponentInChildren<MeshRenderer>().gameObject };
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_36 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)1);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_37 = L_36;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_38 = __this->get_swordInstance_10();
		NullCheck(L_38);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_39;
		L_39 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_38, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_39);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_40;
		L_40 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_39, /*hidden argument*/NULL);
		NullCheck(L_37);
		ArrayElementTypeCheck (L_37, L_40);
		(L_37)->SetAt(static_cast<il2cpp_array_size_t>(0), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_40);
		V_2 = L_37;
		// if (skinnedMeshBaker.AddDeleteGameObjects(null, objsToDelete, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_41 = __this->get_skinnedMeshBaker_9();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_42 = V_2;
		NullCheck(L_41);
		bool L_43;
		L_43 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_41, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, L_42, (bool)1);
		if (!L_43)
		{
			goto IL_012a;
		}
	}
	{
		// skinnedMeshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_44 = __this->get_skinnedMeshBaker_9();
		NullCheck(L_44);
		bool L_45;
		L_45 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_44, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_012a:
	{
		// Destroy(swordInstance);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_46 = __this->get_swordInstance_10();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(L_46, /*hidden argument*/NULL);
		// swordInstance = null;
		__this->set_swordInstance_10((GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)NULL);
	}

IL_013c:
	{
		// if (GUILayout.Button("Add/Remove Hat"))
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_47;
		L_47 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		bool L_48;
		L_48 = GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162(_stringLiteralF3F758FD35A5DD16AA5EF6E3B5380F1BD4ADDA59, L_47, /*hidden argument*/NULL);
		if (!L_48)
		{
			goto IL_027c;
		}
	}
	{
		// if (hatInstance == null)
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_49 = __this->get_hatInstance_12();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_50;
		L_50 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_49, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_50)
		{
			goto IL_0214;
		}
	}
	{
		// Transform hand = SearchHierarchyForBone(targetCharacter.transform, "HeadAttachPoint");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_51 = __this->get_targetCharacter_8();
		NullCheck(L_51);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_52;
		L_52 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_51, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_53;
		L_53 = MB_SkinnedMeshSceneController_SearchHierarchyForBone_m06E65B46043DC5D5B28FB93129261C78C704C52C(__this, L_52, _stringLiteralB02464A50A3B10AAA41DF03F87603D4EFABCFAF1, /*hidden argument*/NULL);
		V_3 = L_53;
		// hatInstance = (GameObject)Instantiate(hatPrefab);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_54 = __this->get_hatPrefab_5();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_55;
		L_55 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33(L_54, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var);
		__this->set_hatInstance_12(L_55);
		// hatInstance.transform.parent = hand;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_56 = __this->get_hatInstance_12();
		NullCheck(L_56);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_57;
		L_57 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_56, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_58 = V_3;
		NullCheck(L_57);
		Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13(L_57, L_58, /*hidden argument*/NULL);
		// hatInstance.transform.localPosition = Vector3.zero;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_59 = __this->get_hatInstance_12();
		NullCheck(L_59);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_60;
		L_60 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_59, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_61;
		L_61 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		NullCheck(L_60);
		Transform_set_localPosition_m2A2B0033EF079077FAE7C65196078EAF5D041AFC(L_60, L_61, /*hidden argument*/NULL);
		// hatInstance.transform.localRotation = Quaternion.identity;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_62 = __this->get_hatInstance_12();
		NullCheck(L_62);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_63;
		L_63 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_62, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_64;
		L_64 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		NullCheck(L_63);
		Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C(L_63, L_64, /*hidden argument*/NULL);
		// hatInstance.transform.localScale = Vector3.one;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_65 = __this->get_hatInstance_12();
		NullCheck(L_65);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_66;
		L_66 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_65, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_67;
		L_67 = Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB(/*hidden argument*/NULL);
		NullCheck(L_66);
		Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A(L_66, L_67, /*hidden argument*/NULL);
		// GameObject[] objsToAdd = new GameObject[1] { hatInstance.GetComponentInChildren<MeshRenderer>().gameObject };
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_68 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)1);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_69 = L_68;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_70 = __this->get_hatInstance_12();
		NullCheck(L_70);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_71;
		L_71 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_70, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_71);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_72;
		L_72 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_71, /*hidden argument*/NULL);
		NullCheck(L_69);
		ArrayElementTypeCheck (L_69, L_72);
		(L_69)->SetAt(static_cast<il2cpp_array_size_t>(0), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_72);
		V_4 = L_69;
		// if (skinnedMeshBaker.AddDeleteGameObjects(objsToAdd, null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_73 = __this->get_skinnedMeshBaker_9();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_74 = V_4;
		NullCheck(L_73);
		bool L_75;
		L_75 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_73, L_74, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_75)
		{
			goto IL_027c;
		}
	}
	{
		// skinnedMeshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_76 = __this->get_skinnedMeshBaker_9();
		NullCheck(L_76);
		bool L_77;
		L_77 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_76, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
		// }
		goto IL_027c;
	}

IL_0214:
	{
		// else if (skinnedMeshBaker.CombinedMeshContains(hatInstance.GetComponentInChildren<MeshRenderer>().gameObject))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_78 = __this->get_skinnedMeshBaker_9();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_79 = __this->get_hatInstance_12();
		NullCheck(L_79);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_80;
		L_80 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_79, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_80);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_81;
		L_81 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_80, /*hidden argument*/NULL);
		NullCheck(L_78);
		bool L_82;
		L_82 = VirtFuncInvoker1< bool, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * >::Invoke(19 /* System.Boolean MB3_MeshBakerCommon::CombinedMeshContains(UnityEngine.GameObject) */, L_78, L_81);
		if (!L_82)
		{
			goto IL_027c;
		}
	}
	{
		// GameObject[] objsToDelete = new GameObject[1] { hatInstance.GetComponentInChildren<MeshRenderer>().gameObject };
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_83 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)1);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_84 = L_83;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_85 = __this->get_hatInstance_12();
		NullCheck(L_85);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_86;
		L_86 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_85, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_86);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_87;
		L_87 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_86, /*hidden argument*/NULL);
		NullCheck(L_84);
		ArrayElementTypeCheck (L_84, L_87);
		(L_84)->SetAt(static_cast<il2cpp_array_size_t>(0), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_87);
		V_5 = L_84;
		// if (skinnedMeshBaker.AddDeleteGameObjects(null, objsToDelete, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_88 = __this->get_skinnedMeshBaker_9();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_89 = V_5;
		NullCheck(L_88);
		bool L_90;
		L_90 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_88, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, L_89, (bool)1);
		if (!L_90)
		{
			goto IL_026a;
		}
	}
	{
		// skinnedMeshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_91 = __this->get_skinnedMeshBaker_9();
		NullCheck(L_91);
		bool L_92;
		L_92 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_91, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_026a:
	{
		// Destroy(hatInstance);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_93 = __this->get_hatInstance_12();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(L_93, /*hidden argument*/NULL);
		// hatInstance = null;
		__this->set_hatInstance_12((GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)NULL);
	}

IL_027c:
	{
		// if (GUILayout.Button("Add/Remove Glasses"))
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_94;
		L_94 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		bool L_95;
		L_95 = GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162(_stringLiteralF864450B05AACC1DF7E89709AF0716CAD8A14213, L_94, /*hidden argument*/NULL);
		if (!L_95)
		{
			goto IL_03bd;
		}
	}
	{
		// if (glassesInstance == null)
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_96 = __this->get_glassesInstance_11();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_97;
		L_97 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_96, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_97)
		{
			goto IL_0355;
		}
	}
	{
		// Transform hand = SearchHierarchyForBone(targetCharacter.transform, "NoseAttachPoint");
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_98 = __this->get_targetCharacter_8();
		NullCheck(L_98);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_99;
		L_99 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_98, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_100;
		L_100 = MB_SkinnedMeshSceneController_SearchHierarchyForBone_m06E65B46043DC5D5B28FB93129261C78C704C52C(__this, L_99, _stringLiteral9B5270D77D3E3831C975E95DE1EB9D935744D556, /*hidden argument*/NULL);
		V_6 = L_100;
		// glassesInstance = (GameObject)Instantiate(glassesPrefab);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_101 = __this->get_glassesPrefab_6();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_102;
		L_102 = Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33(L_101, /*hidden argument*/Object_Instantiate_TisGameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319_m26431AC51B9B7A43FBABD10B4923B72B0C578F33_RuntimeMethod_var);
		__this->set_glassesInstance_11(L_102);
		// glassesInstance.transform.parent = hand;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_103 = __this->get_glassesInstance_11();
		NullCheck(L_103);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_104;
		L_104 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_103, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_105 = V_6;
		NullCheck(L_104);
		Transform_set_parent_mEAE304E1A804E8B83054CEECB5BF1E517196EC13(L_104, L_105, /*hidden argument*/NULL);
		// glassesInstance.transform.localPosition = Vector3.zero;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_106 = __this->get_glassesInstance_11();
		NullCheck(L_106);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_107;
		L_107 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_106, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_108;
		L_108 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		NullCheck(L_107);
		Transform_set_localPosition_m2A2B0033EF079077FAE7C65196078EAF5D041AFC(L_107, L_108, /*hidden argument*/NULL);
		// glassesInstance.transform.localRotation = Quaternion.identity;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_109 = __this->get_glassesInstance_11();
		NullCheck(L_109);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_110;
		L_110 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_109, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_111;
		L_111 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		NullCheck(L_110);
		Transform_set_localRotation_m1A9101457EC4653AFC93FCC4065A29F2C78FA62C(L_110, L_111, /*hidden argument*/NULL);
		// glassesInstance.transform.localScale = Vector3.one;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_112 = __this->get_glassesInstance_11();
		NullCheck(L_112);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_113;
		L_113 = GameObject_get_transform_m16A80BB92B6C8C5AB696E447014D45EDF1E4DE34(L_112, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_114;
		L_114 = Vector3_get_one_m9CDE5C456038B133ED94402673859EC37B1C1CCB(/*hidden argument*/NULL);
		NullCheck(L_113);
		Transform_set_localScale_mF4D1611E48D1BA7566A1E166DC2DACF3ADD8BA3A(L_113, L_114, /*hidden argument*/NULL);
		// GameObject[] objsToAdd = new GameObject[1] { glassesInstance.GetComponentInChildren<MeshRenderer>().gameObject };
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_115 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)1);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_116 = L_115;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_117 = __this->get_glassesInstance_11();
		NullCheck(L_117);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_118;
		L_118 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_117, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_118);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_119;
		L_119 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_118, /*hidden argument*/NULL);
		NullCheck(L_116);
		ArrayElementTypeCheck (L_116, L_119);
		(L_116)->SetAt(static_cast<il2cpp_array_size_t>(0), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_119);
		V_7 = L_116;
		// if (skinnedMeshBaker.AddDeleteGameObjects(objsToAdd, null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_120 = __this->get_skinnedMeshBaker_9();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_121 = V_7;
		NullCheck(L_120);
		bool L_122;
		L_122 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_120, L_121, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_122)
		{
			goto IL_03bd;
		}
	}
	{
		// skinnedMeshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_123 = __this->get_skinnedMeshBaker_9();
		NullCheck(L_123);
		bool L_124;
		L_124 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_123, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
		// }
		return;
	}

IL_0355:
	{
		// else if (skinnedMeshBaker.CombinedMeshContains(glassesInstance.GetComponentInChildren<MeshRenderer>().gameObject))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_125 = __this->get_skinnedMeshBaker_9();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_126 = __this->get_glassesInstance_11();
		NullCheck(L_126);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_127;
		L_127 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_126, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_127);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_128;
		L_128 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_127, /*hidden argument*/NULL);
		NullCheck(L_125);
		bool L_129;
		L_129 = VirtFuncInvoker1< bool, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * >::Invoke(19 /* System.Boolean MB3_MeshBakerCommon::CombinedMeshContains(UnityEngine.GameObject) */, L_125, L_128);
		if (!L_129)
		{
			goto IL_03bd;
		}
	}
	{
		// GameObject[] objsToDelete = new GameObject[1] { glassesInstance.GetComponentInChildren<MeshRenderer>().gameObject };
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_130 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)1);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_131 = L_130;
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_132 = __this->get_glassesInstance_11();
		NullCheck(L_132);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_133;
		L_133 = GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339(L_132, /*hidden argument*/GameObject_GetComponentInChildren_TisMeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B_m4D003AE0E929BFDFE76762C00146548B0BB0D339_RuntimeMethod_var);
		NullCheck(L_133);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_134;
		L_134 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_133, /*hidden argument*/NULL);
		NullCheck(L_131);
		ArrayElementTypeCheck (L_131, L_134);
		(L_131)->SetAt(static_cast<il2cpp_array_size_t>(0), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_134);
		V_8 = L_131;
		// if (skinnedMeshBaker.AddDeleteGameObjects(null, objsToDelete, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_135 = __this->get_skinnedMeshBaker_9();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_136 = V_8;
		NullCheck(L_135);
		bool L_137;
		L_137 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_135, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, L_136, (bool)1);
		if (!L_137)
		{
			goto IL_03ab;
		}
	}
	{
		// skinnedMeshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_138 = __this->get_skinnedMeshBaker_9();
		NullCheck(L_138);
		bool L_139;
		L_139 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_138, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_03ab:
	{
		// Destroy(glassesInstance);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_140 = __this->get_glassesInstance_11();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(L_140, /*hidden argument*/NULL);
		// glassesInstance = null;
		__this->set_glassesInstance_11((GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)NULL);
	}

IL_03bd:
	{
		// }
		return;
	}
}
// UnityEngine.Transform MB_SkinnedMeshSceneController::SearchHierarchyForBone(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * MB_SkinnedMeshSceneController_SearchHierarchyForBone_m06E65B46043DC5D5B28FB93129261C78C704C52C (MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___current0, String_t* ___name1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * V_1 = NULL;
	{
		// if (current.name.Equals(name))
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_0 = ___current0;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_0, /*hidden argument*/NULL);
		String_t* L_2 = ___name1;
		NullCheck(L_1);
		bool L_3;
		L_3 = String_Equals_m8A062B96B61A7D652E7D73C9B3E904F6B0E5F41D(L_1, L_2, /*hidden argument*/NULL);
		if (!L_3)
		{
			goto IL_0010;
		}
	}
	{
		// return current;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_4 = ___current0;
		return L_4;
	}

IL_0010:
	{
		// for (int i = 0; i < current.childCount; ++i)
		V_0 = 0;
		goto IL_0032;
	}

IL_0014:
	{
		// Transform found = SearchHierarchyForBone(current.GetChild(i), name);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_5 = ___current0;
		int32_t L_6 = V_0;
		NullCheck(L_5);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_7;
		L_7 = Transform_GetChild_mA7D94BEFF0144F76561D9B8FED61C5C939EC1F1C(L_5, L_6, /*hidden argument*/NULL);
		String_t* L_8 = ___name1;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_9;
		L_9 = MB_SkinnedMeshSceneController_SearchHierarchyForBone_m06E65B46043DC5D5B28FB93129261C78C704C52C(__this, L_7, L_8, /*hidden argument*/NULL);
		V_1 = L_9;
		// if (found != null)
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_10 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_11;
		L_11 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_10, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_11)
		{
			goto IL_002e;
		}
	}
	{
		// return found;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_12 = V_1;
		return L_12;
	}

IL_002e:
	{
		// for (int i = 0; i < current.childCount; ++i)
		int32_t L_13 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_13, (int32_t)1));
	}

IL_0032:
	{
		// for (int i = 0; i < current.childCount; ++i)
		int32_t L_14 = V_0;
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_15 = ___current0;
		NullCheck(L_15);
		int32_t L_16;
		L_16 = Transform_get_childCount_mCBED4F6D3F6A7386C4D97C2C3FD25C383A0BCD05(L_15, /*hidden argument*/NULL);
		if ((((int32_t)L_14) < ((int32_t)L_16)))
		{
			goto IL_0014;
		}
	}
	{
		// return null;
		return (Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 *)NULL;
	}
}
// System.Void MB_SkinnedMeshSceneController::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SkinnedMeshSceneController__ctor_m3A6C5B04C8EE62EEDD71F26E4697903196A73CD0 (MB_SkinnedMeshSceneController_tF20C5D97CCE39D03571199325AC042759116B711 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_SwapShirts::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwapShirts_Start_m139C94BECE53AF7EB2E5746FBFCF1D6B21C66F73 (MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// GameObject[] objs = new GameObject[clothingAndBodyPartsBareTorso.Length];
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_0 = __this->get_clothingAndBodyPartsBareTorso_5();
		NullCheck(L_0);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_1 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)((int32_t)((int32_t)(((RuntimeArray*)L_0)->max_length))));
		V_0 = L_1;
		// for (int i = 0; i < clothingAndBodyPartsBareTorso.Length; i++)
		V_1 = 0;
		goto IL_0026;
	}

IL_0012:
	{
		// objs[i] = clothingAndBodyPartsBareTorso[i].gameObject;
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_2 = V_0;
		int32_t L_3 = V_1;
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_4 = __this->get_clothingAndBodyPartsBareTorso_5();
		int32_t L_5 = V_1;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		NullCheck(L_7);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_8;
		L_8 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_7, /*hidden argument*/NULL);
		NullCheck(L_2);
		ArrayElementTypeCheck (L_2, L_8);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(L_3), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_8);
		// for (int i = 0; i < clothingAndBodyPartsBareTorso.Length; i++)
		int32_t L_9 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_9, (int32_t)1));
	}

IL_0026:
	{
		// for (int i = 0; i < clothingAndBodyPartsBareTorso.Length; i++)
		int32_t L_10 = V_1;
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_11 = __this->get_clothingAndBodyPartsBareTorso_5();
		NullCheck(L_11);
		if ((((int32_t)L_10) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_11)->max_length))))))
		{
			goto IL_0012;
		}
	}
	{
		// meshBaker.ClearMesh();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_12 = __this->get_meshBaker_4();
		NullCheck(L_12);
		VirtActionInvoker0::Invoke(9 /* System.Void MB3_MeshBakerCommon::ClearMesh() */, L_12);
		// if (meshBaker.AddDeleteGameObjects(objs, null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_13 = __this->get_meshBaker_4();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_14 = V_0;
		NullCheck(L_13);
		bool L_15;
		L_15 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_13, L_14, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_15)
		{
			goto IL_0059;
		}
	}
	{
		// meshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_16 = __this->get_meshBaker_4();
		NullCheck(L_16);
		bool L_17;
		L_17 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_16, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_0059:
	{
		// }
		return;
	}
}
// System.Void MB_SwapShirts::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwapShirts_OnGUI_mC5D5F7BF2452EA63AEEF949CA35786F32EA4D64E (MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1F7C34975DFE706DD833966CB44E790BC5F368E9);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral84BE4104B995B0C9A1BE75ACFE52A28EAEBEC7BE);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB94ABD5415DFD72925D621D57063D571A5D90722);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (GUILayout.Button("Wear Hoodie"))
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_0;
		L_0 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		bool L_1;
		L_1 = GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162(_stringLiteral84BE4104B995B0C9A1BE75ACFE52A28EAEBEC7BE, L_0, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_001d;
		}
	}
	{
		// ChangeOutfit(clothingAndBodyPartsHoodie);
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_2 = __this->get_clothingAndBodyPartsHoodie_7();
		MB_SwapShirts_ChangeOutfit_m826844529AAC21F9F16961B872D9DBC20291F746(__this, L_2, /*hidden argument*/NULL);
	}

IL_001d:
	{
		// if (GUILayout.Button("Bare Torso"))
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_3;
		L_3 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		bool L_4;
		L_4 = GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162(_stringLiteral1F7C34975DFE706DD833966CB44E790BC5F368E9, L_3, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_003a;
		}
	}
	{
		// ChangeOutfit(clothingAndBodyPartsBareTorso);
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_5 = __this->get_clothingAndBodyPartsBareTorso_5();
		MB_SwapShirts_ChangeOutfit_m826844529AAC21F9F16961B872D9DBC20291F746(__this, L_5, /*hidden argument*/NULL);
	}

IL_003a:
	{
		// if (GUILayout.Button("Damaged Arm"))
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_6;
		L_6 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		bool L_7;
		L_7 = GUILayout_Button_m749F2887D57BDC9B6901F2C35F5C6A7E22154162(_stringLiteralB94ABD5415DFD72925D621D57063D571A5D90722, L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0057;
		}
	}
	{
		// ChangeOutfit(clothingAndBodyPartsBareTorsoDamagedArm);
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_8 = __this->get_clothingAndBodyPartsBareTorsoDamagedArm_6();
		MB_SwapShirts_ChangeOutfit_m826844529AAC21F9F16961B872D9DBC20291F746(__this, L_8, /*hidden argument*/NULL);
	}

IL_0057:
	{
		// }
		return;
	}
}
// System.Void MB_SwapShirts::ChangeOutfit(UnityEngine.Renderer[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwapShirts_ChangeOutfit_m826844529AAC21F9F16961B872D9DBC20291F746 (MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A * __this, RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* ___outfit0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_Dispose_m4B68F0A4E0441A036D7E39BC7E639536164196D9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_MoveNext_mF39107B3A55F66C83EBCA798CBC93AC4C990DBD7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_get_Current_mB38DBEFCD264B4682A190F8592464C0658F702B7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_mD787758BED3337F182C18CC67C516C2A11B55466_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Contains_mE508A129A7CB4DC89530674E7854B7F699BB486F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_GetEnumerator_m3616D04A85546C8251A6C376656CDB5358D893F6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6A858309322EB401D88265AE411835295660D2D6);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8486A1F3A607D4973F36A2FB09B9E8A935DD95F2);
		s_Il2CppMethodInitialized = true;
	}
	List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * V_0 = NULL;
	List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * V_1 = NULL;
	Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14  V_2;
	memset((&V_2), 0, sizeof(V_2));
	Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * V_3 = NULL;
	bool V_4 = false;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	Exception_t * __last_unhandled_exception = 0;
	il2cpp::utils::ExceptionSupportStack<int32_t, 1> __leave_targets;
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * G_B10_0 = NULL;
	String_t* G_B10_1 = NULL;
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * G_B9_0 = NULL;
	String_t* G_B9_1 = NULL;
	String_t* G_B11_0 = NULL;
	String_t* G_B11_1 = NULL;
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * G_B19_0 = NULL;
	String_t* G_B19_1 = NULL;
	GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * G_B18_0 = NULL;
	String_t* G_B18_1 = NULL;
	String_t* G_B20_0 = NULL;
	String_t* G_B20_1 = NULL;
	{
		// List<GameObject> objectsWeAreRemoving = new List<GameObject>();
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_0 = (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 *)il2cpp_codegen_object_new(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5_il2cpp_TypeInfo_var);
		List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8(L_0, /*hidden argument*/List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8_RuntimeMethod_var);
		V_0 = L_0;
		// foreach (GameObject item in meshBaker.meshCombiner.GetObjectsInCombined())
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_1 = __this->get_meshBaker_4();
		NullCheck(L_1);
		MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51 * L_2;
		L_2 = VirtFuncInvoker0< MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51 * >::Invoke(8 /* DigitalOpus.MB.Core.MB3_MeshCombiner MB3_MeshBakerCommon::get_meshCombiner() */, L_1);
		NullCheck(L_2);
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_3;
		L_3 = VirtFuncInvoker0< List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * >::Invoke(106 /* System.Collections.Generic.List`1<UnityEngine.GameObject> DigitalOpus.MB.Core.MB3_MeshCombiner::GetObjectsInCombined() */, L_2);
		NullCheck(L_3);
		Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14  L_4;
		L_4 = List_1_GetEnumerator_m3616D04A85546C8251A6C376656CDB5358D893F6(L_3, /*hidden argument*/List_1_GetEnumerator_m3616D04A85546C8251A6C376656CDB5358D893F6_RuntimeMethod_var);
		V_2 = L_4;
	}

IL_001c:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0082;
		}

IL_001e:
		{
			// foreach (GameObject item in meshBaker.meshCombiner.GetObjectsInCombined())
			GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_5;
			L_5 = Enumerator_get_Current_mB38DBEFCD264B4682A190F8592464C0658F702B7_inline((Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 *)(&V_2), /*hidden argument*/Enumerator_get_Current_mB38DBEFCD264B4682A190F8592464C0658F702B7_RuntimeMethod_var);
			// Renderer r = item.GetComponent<Renderer>();
			NullCheck(L_5);
			Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_6;
			L_6 = GameObject_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_mD787758BED3337F182C18CC67C516C2A11B55466(L_5, /*hidden argument*/GameObject_GetComponent_TisRenderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C_mD787758BED3337F182C18CC67C516C2A11B55466_RuntimeMethod_var);
			V_3 = L_6;
			// bool foundInOutfit = false;
			V_4 = (bool)0;
			// for (int i = 0; i < outfit.Length; i++)
			V_5 = 0;
			goto IL_004a;
		}

IL_0033:
		{
			// if (r == outfit[i])
			Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_7 = V_3;
			RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_8 = ___outfit0;
			int32_t L_9 = V_5;
			NullCheck(L_8);
			int32_t L_10 = L_9;
			Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_11 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
			IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
			bool L_12;
			L_12 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_7, L_11, /*hidden argument*/NULL);
			if (!L_12)
			{
				goto IL_0044;
			}
		}

IL_003f:
		{
			// foundInOutfit = true;
			V_4 = (bool)1;
			// break;
			goto IL_0051;
		}

IL_0044:
		{
			// for (int i = 0; i < outfit.Length; i++)
			int32_t L_13 = V_5;
			V_5 = ((int32_t)il2cpp_codegen_add((int32_t)L_13, (int32_t)1));
		}

IL_004a:
		{
			// for (int i = 0; i < outfit.Length; i++)
			int32_t L_14 = V_5;
			RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_15 = ___outfit0;
			NullCheck(L_15);
			if ((((int32_t)L_14) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_15)->max_length))))))
			{
				goto IL_0033;
			}
		}

IL_0051:
		{
			// if (!foundInOutfit)
			bool L_16 = V_4;
			if (L_16)
			{
				goto IL_0082;
			}
		}

IL_0055:
		{
			// objectsWeAreRemoving.Add(r.gameObject);
			List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_17 = V_0;
			Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_18 = V_3;
			NullCheck(L_18);
			GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_19;
			L_19 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_18, /*hidden argument*/NULL);
			NullCheck(L_17);
			List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3(L_17, L_19, /*hidden argument*/List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3_RuntimeMethod_var);
			// Debug.Log("Removing " + r.gameObject);
			Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_20 = V_3;
			NullCheck(L_20);
			GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_21;
			L_21 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_20, /*hidden argument*/NULL);
			GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_22 = L_21;
			G_B9_0 = L_22;
			G_B9_1 = _stringLiteral8486A1F3A607D4973F36A2FB09B9E8A935DD95F2;
			if (L_22)
			{
				G_B10_0 = L_22;
				G_B10_1 = _stringLiteral8486A1F3A607D4973F36A2FB09B9E8A935DD95F2;
				goto IL_0073;
			}
		}

IL_006f:
		{
			G_B11_0 = ((String_t*)(NULL));
			G_B11_1 = G_B9_1;
			goto IL_0078;
		}

IL_0073:
		{
			NullCheck(G_B10_0);
			String_t* L_23;
			L_23 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B10_0);
			G_B11_0 = L_23;
			G_B11_1 = G_B10_1;
		}

IL_0078:
		{
			String_t* L_24;
			L_24 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(G_B11_1, G_B11_0, /*hidden argument*/NULL);
			IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
			Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_24, /*hidden argument*/NULL);
		}

IL_0082:
		{
			// foreach (GameObject item in meshBaker.meshCombiner.GetObjectsInCombined())
			bool L_25;
			L_25 = Enumerator_MoveNext_mF39107B3A55F66C83EBCA798CBC93AC4C990DBD7((Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 *)(&V_2), /*hidden argument*/Enumerator_MoveNext_mF39107B3A55F66C83EBCA798CBC93AC4C990DBD7_RuntimeMethod_var);
			if (L_25)
			{
				goto IL_001e;
			}
		}

IL_008b:
		{
			IL2CPP_LEAVE(0x9B, FINALLY_008d);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_008d;
	}

FINALLY_008d:
	{ // begin finally (depth: 1)
		Enumerator_Dispose_m4B68F0A4E0441A036D7E39BC7E639536164196D9((Enumerator_tFF7242F2EA0307D809676E9B45A3AF1F8BB52A14 *)(&V_2), /*hidden argument*/Enumerator_Dispose_m4B68F0A4E0441A036D7E39BC7E639536164196D9_RuntimeMethod_var);
		IL2CPP_END_FINALLY(141)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(141)
	{
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
		IL2CPP_JUMP_TBL(0x9B, IL_009b)
	}

IL_009b:
	{
		// List<GameObject> objectsWeAreAdding = new List<GameObject>();
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_26 = (List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 *)il2cpp_codegen_object_new(List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5_il2cpp_TypeInfo_var);
		List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8(L_26, /*hidden argument*/List_1__ctor_m859B0EE8491FDDEB1A3F7115D334B863E025BBC8_RuntimeMethod_var);
		V_1 = L_26;
		// for (int i = 0; i < outfit.Length; i++)
		V_6 = 0;
		goto IL_00ff;
	}

IL_00a6:
	{
		// if (!meshBaker.meshCombiner.GetObjectsInCombined().Contains(outfit[i].gameObject))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_27 = __this->get_meshBaker_4();
		NullCheck(L_27);
		MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51 * L_28;
		L_28 = VirtFuncInvoker0< MB3_MeshCombiner_tACECF6264F113852E4541B3F879C75AEEC114B51 * >::Invoke(8 /* DigitalOpus.MB.Core.MB3_MeshCombiner MB3_MeshBakerCommon::get_meshCombiner() */, L_27);
		NullCheck(L_28);
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_29;
		L_29 = VirtFuncInvoker0< List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * >::Invoke(106 /* System.Collections.Generic.List`1<UnityEngine.GameObject> DigitalOpus.MB.Core.MB3_MeshCombiner::GetObjectsInCombined() */, L_28);
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_30 = ___outfit0;
		int32_t L_31 = V_6;
		NullCheck(L_30);
		int32_t L_32 = L_31;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_33 = (L_30)->GetAt(static_cast<il2cpp_array_size_t>(L_32));
		NullCheck(L_33);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_34;
		L_34 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_33, /*hidden argument*/NULL);
		NullCheck(L_29);
		bool L_35;
		L_35 = List_1_Contains_mE508A129A7CB4DC89530674E7854B7F699BB486F(L_29, L_34, /*hidden argument*/List_1_Contains_mE508A129A7CB4DC89530674E7854B7F699BB486F_RuntimeMethod_var);
		if (L_35)
		{
			goto IL_00f9;
		}
	}
	{
		// objectsWeAreAdding.Add(outfit[i].gameObject);
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_36 = V_1;
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_37 = ___outfit0;
		int32_t L_38 = V_6;
		NullCheck(L_37);
		int32_t L_39 = L_38;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_40 = (L_37)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		NullCheck(L_40);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_41;
		L_41 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_40, /*hidden argument*/NULL);
		NullCheck(L_36);
		List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3(L_36, L_41, /*hidden argument*/List_1_Add_m3DD76DE838FA83DF972E0486A296345EB3A7DDF3_RuntimeMethod_var);
		// Debug.Log("Adding " + outfit[i].gameObject);
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_42 = ___outfit0;
		int32_t L_43 = V_6;
		NullCheck(L_42);
		int32_t L_44 = L_43;
		Renderer_t58147AB5B00224FE1460FD47542DC0DA7EC9378C * L_45 = (L_42)->GetAt(static_cast<il2cpp_array_size_t>(L_44));
		NullCheck(L_45);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_46;
		L_46 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_45, /*hidden argument*/NULL);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_47 = L_46;
		G_B18_0 = L_47;
		G_B18_1 = _stringLiteral6A858309322EB401D88265AE411835295660D2D6;
		if (L_47)
		{
			G_B19_0 = L_47;
			G_B19_1 = _stringLiteral6A858309322EB401D88265AE411835295660D2D6;
			goto IL_00ea;
		}
	}
	{
		G_B20_0 = ((String_t*)(NULL));
		G_B20_1 = G_B18_1;
		goto IL_00ef;
	}

IL_00ea:
	{
		NullCheck(G_B19_0);
		String_t* L_48;
		L_48 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B19_0);
		G_B20_0 = L_48;
		G_B20_1 = G_B19_1;
	}

IL_00ef:
	{
		String_t* L_49;
		L_49 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(G_B20_1, G_B20_0, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_49, /*hidden argument*/NULL);
	}

IL_00f9:
	{
		// for (int i = 0; i < outfit.Length; i++)
		int32_t L_50 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add((int32_t)L_50, (int32_t)1));
	}

IL_00ff:
	{
		// for (int i = 0; i < outfit.Length; i++)
		int32_t L_51 = V_6;
		RendererU5BU5D_tE2D3C4350893C593CA40DE876B9F2F0EBBEC49B7* L_52 = ___outfit0;
		NullCheck(L_52);
		if ((((int32_t)L_51) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_52)->max_length))))))
		{
			goto IL_00a6;
		}
	}
	{
		// if (meshBaker.AddDeleteGameObjects(objectsWeAreAdding.ToArray(), objectsWeAreRemoving.ToArray(), true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_53 = __this->get_meshBaker_4();
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_54 = V_1;
		NullCheck(L_54);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_55;
		L_55 = List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F(L_54, /*hidden argument*/List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_56 = V_0;
		NullCheck(L_56);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_57;
		L_57 = List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F(L_56, /*hidden argument*/List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		NullCheck(L_53);
		bool L_58;
		L_58 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_53, L_55, L_57, (bool)1);
		if (!L_58)
		{
			goto IL_012d;
		}
	}
	{
		// meshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_59 = __this->get_meshBaker_4();
		NullCheck(L_59);
		bool L_60;
		L_60 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_59, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_012d:
	{
		// }
		return;
	}
}
// System.Void MB_SwapShirts::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwapShirts__ctor_m38F11DF72F7BA14533AEC1313004F2AF4869F93D (MB_SwapShirts_t0840C9A562C863F9F53B9F2B560AF5647C57EF6A * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_SwitchBakedObjectsTexture::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwitchBakedObjectsTexture_OnGUI_m73DAC6EAE582B6BCE883CEE3D0F51C476C130B35 (MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral96DB94E82B2C0B32BDD0F4D65857163BAC78861E);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUILayout.Label("Press space to switch the material on one of the cubes. " +
		//         "This scene reuses the Texture Bake Result from the SceneBasic example.");
		GUILayoutOptionU5BU5D_tA0F031CC36F88BBBD25D6841ADD3913446E6EA2B* L_0;
		L_0 = Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_inline(/*hidden argument*/Array_Empty_TisGUILayoutOption_t2D992ABCB62BEB24A6F4A826A5CBE7AE236071AB_m6EB599DF46848C50C5E2A836AF0BDA9C81B1A23A_RuntimeMethod_var);
		GUILayout_Label_m0DD89429577B101820231347FB04CFC489245502(_stringLiteral96DB94E82B2C0B32BDD0F4D65857163BAC78861E, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void MB_SwitchBakedObjectsTexture::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwitchBakedObjectsTexture_Start_m57BC1016033F2E2EC8878D111901D453DB0B1923 (MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// meshBaker.ClearMesh();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_0 = __this->get_meshBaker_6();
		NullCheck(L_0);
		VirtActionInvoker0::Invoke(9 /* System.Void MB3_MeshBakerCommon::ClearMesh() */, L_0);
		// if (meshBaker.AddDeleteGameObjects(meshBaker.GetObjectsToCombine().ToArray(), null, true))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_1 = __this->get_meshBaker_6();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_2 = __this->get_meshBaker_6();
		NullCheck(L_2);
		List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * L_3;
		L_3 = VirtFuncInvoker0< List_1_t6D0A10F47F3440798295D2FFFC6D016477AF38E5 * >::Invoke(6 /* System.Collections.Generic.List`1<UnityEngine.GameObject> MB3_MeshBakerRoot::GetObjectsToCombine() */, L_2);
		NullCheck(L_3);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_4;
		L_4 = List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F(L_3, /*hidden argument*/List_1_ToArray_m3A7E83C4E885F8DF9164674E883558383CD2368F_RuntimeMethod_var);
		NullCheck(L_1);
		bool L_5;
		L_5 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_1, L_4, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_5)
		{
			goto IL_0037;
		}
	}
	{
		// meshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_6 = __this->get_meshBaker_6();
		NullCheck(L_6);
		bool L_7;
		L_7 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_6, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_0037:
	{
		// }
		return;
	}
}
// System.Void MB_SwitchBakedObjectsTexture::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwitchBakedObjectsTexture_Update_mF8B40E2CA4C54AA393D66265D9B365A3202D2BD5 (MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC84A871C8490BEB7482BEFA51B4C6EABB2E98A56);
		s_Il2CppMethodInitialized = true;
	}
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* V_3 = NULL;
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * G_B11_0 = NULL;
	String_t* G_B11_1 = NULL;
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * G_B10_0 = NULL;
	String_t* G_B10_1 = NULL;
	String_t* G_B12_0 = NULL;
	String_t* G_B12_1 = NULL;
	{
		// if (Input.GetKeyDown(KeyCode.Space))
		bool L_0;
		L_0 = Input_GetKeyDown_m476116696E71771641BBECBAB1A4C55E69018220(((int32_t)32), /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_00c6;
		}
	}
	{
		// Material mat = targetRenderer.sharedMaterial;
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_1 = __this->get_targetRenderer_4();
		NullCheck(L_1);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_2;
		L_2 = Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		// int materialIdx = -1;
		V_1 = (-1);
		// for (int i = 0; i < materials.Length; i++)
		V_2 = 0;
		goto IL_0034;
	}

IL_001e:
	{
		// if (materials[i] == mat)
		MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492* L_3 = __this->get_materials_5();
		int32_t L_4 = V_2;
		NullCheck(L_3);
		int32_t L_5 = L_4;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_7 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_8;
		L_8 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_6, L_7, /*hidden argument*/NULL);
		if (!L_8)
		{
			goto IL_0030;
		}
	}
	{
		// materialIdx = i;
		int32_t L_9 = V_2;
		V_1 = L_9;
	}

IL_0030:
	{
		// for (int i = 0; i < materials.Length; i++)
		int32_t L_10 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_10, (int32_t)1));
	}

IL_0034:
	{
		// for (int i = 0; i < materials.Length; i++)
		int32_t L_11 = V_2;
		MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492* L_12 = __this->get_materials_5();
		NullCheck(L_12);
		if ((((int32_t)L_11) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_12)->max_length))))))
		{
			goto IL_001e;
		}
	}
	{
		// materialIdx++;
		int32_t L_13 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_13, (int32_t)1));
		// if (materialIdx >= materials.Length) materialIdx = 0;
		int32_t L_14 = V_1;
		MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492* L_15 = __this->get_materials_5();
		NullCheck(L_15);
		if ((((int32_t)L_14) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_15)->max_length))))))
		{
			goto IL_0050;
		}
	}
	{
		// if (materialIdx >= materials.Length) materialIdx = 0;
		V_1 = 0;
	}

IL_0050:
	{
		// if (materialIdx != -1)
		int32_t L_16 = V_1;
		if ((((int32_t)L_16) == ((int32_t)(-1))))
		{
			goto IL_00c6;
		}
	}
	{
		// targetRenderer.sharedMaterial = materials[materialIdx];
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_17 = __this->get_targetRenderer_4();
		MaterialU5BU5D_t3AE4936F3CA08FB9EE182A935E665EA9CDA5E492* L_18 = __this->get_materials_5();
		int32_t L_19 = V_1;
		NullCheck(L_18);
		int32_t L_20 = L_19;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_21 = (L_18)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		NullCheck(L_17);
		Renderer_set_sharedMaterial_m1E66766F93E95F692C3C9C2C09AFD795B156678B(L_17, L_21, /*hidden argument*/NULL);
		// Debug.Log("Updating Material to: " + targetRenderer.sharedMaterial);
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_22 = __this->get_targetRenderer_4();
		NullCheck(L_22);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_23;
		L_23 = Renderer_get_sharedMaterial_m42DF538F0C6EA249B1FB626485D45D083BA74FCC(L_22, /*hidden argument*/NULL);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_24 = L_23;
		G_B10_0 = L_24;
		G_B10_1 = _stringLiteralC84A871C8490BEB7482BEFA51B4C6EABB2E98A56;
		if (L_24)
		{
			G_B11_0 = L_24;
			G_B11_1 = _stringLiteralC84A871C8490BEB7482BEFA51B4C6EABB2E98A56;
			goto IL_007e;
		}
	}
	{
		G_B12_0 = ((String_t*)(NULL));
		G_B12_1 = G_B10_1;
		goto IL_0083;
	}

IL_007e:
	{
		NullCheck(G_B11_0);
		String_t* L_25;
		L_25 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, G_B11_0);
		G_B12_0 = L_25;
		G_B12_1 = G_B11_1;
	}

IL_0083:
	{
		String_t* L_26;
		L_26 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(G_B12_1, G_B12_0, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_Log_mC26E5AD0D8D156C7FFD173AA15827F69225E9DB8(L_26, /*hidden argument*/NULL);
		// GameObject[] gameObjects = new GameObject[] { targetRenderer.gameObject };
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_27 = (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)SZArrayNew(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642_il2cpp_TypeInfo_var, (uint32_t)1);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_28 = L_27;
		MeshRenderer_tCD983A2F635E12BCB0BAA2E635D96A318757908B * L_29 = __this->get_targetRenderer_4();
		NullCheck(L_29);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_30;
		L_30 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_29, /*hidden argument*/NULL);
		NullCheck(L_28);
		ArrayElementTypeCheck (L_28, L_30);
		(L_28)->SetAt(static_cast<il2cpp_array_size_t>(0), (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *)L_30);
		V_3 = L_28;
		// if (meshBaker.UpdateGameObjects(gameObjects, false, false, false, false, true, false, false, false, false))
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_31 = __this->get_meshBaker_6();
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_32 = V_3;
		NullCheck(L_31);
		bool L_33;
		L_33 = VirtFuncInvoker10< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool, bool, bool, bool, bool, bool, bool, bool, bool >::Invoke(22 /* System.Boolean MB3_MeshBakerCommon::UpdateGameObjects(UnityEngine.GameObject[],System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean) */, L_31, L_32, (bool)0, (bool)0, (bool)0, (bool)0, (bool)1, (bool)0, (bool)0, (bool)0, (bool)0);
		if (!L_33)
		{
			goto IL_00c6;
		}
	}
	{
		// meshBaker.Apply();
		MB3_MeshBaker_t0D266D0CA6F7B75872666DC3A1422F880A370E1D * L_34 = __this->get_meshBaker_6();
		NullCheck(L_34);
		bool L_35;
		L_35 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_34, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_00c6:
	{
		// }
		return;
	}
}
// System.Void MB_SwitchBakedObjectsTexture::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MB_SwitchBakedObjectsTexture__ctor_m8B029C8A7B81C2BA5903248952A4B86589C2B969 (MB_SwitchBakedObjectsTexture_t6DE64E052055D8AA65E7A691312D6B2C24E496D2 * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
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
// System.Void MB_DynamicAddDeleteExample/<largeNumber>d__6::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3ClargeNumberU3Ed__6__ctor_m8AC2966092B5D4BF3EFF5FA4ED9AB676FC2ED063 (U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method)
{
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->set_U3CU3E1__state_0(L_0);
		return;
	}
}
// System.Void MB_DynamicAddDeleteExample/<largeNumber>d__6::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3ClargeNumberU3Ed__6_System_IDisposable_Dispose_m74E209AF99CF02B6DBAF898253141EE3733595A2 (U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean MB_DynamicAddDeleteExample/<largeNumber>d__6::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3ClargeNumberU3Ed__6_MoveNext_m91887D847A4CF8AC4DB86392E4CB8691DB028EA5 (U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * V_1 = NULL;
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * L_1 = __this->get_U3CU3E4__this_2();
		V_1 = L_1;
		int32_t L_2 = V_0;
		switch (L_2)
		{
			case 0:
			{
				goto IL_0022;
			}
			case 1:
			{
				goto IL_0042;
			}
			case 2:
			{
				goto IL_0084;
			}
		}
	}
	{
		return (bool)0;
	}

IL_0022:
	{
		__this->set_U3CU3E1__state_0((-1));
	}

IL_0029:
	{
		// yield return new WaitForSeconds(1.5f);
		WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * L_3 = (WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 *)il2cpp_codegen_object_new(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var);
		WaitForSeconds__ctor_mD298C4CB9532BBBDE172FC40F3397E30504038D4(L_3, (1.5f), /*hidden argument*/NULL);
		__this->set_U3CU3E2__current_1(L_3);
		__this->set_U3CU3E1__state_0(1);
		return (bool)1;
	}

IL_0042:
	{
		__this->set_U3CU3E1__state_0((-1));
		// if (mbd.AddDeleteGameObjects(null, objs, true))
		MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * L_4 = V_1;
		NullCheck(L_4);
		MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * L_5 = L_4->get_mbd_6();
		MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * L_6 = V_1;
		NullCheck(L_6);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_7 = L_6->get_objs_7();
		NullCheck(L_5);
		bool L_8;
		L_8 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_5, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, L_7, (bool)1);
		if (!L_8)
		{
			goto IL_006b;
		}
	}
	{
		// mbd.Apply();
		MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * L_9 = V_1;
		NullCheck(L_9);
		MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * L_10 = L_9->get_mbd_6();
		NullCheck(L_10);
		bool L_11;
		L_11 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_10, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
	}

IL_006b:
	{
		// yield return new WaitForSeconds(1.5f);
		WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 * L_12 = (WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013 *)il2cpp_codegen_object_new(WaitForSeconds_t8F9189BE6E467C98C99177038881F8982E0E4013_il2cpp_TypeInfo_var);
		WaitForSeconds__ctor_mD298C4CB9532BBBDE172FC40F3397E30504038D4(L_12, (1.5f), /*hidden argument*/NULL);
		__this->set_U3CU3E2__current_1(L_12);
		__this->set_U3CU3E1__state_0(2);
		return (bool)1;
	}

IL_0084:
	{
		__this->set_U3CU3E1__state_0((-1));
		// if (mbd.AddDeleteGameObjects(objs, null, true))
		MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * L_13 = V_1;
		NullCheck(L_13);
		MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * L_14 = L_13->get_mbd_6();
		MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * L_15 = V_1;
		NullCheck(L_15);
		GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642* L_16 = L_15->get_objs_7();
		NullCheck(L_14);
		bool L_17;
		L_17 = VirtFuncInvoker3< bool, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*, bool >::Invoke(15 /* System.Boolean MB3_MeshBakerCommon::AddDeleteGameObjects(UnityEngine.GameObject[],UnityEngine.GameObject[],System.Boolean) */, L_14, L_16, (GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)(GameObjectU5BU5D_tA88FC1A1FC9D4D73D0B3984D4B0ECE88F4C47642*)NULL, (bool)1);
		if (!L_17)
		{
			goto IL_0029;
		}
	}
	{
		// mbd.Apply();
		MB_DynamicAddDeleteExample_tDE93D4B27B8EEAC888072A037279FFF0ABFCD352 * L_18 = V_1;
		NullCheck(L_18);
		MB3_MultiMeshBaker_t3B9C6A2DB1E22820CFAF270263E433576E87BD3D * L_19 = L_18->get_mbd_6();
		NullCheck(L_19);
		bool L_20;
		L_20 = VirtFuncInvoker1< bool, GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 * >::Invoke(17 /* System.Boolean MB3_MeshBakerCommon::Apply(DigitalOpus.MB.Core.MB3_MeshCombiner/GenerateUV2Delegate) */, L_19, (GenerateUV2Delegate_tF0833904EAD8BBFBF6B5E391B228ECD1BFD8FDE9 *)NULL);
		// while (true)
		goto IL_0029;
	}
}
// System.Object MB_DynamicAddDeleteExample/<largeNumber>d__6::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3ClargeNumberU3Ed__6_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_m2384BA579B01C44E40CD97CA11A67638FE24BB7A (U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
// System.Void MB_DynamicAddDeleteExample/<largeNumber>d__6::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3ClargeNumberU3Ed__6_System_Collections_IEnumerator_Reset_m5890C15C5B5E0FAA08F7DA06DE339AC363A617B4 (U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * __this, const RuntimeMethod* method)
{
	{
		NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 * L_0 = (NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_tB9D89F0E9470A2C423D239D7C68EE0CFD77F9339_il2cpp_TypeInfo_var)));
		NotSupportedException__ctor_m3EA81A5B209A87C3ADA47443F2AFFF735E5256EE(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3ClargeNumberU3Ed__6_System_Collections_IEnumerator_Reset_m5890C15C5B5E0FAA08F7DA06DE339AC363A617B4_RuntimeMethod_var)));
	}
}
// System.Object MB_DynamicAddDeleteExample/<largeNumber>d__6::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * U3ClargeNumberU3Ed__6_System_Collections_IEnumerator_get_Current_m626A613B01AA66738695FF49FC7EB23DD5125357 (U3ClargeNumberU3Ed__6_t1FC121AE6420FAEF48F1DC4C1308AAB094C64CF3 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Multiply_m9EA3D18290418D7B410C7D11C4788C13BFD2C30A_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___a0;
		float L_1 = L_0.get_x_2();
		float L_2 = ___d1;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_3 = ___a0;
		float L_4 = L_3.get_y_3();
		float L_5 = ___d1;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6 = ___a0;
		float L_7 = L_6.get_z_4();
		float L_8 = ___d1;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_9), ((float)il2cpp_codegen_multiply((float)L_1, (float)L_2)), ((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)), ((float)il2cpp_codegen_multiply((float)L_7, (float)L_8)), /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0021;
	}

IL_0021:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_10 = V_0;
		return L_10;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_op_Addition_mEE4F672B923CCB184C39AABCA33443DB218E50E0_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___a0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___b1, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___a0;
		float L_1 = L_0.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2 = ___b1;
		float L_3 = L_2.get_x_2();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_4 = ___a0;
		float L_5 = L_4.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_6 = ___b1;
		float L_7 = L_6.get_y_3();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_8 = ___a0;
		float L_9 = L_8.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_10 = ___b1;
		float L_11 = L_10.get_z_4();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_12;
		memset((&L_12), 0, sizeof(L_12));
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((&L_12), ((float)il2cpp_codegen_add((float)L_1, (float)L_3)), ((float)il2cpp_codegen_add((float)L_5, (float)L_7)), ((float)il2cpp_codegen_add((float)L_9, (float)L_11)), /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0030;
	}

IL_0030:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_13 = V_0;
		return L_13;
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_m9C4EBBD2108B51885E750F927D7936290C8E20EE_gshared_inline (Enumerator_tB6009981BD4E3881E3EC83627255A24198F902D6 * __this, const RuntimeMethod* method)
{
	{
		RuntimeObject * L_0 = (RuntimeObject *)__this->get_current_3();
		return (RuntimeObject *)L_0;
	}
}
