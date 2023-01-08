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
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
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

// System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>
struct List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02;
// UnityEngine.AnimationClip[]
struct AnimationClipU5BU5D_t93D1A9ADEC832A4EABC0353D9E4E435B22B28489;
// UnityEngine.AnimationEvent[]
struct AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA;
// UnityEngine.AnimatorClipInfo[]
struct AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2;
// UnityEngine.AnimatorControllerParameter[]
struct AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Delegate[]
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// UnityEngine.ScriptableObject[]
struct ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// UnityEngine.StateMachineBehaviour[]
struct StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C;
// System.Type[]
struct TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755;
// UnityEngine.Animation
struct Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8;
// UnityEngine.AnimationClip
struct AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178;
// UnityEngine.AnimationCurve
struct AnimationCurve_t2D452A14820CEDB83BFF2C911682A4E59001AD03;
// UnityEngine.AnimationEvent
struct AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF;
// UnityEngine.AnimationState
struct AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD;
// UnityEngine.Animator
struct Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149;
// UnityEngine.AnimatorControllerParameter
struct AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE;
// UnityEngine.AnimatorOverrideController
struct AnimatorOverrideController_t4630AA9761965F735AEB26B9A92D210D6338B2DA;
// System.ArgumentNullException
struct ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB;
// System.AsyncCallback
struct AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA;
// System.Attribute
struct Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71;
// UnityEngine.Avatar
struct Avatar_t1A1B32874530475986346E2EED62F9DDEE8C45C6;
// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9;
// System.Reflection.Binder
struct Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t17DD30660E330C49381DAA99F934BE75CB11F288;
// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319;
// System.IAsyncResult
struct IAsyncResult_tC9F97BF36FCF122D29D3101D80642278297BF370;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.Collections.IEnumerator
struct IEnumerator_t5956F3AFB7ECF1117E3BC5890E7FC7B7F7A04105;
// System.IndexOutOfRangeException
struct IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD;
// System.InvalidCastException
struct InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463;
// System.InvalidOperationException
struct InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB;
// System.Reflection.MemberFilter
struct MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.Motion
struct Motion_t3EAEF01D52B05F10A21CC9B54A35C8F3F6BA3A67;
// UnityEngine.Animations.NotKeyableAttribute
struct NotKeyableAttribute_tE0C94B5FF990C6B4BB118486BCA35CCDA91AA905;
// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A;
// UnityEngine.RuntimeAnimatorController
struct RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// UnityEngine.ScriptableObject
struct ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A;
// UnityEngine.StateMachineBehaviour
struct StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F;
// System.String
struct String_t;
// UnityEngine.TrackedReference
struct TrackedReference_t17AA313389C655DCF279F96A2D85332B29596514;
// UnityEngine.Transform
struct Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1;
// System.Type
struct Type_t;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;
// UnityEngine.Animation/Enumerator
struct Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5;
// UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback
struct OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C;

IL2CPP_EXTERN_C RuntimeClass* AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* HumanBodyBones_tFB48F983A3FDC35E822852C22003086FF9BB4087_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Type_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral00F97321929E0D7989E72D633D157BD761DD173A;
IL2CPP_EXTERN_C String_t* _stringLiteral05ACCFE2F05290DF031B27B4C6B2AD1DC43CCDC6;
IL2CPP_EXTERN_C String_t* _stringLiteral4A3C80CF84F07DA0E7531332FF2B387B07C77760;
IL2CPP_EXTERN_C String_t* _stringLiteral4DEE968069F34C26613ADFCD69C41EFC29314286;
IL2CPP_EXTERN_C String_t* _stringLiteral860B9EA7CDAB02A8A4B38336805EAE2FBA31F09C;
IL2CPP_EXTERN_C String_t* _stringLiteral8DC2252638D84FAF2C30B95D54EC83F52FA6C630;
IL2CPP_EXTERN_C String_t* _stringLiteral98C704D69BD1A288ED31DEE4ED4E50097A2D7018;
IL2CPP_EXTERN_C String_t* _stringLiteralA3C8FF345EC45846B2EE6801F84DD49340F0A9E1;
IL2CPP_EXTERN_C String_t* _stringLiteralBF563F6FCC25CE41FFE0BF7590AF9F4475916665;
IL2CPP_EXTERN_C String_t* _stringLiteralD1DCB778EB9DF1B12AD26B829002FF8E78A1AFCE;
IL2CPP_EXTERN_C String_t* _stringLiteralD2435BFAEB0372E848D9BE812E3B06AB862CC3D1;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C String_t* _stringLiteralE066D08B565F88D413FDACA14C42BFF008FF4EB9;
IL2CPP_EXTERN_C String_t* _stringLiteralE7306902767BBF9821FC01DF5423B33158A3F6ED;
IL2CPP_EXTERN_C String_t* _stringLiteralF5510C45DDAD777CCB4893578D995C9739F990F2;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationClip_AddEvent_mF9B1C0BB15F539AED479F2DBD9FCAAF70CDC1C16_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationLayerMixerPlayable__ctor_m42F8E5BB37A175AF298324D3072932ED9946427B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationMixerPlayable__ctor_mA03CF37709B7854227E25F91BE4F7559981058B0_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationMotionXToDeltaPlayable__ctor_m11668860161B62484EA095BD6360AFD26A86DE93_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationOffsetPlayable__ctor_m9527E52AEA325EAE188AB9843497F2AB33CB742E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationPosePlayable__ctor_m318607F120F21EDE3D7C1ED07C8B2ED13A23BF57_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationRemoveScalePlayable__ctor_m08810C8ECE9A3A100087DD84B13204EC3AF73A8F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimationScriptPlayable__ctor_m0B751F7A7D28F59AADACE7C13704D653E0879C56_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* AnimatorControllerPlayable_SetHandle_m19111E2A65EDAB3382AC9BE815503459A495FF38_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Animator_GetBoneTransform_mE35B1880DB371D4BB7254ECB45BF25ABEE18DD70_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Animator_GetCurrentAnimatorClipInfo_mA1061569ED175C2B54A3273EDB889E9D48DE5A2C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Animator_GetNextAnimatorClipInfo_mB5F0367EAC2C788CD5DB486C511B4F783339C066_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Animator_GetParameter_m8E2B8351264BE835BDAE9B6CCB6C99FCB197760D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_m866298E26CA43C28F7948D46E99D65FAA09722C5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_m30062CF184CC05FFAA026881BEFE337C13B7E70E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_m19943D18384297A3129F799C12E91B0D8162A02F_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_m1B2FA89CE8F4A1EBD1AE3FF4E7154CFE120EDF85_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_m171336A5BD550FD80BFD4B2BDF5903DF72C0E1C2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_mEF5219AC94275FE2811CEDC16FE0B850DBA7E9BE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_m529F82044C8D4F4B60EA35E96D1C0592644AD76B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_mFB1F4B388070EC30EC8DA09EB2869306EE60F2B8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeType* StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F_0_0_0_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A;;
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com;
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com;;
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke;
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke;;

struct AnimationClipU5BU5D_t93D1A9ADEC832A4EABC0353D9E4E435B22B28489;
struct AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA;
struct AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2;
struct AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE;
struct DelegateU5BU5D_t677D8FE08A5F99E8EE49150B73966CD6E9BF7DB8;
struct ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208;
struct StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t3C417EDD55E853BAA084114A5B12880739B4473C 
{
public:

public:
};


// System.Object


// System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>
struct List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02, ____items_1)); }
	inline AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* get__items_1() const { return ____items_1; }
	inline AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02_StaticFields, ____emptyArray_5)); }
	inline AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* get__emptyArray_5() const { return ____emptyArray_5; }
	inline AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
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


// UnityEngine.HumanTrait
struct HumanTrait_t9B5352F78F2BDD91359BF3F8F66BBF8C09C90519  : public RuntimeObject
{
public:

public:
};


// System.Reflection.MemberInfo
struct MemberInfo_t  : public RuntimeObject
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

// UnityEngine.Animation/Enumerator
struct Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5  : public RuntimeObject
{
public:
	// UnityEngine.Animation UnityEngine.Animation/Enumerator::m_Outer
	Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * ___m_Outer_0;
	// System.Int32 UnityEngine.Animation/Enumerator::m_CurrentIndex
	int32_t ___m_CurrentIndex_1;

public:
	inline static int32_t get_offset_of_m_Outer_0() { return static_cast<int32_t>(offsetof(Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5, ___m_Outer_0)); }
	inline Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * get_m_Outer_0() const { return ___m_Outer_0; }
	inline Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 ** get_address_of_m_Outer_0() { return &___m_Outer_0; }
	inline void set_m_Outer_0(Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * value)
	{
		___m_Outer_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Outer_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_CurrentIndex_1() { return static_cast<int32_t>(offsetof(Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5, ___m_CurrentIndex_1)); }
	inline int32_t get_m_CurrentIndex_1() const { return ___m_CurrentIndex_1; }
	inline int32_t* get_address_of_m_CurrentIndex_1() { return &___m_CurrentIndex_1; }
	inline void set_m_CurrentIndex_1(int32_t value)
	{
		___m_CurrentIndex_1 = value;
	}
};


// UnityEngine.AnimatorClipInfo
struct AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 
{
public:
	// System.Int32 UnityEngine.AnimatorClipInfo::m_ClipInstanceID
	int32_t ___m_ClipInstanceID_0;
	// System.Single UnityEngine.AnimatorClipInfo::m_Weight
	float ___m_Weight_1;

public:
	inline static int32_t get_offset_of_m_ClipInstanceID_0() { return static_cast<int32_t>(offsetof(AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610, ___m_ClipInstanceID_0)); }
	inline int32_t get_m_ClipInstanceID_0() const { return ___m_ClipInstanceID_0; }
	inline int32_t* get_address_of_m_ClipInstanceID_0() { return &___m_ClipInstanceID_0; }
	inline void set_m_ClipInstanceID_0(int32_t value)
	{
		___m_ClipInstanceID_0 = value;
	}

	inline static int32_t get_offset_of_m_Weight_1() { return static_cast<int32_t>(offsetof(AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610, ___m_Weight_1)); }
	inline float get_m_Weight_1() const { return ___m_Weight_1; }
	inline float* get_address_of_m_Weight_1() { return &___m_Weight_1; }
	inline void set_m_Weight_1(float value)
	{
		___m_Weight_1 = value;
	}
};


// UnityEngine.AnimatorStateInfo
struct AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA 
{
public:
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Name
	int32_t ___m_Name_0;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Path
	int32_t ___m_Path_1;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_FullPath
	int32_t ___m_FullPath_2;
	// System.Single UnityEngine.AnimatorStateInfo::m_NormalizedTime
	float ___m_NormalizedTime_3;
	// System.Single UnityEngine.AnimatorStateInfo::m_Length
	float ___m_Length_4;
	// System.Single UnityEngine.AnimatorStateInfo::m_Speed
	float ___m_Speed_5;
	// System.Single UnityEngine.AnimatorStateInfo::m_SpeedMultiplier
	float ___m_SpeedMultiplier_6;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Tag
	int32_t ___m_Tag_7;
	// System.Int32 UnityEngine.AnimatorStateInfo::m_Loop
	int32_t ___m_Loop_8;

public:
	inline static int32_t get_offset_of_m_Name_0() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_Name_0)); }
	inline int32_t get_m_Name_0() const { return ___m_Name_0; }
	inline int32_t* get_address_of_m_Name_0() { return &___m_Name_0; }
	inline void set_m_Name_0(int32_t value)
	{
		___m_Name_0 = value;
	}

	inline static int32_t get_offset_of_m_Path_1() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_Path_1)); }
	inline int32_t get_m_Path_1() const { return ___m_Path_1; }
	inline int32_t* get_address_of_m_Path_1() { return &___m_Path_1; }
	inline void set_m_Path_1(int32_t value)
	{
		___m_Path_1 = value;
	}

	inline static int32_t get_offset_of_m_FullPath_2() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_FullPath_2)); }
	inline int32_t get_m_FullPath_2() const { return ___m_FullPath_2; }
	inline int32_t* get_address_of_m_FullPath_2() { return &___m_FullPath_2; }
	inline void set_m_FullPath_2(int32_t value)
	{
		___m_FullPath_2 = value;
	}

	inline static int32_t get_offset_of_m_NormalizedTime_3() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_NormalizedTime_3)); }
	inline float get_m_NormalizedTime_3() const { return ___m_NormalizedTime_3; }
	inline float* get_address_of_m_NormalizedTime_3() { return &___m_NormalizedTime_3; }
	inline void set_m_NormalizedTime_3(float value)
	{
		___m_NormalizedTime_3 = value;
	}

	inline static int32_t get_offset_of_m_Length_4() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_Length_4)); }
	inline float get_m_Length_4() const { return ___m_Length_4; }
	inline float* get_address_of_m_Length_4() { return &___m_Length_4; }
	inline void set_m_Length_4(float value)
	{
		___m_Length_4 = value;
	}

	inline static int32_t get_offset_of_m_Speed_5() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_Speed_5)); }
	inline float get_m_Speed_5() const { return ___m_Speed_5; }
	inline float* get_address_of_m_Speed_5() { return &___m_Speed_5; }
	inline void set_m_Speed_5(float value)
	{
		___m_Speed_5 = value;
	}

	inline static int32_t get_offset_of_m_SpeedMultiplier_6() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_SpeedMultiplier_6)); }
	inline float get_m_SpeedMultiplier_6() const { return ___m_SpeedMultiplier_6; }
	inline float* get_address_of_m_SpeedMultiplier_6() { return &___m_SpeedMultiplier_6; }
	inline void set_m_SpeedMultiplier_6(float value)
	{
		___m_SpeedMultiplier_6 = value;
	}

	inline static int32_t get_offset_of_m_Tag_7() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_Tag_7)); }
	inline int32_t get_m_Tag_7() const { return ___m_Tag_7; }
	inline int32_t* get_address_of_m_Tag_7() { return &___m_Tag_7; }
	inline void set_m_Tag_7(int32_t value)
	{
		___m_Tag_7 = value;
	}

	inline static int32_t get_offset_of_m_Loop_8() { return static_cast<int32_t>(offsetof(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA, ___m_Loop_8)); }
	inline int32_t get_m_Loop_8() const { return ___m_Loop_8; }
	inline int32_t* get_address_of_m_Loop_8() { return &___m_Loop_8; }
	inline void set_m_Loop_8(int32_t value)
	{
		___m_Loop_8 = value;
	}
};


// UnityEngine.AnimatorTransitionInfo
struct AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0 
{
public:
	// System.Int32 UnityEngine.AnimatorTransitionInfo::m_FullPath
	int32_t ___m_FullPath_0;
	// System.Int32 UnityEngine.AnimatorTransitionInfo::m_UserName
	int32_t ___m_UserName_1;
	// System.Int32 UnityEngine.AnimatorTransitionInfo::m_Name
	int32_t ___m_Name_2;
	// System.Boolean UnityEngine.AnimatorTransitionInfo::m_HasFixedDuration
	bool ___m_HasFixedDuration_3;
	// System.Single UnityEngine.AnimatorTransitionInfo::m_Duration
	float ___m_Duration_4;
	// System.Single UnityEngine.AnimatorTransitionInfo::m_NormalizedTime
	float ___m_NormalizedTime_5;
	// System.Boolean UnityEngine.AnimatorTransitionInfo::m_AnyState
	bool ___m_AnyState_6;
	// System.Int32 UnityEngine.AnimatorTransitionInfo::m_TransitionType
	int32_t ___m_TransitionType_7;

public:
	inline static int32_t get_offset_of_m_FullPath_0() { return static_cast<int32_t>(offsetof(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0, ___m_FullPath_0)); }
	inline int32_t get_m_FullPath_0() const { return ___m_FullPath_0; }
	inline int32_t* get_address_of_m_FullPath_0() { return &___m_FullPath_0; }
	inline void set_m_FullPath_0(int32_t value)
	{
		___m_FullPath_0 = value;
	}

	inline static int32_t get_offset_of_m_UserName_1() { return static_cast<int32_t>(offsetof(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0, ___m_UserName_1)); }
	inline int32_t get_m_UserName_1() const { return ___m_UserName_1; }
	inline int32_t* get_address_of_m_UserName_1() { return &___m_UserName_1; }
	inline void set_m_UserName_1(int32_t value)
	{
		___m_UserName_1 = value;
	}

	inline static int32_t get_offset_of_m_Name_2() { return static_cast<int32_t>(offsetof(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0, ___m_Name_2)); }
	inline int32_t get_m_Name_2() const { return ___m_Name_2; }
	inline int32_t* get_address_of_m_Name_2() { return &___m_Name_2; }
	inline void set_m_Name_2(int32_t value)
	{
		___m_Name_2 = value;
	}

	inline static int32_t get_offset_of_m_HasFixedDuration_3() { return static_cast<int32_t>(offsetof(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0, ___m_HasFixedDuration_3)); }
	inline bool get_m_HasFixedDuration_3() const { return ___m_HasFixedDuration_3; }
	inline bool* get_address_of_m_HasFixedDuration_3() { return &___m_HasFixedDuration_3; }
	inline void set_m_HasFixedDuration_3(bool value)
	{
		___m_HasFixedDuration_3 = value;
	}

	inline static int32_t get_offset_of_m_Duration_4() { return static_cast<int32_t>(offsetof(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0, ___m_Duration_4)); }
	inline float get_m_Duration_4() const { return ___m_Duration_4; }
	inline float* get_address_of_m_Duration_4() { return &___m_Duration_4; }
	inline void set_m_Duration_4(float value)
	{
		___m_Duration_4 = value;
	}

	inline static int32_t get_offset_of_m_NormalizedTime_5() { return static_cast<int32_t>(offsetof(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0, ___m_NormalizedTime_5)); }
	inline float get_m_NormalizedTime_5() const { return ___m_NormalizedTime_5; }
	inline float* get_address_of_m_NormalizedTime_5() { return &___m_NormalizedTime_5; }
	inline void set_m_NormalizedTime_5(float value)
	{
		___m_NormalizedTime_5 = value;
	}

	inline static int32_t get_offset_of_m_AnyState_6() { return static_cast<int32_t>(offsetof(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0, ___m_AnyState_6)); }
	inline bool get_m_AnyState_6() const { return ___m_AnyState_6; }
	inline bool* get_address_of_m_AnyState_6() { return &___m_AnyState_6; }
	inline void set_m_AnyState_6(bool value)
	{
		___m_AnyState_6 = value;
	}

	inline static int32_t get_offset_of_m_TransitionType_7() { return static_cast<int32_t>(offsetof(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0, ___m_TransitionType_7)); }
	inline int32_t get_m_TransitionType_7() const { return ___m_TransitionType_7; }
	inline int32_t* get_address_of_m_TransitionType_7() { return &___m_TransitionType_7; }
	inline void set_m_TransitionType_7(int32_t value)
	{
		___m_TransitionType_7 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.AnimatorTransitionInfo
struct AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshaled_pinvoke
{
	int32_t ___m_FullPath_0;
	int32_t ___m_UserName_1;
	int32_t ___m_Name_2;
	int32_t ___m_HasFixedDuration_3;
	float ___m_Duration_4;
	float ___m_NormalizedTime_5;
	int32_t ___m_AnyState_6;
	int32_t ___m_TransitionType_7;
};
// Native definition for COM marshalling of UnityEngine.AnimatorTransitionInfo
struct AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshaled_com
{
	int32_t ___m_FullPath_0;
	int32_t ___m_UserName_1;
	int32_t ___m_Name_2;
	int32_t ___m_HasFixedDuration_3;
	float ___m_Duration_4;
	float ___m_NormalizedTime_5;
	int32_t ___m_AnyState_6;
	int32_t ___m_TransitionType_7;
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


// UnityEngine.Animations.NotKeyableAttribute
struct NotKeyableAttribute_tE0C94B5FF990C6B4BB118486BCA35CCDA91AA905  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
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


// UnityEngine.SharedBetweenAnimatorsAttribute
struct SharedBetweenAnimatorsAttribute_t1F94A6AF21AC0F90F38FFEDE964054F34A117279  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
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


// UnityEngine.AnimationCurve
struct AnimationCurve_t2D452A14820CEDB83BFF2C911682A4E59001AD03  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.AnimationCurve::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(AnimationCurve_t2D452A14820CEDB83BFF2C911682A4E59001AD03, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_t2D452A14820CEDB83BFF2C911682A4E59001AD03_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.AnimationCurve
struct AnimationCurve_t2D452A14820CEDB83BFF2C911682A4E59001AD03_marshaled_com
{
	intptr_t ___m_Ptr_0;
};

// UnityEngine.AnimationEventSource
struct AnimationEventSource_t1B170B0043F7F21E0AA3577B3220584CA3797630 
{
public:
	// System.Int32 UnityEngine.AnimationEventSource::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AnimationEventSource_t1B170B0043F7F21E0AA3577B3220584CA3797630, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Animations.AnimationHumanStream
struct AnimationHumanStream_t98A25119C1A24795BA152F54CF9F0673EEDF1C3F 
{
public:
	// System.IntPtr UnityEngine.Animations.AnimationHumanStream::stream
	intptr_t ___stream_0;

public:
	inline static int32_t get_offset_of_stream_0() { return static_cast<int32_t>(offsetof(AnimationHumanStream_t98A25119C1A24795BA152F54CF9F0673EEDF1C3F, ___stream_0)); }
	inline intptr_t get_stream_0() const { return ___stream_0; }
	inline intptr_t* get_address_of_stream_0() { return &___stream_0; }
	inline void set_stream_0(intptr_t value)
	{
		___stream_0 = value;
	}
};


// UnityEngine.AnimationPlayMode
struct AnimationPlayMode_tAFB57D4FF6931CE028FD030152958BDD0958EE9D 
{
public:
	// System.Int32 UnityEngine.AnimationPlayMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AnimationPlayMode_tAFB57D4FF6931CE028FD030152958BDD0958EE9D, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Animations.AnimationStream
struct AnimationStream_t32D9239CBAA66CE867094B820035B2121D7E2714 
{
public:
	// System.UInt32 UnityEngine.Animations.AnimationStream::m_AnimatorBindingsVersion
	uint32_t ___m_AnimatorBindingsVersion_0;
	// System.IntPtr UnityEngine.Animations.AnimationStream::constant
	intptr_t ___constant_1;
	// System.IntPtr UnityEngine.Animations.AnimationStream::input
	intptr_t ___input_2;
	// System.IntPtr UnityEngine.Animations.AnimationStream::output
	intptr_t ___output_3;
	// System.IntPtr UnityEngine.Animations.AnimationStream::workspace
	intptr_t ___workspace_4;
	// System.IntPtr UnityEngine.Animations.AnimationStream::inputStreamAccessor
	intptr_t ___inputStreamAccessor_5;
	// System.IntPtr UnityEngine.Animations.AnimationStream::animationHandleBinder
	intptr_t ___animationHandleBinder_6;

public:
	inline static int32_t get_offset_of_m_AnimatorBindingsVersion_0() { return static_cast<int32_t>(offsetof(AnimationStream_t32D9239CBAA66CE867094B820035B2121D7E2714, ___m_AnimatorBindingsVersion_0)); }
	inline uint32_t get_m_AnimatorBindingsVersion_0() const { return ___m_AnimatorBindingsVersion_0; }
	inline uint32_t* get_address_of_m_AnimatorBindingsVersion_0() { return &___m_AnimatorBindingsVersion_0; }
	inline void set_m_AnimatorBindingsVersion_0(uint32_t value)
	{
		___m_AnimatorBindingsVersion_0 = value;
	}

	inline static int32_t get_offset_of_constant_1() { return static_cast<int32_t>(offsetof(AnimationStream_t32D9239CBAA66CE867094B820035B2121D7E2714, ___constant_1)); }
	inline intptr_t get_constant_1() const { return ___constant_1; }
	inline intptr_t* get_address_of_constant_1() { return &___constant_1; }
	inline void set_constant_1(intptr_t value)
	{
		___constant_1 = value;
	}

	inline static int32_t get_offset_of_input_2() { return static_cast<int32_t>(offsetof(AnimationStream_t32D9239CBAA66CE867094B820035B2121D7E2714, ___input_2)); }
	inline intptr_t get_input_2() const { return ___input_2; }
	inline intptr_t* get_address_of_input_2() { return &___input_2; }
	inline void set_input_2(intptr_t value)
	{
		___input_2 = value;
	}

	inline static int32_t get_offset_of_output_3() { return static_cast<int32_t>(offsetof(AnimationStream_t32D9239CBAA66CE867094B820035B2121D7E2714, ___output_3)); }
	inline intptr_t get_output_3() const { return ___output_3; }
	inline intptr_t* get_address_of_output_3() { return &___output_3; }
	inline void set_output_3(intptr_t value)
	{
		___output_3 = value;
	}

	inline static int32_t get_offset_of_workspace_4() { return static_cast<int32_t>(offsetof(AnimationStream_t32D9239CBAA66CE867094B820035B2121D7E2714, ___workspace_4)); }
	inline intptr_t get_workspace_4() const { return ___workspace_4; }
	inline intptr_t* get_address_of_workspace_4() { return &___workspace_4; }
	inline void set_workspace_4(intptr_t value)
	{
		___workspace_4 = value;
	}

	inline static int32_t get_offset_of_inputStreamAccessor_5() { return static_cast<int32_t>(offsetof(AnimationStream_t32D9239CBAA66CE867094B820035B2121D7E2714, ___inputStreamAccessor_5)); }
	inline intptr_t get_inputStreamAccessor_5() const { return ___inputStreamAccessor_5; }
	inline intptr_t* get_address_of_inputStreamAccessor_5() { return &___inputStreamAccessor_5; }
	inline void set_inputStreamAccessor_5(intptr_t value)
	{
		___inputStreamAccessor_5 = value;
	}

	inline static int32_t get_offset_of_animationHandleBinder_6() { return static_cast<int32_t>(offsetof(AnimationStream_t32D9239CBAA66CE867094B820035B2121D7E2714, ___animationHandleBinder_6)); }
	inline intptr_t get_animationHandleBinder_6() const { return ___animationHandleBinder_6; }
	inline intptr_t* get_address_of_animationHandleBinder_6() { return &___animationHandleBinder_6; }
	inline void set_animationHandleBinder_6(intptr_t value)
	{
		___animationHandleBinder_6 = value;
	}
};


// UnityEngine.AnimatorControllerParameterType
struct AnimatorControllerParameterType_tAD9F29F9714D48F62AC8F803EA4340971F8C69AE 
{
public:
	// System.Int32 UnityEngine.AnimatorControllerParameterType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AnimatorControllerParameterType_tAD9F29F9714D48F62AC8F803EA4340971F8C69AE, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AnimatorCullingMode
struct AnimatorCullingMode_t2458DE94DB380FE4DF8D3E21580B808F763B9FB3 
{
public:
	// System.Int32 UnityEngine.AnimatorCullingMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AnimatorCullingMode_t2458DE94DB380FE4DF8D3E21580B808F763B9FB3, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AnimatorRecorderMode
struct AnimatorRecorderMode_tA0FAEB151768F764C85D8E225859990AAE276E51 
{
public:
	// System.Int32 UnityEngine.AnimatorRecorderMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AnimatorRecorderMode_tA0FAEB151768F764C85D8E225859990AAE276E51, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AnimatorUpdateMode
struct AnimatorUpdateMode_t5E08EEA8E26DAB1765A82EAD782A0E047920B439 
{
public:
	// System.Int32 UnityEngine.AnimatorUpdateMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AnimatorUpdateMode_t5E08EEA8E26DAB1765A82EAD782A0E047920B439, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AvatarIKGoal
struct AvatarIKGoal_t3A33B8127C253176E5C703917C8E7363E9D5627F 
{
public:
	// System.Int32 UnityEngine.AvatarIKGoal::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AvatarIKGoal_t3A33B8127C253176E5C703917C8E7363E9D5627F, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AvatarIKHint
struct AvatarIKHint_tADA6146AAC012ADEC5C4762949F325106DF8C982 
{
public:
	// System.Int32 UnityEngine.AvatarIKHint::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AvatarIKHint_tADA6146AAC012ADEC5C4762949F325106DF8C982, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.AvatarTarget
struct AvatarTarget_t916FD1B565A68BF9C0FD5234FE988F3CA70D40D0 
{
public:
	// System.Int32 UnityEngine.AvatarTarget::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(AvatarTarget_t916FD1B565A68BF9C0FD5234FE988F3CA70D40D0, ___value___2)); }
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

// UnityEngine.HumanBodyBones
struct HumanBodyBones_tFB48F983A3FDC35E822852C22003086FF9BB4087 
{
public:
	// System.Int32 UnityEngine.HumanBodyBones::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(HumanBodyBones_tFB48F983A3FDC35E822852C22003086FF9BB4087, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.HumanLimit
struct HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8 
{
public:
	// UnityEngine.Vector3 UnityEngine.HumanLimit::m_Min
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___m_Min_0;
	// UnityEngine.Vector3 UnityEngine.HumanLimit::m_Max
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___m_Max_1;
	// UnityEngine.Vector3 UnityEngine.HumanLimit::m_Center
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___m_Center_2;
	// System.Single UnityEngine.HumanLimit::m_AxisLength
	float ___m_AxisLength_3;
	// System.Int32 UnityEngine.HumanLimit::m_UseDefaultValues
	int32_t ___m_UseDefaultValues_4;

public:
	inline static int32_t get_offset_of_m_Min_0() { return static_cast<int32_t>(offsetof(HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8, ___m_Min_0)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_m_Min_0() const { return ___m_Min_0; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_m_Min_0() { return &___m_Min_0; }
	inline void set_m_Min_0(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___m_Min_0 = value;
	}

	inline static int32_t get_offset_of_m_Max_1() { return static_cast<int32_t>(offsetof(HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8, ___m_Max_1)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_m_Max_1() const { return ___m_Max_1; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_m_Max_1() { return &___m_Max_1; }
	inline void set_m_Max_1(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___m_Max_1 = value;
	}

	inline static int32_t get_offset_of_m_Center_2() { return static_cast<int32_t>(offsetof(HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8, ___m_Center_2)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_m_Center_2() const { return ___m_Center_2; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_m_Center_2() { return &___m_Center_2; }
	inline void set_m_Center_2(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___m_Center_2 = value;
	}

	inline static int32_t get_offset_of_m_AxisLength_3() { return static_cast<int32_t>(offsetof(HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8, ___m_AxisLength_3)); }
	inline float get_m_AxisLength_3() const { return ___m_AxisLength_3; }
	inline float* get_address_of_m_AxisLength_3() { return &___m_AxisLength_3; }
	inline void set_m_AxisLength_3(float value)
	{
		___m_AxisLength_3 = value;
	}

	inline static int32_t get_offset_of_m_UseDefaultValues_4() { return static_cast<int32_t>(offsetof(HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8, ___m_UseDefaultValues_4)); }
	inline int32_t get_m_UseDefaultValues_4() const { return ___m_UseDefaultValues_4; }
	inline int32_t* get_address_of_m_UseDefaultValues_4() { return &___m_UseDefaultValues_4; }
	inline void set_m_UseDefaultValues_4(int32_t value)
	{
		___m_UseDefaultValues_4 = value;
	}
};


// UnityEngine.MatchTargetWeightMask
struct MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 
{
public:
	// UnityEngine.Vector3 UnityEngine.MatchTargetWeightMask::m_PositionXYZWeight
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___m_PositionXYZWeight_0;
	// System.Single UnityEngine.MatchTargetWeightMask::m_RotationWeight
	float ___m_RotationWeight_1;

public:
	inline static int32_t get_offset_of_m_PositionXYZWeight_0() { return static_cast<int32_t>(offsetof(MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6, ___m_PositionXYZWeight_0)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_m_PositionXYZWeight_0() const { return ___m_PositionXYZWeight_0; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_m_PositionXYZWeight_0() { return &___m_PositionXYZWeight_0; }
	inline void set_m_PositionXYZWeight_0(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___m_PositionXYZWeight_0 = value;
	}

	inline static int32_t get_offset_of_m_RotationWeight_1() { return static_cast<int32_t>(offsetof(MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6, ___m_RotationWeight_1)); }
	inline float get_m_RotationWeight_1() const { return ___m_RotationWeight_1; }
	inline float* get_address_of_m_RotationWeight_1() { return &___m_RotationWeight_1; }
	inline void set_m_RotationWeight_1(float value)
	{
		___m_RotationWeight_1 = value;
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

// UnityEngine.PlayMode
struct PlayMode_tB7ABFA16A3D0582F8EF40752140263F632FBBD68 
{
public:
	// System.Int32 UnityEngine.PlayMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(PlayMode_tB7ABFA16A3D0582F8EF40752140263F632FBBD68, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
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


// UnityEngine.Playables.PlayableHandle
struct PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A 
{
public:
	// System.IntPtr UnityEngine.Playables.PlayableHandle::m_Handle
	intptr_t ___m_Handle_0;
	// System.UInt32 UnityEngine.Playables.PlayableHandle::m_Version
	uint32_t ___m_Version_1;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A, ___m_Handle_0)); }
	inline intptr_t get_m_Handle_0() const { return ___m_Handle_0; }
	inline intptr_t* get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(intptr_t value)
	{
		___m_Handle_0 = value;
	}

	inline static int32_t get_offset_of_m_Version_1() { return static_cast<int32_t>(offsetof(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A, ___m_Version_1)); }
	inline uint32_t get_m_Version_1() const { return ___m_Version_1; }
	inline uint32_t* get_address_of_m_Version_1() { return &___m_Version_1; }
	inline void set_m_Version_1(uint32_t value)
	{
		___m_Version_1 = value;
	}
};

struct PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_StaticFields
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Playables.PlayableHandle::m_Null
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Null_2;

public:
	inline static int32_t get_offset_of_m_Null_2() { return static_cast<int32_t>(offsetof(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_StaticFields, ___m_Null_2)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Null_2() const { return ___m_Null_2; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Null_2() { return &___m_Null_2; }
	inline void set_m_Null_2(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Null_2 = value;
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


// UnityEngine.QueueMode
struct QueueMode_t635F9346A04A9D17B8EF300B4F913578C3DEB3E9 
{
public:
	// System.Int32 UnityEngine.QueueMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(QueueMode_t635F9346A04A9D17B8EF300B4F913578C3DEB3E9, ___value___2)); }
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


// UnityEngine.SkeletonBone
struct SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E 
{
public:
	// System.String UnityEngine.SkeletonBone::name
	String_t* ___name_0;
	// System.String UnityEngine.SkeletonBone::parentName
	String_t* ___parentName_1;
	// UnityEngine.Vector3 UnityEngine.SkeletonBone::position
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_2;
	// UnityEngine.Quaternion UnityEngine.SkeletonBone::rotation
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___rotation_3;
	// UnityEngine.Vector3 UnityEngine.SkeletonBone::scale
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___scale_4;

public:
	inline static int32_t get_offset_of_name_0() { return static_cast<int32_t>(offsetof(SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E, ___name_0)); }
	inline String_t* get_name_0() const { return ___name_0; }
	inline String_t** get_address_of_name_0() { return &___name_0; }
	inline void set_name_0(String_t* value)
	{
		___name_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___name_0), (void*)value);
	}

	inline static int32_t get_offset_of_parentName_1() { return static_cast<int32_t>(offsetof(SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E, ___parentName_1)); }
	inline String_t* get_parentName_1() const { return ___parentName_1; }
	inline String_t** get_address_of_parentName_1() { return &___parentName_1; }
	inline void set_parentName_1(String_t* value)
	{
		___parentName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___parentName_1), (void*)value);
	}

	inline static int32_t get_offset_of_position_2() { return static_cast<int32_t>(offsetof(SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E, ___position_2)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_position_2() const { return ___position_2; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_position_2() { return &___position_2; }
	inline void set_position_2(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___position_2 = value;
	}

	inline static int32_t get_offset_of_rotation_3() { return static_cast<int32_t>(offsetof(SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E, ___rotation_3)); }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  get_rotation_3() const { return ___rotation_3; }
	inline Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * get_address_of_rotation_3() { return &___rotation_3; }
	inline void set_rotation_3(Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  value)
	{
		___rotation_3 = value;
	}

	inline static int32_t get_offset_of_scale_4() { return static_cast<int32_t>(offsetof(SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E, ___scale_4)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_scale_4() const { return ___scale_4; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_scale_4() { return &___scale_4; }
	inline void set_scale_4(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___scale_4 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.SkeletonBone
struct SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshaled_pinvoke
{
	char* ___name_0;
	char* ___parentName_1;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_2;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___rotation_3;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___scale_4;
};
// Native definition for COM marshalling of UnityEngine.SkeletonBone
struct SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshaled_com
{
	Il2CppChar* ___name_0;
	Il2CppChar* ___parentName_1;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___position_2;
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___rotation_3;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___scale_4;
};

// UnityEngine.StateInfoIndex
struct StateInfoIndex_t96A27EE74F87F915E3B8C246F2DAC129093492EE 
{
public:
	// System.Int32 UnityEngine.StateInfoIndex::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(StateInfoIndex_t96A27EE74F87F915E3B8C246F2DAC129093492EE, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.TrackedReference
struct TrackedReference_t17AA313389C655DCF279F96A2D85332B29596514  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.TrackedReference::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(TrackedReference_t17AA313389C655DCF279F96A2D85332B29596514, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.TrackedReference
struct TrackedReference_t17AA313389C655DCF279F96A2D85332B29596514_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.TrackedReference
struct TrackedReference_t17AA313389C655DCF279F96A2D85332B29596514_marshaled_com
{
	intptr_t ___m_Ptr_0;
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


// UnityEngine.Animations.AnimationClipPlayable
struct AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationClipPlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};


// UnityEngine.AnimationEvent
struct AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF  : public RuntimeObject
{
public:
	// System.Single UnityEngine.AnimationEvent::m_Time
	float ___m_Time_0;
	// System.String UnityEngine.AnimationEvent::m_FunctionName
	String_t* ___m_FunctionName_1;
	// System.String UnityEngine.AnimationEvent::m_StringParameter
	String_t* ___m_StringParameter_2;
	// UnityEngine.Object UnityEngine.AnimationEvent::m_ObjectReferenceParameter
	Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___m_ObjectReferenceParameter_3;
	// System.Single UnityEngine.AnimationEvent::m_FloatParameter
	float ___m_FloatParameter_4;
	// System.Int32 UnityEngine.AnimationEvent::m_IntParameter
	int32_t ___m_IntParameter_5;
	// System.Int32 UnityEngine.AnimationEvent::m_MessageOptions
	int32_t ___m_MessageOptions_6;
	// UnityEngine.AnimationEventSource UnityEngine.AnimationEvent::m_Source
	int32_t ___m_Source_7;
	// UnityEngine.AnimationState UnityEngine.AnimationEvent::m_StateSender
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * ___m_StateSender_8;
	// UnityEngine.AnimatorStateInfo UnityEngine.AnimationEvent::m_AnimatorStateInfo
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___m_AnimatorStateInfo_9;
	// UnityEngine.AnimatorClipInfo UnityEngine.AnimationEvent::m_AnimatorClipInfo
	AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  ___m_AnimatorClipInfo_10;

public:
	inline static int32_t get_offset_of_m_Time_0() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_Time_0)); }
	inline float get_m_Time_0() const { return ___m_Time_0; }
	inline float* get_address_of_m_Time_0() { return &___m_Time_0; }
	inline void set_m_Time_0(float value)
	{
		___m_Time_0 = value;
	}

	inline static int32_t get_offset_of_m_FunctionName_1() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_FunctionName_1)); }
	inline String_t* get_m_FunctionName_1() const { return ___m_FunctionName_1; }
	inline String_t** get_address_of_m_FunctionName_1() { return &___m_FunctionName_1; }
	inline void set_m_FunctionName_1(String_t* value)
	{
		___m_FunctionName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_FunctionName_1), (void*)value);
	}

	inline static int32_t get_offset_of_m_StringParameter_2() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_StringParameter_2)); }
	inline String_t* get_m_StringParameter_2() const { return ___m_StringParameter_2; }
	inline String_t** get_address_of_m_StringParameter_2() { return &___m_StringParameter_2; }
	inline void set_m_StringParameter_2(String_t* value)
	{
		___m_StringParameter_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_StringParameter_2), (void*)value);
	}

	inline static int32_t get_offset_of_m_ObjectReferenceParameter_3() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_ObjectReferenceParameter_3)); }
	inline Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * get_m_ObjectReferenceParameter_3() const { return ___m_ObjectReferenceParameter_3; }
	inline Object_tF2F3778131EFF286AF62B7B013A170F95A91571A ** get_address_of_m_ObjectReferenceParameter_3() { return &___m_ObjectReferenceParameter_3; }
	inline void set_m_ObjectReferenceParameter_3(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * value)
	{
		___m_ObjectReferenceParameter_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_ObjectReferenceParameter_3), (void*)value);
	}

	inline static int32_t get_offset_of_m_FloatParameter_4() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_FloatParameter_4)); }
	inline float get_m_FloatParameter_4() const { return ___m_FloatParameter_4; }
	inline float* get_address_of_m_FloatParameter_4() { return &___m_FloatParameter_4; }
	inline void set_m_FloatParameter_4(float value)
	{
		___m_FloatParameter_4 = value;
	}

	inline static int32_t get_offset_of_m_IntParameter_5() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_IntParameter_5)); }
	inline int32_t get_m_IntParameter_5() const { return ___m_IntParameter_5; }
	inline int32_t* get_address_of_m_IntParameter_5() { return &___m_IntParameter_5; }
	inline void set_m_IntParameter_5(int32_t value)
	{
		___m_IntParameter_5 = value;
	}

	inline static int32_t get_offset_of_m_MessageOptions_6() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_MessageOptions_6)); }
	inline int32_t get_m_MessageOptions_6() const { return ___m_MessageOptions_6; }
	inline int32_t* get_address_of_m_MessageOptions_6() { return &___m_MessageOptions_6; }
	inline void set_m_MessageOptions_6(int32_t value)
	{
		___m_MessageOptions_6 = value;
	}

	inline static int32_t get_offset_of_m_Source_7() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_Source_7)); }
	inline int32_t get_m_Source_7() const { return ___m_Source_7; }
	inline int32_t* get_address_of_m_Source_7() { return &___m_Source_7; }
	inline void set_m_Source_7(int32_t value)
	{
		___m_Source_7 = value;
	}

	inline static int32_t get_offset_of_m_StateSender_8() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_StateSender_8)); }
	inline AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * get_m_StateSender_8() const { return ___m_StateSender_8; }
	inline AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD ** get_address_of_m_StateSender_8() { return &___m_StateSender_8; }
	inline void set_m_StateSender_8(AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * value)
	{
		___m_StateSender_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_StateSender_8), (void*)value);
	}

	inline static int32_t get_offset_of_m_AnimatorStateInfo_9() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_AnimatorStateInfo_9)); }
	inline AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  get_m_AnimatorStateInfo_9() const { return ___m_AnimatorStateInfo_9; }
	inline AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * get_address_of_m_AnimatorStateInfo_9() { return &___m_AnimatorStateInfo_9; }
	inline void set_m_AnimatorStateInfo_9(AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  value)
	{
		___m_AnimatorStateInfo_9 = value;
	}

	inline static int32_t get_offset_of_m_AnimatorClipInfo_10() { return static_cast<int32_t>(offsetof(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF, ___m_AnimatorClipInfo_10)); }
	inline AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  get_m_AnimatorClipInfo_10() const { return ___m_AnimatorClipInfo_10; }
	inline AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * get_address_of_m_AnimatorClipInfo_10() { return &___m_AnimatorClipInfo_10; }
	inline void set_m_AnimatorClipInfo_10(AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  value)
	{
		___m_AnimatorClipInfo_10 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.AnimationEvent
struct AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshaled_pinvoke
{
	float ___m_Time_0;
	char* ___m_FunctionName_1;
	char* ___m_StringParameter_2;
	Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke ___m_ObjectReferenceParameter_3;
	float ___m_FloatParameter_4;
	int32_t ___m_IntParameter_5;
	int32_t ___m_MessageOptions_6;
	int32_t ___m_Source_7;
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * ___m_StateSender_8;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___m_AnimatorStateInfo_9;
	AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  ___m_AnimatorClipInfo_10;
};
// Native definition for COM marshalling of UnityEngine.AnimationEvent
struct AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshaled_com
{
	float ___m_Time_0;
	Il2CppChar* ___m_FunctionName_1;
	Il2CppChar* ___m_StringParameter_2;
	Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com* ___m_ObjectReferenceParameter_3;
	float ___m_FloatParameter_4;
	int32_t ___m_IntParameter_5;
	int32_t ___m_MessageOptions_6;
	int32_t ___m_Source_7;
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * ___m_StateSender_8;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___m_AnimatorStateInfo_9;
	AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  ___m_AnimatorClipInfo_10;
};

// UnityEngine.Animations.AnimationLayerMixerPlayable
struct AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationLayerMixerPlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};

struct AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_StaticFields
{
public:
	// UnityEngine.Animations.AnimationLayerMixerPlayable UnityEngine.Animations.AnimationLayerMixerPlayable::m_NullPlayable
	AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880  ___m_NullPlayable_1;

public:
	inline static int32_t get_offset_of_m_NullPlayable_1() { return static_cast<int32_t>(offsetof(AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_StaticFields, ___m_NullPlayable_1)); }
	inline AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880  get_m_NullPlayable_1() const { return ___m_NullPlayable_1; }
	inline AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * get_address_of_m_NullPlayable_1() { return &___m_NullPlayable_1; }
	inline void set_m_NullPlayable_1(AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880  value)
	{
		___m_NullPlayable_1 = value;
	}
};


// UnityEngine.Animations.AnimationMixerPlayable
struct AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMixerPlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};

struct AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_StaticFields
{
public:
	// UnityEngine.Animations.AnimationMixerPlayable UnityEngine.Animations.AnimationMixerPlayable::m_NullPlayable
	AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741  ___m_NullPlayable_1;

public:
	inline static int32_t get_offset_of_m_NullPlayable_1() { return static_cast<int32_t>(offsetof(AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_StaticFields, ___m_NullPlayable_1)); }
	inline AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741  get_m_NullPlayable_1() const { return ___m_NullPlayable_1; }
	inline AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * get_address_of_m_NullPlayable_1() { return &___m_NullPlayable_1; }
	inline void set_m_NullPlayable_1(AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741  value)
	{
		___m_NullPlayable_1 = value;
	}
};


// UnityEngine.Animations.AnimationMotionXToDeltaPlayable
struct AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMotionXToDeltaPlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};

struct AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_StaticFields
{
public:
	// UnityEngine.Animations.AnimationMotionXToDeltaPlayable UnityEngine.Animations.AnimationMotionXToDeltaPlayable::m_NullPlayable
	AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076  ___m_NullPlayable_1;

public:
	inline static int32_t get_offset_of_m_NullPlayable_1() { return static_cast<int32_t>(offsetof(AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_StaticFields, ___m_NullPlayable_1)); }
	inline AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076  get_m_NullPlayable_1() const { return ___m_NullPlayable_1; }
	inline AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * get_address_of_m_NullPlayable_1() { return &___m_NullPlayable_1; }
	inline void set_m_NullPlayable_1(AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076  value)
	{
		___m_NullPlayable_1 = value;
	}
};


// UnityEngine.Animations.AnimationOffsetPlayable
struct AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationOffsetPlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};

struct AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_StaticFields
{
public:
	// UnityEngine.Animations.AnimationOffsetPlayable UnityEngine.Animations.AnimationOffsetPlayable::m_NullPlayable
	AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941  ___m_NullPlayable_1;

public:
	inline static int32_t get_offset_of_m_NullPlayable_1() { return static_cast<int32_t>(offsetof(AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_StaticFields, ___m_NullPlayable_1)); }
	inline AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941  get_m_NullPlayable_1() const { return ___m_NullPlayable_1; }
	inline AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * get_address_of_m_NullPlayable_1() { return &___m_NullPlayable_1; }
	inline void set_m_NullPlayable_1(AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941  value)
	{
		___m_NullPlayable_1 = value;
	}
};


// UnityEngine.Animations.AnimationPlayableOutput
struct AnimationPlayableOutput_t14570F3E63619E52ABB0B0306D4F4AAA6225DE17 
{
public:
	// UnityEngine.Playables.PlayableOutputHandle UnityEngine.Animations.AnimationPlayableOutput::m_Handle
	PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationPlayableOutput_t14570F3E63619E52ABB0B0306D4F4AAA6225DE17, ___m_Handle_0)); }
	inline PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1 * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableOutputHandle_t8C84BCDB2AECFEDBCF0E7CC7CDBADD517D148CD1  value)
	{
		___m_Handle_0 = value;
	}
};


// UnityEngine.Animations.AnimationPosePlayable
struct AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationPosePlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};

struct AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_StaticFields
{
public:
	// UnityEngine.Animations.AnimationPosePlayable UnityEngine.Animations.AnimationPosePlayable::m_NullPlayable
	AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9  ___m_NullPlayable_1;

public:
	inline static int32_t get_offset_of_m_NullPlayable_1() { return static_cast<int32_t>(offsetof(AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_StaticFields, ___m_NullPlayable_1)); }
	inline AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9  get_m_NullPlayable_1() const { return ___m_NullPlayable_1; }
	inline AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * get_address_of_m_NullPlayable_1() { return &___m_NullPlayable_1; }
	inline void set_m_NullPlayable_1(AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9  value)
	{
		___m_NullPlayable_1 = value;
	}
};


// UnityEngine.Animations.AnimationRemoveScalePlayable
struct AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationRemoveScalePlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};

struct AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_StaticFields
{
public:
	// UnityEngine.Animations.AnimationRemoveScalePlayable UnityEngine.Animations.AnimationRemoveScalePlayable::m_NullPlayable
	AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429  ___m_NullPlayable_1;

public:
	inline static int32_t get_offset_of_m_NullPlayable_1() { return static_cast<int32_t>(offsetof(AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_StaticFields, ___m_NullPlayable_1)); }
	inline AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429  get_m_NullPlayable_1() const { return ___m_NullPlayable_1; }
	inline AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * get_address_of_m_NullPlayable_1() { return &___m_NullPlayable_1; }
	inline void set_m_NullPlayable_1(AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429  value)
	{
		___m_NullPlayable_1 = value;
	}
};


// UnityEngine.Animations.AnimationScriptPlayable
struct AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationScriptPlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};

struct AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_StaticFields
{
public:
	// UnityEngine.Animations.AnimationScriptPlayable UnityEngine.Animations.AnimationScriptPlayable::m_NullPlayable
	AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B  ___m_NullPlayable_1;

public:
	inline static int32_t get_offset_of_m_NullPlayable_1() { return static_cast<int32_t>(offsetof(AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_StaticFields, ___m_NullPlayable_1)); }
	inline AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B  get_m_NullPlayable_1() const { return ___m_NullPlayable_1; }
	inline AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * get_address_of_m_NullPlayable_1() { return &___m_NullPlayable_1; }
	inline void set_m_NullPlayable_1(AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B  value)
	{
		___m_NullPlayable_1 = value;
	}
};


// UnityEngine.AnimationState
struct AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD  : public TrackedReference_t17AA313389C655DCF279F96A2D85332B29596514
{
public:

public:
};


// UnityEngine.AnimatorControllerParameter
struct AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE  : public RuntimeObject
{
public:
	// System.String UnityEngine.AnimatorControllerParameter::m_Name
	String_t* ___m_Name_0;
	// UnityEngine.AnimatorControllerParameterType UnityEngine.AnimatorControllerParameter::m_Type
	int32_t ___m_Type_1;
	// System.Single UnityEngine.AnimatorControllerParameter::m_DefaultFloat
	float ___m_DefaultFloat_2;
	// System.Int32 UnityEngine.AnimatorControllerParameter::m_DefaultInt
	int32_t ___m_DefaultInt_3;
	// System.Boolean UnityEngine.AnimatorControllerParameter::m_DefaultBool
	bool ___m_DefaultBool_4;

public:
	inline static int32_t get_offset_of_m_Name_0() { return static_cast<int32_t>(offsetof(AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE, ___m_Name_0)); }
	inline String_t* get_m_Name_0() const { return ___m_Name_0; }
	inline String_t** get_address_of_m_Name_0() { return &___m_Name_0; }
	inline void set_m_Name_0(String_t* value)
	{
		___m_Name_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Name_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_Type_1() { return static_cast<int32_t>(offsetof(AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE, ___m_Type_1)); }
	inline int32_t get_m_Type_1() const { return ___m_Type_1; }
	inline int32_t* get_address_of_m_Type_1() { return &___m_Type_1; }
	inline void set_m_Type_1(int32_t value)
	{
		___m_Type_1 = value;
	}

	inline static int32_t get_offset_of_m_DefaultFloat_2() { return static_cast<int32_t>(offsetof(AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE, ___m_DefaultFloat_2)); }
	inline float get_m_DefaultFloat_2() const { return ___m_DefaultFloat_2; }
	inline float* get_address_of_m_DefaultFloat_2() { return &___m_DefaultFloat_2; }
	inline void set_m_DefaultFloat_2(float value)
	{
		___m_DefaultFloat_2 = value;
	}

	inline static int32_t get_offset_of_m_DefaultInt_3() { return static_cast<int32_t>(offsetof(AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE, ___m_DefaultInt_3)); }
	inline int32_t get_m_DefaultInt_3() const { return ___m_DefaultInt_3; }
	inline int32_t* get_address_of_m_DefaultInt_3() { return &___m_DefaultInt_3; }
	inline void set_m_DefaultInt_3(int32_t value)
	{
		___m_DefaultInt_3 = value;
	}

	inline static int32_t get_offset_of_m_DefaultBool_4() { return static_cast<int32_t>(offsetof(AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE, ___m_DefaultBool_4)); }
	inline bool get_m_DefaultBool_4() const { return ___m_DefaultBool_4; }
	inline bool* get_address_of_m_DefaultBool_4() { return &___m_DefaultBool_4; }
	inline void set_m_DefaultBool_4(bool value)
	{
		___m_DefaultBool_4 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.AnimatorControllerParameter
struct AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshaled_pinvoke
{
	char* ___m_Name_0;
	int32_t ___m_Type_1;
	float ___m_DefaultFloat_2;
	int32_t ___m_DefaultInt_3;
	int32_t ___m_DefaultBool_4;
};
// Native definition for COM marshalling of UnityEngine.AnimatorControllerParameter
struct AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshaled_com
{
	Il2CppChar* ___m_Name_0;
	int32_t ___m_Type_1;
	float ___m_DefaultFloat_2;
	int32_t ___m_DefaultInt_3;
	int32_t ___m_DefaultBool_4;
};

// UnityEngine.Animations.AnimatorControllerPlayable
struct AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 
{
public:
	// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimatorControllerPlayable::m_Handle
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___m_Handle_0;

public:
	inline static int32_t get_offset_of_m_Handle_0() { return static_cast<int32_t>(offsetof(AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4, ___m_Handle_0)); }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  get_m_Handle_0() const { return ___m_Handle_0; }
	inline PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * get_address_of_m_Handle_0() { return &___m_Handle_0; }
	inline void set_m_Handle_0(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  value)
	{
		___m_Handle_0 = value;
	}
};

struct AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_StaticFields
{
public:
	// UnityEngine.Animations.AnimatorControllerPlayable UnityEngine.Animations.AnimatorControllerPlayable::m_NullPlayable
	AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___m_NullPlayable_1;

public:
	inline static int32_t get_offset_of_m_NullPlayable_1() { return static_cast<int32_t>(offsetof(AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_StaticFields, ___m_NullPlayable_1)); }
	inline AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  get_m_NullPlayable_1() const { return ___m_NullPlayable_1; }
	inline AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * get_address_of_m_NullPlayable_1() { return &___m_NullPlayable_1; }
	inline void set_m_NullPlayable_1(AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  value)
	{
		___m_NullPlayable_1 = value;
	}
};


// UnityEngine.Avatar
struct Avatar_t1A1B32874530475986346E2EED62F9DDEE8C45C6  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.HumanBone
struct HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D 
{
public:
	// System.String UnityEngine.HumanBone::m_BoneName
	String_t* ___m_BoneName_0;
	// System.String UnityEngine.HumanBone::m_HumanName
	String_t* ___m_HumanName_1;
	// UnityEngine.HumanLimit UnityEngine.HumanBone::limit
	HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8  ___limit_2;

public:
	inline static int32_t get_offset_of_m_BoneName_0() { return static_cast<int32_t>(offsetof(HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D, ___m_BoneName_0)); }
	inline String_t* get_m_BoneName_0() const { return ___m_BoneName_0; }
	inline String_t** get_address_of_m_BoneName_0() { return &___m_BoneName_0; }
	inline void set_m_BoneName_0(String_t* value)
	{
		___m_BoneName_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_BoneName_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_HumanName_1() { return static_cast<int32_t>(offsetof(HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D, ___m_HumanName_1)); }
	inline String_t* get_m_HumanName_1() const { return ___m_HumanName_1; }
	inline String_t** get_address_of_m_HumanName_1() { return &___m_HumanName_1; }
	inline void set_m_HumanName_1(String_t* value)
	{
		___m_HumanName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_HumanName_1), (void*)value);
	}

	inline static int32_t get_offset_of_limit_2() { return static_cast<int32_t>(offsetof(HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D, ___limit_2)); }
	inline HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8  get_limit_2() const { return ___limit_2; }
	inline HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8 * get_address_of_limit_2() { return &___limit_2; }
	inline void set_limit_2(HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8  value)
	{
		___limit_2 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.HumanBone
struct HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshaled_pinvoke
{
	char* ___m_BoneName_0;
	char* ___m_HumanName_1;
	HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8  ___limit_2;
};
// Native definition for COM marshalling of UnityEngine.HumanBone
struct HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshaled_com
{
	Il2CppChar* ___m_BoneName_0;
	Il2CppChar* ___m_HumanName_1;
	HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8  ___limit_2;
};

// UnityEngine.Motion
struct Motion_t3EAEF01D52B05F10A21CC9B54A35C8F3F6BA3A67  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:
	// System.Boolean UnityEngine.Motion::<isAnimatorMotion>k__BackingField
	bool ___U3CisAnimatorMotionU3Ek__BackingField_4;

public:
	inline static int32_t get_offset_of_U3CisAnimatorMotionU3Ek__BackingField_4() { return static_cast<int32_t>(offsetof(Motion_t3EAEF01D52B05F10A21CC9B54A35C8F3F6BA3A67, ___U3CisAnimatorMotionU3Ek__BackingField_4)); }
	inline bool get_U3CisAnimatorMotionU3Ek__BackingField_4() const { return ___U3CisAnimatorMotionU3Ek__BackingField_4; }
	inline bool* get_address_of_U3CisAnimatorMotionU3Ek__BackingField_4() { return &___U3CisAnimatorMotionU3Ek__BackingField_4; }
	inline void set_U3CisAnimatorMotionU3Ek__BackingField_4(bool value)
	{
		___U3CisAnimatorMotionU3Ek__BackingField_4 = value;
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

// UnityEngine.RuntimeAnimatorController
struct RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
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


// UnityEngine.AnimationClip
struct AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178  : public Motion_t3EAEF01D52B05F10A21CC9B54A35C8F3F6BA3A67
{
public:

public:
};


// UnityEngine.AnimatorOverrideController
struct AnimatorOverrideController_t4630AA9761965F735AEB26B9A92D210D6338B2DA  : public RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB
{
public:
	// UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback UnityEngine.AnimatorOverrideController::OnOverrideControllerDirty
	OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * ___OnOverrideControllerDirty_4;

public:
	inline static int32_t get_offset_of_OnOverrideControllerDirty_4() { return static_cast<int32_t>(offsetof(AnimatorOverrideController_t4630AA9761965F735AEB26B9A92D210D6338B2DA, ___OnOverrideControllerDirty_4)); }
	inline OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * get_OnOverrideControllerDirty_4() const { return ___OnOverrideControllerDirty_4; }
	inline OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C ** get_address_of_OnOverrideControllerDirty_4() { return &___OnOverrideControllerDirty_4; }
	inline void set_OnOverrideControllerDirty_4(OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * value)
	{
		___OnOverrideControllerDirty_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___OnOverrideControllerDirty_4), (void*)value);
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


// System.InvalidCastException
struct InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
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


// UnityEngine.StateMachineBehaviour
struct StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F  : public ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A
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


// UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback
struct OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C  : public MulticastDelegate_t
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


// UnityEngine.Animator
struct Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
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

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// UnityEngine.AnimationEvent[]
struct AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * m_Items[1];

public:
	inline AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.ScriptableObject[]
struct ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * m_Items[1];

public:
	inline ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.StateMachineBehaviour[]
struct StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * m_Items[1];

public:
	inline StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.AnimatorClipInfo[]
struct AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  m_Items[1];

public:
	inline AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610  value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.AnimatorControllerParameter[]
struct AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * m_Items[1];

public:
	inline AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.AnimationClip[]
struct AnimationClipU5BU5D_t93D1A9ADEC832A4EABC0353D9E4E435B22B28489  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * m_Items[1];

public:
	inline AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * value)
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

IL2CPP_EXTERN_C void Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshal_pinvoke(const Object_tF2F3778131EFF286AF62B7B013A170F95A91571A& unmarshaled, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshal_pinvoke_back(const Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke& marshaled, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A& unmarshaled);
IL2CPP_EXTERN_C void Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshal_pinvoke_cleanup(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke& marshaled);
IL2CPP_EXTERN_C void Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshal_com(const Object_tF2F3778131EFF286AF62B7B013A170F95A91571A& unmarshaled, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com& marshaled);
IL2CPP_EXTERN_C void Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshal_com_back(const Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com& marshaled, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A& unmarshaled);
IL2CPP_EXTERN_C void Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshal_com_cleanup(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com& marshaled);

// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationLayerMixerPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_m866298E26CA43C28F7948D46E99D65FAA09722C5_gshared (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationMixerPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_m30062CF184CC05FFAA026881BEFE337C13B7E70E_gshared (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_m19943D18384297A3129F799C12E91B0D8162A02F_gshared (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationOffsetPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_m1B2FA89CE8F4A1EBD1AE3FF4E7154CFE120EDF85_gshared (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationPosePlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_m171336A5BD550FD80BFD4B2BDF5903DF72C0E1C2_gshared (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationRemoveScalePlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_mEF5219AC94275FE2811CEDC16FE0B850DBA7E9BE_gshared (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationScriptPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_m529F82044C8D4F4B60EA35E96D1C0592644AD76B_gshared (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimatorControllerPlayable>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_mFB1F4B388070EC30EC8DA09EB2869306EE60F2B8_gshared (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);

// System.Void UnityEngine.Animation::StopNamed(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_StopNamed_m54E2AFE7BE6B4BEFD190BEC410AF90B60F343114 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::RewindNamed(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_RewindNamed_m12EAEB94DF9DF5FC785F6357146FFB76EFD8679D (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method);
// UnityEngine.AnimationState UnityEngine.Animation::GetState(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_GetState_mE120497EC77651CF72D9406EBF8E221BCB0C2CA6 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animation::Play(UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_mE768E71A80625EBCE4577FA5F82E2A6E6FE4F9F8 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___mode0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animation::PlayDefaultAnimation(UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_PlayDefaultAnimation_mF95A24563D8A4517F75A8149D0961C2024DE8DAB (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___mode0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animation::Play(System.String,UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_m8F742F537EA22D32B109BB0B57F54315BA2182A1 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, int32_t ___mode1, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::CrossFade(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_CrossFade_m7D83F71B3DCF3D5F8995389669800718C988FA1A (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::CrossFade(System.String,System.Single,UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_CrossFade_m3FA2A5C413E36D5463FEDDFFD87582867F2ED65E (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, int32_t ___mode2, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::Blend(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Blend_mCFF0F9FA59C58DE151C122401F9ECFB1C60F5871 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___targetWeight1, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::Blend(System.String,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Blend_m339C51493052B179F994DDD4C4F15A8AD10ED273 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___targetWeight1, float ___fadeLength2, const RuntimeMethod* method);
// UnityEngine.AnimationState UnityEngine.Animation::CrossFadeQueued(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_CrossFadeQueued_mB89BA9FFE43A1F2091B8E53CD4D4941E46917AF2 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, const RuntimeMethod* method);
// UnityEngine.AnimationState UnityEngine.Animation::CrossFadeQueued(System.String,System.Single,UnityEngine.QueueMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_CrossFadeQueued_mA1604285B9C955AEE75E1EE4A94F90AE4EF1A71F (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, int32_t ___queue2, const RuntimeMethod* method);
// UnityEngine.AnimationState UnityEngine.Animation::CrossFadeQueued(System.String,System.Single,UnityEngine.QueueMode,UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_CrossFadeQueued_mA0B038DDBA8F38A1BE1991A5F316B5C831B26DF3 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, int32_t ___queue2, int32_t ___mode3, const RuntimeMethod* method);
// UnityEngine.AnimationState UnityEngine.Animation::PlayQueued(System.String,UnityEngine.QueueMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_PlayQueued_m8050313AC40A1749FE30F5671705B1F7B5A40CBD (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, int32_t ___queue1, const RuntimeMethod* method);
// UnityEngine.AnimationState UnityEngine.Animation::PlayQueued(System.String,UnityEngine.QueueMode,UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_PlayQueued_mA9D4C771AF24C3F0727AAD594F802D5D9C44F652 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, int32_t ___queue1, int32_t ___mode2, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::AddClip(UnityEngine.AnimationClip,System.String,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_AddClip_mEA5ED66A0C43400FC7A777BB132E024A172BC25B (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___clip0, String_t* ___newName1, int32_t ___firstFrame2, int32_t ___lastFrame3, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::AddClip(UnityEngine.AnimationClip,System.String,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_AddClip_m742D71B7A7C097BF4FD0A0329677B875320498F5 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___clip0, String_t* ___newName1, int32_t ___firstFrame2, int32_t ___lastFrame3, bool ___addLoopFrame4, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::RemoveClipNamed(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_RemoveClipNamed_m1DB64EC40379073AB780F8E90211A8A76F8B8B2E (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___clipName0, const RuntimeMethod* method);
// System.Void UnityEngine.Animation/Enumerator::.ctor(UnityEngine.Animation)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator__ctor_mC97A2B142004D7B757AAF61F6F069FB102372DBA (Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5 * __this, Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * ___outer0, const RuntimeMethod* method);
// System.Boolean UnityEngine.TrackedReference::op_Implicit(UnityEngine.TrackedReference)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool TrackedReference_op_Implicit_mDE5D31DEF5AB0B49315E6FD2F039DC63653D077D (TrackedReference_t17AA313389C655DCF279F96A2D85332B29596514 * ___exists0, const RuntimeMethod* method);
// UnityEngine.AnimationClip UnityEngine.AnimationState::get_clip()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * AnimationState_get_clip_m84FD95AFB1FDC356E53AA6F44089F69B353B42BB (AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::get_localBounds_Injected(UnityEngine.Bounds&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_get_localBounds_Injected_m5E0E63FDDEC0B0F7B5C51B7A854E0CD127B82C4C (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animation::set_localBounds_Injected(UnityEngine.Bounds&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_localBounds_Injected_m30737F4AD048A9BCBD605CB50FDA61A8EEF66195 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Behaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Behaviour__ctor_mCACD3614226521EA607B0F3640C0FAC7EACCBCE0 (Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Motion::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Motion__ctor_mDC0BDF6F52E99C4A69EFDAC157CC29D0C1A4F9E6 (Motion_t3EAEF01D52B05F10A21CC9B54A35C8F3F6BA3A67 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.AnimationClip::Internal_CreateAnimationClip(UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_Internal_CreateAnimationClip_mA9F511FF346799F0F2672D64998CD38D7CB2E168 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___self0, const RuntimeMethod* method);
// UnityEngine.WrapMode UnityEngine.AnimationClip::get_wrapMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimationClip_get_wrapMode_mC16973C5A6B4DEFBDE1DA84AA3BA96067B965A0E (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.AnimationClip::SampleAnimation(UnityEngine.GameObject,UnityEngine.AnimationClip,System.Single,UnityEngine.WrapMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_SampleAnimation_m4C7B0F20B3E375B0FA68B8DF0B42BC67E3287ED8 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___go0, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___clip1, float ___inTime2, int32_t ___wrapMode3, const RuntimeMethod* method);
// System.Void UnityEngine.AnimationClip::get_localBounds_Injected(UnityEngine.Bounds&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_get_localBounds_Injected_m5B95A86FEBB219110EEA104809880830423231B2 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.AnimationClip::set_localBounds_Injected(UnityEngine.Bounds&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_localBounds_Injected_m4B78ABE1CC5A3C7485295EBBEAF25987A98689BE (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * ___value0, const RuntimeMethod* method);
// System.Void System.ArgumentNullException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentNullException__ctor_m81AB157B93BFE2FBFDB08B88F84B444293042F97 (ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB * __this, String_t* ___paramName0, const RuntimeMethod* method);
// System.Void UnityEngine.AnimationClip::AddEventInternal(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_AddEventInternal_m38EF420E8042297AB276AA4D92FA5531F9F6D273 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, RuntimeObject * ___evt0, const RuntimeMethod* method);
// System.Array UnityEngine.AnimationClip::GetEventsInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeArray * AnimationClip_GetEventsInternal_m9A7D3DD46EA3C7F7B935623D3C7640414CF338D8 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.AnimationClip::SetEventsInternal(System.Array)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_SetEventsInternal_m7A1129D019A40C7FD09B5D1C721002268AFD2878 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, RuntimeArray * ___value0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationClipPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationClipPlayable_GetHandle_m93C27911A3C7107750C2A6BE529C58FB2FDB1122 (AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::op_Equality(UnityEngine.Playables.PlayableHandle,UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_op_Equality_mFD26CFA8ECF2B622B1A3D4117066CAE965C9F704 (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___x0, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___y1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::Equals(UnityEngine.Animations.AnimationClipPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_Equals_m73BDBE0839B6AA4782C37B21DD58D3388B5EC814 (AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 * __this, AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953  ___other0, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6 (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationLayerMixerPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_m866298E26CA43C28F7948D46E99D65FAA09722C5 (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_m866298E26CA43C28F7948D46E99D65FAA09722C5_gshared)(__this, method);
}
// System.Void System.InvalidCastException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3 (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable__ctor_m42F8E5BB37A175AF298324D3072932ED9946427B (AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationLayerMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationLayerMixerPlayable_GetHandle_mBFA950F140D76E10983B9AB946397F4C12ABC439 (AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::Equals(UnityEngine.Animations.AnimationLayerMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_Equals_m018BD27B24B3EDC5101A475A14F13F753F2323AA (AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * __this, AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880  ___other0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Playables.PlayableHandle::get_Null()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612 (const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationMixerPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_m30062CF184CC05FFAA026881BEFE337C13B7E70E (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_m30062CF184CC05FFAA026881BEFE337C13B7E70E_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationMixerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMixerPlayable__ctor_mA03CF37709B7854227E25F91BE4F7559981058B0 (AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationMixerPlayable_GetHandle_mE8F7D1A18F1BD1C00BA1EC6AA8036044E8907FC3 (AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animations.AnimationMixerPlayable::Equals(UnityEngine.Animations.AnimationMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMixerPlayable_Equals_m8979D90ED92FF553B5D6AB0BDD616C544352816B (AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * __this, AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_m19943D18384297A3129F799C12E91B0D8162A02F (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_m19943D18384297A3129F799C12E91B0D8162A02F_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable__ctor_m11668860161B62484EA095BD6360AFD26A86DE93 (AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMotionXToDeltaPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationMotionXToDeltaPlayable_GetHandle_m840D19A4E2DFB4BF2397061B833E63AD786587BA (AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animations.AnimationMotionXToDeltaPlayable::Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMotionXToDeltaPlayable_Equals_mB08A41C628755AF909489716A1D62AECC2BFDD9E (AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * __this, AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationOffsetPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_m1B2FA89CE8F4A1EBD1AE3FF4E7154CFE120EDF85 (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_m1B2FA89CE8F4A1EBD1AE3FF4E7154CFE120EDF85_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationOffsetPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationOffsetPlayable__ctor_m9527E52AEA325EAE188AB9843497F2AB33CB742E (AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationOffsetPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationOffsetPlayable_GetHandle_m8C3C08EC531127B002D3AFAB5AF259D8030B0049 (AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animations.AnimationOffsetPlayable::Equals(UnityEngine.Animations.AnimationOffsetPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationOffsetPlayable_Equals_m9AFE60B035481569924E20C6953B4B21EF7734AA (AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * __this, AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationPosePlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_m171336A5BD550FD80BFD4B2BDF5903DF72C0E1C2 (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_m171336A5BD550FD80BFD4B2BDF5903DF72C0E1C2_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationPosePlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPosePlayable__ctor_m318607F120F21EDE3D7C1ED07C8B2ED13A23BF57 (AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationPosePlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationPosePlayable_GetHandle_m0354C54EB680FC70D4B48D95F7FC4BA4700A0DCE (AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animations.AnimationPosePlayable::Equals(UnityEngine.Animations.AnimationPosePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationPosePlayable_Equals_mECC5FA256AAA5334C38DBB6D00EE8AC1BDC015A1 (AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * __this, AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationRemoveScalePlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_mEF5219AC94275FE2811CEDC16FE0B850DBA7E9BE (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_mEF5219AC94275FE2811CEDC16FE0B850DBA7E9BE_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationRemoveScalePlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationRemoveScalePlayable__ctor_m08810C8ECE9A3A100087DD84B13204EC3AF73A8F (AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationRemoveScalePlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationRemoveScalePlayable_GetHandle_m1949202B58BDF17726A1ADC934EB5232E835CCA8 (AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animations.AnimationRemoveScalePlayable::Equals(UnityEngine.Animations.AnimationRemoveScalePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationRemoveScalePlayable_Equals_m7FE9E55B027861A0B91347F18DAC7E11E2740397 (AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * __this, AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429  ___other0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationScriptPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_m529F82044C8D4F4B60EA35E96D1C0592644AD76B (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_m529F82044C8D4F4B60EA35E96D1C0592644AD76B_gshared)(__this, method);
}
// System.Void UnityEngine.Animations.AnimationScriptPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable__ctor_m0B751F7A7D28F59AADACE7C13704D653E0879C56 (AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationScriptPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationScriptPlayable_GetHandle_mCEA7899E7E43FC2C73B3331AE27C289327F03B18 (AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animations.AnimationScriptPlayable::Equals(UnityEngine.Animations.AnimationScriptPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationScriptPlayable_Equals_m1705DCC80312E3D34E17B32BDBAF4BBB78D435D8 (AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * __this, AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B  ___other0, const RuntimeMethod* method);
// System.Void UnityEngine.TrackedReference::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TrackedReference__ctor_m7E082F3A77162102770CCB781B5EAE437AB373CD (TrackedReference_t17AA313389C655DCF279F96A2D85332B29596514 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Animator::GetFloatString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloatString_m1A82C1B3C58A2A289AF6002EEAD2C217197CF5E6 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Single UnityEngine.Animator::GetFloatID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloatID_mC18A6BBCE86EE27603FEE22E31A4657AE75FAE17 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetFloatString(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatString_m0D1D54020A1D7F9E73A84DAA5FF118ED31F3E943 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, float ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetFloatStringDamp(System.String,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatStringDamp_mE5687E1F614DEDDE45110DA6A55F1B5499667B0C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, float ___value1, float ___dampTime2, float ___deltaTime3, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetFloatID(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatID_m277DFF321B75EE54886A5BD1FECF7E3E3CE5D4B2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, float ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetFloatIDDamp(System.Int32,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatIDDamp_mE2C9E4DC3B8A75AE7CD1B14437E4F0F092B4EF66 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, float ___value1, float ___dampTime2, float ___deltaTime3, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animator::GetBoolString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBoolString_mCACE093AEB7F1FDB919A2F5D6057E95124CF6980 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animator::GetBoolID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBoolID_m1C533DC66ECF19A118119773458D0F018F2238F0 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetBoolString(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoolString_mB0D21540179FFB9E5F1B2C2EF008BD0595B78BA7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, bool ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetBoolID(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoolID_m86E6B6BAB2AF50CF90D6E6DA56579AF08E5A9342 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, bool ___value1, const RuntimeMethod* method);
// System.Int32 UnityEngine.Animator::GetIntegerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetIntegerString_m812EDB3BBD70E2910B5C06518D4A383AE3FCCA77 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Animator::GetIntegerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetIntegerID_m6BDA07EF7C93439AB21AB8C8AE84AE5E2BDBB7B1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetIntegerString(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIntegerString_m98F3F5AF11579CA8F0DD2C43625CBE6258999CB9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, int32_t ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetIntegerID(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIntegerID_m935BD3F26317A508AA8EE0642E4D3F0A083673F6 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, int32_t ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetTriggerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTriggerString_m38F66A49276BCED56B89BB6AF8A36183BE4285F0 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetTriggerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTriggerID_mF7C748DA4002FE27B11A23AB015E761EACE374E9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::ResetTriggerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTriggerString_m6FC21A6B7732A31338EE22E78F3D6220903EDBB2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::ResetTriggerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTriggerID_m982AAC9DF5A10C9ED32F52A5F2DD67C4C85DC111 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animator::IsParameterControlledByCurveString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsParameterControlledByCurveString_m51A328B88D4BF88623289AAE897FF4C4AC06556C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animator::IsParameterControlledByCurveID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsParameterControlledByCurveID_m741E77411D309424E5A2A55D74C92D87CB618B9B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_deltaPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_deltaPosition_Injected_m1E4EE8E8FF829CD0CA02B5B2993B8F52F51FAE7E (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_deltaRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_deltaRotation_Injected_mDD91E09560E64E4CD711CF2A0FCB93B9607976D5 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_velocity_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_velocity_Injected_m225EE219299DD0B557685EEBB8C98687A5ABD772 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_angularVelocity_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_angularVelocity_Injected_m111D48072DE65364FA873BEAA14288C44A0538F9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_rootPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_rootPosition_Injected_m3BDD26353E59D49EA2D775B52E87D2430C207836 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::set_rootPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_rootPosition_Injected_m4D693A6922FB9722FB27F58CD291A14DC21FF930 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_rootRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_rootRotation_Injected_mEDD72EDFCAFB6AA9069D2A8A69C4FF5CFFC442F4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::set_rootRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_rootRotation_Injected_m91F597BA80DD077F49C4FD623E5055C5B3F5EAF3 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___value0, const RuntimeMethod* method);
// UnityEngine.AnimatorUpdateMode UnityEngine.Animator::get_updateMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_get_updateMode_mEAAB40A7FC26FB82707B27D27AE946ADD81A4D00 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::set_updateMode(UnityEngine.AnimatorUpdateMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_updateMode_mD10A679F349D4BD7722E1D700215592BDC4B05CE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::CheckIfInIKPass()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Animator::get_bodyPositionInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_bodyPositionInternal_m34906C8C0220B4E5473424B4D2AF010D7ABC9AD0 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::set_bodyPositionInternal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPositionInternal_m39B875F219304D11B1616812D2081EDB72FF1126 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_bodyPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_bodyPositionInternal_Injected_mA3BAEBD74BAA40C266181E9FEDFC924B26C5D1A3 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::set_bodyPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPositionInternal_Injected_m06CF9B9758465B3C3F7B901A9EFFA91E169B604A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___value0, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Animator::get_bodyRotationInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_get_bodyRotationInternal_m890643943203FF53B44FEFE00F8F8D3D083F34A4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::set_bodyRotationInternal(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotationInternal_m27796243543715931044588F28C0A55EDC191F9C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_bodyRotationInternal_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_bodyRotationInternal_Injected_m9728DF9FB2429838E333C3E407348B596015212F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::set_bodyRotationInternal_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotationInternal_Injected_mF305D187AC0A67B81FE749925B80CA593442D9DE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___value0, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Animator::GetGoalPosition(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_GetGoalPosition_m089F722199DBEC377CDE256A74CEAF60A51F71BA (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::GetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetGoalPosition_Injected_mB7A7DDCC49EAF85921366EFDAF4038002AC18597 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetGoalPosition(UnityEngine.AvatarIKGoal,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalPosition_m01430E4C8D0433E8782E20E9F90589E772F7493A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___goalPosition1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalPosition_Injected_m1F55B0A5FB8E563348DEF0C839D855D1B8084870 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___goalPosition1, const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Animator::GetGoalRotation(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_GetGoalRotation_m72679689F5888F5452D58ECE3C238DFCA0AB3D9F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::GetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetGoalRotation_Injected_m2887FC6A66153B5C6F560EA6106A1798E02D3CBD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetGoalRotation(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalRotation_mB88FA15754BA6688DEC7686EAE75CC6750C76F8A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___goalRotation1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalRotation_Injected_m51FB734E9C792821846E5C33FD301879320867B8 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___goalRotation1, const RuntimeMethod* method);
// System.Single UnityEngine.Animator::GetGoalWeightPosition(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetGoalWeightPosition_mCF2EF821773583FC80293F53C23F3E5DA0467E6D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetGoalWeightPosition(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalWeightPosition_mB2A22B5F388D118521990BA45983357A8938FF03 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, float ___value1, const RuntimeMethod* method);
// System.Single UnityEngine.Animator::GetGoalWeightRotation(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetGoalWeightRotation_mA4349BC8109EA7EC3FD79B64E4410C34001B0CA4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetGoalWeightRotation(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalWeightRotation_mC3BE8A348023FCFE0A616157FC12C5FC50537A2A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, float ___value1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Animator::GetHintPosition(UnityEngine.AvatarIKHint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_GetHintPosition_mDA8C9EEE46FA4F1292C61E5B1A228ECD2D8B4EED (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::GetHintPosition_Injected(UnityEngine.AvatarIKHint,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetHintPosition_Injected_m96EC2D942E6D74FC24CA9D60EBBB73AEA1EFCC39 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetHintPosition(UnityEngine.AvatarIKHint,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetHintPosition_mB865182A27E4D7AA4B101C39A355819BCECAC565 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___hintPosition1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetHintPosition_Injected(UnityEngine.AvatarIKHint,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetHintPosition_Injected_m743A8699923BB0AF0BB07EF6C8AF04C1CCD1EC17 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___hintPosition1, const RuntimeMethod* method);
// System.Single UnityEngine.Animator::GetHintWeightPosition(UnityEngine.AvatarIKHint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetHintWeightPosition_m43790DA28C67149F4F0F1A0A352CF5836CFF8227 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetHintWeightPosition(UnityEngine.AvatarIKHint,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetHintWeightPosition_m7DC3A766B3816E65669DDF35A963DFD4084CBF5E (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, float ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetLookAtPositionInternal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPositionInternal_m54D0B2ABC530C6E05989DAB2D8F642BB030BDDEC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___lookAtPosition0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetLookAtPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPositionInternal_Injected_mE79031C5471CA6C40B98D6C1654C55D23FEF021C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___lookAtPosition0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetLookAtWeightInternal(System.Single,System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___weight0, float ___bodyWeight1, float ___headWeight2, float ___eyesWeight3, float ___clampWeight4, const RuntimeMethod* method);
// System.Int32 UnityEngine.HumanTrait::GetBoneIndexFromMono(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t HumanTrait_GetBoneIndexFromMono_m144C635F3328D73F0EFDAE3203B31537B75E1824 (int32_t ___humanId0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetBoneLocalRotationInternal(System.Int32,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoneLocalRotationInternal_m2F65BCDA327433B33029A57B9F8C8812B72320AE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___humanBoneId0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___rotation1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::SetBoneLocalRotationInternal_Injected(System.Int32,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoneLocalRotationInternal_Injected_m78B08DD15F6216F850A89A71BD65DC9FDE36AAE7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___humanBoneId0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___rotation1, const RuntimeMethod* method);
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E (RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ___handle0, const RuntimeMethod* method);
// UnityEngine.ScriptableObject[] UnityEngine.Animator::InternalGetBehavioursByKey(System.Int32,System.Int32,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208* Animator_InternalGetBehavioursByKey_mF775E4A33B17ECB795CA1F7837C1964CFD28490A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___fullPathHash0, int32_t ___layerIndex1, Type_t * ___type2, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::GetAnimatorStateInfo(System.Int32,UnityEngine.StateInfoIndex,UnityEngine.AnimatorStateInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorStateInfo_m623172399D38470B4C5EB7DE06A3106AB6958657 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, int32_t ___stateInfoIndex1, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * ___info2, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::GetAnimatorTransitionInfo(System.Int32,UnityEngine.AnimatorTransitionInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorTransitionInfo_mBB68CA61A21C4D60B1109815CC4353628B428472 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0 * ___info1, const RuntimeMethod* method);
// System.Int32 UnityEngine.Animator::GetAnimatorClipInfoCount(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetAnimatorClipInfoCount_m80A50EDDEAFD721E18702F7F0706552A3C883D3B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, bool ___current1, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::GetAnimatorClipInfoInternal(System.Int32,System.Boolean,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorClipInfoInternal_m7369503B85FAE6630B97209D4F3A7492BD31EA39 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, bool ___isCurrent1, RuntimeObject * ___clips2, const RuntimeMethod* method);
// UnityEngine.AnimatorControllerParameter[] UnityEngine.Animator::get_parameters()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* Animator_get_parameters_m77F06017E5D918C35FEB6A60B4A78E97DFB81CCA (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// System.String System.Int32::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411 (int32_t* __this, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// System.Void System.IndexOutOfRangeException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IndexOutOfRangeException__ctor_mC5747EC0E0F49AAD1AD782ACC7A0CCD80D192FEF (IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_pivotPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_pivotPosition_Injected_mAF27659230FFC6425898DD0675CF34D2234677B1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::MatchTarget_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,System.Int32,UnityEngine.MatchTargetWeightMask&,System.Single,System.Single,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_MatchTarget_Injected_m82320F2465819561765E195C1DB8E69A8A373A3F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___matchPosition0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___matchRotation1, int32_t ___targetBodyPart2, MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 * ___weightMask3, float ___startNormalizedTime4, float ___targetNormalizedTime5, bool ___completeMatch6, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::MatchTarget(UnityEngine.Vector3,UnityEngine.Quaternion,System.Int32,UnityEngine.MatchTargetWeightMask,System.Single,System.Single,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_MatchTarget_m2B22003B1CCB0EB766E97D83B3D8C716FEBCDB59 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___matchPosition0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___matchRotation1, int32_t ___targetBodyPart2, MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6  ___weightMask3, float ___startNormalizedTime4, float ___targetNormalizedTime5, bool ___completeMatch6, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::InterruptMatchTarget(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_InterruptMatchTarget_m84B1E5334849D1BA1FF7E7A80D059DCC075AE070 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___completeMatch0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::Play(System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateNameHash0, int32_t ___layer1, float ___normalizedTime2, const RuntimeMethod* method);
// System.Int32 UnityEngine.Animator::StringToHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668 (String_t* ___name0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.Int32,System.Single,System.Int32,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___fixedTransitionDuration1, int32_t ___layer2, float ___fixedTimeOffset3, float ___normalizedTransitionTime4, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::CrossFade(System.String,System.Single,System.Int32,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_mDD4CB6DEED448B3324562943FBA1A64E2E437B8B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___normalizedTransitionDuration1, int32_t ___layer2, float ___normalizedTimeOffset3, float ___normalizedTransitionTime4, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::CrossFade(System.Int32,System.Single,System.Int32,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___normalizedTransitionDuration1, int32_t ___layer2, float ___normalizedTimeOffset3, float ___normalizedTransitionTime4, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::PlayInFixedTime(System.String,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_PlayInFixedTime_m0CDAEF81DD585E705E54D1B5621209E9C68407DD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, int32_t ___layer1, float ___fixedTime2, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::PlayInFixedTime(System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_PlayInFixedTime_mB532E778E6810C115C70B824DAD7D562434DB0AA (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateNameHash0, int32_t ___layer1, float ___fixedTime2, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::Play(System.String,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_m1438EDACA2804B50ED0D00D9986E30BCF903418B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, int32_t ___layer1, float ___normalizedTime2, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_targetPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_targetPosition_Injected_m8DD5663D05D4E687B3B8FD3C88FF936D94D6B729 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::get_targetRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_targetRotation_Injected_m95B6C40BDD6E4972C5FB4F896D6DEF6519FCCA41 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret0, const RuntimeMethod* method);
// UnityEngine.Transform UnityEngine.Animator::GetBoneTransformInternal(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Animator_GetBoneTransformInternal_mA7FFA1587D3C3ABE27901D845E71765444F13F74 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___humanBoneId0, const RuntimeMethod* method);
// System.Single UnityEngine.Animator::GetRecorderStartTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetRecorderStartTime_mBA14285A955EA02ADC65516542147ED919F1272F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.Animator::GetRecorderStopTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetRecorderStopTime_mC5F49DAF7CA0C6AB54D1EF7CE0D41FAB4108CB15 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::GetCurrentGraph(UnityEngine.Playables.PlayableGraph&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetCurrentGraph_mB07D1ED5E6A81D218B4CD41F224129BC56C45D6F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A * ___graph0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animator::get_logWarnings()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_logWarnings_m692C78DB988B112179D3D42A22310E2317B8BE4A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Animator::IsInIKPass()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsInIKPass_mD14286C3D16BE2031BA3D278F884337815D76FAC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::Rebind(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Rebind_m385B65982B5147AA4BC4FB7209F1578AAE2E65B2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___writeDefaultValues0, const RuntimeMethod* method);
// System.Void UnityEngine.Animator::EvaluateController(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_EvaluateController_mD4751CCBDA8ABF86063783231EBDE9C260458E06 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___deltaTime0, const RuntimeMethod* method);
// System.String UnityEngine.Animator::GetAnimatorStateName(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Animator_GetAnimatorStateName_m91AED430D363500BA29903D513CCE4AF783CF0C1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, bool ___current1, const RuntimeMethod* method);
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6 (const RuntimeMethod* method);
// UnityEngine.Quaternion UnityEngine.Quaternion::get_identity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702 (const RuntimeMethod* method);
// UnityEngine.AnimationClip UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mDA532C9ADE4056E3577FD254944CAF65767DC58B (int32_t ___instanceID0, const RuntimeMethod* method);
// UnityEngine.AnimationClip UnityEngine.AnimatorClipInfo::get_clip()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * AnimatorClipInfo_get_clip_m0822D4BB447803A294410A319C812D2D4B946A95 (AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * __this, const RuntimeMethod* method);
// System.Single UnityEngine.AnimatorClipInfo::get_weight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorClipInfo_get_weight_mF22612DA966F5D6C8EC93E6AD2E05DFE10B36CCA (AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * __this, const RuntimeMethod* method);
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method);
// System.String UnityEngine.AnimatorControllerParameter::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimatorControllerParameter_get_name_m210BF40EC0AC18BA2E21F089F3182FE1CFCE3A55 (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetHandle(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetHandle_m19111E2A65EDAB3382AC9BE815503459A495FF38 (AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable__ctor_mBD4E1368EB671F6349C5740B1BF131F97BD12CC8 (AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method);
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimatorControllerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimatorControllerPlayable_GetHandle_mBB2911E1B1867ED9C9080BEF16838119A51E0C0C (AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * __this, const RuntimeMethod* method);
// System.Void System.InvalidOperationException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimatorControllerPlayable>()
inline bool PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_mFB1F4B388070EC30EC8DA09EB2869306EE60F2B8 (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *, const RuntimeMethod*))PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_mFB1F4B388070EC30EC8DA09EB2869306EE60F2B8_gshared)(__this, method);
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::Equals(UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_Equals_m9D2F918EE07AE657A11C13F285317C05BB257730 (AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * __this, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___other0, const RuntimeMethod* method);
// System.Void UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnOverrideControllerDirtyCallback_Invoke_m21DB79300E852ED93F2521FFC03EC4D858F6B330 (OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.AnimatorStateInfo::IsName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_IsName_mF1263FB1F2AB142CFEB61B375D6EEBCFD53F9428 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Int32 UnityEngine.AnimatorStateInfo::get_fullPathHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_fullPathHash_m296D315AB1FBF6177A423298296CECC1DBA7221D (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.AnimatorStateInfo::get_nameHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_nameHash_mC9F45156C83F42488C753C811229B50E74D97E5E (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.AnimatorStateInfo::get_shortNameHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_shortNameHash_m03CE17FD0EBFF3C2007407F6B3EE9911923DA998 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Single UnityEngine.AnimatorStateInfo::get_normalizedTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_normalizedTime_mC951C5D83749FC2AE37DCC75A022383C578F3B40 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Single UnityEngine.AnimatorStateInfo::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_length_m020815F180AA8D3485CC6AB59A7E596BBA11D6CF (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Single UnityEngine.AnimatorStateInfo::get_speed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_speed_m1B2CAB95244A0ECCE42F79CCFC22BA7CB8618843 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Single UnityEngine.AnimatorStateInfo::get_speedMultiplier()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_speedMultiplier_m9B6B8F0D9654B51B60E2A3BD01FA4C88FB60B793 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Int32 UnityEngine.AnimatorStateInfo::get_tagHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_tagHash_m9DD7F1BE3041F4B51F624311735C02D77A398A97 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.AnimatorStateInfo::IsTag(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_IsTag_m57ADE8725918F9AA03DB5E91EF0301479FF049CA (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, String_t* ___tag0, const RuntimeMethod* method);
// System.Boolean UnityEngine.AnimatorStateInfo::get_loop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_get_loop_mC5EDC24973284F2976E57A6558DBD360820FEED0 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m4DCF5CDB32C2C69290894101A81F473865169279 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, const RuntimeMethod* method);
// System.Void UnityEngine.MatchTargetWeightMask::.ctor(UnityEngine.Vector3,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MatchTargetWeightMask__ctor_mCEB082CDAEDABC6E78F8A239716CABDD4822C1DB (MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positionXYZWeight0, float ___rotationWeight1, const RuntimeMethod* method);
// System.Void System.Attribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Attribute__ctor_m5C1862A7DFC2C25A4797A8C5F681FBB5CB53ECE1 (Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.ScriptableObject::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScriptableObject__ctor_m8DAE6CDCFA34E16F2543B02CC3669669FF203063 (ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * __this, const RuntimeMethod* method);
// UnityEngine.AnimationState UnityEngine.Animation::GetStateAtIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_GetStateAtIndex_m436707B278555E5B3AD4FB8F7B1A04F532CDC679 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Animation::GetStateCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animation_GetStateCount_mBFB004C6182E7243A2DFA09D7E378A94AC61AABA (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method);
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
// UnityEngine.AnimationClip UnityEngine.Animation::get_clip()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * Animation_get_clip_m9F02A36E375CE335DA87A6F0B81070CFB98A871B (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * (*Animation_get_clip_m9F02A36E375CE335DA87A6F0B81070CFB98A871B_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_get_clip_m9F02A36E375CE335DA87A6F0B81070CFB98A871B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_get_clip_m9F02A36E375CE335DA87A6F0B81070CFB98A871B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::get_clip()");
	AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animation::set_clip(UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_clip_mCEC582FF8FE05B1F41E2BAC2C33E60D643C1E211 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Animation_set_clip_mCEC582FF8FE05B1F41E2BAC2C33E60D643C1E211_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static Animation_set_clip_mCEC582FF8FE05B1F41E2BAC2C33E60D643C1E211_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_set_clip_mCEC582FF8FE05B1F41E2BAC2C33E60D643C1E211_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::set_clip(UnityEngine.AnimationClip)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Animation::get_playAutomatically()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_get_playAutomatically_m8645FCBF323004296B900CBDA85570239F5EB0DE (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animation_get_playAutomatically_m8645FCBF323004296B900CBDA85570239F5EB0DE_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_get_playAutomatically_m8645FCBF323004296B900CBDA85570239F5EB0DE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_get_playAutomatically_m8645FCBF323004296B900CBDA85570239F5EB0DE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::get_playAutomatically()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animation::set_playAutomatically(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_playAutomatically_mA0DB7A68D350AB46186C5E59E8976FE66BC9D456 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animation_set_playAutomatically_mA0DB7A68D350AB46186C5E59E8976FE66BC9D456_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, bool);
	static Animation_set_playAutomatically_mA0DB7A68D350AB46186C5E59E8976FE66BC9D456_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_set_playAutomatically_mA0DB7A68D350AB46186C5E59E8976FE66BC9D456_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::set_playAutomatically(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.WrapMode UnityEngine.Animation::get_wrapMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animation_get_wrapMode_m9DFF40D06CB14F96C79B6BCC272F1E166CA79B3E (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animation_get_wrapMode_m9DFF40D06CB14F96C79B6BCC272F1E166CA79B3E_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_get_wrapMode_m9DFF40D06CB14F96C79B6BCC272F1E166CA79B3E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_get_wrapMode_m9DFF40D06CB14F96C79B6BCC272F1E166CA79B3E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::get_wrapMode()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animation::set_wrapMode(UnityEngine.WrapMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_wrapMode_m27F6F0A482EF9EB1CFB350E294D1404C8ADE8A94 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*Animation_set_wrapMode_m27F6F0A482EF9EB1CFB350E294D1404C8ADE8A94_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, int32_t);
	static Animation_set_wrapMode_m27F6F0A482EF9EB1CFB350E294D1404C8ADE8A94_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_set_wrapMode_m27F6F0A482EF9EB1CFB350E294D1404C8ADE8A94_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::set_wrapMode(UnityEngine.WrapMode)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Animation::Stop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Stop_m06283FD9F64A3B05A2A248AE2B86C7F88D479DE9 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef void (*Animation_Stop_m06283FD9F64A3B05A2A248AE2B86C7F88D479DE9_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_Stop_m06283FD9F64A3B05A2A248AE2B86C7F88D479DE9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_Stop_m06283FD9F64A3B05A2A248AE2B86C7F88D479DE9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::Stop()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.Animation::Stop(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Stop_m84D4DE04495B1AA30D43B00DD720C88FAFE60EEB (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___name0;
		Animation_StopNamed_m54E2AFE7BE6B4BEFD190BEC410AF90B60F343114(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::StopNamed(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_StopNamed_m54E2AFE7BE6B4BEFD190BEC410AF90B60F343114 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef void (*Animation_StopNamed_m54E2AFE7BE6B4BEFD190BEC410AF90B60F343114_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*);
	static Animation_StopNamed_m54E2AFE7BE6B4BEFD190BEC410AF90B60F343114_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_StopNamed_m54E2AFE7BE6B4BEFD190BEC410AF90B60F343114_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::StopNamed(System.String)");
	_il2cpp_icall_func(__this, ___name0);
}
// System.Void UnityEngine.Animation::Rewind()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Rewind_m9702AA2EE881928BA38D592E51711D3298BAF3BE (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef void (*Animation_Rewind_m9702AA2EE881928BA38D592E51711D3298BAF3BE_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_Rewind_m9702AA2EE881928BA38D592E51711D3298BAF3BE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_Rewind_m9702AA2EE881928BA38D592E51711D3298BAF3BE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::Rewind()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.Animation::Rewind(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Rewind_m0738049D8BD59D534E46AD4652DA0916CEBA2F85 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___name0;
		Animation_RewindNamed_m12EAEB94DF9DF5FC785F6357146FFB76EFD8679D(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::RewindNamed(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_RewindNamed_m12EAEB94DF9DF5FC785F6357146FFB76EFD8679D (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef void (*Animation_RewindNamed_m12EAEB94DF9DF5FC785F6357146FFB76EFD8679D_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*);
	static Animation_RewindNamed_m12EAEB94DF9DF5FC785F6357146FFB76EFD8679D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_RewindNamed_m12EAEB94DF9DF5FC785F6357146FFB76EFD8679D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::RewindNamed(System.String)");
	_il2cpp_icall_func(__this, ___name0);
}
// System.Void UnityEngine.Animation::Sample()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Sample_mC2F1CF215D835404E205F52DD8096B74EEE3E9A1 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef void (*Animation_Sample_mC2F1CF215D835404E205F52DD8096B74EEE3E9A1_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_Sample_mC2F1CF215D835404E205F52DD8096B74EEE3E9A1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_Sample_mC2F1CF215D835404E205F52DD8096B74EEE3E9A1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::Sample()");
	_il2cpp_icall_func(__this);
}
// System.Boolean UnityEngine.Animation::get_isPlaying()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_get_isPlaying_m71AF60BE632978C6449B57D0AFA59CBF9A3F0705 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animation_get_isPlaying_m71AF60BE632978C6449B57D0AFA59CBF9A3F0705_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_get_isPlaying_m71AF60BE632978C6449B57D0AFA59CBF9A3F0705_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_get_isPlaying_m71AF60BE632978C6449B57D0AFA59CBF9A3F0705_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::get_isPlaying()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animation::IsPlaying(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_IsPlaying_mD156265199E5875D1DFABCF82819BC4735E34887 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef bool (*Animation_IsPlaying_mD156265199E5875D1DFABCF82819BC4735E34887_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*);
	static Animation_IsPlaying_mD156265199E5875D1DFABCF82819BC4735E34887_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_IsPlaying_mD156265199E5875D1DFABCF82819BC4735E34887_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::IsPlaying(System.String)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___name0);
	return icallRetVal;
}
// UnityEngine.AnimationState UnityEngine.Animation::get_Item(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_get_Item_m1A6478937F31595F94BFE95141C8FEF0D90CA932 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * V_0 = NULL;
	{
		String_t* L_0 = ___name0;
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_1;
		L_1 = Animation_GetState_mE120497EC77651CF72D9406EBF8E221BCB0C2CA6(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animation::Play()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_m5588607899B9B866117A1477C696076F161BA3D4 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		bool L_0;
		L_0 = Animation_Play_mE768E71A80625EBCE4577FA5F82E2A6E6FE4F9F8(__this, 0, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000b;
	}

IL_000b:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
// System.Boolean UnityEngine.Animation::Play(UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_mE768E71A80625EBCE4577FA5F82E2A6E6FE4F9F8 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___mode0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0 = ___mode0;
		bool L_1;
		L_1 = Animation_PlayDefaultAnimation_mF95A24563D8A4517F75A8149D0961C2024DE8DAB(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animation::PlayDefaultAnimation(UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_PlayDefaultAnimation_mF95A24563D8A4517F75A8149D0961C2024DE8DAB (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___mode0, const RuntimeMethod* method)
{
	typedef bool (*Animation_PlayDefaultAnimation_mF95A24563D8A4517F75A8149D0961C2024DE8DAB_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, int32_t);
	static Animation_PlayDefaultAnimation_mF95A24563D8A4517F75A8149D0961C2024DE8DAB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_PlayDefaultAnimation_mF95A24563D8A4517F75A8149D0961C2024DE8DAB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::PlayDefaultAnimation(UnityEngine.PlayMode)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___mode0);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animation::Play(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_m8EDFE80589A27DF1C34CCC0CF81DB5313CE35607 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		String_t* L_0 = ___animation0;
		bool L_1;
		L_1 = Animation_Play_m8F742F537EA22D32B109BB0B57F54315BA2182A1(__this, L_0, 0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animation::Play(System.String,UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_m8F742F537EA22D32B109BB0B57F54315BA2182A1 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, int32_t ___mode1, const RuntimeMethod* method)
{
	typedef bool (*Animation_Play_m8F742F537EA22D32B109BB0B57F54315BA2182A1_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*, int32_t);
	static Animation_Play_m8F742F537EA22D32B109BB0B57F54315BA2182A1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_Play_m8F742F537EA22D32B109BB0B57F54315BA2182A1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::Play(System.String,UnityEngine.PlayMode)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___animation0, ___mode1);
	return icallRetVal;
}
// System.Void UnityEngine.Animation::CrossFade(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_CrossFade_mAA2C1F467BCFF4AFF6B06D041BA98A9CBD57352B (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___animation0;
		Animation_CrossFade_m7D83F71B3DCF3D5F8995389669800718C988FA1A(__this, L_0, (0.300000012f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::CrossFade(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_CrossFade_m7D83F71B3DCF3D5F8995389669800718C988FA1A (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___animation0;
		float L_1 = ___fadeLength1;
		Animation_CrossFade_m3FA2A5C413E36D5463FEDDFFD87582867F2ED65E(__this, L_0, L_1, 0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::CrossFade(System.String,System.Single,UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_CrossFade_m3FA2A5C413E36D5463FEDDFFD87582867F2ED65E (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, int32_t ___mode2, const RuntimeMethod* method)
{
	typedef void (*Animation_CrossFade_m3FA2A5C413E36D5463FEDDFFD87582867F2ED65E_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*, float, int32_t);
	static Animation_CrossFade_m3FA2A5C413E36D5463FEDDFFD87582867F2ED65E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_CrossFade_m3FA2A5C413E36D5463FEDDFFD87582867F2ED65E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::CrossFade(System.String,System.Single,UnityEngine.PlayMode)");
	_il2cpp_icall_func(__this, ___animation0, ___fadeLength1, ___mode2);
}
// System.Void UnityEngine.Animation::Blend(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Blend_m5F8E8C98266A608E5E492013F9278C6C03D17F3F (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___animation0;
		Animation_Blend_mCFF0F9FA59C58DE151C122401F9ECFB1C60F5871(__this, L_0, (1.0f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::Blend(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Blend_mCFF0F9FA59C58DE151C122401F9ECFB1C60F5871 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___targetWeight1, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___animation0;
		float L_1 = ___targetWeight1;
		Animation_Blend_m339C51493052B179F994DDD4C4F15A8AD10ED273(__this, L_0, L_1, (0.300000012f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::Blend(System.String,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_Blend_m339C51493052B179F994DDD4C4F15A8AD10ED273 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___targetWeight1, float ___fadeLength2, const RuntimeMethod* method)
{
	typedef void (*Animation_Blend_m339C51493052B179F994DDD4C4F15A8AD10ED273_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*, float, float);
	static Animation_Blend_m339C51493052B179F994DDD4C4F15A8AD10ED273_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_Blend_m339C51493052B179F994DDD4C4F15A8AD10ED273_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::Blend(System.String,System.Single,System.Single)");
	_il2cpp_icall_func(__this, ___animation0, ___targetWeight1, ___fadeLength2);
}
// UnityEngine.AnimationState UnityEngine.Animation::CrossFadeQueued(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_CrossFadeQueued_m79D870F8BD8CDFE1DC2D820FFCE580EB92A5E61F (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, const RuntimeMethod* method)
{
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * V_0 = NULL;
	{
		String_t* L_0 = ___animation0;
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_1;
		L_1 = Animation_CrossFadeQueued_mB89BA9FFE43A1F2091B8E53CD4D4941E46917AF2(__this, L_0, (0.300000012f), /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.AnimationState UnityEngine.Animation::CrossFadeQueued(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_CrossFadeQueued_mB89BA9FFE43A1F2091B8E53CD4D4941E46917AF2 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, const RuntimeMethod* method)
{
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * V_0 = NULL;
	{
		String_t* L_0 = ___animation0;
		float L_1 = ___fadeLength1;
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_2;
		L_2 = Animation_CrossFadeQueued_mA1604285B9C955AEE75E1EE4A94F90AE4EF1A71F(__this, L_0, L_1, 0, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000d;
	}

IL_000d:
	{
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.AnimationState UnityEngine.Animation::CrossFadeQueued(System.String,System.Single,UnityEngine.QueueMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_CrossFadeQueued_mA1604285B9C955AEE75E1EE4A94F90AE4EF1A71F (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, int32_t ___queue2, const RuntimeMethod* method)
{
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * V_0 = NULL;
	{
		String_t* L_0 = ___animation0;
		float L_1 = ___fadeLength1;
		int32_t L_2 = ___queue2;
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_3;
		L_3 = Animation_CrossFadeQueued_mA0B038DDBA8F38A1BE1991A5F316B5C831B26DF3(__this, L_0, L_1, L_2, 0, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_000e;
	}

IL_000e:
	{
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_4 = V_0;
		return L_4;
	}
}
// UnityEngine.AnimationState UnityEngine.Animation::CrossFadeQueued(System.String,System.Single,UnityEngine.QueueMode,UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_CrossFadeQueued_mA0B038DDBA8F38A1BE1991A5F316B5C831B26DF3 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, float ___fadeLength1, int32_t ___queue2, int32_t ___mode3, const RuntimeMethod* method)
{
	typedef AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * (*Animation_CrossFadeQueued_mA0B038DDBA8F38A1BE1991A5F316B5C831B26DF3_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*, float, int32_t, int32_t);
	static Animation_CrossFadeQueued_mA0B038DDBA8F38A1BE1991A5F316B5C831B26DF3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_CrossFadeQueued_mA0B038DDBA8F38A1BE1991A5F316B5C831B26DF3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::CrossFadeQueued(System.String,System.Single,UnityEngine.QueueMode,UnityEngine.PlayMode)");
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * icallRetVal = _il2cpp_icall_func(__this, ___animation0, ___fadeLength1, ___queue2, ___mode3);
	return icallRetVal;
}
// UnityEngine.AnimationState UnityEngine.Animation::PlayQueued(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_PlayQueued_m1DD28BEE3D42E105A20CC263EFE9DF6A131C5F7D (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, const RuntimeMethod* method)
{
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * V_0 = NULL;
	{
		String_t* L_0 = ___animation0;
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_1;
		L_1 = Animation_PlayQueued_m8050313AC40A1749FE30F5671705B1F7B5A40CBD(__this, L_0, 0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.AnimationState UnityEngine.Animation::PlayQueued(System.String,UnityEngine.QueueMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_PlayQueued_m8050313AC40A1749FE30F5671705B1F7B5A40CBD (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, int32_t ___queue1, const RuntimeMethod* method)
{
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * V_0 = NULL;
	{
		String_t* L_0 = ___animation0;
		int32_t L_1 = ___queue1;
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_2;
		L_2 = Animation_PlayQueued_mA9D4C771AF24C3F0727AAD594F802D5D9C44F652(__this, L_0, L_1, 0, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000d;
	}

IL_000d:
	{
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.AnimationState UnityEngine.Animation::PlayQueued(System.String,UnityEngine.QueueMode,UnityEngine.PlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_PlayQueued_mA9D4C771AF24C3F0727AAD594F802D5D9C44F652 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, int32_t ___queue1, int32_t ___mode2, const RuntimeMethod* method)
{
	typedef AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * (*Animation_PlayQueued_mA9D4C771AF24C3F0727AAD594F802D5D9C44F652_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*, int32_t, int32_t);
	static Animation_PlayQueued_mA9D4C771AF24C3F0727AAD594F802D5D9C44F652_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_PlayQueued_mA9D4C771AF24C3F0727AAD594F802D5D9C44F652_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::PlayQueued(System.String,UnityEngine.QueueMode,UnityEngine.PlayMode)");
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * icallRetVal = _il2cpp_icall_func(__this, ___animation0, ___queue1, ___mode2);
	return icallRetVal;
}
// System.Void UnityEngine.Animation::AddClip(UnityEngine.AnimationClip,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_AddClip_m5193765EE51878BE0045540619AA04084E3BBF4B (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___clip0, String_t* ___newName1, const RuntimeMethod* method)
{
	{
		AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * L_0 = ___clip0;
		String_t* L_1 = ___newName1;
		Animation_AddClip_mEA5ED66A0C43400FC7A777BB132E024A172BC25B(__this, L_0, L_1, ((int32_t)-2147483648LL), ((int32_t)2147483647LL), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::AddClip(UnityEngine.AnimationClip,System.String,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_AddClip_mEA5ED66A0C43400FC7A777BB132E024A172BC25B (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___clip0, String_t* ___newName1, int32_t ___firstFrame2, int32_t ___lastFrame3, const RuntimeMethod* method)
{
	{
		AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * L_0 = ___clip0;
		String_t* L_1 = ___newName1;
		int32_t L_2 = ___firstFrame2;
		int32_t L_3 = ___lastFrame3;
		Animation_AddClip_m742D71B7A7C097BF4FD0A0329677B875320498F5(__this, L_0, L_1, L_2, L_3, (bool)0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::AddClip(UnityEngine.AnimationClip,System.String,System.Int32,System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_AddClip_m742D71B7A7C097BF4FD0A0329677B875320498F5 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___clip0, String_t* ___newName1, int32_t ___firstFrame2, int32_t ___lastFrame3, bool ___addLoopFrame4, const RuntimeMethod* method)
{
	typedef void (*Animation_AddClip_m742D71B7A7C097BF4FD0A0329677B875320498F5_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, String_t*, int32_t, int32_t, bool);
	static Animation_AddClip_m742D71B7A7C097BF4FD0A0329677B875320498F5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_AddClip_m742D71B7A7C097BF4FD0A0329677B875320498F5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::AddClip(UnityEngine.AnimationClip,System.String,System.Int32,System.Int32,System.Boolean)");
	_il2cpp_icall_func(__this, ___clip0, ___newName1, ___firstFrame2, ___lastFrame3, ___addLoopFrame4);
}
// System.Void UnityEngine.Animation::RemoveClip(UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_RemoveClip_mEE9A56A1D5963D71862E6BCDC65F6841636D943A (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___clip0, const RuntimeMethod* method)
{
	typedef void (*Animation_RemoveClip_mEE9A56A1D5963D71862E6BCDC65F6841636D943A_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static Animation_RemoveClip_mEE9A56A1D5963D71862E6BCDC65F6841636D943A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_RemoveClip_mEE9A56A1D5963D71862E6BCDC65F6841636D943A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::RemoveClip(UnityEngine.AnimationClip)");
	_il2cpp_icall_func(__this, ___clip0);
}
// System.Void UnityEngine.Animation::RemoveClip(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_RemoveClip_mB3FAE9DFAF4B80D12E7F746B50EC19502D8F451B (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___clipName0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___clipName0;
		Animation_RemoveClipNamed_m1DB64EC40379073AB780F8E90211A8A76F8B8B2E(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::RemoveClipNamed(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_RemoveClipNamed_m1DB64EC40379073AB780F8E90211A8A76F8B8B2E (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___clipName0, const RuntimeMethod* method)
{
	typedef void (*Animation_RemoveClipNamed_m1DB64EC40379073AB780F8E90211A8A76F8B8B2E_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*);
	static Animation_RemoveClipNamed_m1DB64EC40379073AB780F8E90211A8A76F8B8B2E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_RemoveClipNamed_m1DB64EC40379073AB780F8E90211A8A76F8B8B2E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::RemoveClipNamed(System.String)");
	_il2cpp_icall_func(__this, ___clipName0);
}
// System.Int32 UnityEngine.Animation::GetClipCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animation_GetClipCount_m7F02B7ADF7FC64A7BC1A9D35F9B95739D3682E08 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animation_GetClipCount_m7F02B7ADF7FC64A7BC1A9D35F9B95739D3682E08_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_GetClipCount_m7F02B7ADF7FC64A7BC1A9D35F9B95739D3682E08_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_GetClipCount_m7F02B7ADF7FC64A7BC1A9D35F9B95739D3682E08_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::GetClipCount()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animation::Play(UnityEngine.AnimationPlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_mD0CE9373C350E615DFB377E555FDDAC388CBD4DB (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___mode0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0 = ___mode0;
		bool L_1;
		L_1 = Animation_PlayDefaultAnimation_mF95A24563D8A4517F75A8149D0961C2024DE8DAB(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animation::Play(System.String,UnityEngine.AnimationPlayMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_Play_m3BE06FCEF14558E606AAC8F28928AD73FA05FFE8 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___animation0, int32_t ___mode1, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		String_t* L_0 = ___animation0;
		int32_t L_1 = ___mode1;
		bool L_2;
		L_2 = Animation_Play_m8F742F537EA22D32B109BB0B57F54315BA2182A1(__this, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000c;
	}

IL_000c:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
// System.Void UnityEngine.Animation::SyncLayer(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_SyncLayer_m0032256A478957580E94C09F3B7109298B272BC8 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___layer0, const RuntimeMethod* method)
{
	typedef void (*Animation_SyncLayer_m0032256A478957580E94C09F3B7109298B272BC8_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, int32_t);
	static Animation_SyncLayer_m0032256A478957580E94C09F3B7109298B272BC8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_SyncLayer_m0032256A478957580E94C09F3B7109298B272BC8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::SyncLayer(System.Int32)");
	_il2cpp_icall_func(__this, ___layer0);
}
// System.Collections.IEnumerator UnityEngine.Animation::GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Animation_GetEnumerator_m7F0049CCE49D9F5963AFB5552CDEAD51793891F7 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	{
		Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5 * L_0 = (Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5 *)il2cpp_codegen_object_new(Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5_il2cpp_TypeInfo_var);
		Enumerator__ctor_mC97A2B142004D7B757AAF61F6F069FB102372DBA(L_0, __this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		RuntimeObject* L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.AnimationState UnityEngine.Animation::GetState(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_GetState_mE120497EC77651CF72D9406EBF8E221BCB0C2CA6 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * (*Animation_GetState_mE120497EC77651CF72D9406EBF8E221BCB0C2CA6_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, String_t*);
	static Animation_GetState_mE120497EC77651CF72D9406EBF8E221BCB0C2CA6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_GetState_mE120497EC77651CF72D9406EBF8E221BCB0C2CA6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::GetState(System.String)");
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * icallRetVal = _il2cpp_icall_func(__this, ___name0);
	return icallRetVal;
}
// UnityEngine.AnimationState UnityEngine.Animation::GetStateAtIndex(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * Animation_GetStateAtIndex_m436707B278555E5B3AD4FB8F7B1A04F532CDC679 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	typedef AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * (*Animation_GetStateAtIndex_m436707B278555E5B3AD4FB8F7B1A04F532CDC679_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, int32_t);
	static Animation_GetStateAtIndex_m436707B278555E5B3AD4FB8F7B1A04F532CDC679_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_GetStateAtIndex_m436707B278555E5B3AD4FB8F7B1A04F532CDC679_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::GetStateAtIndex(System.Int32)");
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * icallRetVal = _il2cpp_icall_func(__this, ___index0);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animation::GetStateCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animation_GetStateCount_mBFB004C6182E7243A2DFA09D7E378A94AC61AABA (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animation_GetStateCount_mBFB004C6182E7243A2DFA09D7E378A94AC61AABA_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_GetStateCount_mBFB004C6182E7243A2DFA09D7E378A94AC61AABA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_GetStateCount_mBFB004C6182E7243A2DFA09D7E378A94AC61AABA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::GetStateCount()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.AnimationClip UnityEngine.Animation::GetClip(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * Animation_GetClip_m8D59FF4F59C2363DC4D3E087562A0DA606E161D5 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * V_0 = NULL;
	bool V_1 = false;
	AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * V_2 = NULL;
	{
		String_t* L_0 = ___name0;
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_1;
		L_1 = Animation_GetState_mE120497EC77651CF72D9406EBF8E221BCB0C2CA6(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_2 = V_0;
		bool L_3;
		L_3 = TrackedReference_op_Implicit_mDE5D31DEF5AB0B49315E6FD2F039DC63653D077D(L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_001c;
		}
	}
	{
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_5 = V_0;
		NullCheck(L_5);
		AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * L_6;
		L_6 = AnimationState_get_clip_m84FD95AFB1FDC356E53AA6F44089F69B353B42BB(L_5, /*hidden argument*/NULL);
		V_2 = L_6;
		goto IL_0020;
	}

IL_001c:
	{
		V_2 = (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *)NULL;
		goto IL_0020;
	}

IL_0020:
	{
		AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * L_7 = V_2;
		return L_7;
	}
}
// System.Boolean UnityEngine.Animation::get_animatePhysics()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_get_animatePhysics_m4260C89C49FB56DE5D4BAEAE0845FA217BD60C6C (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animation_get_animatePhysics_m4260C89C49FB56DE5D4BAEAE0845FA217BD60C6C_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_get_animatePhysics_m4260C89C49FB56DE5D4BAEAE0845FA217BD60C6C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_get_animatePhysics_m4260C89C49FB56DE5D4BAEAE0845FA217BD60C6C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::get_animatePhysics()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animation::set_animatePhysics(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_animatePhysics_m9653F6928D186F4C72B5BC661156E21988E29926 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animation_set_animatePhysics_m9653F6928D186F4C72B5BC661156E21988E29926_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, bool);
	static Animation_set_animatePhysics_m9653F6928D186F4C72B5BC661156E21988E29926_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_set_animatePhysics_m9653F6928D186F4C72B5BC661156E21988E29926_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::set_animatePhysics(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Animation::get_animateOnlyIfVisible()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animation_get_animateOnlyIfVisible_mB284A89084FC405F8821894D3131D97B7A05D6B3 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animation_get_animateOnlyIfVisible_mB284A89084FC405F8821894D3131D97B7A05D6B3_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_get_animateOnlyIfVisible_mB284A89084FC405F8821894D3131D97B7A05D6B3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_get_animateOnlyIfVisible_mB284A89084FC405F8821894D3131D97B7A05D6B3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::get_animateOnlyIfVisible()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animation::set_animateOnlyIfVisible(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_animateOnlyIfVisible_mF3AE7C7EE97D0DEEC82C33BE8280211F8390D49A (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animation_set_animateOnlyIfVisible_mF3AE7C7EE97D0DEEC82C33BE8280211F8390D49A_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, bool);
	static Animation_set_animateOnlyIfVisible_mF3AE7C7EE97D0DEEC82C33BE8280211F8390D49A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_set_animateOnlyIfVisible_mF3AE7C7EE97D0DEEC82C33BE8280211F8390D49A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::set_animateOnlyIfVisible(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.AnimationCullingType UnityEngine.Animation::get_cullingType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animation_get_cullingType_mF66F4FD19E735710E92DB364B4C1A0DC44ECAB25 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animation_get_cullingType_mF66F4FD19E735710E92DB364B4C1A0DC44ECAB25_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *);
	static Animation_get_cullingType_mF66F4FD19E735710E92DB364B4C1A0DC44ECAB25_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_get_cullingType_mF66F4FD19E735710E92DB364B4C1A0DC44ECAB25_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::get_cullingType()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animation::set_cullingType(UnityEngine.AnimationCullingType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_cullingType_m65032F770648FA34658DAE194947173110CBAD08 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*Animation_set_cullingType_m65032F770648FA34658DAE194947173110CBAD08_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, int32_t);
	static Animation_set_cullingType_m65032F770648FA34658DAE194947173110CBAD08_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_set_cullingType_m65032F770648FA34658DAE194947173110CBAD08_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::set_cullingType(UnityEngine.AnimationCullingType)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Bounds UnityEngine.Animation::get_localBounds()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  Animation_get_localBounds_m0CA4AD020C3D65E720580057B7A511C597B92CCC (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animation_get_localBounds_Injected_m5E0E63FDDEC0B0F7B5C51B7A854E0CD127B82C4C(__this, (Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *)(&V_0), /*hidden argument*/NULL);
		Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.Animation::set_localBounds(UnityEngine.Bounds)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_localBounds_m57726D7289692ADF0E6A43F9FDFA4FF54771E21B (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  ___value0, const RuntimeMethod* method)
{
	{
		Animation_set_localBounds_Injected_m30737F4AD048A9BCBD605CB50FDA61A8EEF66195(__this, (Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation__ctor_m1841EF3605931DBBF89AFD09439CECC5AF0089F7 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, const RuntimeMethod* method)
{
	{
		Behaviour__ctor_mCACD3614226521EA607B0F3640C0FAC7EACCBCE0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animation::get_localBounds_Injected(UnityEngine.Bounds&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_get_localBounds_Injected_m5E0E63FDDEC0B0F7B5C51B7A854E0CD127B82C4C (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animation_get_localBounds_Injected_m5E0E63FDDEC0B0F7B5C51B7A854E0CD127B82C4C_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *);
	static Animation_get_localBounds_Injected_m5E0E63FDDEC0B0F7B5C51B7A854E0CD127B82C4C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_get_localBounds_Injected_m5E0E63FDDEC0B0F7B5C51B7A854E0CD127B82C4C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::get_localBounds_Injected(UnityEngine.Bounds&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animation::set_localBounds_Injected(UnityEngine.Bounds&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animation_set_localBounds_Injected_m30737F4AD048A9BCBD605CB50FDA61A8EEF66195 (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Animation_set_localBounds_Injected_m30737F4AD048A9BCBD605CB50FDA61A8EEF66195_ftn) (Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 *, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *);
	static Animation_set_localBounds_Injected_m30737F4AD048A9BCBD605CB50FDA61A8EEF66195_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animation_set_localBounds_Injected_m30737F4AD048A9BCBD605CB50FDA61A8EEF66195_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animation::set_localBounds_Injected(UnityEngine.Bounds&)");
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
// System.Void UnityEngine.AnimationClip::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip__ctor_m1678D7A0D58F768C92690BABB01DBDE64F12D09E (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	{
		Motion__ctor_mDC0BDF6F52E99C4A69EFDAC157CC29D0C1A4F9E6(__this, /*hidden argument*/NULL);
		AnimationClip_Internal_CreateAnimationClip_mA9F511FF346799F0F2672D64998CD38D7CB2E168(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AnimationClip::Internal_CreateAnimationClip(UnityEngine.AnimationClip)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_Internal_CreateAnimationClip_mA9F511FF346799F0F2672D64998CD38D7CB2E168 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___self0, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_Internal_CreateAnimationClip_mA9F511FF346799F0F2672D64998CD38D7CB2E168_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_Internal_CreateAnimationClip_mA9F511FF346799F0F2672D64998CD38D7CB2E168_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_Internal_CreateAnimationClip_mA9F511FF346799F0F2672D64998CD38D7CB2E168_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::Internal_CreateAnimationClip(UnityEngine.AnimationClip)");
	_il2cpp_icall_func(___self0);
}
// System.Void UnityEngine.AnimationClip::SampleAnimation(UnityEngine.GameObject,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_SampleAnimation_mAE6FB426F2CC5ECC4AF43F4DA060DEF3EDC33852 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___go0, float ___time1, const RuntimeMethod* method)
{
	{
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_0 = ___go0;
		float L_1 = ___time1;
		int32_t L_2;
		L_2 = AnimationClip_get_wrapMode_mC16973C5A6B4DEFBDE1DA84AA3BA96067B965A0E(__this, /*hidden argument*/NULL);
		AnimationClip_SampleAnimation_m4C7B0F20B3E375B0FA68B8DF0B42BC67E3287ED8(L_0, __this, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AnimationClip::SampleAnimation(UnityEngine.GameObject,UnityEngine.AnimationClip,System.Single,UnityEngine.WrapMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_SampleAnimation_m4C7B0F20B3E375B0FA68B8DF0B42BC67E3287ED8 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * ___go0, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * ___clip1, float ___inTime2, int32_t ___wrapMode3, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_SampleAnimation_m4C7B0F20B3E375B0FA68B8DF0B42BC67E3287ED8_ftn) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, float, int32_t);
	static AnimationClip_SampleAnimation_m4C7B0F20B3E375B0FA68B8DF0B42BC67E3287ED8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_SampleAnimation_m4C7B0F20B3E375B0FA68B8DF0B42BC67E3287ED8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::SampleAnimation(UnityEngine.GameObject,UnityEngine.AnimationClip,System.Single,UnityEngine.WrapMode)");
	_il2cpp_icall_func(___go0, ___clip1, ___inTime2, ___wrapMode3);
}
// System.Single UnityEngine.AnimationClip::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationClip_get_length_m7917C4C333DD8083A5395581652C227E0CECC82B (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef float (*AnimationClip_get_length_m7917C4C333DD8083A5395581652C227E0CECC82B_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_length_m7917C4C333DD8083A5395581652C227E0CECC82B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_length_m7917C4C333DD8083A5395581652C227E0CECC82B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_length()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.AnimationClip::get_startTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationClip_get_startTime_mEA2E693F033D77E26F8950AC19FA00A5596C3E1B (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef float (*AnimationClip_get_startTime_mEA2E693F033D77E26F8950AC19FA00A5596C3E1B_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_startTime_mEA2E693F033D77E26F8950AC19FA00A5596C3E1B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_startTime_mEA2E693F033D77E26F8950AC19FA00A5596C3E1B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_startTime()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.AnimationClip::get_stopTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationClip_get_stopTime_mD9CF36AC8CA8EB96BF996AC13BE47A999262CB90 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef float (*AnimationClip_get_stopTime_mD9CF36AC8CA8EB96BF996AC13BE47A999262CB90_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_stopTime_mD9CF36AC8CA8EB96BF996AC13BE47A999262CB90_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_stopTime_mD9CF36AC8CA8EB96BF996AC13BE47A999262CB90_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_stopTime()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.AnimationClip::get_frameRate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimationClip_get_frameRate_mCC11724CA29880EE9659FD07520896FF76F0C950 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef float (*AnimationClip_get_frameRate_mCC11724CA29880EE9659FD07520896FF76F0C950_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_frameRate_mCC11724CA29880EE9659FD07520896FF76F0C950_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_frameRate_mCC11724CA29880EE9659FD07520896FF76F0C950_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_frameRate()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.AnimationClip::set_frameRate(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_frameRate_mD0329B67F782D6CA95C21A9455CE6F1B2C391E03 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_set_frameRate_mD0329B67F782D6CA95C21A9455CE6F1B2C391E03_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, float);
	static AnimationClip_set_frameRate_mD0329B67F782D6CA95C21A9455CE6F1B2C391E03_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_set_frameRate_mD0329B67F782D6CA95C21A9455CE6F1B2C391E03_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::set_frameRate(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.AnimationClip::SetCurve(System.String,System.Type,System.String,UnityEngine.AnimationCurve)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_SetCurve_m096231512BCEB532ADF51107E8E748318E5CAE68 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, String_t* ___relativePath0, Type_t * ___type1, String_t* ___propertyName2, AnimationCurve_t2D452A14820CEDB83BFF2C911682A4E59001AD03 * ___curve3, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_SetCurve_m096231512BCEB532ADF51107E8E748318E5CAE68_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, String_t*, Type_t *, String_t*, AnimationCurve_t2D452A14820CEDB83BFF2C911682A4E59001AD03 *);
	static AnimationClip_SetCurve_m096231512BCEB532ADF51107E8E748318E5CAE68_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_SetCurve_m096231512BCEB532ADF51107E8E748318E5CAE68_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::SetCurve(System.String,System.Type,System.String,UnityEngine.AnimationCurve)");
	_il2cpp_icall_func(__this, ___relativePath0, ___type1, ___propertyName2, ___curve3);
}
// System.Void UnityEngine.AnimationClip::EnsureQuaternionContinuity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_EnsureQuaternionContinuity_mAA694326CADE3EA9B20562301B41A2C31898B078 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_EnsureQuaternionContinuity_mAA694326CADE3EA9B20562301B41A2C31898B078_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_EnsureQuaternionContinuity_mAA694326CADE3EA9B20562301B41A2C31898B078_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_EnsureQuaternionContinuity_mAA694326CADE3EA9B20562301B41A2C31898B078_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::EnsureQuaternionContinuity()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.AnimationClip::ClearCurves()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_ClearCurves_m692D06AB61165077A9E6BE260EF5717CABD903CA (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_ClearCurves_m692D06AB61165077A9E6BE260EF5717CABD903CA_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_ClearCurves_m692D06AB61165077A9E6BE260EF5717CABD903CA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_ClearCurves_m692D06AB61165077A9E6BE260EF5717CABD903CA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::ClearCurves()");
	_il2cpp_icall_func(__this);
}
// UnityEngine.WrapMode UnityEngine.AnimationClip::get_wrapMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimationClip_get_wrapMode_mC16973C5A6B4DEFBDE1DA84AA3BA96067B965A0E (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*AnimationClip_get_wrapMode_mC16973C5A6B4DEFBDE1DA84AA3BA96067B965A0E_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_wrapMode_mC16973C5A6B4DEFBDE1DA84AA3BA96067B965A0E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_wrapMode_mC16973C5A6B4DEFBDE1DA84AA3BA96067B965A0E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_wrapMode()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.AnimationClip::set_wrapMode(UnityEngine.WrapMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_wrapMode_m22EAB1A40AAA6A2CE2C5AD6BA3CAB85EFFF2C4DF (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_set_wrapMode_m22EAB1A40AAA6A2CE2C5AD6BA3CAB85EFFF2C4DF_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, int32_t);
	static AnimationClip_set_wrapMode_m22EAB1A40AAA6A2CE2C5AD6BA3CAB85EFFF2C4DF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_set_wrapMode_m22EAB1A40AAA6A2CE2C5AD6BA3CAB85EFFF2C4DF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::set_wrapMode(UnityEngine.WrapMode)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Bounds UnityEngine.AnimationClip::get_localBounds()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  AnimationClip_get_localBounds_m496EB4AC1643B3D06132BE952BEA808425FD0C4B (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		AnimationClip_get_localBounds_Injected_m5B95A86FEBB219110EEA104809880830423231B2(__this, (Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *)(&V_0), /*hidden argument*/NULL);
		Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.AnimationClip::set_localBounds(UnityEngine.Bounds)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_localBounds_m64AFF5B70E1F83CC684DDE55EFB29E9EF292E41B (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37  ___value0, const RuntimeMethod* method)
{
	{
		AnimationClip_set_localBounds_Injected_m4B78ABE1CC5A3C7485295EBBEAF25987A98689BE(__this, (Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.AnimationClip::get_legacy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_legacy_mCA817A75C0DA2EC33EF8ED2572DAD8308F3E9AC4 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef bool (*AnimationClip_get_legacy_mCA817A75C0DA2EC33EF8ED2572DAD8308F3E9AC4_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_legacy_mCA817A75C0DA2EC33EF8ED2572DAD8308F3E9AC4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_legacy_mCA817A75C0DA2EC33EF8ED2572DAD8308F3E9AC4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_legacy()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.AnimationClip::set_legacy(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_legacy_m350699605A47D4D7D2EAF4B6B864405681273CA3 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_set_legacy_m350699605A47D4D7D2EAF4B6B864405681273CA3_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, bool);
	static AnimationClip_set_legacy_m350699605A47D4D7D2EAF4B6B864405681273CA3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_set_legacy_m350699605A47D4D7D2EAF4B6B864405681273CA3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::set_legacy(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.AnimationClip::get_humanMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_humanMotion_m1A1BFAE1A0B705F4EF731E03294D7CBDDA17BC4B (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef bool (*AnimationClip_get_humanMotion_m1A1BFAE1A0B705F4EF731E03294D7CBDDA17BC4B_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_humanMotion_m1A1BFAE1A0B705F4EF731E03294D7CBDDA17BC4B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_humanMotion_m1A1BFAE1A0B705F4EF731E03294D7CBDDA17BC4B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_humanMotion()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_empty()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_empty_m4579156FCC5C3958D879A088C9A73BBF8EE527CB (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef bool (*AnimationClip_get_empty_m4579156FCC5C3958D879A088C9A73BBF8EE527CB_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_empty_m4579156FCC5C3958D879A088C9A73BBF8EE527CB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_empty_m4579156FCC5C3958D879A088C9A73BBF8EE527CB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_empty()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasGenericRootTransform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasGenericRootTransform_m2E86B853D6F46942691845264A6E33CA0440F85F (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef bool (*AnimationClip_get_hasGenericRootTransform_m2E86B853D6F46942691845264A6E33CA0440F85F_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_hasGenericRootTransform_m2E86B853D6F46942691845264A6E33CA0440F85F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasGenericRootTransform_m2E86B853D6F46942691845264A6E33CA0440F85F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasGenericRootTransform()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasMotionFloatCurves()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasMotionFloatCurves_mC746E53475CBDA8E508391F2A475C2E8AC263AD6 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef bool (*AnimationClip_get_hasMotionFloatCurves_mC746E53475CBDA8E508391F2A475C2E8AC263AD6_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_hasMotionFloatCurves_mC746E53475CBDA8E508391F2A475C2E8AC263AD6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasMotionFloatCurves_mC746E53475CBDA8E508391F2A475C2E8AC263AD6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasMotionFloatCurves()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasMotionCurves()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasMotionCurves_m4E568486AC2D02F0E2CED7A02F251FAAEE6E54F3 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef bool (*AnimationClip_get_hasMotionCurves_m4E568486AC2D02F0E2CED7A02F251FAAEE6E54F3_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_hasMotionCurves_m4E568486AC2D02F0E2CED7A02F251FAAEE6E54F3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasMotionCurves_m4E568486AC2D02F0E2CED7A02F251FAAEE6E54F3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasMotionCurves()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasRootCurves()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasRootCurves_mF03EAEC6D37C882C8A5BA2E8ECF7A48B643EE524 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef bool (*AnimationClip_get_hasRootCurves_mF03EAEC6D37C882C8A5BA2E8ECF7A48B643EE524_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_hasRootCurves_mF03EAEC6D37C882C8A5BA2E8ECF7A48B643EE524_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasRootCurves_mF03EAEC6D37C882C8A5BA2E8ECF7A48B643EE524_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasRootCurves()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.AnimationClip::get_hasRootMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClip_get_hasRootMotion_m18C17AAF4B0EB862BE3F1D0B32B61B362564BFDF (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef bool (*AnimationClip_get_hasRootMotion_m18C17AAF4B0EB862BE3F1D0B32B61B362564BFDF_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_get_hasRootMotion_m18C17AAF4B0EB862BE3F1D0B32B61B362564BFDF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_hasRootMotion_m18C17AAF4B0EB862BE3F1D0B32B61B362564BFDF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_hasRootMotion()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.AnimationClip::AddEvent(UnityEngine.AnimationEvent)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_AddEvent_mF9B1C0BB15F539AED479F2DBD9FCAAF70CDC1C16 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * ___evt0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * L_0 = ___evt0;
		V_0 = (bool)((((RuntimeObject*)(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB * L_2 = (ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m81AB157B93BFE2FBFDB08B88F84B444293042F97(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralE7306902767BBF9821FC01DF5423B33158A3F6ED)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationClip_AddEvent_mF9B1C0BB15F539AED479F2DBD9FCAAF70CDC1C16_RuntimeMethod_var)));
	}

IL_0014:
	{
		AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * L_3 = ___evt0;
		AnimationClip_AddEventInternal_m38EF420E8042297AB276AA4D92FA5531F9F6D273(__this, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AnimationClip::AddEventInternal(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_AddEventInternal_m38EF420E8042297AB276AA4D92FA5531F9F6D273 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, RuntimeObject * ___evt0, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_AddEventInternal_m38EF420E8042297AB276AA4D92FA5531F9F6D273_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, RuntimeObject *);
	static AnimationClip_AddEventInternal_m38EF420E8042297AB276AA4D92FA5531F9F6D273_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_AddEventInternal_m38EF420E8042297AB276AA4D92FA5531F9F6D273_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::AddEventInternal(System.Object)");
	_il2cpp_icall_func(__this, ___evt0);
}
// UnityEngine.AnimationEvent[] UnityEngine.AnimationClip::get_events()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA* AnimationClip_get_events_mA7E93578796F3C2CC56AB2D2CEC680492C279996 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA* V_0 = NULL;
	{
		RuntimeArray * L_0;
		L_0 = AnimationClip_GetEventsInternal_m9A7D3DD46EA3C7F7B935623D3C7640414CF338D8(__this, /*hidden argument*/NULL);
		V_0 = ((AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA*)Castclass((RuntimeObject*)L_0, AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA_il2cpp_TypeInfo_var));
		goto IL_000f;
	}

IL_000f:
	{
		AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA* L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.AnimationClip::set_events(UnityEngine.AnimationEvent[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_events_m72A14EEE080A7F3C9A135237009954A90F926245 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA* ___value0, const RuntimeMethod* method)
{
	{
		AnimationEventU5BU5D_t1996EDB1BBBA4BB0DC0BE90A91C116CB848360AA* L_0 = ___value0;
		AnimationClip_SetEventsInternal_m7A1129D019A40C7FD09B5D1C721002268AFD2878(__this, (RuntimeArray *)(RuntimeArray *)L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.AnimationClip::SetEventsInternal(System.Array)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_SetEventsInternal_m7A1129D019A40C7FD09B5D1C721002268AFD2878 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, RuntimeArray * ___value0, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_SetEventsInternal_m7A1129D019A40C7FD09B5D1C721002268AFD2878_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, RuntimeArray *);
	static AnimationClip_SetEventsInternal_m7A1129D019A40C7FD09B5D1C721002268AFD2878_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_SetEventsInternal_m7A1129D019A40C7FD09B5D1C721002268AFD2878_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::SetEventsInternal(System.Array)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Array UnityEngine.AnimationClip::GetEventsInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeArray * AnimationClip_GetEventsInternal_m9A7D3DD46EA3C7F7B935623D3C7640414CF338D8 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, const RuntimeMethod* method)
{
	typedef RuntimeArray * (*AnimationClip_GetEventsInternal_m9A7D3DD46EA3C7F7B935623D3C7640414CF338D8_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *);
	static AnimationClip_GetEventsInternal_m9A7D3DD46EA3C7F7B935623D3C7640414CF338D8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_GetEventsInternal_m9A7D3DD46EA3C7F7B935623D3C7640414CF338D8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::GetEventsInternal()");
	RuntimeArray * icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.AnimationClip::get_localBounds_Injected(UnityEngine.Bounds&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_get_localBounds_Injected_m5B95A86FEBB219110EEA104809880830423231B2 (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * ___ret0, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_get_localBounds_Injected_m5B95A86FEBB219110EEA104809880830423231B2_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *);
	static AnimationClip_get_localBounds_Injected_m5B95A86FEBB219110EEA104809880830423231B2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_get_localBounds_Injected_m5B95A86FEBB219110EEA104809880830423231B2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::get_localBounds_Injected(UnityEngine.Bounds&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.AnimationClip::set_localBounds_Injected(UnityEngine.Bounds&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationClip_set_localBounds_Injected_m4B78ABE1CC5A3C7485295EBBEAF25987A98689BE (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * __this, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 * ___value0, const RuntimeMethod* method)
{
	typedef void (*AnimationClip_set_localBounds_Injected_m4B78ABE1CC5A3C7485295EBBEAF25987A98689BE_ftn) (AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *, Bounds_t0F1F36D4F7AF49524B3C2A2259594412A3D3AE37 *);
	static AnimationClip_set_localBounds_Injected_m4B78ABE1CC5A3C7485295EBBEAF25987A98689BE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationClip_set_localBounds_Injected_m4B78ABE1CC5A3C7485295EBBEAF25987A98689BE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationClip::set_localBounds_Injected(UnityEngine.Bounds&)");
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
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationClipPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationClipPlayable_GetHandle_m93C27911A3C7107750C2A6BE529C58FB2FDB1122 (AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationClipPlayable_GetHandle_m93C27911A3C7107750C2A6BE529C58FB2FDB1122_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 * _thisAdjusted = reinterpret_cast<AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimationClipPlayable_GetHandle_m93C27911A3C7107750C2A6BE529C58FB2FDB1122(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationClipPlayable::Equals(UnityEngine.Animations.AnimationClipPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationClipPlayable_Equals_m73BDBE0839B6AA4782C37B21DD58D3388B5EC814 (AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 * __this, AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimationClipPlayable_GetHandle_m93C27911A3C7107750C2A6BE529C58FB2FDB1122((AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 *)__this, /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1;
		L_1 = AnimationClipPlayable_GetHandle_m93C27911A3C7107750C2A6BE529C58FB2FDB1122((AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 *)(&___other0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_mFD26CFA8ECF2B622B1A3D4117066CAE965C9F704(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationClipPlayable_Equals_m73BDBE0839B6AA4782C37B21DD58D3388B5EC814_AdjustorThunk (RuntimeObject * __this, AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 * _thisAdjusted = reinterpret_cast<AnimationClipPlayable_t6386488B0C0300A21A352B4C17B9E6D5D38DF953 *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationClipPlayable_Equals_m73BDBE0839B6AA4782C37B21DD58D3388B5EC814(_thisAdjusted, ___other0, method);
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


// Conversion methods for marshalling of: UnityEngine.AnimationEvent
IL2CPP_EXTERN_C void AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshal_pinvoke(const AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF& unmarshaled, AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshaled_pinvoke& marshaled)
{
	Exception_t* ___m_StateSender_8Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_StateSender' of type 'AnimationEvent': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_StateSender_8Exception, NULL);
}
IL2CPP_EXTERN_C void AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshal_pinvoke_back(const AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshaled_pinvoke& marshaled, AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF& unmarshaled)
{
	Exception_t* ___m_StateSender_8Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_StateSender' of type 'AnimationEvent': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_StateSender_8Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimationEvent
IL2CPP_EXTERN_C void AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshal_pinvoke_cleanup(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshaled_pinvoke& marshaled)
{
}


// Conversion methods for marshalling of: UnityEngine.AnimationEvent
IL2CPP_EXTERN_C void AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshal_com(const AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF& unmarshaled, AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshaled_com& marshaled)
{
	Exception_t* ___m_StateSender_8Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_StateSender' of type 'AnimationEvent': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_StateSender_8Exception, NULL);
}
IL2CPP_EXTERN_C void AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshal_com_back(const AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshaled_com& marshaled, AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF& unmarshaled)
{
	Exception_t* ___m_StateSender_8Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_StateSender' of type 'AnimationEvent': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_StateSender_8Exception, NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimationEvent
IL2CPP_EXTERN_C void AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshal_com_cleanup(AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.AnimationEvent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationEvent__ctor_mA2780A113EA8DD56C3C2EDD0D60BBA78047BACDE (AnimationEvent_tC15CA47BE450896AF876FFA75D7A8E22C2D286AF * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		__this->set_m_Time_0((0.0f));
		__this->set_m_FunctionName_1(_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		__this->set_m_StringParameter_2(_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		__this->set_m_ObjectReferenceParameter_3((Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL);
		__this->set_m_FloatParameter_4((0.0f));
		__this->set_m_IntParameter_5(0);
		__this->set_m_MessageOptions_6(0);
		__this->set_m_Source_7(0);
		__this->set_m_StateSender_8((AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD *)NULL);
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
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable__ctor_m42F8E5BB37A175AF298324D3072932ED9946427B (AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_m866298E26CA43C28F7948D46E99D65FAA09722C5_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_m866298E26CA43C28F7948D46E99D65FAA09722C5((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/PlayableHandle_IsPlayableOfType_TisAnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_m866298E26CA43C28F7948D46E99D65FAA09722C5_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * L_4 = (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var)));
		InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralD2435BFAEB0372E848D9BE812E3B06AB862CC3D1)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationLayerMixerPlayable__ctor_m42F8E5BB37A175AF298324D3072932ED9946427B_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_5 = ___handle0;
		__this->set_m_Handle_0(L_5);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationLayerMixerPlayable__ctor_m42F8E5BB37A175AF298324D3072932ED9946427B_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * _thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 *>(__this + _offset);
	AnimationLayerMixerPlayable__ctor_m42F8E5BB37A175AF298324D3072932ED9946427B(_thisAdjusted, ___handle0, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationLayerMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationLayerMixerPlayable_GetHandle_mBFA950F140D76E10983B9AB946397F4C12ABC439 (AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationLayerMixerPlayable_GetHandle_mBFA950F140D76E10983B9AB946397F4C12ABC439_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * _thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimationLayerMixerPlayable_GetHandle_mBFA950F140D76E10983B9AB946397F4C12ABC439(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationLayerMixerPlayable::Equals(UnityEngine.Animations.AnimationLayerMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationLayerMixerPlayable_Equals_m018BD27B24B3EDC5101A475A14F13F753F2323AA (AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * __this, AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimationLayerMixerPlayable_GetHandle_mBFA950F140D76E10983B9AB946397F4C12ABC439((AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 *)__this, /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1;
		L_1 = AnimationLayerMixerPlayable_GetHandle_mBFA950F140D76E10983B9AB946397F4C12ABC439((AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 *)(&___other0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_mFD26CFA8ECF2B622B1A3D4117066CAE965C9F704(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationLayerMixerPlayable_Equals_m018BD27B24B3EDC5101A475A14F13F753F2323AA_AdjustorThunk (RuntimeObject * __this, AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 * _thisAdjusted = reinterpret_cast<AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880 *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationLayerMixerPlayable_Equals_m018BD27B24B3EDC5101A475A14F13F753F2323AA(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationLayerMixerPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationLayerMixerPlayable__cctor_mBE9F47E968D356F7BB549E705A4E91E1AEAEE807 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationLayerMixerPlayable__ctor_m42F8E5BB37A175AF298324D3072932ED9946427B((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_StaticFields*)il2cpp_codegen_static_fields_for(AnimationLayerMixerPlayable_tF647DD9BCA6E0F49367A5F13AAE0D5B093A91880_il2cpp_TypeInfo_var))->set_m_NullPlayable_1(L_1);
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
// System.Void UnityEngine.Animations.AnimationMixerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMixerPlayable__ctor_mA03CF37709B7854227E25F91BE4F7559981058B0 (AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_m30062CF184CC05FFAA026881BEFE337C13B7E70E_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_m30062CF184CC05FFAA026881BEFE337C13B7E70E((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/PlayableHandle_IsPlayableOfType_TisAnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_m30062CF184CC05FFAA026881BEFE337C13B7E70E_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * L_4 = (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var)));
		InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral4DEE968069F34C26613ADFCD69C41EFC29314286)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationMixerPlayable__ctor_mA03CF37709B7854227E25F91BE4F7559981058B0_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_5 = ___handle0;
		__this->set_m_Handle_0(L_5);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationMixerPlayable__ctor_mA03CF37709B7854227E25F91BE4F7559981058B0_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * _thisAdjusted = reinterpret_cast<AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 *>(__this + _offset);
	AnimationMixerPlayable__ctor_mA03CF37709B7854227E25F91BE4F7559981058B0(_thisAdjusted, ___handle0, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMixerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationMixerPlayable_GetHandle_mE8F7D1A18F1BD1C00BA1EC6AA8036044E8907FC3 (AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationMixerPlayable_GetHandle_mE8F7D1A18F1BD1C00BA1EC6AA8036044E8907FC3_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * _thisAdjusted = reinterpret_cast<AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimationMixerPlayable_GetHandle_mE8F7D1A18F1BD1C00BA1EC6AA8036044E8907FC3(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationMixerPlayable::Equals(UnityEngine.Animations.AnimationMixerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMixerPlayable_Equals_m8979D90ED92FF553B5D6AB0BDD616C544352816B (AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * __this, AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimationMixerPlayable_GetHandle_mE8F7D1A18F1BD1C00BA1EC6AA8036044E8907FC3((AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 *)__this, /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1;
		L_1 = AnimationMixerPlayable_GetHandle_mE8F7D1A18F1BD1C00BA1EC6AA8036044E8907FC3((AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 *)(&___other0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_mFD26CFA8ECF2B622B1A3D4117066CAE965C9F704(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationMixerPlayable_Equals_m8979D90ED92FF553B5D6AB0BDD616C544352816B_AdjustorThunk (RuntimeObject * __this, AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 * _thisAdjusted = reinterpret_cast<AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741 *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationMixerPlayable_Equals_m8979D90ED92FF553B5D6AB0BDD616C544352816B(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationMixerPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMixerPlayable__cctor_m8DB71DF60AD75D3274E24FDB9DAC8F4D8FDD5C1D (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationMixerPlayable__ctor_mA03CF37709B7854227E25F91BE4F7559981058B0((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_StaticFields*)il2cpp_codegen_static_fields_for(AnimationMixerPlayable_t7C6D407FE0D55712B07081F8114CFA347F124741_il2cpp_TypeInfo_var))->set_m_NullPlayable_1(L_1);
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
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable__ctor_m11668860161B62484EA095BD6360AFD26A86DE93 (AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_m19943D18384297A3129F799C12E91B0D8162A02F_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_m19943D18384297A3129F799C12E91B0D8162A02F((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/PlayableHandle_IsPlayableOfType_TisAnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_m19943D18384297A3129F799C12E91B0D8162A02F_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * L_4 = (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var)));
		InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral8DC2252638D84FAF2C30B95D54EC83F52FA6C630)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationMotionXToDeltaPlayable__ctor_m11668860161B62484EA095BD6360AFD26A86DE93_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_5 = ___handle0;
		__this->set_m_Handle_0(L_5);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationMotionXToDeltaPlayable__ctor_m11668860161B62484EA095BD6360AFD26A86DE93_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * _thisAdjusted = reinterpret_cast<AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 *>(__this + _offset);
	AnimationMotionXToDeltaPlayable__ctor_m11668860161B62484EA095BD6360AFD26A86DE93(_thisAdjusted, ___handle0, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationMotionXToDeltaPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationMotionXToDeltaPlayable_GetHandle_m840D19A4E2DFB4BF2397061B833E63AD786587BA (AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationMotionXToDeltaPlayable_GetHandle_m840D19A4E2DFB4BF2397061B833E63AD786587BA_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * _thisAdjusted = reinterpret_cast<AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimationMotionXToDeltaPlayable_GetHandle_m840D19A4E2DFB4BF2397061B833E63AD786587BA(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationMotionXToDeltaPlayable::Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationMotionXToDeltaPlayable_Equals_mB08A41C628755AF909489716A1D62AECC2BFDD9E (AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * __this, AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimationMotionXToDeltaPlayable_GetHandle_m840D19A4E2DFB4BF2397061B833E63AD786587BA((AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 *)__this, /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1;
		L_1 = AnimationMotionXToDeltaPlayable_GetHandle_m840D19A4E2DFB4BF2397061B833E63AD786587BA((AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 *)(&___other0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_mFD26CFA8ECF2B622B1A3D4117066CAE965C9F704(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationMotionXToDeltaPlayable_Equals_mB08A41C628755AF909489716A1D62AECC2BFDD9E_AdjustorThunk (RuntimeObject * __this, AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 * _thisAdjusted = reinterpret_cast<AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076 *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationMotionXToDeltaPlayable_Equals_mB08A41C628755AF909489716A1D62AECC2BFDD9E(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationMotionXToDeltaPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationMotionXToDeltaPlayable__cctor_m0C46BAE776A8D7FAB7CEE08C4D6EBC63B08708FD (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationMotionXToDeltaPlayable__ctor_m11668860161B62484EA095BD6360AFD26A86DE93((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_StaticFields*)il2cpp_codegen_static_fields_for(AnimationMotionXToDeltaPlayable_t6E21B629D4689F5E3CFCFACA0B31411082773076_il2cpp_TypeInfo_var))->set_m_NullPlayable_1(L_1);
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
// System.Void UnityEngine.Animations.AnimationOffsetPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationOffsetPlayable__ctor_m9527E52AEA325EAE188AB9843497F2AB33CB742E (AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_m1B2FA89CE8F4A1EBD1AE3FF4E7154CFE120EDF85_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_m1B2FA89CE8F4A1EBD1AE3FF4E7154CFE120EDF85((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/PlayableHandle_IsPlayableOfType_TisAnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_m1B2FA89CE8F4A1EBD1AE3FF4E7154CFE120EDF85_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * L_4 = (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var)));
		InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralA3C8FF345EC45846B2EE6801F84DD49340F0A9E1)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationOffsetPlayable__ctor_m9527E52AEA325EAE188AB9843497F2AB33CB742E_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_5 = ___handle0;
		__this->set_m_Handle_0(L_5);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationOffsetPlayable__ctor_m9527E52AEA325EAE188AB9843497F2AB33CB742E_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * _thisAdjusted = reinterpret_cast<AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 *>(__this + _offset);
	AnimationOffsetPlayable__ctor_m9527E52AEA325EAE188AB9843497F2AB33CB742E(_thisAdjusted, ___handle0, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationOffsetPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationOffsetPlayable_GetHandle_m8C3C08EC531127B002D3AFAB5AF259D8030B0049 (AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationOffsetPlayable_GetHandle_m8C3C08EC531127B002D3AFAB5AF259D8030B0049_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * _thisAdjusted = reinterpret_cast<AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimationOffsetPlayable_GetHandle_m8C3C08EC531127B002D3AFAB5AF259D8030B0049(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationOffsetPlayable::Equals(UnityEngine.Animations.AnimationOffsetPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationOffsetPlayable_Equals_m9AFE60B035481569924E20C6953B4B21EF7734AA (AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * __this, AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimationOffsetPlayable_GetHandle_m8C3C08EC531127B002D3AFAB5AF259D8030B0049((AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 *)(&___other0), /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = L_0;
		RuntimeObject * L_2 = Box(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var, &L_1);
		RuntimeObject * L_3 = Box(AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_il2cpp_TypeInfo_var, __this);
		NullCheck(L_3);
		bool L_4;
		L_4 = VirtFuncInvoker1< bool, RuntimeObject * >::Invoke(0 /* System.Boolean System.Object::Equals(System.Object) */, L_3, L_2);
		*__this = *(AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 *)UnBox(L_3);
		V_0 = L_4;
		goto IL_001c;
	}

IL_001c:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool AnimationOffsetPlayable_Equals_m9AFE60B035481569924E20C6953B4B21EF7734AA_AdjustorThunk (RuntimeObject * __this, AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 * _thisAdjusted = reinterpret_cast<AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941 *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationOffsetPlayable_Equals_m9AFE60B035481569924E20C6953B4B21EF7734AA(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationOffsetPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationOffsetPlayable__cctor_m00251ED10BD7F52F20BC9D0A36B9C8AC52F15FA6 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationOffsetPlayable__ctor_m9527E52AEA325EAE188AB9843497F2AB33CB742E((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_StaticFields*)il2cpp_codegen_static_fields_for(AnimationOffsetPlayable_tBB8333A8E35A23D8FAA2D34E35FF02BD53FF9941_il2cpp_TypeInfo_var))->set_m_NullPlayable_1(L_1);
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
// System.Void UnityEngine.Animations.AnimationPosePlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPosePlayable__ctor_m318607F120F21EDE3D7C1ED07C8B2ED13A23BF57 (AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_m171336A5BD550FD80BFD4B2BDF5903DF72C0E1C2_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_m171336A5BD550FD80BFD4B2BDF5903DF72C0E1C2((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/PlayableHandle_IsPlayableOfType_TisAnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_m171336A5BD550FD80BFD4B2BDF5903DF72C0E1C2_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * L_4 = (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var)));
		InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralE066D08B565F88D413FDACA14C42BFF008FF4EB9)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationPosePlayable__ctor_m318607F120F21EDE3D7C1ED07C8B2ED13A23BF57_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_5 = ___handle0;
		__this->set_m_Handle_0(L_5);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationPosePlayable__ctor_m318607F120F21EDE3D7C1ED07C8B2ED13A23BF57_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * _thisAdjusted = reinterpret_cast<AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 *>(__this + _offset);
	AnimationPosePlayable__ctor_m318607F120F21EDE3D7C1ED07C8B2ED13A23BF57(_thisAdjusted, ___handle0, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationPosePlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationPosePlayable_GetHandle_m0354C54EB680FC70D4B48D95F7FC4BA4700A0DCE (AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationPosePlayable_GetHandle_m0354C54EB680FC70D4B48D95F7FC4BA4700A0DCE_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * _thisAdjusted = reinterpret_cast<AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimationPosePlayable_GetHandle_m0354C54EB680FC70D4B48D95F7FC4BA4700A0DCE(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationPosePlayable::Equals(UnityEngine.Animations.AnimationPosePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationPosePlayable_Equals_mECC5FA256AAA5334C38DBB6D00EE8AC1BDC015A1 (AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * __this, AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimationPosePlayable_GetHandle_m0354C54EB680FC70D4B48D95F7FC4BA4700A0DCE((AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 *)(&___other0), /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = L_0;
		RuntimeObject * L_2 = Box(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var, &L_1);
		RuntimeObject * L_3 = Box(AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_il2cpp_TypeInfo_var, __this);
		NullCheck(L_3);
		bool L_4;
		L_4 = VirtFuncInvoker1< bool, RuntimeObject * >::Invoke(0 /* System.Boolean System.Object::Equals(System.Object) */, L_3, L_2);
		*__this = *(AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 *)UnBox(L_3);
		V_0 = L_4;
		goto IL_001c;
	}

IL_001c:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool AnimationPosePlayable_Equals_mECC5FA256AAA5334C38DBB6D00EE8AC1BDC015A1_AdjustorThunk (RuntimeObject * __this, AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 * _thisAdjusted = reinterpret_cast<AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9 *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationPosePlayable_Equals_mECC5FA256AAA5334C38DBB6D00EE8AC1BDC015A1(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationPosePlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationPosePlayable__cctor_m61B5F097B084BBB3CD21AE5E565AB35450C85B1C (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationPosePlayable__ctor_m318607F120F21EDE3D7C1ED07C8B2ED13A23BF57((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_StaticFields*)il2cpp_codegen_static_fields_for(AnimationPosePlayable_t455DFF8AB153FC8930BD1B79342EC791033662B9_il2cpp_TypeInfo_var))->set_m_NullPlayable_1(L_1);
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
// System.Void UnityEngine.Animations.AnimationRemoveScalePlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationRemoveScalePlayable__ctor_m08810C8ECE9A3A100087DD84B13204EC3AF73A8F (AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_mEF5219AC94275FE2811CEDC16FE0B850DBA7E9BE_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_mEF5219AC94275FE2811CEDC16FE0B850DBA7E9BE((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/PlayableHandle_IsPlayableOfType_TisAnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_mEF5219AC94275FE2811CEDC16FE0B850DBA7E9BE_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * L_4 = (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var)));
		InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral98C704D69BD1A288ED31DEE4ED4E50097A2D7018)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationRemoveScalePlayable__ctor_m08810C8ECE9A3A100087DD84B13204EC3AF73A8F_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_5 = ___handle0;
		__this->set_m_Handle_0(L_5);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationRemoveScalePlayable__ctor_m08810C8ECE9A3A100087DD84B13204EC3AF73A8F_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * _thisAdjusted = reinterpret_cast<AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 *>(__this + _offset);
	AnimationRemoveScalePlayable__ctor_m08810C8ECE9A3A100087DD84B13204EC3AF73A8F(_thisAdjusted, ___handle0, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationRemoveScalePlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationRemoveScalePlayable_GetHandle_m1949202B58BDF17726A1ADC934EB5232E835CCA8 (AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationRemoveScalePlayable_GetHandle_m1949202B58BDF17726A1ADC934EB5232E835CCA8_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * _thisAdjusted = reinterpret_cast<AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimationRemoveScalePlayable_GetHandle_m1949202B58BDF17726A1ADC934EB5232E835CCA8(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationRemoveScalePlayable::Equals(UnityEngine.Animations.AnimationRemoveScalePlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationRemoveScalePlayable_Equals_m7FE9E55B027861A0B91347F18DAC7E11E2740397 (AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * __this, AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimationRemoveScalePlayable_GetHandle_m1949202B58BDF17726A1ADC934EB5232E835CCA8((AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 *)(&___other0), /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = L_0;
		RuntimeObject * L_2 = Box(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var, &L_1);
		RuntimeObject * L_3 = Box(AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_il2cpp_TypeInfo_var, __this);
		NullCheck(L_3);
		bool L_4;
		L_4 = VirtFuncInvoker1< bool, RuntimeObject * >::Invoke(0 /* System.Boolean System.Object::Equals(System.Object) */, L_3, L_2);
		*__this = *(AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 *)UnBox(L_3);
		V_0 = L_4;
		goto IL_001c;
	}

IL_001c:
	{
		bool L_5 = V_0;
		return L_5;
	}
}
IL2CPP_EXTERN_C  bool AnimationRemoveScalePlayable_Equals_m7FE9E55B027861A0B91347F18DAC7E11E2740397_AdjustorThunk (RuntimeObject * __this, AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 * _thisAdjusted = reinterpret_cast<AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429 *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationRemoveScalePlayable_Equals_m7FE9E55B027861A0B91347F18DAC7E11E2740397(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationRemoveScalePlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationRemoveScalePlayable__cctor_mA35B93BA4FDEDAA98ACE6A314BF0ED50839B8A98 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationRemoveScalePlayable__ctor_m08810C8ECE9A3A100087DD84B13204EC3AF73A8F((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_StaticFields*)il2cpp_codegen_static_fields_for(AnimationRemoveScalePlayable_t774D428669D5CF715E9A7E80E52A619AECC80429_il2cpp_TypeInfo_var))->set_m_NullPlayable_1(L_1);
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
// System.Void UnityEngine.Animations.AnimationScriptPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable__ctor_m0B751F7A7D28F59AADACE7C13704D653E0879C56 (AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_m529F82044C8D4F4B60EA35E96D1C0592644AD76B_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	{
		bool L_0;
		L_0 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0027;
		}
	}
	{
		bool L_2;
		L_2 = PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_m529F82044C8D4F4B60EA35E96D1C0592644AD76B((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/PlayableHandle_IsPlayableOfType_TisAnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_m529F82044C8D4F4B60EA35E96D1C0592644AD76B_RuntimeMethod_var);
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0026;
		}
	}
	{
		InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * L_4 = (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var)));
		InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral860B9EA7CDAB02A8A4B38336805EAE2FBA31F09C)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimationScriptPlayable__ctor_m0B751F7A7D28F59AADACE7C13704D653E0879C56_RuntimeMethod_var)));
	}

IL_0026:
	{
	}

IL_0027:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_5 = ___handle0;
		__this->set_m_Handle_0(L_5);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimationScriptPlayable__ctor_m0B751F7A7D28F59AADACE7C13704D653E0879C56_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * _thisAdjusted = reinterpret_cast<AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B *>(__this + _offset);
	AnimationScriptPlayable__ctor_m0B751F7A7D28F59AADACE7C13704D653E0879C56(_thisAdjusted, ___handle0, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimationScriptPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationScriptPlayable_GetHandle_mCEA7899E7E43FC2C73B3331AE27C289327F03B18 (AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimationScriptPlayable_GetHandle_mCEA7899E7E43FC2C73B3331AE27C289327F03B18_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * _thisAdjusted = reinterpret_cast<AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimationScriptPlayable_GetHandle_mCEA7899E7E43FC2C73B3331AE27C289327F03B18(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.Animations.AnimationScriptPlayable::Equals(UnityEngine.Animations.AnimationScriptPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimationScriptPlayable_Equals_m1705DCC80312E3D34E17B32BDBAF4BBB78D435D8 (AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * __this, AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimationScriptPlayable_GetHandle_mCEA7899E7E43FC2C73B3331AE27C289327F03B18((AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B *)__this, /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1;
		L_1 = AnimationScriptPlayable_GetHandle_mCEA7899E7E43FC2C73B3331AE27C289327F03B18((AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B *)(&___other0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_mFD26CFA8ECF2B622B1A3D4117066CAE965C9F704(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimationScriptPlayable_Equals_m1705DCC80312E3D34E17B32BDBAF4BBB78D435D8_AdjustorThunk (RuntimeObject * __this, AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B * _thisAdjusted = reinterpret_cast<AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimationScriptPlayable_Equals_m1705DCC80312E3D34E17B32BDBAF4BBB78D435D8(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimationScriptPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationScriptPlayable__cctor_m2E7AD0269606C2EB23E1A6A1407E53ACAE1C6F31 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimationScriptPlayable__ctor_m0B751F7A7D28F59AADACE7C13704D653E0879C56((&L_1), L_0, /*hidden argument*/NULL);
		((AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_StaticFields*)il2cpp_codegen_static_fields_for(AnimationScriptPlayable_tC1413FB51680271522811045B1BAA555B8F01C6B_il2cpp_TypeInfo_var))->set_m_NullPlayable_1(L_1);
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
// System.Void UnityEngine.AnimationState::set_speed(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationState_set_speed_m54AF12C004F2253228DA25B9E21774184A77271D (AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*AnimationState_set_speed_m54AF12C004F2253228DA25B9E21774184A77271D_ftn) (AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD *, float);
	static AnimationState_set_speed_m54AF12C004F2253228DA25B9E21774184A77271D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationState_set_speed_m54AF12C004F2253228DA25B9E21774184A77271D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationState::set_speed(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.AnimationClip UnityEngine.AnimationState::get_clip()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * AnimationState_get_clip_m84FD95AFB1FDC356E53AA6F44089F69B353B42BB (AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * __this, const RuntimeMethod* method)
{
	typedef AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * (*AnimationState_get_clip_m84FD95AFB1FDC356E53AA6F44089F69B353B42BB_ftn) (AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD *);
	static AnimationState_get_clip_m84FD95AFB1FDC356E53AA6F44089F69B353B42BB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimationState_get_clip_m84FD95AFB1FDC356E53AA6F44089F69B353B42BB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimationState::get_clip()");
	AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.AnimationState::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimationState__ctor_m5ECFF9F10ACFB838138F1E33E3D55EEAF891D217 (AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * __this, const RuntimeMethod* method)
{
	{
		TrackedReference__ctor_m7E082F3A77162102770CCB781B5EAE437AB373CD(__this, /*hidden argument*/NULL);
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
// System.Boolean UnityEngine.Animator::get_isOptimizable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_isOptimizable_m8CCEECCC72F1B724FFFFAD84D2C904EE9D237B05 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_isOptimizable_m8CCEECCC72F1B724FFFFAD84D2C904EE9D237B05_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_isOptimizable_m8CCEECCC72F1B724FFFFAD84D2C904EE9D237B05_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_isOptimizable_m8CCEECCC72F1B724FFFFAD84D2C904EE9D237B05_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_isOptimizable()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_isHuman()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_isHuman_mF84D8FCA931AD30C3ED79723A0FF42643161A969 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_isHuman_mF84D8FCA931AD30C3ED79723A0FF42643161A969_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_isHuman_mF84D8FCA931AD30C3ED79723A0FF42643161A969_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_isHuman_mF84D8FCA931AD30C3ED79723A0FF42643161A969_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_isHuman()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_hasRootMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_hasRootMotion_m762D8451875C8F017E966C09263D38FEF984171F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_hasRootMotion_m762D8451875C8F017E966C09263D38FEF984171F_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_hasRootMotion_m762D8451875C8F017E966C09263D38FEF984171F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_hasRootMotion_m762D8451875C8F017E966C09263D38FEF984171F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_hasRootMotion()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_isRootPositionOrRotationControlledByCurves()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_isRootPositionOrRotationControlledByCurves_m461187EFDD39CD274095127312790C550D7DBF48 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_isRootPositionOrRotationControlledByCurves_m461187EFDD39CD274095127312790C550D7DBF48_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_isRootPositionOrRotationControlledByCurves_m461187EFDD39CD274095127312790C550D7DBF48_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_isRootPositionOrRotationControlledByCurves_m461187EFDD39CD274095127312790C550D7DBF48_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_isRootPositionOrRotationControlledByCurves()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::get_humanScale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_humanScale_m57F5C43B344EA1876B5DC9ED8A5CEDB6CD67DF02 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_get_humanScale_m57F5C43B344EA1876B5DC9ED8A5CEDB6CD67DF02_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_humanScale_m57F5C43B344EA1876B5DC9ED8A5CEDB6CD67DF02_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_humanScale_m57F5C43B344EA1876B5DC9ED8A5CEDB6CD67DF02_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_humanScale()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_isInitialized()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_isInitialized_mE2537C77C6C8DC4403C0D0C58FAFE755310A8FE0 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_isInitialized_mE2537C77C6C8DC4403C0D0C58FAFE755310A8FE0_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_isInitialized_mE2537C77C6C8DC4403C0D0C58FAFE755310A8FE0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_isInitialized_mE2537C77C6C8DC4403C0D0C58FAFE755310A8FE0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_isInitialized()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::GetFloat(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloat_m74C168FD46C780CD153838BDCE77F8B371456D46 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		String_t* L_0 = ___name0;
		float L_1;
		L_1 = Animator_GetFloatString_m1A82C1B3C58A2A289AF6002EEAD2C217197CF5E6(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		float L_2 = V_0;
		return L_2;
	}
}
// System.Single UnityEngine.Animator::GetFloat(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloat_mF4C57107C655950D09A9CFB7360F7ABE2D8057D2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		int32_t L_0 = ___id0;
		float L_1;
		L_1 = Animator_GetFloatID_mC18A6BBCE86EE27603FEE22E31A4657AE75FAE17(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		float L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Animator::SetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloat_mD731F47ED44C2D629F8E1C6DB15629C3E1B992A0 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, float ___value1, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___name0;
		float L_1 = ___value1;
		Animator_SetFloatString_m0D1D54020A1D7F9E73A84DAA5FF118ED31F3E943(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetFloat(System.String,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloat_mA337A8EB0C377B41EAB2FAFC01320F9FD2DC6ED3 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, float ___value1, float ___dampTime2, float ___deltaTime3, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___name0;
		float L_1 = ___value1;
		float L_2 = ___dampTime2;
		float L_3 = ___deltaTime3;
		Animator_SetFloatStringDamp_mE5687E1F614DEDDE45110DA6A55F1B5499667B0C(__this, L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetFloat(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloat_m22777620F85E25691F57A7CAD4190D7F5702E02C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, float ___value1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___id0;
		float L_1 = ___value1;
		Animator_SetFloatID_m277DFF321B75EE54886A5BD1FECF7E3E3CE5D4B2(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetFloat(System.Int32,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloat_mB6D249371976254CDD71F4205E541945C66F887B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, float ___value1, float ___dampTime2, float ___deltaTime3, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___id0;
		float L_1 = ___value1;
		float L_2 = ___dampTime2;
		float L_3 = ___deltaTime3;
		Animator_SetFloatIDDamp_mE2C9E4DC3B8A75AE7CD1B14437E4F0F092B4EF66(__this, L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Animator::GetBool(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBool_m69AFEA8176E7FB312C264773784D6D6B08A80C0A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		String_t* L_0 = ___name0;
		bool L_1;
		L_1 = Animator_GetBoolString_mCACE093AEB7F1FDB919A2F5D6057E95124CF6980(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animator::GetBool(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBool_m48FAF6A6341ADD7A9790DA1C59BA478A9048EB22 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0 = ___id0;
		bool L_1;
		L_1 = Animator_GetBoolID_m1C533DC66ECF19A118119773458D0F018F2238F0(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Animator::SetBool(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBool_m34E2E9785A47A3AE94E804004425C333C36CCD43 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, bool ___value1, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___name0;
		bool L_1 = ___value1;
		Animator_SetBoolString_mB0D21540179FFB9E5F1B2C2EF008BD0595B78BA7(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetBool(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBool_m0F0363B189AAB848FA3B428986C6A01470B3E38C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, bool ___value1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___id0;
		bool L_1 = ___value1;
		Animator_SetBoolID_m86E6B6BAB2AF50CF90D6E6DA56579AF08E5A9342(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Int32 UnityEngine.Animator::GetInteger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetInteger_m241D1FE7606567D0D51FB5BEBC1F4AA5B61DDD7A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		String_t* L_0 = ___name0;
		int32_t L_1;
		L_1 = Animator_GetIntegerString_m812EDB3BBD70E2910B5C06518D4A383AE3FCCA77(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Int32 UnityEngine.Animator::GetInteger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetInteger_m1DE57680CE07B659AF23B2C206850EA825F12DFC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___id0;
		int32_t L_1;
		L_1 = Animator_GetIntegerID_m6BDA07EF7C93439AB21AB8C8AE84AE5E2BDBB7B1(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.Animator::SetInteger(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetInteger_mFB04A03AF6C24978BF2BDE9161243F8F6B9762C5 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, int32_t ___value1, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___name0;
		int32_t L_1 = ___value1;
		Animator_SetIntegerString_m98F3F5AF11579CA8F0DD2C43625CBE6258999CB9(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetInteger(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetInteger_mF7D7D881496A3E762208730799DE488D942EFE46 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, int32_t ___value1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___id0;
		int32_t L_1 = ___value1;
		Animator_SetIntegerID_m935BD3F26317A508AA8EE0642E4D3F0A083673F6(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTrigger_m2D79D155CABD81B1CC75EFC35D90508B58D7211C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___name0;
		Animator_SetTriggerString_m38F66A49276BCED56B89BB6AF8A36183BE4285F0(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetTrigger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTrigger_m081FDF5695B938E2DB858A0DBDC38C2F48C55B28 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___id0;
		Animator_SetTriggerID_mF7C748DA4002FE27B11A23AB015E761EACE374E9(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::ResetTrigger(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTrigger_m02F8CF7EABE466CC3D008A8538171E14BFB907FA (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___name0;
		Animator_ResetTriggerString_m6FC21A6B7732A31338EE22E78F3D6220903EDBB2(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::ResetTrigger(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTrigger_m8A3EFE371465928C7C898424B1852D06E45A9596 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___id0;
		Animator_ResetTriggerID_m982AAC9DF5A10C9ED32F52A5F2DD67C4C85DC111(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Animator::IsParameterControlledByCurve(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsParameterControlledByCurve_mD13E9C72576FB1D5F0436F00D8E82D9EB747F2BB (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		String_t* L_0 = ___name0;
		bool L_1;
		L_1 = Animator_IsParameterControlledByCurveString_m51A328B88D4BF88623289AAE897FF4C4AC06556C(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Boolean UnityEngine.Animator::IsParameterControlledByCurve(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsParameterControlledByCurve_mEA933A8593B7A96ED334CB333384B4420F2E2678 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0 = ___id0;
		bool L_1;
		L_1 = Animator_IsParameterControlledByCurveID_m741E77411D309424E5A2A55D74C92D87CB618B9B(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::get_deltaPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_deltaPosition_m064ACBB4845CFE50050B838DC5F7ADD98E7C38AD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_deltaPosition_Injected_m1E4EE8E8FF829CD0CA02B5B2993B8F52F51FAE7E(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = V_0;
		return L_0;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::get_deltaRotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_get_deltaRotation_mCB34E33E08D5B1D7467609CB08E1753BB0BA94A7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_deltaRotation_Injected_mDD91E09560E64E4CD711CF2A0FCB93B9607976D5(__this, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&V_0), /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_0 = V_0;
		return L_0;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::get_velocity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_velocity_m7DCAEF56F80837FCBC06FECFD4F9181AEBF5D9BD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_velocity_Injected_m225EE219299DD0B557685EEBB8C98687A5ABD772(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = V_0;
		return L_0;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::get_angularVelocity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_angularVelocity_mEEEE469D36F1820A288E26987E207DE496B2DAF2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_angularVelocity_Injected_m111D48072DE65364FA873BEAA14288C44A0538F9(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = V_0;
		return L_0;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::get_rootPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_rootPosition_mAF11A46CB8D953A1947FFF512F143899B3B9BFE9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_rootPosition_Injected_m3BDD26353E59D49EA2D775B52E87D2430C207836(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.Animator::set_rootPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_rootPosition_mCC186E57CE81CE9FAD6B287C8CFA1B5F5980F493 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method)
{
	{
		Animator_set_rootPosition_Injected_m4D693A6922FB9722FB27F58CD291A14DC21FF930(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::get_rootRotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_get_rootRotation_mF887DA02BAFB6FE896257F3FC4DFCA0F670C4933 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_rootRotation_Injected_mEDD72EDFCAFB6AA9069D2A8A69C4FF5CFFC442F4(__this, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&V_0), /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.Animator::set_rootRotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_rootRotation_mF2CEA43F91466423E7D1574A6BC6F3311E42ED3A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value0, const RuntimeMethod* method)
{
	{
		Animator_set_rootRotation_Injected_m91F597BA80DD077F49C4FD623E5055C5B3F5EAF3(__this, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Animator::get_applyRootMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_applyRootMotion_m28D9C6DC1E61538DC7598BF861A39312246A2C1C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_applyRootMotion_m28D9C6DC1E61538DC7598BF861A39312246A2C1C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_applyRootMotion_m28D9C6DC1E61538DC7598BF861A39312246A2C1C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_applyRootMotion_m28D9C6DC1E61538DC7598BF861A39312246A2C1C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_applyRootMotion()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_applyRootMotion(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_applyRootMotion_m21695E3FF10306945F9498641F6945BB73FC4266 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_applyRootMotion_m21695E3FF10306945F9498641F6945BB73FC4266_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_set_applyRootMotion_m21695E3FF10306945F9498641F6945BB73FC4266_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_applyRootMotion_m21695E3FF10306945F9498641F6945BB73FC4266_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_applyRootMotion(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Animator::get_linearVelocityBlending()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_linearVelocityBlending_m6B9F79DBDFCB4009B74D69E07621B260B27EB1B7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_linearVelocityBlending_m6B9F79DBDFCB4009B74D69E07621B260B27EB1B7_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_linearVelocityBlending_m6B9F79DBDFCB4009B74D69E07621B260B27EB1B7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_linearVelocityBlending_m6B9F79DBDFCB4009B74D69E07621B260B27EB1B7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_linearVelocityBlending()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_linearVelocityBlending(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_linearVelocityBlending_mAD9C2420A8463824843D8CE53300211715AB7D23 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_linearVelocityBlending_mAD9C2420A8463824843D8CE53300211715AB7D23_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_set_linearVelocityBlending_mAD9C2420A8463824843D8CE53300211715AB7D23_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_linearVelocityBlending_mAD9C2420A8463824843D8CE53300211715AB7D23_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_linearVelocityBlending(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Animator::get_animatePhysics()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_animatePhysics_mEBD15DA1FA770AB87CB9F466647011A970F0A46B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0;
		L_0 = Animator_get_updateMode_mEAAB40A7FC26FB82707B27D27AE946ADD81A4D00(__this, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)1))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::set_animatePhysics(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_animatePhysics_m67E7D76324838FC3B01FA0961AC26EB41008F494 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * G_B2_0 = NULL;
	Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * G_B1_0 = NULL;
	int32_t G_B3_0 = 0;
	Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * G_B3_1 = NULL;
	{
		bool L_0 = ___value0;
		G_B1_0 = __this;
		if (L_0)
		{
			G_B2_0 = __this;
			goto IL_0008;
		}
	}
	{
		G_B3_0 = 0;
		G_B3_1 = G_B1_0;
		goto IL_0009;
	}

IL_0008:
	{
		G_B3_0 = 1;
		G_B3_1 = G_B2_0;
	}

IL_0009:
	{
		NullCheck(G_B3_1);
		Animator_set_updateMode_mD10A679F349D4BD7722E1D700215592BDC4B05CE(G_B3_1, G_B3_0, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.AnimatorUpdateMode UnityEngine.Animator::get_updateMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_get_updateMode_mEAAB40A7FC26FB82707B27D27AE946ADD81A4D00 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_get_updateMode_mEAAB40A7FC26FB82707B27D27AE946ADD81A4D00_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_updateMode_mEAAB40A7FC26FB82707B27D27AE946ADD81A4D00_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_updateMode_mEAAB40A7FC26FB82707B27D27AE946ADD81A4D00_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_updateMode()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_updateMode(UnityEngine.AnimatorUpdateMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_updateMode_mD10A679F349D4BD7722E1D700215592BDC4B05CE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_updateMode_mD10A679F349D4BD7722E1D700215592BDC4B05CE_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_set_updateMode_mD10A679F349D4BD7722E1D700215592BDC4B05CE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_updateMode_mD10A679F349D4BD7722E1D700215592BDC4B05CE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_updateMode(UnityEngine.AnimatorUpdateMode)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Animator::get_hasTransformHierarchy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_hasTransformHierarchy_m461758001154ECE307BEDF2D95F8A68D3405FC25 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_hasTransformHierarchy_m461758001154ECE307BEDF2D95F8A68D3405FC25_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_hasTransformHierarchy_m461758001154ECE307BEDF2D95F8A68D3405FC25_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_hasTransformHierarchy_m461758001154ECE307BEDF2D95F8A68D3405FC25_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_hasTransformHierarchy()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_allowConstantClipSamplingOptimization()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_allowConstantClipSamplingOptimization_mB602E6761327533E33FF3E705D74C2AE5B75121E (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_allowConstantClipSamplingOptimization_mB602E6761327533E33FF3E705D74C2AE5B75121E_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_allowConstantClipSamplingOptimization_mB602E6761327533E33FF3E705D74C2AE5B75121E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_allowConstantClipSamplingOptimization_mB602E6761327533E33FF3E705D74C2AE5B75121E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_allowConstantClipSamplingOptimization()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_allowConstantClipSamplingOptimization(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_allowConstantClipSamplingOptimization_m8A32E370F11B10FB4244CA4839F866DCF656CC36 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_allowConstantClipSamplingOptimization_m8A32E370F11B10FB4244CA4839F866DCF656CC36_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_set_allowConstantClipSamplingOptimization_m8A32E370F11B10FB4244CA4839F866DCF656CC36_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_allowConstantClipSamplingOptimization_m8A32E370F11B10FB4244CA4839F866DCF656CC36_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_allowConstantClipSamplingOptimization(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.Animator::get_gravityWeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_gravityWeight_m6BFE2871B2675E3947413F4646A9C8C3398DC876 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_get_gravityWeight_m6BFE2871B2675E3947413F4646A9C8C3398DC876_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_gravityWeight_m6BFE2871B2675E3947413F4646A9C8C3398DC876_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_gravityWeight_m6BFE2871B2675E3947413F4646A9C8C3398DC876_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_gravityWeight()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.Vector3 UnityEngine.Animator::get_bodyPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_bodyPosition_m93924AC4ED543B17A7EBC2E58A455A59E1673093 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0;
		L_0 = Animator_get_bodyPositionInternal_m34906C8C0220B4E5473424B4D2AF010D7ABC9AD0(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0011;
	}

IL_0011:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::set_bodyPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPosition_m92675EEE056DF900D1C15C5B5A08562E6EBCDD5A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___value0;
		Animator_set_bodyPositionInternal_m39B875F219304D11B1616812D2081EDB72FF1126(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::get_bodyPositionInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_bodyPositionInternal_m34906C8C0220B4E5473424B4D2AF010D7ABC9AD0 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_bodyPositionInternal_Injected_mA3BAEBD74BAA40C266181E9FEDFC924B26C5D1A3(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.Animator::set_bodyPositionInternal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPositionInternal_m39B875F219304D11B1616812D2081EDB72FF1126 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value0, const RuntimeMethod* method)
{
	{
		Animator_set_bodyPositionInternal_Injected_m06CF9B9758465B3C3F7B901A9EFFA91E169B604A(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::get_bodyRotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_get_bodyRotation_m93EDBF01F3AD03CABBC88EB32545581E6D0592B9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_0;
		L_0 = Animator_get_bodyRotationInternal_m890643943203FF53B44FEFE00F8F8D3D083F34A4(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0011;
	}

IL_0011:
	{
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::set_bodyRotation(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotation_m26449BD9475FAA4A5923A3C41DBBC60CDC6F23AD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value0, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_0 = ___value0;
		Animator_set_bodyRotationInternal_m27796243543715931044588F28C0A55EDC191F9C(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::get_bodyRotationInternal()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_get_bodyRotationInternal_m890643943203FF53B44FEFE00F8F8D3D083F34A4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_bodyRotationInternal_Injected_m9728DF9FB2429838E333C3E407348B596015212F(__this, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&V_0), /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.Animator::set_bodyRotationInternal(UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotationInternal_m27796243543715931044588F28C0A55EDC191F9C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value0, const RuntimeMethod* method)
{
	{
		Animator_set_bodyRotationInternal_Injected_mF305D187AC0A67B81FE749925B80CA593442D9DE(__this, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&___value0), /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::GetIKPosition(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_GetIKPosition_mA331ECF0A9645851664E60A178801C47906F974F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___goal0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1;
		L_1 = Animator_GetGoalPosition_m089F722199DBEC377CDE256A74CEAF60A51F71BA(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0012;
	}

IL_0012:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::GetGoalPosition(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_GetGoalPosition_m089F722199DBEC377CDE256A74CEAF60A51F71BA (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		int32_t L_0 = ___goal0;
		Animator_GetGoalPosition_Injected_mB7A7DDCC49EAF85921366EFDAF4038002AC18597(__this, L_0, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::SetIKPosition(UnityEngine.AvatarIKGoal,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKPosition_m5D061142B0796E3E733A7FE490C6AC761DC0FFFF (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___goalPosition1, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___goal0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = ___goalPosition1;
		Animator_SetGoalPosition_m01430E4C8D0433E8782E20E9F90589E772F7493A(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetGoalPosition(UnityEngine.AvatarIKGoal,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalPosition_m01430E4C8D0433E8782E20E9F90589E772F7493A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___goalPosition1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___goal0;
		Animator_SetGoalPosition_Injected_m1F55B0A5FB8E563348DEF0C839D855D1B8084870(__this, L_0, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&___goalPosition1), /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::GetIKRotation(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_GetIKRotation_m18CE4B741943911903E701773585E3E01C7507F2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___goal0;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1;
		L_1 = Animator_GetGoalRotation_m72679689F5888F5452D58ECE3C238DFCA0AB3D9F(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0012;
	}

IL_0012:
	{
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::GetGoalRotation(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_GetGoalRotation_m72679689F5888F5452D58ECE3C238DFCA0AB3D9F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		int32_t L_0 = ___goal0;
		Animator_GetGoalRotation_Injected_m2887FC6A66153B5C6F560EA6106A1798E02D3CBD(__this, L_0, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&V_0), /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::SetIKRotation(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKRotation_mBBBDDF64761D8FCD67BCEF99B18770738E366DA5 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___goalRotation1, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___goal0;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1 = ___goalRotation1;
		Animator_SetGoalRotation_mB88FA15754BA6688DEC7686EAE75CC6750C76F8A(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetGoalRotation(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalRotation_mB88FA15754BA6688DEC7686EAE75CC6750C76F8A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___goalRotation1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___goal0;
		Animator_SetGoalRotation_Injected_m51FB734E9C792821846E5C33FD301879320867B8(__this, L_0, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&___goalRotation1), /*hidden argument*/NULL);
		return;
	}
}
// System.Single UnityEngine.Animator::GetIKPositionWeight(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetIKPositionWeight_m13574773EDC2F7D587240A43D4F282484FEE5E48 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___goal0;
		float L_1;
		L_1 = Animator_GetGoalWeightPosition_mCF2EF821773583FC80293F53C23F3E5DA0467E6D(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0012;
	}

IL_0012:
	{
		float L_2 = V_0;
		return L_2;
	}
}
// System.Single UnityEngine.Animator::GetGoalWeightPosition(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetGoalWeightPosition_mCF2EF821773583FC80293F53C23F3E5DA0467E6D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method)
{
	typedef float (*Animator_GetGoalWeightPosition_mCF2EF821773583FC80293F53C23F3E5DA0467E6D_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetGoalWeightPosition_mCF2EF821773583FC80293F53C23F3E5DA0467E6D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetGoalWeightPosition_mCF2EF821773583FC80293F53C23F3E5DA0467E6D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetGoalWeightPosition(UnityEngine.AvatarIKGoal)");
	float icallRetVal = _il2cpp_icall_func(__this, ___goal0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetIKPositionWeight(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKPositionWeight_m306B0B0F32E27DF24FB66FB6A1A47C86EA6020EF (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, float ___value1, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___goal0;
		float L_1 = ___value1;
		Animator_SetGoalWeightPosition_mB2A22B5F388D118521990BA45983357A8938FF03(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetGoalWeightPosition(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalWeightPosition_mB2A22B5F388D118521990BA45983357A8938FF03 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, float ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetGoalWeightPosition_mB2A22B5F388D118521990BA45983357A8938FF03_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float);
	static Animator_SetGoalWeightPosition_mB2A22B5F388D118521990BA45983357A8938FF03_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetGoalWeightPosition_mB2A22B5F388D118521990BA45983357A8938FF03_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetGoalWeightPosition(UnityEngine.AvatarIKGoal,System.Single)");
	_il2cpp_icall_func(__this, ___goal0, ___value1);
}
// System.Single UnityEngine.Animator::GetIKRotationWeight(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetIKRotationWeight_m80A6CBCF9B8E504B2BB8D69B2BF38735D44A09BE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___goal0;
		float L_1;
		L_1 = Animator_GetGoalWeightRotation_mA4349BC8109EA7EC3FD79B64E4410C34001B0CA4(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0012;
	}

IL_0012:
	{
		float L_2 = V_0;
		return L_2;
	}
}
// System.Single UnityEngine.Animator::GetGoalWeightRotation(UnityEngine.AvatarIKGoal)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetGoalWeightRotation_mA4349BC8109EA7EC3FD79B64E4410C34001B0CA4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, const RuntimeMethod* method)
{
	typedef float (*Animator_GetGoalWeightRotation_mA4349BC8109EA7EC3FD79B64E4410C34001B0CA4_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetGoalWeightRotation_mA4349BC8109EA7EC3FD79B64E4410C34001B0CA4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetGoalWeightRotation_mA4349BC8109EA7EC3FD79B64E4410C34001B0CA4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetGoalWeightRotation(UnityEngine.AvatarIKGoal)");
	float icallRetVal = _il2cpp_icall_func(__this, ___goal0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetIKRotationWeight(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKRotationWeight_m380781D1EB25E7221C25F96EE5B99C32407FB8E4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, float ___value1, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___goal0;
		float L_1 = ___value1;
		Animator_SetGoalWeightRotation_mC3BE8A348023FCFE0A616157FC12C5FC50537A2A(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetGoalWeightRotation(UnityEngine.AvatarIKGoal,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalWeightRotation_mC3BE8A348023FCFE0A616157FC12C5FC50537A2A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, float ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetGoalWeightRotation_mC3BE8A348023FCFE0A616157FC12C5FC50537A2A_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float);
	static Animator_SetGoalWeightRotation_mC3BE8A348023FCFE0A616157FC12C5FC50537A2A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetGoalWeightRotation_mC3BE8A348023FCFE0A616157FC12C5FC50537A2A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetGoalWeightRotation(UnityEngine.AvatarIKGoal,System.Single)");
	_il2cpp_icall_func(__this, ___goal0, ___value1);
}
// UnityEngine.Vector3 UnityEngine.Animator::GetIKHintPosition(UnityEngine.AvatarIKHint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_GetIKHintPosition_mF3B1DF12DD553D94037E9D61E772195BF6D4AD26 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___hint0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1;
		L_1 = Animator_GetHintPosition_mDA8C9EEE46FA4F1292C61E5B1A228ECD2D8B4EED(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0012;
	}

IL_0012:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::GetHintPosition(UnityEngine.AvatarIKHint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_GetHintPosition_mDA8C9EEE46FA4F1292C61E5B1A228ECD2D8B4EED (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		int32_t L_0 = ___hint0;
		Animator_GetHintPosition_Injected_m96EC2D942E6D74FC24CA9D60EBBB73AEA1EFCC39(__this, L_0, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::SetIKHintPosition(UnityEngine.AvatarIKHint,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKHintPosition_mB5C20E5F63A7BD2B7142543CE15BDC013AED0159 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___hintPosition1, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___hint0;
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = ___hintPosition1;
		Animator_SetHintPosition_mB865182A27E4D7AA4B101C39A355819BCECAC565(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetHintPosition(UnityEngine.AvatarIKHint,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetHintPosition_mB865182A27E4D7AA4B101C39A355819BCECAC565 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___hintPosition1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___hint0;
		Animator_SetHintPosition_Injected_m743A8699923BB0AF0BB07EF6C8AF04C1CCD1EC17(__this, L_0, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&___hintPosition1), /*hidden argument*/NULL);
		return;
	}
}
// System.Single UnityEngine.Animator::GetIKHintPositionWeight(UnityEngine.AvatarIKHint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetIKHintPositionWeight_mF5E5F82C98593546A8C5FCE02B006D1A2E36FFF6 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___hint0;
		float L_1;
		L_1 = Animator_GetHintWeightPosition_m43790DA28C67149F4F0F1A0A352CF5836CFF8227(__this, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0012;
	}

IL_0012:
	{
		float L_2 = V_0;
		return L_2;
	}
}
// System.Single UnityEngine.Animator::GetHintWeightPosition(UnityEngine.AvatarIKHint)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetHintWeightPosition_m43790DA28C67149F4F0F1A0A352CF5836CFF8227 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, const RuntimeMethod* method)
{
	typedef float (*Animator_GetHintWeightPosition_m43790DA28C67149F4F0F1A0A352CF5836CFF8227_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetHintWeightPosition_m43790DA28C67149F4F0F1A0A352CF5836CFF8227_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetHintWeightPosition_m43790DA28C67149F4F0F1A0A352CF5836CFF8227_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetHintWeightPosition(UnityEngine.AvatarIKHint)");
	float icallRetVal = _il2cpp_icall_func(__this, ___hint0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetIKHintPositionWeight(UnityEngine.AvatarIKHint,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIKHintPositionWeight_m3F4D0AECDA4D35D2C63B6C28976E3C4E4048307C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, float ___value1, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___hint0;
		float L_1 = ___value1;
		Animator_SetHintWeightPosition_m7DC3A766B3816E65669DDF35A963DFD4084CBF5E(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetHintWeightPosition(UnityEngine.AvatarIKHint,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetHintWeightPosition_m7DC3A766B3816E65669DDF35A963DFD4084CBF5E (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, float ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetHintWeightPosition_m7DC3A766B3816E65669DDF35A963DFD4084CBF5E_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float);
	static Animator_SetHintWeightPosition_m7DC3A766B3816E65669DDF35A963DFD4084CBF5E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetHintWeightPosition_m7DC3A766B3816E65669DDF35A963DFD4084CBF5E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetHintWeightPosition(UnityEngine.AvatarIKHint,System.Single)");
	_il2cpp_icall_func(__this, ___hint0, ___value1);
}
// System.Void UnityEngine.Animator::SetLookAtPosition(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPosition_m5B3C7A22E90402E0474B57E794B6488492259669 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___lookAtPosition0, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___lookAtPosition0;
		Animator_SetLookAtPositionInternal_m54D0B2ABC530C6E05989DAB2D8F642BB030BDDEC(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtPositionInternal(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPositionInternal_m54D0B2ABC530C6E05989DAB2D8F642BB030BDDEC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___lookAtPosition0, const RuntimeMethod* method)
{
	{
		Animator_SetLookAtPositionInternal_Injected_mE79031C5471CA6C40B98D6C1654C55D23FEF021C(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&___lookAtPosition0), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeight(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeight_m25108E97120C51A3B8BF6CB4E18D66BB3E196FB1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___weight0, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		float L_0 = ___weight0;
		Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1(__this, L_0, (0.0f), (1.0f), (0.0f), (0.5f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeight(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeight_mEFD01E61C5D0D126C80A5425565DE591FDB0FA1A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___weight0, float ___bodyWeight1, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		float L_0 = ___weight0;
		float L_1 = ___bodyWeight1;
		Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1(__this, L_0, L_1, (1.0f), (0.0f), (0.5f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeight(System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeight_m7DE17A9E1CFFB7C6C63F5280D9F76A445A96CB5F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___weight0, float ___bodyWeight1, float ___headWeight2, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		float L_0 = ___weight0;
		float L_1 = ___bodyWeight1;
		float L_2 = ___headWeight2;
		Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1(__this, L_0, L_1, L_2, (0.0f), (0.5f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeight(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeight_mAF22CB8474C13DAEE2093E9C7A76BE0A044E445B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___weight0, float ___bodyWeight1, float ___headWeight2, float ___eyesWeight3, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		float L_0 = ___weight0;
		float L_1 = ___bodyWeight1;
		float L_2 = ___headWeight2;
		float L_3 = ___eyesWeight3;
		Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1(__this, L_0, L_1, L_2, L_3, (0.5f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeight(System.Single,System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeight_m584E072636037D708F20654DDCA97D8B47150F08 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___weight0, float ___bodyWeight1, float ___headWeight2, float ___eyesWeight3, float ___clampWeight4, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		float L_0 = ___weight0;
		float L_1 = ___bodyWeight1;
		float L_2 = ___headWeight2;
		float L_3 = ___eyesWeight3;
		float L_4 = ___clampWeight4;
		Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetLookAtWeightInternal(System.Single,System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___weight0, float ___bodyWeight1, float ___headWeight2, float ___eyesWeight3, float ___clampWeight4, const RuntimeMethod* method)
{
	typedef void (*Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, float, float, float, float, float);
	static Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetLookAtWeightInternal_m98C3C975C22C752FBE94D1A792A3BA76FE27F3D1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetLookAtWeightInternal(System.Single,System.Single,System.Single,System.Single,System.Single)");
	_il2cpp_icall_func(__this, ___weight0, ___bodyWeight1, ___headWeight2, ___eyesWeight3, ___clampWeight4);
}
// System.Void UnityEngine.Animator::SetBoneLocalRotation(UnityEngine.HumanBodyBones,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoneLocalRotation_mD86BB27ED80F2B22818C3CF9BD3EBC4EE257BA70 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___humanBoneId0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___rotation1, const RuntimeMethod* method)
{
	{
		Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___humanBoneId0;
		int32_t L_1;
		L_1 = HumanTrait_GetBoneIndexFromMono_m144C635F3328D73F0EFDAE3203B31537B75E1824(L_0, /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_2 = ___rotation1;
		Animator_SetBoneLocalRotationInternal_m2F65BCDA327433B33029A57B9F8C8812B72320AE(__this, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetBoneLocalRotationInternal(System.Int32,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoneLocalRotationInternal_m2F65BCDA327433B33029A57B9F8C8812B72320AE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___humanBoneId0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___rotation1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___humanBoneId0;
		Animator_SetBoneLocalRotationInternal_Injected_m78B08DD15F6216F850A89A71BD65DC9FDE36AAE7(__this, L_0, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&___rotation1), /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.ScriptableObject UnityEngine.Animator::GetBehaviour(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * Animator_GetBehaviour_mCFA7D37DDDD585DF037C90753700C92AB8A55195 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Type_t * ___type0, const RuntimeMethod* method)
{
	typedef ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * (*Animator_GetBehaviour_mCFA7D37DDDD585DF037C90753700C92AB8A55195_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Type_t *);
	static Animator_GetBehaviour_mCFA7D37DDDD585DF037C90753700C92AB8A55195_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetBehaviour_mCFA7D37DDDD585DF037C90753700C92AB8A55195_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetBehaviour(System.Type)");
	ScriptableObject_t4361E08CEBF052C650D3666C7CEC37EB31DE116A * icallRetVal = _il2cpp_icall_func(__this, ___type0);
	return icallRetVal;
}
// UnityEngine.ScriptableObject[] UnityEngine.Animator::InternalGetBehaviours(System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208* Animator_InternalGetBehaviours_mCFE73688C68166F940906A371C25DF8FD989F139 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Type_t * ___type0, const RuntimeMethod* method)
{
	typedef ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208* (*Animator_InternalGetBehaviours_mCFE73688C68166F940906A371C25DF8FD989F139_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Type_t *);
	static Animator_InternalGetBehaviours_mCFE73688C68166F940906A371C25DF8FD989F139_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_InternalGetBehaviours_mCFE73688C68166F940906A371C25DF8FD989F139_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::InternalGetBehaviours(System.Type)");
	ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208* icallRetVal = _il2cpp_icall_func(__this, ___type0);
	return icallRetVal;
}
// UnityEngine.StateMachineBehaviour[] UnityEngine.Animator::GetBehaviours(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C* Animator_GetBehaviours_m7E5047F382900CCA4628E783F284C7C62DB56DCF (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___fullPathHash0, int32_t ___layerIndex1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F_0_0_0_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Type_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C* V_0 = NULL;
	{
		int32_t L_0 = ___fullPathHash0;
		int32_t L_1 = ___layerIndex1;
		RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  L_2 = { reinterpret_cast<intptr_t> (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_3;
		L_3 = Type_GetTypeFromHandle_m8BB57524FF7F9DB1803BC561D2B3A4DBACEB385E(L_2, /*hidden argument*/NULL);
		ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208* L_4;
		L_4 = Animator_InternalGetBehavioursByKey_mF775E4A33B17ECB795CA1F7837C1964CFD28490A(__this, L_0, L_1, L_3, /*hidden argument*/NULL);
		V_0 = ((StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C*)IsInst((RuntimeObject*)L_4, StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C_il2cpp_TypeInfo_var));
		goto IL_001b;
	}

IL_001b:
	{
		StateMachineBehaviourU5BU5D_tF53CEA4145DE97D8BE911514928EC4D8833FB11C* L_5 = V_0;
		return L_5;
	}
}
// UnityEngine.ScriptableObject[] UnityEngine.Animator::InternalGetBehavioursByKey(System.Int32,System.Int32,System.Type)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208* Animator_InternalGetBehavioursByKey_mF775E4A33B17ECB795CA1F7837C1964CFD28490A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___fullPathHash0, int32_t ___layerIndex1, Type_t * ___type2, const RuntimeMethod* method)
{
	typedef ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208* (*Animator_InternalGetBehavioursByKey_mF775E4A33B17ECB795CA1F7837C1964CFD28490A_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, int32_t, Type_t *);
	static Animator_InternalGetBehavioursByKey_mF775E4A33B17ECB795CA1F7837C1964CFD28490A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_InternalGetBehavioursByKey_mF775E4A33B17ECB795CA1F7837C1964CFD28490A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::InternalGetBehavioursByKey(System.Int32,System.Int32,System.Type)");
	ScriptableObjectU5BU5D_tA5117515D714DD945669F5BAE310FC6F26311208* icallRetVal = _il2cpp_icall_func(__this, ___fullPathHash0, ___layerIndex1, ___type2);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_stabilizeFeet()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_stabilizeFeet_m9B7BA5FAB0ACA1FB398B74DD0C7BE39BA9B2D1ED (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_stabilizeFeet_m9B7BA5FAB0ACA1FB398B74DD0C7BE39BA9B2D1ED_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_stabilizeFeet_m9B7BA5FAB0ACA1FB398B74DD0C7BE39BA9B2D1ED_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_stabilizeFeet_m9B7BA5FAB0ACA1FB398B74DD0C7BE39BA9B2D1ED_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_stabilizeFeet()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_stabilizeFeet(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_stabilizeFeet_m6D1DF4B7EF03A45E7872CE3C3922E927859705C8 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_stabilizeFeet_m6D1DF4B7EF03A45E7872CE3C3922E927859705C8_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_set_stabilizeFeet_m6D1DF4B7EF03A45E7872CE3C3922E927859705C8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_stabilizeFeet_m6D1DF4B7EF03A45E7872CE3C3922E927859705C8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_stabilizeFeet(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Int32 UnityEngine.Animator::get_layerCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_get_layerCount_m9F7ED8546CE9F7A507C88C577919A9C5E4DFE4F6 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_get_layerCount_m9F7ED8546CE9F7A507C88C577919A9C5E4DFE4F6_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_layerCount_m9F7ED8546CE9F7A507C88C577919A9C5E4DFE4F6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_layerCount_m9F7ED8546CE9F7A507C88C577919A9C5E4DFE4F6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_layerCount()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.String UnityEngine.Animator::GetLayerName(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Animator_GetLayerName_mC91656C2D4E1224EB90AF66B498A51D4681AF28C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	typedef String_t* (*Animator_GetLayerName_mC91656C2D4E1224EB90AF66B498A51D4681AF28C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetLayerName_mC91656C2D4E1224EB90AF66B498A51D4681AF28C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetLayerName_mC91656C2D4E1224EB90AF66B498A51D4681AF28C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetLayerName(System.Int32)");
	String_t* icallRetVal = _il2cpp_icall_func(__this, ___layerIndex0);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animator::GetLayerIndex(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetLayerIndex_mF7A3F953A73375F92DF88A4FD442D946D90F0E25 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___layerName0, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_GetLayerIndex_mF7A3F953A73375F92DF88A4FD442D946D90F0E25_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*);
	static Animator_GetLayerIndex_mF7A3F953A73375F92DF88A4FD442D946D90F0E25_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetLayerIndex_mF7A3F953A73375F92DF88A4FD442D946D90F0E25_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetLayerIndex(System.String)");
	int32_t icallRetVal = _il2cpp_icall_func(__this, ___layerName0);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::GetLayerWeight(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetLayerWeight_m0A73AC322BA23FD164856B7FF67A3A0B748A1CF4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	typedef float (*Animator_GetLayerWeight_m0A73AC322BA23FD164856B7FF67A3A0B748A1CF4_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetLayerWeight_m0A73AC322BA23FD164856B7FF67A3A0B748A1CF4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetLayerWeight_m0A73AC322BA23FD164856B7FF67A3A0B748A1CF4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetLayerWeight(System.Int32)");
	float icallRetVal = _il2cpp_icall_func(__this, ___layerIndex0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetLayerWeight(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLayerWeight_mFC527EAF68AAA25156B5A5B838FB9AB7231DDDF7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, float ___weight1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetLayerWeight_mFC527EAF68AAA25156B5A5B838FB9AB7231DDDF7_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float);
	static Animator_SetLayerWeight_mFC527EAF68AAA25156B5A5B838FB9AB7231DDDF7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetLayerWeight_mFC527EAF68AAA25156B5A5B838FB9AB7231DDDF7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetLayerWeight(System.Int32,System.Single)");
	_il2cpp_icall_func(__this, ___layerIndex0, ___weight1);
}
// System.Void UnityEngine.Animator::GetAnimatorStateInfo(System.Int32,UnityEngine.StateInfoIndex,UnityEngine.AnimatorStateInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorStateInfo_m623172399D38470B4C5EB7DE06A3106AB6958657 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, int32_t ___stateInfoIndex1, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * ___info2, const RuntimeMethod* method)
{
	typedef void (*Animator_GetAnimatorStateInfo_m623172399D38470B4C5EB7DE06A3106AB6958657_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, int32_t, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *);
	static Animator_GetAnimatorStateInfo_m623172399D38470B4C5EB7DE06A3106AB6958657_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetAnimatorStateInfo_m623172399D38470B4C5EB7DE06A3106AB6958657_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetAnimatorStateInfo(System.Int32,UnityEngine.StateInfoIndex,UnityEngine.AnimatorStateInfo&)");
	_il2cpp_icall_func(__this, ___layerIndex0, ___stateInfoIndex1, ___info2);
}
// UnityEngine.AnimatorStateInfo UnityEngine.Animator::GetCurrentAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  Animator_GetCurrentAnimatorStateInfo_m562250C74BF8C626B5227FE840D6CB739B5F8314 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = ___layerIndex0;
		Animator_GetAnimatorStateInfo_m623172399D38470B4C5EB7DE06A3106AB6958657(__this, L_0, 0, (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *)(&V_0), /*hidden argument*/NULL);
		AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  L_1 = V_0;
		V_1 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  L_2 = V_1;
		return L_2;
	}
}
// UnityEngine.AnimatorStateInfo UnityEngine.Animator::GetNextAnimatorStateInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  Animator_GetNextAnimatorStateInfo_m0CE4DD9BD652C6C8C691C308FF86ACF650A91C62 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = ___layerIndex0;
		Animator_GetAnimatorStateInfo_m623172399D38470B4C5EB7DE06A3106AB6958657(__this, L_0, 1, (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *)(&V_0), /*hidden argument*/NULL);
		AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  L_1 = V_0;
		V_1 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  L_2 = V_1;
		return L_2;
	}
}
// System.Void UnityEngine.Animator::GetAnimatorTransitionInfo(System.Int32,UnityEngine.AnimatorTransitionInfo&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorTransitionInfo_mBB68CA61A21C4D60B1109815CC4353628B428472 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0 * ___info1, const RuntimeMethod* method)
{
	typedef void (*Animator_GetAnimatorTransitionInfo_mBB68CA61A21C4D60B1109815CC4353628B428472_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0 *);
	static Animator_GetAnimatorTransitionInfo_mBB68CA61A21C4D60B1109815CC4353628B428472_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetAnimatorTransitionInfo_mBB68CA61A21C4D60B1109815CC4353628B428472_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetAnimatorTransitionInfo(System.Int32,UnityEngine.AnimatorTransitionInfo&)");
	_il2cpp_icall_func(__this, ___layerIndex0, ___info1);
}
// UnityEngine.AnimatorTransitionInfo UnityEngine.Animator::GetAnimatorTransitionInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0  Animator_GetAnimatorTransitionInfo_m1DE4BF583787BA1EFD2255C2DD0E3B157808CA16 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0  V_0;
	memset((&V_0), 0, sizeof(V_0));
	AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		int32_t L_0 = ___layerIndex0;
		Animator_GetAnimatorTransitionInfo_mBB68CA61A21C4D60B1109815CC4353628B428472(__this, L_0, (AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0 *)(&V_0), /*hidden argument*/NULL);
		AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0  L_1 = V_0;
		V_1 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0  L_2 = V_1;
		return L_2;
	}
}
// System.Int32 UnityEngine.Animator::GetAnimatorClipInfoCount(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetAnimatorClipInfoCount_m80A50EDDEAFD721E18702F7F0706552A3C883D3B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, bool ___current1, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_GetAnimatorClipInfoCount_m80A50EDDEAFD721E18702F7F0706552A3C883D3B_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, bool);
	static Animator_GetAnimatorClipInfoCount_m80A50EDDEAFD721E18702F7F0706552A3C883D3B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetAnimatorClipInfoCount_m80A50EDDEAFD721E18702F7F0706552A3C883D3B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetAnimatorClipInfoCount(System.Int32,System.Boolean)");
	int32_t icallRetVal = _il2cpp_icall_func(__this, ___layerIndex0, ___current1);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animator::GetCurrentAnimatorClipInfoCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetCurrentAnimatorClipInfoCount_m966D03992968F33EAA0EC9456AE60E18424621BE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___layerIndex0;
		int32_t L_1;
		L_1 = Animator_GetAnimatorClipInfoCount_m80A50EDDEAFD721E18702F7F0706552A3C883D3B(__this, L_0, (bool)1, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Int32 UnityEngine.Animator::GetNextAnimatorClipInfoCount(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetNextAnimatorClipInfoCount_mB69FE8373F6D7BD95162DB6A583818DD24C83A02 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___layerIndex0;
		int32_t L_1;
		L_1 = Animator_GetAnimatorClipInfoCount_m80A50EDDEAFD721E18702F7F0706552A3C883D3B(__this, L_0, (bool)0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animator::GetCurrentAnimatorClipInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* Animator_GetCurrentAnimatorClipInfo_m03540FE5542A41B213B202CD48D429044E1B8A5A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	typedef AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* (*Animator_GetCurrentAnimatorClipInfo_m03540FE5542A41B213B202CD48D429044E1B8A5A_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetCurrentAnimatorClipInfo_m03540FE5542A41B213B202CD48D429044E1B8A5A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetCurrentAnimatorClipInfo_m03540FE5542A41B213B202CD48D429044E1B8A5A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetCurrentAnimatorClipInfo(System.Int32)");
	AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* icallRetVal = _il2cpp_icall_func(__this, ___layerIndex0);
	return icallRetVal;
}
// UnityEngine.AnimatorClipInfo[] UnityEngine.Animator::GetNextAnimatorClipInfo(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* Animator_GetNextAnimatorClipInfo_m13AF58744D99C39E30EE5119AD62A2FA4F40A85C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	typedef AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* (*Animator_GetNextAnimatorClipInfo_m13AF58744D99C39E30EE5119AD62A2FA4F40A85C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetNextAnimatorClipInfo_m13AF58744D99C39E30EE5119AD62A2FA4F40A85C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetNextAnimatorClipInfo_m13AF58744D99C39E30EE5119AD62A2FA4F40A85C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetNextAnimatorClipInfo(System.Int32)");
	AnimatorClipInfoU5BU5D_tCB3D927F30A1769FAEA216264EE98EFFDA4E5DF2* icallRetVal = _il2cpp_icall_func(__this, ___layerIndex0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::GetCurrentAnimatorClipInfo(System.Int32,System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetCurrentAnimatorClipInfo_mA1061569ED175C2B54A3273EDB889E9D48DE5A2C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02 * ___clips1, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02 * L_0 = ___clips1;
		V_0 = (bool)((((RuntimeObject*)(List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB * L_2 = (ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m81AB157B93BFE2FBFDB08B88F84B444293042F97(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral05ACCFE2F05290DF031B27B4C6B2AD1DC43CCDC6)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Animator_GetCurrentAnimatorClipInfo_mA1061569ED175C2B54A3273EDB889E9D48DE5A2C_RuntimeMethod_var)));
	}

IL_0014:
	{
		int32_t L_3 = ___layerIndex0;
		List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02 * L_4 = ___clips1;
		Animator_GetAnimatorClipInfoInternal_m7369503B85FAE6630B97209D4F3A7492BD31EA39(__this, L_3, (bool)1, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::GetAnimatorClipInfoInternal(System.Int32,System.Boolean,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetAnimatorClipInfoInternal_m7369503B85FAE6630B97209D4F3A7492BD31EA39 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, bool ___isCurrent1, RuntimeObject * ___clips2, const RuntimeMethod* method)
{
	typedef void (*Animator_GetAnimatorClipInfoInternal_m7369503B85FAE6630B97209D4F3A7492BD31EA39_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, bool, RuntimeObject *);
	static Animator_GetAnimatorClipInfoInternal_m7369503B85FAE6630B97209D4F3A7492BD31EA39_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetAnimatorClipInfoInternal_m7369503B85FAE6630B97209D4F3A7492BD31EA39_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetAnimatorClipInfoInternal(System.Int32,System.Boolean,System.Object)");
	_il2cpp_icall_func(__this, ___layerIndex0, ___isCurrent1, ___clips2);
}
// System.Void UnityEngine.Animator::GetNextAnimatorClipInfo(System.Int32,System.Collections.Generic.List`1<UnityEngine.AnimatorClipInfo>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetNextAnimatorClipInfo_mB5F0367EAC2C788CD5DB486C511B4F783339C066 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02 * ___clips1, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02 * L_0 = ___clips1;
		V_0 = (bool)((((RuntimeObject*)(List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02 *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0014;
		}
	}
	{
		ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB * L_2 = (ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_tFB5C4621957BC53A7D1B4FDD5C38B4D6E15DB8FB_il2cpp_TypeInfo_var)));
		ArgumentNullException__ctor_m81AB157B93BFE2FBFDB08B88F84B444293042F97(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral05ACCFE2F05290DF031B27B4C6B2AD1DC43CCDC6)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Animator_GetNextAnimatorClipInfo_mB5F0367EAC2C788CD5DB486C511B4F783339C066_RuntimeMethod_var)));
	}

IL_0014:
	{
		int32_t L_3 = ___layerIndex0;
		List_1_tFD5457606E54246517398ECF87FE9CDB5915BA02 * L_4 = ___clips1;
		Animator_GetAnimatorClipInfoInternal_m7369503B85FAE6630B97209D4F3A7492BD31EA39(__this, L_3, (bool)0, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean UnityEngine.Animator::IsInTransition(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsInTransition_mA37A7575AA127459175230011F2BA7560E0E44B9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	typedef bool (*Animator_IsInTransition_mA37A7575AA127459175230011F2BA7560E0E44B9_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_IsInTransition_mA37A7575AA127459175230011F2BA7560E0E44B9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_IsInTransition_mA37A7575AA127459175230011F2BA7560E0E44B9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::IsInTransition(System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___layerIndex0);
	return icallRetVal;
}
// UnityEngine.AnimatorControllerParameter[] UnityEngine.Animator::get_parameters()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* Animator_get_parameters_m77F06017E5D918C35FEB6A60B4A78E97DFB81CCA (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* (*Animator_get_parameters_m77F06017E5D918C35FEB6A60B4A78E97DFB81CCA_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_parameters_m77F06017E5D918C35FEB6A60B4A78E97DFB81CCA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_parameters_m77F06017E5D918C35FEB6A60B4A78E97DFB81CCA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_parameters()");
	AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animator::get_parameterCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_get_parameterCount_m87FC9BB7A51F40CFC666600392693821DA5114EB (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_get_parameterCount_m87FC9BB7A51F40CFC666600392693821DA5114EB_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_parameterCount_m87FC9BB7A51F40CFC666600392693821DA5114EB_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_parameterCount_m87FC9BB7A51F40CFC666600392693821DA5114EB_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_parameterCount()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.AnimatorControllerParameter UnityEngine.Animator::GetParameter(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * Animator_GetParameter_m8E2B8351264BE835BDAE9B6CCB6C99FCB197760D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* V_0 = NULL;
	bool V_1 = false;
	int32_t V_2 = 0;
	AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * V_3 = NULL;
	int32_t G_B3_0 = 0;
	{
		AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* L_0;
		L_0 = Animator_get_parameters_m77F06017E5D918C35FEB6A60B4A78E97DFB81CCA(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		int32_t L_1 = ___index0;
		if ((((int32_t)L_1) < ((int32_t)0)))
		{
			goto IL_001c;
		}
	}
	{
		int32_t L_2 = ___index0;
		AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* L_3;
		L_3 = Animator_get_parameters_m77F06017E5D918C35FEB6A60B4A78E97DFB81CCA(__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		G_B3_0 = ((((int32_t)((((int32_t)L_2) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_3)->max_length)))))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		goto IL_001d;
	}

IL_001c:
	{
		G_B3_0 = 1;
	}

IL_001d:
	{
		V_1 = (bool)G_B3_0;
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_0041;
		}
	}
	{
		AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* L_5;
		L_5 = Animator_get_parameters_m77F06017E5D918C35FEB6A60B4A78E97DFB81CCA(__this, /*hidden argument*/NULL);
		NullCheck(L_5);
		V_2 = ((int32_t)((int32_t)(((RuntimeArray*)L_5)->max_length)));
		String_t* L_6;
		L_6 = Int32_ToString_m340C0A14D16799421EFDF8A81C8A16FA76D48411((int32_t*)(&V_2), /*hidden argument*/NULL);
		String_t* L_7;
		L_7 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral4A3C80CF84F07DA0E7531332FF2B387B07C77760)), L_6, /*hidden argument*/NULL);
		IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD * L_8 = (IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD_il2cpp_TypeInfo_var)));
		IndexOutOfRangeException__ctor_mC5747EC0E0F49AAD1AD782ACC7A0CCD80D192FEF(L_8, L_7, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_8, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Animator_GetParameter_m8E2B8351264BE835BDAE9B6CCB6C99FCB197760D_RuntimeMethod_var)));
	}

IL_0041:
	{
		AnimatorControllerParameterU5BU5D_t51A7788330152A26BE85C81C904CD9C874598EDE* L_9 = V_0;
		int32_t L_10 = ___index0;
		NullCheck(L_9);
		int32_t L_11 = L_10;
		AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		V_3 = L_12;
		goto IL_0047;
	}

IL_0047:
	{
		AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * L_13 = V_3;
		return L_13;
	}
}
// System.Single UnityEngine.Animator::get_feetPivotActive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_feetPivotActive_m6CA21F6EBD549AD77E402BA49C0C79483D7912F5 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_get_feetPivotActive_m6CA21F6EBD549AD77E402BA49C0C79483D7912F5_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_feetPivotActive_m6CA21F6EBD549AD77E402BA49C0C79483D7912F5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_feetPivotActive_m6CA21F6EBD549AD77E402BA49C0C79483D7912F5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_feetPivotActive()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_feetPivotActive(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_feetPivotActive_mF8D4A6342DB841D3443BBD77D22B829FD93446FA (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_feetPivotActive_mF8D4A6342DB841D3443BBD77D22B829FD93446FA_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, float);
	static Animator_set_feetPivotActive_mF8D4A6342DB841D3443BBD77D22B829FD93446FA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_feetPivotActive_mF8D4A6342DB841D3443BBD77D22B829FD93446FA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_feetPivotActive(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.Animator::get_pivotWeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_pivotWeight_m4B06F8D9056EE40C169E15A469A2D8347FB02F9C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_get_pivotWeight_m4B06F8D9056EE40C169E15A469A2D8347FB02F9C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_pivotWeight_m4B06F8D9056EE40C169E15A469A2D8347FB02F9C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_pivotWeight_m4B06F8D9056EE40C169E15A469A2D8347FB02F9C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_pivotWeight()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.Vector3 UnityEngine.Animator::get_pivotPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_pivotPosition_mCAB4BDF862A2EF28753DF62651B497FD0748BC6D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_pivotPosition_Injected_mAF27659230FFC6425898DD0675CF34D2234677B1(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.Animator::MatchTarget(UnityEngine.Vector3,UnityEngine.Quaternion,System.Int32,UnityEngine.MatchTargetWeightMask,System.Single,System.Single,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_MatchTarget_m2B22003B1CCB0EB766E97D83B3D8C716FEBCDB59 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___matchPosition0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___matchRotation1, int32_t ___targetBodyPart2, MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6  ___weightMask3, float ___startNormalizedTime4, float ___targetNormalizedTime5, bool ___completeMatch6, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___targetBodyPart2;
		float L_1 = ___startNormalizedTime4;
		float L_2 = ___targetNormalizedTime5;
		bool L_3 = ___completeMatch6;
		Animator_MatchTarget_Injected_m82320F2465819561765E195C1DB8E69A8A373A3F(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&___matchPosition0), (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&___matchRotation1), L_0, (MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 *)(&___weightMask3), L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::MatchTarget(UnityEngine.Vector3,UnityEngine.Quaternion,UnityEngine.AvatarTarget,UnityEngine.MatchTargetWeightMask,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_MatchTarget_m971AAC1119AEEB395E51A4C1B8D80579F3242247 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___matchPosition0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___matchRotation1, int32_t ___targetBodyPart2, MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6  ___weightMask3, float ___startNormalizedTime4, const RuntimeMethod* method)
{
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___matchPosition0;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1 = ___matchRotation1;
		int32_t L_2 = ___targetBodyPart2;
		MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6  L_3 = ___weightMask3;
		float L_4 = ___startNormalizedTime4;
		Animator_MatchTarget_m2B22003B1CCB0EB766E97D83B3D8C716FEBCDB59(__this, L_0, L_1, L_2, L_3, L_4, (1.0f), (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::MatchTarget(UnityEngine.Vector3,UnityEngine.Quaternion,UnityEngine.AvatarTarget,UnityEngine.MatchTargetWeightMask,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_MatchTarget_m4157621B169D7A60A380308DDE439E4B37BCE86C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___matchPosition0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___matchRotation1, int32_t ___targetBodyPart2, MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6  ___weightMask3, float ___startNormalizedTime4, float ___targetNormalizedTime5, const RuntimeMethod* method)
{
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___matchPosition0;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1 = ___matchRotation1;
		int32_t L_2 = ___targetBodyPart2;
		MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6  L_3 = ___weightMask3;
		float L_4 = ___startNormalizedTime4;
		float L_5 = ___targetNormalizedTime5;
		Animator_MatchTarget_m2B22003B1CCB0EB766E97D83B3D8C716FEBCDB59(__this, L_0, L_1, L_2, L_3, L_4, L_5, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::MatchTarget(UnityEngine.Vector3,UnityEngine.Quaternion,UnityEngine.AvatarTarget,UnityEngine.MatchTargetWeightMask,System.Single,System.Single,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_MatchTarget_mE7A6D9F2A89DE041B43451AADF81E5E626BB405A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___matchPosition0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___matchRotation1, int32_t ___targetBodyPart2, MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6  ___weightMask3, float ___startNormalizedTime4, float ___targetNormalizedTime5, bool ___completeMatch6, const RuntimeMethod* method)
{
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___matchPosition0;
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1 = ___matchRotation1;
		int32_t L_2 = ___targetBodyPart2;
		MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6  L_3 = ___weightMask3;
		float L_4 = ___startNormalizedTime4;
		float L_5 = ___targetNormalizedTime5;
		bool L_6 = ___completeMatch6;
		Animator_MatchTarget_m2B22003B1CCB0EB766E97D83B3D8C716FEBCDB59(__this, L_0, L_1, L_2, L_3, L_4, L_5, L_6, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::InterruptMatchTarget()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_InterruptMatchTarget_mBB631EE45EA571C3187A4AA38D215485659AB1F2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	{
		Animator_InterruptMatchTarget_m84B1E5334849D1BA1FF7E7A80D059DCC075AE070(__this, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::InterruptMatchTarget(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_InterruptMatchTarget_m84B1E5334849D1BA1FF7E7A80D059DCC075AE070 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___completeMatch0, const RuntimeMethod* method)
{
	typedef void (*Animator_InterruptMatchTarget_m84B1E5334849D1BA1FF7E7A80D059DCC075AE070_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_InterruptMatchTarget_m84B1E5334849D1BA1FF7E7A80D059DCC075AE070_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_InterruptMatchTarget_m84B1E5334849D1BA1FF7E7A80D059DCC075AE070_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::InterruptMatchTarget(System.Boolean)");
	_il2cpp_icall_func(__this, ___completeMatch0);
}
// System.Boolean UnityEngine.Animator::get_isMatchingTarget()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_isMatchingTarget_mE372DC28927FCA3DBF69AA3A4BCECFECEE9505E4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_isMatchingTarget_mE372DC28927FCA3DBF69AA3A4BCECFECEE9505E4_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_isMatchingTarget_mE372DC28927FCA3DBF69AA3A4BCECFECEE9505E4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_isMatchingTarget_mE372DC28927FCA3DBF69AA3A4BCECFECEE9505E4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_isMatchingTarget()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::get_speed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_speed_mA1E16FD07760F406F4415BB55648A87711E5BA1F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_get_speed_mA1E16FD07760F406F4415BB55648A87711E5BA1F_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_speed_mA1E16FD07760F406F4415BB55648A87711E5BA1F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_speed_mA1E16FD07760F406F4415BB55648A87711E5BA1F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_speed()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_speed(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_speed_m632FF62E0D6B668C55190B3579B12684316C4041 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_speed_m632FF62E0D6B668C55190B3579B12684316C4041_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, float);
	static Animator_set_speed_m632FF62E0D6B668C55190B3579B12684316C4041_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_speed_m632FF62E0D6B668C55190B3579B12684316C4041_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_speed(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Animator::ForceStateNormalizedTime(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ForceStateNormalizedTime_mE1298A09C1AE4432DC0927B586B635D4BF7040C1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___normalizedTime0, const RuntimeMethod* method)
{
	{
		float L_0 = ___normalizedTime0;
		Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC(__this, 0, 0, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_m424EE9ABD82B06A3D950A538E6A61FA55ECC654B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___fixedTransitionDuration1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	int32_t V_2 = 0;
	{
		V_0 = (0.0f);
		V_1 = (0.0f);
		V_2 = (-1);
		String_t* L_0 = ___stateName0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		float L_2 = ___fixedTransitionDuration1;
		int32_t L_3 = V_2;
		float L_4 = V_1;
		float L_5 = V_0;
		Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D(__this, L_1, L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.String,System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_m33DC76C4B1093476C2A1B03F89E19DFB2B5BC715 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___fixedTransitionDuration1, int32_t ___layer2, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		V_0 = (0.0f);
		V_1 = (0.0f);
		String_t* L_0 = ___stateName0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		float L_2 = ___fixedTransitionDuration1;
		int32_t L_3 = ___layer2;
		float L_4 = V_1;
		float L_5 = V_0;
		Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D(__this, L_1, L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.String,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_mFE2D1DA6620023A256FB1595DF67496640502863 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___fixedTransitionDuration1, int32_t ___layer2, float ___fixedTimeOffset3, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		V_0 = (0.0f);
		String_t* L_0 = ___stateName0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		float L_2 = ___fixedTransitionDuration1;
		int32_t L_3 = ___layer2;
		float L_4 = ___fixedTimeOffset3;
		float L_5 = V_0;
		Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D(__this, L_1, L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.String,System.Single,System.Int32,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_m434C4B6B2A185D1FFE1D2224111B7C96B77A326B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___fixedTransitionDuration1, int32_t ___layer2, float ___fixedTimeOffset3, float ___normalizedTransitionTime4, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___stateName0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		float L_2 = ___fixedTransitionDuration1;
		int32_t L_3 = ___layer2;
		float L_4 = ___fixedTimeOffset3;
		float L_5 = ___normalizedTransitionTime4;
		Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D(__this, L_1, L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_mE139BAAF811C1520EAC0BB6F134B103DF539AA8A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___fixedTransitionDuration1, int32_t ___layer2, float ___fixedTimeOffset3, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		V_0 = (0.0f);
		int32_t L_0 = ___stateHashName0;
		float L_1 = ___fixedTransitionDuration1;
		int32_t L_2 = ___layer2;
		float L_3 = ___fixedTimeOffset3;
		float L_4 = V_0;
		Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.Int32,System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_m0D59107DC818752517248BAEE0CE8CAE782E4F28 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___fixedTransitionDuration1, int32_t ___layer2, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		V_0 = (0.0f);
		V_1 = (0.0f);
		int32_t L_0 = ___stateHashName0;
		float L_1 = ___fixedTransitionDuration1;
		int32_t L_2 = ___layer2;
		float L_3 = V_1;
		float L_4 = V_0;
		Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_m761C4B8B992EF9E9A6A954C49DFF19CAB1E6F7D2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___fixedTransitionDuration1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	int32_t V_2 = 0;
	{
		V_0 = (0.0f);
		V_1 = (0.0f);
		V_2 = (-1);
		int32_t L_0 = ___stateHashName0;
		float L_1 = ___fixedTransitionDuration1;
		int32_t L_2 = V_2;
		float L_3 = V_1;
		float L_4 = V_0;
		Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFadeInFixedTime(System.Int32,System.Single,System.Int32,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___fixedTransitionDuration1, int32_t ___layer2, float ___fixedTimeOffset3, float ___normalizedTransitionTime4, const RuntimeMethod* method)
{
	typedef void (*Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float, int32_t, float, float);
	static Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_CrossFadeInFixedTime_mD90D5AC918701FD8F6236CE367A61CA06AE7723D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::CrossFadeInFixedTime(System.Int32,System.Single,System.Int32,System.Single,System.Single)");
	_il2cpp_icall_func(__this, ___stateHashName0, ___fixedTransitionDuration1, ___layer2, ___fixedTimeOffset3, ___normalizedTransitionTime4);
}
// System.Void UnityEngine.Animator::WriteDefaultValues()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_WriteDefaultValues_mFAF0A763218017E0B5EBE9B0DBBA0A646453F376 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_WriteDefaultValues_mFAF0A763218017E0B5EBE9B0DBBA0A646453F376_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_WriteDefaultValues_mFAF0A763218017E0B5EBE9B0DBBA0A646453F376_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_WriteDefaultValues_mFAF0A763218017E0B5EBE9B0DBBA0A646453F376_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::WriteDefaultValues()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.Animator::CrossFade(System.String,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_m888FD817F446F17812B021743F3BB0E5EA63F36E (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___normalizedTransitionDuration1, int32_t ___layer2, float ___normalizedTimeOffset3, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		V_0 = (0.0f);
		String_t* L_0 = ___stateName0;
		float L_1 = ___normalizedTransitionDuration1;
		int32_t L_2 = ___layer2;
		float L_3 = ___normalizedTimeOffset3;
		float L_4 = V_0;
		Animator_CrossFade_mDD4CB6DEED448B3324562943FBA1A64E2E437B8B(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFade(System.String,System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_mCABB44DAAF8A29E68B9F5B2AC1339D3813215B05 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___normalizedTransitionDuration1, int32_t ___layer2, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		V_0 = (0.0f);
		V_1 = (-std::numeric_limits<float>::infinity());
		String_t* L_0 = ___stateName0;
		float L_1 = ___normalizedTransitionDuration1;
		int32_t L_2 = ___layer2;
		float L_3 = V_1;
		float L_4 = V_0;
		Animator_CrossFade_mDD4CB6DEED448B3324562943FBA1A64E2E437B8B(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFade(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_mD3F99D6835AA415C0B32AE0C574B1815CC07586F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___normalizedTransitionDuration1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	int32_t V_2 = 0;
	{
		V_0 = (0.0f);
		V_1 = (-std::numeric_limits<float>::infinity());
		V_2 = (-1);
		String_t* L_0 = ___stateName0;
		float L_1 = ___normalizedTransitionDuration1;
		int32_t L_2 = V_2;
		float L_3 = V_1;
		float L_4 = V_0;
		Animator_CrossFade_mDD4CB6DEED448B3324562943FBA1A64E2E437B8B(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFade(System.String,System.Single,System.Int32,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_mDD4CB6DEED448B3324562943FBA1A64E2E437B8B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, float ___normalizedTransitionDuration1, int32_t ___layer2, float ___normalizedTimeOffset3, float ___normalizedTransitionTime4, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___stateName0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		float L_2 = ___normalizedTransitionDuration1;
		int32_t L_3 = ___layer2;
		float L_4 = ___normalizedTimeOffset3;
		float L_5 = ___normalizedTransitionTime4;
		Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79(__this, L_1, L_2, L_3, L_4, L_5, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFade(System.Int32,System.Single,System.Int32,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___normalizedTransitionDuration1, int32_t ___layer2, float ___normalizedTimeOffset3, float ___normalizedTransitionTime4, const RuntimeMethod* method)
{
	typedef void (*Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float, int32_t, float, float);
	static Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::CrossFade(System.Int32,System.Single,System.Int32,System.Single,System.Single)");
	_il2cpp_icall_func(__this, ___stateHashName0, ___normalizedTransitionDuration1, ___layer2, ___normalizedTimeOffset3, ___normalizedTransitionTime4);
}
// System.Void UnityEngine.Animator::CrossFade(System.Int32,System.Single,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_mAB3A46ABAA9A19893D6712BA6067C51F9873530F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___normalizedTransitionDuration1, int32_t ___layer2, float ___normalizedTimeOffset3, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		V_0 = (0.0f);
		int32_t L_0 = ___stateHashName0;
		float L_1 = ___normalizedTransitionDuration1;
		int32_t L_2 = ___layer2;
		float L_3 = ___normalizedTimeOffset3;
		float L_4 = V_0;
		Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFade(System.Int32,System.Single,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_m040133A44CF8514112953534556190C9B29B9969 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___normalizedTransitionDuration1, int32_t ___layer2, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	{
		V_0 = (0.0f);
		V_1 = (-std::numeric_limits<float>::infinity());
		int32_t L_0 = ___stateHashName0;
		float L_1 = ___normalizedTransitionDuration1;
		int32_t L_2 = ___layer2;
		float L_3 = V_1;
		float L_4 = V_0;
		Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::CrossFade(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CrossFade_m7978A6EF8133D3511D5D66D755DA26B474C9C119 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateHashName0, float ___normalizedTransitionDuration1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	int32_t V_2 = 0;
	{
		V_0 = (0.0f);
		V_1 = (-std::numeric_limits<float>::infinity());
		V_2 = (-1);
		int32_t L_0 = ___stateHashName0;
		float L_1 = ___normalizedTransitionDuration1;
		int32_t L_2 = V_2;
		float L_3 = V_1;
		float L_4 = V_0;
		Animator_CrossFade_m982460E106F477EF16DE314851BF7467F966EC79(__this, L_0, L_1, L_2, L_3, L_4, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::PlayInFixedTime(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_PlayInFixedTime_mE7814F64498D4E96CE6BEC49CDF9CE700E2E8994 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, int32_t ___layer1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		V_0 = (-std::numeric_limits<float>::infinity());
		String_t* L_0 = ___stateName0;
		int32_t L_1 = ___layer1;
		float L_2 = V_0;
		Animator_PlayInFixedTime_m0CDAEF81DD585E705E54D1B5621209E9C68407DD(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::PlayInFixedTime(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_PlayInFixedTime_mF2581A596A6576B227ED6AFCC6A871D6792816B4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	int32_t V_1 = 0;
	{
		V_0 = (-std::numeric_limits<float>::infinity());
		V_1 = (-1);
		String_t* L_0 = ___stateName0;
		int32_t L_1 = V_1;
		float L_2 = V_0;
		Animator_PlayInFixedTime_m0CDAEF81DD585E705E54D1B5621209E9C68407DD(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::PlayInFixedTime(System.String,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_PlayInFixedTime_m0CDAEF81DD585E705E54D1B5621209E9C68407DD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, int32_t ___layer1, float ___fixedTime2, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___stateName0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		int32_t L_2 = ___layer1;
		float L_3 = ___fixedTime2;
		Animator_PlayInFixedTime_mB532E778E6810C115C70B824DAD7D562434DB0AA(__this, L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::PlayInFixedTime(System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_PlayInFixedTime_mB532E778E6810C115C70B824DAD7D562434DB0AA (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateNameHash0, int32_t ___layer1, float ___fixedTime2, const RuntimeMethod* method)
{
	typedef void (*Animator_PlayInFixedTime_mB532E778E6810C115C70B824DAD7D562434DB0AA_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, int32_t, float);
	static Animator_PlayInFixedTime_mB532E778E6810C115C70B824DAD7D562434DB0AA_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_PlayInFixedTime_mB532E778E6810C115C70B824DAD7D562434DB0AA_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::PlayInFixedTime(System.Int32,System.Int32,System.Single)");
	_il2cpp_icall_func(__this, ___stateNameHash0, ___layer1, ___fixedTime2);
}
// System.Void UnityEngine.Animator::PlayInFixedTime(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_PlayInFixedTime_m50B5A1DAF0A1593B99572723A538F2787B7BA11F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateNameHash0, int32_t ___layer1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		V_0 = (-std::numeric_limits<float>::infinity());
		int32_t L_0 = ___stateNameHash0;
		int32_t L_1 = ___layer1;
		float L_2 = V_0;
		Animator_PlayInFixedTime_mB532E778E6810C115C70B824DAD7D562434DB0AA(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::PlayInFixedTime(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_PlayInFixedTime_m75C717E8A724CDFD113CEDD97206636BC204BFFB (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateNameHash0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	int32_t V_1 = 0;
	{
		V_0 = (-std::numeric_limits<float>::infinity());
		V_1 = (-1);
		int32_t L_0 = ___stateNameHash0;
		int32_t L_1 = V_1;
		float L_2 = V_0;
		Animator_PlayInFixedTime_mB532E778E6810C115C70B824DAD7D562434DB0AA(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::Play(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_m0DA9FB39D07A4F52CDCE8AE53719AF3B71845E11 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, int32_t ___layer1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		V_0 = (-std::numeric_limits<float>::infinity());
		String_t* L_0 = ___stateName0;
		int32_t L_1 = ___layer1;
		float L_2 = V_0;
		Animator_Play_m1438EDACA2804B50ED0D00D9986E30BCF903418B(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::Play(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_mE5E8B1753FFDF754EAD1ACEFF6C5B6ACA506363C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	int32_t V_1 = 0;
	{
		V_0 = (-std::numeric_limits<float>::infinity());
		V_1 = (-1);
		String_t* L_0 = ___stateName0;
		int32_t L_1 = V_1;
		float L_2 = V_0;
		Animator_Play_m1438EDACA2804B50ED0D00D9986E30BCF903418B(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::Play(System.String,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_m1438EDACA2804B50ED0D00D9986E30BCF903418B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___stateName0, int32_t ___layer1, float ___normalizedTime2, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___stateName0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		int32_t L_2 = ___layer1;
		float L_3 = ___normalizedTime2;
		Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC(__this, L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::Play(System.Int32,System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateNameHash0, int32_t ___layer1, float ___normalizedTime2, const RuntimeMethod* method)
{
	typedef void (*Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, int32_t, float);
	static Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::Play(System.Int32,System.Int32,System.Single)");
	_il2cpp_icall_func(__this, ___stateNameHash0, ___layer1, ___normalizedTime2);
}
// System.Void UnityEngine.Animator::Play(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_m2A4173AA96F3B9831609BBE54681E1CD6A83EDE7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateNameHash0, int32_t ___layer1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		V_0 = (-std::numeric_limits<float>::infinity());
		int32_t L_0 = ___stateNameHash0;
		int32_t L_1 = ___layer1;
		float L_2 = V_0;
		Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::Play(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Play_mF5974D135CFF4321BA1C6BBAE2543EDFDE11B348 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___stateNameHash0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	int32_t V_1 = 0;
	{
		V_0 = (-std::numeric_limits<float>::infinity());
		V_1 = (-1);
		int32_t L_0 = ___stateNameHash0;
		int32_t L_1 = V_1;
		float L_2 = V_0;
		Animator_Play_m392289975B858ED7D85DF6E7980E5BA47F606AEC(__this, L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::SetTarget(UnityEngine.AvatarTarget,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTarget_m60BFA8C1D8CF9737C6B5392EBC7581A31E65799F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___targetIndex0, float ___targetNormalizedTime1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetTarget_m60BFA8C1D8CF9737C6B5392EBC7581A31E65799F_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float);
	static Animator_SetTarget_m60BFA8C1D8CF9737C6B5392EBC7581A31E65799F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetTarget_m60BFA8C1D8CF9737C6B5392EBC7581A31E65799F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetTarget(UnityEngine.AvatarTarget,System.Single)");
	_il2cpp_icall_func(__this, ___targetIndex0, ___targetNormalizedTime1);
}
// UnityEngine.Vector3 UnityEngine.Animator::get_targetPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_get_targetPosition_mBEFCDF42E6B32F40A8416EDD5F016DB39B0CF8C9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_targetPosition_Injected_m8DD5663D05D4E687B3B8FD3C88FF936D94D6B729(__this, (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_0), /*hidden argument*/NULL);
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = V_0;
		return L_0;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::get_targetRotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_get_targetRotation_m85AD531DC842A49A4D179D50A36F44A0FB995B2C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Animator_get_targetRotation_Injected_m95B6C40BDD6E4972C5FB4F896D6DEF6519FCCA41(__this, (Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *)(&V_0), /*hidden argument*/NULL);
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_0 = V_0;
		return L_0;
	}
}
// System.Boolean UnityEngine.Animator::IsControlled(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsControlled_mEBBB9FD73D076D1350175CB17034CB604435B353 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___transform0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		V_0 = (bool)0;
		goto IL_0005;
	}

IL_0005:
	{
		bool L_0 = V_0;
		return L_0;
	}
}
// System.Boolean UnityEngine.Animator::IsBoneTransform(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsBoneTransform_m766403AB146E7B2F87A3003F43246D1697C16FEE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * ___transform0, const RuntimeMethod* method)
{
	typedef bool (*Animator_IsBoneTransform_m766403AB146E7B2F87A3003F43246D1697C16FEE_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 *);
	static Animator_IsBoneTransform_m766403AB146E7B2F87A3003F43246D1697C16FEE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_IsBoneTransform_m766403AB146E7B2F87A3003F43246D1697C16FEE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::IsBoneTransform(UnityEngine.Transform)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___transform0);
	return icallRetVal;
}
// UnityEngine.Transform UnityEngine.Animator::get_avatarRoot()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Animator_get_avatarRoot_mDFC549ACF1820DD8022C888B24677DE02217B99A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * (*Animator_get_avatarRoot_mDFC549ACF1820DD8022C888B24677DE02217B99A_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_avatarRoot_mDFC549ACF1820DD8022C888B24677DE02217B99A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_avatarRoot_mDFC549ACF1820DD8022C888B24677DE02217B99A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_avatarRoot()");
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.Transform UnityEngine.Animator::GetBoneTransform(UnityEngine.HumanBodyBones)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Animator_GetBoneTransform_mE35B1880DB371D4BB7254ECB45BF25ABEE18DD70 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___humanBoneId0, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t V_1 = 0;
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * V_2 = NULL;
	int32_t G_B3_0 = 0;
	{
		int32_t L_0 = ___humanBoneId0;
		if ((((int32_t)L_0) < ((int32_t)0)))
		{
			goto IL_000f;
		}
	}
	{
		int32_t L_1 = ___humanBoneId0;
		G_B3_0 = ((((int32_t)((((int32_t)L_1) < ((int32_t)((int32_t)55)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
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
			goto IL_0034;
		}
	}
	{
		V_1 = ((int32_t)55);
		RuntimeObject * L_3 = Box(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&HumanBodyBones_tFB48F983A3FDC35E822852C22003086FF9BB4087_il2cpp_TypeInfo_var)), (&V_1));
		NullCheck(L_3);
		String_t* L_4;
		L_4 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_3);
		V_1 = *(int32_t*)UnBox(L_3);
		String_t* L_5;
		L_5 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral00F97321929E0D7989E72D633D157BD761DD173A)), L_4, /*hidden argument*/NULL);
		IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD * L_6 = (IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&IndexOutOfRangeException_tDC9EF7A0346CE39E54DA1083F07BE6DFC3CE2EDD_il2cpp_TypeInfo_var)));
		IndexOutOfRangeException__ctor_mC5747EC0E0F49AAD1AD782ACC7A0CCD80D192FEF(L_6, L_5, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_6, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Animator_GetBoneTransform_mE35B1880DB371D4BB7254ECB45BF25ABEE18DD70_RuntimeMethod_var)));
	}

IL_0034:
	{
		int32_t L_7 = ___humanBoneId0;
		int32_t L_8;
		L_8 = HumanTrait_GetBoneIndexFromMono_m144C635F3328D73F0EFDAE3203B31537B75E1824(L_7, /*hidden argument*/NULL);
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_9;
		L_9 = Animator_GetBoneTransformInternal_mA7FFA1587D3C3ABE27901D845E71765444F13F74(__this, L_8, /*hidden argument*/NULL);
		V_2 = L_9;
		goto IL_0043;
	}

IL_0043:
	{
		Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * L_10 = V_2;
		return L_10;
	}
}
// UnityEngine.Transform UnityEngine.Animator::GetBoneTransformInternal(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * Animator_GetBoneTransformInternal_mA7FFA1587D3C3ABE27901D845E71765444F13F74 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___humanBoneId0, const RuntimeMethod* method)
{
	typedef Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * (*Animator_GetBoneTransformInternal_mA7FFA1587D3C3ABE27901D845E71765444F13F74_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetBoneTransformInternal_mA7FFA1587D3C3ABE27901D845E71765444F13F74_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetBoneTransformInternal_mA7FFA1587D3C3ABE27901D845E71765444F13F74_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetBoneTransformInternal(System.Int32)");
	Transform_tA8193BB29D4D2C7EC04918F3ED1816345186C3F1 * icallRetVal = _il2cpp_icall_func(__this, ___humanBoneId0);
	return icallRetVal;
}
// UnityEngine.AnimatorCullingMode UnityEngine.Animator::get_cullingMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_get_cullingMode_m0030E55044C8F784082DDDEF1BD284D95BA85A00 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_get_cullingMode_m0030E55044C8F784082DDDEF1BD284D95BA85A00_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_cullingMode_m0030E55044C8F784082DDDEF1BD284D95BA85A00_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_cullingMode_m0030E55044C8F784082DDDEF1BD284D95BA85A00_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_cullingMode()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_cullingMode(UnityEngine.AnimatorCullingMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_cullingMode_m55A7D5E441601EFAE60654409111A895470418D4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_cullingMode_m55A7D5E441601EFAE60654409111A895470418D4_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_set_cullingMode_m55A7D5E441601EFAE60654409111A895470418D4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_cullingMode_m55A7D5E441601EFAE60654409111A895470418D4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_cullingMode(UnityEngine.AnimatorCullingMode)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Animator::StartPlayback()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_StartPlayback_m5831CAE85C873A42FCF32C8BB8737B0AD18A2651 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_StartPlayback_m5831CAE85C873A42FCF32C8BB8737B0AD18A2651_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_StartPlayback_m5831CAE85C873A42FCF32C8BB8737B0AD18A2651_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_StartPlayback_m5831CAE85C873A42FCF32C8BB8737B0AD18A2651_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::StartPlayback()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.Animator::StopPlayback()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_StopPlayback_mF2CE1BE910955B2AA7B4490936037EECDC878592 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_StopPlayback_mF2CE1BE910955B2AA7B4490936037EECDC878592_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_StopPlayback_mF2CE1BE910955B2AA7B4490936037EECDC878592_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_StopPlayback_mF2CE1BE910955B2AA7B4490936037EECDC878592_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::StopPlayback()");
	_il2cpp_icall_func(__this);
}
// System.Single UnityEngine.Animator::get_playbackTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_playbackTime_mDE479F1C19EB17EA3B8187851E43E44CA5B7F4A9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_get_playbackTime_mDE479F1C19EB17EA3B8187851E43E44CA5B7F4A9_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_playbackTime_mDE479F1C19EB17EA3B8187851E43E44CA5B7F4A9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_playbackTime_mDE479F1C19EB17EA3B8187851E43E44CA5B7F4A9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_playbackTime()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_playbackTime(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_playbackTime_m09FDF33BBEB5D6BD115827CBD1230107E07DA4FC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_playbackTime_m09FDF33BBEB5D6BD115827CBD1230107E07DA4FC_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, float);
	static Animator_set_playbackTime_m09FDF33BBEB5D6BD115827CBD1230107E07DA4FC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_playbackTime_m09FDF33BBEB5D6BD115827CBD1230107E07DA4FC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_playbackTime(System.Single)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Animator::StartRecording(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_StartRecording_mBB6D5C09883C79EA294BAE20AD5877EDCA37F99A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___frameCount0, const RuntimeMethod* method)
{
	typedef void (*Animator_StartRecording_mBB6D5C09883C79EA294BAE20AD5877EDCA37F99A_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_StartRecording_mBB6D5C09883C79EA294BAE20AD5877EDCA37F99A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_StartRecording_mBB6D5C09883C79EA294BAE20AD5877EDCA37F99A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::StartRecording(System.Int32)");
	_il2cpp_icall_func(__this, ___frameCount0);
}
// System.Void UnityEngine.Animator::StopRecording()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_StopRecording_mCBE3A93F9E5EBCE4A7ADD9586D723DCBD56076CF (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_StopRecording_mCBE3A93F9E5EBCE4A7ADD9586D723DCBD56076CF_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_StopRecording_mCBE3A93F9E5EBCE4A7ADD9586D723DCBD56076CF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_StopRecording_mCBE3A93F9E5EBCE4A7ADD9586D723DCBD56076CF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::StopRecording()");
	_il2cpp_icall_func(__this);
}
// System.Single UnityEngine.Animator::get_recorderStartTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_recorderStartTime_m5F3EF66CA1EA224CA083C607E509B20D1E71EE11 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0;
		L_0 = Animator_GetRecorderStartTime_mBA14285A955EA02ADC65516542147ED919F1272F(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::set_recorderStartTime(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_recorderStartTime_m5F78AF2FDA63567480E37DD159DC91D3C7EC460A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___value0, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Single UnityEngine.Animator::GetRecorderStartTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetRecorderStartTime_mBA14285A955EA02ADC65516542147ED919F1272F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_GetRecorderStartTime_mBA14285A955EA02ADC65516542147ED919F1272F_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_GetRecorderStartTime_mBA14285A955EA02ADC65516542147ED919F1272F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetRecorderStartTime_mBA14285A955EA02ADC65516542147ED919F1272F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetRecorderStartTime()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::get_recorderStopTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_recorderStopTime_mC03584FEF030D53A94EFF839A6A523C6424179B9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0;
		L_0 = Animator_GetRecorderStopTime_mC5F49DAF7CA0C6AB54D1EF7CE0D41FAB4108CB15(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::set_recorderStopTime(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_recorderStopTime_m61BE53B91F6F37B242B95A5DC3E62A1CBD5714A6 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___value0, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Single UnityEngine.Animator::GetRecorderStopTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetRecorderStopTime_mC5F49DAF7CA0C6AB54D1EF7CE0D41FAB4108CB15 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_GetRecorderStopTime_mC5F49DAF7CA0C6AB54D1EF7CE0D41FAB4108CB15_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_GetRecorderStopTime_mC5F49DAF7CA0C6AB54D1EF7CE0D41FAB4108CB15_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetRecorderStopTime_mC5F49DAF7CA0C6AB54D1EF7CE0D41FAB4108CB15_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetRecorderStopTime()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.AnimatorRecorderMode UnityEngine.Animator::get_recorderMode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_get_recorderMode_mC426A9F5CA3379076FB50FA539AE95B1DA5990AC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_get_recorderMode_mC426A9F5CA3379076FB50FA539AE95B1DA5990AC_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_recorderMode_mC426A9F5CA3379076FB50FA539AE95B1DA5990AC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_recorderMode_mC426A9F5CA3379076FB50FA539AE95B1DA5990AC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_recorderMode()");
	int32_t icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.RuntimeAnimatorController UnityEngine.Animator::get_runtimeAnimatorController()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB * Animator_get_runtimeAnimatorController_mA31EAB2AB6CA23B48FA70155CA399DFA2EE525CC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB * (*Animator_get_runtimeAnimatorController_mA31EAB2AB6CA23B48FA70155CA399DFA2EE525CC_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_runtimeAnimatorController_mA31EAB2AB6CA23B48FA70155CA399DFA2EE525CC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_runtimeAnimatorController_mA31EAB2AB6CA23B48FA70155CA399DFA2EE525CC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_runtimeAnimatorController()");
	RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB * icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_runtimeAnimatorController_mF50ED3D400626A3E3FC42BB6F0772A6CADEEC63B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB * ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_runtimeAnimatorController_mF50ED3D400626A3E3FC42BB6F0772A6CADEEC63B_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB *);
	static Animator_set_runtimeAnimatorController_mF50ED3D400626A3E3FC42BB6F0772A6CADEEC63B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_runtimeAnimatorController_mF50ED3D400626A3E3FC42BB6F0772A6CADEEC63B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Animator::get_hasBoundPlayables()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_hasBoundPlayables_m1ADEF28BC77A4C8DBC707DA02A1B72E00AC0C88A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_hasBoundPlayables_m1ADEF28BC77A4C8DBC707DA02A1B72E00AC0C88A_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_hasBoundPlayables_m1ADEF28BC77A4C8DBC707DA02A1B72E00AC0C88A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_hasBoundPlayables_m1ADEF28BC77A4C8DBC707DA02A1B72E00AC0C88A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_hasBoundPlayables()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::ClearInternalControllerPlayable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ClearInternalControllerPlayable_m355BEE534D61D1A449695F2AC9C7EBFCB0A30B38 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_ClearInternalControllerPlayable_m355BEE534D61D1A449695F2AC9C7EBFCB0A30B38_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_ClearInternalControllerPlayable_m355BEE534D61D1A449695F2AC9C7EBFCB0A30B38_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_ClearInternalControllerPlayable_m355BEE534D61D1A449695F2AC9C7EBFCB0A30B38_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::ClearInternalControllerPlayable()");
	_il2cpp_icall_func(__this);
}
// System.Boolean UnityEngine.Animator::HasState(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_HasState_m1C2FE8BF0269F7560DE3659192ADCEE64E1B2146 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, int32_t ___stateID1, const RuntimeMethod* method)
{
	typedef bool (*Animator_HasState_m1C2FE8BF0269F7560DE3659192ADCEE64E1B2146_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, int32_t);
	static Animator_HasState_m1C2FE8BF0269F7560DE3659192ADCEE64E1B2146_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_HasState_m1C2FE8BF0269F7560DE3659192ADCEE64E1B2146_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::HasState(System.Int32,System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___layerIndex0, ___stateID1);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animator::StringToHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668 (String_t* ___name0, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668_ftn) (String_t*);
	static Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::StringToHash(System.String)");
	int32_t icallRetVal = _il2cpp_icall_func(___name0);
	return icallRetVal;
}
// UnityEngine.Avatar UnityEngine.Animator::get_avatar()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Avatar_t1A1B32874530475986346E2EED62F9DDEE8C45C6 * Animator_get_avatar_m489DDC713148AB3DCCCDE5DBEA432E967DFAB28C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef Avatar_t1A1B32874530475986346E2EED62F9DDEE8C45C6 * (*Animator_get_avatar_m489DDC713148AB3DCCCDE5DBEA432E967DFAB28C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_avatar_m489DDC713148AB3DCCCDE5DBEA432E967DFAB28C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_avatar_m489DDC713148AB3DCCCDE5DBEA432E967DFAB28C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_avatar()");
	Avatar_t1A1B32874530475986346E2EED62F9DDEE8C45C6 * icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_avatar(UnityEngine.Avatar)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_avatar_m99A44A056E67AC7C67D13638270D90750144EAC7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Avatar_t1A1B32874530475986346E2EED62F9DDEE8C45C6 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_avatar_m99A44A056E67AC7C67D13638270D90750144EAC7_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Avatar_t1A1B32874530475986346E2EED62F9DDEE8C45C6 *);
	static Animator_set_avatar_m99A44A056E67AC7C67D13638270D90750144EAC7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_avatar_m99A44A056E67AC7C67D13638270D90750144EAC7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_avatar(UnityEngine.Avatar)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.String UnityEngine.Animator::GetStats()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Animator_GetStats_m1A09FE158C6C2D96DAF71AB9E69FC6EA0F92FB77 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef String_t* (*Animator_GetStats_m1A09FE158C6C2D96DAF71AB9E69FC6EA0F92FB77_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_GetStats_m1A09FE158C6C2D96DAF71AB9E69FC6EA0F92FB77_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetStats_m1A09FE158C6C2D96DAF71AB9E69FC6EA0F92FB77_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetStats()");
	String_t* icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// UnityEngine.Playables.PlayableGraph UnityEngine.Animator::get_playableGraph()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A  Animator_get_playableGraph_mAD948686F7EEF7E088631FC368B6E55DACE55311 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A  V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		il2cpp_codegen_initobj((&V_0), sizeof(PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A ));
		Animator_GetCurrentGraph_mB07D1ED5E6A81D218B4CD41F224129BC56C45D6F(__this, (PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A *)(&V_0), /*hidden argument*/NULL);
		PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A  L_0 = V_0;
		V_1 = L_0;
		goto IL_0016;
	}

IL_0016:
	{
		PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::GetCurrentGraph(UnityEngine.Playables.PlayableGraph&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetCurrentGraph_mB07D1ED5E6A81D218B4CD41F224129BC56C45D6F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A * ___graph0, const RuntimeMethod* method)
{
	typedef void (*Animator_GetCurrentGraph_mB07D1ED5E6A81D218B4CD41F224129BC56C45D6F_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, PlayableGraph_t2D5083CFACB413FA1BB13FF054BE09A5A55A205A *);
	static Animator_GetCurrentGraph_mB07D1ED5E6A81D218B4CD41F224129BC56C45D6F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetCurrentGraph_mB07D1ED5E6A81D218B4CD41F224129BC56C45D6F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetCurrentGraph(UnityEngine.Playables.PlayableGraph&)");
	_il2cpp_icall_func(__this, ___graph0);
}
// System.Void UnityEngine.Animator::CheckIfInIKPass()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_CheckIfInIKPass_m555A7B629DFA0B2EF1184C18F9E89D00387607BD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD1DCB778EB9DF1B12AD26B829002FF8E78A1AFCE);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t G_B3_0 = 0;
	{
		bool L_0;
		L_0 = Animator_get_logWarnings_m692C78DB988B112179D3D42A22310E2317B8BE4A(__this, /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_0014;
		}
	}
	{
		bool L_1;
		L_1 = Animator_IsInIKPass_mD14286C3D16BE2031BA3D278F884337815D76FAC(__this, /*hidden argument*/NULL);
		G_B3_0 = ((((int32_t)L_1) == ((int32_t)0))? 1 : 0);
		goto IL_0015;
	}

IL_0014:
	{
		G_B3_0 = 0;
	}

IL_0015:
	{
		V_0 = (bool)G_B3_0;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0024;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7(_stringLiteralD1DCB778EB9DF1B12AD26B829002FF8E78A1AFCE, /*hidden argument*/NULL);
	}

IL_0024:
	{
		return;
	}
}
// System.Boolean UnityEngine.Animator::IsInIKPass()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsInIKPass_mD14286C3D16BE2031BA3D278F884337815D76FAC (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_IsInIKPass_mD14286C3D16BE2031BA3D278F884337815D76FAC_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_IsInIKPass_mD14286C3D16BE2031BA3D278F884337815D76FAC_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_IsInIKPass_mD14286C3D16BE2031BA3D278F884337815D76FAC_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::IsInIKPass()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetFloatString(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatString_m0D1D54020A1D7F9E73A84DAA5FF118ED31F3E943 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, float ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetFloatString_m0D1D54020A1D7F9E73A84DAA5FF118ED31F3E943_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*, float);
	static Animator_SetFloatString_m0D1D54020A1D7F9E73A84DAA5FF118ED31F3E943_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetFloatString_m0D1D54020A1D7F9E73A84DAA5FF118ED31F3E943_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetFloatString(System.String,System.Single)");
	_il2cpp_icall_func(__this, ___name0, ___value1);
}
// System.Void UnityEngine.Animator::SetFloatID(System.Int32,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatID_m277DFF321B75EE54886A5BD1FECF7E3E3CE5D4B2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, float ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetFloatID_m277DFF321B75EE54886A5BD1FECF7E3E3CE5D4B2_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float);
	static Animator_SetFloatID_m277DFF321B75EE54886A5BD1FECF7E3E3CE5D4B2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetFloatID_m277DFF321B75EE54886A5BD1FECF7E3E3CE5D4B2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetFloatID(System.Int32,System.Single)");
	_il2cpp_icall_func(__this, ___id0, ___value1);
}
// System.Single UnityEngine.Animator::GetFloatString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloatString_m1A82C1B3C58A2A289AF6002EEAD2C217197CF5E6 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef float (*Animator_GetFloatString_m1A82C1B3C58A2A289AF6002EEAD2C217197CF5E6_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*);
	static Animator_GetFloatString_m1A82C1B3C58A2A289AF6002EEAD2C217197CF5E6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetFloatString_m1A82C1B3C58A2A289AF6002EEAD2C217197CF5E6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetFloatString(System.String)");
	float icallRetVal = _il2cpp_icall_func(__this, ___name0);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::GetFloatID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_GetFloatID_mC18A6BBCE86EE27603FEE22E31A4657AE75FAE17 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	typedef float (*Animator_GetFloatID_mC18A6BBCE86EE27603FEE22E31A4657AE75FAE17_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetFloatID_mC18A6BBCE86EE27603FEE22E31A4657AE75FAE17_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetFloatID_mC18A6BBCE86EE27603FEE22E31A4657AE75FAE17_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetFloatID(System.Int32)");
	float icallRetVal = _il2cpp_icall_func(__this, ___id0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetBoolString(System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoolString_mB0D21540179FFB9E5F1B2C2EF008BD0595B78BA7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, bool ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetBoolString_mB0D21540179FFB9E5F1B2C2EF008BD0595B78BA7_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*, bool);
	static Animator_SetBoolString_mB0D21540179FFB9E5F1B2C2EF008BD0595B78BA7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetBoolString_mB0D21540179FFB9E5F1B2C2EF008BD0595B78BA7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetBoolString(System.String,System.Boolean)");
	_il2cpp_icall_func(__this, ___name0, ___value1);
}
// System.Void UnityEngine.Animator::SetBoolID(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoolID_m86E6B6BAB2AF50CF90D6E6DA56579AF08E5A9342 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, bool ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetBoolID_m86E6B6BAB2AF50CF90D6E6DA56579AF08E5A9342_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, bool);
	static Animator_SetBoolID_m86E6B6BAB2AF50CF90D6E6DA56579AF08E5A9342_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetBoolID_m86E6B6BAB2AF50CF90D6E6DA56579AF08E5A9342_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetBoolID(System.Int32,System.Boolean)");
	_il2cpp_icall_func(__this, ___id0, ___value1);
}
// System.Boolean UnityEngine.Animator::GetBoolString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBoolString_mCACE093AEB7F1FDB919A2F5D6057E95124CF6980 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef bool (*Animator_GetBoolString_mCACE093AEB7F1FDB919A2F5D6057E95124CF6980_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*);
	static Animator_GetBoolString_mCACE093AEB7F1FDB919A2F5D6057E95124CF6980_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetBoolString_mCACE093AEB7F1FDB919A2F5D6057E95124CF6980_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetBoolString(System.String)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___name0);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::GetBoolID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_GetBoolID_m1C533DC66ECF19A118119773458D0F018F2238F0 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	typedef bool (*Animator_GetBoolID_m1C533DC66ECF19A118119773458D0F018F2238F0_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetBoolID_m1C533DC66ECF19A118119773458D0F018F2238F0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetBoolID_m1C533DC66ECF19A118119773458D0F018F2238F0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetBoolID(System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___id0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetIntegerString(System.String,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIntegerString_m98F3F5AF11579CA8F0DD2C43625CBE6258999CB9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, int32_t ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetIntegerString_m98F3F5AF11579CA8F0DD2C43625CBE6258999CB9_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*, int32_t);
	static Animator_SetIntegerString_m98F3F5AF11579CA8F0DD2C43625CBE6258999CB9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetIntegerString_m98F3F5AF11579CA8F0DD2C43625CBE6258999CB9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetIntegerString(System.String,System.Int32)");
	_il2cpp_icall_func(__this, ___name0, ___value1);
}
// System.Void UnityEngine.Animator::SetIntegerID(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetIntegerID_m935BD3F26317A508AA8EE0642E4D3F0A083673F6 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, int32_t ___value1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetIntegerID_m935BD3F26317A508AA8EE0642E4D3F0A083673F6_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, int32_t);
	static Animator_SetIntegerID_m935BD3F26317A508AA8EE0642E4D3F0A083673F6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetIntegerID_m935BD3F26317A508AA8EE0642E4D3F0A083673F6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetIntegerID(System.Int32,System.Int32)");
	_il2cpp_icall_func(__this, ___id0, ___value1);
}
// System.Int32 UnityEngine.Animator::GetIntegerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetIntegerString_m812EDB3BBD70E2910B5C06518D4A383AE3FCCA77 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_GetIntegerString_m812EDB3BBD70E2910B5C06518D4A383AE3FCCA77_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*);
	static Animator_GetIntegerString_m812EDB3BBD70E2910B5C06518D4A383AE3FCCA77_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetIntegerString_m812EDB3BBD70E2910B5C06518D4A383AE3FCCA77_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetIntegerString(System.String)");
	int32_t icallRetVal = _il2cpp_icall_func(__this, ___name0);
	return icallRetVal;
}
// System.Int32 UnityEngine.Animator::GetIntegerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Animator_GetIntegerID_m6BDA07EF7C93439AB21AB8C8AE84AE5E2BDBB7B1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	typedef int32_t (*Animator_GetIntegerID_m6BDA07EF7C93439AB21AB8C8AE84AE5E2BDBB7B1_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_GetIntegerID_m6BDA07EF7C93439AB21AB8C8AE84AE5E2BDBB7B1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetIntegerID_m6BDA07EF7C93439AB21AB8C8AE84AE5E2BDBB7B1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetIntegerID(System.Int32)");
	int32_t icallRetVal = _il2cpp_icall_func(__this, ___id0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetTriggerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTriggerString_m38F66A49276BCED56B89BB6AF8A36183BE4285F0 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef void (*Animator_SetTriggerString_m38F66A49276BCED56B89BB6AF8A36183BE4285F0_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*);
	static Animator_SetTriggerString_m38F66A49276BCED56B89BB6AF8A36183BE4285F0_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetTriggerString_m38F66A49276BCED56B89BB6AF8A36183BE4285F0_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetTriggerString(System.String)");
	_il2cpp_icall_func(__this, ___name0);
}
// System.Void UnityEngine.Animator::SetTriggerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetTriggerID_mF7C748DA4002FE27B11A23AB015E761EACE374E9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	typedef void (*Animator_SetTriggerID_mF7C748DA4002FE27B11A23AB015E761EACE374E9_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_SetTriggerID_mF7C748DA4002FE27B11A23AB015E761EACE374E9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetTriggerID_mF7C748DA4002FE27B11A23AB015E761EACE374E9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetTriggerID(System.Int32)");
	_il2cpp_icall_func(__this, ___id0);
}
// System.Void UnityEngine.Animator::ResetTriggerString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTriggerString_m6FC21A6B7732A31338EE22E78F3D6220903EDBB2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef void (*Animator_ResetTriggerString_m6FC21A6B7732A31338EE22E78F3D6220903EDBB2_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*);
	static Animator_ResetTriggerString_m6FC21A6B7732A31338EE22E78F3D6220903EDBB2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_ResetTriggerString_m6FC21A6B7732A31338EE22E78F3D6220903EDBB2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::ResetTriggerString(System.String)");
	_il2cpp_icall_func(__this, ___name0);
}
// System.Void UnityEngine.Animator::ResetTriggerID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ResetTriggerID_m982AAC9DF5A10C9ED32F52A5F2DD67C4C85DC111 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	typedef void (*Animator_ResetTriggerID_m982AAC9DF5A10C9ED32F52A5F2DD67C4C85DC111_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_ResetTriggerID_m982AAC9DF5A10C9ED32F52A5F2DD67C4C85DC111_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_ResetTriggerID_m982AAC9DF5A10C9ED32F52A5F2DD67C4C85DC111_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::ResetTriggerID(System.Int32)");
	_il2cpp_icall_func(__this, ___id0);
}
// System.Boolean UnityEngine.Animator::IsParameterControlledByCurveString(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsParameterControlledByCurveString_m51A328B88D4BF88623289AAE897FF4C4AC06556C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	typedef bool (*Animator_IsParameterControlledByCurveString_m51A328B88D4BF88623289AAE897FF4C4AC06556C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*);
	static Animator_IsParameterControlledByCurveString_m51A328B88D4BF88623289AAE897FF4C4AC06556C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_IsParameterControlledByCurveString_m51A328B88D4BF88623289AAE897FF4C4AC06556C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::IsParameterControlledByCurveString(System.String)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___name0);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::IsParameterControlledByCurveID(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_IsParameterControlledByCurveID_m741E77411D309424E5A2A55D74C92D87CB618B9B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	typedef bool (*Animator_IsParameterControlledByCurveID_m741E77411D309424E5A2A55D74C92D87CB618B9B_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_IsParameterControlledByCurveID_m741E77411D309424E5A2A55D74C92D87CB618B9B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_IsParameterControlledByCurveID_m741E77411D309424E5A2A55D74C92D87CB618B9B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::IsParameterControlledByCurveID(System.Int32)");
	bool icallRetVal = _il2cpp_icall_func(__this, ___id0);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::SetFloatStringDamp(System.String,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatStringDamp_mE5687E1F614DEDDE45110DA6A55F1B5499667B0C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, float ___value1, float ___dampTime2, float ___deltaTime3, const RuntimeMethod* method)
{
	typedef void (*Animator_SetFloatStringDamp_mE5687E1F614DEDDE45110DA6A55F1B5499667B0C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, String_t*, float, float, float);
	static Animator_SetFloatStringDamp_mE5687E1F614DEDDE45110DA6A55F1B5499667B0C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetFloatStringDamp_mE5687E1F614DEDDE45110DA6A55F1B5499667B0C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetFloatStringDamp(System.String,System.Single,System.Single,System.Single)");
	_il2cpp_icall_func(__this, ___name0, ___value1, ___dampTime2, ___deltaTime3);
}
// System.Void UnityEngine.Animator::SetFloatIDDamp(System.Int32,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetFloatIDDamp_mE2C9E4DC3B8A75AE7CD1B14437E4F0F092B4EF66 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, float ___value1, float ___dampTime2, float ___deltaTime3, const RuntimeMethod* method)
{
	typedef void (*Animator_SetFloatIDDamp_mE2C9E4DC3B8A75AE7CD1B14437E4F0F092B4EF66_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, float, float, float);
	static Animator_SetFloatIDDamp_mE2C9E4DC3B8A75AE7CD1B14437E4F0F092B4EF66_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetFloatIDDamp_mE2C9E4DC3B8A75AE7CD1B14437E4F0F092B4EF66_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetFloatIDDamp(System.Int32,System.Single,System.Single,System.Single)");
	_il2cpp_icall_func(__this, ___id0, ___value1, ___dampTime2, ___deltaTime3);
}
// System.Boolean UnityEngine.Animator::get_layersAffectMassCenter()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_layersAffectMassCenter_m1B2379FE73BDF0E05811948B94C14066CFA2800D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_layersAffectMassCenter_m1B2379FE73BDF0E05811948B94C14066CFA2800D_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_layersAffectMassCenter_m1B2379FE73BDF0E05811948B94C14066CFA2800D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_layersAffectMassCenter_m1B2379FE73BDF0E05811948B94C14066CFA2800D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_layersAffectMassCenter()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_layersAffectMassCenter(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_layersAffectMassCenter_mB40A4430FC66358F74D8F42A58827933EFEB2C3B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_layersAffectMassCenter_mB40A4430FC66358F74D8F42A58827933EFEB2C3B_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_set_layersAffectMassCenter_mB40A4430FC66358F74D8F42A58827933EFEB2C3B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_layersAffectMassCenter_mB40A4430FC66358F74D8F42A58827933EFEB2C3B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_layersAffectMassCenter(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.Animator::get_leftFeetBottomHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_leftFeetBottomHeight_m270EDE596C0BB06A7B315D470F5D1F2EF46F7040 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_get_leftFeetBottomHeight_m270EDE596C0BB06A7B315D470F5D1F2EF46F7040_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_leftFeetBottomHeight_m270EDE596C0BB06A7B315D470F5D1F2EF46F7040_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_leftFeetBottomHeight_m270EDE596C0BB06A7B315D470F5D1F2EF46F7040_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_leftFeetBottomHeight()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Single UnityEngine.Animator::get_rightFeetBottomHeight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Animator_get_rightFeetBottomHeight_m0C25C89A296501102F5CC778993714E12A47EBCF (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef float (*Animator_get_rightFeetBottomHeight_m0C25C89A296501102F5CC778993714E12A47EBCF_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_rightFeetBottomHeight_m0C25C89A296501102F5CC778993714E12A47EBCF_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_rightFeetBottomHeight_m0C25C89A296501102F5CC778993714E12A47EBCF_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_rightFeetBottomHeight()");
	float icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_supportsOnAnimatorMove()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_supportsOnAnimatorMove_mD810AD77897FCAA36CBBE9500BE447F4511028BE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_supportsOnAnimatorMove_mD810AD77897FCAA36CBBE9500BE447F4511028BE_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_supportsOnAnimatorMove_mD810AD77897FCAA36CBBE9500BE447F4511028BE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_supportsOnAnimatorMove_mD810AD77897FCAA36CBBE9500BE447F4511028BE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_supportsOnAnimatorMove()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::OnUpdateModeChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_OnUpdateModeChanged_mD180BA5BA742A8AE2915D028CC9C751763E0D3B6 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_OnUpdateModeChanged_mD180BA5BA742A8AE2915D028CC9C751763E0D3B6_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_OnUpdateModeChanged_mD180BA5BA742A8AE2915D028CC9C751763E0D3B6_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_OnUpdateModeChanged_mD180BA5BA742A8AE2915D028CC9C751763E0D3B6_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::OnUpdateModeChanged()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.Animator::OnCullingModeChanged()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_OnCullingModeChanged_mDC2C299AB245D288B38BC5C4E7AB30346518BC97 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_OnCullingModeChanged_mDC2C299AB245D288B38BC5C4E7AB30346518BC97_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_OnCullingModeChanged_mDC2C299AB245D288B38BC5C4E7AB30346518BC97_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_OnCullingModeChanged_mDC2C299AB245D288B38BC5C4E7AB30346518BC97_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::OnCullingModeChanged()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.Animator::WriteDefaultPose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_WriteDefaultPose_m98E6B68EB65B1A6C7DD74FD9037A848FB34623AD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_WriteDefaultPose_m98E6B68EB65B1A6C7DD74FD9037A848FB34623AD_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_WriteDefaultPose_m98E6B68EB65B1A6C7DD74FD9037A848FB34623AD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_WriteDefaultPose_m98E6B68EB65B1A6C7DD74FD9037A848FB34623AD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::WriteDefaultPose()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.Animator::Update(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Update_mBA8EC912BA18CB8718B4A4CCB4F18A0639C36E0D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___deltaTime0, const RuntimeMethod* method)
{
	typedef void (*Animator_Update_mBA8EC912BA18CB8718B4A4CCB4F18A0639C36E0D_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, float);
	static Animator_Update_mBA8EC912BA18CB8718B4A4CCB4F18A0639C36E0D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_Update_mBA8EC912BA18CB8718B4A4CCB4F18A0639C36E0D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::Update(System.Single)");
	_il2cpp_icall_func(__this, ___deltaTime0);
}
// System.Void UnityEngine.Animator::Rebind()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Rebind_mE431618F7D87F4CB933C2ECBACD11CB47EA01615 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	{
		Animator_Rebind_m385B65982B5147AA4BC4FB7209F1578AAE2E65B2(__this, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::Rebind(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_Rebind_m385B65982B5147AA4BC4FB7209F1578AAE2E65B2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___writeDefaultValues0, const RuntimeMethod* method)
{
	typedef void (*Animator_Rebind_m385B65982B5147AA4BC4FB7209F1578AAE2E65B2_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_Rebind_m385B65982B5147AA4BC4FB7209F1578AAE2E65B2_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_Rebind_m385B65982B5147AA4BC4FB7209F1578AAE2E65B2_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::Rebind(System.Boolean)");
	_il2cpp_icall_func(__this, ___writeDefaultValues0);
}
// System.Void UnityEngine.Animator::ApplyBuiltinRootMotion()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_ApplyBuiltinRootMotion_mFB944AAE1BCE87126805FDC27D038D4E8C640D74 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef void (*Animator_ApplyBuiltinRootMotion_mFB944AAE1BCE87126805FDC27D038D4E8C640D74_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_ApplyBuiltinRootMotion_mFB944AAE1BCE87126805FDC27D038D4E8C640D74_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_ApplyBuiltinRootMotion_mFB944AAE1BCE87126805FDC27D038D4E8C640D74_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::ApplyBuiltinRootMotion()");
	_il2cpp_icall_func(__this);
}
// System.Void UnityEngine.Animator::EvaluateController()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_EvaluateController_m3B359D23D95FD9B72BE1212CD22E9034176C2B6D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	{
		Animator_EvaluateController_mD4751CCBDA8ABF86063783231EBDE9C260458E06(__this, (0.0f), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::EvaluateController(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_EvaluateController_mD4751CCBDA8ABF86063783231EBDE9C260458E06 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, float ___deltaTime0, const RuntimeMethod* method)
{
	typedef void (*Animator_EvaluateController_mD4751CCBDA8ABF86063783231EBDE9C260458E06_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, float);
	static Animator_EvaluateController_mD4751CCBDA8ABF86063783231EBDE9C260458E06_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_EvaluateController_mD4751CCBDA8ABF86063783231EBDE9C260458E06_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::EvaluateController(System.Single)");
	_il2cpp_icall_func(__this, ___deltaTime0);
}
// System.String UnityEngine.Animator::GetCurrentStateName(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Animator_GetCurrentStateName_m852C3A3ECAC10C5196D2E8A91147F575C4F375B5 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		int32_t L_0 = ___layerIndex0;
		String_t* L_1;
		L_1 = Animator_GetAnimatorStateName_m91AED430D363500BA29903D513CCE4AF783CF0C1(__this, L_0, (bool)1, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		String_t* L_2 = V_0;
		return L_2;
	}
}
// System.String UnityEngine.Animator::GetNextStateName(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Animator_GetNextStateName_m35FC693FA583F5720DAEA2E6387DD1ACF7AF10D7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		int32_t L_0 = ___layerIndex0;
		String_t* L_1;
		L_1 = Animator_GetAnimatorStateName_m91AED430D363500BA29903D513CCE4AF783CF0C1(__this, L_0, (bool)0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000c;
	}

IL_000c:
	{
		String_t* L_2 = V_0;
		return L_2;
	}
}
// System.String UnityEngine.Animator::GetAnimatorStateName(System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Animator_GetAnimatorStateName_m91AED430D363500BA29903D513CCE4AF783CF0C1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___layerIndex0, bool ___current1, const RuntimeMethod* method)
{
	typedef String_t* (*Animator_GetAnimatorStateName_m91AED430D363500BA29903D513CCE4AF783CF0C1_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, bool);
	static Animator_GetAnimatorStateName_m91AED430D363500BA29903D513CCE4AF783CF0C1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetAnimatorStateName_m91AED430D363500BA29903D513CCE4AF783CF0C1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetAnimatorStateName(System.Int32,System.Boolean)");
	String_t* icallRetVal = _il2cpp_icall_func(__this, ___layerIndex0, ___current1);
	return icallRetVal;
}
// System.String UnityEngine.Animator::ResolveHash(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Animator_ResolveHash_m50E7AB4DAE10F09A1410A1CD2F79EF1F100FB989 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hash0, const RuntimeMethod* method)
{
	typedef String_t* (*Animator_ResolveHash_m50E7AB4DAE10F09A1410A1CD2F79EF1F100FB989_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t);
	static Animator_ResolveHash_m50E7AB4DAE10F09A1410A1CD2F79EF1F100FB989_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_ResolveHash_m50E7AB4DAE10F09A1410A1CD2F79EF1F100FB989_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::ResolveHash(System.Int32)");
	String_t* icallRetVal = _il2cpp_icall_func(__this, ___hash0);
	return icallRetVal;
}
// System.Boolean UnityEngine.Animator::get_logWarnings()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_logWarnings_m692C78DB988B112179D3D42A22310E2317B8BE4A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_logWarnings_m692C78DB988B112179D3D42A22310E2317B8BE4A_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_logWarnings_m692C78DB988B112179D3D42A22310E2317B8BE4A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_logWarnings_m692C78DB988B112179D3D42A22310E2317B8BE4A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_logWarnings()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_logWarnings(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_logWarnings_mCD3C49F229A5192596E3EC477702B9DFFD48FB0B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_logWarnings_mCD3C49F229A5192596E3EC477702B9DFFD48FB0B_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_set_logWarnings_mCD3C49F229A5192596E3EC477702B9DFFD48FB0B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_logWarnings_mCD3C49F229A5192596E3EC477702B9DFFD48FB0B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_logWarnings(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Animator::get_fireEvents()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_fireEvents_m9A6BC589EB3590237899E8D3515830973F80747C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_fireEvents_m9A6BC589EB3590237899E8D3515830973F80747C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_fireEvents_m9A6BC589EB3590237899E8D3515830973F80747C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_fireEvents_m9A6BC589EB3590237899E8D3515830973F80747C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_fireEvents()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_fireEvents(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_fireEvents_m60E03A453B86D1BDAA27C299BB035DDBB927407E (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_fireEvents_m60E03A453B86D1BDAA27C299BB035DDBB927407E_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_set_fireEvents_m60E03A453B86D1BDAA27C299BB035DDBB927407E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_fireEvents_m60E03A453B86D1BDAA27C299BB035DDBB927407E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_fireEvents(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Animator::get_keepAnimatorControllerStateOnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Animator_get_keepAnimatorControllerStateOnDisable_m63FEB922BF9FFA56FABE278ECBDB7A28FD626E7B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	typedef bool (*Animator_get_keepAnimatorControllerStateOnDisable_m63FEB922BF9FFA56FABE278ECBDB7A28FD626E7B_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *);
	static Animator_get_keepAnimatorControllerStateOnDisable_m63FEB922BF9FFA56FABE278ECBDB7A28FD626E7B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_keepAnimatorControllerStateOnDisable_m63FEB922BF9FFA56FABE278ECBDB7A28FD626E7B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_keepAnimatorControllerStateOnDisable()");
	bool icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
}
// System.Void UnityEngine.Animator::set_keepAnimatorControllerStateOnDisable(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_keepAnimatorControllerStateOnDisable_mE92989226784F1E8AB93A1DD5BE8118D041DBB0B (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, bool ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_keepAnimatorControllerStateOnDisable_mE92989226784F1E8AB93A1DD5BE8118D041DBB0B_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, bool);
	static Animator_set_keepAnimatorControllerStateOnDisable_mE92989226784F1E8AB93A1DD5BE8118D041DBB0B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_keepAnimatorControllerStateOnDisable_mE92989226784F1E8AB93A1DD5BE8118D041DBB0B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_keepAnimatorControllerStateOnDisable(System.Boolean)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Vector3 UnityEngine.Animator::GetVector(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_GetVector_m05D4C87F72C7A25CDDD3C7558EFE5AB533E13A66 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0;
		L_0 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Animator::GetVector(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  Animator_GetVector_mAC10208FC08FDBC8F15C6AD7F7A23094F8AFC049 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0;
		L_0 = Vector3_get_zero_m1A8F7993167785F750B6B01762D22C2597C84EF6(/*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::SetVector(System.String,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetVector_mD9ED86006FA7D994C2B989E4EE2FDFA5E142C588 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value1, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.Animator::SetVector(System.Int32,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetVector_mC047F761B4E3A1C1834CA086C6073B711E86BD4D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___value1, const RuntimeMethod* method)
{
	{
		return;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::GetQuaternion(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_GetQuaternion_mB5F3E1F24B2F5FC133621A8E00ADDB6A4AE37229 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_0;
		L_0 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Quaternion UnityEngine.Animator::GetQuaternion(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  Animator_GetQuaternion_m22EDD2B267803B40B6F03CF8B9ADB065AACB026E (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, const RuntimeMethod* method)
{
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_0;
		L_0 = Quaternion_get_identity_mF2E565DBCE793A1AE6208056D42CA7C59D83A702(/*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Animator::SetQuaternion(System.String,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetQuaternion_mD25A73488629DF57A82B53729A463435139BE81D (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, String_t* ___name0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value1, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.Animator::SetQuaternion(System.Int32,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetQuaternion_m39FB33CE24D758178FDF3420F3DEDB49A985B177 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___id0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  ___value1, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.Animator::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator__ctor_m018E7D6694796B1D8E098AB8142B5E4406BA24F2 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, const RuntimeMethod* method)
{
	{
		Behaviour__ctor_mCACD3614226521EA607B0F3640C0FAC7EACCBCE0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Animator::get_deltaPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_deltaPosition_Injected_m1E4EE8E8FF829CD0CA02B5B2993B8F52F51FAE7E (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_deltaPosition_Injected_m1E4EE8E8FF829CD0CA02B5B2993B8F52F51FAE7E_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_get_deltaPosition_Injected_m1E4EE8E8FF829CD0CA02B5B2993B8F52F51FAE7E_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_deltaPosition_Injected_m1E4EE8E8FF829CD0CA02B5B2993B8F52F51FAE7E_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_deltaPosition_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::get_deltaRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_deltaRotation_Injected_mDD91E09560E64E4CD711CF2A0FCB93B9607976D5 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_deltaRotation_Injected_mDD91E09560E64E4CD711CF2A0FCB93B9607976D5_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_get_deltaRotation_Injected_mDD91E09560E64E4CD711CF2A0FCB93B9607976D5_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_deltaRotation_Injected_mDD91E09560E64E4CD711CF2A0FCB93B9607976D5_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_deltaRotation_Injected(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::get_velocity_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_velocity_Injected_m225EE219299DD0B557685EEBB8C98687A5ABD772 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_velocity_Injected_m225EE219299DD0B557685EEBB8C98687A5ABD772_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_get_velocity_Injected_m225EE219299DD0B557685EEBB8C98687A5ABD772_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_velocity_Injected_m225EE219299DD0B557685EEBB8C98687A5ABD772_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_velocity_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::get_angularVelocity_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_angularVelocity_Injected_m111D48072DE65364FA873BEAA14288C44A0538F9 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_angularVelocity_Injected_m111D48072DE65364FA873BEAA14288C44A0538F9_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_get_angularVelocity_Injected_m111D48072DE65364FA873BEAA14288C44A0538F9_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_angularVelocity_Injected_m111D48072DE65364FA873BEAA14288C44A0538F9_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_angularVelocity_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::get_rootPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_rootPosition_Injected_m3BDD26353E59D49EA2D775B52E87D2430C207836 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_rootPosition_Injected_m3BDD26353E59D49EA2D775B52E87D2430C207836_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_get_rootPosition_Injected_m3BDD26353E59D49EA2D775B52E87D2430C207836_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_rootPosition_Injected_m3BDD26353E59D49EA2D775B52E87D2430C207836_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_rootPosition_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::set_rootPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_rootPosition_Injected_m4D693A6922FB9722FB27F58CD291A14DC21FF930 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_rootPosition_Injected_m4D693A6922FB9722FB27F58CD291A14DC21FF930_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_set_rootPosition_Injected_m4D693A6922FB9722FB27F58CD291A14DC21FF930_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_rootPosition_Injected_m4D693A6922FB9722FB27F58CD291A14DC21FF930_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_rootPosition_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Animator::get_rootRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_rootRotation_Injected_mEDD72EDFCAFB6AA9069D2A8A69C4FF5CFFC442F4 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_rootRotation_Injected_mEDD72EDFCAFB6AA9069D2A8A69C4FF5CFFC442F4_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_get_rootRotation_Injected_mEDD72EDFCAFB6AA9069D2A8A69C4FF5CFFC442F4_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_rootRotation_Injected_mEDD72EDFCAFB6AA9069D2A8A69C4FF5CFFC442F4_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_rootRotation_Injected(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::set_rootRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_rootRotation_Injected_m91F597BA80DD077F49C4FD623E5055C5B3F5EAF3 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_rootRotation_Injected_m91F597BA80DD077F49C4FD623E5055C5B3F5EAF3_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_set_rootRotation_Injected_m91F597BA80DD077F49C4FD623E5055C5B3F5EAF3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_rootRotation_Injected_m91F597BA80DD077F49C4FD623E5055C5B3F5EAF3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_rootRotation_Injected(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Animator::get_bodyPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_bodyPositionInternal_Injected_mA3BAEBD74BAA40C266181E9FEDFC924B26C5D1A3 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_bodyPositionInternal_Injected_mA3BAEBD74BAA40C266181E9FEDFC924B26C5D1A3_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_get_bodyPositionInternal_Injected_mA3BAEBD74BAA40C266181E9FEDFC924B26C5D1A3_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_bodyPositionInternal_Injected_mA3BAEBD74BAA40C266181E9FEDFC924B26C5D1A3_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_bodyPositionInternal_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::set_bodyPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyPositionInternal_Injected_m06CF9B9758465B3C3F7B901A9EFFA91E169B604A (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_bodyPositionInternal_Injected_m06CF9B9758465B3C3F7B901A9EFFA91E169B604A_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_set_bodyPositionInternal_Injected_m06CF9B9758465B3C3F7B901A9EFFA91E169B604A_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_bodyPositionInternal_Injected_m06CF9B9758465B3C3F7B901A9EFFA91E169B604A_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_bodyPositionInternal_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Animator::get_bodyRotationInternal_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_bodyRotationInternal_Injected_m9728DF9FB2429838E333C3E407348B596015212F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_bodyRotationInternal_Injected_m9728DF9FB2429838E333C3E407348B596015212F_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_get_bodyRotationInternal_Injected_m9728DF9FB2429838E333C3E407348B596015212F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_bodyRotationInternal_Injected_m9728DF9FB2429838E333C3E407348B596015212F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_bodyRotationInternal_Injected(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::set_bodyRotationInternal_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_set_bodyRotationInternal_Injected_mF305D187AC0A67B81FE749925B80CA593442D9DE (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Animator_set_bodyRotationInternal_Injected_mF305D187AC0A67B81FE749925B80CA593442D9DE_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_set_bodyRotationInternal_Injected_mF305D187AC0A67B81FE749925B80CA593442D9DE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_set_bodyRotationInternal_Injected_mF305D187AC0A67B81FE749925B80CA593442D9DE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::set_bodyRotationInternal_Injected(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Animator::GetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetGoalPosition_Injected_mB7A7DDCC49EAF85921366EFDAF4038002AC18597 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret1, const RuntimeMethod* method)
{
	typedef void (*Animator_GetGoalPosition_Injected_mB7A7DDCC49EAF85921366EFDAF4038002AC18597_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_GetGoalPosition_Injected_mB7A7DDCC49EAF85921366EFDAF4038002AC18597_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetGoalPosition_Injected_mB7A7DDCC49EAF85921366EFDAF4038002AC18597_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___goal0, ___ret1);
}
// System.Void UnityEngine.Animator::SetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalPosition_Injected_m1F55B0A5FB8E563348DEF0C839D855D1B8084870 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___goalPosition1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetGoalPosition_Injected_m1F55B0A5FB8E563348DEF0C839D855D1B8084870_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_SetGoalPosition_Injected_m1F55B0A5FB8E563348DEF0C839D855D1B8084870_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetGoalPosition_Injected_m1F55B0A5FB8E563348DEF0C839D855D1B8084870_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetGoalPosition_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___goal0, ___goalPosition1);
}
// System.Void UnityEngine.Animator::GetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetGoalRotation_Injected_m2887FC6A66153B5C6F560EA6106A1798E02D3CBD (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret1, const RuntimeMethod* method)
{
	typedef void (*Animator_GetGoalRotation_Injected_m2887FC6A66153B5C6F560EA6106A1798E02D3CBD_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_GetGoalRotation_Injected_m2887FC6A66153B5C6F560EA6106A1798E02D3CBD_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetGoalRotation_Injected_m2887FC6A66153B5C6F560EA6106A1798E02D3CBD_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___goal0, ___ret1);
}
// System.Void UnityEngine.Animator::SetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetGoalRotation_Injected_m51FB734E9C792821846E5C33FD301879320867B8 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___goal0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___goalRotation1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetGoalRotation_Injected_m51FB734E9C792821846E5C33FD301879320867B8_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_SetGoalRotation_Injected_m51FB734E9C792821846E5C33FD301879320867B8_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetGoalRotation_Injected_m51FB734E9C792821846E5C33FD301879320867B8_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetGoalRotation_Injected(UnityEngine.AvatarIKGoal,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___goal0, ___goalRotation1);
}
// System.Void UnityEngine.Animator::GetHintPosition_Injected(UnityEngine.AvatarIKHint,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_GetHintPosition_Injected_m96EC2D942E6D74FC24CA9D60EBBB73AEA1EFCC39 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret1, const RuntimeMethod* method)
{
	typedef void (*Animator_GetHintPosition_Injected_m96EC2D942E6D74FC24CA9D60EBBB73AEA1EFCC39_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_GetHintPosition_Injected_m96EC2D942E6D74FC24CA9D60EBBB73AEA1EFCC39_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_GetHintPosition_Injected_m96EC2D942E6D74FC24CA9D60EBBB73AEA1EFCC39_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::GetHintPosition_Injected(UnityEngine.AvatarIKHint,UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___hint0, ___ret1);
}
// System.Void UnityEngine.Animator::SetHintPosition_Injected(UnityEngine.AvatarIKHint,UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetHintPosition_Injected_m743A8699923BB0AF0BB07EF6C8AF04C1CCD1EC17 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___hint0, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___hintPosition1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetHintPosition_Injected_m743A8699923BB0AF0BB07EF6C8AF04C1CCD1EC17_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_SetHintPosition_Injected_m743A8699923BB0AF0BB07EF6C8AF04C1CCD1EC17_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetHintPosition_Injected_m743A8699923BB0AF0BB07EF6C8AF04C1CCD1EC17_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetHintPosition_Injected(UnityEngine.AvatarIKHint,UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___hint0, ___hintPosition1);
}
// System.Void UnityEngine.Animator::SetLookAtPositionInternal_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetLookAtPositionInternal_Injected_mE79031C5471CA6C40B98D6C1654C55D23FEF021C (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___lookAtPosition0, const RuntimeMethod* method)
{
	typedef void (*Animator_SetLookAtPositionInternal_Injected_mE79031C5471CA6C40B98D6C1654C55D23FEF021C_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_SetLookAtPositionInternal_Injected_mE79031C5471CA6C40B98D6C1654C55D23FEF021C_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetLookAtPositionInternal_Injected_mE79031C5471CA6C40B98D6C1654C55D23FEF021C_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetLookAtPositionInternal_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___lookAtPosition0);
}
// System.Void UnityEngine.Animator::SetBoneLocalRotationInternal_Injected(System.Int32,UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_SetBoneLocalRotationInternal_Injected_m78B08DD15F6216F850A89A71BD65DC9FDE36AAE7 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, int32_t ___humanBoneId0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___rotation1, const RuntimeMethod* method)
{
	typedef void (*Animator_SetBoneLocalRotationInternal_Injected_m78B08DD15F6216F850A89A71BD65DC9FDE36AAE7_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, int32_t, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_SetBoneLocalRotationInternal_Injected_m78B08DD15F6216F850A89A71BD65DC9FDE36AAE7_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_SetBoneLocalRotationInternal_Injected_m78B08DD15F6216F850A89A71BD65DC9FDE36AAE7_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::SetBoneLocalRotationInternal_Injected(System.Int32,UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___humanBoneId0, ___rotation1);
}
// System.Void UnityEngine.Animator::get_pivotPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_pivotPosition_Injected_mAF27659230FFC6425898DD0675CF34D2234677B1 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_pivotPosition_Injected_mAF27659230FFC6425898DD0675CF34D2234677B1_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_get_pivotPosition_Injected_mAF27659230FFC6425898DD0675CF34D2234677B1_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_pivotPosition_Injected_mAF27659230FFC6425898DD0675CF34D2234677B1_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_pivotPosition_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::MatchTarget_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,System.Int32,UnityEngine.MatchTargetWeightMask&,System.Single,System.Single,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_MatchTarget_Injected_m82320F2465819561765E195C1DB8E69A8A373A3F (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___matchPosition0, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___matchRotation1, int32_t ___targetBodyPart2, MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 * ___weightMask3, float ___startNormalizedTime4, float ___targetNormalizedTime5, bool ___completeMatch6, const RuntimeMethod* method)
{
	typedef void (*Animator_MatchTarget_Injected_m82320F2465819561765E195C1DB8E69A8A373A3F_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *, int32_t, MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 *, float, float, bool);
	static Animator_MatchTarget_Injected_m82320F2465819561765E195C1DB8E69A8A373A3F_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_MatchTarget_Injected_m82320F2465819561765E195C1DB8E69A8A373A3F_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::MatchTarget_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,System.Int32,UnityEngine.MatchTargetWeightMask&,System.Single,System.Single,System.Boolean)");
	_il2cpp_icall_func(__this, ___matchPosition0, ___matchRotation1, ___targetBodyPart2, ___weightMask3, ___startNormalizedTime4, ___targetNormalizedTime5, ___completeMatch6);
}
// System.Void UnityEngine.Animator::get_targetPosition_Injected(UnityEngine.Vector3&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_targetPosition_Injected_m8DD5663D05D4E687B3B8FD3C88FF936D94D6B729 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_targetPosition_Injected_m8DD5663D05D4E687B3B8FD3C88FF936D94D6B729_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *);
	static Animator_get_targetPosition_Injected_m8DD5663D05D4E687B3B8FD3C88FF936D94D6B729_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_targetPosition_Injected_m8DD5663D05D4E687B3B8FD3C88FF936D94D6B729_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_targetPosition_Injected(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___ret0);
}
// System.Void UnityEngine.Animator::get_targetRotation_Injected(UnityEngine.Quaternion&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Animator_get_targetRotation_Injected_m95B6C40BDD6E4972C5FB4F896D6DEF6519FCCA41 (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * __this, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 * ___ret0, const RuntimeMethod* method)
{
	typedef void (*Animator_get_targetRotation_Injected_m95B6C40BDD6E4972C5FB4F896D6DEF6519FCCA41_ftn) (Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 *, Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4 *);
	static Animator_get_targetRotation_Injected_m95B6C40BDD6E4972C5FB4F896D6DEF6519FCCA41_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Animator_get_targetRotation_Injected_m95B6C40BDD6E4972C5FB4F896D6DEF6519FCCA41_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Animator::get_targetRotation_Injected(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___ret0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.AnimationClip UnityEngine.AnimatorClipInfo::get_clip()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * AnimatorClipInfo_get_clip_m0822D4BB447803A294410A319C812D2D4B946A95 (AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * __this, const RuntimeMethod* method)
{
	AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * V_0 = NULL;
	AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * G_B3_0 = NULL;
	{
		int32_t L_0 = __this->get_m_ClipInstanceID_0();
		if (L_0)
		{
			goto IL_000c;
		}
	}
	{
		G_B3_0 = ((AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 *)(NULL));
		goto IL_0017;
	}

IL_000c:
	{
		int32_t L_1 = __this->get_m_ClipInstanceID_0();
		AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * L_2;
		L_2 = AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mDA532C9ADE4056E3577FD254944CAF65767DC58B(L_1, /*hidden argument*/NULL);
		G_B3_0 = L_2;
	}

IL_0017:
	{
		V_0 = G_B3_0;
		goto IL_001a;
	}

IL_001a:
	{
		AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * AnimatorClipInfo_get_clip_m0822D4BB447803A294410A319C812D2D4B946A95_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * _thisAdjusted = reinterpret_cast<AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 *>(__this + _offset);
	AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * _returnValue;
	_returnValue = AnimatorClipInfo_get_clip_m0822D4BB447803A294410A319C812D2D4B946A95(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorClipInfo::get_weight()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorClipInfo_get_weight_mF22612DA966F5D6C8EC93E6AD2E05DFE10B36CCA (AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_Weight_1();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorClipInfo_get_weight_mF22612DA966F5D6C8EC93E6AD2E05DFE10B36CCA_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 * _thisAdjusted = reinterpret_cast<AnimatorClipInfo_t758011D6F2B4C04893FCD364DAA936C801FBC610 *>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorClipInfo_get_weight_mF22612DA966F5D6C8EC93E6AD2E05DFE10B36CCA(_thisAdjusted, method);
	return _returnValue;
}
// UnityEngine.AnimationClip UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mDA532C9ADE4056E3577FD254944CAF65767DC58B (int32_t ___instanceID0, const RuntimeMethod* method)
{
	typedef AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * (*AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mDA532C9ADE4056E3577FD254944CAF65767DC58B_ftn) (int32_t);
	static AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mDA532C9ADE4056E3577FD254944CAF65767DC58B_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (AnimatorClipInfo_InstanceIDToAnimationClipPPtr_mDA532C9ADE4056E3577FD254944CAF65767DC58B_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.AnimatorClipInfo::InstanceIDToAnimationClipPPtr(System.Int32)");
	AnimationClip_tD9BFD73D43793BA608D5C0B46BE29EB59E40D178 * icallRetVal = _il2cpp_icall_func(___instanceID0);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.AnimatorControllerParameter
IL2CPP_EXTERN_C void AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshal_pinvoke(const AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE& unmarshaled, AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Name_0 = il2cpp_codegen_marshal_string(unmarshaled.get_m_Name_0());
	marshaled.___m_Type_1 = unmarshaled.get_m_Type_1();
	marshaled.___m_DefaultFloat_2 = unmarshaled.get_m_DefaultFloat_2();
	marshaled.___m_DefaultInt_3 = unmarshaled.get_m_DefaultInt_3();
	marshaled.___m_DefaultBool_4 = static_cast<int32_t>(unmarshaled.get_m_DefaultBool_4());
}
IL2CPP_EXTERN_C void AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshal_pinvoke_back(const AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshaled_pinvoke& marshaled, AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE& unmarshaled)
{
	unmarshaled.set_m_Name_0(il2cpp_codegen_marshal_string_result(marshaled.___m_Name_0));
	int32_t unmarshaled_m_Type_temp_1 = 0;
	unmarshaled_m_Type_temp_1 = marshaled.___m_Type_1;
	unmarshaled.set_m_Type_1(unmarshaled_m_Type_temp_1);
	float unmarshaled_m_DefaultFloat_temp_2 = 0.0f;
	unmarshaled_m_DefaultFloat_temp_2 = marshaled.___m_DefaultFloat_2;
	unmarshaled.set_m_DefaultFloat_2(unmarshaled_m_DefaultFloat_temp_2);
	int32_t unmarshaled_m_DefaultInt_temp_3 = 0;
	unmarshaled_m_DefaultInt_temp_3 = marshaled.___m_DefaultInt_3;
	unmarshaled.set_m_DefaultInt_3(unmarshaled_m_DefaultInt_temp_3);
	bool unmarshaled_m_DefaultBool_temp_4 = false;
	unmarshaled_m_DefaultBool_temp_4 = static_cast<bool>(marshaled.___m_DefaultBool_4);
	unmarshaled.set_m_DefaultBool_4(unmarshaled_m_DefaultBool_temp_4);
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimatorControllerParameter
IL2CPP_EXTERN_C void AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshal_pinvoke_cleanup(AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___m_Name_0);
	marshaled.___m_Name_0 = NULL;
}
// Conversion methods for marshalling of: UnityEngine.AnimatorControllerParameter
IL2CPP_EXTERN_C void AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshal_com(const AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE& unmarshaled, AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshaled_com& marshaled)
{
	marshaled.___m_Name_0 = il2cpp_codegen_marshal_bstring(unmarshaled.get_m_Name_0());
	marshaled.___m_Type_1 = unmarshaled.get_m_Type_1();
	marshaled.___m_DefaultFloat_2 = unmarshaled.get_m_DefaultFloat_2();
	marshaled.___m_DefaultInt_3 = unmarshaled.get_m_DefaultInt_3();
	marshaled.___m_DefaultBool_4 = static_cast<int32_t>(unmarshaled.get_m_DefaultBool_4());
}
IL2CPP_EXTERN_C void AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshal_com_back(const AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshaled_com& marshaled, AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE& unmarshaled)
{
	unmarshaled.set_m_Name_0(il2cpp_codegen_marshal_bstring_result(marshaled.___m_Name_0));
	int32_t unmarshaled_m_Type_temp_1 = 0;
	unmarshaled_m_Type_temp_1 = marshaled.___m_Type_1;
	unmarshaled.set_m_Type_1(unmarshaled_m_Type_temp_1);
	float unmarshaled_m_DefaultFloat_temp_2 = 0.0f;
	unmarshaled_m_DefaultFloat_temp_2 = marshaled.___m_DefaultFloat_2;
	unmarshaled.set_m_DefaultFloat_2(unmarshaled_m_DefaultFloat_temp_2);
	int32_t unmarshaled_m_DefaultInt_temp_3 = 0;
	unmarshaled_m_DefaultInt_temp_3 = marshaled.___m_DefaultInt_3;
	unmarshaled.set_m_DefaultInt_3(unmarshaled_m_DefaultInt_temp_3);
	bool unmarshaled_m_DefaultBool_temp_4 = false;
	unmarshaled_m_DefaultBool_temp_4 = static_cast<bool>(marshaled.___m_DefaultBool_4);
	unmarshaled.set_m_DefaultBool_4(unmarshaled_m_DefaultBool_temp_4);
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimatorControllerParameter
IL2CPP_EXTERN_C void AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshal_com_cleanup(AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___m_Name_0);
	marshaled.___m_Name_0 = NULL;
}
// System.String UnityEngine.AnimatorControllerParameter::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AnimatorControllerParameter_get_name_m210BF40EC0AC18BA2E21F089F3182FE1CFCE3A55 (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		String_t* L_0 = __this->get_m_Name_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		String_t* L_1 = V_0;
		return L_1;
	}
}
// System.Int32 UnityEngine.AnimatorControllerParameter::get_nameHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerParameter_get_nameHash_mA765F17CA6E90C1CDD5E09B9BD90FDC7079E311F (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		String_t* L_0 = __this->get_m_Name_0();
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// UnityEngine.AnimatorControllerParameterType UnityEngine.AnimatorControllerParameter::get_type()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerParameter_get_type_mAFE0FF4AF9351535D2B13EB9555881B39B3C6FC1 (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_Type_1();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.AnimatorControllerParameter::set_type(UnityEngine.AnimatorControllerParameterType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerParameter_set_type_mB340D0544F91976DE2345E1FD08B2D8A680EEFE7 (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_m_Type_1(L_0);
		return;
	}
}
// System.Single UnityEngine.AnimatorControllerParameter::get_defaultFloat()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorControllerParameter_get_defaultFloat_m1799A571A0DFF4FE794A3505FB91AA0A52675C8A (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_DefaultFloat_2();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.AnimatorControllerParameter::set_defaultFloat(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerParameter_set_defaultFloat_mA26606EF1BB62705AE9390E488E8C17C27410B6E (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, float ___value0, const RuntimeMethod* method)
{
	{
		float L_0 = ___value0;
		__this->set_m_DefaultFloat_2(L_0);
		return;
	}
}
// System.Int32 UnityEngine.AnimatorControllerParameter::get_defaultInt()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerParameter_get_defaultInt_m6543BC0C99306212285078896A30696E94506862 (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_DefaultInt_3();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.AnimatorControllerParameter::set_defaultInt(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerParameter_set_defaultInt_mCCB0196ADF4BCE0A0CBEEF623455CD3AD541C493 (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___value0;
		__this->set_m_DefaultInt_3(L_0);
		return;
	}
}
// System.Boolean UnityEngine.AnimatorControllerParameter::get_defaultBool()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerParameter_get_defaultBool_m1023670B7892013E9FB0D72EAC61E1EEB44D0AB9 (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		bool L_0 = __this->get_m_DefaultBool_4();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.AnimatorControllerParameter::set_defaultBool(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerParameter_set_defaultBool_m8D17DB32E42C8BA1913A547766596AEE4EFE920A (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___value0;
		__this->set_m_DefaultBool_4(L_0);
		return;
	}
}
// System.Boolean UnityEngine.AnimatorControllerParameter::Equals(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerParameter_Equals_mE3BC5EEC7505B15CF4B0E5F73B312F97C4A84FD0 (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, RuntimeObject * ___o0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * V_0 = NULL;
	bool V_1 = false;
	int32_t G_B7_0 = 0;
	{
		RuntimeObject * L_0 = ___o0;
		V_0 = ((AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE *)IsInstClass((RuntimeObject*)L_0, AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE_il2cpp_TypeInfo_var));
		AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * L_1 = V_0;
		if (!L_1)
		{
			goto IL_0058;
		}
	}
	{
		String_t* L_2 = __this->get_m_Name_0();
		AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * L_3 = V_0;
		NullCheck(L_3);
		String_t* L_4 = L_3->get_m_Name_0();
		bool L_5;
		L_5 = String_op_Equality_m2B91EE68355F142F67095973D32EB5828B7B73CB(L_2, L_4, /*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_0058;
		}
	}
	{
		int32_t L_6 = __this->get_m_Type_1();
		AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * L_7 = V_0;
		NullCheck(L_7);
		int32_t L_8 = L_7->get_m_Type_1();
		if ((!(((uint32_t)L_6) == ((uint32_t)L_8))))
		{
			goto IL_0058;
		}
	}
	{
		float L_9 = __this->get_m_DefaultFloat_2();
		AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * L_10 = V_0;
		NullCheck(L_10);
		float L_11 = L_10->get_m_DefaultFloat_2();
		if ((!(((float)L_9) == ((float)L_11))))
		{
			goto IL_0058;
		}
	}
	{
		int32_t L_12 = __this->get_m_DefaultInt_3();
		AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * L_13 = V_0;
		NullCheck(L_13);
		int32_t L_14 = L_13->get_m_DefaultInt_3();
		if ((!(((uint32_t)L_12) == ((uint32_t)L_14))))
		{
			goto IL_0058;
		}
	}
	{
		bool L_15 = __this->get_m_DefaultBool_4();
		AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * L_16 = V_0;
		NullCheck(L_16);
		bool L_17 = L_16->get_m_DefaultBool_4();
		G_B7_0 = ((((int32_t)L_15) == ((int32_t)L_17))? 1 : 0);
		goto IL_0059;
	}

IL_0058:
	{
		G_B7_0 = 0;
	}

IL_0059:
	{
		V_1 = (bool)G_B7_0;
		goto IL_005c;
	}

IL_005c:
	{
		bool L_18 = V_1;
		return L_18;
	}
}
// System.Int32 UnityEngine.AnimatorControllerParameter::GetHashCode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorControllerParameter_GetHashCode_m0D4341AB66FA55996C337384BC7E124BC44F4ACA (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		String_t* L_0;
		L_0 = AnimatorControllerParameter_get_name_m210BF40EC0AC18BA2E21F089F3182FE1CFCE3A55(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		int32_t L_1;
		L_1 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_0);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		int32_t L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.AnimatorControllerParameter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerParameter__ctor_mC280E4A2450D852EF516D88FC3AA336437328C9F (AnimatorControllerParameter_t8E7EB3AF7837189FB5523DC4E21D9D51CEA70FEE * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	{
		__this->set_m_Name_0(_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
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
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::.ctor(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable__ctor_mBD4E1368EB671F6349C5740B1BF131F97BD12CC8 (AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		__this->set_m_Handle_0(L_0);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = ___handle0;
		AnimatorControllerPlayable_SetHandle_m19111E2A65EDAB3382AC9BE815503459A495FF38((AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 *)__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable__ctor_mBD4E1368EB671F6349C5740B1BF131F97BD12CC8_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * _thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 *>(__this + _offset);
	AnimatorControllerPlayable__ctor_mBD4E1368EB671F6349C5740B1BF131F97BD12CC8(_thisAdjusted, ___handle0, method);
}
// UnityEngine.Playables.PlayableHandle UnityEngine.Animations.AnimatorControllerPlayable::GetHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimatorControllerPlayable_GetHandle_mBB2911E1B1867ED9C9080BEF16838119A51E0C0C (AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * __this, const RuntimeMethod* method)
{
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0 = __this->get_m_Handle_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  AnimatorControllerPlayable_GetHandle_mBB2911E1B1867ED9C9080BEF16838119A51E0C0C_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * _thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 *>(__this + _offset);
	PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  _returnValue;
	_returnValue = AnimatorControllerPlayable_GetHandle_mBB2911E1B1867ED9C9080BEF16838119A51E0C0C(_thisAdjusted, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::SetHandle(UnityEngine.Playables.PlayableHandle)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable_SetHandle_m19111E2A65EDAB3382AC9BE815503459A495FF38 (AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_mFB1F4B388070EC30EC8DA09EB2869306EE60F2B8_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A * L_0 = __this->get_address_of_m_Handle_0();
		bool L_1;
		L_1 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001b;
		}
	}
	{
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_3 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralBF563F6FCC25CE41FFE0BF7590AF9F4475916665)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimatorControllerPlayable_SetHandle_m19111E2A65EDAB3382AC9BE815503459A495FF38_RuntimeMethod_var)));
	}

IL_001b:
	{
		bool L_4;
		L_4 = PlayableHandle_IsValid_m237A5E7818768641BAC928BD08EC0AB439E3DAF6((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/NULL);
		V_1 = L_4;
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0041;
		}
	}
	{
		bool L_6;
		L_6 = PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_mFB1F4B388070EC30EC8DA09EB2869306EE60F2B8((PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A *)(&___handle0), /*hidden argument*/PlayableHandle_IsPlayableOfType_TisAnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_mFB1F4B388070EC30EC8DA09EB2869306EE60F2B8_RuntimeMethod_var);
		V_2 = (bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		bool L_7 = V_2;
		if (!L_7)
		{
			goto IL_0040;
		}
	}
	{
		InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 * L_8 = (InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463 *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidCastException_tD99F9FF94C3859C78E90F68C2F77A1558BCAF463_il2cpp_TypeInfo_var)));
		InvalidCastException__ctor_m50103CBF0C211B93BF46697875413A10B5A5C5A3(L_8, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralF5510C45DDAD777CCB4893578D995C9739F990F2)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_8, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&AnimatorControllerPlayable_SetHandle_m19111E2A65EDAB3382AC9BE815503459A495FF38_RuntimeMethod_var)));
	}

IL_0040:
	{
	}

IL_0041:
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_9 = ___handle0;
		__this->set_m_Handle_0(L_9);
		return;
	}
}
IL2CPP_EXTERN_C  void AnimatorControllerPlayable_SetHandle_m19111E2A65EDAB3382AC9BE815503459A495FF38_AdjustorThunk (RuntimeObject * __this, PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  ___handle0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * _thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 *>(__this + _offset);
	AnimatorControllerPlayable_SetHandle_m19111E2A65EDAB3382AC9BE815503459A495FF38(_thisAdjusted, ___handle0, method);
}
// System.Boolean UnityEngine.Animations.AnimatorControllerPlayable::Equals(UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorControllerPlayable_Equals_m9D2F918EE07AE657A11C13F285317C05BB257730 (AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * __this, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = AnimatorControllerPlayable_GetHandle_mBB2911E1B1867ED9C9080BEF16838119A51E0C0C((AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 *)__this, /*hidden argument*/NULL);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_1;
		L_1 = AnimatorControllerPlayable_GetHandle_mBB2911E1B1867ED9C9080BEF16838119A51E0C0C((AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 *)(&___other0), /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = PlayableHandle_op_Equality_mFD26CFA8ECF2B622B1A3D4117066CAE965C9F704(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0016;
	}

IL_0016:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimatorControllerPlayable_Equals_m9D2F918EE07AE657A11C13F285317C05BB257730_AdjustorThunk (RuntimeObject * __this, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___other0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 * _thisAdjusted = reinterpret_cast<AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4 *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorControllerPlayable_Equals_m9D2F918EE07AE657A11C13F285317C05BB257730(_thisAdjusted, ___other0, method);
	return _returnValue;
}
// System.Void UnityEngine.Animations.AnimatorControllerPlayable::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorControllerPlayable__cctor_m82C2FF3AEAD5D042648E50B513269EF367C51EB4 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A_il2cpp_TypeInfo_var);
		PlayableHandle_t50DCD240B0400DDAD0822C13E5DBC7AD64DC027A  L_0;
		L_0 = PlayableHandle_get_Null_mD1C6FC2D7F6A7A23955ACDD87BE934B75463E612(/*hidden argument*/NULL);
		AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  L_1;
		memset((&L_1), 0, sizeof(L_1));
		AnimatorControllerPlayable__ctor_mBD4E1368EB671F6349C5740B1BF131F97BD12CC8((&L_1), L_0, /*hidden argument*/NULL);
		((AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_StaticFields*)il2cpp_codegen_static_fields_for(AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4_il2cpp_TypeInfo_var))->set_m_NullPlayable_1(L_1);
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
// System.Void UnityEngine.AnimatorOverrideController::OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnimatorOverrideController_OnInvalidateOverrideController_m579571520B7C607B6983D4973EBAE982EAC9AA40 (AnimatorOverrideController_t4630AA9761965F735AEB26B9A92D210D6338B2DA * ___controller0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		AnimatorOverrideController_t4630AA9761965F735AEB26B9A92D210D6338B2DA * L_0 = ___controller0;
		NullCheck(L_0);
		OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * L_1 = L_0->get_OnOverrideControllerDirty_4();
		V_0 = (bool)((!(((RuntimeObject*)(OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C *)L_1) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		AnimatorOverrideController_t4630AA9761965F735AEB26B9A92D210D6338B2DA * L_3 = ___controller0;
		NullCheck(L_3);
		OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * L_4 = L_3->get_OnOverrideControllerDirty_4();
		NullCheck(L_4);
		OnOverrideControllerDirtyCallback_Invoke_m21DB79300E852ED93F2521FFC03EC4D858F6B330(L_4, /*hidden argument*/NULL);
	}

IL_001a:
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
// System.Boolean UnityEngine.AnimatorStateInfo::IsName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_IsName_mF1263FB1F2AB142CFEB61B375D6EEBCFD53F9428 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, String_t* ___name0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t G_B4_0 = 0;
	{
		String_t* L_0 = ___name0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		int32_t L_2 = V_0;
		int32_t L_3 = __this->get_m_FullPath_2();
		if ((((int32_t)L_2) == ((int32_t)L_3)))
		{
			goto IL_0025;
		}
	}
	{
		int32_t L_4 = V_0;
		int32_t L_5 = __this->get_m_Name_0();
		if ((((int32_t)L_4) == ((int32_t)L_5)))
		{
			goto IL_0025;
		}
	}
	{
		int32_t L_6 = V_0;
		int32_t L_7 = __this->get_m_Path_1();
		G_B4_0 = ((((int32_t)L_6) == ((int32_t)L_7))? 1 : 0);
		goto IL_0026;
	}

IL_0025:
	{
		G_B4_0 = 1;
	}

IL_0026:
	{
		V_1 = (bool)G_B4_0;
		goto IL_0029;
	}

IL_0029:
	{
		bool L_8 = V_1;
		return L_8;
	}
}
IL2CPP_EXTERN_C  bool AnimatorStateInfo_IsName_mF1263FB1F2AB142CFEB61B375D6EEBCFD53F9428_AdjustorThunk (RuntimeObject * __this, String_t* ___name0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorStateInfo_IsName_mF1263FB1F2AB142CFEB61B375D6EEBCFD53F9428(_thisAdjusted, ___name0, method);
	return _returnValue;
}
// System.Int32 UnityEngine.AnimatorStateInfo::get_fullPathHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_fullPathHash_m296D315AB1FBF6177A423298296CECC1DBA7221D (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_FullPath_2();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorStateInfo_get_fullPathHash_m296D315AB1FBF6177A423298296CECC1DBA7221D_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorStateInfo_get_fullPathHash_m296D315AB1FBF6177A423298296CECC1DBA7221D(_thisAdjusted, method);
	return _returnValue;
}
// System.Int32 UnityEngine.AnimatorStateInfo::get_nameHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_nameHash_mC9F45156C83F42488C753C811229B50E74D97E5E (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_Path_1();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorStateInfo_get_nameHash_mC9F45156C83F42488C753C811229B50E74D97E5E_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorStateInfo_get_nameHash_mC9F45156C83F42488C753C811229B50E74D97E5E(_thisAdjusted, method);
	return _returnValue;
}
// System.Int32 UnityEngine.AnimatorStateInfo::get_shortNameHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_shortNameHash_m03CE17FD0EBFF3C2007407F6B3EE9911923DA998 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_Name_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorStateInfo_get_shortNameHash_m03CE17FD0EBFF3C2007407F6B3EE9911923DA998_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorStateInfo_get_shortNameHash_m03CE17FD0EBFF3C2007407F6B3EE9911923DA998(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorStateInfo::get_normalizedTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_normalizedTime_mC951C5D83749FC2AE37DCC75A022383C578F3B40 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_NormalizedTime_3();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorStateInfo_get_normalizedTime_mC951C5D83749FC2AE37DCC75A022383C578F3B40_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorStateInfo_get_normalizedTime_mC951C5D83749FC2AE37DCC75A022383C578F3B40(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorStateInfo::get_length()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_length_m020815F180AA8D3485CC6AB59A7E596BBA11D6CF (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_Length_4();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorStateInfo_get_length_m020815F180AA8D3485CC6AB59A7E596BBA11D6CF_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorStateInfo_get_length_m020815F180AA8D3485CC6AB59A7E596BBA11D6CF(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorStateInfo::get_speed()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_speed_m1B2CAB95244A0ECCE42F79CCFC22BA7CB8618843 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_Speed_5();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorStateInfo_get_speed_m1B2CAB95244A0ECCE42F79CCFC22BA7CB8618843_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorStateInfo_get_speed_m1B2CAB95244A0ECCE42F79CCFC22BA7CB8618843(_thisAdjusted, method);
	return _returnValue;
}
// System.Single UnityEngine.AnimatorStateInfo::get_speedMultiplier()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AnimatorStateInfo_get_speedMultiplier_m9B6B8F0D9654B51B60E2A3BD01FA4C88FB60B793 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_SpeedMultiplier_6();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		float L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  float AnimatorStateInfo_get_speedMultiplier_m9B6B8F0D9654B51B60E2A3BD01FA4C88FB60B793_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	float _returnValue;
	_returnValue = AnimatorStateInfo_get_speedMultiplier_m9B6B8F0D9654B51B60E2A3BD01FA4C88FB60B793(_thisAdjusted, method);
	return _returnValue;
}
// System.Int32 UnityEngine.AnimatorStateInfo::get_tagHash()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t AnimatorStateInfo_get_tagHash_m9DD7F1BE3041F4B51F624311735C02D77A398A97 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_Tag_7();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  int32_t AnimatorStateInfo_get_tagHash_m9DD7F1BE3041F4B51F624311735C02D77A398A97_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	int32_t _returnValue;
	_returnValue = AnimatorStateInfo_get_tagHash_m9DD7F1BE3041F4B51F624311735C02D77A398A97(_thisAdjusted, method);
	return _returnValue;
}
// System.Boolean UnityEngine.AnimatorStateInfo::IsTag(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_IsTag_m57ADE8725918F9AA03DB5E91EF0301479FF049CA (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, String_t* ___tag0, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		String_t* L_0 = ___tag0;
		int32_t L_1;
		L_1 = Animator_StringToHash_mA351F39D53E2AEFCF0BBD50E4FA92B7E1C99A668(L_0, /*hidden argument*/NULL);
		int32_t L_2 = __this->get_m_Tag_7();
		V_0 = (bool)((((int32_t)L_1) == ((int32_t)L_2))? 1 : 0);
		goto IL_0012;
	}

IL_0012:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool AnimatorStateInfo_IsTag_m57ADE8725918F9AA03DB5E91EF0301479FF049CA_AdjustorThunk (RuntimeObject * __this, String_t* ___tag0, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorStateInfo_IsTag_m57ADE8725918F9AA03DB5E91EF0301479FF049CA(_thisAdjusted, ___tag0, method);
	return _returnValue;
}
// System.Boolean UnityEngine.AnimatorStateInfo::get_loop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool AnimatorStateInfo_get_loop_mC5EDC24973284F2976E57A6558DBD360820FEED0 (AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		int32_t L_0 = __this->get_m_Loop_8();
		V_0 = (bool)((!(((uint32_t)L_0) <= ((uint32_t)0)))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		bool L_1 = V_0;
		return L_1;
	}
}
IL2CPP_EXTERN_C  bool AnimatorStateInfo_get_loop_mC5EDC24973284F2976E57A6558DBD360820FEED0_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA * _thisAdjusted = reinterpret_cast<AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA *>(__this + _offset);
	bool _returnValue;
	_returnValue = AnimatorStateInfo_get_loop_mC5EDC24973284F2976E57A6558DBD360820FEED0(_thisAdjusted, method);
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
// Conversion methods for marshalling of: UnityEngine.AnimatorTransitionInfo
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshal_pinvoke(const AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0& unmarshaled, AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshaled_pinvoke& marshaled)
{
	marshaled.___m_FullPath_0 = unmarshaled.get_m_FullPath_0();
	marshaled.___m_UserName_1 = unmarshaled.get_m_UserName_1();
	marshaled.___m_Name_2 = unmarshaled.get_m_Name_2();
	marshaled.___m_HasFixedDuration_3 = static_cast<int32_t>(unmarshaled.get_m_HasFixedDuration_3());
	marshaled.___m_Duration_4 = unmarshaled.get_m_Duration_4();
	marshaled.___m_NormalizedTime_5 = unmarshaled.get_m_NormalizedTime_5();
	marshaled.___m_AnyState_6 = static_cast<int32_t>(unmarshaled.get_m_AnyState_6());
	marshaled.___m_TransitionType_7 = unmarshaled.get_m_TransitionType_7();
}
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshal_pinvoke_back(const AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshaled_pinvoke& marshaled, AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0& unmarshaled)
{
	int32_t unmarshaled_m_FullPath_temp_0 = 0;
	unmarshaled_m_FullPath_temp_0 = marshaled.___m_FullPath_0;
	unmarshaled.set_m_FullPath_0(unmarshaled_m_FullPath_temp_0);
	int32_t unmarshaled_m_UserName_temp_1 = 0;
	unmarshaled_m_UserName_temp_1 = marshaled.___m_UserName_1;
	unmarshaled.set_m_UserName_1(unmarshaled_m_UserName_temp_1);
	int32_t unmarshaled_m_Name_temp_2 = 0;
	unmarshaled_m_Name_temp_2 = marshaled.___m_Name_2;
	unmarshaled.set_m_Name_2(unmarshaled_m_Name_temp_2);
	bool unmarshaled_m_HasFixedDuration_temp_3 = false;
	unmarshaled_m_HasFixedDuration_temp_3 = static_cast<bool>(marshaled.___m_HasFixedDuration_3);
	unmarshaled.set_m_HasFixedDuration_3(unmarshaled_m_HasFixedDuration_temp_3);
	float unmarshaled_m_Duration_temp_4 = 0.0f;
	unmarshaled_m_Duration_temp_4 = marshaled.___m_Duration_4;
	unmarshaled.set_m_Duration_4(unmarshaled_m_Duration_temp_4);
	float unmarshaled_m_NormalizedTime_temp_5 = 0.0f;
	unmarshaled_m_NormalizedTime_temp_5 = marshaled.___m_NormalizedTime_5;
	unmarshaled.set_m_NormalizedTime_5(unmarshaled_m_NormalizedTime_temp_5);
	bool unmarshaled_m_AnyState_temp_6 = false;
	unmarshaled_m_AnyState_temp_6 = static_cast<bool>(marshaled.___m_AnyState_6);
	unmarshaled.set_m_AnyState_6(unmarshaled_m_AnyState_temp_6);
	int32_t unmarshaled_m_TransitionType_temp_7 = 0;
	unmarshaled_m_TransitionType_temp_7 = marshaled.___m_TransitionType_7;
	unmarshaled.set_m_TransitionType_7(unmarshaled_m_TransitionType_temp_7);
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimatorTransitionInfo
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshal_pinvoke_cleanup(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.AnimatorTransitionInfo
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshal_com(const AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0& unmarshaled, AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshaled_com& marshaled)
{
	marshaled.___m_FullPath_0 = unmarshaled.get_m_FullPath_0();
	marshaled.___m_UserName_1 = unmarshaled.get_m_UserName_1();
	marshaled.___m_Name_2 = unmarshaled.get_m_Name_2();
	marshaled.___m_HasFixedDuration_3 = static_cast<int32_t>(unmarshaled.get_m_HasFixedDuration_3());
	marshaled.___m_Duration_4 = unmarshaled.get_m_Duration_4();
	marshaled.___m_NormalizedTime_5 = unmarshaled.get_m_NormalizedTime_5();
	marshaled.___m_AnyState_6 = static_cast<int32_t>(unmarshaled.get_m_AnyState_6());
	marshaled.___m_TransitionType_7 = unmarshaled.get_m_TransitionType_7();
}
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshal_com_back(const AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshaled_com& marshaled, AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0& unmarshaled)
{
	int32_t unmarshaled_m_FullPath_temp_0 = 0;
	unmarshaled_m_FullPath_temp_0 = marshaled.___m_FullPath_0;
	unmarshaled.set_m_FullPath_0(unmarshaled_m_FullPath_temp_0);
	int32_t unmarshaled_m_UserName_temp_1 = 0;
	unmarshaled_m_UserName_temp_1 = marshaled.___m_UserName_1;
	unmarshaled.set_m_UserName_1(unmarshaled_m_UserName_temp_1);
	int32_t unmarshaled_m_Name_temp_2 = 0;
	unmarshaled_m_Name_temp_2 = marshaled.___m_Name_2;
	unmarshaled.set_m_Name_2(unmarshaled_m_Name_temp_2);
	bool unmarshaled_m_HasFixedDuration_temp_3 = false;
	unmarshaled_m_HasFixedDuration_temp_3 = static_cast<bool>(marshaled.___m_HasFixedDuration_3);
	unmarshaled.set_m_HasFixedDuration_3(unmarshaled_m_HasFixedDuration_temp_3);
	float unmarshaled_m_Duration_temp_4 = 0.0f;
	unmarshaled_m_Duration_temp_4 = marshaled.___m_Duration_4;
	unmarshaled.set_m_Duration_4(unmarshaled_m_Duration_temp_4);
	float unmarshaled_m_NormalizedTime_temp_5 = 0.0f;
	unmarshaled_m_NormalizedTime_temp_5 = marshaled.___m_NormalizedTime_5;
	unmarshaled.set_m_NormalizedTime_5(unmarshaled_m_NormalizedTime_temp_5);
	bool unmarshaled_m_AnyState_temp_6 = false;
	unmarshaled_m_AnyState_temp_6 = static_cast<bool>(marshaled.___m_AnyState_6);
	unmarshaled.set_m_AnyState_6(unmarshaled_m_AnyState_temp_6);
	int32_t unmarshaled_m_TransitionType_temp_7 = 0;
	unmarshaled_m_TransitionType_temp_7 = marshaled.___m_TransitionType_7;
	unmarshaled.set_m_TransitionType_7(unmarshaled_m_TransitionType_temp_7);
}
// Conversion method for clean up from marshalling of: UnityEngine.AnimatorTransitionInfo
IL2CPP_EXTERN_C void AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshal_com_cleanup(AnimatorTransitionInfo_t7D0BAD3D274C055F1FC7ACE0F3A195CA3C9026A0_marshaled_com& marshaled)
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
// System.Void UnityEngine.Avatar::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Avatar__ctor_mCC21D82CD9B57803A22B8A866B1B006DA0CA50BE (Avatar_t1A1B32874530475986346E2EED62F9DDEE8C45C6 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object__ctor_m4DCF5CDB32C2C69290894101A81F473865169279(__this, /*hidden argument*/NULL);
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.HumanBone
IL2CPP_EXTERN_C void HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshal_pinvoke(const HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D& unmarshaled, HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshaled_pinvoke& marshaled)
{
	marshaled.___m_BoneName_0 = il2cpp_codegen_marshal_string(unmarshaled.get_m_BoneName_0());
	marshaled.___m_HumanName_1 = il2cpp_codegen_marshal_string(unmarshaled.get_m_HumanName_1());
	marshaled.___limit_2 = unmarshaled.get_limit_2();
}
IL2CPP_EXTERN_C void HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshal_pinvoke_back(const HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshaled_pinvoke& marshaled, HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D& unmarshaled)
{
	unmarshaled.set_m_BoneName_0(il2cpp_codegen_marshal_string_result(marshaled.___m_BoneName_0));
	unmarshaled.set_m_HumanName_1(il2cpp_codegen_marshal_string_result(marshaled.___m_HumanName_1));
	HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8  unmarshaled_limit_temp_2;
	memset((&unmarshaled_limit_temp_2), 0, sizeof(unmarshaled_limit_temp_2));
	unmarshaled_limit_temp_2 = marshaled.___limit_2;
	unmarshaled.set_limit_2(unmarshaled_limit_temp_2);
}
// Conversion method for clean up from marshalling of: UnityEngine.HumanBone
IL2CPP_EXTERN_C void HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshal_pinvoke_cleanup(HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___m_BoneName_0);
	marshaled.___m_BoneName_0 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___m_HumanName_1);
	marshaled.___m_HumanName_1 = NULL;
}
// Conversion methods for marshalling of: UnityEngine.HumanBone
IL2CPP_EXTERN_C void HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshal_com(const HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D& unmarshaled, HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshaled_com& marshaled)
{
	marshaled.___m_BoneName_0 = il2cpp_codegen_marshal_bstring(unmarshaled.get_m_BoneName_0());
	marshaled.___m_HumanName_1 = il2cpp_codegen_marshal_bstring(unmarshaled.get_m_HumanName_1());
	marshaled.___limit_2 = unmarshaled.get_limit_2();
}
IL2CPP_EXTERN_C void HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshal_com_back(const HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshaled_com& marshaled, HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D& unmarshaled)
{
	unmarshaled.set_m_BoneName_0(il2cpp_codegen_marshal_bstring_result(marshaled.___m_BoneName_0));
	unmarshaled.set_m_HumanName_1(il2cpp_codegen_marshal_bstring_result(marshaled.___m_HumanName_1));
	HumanLimit_t8F488DD21062BE1259B0F4C77E4EB24FB931E8D8  unmarshaled_limit_temp_2;
	memset((&unmarshaled_limit_temp_2), 0, sizeof(unmarshaled_limit_temp_2));
	unmarshaled_limit_temp_2 = marshaled.___limit_2;
	unmarshaled.set_limit_2(unmarshaled_limit_temp_2);
}
// Conversion method for clean up from marshalling of: UnityEngine.HumanBone
IL2CPP_EXTERN_C void HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshal_com_cleanup(HumanBone_tFEE7CD9B6E62BBB95CC4A6F1AA7FC7A26541D62D_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___m_BoneName_0);
	marshaled.___m_BoneName_0 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___m_HumanName_1);
	marshaled.___m_HumanName_1 = NULL;
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
// System.Int32 UnityEngine.HumanTrait::GetBoneIndexFromMono(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t HumanTrait_GetBoneIndexFromMono_m144C635F3328D73F0EFDAE3203B31537B75E1824 (int32_t ___humanId0, const RuntimeMethod* method)
{
	typedef int32_t (*HumanTrait_GetBoneIndexFromMono_m144C635F3328D73F0EFDAE3203B31537B75E1824_ftn) (int32_t);
	static HumanTrait_GetBoneIndexFromMono_m144C635F3328D73F0EFDAE3203B31537B75E1824_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (HumanTrait_GetBoneIndexFromMono_m144C635F3328D73F0EFDAE3203B31537B75E1824_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.HumanTrait::GetBoneIndexFromMono(System.Int32)");
	int32_t icallRetVal = _il2cpp_icall_func(___humanId0);
	return icallRetVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.MatchTargetWeightMask::.ctor(UnityEngine.Vector3,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MatchTargetWeightMask__ctor_mCEB082CDAEDABC6E78F8A239716CABDD4822C1DB (MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positionXYZWeight0, float ___rotationWeight1, const RuntimeMethod* method)
{
	{
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_0 = ___positionXYZWeight0;
		__this->set_m_PositionXYZWeight_0(L_0);
		float L_1 = ___rotationWeight1;
		__this->set_m_RotationWeight_1(L_1);
		return;
	}
}
IL2CPP_EXTERN_C  void MatchTargetWeightMask__ctor_mCEB082CDAEDABC6E78F8A239716CABDD4822C1DB_AdjustorThunk (RuntimeObject * __this, Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positionXYZWeight0, float ___rotationWeight1, const RuntimeMethod* method)
{
	int32_t _offset = 1;
	MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 * _thisAdjusted = reinterpret_cast<MatchTargetWeightMask_tE266884358C7F63F63791A1433F184729E0D8DB6 *>(__this + _offset);
	MatchTargetWeightMask__ctor_mCEB082CDAEDABC6E78F8A239716CABDD4822C1DB(_thisAdjusted, ___positionXYZWeight0, ___rotationWeight1, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Motion::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Motion__ctor_mDC0BDF6F52E99C4A69EFDAC157CC29D0C1A4F9E6 (Motion_t3EAEF01D52B05F10A21CC9B54A35C8F3F6BA3A67 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object__ctor_m4DCF5CDB32C2C69290894101A81F473865169279(__this, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Animations.NotKeyableAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotKeyableAttribute__ctor_m98269306D3337B28D7E5E55C84B2F6304EBFE507 (NotKeyableAttribute_tE0C94B5FF990C6B4BB118486BCA35CCDA91AA905 * __this, const RuntimeMethod* method)
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.RuntimeAnimatorController::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeAnimatorController__ctor_m974DD22EB55FCAE168AE41718C2BD48B008C7CB3 (RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object__ctor_m4DCF5CDB32C2C69290894101A81F473865169279(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.AnimationClip[] UnityEngine.RuntimeAnimatorController::get_animationClips()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR AnimationClipU5BU5D_t93D1A9ADEC832A4EABC0353D9E4E435B22B28489* RuntimeAnimatorController_get_animationClips_m588DD185B33BC0189878699FEE130C59984FE462 (RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB * __this, const RuntimeMethod* method)
{
	typedef AnimationClipU5BU5D_t93D1A9ADEC832A4EABC0353D9E4E435B22B28489* (*RuntimeAnimatorController_get_animationClips_m588DD185B33BC0189878699FEE130C59984FE462_ftn) (RuntimeAnimatorController_t6F70D5BE51CCBA99132F444EFFA41439DFE71BAB *);
	static RuntimeAnimatorController_get_animationClips_m588DD185B33BC0189878699FEE130C59984FE462_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (RuntimeAnimatorController_get_animationClips_m588DD185B33BC0189878699FEE130C59984FE462_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.RuntimeAnimatorController::get_animationClips()");
	AnimationClipU5BU5D_t93D1A9ADEC832A4EABC0353D9E4E435B22B28489* icallRetVal = _il2cpp_icall_func(__this);
	return icallRetVal;
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
// Conversion methods for marshalling of: UnityEngine.SkeletonBone
IL2CPP_EXTERN_C void SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshal_pinvoke(const SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E& unmarshaled, SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshaled_pinvoke& marshaled)
{
	marshaled.___name_0 = il2cpp_codegen_marshal_string(unmarshaled.get_name_0());
	marshaled.___parentName_1 = il2cpp_codegen_marshal_string(unmarshaled.get_parentName_1());
	marshaled.___position_2 = unmarshaled.get_position_2();
	marshaled.___rotation_3 = unmarshaled.get_rotation_3();
	marshaled.___scale_4 = unmarshaled.get_scale_4();
}
IL2CPP_EXTERN_C void SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshal_pinvoke_back(const SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshaled_pinvoke& marshaled, SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E& unmarshaled)
{
	unmarshaled.set_name_0(il2cpp_codegen_marshal_string_result(marshaled.___name_0));
	unmarshaled.set_parentName_1(il2cpp_codegen_marshal_string_result(marshaled.___parentName_1));
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  unmarshaled_position_temp_2;
	memset((&unmarshaled_position_temp_2), 0, sizeof(unmarshaled_position_temp_2));
	unmarshaled_position_temp_2 = marshaled.___position_2;
	unmarshaled.set_position_2(unmarshaled_position_temp_2);
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  unmarshaled_rotation_temp_3;
	memset((&unmarshaled_rotation_temp_3), 0, sizeof(unmarshaled_rotation_temp_3));
	unmarshaled_rotation_temp_3 = marshaled.___rotation_3;
	unmarshaled.set_rotation_3(unmarshaled_rotation_temp_3);
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  unmarshaled_scale_temp_4;
	memset((&unmarshaled_scale_temp_4), 0, sizeof(unmarshaled_scale_temp_4));
	unmarshaled_scale_temp_4 = marshaled.___scale_4;
	unmarshaled.set_scale_4(unmarshaled_scale_temp_4);
}
// Conversion method for clean up from marshalling of: UnityEngine.SkeletonBone
IL2CPP_EXTERN_C void SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshal_pinvoke_cleanup(SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshaled_pinvoke& marshaled)
{
	il2cpp_codegen_marshal_free(marshaled.___name_0);
	marshaled.___name_0 = NULL;
	il2cpp_codegen_marshal_free(marshaled.___parentName_1);
	marshaled.___parentName_1 = NULL;
}
// Conversion methods for marshalling of: UnityEngine.SkeletonBone
IL2CPP_EXTERN_C void SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshal_com(const SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E& unmarshaled, SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshaled_com& marshaled)
{
	marshaled.___name_0 = il2cpp_codegen_marshal_bstring(unmarshaled.get_name_0());
	marshaled.___parentName_1 = il2cpp_codegen_marshal_bstring(unmarshaled.get_parentName_1());
	marshaled.___position_2 = unmarshaled.get_position_2();
	marshaled.___rotation_3 = unmarshaled.get_rotation_3();
	marshaled.___scale_4 = unmarshaled.get_scale_4();
}
IL2CPP_EXTERN_C void SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshal_com_back(const SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshaled_com& marshaled, SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E& unmarshaled)
{
	unmarshaled.set_name_0(il2cpp_codegen_marshal_bstring_result(marshaled.___name_0));
	unmarshaled.set_parentName_1(il2cpp_codegen_marshal_bstring_result(marshaled.___parentName_1));
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  unmarshaled_position_temp_2;
	memset((&unmarshaled_position_temp_2), 0, sizeof(unmarshaled_position_temp_2));
	unmarshaled_position_temp_2 = marshaled.___position_2;
	unmarshaled.set_position_2(unmarshaled_position_temp_2);
	Quaternion_t6D28618CF65156D4A0AD747370DDFD0C514A31B4  unmarshaled_rotation_temp_3;
	memset((&unmarshaled_rotation_temp_3), 0, sizeof(unmarshaled_rotation_temp_3));
	unmarshaled_rotation_temp_3 = marshaled.___rotation_3;
	unmarshaled.set_rotation_3(unmarshaled_rotation_temp_3);
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  unmarshaled_scale_temp_4;
	memset((&unmarshaled_scale_temp_4), 0, sizeof(unmarshaled_scale_temp_4));
	unmarshaled_scale_temp_4 = marshaled.___scale_4;
	unmarshaled.set_scale_4(unmarshaled_scale_temp_4);
}
// Conversion method for clean up from marshalling of: UnityEngine.SkeletonBone
IL2CPP_EXTERN_C void SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshal_com_cleanup(SkeletonBone_t0AD95EAD0BE7D2EC13B2C7505225D340CB456A9E_marshaled_com& marshaled)
{
	il2cpp_codegen_marshal_free_bstring(marshaled.___name_0);
	marshaled.___name_0 = NULL;
	il2cpp_codegen_marshal_free_bstring(marshaled.___parentName_1);
	marshaled.___parentName_1 = NULL;
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
// System.Void UnityEngine.StateMachineBehaviour::OnStateEnter(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateEnter_m0B5055A01EEF9070E7611D3C3165AAA118D22953 (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateUpdate(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateUpdate_m2FF9D5AD07DF99860C7B0033791FE08F2EF919F1 (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateExit(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateExit_mE8EADFCEA482A101BF13AFB773A06C3C2C8B3208 (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMove(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMove_mB51A6EA16DA5038BF7C4E46863C8ECA1338EFBDD (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateIK(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateIK_m2BB5A0CD4B083CCDFAC7EE2F8233D2B11825197F (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMachineEnter(UnityEngine.Animator,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMachineEnter_m8696CC6EE9DC7577A07023F84DCF6E4F80E75ACC (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, int32_t ___stateMachinePathHash1, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMachineExit(UnityEngine.Animator,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMachineExit_m7FD170C30229751A93F64C26AFFF9C9BA057BF3D (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, int32_t ___stateMachinePathHash1, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateEnter(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateEnter_m0027D5548D58C0E2777A4CF9420F015FD56CEC18 (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___controller3, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateUpdate(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateUpdate_mF81F7D0AB02EB31012A7C50E75295C40301A5055 (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___controller3, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateExit(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateExit_m795DAE1099CF045D5E61ABBBAD017455F48B0707 (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___controller3, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMove(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMove_m29F850CE0258906408520515E4E157D43AFEB181 (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___controller3, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateIK(UnityEngine.Animator,UnityEngine.AnimatorStateInfo,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateIK_m96E18AE1A75046F85EB7FEB5C05CEC7377F72C1F (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, AnimatorStateInfo_t052E146D2DB1EC155950ECA45734BF57134258AA  ___stateInfo1, int32_t ___layerIndex2, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___controller3, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMachineEnter(UnityEngine.Animator,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMachineEnter_mF2DF6E7A25D30F05E99984F3E8D4083D695F23CA (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, int32_t ___stateMachinePathHash1, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___controller2, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::OnStateMachineExit(UnityEngine.Animator,System.Int32,UnityEngine.Animations.AnimatorControllerPlayable)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour_OnStateMachineExit_m8AC70A1160FE329D0E1EC31F08B1E85B59DB516D (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, Animator_t9DD1D43680A61D65A3C98C6EFF559709DC9CE149 * ___animator0, int32_t ___stateMachinePathHash1, AnimatorControllerPlayable_tEABD56FA5A36BD337DA6E049FCB4F1D521DA17A4  ___controller2, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.StateMachineBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StateMachineBehaviour__ctor_mDB0650FD738799E5880150E656D4A88524D0EBE0 (StateMachineBehaviour_tBEDE439261DEB4C7334646339BC6F1E7958F095F * __this, const RuntimeMethod* method)
{
	{
		ScriptableObject__ctor_m8DAE6CDCFA34E16F2543B02CC3669669FF203063(__this, /*hidden argument*/NULL);
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
// System.Void UnityEngine.Animation/Enumerator::.ctor(UnityEngine.Animation)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator__ctor_mC97A2B142004D7B757AAF61F6F069FB102372DBA (Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5 * __this, Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * ___outer0, const RuntimeMethod* method)
{
	{
		__this->set_m_CurrentIndex_1((-1));
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * L_0 = ___outer0;
		__this->set_m_Outer_0(L_0);
		return;
	}
}
// System.Object UnityEngine.Animation/Enumerator::get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_mAB7913C42CA7EB7EFE4AE1F7B9BEAA6B5F44C1A9 (Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5 * __this, const RuntimeMethod* method)
{
	RuntimeObject * V_0 = NULL;
	{
		Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * L_0 = __this->get_m_Outer_0();
		int32_t L_1 = __this->get_m_CurrentIndex_1();
		NullCheck(L_0);
		AnimationState_tDB7088046A65ABCEC66B45147693CA0AD803A3AD * L_2;
		L_2 = Animation_GetStateAtIndex_m436707B278555E5B3AD4FB8F7B1A04F532CDC679(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0015;
	}

IL_0015:
	{
		RuntimeObject * L_3 = V_0;
		return L_3;
	}
}
// System.Boolean UnityEngine.Animation/Enumerator::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m46EE9A2B09C10531425A6CFA6FD305CCDB4B3101 (Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		Animation_t8C4FD9513E57F59E8737AD03938AAAF9EFF2F0D8 * L_0 = __this->get_m_Outer_0();
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Animation_GetStateCount_mBFB004C6182E7243A2DFA09D7E378A94AC61AABA(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		int32_t L_2 = __this->get_m_CurrentIndex_1();
		__this->set_m_CurrentIndex_1(((int32_t)il2cpp_codegen_add((int32_t)L_2, (int32_t)1)));
		int32_t L_3 = __this->get_m_CurrentIndex_1();
		int32_t L_4 = V_0;
		V_1 = (bool)((((int32_t)L_3) < ((int32_t)L_4))? 1 : 0);
		goto IL_0027;
	}

IL_0027:
	{
		bool L_5 = V_1;
		return L_5;
	}
}
// System.Void UnityEngine.Animation/Enumerator::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Enumerator_Reset_mFC24132D3D5F334C8892F799D3B8B92971CBE6C0 (Enumerator_tD70E33E0A88A86F184E3CA32E532974A65CA2FC5 * __this, const RuntimeMethod* method)
{
	{
		__this->set_m_CurrentIndex_1((-1));
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
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C (OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(((RuntimeDelegate*)__this)->method->nativeFunction);

	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnOverrideControllerDirtyCallback__ctor_mA35F55BEB8A4BD57D109684E857F85C1F0A6C1B5 (OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnOverrideControllerDirtyCallback_Invoke_m21DB79300E852ED93F2521FFC03EC4D858F6B330 (OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * __this, const RuntimeMethod* method)
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
// System.IAsyncResult UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* OnOverrideControllerDirtyCallback_BeginInvoke_m40D5810BF8C5066DB2C7987E7C76FD23D2AC47E3 (OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * __this, AsyncCallback_tA7921BEF974919C46FF8F9D9867C567B200BB0EA * ___callback0, RuntimeObject * ___object1, const RuntimeMethod* method)
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);;
}
// System.Void UnityEngine.AnimatorOverrideController/OnOverrideControllerDirtyCallback::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void OnOverrideControllerDirtyCallback_EndInvoke_mAF3C7805FADE63999DC2121032B11DF86668E9F4 (OnOverrideControllerDirtyCallback_t9E38572D7CF06EEFF943EA68082DAC68AB40476C * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
